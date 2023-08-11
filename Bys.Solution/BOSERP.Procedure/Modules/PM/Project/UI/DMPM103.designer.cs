using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Project.UI
{
	/// <summary>
    /// Summary description for DMPM103
	/// </summary>
    partial class DMPM103
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
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcARSaleOrdersGridControl = new BOSERP.Modules.Project.ARSaleOrdersGridControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrdersGridControl)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_dgcARSaleOrdersGridControl);
            this.bosGroupControl2.Location = new System.Drawing.Point(3, 3);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(857, 593);
            this.bosGroupControl2.TabIndex = 4;
            this.bosGroupControl2.Text = "Danh sách đơn bán hàng";
            // 
            // fld_dgcARSaleOrdersGridControl
            // 
            this.fld_dgcARSaleOrdersGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARSaleOrdersGridControl.BOSComment = null;
            this.fld_dgcARSaleOrdersGridControl.BOSDataMember = null;
            this.fld_dgcARSaleOrdersGridControl.BOSDataSource = "ARSaleOrders";
            this.fld_dgcARSaleOrdersGridControl.BOSDescription = null;
            this.fld_dgcARSaleOrdersGridControl.BOSError = null;
            this.fld_dgcARSaleOrdersGridControl.BOSFieldGroup = null;
            this.fld_dgcARSaleOrdersGridControl.BOSFieldRelation = null;
            this.fld_dgcARSaleOrdersGridControl.BOSGridType = null;
            this.fld_dgcARSaleOrdersGridControl.BOSPrivilege = null;
            this.fld_dgcARSaleOrdersGridControl.BOSPropertyName = null;
            this.fld_dgcARSaleOrdersGridControl.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcARSaleOrdersGridControl.MenuManager = this.screenToolbar;
            this.fld_dgcARSaleOrdersGridControl.Name = "fld_dgcARSaleOrdersGridControl";
            this.fld_dgcARSaleOrdersGridControl.PrintReport = false;
            this.fld_dgcARSaleOrdersGridControl.Screen = null;
            this.fld_dgcARSaleOrdersGridControl.Size = new System.Drawing.Size(853, 566);
            this.fld_dgcARSaleOrdersGridControl.TabIndex = 0;
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
            this.bosPanel1.Controls.Add(this.bosGroupControl2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 599);
            this.bosPanel1.TabIndex = 6;
            // 
            // DMPM103
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 599);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPM103";
            this.Text = "Danh sách đơn bán hàng";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrdersGridControl)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private ARSaleOrdersGridControl fld_dgcARSaleOrdersGridControl;
        private BOSComponent.BOSPanel bosPanel1;
	}
}
