using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.SaleOrder.UI
{
	/// <summary>
	/// Summary description for DMSO101
	/// </summary>
	partial class DMSO101
	{
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private ARDocumentPaymentsGridControl fld_dgcARDocumentPayments;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARDocumentPayments;


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
            this.fld_dgcARDocumentPayments = new BOSERP.Modules.SaleOrder.ARDocumentPaymentsGridControl();
            this.fld_dgvARDocumentPayments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_btnAdd = new BOSComponent.BOSButton(this.components);
            this.fld_btnEdit = new BOSComponent.BOSButton(this.components);
            this.fld_btnDelete = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDocumentPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARDocumentPayments)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = "";
            this.fld_grcGroupControl.BOSDataSource = "";
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = "";
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = "";
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcARDocumentPayments);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 523);
            this.fld_grcGroupControl.TabIndex = 4;
            this.fld_grcGroupControl.Tag = "";
            this.fld_grcGroupControl.Text = "Thông tin lần đặt cọc";
            // 
            // fld_dgcARDocumentPayments
            // 
            this.fld_dgcARDocumentPayments.AllowDrop = true;
            this.fld_dgcARDocumentPayments.BOSComment = "";
            this.fld_dgcARDocumentPayments.BOSDataMember = "";
            this.fld_dgcARDocumentPayments.BOSDataSource = "ARDocumentPayments";
            this.fld_dgcARDocumentPayments.BOSDescription = null;
            this.fld_dgcARDocumentPayments.BOSError = null;
            this.fld_dgcARDocumentPayments.BOSFieldGroup = "";
            this.fld_dgcARDocumentPayments.BOSFieldRelation = "";
            this.fld_dgcARDocumentPayments.BOSGridType = null;
            this.fld_dgcARDocumentPayments.BOSPrivilege = "";
            this.fld_dgcARDocumentPayments.BOSPropertyName = "";
            this.fld_dgcARDocumentPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARDocumentPayments.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARDocumentPayments.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcARDocumentPayments.MainView = this.fld_dgvARDocumentPayments;
            this.fld_dgcARDocumentPayments.Name = "fld_dgcARDocumentPayments";
            this.fld_dgcARDocumentPayments.Screen = null;
            this.fld_dgcARDocumentPayments.Size = new System.Drawing.Size(858, 499);
            this.fld_dgcARDocumentPayments.TabIndex = 0;
            this.fld_dgcARDocumentPayments.Tag = "DC";
            this.fld_dgcARDocumentPayments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARDocumentPayments});
            // 
            // fld_dgvARDocumentPayments
            // 
            this.fld_dgvARDocumentPayments.GridControl = this.fld_dgcARDocumentPayments;
            this.fld_dgvARDocumentPayments.Name = "fld_dgvARDocumentPayments";
            this.fld_dgvARDocumentPayments.PaintStyleName = "Office2003";
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
            this.bosPanel1.Controls.Add(this.fld_btnPrint);
            this.bosPanel1.Controls.Add(this.fld_btnAdd);
            this.bosPanel1.Controls.Add(this.fld_btnEdit);
            this.bosPanel1.Controls.Add(this.fld_btnDelete);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bosPanel1.Location = new System.Drawing.Point(0, 523);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 44);
            this.bosPanel1.TabIndex = 9;
            // 
            // fld_btnPrint
            // 
            this.fld_btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnPrint.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnPrint.Appearance.Options.UseForeColor = true;
            this.fld_btnPrint.BOSComment = "";
            this.fld_btnPrint.BOSDataMember = "";
            this.fld_btnPrint.BOSDataSource = "";
            this.fld_btnPrint.BOSDescription = null;
            this.fld_btnPrint.BOSError = null;
            this.fld_btnPrint.BOSFieldGroup = "NonAction";
            this.fld_btnPrint.BOSFieldRelation = "";
            this.fld_btnPrint.BOSPrivilege = "";
            this.fld_btnPrint.BOSPropertyName = "";
            this.fld_btnPrint.Location = new System.Drawing.Point(509, 7);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(75, 27);
            this.fld_btnPrint.TabIndex = 1;
            this.fld_btnPrint.Tag = "";
            this.fld_btnPrint.Text = "In";
            this.fld_btnPrint.Click += new System.EventHandler(this.fld_btnPrint_Click);
            // 
            // fld_btnAdd
            // 
            this.fld_btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAdd.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAdd.Appearance.Options.UseForeColor = true;
            this.fld_btnAdd.BOSComment = "";
            this.fld_btnAdd.BOSDataMember = "";
            this.fld_btnAdd.BOSDataSource = "";
            this.fld_btnAdd.BOSDescription = null;
            this.fld_btnAdd.BOSError = null;
            this.fld_btnAdd.BOSFieldGroup = "NonAction;Deposit";
            this.fld_btnAdd.BOSFieldRelation = "";
            this.fld_btnAdd.BOSPrivilege = "";
            this.fld_btnAdd.BOSPropertyName = "";
            this.fld_btnAdd.Location = new System.Drawing.Point(600, 7);
            this.fld_btnAdd.Name = "fld_btnAdd";
            this.fld_btnAdd.Screen = null;
            this.fld_btnAdd.Size = new System.Drawing.Size(75, 27);
            this.fld_btnAdd.TabIndex = 2;
            this.fld_btnAdd.Tag = "";
            this.fld_btnAdd.Text = "Thêm";
            this.fld_btnAdd.Click += new System.EventHandler(this.fld_btnAdd_Click);
            // 
            // fld_btnEdit
            // 
            this.fld_btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnEdit.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnEdit.Appearance.Options.UseForeColor = true;
            this.fld_btnEdit.BOSComment = "";
            this.fld_btnEdit.BOSDataMember = "";
            this.fld_btnEdit.BOSDataSource = "";
            this.fld_btnEdit.BOSDescription = null;
            this.fld_btnEdit.BOSError = null;
            this.fld_btnEdit.BOSFieldGroup = "NonAction;Deposit";
            this.fld_btnEdit.BOSFieldRelation = "";
            this.fld_btnEdit.BOSPrivilege = "";
            this.fld_btnEdit.BOSPropertyName = "";
            this.fld_btnEdit.Location = new System.Drawing.Point(690, 6);
            this.fld_btnEdit.Name = "fld_btnEdit";
            this.fld_btnEdit.Screen = null;
            this.fld_btnEdit.Size = new System.Drawing.Size(75, 27);
            this.fld_btnEdit.TabIndex = 3;
            this.fld_btnEdit.Tag = "";
            this.fld_btnEdit.Text = "Sửa";
            this.fld_btnEdit.Click += new System.EventHandler(this.fld_btnEdit_Click);
            // 
            // fld_btnDelete
            // 
            this.fld_btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnDelete.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnDelete.Appearance.Options.UseForeColor = true;
            this.fld_btnDelete.BOSComment = "";
            this.fld_btnDelete.BOSDataMember = "";
            this.fld_btnDelete.BOSDataSource = "";
            this.fld_btnDelete.BOSDescription = null;
            this.fld_btnDelete.BOSError = null;
            this.fld_btnDelete.BOSFieldGroup = "NonAction;Deposit";
            this.fld_btnDelete.BOSFieldRelation = "";
            this.fld_btnDelete.BOSPrivilege = "";
            this.fld_btnDelete.BOSPropertyName = "";
            this.fld_btnDelete.Location = new System.Drawing.Point(781, 7);
            this.fld_btnDelete.Name = "fld_btnDelete";
            this.fld_btnDelete.Screen = null;
            this.fld_btnDelete.Size = new System.Drawing.Size(75, 27);
            this.fld_btnDelete.TabIndex = 4;
            this.fld_btnDelete.Tag = "";
            this.fld_btnDelete.Text = "Xóa";
            this.fld_btnDelete.Click += new System.EventHandler(this.fld_btnDelete_Click);
            // 
            // DMSO101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMSO101";
            this.Text = "Danh sách đặt cọc";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDocumentPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARDocumentPayments)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnAdd;
        private BOSComponent.BOSButton fld_btnEdit;
        private BOSComponent.BOSButton fld_btnDelete;
        private BOSComponent.BOSButton fld_btnPrint;
	}
}
