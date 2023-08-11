namespace BOSERP
{
    partial class guiShowIdentifyMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiShowIdentifyMenu));
            this.fld_dgcIdentifyMenu = new BOSERP.Modules.Equipment.IdentifyMenuGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnSelect = new BOSComponent.BOSButton(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_ckICProductIsInventory = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_btnView = new BOSComponent.BOSButton(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtCCDCName = new BOSComponent.BOSTextBox(this.components);
            this.fld_bedICProductGroupID = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_lkeFK_ICDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.BOSLabel5 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcIdentifyMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckICProductIsInventory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCCDCName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICDepartmentID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcIdentifyMenu
            // 
            resources.ApplyResources(this.fld_dgcIdentifyMenu, "fld_dgcIdentifyMenu");
            this.fld_dgcIdentifyMenu.BOSComment = null;
            this.fld_dgcIdentifyMenu.BOSDataMember = null;
            this.fld_dgcIdentifyMenu.BOSDataSource = "ICProductIdentifiedEquipments";
            this.fld_dgcIdentifyMenu.BOSDescription = null;
            this.fld_dgcIdentifyMenu.BOSError = null;
            this.fld_dgcIdentifyMenu.BOSFieldGroup = null;
            this.fld_dgcIdentifyMenu.BOSFieldRelation = null;
            this.fld_dgcIdentifyMenu.BOSGridType = null;
            this.fld_dgcIdentifyMenu.BOSPrivilege = null;
            this.fld_dgcIdentifyMenu.BOSPropertyName = null;
            this.fld_dgcIdentifyMenu.CommodityType = "";
            this.fld_dgcIdentifyMenu.MainView = this.gridView1;
            this.fld_dgcIdentifyMenu.Name = "fld_dgcIdentifyMenu";
            this.fld_dgcIdentifyMenu.PrintReport = false;
            this.fld_dgcIdentifyMenu.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcIdentifyMenu, ((bool)(resources.GetObject("fld_dgcIdentifyMenu.ShowHelp"))));
            this.fld_dgcIdentifyMenu.Tag = "DC";
            this.fld_dgcIdentifyMenu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcIdentifyMenu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // fld_btnSelect
            // 
            resources.ApplyResources(this.fld_btnSelect, "fld_btnSelect");
            this.fld_btnSelect.BOSComment = null;
            this.fld_btnSelect.BOSDataMember = null;
            this.fld_btnSelect.BOSDataSource = null;
            this.fld_btnSelect.BOSDescription = null;
            this.fld_btnSelect.BOSError = null;
            this.fld_btnSelect.BOSFieldGroup = null;
            this.fld_btnSelect.BOSFieldRelation = null;
            this.fld_btnSelect.BOSPrivilege = null;
            this.fld_btnSelect.BOSPropertyName = null;
            this.fld_btnSelect.Name = "fld_btnSelect";
            this.fld_btnSelect.Screen = null;
            this.fld_btnSelect.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // bosGroupControl2
            // 
            resources.ApplyResources(this.bosGroupControl2, "bosGroupControl2");
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_btnPrint);
            this.bosGroupControl2.Controls.Add(this.fld_ckICProductIsInventory);
            this.bosGroupControl2.Controls.Add(this.fld_btnView);
            this.bosGroupControl2.Controls.Add(this.bosLabel1);
            this.bosGroupControl2.Controls.Add(this.fld_txtCCDCName);
            this.bosGroupControl2.Controls.Add(this.fld_bedICProductGroupID);
            this.bosGroupControl2.Controls.Add(this.fld_lkeFK_ICDepartmentID);
            this.bosGroupControl2.Controls.Add(this.BOSLabel5);
            this.bosGroupControl2.Controls.Add(this.BOSLabel4);
            this.bosGroupControl2.Controls.Add(this.fld_dgcIdentifyMenu);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            // 
            // fld_ckICProductIsInventory
            // 
            this.fld_ckICProductIsInventory.BOSComment = "";
            this.fld_ckICProductIsInventory.BOSDataMember = "";
            this.fld_ckICProductIsInventory.BOSDataSource = "";
            this.fld_ckICProductIsInventory.BOSDescription = null;
            this.fld_ckICProductIsInventory.BOSError = "";
            this.fld_ckICProductIsInventory.BOSFieldGroup = "";
            this.fld_ckICProductIsInventory.BOSFieldRelation = "";
            this.fld_ckICProductIsInventory.BOSPrivilege = "";
            this.fld_ckICProductIsInventory.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_ckICProductIsInventory, "fld_ckICProductIsInventory");
            this.fld_ckICProductIsInventory.Name = "fld_ckICProductIsInventory";
            this.fld_ckICProductIsInventory.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_ckICProductIsInventory.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_ckICProductIsInventory.Properties.Appearance.Options.UseBackColor = true;
            this.fld_ckICProductIsInventory.Properties.Appearance.Options.UseForeColor = true;
            this.fld_ckICProductIsInventory.Properties.Caption = resources.GetString("fld_ckICProductIsInventory.Properties.Caption");
            this.fld_ckICProductIsInventory.Screen = null;
            this.fld_ckICProductIsInventory.TabStop = false;
            this.fld_ckICProductIsInventory.Tag = "DC";
            // 
            // fld_btnView
            // 
            this.fld_btnView.BOSComment = null;
            this.fld_btnView.BOSDataMember = null;
            this.fld_btnView.BOSDataSource = null;
            this.fld_btnView.BOSDescription = null;
            this.fld_btnView.BOSError = null;
            this.fld_btnView.BOSFieldGroup = null;
            this.fld_btnView.BOSFieldRelation = null;
            this.fld_btnView.BOSPrivilege = null;
            this.fld_btnView.BOSPropertyName = null;
            resources.ApplyResources(this.fld_btnView, "fld_btnView");
            this.fld_btnView.Name = "fld_btnView";
            this.fld_btnView.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnView, ((bool)(resources.GetObject("fld_btnView.ShowHelp"))));
            this.fld_btnView.Click += new System.EventHandler(this.fld_btnView_Click);
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel1, "bosLabel1");
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, ((bool)(resources.GetObject("bosLabel1.ShowHelp"))));
            // 
            // fld_txtCCDCName
            // 
            this.fld_txtCCDCName.BOSComment = null;
            this.fld_txtCCDCName.BOSDataMember = null;
            this.fld_txtCCDCName.BOSDataSource = null;
            this.fld_txtCCDCName.BOSDescription = null;
            this.fld_txtCCDCName.BOSError = null;
            this.fld_txtCCDCName.BOSFieldGroup = null;
            this.fld_txtCCDCName.BOSFieldRelation = null;
            this.fld_txtCCDCName.BOSPrivilege = null;
            this.fld_txtCCDCName.BOSPropertyName = null;
            resources.ApplyResources(this.fld_txtCCDCName, "fld_txtCCDCName");
            this.fld_txtCCDCName.MenuManager = this.screenToolbar;
            this.fld_txtCCDCName.Name = "fld_txtCCDCName";
            this.fld_txtCCDCName.Screen = null;
            // 
            // fld_bedICProductGroupID
            // 
            this.fld_bedICProductGroupID.BOSComment = null;
            this.fld_bedICProductGroupID.BOSDataMember = "ICProductGroupID";
            this.fld_bedICProductGroupID.BOSDataSource = "ICProductGroups";
            this.fld_bedICProductGroupID.BOSDescription = null;
            this.fld_bedICProductGroupID.BOSError = null;
            this.fld_bedICProductGroupID.BOSFieldGroup = null;
            this.fld_bedICProductGroupID.BOSFieldRelation = null;
            this.fld_bedICProductGroupID.BOSPrivilege = null;
            this.fld_bedICProductGroupID.BOSPropertyName = null;
            resources.ApplyResources(this.fld_bedICProductGroupID, "fld_bedICProductGroupID");
            this.fld_bedICProductGroupID.MenuManager = this.screenToolbar;
            this.fld_bedICProductGroupID.Name = "fld_bedICProductGroupID";
            this.fld_bedICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedICProductGroupID.Properties.ReadOnly = true;
            this.fld_bedICProductGroupID.Screen = null;
            this.fld_bedICProductGroupID.Tag = "DC";
            this.fld_bedICProductGroupID.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedICProductGroupID_ButtonClick);
            // 
            // fld_lkeFK_ICDepartmentID
            // 
            this.fld_lkeFK_ICDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICDepartmentID.BOSAllowDummy = true;
            this.fld_lkeFK_ICDepartmentID.BOSComment = null;
            this.fld_lkeFK_ICDepartmentID.BOSDataMember = "FK_ICDepartmentID";
            this.fld_lkeFK_ICDepartmentID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ICDepartmentID.BOSDescription = null;
            this.fld_lkeFK_ICDepartmentID.BOSError = null;
            this.fld_lkeFK_ICDepartmentID.BOSFieldGroup = null;
            this.fld_lkeFK_ICDepartmentID.BOSFieldParent = null;
            this.fld_lkeFK_ICDepartmentID.BOSFieldRelation = null;
            this.fld_lkeFK_ICDepartmentID.BOSPrivilege = null;
            this.fld_lkeFK_ICDepartmentID.BOSPropertyName = null;
            this.fld_lkeFK_ICDepartmentID.BOSSelectType = null;
            this.fld_lkeFK_ICDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICDepartmentID.CurrentDisplayText = "";
            resources.ApplyResources(this.fld_lkeFK_ICDepartmentID, "fld_lkeFK_ICDepartmentID");
            this.fld_lkeFK_ICDepartmentID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICDepartmentID.Name = "fld_lkeFK_ICDepartmentID";
            this.fld_lkeFK_ICDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_ICDepartmentID.Properties.Buttons"))))});
            this.fld_lkeFK_ICDepartmentID.Properties.ColumnName = null;
            this.fld_lkeFK_ICDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ICDepartmentID.Properties.Columns"), resources.GetString("fld_lkeFK_ICDepartmentID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ICDepartmentID.Properties.Columns2"), resources.GetString("fld_lkeFK_ICDepartmentID.Properties.Columns3"))});
            this.fld_lkeFK_ICDepartmentID.Properties.DisplayMember = "ICDepartmentName";
            this.fld_lkeFK_ICDepartmentID.Properties.NullText = resources.GetString("fld_lkeFK_ICDepartmentID.Properties.NullText");
            this.fld_lkeFK_ICDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICDepartmentID.Properties.ValueMember = "ICDepartmentID";
            this.fld_lkeFK_ICDepartmentID.Screen = null;
            this.fld_lkeFK_ICDepartmentID.Tag = "";
            // 
            // BOSLabel5
            // 
            this.BOSLabel5.BOSComment = null;
            this.BOSLabel5.BOSDataMember = null;
            this.BOSLabel5.BOSDataSource = null;
            this.BOSLabel5.BOSDescription = null;
            this.BOSLabel5.BOSError = null;
            this.BOSLabel5.BOSFieldGroup = null;
            this.BOSLabel5.BOSFieldRelation = null;
            this.BOSLabel5.BOSPrivilege = null;
            this.BOSLabel5.BOSPropertyName = null;
            resources.ApplyResources(this.BOSLabel5, "BOSLabel5");
            this.BOSLabel5.Name = "BOSLabel5";
            this.BOSLabel5.Screen = null;
            // 
            // BOSLabel4
            // 
            this.BOSLabel4.BOSComment = null;
            this.BOSLabel4.BOSDataMember = null;
            this.BOSLabel4.BOSDataSource = null;
            this.BOSLabel4.BOSDescription = null;
            this.BOSLabel4.BOSError = null;
            this.BOSLabel4.BOSFieldGroup = null;
            this.BOSLabel4.BOSFieldRelation = null;
            this.BOSLabel4.BOSPrivilege = null;
            this.BOSLabel4.BOSPropertyName = null;
            resources.ApplyResources(this.BOSLabel4, "BOSLabel4");
            this.BOSLabel4.Name = "BOSLabel4";
            this.BOSLabel4.Screen = null;
            // 
            // fld_btnPrint
            // 
            this.fld_btnPrint.BOSComment = null;
            this.fld_btnPrint.BOSDataMember = null;
            this.fld_btnPrint.BOSDataSource = null;
            this.fld_btnPrint.BOSDescription = null;
            this.fld_btnPrint.BOSError = null;
            this.fld_btnPrint.BOSFieldGroup = null;
            this.fld_btnPrint.BOSFieldRelation = null;
            this.fld_btnPrint.BOSPrivilege = null;
            this.fld_btnPrint.BOSPropertyName = null;
            resources.ApplyResources(this.fld_btnPrint, "fld_btnPrint");
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnPrint, ((bool)(resources.GetObject("fld_btnPrint.ShowHelp"))));
            this.fld_btnPrint.Click += new System.EventHandler(this.fld_btnPrint_Click);
            // 
            // guiShowIdentifyMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = true;
            this.Controls.Add(this.bosGroupControl2);
            this.Controls.Add(this.fld_btnSelect);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiShowIdentifyMenu.IconOptions.Icon")));
            this.Name = "guiShowIdentifyMenu";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.guiShowIdentifyMenu_Load);
            this.Controls.SetChildIndex(this.fld_btnSelect, 0);
            this.Controls.SetChildIndex(this.bosGroupControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcIdentifyMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckICProductIsInventory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtCCDCName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICDepartmentID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSERP.Modules.Equipment.IdentifyMenuGridControl fld_dgcIdentifyMenu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSButton fld_btnSelect;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSButtonEdit fld_bedICProductGroupID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICDepartmentID;
        private BOSComponent.BOSLabel BOSLabel5;
        private BOSComponent.BOSLabel BOSLabel4;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtCCDCName;
        private BOSComponent.BOSButton fld_btnView;
        private BOSComponent.BOSCheckEdit fld_ckICProductIsInventory;
        private BOSComponent.BOSButton fld_btnPrint;
    }
}