using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.InventoryStatistics.UI
{
	/// <summary>
    /// Summary description for DMACIB100
	/// </summary>
    partial class DMISS100
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
            this.fld_lkeMMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_chkIsGroupByStock = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_tabProductTask = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabStatistics = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcInventoryStatistics = new BOSERP.Modules.InventoryStatistics.InventoryStatisticsGridControl();
            this.fld_dgvARSaleOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_btnInventoryStattistics = new BOSComponent.BOSButton(this.components);
            this.fld_cmbViewType = new BOSComponent.BOSComboBox(this.components);
            this.fld_lkeICProductGroupID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_APSupplierID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeICDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeICStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_Lablel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkIsGroupByStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductTask)).BeginInit();
            this.fld_tabProductTask.SuspendLayout();
            this.fld_tabStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcInventoryStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbViewType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_lkeMMBatchProductID);
            this.bosPanel1.Controls.Add(this.fld_chkIsGroupByStock);
            this.bosPanel1.Controls.Add(this.fld_tabProductTask);
            this.bosPanel1.Controls.Add(this.fld_dteToDate);
            this.bosPanel1.Controls.Add(this.fld_dteFromDate);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_btnPrint);
            this.bosPanel1.Controls.Add(this.fld_btnInventoryStattistics);
            this.bosPanel1.Controls.Add(this.fld_cmbViewType);
            this.bosPanel1.Controls.Add(this.fld_lkeICProductGroupID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_APSupplierID);
            this.bosPanel1.Controls.Add(this.fld_lkeICDepartmentID);
            this.bosPanel1.Controls.Add(this.fld_lkeICStockID);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_Lablel3);
            this.bosPanel1.Controls.Add(this.bosLabel16);
            this.bosPanel1.Controls.Add(this.bosLabel15);
            this.bosPanel1.Controls.Add(this.fld_lkeICProductID);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.bosLabel13);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.bosLabel14);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(941, 596);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeMMBatchProductID
            // 
            this.fld_lkeMMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeMMBatchProductID.BOSComment = "";
            this.fld_lkeMMBatchProductID.BOSDataMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductID.BOSDescription = null;
            this.fld_lkeMMBatchProductID.BOSError = null;
            this.fld_lkeMMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeMMBatchProductID.BOSFieldParent = null;
            this.fld_lkeMMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeMMBatchProductID.BOSPrivilege = null;
            this.fld_lkeMMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductID.BOSSelectType = null;
            this.fld_lkeMMBatchProductID.BOSSelectTypeValue = null;
            this.fld_lkeMMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeMMBatchProductID.Location = new System.Drawing.Point(684, 8);
            this.fld_lkeMMBatchProductID.Name = "fld_lkeMMBatchProductID";
            this.fld_lkeMMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMBatchProductID.Properties.ColumnName = null;
            this.fld_lkeMMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "LSX")});
            this.fld_lkeMMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeMMBatchProductID.Properties.NullText = "";
            this.fld_lkeMMBatchProductID.Properties.PopupWidth = 40;
            this.fld_lkeMMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.Screen = null;
            this.fld_lkeMMBatchProductID.Size = new System.Drawing.Size(158, 20);
            this.fld_lkeMMBatchProductID.TabIndex = 26;
            this.fld_lkeMMBatchProductID.Tag = "DC";
            // 
            // fld_chkIsGroupByStock
            // 
            this.fld_chkIsGroupByStock.BOSComment = null;
            this.fld_chkIsGroupByStock.BOSDataMember = "";
            this.fld_chkIsGroupByStock.BOSDataSource = "";
            this.fld_chkIsGroupByStock.BOSDescription = null;
            this.fld_chkIsGroupByStock.BOSError = null;
            this.fld_chkIsGroupByStock.BOSFieldGroup = null;
            this.fld_chkIsGroupByStock.BOSFieldRelation = null;
            this.fld_chkIsGroupByStock.BOSPrivilege = null;
            this.fld_chkIsGroupByStock.BOSPropertyName = "EditValue";
            this.fld_chkIsGroupByStock.Location = new System.Drawing.Point(518, 10);
            this.fld_chkIsGroupByStock.MenuManager = this.screenToolbar;
            this.fld_chkIsGroupByStock.Name = "fld_chkIsGroupByStock";
            this.fld_chkIsGroupByStock.Properties.Caption = "Nhóm theo kho";
            this.fld_chkIsGroupByStock.Screen = null;
            this.fld_chkIsGroupByStock.Size = new System.Drawing.Size(112, 19);
            this.fld_chkIsGroupByStock.TabIndex = 2;
            this.fld_chkIsGroupByStock.Tag = "DC";
            // 
            // fld_tabProductTask
            // 
            this.fld_tabProductTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabProductTask.BOSComment = null;
            this.fld_tabProductTask.BOSDataMember = null;
            this.fld_tabProductTask.BOSDataSource = "";
            this.fld_tabProductTask.BOSDescription = null;
            this.fld_tabProductTask.BOSError = null;
            this.fld_tabProductTask.BOSFieldGroup = null;
            this.fld_tabProductTask.BOSFieldRelation = null;
            this.fld_tabProductTask.BOSPrivilege = null;
            this.fld_tabProductTask.BOSPropertyName = null;
            this.fld_tabProductTask.Location = new System.Drawing.Point(3, 116);
            this.fld_tabProductTask.Name = "fld_tabProductTask";
            this.fld_tabProductTask.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.fld_tabProductTask.Screen = null;
            this.fld_tabProductTask.SelectedTabPage = this.fld_tabStatistics;
            this.fld_tabProductTask.Size = new System.Drawing.Size(935, 477);
            this.fld_tabProductTask.TabIndex = 11;
            this.fld_tabProductTask.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabStatistics});
            // 
            // fld_tabStatistics
            // 
            this.fld_tabStatistics.Controls.Add(this.fld_dgcInventoryStatistics);
            this.fld_tabStatistics.Name = "fld_tabStatistics";
            this.fld_tabStatistics.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.fld_tabStatistics.Size = new System.Drawing.Size(929, 449);
            this.fld_tabStatistics.Text = "Tổng hợp nhật xuất tồn";
            // 
            // fld_dgcInventoryStatistics
            // 
            this.fld_dgcInventoryStatistics.AllowDrop = true;
            this.fld_dgcInventoryStatistics.BOSComment = "";
            this.fld_dgcInventoryStatistics.BOSDataMember = "";
            this.fld_dgcInventoryStatistics.BOSDataSource = "ICTransactions";
            this.fld_dgcInventoryStatistics.BOSDescription = null;
            this.fld_dgcInventoryStatistics.BOSError = null;
            this.fld_dgcInventoryStatistics.BOSFieldGroup = "";
            this.fld_dgcInventoryStatistics.BOSFieldRelation = "";
            this.fld_dgcInventoryStatistics.BOSGridType = null;
            this.fld_dgcInventoryStatistics.BOSPrivilege = "";
            this.fld_dgcInventoryStatistics.BOSPropertyName = "";
            this.fld_dgcInventoryStatistics.CommodityType = "";
            this.fld_dgcInventoryStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcInventoryStatistics.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcInventoryStatistics.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcInventoryStatistics.MainView = this.fld_dgvARSaleOrders;
            this.fld_dgcInventoryStatistics.Name = "fld_dgcInventoryStatistics";
            this.fld_dgcInventoryStatistics.PrintReport = false;
            this.fld_dgcInventoryStatistics.Screen = null;
            this.fld_dgcInventoryStatistics.Size = new System.Drawing.Size(929, 446);
            this.fld_dgcInventoryStatistics.TabIndex = 0;
            this.fld_dgcInventoryStatistics.Tag = "DC";
            this.fld_dgcInventoryStatistics.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrders});
            // 
            // fld_dgvARSaleOrders
            // 
            this.fld_dgvARSaleOrders.GridControl = this.fld_dgcInventoryStatistics;
            this.fld_dgvARSaleOrders.Name = "fld_dgvARSaleOrders";
            this.fld_dgvARSaleOrders.PaintStyleName = "Office2003";
            // 
            // fld_dteToDate
            // 
            this.fld_dteToDate.BOSComment = null;
            this.fld_dteToDate.BOSDataMember = null;
            this.fld_dteToDate.BOSDataSource = null;
            this.fld_dteToDate.BOSDescription = null;
            this.fld_dteToDate.BOSError = null;
            this.fld_dteToDate.BOSFieldGroup = null;
            this.fld_dteToDate.BOSFieldRelation = null;
            this.fld_dteToDate.BOSPrivilege = null;
            this.fld_dteToDate.BOSPropertyName = "EditValue";
            this.fld_dteToDate.EditValue = null;
            this.fld_dteToDate.Location = new System.Drawing.Point(378, 9);
            this.fld_dteToDate.MenuManager = this.screenToolbar;
            this.fld_dteToDate.Name = "fld_dteToDate";
            this.fld_dteToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToDate.Screen = null;
            this.fld_dteToDate.Size = new System.Drawing.Size(134, 20);
            this.fld_dteToDate.TabIndex = 1;
            this.fld_dteToDate.Tag = "DC";
            // 
            // fld_dteFromDate
            // 
            this.fld_dteFromDate.BOSComment = null;
            this.fld_dteFromDate.BOSDataMember = null;
            this.fld_dteFromDate.BOSDataSource = null;
            this.fld_dteFromDate.BOSDescription = null;
            this.fld_dteFromDate.BOSError = null;
            this.fld_dteFromDate.BOSFieldGroup = null;
            this.fld_dteFromDate.BOSFieldRelation = null;
            this.fld_dteFromDate.BOSPrivilege = null;
            this.fld_dteFromDate.BOSPropertyName = "EditValue";
            this.fld_dteFromDate.EditValue = null;
            this.fld_dteFromDate.Location = new System.Drawing.Point(88, 9);
            this.fld_dteFromDate.MenuManager = this.screenToolbar;
            this.fld_dteFromDate.Name = "fld_dteFromDate";
            this.fld_dteFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromDate.Screen = null;
            this.fld_dteFromDate.Size = new System.Drawing.Size(136, 20);
            this.fld_dteFromDate.TabIndex = 0;
            this.fld_dteFromDate.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(307, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 25;
            this.bosLabel1.Text = "Đến ngày";
            // 
            // fld_btnPrint
            // 
            this.fld_btnPrint.BOSComment = null;
            this.fld_btnPrint.BOSDataMember = null;
            this.fld_btnPrint.BOSDataSource = null;
            this.fld_btnPrint.BOSDescription = null;
            this.fld_btnPrint.BOSError = null;
            this.fld_btnPrint.BOSFieldGroup = null;
            this.fld_btnPrint.BOSFieldRelation = null;
            this.fld_btnPrint.BOSPrivilege = null;
            this.fld_btnPrint.BOSPropertyName = null;
            this.fld_btnPrint.Location = new System.Drawing.Point(766, 83);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(76, 27);
            this.fld_btnPrint.TabIndex = 10;
            this.fld_btnPrint.Text = "In";
            this.fld_btnPrint.Click += new System.EventHandler(this.Fld_btnPrint_Click);
            // 
            // fld_btnInventoryStattistics
            // 
            this.fld_btnInventoryStattistics.BOSComment = null;
            this.fld_btnInventoryStattistics.BOSDataMember = null;
            this.fld_btnInventoryStattistics.BOSDataSource = null;
            this.fld_btnInventoryStattistics.BOSDescription = null;
            this.fld_btnInventoryStattistics.BOSError = null;
            this.fld_btnInventoryStattistics.BOSFieldGroup = null;
            this.fld_btnInventoryStattistics.BOSFieldRelation = null;
            this.fld_btnInventoryStattistics.BOSPrivilege = null;
            this.fld_btnInventoryStattistics.BOSPropertyName = null;
            this.fld_btnInventoryStattistics.Location = new System.Drawing.Point(684, 83);
            this.fld_btnInventoryStattistics.Name = "fld_btnInventoryStattistics";
            this.fld_btnInventoryStattistics.Screen = null;
            this.fld_btnInventoryStattistics.Size = new System.Drawing.Size(76, 27);
            this.fld_btnInventoryStattistics.TabIndex = 9;
            this.fld_btnInventoryStattistics.Text = "Xem";
            this.fld_btnInventoryStattistics.Click += new System.EventHandler(this.fld_btnInventoryStattistics_Click);
            // 
            // fld_cmbViewType
            // 
            this.fld_cmbViewType.BOSComment = null;
            this.fld_cmbViewType.BOSDataMember = null;
            this.fld_cmbViewType.BOSDataSource = null;
            this.fld_cmbViewType.BOSDescription = null;
            this.fld_cmbViewType.BOSError = null;
            this.fld_cmbViewType.BOSFieldGroup = null;
            this.fld_cmbViewType.BOSFieldRelation = null;
            this.fld_cmbViewType.BOSPrivilege = null;
            this.fld_cmbViewType.BOSPropertyName = null;
            this.fld_cmbViewType.EditValue = "Tất cả";
            this.fld_cmbViewType.Location = new System.Drawing.Point(88, 61);
            this.fld_cmbViewType.MenuManager = this.screenToolbar;
            this.fld_cmbViewType.Name = "fld_cmbViewType";
            this.fld_cmbViewType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cmbViewType.Properties.Items.AddRange(new object[] {
            "Tất cả",
            "Có tồn"});
            this.fld_cmbViewType.Screen = null;
            this.fld_cmbViewType.Size = new System.Drawing.Size(207, 20);
            this.fld_cmbViewType.TabIndex = 5;
            // 
            // fld_lkeICProductGroupID
            // 
            this.fld_lkeICProductGroupID.BOSAllowAddNew = false;
            this.fld_lkeICProductGroupID.BOSAllowDummy = true;
            this.fld_lkeICProductGroupID.BOSComment = null;
            this.fld_lkeICProductGroupID.BOSDataMember = "ICProductGroupID";
            this.fld_lkeICProductGroupID.BOSDataSource = "ICProductGroups";
            this.fld_lkeICProductGroupID.BOSDescription = null;
            this.fld_lkeICProductGroupID.BOSError = null;
            this.fld_lkeICProductGroupID.BOSFieldGroup = null;
            this.fld_lkeICProductGroupID.BOSFieldParent = null;
            this.fld_lkeICProductGroupID.BOSFieldRelation = null;
            this.fld_lkeICProductGroupID.BOSPrivilege = null;
            this.fld_lkeICProductGroupID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductGroupID.BOSSelectType = null;
            this.fld_lkeICProductGroupID.BOSSelectTypeValue = null;
            this.fld_lkeICProductGroupID.CurrentDisplayText = null;
            this.fld_lkeICProductGroupID.Location = new System.Drawing.Point(378, 35);
            this.fld_lkeICProductGroupID.Name = "fld_lkeICProductGroupID";
            this.fld_lkeICProductGroupID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICProductGroupID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICProductGroupID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductGroupID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductGroupID.Properties.ColumnName = null;
            this.fld_lkeICProductGroupID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductGroupName", "Nhóm hàng")});
            this.fld_lkeICProductGroupID.Properties.DisplayMember = "ICProductGroupName";
            this.fld_lkeICProductGroupID.Properties.NullText = "";
            this.fld_lkeICProductGroupID.Properties.PopupWidth = 40;
            this.fld_lkeICProductGroupID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductGroupID.Properties.ValueMember = "ICProductGroupID";
            this.fld_lkeICProductGroupID.Screen = null;
            this.fld_lkeICProductGroupID.Size = new System.Drawing.Size(252, 20);
            this.fld_lkeICProductGroupID.TabIndex = 4;
            this.fld_lkeICProductGroupID.Tag = "DC";
            // 
            // fld_lkeFK_APSupplierID
            // 
            this.fld_lkeFK_APSupplierID.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID.BOSAllowDummy = true;
            this.fld_lkeFK_APSupplierID.BOSComment = null;
            this.fld_lkeFK_APSupplierID.BOSDataMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID.BOSDataSource = "APSuppliers";
            this.fld_lkeFK_APSupplierID.BOSDescription = null;
            this.fld_lkeFK_APSupplierID.BOSError = null;
            this.fld_lkeFK_APSupplierID.BOSFieldGroup = null;
            this.fld_lkeFK_APSupplierID.BOSFieldParent = null;
            this.fld_lkeFK_APSupplierID.BOSFieldRelation = null;
            this.fld_lkeFK_APSupplierID.BOSPrivilege = null;
            this.fld_lkeFK_APSupplierID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APSupplierID.BOSSelectType = null;
            this.fld_lkeFK_APSupplierID.BOSSelectTypeValue = null;
            this.fld_lkeFK_APSupplierID.CurrentDisplayText = null;
            this.fld_lkeFK_APSupplierID.Location = new System.Drawing.Point(378, 61);
            this.fld_lkeFK_APSupplierID.Name = "fld_lkeFK_APSupplierID";
            this.fld_lkeFK_APSupplierID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APSupplierID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APSupplierID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APSupplierID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APSupplierID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierID.Properties.ColumnName = null;
            this.fld_lkeFK_APSupplierID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Nhà cung cấp")});
            this.fld_lkeFK_APSupplierID.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeFK_APSupplierID.Properties.NullText = "";
            this.fld_lkeFK_APSupplierID.Properties.PopupWidth = 40;
            this.fld_lkeFK_APSupplierID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APSupplierID.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID.Screen = null;
            this.fld_lkeFK_APSupplierID.Size = new System.Drawing.Size(252, 20);
            this.fld_lkeFK_APSupplierID.TabIndex = 6;
            this.fld_lkeFK_APSupplierID.Tag = "DC";
            // 
            // fld_lkeICDepartmentID
            // 
            this.fld_lkeICDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeICDepartmentID.BOSAllowDummy = true;
            this.fld_lkeICDepartmentID.BOSComment = null;
            this.fld_lkeICDepartmentID.BOSDataMember = "ICDepartmentID";
            this.fld_lkeICDepartmentID.BOSDataSource = "ICDepartments";
            this.fld_lkeICDepartmentID.BOSDescription = null;
            this.fld_lkeICDepartmentID.BOSError = null;
            this.fld_lkeICDepartmentID.BOSFieldGroup = null;
            this.fld_lkeICDepartmentID.BOSFieldParent = null;
            this.fld_lkeICDepartmentID.BOSFieldRelation = null;
            this.fld_lkeICDepartmentID.BOSPrivilege = null;
            this.fld_lkeICDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeICDepartmentID.BOSSelectType = null;
            this.fld_lkeICDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeICDepartmentID.CurrentDisplayText = null;
            this.fld_lkeICDepartmentID.Location = new System.Drawing.Point(88, 35);
            this.fld_lkeICDepartmentID.Name = "fld_lkeICDepartmentID";
            this.fld_lkeICDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICDepartmentID.Properties.ColumnName = null;
            this.fld_lkeICDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICDepartmentName", "Ngành hàng")});
            this.fld_lkeICDepartmentID.Properties.DisplayMember = "ICDepartmentName";
            this.fld_lkeICDepartmentID.Properties.NullText = "";
            this.fld_lkeICDepartmentID.Properties.PopupWidth = 40;
            this.fld_lkeICDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICDepartmentID.Properties.ValueMember = "ICDepartmentID";
            this.fld_lkeICDepartmentID.Screen = null;
            this.fld_lkeICDepartmentID.Size = new System.Drawing.Size(207, 20);
            this.fld_lkeICDepartmentID.TabIndex = 3;
            this.fld_lkeICDepartmentID.Tag = "DC";
            // 
            // fld_lkeICStockID
            // 
            this.fld_lkeICStockID.BOSAllowAddNew = false;
            this.fld_lkeICStockID.BOSAllowDummy = true;
            this.fld_lkeICStockID.BOSComment = null;
            this.fld_lkeICStockID.BOSDataMember = "ICStockID";
            this.fld_lkeICStockID.BOSDataSource = "ICStocks";
            this.fld_lkeICStockID.BOSDescription = null;
            this.fld_lkeICStockID.BOSError = null;
            this.fld_lkeICStockID.BOSFieldGroup = null;
            this.fld_lkeICStockID.BOSFieldParent = null;
            this.fld_lkeICStockID.BOSFieldRelation = null;
            this.fld_lkeICStockID.BOSPrivilege = null;
            this.fld_lkeICStockID.BOSPropertyName = "EditValue";
            this.fld_lkeICStockID.BOSSelectType = null;
            this.fld_lkeICStockID.BOSSelectTypeValue = null;
            this.fld_lkeICStockID.CurrentDisplayText = null;
            this.fld_lkeICStockID.Location = new System.Drawing.Point(88, 87);
            this.fld_lkeICStockID.Name = "fld_lkeICStockID";
            this.fld_lkeICStockID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICStockID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICStockID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICStockID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICStockID.Properties.ColumnName = null;
            this.fld_lkeICStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeICStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeICStockID.Properties.NullText = "";
            this.fld_lkeICStockID.Properties.PopupWidth = 40;
            this.fld_lkeICStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeICStockID.Screen = null;
            this.fld_lkeICStockID.Size = new System.Drawing.Size(207, 20);
            this.fld_lkeICStockID.TabIndex = 7;
            this.fld_lkeICStockID.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(307, 64);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(65, 13);
            this.bosLabel6.TabIndex = 20;
            this.bosLabel6.Text = "Nhà cung cấp";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(12, 64);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(45, 13);
            this.bosLabel7.TabIndex = 20;
            this.bosLabel7.Text = "Xem theo";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(307, 38);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(54, 13);
            this.bosLabel5.TabIndex = 20;
            this.bosLabel5.Text = "Nhóm hàng";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(12, 38);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(58, 13);
            this.bosLabel4.TabIndex = 20;
            this.bosLabel4.Text = "Ngành hàng";
            // 
            // fld_Lablel3
            // 
            this.fld_Lablel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_Lablel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel3.Appearance.Options.UseBackColor = true;
            this.fld_Lablel3.Appearance.Options.UseForeColor = true;
            this.fld_Lablel3.BOSComment = null;
            this.fld_Lablel3.BOSDataMember = null;
            this.fld_Lablel3.BOSDataSource = null;
            this.fld_Lablel3.BOSDescription = null;
            this.fld_Lablel3.BOSError = null;
            this.fld_Lablel3.BOSFieldGroup = null;
            this.fld_Lablel3.BOSFieldRelation = null;
            this.fld_Lablel3.BOSPrivilege = null;
            this.fld_Lablel3.BOSPropertyName = null;
            this.fld_Lablel3.Location = new System.Drawing.Point(12, 90);
            this.fld_Lablel3.Name = "fld_Lablel3";
            this.fld_Lablel3.Screen = null;
            this.fld_Lablel3.Size = new System.Drawing.Size(18, 13);
            this.fld_Lablel3.TabIndex = 20;
            this.fld_Lablel3.Text = "Kho";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.bosLabel16.BOSComment = null;
            this.bosLabel16.BOSDataMember = null;
            this.bosLabel16.BOSDataSource = null;
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = null;
            this.bosLabel16.BOSFieldRelation = null;
            this.bosLabel16.BOSPrivilege = null;
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(845, 3);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(20, 40);
            this.bosLabel16.TabIndex = 18;
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = null;
            this.bosLabel15.BOSDataSource = null;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = null;
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(646, 13);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(17, 13);
            this.bosLabel15.TabIndex = 18;
            this.bosLabel15.Text = "LSX";
            // 
            // fld_lkeICProductID
            // 
            this.fld_lkeICProductID.BOSAllowAddNew = false;
            this.fld_lkeICProductID.BOSAllowDummy = true;
            this.fld_lkeICProductID.BOSComment = null;
            this.fld_lkeICProductID.BOSDataMember = "ICProductID";
            this.fld_lkeICProductID.BOSDataSource = "ICProducts";
            this.fld_lkeICProductID.BOSDescription = null;
            this.fld_lkeICProductID.BOSError = null;
            this.fld_lkeICProductID.BOSFieldGroup = null;
            this.fld_lkeICProductID.BOSFieldParent = null;
            this.fld_lkeICProductID.BOSFieldRelation = null;
            this.fld_lkeICProductID.BOSPrivilege = null;
            this.fld_lkeICProductID.BOSPropertyName = null;
            this.fld_lkeICProductID.BOSSelectType = null;
            this.fld_lkeICProductID.BOSSelectTypeValue = null;
            this.fld_lkeICProductID.CurrentDisplayText = null;
            this.fld_lkeICProductID.Location = new System.Drawing.Point(378, 87);
            this.fld_lkeICProductID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductID.Name = "fld_lkeICProductID";
            this.fld_lkeICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductID.Properties.ColumnName = null;
            this.fld_lkeICProductID.Properties.DisplayMember = "ICProductDesc";
            this.fld_lkeICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID.Screen = null;
            this.fld_lkeICProductID.Size = new System.Drawing.Size(252, 20);
            this.fld_lkeICProductID.TabIndex = 8;
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(307, 90);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(47, 13);
            this.bosLabel3.TabIndex = 18;
            this.bosLabel3.Text = "Sản phẩm";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(72, 34);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(10, 21);
            this.bosLabel9.TabIndex = 15;
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = null;
            this.bosLabel13.BOSDataSource = null;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = null;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(296, 80);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(10, 21);
            this.bosLabel13.TabIndex = 15;
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(632, 80);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(20, 21);
            this.bosLabel12.TabIndex = 15;
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(634, 56);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(15, 21);
            this.bosLabel11.TabIndex = 15;
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = null;
            this.bosLabel14.BOSDataSource = null;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(296, 30);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(10, 21);
            this.bosLabel14.TabIndex = 15;
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(634, 30);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(20, 21);
            this.bosLabel10.TabIndex = 15;
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(55, 8);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(15, 21);
            this.bosLabel8.TabIndex = 15;
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(12, 12);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(40, 13);
            this.bosLabel2.TabIndex = 15;
            this.bosLabel2.Text = "Từ ngày";
            // 
            // DMISS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(941, 596);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMISS100";
            this.ShowIcon = false;
            this.Text = "Tổng hợp nhật xuất tồn";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkIsGroupByStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductTask)).EndInit();
            this.fld_tabProductTask.ResumeLayout(false);
            this.fld_tabStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcInventoryStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cmbViewType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel2;
        private ItemLookupEdit fld_lkeICProductID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeICStockID;
        private BOSComponent.BOSLabel fld_Lablel3;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteToDate;
        private BOSComponent.BOSDateEdit fld_dteFromDate;
        private BOSComponent.BOSButton fld_btnInventoryStattistics;
        private BOSComponent.BOSTabControl fld_tabProductTask;
        private DevExpress.XtraTab.XtraTabPage fld_tabStatistics;
        private BOSERP.Modules.InventoryStatistics.InventoryStatisticsGridControl fld_dgcInventoryStatistics;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrders;
        private BOSComponent.BOSCheckEdit fld_chkIsGroupByStock;
        private BOSComponent.BOSLookupEdit fld_lkeICDepartmentID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSComboBox fld_cmbViewType;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeICProductGroupID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID;
        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductID;
        private BOSComponent.BOSLabel bosLabel16;
    }
}
