namespace BOSReport
{
    partial class RP032
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrDetailTable = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowDetail = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xr_lblBRBranchFax = new DevExpress.XtraReports.UI.XRLabel();
            this.xr_lblBRBranchPhone = new DevExpress.XtraReports.UI.XRLabel();
            this.xr_lblBRBranchAddressLine3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xr_lblTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xr_HeaderTable = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowHeader = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.EvenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.OddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.inventoryDataSet1 = new BOSReport.InventoryDataSet();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.logoCompany = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xr_lblSubTitle = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrDetailTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xr_HeaderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrDetailTable});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrDetailTable
            // 
            this.xrDetailTable.BackColor = System.Drawing.Color.Transparent;
            this.xrDetailTable.BorderColor = System.Drawing.Color.Black;
            this.xrDetailTable.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrDetailTable.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.xrDetailTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrDetailTable.Name = "xrDetailTable";
            this.xrDetailTable.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrDetailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRowDetail});
            this.xrDetailTable.SizeF = new System.Drawing.SizeF(992.8744F, 25F);
            this.xrDetailTable.StylePriority.UseBackColor = false;
            this.xrDetailTable.StylePriority.UseBorderColor = false;
            this.xrDetailTable.StylePriority.UseBorders = false;
            this.xrDetailTable.StylePriority.UseFont = false;
            this.xrDetailTable.StylePriority.UsePadding = false;
            this.xrDetailTable.StylePriority.UseTextAlignment = false;
            this.xrDetailTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRowDetail
            // 
            this.xrTableRowDetail.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell12,
            this.xrTableCell3,
            this.xrTableCell15,
            this.xrTableCell16});
            this.xrTableRowDetail.Name = "xrTableRowDetail";
            this.xrTableRowDetail.Weight = 1;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Report_GetProductInventoryStockMinMax.ICProductNo")});
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "xrTableCell4";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell4.Weight = 1.1160720138286544;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Report_GetProductInventoryStockMinMax.ICProductSupplierNumber")});
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTableCell12.StylePriority.UsePadding = false;
            this.xrTableCell12.Text = "xrTableCell12";
            this.xrTableCell12.Weight = 0.47030118829106871;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Report_GetProductInventoryStockMinMax.ICProductDesc")});
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell3.Weight = 1.3902719634306691;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Report_GetProductInventoryStockMinMax.ICProductStockMin")});
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseTextAlignment = false;
            this.xrTableCell15.Text = "xrTableCell15";
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell15.Weight = 0.50295537655602285;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Report_GetProductInventoryStockMinMax.ICProductStockMax")});
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.xrTableCell16.StylePriority.UsePadding = false;
            this.xrTableCell16.StylePriority.UseTextAlignment = false;
            this.xrTableCell16.Text = "xrTableCell16";
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell16.Weight = 0.46037927219438535;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 24F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xr_lblBRBranchFax
            // 
            this.xr_lblBRBranchFax.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xr_lblBRBranchFax.LocationFloat = new DevExpress.Utils.PointFloat(202.0832F, 152.3333F);
            this.xr_lblBRBranchFax.Multiline = true;
            this.xr_lblBRBranchFax.Name = "xr_lblBRBranchFax";
            this.xr_lblBRBranchFax.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xr_lblBRBranchFax.SizeF = new System.Drawing.SizeF(104.7078F, 18.91664F);
            this.xr_lblBRBranchFax.StylePriority.UseFont = false;
            this.xr_lblBRBranchFax.StylePriority.UseTextAlignment = false;
            this.xr_lblBRBranchFax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xr_lblBRBranchPhone
            // 
            this.xr_lblBRBranchPhone.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xr_lblBRBranchPhone.LocationFloat = new DevExpress.Utils.PointFloat(77.0833F, 152.3333F);
            this.xr_lblBRBranchPhone.Multiline = true;
            this.xr_lblBRBranchPhone.Name = "xr_lblBRBranchPhone";
            this.xr_lblBRBranchPhone.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xr_lblBRBranchPhone.SizeF = new System.Drawing.SizeF(89.58331F, 18.91664F);
            this.xr_lblBRBranchPhone.StylePriority.UseFont = false;
            this.xr_lblBRBranchPhone.StylePriority.UseTextAlignment = false;
            this.xr_lblBRBranchPhone.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xr_lblBRBranchAddressLine3
            // 
            this.xr_lblBRBranchAddressLine3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xr_lblBRBranchAddressLine3.LocationFloat = new DevExpress.Utils.PointFloat(3.031079F, 133.4167F);
            this.xr_lblBRBranchAddressLine3.Multiline = true;
            this.xr_lblBRBranchAddressLine3.Name = "xr_lblBRBranchAddressLine3";
            this.xr_lblBRBranchAddressLine3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xr_lblBRBranchAddressLine3.SizeF = new System.Drawing.SizeF(396.7347F, 18.91664F);
            this.xr_lblBRBranchAddressLine3.StylePriority.UseFont = false;
            this.xr_lblBRBranchAddressLine3.StylePriority.UseTextAlignment = false;
            this.xr_lblBRBranchAddressLine3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(168.7499F, 152.3333F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(33.33333F, 18.91664F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Fax:";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(2.083318F, 152.3333F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(75F, 18.91664F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Điện thoại:";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xr_lblTitle
            // 
            this.xr_lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.xr_lblTitle.LocationFloat = new DevExpress.Utils.PointFloat(0.9477456F, 183.7502F);
            this.xr_lblTitle.Name = "xr_lblTitle";
            this.xr_lblTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xr_lblTitle.SizeF = new System.Drawing.SizeF(991.9266F, 36.9167F);
            this.xr_lblTitle.StylePriority.UseFont = false;
            this.xr_lblTitle.StylePriority.UseForeColor = false;
            this.xr_lblTitle.StylePriority.UseTextAlignment = false;
            this.xr_lblTitle.Text = "HÀNG TỒN KHO ĐẾN HẠN MỨC TỐI THIỂU, TỐI ĐA";
            this.xr_lblTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 24F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xr_HeaderTable});
            this.PageHeader.HeightF = 30.99999F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xr_HeaderTable
            // 
            this.xr_HeaderTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(214)))), ((int)(((byte)(211)))));
            this.xr_HeaderTable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(177)))), ((int)(((byte)(183)))));
            this.xr_HeaderTable.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xr_HeaderTable.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xr_HeaderTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xr_HeaderTable.Name = "xr_HeaderTable";
            this.xr_HeaderTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRowHeader});
            this.xr_HeaderTable.SizeF = new System.Drawing.SizeF(992.8745F, 30.99999F);
            this.xr_HeaderTable.StylePriority.UseBackColor = false;
            this.xr_HeaderTable.StylePriority.UseBorderColor = false;
            this.xr_HeaderTable.StylePriority.UseBorders = false;
            this.xr_HeaderTable.StylePriority.UseFont = false;
            this.xr_HeaderTable.StylePriority.UseTextAlignment = false;
            this.xr_HeaderTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRowHeader
            // 
            this.xrTableRowHeader.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell7,
            this.xrTableCell2,
            this.xrTableCell10,
            this.xrTableCell11});
            this.xrTableRowHeader.Name = "xrTableRowHeader";
            this.xrTableRowHeader.Weight = 1;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "Mã sản phẩm";
            this.xrTableCell1.Weight = 1.3241858359104866;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "Mã sản phẩm NCC";
            this.xrTableCell7.Weight = 0.5579980623369224;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "Mô tả";
            this.xrTableCell2.Weight = 1.6495159538482906;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Text = "Số lượng tối thiểu";
            this.xrTableCell10.Weight = 0.59674140410173859;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Text = "Số lượng tối đa";
            this.xrTableCell11.Weight = 0.54622676896045852;
            // 
            // EvenStyle
            // 
            this.EvenStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.EvenStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(207)))), ((int)(((byte)(189)))));
            this.EvenStyle.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.EvenStyle.BorderWidth = 1;
            this.EvenStyle.Name = "EvenStyle";
            this.EvenStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            // 
            // OddStyle
            // 
            this.OddStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.OddStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(207)))), ((int)(((byte)(189)))));
            this.OddStyle.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.OddStyle.BorderWidth = 1;
            this.OddStyle.Name = "OddStyle";
            this.OddStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2});
            this.PageFooter.HeightF = 23F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(892.8744F, 0F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 0F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // inventoryDataSet1
            // 
            this.inventoryDataSet1.DataSetName = "InventoryDataSet";
            this.inventoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.logoCompany,
            this.xr_lblSubTitle,
            this.xr_lblTitle,
            this.xrLabel8,
            this.xrLabel6,
            this.xr_lblBRBranchAddressLine3,
            this.xr_lblBRBranchPhone,
            this.xr_lblBRBranchFax});
            this.ReportHeader.HeightF = 250.0419F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // logoCompany
            // 
            this.logoCompany.Image = global::BOSReport.Properties.Resources.Logo_LV;
            this.logoCompany.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.logoCompany.Name = "logoCompany";
            this.logoCompany.SizeF = new System.Drawing.SizeF(148.9583F, 133.4167F);
            this.logoCompany.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xr_lblSubTitle
            // 
            this.xr_lblSubTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_lblSubTitle.ForeColor = System.Drawing.Color.Blue;
            this.xr_lblSubTitle.LocationFloat = new DevExpress.Utils.PointFloat(2.083286F, 220.6669F);
            this.xr_lblSubTitle.Name = "xr_lblSubTitle";
            this.xr_lblSubTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xr_lblSubTitle.SizeF = new System.Drawing.SizeF(990.7912F, 29.37502F);
            this.xr_lblSubTitle.StylePriority.UseFont = false;
            this.xr_lblSubTitle.StylePriority.UseForeColor = false;
            this.xr_lblSubTitle.StylePriority.UseTextAlignment = false;
            this.xr_lblSubTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // RP032
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.PageFooter,
            this.ReportFooter,
            this.ReportHeader});
            this.DataMember = "Report_GetProductInventoryStockMinMax";
            this.DataSource = this.inventoryDataSet1;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(52, 52, 24, 24);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.ShowPrintMarginsWarning = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.EvenStyle,
            this.OddStyle});
            this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.Version = "9.3";
            ((System.ComponentModel.ISupportInitialize)(this.xrDetailTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xr_HeaderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable xr_HeaderTable;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRLabel xr_lblTitle;
        private DevExpress.XtraReports.UI.XRControlStyle EvenStyle;
        private DevExpress.XtraReports.UI.XRControlStyle OddStyle;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRTable xrDetailTable;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowDetail;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell15;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell16;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRLabel xr_lblBRBranchFax;
        private DevExpress.XtraReports.UI.XRLabel xr_lblBRBranchPhone;
        private DevExpress.XtraReports.UI.XRLabel xr_lblBRBranchAddressLine3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private InventoryDataSet inventoryDataSet1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.XRLabel xr_lblSubTitle;
        private DevExpress.XtraReports.UI.XRPictureBox logoCompany;
    }
}
