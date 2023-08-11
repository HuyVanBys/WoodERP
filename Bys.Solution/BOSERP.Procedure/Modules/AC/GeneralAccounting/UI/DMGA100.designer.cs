using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.GeneralAccounting.UI
{
	/// <summary>
	/// Summary description for DMGA100
	/// </summary>
	partial class DMGA100
	{
		private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
		private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSLabel fld_lblLabel5;
		private BOSComponent.BOSMemoEdit fld_medACDocumentDesc;
		private BOSComponent.BOSLabel fld_lblLabel6;
		private BOSComponent.BOSTextBox fld_txtACDocumentNo1;
        private BOSComponent.BOSDateEdit fld_dteACDocumentDate2;


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
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_medACDocumentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACDocumentNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteACDocumentDate2 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_pteACDocumentEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_dteACDocumentPaymentDueDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteACDocumentInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnRefresh = new BOSComponent.BOSButton(this.components);
            this.fld_tabControl = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageBriefDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_tabPageACAllocationEquipmentTrans = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACAllocationEquipmentTrans = new BOSERP.Modules.GeneralAccounting.ACAllocationEquipmentTransGridControl();
            this.fld_tabPageACDepreciationAssetTrans = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDepreciationAssetTrans = new BOSERP.Modules.GeneralAccounting.ACDepreciationAssetTransGridControl();
            this.fld_tabPageACAllocationCostObjectTrans = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACAllocationCostObjectTrans = new BOSERP.Modules.GeneralAccounting.ACAllocationCostObjectTransGridControl();
            this.fld_tabPageDocumentEntrys = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcDocumentEntryGridControl = new BOSERP.Modules.GeneralAccounting.DocumentEntryGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACDocumentDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACDocumentEmployeePicture.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentPaymentDueDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentPaymentDueDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentInvoiceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabControl)).BeginInit();
            this.fld_tabControl.SuspendLayout();
            this.fld_tabPageBriefDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).BeginInit();
            this.fld_tabPageACAllocationEquipmentTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACAllocationEquipmentTrans)).BeginInit();
            this.fld_tabPageACDepreciationAssetTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDepreciationAssetTrans)).BeginInit();
            this.fld_tabPageACAllocationCostObjectTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACAllocationCostObjectTrans)).BeginInit();
            this.fld_tabPageDocumentEntrys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntryGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = "";
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ACDocuments";
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
            this.fld_lblLabel4.Location = new System.Drawing.Point(127, 18);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel4.TabIndex = 5;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Mã chứng từ";
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
            this.fld_lblLabel5.Location = new System.Drawing.Point(388, 18);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel5.TabIndex = 6;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Ngày chứng từ";
            // 
            // fld_medACDocumentDesc
            // 
            this.fld_medACDocumentDesc.BOSComment = "";
            this.fld_medACDocumentDesc.BOSDataMember = "ACDocumentDesc";
            this.fld_medACDocumentDesc.BOSDataSource = "ACDocuments";
            this.fld_medACDocumentDesc.BOSDescription = null;
            this.fld_medACDocumentDesc.BOSError = null;
            this.fld_medACDocumentDesc.BOSFieldGroup = "";
            this.fld_medACDocumentDesc.BOSFieldRelation = "";
            this.fld_medACDocumentDesc.BOSPrivilege = "";
            this.fld_medACDocumentDesc.BOSPropertyName = "Text";
            this.fld_medACDocumentDesc.EditValue = "";
            this.fld_medACDocumentDesc.Location = new System.Drawing.Point(213, 66);
            this.fld_medACDocumentDesc.Name = "fld_medACDocumentDesc";
            this.fld_medACDocumentDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACDocumentDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACDocumentDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACDocumentDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACDocumentDesc.Screen = null;
            this.fld_medACDocumentDesc.Size = new System.Drawing.Size(415, 38);
            this.fld_medACDocumentDesc.TabIndex = 3;
            this.fld_medACDocumentDesc.Tag = "DC";
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
            this.fld_lblLabel6.Location = new System.Drawing.Point(127, 69);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel6.TabIndex = 8;
            this.fld_lblLabel6.Tag = "";
            this.fld_lblLabel6.Text = "Diễn giải";
            // 
            // fld_txtACDocumentNo1
            // 
            this.fld_txtACDocumentNo1.BOSComment = "";
            this.fld_txtACDocumentNo1.BOSDataMember = "ACDocumentNo";
            this.fld_txtACDocumentNo1.BOSDataSource = "ACDocuments";
            this.fld_txtACDocumentNo1.BOSDescription = null;
            this.fld_txtACDocumentNo1.BOSError = null;
            this.fld_txtACDocumentNo1.BOSFieldGroup = "";
            this.fld_txtACDocumentNo1.BOSFieldRelation = "";
            this.fld_txtACDocumentNo1.BOSPrivilege = "";
            this.fld_txtACDocumentNo1.BOSPropertyName = "Text";
            this.fld_txtACDocumentNo1.EditValue = "";
            this.fld_txtACDocumentNo1.Location = new System.Drawing.Point(213, 14);
            this.fld_txtACDocumentNo1.Name = "fld_txtACDocumentNo1";
            this.fld_txtACDocumentNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACDocumentNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACDocumentNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACDocumentNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACDocumentNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACDocumentNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACDocumentNo1.Screen = null;
            this.fld_txtACDocumentNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACDocumentNo1.TabIndex = 1;
            this.fld_txtACDocumentNo1.Tag = "DC";
            // 
            // fld_dteACDocumentDate2
            // 
            this.fld_dteACDocumentDate2.BOSComment = "";
            this.fld_dteACDocumentDate2.BOSDataMember = "ACDocumentDate";
            this.fld_dteACDocumentDate2.BOSDataSource = "ACDocuments";
            this.fld_dteACDocumentDate2.BOSDescription = null;
            this.fld_dteACDocumentDate2.BOSError = null;
            this.fld_dteACDocumentDate2.BOSFieldGroup = "";
            this.fld_dteACDocumentDate2.BOSFieldRelation = "";
            this.fld_dteACDocumentDate2.BOSPrivilege = "";
            this.fld_dteACDocumentDate2.BOSPropertyName = "EditValue";
            this.fld_dteACDocumentDate2.EditValue = null;
            this.fld_dteACDocumentDate2.Location = new System.Drawing.Point(478, 14);
            this.fld_dteACDocumentDate2.Name = "fld_dteACDocumentDate2";
            this.fld_dteACDocumentDate2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACDocumentDate2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACDocumentDate2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACDocumentDate2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACDocumentDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACDocumentDate2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACDocumentDate2.Screen = null;
            this.fld_dteACDocumentDate2.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACDocumentDate2.TabIndex = 2;
            this.fld_dteACDocumentDate2.Tag = "DC";
            this.fld_dteACDocumentDate2.Validated += new System.EventHandler(this.fld_dteACDocumentDate2_Validated);
            // 
            // fld_pteACDocumentEmployeePicture
            // 
            this.fld_pteACDocumentEmployeePicture.BOSComment = null;
            this.fld_pteACDocumentEmployeePicture.BOSDataMember = "ACDocumentEmployeePicture";
            this.fld_pteACDocumentEmployeePicture.BOSDataSource = "ACDocuments";
            this.fld_pteACDocumentEmployeePicture.BOSDescription = null;
            this.fld_pteACDocumentEmployeePicture.BOSError = null;
            this.fld_pteACDocumentEmployeePicture.BOSFieldGroup = null;
            this.fld_pteACDocumentEmployeePicture.BOSFieldRelation = null;
            this.fld_pteACDocumentEmployeePicture.BOSPrivilege = null;
            this.fld_pteACDocumentEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteACDocumentEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteACDocumentEmployeePicture.FileName = null;
            this.fld_pteACDocumentEmployeePicture.FilePath = null;
            this.fld_pteACDocumentEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteACDocumentEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteACDocumentEmployeePicture.Name = "fld_pteACDocumentEmployeePicture";
            this.fld_pteACDocumentEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteACDocumentEmployeePicture.Screen = null;
            this.fld_pteACDocumentEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteACDocumentEmployeePicture.TabIndex = 11;
            this.fld_pteACDocumentEmployeePicture.Tag = "DC";
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
            this.bosPanel1.Controls.Add(this.fld_dteACDocumentPaymentDueDate);
            this.bosPanel1.Controls.Add(this.fld_dteACDocumentInvoiceDate);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_btnRefresh);
            this.bosPanel1.Controls.Add(this.fld_tabControl);
            this.bosPanel1.Controls.Add(this.fld_pteACDocumentEmployeePicture);
            this.bosPanel1.Controls.Add(this.fld_dteACDocumentDate2);
            this.bosPanel1.Controls.Add(this.fld_txtACDocumentNo1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel6);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_medACDocumentDesc);
            this.bosPanel1.Controls.Add(this.fld_lblLabel5);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(914, 597);
            this.bosPanel1.TabIndex = 13;
            // 
            // fld_dteACDocumentPaymentDueDate
            // 
            this.fld_dteACDocumentPaymentDueDate.BOSComment = "";
            this.fld_dteACDocumentPaymentDueDate.BOSDataMember = "ACDocumentPaymentDueDate";
            this.fld_dteACDocumentPaymentDueDate.BOSDataSource = "ACDocuments";
            this.fld_dteACDocumentPaymentDueDate.BOSDescription = null;
            this.fld_dteACDocumentPaymentDueDate.BOSError = null;
            this.fld_dteACDocumentPaymentDueDate.BOSFieldGroup = "";
            this.fld_dteACDocumentPaymentDueDate.BOSFieldRelation = "";
            this.fld_dteACDocumentPaymentDueDate.BOSPrivilege = "";
            this.fld_dteACDocumentPaymentDueDate.BOSPropertyName = "EditValue";
            this.fld_dteACDocumentPaymentDueDate.EditValue = null;
            this.fld_dteACDocumentPaymentDueDate.Location = new System.Drawing.Point(478, 40);
            this.fld_dteACDocumentPaymentDueDate.Name = "fld_dteACDocumentPaymentDueDate";
            this.fld_dteACDocumentPaymentDueDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACDocumentPaymentDueDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACDocumentPaymentDueDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACDocumentPaymentDueDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACDocumentPaymentDueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACDocumentPaymentDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACDocumentPaymentDueDate.Screen = null;
            this.fld_dteACDocumentPaymentDueDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACDocumentPaymentDueDate.TabIndex = 31;
            this.fld_dteACDocumentPaymentDueDate.Tag = "DC";
            // 
            // fld_dteACDocumentInvoiceDate
            // 
            this.fld_dteACDocumentInvoiceDate.BOSComment = "";
            this.fld_dteACDocumentInvoiceDate.BOSDataMember = "ACDocumentInvoiceDate";
            this.fld_dteACDocumentInvoiceDate.BOSDataSource = "ACDocuments";
            this.fld_dteACDocumentInvoiceDate.BOSDescription = null;
            this.fld_dteACDocumentInvoiceDate.BOSError = null;
            this.fld_dteACDocumentInvoiceDate.BOSFieldGroup = "";
            this.fld_dteACDocumentInvoiceDate.BOSFieldRelation = "";
            this.fld_dteACDocumentInvoiceDate.BOSPrivilege = "";
            this.fld_dteACDocumentInvoiceDate.BOSPropertyName = "EditValue";
            this.fld_dteACDocumentInvoiceDate.EditValue = null;
            this.fld_dteACDocumentInvoiceDate.Location = new System.Drawing.Point(213, 40);
            this.fld_dteACDocumentInvoiceDate.Name = "fld_dteACDocumentInvoiceDate";
            this.fld_dteACDocumentInvoiceDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACDocumentInvoiceDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACDocumentInvoiceDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACDocumentInvoiceDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACDocumentInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACDocumentInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACDocumentInvoiceDate.Screen = null;
            this.fld_dteACDocumentInvoiceDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACDocumentInvoiceDate.TabIndex = 30;
            this.fld_dteACDocumentInvoiceDate.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(388, 43);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(47, 13);
            this.bosLabel3.TabIndex = 27;
            this.bosLabel3.Text = "Đến ngày";
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
            this.bosLabel1.Location = new System.Drawing.Point(127, 43);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 29;
            this.bosLabel1.Text = "Từ ngày";
            // 
            // fld_btnRefresh
            // 
            this.fld_btnRefresh.BOSComment = null;
            this.fld_btnRefresh.BOSDataMember = null;
            this.fld_btnRefresh.BOSDataSource = null;
            this.fld_btnRefresh.BOSDescription = null;
            this.fld_btnRefresh.BOSError = null;
            this.fld_btnRefresh.BOSFieldGroup = null;
            this.fld_btnRefresh.BOSFieldRelation = null;
            this.fld_btnRefresh.BOSPrivilege = null;
            this.fld_btnRefresh.BOSPropertyName = null;
            this.fld_btnRefresh.Location = new System.Drawing.Point(644, 12);
            this.fld_btnRefresh.Name = "fld_btnRefresh";
            this.fld_btnRefresh.Screen = null;
            this.fld_btnRefresh.Size = new System.Drawing.Size(75, 27);
            this.fld_btnRefresh.TabIndex = 26;
            this.fld_btnRefresh.Text = "Tính";
            this.fld_btnRefresh.Click += new System.EventHandler(this.fld_btnRefresh_Click);
            // 
            // fld_tabControl
            // 
            this.fld_tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabControl.BOSComment = null;
            this.fld_tabControl.BOSDataMember = null;
            this.fld_tabControl.BOSDataSource = null;
            this.fld_tabControl.BOSDescription = null;
            this.fld_tabControl.BOSError = null;
            this.fld_tabControl.BOSFieldGroup = null;
            this.fld_tabControl.BOSFieldRelation = null;
            this.fld_tabControl.BOSPrivilege = null;
            this.fld_tabControl.BOSPropertyName = null;
            this.fld_tabControl.Location = new System.Drawing.Point(0, 128);
            this.fld_tabControl.Name = "fld_tabControl";
            this.fld_tabControl.Screen = null;
            this.fld_tabControl.SelectedTabPage = this.fld_tabPageBriefDocumentEntrys;
            this.fld_tabControl.Size = new System.Drawing.Size(911, 466);
            this.fld_tabControl.TabIndex = 13;
            this.fld_tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageACAllocationEquipmentTrans,
            this.fld_tabPageACDepreciationAssetTrans,
            this.fld_tabPageACAllocationCostObjectTrans,
            this.fld_tabPageBriefDocumentEntrys,
            this.fld_tabPageDocumentEntrys});
            this.fld_tabControl.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.fld_tabControl_SelectedPageChanged);
            // 
            // fld_tabPageBriefDocumentEntrys
            // 
            this.fld_tabPageBriefDocumentEntrys.Controls.Add(this.fld_dgcDocumentEntrys);
            this.fld_tabPageBriefDocumentEntrys.Name = "fld_tabPageBriefDocumentEntrys";
            this.fld_tabPageBriefDocumentEntrys.Size = new System.Drawing.Size(905, 438);
            this.fld_tabPageBriefDocumentEntrys.Text = "Danh sách hạch toán chi tiết";
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
            this.fld_dgcDocumentEntrys.Size = new System.Drawing.Size(905, 438);
            this.fld_dgcDocumentEntrys.TabIndex = 1;
            this.fld_dgcDocumentEntrys.Tag = "DC";
            // 
            // fld_tabPageACAllocationEquipmentTrans
            // 
            this.fld_tabPageACAllocationEquipmentTrans.Controls.Add(this.fld_dgcACAllocationEquipmentTrans);
            this.fld_tabPageACAllocationEquipmentTrans.Name = "fld_tabPageACAllocationEquipmentTrans";
            this.fld_tabPageACAllocationEquipmentTrans.Size = new System.Drawing.Size(899, 431);
            this.fld_tabPageACAllocationEquipmentTrans.Text = "Phân bổ CCDC";
            // 
            // fld_dgcACAllocationEquipmentTrans
            // 
            this.fld_dgcACAllocationEquipmentTrans.BOSComment = null;
            this.fld_dgcACAllocationEquipmentTrans.BOSDataMember = null;
            this.fld_dgcACAllocationEquipmentTrans.BOSDataSource = "ACAllocationEquipmentTrans";
            this.fld_dgcACAllocationEquipmentTrans.BOSDescription = null;
            this.fld_dgcACAllocationEquipmentTrans.BOSError = null;
            this.fld_dgcACAllocationEquipmentTrans.BOSFieldGroup = null;
            this.fld_dgcACAllocationEquipmentTrans.BOSFieldRelation = null;
            this.fld_dgcACAllocationEquipmentTrans.BOSGridType = null;
            this.fld_dgcACAllocationEquipmentTrans.BOSPrivilege = null;
            this.fld_dgcACAllocationEquipmentTrans.BOSPropertyName = null;
            this.fld_dgcACAllocationEquipmentTrans.CommodityType = "";
            this.fld_dgcACAllocationEquipmentTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACAllocationEquipmentTrans.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACAllocationEquipmentTrans.MenuManager = this.screenToolbar;
            this.fld_dgcACAllocationEquipmentTrans.Name = "fld_dgcACAllocationEquipmentTrans";
            this.fld_dgcACAllocationEquipmentTrans.PrintReport = false;
            this.fld_dgcACAllocationEquipmentTrans.Screen = null;
            this.fld_dgcACAllocationEquipmentTrans.Size = new System.Drawing.Size(899, 431);
            this.fld_dgcACAllocationEquipmentTrans.TabIndex = 3;
            this.fld_dgcACAllocationEquipmentTrans.Tag = "DC";
            // 
            // fld_tabPageACDepreciationAssetTrans
            // 
            this.fld_tabPageACDepreciationAssetTrans.Controls.Add(this.fld_dgcACDepreciationAssetTrans);
            this.fld_tabPageACDepreciationAssetTrans.Name = "fld_tabPageACDepreciationAssetTrans";
            this.fld_tabPageACDepreciationAssetTrans.Size = new System.Drawing.Size(899, 431);
            this.fld_tabPageACDepreciationAssetTrans.Text = "Khấu hao TSCĐ";
            // 
            // fld_dgcACDepreciationAssetTrans
            // 
            this.fld_dgcACDepreciationAssetTrans.BOSComment = null;
            this.fld_dgcACDepreciationAssetTrans.BOSDataMember = null;
            this.fld_dgcACDepreciationAssetTrans.BOSDataSource = "ACDepreciationAssetTrans";
            this.fld_dgcACDepreciationAssetTrans.BOSDescription = null;
            this.fld_dgcACDepreciationAssetTrans.BOSError = null;
            this.fld_dgcACDepreciationAssetTrans.BOSFieldGroup = null;
            this.fld_dgcACDepreciationAssetTrans.BOSFieldRelation = null;
            this.fld_dgcACDepreciationAssetTrans.BOSGridType = null;
            this.fld_dgcACDepreciationAssetTrans.BOSPrivilege = null;
            this.fld_dgcACDepreciationAssetTrans.BOSPropertyName = null;
            this.fld_dgcACDepreciationAssetTrans.CommodityType = "";
            this.fld_dgcACDepreciationAssetTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACDepreciationAssetTrans.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACDepreciationAssetTrans.MenuManager = this.screenToolbar;
            this.fld_dgcACDepreciationAssetTrans.Name = "fld_dgcACDepreciationAssetTrans";
            this.fld_dgcACDepreciationAssetTrans.PrintReport = false;
            this.fld_dgcACDepreciationAssetTrans.Screen = null;
            this.fld_dgcACDepreciationAssetTrans.Size = new System.Drawing.Size(899, 431);
            this.fld_dgcACDepreciationAssetTrans.TabIndex = 2;
            this.fld_dgcACDepreciationAssetTrans.Tag = "DC";
            // 
            // fld_tabPageACAllocationCostObjectTrans
            // 
            this.fld_tabPageACAllocationCostObjectTrans.Controls.Add(this.fld_dgcACAllocationCostObjectTrans);
            this.fld_tabPageACAllocationCostObjectTrans.Name = "fld_tabPageACAllocationCostObjectTrans";
            this.fld_tabPageACAllocationCostObjectTrans.Size = new System.Drawing.Size(905, 438);
            this.fld_tabPageACAllocationCostObjectTrans.Text = "Phân bổ chi phí";
            // 
            // fld_dgcACAllocationCostObjectTrans
            // 
            this.fld_dgcACAllocationCostObjectTrans.BOSComment = null;
            this.fld_dgcACAllocationCostObjectTrans.BOSDataMember = null;
            this.fld_dgcACAllocationCostObjectTrans.BOSDataSource = "ACAllocationCostObjectTrans";
            this.fld_dgcACAllocationCostObjectTrans.BOSDescription = null;
            this.fld_dgcACAllocationCostObjectTrans.BOSError = null;
            this.fld_dgcACAllocationCostObjectTrans.BOSFieldGroup = null;
            this.fld_dgcACAllocationCostObjectTrans.BOSFieldRelation = null;
            this.fld_dgcACAllocationCostObjectTrans.BOSGridType = null;
            this.fld_dgcACAllocationCostObjectTrans.BOSPrivilege = null;
            this.fld_dgcACAllocationCostObjectTrans.BOSPropertyName = null;
            this.fld_dgcACAllocationCostObjectTrans.CommodityType = "";
            this.fld_dgcACAllocationCostObjectTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACAllocationCostObjectTrans.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACAllocationCostObjectTrans.MenuManager = this.screenToolbar;
            this.fld_dgcACAllocationCostObjectTrans.Name = "fld_dgcACAllocationCostObjectTrans";
            this.fld_dgcACAllocationCostObjectTrans.PrintReport = false;
            this.fld_dgcACAllocationCostObjectTrans.Screen = null;
            this.fld_dgcACAllocationCostObjectTrans.Size = new System.Drawing.Size(905, 438);
            this.fld_dgcACAllocationCostObjectTrans.TabIndex = 4;
            this.fld_dgcACAllocationCostObjectTrans.Tag = "DC";
            // 
            // fld_tabPageDocumentEntrys
            // 
            this.fld_tabPageDocumentEntrys.Controls.Add(this.fld_dgcDocumentEntryGridControl);
            this.fld_tabPageDocumentEntrys.Name = "fld_tabPageDocumentEntrys";
            this.fld_tabPageDocumentEntrys.Size = new System.Drawing.Size(899, 431);
            this.fld_tabPageDocumentEntrys.Text = "Danh sách hạch toán chung";
            // 
            // fld_dgcDocumentEntryGridControl
            // 
            this.fld_dgcDocumentEntryGridControl.BOSComment = null;
            this.fld_dgcDocumentEntryGridControl.BOSDataMember = null;
            this.fld_dgcDocumentEntryGridControl.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcDocumentEntryGridControl.BOSDescription = null;
            this.fld_dgcDocumentEntryGridControl.BOSError = null;
            this.fld_dgcDocumentEntryGridControl.BOSFieldGroup = null;
            this.fld_dgcDocumentEntryGridControl.BOSFieldRelation = null;
            this.fld_dgcDocumentEntryGridControl.BOSGridType = null;
            this.fld_dgcDocumentEntryGridControl.BOSPrivilege = null;
            this.fld_dgcDocumentEntryGridControl.BOSPropertyName = null;
            this.fld_dgcDocumentEntryGridControl.CommodityType = "";
            this.fld_dgcDocumentEntryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcDocumentEntryGridControl.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcDocumentEntryGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcDocumentEntryGridControl.Name = "fld_dgcDocumentEntryGridControl";
            this.fld_dgcDocumentEntryGridControl.PrintReport = false;
            this.fld_dgcDocumentEntryGridControl.Screen = null;
            this.fld_dgcDocumentEntryGridControl.Size = new System.Drawing.Size(899, 431);
            this.fld_dgcDocumentEntryGridControl.TabIndex = 2;
            this.fld_dgcDocumentEntryGridControl.Tag = "DC";
            // 
            // DMGA100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(914, 597);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMGA100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACDocumentDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACDocumentNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentDate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteACDocumentEmployeePicture.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentPaymentDueDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentPaymentDueDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentInvoiceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACDocumentInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabControl)).EndInit();
            this.fld_tabControl.ResumeLayout(false);
            this.fld_tabPageBriefDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntrys)).EndInit();
            this.fld_tabPageACAllocationEquipmentTrans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACAllocationEquipmentTrans)).EndInit();
            this.fld_tabPageACDepreciationAssetTrans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDepreciationAssetTrans)).EndInit();
            this.fld_tabPageACAllocationCostObjectTrans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACAllocationCostObjectTrans)).EndInit();
            this.fld_tabPageDocumentEntrys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDocumentEntryGridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPictureEdit fld_pteACDocumentEmployeePicture;
        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSTabControl fld_tabControl;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageBriefDocumentEntrys;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageDocumentEntrys;
        private BaseDocumentEntryGridControl fld_dgcDocumentEntrys;
        private DocumentEntryGridControl fld_dgcDocumentEntryGridControl;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageACDepreciationAssetTrans;
        private ACDepreciationAssetTransGridControl fld_dgcACDepreciationAssetTrans;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageACAllocationEquipmentTrans;
        private ACAllocationEquipmentTransGridControl fld_dgcACAllocationEquipmentTrans;
        private BOSComponent.BOSButton fld_btnRefresh;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteACDocumentPaymentDueDate;
        private BOSComponent.BOSDateEdit fld_dteACDocumentInvoiceDate;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageACAllocationCostObjectTrans;
        private ACAllocationCostObjectTransGridControl fld_dgcACAllocationCostObjectTrans;
    }
}
