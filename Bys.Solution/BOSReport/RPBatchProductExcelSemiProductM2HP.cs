using DevExpress.XtraReports.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPBatchProductExcelSemiProductM2HP : BaseReport
    {
        public decimal ProductionNormItemTotalQty = 0;
        #region Contructor
        public RPBatchProductExcelSemiProductM2HP(decimal productionNormItemTotalQty)
        {
            InitializeComponent();
            ProductionNormItemTotalQty = productionNormItemTotalQty;
            //logoCompany.ImageUrl = Application.StartupPath + BOSERP.BOSApp.CurrentCompanyInfo.CSCompanyLogo.Replace("logo.png", "LogoCN.png");
        }
        #endregion
        #region Before Print


        /// <summary>
        /// Set text of type decimal   TableCell
        /// </summary>
        /// <param name="tableCell"> tableCell</param>
        private void SetTextOfTypedecimalTableCell(XRTableCell tableCell)
        {
            if (!string.IsNullOrEmpty(tableCell.Text))
            {
                XRBinding biding = tableCell.DataBindings[0];
                decimal cellValue = 0;
                if (decimal.TryParse(tableCell.Text, out cellValue))
                {
                    if (cellValue < 0)
                    {
                        if (tableCell.Text.StartsWith("-"))
                        {
                            tableCell.Text = tableCell.Text.Remove(0, 1);
                        }
                        tableCell.Text = string.Format("({0})", tableCell.Text);
                        tableCell.ForeColor = Color.Red;
                    }
                    else if (cellValue > 0)
                    {
                        tableCell.ForeColor = Color.Black;
                    }
                    else if (cellValue == 0)
                    {
                        tableCell.Text = string.Format("{0}", "-");
                        tableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    }
                }
            }
            else
            {
                tableCell.Text = string.Format("{0}", "-");
                tableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            }
        }
        #region ProductionNorm
        private void xrTbc_Acreage_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }
        private void xrTbcBlocks_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }
        private void xrTbcMDFBlocks_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }
        private void xrTbcPlyWood_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }
        private void xrTbcPaintA_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }
        private void xrTbcTotalWoodConsumable_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }
        private void xrTbcPaintB_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }
        private void xrTbcSumTotalWoodConsumable_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }
        private void xrTbcSumPaintA_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }
        private void xrTbcSumBlocks_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }
        private void xrTbcSumAcreage_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }
        private void xrTbcSumPaintB_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }
        #endregion


        #region Hardware
        private void xrTbcAssembleTotalQuantity_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }

        private void xrTbcSubForOnes_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }

        private void xrTbcSubForSets_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }

        private void xrTbcSubForCustomer_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }

        private void xrTbcBuyTotalQuantity_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }

        private void xrTbcAllocationTotalQuantity_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }
        #endregion

        #region Paint
        private void xrTbcTotalQuantity_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }
        #endregion

        private void xrTable2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }
        #endregion
        bool isFirstPrint = false;
        private void xr_tbcRecord_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //BOSERP.MMBatchProductProductionNormItemsInfo ParentOrderName = new BOSERP.MMBatchProductProductionNormItemsInfo();
            //ParentOrderName = (BOSERP.MMBatchProductProductionNormItemsInfo)SemiProduct.GetCurrentRow();
            //if (ParentOrderName != null && string.IsNullOrEmpty(ParentOrderName.MMBatchProductProductionNormItemParentNo) && ParentOrderName.MMBatchProductProductionNormItemParentID == 0)
            //{
            //    xr_tbcRecord.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xr_tbcProductNo.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xr_tbcProductName.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xr_tbcProductWoodType.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xr_tbcAttribute1.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xr_tbcProductDesc.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xr_tbcDescriptionRate.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xr_tbcQuantity.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xr_tbcProductThick.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xr_tblProductWidth.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xr_tbcProductLenght.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xr_tblProductJouDesc.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xrTbcBlocks.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xrTbcMDFBlocks.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xrTbcPaintA.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xrTbcPaintB.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xrTbcTotalWoodConsumable.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //}
            //else
            //{
            //    xr_tbcRecord.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xr_tbcProductNo.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xr_tbcProductName.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xr_tbcProductWoodType.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xr_tbcAttribute1.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xr_tbcProductDesc.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xr_tbcDescriptionRate.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xr_tbcQuantity.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xr_tbcProductThick.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xr_tblProductWidth.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xr_tbcProductLenght.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xr_tblProductJouDesc.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xrTbcBlocks.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xrTbcMDFBlocks.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xrTbcPaintA.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xrTbcPaintB.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xrTbcTotalWoodConsumable.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //}
        }

        private void xrSumQty_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //xrSumQty.Text = ProductionNormItemTotalQty.ToString();
        }

        private void xrPackRecord_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (isFirstPrint)
            {
                Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand;
            }
            else
            {
                isFirstPrint = true;
            }
        }

        private void xrTable4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            BOSERP.MMBatchProductProductionNormItemsInfo ParentOrderName = new BOSERP.MMBatchProductProductionNormItemsInfo();
            ParentOrderName = (BOSERP.MMBatchProductProductionNormItemsInfo)SemiProduct.GetCurrentRow();
            //if (ParentOrderName != null && ParentOrderName.ParentOfParentID == 0)
            if (ParentOrderName != null && ParentOrderName.HasComponent)
            {
                xrTableCell1.Font = new Font(xrTableCell1.Font.Name, 12, FontStyle.Bold);
                xrTableCell1.ForeColor = Color.Red;
                xrTableCell2.Font = new Font(xrTableCell2.Font.Name, 12, FontStyle.Bold);
                xrTableCell2.ForeColor = Color.Red;
                xrTableCell3.Font = new Font(xrTableCell3.Font.Name, 12, FontStyle.Bold);
                xrTableCell3.ForeColor = Color.Red;
                xr_tbcProductThick1.Font = new Font(xr_tbcProductThick1.Font.Name, 12, FontStyle.Bold);
                xr_tbcProductThick1.ForeColor = Color.Red;
                xr_tblProductWidth1.Font = new Font(xr_tblProductWidth1.Font.Name, 12, FontStyle.Bold);
                xr_tblProductWidth1.ForeColor = Color.Red;
                xr_tbcProductLenght1.Font = new Font(xr_tbcProductLenght1.Font.Name, 12, FontStyle.Bold);
                xr_tbcProductLenght1.ForeColor = Color.Red;
                //xr_tblProductJouDesc1.Font = new Font(xr_tblProductJouDesc1.Font.Name, 12, FontStyle.Bold);
                //xr_tblProductJouDesc1.ForeColor = Color.Red;
                xrTableCell8.Font = new Font(xrTableCell8.Font.Name, 12, FontStyle.Bold);
                xrTableCell8.ForeColor = Color.Red;
                xrTableCell9.Font = new Font(xrTableCell9.Font.Name, 12, FontStyle.Bold);
                xrTableCell9.ForeColor = Color.Red;
                xrTableCell10.Font = new Font(xrTableCell10.Font.Name, 12, FontStyle.Bold);
                xrTableCell10.ForeColor = Color.Red;
                xrTableCell11.Font = new Font(xrTableCell11.Font.Name, 12, FontStyle.Bold);
                xrTableCell11.ForeColor = Color.Red;
                xrTableCell12.Font = new Font(xrTableCell12.Font.Name, 12, FontStyle.Bold);
                xrTableCell12.ForeColor = Color.Red;
                xrTableCell13.Font = new Font(xrTableCell13.Font.Name, 12, FontStyle.Bold);
                xrTableCell13.ForeColor = Color.Red;
                xrTableCell14.Font = new Font(xrTableCell14.Font.Name, 12, FontStyle.Bold);
                xrTableCell14.ForeColor = Color.Red;
                xrTableCell15.Font = new Font(xrTableCell15.Font.Name, 12, FontStyle.Bold);
                xrTableCell15.ForeColor = Color.Red;
                xrTableCell16.Font = new Font(xrTableCell16.Font.Name, 12, FontStyle.Bold);
                xrTableCell16.ForeColor = Color.Red;
                xrTableCell14.Font = new Font(xrTableCell14.Font.Name, 12, FontStyle.Bold);
                xrTableCell14.ForeColor = Color.Red;
                xrTableCell15.Font = new Font(xrTableCell15.Font.Name, 12, FontStyle.Bold);
                xrTableCell15.ForeColor = Color.Red;
                xrTableCell43.Font = new Font(xrTableCell43.Font.Name, 12, FontStyle.Bold);
                xrTableCell43.ForeColor = Color.Red;
                xrTableCell44.Font = new Font(xrTableCell44.Font.Name, 12, FontStyle.Bold);
                xrTableCell44.ForeColor = Color.Red;
                xrTableCell45.Font = new Font(xrTableCell45.Font.Name, 12, FontStyle.Bold);
                xrTableCell45.ForeColor = Color.Red;
            }
            else
            {
                xrTableCell1.Font = new Font(xrTableCell1.Font.Name, 12, FontStyle.Regular);
                xrTableCell1.ForeColor = Color.Black;
                xrTableCell2.Font = new Font(xrTableCell2.Font.Name, 12, FontStyle.Regular);
                xrTableCell2.ForeColor = Color.Black;
                xrTableCell3.Font = new Font(xrTableCell3.Font.Name, 12, FontStyle.Regular);
                xrTableCell3.ForeColor = Color.Black;
                xr_tbcProductThick1.Font = new Font(xr_tbcProductThick1.Font.Name, 12, FontStyle.Regular);
                xr_tbcProductThick1.ForeColor = Color.Black;
                xr_tblProductWidth1.Font = new Font(xr_tblProductWidth1.Font.Name, 12, FontStyle.Regular);
                xr_tblProductWidth1.ForeColor = Color.Black;
                xr_tbcProductLenght1.Font = new Font(xr_tbcProductLenght1.Font.Name, 12, FontStyle.Regular);
                xr_tbcProductLenght1.ForeColor = Color.Black;
                //xr_tblProductJouDesc1.Font = new Font(xr_tblProductJouDesc1.Font.Name, 12, FontStyle.Regular);
                //xr_tblProductJouDesc1.ForeColor = Color.Black;
                xrTableCell8.Font = new Font(xrTableCell8.Font.Name, 12, FontStyle.Regular);
                xrTableCell8.ForeColor = Color.Black;
                xrTableCell9.Font = new Font(xrTableCell9.Font.Name, 12, FontStyle.Regular);
                xrTableCell9.ForeColor = Color.Black;
                xrTableCell10.Font = new Font(xrTableCell10.Font.Name, 12, FontStyle.Regular);
                xrTableCell10.ForeColor = Color.Black;
                xrTableCell11.Font = new Font(xrTableCell11.Font.Name, 12, FontStyle.Regular);
                xrTableCell11.ForeColor = Color.Black;
                xrTableCell12.Font = new Font(xrTableCell12.Font.Name, 12, FontStyle.Regular);
                xrTableCell12.ForeColor = Color.Black;
                xrTableCell13.Font = new Font(xrTableCell13.Font.Name, 12, FontStyle.Regular);
                xrTableCell13.ForeColor = Color.Black;
                xrTableCell14.Font = new Font(xrTableCell14.Font.Name, 12, FontStyle.Regular);
                xrTableCell14.ForeColor = Color.Black;
                xrTableCell15.Font = new Font(xrTableCell15.Font.Name, 12, FontStyle.Regular);
                xrTableCell15.ForeColor = Color.Black;
                xrTableCell16.Font = new Font(xrTableCell16.Font.Name, 12, FontStyle.Regular);
                xrTableCell16.ForeColor = Color.Black;
                xrTableCell14.Font = new Font(xrTableCell14.Font.Name, 12, FontStyle.Regular);
                xrTableCell14.ForeColor = Color.Black;
                xrTableCell15.Font = new Font(xrTableCell15.Font.Name, 12, FontStyle.Regular);
                xrTableCell15.ForeColor = Color.Black;
                xrTableCell43.Font = new Font(xrTableCell43.Font.Name, 12, FontStyle.Regular);
                xrTableCell43.ForeColor = Color.Black;
                xrTableCell44.Font = new Font(xrTableCell44.Font.Name, 12, FontStyle.Regular);
                xrTableCell44.ForeColor = Color.Black;
                xrTableCell45.Font = new Font(xrTableCell45.Font.Name, 12, FontStyle.Regular);
                xrTableCell45.ForeColor = Color.Black;
            }
        }

        private void xr_tbcProductThick1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal number = 0;
            decimal.TryParse(xr_tbcProductThick1.Text.ToString(), out number);
            if (number == 0)
            {
                xr_tbcProductThick1.Text = "";
            }
            else if (number % 1 == 0)
            {
                decimal so = Math.Round((decimal)number, 0);
                xr_tbcProductThick1.Text = string.Format("{0:n0}", so);
            }
            else if (number * 10 % 1 == 0)
            {
                decimal so = Math.Round((decimal)number, 1);
                xr_tbcProductThick1.Text = string.Format("{0:n1}", so);
            }
        }

        private void xr_tblProductWidth1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal number = 0;
            decimal.TryParse(xr_tblProductWidth1.Text.ToString(), out number);
            if (number == 0)
            {
                xr_tblProductWidth1.Text = "";
            }
            else if (number % 1 == 0)
            {
                decimal so = Math.Round((decimal)number, 0);
                xr_tblProductWidth1.Text = string.Format("{0:n0}", so);
            }
            else if (number * 10 % 1 == 0)
            {
                decimal so = Math.Round((decimal)number, 1);
                xr_tblProductWidth1.Text = string.Format("{0:n1}", so);
            }
        }

        private void xr_tbcProductLenght1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal number = 0;
            decimal.TryParse(xr_tbcProductLenght1.Text.ToString(), out number);
            if (number == 0)
            {
                xr_tbcProductLenght1.Text = "";
            }
            else if (number % 1 == 0)
            {
                decimal so = Math.Round((decimal)number, 0);
                xr_tbcProductLenght1.Text = string.Format("{0:n0}", so);
            }
            else if (number * 10 % 1 == 0)
            {
                decimal so = Math.Round((decimal)number, 1);
                xr_tbcProductLenght1.Text = string.Format("{0:n1}", so);
            }
        }

        private void xrTableCell10_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal number = 0;
            decimal.TryParse(xrTableCell10.Text.ToString(), out number);
            if (number == 0)
            {
                xrTableCell10.Text = "";
            }
            else if (number % 1 == 0)
            {
                decimal so = Math.Round((decimal)number, 0);
                xrTableCell10.Text = string.Format("{0:n0}", so);
            }
            else if (number * 10 % 1 == 0)
            {
                decimal so = Math.Round((decimal)number, 1);
                xrTableCell10.Text = string.Format("{0:n1}", so);
            }
        }

        private void xrTableCell15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal number = 0;
            decimal.TryParse(xrTableCell15.Text.ToString(), out number);
            if (number == 0)
            {
                xrTableCell15.Text = "";
            }
            else if (number % 1 == 0)
            {
                decimal so = Math.Round((decimal)number, 0);
                xrTableCell15.Text = string.Format("{0:n0}", so);
            }
            else if (number * 10 % 1 == 0)
            {
                decimal so = Math.Round((decimal)number, 1);
                xrTableCell15.Text = string.Format("{0:n1}", so);
            }
        }

        private void xrTableCell43_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal number = 0;
            decimal.TryParse(xrTableCell43.Text.ToString(), out number);
            if (number == 0)
            {
                xrTableCell43.Text = "";
            }
            else if (number % 1 == 0)
            {
                decimal so = Math.Round((decimal)number, 0);
                xrTableCell43.Text = string.Format("{0:n0}", so);
            }
            else if (number * 10 % 1 == 0)
            {
                decimal so = Math.Round((decimal)number, 1);
                xrTableCell43.Text = string.Format("{0:n1}", so);
            }
        }
    }
}
