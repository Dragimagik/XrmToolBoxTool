using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using XrmToolBox.Extensibility;

namespace Customizer
{
    public partial class ThemeCustomizer : PluginControlBase
    {
        private Settings mySettings;
        private Entity _webresource;

        public ThemeCustomizer()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();
                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
                LogInfo("Settings found and loaded");
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            ExecuteMethod(save);
        }

        private void save()
        {

            List<TextBox> textBoxes = new List<TextBox>
            {
                tbBackground,
                tbForeground,
                tbBackgroundHover,
                tbForegroundHover,
                tbBackgroundPressed,
                tbForegroundPressed,
                tbBackgroundSelected,
                tbForegroundSelected
            };
            textBoxes.ForEach(textBox =>
            {
                if (!checkFormat(textBox.Text))
                    errorProvider.SetError(textBox, "Invalid color format");
                else
                    errorProvider.SetError(textBox, "");
            });

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Save your personalization",
                Work = (worker, args) =>
                {
                    QueryExpression querySettingDefinition = new QueryExpression("settingdefinition");
                    querySettingDefinition.ColumnSet.AddColumns("displayname", "datatype", "defaultvalue");
                    querySettingDefinition.Criteria.AddCondition("uniquename", ConditionOperator.Equal, "OverrideAppHeaderColor");
                    Entity settingOverrideAppHeaderColor = Service.RetrieveMultiple(querySettingDefinition).Entities.FirstOrDefault();
                    if (settingOverrideAppHeaderColor == null)
                        throw new Exception("Cannot find the customisation setting");
                    Entity webresourceCustomization = (_webresource == null) ? _webresource : Service.Retrieve(_webresource.LogicalName, _webresource.Id, new ColumnSet("name", "content"));
                    string webresourceName = tbWebresourceName.Text;
                    string encodedContent = Convert.ToBase64String(Encoding.UTF8.GetBytes($"<AppHeaderColors background=\"{tbBackground.Text}\" foreground=\"{tbForeground.Text}\" backgroundHover=\"{tbBackgroundHover.Text}\" foregroundHover=\"{tbForegroundHover.Text}\" backgroundPressed=\"{tbBackgroundPressed.Text}\" foregroundPressed=\"{tbForegroundPressed.Text}\" backgroundSelected=\"{tbBackgroundSelected.Text}\" foregroundSelected=\"{tbForegroundSelected.Text}\"  />"));
                    if (webresourceCustomization == null)
                    {
                        webresourceCustomization = new Entity("webresource");
                        webresourceCustomization["name"] = webresourceName;
                        webresourceCustomization["webresourcetype"] = new OptionSetValue(4);
                        webresourceCustomization["content"] = encodedContent;
                        Guid webressourceId = Service.Create(webresourceCustomization);
                    }
                    else
                    {
                        webresourceCustomization = new Entity(webresourceCustomization.LogicalName, webresourceCustomization.Id);
                        bool tryName = webresourceCustomization.TryGetAttributeValue("name", out string webressourceName);
                        webresourceCustomization["content"] = encodedContent;
                        Service.Update(webresourceCustomization);
                    }

                    if (webresourceName == string.Empty)
                        throw new Exception("Cannot find the name of the webressource");
                    QueryExpression queryOrganizationSetting = new QueryExpression("organizationsetting");
                    queryOrganizationSetting.TopCount = 3;
                    queryOrganizationSetting.ColumnSet.AddColumn("value");
                    queryOrganizationSetting.Criteria.AddCondition("settingdefinitionid", ConditionOperator.Equal, settingOverrideAppHeaderColor.Id);
                    Entity organizationSettingOverrideAppHeaderColor = Service.RetrieveMultiple(queryOrganizationSetting).Entities.FirstOrDefault();
                    if (organizationSettingOverrideAppHeaderColor == null)
                    {
                        organizationSettingOverrideAppHeaderColor = new Entity("organizationsetting");
                        organizationSettingOverrideAppHeaderColor["value"] = webresourceName; // Text
                        organizationSettingOverrideAppHeaderColor["settingdefinitionid"] = settingOverrideAppHeaderColor.ToEntityReference(); // Lookup
                        Service.Create(organizationSettingOverrideAppHeaderColor);
                    }
                    else
                    {
                        organizationSettingOverrideAppHeaderColor["value"] = webresourceName;
                        Service.Update(organizationSettingOverrideAppHeaderColor);
                    }
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }

        //private void tsbApply_Click(object sender, EventArgs e)
        //{
        //    ExecuteMethod(Apply);
        //}

        //private void Apply()
        //{
        //    WorkAsync(new WorkAsyncInfo
        //    {
        //        Message = "Save",
        //        Work = (worker, args) =>
        //        {
        //            QueryExpression query = new QueryExpression("settingdefinition");
        //            query.Criteria.AddCondition("uniquename", ConditionOperator.Equal, "OverrideAppHeaderColor");
        //            args.Result = Service.RetrieveMultiple(query);
        //        },
        //        PostWorkCallBack = (args) =>
        //        {
        //            if (args.Error != null)
        //                MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            EntityCollection settings = args.Result as EntityCollection;
        //            if (settings == null || settings.Entities.Count == 0)
        //                MessageBox.Show("Cannot find the customisation setting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            Entity setting = settings.Entities.FirstOrDefault();
        //            bool tryDefaultValue = setting.TryGetAttributeValue("defaultvalue", out string webressoureceName);
        //            if (tryDefaultValue)
        //                if (webressoureceName == "customWebressoure") return;
        //            Entity newSetting = new Entity(setting.LogicalName, setting.Id);
        //            newSetting["defaultvalue"] = "customWebressoure";
        //            Service.Update(newSetting);
        //        }
        //    });
        //}

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            ExecuteMethod(searchWebresource);
        }

        private void searchWebresource()
        {
            Entity webresource = new Entity();
            var dialog = new Forms.WebresourcePicker(Service);
            if (dialog.ShowDialog(this) == DialogResult.OK)
                _webresource = dialog.SelectedWebresource;
            else
            {
                tbWebresourceName.Enabled = true;
                return;
            }
            if (_webresource != null)
                tbWebresourceName.Enabled = false;
            else
            {
                tbWebresourceName.Enabled = true;
                return;
            }

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting Customization",
                Work = (worker, args) =>
                {
                    args.Result = Service.Retrieve(_webresource.LogicalName, _webresource.Id, new ColumnSet("name", "content"));
                },
                PostWorkCallBack = (args) =>
                {
                    Entity webressource = args.Result as Entity;
                    if (webressource == null)
                        //MessageBox.Show("Cannot find the webressource", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    bool tryName = webressource.TryGetAttributeValue("name", out string webressourceName);
                    if (tryName)
                        tbWebresourceName.Text = webressourceName;
                    bool tryContent = webressource.TryGetAttributeValue("content", out string webressourceContent);
                    if (!tryContent)
                        return;
                    string content = UnicodeEncoding.UTF8.GetString(Convert.FromBase64String(webressourceContent));
                    if (content == string.Empty)
                        return;
                    else
                    {
                        XDocument xmlContent = XDocument.Parse(content);
                        if (!xmlContent.Root.HasAttributes)
                            return;
                        xmlContent.Root.Attributes().ToList().ForEach(attribute =>
                        {
                            Color color = ColorTranslator.FromHtml(attribute.Value);
                            switch (attribute.Name.ToString())
                            {
                                // add to eqach case the BackColor property and define it with color;
                                case "background":
                                    tbBackground.Text = attribute.Value;
                                    tbBackground.BackColor = color;
                                    break;
                                case "foreground":
                                    tbForeground.Text = attribute.Value;
                                    tbForeground.BackColor = color;
                                    break;
                                case "backgroundHover":
                                    tbBackgroundHover.Text = attribute.Value;
                                    tbBackgroundHover.BackColor = color;
                                    break;
                                case "foregroundHover":
                                    tbForegroundHover.Text = attribute.Value;
                                    tbForegroundHover.BackColor = color;
                                    break;
                                case "backgroundPressed":
                                    tbBackgroundPressed.Text = attribute.Value;
                                    tbBackgroundPressed.BackColor = color;
                                    break;
                                case "foregroundPressed":
                                    tbForegroundPressed.Text = attribute.Value;
                                    tbForegroundPressed.BackColor = color;
                                    break;
                                case "backgroundSelected":
                                    tbBackgroundSelected.Text = attribute.Value;
                                    tbBackgroundSelected.BackColor = color;
                                    break;
                                case "foregroundSelected":
                                    tbForegroundSelected.Text = attribute.Value;
                                    tbForegroundSelected.BackColor = color;
                                    break;
                                default:
                                    break;
                            }
                        });
                    }
                }
            });
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClose(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }


        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;
            string color = ColorTranslator.ToHtml(Color.FromArgb(colorDialog.Color.ToArgb()));
            TextBox textBox = getTextBoxOfColorPicker(sender);
            textBox.Text = formatColor(color);
            textBox.BackColor = colorDialog.Color;
        }

        private TextBox getTextBoxOfColorPicker(object sender)
        {
            Button button = sender as Button;
            string colorName = button.Name.Replace("bColorPicker", "");
            return this.Controls.Find($"tb{colorName}", true).FirstOrDefault() as TextBox;
        }

        private void checkFormat_Change(object sender, EventArgs e)
        {

        }

        private void textBox_Validating(object sender,
                System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (checkFormat(textBox.Text))
                return;
            e.Cancel = true;
            //textBox.Select(0, textBox.Text.Length);
            this.errorProvider.SetError(textBox, "Incorrect color format");
        }

        private void textBox_Validated(object sender, System.EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            this.errorProvider.SetError(textBox, "");
        }

        private bool checkFormat(string input)
        {
            Regex regex = new Regex(@"^[#]?[0-9a-fA-F]{6}$");
            return regex.IsMatch(input);
        }

        private string formatColor(string input)
        {
            if (input.StartsWith("#"))
                return input;
            return $"#{input}";
        }
    }
}