using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.OperationDetailPlanCapacity.UI
{
	/// <summary>
	/// Summary description for DMODPC100
	/// </summary>
	partial class DMODPC100
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
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductForBatchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_ckeDefaultByProcess = new BOSComponent.BOSCheckEdit(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_ckeHasReceipt = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_ckeBeginOperation = new BOSComponent.BOSCheckEdit(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.fld_btnAddFromList = new BOSComponent.BOSButton(this.components);
            this.fld_btnClear = new BOSComponent.BOSButton(this.components);
            this.fld_dteToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREmployeeQCID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHREmployeeGiveID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREmployeeTakeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnCapacity = new BOSComponent.BOSButton(this.components);
            this.fld_btnEditCapacity = new BOSComponent.BOSButton(this.components);
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtQty = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblFrom = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcMMOperationDetailPlanCapacityItems = new BOSERP.Modules.OperationDetailPlanCapacity.MMOperationDetailPlanCapacityItemsGridControl();
            this.fld_dgvMMOperationDetailPlanCapacityItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductForBatchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeDefaultByProcess.Properties)).BeginInit();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeHasReceipt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeBeginOperation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeQCID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeGiveID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeTakeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMOperationDetailPlanCapacityItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMOperationDetailPlanCapacityItems)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lkeICProductForBatchID);
            this.bosPanel1.Controls.Add(this.fld_ckeDefaultByProcess);
            this.bosPanel1.Controls.Add(this.bosPanel2);
            this.bosPanel1.Controls.Add(this.bosButton1);
            this.bosPanel1.Controls.Add(this.fld_btnAddFromList);
            this.bosPanel1.Controls.Add(this.fld_btnClear);
            this.bosPanel1.Controls.Add(this.fld_dteToDate);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_dteFromDate);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_lkeHREmployeeQCID);
            this.bosPanel1.Controls.Add(this.fld_lkeHREmployeeGiveID);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeHREmployeeTakeID);
            this.bosPanel1.Controls.Add(this.fld_btnCapacity);
            this.bosPanel1.Controls.Add(this.fld_btnEditCapacity);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_txtQty);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_btnApply);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lkeMMBatchProductID);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeICProductID);
            this.bosPanel1.Controls.Add(this.fld_dteDate);
            this.bosPanel1.Controls.Add(this.fld_lblFrom);
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1148, 542);
            this.bosPanel1.TabIndex = 0;
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
            this.bosLabel3.Location = new System.Drawing.Point(16, 119);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(59, 13);
            this.bosLabel3.TabIndex = 152;
            this.bosLabel3.Text = "Thành phẩm";
            // 
            // fld_lkeICProductForBatchID
            // 
            this.fld_lkeICProductForBatchID.BOSAllowAddNew = false;
            this.fld_lkeICProductForBatchID.BOSAllowDummy = true;
            this.fld_lkeICProductForBatchID.BOSComment = null;
            this.fld_lkeICProductForBatchID.BOSDataMember = "ICProductID";
            this.fld_lkeICProductForBatchID.BOSDataSource = "ICProducts";
            this.fld_lkeICProductForBatchID.BOSDescription = null;
            this.fld_lkeICProductForBatchID.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductForBatchID.BOSFieldGroup = null;
            this.fld_lkeICProductForBatchID.BOSFieldParent = null;
            this.fld_lkeICProductForBatchID.BOSFieldRelation = null;
            this.fld_lkeICProductForBatchID.BOSPrivilege = null;
            this.fld_lkeICProductForBatchID.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductForBatchID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductForBatchID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductForBatchID.CurrentDisplayText = null;
            this.fld_lkeICProductForBatchID.Location = new System.Drawing.Point(93, 116);
            this.fld_lkeICProductForBatchID.Name = "fld_lkeICProductForBatchID";
            this.fld_lkeICProductForBatchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICProductForBatchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICProductForBatchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductForBatchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICProductForBatchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductForBatchID.Properties.ColumnName = null;
            this.fld_lkeICProductForBatchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã thành phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FK_MMLineID", "Chuyền", 20, DevExpress.Utils.FormatType.None, global::Localization.MESLocalizedResources.String1, false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FK_MMWorkShopID", "Xưởng", 20, DevExpress.Utils.FormatType.None, global::Localization.MESLocalizedResources.String1, false, DevExpress.Utils.HorzAlignment.Default)});
            this.fld_lkeICProductForBatchID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeICProductForBatchID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductForBatchID.Properties.PopupWidth = 40;
            this.fld_lkeICProductForBatchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductForBatchID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductForBatchID.Screen = null;
            this.fld_lkeICProductForBatchID.Size = new System.Drawing.Size(437, 20);
            this.fld_lkeICProductForBatchID.TabIndex = 151;
            this.fld_lkeICProductForBatchID.Tag = "DC";
            this.fld_lkeICProductForBatchID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeICProductForBatchID_CloseUp);
            // 
            // fld_ckeDefaultByProcess
            // 
            this.fld_ckeDefaultByProcess.BOSComment = null;
            this.fld_ckeDefaultByProcess.BOSDataMember = null;
            this.fld_ckeDefaultByProcess.BOSDataSource = null;
            this.fld_ckeDefaultByProcess.BOSDescription = null;
            this.fld_ckeDefaultByProcess.BOSError = null;
            this.fld_ckeDefaultByProcess.BOSFieldGroup = null;
            this.fld_ckeDefaultByProcess.BOSFieldRelation = null;
            this.fld_ckeDefaultByProcess.BOSPrivilege = null;
            this.fld_ckeDefaultByProcess.BOSPropertyName = null;
            this.fld_ckeDefaultByProcess.Location = new System.Drawing.Point(558, 65);
            this.fld_ckeDefaultByProcess.MenuManager = this.screenToolbar;
            this.fld_ckeDefaultByProcess.Name = "fld_ckeDefaultByProcess";
            this.fld_ckeDefaultByProcess.Properties.Caption = "Mặc định theo QTSX";
            this.fld_ckeDefaultByProcess.Screen = null;
            this.fld_ckeDefaultByProcess.Size = new System.Drawing.Size(124, 19);
            this.fld_ckeDefaultByProcess.TabIndex = 150;
            this.fld_ckeDefaultByProcess.CheckedChanged += new System.EventHandler(this.fld_ckeDefaultByProcess_CheckedChanged);
            // 
            // bosPanel2
            // 
            this.bosPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.fld_ckeHasReceipt);
            this.bosPanel2.Controls.Add(this.fld_ckeBeginOperation);
            this.bosPanel2.Location = new System.Drawing.Point(554, 77);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(140, 56);
            this.bosPanel2.TabIndex = 149;
            // 
            // fld_ckeHasReceipt
            // 
            this.fld_ckeHasReceipt.BOSComment = null;
            this.fld_ckeHasReceipt.BOSDataMember = null;
            this.fld_ckeHasReceipt.BOSDataSource = null;
            this.fld_ckeHasReceipt.BOSDescription = null;
            this.fld_ckeHasReceipt.BOSError = null;
            this.fld_ckeHasReceipt.BOSFieldGroup = null;
            this.fld_ckeHasReceipt.BOSFieldRelation = null;
            this.fld_ckeHasReceipt.BOSPrivilege = null;
            this.fld_ckeHasReceipt.BOSPropertyName = null;
            this.fld_ckeHasReceipt.Location = new System.Drawing.Point(3, 9);
            this.fld_ckeHasReceipt.MenuManager = this.screenToolbar;
            this.fld_ckeHasReceipt.Name = "fld_ckeHasReceipt";
            this.fld_ckeHasReceipt.Properties.Caption = "Có nhập kho";
            this.fld_ckeHasReceipt.Screen = null;
            this.fld_ckeHasReceipt.Size = new System.Drawing.Size(124, 19);
            this.fld_ckeHasReceipt.TabIndex = 147;
            // 
            // fld_ckeBeginOperation
            // 
            this.fld_ckeBeginOperation.BOSComment = null;
            this.fld_ckeBeginOperation.BOSDataMember = null;
            this.fld_ckeBeginOperation.BOSDataSource = null;
            this.fld_ckeBeginOperation.BOSDescription = null;
            this.fld_ckeBeginOperation.BOSError = null;
            this.fld_ckeBeginOperation.BOSFieldGroup = null;
            this.fld_ckeBeginOperation.BOSFieldRelation = null;
            this.fld_ckeBeginOperation.BOSPrivilege = null;
            this.fld_ckeBeginOperation.BOSPropertyName = null;
            this.fld_ckeBeginOperation.Location = new System.Drawing.Point(3, 35);
            this.fld_ckeBeginOperation.MenuManager = this.screenToolbar;
            this.fld_ckeBeginOperation.Name = "fld_ckeBeginOperation";
            this.fld_ckeBeginOperation.Properties.Caption = "Công đoạn bắt đầu";
            this.fld_ckeBeginOperation.Screen = null;
            this.fld_ckeBeginOperation.Size = new System.Drawing.Size(124, 19);
            this.fld_ckeBeginOperation.TabIndex = 9;
            // 
            // bosButton1
            // 
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.Location = new System.Drawing.Point(726, 67);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(75, 27);
            this.bosButton1.TabIndex = 148;
            this.bosButton1.Text = "test";
            this.bosButton1.Visible = false;
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
            // 
            // fld_btnAddFromList
            // 
            this.fld_btnAddFromList.BOSComment = null;
            this.fld_btnAddFromList.BOSDataMember = null;
            this.fld_btnAddFromList.BOSDataSource = null;
            this.fld_btnAddFromList.BOSDescription = null;
            this.fld_btnAddFromList.BOSError = null;
            this.fld_btnAddFromList.BOSFieldGroup = null;
            this.fld_btnAddFromList.BOSFieldRelation = null;
            this.fld_btnAddFromList.BOSPrivilege = null;
            this.fld_btnAddFromList.BOSPropertyName = null;
            this.fld_btnAddFromList.Location = new System.Drawing.Point(996, 135);
            this.fld_btnAddFromList.Name = "fld_btnAddFromList";
            this.fld_btnAddFromList.Screen = null;
            this.fld_btnAddFromList.Size = new System.Drawing.Size(108, 27);
            this.fld_btnAddFromList.TabIndex = 16;
            this.fld_btnAddFromList.Text = "Thêm từ danh sách";
            this.fld_btnAddFromList.Click += new System.EventHandler(this.fld_btnAddFromList_Click);
            // 
            // fld_btnClear
            // 
            this.fld_btnClear.BOSComment = null;
            this.fld_btnClear.BOSDataMember = null;
            this.fld_btnClear.BOSDataSource = null;
            this.fld_btnClear.BOSDescription = null;
            this.fld_btnClear.BOSError = null;
            this.fld_btnClear.BOSFieldGroup = null;
            this.fld_btnClear.BOSFieldRelation = null;
            this.fld_btnClear.BOSPrivilege = null;
            this.fld_btnClear.BOSPropertyName = null;
            this.fld_btnClear.Location = new System.Drawing.Point(915, 135);
            this.fld_btnClear.Name = "fld_btnClear";
            this.fld_btnClear.Screen = null;
            this.fld_btnClear.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClear.TabIndex = 16;
            this.fld_btnClear.Text = "Làm mới";
            this.fld_btnClear.Click += new System.EventHandler(this.fld_btnClear_Click);
            // 
            // fld_dteToDate
            // 
            this.fld_dteToDate.BOSComment = null;
            this.fld_dteToDate.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_dteToDate.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_dteToDate.BOSDescription = null;
            this.fld_dteToDate.BOSError = null;
            this.fld_dteToDate.BOSFieldGroup = null;
            this.fld_dteToDate.BOSFieldRelation = null;
            this.fld_dteToDate.BOSPrivilege = null;
            this.fld_dteToDate.BOSPropertyName = null;
            this.fld_dteToDate.EditValue = null;
            this.fld_dteToDate.Location = new System.Drawing.Point(366, 12);
            this.fld_dteToDate.Name = "fld_dteToDate";
            this.fld_dteToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToDate.Screen = null;
            this.fld_dteToDate.Size = new System.Drawing.Size(163, 20);
            this.fld_dteToDate.TabIndex = 1;
            this.fld_dteToDate.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(285, 15);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 146;
            this.bosLabel9.Text = "Đến ngày";
            // 
            // fld_dteFromDate
            // 
            this.fld_dteFromDate.BOSComment = null;
            this.fld_dteFromDate.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_dteFromDate.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_dteFromDate.BOSDescription = null;
            this.fld_dteFromDate.BOSError = null;
            this.fld_dteFromDate.BOSFieldGroup = null;
            this.fld_dteFromDate.BOSFieldRelation = null;
            this.fld_dteFromDate.BOSPrivilege = null;
            this.fld_dteFromDate.BOSPropertyName = null;
            this.fld_dteFromDate.EditValue = null;
            this.fld_dteFromDate.Location = new System.Drawing.Point(93, 12);
            this.fld_dteFromDate.Name = "fld_dteFromDate";
            this.fld_dteFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromDate.Screen = null;
            this.fld_dteFromDate.Size = new System.Drawing.Size(163, 20);
            this.fld_dteFromDate.TabIndex = 0;
            this.fld_dteFromDate.Tag = "DC";
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
            this.bosLabel8.Location = new System.Drawing.Point(16, 15);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(63, 13);
            this.bosLabel8.TabIndex = 144;
            this.bosLabel8.Text = "Xem Từ ngày";
            // 
            // fld_lkeHREmployeeQCID
            // 
            this.fld_lkeHREmployeeQCID.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeQCID.BOSAllowDummy = true;
            this.fld_lkeHREmployeeQCID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeQCID.BOSDataMember = "HREmployeeID";
            this.fld_lkeHREmployeeQCID.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeeQCID.BOSDescription = null;
            this.fld_lkeHREmployeeQCID.BOSError = null;
            this.fld_lkeHREmployeeQCID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeQCID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeQCID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeQCID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeQCID.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeQCID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeQCID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeQCID.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeQCID.Location = new System.Drawing.Point(366, 38);
            this.fld_lkeHREmployeeQCID.Name = "fld_lkeHREmployeeQCID";
            this.fld_lkeHREmployeeQCID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREmployeeQCID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREmployeeQCID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeeQCID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREmployeeQCID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeQCID.Properties.ColumnName = null;
            this.fld_lkeHREmployeeQCID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeHREmployeeQCID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeHREmployeeQCID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeQCID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeeQCID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeHREmployeeQCID.Screen = null;
            this.fld_lkeHREmployeeQCID.Size = new System.Drawing.Size(164, 20);
            this.fld_lkeHREmployeeQCID.TabIndex = 3;
            this.fld_lkeHREmployeeQCID.Tag = "DC";
            // 
            // fld_lkeHREmployeeGiveID
            // 
            this.fld_lkeHREmployeeGiveID.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeGiveID.BOSAllowDummy = true;
            this.fld_lkeHREmployeeGiveID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeGiveID.BOSDataMember = "HREmployeeID";
            this.fld_lkeHREmployeeGiveID.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeeGiveID.BOSDescription = null;
            this.fld_lkeHREmployeeGiveID.BOSError = null;
            this.fld_lkeHREmployeeGiveID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeGiveID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeGiveID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeGiveID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeGiveID.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeGiveID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeGiveID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeGiveID.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeGiveID.Location = new System.Drawing.Point(93, 64);
            this.fld_lkeHREmployeeGiveID.Name = "fld_lkeHREmployeeGiveID";
            this.fld_lkeHREmployeeGiveID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREmployeeGiveID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREmployeeGiveID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeeGiveID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREmployeeGiveID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeGiveID.Properties.ColumnName = null;
            this.fld_lkeHREmployeeGiveID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeHREmployeeGiveID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeHREmployeeGiveID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeGiveID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeeGiveID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeHREmployeeGiveID.Screen = null;
            this.fld_lkeHREmployeeGiveID.Size = new System.Drawing.Size(163, 20);
            this.fld_lkeHREmployeeGiveID.TabIndex = 4;
            this.fld_lkeHREmployeeGiveID.Tag = "DC";
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
            this.bosLabel10.Location = new System.Drawing.Point(285, 41);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(15, 13);
            this.bosLabel10.TabIndex = 138;
            this.bosLabel10.Text = "QC";
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
            this.bosLabel4.Location = new System.Drawing.Point(285, 67);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(55, 13);
            this.bosLabel4.TabIndex = 136;
            this.bosLabel4.Text = "Người nhận";
            // 
            // fld_lkeHREmployeeTakeID
            // 
            this.fld_lkeHREmployeeTakeID.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeTakeID.BOSAllowDummy = true;
            this.fld_lkeHREmployeeTakeID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeTakeID.BOSDataMember = "HREmployeeID";
            this.fld_lkeHREmployeeTakeID.BOSDataSource = "HREmployees";
            this.fld_lkeHREmployeeTakeID.BOSDescription = null;
            this.fld_lkeHREmployeeTakeID.BOSError = null;
            this.fld_lkeHREmployeeTakeID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeTakeID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeTakeID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeTakeID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeTakeID.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeeTakeID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeTakeID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeTakeID.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeTakeID.Location = new System.Drawing.Point(366, 64);
            this.fld_lkeHREmployeeTakeID.Name = "fld_lkeHREmployeeTakeID";
            this.fld_lkeHREmployeeTakeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHREmployeeTakeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHREmployeeTakeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHREmployeeTakeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHREmployeeTakeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeTakeID.Properties.ColumnName = null;
            this.fld_lkeHREmployeeTakeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeHREmployeeTakeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeHREmployeeTakeID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeHREmployeeTakeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHREmployeeTakeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeHREmployeeTakeID.Screen = null;
            this.fld_lkeHREmployeeTakeID.Size = new System.Drawing.Size(164, 20);
            this.fld_lkeHREmployeeTakeID.TabIndex = 5;
            this.fld_lkeHREmployeeTakeID.Tag = "DC";
            // 
            // fld_btnCapacity
            // 
            this.fld_btnCapacity.BOSComment = null;
            this.fld_btnCapacity.BOSDataMember = null;
            this.fld_btnCapacity.BOSDataSource = null;
            this.fld_btnCapacity.BOSDescription = null;
            this.fld_btnCapacity.BOSError = null;
            this.fld_btnCapacity.BOSFieldGroup = null;
            this.fld_btnCapacity.BOSFieldRelation = null;
            this.fld_btnCapacity.BOSPrivilege = null;
            this.fld_btnCapacity.BOSPropertyName = null;
            this.fld_btnCapacity.Location = new System.Drawing.Point(672, 135);
            this.fld_btnCapacity.Name = "fld_btnCapacity";
            this.fld_btnCapacity.Screen = null;
            this.fld_btnCapacity.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCapacity.TabIndex = 13;
            this.fld_btnCapacity.Text = "Thêm";
            this.fld_btnCapacity.Click += new System.EventHandler(this.fld_btnAddCertificate_Click);
            // 
            // fld_btnEditCapacity
            // 
            this.fld_btnEditCapacity.BOSComment = null;
            this.fld_btnEditCapacity.BOSDataMember = null;
            this.fld_btnEditCapacity.BOSDataSource = null;
            this.fld_btnEditCapacity.BOSDescription = null;
            this.fld_btnEditCapacity.BOSError = null;
            this.fld_btnEditCapacity.BOSFieldGroup = null;
            this.fld_btnEditCapacity.BOSFieldRelation = null;
            this.fld_btnEditCapacity.BOSPrivilege = null;
            this.fld_btnEditCapacity.BOSPropertyName = null;
            this.fld_btnEditCapacity.Location = new System.Drawing.Point(753, 135);
            this.fld_btnEditCapacity.Name = "fld_btnEditCapacity";
            this.fld_btnEditCapacity.Screen = null;
            this.fld_btnEditCapacity.Size = new System.Drawing.Size(75, 27);
            this.fld_btnEditCapacity.TabIndex = 14;
            this.fld_btnEditCapacity.Text = "Lưu";
            this.fld_btnEditCapacity.Click += new System.EventHandler(this.fld_btnEditCapacity_Click);
            // 
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = true;
            this.fld_lkeFK_MMOperationID.BOSComment = null;
            this.fld_lkeFK_MMOperationID.BOSDataMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.BOSDataSource = "MMOperations";
            this.fld_lkeFK_MMOperationID.BOSDescription = null;
            this.fld_lkeFK_MMOperationID.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.BOSFieldGroup = null;
            this.fld_lkeFK_MMOperationID.BOSFieldParent = null;
            this.fld_lkeFK_MMOperationID.BOSFieldRelation = null;
            this.fld_lkeFK_MMOperationID.BOSPrivilege = null;
            this.fld_lkeFK_MMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.CurrentDisplayText = null;
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(366, 90);
            this.fld_lkeFK_MMOperationID.Name = "fld_lkeFK_MMOperationID";
            this.fld_lkeFK_MMOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationID.Properties.ColumnName = null;
            this.fld_lkeFK_MMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Công đoạn")});
            this.fld_lkeFK_MMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMOperationID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.Screen = null;
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(163, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 6;
            this.fld_lkeFK_MMOperationID.Tag = "DC";
            this.fld_lkeFK_MMOperationID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMOperationID_CloseUp);
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(285, 93);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(52, 13);
            this.bosLabel7.TabIndex = 130;
            this.bosLabel7.Text = "Công đoạn";
            // 
            // fld_txtQty
            // 
            this.fld_txtQty.BOSComment = null;
            this.fld_txtQty.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_txtQty.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_txtQty.BOSDescription = null;
            this.fld_txtQty.BOSError = null;
            this.fld_txtQty.BOSFieldGroup = null;
            this.fld_txtQty.BOSFieldRelation = null;
            this.fld_txtQty.BOSPrivilege = null;
            this.fld_txtQty.BOSPropertyName = "EditValue";
            this.fld_txtQty.Location = new System.Drawing.Point(602, 142);
            this.fld_txtQty.Name = "fld_txtQty";
            this.fld_txtQty.Properties.DisplayFormat.FormatString = "n0";
            this.fld_txtQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtQty.Properties.EditFormat.FormatString = "n0";
            this.fld_txtQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtQty.Properties.Mask.EditMask = "n0";
            this.fld_txtQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtQty.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtQty, false);
            this.fld_txtQty.Size = new System.Drawing.Size(64, 20);
            this.fld_txtQty.TabIndex = 12;
            this.fld_txtQty.Tag = "DC";
            this.fld_txtQty.Enter += new System.EventHandler(this.fld_txtQty_Enter);
            this.fld_txtQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_txtQty_KeyUp);
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
            this.bosLabel6.Location = new System.Drawing.Point(554, 145);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(42, 13);
            this.bosLabel6.TabIndex = 128;
            this.bosLabel6.Text = "Số lượng";
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(834, 135);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 27);
            this.fld_btnApply.TabIndex = 15;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
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
            this.bosLabel2.Location = new System.Drawing.Point(16, 67);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(51, 13);
            this.bosLabel2.TabIndex = 121;
            this.bosLabel2.Text = "Người giao";
            // 
            // fld_lkeMMBatchProductID
            // 
            this.fld_lkeMMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeMMBatchProductID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.BOSDataMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductID.BOSDescription = null;
            this.fld_lkeMMBatchProductID.BOSError = null;
            this.fld_lkeMMBatchProductID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.Location = new System.Drawing.Point(93, 90);
            this.fld_lkeMMBatchProductID.Name = "fld_lkeMMBatchProductID";
            this.fld_lkeMMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMBatchProductID.Properties.ColumnName = null;
            this.fld_lkeMMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã LSX")});
            this.fld_lkeMMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeMMBatchProductID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.Screen = null;
            this.fld_lkeMMBatchProductID.Size = new System.Drawing.Size(163, 20);
            this.fld_lkeMMBatchProductID.TabIndex = 10;
            this.fld_lkeMMBatchProductID.Tag = "DC";
            this.fld_lkeMMBatchProductID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeMMBatchProductID_CloseUp);
            this.fld_lkeMMBatchProductID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeMMBatchProductID_QueryPopUp);
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
            this.bosLabel1.Location = new System.Drawing.Point(16, 93);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(34, 13);
            this.bosLabel1.TabIndex = 109;
            this.bosLabel1.Text = "Mã LSX";
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
            this.bosLabel5.Location = new System.Drawing.Point(16, 145);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(56, 13);
            this.bosLabel5.TabIndex = 116;
            this.bosLabel5.Text = "Chi tiết / SP";
            // 
            // fld_lkeICProductID
            // 
            this.fld_lkeICProductID.BOSAllowAddNew = false;
            this.fld_lkeICProductID.BOSAllowDummy = true;
            this.fld_lkeICProductID.BOSComment = null;
            this.fld_lkeICProductID.BOSDataMember = "ICProductID";
            this.fld_lkeICProductID.BOSDataSource = "ICProducts";
            this.fld_lkeICProductID.BOSDescription = null;
            this.fld_lkeICProductID.BOSError = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductID.BOSFieldGroup = null;
            this.fld_lkeICProductID.BOSFieldParent = null;
            this.fld_lkeICProductID.BOSFieldRelation = null;
            this.fld_lkeICProductID.BOSPrivilege = null;
            this.fld_lkeICProductID.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductID.CurrentDisplayText = null;
            this.fld_lkeICProductID.Location = new System.Drawing.Point(92, 142);
            this.fld_lkeICProductID.Name = "fld_lkeICProductID";
            this.fld_lkeICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductID.Properties.ColumnName = null;
            this.fld_lkeICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductCarcassNo", "Mã carcass"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductCarcassName", "Tên carcass"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã chi tiết"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên chi tiết"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FK_MMLineID", "Chuyền", 20, DevExpress.Utils.FormatType.None, global::Localization.MESLocalizedResources.String1, false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FK_MMWorkShopID", "Xưởng", 20, DevExpress.Utils.FormatType.None, global::Localization.MESLocalizedResources.String1, false, DevExpress.Utils.HorzAlignment.Default)});
            this.fld_lkeICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeICProductID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductID.Properties.PopupWidth = 40;
            this.fld_lkeICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID.Screen = null;
            this.fld_lkeICProductID.Size = new System.Drawing.Size(437, 20);
            this.fld_lkeICProductID.TabIndex = 11;
            this.fld_lkeICProductID.Tag = "DC";
            this.fld_lkeICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeICProductID_KeyUp);
            this.fld_lkeICProductID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeICProductID_QueryPopUp);
            // 
            // fld_dteDate
            // 
            this.fld_dteDate.BOSComment = null;
            this.fld_dteDate.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_dteDate.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_dteDate.BOSDescription = null;
            this.fld_dteDate.BOSError = null;
            this.fld_dteDate.BOSFieldGroup = null;
            this.fld_dteDate.BOSFieldRelation = null;
            this.fld_dteDate.BOSPrivilege = null;
            this.fld_dteDate.BOSPropertyName = null;
            this.fld_dteDate.EditValue = null;
            this.fld_dteDate.Location = new System.Drawing.Point(93, 38);
            this.fld_dteDate.Name = "fld_dteDate";
            this.fld_dteDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteDate.Screen = null;
            this.fld_dteDate.Size = new System.Drawing.Size(163, 20);
            this.fld_dteDate.TabIndex = 2;
            this.fld_dteDate.Tag = "DC";
            // 
            // fld_lblFrom
            // 
            this.fld_lblFrom.BOSComment = null;
            this.fld_lblFrom.BOSDataMember = null;
            this.fld_lblFrom.BOSDataSource = null;
            this.fld_lblFrom.BOSDescription = null;
            this.fld_lblFrom.BOSError = null;
            this.fld_lblFrom.BOSFieldGroup = null;
            this.fld_lblFrom.BOSFieldRelation = null;
            this.fld_lblFrom.BOSPrivilege = null;
            this.fld_lblFrom.BOSPropertyName = null;
            this.fld_lblFrom.Location = new System.Drawing.Point(16, 41);
            this.fld_lblFrom.Name = "fld_lblFrom";
            this.fld_lblFrom.Screen = null;
            this.fld_lblFrom.Size = new System.Drawing.Size(25, 13);
            this.fld_lblFrom.TabIndex = 119;
            this.fld_lblFrom.Text = "Ngày";
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
            this.bosGroupControl2.Controls.Add(this.fld_dgcMMOperationDetailPlanCapacityItems);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 168);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(1142, 371);
            this.bosGroupControl2.TabIndex = 17;
            this.bosGroupControl2.Text = "Danh sách chi tiết";
            // 
            // fld_dgcMMOperationDetailPlanCapacityItems
            // 
            this.fld_dgcMMOperationDetailPlanCapacityItems.BOSComment = null;
            this.fld_dgcMMOperationDetailPlanCapacityItems.BOSDataMember = null;
            this.fld_dgcMMOperationDetailPlanCapacityItems.BOSDataSource = "MMOperationDetailPlanCapacityItems";
            this.fld_dgcMMOperationDetailPlanCapacityItems.BOSDescription = null;
            this.fld_dgcMMOperationDetailPlanCapacityItems.BOSError = null;
            this.fld_dgcMMOperationDetailPlanCapacityItems.BOSFieldGroup = null;
            this.fld_dgcMMOperationDetailPlanCapacityItems.BOSFieldRelation = null;
            this.fld_dgcMMOperationDetailPlanCapacityItems.BOSGridType = null;
            this.fld_dgcMMOperationDetailPlanCapacityItems.BOSPrivilege = null;
            this.fld_dgcMMOperationDetailPlanCapacityItems.BOSPropertyName = null;
            this.fld_dgcMMOperationDetailPlanCapacityItems.CommodityType = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMOperationDetailPlanCapacityItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMOperationDetailPlanCapacityItems.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcMMOperationDetailPlanCapacityItems.MenuManager = this.screenToolbar;
            this.fld_dgcMMOperationDetailPlanCapacityItems.Name = "fld_dgcMMOperationDetailPlanCapacityItems";
            this.fld_dgcMMOperationDetailPlanCapacityItems.PrintReport = false;
            this.fld_dgcMMOperationDetailPlanCapacityItems.Screen = null;
            this.fld_dgcMMOperationDetailPlanCapacityItems.Size = new System.Drawing.Size(1138, 347);
            this.fld_dgcMMOperationDetailPlanCapacityItems.TabIndex = 0;
            this.fld_dgcMMOperationDetailPlanCapacityItems.Click += new System.EventHandler(this.fld_dgcMMOperationDetailPlanCapacityItems_Click);
            // 
            // fld_dgvMMOperationDetailPlanCapacityItems
            // 
            this.fld_dgvMMOperationDetailPlanCapacityItems.Name = "fld_dgvMMOperationDetailPlanCapacityItems";
            this.fld_dgvMMOperationDetailPlanCapacityItems.PaintStyleName = "Office2003";
            // 
            // DMODPC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1148, 542);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMODPC100";
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.DMODPC100_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductForBatchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeDefaultByProcess.Properties)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeHasReceipt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeBeginOperation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeQCID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeGiveID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeTakeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMOperationDetailPlanCapacityItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMOperationDetailPlanCapacityItems)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMOperationDetailPlanCapacityItems;
        private MMOperationDetailPlanCapacityItemsGridControl fld_dgcMMOperationDetailPlanCapacityItems;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteDate;
        private BOSComponent.BOSLabel fld_lblFrom;
        private BOSComponent.BOSTextBox fld_txtQty;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSButton fld_btnCapacity;
        private BOSComponent.BOSButton fld_btnEditCapacity;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeICProductID;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeTakeID;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeQCID;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeeGiveID;
        private BOSComponent.BOSDateEdit fld_dteToDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit fld_dteFromDate;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSButton fld_btnClear;
        private BOSComponent.BOSCheckEdit fld_ckeBeginOperation;
        private BOSComponent.BOSCheckEdit fld_ckeHasReceipt;
        private BOSComponent.BOSButton fld_btnAddFromList;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSCheckEdit fld_ckeDefaultByProcess;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeICProductForBatchID;
       
	}
}
