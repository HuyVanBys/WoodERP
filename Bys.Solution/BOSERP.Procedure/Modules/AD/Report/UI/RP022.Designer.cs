namespace BOSERP.Modules.Report
{
    partial class RP022
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP022));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dteSearchToARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_chcSaleOverTime = new BOSComponent.BOSChartControl(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.BOSLabel4 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblFilter = new BOSComponent.BOSLabel(this.components);
            this.fld_ctxMenuStripFilter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fld_ctxItemDayOfWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.fld_ctxItemDayOfMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.fld_ctxItemMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.fld_ctxItemYear = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chcSaleOverTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            this.fld_ctxMenuStripFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.fld_dteSearchToARInvoiceDate);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromARInvoiceDate);
            this.panelControl1.Controls.Add(this.BOSLabel2);
            this.panelControl1.Controls.Add(this.BOSLabel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1222, 48);
            this.panelControl1.TabIndex = 6;
            // 
            // fld_btnApply
            // 
            this.fld_btnApply.BOSComment = null;
            this.fld_btnApply.BOSDataMember = null;
            this.fld_btnApply.BOSDataSource = null;
            this.fld_btnApply.BOSDescription = null;
            this.fld_btnApply.BOSError = null;
            this.fld_btnApply.BOSFieldGroup = null;
            this.fld_btnApply.BOSFieldRelation = null;
            this.fld_btnApply.BOSPrivilege = null;
            this.fld_btnApply.BOSPropertyName = null;
            this.fld_btnApply.Location = new System.Drawing.Point(477, 6);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 23);
            this.fld_btnApply.TabIndex = 8;
            this.fld_btnApply.Text = "Áp dụng";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dteSearchToARInvoiceDate
            // 
            this.fld_dteSearchToARInvoiceDate.BOSComment = null;
            this.fld_dteSearchToARInvoiceDate.BOSDataMember = "ARInvoiceDate";
            this.fld_dteSearchToARInvoiceDate.BOSDataSource = "ARInvoices";
            this.fld_dteSearchToARInvoiceDate.BOSDescription = null;
            this.fld_dteSearchToARInvoiceDate.BOSError = null;
            this.fld_dteSearchToARInvoiceDate.BOSFieldGroup = null;
            this.fld_dteSearchToARInvoiceDate.BOSFieldRelation = null;
            this.fld_dteSearchToARInvoiceDate.BOSPrivilege = null;
            this.fld_dteSearchToARInvoiceDate.BOSPropertyName = null;
            this.fld_dteSearchToARInvoiceDate.EditValue = null;
            this.fld_dteSearchToARInvoiceDate.Location = new System.Drawing.Point(295, 9);
            this.fld_dteSearchToARInvoiceDate.Name = "fld_dteSearchToARInvoiceDate";
            this.fld_dteSearchToARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARInvoiceDate.Screen = null;
            this.fld_dteSearchToARInvoiceDate.Size = new System.Drawing.Size(100, 20);
            this.fld_dteSearchToARInvoiceDate.TabIndex = 9;
            this.fld_dteSearchToARInvoiceDate.Tag = "SC";
            // 
            // fld_dteSearchFromARInvoiceDate
            // 
            this.fld_dteSearchFromARInvoiceDate.BOSComment = null;
            this.fld_dteSearchFromARInvoiceDate.BOSDataMember = "ARInvoiceDate";
            this.fld_dteSearchFromARInvoiceDate.BOSDataSource = "ARInvoices";
            this.fld_dteSearchFromARInvoiceDate.BOSDescription = null;
            this.fld_dteSearchFromARInvoiceDate.BOSError = null;
            this.fld_dteSearchFromARInvoiceDate.BOSFieldGroup = null;
            this.fld_dteSearchFromARInvoiceDate.BOSFieldRelation = null;
            this.fld_dteSearchFromARInvoiceDate.BOSPrivilege = null;
            this.fld_dteSearchFromARInvoiceDate.BOSPropertyName = null;
            this.fld_dteSearchFromARInvoiceDate.EditValue = null;
            this.fld_dteSearchFromARInvoiceDate.Location = new System.Drawing.Point(89, 9);
            this.fld_dteSearchFromARInvoiceDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchFromARInvoiceDate.Name = "fld_dteSearchFromARInvoiceDate";
            this.fld_dteSearchFromARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARInvoiceDate.Screen = null;
            this.fld_dteSearchFromARInvoiceDate.Size = new System.Drawing.Size(100, 20);
            this.fld_dteSearchFromARInvoiceDate.TabIndex = 9;
            this.fld_dteSearchFromARInvoiceDate.Tag = "SC";
            // 
            // BOSLabel2
            // 
            this.BOSLabel2.BOSComment = null;
            this.BOSLabel2.BOSDataMember = null;
            this.BOSLabel2.BOSDataSource = null;
            this.BOSLabel2.BOSDescription = null;
            this.BOSLabel2.BOSError = null;
            this.BOSLabel2.BOSFieldGroup = null;
            this.BOSLabel2.BOSFieldRelation = null;
            this.BOSLabel2.BOSPrivilege = null;
            this.BOSLabel2.BOSPropertyName = null;
            this.BOSLabel2.Location = new System.Drawing.Point(251, 12);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(20, 13);
            this.BOSLabel2.TabIndex = 7;
            this.BOSLabel2.Text = "Đến";
            // 
            // BOSLabel1
            // 
            this.BOSLabel1.BOSComment = null;
            this.BOSLabel1.BOSDataMember = null;
            this.BOSLabel1.BOSDataSource = null;
            this.BOSLabel1.BOSDescription = null;
            this.BOSLabel1.BOSError = null;
            this.BOSLabel1.BOSFieldGroup = null;
            this.BOSLabel1.BOSFieldRelation = null;
            this.BOSLabel1.BOSPrivilege = null;
            this.BOSLabel1.BOSPropertyName = null;
            this.BOSLabel1.Location = new System.Drawing.Point(12, 12);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(40, 13);
            this.BOSLabel1.TabIndex = 7;
            this.BOSLabel1.Text = "Từ ngày";
            // 
            // fld_chcSaleOverTime
            // 
            this.fld_chcSaleOverTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_chcSaleOverTime.BorderOptions.Visible = false;
            this.fld_chcSaleOverTime.BOSComment = null;
            this.fld_chcSaleOverTime.BOSDataMember = null;
            this.fld_chcSaleOverTime.BOSDataSource = null;
            this.fld_chcSaleOverTime.BOSDescription = null;
            this.fld_chcSaleOverTime.BOSError = null;
            this.fld_chcSaleOverTime.BOSFieldGroup = null;
            this.fld_chcSaleOverTime.BOSFieldRelation = null;
            this.fld_chcSaleOverTime.BOSPrivilege = null;
            this.fld_chcSaleOverTime.BOSPropertyName = null;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.fld_chcSaleOverTime.Diagram = xyDiagram1;
            this.fld_chcSaleOverTime.Location = new System.Drawing.Point(23, 127);
            this.fld_chcSaleOverTime.Name = "fld_chcSaleOverTime";
            this.fld_chcSaleOverTime.Screen = null;
            pointSeriesLabel1.LineVisible = true;
            series1.Label = pointSeriesLabel1;
            series1.Name = "Series 1";
            lineSeriesView1.ColorEach = true;
            series1.View = lineSeriesView1;
            this.fld_chcSaleOverTime.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            pointSeriesLabel2.LineVisible = true;
            this.fld_chcSaleOverTime.SeriesTemplate.Label = pointSeriesLabel2;
            this.fld_chcSaleOverTime.SeriesTemplate.View = lineSeriesView2;
            this.fld_chcSaleOverTime.Size = new System.Drawing.Size(1129, 504);
            this.fld_chcSaleOverTime.TabIndex = 8;
            // 
            // fld_btnClose
            // 
            this.fld_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnClose.BOSComment = null;
            this.fld_btnClose.BOSDataMember = null;
            this.fld_btnClose.BOSDataSource = null;
            this.fld_btnClose.BOSDescription = null;
            this.fld_btnClose.BOSError = null;
            this.fld_btnClose.BOSFieldGroup = null;
            this.fld_btnClose.BOSFieldRelation = null;
            this.fld_btnClose.BOSPrivilege = null;
            this.fld_btnClose.BOSPropertyName = null;
            this.fld_btnClose.Location = new System.Drawing.Point(1133, 675);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 23);
            this.fld_btnClose.TabIndex = 8;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // BOSLabel4
            // 
            this.BOSLabel4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.BOSLabel4.Appearance.Options.UseFont = true;
            this.BOSLabel4.BOSComment = null;
            this.BOSLabel4.BOSDataMember = null;
            this.BOSLabel4.BOSDataSource = null;
            this.BOSLabel4.BOSDescription = null;
            this.BOSLabel4.BOSError = null;
            this.BOSLabel4.BOSFieldGroup = null;
            this.BOSLabel4.BOSFieldRelation = null;
            this.BOSLabel4.BOSPrivilege = null;
            this.BOSLabel4.BOSPropertyName = null;
            this.BOSLabel4.Location = new System.Drawing.Point(528, 77);
            this.BOSLabel4.Name = "BOSLabel4";
            this.BOSLabel4.Screen = null;
            this.BOSLabel4.Size = new System.Drawing.Size(248, 19);
            this.BOSLabel4.TabIndex = 7;
            this.BOSLabel4.Text = "Đồ thị bán hàng theo thời gian";
            // 
            // BOSLabel3
            // 
            this.BOSLabel3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.BOSLabel3.Appearance.Options.UseFont = true;
            this.BOSLabel3.BOSComment = null;
            this.BOSLabel3.BOSDataMember = null;
            this.BOSLabel3.BOSDataSource = null;
            this.BOSLabel3.BOSDescription = null;
            this.BOSLabel3.BOSError = null;
            this.BOSLabel3.BOSFieldGroup = null;
            this.BOSLabel3.BOSFieldRelation = null;
            this.BOSLabel3.BOSPrivilege = null;
            this.BOSLabel3.BOSPropertyName = null;
            this.BOSLabel3.Location = new System.Drawing.Point(23, 108);
            this.BOSLabel3.Name = "BOSLabel3";
            this.BOSLabel3.Screen = null;
            this.BOSLabel3.Size = new System.Drawing.Size(53, 13);
            this.BOSLabel3.TabIndex = 7;
            this.BOSLabel3.Text = "Tổng tiền";
            // 
            // fld_lblFilter
            // 
            this.fld_lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblFilter.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblFilter.Appearance.Options.UseFont = true;
            this.fld_lblFilter.BOSComment = null;
            this.fld_lblFilter.BOSDataMember = null;
            this.fld_lblFilter.BOSDataSource = null;
            this.fld_lblFilter.BOSDescription = null;
            this.fld_lblFilter.BOSError = null;
            this.fld_lblFilter.BOSFieldGroup = null;
            this.fld_lblFilter.BOSFieldRelation = null;
            this.fld_lblFilter.BOSPrivilege = null;
            this.fld_lblFilter.BOSPropertyName = null;
            this.fld_lblFilter.ContextMenuStrip = this.fld_ctxMenuStripFilter;
            this.fld_lblFilter.Location = new System.Drawing.Point(1008, 637);
            this.fld_lblFilter.Name = "fld_lblFilter";
            this.fld_lblFilter.Screen = null;
            this.fld_lblFilter.Size = new System.Drawing.Size(91, 13);
            this.fld_lblFilter.TabIndex = 7;
            this.fld_lblFilter.Text = "Ngày trong tuần";
            // 
            // fld_ctxMenuStripFilter
            // 
            this.fld_ctxMenuStripFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fld_ctxItemDayOfWeek,
            this.fld_ctxItemDayOfMonth,
            this.fld_ctxItemMonth,
            this.fld_ctxItemYear});
            this.fld_ctxMenuStripFilter.Name = "fld_ctxMenuStripFilter";
            this.fld_ctxMenuStripFilter.Size = new System.Drawing.Size(148, 92);
            // 
            // fld_ctxItemDayOfWeek
            // 
            this.fld_ctxItemDayOfWeek.Name = "fld_ctxItemDayOfWeek";
            this.fld_ctxItemDayOfWeek.Size = new System.Drawing.Size(147, 22);
            this.fld_ctxItemDayOfWeek.Text = "Day of Week";
            this.fld_ctxItemDayOfWeek.Click += new System.EventHandler(this.fld_ctxItemDayOfWeek_Click);
            // 
            // fld_ctxItemDayOfMonth
            // 
            this.fld_ctxItemDayOfMonth.Name = "fld_ctxItemDayOfMonth";
            this.fld_ctxItemDayOfMonth.Size = new System.Drawing.Size(147, 22);
            this.fld_ctxItemDayOfMonth.Text = "Day of Month";
            this.fld_ctxItemDayOfMonth.Click += new System.EventHandler(this.fld_ctxItemDayOfMonth_Click);
            // 
            // fld_ctxItemMonth
            // 
            this.fld_ctxItemMonth.Name = "fld_ctxItemMonth";
            this.fld_ctxItemMonth.Size = new System.Drawing.Size(147, 22);
            this.fld_ctxItemMonth.Text = "Month";
            this.fld_ctxItemMonth.Click += new System.EventHandler(this.fld_ctxItemMonth_Click);
            // 
            // fld_ctxItemYear
            // 
            this.fld_ctxItemYear.Name = "fld_ctxItemYear";
            this.fld_ctxItemYear.Size = new System.Drawing.Size(147, 22);
            this.fld_ctxItemYear.Text = "Year";
            this.fld_ctxItemYear.Click += new System.EventHandler(this.fld_ctxItemYear_Click);
            // 
            // RP022
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 710);
            this.Controls.Add(this.fld_chcSaleOverTime);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.BOSLabel3);
            this.Controls.Add(this.BOSLabel4);
            this.Controls.Add(this.fld_lblFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RP022";
            this.Tag = "SS";
            this.Text = "Đồ thị bán hàng theo thời gian";
            this.Load += new System.EventHandler(this.RP022_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chcSaleOverTime)).EndInit();
            this.fld_ctxMenuStripFilter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSDateEdit fld_dteSearchToARInvoiceDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARInvoiceDate;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSChartControl fld_chcSaleOverTime;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSLabel BOSLabel4;
        private BOSComponent.BOSLabel BOSLabel3;
        private BOSComponent.BOSLabel fld_lblFilter;
        private System.Windows.Forms.ContextMenuStrip fld_ctxMenuStripFilter;
        private System.Windows.Forms.ToolStripMenuItem fld_ctxItemDayOfWeek;
        private System.Windows.Forms.ToolStripMenuItem fld_ctxItemDayOfMonth;
        private System.Windows.Forms.ToolStripMenuItem fld_ctxItemMonth;
        private System.Windows.Forms.ToolStripMenuItem fld_ctxItemYear;
    }
}