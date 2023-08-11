using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSERP;

namespace BOSERP.Modules.Customer.UI
{
    /// <summary>
    /// Summary description for DMCU101
    /// </summary>
    partial class DMCU101
    {
        private BOSComponent.BOSLine BOSLine1;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel BOSLabel7;
        private BOSComponent.BOSLabel BOSLabel6;
        private BOSComponent.BOSLabel BOSLabel5;
        private BOSComponent.BOSLabel BOSLabel9;
        private BOSComponent.BOSLabel BOSLabel3;
        private BOSComponent.BOSLabel fld_lblLabel21;
        private BOSComponent.BOSLine fld_Line;
        private BOSComponent.BOSLabel fld_lblLabel23;
        private BOSComponent.BOSLabel fld_lblLabel24;
        private BOSComponent.BOSLabel fld_lblLabel28;
        private BOSComponent.BOSLabel fld_lblLabel29;


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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointOptions pointOptions1 = new DevExpress.XtraCharts.PointOptions();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel3 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointOptions pointOptions2 = new DevExpress.XtraCharts.PointOptions();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel4 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView4 = new DevExpress.XtraCharts.LineSeriesView();
            this.BOSLine1 = new BOSComponent.BOSLine(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel7 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel6 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel5 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel9 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_Line = new BOSComponent.BOSLine(this.components);
            this.fld_lblLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel24 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel28 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel29 = new BOSComponent.BOSLabel(this.components);
            this.BOSTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARSaleOrders = new BOSERP.Modules.Customer.ARSaleOrdersGridControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARInvoices = new BOSERP.Modules.Customer.ARInvoicesGridControl();
            this.fld_crtCustomerPurchase = new BOSERP.OverTimeChart(this.components);
            this.BOSTabControl2 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_crtCustomerPayment = new BOSERP.OverTimeChart(this.components);
            this.BOSPanel1 = new BOSComponent.BOSPanel(this.components);
            this.BOSPanel2 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHistoryDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHistoryDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_btnFilter = new BOSComponent.BOSButton(this.components);
            this.bosPanel3 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BOSTabControl1)).BeginInit();
            this.BOSTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrders)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_crtCustomerPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOSTabControl2)).BeginInit();
            this.BOSTabControl2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_crtCustomerPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).BeginInit();
            this.BOSPanel1.SuspendLayout();
            this.BOSPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHistoryDateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHistoryDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHistoryDateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHistoryDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.bosPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BOSLine1
            // 
            this.BOSLine1.BackColor = System.Drawing.Color.Transparent;
            this.BOSLine1.BOSComment = "";
            this.BOSLine1.BOSDataMember = "";
            this.BOSLine1.BOSDataSource = "";
            this.BOSLine1.BOSDescription = null;
            this.BOSLine1.BOSError = null;
            this.BOSLine1.BOSFieldGroup = "";
            this.BOSLine1.BOSFieldRelation = "";
            this.BOSLine1.BOSPrivilege = "";
            this.BOSLine1.BOSPropertyName = null;
            this.BOSLine1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BOSLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLine1.Location = new System.Drawing.Point(11, 25);
            this.BOSLine1.Name = "BOSLine1";
            this.BOSLine1.Screen = null;
            this.BOSLine1.Size = new System.Drawing.Size(385, 10);
            this.BOSLine1.TabIndex = 8;
            this.BOSLine1.TabStop = false;
            this.BOSLine1.Tag = "";
            // 
            // BOSLabel2
            // 
            this.BOSLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel2.Appearance.Options.UseBackColor = true;
            this.BOSLabel2.Appearance.Options.UseForeColor = true;
            this.BOSLabel2.BOSComment = "";
            this.BOSLabel2.BOSDataMember = "";
            this.BOSLabel2.BOSDataSource = "";
            this.BOSLabel2.BOSDescription = null;
            this.BOSLabel2.BOSError = null;
            this.BOSLabel2.BOSFieldGroup = "";
            this.BOSLabel2.BOSFieldRelation = "";
            this.BOSLabel2.BOSPrivilege = "";
            this.BOSLabel2.BOSPropertyName = null;
            this.BOSLabel2.Location = new System.Drawing.Point(11, 41);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(54, 13);
            this.BOSLabel2.TabIndex = 9;
            this.BOSLabel2.Tag = "";
            this.BOSLabel2.Text = "Số tiền bán";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.BOSLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel1.Appearance.Options.UseBackColor = true;
            this.BOSLabel1.Appearance.Options.UseFont = true;
            this.BOSLabel1.Appearance.Options.UseForeColor = true;
            this.BOSLabel1.BOSComment = "";
            this.BOSLabel1.BOSDataMember = "";
            this.BOSLabel1.BOSDataSource = "";
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = "";
            this.BOSLabel1.BOSFieldRelation = "";
            this.BOSLabel1.BOSPrivilege = "";
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(151, 8);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(119, 13);
            this.BOSLabel1.TabIndex = 7;
            this.BOSLabel1.Tag = "";
            this.BOSLabel1.Text = "Tổng số trên hóa đơn";
            // 
            // BOSLabel7
            // 
            this.BOSLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel7.Appearance.Options.UseBackColor = true;
            this.BOSLabel7.Appearance.Options.UseForeColor = true;
            this.BOSLabel7.BOSComment = "";
            this.BOSLabel7.BOSDataMember = "TotalRefundAmount";
            this.BOSLabel7.BOSDataSource = "ARCustomers";
            this.BOSLabel7.BOSDescription = null;
            this.BOSLabel7.BOSError = null;
            this.BOSLabel7.BOSFieldGroup = "";
            this.BOSLabel7.BOSFieldRelation = "";
            this.BOSLabel7.BOSPrivilege = "";
            this.BOSLabel7.BOSPropertyName = null;
            this.BOSLabel7.Location = new System.Drawing.Point(114, 68);
            this.BOSLabel7.Name = "BOSLabel7";
            this.BOSLabel7.Screen = null;
            this.BOSLabel7.Size = new System.Drawing.Size(6, 13);
            this.BOSLabel7.TabIndex = 10;
            this.BOSLabel7.Tag = "";
            this.BOSLabel7.Text = "0";
            // 
            // BOSLabel6
            // 
            this.BOSLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel6.Appearance.Options.UseBackColor = true;
            this.BOSLabel6.Appearance.Options.UseForeColor = true;
            this.BOSLabel6.BOSComment = "";
            this.BOSLabel6.BOSDataMember = "TotalPurchaseAmount";
            this.BOSLabel6.BOSDataSource = "ARCustomers";
            this.BOSLabel6.BOSDescription = null;
            this.BOSLabel6.BOSError = null;
            this.BOSLabel6.BOSFieldGroup = "";
            this.BOSLabel6.BOSFieldRelation = "";
            this.BOSLabel6.BOSPrivilege = "";
            this.BOSLabel6.BOSPropertyName = null;
            this.BOSLabel6.Location = new System.Drawing.Point(114, 41);
            this.BOSLabel6.Name = "BOSLabel6";
            this.BOSLabel6.Screen = null;
            this.BOSLabel6.Size = new System.Drawing.Size(6, 13);
            this.BOSLabel6.TabIndex = 10;
            this.BOSLabel6.Tag = "";
            this.BOSLabel6.Text = "0";
            // 
            // BOSLabel5
            // 
            this.BOSLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel5.Appearance.Options.UseBackColor = true;
            this.BOSLabel5.Appearance.Options.UseForeColor = true;
            this.BOSLabel5.BOSComment = "";
            this.BOSLabel5.BOSDataMember = "";
            this.BOSLabel5.BOSDataSource = "";
            this.BOSLabel5.BOSDescription = null;
            this.BOSLabel5.BOSError = null;
            this.BOSLabel5.BOSFieldGroup = "";
            this.BOSLabel5.BOSFieldRelation = "";
            this.BOSLabel5.BOSPrivilege = "";
            this.BOSLabel5.BOSPropertyName = null;
            this.BOSLabel5.Location = new System.Drawing.Point(219, 41);
            this.BOSLabel5.Name = "BOSLabel5";
            this.BOSLabel5.Screen = null;
            this.BOSLabel5.Size = new System.Drawing.Size(63, 13);
            this.BOSLabel5.TabIndex = 9;
            this.BOSLabel5.Tag = "";
            this.BOSLabel5.Text = "Số lượng bán";
            // 
            // BOSLabel9
            // 
            this.BOSLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel9.Appearance.Options.UseBackColor = true;
            this.BOSLabel9.Appearance.Options.UseForeColor = true;
            this.BOSLabel9.BOSComment = "";
            this.BOSLabel9.BOSDataMember = "TotalPurchaseQty";
            this.BOSLabel9.BOSDataSource = "ARCustomers";
            this.BOSLabel9.BOSDescription = null;
            this.BOSLabel9.BOSError = null;
            this.BOSLabel9.BOSFieldGroup = "";
            this.BOSLabel9.BOSFieldRelation = "";
            this.BOSLabel9.BOSPrivilege = "";
            this.BOSLabel9.BOSPropertyName = null;
            this.BOSLabel9.Location = new System.Drawing.Point(327, 41);
            this.BOSLabel9.Name = "BOSLabel9";
            this.BOSLabel9.Screen = null;
            this.BOSLabel9.Size = new System.Drawing.Size(6, 13);
            this.BOSLabel9.TabIndex = 10;
            this.BOSLabel9.Tag = "";
            this.BOSLabel9.Text = "0";
            // 
            // BOSLabel3
            // 
            this.BOSLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BOSLabel3.Appearance.Options.UseBackColor = true;
            this.BOSLabel3.Appearance.Options.UseForeColor = true;
            this.BOSLabel3.BOSComment = "";
            this.BOSLabel3.BOSDataMember = "";
            this.BOSLabel3.BOSDataSource = "";
            this.BOSLabel3.BOSDescription = null;
            this.BOSLabel3.BOSError = null;
            this.BOSLabel3.BOSFieldGroup = "";
            this.BOSLabel3.BOSFieldRelation = "";
            this.BOSLabel3.BOSPrivilege = "";
            this.BOSLabel3.BOSPropertyName = null;
            this.BOSLabel3.Location = new System.Drawing.Point(11, 68);
            this.BOSLabel3.Name = "BOSLabel3";
            this.BOSLabel3.Screen = null;
            this.BOSLabel3.Size = new System.Drawing.Size(77, 13);
            this.BOSLabel3.TabIndex = 9;
            this.BOSLabel3.Tag = "";
            this.BOSLabel3.Text = "Số tiền trả hàng";
            // 
            // fld_lblLabel21
            // 
            this.fld_lblLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel21.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel21.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel21.Appearance.Options.UseFont = true;
            this.fld_lblLabel21.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel21.BOSComment = "";
            this.fld_lblLabel21.BOSDataMember = "";
            this.fld_lblLabel21.BOSDataSource = "";
            this.fld_lblLabel21.BOSDescription = null;
            this.fld_lblLabel21.BOSError = null;
            this.fld_lblLabel21.BOSFieldGroup = "";
            this.fld_lblLabel21.BOSFieldRelation = "";
            this.fld_lblLabel21.BOSPrivilege = "";
            this.fld_lblLabel21.BOSPropertyName = null;
            this.fld_lblLabel21.Location = new System.Drawing.Point(53, 8);
            this.fld_lblLabel21.Name = "fld_lblLabel21";
            this.fld_lblLabel21.Screen = null;
            this.fld_lblLabel21.Size = new System.Drawing.Size(148, 13);
            this.fld_lblLabel21.TabIndex = 12;
            this.fld_lblLabel21.Tag = "";
            this.fld_lblLabel21.Text = "Tổng số trên đơn đặt hàng";
            // 
            // fld_Line
            // 
            this.fld_Line.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line.BOSComment = "";
            this.fld_Line.BOSDataMember = "";
            this.fld_Line.BOSDataSource = "";
            this.fld_Line.BOSDescription = null;
            this.fld_Line.BOSError = null;
            this.fld_Line.BOSFieldGroup = "";
            this.fld_Line.BOSFieldRelation = "";
            this.fld_Line.BOSPrivilege = "";
            this.fld_Line.BOSPropertyName = null;
            this.fld_Line.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line.Location = new System.Drawing.Point(8, 25);
            this.fld_Line.Name = "fld_Line";
            this.fld_Line.Screen = null;
            this.fld_Line.Size = new System.Drawing.Size(249, 10);
            this.fld_Line.TabIndex = 13;
            this.fld_Line.TabStop = false;
            this.fld_Line.Tag = "";
            // 
            // fld_lblLabel23
            // 
            this.fld_lblLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel23.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel23.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel23.BOSComment = "";
            this.fld_lblLabel23.BOSDataMember = "";
            this.fld_lblLabel23.BOSDataSource = "";
            this.fld_lblLabel23.BOSDescription = null;
            this.fld_lblLabel23.BOSError = null;
            this.fld_lblLabel23.BOSFieldGroup = "";
            this.fld_lblLabel23.BOSFieldRelation = "";
            this.fld_lblLabel23.BOSPrivilege = "";
            this.fld_lblLabel23.BOSPropertyName = null;
            this.fld_lblLabel23.Location = new System.Drawing.Point(18, 41);
            this.fld_lblLabel23.Name = "fld_lblLabel23";
            this.fld_lblLabel23.Screen = null;
            this.fld_lblLabel23.Size = new System.Drawing.Size(33, 13);
            this.fld_lblLabel23.TabIndex = 15;
            this.fld_lblLabel23.Tag = "";
            this.fld_lblLabel23.Text = "Số tiền";
            // 
            // fld_lblLabel24
            // 
            this.fld_lblLabel24.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel24.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel24.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel24.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel24.BOSComment = "";
            this.fld_lblLabel24.BOSDataMember = "TotalOrderAmount";
            this.fld_lblLabel24.BOSDataSource = "ARCustomers";
            this.fld_lblLabel24.BOSDescription = null;
            this.fld_lblLabel24.BOSError = null;
            this.fld_lblLabel24.BOSFieldGroup = "";
            this.fld_lblLabel24.BOSFieldRelation = "";
            this.fld_lblLabel24.BOSPrivilege = "";
            this.fld_lblLabel24.BOSPropertyName = null;
            this.fld_lblLabel24.Location = new System.Drawing.Point(99, 41);
            this.fld_lblLabel24.Name = "fld_lblLabel24";
            this.fld_lblLabel24.Screen = null;
            this.fld_lblLabel24.Size = new System.Drawing.Size(6, 13);
            this.fld_lblLabel24.TabIndex = 16;
            this.fld_lblLabel24.Tag = "";
            this.fld_lblLabel24.Text = "0";
            // 
            // fld_lblLabel28
            // 
            this.fld_lblLabel28.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel28.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel28.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel28.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel28.BOSComment = "";
            this.fld_lblLabel28.BOSDataMember = "";
            this.fld_lblLabel28.BOSDataSource = "";
            this.fld_lblLabel28.BOSDescription = null;
            this.fld_lblLabel28.BOSError = null;
            this.fld_lblLabel28.BOSFieldGroup = "";
            this.fld_lblLabel28.BOSFieldRelation = "";
            this.fld_lblLabel28.BOSPrivilege = "";
            this.fld_lblLabel28.BOSPropertyName = null;
            this.fld_lblLabel28.Location = new System.Drawing.Point(18, 68);
            this.fld_lblLabel28.Name = "fld_lblLabel28";
            this.fld_lblLabel28.Screen = null;
            this.fld_lblLabel28.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel28.TabIndex = 19;
            this.fld_lblLabel28.Tag = "";
            this.fld_lblLabel28.Text = "Số lượng";
            // 
            // fld_lblLabel29
            // 
            this.fld_lblLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel29.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel29.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel29.BOSComment = "";
            this.fld_lblLabel29.BOSDataMember = "TotalOrderQty";
            this.fld_lblLabel29.BOSDataSource = "ARCustomers";
            this.fld_lblLabel29.BOSDescription = null;
            this.fld_lblLabel29.BOSError = null;
            this.fld_lblLabel29.BOSFieldGroup = "";
            this.fld_lblLabel29.BOSFieldRelation = "";
            this.fld_lblLabel29.BOSPrivilege = "";
            this.fld_lblLabel29.BOSPropertyName = null;
            this.fld_lblLabel29.Location = new System.Drawing.Point(99, 68);
            this.fld_lblLabel29.Name = "fld_lblLabel29";
            this.fld_lblLabel29.Screen = null;
            this.fld_lblLabel29.Size = new System.Drawing.Size(6, 13);
            this.fld_lblLabel29.TabIndex = 20;
            this.fld_lblLabel29.Tag = "";
            this.fld_lblLabel29.Text = "0";
            // 
            // BOSTabControl1
            // 
            this.BOSTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BOSTabControl1.BOSComment = null;
            this.BOSTabControl1.BOSDataMember = null;
            this.BOSTabControl1.BOSDataSource = null;
            this.BOSTabControl1.BOSDescription = null;
            this.BOSTabControl1.BOSError = null;
            this.BOSTabControl1.BOSFieldGroup = null;
            this.BOSTabControl1.BOSFieldRelation = null;
            this.BOSTabControl1.BOSPrivilege = null;
            this.BOSTabControl1.BOSPropertyName = null;
            this.BOSTabControl1.Location = new System.Drawing.Point(15, 190);
            this.BOSTabControl1.Name = "BOSTabControl1";
            this.BOSTabControl1.Screen = null;
            this.BOSTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.BOSTabControl1.Size = new System.Drawing.Size(874, 251);
            this.BOSTabControl1.TabIndex = 21;
            this.BOSTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage1});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcARSaleOrders);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(867, 222);
            this.xtraTabPage2.Text = "Danh sách đơn đặt hàng";
            // 
            // fld_dgcARSaleOrders
            // 
            this.fld_dgcARSaleOrders.BOSComment = null;
            this.fld_dgcARSaleOrders.BOSDataMember = null;
            this.fld_dgcARSaleOrders.BOSDataSource = "ARSaleOrders";
            this.fld_dgcARSaleOrders.BOSDescription = null;
            this.fld_dgcARSaleOrders.BOSError = null;
            this.fld_dgcARSaleOrders.BOSFieldGroup = null;
            this.fld_dgcARSaleOrders.BOSFieldRelation = null;
            this.fld_dgcARSaleOrders.BOSGridType = null;
            this.fld_dgcARSaleOrders.BOSPrivilege = null;
            this.fld_dgcARSaleOrders.BOSPropertyName = null;
            this.fld_dgcARSaleOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARSaleOrders.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcARSaleOrders.MenuManager = this.screenToolbar;
            this.fld_dgcARSaleOrders.Name = "fld_dgcARSaleOrders";
            this.fld_dgcARSaleOrders.Screen = null;
            this.fld_dgcARSaleOrders.Size = new System.Drawing.Size(867, 222);
            this.fld_dgcARSaleOrders.TabIndex = 0;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcARInvoices);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(867, 222);
            this.xtraTabPage1.Text = "Danh sách hóa đơn";
            // 
            // fld_dgcARInvoices
            // 
            this.fld_dgcARInvoices.BOSComment = null;
            this.fld_dgcARInvoices.BOSDataMember = null;
            this.fld_dgcARInvoices.BOSDataSource = "ARInvoices";
            this.fld_dgcARInvoices.BOSDescription = null;
            this.fld_dgcARInvoices.BOSError = null;
            this.fld_dgcARInvoices.BOSFieldGroup = null;
            this.fld_dgcARInvoices.BOSFieldRelation = null;
            this.fld_dgcARInvoices.BOSGridType = null;
            this.fld_dgcARInvoices.BOSPrivilege = null;
            this.fld_dgcARInvoices.BOSPropertyName = null;
            this.fld_dgcARInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcARInvoices.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcARInvoices.MenuManager = this.screenToolbar;
            this.fld_dgcARInvoices.Name = "fld_dgcARInvoices";
            this.fld_dgcARInvoices.Screen = null;
            this.fld_dgcARInvoices.Size = new System.Drawing.Size(867, 222);
            this.fld_dgcARInvoices.TabIndex = 0;
            // 
            // fld_crtCustomerPurchase
            // 
            this.fld_crtCustomerPurchase.BOSComment = null;
            this.fld_crtCustomerPurchase.BOSDataMember = null;
            this.fld_crtCustomerPurchase.BOSDataSource = "ARInvoices";
            this.fld_crtCustomerPurchase.BOSDescription = null;
            this.fld_crtCustomerPurchase.BOSError = null;
            this.fld_crtCustomerPurchase.BOSFieldGroup = null;
            this.fld_crtCustomerPurchase.BOSFieldRelation = null;
            this.fld_crtCustomerPurchase.BOSPrivilege = null;
            this.fld_crtCustomerPurchase.BOSPropertyName = null;            
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.fld_crtCustomerPurchase.Diagram = xyDiagram1;
            this.fld_crtCustomerPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_crtCustomerPurchase.FilterType = BOSERP.OverTimeChart.FilterTypeEnum.DayOfWeek;
            this.fld_crtCustomerPurchase.Location = new System.Drawing.Point(0, 0);
            this.fld_crtCustomerPurchase.Name = "fld_crtCustomerPurchase";
            this.fld_crtCustomerPurchase.Screen = null;
            pointSeriesLabel1.LineVisible = true;
            series1.Label = pointSeriesLabel1;
            series1.Name = "Series 1";
            pointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number;
            pointOptions1.ValueNumericOptions.Precision = 0;
            series1.PointOptions = pointOptions1;
            series1.View = lineSeriesView1;
            this.fld_crtCustomerPurchase.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            pointSeriesLabel2.LineVisible = true;
            this.fld_crtCustomerPurchase.SeriesTemplate.Label = pointSeriesLabel2;
            this.fld_crtCustomerPurchase.SeriesTemplate.View = lineSeriesView2;
            this.fld_crtCustomerPurchase.Size = new System.Drawing.Size(840, 260);
            this.fld_crtCustomerPurchase.TabIndex = 22;
            // 
            // BOSTabControl2
            // 
            this.BOSTabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BOSTabControl2.BOSComment = null;
            this.BOSTabControl2.BOSDataMember = null;
            this.BOSTabControl2.BOSDataSource = null;
            this.BOSTabControl2.BOSDescription = null;
            this.BOSTabControl2.BOSError = null;
            this.BOSTabControl2.BOSFieldGroup = null;
            this.BOSTabControl2.BOSFieldRelation = null;
            this.BOSTabControl2.BOSPrivilege = null;
            this.BOSTabControl2.BOSPropertyName = null;
            this.BOSTabControl2.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right;
            this.BOSTabControl2.Location = new System.Drawing.Point(15, 450);
            this.BOSTabControl2.Name = "BOSTabControl2";
            this.BOSTabControl2.Screen = null;
            this.BOSTabControl2.SelectedTabPage = this.xtraTabPage3;
            this.BOSTabControl2.Size = new System.Drawing.Size(869, 267);
            this.BOSTabControl2.TabIndex = 23;
            this.BOSTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_crtCustomerPurchase);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(840, 260);
            this.xtraTabPage3.Text = "Thống kê mua hàng";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.fld_crtCustomerPayment);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(840, 260);
            this.xtraTabPage4.Text = "Thống kê thanh toán";
            // 
            // fld_crtCustomerPayment
            // 
            this.fld_crtCustomerPayment.BOSComment = null;
            this.fld_crtCustomerPayment.BOSDataMember = null;
            this.fld_crtCustomerPayment.BOSDataSource = "ARCustomerPayments";
            this.fld_crtCustomerPayment.BOSDescription = null;
            this.fld_crtCustomerPayment.BOSError = null;
            this.fld_crtCustomerPayment.BOSFieldGroup = null;
            this.fld_crtCustomerPayment.BOSFieldRelation = null;
            this.fld_crtCustomerPayment.BOSPrivilege = null;
            this.fld_crtCustomerPayment.BOSPropertyName = null;            
            xyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.fld_crtCustomerPayment.Diagram = xyDiagram2;
            this.fld_crtCustomerPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_crtCustomerPayment.FilterType = BOSERP.OverTimeChart.FilterTypeEnum.DayOfWeek;
            this.fld_crtCustomerPayment.Location = new System.Drawing.Point(0, 0);
            this.fld_crtCustomerPayment.Name = "fld_crtCustomerPayment";
            this.fld_crtCustomerPayment.Screen = null;
            pointSeriesLabel3.LineVisible = true;
            series2.Label = pointSeriesLabel3;
            series2.Name = "Series 1";
            pointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number;
            pointOptions2.ValueNumericOptions.Precision = 0;
            series2.PointOptions = pointOptions2;
            series2.View = lineSeriesView3;
            this.fld_crtCustomerPayment.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            pointSeriesLabel4.LineVisible = true;
            this.fld_crtCustomerPayment.SeriesTemplate.Label = pointSeriesLabel4;
            this.fld_crtCustomerPayment.SeriesTemplate.View = lineSeriesView4;
            this.fld_crtCustomerPayment.Size = new System.Drawing.Size(840, 260);
            this.fld_crtCustomerPayment.TabIndex = 23;
            // 
            // BOSPanel1
            // 
            this.BOSPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BOSPanel1.BOSComment = null;
            this.BOSPanel1.BOSDataMember = null;
            this.BOSPanel1.BOSDataSource = null;
            this.BOSPanel1.BOSDescription = null;
            this.BOSPanel1.BOSError = null;
            this.BOSPanel1.BOSFieldGroup = null;
            this.BOSPanel1.BOSFieldRelation = null;
            this.BOSPanel1.BOSPrivilege = null;
            this.BOSPanel1.BOSPropertyName = null;
            this.BOSPanel1.Controls.Add(this.fld_lblLabel21);
            this.BOSPanel1.Controls.Add(this.fld_lblLabel29);
            this.BOSPanel1.Controls.Add(this.fld_lblLabel28);
            this.BOSPanel1.Controls.Add(this.fld_lblLabel24);
            this.BOSPanel1.Controls.Add(this.fld_lblLabel23);
            this.BOSPanel1.Controls.Add(this.fld_Line);
            this.BOSPanel1.Location = new System.Drawing.Point(17, 58);
            this.BOSPanel1.Name = "BOSPanel1";
            this.BOSPanel1.Screen = null;
            this.BOSPanel1.Size = new System.Drawing.Size(265, 126);
            this.BOSPanel1.TabIndex = 25;
            // 
            // BOSPanel2
            // 
            this.BOSPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BOSPanel2.BOSComment = null;
            this.BOSPanel2.BOSDataMember = null;
            this.BOSPanel2.BOSDataSource = null;
            this.BOSPanel2.BOSDescription = null;
            this.BOSPanel2.BOSError = null;
            this.BOSPanel2.BOSFieldGroup = null;
            this.BOSPanel2.BOSFieldRelation = null;
            this.BOSPanel2.BOSPrivilege = null;
            this.BOSPanel2.BOSPropertyName = null;
            this.BOSPanel2.Controls.Add(this.BOSLabel1);
            this.BOSPanel2.Controls.Add(this.BOSLabel3);
            this.BOSPanel2.Controls.Add(this.bosLabel20);
            this.BOSPanel2.Controls.Add(this.BOSLabel9);
            this.BOSPanel2.Controls.Add(this.bosLabel10);
            this.BOSPanel2.Controls.Add(this.BOSLabel5);
            this.BOSPanel2.Controls.Add(this.BOSLabel6);
            this.BOSPanel2.Controls.Add(this.BOSLine1);
            this.BOSPanel2.Controls.Add(this.BOSLabel7);
            this.BOSPanel2.Controls.Add(this.BOSLabel2);
            this.BOSPanel2.Location = new System.Drawing.Point(289, 58);
            this.BOSPanel2.Name = "BOSPanel2";
            this.BOSPanel2.Screen = null;
            this.BOSPanel2.Size = new System.Drawing.Size(401, 126);
            this.BOSPanel2.TabIndex = 25;
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = "";
            this.bosLabel20.BOSDataMember = "TotalRefundQty";
            this.bosLabel20.BOSDataSource = "ARCustomers";
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = "";
            this.bosLabel20.BOSFieldRelation = "";
            this.bosLabel20.BOSPrivilege = "";
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(327, 68);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(6, 13);
            this.bosLabel20.TabIndex = 10;
            this.bosLabel20.Tag = "";
            this.bosLabel20.Text = "0";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = "";
            this.bosLabel10.BOSDataMember = "";
            this.bosLabel10.BOSDataSource = "";
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = "";
            this.bosLabel10.BOSFieldRelation = "";
            this.bosLabel10.BOSPrivilege = "";
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(219, 68);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(86, 13);
            this.bosLabel10.TabIndex = 9;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Số lượng trả hàng";
            // 
            // fld_dteHistoryDateFrom
            // 
            this.fld_dteHistoryDateFrom.BOSComment = null;
            this.fld_dteHistoryDateFrom.BOSDataMember = null;
            this.fld_dteHistoryDateFrom.BOSDataSource = null;
            this.fld_dteHistoryDateFrom.BOSDescription = null;
            this.fld_dteHistoryDateFrom.BOSError = null;
            this.fld_dteHistoryDateFrom.BOSFieldGroup = null;
            this.fld_dteHistoryDateFrom.BOSFieldRelation = null;
            this.fld_dteHistoryDateFrom.BOSPrivilege = null;
            this.fld_dteHistoryDateFrom.BOSPropertyName = null;
            this.fld_dteHistoryDateFrom.EditValue = null;
            this.fld_dteHistoryDateFrom.Location = new System.Drawing.Point(94, 9);
            this.fld_dteHistoryDateFrom.MenuManager = this.screenToolbar;
            this.fld_dteHistoryDateFrom.Name = "fld_dteHistoryDateFrom";
            this.fld_dteHistoryDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHistoryDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHistoryDateFrom.Screen = null;
            this.fld_dteHistoryDateFrom.Size = new System.Drawing.Size(132, 20);
            this.fld_dteHistoryDateFrom.TabIndex = 0;
            // 
            // fld_dteHistoryDateTo
            // 
            this.fld_dteHistoryDateTo.BOSComment = null;
            this.fld_dteHistoryDateTo.BOSDataMember = null;
            this.fld_dteHistoryDateTo.BOSDataSource = null;
            this.fld_dteHistoryDateTo.BOSDescription = null;
            this.fld_dteHistoryDateTo.BOSError = null;
            this.fld_dteHistoryDateTo.BOSFieldGroup = null;
            this.fld_dteHistoryDateTo.BOSFieldRelation = null;
            this.fld_dteHistoryDateTo.BOSPrivilege = null;
            this.fld_dteHistoryDateTo.BOSPropertyName = null;
            this.fld_dteHistoryDateTo.EditValue = null;
            this.fld_dteHistoryDateTo.Location = new System.Drawing.Point(320, 9);
            this.fld_dteHistoryDateTo.Name = "fld_dteHistoryDateTo";
            this.fld_dteHistoryDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHistoryDateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHistoryDateTo.Screen = null;
            this.fld_dteHistoryDateTo.Size = new System.Drawing.Size(132, 20);
            this.fld_dteHistoryDateTo.TabIndex = 1;
            // 
            // bosLabel14
            // 
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = null;
            this.bosLabel14.BOSDataSource = null;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(15, 12);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(40, 13);
            this.bosLabel14.TabIndex = 27;
            this.bosLabel14.Text = "Từ ngày";
            // 
            // bosLabel15
            // 
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = null;
            this.bosLabel15.BOSDataSource = null;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = null;
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(258, 12);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(47, 13);
            this.bosLabel15.TabIndex = 27;
            this.bosLabel15.Text = "Đến ngày";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_btnFilter);
            this.panelControl1.Controls.Add(this.bosLabel14);
            this.panelControl1.Controls.Add(this.bosLabel15);
            this.panelControl1.Controls.Add(this.fld_dteHistoryDateFrom);
            this.panelControl1.Controls.Add(this.fld_dteHistoryDateTo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(892, 39);
            this.panelControl1.TabIndex = 28;
            // 
            // fld_btnFilter
            // 
            this.fld_btnFilter.BOSComment = null;
            this.fld_btnFilter.BOSDataMember = null;
            this.fld_btnFilter.BOSDataSource = null;
            this.fld_btnFilter.BOSDescription = null;
            this.fld_btnFilter.BOSError = null;
            this.fld_btnFilter.BOSFieldGroup = null;
            this.fld_btnFilter.BOSFieldRelation = null;
            this.fld_btnFilter.BOSPrivilege = null;
            this.fld_btnFilter.BOSPropertyName = null;
            this.fld_btnFilter.Location = new System.Drawing.Point(545, 5);
            this.fld_btnFilter.Name = "fld_btnFilter";
            this.fld_btnFilter.Screen = null;
            this.fld_btnFilter.Size = new System.Drawing.Size(67, 27);
            this.fld_btnFilter.TabIndex = 2;
            this.fld_btnFilter.Text = "Tìm kiếm";
            this.fld_btnFilter.Click += new System.EventHandler(this.fld_btnFilter_Click);
            // 
            // bosPanel3
            // 
            this.bosPanel3.BOSComment = null;
            this.bosPanel3.BOSDataMember = null;
            this.bosPanel3.BOSDataSource = null;
            this.bosPanel3.BOSDescription = null;
            this.bosPanel3.BOSError = null;
            this.bosPanel3.BOSFieldGroup = null;
            this.bosPanel3.BOSFieldRelation = null;
            this.bosPanel3.BOSPrivilege = null;
            this.bosPanel3.BOSPropertyName = null;
            this.bosPanel3.Controls.Add(this.panelControl1);
            this.bosPanel3.Controls.Add(this.BOSPanel2);
            this.bosPanel3.Controls.Add(this.BOSTabControl1);
            this.bosPanel3.Controls.Add(this.BOSTabControl2);
            this.bosPanel3.Controls.Add(this.BOSPanel1);
            this.bosPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel3.Location = new System.Drawing.Point(0, 0);
            this.bosPanel3.Name = "bosPanel3";
            this.bosPanel3.Screen = null;
            this.bosPanel3.Size = new System.Drawing.Size(892, 720);
            this.bosPanel3.TabIndex = 29;
            // 
            // DMCU101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(892, 720);
            this.Controls.Add(this.bosPanel3);
            this.Name = "DMCU101";
            this.Text = "Lịch sử bán hàng";
            this.Controls.SetChildIndex(this.bosPanel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BOSTabControl1)).EndInit();
            this.BOSTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARSaleOrders)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_crtCustomerPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOSTabControl2)).EndInit();
            this.BOSTabControl2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_crtCustomerPayment)).EndInit();
            this.BOSPanel1.ResumeLayout(false);
            this.BOSPanel1.PerformLayout();
            this.BOSPanel2.ResumeLayout(false);
            this.BOSPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHistoryDateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHistoryDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHistoryDateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHistoryDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.bosPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSTabControl BOSTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ARInvoicesGridControl fld_dgcARInvoices;
        private ARSaleOrdersGridControl fld_dgcARSaleOrders;
        private OverTimeChart fld_crtCustomerPurchase;
        private BOSComponent.BOSTabControl BOSTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private OverTimeChart fld_crtCustomerPayment;
        private BOSComponent.BOSPanel BOSPanel1;
        private BOSComponent.BOSPanel BOSPanel2;
        private BOSComponent.BOSDateEdit fld_dteHistoryDateFrom;
        private BOSComponent.BOSDateEdit fld_dteHistoryDateTo;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel15;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSButton fld_btnFilter;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSPanel bosPanel3;
    }
}
