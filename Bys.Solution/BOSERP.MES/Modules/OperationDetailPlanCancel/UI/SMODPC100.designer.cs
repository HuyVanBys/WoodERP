using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.OperationDetailPlanCancel.UI
{
	/// <summary>
	/// Summary description for SMODPC100
	/// </summary>
	partial class SMODPC100
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
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeMMOperationDetailPlanCancelStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMOperationDetailPlanCancelNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteSearchToMMOperationDetailPlanCancelDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMOperationDetailPlanID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcMMOperationDetailPlanCancels = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvMMBatchProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationDetailPlanCancelStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationDetailPlanCancelNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMOperationDetailPlanCancelDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMOperationDetailPlanCancelDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMOperationDetailPlanCancelDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMOperationDetailPlanCancelDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationDetailPlanID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMOperationDetailPlanCancels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMBatchProducts)).BeginInit();
            this.SuspendLayout();
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
            this.bosLabel4.Location = new System.Drawing.Point(29, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 367;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Nhân viên";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "MMOperationDetailPlanCancels";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(129, 38);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, true);
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 363;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_lkeMMOperationDetailPlanCancelStatus
            // 
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSAllowAddNew = false;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSAllowDummy = false;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSDataMember = "MMOperationDetailPlanCancelStatus";
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSDataSource = "MMOperationDetailPlanCancels";
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSDescription = null;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSError = null;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.CurrentDisplayText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.Location = new System.Drawing.Point(129, 64);
            this.fld_lkeMMOperationDetailPlanCancelStatus.Name = "fld_lkeMMOperationDetailPlanCancelStatus";
            this.fld_lkeMMOperationDetailPlanCancelStatus.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeMMOperationDetailPlanCancelStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMOperationDetailPlanCancelStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMOperationDetailPlanCancelStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMOperationDetailPlanCancelStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMOperationDetailPlanCancelStatus.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMOperationDetailPlanCancelStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMOperationDetailPlanCancelStatus, true);
            this.fld_lkeMMOperationDetailPlanCancelStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMOperationDetailPlanCancelStatus.TabIndex = 364;
            this.fld_lkeMMOperationDetailPlanCancelStatus.Tag = "SC";
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
            this.bosLabel3.Location = new System.Drawing.Point(29, 67);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 366;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Tình trạng";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel.Location = new System.Drawing.Point(29, 15);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 365;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_txtMMOperationDetailPlanCancelNo
            // 
            this.fld_txtMMOperationDetailPlanCancelNo.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMOperationDetailPlanCancelNo.BOSDataMember = "MMOperationDetailPlanCancelNo";
            this.fld_txtMMOperationDetailPlanCancelNo.BOSDataSource = "MMOperationDetailPlanCancels";
            this.fld_txtMMOperationDetailPlanCancelNo.BOSDescription = null;
            this.fld_txtMMOperationDetailPlanCancelNo.BOSError = null;
            this.fld_txtMMOperationDetailPlanCancelNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMOperationDetailPlanCancelNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMOperationDetailPlanCancelNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMOperationDetailPlanCancelNo.BOSPropertyName = "Text";
            this.fld_txtMMOperationDetailPlanCancelNo.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMOperationDetailPlanCancelNo.Location = new System.Drawing.Point(129, 12);
            this.fld_txtMMOperationDetailPlanCancelNo.Name = "fld_txtMMOperationDetailPlanCancelNo";
            this.fld_txtMMOperationDetailPlanCancelNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMOperationDetailPlanCancelNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMOperationDetailPlanCancelNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMOperationDetailPlanCancelNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMOperationDetailPlanCancelNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMOperationDetailPlanCancelNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMOperationDetailPlanCancelNo.Screen = null;
            this.fld_txtMMOperationDetailPlanCancelNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMOperationDetailPlanCancelNo.TabIndex = 362;
            this.fld_txtMMOperationDetailPlanCancelNo.Tag = "SC";
            // 
            // fld_dteSearchToMMOperationDetailPlanCancelDate
            // 
            this.fld_dteSearchToMMOperationDetailPlanCancelDate.BOSComment = null;
            this.fld_dteSearchToMMOperationDetailPlanCancelDate.BOSDataMember = "OperationDetailPlanCancelDateTo";
            this.fld_dteSearchToMMOperationDetailPlanCancelDate.BOSDataSource = "MMOperationDetailPlanCancels";
            this.fld_dteSearchToMMOperationDetailPlanCancelDate.BOSDescription = null;
            this.fld_dteSearchToMMOperationDetailPlanCancelDate.BOSError = null;
            this.fld_dteSearchToMMOperationDetailPlanCancelDate.BOSFieldGroup = null;
            this.fld_dteSearchToMMOperationDetailPlanCancelDate.BOSFieldRelation = null;
            this.fld_dteSearchToMMOperationDetailPlanCancelDate.BOSPrivilege = null;
            this.fld_dteSearchToMMOperationDetailPlanCancelDate.BOSPropertyName = null;
            this.fld_dteSearchToMMOperationDetailPlanCancelDate.EditValue = null;
            this.fld_dteSearchToMMOperationDetailPlanCancelDate.Location = new System.Drawing.Point(371, 116);
            this.fld_dteSearchToMMOperationDetailPlanCancelDate.Name = "fld_dteSearchToMMOperationDetailPlanCancelDate";
            this.fld_dteSearchToMMOperationDetailPlanCancelDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToMMOperationDetailPlanCancelDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToMMOperationDetailPlanCancelDate.Screen = null;
            this.fld_dteSearchToMMOperationDetailPlanCancelDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToMMOperationDetailPlanCancelDate.TabIndex = 369;
            this.fld_dteSearchToMMOperationDetailPlanCancelDate.Tag = "SC";
            // 
            // fld_dteSearchFromMMOperationDetailPlanCancelDate
            // 
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.BOSComment = null;
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.BOSDataMember = "OperationDetailPlanCancelDateFrom";
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.BOSDataSource = "MMOperationDetailPlanCancels";
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.BOSDescription = null;
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.BOSError = null;
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.BOSFieldGroup = null;
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.BOSFieldRelation = null;
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.BOSPrivilege = null;
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.BOSPropertyName = null;
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.EditValue = null;
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.Location = new System.Drawing.Point(129, 116);
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.Name = "fld_dteSearchFromMMOperationDetailPlanCancelDate";
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.Screen = null;
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.TabIndex = 368;
            this.fld_dteSearchFromMMOperationDetailPlanCancelDate.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.Location = new System.Drawing.Point(310, 119);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 370;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đến ngày";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel1.Location = new System.Drawing.Point(29, 119);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(40, 13);
            this.bosLabel1.TabIndex = 371;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Từ ngày";
            // 
            // fld_lkeFK_MMOperationDetailPlanID
            // 
            this.fld_lkeFK_MMOperationDetailPlanID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSAllowDummy = false;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSComment = null;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSDataMember = "FK_MMOperationDetailPlanID";
            this.fld_lkeFK_MMOperationDetailPlanID.BOSDataSource = "MMOperationDetailPlanCancels";
            this.fld_lkeFK_MMOperationDetailPlanID.BOSDescription = null;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSError = null;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSFieldGroup = null;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSFieldParent = null;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSFieldRelation = null;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSPrivilege = null;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationDetailPlanID.BOSSelectType = null;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMOperationDetailPlanID.CurrentDisplayText = null;
            this.fld_lkeFK_MMOperationDetailPlanID.Location = new System.Drawing.Point(129, 90);
            this.fld_lkeFK_MMOperationDetailPlanID.Name = "fld_lkeFK_MMOperationDetailPlanID";
            this.fld_lkeFK_MMOperationDetailPlanID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationDetailPlanID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationDetailPlanNo", "Kế hoạch sản xuất")});
            this.fld_lkeFK_MMOperationDetailPlanID.Properties.DisplayMember = "MMOperationDetailPlanNo";
            this.fld_lkeFK_MMOperationDetailPlanID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMOperationDetailPlanID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMOperationDetailPlanID.Properties.ValueMember = "MMOperationDetailPlanID";
            this.fld_lkeFK_MMOperationDetailPlanID.Screen = null;
            this.fld_lkeFK_MMOperationDetailPlanID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_MMOperationDetailPlanID.TabIndex = 372;
            this.fld_lkeFK_MMOperationDetailPlanID.Tag = "SC";
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
            this.bosLabel8.Location = new System.Drawing.Point(29, 93);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(89, 13);
            this.bosLabel8.TabIndex = 373;
            this.bosLabel8.Tag = "SI";
            this.bosLabel8.Text = "Kế hoạch sản xuất";
            // 
            // fld_dgcMMOperationDetailPlanCancels
            // 
            this.fld_dgcMMOperationDetailPlanCancels.AllowDrop = true;
            this.fld_dgcMMOperationDetailPlanCancels.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMOperationDetailPlanCancels.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMOperationDetailPlanCancels.BOSDataSource = "MMOperationDetailPlanCancels";
            this.fld_dgcMMOperationDetailPlanCancels.BOSDescription = null;
            this.fld_dgcMMOperationDetailPlanCancels.BOSError = null;
            this.fld_dgcMMOperationDetailPlanCancels.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMOperationDetailPlanCancels.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMOperationDetailPlanCancels.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMOperationDetailPlanCancels.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMOperationDetailPlanCancels.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMOperationDetailPlanCancels.Location = new System.Drawing.Point(29, 156);
            this.fld_dgcMMOperationDetailPlanCancels.MainView = this.fld_dgvMMBatchProducts;
            this.fld_dgcMMOperationDetailPlanCancels.Name = "fld_dgcMMOperationDetailPlanCancels";
            this.fld_dgcMMOperationDetailPlanCancels.Screen = null;
            this.fld_dgcMMOperationDetailPlanCancels.Size = new System.Drawing.Size(492, 200);
            this.fld_dgcMMOperationDetailPlanCancels.TabIndex = 374;
            this.fld_dgcMMOperationDetailPlanCancels.Tag = "SR";
            this.fld_dgcMMOperationDetailPlanCancels.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvMMBatchProducts});
            // 
            // fld_dgvMMBatchProducts
            // 
            this.fld_dgvMMBatchProducts.GridControl = this.fld_dgcMMOperationDetailPlanCancels;
            this.fld_dgvMMBatchProducts.Name = "fld_dgvMMBatchProducts";
            this.fld_dgvMMBatchProducts.PaintStyleName = "Office2003";
            // 
            // SMODPC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(546, 567);
            this.Controls.Add(this.fld_dgcMMOperationDetailPlanCancels);
            this.Controls.Add(this.fld_lkeFK_MMOperationDetailPlanID);
            this.Controls.Add(this.bosLabel8);
            this.Controls.Add(this.fld_dteSearchToMMOperationDetailPlanCancelDate);
            this.Controls.Add(this.fld_dteSearchFromMMOperationDetailPlanCancelDate);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_lkeMMOperationDetailPlanCancelStatus);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtMMOperationDetailPlanCancelNo);
            this.Name = "SMODPC100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtMMOperationDetailPlanCancelNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lkeMMOperationDetailPlanCancelStatus, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromMMOperationDetailPlanCancelDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToMMOperationDetailPlanCancelDate, 0);
            this.Controls.SetChildIndex(this.bosLabel8, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_MMOperationDetailPlanID, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMOperationDetailPlanCancels, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationDetailPlanCancelStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationDetailPlanCancelNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMOperationDetailPlanCancelDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMOperationDetailPlanCancelDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMOperationDetailPlanCancelDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMOperationDetailPlanCancelDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationDetailPlanID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMOperationDetailPlanCancels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMBatchProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLookupEdit fld_lkeMMOperationDetailPlanCancelStatus;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSTextBox fld_txtMMOperationDetailPlanCancelNo;
        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteSearchToMMOperationDetailPlanCancelDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromMMOperationDetailPlanCancelDate;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationDetailPlanID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSSearchResultsGridControl fld_dgcMMOperationDetailPlanCancels;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMBatchProducts;
	}
}
