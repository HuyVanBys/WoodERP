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
	partial class DMHM109
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
            this.fld_lkeARSaleOrderStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteSaleOrderFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel61 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel62 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSaleOrderToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnShow = new BOSComponent.BOSButton(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcSaleOrdersFilterGridControl = new BOSERP.Modules.Home.ARSaleOrderFiltersGridControl();
            this.fld_dgvGEHistoryDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_ckeSaleOrderIsReceiveBill = new BOSComponent.BOSCheckEdit(this.components);
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSaleOrderFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSaleOrderFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSaleOrderToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSaleOrderToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSaleOrdersFilterGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeSaleOrderIsReceiveBill.Properties)).BeginInit();
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
            this.bosPanel2.Controls.Add(this.fld_ckeSaleOrderIsReceiveBill);
            this.bosPanel2.Controls.Add(this.fld_lkeARSaleOrderStatus);
            this.bosPanel2.Controls.Add(this.fld_dteSaleOrderFromDate);
            this.bosPanel2.Controls.Add(this.bosLabel1);
            this.bosPanel2.Controls.Add(this.fld_lblLabel61);
            this.bosPanel2.Controls.Add(this.fld_lblLabel62);
            this.bosPanel2.Controls.Add(this.fld_dteSaleOrderToDate);
            this.bosPanel2.Controls.Add(this.fld_btnShow);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(862, 76);
            this.bosPanel2.TabIndex = 0;
            // 
            // fld_lkeARSaleOrderStatus
            // 
            this.fld_lkeARSaleOrderStatus.BOSAllowAddNew = false;
            this.fld_lkeARSaleOrderStatus.BOSAllowDummy = true;
            this.fld_lkeARSaleOrderStatus.BOSComment = null;
            this.fld_lkeARSaleOrderStatus.BOSDataMember = "ARSaleOrderStatus";
            this.fld_lkeARSaleOrderStatus.BOSDataSource = "ARSaleOrders";
            this.fld_lkeARSaleOrderStatus.BOSDescription = null;
            this.fld_lkeARSaleOrderStatus.BOSError = null;
            this.fld_lkeARSaleOrderStatus.BOSFieldGroup = null;
            this.fld_lkeARSaleOrderStatus.BOSFieldParent = null;
            this.fld_lkeARSaleOrderStatus.BOSFieldRelation = null;
            this.fld_lkeARSaleOrderStatus.BOSPrivilege = null;
            this.fld_lkeARSaleOrderStatus.BOSPropertyName = null;
            this.fld_lkeARSaleOrderStatus.BOSSelectType = null;
            this.fld_lkeARSaleOrderStatus.BOSSelectTypeValue = null;
            this.fld_lkeARSaleOrderStatus.CurrentDisplayText = null;
            this.fld_lkeARSaleOrderStatus.Location = new System.Drawing.Point(90, 38);
            this.fld_lkeARSaleOrderStatus.MenuManager = this.screenToolbar;
            this.fld_lkeARSaleOrderStatus.Name = "fld_lkeARSaleOrderStatus";
            this.fld_lkeARSaleOrderStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARSaleOrderStatus.Properties.NullText = string.Empty;
            this.fld_lkeARSaleOrderStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARSaleOrderStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeARSaleOrderStatus, true);
            this.fld_lkeARSaleOrderStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeARSaleOrderStatus.TabIndex = 2;
            this.fld_lkeARSaleOrderStatus.Tag = "DC";
            // 
            // fld_dteSaleOrderFromDate
            // 
            this.fld_dteSaleOrderFromDate.BOSComment = null;
            this.fld_dteSaleOrderFromDate.BOSDataMember = "DateEdit";
            this.fld_dteSaleOrderFromDate.BOSDataSource = string.Empty;
            this.fld_dteSaleOrderFromDate.BOSDescription = null;
            this.fld_dteSaleOrderFromDate.BOSError = null;
            this.fld_dteSaleOrderFromDate.BOSFieldGroup = null;
            this.fld_dteSaleOrderFromDate.BOSFieldRelation = null;
            this.fld_dteSaleOrderFromDate.BOSPrivilege = null;
            this.fld_dteSaleOrderFromDate.BOSPropertyName = "EditValue";
            this.fld_dteSaleOrderFromDate.EditValue = null;
            this.fld_dteSaleOrderFromDate.Location = new System.Drawing.Point(90, 12);
            this.fld_dteSaleOrderFromDate.Name = "fld_dteSaleOrderFromDate";
            this.fld_dteSaleOrderFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSaleOrderFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSaleOrderFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSaleOrderFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSaleOrderFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSaleOrderFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSaleOrderFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSaleOrderFromDate, true);
            this.fld_dteSaleOrderFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSaleOrderFromDate.TabIndex = 0;
            this.fld_dteSaleOrderFromDate.Tag = "DC";
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
            // fld_dteSaleOrderToDate
            // 
            this.fld_dteSaleOrderToDate.BOSComment = null;
            this.fld_dteSaleOrderToDate.BOSDataMember = "DateEdit";
            this.fld_dteSaleOrderToDate.BOSDataSource = string.Empty;
            this.fld_dteSaleOrderToDate.BOSDescription = null;
            this.fld_dteSaleOrderToDate.BOSError = null;
            this.fld_dteSaleOrderToDate.BOSFieldGroup = null;
            this.fld_dteSaleOrderToDate.BOSFieldRelation = null;
            this.fld_dteSaleOrderToDate.BOSPrivilege = null;
            this.fld_dteSaleOrderToDate.BOSPropertyName = "EditValue";
            this.fld_dteSaleOrderToDate.EditValue = null;
            this.fld_dteSaleOrderToDate.Location = new System.Drawing.Point(339, 12);
            this.fld_dteSaleOrderToDate.Name = "fld_dteSaleOrderToDate";
            this.fld_dteSaleOrderToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSaleOrderToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSaleOrderToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSaleOrderToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSaleOrderToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSaleOrderToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSaleOrderToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSaleOrderToDate, true);
            this.fld_dteSaleOrderToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSaleOrderToDate.TabIndex = 1;
            this.fld_dteSaleOrderToDate.Tag = "DC";
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
            this.fld_btnShow.TabIndex = 4;
            this.fld_btnShow.Text = "Xem";
            this.fld_btnShow.Click += new System.EventHandler(this.fld_btnShow_Click);
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = string.Empty;
            this.fld_grcGroupControl.BOSDataMember = string.Empty;
            this.fld_grcGroupControl.BOSDataSource = string.Empty;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = string.Empty;
            this.fld_grcGroupControl.BOSFieldRelation = string.Empty;
            this.fld_grcGroupControl.BOSPrivilege = string.Empty;
            this.fld_grcGroupControl.BOSPropertyName = string.Empty;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcSaleOrdersFilterGridControl);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 76);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 403);
            this.fld_grcGroupControl.TabIndex = 1;
            this.fld_grcGroupControl.Tag = string.Empty;
            this.fld_grcGroupControl.Text = "Danh sách đơn bán hàng";
            // 
            // fld_dgcSaleOrdersFilterGridControl
            // 
            this.fld_dgcSaleOrdersFilterGridControl.AllowDrop = true;
            this.fld_dgcSaleOrdersFilterGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcSaleOrdersFilterGridControl.BOSComment = string.Empty;
            this.fld_dgcSaleOrdersFilterGridControl.BOSDataMember = string.Empty;
            this.fld_dgcSaleOrdersFilterGridControl.BOSDataSource = "ARSaleOrders";
            this.fld_dgcSaleOrdersFilterGridControl.BOSDescription = null;
            this.fld_dgcSaleOrdersFilterGridControl.BOSError = null;
            this.fld_dgcSaleOrdersFilterGridControl.BOSFieldGroup = string.Empty;
            this.fld_dgcSaleOrdersFilterGridControl.BOSFieldRelation = string.Empty;
            this.fld_dgcSaleOrdersFilterGridControl.BOSGridType = null;
            this.fld_dgcSaleOrdersFilterGridControl.BOSPrivilege = string.Empty;
            this.fld_dgcSaleOrdersFilterGridControl.BOSPropertyName = string.Empty;
            this.fld_dgcSaleOrdersFilterGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcSaleOrdersFilterGridControl.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcSaleOrdersFilterGridControl.MainView = this.fld_dgvGEHistoryDetails;
            this.fld_dgcSaleOrdersFilterGridControl.Name = "fld_dgcSaleOrdersFilterGridControl";
            this.fld_dgcSaleOrdersFilterGridControl.PrintReport = false;
            this.fld_dgcSaleOrdersFilterGridControl.Screen = null;
            this.fld_dgcSaleOrdersFilterGridControl.Size = new System.Drawing.Size(858, 381);
            this.fld_dgcSaleOrdersFilterGridControl.TabIndex = 4;
            this.fld_dgcSaleOrdersFilterGridControl.Tag = "DC";
            this.fld_dgcSaleOrdersFilterGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGEHistoryDetails});
            // 
            // fld_dgvGEHistoryDetails
            // 
            this.fld_dgvGEHistoryDetails.GridControl = this.fld_dgcSaleOrdersFilterGridControl;
            this.fld_dgvGEHistoryDetails.Name = "fld_dgvGEHistoryDetails";
            this.fld_dgvGEHistoryDetails.PaintStyleName = "Office2003";
            // 
            // fld_ckeSaleOrderIsReceiveBill
            // 
            this.fld_ckeSaleOrderIsReceiveBill.BOSComment = null;
            this.fld_ckeSaleOrderIsReceiveBill.BOSDataMember = "";
            this.fld_ckeSaleOrderIsReceiveBill.BOSDataSource = "";
            this.fld_ckeSaleOrderIsReceiveBill.BOSDescription = null;
            this.fld_ckeSaleOrderIsReceiveBill.BOSError = null;
            this.fld_ckeSaleOrderIsReceiveBill.BOSFieldGroup = null;
            this.fld_ckeSaleOrderIsReceiveBill.BOSFieldRelation = null;
            this.fld_ckeSaleOrderIsReceiveBill.BOSPrivilege = null;
            this.fld_ckeSaleOrderIsReceiveBill.BOSPropertyName = "EditValue";
            this.fld_ckeSaleOrderIsReceiveBill.Location = new System.Drawing.Point(337, 38);
            this.fld_ckeSaleOrderIsReceiveBill.Name = "fld_ckeSaleOrderIsReceiveBill";
            this.fld_ckeSaleOrderIsReceiveBill.Properties.Caption = "Xuất hóa đơn";
            this.fld_ckeSaleOrderIsReceiveBill.Screen = null;
            this.fld_ckeSaleOrderIsReceiveBill.Size = new System.Drawing.Size(121, 19);
            this.fld_ckeSaleOrderIsReceiveBill.TabIndex = 3;
            this.fld_ckeSaleOrderIsReceiveBill.Tag = "DC";
            // 
            // DMHM109
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 479);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.bosPanel2);
            this.Name = "DMHM109";
            this.Text = "Thông tin đơn bán hàng";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARSaleOrderStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSaleOrderFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSaleOrderFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSaleOrderToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSaleOrderToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcSaleOrdersFilterGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeSaleOrderIsReceiveBill.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSDateEdit fld_dteSaleOrderFromDate;
        private BOSComponent.BOSLabel fld_lblLabel61;
        private BOSComponent.BOSLabel fld_lblLabel62;
        private BOSComponent.BOSDateEdit fld_dteSaleOrderToDate;
        private BOSComponent.BOSButton fld_btnShow;
        private IContainer components;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private ARSaleOrderFiltersGridControl fld_dgcSaleOrdersFilterGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGEHistoryDetails;
        private BOSLookupEdit fld_lkeARSaleOrderStatus;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSCheckEdit fld_ckeSaleOrderIsReceiveBill;
	}
}
