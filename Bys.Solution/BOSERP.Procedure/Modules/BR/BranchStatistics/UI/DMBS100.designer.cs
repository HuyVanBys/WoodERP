using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BranchStatistics.UI
{
	/// <summary>
	/// Summary description for SMBS100
	/// </summary>
	partial class DMBS100
    {
        private BOSComponent.BOSGroupControl fld_grcDepartmentChart;
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSGridControl fld_dgcARInvoices;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARInvoices;


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
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel4 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel5 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel6 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.fld_grcDepartmentChart = new BOSComponent.BOSGroupControl(this.components);
            this.fld_chcDepartmentSale = new BOSComponent.BOSChartControl(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcARInvoices = new BOSComponent.BOSGridControl(this.components);
            this.fld_dgvARInvoices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgcARInvoiceItems = new BOSERP.Modules.BranchStatistics.ARInvoiceItemsGridControl();
            this.fld_dgvARInvoiceItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_grcGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcAROwingInvoices = new AROwingInvoicesGridControl();
            this.fld_dgcGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcAPOwingInvoiceIns = new APOwingInvoiceInsGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcDepartmentChart)).BeginInit();
            this.fld_grcDepartmentChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chcDepartmentSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARInvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).BeginInit();
            this.fld_grcGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAROwingInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGroupControl3)).BeginInit();
            this.fld_dgcGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPOwingInvoiceIns)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_grcDepartmentChart
            // 
            this.fld_grcDepartmentChart.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcDepartmentChart.Appearance.Options.UseBackColor = true;
            this.fld_grcDepartmentChart.BOSComment = "";
            this.fld_grcDepartmentChart.BOSDataMember = null;
            this.fld_grcDepartmentChart.BOSDataSource = null;
            this.fld_grcDepartmentChart.BOSDescription = null;
            this.fld_grcDepartmentChart.BOSError = null;
            this.fld_grcDepartmentChart.BOSFieldGroup = "";
            this.fld_grcDepartmentChart.BOSFieldRelation = null;
            this.fld_grcDepartmentChart.BOSPrivilege = "";
            this.fld_grcDepartmentChart.BOSPropertyName = null;
            this.fld_grcDepartmentChart.Controls.Add(this.fld_chcDepartmentSale);
            this.fld_grcDepartmentChart.Location = new System.Drawing.Point(834, 12);
            this.fld_grcDepartmentChart.Name = "fld_grcDepartmentChart";
            this.fld_grcDepartmentChart.Screen = null;
            this.fld_grcDepartmentChart.Size = new System.Drawing.Size(405, 300);
            this.fld_grcDepartmentChart.TabIndex = 19;
            this.fld_grcDepartmentChart.Text = "Biểu đồ ngành hàng";
            // 
            // fld_chcDepartmentSale
            // 
            this.fld_chcDepartmentSale.BOSComment = null;
            this.fld_chcDepartmentSale.BOSDataMember = null;
            this.fld_chcDepartmentSale.BOSDataSource = null;
            this.fld_chcDepartmentSale.BOSDescription = null;
            this.fld_chcDepartmentSale.BOSError = null;
            this.fld_chcDepartmentSale.BOSFieldGroup = null;
            this.fld_chcDepartmentSale.BOSFieldRelation = null;
            this.fld_chcDepartmentSale.BOSPrivilege = null;
            this.fld_chcDepartmentSale.BOSPropertyName = null;
            xyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.fld_chcDepartmentSale.Diagram = xyDiagram2;
            this.fld_chcDepartmentSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_chcDepartmentSale.Legend.EquallySpacedItems = false;
            this.fld_chcDepartmentSale.Legend.Visible = false;
            this.fld_chcDepartmentSale.Location = new System.Drawing.Point(2, 22);
            this.fld_chcDepartmentSale.Name = "fld_chcDepartmentSale";
            this.fld_chcDepartmentSale.Screen = null;
            sideBySideBarSeriesLabel4.LineVisible = true;
            series3.Label = sideBySideBarSeriesLabel4;
            series3.Name = "Series 1";
            sideBySideBarSeriesLabel5.LineVisible = true;
            series4.Label = sideBySideBarSeriesLabel5;
            series4.Name = "Series 2";
            this.fld_chcDepartmentSale.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3,
        series4};
            sideBySideBarSeriesLabel6.LineVisible = true;
            this.fld_chcDepartmentSale.SeriesTemplate.Label = sideBySideBarSeriesLabel6;
            this.fld_chcDepartmentSale.Size = new System.Drawing.Size(401, 276);
            this.fld_chcDepartmentSale.TabIndex = 0;
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcARInvoices);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(834, 313);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(405, 322);
            this.fld_grcGroupControl.TabIndex = 28;
            this.fld_grcGroupControl.Text = "Danh sách khách hàng mua nhiều";
            // 
            // fld_dgcARInvoices
            // 
            this.fld_dgcARInvoices.AllowDrop = true;
            this.fld_dgcARInvoices.BOSComment = "";
            this.fld_dgcARInvoices.BOSDataMember = null;
            this.fld_dgcARInvoices.BOSDataSource = "ARInvoices";
            this.fld_dgcARInvoices.BOSDescription = null;
            this.fld_dgcARInvoices.BOSError = "";
            this.fld_dgcARInvoices.BOSFieldGroup = "";
            this.fld_dgcARInvoices.BOSFieldRelation = null;
            this.fld_dgcARInvoices.BOSGridType = null;
            this.fld_dgcARInvoices.BOSPrivilege = "";
            this.fld_dgcARInvoices.BOSPropertyName = null;
            this.fld_dgcARInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARInvoices.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARInvoices.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcARInvoices.MainView = this.fld_dgvARInvoices;
            this.fld_dgcARInvoices.Name = "fld_dgcARInvoices";
            this.fld_dgcARInvoices.Screen = null;
            this.fld_dgcARInvoices.Size = new System.Drawing.Size(401, 298);
            this.fld_dgcARInvoices.TabIndex = 29;
            this.fld_dgcARInvoices.Tag = "DC";
            this.fld_dgcARInvoices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARInvoices});
            // 
            // fld_dgvARInvoices
            // 
            this.fld_dgvARInvoices.GridControl = this.fld_dgcARInvoices;
            this.fld_dgvARInvoices.Name = "fld_dgvARInvoices";
            this.fld_dgvARInvoices.PaintStyleName = "Office2003";
            // 
            // fld_dgcARInvoiceItems
            // 
            this.fld_dgcARInvoiceItems.AllowDrop = true;
            this.fld_dgcARInvoiceItems.BOSComment = "";
            this.fld_dgcARInvoiceItems.BOSDataMember = null;
            this.fld_dgcARInvoiceItems.BOSDataSource = "ARInvoiceItems";
            this.fld_dgcARInvoiceItems.BOSDescription = null;
            this.fld_dgcARInvoiceItems.BOSError = "";
            this.fld_dgcARInvoiceItems.BOSFieldGroup = "";
            this.fld_dgcARInvoiceItems.BOSFieldRelation = null;
            this.fld_dgcARInvoiceItems.BOSGridType = null;
            this.fld_dgcARInvoiceItems.BOSPrivilege = "";
            this.fld_dgcARInvoiceItems.BOSPropertyName = null;
            this.fld_dgcARInvoiceItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARInvoiceItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARInvoiceItems.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcARInvoiceItems.MainView = this.fld_dgvARInvoiceItems;
            this.fld_dgcARInvoiceItems.Name = "fld_dgcARInvoiceItems";
            this.fld_dgcARInvoiceItems.Screen = null;
            this.fld_dgcARInvoiceItems.Size = new System.Drawing.Size(814, 274);
            this.fld_dgcARInvoiceItems.TabIndex = 13;
            this.fld_dgcARInvoiceItems.Tag = "DC";
            this.fld_dgcARInvoiceItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARInvoiceItems});
            // 
            // fld_dgvARInvoiceItems
            // 
            this.fld_dgvARInvoiceItems.GridControl = this.fld_dgcARInvoiceItems;
            this.fld_dgvARInvoiceItems.Name = "fld_dgvARInvoiceItems";
            this.fld_dgvARInvoiceItems.PaintStyleName = "Office2003";
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.BOSComment = "";
            this.fld_grcGroupControl1.BOSDataMember = null;
            this.fld_grcGroupControl1.BOSDataSource = null;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = "";
            this.fld_grcGroupControl1.BOSFieldRelation = null;
            this.fld_grcGroupControl1.BOSPrivilege = "";
            this.fld_grcGroupControl1.BOSPropertyName = null;
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcARInvoiceItems);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(12, 12);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(818, 298);
            this.fld_grcGroupControl1.TabIndex = 20;
            this.fld_grcGroupControl1.Text = "Danh sách sản phẩm bán";
            // 
            // fld_grcGroupControl2
            // 
            this.fld_grcGroupControl2.BOSComment = null;
            this.fld_grcGroupControl2.BOSDataMember = null;
            this.fld_grcGroupControl2.BOSDataSource = null;
            this.fld_grcGroupControl2.BOSDescription = null;
            this.fld_grcGroupControl2.BOSError = null;
            this.fld_grcGroupControl2.BOSFieldGroup = null;
            this.fld_grcGroupControl2.BOSFieldRelation = null;
            this.fld_grcGroupControl2.BOSPrivilege = null;
            this.fld_grcGroupControl2.BOSPropertyName = null;
            this.fld_grcGroupControl2.Controls.Add(this.fld_dgcAROwingInvoices);
            this.fld_grcGroupControl2.Location = new System.Drawing.Point(12, 316);
            this.fld_grcGroupControl2.Name = "fld_grcGroupControl2";
            this.fld_grcGroupControl2.Screen = null;
            this.fld_grcGroupControl2.Size = new System.Drawing.Size(397, 319);
            this.fld_grcGroupControl2.TabIndex = 29;
            this.fld_grcGroupControl2.Text = "Công nợ thu";
            // 
            // fld_dgcAROwingInvoices
            // 
            this.fld_dgcAROwingInvoices.BOSComment = null;
            this.fld_dgcAROwingInvoices.BOSDataMember = null;
            this.fld_dgcAROwingInvoices.BOSDataSource = "ARInvoices";
            this.fld_dgcAROwingInvoices.BOSDescription = null;
            this.fld_dgcAROwingInvoices.BOSError = null;
            this.fld_dgcAROwingInvoices.BOSFieldGroup = null;
            this.fld_dgcAROwingInvoices.BOSFieldRelation = null;
            this.fld_dgcAROwingInvoices.BOSGridType = null;
            this.fld_dgcAROwingInvoices.BOSPrivilege = null;
            this.fld_dgcAROwingInvoices.BOSPropertyName = null;
            this.fld_dgcAROwingInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcAROwingInvoices.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcAROwingInvoices.MenuManager = this.screenToolbar;
            this.fld_dgcAROwingInvoices.Name = "fld_dgcAROwingInvoices";
            this.fld_dgcAROwingInvoices.Screen = null;
            this.fld_dgcAROwingInvoices.Size = new System.Drawing.Size(393, 295);
            this.fld_dgcAROwingInvoices.TabIndex = 0;
            // 
            // fld_dgcGroupControl3
            // 
            this.fld_dgcGroupControl3.BOSComment = null;
            this.fld_dgcGroupControl3.BOSDataMember = null;
            this.fld_dgcGroupControl3.BOSDataSource = null;
            this.fld_dgcGroupControl3.BOSDescription = null;
            this.fld_dgcGroupControl3.BOSError = null;
            this.fld_dgcGroupControl3.BOSFieldGroup = null;
            this.fld_dgcGroupControl3.BOSFieldRelation = null;
            this.fld_dgcGroupControl3.BOSPrivilege = null;
            this.fld_dgcGroupControl3.BOSPropertyName = null;
            this.fld_dgcGroupControl3.Controls.Add(this.fld_dgcAPOwingInvoiceIns);
            this.fld_dgcGroupControl3.Location = new System.Drawing.Point(415, 316);
            this.fld_dgcGroupControl3.Name = "fld_dgcGroupControl3";
            this.fld_dgcGroupControl3.Screen = null;
            this.fld_dgcGroupControl3.Size = new System.Drawing.Size(413, 319);
            this.fld_dgcGroupControl3.TabIndex = 29;
            this.fld_dgcGroupControl3.Text = "Công nợ chi";
            // 
            // fld_dgcAPOwingInvoiceIns
            // 
            this.fld_dgcAPOwingInvoiceIns.BOSComment = null;
            this.fld_dgcAPOwingInvoiceIns.BOSDataMember = null;
            this.fld_dgcAPOwingInvoiceIns.BOSDataSource = "APInvoiceIns";
            this.fld_dgcAPOwingInvoiceIns.BOSDescription = null;
            this.fld_dgcAPOwingInvoiceIns.BOSError = null;
            this.fld_dgcAPOwingInvoiceIns.BOSFieldGroup = null;
            this.fld_dgcAPOwingInvoiceIns.BOSFieldRelation = null;
            this.fld_dgcAPOwingInvoiceIns.BOSGridType = null;
            this.fld_dgcAPOwingInvoiceIns.BOSPrivilege = null;
            this.fld_dgcAPOwingInvoiceIns.BOSPropertyName = null;
            this.fld_dgcAPOwingInvoiceIns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcAPOwingInvoiceIns.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcAPOwingInvoiceIns.MenuManager = this.screenToolbar;
            this.fld_dgcAPOwingInvoiceIns.Name = "fld_dgcAPOwingInvoiceIns";
            this.fld_dgcAPOwingInvoiceIns.Screen = null;
            this.fld_dgcAPOwingInvoiceIns.Size = new System.Drawing.Size(409, 295);
            this.fld_dgcAPOwingInvoiceIns.TabIndex = 0;
            // 
            // DMBS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1248, 655);
            this.Controls.Add(this.fld_dgcGroupControl3);
            this.Controls.Add(this.fld_grcGroupControl2);
            this.Controls.Add(this.fld_grcGroupControl1);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.fld_grcDepartmentChart);
            this.Name = "DMBS100";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcDepartmentChart)).EndInit();
            this.fld_grcDepartmentChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chcDepartmentSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoiceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARInvoiceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).EndInit();
            this.fld_grcGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAROwingInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGroupControl3)).EndInit();
            this.fld_dgcGroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPOwingInvoiceIns)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSChartControl fld_chcDepartmentSale;
        private ARInvoiceItemsGridControl fld_dgcARInvoiceItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARInvoiceItems;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private BOSComponent.BOSGroupControl fld_grcGroupControl2;
        private AROwingInvoicesGridControl fld_dgcAROwingInvoices;
        private BOSComponent.BOSGroupControl fld_dgcGroupControl3;
        private APOwingInvoiceInsGridControl fld_dgcAPOwingInvoiceIns;
	}
}
