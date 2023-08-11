using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Package.UI
{
	/// <summary>
	/// Summary description for DMPK100
	/// </summary>
	partial class DMPK100
	{
		private BOSComponent.BOSTextBox fld_txtICPackageNo1;
		private BOSComponent.BOSTextBox fld_txtICPackageOrder;
		private BOSComponent.BOSTextBox fld_txtICPackagePackNo1;
		private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID1;
		private BOSComponent.BOSMemoEdit fld_medICPackageDesc;
		private BOSComponent.BOSDateEdit fld_dteICPackageReceiptDate;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSLabel fld_lblLabel6;
		private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSLabel fld_lblLabel8;


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
            this.fld_txtICPackageNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICPackageOrder = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICPackagePackNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_APSupplierID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medICPackageDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dteICPackageReceiptDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICPackageSupplierNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtPackageType = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICPackageProductCount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICPackageCount = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcICProducts = new BOSERP.Modules.Package.ICProductsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPackageNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPackageOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPackagePackNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICPackageDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICPackageReceiptDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICPackageReceiptDate.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPackageSupplierNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPackageType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPackageProductCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPackageCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtICPackageNo1
            // 
            this.fld_txtICPackageNo1.BOSComment = "";
            this.fld_txtICPackageNo1.BOSDataMember = "ICPackageNo";
            this.fld_txtICPackageNo1.BOSDataSource = "ICPackages";
            this.fld_txtICPackageNo1.BOSDescription = null;
            this.fld_txtICPackageNo1.BOSError = null;
            this.fld_txtICPackageNo1.BOSFieldGroup = "";
            this.fld_txtICPackageNo1.BOSFieldRelation = "";
            this.fld_txtICPackageNo1.BOSPrivilege = "";
            this.fld_txtICPackageNo1.BOSPropertyName = "Text";
            this.fld_txtICPackageNo1.EditValue = "";
            this.fld_txtICPackageNo1.Location = new System.Drawing.Point(96, 32);
            this.fld_txtICPackageNo1.Name = "fld_txtICPackageNo1";
            this.fld_txtICPackageNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICPackageNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICPackageNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICPackageNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICPackageNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICPackageNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICPackageNo1.Screen = null;
            this.fld_txtICPackageNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICPackageNo1.TabIndex = 0;
            this.fld_txtICPackageNo1.Tag = "DC";
            // 
            // fld_txtICPackageOrder
            // 
            this.fld_txtICPackageOrder.BOSComment = "";
            this.fld_txtICPackageOrder.BOSDataMember = "ICPackageOrder";
            this.fld_txtICPackageOrder.BOSDataSource = "ICPackages";
            this.fld_txtICPackageOrder.BOSDescription = null;
            this.fld_txtICPackageOrder.BOSError = null;
            this.fld_txtICPackageOrder.BOSFieldGroup = "";
            this.fld_txtICPackageOrder.BOSFieldRelation = "";
            this.fld_txtICPackageOrder.BOSPrivilege = "";
            this.fld_txtICPackageOrder.BOSPropertyName = "Text";
            this.fld_txtICPackageOrder.EditValue = "";
            this.fld_txtICPackageOrder.Location = new System.Drawing.Point(96, 84);
            this.fld_txtICPackageOrder.Name = "fld_txtICPackageOrder";
            this.fld_txtICPackageOrder.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICPackageOrder.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICPackageOrder.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICPackageOrder.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICPackageOrder.Properties.Mask.EditMask = "n0";
            this.fld_txtICPackageOrder.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICPackageOrder.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICPackageOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICPackageOrder.Screen = null;
            this.fld_txtICPackageOrder.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICPackageOrder.TabIndex = 6;
            this.fld_txtICPackageOrder.Tag = "DC";
            // 
            // fld_txtICPackagePackNo1
            // 
            this.fld_txtICPackagePackNo1.BOSComment = "";
            this.fld_txtICPackagePackNo1.BOSDataMember = "ICPackagePackNo";
            this.fld_txtICPackagePackNo1.BOSDataSource = "ICPackages";
            this.fld_txtICPackagePackNo1.BOSDescription = null;
            this.fld_txtICPackagePackNo1.BOSError = null;
            this.fld_txtICPackagePackNo1.BOSFieldGroup = "";
            this.fld_txtICPackagePackNo1.BOSFieldRelation = "";
            this.fld_txtICPackagePackNo1.BOSPrivilege = "";
            this.fld_txtICPackagePackNo1.BOSPropertyName = "Text";
            this.fld_txtICPackagePackNo1.EditValue = "";
            this.fld_txtICPackagePackNo1.Location = new System.Drawing.Point(96, 58);
            this.fld_txtICPackagePackNo1.Name = "fld_txtICPackagePackNo1";
            this.fld_txtICPackagePackNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICPackagePackNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICPackagePackNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICPackagePackNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICPackagePackNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICPackagePackNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICPackagePackNo1.Screen = null;
            this.fld_txtICPackagePackNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICPackagePackNo1.TabIndex = 3;
            this.fld_txtICPackagePackNo1.Tag = "DC";
            // 
            // fld_lkeFK_APSupplierID1
            // 
            this.fld_lkeFK_APSupplierID1.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID1.BOSAllowDummy = false;
            this.fld_lkeFK_APSupplierID1.BOSComment = "";
            this.fld_lkeFK_APSupplierID1.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeFK_APSupplierID1.BOSDataSource = "ICPackages";
            this.fld_lkeFK_APSupplierID1.BOSDescription = null;
            this.fld_lkeFK_APSupplierID1.BOSError = null;
            this.fld_lkeFK_APSupplierID1.BOSFieldGroup = "";
            this.fld_lkeFK_APSupplierID1.BOSFieldParent = "";
            this.fld_lkeFK_APSupplierID1.BOSFieldRelation = "";
            this.fld_lkeFK_APSupplierID1.BOSPrivilege = "";
            this.fld_lkeFK_APSupplierID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APSupplierID1.BOSSelectType = "";
            this.fld_lkeFK_APSupplierID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_APSupplierID1.CurrentDisplayText = null;
            this.fld_lkeFK_APSupplierID1.Location = new System.Drawing.Point(462, 31);
            this.fld_lkeFK_APSupplierID1.Name = "fld_lkeFK_APSupplierID1";
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APSupplierID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APSupplierID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "Mã nhà cung cấp", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Tên nhà cung cấp")});
            this.fld_lkeFK_APSupplierID1.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeFK_APSupplierID1.Properties.NullText = "";
            this.fld_lkeFK_APSupplierID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_APSupplierID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APSupplierID1.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID1.Screen = null;
            this.fld_lkeFK_APSupplierID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_APSupplierID1.TabIndex = 1;
            this.fld_lkeFK_APSupplierID1.Tag = "DC";
            // 
            // fld_medICPackageDesc
            // 
            this.fld_medICPackageDesc.BOSComment = "";
            this.fld_medICPackageDesc.BOSDataMember = "ICPackageDesc";
            this.fld_medICPackageDesc.BOSDataSource = "ICPackages";
            this.fld_medICPackageDesc.BOSDescription = null;
            this.fld_medICPackageDesc.BOSError = null;
            this.fld_medICPackageDesc.BOSFieldGroup = "";
            this.fld_medICPackageDesc.BOSFieldRelation = "";
            this.fld_medICPackageDesc.BOSPrivilege = "";
            this.fld_medICPackageDesc.BOSPropertyName = "Text";
            this.fld_medICPackageDesc.EditValue = "";
            this.fld_medICPackageDesc.Location = new System.Drawing.Point(96, 136);
            this.fld_medICPackageDesc.Name = "fld_medICPackageDesc";
            this.fld_medICPackageDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICPackageDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICPackageDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICPackageDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICPackageDesc.Screen = null;
            this.fld_medICPackageDesc.Size = new System.Drawing.Size(856, 30);
            this.fld_medICPackageDesc.TabIndex = 9;
            this.fld_medICPackageDesc.Tag = "DC";
            // 
            // fld_dteICPackageReceiptDate
            // 
            this.fld_dteICPackageReceiptDate.BOSComment = "";
            this.fld_dteICPackageReceiptDate.BOSDataMember = "ICPackageReceiptDate";
            this.fld_dteICPackageReceiptDate.BOSDataSource = "ICPackages";
            this.fld_dteICPackageReceiptDate.BOSDescription = null;
            this.fld_dteICPackageReceiptDate.BOSError = null;
            this.fld_dteICPackageReceiptDate.BOSFieldGroup = "";
            this.fld_dteICPackageReceiptDate.BOSFieldRelation = "";
            this.fld_dteICPackageReceiptDate.BOSPrivilege = "";
            this.fld_dteICPackageReceiptDate.BOSPropertyName = "EditValue";
            this.fld_dteICPackageReceiptDate.EditValue = null;
            this.fld_dteICPackageReceiptDate.Location = new System.Drawing.Point(802, 32);
            this.fld_dteICPackageReceiptDate.Name = "fld_dteICPackageReceiptDate";
            this.fld_dteICPackageReceiptDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICPackageReceiptDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICPackageReceiptDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICPackageReceiptDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICPackageReceiptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICPackageReceiptDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICPackageReceiptDate.Screen = null;
            this.fld_dteICPackageReceiptDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICPackageReceiptDate.TabIndex = 2;
            this.fld_dteICPackageReceiptDate.Tag = "DC";
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
            this.fld_lblLabel3.Location = new System.Drawing.Point(12, 34);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(36, 13);
            this.fld_lblLabel3.TabIndex = 10;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Mã kiện";
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(12, 61);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel4.TabIndex = 11;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Mã lô hàng";
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(736, 34);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel5.TabIndex = 12;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Ngày nhập";
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(12, 87);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(68, 13);
            this.fld_lblLabel6.TabIndex = 13;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Số thứ tự kiện";
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
            this.fld_lblLabel7.Location = new System.Drawing.Point(372, 34);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel7.TabIndex = 14;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Nhà cung cấp";
            // 
            // fld_lblLabel8
            // 
            this.fld_lblLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel8.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel8.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel8.BOSComment = "";
            this.fld_lblLabel8.BOSDataMember = "";
            this.fld_lblLabel8.BOSDataSource = "";
            this.fld_lblLabel8.BOSDescription = null;
            this.fld_lblLabel8.BOSError = null;
            this.fld_lblLabel8.BOSFieldGroup = "";
            this.fld_lblLabel8.BOSFieldRelation = "";
            this.fld_lblLabel8.BOSPrivilege = "";
            this.fld_lblLabel8.BOSPropertyName = "";
            this.fld_lblLabel8.Location = new System.Drawing.Point(12, 139);
            this.fld_lblLabel8.Name = "fld_lblLabel8";
            this.fld_lblLabel8.Screen = null;
            this.fld_lblLabel8.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel8.TabIndex = 15;
            this.fld_lblLabel8.Tag = "";
            this.fld_lblLabel8.Text = "Mô tả";
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
            this.bosPanel1.Controls.Add(this.panel1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1075, 567);
            this.bosPanel1.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bosGroupControl1);
            this.panel1.Controls.Add(this.bosGroupControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 567);
            this.panel1.TabIndex = 26;
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
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_txtICPackageSupplierNo);
            this.bosGroupControl1.Controls.Add(this.fld_txtPackageType);
            this.bosGroupControl1.Controls.Add(this.fld_txtICPackageProductCount);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.fld_txtICPackageCount);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_txtICPackagePackNo1);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_txtICPackageNo1);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_APSupplierID1);
            this.bosGroupControl1.Controls.Add(this.fld_txtICPackageOrder);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel6);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel5);
            this.bosGroupControl1.Controls.Add(this.fld_medICPackageDesc);
            this.bosGroupControl1.Controls.Add(this.fld_dteICPackageReceiptDate);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel7);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel8);
            this.bosGroupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosGroupControl1.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(1075, 208);
            this.bosGroupControl1.TabIndex = 24;
            this.bosGroupControl1.Text = "Thông tin kiện hàng";
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
            this.bosLabel4.Location = new System.Drawing.Point(372, 87);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(60, 13);
            this.bosLabel4.TabIndex = 22;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Mã kiện NCC";
            // 
            // fld_txtICPackageSupplierNo
            // 
            this.fld_txtICPackageSupplierNo.BOSComment = "";
            this.fld_txtICPackageSupplierNo.BOSDataMember = "ICPackageSupplierNo";
            this.fld_txtICPackageSupplierNo.BOSDataSource = "ICPackages";
            this.fld_txtICPackageSupplierNo.BOSDescription = null;
            this.fld_txtICPackageSupplierNo.BOSError = null;
            this.fld_txtICPackageSupplierNo.BOSFieldGroup = "";
            this.fld_txtICPackageSupplierNo.BOSFieldRelation = "";
            this.fld_txtICPackageSupplierNo.BOSPrivilege = "";
            this.fld_txtICPackageSupplierNo.BOSPropertyName = "Text";
            this.fld_txtICPackageSupplierNo.EditValue = "";
            this.fld_txtICPackageSupplierNo.Location = new System.Drawing.Point(462, 83);
            this.fld_txtICPackageSupplierNo.Name = "fld_txtICPackageSupplierNo";
            this.fld_txtICPackageSupplierNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICPackageSupplierNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICPackageSupplierNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICPackageSupplierNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICPackageSupplierNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICPackageSupplierNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICPackageSupplierNo.Screen = null;
            this.fld_txtICPackageSupplierNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICPackageSupplierNo.TabIndex = 7;
            this.fld_txtICPackageSupplierNo.Tag = "DC";
            // 
            // fld_txtPackageType
            // 
            this.fld_txtPackageType.BOSComment = "";
            this.fld_txtPackageType.BOSDataMember = "ICPackageType";
            this.fld_txtPackageType.BOSDataSource = "ICPackages";
            this.fld_txtPackageType.BOSDescription = null;
            this.fld_txtPackageType.BOSError = null;
            this.fld_txtPackageType.BOSFieldGroup = "";
            this.fld_txtPackageType.BOSFieldRelation = "";
            this.fld_txtPackageType.BOSPrivilege = "";
            this.fld_txtPackageType.BOSPropertyName = "Text";
            this.fld_txtPackageType.EditValue = "";
            this.fld_txtPackageType.Location = new System.Drawing.Point(96, 110);
            this.fld_txtPackageType.Name = "fld_txtPackageType";
            this.fld_txtPackageType.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_txtPackageType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_txtPackageType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtPackageType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtPackageType.Properties.Appearance.Options.UseFont = true;
            this.fld_txtPackageType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtPackageType.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtPackageType.Properties.ReadOnly = true;
            this.fld_txtPackageType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtPackageType.Screen = null;
            this.fld_txtPackageType.Size = new System.Drawing.Size(856, 20);
            this.fld_txtPackageType.TabIndex = 8;
            this.fld_txtPackageType.Tag = "DC";
            // 
            // fld_txtICPackageProductCount
            // 
            this.fld_txtICPackageProductCount.BOSComment = "";
            this.fld_txtICPackageProductCount.BOSDataMember = "ICPackageProductCount";
            this.fld_txtICPackageProductCount.BOSDataSource = "ICPackages";
            this.fld_txtICPackageProductCount.BOSDescription = null;
            this.fld_txtICPackageProductCount.BOSError = null;
            this.fld_txtICPackageProductCount.BOSFieldGroup = "";
            this.fld_txtICPackageProductCount.BOSFieldRelation = "";
            this.fld_txtICPackageProductCount.BOSPrivilege = "";
            this.fld_txtICPackageProductCount.BOSPropertyName = "Text";
            this.fld_txtICPackageProductCount.EditValue = "";
            this.fld_txtICPackageProductCount.Location = new System.Drawing.Point(802, 58);
            this.fld_txtICPackageProductCount.Name = "fld_txtICPackageProductCount";
            this.fld_txtICPackageProductCount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICPackageProductCount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICPackageProductCount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICPackageProductCount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICPackageProductCount.Properties.Mask.EditMask = "n0";
            this.fld_txtICPackageProductCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICPackageProductCount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICPackageProductCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICPackageProductCount.Screen = null;
            this.fld_txtICPackageProductCount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICPackageProductCount.TabIndex = 5;
            this.fld_txtICPackageProductCount.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(697, 61);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(91, 13);
            this.bosLabel2.TabIndex = 19;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Số lượng sản phẩm";
            // 
            // fld_txtICPackageCount
            // 
            this.fld_txtICPackageCount.BOSComment = "";
            this.fld_txtICPackageCount.BOSDataMember = "ICPackageCount";
            this.fld_txtICPackageCount.BOSDataSource = "ICPackages";
            this.fld_txtICPackageCount.BOSDescription = null;
            this.fld_txtICPackageCount.BOSError = null;
            this.fld_txtICPackageCount.BOSFieldGroup = "";
            this.fld_txtICPackageCount.BOSFieldRelation = "";
            this.fld_txtICPackageCount.BOSPrivilege = "";
            this.fld_txtICPackageCount.BOSPropertyName = "Text";
            this.fld_txtICPackageCount.EditValue = "";
            this.fld_txtICPackageCount.Location = new System.Drawing.Point(462, 59);
            this.fld_txtICPackageCount.Name = "fld_txtICPackageCount";
            this.fld_txtICPackageCount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICPackageCount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICPackageCount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICPackageCount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICPackageCount.Properties.Mask.EditMask = "n0";
            this.fld_txtICPackageCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICPackageCount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICPackageCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICPackageCount.Screen = null;
            this.fld_txtICPackageCount.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICPackageCount.TabIndex = 4;
            this.fld_txtICPackageCount.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(12, 113);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(41, 13);
            this.bosLabel3.TabIndex = 17;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Loại kiện";
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
            this.bosLabel1.Location = new System.Drawing.Point(372, 63);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(64, 13);
            this.bosLabel1.TabIndex = 17;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Số lượng kiện";
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
            this.bosGroupControl2.Controls.Add(this.fld_dgcICProducts);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 228);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(1070, 336);
            this.bosGroupControl2.TabIndex = 25;
            this.bosGroupControl2.Text = "Thông tin sản phẩm";
            // 
            // fld_dgcICProducts
            // 
            this.fld_dgcICProducts.BOSComment = null;
            this.fld_dgcICProducts.BOSDataMember = null;
            this.fld_dgcICProducts.BOSDataSource = "ICProducts";
            this.fld_dgcICProducts.BOSDescription = null;
            this.fld_dgcICProducts.BOSError = null;
            this.fld_dgcICProducts.BOSFieldGroup = null;
            this.fld_dgcICProducts.BOSFieldRelation = null;
            this.fld_dgcICProducts.BOSGridType = null;
            this.fld_dgcICProducts.BOSPrivilege = null;
            this.fld_dgcICProducts.BOSPropertyName = null;
            this.fld_dgcICProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICProducts.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcICProducts.MenuManager = this.screenToolbar;
            this.fld_dgcICProducts.Name = "fld_dgcICProducts";
            this.fld_dgcICProducts.Screen = null;
            this.fld_dgcICProducts.Size = new System.Drawing.Size(1066, 312);
            this.fld_dgcICProducts.TabIndex = 10;
            this.fld_dgcICProducts.Tag = "DC";
            // 
            // DMPK100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1075, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPK100";
            this.Text = "Thông tin";
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPackageNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPackageOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPackagePackNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICPackageDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICPackageReceiptDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICPackageReceiptDate.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPackageSupplierNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtPackageType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPackageProductCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICPackageCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProducts)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private ICProductsGridControl fld_dgcICProducts;
        private Panel panel1;
        private BOSComponent.BOSTextBox fld_txtICPackageCount;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtICPackageProductCount;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtPackageType;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtICPackageSupplierNo;
        private BOSComponent.BOSLabel bosLabel4;
	}
}
