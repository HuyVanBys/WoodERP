namespace BOSERP.Modules.Report
{
    partial class RP194
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_lblSubTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_lblFromdateTodate = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcHREmployees = new BOSERP.Modules.Report.RP194SaleOrderGridControl();
            this.fld_lblBranchName = new BOSComponent.BOSLabel(this.components);
            this.fld_btnExportExcelXls = new BOSComponent.BOSButton(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.bosLabel8);
            this.panelControl1.Controls.Add(this.fld_lkeHREmployeeID);
            this.panelControl1.Controls.Add(this.fld_lkeBRBranchID);
            this.panelControl1.Controls.Add(this.bosLabel6);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromDate);
            this.panelControl1.Controls.Add(this.bosLabel10);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(866, 44);
            this.panelControl1.TabIndex = 1;
            // 
            // fld_lkeBRBranchID
            // 
            this.fld_lkeBRBranchID.BOSAllowAddNew = false;
            this.fld_lkeBRBranchID.BOSAllowDummy = true;
            this.fld_lkeBRBranchID.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeBRBranchID.BOSDataMember = "BRBranchID";
            this.fld_lkeBRBranchID.BOSDataSource = "BRBranchs";
            this.fld_lkeBRBranchID.BOSDescription = null;
            this.fld_lkeBRBranchID.BOSError = null;
            this.fld_lkeBRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeBRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeBRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeBRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeBRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeBRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeBRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeBRBranchID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(287, 9);
            this.fld_lkeBRBranchID.Name = "fld_lkeBRBranchID";
            this.fld_lkeBRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeBRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeBRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeBRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeBRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeBRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeBRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 1;
            this.fld_lkeBRBranchID.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(229, 12);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 117;
            this.bosLabel6.Text = "Chi nhánh";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = null;
            this.fld_dteSearchFromDate.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.fld_dteSearchFromDate.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.fld_dteSearchFromDate.BOSDescription = null;
            this.fld_dteSearchFromDate.BOSError = null;
            this.fld_dteSearchFromDate.BOSFieldGroup = null;
            this.fld_dteSearchFromDate.BOSFieldRelation = null;
            this.fld_dteSearchFromDate.BOSPrivilege = null;
            this.fld_dteSearchFromDate.BOSPropertyName = null;
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(59, 9);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromDate.TabIndex = 0;
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
            this.bosLabel10.Location = new System.Drawing.Point(19, 12);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(30, 13);
            this.bosLabel10.TabIndex = 10;
            this.bosLabel10.Text = "Tháng";
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
            this.fld_btnApply.Location = new System.Drawing.Point(677, 5);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(77, 28);
            this.fld_btnApply.TabIndex = 3;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_btnClose
            // 
            this.fld_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnClose.BOSComment = null;
            this.fld_btnClose.BOSDataMember = null;
            this.fld_btnClose.BOSDataSource = null;
            this.fld_btnClose.BOSDescription = null;
            this.fld_btnClose.BOSError = null;
            this.fld_btnClose.BOSFieldGroup = null;
            this.fld_btnClose.BOSFieldRelation = null;
            this.fld_btnClose.BOSPrivilege = null;
            this.fld_btnClose.BOSPropertyName = null;
            this.fld_btnClose.Location = new System.Drawing.Point(779, 639);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 0;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_lblTitle
            // 
            this.fld_lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
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
            this.fld_lblTitle.Location = new System.Drawing.Point(303, 50);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(260, 19);
            this.fld_lblTitle.TabIndex = 1;
            this.fld_lblTitle.Text = "BÁO CÁO TỔNG HỢP DOANH SỐ";
            // 
            // fld_lblSubTitle
            // 
            this.fld_lblSubTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_lblSubTitle.Appearance.Options.UseFont = true;
            this.fld_lblSubTitle.BOSComment = null;
            this.fld_lblSubTitle.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.fld_lblSubTitle.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.fld_lblSubTitle.BOSDescription = null;
            this.fld_lblSubTitle.BOSError = null;
            this.fld_lblSubTitle.BOSFieldGroup = null;
            this.fld_lblSubTitle.BOSFieldRelation = null;
            this.fld_lblSubTitle.BOSPrivilege = null;
            this.fld_lblSubTitle.BOSPropertyName = null;
            this.fld_lblSubTitle.Location = new System.Drawing.Point(529, 96);
            this.fld_lblSubTitle.Name = "fld_lblSubTitle";
            this.fld_lblSubTitle.Screen = null;
            this.fld_lblSubTitle.Size = new System.Drawing.Size(0, 19);
            this.fld_lblSubTitle.TabIndex = 2;
            this.fld_lblSubTitle.Tag = "HD";
            // 
            // fld_lblFromdateTodate
            // 
            this.fld_lblFromdateTodate.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_lblFromdateTodate.Appearance.Options.UseFont = true;
            this.fld_lblFromdateTodate.BOSComment = null;
            this.fld_lblFromdateTodate.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.fld_lblFromdateTodate.BOSDataSource = global::Localization.ReportLocalizedResources.String2;
            this.fld_lblFromdateTodate.BOSDescription = null;
            this.fld_lblFromdateTodate.BOSError = null;
            this.fld_lblFromdateTodate.BOSFieldGroup = null;
            this.fld_lblFromdateTodate.BOSFieldRelation = null;
            this.fld_lblFromdateTodate.BOSPrivilege = null;
            this.fld_lblFromdateTodate.BOSPropertyName = null;
            this.fld_lblFromdateTodate.Location = new System.Drawing.Point(287, 121);
            this.fld_lblFromdateTodate.Name = "fld_lblFromdateTodate";
            this.fld_lblFromdateTodate.Screen = null;
            this.fld_lblFromdateTodate.Size = new System.Drawing.Size(0, 16);
            this.fld_lblFromdateTodate.TabIndex = 3;
            this.fld_lblFromdateTodate.Tag = "HD";
            // 
            // fld_dgcHREmployees
            // 
            this.fld_dgcHREmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployees.BOSComment = null;
            this.fld_dgcHREmployees.BOSDataMember = null;
            this.fld_dgcHREmployees.BOSDataSource = "HREmployees";
            this.fld_dgcHREmployees.BOSDescription = null;
            this.fld_dgcHREmployees.BOSError = null;
            this.fld_dgcHREmployees.BOSFieldGroup = null;
            this.fld_dgcHREmployees.BOSFieldRelation = null;
            this.fld_dgcHREmployees.BOSGridType = null;
            this.fld_dgcHREmployees.BOSPrivilege = null;
            this.fld_dgcHREmployees.BOSPropertyName = null;
            this.fld_dgcHREmployees.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.fld_dgcHREmployees.EmbeddedNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fld_dgcHREmployees.EmbeddedNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fld_dgcHREmployees.EmbeddedNavigator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fld_dgcHREmployees.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None;
            this.fld_dgcHREmployees.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.fld_dgcHREmployees.Location = new System.Drawing.Point(0, 100);
            this.fld_dgcHREmployees.MenuManager = this.screenToolbar;
            this.fld_dgcHREmployees.Name = "fld_dgcHREmployees";
            this.fld_dgcHREmployees.PrintReport = false;
            this.fld_dgcHREmployees.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHREmployees, false);
            this.fld_dgcHREmployees.Size = new System.Drawing.Size(866, 533);
            this.fld_dgcHREmployees.TabIndex = 0;
            // 
            // fld_lblBranchName
            // 
            this.fld_lblBranchName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblBranchName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.fld_lblBranchName.Appearance.Options.UseFont = true;
            this.fld_lblBranchName.BOSComment = null;
            this.fld_lblBranchName.BOSDataMember = null;
            this.fld_lblBranchName.BOSDataSource = null;
            this.fld_lblBranchName.BOSDescription = null;
            this.fld_lblBranchName.BOSError = null;
            this.fld_lblBranchName.BOSFieldGroup = null;
            this.fld_lblBranchName.BOSFieldRelation = null;
            this.fld_lblBranchName.BOSPrivilege = null;
            this.fld_lblBranchName.BOSPropertyName = null;
            this.fld_lblBranchName.Location = new System.Drawing.Point(395, 75);
            this.fld_lblBranchName.Name = "fld_lblBranchName";
            this.fld_lblBranchName.Screen = null;
            this.fld_lblBranchName.Size = new System.Drawing.Size(38, 19);
            this.fld_lblBranchName.TabIndex = 9;
            this.fld_lblBranchName.Text = "Text";
            // 
            // fld_btnExportExcelXls
            // 
            this.fld_btnExportExcelXls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnExportExcelXls.BOSComment = null;
            this.fld_btnExportExcelXls.BOSDataMember = null;
            this.fld_btnExportExcelXls.BOSDataSource = null;
            this.fld_btnExportExcelXls.BOSDescription = null;
            this.fld_btnExportExcelXls.BOSError = null;
            this.fld_btnExportExcelXls.BOSFieldGroup = null;
            this.fld_btnExportExcelXls.BOSFieldRelation = null;
            this.fld_btnExportExcelXls.BOSPrivilege = null;
            this.fld_btnExportExcelXls.BOSPropertyName = null;
            this.fld_btnExportExcelXls.Location = new System.Drawing.Point(698, 639);
            this.fld_btnExportExcelXls.Name = "fld_btnExportExcelXls";
            this.fld_btnExportExcelXls.Screen = null;
            this.fld_btnExportExcelXls.Size = new System.Drawing.Size(75, 27);
            this.fld_btnExportExcelXls.TabIndex = 10;
            this.fld_btnExportExcelXls.Text = "Xuất excel";
            this.fld_btnExportExcelXls.Click += new System.EventHandler(this.fld_btnExportExcelXls_Click);
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(457, 12);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(49, 13);
            this.bosLabel8.TabIndex = 119;
            this.bosLabel8.Text = "Người bán";
            // 
            // fld_lkeHREmployeeID
            // 
            this.fld_lkeHREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeID.BOSAllowDummy = true;
            this.fld_lkeHREmployeeID.BOSComment = null;
            this.fld_lkeHREmployeeID.BOSDataMember = "HREmployeeID";
            this.fld_lkeHREmployeeID.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeeID.BOSDescription = null;
            this.fld_lkeHREmployeeID.BOSError = null;
            this.fld_lkeHREmployeeID.BOSFieldGroup = null;
            this.fld_lkeHREmployeeID.BOSFieldParent = null;
            this.fld_lkeHREmployeeID.BOSFieldRelation = null;
            this.fld_lkeHREmployeeID.BOSPrivilege = null;
            this.fld_lkeHREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeID.BOSSelectType = null;
            this.fld_lkeHREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeID.CurrentDisplayText = null;
            this.fld_lkeHREmployeeID.Location = new System.Drawing.Point(512, 9);
            this.fld_lkeHREmployeeID.Name = "fld_lkeHREmployeeID";
            this.fld_lkeHREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeHREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeHREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.String2;
            this.fld_lkeHREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeHREmployeeID.Screen = null;
            this.fld_lkeHREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHREmployeeID.TabIndex = 2;
            this.fld_lkeHREmployeeID.Tag = "DC";
            // 
            // RP194
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 674);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnExportExcelXls);
            this.Controls.Add(this.fld_lblBranchName);
            this.Controls.Add(this.fld_dgcHREmployees);
            this.Controls.Add(this.fld_lblTitle);
            this.Controls.Add(this.fld_lblFromdateTodate);
            this.Controls.Add(this.fld_lblSubTitle);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.panelControl1);
            this.Name = "RP194";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tổng hợp doanh số";
            this.Load += new System.EventHandler(this.RP194_Load);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_lblSubTitle, 0);
            this.Controls.SetChildIndex(this.fld_lblFromdateTodate, 0);
            this.Controls.SetChildIndex(this.fld_lblTitle, 0);
            this.Controls.SetChildIndex(this.fld_dgcHREmployees, 0);
            this.Controls.SetChildIndex(this.fld_lblBranchName, 0);
            this.Controls.SetChildIndex(this.fld_btnExportExcelXls, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSLabel fld_lblTitle;
        private BOSComponent.BOSLabel fld_lblSubTitle;
        private BOSComponent.BOSLabel fld_lblFromdateTodate;
        private BOSComponent.BOSLabel bosLabel6;
        private RP194SaleOrderGridControl fld_dgcHREmployees;
        private BOSComponent.BOSLabel fld_lblBranchName;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private BOSComponent.BOSButton fld_btnExportExcelXls;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeID;
    }
}