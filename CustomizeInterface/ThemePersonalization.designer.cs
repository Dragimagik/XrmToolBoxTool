namespace ThemePersonalizer
{
    partial class ThemePersonalization
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemePersonalization));
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsSeparatorSave = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsSeparatorSearch = new System.Windows.Forms.ToolStripSeparator();
            this.tbsSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.gbColorProperties = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tbBackgroundHover = new System.Windows.Forms.TextBox();
            this.lBackgroundHover = new System.Windows.Forms.Label();
            this.lForeground = new System.Windows.Forms.Label();
            this.tbWebresourceName = new System.Windows.Forms.TextBox();
            this.lBackground = new System.Windows.Forms.Label();
            this.tbBackground = new System.Windows.Forms.TextBox();
            this.tbForeground = new System.Windows.Forms.TextBox();
            this.tbForegroundHover = new System.Windows.Forms.TextBox();
            this.lForegroundHover = new System.Windows.Forms.Label();
            this.tbBackgroundPressed = new System.Windows.Forms.TextBox();
            this.lBackgroundPressed = new System.Windows.Forms.Label();
            this.tbForegroundPressed = new System.Windows.Forms.TextBox();
            this.lForegroundPressed = new System.Windows.Forms.Label();
            this.tbBackgroundSelected = new System.Windows.Forms.TextBox();
            this.lBackgroundSelected = new System.Windows.Forms.Label();
            this.tbForegroundSelected = new System.Windows.Forms.TextBox();
            this.lForegroundSelected = new System.Windows.Forms.Label();
            this.lOrgSetting = new System.Windows.Forms.Label();
            this.lWebresourceName = new System.Windows.Forms.Label();
            this.lInformations = new System.Windows.Forms.Label();
            this.bColorPickerBackground = new System.Windows.Forms.Button();
            this.bColorPickerForeground = new System.Windows.Forms.Button();
            this.bColorPickerBackgroundHover = new System.Windows.Forms.Button();
            this.bColorPickerForegroundHover = new System.Windows.Forms.Button();
            this.bColorPickerBackgroundPressed = new System.Windows.Forms.Button();
            this.bColorPickerForegroundPressed = new System.Windows.Forms.Button();
            this.bColorPickerBackgroundSelected = new System.Windows.Forms.Button();
            this.bColorPickerForegroundSelected = new System.Windows.Forms.Button();
            this.cbOrgSetting = new System.Windows.Forms.CheckBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripMenu.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.gbColorProperties.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(40, 28);
            this.tsbClose.Text = "Close";
            this.tsbClose.Visible = false;
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tsSeparatorSave
            // 
            this.tsSeparatorSave.Name = "tsSeparatorSave";
            this.tsSeparatorSave.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(59, 28);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tsSeparatorSearch,
            this.tbsSearch,
            this.tsSeparatorSave,
            this.tsbSave,
            this.toolStripButton1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(654, 31);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsSeparatorSearch
            // 
            this.tsSeparatorSearch.Name = "tsSeparatorSearch";
            this.tsSeparatorSearch.Size = new System.Drawing.Size(6, 31);
            this.tsSeparatorSearch.Visible = false;
            // 
            // tbsSearch
            // 
            this.tbsSearch.Image = ((System.Drawing.Image)(resources.GetObject("tbsSearch.Image")));
            this.tbsSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsSearch.Name = "tbsSearch";
            this.tbsSearch.Size = new System.Drawing.Size(70, 28);
            this.tbsSearch.Text = "Search";
            this.tbsSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(42, 28);
            this.toolStripButton1.Text = "Apply";
            this.toolStripButton1.Visible = false;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(314, 198);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.gbColorProperties);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(654, 378);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 31);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(654, 378);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // gbColorProperties
            // 
            this.gbColorProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbColorProperties.Controls.Add(this.tableLayoutPanel);
            this.gbColorProperties.Location = new System.Drawing.Point(0, 3);
            this.gbColorProperties.Name = "gbColorProperties";
            this.gbColorProperties.Size = new System.Drawing.Size(654, 375);
            this.gbColorProperties.TabIndex = 0;
            this.gbColorProperties.TabStop = false;
            this.gbColorProperties.Text = "Color properties ";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.tbBackgroundHover, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.lBackgroundHover, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.lForeground, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.tbWebresourceName, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lBackground, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.tbBackground, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.tbForeground, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.tbForegroundHover, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.lForegroundHover, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.tbBackgroundPressed, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.lBackgroundPressed, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.tbForegroundPressed, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.lForegroundPressed, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.tbBackgroundSelected, 1, 8);
            this.tableLayoutPanel.Controls.Add(this.lBackgroundSelected, 0, 8);
            this.tableLayoutPanel.Controls.Add(this.tbForegroundSelected, 1, 9);
            this.tableLayoutPanel.Controls.Add(this.lForegroundSelected, 0, 9);
            this.tableLayoutPanel.Controls.Add(this.lOrgSetting, 0, 10);
            this.tableLayoutPanel.Controls.Add(this.lWebresourceName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lInformations, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.bColorPickerBackground, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.bColorPickerForeground, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.bColorPickerBackgroundHover, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.bColorPickerForegroundHover, 2, 5);
            this.tableLayoutPanel.Controls.Add(this.bColorPickerBackgroundPressed, 2, 6);
            this.tableLayoutPanel.Controls.Add(this.bColorPickerForegroundPressed, 2, 7);
            this.tableLayoutPanel.Controls.Add(this.bColorPickerBackgroundSelected, 2, 8);
            this.tableLayoutPanel.Controls.Add(this.bColorPickerForegroundSelected, 2, 9);
            this.tableLayoutPanel.Controls.Add(this.cbOrgSetting, 1, 10);
            this.tableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 11;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(642, 278);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_Paint);
            // 
            // tbBackgroundHover
            // 
            this.tbBackgroundHover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBackgroundHover.Location = new System.Drawing.Point(318, 87);
            this.tbBackgroundHover.Name = "tbBackgroundHover";
            this.tbBackgroundHover.Size = new System.Drawing.Size(208, 20);
            this.tbBackgroundHover.TabIndex = 7;
            this.tbBackgroundHover.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.tbBackgroundHover.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // lBackgroundHover
            // 
            this.lBackgroundHover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBackgroundHover.AutoSize = true;
            this.lBackgroundHover.Location = new System.Drawing.Point(3, 84);
            this.lBackgroundHover.Name = "lBackgroundHover";
            this.lBackgroundHover.Size = new System.Drawing.Size(309, 29);
            this.lBackgroundHover.TabIndex = 6;
            this.lBackgroundHover.Text = "Background hover";
            this.lBackgroundHover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lForeground
            // 
            this.lForeground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lForeground.AutoSize = true;
            this.lForeground.Location = new System.Drawing.Point(3, 55);
            this.lForeground.Name = "lForeground";
            this.lForeground.Size = new System.Drawing.Size(309, 29);
            this.lForeground.TabIndex = 5;
            this.lForeground.Text = "Foreground";
            this.lForeground.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbWebresourceName
            // 
            this.tbWebresourceName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWebresourceName.Location = new System.Drawing.Point(318, 3);
            this.tbWebresourceName.MaxLength = 0;
            this.tbWebresourceName.Name = "tbWebresourceName";
            this.tbWebresourceName.Size = new System.Drawing.Size(208, 20);
            this.tbWebresourceName.TabIndex = 3;
            // 
            // lBackground
            // 
            this.lBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBackground.AutoSize = true;
            this.lBackground.Location = new System.Drawing.Point(3, 26);
            this.lBackground.Name = "lBackground";
            this.lBackground.Size = new System.Drawing.Size(309, 29);
            this.lBackground.TabIndex = 0;
            this.lBackground.Text = "Background";
            this.lBackground.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbBackground
            // 
            this.tbBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBackground.Location = new System.Drawing.Point(318, 29);
            this.tbBackground.Name = "tbBackground";
            this.tbBackground.Size = new System.Drawing.Size(208, 20);
            this.tbBackground.TabIndex = 1;
            this.tbBackground.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.tbBackground.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // tbForeground
            // 
            this.tbForeground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbForeground.Location = new System.Drawing.Point(318, 58);
            this.tbForeground.Name = "tbForeground";
            this.tbForeground.Size = new System.Drawing.Size(208, 20);
            this.tbForeground.TabIndex = 4;
            this.tbForeground.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.tbForeground.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // tbForegroundHover
            // 
            this.tbForegroundHover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbForegroundHover.Location = new System.Drawing.Point(318, 116);
            this.tbForegroundHover.Name = "tbForegroundHover";
            this.tbForegroundHover.Size = new System.Drawing.Size(208, 20);
            this.tbForegroundHover.TabIndex = 9;
            this.tbForegroundHover.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.tbForegroundHover.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // lForegroundHover
            // 
            this.lForegroundHover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lForegroundHover.AutoSize = true;
            this.lForegroundHover.Location = new System.Drawing.Point(3, 113);
            this.lForegroundHover.Name = "lForegroundHover";
            this.lForegroundHover.Size = new System.Drawing.Size(309, 29);
            this.lForegroundHover.TabIndex = 8;
            this.lForegroundHover.Text = "Foreground hover";
            this.lForegroundHover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbBackgroundPressed
            // 
            this.tbBackgroundPressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBackgroundPressed.Location = new System.Drawing.Point(318, 145);
            this.tbBackgroundPressed.Name = "tbBackgroundPressed";
            this.tbBackgroundPressed.Size = new System.Drawing.Size(208, 20);
            this.tbBackgroundPressed.TabIndex = 11;
            this.tbBackgroundPressed.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.tbBackgroundPressed.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // lBackgroundPressed
            // 
            this.lBackgroundPressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBackgroundPressed.AutoSize = true;
            this.lBackgroundPressed.Location = new System.Drawing.Point(3, 142);
            this.lBackgroundPressed.Name = "lBackgroundPressed";
            this.lBackgroundPressed.Size = new System.Drawing.Size(309, 29);
            this.lBackgroundPressed.TabIndex = 10;
            this.lBackgroundPressed.Text = "Background pressed";
            this.lBackgroundPressed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbForegroundPressed
            // 
            this.tbForegroundPressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbForegroundPressed.Location = new System.Drawing.Point(318, 174);
            this.tbForegroundPressed.Name = "tbForegroundPressed";
            this.tbForegroundPressed.Size = new System.Drawing.Size(208, 20);
            this.tbForegroundPressed.TabIndex = 13;
            this.tbForegroundPressed.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.tbForegroundPressed.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // lForegroundPressed
            // 
            this.lForegroundPressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lForegroundPressed.AutoSize = true;
            this.lForegroundPressed.Location = new System.Drawing.Point(3, 171);
            this.lForegroundPressed.Name = "lForegroundPressed";
            this.lForegroundPressed.Size = new System.Drawing.Size(309, 29);
            this.lForegroundPressed.TabIndex = 12;
            this.lForegroundPressed.Text = "Foreground pressed";
            this.lForegroundPressed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbBackgroundSelected
            // 
            this.tbBackgroundSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBackgroundSelected.Location = new System.Drawing.Point(318, 203);
            this.tbBackgroundSelected.Name = "tbBackgroundSelected";
            this.tbBackgroundSelected.Size = new System.Drawing.Size(208, 20);
            this.tbBackgroundSelected.TabIndex = 15;
            this.tbBackgroundSelected.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.tbBackgroundSelected.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // lBackgroundSelected
            // 
            this.lBackgroundSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBackgroundSelected.AutoSize = true;
            this.lBackgroundSelected.Location = new System.Drawing.Point(3, 200);
            this.lBackgroundSelected.Name = "lBackgroundSelected";
            this.lBackgroundSelected.Size = new System.Drawing.Size(309, 29);
            this.lBackgroundSelected.TabIndex = 14;
            this.lBackgroundSelected.Text = "Background selected";
            this.lBackgroundSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbForegroundSelected
            // 
            this.tbForegroundSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbForegroundSelected.Location = new System.Drawing.Point(318, 232);
            this.tbForegroundSelected.Name = "tbForegroundSelected";
            this.tbForegroundSelected.Size = new System.Drawing.Size(208, 20);
            this.tbForegroundSelected.TabIndex = 17;
            this.tbForegroundSelected.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.tbForegroundSelected.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // lForegroundSelected
            // 
            this.lForegroundSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lForegroundSelected.AutoSize = true;
            this.lForegroundSelected.Location = new System.Drawing.Point(3, 229);
            this.lForegroundSelected.Name = "lForegroundSelected";
            this.lForegroundSelected.Size = new System.Drawing.Size(309, 29);
            this.lForegroundSelected.TabIndex = 16;
            this.lForegroundSelected.Text = "Foreground selected";
            this.lForegroundSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lOrgSetting
            // 
            this.lOrgSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lOrgSetting.AutoSize = true;
            this.lOrgSetting.Location = new System.Drawing.Point(3, 258);
            this.lOrgSetting.Name = "lOrgSetting";
            this.lOrgSetting.Size = new System.Drawing.Size(309, 20);
            this.lOrgSetting.TabIndex = 18;
            this.lOrgSetting.Text = "Organization setting";
            this.lOrgSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lWebresourceName
            // 
            this.lWebresourceName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lWebresourceName.AutoSize = true;
            this.lWebresourceName.Location = new System.Drawing.Point(3, 0);
            this.lWebresourceName.Name = "lWebresourceName";
            this.lWebresourceName.Size = new System.Drawing.Size(309, 26);
            this.lWebresourceName.TabIndex = 2;
            this.lWebresourceName.Text = "Webresource name";
            this.lWebresourceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lInformations
            // 
            this.lInformations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lInformations.AutoSize = true;
            this.lInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInformations.Location = new System.Drawing.Point(3, 0);
            this.lInformations.Name = "lInformations";
            this.lInformations.Size = new System.Drawing.Size(309, 1);
            this.lInformations.TabIndex = 20;
            this.lInformations.Text = "⚠ All value should be inputed in hexadecimal format.";
            this.lInformations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lInformations.Visible = false;
            // 
            // bColorPickerBackground
            // 
            this.bColorPickerBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bColorPickerBackground.Location = new System.Drawing.Point(532, 29);
            this.bColorPickerBackground.Name = "bColorPickerBackground";
            this.bColorPickerBackground.Size = new System.Drawing.Size(75, 23);
            this.bColorPickerBackground.TabIndex = 21;
            this.bColorPickerBackground.Text = "Color Picker";
            this.bColorPickerBackground.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bColorPickerBackground.UseVisualStyleBackColor = true;
            this.bColorPickerBackground.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // bColorPickerForeground
            // 
            this.bColorPickerForeground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bColorPickerForeground.Location = new System.Drawing.Point(532, 58);
            this.bColorPickerForeground.Name = "bColorPickerForeground";
            this.bColorPickerForeground.Size = new System.Drawing.Size(75, 23);
            this.bColorPickerForeground.TabIndex = 22;
            this.bColorPickerForeground.Text = "Color Picker";
            this.bColorPickerForeground.UseVisualStyleBackColor = true;
            this.bColorPickerForeground.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // bColorPickerBackgroundHover
            // 
            this.bColorPickerBackgroundHover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bColorPickerBackgroundHover.Location = new System.Drawing.Point(532, 87);
            this.bColorPickerBackgroundHover.Name = "bColorPickerBackgroundHover";
            this.bColorPickerBackgroundHover.Size = new System.Drawing.Size(75, 23);
            this.bColorPickerBackgroundHover.TabIndex = 23;
            this.bColorPickerBackgroundHover.Text = "Color Picker";
            this.bColorPickerBackgroundHover.UseVisualStyleBackColor = true;
            this.bColorPickerBackgroundHover.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // bColorPickerForegroundHover
            // 
            this.bColorPickerForegroundHover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bColorPickerForegroundHover.Location = new System.Drawing.Point(532, 116);
            this.bColorPickerForegroundHover.Name = "bColorPickerForegroundHover";
            this.bColorPickerForegroundHover.Size = new System.Drawing.Size(75, 23);
            this.bColorPickerForegroundHover.TabIndex = 24;
            this.bColorPickerForegroundHover.Text = "Color Picker";
            this.bColorPickerForegroundHover.UseVisualStyleBackColor = true;
            this.bColorPickerForegroundHover.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // bColorPickerBackgroundPressed
            // 
            this.bColorPickerBackgroundPressed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bColorPickerBackgroundPressed.Location = new System.Drawing.Point(532, 145);
            this.bColorPickerBackgroundPressed.Name = "bColorPickerBackgroundPressed";
            this.bColorPickerBackgroundPressed.Size = new System.Drawing.Size(75, 23);
            this.bColorPickerBackgroundPressed.TabIndex = 25;
            this.bColorPickerBackgroundPressed.Text = "Color Picker";
            this.bColorPickerBackgroundPressed.UseVisualStyleBackColor = true;
            this.bColorPickerBackgroundPressed.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // bColorPickerForegroundPressed
            // 
            this.bColorPickerForegroundPressed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bColorPickerForegroundPressed.Location = new System.Drawing.Point(532, 174);
            this.bColorPickerForegroundPressed.Name = "bColorPickerForegroundPressed";
            this.bColorPickerForegroundPressed.Size = new System.Drawing.Size(75, 23);
            this.bColorPickerForegroundPressed.TabIndex = 26;
            this.bColorPickerForegroundPressed.Text = "Color Picker";
            this.bColorPickerForegroundPressed.UseVisualStyleBackColor = true;
            this.bColorPickerForegroundPressed.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // bColorPickerBackgroundSelected
            // 
            this.bColorPickerBackgroundSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bColorPickerBackgroundSelected.Location = new System.Drawing.Point(532, 203);
            this.bColorPickerBackgroundSelected.Name = "bColorPickerBackgroundSelected";
            this.bColorPickerBackgroundSelected.Size = new System.Drawing.Size(75, 23);
            this.bColorPickerBackgroundSelected.TabIndex = 27;
            this.bColorPickerBackgroundSelected.Text = "Color Picker";
            this.bColorPickerBackgroundSelected.UseVisualStyleBackColor = true;
            this.bColorPickerBackgroundSelected.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // bColorPickerForegroundSelected
            // 
            this.bColorPickerForegroundSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bColorPickerForegroundSelected.Location = new System.Drawing.Point(532, 232);
            this.bColorPickerForegroundSelected.Name = "bColorPickerForegroundSelected";
            this.bColorPickerForegroundSelected.Size = new System.Drawing.Size(75, 23);
            this.bColorPickerForegroundSelected.TabIndex = 28;
            this.bColorPickerForegroundSelected.Text = "Color Picker";
            this.bColorPickerForegroundSelected.UseVisualStyleBackColor = true;
            this.bColorPickerForegroundSelected.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // cbOrgSetting
            // 
            this.cbOrgSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOrgSetting.AutoSize = true;
            this.cbOrgSetting.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbOrgSetting.Checked = true;
            this.cbOrgSetting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOrgSetting.Enabled = false;
            this.cbOrgSetting.Location = new System.Drawing.Point(318, 261);
            this.cbOrgSetting.Name = "cbOrgSetting";
            this.cbOrgSetting.Size = new System.Drawing.Size(208, 14);
            this.cbOrgSetting.TabIndex = 19;
            this.cbOrgSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbOrgSetting.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ThemePersonalization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "ThemePersonalization";
            this.Size = new System.Drawing.Size(654, 409);
            this.Load += new System.EventHandler(this.OnLoad);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.gbColorProperties.ResumeLayout(false);
            this.gbColorProperties.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tsSeparatorSave;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.GroupBox gbColorProperties;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lBackground;
        private System.Windows.Forms.TextBox tbBackground;
        private System.Windows.Forms.ToolStripButton tbsSearch;
        private System.Windows.Forms.ToolStripSeparator tsSeparatorSearch;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label lWebresourceName;
        private System.Windows.Forms.TextBox tbBackgroundHover;
        private System.Windows.Forms.Label lBackgroundHover;
        private System.Windows.Forms.Label lForeground;
        private System.Windows.Forms.TextBox tbWebresourceName;
        private System.Windows.Forms.TextBox tbForeground;
        private System.Windows.Forms.TextBox tbForegroundHover;
        private System.Windows.Forms.Label lForegroundHover;
        private System.Windows.Forms.TextBox tbBackgroundPressed;
        private System.Windows.Forms.Label lBackgroundPressed;
        private System.Windows.Forms.TextBox tbForegroundPressed;
        private System.Windows.Forms.Label lForegroundPressed;
        private System.Windows.Forms.TextBox tbBackgroundSelected;
        private System.Windows.Forms.Label lBackgroundSelected;
        private System.Windows.Forms.TextBox tbForegroundSelected;
        private System.Windows.Forms.Label lForegroundSelected;
        private System.Windows.Forms.Label lOrgSetting;
        private System.Windows.Forms.CheckBox cbOrgSetting;
        private System.Windows.Forms.Label lInformations;
        private System.Windows.Forms.Button bColorPickerBackground;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button bColorPickerForeground;
        private System.Windows.Forms.Button bColorPickerBackgroundHover;
        private System.Windows.Forms.Button bColorPickerForegroundHover;
        private System.Windows.Forms.Button bColorPickerBackgroundPressed;
        private System.Windows.Forms.Button bColorPickerForegroundPressed;
        private System.Windows.Forms.Button bColorPickerBackgroundSelected;
        private System.Windows.Forms.Button bColorPickerForegroundSelected;
    }
}
