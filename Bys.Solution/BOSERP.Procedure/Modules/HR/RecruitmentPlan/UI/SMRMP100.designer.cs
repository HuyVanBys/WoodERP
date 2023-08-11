using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.RecruitmentPlan.UI
{
	/// <summary>
	/// Summary description for SMRMP100
	/// </summary>
	partial class SMRMP100
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
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcHRRecruitmentPlans = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvGridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteSearchHRRecruitmentPlanFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchHRRecruitmentPlanToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRRecruitmentPlanNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeSearchFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRRecruitmentPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRRecruitmentPlanFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRRecruitmentPlanFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRRecruitmentPlanToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRRecruitmentPlanToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRecruitmentPlanNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSearchFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(33, 40);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel11.TabIndex = 24;
            this.fld_lblLabel11.Tag = "SI";
            this.fld_lblLabel11.Text = "Mã chứng từ";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(33, 92);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel14.TabIndex = 27;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Ngày chứng từ từ";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(317, 92);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel17.TabIndex = 30;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến";
            // 
            // fld_dgcHRRecruitmentPlans
            // 
            this.fld_dgcHRRecruitmentPlans.AllowDrop = true;
            this.fld_dgcHRRecruitmentPlans.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRRecruitmentPlans.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRRecruitmentPlans.BOSDataSource = "HRRecruitmentPlans";
            this.fld_dgcHRRecruitmentPlans.BOSDescription = null;
            this.fld_dgcHRRecruitmentPlans.BOSError = null;
            this.fld_dgcHRRecruitmentPlans.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRRecruitmentPlans.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRRecruitmentPlans.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcHRRecruitmentPlans.BOSPropertyName = null;
            this.fld_dgcHRRecruitmentPlans.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRRecruitmentPlans.Location = new System.Drawing.Point(32, 216);
            this.fld_dgcHRRecruitmentPlans.MainView = this.fld_dgvGridControl;
            this.fld_dgcHRRecruitmentPlans.Name = "fld_dgcHRRecruitmentPlans";
            this.fld_dgcHRRecruitmentPlans.Screen = null;
            this.fld_dgcHRRecruitmentPlans.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRRecruitmentPlans.TabIndex = 4;
            this.fld_dgcHRRecruitmentPlans.Tag = "SR";
            this.fld_dgcHRRecruitmentPlans.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl});
            // 
            // fld_dgvGridControl
            // 
            this.fld_dgvGridControl.GridControl = this.fld_dgcHRRecruitmentPlans;
            this.fld_dgvGridControl.Name = "fld_dgvGridControl";
            this.fld_dgvGridControl.PaintStyleName = "Office2003";
            // 
            // fld_dteSearchHRRecruitmentPlanFromDate
            // 
            this.fld_dteSearchHRRecruitmentPlanFromDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHRRecruitmentPlanFromDate.BOSDataMember = "HRRecruitmentPlanFromDate";
            this.fld_dteSearchHRRecruitmentPlanFromDate.BOSDataSource = "HRRecruitmentPlans";
            this.fld_dteSearchHRRecruitmentPlanFromDate.BOSDescription = null;
            this.fld_dteSearchHRRecruitmentPlanFromDate.BOSError = null;
            this.fld_dteSearchHRRecruitmentPlanFromDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHRRecruitmentPlanFromDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHRRecruitmentPlanFromDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHRRecruitmentPlanFromDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchHRRecruitmentPlanFromDate.EditValue = null;
            this.fld_dteSearchHRRecruitmentPlanFromDate.Location = new System.Drawing.Point(144, 89);
            this.fld_dteSearchHRRecruitmentPlanFromDate.Name = "fld_dteSearchHRRecruitmentPlanFromDate";
            this.fld_dteSearchHRRecruitmentPlanFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchHRRecruitmentPlanFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchHRRecruitmentPlanFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchHRRecruitmentPlanFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchHRRecruitmentPlanFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchHRRecruitmentPlanFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchHRRecruitmentPlanFromDate.Screen = null;
            this.fld_dteSearchHRRecruitmentPlanFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchHRRecruitmentPlanFromDate.TabIndex = 2;
            this.fld_dteSearchHRRecruitmentPlanFromDate.Tag = "SC";
            // 
            // fld_dteSearchHRRecruitmentPlanToDate
            // 
            this.fld_dteSearchHRRecruitmentPlanToDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHRRecruitmentPlanToDate.BOSDataMember = "HRRecruitmentPlanToDate";
            this.fld_dteSearchHRRecruitmentPlanToDate.BOSDataSource = "HRRecruitmentPlans";
            this.fld_dteSearchHRRecruitmentPlanToDate.BOSDescription = null;
            this.fld_dteSearchHRRecruitmentPlanToDate.BOSError = null;
            this.fld_dteSearchHRRecruitmentPlanToDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHRRecruitmentPlanToDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHRRecruitmentPlanToDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteSearchHRRecruitmentPlanToDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchHRRecruitmentPlanToDate.EditValue = null;
            this.fld_dteSearchHRRecruitmentPlanToDate.Location = new System.Drawing.Point(351, 89);
            this.fld_dteSearchHRRecruitmentPlanToDate.Name = "fld_dteSearchHRRecruitmentPlanToDate";
            this.fld_dteSearchHRRecruitmentPlanToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchHRRecruitmentPlanToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchHRRecruitmentPlanToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchHRRecruitmentPlanToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchHRRecruitmentPlanToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchHRRecruitmentPlanToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchHRRecruitmentPlanToDate.Screen = null;
            this.fld_dteSearchHRRecruitmentPlanToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchHRRecruitmentPlanToDate.TabIndex = 3;
            this.fld_dteSearchHRRecruitmentPlanToDate.Tag = "SC";
            // 
            // fld_txtHRRecruitmentPlanNo
            // 
            this.fld_txtHRRecruitmentPlanNo.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRRecruitmentPlanNo.BOSDataMember = "HRRecruitmentPlanNo";
            this.fld_txtHRRecruitmentPlanNo.BOSDataSource = "HRRecruitmentPlans";
            this.fld_txtHRRecruitmentPlanNo.BOSDescription = null;
            this.fld_txtHRRecruitmentPlanNo.BOSError = null;
            this.fld_txtHRRecruitmentPlanNo.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRRecruitmentPlanNo.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRRecruitmentPlanNo.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRRecruitmentPlanNo.BOSPropertyName = "EditValue";
            this.fld_txtHRRecruitmentPlanNo.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtHRRecruitmentPlanNo.Location = new System.Drawing.Point(144, 37);
            this.fld_txtHRRecruitmentPlanNo.Name = "fld_txtHRRecruitmentPlanNo";
            this.fld_txtHRRecruitmentPlanNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRRecruitmentPlanNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRRecruitmentPlanNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRRecruitmentPlanNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRRecruitmentPlanNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRRecruitmentPlanNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRRecruitmentPlanNo.Screen = null;
            this.fld_txtHRRecruitmentPlanNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRRecruitmentPlanNo.TabIndex = 0;
            this.fld_txtHRRecruitmentPlanNo.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel2.Location = new System.Drawing.Point(32, 66);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 39;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // fld_lkeSearchFK_BRBranchID
            // 
            this.fld_lkeSearchFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeSearchFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeSearchFK_BRBranchID.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeSearchFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeSearchFK_BRBranchID.BOSDataSource = "HRRecruitmentPlans";
            this.fld_lkeSearchFK_BRBranchID.BOSDescription = null;
            this.fld_lkeSearchFK_BRBranchID.BOSError = null;
            this.fld_lkeSearchFK_BRBranchID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeSearchFK_BRBranchID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeSearchFK_BRBranchID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeSearchFK_BRBranchID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeSearchFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeSearchFK_BRBranchID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeSearchFK_BRBranchID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeSearchFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeSearchFK_BRBranchID.Location = new System.Drawing.Point(144, 63);
            this.fld_lkeSearchFK_BRBranchID.Name = "fld_lkeSearchFK_BRBranchID";
            this.fld_lkeSearchFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeSearchFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeSearchFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeSearchFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeSearchFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeSearchFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeSearchFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeSearchFK_BRBranchID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeSearchFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeSearchFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeSearchFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeSearchFK_BRBranchID.Screen = null;
            this.fld_lkeSearchFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeSearchFK_BRBranchID.TabIndex = 1;
            this.fld_lkeSearchFK_BRBranchID.Tag = "SC";
            // 
            // SMRMP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeSearchFK_BRBranchID);
            this.Controls.Add(this.fld_dgcHRRecruitmentPlans);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.fld_txtHRRecruitmentPlanNo);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_dteSearchHRRecruitmentPlanFromDate);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dteSearchHRRecruitmentPlanToDate);
            this.Name = "SMRMP100";
            this.Tag = "SI";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dteSearchHRRecruitmentPlanToDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchHRRecruitmentPlanFromDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_txtHRRecruitmentPlanNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRRecruitmentPlans, 0);
            this.Controls.SetChildIndex(this.fld_lkeSearchFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRRecruitmentPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRRecruitmentPlanFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRRecruitmentPlanFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRRecruitmentPlanToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchHRRecruitmentPlanToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRRecruitmentPlanNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeSearchFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSSearchResultsGridControl fld_dgcHRRecruitmentPlans;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl;
        private BOSComponent.BOSDateEdit fld_dteSearchHRRecruitmentPlanFromDate;
        private BOSComponent.BOSDateEdit fld_dteSearchHRRecruitmentPlanToDate;
        private BOSComponent.BOSTextBox fld_txtHRRecruitmentPlanNo;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeSearchFK_BRBranchID;
	}
}
