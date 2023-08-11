using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.InventoryLeadger.UI
{
	/// <summary>
    /// Summary description for DMIL100
	/// </summary>
    partial class DMIL100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMIL100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_tabProductTask = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabCard = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcInventoryLeadger = new BOSERP.Modules.InventoryLeadger.InventoryLeadgerGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnInventoryCard = new BOSComponent.BOSButton(this.components);
            this.fld_lkeICProductSerieID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_Lablel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_chkIsGetAccumulatedQty = new BOSComponent.BOSCheckEdit(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductTask)).BeginInit();
            this.fld_tabProductTask.SuspendLayout();
            this.fld_tabCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcInventoryLeadger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductSerieID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkIsGetAccumulatedQty.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_chkIsGetAccumulatedQty);
            this.bosPanel1.Controls.Add(this.fld_tabProductTask);
            this.bosPanel1.Controls.Add(this.fld_dteToDate);
            this.bosPanel1.Controls.Add(this.fld_dteFromDate);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_btnInventoryCard);
            this.bosPanel1.Controls.Add(this.fld_lkeICProductSerieID);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeICStockID);
            this.bosPanel1.Controls.Add(this.fld_Lablel3);
            this.bosPanel1.Controls.Add(this.fld_lkeICProductID);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1004, 649);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_tabProductTask
            // 
            this.fld_tabProductTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabProductTask.BOSComment = null;
            this.fld_tabProductTask.BOSDataMember = null;
            this.fld_tabProductTask.BOSDataSource = null;
            this.fld_tabProductTask.BOSDescription = null;
            this.fld_tabProductTask.BOSError = null;
            this.fld_tabProductTask.BOSFieldGroup = null;
            this.fld_tabProductTask.BOSFieldRelation = null;
            this.fld_tabProductTask.BOSPrivilege = null;
            this.fld_tabProductTask.BOSPropertyName = null;
            this.fld_tabProductTask.Location = new System.Drawing.Point(3, 61);
            this.fld_tabProductTask.Name = "fld_tabProductTask";
            this.fld_tabProductTask.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.fld_tabProductTask.Screen = null;
            this.fld_tabProductTask.SelectedTabPage = this.fld_tabCard;
            this.fld_tabProductTask.Size = new System.Drawing.Size(998, 585);
            this.fld_tabProductTask.TabIndex = 28;
            this.fld_tabProductTask.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabCard});
            // 
            // fld_tabCard
            // 
            this.fld_tabCard.Controls.Add(this.fld_dgcInventoryLeadger);
            this.fld_tabCard.Name = "fld_tabCard";
            this.fld_tabCard.Size = new System.Drawing.Size(996, 560);
            this.fld_tabCard.Text = "Sổ chi tiết vật tư";
            // 
            // fld_dgcInventoryLeadger
            // 
            this.fld_dgcInventoryLeadger.AllowDrop = true;
            this.fld_dgcInventoryLeadger.BOSComment = null;
            this.fld_dgcInventoryLeadger.BOSDataMember = null;
            this.fld_dgcInventoryLeadger.BOSDataSource = "ICTransactions";
            this.fld_dgcInventoryLeadger.BOSDescription = null;
            this.fld_dgcInventoryLeadger.BOSError = null;
            this.fld_dgcInventoryLeadger.BOSFieldGroup = null;
            this.fld_dgcInventoryLeadger.BOSFieldRelation = null;
            this.fld_dgcInventoryLeadger.BOSGridType = null;
            this.fld_dgcInventoryLeadger.BOSPrivilege = null;
            this.fld_dgcInventoryLeadger.BOSPropertyName = null;
            this.fld_dgcInventoryLeadger.CommodityType = "";
            this.fld_dgcInventoryLeadger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcInventoryLeadger.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcInventoryLeadger.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcInventoryLeadger.MainView = this.gridView1;
            this.fld_dgcInventoryLeadger.Name = "fld_dgcInventoryLeadger";
            this.fld_dgcInventoryLeadger.PrintReport = false;
            this.fld_dgcInventoryLeadger.Screen = null;
            this.fld_dgcInventoryLeadger.Size = new System.Drawing.Size(996, 560);
            this.fld_dgcInventoryLeadger.TabIndex = 7;
            this.fld_dgcInventoryLeadger.Tag = "DC";
            this.fld_dgcInventoryLeadger.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcInventoryLeadger;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_dteToDate
            // 
            this.fld_dteToDate.BOSComment = null;
            this.fld_dteToDate.BOSDataMember = "ICReceiptDate";
            this.fld_dteToDate.BOSDataSource = "ICReceipts";
            this.fld_dteToDate.BOSDescription = null;
            this.fld_dteToDate.BOSError = null;
            this.fld_dteToDate.BOSFieldGroup = null;
            this.fld_dteToDate.BOSFieldRelation = null;
            this.fld_dteToDate.BOSPrivilege = null;
            this.fld_dteToDate.BOSPropertyName = "EditValue";
            this.fld_dteToDate.EditValue = null;
            this.fld_dteToDate.Location = new System.Drawing.Point(342, 9);
            this.fld_dteToDate.MenuManager = this.screenToolbar;
            this.fld_dteToDate.Name = "fld_dteToDate";
            this.fld_dteToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToDate.Screen = null;
            this.fld_dteToDate.Size = new System.Drawing.Size(192, 20);
            this.fld_dteToDate.TabIndex = 27;
            this.fld_dteToDate.Tag = "DC";
            // 
            // fld_dteFromDate
            // 
            this.fld_dteFromDate.BOSComment = null;
            this.fld_dteFromDate.BOSDataMember = "ICReceiptDate";
            this.fld_dteFromDate.BOSDataSource = "ICReceipts";
            this.fld_dteFromDate.BOSDescription = null;
            this.fld_dteFromDate.BOSError = null;
            this.fld_dteFromDate.BOSFieldGroup = null;
            this.fld_dteFromDate.BOSFieldRelation = null;
            this.fld_dteFromDate.BOSPrivilege = null;
            this.fld_dteFromDate.BOSPropertyName = "EditValue";
            this.fld_dteFromDate.EditValue = null;
            this.fld_dteFromDate.Location = new System.Drawing.Point(60, 9);
            this.fld_dteFromDate.MenuManager = this.screenToolbar;
            this.fld_dteFromDate.Name = "fld_dteFromDate";
            this.fld_dteFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromDate.Screen = null;
            this.fld_dteFromDate.Size = new System.Drawing.Size(192, 20);
            this.fld_dteFromDate.TabIndex = 26;
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
            this.bosLabel1.Location = new System.Drawing.Point(289, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 25;
            this.bosLabel1.Text = "Đến ngày";
            // 
            // fld_btnInventoryCard
            // 
            this.fld_btnInventoryCard.BOSComment = null;
            this.fld_btnInventoryCard.BOSDataMember = null;
            this.fld_btnInventoryCard.BOSDataSource = null;
            this.fld_btnInventoryCard.BOSDescription = null;
            this.fld_btnInventoryCard.BOSError = null;
            this.fld_btnInventoryCard.BOSFieldGroup = null;
            this.fld_btnInventoryCard.BOSFieldRelation = null;
            this.fld_btnInventoryCard.BOSPrivilege = null;
            this.fld_btnInventoryCard.BOSPropertyName = null;
            this.fld_btnInventoryCard.Location = new System.Drawing.Point(675, 35);
            this.fld_btnInventoryCard.Name = "fld_btnInventoryCard";
            this.fld_btnInventoryCard.Screen = null;
            this.fld_btnInventoryCard.Size = new System.Drawing.Size(127, 20);
            this.fld_btnInventoryCard.TabIndex = 5;
            this.fld_btnInventoryCard.Text = "Xem thẻ kho";
            this.fld_btnInventoryCard.Click += new System.EventHandler(this.fld_btnInventoryCard_Click);
            // 
            // fld_lkeICProductSerieID
            // 
            this.fld_lkeICProductSerieID.BOSAllowAddNew = false;
            this.fld_lkeICProductSerieID.BOSAllowDummy = true;
            this.fld_lkeICProductSerieID.BOSComment = null;
            this.fld_lkeICProductSerieID.BOSDataMember = "ICProductSerieID";
            this.fld_lkeICProductSerieID.BOSDataSource = "ICProductSeries";
            this.fld_lkeICProductSerieID.BOSDescription = null;
            this.fld_lkeICProductSerieID.BOSError = null;
            this.fld_lkeICProductSerieID.BOSFieldGroup = null;
            this.fld_lkeICProductSerieID.BOSFieldParent = null;
            this.fld_lkeICProductSerieID.BOSFieldRelation = null;
            this.fld_lkeICProductSerieID.BOSPrivilege = null;
            this.fld_lkeICProductSerieID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductSerieID.BOSSelectType = null;
            this.fld_lkeICProductSerieID.BOSSelectTypeValue = null;
            this.fld_lkeICProductSerieID.CurrentDisplayText = null;
            this.fld_lkeICProductSerieID.Enabled = false;
            this.fld_lkeICProductSerieID.Location = new System.Drawing.Point(610, 9);
            this.fld_lkeICProductSerieID.Name = "fld_lkeICProductSerieID";
            this.fld_lkeICProductSerieID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICProductSerieID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICProductSerieID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductSerieID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICProductSerieID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductSerieID.Properties.ColumnName = null;
            this.fld_lkeICProductSerieID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductSerieLotNo", "Lô hàng", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductSerieNo", "Mã lô SP")});
            this.fld_lkeICProductSerieID.Properties.DisplayMember = "ICProductSerieNo";
            this.fld_lkeICProductSerieID.Properties.NullText = "";
            this.fld_lkeICProductSerieID.Properties.PopupWidth = 40;
            this.fld_lkeICProductSerieID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductSerieID.Properties.ValueMember = "ICProductSerieID";
            this.fld_lkeICProductSerieID.Screen = null;
            this.fld_lkeICProductSerieID.Size = new System.Drawing.Size(192, 20);
            this.fld_lkeICProductSerieID.TabIndex = 2;
            this.fld_lkeICProductSerieID.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(569, 12);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(25, 13);
            this.bosLabel4.TabIndex = 20;
            this.bosLabel4.Text = "Mã lô";
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
            this.fld_lkeICStockID.Location = new System.Drawing.Point(60, 35);
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
            this.fld_lkeICStockID.Size = new System.Drawing.Size(192, 20);
            this.fld_lkeICStockID.TabIndex = 2;
            this.fld_lkeICStockID.Tag = "DC";
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
            this.fld_Lablel3.Location = new System.Drawing.Point(12, 38);
            this.fld_Lablel3.Name = "fld_Lablel3";
            this.fld_Lablel3.Screen = null;
            this.fld_Lablel3.Size = new System.Drawing.Size(18, 13);
            this.fld_Lablel3.TabIndex = 20;
            this.fld_Lablel3.Text = "Kho";
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
            this.fld_lkeICProductID.Location = new System.Drawing.Point(342, 35);
            this.fld_lkeICProductID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductID.Name = "fld_lkeICProductID";
            this.fld_lkeICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductID.Properties.ColumnName = null;
            this.fld_lkeICProductID.Properties.DisplayMember = "ICProductDesc";
            this.fld_lkeICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID.Screen = null;
            this.fld_lkeICProductID.Size = new System.Drawing.Size(192, 20);
            this.fld_lkeICProductID.TabIndex = 4;
            this.fld_lkeICProductID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeICProductID_CloseUp);
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
            this.bosLabel3.Location = new System.Drawing.Point(289, 38);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(47, 13);
            this.bosLabel3.TabIndex = 18;
            this.bosLabel3.Text = "Sản phẩm";
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
            // fld_chkIsGetAccumulatedQty
            // 
            this.fld_chkIsGetAccumulatedQty.BOSComment = null;
            this.fld_chkIsGetAccumulatedQty.BOSDataMember = "";
            this.fld_chkIsGetAccumulatedQty.BOSDataSource = "";
            this.fld_chkIsGetAccumulatedQty.BOSDescription = null;
            this.fld_chkIsGetAccumulatedQty.BOSError = null;
            this.fld_chkIsGetAccumulatedQty.BOSFieldGroup = null;
            this.fld_chkIsGetAccumulatedQty.BOSFieldRelation = null;
            this.fld_chkIsGetAccumulatedQty.BOSPrivilege = null;
            this.fld_chkIsGetAccumulatedQty.BOSPropertyName = "EditValue";
            this.fld_chkIsGetAccumulatedQty.Location = new System.Drawing.Point(569, 35);
            this.fld_chkIsGetAccumulatedQty.MenuManager = this.screenToolbar;
            this.fld_chkIsGetAccumulatedQty.Name = "fld_chkIsGetAccumulatedQty";
            this.fld_chkIsGetAccumulatedQty.Properties.Caption = "Xem tồn lũy kế";
            this.fld_chkIsGetAccumulatedQty.Screen = null;
            this.fld_chkIsGetAccumulatedQty.Size = new System.Drawing.Size(100, 20);
            this.fld_chkIsGetAccumulatedQty.TabIndex = 29;
            this.fld_chkIsGetAccumulatedQty.Tag = "DC";
            // 
            // DMIL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1004, 649);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMIL100.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.Name = "DMIL100";
            this.Text = "Sổ chi tiết vật tư";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductTask)).EndInit();
            this.fld_tabProductTask.ResumeLayout(false);
            this.fld_tabCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcInventoryLeadger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductSerieID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkIsGetAccumulatedQty.Properties)).EndInit();
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
        private BOSComponent.BOSButton fld_btnInventoryCard;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSDateEdit fld_dteToDate;
        private BOSComponent.BOSDateEdit fld_dteFromDate;
        private BOSComponent.BOSTabControl fld_tabProductTask;
        private DevExpress.XtraTab.XtraTabPage fld_tabCard;
        private BOSERP.Modules.InventoryLeadger.InventoryLeadgerGridControl fld_dgcInventoryLeadger;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLookupEdit fld_lkeICProductSerieID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSCheckEdit fld_chkIsGetAccumulatedQty;
    }
}
