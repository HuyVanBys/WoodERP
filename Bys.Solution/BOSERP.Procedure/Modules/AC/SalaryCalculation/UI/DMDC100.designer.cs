using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SalaryCalculation.UI
{
	/// <summary>
	/// Summary description for DMDC100
	/// </summary>
	partial class DMDC100
    {
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private BOSComponent.BOSTextBox fld_txtACSalaryCalculationNo1;
		private BOSComponent.BOSDateEdit fld_dteACSalaryCalculationDate;
		private BOSComponent.BOSMemoEdit fld_medACSalaryCalculationDesc;
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;


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
            this.fld_txtACSalaryCalculationNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteACSalaryCalculationDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medACSalaryCalculationDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcSalaryCalculationDetails = new BOSERP.Modules.SalaryCalculation.ACSalaryCalculationDetailsGridControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_txtAPPaymentVoucherExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACSalaryCalculationStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtACSalaryCalculationReference = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteACSalaryCalculationEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSalaryCalculationNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACSalaryCalculationDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACSalaryCalculationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACSalaryCalculationDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSalaryCalculationDetails)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentVoucherExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACSalaryCalculationStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSalaryCalculationReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACSalaryCalculationEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtACSalaryCalculationNo1
            // 
            this.fld_txtACSalaryCalculationNo1.BOSComment = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_txtACSalaryCalculationNo1.BOSDataMember = "ACSalaryCalculationNo";
            this.fld_txtACSalaryCalculationNo1.BOSDataSource = "ACSalaryCalculations";
            this.fld_txtACSalaryCalculationNo1.BOSDescription = null;
            this.fld_txtACSalaryCalculationNo1.BOSError = null;
            this.fld_txtACSalaryCalculationNo1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_txtACSalaryCalculationNo1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_txtACSalaryCalculationNo1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_txtACSalaryCalculationNo1.BOSPropertyName = "Text";
            this.fld_txtACSalaryCalculationNo1.EditValue = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_txtACSalaryCalculationNo1.Location = new System.Drawing.Point(219, 12);
            this.fld_txtACSalaryCalculationNo1.Name = "fld_txtACSalaryCalculationNo1";
            this.fld_txtACSalaryCalculationNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACSalaryCalculationNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACSalaryCalculationNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACSalaryCalculationNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACSalaryCalculationNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACSalaryCalculationNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACSalaryCalculationNo1.Screen = null;
            this.fld_txtACSalaryCalculationNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACSalaryCalculationNo1.TabIndex = 0;
            this.fld_txtACSalaryCalculationNo1.Tag = "DC";
            // 
            // fld_dteACSalaryCalculationDate
            // 
            this.fld_dteACSalaryCalculationDate.BOSComment = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_dteACSalaryCalculationDate.BOSDataMember = "ACSalaryCalculationDate";
            this.fld_dteACSalaryCalculationDate.BOSDataSource = "ACSalaryCalculations";
            this.fld_dteACSalaryCalculationDate.BOSDescription = null;
            this.fld_dteACSalaryCalculationDate.BOSError = null;
            this.fld_dteACSalaryCalculationDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_dteACSalaryCalculationDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_dteACSalaryCalculationDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_dteACSalaryCalculationDate.BOSPropertyName = "EditValue";
            this.fld_dteACSalaryCalculationDate.EditValue = null;
            this.fld_dteACSalaryCalculationDate.Location = new System.Drawing.Point(489, 12);
            this.fld_dteACSalaryCalculationDate.Name = "fld_dteACSalaryCalculationDate";
            this.fld_dteACSalaryCalculationDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACSalaryCalculationDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACSalaryCalculationDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACSalaryCalculationDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACSalaryCalculationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACSalaryCalculationDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACSalaryCalculationDate.Screen = null;
            this.fld_dteACSalaryCalculationDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACSalaryCalculationDate.TabIndex = 1;
            this.fld_dteACSalaryCalculationDate.Tag = "DC";
            // 
            // fld_medACSalaryCalculationDesc
            // 
            this.fld_medACSalaryCalculationDesc.BOSComment = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_medACSalaryCalculationDesc.BOSDataMember = "ACSalaryCalculationDesc";
            this.fld_medACSalaryCalculationDesc.BOSDataSource = "ACSalaryCalculations";
            this.fld_medACSalaryCalculationDesc.BOSDescription = null;
            this.fld_medACSalaryCalculationDesc.BOSError = null;
            this.fld_medACSalaryCalculationDesc.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_medACSalaryCalculationDesc.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_medACSalaryCalculationDesc.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_medACSalaryCalculationDesc.BOSPropertyName = "Text";
            this.fld_medACSalaryCalculationDesc.EditValue = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_medACSalaryCalculationDesc.Location = new System.Drawing.Point(219, 64);
            this.fld_medACSalaryCalculationDesc.Name = "fld_medACSalaryCalculationDesc";
            this.fld_medACSalaryCalculationDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACSalaryCalculationDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACSalaryCalculationDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACSalaryCalculationDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACSalaryCalculationDesc.Screen = null;
            this.fld_medACSalaryCalculationDesc.Size = new System.Drawing.Size(420, 47);
            this.fld_medACSalaryCalculationDesc.TabIndex = 3;
            this.fld_medACSalaryCalculationDesc.Tag = "DC";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel2.Location = new System.Drawing.Point(128, 15);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel2.TabIndex = 9;
            this.fld_lblLabel2.Tag = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel2.Text = "Mã chứng từ";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel3.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel3.Location = new System.Drawing.Point(397, 15);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel3.TabIndex = 3;
            this.fld_lblLabel3.Tag = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel3.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel4.Location = new System.Drawing.Point(128, 67);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel4.TabIndex = 7;
            this.fld_lblLabel4.Tag = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lblLabel4.Text = "Diễn giải";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_grcGroupControl1.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcSalaryCalculationDetails);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(3, 134);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(928, 433);
            this.fld_grcGroupControl1.TabIndex = 0;
            this.fld_grcGroupControl1.Tag = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_grcGroupControl1.Text = "Chi tiết";
            // 
            // fld_dgcSalaryCalculationDetails
            // 
            this.fld_dgcSalaryCalculationDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcSalaryCalculationDetails.BOSComment = null;
            this.fld_dgcSalaryCalculationDetails.BOSDataMember = null;
            this.fld_dgcSalaryCalculationDetails.BOSDataSource = "ACSalaryCalculationDetails";
            this.fld_dgcSalaryCalculationDetails.BOSDescription = null;
            this.fld_dgcSalaryCalculationDetails.BOSError = null;
            this.fld_dgcSalaryCalculationDetails.BOSFieldGroup = null;
            this.fld_dgcSalaryCalculationDetails.BOSFieldRelation = null;
            this.fld_dgcSalaryCalculationDetails.BOSGridType = null;
            this.fld_dgcSalaryCalculationDetails.BOSPrivilege = null;
            this.fld_dgcSalaryCalculationDetails.BOSPropertyName = null;
            this.fld_dgcSalaryCalculationDetails.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcSalaryCalculationDetails.MenuManager = this.screenToolbar;
            this.fld_dgcSalaryCalculationDetails.Name = "fld_dgcSalaryCalculationDetails";
            this.fld_dgcSalaryCalculationDetails.PrintReport = false;
            this.fld_dgcSalaryCalculationDetails.Screen = null;
            this.fld_dgcSalaryCalculationDetails.Size = new System.Drawing.Size(923, 405);
            this.fld_dgcSalaryCalculationDetails.TabIndex = 1;
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosPanel1.Controls.Add(this.fld_txtAPPaymentVoucherExchangeRate);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lkeACSalaryCalculationStatus);
            this.bosPanel1.Controls.Add(this.fld_txtACSalaryCalculationReference);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel15);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl1);
            this.bosPanel1.Controls.Add(this.fld_pteACSalaryCalculationEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.fld_txtACSalaryCalculationNo1);
            this.bosPanel1.Controls.Add(this.fld_dteACSalaryCalculationDate);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_medACSalaryCalculationDesc);
            this.bosPanel1.Controls.Add(this.fld_lblLabel3);
            this.bosPanel1.Controls.Add(this.fld_lblLabel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(939, 567);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_txtAPPaymentVoucherExchangeRate
            // 
            this.fld_txtAPPaymentVoucherExchangeRate.BOSComment = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_txtAPPaymentVoucherExchangeRate.BOSDataMember = "ACSalaryCalculationExchangeRate";
            this.fld_txtAPPaymentVoucherExchangeRate.BOSDataSource = "ACSalaryCalculations";
            this.fld_txtAPPaymentVoucherExchangeRate.BOSDescription = null;
            this.fld_txtAPPaymentVoucherExchangeRate.BOSError = null;
            this.fld_txtAPPaymentVoucherExchangeRate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_txtAPPaymentVoucherExchangeRate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_txtAPPaymentVoucherExchangeRate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_txtAPPaymentVoucherExchangeRate.BOSPropertyName = "Text";
            this.fld_txtAPPaymentVoucherExchangeRate.EditValue = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_txtAPPaymentVoucherExchangeRate.Location = new System.Drawing.Point(746, 38);
            this.fld_txtAPPaymentVoucherExchangeRate.Name = "fld_txtAPPaymentVoucherExchangeRate";
            this.fld_txtAPPaymentVoucherExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPaymentVoucherExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPaymentVoucherExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPaymentVoucherExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPaymentVoucherExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPaymentVoucherExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPaymentVoucherExchangeRate.Screen = null;
            this.fld_txtAPPaymentVoucherExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPPaymentVoucherExchangeRate.TabIndex = 846;
            this.fld_txtAPPaymentVoucherExchangeRate.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(663, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(29, 13);
            this.bosLabel4.TabIndex = 845;
            this.bosLabel4.Text = "Tỷ giá";
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
            this.bosLabel1.Location = new System.Drawing.Point(397, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(53, 13);
            this.bosLabel1.TabIndex = 843;
            this.bosLabel1.Text = "Loại tiền tệ";
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(663, 67);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 841;
            this.bosLabel3.Text = "Trạng thái";
            // 
            // fld_lkeACSalaryCalculationStatus
            // 
            this.fld_lkeACSalaryCalculationStatus.BOSAllowAddNew = false;
            this.fld_lkeACSalaryCalculationStatus.BOSAllowDummy = false;
            this.fld_lkeACSalaryCalculationStatus.BOSComment = null;
            this.fld_lkeACSalaryCalculationStatus.BOSDataMember = "ACSalaryCalculationStatus";
            this.fld_lkeACSalaryCalculationStatus.BOSDataSource = "ACSalaryCalculations";
            this.fld_lkeACSalaryCalculationStatus.BOSDescription = null;
            this.fld_lkeACSalaryCalculationStatus.BOSError = null;
            this.fld_lkeACSalaryCalculationStatus.BOSFieldGroup = null;
            this.fld_lkeACSalaryCalculationStatus.BOSFieldParent = null;
            this.fld_lkeACSalaryCalculationStatus.BOSFieldRelation = null;
            this.fld_lkeACSalaryCalculationStatus.BOSPrivilege = null;
            this.fld_lkeACSalaryCalculationStatus.BOSPropertyName = "EditValue";
            this.fld_lkeACSalaryCalculationStatus.BOSSelectType = null;
            this.fld_lkeACSalaryCalculationStatus.BOSSelectTypeValue = null;
            this.fld_lkeACSalaryCalculationStatus.CurrentDisplayText = null;
            this.fld_lkeACSalaryCalculationStatus.Location = new System.Drawing.Point(746, 64);
            this.fld_lkeACSalaryCalculationStatus.MenuManager = this.screenToolbar;
            this.fld_lkeACSalaryCalculationStatus.Name = "fld_lkeACSalaryCalculationStatus";
            this.fld_lkeACSalaryCalculationStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACSalaryCalculationStatus.Properties.ReadOnly = true;
            this.fld_lkeACSalaryCalculationStatus.Screen = null;
            this.fld_lkeACSalaryCalculationStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACSalaryCalculationStatus.TabIndex = 840;
            this.fld_lkeACSalaryCalculationStatus.Tag = "DC";
            // 
            // fld_txtACSalaryCalculationReference
            // 
            this.fld_txtACSalaryCalculationReference.BOSComment = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_txtACSalaryCalculationReference.BOSDataMember = "ACSalaryCalculationReference";
            this.fld_txtACSalaryCalculationReference.BOSDataSource = "ACSalaryCalculations";
            this.fld_txtACSalaryCalculationReference.BOSDescription = null;
            this.fld_txtACSalaryCalculationReference.BOSError = null;
            this.fld_txtACSalaryCalculationReference.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_txtACSalaryCalculationReference.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_txtACSalaryCalculationReference.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_txtACSalaryCalculationReference.BOSPropertyName = "Text";
            this.fld_txtACSalaryCalculationReference.EditValue = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_txtACSalaryCalculationReference.Location = new System.Drawing.Point(219, 38);
            this.fld_txtACSalaryCalculationReference.Name = "fld_txtACSalaryCalculationReference";
            this.fld_txtACSalaryCalculationReference.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACSalaryCalculationReference.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACSalaryCalculationReference.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACSalaryCalculationReference.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACSalaryCalculationReference.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACSalaryCalculationReference.Properties.ReadOnly = true;
            this.fld_txtACSalaryCalculationReference.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACSalaryCalculationReference.Screen = null;
            this.fld_txtACSalaryCalculationReference.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACSalaryCalculationReference.TabIndex = 5;
            this.fld_txtACSalaryCalculationReference.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(128, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(54, 13);
            this.bosLabel2.TabIndex = 838;
            this.bosLabel2.Text = "Bảng lương";
            // 
            // bosLabel15
            // 
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = null;
            this.bosLabel15.BOSDataSource = null;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = null;
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(663, 15);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(48, 13);
            this.bosLabel15.TabIndex = 835;
            this.bosLabel15.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchID.BOSComment = null;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ACSalaryCalculations";
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
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(746, 12);
            this.fld_lkeFK_BRBranchID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Đơn vị"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchCompanyName", "Công ty")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 2;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            // 
            // fld_pteACSalaryCalculationEmployeePicture
            // 
            this.fld_pteACSalaryCalculationEmployeePicture.BOSComment = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_pteACSalaryCalculationEmployeePicture.BOSDataMember = "ACSalaryCalculationEmployeePicture";
            this.fld_pteACSalaryCalculationEmployeePicture.BOSDataSource = "ACSalaryCalculations";
            this.fld_pteACSalaryCalculationEmployeePicture.BOSDescription = null;
            this.fld_pteACSalaryCalculationEmployeePicture.BOSError = null;
            this.fld_pteACSalaryCalculationEmployeePicture.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_pteACSalaryCalculationEmployeePicture.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_pteACSalaryCalculationEmployeePicture.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_pteACSalaryCalculationEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteACSalaryCalculationEmployeePicture.EditValue = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_pteACSalaryCalculationEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteACSalaryCalculationEmployeePicture.Name = "fld_pteACSalaryCalculationEmployeePicture";
            this.fld_pteACSalaryCalculationEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteACSalaryCalculationEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteACSalaryCalculationEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteACSalaryCalculationEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteACSalaryCalculationEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteACSalaryCalculationEmployeePicture.Screen = null;
            this.fld_pteACSalaryCalculationEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteACSalaryCalculationEmployeePicture.TabIndex = 0;
            this.fld_pteACSalaryCalculationEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ACSalaryCalculations";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 105);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.SaleOrderLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeFName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = true;
            this.fld_lkeFK_GECurrencyID.BOSComment = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "ACSalaryCalculations";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(489, 38);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String1;
            this.fld_lkeFK_GECurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 847;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            // 
            // DMDC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(939, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMDC100";
            this.Text = "Thông tin ";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSalaryCalculationNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACSalaryCalculationDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACSalaryCalculationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACSalaryCalculationDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSalaryCalculationDetails)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPaymentVoucherExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACSalaryCalculationStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSalaryCalculationReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACSalaryCalculationEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPictureEdit fld_pteACSalaryCalculationEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSTextBox fld_txtACSalaryCalculationReference;
        private BOSComponent.BOSLabel bosLabel2;
        private ACSalaryCalculationDetailsGridControl fld_dgcSalaryCalculationDetails;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeACSalaryCalculationStatus;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtAPPaymentVoucherExchangeRate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
	}
}