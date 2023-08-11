using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Home.UI
{
	/// <summary>
    /// Summary description for DMHM108
	/// </summary>
    partial class DMHM108
	{
        private BOSComponent.BOSGroupControl fld_grcGroupControl;


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
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcARDeliveryPlanTruckPointsGridControl = new BOSERP.Modules.Home.ARDeliveryPlanTruckPointsGridControl();
            this.fld_dgvAPPurchaseOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_dteFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel61 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel62 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnShow = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlanTruckPointsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrders)).BeginInit();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTo.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcARDeliveryPlanTruckPointsGridControl);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 44);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 523);
            this.fld_grcGroupControl.TabIndex = 5;
            this.fld_grcGroupControl.Tag = global::Localization.ReportLocalizedResources.tutu;
            this.fld_grcGroupControl.Text = "Danh sách điểm giao hàng ";
            // 
            // fld_dgcARDeliveryPlanTruckPointsGridControl
            // 
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.AllowDrop = true;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSDataSource = "ARDeliveryPlanTruckPoints";
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSDescription = null;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSError = null;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSGridType = null;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.MainView = this.fld_dgvAPPurchaseOrders;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.Name = "fld_dgcARDeliveryPlanTruckPointsGridControl";
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.PrintReport = false;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.Screen = null;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.Size = new System.Drawing.Size(858, 499);
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.TabIndex = 6;
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.Tag = "DC";
            this.fld_dgcARDeliveryPlanTruckPointsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPPurchaseOrders});
            // 
            // fld_dgvAPPurchaseOrders
            // 
            this.fld_dgvAPPurchaseOrders.GridControl = this.fld_dgcARDeliveryPlanTruckPointsGridControl;
            this.fld_dgvAPPurchaseOrders.Name = "fld_dgvAPPurchaseOrders";
            this.fld_dgvAPPurchaseOrders.PaintStyleName = "Office2003";
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
            this.bosPanel2.Controls.Add(this.fld_dteFrom);
            this.bosPanel2.Controls.Add(this.fld_lblLabel61);
            this.bosPanel2.Controls.Add(this.fld_lblLabel62);
            this.bosPanel2.Controls.Add(this.fld_dteTo);
            this.bosPanel2.Controls.Add(this.fld_btnShow);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(862, 44);
            this.bosPanel2.TabIndex = 10;
            // 
            // fld_dteFrom
            // 
            this.fld_dteFrom.BOSComment = null;
            this.fld_dteFrom.BOSDataMember = "DateEdit";
            this.fld_dteFrom.BOSDataSource = null;
            this.fld_dteFrom.BOSDescription = null;
            this.fld_dteFrom.BOSError = null;
            this.fld_dteFrom.BOSFieldGroup = null;
            this.fld_dteFrom.BOSFieldRelation = null;
            this.fld_dteFrom.BOSPrivilege = null;
            this.fld_dteFrom.BOSPropertyName = "EditValue";
            this.fld_dteFrom.EditValue = null;
            this.fld_dteFrom.Location = new System.Drawing.Point(108, 12);
            this.fld_dteFrom.Name = "fld_dteFrom";
            this.fld_dteFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteFrom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteFrom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFrom.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteFrom, true);
            this.fld_dteFrom.Size = new System.Drawing.Size(150, 20);
            this.fld_dteFrom.TabIndex = 20;
            this.fld_dteFrom.Tag = "DC";
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
            this.fld_lblLabel62.Location = new System.Drawing.Point(294, 15);
            this.fld_lblLabel62.Name = "fld_lblLabel62";
            this.fld_lblLabel62.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel62, true);
            this.fld_lblLabel62.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel62.TabIndex = 18;
            this.fld_lblLabel62.Text = "Đến ngày";
            // 
            // fld_dteTo
            // 
            this.fld_dteTo.BOSComment = null;
            this.fld_dteTo.BOSDataMember = "DateEdit";
            this.fld_dteTo.BOSDataSource = null;
            this.fld_dteTo.BOSDescription = null;
            this.fld_dteTo.BOSError = null;
            this.fld_dteTo.BOSFieldGroup = null;
            this.fld_dteTo.BOSFieldRelation = null;
            this.fld_dteTo.BOSPrivilege = null;
            this.fld_dteTo.BOSPropertyName = "EditValue";
            this.fld_dteTo.EditValue = null;
            this.fld_dteTo.Location = new System.Drawing.Point(366, 12);
            this.fld_dteTo.Name = "fld_dteTo";
            this.fld_dteTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteTo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteTo, true);
            this.fld_dteTo.Size = new System.Drawing.Size(150, 20);
            this.fld_dteTo.TabIndex = 21;
            this.fld_dteTo.Tag = "DC";
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
            this.fld_btnShow.Location = new System.Drawing.Point(546, 8);
            this.fld_btnShow.Name = "fld_btnShow";
            this.fld_btnShow.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShow, true);
            this.fld_btnShow.Size = new System.Drawing.Size(75, 27);
            this.fld_btnShow.TabIndex = 19;
            this.fld_btnShow.Text = "Xem";
            this.fld_btnShow.Click += new System.EventHandler(this.fld_btnShow_Click);
            // 
            // DMHM108
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.bosPanel2);
            this.Name = "DMHM108";
            this.Text = "Theo dõi giao hàng";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDeliveryPlanTruckPointsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrders)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTo.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSDateEdit fld_dteFrom;
        private BOSComponent.BOSLabel fld_lblLabel61;
        private BOSComponent.BOSLabel fld_lblLabel62;
        private BOSComponent.BOSDateEdit fld_dteTo;
        private BOSComponent.BOSButton fld_btnShow;
        private ARDeliveryPlanTruckPointsGridControl fld_dgcARDeliveryPlanTruckPointsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPPurchaseOrders;
	}
}
