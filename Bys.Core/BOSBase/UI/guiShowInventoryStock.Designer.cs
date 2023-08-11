namespace BOSERP
{
    partial class guiShowInventoryStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiShowInventoryStock));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_lkeICProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_bedFK_ICProductGroupID = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_lkeFK_ICProductID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel28 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeWoodType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnSearch = new BOSComponent.BOSButton(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgcICProductSeries = new BOSERP.ShowInventoryStockGridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnChosse = new BOSComponent.BOSButton(this.components);
            this.fld_chkSelectAll = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeStocks = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeWoodType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeStocks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // fld_btnClose
            // 
            resources.ApplyResources(this.fld_btnClose, "fld_btnClose");
            this.fld_btnClose.BOSComment = null;
            this.fld_btnClose.BOSDataMember = null;
            this.fld_btnClose.BOSDataSource = null;
            this.fld_btnClose.BOSDescription = null;
            this.fld_btnClose.BOSError = null;
            this.fld_btnClose.BOSFieldGroup = null;
            this.fld_btnClose.BOSFieldRelation = null;
            this.fld_btnClose.BOSPrivilege = null;
            this.fld_btnClose.BOSPropertyName = null;
            this.fld_btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnClose, ((bool)(resources.GetObject("fld_btnClose.ShowHelp"))));
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_lkeICProductType
            // 
            this.fld_lkeICProductType.BOSAllowAddNew = false;
            this.fld_lkeICProductType.BOSAllowDummy = false;
            this.fld_lkeICProductType.BOSComment = null;
            this.fld_lkeICProductType.BOSDataMember = "ICProductType";
            this.fld_lkeICProductType.BOSDataSource = "ICProducts";
            this.fld_lkeICProductType.BOSDescription = null;
            this.fld_lkeICProductType.BOSError = null;
            this.fld_lkeICProductType.BOSFieldGroup = null;
            this.fld_lkeICProductType.BOSFieldParent = null;
            this.fld_lkeICProductType.BOSFieldRelation = null;
            this.fld_lkeICProductType.BOSPrivilege = null;
            this.fld_lkeICProductType.BOSPropertyName = "EditValue";
            this.fld_lkeICProductType.BOSSelectType = null;
            this.fld_lkeICProductType.BOSSelectTypeValue = null;
            this.fld_lkeICProductType.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeICProductType, "fld_lkeICProductType");
            this.fld_lkeICProductType.MenuManager = this.screenToolbar;
            this.fld_lkeICProductType.Name = "fld_lkeICProductType";
            this.fld_lkeICProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeICProductType.Properties.Buttons"))))});
            this.fld_lkeICProductType.Properties.ColumnName = null;
            this.fld_lkeICProductType.Properties.NullText = resources.GetString("fld_lkeICProductType.Properties.NullText");
            this.fld_lkeICProductType.Properties.ReadOnly = true;
            this.fld_lkeICProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductType, ((bool)(resources.GetObject("fld_lkeICProductType.ShowHelp"))));
            this.fld_lkeICProductType.Tag = "DC";
            this.fld_lkeICProductType.EditValueChanged += new System.EventHandler(this.fld_lkeICProductType_EditValueChanged);
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.BOSComment = null;
            this.fld_lblLabel17.BOSDataMember = null;
            this.fld_lblLabel17.BOSDataSource = null;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = null;
            this.fld_lblLabel17.BOSFieldRelation = null;
            this.fld_lblLabel17.BOSPrivilege = null;
            this.fld_lblLabel17.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel17, "fld_lblLabel17");
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            // 
            // fld_bedFK_ICProductGroupID
            // 
            this.fld_bedFK_ICProductGroupID.BOSComment = null;
            this.fld_bedFK_ICProductGroupID.BOSDataMember = "FK_ICProductGroupID";
            this.fld_bedFK_ICProductGroupID.BOSDataSource = "ICProducts";
            this.fld_bedFK_ICProductGroupID.BOSDescription = null;
            this.fld_bedFK_ICProductGroupID.BOSError = null;
            this.fld_bedFK_ICProductGroupID.BOSFieldGroup = null;
            this.fld_bedFK_ICProductGroupID.BOSFieldRelation = null;
            this.fld_bedFK_ICProductGroupID.BOSPrivilege = null;
            this.fld_bedFK_ICProductGroupID.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_bedFK_ICProductGroupID, "fld_bedFK_ICProductGroupID");
            this.fld_bedFK_ICProductGroupID.MenuManager = this.screenToolbar;
            this.fld_bedFK_ICProductGroupID.Name = "fld_bedFK_ICProductGroupID";
            this.fld_bedFK_ICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedFK_ICProductGroupID.Properties.ReadOnly = true;
            this.fld_bedFK_ICProductGroupID.Screen = null;
            this.fld_bedFK_ICProductGroupID.Tag = "DC";
            this.fld_bedFK_ICProductGroupID.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedFK_ICProductGroupID_ButtonClick);
            // 
            // fld_lkeFK_ICProductID1
            // 
            this.fld_lkeFK_ICProductID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID1.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductID1.BOSComment = "";
            this.fld_lkeFK_ICProductID1.BOSDataMember = "ICProductID";
            this.fld_lkeFK_ICProductID1.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ICProductID1.BOSDescription = null;
            this.fld_lkeFK_ICProductID1.BOSError = null;
            this.fld_lkeFK_ICProductID1.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductID1.BOSFieldParent = "";
            this.fld_lkeFK_ICProductID1.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductID1.BOSPrivilege = "";
            this.fld_lkeFK_ICProductID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID1.BOSSelectType = "";
            this.fld_lkeFK_ICProductID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductID1.CurrentDisplayText = "";
            resources.ApplyResources(this.fld_lkeFK_ICProductID1, "fld_lkeFK_ICProductID1");
            this.fld_lkeFK_ICProductID1.Name = "fld_lkeFK_ICProductID1";
            this.fld_lkeFK_ICProductID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_ICProductID1.Properties.Buttons"))))});
            this.fld_lkeFK_ICProductID1.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ICProductID1.Properties.Columns"), resources.GetString("fld_lkeFK_ICProductID1.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ICProductID1.Properties.Columns2"), resources.GetString("fld_lkeFK_ICProductID1.Properties.Columns3")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ICProductID1.Properties.Columns4"), resources.GetString("fld_lkeFK_ICProductID1.Properties.Columns5")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ICProductID1.Properties.Columns6"), resources.GetString("fld_lkeFK_ICProductID1.Properties.Columns7"))});
            this.fld_lkeFK_ICProductID1.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID1.Properties.NullText = resources.GetString("fld_lkeFK_ICProductID1.Properties.NullText");
            this.fld_lkeFK_ICProductID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID1.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductID1, ((bool)(resources.GetObject("fld_lkeFK_ICProductID1.ShowHelp"))));
            this.fld_lkeFK_ICProductID1.Tag = "DC";
            // 
            // fld_lblLabel28
            // 
            this.fld_lblLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel28.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("fld_lblLabel28.Appearance.Font")));
            this.fld_lblLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel28.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel28.Appearance.Options.UseFont = true;
            this.fld_lblLabel28.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel28.BOSComment = "";
            this.fld_lblLabel28.BOSDataMember = "";
            this.fld_lblLabel28.BOSDataSource = "";
            this.fld_lblLabel28.BOSDescription = null;
            this.fld_lblLabel28.BOSError = null;
            this.fld_lblLabel28.BOSFieldGroup = "";
            this.fld_lblLabel28.BOSFieldRelation = "";
            this.fld_lblLabel28.BOSPrivilege = "";
            this.fld_lblLabel28.BOSPropertyName = "";
            resources.ApplyResources(this.fld_lblLabel28, "fld_lblLabel28");
            this.fld_lblLabel28.Name = "fld_lblLabel28";
            this.fld_lblLabel28.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel28, ((bool)(resources.GetObject("fld_lblLabel28.ShowHelp"))));
            this.fld_lblLabel28.Tag = "";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("bosLabel1.Appearance.Font")));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = "";
            resources.ApplyResources(this.bosLabel1, "bosLabel1");
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, ((bool)(resources.GetObject("bosLabel1.ShowHelp"))));
            this.bosLabel1.Tag = "";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("bosLabel2.Appearance.Font")));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = "";
            resources.ApplyResources(this.bosLabel2, "bosLabel2");
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, ((bool)(resources.GetObject("bosLabel2.ShowHelp"))));
            this.bosLabel2.Tag = "";
            // 
            // fld_lkeWoodType
            // 
            this.fld_lkeWoodType.BOSAllowAddNew = false;
            this.fld_lkeWoodType.BOSAllowDummy = true;
            this.fld_lkeWoodType.BOSComment = "";
            this.fld_lkeWoodType.BOSDataMember = "ICProductAttributeID";
            this.fld_lkeWoodType.BOSDataSource = "ICProductAttributes";
            this.fld_lkeWoodType.BOSDescription = null;
            this.fld_lkeWoodType.BOSError = null;
            this.fld_lkeWoodType.BOSFieldGroup = "";
            this.fld_lkeWoodType.BOSFieldParent = "";
            this.fld_lkeWoodType.BOSFieldRelation = "";
            this.fld_lkeWoodType.BOSPrivilege = "";
            this.fld_lkeWoodType.BOSPropertyName = "EditValue";
            this.fld_lkeWoodType.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeWoodType.BOSSelectTypeValue = "WoodType";
            this.fld_lkeWoodType.CurrentDisplayText = "";
            resources.ApplyResources(this.fld_lkeWoodType, "fld_lkeWoodType");
            this.fld_lkeWoodType.Name = "fld_lkeWoodType";
            this.fld_lkeWoodType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeWoodType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeWoodType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeWoodType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeWoodType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeWoodType.Properties.Buttons"))))});
            this.fld_lkeWoodType.Properties.ColumnName = null;
            this.fld_lkeWoodType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeWoodType.Properties.Columns"), resources.GetString("fld_lkeWoodType.Properties.Columns1"))});
            this.fld_lkeWoodType.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeWoodType.Properties.NullText = resources.GetString("fld_lkeWoodType.Properties.NullText");
            this.fld_lkeWoodType.Properties.PopupWidth = 40;
            this.fld_lkeWoodType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeWoodType.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeWoodType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeWoodType, ((bool)(resources.GetObject("fld_lkeWoodType.ShowHelp"))));
            this.fld_lkeWoodType.Tag = "DC";
            // 
            // fld_btnSearch
            // 
            this.fld_btnSearch.BOSComment = null;
            this.fld_btnSearch.BOSDataMember = null;
            this.fld_btnSearch.BOSDataSource = null;
            this.fld_btnSearch.BOSDescription = null;
            this.fld_btnSearch.BOSError = null;
            this.fld_btnSearch.BOSFieldGroup = null;
            this.fld_btnSearch.BOSFieldRelation = null;
            this.fld_btnSearch.BOSPrivilege = null;
            this.fld_btnSearch.BOSPropertyName = null;
            resources.ApplyResources(this.fld_btnSearch, "fld_btnSearch");
            this.fld_btnSearch.Name = "fld_btnSearch";
            this.fld_btnSearch.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSearch, ((bool)(resources.GetObject("fld_btnSearch.ShowHelp"))));
            this.fld_btnSearch.Click += new System.EventHandler(this.fld_btnSearch_Click);
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // gridView3
            // 
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // gridView4
            // 
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // fld_dgcICProductSeries
            // 
            resources.ApplyResources(this.fld_dgcICProductSeries, "fld_dgcICProductSeries");
            this.fld_dgcICProductSeries.BOSComment = null;
            this.fld_dgcICProductSeries.BOSDataMember = null;
            this.fld_dgcICProductSeries.BOSDataSource = "ICProductSeries";
            this.fld_dgcICProductSeries.BOSDescription = null;
            this.fld_dgcICProductSeries.BOSError = null;
            this.fld_dgcICProductSeries.BOSFieldGroup = null;
            this.fld_dgcICProductSeries.BOSFieldRelation = null;
            this.fld_dgcICProductSeries.BOSGridType = null;
            this.fld_dgcICProductSeries.BOSPrivilege = null;
            this.fld_dgcICProductSeries.BOSPropertyName = null;
            this.fld_dgcICProductSeries.CommodityType = "";
            this.fld_dgcICProductSeries.MainView = this.gridView5;
            this.fld_dgcICProductSeries.Name = "fld_dgcICProductSeries";
            this.fld_dgcICProductSeries.PrintReport = false;
            this.fld_dgcICProductSeries.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcICProductSeries, ((bool)(resources.GetObject("fld_dgcICProductSeries.ShowHelp"))));
            this.fld_dgcICProductSeries.Tag = "DC";
            this.fld_dgcICProductSeries.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.fld_dgcICProductSeries;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // fld_btnChosse
            // 
            resources.ApplyResources(this.fld_btnChosse, "fld_btnChosse");
            this.fld_btnChosse.BOSComment = null;
            this.fld_btnChosse.BOSDataMember = null;
            this.fld_btnChosse.BOSDataSource = null;
            this.fld_btnChosse.BOSDescription = null;
            this.fld_btnChosse.BOSError = null;
            this.fld_btnChosse.BOSFieldGroup = null;
            this.fld_btnChosse.BOSFieldRelation = null;
            this.fld_btnChosse.BOSPrivilege = null;
            this.fld_btnChosse.BOSPropertyName = null;
            this.fld_btnChosse.Name = "fld_btnChosse";
            this.fld_btnChosse.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnChosse, ((bool)(resources.GetObject("fld_btnChosse.ShowHelp"))));
            this.fld_btnChosse.Click += new System.EventHandler(this.fld_btnChosse_Click);
            // 
            // fld_chkSelectAll
            // 
            resources.ApplyResources(this.fld_chkSelectAll, "fld_chkSelectAll");
            this.fld_chkSelectAll.BOSComment = null;
            this.fld_chkSelectAll.BOSDataMember = null;
            this.fld_chkSelectAll.BOSDataSource = null;
            this.fld_chkSelectAll.BOSDescription = null;
            this.fld_chkSelectAll.BOSError = null;
            this.fld_chkSelectAll.BOSFieldGroup = null;
            this.fld_chkSelectAll.BOSFieldRelation = null;
            this.fld_chkSelectAll.BOSPrivilege = null;
            this.fld_chkSelectAll.BOSPropertyName = null;
            this.fld_chkSelectAll.MenuManager = this.screenToolbar;
            this.fld_chkSelectAll.Name = "fld_chkSelectAll";
            this.fld_chkSelectAll.Properties.Caption = resources.GetString("fld_chkSelectAll.Properties.Caption");
            this.fld_chkSelectAll.Screen = null;
            this.fld_chkSelectAll.CheckedChanged += new System.EventHandler(this.fld_chkSelectAll_CheckedChanged);
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("bosLabel3.Appearance.Font")));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = "";
            resources.ApplyResources(this.bosLabel3, "bosLabel3");
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, ((bool)(resources.GetObject("bosLabel3.ShowHelp"))));
            this.bosLabel3.Tag = "";
            // 
            // fld_lkeStocks
            // 
            this.fld_lkeStocks.BOSAllowAddNew = false;
            this.fld_lkeStocks.BOSAllowDummy = true;
            this.fld_lkeStocks.BOSComment = "";
            this.fld_lkeStocks.BOSDataMember = "ICStockID";
            this.fld_lkeStocks.BOSDataSource = "ICStocks";
            this.fld_lkeStocks.BOSDescription = null;
            this.fld_lkeStocks.BOSError = null;
            this.fld_lkeStocks.BOSFieldGroup = "";
            this.fld_lkeStocks.BOSFieldParent = "";
            this.fld_lkeStocks.BOSFieldRelation = "";
            this.fld_lkeStocks.BOSPrivilege = "";
            this.fld_lkeStocks.BOSPropertyName = "EditValue";
            this.fld_lkeStocks.BOSSelectType = "";
            this.fld_lkeStocks.BOSSelectTypeValue = "";
            this.fld_lkeStocks.CurrentDisplayText = "";
            resources.ApplyResources(this.fld_lkeStocks, "fld_lkeStocks");
            this.fld_lkeStocks.Name = "fld_lkeStocks";
            this.fld_lkeStocks.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeStocks.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeStocks.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeStocks.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeStocks.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeStocks.Properties.Buttons"))))});
            this.fld_lkeStocks.Properties.ColumnName = null;
            this.fld_lkeStocks.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeStocks.Properties.Columns"), resources.GetString("fld_lkeStocks.Properties.Columns1"))});
            this.fld_lkeStocks.Properties.DisplayMember = "ICStockName";
            this.fld_lkeStocks.Properties.NullText = resources.GetString("fld_lkeStocks.Properties.NullText");
            this.fld_lkeStocks.Properties.PopupWidth = 40;
            this.fld_lkeStocks.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeStocks.Properties.ValueMember = "ICStockID";
            this.fld_lkeStocks.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeStocks, ((bool)(resources.GetObject("fld_lkeStocks.ShowHelp"))));
            this.fld_lkeStocks.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("bosLabel4.Appearance.Font")));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "";
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = "";
            resources.ApplyResources(this.bosLabel4, "bosLabel4");
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, ((bool)(resources.GetObject("bosLabel4.ShowHelp"))));
            this.bosLabel4.Tag = "";
            // 
            // fld_lkeMMBatchProductID
            // 
            this.fld_lkeMMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeMMBatchProductID.BOSComment = "";
            this.fld_lkeMMBatchProductID.BOSDataMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductID.BOSDescription = null;
            this.fld_lkeMMBatchProductID.BOSError = null;
            this.fld_lkeMMBatchProductID.BOSFieldGroup = "";
            this.fld_lkeMMBatchProductID.BOSFieldParent = "";
            this.fld_lkeMMBatchProductID.BOSFieldRelation = "";
            this.fld_lkeMMBatchProductID.BOSPrivilege = "";
            this.fld_lkeMMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductID.BOSSelectType = "";
            this.fld_lkeMMBatchProductID.BOSSelectTypeValue = "";
            this.fld_lkeMMBatchProductID.CurrentDisplayText = "";
            resources.ApplyResources(this.fld_lkeMMBatchProductID, "fld_lkeMMBatchProductID");
            this.fld_lkeMMBatchProductID.Name = "fld_lkeMMBatchProductID";
            this.fld_lkeMMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeMMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeMMBatchProductID.Properties.Buttons"))))});
            this.fld_lkeMMBatchProductID.Properties.ColumnName = null;
            this.fld_lkeMMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeMMBatchProductID.Properties.Columns"), resources.GetString("fld_lkeMMBatchProductID.Properties.Columns1"))});
            this.fld_lkeMMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeMMBatchProductID.Properties.NullText = resources.GetString("fld_lkeMMBatchProductID.Properties.NullText");
            this.fld_lkeMMBatchProductID.Properties.PopupWidth = 40;
            this.fld_lkeMMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMBatchProductID, ((bool)(resources.GetObject("fld_lkeMMBatchProductID.ShowHelp"))));
            this.fld_lkeMMBatchProductID.Tag = "DC";
            // 
            // guiShowInventoryStock
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ControlBox = true;
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lkeMMBatchProductID);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeStocks);
            this.Controls.Add(this.fld_chkSelectAll);
            this.Controls.Add(this.fld_btnChosse);
            this.Controls.Add(this.fld_dgcICProductSeries);
            this.Controls.Add(this.fld_btnSearch);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeWoodType);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeFK_ICProductID1);
            this.Controls.Add(this.fld_bedFK_ICProductGroupID);
            this.Controls.Add(this.fld_lblLabel28);
            this.Controls.Add(this.fld_lkeICProductType);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_btnClose);
            this.Name = "guiShowInventoryStock";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Load += new System.EventHandler(this.guiShowInventoryStock_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_lkeICProductType, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel28, 0);
            this.Controls.SetChildIndex(this.fld_bedFK_ICProductGroupID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICProductID1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lkeWoodType, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_btnSearch, 0);
            this.Controls.SetChildIndex(this.fld_dgcICProductSeries, 0);
            this.Controls.SetChildIndex(this.fld_btnChosse, 0);
            this.Controls.SetChildIndex(this.fld_chkSelectAll, 0);
            this.Controls.SetChildIndex(this.fld_lkeStocks, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lkeMMBatchProductID, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeWoodType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeStocks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private ShowInventoryStockGridControl fld_dgcInventoryStocks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSLookupEdit fld_lkeICProductType;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSButtonEdit fld_bedFK_ICProductGroupID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID1;
        private BOSComponent.BOSLabel fld_lblLabel28;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeWoodType;
        private BOSComponent.BOSButton fld_btnSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private ShowInventoryStockGridControl fld_dgcICProductSeries;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private BOSComponent.BOSButton fld_btnChosse;
        private BOSComponent.BOSCheckEdit fld_chkSelectAll;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeStocks;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductID;
    }
}