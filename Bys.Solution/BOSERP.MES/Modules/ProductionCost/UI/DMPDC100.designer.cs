using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionCost.UI
{
	/// <summary>
	/// Summary description for DMPDC100
	/// </summary>
	partial class DMPDC100
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
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcMMProductionCostItems = new BOSERP.Modules.ProductionCost.MMProductionCostItemsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnCapNhatAll = new BOSComponent.BOSButton(this.components);
            this.fld_btnTinhGiaAll = new BOSComponent.BOSButton(this.components);
            this.fld_btnRefresh = new BOSComponent.BOSButton(this.components);
            this.fld_lkeMMProductionCostStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMProductionCostFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteMMProductionCostToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_medMMProductionCostDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMProductionCostNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMProductionCostName = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionCostStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionCostDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostName.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1036, 600);
            this.bosPanel1.TabIndex = 6;
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bosGroupControl1.Appearance.Options.UseBackColor = true;
            this.bosGroupControl1.BOSComment = global::Localization.MESLocalizedResources.Contact2;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = global::Localization.MESLocalizedResources.Contact2;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = global::Localization.MESLocalizedResources.Contact2;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_dgcMMProductionCostItems);
            this.bosGroupControl1.Location = new System.Drawing.Point(6, 128);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl1, true);
            this.bosGroupControl1.Size = new System.Drawing.Size(1023, 460);
            this.bosGroupControl1.TabIndex = 1;
            this.bosGroupControl1.Text = "Danh sách lệnh sản xuất";
            // 
            // fld_dgcMMProductionCostItems
            // 
            this.fld_dgcMMProductionCostItems.AllowDrop = true;
            this.fld_dgcMMProductionCostItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostItems.BOSComment = null;
            this.fld_dgcMMProductionCostItems.BOSDataMember = null;
            this.fld_dgcMMProductionCostItems.BOSDataSource = "MMProductionCostItems";
            this.fld_dgcMMProductionCostItems.BOSDescription = null;
            this.fld_dgcMMProductionCostItems.BOSError = null;
            this.fld_dgcMMProductionCostItems.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostItems.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostItems.BOSGridType = null;
            this.fld_dgcMMProductionCostItems.BOSPrivilege = null;
            this.fld_dgcMMProductionCostItems.BOSPropertyName = null;
            this.fld_dgcMMProductionCostItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostItems.Location = new System.Drawing.Point(8, 25);
            this.fld_dgcMMProductionCostItems.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcMMProductionCostItems.Name = "fld_dgcMMProductionCostItems";
            this.fld_dgcMMProductionCostItems.PrintReport = false;
            this.fld_dgcMMProductionCostItems.Screen = null;
            this.fld_dgcMMProductionCostItems.Size = new System.Drawing.Size(1010, 430);
            this.fld_dgcMMProductionCostItems.TabIndex = 27;
            this.fld_dgcMMProductionCostItems.Tag = "DC";
            this.fld_dgcMMProductionCostItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcMMProductionCostItems;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.MESLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.MESLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.MESLocalizedResources.Contact2;
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.fld_btnCapNhatAll);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnTinhGiaAll);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnRefresh);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeMMProductionCostStatus);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel6);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteMMProductionCostFromDate);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteMMProductionCostToDate);
            this.fld_grcGroupControl.Controls.Add(this.fld_medMMProductionCostDesc);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel13);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtMMProductionCostNo);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtMMProductionCostName);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(6, 3);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl, true);
            this.fld_grcGroupControl.Size = new System.Drawing.Size(1023, 119);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // fld_btnCapNhatAll
            // 
            this.fld_btnCapNhatAll.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnCapNhatAll.Appearance.Options.UseForeColor = true;
            this.fld_btnCapNhatAll.BOSComment = null;
            this.fld_btnCapNhatAll.BOSDataMember = null;
            this.fld_btnCapNhatAll.BOSDataSource = null;
            this.fld_btnCapNhatAll.BOSDescription = null;
            this.fld_btnCapNhatAll.BOSError = null;
            this.fld_btnCapNhatAll.BOSFieldGroup = null;
            this.fld_btnCapNhatAll.BOSFieldRelation = null;
            this.fld_btnCapNhatAll.BOSPrivilege = null;
            this.fld_btnCapNhatAll.BOSPropertyName = null;
            this.fld_btnCapNhatAll.Location = new System.Drawing.Point(757, 80);
            this.fld_btnCapNhatAll.Name = "fld_btnCapNhatAll";
            this.fld_btnCapNhatAll.Screen = null;
            this.fld_btnCapNhatAll.Size = new System.Drawing.Size(115, 34);
            this.fld_btnCapNhatAll.TabIndex = 370;
            this.fld_btnCapNhatAll.Text = "Cập nhật hạch toán";
            this.fld_btnCapNhatAll.Click += new System.EventHandler(this.bosButton2_Click);
            // 
            // fld_btnTinhGiaAll
            // 
            this.fld_btnTinhGiaAll.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnTinhGiaAll.Appearance.Options.UseForeColor = true;
            this.fld_btnTinhGiaAll.BOSComment = null;
            this.fld_btnTinhGiaAll.BOSDataMember = null;
            this.fld_btnTinhGiaAll.BOSDataSource = null;
            this.fld_btnTinhGiaAll.BOSDescription = null;
            this.fld_btnTinhGiaAll.BOSError = null;
            this.fld_btnTinhGiaAll.BOSFieldGroup = null;
            this.fld_btnTinhGiaAll.BOSFieldRelation = null;
            this.fld_btnTinhGiaAll.BOSPrivilege = null;
            this.fld_btnTinhGiaAll.BOSPropertyName = null;
            this.fld_btnTinhGiaAll.Location = new System.Drawing.Point(654, 80);
            this.fld_btnTinhGiaAll.Name = "fld_btnTinhGiaAll";
            this.fld_btnTinhGiaAll.Screen = null;
            this.fld_btnTinhGiaAll.Size = new System.Drawing.Size(87, 34);
            this.fld_btnTinhGiaAll.TabIndex = 370;
            this.fld_btnTinhGiaAll.Text = "Tính giá";
            this.fld_btnTinhGiaAll.Click += new System.EventHandler(this.bosButton1_Click);
            // 
            // fld_btnRefresh
            // 
            this.fld_btnRefresh.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnRefresh.Appearance.Options.UseForeColor = true;
            this.fld_btnRefresh.BOSComment = null;
            this.fld_btnRefresh.BOSDataMember = null;
            this.fld_btnRefresh.BOSDataSource = null;
            this.fld_btnRefresh.BOSDescription = null;
            this.fld_btnRefresh.BOSError = null;
            this.fld_btnRefresh.BOSFieldGroup = null;
            this.fld_btnRefresh.BOSFieldRelation = null;
            this.fld_btnRefresh.BOSPrivilege = null;
            this.fld_btnRefresh.BOSPropertyName = null;
            this.fld_btnRefresh.Location = new System.Drawing.Point(552, 80);
            this.fld_btnRefresh.Name = "fld_btnRefresh";
            this.fld_btnRefresh.Screen = null;
            this.fld_btnRefresh.Size = new System.Drawing.Size(87, 34);
            this.fld_btnRefresh.TabIndex = 370;
            this.fld_btnRefresh.Text = "Tải dữ liệu";
            this.fld_btnRefresh.Click += new System.EventHandler(this.fld_btnRefresh_Click);
            // 
            // fld_lkeMMProductionCostStatus
            // 
            this.fld_lkeMMProductionCostStatus.BOSAllowAddNew = false;
            this.fld_lkeMMProductionCostStatus.BOSAllowDummy = false;
            this.fld_lkeMMProductionCostStatus.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionCostStatus.BOSDataMember = "MMProductionCostStatus";
            this.fld_lkeMMProductionCostStatus.BOSDataSource = "MMProductionCosts";
            this.fld_lkeMMProductionCostStatus.BOSDescription = null;
            this.fld_lkeMMProductionCostStatus.BOSError = null;
            this.fld_lkeMMProductionCostStatus.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionCostStatus.BOSFieldParent =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionCostStatus.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionCostStatus.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionCostStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMProductionCostStatus.BOSSelectType =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionCostStatus.BOSSelectTypeValue =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionCostStatus.CurrentDisplayText = null;
            this.fld_lkeMMProductionCostStatus.Location = new System.Drawing.Point(616, 25);
            this.fld_lkeMMProductionCostStatus.Name = "fld_lkeMMProductionCostStatus";
            this.fld_lkeMMProductionCostStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMProductionCostStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMProductionCostStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMProductionCostStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMProductionCostStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMProductionCostStatus.Properties.DisplayMember = "ADConfigText";
            this.fld_lkeMMProductionCostStatus.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMProductionCostStatus.Properties.PopupWidth = 40;
            this.fld_lkeMMProductionCostStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMProductionCostStatus.Properties.ValueMember = "ADConfigKeyValue";
            this.fld_lkeMMProductionCostStatus.Screen = null;
            this.fld_lkeMMProductionCostStatus.Size = new System.Drawing.Size(160, 20);
            this.fld_lkeMMProductionCostStatus.TabIndex = 7;
            this.fld_lkeMMProductionCostStatus.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel6.BOSDataMember = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel6.BOSDataSource = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel6.BOSFieldRelation = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel6.BOSPrivilege = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(552, 28);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 349;
            this.bosLabel6.Tag = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel6.Text = "Trạng thái";
            // 
            // fld_dteMMProductionCostFromDate
            // 
            this.fld_dteMMProductionCostFromDate.BOSComment = global::Localization.MESLocalizedResources.Contact2;
            this.fld_dteMMProductionCostFromDate.BOSDataMember = "MMProductionCostFromDate";
            this.fld_dteMMProductionCostFromDate.BOSDataSource = "MMProductionCosts";
            this.fld_dteMMProductionCostFromDate.BOSDescription = null;
            this.fld_dteMMProductionCostFromDate.BOSError = null;
            this.fld_dteMMProductionCostFromDate.BOSFieldGroup = global::Localization.MESLocalizedResources.Contact2;
            this.fld_dteMMProductionCostFromDate.BOSFieldRelation = global::Localization.MESLocalizedResources.Contact2;
            this.fld_dteMMProductionCostFromDate.BOSPrivilege = global::Localization.MESLocalizedResources.Contact2;
            this.fld_dteMMProductionCostFromDate.BOSPropertyName = "EditValue";
            this.fld_dteMMProductionCostFromDate.EditValue = null;
            this.fld_dteMMProductionCostFromDate.Location = new System.Drawing.Point(92, 51);
            this.fld_dteMMProductionCostFromDate.Name = "fld_dteMMProductionCostFromDate";
            this.fld_dteMMProductionCostFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProductionCostFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProductionCostFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProductionCostFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProductionCostFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProductionCostFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProductionCostFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMProductionCostFromDate, true);
            this.fld_dteMMProductionCostFromDate.Size = new System.Drawing.Size(160, 20);
            this.fld_dteMMProductionCostFromDate.TabIndex = 3;
            this.fld_dteMMProductionCostFromDate.Tag = "DC";
            // 
            // fld_dteMMProductionCostToDate
            // 
            this.fld_dteMMProductionCostToDate.BOSComment = global::Localization.MESLocalizedResources.Contact2;
            this.fld_dteMMProductionCostToDate.BOSDataMember = "MMProductionCostToDate";
            this.fld_dteMMProductionCostToDate.BOSDataSource = "MMProductionCosts";
            this.fld_dteMMProductionCostToDate.BOSDescription = null;
            this.fld_dteMMProductionCostToDate.BOSError = null;
            this.fld_dteMMProductionCostToDate.BOSFieldGroup = global::Localization.MESLocalizedResources.Contact2;
            this.fld_dteMMProductionCostToDate.BOSFieldRelation = global::Localization.MESLocalizedResources.Contact2;
            this.fld_dteMMProductionCostToDate.BOSPrivilege = global::Localization.MESLocalizedResources.Contact2;
            this.fld_dteMMProductionCostToDate.BOSPropertyName = "EditValue";
            this.fld_dteMMProductionCostToDate.EditValue = null;
            this.fld_dteMMProductionCostToDate.Location = new System.Drawing.Point(364, 51);
            this.fld_dteMMProductionCostToDate.Name = "fld_dteMMProductionCostToDate";
            this.fld_dteMMProductionCostToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProductionCostToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProductionCostToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProductionCostToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProductionCostToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProductionCostToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProductionCostToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMProductionCostToDate, true);
            this.fld_dteMMProductionCostToDate.Size = new System.Drawing.Size(160, 20);
            this.fld_dteMMProductionCostToDate.TabIndex = 4;
            this.fld_dteMMProductionCostToDate.Tag = "DC";
            // 
            // fld_medMMProductionCostDesc
            // 
            this.fld_medMMProductionCostDesc.BOSComment = global::Localization.MESLocalizedResources.Contact2;
            this.fld_medMMProductionCostDesc.BOSDataMember = "MMProductionCostDesc";
            this.fld_medMMProductionCostDesc.BOSDataSource = "MMProductionCosts";
            this.fld_medMMProductionCostDesc.BOSDescription = null;
            this.fld_medMMProductionCostDesc.BOSError = null;
            this.fld_medMMProductionCostDesc.BOSFieldGroup = global::Localization.MESLocalizedResources.Contact2;
            this.fld_medMMProductionCostDesc.BOSFieldRelation = global::Localization.MESLocalizedResources.Contact2;
            this.fld_medMMProductionCostDesc.BOSPrivilege = global::Localization.MESLocalizedResources.Contact2;
            this.fld_medMMProductionCostDesc.BOSPropertyName = "EditValue";
            this.fld_medMMProductionCostDesc.EditValue =global::Localization.MESLocalizedResources.String1;
            this.fld_medMMProductionCostDesc.Location = new System.Drawing.Point(92, 77);
            this.fld_medMMProductionCostDesc.Name = "fld_medMMProductionCostDesc";
            this.fld_medMMProductionCostDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medMMProductionCostDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medMMProductionCostDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medMMProductionCostDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medMMProductionCostDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMProductionCostDesc, true);
            this.fld_medMMProductionCostDesc.Size = new System.Drawing.Size(432, 37);
            this.fld_medMMProductionCostDesc.TabIndex = 6;
            this.fld_medMMProductionCostDesc.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel13.BOSDataMember = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel13.BOSDataSource = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel13.BOSFieldRelation = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel13.BOSPrivilege = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(13, 80);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel13, true);
            this.bosLabel13.Size = new System.Drawing.Size(40, 13);
            this.bosLabel13.TabIndex = 100;
            this.bosLabel13.Tag = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel13.Text = "Diễn giải";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel3.BOSDataMember = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel3.BOSDataSource = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel3.BOSFieldRelation = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel3.BOSPrivilege = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(13, 54);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(39, 13);
            this.bosLabel3.TabIndex = 99;
            this.bosLabel3.Tag = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel3.Text = "Từ ngày";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseFont = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.MESLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSDataMember = global::Localization.MESLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSDataSource = global::Localization.MESLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.MESLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.MESLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.MESLocalizedResources.Contact2;
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(13, 28);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel4, true);
            this.fld_lblLabel4.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel4.TabIndex = 99;
            this.fld_lblLabel4.Tag = global::Localization.MESLocalizedResources.Contact2;
            this.fld_lblLabel4.Text = "Mã chứng từ";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel2.BOSDataMember = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel2.BOSDataSource = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel2.BOSFieldRelation = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel2.BOSPrivilege = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(290, 54);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(46, 13);
            this.bosLabel2.TabIndex = 97;
            this.bosLabel2.Tag = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel2.Text = "Đến ngày";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel1.BOSDataMember = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel1.BOSDataSource = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel1.BOSFieldRelation = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel1.BOSPrivilege = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(290, 28);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(64, 13);
            this.bosLabel1.TabIndex = 97;
            this.bosLabel1.Tag = global::Localization.MESLocalizedResources.Contact2;
            this.bosLabel1.Text = "Tên chứng từ";
            // 
            // fld_txtMMProductionCostNo
            // 
            this.fld_txtMMProductionCostNo.BOSComment = global::Localization.MESLocalizedResources.Contact2;
            this.fld_txtMMProductionCostNo.BOSDataMember = "MMProductionCostNo";
            this.fld_txtMMProductionCostNo.BOSDataSource = "MMProductionCosts";
            this.fld_txtMMProductionCostNo.BOSDescription = null;
            this.fld_txtMMProductionCostNo.BOSError = global::Localization.MESLocalizedResources.Contact2;
            this.fld_txtMMProductionCostNo.BOSFieldGroup = global::Localization.MESLocalizedResources.Contact2;
            this.fld_txtMMProductionCostNo.BOSFieldRelation = global::Localization.MESLocalizedResources.Contact2;
            this.fld_txtMMProductionCostNo.BOSPrivilege = global::Localization.MESLocalizedResources.Contact2;
            this.fld_txtMMProductionCostNo.BOSPropertyName = "Text";
            this.fld_txtMMProductionCostNo.Location = new System.Drawing.Point(92, 25);
            this.fld_txtMMProductionCostNo.Name = "fld_txtMMProductionCostNo";
            this.fld_txtMMProductionCostNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionCostNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionCostNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionCostNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionCostNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionCostNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionCostNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMProductionCostNo, true);
            this.fld_txtMMProductionCostNo.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMProductionCostNo.TabIndex = 0;
            this.fld_txtMMProductionCostNo.Tag = "DC";
            // 
            // fld_txtMMProductionCostName
            // 
            this.fld_txtMMProductionCostName.BOSComment = global::Localization.MESLocalizedResources.Contact2;
            this.fld_txtMMProductionCostName.BOSDataMember = "MMProductionCostName";
            this.fld_txtMMProductionCostName.BOSDataSource = "MMProductionCosts";
            this.fld_txtMMProductionCostName.BOSDescription = null;
            this.fld_txtMMProductionCostName.BOSError = global::Localization.MESLocalizedResources.Contact2;
            this.fld_txtMMProductionCostName.BOSFieldGroup = global::Localization.MESLocalizedResources.Contact2;
            this.fld_txtMMProductionCostName.BOSFieldRelation = global::Localization.MESLocalizedResources.Contact2;
            this.fld_txtMMProductionCostName.BOSPrivilege = global::Localization.MESLocalizedResources.Contact2;
            this.fld_txtMMProductionCostName.BOSPropertyName = "Text";
            this.fld_txtMMProductionCostName.Location = new System.Drawing.Point(364, 25);
            this.fld_txtMMProductionCostName.Name = "fld_txtMMProductionCostName";
            this.fld_txtMMProductionCostName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionCostName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionCostName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionCostName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionCostName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionCostName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionCostName.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMProductionCostName, true);
            this.fld_txtMMProductionCostName.Size = new System.Drawing.Size(160, 20);
            this.fld_txtMMProductionCostName.TabIndex = 1;
            this.fld_txtMMProductionCostName.Tag = "DC";
            // 
            // DMPDC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1036, 600);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPDC100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionCostStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionCostDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostName.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private BOSComponent.BOSButton fld_btnRefresh;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionCostStatus;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSDateEdit fld_dteMMProductionCostFromDate;
        private BOSComponent.BOSDateEdit fld_dteMMProductionCostToDate;
        private BOSComponent.BOSMemoEdit fld_medMMProductionCostDesc;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMProductionCostNo;
        private BOSComponent.BOSTextBox fld_txtMMProductionCostName;
        private IContainer components;
        private MMProductionCostItemsGridControl fld_dgcMMProductionCostItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private BOSComponent.BOSButton fld_btnCapNhatAll;
        private BOSComponent.BOSButton fld_btnTinhGiaAll;
	}
}
