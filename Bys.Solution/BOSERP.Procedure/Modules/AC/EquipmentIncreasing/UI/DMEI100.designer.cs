using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.EquipmentIncreasing.UI
{
	/// <summary>
	/// Summary description for DMEI100
	/// </summary>
	partial class DMEI100
	{
		private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSLabel fld_lblLabel6;
		private BOSComponent.BOSLabel fld_lblLabel7;
		private BOSComponent.BOSTextBox fld_txtICShipmentNo1;
		private BOSComponent.BOSDateEdit fld_dteICShipmentDate2;
		private BOSComponent.BOSMemoEdit fld_medICShipmentDesc;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMEI100));
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICShipmentNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteICShipmentDate2 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medICShipmentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteICShipmentEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcShipmentItems = new BOSERP.Modules.EquipmentIncreasing.ShipmentItemGridControl();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICShipmentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcShipmentItems)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(123, 14);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel5.TabIndex = 4;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Mã chứng từ";
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(402, 12);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel6.TabIndex = 5;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Ngày chứng từ";
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
            this.fld_lblLabel7.Location = new System.Drawing.Point(123, 38);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel7.TabIndex = 6;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Diễn giải";
            // 
            // fld_txtICShipmentNo1
            // 
            this.fld_txtICShipmentNo1.BOSComment = "";
            this.fld_txtICShipmentNo1.BOSDataMember = "ICShipmentNo";
            this.fld_txtICShipmentNo1.BOSDataSource = "ICShipments";
            this.fld_txtICShipmentNo1.BOSDescription = null;
            this.fld_txtICShipmentNo1.BOSError = null;
            this.fld_txtICShipmentNo1.BOSFieldGroup = "";
            this.fld_txtICShipmentNo1.BOSFieldRelation = "";
            this.fld_txtICShipmentNo1.BOSPrivilege = "";
            this.fld_txtICShipmentNo1.BOSPropertyName = "Text";
            this.fld_txtICShipmentNo1.EditValue = "";
            this.fld_txtICShipmentNo1.Location = new System.Drawing.Point(214, 9);
            this.fld_txtICShipmentNo1.Name = "fld_txtICShipmentNo1";
            this.fld_txtICShipmentNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICShipmentNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICShipmentNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICShipmentNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICShipmentNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICShipmentNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICShipmentNo1.Screen = null;
            this.fld_txtICShipmentNo1.Size = new System.Drawing.Size(151, 20);
            this.fld_txtICShipmentNo1.TabIndex = 7;
            this.fld_txtICShipmentNo1.Tag = "DC";
            // 
            // fld_dteICShipmentDate2
            // 
            this.fld_dteICShipmentDate2.BOSComment = "";
            this.fld_dteICShipmentDate2.BOSDataMember = "ICShipmentDate";
            this.fld_dteICShipmentDate2.BOSDataSource = "ICShipments";
            this.fld_dteICShipmentDate2.BOSDescription = null;
            this.fld_dteICShipmentDate2.BOSError = null;
            this.fld_dteICShipmentDate2.BOSFieldGroup = "";
            this.fld_dteICShipmentDate2.BOSFieldRelation = "";
            this.fld_dteICShipmentDate2.BOSPrivilege = "";
            this.fld_dteICShipmentDate2.BOSPropertyName = "EditValue";
            this.fld_dteICShipmentDate2.EditValue = null;
            this.fld_dteICShipmentDate2.Location = new System.Drawing.Point(494, 9);
            this.fld_dteICShipmentDate2.Name = "fld_dteICShipmentDate2";
            this.fld_dteICShipmentDate2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICShipmentDate2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICShipmentDate2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICShipmentDate2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICShipmentDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICShipmentDate2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICShipmentDate2.Screen = null;
            this.fld_dteICShipmentDate2.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICShipmentDate2.TabIndex = 8;
            this.fld_dteICShipmentDate2.Tag = "DC";
            // 
            // fld_medICShipmentDesc
            // 
            this.fld_medICShipmentDesc.BOSComment = "";
            this.fld_medICShipmentDesc.BOSDataMember = "ICShipmentDesc";
            this.fld_medICShipmentDesc.BOSDataSource = "ICShipments";
            this.fld_medICShipmentDesc.BOSDescription = null;
            this.fld_medICShipmentDesc.BOSError = null;
            this.fld_medICShipmentDesc.BOSFieldGroup = "";
            this.fld_medICShipmentDesc.BOSFieldRelation = "";
            this.fld_medICShipmentDesc.BOSPrivilege = "";
            this.fld_medICShipmentDesc.BOSPropertyName = "Text";
            this.fld_medICShipmentDesc.EditValue = "";
            this.fld_medICShipmentDesc.Location = new System.Drawing.Point(214, 35);
            this.fld_medICShipmentDesc.Name = "fld_medICShipmentDesc";
            this.fld_medICShipmentDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICShipmentDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICShipmentDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICShipmentDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICShipmentDesc.Screen = null;
            this.fld_medICShipmentDesc.Size = new System.Drawing.Size(430, 61);
            this.fld_medICShipmentDesc.TabIndex = 9;
            this.fld_medICShipmentDesc.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = "";
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ICShipments";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(3, 102);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 10;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
            // 
            // fld_pteICShipmentEmployeePicture
            // 
            this.fld_pteICShipmentEmployeePicture.BOSComment = null;
            this.fld_pteICShipmentEmployeePicture.BOSDataMember = "ICShipmentEmployeePicture";
            this.fld_pteICShipmentEmployeePicture.BOSDataSource = "ICShipments";
            this.fld_pteICShipmentEmployeePicture.BOSDescription = null;
            this.fld_pteICShipmentEmployeePicture.BOSError = null;
            this.fld_pteICShipmentEmployeePicture.BOSFieldGroup = null;
            this.fld_pteICShipmentEmployeePicture.BOSFieldRelation = null;
            this.fld_pteICShipmentEmployeePicture.BOSPrivilege = null;
            this.fld_pteICShipmentEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteICShipmentEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteICShipmentEmployeePicture.FileName = null;
            this.fld_pteICShipmentEmployeePicture.FilePath = null;
            this.fld_pteICShipmentEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteICShipmentEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteICShipmentEmployeePicture.Name = "fld_pteICShipmentEmployeePicture";
            this.fld_pteICShipmentEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICShipmentEmployeePicture.Screen = null;
            this.fld_pteICShipmentEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteICShipmentEmployeePicture.TabIndex = 11;
            this.fld_pteICShipmentEmployeePicture.Tag = "DC";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ICProductID);
            this.bosGroupControl1.Controls.Add(this.fld_dgcShipmentItems);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 128);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(911, 381);
            this.bosGroupControl1.TabIndex = 12;
            this.bosGroupControl1.Text = "Danh sách CCDC";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkeFK_ICProductID.BOSComment = null;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "ICShipmentItems";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = "ICProductUsingMethod";
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = "SpecificEquipment";
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(72, 29);
            this.fld_lkeFK_ICProductID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(834, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 1;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeFK_ICProductID_KeyUp);
            // 
            // fld_dgcShipmentItems
            // 
            this.fld_dgcShipmentItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcShipmentItems.BOSComment = null;
            this.fld_dgcShipmentItems.BOSDataMember = null;
            this.fld_dgcShipmentItems.BOSDataSource = "ICShipmentItems";
            this.fld_dgcShipmentItems.BOSDescription = null;
            this.fld_dgcShipmentItems.BOSError = null;
            this.fld_dgcShipmentItems.BOSFieldGroup = null;
            this.fld_dgcShipmentItems.BOSFieldRelation = null;
            this.fld_dgcShipmentItems.BOSGridType = null;
            this.fld_dgcShipmentItems.BOSPrivilege = null;
            this.fld_dgcShipmentItems.BOSPropertyName = null;
            this.fld_dgcShipmentItems.CommodityType = "";
            this.fld_dgcShipmentItems.Location = new System.Drawing.Point(11, 55);
            this.fld_dgcShipmentItems.MenuManager = this.screenToolbar;
            this.fld_dgcShipmentItems.Name = "fld_dgcShipmentItems";
            this.fld_dgcShipmentItems.PrintReport = false;
            this.fld_dgcShipmentItems.Screen = null;
            this.fld_dgcShipmentItems.Size = new System.Drawing.Size(895, 320);
            this.fld_dgcShipmentItems.TabIndex = 0;
            this.fld_dgcShipmentItems.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(11, 32);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(28, 13);
            this.bosLabel1.TabIndex = 6;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "CCDC";
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
            this.bosPanel1.Controls.Add(this.fld_pteICShipmentEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.fld_medICShipmentDesc);
            this.bosPanel1.Controls.Add(this.fld_dteICShipmentDate2);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentNo1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(917, 517);
            this.bosPanel1.TabIndex = 13;
            // 
            // DMEI100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(917, 517);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMEI100.IconOptions.Icon")));
            this.Name = "DMEI100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICShipmentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcShipmentItems)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPictureEdit fld_pteICShipmentEmployeePicture;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
        private ShipmentItemGridControl fld_dgcShipmentItems;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSPanel bosPanel1;
	}
}
