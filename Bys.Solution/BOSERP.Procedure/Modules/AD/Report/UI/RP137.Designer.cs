namespace BOSERP.Modules.Report
{
    partial class RP137
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP137));
            this.fld_btnExportExcel = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcRP137ICReceiptItems = new BOSERP.Modules.Report.RP137ReceiptItemsGridControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_txtICReceiptItemLotNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductAttributeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP137ICReceiptItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptItemLotNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductAttributeID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnExportExcel
            // 
            resources.ApplyResources(this.fld_btnExportExcel, "fld_btnExportExcel");
            this.fld_btnExportExcel.BOSComment = null;
            this.fld_btnExportExcel.BOSDataMember = null;
            this.fld_btnExportExcel.BOSDataSource = null;
            this.fld_btnExportExcel.BOSDescription = null;
            this.fld_btnExportExcel.BOSError = null;
            this.fld_btnExportExcel.BOSFieldGroup = null;
            this.fld_btnExportExcel.BOSFieldRelation = null;
            this.fld_btnExportExcel.BOSPrivilege = null;
            this.fld_btnExportExcel.BOSPropertyName = null;
            this.fld_btnExportExcel.Name = "fld_btnExportExcel";
            this.fld_btnExportExcel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnExportExcel, ((bool)(resources.GetObject("fld_btnExportExcel.ShowHelp"))));
            this.fld_btnExportExcel.Click += new System.EventHandler(this.fld_btnExportExcel_Click);
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
            // bosPanel1
            // 
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.panelControl2);
            this.bosPanel1.Controls.Add(this.panelControl1);
            resources.ApplyResources(this.bosPanel1, "bosPanel1");
            this.bosPanel1.Name = "bosPanel1";
            this.ScreenHelper.SetShowHelp(this.bosPanel1, ((bool)(resources.GetObject("bosPanel1.ShowHelp"))));
            // 
            // bosLine1
            // 
            resources.ApplyResources(this.bosLine1, "bosLine1");
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_dgcRP137ICReceiptItems);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine1, ((bool)(resources.GetObject("bosLine1.ShowHelp"))));
            this.bosLine1.TabStop = false;
            // 
            // fld_dgcRP137ICReceiptItems
            // 
            resources.ApplyResources(this.fld_dgcRP137ICReceiptItems, "fld_dgcRP137ICReceiptItems");
            this.fld_dgcRP137ICReceiptItems.BOSComment = null;
            this.fld_dgcRP137ICReceiptItems.BOSDataMember = null;
            this.fld_dgcRP137ICReceiptItems.BOSDataSource = "ICReceiptItems";
            this.fld_dgcRP137ICReceiptItems.BOSDescription = null;
            this.fld_dgcRP137ICReceiptItems.BOSError = null;
            this.fld_dgcRP137ICReceiptItems.BOSFieldGroup = null;
            this.fld_dgcRP137ICReceiptItems.BOSFieldRelation = null;
            this.fld_dgcRP137ICReceiptItems.BOSGridType = null;
            this.fld_dgcRP137ICReceiptItems.BOSPrivilege = null;
            this.fld_dgcRP137ICReceiptItems.BOSPropertyName = null;
            this.fld_dgcRP137ICReceiptItems.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("fld_dgcRP137ICReceiptItems.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.fld_dgcRP137ICReceiptItems.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("fld_dgcRP137ICReceiptItems.EmbeddedNavigator.Anchor")));
            this.fld_dgcRP137ICReceiptItems.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("fld_dgcRP137ICReceiptItems.EmbeddedNavigator.BackgroundImageLayout")));
            this.fld_dgcRP137ICReceiptItems.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("fld_dgcRP137ICReceiptItems.EmbeddedNavigator.ImeMode")));
            this.fld_dgcRP137ICReceiptItems.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("fld_dgcRP137ICReceiptItems.EmbeddedNavigator.TextLocation")));
            this.fld_dgcRP137ICReceiptItems.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("fld_dgcRP137ICReceiptItems.EmbeddedNavigator.ToolTipIconType")));
            this.fld_dgcRP137ICReceiptItems.MenuManager = this.screenToolbar;
            this.fld_dgcRP137ICReceiptItems.Name = "fld_dgcRP137ICReceiptItems";
            this.fld_dgcRP137ICReceiptItems.PrintReport = false;
            this.fld_dgcRP137ICReceiptItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcRP137ICReceiptItems, ((bool)(resources.GetObject("fld_dgcRP137ICReceiptItems.ShowHelp"))));
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.fld_btnClose);
            this.panelControl2.Controls.Add(this.fld_btnExportExcel);
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Name = "panelControl2";
            this.ScreenHelper.SetShowHelp(this.panelControl2, ((bool)(resources.GetObject("panelControl2.ShowHelp"))));
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_txtICReceiptItemLotNo);
            this.panelControl1.Controls.Add(this.bosLabel1);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.fld_dteSearchToDate);
            this.panelControl1.Controls.Add(this.bosLabel9);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromDate);
            this.panelControl1.Controls.Add(this.bosLabel10);
            this.panelControl1.Controls.Add(this.fld_lkeICProductAttributeID);
            this.panelControl1.Controls.Add(this.bosLabel6);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            this.ScreenHelper.SetShowHelp(this.panelControl1, ((bool)(resources.GetObject("panelControl1.ShowHelp"))));
            this.panelControl1.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_txtICReceiptItemLotNo
            // 
            this.fld_txtICReceiptItemLotNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptItemLotNo.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptItemLotNo.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptItemLotNo.BOSDescription = null;
            this.fld_txtICReceiptItemLotNo.BOSError = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptItemLotNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptItemLotNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptItemLotNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtICReceiptItemLotNo.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtICReceiptItemLotNo, "fld_txtICReceiptItemLotNo");
            this.fld_txtICReceiptItemLotNo.Name = "fld_txtICReceiptItemLotNo";
            this.fld_txtICReceiptItemLotNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICReceiptItemLotNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICReceiptItemLotNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICReceiptItemLotNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICReceiptItemLotNo.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtICReceiptItemLotNo.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtICReceiptItemLotNo.Screen = null;
            this.fld_txtICReceiptItemLotNo.Tag = "DC";
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
            // fld_btnApply
            // 
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            resources.ApplyResources(this.fld_btnApply, "fld_btnApply");
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnApply, ((bool)(resources.GetObject("fld_btnApply.ShowHelp"))));
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.BOSComment = null;
            this.fld_dteSearchToDate.BOSDataMember = null;
            this.fld_dteSearchToDate.BOSDataSource = null;
            this.fld_dteSearchToDate.BOSDescription = null;
            this.fld_dteSearchToDate.BOSError = null;
            this.fld_dteSearchToDate.BOSFieldGroup = null;
            this.fld_dteSearchToDate.BOSFieldRelation = null;
            this.fld_dteSearchToDate.BOSPrivilege = null;
            this.fld_dteSearchToDate.BOSPropertyName = null;
            this.fld_dteSearchToDate.EditValue = null;
            resources.ApplyResources(this.fld_dteSearchToDate, "fld_dteSearchToDate");
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteSearchToDate.Properties.Buttons"))))});
            this.fld_dteSearchToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSearchToDate, ((bool)(resources.GetObject("fld_dteSearchToDate.ShowHelp"))));
            this.fld_dteSearchToDate.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel9, "bosLabel9");
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, ((bool)(resources.GetObject("bosLabel9.ShowHelp"))));
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = null;
            this.fld_dteSearchFromDate.BOSDataMember = null;
            this.fld_dteSearchFromDate.BOSDataSource = null;
            this.fld_dteSearchFromDate.BOSDescription = null;
            this.fld_dteSearchFromDate.BOSError = null;
            this.fld_dteSearchFromDate.BOSFieldGroup = null;
            this.fld_dteSearchFromDate.BOSFieldRelation = null;
            this.fld_dteSearchFromDate.BOSPrivilege = null;
            this.fld_dteSearchFromDate.BOSPropertyName = null;
            this.fld_dteSearchFromDate.EditValue = null;
            resources.ApplyResources(this.fld_dteSearchFromDate, "fld_dteSearchFromDate");
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteSearchFromDate.Properties.Buttons"))))});
            this.fld_dteSearchFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSearchFromDate, ((bool)(resources.GetObject("fld_dteSearchFromDate.ShowHelp"))));
            this.fld_dteSearchFromDate.Tag = "DC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel10, "bosLabel10");
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, ((bool)(resources.GetObject("bosLabel10.ShowHelp"))));
            // 
            // fld_lkeICProductAttributeID
            // 
            this.fld_lkeICProductAttributeID.BOSAllowAddNew = false;
            this.fld_lkeICProductAttributeID.BOSAllowDummy = true;
            this.fld_lkeICProductAttributeID.BOSComment = null;
            this.fld_lkeICProductAttributeID.BOSDataMember = "";
            this.fld_lkeICProductAttributeID.BOSDataSource = "ICProductAttributes";
            this.fld_lkeICProductAttributeID.BOSDescription = null;
            this.fld_lkeICProductAttributeID.BOSError = null;
            this.fld_lkeICProductAttributeID.BOSFieldGroup = null;
            this.fld_lkeICProductAttributeID.BOSFieldParent = null;
            this.fld_lkeICProductAttributeID.BOSFieldRelation = null;
            this.fld_lkeICProductAttributeID.BOSPrivilege = null;
            this.fld_lkeICProductAttributeID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductAttributeID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeICProductAttributeID.BOSSelectTypeValue = "WoodType";
            this.fld_lkeICProductAttributeID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeICProductAttributeID, "fld_lkeICProductAttributeID");
            this.fld_lkeICProductAttributeID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductAttributeID.Name = "fld_lkeICProductAttributeID";
            this.fld_lkeICProductAttributeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeICProductAttributeID.Properties.Buttons"))))});
            this.fld_lkeICProductAttributeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeICProductAttributeID.Properties.Columns"), resources.GetString("fld_lkeICProductAttributeID.Properties.Columns1"))});
            this.fld_lkeICProductAttributeID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeICProductAttributeID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeICProductAttributeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductAttributeID, ((bool)(resources.GetObject("fld_lkeICProductAttributeID.ShowHelp"))));
            this.fld_lkeICProductAttributeID.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel6, "bosLabel6");
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, ((bool)(resources.GetObject("bosLabel6.ShowHelp"))));
            // 
            // RP137
            // 
            this.AcceptButton = this.fld_btnExportExcel;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RP137";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RP137_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcRP137ICReceiptItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptItemLotNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductAttributeID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnExportExcel;
        private BOSComponent.BOSButton fld_btnClose;
        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSLine bosLine1;
        private RP137ReceiptItemsGridControl fld_dgcRP137ICReceiptItems;
        private BOSComponent.BOSLookupEdit fld_lkeICProductAttributeID;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtICReceiptItemLotNo;
    }
}