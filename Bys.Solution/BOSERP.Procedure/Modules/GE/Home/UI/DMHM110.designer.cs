using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSComponent;

namespace BOSERP.Modules.Home.UI
{
	/// <summary>
	/// Summary description for DMHM104
	/// </summary>
	partial class DMHM110
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
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeAPPurchaseOrderStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dtePurchaseOrdersFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel61 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel62 = new BOSComponent.BOSLabel(this.components);
            this.fld_dtePurchaseOrderToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnShow = new BOSComponent.BOSButton(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcPurchaseOrderFilterGridControl = new BOSERP.Modules.Home.APPurchaseOrderFiltersGridControl();
            this.fld_dgvGEHistoryDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseOrderStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePurchaseOrdersFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePurchaseOrdersFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePurchaseOrderToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePurchaseOrderToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPurchaseOrderFilterGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel2.Controls.Add(this.fld_lkeAPPurchaseOrderStatus);
            this.bosPanel2.Controls.Add(this.fld_dtePurchaseOrdersFromDate);
            this.bosPanel2.Controls.Add(this.bosLabel1);
            this.bosPanel2.Controls.Add(this.fld_lblLabel61);
            this.bosPanel2.Controls.Add(this.fld_lblLabel62);
            this.bosPanel2.Controls.Add(this.fld_dtePurchaseOrderToDate);
            this.bosPanel2.Controls.Add(this.fld_btnShow);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(862, 76);
            this.bosPanel2.TabIndex = 0;
            // 
            // fld_lkeAPPurchaseOrderStatus
            // 
            this.fld_lkeAPPurchaseOrderStatus.BOSAllowAddNew = false;
            this.fld_lkeAPPurchaseOrderStatus.BOSAllowDummy = true;
            this.fld_lkeAPPurchaseOrderStatus.BOSComment = null;
            this.fld_lkeAPPurchaseOrderStatus.BOSDataMember = "APPurchaseOrderStatus";
            this.fld_lkeAPPurchaseOrderStatus.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeAPPurchaseOrderStatus.BOSDescription = null;
            this.fld_lkeAPPurchaseOrderStatus.BOSError = null;
            this.fld_lkeAPPurchaseOrderStatus.BOSFieldGroup = null;
            this.fld_lkeAPPurchaseOrderStatus.BOSFieldParent = null;
            this.fld_lkeAPPurchaseOrderStatus.BOSFieldRelation = null;
            this.fld_lkeAPPurchaseOrderStatus.BOSPrivilege = null;
            this.fld_lkeAPPurchaseOrderStatus.BOSPropertyName = null;
            this.fld_lkeAPPurchaseOrderStatus.BOSSelectType = null;
            this.fld_lkeAPPurchaseOrderStatus.BOSSelectTypeValue = null;
            this.fld_lkeAPPurchaseOrderStatus.CurrentDisplayText = null;
            this.fld_lkeAPPurchaseOrderStatus.Location = new System.Drawing.Point(90, 38);
            this.fld_lkeAPPurchaseOrderStatus.MenuManager = this.screenToolbar;
            this.fld_lkeAPPurchaseOrderStatus.Name = "fld_lkeAPPurchaseOrderStatus";
            this.fld_lkeAPPurchaseOrderStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPPurchaseOrderStatus.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeAPPurchaseOrderStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPPurchaseOrderStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPPurchaseOrderStatus, true);
            this.fld_lkeAPPurchaseOrderStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPPurchaseOrderStatus.TabIndex = 2;
            this.fld_lkeAPPurchaseOrderStatus.Tag = "DC";
            // 
            // fld_dtePurchaseOrdersFromDate
            // 
            this.fld_dtePurchaseOrdersFromDate.BOSComment = null;
            this.fld_dtePurchaseOrdersFromDate.BOSDataMember = "DateEdit";
            this.fld_dtePurchaseOrdersFromDate.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dtePurchaseOrdersFromDate.BOSDescription = null;
            this.fld_dtePurchaseOrdersFromDate.BOSError = null;
            this.fld_dtePurchaseOrdersFromDate.BOSFieldGroup = null;
            this.fld_dtePurchaseOrdersFromDate.BOSFieldRelation = null;
            this.fld_dtePurchaseOrdersFromDate.BOSPrivilege = null;
            this.fld_dtePurchaseOrdersFromDate.BOSPropertyName = "EditValue";
            this.fld_dtePurchaseOrdersFromDate.EditValue = null;
            this.fld_dtePurchaseOrdersFromDate.Location = new System.Drawing.Point(90, 12);
            this.fld_dtePurchaseOrdersFromDate.Name = "fld_dtePurchaseOrdersFromDate";
            this.fld_dtePurchaseOrdersFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtePurchaseOrdersFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtePurchaseOrdersFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtePurchaseOrdersFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtePurchaseOrdersFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtePurchaseOrdersFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtePurchaseOrdersFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dtePurchaseOrdersFromDate, true);
            this.fld_dtePurchaseOrdersFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dtePurchaseOrdersFromDate.TabIndex = 0;
            this.fld_dtePurchaseOrdersFromDate.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(23, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(49, 13);
            this.bosLabel1.TabIndex = 17;
            this.bosLabel1.Text = "Trạng thái";
            // 
            // fld_lblLabel61
            // 
            this.fld_lblLabel61.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel61.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel61.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel61.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel61.BOSComment = null;
            this.fld_lblLabel61.BOSDataMember = null;
            this.fld_lblLabel61.BOSDataSource = null;
            this.fld_lblLabel61.BOSDescription = null;
            this.fld_lblLabel61.BOSError = null;
            this.fld_lblLabel61.BOSFieldGroup = null;
            this.fld_lblLabel61.BOSFieldRelation = null;
            this.fld_lblLabel61.BOSPrivilege = null;
            this.fld_lblLabel61.BOSPropertyName = null;
            this.fld_lblLabel61.Location = new System.Drawing.Point(23, 15);
            this.fld_lblLabel61.Name = "fld_lblLabel61";
            this.fld_lblLabel61.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel61, true);
            this.fld_lblLabel61.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel61.TabIndex = 17;
            this.fld_lblLabel61.Text = "Từ ngày";
            // 
            // fld_lblLabel62
            // 
            this.fld_lblLabel62.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel62.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel62.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel62.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel62.BOSComment = null;
            this.fld_lblLabel62.BOSDataMember = null;
            this.fld_lblLabel62.BOSDataSource = null;
            this.fld_lblLabel62.BOSDescription = null;
            this.fld_lblLabel62.BOSError = null;
            this.fld_lblLabel62.BOSFieldGroup = null;
            this.fld_lblLabel62.BOSFieldRelation = null;
            this.fld_lblLabel62.BOSPrivilege = null;
            this.fld_lblLabel62.BOSPropertyName = null;
            this.fld_lblLabel62.Location = new System.Drawing.Point(267, 15);
            this.fld_lblLabel62.Name = "fld_lblLabel62";
            this.fld_lblLabel62.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel62, true);
            this.fld_lblLabel62.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel62.TabIndex = 18;
            this.fld_lblLabel62.Text = "Đến ngày";
            // 
            // fld_dtePurchaseOrderToDate
            // 
            this.fld_dtePurchaseOrderToDate.BOSComment = null;
            this.fld_dtePurchaseOrderToDate.BOSDataMember = "DateEdit";
            this.fld_dtePurchaseOrderToDate.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dtePurchaseOrderToDate.BOSDescription = null;
            this.fld_dtePurchaseOrderToDate.BOSError = null;
            this.fld_dtePurchaseOrderToDate.BOSFieldGroup = null;
            this.fld_dtePurchaseOrderToDate.BOSFieldRelation = null;
            this.fld_dtePurchaseOrderToDate.BOSPrivilege = null;
            this.fld_dtePurchaseOrderToDate.BOSPropertyName = "EditValue";
            this.fld_dtePurchaseOrderToDate.EditValue = null;
            this.fld_dtePurchaseOrderToDate.Location = new System.Drawing.Point(339, 12);
            this.fld_dtePurchaseOrderToDate.Name = "fld_dtePurchaseOrderToDate";
            this.fld_dtePurchaseOrderToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtePurchaseOrderToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtePurchaseOrderToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtePurchaseOrderToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtePurchaseOrderToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtePurchaseOrderToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtePurchaseOrderToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dtePurchaseOrderToDate, true);
            this.fld_dtePurchaseOrderToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dtePurchaseOrderToDate.TabIndex = 1;
            this.fld_dtePurchaseOrderToDate.Tag = "DC";
            // 
            // fld_btnShow
            // 
            this.fld_btnShow.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnShow.Appearance.Options.UseForeColor = true;
            this.fld_btnShow.BOSComment = null;
            this.fld_btnShow.BOSDataMember = null;
            this.fld_btnShow.BOSDataSource = null;
            this.fld_btnShow.BOSDescription = null;
            this.fld_btnShow.BOSError = null;
            this.fld_btnShow.BOSFieldGroup = null;
            this.fld_btnShow.BOSFieldRelation = null;
            this.fld_btnShow.BOSPrivilege = null;
            this.fld_btnShow.BOSPropertyName = null;
            this.fld_btnShow.Location = new System.Drawing.Point(538, 9);
            this.fld_btnShow.Name = "fld_btnShow";
            this.fld_btnShow.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShow, true);
            this.fld_btnShow.Size = new System.Drawing.Size(75, 27);
            this.fld_btnShow.TabIndex = 3;
            this.fld_btnShow.Text = "Xem";
            this.fld_btnShow.Click += new System.EventHandler(this.fld_btnShow_Click);
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcPurchaseOrderFilterGridControl);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 76);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 403);
            this.fld_grcGroupControl.TabIndex = 1;
            this.fld_grcGroupControl.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.Text = "Danh sách đơn bán hàng";
            // 
            // fld_dgcPurchaseOrderFilterGridControl
            // 
            this.fld_dgcPurchaseOrderFilterGridControl.AllowDrop = true;
            this.fld_dgcPurchaseOrderFilterGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPurchaseOrderFilterGridControl.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcPurchaseOrderFilterGridControl.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcPurchaseOrderFilterGridControl.BOSDataSource = "APPurchaseOrders";
            this.fld_dgcPurchaseOrderFilterGridControl.BOSDescription = null;
            this.fld_dgcPurchaseOrderFilterGridControl.BOSError = null;
            this.fld_dgcPurchaseOrderFilterGridControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcPurchaseOrderFilterGridControl.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcPurchaseOrderFilterGridControl.BOSGridType = null;
            this.fld_dgcPurchaseOrderFilterGridControl.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcPurchaseOrderFilterGridControl.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcPurchaseOrderFilterGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcPurchaseOrderFilterGridControl.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcPurchaseOrderFilterGridControl.MainView = this.fld_dgvGEHistoryDetails;
            this.fld_dgcPurchaseOrderFilterGridControl.Name = "fld_dgcPurchaseOrderFilterGridControl";
            this.fld_dgcPurchaseOrderFilterGridControl.PrintReport = false;
            this.fld_dgcPurchaseOrderFilterGridControl.Screen = null;
            this.fld_dgcPurchaseOrderFilterGridControl.Size = new System.Drawing.Size(858, 381);
            this.fld_dgcPurchaseOrderFilterGridControl.TabIndex = 4;
            this.fld_dgcPurchaseOrderFilterGridControl.Tag = "DC";
            this.fld_dgcPurchaseOrderFilterGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGEHistoryDetails});
            // 
            // fld_dgvGEHistoryDetails
            // 
            this.fld_dgvGEHistoryDetails.GridControl = this.fld_dgcPurchaseOrderFilterGridControl;
            this.fld_dgvGEHistoryDetails.Name = "fld_dgvGEHistoryDetails";
            this.fld_dgvGEHistoryDetails.PaintStyleName = "Office2003";
            // 
            // DMHM110
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 479);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.bosPanel2);
            this.Name = "DMHM110";
            this.Text = "Thông tin đơn mua hàng";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPPurchaseOrderStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePurchaseOrdersFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePurchaseOrdersFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePurchaseOrderToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePurchaseOrderToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPurchaseOrderFilterGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSDateEdit fld_dtePurchaseOrdersFromDate;
        private BOSComponent.BOSLabel fld_lblLabel61;
        private BOSComponent.BOSLabel fld_lblLabel62;
        private BOSComponent.BOSDateEdit fld_dtePurchaseOrderToDate;
        private BOSComponent.BOSButton fld_btnShow;
        private IContainer components;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private APPurchaseOrderFiltersGridControl fld_dgcPurchaseOrderFilterGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGEHistoryDetails;
        private BOSLookupEdit fld_lkeAPPurchaseOrderStatus;
        private BOSComponent.BOSLabel bosLabel1;
	}
}
