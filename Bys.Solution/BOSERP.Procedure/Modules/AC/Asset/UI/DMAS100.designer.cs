using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Asset.UI
{
	/// <summary>
	/// Summary description for DMAS100
	/// </summary>
	partial class DMAS100
	{
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSLabel fld_lblLabel7;
		private BOSComponent.BOSLabel fld_lblLabel12;
		private BOSComponent.BOSLabel fld_lblLabel13;
		private BOSComponent.BOSLabel fld_lblLabel14;
		private BOSComponent.BOSLabel fld_lblLabel15;
		private BOSComponent.BOSLabel fld_lblLabel16;
		private BOSComponent.BOSTextBox fld_txtACAssetNo1;
		private BOSComponent.BOSTextBox fld_txtACAssetName1;
		private BOSComponent.BOSDateEdit fld_dteACAssetPurchasedDate;
		private BOSComponent.BOSDateEdit fld_dteACAssetUsedDate;
        private BOSComponent.BOSTextBox fld_txtACAssetExpiryMonths;
		private BOSComponent.BOSTextBox fld_txtACAssetDepreciatedAmount;
		private BOSComponent.BOSTextBox fld_txtACAssetOriginalAmount;
		private BOSComponent.BOSTextBox fld_txtACAssetRemainedAmount;
		private BOSComponent.BOSTextBox fld_txtACAssetDepreciationPercent;
        private BOSComponent.BOSTextBox fld_txtACAssetDepreciationAmount;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMAS100));
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACAssetNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACAssetName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteACAssetPurchasedDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteACAssetUsedDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtACAssetExpiryMonths = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACAssetDepreciatedAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACAssetOriginalAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACAssetRemainedAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACAssetDepreciationPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACAssetDepreciationAmount = new BOSComponent.BOSTextBox(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_ckACAssetIsInventory = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACSegmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACAssetTypeAccountConfigID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel23 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACCostCenterID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit6 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit5 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACDepreciationCostAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICMeasureUnitID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit4 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit3 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentRoomID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACAssetType1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeACAssetStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medACAssetComment = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteACAssetDepreciationDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_ACUnfinishedConstructionCostID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACAssetDepreciationMethod = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACAssetInitDepreciatedAmount = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACAssetInitQty = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACAssetCost = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetPurchasedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetPurchasedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetUsedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetUsedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetExpiryMonths.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetDepreciatedAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetOriginalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetRemainedAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetDepreciationPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetDepreciationAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckACAssetIsInventory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssetTypeAccountConfigID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACCostCenterID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACDepreciationCostAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICMeasureUnitID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAssetType1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAssetStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACAssetComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetDepreciationDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetDepreciationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACUnfinishedConstructionCostID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAssetDepreciationMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetInitDepreciatedAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetInitQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetCost.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = "";
            this.fld_lblLabel3.BOSDataMember = "";
            this.fld_lblLabel3.BOSDataSource = "";
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = "";
            this.fld_lblLabel3.BOSFieldRelation = "";
            this.fld_lblLabel3.BOSPrivilege = "";
            this.fld_lblLabel3.BOSPropertyName = "";
            this.fld_lblLabel3.Location = new System.Drawing.Point(15, 33);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel3.TabIndex = 0;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Mã tài sản";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "";
            this.fld_lblLabel4.BOSDataMember = "";
            this.fld_lblLabel4.BOSDataSource = "";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "";
            this.fld_lblLabel4.BOSFieldRelation = "";
            this.fld_lblLabel4.BOSPrivilege = "";
            this.fld_lblLabel4.BOSPropertyName = "";
            this.fld_lblLabel4.Location = new System.Drawing.Point(15, 59);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(53, 13);
            this.fld_lblLabel4.TabIndex = 6;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Tên tài sản";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = "";
            this.fld_lblLabel5.BOSDataMember = "";
            this.fld_lblLabel5.BOSDataSource = "";
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = "";
            this.fld_lblLabel5.BOSFieldRelation = "";
            this.fld_lblLabel5.BOSPrivilege = "";
            this.fld_lblLabel5.BOSPropertyName = "";
            this.fld_lblLabel5.Location = new System.Drawing.Point(15, 85);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 10;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Ngày mua";
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = "";
            this.fld_lblLabel6.BOSDataMember = "";
            this.fld_lblLabel6.BOSDataSource = "";
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = "";
            this.fld_lblLabel6.BOSFieldRelation = "";
            this.fld_lblLabel6.BOSPrivilege = "";
            this.fld_lblLabel6.BOSPropertyName = "";
            this.fld_lblLabel6.Location = new System.Drawing.Point(275, 85);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel6.TabIndex = 12;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Ngày sử dụng";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = "";
            this.fld_lblLabel7.BOSDataMember = "";
            this.fld_lblLabel7.BOSDataSource = "";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "";
            this.fld_lblLabel7.BOSFieldRelation = "";
            this.fld_lblLabel7.BOSPrivilege = "";
            this.fld_lblLabel7.BOSPropertyName = "";
            this.fld_lblLabel7.Location = new System.Drawing.Point(319, 61);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(111, 13);
            this.fld_lblLabel7.TabIndex = 8;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Phương pháp khấu hao";
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = "";
            this.fld_lblLabel12.BOSDataMember = "";
            this.fld_lblLabel12.BOSDataSource = "";
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = "";
            this.fld_lblLabel12.BOSFieldRelation = "";
            this.fld_lblLabel12.BOSPrivilege = "";
            this.fld_lblLabel12.BOSPropertyName = "";
            this.fld_lblLabel12.Location = new System.Drawing.Point(319, 35);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(54, 13);
            this.fld_lblLabel12.TabIndex = 4;
            this.fld_lblLabel12.Tag = "";
            this.fld_lblLabel12.Text = "Nguyên giá";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = "";
            this.fld_lblLabel13.BOSDataMember = "";
            this.fld_lblLabel13.BOSDataSource = "";
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = "";
            this.fld_lblLabel13.BOSFieldRelation = "";
            this.fld_lblLabel13.BOSPrivilege = "";
            this.fld_lblLabel13.BOSPropertyName = "";
            this.fld_lblLabel13.Location = new System.Drawing.Point(15, 138);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(58, 13);
            this.fld_lblLabel13.TabIndex = 14;
            this.fld_lblLabel13.Tag = "";
            this.fld_lblLabel13.Text = "% khấu hao";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = "";
            this.fld_lblLabel14.BOSDataMember = "";
            this.fld_lblLabel14.BOSDataSource = "";
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = "";
            this.fld_lblLabel14.BOSFieldRelation = "";
            this.fld_lblLabel14.BOSPrivilege = "";
            this.fld_lblLabel14.BOSPropertyName = "";
            this.fld_lblLabel14.Location = new System.Drawing.Point(319, 85);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(75, 13);
            this.fld_lblLabel14.TabIndex = 12;
            this.fld_lblLabel14.Tag = "";
            this.fld_lblLabel14.Text = "Giá trị khấu hao";
            // 
            // fld_lblLabel15
            // 
            this.fld_lblLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel15.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel15.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel15.BOSComment = "";
            this.fld_lblLabel15.BOSDataMember = "";
            this.fld_lblLabel15.BOSDataSource = "";
            this.fld_lblLabel15.BOSDescription = null;
            this.fld_lblLabel15.BOSError = null;
            this.fld_lblLabel15.BOSFieldGroup = "";
            this.fld_lblLabel15.BOSFieldRelation = "";
            this.fld_lblLabel15.BOSPrivilege = "";
            this.fld_lblLabel15.BOSPropertyName = "";
            this.fld_lblLabel15.Location = new System.Drawing.Point(319, 164);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.fld_lblLabel15.Size = new System.Drawing.Size(73, 13);
            this.fld_lblLabel15.TabIndex = 26;
            this.fld_lblLabel15.Tag = "";
            this.fld_lblLabel15.Text = "Hao mòn lũy kế";
            // 
            // fld_lblLabel16
            // 
            this.fld_lblLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel16.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel16.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel16.BOSComment = "";
            this.fld_lblLabel16.BOSDataMember = "";
            this.fld_lblLabel16.BOSDataSource = "";
            this.fld_lblLabel16.BOSDescription = null;
            this.fld_lblLabel16.BOSError = null;
            this.fld_lblLabel16.BOSFieldGroup = "";
            this.fld_lblLabel16.BOSFieldRelation = "";
            this.fld_lblLabel16.BOSPrivilege = "";
            this.fld_lblLabel16.BOSPropertyName = "";
            this.fld_lblLabel16.Location = new System.Drawing.Point(319, 136);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.fld_lblLabel16.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel16.TabIndex = 20;
            this.fld_lblLabel16.Tag = "";
            this.fld_lblLabel16.Text = "Giá trị còn lại";
            // 
            // fld_txtACAssetNo1
            // 
            this.fld_txtACAssetNo1.BOSComment = "";
            this.fld_txtACAssetNo1.BOSDataMember = "ACAssetNo";
            this.fld_txtACAssetNo1.BOSDataSource = "ACAssets";
            this.fld_txtACAssetNo1.BOSDescription = null;
            this.fld_txtACAssetNo1.BOSError = null;
            this.fld_txtACAssetNo1.BOSFieldGroup = "";
            this.fld_txtACAssetNo1.BOSFieldRelation = "";
            this.fld_txtACAssetNo1.BOSPrivilege = "";
            this.fld_txtACAssetNo1.BOSPropertyName = "Text";
            this.fld_txtACAssetNo1.EditValue = "";
            this.fld_txtACAssetNo1.Location = new System.Drawing.Point(99, 30);
            this.fld_txtACAssetNo1.Name = "fld_txtACAssetNo1";
            this.fld_txtACAssetNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACAssetNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetNo1.Screen = null;
            this.fld_txtACAssetNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACAssetNo1.TabIndex = 0;
            this.fld_txtACAssetNo1.Tag = "DC";
            // 
            // fld_txtACAssetName1
            // 
            this.fld_txtACAssetName1.BOSComment = "";
            this.fld_txtACAssetName1.BOSDataMember = "ACAssetName";
            this.fld_txtACAssetName1.BOSDataSource = "ACAssets";
            this.fld_txtACAssetName1.BOSDescription = null;
            this.fld_txtACAssetName1.BOSError = null;
            this.fld_txtACAssetName1.BOSFieldGroup = "";
            this.fld_txtACAssetName1.BOSFieldRelation = "";
            this.fld_txtACAssetName1.BOSPrivilege = "";
            this.fld_txtACAssetName1.BOSPropertyName = "Text";
            this.fld_txtACAssetName1.EditValue = "";
            this.fld_txtACAssetName1.Location = new System.Drawing.Point(99, 56);
            this.fld_txtACAssetName1.Name = "fld_txtACAssetName1";
            this.fld_txtACAssetName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACAssetName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetName1.Screen = null;
            this.fld_txtACAssetName1.Size = new System.Drawing.Size(414, 20);
            this.fld_txtACAssetName1.TabIndex = 2;
            this.fld_txtACAssetName1.Tag = "DC";
            // 
            // fld_dteACAssetPurchasedDate
            // 
            this.fld_dteACAssetPurchasedDate.BOSComment = "";
            this.fld_dteACAssetPurchasedDate.BOSDataMember = "ACAssetPurchasedDate";
            this.fld_dteACAssetPurchasedDate.BOSDataSource = "ACAssets";
            this.fld_dteACAssetPurchasedDate.BOSDescription = null;
            this.fld_dteACAssetPurchasedDate.BOSError = null;
            this.fld_dteACAssetPurchasedDate.BOSFieldGroup = "";
            this.fld_dteACAssetPurchasedDate.BOSFieldRelation = "";
            this.fld_dteACAssetPurchasedDate.BOSPrivilege = "";
            this.fld_dteACAssetPurchasedDate.BOSPropertyName = "EditValue";
            this.fld_dteACAssetPurchasedDate.EditValue = null;
            this.fld_dteACAssetPurchasedDate.Location = new System.Drawing.Point(99, 82);
            this.fld_dteACAssetPurchasedDate.Name = "fld_dteACAssetPurchasedDate";
            this.fld_dteACAssetPurchasedDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACAssetPurchasedDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACAssetPurchasedDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACAssetPurchasedDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACAssetPurchasedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACAssetPurchasedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACAssetPurchasedDate.Screen = null;
            this.fld_dteACAssetPurchasedDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACAssetPurchasedDate.TabIndex = 3;
            this.fld_dteACAssetPurchasedDate.Tag = "DC";
            // 
            // fld_dteACAssetUsedDate
            // 
            this.fld_dteACAssetUsedDate.BOSComment = "";
            this.fld_dteACAssetUsedDate.BOSDataMember = "ACAssetUsedDate";
            this.fld_dteACAssetUsedDate.BOSDataSource = "ACAssets";
            this.fld_dteACAssetUsedDate.BOSDescription = null;
            this.fld_dteACAssetUsedDate.BOSError = null;
            this.fld_dteACAssetUsedDate.BOSFieldGroup = "";
            this.fld_dteACAssetUsedDate.BOSFieldRelation = "";
            this.fld_dteACAssetUsedDate.BOSPrivilege = "";
            this.fld_dteACAssetUsedDate.BOSPropertyName = "EditValue";
            this.fld_dteACAssetUsedDate.EditValue = null;
            this.fld_dteACAssetUsedDate.Location = new System.Drawing.Point(363, 82);
            this.fld_dteACAssetUsedDate.Name = "fld_dteACAssetUsedDate";
            this.fld_dteACAssetUsedDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACAssetUsedDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACAssetUsedDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACAssetUsedDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACAssetUsedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACAssetUsedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACAssetUsedDate.Screen = null;
            this.fld_dteACAssetUsedDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACAssetUsedDate.TabIndex = 4;
            this.fld_dteACAssetUsedDate.Tag = "DC";
            // 
            // fld_txtACAssetExpiryMonths
            // 
            this.fld_txtACAssetExpiryMonths.BOSComment = "";
            this.fld_txtACAssetExpiryMonths.BOSDataMember = "ACAssetExpiryMonths";
            this.fld_txtACAssetExpiryMonths.BOSDataSource = "ACAssets";
            this.fld_txtACAssetExpiryMonths.BOSDescription = null;
            this.fld_txtACAssetExpiryMonths.BOSError = null;
            this.fld_txtACAssetExpiryMonths.BOSFieldGroup = "";
            this.fld_txtACAssetExpiryMonths.BOSFieldRelation = "";
            this.fld_txtACAssetExpiryMonths.BOSPrivilege = "";
            this.fld_txtACAssetExpiryMonths.BOSPropertyName = "Text";
            this.fld_txtACAssetExpiryMonths.EditValue = "";
            this.fld_txtACAssetExpiryMonths.Location = new System.Drawing.Point(132, 83);
            this.fld_txtACAssetExpiryMonths.Name = "fld_txtACAssetExpiryMonths";
            this.fld_txtACAssetExpiryMonths.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACAssetExpiryMonths.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetExpiryMonths.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetExpiryMonths.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetExpiryMonths.Properties.Mask.EditMask = "n0";
            this.fld_txtACAssetExpiryMonths.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACAssetExpiryMonths.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetExpiryMonths.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetExpiryMonths.Screen = null;
            this.fld_txtACAssetExpiryMonths.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACAssetExpiryMonths.TabIndex = 2;
            this.fld_txtACAssetExpiryMonths.Tag = "DC";
            this.fld_txtACAssetExpiryMonths.Validated += new System.EventHandler(this.fld_txtACAssetExpiryMonths_Validated);
            // 
            // fld_txtACAssetDepreciatedAmount
            // 
            this.fld_txtACAssetDepreciatedAmount.BOSComment = "";
            this.fld_txtACAssetDepreciatedAmount.BOSDataMember = "ACAssetDepreciatedAmount";
            this.fld_txtACAssetDepreciatedAmount.BOSDataSource = "ACAssets";
            this.fld_txtACAssetDepreciatedAmount.BOSDescription = null;
            this.fld_txtACAssetDepreciatedAmount.BOSError = null;
            this.fld_txtACAssetDepreciatedAmount.BOSFieldGroup = "";
            this.fld_txtACAssetDepreciatedAmount.BOSFieldRelation = "";
            this.fld_txtACAssetDepreciatedAmount.BOSPrivilege = "";
            this.fld_txtACAssetDepreciatedAmount.BOSPropertyName = "Text";
            this.fld_txtACAssetDepreciatedAmount.EditValue = "";
            this.fld_txtACAssetDepreciatedAmount.Location = new System.Drawing.Point(456, 161);
            this.fld_txtACAssetDepreciatedAmount.Name = "fld_txtACAssetDepreciatedAmount";
            this.fld_txtACAssetDepreciatedAmount.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtACAssetDepreciatedAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetDepreciatedAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetDepreciatedAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetDepreciatedAmount.Properties.Mask.EditMask = "n";
            this.fld_txtACAssetDepreciatedAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACAssetDepreciatedAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetDepreciatedAmount.Properties.ReadOnly = true;
            this.fld_txtACAssetDepreciatedAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetDepreciatedAmount.Screen = null;
            this.fld_txtACAssetDepreciatedAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACAssetDepreciatedAmount.TabIndex = 11;
            this.fld_txtACAssetDepreciatedAmount.Tag = "DC";
            // 
            // fld_txtACAssetOriginalAmount
            // 
            this.fld_txtACAssetOriginalAmount.BOSComment = "";
            this.fld_txtACAssetOriginalAmount.BOSDataMember = "ACAssetOriginalAmount";
            this.fld_txtACAssetOriginalAmount.BOSDataSource = "ACAssets";
            this.fld_txtACAssetOriginalAmount.BOSDescription = null;
            this.fld_txtACAssetOriginalAmount.BOSError = null;
            this.fld_txtACAssetOriginalAmount.BOSFieldGroup = "";
            this.fld_txtACAssetOriginalAmount.BOSFieldRelation = "";
            this.fld_txtACAssetOriginalAmount.BOSPrivilege = "";
            this.fld_txtACAssetOriginalAmount.BOSPropertyName = "Text";
            this.fld_txtACAssetOriginalAmount.EditValue = "";
            this.fld_txtACAssetOriginalAmount.Location = new System.Drawing.Point(456, 32);
            this.fld_txtACAssetOriginalAmount.Name = "fld_txtACAssetOriginalAmount";
            this.fld_txtACAssetOriginalAmount.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtACAssetOriginalAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetOriginalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetOriginalAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetOriginalAmount.Properties.Mask.EditMask = "n";
            this.fld_txtACAssetOriginalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACAssetOriginalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetOriginalAmount.Properties.ReadOnly = true;
            this.fld_txtACAssetOriginalAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetOriginalAmount.Screen = null;
            this.fld_txtACAssetOriginalAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACAssetOriginalAmount.TabIndex = 6;
            this.fld_txtACAssetOriginalAmount.Tag = "DC";
            // 
            // fld_txtACAssetRemainedAmount
            // 
            this.fld_txtACAssetRemainedAmount.BOSComment = "";
            this.fld_txtACAssetRemainedAmount.BOSDataMember = "ACAssetRemainedAmount";
            this.fld_txtACAssetRemainedAmount.BOSDataSource = "ACAssets";
            this.fld_txtACAssetRemainedAmount.BOSDescription = null;
            this.fld_txtACAssetRemainedAmount.BOSError = null;
            this.fld_txtACAssetRemainedAmount.BOSFieldGroup = "";
            this.fld_txtACAssetRemainedAmount.BOSFieldRelation = "";
            this.fld_txtACAssetRemainedAmount.BOSPrivilege = "";
            this.fld_txtACAssetRemainedAmount.BOSPropertyName = "Text";
            this.fld_txtACAssetRemainedAmount.EditValue = "";
            this.fld_txtACAssetRemainedAmount.Location = new System.Drawing.Point(456, 135);
            this.fld_txtACAssetRemainedAmount.Name = "fld_txtACAssetRemainedAmount";
            this.fld_txtACAssetRemainedAmount.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtACAssetRemainedAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetRemainedAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetRemainedAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetRemainedAmount.Properties.Mask.EditMask = "n";
            this.fld_txtACAssetRemainedAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACAssetRemainedAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetRemainedAmount.Properties.ReadOnly = true;
            this.fld_txtACAssetRemainedAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetRemainedAmount.Screen = null;
            this.fld_txtACAssetRemainedAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACAssetRemainedAmount.TabIndex = 10;
            this.fld_txtACAssetRemainedAmount.Tag = "DC";
            // 
            // fld_txtACAssetDepreciationPercent
            // 
            this.fld_txtACAssetDepreciationPercent.BOSComment = "";
            this.fld_txtACAssetDepreciationPercent.BOSDataMember = "ACAssetDepreciationPercent";
            this.fld_txtACAssetDepreciationPercent.BOSDataSource = "ACAssets";
            this.fld_txtACAssetDepreciationPercent.BOSDescription = null;
            this.fld_txtACAssetDepreciationPercent.BOSError = null;
            this.fld_txtACAssetDepreciationPercent.BOSFieldGroup = "";
            this.fld_txtACAssetDepreciationPercent.BOSFieldRelation = "";
            this.fld_txtACAssetDepreciationPercent.BOSPrivilege = "";
            this.fld_txtACAssetDepreciationPercent.BOSPropertyName = "Text";
            this.fld_txtACAssetDepreciationPercent.EditValue = "";
            this.fld_txtACAssetDepreciationPercent.Location = new System.Drawing.Point(132, 135);
            this.fld_txtACAssetDepreciationPercent.Name = "fld_txtACAssetDepreciationPercent";
            this.fld_txtACAssetDepreciationPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACAssetDepreciationPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetDepreciationPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetDepreciationPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetDepreciationPercent.Properties.Mask.EditMask = "n";
            this.fld_txtACAssetDepreciationPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACAssetDepreciationPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetDepreciationPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetDepreciationPercent.Screen = null;
            this.fld_txtACAssetDepreciationPercent.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACAssetDepreciationPercent.TabIndex = 4;
            this.fld_txtACAssetDepreciationPercent.Tag = "DC";
            this.fld_txtACAssetDepreciationPercent.Validated += new System.EventHandler(this.fld_txtACAssetDepreciationPercent_Validated);
            // 
            // fld_txtACAssetDepreciationAmount
            // 
            this.fld_txtACAssetDepreciationAmount.BOSComment = "";
            this.fld_txtACAssetDepreciationAmount.BOSDataMember = "ACAssetDepreciationAmount";
            this.fld_txtACAssetDepreciationAmount.BOSDataSource = "ACAssets";
            this.fld_txtACAssetDepreciationAmount.BOSDescription = null;
            this.fld_txtACAssetDepreciationAmount.BOSError = null;
            this.fld_txtACAssetDepreciationAmount.BOSFieldGroup = "";
            this.fld_txtACAssetDepreciationAmount.BOSFieldRelation = "";
            this.fld_txtACAssetDepreciationAmount.BOSPrivilege = "";
            this.fld_txtACAssetDepreciationAmount.BOSPropertyName = "Text";
            this.fld_txtACAssetDepreciationAmount.EditValue = "";
            this.fld_txtACAssetDepreciationAmount.Location = new System.Drawing.Point(456, 83);
            this.fld_txtACAssetDepreciationAmount.Name = "fld_txtACAssetDepreciationAmount";
            this.fld_txtACAssetDepreciationAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACAssetDepreciationAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetDepreciationAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetDepreciationAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetDepreciationAmount.Properties.Mask.EditMask = "n";
            this.fld_txtACAssetDepreciationAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACAssetDepreciationAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetDepreciationAmount.Properties.ReadOnly = true;
            this.fld_txtACAssetDepreciationAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetDepreciationAmount.Screen = null;
            this.fld_txtACAssetDepreciationAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACAssetDepreciationAmount.TabIndex = 8;
            this.fld_txtACAssetDepreciationAmount.Tag = "DC";
            this.fld_txtACAssetDepreciationAmount.Validated += new System.EventHandler(this.fld_txtACAssetDepreciationAmount_Validated);
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_ckACAssetIsInventory);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ICProductID);
            this.bosGroupControl1.Controls.Add(this.bosLabel25);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACSegmentID);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAssetTypeAccountConfigID);
            this.bosGroupControl1.Controls.Add(this.bosLabel23);
            this.bosGroupControl1.Controls.Add(this.bosLabel24);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACCostCenterID);
            this.bosGroupControl1.Controls.Add(this.bosLabel22);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit6);
            this.bosGroupControl1.Controls.Add(this.bosLabel19);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit5);
            this.bosGroupControl1.Controls.Add(this.bosLabel18);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACDepreciationCostAccountID);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit1);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountID);
            this.bosGroupControl1.Controls.Add(this.bosLabel8);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ICMeasureUnitID);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit4);
            this.bosGroupControl1.Controls.Add(this.bosLabel17);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit3);
            this.bosGroupControl1.Controls.Add(this.bosLabel16);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit2);
            this.bosGroupControl1.Controls.Add(this.bosLabel15);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID1);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.fld_lkeACAssetType1);
            this.bosGroupControl1.Controls.Add(this.fld_lkeACAssetStatus);
            this.bosGroupControl1.Controls.Add(this.fld_medACAssetComment);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_txtACAssetNo1);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel4);
            this.bosGroupControl1.Controls.Add(this.bosLabel10);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.bosLabel13);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel5);
            this.bosGroupControl1.Controls.Add(this.bosLabel12);
            this.bosGroupControl1.Controls.Add(this.fld_dteACAssetUsedDate);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel6);
            this.bosGroupControl1.Controls.Add(this.fld_dteACAssetPurchasedDate);
            this.bosGroupControl1.Controls.Add(this.fld_txtACAssetName1);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 4);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(890, 251);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin chung";
            // 
            // fld_ckACAssetIsInventory
            // 
            this.fld_ckACAssetIsInventory.BOSComment = "";
            this.fld_ckACAssetIsInventory.BOSDataMember = "ACAssetIsInventory";
            this.fld_ckACAssetIsInventory.BOSDataSource = "ACAssets";
            this.fld_ckACAssetIsInventory.BOSDescription = null;
            this.fld_ckACAssetIsInventory.BOSError = "";
            this.fld_ckACAssetIsInventory.BOSFieldGroup = "";
            this.fld_ckACAssetIsInventory.BOSFieldRelation = "";
            this.fld_ckACAssetIsInventory.BOSPrivilege = "";
            this.fld_ckACAssetIsInventory.BOSPropertyName = "EditValue";
            this.fld_ckACAssetIsInventory.Location = new System.Drawing.Point(647, 214);
            this.fld_ckACAssetIsInventory.Name = "fld_ckACAssetIsInventory";
            this.fld_ckACAssetIsInventory.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_ckACAssetIsInventory.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_ckACAssetIsInventory.Properties.Appearance.Options.UseBackColor = true;
            this.fld_ckACAssetIsInventory.Properties.Appearance.Options.UseForeColor = true;
            this.fld_ckACAssetIsInventory.Properties.Caption = "Kiểm kê";
            this.fld_ckACAssetIsInventory.Screen = null;
            this.fld_ckACAssetIsInventory.Size = new System.Drawing.Size(150, 20);
            this.fld_ckACAssetIsInventory.TabIndex = 21;
            this.fld_ckACAssetIsInventory.TabStop = false;
            this.fld_ckACAssetIsInventory.Tag = "DC";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductID.BOSComment = null;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ACAssets";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "ICProductType";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "MMTB";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(363, 188);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.fld_lkeFK_ICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã SP"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID.Properties.NullText = "";
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductID, true);
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 12;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.Options.UseBackColor = true;
            this.bosLabel25.Appearance.Options.UseForeColor = true;
            this.bosLabel25.BOSComment = "";
            this.bosLabel25.BOSDataMember = "";
            this.bosLabel25.BOSDataSource = "";
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = "";
            this.bosLabel25.BOSFieldRelation = "";
            this.bosLabel25.BOSPrivilege = "";
            this.bosLabel25.BOSPropertyName = "";
            this.bosLabel25.Location = new System.Drawing.Point(275, 191);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(50, 13);
            this.bosLabel25.TabIndex = 47;
            this.bosLabel25.Tag = "";
            this.bosLabel25.Text = "Nhóm máy";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = "";
            this.bosLabel6.BOSDataMember = "";
            this.bosLabel6.BOSDataSource = "";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "";
            this.bosLabel6.BOSFieldRelation = "";
            this.bosLabel6.BOSPrivilege = "";
            this.bosLabel6.BOSPropertyName = "";
            this.bosLabel6.Location = new System.Drawing.Point(555, 137);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(12, 13);
            this.bosLabel6.TabIndex = 45;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Tổ";
            // 
            // fld_lkeFK_ACSegmentID
            // 
            this.fld_lkeFK_ACSegmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACSegmentID.BOSAllowDummy = true;
            this.fld_lkeFK_ACSegmentID.BOSComment = null;
            this.fld_lkeFK_ACSegmentID.BOSDataMember = "FK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.BOSDataSource = "ACAssets";
            this.fld_lkeFK_ACSegmentID.BOSDescription = null;
            this.fld_lkeFK_ACSegmentID.BOSError = null;
            this.fld_lkeFK_ACSegmentID.BOSFieldGroup = null;
            this.fld_lkeFK_ACSegmentID.BOSFieldParent = null;
            this.fld_lkeFK_ACSegmentID.BOSFieldRelation = null;
            this.fld_lkeFK_ACSegmentID.BOSPrivilege = null;
            this.fld_lkeFK_ACSegmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACSegmentID.BOSSelectType = null;
            this.fld_lkeFK_ACSegmentID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACSegmentID.CurrentDisplayText = null;
            this.fld_lkeFK_ACSegmentID.Location = new System.Drawing.Point(647, 188);
            this.fld_lkeFK_ACSegmentID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ACSegmentID.Name = "fld_lkeFK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACSegmentID.Properties.ColumnName = null;
            this.fld_lkeFK_ACSegmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACSegmentNo", "Mã khoản mục chi phí"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACSegmentName", "Tên khoản mục chi phí")});
            this.fld_lkeFK_ACSegmentID.Properties.DisplayMember = "ACSegmentName";
            this.fld_lkeFK_ACSegmentID.Properties.ValueMember = "ACSegmentID";
            this.fld_lkeFK_ACSegmentID.Screen = null;
            this.fld_lkeFK_ACSegmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACSegmentID.TabIndex = 20;
            this.fld_lkeFK_ACSegmentID.Tag = "DC";
            // 
            // fld_lkeFK_ACAssetTypeAccountConfigID
            // 
            this.fld_lkeFK_ACAssetTypeAccountConfigID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAssetTypeAccountConfigID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAssetTypeAccountConfigID.BOSComment = "";
            this.fld_lkeFK_ACAssetTypeAccountConfigID.BOSDataMember = "FK_ACAssetTypeAccountConfigID";
            this.fld_lkeFK_ACAssetTypeAccountConfigID.BOSDataSource = "ACAssets";
            this.fld_lkeFK_ACAssetTypeAccountConfigID.BOSDescription = null;
            this.fld_lkeFK_ACAssetTypeAccountConfigID.BOSError = "";
            this.fld_lkeFK_ACAssetTypeAccountConfigID.BOSFieldGroup = "";
            this.fld_lkeFK_ACAssetTypeAccountConfigID.BOSFieldParent = "";
            this.fld_lkeFK_ACAssetTypeAccountConfigID.BOSFieldRelation = "";
            this.fld_lkeFK_ACAssetTypeAccountConfigID.BOSPrivilege = "";
            this.fld_lkeFK_ACAssetTypeAccountConfigID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAssetTypeAccountConfigID.BOSSelectType = "";
            this.fld_lkeFK_ACAssetTypeAccountConfigID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACAssetTypeAccountConfigID.CurrentDisplayText = "";
            this.fld_lkeFK_ACAssetTypeAccountConfigID.Location = new System.Drawing.Point(99, 134);
            this.fld_lkeFK_ACAssetTypeAccountConfigID.Name = "fld_lkeFK_ACAssetTypeAccountConfigID";
            this.fld_lkeFK_ACAssetTypeAccountConfigID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACAssetTypeAccountConfigID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACAssetTypeAccountConfigID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACAssetTypeAccountConfigID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACAssetTypeAccountConfigID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAssetTypeAccountConfigID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAssetTypeAccountConfigID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAssetTypeAccountConfigName", "Nhóm tài khoản")});
            this.fld_lkeFK_ACAssetTypeAccountConfigID.Properties.DisplayMember = "ACAssetTypeAccountConfigName";
            this.fld_lkeFK_ACAssetTypeAccountConfigID.Properties.NullText = "";
            this.fld_lkeFK_ACAssetTypeAccountConfigID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAssetTypeAccountConfigID.Properties.ValueMember = "ACAssetTypeAccountConfigID";
            this.fld_lkeFK_ACAssetTypeAccountConfigID.Screen = null;
            this.fld_lkeFK_ACAssetTypeAccountConfigID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACAssetTypeAccountConfigID.TabIndex = 7;
            this.fld_lkeFK_ACAssetTypeAccountConfigID.Tag = "DC";
            this.fld_lkeFK_ACAssetTypeAccountConfigID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACAssetTypeAccountConfigID_CloseUp);
            // 
            // bosLabel23
            // 
            this.bosLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel23.Appearance.Options.UseBackColor = true;
            this.bosLabel23.Appearance.Options.UseForeColor = true;
            this.bosLabel23.BOSComment = "";
            this.bosLabel23.BOSDataMember = "";
            this.bosLabel23.BOSDataSource = "";
            this.bosLabel23.BOSDescription = null;
            this.bosLabel23.BOSError = null;
            this.bosLabel23.BOSFieldGroup = "";
            this.bosLabel23.BOSFieldRelation = "";
            this.bosLabel23.BOSPrivilege = "";
            this.bosLabel23.BOSPropertyName = "";
            this.bosLabel23.Location = new System.Drawing.Point(555, 191);
            this.bosLabel23.Name = "bosLabel23";
            this.bosLabel23.Screen = null;
            this.bosLabel23.Size = new System.Drawing.Size(85, 13);
            this.bosLabel23.TabIndex = 28;
            this.bosLabel23.Tag = "";
            this.bosLabel23.Text = "Khoản mục chi phí";
            // 
            // bosLabel24
            // 
            this.bosLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel24.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel24.Appearance.Options.UseBackColor = true;
            this.bosLabel24.Appearance.Options.UseFont = true;
            this.bosLabel24.Appearance.Options.UseForeColor = true;
            this.bosLabel24.BOSComment = "";
            this.bosLabel24.BOSDataMember = "";
            this.bosLabel24.BOSDataSource = "";
            this.bosLabel24.BOSDescription = null;
            this.bosLabel24.BOSError = null;
            this.bosLabel24.BOSFieldGroup = "";
            this.bosLabel24.BOSFieldRelation = "";
            this.bosLabel24.BOSPrivilege = "";
            this.bosLabel24.BOSPropertyName = null;
            this.bosLabel24.Location = new System.Drawing.Point(15, 137);
            this.bosLabel24.Name = "bosLabel24";
            this.bosLabel24.Screen = null;
            this.bosLabel24.Size = new System.Drawing.Size(75, 13);
            this.bosLabel24.TabIndex = 36;
            this.bosLabel24.Tag = "";
            this.bosLabel24.Text = "Nhóm tài khoản";
            // 
            // fld_lkeFK_ACCostCenterID
            // 
            this.fld_lkeFK_ACCostCenterID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACCostCenterID.BOSAllowDummy = true;
            this.fld_lkeFK_ACCostCenterID.BOSComment = null;
            this.fld_lkeFK_ACCostCenterID.BOSDataMember = "FK_ACCostCenterID";
            this.fld_lkeFK_ACCostCenterID.BOSDataSource = "ACAssets";
            this.fld_lkeFK_ACCostCenterID.BOSDescription = null;
            this.fld_lkeFK_ACCostCenterID.BOSError = null;
            this.fld_lkeFK_ACCostCenterID.BOSFieldGroup = null;
            this.fld_lkeFK_ACCostCenterID.BOSFieldParent = null;
            this.fld_lkeFK_ACCostCenterID.BOSFieldRelation = null;
            this.fld_lkeFK_ACCostCenterID.BOSPrivilege = null;
            this.fld_lkeFK_ACCostCenterID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACCostCenterID.BOSSelectType = null;
            this.fld_lkeFK_ACCostCenterID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACCostCenterID.CurrentDisplayText = null;
            this.fld_lkeFK_ACCostCenterID.Location = new System.Drawing.Point(647, 162);
            this.fld_lkeFK_ACCostCenterID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ACCostCenterID.Name = "fld_lkeFK_ACCostCenterID";
            this.fld_lkeFK_ACCostCenterID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACCostCenterID.Properties.ColumnName = null;
            this.fld_lkeFK_ACCostCenterID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACCostCenterNo", "Mã trung tâm chi phí"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACCostCenterName", "Tên trung tâm chi phí")});
            this.fld_lkeFK_ACCostCenterID.Properties.DisplayMember = "ACCostCenterName";
            this.fld_lkeFK_ACCostCenterID.Properties.ValueMember = "ACCostCenterID";
            this.fld_lkeFK_ACCostCenterID.Screen = null;
            this.fld_lkeFK_ACCostCenterID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACCostCenterID.TabIndex = 19;
            this.fld_lkeFK_ACCostCenterID.Tag = "DC";
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Options.UseBackColor = true;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
            this.bosLabel22.BOSComment = "";
            this.bosLabel22.BOSDataMember = "";
            this.bosLabel22.BOSDataSource = "";
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = "";
            this.bosLabel22.BOSFieldRelation = "";
            this.bosLabel22.BOSPrivilege = "";
            this.bosLabel22.BOSPropertyName = "";
            this.bosLabel22.Location = new System.Drawing.Point(555, 165);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.bosLabel22.Size = new System.Drawing.Size(83, 13);
            this.bosLabel22.TabIndex = 24;
            this.bosLabel22.Tag = "";
            this.bosLabel22.Text = "Trung tâm chi phí";
            // 
            // bosLookupEdit6
            // 
            this.bosLookupEdit6.BOSAllowAddNew = false;
            this.bosLookupEdit6.BOSAllowDummy = true;
            this.bosLookupEdit6.BOSComment = null;
            this.bosLookupEdit6.BOSDataMember = "FK_HRDepartmentID";
            this.bosLookupEdit6.BOSDataSource = "ACAssets";
            this.bosLookupEdit6.BOSDescription = null;
            this.bosLookupEdit6.BOSError = null;
            this.bosLookupEdit6.BOSFieldGroup = null;
            this.bosLookupEdit6.BOSFieldParent = null;
            this.bosLookupEdit6.BOSFieldRelation = null;
            this.bosLookupEdit6.BOSPrivilege = null;
            this.bosLookupEdit6.BOSPropertyName = "EditValue";
            this.bosLookupEdit6.BOSSelectType = null;
            this.bosLookupEdit6.BOSSelectTypeValue = null;
            this.bosLookupEdit6.CurrentDisplayText = null;
            this.bosLookupEdit6.Location = new System.Drawing.Point(647, 30);
            this.bosLookupEdit6.MenuManager = this.screenToolbar;
            this.bosLookupEdit6.Name = "bosLookupEdit6";
            this.bosLookupEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit6.Properties.ColumnName = null;
            this.bosLookupEdit6.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentNo", "Mã phòng ban"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Tên phòng ban")});
            this.bosLookupEdit6.Properties.DisplayMember = "HRDepartmentName";
            this.bosLookupEdit6.Properties.ValueMember = "HRDepartmentID";
            this.bosLookupEdit6.Screen = null;
            this.bosLookupEdit6.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit6.TabIndex = 14;
            this.bosLookupEdit6.Tag = "DC";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BOSComment = "";
            this.bosLabel19.BOSDataMember = "";
            this.bosLabel19.BOSDataSource = "";
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = "";
            this.bosLabel19.BOSFieldRelation = "";
            this.bosLabel19.BOSPrivilege = "";
            this.bosLabel19.BOSPropertyName = "";
            this.bosLabel19.Location = new System.Drawing.Point(555, 33);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(51, 13);
            this.bosLabel19.TabIndex = 8;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "Phòng ban";
            // 
            // bosLookupEdit5
            // 
            this.bosLookupEdit5.BOSAllowAddNew = false;
            this.bosLookupEdit5.BOSAllowDummy = true;
            this.bosLookupEdit5.BOSComment = null;
            this.bosLookupEdit5.BOSDataMember = "FK_HREmployeeUserID";
            this.bosLookupEdit5.BOSDataSource = "ACAssets";
            this.bosLookupEdit5.BOSDescription = null;
            this.bosLookupEdit5.BOSError = null;
            this.bosLookupEdit5.BOSFieldGroup = null;
            this.bosLookupEdit5.BOSFieldParent = null;
            this.bosLookupEdit5.BOSFieldRelation = null;
            this.bosLookupEdit5.BOSPrivilege = null;
            this.bosLookupEdit5.BOSPropertyName = "EditValue";
            this.bosLookupEdit5.BOSSelectType = null;
            this.bosLookupEdit5.BOSSelectTypeValue = null;
            this.bosLookupEdit5.CurrentDisplayText = null;
            this.bosLookupEdit5.Location = new System.Drawing.Point(363, 108);
            this.bosLookupEdit5.MenuManager = this.screenToolbar;
            this.bosLookupEdit5.Name = "bosLookupEdit5";
            this.bosLookupEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit5.Properties.ColumnName = null;
            this.bosLookupEdit5.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên")});
            this.bosLookupEdit5.Properties.DisplayMember = "HREmployeeName";
            this.bosLookupEdit5.Properties.ValueMember = "HREmployeeID";
            this.bosLookupEdit5.Screen = null;
            this.bosLookupEdit5.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit5.TabIndex = 6;
            this.bosLookupEdit5.Tag = "DC";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = "";
            this.bosLabel18.BOSDataMember = "";
            this.bosLabel18.BOSDataSource = "";
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = "";
            this.bosLabel18.BOSFieldRelation = "";
            this.bosLabel18.BOSPrivilege = "";
            this.bosLabel18.BOSPropertyName = "";
            this.bosLabel18.Location = new System.Drawing.Point(275, 111);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(70, 13);
            this.bosLabel18.TabIndex = 30;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "Người sử dụng";
            // 
            // fld_lkeFK_ACDepreciationCostAccountID
            // 
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSAllowDummy = true;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSComment = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSDataMember = "FK_ACDepreciationCostAccountID";
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSDataSource = "ACAssets";
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSDescription = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSError = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSFieldGroup = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSFieldParent = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSFieldRelation = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSPrivilege = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSSelectType = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.CurrentDisplayText = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.Location = new System.Drawing.Point(363, 134);
            this.fld_lkeFK_ACDepreciationCostAccountID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ACDepreciationCostAccountID.Name = "fld_lkeFK_ACDepreciationCostAccountID";
            this.fld_lkeFK_ACDepreciationCostAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACDepreciationCostAccountID.Properties.ColumnName = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACDepreciationCostAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACDepreciationCostAccountID.Screen = null;
            this.fld_lkeFK_ACDepreciationCostAccountID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACDepreciationCostAccountID.TabIndex = 8;
            this.fld_lkeFK_ACDepreciationCostAccountID.Tag = "DC";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_ACDepreciationAccountID";
            this.bosLookupEdit1.BOSDataSource = "ACAssets";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = null;
            this.bosLookupEdit1.BOSFieldParent = null;
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = null;
            this.bosLookupEdit1.BOSSelectTypeValue = null;
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(363, 162);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.bosLookupEdit1.Properties.DisplayMember = "ACAccountNo";
            this.bosLookupEdit1.Properties.NullText = "";
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "ACAccountID";
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit1.TabIndex = 10;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // fld_lkeFK_ACAccountID
            // 
            this.fld_lkeFK_ACAccountID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountID.BOSComment = null;
            this.fld_lkeFK_ACAccountID.BOSDataMember = "FK_ACAccountID";
            this.fld_lkeFK_ACAccountID.BOSDataSource = "ACAssets";
            this.fld_lkeFK_ACAccountID.BOSDescription = null;
            this.fld_lkeFK_ACAccountID.BOSError = null;
            this.fld_lkeFK_ACAccountID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAccountID.BOSFieldParent = null;
            this.fld_lkeFK_ACAccountID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAccountID.BOSPrivilege = null;
            this.fld_lkeFK_ACAccountID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountID.BOSSelectType = null;
            this.fld_lkeFK_ACAccountID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAccountID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAccountID.Location = new System.Drawing.Point(99, 162);
            this.fld_lkeFK_ACAccountID.Name = "fld_lkeFK_ACAccountID";
            this.fld_lkeFK_ACAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountID.Properties.NullText = "";
            this.fld_lkeFK_ACAccountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountID.Screen = null;
            this.fld_lkeFK_ACAccountID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACAccountID.TabIndex = 9;
            this.fld_lkeFK_ACAccountID.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = "";
            this.bosLabel8.BOSDataMember = "";
            this.bosLabel8.BOSDataSource = "";
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = "";
            this.bosLabel8.BOSFieldRelation = "";
            this.bosLabel8.BOSPrivilege = "";
            this.bosLabel8.BOSPropertyName = "";
            this.bosLabel8.Location = new System.Drawing.Point(275, 137);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(46, 13);
            this.bosLabel8.TabIndex = 18;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "TK chi phí";
            // 
            // fld_lkeFK_ICMeasureUnitID
            // 
            this.fld_lkeFK_ICMeasureUnitID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICMeasureUnitID.BOSAllowDummy = true;
            this.fld_lkeFK_ICMeasureUnitID.BOSComment = null;
            this.fld_lkeFK_ICMeasureUnitID.BOSDataMember = "FK_ICMeasureUnitID";
            this.fld_lkeFK_ICMeasureUnitID.BOSDataSource = "ACAssets";
            this.fld_lkeFK_ICMeasureUnitID.BOSDescription = null;
            this.fld_lkeFK_ICMeasureUnitID.BOSError = null;
            this.fld_lkeFK_ICMeasureUnitID.BOSFieldGroup = null;
            this.fld_lkeFK_ICMeasureUnitID.BOSFieldParent = null;
            this.fld_lkeFK_ICMeasureUnitID.BOSFieldRelation = null;
            this.fld_lkeFK_ICMeasureUnitID.BOSPrivilege = null;
            this.fld_lkeFK_ICMeasureUnitID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICMeasureUnitID.BOSSelectType = null;
            this.fld_lkeFK_ICMeasureUnitID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICMeasureUnitID.CurrentDisplayText = null;
            this.fld_lkeFK_ICMeasureUnitID.Location = new System.Drawing.Point(99, 108);
            this.fld_lkeFK_ICMeasureUnitID.Name = "fld_lkeFK_ICMeasureUnitID";
            this.fld_lkeFK_ICMeasureUnitID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICMeasureUnitID.Properties.ColumnName = null;
            this.fld_lkeFK_ICMeasureUnitID.Properties.DisplayMember = "ICMeasureUnitName";
            this.fld_lkeFK_ICMeasureUnitID.Properties.ValueMember = "ICMeasureUnitID";
            this.fld_lkeFK_ICMeasureUnitID.Screen = null;
            this.fld_lkeFK_ICMeasureUnitID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICMeasureUnitID.TabIndex = 5;
            this.fld_lkeFK_ICMeasureUnitID.Tag = "DC";
            // 
            // bosLookupEdit4
            // 
            this.bosLookupEdit4.BOSAllowAddNew = false;
            this.bosLookupEdit4.BOSAllowDummy = true;
            this.bosLookupEdit4.BOSComment = null;
            this.bosLookupEdit4.BOSDataMember = "FK_MMWorkShopID";
            this.bosLookupEdit4.BOSDataSource = "ACAssets";
            this.bosLookupEdit4.BOSDescription = null;
            this.bosLookupEdit4.BOSError = null;
            this.bosLookupEdit4.BOSFieldGroup = null;
            this.bosLookupEdit4.BOSFieldParent = null;
            this.bosLookupEdit4.BOSFieldRelation = null;
            this.bosLookupEdit4.BOSPrivilege = null;
            this.bosLookupEdit4.BOSPropertyName = "EditValue";
            this.bosLookupEdit4.BOSSelectType = null;
            this.bosLookupEdit4.BOSSelectTypeValue = null;
            this.bosLookupEdit4.CurrentDisplayText = null;
            this.bosLookupEdit4.Location = new System.Drawing.Point(647, 82);
            this.bosLookupEdit4.Name = "bosLookupEdit4";
            this.bosLookupEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit4.Properties.ColumnName = null;
            this.bosLookupEdit4.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Tên")});
            this.bosLookupEdit4.Properties.DisplayMember = "MMWorkShopName";
            this.bosLookupEdit4.Properties.ValueMember = "MMWorkShopID";
            this.bosLookupEdit4.Screen = null;
            this.bosLookupEdit4.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit4.TabIndex = 16;
            this.bosLookupEdit4.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = "";
            this.bosLabel17.BOSDataMember = "";
            this.bosLabel17.BOSDataSource = "";
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = "";
            this.bosLabel17.BOSFieldRelation = "";
            this.bosLabel17.BOSPrivilege = "";
            this.bosLabel17.BOSPropertyName = "";
            this.bosLabel17.Location = new System.Drawing.Point(555, 85);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(31, 13);
            this.bosLabel17.TabIndex = 20;
            this.bosLabel17.Tag = "";
            this.bosLabel17.Text = "Xưởng";
            // 
            // bosLookupEdit3
            // 
            this.bosLookupEdit3.BOSAllowAddNew = false;
            this.bosLookupEdit3.BOSAllowDummy = true;
            this.bosLookupEdit3.BOSComment = null;
            this.bosLookupEdit3.BOSDataMember = "FK_HRDepartmentRoomGroupItemID";
            this.bosLookupEdit3.BOSDataSource = "ACAssets";
            this.bosLookupEdit3.BOSDescription = null;
            this.bosLookupEdit3.BOSError = null;
            this.bosLookupEdit3.BOSFieldGroup = null;
            this.bosLookupEdit3.BOSFieldParent = null;
            this.bosLookupEdit3.BOSFieldRelation = null;
            this.bosLookupEdit3.BOSPrivilege = null;
            this.bosLookupEdit3.BOSPropertyName = "EditValue";
            this.bosLookupEdit3.BOSSelectType = null;
            this.bosLookupEdit3.BOSSelectTypeValue = null;
            this.bosLookupEdit3.CurrentDisplayText = null;
            this.bosLookupEdit3.Location = new System.Drawing.Point(647, 134);
            this.bosLookupEdit3.Name = "bosLookupEdit3";
            this.bosLookupEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit3.Properties.ColumnName = null;
            this.bosLookupEdit3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tên")});
            this.bosLookupEdit3.Properties.DisplayMember = "HRDepartmentRoomGroupItemName";
            this.bosLookupEdit3.Properties.ValueMember = "HRDepartmentRoomGroupItemID";
            this.bosLookupEdit3.Screen = null;
            this.bosLookupEdit3.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit3.TabIndex = 18;
            this.bosLookupEdit3.Tag = "DC";
            this.bosLookupEdit3.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.bosLookupEdit3_QueryPopUp);
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = "";
            this.bosLabel16.BOSDataMember = "";
            this.bosLabel16.BOSDataSource = "";
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = "";
            this.bosLabel16.BOSFieldRelation = "";
            this.bosLabel16.BOSPrivilege = "";
            this.bosLabel16.BOSPropertyName = "";
            this.bosLabel16.Location = new System.Drawing.Point(275, 134);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(12, 13);
            this.bosLabel16.TabIndex = 32;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Tổ";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = true;
            this.bosLookupEdit2.BOSComment = null;
            this.bosLookupEdit2.BOSDataMember = "FK_MMLineID";
            this.bosLookupEdit2.BOSDataSource = "ACAssets";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = null;
            this.bosLookupEdit2.BOSFieldGroup = null;
            this.bosLookupEdit2.BOSFieldParent = null;
            this.bosLookupEdit2.BOSFieldRelation = null;
            this.bosLookupEdit2.BOSPrivilege = null;
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = null;
            this.bosLookupEdit2.BOSSelectTypeValue = null;
            this.bosLookupEdit2.CurrentDisplayText = null;
            this.bosLookupEdit2.Location = new System.Drawing.Point(647, 108);
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.ColumnName = null;
            this.bosLookupEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMLineNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMLineName", "Tên")});
            this.bosLookupEdit2.Properties.DisplayMember = "MMLineName";
            this.bosLookupEdit2.Properties.ValueMember = "MMLineID";
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit2.TabIndex = 17;
            this.bosLookupEdit2.Tag = "DC";
            this.bosLookupEdit2.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.bosLookupEdit2_QueryPopUp);
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = "";
            this.bosLabel15.BOSDataMember = "";
            this.bosLabel15.BOSDataSource = "";
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = "";
            this.bosLabel15.BOSFieldRelation = "";
            this.bosLabel15.BOSPrivilege = "";
            this.bosLabel15.BOSPropertyName = "";
            this.bosLabel15.Location = new System.Drawing.Point(555, 111);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(37, 13);
            this.bosLabel15.TabIndex = 26;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "Chuyền";
            // 
            // fld_lkeFK_HRDepartmentRoomID1
            // 
            this.fld_lkeFK_HRDepartmentRoomID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID1.BOSDataSource = "ACAssets";
            this.fld_lkeFK_HRDepartmentRoomID1.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSFieldParent = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomID1.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomID1.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomID1.Location = new System.Drawing.Point(647, 56);
            this.fld_lkeFK_HRDepartmentRoomID1.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HRDepartmentRoomID1.Name = "fld_lkeFK_HRDepartmentRoomID1";
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomID1.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID1.Screen = null;
            this.fld_lkeFK_HRDepartmentRoomID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HRDepartmentRoomID1.TabIndex = 15;
            this.fld_lkeFK_HRDepartmentRoomID1.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomID1.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentRoomID1_QueryPopUp);
            this.fld_lkeFK_HRDepartmentRoomID1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_HRDepartmentRoomID1_CloseUp);
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "";
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = "";
            this.bosLabel5.Location = new System.Drawing.Point(555, 59);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(39, 13);
            this.bosLabel5.TabIndex = 14;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Bộ phận";
            // 
            // fld_lkeACAssetType1
            // 
            this.fld_lkeACAssetType1.BOSAllowAddNew = false;
            this.fld_lkeACAssetType1.BOSAllowDummy = false;
            this.fld_lkeACAssetType1.BOSComment = null;
            this.fld_lkeACAssetType1.BOSDataMember = "ACAssetType";
            this.fld_lkeACAssetType1.BOSDataSource = "ACAssets";
            this.fld_lkeACAssetType1.BOSDescription = null;
            this.fld_lkeACAssetType1.BOSError = null;
            this.fld_lkeACAssetType1.BOSFieldGroup = null;
            this.fld_lkeACAssetType1.BOSFieldParent = null;
            this.fld_lkeACAssetType1.BOSFieldRelation = null;
            this.fld_lkeACAssetType1.BOSPrivilege = null;
            this.fld_lkeACAssetType1.BOSPropertyName = "EditValue";
            this.fld_lkeACAssetType1.BOSSelectType = null;
            this.fld_lkeACAssetType1.BOSSelectTypeValue = null;
            this.fld_lkeACAssetType1.CurrentDisplayText = null;
            this.fld_lkeACAssetType1.Location = new System.Drawing.Point(363, 30);
            this.fld_lkeACAssetType1.MenuManager = this.screenToolbar;
            this.fld_lkeACAssetType1.Name = "fld_lkeACAssetType1";
            this.fld_lkeACAssetType1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACAssetType1.Properties.ColumnName = null;
            this.fld_lkeACAssetType1.Screen = null;
            this.fld_lkeACAssetType1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACAssetType1.TabIndex = 1;
            this.fld_lkeACAssetType1.Tag = "DC";
            this.fld_lkeACAssetType1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeACAssetType1_CloseUp);
            // 
            // fld_lkeACAssetStatus
            // 
            this.fld_lkeACAssetStatus.BOSAllowAddNew = false;
            this.fld_lkeACAssetStatus.BOSAllowDummy = false;
            this.fld_lkeACAssetStatus.BOSComment = null;
            this.fld_lkeACAssetStatus.BOSDataMember = "ACAssetStatus";
            this.fld_lkeACAssetStatus.BOSDataSource = "ACAssets";
            this.fld_lkeACAssetStatus.BOSDescription = null;
            this.fld_lkeACAssetStatus.BOSError = null;
            this.fld_lkeACAssetStatus.BOSFieldGroup = null;
            this.fld_lkeACAssetStatus.BOSFieldParent = null;
            this.fld_lkeACAssetStatus.BOSFieldRelation = null;
            this.fld_lkeACAssetStatus.BOSPrivilege = null;
            this.fld_lkeACAssetStatus.BOSPropertyName = "EditValue";
            this.fld_lkeACAssetStatus.BOSSelectType = null;
            this.fld_lkeACAssetStatus.BOSSelectTypeValue = null;
            this.fld_lkeACAssetStatus.CurrentDisplayText = null;
            this.fld_lkeACAssetStatus.Location = new System.Drawing.Point(363, 214);
            this.fld_lkeACAssetStatus.MenuManager = this.screenToolbar;
            this.fld_lkeACAssetStatus.Name = "fld_lkeACAssetStatus";
            this.fld_lkeACAssetStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACAssetStatus.Properties.ColumnName = null;
            this.fld_lkeACAssetStatus.Properties.ReadOnly = true;
            this.fld_lkeACAssetStatus.Screen = null;
            this.fld_lkeACAssetStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACAssetStatus.TabIndex = 13;
            this.fld_lkeACAssetStatus.Tag = "DC";
            // 
            // fld_medACAssetComment
            // 
            this.fld_medACAssetComment.BOSComment = null;
            this.fld_medACAssetComment.BOSDataMember = "ACAssetComment";
            this.fld_medACAssetComment.BOSDataSource = "ACAssets";
            this.fld_medACAssetComment.BOSDescription = null;
            this.fld_medACAssetComment.BOSError = null;
            this.fld_medACAssetComment.BOSFieldGroup = null;
            this.fld_medACAssetComment.BOSFieldRelation = null;
            this.fld_medACAssetComment.BOSPrivilege = null;
            this.fld_medACAssetComment.BOSPropertyName = "Text";
            this.fld_medACAssetComment.Location = new System.Drawing.Point(99, 188);
            this.fld_medACAssetComment.MenuManager = this.screenToolbar;
            this.fld_medACAssetComment.Name = "fld_medACAssetComment";
            this.fld_medACAssetComment.Screen = null;
            this.fld_medACAssetComment.Size = new System.Drawing.Size(150, 46);
            this.fld_medACAssetComment.TabIndex = 11;
            this.fld_medACAssetComment.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = "";
            this.bosLabel1.Location = new System.Drawing.Point(15, 191);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(35, 13);
            this.bosLabel1.TabIndex = 44;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Ghi chú";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "";
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = "";
            this.bosLabel4.Location = new System.Drawing.Point(275, 33);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(54, 13);
            this.bosLabel4.TabIndex = 2;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Loại tài sản";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = "";
            this.bosLabel10.BOSDataMember = "";
            this.bosLabel10.BOSDataSource = "";
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = "";
            this.bosLabel10.BOSFieldRelation = "";
            this.bosLabel10.BOSPrivilege = "";
            this.bosLabel10.BOSPropertyName = "";
            this.bosLabel10.Location = new System.Drawing.Point(15, 111);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(52, 13);
            this.bosLabel10.TabIndex = 4;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Đơn vị tính";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = "";
            this.bosLabel3.Location = new System.Drawing.Point(275, 217);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 22;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Tình trạng";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = "";
            this.bosLabel13.BOSDataMember = "";
            this.bosLabel13.BOSDataSource = "";
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = "";
            this.bosLabel13.BOSFieldRelation = "";
            this.bosLabel13.BOSPrivilege = "";
            this.bosLabel13.BOSPropertyName = "";
            this.bosLabel13.Location = new System.Drawing.Point(275, 165);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(59, 13);
            this.bosLabel13.TabIndex = 42;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "TK khấu hao";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = "";
            this.bosLabel12.BOSDataMember = "";
            this.bosLabel12.BOSDataSource = "";
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = "";
            this.bosLabel12.BOSFieldRelation = "";
            this.bosLabel12.BOSPrivilege = "";
            this.bosLabel12.BOSPropertyName = "";
            this.bosLabel12.Location = new System.Drawing.Point(15, 165);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(47, 13);
            this.bosLabel12.TabIndex = 38;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "TK tài sản";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.bosGroupControl2.Controls.Add(this.bosLabel21);
            this.bosGroupControl2.Controls.Add(this.fld_dteACAssetDepreciationDate);
            this.bosGroupControl2.Controls.Add(this.fld_lkeFK_ACUnfinishedConstructionCostID);
            this.bosGroupControl2.Controls.Add(this.bosLabel20);
            this.bosGroupControl2.Controls.Add(this.fld_lkeACAssetDepreciationMethod);
            this.bosGroupControl2.Controls.Add(this.bosLabel7);
            this.bosGroupControl2.Controls.Add(this.bosLabel11);
            this.bosGroupControl2.Controls.Add(this.bosLabel9);
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel12);
            this.bosGroupControl2.Controls.Add(this.fld_txtACAssetDepreciationAmount);
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel7);
            this.bosGroupControl2.Controls.Add(this.fld_txtACAssetDepreciationPercent);
            this.bosGroupControl2.Controls.Add(this.fld_txtACAssetRemainedAmount);
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel13);
            this.bosGroupControl2.Controls.Add(this.fld_txtACAssetExpiryMonths);
            this.bosGroupControl2.Controls.Add(this.fld_txtACAssetInitDepreciatedAmount);
            this.bosGroupControl2.Controls.Add(this.fld_txtACAssetInitQty);
            this.bosGroupControl2.Controls.Add(this.fld_txtACAssetCost);
            this.bosGroupControl2.Controls.Add(this.fld_txtACAssetOriginalAmount);
            this.bosGroupControl2.Controls.Add(this.bosLabel2);
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel14);
            this.bosGroupControl2.Controls.Add(this.fld_txtACAssetDepreciatedAmount);
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel15);
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel16);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 267);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(890, 222);
            this.bosGroupControl2.TabIndex = 1;
            this.bosGroupControl2.Text = "Thông tin khấu hao";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BOSComment = "";
            this.bosLabel21.BOSDataMember = "";
            this.bosLabel21.BOSDataSource = "";
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = "";
            this.bosLabel21.BOSFieldRelation = "";
            this.bosLabel21.BOSPrivilege = "";
            this.bosLabel21.BOSPropertyName = "";
            this.bosLabel21.Location = new System.Drawing.Point(15, 112);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(72, 13);
            this.bosLabel21.TabIndex = 10;
            this.bosLabel21.Tag = "";
            this.bosLabel21.Text = "Ngày khấu hao";
            // 
            // fld_dteACAssetDepreciationDate
            // 
            this.fld_dteACAssetDepreciationDate.BOSComment = "";
            this.fld_dteACAssetDepreciationDate.BOSDataMember = "ACAssetDepreciationDate";
            this.fld_dteACAssetDepreciationDate.BOSDataSource = "ACAssets";
            this.fld_dteACAssetDepreciationDate.BOSDescription = null;
            this.fld_dteACAssetDepreciationDate.BOSError = null;
            this.fld_dteACAssetDepreciationDate.BOSFieldGroup = "";
            this.fld_dteACAssetDepreciationDate.BOSFieldRelation = "";
            this.fld_dteACAssetDepreciationDate.BOSPrivilege = "";
            this.fld_dteACAssetDepreciationDate.BOSPropertyName = "EditValue";
            this.fld_dteACAssetDepreciationDate.EditValue = null;
            this.fld_dteACAssetDepreciationDate.Location = new System.Drawing.Point(132, 109);
            this.fld_dteACAssetDepreciationDate.Name = "fld_dteACAssetDepreciationDate";
            this.fld_dteACAssetDepreciationDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACAssetDepreciationDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACAssetDepreciationDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACAssetDepreciationDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACAssetDepreciationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACAssetDepreciationDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACAssetDepreciationDate.Screen = null;
            this.fld_dteACAssetDepreciationDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACAssetDepreciationDate.TabIndex = 3;
            this.fld_dteACAssetDepreciationDate.Tag = "DC";
            // 
            // fld_lkeFK_ACUnfinishedConstructionCostID
            // 
            this.fld_lkeFK_ACUnfinishedConstructionCostID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACUnfinishedConstructionCostID.BOSAllowDummy = true;
            this.fld_lkeFK_ACUnfinishedConstructionCostID.BOSComment = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID.BOSDataMember = "FK_ACUnfinishedConstructionCostID";
            this.fld_lkeFK_ACUnfinishedConstructionCostID.BOSDataSource = "ACAssets";
            this.fld_lkeFK_ACUnfinishedConstructionCostID.BOSDescription = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID.BOSError = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID.BOSFieldGroup = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID.BOSFieldParent = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID.BOSFieldRelation = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID.BOSPrivilege = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACUnfinishedConstructionCostID.BOSSelectType = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID.CurrentDisplayText = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID.Location = new System.Drawing.Point(132, 32);
            this.fld_lkeFK_ACUnfinishedConstructionCostID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ACUnfinishedConstructionCostID.Name = "fld_lkeFK_ACUnfinishedConstructionCostID";
            this.fld_lkeFK_ACUnfinishedConstructionCostID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACUnfinishedConstructionCostID.Properties.ColumnName = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACUnfinishedConstructionCostNo", "Mã chi phí XDCBDD"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACUnfinishedConstructionCostName", "Tên chi phí XDCBDD")});
            this.fld_lkeFK_ACUnfinishedConstructionCostID.Properties.DisplayMember = "ACUnfinishedConstructionCostName";
            this.fld_lkeFK_ACUnfinishedConstructionCostID.Properties.ReadOnly = true;
            this.fld_lkeFK_ACUnfinishedConstructionCostID.Properties.ValueMember = "ACUnfinishedConstructionCostID";
            this.fld_lkeFK_ACUnfinishedConstructionCostID.Screen = null;
            this.fld_lkeFK_ACUnfinishedConstructionCostID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACUnfinishedConstructionCostID.TabIndex = 0;
            this.fld_lkeFK_ACUnfinishedConstructionCostID.Tag = "DC";
            this.fld_lkeFK_ACUnfinishedConstructionCostID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_ACUnfinishedConstructionCostID_QueryPopUp);
            this.fld_lkeFK_ACUnfinishedConstructionCostID.Validated += new System.EventHandler(this.fld_lkeFK_ACUnfinishedConstructionCostID_Validated);
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = "";
            this.bosLabel20.BOSDataMember = "";
            this.bosLabel20.BOSDataSource = "";
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = "";
            this.bosLabel20.BOSFieldRelation = "";
            this.bosLabel20.BOSPrivilege = "";
            this.bosLabel20.BOSPropertyName = "";
            this.bosLabel20.Location = new System.Drawing.Point(15, 35);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(62, 13);
            this.bosLabel20.TabIndex = 0;
            this.bosLabel20.Tag = "";
            this.bosLabel20.Text = "Chi phí XDDD";
            // 
            // fld_lkeACAssetDepreciationMethod
            // 
            this.fld_lkeACAssetDepreciationMethod.BOSAllowAddNew = false;
            this.fld_lkeACAssetDepreciationMethod.BOSAllowDummy = false;
            this.fld_lkeACAssetDepreciationMethod.BOSComment = null;
            this.fld_lkeACAssetDepreciationMethod.BOSDataMember = "ACAssetDepreciationMethod";
            this.fld_lkeACAssetDepreciationMethod.BOSDataSource = "ACAssets";
            this.fld_lkeACAssetDepreciationMethod.BOSDescription = null;
            this.fld_lkeACAssetDepreciationMethod.BOSError = null;
            this.fld_lkeACAssetDepreciationMethod.BOSFieldGroup = null;
            this.fld_lkeACAssetDepreciationMethod.BOSFieldParent = null;
            this.fld_lkeACAssetDepreciationMethod.BOSFieldRelation = null;
            this.fld_lkeACAssetDepreciationMethod.BOSPrivilege = null;
            this.fld_lkeACAssetDepreciationMethod.BOSPropertyName = "EditValue";
            this.fld_lkeACAssetDepreciationMethod.BOSSelectType = null;
            this.fld_lkeACAssetDepreciationMethod.BOSSelectTypeValue = null;
            this.fld_lkeACAssetDepreciationMethod.CurrentDisplayText = null;
            this.fld_lkeACAssetDepreciationMethod.Location = new System.Drawing.Point(456, 58);
            this.fld_lkeACAssetDepreciationMethod.MenuManager = this.screenToolbar;
            this.fld_lkeACAssetDepreciationMethod.Name = "fld_lkeACAssetDepreciationMethod";
            this.fld_lkeACAssetDepreciationMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACAssetDepreciationMethod.Properties.ColumnName = null;
            this.fld_lkeACAssetDepreciationMethod.Screen = null;
            this.fld_lkeACAssetDepreciationMethod.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACAssetDepreciationMethod.TabIndex = 7;
            this.fld_lkeACAssetDepreciationMethod.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = "";
            this.bosLabel7.BOSDataMember = "";
            this.bosLabel7.BOSDataSource = "";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = "";
            this.bosLabel7.BOSFieldRelation = "";
            this.bosLabel7.BOSPrivilege = "";
            this.bosLabel7.BOSPropertyName = "";
            this.bosLabel7.Location = new System.Drawing.Point(15, 61);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(38, 13);
            this.bosLabel7.TabIndex = 2;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Giá mua";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = "";
            this.bosLabel11.BOSDataMember = "";
            this.bosLabel11.BOSDataSource = "";
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = "";
            this.bosLabel11.BOSFieldRelation = "";
            this.bosLabel11.BOSPrivilege = "";
            this.bosLabel11.BOSPropertyName = "";
            this.bosLabel11.Location = new System.Drawing.Point(319, 112);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(102, 13);
            this.bosLabel11.TabIndex = 16;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "GT khấu hao ban đầu";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = "";
            this.bosLabel9.BOSDataMember = "";
            this.bosLabel9.BOSDataSource = "";
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = "";
            this.bosLabel9.BOSFieldRelation = "";
            this.bosLabel9.BOSPrivilege = "";
            this.bosLabel9.BOSPropertyName = "";
            this.bosLabel9.Location = new System.Drawing.Point(15, 164);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(84, 13);
            this.bosLabel9.TabIndex = 22;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Số lượng ban đầu";
            // 
            // fld_txtACAssetInitDepreciatedAmount
            // 
            this.fld_txtACAssetInitDepreciatedAmount.BOSComment = "";
            this.fld_txtACAssetInitDepreciatedAmount.BOSDataMember = "ACAssetInitDepreciatedAmount";
            this.fld_txtACAssetInitDepreciatedAmount.BOSDataSource = "ACAssets";
            this.fld_txtACAssetInitDepreciatedAmount.BOSDescription = null;
            this.fld_txtACAssetInitDepreciatedAmount.BOSError = null;
            this.fld_txtACAssetInitDepreciatedAmount.BOSFieldGroup = "";
            this.fld_txtACAssetInitDepreciatedAmount.BOSFieldRelation = "";
            this.fld_txtACAssetInitDepreciatedAmount.BOSPrivilege = "";
            this.fld_txtACAssetInitDepreciatedAmount.BOSPropertyName = "Text";
            this.fld_txtACAssetInitDepreciatedAmount.EditValue = "";
            this.fld_txtACAssetInitDepreciatedAmount.Location = new System.Drawing.Point(456, 109);
            this.fld_txtACAssetInitDepreciatedAmount.Name = "fld_txtACAssetInitDepreciatedAmount";
            this.fld_txtACAssetInitDepreciatedAmount.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtACAssetInitDepreciatedAmount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetInitDepreciatedAmount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetInitDepreciatedAmount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetInitDepreciatedAmount.Properties.Mask.EditMask = "n";
            this.fld_txtACAssetInitDepreciatedAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACAssetInitDepreciatedAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetInitDepreciatedAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetInitDepreciatedAmount.Screen = null;
            this.fld_txtACAssetInitDepreciatedAmount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACAssetInitDepreciatedAmount.TabIndex = 9;
            this.fld_txtACAssetInitDepreciatedAmount.Tag = "DC";
            // 
            // fld_txtACAssetInitQty
            // 
            this.fld_txtACAssetInitQty.BOSComment = "";
            this.fld_txtACAssetInitQty.BOSDataMember = "ACAssetInitQty";
            this.fld_txtACAssetInitQty.BOSDataSource = "ACAssets";
            this.fld_txtACAssetInitQty.BOSDescription = null;
            this.fld_txtACAssetInitQty.BOSError = null;
            this.fld_txtACAssetInitQty.BOSFieldGroup = "";
            this.fld_txtACAssetInitQty.BOSFieldRelation = "";
            this.fld_txtACAssetInitQty.BOSPrivilege = "";
            this.fld_txtACAssetInitQty.BOSPropertyName = "Text";
            this.fld_txtACAssetInitQty.EditValue = "0";
            this.fld_txtACAssetInitQty.Location = new System.Drawing.Point(132, 161);
            this.fld_txtACAssetInitQty.Name = "fld_txtACAssetInitQty";
            this.fld_txtACAssetInitQty.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtACAssetInitQty.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetInitQty.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetInitQty.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetInitQty.Properties.Mask.EditMask = "n";
            this.fld_txtACAssetInitQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACAssetInitQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetInitQty.Properties.ReadOnly = true;
            this.fld_txtACAssetInitQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetInitQty.Screen = null;
            this.fld_txtACAssetInitQty.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACAssetInitQty.TabIndex = 5;
            this.fld_txtACAssetInitQty.Tag = "DC";
            // 
            // fld_txtACAssetCost
            // 
            this.fld_txtACAssetCost.BOSComment = "";
            this.fld_txtACAssetCost.BOSDataMember = "ACAssetCost";
            this.fld_txtACAssetCost.BOSDataSource = "ACAssets";
            this.fld_txtACAssetCost.BOSDescription = null;
            this.fld_txtACAssetCost.BOSError = null;
            this.fld_txtACAssetCost.BOSFieldGroup = "";
            this.fld_txtACAssetCost.BOSFieldRelation = "";
            this.fld_txtACAssetCost.BOSPrivilege = "";
            this.fld_txtACAssetCost.BOSPropertyName = "Text";
            this.fld_txtACAssetCost.EditValue = "";
            this.fld_txtACAssetCost.Location = new System.Drawing.Point(132, 58);
            this.fld_txtACAssetCost.Name = "fld_txtACAssetCost";
            this.fld_txtACAssetCost.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtACAssetCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACAssetCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACAssetCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACAssetCost.Properties.Mask.EditMask = "n";
            this.fld_txtACAssetCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACAssetCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACAssetCost.Properties.ReadOnly = true;
            this.fld_txtACAssetCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACAssetCost.Screen = null;
            this.fld_txtACAssetCost.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACAssetCost.TabIndex = 1;
            this.fld_txtACAssetCost.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(15, 87);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(90, 13);
            this.bosLabel2.TabIndex = 6;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Số tháng khấu hao";
            // 
            // DMAS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(895, 523);
            this.Controls.Add(this.bosGroupControl2);
            this.Controls.Add(this.bosGroupControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMAS100.IconOptions.Icon")));
            this.Name = "DMAS100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosGroupControl1, 0);
            this.Controls.SetChildIndex(this.bosGroupControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetPurchasedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetPurchasedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetUsedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetUsedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetExpiryMonths.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetDepreciatedAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetOriginalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetRemainedAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetDepreciationPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetDepreciationAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckACAssetIsInventory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssetTypeAccountConfigID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACCostCenterID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACDepreciationCostAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICMeasureUnitID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAssetType1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAssetStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACAssetComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetDepreciationDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACAssetDepreciationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACUnfinishedConstructionCostID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAssetDepreciationMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetInitDepreciatedAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetInitQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACAssetCost.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSMemoEdit fld_medACAssetComment;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeACAssetStatus;
        private BOSComponent.BOSLookupEdit fld_lkeACAssetDepreciationMethod;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeACAssetType1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomID1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtACAssetCost;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACDepreciationCostAccountID;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox fld_txtACAssetInitQty;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICMeasureUnitID;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox fld_txtACAssetInitDepreciatedAmount;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountID;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLookupEdit bosLookupEdit4;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit bosLookupEdit3;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLookupEdit bosLookupEdit5;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLookupEdit bosLookupEdit6;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACUnfinishedConstructionCostID;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSDateEdit fld_dteACAssetDepreciationDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACCostCenterID;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACSegmentID;
        private BOSComponent.BOSLabel bosLabel23;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAssetTypeAccountConfigID;
        private BOSComponent.BOSLabel bosLabel24;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSCheckEdit fld_ckACAssetIsInventory;
    }
}
