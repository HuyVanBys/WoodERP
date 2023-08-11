using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ReceiptCD.UI
{
	/// <summary>
	/// Summary description for DMRCD100
	/// </summary>
	partial class DMRCD100
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
            this.fld_txtICReceiptSerialRefix = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblICReceiptSerialRefix = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ICStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_Lablel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeReceiptAcceptanceType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnLumber = new BOSComponent.BOSButton(this.components);
            this.fld_lkeProductAttributeQualityID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICProductAttributeTTMTID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICProductAttributeWoodTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.fld_lkeFK_GECountryID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblFK_ICProductAttributeQualityID = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblICReceiptCDHeight = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICReceiptCDHeight = new BOSComponent.BOSTextBox(this.components);
            this.fld_medICReceiptDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_tabReceiptItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageReceiptItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcReceiptCDItems = new BOSERP.Modules.ReceiptCD.ICReceiptItemsGridControl();
            this.fld_pteICReceiptItemProductPicture1 = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_pteICReceiptEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_Lablel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICReceiptDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICReceiptStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICReceiptNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptSerialRefix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeReceiptAcceptanceType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeProductAttributeQualityID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptCDHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabReceiptItems)).BeginInit();
            this.fld_tabReceiptItems.SuspendLayout();
            this.fld_tabPageReceiptItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReceiptCDItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptItemProductPicture1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptSerialRefix);
            this.bosPanel1.Controls.Add(this.fld_lblICReceiptSerialRefix);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICStockID);
            this.bosPanel1.Controls.Add(this.fld_Lablel3);
            this.bosPanel1.Controls.Add(this.fld_lkeReceiptAcceptanceType);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_btnLumber);
            this.bosPanel1.Controls.Add(this.fld_lkeProductAttributeQualityID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductAttributeTTMTID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductAttributeWoodTypeID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_GECountryID);
            this.bosPanel1.Controls.Add(this.bosLabel16);
            this.bosPanel1.Controls.Add(this.fld_lblFK_ICProductAttributeQualityID);
            this.bosPanel1.Controls.Add(this.bosLabel14);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosLookupEdit2);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_lblICReceiptCDHeight);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptCDHeight);
            this.bosPanel1.Controls.Add(this.fld_medICReceiptDesc);
            this.bosPanel1.Controls.Add(this.fld_tabReceiptItems);
            this.bosPanel1.Controls.Add(this.fld_pteICReceiptEmployeePicture);
            this.bosPanel1.Controls.Add(this.BOSLabel2);
            this.bosPanel1.Controls.Add(this.fld_Lablel2);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_dteICReceiptDate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lkeICReceiptStatus);
            this.bosPanel1.Controls.Add(this.fld_txtICReceiptNo);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1017, 532);
            this.bosPanel1.TabIndex = 533;
            // 
            // fld_txtICReceiptSerialRefix
            // 
            this.fld_txtICReceiptSerialRefix.BOSComment = null;
            this.fld_txtICReceiptSerialRefix.BOSDataMember = "ICReceiptSerialPrefix";
            this.fld_txtICReceiptSerialRefix.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptSerialRefix.BOSDescription = null;
            this.fld_txtICReceiptSerialRefix.BOSError = null;
            this.fld_txtICReceiptSerialRefix.BOSFieldGroup = null;
            this.fld_txtICReceiptSerialRefix.BOSFieldRelation = null;
            this.fld_txtICReceiptSerialRefix.BOSPrivilege = null;
            this.fld_txtICReceiptSerialRefix.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptSerialRefix.Location = new System.Drawing.Point(643, 117);
            this.fld_txtICReceiptSerialRefix.MenuManager = this.screenToolbar;
            this.fld_txtICReceiptSerialRefix.Name = "fld_txtICReceiptSerialRefix";
            this.fld_txtICReceiptSerialRefix.Screen = null;
            this.fld_txtICReceiptSerialRefix.Size = new System.Drawing.Size(134, 20);
            this.fld_txtICReceiptSerialRefix.TabIndex = 573;
            this.fld_txtICReceiptSerialRefix.Tag = "DC";
            // 
            // fld_lblICReceiptSerialRefix
            // 
            this.fld_lblICReceiptSerialRefix.BOSComment = null;
            this.fld_lblICReceiptSerialRefix.BOSDataMember = null;
            this.fld_lblICReceiptSerialRefix.BOSDataSource = null;
            this.fld_lblICReceiptSerialRefix.BOSDescription = null;
            this.fld_lblICReceiptSerialRefix.BOSError = null;
            this.fld_lblICReceiptSerialRefix.BOSFieldGroup = null;
            this.fld_lblICReceiptSerialRefix.BOSFieldRelation = null;
            this.fld_lblICReceiptSerialRefix.BOSPrivilege = null;
            this.fld_lblICReceiptSerialRefix.BOSPropertyName = null;
            this.fld_lblICReceiptSerialRefix.Location = new System.Drawing.Point(569, 119);
            this.fld_lblICReceiptSerialRefix.Name = "fld_lblICReceiptSerialRefix";
            this.fld_lblICReceiptSerialRefix.Screen = null;
            this.fld_lblICReceiptSerialRefix.Size = new System.Drawing.Size(36, 13);
            this.fld_lblICReceiptSerialRefix.TabIndex = 572;
            this.fld_lblICReceiptSerialRefix.Text = "Mã kiện";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ICReceiptPackNo";
            this.bosTextBox1.BOSDataSource = "ICReceipts";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(866, 65);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(134, 20);
            this.bosTextBox1.TabIndex = 571;
            this.bosTextBox1.Tag = "DC";
            // 
            // fld_lkeFK_ICStockID
            // 
            this.fld_lkeFK_ICStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID.BOSAllowDummy = false;
            this.fld_lkeFK_ICStockID.BOSComment = null;
            this.fld_lkeFK_ICStockID.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ICStockID.BOSDescription = null;
            this.fld_lkeFK_ICStockID.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICStockID.BOSFieldGroup = null;
            this.fld_lkeFK_ICStockID.BOSFieldParent = null;
            this.fld_lkeFK_ICStockID.BOSFieldRelation = null;
            this.fld_lkeFK_ICStockID.BOSPrivilege = null;
            this.fld_lkeFK_ICStockID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID.BOSSelectType = null;
            this.fld_lkeFK_ICStockID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICStockID.CurrentDisplayText = null;
            this.fld_lkeFK_ICStockID.Location = new System.Drawing.Point(423, 64);
            this.fld_lkeFK_ICStockID.Name = "fld_lkeFK_ICStockID";
            this.fld_lkeFK_ICStockID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICStockID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICStockID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICStockID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String2, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeFK_ICStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICStockID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID.Screen = null;
            this.fld_lkeFK_ICStockID.Size = new System.Drawing.Size(128, 20);
            this.fld_lkeFK_ICStockID.TabIndex = 569;
            this.fld_lkeFK_ICStockID.Tag = "DC";
            this.fld_lkeFK_ICStockID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICStockID_CloseUp);
            // 
            // fld_Lablel3
            // 
            this.fld_Lablel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel3.Appearance.Options.UseBackColor = true;
            this.fld_Lablel3.Appearance.Options.UseForeColor = true;
            this.fld_Lablel3.BOSComment = null;
            this.fld_Lablel3.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_Lablel3.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_Lablel3.BOSDescription = null;
            this.fld_Lablel3.BOSError = null;
            this.fld_Lablel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_Lablel3.BOSFieldRelation = null;
            this.fld_Lablel3.BOSPrivilege = null;
            this.fld_Lablel3.BOSPropertyName = null;
            this.fld_Lablel3.Location = new System.Drawing.Point(332, 67);
            this.fld_Lablel3.Name = "fld_Lablel3";
            this.fld_Lablel3.Screen = null;
            this.fld_Lablel3.Size = new System.Drawing.Size(18, 13);
            this.fld_Lablel3.TabIndex = 570;
            this.fld_Lablel3.Text = "Kho";
            // 
            // fld_lkeReceiptAcceptanceType
            // 
            this.fld_lkeReceiptAcceptanceType.BOSAllowAddNew = false;
            this.fld_lkeReceiptAcceptanceType.BOSAllowDummy = false;
            this.fld_lkeReceiptAcceptanceType.BOSComment = null;
            this.fld_lkeReceiptAcceptanceType.BOSDataMember = "ICReceiptAcceptanceType";
            this.fld_lkeReceiptAcceptanceType.BOSDataSource = "ICReceipts";
            this.fld_lkeReceiptAcceptanceType.BOSDescription = null;
            this.fld_lkeReceiptAcceptanceType.BOSError = null;
            this.fld_lkeReceiptAcceptanceType.BOSFieldGroup = null;
            this.fld_lkeReceiptAcceptanceType.BOSFieldParent = null;
            this.fld_lkeReceiptAcceptanceType.BOSFieldRelation = null;
            this.fld_lkeReceiptAcceptanceType.BOSPrivilege = null;
            this.fld_lkeReceiptAcceptanceType.BOSPropertyName = "EditValue";
            this.fld_lkeReceiptAcceptanceType.BOSSelectType = null;
            this.fld_lkeReceiptAcceptanceType.BOSSelectTypeValue = null;
            this.fld_lkeReceiptAcceptanceType.CurrentDisplayText = null;
            this.fld_lkeReceiptAcceptanceType.Location = new System.Drawing.Point(189, 64);
            this.fld_lkeReceiptAcceptanceType.Name = "fld_lkeReceiptAcceptanceType";
            this.fld_lkeReceiptAcceptanceType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeReceiptAcceptanceType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeReceiptAcceptanceType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeReceiptAcceptanceType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeReceiptAcceptanceType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeReceiptAcceptanceType.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeReceiptAcceptanceType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeReceiptAcceptanceType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeReceiptAcceptanceType, true);
            this.fld_lkeReceiptAcceptanceType.Size = new System.Drawing.Size(128, 20);
            this.fld_lkeReceiptAcceptanceType.TabIndex = 567;
            this.fld_lkeReceiptAcceptanceType.Tag = "DC";
            this.fld_lkeReceiptAcceptanceType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeReceiptAcceptanceType_CloseUp);
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(118, 68);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(66, 13);
            this.bosLabel7.TabIndex = 568;
            this.bosLabel7.Text = "Loại nhập kho";
            // 
            // fld_btnLumber
            // 
            this.fld_btnLumber.BOSComment = null;
            this.fld_btnLumber.BOSDataMember = null;
            this.fld_btnLumber.BOSDataSource = null;
            this.fld_btnLumber.BOSDescription = null;
            this.fld_btnLumber.BOSError = null;
            this.fld_btnLumber.BOSFieldGroup = null;
            this.fld_btnLumber.BOSFieldRelation = null;
            this.fld_btnLumber.BOSPrivilege = null;
            this.fld_btnLumber.BOSPropertyName = null;
            this.fld_btnLumber.Location = new System.Drawing.Point(866, 96);
            this.fld_btnLumber.Name = "fld_btnLumber";
            this.fld_btnLumber.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnLumber, true);
            this.fld_btnLumber.Size = new System.Drawing.Size(134, 27);
            this.fld_btnLumber.TabIndex = 566;
            this.fld_btnLumber.Text = "Thêm gỗ phách";
            this.fld_btnLumber.Click += new System.EventHandler(this.fld_btnLumber_Click);
            // 
            // fld_lkeProductAttributeQualityID
            // 
            this.fld_lkeProductAttributeQualityID.BOSAllowAddNew = false;
            this.fld_lkeProductAttributeQualityID.BOSAllowDummy = false;
            this.fld_lkeProductAttributeQualityID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeProductAttributeQualityID.BOSDataMember = "FK_ICProductAttributeQualityID";
            this.fld_lkeProductAttributeQualityID.BOSDataSource = "ICReceipts";
            this.fld_lkeProductAttributeQualityID.BOSDescription = null;
            this.fld_lkeProductAttributeQualityID.BOSError = null;
            this.fld_lkeProductAttributeQualityID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeProductAttributeQualityID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeProductAttributeQualityID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeProductAttributeQualityID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeProductAttributeQualityID.BOSPropertyName = "EditValue";
            this.fld_lkeProductAttributeQualityID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeProductAttributeQualityID.BOSSelectTypeValue = "Quality";
            this.fld_lkeProductAttributeQualityID.CurrentDisplayText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeProductAttributeQualityID.Location = new System.Drawing.Point(643, 91);
            this.fld_lkeProductAttributeQualityID.Name = "fld_lkeProductAttributeQualityID";
            this.fld_lkeProductAttributeQualityID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeProductAttributeQualityID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeProductAttributeQualityID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeProductAttributeQualityID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeProductAttributeQualityID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeProductAttributeQualityID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "TTMT")});
            this.fld_lkeProductAttributeQualityID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeProductAttributeQualityID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeProductAttributeQualityID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeProductAttributeQualityID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeProductAttributeQualityID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeProductAttributeQualityID, true);
            this.fld_lkeProductAttributeQualityID.Size = new System.Drawing.Size(134, 20);
            this.fld_lkeProductAttributeQualityID.TabIndex = 16;
            this.fld_lkeProductAttributeQualityID.Tag = "DC";
            this.fld_lkeProductAttributeQualityID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeProductAttributeQualityID_CloseUp);
            // 
            // fld_lkeFK_ICProductAttributeTTMTID
            // 
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataMember = "FK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSSelectTypeValue = "TTMT";
            this.fld_lkeFK_ICProductAttributeTTMTID.CurrentDisplayText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductAttributeTTMTID.Location = new System.Drawing.Point(866, 38);
            this.fld_lkeFK_ICProductAttributeTTMTID.Name = "fld_lkeFK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "TTMT")});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeTTMTID, true);
            this.fld_lkeFK_ICProductAttributeTTMTID.Size = new System.Drawing.Size(134, 20);
            this.fld_lkeFK_ICProductAttributeTTMTID.TabIndex = 8;
            this.fld_lkeFK_ICProductAttributeTTMTID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeTTMTID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICProductAttributeTTMTID_CloseUp);
            // 
            // fld_lkeFK_ICProductAttributeWoodTypeID
            // 
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSDataMember = "FK_ICProductAttributeWoodTypeID";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.BOSSelectTypeValue = "WoodType";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Location = new System.Drawing.Point(866, 12);
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Name = "fld_lkeFK_ICProductAttributeWoodTypeID";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeNo", "Mã loại gỗ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Tên loại gỗ")});
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeWoodTypeID, true);
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Size = new System.Drawing.Size(135, 20);
            this.fld_lkeFK_ICProductAttributeWoodTypeID.TabIndex = 4;
            this.fld_lkeFK_ICProductAttributeWoodTypeID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeWoodTypeID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICProductAttributeWoodTypeID_CloseUp);
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = null;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = null;
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(643, 38);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Style No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Own Style No."),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Desc.")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICProductID.Properties.PopupWidth = 60;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(133, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 0;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            // 
            // fld_lkeFK_GECountryID
            // 
            this.fld_lkeFK_GECountryID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECountryID.BOSAllowDummy = true;
            this.fld_lkeFK_GECountryID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_GECountryID.BOSDataMember = "FK_GECountryID";
            this.fld_lkeFK_GECountryID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_GECountryID.BOSDescription = null;
            this.fld_lkeFK_GECountryID.BOSError = null;
            this.fld_lkeFK_GECountryID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_GECountryID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_GECountryID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_GECountryID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_GECountryID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECountryID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_GECountryID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_GECountryID.CurrentDisplayText = null;
            this.fld_lkeFK_GECountryID.Location = new System.Drawing.Point(643, 12);
            this.fld_lkeFK_GECountryID.Name = "fld_lkeFK_GECountryID";
            this.fld_lkeFK_GECountryID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECountryID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECountryID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECountryID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECountryID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECountryID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECountryName", "Nguồn gốc")});
            this.fld_lkeFK_GECountryID.Properties.DisplayMember = "GECountryName";
            this.fld_lkeFK_GECountryID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_GECountryID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECountryID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECountryID.Properties.ValueMember = "GECountryID";
            this.fld_lkeFK_GECountryID.Screen = null;
            this.fld_lkeFK_GECountryID.Size = new System.Drawing.Size(134, 20);
            this.fld_lkeFK_GECountryID.TabIndex = 7;
            this.fld_lkeFK_GECountryID.Tag = "DC";
            this.fld_lkeFK_GECountryID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECountryID_CloseUp);
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel16.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel16.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel16.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel16.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel16.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel16.Location = new System.Drawing.Point(569, 15);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(51, 13);
            this.bosLabel16.TabIndex = 564;
            this.bosLabel16.Tag = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel16.Text = "Nguồn gốc";
            // 
            // fld_lblFK_ICProductAttributeQualityID
            // 
            this.fld_lblFK_ICProductAttributeQualityID.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblFK_ICProductAttributeQualityID.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblFK_ICProductAttributeQualityID.Appearance.Options.UseBackColor = true;
            this.fld_lblFK_ICProductAttributeQualityID.Appearance.Options.UseForeColor = true;
            this.fld_lblFK_ICProductAttributeQualityID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblFK_ICProductAttributeQualityID.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblFK_ICProductAttributeQualityID.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblFK_ICProductAttributeQualityID.BOSDescription = null;
            this.fld_lblFK_ICProductAttributeQualityID.BOSError = null;
            this.fld_lblFK_ICProductAttributeQualityID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblFK_ICProductAttributeQualityID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblFK_ICProductAttributeQualityID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblFK_ICProductAttributeQualityID.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblFK_ICProductAttributeQualityID.Location = new System.Drawing.Point(568, 94);
            this.fld_lblFK_ICProductAttributeQualityID.Name = "fld_lblFK_ICProductAttributeQualityID";
            this.fld_lblFK_ICProductAttributeQualityID.Screen = null;
            this.fld_lblFK_ICProductAttributeQualityID.Size = new System.Drawing.Size(53, 13);
            this.fld_lblFK_ICProductAttributeQualityID.TabIndex = 562;
            this.fld_lblFK_ICProductAttributeQualityID.Tag = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblFK_ICProductAttributeQualityID.Text = "Chất lượng";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel14.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel14.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel14.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel14.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel14.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel14.Location = new System.Drawing.Point(792, 41);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(26, 13);
            this.bosLabel14.TabIndex = 560;
            this.bosLabel14.Tag = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel14.Text = "TTMT";
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
            this.bosLabel12.Location = new System.Drawing.Point(569, 41);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(29, 13);
            this.bosLabel12.TabIndex = 558;
            this.bosLabel12.Text = "Mã gỗ";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel11.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel11.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel11.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel11.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel11.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel11.Location = new System.Drawing.Point(792, 15);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(34, 13);
            this.bosLabel11.TabIndex = 556;
            this.bosLabel11.Tag = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel11.Text = "Loại gỗ";
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
            this.bosLabel10.Location = new System.Drawing.Point(792, 67);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(40, 13);
            this.bosLabel10.TabIndex = 554;
            this.bosLabel10.Text = "Mã lô gỗ";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = true;
            this.bosLookupEdit2.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit2.BOSDataMember = "FK_APSupplierID";
            this.bosLookupEdit2.BOSDataSource = "ICReceipts";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = null;
            this.bosLookupEdit2.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit2.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit2.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit2.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit2.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit2.CurrentDisplayText = null;
            this.bosLookupEdit2.Location = new System.Drawing.Point(189, 38);
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "Mã NCC"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Tên NCC")});
            this.bosLookupEdit2.Properties.DisplayMember = "APSupplierName";
            this.bosLookupEdit2.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit2.Properties.PopupWidth = 40;
            this.bosLookupEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit2.Properties.ValueMember = "APSupplierID";
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(128, 20);
            this.bosLookupEdit2.TabIndex = 3;
            this.bosLookupEdit2.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel9.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel9.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel9.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel9.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel9.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel9.Location = new System.Drawing.Point(118, 41);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(21, 13);
            this.bosLabel9.TabIndex = 552;
            this.bosLabel9.Tag = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel9.Text = "NCC";
            // 
            // fld_lblICReceiptCDHeight
            // 
            this.fld_lblICReceiptCDHeight.BOSComment = null;
            this.fld_lblICReceiptCDHeight.BOSDataMember = null;
            this.fld_lblICReceiptCDHeight.BOSDataSource = null;
            this.fld_lblICReceiptCDHeight.BOSDescription = null;
            this.fld_lblICReceiptCDHeight.BOSError = null;
            this.fld_lblICReceiptCDHeight.BOSFieldGroup = null;
            this.fld_lblICReceiptCDHeight.BOSFieldRelation = null;
            this.fld_lblICReceiptCDHeight.BOSPrivilege = null;
            this.fld_lblICReceiptCDHeight.BOSPropertyName = null;
            this.fld_lblICReceiptCDHeight.Location = new System.Drawing.Point(569, 67);
            this.fld_lblICReceiptCDHeight.Name = "fld_lblICReceiptCDHeight";
            this.fld_lblICReceiptCDHeight.Screen = null;
            this.fld_lblICReceiptCDHeight.Size = new System.Drawing.Size(62, 13);
            this.fld_lblICReceiptCDHeight.TabIndex = 550;
            this.fld_lblICReceiptCDHeight.Text = "Dày ván tươi";
            // 
            // fld_txtICReceiptCDHeight
            // 
            this.fld_txtICReceiptCDHeight.BOSComment = null;
            this.fld_txtICReceiptCDHeight.BOSDataMember = "ICReceiptHeight";
            this.fld_txtICReceiptCDHeight.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptCDHeight.BOSDescription = null;
            this.fld_txtICReceiptCDHeight.BOSError = null;
            this.fld_txtICReceiptCDHeight.BOSFieldGroup = null;
            this.fld_txtICReceiptCDHeight.BOSFieldRelation = null;
            this.fld_txtICReceiptCDHeight.BOSPrivilege = null;
            this.fld_txtICReceiptCDHeight.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptCDHeight.Location = new System.Drawing.Point(643, 64);
            this.fld_txtICReceiptCDHeight.MenuManager = this.screenToolbar;
            this.fld_txtICReceiptCDHeight.Name = "fld_txtICReceiptCDHeight";
            this.fld_txtICReceiptCDHeight.Screen = null;
            this.fld_txtICReceiptCDHeight.Size = new System.Drawing.Size(134, 20);
            this.fld_txtICReceiptCDHeight.TabIndex = 15;
            this.fld_txtICReceiptCDHeight.Tag = "DC";
            this.fld_txtICReceiptCDHeight.Validated += new System.EventHandler(this.fld_txtICReceiptCDHeight_Validated);
            // 
            // fld_medICReceiptDesc
            // 
            this.fld_medICReceiptDesc.BOSComment = null;
            this.fld_medICReceiptDesc.BOSDataMember = "ICReceiptDesc";
            this.fld_medICReceiptDesc.BOSDataSource = "ICReceipts";
            this.fld_medICReceiptDesc.BOSDescription = null;
            this.fld_medICReceiptDesc.BOSError = null;
            this.fld_medICReceiptDesc.BOSFieldGroup = null;
            this.fld_medICReceiptDesc.BOSFieldRelation = null;
            this.fld_medICReceiptDesc.BOSPrivilege = null;
            this.fld_medICReceiptDesc.BOSPropertyName = "Text";
            this.fld_medICReceiptDesc.Location = new System.Drawing.Point(189, 116);
            this.fld_medICReceiptDesc.Name = "fld_medICReceiptDesc";
            this.fld_medICReceiptDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICReceiptDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICReceiptDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICReceiptDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICReceiptDesc.Screen = null;
            this.fld_medICReceiptDesc.Size = new System.Drawing.Size(362, 45);
            this.fld_medICReceiptDesc.TabIndex = 13;
            this.fld_medICReceiptDesc.Tag = "DC";
            // 
            // fld_tabReceiptItems
            // 
            this.fld_tabReceiptItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabReceiptItems.BOSComment = null;
            this.fld_tabReceiptItems.BOSDataMember = null;
            this.fld_tabReceiptItems.BOSDataSource = null;
            this.fld_tabReceiptItems.BOSDescription = null;
            this.fld_tabReceiptItems.BOSError = null;
            this.fld_tabReceiptItems.BOSFieldGroup = null;
            this.fld_tabReceiptItems.BOSFieldRelation = null;
            this.fld_tabReceiptItems.BOSPrivilege = null;
            this.fld_tabReceiptItems.BOSPropertyName = null;
            this.fld_tabReceiptItems.Location = new System.Drawing.Point(0, 176);
            this.fld_tabReceiptItems.Name = "fld_tabReceiptItems";
            this.fld_tabReceiptItems.Screen = null;
            this.fld_tabReceiptItems.SelectedTabPage = this.fld_tabPageReceiptItems;
            this.fld_tabReceiptItems.Size = new System.Drawing.Size(1017, 353);
            this.fld_tabReceiptItems.TabIndex = 10;
            this.fld_tabReceiptItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageReceiptItems});
            // 
            // fld_tabPageReceiptItems
            // 
            this.fld_tabPageReceiptItems.Controls.Add(this.fld_dgcReceiptCDItems);
            this.fld_tabPageReceiptItems.Controls.Add(this.fld_pteICReceiptItemProductPicture1);
            this.fld_tabPageReceiptItems.Name = "fld_tabPageReceiptItems";
            this.fld_tabPageReceiptItems.Size = new System.Drawing.Size(1010, 324);
            this.fld_tabPageReceiptItems.Text = "Danh sách sản phẩm";
            // 
            // fld_dgcReceiptCDItems
            // 
            this.fld_dgcReceiptCDItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcReceiptCDItems.BOSComment = null;
            this.fld_dgcReceiptCDItems.BOSDataMember = null;
            this.fld_dgcReceiptCDItems.BOSDataSource = "ICReceiptItems";
            this.fld_dgcReceiptCDItems.BOSDescription = null;
            this.fld_dgcReceiptCDItems.BOSError = null;
            this.fld_dgcReceiptCDItems.BOSFieldGroup = null;
            this.fld_dgcReceiptCDItems.BOSFieldRelation = null;
            this.fld_dgcReceiptCDItems.BOSGridType = null;
            this.fld_dgcReceiptCDItems.BOSPrivilege = null;
            this.fld_dgcReceiptCDItems.BOSPropertyName = null;
            this.fld_dgcReceiptCDItems.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcReceiptCDItems.MenuManager = this.screenToolbar;
            this.fld_dgcReceiptCDItems.Name = "fld_dgcReceiptCDItems";
            this.fld_dgcReceiptCDItems.PrintReport = false;
            this.fld_dgcReceiptCDItems.Screen = null;
            this.fld_dgcReceiptCDItems.Size = new System.Drawing.Size(858, 318);
            this.fld_dgcReceiptCDItems.TabIndex = 1;
            // 
            // fld_pteICReceiptItemProductPicture1
            // 
            this.fld_pteICReceiptItemProductPicture1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteICReceiptItemProductPicture1.BOSComment = null;
            this.fld_pteICReceiptItemProductPicture1.BOSDataMember = "ICReceiptCDItemProductPicture";
            this.fld_pteICReceiptItemProductPicture1.BOSDataSource = "ICReceiptCDItems";
            this.fld_pteICReceiptItemProductPicture1.BOSDescription = null;
            this.fld_pteICReceiptItemProductPicture1.BOSError = null;
            this.fld_pteICReceiptItemProductPicture1.BOSFieldGroup = null;
            this.fld_pteICReceiptItemProductPicture1.BOSFieldRelation = null;
            this.fld_pteICReceiptItemProductPicture1.BOSPrivilege = null;
            this.fld_pteICReceiptItemProductPicture1.BOSPropertyName = "EditValue";
            this.fld_pteICReceiptItemProductPicture1.Location = new System.Drawing.Point(867, 3);
            this.fld_pteICReceiptItemProductPicture1.Name = "fld_pteICReceiptItemProductPicture1";
            this.fld_pteICReceiptItemProductPicture1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICReceiptItemProductPicture1.Screen = null;
            this.fld_pteICReceiptItemProductPicture1.Size = new System.Drawing.Size(140, 140);
            this.fld_pteICReceiptItemProductPicture1.TabIndex = 2;
            this.fld_pteICReceiptItemProductPicture1.Tag = "DC";
            // 
            // fld_pteICReceiptEmployeePicture
            // 
            this.fld_pteICReceiptEmployeePicture.BOSComment = null;
            this.fld_pteICReceiptEmployeePicture.BOSDataMember = "ICReceiptEmployeePicture";
            this.fld_pteICReceiptEmployeePicture.BOSDataSource = "ICReceipts";
            this.fld_pteICReceiptEmployeePicture.BOSDescription = null;
            this.fld_pteICReceiptEmployeePicture.BOSError = null;
            this.fld_pteICReceiptEmployeePicture.BOSFieldGroup = null;
            this.fld_pteICReceiptEmployeePicture.BOSFieldRelation = null;
            this.fld_pteICReceiptEmployeePicture.BOSPrivilege = null;
            this.fld_pteICReceiptEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteICReceiptEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteICReceiptEmployeePicture.Name = "fld_pteICReceiptEmployeePicture";
            this.fld_pteICReceiptEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICReceiptEmployeePicture.Screen = null;
            this.fld_pteICReceiptEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteICReceiptEmployeePicture.TabIndex = 0;
            this.fld_pteICReceiptEmployeePicture.Tag = "DC";
            // 
            // BOSLabel2
            // 
            this.BOSLabel2.BOSComment = null;
            this.BOSLabel2.BOSDataMember = null;
            this.BOSLabel2.BOSDataSource = null;
            this.BOSLabel2.BOSDescription = null;
            this.BOSLabel2.BOSError = null;
            this.BOSLabel2.BOSFieldGroup = null;
            this.BOSLabel2.BOSFieldRelation = null;
            this.BOSLabel2.BOSPrivilege = null;
            this.BOSLabel2.BOSPropertyName = null;
            this.BOSLabel2.Location = new System.Drawing.Point(332, 15);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(72, 13);
            this.BOSLabel2.TabIndex = 508;
            this.BOSLabel2.Text = "Ngày chứng từ";
            // 
            // fld_Lablel2
            // 
            this.fld_Lablel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.Options.UseBackColor = true;
            this.fld_Lablel2.Appearance.Options.UseForeColor = true;
            this.fld_Lablel2.BOSComment = null;
            this.fld_Lablel2.BOSDataMember = null;
            this.fld_Lablel2.BOSDataSource = null;
            this.fld_Lablel2.BOSDescription = null;
            this.fld_Lablel2.BOSError = null;
            this.fld_Lablel2.BOSFieldGroup = null;
            this.fld_Lablel2.BOSFieldRelation = null;
            this.fld_Lablel2.BOSPrivilege = null;
            this.fld_Lablel2.BOSPropertyName = null;
            this.fld_Lablel2.Location = new System.Drawing.Point(332, 41);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(49, 13);
            this.fld_Lablel2.TabIndex = 478;
            this.fld_Lablel2.Text = "Tình trạng";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(118, 119);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 482;
            this.bosLabel5.Text = "Diễn giải";
            // 
            // fld_dteICReceiptDate
            // 
            this.fld_dteICReceiptDate.BOSComment = null;
            this.fld_dteICReceiptDate.BOSDataMember = "ICReceiptDate";
            this.fld_dteICReceiptDate.BOSDataSource = "ICReceipts";
            this.fld_dteICReceiptDate.BOSDescription = null;
            this.fld_dteICReceiptDate.BOSError = null;
            this.fld_dteICReceiptDate.BOSFieldGroup = null;
            this.fld_dteICReceiptDate.BOSFieldRelation = null;
            this.fld_dteICReceiptDate.BOSPrivilege = null;
            this.fld_dteICReceiptDate.BOSPropertyName = "EditValue";
            this.fld_dteICReceiptDate.EditValue = null;
            this.fld_dteICReceiptDate.Location = new System.Drawing.Point(423, 12);
            this.fld_dteICReceiptDate.MenuManager = this.screenToolbar;
            this.fld_dteICReceiptDate.Name = "fld_dteICReceiptDate";
            this.fld_dteICReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICReceiptDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICReceiptDate.Screen = null;
            this.fld_dteICReceiptDate.Size = new System.Drawing.Size(128, 20);
            this.fld_dteICReceiptDate.TabIndex = 2;
            this.fld_dteICReceiptDate.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(4, 103);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String2, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 0;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(118, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 510;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_lkeICReceiptStatus
            // 
            this.fld_lkeICReceiptStatus.BOSAllowAddNew = false;
            this.fld_lkeICReceiptStatus.BOSAllowDummy = false;
            this.fld_lkeICReceiptStatus.BOSComment = null;
            this.fld_lkeICReceiptStatus.BOSDataMember = "ICReceiptStatus";
            this.fld_lkeICReceiptStatus.BOSDataSource = "ICReceipts";
            this.fld_lkeICReceiptStatus.BOSDescription = null;
            this.fld_lkeICReceiptStatus.BOSError = null;
            this.fld_lkeICReceiptStatus.BOSFieldGroup = null;
            this.fld_lkeICReceiptStatus.BOSFieldParent = null;
            this.fld_lkeICReceiptStatus.BOSFieldRelation = null;
            this.fld_lkeICReceiptStatus.BOSPrivilege = null;
            this.fld_lkeICReceiptStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICReceiptStatus.BOSSelectType = null;
            this.fld_lkeICReceiptStatus.BOSSelectTypeValue = null;
            this.fld_lkeICReceiptStatus.CurrentDisplayText = null;
            this.fld_lkeICReceiptStatus.Location = new System.Drawing.Point(423, 38);
            this.fld_lkeICReceiptStatus.MenuManager = this.screenToolbar;
            this.fld_lkeICReceiptStatus.Name = "fld_lkeICReceiptStatus";
            this.fld_lkeICReceiptStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICReceiptStatus.Properties.ReadOnly = true;
            this.fld_lkeICReceiptStatus.Screen = null;
            this.fld_lkeICReceiptStatus.Size = new System.Drawing.Size(128, 20);
            this.fld_lkeICReceiptStatus.TabIndex = 10;
            this.fld_lkeICReceiptStatus.Tag = "DC";
            // 
            // fld_txtICReceiptNo
            // 
            this.fld_txtICReceiptNo.BOSComment = null;
            this.fld_txtICReceiptNo.BOSDataMember = "ICReceiptNo";
            this.fld_txtICReceiptNo.BOSDataSource = "ICReceipts";
            this.fld_txtICReceiptNo.BOSDescription = null;
            this.fld_txtICReceiptNo.BOSError = null;
            this.fld_txtICReceiptNo.BOSFieldGroup = null;
            this.fld_txtICReceiptNo.BOSFieldRelation = null;
            this.fld_txtICReceiptNo.BOSPrivilege = null;
            this.fld_txtICReceiptNo.BOSPropertyName = "EditValue";
            this.fld_txtICReceiptNo.Location = new System.Drawing.Point(189, 12);
            this.fld_txtICReceiptNo.MenuManager = this.screenToolbar;
            this.fld_txtICReceiptNo.Name = "fld_txtICReceiptNo";
            this.fld_txtICReceiptNo.Screen = null;
            this.fld_txtICReceiptNo.Size = new System.Drawing.Size(128, 20);
            this.fld_txtICReceiptNo.TabIndex = 1;
            this.fld_txtICReceiptNo.Tag = "DC";
            // 
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = true;
            this.fld_lkeFK_MMOperationID.BOSComment = null;
            this.fld_lkeFK_MMOperationID.BOSDataMember = "FK_MMOperationID";
            this.fld_lkeFK_MMOperationID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_MMOperationID.BOSDescription = null;
            this.fld_lkeFK_MMOperationID.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMOperationID.BOSFieldGroup = null;
            this.fld_lkeFK_MMOperationID.BOSFieldParent = null;
            this.fld_lkeFK_MMOperationID.BOSFieldRelation = null;
            this.fld_lkeFK_MMOperationID.BOSPrivilege = null;
            this.fld_lkeFK_MMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationID.BOSSelectType = "MMOperationGroup";
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue = "Material";
            this.fld_lkeFK_MMOperationID.CurrentDisplayText = null;
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(423, 90);
            this.fld_lkeFK_MMOperationID.Name = "fld_lkeFK_MMOperationID";
            this.fld_lkeFK_MMOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String2, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Name")});
            this.fld_lkeFK_MMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMOperationID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMOperationID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.Screen = null;
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(128, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 575;
            this.fld_lkeFK_MMOperationID.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(332, 94);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(52, 13);
            this.bosLabel3.TabIndex = 577;
            this.bosLabel3.Text = "Công đoạn";
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeFK_MMBatchProductID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "ICReceipts";
            this.fld_lkeFK_MMBatchProductID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductID.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldParent = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeFK_MMBatchProductID.BOSPrivilege = null;
            this.fld_lkeFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductID.BOSSelectType = "BatchProductType";
            this.fld_lkeFK_MMBatchProductID.BOSSelectTypeValue = "LumberProduct";
            this.fld_lkeFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(189, 91);
            this.fld_lkeFK_MMBatchProductID.Name = "fld_lkeFK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã")});
            this.fld_lkeFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMBatchProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(128, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 574;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(118, 94);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(17, 13);
            this.bosLabel4.TabIndex = 576;
            this.bosLabel4.Text = "LSX";
            // 
            // DMRCD100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1017, 532);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMRCD100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptSerialRefix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeReceiptAcceptanceType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeProductAttributeQualityID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeWoodTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECountryID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptCDHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICReceiptDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabReceiptItems)).EndInit();
            this.fld_tabReceiptItems.ResumeLayout(false);
            this.fld_tabPageReceiptItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcReceiptCDItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptItemProductPicture1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICReceiptEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICReceiptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICReceiptStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICReceiptNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSMemoEdit fld_medICReceiptDesc;
        private BOSComponent.BOSTabControl fld_tabReceiptItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageReceiptItems;
        private BOSERP.Modules.ReceiptCD.ICReceiptItemsGridControl fld_dgcReceiptCDItems;
        private BOSComponent.BOSPictureEdit fld_pteICReceiptItemProductPicture1;
        private ItemLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSPictureEdit fld_pteICReceiptEmployeePicture;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel fld_Lablel2;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dteICReceiptDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeICReceiptStatus;
        private BOSComponent.BOSTextBox fld_txtICReceiptNo;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel fld_lblICReceiptCDHeight;
        private BOSComponent.BOSTextBox fld_txtICReceiptCDHeight;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECountryID;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel fld_lblFK_ICProductAttributeQualityID;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeWoodTypeID;
        private BOSComponent.BOSLookupEdit fld_lkeProductAttributeQualityID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeTTMTID;
        private BOSComponent.BOSButton fld_btnLumber;
        private BOSComponent.BOSLookupEdit fld_lkeReceiptAcceptanceType;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID;
        private BOSComponent.BOSLabel fld_Lablel3;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSTextBox fld_txtICReceiptSerialRefix;
        private BOSComponent.BOSLabel fld_lblICReceiptSerialRefix;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSComponent.BOSLabel bosLabel4;
	}
}
