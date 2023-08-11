using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Vehicle.UI
{
	/// <summary>
	/// Summary description for DMVM101
	/// </summary>
	partial class DMVM101
    {
		private BOSComponent.BOSTextBox fld_txtVMVehicleFuelLogQty;
		private BOSComponent.BOSTextBox fld_txtVMVehicleFuelLogCost;
		private BOSComponent.BOSTextBox fld_txtVMVehicleFuelLogTotalCost;
		private BOSComponent.BOSTextBox fld_txtVMVehicleFuelLogStartOdometer;
		private BOSComponent.BOSTextBox fld_txtVMVehicleFuelLogEndOdometer;
		private BOSComponent.BOSTextBox fld_txtVMVehicleFuelLogDistanceCovered;
		private BOSComponent.BOSTextBox fld_txtVMVehicleFuelLogConsumption1;
		private BOSComponent.BOSTextBox fld_txtVMVehicleFuelLogConsumption2;
        private BOSComponent.BOSMemoEdit fld_medVMVehicleFuelLogRemark;


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
            this.fld_txtVMVehicleFuelLogQty = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtVMVehicleFuelLogCost = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtVMVehicleFuelLogTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtVMVehicleFuelLogStartOdometer = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtVMVehicleFuelLogEndOdometer = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtVMVehicleFuelLogDistanceCovered = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtVMVehicleFuelLogConsumption1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtVMVehicleFuelLogConsumption2 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medVMVehicleFuelLogRemark = new BOSComponent.BOSMemoEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcVMVehicleFuelLogs = new BOSERP.Modules.Vehicle.VehicleFuelLogsGridControl();
            this.bosButton3 = new BOSComponent.BOSButton(this.components);
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteVMVehiclePurchaseDate = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleFuelLogQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleFuelLogCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleFuelLogTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleFuelLogStartOdometer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleFuelLogEndOdometer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleFuelLogDistanceCovered.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleFuelLogConsumption1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleFuelLogConsumption2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medVMVehicleFuelLogRemark.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcVMVehicleFuelLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehiclePurchaseDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehiclePurchaseDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtVMVehicleFuelLogQty
            // 
            this.fld_txtVMVehicleFuelLogQty.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogQty.BOSDataMember = "VMVehicleFuelLogQty";
            this.fld_txtVMVehicleFuelLogQty.BOSDataSource = "VMVehicleFuelLogs";
            this.fld_txtVMVehicleFuelLogQty.BOSDescription = null;
            this.fld_txtVMVehicleFuelLogQty.BOSError = null;
            this.fld_txtVMVehicleFuelLogQty.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogQty.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogQty.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogQty.BOSPropertyName = "Text";
            this.fld_txtVMVehicleFuelLogQty.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogQty.Location = new System.Drawing.Point(132, 61);
            this.fld_txtVMVehicleFuelLogQty.Name = "fld_txtVMVehicleFuelLogQty";
            this.fld_txtVMVehicleFuelLogQty.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleFuelLogQty.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleFuelLogQty.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleFuelLogQty.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleFuelLogQty.Properties.Mask.EditMask = "n";
            this.fld_txtVMVehicleFuelLogQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtVMVehicleFuelLogQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleFuelLogQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleFuelLogQty.Screen = null;
            this.fld_txtVMVehicleFuelLogQty.Size = new System.Drawing.Size(125, 20);
            this.fld_txtVMVehicleFuelLogQty.TabIndex = 6;
            this.fld_txtVMVehicleFuelLogQty.Tag = "DC";
            this.fld_txtVMVehicleFuelLogQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_txtVMVehicleFuelLogQty_KeyUp);
            // 
            // fld_txtVMVehicleFuelLogCost
            // 
            this.fld_txtVMVehicleFuelLogCost.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogCost.BOSDataMember = "VMVehicleFuelLogCost";
            this.fld_txtVMVehicleFuelLogCost.BOSDataSource = "VMVehicleFuelLogs";
            this.fld_txtVMVehicleFuelLogCost.BOSDescription = null;
            this.fld_txtVMVehicleFuelLogCost.BOSError = null;
            this.fld_txtVMVehicleFuelLogCost.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogCost.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogCost.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogCost.BOSPropertyName = "Text";
            this.fld_txtVMVehicleFuelLogCost.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogCost.Location = new System.Drawing.Point(475, 61);
            this.fld_txtVMVehicleFuelLogCost.Name = "fld_txtVMVehicleFuelLogCost";
            this.fld_txtVMVehicleFuelLogCost.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleFuelLogCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleFuelLogCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleFuelLogCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleFuelLogCost.Properties.Mask.EditMask = "n";
            this.fld_txtVMVehicleFuelLogCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtVMVehicleFuelLogCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleFuelLogCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleFuelLogCost.Screen = null;
            this.fld_txtVMVehicleFuelLogCost.Size = new System.Drawing.Size(125, 20);
            this.fld_txtVMVehicleFuelLogCost.TabIndex = 7;
            this.fld_txtVMVehicleFuelLogCost.Tag = "DC";
            this.fld_txtVMVehicleFuelLogCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_txtVMVehicleFuelLogQty_KeyUp);
            // 
            // fld_txtVMVehicleFuelLogTotalCost
            // 
            this.fld_txtVMVehicleFuelLogTotalCost.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogTotalCost.BOSDataMember = "VMVehicleFuelLogTotalCost";
            this.fld_txtVMVehicleFuelLogTotalCost.BOSDataSource = "VMVehicleFuelLogs";
            this.fld_txtVMVehicleFuelLogTotalCost.BOSDescription = null;
            this.fld_txtVMVehicleFuelLogTotalCost.BOSError = null;
            this.fld_txtVMVehicleFuelLogTotalCost.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogTotalCost.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogTotalCost.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogTotalCost.BOSPropertyName = "Text";
            this.fld_txtVMVehicleFuelLogTotalCost.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogTotalCost.Enabled = false;
            this.fld_txtVMVehicleFuelLogTotalCost.Location = new System.Drawing.Point(132, 87);
            this.fld_txtVMVehicleFuelLogTotalCost.Name = "fld_txtVMVehicleFuelLogTotalCost";
            this.fld_txtVMVehicleFuelLogTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleFuelLogTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleFuelLogTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleFuelLogTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleFuelLogTotalCost.Properties.Mask.EditMask = "n";
            this.fld_txtVMVehicleFuelLogTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtVMVehicleFuelLogTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleFuelLogTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleFuelLogTotalCost.Screen = null;
            this.fld_txtVMVehicleFuelLogTotalCost.Size = new System.Drawing.Size(125, 20);
            this.fld_txtVMVehicleFuelLogTotalCost.TabIndex = 8;
            this.fld_txtVMVehicleFuelLogTotalCost.Tag = "DC";
            // 
            // fld_txtVMVehicleFuelLogStartOdometer
            // 
            this.fld_txtVMVehicleFuelLogStartOdometer.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogStartOdometer.BOSDataMember = "VMVehicleFuelLogStartOdometer";
            this.fld_txtVMVehicleFuelLogStartOdometer.BOSDataSource = "VMVehicleFuelLogs";
            this.fld_txtVMVehicleFuelLogStartOdometer.BOSDescription = null;
            this.fld_txtVMVehicleFuelLogStartOdometer.BOSError = null;
            this.fld_txtVMVehicleFuelLogStartOdometer.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogStartOdometer.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogStartOdometer.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogStartOdometer.BOSPropertyName = "Text";
            this.fld_txtVMVehicleFuelLogStartOdometer.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogStartOdometer.Location = new System.Drawing.Point(132, 113);
            this.fld_txtVMVehicleFuelLogStartOdometer.Name = "fld_txtVMVehicleFuelLogStartOdometer";
            this.fld_txtVMVehicleFuelLogStartOdometer.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleFuelLogStartOdometer.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleFuelLogStartOdometer.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleFuelLogStartOdometer.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleFuelLogStartOdometer.Properties.Mask.EditMask = "n";
            this.fld_txtVMVehicleFuelLogStartOdometer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtVMVehicleFuelLogStartOdometer.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleFuelLogStartOdometer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleFuelLogStartOdometer.Screen = null;
            this.fld_txtVMVehicleFuelLogStartOdometer.Size = new System.Drawing.Size(125, 20);
            this.fld_txtVMVehicleFuelLogStartOdometer.TabIndex = 9;
            this.fld_txtVMVehicleFuelLogStartOdometer.Tag = "DC";
            this.fld_txtVMVehicleFuelLogStartOdometer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_txtVMVehicleFuelLogStartOdometer_KeyUp);
            // 
            // fld_txtVMVehicleFuelLogEndOdometer
            // 
            this.fld_txtVMVehicleFuelLogEndOdometer.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogEndOdometer.BOSDataMember = "VMVehicleFuelLogEndOdometer";
            this.fld_txtVMVehicleFuelLogEndOdometer.BOSDataSource = "VMVehicleFuelLogs";
            this.fld_txtVMVehicleFuelLogEndOdometer.BOSDescription = null;
            this.fld_txtVMVehicleFuelLogEndOdometer.BOSError = null;
            this.fld_txtVMVehicleFuelLogEndOdometer.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogEndOdometer.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogEndOdometer.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogEndOdometer.BOSPropertyName = "Text";
            this.fld_txtVMVehicleFuelLogEndOdometer.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogEndOdometer.Location = new System.Drawing.Point(475, 113);
            this.fld_txtVMVehicleFuelLogEndOdometer.Name = "fld_txtVMVehicleFuelLogEndOdometer";
            this.fld_txtVMVehicleFuelLogEndOdometer.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleFuelLogEndOdometer.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleFuelLogEndOdometer.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleFuelLogEndOdometer.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleFuelLogEndOdometer.Properties.Mask.EditMask = "n";
            this.fld_txtVMVehicleFuelLogEndOdometer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtVMVehicleFuelLogEndOdometer.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleFuelLogEndOdometer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleFuelLogEndOdometer.Screen = null;
            this.fld_txtVMVehicleFuelLogEndOdometer.Size = new System.Drawing.Size(125, 20);
            this.fld_txtVMVehicleFuelLogEndOdometer.TabIndex = 10;
            this.fld_txtVMVehicleFuelLogEndOdometer.Tag = "DC";
            this.fld_txtVMVehicleFuelLogEndOdometer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_txtVMVehicleFuelLogStartOdometer_KeyUp);
            // 
            // fld_txtVMVehicleFuelLogDistanceCovered
            // 
            this.fld_txtVMVehicleFuelLogDistanceCovered.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogDistanceCovered.BOSDataMember = "VMVehicleFuelLogDistanceCovered";
            this.fld_txtVMVehicleFuelLogDistanceCovered.BOSDataSource = "VMVehicleFuelLogs";
            this.fld_txtVMVehicleFuelLogDistanceCovered.BOSDescription = null;
            this.fld_txtVMVehicleFuelLogDistanceCovered.BOSError = null;
            this.fld_txtVMVehicleFuelLogDistanceCovered.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogDistanceCovered.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogDistanceCovered.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogDistanceCovered.BOSPropertyName = "Text";
            this.fld_txtVMVehicleFuelLogDistanceCovered.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogDistanceCovered.Location = new System.Drawing.Point(475, 87);
            this.fld_txtVMVehicleFuelLogDistanceCovered.Name = "fld_txtVMVehicleFuelLogDistanceCovered";
            this.fld_txtVMVehicleFuelLogDistanceCovered.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleFuelLogDistanceCovered.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleFuelLogDistanceCovered.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleFuelLogDistanceCovered.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleFuelLogDistanceCovered.Properties.Mask.EditMask = "n";
            this.fld_txtVMVehicleFuelLogDistanceCovered.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtVMVehicleFuelLogDistanceCovered.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleFuelLogDistanceCovered.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleFuelLogDistanceCovered.Screen = null;
            this.fld_txtVMVehicleFuelLogDistanceCovered.Size = new System.Drawing.Size(125, 20);
            this.fld_txtVMVehicleFuelLogDistanceCovered.TabIndex = 11;
            this.fld_txtVMVehicleFuelLogDistanceCovered.Tag = "DC";
            this.fld_txtVMVehicleFuelLogDistanceCovered.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_txtVMVehicleFuelLogDistanceCovered_KeyUp);
            // 
            // fld_txtVMVehicleFuelLogConsumption1
            // 
            this.fld_txtVMVehicleFuelLogConsumption1.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogConsumption1.BOSDataMember = "VMVehicleFuelLogConsumption1";
            this.fld_txtVMVehicleFuelLogConsumption1.BOSDataSource = "VMVehicleFuelLogs";
            this.fld_txtVMVehicleFuelLogConsumption1.BOSDescription = null;
            this.fld_txtVMVehicleFuelLogConsumption1.BOSError = null;
            this.fld_txtVMVehicleFuelLogConsumption1.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogConsumption1.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogConsumption1.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogConsumption1.BOSPropertyName = "Text";
            this.fld_txtVMVehicleFuelLogConsumption1.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogConsumption1.Enabled = false;
            this.fld_txtVMVehicleFuelLogConsumption1.Location = new System.Drawing.Point(132, 139);
            this.fld_txtVMVehicleFuelLogConsumption1.Name = "fld_txtVMVehicleFuelLogConsumption1";
            this.fld_txtVMVehicleFuelLogConsumption1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleFuelLogConsumption1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleFuelLogConsumption1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleFuelLogConsumption1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleFuelLogConsumption1.Properties.Mask.EditMask = "n";
            this.fld_txtVMVehicleFuelLogConsumption1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtVMVehicleFuelLogConsumption1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleFuelLogConsumption1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleFuelLogConsumption1.Screen = null;
            this.fld_txtVMVehicleFuelLogConsumption1.Size = new System.Drawing.Size(125, 20);
            this.fld_txtVMVehicleFuelLogConsumption1.TabIndex = 12;
            this.fld_txtVMVehicleFuelLogConsumption1.Tag = "DC";
            // 
            // fld_txtVMVehicleFuelLogConsumption2
            // 
            this.fld_txtVMVehicleFuelLogConsumption2.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogConsumption2.BOSDataMember = "VMVehicleFuelLogConsumption2";
            this.fld_txtVMVehicleFuelLogConsumption2.BOSDataSource = "VMVehicleFuelLogs";
            this.fld_txtVMVehicleFuelLogConsumption2.BOSDescription = null;
            this.fld_txtVMVehicleFuelLogConsumption2.BOSError = null;
            this.fld_txtVMVehicleFuelLogConsumption2.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogConsumption2.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogConsumption2.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogConsumption2.BOSPropertyName = "Text";
            this.fld_txtVMVehicleFuelLogConsumption2.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_txtVMVehicleFuelLogConsumption2.Enabled = false;
            this.fld_txtVMVehicleFuelLogConsumption2.Location = new System.Drawing.Point(475, 139);
            this.fld_txtVMVehicleFuelLogConsumption2.Name = "fld_txtVMVehicleFuelLogConsumption2";
            this.fld_txtVMVehicleFuelLogConsumption2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleFuelLogConsumption2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleFuelLogConsumption2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleFuelLogConsumption2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleFuelLogConsumption2.Properties.Mask.EditMask = "n";
            this.fld_txtVMVehicleFuelLogConsumption2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtVMVehicleFuelLogConsumption2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleFuelLogConsumption2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleFuelLogConsumption2.Screen = null;
            this.fld_txtVMVehicleFuelLogConsumption2.Size = new System.Drawing.Size(125, 20);
            this.fld_txtVMVehicleFuelLogConsumption2.TabIndex = 13;
            this.fld_txtVMVehicleFuelLogConsumption2.Tag = "DC";
            // 
            // fld_medVMVehicleFuelLogRemark
            // 
            this.fld_medVMVehicleFuelLogRemark.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_medVMVehicleFuelLogRemark.BOSDataMember = "VMVehicleFuelLogRemark";
            this.fld_medVMVehicleFuelLogRemark.BOSDataSource = "VMVehicleFuelLogs";
            this.fld_medVMVehicleFuelLogRemark.BOSDescription = null;
            this.fld_medVMVehicleFuelLogRemark.BOSError = null;
            this.fld_medVMVehicleFuelLogRemark.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_medVMVehicleFuelLogRemark.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_medVMVehicleFuelLogRemark.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_medVMVehicleFuelLogRemark.BOSPropertyName = "Text";
            this.fld_medVMVehicleFuelLogRemark.EditValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_medVMVehicleFuelLogRemark.Location = new System.Drawing.Point(132, 165);
            this.fld_medVMVehicleFuelLogRemark.Name = "fld_medVMVehicleFuelLogRemark";
            this.fld_medVMVehicleFuelLogRemark.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medVMVehicleFuelLogRemark.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medVMVehicleFuelLogRemark.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medVMVehicleFuelLogRemark.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medVMVehicleFuelLogRemark.Screen = null;
            this.fld_medVMVehicleFuelLogRemark.Size = new System.Drawing.Size(468, 34);
            this.fld_medVMVehicleFuelLogRemark.TabIndex = 14;
            this.fld_medVMVehicleFuelLogRemark.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Controls.Add(this.bosButton3);
            this.bosPanel1.Controls.Add(this.bosButton2);
            this.bosPanel1.Controls.Add(this.bosButton1);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 15;
            this.bosPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bosPanel1_Paint);
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_dgcVMVehicleFuelLogs);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 272);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(856, 292);
            this.bosGroupControl2.TabIndex = 17;
            this.bosGroupControl2.Text = "Danh sách sử dụng nhiên liệu";
            // 
            // fld_dgcVMVehicleFuelLogs
            // 
            this.fld_dgcVMVehicleFuelLogs.BOSComment = null;
            this.fld_dgcVMVehicleFuelLogs.BOSDataMember = null;
            this.fld_dgcVMVehicleFuelLogs.BOSDataSource = "VMVehicleFuelLogs";
            this.fld_dgcVMVehicleFuelLogs.BOSDescription = null;
            this.fld_dgcVMVehicleFuelLogs.BOSError = null;
            this.fld_dgcVMVehicleFuelLogs.BOSFieldGroup = null;
            this.fld_dgcVMVehicleFuelLogs.BOSFieldRelation = null;
            this.fld_dgcVMVehicleFuelLogs.BOSGridType = null;
            this.fld_dgcVMVehicleFuelLogs.BOSPrivilege = null;
            this.fld_dgcVMVehicleFuelLogs.BOSPropertyName = null;
            this.fld_dgcVMVehicleFuelLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcVMVehicleFuelLogs.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcVMVehicleFuelLogs.MenuManager = this.screenToolbar;
            this.fld_dgcVMVehicleFuelLogs.Name = "fld_dgcVMVehicleFuelLogs";
            this.fld_dgcVMVehicleFuelLogs.PrintReport = false;
            this.fld_dgcVMVehicleFuelLogs.Screen = null;
            this.fld_dgcVMVehicleFuelLogs.Size = new System.Drawing.Size(852, 268);
            this.fld_dgcVMVehicleFuelLogs.TabIndex = 0;
            // 
            // bosButton3
            // 
            this.bosButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton3.BOSComment = null;
            this.bosButton3.BOSDataMember = null;
            this.bosButton3.BOSDataSource = null;
            this.bosButton3.BOSDescription = null;
            this.bosButton3.BOSError = null;
            this.bosButton3.BOSFieldGroup = null;
            this.bosButton3.BOSFieldRelation = null;
            this.bosButton3.BOSPrivilege = null;
            this.bosButton3.BOSPropertyName = null;
            this.bosButton3.Location = new System.Drawing.Point(755, 237);
            this.bosButton3.Name = "bosButton3";
            this.bosButton3.Screen = null;
            this.bosButton3.Size = new System.Drawing.Size(75, 27);
            this.bosButton3.TabIndex = 16;
            this.bosButton3.Text = "Xóa";
            this.bosButton3.Click += new System.EventHandler(this.bosButton3_Click);
            // 
            // bosButton2
            // 
            this.bosButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton2.BOSComment = null;
            this.bosButton2.BOSDataMember = null;
            this.bosButton2.BOSDataSource = null;
            this.bosButton2.BOSDescription = null;
            this.bosButton2.BOSError = null;
            this.bosButton2.BOSFieldGroup = null;
            this.bosButton2.BOSFieldRelation = null;
            this.bosButton2.BOSPrivilege = null;
            this.bosButton2.BOSPropertyName = null;
            this.bosButton2.Location = new System.Drawing.Point(674, 237);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.bosButton2.Size = new System.Drawing.Size(75, 27);
            this.bosButton2.TabIndex = 16;
            this.bosButton2.Text = "Sửa";
            this.bosButton2.Click += new System.EventHandler(this.bosButton2_Click);
            // 
            // bosButton1
            // 
            this.bosButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.Location = new System.Drawing.Point(593, 237);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(75, 27);
            this.bosButton1.TabIndex = 16;
            this.bosButton1.Text = "Thêm";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_dteVMVehiclePurchaseDate);
            this.bosGroupControl1.Controls.Add(this.bosLabel9);
            this.bosGroupControl1.Controls.Add(this.bosLabel10);
            this.bosGroupControl1.Controls.Add(this.bosLabel8);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.bosLabel7);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_txtVMVehicleFuelLogStartOdometer);
            this.bosGroupControl1.Controls.Add(this.fld_txtVMVehicleFuelLogCost);
            this.bosGroupControl1.Controls.Add(this.fld_medVMVehicleFuelLogRemark);
            this.bosGroupControl1.Controls.Add(this.fld_txtVMVehicleFuelLogEndOdometer);
            this.bosGroupControl1.Controls.Add(this.fld_txtVMVehicleFuelLogConsumption2);
            this.bosGroupControl1.Controls.Add(this.fld_txtVMVehicleFuelLogQty);
            this.bosGroupControl1.Controls.Add(this.fld_txtVMVehicleFuelLogTotalCost);
            this.bosGroupControl1.Controls.Add(this.fld_txtVMVehicleFuelLogDistanceCovered);
            this.bosGroupControl1.Controls.Add(this.fld_txtVMVehicleFuelLogConsumption1);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 12);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(856, 216);
            this.bosGroupControl1.TabIndex = 15;
            this.bosGroupControl1.Text = "Thông tin chung";
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
            this.bosLabel9.Location = new System.Drawing.Point(363, 142);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(96, 13);
            this.bosLabel9.TabIndex = 15;
            this.bosLabel9.Text = "Tiêu hao (lít/100Km)";
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
            this.bosLabel10.Location = new System.Drawing.Point(20, 168);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(35, 13);
            this.bosLabel10.TabIndex = 15;
            this.bosLabel10.Text = "Ghi chú";
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
            this.bosLabel8.Location = new System.Drawing.Point(20, 142);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(72, 13);
            this.bosLabel8.TabIndex = 15;
            this.bosLabel8.Text = "Tiêu hao (Km/l)";
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
            this.bosLabel6.Location = new System.Drawing.Point(363, 116);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(70, 13);
            this.bosLabel6.TabIndex = 15;
            this.bosLabel6.Text = "Số km kết thúc";
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
            this.bosLabel4.Location = new System.Drawing.Point(20, 90);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(51, 13);
            this.bosLabel4.TabIndex = 15;
            this.bosLabel4.Text = "Thành tiền";
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
            this.bosLabel2.Location = new System.Drawing.Point(20, 64);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(61, 13);
            this.bosLabel2.TabIndex = 15;
            this.bosLabel2.Text = "Số lượng (lít)";
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
            this.bosLabel7.Location = new System.Drawing.Point(363, 90);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(104, 13);
            this.bosLabel7.TabIndex = 15;
            this.bosLabel7.Text = "Quãng đường đi được";
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
            this.bosLabel5.Location = new System.Drawing.Point(20, 116);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(68, 13);
            this.bosLabel5.TabIndex = 15;
            this.bosLabel5.Text = "Số km bắt đầu";
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
            this.bosLabel3.Location = new System.Drawing.Point(363, 64);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(37, 13);
            this.bosLabel3.TabIndex = 15;
            this.bosLabel3.Text = "Đơn giá";
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
            this.bosLabel1.Location = new System.Drawing.Point(20, 38);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(94, 13);
            this.bosLabel1.TabIndex = 15;
            this.bosLabel1.Text = "Ngày tiếp nhiên liệu";
            // 
            // fld_dteVMVehiclePurchaseDate
            // 
            this.fld_dteVMVehiclePurchaseDate.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteVMVehiclePurchaseDate.BOSDataMember = "VMVehicleFuelLogDate";
            this.fld_dteVMVehiclePurchaseDate.BOSDataSource = "VMVehicleFuelLogs";
            this.fld_dteVMVehiclePurchaseDate.BOSDescription = null;
            this.fld_dteVMVehiclePurchaseDate.BOSError = null;
            this.fld_dteVMVehiclePurchaseDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteVMVehiclePurchaseDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteVMVehiclePurchaseDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dteVMVehiclePurchaseDate.BOSPropertyName = "EditValue";
            this.fld_dteVMVehiclePurchaseDate.EditValue = null;
            this.fld_dteVMVehiclePurchaseDate.Location = new System.Drawing.Point(132, 35);
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
            this.fld_dteVMVehiclePurchaseDate.Size = new System.Drawing.Size(125, 20);
            this.fld_dteVMVehiclePurchaseDate.TabIndex = 16;
            this.fld_dteVMVehiclePurchaseDate.Tag = "DC";
            // 
            // DMVM101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMVM101";
            this.Text = "Lịch sử sử dụng nhiên liệu";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleFuelLogQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleFuelLogCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleFuelLogTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleFuelLogStartOdometer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleFuelLogEndOdometer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleFuelLogDistanceCovered.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleFuelLogConsumption1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleFuelLogConsumption2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medVMVehicleFuelLogRemark.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcVMVehicleFuelLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehiclePurchaseDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteVMVehiclePurchaseDate.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSButton bosButton3;
        private BOSComponent.BOSButton bosButton2;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSLabel bosLabel10;
        private VehicleFuelLogsGridControl fld_dgcVMVehicleFuelLogs;
        private BOSComponent.BOSDateEdit fld_dteVMVehiclePurchaseDate;
	}
}
