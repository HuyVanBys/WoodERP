using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Equipment.UI
{
	/// <summary>
	/// Summary description for DMEQ100
	/// </summary>
	partial class DMEQ100
	{
		private BOSComponent.BOSLabel fld_lblLabel15;
		private BOSComponent.BOSLabel fld_lblLabel16;
        private BOSComponent.BOSLabel fld_lblLabel17;
		private BOSComponent.BOSLabel fld_lblLabel22;
		private BOSComponent.BOSTextBox fld_txtICProductNo1;
        private BOSComponent.BOSMemoEdit fld_medICProductComment;
		private BOSComponent.BOSLabel fld_lblLabel27;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductBasicUnitID;
        private BOSComponent.BOSTextBox fld_txtICProductDepreciationMonths;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMEQ100));
            this.fld_lblLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medICProductComment = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductBasicUnitID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICProductDepreciationMonths = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICProductName1 = new BOSComponent.BOSTextBox(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_ckICProductIsFollowInventoryStock = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeFK_ICPriceCalculationMethodID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel27 = new BOSComponent.BOSLabel(this.components);
            this.fld_bedFK_ICProductGroupID = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_lblLabel28 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_ckICProductIsInventory = new BOSComponent.BOSCheckEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductBasicUnitID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductDepreciationMonths.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckICProductIsFollowInventoryStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICPriceCalculationMethodID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckICProductIsInventory.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.fld_lblLabel15.Location = new System.Drawing.Point(13, 31);
            this.fld_lblLabel15.Name = "fld_lblLabel15";
            this.fld_lblLabel15.Screen = null;
            this.fld_lblLabel15.Size = new System.Drawing.Size(45, 13);
            this.fld_lblLabel15.TabIndex = 4;
            this.fld_lblLabel15.Tag = "";
            this.fld_lblLabel15.Text = "Mã CCDC";
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
            this.fld_lblLabel16.Location = new System.Drawing.Point(258, 31);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.fld_lblLabel16.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel16.TabIndex = 5;
            this.fld_lblLabel16.Tag = "";
            this.fld_lblLabel16.Text = "Tên CCDC";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = "";
            this.fld_lblLabel17.BOSDataMember = "";
            this.fld_lblLabel17.BOSDataSource = "";
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = "";
            this.fld_lblLabel17.BOSFieldRelation = "";
            this.fld_lblLabel17.BOSPrivilege = "";
            this.fld_lblLabel17.BOSPropertyName = "";
            this.fld_lblLabel17.Location = new System.Drawing.Point(258, 57);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel17.TabIndex = 6;
            this.fld_lblLabel17.Tag = "";
            this.fld_lblLabel17.Text = "Đơn vị tính";
            // 
            // fld_lblLabel22
            // 
            this.fld_lblLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel22.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel22.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel22.BOSComment = "";
            this.fld_lblLabel22.BOSDataMember = "";
            this.fld_lblLabel22.BOSDataSource = "";
            this.fld_lblLabel22.BOSDescription = null;
            this.fld_lblLabel22.BOSError = null;
            this.fld_lblLabel22.BOSFieldGroup = "";
            this.fld_lblLabel22.BOSFieldRelation = "";
            this.fld_lblLabel22.BOSPrivilege = "";
            this.fld_lblLabel22.BOSPropertyName = "";
            this.fld_lblLabel22.Location = new System.Drawing.Point(13, 109);
            this.fld_lblLabel22.Name = "fld_lblLabel22";
            this.fld_lblLabel22.Screen = null;
            this.fld_lblLabel22.Size = new System.Drawing.Size(35, 13);
            this.fld_lblLabel22.TabIndex = 11;
            this.fld_lblLabel22.Tag = "";
            this.fld_lblLabel22.Text = "Ghi chú";
            // 
            // fld_txtICProductNo1
            // 
            this.fld_txtICProductNo1.BOSComment = "";
            this.fld_txtICProductNo1.BOSDataMember = "ICProductNo";
            this.fld_txtICProductNo1.BOSDataSource = "ICProducts";
            this.fld_txtICProductNo1.BOSDescription = null;
            this.fld_txtICProductNo1.BOSError = null;
            this.fld_txtICProductNo1.BOSFieldGroup = "";
            this.fld_txtICProductNo1.BOSFieldRelation = "";
            this.fld_txtICProductNo1.BOSPrivilege = "";
            this.fld_txtICProductNo1.BOSPropertyName = "Text";
            this.fld_txtICProductNo1.EditValue = "";
            this.fld_txtICProductNo1.Location = new System.Drawing.Point(93, 28);
            this.fld_txtICProductNo1.Name = "fld_txtICProductNo1";
            this.fld_txtICProductNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductNo1.Screen = null;
            this.fld_txtICProductNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICProductNo1.TabIndex = 0;
            this.fld_txtICProductNo1.Tag = "DC";
            // 
            // fld_medICProductComment
            // 
            this.fld_medICProductComment.BOSComment = "";
            this.fld_medICProductComment.BOSDataMember = "ICProductComment";
            this.fld_medICProductComment.BOSDataSource = "ICProducts";
            this.fld_medICProductComment.BOSDescription = null;
            this.fld_medICProductComment.BOSError = null;
            this.fld_medICProductComment.BOSFieldGroup = "";
            this.fld_medICProductComment.BOSFieldRelation = "";
            this.fld_medICProductComment.BOSPrivilege = "";
            this.fld_medICProductComment.BOSPropertyName = "Text";
            this.fld_medICProductComment.EditValue = "";
            this.fld_medICProductComment.Location = new System.Drawing.Point(93, 106);
            this.fld_medICProductComment.Name = "fld_medICProductComment";
            this.fld_medICProductComment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICProductComment.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICProductComment.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICProductComment.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICProductComment.Screen = null;
            this.fld_medICProductComment.Size = new System.Drawing.Size(411, 45);
            this.fld_medICProductComment.TabIndex = 9;
            this.fld_medICProductComment.Tag = "DC";
            // 
            // fld_lblLabel27
            // 
            this.fld_lblLabel27.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel27.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel27.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel27.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel27.BOSComment = "";
            this.fld_lblLabel27.BOSDataMember = "";
            this.fld_lblLabel27.BOSDataSource = "";
            this.fld_lblLabel27.BOSDescription = null;
            this.fld_lblLabel27.BOSError = null;
            this.fld_lblLabel27.BOSFieldGroup = "";
            this.fld_lblLabel27.BOSFieldRelation = "";
            this.fld_lblLabel27.BOSPrivilege = "";
            this.fld_lblLabel27.BOSPropertyName = "";
            this.fld_lblLabel27.Location = new System.Drawing.Point(530, 57);
            this.fld_lblLabel27.Name = "fld_lblLabel27";
            this.fld_lblLabel27.Screen = null;
            this.fld_lblLabel27.Size = new System.Drawing.Size(85, 13);
            this.fld_lblLabel27.TabIndex = 18;
            this.fld_lblLabel27.Tag = "";
            this.fld_lblLabel27.Text = "Số tháng phân bổ";
            // 
            // fld_lkeFK_ICProductBasicUnitID
            // 
            this.fld_lkeFK_ICProductBasicUnitID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductBasicUnitID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductBasicUnitID.BOSComment = "";
            this.fld_lkeFK_ICProductBasicUnitID.BOSDataMember = "FK_ICProductBasicUnitID";
            this.fld_lkeFK_ICProductBasicUnitID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ICProductBasicUnitID.BOSDescription = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSError = null;
            this.fld_lkeFK_ICProductBasicUnitID.BOSFieldGroup = "";
            this.fld_lkeFK_ICProductBasicUnitID.BOSFieldParent = "";
            this.fld_lkeFK_ICProductBasicUnitID.BOSFieldRelation = "";
            this.fld_lkeFK_ICProductBasicUnitID.BOSPrivilege = "";
            this.fld_lkeFK_ICProductBasicUnitID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductBasicUnitID.BOSSelectType = "";
            this.fld_lkeFK_ICProductBasicUnitID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICProductBasicUnitID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductBasicUnitID.Location = new System.Drawing.Point(354, 54);
            this.fld_lkeFK_ICProductBasicUnitID.Name = "fld_lkeFK_ICProductBasicUnitID";
            this.fld_lkeFK_ICProductBasicUnitID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductBasicUnitID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductBasicUnitID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductBasicUnitID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductBasicUnitID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductBasicUnitID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductBasicUnitID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICMeasureUnitNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICMeasureUnitName", "Name")});
            this.fld_lkeFK_ICProductBasicUnitID.Properties.DisplayMember = "ICMeasureUnitName";
            this.fld_lkeFK_ICProductBasicUnitID.Properties.NullText = "";
            this.fld_lkeFK_ICProductBasicUnitID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICProductBasicUnitID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductBasicUnitID.Properties.ValueMember = "ICMeasureUnitID";
            this.fld_lkeFK_ICProductBasicUnitID.Screen = null;
            this.fld_lkeFK_ICProductBasicUnitID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICProductBasicUnitID.TabIndex = 4;
            this.fld_lkeFK_ICProductBasicUnitID.Tag = "DC";
            // 
            // fld_txtICProductDepreciationMonths
            // 
            this.fld_txtICProductDepreciationMonths.BOSComment = "";
            this.fld_txtICProductDepreciationMonths.BOSDataMember = "ICProductDepreciationMonths";
            this.fld_txtICProductDepreciationMonths.BOSDataSource = "ICProducts";
            this.fld_txtICProductDepreciationMonths.BOSDescription = null;
            this.fld_txtICProductDepreciationMonths.BOSError = null;
            this.fld_txtICProductDepreciationMonths.BOSFieldGroup = "";
            this.fld_txtICProductDepreciationMonths.BOSFieldRelation = "";
            this.fld_txtICProductDepreciationMonths.BOSPrivilege = "";
            this.fld_txtICProductDepreciationMonths.BOSPropertyName = "Text";
            this.fld_txtICProductDepreciationMonths.EditValue = "";
            this.fld_txtICProductDepreciationMonths.Location = new System.Drawing.Point(638, 54);
            this.fld_txtICProductDepreciationMonths.Name = "fld_txtICProductDepreciationMonths";
            this.fld_txtICProductDepreciationMonths.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductDepreciationMonths.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductDepreciationMonths.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductDepreciationMonths.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductDepreciationMonths.Properties.Mask.EditMask = "n0";
            this.fld_txtICProductDepreciationMonths.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICProductDepreciationMonths.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductDepreciationMonths.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductDepreciationMonths.Screen = null;
            this.fld_txtICProductDepreciationMonths.Size = new System.Drawing.Size(158, 20);
            this.fld_txtICProductDepreciationMonths.TabIndex = 5;
            this.fld_txtICProductDepreciationMonths.Tag = "DC";
            // 
            // fld_txtICProductName1
            // 
            this.fld_txtICProductName1.BOSComment = null;
            this.fld_txtICProductName1.BOSDataMember = "ICProductName";
            this.fld_txtICProductName1.BOSDataSource = "ICProducts";
            this.fld_txtICProductName1.BOSDescription = null;
            this.fld_txtICProductName1.BOSError = null;
            this.fld_txtICProductName1.BOSFieldGroup = null;
            this.fld_txtICProductName1.BOSFieldRelation = null;
            this.fld_txtICProductName1.BOSPrivilege = null;
            this.fld_txtICProductName1.BOSPropertyName = "Text";
            this.fld_txtICProductName1.Location = new System.Drawing.Point(354, 28);
            this.fld_txtICProductName1.MenuManager = this.screenToolbar;
            this.fld_txtICProductName1.Name = "fld_txtICProductName1";
            this.fld_txtICProductName1.Screen = null;
            this.fld_txtICProductName1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICProductName1.TabIndex = 1;
            this.fld_txtICProductName1.Tag = "DC";
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
            this.bosGroupControl1.Controls.Add(this.fld_ckICProductIsInventory);
            this.bosGroupControl1.Controls.Add(this.fld_ckICProductIsFollowInventoryStock);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ICPriceCalculationMethodID);
            this.bosGroupControl1.Controls.Add(this.bosLabel27);
            this.bosGroupControl1.Controls.Add(this.fld_txtICProductDepreciationMonths);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel27);
            this.bosGroupControl1.Controls.Add(this.fld_bedFK_ICProductGroupID);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel28);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit2);
            this.bosGroupControl1.Controls.Add(this.bosLabel6);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit1);
            this.bosGroupControl1.Controls.Add(this.FLd_lkeFK_ACEquipmentTypeAccountConfigID);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACAccountID);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel15);
            this.bosGroupControl1.Controls.Add(this.fld_txtICProductName1);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel17);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ICProductBasicUnitID);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel16);
            this.bosGroupControl1.Controls.Add(this.fld_medICProductComment);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_txtICProductNo1);
            this.bosGroupControl1.Controls.Add(this.bosLabel7);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel22);
            this.bosGroupControl1.Location = new System.Drawing.Point(5, 4);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(824, 167);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin chung";
            // 
            // fld_ckICProductIsFollowInventoryStock
            // 
            this.fld_ckICProductIsFollowInventoryStock.BOSComment = "";
            this.fld_ckICProductIsFollowInventoryStock.BOSDataMember = "ICProductIsFollowInventoryStock";
            this.fld_ckICProductIsFollowInventoryStock.BOSDataSource = "ICProducts";
            this.fld_ckICProductIsFollowInventoryStock.BOSDescription = null;
            this.fld_ckICProductIsFollowInventoryStock.BOSError = "";
            this.fld_ckICProductIsFollowInventoryStock.BOSFieldGroup = "";
            this.fld_ckICProductIsFollowInventoryStock.BOSFieldRelation = "";
            this.fld_ckICProductIsFollowInventoryStock.BOSPrivilege = "";
            this.fld_ckICProductIsFollowInventoryStock.BOSPropertyName = "EditValue";
            this.fld_ckICProductIsFollowInventoryStock.Location = new System.Drawing.Point(531, 132);
            this.fld_ckICProductIsFollowInventoryStock.Name = "fld_ckICProductIsFollowInventoryStock";
            this.fld_ckICProductIsFollowInventoryStock.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_ckICProductIsFollowInventoryStock.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_ckICProductIsFollowInventoryStock.Properties.Appearance.Options.UseBackColor = true;
            this.fld_ckICProductIsFollowInventoryStock.Properties.Appearance.Options.UseForeColor = true;
            this.fld_ckICProductIsFollowInventoryStock.Properties.Caption = "Theo dõi tồn kho";
            this.fld_ckICProductIsFollowInventoryStock.Screen = null;
            this.fld_ckICProductIsFollowInventoryStock.Size = new System.Drawing.Size(112, 20);
            this.fld_ckICProductIsFollowInventoryStock.TabIndex = 11;
            this.fld_ckICProductIsFollowInventoryStock.TabStop = false;
            this.fld_ckICProductIsFollowInventoryStock.Tag = "DC";
            // 
            // fld_lkeFK_ICPriceCalculationMethodID
            // 
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSAllowDummy = false;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSComment = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSDataMember = "FK_ICPriceCalculationMethodID";
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSDataSource = "ICProducts";
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSDescription = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSError = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSFieldGroup = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSFieldParent = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSFieldRelation = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSPrivilege = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSSelectType = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.CurrentDisplayText = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.Location = new System.Drawing.Point(638, 106);
            this.fld_lkeFK_ICPriceCalculationMethodID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICPriceCalculationMethodID.Name = "fld_lkeFK_ICPriceCalculationMethodID";
            this.fld_lkeFK_ICPriceCalculationMethodID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICPriceCalculationMethodID.Properties.ColumnName = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICPriceCalculationMethodName", "Tên phương pháp")});
            this.fld_lkeFK_ICPriceCalculationMethodID.Properties.DisplayMember = "ICPriceCalculationMethodName";
            this.fld_lkeFK_ICPriceCalculationMethodID.Properties.NullText = "";
            this.fld_lkeFK_ICPriceCalculationMethodID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICPriceCalculationMethodID.Properties.ValueMember = "ICPriceCalculationMethodID";
            this.fld_lkeFK_ICPriceCalculationMethodID.Screen = null;
            this.fld_lkeFK_ICPriceCalculationMethodID.Size = new System.Drawing.Size(158, 20);
            this.fld_lkeFK_ICPriceCalculationMethodID.TabIndex = 10;
            this.fld_lkeFK_ICPriceCalculationMethodID.Tag = "DC";
            // 
            // bosLabel27
            // 
            this.bosLabel27.BOSComment = null;
            this.bosLabel27.BOSDataMember = null;
            this.bosLabel27.BOSDataSource = null;
            this.bosLabel27.BOSDescription = null;
            this.bosLabel27.BOSError = null;
            this.bosLabel27.BOSFieldGroup = null;
            this.bosLabel27.BOSFieldRelation = null;
            this.bosLabel27.BOSPrivilege = null;
            this.bosLabel27.BOSPropertyName = null;
            this.bosLabel27.Location = new System.Drawing.Point(531, 110);
            this.bosLabel27.Name = "bosLabel27";
            this.bosLabel27.Screen = null;
            this.bosLabel27.Size = new System.Drawing.Size(50, 13);
            this.bosLabel27.TabIndex = 347;
            this.bosLabel27.Text = "PP tính giá";
            // 
            // fld_bedFK_ICProductGroupID
            // 
            this.fld_bedFK_ICProductGroupID.BOSComment = null;
            this.fld_bedFK_ICProductGroupID.BOSDataMember = "ICProductGroupName";
            this.fld_bedFK_ICProductGroupID.BOSDataSource = "ICProducts";
            this.fld_bedFK_ICProductGroupID.BOSDescription = null;
            this.fld_bedFK_ICProductGroupID.BOSError = null;
            this.fld_bedFK_ICProductGroupID.BOSFieldGroup = null;
            this.fld_bedFK_ICProductGroupID.BOSFieldRelation = null;
            this.fld_bedFK_ICProductGroupID.BOSPrivilege = null;
            this.fld_bedFK_ICProductGroupID.BOSPropertyName = "Text";
            this.fld_bedFK_ICProductGroupID.Location = new System.Drawing.Point(638, 28);
            this.fld_bedFK_ICProductGroupID.MenuManager = this.screenToolbar;
            this.fld_bedFK_ICProductGroupID.Name = "fld_bedFK_ICProductGroupID";
            this.fld_bedFK_ICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedFK_ICProductGroupID.Properties.ReadOnly = true;
            this.fld_bedFK_ICProductGroupID.Screen = null;
            this.fld_bedFK_ICProductGroupID.Size = new System.Drawing.Size(158, 20);
            this.fld_bedFK_ICProductGroupID.TabIndex = 2;
            this.fld_bedFK_ICProductGroupID.Tag = "DC";
            this.fld_bedFK_ICProductGroupID.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedFK_ICProductGroupID_ButtonClick);
            // 
            // fld_lblLabel28
            // 
            this.fld_lblLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel28.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel28.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel28.Appearance.Options.UseFont = true;
            this.fld_lblLabel28.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel28.BOSComment = "";
            this.fld_lblLabel28.BOSDataMember = "";
            this.fld_lblLabel28.BOSDataSource = "";
            this.fld_lblLabel28.BOSDescription = null;
            this.fld_lblLabel28.BOSError = null;
            this.fld_lblLabel28.BOSFieldGroup = "";
            this.fld_lblLabel28.BOSFieldRelation = "";
            this.fld_lblLabel28.BOSPrivilege = "";
            this.fld_lblLabel28.BOSPropertyName = "";
            this.fld_lblLabel28.Location = new System.Drawing.Point(530, 31);
            this.fld_lblLabel28.Name = "fld_lblLabel28";
            this.fld_lblLabel28.Screen = null;
            this.fld_lblLabel28.Size = new System.Drawing.Size(55, 13);
            this.fld_lblLabel28.TabIndex = 22;
            this.fld_lblLabel28.Tag = "";
            this.fld_lblLabel28.Text = "Nhóm hàng";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = false;
            this.bosLookupEdit2.BOSComment = null;
            this.bosLookupEdit2.BOSDataMember = "FK_ACDepreciationAccountID";
            this.bosLookupEdit2.BOSDataSource = "ICProducts";
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
            this.bosLookupEdit2.Location = new System.Drawing.Point(638, 80);
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.ColumnName = null;
            this.bosLookupEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.bosLookupEdit2.Properties.DisplayMember = "ACAccountNo";
            this.bosLookupEdit2.Properties.NullText = "";
            this.bosLookupEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit2.Properties.ValueMember = "ACAccountID";
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(158, 20);
            this.bosLookupEdit2.TabIndex = 8;
            this.bosLookupEdit2.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(530, 83);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(88, 13);
            this.bosLabel6.TabIndex = 17;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Tài khoản phân bổ";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "FK_ACDepreciationCostAccountID";
            this.bosLookupEdit1.BOSDataSource = "ICProducts";
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
            this.bosLookupEdit1.Location = new System.Drawing.Point(354, 80);
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
            this.bosLookupEdit1.TabIndex = 7;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // FLd_lkeFK_ACEquipmentTypeAccountConfigID
            // 
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.BOSAllowAddNew = false;
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.BOSAllowDummy = false;
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.BOSComment = null;
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.BOSDataMember = "FK_ACEquipmentTypeAccountConfigID";
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.BOSDataSource = "ICProducts";
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.BOSDescription = null;
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.BOSError = null;
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.BOSFieldGroup = null;
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.BOSFieldParent = null;
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.BOSFieldRelation = null;
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.BOSPrivilege = null;
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.BOSPropertyName = "EditValue";
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.BOSSelectType = null;
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.BOSSelectTypeValue = null;
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.CurrentDisplayText = null;
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.Location = new System.Drawing.Point(93, 54);
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.Name = "FLd_lkeFK_ACEquipmentTypeAccountConfigID";
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.Properties.ColumnName = null;
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACEquipmentTypeAccountConfigName", "Nhóm")});
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.Properties.DisplayMember = "ACEquipmentTypeAccountConfigName";
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.Properties.NullText = "";
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.Properties.ValueMember = "ACEquipmentTypeAccountConfigID";
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.Screen = null;
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.Size = new System.Drawing.Size(150, 20);
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.TabIndex = 3;
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.Tag = "DC";
            this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.FLd_lkeFK_ACEquipmentTypeAccountConfigID_CloseUp);
            // 
            // fld_lkeFK_ACAccountID
            // 
            this.fld_lkeFK_ACAccountID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountID.BOSAllowDummy = false;
            this.fld_lkeFK_ACAccountID.BOSComment = null;
            this.fld_lkeFK_ACAccountID.BOSDataMember = "FK_ACAccountID";
            this.fld_lkeFK_ACAccountID.BOSDataSource = "ICProducts";
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
            this.fld_lkeFK_ACAccountID.Location = new System.Drawing.Point(93, 80);
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
            this.fld_lkeFK_ACAccountID.TabIndex = 6;
            this.fld_lkeFK_ACAccountID.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(258, 83);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(79, 13);
            this.bosLabel3.TabIndex = 10;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Tài khoản chi phí";
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
            this.bosLabel7.Location = new System.Drawing.Point(13, 57);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(74, 13);
            this.bosLabel7.TabIndex = 10;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Nhóm tài khoản";
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
            this.bosLabel2.Location = new System.Drawing.Point(13, 83);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(46, 13);
            this.bosLabel2.TabIndex = 10;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Tài khoản";
            // 
            // fld_ckICProductIsInventory
            // 
            this.fld_ckICProductIsInventory.BOSComment = "";
            this.fld_ckICProductIsInventory.BOSDataMember = "ICProductIsInventory";
            this.fld_ckICProductIsInventory.BOSDataSource = "ICProducts";
            this.fld_ckICProductIsInventory.BOSDescription = null;
            this.fld_ckICProductIsInventory.BOSError = "";
            this.fld_ckICProductIsInventory.BOSFieldGroup = "";
            this.fld_ckICProductIsInventory.BOSFieldRelation = "";
            this.fld_ckICProductIsInventory.BOSPrivilege = "";
            this.fld_ckICProductIsInventory.BOSPropertyName = "EditValue";
            this.fld_ckICProductIsInventory.Location = new System.Drawing.Point(684, 132);
            this.fld_ckICProductIsInventory.Name = "fld_ckICProductIsInventory";
            this.fld_ckICProductIsInventory.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_ckICProductIsInventory.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_ckICProductIsInventory.Properties.Appearance.Options.UseBackColor = true;
            this.fld_ckICProductIsInventory.Properties.Appearance.Options.UseForeColor = true;
            this.fld_ckICProductIsInventory.Properties.Caption = "Kiểm kê";
            this.fld_ckICProductIsInventory.Screen = null;
            this.fld_ckICProductIsInventory.Size = new System.Drawing.Size(112, 20);
            this.fld_ckICProductIsInventory.TabIndex = 12;
            this.fld_ckICProductIsInventory.TabStop = false;
            this.fld_ckICProductIsInventory.Tag = "DC";
            // 
            // DMEQ100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1155, 516);
            this.Controls.Add(this.bosGroupControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMEQ100.IconOptions.Icon")));
            this.Name = "DMEQ100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosGroupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductBasicUnitID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductDepreciationMonths.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckICProductIsFollowInventoryStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICPriceCalculationMethodID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedFK_ICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FLd_lkeFK_ACEquipmentTypeAccountConfigID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckICProductIsInventory.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSTextBox fld_txtICProductName1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSButtonEdit fld_bedFK_ICProductGroupID;
        private BOSComponent.BOSLabel fld_lblLabel28;
        private BOSComponent.BOSLookupEdit FLd_lkeFK_ACEquipmentTypeAccountConfigID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICPriceCalculationMethodID;
        private BOSComponent.BOSLabel bosLabel27;
        private BOSComponent.BOSCheckEdit fld_ckICProductIsFollowInventoryStock;
        private BOSComponent.BOSCheckEdit fld_ckICProductIsInventory;
    }
}
