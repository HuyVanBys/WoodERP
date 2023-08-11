using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BalanceAmountArising.UI
{
	/// <summary>
	/// Summary description for DMBAA100
	/// </summary>
	partial class DMBAA100
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
            this.fld_medARSaleOrderDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACBalanceAmountArisingNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_tabCompany = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabBalanceAmountArisingDetail = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACBalanceAmountArisingDetails = new BOSERP.Modules.BalanceAmountArising.ACBalanceAmountArisingDetailsGridControl();
            this.fld_dgvHREmployeeAllowances = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabBalanceAmountArisingObjectDetail = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACBalanceAmountArisingObjectDetails = new BOSERP.Modules.BalanceAmountArising.ACBalanceAmountArisingObjectDetailsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnAdd = new BOSComponent.BOSButton(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACBalanceAmountArisingFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteACBalanceAmountArisingToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARSaleOrderDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBalanceAmountArisingNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCompany)).BeginInit();
            this.fld_tabCompany.SuspendLayout();
            this.fld_tabBalanceAmountArisingDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACBalanceAmountArisingDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeAllowances)).BeginInit();
            this.fld_tabBalanceAmountArisingObjectDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACBalanceAmountArisingObjectDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBalanceAmountArisingFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBalanceAmountArisingFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBalanceAmountArisingToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBalanceAmountArisingToDate.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_medARSaleOrderDesc);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lblLabel);
            this.bosPanel1.Controls.Add(this.fld_txtACBalanceAmountArisingNo);
            this.bosPanel1.Controls.Add(this.fld_tabCompany);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosPanel1.Controls.Add(this.bosLabel18);
            this.bosPanel1.Controls.Add(this.fld_btnAdd);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_dteACBalanceAmountArisingFromDate);
            this.bosPanel1.Controls.Add(this.fld_dteACBalanceAmountArisingToDate);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_medARSaleOrderDesc
            // 
            this.fld_medARSaleOrderDesc.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_medARSaleOrderDesc.BOSDataMember = "ARSaleOrderDesc";
            this.fld_medARSaleOrderDesc.BOSDataSource = "ARSaleOrders";
            this.fld_medARSaleOrderDesc.BOSDescription = null;
            this.fld_medARSaleOrderDesc.BOSError = null;
            this.fld_medARSaleOrderDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_medARSaleOrderDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_medARSaleOrderDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_medARSaleOrderDesc.BOSPropertyName = "EditValue";
            this.fld_medARSaleOrderDesc.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_medARSaleOrderDesc.Location = new System.Drawing.Point(99, 61);
            this.fld_medARSaleOrderDesc.Name = "fld_medARSaleOrderDesc";
            this.fld_medARSaleOrderDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARSaleOrderDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARSaleOrderDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARSaleOrderDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARSaleOrderDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medARSaleOrderDesc, true);
            this.fld_medARSaleOrderDesc.Size = new System.Drawing.Size(414, 35);
            this.fld_medARSaleOrderDesc.TabIndex = 9;
            this.fld_medARSaleOrderDesc.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(15, 64);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 8;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel3.Text = "Diễn giải";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.Location = new System.Drawing.Point(14, 12);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 0;
            this.fld_lblLabel.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_txtACBalanceAmountArisingNo
            // 
            this.fld_txtACBalanceAmountArisingNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACBalanceAmountArisingNo.BOSDataMember = "ACBalanceAmountArisingNo";
            this.fld_txtACBalanceAmountArisingNo.BOSDataSource = "ACBalanceAmountArisings";
            this.fld_txtACBalanceAmountArisingNo.BOSDescription = null;
            this.fld_txtACBalanceAmountArisingNo.BOSError = null;
            this.fld_txtACBalanceAmountArisingNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACBalanceAmountArisingNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACBalanceAmountArisingNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACBalanceAmountArisingNo.BOSPropertyName = "Text";
            this.fld_txtACBalanceAmountArisingNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtACBalanceAmountArisingNo.Location = new System.Drawing.Point(99, 9);
            this.fld_txtACBalanceAmountArisingNo.Name = "fld_txtACBalanceAmountArisingNo";
            this.fld_txtACBalanceAmountArisingNo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtACBalanceAmountArisingNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACBalanceAmountArisingNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACBalanceAmountArisingNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACBalanceAmountArisingNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACBalanceAmountArisingNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACBalanceAmountArisingNo.Screen = null;
            this.fld_txtACBalanceAmountArisingNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACBalanceAmountArisingNo.TabIndex = 1;
            this.fld_txtACBalanceAmountArisingNo.Tag = "DC";
            // 
            // fld_tabCompany
            // 
            this.fld_tabCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabCompany.BOSComment = null;
            this.fld_tabCompany.BOSDataMember = null;
            this.fld_tabCompany.BOSDataSource = null;
            this.fld_tabCompany.BOSDescription = null;
            this.fld_tabCompany.BOSError = null;
            this.fld_tabCompany.BOSFieldGroup = null;
            this.fld_tabCompany.BOSFieldRelation = null;
            this.fld_tabCompany.BOSPrivilege = null;
            this.fld_tabCompany.BOSPropertyName = null;
            this.fld_tabCompany.Location = new System.Drawing.Point(4, 102);
            this.fld_tabCompany.Name = "fld_tabCompany";
            this.fld_tabCompany.Screen = null;
            this.fld_tabCompany.SelectedTabPage = this.fld_tabBalanceAmountArisingDetail;
            this.ScreenHelper.SetShowHelp(this.fld_tabCompany, true);
            this.fld_tabCompany.Size = new System.Drawing.Size(855, 462);
            this.fld_tabCompany.TabIndex = 11;
            this.fld_tabCompany.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabBalanceAmountArisingDetail,
            this.fld_tabBalanceAmountArisingObjectDetail});
            // 
            // fld_tabBalanceAmountArisingDetail
            // 
            this.fld_tabBalanceAmountArisingDetail.Controls.Add(this.fld_dgcACBalanceAmountArisingDetails);
            this.fld_tabBalanceAmountArisingDetail.Name = "fld_tabBalanceAmountArisingDetail";
            this.fld_tabBalanceAmountArisingDetail.Size = new System.Drawing.Size(848, 433);
            this.fld_tabBalanceAmountArisingDetail.Text = "Bảng cân đối số phát sinh";
            // 
            // fld_dgcACBalanceAmountArisingDetails
            // 
            this.fld_dgcACBalanceAmountArisingDetails.AllowDrop = true;
            this.fld_dgcACBalanceAmountArisingDetails.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACBalanceAmountArisingDetails.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACBalanceAmountArisingDetails.BOSDataSource = "ACBalanceAmountArisingDetails";
            this.fld_dgcACBalanceAmountArisingDetails.BOSDescription = null;
            this.fld_dgcACBalanceAmountArisingDetails.BOSError = null;
            this.fld_dgcACBalanceAmountArisingDetails.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACBalanceAmountArisingDetails.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACBalanceAmountArisingDetails.BOSGridType = null;
            this.fld_dgcACBalanceAmountArisingDetails.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACBalanceAmountArisingDetails.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcACBalanceAmountArisingDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACBalanceAmountArisingDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACBalanceAmountArisingDetails.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACBalanceAmountArisingDetails.MainView = this.fld_dgvHREmployeeAllowances;
            this.fld_dgcACBalanceAmountArisingDetails.Name = "fld_dgcACBalanceAmountArisingDetails";
            this.fld_dgcACBalanceAmountArisingDetails.PrintReport = false;
            this.fld_dgcACBalanceAmountArisingDetails.Screen = null;
            this.fld_dgcACBalanceAmountArisingDetails.Size = new System.Drawing.Size(848, 433);
            this.fld_dgcACBalanceAmountArisingDetails.TabIndex = 0;
            this.fld_dgcACBalanceAmountArisingDetails.Tag = "DC";
            this.fld_dgcACBalanceAmountArisingDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeeAllowances});
            // 
            // fld_dgvHREmployeeAllowances
            // 
            this.fld_dgvHREmployeeAllowances.GridControl = this.fld_dgcACBalanceAmountArisingDetails;
            this.fld_dgvHREmployeeAllowances.Name = "fld_dgvHREmployeeAllowances";
            this.fld_dgvHREmployeeAllowances.PaintStyleName = "Office2003";
            // 
            // fld_tabBalanceAmountArisingObjectDetail
            // 
            this.fld_tabBalanceAmountArisingObjectDetail.Controls.Add(this.fld_dgcACBalanceAmountArisingObjectDetails);
            this.fld_tabBalanceAmountArisingObjectDetail.Name = "fld_tabBalanceAmountArisingObjectDetail";
            this.fld_tabBalanceAmountArisingObjectDetail.Size = new System.Drawing.Size(848, 433);
            this.fld_tabBalanceAmountArisingObjectDetail.Text = "Bảng chi tiết số sư theo đối tượng và ngoại tệ";
            // 
            // fld_dgcACBalanceAmountArisingObjectDetails
            // 
            this.fld_dgcACBalanceAmountArisingObjectDetails.AllowDrop = true;
            this.fld_dgcACBalanceAmountArisingObjectDetails.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcACBalanceAmountArisingObjectDetails.BOSDataMember = null;
            this.fld_dgcACBalanceAmountArisingObjectDetails.BOSDataSource = "ACBalanceAmountArisingObjectDetails";
            this.fld_dgcACBalanceAmountArisingObjectDetails.BOSDescription = null;
            this.fld_dgcACBalanceAmountArisingObjectDetails.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcACBalanceAmountArisingObjectDetails.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcACBalanceAmountArisingObjectDetails.BOSFieldRelation = null;
            this.fld_dgcACBalanceAmountArisingObjectDetails.BOSGridType = null;
            this.fld_dgcACBalanceAmountArisingObjectDetails.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcACBalanceAmountArisingObjectDetails.BOSPropertyName = null;
            this.fld_dgcACBalanceAmountArisingObjectDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACBalanceAmountArisingObjectDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACBalanceAmountArisingObjectDetails.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACBalanceAmountArisingObjectDetails.MainView = this.gridView1;
            this.fld_dgcACBalanceAmountArisingObjectDetails.Name = "fld_dgcACBalanceAmountArisingObjectDetails";
            this.fld_dgcACBalanceAmountArisingObjectDetails.PrintReport = false;
            this.fld_dgcACBalanceAmountArisingObjectDetails.Screen = null;
            this.fld_dgcACBalanceAmountArisingObjectDetails.Size = new System.Drawing.Size(848, 433);
            this.fld_dgcACBalanceAmountArisingObjectDetails.TabIndex = 60;
            this.fld_dgcACBalanceAmountArisingObjectDetails.Tag = "DC";
            this.fld_dgcACBalanceAmountArisingObjectDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcACBalanceAmountArisingObjectDetails;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ACBalanceAmountArisings";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(363, 9);
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
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 3;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel18.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel18.BOSDataSource = "ARInvoices";
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel18.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel18.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(279, 12);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(48, 13);
            this.bosLabel18.TabIndex = 2;
            this.bosLabel18.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel18.Text = "Chi nhánh";
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
            this.fld_btnAdd.Location = new System.Drawing.Point(535, 64);
            this.fld_btnAdd.Name = "fld_btnAdd";
            this.fld_btnAdd.Screen = null;
            this.fld_btnAdd.Size = new System.Drawing.Size(98, 32);
            this.fld_btnAdd.TabIndex = 10;
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(14, 38);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel5.TabIndex = 4;
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(279, 38);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel6.TabIndex = 6;
            this.fld_lblLabel6.Tag = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel6.Text = "Đến ngày";
            // 
            // fld_dteACBalanceAmountArisingFromDate
            // 
            this.fld_dteACBalanceAmountArisingFromDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBalanceAmountArisingFromDate.BOSDataMember = "ACBalanceAmountArisingFromDate";
            this.fld_dteACBalanceAmountArisingFromDate.BOSDataSource = "ACBalanceAmountArisings";
            this.fld_dteACBalanceAmountArisingFromDate.BOSDescription = null;
            this.fld_dteACBalanceAmountArisingFromDate.BOSError = null;
            this.fld_dteACBalanceAmountArisingFromDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBalanceAmountArisingFromDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBalanceAmountArisingFromDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBalanceAmountArisingFromDate.BOSPropertyName = "EditValue";
            this.fld_dteACBalanceAmountArisingFromDate.EditValue = null;
            this.fld_dteACBalanceAmountArisingFromDate.Location = new System.Drawing.Point(99, 35);
            this.fld_dteACBalanceAmountArisingFromDate.Name = "fld_dteACBalanceAmountArisingFromDate";
            this.fld_dteACBalanceAmountArisingFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACBalanceAmountArisingFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACBalanceAmountArisingFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACBalanceAmountArisingFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACBalanceAmountArisingFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACBalanceAmountArisingFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACBalanceAmountArisingFromDate.Screen = null;
            this.fld_dteACBalanceAmountArisingFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACBalanceAmountArisingFromDate.TabIndex = 5;
            this.fld_dteACBalanceAmountArisingFromDate.Tag = "DC";
            // 
            // fld_dteACBalanceAmountArisingToDate
            // 
            this.fld_dteACBalanceAmountArisingToDate.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBalanceAmountArisingToDate.BOSDataMember = "ACBalanceAmountArisingToDate";
            this.fld_dteACBalanceAmountArisingToDate.BOSDataSource = "ACBalanceAmountArisings";
            this.fld_dteACBalanceAmountArisingToDate.BOSDescription = null;
            this.fld_dteACBalanceAmountArisingToDate.BOSError = null;
            this.fld_dteACBalanceAmountArisingToDate.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBalanceAmountArisingToDate.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBalanceAmountArisingToDate.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dteACBalanceAmountArisingToDate.BOSPropertyName = "EditValue";
            this.fld_dteACBalanceAmountArisingToDate.EditValue = null;
            this.fld_dteACBalanceAmountArisingToDate.Location = new System.Drawing.Point(363, 35);
            this.fld_dteACBalanceAmountArisingToDate.Name = "fld_dteACBalanceAmountArisingToDate";
            this.fld_dteACBalanceAmountArisingToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACBalanceAmountArisingToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACBalanceAmountArisingToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACBalanceAmountArisingToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACBalanceAmountArisingToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACBalanceAmountArisingToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACBalanceAmountArisingToDate.Screen = null;
            this.fld_dteACBalanceAmountArisingToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACBalanceAmountArisingToDate.TabIndex = 7;
            this.fld_dteACBalanceAmountArisingToDate.Tag = "DC";
            // 
            // DMBAA100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMBAA100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARSaleOrderDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACBalanceAmountArisingNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCompany)).EndInit();
            this.fld_tabCompany.ResumeLayout(false);
            this.fld_tabBalanceAmountArisingDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACBalanceAmountArisingDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeeAllowances)).EndInit();
            this.fld_tabBalanceAmountArisingObjectDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACBalanceAmountArisingObjectDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBalanceAmountArisingFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBalanceAmountArisingFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBalanceAmountArisingToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACBalanceAmountArisingToDate.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnAdd;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSDateEdit fld_dteACBalanceAmountArisingToDate;
        private BOSERP.Modules.BalanceAmountArising.ACBalanceAmountArisingDetailsGridControl fld_dgcACBalanceAmountArisingDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeeAllowances;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSTabControl fld_tabCompany;
        private DevExpress.XtraTab.XtraTabPage fld_tabBalanceAmountArisingDetail;
        private DevExpress.XtraTab.XtraTabPage fld_tabBalanceAmountArisingObjectDetail;
        private ACBalanceAmountArisingObjectDetailsGridControl fld_dgcACBalanceAmountArisingObjectDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSTextBox fld_txtACBalanceAmountArisingNo;
        private BOSComponent.BOSDateEdit fld_dteACBalanceAmountArisingFromDate;
        private BOSComponent.BOSMemoEdit fld_medARSaleOrderDesc;
        private BOSComponent.BOSLabel bosLabel3;
	}
}
