namespace BOSReport
{
    partial class RP033
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
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowDetail = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
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
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.EvenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.OddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.inventoryDataSet1 = new BOSReport.InventoryDataSet();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.logoCompany = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xr_lblSubTitle = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xr_HeaderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable2
            // 
            this.xrTable2.BackColor = System.Drawing.Color.Transparent;
            this.xrTable2.BorderColor = System.Drawing.Color.Black;
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRowDetail});
            this.xrTable2.SizeF = new System.Drawing.SizeF(1005.958F, 25F);
            this.xrTable2.StylePriority.UseBackColor = false;
            this.xrTable2.StylePriority.UseBorderColor = false;
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UsePadding = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRowDetail
            // 
            this.xrTableRowDetail.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell12,
            this.xrTableCell3});
            this.xrTableRowDetail.Name = "xrTableRowDetail";
            this.xrTableRowDetail.Weight = 1;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.CanGrow = false;
            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Report_GetProductComponentParentInventoryStockList.ICProductNo")});
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "xrTableCell4";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell4.Weight = 0.92991695424665866;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.CanGrow = false;
            this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Report_GetProductComponentParentInventoryStockList.ICProductSupplierNumber")});
            this.xrTableCell12.Multiline = true;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTableCell12.StylePriority.UsePadding = false;
            this.xrTableCell12.Text = "xrTableCell12";
            this.xrTableCell12.Weight = 0.522588630747281;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Report_GetProductComponentParentInventoryStockList.ICProductDesc")});
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell3.Weight = 1.7606815504361988;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 23F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xr_lblBRBranchFax
            // 
            this.xr_lblBRBranchFax.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xr_lblBRBranchFax.LocationFloat = new DevExpress.Utils.PointFloat(199.0522F, 142.0416F);
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
            this.xr_lblBRBranchPhone.LocationFloat = new DevExpress.Utils.PointFloat(74.05224F, 142.0416F);
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
            this.xr_lblBRBranchAddressLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 123.125F);
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
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(165.7189F, 142.0416F);
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
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 142.0416F);
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
            this.xr_lblTitle.LocationFloat = new DevExpress.Utils.PointFloat(0F, 182.8335F);
            this.xr_lblTitle.Name = "xr_lblTitle";
            this.xr_lblTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xr_lblTitle.SizeF = new System.Drawing.SizeF(1005.011F, 36.9167F);
            this.xr_lblTitle.StylePriority.UseFont = false;
            this.xr_lblTitle.StylePriority.UseForeColor = false;
            this.xr_lblTitle.StylePriority.UseTextAlignment = false;
            this.xr_lblTitle.Text = "DANH SÁCH BỘ THIẾU";
            this.xr_lblTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
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
            this.PageHeader.HeightF = 25F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xr_HeaderTable
            // 
            this.xr_HeaderTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(214)))), ((int)(((byte)(211)))));
            this.xr_HeaderTable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(177)))), ((int)(((byte)(183)))));
            this.xr_HeaderTable.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xr_HeaderTable.BorderWidth = 1;
            this.xr_HeaderTable.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xr_HeaderTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xr_HeaderTable.Name = "xr_HeaderTable";
            this.xr_HeaderTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRowHeader});
            this.xr_HeaderTable.SizeF = new System.Drawing.SizeF(1005.958F, 25F);
            this.xr_HeaderTable.StylePriority.UseBackColor = false;
            this.xr_HeaderTable.StylePriority.UseBorderColor = false;
            this.xr_HeaderTable.StylePriority.UseBorders = false;
            this.xr_HeaderTable.StylePriority.UseBorderWidth = false;
            this.xr_HeaderTable.StylePriority.UseFont = false;
            this.xr_HeaderTable.StylePriority.UseTextAlignment = false;
            this.xr_HeaderTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRowHeader
            // 
            this.xrTableRowHeader.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell8});
            this.xrTableRowHeader.Name = "xrTableRowHeader";
            this.xrTableRowHeader.Weight = 1;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "Mã sản phẩm";
            this.xrTableCell5.Weight = 1.2748775066759919;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "Mã sản phẩm NCC";
            this.xrTableCell6.Weight = 0.71644717307462591;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "Mô tả";
            this.xrTableCell8.Weight = 2.4138201112435334;
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
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(907F, 0F);
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
            this.xrLabel6,
            this.xr_lblBRBranchAddressLine3,
            this.xr_lblBRBranchPhone,
            this.xr_lblBRBranchFax,
            this.xrLabel8});
            this.ReportHeader.HeightF = 243.1253F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // logoCompany
            // 
            this.logoCompany.Image = global::BOSReport.Properties.Resources.Logo_LV;
            this.logoCompany.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.logoCompany.Name = "logoCompany";
            this.logoCompany.SizeF = new System.Drawing.SizeF(145.8333F, 123.125F);
            this.logoCompany.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xr_lblSubTitle
            // 
            this.xr_lblSubTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_lblSubTitle.ForeColor = System.Drawing.Color.Blue;
            this.xr_lblSubTitle.LocationFloat = new DevExpress.Utils.PointFloat(0F, 219.7503F);
            this.xr_lblSubTitle.Name = "xr_lblSubTitle";
            this.xr_lblSubTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xr_lblSubTitle.SizeF = new System.Drawing.SizeF(1005.01F, 23.375F);
            this.xr_lblSubTitle.StylePriority.UseFont = false;
            this.xr_lblSubTitle.StylePriority.UseForeColor = false;
            this.xr_lblSubTitle.StylePriority.UseTextAlignment = false;
            this.xr_lblSubTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // RP033
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.PageFooter,
            this.ReportFooter,
            this.ReportHeader});
            this.DataMember = "Report_GetTransferProductList";
            this.DataSource = this.inventoryDataSet1;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(41, 52, 23, 24);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.ShowPrintMarginsWarning = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.EvenStyle,
            this.OddStyle});
            this.Version = "9.3";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xr_HeaderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xr_lblTitle;
        private DevExpress.XtraReports.UI.XRControlStyle EvenStyle;
        private DevExpress.XtraReports.UI.XRControlStyle OddStyle;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowDetail;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRLabel xr_lblBRBranchFax;
        private DevExpress.XtraReports.UI.XRLabel xr_lblBRBranchPhone;
        private DevExpress.XtraReports.UI.XRLabel xr_lblBRBranchAddressLine3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private InventoryDataSet inventoryDataSet1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRTable xr_HeaderTable;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.XRLabel xr_lblSubTitle;
        private DevExpress.XtraReports.UI.XRPictureBox logoCompany;
    }
}
