namespace BOSERP.Modules.Report
{
    partial class RP006
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP006));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.fld_dteSearchToARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblBranchName = new BOSComponent.BOSLabel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.BOSLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_ctxMenuStripFilter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fld_ctxItemDayOfWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.fld_ctxItemDayOfMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.fld_ctxItemMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.fld_ctxItemYear = new System.Windows.Forms.ToolStripMenuItem();
            this.fld_cctrlARRP006Invoices = new BOSERP.OverTimeChart(this.components);
            this.fld_lblFromdateTodate = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties)).BeginInit();
            this.fld_ctxMenuStripFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cctrlARRP006Invoices)).BeginInit();
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
            this.panelControl1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.panelControl1.Controls.Add(this.bosLabel5);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.fld_dteSearchToARInvoiceDate);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromARInvoiceDate);
            this.panelControl1.Controls.Add(this.BOSLabel2);
            this.panelControl1.Controls.Add(this.BOSLabel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1028, 48);
            this.panelControl1.TabIndex = 6;
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = null;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ARInvoices";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = null;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = null;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = null;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = null;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = null;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(89, 15);
            this.fld_lkeFK_BRBranchID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_BRBranchID, true);
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 1;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(22, 18);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(48, 13);
            this.bosLabel5.TabIndex = 33;
            this.bosLabel5.Text = "Chi nhánh";
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
            this.fld_btnApply.Location = new System.Drawing.Point(748, 10);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 27);
            this.fld_btnApply.TabIndex = 4;
            this.fld_btnApply.Text = "Xem";
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
            this.fld_dteSearchToARInvoiceDate.Location = new System.Drawing.Point(550, 15);
            this.fld_dteSearchToARInvoiceDate.Name = "fld_dteSearchToARInvoiceDate";
            this.fld_dteSearchToARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARInvoiceDate.Screen = null;
            this.fld_dteSearchToARInvoiceDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARInvoiceDate.TabIndex = 3;
            this.fld_dteSearchToARInvoiceDate.Tag = "SC";
            this.fld_dteSearchToARInvoiceDate.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.fld_dteSearchToARInvoiceDate_InvalidValue);
            this.fld_dteSearchToARInvoiceDate.Validating += new System.ComponentModel.CancelEventHandler(this.fld_dteSearchToARInvoiceDate_Validating);
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
            this.fld_dteSearchFromARInvoiceDate.Location = new System.Drawing.Point(328, 15);
            this.fld_dteSearchFromARInvoiceDate.MenuManager = this.screenToolbar;
            this.fld_dteSearchFromARInvoiceDate.Name = "fld_dteSearchFromARInvoiceDate";
            this.fld_dteSearchFromARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARInvoiceDate.Screen = null;
            this.fld_dteSearchFromARInvoiceDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromARInvoiceDate.TabIndex = 2;
            this.fld_dteSearchFromARInvoiceDate.Tag = "SC";
            this.fld_dteSearchFromARInvoiceDate.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.fld_dteSearchFromARInvoiceDate_InvalidValue);
            this.fld_dteSearchFromARInvoiceDate.Validating += new System.ComponentModel.CancelEventHandler(this.fld_dteSearchFromARInvoiceDate_Validating);
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
            this.BOSLabel2.Location = new System.Drawing.Point(509, 18);
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
            this.BOSLabel1.Location = new System.Drawing.Point(272, 18);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(40, 13);
            this.BOSLabel1.TabIndex = 7;
            this.BOSLabel1.Text = "Từ ngày";
            // 
            // fld_lblBranchName
            // 
            this.fld_lblBranchName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblBranchName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_lblBranchName.Appearance.Options.UseFont = true;
            this.fld_lblBranchName.Appearance.Options.UseTextOptions = true;
            this.fld_lblBranchName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fld_lblBranchName.BOSComment = null;
            this.fld_lblBranchName.BOSDataMember = null;
            this.fld_lblBranchName.BOSDataSource = null;
            this.fld_lblBranchName.BOSDescription = null;
            this.fld_lblBranchName.BOSError = null;
            this.fld_lblBranchName.BOSFieldGroup = null;
            this.fld_lblBranchName.BOSFieldRelation = null;
            this.fld_lblBranchName.BOSPrivilege = null;
            this.fld_lblBranchName.BOSPropertyName = null;
            this.fld_lblBranchName.Location = new System.Drawing.Point(618, 54);
            this.fld_lblBranchName.Name = "fld_lblBranchName";
            this.fld_lblBranchName.Screen = null;
            this.fld_lblBranchName.Size = new System.Drawing.Size(82, 19);
            this.fld_lblBranchName.TabIndex = 7;
            this.fld_lblBranchName.Text = "PHO XINH";
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
            this.fld_btnClose.Location = new System.Drawing.Point(939, 675);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 8;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // BOSLabel4
            // 
            this.BOSLabel4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BOSLabel4.Location = new System.Drawing.Point(314, 54);
            this.BOSLabel4.Name = "BOSLabel4";
            this.BOSLabel4.Screen = null;
            this.BOSLabel4.Size = new System.Drawing.Size(298, 19);
            this.BOSLabel4.TabIndex = 7;
            this.BOSLabel4.Text = "ĐỒ THỊ BÁN HÀNG THEO THỜI GIAN";
            // 
            // fld_ctxMenuStripFilter
            // 
            this.fld_ctxMenuStripFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fld_ctxItemDayOfWeek,
            this.fld_ctxItemDayOfMonth,
            this.fld_ctxItemMonth,
            this.fld_ctxItemYear});
            this.fld_ctxMenuStripFilter.Name = "fld_ctxMenuStripFilter";
            this.fld_ctxMenuStripFilter.Size = new System.Drawing.Size(169, 92);
            // 
            // fld_ctxItemDayOfWeek
            // 
            this.fld_ctxItemDayOfWeek.Name = "fld_ctxItemDayOfWeek";
            this.fld_ctxItemDayOfWeek.Size = new System.Drawing.Size(168, 22);
            this.fld_ctxItemDayOfWeek.Text = "Ngày trong tuần";
            this.fld_ctxItemDayOfWeek.Click += new System.EventHandler(this.fld_ctxItemDayOfWeek_Click);
            // 
            // fld_ctxItemDayOfMonth
            // 
            this.fld_ctxItemDayOfMonth.Name = "fld_ctxItemDayOfMonth";
            this.fld_ctxItemDayOfMonth.Size = new System.Drawing.Size(168, 22);
            this.fld_ctxItemDayOfMonth.Text = "Ngày trong tháng";
            this.fld_ctxItemDayOfMonth.Click += new System.EventHandler(this.fld_ctxItemDayOfMonth_Click);
            // 
            // fld_ctxItemMonth
            // 
            this.fld_ctxItemMonth.Name = "fld_ctxItemMonth";
            this.fld_ctxItemMonth.Size = new System.Drawing.Size(168, 22);
            this.fld_ctxItemMonth.Text = "Tháng";
            this.fld_ctxItemMonth.Click += new System.EventHandler(this.fld_ctxItemMonth_Click);
            // 
            // fld_ctxItemYear
            // 
            this.fld_ctxItemYear.Name = "fld_ctxItemYear";
            this.fld_ctxItemYear.Size = new System.Drawing.Size(168, 22);
            this.fld_ctxItemYear.Text = "Năm";
            this.fld_ctxItemYear.Click += new System.EventHandler(this.fld_ctxItemYear_Click);
            // 
            // fld_cctrlARRP006Invoices
            // 
            this.fld_cctrlARRP006Invoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_cctrlARRP006Invoices.BorderOptions.Visible = false;
            this.fld_cctrlARRP006Invoices.BOSComment = null;
            this.fld_cctrlARRP006Invoices.BOSDataMember = null;
            this.fld_cctrlARRP006Invoices.BOSDataSource = "ARInvoices";
            this.fld_cctrlARRP006Invoices.BOSDescription = null;
            this.fld_cctrlARRP006Invoices.BOSError = null;
            this.fld_cctrlARRP006Invoices.BOSFieldGroup = null;
            this.fld_cctrlARRP006Invoices.BOSFieldRelation = null;
            this.fld_cctrlARRP006Invoices.BOSPrivilege = null;
            this.fld_cctrlARRP006Invoices.BOSPropertyName = null;
            this.fld_cctrlARRP006Invoices.ContextMenuStrip = this.fld_ctxMenuStripFilter;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.fld_cctrlARRP006Invoices.Diagram = xyDiagram1;
            this.fld_cctrlARRP006Invoices.FilterType = BOSERP.OverTimeChart.FilterTypeEnum.DayOfWeek;
            this.fld_cctrlARRP006Invoices.Location = new System.Drawing.Point(12, 101);
            this.fld_cctrlARRP006Invoices.Name = "fld_cctrlARRP006Invoices";
            this.fld_cctrlARRP006Invoices.Points = null;
            this.fld_cctrlARRP006Invoices.Screen = null;
            pointSeriesLabel1.LineVisible = true;
            series1.Label = pointSeriesLabel1;
            series1.Name = "Series 1";
            pointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number;
            pointOptions1.ValueNumericOptions.Precision = 0;
            series1.PointOptions = pointOptions1;
            lineSeriesView1.ColorEach = true;
            lineSeriesView1.Shadow.Visible = true;
            series1.View = lineSeriesView1;
            this.fld_cctrlARRP006Invoices.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            pointSeriesLabel2.LineVisible = true;
            this.fld_cctrlARRP006Invoices.SeriesTemplate.Label = pointSeriesLabel2;
            this.fld_cctrlARRP006Invoices.SeriesTemplate.View = lineSeriesView2;
            this.ScreenHelper.SetShowHelp(this.fld_cctrlARRP006Invoices, true);
            this.fld_cctrlARRP006Invoices.Size = new System.Drawing.Size(1002, 555);
            this.fld_cctrlARRP006Invoices.TabIndex = 18;
            chartTitle1.Alignment = System.Drawing.StringAlignment.Near;
            chartTitle1.Font = new System.Drawing.Font("Tahoma", 10F);
            chartTitle1.Text = "Doanh thu";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 10F);
            chartTitle2.Text = "Ngày trong tuần";
            this.fld_cctrlARRP006Invoices.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            // 
            // fld_lblFromdateTodate
            // 
            this.fld_lblFromdateTodate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblFromdateTodate.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.fld_lblFromdateTodate.Appearance.Options.UseFont = true;
            this.fld_lblFromdateTodate.Appearance.Options.UseTextOptions = true;
            this.fld_lblFromdateTodate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fld_lblFromdateTodate.BOSComment = null;
            this.fld_lblFromdateTodate.BOSDataMember = null;
            this.fld_lblFromdateTodate.BOSDataSource = null;
            this.fld_lblFromdateTodate.BOSDescription = null;
            this.fld_lblFromdateTodate.BOSError = null;
            this.fld_lblFromdateTodate.BOSFieldGroup = null;
            this.fld_lblFromdateTodate.BOSFieldRelation = null;
            this.fld_lblFromdateTodate.BOSPrivilege = null;
            this.fld_lblFromdateTodate.BOSPropertyName = null;
            this.fld_lblFromdateTodate.Location = new System.Drawing.Point(342, 79);
            this.fld_lblFromdateTodate.Name = "fld_lblFromdateTodate";
            this.fld_lblFromdateTodate.Screen = null;
            this.fld_lblFromdateTodate.Size = new System.Drawing.Size(65, 16);
            this.fld_lblFromdateTodate.TabIndex = 19;
            this.fld_lblFromdateTodate.Text = "THOI GIAN";
            // 
            // RP006
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 710);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lblFromdateTodate);
            this.Controls.Add(this.fld_cctrlARRP006Invoices);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.BOSLabel4);
            this.Controls.Add(this.fld_lblBranchName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RP006";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Đồ thị bán hàng theo thời gian";
            this.Load += new System.EventHandler(this.RP006_Load);
            this.Controls.SetChildIndex(this.fld_lblBranchName, 0);
            this.Controls.SetChildIndex(this.BOSLabel4, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_cctrlARRP006Invoices, 0);
            this.Controls.SetChildIndex(this.fld_lblFromdateTodate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties)).EndInit();
            this.fld_ctxMenuStripFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cctrlARRP006Invoices)).EndInit();
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
        private BOSComponent.BOSLabel fld_lblBranchName;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSLabel BOSLabel4;
        private System.Windows.Forms.ContextMenuStrip fld_ctxMenuStripFilter;
        private System.Windows.Forms.ToolStripMenuItem fld_ctxItemDayOfWeek;
        private System.Windows.Forms.ToolStripMenuItem fld_ctxItemDayOfMonth;
        private System.Windows.Forms.ToolStripMenuItem fld_ctxItemMonth;
        private System.Windows.Forms.ToolStripMenuItem fld_ctxItemYear;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel5;
        private OverTimeChart fld_cctrlARRP006Invoices;
        private BOSComponent.BOSLabel fld_lblFromdateTodate;
    }
}