using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.TransferPlan.UI
{
    partial class SMTFP100
    {
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
            this.fld_dgvGridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgcARDeliveryPlans = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARDeliveryPlanNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtARDeliveryPlanName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARDeliveryPlanBeginDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosDateEdit1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteARDeliveryPlanEndDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosDateEdit2 = new BOSComponent.BOSDateEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDeliveryPlanNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDeliveryPlanName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanBeginDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanBeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgvGridControl
            // 
            this.fld_dgvGridControl.GridControl = this.fld_dgcARDeliveryPlans;
            this.fld_dgvGridControl.Name = "fld_dgvGridControl";
            this.fld_dgvGridControl.PaintStyleName = "Office2003";
            // 
            // fld_dgcARDeliveryPlans
            // 
            this.fld_dgcARDeliveryPlans.AllowDrop = true;
            this.fld_dgcARDeliveryPlans.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARDeliveryPlans.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARDeliveryPlans.BOSDataSource = "ARDeliveryPlans";
            this.fld_dgcARDeliveryPlans.BOSDescription = null;
            this.fld_dgcARDeliveryPlans.BOSError = null;
            this.fld_dgcARDeliveryPlans.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARDeliveryPlans.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARDeliveryPlans.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcARDeliveryPlans.BOSPropertyName = null;
            this.fld_dgcARDeliveryPlans.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARDeliveryPlans.Location = new System.Drawing.Point(43, 156);
            this.fld_dgcARDeliveryPlans.MainView = this.fld_dgvGridControl;
            this.fld_dgcARDeliveryPlans.Name = "fld_dgcARDeliveryPlans";
            this.fld_dgcARDeliveryPlans.Screen = null;
            this.fld_dgcARDeliveryPlans.Size = new System.Drawing.Size(528, 200);
            this.fld_dgcARDeliveryPlans.TabIndex = 9;
            this.fld_dgcARDeliveryPlans.Tag = "SR";
            this.fld_dgcARDeliveryPlans.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl});
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel8.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel8.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel8.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel8.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(331, 91);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(47, 13);
            this.bosLabel8.TabIndex = 101;
            this.bosLabel8.Tag = "SI";
            this.bosLabel8.Text = "Đến ngày";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel7.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel7.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel7.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel7.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(42, 91);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(51, 13);
            this.bosLabel7.TabIndex = 100;
            this.bosLabel7.Tag = "SI";
            this.bosLabel7.Text = "Bắt đầu từ";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(43, 65);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 98;
            this.bosLabel6.Tag = "SI";
            this.bosLabel6.Text = "Nhân viên";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(43, 13);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(61, 13);
            this.bosLabel3.TabIndex = 95;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Mã chứng từ";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(43, 39);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(64, 13);
            this.bosLabel1.TabIndex = 102;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Tên kế hoạch";
            // 
            // fld_txtARDeliveryPlanNo
            // 
            this.fld_txtARDeliveryPlanNo.BOSComment = null;
            this.fld_txtARDeliveryPlanNo.BOSDataMember = "ARDeliveryPlanNo";
            this.fld_txtARDeliveryPlanNo.BOSDataSource = "ARDeliveryPlans";
            this.fld_txtARDeliveryPlanNo.BOSDescription = null;
            this.fld_txtARDeliveryPlanNo.BOSError = null;
            this.fld_txtARDeliveryPlanNo.BOSFieldGroup = null;
            this.fld_txtARDeliveryPlanNo.BOSFieldRelation = null;
            this.fld_txtARDeliveryPlanNo.BOSPrivilege = null;
            this.fld_txtARDeliveryPlanNo.BOSPropertyName = "EditValue";
            this.fld_txtARDeliveryPlanNo.Location = new System.Drawing.Point(126, 10);
            this.fld_txtARDeliveryPlanNo.MenuManager = this.screenToolbar;
            this.fld_txtARDeliveryPlanNo.Name = "fld_txtARDeliveryPlanNo";
            this.fld_txtARDeliveryPlanNo.Screen = null;
            this.fld_txtARDeliveryPlanNo.Size = new System.Drawing.Size(187, 20);
            this.fld_txtARDeliveryPlanNo.TabIndex = 0;
            this.fld_txtARDeliveryPlanNo.Tag = "SC";
            // 
            // fld_txtARDeliveryPlanName
            // 
            this.fld_txtARDeliveryPlanName.BOSComment = null;
            this.fld_txtARDeliveryPlanName.BOSDataMember = "ARDeliveryPlanName";
            this.fld_txtARDeliveryPlanName.BOSDataSource = "ARDeliveryPlans";
            this.fld_txtARDeliveryPlanName.BOSDescription = null;
            this.fld_txtARDeliveryPlanName.BOSError = null;
            this.fld_txtARDeliveryPlanName.BOSFieldGroup = null;
            this.fld_txtARDeliveryPlanName.BOSFieldRelation = null;
            this.fld_txtARDeliveryPlanName.BOSPrivilege = null;
            this.fld_txtARDeliveryPlanName.BOSPropertyName = "EditValue";
            this.fld_txtARDeliveryPlanName.Location = new System.Drawing.Point(126, 36);
            this.fld_txtARDeliveryPlanName.Name = "fld_txtARDeliveryPlanName";
            this.fld_txtARDeliveryPlanName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARDeliveryPlanName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARDeliveryPlanName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARDeliveryPlanName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARDeliveryPlanName.Properties.Mask.EditMask = "n";
            this.fld_txtARDeliveryPlanName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARDeliveryPlanName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARDeliveryPlanName.Screen = null;
            this.fld_txtARDeliveryPlanName.Size = new System.Drawing.Size(445, 20);
            this.fld_txtARDeliveryPlanName.TabIndex = 1;
            this.fld_txtARDeliveryPlanName.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID1
            // 
            this.fld_lkeFK_HREmployeeID1.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID1.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID1.BOSComment = null;
            this.fld_lkeFK_HREmployeeID1.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.BOSDataSource = "ARDeliveryPlans";
            this.fld_lkeFK_HREmployeeID1.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID1.BOSError = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID1.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID1.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID1.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID1.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID1.Location = new System.Drawing.Point(126, 62);
            this.fld_lkeFK_HREmployeeID1.Name = "fld_lkeFK_HREmployeeID1";
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID1.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID1.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID1.Screen = null;
            this.fld_lkeFK_HREmployeeID1.Size = new System.Drawing.Size(187, 20);
            this.fld_lkeFK_HREmployeeID1.TabIndex = 2;
            this.fld_lkeFK_HREmployeeID1.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(331, 117);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(47, 13);
            this.bosLabel2.TabIndex = 109;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Đến ngày";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(42, 117);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(54, 13);
            this.bosLabel4.TabIndex = 108;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Kết thúc từ";
            // 
            // fld_dteARDeliveryPlanBeginDate
            // 
            this.fld_dteARDeliveryPlanBeginDate.BOSComment = null;
            this.fld_dteARDeliveryPlanBeginDate.BOSDataMember = "ARDeliveryPlanBeginDateFrom";
            this.fld_dteARDeliveryPlanBeginDate.BOSDataSource = "ARDeliveryPlans";
            this.fld_dteARDeliveryPlanBeginDate.BOSDescription = null;
            this.fld_dteARDeliveryPlanBeginDate.BOSError = null;
            this.fld_dteARDeliveryPlanBeginDate.BOSFieldGroup = null;
            this.fld_dteARDeliveryPlanBeginDate.BOSFieldRelation = null;
            this.fld_dteARDeliveryPlanBeginDate.BOSPrivilege = null;
            this.fld_dteARDeliveryPlanBeginDate.BOSPropertyName = "EditValue";
            this.fld_dteARDeliveryPlanBeginDate.EditValue = null;
            this.fld_dteARDeliveryPlanBeginDate.Location = new System.Drawing.Point(126, 88);
            this.fld_dteARDeliveryPlanBeginDate.Name = "fld_dteARDeliveryPlanBeginDate";
            this.fld_dteARDeliveryPlanBeginDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARDeliveryPlanBeginDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARDeliveryPlanBeginDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARDeliveryPlanBeginDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARDeliveryPlanBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARDeliveryPlanBeginDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARDeliveryPlanBeginDate.Screen = null;
            this.fld_dteARDeliveryPlanBeginDate.Size = new System.Drawing.Size(187, 20);
            this.fld_dteARDeliveryPlanBeginDate.TabIndex = 3;
            this.fld_dteARDeliveryPlanBeginDate.Tag = "SC";
            // 
            // bosDateEdit1
            // 
            this.bosDateEdit1.BOSComment = null;
            this.bosDateEdit1.BOSDataMember = "ARDeliveryPlanBeginDateTo";
            this.bosDateEdit1.BOSDataSource = "ARDeliveryPlans";
            this.bosDateEdit1.BOSDescription = null;
            this.bosDateEdit1.BOSError = null;
            this.bosDateEdit1.BOSFieldGroup = null;
            this.bosDateEdit1.BOSFieldRelation = null;
            this.bosDateEdit1.BOSPrivilege = null;
            this.bosDateEdit1.BOSPropertyName = "EditValue";
            this.bosDateEdit1.EditValue = null;
            this.bosDateEdit1.Location = new System.Drawing.Point(384, 88);
            this.bosDateEdit1.Name = "bosDateEdit1";
            this.bosDateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit1.Screen = null;
            this.bosDateEdit1.Size = new System.Drawing.Size(187, 20);
            this.bosDateEdit1.TabIndex = 4;
            this.bosDateEdit1.Tag = "SC";
            // 
            // fld_dteARDeliveryPlanEndDate
            // 
            this.fld_dteARDeliveryPlanEndDate.BOSComment = null;
            this.fld_dteARDeliveryPlanEndDate.BOSDataMember = "ARDeliveryPlanEndDateFrom";
            this.fld_dteARDeliveryPlanEndDate.BOSDataSource = "ARDeliveryPlans";
            this.fld_dteARDeliveryPlanEndDate.BOSDescription = null;
            this.fld_dteARDeliveryPlanEndDate.BOSError = null;
            this.fld_dteARDeliveryPlanEndDate.BOSFieldGroup = null;
            this.fld_dteARDeliveryPlanEndDate.BOSFieldRelation = null;
            this.fld_dteARDeliveryPlanEndDate.BOSPrivilege = null;
            this.fld_dteARDeliveryPlanEndDate.BOSPropertyName = "EditValue";
            this.fld_dteARDeliveryPlanEndDate.EditValue = null;
            this.fld_dteARDeliveryPlanEndDate.Location = new System.Drawing.Point(126, 114);
            this.fld_dteARDeliveryPlanEndDate.Name = "fld_dteARDeliveryPlanEndDate";
            this.fld_dteARDeliveryPlanEndDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARDeliveryPlanEndDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARDeliveryPlanEndDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARDeliveryPlanEndDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARDeliveryPlanEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARDeliveryPlanEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARDeliveryPlanEndDate.Screen = null;
            this.fld_dteARDeliveryPlanEndDate.Size = new System.Drawing.Size(187, 20);
            this.fld_dteARDeliveryPlanEndDate.TabIndex = 5;
            this.fld_dteARDeliveryPlanEndDate.Tag = "SC";
            // 
            // bosDateEdit2
            // 
            this.bosDateEdit2.BOSComment = null;
            this.bosDateEdit2.BOSDataMember = "ARDeliveryPlanEndDateTo";
            this.bosDateEdit2.BOSDataSource = "ARDeliveryPlans";
            this.bosDateEdit2.BOSDescription = null;
            this.bosDateEdit2.BOSError = null;
            this.bosDateEdit2.BOSFieldGroup = null;
            this.bosDateEdit2.BOSFieldRelation = null;
            this.bosDateEdit2.BOSPrivilege = null;
            this.bosDateEdit2.BOSPropertyName = "EditValue";
            this.bosDateEdit2.EditValue = null;
            this.bosDateEdit2.Location = new System.Drawing.Point(384, 114);
            this.bosDateEdit2.Name = "bosDateEdit2";
            this.bosDateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosDateEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosDateEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosDateEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosDateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosDateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bosDateEdit2.Screen = null;
            this.bosDateEdit2.Size = new System.Drawing.Size(187, 20);
            this.bosDateEdit2.TabIndex = 6;
            this.bosDateEdit2.Tag = "SC";
            // 
            // SMDP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(636, 386);
            this.Controls.Add(this.bosDateEdit2);
            this.Controls.Add(this.fld_dteARDeliveryPlanEndDate);
            this.Controls.Add(this.bosDateEdit1);
            this.Controls.Add(this.fld_dteARDeliveryPlanBeginDate);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel4);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID1);
            this.Controls.Add(this.fld_txtARDeliveryPlanName);
            this.Controls.Add(this.fld_txtARDeliveryPlanNo);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_dgcARDeliveryPlans);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.bosLabel6);
            this.Controls.Add(this.bosLabel8);
            this.Controls.Add(this.bosLabel7);
            this.Name = "SMDP100";
            this.Tag = "SI";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.bosLabel7, 0);
            this.Controls.SetChildIndex(this.bosLabel8, 0);
            this.Controls.SetChildIndex(this.bosLabel6, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_dgcARDeliveryPlans, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_txtARDeliveryPlanNo, 0);
            this.Controls.SetChildIndex(this.fld_txtARDeliveryPlanName, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID1, 0);
            this.Controls.SetChildIndex(this.bosLabel4, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dteARDeliveryPlanBeginDate, 0);
            this.Controls.SetChildIndex(this.bosDateEdit1, 0);
            this.Controls.SetChildIndex(this.fld_dteARDeliveryPlanEndDate, 0);
            this.Controls.SetChildIndex(this.bosDateEdit2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDeliveryPlanNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDeliveryPlanName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanBeginDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanBeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDeliveryPlanEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosDateEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl;
        private BOSSearchResultsGridControl fld_dgcARDeliveryPlans;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtARDeliveryPlanNo;
        private BOSComponent.BOSTextBox fld_txtARDeliveryPlanName;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSDateEdit fld_dteARDeliveryPlanBeginDate;
        private BOSComponent.BOSDateEdit bosDateEdit1;
        private BOSComponent.BOSDateEdit fld_dteARDeliveryPlanEndDate;
        private BOSComponent.BOSDateEdit bosDateEdit2;
	}
}
