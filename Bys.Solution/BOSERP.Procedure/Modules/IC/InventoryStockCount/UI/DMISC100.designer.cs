using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.InventoryStockCount.UI
{
	/// <summary>
	/// Summary description for DMISC100
	/// </summary>
	partial class DMISC100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMISC100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_grcGroupControl5 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_ccbeICInventoryStockCountEmployeeInspector = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.fld_ccbeICInventoryStockCountEmployeeRepresentatives = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICInventoryStockCountStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_medICInventoryStockCountRemark = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICInventoryStockCountNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICInventoryStockCountName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteICInventoryStockCountDate = new BOSComponent.BOSDateEdit(this.components);
            this.groupStock = new BOSComponent.BOSGroupControl(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnImportExcel = new BOSComponent.BOSButton(this.components);
            this.fld_lkeICInventoryStockCountType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_bedICProductGroupID = new BOSComponent.BOSButtonEdit(this.components);
            this.fld_btnStockQuantity = new BOSComponent.BOSButton(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_FK_ICStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcICInventoryStockCountItems = new BOSERP.Modules.InventoryStockCount.InventoryStockCountsGridControl();
            this.bosPanel4 = new BOSComponent.BOSPanel(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACDocumentEntrys = new BOSERP.BaseDocumentEntryGridControl();
            this.fld_dgvACDocumentEntrys = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).BeginInit();
            this.fld_grcGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ccbeICInventoryStockCountEmployeeInspector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ccbeICInventoryStockCountEmployeeRepresentatives.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICInventoryStockCountStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICInventoryStockCountRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICInventoryStockCountNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICInventoryStockCountName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICInventoryStockCountDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICInventoryStockCountDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupStock)).BeginInit();
            this.groupStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICInventoryStockCountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_FK_ICStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICInventoryStockCountItems)).BeginInit();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl5);
            this.bosPanel1.Controls.Add(this.groupStock);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1101, 196);
            this.bosPanel1.TabIndex = 0;
            this.bosPanel1.Tag = "DC";
            // 
            // fld_grcGroupControl5
            // 
            this.fld_grcGroupControl5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl5.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl5.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl5.BOSComment = "";
            this.fld_grcGroupControl5.BOSDataMember = "";
            this.fld_grcGroupControl5.BOSDataSource = "";
            this.fld_grcGroupControl5.BOSDescription = null;
            this.fld_grcGroupControl5.BOSError = null;
            this.fld_grcGroupControl5.BOSFieldGroup = "";
            this.fld_grcGroupControl5.BOSFieldRelation = "";
            this.fld_grcGroupControl5.BOSPrivilege = "";
            this.fld_grcGroupControl5.BOSPropertyName = "";
            this.fld_grcGroupControl5.Controls.Add(this.fld_ccbeICInventoryStockCountEmployeeInspector);
            this.fld_grcGroupControl5.Controls.Add(this.fld_ccbeICInventoryStockCountEmployeeRepresentatives);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel9);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel8);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeICInventoryStockCountStatus);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl5.Controls.Add(this.fld_medICInventoryStockCountRemark);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel7);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICInventoryStockCountNo);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel6);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtICInventoryStockCountName);
            this.fld_grcGroupControl5.Controls.Add(this.fld_dteICInventoryStockCountDate);
            this.fld_grcGroupControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.fld_grcGroupControl5.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl5.Name = "fld_grcGroupControl5";
            this.fld_grcGroupControl5.Screen = null;
            this.fld_grcGroupControl5.Size = new System.Drawing.Size(1101, 123);
            this.fld_grcGroupControl5.TabIndex = 0;
            this.fld_grcGroupControl5.Tag = "";
            this.fld_grcGroupControl5.Text = "Thông tin chung";
            // 
            // fld_ccbeICInventoryStockCountEmployeeInspector
            // 
            this.fld_ccbeICInventoryStockCountEmployeeInspector.Location = new System.Drawing.Point(389, 30);
            this.fld_ccbeICInventoryStockCountEmployeeInspector.MenuManager = this.screenToolbar;
            this.fld_ccbeICInventoryStockCountEmployeeInspector.Name = "fld_ccbeICInventoryStockCountEmployeeInspector";
            this.fld_ccbeICInventoryStockCountEmployeeInspector.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_ccbeICInventoryStockCountEmployeeInspector.Size = new System.Drawing.Size(150, 20);
            this.fld_ccbeICInventoryStockCountEmployeeInspector.TabIndex = 11;
            this.fld_ccbeICInventoryStockCountEmployeeInspector.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_ccbeICInventoryStockCountEmployeeInspector_CloseUp);
            // 
            // fld_ccbeICInventoryStockCountEmployeeRepresentatives
            // 
            this.fld_ccbeICInventoryStockCountEmployeeRepresentatives.Location = new System.Drawing.Point(652, 56);
            this.fld_ccbeICInventoryStockCountEmployeeRepresentatives.MenuManager = this.screenToolbar;
            this.fld_ccbeICInventoryStockCountEmployeeRepresentatives.Name = "fld_ccbeICInventoryStockCountEmployeeRepresentatives";
            this.fld_ccbeICInventoryStockCountEmployeeRepresentatives.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_ccbeICInventoryStockCountEmployeeRepresentatives.Size = new System.Drawing.Size(150, 20);
            this.fld_ccbeICInventoryStockCountEmployeeRepresentatives.TabIndex = 10;
            this.fld_ccbeICInventoryStockCountEmployeeRepresentatives.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_ccbeICInventoryStockCountEmployeeRepresentatives_CloseUp);
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
            this.bosLabel9.Location = new System.Drawing.Point(565, 59);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(68, 13);
            this.bosLabel9.TabIndex = 9;
            this.bosLabel9.Text = "Người đại diện";
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
            this.bosLabel8.Location = new System.Drawing.Point(565, 33);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(49, 13);
            this.bosLabel8.TabIndex = 8;
            this.bosLabel8.Text = "Tình trạng";
            // 
            // fld_lkeICInventoryStockCountStatus
            // 
            this.fld_lkeICInventoryStockCountStatus.BOSAllowAddNew = false;
            this.fld_lkeICInventoryStockCountStatus.BOSAllowDummy = true;
            this.fld_lkeICInventoryStockCountStatus.BOSComment = "";
            this.fld_lkeICInventoryStockCountStatus.BOSDataMember = "ICInventoryStockCountStatus";
            this.fld_lkeICInventoryStockCountStatus.BOSDataSource = "ICInventoryStockCounts";
            this.fld_lkeICInventoryStockCountStatus.BOSDescription = null;
            this.fld_lkeICInventoryStockCountStatus.BOSError = null;
            this.fld_lkeICInventoryStockCountStatus.BOSFieldGroup = "";
            this.fld_lkeICInventoryStockCountStatus.BOSFieldParent = "";
            this.fld_lkeICInventoryStockCountStatus.BOSFieldRelation = "";
            this.fld_lkeICInventoryStockCountStatus.BOSPrivilege = "";
            this.fld_lkeICInventoryStockCountStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICInventoryStockCountStatus.BOSSelectType = "";
            this.fld_lkeICInventoryStockCountStatus.BOSSelectTypeValue = "";
            this.fld_lkeICInventoryStockCountStatus.CurrentDisplayText = null;
            this.fld_lkeICInventoryStockCountStatus.Location = new System.Drawing.Point(652, 30);
            this.fld_lkeICInventoryStockCountStatus.Name = "fld_lkeICInventoryStockCountStatus";
            this.fld_lkeICInventoryStockCountStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICInventoryStockCountStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICInventoryStockCountStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICInventoryStockCountStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICInventoryStockCountStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICInventoryStockCountStatus.Properties.ColumnName = null;
            this.fld_lkeICInventoryStockCountStatus.Properties.NullText = "";
            this.fld_lkeICInventoryStockCountStatus.Properties.PopupWidth = 40;
            this.fld_lkeICInventoryStockCountStatus.Properties.ReadOnly = true;
            this.fld_lkeICInventoryStockCountStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICInventoryStockCountStatus.Screen = null;
            this.fld_lkeICInventoryStockCountStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICInventoryStockCountStatus.TabIndex = 2;
            this.fld_lkeICInventoryStockCountStatus.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(18, 33);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(75, 13);
            this.bosLabel3.TabIndex = 0;
            this.bosLabel3.Text = "Mã lần kiểm kho";
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
            this.bosLabel4.Location = new System.Drawing.Point(18, 59);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(79, 13);
            this.bosLabel4.TabIndex = 0;
            this.bosLabel4.Text = "Tên lần kiểm kho";
            // 
            // fld_medICInventoryStockCountRemark
            // 
            this.fld_medICInventoryStockCountRemark.BOSComment = null;
            this.fld_medICInventoryStockCountRemark.BOSDataMember = "ICInventoryStockCountRemark";
            this.fld_medICInventoryStockCountRemark.BOSDataSource = "ICInventoryStockCounts";
            this.fld_medICInventoryStockCountRemark.BOSDescription = null;
            this.fld_medICInventoryStockCountRemark.BOSError = null;
            this.fld_medICInventoryStockCountRemark.BOSFieldGroup = null;
            this.fld_medICInventoryStockCountRemark.BOSFieldRelation = null;
            this.fld_medICInventoryStockCountRemark.BOSPrivilege = null;
            this.fld_medICInventoryStockCountRemark.BOSPropertyName = "EditValue";
            this.fld_medICInventoryStockCountRemark.Location = new System.Drawing.Point(112, 82);
            this.fld_medICInventoryStockCountRemark.MenuManager = this.screenToolbar;
            this.fld_medICInventoryStockCountRemark.Name = "fld_medICInventoryStockCountRemark";
            this.fld_medICInventoryStockCountRemark.Screen = null;
            this.fld_medICInventoryStockCountRemark.Size = new System.Drawing.Size(427, 33);
            this.fld_medICInventoryStockCountRemark.TabIndex = 5;
            this.fld_medICInventoryStockCountRemark.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(294, 33);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(72, 13);
            this.bosLabel5.TabIndex = 0;
            this.bosLabel5.Text = "Người kiểm kho";
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
            this.bosLabel7.Location = new System.Drawing.Point(18, 85);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(35, 13);
            this.bosLabel7.TabIndex = 6;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "Ghi chú";
            // 
            // fld_txtICInventoryStockCountNo
            // 
            this.fld_txtICInventoryStockCountNo.BOSComment = null;
            this.fld_txtICInventoryStockCountNo.BOSDataMember = "ICInventoryStockCountNo";
            this.fld_txtICInventoryStockCountNo.BOSDataSource = "ICInventoryStockCounts";
            this.fld_txtICInventoryStockCountNo.BOSDescription = null;
            this.fld_txtICInventoryStockCountNo.BOSError = null;
            this.fld_txtICInventoryStockCountNo.BOSFieldGroup = null;
            this.fld_txtICInventoryStockCountNo.BOSFieldRelation = null;
            this.fld_txtICInventoryStockCountNo.BOSPrivilege = null;
            this.fld_txtICInventoryStockCountNo.BOSPropertyName = "EditValue";
            this.fld_txtICInventoryStockCountNo.Location = new System.Drawing.Point(112, 30);
            this.fld_txtICInventoryStockCountNo.MenuManager = this.screenToolbar;
            this.fld_txtICInventoryStockCountNo.Name = "fld_txtICInventoryStockCountNo";
            this.fld_txtICInventoryStockCountNo.Screen = null;
            this.fld_txtICInventoryStockCountNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICInventoryStockCountNo.TabIndex = 0;
            this.fld_txtICInventoryStockCountNo.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(294, 59);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(69, 13);
            this.bosLabel6.TabIndex = 0;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Ngày kiểm kho";
            // 
            // fld_txtICInventoryStockCountName
            // 
            this.fld_txtICInventoryStockCountName.BOSComment = null;
            this.fld_txtICInventoryStockCountName.BOSDataMember = "ICInventoryStockCountName";
            this.fld_txtICInventoryStockCountName.BOSDataSource = "ICInventoryStockCounts";
            this.fld_txtICInventoryStockCountName.BOSDescription = null;
            this.fld_txtICInventoryStockCountName.BOSError = null;
            this.fld_txtICInventoryStockCountName.BOSFieldGroup = null;
            this.fld_txtICInventoryStockCountName.BOSFieldRelation = null;
            this.fld_txtICInventoryStockCountName.BOSPrivilege = null;
            this.fld_txtICInventoryStockCountName.BOSPropertyName = "EditValue";
            this.fld_txtICInventoryStockCountName.Location = new System.Drawing.Point(112, 56);
            this.fld_txtICInventoryStockCountName.MenuManager = this.screenToolbar;
            this.fld_txtICInventoryStockCountName.Name = "fld_txtICInventoryStockCountName";
            this.fld_txtICInventoryStockCountName.Screen = null;
            this.fld_txtICInventoryStockCountName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICInventoryStockCountName.TabIndex = 3;
            this.fld_txtICInventoryStockCountName.Tag = "DC";
            // 
            // fld_dteICInventoryStockCountDate
            // 
            this.fld_dteICInventoryStockCountDate.BOSComment = "";
            this.fld_dteICInventoryStockCountDate.BOSDataMember = "ICInventoryStockCountDate";
            this.fld_dteICInventoryStockCountDate.BOSDataSource = "ICInventoryStockCounts";
            this.fld_dteICInventoryStockCountDate.BOSDescription = null;
            this.fld_dteICInventoryStockCountDate.BOSError = null;
            this.fld_dteICInventoryStockCountDate.BOSFieldGroup = "";
            this.fld_dteICInventoryStockCountDate.BOSFieldRelation = "";
            this.fld_dteICInventoryStockCountDate.BOSPrivilege = "";
            this.fld_dteICInventoryStockCountDate.BOSPropertyName = "EditValue";
            this.fld_dteICInventoryStockCountDate.EditValue = null;
            this.fld_dteICInventoryStockCountDate.Location = new System.Drawing.Point(389, 56);
            this.fld_dteICInventoryStockCountDate.Name = "fld_dteICInventoryStockCountDate";
            this.fld_dteICInventoryStockCountDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICInventoryStockCountDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICInventoryStockCountDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICInventoryStockCountDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICInventoryStockCountDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICInventoryStockCountDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICInventoryStockCountDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.fld_dteICInventoryStockCountDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteICInventoryStockCountDate.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.fld_dteICInventoryStockCountDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteICInventoryStockCountDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy HH:mm");
            this.fld_dteICInventoryStockCountDate.Screen = null;
            this.fld_dteICInventoryStockCountDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICInventoryStockCountDate.TabIndex = 4;
            this.fld_dteICInventoryStockCountDate.Tag = "DC";
            // 
            // groupStock
            // 
            this.groupStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupStock.BOSComment = null;
            this.groupStock.BOSDataMember = null;
            this.groupStock.BOSDataSource = null;
            this.groupStock.BOSDescription = null;
            this.groupStock.BOSError = null;
            this.groupStock.BOSFieldGroup = null;
            this.groupStock.BOSFieldRelation = null;
            this.groupStock.BOSPrivilege = null;
            this.groupStock.BOSPropertyName = null;
            this.groupStock.Controls.Add(this.bosLabel11);
            this.groupStock.Controls.Add(this.fld_btnImportExcel);
            this.groupStock.Controls.Add(this.fld_lkeICInventoryStockCountType);
            this.groupStock.Controls.Add(this.fld_lkeFK_ICDepartmentID);
            this.groupStock.Controls.Add(this.fld_lblLabel7);
            this.groupStock.Controls.Add(this.fld_bedICProductGroupID);
            this.groupStock.Controls.Add(this.fld_btnStockQuantity);
            this.groupStock.Controls.Add(this.bosLabel2);
            this.groupStock.Controls.Add(this.fld_FK_ICStockID);
            this.groupStock.Controls.Add(this.bosLabel10);
            this.groupStock.Location = new System.Drawing.Point(0, 121);
            this.groupStock.Name = "groupStock";
            this.groupStock.Screen = null;
            this.groupStock.Size = new System.Drawing.Size(1101, 71);
            this.groupStock.TabIndex = 1;
            this.groupStock.Text = "Thông tin tìm kiếm";
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
            this.bosLabel11.Location = new System.Drawing.Point(386, 26);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(58, 13);
            this.bosLabel11.TabIndex = 90;
            this.bosLabel11.Text = "Ngành hàng";
            // 
            // fld_btnImportExcel
            // 
            this.fld_btnImportExcel.BOSComment = null;
            this.fld_btnImportExcel.BOSDataMember = null;
            this.fld_btnImportExcel.BOSDataSource = null;
            this.fld_btnImportExcel.BOSDescription = null;
            this.fld_btnImportExcel.BOSError = null;
            this.fld_btnImportExcel.BOSFieldGroup = null;
            this.fld_btnImportExcel.BOSFieldRelation = null;
            this.fld_btnImportExcel.BOSPrivilege = null;
            this.fld_btnImportExcel.BOSPropertyName = null;
            this.fld_btnImportExcel.Location = new System.Drawing.Point(906, 43);
            this.fld_btnImportExcel.Name = "fld_btnImportExcel";
            this.fld_btnImportExcel.Screen = null;
            this.fld_btnImportExcel.Size = new System.Drawing.Size(121, 24);
            this.fld_btnImportExcel.TabIndex = 12;
            this.fld_btnImportExcel.Tag = "ButtonStockQuantity";
            this.fld_btnImportExcel.Text = "Nhập nhanh từ Excel";
            this.fld_btnImportExcel.Click += new System.EventHandler(this.bosButton1_Click);
            // 
            // fld_lkeICInventoryStockCountType
            // 
            this.fld_lkeICInventoryStockCountType.BOSAllowAddNew = false;
            this.fld_lkeICInventoryStockCountType.BOSAllowDummy = false;
            this.fld_lkeICInventoryStockCountType.BOSComment = "";
            this.fld_lkeICInventoryStockCountType.BOSDataMember = "ICInventoryStockCountType";
            this.fld_lkeICInventoryStockCountType.BOSDataSource = "ICInventoryStockCounts";
            this.fld_lkeICInventoryStockCountType.BOSDescription = null;
            this.fld_lkeICInventoryStockCountType.BOSError = null;
            this.fld_lkeICInventoryStockCountType.BOSFieldGroup = "";
            this.fld_lkeICInventoryStockCountType.BOSFieldParent = "";
            this.fld_lkeICInventoryStockCountType.BOSFieldRelation = "";
            this.fld_lkeICInventoryStockCountType.BOSPrivilege = "";
            this.fld_lkeICInventoryStockCountType.BOSPropertyName = "EditValue";
            this.fld_lkeICInventoryStockCountType.BOSSelectType = "";
            this.fld_lkeICInventoryStockCountType.BOSSelectTypeValue = "";
            this.fld_lkeICInventoryStockCountType.CurrentDisplayText = null;
            this.fld_lkeICInventoryStockCountType.Location = new System.Drawing.Point(230, 45);
            this.fld_lkeICInventoryStockCountType.Name = "fld_lkeICInventoryStockCountType";
            this.fld_lkeICInventoryStockCountType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICInventoryStockCountType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICInventoryStockCountType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICInventoryStockCountType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICInventoryStockCountType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICInventoryStockCountType.Properties.ColumnName = null;
            this.fld_lkeICInventoryStockCountType.Properties.NullText = "";
            this.fld_lkeICInventoryStockCountType.Properties.PopupWidth = 40;
            this.fld_lkeICInventoryStockCountType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICInventoryStockCountType.Screen = null;
            this.fld_lkeICInventoryStockCountType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICInventoryStockCountType.TabIndex = 1;
            this.fld_lkeICInventoryStockCountType.Tag = "DC";
            // 
            // fld_lkeFK_ICDepartmentID
            // 
            this.fld_lkeFK_ICDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICDepartmentID.BOSAllowDummy = true;
            this.fld_lkeFK_ICDepartmentID.BOSComment = "";
            this.fld_lkeFK_ICDepartmentID.BOSDataMember = "FK_ICDepartmentID";
            this.fld_lkeFK_ICDepartmentID.BOSDataSource = "ICInventoryStockCounts";
            this.fld_lkeFK_ICDepartmentID.BOSDescription = null;
            this.fld_lkeFK_ICDepartmentID.BOSError = "";
            this.fld_lkeFK_ICDepartmentID.BOSFieldGroup = "";
            this.fld_lkeFK_ICDepartmentID.BOSFieldParent = "";
            this.fld_lkeFK_ICDepartmentID.BOSFieldRelation = "";
            this.fld_lkeFK_ICDepartmentID.BOSPrivilege = "";
            this.fld_lkeFK_ICDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICDepartmentID.BOSSelectType = "";
            this.fld_lkeFK_ICDepartmentID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ICDepartmentID.CurrentDisplayText = "";
            this.fld_lkeFK_ICDepartmentID.Location = new System.Drawing.Point(386, 45);
            this.fld_lkeFK_ICDepartmentID.Name = "fld_lkeFK_ICDepartmentID";
            this.fld_lkeFK_ICDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICDepartmentID.Properties.ColumnName = null;
            this.fld_lkeFK_ICDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICDepartmentName", "Ngành hàng")});
            this.fld_lkeFK_ICDepartmentID.Properties.DisplayMember = "ICDepartmentName";
            this.fld_lkeFK_ICDepartmentID.Properties.NullText = "";
            this.fld_lkeFK_ICDepartmentID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICDepartmentID.Properties.ValueMember = "ICDepartmentID";
            this.fld_lkeFK_ICDepartmentID.Screen = null;
            this.fld_lkeFK_ICDepartmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICDepartmentID.TabIndex = 2;
            this.fld_lkeFK_ICDepartmentID.Tag = "DC";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseFont = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = "";
            this.fld_lblLabel7.BOSDataMember = "";
            this.fld_lblLabel7.BOSDataSource = "";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "";
            this.fld_lblLabel7.BOSFieldRelation = "";
            this.fld_lblLabel7.BOSPrivilege = "";
            this.fld_lblLabel7.BOSPropertyName = null;
            this.fld_lblLabel7.Location = new System.Drawing.Point(230, 25);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(66, 13);
            this.fld_lblLabel7.TabIndex = 88;
            this.fld_lblLabel7.Tag = "SI";
            this.fld_lblLabel7.Text = "Loại kiểm kho";
            // 
            // fld_bedICProductGroupID
            // 
            this.fld_bedICProductGroupID.BOSComment = null;
            this.fld_bedICProductGroupID.BOSDataMember = "";
            this.fld_bedICProductGroupID.BOSDataSource = "";
            this.fld_bedICProductGroupID.BOSDescription = null;
            this.fld_bedICProductGroupID.BOSError = null;
            this.fld_bedICProductGroupID.BOSFieldGroup = null;
            this.fld_bedICProductGroupID.BOSFieldRelation = null;
            this.fld_bedICProductGroupID.BOSPrivilege = null;
            this.fld_bedICProductGroupID.BOSPropertyName = "";
            this.fld_bedICProductGroupID.Location = new System.Drawing.Point(542, 45);
            this.fld_bedICProductGroupID.MenuManager = this.screenToolbar;
            this.fld_bedICProductGroupID.Name = "fld_bedICProductGroupID";
            this.fld_bedICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_bedICProductGroupID.Properties.ReadOnly = true;
            this.fld_bedICProductGroupID.Screen = null;
            this.fld_bedICProductGroupID.Size = new System.Drawing.Size(222, 20);
            this.fld_bedICProductGroupID.TabIndex = 3;
            this.fld_bedICProductGroupID.Tag = "DC";
            this.fld_bedICProductGroupID.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fld_bedICProductGroupID_ButtonClick);
            // 
            // fld_btnStockQuantity
            // 
            this.fld_btnStockQuantity.BOSComment = null;
            this.fld_btnStockQuantity.BOSDataMember = null;
            this.fld_btnStockQuantity.BOSDataSource = null;
            this.fld_btnStockQuantity.BOSDescription = null;
            this.fld_btnStockQuantity.BOSError = null;
            this.fld_btnStockQuantity.BOSFieldGroup = null;
            this.fld_btnStockQuantity.BOSFieldRelation = null;
            this.fld_btnStockQuantity.BOSPrivilege = null;
            this.fld_btnStockQuantity.BOSPropertyName = null;
            this.fld_btnStockQuantity.Location = new System.Drawing.Point(770, 43);
            this.fld_btnStockQuantity.Name = "fld_btnStockQuantity";
            this.fld_btnStockQuantity.Screen = null;
            this.fld_btnStockQuantity.Size = new System.Drawing.Size(130, 24);
            this.fld_btnStockQuantity.TabIndex = 4;
            this.fld_btnStockQuantity.Tag = "ButtonStockQuantity";
            this.fld_btnStockQuantity.Text = "Tồn kho chương trình";
            this.fld_btnStockQuantity.Click += new System.EventHandler(this.fld_btnStockQuantity_Click);
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
            this.bosLabel2.Location = new System.Drawing.Point(18, 26);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(18, 13);
            this.bosLabel2.TabIndex = 0;
            this.bosLabel2.Text = "Kho";
            // 
            // fld_FK_ICStockID
            // 
            this.fld_FK_ICStockID.BOSAllowAddNew = false;
            this.fld_FK_ICStockID.BOSAllowDummy = false;
            this.fld_FK_ICStockID.BOSComment = null;
            this.fld_FK_ICStockID.BOSDataMember = "FK_ICStockID";
            this.fld_FK_ICStockID.BOSDataSource = "ICInventoryStockCounts";
            this.fld_FK_ICStockID.BOSDescription = null;
            this.fld_FK_ICStockID.BOSError = null;
            this.fld_FK_ICStockID.BOSFieldGroup = null;
            this.fld_FK_ICStockID.BOSFieldParent = "fld_lkeBRBranchID";
            this.fld_FK_ICStockID.BOSFieldRelation = null;
            this.fld_FK_ICStockID.BOSPrivilege = null;
            this.fld_FK_ICStockID.BOSPropertyName = "EditValue";
            this.fld_FK_ICStockID.BOSSelectType = null;
            this.fld_FK_ICStockID.BOSSelectTypeValue = null;
            this.fld_FK_ICStockID.CurrentDisplayText = null;
            this.fld_FK_ICStockID.Location = new System.Drawing.Point(18, 45);
            this.fld_FK_ICStockID.MenuManager = this.screenToolbar;
            this.fld_FK_ICStockID.Name = "fld_FK_ICStockID";
            this.fld_FK_ICStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_FK_ICStockID.Properties.ColumnName = null;
            this.fld_FK_ICStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockID", "Mã kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Tên kho")});
            this.fld_FK_ICStockID.Properties.DisplayMember = "ICStockName";
            this.fld_FK_ICStockID.Properties.NullText = "";
            this.fld_FK_ICStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_FK_ICStockID.Properties.ValueMember = "ICStockID";
            this.fld_FK_ICStockID.Screen = null;
            this.fld_FK_ICStockID.Size = new System.Drawing.Size(206, 20);
            this.fld_FK_ICStockID.TabIndex = 0;
            this.fld_FK_ICStockID.Tag = "DC";
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
            this.bosLabel10.Location = new System.Drawing.Point(551, 26);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(54, 13);
            this.bosLabel10.TabIndex = 86;
            this.bosLabel10.Text = "Nhóm hàng";
            // 
            // fld_dgcICInventoryStockCountItems
            // 
            this.fld_dgcICInventoryStockCountItems.BOSComment = null;
            this.fld_dgcICInventoryStockCountItems.BOSDataMember = null;
            this.fld_dgcICInventoryStockCountItems.BOSDataSource = "ICInventoryStockCountItems";
            this.fld_dgcICInventoryStockCountItems.BOSDescription = null;
            this.fld_dgcICInventoryStockCountItems.BOSError = null;
            this.fld_dgcICInventoryStockCountItems.BOSFieldGroup = null;
            this.fld_dgcICInventoryStockCountItems.BOSFieldRelation = null;
            this.fld_dgcICInventoryStockCountItems.BOSGridType = null;
            this.fld_dgcICInventoryStockCountItems.BOSPrivilege = null;
            this.fld_dgcICInventoryStockCountItems.BOSPropertyName = "EditValue";
            this.fld_dgcICInventoryStockCountItems.CommodityType = "";
            this.fld_dgcICInventoryStockCountItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_dgcICInventoryStockCountItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICInventoryStockCountItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcICInventoryStockCountItems.MenuManager = this.screenToolbar;
            this.fld_dgcICInventoryStockCountItems.Name = "fld_dgcICInventoryStockCountItems";
            this.fld_dgcICInventoryStockCountItems.PrintReport = false;
            this.fld_dgcICInventoryStockCountItems.Screen = null;
            this.fld_dgcICInventoryStockCountItems.Size = new System.Drawing.Size(1093, 399);
            this.fld_dgcICInventoryStockCountItems.TabIndex = 0;
            this.fld_dgcICInventoryStockCountItems.TabStop = false;
            this.fld_dgcICInventoryStockCountItems.Tag = "DC";
            // 
            // bosPanel4
            // 
            this.bosPanel4.BOSComment = null;
            this.bosPanel4.BOSDataMember = null;
            this.bosPanel4.BOSDataSource = null;
            this.bosPanel4.BOSDescription = null;
            this.bosPanel4.BOSError = null;
            this.bosPanel4.BOSFieldGroup = null;
            this.bosPanel4.BOSFieldRelation = null;
            this.bosPanel4.BOSPrivilege = null;
            this.bosPanel4.BOSPropertyName = null;
            this.bosPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bosPanel4.Location = new System.Drawing.Point(0, 622);
            this.bosPanel4.Name = "bosPanel4";
            this.bosPanel4.Screen = null;
            this.bosPanel4.Size = new System.Drawing.Size(1101, 10);
            this.bosPanel4.TabIndex = 2;
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
            this.bosPanel2.Controls.Add(this.bosTabControl1);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel2.Location = new System.Drawing.Point(0, 196);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(1101, 426);
            this.bosPanel2.TabIndex = 1;
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 0);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.bosTabControl1.Size = new System.Drawing.Size(1095, 424);
            this.bosTabControl1.TabIndex = 24;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcICInventoryStockCountItems);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1093, 399);
            this.xtraTabPage2.Text = "Kết quả kiểm kho";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcACDocumentEntrys);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1079, 392);
            this.xtraTabPage3.Text = "Hạch toán";
            // 
            // fld_dgcACDocumentEntrys
            // 
            this.fld_dgcACDocumentEntrys.AllowDrop = true;
            this.fld_dgcACDocumentEntrys.BOSComment = "";
            this.fld_dgcACDocumentEntrys.BOSDataMember = "";
            this.fld_dgcACDocumentEntrys.BOSDataSource = "ACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.BOSDescription = null;
            this.fld_dgcACDocumentEntrys.BOSError = null;
            this.fld_dgcACDocumentEntrys.BOSFieldGroup = "";
            this.fld_dgcACDocumentEntrys.BOSFieldRelation = "";
            this.fld_dgcACDocumentEntrys.BOSGridType = null;
            this.fld_dgcACDocumentEntrys.BOSPrivilege = "";
            this.fld_dgcACDocumentEntrys.BOSPropertyName = "";
            this.fld_dgcACDocumentEntrys.CommodityType = "";
            this.fld_dgcACDocumentEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACDocumentEntrys.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACDocumentEntrys.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACDocumentEntrys.MainView = this.fld_dgvACDocumentEntrys;
            this.fld_dgcACDocumentEntrys.Name = "fld_dgcACDocumentEntrys";
            this.fld_dgcACDocumentEntrys.PrintReport = false;
            this.fld_dgcACDocumentEntrys.Screen = null;
            this.fld_dgcACDocumentEntrys.Size = new System.Drawing.Size(1079, 392);
            this.fld_dgcACDocumentEntrys.TabIndex = 3;
            this.fld_dgcACDocumentEntrys.Tag = "DC";
            this.fld_dgcACDocumentEntrys.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvACDocumentEntrys});
            // 
            // fld_dgvACDocumentEntrys
            // 
            this.fld_dgvACDocumentEntrys.GridControl = this.fld_dgcACDocumentEntrys;
            this.fld_dgvACDocumentEntrys.Name = "fld_dgvACDocumentEntrys";
            this.fld_dgvACDocumentEntrys.PaintStyleName = "Office2003";
            // 
            // DMISC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1101, 632);
            this.Controls.Add(this.bosPanel2);
            this.Controls.Add(this.bosPanel4);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMISC100.IconOptions.Icon")));
            this.Name = "DMISC100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.Controls.SetChildIndex(this.bosPanel4, 0);
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).EndInit();
            this.fld_grcGroupControl5.ResumeLayout(false);
            this.fld_grcGroupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ccbeICInventoryStockCountEmployeeInspector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ccbeICInventoryStockCountEmployeeRepresentatives.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICInventoryStockCountStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICInventoryStockCountRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICInventoryStockCountNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICInventoryStockCountName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICInventoryStockCountDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICInventoryStockCountDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupStock)).EndInit();
            this.groupStock.ResumeLayout(false);
            this.groupStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICInventoryStockCountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bedICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_FK_ICStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICInventoryStockCountItems)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACDocumentEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocumentEntrys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLookupEdit fld_FK_ICStockID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSERP.Modules.InventoryStockCount.InventoryStockCountsGridControl fld_dgcICInventoryStockCountItems;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtICInventoryStockCountNo;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtICInventoryStockCountName;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSDateEdit fld_dteICInventoryStockCountDate;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSMemoEdit fld_medICInventoryStockCountRemark;
        private BOSComponent.BOSButtonEdit fld_bedICProductGroupID;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSButton fld_btnStockQuantity;
        private BOSComponent.BOSGroupControl groupStock;
        private BOSComponent.BOSGroupControl fld_grcGroupControl5;
        private BOSComponent.BOSPanel bosPanel4;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeICInventoryStockCountStatus;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICDepartmentID;
        private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSLabel bosLabel9;
        private DevExpress.XtraEditors.CheckedComboBoxEdit fld_ccbeICInventoryStockCountEmployeeInspector;
        private DevExpress.XtraEditors.CheckedComboBoxEdit fld_ccbeICInventoryStockCountEmployeeRepresentatives;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeICInventoryStockCountType;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private BaseDocumentEntryGridControl fld_dgcACDocumentEntrys;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocumentEntrys;
        private BOSComponent.BOSButton fld_btnImportExcel;
    }
}
