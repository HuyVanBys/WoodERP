namespace BOSERP.Modules.WorkProduct
{
    partial class guiAddNewTask<T>
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
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_txtICTaskEstimatedTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICTaskTotalEstimatedDays = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICMeasureUnitID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtICTaskTotalEstimatedHours = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel46 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRDepartmentRoomID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_PMProjectTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICTaskNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICTaskName = new BOSComponent.BOSTextBox(this.components);
            this.fld_medICTaskInfo = new BOSComponent.BOSMemoEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTaskEstimatedTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTaskTotalEstimatedDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICMeasureUnitID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTaskTotalEstimatedHours.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTaskNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTaskName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICTaskInfo.Properties)).BeginInit();
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
            this.fld_btnClose.Location = new System.Drawing.Point(468, 184);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 5;
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
            this.fld_btnApply.Location = new System.Drawing.Point(368, 184);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(83, 27);
            this.fld_btnApply.TabIndex = 4;
            this.fld_btnApply.Text = "Thêm";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_txtICTaskEstimatedTotalCost
            // 
            this.fld_txtICTaskEstimatedTotalCost.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskEstimatedTotalCost.BOSDataMember = "ICTaskEstimatedTotalCost";
            this.fld_txtICTaskEstimatedTotalCost.BOSDataSource = "ICTasks";
            this.fld_txtICTaskEstimatedTotalCost.BOSDescription = null;
            this.fld_txtICTaskEstimatedTotalCost.BOSError = null;
            this.fld_txtICTaskEstimatedTotalCost.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskEstimatedTotalCost.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskEstimatedTotalCost.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskEstimatedTotalCost.BOSPropertyName = "EditValue";
            this.fld_txtICTaskEstimatedTotalCost.EditValue = "0.00";
            this.fld_txtICTaskEstimatedTotalCost.Location = new System.Drawing.Point(352, 153);
            this.fld_txtICTaskEstimatedTotalCost.Name = "fld_txtICTaskEstimatedTotalCost";
            this.fld_txtICTaskEstimatedTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICTaskEstimatedTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICTaskEstimatedTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICTaskEstimatedTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICTaskEstimatedTotalCost.Properties.Mask.EditMask = "n";
            this.fld_txtICTaskEstimatedTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICTaskEstimatedTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICTaskEstimatedTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICTaskEstimatedTotalCost.Screen = null;
            this.fld_txtICTaskEstimatedTotalCost.Size = new System.Drawing.Size(99, 20);
            this.fld_txtICTaskEstimatedTotalCost.TabIndex = 361;
            this.fld_txtICTaskEstimatedTotalCost.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(277, 156);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(57, 13);
            this.bosLabel5.TabIndex = 369;
            this.bosLabel5.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel5.Text = "Tổng chi phí";
            // 
            // fld_txtICTaskTotalEstimatedDays
            // 
            this.fld_txtICTaskTotalEstimatedDays.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskTotalEstimatedDays.BOSDataMember = "ICTaskTotalEstimatedDays";
            this.fld_txtICTaskTotalEstimatedDays.BOSDataSource = "ICTasks";
            this.fld_txtICTaskTotalEstimatedDays.BOSDescription = null;
            this.fld_txtICTaskTotalEstimatedDays.BOSError = null;
            this.fld_txtICTaskTotalEstimatedDays.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskTotalEstimatedDays.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskTotalEstimatedDays.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskTotalEstimatedDays.BOSPropertyName = "EditValue";
            this.fld_txtICTaskTotalEstimatedDays.EditValue = "0.00";
            this.fld_txtICTaskTotalEstimatedDays.Location = new System.Drawing.Point(192, 153);
            this.fld_txtICTaskTotalEstimatedDays.Name = "fld_txtICTaskTotalEstimatedDays";
            this.fld_txtICTaskTotalEstimatedDays.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICTaskTotalEstimatedDays.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICTaskTotalEstimatedDays.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICTaskTotalEstimatedDays.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICTaskTotalEstimatedDays.Properties.Mask.EditMask = "n";
            this.fld_txtICTaskTotalEstimatedDays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICTaskTotalEstimatedDays.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICTaskTotalEstimatedDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICTaskTotalEstimatedDays.Screen = null;
            this.fld_txtICTaskTotalEstimatedDays.Size = new System.Drawing.Size(70, 20);
            this.fld_txtICTaskTotalEstimatedDays.TabIndex = 360;
            this.fld_txtICTaskTotalEstimatedDays.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(139, 156);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(39, 13);
            this.bosLabel4.TabIndex = 368;
            this.bosLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel4.Text = "Số ngày";
            // 
            // fld_lblLabel16
            // 
            this.fld_lblLabel16.BOSComment = null;
            this.fld_lblLabel16.BOSDataMember = null;
            this.fld_lblLabel16.BOSDataSource = null;
            this.fld_lblLabel16.BOSDescription = null;
            this.fld_lblLabel16.BOSError = null;
            this.fld_lblLabel16.BOSFieldGroup = null;
            this.fld_lblLabel16.BOSFieldRelation = null;
            this.fld_lblLabel16.BOSPrivilege = null;
            this.fld_lblLabel16.BOSPropertyName = null;
            this.fld_lblLabel16.Location = new System.Drawing.Point(277, 8);
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel16, true);
            this.fld_lblLabel16.Size = new System.Drawing.Size(52, 13);
            this.fld_lblLabel16.TabIndex = 367;
            this.fld_lblLabel16.Text = "Đơn vị tính";
            // 
            // fld_lkeFK_ICMeasureUnitID
            // 
            this.fld_lkeFK_ICMeasureUnitID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICMeasureUnitID.BOSAllowDummy = false;
            this.fld_lkeFK_ICMeasureUnitID.BOSComment = null;
            this.fld_lkeFK_ICMeasureUnitID.BOSDataMember = "FK_ICMeasureUnitID";
            this.fld_lkeFK_ICMeasureUnitID.BOSDataSource = "ICTasks";
            this.fld_lkeFK_ICMeasureUnitID.BOSDescription = null;
            this.fld_lkeFK_ICMeasureUnitID.BOSError = null;
            this.fld_lkeFK_ICMeasureUnitID.BOSFieldGroup = null;
            this.fld_lkeFK_ICMeasureUnitID.BOSFieldParent = null;
            this.fld_lkeFK_ICMeasureUnitID.BOSFieldRelation = null;
            this.fld_lkeFK_ICMeasureUnitID.BOSPrivilege = null;
            this.fld_lkeFK_ICMeasureUnitID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICMeasureUnitID.BOSSelectType = null;
            this.fld_lkeFK_ICMeasureUnitID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICMeasureUnitID.CurrentDisplayText = null;
            this.fld_lkeFK_ICMeasureUnitID.Location = new System.Drawing.Point(352, 5);
            this.fld_lkeFK_ICMeasureUnitID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ICMeasureUnitID.Name = "fld_lkeFK_ICMeasureUnitID";
            this.fld_lkeFK_ICMeasureUnitID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICMeasureUnitID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICMeasureUnitName", "Tên đơn vị")});
            this.fld_lkeFK_ICMeasureUnitID.Properties.DisplayMember = "ICMeasureUnitName";
            this.fld_lkeFK_ICMeasureUnitID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_ICMeasureUnitID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICMeasureUnitID.Properties.ValueMember = "ICMeasureUnitID";
            this.fld_lkeFK_ICMeasureUnitID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICMeasureUnitID, true);
            this.fld_lkeFK_ICMeasureUnitID.Size = new System.Drawing.Size(198, 20);
            this.fld_lkeFK_ICMeasureUnitID.TabIndex = 349;
            this.fld_lkeFK_ICMeasureUnitID.Tag = "DC";
            // 
            // fld_txtICTaskTotalEstimatedHours
            // 
            this.fld_txtICTaskTotalEstimatedHours.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskTotalEstimatedHours.BOSDataMember = "ICTaskTotalEstimatedHours";
            this.fld_txtICTaskTotalEstimatedHours.BOSDataSource = "ICTasks";
            this.fld_txtICTaskTotalEstimatedHours.BOSDescription = null;
            this.fld_txtICTaskTotalEstimatedHours.BOSError = null;
            this.fld_txtICTaskTotalEstimatedHours.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskTotalEstimatedHours.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskTotalEstimatedHours.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskTotalEstimatedHours.BOSPropertyName = "EditValue";
            this.fld_txtICTaskTotalEstimatedHours.EditValue = "0.00";
            this.fld_txtICTaskTotalEstimatedHours.Location = new System.Drawing.Point(63, 153);
            this.fld_txtICTaskTotalEstimatedHours.Name = "fld_txtICTaskTotalEstimatedHours";
            this.fld_txtICTaskTotalEstimatedHours.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICTaskTotalEstimatedHours.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICTaskTotalEstimatedHours.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICTaskTotalEstimatedHours.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICTaskTotalEstimatedHours.Properties.Mask.EditMask = "n";
            this.fld_txtICTaskTotalEstimatedHours.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtICTaskTotalEstimatedHours.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICTaskTotalEstimatedHours.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICTaskTotalEstimatedHours.Screen = null;
            this.fld_txtICTaskTotalEstimatedHours.Size = new System.Drawing.Size(70, 20);
            this.fld_txtICTaskTotalEstimatedHours.TabIndex = 358;
            this.fld_txtICTaskTotalEstimatedHours.Tag = "DC";
            // 
            // fld_lblLabel46
            // 
            this.fld_lblLabel46.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel46.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel46.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel46.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel46.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel46.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel46.BOSDescription = null;
            this.fld_lblLabel46.BOSError = null;
            this.fld_lblLabel46.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel46.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel46.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel46.BOSPropertyName = null;
            this.fld_lblLabel46.Location = new System.Drawing.Point(6, 156);
            this.fld_lblLabel46.Name = "fld_lblLabel46";
            this.fld_lblLabel46.Screen = null;
            this.fld_lblLabel46.Size = new System.Drawing.Size(29, 13);
            this.fld_lblLabel46.TabIndex = 366;
            this.fld_lblLabel46.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel46.Text = "Số giờ";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(6, 86);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(39, 13);
            this.bosLabel3.TabIndex = 365;
            this.bosLabel3.Text = "Bộ phận";
            // 
            // fld_lkeFK_HRDepartmentRoomID
            // 
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentRoomID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDataSource = "ICTasks";
            this.fld_lkeFK_HRDepartmentRoomID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HRDepartmentRoomID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomID.Location = new System.Drawing.Point(63, 83);
            this.fld_lkeFK_HRDepartmentRoomID.Name = "fld_lkeFK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận")});
            this.fld_lkeFK_HRDepartmentRoomID.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomID.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomID, true);
            this.fld_lkeFK_HRDepartmentRoomID.Size = new System.Drawing.Size(198, 20);
            this.fld_lkeFK_HRDepartmentRoomID.TabIndex = 354;
            this.fld_lkeFK_HRDepartmentRoomID.Tag = "DC";
            // 
            // fld_lkeFK_HRDepartmentID
            // 
            this.fld_lkeFK_HRDepartmentID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentID.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentID.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.BOSDataSource = "ICTasks";
            this.fld_lkeFK_HRDepartmentID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentID.BOSError = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HRDepartmentID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentID.Location = new System.Drawing.Point(352, 83);
            this.fld_lkeFK_HRDepartmentID.Name = "fld_lkeFK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentNo", "Mã phòng ban", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Tên phòng ban")});
            this.fld_lkeFK_HRDepartmentID.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HRDepartmentID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentID.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentID, true);
            this.fld_lkeFK_HRDepartmentID.Size = new System.Drawing.Size(199, 20);
            this.fld_lkeFK_HRDepartmentID.TabIndex = 353;
            this.fld_lkeFK_HRDepartmentID.Tag = "DC";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = null;
            this.fld_lblLabel11.BOSDataMember = null;
            this.fld_lblLabel11.BOSDataSource = null;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = null;
            this.fld_lblLabel11.BOSFieldRelation = null;
            this.fld_lblLabel11.BOSPrivilege = null;
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(277, 86);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel11, true);
            this.fld_lblLabel11.Size = new System.Drawing.Size(51, 13);
            this.fld_lblLabel11.TabIndex = 364;
            this.fld_lblLabel11.Text = "Phòng ban";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ICTasks";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(352, 57);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.String1, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, true);
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(198, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 352;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(277, 60);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, true);
            this.bosLabel2.Size = new System.Drawing.Size(49, 13);
            this.bosLabel2.TabIndex = 363;
            this.bosLabel2.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.Text = "Nhân viên";
            // 
            // fld_lkeFK_PMProjectTypeID
            // 
            this.fld_lkeFK_PMProjectTypeID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectTypeID.BOSAllowDummy = true;
            this.fld_lkeFK_PMProjectTypeID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID.BOSDataMember = "FK_PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.BOSDataSource = "ICTasks";
            this.fld_lkeFK_PMProjectTypeID.BOSDescription = null;
            this.fld_lkeFK_PMProjectTypeID.BOSError = null;
            this.fld_lkeFK_PMProjectTypeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMProjectTypeID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID.CurrentDisplayText = null;
            this.fld_lkeFK_PMProjectTypeID.Location = new System.Drawing.Point(63, 57);
            this.fld_lkeFK_PMProjectTypeID.Name = "fld_lkeFK_PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMProjectTypeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMProjectTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMProjectTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectTypeNo", "Mã loại dự án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectTypeName", 300, "Tên Loại dự án")});
            this.fld_lkeFK_PMProjectTypeID.Properties.DisplayMember = "PMProjectTypeName";
            this.fld_lkeFK_PMProjectTypeID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_PMProjectTypeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMProjectTypeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMProjectTypeID.Properties.ValueMember = "PMProjectTypeID";
            this.fld_lkeFK_PMProjectTypeID.Screen = null;
            this.fld_lkeFK_PMProjectTypeID.Size = new System.Drawing.Size(199, 20);
            this.fld_lkeFK_PMProjectTypeID.TabIndex = 351;
            this.fld_lkeFK_PMProjectTypeID.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(5, 60);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(50, 13);
            this.bosLabel1.TabIndex = 362;
            this.bosLabel1.Tag = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel1.Text = "Loại dự án";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.BOSPropertyName = null;
            this.fld_lblLabel2.Location = new System.Drawing.Point(6, 8);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(37, 13);
            this.fld_lblLabel2.TabIndex = 355;
            this.fld_lblLabel2.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel2.Text = "Mã task";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.BOSPropertyName = null;
            this.fld_lblLabel3.Location = new System.Drawing.Point(6, 34);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(41, 13);
            this.fld_lblLabel3.TabIndex = 356;
            this.fld_lblLabel3.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel3.Text = "Tên task";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(6, 112);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel4.TabIndex = 359;
            this.fld_lblLabel4.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel4.Text = "Mô tả";
            // 
            // fld_txtICTaskNo
            // 
            this.fld_txtICTaskNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskNo.BOSDataMember = "ICTaskNo";
            this.fld_txtICTaskNo.BOSDataSource = "ICTasks";
            this.fld_txtICTaskNo.BOSDescription = null;
            this.fld_txtICTaskNo.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskNo.BOSPropertyName = "Text";
            this.fld_txtICTaskNo.Location = new System.Drawing.Point(63, 5);
            this.fld_txtICTaskNo.Name = "fld_txtICTaskNo";
            this.fld_txtICTaskNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICTaskNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICTaskNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICTaskNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICTaskNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICTaskNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICTaskNo.Screen = null;
            this.fld_txtICTaskNo.Size = new System.Drawing.Size(199, 20);
            this.fld_txtICTaskNo.TabIndex = 348;
            this.fld_txtICTaskNo.Tag = "DC";
            // 
            // fld_txtICTaskName
            // 
            this.fld_txtICTaskName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskName.BOSDataMember = "ICTaskName";
            this.fld_txtICTaskName.BOSDataSource = "ICTasks";
            this.fld_txtICTaskName.BOSDescription = null;
            this.fld_txtICTaskName.BOSError = "Tên nhóm công việc không thể rỗng";
            this.fld_txtICTaskName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtICTaskName.BOSPropertyName = "Text";
            this.fld_txtICTaskName.Location = new System.Drawing.Point(63, 31);
            this.fld_txtICTaskName.Name = "fld_txtICTaskName";
            this.fld_txtICTaskName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICTaskName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICTaskName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICTaskName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICTaskName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICTaskName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICTaskName.Screen = null;
            this.fld_txtICTaskName.Size = new System.Drawing.Size(488, 20);
            this.fld_txtICTaskName.TabIndex = 350;
            this.fld_txtICTaskName.Tag = "DC";
            // 
            // fld_medICTaskInfo
            // 
            this.fld_medICTaskInfo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_medICTaskInfo.BOSDataMember = "ICTaskInfo";
            this.fld_medICTaskInfo.BOSDataSource = "ICTasks";
            this.fld_medICTaskInfo.BOSDescription = null;
            this.fld_medICTaskInfo.BOSError = global::Localization.ReportLocalizedResources.String1;
            this.fld_medICTaskInfo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_medICTaskInfo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_medICTaskInfo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_medICTaskInfo.BOSPropertyName = "Text";
            this.fld_medICTaskInfo.Location = new System.Drawing.Point(63, 109);
            this.fld_medICTaskInfo.Name = "fld_medICTaskInfo";
            this.fld_medICTaskInfo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICTaskInfo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICTaskInfo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICTaskInfo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICTaskInfo.Screen = null;
            this.fld_medICTaskInfo.Size = new System.Drawing.Size(488, 38);
            this.fld_medICTaskInfo.TabIndex = 357;
            this.fld_medICTaskInfo.Tag = "DC";
            // 
            // guiAddNewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.fld_btnClose;
            this.ClientSize = new System.Drawing.Size(555, 223);
            this.ControlBox = true;
            this.Controls.Add(this.fld_txtICTaskEstimatedTotalCost);
            this.Controls.Add(this.bosLabel5);
            this.Controls.Add(this.fld_txtICTaskTotalEstimatedDays);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lblLabel16);
            this.Controls.Add(this.fld_lkeFK_ICMeasureUnitID);
            this.Controls.Add(this.fld_txtICTaskTotalEstimatedHours);
            this.Controls.Add(this.fld_lblLabel46);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID);
            this.Controls.Add(this.fld_lkeFK_HRDepartmentID);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_PMProjectTypeID);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lblLabel2);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_txtICTaskNo);
            this.Controls.Add(this.fld_txtICTaskName);
            this.Controls.Add(this.fld_medICTaskInfo);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_btnApply);
            this.Name = "guiAddNewTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm mới task";
            this.Load += new System.EventHandler(this.guiAddPhase_Load);
            this.Controls.SetChildIndex(this.fld_btnApply, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_medICTaskInfo, 0);
            this.Controls.SetChildIndex(this.fld_txtICTaskName, 0);
            this.Controls.SetChildIndex(this.fld_txtICTaskNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel2, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_PMProjectTypeID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HRDepartmentID, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HRDepartmentRoomID, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel46, 0);
            this.Controls.SetChildIndex(this.fld_txtICTaskTotalEstimatedHours, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ICMeasureUnitID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel16, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.fld_txtICTaskTotalEstimatedDays, 0);
            this.Controls.SetChildIndex(this.bosLabel5, 0);
            this.Controls.SetChildIndex(this.fld_txtICTaskEstimatedTotalCost, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTaskEstimatedTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTaskTotalEstimatedDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICMeasureUnitID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTaskTotalEstimatedHours.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTaskNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICTaskName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICTaskInfo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSTextBox fld_txtICTaskEstimatedTotalCost;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtICTaskTotalEstimatedDays;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel fld_lblLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICMeasureUnitID;
        private BOSComponent.BOSTextBox fld_txtICTaskTotalEstimatedHours;
        private BOSComponent.BOSLabel fld_lblLabel46;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectTypeID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSTextBox fld_txtICTaskNo;
        private BOSComponent.BOSTextBox fld_txtICTaskName;
        private BOSComponent.BOSMemoEdit fld_medICTaskInfo;
    }
}