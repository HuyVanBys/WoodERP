using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRArrangementShift.UI
{
	/// <summary>
	/// Summary description for DMAGS100
	/// </summary>
	partial class DMAGS100
    {
		private BOSComponent.BOSTextBox fld_txtHRArrangementShiftNo;
        private BOSComponent.BOSTextBox fld_txtHRArrangementShiftName;
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private BOSComponent.BOSButton fld_btnAddEmployee;
        private HREmployeeArrangementShiftsGridControl fld_dgcHREmployeeArrangementShifts;


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
            this.fld_txtHRArrangementShiftNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRArrangementShiftName = new BOSComponent.BOSTextBox(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREmployeeArrangementShifts = new BOSERP.Modules.HRArrangementShift.HREmployeeArrangementShiftsGridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.bosMemoEdit1 = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dteHRArrangementShiftToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHRArrangementShiftFormDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteHRTimeSheetEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRArrangementShiftNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRArrangementShiftName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeArrangementShifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRArrangementShiftToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRArrangementShiftToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRArrangementShiftFormDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRArrangementShiftFormDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRTimeSheetEmployeePicture.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHRArrangementShiftNo
            // 
            this.fld_txtHRArrangementShiftNo.BOSComment = string.Empty;
            this.fld_txtHRArrangementShiftNo.BOSDataMember = "HRArrangementShiftNo";
            this.fld_txtHRArrangementShiftNo.BOSDataSource = "HRArrangementShifts";
            this.fld_txtHRArrangementShiftNo.BOSDescription = null;
            this.fld_txtHRArrangementShiftNo.BOSError = null;
            this.fld_txtHRArrangementShiftNo.BOSFieldGroup = string.Empty;
            this.fld_txtHRArrangementShiftNo.BOSFieldRelation = string.Empty;
            this.fld_txtHRArrangementShiftNo.BOSPrivilege = string.Empty;
            this.fld_txtHRArrangementShiftNo.BOSPropertyName = "Text";
            this.fld_txtHRArrangementShiftNo.EditValue = string.Empty;
            this.fld_txtHRArrangementShiftNo.Location = new System.Drawing.Point(203, 9);
            this.fld_txtHRArrangementShiftNo.Name = "fld_txtHRArrangementShiftNo";
            this.fld_txtHRArrangementShiftNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRArrangementShiftNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRArrangementShiftNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRArrangementShiftNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRArrangementShiftNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRArrangementShiftNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRArrangementShiftNo.Screen = null;
            this.fld_txtHRArrangementShiftNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRArrangementShiftNo.TabIndex = 0;
            this.fld_txtHRArrangementShiftNo.Tag = "DC";
            // 
            // fld_txtHRArrangementShiftName
            // 
            this.fld_txtHRArrangementShiftName.BOSComment = string.Empty;
            this.fld_txtHRArrangementShiftName.BOSDataMember = "HRArrangementShiftName";
            this.fld_txtHRArrangementShiftName.BOSDataSource = "HRArrangementShifts";
            this.fld_txtHRArrangementShiftName.BOSDescription = null;
            this.fld_txtHRArrangementShiftName.BOSError = null;
            this.fld_txtHRArrangementShiftName.BOSFieldGroup = string.Empty;
            this.fld_txtHRArrangementShiftName.BOSFieldRelation = string.Empty;
            this.fld_txtHRArrangementShiftName.BOSPrivilege = string.Empty;
            this.fld_txtHRArrangementShiftName.BOSPropertyName = "Text";
            this.fld_txtHRArrangementShiftName.EditValue = string.Empty;
            this.fld_txtHRArrangementShiftName.Location = new System.Drawing.Point(519, 9);
            this.fld_txtHRArrangementShiftName.Name = "fld_txtHRArrangementShiftName";
            this.fld_txtHRArrangementShiftName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRArrangementShiftName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRArrangementShiftName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRArrangementShiftName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRArrangementShiftName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRArrangementShiftName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRArrangementShiftName.Screen = null;
            this.fld_txtHRArrangementShiftName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRArrangementShiftName.TabIndex = 2;
            this.fld_txtHRArrangementShiftName.Tag = "DC";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = string.Empty;
            this.fld_grcGroupControl1.BOSDataMember = string.Empty;
            this.fld_grcGroupControl1.BOSDataSource = string.Empty;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = string.Empty;
            this.fld_grcGroupControl1.BOSFieldRelation = string.Empty;
            this.fld_grcGroupControl1.BOSPrivilege = string.Empty;
            this.fld_grcGroupControl1.BOSPropertyName = string.Empty;
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHREmployeeArrangementShifts);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(6, 122);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(965, 586);
            this.fld_grcGroupControl1.TabIndex = 13;
            this.fld_grcGroupControl1.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl1.Text = "Thông tin chi tiết";
            // 
            // fld_dgcHREmployeeArrangementShifts
            // 
            this.fld_dgcHREmployeeArrangementShifts.AllowDrop = true;
            this.fld_dgcHREmployeeArrangementShifts.BOSComment = string.Empty;
            this.fld_dgcHREmployeeArrangementShifts.BOSDataMember = string.Empty;
            this.fld_dgcHREmployeeArrangementShifts.BOSDataSource = "HREmployeeArrangementShifts";
            this.fld_dgcHREmployeeArrangementShifts.BOSDescription = null;
            this.fld_dgcHREmployeeArrangementShifts.BOSError = null;
            this.fld_dgcHREmployeeArrangementShifts.BOSFieldGroup = string.Empty;
            this.fld_dgcHREmployeeArrangementShifts.BOSFieldRelation = string.Empty;
            this.fld_dgcHREmployeeArrangementShifts.BOSGridType = null;
            this.fld_dgcHREmployeeArrangementShifts.BOSPrivilege = string.Empty;
            this.fld_dgcHREmployeeArrangementShifts.BOSPropertyName = string.Empty;
            this.fld_dgcHREmployeeArrangementShifts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHREmployeeArrangementShifts.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeeArrangementShifts.GridViewMain = null;
            this.fld_dgcHREmployeeArrangementShifts.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcHREmployeeArrangementShifts.Name = "fld_dgcHREmployeeArrangementShifts";
            this.fld_dgcHREmployeeArrangementShifts.PrintReport = false;
            this.fld_dgcHREmployeeArrangementShifts.RowHandle = 0;
            this.fld_dgcHREmployeeArrangementShifts.Screen = null;
            this.fld_dgcHREmployeeArrangementShifts.Size = new System.Drawing.Size(961, 562);
            this.fld_dgcHREmployeeArrangementShifts.TabIndex = 0;
            this.fld_dgcHREmployeeArrangementShifts.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcHREmployeeArrangementShifts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.GridControl = this.fld_dgcHREmployeeArrangementShifts;
            this.bandedGridView1.Name = "bandedGridView1";
            // 
            // fld_btnAddEmployee
            // 
            this.fld_btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnAddEmployee.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddEmployee.Appearance.Options.UseForeColor = true;
            this.fld_btnAddEmployee.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddEmployee.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddEmployee.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddEmployee.BOSDescription = null;
            this.fld_btnAddEmployee.BOSError = null;
            this.fld_btnAddEmployee.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddEmployee.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddEmployee.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddEmployee.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddEmployee.Location = new System.Drawing.Point(6, 710);
            this.fld_btnAddEmployee.Name = "fld_btnAddEmployee";
            this.fld_btnAddEmployee.Screen = null;
            this.fld_btnAddEmployee.Size = new System.Drawing.Size(100, 27);
            this.fld_btnAddEmployee.TabIndex = 15;
            this.fld_btnAddEmployee.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_btnAddEmployee.Text = "Thêm nhân viên";
            this.fld_btnAddEmployee.Click += new System.EventHandler(this.fld_btnAddEmployee_Click);
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
            this.bosPanel1.Controls.Add(this.bosPanel2);
            this.bosPanel1.Controls.Add(this.fld_btnAddEmployee);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(976, 741);
            this.bosPanel1.TabIndex = 17;
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
            this.bosPanel2.Controls.Add(this.bosMemoEdit1);
            this.bosPanel2.Controls.Add(this.fld_dteHRArrangementShiftToDate);
            this.bosPanel2.Controls.Add(this.fld_dteHRArrangementShiftFormDate);
            this.bosPanel2.Controls.Add(this.fld_txtHRArrangementShiftName);
            this.bosPanel2.Controls.Add(this.fld_txtHRArrangementShiftNo);
            this.bosPanel2.Controls.Add(this.bosLabel6);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel2.Controls.Add(this.bosLabel5);
            this.bosPanel2.Controls.Add(this.fld_pteHRTimeSheetEmployeePicture);
            this.bosPanel2.Controls.Add(this.fld_lblLabel2);
            this.bosPanel2.Controls.Add(this.fld_lblLabel4);
            this.bosPanel2.Controls.Add(this.bosLabel3);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(976, 116);
            this.bosPanel2.TabIndex = 17;
            // 
            // bosMemoEdit1
            // 
            this.bosMemoEdit1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosMemoEdit1.BOSDataMember = "HRArrangementShiftDesc";
            this.bosMemoEdit1.BOSDataSource = "HRArrangementShifts";
            this.bosMemoEdit1.BOSDescription = null;
            this.bosMemoEdit1.BOSError = null;
            this.bosMemoEdit1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosMemoEdit1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosMemoEdit1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosMemoEdit1.BOSPropertyName = "Text";
            this.bosMemoEdit1.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.bosMemoEdit1.Location = new System.Drawing.Point(203, 61);
            this.bosMemoEdit1.Name = "bosMemoEdit1";
            this.bosMemoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosMemoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosMemoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosMemoEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosMemoEdit1.Screen = null;
            this.bosMemoEdit1.Size = new System.Drawing.Size(466, 35);
            this.bosMemoEdit1.TabIndex = 7;
            this.bosMemoEdit1.Tag = "DC";
            // 
            // fld_dteHRArrangementShiftToDate
            // 
            this.fld_dteHRArrangementShiftToDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteHRArrangementShiftToDate.BOSDataMember = "HRArrangementShiftToDate";
            this.fld_dteHRArrangementShiftToDate.BOSDataSource = "HRArrangementShifts";
            this.fld_dteHRArrangementShiftToDate.BOSDescription = null;
            this.fld_dteHRArrangementShiftToDate.BOSError = null;
            this.fld_dteHRArrangementShiftToDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteHRArrangementShiftToDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteHRArrangementShiftToDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteHRArrangementShiftToDate.BOSPropertyName = "EditValue";
            this.fld_dteHRArrangementShiftToDate.EditValue = null;
            this.fld_dteHRArrangementShiftToDate.Location = new System.Drawing.Point(519, 35);
            this.fld_dteHRArrangementShiftToDate.Name = "fld_dteHRArrangementShiftToDate";
            this.fld_dteHRArrangementShiftToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRArrangementShiftToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRArrangementShiftToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRArrangementShiftToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRArrangementShiftToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRArrangementShiftToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.fld_dteHRArrangementShiftToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRArrangementShiftToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.fld_dteHRArrangementShiftToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRArrangementShiftToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.fld_dteHRArrangementShiftToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRArrangementShiftToDate.Screen = null;
            this.fld_dteHRArrangementShiftToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRArrangementShiftToDate.TabIndex = 6;
            this.fld_dteHRArrangementShiftToDate.Tag = "DC";
            this.fld_dteHRArrangementShiftToDate.Validated += new System.EventHandler(this.fld_dteHRArrangementShiftDate1_Validated);
            // 
            // fld_dteHRArrangementShiftFormDate
            // 
            this.fld_dteHRArrangementShiftFormDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteHRArrangementShiftFormDate.BOSDataMember = "HRArrangementShiftFromDate";
            this.fld_dteHRArrangementShiftFormDate.BOSDataSource = "HRArrangementShifts";
            this.fld_dteHRArrangementShiftFormDate.BOSDescription = null;
            this.fld_dteHRArrangementShiftFormDate.BOSError = null;
            this.fld_dteHRArrangementShiftFormDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteHRArrangementShiftFormDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteHRArrangementShiftFormDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteHRArrangementShiftFormDate.BOSPropertyName = "EditValue";
            this.fld_dteHRArrangementShiftFormDate.EditValue = null;
            this.fld_dteHRArrangementShiftFormDate.Location = new System.Drawing.Point(203, 35);
            this.fld_dteHRArrangementShiftFormDate.Name = "fld_dteHRArrangementShiftFormDate";
            this.fld_dteHRArrangementShiftFormDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRArrangementShiftFormDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRArrangementShiftFormDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRArrangementShiftFormDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRArrangementShiftFormDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRArrangementShiftFormDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.fld_dteHRArrangementShiftFormDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRArrangementShiftFormDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.fld_dteHRArrangementShiftFormDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRArrangementShiftFormDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.fld_dteHRArrangementShiftFormDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRArrangementShiftFormDate.Screen = null;
            this.fld_dteHRArrangementShiftFormDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRArrangementShiftFormDate.TabIndex = 5;
            this.fld_dteHRArrangementShiftFormDate.Tag = "DC";
            this.fld_dteHRArrangementShiftFormDate.Validated += new System.EventHandler(this.fld_dteHRArrangementShiftDate1_Validated);
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
            this.bosLabel6.Location = new System.Drawing.Point(431, 38);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(47, 13);
            this.bosLabel6.TabIndex = 5;
            this.bosLabel6.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel6.Text = "Đến ngày";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "HRArrangementShifts";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 83);
            this.fld_lkeFK_HREmployeeID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(79, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 20;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(120, 38);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 5;
            this.bosLabel5.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel5.Text = "Từ ngày";
            // 
            // fld_pteHRTimeSheetEmployeePicture
            // 
            this.fld_pteHRTimeSheetEmployeePicture.BOSComment = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSDataMember = "HRTimeSheetEmployeePicture";
            this.fld_pteHRTimeSheetEmployeePicture.BOSDataSource = "HRTimeSheets";
            this.fld_pteHRTimeSheetEmployeePicture.BOSDescription = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSError = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSFieldGroup = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSFieldRelation = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSPrivilege = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteHRTimeSheetEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteHRTimeSheetEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteHRTimeSheetEmployeePicture.Name = "fld_pteHRTimeSheetEmployeePicture";
            this.fld_pteHRTimeSheetEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteHRTimeSheetEmployeePicture.Screen = null;
            this.fld_pteHRTimeSheetEmployeePicture.Size = new System.Drawing.Size(79, 74);
            this.fld_pteHRTimeSheetEmployeePicture.TabIndex = 0;
            this.fld_pteHRTimeSheetEmployeePicture.Tag = "DC";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.Location = new System.Drawing.Point(120, 12);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel2.TabIndex = 1;
            this.fld_lblLabel2.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel2.Text = "Mã chứng từ";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.Location = new System.Drawing.Point(431, 12);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(65, 13);
            this.fld_lblLabel4.TabIndex = 3;
            this.fld_lblLabel4.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.Text = "Tên chứng từ";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Location = new System.Drawing.Point(120, 64);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 15;
            this.bosLabel3.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel3.Text = "Diễn giải";
            // 
            // DMAGS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(976, 741);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMAGS100";
            this.Text = "Bảng xếp ca";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRArrangementShiftNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRArrangementShiftName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeArrangementShifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRArrangementShiftToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRArrangementShiftToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRArrangementShiftFormDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRArrangementShiftFormDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRTimeSheetEmployeePicture.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteHRTimeSheetEmployeePicture;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit bosMemoEdit1;
        private BOSComponent.BOSDateEdit fld_dteHRArrangementShiftToDate;
        private BOSComponent.BOSDateEdit fld_dteHRArrangementShiftFormDate;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel5;
	}
}
