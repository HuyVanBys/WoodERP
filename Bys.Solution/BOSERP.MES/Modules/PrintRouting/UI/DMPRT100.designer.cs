using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSComponent;

namespace BOSERP.Modules.PrintRouting.UI
{
	/// <summary>
	/// Summary description for SMNTS100
	/// </summary>
    partial class DMPRT100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPRT100));
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.fld_txtUpdateQuanlity = new BOSComponent.BOSButton(this.components);
            this.fld_txtSoluong = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeProductCarcass = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_cbbType = new BOSComponent.BOSComboBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcMMPrintRoutings = new BOSERP.Modules.PrintRouting.PrintRoutingGridControl();
            this.fld_btnPRint = new BOSComponent.BOSButton(this.components);
            this.fld_btnLuu = new BOSComponent.BOSButton(this.components);
            this.fld_btnSearch = new BOSComponent.BOSButton(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_chkChecked = new BOSComponent.BOSCheckEdit(this.components);
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeProductCarcass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cbbType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMPrintRoutings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkChecked.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.fld_txtUpdateQuanlity);
            this.xtraScrollableControl1.Controls.Add(this.fld_txtSoluong);
            this.xtraScrollableControl1.Controls.Add(this.bosLabel5);
            this.xtraScrollableControl1.Controls.Add(this.bosLabel4);
            this.xtraScrollableControl1.Controls.Add(this.fld_lkeProductCarcass);
            this.xtraScrollableControl1.Controls.Add(this.fld_cbbType);
            this.xtraScrollableControl1.Controls.Add(this.bosLabel3);
            this.xtraScrollableControl1.Controls.Add(this.bosGroupControl1);
            this.xtraScrollableControl1.Controls.Add(this.fld_btnPRint);
            this.xtraScrollableControl1.Controls.Add(this.fld_btnLuu);
            this.xtraScrollableControl1.Controls.Add(this.fld_btnSearch);
            this.xtraScrollableControl1.Controls.Add(this.bosLabel2);
            this.xtraScrollableControl1.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.xtraScrollableControl1.Controls.Add(this.bosLabel1);
            this.xtraScrollableControl1.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.xtraScrollableControl1.Controls.Add(this.bosPanel1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1176, 727);
            this.xtraScrollableControl1.TabIndex = 6;
            // 
            // fld_txtUpdateQuanlity
            // 
            this.fld_txtUpdateQuanlity.BOSComment = null;
            this.fld_txtUpdateQuanlity.BOSDataMember = null;
            this.fld_txtUpdateQuanlity.BOSDataSource = null;
            this.fld_txtUpdateQuanlity.BOSDescription = null;
            this.fld_txtUpdateQuanlity.BOSError = null;
            this.fld_txtUpdateQuanlity.BOSFieldGroup = null;
            this.fld_txtUpdateQuanlity.BOSFieldRelation = null;
            this.fld_txtUpdateQuanlity.BOSPrivilege = null;
            this.fld_txtUpdateQuanlity.BOSPropertyName = null;
            this.fld_txtUpdateQuanlity.Location = new System.Drawing.Point(952, 100);
            this.fld_txtUpdateQuanlity.Name = "fld_txtUpdateQuanlity";
            this.fld_txtUpdateQuanlity.Screen = null;
            this.fld_txtUpdateQuanlity.Size = new System.Drawing.Size(110, 20);
            this.fld_txtUpdateQuanlity.TabIndex = 16;
            this.fld_txtUpdateQuanlity.Tag = "DC";
            this.fld_txtUpdateQuanlity.Text = "Cập nhật số lượng";
            this.fld_txtUpdateQuanlity.Visible = false;
            this.fld_txtUpdateQuanlity.Click += new System.EventHandler(this.fld_txtUpdateQuanlity_Click);
            // 
            // fld_txtSoluong
            // 
            this.fld_txtSoluong.BOSComment = null;
            this.fld_txtSoluong.BOSDataMember = null;
            this.fld_txtSoluong.BOSDataSource = null;
            this.fld_txtSoluong.BOSDescription = null;
            this.fld_txtSoluong.BOSError = null;
            this.fld_txtSoluong.BOSFieldGroup = null;
            this.fld_txtSoluong.BOSFieldRelation = null;
            this.fld_txtSoluong.BOSPrivilege = null;
            this.fld_txtSoluong.BOSPropertyName = null;
            this.fld_txtSoluong.Location = new System.Drawing.Point(848, 100);
            this.fld_txtSoluong.MenuManager = this.screenToolbar;
            this.fld_txtSoluong.Name = "fld_txtSoluong";
            this.fld_txtSoluong.Screen = null;
            this.fld_txtSoluong.Size = new System.Drawing.Size(98, 20);
            this.fld_txtSoluong.TabIndex = 15;
            this.fld_txtSoluong.Tag = "DC";
            this.fld_txtSoluong.Visible = false;
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
            this.bosLabel5.Location = new System.Drawing.Point(800, 103);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(42, 13);
            this.bosLabel5.TabIndex = 14;
            this.bosLabel5.Tag = "DC";
            this.bosLabel5.Text = "Số lượng";
            this.bosLabel5.Visible = false;
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
            this.bosLabel4.Location = new System.Drawing.Point(12, 100);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(104, 13);
            this.bosLabel4.TabIndex = 13;
            this.bosLabel4.Tag = "DC";
            this.bosLabel4.Text = "Thành phẩm/ Carcass";
            // 
            // fld_lkeProductCarcass
            // 
            this.fld_lkeProductCarcass.BOSAllowAddNew = false;
            this.fld_lkeProductCarcass.BOSAllowDummy = true;
            this.fld_lkeProductCarcass.BOSComment = null;
            this.fld_lkeProductCarcass.BOSDataMember = "";
            this.fld_lkeProductCarcass.BOSDataSource = "";
            this.fld_lkeProductCarcass.BOSDescription = null;
            this.fld_lkeProductCarcass.BOSError = null;
            this.fld_lkeProductCarcass.BOSFieldGroup = null;
            this.fld_lkeProductCarcass.BOSFieldParent = null;
            this.fld_lkeProductCarcass.BOSFieldRelation = null;
            this.fld_lkeProductCarcass.BOSPrivilege = null;
            this.fld_lkeProductCarcass.BOSPropertyName = "EditValue";
            this.fld_lkeProductCarcass.BOSSelectType = null;
            this.fld_lkeProductCarcass.BOSSelectTypeValue = null;
            this.fld_lkeProductCarcass.CurrentDisplayText = null;
            this.fld_lkeProductCarcass.Location = new System.Drawing.Point(124, 97);
            this.fld_lkeProductCarcass.MenuManager = this.screenToolbar;
            this.fld_lkeProductCarcass.Name = "fld_lkeProductCarcass";
            this.fld_lkeProductCarcass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeProductCarcass.Properties.ColumnName = null;
            this.fld_lkeProductCarcass.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductQuality", "Số lượng")});
            this.fld_lkeProductCarcass.Properties.DisplayMember = "ICProductName";
            this.fld_lkeProductCarcass.Properties.ValueMember = "ICProductID";
            this.fld_lkeProductCarcass.Screen = null;
            this.fld_lkeProductCarcass.Size = new System.Drawing.Size(214, 20);
            this.fld_lkeProductCarcass.TabIndex = 12;
            this.fld_lkeProductCarcass.Tag = "DC";
            this.fld_lkeProductCarcass.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeProductCarcass_QueryPopUp);
            this.fld_lkeProductCarcass.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_lkeProductCarcass_Closed);
            // 
            // fld_cbbType
            // 
            this.fld_cbbType.BOSComment = null;
            this.fld_cbbType.BOSDataMember = null;
            this.fld_cbbType.BOSDataSource = null;
            this.fld_cbbType.BOSDescription = null;
            this.fld_cbbType.BOSError = null;
            this.fld_cbbType.BOSFieldGroup = null;
            this.fld_cbbType.BOSFieldRelation = null;
            this.fld_cbbType.BOSPrivilege = null;
            this.fld_cbbType.BOSPropertyName = "EditValue";
            this.fld_cbbType.Location = new System.Drawing.Point(124, 45);
            this.fld_cbbType.MenuManager = this.screenToolbar;
            this.fld_cbbType.Name = "fld_cbbType";
            this.fld_cbbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_cbbType.Properties.Items.AddRange(new object[] {
            "Thành Phẩm",
            "Cụm",
            "Chi tiết"});
            this.fld_cbbType.Screen = null;
            this.fld_cbbType.Size = new System.Drawing.Size(214, 20);
            this.fld_cbbType.TabIndex = 11;
            this.fld_cbbType.Tag = "DC";
            this.fld_cbbType.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_cbbType_Closed);
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
            this.bosLabel3.Location = new System.Drawing.Point(12, 48);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(19, 13);
            this.bosLabel3.TabIndex = 10;
            this.bosLabel3.Tag = "DC";
            this.bosLabel3.Text = "Loại";
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
            this.bosGroupControl1.Controls.Add(this.fld_dgcMMPrintRoutings);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 126);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(1170, 555);
            this.bosGroupControl1.TabIndex = 8;
            this.bosGroupControl1.Text = "Thông tin tìm kiếm";
            // 
            // fld_dgcMMPrintRoutings
            // 
            this.fld_dgcMMPrintRoutings.BOSComment = null;
            this.fld_dgcMMPrintRoutings.BOSDataMember = null;
            this.fld_dgcMMPrintRoutings.BOSDataSource = "MMPrintRoutings";
            this.fld_dgcMMPrintRoutings.BOSDescription = null;
            this.fld_dgcMMPrintRoutings.BOSError = null;
            this.fld_dgcMMPrintRoutings.BOSFieldGroup = null;
            this.fld_dgcMMPrintRoutings.BOSFieldRelation = null;
            this.fld_dgcMMPrintRoutings.BOSGridType = null;
            this.fld_dgcMMPrintRoutings.BOSPrivilege = null;
            this.fld_dgcMMPrintRoutings.BOSPropertyName = null;
            this.fld_dgcMMPrintRoutings.CommodityType = "";
            this.fld_dgcMMPrintRoutings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMPrintRoutings.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcMMPrintRoutings.MenuManager = this.screenToolbar;
            this.fld_dgcMMPrintRoutings.Name = "fld_dgcMMPrintRoutings";
            this.fld_dgcMMPrintRoutings.PrintReport = false;
            this.fld_dgcMMPrintRoutings.Screen = null;
            this.fld_dgcMMPrintRoutings.Size = new System.Drawing.Size(1166, 530);
            this.fld_dgcMMPrintRoutings.TabIndex = 0;
            // 
            // fld_btnPRint
            // 
            this.fld_btnPRint.BOSComment = null;
            this.fld_btnPRint.BOSDataMember = null;
            this.fld_btnPRint.BOSDataSource = null;
            this.fld_btnPRint.BOSDescription = null;
            this.fld_btnPRint.BOSError = null;
            this.fld_btnPRint.BOSFieldGroup = null;
            this.fld_btnPRint.BOSFieldRelation = null;
            this.fld_btnPRint.BOSPrivilege = null;
            this.fld_btnPRint.BOSPropertyName = null;
            this.fld_btnPRint.Location = new System.Drawing.Point(609, 86);
            this.fld_btnPRint.Name = "fld_btnPRint";
            this.fld_btnPRint.Screen = null;
            this.fld_btnPRint.Size = new System.Drawing.Size(100, 31);
            this.fld_btnPRint.TabIndex = 1;
            this.fld_btnPRint.Tag = "DC";
            this.fld_btnPRint.Text = "In Routing";
            this.fld_btnPRint.Click += new System.EventHandler(this.fld_btnPRint_Click);
            // 
            // fld_btnLuu
            // 
            this.fld_btnLuu.BOSComment = null;
            this.fld_btnLuu.BOSDataMember = null;
            this.fld_btnLuu.BOSDataSource = null;
            this.fld_btnLuu.BOSDescription = null;
            this.fld_btnLuu.BOSError = null;
            this.fld_btnLuu.BOSFieldGroup = null;
            this.fld_btnLuu.BOSFieldRelation = null;
            this.fld_btnLuu.BOSPrivilege = null;
            this.fld_btnLuu.BOSPropertyName = null;
            this.fld_btnLuu.Location = new System.Drawing.Point(486, 86);
            this.fld_btnLuu.Name = "fld_btnLuu";
            this.fld_btnLuu.Screen = null;
            this.fld_btnLuu.Size = new System.Drawing.Size(100, 31);
            this.fld_btnLuu.TabIndex = 0;
            this.fld_btnLuu.Tag = "DC";
            this.fld_btnLuu.Text = "Lưu";
            this.fld_btnLuu.Click += new System.EventHandler(this.fld_btnLuu_Click);
            // 
            // fld_btnSearch
            // 
            this.fld_btnSearch.BOSComment = null;
            this.fld_btnSearch.BOSDataMember = null;
            this.fld_btnSearch.BOSDataSource = null;
            this.fld_btnSearch.BOSDescription = null;
            this.fld_btnSearch.BOSError = null;
            this.fld_btnSearch.BOSFieldGroup = null;
            this.fld_btnSearch.BOSFieldRelation = null;
            this.fld_btnSearch.BOSPrivilege = null;
            this.fld_btnSearch.BOSPropertyName = null;
            this.fld_btnSearch.Location = new System.Drawing.Point(366, 86);
            this.fld_btnSearch.Name = "fld_btnSearch";
            this.fld_btnSearch.Screen = null;
            this.fld_btnSearch.Size = new System.Drawing.Size(100, 31);
            this.fld_btnSearch.TabIndex = 7;
            this.fld_btnSearch.Tag = "DC";
            this.fld_btnSearch.Text = "Tìm kiếm";
            this.fld_btnSearch.Click += new System.EventHandler(this.fld_btnSearch_Click);
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
            this.bosLabel2.Location = new System.Drawing.Point(12, 74);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(52, 13);
            this.bosLabel2.TabIndex = 6;
            this.bosLabel2.Tag = "DC";
            this.bosLabel2.Text = "Công đoạn";
            // 
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = true;
            this.fld_lkeFK_MMOperationID.BOSComment = null;
            this.fld_lkeFK_MMOperationID.BOSDataMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.BOSDataSource = "MMOperations";
            this.fld_lkeFK_MMOperationID.BOSDescription = null;
            this.fld_lkeFK_MMOperationID.BOSError = null;
            this.fld_lkeFK_MMOperationID.BOSFieldGroup = null;
            this.fld_lkeFK_MMOperationID.BOSFieldParent = null;
            this.fld_lkeFK_MMOperationID.BOSFieldRelation = null;
            this.fld_lkeFK_MMOperationID.BOSPrivilege = null;
            this.fld_lkeFK_MMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationID.BOSSelectType = null;
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMOperationID.CurrentDisplayText = null;
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(124, 71);
            this.fld_lkeFK_MMOperationID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_MMOperationID.Name = "fld_lkeFK_MMOperationID";
            this.fld_lkeFK_MMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationID.Properties.ColumnName = null;
            this.fld_lkeFK_MMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Tên")});
            this.fld_lkeFK_MMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.Screen = null;
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(214, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 5;
            this.fld_lkeFK_MMOperationID.Tag = "DC";
            this.fld_lkeFK_MMOperationID.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_lkeFK_MMOperationID_Closed);
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
            this.bosLabel1.Location = new System.Drawing.Point(12, 24);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(68, 13);
            this.bosLabel1.TabIndex = 4;
            this.bosLabel1.Tag = "DC";
            this.bosLabel1.Text = "Lệnh sản xuất";
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeFK_MMBatchProductID.BOSComment = null;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "MMBatchProducts";
            this.fld_lkeFK_MMBatchProductID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductID.BOSError = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldParent = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeFK_MMBatchProductID.BOSPrivilege = null;
            this.fld_lkeFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductID.BOSSelectType = null;
            this.fld_lkeFK_MMBatchProductID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(124, 21);
            this.fld_lkeFK_MMBatchProductID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_MMBatchProductID.Name = "fld_lkeFK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductID.Properties.ColumnName = null;
            this.fld_lkeFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã ")});
            this.fld_lkeFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(214, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 3;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            this.fld_lkeFK_MMBatchProductID.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_lkeFK_MMBatchProductID_Closed);
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
            this.bosPanel1.Controls.Add(this.fld_chkChecked);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bosPanel1.Location = new System.Drawing.Point(0, 685);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1176, 42);
            this.bosPanel1.TabIndex = 2;
            // 
            // fld_chkChecked
            // 
            this.fld_chkChecked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_chkChecked.BOSComment = null;
            this.fld_chkChecked.BOSDataMember = null;
            this.fld_chkChecked.BOSDataSource = null;
            this.fld_chkChecked.BOSDescription = null;
            this.fld_chkChecked.BOSError = null;
            this.fld_chkChecked.BOSFieldGroup = null;
            this.fld_chkChecked.BOSFieldRelation = null;
            this.fld_chkChecked.BOSPrivilege = null;
            this.fld_chkChecked.BOSPropertyName = null;
            this.fld_chkChecked.Location = new System.Drawing.Point(10, 11);
            this.fld_chkChecked.MenuManager = this.screenToolbar;
            this.fld_chkChecked.Name = "fld_chkChecked";
            this.fld_chkChecked.Properties.Caption = "Chọn tất cả";
            this.fld_chkChecked.Screen = null;
            this.fld_chkChecked.Size = new System.Drawing.Size(144, 19);
            this.fld_chkChecked.TabIndex = 2;
            this.fld_chkChecked.CheckedChanged += new System.EventHandler(this.fld_chkChecked_CheckedChanged);
            // 
            // DMPRT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1176, 727);
            this.Controls.Add(this.xtraScrollableControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPRT100.IconOptions.Icon")));
            this.Name = "DMPRT100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.xtraScrollableControl1, 0);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtSoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeProductCarcass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cbbType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMPrintRoutings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkChecked.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private BOSPanel bosPanel1;
        private BOSButton fld_btnLuu;
        private BOSButton fld_btnSearch;
        private BOSLabel bosLabel2;
        private BOSLookupEdit fld_lkeFK_MMOperationID;
        private BOSLabel bosLabel1;
        private BOSLookupEdit fld_lkeFK_MMBatchProductID;
        private BOSGroupControl bosGroupControl1;
        private PrintRoutingGridControl fld_dgcMMPrintRoutings;
        private BOSButton fld_btnPRint;
        private BOSCheckEdit fld_chkChecked;
        private BOSLabel bosLabel3;
        private BOSComboBox fld_cbbType;
        private BOSLabel bosLabel4;
        private BOSLookupEdit fld_lkeProductCarcass;
        private BOSButton fld_txtUpdateQuanlity;
        private BOSTextBox fld_txtSoluong;
        private BOSLabel bosLabel5;
    }
}
