using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.RevenueForecast.UI
{
	/// <summary>
	/// Summary description for DMLM100
	/// </summary>
	partial class DMRF100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMRF100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.fld_lkeRoundingNumber = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnLoadRealRevenue = new BOSComponent.BOSButton(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARRevenueForecastType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnCalculatePredictRevenue = new BOSComponent.BOSButton(this.components);
            this.fld_btnLoadItem = new BOSComponent.BOSButton(this.components);
            this.fld_ckeIsDiscount = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_dgcARRevenueForecastItems = new BOSERP.Modules.RevenueForecast.RevenueForecastItemsGridControl();
            this.fld_dgvARRevenueForecastItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARRevenueForecastStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARRevenueForecastDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARRevenueForecastNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeRoundingNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARRevenueForecastType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeIsDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRevenueForecastItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARRevenueForecastItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARRevenueForecastStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARRevenueForecastDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARRevenueForecastDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARRevenueForecastNo.Properties)).BeginInit();
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
            this.bosPanel1.Size = new System.Drawing.Size(1158, 575);
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
            this.fld_grcGroupControl.Controls.Add(this.bosButton1);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeRoundingNumber);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel7);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnLoadRealRevenue);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel6);
            this.fld_grcGroupControl.Controls.Add(this.bosTextBox2);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl.Controls.Add(this.bosTextBox1);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeARRevenueForecastType);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnCalculatePredictRevenue);
            this.fld_grcGroupControl.Controls.Add(this.fld_btnLoadItem);
            this.fld_grcGroupControl.Controls.Add(this.fld_ckeIsDiscount);
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcARRevenueForecastItems);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel9);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeARRevenueForecastStatus);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteARRevenueForecastDate);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtARRevenueForecastNo);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl, true);
            this.fld_grcGroupControl.Size = new System.Drawing.Size(1152, 572);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // bosButton1
            // 
            this.bosButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bosButton1.Appearance.Options.UseFont = true;
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.Location = new System.Drawing.Point(935, 38);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(132, 31);
            this.bosButton1.TabIndex = 42;
            this.bosButton1.Text = "Export Excel";
            this.bosButton1.Visible = false;
            // 
            // fld_lkeRoundingNumber
            // 
            this.fld_lkeRoundingNumber.BOSAllowAddNew = false;
            this.fld_lkeRoundingNumber.BOSAllowDummy = false;
            this.fld_lkeRoundingNumber.BOSComment = null;
            this.fld_lkeRoundingNumber.BOSDataMember = "ARRoundingNumber";
            this.fld_lkeRoundingNumber.BOSDataSource = "";
            this.fld_lkeRoundingNumber.BOSDescription = null;
            this.fld_lkeRoundingNumber.BOSError = null;
            this.fld_lkeRoundingNumber.BOSFieldGroup = null;
            this.fld_lkeRoundingNumber.BOSFieldParent = null;
            this.fld_lkeRoundingNumber.BOSFieldRelation = null;
            this.fld_lkeRoundingNumber.BOSPrivilege = null;
            this.fld_lkeRoundingNumber.BOSPropertyName = "EditValue";
            this.fld_lkeRoundingNumber.BOSSelectType = null;
            this.fld_lkeRoundingNumber.BOSSelectTypeValue = null;
            this.fld_lkeRoundingNumber.CurrentDisplayText = null;
            this.fld_lkeRoundingNumber.Location = new System.Drawing.Point(612, 97);
            this.fld_lkeRoundingNumber.MenuManager = this.screenToolbar;
            this.fld_lkeRoundingNumber.Name = "fld_lkeRoundingNumber";
            this.fld_lkeRoundingNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeRoundingNumber.Properties.ColumnName = null;
            this.fld_lkeRoundingNumber.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADConfigText", "")});
            this.fld_lkeRoundingNumber.Properties.DisplayMember = "ADConfigText";
            this.fld_lkeRoundingNumber.Properties.NullText = "";
            this.fld_lkeRoundingNumber.Properties.PopupWidth = 40;
            this.fld_lkeRoundingNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeRoundingNumber.Properties.ValueMember = "ADConfigKeyValue";
            this.fld_lkeRoundingNumber.Screen = null;
            this.fld_lkeRoundingNumber.Size = new System.Drawing.Size(118, 20);
            this.fld_lkeRoundingNumber.TabIndex = 41;
            this.fld_lkeRoundingNumber.Tag = "DC";
            this.fld_lkeRoundingNumber.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeRoundingNumber_CloseUp);
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
            this.bosLabel7.Location = new System.Drawing.Point(480, 100);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(65, 13);
            this.bosLabel7.TabIndex = 40;
            this.bosLabel7.Text = "Đơn vị tiền tệ";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARRevenueForecasts";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(342, 97);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(121, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 39;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = true;
            this.fld_lkeFK_ARCustomerID.BOSComment = null;
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "ARRevenueForecasts";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = "";
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = null;
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = null;
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID.BOSSelectType = null;
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = null;
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(342, 45);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.ColumnName = null;
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADConfigText", "")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = "";
            this.fld_lkeFK_ARCustomerID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(121, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 38;
            this.fld_lkeFK_ARCustomerID.Tag = "DC";
            // 
            // fld_btnLoadRealRevenue
            // 
            this.fld_btnLoadRealRevenue.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_btnLoadRealRevenue.Appearance.Options.UseFont = true;
            this.fld_btnLoadRealRevenue.BOSComment = null;
            this.fld_btnLoadRealRevenue.BOSDataMember = null;
            this.fld_btnLoadRealRevenue.BOSDataSource = null;
            this.fld_btnLoadRealRevenue.BOSDescription = null;
            this.fld_btnLoadRealRevenue.BOSError = null;
            this.fld_btnLoadRealRevenue.BOSFieldGroup = null;
            this.fld_btnLoadRealRevenue.BOSFieldRelation = null;
            this.fld_btnLoadRealRevenue.BOSPrivilege = null;
            this.fld_btnLoadRealRevenue.BOSPropertyName = null;
            this.fld_btnLoadRealRevenue.Location = new System.Drawing.Point(935, 38);
            this.fld_btnLoadRealRevenue.Name = "fld_btnLoadRealRevenue";
            this.fld_btnLoadRealRevenue.Screen = null;
            this.fld_btnLoadRealRevenue.Size = new System.Drawing.Size(132, 31);
            this.fld_btnLoadRealRevenue.TabIndex = 37;
            this.fld_btnLoadRealRevenue.Text = "Load doanh thu thực tế";
            this.fld_btnLoadRealRevenue.Visible = false;
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = "";
            this.bosLabel6.BOSDataMember = "";
            this.bosLabel6.BOSDataSource = "";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "";
            this.bosLabel6.BOSFieldRelation = "";
            this.bosLabel6.BOSPrivilege = "";
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(480, 74);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(124, 13);
            this.bosLabel6.TabIndex = 35;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Tỉ lệ tăng giảm dự kiến (%)";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "ARRevenueForecastRate";
            this.bosTextBox2.BOSDataSource = "ARRevenueForecasts";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = "";
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.Location = new System.Drawing.Point(612, 71);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.bosTextBox2.Properties.MaskSettings.Set("mask", "n2");
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox2, true);
            this.bosTextBox2.Size = new System.Drawing.Size(118, 20);
            this.bosTextBox2.TabIndex = 36;
            this.bosTextBox2.Tag = "DC";
            this.bosTextBox2.Validated += new System.EventHandler(this.bosTextBox2_Validated);
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "";
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(480, 48);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(60, 13);
            this.bosLabel4.TabIndex = 33;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Năm dự kiến";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "ARRevenueForecastYear";
            this.bosTextBox1.BOSDataSource = "ARRevenueForecasts";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = "";
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(612, 45);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox1, true);
            this.bosTextBox1.Size = new System.Drawing.Size(118, 20);
            this.bosTextBox1.TabIndex = 34;
            this.bosTextBox1.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(248, 48);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(56, 13);
            this.bosLabel2.TabIndex = 26;
            this.bosLabel2.Text = "Khách hàng";
            // 
            // fld_lkeARRevenueForecastType
            // 
            this.fld_lkeARRevenueForecastType.BOSAllowAddNew = false;
            this.fld_lkeARRevenueForecastType.BOSAllowDummy = true;
            this.fld_lkeARRevenueForecastType.BOSComment = null;
            this.fld_lkeARRevenueForecastType.BOSDataMember = "ARCustomerType";
            this.fld_lkeARRevenueForecastType.BOSDataSource = "ARRevenueForecasts";
            this.fld_lkeARRevenueForecastType.BOSDescription = null;
            this.fld_lkeARRevenueForecastType.BOSError = null;
            this.fld_lkeARRevenueForecastType.BOSFieldGroup = null;
            this.fld_lkeARRevenueForecastType.BOSFieldParent = null;
            this.fld_lkeARRevenueForecastType.BOSFieldRelation = null;
            this.fld_lkeARRevenueForecastType.BOSPrivilege = null;
            this.fld_lkeARRevenueForecastType.BOSPropertyName = "EditValue";
            this.fld_lkeARRevenueForecastType.BOSSelectType = null;
            this.fld_lkeARRevenueForecastType.BOSSelectTypeValue = null;
            this.fld_lkeARRevenueForecastType.CurrentDisplayText = null;
            this.fld_lkeARRevenueForecastType.Location = new System.Drawing.Point(342, 71);
            this.fld_lkeARRevenueForecastType.MenuManager = this.screenToolbar;
            this.fld_lkeARRevenueForecastType.Name = "fld_lkeARRevenueForecastType";
            this.fld_lkeARRevenueForecastType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARRevenueForecastType.Properties.ColumnName = null;
            this.fld_lkeARRevenueForecastType.Properties.NullText = "";
            this.fld_lkeARRevenueForecastType.Properties.PopupWidth = 40;
            this.fld_lkeARRevenueForecastType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARRevenueForecastType.Screen = null;
            this.fld_lkeARRevenueForecastType.Size = new System.Drawing.Size(121, 20);
            this.fld_lkeARRevenueForecastType.TabIndex = 29;
            this.fld_lkeARRevenueForecastType.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(248, 74);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(85, 13);
            this.bosLabel1.TabIndex = 28;
            this.bosLabel1.Text = "Nhóm khách hàng";
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
            this.bosLabel3.Location = new System.Drawing.Point(248, 100);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 30;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Nhân viên";
            // 
            // fld_btnCalculatePredictRevenue
            // 
            this.fld_btnCalculatePredictRevenue.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_btnCalculatePredictRevenue.Appearance.Options.UseFont = true;
            this.fld_btnCalculatePredictRevenue.BOSComment = null;
            this.fld_btnCalculatePredictRevenue.BOSDataMember = null;
            this.fld_btnCalculatePredictRevenue.BOSDataSource = null;
            this.fld_btnCalculatePredictRevenue.BOSDescription = null;
            this.fld_btnCalculatePredictRevenue.BOSError = null;
            this.fld_btnCalculatePredictRevenue.BOSFieldGroup = null;
            this.fld_btnCalculatePredictRevenue.BOSFieldRelation = null;
            this.fld_btnCalculatePredictRevenue.BOSPrivilege = null;
            this.fld_btnCalculatePredictRevenue.BOSPropertyName = null;
            this.fld_btnCalculatePredictRevenue.Location = new System.Drawing.Point(935, 75);
            this.fld_btnCalculatePredictRevenue.Name = "fld_btnCalculatePredictRevenue";
            this.fld_btnCalculatePredictRevenue.Screen = null;
            this.fld_btnCalculatePredictRevenue.Size = new System.Drawing.Size(132, 30);
            this.fld_btnCalculatePredictRevenue.TabIndex = 31;
            this.fld_btnCalculatePredictRevenue.Text = "Tính doanh thu dự kiến";
            this.fld_btnCalculatePredictRevenue.Click += new System.EventHandler(this.fld_btnCalculatePredictRevenue_Click);
            // 
            // fld_btnLoadItem
            // 
            this.fld_btnLoadItem.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_btnLoadItem.Appearance.Options.UseFont = true;
            this.fld_btnLoadItem.BOSComment = null;
            this.fld_btnLoadItem.BOSDataMember = null;
            this.fld_btnLoadItem.BOSDataSource = null;
            this.fld_btnLoadItem.BOSDescription = null;
            this.fld_btnLoadItem.BOSError = null;
            this.fld_btnLoadItem.BOSFieldGroup = null;
            this.fld_btnLoadItem.BOSFieldRelation = null;
            this.fld_btnLoadItem.BOSPrivilege = null;
            this.fld_btnLoadItem.BOSPropertyName = null;
            this.fld_btnLoadItem.Location = new System.Drawing.Point(770, 74);
            this.fld_btnLoadItem.Name = "fld_btnLoadItem";
            this.fld_btnLoadItem.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnLoadItem, true);
            this.fld_btnLoadItem.Size = new System.Drawing.Size(148, 31);
            this.fld_btnLoadItem.TabIndex = 32;
            this.fld_btnLoadItem.Text = "Load danh sách khách hàng";
            this.fld_btnLoadItem.Click += new System.EventHandler(this.fld_btnLoadItem_Click);
            // 
            // fld_ckeIsDiscount
            // 
            this.fld_ckeIsDiscount.BOSComment = "";
            this.fld_ckeIsDiscount.BOSDataMember = "";
            this.fld_ckeIsDiscount.BOSDataSource = "";
            this.fld_ckeIsDiscount.BOSDescription = null;
            this.fld_ckeIsDiscount.BOSError = "";
            this.fld_ckeIsDiscount.BOSFieldGroup = "";
            this.fld_ckeIsDiscount.BOSFieldRelation = "";
            this.fld_ckeIsDiscount.BOSPrivilege = "";
            this.fld_ckeIsDiscount.BOSPropertyName = "EditValue";
            this.fld_ckeIsDiscount.Location = new System.Drawing.Point(770, 45);
            this.fld_ckeIsDiscount.Name = "fld_ckeIsDiscount";
            this.fld_ckeIsDiscount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_ckeIsDiscount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_ckeIsDiscount.Properties.Appearance.Options.UseBackColor = true;
            this.fld_ckeIsDiscount.Properties.Appearance.Options.UseForeColor = true;
            this.fld_ckeIsDiscount.Properties.Caption = "Có bao gồm chiết khấu";
            this.fld_ckeIsDiscount.Screen = null;
            this.fld_ckeIsDiscount.Size = new System.Drawing.Size(159, 20);
            this.fld_ckeIsDiscount.TabIndex = 27;
            this.fld_ckeIsDiscount.Tag = "DC";
            // 
            // fld_dgcARRevenueForecastItems
            // 
            this.fld_dgcARRevenueForecastItems.AllowDrop = true;
            this.fld_dgcARRevenueForecastItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARRevenueForecastItems.BOSComment = null;
            this.fld_dgcARRevenueForecastItems.BOSDataMember = null;
            this.fld_dgcARRevenueForecastItems.BOSDataSource = "ARRevenueForecastItems";
            this.fld_dgcARRevenueForecastItems.BOSDescription = null;
            this.fld_dgcARRevenueForecastItems.BOSError = null;
            this.fld_dgcARRevenueForecastItems.BOSFieldGroup = null;
            this.fld_dgcARRevenueForecastItems.BOSFieldRelation = null;
            this.fld_dgcARRevenueForecastItems.BOSGridType = null;
            this.fld_dgcARRevenueForecastItems.BOSPrivilege = null;
            this.fld_dgcARRevenueForecastItems.BOSPropertyName = null;
            this.fld_dgcARRevenueForecastItems.CommodityType = "";
            this.fld_dgcARRevenueForecastItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARRevenueForecastItems.GridViewMain = null;
            this.fld_dgcARRevenueForecastItems.Location = new System.Drawing.Point(5, 133);
            this.fld_dgcARRevenueForecastItems.MainView = this.fld_dgvARRevenueForecastItems;
            this.fld_dgcARRevenueForecastItems.Name = "fld_dgcARRevenueForecastItems";
            this.fld_dgcARRevenueForecastItems.PrintReport = false;
            this.fld_dgcARRevenueForecastItems.RowHandle = 0;
            this.fld_dgcARRevenueForecastItems.Screen = null;
            this.fld_dgcARRevenueForecastItems.Size = new System.Drawing.Size(1138, 434);
            this.fld_dgcARRevenueForecastItems.TabIndex = 7;
            this.fld_dgcARRevenueForecastItems.Tag = "DC";
            this.fld_dgcARRevenueForecastItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARRevenueForecastItems});
            // 
            // fld_dgvARRevenueForecastItems
            // 
            this.fld_dgvARRevenueForecastItems.GridControl = this.fld_dgcARRevenueForecastItems;
            this.fld_dgvARRevenueForecastItems.Name = "fld_dgvARRevenueForecastItems";
            this.fld_dgvARRevenueForecastItems.PaintStyleName = "Office2003";
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
            // fld_lkeARRevenueForecastStatus
            // 
            this.fld_lkeARRevenueForecastStatus.BOSAllowAddNew = false;
            this.fld_lkeARRevenueForecastStatus.BOSAllowDummy = false;
            this.fld_lkeARRevenueForecastStatus.BOSComment = null;
            this.fld_lkeARRevenueForecastStatus.BOSDataMember = "ARRevenueForecastStatus";
            this.fld_lkeARRevenueForecastStatus.BOSDataSource = "ARRevenueForecasts";
            this.fld_lkeARRevenueForecastStatus.BOSDescription = null;
            this.fld_lkeARRevenueForecastStatus.BOSError = null;
            this.fld_lkeARRevenueForecastStatus.BOSFieldGroup = null;
            this.fld_lkeARRevenueForecastStatus.BOSFieldParent = null;
            this.fld_lkeARRevenueForecastStatus.BOSFieldRelation = null;
            this.fld_lkeARRevenueForecastStatus.BOSPrivilege = null;
            this.fld_lkeARRevenueForecastStatus.BOSPropertyName = "EditValue";
            this.fld_lkeARRevenueForecastStatus.BOSSelectType = null;
            this.fld_lkeARRevenueForecastStatus.BOSSelectTypeValue = null;
            this.fld_lkeARRevenueForecastStatus.CurrentDisplayText = null;
            this.fld_lkeARRevenueForecastStatus.Enabled = false;
            this.fld_lkeARRevenueForecastStatus.Location = new System.Drawing.Point(109, 97);
            this.fld_lkeARRevenueForecastStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARRevenueForecastStatus.Name = "fld_lkeARRevenueForecastStatus";
            this.fld_lkeARRevenueForecastStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARRevenueForecastStatus.Properties.ColumnName = null;
            this.fld_lkeARRevenueForecastStatus.Properties.NullText = "";
            this.fld_lkeARRevenueForecastStatus.Screen = null;
            this.fld_lkeARRevenueForecastStatus.Size = new System.Drawing.Size(118, 20);
            this.fld_lkeARRevenueForecastStatus.TabIndex = 5;
            this.fld_lkeARRevenueForecastStatus.Tag = "DC";
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
            // fld_dteARRevenueForecastDate
            // 
            this.fld_dteARRevenueForecastDate.BOSComment = null;
            this.fld_dteARRevenueForecastDate.BOSDataMember = "ARRevenueForecastDate";
            this.fld_dteARRevenueForecastDate.BOSDataSource = "ARRevenueForecasts";
            this.fld_dteARRevenueForecastDate.BOSDescription = null;
            this.fld_dteARRevenueForecastDate.BOSError = null;
            this.fld_dteARRevenueForecastDate.BOSFieldGroup = null;
            this.fld_dteARRevenueForecastDate.BOSFieldRelation = null;
            this.fld_dteARRevenueForecastDate.BOSPrivilege = null;
            this.fld_dteARRevenueForecastDate.BOSPropertyName = "EditValue";
            this.fld_dteARRevenueForecastDate.EditValue = null;
            this.fld_dteARRevenueForecastDate.Location = new System.Drawing.Point(109, 71);
            this.fld_dteARRevenueForecastDate.MenuManager = this.screenToolbar;
            this.fld_dteARRevenueForecastDate.Name = "fld_dteARRevenueForecastDate";
            this.fld_dteARRevenueForecastDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARRevenueForecastDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARRevenueForecastDate.Screen = null;
            this.fld_dteARRevenueForecastDate.Size = new System.Drawing.Size(118, 20);
            this.fld_dteARRevenueForecastDate.TabIndex = 3;
            this.fld_dteARRevenueForecastDate.Tag = "DC";
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
            // fld_txtARRevenueForecastNo
            // 
            this.fld_txtARRevenueForecastNo.BOSComment = "";
            this.fld_txtARRevenueForecastNo.BOSDataMember = "ARRevenueForecastNo";
            this.fld_txtARRevenueForecastNo.BOSDataSource = "ARRevenueForecasts";
            this.fld_txtARRevenueForecastNo.BOSDescription = null;
            this.fld_txtARRevenueForecastNo.BOSError = "";
            this.fld_txtARRevenueForecastNo.BOSFieldGroup = "";
            this.fld_txtARRevenueForecastNo.BOSFieldRelation = "";
            this.fld_txtARRevenueForecastNo.BOSPrivilege = "";
            this.fld_txtARRevenueForecastNo.BOSPropertyName = "Text";
            this.fld_txtARRevenueForecastNo.Location = new System.Drawing.Point(109, 45);
            this.fld_txtARRevenueForecastNo.Name = "fld_txtARRevenueForecastNo";
            this.fld_txtARRevenueForecastNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARRevenueForecastNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARRevenueForecastNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARRevenueForecastNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARRevenueForecastNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARRevenueForecastNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARRevenueForecastNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtARRevenueForecastNo, true);
            this.fld_txtARRevenueForecastNo.Size = new System.Drawing.Size(118, 20);
            this.fld_txtARRevenueForecastNo.TabIndex = 1;
            this.fld_txtARRevenueForecastNo.Tag = "DC";
            // 
            // DMRF100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1158, 575);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMRF100.IconOptions.Icon")));
            this.Name = "DMRF100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.DMRF100_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeRoundingNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARRevenueForecastType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeIsDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRevenueForecastItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARRevenueForecastItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARRevenueForecastStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARRevenueForecastDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARRevenueForecastDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARRevenueForecastNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSTextBox fld_txtARRevenueForecastNo;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dteARRevenueForecastDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeARRevenueForecastStatus;
        private RevenueForecastItemsGridControl fld_dgcARRevenueForecastItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARRevenueForecastItems;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSLookupEdit fld_lkeRoundingNumber;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSButton fld_btnLoadRealRevenue;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeARRevenueForecastType;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSButton fld_btnCalculatePredictRevenue;
        private BOSComponent.BOSButton fld_btnLoadItem;
        private BOSComponent.BOSCheckEdit fld_ckeIsDiscount;
    }
}
