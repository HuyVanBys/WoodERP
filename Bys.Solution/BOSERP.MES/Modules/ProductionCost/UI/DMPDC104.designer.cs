using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.MES.Modules.ProductionCost.UI
{
	/// <summary>
	/// Summary description for DMPDC104
	/// </summary>
	partial class DMPDC104
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
            this.fld_btnUpdateProductUnitCost = new BOSComponent.BOSButton(this.components);
            this.fld_btnApplyPrice = new BOSComponent.BOSButton(this.components);
            this.fld_tabProductPriceList = new BOSComponent.BOSTabControl(this.components);
            this.xrTabProductPrice = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductPrices = new BOSERP.MES.Modules.ProductionCost.MMProductPricesGridControl();
            this.fld_dgvMMProductPrices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xrUnfinishedProductPrice = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductPriceIncompletes = new BOSERP.MES.Modules.ProductionCost.MMProductPriceIncompletesGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductPriceList)).BeginInit();
            this.fld_tabProductPriceList.SuspendLayout();
            this.xrTabProductPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMProductPrices)).BeginInit();
            this.xrUnfinishedProductPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductPriceIncompletes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_btnUpdateProductUnitCost);
            this.bosPanel1.Controls.Add(this.fld_btnApplyPrice);
            this.bosPanel1.Controls.Add(this.fld_tabProductPriceList);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_btnUpdateProductUnitCost
            // 
            this.fld_btnUpdateProductUnitCost.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnUpdateProductUnitCost.Appearance.Options.UseForeColor = true;
            this.fld_btnUpdateProductUnitCost.BOSComment = null;
            this.fld_btnUpdateProductUnitCost.BOSDataMember = null;
            this.fld_btnUpdateProductUnitCost.BOSDataSource = null;
            this.fld_btnUpdateProductUnitCost.BOSDescription = null;
            this.fld_btnUpdateProductUnitCost.BOSError = null;
            this.fld_btnUpdateProductUnitCost.BOSFieldGroup = null;
            this.fld_btnUpdateProductUnitCost.BOSFieldRelation = null;
            this.fld_btnUpdateProductUnitCost.BOSPrivilege = null;
            this.fld_btnUpdateProductUnitCost.BOSPropertyName = null;
            this.fld_btnUpdateProductUnitCost.Location = new System.Drawing.Point(119, 12);
            this.fld_btnUpdateProductUnitCost.Name = "fld_btnUpdateProductUnitCost";
            this.fld_btnUpdateProductUnitCost.Screen = null;
            this.fld_btnUpdateProductUnitCost.Size = new System.Drawing.Size(116, 30);
            this.fld_btnUpdateProductUnitCost.TabIndex = 369;
            this.fld_btnUpdateProductUnitCost.Text = "Cập nhật giá vốn";
            this.fld_btnUpdateProductUnitCost.Click += new System.EventHandler(this.fld_btnUpdateProductUnitCost_Click);
            // 
            // fld_btnApplyPrice
            // 
            this.fld_btnApplyPrice.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnApplyPrice.Appearance.Options.UseForeColor = true;
            this.fld_btnApplyPrice.BOSComment = null;
            this.fld_btnApplyPrice.BOSDataMember = null;
            this.fld_btnApplyPrice.BOSDataSource = null;
            this.fld_btnApplyPrice.BOSDescription = null;
            this.fld_btnApplyPrice.BOSError = null;
            this.fld_btnApplyPrice.BOSFieldGroup = null;
            this.fld_btnApplyPrice.BOSFieldRelation = null;
            this.fld_btnApplyPrice.BOSPrivilege = null;
            this.fld_btnApplyPrice.BOSPropertyName = null;
            this.fld_btnApplyPrice.Location = new System.Drawing.Point(12, 12);
            this.fld_btnApplyPrice.Name = "fld_btnApplyPrice";
            this.fld_btnApplyPrice.Screen = null;
            this.fld_btnApplyPrice.Size = new System.Drawing.Size(87, 30);
            this.fld_btnApplyPrice.TabIndex = 369;
            this.fld_btnApplyPrice.Text = "Tính giá";
            this.fld_btnApplyPrice.Click += new System.EventHandler(this.fld_btnApplyPrice_Click);
            // 
            // fld_tabProductPriceList
            // 
            this.fld_tabProductPriceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabProductPriceList.BOSComment = null;
            this.fld_tabProductPriceList.BOSDataMember = null;
            this.fld_tabProductPriceList.BOSDataSource = null;
            this.fld_tabProductPriceList.BOSDescription = null;
            this.fld_tabProductPriceList.BOSError = null;
            this.fld_tabProductPriceList.BOSFieldGroup = null;
            this.fld_tabProductPriceList.BOSFieldRelation = null;
            this.fld_tabProductPriceList.BOSPrivilege = null;
            this.fld_tabProductPriceList.BOSPropertyName = null;
            this.fld_tabProductPriceList.Location = new System.Drawing.Point(6, 48);
            this.fld_tabProductPriceList.Name = "fld_tabProductPriceList";
            this.fld_tabProductPriceList.Screen = null;
            this.fld_tabProductPriceList.SelectedTabPage = this.xrTabProductPrice;
            this.fld_tabProductPriceList.Size = new System.Drawing.Size(851, 516);
            this.fld_tabProductPriceList.TabIndex = 347;
            this.fld_tabProductPriceList.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xrTabProductPrice,
            this.xrUnfinishedProductPrice});
            // 
            // xrTabProductPrice
            // 
            this.xrTabProductPrice.Controls.Add(this.fld_dgcMMProductPrices);
            this.xrTabProductPrice.Name = "xrTabProductPrice";
            this.xrTabProductPrice.Size = new System.Drawing.Size(844, 487);
            this.xrTabProductPrice.Text = "DS thành phẩm";
            // 
            // fld_dgcMMProductPrices
            // 
            this.fld_dgcMMProductPrices.AllowDrop = true;
            this.fld_dgcMMProductPrices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductPrices.BOSComment = null;
            this.fld_dgcMMProductPrices.BOSDataMember = null;
            this.fld_dgcMMProductPrices.BOSDataSource = "MMProductPrices";
            this.fld_dgcMMProductPrices.BOSDescription = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcMMProductPrices.BOSError = null;
            this.fld_dgcMMProductPrices.BOSFieldGroup = null;
            this.fld_dgcMMProductPrices.BOSFieldRelation = null;
            this.fld_dgcMMProductPrices.BOSGridType = null;
            this.fld_dgcMMProductPrices.BOSPrivilege = null;
            this.fld_dgcMMProductPrices.BOSPropertyName = null;
            this.fld_dgcMMProductPrices.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductPrices.Location = new System.Drawing.Point(4, 3);
            this.fld_dgcMMProductPrices.MainView = this.fld_dgvMMProductPrices;
            this.fld_dgcMMProductPrices.Name = "fld_dgcMMProductPrices";
            this.fld_dgcMMProductPrices.PrintReport = false;
            this.fld_dgcMMProductPrices.Screen = null;
            this.fld_dgcMMProductPrices.Size = new System.Drawing.Size(837, 480);
            this.fld_dgcMMProductPrices.TabIndex = 115;
            this.fld_dgcMMProductPrices.Tag = "DC";
            this.fld_dgcMMProductPrices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvMMProductPrices});
            // 
            // fld_dgvMMProductPrices
            // 
            this.fld_dgvMMProductPrices.GridControl = this.fld_dgcMMProductPrices;
            this.fld_dgvMMProductPrices.Name = "fld_dgvMMProductPrices";
            this.fld_dgvMMProductPrices.PaintStyleName = "Office2003";
            // 
            // xrUnfinishedProductPrice
            // 
            this.xrUnfinishedProductPrice.Controls.Add(this.fld_dgcMMProductPriceIncompletes);
            this.xrUnfinishedProductPrice.Name = "xrUnfinishedProductPrice";
            this.xrUnfinishedProductPrice.Size = new System.Drawing.Size(844, 487);
            this.xrUnfinishedProductPrice.Text = "DS sản phẩm dở dang";
            // 
            // fld_dgcMMProductPriceIncompletes
            // 
            this.fld_dgcMMProductPriceIncompletes.AllowDrop = true;
            this.fld_dgcMMProductPriceIncompletes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProductPriceIncompletes.BOSComment = null;
            this.fld_dgcMMProductPriceIncompletes.BOSDataMember = null;
            this.fld_dgcMMProductPriceIncompletes.BOSDataSource = "MMProductPriceIncompletes";
            this.fld_dgcMMProductPriceIncompletes.BOSDescription = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcMMProductPriceIncompletes.BOSError = null;
            this.fld_dgcMMProductPriceIncompletes.BOSFieldGroup = null;
            this.fld_dgcMMProductPriceIncompletes.BOSFieldRelation = null;
            this.fld_dgcMMProductPriceIncompletes.BOSGridType = null;
            this.fld_dgcMMProductPriceIncompletes.BOSPrivilege = null;
            this.fld_dgcMMProductPriceIncompletes.BOSPropertyName = null;
            this.fld_dgcMMProductPriceIncompletes.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductPriceIncompletes.Location = new System.Drawing.Point(4, 3);
            this.fld_dgcMMProductPriceIncompletes.MainView = this.gridView1;
            this.fld_dgcMMProductPriceIncompletes.Name = "fld_dgcMMProductPriceIncompletes";
            this.fld_dgcMMProductPriceIncompletes.PrintReport = false;
            this.fld_dgcMMProductPriceIncompletes.Screen = null;
            this.fld_dgcMMProductPriceIncompletes.Size = new System.Drawing.Size(837, 480);
            this.fld_dgcMMProductPriceIncompletes.TabIndex = 116;
            this.fld_dgcMMProductPriceIncompletes.Tag = "DC";
            this.fld_dgcMMProductPriceIncompletes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcMMProductPriceIncompletes;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
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
            // DMPDC104
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPDC104";
            this.Text = "Chi phí sản xuất";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabProductPriceList)).EndInit();
            this.fld_tabProductPriceList.ResumeLayout(false);
            this.xrTabProductPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMProductPrices)).EndInit();
            this.xrUnfinishedProductPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductPriceIncompletes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSButton fld_btnUpdateProductUnitCost;
        private BOSComponent.BOSButton fld_btnApplyPrice;
        private BOSComponent.BOSTabControl fld_tabProductPriceList;
        private DevExpress.XtraTab.XtraTabPage xrTabProductPrice;
        private DevExpress.XtraTab.XtraTabPage xrUnfinishedProductPrice;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private IContainer components;
        private MMProductPricesGridControl fld_dgcMMProductPrices;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMProductPrices;
        private MMProductPriceIncompletesGridControl fld_dgcMMProductPriceIncompletes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
	}
}
