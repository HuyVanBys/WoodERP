namespace BOSERP.Modules.EmployeeSchedule.UI
{
    partial class guiSearchEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiSearchEmployee));
            this.fld_dgcHREmployees = new BOSERP.Modules.EmployeeSchedule.UI.HREmployee2sGridControl();
            this.fld_btnChoose = new BOSComponent.BOSButton(this.components);
            this.fld_chkSellectAll = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_btnCancel = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeHRDepartmentRooms = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHRDepartment = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHRBranch = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeHREmployeePayrollFormula = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblCTTL2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHREmployeePayrollFormulaID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnSearch = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRooms.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeePayrollFormula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeePayrollFormulaID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHREmployees
            // 
            this.fld_dgcHREmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployees.BOSComment = null;
            this.fld_dgcHREmployees.BOSDataMember = null;
            this.fld_dgcHREmployees.BOSDataSource = "HREmployees";
            this.fld_dgcHREmployees.BOSDescription = null;
            this.fld_dgcHREmployees.BOSError = null;
            this.fld_dgcHREmployees.BOSFieldGroup = null;
            this.fld_dgcHREmployees.BOSFieldRelation = null;
            this.fld_dgcHREmployees.BOSGridType = null;
            this.fld_dgcHREmployees.BOSPrivilege = null;
            this.fld_dgcHREmployees.BOSPropertyName = null;
            this.fld_dgcHREmployees.Location = new System.Drawing.Point(1, 58);
            this.fld_dgcHREmployees.MenuManager = this.screenToolbar;
            this.fld_dgcHREmployees.Name = "fld_dgcHREmployees";
            this.fld_dgcHREmployees.PrintReport = false;
            this.fld_dgcHREmployees.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHREmployees, true);
            this.fld_dgcHREmployees.Size = new System.Drawing.Size(860, 400);
            this.fld_dgcHREmployees.TabIndex = 1;
            this.fld_dgcHREmployees.Tag = "DC";
            // 
            // fld_btnChoose
            // 
            this.fld_btnChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnChoose.BOSComment = null;
            this.fld_btnChoose.BOSDataMember = null;
            this.fld_btnChoose.BOSDataSource = null;
            this.fld_btnChoose.BOSDescription = null;
            this.fld_btnChoose.BOSError = null;
            this.fld_btnChoose.BOSFieldGroup = null;
            this.fld_btnChoose.BOSFieldRelation = null;
            this.fld_btnChoose.BOSPrivilege = null;
            this.fld_btnChoose.BOSPropertyName = null;
            this.fld_btnChoose.Location = new System.Drawing.Point(684, 472);
            this.fld_btnChoose.Name = "fld_btnChoose";
            this.fld_btnChoose.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnChoose, true);
            this.fld_btnChoose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnChoose.TabIndex = 2;
            this.fld_btnChoose.Text = "Chọn";
            this.fld_btnChoose.Click += new System.EventHandler(this.fld_btnChoose_Click);
            // 
            // fld_chkSellectAll
            // 
            this.fld_chkSellectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_chkSellectAll.BOSComment = null;
            this.fld_chkSellectAll.BOSDataMember = null;
            this.fld_chkSellectAll.BOSDataSource = null;
            this.fld_chkSellectAll.BOSDescription = null;
            this.fld_chkSellectAll.BOSError = null;
            this.fld_chkSellectAll.BOSFieldGroup = null;
            this.fld_chkSellectAll.BOSFieldRelation = null;
            this.fld_chkSellectAll.BOSPrivilege = null;
            this.fld_chkSellectAll.BOSPropertyName = null;
            this.fld_chkSellectAll.Location = new System.Drawing.Point(1, 480);
            this.fld_chkSellectAll.MenuManager = this.screenToolbar;
            this.fld_chkSellectAll.Name = "fld_chkSellectAll";
            this.fld_chkSellectAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkSellectAll.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkSellectAll, true);
            this.fld_chkSellectAll.Size = new System.Drawing.Size(144, 19);
            this.fld_chkSellectAll.TabIndex = 4;
            this.fld_chkSellectAll.Tag = "DC";
            this.fld_chkSellectAll.CheckedChanged += new System.EventHandler(this.fld_chkSellectAll_CheckedChanged);
            // 
            // fld_btnCancel
            // 
            this.fld_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancel.BOSComment = null;
            this.fld_btnCancel.BOSDataMember = null;
            this.fld_btnCancel.BOSDataSource = null;
            this.fld_btnCancel.BOSDescription = null;
            this.fld_btnCancel.BOSError = null;
            this.fld_btnCancel.BOSFieldGroup = null;
            this.fld_btnCancel.BOSFieldRelation = null;
            this.fld_btnCancel.BOSPrivilege = null;
            this.fld_btnCancel.BOSPropertyName = null;
            this.fld_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnCancel.Location = new System.Drawing.Point(765, 472);
            this.fld_btnCancel.Name = "fld_btnCancel";
            this.fld_btnCancel.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnCancel, true);
            this.fld_btnCancel.Size = new System.Drawing.Size(75, 27);
            this.fld_btnCancel.TabIndex = 3;
            this.fld_btnCancel.Text = "Hủy";
            this.fld_btnCancel.Click += new System.EventHandler(this.fld_btnCancel_Click);
            // 
            // bosPanel1
            // 
            this.bosPanel1.Controls.Add(this.fld_lkeHRDepartmentRooms);
            this.bosPanel1.Controls.Add(this.fld_lkeHRDepartment);
            this.bosPanel1.Controls.Add(this.fld_lkeHRBranch);
            this.bosPanel1.Controls.Add(this.fld_lkeHREmployeePayrollFormula);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lblCTTL2);
            this.bosPanel1.Controls.Add(this.fld_lkeHREmployeePayrollFormulaID);
            this.bosPanel1.Controls.Add(this.fld_btnSearch);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.ScreenHelper.SetShowHelp(this.bosPanel1, true);
            this.bosPanel1.Size = new System.Drawing.Size(863, 61);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_lkeHRDepartmentRooms
            // 
            this.fld_lkeHRDepartmentRooms.BOSAllowAddNew = false;
            this.fld_lkeHRDepartmentRooms.BOSAllowDummy = true;
            this.fld_lkeHRDepartmentRooms.BOSComment = null;
            this.fld_lkeHRDepartmentRooms.BOSDataMember = "HRDepartmentRoomID";
            this.fld_lkeHRDepartmentRooms.BOSDataSource = "HRDepartmentRooms";
            this.fld_lkeHRDepartmentRooms.BOSDescription = null;
            this.fld_lkeHRDepartmentRooms.BOSError = null;
            this.fld_lkeHRDepartmentRooms.BOSFieldGroup = null;
            this.fld_lkeHRDepartmentRooms.BOSFieldParent = null;
            this.fld_lkeHRDepartmentRooms.BOSFieldRelation = null;
            this.fld_lkeHRDepartmentRooms.BOSPrivilege = null;
            this.fld_lkeHRDepartmentRooms.BOSPropertyName = "EditValue";
            this.fld_lkeHRDepartmentRooms.BOSSelectType = null;
            this.fld_lkeHRDepartmentRooms.BOSSelectTypeValue = null;
            this.fld_lkeHRDepartmentRooms.CurrentDisplayText = null;
            this.fld_lkeHRDepartmentRooms.Location = new System.Drawing.Point(356, 36);
            this.fld_lkeHRDepartmentRooms.Name = "fld_lkeHRDepartmentRooms";
            this.fld_lkeHRDepartmentRooms.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartmentRooms.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Phòng ban")});
            this.fld_lkeHRDepartmentRooms.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeHRDepartmentRooms.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeHRDepartmentRooms.Screen = null;
            this.fld_lkeHRDepartmentRooms.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRDepartmentRooms.TabIndex = 90;
            this.fld_lkeHRDepartmentRooms.Tag = "DC";
            // 
            // fld_lkeHRDepartment
            // 
            this.fld_lkeHRDepartment.BOSAllowAddNew = false;
            this.fld_lkeHRDepartment.BOSAllowDummy = true;
            this.fld_lkeHRDepartment.BOSComment = null;
            this.fld_lkeHRDepartment.BOSDataMember = "HRDepartmentID";
            this.fld_lkeHRDepartment.BOSDataSource = "HRDepartments";
            this.fld_lkeHRDepartment.BOSDescription = null;
            this.fld_lkeHRDepartment.BOSError = null;
            this.fld_lkeHRDepartment.BOSFieldGroup = null;
            this.fld_lkeHRDepartment.BOSFieldParent = null;
            this.fld_lkeHRDepartment.BOSFieldRelation = null;
            this.fld_lkeHRDepartment.BOSPrivilege = null;
            this.fld_lkeHRDepartment.BOSPropertyName = "EditValue";
            this.fld_lkeHRDepartment.BOSSelectType = null;
            this.fld_lkeHRDepartment.BOSSelectTypeValue = null;
            this.fld_lkeHRDepartment.CurrentDisplayText = null;
            this.fld_lkeHRDepartment.Location = new System.Drawing.Point(121, 36);
            this.fld_lkeHRDepartment.Name = "fld_lkeHRDepartment";
            this.fld_lkeHRDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRDepartment.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Bộ phận")});
            this.fld_lkeHRDepartment.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeHRDepartment.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeHRDepartment.Screen = null;
            this.fld_lkeHRDepartment.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRDepartment.TabIndex = 89;
            this.fld_lkeHRDepartment.Tag = "DC";
            // 
            // fld_lkeHRBranch
            // 
            this.fld_lkeHRBranch.BOSAllowAddNew = false;
            this.fld_lkeHRBranch.BOSAllowDummy = true;
            this.fld_lkeHRBranch.BOSComment = null;
            this.fld_lkeHRBranch.BOSDataMember = "BRBranchID";
            this.fld_lkeHRBranch.BOSDataSource = "BRBranchs";
            this.fld_lkeHRBranch.BOSDescription = null;
            this.fld_lkeHRBranch.BOSError = null;
            this.fld_lkeHRBranch.BOSFieldGroup = null;
            this.fld_lkeHRBranch.BOSFieldParent = null;
            this.fld_lkeHRBranch.BOSFieldRelation = null;
            this.fld_lkeHRBranch.BOSPrivilege = null;
            this.fld_lkeHRBranch.BOSPropertyName = "EditValue";
            this.fld_lkeHRBranch.BOSSelectType = null;
            this.fld_lkeHRBranch.BOSSelectTypeValue = null;
            this.fld_lkeHRBranch.CurrentDisplayText = null;
            this.fld_lkeHRBranch.Location = new System.Drawing.Point(356, 7);
            this.fld_lkeHRBranch.Name = "fld_lkeHRBranch";
            this.fld_lkeHRBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRBranch.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeHRBranch.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeHRBranch.Properties.ValueMember = "BRBranchID";
            this.fld_lkeHRBranch.Screen = null;
            this.fld_lkeHRBranch.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRBranch.TabIndex = 88;
            this.fld_lkeHRBranch.Tag = "DC";
            // 
            // fld_lkeHREmployeePayrollFormula
            // 
            this.fld_lkeHREmployeePayrollFormula.BOSAllowAddNew = false;
            this.fld_lkeHREmployeePayrollFormula.BOSAllowDummy = false;
            this.fld_lkeHREmployeePayrollFormula.BOSComment = null;
            this.fld_lkeHREmployeePayrollFormula.BOSDataMember = "HREmployeePayrollFormulaID";
            this.fld_lkeHREmployeePayrollFormula.BOSDataSource = "HREmployeePayrollFormulas";
            this.fld_lkeHREmployeePayrollFormula.BOSDescription = null;
            this.fld_lkeHREmployeePayrollFormula.BOSError = null;
            this.fld_lkeHREmployeePayrollFormula.BOSFieldGroup = null;
            this.fld_lkeHREmployeePayrollFormula.BOSFieldParent = null;
            this.fld_lkeHREmployeePayrollFormula.BOSFieldRelation = null;
            this.fld_lkeHREmployeePayrollFormula.BOSPrivilege = null;
            this.fld_lkeHREmployeePayrollFormula.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeePayrollFormula.BOSSelectType = null;
            this.fld_lkeHREmployeePayrollFormula.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeePayrollFormula.CurrentDisplayText = null;
            this.fld_lkeHREmployeePayrollFormula.Location = new System.Drawing.Point(121, 7);
            this.fld_lkeHREmployeePayrollFormula.MenuManager = this.screenToolbar;
            this.fld_lkeHREmployeePayrollFormula.Name = "fld_lkeHREmployeePayrollFormula";
            this.fld_lkeHREmployeePayrollFormula.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeePayrollFormula.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeePayrollFormulaName", "Công thức tính lương")});
            this.fld_lkeHREmployeePayrollFormula.Properties.DisplayMember = "HREmployeePayrollFormulaName";
            this.fld_lkeHREmployeePayrollFormula.Properties.ValueMember = "HREmployeePayrollFormulaID";
            this.fld_lkeHREmployeePayrollFormula.Screen = null;
            this.fld_lkeHREmployeePayrollFormula.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHREmployeePayrollFormula.TabIndex = 87;
            this.fld_lkeHREmployeePayrollFormula.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(302, 39);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(39, 13);
            this.bosLabel3.TabIndex = 86;
            this.bosLabel3.Text = "Bộ phận";
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
            this.bosLabel2.Location = new System.Drawing.Point(55, 39);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(51, 13);
            this.bosLabel2.TabIndex = 86;
            this.bosLabel2.Text = "Phòng ban";
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
            this.bosLabel1.Location = new System.Drawing.Point(293, 10);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 86;
            this.bosLabel1.Text = "Chi nhánh";
            // 
            // fld_lblCTTL2
            // 
            this.fld_lblCTTL2.BOSComment = null;
            this.fld_lblCTTL2.BOSDataMember = null;
            this.fld_lblCTTL2.BOSDataSource = null;
            this.fld_lblCTTL2.BOSDescription = null;
            this.fld_lblCTTL2.BOSError = null;
            this.fld_lblCTTL2.BOSFieldGroup = null;
            this.fld_lblCTTL2.BOSFieldRelation = null;
            this.fld_lblCTTL2.BOSPrivilege = null;
            this.fld_lblCTTL2.BOSPropertyName = null;
            this.fld_lblCTTL2.Location = new System.Drawing.Point(5, 10);
            this.fld_lblCTTL2.Name = "fld_lblCTTL2";
            this.fld_lblCTTL2.Screen = null;
            this.fld_lblCTTL2.Size = new System.Drawing.Size(101, 13);
            this.fld_lblCTTL2.TabIndex = 86;
            this.fld_lblCTTL2.Text = "Công thức tính lương";
            // 
            // fld_lkeHREmployeePayrollFormulaID
            // 
            this.fld_lkeHREmployeePayrollFormulaID.BOSAllowAddNew = false;
            this.fld_lkeHREmployeePayrollFormulaID.BOSAllowDummy = false;
            this.fld_lkeHREmployeePayrollFormulaID.BOSComment = null;
            this.fld_lkeHREmployeePayrollFormulaID.BOSDataMember = "HREmployeePayrollFormulaID";
            this.fld_lkeHREmployeePayrollFormulaID.BOSDataSource = "HREmployeePayrollFormulas";
            this.fld_lkeHREmployeePayrollFormulaID.BOSDescription = null;
            this.fld_lkeHREmployeePayrollFormulaID.BOSError = null;
            this.fld_lkeHREmployeePayrollFormulaID.BOSFieldGroup = null;
            this.fld_lkeHREmployeePayrollFormulaID.BOSFieldParent = null;
            this.fld_lkeHREmployeePayrollFormulaID.BOSFieldRelation = null;
            this.fld_lkeHREmployeePayrollFormulaID.BOSPrivilege = null;
            this.fld_lkeHREmployeePayrollFormulaID.BOSPropertyName = "EditValue";
            this.fld_lkeHREmployeePayrollFormulaID.BOSSelectType = null;
            this.fld_lkeHREmployeePayrollFormulaID.BOSSelectTypeValue = null;
            this.fld_lkeHREmployeePayrollFormulaID.CurrentDisplayText = null;
            this.fld_lkeHREmployeePayrollFormulaID.Location = new System.Drawing.Point(284, -27);
            this.fld_lkeHREmployeePayrollFormulaID.MenuManager = this.screenToolbar;
            this.fld_lkeHREmployeePayrollFormulaID.Name = "fld_lkeHREmployeePayrollFormulaID";
            this.fld_lkeHREmployeePayrollFormulaID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHREmployeePayrollFormulaID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeePayrollFormulaName", "Công thức tính lương")});
            this.fld_lkeHREmployeePayrollFormulaID.Properties.DisplayMember = "HREmployeePayrollFormulaName";
            this.fld_lkeHREmployeePayrollFormulaID.Properties.ValueMember = "HREmployeePayrollFormulaID";
            this.fld_lkeHREmployeePayrollFormulaID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeHREmployeePayrollFormulaID, true);
            this.fld_lkeHREmployeePayrollFormulaID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHREmployeePayrollFormulaID.TabIndex = 85;
            this.fld_lkeHREmployeePayrollFormulaID.Tag = "DC";
            // 
            // fld_btnSearch
            // 
            this.fld_btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSearch.BOSComment = null;
            this.fld_btnSearch.BOSDataMember = null;
            this.fld_btnSearch.BOSDataSource = null;
            this.fld_btnSearch.BOSDescription = null;
            this.fld_btnSearch.BOSError = null;
            this.fld_btnSearch.BOSFieldGroup = null;
            this.fld_btnSearch.BOSFieldRelation = null;
            this.fld_btnSearch.BOSPrivilege = null;
            this.fld_btnSearch.BOSPropertyName = null;
            this.fld_btnSearch.Location = new System.Drawing.Point(534, 5);
            this.fld_btnSearch.Name = "fld_btnSearch";
            this.fld_btnSearch.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSearch, true);
            this.fld_btnSearch.Size = new System.Drawing.Size(75, 27);
            this.fld_btnSearch.TabIndex = 5;
            this.fld_btnSearch.Text = "Tìm kiếm";
            this.fld_btnSearch.Click += new System.EventHandler(this.fld_btnSearch_Click);
            // 
            // guiSearchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnCancel;
            this.ClientSize = new System.Drawing.Size(863, 511);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.fld_dgcHREmployees);
            this.Controls.Add(this.fld_btnCancel);
            this.Controls.Add(this.fld_chkSellectAll);
            this.Controls.Add(this.fld_btnChoose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiSearchEmployee";
            this.ScreenHelper.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Chọn nhân viên";
            this.Load += new System.EventHandler(this.guiSearchEmployee_Load);
            this.Controls.SetChildIndex(this.fld_btnChoose, 0);
            this.Controls.SetChildIndex(this.fld_chkSellectAll, 0);
            this.Controls.SetChildIndex(this.fld_btnCancel, 0);
            this.Controls.SetChildIndex(this.fld_dgcHREmployees, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSellectAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartmentRooms.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeePayrollFormula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHREmployeePayrollFormulaID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSButton fld_btnChoose;
        private BOSComponent.BOSCheckEdit fld_chkSellectAll;
        private BOSERP.Modules.EmployeeSchedule.UI.HREmployee2sGridControl fld_dgcHREmployees;
        private BOSComponent.BOSButton fld_btnCancel;
        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private BOSComponent.BOSButton fld_btnSearch;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeePayrollFormulaID;
        private BOSComponent.BOSLabel fld_lblCTTL2;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartment;
        private BOSComponent.BOSLookupEdit fld_lkeHRBranch;
        private BOSComponent.BOSLookupEdit fld_lkeHREmployeePayrollFormula;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeHRDepartmentRooms;
        private BOSComponent.BOSLabel bosLabel3;
    }
}