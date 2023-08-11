using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Vehicle.UI
{
	/// <summary>
	/// Summary description for DMVM100
	/// </summary>
	partial class DMVM100
	{
		private BOSComponent.BOSLookupEdit fld_lkeFK_VMVehicleGroupID;
		private BOSComponent.BOSTextBox fld_txtVMVehicleNo;
		private BOSComponent.BOSTextBox fld_txtVMVehicleName;
		private BOSComponent.BOSTextBox fld_txtVMVehicleNoPlate;
        private BOSComponent.BOSMemoEdit fld_medVMVehicleDesc;
		private BOSComponent.BOSDateEdit fld_dteVMVehiclePurchaseDate;
		private BOSComponent.BOSTextBox fld_txtVMVehicleOdometerOnPurchase;
		private BOSComponent.BOSTextBox fld_txtVMVehicleCapacity;
        private BOSComponent.BOSTextBox fld_txtVMVehicleFuelNorm;


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
            this.fld_lkeFK_VMVehicleGroupID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtVMVehicleNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtVMVehicleName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtVMVehicleNoPlate = new BOSComponent.BOSTextBox(this.components);
            this.fld_medVMVehicleDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dteVMVehiclePurchaseDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtVMVehicleOdometerOnPurchase = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtVMVehicleCapacity = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtVMVehicleFuelNorm = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcVMVehicleCustomers = new BOSERP.Modules.Vehicle.VehicleCustomersGridControl();
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lblLabel48 = new BOSComponent.BOSLabel(this.components);
            this.fld_VMVehicleStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeVMVehicleStatus = new BOSComponent.BOSLabel(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_txtVMVehicleHight = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtVMVehicleWidth = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtVMVehicleLength = new BOSComponent.BOSTextBox(this.components);
            this.fld_lteFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtVMVehicleTruckLoad = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtVMVehicleCargoTonnage = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteVMVehicleRegistrationDeadline = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteVMVehicleInsuranceTerm = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICMeasureUnitID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtVMVehicleCarLife = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtVMVehicleCompanyName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtVMVehicleCar = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeVMDeliveryPlanTruckType = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_VMVehicleGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleNoPlate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medVMVehicleDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehiclePurchaseDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehiclePurchaseDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleOdometerOnPurchase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleCapacity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleFuelNorm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcVMVehicleCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_VMVehicleStatus.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleHight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lteFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleTruckLoad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleCargoTonnage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehicleRegistrationDeadline.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehicleRegistrationDeadline.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehicleInsuranceTerm.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehicleInsuranceTerm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICMeasureUnitID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleCarLife.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleCompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleCar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeVMDeliveryPlanTruckType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeFK_VMVehicleGroupID
            // 
            this.fld_lkeFK_VMVehicleGroupID.BOSAllowAddNew = false;
            this.fld_lkeFK_VMVehicleGroupID.BOSAllowDummy = true;
            this.fld_lkeFK_VMVehicleGroupID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_VMVehicleGroupID.BOSDataMember = "FK_VMVehicleGroupID";
            this.fld_lkeFK_VMVehicleGroupID.BOSDataSource = "VMVehicles";
            this.fld_lkeFK_VMVehicleGroupID.BOSDescription = null;
            this.fld_lkeFK_VMVehicleGroupID.BOSError = null;
            this.fld_lkeFK_VMVehicleGroupID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_VMVehicleGroupID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_VMVehicleGroupID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_VMVehicleGroupID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_VMVehicleGroupID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_VMVehicleGroupID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_VMVehicleGroupID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_VMVehicleGroupID.CurrentDisplayText = null;
            this.fld_lkeFK_VMVehicleGroupID.Location = new System.Drawing.Point(500, 32);
            this.fld_lkeFK_VMVehicleGroupID.Name = "fld_lkeFK_VMVehicleGroupID";
            this.fld_lkeFK_VMVehicleGroupID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_VMVehicleGroupID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_VMVehicleGroupID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_VMVehicleGroupID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_VMVehicleGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_VMVehicleGroupID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VMVehicleGroupNo", "Mã nhóm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VMVehicleGroupDesc", "Mô tả")});
            this.fld_lkeFK_VMVehicleGroupID.Properties.DisplayMember = "VMVehicleGroupNo";
            this.fld_lkeFK_VMVehicleGroupID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_VMVehicleGroupID.Properties.PopupWidth = 40;
            this.fld_lkeFK_VMVehicleGroupID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_VMVehicleGroupID.Properties.ValueMember = "VMVehicleGroupID";
            this.fld_lkeFK_VMVehicleGroupID.Screen = null;
            this.fld_lkeFK_VMVehicleGroupID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_VMVehicleGroupID.TabIndex = 3;
            this.fld_lkeFK_VMVehicleGroupID.Tag = "DC";
            // 
            // fld_txtVMVehicleNo
            // 
            this.fld_txtVMVehicleNo.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleNo.BOSDataMember = "VMVehicleNo";
            this.fld_txtVMVehicleNo.BOSDataSource = "VMVehicles";
            this.fld_txtVMVehicleNo.BOSDescription = null;
            this.fld_txtVMVehicleNo.BOSError = null;
            this.fld_txtVMVehicleNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleNo.BOSPropertyName = "Text";
            this.fld_txtVMVehicleNo.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleNo.Location = new System.Drawing.Point(137, 6);
            this.fld_txtVMVehicleNo.Name = "fld_txtVMVehicleNo";
            this.fld_txtVMVehicleNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleNo.Screen = null;
            this.fld_txtVMVehicleNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtVMVehicleNo.TabIndex = 0;
            this.fld_txtVMVehicleNo.Tag = "DC";
            // 
            // fld_txtVMVehicleName
            // 
            this.fld_txtVMVehicleName.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleName.BOSDataMember = "VMVehicleName";
            this.fld_txtVMVehicleName.BOSDataSource = "VMVehicles";
            this.fld_txtVMVehicleName.BOSDescription = null;
            this.fld_txtVMVehicleName.BOSError = null;
            this.fld_txtVMVehicleName.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleName.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleName.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleName.BOSPropertyName = "Text";
            this.fld_txtVMVehicleName.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleName.Location = new System.Drawing.Point(500, 6);
            this.fld_txtVMVehicleName.Name = "fld_txtVMVehicleName";
            this.fld_txtVMVehicleName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleName.Screen = null;
            this.fld_txtVMVehicleName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtVMVehicleName.TabIndex = 1;
            this.fld_txtVMVehicleName.Tag = "DC";
            // 
            // fld_txtVMVehicleNoPlate
            // 
            this.fld_txtVMVehicleNoPlate.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleNoPlate.BOSDataMember = "VMVehicleNoPlate";
            this.fld_txtVMVehicleNoPlate.BOSDataSource = "VMVehicles";
            this.fld_txtVMVehicleNoPlate.BOSDescription = null;
            this.fld_txtVMVehicleNoPlate.BOSError = null;
            this.fld_txtVMVehicleNoPlate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleNoPlate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleNoPlate.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleNoPlate.BOSPropertyName = "Text";
            this.fld_txtVMVehicleNoPlate.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleNoPlate.Location = new System.Drawing.Point(137, 32);
            this.fld_txtVMVehicleNoPlate.Name = "fld_txtVMVehicleNoPlate";
            this.fld_txtVMVehicleNoPlate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleNoPlate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleNoPlate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleNoPlate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleNoPlate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleNoPlate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleNoPlate.Screen = null;
            this.fld_txtVMVehicleNoPlate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtVMVehicleNoPlate.TabIndex = 2;
            this.fld_txtVMVehicleNoPlate.Tag = "DC";
            // 
            // fld_medVMVehicleDesc
            // 
            this.fld_medVMVehicleDesc.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_medVMVehicleDesc.BOSDataMember = "VMVehicleDesc";
            this.fld_medVMVehicleDesc.BOSDataSource = "VMVehicles";
            this.fld_medVMVehicleDesc.BOSDescription = null;
            this.fld_medVMVehicleDesc.BOSError = null;
            this.fld_medVMVehicleDesc.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_medVMVehicleDesc.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_medVMVehicleDesc.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_medVMVehicleDesc.BOSPropertyName = "Text";
            this.fld_medVMVehicleDesc.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_medVMVehicleDesc.Location = new System.Drawing.Point(137, 348);
            this.fld_medVMVehicleDesc.Name = "fld_medVMVehicleDesc";
            this.fld_medVMVehicleDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medVMVehicleDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medVMVehicleDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medVMVehicleDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medVMVehicleDesc.Screen = null;
            this.fld_medVMVehicleDesc.Size = new System.Drawing.Size(513, 50);
            this.fld_medVMVehicleDesc.TabIndex = 21;
            this.fld_medVMVehicleDesc.Tag = "DC";
            // 
            // fld_dteVMVehiclePurchaseDate
            // 
            this.fld_dteVMVehiclePurchaseDate.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteVMVehiclePurchaseDate.BOSDataMember = "VMVehiclePurchaseDate";
            this.fld_dteVMVehiclePurchaseDate.BOSDataSource = "VMVehicles";
            this.fld_dteVMVehiclePurchaseDate.BOSDescription = null;
            this.fld_dteVMVehiclePurchaseDate.BOSError = null;
            this.fld_dteVMVehiclePurchaseDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteVMVehiclePurchaseDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteVMVehiclePurchaseDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteVMVehiclePurchaseDate.BOSPropertyName = "EditValue";
            this.fld_dteVMVehiclePurchaseDate.EditValue = null;
            this.fld_dteVMVehiclePurchaseDate.Location = new System.Drawing.Point(137, 188);
            this.fld_dteVMVehiclePurchaseDate.Name = "fld_dteVMVehiclePurchaseDate";
            this.fld_dteVMVehiclePurchaseDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteVMVehiclePurchaseDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteVMVehiclePurchaseDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteVMVehiclePurchaseDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteVMVehiclePurchaseDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteVMVehiclePurchaseDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteVMVehiclePurchaseDate.Screen = null;
            this.fld_dteVMVehiclePurchaseDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteVMVehiclePurchaseDate.TabIndex = 14;
            this.fld_dteVMVehiclePurchaseDate.Tag = "DC";
            // 
            // fld_txtVMVehicleOdometerOnPurchase
            // 
            this.fld_txtVMVehicleOdometerOnPurchase.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleOdometerOnPurchase.BOSDataMember = "VMVehicleOdometerOnPurchase";
            this.fld_txtVMVehicleOdometerOnPurchase.BOSDataSource = "VMVehicles";
            this.fld_txtVMVehicleOdometerOnPurchase.BOSDescription = null;
            this.fld_txtVMVehicleOdometerOnPurchase.BOSError = null;
            this.fld_txtVMVehicleOdometerOnPurchase.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleOdometerOnPurchase.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleOdometerOnPurchase.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleOdometerOnPurchase.BOSPropertyName = "Text";
            this.fld_txtVMVehicleOdometerOnPurchase.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleOdometerOnPurchase.Location = new System.Drawing.Point(500, 214);
            this.fld_txtVMVehicleOdometerOnPurchase.Name = "fld_txtVMVehicleOdometerOnPurchase";
            this.fld_txtVMVehicleOdometerOnPurchase.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleOdometerOnPurchase.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleOdometerOnPurchase.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleOdometerOnPurchase.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleOdometerOnPurchase.Properties.Mask.EditMask = "n0";
            this.fld_txtVMVehicleOdometerOnPurchase.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtVMVehicleOdometerOnPurchase.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleOdometerOnPurchase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleOdometerOnPurchase.Screen = null;
            this.fld_txtVMVehicleOdometerOnPurchase.Size = new System.Drawing.Size(150, 20);
            this.fld_txtVMVehicleOdometerOnPurchase.TabIndex = 15;
            this.fld_txtVMVehicleOdometerOnPurchase.Tag = "DC";
            // 
            // fld_txtVMVehicleCapacity
            // 
            this.fld_txtVMVehicleCapacity.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCapacity.BOSDataMember = "VMVehicleCapacity";
            this.fld_txtVMVehicleCapacity.BOSDataSource = "VMVehicles";
            this.fld_txtVMVehicleCapacity.BOSDescription = null;
            this.fld_txtVMVehicleCapacity.BOSError = null;
            this.fld_txtVMVehicleCapacity.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCapacity.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCapacity.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCapacity.BOSPropertyName = "Text";
            this.fld_txtVMVehicleCapacity.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCapacity.Location = new System.Drawing.Point(137, 214);
            this.fld_txtVMVehicleCapacity.Name = "fld_txtVMVehicleCapacity";
            this.fld_txtVMVehicleCapacity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleCapacity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleCapacity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleCapacity.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleCapacity.Properties.Mask.EditMask = "n";
            this.fld_txtVMVehicleCapacity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtVMVehicleCapacity.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleCapacity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleCapacity.Screen = null;
            this.fld_txtVMVehicleCapacity.Size = new System.Drawing.Size(150, 20);
            this.fld_txtVMVehicleCapacity.TabIndex = 16;
            this.fld_txtVMVehicleCapacity.Tag = "DC";
            // 
            // fld_txtVMVehicleFuelNorm
            // 
            this.fld_txtVMVehicleFuelNorm.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleFuelNorm.BOSDataMember = "VMVehicleFuelNorm";
            this.fld_txtVMVehicleFuelNorm.BOSDataSource = "VMVehicles";
            this.fld_txtVMVehicleFuelNorm.BOSDescription = null;
            this.fld_txtVMVehicleFuelNorm.BOSError = null;
            this.fld_txtVMVehicleFuelNorm.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleFuelNorm.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleFuelNorm.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleFuelNorm.BOSPropertyName = "Text";
            this.fld_txtVMVehicleFuelNorm.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleFuelNorm.Location = new System.Drawing.Point(500, 240);
            this.fld_txtVMVehicleFuelNorm.Name = "fld_txtVMVehicleFuelNorm";
            this.fld_txtVMVehicleFuelNorm.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleFuelNorm.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleFuelNorm.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleFuelNorm.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleFuelNorm.Properties.Mask.EditMask = "n";
            this.fld_txtVMVehicleFuelNorm.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtVMVehicleFuelNorm.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleFuelNorm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleFuelNorm.Screen = null;
            this.fld_txtVMVehicleFuelNorm.Size = new System.Drawing.Size(150, 20);
            this.fld_txtVMVehicleFuelNorm.TabIndex = 17;
            this.fld_txtVMVehicleFuelNorm.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(12, 351);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(27, 13);
            this.bosLabel5.TabIndex = 15;
            this.bosLabel5.Text = "Mô tả";
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
            this.bosLabel11.Location = new System.Drawing.Point(347, 243);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(147, 13);
            this.bosLabel11.TabIndex = 15;
            this.bosLabel11.Text = "Định mức nhiêu liệu (lít/100km)";
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
            this.bosLabel9.Location = new System.Drawing.Point(347, 217);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(68, 13);
            this.bosLabel9.TabIndex = 15;
            this.bosLabel9.Text = "Số Km lúc mua";
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
            this.bosLabel7.Location = new System.Drawing.Point(347, 87);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(67, 13);
            this.bosLabel7.TabIndex = 15;
            this.bosLabel7.Text = "Loại nhiên liệu";
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
            this.bosLabel10.Location = new System.Drawing.Point(12, 217);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(109, 13);
            this.bosLabel10.TabIndex = 15;
            this.bosLabel10.Text = "Dung tích xi lanh (cm3)";
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(12, 191);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(48, 13);
            this.bosLabel8.TabIndex = 15;
            this.bosLabel8.Text = "Ngày mua";
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
            this.bosLabel6.Location = new System.Drawing.Point(12, 61);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(34, 13);
            this.bosLabel6.TabIndex = 15;
            this.bosLabel6.Text = "Loại xe";
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
            this.bosLabel3.Location = new System.Drawing.Point(347, 35);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(42, 13);
            this.bosLabel3.TabIndex = 15;
            this.bosLabel3.Text = "Nhóm xe";
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
            this.bosLabel4.Location = new System.Drawing.Point(12, 35);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(34, 13);
            this.bosLabel4.TabIndex = 15;
            this.bosLabel4.Text = "Biển số";
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
            this.bosLabel2.Location = new System.Drawing.Point(347, 9);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(33, 13);
            this.bosLabel2.TabIndex = 15;
            this.bosLabel2.Text = "Tên xe";
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
            this.bosLabel1.Location = new System.Drawing.Point(12, 9);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(29, 13);
            this.bosLabel1.TabIndex = 15;
            this.bosLabel1.Text = "Mã xe";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = true;
            this.bosLookupEdit2.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit2.BOSDataMember = "VMVehicleFuelType";
            this.bosLookupEdit2.BOSDataSource = "VMVehicles";
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
            this.bosLookupEdit2.Location = new System.Drawing.Point(500, 84);
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit2.Properties.PopupWidth = 40;
            this.bosLookupEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit2.TabIndex = 5;
            this.bosLookupEdit2.Tag = "DC";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = true;
            this.bosLookupEdit1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit1.BOSDataMember = "VMVehicleType";
            this.bosLookupEdit1.BOSDataSource = "VMVehicles";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit1.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit1.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(137, 58);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.bosLookupEdit1.Properties.PopupWidth = 40;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 4;
            this.bosLookupEdit1.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_lkeVMDeliveryPlanTruckType);
            this.bosPanel1.Controls.Add(this.bosLabel21);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.fld_VMVehicleStatus);
            this.bosPanel1.Controls.Add(this.fld_lkeVMVehicleStatus);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_lteFK_BRBranchID);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_txtVMVehicleTruckLoad);
            this.bosPanel1.Controls.Add(this.fld_txtVMVehicleCargoTonnage);
            this.bosPanel1.Controls.Add(this.fld_txtVMVehicleCapacity);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_txtVMVehicleFuelNorm);
            this.bosPanel1.Controls.Add(this.bosLabel18);
            this.bosPanel1.Controls.Add(this.bosLabel17);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_txtVMVehicleOdometerOnPurchase);
            this.bosPanel1.Controls.Add(this.bosLabel20);
            this.bosPanel1.Controls.Add(this.bosLabel19);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_txtVMVehicleNo);
            this.bosPanel1.Controls.Add(this.bosLabel13);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_dteVMVehicleRegistrationDeadline);
            this.bosPanel1.Controls.Add(this.fld_dteVMVehicleInsuranceTerm);
            this.bosPanel1.Controls.Add(this.fld_dteVMVehiclePurchaseDate);
            this.bosPanel1.Controls.Add(this.bosLabel16);
            this.bosPanel1.Controls.Add(this.bosLabel15);
            this.bosPanel1.Controls.Add(this.bosLabel14);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_VMVehicleGroupID);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICMeasureUnitID);
            this.bosPanel1.Controls.Add(this.bosLookupEdit1);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLookupEdit2);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_txtVMVehicleCarLife);
            this.bosPanel1.Controls.Add(this.fld_txtVMVehicleName);
            this.bosPanel1.Controls.Add(this.fld_medVMVehicleDesc);
            this.bosPanel1.Controls.Add(this.fld_txtVMVehicleCompanyName);
            this.bosPanel1.Controls.Add(this.fld_txtVMVehicleCar);
            this.bosPanel1.Controls.Add(this.fld_txtVMVehicleNoPlate);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(676, 687);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Location = new System.Drawing.Point(12, 404);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(638, 271);
            this.bosTabControl1.TabIndex = 60;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcVMVehicleCustomers);
            this.xtraTabPage1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.xtraTabPage1.Controls.Add(this.fld_lblLabel48);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(631, 242);
            this.xtraTabPage1.Text = "Danh sách đối tượng";
            // 
            // fld_dgcVMVehicleCustomers
            // 
            this.fld_dgcVMVehicleCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcVMVehicleCustomers.BOSComment = null;
            this.fld_dgcVMVehicleCustomers.BOSDataMember = null;
            this.fld_dgcVMVehicleCustomers.BOSDataSource = "VMVehicleEmployees";
            this.fld_dgcVMVehicleCustomers.BOSDescription = null;
            this.fld_dgcVMVehicleCustomers.BOSError = null;
            this.fld_dgcVMVehicleCustomers.BOSFieldGroup = null;
            this.fld_dgcVMVehicleCustomers.BOSFieldRelation = null;
            this.fld_dgcVMVehicleCustomers.BOSGridType = null;
            this.fld_dgcVMVehicleCustomers.BOSPrivilege = null;
            this.fld_dgcVMVehicleCustomers.BOSPropertyName = null;
            this.fld_dgcVMVehicleCustomers.Location = new System.Drawing.Point(3, 36);
            this.fld_dgcVMVehicleCustomers.MenuManager = this.screenToolbar;
            this.fld_dgcVMVehicleCustomers.Name = "fld_dgcVMVehicleCustomers";
            this.fld_dgcVMVehicleCustomers.PrintReport = false;
            this.fld_dgcVMVehicleCustomers.Screen = null;
            this.fld_dgcVMVehicleCustomers.Size = new System.Drawing.Size(625, 203);
            this.fld_dgcVMVehicleCustomers.TabIndex = 59;
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(58, 10);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String2, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(570, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 58;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ACObjectID_KeyUp);
            // 
            // fld_lblLabel48
            // 
            this.fld_lblLabel48.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel48.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel48.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel48.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel48.BOSComment = null;
            this.fld_lblLabel48.BOSDataMember = null;
            this.fld_lblLabel48.BOSDataSource = null;
            this.fld_lblLabel48.BOSDescription = null;
            this.fld_lblLabel48.BOSError = null;
            this.fld_lblLabel48.BOSFieldGroup = null;
            this.fld_lblLabel48.BOSFieldRelation = null;
            this.fld_lblLabel48.BOSPrivilege = null;
            this.fld_lblLabel48.BOSPropertyName = null;
            this.fld_lblLabel48.Location = new System.Drawing.Point(4, 13);
            this.fld_lblLabel48.Name = "fld_lblLabel48";
            this.fld_lblLabel48.Screen = null;
            this.fld_lblLabel48.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel48.TabIndex = 57;
            this.fld_lblLabel48.Text = "Đối tượng";
            // 
            // fld_VMVehicleStatus
            // 
            this.fld_VMVehicleStatus.BOSAllowAddNew = false;
            this.fld_VMVehicleStatus.BOSAllowDummy = true;
            this.fld_VMVehicleStatus.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_VMVehicleStatus.BOSDataMember = "VMVehicleStatus";
            this.fld_VMVehicleStatus.BOSDataSource = "VMVehicles";
            this.fld_VMVehicleStatus.BOSDescription = null;
            this.fld_VMVehicleStatus.BOSError = null;
            this.fld_VMVehicleStatus.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_VMVehicleStatus.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_VMVehicleStatus.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_VMVehicleStatus.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_VMVehicleStatus.BOSPropertyName = "EditValue";
            this.fld_VMVehicleStatus.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_VMVehicleStatus.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_VMVehicleStatus.CurrentDisplayText = null;
            this.fld_VMVehicleStatus.Location = new System.Drawing.Point(500, 266);
            this.fld_VMVehicleStatus.Name = "fld_VMVehicleStatus";
            this.fld_VMVehicleStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_VMVehicleStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_VMVehicleStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_VMVehicleStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_VMVehicleStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_VMVehicleStatus.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_VMVehicleStatus.Properties.PopupWidth = 40;
            this.fld_VMVehicleStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_VMVehicleStatus.Screen = null;
            this.fld_VMVehicleStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_VMVehicleStatus.TabIndex = 19;
            this.fld_VMVehicleStatus.Tag = "DC";
            // 
            // fld_lkeVMVehicleStatus
            // 
            this.fld_lkeVMVehicleStatus.BOSComment = null;
            this.fld_lkeVMVehicleStatus.BOSDataMember = "VMVehicleStatus";
            this.fld_lkeVMVehicleStatus.BOSDataSource = "VMVehicles";
            this.fld_lkeVMVehicleStatus.BOSDescription = null;
            this.fld_lkeVMVehicleStatus.BOSError = null;
            this.fld_lkeVMVehicleStatus.BOSFieldGroup = null;
            this.fld_lkeVMVehicleStatus.BOSFieldRelation = null;
            this.fld_lkeVMVehicleStatus.BOSPrivilege = null;
            this.fld_lkeVMVehicleStatus.BOSPropertyName = null;
            this.fld_lkeVMVehicleStatus.Location = new System.Drawing.Point(347, 269);
            this.fld_lkeVMVehicleStatus.Name = "fld_lkeVMVehicleStatus";
            this.fld_lkeVMVehicleStatus.Screen = null;
            this.fld_lkeVMVehicleStatus.Size = new System.Drawing.Size(49, 13);
            this.fld_lkeVMVehicleStatus.TabIndex = 25;
            this.fld_lkeVMVehicleStatus.Text = "Tình trạng";
            // 
            // bosLine1
            // 
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_txtVMVehicleHight);
            this.bosLine1.Controls.Add(this.fld_txtVMVehicleWidth);
            this.bosLine1.Controls.Add(this.bosLabel23);
            this.bosLine1.Controls.Add(this.fld_txtVMVehicleLength);
            this.bosLine1.Location = new System.Drawing.Point(12, 292);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(638, 50);
            this.bosLine1.TabIndex = 20;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Kích thước thùng";
            // 
            // fld_txtVMVehicleHight
            // 
            this.fld_txtVMVehicleHight.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleHight.BOSDataMember = "VMVehicleHight";
            this.fld_txtVMVehicleHight.BOSDataSource = "VMVehicles";
            this.fld_txtVMVehicleHight.BOSDescription = null;
            this.fld_txtVMVehicleHight.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleHight.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleHight.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleHight.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleHight.BOSPropertyName = "Text";
            this.fld_txtVMVehicleHight.Location = new System.Drawing.Point(257, 17);
            this.fld_txtVMVehicleHight.Name = "fld_txtVMVehicleHight";
            this.fld_txtVMVehicleHight.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleHight.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleHight.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleHight.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleHight.Properties.Mask.EditMask = "n";
            this.fld_txtVMVehicleHight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtVMVehicleHight.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleHight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleHight.Screen = null;
            this.fld_txtVMVehicleHight.Size = new System.Drawing.Size(60, 20);
            this.fld_txtVMVehicleHight.TabIndex = 2;
            this.fld_txtVMVehicleHight.Tag = "DC";
            // 
            // fld_txtVMVehicleWidth
            // 
            this.fld_txtVMVehicleWidth.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleWidth.BOSDataMember = "VMVehicleWidth";
            this.fld_txtVMVehicleWidth.BOSDataSource = "VMVehicles";
            this.fld_txtVMVehicleWidth.BOSDescription = null;
            this.fld_txtVMVehicleWidth.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleWidth.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleWidth.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleWidth.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleWidth.BOSPropertyName = "Text";
            this.fld_txtVMVehicleWidth.Location = new System.Drawing.Point(191, 17);
            this.fld_txtVMVehicleWidth.Name = "fld_txtVMVehicleWidth";
            this.fld_txtVMVehicleWidth.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleWidth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleWidth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleWidth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleWidth.Properties.Mask.EditMask = "n";
            this.fld_txtVMVehicleWidth.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtVMVehicleWidth.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleWidth.Screen = null;
            this.fld_txtVMVehicleWidth.Size = new System.Drawing.Size(60, 20);
            this.fld_txtVMVehicleWidth.TabIndex = 1;
            this.fld_txtVMVehicleWidth.Tag = "DC";
            // 
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel23.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Options.UseBackColor = true;
            this.bosLabel23.Appearance.Options.UseFont = true;
            this.bosLabel23.Appearance.Options.UseForeColor = true;
            this.bosLabel23.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel23.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel23.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel23.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel23.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel23.BOSPropertyName = null;
            this.bosLabel23.Location = new System.Drawing.Point(8, 20);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(83, 13);
            this.bosLabel23.TabIndex = 63;
            this.bosLabel23.Tag = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel23.Text = "Dài x Rộng x Cao";
            // 
            // fld_txtVMVehicleLength
            // 
            this.fld_txtVMVehicleLength.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleLength.BOSDataMember = "VMVehicleLength";
            this.fld_txtVMVehicleLength.BOSDataSource = "VMVehicles";
            this.fld_txtVMVehicleLength.BOSDescription = null;
            this.fld_txtVMVehicleLength.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleLength.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleLength.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleLength.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleLength.BOSPropertyName = "Text";
            this.fld_txtVMVehicleLength.Location = new System.Drawing.Point(125, 17);
            this.fld_txtVMVehicleLength.Name = "fld_txtVMVehicleLength";
            this.fld_txtVMVehicleLength.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleLength.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleLength.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleLength.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleLength.Properties.Mask.EditMask = "n";
            this.fld_txtVMVehicleLength.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtVMVehicleLength.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleLength.Screen = null;
            this.fld_txtVMVehicleLength.Size = new System.Drawing.Size(60, 20);
            this.fld_txtVMVehicleLength.TabIndex = 0;
            this.fld_txtVMVehicleLength.Tag = "DC";
            // 
            // fld_lteFK_BRBranchID
            // 
            this.fld_lteFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lteFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lteFK_BRBranchID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lteFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lteFK_BRBranchID.BOSDataSource = "VMVehicles";
            this.fld_lteFK_BRBranchID.BOSDescription = null;
            this.fld_lteFK_BRBranchID.BOSError = null;
            this.fld_lteFK_BRBranchID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lteFK_BRBranchID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lteFK_BRBranchID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lteFK_BRBranchID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lteFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lteFK_BRBranchID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lteFK_BRBranchID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lteFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lteFK_BRBranchID.Location = new System.Drawing.Point(500, 136);
            this.fld_lteFK_BRBranchID.Name = "fld_lteFK_BRBranchID";
            this.fld_lteFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lteFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lteFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lteFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lteFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lteFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã đơn vị"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên đơn vị"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchCompanyName", "Tên công ty")});
            this.fld_lteFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lteFK_BRBranchID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lteFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lteFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lteFK_BRBranchID.Screen = null;
            this.fld_lteFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lteFK_BRBranchID.TabIndex = 9;
            this.fld_lteFK_BRBranchID.Tag = "DC";
            // 
            // fld_txtVMVehicleTruckLoad
            // 
            this.fld_txtVMVehicleTruckLoad.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleTruckLoad.BOSDataMember = "VMVehicleTruckLoad";
            this.fld_txtVMVehicleTruckLoad.BOSDataSource = "VMVehicles";
            this.fld_txtVMVehicleTruckLoad.BOSDescription = null;
            this.fld_txtVMVehicleTruckLoad.BOSError = null;
            this.fld_txtVMVehicleTruckLoad.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleTruckLoad.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleTruckLoad.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleTruckLoad.BOSPropertyName = "Text";
            this.fld_txtVMVehicleTruckLoad.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleTruckLoad.Location = new System.Drawing.Point(500, 162);
            this.fld_txtVMVehicleTruckLoad.Name = "fld_txtVMVehicleTruckLoad";
            this.fld_txtVMVehicleTruckLoad.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleTruckLoad.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleTruckLoad.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleTruckLoad.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleTruckLoad.Properties.Mask.EditMask = "n0";
            this.fld_txtVMVehicleTruckLoad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtVMVehicleTruckLoad.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleTruckLoad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleTruckLoad.Screen = null;
            this.fld_txtVMVehicleTruckLoad.Size = new System.Drawing.Size(150, 20);
            this.fld_txtVMVehicleTruckLoad.TabIndex = 11;
            this.fld_txtVMVehicleTruckLoad.Tag = "DC";
            // 
            // fld_txtVMVehicleCargoTonnage
            // 
            this.fld_txtVMVehicleCargoTonnage.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCargoTonnage.BOSDataMember = "VMVehicleCargoTonnage";
            this.fld_txtVMVehicleCargoTonnage.BOSDataSource = "VMVehicles";
            this.fld_txtVMVehicleCargoTonnage.BOSDescription = null;
            this.fld_txtVMVehicleCargoTonnage.BOSError = null;
            this.fld_txtVMVehicleCargoTonnage.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCargoTonnage.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCargoTonnage.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCargoTonnage.BOSPropertyName = "Text";
            this.fld_txtVMVehicleCargoTonnage.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCargoTonnage.Location = new System.Drawing.Point(137, 136);
            this.fld_txtVMVehicleCargoTonnage.Name = "fld_txtVMVehicleCargoTonnage";
            this.fld_txtVMVehicleCargoTonnage.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleCargoTonnage.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleCargoTonnage.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleCargoTonnage.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleCargoTonnage.Properties.Mask.EditMask = "n0";
            this.fld_txtVMVehicleCargoTonnage.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtVMVehicleCargoTonnage.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleCargoTonnage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleCargoTonnage.Screen = null;
            this.fld_txtVMVehicleCargoTonnage.Size = new System.Drawing.Size(150, 20);
            this.fld_txtVMVehicleCargoTonnage.TabIndex = 10;
            this.fld_txtVMVehicleCargoTonnage.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.BOSComment = null;
            this.bosLabel18.BOSDataMember = null;
            this.bosLabel18.BOSDataSource = null;
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = null;
            this.bosLabel18.BOSFieldRelation = null;
            this.bosLabel18.BOSPrivilege = null;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(12, 113);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(36, 13);
            this.bosLabel18.TabIndex = 15;
            this.bosLabel18.Text = "Hiệu xe";
            // 
            // bosLabel17
            // 
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(347, 113);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(31, 13);
            this.bosLabel17.TabIndex = 15;
            this.bosLabel17.Text = "Đời xe";
            // 
            // bosLabel20
            // 
            this.bosLabel20.BOSComment = null;
            this.bosLabel20.BOSDataMember = null;
            this.bosLabel20.BOSDataSource = null;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = null;
            this.bosLabel20.BOSFieldRelation = null;
            this.bosLabel20.BOSPrivilege = null;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(347, 165);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(58, 13);
            this.bosLabel20.TabIndex = 15;
            this.bosLabel20.Text = "Trọng tải xe";
            // 
            // bosLabel19
            // 
            this.bosLabel19.BOSComment = null;
            this.bosLabel19.BOSDataMember = null;
            this.bosLabel19.BOSDataSource = null;
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = null;
            this.bosLabel19.BOSFieldRelation = null;
            this.bosLabel19.BOSPrivilege = null;
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(12, 139);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(70, 13);
            this.bosLabel19.TabIndex = 15;
            this.bosLabel19.Text = "Trọng tải hàng";
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
            this.bosLabel13.Location = new System.Drawing.Point(347, 191);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(70, 13);
            this.bosLabel13.TabIndex = 15;
            this.bosLabel13.Text = "Hạn đăng kiểm";
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
            this.bosLabel12.Location = new System.Drawing.Point(12, 165);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(65, 13);
            this.bosLabel12.TabIndex = 15;
            this.bosLabel12.Text = "Hạn bảo hiểm";
            // 
            // fld_dteVMVehicleRegistrationDeadline
            // 
            this.fld_dteVMVehicleRegistrationDeadline.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteVMVehicleRegistrationDeadline.BOSDataMember = "VMVehicleRegistrationDeadline";
            this.fld_dteVMVehicleRegistrationDeadline.BOSDataSource = "VMVehicles";
            this.fld_dteVMVehicleRegistrationDeadline.BOSDescription = null;
            this.fld_dteVMVehicleRegistrationDeadline.BOSError = null;
            this.fld_dteVMVehicleRegistrationDeadline.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteVMVehicleRegistrationDeadline.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteVMVehicleRegistrationDeadline.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteVMVehicleRegistrationDeadline.BOSPropertyName = "EditValue";
            this.fld_dteVMVehicleRegistrationDeadline.EditValue = null;
            this.fld_dteVMVehicleRegistrationDeadline.Location = new System.Drawing.Point(500, 188);
            this.fld_dteVMVehicleRegistrationDeadline.Name = "fld_dteVMVehicleRegistrationDeadline";
            this.fld_dteVMVehicleRegistrationDeadline.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteVMVehicleRegistrationDeadline.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteVMVehicleRegistrationDeadline.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteVMVehicleRegistrationDeadline.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteVMVehicleRegistrationDeadline.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteVMVehicleRegistrationDeadline.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteVMVehicleRegistrationDeadline.Screen = null;
            this.fld_dteVMVehicleRegistrationDeadline.Size = new System.Drawing.Size(150, 20);
            this.fld_dteVMVehicleRegistrationDeadline.TabIndex = 13;
            this.fld_dteVMVehicleRegistrationDeadline.Tag = "DC";
            // 
            // fld_dteVMVehicleInsuranceTerm
            // 
            this.fld_dteVMVehicleInsuranceTerm.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteVMVehicleInsuranceTerm.BOSDataMember = "VMVehicleInsuranceTerm";
            this.fld_dteVMVehicleInsuranceTerm.BOSDataSource = "VMVehicles";
            this.fld_dteVMVehicleInsuranceTerm.BOSDescription = null;
            this.fld_dteVMVehicleInsuranceTerm.BOSError = null;
            this.fld_dteVMVehicleInsuranceTerm.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteVMVehicleInsuranceTerm.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteVMVehicleInsuranceTerm.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteVMVehicleInsuranceTerm.BOSPropertyName = "EditValue";
            this.fld_dteVMVehicleInsuranceTerm.EditValue = null;
            this.fld_dteVMVehicleInsuranceTerm.Location = new System.Drawing.Point(137, 162);
            this.fld_dteVMVehicleInsuranceTerm.Name = "fld_dteVMVehicleInsuranceTerm";
            this.fld_dteVMVehicleInsuranceTerm.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteVMVehicleInsuranceTerm.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteVMVehicleInsuranceTerm.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteVMVehicleInsuranceTerm.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteVMVehicleInsuranceTerm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteVMVehicleInsuranceTerm.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteVMVehicleInsuranceTerm.Screen = null;
            this.fld_dteVMVehicleInsuranceTerm.Size = new System.Drawing.Size(150, 20);
            this.fld_dteVMVehicleInsuranceTerm.TabIndex = 12;
            this.fld_dteVMVehicleInsuranceTerm.Tag = "DC";
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
            this.bosLabel16.Location = new System.Drawing.Point(347, 139);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(73, 13);
            this.bosLabel16.TabIndex = 15;
            this.bosLabel16.Text = "Đơn vị sử dụng";
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
            this.bosLabel15.Location = new System.Drawing.Point(12, 243);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(68, 13);
            this.bosLabel15.TabIndex = 15;
            this.bosLabel15.Text = "Thuộc công ty";
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
            this.bosLabel14.Location = new System.Drawing.Point(12, 87);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(52, 13);
            this.bosLabel14.TabIndex = 15;
            this.bosLabel14.Text = "Đơn vị tính";
            // 
            // fld_lkeFK_ICMeasureUnitID
            // 
            this.fld_lkeFK_ICMeasureUnitID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICMeasureUnitID.BOSAllowDummy = true;
            this.fld_lkeFK_ICMeasureUnitID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICMeasureUnitID.BOSDataMember = "FK_ICMeasureUnitID";
            this.fld_lkeFK_ICMeasureUnitID.BOSDataSource = "VMVehicles";
            this.fld_lkeFK_ICMeasureUnitID.BOSDescription = null;
            this.fld_lkeFK_ICMeasureUnitID.BOSError = null;
            this.fld_lkeFK_ICMeasureUnitID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICMeasureUnitID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICMeasureUnitID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICMeasureUnitID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICMeasureUnitID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICMeasureUnitID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICMeasureUnitID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICMeasureUnitID.CurrentDisplayText = null;
            this.fld_lkeFK_ICMeasureUnitID.Location = new System.Drawing.Point(137, 84);
            this.fld_lkeFK_ICMeasureUnitID.Name = "fld_lkeFK_ICMeasureUnitID";
            this.fld_lkeFK_ICMeasureUnitID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICMeasureUnitID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICMeasureUnitID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICMeasureUnitID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICMeasureUnitID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICMeasureUnitID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICMeasureUnitName", "Đơn vị tính")});
            this.fld_lkeFK_ICMeasureUnitID.Properties.DisplayMember = "ICMeasureUnitName";
            this.fld_lkeFK_ICMeasureUnitID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICMeasureUnitID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICMeasureUnitID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICMeasureUnitID.Properties.ValueMember = "ICMeasureUnitID";
            this.fld_lkeFK_ICMeasureUnitID.Screen = null;
            this.fld_lkeFK_ICMeasureUnitID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICMeasureUnitID.TabIndex = 6;
            this.fld_lkeFK_ICMeasureUnitID.Tag = "DC";
            // 
            // fld_txtVMVehicleCarLife
            // 
            this.fld_txtVMVehicleCarLife.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCarLife.BOSDataMember = "VMVehicleCarLife";
            this.fld_txtVMVehicleCarLife.BOSDataSource = "VMVehicles";
            this.fld_txtVMVehicleCarLife.BOSDescription = null;
            this.fld_txtVMVehicleCarLife.BOSError = null;
            this.fld_txtVMVehicleCarLife.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCarLife.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCarLife.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCarLife.BOSPropertyName = "Text";
            this.fld_txtVMVehicleCarLife.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCarLife.Location = new System.Drawing.Point(500, 110);
            this.fld_txtVMVehicleCarLife.Name = "fld_txtVMVehicleCarLife";
            this.fld_txtVMVehicleCarLife.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleCarLife.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleCarLife.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleCarLife.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleCarLife.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleCarLife.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleCarLife.Screen = null;
            this.fld_txtVMVehicleCarLife.Size = new System.Drawing.Size(150, 20);
            this.fld_txtVMVehicleCarLife.TabIndex = 7;
            this.fld_txtVMVehicleCarLife.Tag = "DC";
            // 
            // fld_txtVMVehicleCompanyName
            // 
            this.fld_txtVMVehicleCompanyName.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCompanyName.BOSDataMember = "VMVehicleCompanyName";
            this.fld_txtVMVehicleCompanyName.BOSDataSource = "VMVehicles";
            this.fld_txtVMVehicleCompanyName.BOSDescription = null;
            this.fld_txtVMVehicleCompanyName.BOSError = null;
            this.fld_txtVMVehicleCompanyName.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCompanyName.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCompanyName.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCompanyName.BOSPropertyName = "Text";
            this.fld_txtVMVehicleCompanyName.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCompanyName.Location = new System.Drawing.Point(137, 240);
            this.fld_txtVMVehicleCompanyName.Name = "fld_txtVMVehicleCompanyName";
            this.fld_txtVMVehicleCompanyName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleCompanyName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleCompanyName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleCompanyName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleCompanyName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleCompanyName.Screen = null;
            this.fld_txtVMVehicleCompanyName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtVMVehicleCompanyName.TabIndex = 18;
            this.fld_txtVMVehicleCompanyName.Tag = "DC";
            // 
            // fld_txtVMVehicleCar
            // 
            this.fld_txtVMVehicleCar.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCar.BOSDataMember = "VMVehicleCar";
            this.fld_txtVMVehicleCar.BOSDataSource = "VMVehicles";
            this.fld_txtVMVehicleCar.BOSDescription = null;
            this.fld_txtVMVehicleCar.BOSError = null;
            this.fld_txtVMVehicleCar.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCar.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCar.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCar.BOSPropertyName = "Text";
            this.fld_txtVMVehicleCar.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtVMVehicleCar.Location = new System.Drawing.Point(137, 110);
            this.fld_txtVMVehicleCar.Name = "fld_txtVMVehicleCar";
            this.fld_txtVMVehicleCar.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleCar.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleCar.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleCar.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleCar.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleCar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleCar.Screen = null;
            this.fld_txtVMVehicleCar.Size = new System.Drawing.Size(150, 20);
            this.fld_txtVMVehicleCar.TabIndex = 8;
            this.fld_txtVMVehicleCar.Tag = "DC";
            // 
            // bosLabel21
            // 
            this.bosLabel21.BOSComment = null;
            this.bosLabel21.BOSDataMember = null;
            this.bosLabel21.BOSDataSource = null;
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = null;
            this.bosLabel21.BOSFieldRelation = null;
            this.bosLabel21.BOSPrivilege = null;
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(346, 61);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(58, 13);
            this.bosLabel21.TabIndex = 61;
            this.bosLabel21.Text = "Phân loại xe";
            // 
            // fld_lkeVMDeliveryPlanTruckType
            // 
            this.fld_lkeVMDeliveryPlanTruckType.BOSAllowAddNew = false;
            this.fld_lkeVMDeliveryPlanTruckType.BOSAllowDummy = true;
            this.fld_lkeVMDeliveryPlanTruckType.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeVMDeliveryPlanTruckType.BOSDataMember = "VMDeliveryPlanTruckType";
            this.fld_lkeVMDeliveryPlanTruckType.BOSDataSource = "VMVehicles";
            this.fld_lkeVMDeliveryPlanTruckType.BOSDescription = null;
            this.fld_lkeVMDeliveryPlanTruckType.BOSError = null;
            this.fld_lkeVMDeliveryPlanTruckType.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeVMDeliveryPlanTruckType.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeVMDeliveryPlanTruckType.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeVMDeliveryPlanTruckType.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeVMDeliveryPlanTruckType.BOSPropertyName = "EditValue";
            this.fld_lkeVMDeliveryPlanTruckType.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeVMDeliveryPlanTruckType.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeVMDeliveryPlanTruckType.CurrentDisplayText = null;
            this.fld_lkeVMDeliveryPlanTruckType.Location = new System.Drawing.Point(500, 58);
            this.fld_lkeVMDeliveryPlanTruckType.Name = "fld_lkeVMDeliveryPlanTruckType";
            this.fld_lkeVMDeliveryPlanTruckType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeVMDeliveryPlanTruckType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeVMDeliveryPlanTruckType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeVMDeliveryPlanTruckType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeVMDeliveryPlanTruckType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeVMDeliveryPlanTruckType.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeVMDeliveryPlanTruckType.Properties.PopupWidth = 40;
            this.fld_lkeVMDeliveryPlanTruckType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeVMDeliveryPlanTruckType.Screen = null;
            this.fld_lkeVMDeliveryPlanTruckType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeVMDeliveryPlanTruckType.TabIndex = 62;
            this.fld_lkeVMDeliveryPlanTruckType.Tag = "DC";
            // 
            // DMVM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(676, 687);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMVM100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_VMVehicleGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleNoPlate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medVMVehicleDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehiclePurchaseDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehiclePurchaseDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleOdometerOnPurchase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleCapacity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleFuelNorm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcVMVehicleCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_VMVehicleStatus.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleHight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lteFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleTruckLoad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleCargoTonnage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehicleRegistrationDeadline.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehicleRegistrationDeadline.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehicleInsuranceTerm.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehicleInsuranceTerm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICMeasureUnitID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleCarLife.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleCompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleCar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeVMDeliveryPlanTruckType.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSDateEdit fld_dteVMVehicleRegistrationDeadline;
        private BOSComponent.BOSDateEdit fld_dteVMVehicleInsuranceTerm;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICMeasureUnitID;
        private BOSComponent.BOSTextBox fld_txtVMVehicleCompanyName;
        private BOSComponent.BOSLookupEdit fld_lteFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSTextBox fld_txtVMVehicleCarLife;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSTextBox fld_txtVMVehicleCar;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSTextBox fld_txtVMVehicleHight;
        private BOSComponent.BOSTextBox fld_txtVMVehicleWidth;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSTextBox fld_txtVMVehicleLength;
        private BOSComponent.BOSTextBox fld_txtVMVehicleTruckLoad;
        private BOSComponent.BOSTextBox fld_txtVMVehicleCargoTonnage;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLabel fld_lkeVMVehicleStatus;
        private BOSComponent.BOSLookupEdit fld_VMVehicleStatus;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSLabel fld_lblLabel48;
        public AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private VehicleCustomersGridControl fld_dgcVMVehicleCustomers;
        private BOSComponent.BOSLookupEdit fld_lkeVMDeliveryPlanTruckType;
        private BOSComponent.BOSLabel bosLabel21;
	}
}
