using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.InvBalance.UI
{
	/// <summary>
    /// Summary description for DMINVB100
	/// </summary>
    partial class DMINVB100
	{
        private ICInvBalancesGridControl fld_dgcICInvBalances;
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
            this.fld_dgcICInvBalances = new BOSERP.Modules.InvBalance.ICInvBalancesGridControl();
            this.fld_dgvARSaleOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICInvBalances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_dgcICInvBalances
            // 
            this.fld_dgcICInvBalances.AllowDrop = true;
            this.fld_dgcICInvBalances.BOSComment = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcICInvBalances.BOSDataMember = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcICInvBalances.BOSDataSource = "ICInvBalances";
            this.fld_dgcICInvBalances.BOSDescription = null;
            this.fld_dgcICInvBalances.BOSError = null;
            this.fld_dgcICInvBalances.BOSFieldGroup = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcICInvBalances.BOSFieldRelation = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcICInvBalances.BOSGridType = null;
            this.fld_dgcICInvBalances.BOSPrivilege = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcICInvBalances.BOSPropertyName = global::Localization.ReportLocalizedResources.String2;
            this.fld_dgcICInvBalances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICInvBalances.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICInvBalances.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcICInvBalances.MainView = this.fld_dgvARSaleOrders;
            this.fld_dgcICInvBalances.Name = "fld_dgcICInvBalances";
            this.fld_dgcICInvBalances.PrintReport = false;
            this.fld_dgcICInvBalances.Screen = null;
            this.fld_dgcICInvBalances.Size = new System.Drawing.Size(862, 567);
            this.fld_dgcICInvBalances.TabIndex = 4;
            this.fld_dgcICInvBalances.Tag = "DC";
            this.fld_dgcICInvBalances.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrders});
            // 
            // fld_dgvARSaleOrders
            // 
            this.fld_dgvARSaleOrders.GridControl = this.fld_dgcICInvBalances;
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
            this.bosPanel1.Controls.Add(this.fld_dgcICInvBalances);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 6;
            // 
            // DMINVB100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMINVB100";
            this.ShowIcon = false;
            this.Text = "Cập nhật số dư tồn kho đầu kỳ";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICInvBalances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrders)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
	}
}
