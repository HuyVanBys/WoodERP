using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.UpdatePosition.UI
{
	/// <summary>
	/// Summary description for DMLM100
	/// </summary>
	partial class DMUP100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMUP100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.bosLine5 = new BOSComponent.BOSLine(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtProductLength = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtProductWidth = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtProductHeight = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ICStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnInventoryStatement = new BOSComponent.BOSButton(this.components);
            this.fld_btnICProductSerieNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_ckeIsStockQty = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_ckeIsExistTree = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_dgcMMUpdatePostitionItems = new BOSERP.Modules.UpdatePosition.UpdatePositionItemsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMUpdatePositionStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMUpdatePositionDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMPositionNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_btn_DeleteSerialNo = new BOSComponent.BOSButton(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            this.bosLine5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProductLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProductWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProductHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_btnICProductSerieNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeIsStockQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeIsExistTree.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMUpdatePostitionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMUpdatePositionStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMUpdatePositionDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMUpdatePositionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPositionNo.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1086, 601);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.bosLine5);
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcMMUpdatePostitionItems);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel9);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeMMUpdatePositionStatus);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteMMUpdatePositionDate);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtMMPositionNo);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl, true);
            this.fld_grcGroupControl.Size = new System.Drawing.Size(1083, 598);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // bosLine5
            // 
            this.bosLine5.BOSComment = null;
            this.bosLine5.BOSDataMember = null;
            this.bosLine5.BOSDataSource = null;
            this.bosLine5.BOSDescription = null;
            this.bosLine5.BOSError = null;
            this.bosLine5.BOSFieldGroup = null;
            this.bosLine5.BOSFieldRelation = null;
            this.bosLine5.BOSPrivilege = null;
            this.bosLine5.BOSPropertyName = null;
            this.bosLine5.Controls.Add(this.bosLabel8);
            this.bosLine5.Controls.Add(this.fld_txtProductLength);
            this.bosLine5.Controls.Add(this.bosLabel7);
            this.bosLine5.Controls.Add(this.fld_txtProductWidth);
            this.bosLine5.Controls.Add(this.bosLabel6);
            this.bosLine5.Controls.Add(this.fld_txtProductHeight);
            this.bosLine5.Controls.Add(this.bosLabel2);
            this.bosLine5.Controls.Add(this.fld_lkeICProductID);
            this.bosLine5.Controls.Add(this.fld_lkeFK_ICStockID);
            this.bosLine5.Controls.Add(this.bosLabel1);
            this.bosLine5.Controls.Add(this.bosLabel3);
            this.bosLine5.Controls.Add(this.fld_btn_DeleteSerialNo);
            this.bosLine5.Controls.Add(this.fld_btnInventoryStatement);
            this.bosLine5.Controls.Add(this.fld_btnICProductSerieNo);
            this.bosLine5.Controls.Add(this.fld_ckeIsStockQty);
            this.bosLine5.Controls.Add(this.fld_ckeIsExistTree);
            this.bosLine5.Location = new System.Drawing.Point(250, 26);
            this.bosLine5.Name = "bosLine5";
            this.bosLine5.Screen = null;
            this.bosLine5.Size = new System.Drawing.Size(814, 100);
            this.bosLine5.TabIndex = 6;
            this.bosLine5.TabStop = false;
            this.bosLine5.Text = "Thông tin tìm kiếm";
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
            this.bosLabel8.Location = new System.Drawing.Point(244, 74);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(42, 13);
            this.bosLabel8.TabIndex = 12;
            this.bosLabel8.Text = "Dài (mm)";
            // 
            // fld_txtProductLength
            // 
            this.fld_txtProductLength.BOSComment = null;
            this.fld_txtProductLength.BOSDataMember = null;
            this.fld_txtProductLength.BOSDataSource = null;
            this.fld_txtProductLength.BOSDescription = null;
            this.fld_txtProductLength.BOSError = null;
            this.fld_txtProductLength.BOSFieldGroup = null;
            this.fld_txtProductLength.BOSFieldRelation = null;
            this.fld_txtProductLength.BOSPrivilege = null;
            this.fld_txtProductLength.BOSPropertyName = "EditValue";
            this.fld_txtProductLength.Location = new System.Drawing.Point(305, 71);
            this.fld_txtProductLength.MenuManager = this.screenToolbar;
            this.fld_txtProductLength.Name = "fld_txtProductLength";
            this.fld_txtProductLength.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtProductLength, true);
            this.fld_txtProductLength.Size = new System.Drawing.Size(130, 20);
            this.fld_txtProductLength.TabIndex = 13;
            this.fld_txtProductLength.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(244, 48);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(52, 13);
            this.bosLabel7.TabIndex = 7;
            this.bosLabel7.Text = "Rộng (mm)";
            // 
            // fld_txtProductWidth
            // 
            this.fld_txtProductWidth.BOSComment = null;
            this.fld_txtProductWidth.BOSDataMember = null;
            this.fld_txtProductWidth.BOSDataSource = null;
            this.fld_txtProductWidth.BOSDescription = null;
            this.fld_txtProductWidth.BOSError = null;
            this.fld_txtProductWidth.BOSFieldGroup = null;
            this.fld_txtProductWidth.BOSFieldRelation = null;
            this.fld_txtProductWidth.BOSPrivilege = null;
            this.fld_txtProductWidth.BOSPropertyName = "EditValue";
            this.fld_txtProductWidth.Location = new System.Drawing.Point(305, 45);
            this.fld_txtProductWidth.MenuManager = this.screenToolbar;
            this.fld_txtProductWidth.Name = "fld_txtProductWidth";
            this.fld_txtProductWidth.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtProductWidth, true);
            this.fld_txtProductWidth.Size = new System.Drawing.Size(130, 20);
            this.fld_txtProductWidth.TabIndex = 8;
            this.fld_txtProductWidth.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(244, 22);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(46, 13);
            this.bosLabel6.TabIndex = 2;
            this.bosLabel6.Text = "Dày (mm)";
            // 
            // fld_txtProductHeight
            // 
            this.fld_txtProductHeight.BOSComment = null;
            this.fld_txtProductHeight.BOSDataMember = null;
            this.fld_txtProductHeight.BOSDataSource = null;
            this.fld_txtProductHeight.BOSDescription = null;
            this.fld_txtProductHeight.BOSError = null;
            this.fld_txtProductHeight.BOSFieldGroup = null;
            this.fld_txtProductHeight.BOSFieldRelation = null;
            this.fld_txtProductHeight.BOSPrivilege = null;
            this.fld_txtProductHeight.BOSPropertyName = "EditValue";
            this.fld_txtProductHeight.Location = new System.Drawing.Point(305, 19);
            this.fld_txtProductHeight.MenuManager = this.screenToolbar;
            this.fld_txtProductHeight.Name = "fld_txtProductHeight";
            this.fld_txtProductHeight.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtProductHeight, true);
            this.fld_txtProductHeight.Size = new System.Drawing.Size(130, 20);
            this.fld_txtProductHeight.TabIndex = 3;
            this.fld_txtProductHeight.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(9, 22);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(41, 13);
            this.bosLabel2.TabIndex = 0;
            this.bosLabel2.Text = "Mã hàng";
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
            this.fld_lkeICProductID.Location = new System.Drawing.Point(67, 19);
            this.fld_lkeICProductID.Name = "fld_lkeICProductID";
            this.fld_lkeICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductID.Properties.ColumnName = null;
            this.fld_lkeICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên")});
            this.fld_lkeICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID.Screen = null;
            this.fld_lkeICProductID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICProductID.TabIndex = 1;
            // 
            // fld_lkeFK_ICStockID
            // 
            this.fld_lkeFK_ICStockID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID.BOSAllowDummy = false;
            this.fld_lkeFK_ICStockID.BOSComment = null;
            this.fld_lkeFK_ICStockID.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID.BOSDataSource = "MMUpdatePositions";
            this.fld_lkeFK_ICStockID.BOSDescription = null;
            this.fld_lkeFK_ICStockID.BOSError = null;
            this.fld_lkeFK_ICStockID.BOSFieldGroup = null;
            this.fld_lkeFK_ICStockID.BOSFieldParent = null;
            this.fld_lkeFK_ICStockID.BOSFieldRelation = null;
            this.fld_lkeFK_ICStockID.BOSPrivilege = null;
            this.fld_lkeFK_ICStockID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID.BOSSelectType = null;
            this.fld_lkeFK_ICStockID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICStockID.CurrentDisplayText = null;
            this.fld_lkeFK_ICStockID.Location = new System.Drawing.Point(67, 45);
            this.fld_lkeFK_ICStockID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICStockID.Name = "fld_lkeFK_ICStockID";
            this.fld_lkeFK_ICStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID.Properties.ColumnName = null;
            this.fld_lkeFK_ICStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeFK_ICStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID.Properties.NullText = "";
            this.fld_lkeFK_ICStockID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID.Screen = null;
            this.fld_lkeFK_ICStockID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICStockID.TabIndex = 6;
            this.fld_lkeFK_ICStockID.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(9, 48);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(18, 13);
            this.bosLabel1.TabIndex = 5;
            this.bosLabel1.Text = "Kho";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(9, 74);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(38, 13);
            this.bosLabel3.TabIndex = 10;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Mã kiện";
            // 
            // fld_btnInventoryStatement
            // 
            this.fld_btnInventoryStatement.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_btnInventoryStatement.Appearance.Options.UseFont = true;
            this.fld_btnInventoryStatement.BOSComment = null;
            this.fld_btnInventoryStatement.BOSDataMember = null;
            this.fld_btnInventoryStatement.BOSDataSource = null;
            this.fld_btnInventoryStatement.BOSDescription = null;
            this.fld_btnInventoryStatement.BOSError = null;
            this.fld_btnInventoryStatement.BOSFieldGroup = null;
            this.fld_btnInventoryStatement.BOSFieldRelation = null;
            this.fld_btnInventoryStatement.BOSPrivilege = null;
            this.fld_btnInventoryStatement.BOSPropertyName = null;
            this.fld_btnInventoryStatement.Location = new System.Drawing.Point(463, 69);
            this.fld_btnInventoryStatement.Name = "fld_btnInventoryStatement";
            this.fld_btnInventoryStatement.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnInventoryStatement, true);
            this.fld_btnInventoryStatement.Size = new System.Drawing.Size(87, 22);
            this.fld_btnInventoryStatement.TabIndex = 14;
            this.fld_btnInventoryStatement.Text = "Load tồn kho";
            this.fld_btnInventoryStatement.Click += new System.EventHandler(this.fld_btnInventoryStatement_Click);
            // 
            // fld_btnICProductSerieNo
            // 
            this.fld_btnICProductSerieNo.BOSComment = "";
            this.fld_btnICProductSerieNo.BOSDataMember = "";
            this.fld_btnICProductSerieNo.BOSDataSource = "";
            this.fld_btnICProductSerieNo.BOSDescription = null;
            this.fld_btnICProductSerieNo.BOSError = "";
            this.fld_btnICProductSerieNo.BOSFieldGroup = "";
            this.fld_btnICProductSerieNo.BOSFieldRelation = "";
            this.fld_btnICProductSerieNo.BOSPrivilege = "";
            this.fld_btnICProductSerieNo.BOSPropertyName = "Text";
            this.fld_btnICProductSerieNo.Location = new System.Drawing.Point(67, 71);
            this.fld_btnICProductSerieNo.Name = "fld_btnICProductSerieNo";
            this.fld_btnICProductSerieNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_btnICProductSerieNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnICProductSerieNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_btnICProductSerieNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_btnICProductSerieNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_btnICProductSerieNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_btnICProductSerieNo.Screen = null;
            this.fld_btnICProductSerieNo.Size = new System.Drawing.Size(150, 20);
            this.fld_btnICProductSerieNo.TabIndex = 11;
            this.fld_btnICProductSerieNo.Tag = "DC";
            // 
            // fld_ckeIsStockQty
            // 
            this.fld_ckeIsStockQty.BOSComment = "";
            this.fld_ckeIsStockQty.BOSDataMember = "";
            this.fld_ckeIsStockQty.BOSDataSource = "";
            this.fld_ckeIsStockQty.BOSDescription = null;
            this.fld_ckeIsStockQty.BOSError = "";
            this.fld_ckeIsStockQty.BOSFieldGroup = "";
            this.fld_ckeIsStockQty.BOSFieldRelation = "";
            this.fld_ckeIsStockQty.BOSPrivilege = "";
            this.fld_ckeIsStockQty.BOSPropertyName = "EditValue";
            this.fld_ckeIsStockQty.Location = new System.Drawing.Point(463, 43);
            this.fld_ckeIsStockQty.Name = "fld_ckeIsStockQty";
            this.fld_ckeIsStockQty.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_ckeIsStockQty.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_ckeIsStockQty.Properties.Appearance.Options.UseBackColor = true;
            this.fld_ckeIsStockQty.Properties.Appearance.Options.UseForeColor = true;
            this.fld_ckeIsStockQty.Properties.Caption = "Tồn kho lớn hơn 0";
            this.fld_ckeIsStockQty.Screen = null;
            this.fld_ckeIsStockQty.Size = new System.Drawing.Size(159, 20);
            this.fld_ckeIsStockQty.TabIndex = 9;
            this.fld_ckeIsStockQty.Tag = "DC";
            // 
            // fld_ckeIsExistTree
            // 
            this.fld_ckeIsExistTree.BOSComment = "";
            this.fld_ckeIsExistTree.BOSDataMember = "";
            this.fld_ckeIsExistTree.BOSDataSource = "";
            this.fld_ckeIsExistTree.BOSDescription = null;
            this.fld_ckeIsExistTree.BOSError = "";
            this.fld_ckeIsExistTree.BOSFieldGroup = "";
            this.fld_ckeIsExistTree.BOSFieldRelation = "";
            this.fld_ckeIsExistTree.BOSPrivilege = "";
            this.fld_ckeIsExistTree.BOSPropertyName = "EditValue";
            this.fld_ckeIsExistTree.Location = new System.Drawing.Point(463, 20);
            this.fld_ckeIsExistTree.Name = "fld_ckeIsExistTree";
            this.fld_ckeIsExistTree.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_ckeIsExistTree.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_ckeIsExistTree.Properties.Appearance.Options.UseBackColor = true;
            this.fld_ckeIsExistTree.Properties.Appearance.Options.UseForeColor = true;
            this.fld_ckeIsExistTree.Properties.Caption = "Chưa được tạo sơ đồ cây";
            this.fld_ckeIsExistTree.Screen = null;
            this.fld_ckeIsExistTree.Size = new System.Drawing.Size(159, 20);
            this.fld_ckeIsExistTree.TabIndex = 4;
            this.fld_ckeIsExistTree.Tag = "DC";
            // 
            // fld_dgcMMUpdatePostitionItems
            // 
            this.fld_dgcMMUpdatePostitionItems.AllowDrop = true;
            this.fld_dgcMMUpdatePostitionItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMUpdatePostitionItems.BOSComment = null;
            this.fld_dgcMMUpdatePostitionItems.BOSDataMember = null;
            this.fld_dgcMMUpdatePostitionItems.BOSDataSource = "MMUpdatePositionItems";
            this.fld_dgcMMUpdatePostitionItems.BOSDescription = null;
            this.fld_dgcMMUpdatePostitionItems.BOSError = null;
            this.fld_dgcMMUpdatePostitionItems.BOSFieldGroup = null;
            this.fld_dgcMMUpdatePostitionItems.BOSFieldRelation = null;
            this.fld_dgcMMUpdatePostitionItems.BOSGridType = null;
            this.fld_dgcMMUpdatePostitionItems.BOSPrivilege = null;
            this.fld_dgcMMUpdatePostitionItems.BOSPropertyName = null;
            this.fld_dgcMMUpdatePostitionItems.CommodityType = "";
            this.fld_dgcMMUpdatePostitionItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMUpdatePostitionItems.Location = new System.Drawing.Point(5, 132);
            this.fld_dgcMMUpdatePostitionItems.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcMMUpdatePostitionItems.Name = "fld_dgcMMUpdatePostitionItems";
            this.fld_dgcMMUpdatePostitionItems.PrintReport = false;
            this.fld_dgcMMUpdatePostitionItems.Screen = null;
            this.fld_dgcMMUpdatePostitionItems.Size = new System.Drawing.Size(1075, 461);
            this.fld_dgcMMUpdatePostitionItems.TabIndex = 7;
            this.fld_dgcMMUpdatePostitionItems.Tag = "DC";
            this.fld_dgcMMUpdatePostitionItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcMMUpdatePostitionItems;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
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
            this.bosLabel9.Location = new System.Drawing.Point(22, 100);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(49, 13);
            this.bosLabel9.TabIndex = 4;
            this.bosLabel9.Text = "Trạng thái";
            // 
            // fld_lkeMMUpdatePositionStatus
            // 
            this.fld_lkeMMUpdatePositionStatus.BOSAllowAddNew = false;
            this.fld_lkeMMUpdatePositionStatus.BOSAllowDummy = false;
            this.fld_lkeMMUpdatePositionStatus.BOSComment = null;
            this.fld_lkeMMUpdatePositionStatus.BOSDataMember = "MMUpdatePositionStatus";
            this.fld_lkeMMUpdatePositionStatus.BOSDataSource = "MMUpdatePositions";
            this.fld_lkeMMUpdatePositionStatus.BOSDescription = null;
            this.fld_lkeMMUpdatePositionStatus.BOSError = null;
            this.fld_lkeMMUpdatePositionStatus.BOSFieldGroup = null;
            this.fld_lkeMMUpdatePositionStatus.BOSFieldParent = null;
            this.fld_lkeMMUpdatePositionStatus.BOSFieldRelation = null;
            this.fld_lkeMMUpdatePositionStatus.BOSPrivilege = null;
            this.fld_lkeMMUpdatePositionStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMUpdatePositionStatus.BOSSelectType = null;
            this.fld_lkeMMUpdatePositionStatus.BOSSelectTypeValue = null;
            this.fld_lkeMMUpdatePositionStatus.CurrentDisplayText = null;
            this.fld_lkeMMUpdatePositionStatus.Enabled = false;
            this.fld_lkeMMUpdatePositionStatus.Location = new System.Drawing.Point(109, 97);
            this.fld_lkeMMUpdatePositionStatus.MenuManager = this.screenToolbar;
            this.fld_lkeMMUpdatePositionStatus.Name = "fld_lkeMMUpdatePositionStatus";
            this.fld_lkeMMUpdatePositionStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMUpdatePositionStatus.Properties.ColumnName = null;
            this.fld_lkeMMUpdatePositionStatus.Properties.NullText = "";
            this.fld_lkeMMUpdatePositionStatus.Screen = null;
            this.fld_lkeMMUpdatePositionStatus.Size = new System.Drawing.Size(118, 20);
            this.fld_lkeMMUpdatePositionStatus.TabIndex = 5;
            this.fld_lkeMMUpdatePositionStatus.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(22, 74);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(72, 13);
            this.bosLabel5.TabIndex = 2;
            this.bosLabel5.Text = "Ngày chứng từ";
            // 
            // fld_dteMMUpdatePositionDate
            // 
            this.fld_dteMMUpdatePositionDate.BOSComment = null;
            this.fld_dteMMUpdatePositionDate.BOSDataMember = "MMUpdatePositionDate";
            this.fld_dteMMUpdatePositionDate.BOSDataSource = "MMUpdatePositions";
            this.fld_dteMMUpdatePositionDate.BOSDescription = null;
            this.fld_dteMMUpdatePositionDate.BOSError = null;
            this.fld_dteMMUpdatePositionDate.BOSFieldGroup = null;
            this.fld_dteMMUpdatePositionDate.BOSFieldRelation = null;
            this.fld_dteMMUpdatePositionDate.BOSPrivilege = null;
            this.fld_dteMMUpdatePositionDate.BOSPropertyName = "EditValue";
            this.fld_dteMMUpdatePositionDate.EditValue = null;
            this.fld_dteMMUpdatePositionDate.Location = new System.Drawing.Point(109, 71);
            this.fld_dteMMUpdatePositionDate.MenuManager = this.screenToolbar;
            this.fld_dteMMUpdatePositionDate.Name = "fld_dteMMUpdatePositionDate";
            this.fld_dteMMUpdatePositionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMUpdatePositionDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMUpdatePositionDate.Screen = null;
            this.fld_dteMMUpdatePositionDate.Size = new System.Drawing.Size(118, 20);
            this.fld_dteMMUpdatePositionDate.TabIndex = 3;
            this.fld_dteMMUpdatePositionDate.Tag = "DC";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseFont = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "";
            this.fld_lblLabel4.BOSDataMember = "";
            this.fld_lblLabel4.BOSDataSource = "";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "";
            this.fld_lblLabel4.BOSFieldRelation = "";
            this.fld_lblLabel4.BOSPrivilege = "";
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(22, 48);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel4, true);
            this.fld_lblLabel4.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel4.TabIndex = 0;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Mã chứng từ";
            // 
            // fld_txtMMPositionNo
            // 
            this.fld_txtMMPositionNo.BOSComment = "";
            this.fld_txtMMPositionNo.BOSDataMember = "MMUpdatePositionNo";
            this.fld_txtMMPositionNo.BOSDataSource = "MMUpdatePositions";
            this.fld_txtMMPositionNo.BOSDescription = null;
            this.fld_txtMMPositionNo.BOSError = "";
            this.fld_txtMMPositionNo.BOSFieldGroup = "";
            this.fld_txtMMPositionNo.BOSFieldRelation = "";
            this.fld_txtMMPositionNo.BOSPrivilege = "";
            this.fld_txtMMPositionNo.BOSPropertyName = "Text";
            this.fld_txtMMPositionNo.Location = new System.Drawing.Point(109, 45);
            this.fld_txtMMPositionNo.Name = "fld_txtMMPositionNo";
            this.fld_txtMMPositionNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMPositionNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMPositionNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMPositionNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMPositionNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMPositionNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMPositionNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMPositionNo, true);
            this.fld_txtMMPositionNo.Size = new System.Drawing.Size(118, 20);
            this.fld_txtMMPositionNo.TabIndex = 1;
            this.fld_txtMMPositionNo.Tag = "DC";
            // 
            // fld_btn_DeleteSerialNo
            // 
            this.fld_btn_DeleteSerialNo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_btn_DeleteSerialNo.Appearance.Options.UseFont = true;
            this.fld_btn_DeleteSerialNo.BOSComment = null;
            this.fld_btn_DeleteSerialNo.BOSDataMember = null;
            this.fld_btn_DeleteSerialNo.BOSDataSource = null;
            this.fld_btn_DeleteSerialNo.BOSDescription = null;
            this.fld_btn_DeleteSerialNo.BOSError = null;
            this.fld_btn_DeleteSerialNo.BOSFieldGroup = null;
            this.fld_btn_DeleteSerialNo.BOSFieldRelation = null;
            this.fld_btn_DeleteSerialNo.BOSPrivilege = null;
            this.fld_btn_DeleteSerialNo.BOSPropertyName = null;
            this.fld_btn_DeleteSerialNo.Location = new System.Drawing.Point(570, 69);
            this.fld_btn_DeleteSerialNo.Name = "fld_btn_DeleteSerialNo";
            this.fld_btn_DeleteSerialNo.Screen = null;
            this.fld_btn_DeleteSerialNo.Size = new System.Drawing.Size(145, 22);
            this.fld_btn_DeleteSerialNo.TabIndex = 14;
            this.fld_btn_DeleteSerialNo.Text = "Xóa kiện không cập nhật";
            this.fld_btn_DeleteSerialNo.Click += new System.EventHandler(this.fld_btn_DeleteSerialNo_Click);
            // 
            // DMUP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1086, 601);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMUP100.IconOptions.Icon")));
            this.Name = "DMUP100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            this.bosLine5.ResumeLayout(false);
            this.bosLine5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProductLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProductWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtProductHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_btnICProductSerieNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeIsStockQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeIsExistTree.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMUpdatePostitionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMUpdatePositionStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMUpdatePositionDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMUpdatePositionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMPositionNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSTextBox fld_txtMMPositionNo;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dteMMUpdatePositionDate;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeMMUpdatePositionStatus;
        private BOSComponent.BOSCheckEdit fld_ckeIsExistTree;
        private BOSComponent.BOSCheckEdit fld_ckeIsStockQty;
        private BOSComponent.BOSButton fld_btnInventoryStatement;
        private UpdatePosition.UpdatePositionItemsGridControl fld_dgcMMUpdatePostitionItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private BOSComponent.BOSLine bosLine5;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeICProductID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_btnICProductSerieNo;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox fld_txtProductHeight;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtProductWidth;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtProductLength;
        private BOSComponent.BOSButton fld_btn_DeleteSerialNo;
    }
}
