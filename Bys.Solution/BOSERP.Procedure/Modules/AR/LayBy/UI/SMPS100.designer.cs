using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.LayBy.UI
{
	/// <summary>
	/// Summary description for SMPS100
	/// </summary>
	partial class SMPS100
	{
        private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel94;
		private BOSComponent.BOSLabel fld_lblLabel114;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSLabel fld_lblLabel3;
		private BOSComponent.BOSTextBox fld_txtARSaleOrderNo;
		private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
		private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID1;
		private BOSSearchResultsGridControl fld_dgcARSaleOrder;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
		private BOSComponent.BOSDateEdit fld_dteSearchFromARSaleOrderDeliveryDate1;
		private BOSComponent.BOSLabel fld_lblLabel29;
		private BOSComponent.BOSLabel fld_lblLabel30;
		private BOSComponent.BOSDateEdit fld_dteSearchToARSaleOrderDeliveryDate1;
		private BOSComponent.BOSDateEdit fld_dteSearchFromARSaleOrderDate1;
        private BOSComponent.BOSDateEdit fld_dteSearchToARSaleOrderDate2;


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
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel94 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel114 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARSaleOrderNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ARCustomerID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcARSaleOrder = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteSearchFromARSaleOrderDeliveryDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel29 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel30 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToARSaleOrderDeliveryDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromARSaleOrderDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToARSaleOrderDate2 = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDeliveryDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDeliveryDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDeliveryDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDeliveryDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = null;
            this.fld_lblLabel.Location = new System.Drawing.Point(44, 12);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(14, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã";
            // 
            // fld_lblLabel94
            // 
            this.fld_lblLabel94.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel94.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel94.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel94.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel94.BOSComment = "";
            this.fld_lblLabel94.BOSDataMember = "";
            this.fld_lblLabel94.BOSDataSource = "";
            this.fld_lblLabel94.BOSDescription = null;
            this.fld_lblLabel94.BOSError = null;
            this.fld_lblLabel94.BOSFieldGroup = "";
            this.fld_lblLabel94.BOSFieldRelation = "";
            this.fld_lblLabel94.BOSPrivilege = "";
            this.fld_lblLabel94.BOSPropertyName = null;
            this.fld_lblLabel94.Location = new System.Drawing.Point(44, 120);
            this.fld_lblLabel94.Name = "fld_lblLabel94";
            this.fld_lblLabel94.Screen = null;
            this.fld_lblLabel94.Size = new System.Drawing.Size(78, 13);
            this.fld_lblLabel94.TabIndex = 63;
            this.fld_lblLabel94.Tag = "SI";
            this.fld_lblLabel94.Text = "Bắt đầu từ ngày";
            // 
            // fld_lblLabel114
            // 
            this.fld_lblLabel114.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel114.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel114.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel114.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel114.BOSComment = "";
            this.fld_lblLabel114.BOSDataMember = "";
            this.fld_lblLabel114.BOSDataSource = "";
            this.fld_lblLabel114.BOSDescription = null;
            this.fld_lblLabel114.BOSError = null;
            this.fld_lblLabel114.BOSFieldGroup = "";
            this.fld_lblLabel114.BOSFieldRelation = "";
            this.fld_lblLabel114.BOSPrivilege = "";
            this.fld_lblLabel114.BOSPropertyName = null;
            this.fld_lblLabel114.Location = new System.Drawing.Point(299, 120);
            this.fld_lblLabel114.Name = "fld_lblLabel114";
            this.fld_lblLabel114.Screen = null;
            this.fld_lblLabel114.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel114.TabIndex = 65;
            this.fld_lblLabel114.Tag = "SI";
            this.fld_lblLabel114.Text = "Đến";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = "";
            this.fld_lblLabel1.BOSDataMember = "";
            this.fld_lblLabel1.BOSDataSource = "";
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = "";
            this.fld_lblLabel1.BOSFieldRelation = "";
            this.fld_lblLabel1.BOSPrivilege = "";
            this.fld_lblLabel1.BOSPropertyName = null;
            this.fld_lblLabel1.Location = new System.Drawing.Point(44, 49);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel1.TabIndex = 80;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Khách hàng";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = "";
            this.fld_lblLabel3.BOSDataMember = "";
            this.fld_lblLabel3.BOSDataSource = "";
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = "";
            this.fld_lblLabel3.BOSFieldRelation = "";
            this.fld_lblLabel3.BOSPrivilege = "";
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(44, 84);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel3.TabIndex = 82;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Nhân viên";
            // 
            // fld_txtARSaleOrderNo
            // 
            this.fld_txtARSaleOrderNo.BOSComment = "";
            this.fld_txtARSaleOrderNo.BOSDataMember = "ARSaleOrderNo";
            this.fld_txtARSaleOrderNo.BOSDataSource = "ARSaleOrders";
            this.fld_txtARSaleOrderNo.BOSDescription = null;
            this.fld_txtARSaleOrderNo.BOSError = "";
            this.fld_txtARSaleOrderNo.BOSFieldGroup = "";
            this.fld_txtARSaleOrderNo.BOSFieldRelation = "";
            this.fld_txtARSaleOrderNo.BOSPrivilege = "";
            this.fld_txtARSaleOrderNo.BOSPropertyName = "Text";
            this.fld_txtARSaleOrderNo.Location = new System.Drawing.Point(135, 9);
            this.fld_txtARSaleOrderNo.Name = "fld_txtARSaleOrderNo";
            this.fld_txtARSaleOrderNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderNo.Screen = null;
            this.fld_txtARSaleOrderNo.Size = new System.Drawing.Size(120, 20);
            this.fld_txtARSaleOrderNo.TabIndex = 0;
            this.fld_txtARSaleOrderNo.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID1.BOSComment = "";
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(135, 81);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeFName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeFName";
            this.fld_lkeFK_HREmployeeID1.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 2;
            this.fld_lkeFK_HREmployeeID1.Tag = "SC";
            // 
            // fld_lkeFK_ARCustomerID1
            // 
            this.fld_lkeFK_ARCustomerID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID1.BOSAllowDummy = true;
            this.fld_lkeFK_ARCustomerID1.BOSComment = "";
            this.fld_lkeFK_ARCustomerID1.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID1.BOSDataSource = "ARSaleOrders";
            this.fld_lkeFK_ARCustomerID1.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID1.BOSError = "";
            this.fld_lkeFK_ARCustomerID1.BOSFieldGroup = "";
            this.fld_lkeFK_ARCustomerID1.BOSFieldParent = "";
            this.fld_lkeFK_ARCustomerID1.BOSFieldRelation = "";
            this.fld_lkeFK_ARCustomerID1.BOSPrivilege = "";
            this.fld_lkeFK_ARCustomerID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID1.BOSSelectType = "";
            this.fld_lkeFK_ARCustomerID1.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARCustomerID1.CurrentDisplayText = "";
            this.fld_lkeFK_ARCustomerID1.Location = new System.Drawing.Point(135, 46);
            this.fld_lkeFK_ARCustomerID1.Name = "fld_lkeFK_ARCustomerID1";
            this.fld_lkeFK_ARCustomerID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Name")});
            this.fld_lkeFK_ARCustomerID1.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID1.Properties.NullText = "";
            this.fld_lkeFK_ARCustomerID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARCustomerID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID1.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID1.Screen = null;
            this.fld_lkeFK_ARCustomerID1.Size = new System.Drawing.Size(120, 20);
            this.fld_lkeFK_ARCustomerID1.TabIndex = 1;
            this.fld_lkeFK_ARCustomerID1.Tag = "SC";
            // 
            // fld_dgcARSaleOrder
            // 
            this.fld_dgcARSaleOrder.AllowDrop = true;
            this.fld_dgcARSaleOrder.BOSComment = "";
            this.fld_dgcARSaleOrder.BOSDataMember = null;
            this.fld_dgcARSaleOrder.BOSDataSource = "ARSaleOrders";
            this.fld_dgcARSaleOrder.BOSDescription = null;
            this.fld_dgcARSaleOrder.BOSError = "";
            this.fld_dgcARSaleOrder.BOSFieldGroup = "";
            this.fld_dgcARSaleOrder.BOSFieldRelation = null;
            this.fld_dgcARSaleOrder.BOSPrivilege = "";
            this.fld_dgcARSaleOrder.BOSPropertyName = null;
            this.fld_dgcARSaleOrder.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleOrder.Location = new System.Drawing.Point(12, 214);
            this.fld_dgcARSaleOrder.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcARSaleOrder.Name = "fld_dgcARSaleOrder";
            this.fld_dgcARSaleOrder.Screen = null;
            this.fld_dgcARSaleOrder.Size = new System.Drawing.Size(515, 309);
            this.fld_dgcARSaleOrder.TabIndex = 79;
            this.fld_dgcARSaleOrder.Tag = "SR";
            this.fld_dgcARSaleOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcARSaleOrder;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
            // 
            // fld_dteSearchFromARSaleOrderDeliveryDate1
            // 
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.BOSComment = "";
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.BOSDataMember = "ARSaleOrderDeliveryDate";
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.BOSDataSource = "ARSaleOrders";
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.BOSDescription = null;
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.BOSError = "";
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.BOSFieldGroup = "";
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.BOSFieldRelation = null;
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.BOSPrivilege = "";
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.EditValue = null;
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.Location = new System.Drawing.Point(135, 153);
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.Name = "fld_dteSearchFromARSaleOrderDeliveryDate1";
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.Screen = null;
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.Size = new System.Drawing.Size(120, 20);
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.TabIndex = 5;
            this.fld_dteSearchFromARSaleOrderDeliveryDate1.Tag = "SC";
            // 
            // fld_lblLabel29
            // 
            this.fld_lblLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel29.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel29.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel29.BOSComment = "";
            this.fld_lblLabel29.BOSDataMember = "";
            this.fld_lblLabel29.BOSDataSource = "";
            this.fld_lblLabel29.BOSDescription = null;
            this.fld_lblLabel29.BOSError = null;
            this.fld_lblLabel29.BOSFieldGroup = "";
            this.fld_lblLabel29.BOSFieldRelation = "";
            this.fld_lblLabel29.BOSPrivilege = "";
            this.fld_lblLabel29.BOSPropertyName = null;
            this.fld_lblLabel29.Location = new System.Drawing.Point(44, 156);
            this.fld_lblLabel29.Name = "fld_lblLabel29";
            this.fld_lblLabel29.Screen = null;
            this.fld_lblLabel29.Size = new System.Drawing.Size(79, 13);
            this.fld_lblLabel29.TabIndex = 92;
            this.fld_lblLabel29.Tag = "SI";
            this.fld_lblLabel29.Text = "Hết hạn từ ngày";
            // 
            // fld_lblLabel30
            // 
            this.fld_lblLabel30.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel30.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel30.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel30.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel30.BOSComment = "";
            this.fld_lblLabel30.BOSDataMember = "";
            this.fld_lblLabel30.BOSDataSource = "";
            this.fld_lblLabel30.BOSDescription = null;
            this.fld_lblLabel30.BOSError = null;
            this.fld_lblLabel30.BOSFieldGroup = "";
            this.fld_lblLabel30.BOSFieldRelation = "";
            this.fld_lblLabel30.BOSPrivilege = "";
            this.fld_lblLabel30.BOSPropertyName = null;
            this.fld_lblLabel30.Location = new System.Drawing.Point(299, 160);
            this.fld_lblLabel30.Name = "fld_lblLabel30";
            this.fld_lblLabel30.Screen = null;
            this.fld_lblLabel30.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel30.TabIndex = 93;
            this.fld_lblLabel30.Tag = "SI";
            this.fld_lblLabel30.Text = "Đến";
            // 
            // fld_dteSearchToARSaleOrderDeliveryDate1
            // 
            this.fld_dteSearchToARSaleOrderDeliveryDate1.BOSComment = "";
            this.fld_dteSearchToARSaleOrderDeliveryDate1.BOSDataMember = "ARSaleOrderDeliveryDate";
            this.fld_dteSearchToARSaleOrderDeliveryDate1.BOSDataSource = "ARSaleOrders";
            this.fld_dteSearchToARSaleOrderDeliveryDate1.BOSDescription = null;
            this.fld_dteSearchToARSaleOrderDeliveryDate1.BOSError = "";
            this.fld_dteSearchToARSaleOrderDeliveryDate1.BOSFieldGroup = "";
            this.fld_dteSearchToARSaleOrderDeliveryDate1.BOSFieldRelation = null;
            this.fld_dteSearchToARSaleOrderDeliveryDate1.BOSPrivilege = "";
            this.fld_dteSearchToARSaleOrderDeliveryDate1.BOSPropertyName = "EditValue";
            this.fld_dteSearchToARSaleOrderDeliveryDate1.EditValue = null;
            this.fld_dteSearchToARSaleOrderDeliveryDate1.Location = new System.Drawing.Point(332, 153);
            this.fld_dteSearchToARSaleOrderDeliveryDate1.Name = "fld_dteSearchToARSaleOrderDeliveryDate1";
            this.fld_dteSearchToARSaleOrderDeliveryDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARSaleOrderDeliveryDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARSaleOrderDeliveryDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARSaleOrderDeliveryDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARSaleOrderDeliveryDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARSaleOrderDeliveryDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARSaleOrderDeliveryDate1.Screen = null;
            this.fld_dteSearchToARSaleOrderDeliveryDate1.Size = new System.Drawing.Size(120, 20);
            this.fld_dteSearchToARSaleOrderDeliveryDate1.TabIndex = 6;
            this.fld_dteSearchToARSaleOrderDeliveryDate1.Tag = "SC";
            // 
            // fld_dteSearchFromARSaleOrderDate1
            // 
            this.fld_dteSearchFromARSaleOrderDate1.BOSComment = "";
            this.fld_dteSearchFromARSaleOrderDate1.BOSDataMember = "ARSaleOrderDate";
            this.fld_dteSearchFromARSaleOrderDate1.BOSDataSource = "ARSaleOrders";
            this.fld_dteSearchFromARSaleOrderDate1.BOSDescription = null;
            this.fld_dteSearchFromARSaleOrderDate1.BOSError = "";
            this.fld_dteSearchFromARSaleOrderDate1.BOSFieldGroup = "";
            this.fld_dteSearchFromARSaleOrderDate1.BOSFieldRelation = null;
            this.fld_dteSearchFromARSaleOrderDate1.BOSPrivilege = "";
            this.fld_dteSearchFromARSaleOrderDate1.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromARSaleOrderDate1.EditValue = null;
            this.fld_dteSearchFromARSaleOrderDate1.Location = new System.Drawing.Point(135, 117);
            this.fld_dteSearchFromARSaleOrderDate1.Name = "fld_dteSearchFromARSaleOrderDate1";
            this.fld_dteSearchFromARSaleOrderDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARSaleOrderDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARSaleOrderDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARSaleOrderDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARSaleOrderDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARSaleOrderDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARSaleOrderDate1.Screen = null;
            this.fld_dteSearchFromARSaleOrderDate1.Size = new System.Drawing.Size(120, 20);
            this.fld_dteSearchFromARSaleOrderDate1.TabIndex = 3;
            this.fld_dteSearchFromARSaleOrderDate1.Tag = "SC";
            // 
            // fld_dteSearchToARSaleOrderDate2
            // 
            this.fld_dteSearchToARSaleOrderDate2.BOSComment = "";
            this.fld_dteSearchToARSaleOrderDate2.BOSDataMember = "ARSaleOrderDate";
            this.fld_dteSearchToARSaleOrderDate2.BOSDataSource = "ARSaleOrders";
            this.fld_dteSearchToARSaleOrderDate2.BOSDescription = null;
            this.fld_dteSearchToARSaleOrderDate2.BOSError = "";
            this.fld_dteSearchToARSaleOrderDate2.BOSFieldGroup = "";
            this.fld_dteSearchToARSaleOrderDate2.BOSFieldRelation = null;
            this.fld_dteSearchToARSaleOrderDate2.BOSPrivilege = "";
            this.fld_dteSearchToARSaleOrderDate2.BOSPropertyName = "EditValue";
            this.fld_dteSearchToARSaleOrderDate2.EditValue = null;
            this.fld_dteSearchToARSaleOrderDate2.Location = new System.Drawing.Point(332, 117);
            this.fld_dteSearchToARSaleOrderDate2.Name = "fld_dteSearchToARSaleOrderDate2";
            this.fld_dteSearchToARSaleOrderDate2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARSaleOrderDate2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARSaleOrderDate2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARSaleOrderDate2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARSaleOrderDate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARSaleOrderDate2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARSaleOrderDate2.Screen = null;
            this.fld_dteSearchToARSaleOrderDate2.Size = new System.Drawing.Size(120, 20);
            this.fld_dteSearchToARSaleOrderDate2.TabIndex = 4;
            this.fld_dteSearchToARSaleOrderDate2.Tag = "SC";
            // 
            // SMPS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(611, 567);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel94);
            this.Controls.Add(this.fld_lblLabel114);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_txtARSaleOrderNo);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.Controls.Add(this.fld_lkeFK_ARCustomerID1);
            this.Controls.Add(this.fld_dgcARSaleOrder);
            this.Controls.Add(this.fld_dteSearchFromARSaleOrderDeliveryDate1);
            this.Controls.Add(this.fld_lblLabel29);
            this.Controls.Add(this.fld_lblLabel30);
            this.Controls.Add(this.fld_dteSearchToARSaleOrderDeliveryDate1);
            this.Controls.Add(this.fld_dteSearchFromARSaleOrderDate1);
            this.Controls.Add(this.fld_dteSearchToARSaleOrderDate2);
            this.Name = "SMPS100";
            this.Text = "Tìm kiếm";
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDeliveryDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDeliveryDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDeliveryDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDeliveryDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
	}
}
