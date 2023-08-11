namespace BOSERP
{
    partial class guiProductUnitCostComparison
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
            DevExpress.XtraCharts.PointOptions pointOptions1 = new DevExpress.XtraCharts.PointOptions();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiProductUnitCostComparison));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeFK_APSupplierID2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dteSearchToAPInvoiceInDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromAPInvoiceInDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel3 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_cctrlAPInvoiceInItems = new BOSComponent.BOSChartControl(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cctrlAPInvoiceInItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeFK_APSupplierID2);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.fld_dteSearchToAPInvoiceInDate);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromAPInvoiceInDate);
            this.panelControl1.Controls.Add(this.BOSLabel2);
            this.panelControl1.Controls.Add(this.BOSLabel3);
            this.panelControl1.Controls.Add(this.BOSLabel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(922, 43);
            this.panelControl1.TabIndex = 7;
            // 
            // fld_lkeFK_APSupplierID2
            // 
            this.fld_lkeFK_APSupplierID2.BOSAllowAddNew = false;
            this.fld_lkeFK_APSupplierID2.BOSAllowDummy = true;
            this.fld_lkeFK_APSupplierID2.BOSComment = "";
            this.fld_lkeFK_APSupplierID2.BOSDataMember = "FK_APSupplierID";
            this.fld_lkeFK_APSupplierID2.BOSDataSource = "APInvoiceIns";
            this.fld_lkeFK_APSupplierID2.BOSDescription = null;
            this.fld_lkeFK_APSupplierID2.BOSError = null;
            this.fld_lkeFK_APSupplierID2.BOSFieldGroup = "";
            this.fld_lkeFK_APSupplierID2.BOSFieldParent = "";
            this.fld_lkeFK_APSupplierID2.BOSFieldRelation = "";
            this.fld_lkeFK_APSupplierID2.BOSPrivilege = "";
            this.fld_lkeFK_APSupplierID2.BOSPropertyName = "EditValue";
            this.fld_lkeFK_APSupplierID2.BOSSelectType = "";
            this.fld_lkeFK_APSupplierID2.BOSSelectTypeValue = "";
            this.fld_lkeFK_APSupplierID2.CurrentDisplayText = null;
            this.fld_lkeFK_APSupplierID2.Location = new System.Drawing.Point(100, 12);
            this.fld_lkeFK_APSupplierID2.Name = "fld_lkeFK_APSupplierID2";
            this.fld_lkeFK_APSupplierID2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_APSupplierID2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_APSupplierID2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_APSupplierID2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_APSupplierID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_APSupplierID2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("APSupplierName", "Name")});
            this.fld_lkeFK_APSupplierID2.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeFK_APSupplierID2.Properties.NullText = "";
            this.fld_lkeFK_APSupplierID2.Properties.PopupWidth = 40;
            this.fld_lkeFK_APSupplierID2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_APSupplierID2.Properties.ValueMember = "APSupplierID";
            this.fld_lkeFK_APSupplierID2.Screen = null;
            this.fld_lkeFK_APSupplierID2.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_APSupplierID2.TabIndex = 0;
            this.fld_lkeFK_APSupplierID2.Tag = "DC";
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
            this.fld_btnApply.Location = new System.Drawing.Point(744, 9);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 27);
            this.fld_btnApply.TabIndex = 3;
            this.fld_btnApply.Text = "Xem";
            this.fld_btnApply.Click += new System.EventHandler(this.fld_btnApply_Click);
            // 
            // fld_dteSearchToAPInvoiceInDate
            // 
            this.fld_dteSearchToAPInvoiceInDate.BOSComment = null;
            this.fld_dteSearchToAPInvoiceInDate.BOSDataMember = "";
            this.fld_dteSearchToAPInvoiceInDate.BOSDataSource = "";
            this.fld_dteSearchToAPInvoiceInDate.BOSDescription = null;
            this.fld_dteSearchToAPInvoiceInDate.BOSError = null;
            this.fld_dteSearchToAPInvoiceInDate.BOSFieldGroup = null;
            this.fld_dteSearchToAPInvoiceInDate.BOSFieldRelation = null;
            this.fld_dteSearchToAPInvoiceInDate.BOSPrivilege = null;
            this.fld_dteSearchToAPInvoiceInDate.BOSPropertyName = null;
            this.fld_dteSearchToAPInvoiceInDate.EditValue = null;
            this.fld_dteSearchToAPInvoiceInDate.Location = new System.Drawing.Point(537, 12);
            this.fld_dteSearchToAPInvoiceInDate.Name = "fld_dteSearchToAPInvoiceInDate";
            this.fld_dteSearchToAPInvoiceInDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToAPInvoiceInDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToAPInvoiceInDate.Screen = null;
            this.fld_dteSearchToAPInvoiceInDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToAPInvoiceInDate.TabIndex = 2;
            this.fld_dteSearchToAPInvoiceInDate.Tag = "DC";
            // 
            // fld_dteSearchFromAPInvoiceInDate
            // 
            this.fld_dteSearchFromAPInvoiceInDate.BOSComment = null;
            this.fld_dteSearchFromAPInvoiceInDate.BOSDataMember = "";
            this.fld_dteSearchFromAPInvoiceInDate.BOSDataSource = "";
            this.fld_dteSearchFromAPInvoiceInDate.BOSDescription = null;
            this.fld_dteSearchFromAPInvoiceInDate.BOSError = null;
            this.fld_dteSearchFromAPInvoiceInDate.BOSFieldGroup = null;
            this.fld_dteSearchFromAPInvoiceInDate.BOSFieldRelation = null;
            this.fld_dteSearchFromAPInvoiceInDate.BOSPrivilege = null;
            this.fld_dteSearchFromAPInvoiceInDate.BOSPropertyName = null;
            this.fld_dteSearchFromAPInvoiceInDate.EditValue = null;
            this.fld_dteSearchFromAPInvoiceInDate.Location = new System.Drawing.Point(328, 12);
            this.fld_dteSearchFromAPInvoiceInDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchFromAPInvoiceInDate.Name = "fld_dteSearchFromAPInvoiceInDate";
            this.fld_dteSearchFromAPInvoiceInDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromAPInvoiceInDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromAPInvoiceInDate.Screen = null;
            this.fld_dteSearchFromAPInvoiceInDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromAPInvoiceInDate.TabIndex = 1;
            this.fld_dteSearchFromAPInvoiceInDate.Tag = "DC";
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
            this.BOSLabel2.Location = new System.Drawing.Point(502, 15);
            this.BOSLabel2.Name = "BOSLabel2";
            this.BOSLabel2.Screen = null;
            this.BOSLabel2.Size = new System.Drawing.Size(20, 13);
            this.BOSLabel2.TabIndex = 8;
            this.BOSLabel2.Text = "Đến";
            // 
            // BOSLabel3
            // 
            this.BOSLabel3.BOSComment = null;
            this.BOSLabel3.BOSDataMember = null;
            this.BOSLabel3.BOSDataSource = null;
            this.BOSLabel3.BOSDescription = null;
            this.BOSLabel3.BOSError = null;
            this.BOSLabel3.BOSFieldGroup = null;
            this.BOSLabel3.BOSFieldRelation = null;
            this.BOSLabel3.BOSPrivilege = null;
            this.BOSLabel3.BOSPropertyName = null;
            this.BOSLabel3.Location = new System.Drawing.Point(9, 15);
            this.BOSLabel3.Name = "BOSLabel3";
            this.BOSLabel3.Screen = null;
            this.BOSLabel3.Size = new System.Drawing.Size(65, 13);
            this.BOSLabel3.TabIndex = 8;
            this.BOSLabel3.Text = "Nhà cung cấp";
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
            this.BOSLabel1.Location = new System.Drawing.Point(272, 15);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(40, 13);
            this.BOSLabel1.TabIndex = 8;
            this.BOSLabel1.Text = "Từ ngày";
            // 
            // fld_cctrlAPInvoiceInItems
            // 
            this.fld_cctrlAPInvoiceInItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_cctrlAPInvoiceInItems.BorderOptions.Visible = false;
            this.fld_cctrlAPInvoiceInItems.BOSComment = null;
            this.fld_cctrlAPInvoiceInItems.BOSDataMember = null;
            this.fld_cctrlAPInvoiceInItems.BOSDataSource = "APInvoiceInItems";
            this.fld_cctrlAPInvoiceInItems.BOSDescription = null;
            this.fld_cctrlAPInvoiceInItems.BOSError = null;
            this.fld_cctrlAPInvoiceInItems.BOSFieldGroup = null;
            this.fld_cctrlAPInvoiceInItems.BOSFieldRelation = null;
            this.fld_cctrlAPInvoiceInItems.BOSPrivilege = null;
            this.fld_cctrlAPInvoiceInItems.BOSPropertyName = null;
            xyDiagram1.AxisX.Label.Angle = -15;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.fld_cctrlAPInvoiceInItems.Diagram = xyDiagram1;
            this.fld_cctrlAPInvoiceInItems.Location = new System.Drawing.Point(0, 43);
            this.fld_cctrlAPInvoiceInItems.Name = "fld_cctrlAPInvoiceInItems";
            this.fld_cctrlAPInvoiceInItems.Screen = null;
            pointSeriesLabel1.LineVisible = true;
            series1.Label = pointSeriesLabel1;
            series1.Name = "Series 1";
            pointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number;
            series1.PointOptions = pointOptions1;
            lineSeriesView1.ColorEach = true;
            series1.View = lineSeriesView1;
            this.fld_cctrlAPInvoiceInItems.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            pointSeriesLabel2.LineVisible = true;
            this.fld_cctrlAPInvoiceInItems.SeriesTemplate.Label = pointSeriesLabel2;
            this.fld_cctrlAPInvoiceInItems.SeriesTemplate.View = lineSeriesView2;
            this.fld_cctrlAPInvoiceInItems.Size = new System.Drawing.Size(922, 545);
            this.fld_cctrlAPInvoiceInItems.TabIndex = 9;
            chartTitle1.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle1.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartTitle1.Text = "Ngày";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Near;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartTitle2.Text = "Giá mua";
            this.fld_cctrlAPInvoiceInItems.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            this.fld_cctrlAPInvoiceInItems.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.fld_cctrlAPInvoiceInItems_BoundDataChanged);
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
            this.fld_btnClose.Location = new System.Drawing.Point(835, 599);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 4;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // guiProductUnitCostComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 634);
            this.ControlBox = true;
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.fld_cctrlAPInvoiceInItems);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiProductUnitCostComparison";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "So sánh giá mua của sản phẩm theo thời gian ";
            this.Load += new System.EventHandler(this.guiDictinctProductUnitCost_Load);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_cctrlAPInvoiceInItems, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_APSupplierID2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPInvoiceInDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPInvoiceInDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cctrlAPInvoiceInItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSDateEdit fld_dteSearchToAPInvoiceInDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromAPInvoiceInDate;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel BOSLabel3;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSChartControl fld_cctrlAPInvoiceInItems;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSLookupEdit fld_lkeFK_APSupplierID2;
    }
}