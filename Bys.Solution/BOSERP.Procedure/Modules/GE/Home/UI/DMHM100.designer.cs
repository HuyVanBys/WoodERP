using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Home.UI
{
	/// <summary>
	/// Summary description for DMHM100
	/// </summary>
	partial class DMHM100
	{
        private ARSaleOrdersGridControl fld_dgcARSaleOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrders;


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
            this.fld_dgcARSaleOrders = new BOSERP.Modules.Home.ARSaleOrdersGridControl();
            this.fld_dgvARSaleOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_dteSaleOrderFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel61 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel62 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSaleOrderToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnShow = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSaleOrderFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSaleOrderFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSaleOrderToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSaleOrderToDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcARSaleOrders
            // 
            this.fld_dgcARSaleOrders.AllowDrop = true;
            this.fld_dgcARSaleOrders.BOSComment = string.Empty;
            this.fld_dgcARSaleOrders.BOSDataMember = string.Empty;
            this.fld_dgcARSaleOrders.BOSDataSource = "ARSaleOrders";
            this.fld_dgcARSaleOrders.BOSDescription = null;
            this.fld_dgcARSaleOrders.BOSError = null;
            this.fld_dgcARSaleOrders.BOSFieldGroup = string.Empty;
            this.fld_dgcARSaleOrders.BOSFieldRelation = string.Empty;
            this.fld_dgcARSaleOrders.BOSGridType = null;
            this.fld_dgcARSaleOrders.BOSPrivilege = string.Empty;
            this.fld_dgcARSaleOrders.BOSPropertyName = string.Empty;
            this.fld_dgcARSaleOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARSaleOrders.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARSaleOrders.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcARSaleOrders.MainView = this.fld_dgvARSaleOrders;
            this.fld_dgcARSaleOrders.Name = "fld_dgcARSaleOrders";
            this.fld_dgcARSaleOrders.PrintReport = false;
            this.fld_dgcARSaleOrders.Screen = null;
            this.fld_dgcARSaleOrders.Size = new System.Drawing.Size(858, 493);
            this.fld_dgcARSaleOrders.TabIndex = 4;
            this.fld_dgcARSaleOrders.Tag = "DC";
            this.fld_dgcARSaleOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrders});
            // 
            // fld_dgvARSaleOrders
            // 
            this.fld_dgvARSaleOrders.GridControl = this.fld_dgcARSaleOrders;
            this.fld_dgvARSaleOrders.Name = "fld_dgvARSaleOrders";
            this.fld_dgvARSaleOrders.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.groupControl1);
            this.bosPanel1.Controls.Add(this.bosPanel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.fld_dgcARSaleOrders);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 50);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(862, 517);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Nhắc nhở giao hàng";
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
            this.bosPanel2.Controls.Add(this.fld_dteSaleOrderFromDate);
            this.bosPanel2.Controls.Add(this.fld_lblLabel61);
            this.bosPanel2.Controls.Add(this.fld_lblLabel62);
            this.bosPanel2.Controls.Add(this.fld_dteSaleOrderToDate);
            this.bosPanel2.Controls.Add(this.fld_btnShow);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(862, 50);
            this.bosPanel2.TabIndex = 5;
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
            this.fld_dteSaleOrderFromDate.Location = new System.Drawing.Point(90, 15);
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
            this.fld_lblLabel61.Location = new System.Drawing.Point(23, 18);
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
            this.fld_lblLabel62.Location = new System.Drawing.Point(267, 18);
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
            this.fld_dteSaleOrderToDate.Location = new System.Drawing.Point(339, 15);
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
            this.fld_btnShow.Location = new System.Drawing.Point(516, 12);
            this.fld_btnShow.Name = "fld_btnShow";
            this.fld_btnShow.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShow, true);
            this.fld_btnShow.Size = new System.Drawing.Size(75, 27);
            this.fld_btnShow.TabIndex = 3;
            this.fld_btnShow.Text = "Xem";
            this.fld_btnShow.Click += new System.EventHandler(this.fld_btnShow_Click);
            // 
            // DMHM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHM100";
            this.Text = "Nhắc nhở giao hàng";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSaleOrderFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSaleOrderFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSaleOrderToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSaleOrderToDate.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSDateEdit fld_dteSaleOrderFromDate;
        private BOSComponent.BOSLabel fld_lblLabel61;
        private BOSComponent.BOSLabel fld_lblLabel62;
        private BOSComponent.BOSDateEdit fld_dteSaleOrderToDate;
        private BOSComponent.BOSButton fld_btnShow;
        private DevExpress.XtraEditors.GroupControl groupControl1;
	}
}
