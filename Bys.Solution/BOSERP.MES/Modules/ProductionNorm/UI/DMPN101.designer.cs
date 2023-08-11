using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionNorm.UI
{
	/// <summary>
	/// Summary description for DMPN101
	/// </summary>
	partial class DMPN101
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
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProfileManagementItems = new BOSERP.Modules.ProductionNorm.ProfileManagementItemsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_tabHistory = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabSemiProduct = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHistorySemiProduct = new BOSERP.Modules.ProductionNorm.SemiProductProfileManagementHistoryGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabHardware = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHistoryHardware = new BOSERP.Modules.ProductionNorm.HardwareProfileManagementHistoryGridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabPaint = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHistoryPaint = new BOSERP.Modules.ProductionNorm.PaintProfileManagementHistoryGridControl();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabPackaging = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHistoryPackaging = new BOSERP.Modules.ProductionNorm.PackagingProfileManagementHistoryGridControl();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabOperation = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcHistoryGeneral = new BOSERP.Modules.ProductionNorm.ProfileManagementHistoryGridControl();
            this.gridView11 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView12 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProfileManagementItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabHistory)).BeginInit();
            this.fld_tabHistory.SuspendLayout();
            this.fld_tabSemiProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHistorySemiProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.fld_tabHardware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHistoryHardware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.fld_tabPaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHistoryPaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            this.fld_tabPackaging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHistoryPackaging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
            this.fld_tabOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHistoryGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(884, 562);
            this.bosPanel1.TabIndex = 6;
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosTabControl1.Location = new System.Drawing.Point(0, 0);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(884, 562);
            this.bosTabControl1.TabIndex = 90;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(this.fld_dgcMMProfileManagementItems);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(877, 533);
            this.xtraTabPage1.Text = "Trang kiểm soát hồ sơ";
            // 
            // fld_dgcMMProfileManagementItems
            // 
            this.fld_dgcMMProfileManagementItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMProfileManagementItems.BOSComment = null;
            this.fld_dgcMMProfileManagementItems.BOSDataMember = null;
            this.fld_dgcMMProfileManagementItems.BOSDataSource = "MMProfileManagementItems";
            this.fld_dgcMMProfileManagementItems.BOSDescription = null;
            this.fld_dgcMMProfileManagementItems.BOSError = null;
            this.fld_dgcMMProfileManagementItems.BOSFieldGroup = null;
            this.fld_dgcMMProfileManagementItems.BOSFieldRelation = null;
            this.fld_dgcMMProfileManagementItems.BOSGridType = null;
            this.fld_dgcMMProfileManagementItems.BOSPrivilege = null;
            this.fld_dgcMMProfileManagementItems.BOSPropertyName = null;
            this.fld_dgcMMProfileManagementItems.Location = new System.Drawing.Point(1, 5);
            this.fld_dgcMMProfileManagementItems.MainView = this.gridView1;
            this.fld_dgcMMProfileManagementItems.Name = "fld_dgcMMProfileManagementItems";
            this.fld_dgcMMProfileManagementItems.PrintReport = false;
            this.fld_dgcMMProfileManagementItems.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMProfileManagementItems, true);
            this.fld_dgcMMProfileManagementItems.Size = new System.Drawing.Size(874, 523);
            this.fld_dgcMMProfileManagementItems.TabIndex = 73;
            this.fld_dgcMMProfileManagementItems.Tag = "DC";
            this.fld_dgcMMProfileManagementItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView4});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcMMProfileManagementItems;
            this.gridView1.Name = "gridView1";
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.fld_dgcMMProfileManagementItems;
            this.gridView4.Name = "gridView4";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_tabHistory);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(877, 533);
            this.xtraTabPage2.Text = "Lịch sử thay đổi";
            // 
            // fld_tabHistory
            // 
            this.fld_tabHistory.BOSComment = null;
            this.fld_tabHistory.BOSDataMember = null;
            this.fld_tabHistory.BOSDataSource = "MMProfileManagementItems";
            this.fld_tabHistory.BOSDescription = null;
            this.fld_tabHistory.BOSError = null;
            this.fld_tabHistory.BOSFieldGroup = null;
            this.fld_tabHistory.BOSFieldRelation = null;
            this.fld_tabHistory.BOSPrivilege = null;
            this.fld_tabHistory.BOSPropertyName = null;
            this.fld_tabHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_tabHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tabHistory.Location = new System.Drawing.Point(0, 0);
            this.fld_tabHistory.Name = "fld_tabHistory";
            this.fld_tabHistory.Screen = null;
            this.fld_tabHistory.SelectedTabPage = this.fld_tabSemiProduct;
            this.ScreenHelper.SetShowHelp(this.fld_tabHistory, true);
            this.fld_tabHistory.Size = new System.Drawing.Size(877, 533);
            this.fld_tabHistory.TabIndex = 73;
            this.fld_tabHistory.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabSemiProduct,
            this.fld_tabHardware,
            this.fld_tabPaint,
            this.fld_tabPackaging,
            this.fld_tabOperation});
            // 
            // fld_tabSemiProduct
            // 
            this.fld_tabSemiProduct.Controls.Add(this.fld_dgcHistorySemiProduct);
            this.fld_tabSemiProduct.Name = "fld_tabSemiProduct";
            this.ScreenHelper.SetShowHelp(this.fld_tabSemiProduct, true);
            this.fld_tabSemiProduct.Size = new System.Drawing.Size(870, 504);
            this.fld_tabSemiProduct.Text = "ĐM Gổ";
            // 
            // fld_dgcHistorySemiProduct
            // 
            this.fld_dgcHistorySemiProduct.BOSComment = null;
            this.fld_dgcHistorySemiProduct.BOSDataMember = null;
            this.fld_dgcHistorySemiProduct.BOSDataSource = "GEObjectHistory";
            this.fld_dgcHistorySemiProduct.BOSDescription = null;
            this.fld_dgcHistorySemiProduct.BOSError = null;
            this.fld_dgcHistorySemiProduct.BOSFieldGroup = null;
            this.fld_dgcHistorySemiProduct.BOSFieldRelation = null;
            this.fld_dgcHistorySemiProduct.BOSGridType = null;
            this.fld_dgcHistorySemiProduct.BOSPrivilege = null;
            this.fld_dgcHistorySemiProduct.BOSPropertyName = null;
            this.fld_dgcHistorySemiProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHistorySemiProduct.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcHistorySemiProduct.MainView = this.gridView2;
            this.fld_dgcHistorySemiProduct.Name = "fld_dgcHistorySemiProduct";
            this.fld_dgcHistorySemiProduct.PrintReport = false;
            this.fld_dgcHistorySemiProduct.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHistorySemiProduct, true);
            this.fld_dgcHistorySemiProduct.Size = new System.Drawing.Size(870, 504);
            this.fld_dgcHistorySemiProduct.TabIndex = 72;
            this.fld_dgcHistorySemiProduct.Tag = "DC";
            this.fld_dgcHistorySemiProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView3});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcHistorySemiProduct;
            this.gridView2.Name = "gridView2";
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.fld_dgcHistorySemiProduct;
            this.gridView3.Name = "gridView3";
            // 
            // fld_tabHardware
            // 
            this.fld_tabHardware.Controls.Add(this.fld_dgcHistoryHardware);
            this.fld_tabHardware.Name = "fld_tabHardware";
            this.ScreenHelper.SetShowHelp(this.fld_tabHardware, true);
            this.fld_tabHardware.Size = new System.Drawing.Size(870, 504);
            this.fld_tabHardware.Text = "ĐM Hardware";
            // 
            // fld_dgcHistoryHardware
            // 
            this.fld_dgcHistoryHardware.BOSComment = null;
            this.fld_dgcHistoryHardware.BOSDataMember = null;
            this.fld_dgcHistoryHardware.BOSDataSource = "GEObjectHistory";
            this.fld_dgcHistoryHardware.BOSDescription = null;
            this.fld_dgcHistoryHardware.BOSError = null;
            this.fld_dgcHistoryHardware.BOSFieldGroup = null;
            this.fld_dgcHistoryHardware.BOSFieldRelation = null;
            this.fld_dgcHistoryHardware.BOSGridType = null;
            this.fld_dgcHistoryHardware.BOSPrivilege = null;
            this.fld_dgcHistoryHardware.BOSPropertyName = null;
            this.fld_dgcHistoryHardware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHistoryHardware.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcHistoryHardware.MainView = this.gridView5;
            this.fld_dgcHistoryHardware.Name = "fld_dgcHistoryHardware";
            this.fld_dgcHistoryHardware.PrintReport = false;
            this.fld_dgcHistoryHardware.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHistoryHardware, true);
            this.fld_dgcHistoryHardware.Size = new System.Drawing.Size(870, 504);
            this.fld_dgcHistoryHardware.TabIndex = 73;
            this.fld_dgcHistoryHardware.Tag = "DC";
            this.fld_dgcHistoryHardware.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5,
            this.gridView6});
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.fld_dgcHistoryHardware;
            this.gridView5.Name = "gridView5";
            // 
            // gridView6
            // 
            this.gridView6.GridControl = this.fld_dgcHistoryHardware;
            this.gridView6.Name = "gridView6";
            // 
            // fld_tabPaint
            // 
            this.fld_tabPaint.Controls.Add(this.fld_dgcHistoryPaint);
            this.fld_tabPaint.Name = "fld_tabPaint";
            this.fld_tabPaint.Size = new System.Drawing.Size(870, 504);
            this.fld_tabPaint.Text = "ĐM Sơn";
            // 
            // fld_dgcHistoryPaint
            // 
            this.fld_dgcHistoryPaint.BOSComment = null;
            this.fld_dgcHistoryPaint.BOSDataMember = null;
            this.fld_dgcHistoryPaint.BOSDataSource = "GEObjectHistory";
            this.fld_dgcHistoryPaint.BOSDescription = null;
            this.fld_dgcHistoryPaint.BOSError = null;
            this.fld_dgcHistoryPaint.BOSFieldGroup = null;
            this.fld_dgcHistoryPaint.BOSFieldRelation = null;
            this.fld_dgcHistoryPaint.BOSGridType = null;
            this.fld_dgcHistoryPaint.BOSPrivilege = null;
            this.fld_dgcHistoryPaint.BOSPropertyName = null;
            this.fld_dgcHistoryPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHistoryPaint.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcHistoryPaint.MainView = this.gridView7;
            this.fld_dgcHistoryPaint.Name = "fld_dgcHistoryPaint";
            this.fld_dgcHistoryPaint.PrintReport = false;
            this.fld_dgcHistoryPaint.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHistoryPaint, true);
            this.fld_dgcHistoryPaint.Size = new System.Drawing.Size(870, 504);
            this.fld_dgcHistoryPaint.TabIndex = 73;
            this.fld_dgcHistoryPaint.Tag = "DC";
            this.fld_dgcHistoryPaint.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView7,
            this.gridView8});
            // 
            // gridView7
            // 
            this.gridView7.GridControl = this.fld_dgcHistoryPaint;
            this.gridView7.Name = "gridView7";
            // 
            // gridView8
            // 
            this.gridView8.GridControl = this.fld_dgcHistoryPaint;
            this.gridView8.Name = "gridView8";
            // 
            // fld_tabPackaging
            // 
            this.fld_tabPackaging.Controls.Add(this.fld_dgcHistoryPackaging);
            this.fld_tabPackaging.Name = "fld_tabPackaging";
            this.fld_tabPackaging.Size = new System.Drawing.Size(870, 504);
            this.fld_tabPackaging.Text = "ĐM Phụ liệu đóng gói";
            // 
            // fld_dgcHistoryPackaging
            // 
            this.fld_dgcHistoryPackaging.BOSComment = null;
            this.fld_dgcHistoryPackaging.BOSDataMember = null;
            this.fld_dgcHistoryPackaging.BOSDataSource = "GEObjectHistory";
            this.fld_dgcHistoryPackaging.BOSDescription = null;
            this.fld_dgcHistoryPackaging.BOSError = null;
            this.fld_dgcHistoryPackaging.BOSFieldGroup = null;
            this.fld_dgcHistoryPackaging.BOSFieldRelation = null;
            this.fld_dgcHistoryPackaging.BOSGridType = null;
            this.fld_dgcHistoryPackaging.BOSPrivilege = null;
            this.fld_dgcHistoryPackaging.BOSPropertyName = null;
            this.fld_dgcHistoryPackaging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHistoryPackaging.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcHistoryPackaging.MainView = this.gridView9;
            this.fld_dgcHistoryPackaging.Name = "fld_dgcHistoryPackaging";
            this.fld_dgcHistoryPackaging.PrintReport = false;
            this.fld_dgcHistoryPackaging.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHistoryPackaging, true);
            this.fld_dgcHistoryPackaging.Size = new System.Drawing.Size(870, 504);
            this.fld_dgcHistoryPackaging.TabIndex = 73;
            this.fld_dgcHistoryPackaging.Tag = "DC";
            this.fld_dgcHistoryPackaging.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView9,
            this.gridView10});
            // 
            // gridView9
            // 
            this.gridView9.GridControl = this.fld_dgcHistoryPackaging;
            this.gridView9.Name = "gridView9";
            // 
            // gridView10
            // 
            this.gridView10.GridControl = this.fld_dgcHistoryPackaging;
            this.gridView10.Name = "gridView10";
            // 
            // fld_tabOperation
            // 
            this.fld_tabOperation.Controls.Add(this.fld_dgcHistoryGeneral);
            this.fld_tabOperation.Name = "fld_tabOperation";
            this.fld_tabOperation.Size = new System.Drawing.Size(870, 504);
            this.fld_tabOperation.Text = "Thông tin chung";
            // 
            // fld_dgcHistoryGeneral
            // 
            this.fld_dgcHistoryGeneral.BOSComment = null;
            this.fld_dgcHistoryGeneral.BOSDataMember = null;
            this.fld_dgcHistoryGeneral.BOSDataSource = "GEObjectHistory";
            this.fld_dgcHistoryGeneral.BOSDescription = null;
            this.fld_dgcHistoryGeneral.BOSError = null;
            this.fld_dgcHistoryGeneral.BOSFieldGroup = null;
            this.fld_dgcHistoryGeneral.BOSFieldRelation = null;
            this.fld_dgcHistoryGeneral.BOSGridType = null;
            this.fld_dgcHistoryGeneral.BOSPrivilege = null;
            this.fld_dgcHistoryGeneral.BOSPropertyName = null;
            this.fld_dgcHistoryGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHistoryGeneral.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcHistoryGeneral.MainView = this.gridView11;
            this.fld_dgcHistoryGeneral.Name = "fld_dgcHistoryGeneral";
            this.fld_dgcHistoryGeneral.PrintReport = false;
            this.fld_dgcHistoryGeneral.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcHistoryGeneral, true);
            this.fld_dgcHistoryGeneral.Size = new System.Drawing.Size(870, 504);
            this.fld_dgcHistoryGeneral.TabIndex = 73;
            this.fld_dgcHistoryGeneral.Tag = "DC";
            this.fld_dgcHistoryGeneral.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView11,
            this.gridView12});
            // 
            // gridView11
            // 
            this.gridView11.GridControl = this.fld_dgcHistoryGeneral;
            this.gridView11.Name = "gridView11";
            // 
            // gridView12
            // 
            this.gridView12.GridControl = this.fld_dgcHistoryGeneral;
            this.gridView12.Name = "gridView12";
            // 
            // DMPN101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMPN101";
            this.Tag = "DM";
            this.Text = "Kiểm soát hồ sơ";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProfileManagementItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabHistory)).EndInit();
            this.fld_tabHistory.ResumeLayout(false);
            this.fld_tabSemiProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHistorySemiProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.fld_tabHardware.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHistoryHardware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.fld_tabPaint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHistoryPaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            this.fld_tabPackaging.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHistoryPackaging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            this.fld_tabOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHistoryGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private SemiProductProfileManagementHistoryGridControl fld_dgcHistorySemiProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ProfileManagementItemsGridControl fld_dgcMMProfileManagementItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private BOSComponent.BOSTabControl fld_tabHistory;
        private DevExpress.XtraTab.XtraTabPage fld_tabSemiProduct;
        private DevExpress.XtraTab.XtraTabPage fld_tabHardware;
        private HardwareProfileManagementHistoryGridControl fld_dgcHistoryHardware;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraTab.XtraTabPage fld_tabPaint;
        private PaintProfileManagementHistoryGridControl fld_dgcHistoryPaint;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraTab.XtraTabPage fld_tabPackaging;
        private PackagingProfileManagementHistoryGridControl fld_dgcHistoryPackaging;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
        private DevExpress.XtraTab.XtraTabPage fld_tabOperation;
        private ProfileManagementHistoryGridControl fld_dgcHistoryGeneral;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView11;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView12;
	}
}
