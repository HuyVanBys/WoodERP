using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ContainerLoader.UI
{
	/// <summary>
	/// Summary description for SMCL100
	/// </summary>
	partial class SMCL100
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
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcARSaleOrder = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvGridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteARContainerLoaderDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteARContainerLoaderDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtARSaleOrderNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARContainerLoaderDateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARContainerLoaderDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARContainerLoaderDateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARContainerLoaderDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.bosLabel2.Location = new System.Drawing.Point(9, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 103;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ARContainerLoaders";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(124, 38);
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
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 91;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel11.BOSPropertyName = null;
            this.fld_lblLabel11.Location = new System.Drawing.Point(9, 15);
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.fld_lblLabel11.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel11.TabIndex = 94;
            this.fld_lblLabel11.Tag = "SI";
            this.fld_lblLabel11.Text = "Mã chứng từ";
            // 
            // fld_lblLabel13
            // 
            this.fld_lblLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel13.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel13.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel13.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.BOSDescription = null;
            this.fld_lblLabel13.BOSError = null;
            this.fld_lblLabel13.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel13.BOSPropertyName = null;
            this.fld_lblLabel13.Location = new System.Drawing.Point(9, 67);
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.fld_lblLabel13.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel13.TabIndex = 99;
            this.fld_lblLabel13.Tag = "SI";
            this.fld_lblLabel13.Text = "Nhân viên";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(9, 93);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(86, 13);
            this.fld_lblLabel14.TabIndex = 100;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Ngày chứng từ từ";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(305, 93);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel17.TabIndex = 102;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến";
            // 
            // fld_dgcARSaleOrder
            // 
            this.fld_dgcARSaleOrder.AllowDrop = true;
            this.fld_dgcARSaleOrder.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARSaleOrder.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARSaleOrder.BOSDataSource = "ARContainerLoaders";
            this.fld_dgcARSaleOrder.BOSDescription = null;
            this.fld_dgcARSaleOrder.BOSError = null;
            this.fld_dgcARSaleOrder.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARSaleOrder.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARSaleOrder.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcARSaleOrder.BOSPropertyName = null;
            this.fld_dgcARSaleOrder.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleOrder.Location = new System.Drawing.Point(9, 138);
            this.fld_dgcARSaleOrder.MainView = this.fld_dgvGridControl;
            this.fld_dgcARSaleOrder.Name = "fld_dgcARSaleOrder";
            this.fld_dgcARSaleOrder.Screen = null;
            this.fld_dgcARSaleOrder.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcARSaleOrder.TabIndex = 101;
            this.fld_dgcARSaleOrder.Tag = "SR";
            this.fld_dgcARSaleOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl});
            // 
            // fld_dgvGridControl
            // 
            this.fld_dgvGridControl.GridControl = this.fld_dgcARSaleOrder;
            this.fld_dgvGridControl.Name = "fld_dgvGridControl";
            this.fld_dgvGridControl.PaintStyleName = "Office2003";
            // 
            // fld_dteARContainerLoaderDateFrom
            // 
            this.fld_dteARContainerLoaderDateFrom.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteARContainerLoaderDateFrom.BOSDataMember = "ARContainerLoaderDateFrom";
            this.fld_dteARContainerLoaderDateFrom.BOSDataSource = "ARContainerLoaders";
            this.fld_dteARContainerLoaderDateFrom.BOSDescription = null;
            this.fld_dteARContainerLoaderDateFrom.BOSError = null;
            this.fld_dteARContainerLoaderDateFrom.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteARContainerLoaderDateFrom.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteARContainerLoaderDateFrom.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteARContainerLoaderDateFrom.BOSPropertyName = "EditValue";
            this.fld_dteARContainerLoaderDateFrom.EditValue = null;
            this.fld_dteARContainerLoaderDateFrom.Location = new System.Drawing.Point(124, 90);
            this.fld_dteARContainerLoaderDateFrom.Name = "fld_dteARContainerLoaderDateFrom";
            this.fld_dteARContainerLoaderDateFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARContainerLoaderDateFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARContainerLoaderDateFrom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARContainerLoaderDateFrom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARContainerLoaderDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARContainerLoaderDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARContainerLoaderDateFrom.Screen = null;
            this.fld_dteARContainerLoaderDateFrom.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARContainerLoaderDateFrom.TabIndex = 95;
            this.fld_dteARContainerLoaderDateFrom.Tag = "SC";
            // 
            // fld_dteARContainerLoaderDateTo
            // 
            this.fld_dteARContainerLoaderDateTo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteARContainerLoaderDateTo.BOSDataMember = "ARContainerLoaderDateTo";
            this.fld_dteARContainerLoaderDateTo.BOSDataSource = "ARContainerLoaders";
            this.fld_dteARContainerLoaderDateTo.BOSDescription = null;
            this.fld_dteARContainerLoaderDateTo.BOSError = null;
            this.fld_dteARContainerLoaderDateTo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteARContainerLoaderDateTo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteARContainerLoaderDateTo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteARContainerLoaderDateTo.BOSPropertyName = "EditValue";
            this.fld_dteARContainerLoaderDateTo.EditValue = null;
            this.fld_dteARContainerLoaderDateTo.Location = new System.Drawing.Point(339, 90);
            this.fld_dteARContainerLoaderDateTo.Name = "fld_dteARContainerLoaderDateTo";
            this.fld_dteARContainerLoaderDateTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARContainerLoaderDateTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARContainerLoaderDateTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARContainerLoaderDateTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARContainerLoaderDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARContainerLoaderDateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARContainerLoaderDateTo.Screen = null;
            this.fld_dteARContainerLoaderDateTo.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARContainerLoaderDateTo.TabIndex = 96;
            this.fld_dteARContainerLoaderDateTo.Tag = "SC";
            // 
            // fld_txtARSaleOrderNo
            // 
            this.fld_txtARSaleOrderNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleOrderNo.BOSDataMember = "ARContainerLoaderNo";
            this.fld_txtARSaleOrderNo.BOSDataSource = "ARContainerLoaders";
            this.fld_txtARSaleOrderNo.BOSDescription = null;
            this.fld_txtARSaleOrderNo.BOSError = null;
            this.fld_txtARSaleOrderNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleOrderNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleOrderNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleOrderNo.BOSPropertyName = "EditValue";
            this.fld_txtARSaleOrderNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtARSaleOrderNo.Location = new System.Drawing.Point(124, 12);
            this.fld_txtARSaleOrderNo.Name = "fld_txtARSaleOrderNo";
            this.fld_txtARSaleOrderNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARSaleOrderNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARSaleOrderNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARSaleOrderNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARSaleOrderNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARSaleOrderNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARSaleOrderNo.Screen = null;
            this.fld_txtARSaleOrderNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtARSaleOrderNo.TabIndex = 89;
            this.fld_txtARSaleOrderNo.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARContainerLoaders";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(124, 64);
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
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 92;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // SMCL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(569, 376);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.fld_lblLabel13);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dgcARSaleOrder);
            this.Controls.Add(this.fld_dteARContainerLoaderDateFrom);
            this.Controls.Add(this.fld_dteARContainerLoaderDateTo);
            this.Controls.Add(this.fld_txtARSaleOrderNo);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Name = "SMCL100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_txtARSaleOrderNo, 0);
            this.Controls.SetChildIndex(this.fld_dteARContainerLoaderDateTo, 0);
            this.Controls.SetChildIndex(this.fld_dteARContainerLoaderDateFrom, 0);
            this.Controls.SetChildIndex(this.fld_dgcARSaleOrder, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel13, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARContainerLoaderDateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARContainerLoaderDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARContainerLoaderDateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARContainerLoaderDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARSaleOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSSearchResultsGridControl fld_dgcARSaleOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl;
        private BOSComponent.BOSDateEdit fld_dteARContainerLoaderDateFrom;
        private BOSComponent.BOSDateEdit fld_dteARContainerLoaderDateTo;
        private BOSComponent.BOSTextBox fld_txtARSaleOrderNo;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private IContainer components;
	}
}
