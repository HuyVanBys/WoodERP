using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ImportData.UI
{
	/// <summary>
	/// Summary description for DMID100
	/// </summary>
	partial class DMID100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMID100));
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeCheckDataType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtProducttionCostNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_Lablel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnCheckData = new BOSComponent.BOSButton(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteCheckToDate = new BOSComponent.BOSDateEdit(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.fld_tabProductWorkItem = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabProduct = new DevExpress.XtraTab.XtraTabPage();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.fld_lkeICImportAndExportReasons = new BOSComponent.BOSLookupEdit(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.bosLine7 = new BOSComponent.BOSLine(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnUpdateReferItem = new BOSComponent.BOSButton(this.components);
            this.fld_btnUpdateSelectItem = new BOSComponent.BOSButton(this.components);
            this.fld_lkeICImportAndExportReasonsTab1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_gcTab1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcCheckShipmentAffterCompleteReceipt = new BOSERP.Modules.ImportData.CheckShipmentAffterFullReceiptGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeICShipmentTypeCombo = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeMMoperation1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteCostDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnChecktab1 = new BOSComponent.BOSButton(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.bosLine5 = new BOSComponent.BOSLine(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnUpdateTab2 = new BOSComponent.BOSButton(this.components);
            this.fld_lkeUpdateMMOperationIDTab2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_bgrTab2 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLine4 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeShipmentTypeTab2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMOperationTab2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICImportAndExportReasonsTab2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteDateTab2 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnCheckTab2 = new BOSComponent.BOSButton(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_xtabNVLChinhKPB = new DevExpress.XtraTab.XtraTabPage();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_tclProductTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_dgcCheckCostGridControl = new BOSERP.Modules.ImportData.CheckCostGridControl();
            this.gridView38 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMCostUpdatePrices = new BOSERP.Modules.ImportData.MMCostUpdatePricesGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine6 = new BOSComponent.BOSLine(this.components);
            this.fld_lkePrevMMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnOperation3 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteCheckToDate3 = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnUpdatePrice = new BOSComponent.BOSButton(this.components);
            this.fld_btnCheckData3 = new BOSComponent.BOSButton(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtProducttionCostNo3 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeCheckDataType3 = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeCheckDataType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProducttionCostNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCheckToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCheckToDate.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductWorkItem)).BeginInit();
            this.fld_tabProductWorkItem.SuspendLayout();
            this.fld_tabProduct.SuspendLayout();
            this.bosLine1.SuspendLayout();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICImportAndExportReasons.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            this.bosLine7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICImportAndExportReasonsTab1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_gcTab1)).BeginInit();
            this.fld_gcTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCheckShipmentAffterCompleteReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.bosLine3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentTypeCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMoperation1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCostDate1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCostDate1.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.bosLine5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeUpdateMMOperationIDTab2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bgrTab2)).BeginInit();
            this.bosLine4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeShipmentTypeTab2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationTab2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICImportAndExportReasonsTab2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDateTab2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDateTab2.Properties)).BeginInit();
            this.fld_xtabNVLChinhKPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tclProductTabControl)).BeginInit();
            this.fld_tclProductTabControl.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCheckCostGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView38)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMCostUpdatePrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.bosLine6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePrevMMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_btnOperation3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCheckToDate3.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCheckToDate3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProducttionCostNo3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeCheckDataType3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = "";
            this.fld_grcGroupControl.BOSDataSource = "";
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = "";
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = "";
            this.fld_grcGroupControl.Location = new System.Drawing.Point(3, 92);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(1341, 510);
            this.fld_grcGroupControl.TabIndex = 4;
            this.fld_grcGroupControl.Tag = "";
            this.fld_grcGroupControl.Text = "Danh sách dữ liệu sai";
            // 
            // fld_lkeCheckDataType
            // 
            this.fld_lkeCheckDataType.BOSAllowAddNew = false;
            this.fld_lkeCheckDataType.BOSAllowDummy = false;
            this.fld_lkeCheckDataType.BOSComment = null;
            this.fld_lkeCheckDataType.BOSDataMember = "";
            this.fld_lkeCheckDataType.BOSDataSource = "MMProductionCostFactors";
            this.fld_lkeCheckDataType.BOSDescription = null;
            this.fld_lkeCheckDataType.BOSError = null;
            this.fld_lkeCheckDataType.BOSFieldGroup = null;
            this.fld_lkeCheckDataType.BOSFieldParent = null;
            this.fld_lkeCheckDataType.BOSFieldRelation = null;
            this.fld_lkeCheckDataType.BOSPrivilege = null;
            this.fld_lkeCheckDataType.BOSPropertyName = null;
            this.fld_lkeCheckDataType.BOSSelectType = "";
            this.fld_lkeCheckDataType.BOSSelectTypeValue = "";
            this.fld_lkeCheckDataType.CurrentDisplayText = null;
            this.fld_lkeCheckDataType.Location = new System.Drawing.Point(403, 49);
            this.fld_lkeCheckDataType.MenuManager = this.screenToolbar;
            this.fld_lkeCheckDataType.Name = "fld_lkeCheckDataType";
            this.fld_lkeCheckDataType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeCheckDataType.Properties.ColumnName = null;
            this.fld_lkeCheckDataType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionCostFactorName", "Tên yếu tố")});
            this.fld_lkeCheckDataType.Properties.DisplayMember = "MMProductionCostFactorName";
            this.fld_lkeCheckDataType.Properties.ValueMember = "MMProductionCostFactorID";
            this.fld_lkeCheckDataType.Screen = null;
            this.fld_lkeCheckDataType.Size = new System.Drawing.Size(324, 20);
            this.fld_lkeCheckDataType.TabIndex = 7;
            this.fld_lkeCheckDataType.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeCheckDataType_QueryPopUp);
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
            this.bosLabel4.Location = new System.Drawing.Point(324, 52);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(64, 13);
            this.bosLabel4.TabIndex = 6;
            this.bosLabel4.Text = "Yếu tố chi phí";
            // 
            // fld_txtProducttionCostNo
            // 
            this.fld_txtProducttionCostNo.BOSComment = "";
            this.fld_txtProducttionCostNo.BOSDataMember = "";
            this.fld_txtProducttionCostNo.BOSDataSource = "";
            this.fld_txtProducttionCostNo.BOSDescription = null;
            this.fld_txtProducttionCostNo.BOSError = "";
            this.fld_txtProducttionCostNo.BOSFieldGroup = "";
            this.fld_txtProducttionCostNo.BOSFieldRelation = "";
            this.fld_txtProducttionCostNo.BOSPrivilege = "";
            this.fld_txtProducttionCostNo.BOSPropertyName = "Text";
            this.fld_txtProducttionCostNo.Location = new System.Drawing.Point(99, 49);
            this.fld_txtProducttionCostNo.Name = "fld_txtProducttionCostNo";
            this.fld_txtProducttionCostNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtProducttionCostNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtProducttionCostNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtProducttionCostNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtProducttionCostNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtProducttionCostNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtProducttionCostNo.Screen = null;
            this.fld_txtProducttionCostNo.Size = new System.Drawing.Size(192, 20);
            this.fld_txtProducttionCostNo.TabIndex = 8;
            this.fld_txtProducttionCostNo.Tag = "DC";
            // 
            // fld_Lablel2
            // 
            this.fld_Lablel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.Options.UseBackColor = true;
            this.fld_Lablel2.Appearance.Options.UseForeColor = true;
            this.fld_Lablel2.BOSComment = "";
            this.fld_Lablel2.BOSDataMember = "";
            this.fld_Lablel2.BOSDataSource = "";
            this.fld_Lablel2.BOSDescription = null;
            this.fld_Lablel2.BOSError = null;
            this.fld_Lablel2.BOSFieldGroup = "";
            this.fld_Lablel2.BOSFieldRelation = "";
            this.fld_Lablel2.BOSPrivilege = "";
            this.fld_Lablel2.BOSPropertyName = null;
            this.fld_Lablel2.Location = new System.Drawing.Point(9, 52);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(83, 13);
            this.fld_Lablel2.TabIndex = 9;
            this.fld_Lablel2.Tag = "";
            this.fld_Lablel2.Text = "Mã chứng từ TGT";
            // 
            // fld_btnCheckData
            // 
            this.fld_btnCheckData.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnCheckData.Appearance.Options.UseForeColor = true;
            this.fld_btnCheckData.BOSComment = "";
            this.fld_btnCheckData.BOSDataMember = "";
            this.fld_btnCheckData.BOSDataSource = "";
            this.fld_btnCheckData.BOSDescription = null;
            this.fld_btnCheckData.BOSError = null;
            this.fld_btnCheckData.BOSFieldGroup = "";
            this.fld_btnCheckData.BOSFieldRelation = "";
            this.fld_btnCheckData.BOSPrivilege = "";
            this.fld_btnCheckData.BOSPropertyName = "";
            this.fld_btnCheckData.Location = new System.Drawing.Point(651, 18);
            this.fld_btnCheckData.Name = "fld_btnCheckData";
            this.fld_btnCheckData.Screen = null;
            this.fld_btnCheckData.Size = new System.Drawing.Size(76, 24);
            this.fld_btnCheckData.TabIndex = 10;
            this.fld_btnCheckData.Tag = "";
            this.fld_btnCheckData.Text = "Kiểm tra";
            this.fld_btnCheckData.Click += new System.EventHandler(this.fld_btnCheckData_Click);
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
            this.bosLabel1.Location = new System.Drawing.Point(9, 23);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(52, 13);
            this.bosLabel1.TabIndex = 6;
            this.bosLabel1.Text = "Công đoạn";
            // 
            // fld_lkeMMOperationID
            // 
            this.fld_lkeMMOperationID.BOSAllowAddNew = false;
            this.fld_lkeMMOperationID.BOSAllowDummy = true;
            this.fld_lkeMMOperationID.BOSComment = null;
            this.fld_lkeMMOperationID.BOSDataMember = "";
            this.fld_lkeMMOperationID.BOSDataSource = "MMOperations";
            this.fld_lkeMMOperationID.BOSDescription = null;
            this.fld_lkeMMOperationID.BOSError = null;
            this.fld_lkeMMOperationID.BOSFieldGroup = null;
            this.fld_lkeMMOperationID.BOSFieldParent = null;
            this.fld_lkeMMOperationID.BOSFieldRelation = null;
            this.fld_lkeMMOperationID.BOSPrivilege = null;
            this.fld_lkeMMOperationID.BOSPropertyName = null;
            this.fld_lkeMMOperationID.BOSSelectType = "MMOperationInOutStockCheck";
            this.fld_lkeMMOperationID.BOSSelectTypeValue = "true";
            this.fld_lkeMMOperationID.CurrentDisplayText = null;
            this.fld_lkeMMOperationID.Location = new System.Drawing.Point(99, 20);
            this.fld_lkeMMOperationID.Name = "fld_lkeMMOperationID";
            this.fld_lkeMMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMOperationID.Properties.ColumnName = null;
            this.fld_lkeMMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên CD")});
            this.fld_lkeMMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeMMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeMMOperationID.Screen = null;
            this.fld_lkeMMOperationID.Size = new System.Drawing.Size(192, 20);
            this.fld_lkeMMOperationID.TabIndex = 7;
            this.fld_lkeMMOperationID.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_lkeMMOperationID_Closed);
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
            this.bosLabel2.Location = new System.Drawing.Point(324, 23);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(60, 13);
            this.bosLabel2.TabIndex = 6;
            this.bosLabel2.Text = "Kỳ giá thành";
            // 
            // fld_dteCheckToDate
            // 
            this.fld_dteCheckToDate.BOSComment = null;
            this.fld_dteCheckToDate.BOSDataMember = "";
            this.fld_dteCheckToDate.BOSDataSource = "";
            this.fld_dteCheckToDate.BOSDescription = null;
            this.fld_dteCheckToDate.BOSError = null;
            this.fld_dteCheckToDate.BOSFieldGroup = null;
            this.fld_dteCheckToDate.BOSFieldRelation = null;
            this.fld_dteCheckToDate.BOSPrivilege = null;
            this.fld_dteCheckToDate.BOSPropertyName = null;
            this.fld_dteCheckToDate.EditValue = null;
            this.fld_dteCheckToDate.Location = new System.Drawing.Point(403, 20);
            this.fld_dteCheckToDate.Name = "fld_dteCheckToDate";
            this.fld_dteCheckToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteCheckToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteCheckToDate.Screen = null;
            this.fld_dteCheckToDate.Size = new System.Drawing.Size(194, 20);
            this.fld_dteCheckToDate.TabIndex = 11;
            this.fld_dteCheckToDate.Tag = "DC";
            this.fld_dteCheckToDate.EditValueChanged += new System.EventHandler(this.fld_dteCheckToDate_EditValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fld_tabProductWorkItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1349, 698);
            this.panel1.TabIndex = 12;
            // 
            // fld_tabProductWorkItem
            // 
            this.fld_tabProductWorkItem.BOSComment = null;
            this.fld_tabProductWorkItem.BOSDataMember = null;
            this.fld_tabProductWorkItem.BOSDataSource = null;
            this.fld_tabProductWorkItem.BOSDescription = null;
            this.fld_tabProductWorkItem.BOSError = null;
            this.fld_tabProductWorkItem.BOSFieldGroup = null;
            this.fld_tabProductWorkItem.BOSFieldRelation = null;
            this.fld_tabProductWorkItem.BOSPrivilege = null;
            this.fld_tabProductWorkItem.BOSPropertyName = null;
            this.fld_tabProductWorkItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tabProductWorkItem.Location = new System.Drawing.Point(0, 0);
            this.fld_tabProductWorkItem.Name = "fld_tabProductWorkItem";
            this.fld_tabProductWorkItem.Screen = null;
            this.fld_tabProductWorkItem.SelectedTabPage = this.fld_tabProduct;
            this.fld_tabProductWorkItem.Size = new System.Drawing.Size(1349, 698);
            this.fld_tabProductWorkItem.TabIndex = 6;
            this.fld_tabProductWorkItem.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabProduct,
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.fld_xtabNVLChinhKPB});
            // 
            // fld_tabProduct
            // 
            this.fld_tabProduct.Controls.Add(this.bosLine1);
            this.fld_tabProduct.Controls.Add(this.bosLine2);
            this.fld_tabProduct.Controls.Add(this.fld_grcGroupControl);
            this.fld_tabProduct.Name = "fld_tabProduct";
            this.fld_tabProduct.Size = new System.Drawing.Size(1347, 673);
            this.fld_tabProduct.Text = "Chi phí xuất kho VT, NL không phân bổ hết";
            // 
            // bosLine1
            // 
            this.bosLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_lkeMMOperationID);
            this.bosLine1.Controls.Add(this.fld_dteCheckToDate);
            this.bosLine1.Controls.Add(this.bosLabel4);
            this.bosLine1.Controls.Add(this.fld_btnCheckData);
            this.bosLine1.Controls.Add(this.bosLabel2);
            this.bosLine1.Controls.Add(this.fld_txtProducttionCostNo);
            this.bosLine1.Controls.Add(this.bosLabel1);
            this.bosLine1.Controls.Add(this.fld_Lablel2);
            this.bosLine1.Controls.Add(this.fld_lkeCheckDataType);
            this.bosLine1.Location = new System.Drawing.Point(3, 3);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(1341, 83);
            this.bosLine1.TabIndex = 0;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Thông tin tiềm kiếm";
            // 
            // bosLine2
            // 
            this.bosLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.bosLabel3);
            this.bosLine2.Controls.Add(this.bosButton1);
            this.bosLine2.Controls.Add(this.fld_lkeICImportAndExportReasons);
            this.bosLine2.Location = new System.Drawing.Point(3, 606);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(1341, 65);
            this.bosLine2.TabIndex = 5;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Xử lý dữ liệu";
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
            this.bosLabel3.Location = new System.Drawing.Point(8, 25);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(78, 13);
            this.bosLabel3.TabIndex = 6;
            this.bosLabel3.Text = "Lý do nhập xuất";
            // 
            // bosButton1
            // 
            this.bosButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosButton1.Appearance.Options.UseForeColor = true;
            this.bosButton1.BOSComment = "";
            this.bosButton1.BOSDataMember = "";
            this.bosButton1.BOSDataSource = "";
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = "";
            this.bosButton1.BOSFieldRelation = "";
            this.bosButton1.BOSPrivilege = "";
            this.bosButton1.BOSPropertyName = "";
            this.bosButton1.Location = new System.Drawing.Point(710, 18);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(76, 24);
            this.bosButton1.TabIndex = 10;
            this.bosButton1.Tag = "";
            this.bosButton1.Text = "Cập nhật";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
            // 
            // fld_lkeICImportAndExportReasons
            // 
            this.fld_lkeICImportAndExportReasons.BOSAllowAddNew = false;
            this.fld_lkeICImportAndExportReasons.BOSAllowDummy = false;
            this.fld_lkeICImportAndExportReasons.BOSComment = null;
            this.fld_lkeICImportAndExportReasons.BOSDataMember = "";
            this.fld_lkeICImportAndExportReasons.BOSDataSource = "ICImportAndExportReasons";
            this.fld_lkeICImportAndExportReasons.BOSDescription = null;
            this.fld_lkeICImportAndExportReasons.BOSError = null;
            this.fld_lkeICImportAndExportReasons.BOSFieldGroup = null;
            this.fld_lkeICImportAndExportReasons.BOSFieldParent = null;
            this.fld_lkeICImportAndExportReasons.BOSFieldRelation = null;
            this.fld_lkeICImportAndExportReasons.BOSPrivilege = null;
            this.fld_lkeICImportAndExportReasons.BOSPropertyName = null;
            this.fld_lkeICImportAndExportReasons.BOSSelectType = "ICImportAndExportReasonType";
            this.fld_lkeICImportAndExportReasons.BOSSelectTypeValue = "Export";
            this.fld_lkeICImportAndExportReasons.CurrentDisplayText = null;
            this.fld_lkeICImportAndExportReasons.Location = new System.Drawing.Point(108, 22);
            this.fld_lkeICImportAndExportReasons.MenuManager = this.screenToolbar;
            this.fld_lkeICImportAndExportReasons.Name = "fld_lkeICImportAndExportReasons";
            this.fld_lkeICImportAndExportReasons.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICImportAndExportReasons.Properties.ColumnName = null;
            this.fld_lkeICImportAndExportReasons.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICImportAndExportReasonName", "Lý do")});
            this.fld_lkeICImportAndExportReasons.Properties.DisplayMember = "ICImportAndExportReasonName";
            this.fld_lkeICImportAndExportReasons.Properties.ValueMember = "ICImportAndExportReasonID";
            this.fld_lkeICImportAndExportReasons.Screen = null;
            this.fld_lkeICImportAndExportReasons.Size = new System.Drawing.Size(557, 20);
            this.fld_lkeICImportAndExportReasons.TabIndex = 7;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.bosLine7);
            this.xtraTabPage1.Controls.Add(this.fld_gcTab1);
            this.xtraTabPage1.Controls.Add(this.bosLine3);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1347, 673);
            this.xtraTabPage1.Text = "Kiểm tra vật tư, NL xuất sau khi nhập đủ BTP";
            // 
            // bosLine7
            // 
            this.bosLine7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine7.BOSComment = null;
            this.bosLine7.BOSDataMember = null;
            this.bosLine7.BOSDataSource = null;
            this.bosLine7.BOSDescription = null;
            this.bosLine7.BOSError = null;
            this.bosLine7.BOSFieldGroup = null;
            this.bosLine7.BOSFieldRelation = null;
            this.bosLine7.BOSPrivilege = null;
            this.bosLine7.BOSPropertyName = null;
            this.bosLine7.Controls.Add(this.bosLabel18);
            this.bosLine7.Controls.Add(this.fld_btnUpdateReferItem);
            this.bosLine7.Controls.Add(this.fld_btnUpdateSelectItem);
            this.bosLine7.Controls.Add(this.fld_lkeICImportAndExportReasonsTab1);
            this.bosLine7.Location = new System.Drawing.Point(5, 597);
            this.bosLine7.Name = "bosLine7";
            this.bosLine7.Screen = null;
            this.bosLine7.Size = new System.Drawing.Size(1341, 65);
            this.bosLine7.TabIndex = 6;
            this.bosLine7.TabStop = false;
            this.bosLine7.Text = "Xử lý dữ liệu";
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
            this.bosLabel18.Location = new System.Drawing.Point(8, 25);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(78, 13);
            this.bosLabel18.TabIndex = 6;
            this.bosLabel18.Text = "Lý do nhập xuất";
            // 
            // fld_btnUpdateReferItem
            // 
            this.fld_btnUpdateReferItem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnUpdateReferItem.Appearance.Options.UseForeColor = true;
            this.fld_btnUpdateReferItem.BOSComment = "";
            this.fld_btnUpdateReferItem.BOSDataMember = "";
            this.fld_btnUpdateReferItem.BOSDataSource = "";
            this.fld_btnUpdateReferItem.BOSDescription = null;
            this.fld_btnUpdateReferItem.BOSError = null;
            this.fld_btnUpdateReferItem.BOSFieldGroup = "";
            this.fld_btnUpdateReferItem.BOSFieldRelation = "";
            this.fld_btnUpdateReferItem.BOSPrivilege = "";
            this.fld_btnUpdateReferItem.BOSPropertyName = "";
            this.fld_btnUpdateReferItem.Location = new System.Drawing.Point(843, 20);
            this.fld_btnUpdateReferItem.Name = "fld_btnUpdateReferItem";
            this.fld_btnUpdateReferItem.Screen = null;
            this.fld_btnUpdateReferItem.Size = new System.Drawing.Size(139, 24);
            this.fld_btnUpdateReferItem.TabIndex = 10;
            this.fld_btnUpdateReferItem.Tag = "";
            this.fld_btnUpdateReferItem.Text = "Cập nhật chứng từ";
            this.fld_btnUpdateReferItem.Click += new System.EventHandler(this.fld_btnUpdateReferItem_Click);
            // 
            // fld_btnUpdateSelectItem
            // 
            this.fld_btnUpdateSelectItem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnUpdateSelectItem.Appearance.Options.UseForeColor = true;
            this.fld_btnUpdateSelectItem.BOSComment = "";
            this.fld_btnUpdateSelectItem.BOSDataMember = "";
            this.fld_btnUpdateSelectItem.BOSDataSource = "";
            this.fld_btnUpdateSelectItem.BOSDescription = null;
            this.fld_btnUpdateSelectItem.BOSError = null;
            this.fld_btnUpdateSelectItem.BOSFieldGroup = "";
            this.fld_btnUpdateSelectItem.BOSFieldRelation = "";
            this.fld_btnUpdateSelectItem.BOSPrivilege = "";
            this.fld_btnUpdateSelectItem.BOSPropertyName = "";
            this.fld_btnUpdateSelectItem.Location = new System.Drawing.Point(688, 20);
            this.fld_btnUpdateSelectItem.Name = "fld_btnUpdateSelectItem";
            this.fld_btnUpdateSelectItem.Screen = null;
            this.fld_btnUpdateSelectItem.Size = new System.Drawing.Size(139, 24);
            this.fld_btnUpdateSelectItem.TabIndex = 10;
            this.fld_btnUpdateSelectItem.Tag = "";
            this.fld_btnUpdateSelectItem.Text = "Cập nhật CT đã chọn";
            this.fld_btnUpdateSelectItem.Click += new System.EventHandler(this.fld_btnUpdateSelectItem_Click);
            // 
            // fld_lkeICImportAndExportReasonsTab1
            // 
            this.fld_lkeICImportAndExportReasonsTab1.BOSAllowAddNew = false;
            this.fld_lkeICImportAndExportReasonsTab1.BOSAllowDummy = false;
            this.fld_lkeICImportAndExportReasonsTab1.BOSComment = null;
            this.fld_lkeICImportAndExportReasonsTab1.BOSDataMember = "";
            this.fld_lkeICImportAndExportReasonsTab1.BOSDataSource = "ICImportAndExportReasons";
            this.fld_lkeICImportAndExportReasonsTab1.BOSDescription = null;
            this.fld_lkeICImportAndExportReasonsTab1.BOSError = null;
            this.fld_lkeICImportAndExportReasonsTab1.BOSFieldGroup = null;
            this.fld_lkeICImportAndExportReasonsTab1.BOSFieldParent = null;
            this.fld_lkeICImportAndExportReasonsTab1.BOSFieldRelation = null;
            this.fld_lkeICImportAndExportReasonsTab1.BOSPrivilege = null;
            this.fld_lkeICImportAndExportReasonsTab1.BOSPropertyName = null;
            this.fld_lkeICImportAndExportReasonsTab1.BOSSelectType = "ICImportAndExportReasonType";
            this.fld_lkeICImportAndExportReasonsTab1.BOSSelectTypeValue = "Export";
            this.fld_lkeICImportAndExportReasonsTab1.CurrentDisplayText = null;
            this.fld_lkeICImportAndExportReasonsTab1.Location = new System.Drawing.Point(108, 22);
            this.fld_lkeICImportAndExportReasonsTab1.MenuManager = this.screenToolbar;
            this.fld_lkeICImportAndExportReasonsTab1.Name = "fld_lkeICImportAndExportReasonsTab1";
            this.fld_lkeICImportAndExportReasonsTab1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICImportAndExportReasonsTab1.Properties.ColumnName = null;
            this.fld_lkeICImportAndExportReasonsTab1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICImportAndExportReasonName", "Lý do")});
            this.fld_lkeICImportAndExportReasonsTab1.Properties.DisplayMember = "ICImportAndExportReasonName";
            this.fld_lkeICImportAndExportReasonsTab1.Properties.ValueMember = "ICImportAndExportReasonID";
            this.fld_lkeICImportAndExportReasonsTab1.Screen = null;
            this.fld_lkeICImportAndExportReasonsTab1.Size = new System.Drawing.Size(557, 20);
            this.fld_lkeICImportAndExportReasonsTab1.TabIndex = 7;
            // 
            // fld_gcTab1
            // 
            this.fld_gcTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_gcTab1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_gcTab1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_gcTab1.Appearance.Options.UseBackColor = true;
            this.fld_gcTab1.Appearance.Options.UseForeColor = true;
            this.fld_gcTab1.BOSComment = "";
            this.fld_gcTab1.BOSDataMember = "";
            this.fld_gcTab1.BOSDataSource = "";
            this.fld_gcTab1.BOSDescription = null;
            this.fld_gcTab1.BOSError = null;
            this.fld_gcTab1.BOSFieldGroup = "";
            this.fld_gcTab1.BOSFieldRelation = "";
            this.fld_gcTab1.BOSPrivilege = "";
            this.fld_gcTab1.BOSPropertyName = "";
            this.fld_gcTab1.Controls.Add(this.fld_dgcCheckShipmentAffterCompleteReceipt);
            this.fld_gcTab1.Location = new System.Drawing.Point(3, 81);
            this.fld_gcTab1.Name = "fld_gcTab1";
            this.fld_gcTab1.Screen = null;
            this.fld_gcTab1.Size = new System.Drawing.Size(1341, 510);
            this.fld_gcTab1.TabIndex = 5;
            this.fld_gcTab1.Tag = "";
            this.fld_gcTab1.Text = "Danh sách dữ liệu sai";
            // 
            // fld_dgcCheckShipmentAffterCompleteReceipt
            // 
            this.fld_dgcCheckShipmentAffterCompleteReceipt.AllowDrop = true;
            this.fld_dgcCheckShipmentAffterCompleteReceipt.BOSComment = "";
            this.fld_dgcCheckShipmentAffterCompleteReceipt.BOSDataMember = null;
            this.fld_dgcCheckShipmentAffterCompleteReceipt.BOSDataSource = "CheckShipmentAffterCompleteReceipt";
            this.fld_dgcCheckShipmentAffterCompleteReceipt.BOSDescription = null;
            this.fld_dgcCheckShipmentAffterCompleteReceipt.BOSError = "";
            this.fld_dgcCheckShipmentAffterCompleteReceipt.BOSFieldGroup = "";
            this.fld_dgcCheckShipmentAffterCompleteReceipt.BOSFieldRelation = null;
            this.fld_dgcCheckShipmentAffterCompleteReceipt.BOSGridType = null;
            this.fld_dgcCheckShipmentAffterCompleteReceipt.BOSPrivilege = "";
            this.fld_dgcCheckShipmentAffterCompleteReceipt.BOSPropertyName = null;
            this.fld_dgcCheckShipmentAffterCompleteReceipt.CommodityType = "";
            this.fld_dgcCheckShipmentAffterCompleteReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcCheckShipmentAffterCompleteReceipt.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcCheckShipmentAffterCompleteReceipt.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcCheckShipmentAffterCompleteReceipt.MainView = this.gridView2;
            this.fld_dgcCheckShipmentAffterCompleteReceipt.Name = "fld_dgcCheckShipmentAffterCompleteReceipt";
            this.fld_dgcCheckShipmentAffterCompleteReceipt.PrintReport = false;
            this.fld_dgcCheckShipmentAffterCompleteReceipt.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcCheckShipmentAffterCompleteReceipt, true);
            this.fld_dgcCheckShipmentAffterCompleteReceipt.Size = new System.Drawing.Size(1337, 485);
            this.fld_dgcCheckShipmentAffterCompleteReceipt.TabIndex = 7;
            this.fld_dgcCheckShipmentAffterCompleteReceipt.Tag = "DC";
            this.fld_dgcCheckShipmentAffterCompleteReceipt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcCheckShipmentAffterCompleteReceipt;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // bosLine3
            // 
            this.bosLine3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine3.BOSComment = null;
            this.bosLine3.BOSDataMember = null;
            this.bosLine3.BOSDataSource = null;
            this.bosLine3.BOSDescription = null;
            this.bosLine3.BOSError = null;
            this.bosLine3.BOSFieldGroup = null;
            this.bosLine3.BOSFieldRelation = null;
            this.bosLine3.BOSPrivilege = null;
            this.bosLine3.BOSPropertyName = null;
            this.bosLine3.Controls.Add(this.fld_lkeICShipmentTypeCombo);
            this.bosLine3.Controls.Add(this.fld_lkeMMoperation1);
            this.bosLine3.Controls.Add(this.fld_dteCostDate1);
            this.bosLine3.Controls.Add(this.fld_btnChecktab1);
            this.bosLine3.Controls.Add(this.bosLabel5);
            this.bosLine3.Controls.Add(this.bosLabel6);
            this.bosLine3.Controls.Add(this.bosLabel7);
            this.bosLine3.Location = new System.Drawing.Point(2, 3);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(1341, 83);
            this.bosLine3.TabIndex = 1;
            this.bosLine3.TabStop = false;
            this.bosLine3.Text = "Thông tin tiềm kiếm";
            // 
            // fld_lkeICShipmentTypeCombo
            // 
            this.fld_lkeICShipmentTypeCombo.BOSAllowAddNew = false;
            this.fld_lkeICShipmentTypeCombo.BOSAllowDummy = true;
            this.fld_lkeICShipmentTypeCombo.BOSComment = null;
            this.fld_lkeICShipmentTypeCombo.BOSDataMember = "ICShipmentTypeCombo";
            this.fld_lkeICShipmentTypeCombo.BOSDataSource = "ICShipments";
            this.fld_lkeICShipmentTypeCombo.BOSDescription = null;
            this.fld_lkeICShipmentTypeCombo.BOSError = null;
            this.fld_lkeICShipmentTypeCombo.BOSFieldGroup = null;
            this.fld_lkeICShipmentTypeCombo.BOSFieldParent = null;
            this.fld_lkeICShipmentTypeCombo.BOSFieldRelation = null;
            this.fld_lkeICShipmentTypeCombo.BOSPrivilege = null;
            this.fld_lkeICShipmentTypeCombo.BOSPropertyName = null;
            this.fld_lkeICShipmentTypeCombo.BOSSelectType = "";
            this.fld_lkeICShipmentTypeCombo.BOSSelectTypeValue = "";
            this.fld_lkeICShipmentTypeCombo.CurrentDisplayText = null;
            this.fld_lkeICShipmentTypeCombo.Location = new System.Drawing.Point(118, 46);
            this.fld_lkeICShipmentTypeCombo.Name = "fld_lkeICShipmentTypeCombo";
            this.fld_lkeICShipmentTypeCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICShipmentTypeCombo.Properties.ColumnName = null;
            this.fld_lkeICShipmentTypeCombo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên CD")});
            this.fld_lkeICShipmentTypeCombo.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeICShipmentTypeCombo.Properties.ValueMember = "MMOperationID";
            this.fld_lkeICShipmentTypeCombo.Screen = null;
            this.fld_lkeICShipmentTypeCombo.Size = new System.Drawing.Size(192, 20);
            this.fld_lkeICShipmentTypeCombo.TabIndex = 7;
            // 
            // fld_lkeMMoperation1
            // 
            this.fld_lkeMMoperation1.BOSAllowAddNew = false;
            this.fld_lkeMMoperation1.BOSAllowDummy = true;
            this.fld_lkeMMoperation1.BOSComment = null;
            this.fld_lkeMMoperation1.BOSDataMember = "";
            this.fld_lkeMMoperation1.BOSDataSource = "MMOperations";
            this.fld_lkeMMoperation1.BOSDescription = null;
            this.fld_lkeMMoperation1.BOSError = null;
            this.fld_lkeMMoperation1.BOSFieldGroup = null;
            this.fld_lkeMMoperation1.BOSFieldParent = null;
            this.fld_lkeMMoperation1.BOSFieldRelation = null;
            this.fld_lkeMMoperation1.BOSPrivilege = null;
            this.fld_lkeMMoperation1.BOSPropertyName = null;
            this.fld_lkeMMoperation1.BOSSelectType = "MMOperationInOutStockCheck";
            this.fld_lkeMMoperation1.BOSSelectTypeValue = "true";
            this.fld_lkeMMoperation1.CurrentDisplayText = null;
            this.fld_lkeMMoperation1.Location = new System.Drawing.Point(118, 20);
            this.fld_lkeMMoperation1.Name = "fld_lkeMMoperation1";
            this.fld_lkeMMoperation1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMoperation1.Properties.ColumnName = null;
            this.fld_lkeMMoperation1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên CD")});
            this.fld_lkeMMoperation1.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeMMoperation1.Properties.ValueMember = "MMOperationID";
            this.fld_lkeMMoperation1.Screen = null;
            this.fld_lkeMMoperation1.Size = new System.Drawing.Size(192, 20);
            this.fld_lkeMMoperation1.TabIndex = 7;
            // 
            // fld_dteCostDate1
            // 
            this.fld_dteCostDate1.BOSComment = null;
            this.fld_dteCostDate1.BOSDataMember = "";
            this.fld_dteCostDate1.BOSDataSource = "";
            this.fld_dteCostDate1.BOSDescription = null;
            this.fld_dteCostDate1.BOSError = null;
            this.fld_dteCostDate1.BOSFieldGroup = null;
            this.fld_dteCostDate1.BOSFieldRelation = null;
            this.fld_dteCostDate1.BOSPrivilege = null;
            this.fld_dteCostDate1.BOSPropertyName = null;
            this.fld_dteCostDate1.EditValue = null;
            this.fld_dteCostDate1.Location = new System.Drawing.Point(403, 20);
            this.fld_dteCostDate1.Name = "fld_dteCostDate1";
            this.fld_dteCostDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteCostDate1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteCostDate1.Screen = null;
            this.fld_dteCostDate1.Size = new System.Drawing.Size(194, 20);
            this.fld_dteCostDate1.TabIndex = 11;
            this.fld_dteCostDate1.Tag = "DC";
            // 
            // fld_btnChecktab1
            // 
            this.fld_btnChecktab1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnChecktab1.Appearance.Options.UseForeColor = true;
            this.fld_btnChecktab1.BOSComment = "";
            this.fld_btnChecktab1.BOSDataMember = "";
            this.fld_btnChecktab1.BOSDataSource = "";
            this.fld_btnChecktab1.BOSDescription = null;
            this.fld_btnChecktab1.BOSError = null;
            this.fld_btnChecktab1.BOSFieldGroup = "";
            this.fld_btnChecktab1.BOSFieldRelation = "";
            this.fld_btnChecktab1.BOSPrivilege = "";
            this.fld_btnChecktab1.BOSPropertyName = "";
            this.fld_btnChecktab1.Location = new System.Drawing.Point(710, 18);
            this.fld_btnChecktab1.Name = "fld_btnChecktab1";
            this.fld_btnChecktab1.Screen = null;
            this.fld_btnChecktab1.Size = new System.Drawing.Size(76, 24);
            this.fld_btnChecktab1.TabIndex = 10;
            this.fld_btnChecktab1.Tag = "";
            this.fld_btnChecktab1.Text = "Kiểm tra";
            this.fld_btnChecktab1.Click += new System.EventHandler(this.fld_btnChecktab1_Click);
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
            this.bosLabel5.Location = new System.Drawing.Point(9, 49);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(91, 13);
            this.bosLabel5.TabIndex = 6;
            this.bosLabel5.Text = "Loại chứng từ xuất";
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
            this.bosLabel6.Location = new System.Drawing.Point(337, 23);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(60, 13);
            this.bosLabel6.TabIndex = 6;
            this.bosLabel6.Text = "Kỳ giá thành";
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
            this.bosLabel7.Location = new System.Drawing.Point(9, 23);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(52, 13);
            this.bosLabel7.TabIndex = 6;
            this.bosLabel7.Text = "Công đoạn";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.bosLine5);
            this.xtraTabPage2.Controls.Add(this.fld_bgrTab2);
            this.xtraTabPage2.Controls.Add(this.bosLine4);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1347, 673);
            this.xtraTabPage2.Text = "Xuất sai công đoạn so với lý do nhập xuất";
            // 
            // bosLine5
            // 
            this.bosLine5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine5.BOSComment = null;
            this.bosLine5.BOSDataMember = null;
            this.bosLine5.BOSDataSource = null;
            this.bosLine5.BOSDescription = null;
            this.bosLine5.BOSError = null;
            this.bosLine5.BOSFieldGroup = null;
            this.bosLine5.BOSFieldRelation = null;
            this.bosLine5.BOSPrivilege = null;
            this.bosLine5.BOSPropertyName = null;
            this.bosLine5.Controls.Add(this.bosLabel12);
            this.bosLine5.Controls.Add(this.fld_btnUpdateTab2);
            this.bosLine5.Controls.Add(this.fld_lkeUpdateMMOperationIDTab2);
            this.bosLine5.Location = new System.Drawing.Point(4, 606);
            this.bosLine5.Name = "bosLine5";
            this.bosLine5.Screen = null;
            this.bosLine5.Size = new System.Drawing.Size(1341, 65);
            this.bosLine5.TabIndex = 7;
            this.bosLine5.TabStop = false;
            this.bosLine5.Text = "Xử lý dữ liệu";
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
            this.bosLabel12.Location = new System.Drawing.Point(8, 25);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(97, 13);
            this.bosLabel12.TabIndex = 6;
            this.bosLabel12.Text = "Công đoạn cập nhật";
            // 
            // fld_btnUpdateTab2
            // 
            this.fld_btnUpdateTab2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnUpdateTab2.Appearance.Options.UseForeColor = true;
            this.fld_btnUpdateTab2.BOSComment = "";
            this.fld_btnUpdateTab2.BOSDataMember = "";
            this.fld_btnUpdateTab2.BOSDataSource = "";
            this.fld_btnUpdateTab2.BOSDescription = null;
            this.fld_btnUpdateTab2.BOSError = null;
            this.fld_btnUpdateTab2.BOSFieldGroup = "";
            this.fld_btnUpdateTab2.BOSFieldRelation = "";
            this.fld_btnUpdateTab2.BOSPrivilege = "";
            this.fld_btnUpdateTab2.BOSPropertyName = "";
            this.fld_btnUpdateTab2.Location = new System.Drawing.Point(336, 20);
            this.fld_btnUpdateTab2.Name = "fld_btnUpdateTab2";
            this.fld_btnUpdateTab2.Screen = null;
            this.fld_btnUpdateTab2.Size = new System.Drawing.Size(76, 24);
            this.fld_btnUpdateTab2.TabIndex = 10;
            this.fld_btnUpdateTab2.Tag = "";
            this.fld_btnUpdateTab2.Text = "Cập nhật";
            this.fld_btnUpdateTab2.Click += new System.EventHandler(this.fld_btnUpdateTab2_Click);
            // 
            // fld_lkeUpdateMMOperationIDTab2
            // 
            this.fld_lkeUpdateMMOperationIDTab2.BOSAllowAddNew = false;
            this.fld_lkeUpdateMMOperationIDTab2.BOSAllowDummy = true;
            this.fld_lkeUpdateMMOperationIDTab2.BOSComment = null;
            this.fld_lkeUpdateMMOperationIDTab2.BOSDataMember = "";
            this.fld_lkeUpdateMMOperationIDTab2.BOSDataSource = "MMOperations";
            this.fld_lkeUpdateMMOperationIDTab2.BOSDescription = null;
            this.fld_lkeUpdateMMOperationIDTab2.BOSError = null;
            this.fld_lkeUpdateMMOperationIDTab2.BOSFieldGroup = null;
            this.fld_lkeUpdateMMOperationIDTab2.BOSFieldParent = null;
            this.fld_lkeUpdateMMOperationIDTab2.BOSFieldRelation = null;
            this.fld_lkeUpdateMMOperationIDTab2.BOSPrivilege = null;
            this.fld_lkeUpdateMMOperationIDTab2.BOSPropertyName = null;
            this.fld_lkeUpdateMMOperationIDTab2.BOSSelectType = "MMOperationInOutStockCheck";
            this.fld_lkeUpdateMMOperationIDTab2.BOSSelectTypeValue = "true";
            this.fld_lkeUpdateMMOperationIDTab2.CurrentDisplayText = null;
            this.fld_lkeUpdateMMOperationIDTab2.Location = new System.Drawing.Point(123, 22);
            this.fld_lkeUpdateMMOperationIDTab2.Name = "fld_lkeUpdateMMOperationIDTab2";
            this.fld_lkeUpdateMMOperationIDTab2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeUpdateMMOperationIDTab2.Properties.ColumnName = null;
            this.fld_lkeUpdateMMOperationIDTab2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên CD")});
            this.fld_lkeUpdateMMOperationIDTab2.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeUpdateMMOperationIDTab2.Properties.ValueMember = "MMOperationID";
            this.fld_lkeUpdateMMOperationIDTab2.Screen = null;
            this.fld_lkeUpdateMMOperationIDTab2.Size = new System.Drawing.Size(192, 20);
            this.fld_lkeUpdateMMOperationIDTab2.TabIndex = 7;
            // 
            // fld_bgrTab2
            // 
            this.fld_bgrTab2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_bgrTab2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_bgrTab2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_bgrTab2.Appearance.Options.UseBackColor = true;
            this.fld_bgrTab2.Appearance.Options.UseForeColor = true;
            this.fld_bgrTab2.BOSComment = "";
            this.fld_bgrTab2.BOSDataMember = "";
            this.fld_bgrTab2.BOSDataSource = "";
            this.fld_bgrTab2.BOSDescription = null;
            this.fld_bgrTab2.BOSError = null;
            this.fld_bgrTab2.BOSFieldGroup = "";
            this.fld_bgrTab2.BOSFieldRelation = "";
            this.fld_bgrTab2.BOSPrivilege = "";
            this.fld_bgrTab2.BOSPropertyName = "";
            this.fld_bgrTab2.Location = new System.Drawing.Point(4, 92);
            this.fld_bgrTab2.Name = "fld_bgrTab2";
            this.fld_bgrTab2.Screen = null;
            this.fld_bgrTab2.Size = new System.Drawing.Size(1341, 510);
            this.fld_bgrTab2.TabIndex = 6;
            this.fld_bgrTab2.Tag = "";
            this.fld_bgrTab2.Text = "Danh sách dữ liệu sai";
            // 
            // bosLine4
            // 
            this.bosLine4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine4.BOSComment = null;
            this.bosLine4.BOSDataMember = null;
            this.bosLine4.BOSDataSource = null;
            this.bosLine4.BOSDescription = null;
            this.bosLine4.BOSError = null;
            this.bosLine4.BOSFieldGroup = null;
            this.bosLine4.BOSFieldRelation = null;
            this.bosLine4.BOSPrivilege = null;
            this.bosLine4.BOSPropertyName = null;
            this.bosLine4.Controls.Add(this.fld_lkeShipmentTypeTab2);
            this.bosLine4.Controls.Add(this.bosLabel11);
            this.bosLine4.Controls.Add(this.fld_lkeMMOperationTab2);
            this.bosLine4.Controls.Add(this.bosLabel8);
            this.bosLine4.Controls.Add(this.fld_lkeICImportAndExportReasonsTab2);
            this.bosLine4.Controls.Add(this.fld_dteDateTab2);
            this.bosLine4.Controls.Add(this.fld_btnCheckTab2);
            this.bosLine4.Controls.Add(this.bosLabel9);
            this.bosLine4.Controls.Add(this.bosLabel10);
            this.bosLine4.Location = new System.Drawing.Point(4, 3);
            this.bosLine4.Name = "bosLine4";
            this.bosLine4.Screen = null;
            this.bosLine4.Size = new System.Drawing.Size(1341, 83);
            this.bosLine4.TabIndex = 1;
            this.bosLine4.TabStop = false;
            this.bosLine4.Text = "Thông tin tiềm kiếm";
            // 
            // fld_lkeShipmentTypeTab2
            // 
            this.fld_lkeShipmentTypeTab2.BOSAllowAddNew = false;
            this.fld_lkeShipmentTypeTab2.BOSAllowDummy = true;
            this.fld_lkeShipmentTypeTab2.BOSComment = null;
            this.fld_lkeShipmentTypeTab2.BOSDataMember = "ICShipmentTypeCombo";
            this.fld_lkeShipmentTypeTab2.BOSDataSource = "ICShipments";
            this.fld_lkeShipmentTypeTab2.BOSDescription = null;
            this.fld_lkeShipmentTypeTab2.BOSError = null;
            this.fld_lkeShipmentTypeTab2.BOSFieldGroup = null;
            this.fld_lkeShipmentTypeTab2.BOSFieldParent = null;
            this.fld_lkeShipmentTypeTab2.BOSFieldRelation = null;
            this.fld_lkeShipmentTypeTab2.BOSPrivilege = null;
            this.fld_lkeShipmentTypeTab2.BOSPropertyName = null;
            this.fld_lkeShipmentTypeTab2.BOSSelectType = "";
            this.fld_lkeShipmentTypeTab2.BOSSelectTypeValue = "";
            this.fld_lkeShipmentTypeTab2.CurrentDisplayText = null;
            this.fld_lkeShipmentTypeTab2.Location = new System.Drawing.Point(108, 46);
            this.fld_lkeShipmentTypeTab2.Name = "fld_lkeShipmentTypeTab2";
            this.fld_lkeShipmentTypeTab2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeShipmentTypeTab2.Properties.ColumnName = null;
            this.fld_lkeShipmentTypeTab2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên CD")});
            this.fld_lkeShipmentTypeTab2.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeShipmentTypeTab2.Properties.ValueMember = "MMOperationID";
            this.fld_lkeShipmentTypeTab2.Screen = null;
            this.fld_lkeShipmentTypeTab2.Size = new System.Drawing.Size(192, 20);
            this.fld_lkeShipmentTypeTab2.TabIndex = 15;
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
            this.bosLabel11.Location = new System.Drawing.Point(7, 49);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(91, 13);
            this.bosLabel11.TabIndex = 14;
            this.bosLabel11.Text = "Loại chứng từ xuất";
            // 
            // fld_lkeMMOperationTab2
            // 
            this.fld_lkeMMOperationTab2.BOSAllowAddNew = false;
            this.fld_lkeMMOperationTab2.BOSAllowDummy = true;
            this.fld_lkeMMOperationTab2.BOSComment = null;
            this.fld_lkeMMOperationTab2.BOSDataMember = "";
            this.fld_lkeMMOperationTab2.BOSDataSource = "MMOperations";
            this.fld_lkeMMOperationTab2.BOSDescription = null;
            this.fld_lkeMMOperationTab2.BOSError = null;
            this.fld_lkeMMOperationTab2.BOSFieldGroup = null;
            this.fld_lkeMMOperationTab2.BOSFieldParent = null;
            this.fld_lkeMMOperationTab2.BOSFieldRelation = null;
            this.fld_lkeMMOperationTab2.BOSPrivilege = null;
            this.fld_lkeMMOperationTab2.BOSPropertyName = null;
            this.fld_lkeMMOperationTab2.BOSSelectType = "MMOperationInOutStockCheck";
            this.fld_lkeMMOperationTab2.BOSSelectTypeValue = "true";
            this.fld_lkeMMOperationTab2.CurrentDisplayText = null;
            this.fld_lkeMMOperationTab2.Location = new System.Drawing.Point(473, 46);
            this.fld_lkeMMOperationTab2.Name = "fld_lkeMMOperationTab2";
            this.fld_lkeMMOperationTab2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMOperationTab2.Properties.ColumnName = null;
            this.fld_lkeMMOperationTab2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên CD")});
            this.fld_lkeMMOperationTab2.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeMMOperationTab2.Properties.ValueMember = "MMOperationID";
            this.fld_lkeMMOperationTab2.Screen = null;
            this.fld_lkeMMOperationTab2.Size = new System.Drawing.Size(192, 20);
            this.fld_lkeMMOperationTab2.TabIndex = 7;
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
            this.bosLabel8.Location = new System.Drawing.Point(8, 25);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(78, 13);
            this.bosLabel8.TabIndex = 12;
            this.bosLabel8.Text = "Lý do nhập xuất";
            // 
            // fld_lkeICImportAndExportReasonsTab2
            // 
            this.fld_lkeICImportAndExportReasonsTab2.BOSAllowAddNew = false;
            this.fld_lkeICImportAndExportReasonsTab2.BOSAllowDummy = false;
            this.fld_lkeICImportAndExportReasonsTab2.BOSComment = null;
            this.fld_lkeICImportAndExportReasonsTab2.BOSDataMember = "";
            this.fld_lkeICImportAndExportReasonsTab2.BOSDataSource = "ICImportAndExportReasons";
            this.fld_lkeICImportAndExportReasonsTab2.BOSDescription = null;
            this.fld_lkeICImportAndExportReasonsTab2.BOSError = null;
            this.fld_lkeICImportAndExportReasonsTab2.BOSFieldGroup = null;
            this.fld_lkeICImportAndExportReasonsTab2.BOSFieldParent = null;
            this.fld_lkeICImportAndExportReasonsTab2.BOSFieldRelation = null;
            this.fld_lkeICImportAndExportReasonsTab2.BOSPrivilege = null;
            this.fld_lkeICImportAndExportReasonsTab2.BOSPropertyName = null;
            this.fld_lkeICImportAndExportReasonsTab2.BOSSelectType = "ICImportAndExportReasonType";
            this.fld_lkeICImportAndExportReasonsTab2.BOSSelectTypeValue = "Export";
            this.fld_lkeICImportAndExportReasonsTab2.CurrentDisplayText = null;
            this.fld_lkeICImportAndExportReasonsTab2.Location = new System.Drawing.Point(108, 22);
            this.fld_lkeICImportAndExportReasonsTab2.MenuManager = this.screenToolbar;
            this.fld_lkeICImportAndExportReasonsTab2.Name = "fld_lkeICImportAndExportReasonsTab2";
            this.fld_lkeICImportAndExportReasonsTab2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICImportAndExportReasonsTab2.Properties.ColumnName = null;
            this.fld_lkeICImportAndExportReasonsTab2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICImportAndExportReasonName", "Lý do")});
            this.fld_lkeICImportAndExportReasonsTab2.Properties.DisplayMember = "ICImportAndExportReasonName";
            this.fld_lkeICImportAndExportReasonsTab2.Properties.ValueMember = "ICImportAndExportReasonID";
            this.fld_lkeICImportAndExportReasonsTab2.Screen = null;
            this.fld_lkeICImportAndExportReasonsTab2.Size = new System.Drawing.Size(557, 20);
            this.fld_lkeICImportAndExportReasonsTab2.TabIndex = 13;
            // 
            // fld_dteDateTab2
            // 
            this.fld_dteDateTab2.BOSComment = null;
            this.fld_dteDateTab2.BOSDataMember = "";
            this.fld_dteDateTab2.BOSDataSource = "";
            this.fld_dteDateTab2.BOSDescription = null;
            this.fld_dteDateTab2.BOSError = null;
            this.fld_dteDateTab2.BOSFieldGroup = null;
            this.fld_dteDateTab2.BOSFieldRelation = null;
            this.fld_dteDateTab2.BOSPrivilege = null;
            this.fld_dteDateTab2.BOSPropertyName = null;
            this.fld_dteDateTab2.EditValue = null;
            this.fld_dteDateTab2.Location = new System.Drawing.Point(783, 22);
            this.fld_dteDateTab2.Name = "fld_dteDateTab2";
            this.fld_dteDateTab2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteDateTab2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteDateTab2.Screen = null;
            this.fld_dteDateTab2.Size = new System.Drawing.Size(194, 20);
            this.fld_dteDateTab2.TabIndex = 11;
            this.fld_dteDateTab2.Tag = "DC";
            // 
            // fld_btnCheckTab2
            // 
            this.fld_btnCheckTab2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnCheckTab2.Appearance.Options.UseForeColor = true;
            this.fld_btnCheckTab2.BOSComment = "";
            this.fld_btnCheckTab2.BOSDataMember = "";
            this.fld_btnCheckTab2.BOSDataSource = "";
            this.fld_btnCheckTab2.BOSDescription = null;
            this.fld_btnCheckTab2.BOSError = null;
            this.fld_btnCheckTab2.BOSFieldGroup = "";
            this.fld_btnCheckTab2.BOSFieldRelation = "";
            this.fld_btnCheckTab2.BOSPrivilege = "";
            this.fld_btnCheckTab2.BOSPropertyName = "";
            this.fld_btnCheckTab2.Location = new System.Drawing.Point(901, 44);
            this.fld_btnCheckTab2.Name = "fld_btnCheckTab2";
            this.fld_btnCheckTab2.Screen = null;
            this.fld_btnCheckTab2.Size = new System.Drawing.Size(76, 24);
            this.fld_btnCheckTab2.TabIndex = 10;
            this.fld_btnCheckTab2.Tag = "";
            this.fld_btnCheckTab2.Text = "Kiểm tra";
            this.fld_btnCheckTab2.Click += new System.EventHandler(this.fld_btnCheckTab2_Click);
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
            this.bosLabel9.Location = new System.Drawing.Point(704, 25);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(53, 13);
            this.bosLabel9.TabIndex = 6;
            this.bosLabel9.Text = "Kỳ kiểm tra";
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
            this.bosLabel10.Location = new System.Drawing.Point(318, 49);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(112, 13);
            this.bosLabel10.TabIndex = 6;
            this.bosLabel10.Text = "CĐ tương ứng với lý do";
            // 
            // fld_xtabNVLChinhKPB
            // 
            this.fld_xtabNVLChinhKPB.Controls.Add(this.bosGroupControl1);
            this.fld_xtabNVLChinhKPB.Controls.Add(this.bosLine6);
            this.fld_xtabNVLChinhKPB.Name = "fld_xtabNVLChinhKPB";
            this.fld_xtabNVLChinhKPB.Size = new System.Drawing.Size(1333, 666);
            this.fld_xtabNVLChinhKPB.Text = "Chi phí BTP không phân bổ do hoàn thành trước kỳ";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosGroupControl1.Appearance.Options.UseBackColor = true;
            this.bosGroupControl1.Appearance.Options.UseForeColor = true;
            this.bosGroupControl1.BOSComment = "";
            this.bosGroupControl1.BOSDataMember = "";
            this.bosGroupControl1.BOSDataSource = "";
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = "";
            this.bosGroupControl1.BOSFieldRelation = "";
            this.bosGroupControl1.BOSPrivilege = "";
            this.bosGroupControl1.BOSPropertyName = "";
            this.bosGroupControl1.Controls.Add(this.fld_tclProductTabControl);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 82);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(1327, 581);
            this.bosGroupControl1.TabIndex = 5;
            this.bosGroupControl1.Tag = "";
            this.bosGroupControl1.Text = "Danh sách dữ liệu sai";
            // 
            // fld_tclProductTabControl
            // 
            this.fld_tclProductTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tclProductTabControl.Location = new System.Drawing.Point(2, 23);
            this.fld_tclProductTabControl.Name = "fld_tclProductTabControl";
            this.fld_tclProductTabControl.SelectedTabPage = this.xtraTabPage3;
            this.fld_tclProductTabControl.Size = new System.Drawing.Size(1323, 556);
            this.fld_tclProductTabControl.TabIndex = 337;
            this.fld_tclProductTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.bosPanel1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1321, 531);
            this.xtraTabPage3.Text = "DS chi tiết không phân bổ hết";
            // 
            // bosPanel1
            // 
            this.bosPanel1.AutoScroll = true;
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_dgcCheckCostGridControl);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1321, 531);
            this.bosPanel1.TabIndex = 335;
            // 
            // fld_dgcCheckCostGridControl
            // 
            this.fld_dgcCheckCostGridControl.AllowDrop = true;
            this.fld_dgcCheckCostGridControl.BOSComment = "";
            this.fld_dgcCheckCostGridControl.BOSDataMember = null;
            this.fld_dgcCheckCostGridControl.BOSDataSource = "CheckCost";
            this.fld_dgcCheckCostGridControl.BOSDescription = null;
            this.fld_dgcCheckCostGridControl.BOSError = "";
            this.fld_dgcCheckCostGridControl.BOSFieldGroup = "";
            this.fld_dgcCheckCostGridControl.BOSFieldRelation = null;
            this.fld_dgcCheckCostGridControl.BOSGridType = null;
            this.fld_dgcCheckCostGridControl.BOSPrivilege = "";
            this.fld_dgcCheckCostGridControl.BOSPropertyName = null;
            this.fld_dgcCheckCostGridControl.CommodityType = "";
            this.fld_dgcCheckCostGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcCheckCostGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcCheckCostGridControl.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcCheckCostGridControl.MainView = this.gridView38;
            this.fld_dgcCheckCostGridControl.Name = "fld_dgcCheckCostGridControl";
            this.fld_dgcCheckCostGridControl.PrintReport = false;
            this.fld_dgcCheckCostGridControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcCheckCostGridControl, true);
            this.fld_dgcCheckCostGridControl.Size = new System.Drawing.Size(1321, 531);
            this.fld_dgcCheckCostGridControl.TabIndex = 6;
            this.fld_dgcCheckCostGridControl.Tag = "DC";
            this.fld_dgcCheckCostGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView38});
            // 
            // gridView38
            // 
            this.gridView38.GridControl = this.fld_dgcCheckCostGridControl;
            this.gridView38.Name = "gridView38";
            this.gridView38.PaintStyleName = "Office2003";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.fld_dgcMMCostUpdatePrices);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1321, 531);
            this.xtraTabPage4.Text = "Lịch sử chuyển chi phí";
            // 
            // fld_dgcMMCostUpdatePrices
            // 
            this.fld_dgcMMCostUpdatePrices.AllowDrop = true;
            this.fld_dgcMMCostUpdatePrices.BOSComment = "";
            this.fld_dgcMMCostUpdatePrices.BOSDataMember = null;
            this.fld_dgcMMCostUpdatePrices.BOSDataSource = "MMCostUpdatePrices";
            this.fld_dgcMMCostUpdatePrices.BOSDescription = null;
            this.fld_dgcMMCostUpdatePrices.BOSError = "";
            this.fld_dgcMMCostUpdatePrices.BOSFieldGroup = "";
            this.fld_dgcMMCostUpdatePrices.BOSFieldRelation = null;
            this.fld_dgcMMCostUpdatePrices.BOSGridType = null;
            this.fld_dgcMMCostUpdatePrices.BOSPrivilege = "";
            this.fld_dgcMMCostUpdatePrices.BOSPropertyName = null;
            this.fld_dgcMMCostUpdatePrices.CommodityType = "";
            this.fld_dgcMMCostUpdatePrices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMCostUpdatePrices.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMCostUpdatePrices.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMMCostUpdatePrices.MainView = this.gridView1;
            this.fld_dgcMMCostUpdatePrices.Name = "fld_dgcMMCostUpdatePrices";
            this.fld_dgcMMCostUpdatePrices.PrintReport = false;
            this.fld_dgcMMCostUpdatePrices.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMCostUpdatePrices, true);
            this.fld_dgcMMCostUpdatePrices.Size = new System.Drawing.Size(1321, 531);
            this.fld_dgcMMCostUpdatePrices.TabIndex = 7;
            this.fld_dgcMMCostUpdatePrices.Tag = "DC";
            this.fld_dgcMMCostUpdatePrices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcMMCostUpdatePrices;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // bosLine6
            // 
            this.bosLine6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine6.BOSComment = null;
            this.bosLine6.BOSDataMember = null;
            this.bosLine6.BOSDataSource = null;
            this.bosLine6.BOSDescription = null;
            this.bosLine6.BOSError = null;
            this.bosLine6.BOSFieldGroup = null;
            this.bosLine6.BOSFieldRelation = null;
            this.bosLine6.BOSPrivilege = null;
            this.bosLine6.BOSPropertyName = null;
            this.bosLine6.Controls.Add(this.fld_lkePrevMMOperationID);
            this.bosLine6.Controls.Add(this.bosLabel17);
            this.bosLine6.Controls.Add(this.fld_btnOperation3);
            this.bosLine6.Controls.Add(this.fld_dteCheckToDate3);
            this.bosLine6.Controls.Add(this.bosLabel13);
            this.bosLine6.Controls.Add(this.fld_btnUpdatePrice);
            this.bosLine6.Controls.Add(this.fld_btnCheckData3);
            this.bosLine6.Controls.Add(this.bosLabel14);
            this.bosLine6.Controls.Add(this.fld_txtProducttionCostNo3);
            this.bosLine6.Controls.Add(this.bosLabel15);
            this.bosLine6.Controls.Add(this.bosLabel16);
            this.bosLine6.Controls.Add(this.fld_lkeCheckDataType3);
            this.bosLine6.Location = new System.Drawing.Point(2, 3);
            this.bosLine6.Name = "bosLine6";
            this.bosLine6.Screen = null;
            this.bosLine6.Size = new System.Drawing.Size(1327, 83);
            this.bosLine6.TabIndex = 1;
            this.bosLine6.TabStop = false;
            this.bosLine6.Text = "Thông tin tiềm kiếm";
            // 
            // fld_lkePrevMMOperationID
            // 
            this.fld_lkePrevMMOperationID.BOSAllowAddNew = false;
            this.fld_lkePrevMMOperationID.BOSAllowDummy = true;
            this.fld_lkePrevMMOperationID.BOSComment = null;
            this.fld_lkePrevMMOperationID.BOSDataMember = "";
            this.fld_lkePrevMMOperationID.BOSDataSource = "MMOperations";
            this.fld_lkePrevMMOperationID.BOSDescription = null;
            this.fld_lkePrevMMOperationID.BOSError = null;
            this.fld_lkePrevMMOperationID.BOSFieldGroup = null;
            this.fld_lkePrevMMOperationID.BOSFieldParent = null;
            this.fld_lkePrevMMOperationID.BOSFieldRelation = null;
            this.fld_lkePrevMMOperationID.BOSPrivilege = null;
            this.fld_lkePrevMMOperationID.BOSPropertyName = null;
            this.fld_lkePrevMMOperationID.BOSSelectType = "MMOperationInOutStockCheck";
            this.fld_lkePrevMMOperationID.BOSSelectTypeValue = "true";
            this.fld_lkePrevMMOperationID.CurrentDisplayText = null;
            this.fld_lkePrevMMOperationID.Location = new System.Drawing.Point(782, 20);
            this.fld_lkePrevMMOperationID.Name = "fld_lkePrevMMOperationID";
            this.fld_lkePrevMMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkePrevMMOperationID.Properties.ColumnName = null;
            this.fld_lkePrevMMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên CD")});
            this.fld_lkePrevMMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkePrevMMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkePrevMMOperationID.Screen = null;
            this.fld_lkePrevMMOperationID.Size = new System.Drawing.Size(154, 20);
            this.fld_lkePrevMMOperationID.TabIndex = 13;
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
            this.bosLabel17.Location = new System.Drawing.Point(649, 23);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(117, 13);
            this.bosLabel17.TabIndex = 12;
            this.bosLabel17.Text = "CD thành phẩm kỳ trước";
            // 
            // fld_btnOperation3
            // 
            this.fld_btnOperation3.BOSAllowAddNew = false;
            this.fld_btnOperation3.BOSAllowDummy = true;
            this.fld_btnOperation3.BOSComment = null;
            this.fld_btnOperation3.BOSDataMember = "";
            this.fld_btnOperation3.BOSDataSource = "MMOperations";
            this.fld_btnOperation3.BOSDescription = null;
            this.fld_btnOperation3.BOSError = null;
            this.fld_btnOperation3.BOSFieldGroup = null;
            this.fld_btnOperation3.BOSFieldParent = null;
            this.fld_btnOperation3.BOSFieldRelation = null;
            this.fld_btnOperation3.BOSPrivilege = null;
            this.fld_btnOperation3.BOSPropertyName = null;
            this.fld_btnOperation3.BOSSelectType = "MMOperationInOutStockCheck";
            this.fld_btnOperation3.BOSSelectTypeValue = "true";
            this.fld_btnOperation3.CurrentDisplayText = null;
            this.fld_btnOperation3.Location = new System.Drawing.Point(99, 20);
            this.fld_btnOperation3.Name = "fld_btnOperation3";
            this.fld_btnOperation3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_btnOperation3.Properties.ColumnName = null;
            this.fld_btnOperation3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên CD")});
            this.fld_btnOperation3.Properties.DisplayMember = "MMOperationName";
            this.fld_btnOperation3.Properties.ValueMember = "MMOperationID";
            this.fld_btnOperation3.Screen = null;
            this.fld_btnOperation3.Size = new System.Drawing.Size(192, 20);
            this.fld_btnOperation3.TabIndex = 7;
            this.fld_btnOperation3.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_btnOperation3_Closed);
            // 
            // fld_dteCheckToDate3
            // 
            this.fld_dteCheckToDate3.BOSComment = null;
            this.fld_dteCheckToDate3.BOSDataMember = "";
            this.fld_dteCheckToDate3.BOSDataSource = "";
            this.fld_dteCheckToDate3.BOSDescription = null;
            this.fld_dteCheckToDate3.BOSError = null;
            this.fld_dteCheckToDate3.BOSFieldGroup = null;
            this.fld_dteCheckToDate3.BOSFieldRelation = null;
            this.fld_dteCheckToDate3.BOSPrivilege = null;
            this.fld_dteCheckToDate3.BOSPropertyName = null;
            this.fld_dteCheckToDate3.EditValue = null;
            this.fld_dteCheckToDate3.Location = new System.Drawing.Point(403, 20);
            this.fld_dteCheckToDate3.Name = "fld_dteCheckToDate3";
            this.fld_dteCheckToDate3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteCheckToDate3.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteCheckToDate3.Screen = null;
            this.fld_dteCheckToDate3.Size = new System.Drawing.Size(194, 20);
            this.fld_dteCheckToDate3.TabIndex = 11;
            this.fld_dteCheckToDate3.Tag = "DC";
            this.fld_dteCheckToDate3.EditValueChanged += new System.EventHandler(this.fld_dteCheckToDate3_EditValueChanged);
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
            this.bosLabel13.Location = new System.Drawing.Point(324, 52);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(64, 13);
            this.bosLabel13.TabIndex = 6;
            this.bosLabel13.Text = "Yếu tố chi phí";
            // 
            // fld_btnUpdatePrice
            // 
            this.fld_btnUpdatePrice.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnUpdatePrice.Appearance.Options.UseForeColor = true;
            this.fld_btnUpdatePrice.BOSComment = "";
            this.fld_btnUpdatePrice.BOSDataMember = "";
            this.fld_btnUpdatePrice.BOSDataSource = "";
            this.fld_btnUpdatePrice.BOSDescription = null;
            this.fld_btnUpdatePrice.BOSError = null;
            this.fld_btnUpdatePrice.BOSFieldGroup = "";
            this.fld_btnUpdatePrice.BOSFieldRelation = "";
            this.fld_btnUpdatePrice.BOSPrivilege = "";
            this.fld_btnUpdatePrice.BOSPropertyName = "";
            this.fld_btnUpdatePrice.Location = new System.Drawing.Point(987, 47);
            this.fld_btnUpdatePrice.Name = "fld_btnUpdatePrice";
            this.fld_btnUpdatePrice.Screen = null;
            this.fld_btnUpdatePrice.Size = new System.Drawing.Size(121, 24);
            this.fld_btnUpdatePrice.TabIndex = 10;
            this.fld_btnUpdatePrice.Tag = "";
            this.fld_btnUpdatePrice.Text = "Cập nhật";
            this.fld_btnUpdatePrice.Click += new System.EventHandler(this.fld_btnUpdatePrice_Click);
            // 
            // fld_btnCheckData3
            // 
            this.fld_btnCheckData3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnCheckData3.Appearance.Options.UseForeColor = true;
            this.fld_btnCheckData3.BOSComment = "";
            this.fld_btnCheckData3.BOSDataMember = "";
            this.fld_btnCheckData3.BOSDataSource = "";
            this.fld_btnCheckData3.BOSDescription = null;
            this.fld_btnCheckData3.BOSError = null;
            this.fld_btnCheckData3.BOSFieldGroup = "";
            this.fld_btnCheckData3.BOSFieldRelation = "";
            this.fld_btnCheckData3.BOSPrivilege = "";
            this.fld_btnCheckData3.BOSPropertyName = "";
            this.fld_btnCheckData3.Location = new System.Drawing.Point(987, 18);
            this.fld_btnCheckData3.Name = "fld_btnCheckData3";
            this.fld_btnCheckData3.Screen = null;
            this.fld_btnCheckData3.Size = new System.Drawing.Size(121, 24);
            this.fld_btnCheckData3.TabIndex = 10;
            this.fld_btnCheckData3.Tag = "";
            this.fld_btnCheckData3.Text = "Kiểm tra";
            this.fld_btnCheckData3.Click += new System.EventHandler(this.fld_btnCheckData3_Click);
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
            this.bosLabel14.Location = new System.Drawing.Point(324, 23);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(60, 13);
            this.bosLabel14.TabIndex = 6;
            this.bosLabel14.Text = "Kỳ giá thành";
            // 
            // fld_txtProducttionCostNo3
            // 
            this.fld_txtProducttionCostNo3.BOSComment = "";
            this.fld_txtProducttionCostNo3.BOSDataMember = "";
            this.fld_txtProducttionCostNo3.BOSDataSource = "";
            this.fld_txtProducttionCostNo3.BOSDescription = null;
            this.fld_txtProducttionCostNo3.BOSError = "";
            this.fld_txtProducttionCostNo3.BOSFieldGroup = "";
            this.fld_txtProducttionCostNo3.BOSFieldRelation = "";
            this.fld_txtProducttionCostNo3.BOSPrivilege = "";
            this.fld_txtProducttionCostNo3.BOSPropertyName = "Text";
            this.fld_txtProducttionCostNo3.Location = new System.Drawing.Point(99, 49);
            this.fld_txtProducttionCostNo3.Name = "fld_txtProducttionCostNo3";
            this.fld_txtProducttionCostNo3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtProducttionCostNo3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtProducttionCostNo3.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtProducttionCostNo3.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtProducttionCostNo3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtProducttionCostNo3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtProducttionCostNo3.Screen = null;
            this.fld_txtProducttionCostNo3.Size = new System.Drawing.Size(192, 20);
            this.fld_txtProducttionCostNo3.TabIndex = 8;
            this.fld_txtProducttionCostNo3.Tag = "DC";
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
            this.bosLabel15.Location = new System.Drawing.Point(9, 23);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(52, 13);
            this.bosLabel15.TabIndex = 6;
            this.bosLabel15.Text = "Công đoạn";
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
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(9, 52);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(83, 13);
            this.bosLabel16.TabIndex = 9;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Mã chứng từ TGT";
            // 
            // fld_lkeCheckDataType3
            // 
            this.fld_lkeCheckDataType3.BOSAllowAddNew = false;
            this.fld_lkeCheckDataType3.BOSAllowDummy = false;
            this.fld_lkeCheckDataType3.BOSComment = null;
            this.fld_lkeCheckDataType3.BOSDataMember = "";
            this.fld_lkeCheckDataType3.BOSDataSource = "MMProductionCostFactors";
            this.fld_lkeCheckDataType3.BOSDescription = null;
            this.fld_lkeCheckDataType3.BOSError = null;
            this.fld_lkeCheckDataType3.BOSFieldGroup = null;
            this.fld_lkeCheckDataType3.BOSFieldParent = null;
            this.fld_lkeCheckDataType3.BOSFieldRelation = null;
            this.fld_lkeCheckDataType3.BOSPrivilege = null;
            this.fld_lkeCheckDataType3.BOSPropertyName = null;
            this.fld_lkeCheckDataType3.BOSSelectType = "";
            this.fld_lkeCheckDataType3.BOSSelectTypeValue = "";
            this.fld_lkeCheckDataType3.CurrentDisplayText = null;
            this.fld_lkeCheckDataType3.Location = new System.Drawing.Point(403, 49);
            this.fld_lkeCheckDataType3.MenuManager = this.screenToolbar;
            this.fld_lkeCheckDataType3.Name = "fld_lkeCheckDataType3";
            this.fld_lkeCheckDataType3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeCheckDataType3.Properties.ColumnName = null;
            this.fld_lkeCheckDataType3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionCostFactorName", "Tên yếu tố")});
            this.fld_lkeCheckDataType3.Properties.DisplayMember = "MMProductionCostFactorName";
            this.fld_lkeCheckDataType3.Properties.ValueMember = "MMProductionCostFactorID";
            this.fld_lkeCheckDataType3.Screen = null;
            this.fld_lkeCheckDataType3.Size = new System.Drawing.Size(363, 20);
            this.fld_lkeCheckDataType3.TabIndex = 7;
            this.fld_lkeCheckDataType3.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeCheckDataType3_QueryPopUp);
            // 
            // DMID100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1349, 698);
            this.Controls.Add(this.panel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMID100.IconOptions.Icon")));
            this.Name = "DMID100";
            this.Text = "kiểm tra dữ liệu TGT";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeCheckDataType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProducttionCostNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCheckToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCheckToDate.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductWorkItem)).EndInit();
            this.fld_tabProductWorkItem.ResumeLayout(false);
            this.fld_tabProduct.ResumeLayout(false);
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            this.bosLine2.ResumeLayout(false);
            this.bosLine2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICImportAndExportReasons.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.bosLine7.ResumeLayout(false);
            this.bosLine7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICImportAndExportReasonsTab1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_gcTab1)).EndInit();
            this.fld_gcTab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCheckShipmentAffterCompleteReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.bosLine3.ResumeLayout(false);
            this.bosLine3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICShipmentTypeCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMoperation1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCostDate1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCostDate1.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.bosLine5.ResumeLayout(false);
            this.bosLine5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeUpdateMMOperationIDTab2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_bgrTab2)).EndInit();
            this.bosLine4.ResumeLayout(false);
            this.bosLine4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeShipmentTypeTab2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationTab2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICImportAndExportReasonsTab2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDateTab2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDateTab2.Properties)).EndInit();
            this.fld_xtabNVLChinhKPB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tclProductTabControl)).EndInit();
            this.fld_tclProductTabControl.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcCheckCostGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView38)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMCostUpdatePrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.bosLine6.ResumeLayout(false);
            this.bosLine6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkePrevMMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_btnOperation3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCheckToDate3.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteCheckToDate3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProducttionCostNo3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeCheckDataType3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        public BOSComponent.BOSGroupControl fld_grcGroupControl;
        private BOSComponent.BOSLookupEdit fld_lkeCheckDataType;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtProducttionCostNo;
        private BOSComponent.BOSLabel fld_Lablel2;
        private BOSComponent.BOSButton fld_btnCheckData;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeMMOperationID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteCheckToDate;
        private Panel panel1;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSLookupEdit fld_lkeICImportAndExportReasons;
        private BOSComponent.BOSTabControl fld_tabProductWorkItem;
        private DevExpress.XtraTab.XtraTabPage fld_tabProduct;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private BOSComponent.BOSLine bosLine3;
        private BOSComponent.BOSLookupEdit fld_lkeICShipmentTypeCombo;
        private BOSComponent.BOSLookupEdit fld_lkeMMoperation1;
        private BOSComponent.BOSDateEdit fld_dteCostDate1;
        private BOSComponent.BOSButton fld_btnChecktab1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel7;
        public BOSComponent.BOSGroupControl fld_gcTab1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSLine bosLine5;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSButton fld_btnUpdateTab2;
        private BOSComponent.BOSLookupEdit fld_lkeUpdateMMOperationIDTab2;
        public BOSComponent.BOSGroupControl fld_bgrTab2;
        private BOSComponent.BOSLine bosLine4;
        private BOSComponent.BOSLookupEdit fld_lkeShipmentTypeTab2;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeMMOperationTab2;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeICImportAndExportReasonsTab2;
        private BOSComponent.BOSDateEdit fld_dteDateTab2;
        private BOSComponent.BOSButton fld_btnCheckTab2;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel10;
        private DevExpress.XtraTab.XtraTabPage fld_xtabNVLChinhKPB;
        public BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLine bosLine6;
        private BOSComponent.BOSLookupEdit fld_btnOperation3;
        private BOSComponent.BOSDateEdit fld_dteCheckToDate3;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSButton fld_btnCheckData3;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSTextBox fld_txtProducttionCostNo3;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeCheckDataType3;
        private BOSComponent.BOSLookupEdit fld_lkePrevMMOperationID;
        private BOSComponent.BOSLabel bosLabel17;
        private CheckCostGridControl fld_dgcCheckCostGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView38;
        private DevExpress.XtraTab.XtraTabControl fld_tclProductTabControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private BOSComponent.BOSPanel bosPanel1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private MMCostUpdatePricesGridControl fld_dgcMMCostUpdatePrices;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSButton fld_btnUpdatePrice;
        private CheckShipmentAffterFullReceiptGridControl fld_dgcCheckShipmentAffterCompleteReceipt;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSLine bosLine7;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSButton fld_btnUpdateReferItem;
        private BOSComponent.BOSButton fld_btnUpdateSelectItem;
        private BOSComponent.BOSLookupEdit fld_lkeICImportAndExportReasonsTab1;
    }
}
