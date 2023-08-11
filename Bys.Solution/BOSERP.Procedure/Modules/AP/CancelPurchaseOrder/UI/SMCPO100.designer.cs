using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CancelPurchaseOrder.UI
{
	/// <summary>
	/// Summary description for SMCPO100
	/// </summary>
	partial class SMCPO100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMCPO100));
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcAPCancelPurchaseOrder = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvGridControl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPCancelPurchaseOrderNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPPurchaseOrderNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteAPCancelPurchaseOrderDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAPCancelPurchaseOrderDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeACObjectAccessKey = new BOSERP.AccObjectLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPCancelPurchaseOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPCancelPurchaseOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPCancelPurchaseOrderDateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPCancelPurchaseOrderDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPCancelPurchaseOrderDateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPCancelPurchaseOrderDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).BeginInit();
            this.SuspendLayout();
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
            resources.ApplyResources(this.bosLabel2, "bosLabel2");
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel2, ((bool)(resources.GetObject("bosLabel2.ShowHelp"))));
            this.bosLabel2.Tag = "SI";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "APCancelPurchaseOrders";
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
            resources.ApplyResources(this.fld_lkeFK_BRBranchID, "fld_lkeFK_BRBranchID");
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_BRBranchID.Properties.Buttons"))))});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_BRBranchID.Properties.Columns"), resources.GetString("fld_lkeFK_BRBranchID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_BRBranchID.Properties.Columns2"), resources.GetString("fld_lkeFK_BRBranchID.Properties.Columns3"))});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_BRBranchID, ((bool)(resources.GetObject("fld_lkeFK_BRBranchID.ShowHelp"))));
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // fld_dgcAPCancelPurchaseOrder
            // 
            this.fld_dgcAPCancelPurchaseOrder.AllowDrop = true;
            this.fld_dgcAPCancelPurchaseOrder.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPCancelPurchaseOrder.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPCancelPurchaseOrder.BOSDataSource = "APCancelPurchaseOrders";
            this.fld_dgcAPCancelPurchaseOrder.BOSDescription = null;
            this.fld_dgcAPCancelPurchaseOrder.BOSError = null;
            this.fld_dgcAPCancelPurchaseOrder.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPCancelPurchaseOrder.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPCancelPurchaseOrder.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPCancelPurchaseOrder.BOSPropertyName = null;
            resources.ApplyResources(this.fld_dgcAPCancelPurchaseOrder, "fld_dgcAPCancelPurchaseOrder");
            this.fld_dgcAPCancelPurchaseOrder.MainView = this.fld_dgvGridControl;
            this.fld_dgcAPCancelPurchaseOrder.Name = "fld_dgcAPCancelPurchaseOrder";
            this.fld_dgcAPCancelPurchaseOrder.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcAPCancelPurchaseOrder, ((bool)(resources.GetObject("fld_dgcAPCancelPurchaseOrder.ShowHelp"))));
            this.fld_dgcAPCancelPurchaseOrder.Tag = "SR";
            this.fld_dgcAPCancelPurchaseOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl});
            // 
            // fld_dgvGridControl
            // 
            this.fld_dgvGridControl.GridControl = this.fld_dgcAPCancelPurchaseOrder;
            this.fld_dgvGridControl.Name = "fld_dgvGridControl";
            this.fld_dgvGridControl.PaintStyleName = "Office2003";
            // 
            // fld_lblLabel11
            // 
            this.fld_lblLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel11.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel11.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel11.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel11.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel11.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel11.BOSDescription = null;
            this.fld_lblLabel11.BOSError = null;
            this.fld_lblLabel11.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel11.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel11.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel11.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel11, "fld_lblLabel11");
            this.fld_lblLabel11.Name = "fld_lblLabel11";
            this.fld_lblLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel11, ((bool)(resources.GetObject("fld_lblLabel11.ShowHelp"))));
            this.fld_lblLabel11.Tag = "SI";
            // 
            // fld_txtAPCancelPurchaseOrderNo
            // 
            this.fld_txtAPCancelPurchaseOrderNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPCancelPurchaseOrderNo.BOSDataMember = "APCancelPurchaseOrderNo";
            this.fld_txtAPCancelPurchaseOrderNo.BOSDataSource = "APCancelPurchaseOrders";
            this.fld_txtAPCancelPurchaseOrderNo.BOSDescription = null;
            this.fld_txtAPCancelPurchaseOrderNo.BOSError = null;
            this.fld_txtAPCancelPurchaseOrderNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPCancelPurchaseOrderNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPCancelPurchaseOrderNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPCancelPurchaseOrderNo.BOSPropertyName = "EditValue";
            this.fld_txtAPCancelPurchaseOrderNo.EditValue = global::Localization.ReportLocalizedResources.tutu;
            resources.ApplyResources(this.fld_txtAPCancelPurchaseOrderNo, "fld_txtAPCancelPurchaseOrderNo");
            this.fld_txtAPCancelPurchaseOrderNo.Name = "fld_txtAPCancelPurchaseOrderNo";
            this.fld_txtAPCancelPurchaseOrderNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPCancelPurchaseOrderNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPCancelPurchaseOrderNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPCancelPurchaseOrderNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPCancelPurchaseOrderNo.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtAPCancelPurchaseOrderNo.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtAPCancelPurchaseOrderNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtAPCancelPurchaseOrderNo, ((bool)(resources.GetObject("fld_txtAPCancelPurchaseOrderNo.ShowHelp"))));
            this.fld_txtAPCancelPurchaseOrderNo.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel1, "bosLabel1");
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, ((bool)(resources.GetObject("bosLabel1.ShowHelp"))));
            this.bosLabel1.Tag = "SI";
            // 
            // fld_txtAPPurchaseOrderNo
            // 
            this.fld_txtAPPurchaseOrderNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPPurchaseOrderNo.BOSDataMember = "APCancelPurchaseOrderReference";
            this.fld_txtAPPurchaseOrderNo.BOSDataSource = "APCancelPurchaseOrders";
            this.fld_txtAPPurchaseOrderNo.BOSDescription = null;
            this.fld_txtAPPurchaseOrderNo.BOSError = null;
            this.fld_txtAPPurchaseOrderNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPPurchaseOrderNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPPurchaseOrderNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPPurchaseOrderNo.BOSPropertyName = "EditValue";
            this.fld_txtAPPurchaseOrderNo.EditValue = global::Localization.ReportLocalizedResources.tutu;
            resources.ApplyResources(this.fld_txtAPPurchaseOrderNo, "fld_txtAPPurchaseOrderNo");
            this.fld_txtAPPurchaseOrderNo.Name = "fld_txtAPPurchaseOrderNo";
            this.fld_txtAPPurchaseOrderNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPurchaseOrderNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseOrderNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseOrderNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseOrderNo.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtAPPurchaseOrderNo.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtAPPurchaseOrderNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtAPPurchaseOrderNo, ((bool)(resources.GetObject("fld_txtAPPurchaseOrderNo.ShowHelp"))));
            this.fld_txtAPPurchaseOrderNo.Tag = "SC";
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel12.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel12.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel12.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel12.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel12.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel12, "fld_lblLabel12");
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel12, ((bool)(resources.GetObject("fld_lblLabel12.ShowHelp"))));
            this.fld_lblLabel12.Tag = "SI";
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
            resources.ApplyResources(this.fld_lblLabel13, "fld_lblLabel13");
            this.fld_lblLabel13.Name = "fld_lblLabel13";
            this.fld_lblLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel13, ((bool)(resources.GetObject("fld_lblLabel13.ShowHelp"))));
            this.fld_lblLabel13.Tag = "SI";
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
            resources.ApplyResources(this.fld_lblLabel14, "fld_lblLabel14");
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel14, ((bool)(resources.GetObject("fld_lblLabel14.ShowHelp"))));
            this.fld_lblLabel14.Tag = "SI";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "APCancelPurchaseOrders";
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
            resources.ApplyResources(this.fld_lkeFK_HREmployeeID, "fld_lkeFK_HREmployeeID");
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_HREmployeeID.Properties.Buttons"))))});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HREmployeeID.Properties.Columns"), resources.GetString("fld_lkeFK_HREmployeeID.Properties.Columns1"), ((int)(resources.GetObject("fld_lkeFK_HREmployeeID.Properties.Columns2"))), ((DevExpress.Utils.FormatType)(resources.GetObject("fld_lkeFK_HREmployeeID.Properties.Columns3"))), global::Localization.ReportLocalizedResources.tutu, ((bool)(resources.GetObject("fld_lkeFK_HREmployeeID.Properties.Columns4"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("fld_lkeFK_HREmployeeID.Properties.Columns5")))),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HREmployeeID.Properties.Columns6"), resources.GetString("fld_lkeFK_HREmployeeID.Properties.Columns7"))});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, ((bool)(resources.GetObject("fld_lkeFK_HREmployeeID.ShowHelp"))));
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // fld_dteAPCancelPurchaseOrderDateFrom
            // 
            this.fld_dteAPCancelPurchaseOrderDateFrom.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteAPCancelPurchaseOrderDateFrom.BOSDataMember = "APCancelPurchaseOrderDateFrom";
            this.fld_dteAPCancelPurchaseOrderDateFrom.BOSDataSource = "APCancelPurchaseOrders";
            this.fld_dteAPCancelPurchaseOrderDateFrom.BOSDescription = null;
            this.fld_dteAPCancelPurchaseOrderDateFrom.BOSError = null;
            this.fld_dteAPCancelPurchaseOrderDateFrom.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteAPCancelPurchaseOrderDateFrom.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteAPCancelPurchaseOrderDateFrom.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteAPCancelPurchaseOrderDateFrom.BOSPropertyName = "EditValue";
            this.fld_dteAPCancelPurchaseOrderDateFrom.EditValue = null;
            resources.ApplyResources(this.fld_dteAPCancelPurchaseOrderDateFrom, "fld_dteAPCancelPurchaseOrderDateFrom");
            this.fld_dteAPCancelPurchaseOrderDateFrom.Name = "fld_dteAPCancelPurchaseOrderDateFrom";
            this.fld_dteAPCancelPurchaseOrderDateFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPCancelPurchaseOrderDateFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPCancelPurchaseOrderDateFrom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPCancelPurchaseOrderDateFrom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPCancelPurchaseOrderDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteAPCancelPurchaseOrderDateFrom.Properties.Buttons"))))});
            this.fld_dteAPCancelPurchaseOrderDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPCancelPurchaseOrderDateFrom.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteAPCancelPurchaseOrderDateFrom, ((bool)(resources.GetObject("fld_dteAPCancelPurchaseOrderDateFrom.ShowHelp"))));
            this.fld_dteAPCancelPurchaseOrderDateFrom.Tag = "SC";
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
            resources.ApplyResources(this.fld_lblLabel17, "fld_lblLabel17");
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel17, ((bool)(resources.GetObject("fld_lblLabel17.ShowHelp"))));
            this.fld_lblLabel17.Tag = "SI";
            // 
            // fld_dteAPCancelPurchaseOrderDateTo
            // 
            this.fld_dteAPCancelPurchaseOrderDateTo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteAPCancelPurchaseOrderDateTo.BOSDataMember = "APCancelPurchaseOrderDateTo";
            this.fld_dteAPCancelPurchaseOrderDateTo.BOSDataSource = "APCancelPurchaseOrders";
            this.fld_dteAPCancelPurchaseOrderDateTo.BOSDescription = null;
            this.fld_dteAPCancelPurchaseOrderDateTo.BOSError = null;
            this.fld_dteAPCancelPurchaseOrderDateTo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteAPCancelPurchaseOrderDateTo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteAPCancelPurchaseOrderDateTo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteAPCancelPurchaseOrderDateTo.BOSPropertyName = "EditValue";
            this.fld_dteAPCancelPurchaseOrderDateTo.EditValue = null;
            resources.ApplyResources(this.fld_dteAPCancelPurchaseOrderDateTo, "fld_dteAPCancelPurchaseOrderDateTo");
            this.fld_dteAPCancelPurchaseOrderDateTo.Name = "fld_dteAPCancelPurchaseOrderDateTo";
            this.fld_dteAPCancelPurchaseOrderDateTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPCancelPurchaseOrderDateTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPCancelPurchaseOrderDateTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPCancelPurchaseOrderDateTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPCancelPurchaseOrderDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteAPCancelPurchaseOrderDateTo.Properties.Buttons"))))});
            this.fld_dteAPCancelPurchaseOrderDateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPCancelPurchaseOrderDateTo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteAPCancelPurchaseOrderDateTo, ((bool)(resources.GetObject("fld_dteAPCancelPurchaseOrderDateTo.ShowHelp"))));
            this.fld_dteAPCancelPurchaseOrderDateTo.Tag = "SC";
            // 
            // fld_lkeACObjectAccessKey
            // 
            this.fld_lkeACObjectAccessKey.BOSAllowAddNew = false;
            this.fld_lkeACObjectAccessKey.BOSAllowDummy = true;
            this.fld_lkeACObjectAccessKey.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACObjectAccessKey.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.BOSDataSource = "APCancelPurchaseOrders";
            this.fld_lkeACObjectAccessKey.BOSDescription = null;
            this.fld_lkeACObjectAccessKey.BOSError = null;
            this.fld_lkeACObjectAccessKey.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACObjectAccessKey.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACObjectAccessKey.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACObjectAccessKey.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACObjectAccessKey.BOSPropertyName = "EditValue";
            this.fld_lkeACObjectAccessKey.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACObjectAccessKey.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACObjectAccessKey.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeACObjectAccessKey, "fld_lkeACObjectAccessKey");
            this.fld_lkeACObjectAccessKey.Name = "fld_lkeACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeACObjectAccessKey.Properties.Buttons"))))});
            this.fld_lkeACObjectAccessKey.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeACObjectAccessKey.Properties.Columns"), resources.GetString("fld_lkeACObjectAccessKey.Properties.Columns1"), ((int)(resources.GetObject("fld_lkeACObjectAccessKey.Properties.Columns2"))), ((DevExpress.Utils.FormatType)(resources.GetObject("fld_lkeACObjectAccessKey.Properties.Columns3"))), global::Localization.ReportLocalizedResources.tutu, ((bool)(resources.GetObject("fld_lkeACObjectAccessKey.Properties.Columns4"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("fld_lkeACObjectAccessKey.Properties.Columns5")))),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeACObjectAccessKey.Properties.Columns6"), resources.GetString("fld_lkeACObjectAccessKey.Properties.Columns7"))});
            this.fld_lkeACObjectAccessKey.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeACObjectAccessKey.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACObjectAccessKey.Properties.PopupWidth = 40;
            this.fld_lkeACObjectAccessKey.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACObjectAccessKey.Properties.ValueMember = "ACObjectID";
            this.fld_lkeACObjectAccessKey.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeACObjectAccessKey, ((bool)(resources.GetObject("fld_lkeACObjectAccessKey.ShowHelp"))));
            this.fld_lkeACObjectAccessKey.Tag = "DC";
            // 
            // SMCPO100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.fld_lkeACObjectAccessKey);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_dgcAPCancelPurchaseOrder);
            this.Controls.Add(this.fld_lblLabel11);
            this.Controls.Add(this.fld_txtAPCancelPurchaseOrderNo);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtAPPurchaseOrderNo);
            this.Controls.Add(this.fld_lblLabel12);
            this.Controls.Add(this.fld_lblLabel13);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.fld_dteAPCancelPurchaseOrderDateFrom);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dteAPCancelPurchaseOrderDateTo);
            this.Name = "SMCPO100";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.fld_dteAPCancelPurchaseOrderDateTo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_dteAPCancelPurchaseOrderDateFrom, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel13, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel12, 0);
            this.Controls.SetChildIndex(this.fld_txtAPPurchaseOrderNo, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_txtAPCancelPurchaseOrderNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel11, 0);
            this.Controls.SetChildIndex(this.fld_dgcAPCancelPurchaseOrder, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeACObjectAccessKey, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPCancelPurchaseOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPCancelPurchaseOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPCancelPurchaseOrderDateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPCancelPurchaseOrderDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPCancelPurchaseOrderDateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPCancelPurchaseOrderDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSSearchResultsGridControl fld_dgcAPCancelPurchaseOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl;
        private BOSComponent.BOSLabel fld_lblLabel11;
        private BOSComponent.BOSTextBox fld_txtAPCancelPurchaseOrderNo;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseOrderNo;
        private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSLabel fld_lblLabel13;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSDateEdit fld_dteAPCancelPurchaseOrderDateFrom;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSDateEdit fld_dteAPCancelPurchaseOrderDateTo;
        private IContainer components;
        private AccObjectLookupEdit fld_lkeACObjectAccessKey;
	}
}
