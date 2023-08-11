using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ACBalance.UI
{
	/// <summary>
    /// Summary description for DMINVB100
	/// </summary>
    partial class DMACBL100
	{
        private ACBalancesGridControl fld_dgcACBalances;
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
            this.fld_dgcACBalances = new BOSERP.Modules.ACBalance.ACBalancesGridControl();
            this.fld_dgvARSaleOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACBalances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_dgcACBalances
            // 
            this.fld_dgcACBalances.AllowDrop = true;
            this.fld_dgcACBalances.BOSComment = string.Empty;
            this.fld_dgcACBalances.BOSDataMember = string.Empty;
            this.fld_dgcACBalances.BOSDataSource = "ACBalances";
            this.fld_dgcACBalances.BOSDescription = null;
            this.fld_dgcACBalances.BOSError = null;
            this.fld_dgcACBalances.BOSFieldGroup = string.Empty;
            this.fld_dgcACBalances.BOSFieldRelation = string.Empty;
            this.fld_dgcACBalances.BOSGridType = null;
            this.fld_dgcACBalances.BOSPrivilege = string.Empty;
            this.fld_dgcACBalances.BOSPropertyName = string.Empty;
            this.fld_dgcACBalances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACBalances.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACBalances.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACBalances.MainView = this.fld_dgvARSaleOrders;
            this.fld_dgcACBalances.Name = "fld_dgcACBalances";
            this.fld_dgcACBalances.PrintReport = false;
            this.fld_dgcACBalances.Screen = null;
            this.fld_dgcACBalances.Size = new System.Drawing.Size(862, 567);
            this.fld_dgcACBalances.TabIndex = 4;
            this.fld_dgcACBalances.Tag = "DC";
            this.fld_dgcACBalances.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrders});
            // 
            // fld_dgvARSaleOrders
            // 
            this.fld_dgvARSaleOrders.GridControl = this.fld_dgcACBalances;
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
            this.bosPanel1.Controls.Add(this.fld_dgcACBalances);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 6;
            // 
            // DMACBL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMACBL100";
            this.ShowIcon = false;
            this.Text = "Cập nhật số dư tài khoản đầu kỳ";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACBalances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
	}
}
