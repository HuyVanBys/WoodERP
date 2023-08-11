using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.RemindWorking.UI
{
	/// <summary>
	/// Summary description for DMRW100
	/// </summary>
	partial class DMRW100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMRW100));
            this.panel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.fld_chkRemindWorkingIsRead = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_btnSearchNew = new DevExpress.XtraEditors.SimpleButton();
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteRemindWorkingFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteRemindWorkingToDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.fld_dgcADRemindWorkingNewMessagesGridControl = new BOSERP.Modules.RemindWorking.ADRemindWorkingNewsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkRemindWorkingIsRead.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteRemindWorkingFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteRemindWorkingFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteRemindWorkingToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteRemindWorkingToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADRemindWorkingNewMessagesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BOSComment = null;
            this.panel1.BOSDataMember = null;
            this.panel1.BOSDataSource = null;
            this.panel1.BOSDescription = null;
            this.panel1.BOSError = null;
            this.panel1.BOSFieldGroup = null;
            this.panel1.BOSFieldRelation = null;
            this.panel1.BOSPrivilege = null;
            this.panel1.BOSPropertyName = null;
            this.panel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.panel1.Controls.Add(this.fld_btnRefresh);
            this.panel1.Controls.Add(this.fld_chkRemindWorkingIsRead);
            this.panel1.Controls.Add(this.fld_btnSearchNew);
            this.panel1.Controls.Add(this.bosLabel4);
            this.panel1.Controls.Add(this.fld_dteRemindWorkingFromDate);
            this.panel1.Controls.Add(this.fld_dteRemindWorkingToDate);
            this.panel1.Controls.Add(this.BOSLabel2);
            this.panel1.Controls.Add(this.BOSLabel1);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Screen = null;
            // 
            // fld_btnRefresh
            // 
            resources.ApplyResources(this.fld_btnRefresh, "fld_btnRefresh");
            this.fld_btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("fld_btnRefresh.Image")));
            this.fld_btnRefresh.Name = "fld_btnRefresh";
            this.ScreenHelper.SetShowHelp(this.fld_btnRefresh, ((bool)(resources.GetObject("fld_btnRefresh.ShowHelp"))));
            this.fld_btnRefresh.Click += new System.EventHandler(this.fld_btnRefresh_Click);
            // 
            // fld_chkRemindWorkingIsRead
            // 
            this.fld_chkRemindWorkingIsRead.BOSComment = null;
            this.fld_chkRemindWorkingIsRead.BOSDataMember = "ADRemindWorkingIsRead";
            this.fld_chkRemindWorkingIsRead.BOSDataSource = "ADRemindWorkings";
            this.fld_chkRemindWorkingIsRead.BOSDescription = null;
            this.fld_chkRemindWorkingIsRead.BOSError = null;
            this.fld_chkRemindWorkingIsRead.BOSFieldGroup = null;
            this.fld_chkRemindWorkingIsRead.BOSFieldRelation = null;
            this.fld_chkRemindWorkingIsRead.BOSPrivilege = null;
            this.fld_chkRemindWorkingIsRead.BOSPropertyName = "EditValue";
            resources.ApplyResources(this.fld_chkRemindWorkingIsRead, "fld_chkRemindWorkingIsRead");
            this.fld_chkRemindWorkingIsRead.MenuManager = this.screenToolbar;
            this.fld_chkRemindWorkingIsRead.Name = "fld_chkRemindWorkingIsRead";
            this.fld_chkRemindWorkingIsRead.Properties.Caption = resources.GetString("fld_chkRemindWorkingIsRead.Properties.Caption");
            this.fld_chkRemindWorkingIsRead.Screen = null;
            this.fld_chkRemindWorkingIsRead.Tag = "DC";
            // 
            // fld_btnSearchNew
            // 
            this.fld_btnSearchNew.Image = ((System.Drawing.Image)(resources.GetObject("fld_btnSearchNew.Image")));
            resources.ApplyResources(this.fld_btnSearchNew, "fld_btnSearchNew");
            this.fld_btnSearchNew.Name = "fld_btnSearchNew";
            this.fld_btnSearchNew.Click += new System.EventHandler(this.fld_btnSearchNew_Click);
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSDataMember = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSDataSource = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.bosLabel4.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel4, "bosLabel4");
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            // 
            // fld_dteRemindWorkingFromDate
            // 
            this.fld_dteRemindWorkingFromDate.BOSComment = null;
            this.fld_dteRemindWorkingFromDate.BOSDataMember = "ADRemindWorkingFromDate";
            this.fld_dteRemindWorkingFromDate.BOSDataSource = "ADRemindWorkings";
            this.fld_dteRemindWorkingFromDate.BOSDescription = null;
            this.fld_dteRemindWorkingFromDate.BOSError = null;
            this.fld_dteRemindWorkingFromDate.BOSFieldGroup = null;
            this.fld_dteRemindWorkingFromDate.BOSFieldRelation = null;
            this.fld_dteRemindWorkingFromDate.BOSPrivilege = null;
            this.fld_dteRemindWorkingFromDate.BOSPropertyName = null;
            this.fld_dteRemindWorkingFromDate.EditValue = null;
            resources.ApplyResources(this.fld_dteRemindWorkingFromDate, "fld_dteRemindWorkingFromDate");
            this.fld_dteRemindWorkingFromDate.Name = "fld_dteRemindWorkingFromDate";
            this.fld_dteRemindWorkingFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteRemindWorkingFromDate.Properties.Buttons"))))});
            this.fld_dteRemindWorkingFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteRemindWorkingFromDate.Screen = null;
            this.fld_dteRemindWorkingFromDate.Tag = "SC";
            // 
            // fld_dteRemindWorkingToDate
            // 
            this.fld_dteRemindWorkingToDate.BOSComment = null;
            this.fld_dteRemindWorkingToDate.BOSDataMember = "ADRemindWorkingToDate";
            this.fld_dteRemindWorkingToDate.BOSDataSource = "ADRemindWorkings";
            this.fld_dteRemindWorkingToDate.BOSDescription = null;
            this.fld_dteRemindWorkingToDate.BOSError = null;
            this.fld_dteRemindWorkingToDate.BOSFieldGroup = null;
            this.fld_dteRemindWorkingToDate.BOSFieldRelation = null;
            this.fld_dteRemindWorkingToDate.BOSPrivilege = null;
            this.fld_dteRemindWorkingToDate.BOSPropertyName = null;
            this.fld_dteRemindWorkingToDate.EditValue = null;
            resources.ApplyResources(this.fld_dteRemindWorkingToDate, "fld_dteRemindWorkingToDate");
            this.fld_dteRemindWorkingToDate.MenuManager = this.screenToolbar;
            this.fld_dteRemindWorkingToDate.Name = "fld_dteRemindWorkingToDate";
            this.fld_dteRemindWorkingToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_dteRemindWorkingToDate.Properties.Buttons"))))});
            this.fld_dteRemindWorkingToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteRemindWorkingToDate.Screen = null;
            this.fld_dteRemindWorkingToDate.Tag = "SC";
            // 
            // BOSLabel2
            // 
            this.BOSLabel2.BOSComment = null;
            this.BOSLabel2.BOSDataMember = null;
            this.BOSLabel2.BOSDataSource = null;
            this.BOSLabel2.BOSDescription = null;
            this.BOSLabel2.BOSError = null;
            this.BOSLabel2.BOSFieldGroup = null;
            this.BOSLabel2.BOSFieldRelation = null;
            this.BOSLabel2.BOSPrivilege = null;
            this.BOSLabel2.BOSPropertyName = null;
            resources.ApplyResources(this.BOSLabel2, "BOSLabel2");
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.BOSComment = null;
            this.BOSLabel1.BOSDataMember = null;
            this.BOSLabel1.BOSDataSource = null;
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = null;
            this.BOSLabel1.BOSFieldRelation = null;
            this.BOSLabel1.BOSPrivilege = null;
            this.BOSLabel1.BOSPropertyName = null;
            resources.ApplyResources(this.BOSLabel1, "BOSLabel1");
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            // 
            // groupControl1
            // 
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Controls.Add(this.fld_dgcADRemindWorkingNewMessagesGridControl);
            this.groupControl1.Name = "groupControl1";
            // 
            // fld_dgcADRemindWorkingNewMessagesGridControl
            // 
            this.fld_dgcADRemindWorkingNewMessagesGridControl.AllowDrop = true;
            this.fld_dgcADRemindWorkingNewMessagesGridControl.BOSComment = null;
            this.fld_dgcADRemindWorkingNewMessagesGridControl.BOSDataMember = null;
            this.fld_dgcADRemindWorkingNewMessagesGridControl.BOSDataSource = "ADRemindWorkings";
            this.fld_dgcADRemindWorkingNewMessagesGridControl.BOSDescription = null;
            this.fld_dgcADRemindWorkingNewMessagesGridControl.BOSError = null;
            this.fld_dgcADRemindWorkingNewMessagesGridControl.BOSFieldGroup = null;
            this.fld_dgcADRemindWorkingNewMessagesGridControl.BOSFieldRelation = null;
            this.fld_dgcADRemindWorkingNewMessagesGridControl.BOSGridType = null;
            this.fld_dgcADRemindWorkingNewMessagesGridControl.BOSPrivilege = null;
            this.fld_dgcADRemindWorkingNewMessagesGridControl.BOSPropertyName = null;
            resources.ApplyResources(this.fld_dgcADRemindWorkingNewMessagesGridControl, "fld_dgcADRemindWorkingNewMessagesGridControl");
            this.fld_dgcADRemindWorkingNewMessagesGridControl.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcADRemindWorkingNewMessagesGridControl.Name = "fld_dgcADRemindWorkingNewMessagesGridControl";
            this.fld_dgcADRemindWorkingNewMessagesGridControl.PrintReport = false;
            this.fld_dgcADRemindWorkingNewMessagesGridControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcADRemindWorkingNewMessagesGridControl, ((bool)(resources.GetObject("fld_dgcADRemindWorkingNewMessagesGridControl.ShowHelp"))));
            this.fld_dgcADRemindWorkingNewMessagesGridControl.Tag = "DC";
            this.fld_dgcADRemindWorkingNewMessagesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcADRemindWorkingNewMessagesGridControl;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ADRemindWorkings";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            resources.ApplyResources(this.fld_lkeFK_HREmployeeID, "fld_lkeFK_HREmployeeID");
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_HREmployeeID.Properties.Buttons"))))});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HREmployeeID.Properties.Columns"), resources.GetString("fld_lkeFK_HREmployeeID.Properties.Columns1"), ((int)(resources.GetObject("fld_lkeFK_HREmployeeID.Properties.Columns2"))), ((DevExpress.Utils.FormatType)(resources.GetObject("fld_lkeFK_HREmployeeID.Properties.Columns3"))), global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement, ((bool)(resources.GetObject("fld_lkeFK_HREmployeeID.Properties.Columns4"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("fld_lkeFK_HREmployeeID.Properties.Columns5")))),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_HREmployeeID.Properties.Columns6"), resources.GetString("fld_lkeFK_HREmployeeID.Properties.Columns7"))});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // DMRW100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel1);
            this.Name = "DMRW100";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkRemindWorkingIsRead.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteRemindWorkingFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteRemindWorkingFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteRemindWorkingToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteRemindWorkingToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADRemindWorkingNewMessagesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel panel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private BOSComponent.BOSDateEdit fld_dteRemindWorkingFromDate;
        private BOSComponent.BOSDateEdit fld_dteRemindWorkingToDate;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel bosLabel4;
        private DevExpress.XtraEditors.SimpleButton fld_btnSearchNew;
        private BOSComponent.BOSCheckEdit fld_chkRemindWorkingIsRead;
        private DevExpress.XtraEditors.SimpleButton fld_btnRefresh;
        private BOSERP.Modules.RemindWorking.ADRemindWorkingNewsGridControl fld_dgcADRemindWorkingNewMessagesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
	}
}
