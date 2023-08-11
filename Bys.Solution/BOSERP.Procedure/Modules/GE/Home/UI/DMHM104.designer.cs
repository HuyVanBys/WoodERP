using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Home.UI
{
	/// <summary>
	/// Summary description for DMHM104
	/// </summary>
	partial class DMHM104
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
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_dteProductFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel61 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel62 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteProductTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnShow = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnAccept = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancelRemind = new BOSComponent.BOSButton(this.components);
            this.fld_chkCheckAllProduct = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcChangeProducts = new BOSERP.Modules.Home.GEHistoryDetailsOfProductsGridControl();
            this.fld_dgvGEHistoryDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductID = new ItemLookupEdit();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteProductFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteProductFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteProductTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteProductTo.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkCheckAllProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcChangeProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel2.Controls.Add(this.fld_lkeICProductID);
            this.bosPanel2.Controls.Add(this.fld_dteProductFrom);
            this.bosPanel2.Controls.Add(this.bosLabel1);
            this.bosPanel2.Controls.Add(this.fld_lblLabel61);
            this.bosPanel2.Controls.Add(this.fld_lblLabel62);
            this.bosPanel2.Controls.Add(this.fld_dteProductTo);
            this.bosPanel2.Controls.Add(this.fld_btnShow);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(862, 82);
            this.bosPanel2.TabIndex = 0;
            // 
            // fld_dteProductFrom
            // 
            this.fld_dteProductFrom.BOSComment = null;
            this.fld_dteProductFrom.BOSDataMember = "DateEdit";
            this.fld_dteProductFrom.BOSDataSource = null;
            this.fld_dteProductFrom.BOSDescription = null;
            this.fld_dteProductFrom.BOSError = null;
            this.fld_dteProductFrom.BOSFieldGroup = null;
            this.fld_dteProductFrom.BOSFieldRelation = null;
            this.fld_dteProductFrom.BOSPrivilege = null;
            this.fld_dteProductFrom.BOSPropertyName = "EditValue";
            this.fld_dteProductFrom.EditValue = null;
            this.fld_dteProductFrom.Location = new System.Drawing.Point(90, 12);
            this.fld_dteProductFrom.Name = "fld_dteProductFrom";
            this.fld_dteProductFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteProductFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteProductFrom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteProductFrom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteProductFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteProductFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteProductFrom.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteProductFrom, true);
            this.fld_dteProductFrom.Size = new System.Drawing.Size(150, 20);
            this.fld_dteProductFrom.TabIndex = 0;
            this.fld_dteProductFrom.Tag = "DC";
            // 
            // fld_lblLabel61
            // 
            this.fld_lblLabel61.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel61.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel61.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel61.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel61.BOSComment = null;
            this.fld_lblLabel61.BOSDataMember = null;
            this.fld_lblLabel61.BOSDataSource = null;
            this.fld_lblLabel61.BOSDescription = null;
            this.fld_lblLabel61.BOSError = null;
            this.fld_lblLabel61.BOSFieldGroup = null;
            this.fld_lblLabel61.BOSFieldRelation = null;
            this.fld_lblLabel61.BOSPrivilege = null;
            this.fld_lblLabel61.BOSPropertyName = null;
            this.fld_lblLabel61.Location = new System.Drawing.Point(23, 15);
            this.fld_lblLabel61.Name = "fld_lblLabel61";
            this.fld_lblLabel61.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel61, true);
            this.fld_lblLabel61.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel61.TabIndex = 17;
            this.fld_lblLabel61.Text = "Từ ngày";
            // 
            // fld_lblLabel62
            // 
            this.fld_lblLabel62.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel62.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel62.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel62.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel62.BOSComment = null;
            this.fld_lblLabel62.BOSDataMember = null;
            this.fld_lblLabel62.BOSDataSource = null;
            this.fld_lblLabel62.BOSDescription = null;
            this.fld_lblLabel62.BOSError = null;
            this.fld_lblLabel62.BOSFieldGroup = null;
            this.fld_lblLabel62.BOSFieldRelation = null;
            this.fld_lblLabel62.BOSPrivilege = null;
            this.fld_lblLabel62.BOSPropertyName = null;
            this.fld_lblLabel62.Location = new System.Drawing.Point(267, 15);
            this.fld_lblLabel62.Name = "fld_lblLabel62";
            this.fld_lblLabel62.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel62, true);
            this.fld_lblLabel62.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel62.TabIndex = 18;
            this.fld_lblLabel62.Text = "Đến ngày";
            // 
            // fld_dteProductTo
            // 
            this.fld_dteProductTo.BOSComment = null;
            this.fld_dteProductTo.BOSDataMember = "DateEdit";
            this.fld_dteProductTo.BOSDataSource = null;
            this.fld_dteProductTo.BOSDescription = null;
            this.fld_dteProductTo.BOSError = null;
            this.fld_dteProductTo.BOSFieldGroup = null;
            this.fld_dteProductTo.BOSFieldRelation = null;
            this.fld_dteProductTo.BOSPrivilege = null;
            this.fld_dteProductTo.BOSPropertyName = "EditValue";
            this.fld_dteProductTo.EditValue = null;
            this.fld_dteProductTo.Location = new System.Drawing.Point(339, 12);
            this.fld_dteProductTo.Name = "fld_dteProductTo";
            this.fld_dteProductTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteProductTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteProductTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteProductTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteProductTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteProductTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteProductTo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteProductTo, true);
            this.fld_dteProductTo.Size = new System.Drawing.Size(150, 20);
            this.fld_dteProductTo.TabIndex = 1;
            this.fld_dteProductTo.Tag = "DC";
            // 
            // fld_btnShow
            // 
            this.fld_btnShow.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnShow.Appearance.Options.UseForeColor = true;
            this.fld_btnShow.BOSComment = null;
            this.fld_btnShow.BOSDataMember = null;
            this.fld_btnShow.BOSDataSource = null;
            this.fld_btnShow.BOSDescription = null;
            this.fld_btnShow.BOSError = null;
            this.fld_btnShow.BOSFieldGroup = null;
            this.fld_btnShow.BOSFieldRelation = null;
            this.fld_btnShow.BOSPrivilege = null;
            this.fld_btnShow.BOSPropertyName = null;
            this.fld_btnShow.Location = new System.Drawing.Point(538, 9);
            this.fld_btnShow.Name = "fld_btnShow";
            this.fld_btnShow.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShow, true);
            this.fld_btnShow.Size = new System.Drawing.Size(75, 27);
            this.fld_btnShow.TabIndex = 3;
            this.fld_btnShow.Text = "Xem";
            this.fld_btnShow.Click += new System.EventHandler(this.fld_btnShow_Click);
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
            this.bosPanel1.Controls.Add(this.fld_btnAccept);
            this.bosPanel1.Controls.Add(this.fld_btnCancelRemind);
            this.bosPanel1.Controls.Add(this.fld_chkCheckAllProduct);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bosPanel1.Location = new System.Drawing.Point(0, 524);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 43);
            this.bosPanel1.TabIndex = 12;
            // 
            // fld_btnAccept
            // 
            this.fld_btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAccept.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAccept.Appearance.Options.UseForeColor = true;
            this.fld_btnAccept.BOSComment = "";
            this.fld_btnAccept.BOSDataMember = "";
            this.fld_btnAccept.BOSDataSource = "";
            this.fld_btnAccept.BOSDescription = null;
            this.fld_btnAccept.BOSError = null;
            this.fld_btnAccept.BOSFieldGroup = "";
            this.fld_btnAccept.BOSFieldRelation = "";
            this.fld_btnAccept.BOSPrivilege = "";
            this.fld_btnAccept.BOSPropertyName = "";
            this.fld_btnAccept.Location = new System.Drawing.Point(647, 6);
            this.fld_btnAccept.Name = "fld_btnAccept";
            this.fld_btnAccept.Screen = null;
            this.fld_btnAccept.Size = new System.Drawing.Size(94, 27);
            this.fld_btnAccept.TabIndex = 7;
            this.fld_btnAccept.Tag = "";
            this.fld_btnAccept.Text = "Duyệt";
            this.fld_btnAccept.Click += new System.EventHandler(this.fld_btnAccept_Click);
            // 
            // fld_btnCancelRemind
            // 
            this.fld_btnCancelRemind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancelRemind.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnCancelRemind.Appearance.Options.UseForeColor = true;
            this.fld_btnCancelRemind.BOSComment = "";
            this.fld_btnCancelRemind.BOSDataMember = "";
            this.fld_btnCancelRemind.BOSDataSource = "";
            this.fld_btnCancelRemind.BOSDescription = null;
            this.fld_btnCancelRemind.BOSError = null;
            this.fld_btnCancelRemind.BOSFieldGroup = "";
            this.fld_btnCancelRemind.BOSFieldRelation = "";
            this.fld_btnCancelRemind.BOSPrivilege = "";
            this.fld_btnCancelRemind.BOSPropertyName = "";
            this.fld_btnCancelRemind.Location = new System.Drawing.Point(747, 6);
            this.fld_btnCancelRemind.Name = "fld_btnCancelRemind";
            this.fld_btnCancelRemind.Screen = null;
            this.fld_btnCancelRemind.Size = new System.Drawing.Size(103, 27);
            this.fld_btnCancelRemind.TabIndex = 6;
            this.fld_btnCancelRemind.Tag = "";
            this.fld_btnCancelRemind.Text = "Hủy thay đổi";
            this.fld_btnCancelRemind.Click += new System.EventHandler(this.fld_btnCancelRemind_Click);
            // 
            // fld_chkCheckAllProduct
            // 
            this.fld_chkCheckAllProduct.BOSComment = "";
            this.fld_chkCheckAllProduct.BOSDataMember = "";
            this.fld_chkCheckAllProduct.BOSDataSource = "";
            this.fld_chkCheckAllProduct.BOSDescription = null;
            this.fld_chkCheckAllProduct.BOSError = null;
            this.fld_chkCheckAllProduct.BOSFieldGroup = "";
            this.fld_chkCheckAllProduct.BOSFieldRelation = "";
            this.fld_chkCheckAllProduct.BOSPrivilege = "";
            this.fld_chkCheckAllProduct.BOSPropertyName = "";
            this.fld_chkCheckAllProduct.Location = new System.Drawing.Point(12, 12);
            this.fld_chkCheckAllProduct.Name = "fld_chkCheckAllProduct";
            this.fld_chkCheckAllProduct.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkCheckAllProduct.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkCheckAllProduct.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkCheckAllProduct.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkCheckAllProduct.Properties.Caption = "Chọn tất cả";
            this.fld_chkCheckAllProduct.Screen = null;
            this.fld_chkCheckAllProduct.Size = new System.Drawing.Size(90, 19);
            this.fld_chkCheckAllProduct.TabIndex = 8;
            this.fld_chkCheckAllProduct.Tag = "DC";
            this.fld_chkCheckAllProduct.CheckedChanged += new System.EventHandler(this.fld_chkCheckAllProduct_CheckedChanged);
            // 
            // fld_grcGroupControl
            // 
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
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcChangeProducts);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 82);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 442);
            this.fld_grcGroupControl.TabIndex = 1;
            this.fld_grcGroupControl.Tag = "";
            this.fld_grcGroupControl.Text = "Danh sách thay đổi thông tin hàng hóa";
            // 
            // fld_dgcChangeProducts
            // 
            this.fld_dgcChangeProducts.AllowDrop = true;
            this.fld_dgcChangeProducts.BOSComment = "";
            this.fld_dgcChangeProducts.BOSDataMember = "";
            this.fld_dgcChangeProducts.BOSDataSource = "GEHistoryDetails";
            this.fld_dgcChangeProducts.BOSDescription = null;
            this.fld_dgcChangeProducts.BOSError = null;
            this.fld_dgcChangeProducts.BOSFieldGroup = "";
            this.fld_dgcChangeProducts.BOSFieldRelation = "";
            this.fld_dgcChangeProducts.BOSGridType = null;
            this.fld_dgcChangeProducts.BOSPrivilege = "";
            this.fld_dgcChangeProducts.BOSPropertyName = "";
            this.fld_dgcChangeProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcChangeProducts.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcChangeProducts.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcChangeProducts.MainView = this.fld_dgvGEHistoryDetails;
            this.fld_dgcChangeProducts.Name = "fld_dgcChangeProducts";
            this.fld_dgcChangeProducts.Screen = null;
            this.fld_dgcChangeProducts.Size = new System.Drawing.Size(858, 418);
            this.fld_dgcChangeProducts.TabIndex = 4;
            this.fld_dgcChangeProducts.Tag = "DC";
            this.fld_dgcChangeProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGEHistoryDetails});
            // 
            // fld_dgvGEHistoryDetails
            // 
            this.fld_dgvGEHistoryDetails.GridControl = this.fld_dgcChangeProducts;
            this.fld_dgvGEHistoryDetails.Name = "fld_dgvGEHistoryDetails";
            this.fld_dgvGEHistoryDetails.PaintStyleName = "Office2003";
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
            this.bosLabel1.Location = new System.Drawing.Point(23, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 17;
            this.bosLabel1.Text = "Sản phẩm";
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
            this.fld_lkeICProductID.Location = new System.Drawing.Point(90, 38);
            this.fld_lkeICProductID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductID.Name = "fld_lkeICProductID";
            this.fld_lkeICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductID.Properties.DisplayMember = "ICProductDesc";
            this.fld_lkeICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID.Screen = null;
            this.fld_lkeICProductID.Size = new System.Drawing.Size(399, 20);
            this.fld_lkeICProductID.TabIndex = 2;
            // 
            // DMHM104
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.bosPanel2);
            this.Name = "DMHM104";
            this.Text = "Thông tin hàng hóa thay đổi";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteProductFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteProductFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteProductTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteProductTo.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkCheckAllProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcChangeProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSDateEdit fld_dteProductFrom;
        private BOSComponent.BOSLabel fld_lblLabel61;
        private BOSComponent.BOSLabel fld_lblLabel62;
        private BOSComponent.BOSDateEdit fld_dteProductTo;
        private BOSComponent.BOSButton fld_btnShow;
        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnAccept;
        private BOSComponent.BOSButton fld_btnCancelRemind;
        private BOSComponent.BOSCheckEdit fld_chkCheckAllProduct;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private GEHistoryDetailsOfProductsGridControl fld_dgcChangeProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGEHistoryDetails;
        private ItemLookupEdit fld_lkeICProductID;
        private BOSComponent.BOSLabel bosLabel1;
	}
}
