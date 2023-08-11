using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPBatchProductVMOrderStyle : BaseReport
    {
        #region Contructor
        public RPBatchProductVMOrderStyle()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
        #endregion

        private void xrTableCell21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            XRTable tableHeader = null;
            int groupOrder = 0;
            Int32.TryParse(tableCell.Text, out groupOrder);
            if (groupOrder == 0 || string.IsNullOrEmpty(tableCell.NextCell.Text))
            {
                XRTableRow tableRow = tableCell.Parent as XRTableRow;
                if (tableRow != null)
                {
                    foreach (XRTableCell tableItem in tableRow.Cells)
                    {
                        tableItem.Text = string.Empty;
                        tableItem.CanGrow = true;
                        tableItem.BorderWidth = 0;
                        tableItem.HeightF = 0F;
                        tableItem.SnapLinePadding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
                        tableItem.SnapLineMargin = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
                        tableItem.BoundsF = new RectangleF(new PointF(0, 0), new SizeF(0, 0));
                        tableItem.SizeF = new SizeF(0, 0);
                        tableItem.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
                        tableItem.Multiline = false;
                        tableItem.Visible = false;
                    }
                    tableRow.CanGrow = true;
                    tableRow.Visible = false;
                    tableRow.LocationF = new PointF(0, 0);
                    tableRow.BorderWidth = 0;
                    tableRow.SnapLinePadding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
                    tableRow.SnapLineMargin = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
                    tableRow.SizeF = new SizeF(0, 0);
                    tableRow.HeightF = 0F;
                    tableRow.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
                    tableHeader = tableRow.Parent as XRTable;
                }
                if (tableHeader != null)
                {
                    int count = 0;
                    foreach (XRTableRow tableRowItem in tableHeader)
                    {
                        if (tableRowItem != tableRow)
                            count++;
                    }
                    if (count == 0)
                    {
                        tableHeader.HeightF = 0;
                        tableHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
                        tableHeader.BorderWidth = 0;
                        tableHeader.Visible = false;
                        GroupHeaderBand groupHeaderBand = tableHeader.Parent as GroupHeaderBand;
                        if (groupHeaderBand != null)
                        {
                            groupHeaderBand.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
                            groupHeaderBand.BorderWidth = 0;
                            groupHeaderBand.HeightF = 0F;
                            groupHeaderBand.Visible = false;
                        }
                    }
                }
            }
        }

        private void xrTableCell_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            decimal strNumber = 0;
            Decimal.TryParse(tableCell.Text, out strNumber);
            tableCell.Text = strNumber.ToString("n0");
        }

        private void xrTableCell59_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            if (tableCell == null)
            {
                decimal painQty = 0;
                decimal.TryParse(tableCell.Text, out painQty);
                tableCell.Text = painQty == 0 ? " " : painQty.ToString("n1");
            }
        }
    }
}