namespace BOSERP.Modules.Report
{
    partial class RP005
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
            DevExpress.XtraCharts.PointOptions pointOptions1 = new DevExpress.XtraCharts.PointOptions();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP005));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fld_lkeBRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblBranch = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchToARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchFromARInvoiceDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnApply = new BOSComponent.BOSButton(this.components);
            this.BOSLabel2 = new BOSComponent.BOSLabel(this.components);
            this.BOSLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_ctmExisY = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.extPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qtyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fld_cctrlARRP005InvoiceItems = new BOSComponent.BOSChartControl(this.components);
            this.fld_btnBack = new BOSComponent.BOSButton(this.components);
            this.fld_lblTitle = new BOSComponent.BOSLabel(this.components);
            this.fld_lblBranchName = new BOSComponent.BOSLabel(this.components);
            this.fld_lblFromdateTodate = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToARInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromARInvoiceDate.Properties)).BeginInit();
            this.fld_ctmExisY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_cctrlARRP005InvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_lkeBRBranchID);
            this.panelControl1.Controls.Add(this.fld_lblBranch);
            this.panelControl1.Controls.Add(this.fld_dteSearchToARInvoiceDate);
            this.panelControl1.Controls.Add(this.fld_dteSearchFromARInvoiceDate);
            this.panelControl1.Controls.Add(this.fld_btnApply);
            this.panelControl1.Controls.Add(this.BOSLabel2);
            this.panelControl1.Controls.Add(this.BOSLabel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1028, 47);
            this.panelControl1.TabIndex = 1;
            // 
            // fld_lkeBRBranchID
            // 
            this.fld_lkeBRBranchID.BOSAllowAddNew = false;
            this.fld_lkeBRBranchID.BOSAllowDummy = true;
            this.fld_lkeBRBranchID.BOSComment = null;
            this.fld_lkeBRBranchID.BOSDataMember = "BRBranchID";
            this.fld_lkeBRBranchID.BOSDataSource = "BRBranchs";
            this.fld_lkeBRBranchID.BOSDescription = null;
            this.fld_lkeBRBranchID.BOSError = null;
            this.fld_lkeBRBranchID.BOSFieldGroup = null;
            this.fld_lkeBRBranchID.BOSFieldParent = null;
            this.fld_lkeBRBranchID.BOSFieldRelation = null;
            this.fld_lkeBRBranchID.BOSPrivilege = null;
            this.fld_lkeBRBranchID.BOSPropertyName = "Edit Value";
            this.fld_lkeBRBranchID.BOSSelectType = null;
            this.fld_lkeBRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeBRBranchID.CurrentDisplayText = null;
            this.fld_lkeBRBranchID.Location = new System.Drawing.Point(90, 9);
            this.fld_lkeBRBranchID.Name = "fld_lkeBRBranchID";
            this.fld_lkeBRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeBRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeBRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeBRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeBRBranchID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeBRBranchID, true);
            this.fld_lkeBRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeBRBranchID.TabIndex = 1;
            this.fld_lkeBRBranchID.Tag = "DC";
            // 
            // fld_lblBranch
            // 
            this.fld_lblBranch.BOSComment = null;
            this.fld_lblBranch.BOSDataMember = null;
            this.fld_lblBranch.BOSDataSource = null;
            this.fld_lblBranch.BOSDescription = null;
            this.fld_lblBranch.BOSError = null;
            this.fld_lblBranch.BOSFieldGroup = null;
            this.fld_lblBranch.BOSFieldRelation = null;
            this.fld_lblBranch.BOSPrivilege = null;
            this.fld_lblBranch.BOSPropertyName = null;
            this.fld_lblBranch.Location = new System.Drawing.Point(25, 12);
            this.fld_lblBranch.Name = "fld_lblBranch";
            this.fld_lblBranch.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblBranch, true);
            this.fld_lblBranch.Size = new System.Drawing.Size(48, 13);
            this.fld_lblBranch.TabIndex = 5;
            this.fld_lblBranch.Text = "Chi nhánh";
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
            this.fld_dteSearchToARInvoiceDate.Location = new System.Drawing.Point(555, 9);
            this.fld_dteSearchToARInvoiceDate.Name = "fld_dteSearchToARInvoiceDate";
            this.fld_dteSearchToARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToARInvoiceDate.Screen = null;
            this.fld_dteSearchToARInvoiceDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToARInvoiceDate.TabIndex = 3;
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
            this.fld_dteSearchFromARInvoiceDate.Location = new System.Drawing.Point(343, 9);
            this.fld_dteSearchFromARInvoiceDate.Name = "fld_dteSearchFromARInvoiceDate";
            this.fld_dteSearchFromARInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromARInvoiceDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromARInvoiceDate.Screen = null;
            this.fld_dteSearchFromARInvoiceDate.Size = new System.Drawing.Size(150, 20);
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
            this.fld_btnApply.Location = new System.Drawing.Point(740, 5);
            this.fld_btnApply.Name = "fld_btnApply";
            this.fld_btnApply.Screen = null;
            this.fld_btnApply.Size = new System.Drawing.Size(75, 27);
            this.fld_btnApply.TabIndex = 4;
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
            this.BOSLabel2.Location = new System.Drawing.Point(515, 12);
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
            this.BOSLabel1.Location = new System.Drawing.Point(285, 12);
            this.BOSLabel1.Name = "BOSLabel1";
            this.BOSLabel1.Screen = null;
            this.BOSLabel1.Size = new System.Drawing.Size(40, 13);
            this.BOSLabel1.TabIndex = 0;
            this.BOSLabel1.Text = "Từ ngày";
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
            this.fld_btnClose.Location = new System.Drawing.Point(917, 761);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(75, 27);
            this.fld_btnClose.TabIndex = 3;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_ctmExisY
            // 
            this.fld_ctmExisY.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extPriceToolStripMenuItem,
            this.qtyToolStripMenuItem});
            this.fld_ctmExisY.Name = "contextMenuStrip1";
            this.fld_ctmExisY.Size = new System.Drawing.Size(131, 48);
            // 
            // extPriceToolStripMenuItem
            // 
            this.extPriceToolStripMenuItem.Name = "extPriceToolStripMenuItem";
            this.extPriceToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.extPriceToolStripMenuItem.Text = "Doanh thu";
            this.extPriceToolStripMenuItem.Click += new System.EventHandler(this.axisYToolStripMenuItem_Click);
            // 
            // qtyToolStripMenuItem
            // 
            this.qtyToolStripMenuItem.Name = "qtyToolStripMenuItem";
            this.qtyToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.qtyToolStripMenuItem.Text = "Số lượng";
            this.qtyToolStripMenuItem.Click += new System.EventHandler(this.axisYToolStripMenuItem_Click);
            // 
            // fld_cctrlARRP005InvoiceItems
            // 
            this.fld_cctrlARRP005InvoiceItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_cctrlARRP005InvoiceItems.BorderOptions.Visible = false;
            this.fld_cctrlARRP005InvoiceItems.BOSComment = null;
            this.fld_cctrlARRP005InvoiceItems.BOSDataMember = null;
            this.fld_cctrlARRP005InvoiceItems.BOSDataSource = null;
            this.fld_cctrlARRP005InvoiceItems.BOSDescription = null;
            this.fld_cctrlARRP005InvoiceItems.BOSError = null;
            this.fld_cctrlARRP005InvoiceItems.BOSFieldGroup = null;
            this.fld_cctrlARRP005InvoiceItems.BOSFieldRelation = null;
            this.fld_cctrlARRP005InvoiceItems.BOSPrivilege = null;
            this.fld_cctrlARRP005InvoiceItems.BOSPropertyName = null;
            this.fld_cctrlARRP005InvoiceItems.ContextMenuStrip = this.fld_ctmExisY;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.fld_cctrlARRP005InvoiceItems.Diagram = xyDiagram1;
            this.fld_cctrlARRP005InvoiceItems.Location = new System.Drawing.Point(12, 104);
            this.fld_cctrlARRP005InvoiceItems.Name = "fld_cctrlARRP005InvoiceItems";
            this.fld_cctrlARRP005InvoiceItems.Screen = null;
            sideBySideBarSeriesLabel1.LineVisible = true;
            series1.Label = sideBySideBarSeriesLabel1;
            series1.Name = "Series 1";
            pointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number;
            pointOptions1.ValueNumericOptions.Precision = 0;
            series1.PointOptions = pointOptions1;
            sideBySideBarSeriesView1.ColorEach = true;
            sideBySideBarSeriesView1.Shadow.Visible = true;
            series1.View = sideBySideBarSeriesView1;
            this.fld_cctrlARRP005InvoiceItems.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            sideBySideBarSeriesLabel2.LineVisible = true;
            this.fld_cctrlARRP005InvoiceItems.SeriesTemplate.Label = sideBySideBarSeriesLabel2;
            this.fld_cctrlARRP005InvoiceItems.Size = new System.Drawing.Size(989, 651);
            this.fld_cctrlARRP005InvoiceItems.TabIndex = 8;
            chartTitle1.Alignment = System.Drawing.StringAlignment.Near;
            chartTitle1.Font = new System.Drawing.Font("Tahoma", 12F);
            chartTitle1.Indent = 1;
            chartTitle1.Text = "Doanh thu";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 12F);
            chartTitle2.Indent = 2;
            chartTitle2.Text = "Ngành hàng";
            this.fld_cctrlARRP005InvoiceItems.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            this.fld_cctrlARRP005InvoiceItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fld_cctrlARRP005InvoiceItems_MouseClick);
            // 
            // fld_btnBack
            // 
            this.fld_btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnBack.BOSComment = null;
            this.fld_btnBack.BOSDataMember = null;
            this.fld_btnBack.BOSDataSource = null;
            this.fld_btnBack.BOSDescription = null;
            this.fld_btnBack.BOSError = null;
            this.fld_btnBack.BOSFieldGroup = null;
            this.fld_btnBack.BOSFieldRelation = null;
            this.fld_btnBack.BOSPrivilege = null;
            this.fld_btnBack.BOSPropertyName = null;
            this.fld_btnBack.Location = new System.Drawing.Point(12, 757);
            this.fld_btnBack.Name = "fld_btnBack";
            this.fld_btnBack.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnBack, true);
            this.fld_btnBack.Size = new System.Drawing.Size(75, 27);
            this.fld_btnBack.TabIndex = 2;
            this.fld_btnBack.Text = "Trở lại";
            this.fld_btnBack.Click += new System.EventHandler(this.fld_btnBack_Click);
            // 
            // fld_lblTitle
            // 
            this.fld_lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fld_lblTitle.Appearance.Options.UseFont = true;
            this.fld_lblTitle.BOSComment = null;
            this.fld_lblTitle.BOSDataMember = null;
            this.fld_lblTitle.BOSDataSource = null;
            this.fld_lblTitle.BOSDescription = null;
            this.fld_lblTitle.BOSError = null;
            this.fld_lblTitle.BOSFieldGroup = null;
            this.fld_lblTitle.BOSFieldRelation = null;
            this.fld_lblTitle.BOSPrivilege = null;
            this.fld_lblTitle.BOSPropertyName = null;
            this.fld_lblTitle.Location = new System.Drawing.Point(271, 57);
            this.fld_lblTitle.Name = "fld_lblTitle";
            this.fld_lblTitle.Screen = null;
            this.fld_lblTitle.Size = new System.Drawing.Size(307, 19);
            this.fld_lblTitle.TabIndex = 12;
            this.fld_lblTitle.Text = "ĐỒ THỊ DOANH THU THEO SẢN PHẨM";
            // 
            // fld_lblBranchName
            // 
            this.fld_lblBranchName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lblBranchName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
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
            this.fld_lblBranchName.Location = new System.Drawing.Point(584, 57);
            this.fld_lblBranchName.Name = "fld_lblBranchName";
            this.fld_lblBranchName.Screen = null;
            this.fld_lblBranchName.Size = new System.Drawing.Size(82, 19);
            this.fld_lblBranchName.TabIndex = 13;
            this.fld_lblBranchName.Text = "PHO XINH";
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
            this.fld_lblFromdateTodate.Location = new System.Drawing.Point(295, 82);
            this.fld_lblFromdateTodate.Name = "fld_lblFromdateTodate";
            this.fld_lblFromdateTodate.Screen = null;
            this.fld_lblFromdateTodate.Size = new System.Drawing.Size(65, 16);
            this.fld_lblFromdateTodate.TabIndex = 13;
            this.fld_lblFromdateTodate.Text = "THOI GIAN";
            // 
            // RP005
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 796);
            this.ControlBox = true;
            this.Controls.Add(this.fld_lblFromdateTodate);
            this.Controls.Add(this.fld_lblBranchName);
            this.Controls.Add(this.fld_lblTitle);
            this.Controls.Add(this.fld_btnBack);
            this.Controls.Add(this.fld_cctrlARRP005InvoiceItems);
            this.Controls.Add(this.fld_btnClose);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RP005";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "SS";
            this.Text = "Đồ thị doanh thu theo sản phẩm";
            this.Load += new System.EventHandler(this.RP005_Load);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.fld_btnClose, 0);
            this.Controls.SetChildIndex(this.fld_cctrlARRP005InvoiceItems, 0);
            this.Controls.SetChildIndex(this.fld_btnBack, 0);
            this.Controls.SetChildIndex(this.fld_lblTitle, 0);
            this.Controls.SetChildIndex(this.fld_lblBranchName, 0);
            this.Controls.SetChildIndex(this.fld_lblFromdateTodate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeBRBranchID.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.fld_cctrlARRP005InvoiceItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSDateEdit fld_dteSearchToARInvoiceDate;
        private BOSComponent.BOSDateEdit fld_dteSearchFromARInvoiceDate;
        private BOSComponent.BOSLabel BOSLabel2;
        private BOSComponent.BOSLabel BOSLabel1;
        private BOSComponent.BOSButton fld_btnApply;
        private BOSComponent.BOSButton fld_btnClose;
        private System.Windows.Forms.ContextMenuStrip fld_ctmExisY;
        private System.Windows.Forms.ToolStripMenuItem qtyToolStripMenuItem;
        private BOSComponent.BOSChartControl fld_cctrlARRP005InvoiceItems;
        private System.Windows.Forms.ToolStripMenuItem extPriceToolStripMenuItem;
        private BOSComponent.BOSButton fld_btnBack;
        private BOSComponent.BOSLookupEdit fld_lkeBRBranchID;
        private BOSComponent.BOSLabel fld_lblBranch;
        private BOSComponent.BOSLabel fld_lblTitle;
        private BOSComponent.BOSLabel fld_lblBranchName;
        private BOSComponent.BOSLabel fld_lblFromdateTodate;

    }
}