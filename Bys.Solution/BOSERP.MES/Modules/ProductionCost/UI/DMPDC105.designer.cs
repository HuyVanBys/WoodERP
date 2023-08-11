using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionCost.UI
{
	/// <summary>
    /// Summary description for DMPDC105
	/// </summary>
    partial class DMPDC105
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgcMMProductionCostOtherFees = new BOSERP.Modules.ProductionCost.MMProductionCostOtherFeesGridControl();
            this.fld_dgvMMProductionCostOveralls6271 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostOtherFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMProductionCostOveralls6271)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.fld_dgcMMProductionCostOtherFees);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 6;
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // gridView3
            // 
            this.gridView3.Name = "gridView3";
            // 
            // gridView5
            // 
            this.gridView5.Name = "gridView5";
            // 
            // gridView6
            // 
            this.gridView6.Name = "gridView6";
            // 
            // fld_dgcMMProductionCostOtherFees
            // 
            this.fld_dgcMMProductionCostOtherFees.AllowDrop = true;
            this.fld_dgcMMProductionCostOtherFees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductionCostOtherFees.BOSComment = null;
            this.fld_dgcMMProductionCostOtherFees.BOSDataMember = null;
            this.fld_dgcMMProductionCostOtherFees.BOSDataSource = "MMProductionCostOtherFees";
            this.fld_dgcMMProductionCostOtherFees.BOSDescription = "";
            this.fld_dgcMMProductionCostOtherFees.BOSError = null;
            this.fld_dgcMMProductionCostOtherFees.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostOtherFees.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostOtherFees.BOSGridType = null;
            this.fld_dgcMMProductionCostOtherFees.BOSPrivilege = null;
            this.fld_dgcMMProductionCostOtherFees.BOSPropertyName = null;
            this.fld_dgcMMProductionCostOtherFees.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionCostOtherFees.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcMMProductionCostOtherFees.MainView = this.fld_dgvMMProductionCostOveralls6271;
            this.fld_dgcMMProductionCostOtherFees.Name = "fld_dgcMMProductionCostOtherFees";
            this.fld_dgcMMProductionCostOtherFees.PrintReport = false;
            this.fld_dgcMMProductionCostOtherFees.Screen = null;
            this.fld_dgcMMProductionCostOtherFees.Size = new System.Drawing.Size(856, 561);
            this.fld_dgcMMProductionCostOtherFees.TabIndex = 376;
            this.fld_dgcMMProductionCostOtherFees.Tag = "DC";
            this.fld_dgcMMProductionCostOtherFees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvMMProductionCostOveralls6271});
            // 
            // fld_dgvMMProductionCostOveralls6271
            // 
            this.fld_dgvMMProductionCostOveralls6271.GridControl = this.fld_dgcMMProductionCostOtherFees;
            this.fld_dgvMMProductionCostOveralls6271.Name = "fld_dgvMMProductionCostOveralls6271";
            this.fld_dgvMMProductionCostOveralls6271.PaintStyleName = "Office2003";
            // 
            // DMPDC105
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPDC105";
            this.Text = "Chi phí khác";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostOtherFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMProductionCostOveralls6271)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private IContainer components;
        private MMProductionCostOtherFeesGridControl fld_dgcMMProductionCostOtherFees;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMProductionCostOveralls6271;
	}
}
