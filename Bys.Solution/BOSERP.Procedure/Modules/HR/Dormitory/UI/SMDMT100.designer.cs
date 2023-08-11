using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Dormitory.UI
{
	/// <summary>
	/// Summary description for SMAS100
	/// </summary>
    partial class SMDMT100
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
            this.fld_txtHRDormitoryName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRDormitoryNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcHRDormitorys = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromARSaleOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToARSaleOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDormitorys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtHRDormitoryName
            // 
            this.fld_txtHRDormitoryName.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRDormitoryName.BOSDataMember = "HRDormitoryName";
            this.fld_txtHRDormitoryName.BOSDataSource = "HRDormitorys";
            this.fld_txtHRDormitoryName.BOSDescription = null;
            this.fld_txtHRDormitoryName.BOSError = null;
            this.fld_txtHRDormitoryName.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRDormitoryName.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRDormitoryName.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRDormitoryName.BOSPropertyName = "Text";
            this.fld_txtHRDormitoryName.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRDormitoryName.Location = new System.Drawing.Point(132, 53);
            this.fld_txtHRDormitoryName.Name = "fld_txtHRDormitoryName";
            this.fld_txtHRDormitoryName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRDormitoryName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRDormitoryName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRDormitoryName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRDormitoryName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRDormitoryName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRDormitoryName.Screen = null;
            this.fld_txtHRDormitoryName.Size = new System.Drawing.Size(319, 20);
            this.fld_txtHRDormitoryName.TabIndex = 1;
            this.fld_txtHRDormitoryName.Tag = "SC";
            // 
            // fld_txtHRDormitoryNo
            // 
            this.fld_txtHRDormitoryNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRDormitoryNo.BOSDataMember = "HRDormitoryNo";
            this.fld_txtHRDormitoryNo.BOSDataSource = "HRDormitorys";
            this.fld_txtHRDormitoryNo.BOSDescription = null;
            this.fld_txtHRDormitoryNo.BOSError = null;
            this.fld_txtHRDormitoryNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRDormitoryNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRDormitoryNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRDormitoryNo.BOSPropertyName = "Text";
            this.fld_txtHRDormitoryNo.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtHRDormitoryNo.Location = new System.Drawing.Point(132, 27);
            this.fld_txtHRDormitoryNo.Name = "fld_txtHRDormitoryNo";
            this.fld_txtHRDormitoryNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRDormitoryNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRDormitoryNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRDormitoryNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRDormitoryNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRDormitoryNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRDormitoryNo.Screen = null;
            this.fld_txtHRDormitoryNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRDormitoryNo.TabIndex = 0;
            this.fld_txtHRDormitoryNo.Tag = "SC";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel1.Location = new System.Drawing.Point(34, 56);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(68, 13);
            this.fld_lblLabel1.TabIndex = 5;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Tên phòng trọ";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.Location = new System.Drawing.Point(34, 30);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã phòng trọ";
            // 
            // fld_dgcHRDormitorys
            // 
            this.fld_dgcHRDormitorys.BOSComment = null;
            this.fld_dgcHRDormitorys.BOSDataMember = null;
            this.fld_dgcHRDormitorys.BOSDataSource = "HRDormitorys";
            this.fld_dgcHRDormitorys.BOSDescription = null;
            this.fld_dgcHRDormitorys.BOSError = null;
            this.fld_dgcHRDormitorys.BOSFieldGroup = null;
            this.fld_dgcHRDormitorys.BOSFieldRelation = null;
            this.fld_dgcHRDormitorys.BOSPrivilege = null;
            this.fld_dgcHRDormitorys.BOSPropertyName = null;
            this.fld_dgcHRDormitorys.Location = new System.Drawing.Point(34, 216);
            this.fld_dgcHRDormitorys.MenuManager = this.screenToolbar;
            this.fld_dgcHRDormitorys.Name = "fld_dgcHRDormitorys";
            this.fld_dgcHRDormitorys.Screen = null;
            this.fld_dgcHRDormitorys.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRDormitorys.TabIndex = 11;
            this.fld_dgcHRDormitorys.Tag = "SR";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.Location = new System.Drawing.Point(34, 82);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 96;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "HRDormitorys";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(132, 79);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 89;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel13.BOSPropertyName = null;
            this.fld_lblLabel13.Location = new System.Drawing.Point(34, 108);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel13.TabIndex = 93;
            this.fld_lblLabel13.Tag = "SI";
            this.fld_lblLabel13.Text = "Nhân viên";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel14.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel14.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel14.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel14.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(34, 134);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(58, 13);
            this.fld_lblLabel14.TabIndex = 94;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Ngày tạo từ";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(313, 134);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel17.TabIndex = 95;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến";
            // 
            // fld_dteSearchFromARSaleOrderDate
            // 
            this.fld_dteSearchFromARSaleOrderDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromARSaleOrderDate.BOSDataMember = "DormitoryFromDate";
            this.fld_dteSearchFromARSaleOrderDate.BOSDataSource = "HRDormitorys";
            this.fld_dteSearchFromARSaleOrderDate.BOSDescription = null;
            this.fld_dteSearchFromARSaleOrderDate.BOSError = null;
            this.fld_dteSearchFromARSaleOrderDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromARSaleOrderDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromARSaleOrderDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromARSaleOrderDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromARSaleOrderDate.EditValue = null;
            this.fld_dteSearchFromARSaleOrderDate.Location = new System.Drawing.Point(132, 131);
            this.fld_dteSearchFromARSaleOrderDate.Name = "fld_dteSearchFromARSaleOrderDate";
            this.fld_dteSearchFromARSaleOrderDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromARSaleOrderDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromARSaleOrderDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromARSaleOrderDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromARSaleOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARSaleOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARSaleOrderDate.Screen = null;
            this.fld_dteSearchFromARSaleOrderDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARSaleOrderDate.TabIndex = 91;
            this.fld_dteSearchFromARSaleOrderDate.Tag = "SC";
            // 
            // fld_dteSearchToARSaleOrderDate
            // 
            this.fld_dteSearchToARSaleOrderDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToARSaleOrderDate.BOSDataMember = "DormitoryToDate";
            this.fld_dteSearchToARSaleOrderDate.BOSDataSource = "HRDormitorys";
            this.fld_dteSearchToARSaleOrderDate.BOSDescription = null;
            this.fld_dteSearchToARSaleOrderDate.BOSError = null;
            this.fld_dteSearchToARSaleOrderDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToARSaleOrderDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToARSaleOrderDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToARSaleOrderDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToARSaleOrderDate.EditValue = null;
            this.fld_dteSearchToARSaleOrderDate.Location = new System.Drawing.Point(347, 131);
            this.fld_dteSearchToARSaleOrderDate.Name = "fld_dteSearchToARSaleOrderDate";
            this.fld_dteSearchToARSaleOrderDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToARSaleOrderDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToARSaleOrderDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToARSaleOrderDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToARSaleOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARSaleOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARSaleOrderDate.Screen = null;
            this.fld_dteSearchToARSaleOrderDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARSaleOrderDate.TabIndex = 92;
            this.fld_dteSearchToARSaleOrderDate.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "HRDormitorys";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(132, 105);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã nhân viên", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.tutu, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên nhân viên")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 90;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // SMAS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lblLabel13);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dteSearchFromARSaleOrderDate);
            this.Controls.Add(this.fld_dteSearchToARSaleOrderDate);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_dgcHRDormitorys);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_txtHRDormitoryNo);
            this.Controls.Add(this.fld_txtHRDormitoryName);
            this.Name = "SMAS100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtHRDormitoryName, 0);
            this.Controls.SetChildIndex(this.fld_txtHRDormitoryNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dgcHRDormitorys, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToARSaleOrderDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromARSaleOrderDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel13, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDormitoryNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDormitorys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARSaleOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARSaleOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSTextBox fld_txtHRDormitoryName;
        private BOSComponent.BOSTextBox fld_txtHRDormitoryNo;
        private BOSComponent.BOSLabel fld_lblLabel1;
        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSSearchResultsGridControl fld_dgcHRDormitorys;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARSaleOrderDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToARSaleOrderDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
	}
}
