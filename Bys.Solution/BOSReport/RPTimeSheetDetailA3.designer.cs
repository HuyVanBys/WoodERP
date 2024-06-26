namespace BOSReport
{
    partial class RPTimeSheetDetailA3
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
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrDetailTable = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowDetail = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellDetailSTT = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellDetailNo = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellDetailEmployeeName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellDetailDepartmentRoomName = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.EvenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.OddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xr_HeaderTable = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRowHeader = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellSTT = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellNo = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellEmployeeName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellDepartmentRoomName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRowHeaderNB = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellNBSTT = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellNBNo = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellNBEmployeeName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellNBDepartmentRoomName = new DevExpress.XtraReports.UI.XRTableCell();
            this.workingDataSet1 = new BOSReport.WorkingDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.xrDetailTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xr_HeaderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingDataSet1)).BeginInit();
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
            this.xrDetailTable.BorderWidth = 1;
            this.xrDetailTable.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrDetailTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrDetailTable.Name = "xrDetailTable";
            this.xrDetailTable.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrDetailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRowDetail});
            this.xrDetailTable.SizeF = new System.Drawing.SizeF(1613F, 25F);
            this.xrDetailTable.StylePriority.UseBackColor = false;
            this.xrDetailTable.StylePriority.UseBorderColor = false;
            this.xrDetailTable.StylePriority.UseBorders = false;
            this.xrDetailTable.StylePriority.UseBorderWidth = false;
            this.xrDetailTable.StylePriority.UseFont = false;
            this.xrDetailTable.StylePriority.UsePadding = false;
            this.xrDetailTable.StylePriority.UseTextAlignment = false;
            this.xrDetailTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRowDetail
            // 
            this.xrTableRowDetail.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellDetailSTT,
            this.xrTableCellDetailNo,
            this.xrTableCellDetailEmployeeName,
            this.xrTableCellDetailDepartmentRoomName});
            this.xrTableRowDetail.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableRowDetail.Name = "xrTableRowDetail";
            this.xrTableRowDetail.StylePriority.UseFont = false;
            this.xrTableRowDetail.Weight = 1;
            // 
            // xrTableCellDetailSTT
            // 
            this.xrTableCellDetailSTT.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Report_GetTimeSheetEntryListByTimeSheetID.HREmployeeID")});
            this.xrTableCellDetailSTT.Name = "xrTableCellDetailSTT";
            this.xrTableCellDetailSTT.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableCellDetailSTT.StylePriority.UsePadding = false;
            this.xrTableCellDetailSTT.StylePriority.UseTextAlignment = false;
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCellDetailSTT.Summary = xrSummary1;
            this.xrTableCellDetailSTT.Text = "xrTableCellDetailSTT";
            this.xrTableCellDetailSTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCellDetailSTT.Weight = 1.0214822369804892;
            // 
            // xrTableCellDetailNo
            // 
            this.xrTableCellDetailNo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Report_GetTimeSheetEntryListByTimeSheetID.HREmployeeNo")});
            this.xrTableCellDetailNo.Name = "xrTableCellDetailNo";
            this.xrTableCellDetailNo.Text = "xrTableCellDetailNo";
            this.xrTableCellDetailNo.Weight = 1.4590260103551487;
            // 
            // xrTableCellDetailEmployeeName
            // 
            this.xrTableCellDetailEmployeeName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Report_GetTimeSheetEntryListByTimeSheetID.HREmployeeName")});
            this.xrTableCellDetailEmployeeName.Multiline = true;
            this.xrTableCellDetailEmployeeName.Name = "xrTableCellDetailEmployeeName";
            this.xrTableCellDetailEmployeeName.Text = "xrTableCellDetailEmployeeName";
            this.xrTableCellDetailEmployeeName.Weight = 3.9883483397386614;
            // 
            // xrTableCellDetailDepartmentRoomName
            // 
            this.xrTableCellDetailDepartmentRoomName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Report_GetTimeSheetEntryListByTimeSheetID.HRDepartmentRoomName")});
            this.xrTableCellDetailDepartmentRoomName.Name = "xrTableCellDetailDepartmentRoomName";
            this.xrTableCellDetailDepartmentRoomName.StylePriority.UseTextAlignment = false;
            this.xrTableCellDetailDepartmentRoomName.Text = "xrTableCellDetailDepartmentRoomName";
            this.xrTableCellDetailDepartmentRoomName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCellDetailDepartmentRoomName.Weight = 3.5147821007570208;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 32F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 25F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(900.9999F, 0F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
            this.PageFooter.HeightF = 25F;
            this.PageFooter.Name = "PageFooter";
            // 
            // EvenStyle
            // 
            this.EvenStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.EvenStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(207)))), ((int)(((byte)(189)))));
            this.EvenStyle.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.EvenStyle.BorderWidth = 1;
            this.EvenStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            // PageHeader
            // 
            this.PageHeader.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xr_HeaderTable});
            this.PageHeader.HeightF = 125.2917F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseBorders = false;
            // 
            // xr_HeaderTable
            // 
            this.xr_HeaderTable.BackColor = System.Drawing.Color.White;
            this.xr_HeaderTable.BorderColor = System.Drawing.Color.Black;
            this.xr_HeaderTable.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xr_HeaderTable.BorderWidth = 1;
            this.xr_HeaderTable.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_HeaderTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1.589457E-05F);
            this.xr_HeaderTable.Name = "xr_HeaderTable";
            this.xr_HeaderTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRowHeader,
            this.xrTableRowHeaderNB});
            this.xr_HeaderTable.SizeF = new System.Drawing.SizeF(1613F, 125.2917F);
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
            this.xrTableCellSTT,
            this.xrTableCellNo,
            this.xrTableCellEmployeeName,
            this.xrTableCellDepartmentRoomName});
            this.xrTableRowHeader.Name = "xrTableRowHeader";
            this.xrTableRowHeader.Weight = 1.7149763240745117;
            // 
            // xrTableCellSTT
            // 
            this.xrTableCellSTT.Name = "xrTableCellSTT";
            this.xrTableCellSTT.Text = "STT";
            this.xrTableCellSTT.Weight = 0.7825238946211921;
            // 
            // xrTableCellNo
            // 
            this.xrTableCellNo.ForeColor = System.Drawing.Color.Black;
            this.xrTableCellNo.Name = "xrTableCellNo";
            this.xrTableCellNo.StylePriority.UseForeColor = false;
            this.xrTableCellNo.Text = "Mã NV";
            this.xrTableCellNo.Weight = 1.1177122167243667;
            // 
            // xrTableCellEmployeeName
            // 
            this.xrTableCellEmployeeName.Name = "xrTableCellEmployeeName";
            this.xrTableCellEmployeeName.Text = "Tên nhân viên";
            this.xrTableCellEmployeeName.Weight = 3.05534334151003;
            // 
            // xrTableCellDepartmentRoomName
            // 
            this.xrTableCellDepartmentRoomName.Multiline = true;
            this.xrTableCellDepartmentRoomName.Name = "xrTableCellDepartmentRoomName";
            this.xrTableCellDepartmentRoomName.Text = "Phòng ban";
            this.xrTableCellDepartmentRoomName.Weight = 2.6925583663719093;
            // 
            // xrTableRowHeaderNB
            // 
            this.xrTableRowHeaderNB.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellNBSTT,
            this.xrTableCellNBNo,
            this.xrTableCellNBEmployeeName,
            this.xrTableCellNBDepartmentRoomName});
            this.xrTableRowHeaderNB.Name = "xrTableRowHeaderNB";
            this.xrTableRowHeaderNB.Weight = 0.35441917243754861;
            // 
            // xrTableCellNBSTT
            // 
            this.xrTableCellNBSTT.Name = "xrTableCellNBSTT";
            this.xrTableCellNBSTT.Text = "1";
            this.xrTableCellNBSTT.Weight = 0.78252389462119232;
            // 
            // xrTableCellNBNo
            // 
            this.xrTableCellNBNo.BackColor = System.Drawing.SystemColors.Window;
            this.xrTableCellNBNo.Name = "xrTableCellNBNo";
            this.xrTableCellNBNo.StylePriority.UseBackColor = false;
            this.xrTableCellNBNo.Text = "2";
            this.xrTableCellNBNo.Weight = 1.1177122167243667;
            // 
            // xrTableCellNBEmployeeName
            // 
            this.xrTableCellNBEmployeeName.Name = "xrTableCellNBEmployeeName";
            this.xrTableCellNBEmployeeName.Text = "3";
            this.xrTableCellNBEmployeeName.Weight = 3.055343260115742;
            // 
            // xrTableCellNBDepartmentRoomName
            // 
            this.xrTableCellNBDepartmentRoomName.Name = "xrTableCellNBDepartmentRoomName";
            this.xrTableCellNBDepartmentRoomName.Text = "4";
            this.xrTableCellNBDepartmentRoomName.Weight = 2.6925584477661966;
            // 
            // workingDataSet1
            // 
            this.workingDataSet1.DataSetName = "WorkingDataSet";
            this.workingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RPTimeSheetDetailA3
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.BottomMargin,
            this.Detail,
            this.TopMargin,
            this.PageFooter,
            this.PageHeader});
            this.BorderWidth = 0;
            this.DataMember = "Report_GetTimeSheetEntryListByTimeSheetID";
            this.DataSource = this.workingDataSet1;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(23, 18, 32, 25);
            this.PageHeight = 1169;
            this.PageWidth = 1654;
            this.PaperKind = System.Drawing.Printing.PaperKind.A3;
            this.ShowPrintMarginsWarning = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.EvenStyle,
            this.OddStyle});
            this.Version = "9.3";
            ((System.ComponentModel.ISupportInitialize)(this.xrDetailTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xr_HeaderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRTable xrDetailTable;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowDetail;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellDetailSTT;
        private DevExpress.XtraReports.UI.XRControlStyle EvenStyle;
        private DevExpress.XtraReports.UI.XRControlStyle OddStyle;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellDetailNo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellDetailDepartmentRoomName;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable xr_HeaderTable;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowHeaderNB;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellNBSTT;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellNBNo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellNBEmployeeName;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellNBDepartmentRoomName;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellDetailEmployeeName;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRowHeader;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellSTT;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellNo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellEmployeeName;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellDepartmentRoomName;
        private WorkingDataSet workingDataSet1;
    }
}
