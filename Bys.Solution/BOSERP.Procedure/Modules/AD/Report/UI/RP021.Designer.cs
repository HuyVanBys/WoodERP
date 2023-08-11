namespace BOSERP.Modules.Report
{
    partial class RP021
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
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP021));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_dteSearchToARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_lblAxisY = new BOSComponent.BOSLabel(this.components);
            this.fld_ctmExisY = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.extPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalCoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qtyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fld_cctrlARRP021InvoiceItems = new BOSComponent.BOSChartControl(this.components);
            this.fld_ctmExisX = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fld_lblAxisX = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties)).BeginInit();
            this.fld_ctmExisY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cctrlARRP021InvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            this.fld_ctmExisX.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_dteSearchToARInvoiceDate);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromARInvoiceDate);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.BOSLabel2);
            this.panelControl1.Controls.Add(this.BOSLabel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1256, 47);
            this.panelControl1.TabIndex = 0;
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
            this.fld_dteSearchToARInvoiceDate.Location = new System.Drawing.Point(355, 12);
            this.fld_dteSearchToARInvoiceDate.Name = "fld_dteSearchToARInvoiceDate";
            this.fld_dteSearchToARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARInvoiceDate.Screen = null;
            this.fld_dteSearchToARInvoiceDate.Size = new System.Drawing.Size(115, 20);
            this.fld_dteSearchToARInvoiceDate.TabIndex = 2;
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
            this.fld_dteSearchFromARInvoiceDate.Location = new System.Drawing.Point(110, 12);
            this.fld_dteSearchFromARInvoiceDate.Name = "fld_dteSearchFromARInvoiceDate";
            this.fld_dteSearchFromARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARInvoiceDate.Screen = null;
            this.fld_dteSearchFromARInvoiceDate.Size = new System.Drawing.Size(115, 20);
            this.fld_dteSearchFromARInvoiceDate.TabIndex = 2;
            this.fld_dteSearchFromARInvoiceDate.Tag = "SC";
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
            this.fld_btnApply.Location = new System.Drawing.Point(516, 9);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 23);
            this.fld_btnApply.TabIndex = 1;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
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
            this.BOSLabel2.Location = new System.Drawing.Point(298, 15);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(20, 13);
            this.BOSLabel2.TabIndex = 0;
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
            this.BOSLabel1.Location = new System.Drawing.Point(27, 15);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(40, 13);
            this.BOSLabel1.TabIndex = 0;
            this.BOSLabel1.Text = "Từ ngày";
            // 
            // BOSLabel3
            // 
            this.BOSLabel3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
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
            this.BOSLabel3.Location = new System.Drawing.Point(539, 77);
            this.BOSLabel3.Name = "BOSLabel3";
            this.BOSLabel3.Screen = null;
            this.BOSLabel3.Size = new System.Drawing.Size(167, 19);
            this.BOSLabel3.TabIndex = 0;
            this.BOSLabel3.Text = "Đồ thị sản phẩm bán";
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
            this.fld_btnClose.Location = new System.Drawing.Point(1145, 701);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 23);
            this.fld_btnClose.TabIndex = 2;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_lblAxisY
            // 
            this.fld_lblAxisY.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblAxisY.Appearance.Options.UseFont = true;
            this.fld_lblAxisY.BOSComment = null;
            this.fld_lblAxisY.BOSDataMember = null;
            this.fld_lblAxisY.BOSDataSource = null;
            this.fld_lblAxisY.BOSDescription = null;
            this.fld_lblAxisY.BOSError = null;
            this.fld_lblAxisY.BOSFieldGroup = null;
            this.fld_lblAxisY.BOSFieldRelation = null;
            this.fld_lblAxisY.BOSPrivilege = null;
            this.fld_lblAxisY.BOSPropertyName = null;
            this.fld_lblAxisY.ContextMenuStrip = this.fld_ctmExisY;
            this.fld_lblAxisY.Location = new System.Drawing.Point(27, 107);
            this.fld_lblAxisY.Name = "fld_lblAxisY";
            this.fld_lblAxisY.Screen = null;
            this.fld_lblAxisY.Size = new System.Drawing.Size(72, 13);
            this.fld_lblAxisY.TabIndex = 7;
            this.fld_lblAxisY.Text = "Tổng giá bán";
            // 
            // fld_ctmExisY
            // 
            this.fld_ctmExisY.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extPriceToolStripMenuItem,
            this.totalCoatToolStripMenuItem,
            this.qtyToolStripMenuItem});
            this.fld_ctmExisY.Name = "contextMenuStrip1";
            this.fld_ctmExisY.Size = new System.Drawing.Size(122, 70);
            // 
            // extPriceToolStripMenuItem
            // 
            this.extPriceToolStripMenuItem.Name = "extPriceToolStripMenuItem";
            this.extPriceToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.extPriceToolStripMenuItem.Text = "Ext. Price";
            this.extPriceToolStripMenuItem.Click += new System.EventHandler(this.axisYToolStripMenuItem_Click);
            // 
            // totalCoatToolStripMenuItem
            // 
            this.totalCoatToolStripMenuItem.Name = "totalCoatToolStripMenuItem";
            this.totalCoatToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.totalCoatToolStripMenuItem.Text = "Ext. Cost";
            this.totalCoatToolStripMenuItem.Click += new System.EventHandler(this.axisYToolStripMenuItem_Click);
            // 
            // qtyToolStripMenuItem
            // 
            this.qtyToolStripMenuItem.Name = "qtyToolStripMenuItem";
            this.qtyToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.qtyToolStripMenuItem.Text = "Qty";
            this.qtyToolStripMenuItem.Click += new System.EventHandler(this.axisYToolStripMenuItem_Click);
            // 
            // fld_cctrlARRP021InvoiceItems
            // 
            this.fld_cctrlARRP021InvoiceItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_cctrlARRP021InvoiceItems.BorderOptions.Visible = false;
            this.fld_cctrlARRP021InvoiceItems.BOSComment = null;
            this.fld_cctrlARRP021InvoiceItems.BOSDataMember = null;
            this.fld_cctrlARRP021InvoiceItems.BOSDataSource = null;
            this.fld_cctrlARRP021InvoiceItems.BOSDescription = null;
            this.fld_cctrlARRP021InvoiceItems.BOSError = null;
            this.fld_cctrlARRP021InvoiceItems.BOSFieldGroup = null;
            this.fld_cctrlARRP021InvoiceItems.BOSFieldRelation = null;
            this.fld_cctrlARRP021InvoiceItems.BOSPrivilege = null;
            this.fld_cctrlARRP021InvoiceItems.BOSPropertyName = null;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.fld_cctrlARRP021InvoiceItems.Diagram = xyDiagram1;
            this.fld_cctrlARRP021InvoiceItems.Location = new System.Drawing.Point(27, 126);
            this.fld_cctrlARRP021InvoiceItems.Name = "fld_cctrlARRP021InvoiceItems";
            this.fld_cctrlARRP021InvoiceItems.Screen = null;
            sideBySideBarSeriesLabel1.LineVisible = true;
            series1.Label = sideBySideBarSeriesLabel1;
            series1.Name = "Series 1";
            sideBySideBarSeriesView1.ColorEach = true;
            sideBySideBarSeriesView1.Shadow.Visible = true;
            series1.View = sideBySideBarSeriesView1;
            this.fld_cctrlARRP021InvoiceItems.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            sideBySideBarSeriesLabel2.LineVisible = true;
            this.fld_cctrlARRP021InvoiceItems.SeriesTemplate.Label = sideBySideBarSeriesLabel2;
            this.fld_cctrlARRP021InvoiceItems.Size = new System.Drawing.Size(1135, 535);
            this.fld_cctrlARRP021InvoiceItems.TabIndex = 8;
            // 
            // fld_ctmExisX
            // 
            this.fld_ctmExisX.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.supplierToolStripMenuItem});
            this.fld_ctmExisX.Name = "fld_ctmExisX";
            this.fld_ctmExisX.Size = new System.Drawing.Size(138, 70);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.axisXToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.axisXToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.axisXToolStripMenuItem_Click);
            // 
            // fld_lblAxisX
            // 
            this.fld_lblAxisX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblAxisX.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fld_lblAxisX.Appearance.Options.UseFont = true;
            this.fld_lblAxisX.ContextMenuStrip = this.fld_ctmExisX;
            this.fld_lblAxisX.Location = new System.Drawing.Point(1030, 667);
            this.fld_lblAxisX.Name = "fld_lblAxisX";
            this.fld_lblAxisX.Size = new System.Drawing.Size(74, 13);
            this.fld_lblAxisX.TabIndex = 10;
            this.fld_lblAxisX.Text = "Nhà cung cấp";
            // 
            // RP021
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 736);
            this.Controls.Add(this.fld_cctrlARRP021InvoiceItems);
            this.Controls.Add(this.fld_lblAxisY);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.fld_lblAxisX);
            this.Controls.Add(this.BOSLabel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RP021";
            this.Tag = "SS";
            this.Text = "Đồ thị sản phẩm bán";
            this.Load += new System.EventHandler(this.RP021_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties)).EndInit();
            this.fld_ctmExisY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cctrlARRP021InvoiceItems)).EndInit();
            this.fld_ctmExisX.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSDateEdit fld_dteSearchToARInvoiceDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARInvoiceDate;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSLabel BOSLabel3;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSLabel fld_lblAxisY;
        private System.Windows.Forms.ContextMenuStrip fld_ctmExisY;
        private System.Windows.Forms.ToolStripMenuItem totalCoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qtyToolStripMenuItem;
        private BOSComponent.BOSChartControl fld_cctrlARRP021InvoiceItems;
        private System.Windows.Forms.ContextMenuStrip fld_ctmExisX;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private DevExpress.XtraEditors.LabelControl fld_lblAxisX;
        private System.Windows.Forms.ToolStripMenuItem extPriceToolStripMenuItem;

    }
}