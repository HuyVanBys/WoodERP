namespace BOSERP.Modules.HRArrangementShift
{
    partial class guiChooseArrangementShift
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_chkSelectedAll = new BOSComponent.BOSCheckEdit(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgcHREmployeeArrangementShiftsGridControl2 = new BOSERP.Modules.HRArrangementShift.HREmployeeArrangementShiftsGridControl2();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeHRWorkingShiftID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectedAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeArrangementShiftsGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRWorkingShiftID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_btnClose
            // 
            this.fld_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnClose.BOSComment = null;
            this.fld_btnClose.BOSDataMember = null;
            this.fld_btnClose.BOSDataSource = null;
            this.fld_btnClose.BOSDescription = null;
            this.fld_btnClose.BOSError = null;
            this.fld_btnClose.BOSFieldGroup = null;
            this.fld_btnClose.BOSFieldRelation = null;
            this.fld_btnClose.BOSPrivilege = null;
            this.fld_btnClose.BOSPropertyName = null;
            this.fld_btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnClose.Location = new System.Drawing.Point(667, 444);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 6;
            this.fld_btnClose.Text = "Hủy";
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(578, 444);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 5;
            this.fld_btnApply.Text = "Đồng ý";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_chkSelectedAll
            // 
            this.fld_chkSelectedAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_chkSelectedAll.BOSComment = null;
            this.fld_chkSelectedAll.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_chkSelectedAll.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_chkSelectedAll.BOSDescription = null;
            this.fld_chkSelectedAll.BOSError = null;
            this.fld_chkSelectedAll.BOSFieldGroup = null;
            this.fld_chkSelectedAll.BOSFieldRelation = null;
            this.fld_chkSelectedAll.BOSPrivilege = null;
            this.fld_chkSelectedAll.BOSPropertyName = "EditValue";
            this.fld_chkSelectedAll.Location = new System.Drawing.Point(12, 442);
            this.fld_chkSelectedAll.MenuManager = this.screenToolbar;
            this.fld_chkSelectedAll.Name = "fld_chkSelectedAll";
            this.fld_chkSelectedAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkSelectedAll.Screen = null;
            this.fld_chkSelectedAll.Size = new System.Drawing.Size(118, 19);
            this.fld_chkSelectedAll.TabIndex = 4;
            this.fld_chkSelectedAll.Tag = "DC";
            this.fld_chkSelectedAll.CheckedChanged += new System.EventHandler(this.fld_chkSelectedAll_CheckedChanged);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcHREmployeeArrangementShiftsGridControl2;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_dgcHREmployeeArrangementShiftsGridControl2
            // 
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.AllowDrop = true;
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.BOSDataSource = "HREmployeeArrangementShifts";
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.BOSDescription = null;
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.BOSError = null;
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.BOSGridType = null;
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.CommodityType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.Location = new System.Drawing.Point(4, 38);
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.MainView = this.gridView1;
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.Name = "fld_dgcHREmployeeArrangementShiftsGridControl2";
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.PrintReport = false;
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.Screen = null;
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.Size = new System.Drawing.Size(755, 398);
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.TabIndex = 3;
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.Tag = "DC";
            this.fld_dgcHREmployeeArrangementShiftsGridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.bosLabel1.Location = new System.Drawing.Point(536, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(54, 13);
            this.bosLabel1.TabIndex = 145;
            this.bosLabel1.Text = "Ca làm việc";
            // 
            // fld_lkeHRWorkingShiftID
            // 
            this.fld_lkeHRWorkingShiftID.BOSAllowAddNew = false;
            this.fld_lkeHRWorkingShiftID.BOSAllowDummy = true;
            this.fld_lkeHRWorkingShiftID.BOSComment = null;
            this.fld_lkeHRWorkingShiftID.BOSDataMember = "HRWorkingShiftID";
            this.fld_lkeHRWorkingShiftID.BOSDataSource = "HRWorkingShifts";
            this.fld_lkeHRWorkingShiftID.BOSDescription = null;
            this.fld_lkeHRWorkingShiftID.BOSError = null;
            this.fld_lkeHRWorkingShiftID.BOSFieldGroup = null;
            this.fld_lkeHRWorkingShiftID.BOSFieldParent = null;
            this.fld_lkeHRWorkingShiftID.BOSFieldRelation = null;
            this.fld_lkeHRWorkingShiftID.BOSPrivilege = null;
            this.fld_lkeHRWorkingShiftID.BOSPropertyName = "EditValue";
            this.fld_lkeHRWorkingShiftID.BOSSelectType = null;
            this.fld_lkeHRWorkingShiftID.BOSSelectTypeValue = null;
            this.fld_lkeHRWorkingShiftID.CurrentDisplayText = null;
            this.fld_lkeHRWorkingShiftID.Location = new System.Drawing.Point(604, 12);
            this.fld_lkeHRWorkingShiftID.Name = "fld_lkeHRWorkingShiftID";
            this.fld_lkeHRWorkingShiftID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRWorkingShiftID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRWorkingShiftID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRWorkingShiftID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRWorkingShiftID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRWorkingShiftID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRWorkingShiftName", "Ca làm việc")});
            this.fld_lkeHRWorkingShiftID.Properties.DisplayMember = "HRWorkingShiftName";
            this.fld_lkeHRWorkingShiftID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRWorkingShiftID.Properties.PopupWidth = 40;
            this.fld_lkeHRWorkingShiftID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRWorkingShiftID.Properties.ValueMember = "HRWorkingShiftID";
            this.fld_lkeHRWorkingShiftID.Screen = null;
            this.fld_lkeHRWorkingShiftID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRWorkingShiftID.TabIndex = 2;
            this.fld_lkeHRWorkingShiftID.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeHRWorkingShiftID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeHRWorkingShiftID_QueryPopUp);
            // 
            // fld_dteToDate
            // 
            this.fld_dteToDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteToDate.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteToDate.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteToDate.BOSDescription = null;
            this.fld_dteToDate.BOSError = null;
            this.fld_dteToDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteToDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteToDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteToDate.BOSPropertyName = "EditValue";
            this.fld_dteToDate.EditValue = null;
            this.fld_dteToDate.Location = new System.Drawing.Point(338, 12);
            this.fld_dteToDate.Name = "fld_dteToDate";
            this.fld_dteToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.fld_dteToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.fld_dteToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.fld_dteToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToDate.Screen = null;
            this.fld_dteToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteToDate.TabIndex = 1;
            this.fld_dteToDate.Tag = "DC";
            // 
            // fld_dteFromDate
            // 
            this.fld_dteFromDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteFromDate.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteFromDate.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteFromDate.BOSDescription = null;
            this.fld_dteFromDate.BOSError = null;
            this.fld_dteFromDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteFromDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteFromDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteFromDate.BOSPropertyName = "EditValue";
            this.fld_dteFromDate.EditValue = null;
            this.fld_dteFromDate.Location = new System.Drawing.Point(84, 12);
            this.fld_dteFromDate.Name = "fld_dteFromDate";
            this.fld_dteFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.fld_dteFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteFromDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.fld_dteFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteFromDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.fld_dteFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromDate.Screen = null;
            this.fld_dteFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteFromDate.TabIndex = 0;
            this.fld_dteFromDate.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.Location = new System.Drawing.Point(271, 15);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(47, 13);
            this.bosLabel6.TabIndex = 146;
            this.bosLabel6.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.Text = "Đến ngày";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.Location = new System.Drawing.Point(23, 15);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 147;
            this.bosLabel5.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.Text = "Từ ngày";
            // 
            // guiChooseArrangementShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(762, 483);
            this.ControlBox = true;
            this.Controls.Add(this.fld_dteToDate);
            this.Controls.Add(this.fld_dteFromDate);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeHRWorkingShiftID);
            this.Controls.Add(this.fld_dgcHREmployeeArrangementShiftsGridControl2);
            this.Controls.Add(this.fld_chkSelectedAll);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Name = "guiChooseArrangementShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xếp ca nhanh";
            this.Load += new System.EventHandler(this.guiChooseArrangementShift_Load_1);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_chkSelectedAll, 0);
            this.Controls.SetChildIndex(this.fld_dgcHREmployeeArrangementShiftsGridControl2, 0);
            this.Controls.SetChildIndex(this.fld_lkeHRWorkingShiftID, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.fld_dteFromDate, 0);
            this.Controls.SetChildIndex(this.fld_dteToDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkSelectedAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeArrangementShiftsGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRWorkingShiftID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSCheckEdit fld_chkSelectedAll;
        private HREmployeeArrangementShiftsGridControl2 fld_dgcHREmployeeArrangementShiftsGridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeHRWorkingShiftID;
        private BOSComponent.BOSDateEdit fld_dteToDate;
        private BOSComponent.BOSDateEdit fld_dteFromDate;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel5;
    }
}