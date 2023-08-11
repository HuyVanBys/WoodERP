using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AverageCost.UI
{
	/// <summary>
    /// Summary description for DMACIB100
	/// </summary>
    partial class DMACIB100
	{
        private ICAverageCostsGridControl fld_dgcICAverageCosts;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrders;


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
            this.fld_dgcICAverageCosts = new BOSERP.Modules.AverageCost.ICAverageCostsGridControl();
            this.fld_dgvARSaleOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_txtYear = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductGroupID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeICStockID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_Lablel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductID = new BOSERP.ItemLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMonth = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICAverageCosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICStockID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMonth.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcICAverageCosts
            // 
            this.fld_dgcICAverageCosts.AllowDrop = true;
            this.fld_dgcICAverageCosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICAverageCosts.BOSComment = string.Empty;
            this.fld_dgcICAverageCosts.BOSDataMember = string.Empty;
            this.fld_dgcICAverageCosts.BOSDataSource = "ICAverageCosts";
            this.fld_dgcICAverageCosts.BOSDescription = null;
            this.fld_dgcICAverageCosts.BOSError = null;
            this.fld_dgcICAverageCosts.BOSFieldGroup = string.Empty;
            this.fld_dgcICAverageCosts.BOSFieldRelation = string.Empty;
            this.fld_dgcICAverageCosts.BOSGridType = null;
            this.fld_dgcICAverageCosts.BOSPrivilege = string.Empty;
            this.fld_dgcICAverageCosts.BOSPropertyName = string.Empty;
            this.fld_dgcICAverageCosts.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICAverageCosts.Location = new System.Drawing.Point(0, 61);
            this.fld_dgcICAverageCosts.MainView = this.fld_dgvARSaleOrders;
            this.fld_dgcICAverageCosts.Name = "fld_dgcICAverageCosts";
            this.fld_dgcICAverageCosts.PrintReport = false;
            this.fld_dgcICAverageCosts.Screen = null;
            this.fld_dgcICAverageCosts.Size = new System.Drawing.Size(862, 506);
            this.fld_dgcICAverageCosts.TabIndex = 5;
            this.fld_dgcICAverageCosts.Tag = "DC";
            this.fld_dgcICAverageCosts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrders});
            // 
            // fld_dgvARSaleOrders
            // 
            this.fld_dgvARSaleOrders.GridControl = this.fld_dgcICAverageCosts;
            this.fld_dgvARSaleOrders.Name = "fld_dgvARSaleOrders";
            this.fld_dgvARSaleOrders.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.fld_txtYear);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosButton1);
            this.bosPanel1.Controls.Add(this.fld_btnApply);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeICProductGroupID);
            this.bosPanel1.Controls.Add(this.fld_lkeICStockID);
            this.bosPanel1.Controls.Add(this.fld_Lablel3);
            this.bosPanel1.Controls.Add(this.fld_lkeICProductID);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_lkeMonth);
            this.bosPanel1.Controls.Add(this.fld_dgcICAverageCosts);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_txtYear
            // 
            this.fld_txtYear.BOSComment = null;
            this.fld_txtYear.BOSDataMember = "";
            this.fld_txtYear.BOSDataSource = "";
            this.fld_txtYear.BOSDescription = null;
            this.fld_txtYear.BOSError = null;
            this.fld_txtYear.BOSFieldGroup = null;
            this.fld_txtYear.BOSFieldRelation = null;
            this.fld_txtYear.BOSPrivilege = null;
            this.fld_txtYear.BOSPropertyName = "Text";
            this.fld_txtYear.Location = new System.Drawing.Point(202, 9);
            this.fld_txtYear.MenuManager = this.screenToolbar;
            this.fld_txtYear.Name = "fld_txtYear";
            this.fld_txtYear.Screen = null;
            this.fld_txtYear.Size = new System.Drawing.Size(81, 20);
            this.fld_txtYear.TabIndex = 26;
            this.fld_txtYear.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = string.Empty;
            this.bosLabel1.BOSDataMember = string.Empty;
            this.bosLabel1.BOSDataSource = string.Empty;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = string.Empty;
            this.bosLabel1.BOSFieldRelation = string.Empty;
            this.bosLabel1.BOSPrivilege = string.Empty;
            this.bosLabel1.BOSPropertyName = string.Empty;
            this.bosLabel1.Location = new System.Drawing.Point(175, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(21, 13);
            this.bosLabel1.TabIndex = 25;
            this.bosLabel1.Tag = string.Empty;
            this.bosLabel1.Text = "Năm";
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
            this.bosButton1.Location = new System.Drawing.Point(721, 28);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(101, 27);
            this.bosButton1.TabIndex = 24;
            this.bosButton1.Text = "Áp giá chứng từ";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
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
            this.fld_btnApply.Location = new System.Drawing.Point(640, 28);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 27);
            this.fld_btnApply.TabIndex = 5;
            this.fld_btnApply.Text = "Tính giá";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = string.Empty;
            this.bosLabel4.BOSDataMember = string.Empty;
            this.bosLabel4.BOSDataSource = string.Empty;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = string.Empty;
            this.bosLabel4.BOSFieldRelation = string.Empty;
            this.bosLabel4.BOSPrivilege = string.Empty;
            this.bosLabel4.BOSPropertyName = string.Empty;
            this.bosLabel4.Location = new System.Drawing.Point(12, 38);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(76, 13);
            this.bosLabel4.TabIndex = 23;
            this.bosLabel4.Tag = string.Empty;
            this.bosLabel4.Text = "Nhóm sản phẩm";
            // 
            // fld_lkeICProductGroupID
            // 
            this.fld_lkeICProductGroupID.BOSAllowAddNew = false;
            this.fld_lkeICProductGroupID.BOSAllowDummy = false;
            this.fld_lkeICProductGroupID.BOSComment = null;
            this.fld_lkeICProductGroupID.BOSDataMember = "ICProductGroupID";
            this.fld_lkeICProductGroupID.BOSDataSource = "ICProductGroups";
            this.fld_lkeICProductGroupID.BOSDescription = null;
            this.fld_lkeICProductGroupID.BOSError = string.Empty;
            this.fld_lkeICProductGroupID.BOSFieldGroup = null;
            this.fld_lkeICProductGroupID.BOSFieldParent = null;
            this.fld_lkeICProductGroupID.BOSFieldRelation = null;
            this.fld_lkeICProductGroupID.BOSPrivilege = null;
            this.fld_lkeICProductGroupID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductGroupID.BOSSelectType = null;
            this.fld_lkeICProductGroupID.BOSSelectTypeValue = null;
            this.fld_lkeICProductGroupID.CurrentDisplayText = null;
            this.fld_lkeICProductGroupID.Location = new System.Drawing.Point(94, 35);
            this.fld_lkeICProductGroupID.Name = "fld_lkeICProductGroupID";
            this.fld_lkeICProductGroupID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICProductGroupID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICProductGroupID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductGroupID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICProductGroupID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductGroupID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductGroupName", "Tên nhóm")});
            this.fld_lkeICProductGroupID.Properties.DisplayMember = "ICProductGroupName";
            this.fld_lkeICProductGroupID.Properties.NullText = string.Empty;
            this.fld_lkeICProductGroupID.Properties.PopupWidth = 40;
            this.fld_lkeICProductGroupID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductGroupID.Properties.ValueMember = "ICProductGroupID";
            this.fld_lkeICProductGroupID.Screen = null;
            this.fld_lkeICProductGroupID.Size = new System.Drawing.Size(189, 20);
            this.fld_lkeICProductGroupID.TabIndex = 3;
            this.fld_lkeICProductGroupID.Tag = "DC";
            // 
            // fld_lkeICStockID
            // 
            this.fld_lkeICStockID.BOSAllowAddNew = false;
            this.fld_lkeICStockID.BOSAllowDummy = false;
            this.fld_lkeICStockID.BOSComment = null;
            this.fld_lkeICStockID.BOSDataMember = "ICStockID";
            this.fld_lkeICStockID.BOSDataSource = "ICStocks";
            this.fld_lkeICStockID.BOSDescription = null;
            this.fld_lkeICStockID.BOSError = string.Empty;
            this.fld_lkeICStockID.BOSFieldGroup = null;
            this.fld_lkeICStockID.BOSFieldParent = null;
            this.fld_lkeICStockID.BOSFieldRelation = null;
            this.fld_lkeICStockID.BOSPrivilege = null;
            this.fld_lkeICStockID.BOSPropertyName = "EditValue";
            this.fld_lkeICStockID.BOSSelectType = null;
            this.fld_lkeICStockID.BOSSelectTypeValue = null;
            this.fld_lkeICStockID.CurrentDisplayText = null;
            this.fld_lkeICStockID.Location = new System.Drawing.Point(342, 9);
            this.fld_lkeICStockID.Name = "fld_lkeICStockID";
            this.fld_lkeICStockID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICStockID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICStockID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICStockID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICStockID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICStockID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No", 20, DevExpress.Utils.FormatType.Numeric, string.Empty, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeICStockID.Properties.DisplayMember = "ICStockName";
            this.fld_lkeICStockID.Properties.NullText = string.Empty;
            this.fld_lkeICStockID.Properties.PopupWidth = 40;
            this.fld_lkeICStockID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICStockID.Properties.ValueMember = "ICStockID";
            this.fld_lkeICStockID.Screen = null;
            this.fld_lkeICStockID.Size = new System.Drawing.Size(292, 20);
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
            this.fld_Lablel3.BOSDataMember = string.Empty;
            this.fld_Lablel3.BOSDataSource = string.Empty;
            this.fld_Lablel3.BOSDescription = null;
            this.fld_Lablel3.BOSError = null;
            this.fld_Lablel3.BOSFieldGroup = string.Empty;
            this.fld_Lablel3.BOSFieldRelation = null;
            this.fld_Lablel3.BOSPrivilege = null;
            this.fld_Lablel3.BOSPropertyName = null;
            this.fld_Lablel3.Location = new System.Drawing.Point(289, 12);
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
            this.fld_lkeICProductID.Properties.DisplayMember = "ICProductDesc";
            this.fld_lkeICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID.Screen = null;
            this.fld_lkeICProductID.Size = new System.Drawing.Size(292, 20);
            this.fld_lkeICProductID.TabIndex = 4;
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = string.Empty;
            this.bosLabel3.BOSDataMember = string.Empty;
            this.bosLabel3.BOSDataSource = string.Empty;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = string.Empty;
            this.bosLabel3.BOSFieldRelation = string.Empty;
            this.bosLabel3.BOSPrivilege = string.Empty;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(289, 38);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(47, 13);
            this.bosLabel3.TabIndex = 18;
            this.bosLabel3.Tag = string.Empty;
            this.bosLabel3.Text = "Sản phẩm";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = string.Empty;
            this.bosLabel2.BOSDataMember = string.Empty;
            this.bosLabel2.BOSDataSource = string.Empty;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = string.Empty;
            this.bosLabel2.BOSFieldRelation = string.Empty;
            this.bosLabel2.BOSPrivilege = string.Empty;
            this.bosLabel2.BOSPropertyName = string.Empty;
            this.bosLabel2.Location = new System.Drawing.Point(12, 12);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(30, 13);
            this.bosLabel2.TabIndex = 15;
            this.bosLabel2.Tag = string.Empty;
            this.bosLabel2.Text = "Tháng";
            // 
            // fld_lkeMonth
            // 
            this.fld_lkeMonth.BOSAllowAddNew = false;
            this.fld_lkeMonth.BOSAllowDummy = false;
            this.fld_lkeMonth.BOSComment = string.Empty;
            this.fld_lkeMonth.BOSDataMember = string.Empty;
            this.fld_lkeMonth.BOSDataSource = string.Empty;
            this.fld_lkeMonth.BOSDescription = null;
            this.fld_lkeMonth.BOSError = null;
            this.fld_lkeMonth.BOSFieldGroup = string.Empty;
            this.fld_lkeMonth.BOSFieldParent = string.Empty;
            this.fld_lkeMonth.BOSFieldRelation = string.Empty;
            this.fld_lkeMonth.BOSPrivilege = string.Empty;
            this.fld_lkeMonth.BOSPropertyName = "EditValue";
            this.fld_lkeMonth.BOSSelectType = string.Empty;
            this.fld_lkeMonth.BOSSelectTypeValue = string.Empty;
            this.fld_lkeMonth.CurrentDisplayText = null;
            this.fld_lkeMonth.Location = new System.Drawing.Point(94, 9);
            this.fld_lkeMonth.Name = "fld_lkeMonth";
            this.fld_lkeMonth.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMonth.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMonth.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMonth.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMonth.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeMonth.Properties.NullText = string.Empty;
            this.fld_lkeMonth.Properties.PopupWidth = 40;
            this.fld_lkeMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMonth.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeMonth.Screen = null;
            this.fld_lkeMonth.Size = new System.Drawing.Size(75, 20);
            this.fld_lkeMonth.TabIndex = 0;
            this.fld_lkeMonth.Tag = "DC";
            // 
            // DMACIB100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMACIB100";
            this.ShowIcon = false;
            this.Text = "Tính giá trung bình";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICAverageCosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICStockID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMonth.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeMonth;
        private ItemLookupEdit fld_lkeICProductID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeICProductGroupID;
        private BOSComponent.BOSLookupEdit fld_lkeICStockID;
        private BOSComponent.BOSLabel fld_Lablel3;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtYear;
	}
}
