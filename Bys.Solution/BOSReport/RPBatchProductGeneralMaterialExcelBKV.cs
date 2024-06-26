using DevExpress.XtraReports.UI;
using System;
using System.Drawing;
using System.Windows.Forms;
using BOSERP;

namespace BOSReport
{
    public partial class RPBatchProductGeneralMaterialExcelBKV : BaseReport
    {
        public decimal ProductionNormItemTotalQty = 0;
        #region Contructor
        public RPBatchProductGeneralMaterialExcelBKV(decimal productionNormItemTotalQty)
        {
            InitializeComponent();
            ProductionNormItemTotalQty = productionNormItemTotalQty;
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo.Replace("logo.png", "LogoCN.png");
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
            decimal number = 0;
            decimal.TryParse(xrTableCell29.Text.ToString(), out number);
            if (number % 1 == 0)
            {
                decimal so = Math.Round((decimal)number, 0);
                xrTableCell29.Text = string.Format("{0:n0}", so);
            }
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
            //BOSERP.MMBatchProductProductionNormItemsInfo ParentOrderName = new BOSERP.MMBatchProductProductionNormItemsInfo();
            //ParentOrderName = (BOSERP.MMBatchProductProductionNormItemsInfo)IngredientPackaging.GetCurrentRow();
            //if (ParentOrderName != null && ParentOrderName.MMBatchProductProductionNormItemIsComponent)
            //{
            //    xrPackRecord.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xrPackProductName.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xrPackProductNo.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xrPackQty.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xrPackInside.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xrPackOutSide.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xrPackSizeOrSpecs.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    //xrPackDVT.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xrPackRemark.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    //xrPackNW.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //    xrPackGW.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
            //}
            //else
            //{
            //    xrPackRecord.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xrPackProductName.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xrPackProductNo.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xrPackQty.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xrPackInside.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xrPackOutSide.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xrPackSizeOrSpecs.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    // xrPackDVT.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xrPackRemark.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    //  xrPackNW.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //    xrPackGW.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
            //}
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
    }
}
