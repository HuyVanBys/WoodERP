using DevExpress.XtraReports.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPBatchProductSemiProductBOM : BaseReport
    {
        public decimal ProductionNormItemTotalQty = 0;
        public decimal TotalQty = 0;
        public decimal SumTotalQty = 0;
        #region Contructor
        public RPBatchProductSemiProductBOM(decimal productionNormItemTotalQty)
        {
            InitializeComponent();
            ProductionNormItemTotalQty = productionNormItemTotalQty;
            logoCompany.ImageUrl = Application.StartupPath + BOSERP.BOSApp.CurrentCompanyInfo.CSCompanyLogo.Replace("logo.png", "LogoReport.png");
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
                        tableCell.ForeColor = Color.Black;
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
        }

        private void xrSumQty_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void xrPackRecord_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //if (isFirstPrint)
            //{
            //    Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand;
            //}
            //else
            //{
            //    isFirstPrint = true;
            //}
        }

        private void xrTable4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            BOSERP.MMBatchProductProductionNormItemsInfo ParentOrderName = new BOSERP.MMBatchProductProductionNormItemsInfo();
            ParentOrderName = (BOSERP.MMBatchProductProductionNormItemsInfo)SemiProduct.GetCurrentRow();
            //if (ParentOrderName != null && ParentOrderName.ParentOfParentID == 0)
            if (ParentOrderName != null && ParentOrderName.HasComponent)
            {
                //xrTableCell1.Font = new Font(xrTableCell1.Font.Name, 8, FontStyle.Bold);
                //xrTableCell1.ForeColor = Color.Black;
                xrTableCell2.Font = new Font(xrTableCell2.Font.Name, 8, FontStyle.Bold);
                xrTableCell2.ForeColor = Color.Black;
                xrTableCell3.Font = new Font(xrTableCell3.Font.Name, 8, FontStyle.Bold);
                xrTableCell3.ForeColor = Color.Black;
                xr_tbcProductThick1.Font = new Font(xr_tbcProductThick1.Font.Name, 8, FontStyle.Bold);
                xr_tbcProductThick1.ForeColor = Color.Black;
                xr_tblProductWidth1.Font = new Font(xr_tblProductWidth1.Font.Name, 8, FontStyle.Bold);
                xr_tblProductWidth1.ForeColor = Color.Black;
                xr_tbcProductLenght1.Font = new Font(xr_tbcProductLenght1.Font.Name, 8, FontStyle.Bold);
                xr_tbcProductLenght1.ForeColor = Color.Black;
                //xr_tblProductJouDesc1.Font = new Font(xr_tblProductJouDesc1.Font.Name, 8, FontStyle.Bold);
                //xr_tblProductJouDesc1.ForeColor = Color.Black;
                xrTableCell8.Font = new Font(xrTableCell8.Font.Name, 8, FontStyle.Bold);
                xrTableCell8.ForeColor = Color.Black;
                xrTableCell9.Font = new Font(xrTableCell9.Font.Name, 8, FontStyle.Bold);
                xrTableCell9.ForeColor = Color.Black;
                //xrTableCell10.Font = new Font(xrTableCell10.Font.Name, 10, FontStyle.Bold);
                //xrTableCell10.ForeColor = Color.Black;
                //xrTableCell11.Font = new Font(xrTableCell11.Font.Name, 10, FontStyle.Bold);
                //xrTableCell11.ForeColor = Color.Black;
                //xrTableCell12.Font = new Font(xrTableCell12.Font.Name, 10, FontStyle.Bold);
                //xrTableCell12.ForeColor = Color.Black;
                xrTableCell13.Font = new Font(xrTableCell13.Font.Name, 8, FontStyle.Bold);
                xrTableCell13.ForeColor = Color.Black;
                xrTableCell14.Font = new Font(xrTableCell14.Font.Name, 8, FontStyle.Bold);
                xrTableCell14.ForeColor = Color.Black;
                xrTableCell15.Font = new Font(xrTableCell15.Font.Name, 8, FontStyle.Bold);
                xrTableCell15.ForeColor = Color.Black;
                xrTableCell49.Font = new Font(xrTableCell49.Font.Name, 8, FontStyle.Bold);
                xrTableCell49.ForeColor = Color.Black;
                //xrTableCell16.Font = new Font(xrTableCell16.Font.Name, 10, FontStyle.Bold);
                //xrTableCell16.ForeColor = Color.Black;
                //xrTableCell41.Font = new Font(xrTableCell41.Font.Name, 10, FontStyle.Bold);
                //xrTableCell41.ForeColor = Color.Black;
            }
            else
            {
                //xrTableCell1.Font = new Font(xrTableCell1.Font.Name, 8, FontStyle.Regular);
                //xrTableCell1.ForeColor = Color.Black;
                xrTableCell2.Font = new Font(xrTableCell2.Font.Name, 8, FontStyle.Regular);
                xrTableCell2.ForeColor = Color.Black;
                xrTableCell3.Font = new Font(xrTableCell3.Font.Name, 8, FontStyle.Regular);
                xrTableCell3.ForeColor = Color.Black;
                xr_tbcProductThick1.Font = new Font(xr_tbcProductThick1.Font.Name, 8, FontStyle.Regular);
                xr_tbcProductThick1.ForeColor = Color.Black;
                xr_tblProductWidth1.Font = new Font(xr_tblProductWidth1.Font.Name, 8, FontStyle.Regular);
                xr_tblProductWidth1.ForeColor = Color.Black;
                xr_tbcProductLenght1.Font = new Font(xr_tbcProductLenght1.Font.Name, 8, FontStyle.Regular);
                xr_tbcProductLenght1.ForeColor = Color.Black;
                //xr_tblProductJouDesc1.Font = new Font(xr_tblProductJouDesc1.Font.Name, 10, FontStyle.Regular);
                //xr_tblProductJouDesc1.ForeColor = Color.Black;
                xrTableCell8.Font = new Font(xrTableCell8.Font.Name, 8, FontStyle.Regular);
                xrTableCell8.ForeColor = Color.Black;
                xrTableCell9.Font = new Font(xrTableCell9.Font.Name, 8, FontStyle.Regular);
                xrTableCell9.ForeColor = Color.Black;
                //xrTableCell10.Font = new Font(xrTableCell10.Font.Name, 10, FontStyle.Regular);
                //xrTableCell10.ForeColor = Color.Black;
                //xrTableCell11.Font = new Font(xrTableCell11.Font.Name, 10, FontStyle.Regular);
                //xrTableCell11.ForeColor = Color.Black;
                //xrTableCell12.Font = new Font(xrTableCell12.Font.Name, 10, FontStyle.Regular);
                //xrTableCell12.ForeColor = Color.Black;
                xrTableCell13.Font = new Font(xrTableCell13.Font.Name, 8, FontStyle.Regular);
                xrTableCell13.ForeColor = Color.Black;
                xrTableCell14.Font = new Font(xrTableCell14.Font.Name, 8, FontStyle.Regular);
                xrTableCell14.ForeColor = Color.Black;
                xrTableCell15.Font = new Font(xrTableCell15.Font.Name, 8, FontStyle.Regular);
                xrTableCell15.ForeColor = Color.Black;
                xrTableCell49.Font = new Font(xrTableCell49.Font.Name, 8, FontStyle.Regular);
                xrTableCell49.ForeColor = Color.Black;
                //xrTableCell16.Font = new Font(xrTableCell16.Font.Name, 10, FontStyle.Regular);
                //xrTableCell16.ForeColor = Color.Black;
                //xrTableCell41.Font = new Font(xrTableCell41.Font.Name, 10, FontStyle.Regular);
                //xrTableCell41.ForeColor = Color.Black;
            }
        }

        private void xr_tbcProductThick1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void xr_tblProductWidth1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void xr_tbcProductLenght1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void xrTableCell10_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void xrTableCell6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrTableCell6.Text = string.Format("{0:n5}", ProductionNormItemTotalQty);
        }

        private void xrTableCell2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            BOSERP.MMBatchProductProductionNormItemsInfo ParentOrderName = new BOSERP.MMBatchProductProductionNormItemsInfo();
            ParentOrderName = (BOSERP.MMBatchProductProductionNormItemsInfo)SemiProduct.GetCurrentRow();
            if (ParentOrderName != null && ParentOrderName.HasComponent)
            {
                //xrTableCell1.Font = new Font(xrTableCell1.Font.Name, 8, FontStyle.Bold);
                //xrTableCell1.ForeColor = Color.Black;
                xrTableCell2.Font = new Font(xrTableCell2.Font.Name, 8, FontStyle.Bold);
                xrTableCell2.ForeColor = Color.Black;
                xrTableCell3.Font = new Font(xrTableCell3.Font.Name, 8, FontStyle.Bold);
                xrTableCell3.ForeColor = Color.Black;
                xr_tbcProductThick1.Font = new Font(xr_tbcProductThick1.Font.Name, 8, FontStyle.Bold);
                xr_tbcProductThick1.ForeColor = Color.Black;
                xr_tblProductWidth1.Font = new Font(xr_tblProductWidth1.Font.Name, 8, FontStyle.Bold);
                xr_tblProductWidth1.ForeColor = Color.Black;
                xr_tbcProductLenght1.Font = new Font(xr_tbcProductLenght1.Font.Name, 8, FontStyle.Bold);
                xr_tbcProductLenght1.ForeColor = Color.Black;
                //xr_tblProductJouDesc1.Font = new Font(xr_tblProductJouDesc1.Font.Name, 8, FontStyle.Bold);
                //xr_tblProductJouDesc1.ForeColor = Color.Black;
                xrTableCell8.Font = new Font(xrTableCell8.Font.Name, 8, FontStyle.Bold);
                xrTableCell8.ForeColor = Color.Black;
                xrTableCell9.Font = new Font(xrTableCell9.Font.Name, 8, FontStyle.Bold);
                xrTableCell9.ForeColor = Color.Black;
                //xrTableCell10.Font = new Font(xrTableCell10.Font.Name, 10, FontStyle.Bold);
                //xrTableCell10.ForeColor = Color.Black;
                //xrTableCell11.Font = new Font(xrTableCell11.Font.Name, 10, FontStyle.Bold);
                //xrTableCell11.ForeColor = Color.Black;
                //xrTableCell12.Font = new Font(xrTableCell12.Font.Name, 10, FontStyle.Bold);
                //xrTableCell12.ForeColor = Color.Black;
                xrTableCell13.Font = new Font(xrTableCell13.Font.Name, 8, FontStyle.Bold);
                xrTableCell13.ForeColor = Color.Black;
                xrTableCell14.Font = new Font(xrTableCell14.Font.Name, 8, FontStyle.Bold);
                xrTableCell14.ForeColor = Color.Black;
                xrTableCell15.Font = new Font(xrTableCell15.Font.Name, 8, FontStyle.Bold);
                xrTableCell15.ForeColor = Color.Black;
                xrTableCell49.Font = new Font(xrTableCell49.Font.Name, 8, FontStyle.Bold);
                xrTableCell49.ForeColor = Color.Black;
                //xrTableCell16.Font = new Font(xrTableCell16.Font.Name, 10, FontStyle.Bold);
                //xrTableCell16.ForeColor = Color.Black;
                //xrTableCell41.Font = new Font(xrTableCell41.Font.Name, 10, FontStyle.Bold);
                //xrTableCell41.ForeColor = Color.Black;
            }
            else
            {
                //xrTableCell1.Font = new Font(xrTableCell1.Font.Name, 8, FontStyle.Regular);
                //xrTableCell1.ForeColor = Color.Black;
                xrTableCell2.Font = new Font(xrTableCell2.Font.Name, 8, FontStyle.Regular);
                xrTableCell2.ForeColor = Color.Black;
                xrTableCell3.Font = new Font(xrTableCell3.Font.Name, 8, FontStyle.Regular);
                xrTableCell3.ForeColor = Color.Black;
                xr_tbcProductThick1.Font = new Font(xr_tbcProductThick1.Font.Name, 8, FontStyle.Regular);
                xr_tbcProductThick1.ForeColor = Color.Black;
                xr_tblProductWidth1.Font = new Font(xr_tblProductWidth1.Font.Name, 8, FontStyle.Regular);
                xr_tblProductWidth1.ForeColor = Color.Black;
                xr_tbcProductLenght1.Font = new Font(xr_tbcProductLenght1.Font.Name, 8, FontStyle.Regular);
                xr_tbcProductLenght1.ForeColor = Color.Black;
                //xr_tblProductJouDesc1.Font = new Font(xr_tblProductJouDesc1.Font.Name, 10, FontStyle.Regular);
                //xr_tblProductJouDesc1.ForeColor = Color.Black;
                xrTableCell8.Font = new Font(xrTableCell8.Font.Name, 8, FontStyle.Regular);
                xrTableCell8.ForeColor = Color.Black;
                xrTableCell9.Font = new Font(xrTableCell9.Font.Name, 8, FontStyle.Regular);
                xrTableCell9.ForeColor = Color.Black;
                //xrTableCell10.Font = new Font(xrTableCell10.Font.Name, 10, FontStyle.Regular);
                //xrTableCell10.ForeColor = Color.Black;
                //xrTableCell11.Font = new Font(xrTableCell11.Font.Name, 10, FontStyle.Regular);
                //xrTableCell11.ForeColor = Color.Black;
                //xrTableCell12.Font = new Font(xrTableCell12.Font.Name, 10, FontStyle.Regular);
                //xrTableCell12.ForeColor = Color.Black;
                xrTableCell13.Font = new Font(xrTableCell13.Font.Name, 8, FontStyle.Regular);
                xrTableCell13.ForeColor = Color.Black;
                xrTableCell14.Font = new Font(xrTableCell14.Font.Name, 8, FontStyle.Regular);
                xrTableCell14.ForeColor = Color.Black;
                xrTableCell15.Font = new Font(xrTableCell15.Font.Name, 8, FontStyle.Regular);
                xrTableCell15.ForeColor = Color.Black;
                xrTableCell49.Font = new Font(xrTableCell49.Font.Name, 8, FontStyle.Regular);
                xrTableCell49.ForeColor = Color.Black;
                //xrTableCell16.Font = new Font(xrTableCell16.Font.Name, 10, FontStyle.Regular);
                //xrTableCell16.ForeColor = Color.Black;
                //xrTableCell41.Font = new Font(xrTableCell41.Font.Name, 10, FontStyle.Regular);
                //xrTableCell41.ForeColor = Color.Black;
            }
        }

        private void xrTableCell3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            BOSERP.MMBatchProductProductionNormItemsInfo ParentOrderName = new BOSERP.MMBatchProductProductionNormItemsInfo();
            ParentOrderName = (BOSERP.MMBatchProductProductionNormItemsInfo)SemiProduct.GetCurrentRow();
            if (ParentOrderName != null && ParentOrderName.HasComponent)
            {
                decimal cellValue = 0;
                if (decimal.TryParse(xrTableCell3.Text, out cellValue))
                {
                    if (cellValue == 0)
                    {
                        xrTableCell3.Text = "";
                    }
                }
                if(ParentOrderName.MMBatchProductProductionNormItemParentOrderName.Length == 1) 
                {
                    TotalQty = 0;
                    xrTableCell3.Text = "";
                }
                xrTableCell6.Text = string.Format("{0:n5}", TotalQty);
            }
            else
            {
                decimal cellValue = 0;
                if (decimal.TryParse(xrTableCell3.Text, out cellValue))
                {
                    if (cellValue > 0)
                    {
                        if(!ParentOrderName.HasComponent)
                        {
                            TotalQty += cellValue;
                            SumTotalQty += cellValue;
                        }
                        xrTableCell6.Text = string.Format("{0:n5}", TotalQty);
                        xrTableCell4.Text = "Tổng M3: " + string.Format("{0:n5}", SumTotalQty);
                    }
                }
            }
        }

        private void xrTableCell1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            BOSERP.MMBatchProductProductionNormItemsInfo ParentOrderName = new BOSERP.MMBatchProductProductionNormItemsInfo();
            ParentOrderName = (BOSERP.MMBatchProductProductionNormItemsInfo)SemiProduct.GetCurrentRow();
            if (ParentOrderName != null && ParentOrderName.HasComponent)
            {
                //xrTableCell1.Font = new Font(xrTableCell1.Font.Name, 8, FontStyle.Bold);
                //xrTableCell1.ForeColor = Color.Black;
                xrTableCell2.Font = new Font(xrTableCell2.Font.Name, 8, FontStyle.Bold);
                xrTableCell2.ForeColor = Color.Black;
                xrTableCell3.Font = new Font(xrTableCell3.Font.Name, 8, FontStyle.Bold);
                xrTableCell3.ForeColor = Color.Black;
                xr_tbcProductThick1.Font = new Font(xr_tbcProductThick1.Font.Name, 8, FontStyle.Bold);
                xr_tbcProductThick1.ForeColor = Color.Black;
                xr_tblProductWidth1.Font = new Font(xr_tblProductWidth1.Font.Name, 8, FontStyle.Bold);
                xr_tblProductWidth1.ForeColor = Color.Black;
                xr_tbcProductLenght1.Font = new Font(xr_tbcProductLenght1.Font.Name, 8, FontStyle.Bold);
                xr_tbcProductLenght1.ForeColor = Color.Black;
                //xr_tblProductJouDesc1.Font = new Font(xr_tblProductJouDesc1.Font.Name, 8, FontStyle.Bold);
                //xr_tblProductJouDesc1.ForeColor = Color.Black;
                xrTableCell8.Font = new Font(xrTableCell8.Font.Name, 8, FontStyle.Bold);
                xrTableCell8.ForeColor = Color.Black;
                xrTableCell9.Font = new Font(xrTableCell9.Font.Name, 8, FontStyle.Bold);
                xrTableCell9.ForeColor = Color.Black;
                //xrTableCell10.Font = new Font(xrTableCell10.Font.Name, 10, FontStyle.Bold);
                //xrTableCell10.ForeColor = Color.Black;
                //xrTableCell11.Font = new Font(xrTableCell11.Font.Name, 10, FontStyle.Bold);
                //xrTableCell11.ForeColor = Color.Black;
                //xrTableCell12.Font = new Font(xrTableCell12.Font.Name, 10, FontStyle.Bold);
                //xrTableCell12.ForeColor = Color.Black;
                xrTableCell13.Font = new Font(xrTableCell13.Font.Name, 8, FontStyle.Bold);
                xrTableCell13.ForeColor = Color.Black;
                xrTableCell14.Font = new Font(xrTableCell14.Font.Name, 8, FontStyle.Bold);
                xrTableCell14.ForeColor = Color.Black;
                xrTableCell15.Font = new Font(xrTableCell15.Font.Name, 8, FontStyle.Bold);
                xrTableCell15.ForeColor = Color.Black;
                xrTableCell49.Font = new Font(xrTableCell49.Font.Name, 8, FontStyle.Bold);
                xrTableCell49.ForeColor = Color.Black;
                //xrTableCell16.Font = new Font(xrTableCell16.Font.Name, 10, FontStyle.Bold);
                //xrTableCell16.ForeColor = Color.Black;
                //xrTableCell41.Font = new Font(xrTableCell41.Font.Name, 10, FontStyle.Bold);
                //xrTableCell41.ForeColor = Color.Black;
            }
            else
            {
                //xrTableCell1.Font = new Font(xrTableCell1.Font.Name, 8, FontStyle.Regular);
                //xrTableCell1.ForeColor = Color.Black;
                xrTableCell2.Font = new Font(xrTableCell2.Font.Name, 8, FontStyle.Regular);
                xrTableCell2.ForeColor = Color.Black;
                xrTableCell3.Font = new Font(xrTableCell3.Font.Name, 8, FontStyle.Regular);
                xrTableCell3.ForeColor = Color.Black;
                xr_tbcProductThick1.Font = new Font(xr_tbcProductThick1.Font.Name, 8, FontStyle.Regular);
                xr_tbcProductThick1.ForeColor = Color.Black;
                xr_tblProductWidth1.Font = new Font(xr_tblProductWidth1.Font.Name, 8, FontStyle.Regular);
                xr_tblProductWidth1.ForeColor = Color.Black;
                xr_tbcProductLenght1.Font = new Font(xr_tbcProductLenght1.Font.Name, 8, FontStyle.Regular);
                xr_tbcProductLenght1.ForeColor = Color.Black;
                //xr_tblProductJouDesc1.Font = new Font(xr_tblProductJouDesc1.Font.Name, 10, FontStyle.Regular);
                //xr_tblProductJouDesc1.ForeColor = Color.Black;
                xrTableCell8.Font = new Font(xrTableCell8.Font.Name, 8, FontStyle.Regular);
                xrTableCell8.ForeColor = Color.Black;
                xrTableCell9.Font = new Font(xrTableCell9.Font.Name, 8, FontStyle.Regular);
                xrTableCell9.ForeColor = Color.Black;
                //xrTableCell10.Font = new Font(xrTableCell10.Font.Name, 10, FontStyle.Regular);
                //xrTableCell10.ForeColor = Color.Black;
                //xrTableCell11.Font = new Font(xrTableCell11.Font.Name, 10, FontStyle.Regular);
                //xrTableCell11.ForeColor = Color.Black;
                //xrTableCell12.Font = new Font(xrTableCell12.Font.Name, 10, FontStyle.Regular);
                //xrTableCell12.ForeColor = Color.Black;
                xrTableCell13.Font = new Font(xrTableCell13.Font.Name, 8, FontStyle.Regular);
                xrTableCell13.ForeColor = Color.Black;
                xrTableCell14.Font = new Font(xrTableCell14.Font.Name, 8, FontStyle.Regular);
                xrTableCell14.ForeColor = Color.Black;
                xrTableCell15.Font = new Font(xrTableCell15.Font.Name, 8, FontStyle.Regular);
                xrTableCell15.ForeColor = Color.Black;
                xrTableCell49.Font = new Font(xrTableCell49.Font.Name, 8, FontStyle.Regular);
                xrTableCell49.ForeColor = Color.Black;
                //xrTableCell16.Font = new Font(xrTableCell16.Font.Name, 10, FontStyle.Regular);
                //xrTableCell16.ForeColor = Color.Black;
                //xrTableCell41.Font = new Font(xrTableCell41.Font.Name, 10, FontStyle.Regular);
                //xrTableCell41.ForeColor = Color.Black;
            }
        }

        private void xrTableCell6_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //xrTableCell6.Text = string.Format("{0:n5}", TotalQty);
        }

        private void xrTableCell14_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal cellValue = 0;
            if (decimal.TryParse(xrTableCell14.Text, out cellValue))
            {
                if (cellValue == 0)
                {
                    xrTableCell14.Text = "";
                }
            }
        }

        private void xrTableCell15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal cellValue = 0;
            if (decimal.TryParse(xrTableCell15.Text, out cellValue))
            {
                if (cellValue == 0)
                {
                    xrTableCell15.Text = "";
                }
            }
        }
    }
}
