using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Home.UI
{
	/// <summary>
	/// Summary description for DMHM103
	/// </summary>
	partial class DMHM103
	{
		private BOSComponent.BOSDateEdit fld_dteFromDateEdit;
		private BOSComponent.BOSDateEdit fld_dteToDateEdit;
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
		private BOSComponent.BOSCheckEdit fld_chkCheckAllSaleOrder;
		private BOSComponent.BOSButton fld_btnAccept;
		private BOSComponent.BOSButton fld_btnShow;
        private GEHistoryDetailOfSaleOrdersGridControl fld_dgcChangeInvoices;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvChangeInvoices;


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
            this.fld_dteFromDateEdit = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteToDateEdit = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcChangeInvoices = new BOSERP.Modules.Home.GEHistoryDetailOfSaleOrdersGridControl();
            this.fld_dgvChangeInvoices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_chkCheckAllSaleOrder = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_btnAccept = new BOSComponent.BOSButton(this.components);
            this.fld_btnShow = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcChangeInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvChangeInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkCheckAllSaleOrder.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_dteFromDateEdit
            // 
            this.fld_dteFromDateEdit.BOSComment = "";
            this.fld_dteFromDateEdit.BOSDataMember = "DateEdit";
            this.fld_dteFromDateEdit.BOSDataSource = "";
            this.fld_dteFromDateEdit.BOSDescription = null;
            this.fld_dteFromDateEdit.BOSError = null;
            this.fld_dteFromDateEdit.BOSFieldGroup = "";
            this.fld_dteFromDateEdit.BOSFieldRelation = "";
            this.fld_dteFromDateEdit.BOSPrivilege = "";
            this.fld_dteFromDateEdit.BOSPropertyName = "EditValue";
            this.fld_dteFromDateEdit.EditValue = null;
            this.fld_dteFromDateEdit.Location = new System.Drawing.Point(102, 13);
            this.fld_dteFromDateEdit.Name = "fld_dteFromDateEdit";
            this.fld_dteFromDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteFromDateEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteFromDateEdit.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteFromDateEdit.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteFromDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFromDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFromDateEdit.Screen = null;
            this.fld_dteFromDateEdit.Size = new System.Drawing.Size(150, 20);
            this.fld_dteFromDateEdit.TabIndex = 4;
            this.fld_dteFromDateEdit.Tag = "DC";
            // 
            // fld_dteToDateEdit
            // 
            this.fld_dteToDateEdit.BOSComment = "";
            this.fld_dteToDateEdit.BOSDataMember = "DateEdit";
            this.fld_dteToDateEdit.BOSDataSource = "";
            this.fld_dteToDateEdit.BOSDescription = null;
            this.fld_dteToDateEdit.BOSError = null;
            this.fld_dteToDateEdit.BOSFieldGroup = "";
            this.fld_dteToDateEdit.BOSFieldRelation = "";
            this.fld_dteToDateEdit.BOSPrivilege = "";
            this.fld_dteToDateEdit.BOSPropertyName = "EditValue";
            this.fld_dteToDateEdit.EditValue = null;
            this.fld_dteToDateEdit.Location = new System.Drawing.Point(344, 13);
            this.fld_dteToDateEdit.Name = "fld_dteToDateEdit";
            this.fld_dteToDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteToDateEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteToDateEdit.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteToDateEdit.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteToDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteToDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteToDateEdit.Screen = null;
            this.fld_dteToDateEdit.Size = new System.Drawing.Size(150, 20);
            this.fld_dteToDateEdit.TabIndex = 5;
            this.fld_dteToDateEdit.Tag = "DC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = "";
            this.fld_lblLabel.Location = new System.Drawing.Point(41, 16);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel.TabIndex = 6;
            this.fld_lblLabel.Tag = "";
            this.fld_lblLabel.Text = "Từ ngày";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = "";
            this.fld_lblLabel1.BOSDataMember = "";
            this.fld_lblLabel1.BOSDataSource = "";
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = "";
            this.fld_lblLabel1.BOSFieldRelation = "";
            this.fld_lblLabel1.BOSPrivilege = "";
            this.fld_lblLabel1.BOSPropertyName = "";
            this.fld_lblLabel1.Location = new System.Drawing.Point(280, 16);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel1.TabIndex = 7;
            this.fld_lblLabel1.Tag = "";
            this.fld_lblLabel1.Text = "Đến ngày";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = "";
            this.fld_grcGroupControl1.BOSDataMember = "";
            this.fld_grcGroupControl1.BOSDataSource = "";
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = "";
            this.fld_grcGroupControl1.BOSFieldRelation = "";
            this.fld_grcGroupControl1.BOSPrivilege = "";
            this.fld_grcGroupControl1.BOSPropertyName = "";
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcChangeInvoices);
            this.fld_grcGroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(0, 50);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(862, 474);
            this.fld_grcGroupControl1.TabIndex = 9;
            this.fld_grcGroupControl1.Tag = "";
            this.fld_grcGroupControl1.Text = "Danh sách thông tin đơn hàng thay đổi";
            // 
            // fld_dgcChangeInvoices
            // 
            this.fld_dgcChangeInvoices.AllowDrop = true;
            this.fld_dgcChangeInvoices.BOSComment = "";
            this.fld_dgcChangeInvoices.BOSDataMember = "";
            this.fld_dgcChangeInvoices.BOSDataSource = "GEHistoryDetails";
            this.fld_dgcChangeInvoices.BOSDescription = null;
            this.fld_dgcChangeInvoices.BOSError = null;
            this.fld_dgcChangeInvoices.BOSFieldGroup = "";
            this.fld_dgcChangeInvoices.BOSFieldRelation = "";
            this.fld_dgcChangeInvoices.BOSGridType = null;
            this.fld_dgcChangeInvoices.BOSPrivilege = "";
            this.fld_dgcChangeInvoices.BOSPropertyName = "";
            this.fld_dgcChangeInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcChangeInvoices.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcChangeInvoices.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcChangeInvoices.MainView = this.fld_dgvChangeInvoices;
            this.fld_dgcChangeInvoices.Name = "fld_dgcChangeInvoices";
            this.fld_dgcChangeInvoices.Screen = null;
            this.fld_dgcChangeInvoices.Size = new System.Drawing.Size(858, 450);
            this.fld_dgcChangeInvoices.TabIndex = 10;
            this.fld_dgcChangeInvoices.Tag = "DC";
            this.fld_dgcChangeInvoices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvChangeInvoices});
            // 
            // fld_dgvChangeInvoices
            // 
            this.fld_dgvChangeInvoices.GridControl = this.fld_dgcChangeInvoices;
            this.fld_dgvChangeInvoices.Name = "fld_dgvChangeInvoices";
            this.fld_dgvChangeInvoices.PaintStyleName = "Office2003";
            // 
            // fld_chkCheckAllSaleOrder
            // 
            this.fld_chkCheckAllSaleOrder.BOSComment = "";
            this.fld_chkCheckAllSaleOrder.BOSDataMember = "";
            this.fld_chkCheckAllSaleOrder.BOSDataSource = "";
            this.fld_chkCheckAllSaleOrder.BOSDescription = null;
            this.fld_chkCheckAllSaleOrder.BOSError = null;
            this.fld_chkCheckAllSaleOrder.BOSFieldGroup = "";
            this.fld_chkCheckAllSaleOrder.BOSFieldRelation = "";
            this.fld_chkCheckAllSaleOrder.BOSPrivilege = "";
            this.fld_chkCheckAllSaleOrder.BOSPropertyName = "";
            this.fld_chkCheckAllSaleOrder.Location = new System.Drawing.Point(12, 12);
            this.fld_chkCheckAllSaleOrder.Name = "fld_chkCheckAllSaleOrder";
            this.fld_chkCheckAllSaleOrder.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkCheckAllSaleOrder.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkCheckAllSaleOrder.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkCheckAllSaleOrder.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkCheckAllSaleOrder.Properties.Caption = "Chọn tất cả";
            this.fld_chkCheckAllSaleOrder.Screen = null;
            this.fld_chkCheckAllSaleOrder.Size = new System.Drawing.Size(80, 19);
            this.fld_chkCheckAllSaleOrder.TabIndex = 11;
            this.fld_chkCheckAllSaleOrder.Tag = "DC";
            this.fld_chkCheckAllSaleOrder.CheckedChanged += new System.EventHandler(this.fld_chkCheckAllSaleOrder_CheckedChanged);
            // 
            // fld_btnAccept
            // 
            this.fld_btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAccept.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAccept.Appearance.Options.UseForeColor = true;
            this.fld_btnAccept.BOSComment = "";
            this.fld_btnAccept.BOSDataMember = "";
            this.fld_btnAccept.BOSDataSource = "";
            this.fld_btnAccept.BOSDescription = null;
            this.fld_btnAccept.BOSError = null;
            this.fld_btnAccept.BOSFieldGroup = "";
            this.fld_btnAccept.BOSFieldRelation = "";
            this.fld_btnAccept.BOSPrivilege = "";
            this.fld_btnAccept.BOSPropertyName = "";
            this.fld_btnAccept.Location = new System.Drawing.Point(775, 8);
            this.fld_btnAccept.Name = "fld_btnAccept";
            this.fld_btnAccept.Screen = null;
            this.fld_btnAccept.Size = new System.Drawing.Size(75, 27);
            this.fld_btnAccept.TabIndex = 12;
            this.fld_btnAccept.Tag = "";
            this.fld_btnAccept.Text = "Duyệt";
            this.fld_btnAccept.Click += new System.EventHandler(this.fld_btnAccept_Click);
            // 
            // fld_btnShow
            // 
            this.fld_btnShow.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnShow.Appearance.Options.UseForeColor = true;
            this.fld_btnShow.BOSComment = "";
            this.fld_btnShow.BOSDataMember = "";
            this.fld_btnShow.BOSDataSource = "";
            this.fld_btnShow.BOSDescription = null;
            this.fld_btnShow.BOSError = null;
            this.fld_btnShow.BOSFieldGroup = "";
            this.fld_btnShow.BOSFieldRelation = "";
            this.fld_btnShow.BOSPrivilege = "";
            this.fld_btnShow.BOSPropertyName = "";
            this.fld_btnShow.Location = new System.Drawing.Point(533, 9);
            this.fld_btnShow.Name = "fld_btnShow";
            this.fld_btnShow.Screen = null;
            this.fld_btnShow.Size = new System.Drawing.Size(75, 27);
            this.fld_btnShow.TabIndex = 8;
            this.fld_btnShow.Tag = "";
            this.fld_btnShow.Text = "Xem";
            this.fld_btnShow.Click += new System.EventHandler(this.fld_btnShow_Click);
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
            this.bosPanel1.Controls.Add(this.fld_dteFromDateEdit);
            this.bosPanel1.Controls.Add(this.fld_btnShow);
            this.bosPanel1.Controls.Add(this.fld_lblLabel1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel);
            this.bosPanel1.Controls.Add(this.fld_dteToDateEdit);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 50);
            this.bosPanel1.TabIndex = 13;
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
            this.bosPanel2.Controls.Add(this.fld_btnAccept);
            this.bosPanel2.Controls.Add(this.fld_chkCheckAllSaleOrder);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bosPanel2.Location = new System.Drawing.Point(0, 524);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(862, 43);
            this.bosPanel2.TabIndex = 14;
            // 
            // DMHM103
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_grcGroupControl1);
            this.Controls.Add(this.bosPanel2);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHM103";
            this.Text = "Thông tin đơn hàng thay đổi";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFromDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteToDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcChangeInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvChangeInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkCheckAllSaleOrder.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.bosPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPanel bosPanel2;
	}
}
