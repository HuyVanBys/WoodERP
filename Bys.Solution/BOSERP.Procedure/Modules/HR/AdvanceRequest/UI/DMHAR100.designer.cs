using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AdvanceRequest.UI
{
	/// <summary>
	/// Summary description for DMHAR100
	/// </summary>
	partial class DMHAR100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMHAR100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnDelete = new BOSComponent.BOSButton(this.components);
            this.fld_btnAdd = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHRAdvanceRequestItems = new BOSERP.Modules.AdvanceRequest.AdvanceRequestItemsGridControl();
            this.fld_grcGroupControl5 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_PMProjectID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRAdvanceRequestType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRAdvanceRequestStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRAdvanceRequestNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_ACSegmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medHRAdvanceRequestDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRAdvanceRequestDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRAdvanceRequestExchangeRate = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_GECurrencyID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAdvanceRequestItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).BeginInit();
            this.fld_grcGroupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRAdvanceRequestType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRAdvanceRequestStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdvanceRequestNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRAdvanceRequestDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRequestDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRequestDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdvanceRequestExchangeRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl5);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(910, 583);
            this.bosPanel1.TabIndex = 8;
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
            this.bosGroupControl1.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.bosGroupControl1.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.bosGroupControl1.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.bosGroupControl1.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.bosGroupControl1.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.bosGroupControl1.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.bosGroupControl1.Controls.Add(this.fld_btnDelete);
            this.bosGroupControl1.Controls.Add(this.fld_btnAdd);
            this.bosGroupControl1.Controls.Add(this.fld_dgcHRAdvanceRequestItems);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 153);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(904, 419);
            this.bosGroupControl1.TabIndex = 1;
            this.bosGroupControl1.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.bosGroupControl1.Text = "Chi tiết tạm ứng";
            // 
            // fld_btnDelete
            // 
            this.fld_btnDelete.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnDelete.Appearance.Options.UseForeColor = true;
            this.fld_btnDelete.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_btnDelete.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_btnDelete.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_btnDelete.BOSDescription = null;
            this.fld_btnDelete.BOSError = null;
            this.fld_btnDelete.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_btnDelete.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_btnDelete.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_btnDelete.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_btnDelete.Location = new System.Drawing.Point(138, 28);
            this.fld_btnDelete.Name = "fld_btnDelete";
            this.fld_btnDelete.Screen = null;
            this.fld_btnDelete.Size = new System.Drawing.Size(69, 30);
            this.fld_btnDelete.TabIndex = 2;
            this.fld_btnDelete.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_btnDelete.Text = "Xóa";
            this.fld_btnDelete.Click += new System.EventHandler(this.fld_btnDelete_Click);
            // 
            // fld_btnAdd
            // 
            this.fld_btnAdd.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAdd.Appearance.Options.UseForeColor = true;
            this.fld_btnAdd.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_btnAdd.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_btnAdd.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_btnAdd.BOSDescription = null;
            this.fld_btnAdd.BOSError = null;
            this.fld_btnAdd.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_btnAdd.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_btnAdd.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_btnAdd.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_btnAdd.ImageOptions.Image = global::BOSERP.Procedure.Properties.Resources.table_add_icon;
            this.fld_btnAdd.Location = new System.Drawing.Point(12, 28);
            this.fld_btnAdd.Name = "fld_btnAdd";
            this.fld_btnAdd.Screen = null;
            this.fld_btnAdd.Size = new System.Drawing.Size(120, 30);
            this.fld_btnAdd.TabIndex = 1;
            this.fld_btnAdd.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_btnAdd.Text = "Thêm nhân viên";
            this.fld_btnAdd.Click += new System.EventHandler(this.fld_btnAdd_Click);
            // 
            // fld_dgcHRAdvanceRequestItems
            // 
            this.fld_dgcHRAdvanceRequestItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRAdvanceRequestItems.BOSComment = null;
            this.fld_dgcHRAdvanceRequestItems.BOSDataMember = null;
            this.fld_dgcHRAdvanceRequestItems.BOSDataSource = "HRAdvanceRequestItems";
            this.fld_dgcHRAdvanceRequestItems.BOSDescription = null;
            this.fld_dgcHRAdvanceRequestItems.BOSError = null;
            this.fld_dgcHRAdvanceRequestItems.BOSFieldGroup = null;
            this.fld_dgcHRAdvanceRequestItems.BOSFieldRelation = null;
            this.fld_dgcHRAdvanceRequestItems.BOSGridType = null;
            this.fld_dgcHRAdvanceRequestItems.BOSPrivilege = null;
            this.fld_dgcHRAdvanceRequestItems.BOSPropertyName = null;
            this.fld_dgcHRAdvanceRequestItems.CommodityType = "";
            this.fld_dgcHRAdvanceRequestItems.Location = new System.Drawing.Point(5, 64);
            this.fld_dgcHRAdvanceRequestItems.MenuManager = this.screenToolbar;
            this.fld_dgcHRAdvanceRequestItems.Name = "fld_dgcHRAdvanceRequestItems";
            this.fld_dgcHRAdvanceRequestItems.PrintReport = false;
            this.fld_dgcHRAdvanceRequestItems.Screen = null;
            this.fld_dgcHRAdvanceRequestItems.Size = new System.Drawing.Size(894, 350);
            this.fld_dgcHRAdvanceRequestItems.TabIndex = 3;
            this.fld_dgcHRAdvanceRequestItems.TabStop = false;
            // 
            // fld_grcGroupControl5
            // 
            this.fld_grcGroupControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl5.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl5.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl5.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl5.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl5.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl5.BOSDescription = null;
            this.fld_grcGroupControl5.BOSError = null;
            this.fld_grcGroupControl5.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl5.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl5.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl5.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_PMProjectID);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel16);
            this.fld_grcGroupControl5.Controls.Add(this.bosTextBox1);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeHRAdvanceRequestType);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel6);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeHRAdvanceRequestStatus);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel25);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtHRAdvanceRequestNo);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_ACSegmentID);
            this.fld_grcGroupControl5.Controls.Add(this.fld_medHRAdvanceRequestDesc);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel7);
            this.fld_grcGroupControl5.Controls.Add(this.fld_dteHRAdvanceRequestDate);
            this.fld_grcGroupControl5.Controls.Add(this.fld_txtHRAdvanceRequestExchangeRate);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl5.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lblLabel2);
            this.fld_grcGroupControl5.Controls.Add(this.fld_lkeFK_GECurrencyID);
            this.fld_grcGroupControl5.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl5.Name = "fld_grcGroupControl5";
            this.fld_grcGroupControl5.Screen = null;
            this.fld_grcGroupControl5.Size = new System.Drawing.Size(904, 144);
            this.fld_grcGroupControl5.TabIndex = 0;
            this.fld_grcGroupControl5.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_grcGroupControl5.Text = "Thông tin chung";
            // 
            // fld_lkeFK_PMProjectID
            // 
            this.fld_lkeFK_PMProjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectID.BOSAllowDummy = true;
            this.fld_lkeFK_PMProjectID.BOSComment = "";
            this.fld_lkeFK_PMProjectID.BOSDataMember = "FK_PMProjectID";
            this.fld_lkeFK_PMProjectID.BOSDataSource = "HRAdvanceRequests";
            this.fld_lkeFK_PMProjectID.BOSDescription = null;
            this.fld_lkeFK_PMProjectID.BOSError = null;
            this.fld_lkeFK_PMProjectID.BOSFieldGroup = "";
            this.fld_lkeFK_PMProjectID.BOSFieldParent = "";
            this.fld_lkeFK_PMProjectID.BOSFieldRelation = "";
            this.fld_lkeFK_PMProjectID.BOSPrivilege = "";
            this.fld_lkeFK_PMProjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMProjectID.BOSSelectType = "";
            this.fld_lkeFK_PMProjectID.BOSSelectTypeValue = "";
            this.fld_lkeFK_PMProjectID.CurrentDisplayText = null;
            this.fld_lkeFK_PMProjectID.Location = new System.Drawing.Point(373, 77);
            this.fld_lkeFK_PMProjectID.Name = "fld_lkeFK_PMProjectID";
            this.fld_lkeFK_PMProjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMProjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMProjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMProjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMProjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMProjectID.Properties.ColumnName = null;
            this.fld_lkeFK_PMProjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectNo", "Mã dự án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectName", "Tên dự án")});
            this.fld_lkeFK_PMProjectID.Properties.DisplayMember = "PMProjectNo";
            this.fld_lkeFK_PMProjectID.Properties.NullText = "";
            this.fld_lkeFK_PMProjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMProjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMProjectID.Properties.ValueMember = "PMProjectID";
            this.fld_lkeFK_PMProjectID.Screen = null;
            this.fld_lkeFK_PMProjectID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_PMProjectID.TabIndex = 7;
            this.fld_lkeFK_PMProjectID.Tag = "DC";
            this.fld_lkeFK_PMProjectID.Visible = false;
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel16.Location = new System.Drawing.Point(283, 81);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(45, 13);
            this.bosLabel16.TabIndex = 111;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Mã dự án";
            this.bosLabel16.Visible = false;
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "HRAdvanceRequestTotalAmount";
            this.bosTextBox1.BOSDataSource = "HRAdvanceRequests";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = "";
            this.bosTextBox1.Location = new System.Drawing.Point(645, 51);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.EditMask = "n2";
            this.bosTextBox1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 8;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel5.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel5.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel5.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel5.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel5.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel5.Location = new System.Drawing.Point(544, 54);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(88, 13);
            this.bosLabel5.TabIndex = 50;
            this.bosLabel5.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel5.Text = "Tổng tiền tạm ứng";
            // 
            // fld_lkeHRAdvanceRequestType
            // 
            this.fld_lkeHRAdvanceRequestType.BOSAllowAddNew = false;
            this.fld_lkeHRAdvanceRequestType.BOSAllowDummy = true;
            this.fld_lkeHRAdvanceRequestType.BOSComment = "";
            this.fld_lkeHRAdvanceRequestType.BOSDataMember = "HRAdvanceRequestType";
            this.fld_lkeHRAdvanceRequestType.BOSDataSource = "HRAdvanceRequests";
            this.fld_lkeHRAdvanceRequestType.BOSDescription = null;
            this.fld_lkeHRAdvanceRequestType.BOSError = null;
            this.fld_lkeHRAdvanceRequestType.BOSFieldGroup = "";
            this.fld_lkeHRAdvanceRequestType.BOSFieldParent = "";
            this.fld_lkeHRAdvanceRequestType.BOSFieldRelation = "";
            this.fld_lkeHRAdvanceRequestType.BOSPrivilege = "";
            this.fld_lkeHRAdvanceRequestType.BOSPropertyName = "EditValue";
            this.fld_lkeHRAdvanceRequestType.BOSSelectType = "";
            this.fld_lkeHRAdvanceRequestType.BOSSelectTypeValue = "";
            this.fld_lkeHRAdvanceRequestType.CurrentDisplayText = null;
            this.fld_lkeHRAdvanceRequestType.Location = new System.Drawing.Point(110, 77);
            this.fld_lkeHRAdvanceRequestType.Name = "fld_lkeHRAdvanceRequestType";
            this.fld_lkeHRAdvanceRequestType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRAdvanceRequestType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRAdvanceRequestType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRAdvanceRequestType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRAdvanceRequestType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRAdvanceRequestType.Properties.ColumnName = null;
            this.fld_lkeHRAdvanceRequestType.Properties.DisplayMember = "ACSegmentName";
            this.fld_lkeHRAdvanceRequestType.Properties.NullText = "";
            this.fld_lkeHRAdvanceRequestType.Properties.PopupWidth = 40;
            this.fld_lkeHRAdvanceRequestType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRAdvanceRequestType.Properties.ValueMember = "ACSegmentID";
            this.fld_lkeHRAdvanceRequestType.Screen = null;
            this.fld_lkeHRAdvanceRequestType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRAdvanceRequestType.TabIndex = 6;
            this.fld_lkeHRAdvanceRequestType.Tag = "DC";
            this.fld_lkeHRAdvanceRequestType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeHRAdvanceRequestType_CloseUp);
            // 
            // fld_lblLabel6
            // 
            this.fld_lblLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel6.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel6.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel6.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel6.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel6.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel6.BOSDescription = null;
            this.fld_lblLabel6.BOSError = null;
            this.fld_lblLabel6.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel6.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel6.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel6.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel6.Location = new System.Drawing.Point(12, 106);
            this.fld_lblLabel6.Name = "fld_lblLabel6";
            this.fld_lblLabel6.Screen = null;
            this.fld_lblLabel6.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel6.TabIndex = 16;
            this.fld_lblLabel6.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel6.Text = "Diễn giải";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel3.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel3.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel3.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel3.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel3.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel3.Location = new System.Drawing.Point(12, 80);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(62, 13);
            this.bosLabel3.TabIndex = 47;
            this.bosLabel3.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel3.Text = "Loại tạm ứng";
            // 
            // fld_lkeHRAdvanceRequestStatus
            // 
            this.fld_lkeHRAdvanceRequestStatus.BOSAllowAddNew = false;
            this.fld_lkeHRAdvanceRequestStatus.BOSAllowDummy = false;
            this.fld_lkeHRAdvanceRequestStatus.BOSComment = null;
            this.fld_lkeHRAdvanceRequestStatus.BOSDataMember = "HRAdvanceRequestStatus";
            this.fld_lkeHRAdvanceRequestStatus.BOSDataSource = "HRAdvanceRequests";
            this.fld_lkeHRAdvanceRequestStatus.BOSDescription = null;
            this.fld_lkeHRAdvanceRequestStatus.BOSError = null;
            this.fld_lkeHRAdvanceRequestStatus.BOSFieldGroup = null;
            this.fld_lkeHRAdvanceRequestStatus.BOSFieldParent = null;
            this.fld_lkeHRAdvanceRequestStatus.BOSFieldRelation = null;
            this.fld_lkeHRAdvanceRequestStatus.BOSPrivilege = null;
            this.fld_lkeHRAdvanceRequestStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRAdvanceRequestStatus.BOSSelectType = null;
            this.fld_lkeHRAdvanceRequestStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRAdvanceRequestStatus.CurrentDisplayText = null;
            this.fld_lkeHRAdvanceRequestStatus.Location = new System.Drawing.Point(645, 25);
            this.fld_lkeHRAdvanceRequestStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHRAdvanceRequestStatus.Name = "fld_lkeHRAdvanceRequestStatus";
            this.fld_lkeHRAdvanceRequestStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeHRAdvanceRequestStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRAdvanceRequestStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRAdvanceRequestStatus.Properties.ColumnName = null;
            this.fld_lkeHRAdvanceRequestStatus.Properties.NullText = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeHRAdvanceRequestStatus.Properties.ReadOnly = true;
            this.fld_lkeHRAdvanceRequestStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRAdvanceRequestStatus.Screen = null;
            this.fld_lkeHRAdvanceRequestStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRAdvanceRequestStatus.TabIndex = 2;
            this.fld_lkeHRAdvanceRequestStatus.Tag = "DC";
            // 
            // fld_lblLabel25
            // 
            this.fld_lblLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel25.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel25.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel25.BOSComment = null;
            this.fld_lblLabel25.BOSDataMember = null;
            this.fld_lblLabel25.BOSDataSource = null;
            this.fld_lblLabel25.BOSDescription = null;
            this.fld_lblLabel25.BOSError = null;
            this.fld_lblLabel25.BOSFieldGroup = null;
            this.fld_lblLabel25.BOSFieldRelation = null;
            this.fld_lblLabel25.BOSPrivilege = null;
            this.fld_lblLabel25.BOSPropertyName = null;
            this.fld_lblLabel25.Location = new System.Drawing.Point(544, 28);
            this.fld_lblLabel25.Name = "fld_lblLabel25";
            this.fld_lblLabel25.Screen = null;
            this.fld_lblLabel25.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel25.TabIndex = 46;
            this.fld_lblLabel25.Text = "Tình trạng";
            // 
            // fld_txtHRAdvanceRequestNo
            // 
            this.fld_txtHRAdvanceRequestNo.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHRAdvanceRequestNo.BOSDataMember = "HRAdvanceRequestNo";
            this.fld_txtHRAdvanceRequestNo.BOSDataSource = "HRAdvanceRequests";
            this.fld_txtHRAdvanceRequestNo.BOSDescription = null;
            this.fld_txtHRAdvanceRequestNo.BOSError = null;
            this.fld_txtHRAdvanceRequestNo.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHRAdvanceRequestNo.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHRAdvanceRequestNo.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHRAdvanceRequestNo.BOSPropertyName = "Text";
            this.fld_txtHRAdvanceRequestNo.EditValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_txtHRAdvanceRequestNo.Location = new System.Drawing.Point(110, 25);
            this.fld_txtHRAdvanceRequestNo.Name = "fld_txtHRAdvanceRequestNo";
            this.fld_txtHRAdvanceRequestNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRAdvanceRequestNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRAdvanceRequestNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRAdvanceRequestNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRAdvanceRequestNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRAdvanceRequestNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRAdvanceRequestNo.Screen = null;
            this.fld_txtHRAdvanceRequestNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRAdvanceRequestNo.TabIndex = 0;
            this.fld_txtHRAdvanceRequestNo.Tag = "DC";
            // 
            // fld_lkeFK_ACSegmentID
            // 
            this.fld_lkeFK_ACSegmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACSegmentID.BOSAllowDummy = true;
            this.fld_lkeFK_ACSegmentID.BOSComment = "";
            this.fld_lkeFK_ACSegmentID.BOSDataMember = "FK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.BOSDataSource = "HRAdvanceRequests";
            this.fld_lkeFK_ACSegmentID.BOSDescription = null;
            this.fld_lkeFK_ACSegmentID.BOSError = null;
            this.fld_lkeFK_ACSegmentID.BOSFieldGroup = "";
            this.fld_lkeFK_ACSegmentID.BOSFieldParent = "";
            this.fld_lkeFK_ACSegmentID.BOSFieldRelation = "";
            this.fld_lkeFK_ACSegmentID.BOSPrivilege = "";
            this.fld_lkeFK_ACSegmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACSegmentID.BOSSelectType = "";
            this.fld_lkeFK_ACSegmentID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACSegmentID.CurrentDisplayText = null;
            this.fld_lkeFK_ACSegmentID.Location = new System.Drawing.Point(645, 77);
            this.fld_lkeFK_ACSegmentID.Name = "fld_lkeFK_ACSegmentID";
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACSegmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACSegmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACSegmentID.Properties.ColumnName = null;
            this.fld_lkeFK_ACSegmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACSegmentName", "Khoản mục chi phí")});
            this.fld_lkeFK_ACSegmentID.Properties.DisplayMember = "ACSegmentName";
            this.fld_lkeFK_ACSegmentID.Properties.NullText = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_ACSegmentID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACSegmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACSegmentID.Properties.ValueMember = "ACSegmentID";
            this.fld_lkeFK_ACSegmentID.Screen = null;
            this.fld_lkeFK_ACSegmentID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACSegmentID.TabIndex = 5;
            this.fld_lkeFK_ACSegmentID.Tag = "DC";
            this.fld_lkeFK_ACSegmentID.Visible = false;
            // 
            // fld_medHRAdvanceRequestDesc
            // 
            this.fld_medHRAdvanceRequestDesc.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_medHRAdvanceRequestDesc.BOSDataMember = "HRAdvanceRequestDesc";
            this.fld_medHRAdvanceRequestDesc.BOSDataSource = "HRAdvanceRequests";
            this.fld_medHRAdvanceRequestDesc.BOSDescription = null;
            this.fld_medHRAdvanceRequestDesc.BOSError = null;
            this.fld_medHRAdvanceRequestDesc.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_medHRAdvanceRequestDesc.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_medHRAdvanceRequestDesc.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_medHRAdvanceRequestDesc.BOSPropertyName = "Text";
            this.fld_medHRAdvanceRequestDesc.EditValue = "(Liên 2 - Giao cho khách hàng)";
            this.fld_medHRAdvanceRequestDesc.Location = new System.Drawing.Point(110, 103);
            this.fld_medHRAdvanceRequestDesc.Name = "fld_medHRAdvanceRequestDesc";
            this.fld_medHRAdvanceRequestDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRAdvanceRequestDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRAdvanceRequestDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRAdvanceRequestDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRAdvanceRequestDesc.Screen = null;
            this.fld_medHRAdvanceRequestDesc.Size = new System.Drawing.Size(685, 33);
            this.fld_medHRAdvanceRequestDesc.TabIndex = 9;
            this.fld_medHRAdvanceRequestDesc.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel7.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel7.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel7.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel7.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel7.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel7.Location = new System.Drawing.Point(544, 80);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(85, 13);
            this.bosLabel7.TabIndex = 44;
            this.bosLabel7.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel7.Text = "Khoản mục chi phí";
            this.bosLabel7.Visible = false;
            // 
            // fld_dteHRAdvanceRequestDate
            // 
            this.fld_dteHRAdvanceRequestDate.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dteHRAdvanceRequestDate.BOSDataMember = "HRAdvanceRequestDate";
            this.fld_dteHRAdvanceRequestDate.BOSDataSource = "HRAdvanceRequests";
            this.fld_dteHRAdvanceRequestDate.BOSDescription = null;
            this.fld_dteHRAdvanceRequestDate.BOSError = null;
            this.fld_dteHRAdvanceRequestDate.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dteHRAdvanceRequestDate.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dteHRAdvanceRequestDate.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_dteHRAdvanceRequestDate.BOSPropertyName = "EditValue";
            this.fld_dteHRAdvanceRequestDate.EditValue = null;
            this.fld_dteHRAdvanceRequestDate.Location = new System.Drawing.Point(373, 25);
            this.fld_dteHRAdvanceRequestDate.Name = "fld_dteHRAdvanceRequestDate";
            this.fld_dteHRAdvanceRequestDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRAdvanceRequestDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRAdvanceRequestDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRAdvanceRequestDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRAdvanceRequestDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRAdvanceRequestDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRAdvanceRequestDate.Screen = null;
            this.fld_dteHRAdvanceRequestDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRAdvanceRequestDate.TabIndex = 1;
            this.fld_dteHRAdvanceRequestDate.Tag = "DC";
            // 
            // fld_txtHRAdvanceRequestExchangeRate
            // 
            this.fld_txtHRAdvanceRequestExchangeRate.BOSComment = "";
            this.fld_txtHRAdvanceRequestExchangeRate.BOSDataMember = "HRAdvanceRequestExchangeRate";
            this.fld_txtHRAdvanceRequestExchangeRate.BOSDataSource = "HRAdvanceRequests";
            this.fld_txtHRAdvanceRequestExchangeRate.BOSDescription = null;
            this.fld_txtHRAdvanceRequestExchangeRate.BOSError = null;
            this.fld_txtHRAdvanceRequestExchangeRate.BOSFieldGroup = "";
            this.fld_txtHRAdvanceRequestExchangeRate.BOSFieldRelation = "";
            this.fld_txtHRAdvanceRequestExchangeRate.BOSPrivilege = "";
            this.fld_txtHRAdvanceRequestExchangeRate.BOSPropertyName = "Text";
            this.fld_txtHRAdvanceRequestExchangeRate.EditValue = "";
            this.fld_txtHRAdvanceRequestExchangeRate.Location = new System.Drawing.Point(373, 51);
            this.fld_txtHRAdvanceRequestExchangeRate.Name = "fld_txtHRAdvanceRequestExchangeRate";
            this.fld_txtHRAdvanceRequestExchangeRate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRAdvanceRequestExchangeRate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRAdvanceRequestExchangeRate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRAdvanceRequestExchangeRate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRAdvanceRequestExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRAdvanceRequestExchangeRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRAdvanceRequestExchangeRate.Screen = null;
            this.fld_txtHRAdvanceRequestExchangeRate.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRAdvanceRequestExchangeRate.TabIndex = 4;
            this.fld_txtHRAdvanceRequestExchangeRate.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel4.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel4.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel4.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel4.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel4.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel4.Location = new System.Drawing.Point(283, 54);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(29, 13);
            this.bosLabel4.TabIndex = 10;
            this.bosLabel4.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel4.Text = "Tỷ giá";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel4.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel4.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel4.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel4.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel4.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel4.Location = new System.Drawing.Point(283, 28);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel4.TabIndex = 2;
            this.fld_lblLabel4.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel4.Text = "Ngày chứng từ";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel2.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel2.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel2.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel2.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel2.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel2.Location = new System.Drawing.Point(12, 54);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(53, 13);
            this.bosLabel2.TabIndex = 8;
            this.bosLabel2.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.bosLabel2.Text = "Loại tiền tệ";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel2.BOSDataMember = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel2.BOSDataSource = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel2.BOSFieldRelation = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel2.BOSPrivilege = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel2.BOSPropertyName = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel2.Location = new System.Drawing.Point(12, 28);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel2.TabIndex = 0;
            this.fld_lblLabel2.Tag = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lblLabel2.Text = "Mã chứng từ";
            // 
            // fld_lkeFK_GECurrencyID
            // 
            this.fld_lkeFK_GECurrencyID.BOSAllowAddNew = false;
            this.fld_lkeFK_GECurrencyID.BOSAllowDummy = false;
            this.fld_lkeFK_GECurrencyID.BOSComment = "";
            this.fld_lkeFK_GECurrencyID.BOSDataMember = "FK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.BOSDataSource = "HRAdvanceRequests";
            this.fld_lkeFK_GECurrencyID.BOSDescription = null;
            this.fld_lkeFK_GECurrencyID.BOSError = null;
            this.fld_lkeFK_GECurrencyID.BOSFieldGroup = "";
            this.fld_lkeFK_GECurrencyID.BOSFieldParent = "";
            this.fld_lkeFK_GECurrencyID.BOSFieldRelation = "";
            this.fld_lkeFK_GECurrencyID.BOSPrivilege = "";
            this.fld_lkeFK_GECurrencyID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_GECurrencyID.BOSSelectType = "";
            this.fld_lkeFK_GECurrencyID.BOSSelectTypeValue = "";
            this.fld_lkeFK_GECurrencyID.CurrentDisplayText = null;
            this.fld_lkeFK_GECurrencyID.Location = new System.Drawing.Point(110, 51);
            this.fld_lkeFK_GECurrencyID.Name = "fld_lkeFK_GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_GECurrencyID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_GECurrencyID.Properties.ColumnName = null;
            this.fld_lkeFK_GECurrencyID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GECurrencyName", "Loại tiền tệ")});
            this.fld_lkeFK_GECurrencyID.Properties.DisplayMember = "GECurrencyName";
            this.fld_lkeFK_GECurrencyID.Properties.NullText = "(Liên 2 - Giao cho khách hàng)";
            this.fld_lkeFK_GECurrencyID.Properties.PopupWidth = 40;
            this.fld_lkeFK_GECurrencyID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_GECurrencyID.Properties.ValueMember = "GECurrencyID";
            this.fld_lkeFK_GECurrencyID.Screen = null;
            this.fld_lkeFK_GECurrencyID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_GECurrencyID.TabIndex = 3;
            this.fld_lkeFK_GECurrencyID.Tag = "DC";
            this.fld_lkeFK_GECurrencyID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_GECurrencyID_CloseUp);
            // 
            // DMHAR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(910, 583);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMHAR100.IconOptions.Icon")));
            this.Name = "DMHAR100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRAdvanceRequestItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl5)).EndInit();
            this.fld_grcGroupControl5.ResumeLayout(false);
            this.fld_grcGroupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRAdvanceRequestType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRAdvanceRequestStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdvanceRequestNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACSegmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRAdvanceRequestDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRequestDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRAdvanceRequestDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRAdvanceRequestExchangeRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_GECurrencyID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACSegmentID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTextBox fld_txtHRAdvanceRequestExchangeRate;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_GECurrencyID;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel6;
        private BOSComponent.BOSTextBox fld_txtHRAdvanceRequestNo;
        private BOSComponent.BOSDateEdit fld_dteHRAdvanceRequestDate;
        private BOSComponent.BOSMemoEdit fld_medHRAdvanceRequestDesc;
        private IContainer components;
        private BOSComponent.BOSGroupControl fld_grcGroupControl5;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSERP.Modules.AdvanceRequest.AdvanceRequestItemsGridControl fld_dgcHRAdvanceRequestItems;
        private BOSComponent.BOSButton fld_btnDelete;
        private BOSComponent.BOSButton fld_btnAdd;
        private BOSComponent.BOSLookupEdit fld_lkeHRAdvanceRequestStatus;
        private BOSComponent.BOSLabel fld_lblLabel25;
        private BOSComponent.BOSLookupEdit fld_lkeHRAdvanceRequestType;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectID;
        private BOSComponent.BOSLabel bosLabel16;
	}
}
