using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PurchaseContract.UI
{
	/// <summary>
	/// Summary description for DMPCT100
	/// </summary>
	partial class DMPCT100
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
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_txtAPPurchaseContractExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPurchaseContractTaxAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARPurchaseOrderSubTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPurchaseContractTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPurchaseContractTaxPercent = new BOSComponent.BOSTextBox(this.components);
            this.bosGroupControl6 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_APPurchaseContractGroupID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_PMProjectID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPPurchaseContractNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPurchaseContractName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosMemoEdit1 = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeAPPurchaseContractParentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkePurchaseContractStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteAPPurchaseContractDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteAPPurchaseContractEndDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAPPurchaseContractBeginDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeAPPurchaseContractType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.fld_ptdAPPurchaseContractEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit7 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseContractExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseContractTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARPurchaseOrderSubTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseContractTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseContractTaxPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl6)).BeginInit();
            this.bosGroupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APPurchaseContractGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseContractNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseContractName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseContractParentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePurchaseContractStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseContractDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseContractDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseContractEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseContractEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseContractBeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseContractBeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseContractType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptdAPPurchaseContractEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit7.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosPanel2
            // 
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.bosGroupControl1);
            this.bosPanel2.Controls.Add(this.bosGroupControl6);
            this.bosPanel2.Controls.Add(this.bosTextBox4);
            this.bosPanel2.Controls.Add(this.fld_ptdAPPurchaseContractEmployeePicture);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel2.Controls.Add(this.bosLabel22);
            this.bosPanel2.Controls.Add(this.bosLabel21);
            this.bosPanel2.Controls.Add(this.bosLookupEdit7);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(990, 574);
            this.bosPanel2.TabIndex = 585;
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_txtAPPurchaseContractExchangeRate);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel22);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.bosGroupControl1.Controls.Add(this.bosLabel18);
            this.bosGroupControl1.Controls.Add(this.fld_txtAPPurchaseContractTaxAmount);
            this.bosGroupControl1.Controls.Add(this.fld_txtARPurchaseOrderSubTotalCost);
            this.bosGroupControl1.Controls.Add(this.bosLabel17);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel16);
            this.bosGroupControl1.Controls.Add(this.fld_txtAPPurchaseContractTotalCost);
            this.bosGroupControl1.Controls.Add(this.bosLabel20);
            this.bosGroupControl1.Controls.Add(this.fld_txtAPPurchaseContractTaxPercent);
            this.bosGroupControl1.Location = new System.Drawing.Point(657, 8);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(321, 248);
            this.bosGroupControl1.TabIndex = 597;
            this.bosGroupControl1.Text = "Giá trị";
            // 
            // fld_txtAPPurchaseContractExchangeRate
            // 
            this.fld_txtAPPurchaseContractExchangeRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPPurchaseContractExchangeRate.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractExchangeRate.BOSDataMember = "APPurchaseContractExchangeRate";
            this.fld_txtAPPurchaseContractExchangeRate.BOSDataSource = "APPurchaseContracts";
            this.fld_txtAPPurchaseContractExchangeRate.BOSDescription = null;
            this.fld_txtAPPurchaseContractExchangeRate.BOSError = null;
            this.fld_txtAPPurchaseContractExchangeRate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractExchangeRate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractExchangeRate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractExchangeRate.BOSPropertyName = "Text";
            this.fld_txtAPPurchaseContractExchangeRate.EditValue = "0.00";
            this.fld_txtAPPurchaseContractExchangeRate.Location = new System.Drawing.Point(155, 57);
            this.fld_txtAPPurchaseContractExchangeRate.Name = "fld_txtAPPurchaseContractExchangeRate";
            this.fld_txtAPPurchaseContractExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPurchaseContractExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseContractExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseContractExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseContractExchangeRate.Properties.Mask.EditMask = "n";
            this.fld_txtAPPurchaseContractExchangeRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAPPurchaseContractExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPurchaseContractExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPurchaseContractExchangeRate.Screen = null;
            this.fld_txtAPPurchaseContractExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPPurchaseContractExchangeRate.TabIndex = 1;
            this.fld_txtAPPurchaseContractExchangeRate.Tag = "DC";
            // 
            // fld_lblLabel22
            // 
            this.fld_lblLabel22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel22.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel22.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel22.Appearance.Options.UseFont = true;
            this.fld_lblLabel22.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel22.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel22.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel22.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel22.BOSDescription = null;
            this.fld_lblLabel22.BOSError = null;
            this.fld_lblLabel22.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel22.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel22.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel22.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel22.Location = new System.Drawing.Point(17, 140);
            this.fld_lblLabel22.Name = "fld_lblLabel22";
            this.fld_lblLabel22.Screen = null;
            this.fld_lblLabel22.Size = new System.Drawing.Size(119, 13);
            this.fld_lblLabel22.TabIndex = 607;
            this.fld_lblLabel22.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel22.Text = "Tổng giá trị hợp đồng";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = false;
            this.fld_lkeFK_GECurrencyID.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "APPurchaseContracts";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(155, 31);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 0;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel18.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel18.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel18.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel18.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel18.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel18.Location = new System.Drawing.Point(17, 34);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(53, 13);
            this.bosLabel18.TabIndex = 594;
            this.bosLabel18.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel18.Text = "Loại tiền tệ";
            // 
            // fld_txtAPPurchaseContractTaxAmount
            // 
            this.fld_txtAPPurchaseContractTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPPurchaseContractTaxAmount.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractTaxAmount.BOSDataMember = "APPurchaseContractTaxAmount";
            this.fld_txtAPPurchaseContractTaxAmount.BOSDataSource = "APPurchaseContracts";
            this.fld_txtAPPurchaseContractTaxAmount.BOSDescription = null;
            this.fld_txtAPPurchaseContractTaxAmount.BOSError = null;
            this.fld_txtAPPurchaseContractTaxAmount.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractTaxAmount.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractTaxAmount.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractTaxAmount.BOSPropertyName = "Text";
            this.fld_txtAPPurchaseContractTaxAmount.EditValue = "0.00";
            this.fld_txtAPPurchaseContractTaxAmount.Location = new System.Drawing.Point(217, 109);
            this.fld_txtAPPurchaseContractTaxAmount.Name = "fld_txtAPPurchaseContractTaxAmount";
            this.fld_txtAPPurchaseContractTaxAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPurchaseContractTaxAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseContractTaxAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseContractTaxAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseContractTaxAmount.Properties.Mask.EditMask = "n";
            this.fld_txtAPPurchaseContractTaxAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAPPurchaseContractTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPurchaseContractTaxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPurchaseContractTaxAmount.Screen = null;
            this.fld_txtAPPurchaseContractTaxAmount.Size = new System.Drawing.Size(88, 20);
            this.fld_txtAPPurchaseContractTaxAmount.TabIndex = 4;
            this.fld_txtAPPurchaseContractTaxAmount.Tag = "DC";
            this.fld_txtAPPurchaseContractTaxAmount.Validated += new System.EventHandler(this.fld_txtAPPurchaseContractTaxAmount_Validated);
            // 
            // fld_txtARPurchaseOrderSubTotalCost
            // 
            this.fld_txtARPurchaseOrderSubTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtARPurchaseOrderSubTotalCost.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARPurchaseOrderSubTotalCost.BOSDataMember = "APPurchaseContractSubTotalAmount";
            this.fld_txtARPurchaseOrderSubTotalCost.BOSDataSource = "APPurchaseContracts";
            this.fld_txtARPurchaseOrderSubTotalCost.BOSDescription = null;
            this.fld_txtARPurchaseOrderSubTotalCost.BOSError = null;
            this.fld_txtARPurchaseOrderSubTotalCost.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARPurchaseOrderSubTotalCost.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARPurchaseOrderSubTotalCost.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtARPurchaseOrderSubTotalCost.BOSPropertyName = "Text";
            this.fld_txtARPurchaseOrderSubTotalCost.EditValue = "0.00";
            this.fld_txtARPurchaseOrderSubTotalCost.Location = new System.Drawing.Point(155, 83);
            this.fld_txtARPurchaseOrderSubTotalCost.Name = "fld_txtARPurchaseOrderSubTotalCost";
            this.fld_txtARPurchaseOrderSubTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtARPurchaseOrderSubTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARPurchaseOrderSubTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARPurchaseOrderSubTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARPurchaseOrderSubTotalCost.Properties.Mask.EditMask = "n";
            this.fld_txtARPurchaseOrderSubTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARPurchaseOrderSubTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARPurchaseOrderSubTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARPurchaseOrderSubTotalCost.Screen = null;
            this.fld_txtARPurchaseOrderSubTotalCost.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARPurchaseOrderSubTotalCost.TabIndex = 2;
            this.fld_txtARPurchaseOrderSubTotalCost.Tag = "DC";
            this.fld_txtARPurchaseOrderSubTotalCost.Validated += new System.EventHandler(this.fld_txtARPurchaseOrderSubTotalCost_Validated);
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel17.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel17.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel17.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel17.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel17.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel17.Location = new System.Drawing.Point(17, 59);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(29, 13);
            this.bosLabel17.TabIndex = 595;
            this.bosLabel17.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel17.Text = "Tỷ giá";
            // 
            // fld_lblLabel16
            // 
            this.fld_lblLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel16.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel16.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel16.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel16.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel16.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel16.BOSDescription = null;
            this.fld_lblLabel16.BOSError = null;
            this.fld_lblLabel16.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel16.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel16.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel16.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel16.Location = new System.Drawing.Point(17, 86);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.fld_lblLabel16.Size = new System.Drawing.Size(76, 13);
            this.fld_lblLabel16.TabIndex = 605;
            this.fld_lblLabel16.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel16.Text = "Giá trị hợp đồng";
            // 
            // fld_txtAPPurchaseContractTotalCost
            // 
            this.fld_txtAPPurchaseContractTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPPurchaseContractTotalCost.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractTotalCost.BOSDataMember = "APPurchaseContractTotalAmount";
            this.fld_txtAPPurchaseContractTotalCost.BOSDataSource = "APPurchaseContracts";
            this.fld_txtAPPurchaseContractTotalCost.BOSDescription = null;
            this.fld_txtAPPurchaseContractTotalCost.BOSError = null;
            this.fld_txtAPPurchaseContractTotalCost.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractTotalCost.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractTotalCost.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractTotalCost.BOSPropertyName = "Text";
            this.fld_txtAPPurchaseContractTotalCost.EditValue = "0.00";
            this.fld_txtAPPurchaseContractTotalCost.Location = new System.Drawing.Point(155, 135);
            this.fld_txtAPPurchaseContractTotalCost.Name = "fld_txtAPPurchaseContractTotalCost";
            this.fld_txtAPPurchaseContractTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.fld_txtAPPurchaseContractTotalCost.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_txtAPPurchaseContractTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseContractTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseContractTotalCost.Properties.Appearance.Options.UseFont = true;
            this.fld_txtAPPurchaseContractTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseContractTotalCost.Properties.Mask.EditMask = "n";
            this.fld_txtAPPurchaseContractTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAPPurchaseContractTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPurchaseContractTotalCost.Properties.ReadOnly = true;
            this.fld_txtAPPurchaseContractTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPurchaseContractTotalCost.Screen = null;
            this.fld_txtAPPurchaseContractTotalCost.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPPurchaseContractTotalCost.TabIndex = 5;
            this.fld_txtAPPurchaseContractTotalCost.Tag = "DC";
            // 
            // bosLabel20
            // 
            this.bosLabel20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel20.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel20.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel20.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel20.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel20.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel20.Location = new System.Drawing.Point(17, 112);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(24, 13);
            this.bosLabel20.TabIndex = 606;
            this.bosLabel20.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel20.Text = "Thuế";
            // 
            // fld_txtAPPurchaseContractTaxPercent
            // 
            this.fld_txtAPPurchaseContractTaxPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtAPPurchaseContractTaxPercent.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractTaxPercent.BOSDataMember = "APPurchaseContractTaxPercent";
            this.fld_txtAPPurchaseContractTaxPercent.BOSDataSource = "APPurchaseContracts";
            this.fld_txtAPPurchaseContractTaxPercent.BOSDescription = null;
            this.fld_txtAPPurchaseContractTaxPercent.BOSError = null;
            this.fld_txtAPPurchaseContractTaxPercent.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractTaxPercent.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractTaxPercent.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractTaxPercent.BOSPropertyName = "Text";
            this.fld_txtAPPurchaseContractTaxPercent.EditValue = "0.00";
            this.fld_txtAPPurchaseContractTaxPercent.Location = new System.Drawing.Point(155, 109);
            this.fld_txtAPPurchaseContractTaxPercent.Name = "fld_txtAPPurchaseContractTaxPercent";
            this.fld_txtAPPurchaseContractTaxPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPurchaseContractTaxPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseContractTaxPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseContractTaxPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseContractTaxPercent.Properties.Mask.EditMask = "n";
            this.fld_txtAPPurchaseContractTaxPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtAPPurchaseContractTaxPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPurchaseContractTaxPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPurchaseContractTaxPercent.Screen = null;
            this.fld_txtAPPurchaseContractTaxPercent.Size = new System.Drawing.Size(56, 20);
            this.fld_txtAPPurchaseContractTaxPercent.TabIndex = 3;
            this.fld_txtAPPurchaseContractTaxPercent.Tag = "DC";
            this.fld_txtAPPurchaseContractTaxPercent.Validated += new System.EventHandler(this.fld_txtAPPurchaseContractTaxPercent_Validated);
            // 
            // bosGroupControl6
            // 
            this.bosGroupControl6.BOSComment = null;
            this.bosGroupControl6.BOSDataMember = null;
            this.bosGroupControl6.BOSDataSource = null;
            this.bosGroupControl6.BOSDescription = null;
            this.bosGroupControl6.BOSError = null;
            this.bosGroupControl6.BOSFieldGroup = null;
            this.bosGroupControl6.BOSFieldRelation = null;
            this.bosGroupControl6.BOSPrivilege = null;
            this.bosGroupControl6.BOSPropertyName = null;
            this.bosGroupControl6.Controls.Add(this.fld_lkeFK_APPurchaseContractGroupID);
            this.bosGroupControl6.Controls.Add(this.fld_lkeFK_PMProjectID);
            this.bosGroupControl6.Controls.Add(this.bosLabel24);
            this.bosGroupControl6.Controls.Add(this.fld_lkeAPPurchaseContractNo);
            this.bosGroupControl6.Controls.Add(this.bosLabel9);
            this.bosGroupControl6.Controls.Add(this.bosLabel13);
            this.bosGroupControl6.Controls.Add(this.bosLabel6);
            this.bosGroupControl6.Controls.Add(this.fld_txtAPPurchaseContractName);
            this.bosGroupControl6.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.bosGroupControl6.Controls.Add(this.bosMemoEdit1);
            this.bosGroupControl6.Controls.Add(this.bosLabel14);
            this.bosGroupControl6.Controls.Add(this.fld_lblLabel1);
            this.bosGroupControl6.Controls.Add(this.bosLabel10);
            this.bosGroupControl6.Controls.Add(this.fld_lkeAPPurchaseContractParentID);
            this.bosGroupControl6.Controls.Add(this.fld_lkePurchaseContractStatus);
            this.bosGroupControl6.Controls.Add(this.fld_dteAPPurchaseContractDate);
            this.bosGroupControl6.Controls.Add(this.fld_dteAPPurchaseContractEndDate);
            this.bosGroupControl6.Controls.Add(this.bosLabel16);
            this.bosGroupControl6.Controls.Add(this.bosLabel11);
            this.bosGroupControl6.Controls.Add(this.bosLabel12);
            this.bosGroupControl6.Controls.Add(this.fld_dteAPPurchaseContractBeginDate);
            this.bosGroupControl6.Controls.Add(this.fld_lkeAPPurchaseContractType);
            this.bosGroupControl6.Controls.Add(this.bosLabel15);
            this.bosGroupControl6.Controls.Add(this.bosLabel4);
            this.bosGroupControl6.Location = new System.Drawing.Point(118, 7);
            this.bosGroupControl6.Name = "bosGroupControl6";
            this.bosGroupControl6.Screen = null;
            this.bosGroupControl6.Size = new System.Drawing.Size(533, 249);
            this.bosGroupControl6.TabIndex = 584;
            this.bosGroupControl6.Text = "Thông tin hợp đồng";
            // 
            // fld_lkeFK_APPurchaseContractGroupID
            // 
            this.fld_lkeFK_APPurchaseContractGroupID.BOSAllowAddNew = false;
            this.fld_lkeFK_APPurchaseContractGroupID.BOSAllowDummy = true;
            this.fld_lkeFK_APPurchaseContractGroupID.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_APPurchaseContractGroupID.BOSDataMember = "FK_APPurchaseContractGroupID";
            this.fld_lkeFK_APPurchaseContractGroupID.BOSDataSource = "APPurchaseContractGroups";
            this.fld_lkeFK_APPurchaseContractGroupID.BOSDescription = null;
            this.fld_lkeFK_APPurchaseContractGroupID.BOSError = null;
            this.fld_lkeFK_APPurchaseContractGroupID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_APPurchaseContractGroupID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_APPurchaseContractGroupID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_APPurchaseContractGroupID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_APPurchaseContractGroupID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APPurchaseContractGroupID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_APPurchaseContractGroupID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_APPurchaseContractGroupID.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_APPurchaseContractGroupID.Location = new System.Drawing.Point(369, 83);
            this.fld_lkeFK_APPurchaseContractGroupID.Name = "fld_lkeFK_APPurchaseContractGroupID";
            this.fld_lkeFK_APPurchaseContractGroupID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APPurchaseContractGroupID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APPurchaseContractGroupID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APPurchaseContractGroupID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APPurchaseContractGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APPurchaseContractGroupID.Properties.ColumnName = null;
            this.fld_lkeFK_APPurchaseContractGroupID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APPurchaseContractGroupNo", "Mã nhóm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APPurchaseContractGroupName", "Tên nhóm")});
            this.fld_lkeFK_APPurchaseContractGroupID.Properties.DisplayMember = "APPurchaseContractGroupName";
            this.fld_lkeFK_APPurchaseContractGroupID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_APPurchaseContractGroupID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APPurchaseContractGroupID.Properties.ValueMember = "APPurchaseContractGroupID";
            this.fld_lkeFK_APPurchaseContractGroupID.Screen = null;
            this.fld_lkeFK_APPurchaseContractGroupID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_APPurchaseContractGroupID.TabIndex = 4;
            this.fld_lkeFK_APPurchaseContractGroupID.Tag = "DC";
            // 
            // fld_lkeFK_PMProjectID
            // 
            this.fld_lkeFK_PMProjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectID.BOSAllowDummy = false;
            this.fld_lkeFK_PMProjectID.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_PMProjectID.BOSDataMember = "FK_PMProjectID";
            this.fld_lkeFK_PMProjectID.BOSDataSource = "APPurchaseContracts";
            this.fld_lkeFK_PMProjectID.BOSDescription = null;
            this.fld_lkeFK_PMProjectID.BOSError = null;
            this.fld_lkeFK_PMProjectID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_PMProjectID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_PMProjectID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_PMProjectID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_PMProjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMProjectID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_PMProjectID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_PMProjectID.CurrentDisplayText = null;
            this.fld_lkeFK_PMProjectID.Location = new System.Drawing.Point(369, 162);
            this.fld_lkeFK_PMProjectID.Name = "fld_lkeFK_PMProjectID";
            this.fld_lkeFK_PMProjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMProjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMProjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMProjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMProjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMProjectID.Properties.ColumnName = null;
            this.fld_lkeFK_PMProjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectNo", "Mã dự án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectName", "Tên dự án")});
            this.fld_lkeFK_PMProjectID.Properties.DisplayMember = "PMProjectNo";
            this.fld_lkeFK_PMProjectID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_PMProjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMProjectID.Properties.ValueMember = "PMProjectID";
            this.fld_lkeFK_PMProjectID.Screen = null;
            this.fld_lkeFK_PMProjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_PMProjectID.TabIndex = 10;
            this.fld_lkeFK_PMProjectID.Tag = "DC";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseForeColor = true;
            this.bosLabel24.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel24.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel24.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel24.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel24.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel24.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel24.Location = new System.Drawing.Point(276, 166);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(45, 13);
            this.bosLabel24.TabIndex = 602;
            this.bosLabel24.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel24.Text = "Mã dự án";
            // 
            // fld_lkeAPPurchaseContractNo
            // 
            this.fld_lkeAPPurchaseContractNo.BOSComment = null;
            this.fld_lkeAPPurchaseContractNo.BOSDataMember = "APPurchaseContractNo";
            this.fld_lkeAPPurchaseContractNo.BOSDataSource = "APPurchaseContracts";
            this.fld_lkeAPPurchaseContractNo.BOSDescription = null;
            this.fld_lkeAPPurchaseContractNo.BOSError = null;
            this.fld_lkeAPPurchaseContractNo.BOSFieldGroup = null;
            this.fld_lkeAPPurchaseContractNo.BOSFieldRelation = null;
            this.fld_lkeAPPurchaseContractNo.BOSPrivilege = null;
            this.fld_lkeAPPurchaseContractNo.BOSPropertyName = "EditValue";
            this.fld_lkeAPPurchaseContractNo.Location = new System.Drawing.Point(101, 32);
            this.fld_lkeAPPurchaseContractNo.MenuManager = this.screenToolbar;
            this.fld_lkeAPPurchaseContractNo.Name = "fld_lkeAPPurchaseContractNo";
            this.fld_lkeAPPurchaseContractNo.Screen = null;
            this.fld_lkeAPPurchaseContractNo.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPurchaseContractNo.TabIndex = 0;
            this.fld_lkeAPPurchaseContractNo.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(16, 35);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(60, 13);
            this.bosLabel9.TabIndex = 0;
            this.bosLabel9.Text = "Số hợp đồng";
            // 
            // bosLabel13
            // 
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = null;
            this.bosLabel13.BOSDataSource = null;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = null;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(276, 35);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(73, 13);
            this.bosLabel13.TabIndex = 4;
            this.bosLabel13.Text = "Ngày hợp đồng";
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
            this.bosLabel6.Location = new System.Drawing.Point(16, 61);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(66, 13);
            this.bosLabel6.TabIndex = 583;
            this.bosLabel6.Text = "Tên hợp đồng";
            // 
            // fld_txtAPPurchaseContractName
            // 
            this.fld_txtAPPurchaseContractName.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractName.BOSDataMember = "APPurchaseContractName";
            this.fld_txtAPPurchaseContractName.BOSDataSource = "APPurchaseContracts";
            this.fld_txtAPPurchaseContractName.BOSDescription = null;
            this.fld_txtAPPurchaseContractName.BOSError = null;
            this.fld_txtAPPurchaseContractName.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractName.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractName.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractName.BOSPropertyName = "Text";
            this.fld_txtAPPurchaseContractName.EditValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_txtAPPurchaseContractName.Location = new System.Drawing.Point(101, 58);
            this.fld_txtAPPurchaseContractName.Name = "fld_txtAPPurchaseContractName";
            this.fld_txtAPPurchaseContractName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtAPPurchaseContractName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseContractName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseContractName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseContractName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPurchaseContractName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPurchaseContractName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtAPPurchaseContractName, true);
            this.fld_txtAPPurchaseContractName.Size = new System.Drawing.Size(418, 20);
            this.fld_txtAPPurchaseContractName.TabIndex = 2;
            this.fld_txtAPPurchaseContractName.Tag = "DC";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "APPurchaseContracts";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.BOSModuleType = null;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(101, 136);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 7;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            // 
            // bosMemoEdit1
            // 
            this.bosMemoEdit1.BOSComment = null;
            this.bosMemoEdit1.BOSDataMember = "APPurchaseContractDesc";
            this.bosMemoEdit1.BOSDataSource = "APPurchaseContracts";
            this.bosMemoEdit1.BOSDescription = null;
            this.bosMemoEdit1.BOSError = null;
            this.bosMemoEdit1.BOSFieldGroup = null;
            this.bosMemoEdit1.BOSFieldRelation = null;
            this.bosMemoEdit1.BOSPrivilege = null;
            this.bosMemoEdit1.BOSPropertyName = "EditValue";
            this.bosMemoEdit1.Location = new System.Drawing.Point(101, 188);
            this.bosMemoEdit1.MenuManager = this.screenToolbar;
            this.bosMemoEdit1.Name = "bosMemoEdit1";
            this.bosMemoEdit1.Screen = null;
            this.bosMemoEdit1.Size = new System.Drawing.Size(418, 44);
            this.bosMemoEdit1.TabIndex = 11;
            this.bosMemoEdit1.Tag = "DC";
            // 
            // bosLabel14
            // 
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = null;
            this.bosLabel14.BOSDataSource = null;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(15, 165);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(66, 13);
            this.bosLabel14.TabIndex = 586;
            this.bosLabel14.Text = "Hợp đồng gốc";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel1.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel1.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel1.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel1.Location = new System.Drawing.Point(16, 139);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel1.TabIndex = 591;
            this.fld_lblLabel1.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel1.Text = "Đối tượng";
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
            this.bosLabel10.Location = new System.Drawing.Point(16, 191);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(27, 13);
            this.bosLabel10.TabIndex = 12;
            this.bosLabel10.Text = "Lưu ý";
            // 
            // fld_lkeAPPurchaseContractParentID
            // 
            this.fld_lkeAPPurchaseContractParentID.BOSAllowAddNew = false;
            this.fld_lkeAPPurchaseContractParentID.BOSAllowDummy = false;
            this.fld_lkeAPPurchaseContractParentID.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPPurchaseContractParentID.BOSDataMember = "APPurchaseContractParentID";
            this.fld_lkeAPPurchaseContractParentID.BOSDataSource = "APPurchaseContracts";
            this.fld_lkeAPPurchaseContractParentID.BOSDescription = null;
            this.fld_lkeAPPurchaseContractParentID.BOSError = null;
            this.fld_lkeAPPurchaseContractParentID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPPurchaseContractParentID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPPurchaseContractParentID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPPurchaseContractParentID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPPurchaseContractParentID.BOSPropertyName = "EditValue";
            this.fld_lkeAPPurchaseContractParentID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPPurchaseContractParentID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPPurchaseContractParentID.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPPurchaseContractParentID.Location = new System.Drawing.Point(101, 162);
            this.fld_lkeAPPurchaseContractParentID.Name = "fld_lkeAPPurchaseContractParentID";
            this.fld_lkeAPPurchaseContractParentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPPurchaseContractParentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPPurchaseContractParentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPPurchaseContractParentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPPurchaseContractParentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPurchaseContractParentID.Properties.ColumnName = null;
            this.fld_lkeAPPurchaseContractParentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APPurchaseContractNo", "Mã hợp đồng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APPurchaseContractName", "Tên hợp đồng")});
            this.fld_lkeAPPurchaseContractParentID.Properties.DisplayMember = "APPurchaseContractName";
            this.fld_lkeAPPurchaseContractParentID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPPurchaseContractParentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPurchaseContractParentID.Properties.ValueMember = "APPurchaseContractID";
            this.fld_lkeAPPurchaseContractParentID.Screen = null;
            this.fld_lkeAPPurchaseContractParentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPurchaseContractParentID.TabIndex = 9;
            this.fld_lkeAPPurchaseContractParentID.Tag = "DC";
            // 
            // fld_lkePurchaseContractStatus
            // 
            this.fld_lkePurchaseContractStatus.BOSAllowAddNew = false;
            this.fld_lkePurchaseContractStatus.BOSAllowDummy = false;
            this.fld_lkePurchaseContractStatus.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkePurchaseContractStatus.BOSDataMember = "APPurchaseContractStatus";
            this.fld_lkePurchaseContractStatus.BOSDataSource = "APPurchaseContracts";
            this.fld_lkePurchaseContractStatus.BOSDescription = null;
            this.fld_lkePurchaseContractStatus.BOSError = null;
            this.fld_lkePurchaseContractStatus.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkePurchaseContractStatus.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkePurchaseContractStatus.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkePurchaseContractStatus.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkePurchaseContractStatus.BOSPropertyName = "EditValue";
            this.fld_lkePurchaseContractStatus.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkePurchaseContractStatus.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkePurchaseContractStatus.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkePurchaseContractStatus.Location = new System.Drawing.Point(369, 136);
            this.fld_lkePurchaseContractStatus.Name = "fld_lkePurchaseContractStatus";
            this.fld_lkePurchaseContractStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkePurchaseContractStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkePurchaseContractStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkePurchaseContractStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkePurchaseContractStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkePurchaseContractStatus.Properties.ColumnName = null;
            this.fld_lkePurchaseContractStatus.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkePurchaseContractStatus.Properties.ReadOnly = true;
            this.fld_lkePurchaseContractStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkePurchaseContractStatus.Screen = null;
            this.fld_lkePurchaseContractStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkePurchaseContractStatus.TabIndex = 8;
            this.fld_lkePurchaseContractStatus.Tag = "DC";
            // 
            // fld_dteAPPurchaseContractDate
            // 
            this.fld_dteAPPurchaseContractDate.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteAPPurchaseContractDate.BOSDataMember = "APPurchaseContractDate";
            this.fld_dteAPPurchaseContractDate.BOSDataSource = "APPurchaseContracts";
            this.fld_dteAPPurchaseContractDate.BOSDescription = null;
            this.fld_dteAPPurchaseContractDate.BOSError = null;
            this.fld_dteAPPurchaseContractDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteAPPurchaseContractDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteAPPurchaseContractDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteAPPurchaseContractDate.BOSPropertyName = "EditValue";
            this.fld_dteAPPurchaseContractDate.EditValue = null;
            this.fld_dteAPPurchaseContractDate.Location = new System.Drawing.Point(369, 32);
            this.fld_dteAPPurchaseContractDate.Name = "fld_dteAPPurchaseContractDate";
            this.fld_dteAPPurchaseContractDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPPurchaseContractDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPPurchaseContractDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPPurchaseContractDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPPurchaseContractDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPPurchaseContractDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPPurchaseContractDate.Screen = null;
            this.fld_dteAPPurchaseContractDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteAPPurchaseContractDate.TabIndex = 1;
            this.fld_dteAPPurchaseContractDate.Tag = "DC";
            // 
            // fld_dteAPPurchaseContractEndDate
            // 
            this.fld_dteAPPurchaseContractEndDate.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteAPPurchaseContractEndDate.BOSDataMember = "APPurchaseContractEndDate";
            this.fld_dteAPPurchaseContractEndDate.BOSDataSource = "APPurchaseContracts";
            this.fld_dteAPPurchaseContractEndDate.BOSDescription = null;
            this.fld_dteAPPurchaseContractEndDate.BOSError = null;
            this.fld_dteAPPurchaseContractEndDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteAPPurchaseContractEndDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteAPPurchaseContractEndDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteAPPurchaseContractEndDate.BOSPropertyName = "EditValue";
            this.fld_dteAPPurchaseContractEndDate.EditValue = null;
            this.fld_dteAPPurchaseContractEndDate.Location = new System.Drawing.Point(369, 110);
            this.fld_dteAPPurchaseContractEndDate.Name = "fld_dteAPPurchaseContractEndDate";
            this.fld_dteAPPurchaseContractEndDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPPurchaseContractEndDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPPurchaseContractEndDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPPurchaseContractEndDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPPurchaseContractEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPPurchaseContractEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPPurchaseContractEndDate.Screen = null;
            this.fld_dteAPPurchaseContractEndDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteAPPurchaseContractEndDate.TabIndex = 6;
            this.fld_dteAPPurchaseContractEndDate.Tag = "DC";
            // 
            // bosLabel16
            // 
            this.bosLabel16.BOSComment = null;
            this.bosLabel16.BOSDataMember = null;
            this.bosLabel16.BOSDataSource = null;
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = null;
            this.bosLabel16.BOSFieldRelation = null;
            this.bosLabel16.BOSPrivilege = null;
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(276, 113);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(47, 13);
            this.bosLabel16.TabIndex = 590;
            this.bosLabel16.Text = "Đến ngày";
            // 
            // bosLabel11
            // 
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(276, 139);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(49, 13);
            this.bosLabel11.TabIndex = 6;
            this.bosLabel11.Text = "Tình trạng";
            // 
            // bosLabel12
            // 
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(16, 87);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(67, 13);
            this.bosLabel12.TabIndex = 6;
            this.bosLabel12.Text = "Loại hợp đồng";
            // 
            // fld_dteAPPurchaseContractBeginDate
            // 
            this.fld_dteAPPurchaseContractBeginDate.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteAPPurchaseContractBeginDate.BOSDataMember = "APPurchaseContractBeginDate";
            this.fld_dteAPPurchaseContractBeginDate.BOSDataSource = "APPurchaseContracts";
            this.fld_dteAPPurchaseContractBeginDate.BOSDescription = null;
            this.fld_dteAPPurchaseContractBeginDate.BOSError = null;
            this.fld_dteAPPurchaseContractBeginDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteAPPurchaseContractBeginDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteAPPurchaseContractBeginDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteAPPurchaseContractBeginDate.BOSPropertyName = "EditValue";
            this.fld_dteAPPurchaseContractBeginDate.EditValue = null;
            this.fld_dteAPPurchaseContractBeginDate.Location = new System.Drawing.Point(101, 110);
            this.fld_dteAPPurchaseContractBeginDate.Name = "fld_dteAPPurchaseContractBeginDate";
            this.fld_dteAPPurchaseContractBeginDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPPurchaseContractBeginDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPPurchaseContractBeginDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPPurchaseContractBeginDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPPurchaseContractBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPPurchaseContractBeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPPurchaseContractBeginDate.Screen = null;
            this.fld_dteAPPurchaseContractBeginDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteAPPurchaseContractBeginDate.TabIndex = 5;
            this.fld_dteAPPurchaseContractBeginDate.Tag = "DC";
            // 
            // fld_lkeAPPurchaseContractType
            // 
            this.fld_lkeAPPurchaseContractType.BOSAllowAddNew = false;
            this.fld_lkeAPPurchaseContractType.BOSAllowDummy = false;
            this.fld_lkeAPPurchaseContractType.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPPurchaseContractType.BOSDataMember = "APPurchaseContractType";
            this.fld_lkeAPPurchaseContractType.BOSDataSource = "APPurchaseContracts";
            this.fld_lkeAPPurchaseContractType.BOSDescription = null;
            this.fld_lkeAPPurchaseContractType.BOSError = null;
            this.fld_lkeAPPurchaseContractType.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPPurchaseContractType.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPPurchaseContractType.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPPurchaseContractType.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPPurchaseContractType.BOSPropertyName = "EditValue";
            this.fld_lkeAPPurchaseContractType.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPPurchaseContractType.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPPurchaseContractType.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPPurchaseContractType.Location = new System.Drawing.Point(101, 84);
            this.fld_lkeAPPurchaseContractType.Name = "fld_lkeAPPurchaseContractType";
            this.fld_lkeAPPurchaseContractType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeAPPurchaseContractType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeAPPurchaseContractType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeAPPurchaseContractType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeAPPurchaseContractType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPurchaseContractType.Properties.ColumnName = null;
            this.fld_lkeAPPurchaseContractType.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeAPPurchaseContractType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPurchaseContractType.Screen = null;
            this.fld_lkeAPPurchaseContractType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPurchaseContractType.TabIndex = 3;
            this.fld_lkeAPPurchaseContractType.Tag = "DC";
            this.fld_lkeAPPurchaseContractType.Validated += new System.EventHandler(this.fld_lkeAPPurchaseContractType_Validated);
            this.fld_lkeAPPurchaseContractType.QueryCloseUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeAPPurchaseContractType_QueryCloseUp);
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
            this.bosLabel15.Location = new System.Drawing.Point(16, 113);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(79, 13);
            this.bosLabel15.TabIndex = 588;
            this.bosLabel15.Text = "Hiệu lực từ ngày";
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
            this.bosLabel4.Location = new System.Drawing.Point(276, 87);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(75, 13);
            this.bosLabel4.TabIndex = 584;
            this.bosLabel4.Text = "Nhóm hợp đồng";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosTextBox4.BOSDataMember = "APPurchaseContractExchangeRate";
            this.bosTextBox4.BOSDataSource = "APPurchaseContracts";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = null;
            this.bosTextBox4.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosTextBox4.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosTextBox4.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosTextBox4.BOSPropertyName = "Text";
            this.bosTextBox4.EditValue = global::Localization.SaleOrderLocalizedResources.String;
            this.bosTextBox4.Location = new System.Drawing.Point(475, -195);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bosTextBox4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox4.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox4.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox4.Screen = null;
            this.bosTextBox4.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox4.TabIndex = 597;
            this.bosTextBox4.Tag = "DC";
            // 
            // fld_ptdAPPurchaseContractEmployeePicture
            // 
            this.fld_ptdAPPurchaseContractEmployeePicture.BOSComment = null;
            this.fld_ptdAPPurchaseContractEmployeePicture.BOSDataMember = "APPurchaseContractEmployeePicture";
            this.fld_ptdAPPurchaseContractEmployeePicture.BOSDataSource = "APPurchaseContracts";
            this.fld_ptdAPPurchaseContractEmployeePicture.BOSDescription = null;
            this.fld_ptdAPPurchaseContractEmployeePicture.BOSError = null;
            this.fld_ptdAPPurchaseContractEmployeePicture.BOSFieldGroup = null;
            this.fld_ptdAPPurchaseContractEmployeePicture.BOSFieldRelation = null;
            this.fld_ptdAPPurchaseContractEmployeePicture.BOSPrivilege = null;
            this.fld_ptdAPPurchaseContractEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_ptdAPPurchaseContractEmployeePicture.FileName = null;
            this.fld_ptdAPPurchaseContractEmployeePicture.FilePath = null;
            this.fld_ptdAPPurchaseContractEmployeePicture.Location = new System.Drawing.Point(5, 8);
            this.fld_ptdAPPurchaseContractEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_ptdAPPurchaseContractEmployeePicture.Name = "fld_ptdAPPurchaseContractEmployeePicture";
            this.fld_ptdAPPurchaseContractEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_ptdAPPurchaseContractEmployeePicture.Screen = null;
            this.fld_ptdAPPurchaseContractEmployeePicture.Size = new System.Drawing.Size(107, 102);
            this.fld_ptdAPPurchaseContractEmployeePicture.TabIndex = 0;
            this.fld_ptdAPPurchaseContractEmployeePicture.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "APPurchaseContracts";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(5, 115);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã người bán"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên người bán")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(107, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Options.UseBackColor = true;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
            this.bosLabel22.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel22.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel22.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel22.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel22.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel22.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel22.Location = new System.Drawing.Point(382, -166);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(53, 13);
            this.bosLabel22.TabIndex = 600;
            this.bosLabel22.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel22.Text = "Loại tiền tệ";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel21.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel21.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel21.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel21.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel21.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel21.Location = new System.Drawing.Point(382, -192);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(29, 13);
            this.bosLabel21.TabIndex = 598;
            this.bosLabel21.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLabel21.Text = "Tỷ giá";
            // 
            // bosLookupEdit7
            // 
            this.bosLookupEdit7.BOSAllowAddNew = false;
            this.bosLookupEdit7.BOSAllowDummy = false;
            this.bosLookupEdit7.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLookupEdit7.BOSDataMember = "FK_GECurrencyID";
            this.bosLookupEdit7.BOSDataSource = "APPurchaseContracts";
            this.bosLookupEdit7.BOSDescription = null;
            this.bosLookupEdit7.BOSError = null;
            this.bosLookupEdit7.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLookupEdit7.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLookupEdit7.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLookupEdit7.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLookupEdit7.BOSPropertyName = "EditValue";
            this.bosLookupEdit7.BOSSelectType = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLookupEdit7.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLookupEdit7.CurrentDisplayText = null;
            this.bosLookupEdit7.Location = new System.Drawing.Point(475, -169);
            this.bosLookupEdit7.Name = "bosLookupEdit7";
            this.bosLookupEdit7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit7.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit7.Properties.ColumnName = null;
            this.bosLookupEdit7.Properties.DisplayMember = "GECurrencyName";
            this.bosLookupEdit7.Properties.NullText = global::Localization.SaleOrderLocalizedResources.String;
            this.bosLookupEdit7.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit7.Properties.ValueMember = "GECurrencyID";
            this.bosLookupEdit7.Screen = null;
            this.bosLookupEdit7.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit7.TabIndex = 599;
            this.bosLookupEdit7.Tag = "DC";
            // 
            // DMPCT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(990, 574);
            this.Controls.Add(this.bosPanel2);
            this.Name = "DMPCT100";
            this.Text = "Thông tin hợp đồng mua";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseContractExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseContractTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARPurchaseOrderSubTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseContractTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseContractTaxPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl6)).EndInit();
            this.bosGroupControl6.ResumeLayout(false);
            this.bosGroupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APPurchaseContractGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseContractNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseContractName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseContractParentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePurchaseContractStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseContractDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseContractDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseContractEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseContractEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseContractBeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPPurchaseContractBeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseContractType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ptdAPPurchaseContractEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit7.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel fld_lblLabel22;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseContractTaxAmount;
        private BOSComponent.BOSTextBox fld_txtARPurchaseOrderSubTotalCost;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLabel fld_lblLabel16;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseContractTotalCost;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseContractTaxPercent;
        private BOSComponent.BOSGroupControl bosGroupControl6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectID;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSTextBox fld_lkeAPPurchaseContractNo;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseContractName;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSMemoEdit bosMemoEdit1;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel fld_lblLabel1;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeAPPurchaseContractParentID;
        private BOSComponent.BOSLookupEdit fld_lkePurchaseContractStatus;
        private BOSComponent.BOSDateEdit fld_dteAPPurchaseContractDate;
        private BOSComponent.BOSDateEdit fld_dteAPPurchaseContractEndDate;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSDateEdit fld_dteAPPurchaseContractBeginDate;
        private BOSComponent.BOSLookupEdit fld_lkeAPPurchaseContractType;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSPictureEdit fld_ptdAPPurchaseContractEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLookupEdit bosLookupEdit7;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseContractExchangeRate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APPurchaseContractGroupID;
	}
}
