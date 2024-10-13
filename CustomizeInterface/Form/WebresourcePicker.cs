using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;

namespace Customizer.Forms
{
    public partial class WebresourcePicker : Form
    {
        private readonly IOrganizationService _Service;
        private EntityCollection _webresources;

        public WebresourcePicker(IOrganizationService service)
        {
            InitializeComponent();
            _Service = service;
        }

        public Entity SelectedWebresource { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SelectedWebresource = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lvWebresource.SelectedItems.Count > 0)
            {
                SelectedWebresource = lvWebresource.SelectedItems.Cast<ListViewItem>().Select(i => (Entity)i.Tag).FirstOrDefault();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show(this, "Please select at least one solution!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // function to sort the listview
        //private void lstWebresource_ColumnClick(object sender, ColumnClickEventArgs e)
        //{
        //    //var list = (ListView)sender;
        //    //list.Sorting = list.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
        //    //list.ListViewItemSorter = new ListViewItemComparer(e.Column, list.Sorting);
        //}

        private void lstWebresource_DoubleClick(object sender, EventArgs e)
        {
            btnOk_Click(null, null);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            lvWebresource.Items.Clear();

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += GetWebresources;
            worker.RunWorkerCompleted += DisplayWebresources;
            worker.RunWorkerAsync();
        }

        private void GetWebresources(object sender, DoWorkEventArgs e)
        {
            try
            {
                QueryExpression queryWebresource = new QueryExpression("webresource");
                queryWebresource.ColumnSet.AddColumns("displayname", "name");
                queryWebresource.Criteria.AddCondition("ismanaged", ConditionOperator.Equal, false);
                queryWebresource.Criteria.AddCondition("webresourcetype", ConditionOperator.Equal, 4);
                _webresources = _Service.RetrieveMultiple(queryWebresource);
                if (_webresources == null || _webresources.Entities.Count == 0)
                    MessageBox.Show(this, "There is no unmanaged and XML type webresource.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception error)
            {
                if (error.InnerException is FaultException)
                {
                    throw new Exception("Error while retrieving solutions: " + (error.InnerException).Message);
                }

                throw new Exception("Error while retrieving solutions: " + error.Message);
            }
        }

        private void DisplayWebresources(object sender, RunWorkerCompletedEventArgs e)
        {
            lvWebresource.Items.Clear();
            _webresources.Entities.ToList().ForEach(webresource =>
            {
                ListViewItem item = new ListViewItem(webresource["displayname"].ToString());
                item.SubItems.Add(webresource["name"].ToString());
                item.Tag = webresource;
                lvWebresource.Items.Add(item);
            });
            lvWebresource.Enabled = true;
            btnOK.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}