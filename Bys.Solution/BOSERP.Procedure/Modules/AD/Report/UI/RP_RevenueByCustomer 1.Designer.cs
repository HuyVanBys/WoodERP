using BOSComponent;
namespace BOSERP.Modules.Report
{
    partial class RP_RevenueByCustomer1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP_RevenueByCustomer1));
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeRoundingNumber = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_tbYear = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeViewType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_ckeIsDiscount = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARCustomerType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosButton2 = new BOSComponent.BOSButton(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARInvoices = new BOSComponent.BOSGridControl(this.components);
            this.fld_dteFromYear = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteToYear = new BOSComponent.BOSDateEdit(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeRoundingNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tbYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeViewType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeIsDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerID.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromYear.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToYear.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToYear.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.fld_btnApply.Location = new System.Drawing.Point(804, 8);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(78, 28);
            this.fld_btnApply.TabIndex = 7;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
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
            this.bosPanel1.Controls.Add(this.fld_lkeRoundingNumber);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_tbYear);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeViewType);
            this.bosPanel1.Controls.Add(this.fld_ckeIsDiscount);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lkeHREmployeeID);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeARCustomerType);
            this.bosPanel1.Controls.Add(this.bosButton2);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_lkeARCustomerID);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosButton1);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_btnApply);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1237, 679);
            this.bosPanel1.TabIndex = 0;
            this.bosPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bosPanel1_Paint);
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
            this.fld_lkeRoundingNumber.Location = new System.Drawing.Point(596, 12);
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
            this.fld_lkeRoundingNumber.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeRoundingNumber.TabIndex = 416;
            this.fld_lkeRoundingNumber.Tag = "DC";
            this.fld_lkeRoundingNumber.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeRoundingNumber_CloseUp);
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
            this.bosLabel8.Location = new System.Drawing.Point(517, 15);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(65, 13);
            this.bosLabel8.TabIndex = 415;
            this.bosLabel8.Text = "Đơn vị tiền tệ";
            // 
            // fld_tbYear
            // 
            this.fld_tbYear.BOSComment = "";
            this.fld_tbYear.BOSDataMember = "ARRevenueForecastYear";
            this.fld_tbYear.BOSDataSource = "ARRevenueForecasts";
            this.fld_tbYear.BOSDescription = null;
            this.fld_tbYear.BOSError = "";
            this.fld_tbYear.BOSFieldGroup = "";
            this.fld_tbYear.BOSFieldRelation = "";
            this.fld_tbYear.BOSPrivilege = "";
            this.fld_tbYear.BOSPropertyName = "Text";
            this.fld_tbYear.Location = new System.Drawing.Point(73, 12);
            this.fld_tbYear.Name = "fld_tbYear";
            this.fld_tbYear.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_tbYear.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_tbYear.Properties.Appearance.Options.UseBackColor = true;
            this.fld_tbYear.Properties.Appearance.Options.UseForeColor = true;
            this.fld_tbYear.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_tbYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_tbYear.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_tbYear, true);
            this.fld_tbYear.Size = new System.Drawing.Size(150, 20);
            this.fld_tbYear.TabIndex = 414;
            this.fld_tbYear.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(517, 41);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(45, 13);
            this.bosLabel7.TabIndex = 413;
            this.bosLabel7.Text = "Xem theo";
            // 
            // fld_lkeViewType
            // 
            this.fld_lkeViewType.BOSAllowAddNew = false;
            this.fld_lkeViewType.BOSAllowDummy = true;
            this.fld_lkeViewType.BOSComment = null;
            this.fld_lkeViewType.BOSDataMember = "ViewType";
            this.fld_lkeViewType.BOSDataSource = "";
            this.fld_lkeViewType.BOSDescription = null;
            this.fld_lkeViewType.BOSError = null;
            this.fld_lkeViewType.BOSFieldGroup = null;
            this.fld_lkeViewType.BOSFieldParent = null;
            this.fld_lkeViewType.BOSFieldRelation = null;
            this.fld_lkeViewType.BOSPrivilege = null;
            this.fld_lkeViewType.BOSPropertyName = null;
            this.fld_lkeViewType.BOSSelectType = null;
            this.fld_lkeViewType.BOSSelectTypeValue = null;
            this.fld_lkeViewType.CurrentDisplayText = null;
            this.fld_lkeViewType.Location = new System.Drawing.Point(596, 38);
            this.fld_lkeViewType.MenuManager = this.screenToolbar;
            this.fld_lkeViewType.Name = "fld_lkeViewType";
            this.fld_lkeViewType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeViewType.Properties.ColumnName = null;
            this.fld_lkeViewType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADConfigText", "")});
            this.fld_lkeViewType.Properties.DisplayMember = "ADConfigText";
            this.fld_lkeViewType.Properties.NullText = "";
            this.fld_lkeViewType.Properties.PopupWidth = 40;
            this.fld_lkeViewType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeViewType.Properties.ValueMember = "ADConfigKeyValue";
            this.fld_lkeViewType.Screen = null;
            this.fld_lkeViewType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeViewType.TabIndex = 412;
            // 
            // fld_ckeIsDiscount
            // 
            this.fld_ckeIsDiscount.BOSComment = null;
            this.fld_ckeIsDiscount.BOSDataMember = "";
            this.fld_ckeIsDiscount.BOSDataSource = "";
            this.fld_ckeIsDiscount.BOSDescription = null;
            this.fld_ckeIsDiscount.BOSError = null;
            this.fld_ckeIsDiscount.BOSFieldGroup = null;
            this.fld_ckeIsDiscount.BOSFieldRelation = null;
            this.fld_ckeIsDiscount.BOSPrivilege = null;
            this.fld_ckeIsDiscount.BOSPropertyName = "EditValue";
            this.fld_ckeIsDiscount.Location = new System.Drawing.Point(804, 42);
            this.fld_ckeIsDiscount.MenuManager = this.screenToolbar;
            this.fld_ckeIsDiscount.Name = "fld_ckeIsDiscount";
            this.fld_ckeIsDiscount.Properties.Caption = "Có bao gồm chiết khấu";
            this.fld_ckeIsDiscount.Screen = null;
            this.fld_ckeIsDiscount.Size = new System.Drawing.Size(150, 20);
            this.fld_ckeIsDiscount.TabIndex = 411;
            this.fld_ckeIsDiscount.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(245, 15);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 410;
            this.bosLabel6.Text = "Nhân viên";
            // 
            // fld_lkeHREmployeeID
            // 
            this.fld_lkeHREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeHREmployeeID.BOSAllowDummy = true;
            this.fld_lkeHREmployeeID.BOSComment = null;
            this.fld_lkeHREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeHREmployeeID.BOSDataSource = "ARCustomers";
            this.fld_lkeHREmployeeID.BOSDescription = null;
            this.fld_lkeHREmployeeID.BOSError = null;
            this.fld_lkeHREmployeeID.BOSFieldGroup = null;
            this.fld_lkeHREmployeeID.BOSFieldParent = null;
            this.fld_lkeHREmployeeID.BOSFieldRelation = null;
            this.fld_lkeHREmployeeID.BOSPrivilege = null;
            this.fld_lkeHREmployeeID.BOSPropertyName = null;
            this.fld_lkeHREmployeeID.BOSSelectType = null;
            this.fld_lkeHREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeeID.CurrentDisplayText = null;
            this.fld_lkeHREmployeeID.Location = new System.Drawing.Point(346, 12);
            this.fld_lkeHREmployeeID.MenuManager = this.screenToolbar;
            this.fld_lkeHREmployeeID.Name = "fld_lkeHREmployeeID";
            this.fld_lkeHREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeeID.Properties.ColumnName = null;
            this.fld_lkeHREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Nhân viên")});
            this.fld_lkeHREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeHREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeHREmployeeID.Screen = null;
            this.fld_lkeHREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHREmployeeID.TabIndex = 409;
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
            this.bosLabel5.Location = new System.Drawing.Point(245, 41);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(85, 13);
            this.bosLabel5.TabIndex = 408;
            this.bosLabel5.Text = "Nhóm khách hàng";
            // 
            // fld_lkeARCustomerType
            // 
            this.fld_lkeARCustomerType.BOSAllowAddNew = false;
            this.fld_lkeARCustomerType.BOSAllowDummy = true;
            this.fld_lkeARCustomerType.BOSComment = null;
            this.fld_lkeARCustomerType.BOSDataMember = "ARCustomerTypeCombo";
            this.fld_lkeARCustomerType.BOSDataSource = "ARCustomers";
            this.fld_lkeARCustomerType.BOSDescription = null;
            this.fld_lkeARCustomerType.BOSError = null;
            this.fld_lkeARCustomerType.BOSFieldGroup = null;
            this.fld_lkeARCustomerType.BOSFieldParent = null;
            this.fld_lkeARCustomerType.BOSFieldRelation = null;
            this.fld_lkeARCustomerType.BOSPrivilege = null;
            this.fld_lkeARCustomerType.BOSPropertyName = null;
            this.fld_lkeARCustomerType.BOSSelectType = null;
            this.fld_lkeARCustomerType.BOSSelectTypeValue = null;
            this.fld_lkeARCustomerType.CurrentDisplayText = null;
            this.fld_lkeARCustomerType.Location = new System.Drawing.Point(346, 38);
            this.fld_lkeARCustomerType.MenuManager = this.screenToolbar;
            this.fld_lkeARCustomerType.Name = "fld_lkeARCustomerType";
            this.fld_lkeARCustomerType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCustomerType.Properties.ColumnName = null;
            this.fld_lkeARCustomerType.Screen = null;
            this.fld_lkeARCustomerType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARCustomerType.TabIndex = 407;
            // 
            // bosButton2
            // 
            this.bosButton2.BOSComment = null;
            this.bosButton2.BOSDataMember = null;
            this.bosButton2.BOSDataSource = null;
            this.bosButton2.BOSDescription = null;
            this.bosButton2.BOSError = null;
            this.bosButton2.BOSFieldGroup = null;
            this.bosButton2.BOSFieldRelation = null;
            this.bosButton2.BOSPrivilege = null;
            this.bosButton2.BOSPropertyName = null;
            this.bosButton2.Location = new System.Drawing.Point(972, 8);
            this.bosButton2.Name = "bosButton2";
            this.bosButton2.Screen = null;
            this.bosButton2.Size = new System.Drawing.Size(78, 28);
            this.bosButton2.TabIndex = 406;
            this.bosButton2.Text = "In";
            this.bosButton2.Visible = false;
            this.bosButton2.Click += new System.EventHandler(this.bosButton2_Click);
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
            this.bosLabel4.Location = new System.Drawing.Point(12, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 397;
            this.bosLabel4.Text = "Đối tượng";
            // 
            // fld_lkeARCustomerID
            // 
            this.fld_lkeARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeARCustomerID.BOSAllowDummy = true;
            this.fld_lkeARCustomerID.BOSComment = null;
            this.fld_lkeARCustomerID.BOSDataMember = "ARCustomerID";
            this.fld_lkeARCustomerID.BOSDataSource = "ARCustomers";
            this.fld_lkeARCustomerID.BOSDescription = null;
            this.fld_lkeARCustomerID.BOSError = null;
            this.fld_lkeARCustomerID.BOSFieldGroup = null;
            this.fld_lkeARCustomerID.BOSFieldParent = null;
            this.fld_lkeARCustomerID.BOSFieldRelation = null;
            this.fld_lkeARCustomerID.BOSPrivilege = null;
            this.fld_lkeARCustomerID.BOSPropertyName = null;
            this.fld_lkeARCustomerID.BOSSelectType = null;
            this.fld_lkeARCustomerID.BOSSelectTypeValue = null;
            this.fld_lkeARCustomerID.CurrentDisplayText = null;
            this.fld_lkeARCustomerID.Location = new System.Drawing.Point(73, 38);
            this.fld_lkeARCustomerID.MenuManager = this.screenToolbar;
            this.fld_lkeARCustomerID.Name = "fld_lkeARCustomerID";
            this.fld_lkeARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARCustomerID.Properties.ColumnName = null;
            this.fld_lkeARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên khách hàng")});
            this.fld_lkeARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeARCustomerID.Screen = null;
            this.fld_lkeARCustomerID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARCustomerID.TabIndex = 2;
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
            this.bosLabel1.Location = new System.Drawing.Point(12, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(21, 13);
            this.bosLabel1.TabIndex = 390;
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
            this.bosButton1.Location = new System.Drawing.Point(888, 8);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(78, 28);
            this.bosButton1.TabIndex = 8;
            this.bosButton1.Text = "Xuất excel";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click_1);
            // 
            // bosLine1
            // 
            this.bosLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.bosLabel3);
            this.bosLine1.Controls.Add(this.fld_dgcARInvoices);
            this.bosLine1.Controls.Add(this.fld_dteFromYear);
            this.bosLine1.Controls.Add(this.bosLabel2);
            this.bosLine1.Controls.Add(this.fld_dteToYear);
            this.bosLine1.Location = new System.Drawing.Point(3, 64);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(1231, 615);
            this.bosLine1.TabIndex = 377;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Chi tiết    ";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(70, 17);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(483, 27);
            this.bosLabel3.TabIndex = 35;
            this.bosLabel3.Text = "BÁO CÁO DOANH THU THEO KHÁCH HÀNG";
            // 
            // fld_dgcARInvoices
            // 
            this.fld_dgcARInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARInvoices.BOSComment = null;
            this.fld_dgcARInvoices.BOSDataMember = null;
            this.fld_dgcARInvoices.BOSDataSource = "ARInvoices";
            this.fld_dgcARInvoices.BOSDescription = null;
            this.fld_dgcARInvoices.BOSError = null;
            this.fld_dgcARInvoices.BOSFieldGroup = null;
            this.fld_dgcARInvoices.BOSFieldRelation = null;
            this.fld_dgcARInvoices.BOSGridType = null;
            this.fld_dgcARInvoices.BOSPrivilege = null;
            this.fld_dgcARInvoices.BOSPropertyName = null;
            this.fld_dgcARInvoices.CommodityType = "";
            this.fld_dgcARInvoices.Location = new System.Drawing.Point(0, 50);
            this.fld_dgcARInvoices.MenuManager = this.screenToolbar;
            this.fld_dgcARInvoices.Name = "fld_dgcARInvoices";
            this.fld_dgcARInvoices.PrintReport = false;
            this.fld_dgcARInvoices.Screen = null;
            this.fld_dgcARInvoices.Size = new System.Drawing.Size(1228, 562);
            this.fld_dgcARInvoices.TabIndex = 16;
            // 
            // fld_dteFromYear
            // 
            this.fld_dteFromYear.BOSComment = null;
            this.fld_dteFromYear.BOSDataMember = null;
            this.fld_dteFromYear.BOSDataSource = null;
            this.fld_dteFromYear.BOSDescription = null;
            this.fld_dteFromYear.BOSError = null;
            this.fld_dteFromYear.BOSFieldGroup = null;
            this.fld_dteFromYear.BOSFieldRelation = null;
            this.fld_dteFromYear.BOSPrivilege = null;
            this.fld_dteFromYear.BOSPropertyName = null;
            this.fld_dteFromYear.EditValue = null;
            this.fld_dteFromYear.Location = new System.Drawing.Point(650, 14);
            this.fld_dteFromYear.MenuManager = this.screenToolbar;
            this.fld_dteFromYear.Name = "fld_dteFromYear";
            this.fld_dteFromYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromYear.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromYear.Properties.DisplayFormat.FormatString = "yyyy";
            this.fld_dteFromYear.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteFromYear.Properties.EditFormat.FormatString = "yyyy";
            this.fld_dteFromYear.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteFromYear.Properties.MaskSettings.Set("mask", "yyyy");
            this.fld_dteFromYear.Screen = null;
            this.fld_dteFromYear.Size = new System.Drawing.Size(150, 20);
            this.fld_dteFromYear.TabIndex = 0;
            this.fld_dteFromYear.Visible = false;
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
            this.bosLabel2.Location = new System.Drawing.Point(822, 17);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(43, 13);
            this.bosLabel2.TabIndex = 392;
            this.bosLabel2.Text = "Đến năm";
            this.bosLabel2.Visible = false;
            // 
            // fld_dteToYear
            // 
            this.fld_dteToYear.BOSComment = null;
            this.fld_dteToYear.BOSDataMember = null;
            this.fld_dteToYear.BOSDataSource = null;
            this.fld_dteToYear.BOSDescription = null;
            this.fld_dteToYear.BOSError = null;
            this.fld_dteToYear.BOSFieldGroup = null;
            this.fld_dteToYear.BOSFieldRelation = null;
            this.fld_dteToYear.BOSPrivilege = null;
            this.fld_dteToYear.BOSPropertyName = null;
            this.fld_dteToYear.EditValue = null;
            this.fld_dteToYear.Location = new System.Drawing.Point(923, 14);
            this.fld_dteToYear.MenuManager = this.screenToolbar;
            this.fld_dteToYear.Name = "fld_dteToYear";
            this.fld_dteToYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToYear.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToYear.Properties.DisplayFormat.FormatString = "yyyy";
            this.fld_dteToYear.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteToYear.Properties.EditFormat.FormatString = "yyyy";
            this.fld_dteToYear.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteToYear.Properties.MaskSettings.Set("mask", "yyyy");
            this.fld_dteToYear.Screen = null;
            this.fld_dteToYear.Size = new System.Drawing.Size(150, 20);
            this.fld_dteToYear.TabIndex = 1;
            this.fld_dteToYear.Visible = false;
            // 
            // RP_RevenueByCustomer1
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 679);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("RP_RevenueByCustomer1.IconOptions.Icon")));
            this.Name = "RP_RevenueByCustomer1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "BÁO CÁO DOANH THU THEO SP, THEO KH";
            this.Load += new System.EventHandler(this.RPPTCP_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeRoundingNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tbYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeViewType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeIsDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARCustomerID.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromYear.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToYear.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToYear.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnApply;
        private BOSPanel bosPanel1;
        private BOSLine bosLine1;
        private BOSGridControl fld_dgcARInvoices;
        private BOSLabel bosLabel3;
        private BOSButton bosButton1;
        private BOSDateEdit fld_dteToYear;
        private BOSLabel bosLabel2;
        private BOSDateEdit fld_dteFromYear;
        private BOSLabel bosLabel1;
        private BOSLabel bosLabel4;
        private BOSLookupEdit fld_lkeARCustomerID;
        private BOSButton bosButton2;
        private BOSLabel bosLabel5;
        private BOSLookupEdit fld_lkeARCustomerType;
        private BOSLabel bosLabel6;
        private BOSLookupEdit fld_lkeHREmployeeID;
        private BOSCheckEdit fld_ckeIsDiscount;
        private BOSLabel bosLabel7;
        private BOSLookupEdit fld_lkeViewType;
        private BOSTextBox fld_tbYear;
        private BOSLookupEdit fld_lkeRoundingNumber;
        private BOSLabel bosLabel8;
    }
}