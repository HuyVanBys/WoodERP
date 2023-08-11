using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.EquipmentDecreasing.UI
{
	/// <summary>
	/// Summary description for DMED100
	/// </summary>
	partial class DMED100
	{
		private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
		private BOSComponent.BOSTextBox fld_txtICShipmentNo1;
		private BOSComponent.BOSDateEdit fld_dteICShipmentDate2;
		private BOSComponent.BOSMemoEdit fld_medICShipmentDesc;
		private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSLabel fld_lblLabel7;


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
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICShipmentNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteICShipmentDate2 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medICShipmentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteICShipmentEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dgcShipmentItems = new BOSERP.Modules.EquipmentDecreasing.ShipmentItemGridControl();
            this.fld_lkFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_ACAssObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICShipmentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcShipmentItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkFK_ICProductID.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            this.SuspendLayout();
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
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(3, 103);
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
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 4;
            this.fld_lkeFK_HREmployeeID1.Tag = "DC";
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
            this.fld_txtICShipmentNo1.Location = new System.Drawing.Point(196, 13);
            this.fld_txtICShipmentNo1.Name = "fld_txtICShipmentNo1";
            this.fld_txtICShipmentNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICShipmentNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICShipmentNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICShipmentNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICShipmentNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICShipmentNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICShipmentNo1.Screen = null;
            this.fld_txtICShipmentNo1.Size = new System.Drawing.Size(151, 20);
            this.fld_txtICShipmentNo1.TabIndex = 0;
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
            this.fld_dteICShipmentDate2.Location = new System.Drawing.Point(491, 13);
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
            this.fld_dteICShipmentDate2.TabIndex = 1;
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
            this.fld_medICShipmentDesc.Location = new System.Drawing.Point(196, 65);
            this.fld_medICShipmentDesc.Name = "fld_medICShipmentDesc";
            this.fld_medICShipmentDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICShipmentDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICShipmentDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICShipmentDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICShipmentDesc.Screen = null;
            this.fld_medICShipmentDesc.Size = new System.Drawing.Size(617, 36);
            this.fld_medICShipmentDesc.TabIndex = 3;
            this.fld_medICShipmentDesc.Tag = "DC";
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(117, 16);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel5.TabIndex = 8;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Mã chứng từ";
            this.fld_lblLabel5.Click += new System.EventHandler(this.fld_lblLabel5_Click);
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(399, 16);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel6.TabIndex = 9;
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
            this.fld_lblLabel7.Location = new System.Drawing.Point(117, 68);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel7.TabIndex = 10;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Diễn giải";
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
            this.fld_pteICShipmentEmployeePicture.Location = new System.Drawing.Point(3, 4);
            this.fld_pteICShipmentEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteICShipmentEmployeePicture.Name = "fld_pteICShipmentEmployeePicture";
            this.fld_pteICShipmentEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteICShipmentEmployeePicture.Screen = null;
            this.fld_pteICShipmentEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteICShipmentEmployeePicture.TabIndex = 11;
            this.fld_pteICShipmentEmployeePicture.Tag = "DC";
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
            this.fld_dgcShipmentItems.Location = new System.Drawing.Point(12, 35);
            this.fld_dgcShipmentItems.MenuManager = this.screenToolbar;
            this.fld_dgcShipmentItems.Name = "fld_dgcShipmentItems";
            this.fld_dgcShipmentItems.PrintReport = false;
            this.fld_dgcShipmentItems.Screen = null;
            this.fld_dgcShipmentItems.Size = new System.Drawing.Size(795, 273);
            this.fld_dgcShipmentItems.TabIndex = 11;
            this.fld_dgcShipmentItems.Tag = "DC";
            // 
            // fld_lkFK_ICProductID
            // 
            this.fld_lkFK_ICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkFK_ICProductID.BOSAllowDummy = false;
            this.fld_lkFK_ICProductID.BOSComment = null;
            this.fld_lkFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkFK_ICProductID.BOSDataSource = "ICShipmentItems";
            this.fld_lkFK_ICProductID.BOSDescription = null;
            this.fld_lkFK_ICProductID.BOSError = null;
            this.fld_lkFK_ICProductID.BOSFieldGroup = null;
            this.fld_lkFK_ICProductID.BOSFieldParent = null;
            this.fld_lkFK_ICProductID.BOSFieldRelation = null;
            this.fld_lkFK_ICProductID.BOSPrivilege = null;
            this.fld_lkFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkFK_ICProductID.BOSSelectType = "ICProductType";
            this.fld_lkFK_ICProductID.BOSSelectTypeValue = "Equipment";
            this.fld_lkFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkFK_ICProductID.Enabled = false;
            this.fld_lkFK_ICProductID.Location = new System.Drawing.Point(62, 9);
            this.fld_lkFK_ICProductID.MenuManager = this.screenToolbar;
            this.fld_lkFK_ICProductID.Name = "fld_lkFK_ICProductID";
            this.fld_lkFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkFK_ICProductID.Properties.ColumnName = null;
            this.fld_lkFK_ICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkFK_ICProductID.Screen = null;
            this.fld_lkFK_ICProductID.Size = new System.Drawing.Size(745, 20);
            this.fld_lkFK_ICProductID.TabIndex = 0;
            this.fld_lkFK_ICProductID.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(12, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(28, 13);
            this.bosLabel1.TabIndex = 10;
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACAssObjectID);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.fld_pteICShipmentEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_lblLabel7);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Controls.Add(this.fld_txtICShipmentNo1);
            this.bosPanel1.Controls.Add(this.fld_medICShipmentDesc);
            this.bosPanel1.Controls.Add(this.fld_dteICShipmentDate2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(825, 472);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeFK_ACAssObjectID
            // 
            this.fld_lkeFK_ACAssObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAssObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACAssObjectID.BOSComment = null;
            this.fld_lkeFK_ACAssObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACAssObjectID.BOSDataSource = "ICShipments";
            this.fld_lkeFK_ACAssObjectID.BOSDescription = null;
            this.fld_lkeFK_ACAssObjectID.BOSError = null;
            this.fld_lkeFK_ACAssObjectID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAssObjectID.BOSFieldParent = null;
            this.fld_lkeFK_ACAssObjectID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAssObjectID.BOSModuleType = null;
            this.fld_lkeFK_ACAssObjectID.BOSPrivilege = null;
            this.fld_lkeFK_ACAssObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAssObjectID.BOSSelectType = null;
            this.fld_lkeFK_ACAssObjectID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAssObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAssObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeFK_ACAssObjectID.Location = new System.Drawing.Point(197, 39);
            this.fld_lkeFK_ACAssObjectID.Name = "fld_lkeFK_ACAssObjectID";
            this.fld_lkeFK_ACAssObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAssObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAssObjectID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ACAssObjectID, true);
            this.fld_lkeFK_ACAssObjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACAssObjectID.TabIndex = 2;
            this.fld_lkeFK_ACAssObjectID.Tag = "DC";
            this.fld_lkeFK_ACAssObjectID.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_lkeFK_ACAssObjectID_Closed);
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Location = new System.Drawing.Point(3, 129);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.bosTabControl1.Size = new System.Drawing.Size(816, 340);
            this.bosTabControl1.TabIndex = 4;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcDocumentEntrys);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(810, 312);
            this.xtraTabPage2.Text = "Hạch toán";
            // 
            // fld_dgcDocumentEntrys
            // 
            this.fld_dgcDocumentEntrys.BOSComment = null;
            this.fld_dgcDocumentEntrys.BOSDataMember = null;
            this.fld_dgcDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcDocumentEntrys.BOSDescription = null;
            this.fld_dgcDocumentEntrys.BOSError = null;
            this.fld_dgcDocumentEntrys.BOSFieldGroup = null;
            this.fld_dgcDocumentEntrys.BOSFieldRelation = null;
            this.fld_dgcDocumentEntrys.BOSGridType = null;
            this.fld_dgcDocumentEntrys.BOSPrivilege = null;
            this.fld_dgcDocumentEntrys.BOSPropertyName = null;
            this.fld_dgcDocumentEntrys.CommodityType = "";
            this.fld_dgcDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcDocumentEntrys.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcDocumentEntrys.MenuManager = this.screenToolbar;
            this.fld_dgcDocumentEntrys.Name = "fld_dgcDocumentEntrys";
            this.fld_dgcDocumentEntrys.PrintReport = false;
            this.fld_dgcDocumentEntrys.Screen = null;
            this.fld_dgcDocumentEntrys.Size = new System.Drawing.Size(810, 312);
            this.fld_dgcDocumentEntrys.TabIndex = 0;
            this.fld_dgcDocumentEntrys.Tag = "DC";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcShipmentItems);
            this.xtraTabPage1.Controls.Add(this.bosLabel1);
            this.xtraTabPage1.Controls.Add(this.fld_lkFK_ICProductID);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(810, 312);
            this.xtraTabPage1.Text = "Danh sách CCDC";
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
            this.bosLabel2.Location = new System.Drawing.Point(117, 42);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 8;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Đối tượng";
            this.bosLabel2.Click += new System.EventHandler(this.fld_lblLabel5_Click);
            // 
            // DMED100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(825, 472);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMED100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICShipmentNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICShipmentDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICShipmentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteICShipmentEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcShipmentItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkFK_ICProductID.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAssObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPictureEdit fld_pteICShipmentEmployeePicture;
        private BOSComponent.BOSLookupEdit fld_lkFK_ICProductID;
        private BOSComponent.BOSLabel bosLabel1;
        private ShipmentItemGridControl fld_dgcShipmentItems;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BaseDocumentEntryGridControl fld_dgcDocumentEntrys;
        private AccObjectLookupEdit fld_lkeFK_ACAssObjectID;
        private BOSComponent.BOSLabel bosLabel2;
	}
}
