using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BusinessResult.UI
{
	/// <summary>
	/// Summary description for DMBR100
	/// </summary>
	partial class DMBR100
    {


		/// <summary>
		/// Clean up any resources being used
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
				if (components != null)
					components.Dispose();
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACBusinessResultOpeningFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteACBusinessResultOpeningToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcACBusinessResultDetails = new BOSERP.Modules.BusinessResult.ACBusinessResultDetailsGridControl();
            this.fld_dgvHREmployeeAllowances = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnAdd = new BOSComponent.BOSButton(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACBusinessResultFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteACBusinessResultToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultOpeningFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultOpeningFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultOpeningToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultOpeningToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACBusinessResultDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeAllowances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultToDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosPanel1
            // 
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.bosLookupEdit1);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_dteACBusinessResultOpeningFromDate);
            this.bosPanel1.Controls.Add(this.fld_dteACBusinessResultOpeningToDate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosPanel1.Controls.Add(this.bosLabel18);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Controls.Add(this.fld_btnAdd);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_dteACBusinessResultFromDate);
            this.bosPanel1.Controls.Add(this.fld_dteACBusinessResultToDate);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 8;
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_BRBranchCentralID";
            this.bosLookupEdit1.BOSDataSource = "ACBusinessResults";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = "";
            this.bosLookupEdit1.BOSFieldParent = null;
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = "BRBranchType";
            this.bosLookupEdit1.BOSSelectTypeValue = "Central";
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(558, 12);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.bosLookupEdit1.Properties.DisplayMember = "BRBranchName";
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "BRBranchID";
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 2;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = "ARInvoices";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(504, 15);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 597;
            this.bosLabel3.Text = "Trung tâm";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel1.Location = new System.Drawing.Point(13, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(83, 13);
            this.bosLabel1.TabIndex = 593;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Từ ngày kỳ trước";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
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
            this.bosLabel2.Location = new System.Drawing.Point(254, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(90, 13);
            this.bosLabel2.TabIndex = 594;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Đến ngày kỳ trước";
            // 
            // fld_dteACBusinessResultOpeningFromDate
            // 
            this.fld_dteACBusinessResultOpeningFromDate.BOSComment = "";
            this.fld_dteACBusinessResultOpeningFromDate.BOSDataMember = "ACBusinessResultOpeningFromDate";
            this.fld_dteACBusinessResultOpeningFromDate.BOSDataSource = "ACBusinessResults";
            this.fld_dteACBusinessResultOpeningFromDate.BOSDescription = null;
            this.fld_dteACBusinessResultOpeningFromDate.BOSError = null;
            this.fld_dteACBusinessResultOpeningFromDate.BOSFieldGroup = "";
            this.fld_dteACBusinessResultOpeningFromDate.BOSFieldRelation = "";
            this.fld_dteACBusinessResultOpeningFromDate.BOSPrivilege = "";
            this.fld_dteACBusinessResultOpeningFromDate.BOSPropertyName = "EditValue";
            this.fld_dteACBusinessResultOpeningFromDate.EditValue = null;
            this.fld_dteACBusinessResultOpeningFromDate.Location = new System.Drawing.Point(102, 12);
            this.fld_dteACBusinessResultOpeningFromDate.Name = "fld_dteACBusinessResultOpeningFromDate";
            this.fld_dteACBusinessResultOpeningFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACBusinessResultOpeningFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACBusinessResultOpeningFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACBusinessResultOpeningFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACBusinessResultOpeningFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACBusinessResultOpeningFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACBusinessResultOpeningFromDate.Screen = null;
            this.fld_dteACBusinessResultOpeningFromDate.Size = new System.Drawing.Size(146, 20);
            this.fld_dteACBusinessResultOpeningFromDate.TabIndex = 0;
            this.fld_dteACBusinessResultOpeningFromDate.Tag = "DC";
            // 
            // fld_dteACBusinessResultOpeningToDate
            // 
            this.fld_dteACBusinessResultOpeningToDate.BOSComment = "";
            this.fld_dteACBusinessResultOpeningToDate.BOSDataMember = "ACBusinessResultOpeningToDate";
            this.fld_dteACBusinessResultOpeningToDate.BOSDataSource = "ACBusinessResults";
            this.fld_dteACBusinessResultOpeningToDate.BOSDescription = null;
            this.fld_dteACBusinessResultOpeningToDate.BOSError = null;
            this.fld_dteACBusinessResultOpeningToDate.BOSFieldGroup = "";
            this.fld_dteACBusinessResultOpeningToDate.BOSFieldRelation = "";
            this.fld_dteACBusinessResultOpeningToDate.BOSPrivilege = "";
            this.fld_dteACBusinessResultOpeningToDate.BOSPropertyName = "EditValue";
            this.fld_dteACBusinessResultOpeningToDate.EditValue = null;
            this.fld_dteACBusinessResultOpeningToDate.Location = new System.Drawing.Point(350, 12);
            this.fld_dteACBusinessResultOpeningToDate.Name = "fld_dteACBusinessResultOpeningToDate";
            this.fld_dteACBusinessResultOpeningToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACBusinessResultOpeningToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACBusinessResultOpeningToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACBusinessResultOpeningToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACBusinessResultOpeningToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACBusinessResultOpeningToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACBusinessResultOpeningToDate.Screen = null;
            this.fld_dteACBusinessResultOpeningToDate.Size = new System.Drawing.Size(148, 20);
            this.fld_dteACBusinessResultOpeningToDate.TabIndex = 1;
            this.fld_dteACBusinessResultOpeningToDate.Tag = "DC";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchID.BOSComment = null;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ACBusinessResults";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = null;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = null;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = null;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = null;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = null;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(558, 38);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 5;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = null;
            this.bosLabel18.BOSDataMember = null;
            this.bosLabel18.BOSDataSource = "ARInvoices";
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = null;
            this.bosLabel18.BOSFieldRelation = null;
            this.bosLabel18.BOSPrivilege = null;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(504, 41);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(48, 13);
            this.bosLabel18.TabIndex = 591;
            this.bosLabel18.Text = "Chi nhánh";
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcACBusinessResultDetails);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(3, 75);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(855, 489);
            this.fld_grcGroupControl.TabIndex = 76;
            this.fld_grcGroupControl.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_grcGroupControl.Text = "Chi tiết kết quả hoạt động kinh doanh";
            // 
            // fld_dgcACBusinessResultDetails
            // 
            this.fld_dgcACBusinessResultDetails.AllowDrop = true;
            this.fld_dgcACBusinessResultDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACBusinessResultDetails.BOSComment = "";
            this.fld_dgcACBusinessResultDetails.BOSDataMember = "";
            this.fld_dgcACBusinessResultDetails.BOSDataSource = "ACBusinessResultDetails";
            this.fld_dgcACBusinessResultDetails.BOSDescription = null;
            this.fld_dgcACBusinessResultDetails.BOSError = null;
            this.fld_dgcACBusinessResultDetails.BOSFieldGroup = "";
            this.fld_dgcACBusinessResultDetails.BOSFieldRelation = "";
            this.fld_dgcACBusinessResultDetails.BOSGridType = null;
            this.fld_dgcACBusinessResultDetails.BOSPrivilege = "";
            this.fld_dgcACBusinessResultDetails.BOSPropertyName = "";
            this.fld_dgcACBusinessResultDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACBusinessResultDetails.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcACBusinessResultDetails.MainView = this.fld_dgvHREmployeeAllowances;
            this.fld_dgcACBusinessResultDetails.Name = "fld_dgcACBusinessResultDetails";
            this.fld_dgcACBusinessResultDetails.PrintReport = false;
            this.fld_dgcACBusinessResultDetails.Screen = null;
            this.fld_dgcACBusinessResultDetails.Size = new System.Drawing.Size(845, 459);
            this.fld_dgcACBusinessResultDetails.TabIndex = 12;
            this.fld_dgcACBusinessResultDetails.Tag = "DC";
            this.fld_dgcACBusinessResultDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeAllowances});
            // 
            // fld_dgvHREmployeeAllowances
            // 
            this.fld_dgvHREmployeeAllowances.GridControl = this.fld_dgcACBusinessResultDetails;
            this.fld_dgvHREmployeeAllowances.Name = "fld_dgvHREmployeeAllowances";
            this.fld_dgvHREmployeeAllowances.PaintStyleName = "Office2003";
            // 
            // fld_btnAdd
            // 
            this.fld_btnAdd.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAdd.Appearance.Options.UseForeColor = true;
            this.fld_btnAdd.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.BOSDescription = null;
            this.fld_btnAdd.BOSError = null;
            this.fld_btnAdd.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.Location = new System.Drawing.Point(714, 38);
            this.fld_btnAdd.Name = "fld_btnAdd";
            this.fld_btnAdd.Screen = null;
            this.fld_btnAdd.Size = new System.Drawing.Size(69, 20);
            this.fld_btnAdd.TabIndex = 75;
            this.fld_btnAdd.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_btnAdd.Text = "Xem";
            this.fld_btnAdd.Click += new System.EventHandler(this.fld_btnAdd_Click);
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.Location = new System.Drawing.Point(13, 41);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel5.TabIndex = 71;
            this.fld_lblLabel5.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel5.Text = "Từ ngày";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.Location = new System.Drawing.Point(254, 41);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel6.TabIndex = 72;
            this.fld_lblLabel6.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.Text = "Đến ngày";
            // 
            // fld_dteACBusinessResultFromDate
            // 
            this.fld_dteACBusinessResultFromDate.BOSComment = string.Empty;
            this.fld_dteACBusinessResultFromDate.BOSDataMember = "ACBusinessResultFromDate";
            this.fld_dteACBusinessResultFromDate.BOSDataSource = "ACBusinessResults";
            this.fld_dteACBusinessResultFromDate.BOSDescription = null;
            this.fld_dteACBusinessResultFromDate.BOSError = null;
            this.fld_dteACBusinessResultFromDate.BOSFieldGroup = string.Empty;
            this.fld_dteACBusinessResultFromDate.BOSFieldRelation = string.Empty;
            this.fld_dteACBusinessResultFromDate.BOSPrivilege = string.Empty;
            this.fld_dteACBusinessResultFromDate.BOSPropertyName = "EditValue";
            this.fld_dteACBusinessResultFromDate.EditValue = null;
            this.fld_dteACBusinessResultFromDate.Location = new System.Drawing.Point(102, 38);
            this.fld_dteACBusinessResultFromDate.Name = "fld_dteACBusinessResultFromDate";
            this.fld_dteACBusinessResultFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACBusinessResultFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACBusinessResultFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACBusinessResultFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACBusinessResultFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACBusinessResultFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACBusinessResultFromDate.Screen = null;
            this.fld_dteACBusinessResultFromDate.Size = new System.Drawing.Size(146, 20);
            this.fld_dteACBusinessResultFromDate.TabIndex = 3;
            this.fld_dteACBusinessResultFromDate.Tag = "DC";
            // 
            // fld_dteACBusinessResultToDate
            // 
            this.fld_dteACBusinessResultToDate.BOSComment = string.Empty;
            this.fld_dteACBusinessResultToDate.BOSDataMember = "ACBusinessResultToDate";
            this.fld_dteACBusinessResultToDate.BOSDataSource = "ACBusinessResults";
            this.fld_dteACBusinessResultToDate.BOSDescription = null;
            this.fld_dteACBusinessResultToDate.BOSError = null;
            this.fld_dteACBusinessResultToDate.BOSFieldGroup = string.Empty;
            this.fld_dteACBusinessResultToDate.BOSFieldRelation = string.Empty;
            this.fld_dteACBusinessResultToDate.BOSPrivilege = string.Empty;
            this.fld_dteACBusinessResultToDate.BOSPropertyName = "EditValue";
            this.fld_dteACBusinessResultToDate.EditValue = null;
            this.fld_dteACBusinessResultToDate.Location = new System.Drawing.Point(350, 38);
            this.fld_dteACBusinessResultToDate.Name = "fld_dteACBusinessResultToDate";
            this.fld_dteACBusinessResultToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACBusinessResultToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACBusinessResultToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACBusinessResultToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACBusinessResultToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACBusinessResultToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACBusinessResultToDate.Screen = null;
            this.fld_dteACBusinessResultToDate.Size = new System.Drawing.Size(148, 20);
            this.fld_dteACBusinessResultToDate.TabIndex = 4;
            this.fld_dteACBusinessResultToDate.Tag = "DC";
            // 
            // DMBR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMBR100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultOpeningFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultOpeningFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultOpeningToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultOpeningToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACBusinessResultDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeAllowances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBusinessResultToDate.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private ACBusinessResultDetailsGridControl fld_dgcACBusinessResultDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeAllowances;
        private BOSComponent.BOSButton fld_btnAdd;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSDateEdit fld_dteACBusinessResultFromDate;
        private BOSComponent.BOSDateEdit fld_dteACBusinessResultToDate;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteACBusinessResultOpeningFromDate;
        private BOSComponent.BOSDateEdit fld_dteACBusinessResultOpeningToDate;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel3;
	}
}
