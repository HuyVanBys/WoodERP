using BOSComponent;
namespace BOSERP.Modules.Report
{
    partial class RP183
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP183));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblFrom = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_lbl_FromdateTodate = new BOSComponent.BOSLabel(this.components);
            this.fld_btnExcel = new BOSComponent.BOSButton(this.components);
            this.fld_dgcICReceiptItems = new BOSComponent.BOSGridControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeICProductID);
            this.panelControl1.Controls.Add(this.bosLabel1);
            this.panelControl1.Controls.Add(this.fld_dteSearchToDate);
            this.panelControl1.Controls.Add(this.bosLabel9);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromDate);
            this.panelControl1.Controls.Add(this.fld_lblFrom);
            this.panelControl1.Controls.Add(this.bosLabel11);
            this.panelControl1.Controls.Add(this.fld_lkeMMBatchProductID);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // fld_lkeICProductID
            // 
            this.fld_lkeICProductID.BOSAllowAddNew = false;
            this.fld_lkeICProductID.BOSAllowDummy = true;
            this.fld_lkeICProductID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductID.BOSDataMember = "ICProductID";
            this.fld_lkeICProductID.BOSDataSource = "ICProducts";
            this.fld_lkeICProductID.BOSDescription = null;
            this.fld_lkeICProductID.BOSError = null;
            this.fld_lkeICProductID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            resources.ApplyResources(this.fld_lkeICProductID, "fld_lkeICProductID");
            this.fld_lkeICProductID.Name = "fld_lkeICProductID";
            this.fld_lkeICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeICProductID.Properties.Buttons"))))});
            this.fld_lkeICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeICProductID.Properties.Columns"), resources.GetString("fld_lkeICProductID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeICProductID.Properties.Columns2"), resources.GetString("fld_lkeICProductID.Properties.Columns3"))});
            this.fld_lkeICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeICProductID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeICProductID, ((bool)(resources.GetObject("fld_lkeICProductID.ShowHelp"))));
            this.fld_lkeICProductID.Tag = global::Localization.ReportLocalizedResources.String1;
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
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.BOSComment = null;
            this.fld_dteSearchToDate.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchToDate.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
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
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = null;
            this.fld_dteSearchFromDate.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteSearchFromDate.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
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
            this.fld_dteSearchFromDate.Tag = "DC";
            // 
            // fld_lblFrom
            // 
            this.fld_lblFrom.BOSComment = null;
            this.fld_lblFrom.BOSDataMember = null;
            this.fld_lblFrom.BOSDataSource = null;
            this.fld_lblFrom.BOSDescription = null;
            this.fld_lblFrom.BOSError = null;
            this.fld_lblFrom.BOSFieldGroup = null;
            this.fld_lblFrom.BOSFieldRelation = null;
            this.fld_lblFrom.BOSPrivilege = null;
            this.fld_lblFrom.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblFrom, "fld_lblFrom");
            this.fld_lblFrom.Name = "fld_lblFrom";
            this.fld_lblFrom.Screen = null;
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel11.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel11, "bosLabel11");
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Tag = global::Localization.ReportLocalizedResources.String1;
            // 
            // fld_lkeMMBatchProductID
            // 
            this.fld_lkeMMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeMMBatchProductID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.BOSDataMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductID.BOSDescription = null;
            this.fld_lkeMMBatchProductID.BOSError = null;
            this.fld_lkeMMBatchProductID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            resources.ApplyResources(this.fld_lkeMMBatchProductID, "fld_lkeMMBatchProductID");
            this.fld_lkeMMBatchProductID.Name = "fld_lkeMMBatchProductID";
            this.fld_lkeMMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeMMBatchProductID.Properties.Buttons"))))});
            this.fld_lkeMMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeMMBatchProductID.Properties.Columns"), resources.GetString("fld_lkeMMBatchProductID.Properties.Columns1"))});
            this.fld_lkeMMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeMMBatchProductID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.Screen = null;
            this.fld_lkeMMBatchProductID.Tag = global::Localization.ReportLocalizedResources.String1;
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
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_lblTitle
            // 
            this.fld_lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.fld_lblTitle.Appearance.Options.UseFont = true;
            this.fld_lblTitle.BOSComment = null;
            this.fld_lblTitle.BOSDataMember = null;
            this.fld_lblTitle.BOSDataSource = null;
            this.fld_lblTitle.BOSDescription = null;
            this.fld_lblTitle.BOSError = null;
            this.fld_lblTitle.BOSFieldGroup = null;
            this.fld_lblTitle.BOSFieldRelation = null;
            this.fld_lblTitle.BOSPrivilege = null;
            this.fld_lblTitle.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblTitle, "fld_lblTitle");
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
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
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_lbl_FromdateTodate
            // 
            this.fld_lbl_FromdateTodate.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.fld_lbl_FromdateTodate.Appearance.Options.UseFont = true;
            this.fld_lbl_FromdateTodate.BOSComment = null;
            this.fld_lbl_FromdateTodate.BOSDataMember = null;
            this.fld_lbl_FromdateTodate.BOSDataSource = null;
            this.fld_lbl_FromdateTodate.BOSDescription = null;
            this.fld_lbl_FromdateTodate.BOSError = null;
            this.fld_lbl_FromdateTodate.BOSFieldGroup = null;
            this.fld_lbl_FromdateTodate.BOSFieldRelation = null;
            this.fld_lbl_FromdateTodate.BOSPrivilege = null;
            this.fld_lbl_FromdateTodate.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lbl_FromdateTodate, "fld_lbl_FromdateTodate");
            this.fld_lbl_FromdateTodate.Name = "fld_lbl_FromdateTodate";
            this.fld_lbl_FromdateTodate.Screen = null;
            // 
            // fld_btnExcel
            // 
            resources.ApplyResources(this.fld_btnExcel, "fld_btnExcel");
            this.fld_btnExcel.BOSComment = null;
            this.fld_btnExcel.BOSDataMember = null;
            this.fld_btnExcel.BOSDataSource = null;
            this.fld_btnExcel.BOSDescription = null;
            this.fld_btnExcel.BOSError = null;
            this.fld_btnExcel.BOSFieldGroup = null;
            this.fld_btnExcel.BOSFieldRelation = null;
            this.fld_btnExcel.BOSPrivilege = null;
            this.fld_btnExcel.BOSPropertyName = null;
            this.fld_btnExcel.Name = "fld_btnExcel";
            this.fld_btnExcel.Screen = null;
            this.fld_btnExcel.Click += new System.EventHandler(this.fld_btnExcel_Click);
            // 
            // fld_dgcICReceiptItems
            // 
            resources.ApplyResources(this.fld_dgcICReceiptItems, "fld_dgcICReceiptItems");
            this.fld_dgcICReceiptItems.BOSComment = null;
            this.fld_dgcICReceiptItems.BOSDataMember = null;
            this.fld_dgcICReceiptItems.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcICReceiptItems.BOSDescription = null;
            this.fld_dgcICReceiptItems.BOSError = null;
            this.fld_dgcICReceiptItems.BOSFieldGroup = null;
            this.fld_dgcICReceiptItems.BOSFieldRelation = null;
            this.fld_dgcICReceiptItems.BOSGridType = null;
            this.fld_dgcICReceiptItems.BOSPrivilege = null;
            this.fld_dgcICReceiptItems.BOSPropertyName = null;
            this.fld_dgcICReceiptItems.MenuManager = this.screenToolbar;
            this.fld_dgcICReceiptItems.Name = "fld_dgcICReceiptItems";
            this.fld_dgcICReceiptItems.PrintReport = false;
            this.fld_dgcICReceiptItems.Screen = null;
            // 
            // RP183
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = true;
            this.Controls.Add(this.fld_dgcICReceiptItems);
            this.Controls.Add(this.fld_btnExcel);
            this.Controls.Add(this.fld_lbl_FromdateTodate);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.fld_lblTitle);
            this.Controls.Add(this.fld_btnClose);
            this.Name = "RP183";
            this.Tag = "SS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RP182_Load);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_lblTitle, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_lbl_FromdateTodate, 0);
            this.Controls.SetChildIndex(this.fld_btnExcel, 0);
            this.Controls.SetChildIndex(this.fld_dgcICReceiptItems, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceiptItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLabel fld_lblTitle;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSLabel fld_lbl_FromdateTodate;
        private BOSComponent.BOSButton fld_btnExcel;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductID;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSLabel fld_lblFrom;
        private BOSGridControl fld_dgcICReceiptItems;
        private BOSLabel bosLabel1;
        private BOSLookupEdit fld_lkeICProductID;
    }
}