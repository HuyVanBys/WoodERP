using BOSERP;
using DevExpress.XtraReports.UI;
using System.Drawing;
using System.Windows.Forms;
using System;


namespace BOSReport
{
    public partial class RPProductionNormSemiProductHP : BaseReport
    {
        public decimal ProductionNormItemTotalQty = 0;
        #region Contructor
        public RPProductionNormSemiProductHP(decimal productionNormItemTotalQty)
        {
            InitializeComponent();
            //logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
            ProductionNormItemTotalQty = productionNormItemTotalQty;
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
        }
        #endregion
        #region Before Print

        //TNDLoc [ADD][29/01/2016][Issue sum production norm report],START
        public decimal ProductionNormItemWoodBlocks = 0;
        public decimal ProductionNormItemPaintA = 0;
        public decimal ProductionNormItemPaintB = 0;
        public decimal ProductionNormItemPaintTotalWoodConsumable = 0;
        //TNDLoc [ADD][29/01/2016][Issue sum production norm report],END
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
            //XRTableCell tableCell = (XRTableCell)sender;
            //SetTextOfTypedecimalTableCell(tableCell);
            //xrTbcSumTotalWoodConsumable.Text = ProductionNormItemPaintTotalWoodConsumable.ToString();
        }
        private void xrTbcSumPaintA_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //XRTableCell tableCell = (XRTableCell)sender;
            //SetTextOfTypedecimalTableCell(tableCell);
            //xrTbcSumPaintA.Text = ProductionNormItemPaintA.ToString();
        }
        private void xrTbcSumBlocks_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //XRTableCell tableCell = (XRTableCell)sender;
            //SetTextOfTypedecimalTableCell(tableCell);
            //xrTbcSumBlocks.Text = ProductionNormItemWoodBlocks.ToString();
        }
        private void xrTbcSumAcreage_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }
        private void xrTbcSumPaintB_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //XRTableCell tableCell = (XRTableCell)sender;
            //SetTextOfTypedecimalTableCell(tableCell);
            //xrTbcSumPaintB.Text = ProductionNormItemPaintB.ToString();
        }
        #endregion


        #region Hardware
        private void xrTbcAssembleTotalQuantity_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextOfTypedecimalTableCell(tableCell);
        }
        private void RoundByN2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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

        private void xr_tbcRecord_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            BOSERP.MMProductionNormItemsInfo ParentOrderName = new BOSERP.MMProductionNormItemsInfo();
            try 
            {
                ParentOrderName = (BOSERP.MMProductionNormItemsInfo)SemiProduct.GetCurrentRow();
                if (ParentOrderName != null && string.IsNullOrEmpty(ParentOrderName.MMProductionNormItemParentNo) && ParentOrderName.MMProductionNormItemParentID == 0)
                {
                    xr_tbcRecord.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xr_tbcProductName.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xr_tbcProductWoodType.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xr_tbcAttribute1.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xr_tbcProductDesc.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xr_tbcDescriptionRate.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xr_tbcQuantity.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xr_tblProductWidth.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xr_tbcProductLenght.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xrTbcBlocks.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xrTbcMDFBlocks.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);

                    xr_tbcProductMaterialDepreciationRate.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xrTbcPaintA.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xrTbcPaintB.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xrTbcTotalWoodConsumable.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                }
                else
                {
                    xr_tbcRecord.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xr_tbcProductName.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xr_tbcProductWoodType.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xr_tbcAttribute1.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xr_tbcProductDesc.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xr_tbcDescriptionRate.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xr_tbcQuantity.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xr_tblProductWidth.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xr_tbcProductLenght.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xrTbcBlocks.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xrTbcMDFBlocks.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);

                    xr_tbcProductMaterialDepreciationRate.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    //xrTbcPaintA.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    //xrTbcPaintB.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    //xrTbcTotalWoodConsumable.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                }
            }
            catch (Exception) 
            { }
        }

        private void xrSumQty_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //xrSumQty.Text = ProductionNormItemTotalQty.ToString();
        }

        private void xrPackRecord_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            BOSERP.MMProductionNormItemsInfo ParentOrderName = new BOSERP.MMProductionNormItemsInfo();
            if (ParentOrderName != null && ParentOrderName.MMProductionNormItemIsComponent)
            {

            }
            else
            {

            }
        }

        private void xr_tbcProductThick_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            decimal cellValue = 0;
            if (decimal.TryParse(tableCell.Text, out cellValue))
            {
                decimal mod = cellValue % 1;
                if (mod > 0 && mod < 1)
                {
                    tableCell.Text = cellValue.ToString();
                }
                else
                {
                    tableCell.Text = cellValue.ToString("N0");
                }
            }
        }

        private void xrLabel2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void xrLabel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void xrTable2_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            BOSERP.MMProductionNormItemsInfo ParentOrderName = new BOSERP.MMProductionNormItemsInfo();
            try
            {
                ParentOrderName = (BOSERP.MMProductionNormItemsInfo)SemiProduct.GetCurrentRow();
                if (ParentOrderName != null && string.IsNullOrEmpty(ParentOrderName.MMProductionNormItemParentNo) && ParentOrderName.MMProductionNormItemParentID == 0)
                {
                    xr_tbcRecord.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xr_tbcProductName.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xr_tbcProductWoodType.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xr_tbcAttribute1.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xr_tbcProductDesc.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xr_tbcDescriptionRate.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xr_tbcQuantity.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xr_tblProductWidth.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xr_tbcProductLenght.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xrTbcBlocks.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    xrTbcMDFBlocks.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);

                    xr_tbcProductMaterialDepreciationRate.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xrTbcPaintA.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xrTbcPaintB.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xrTbcTotalWoodConsumable.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                }
                else
                {
                    xr_tbcRecord.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xr_tbcProductName.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xr_tbcProductWoodType.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xr_tbcAttribute1.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xr_tbcProductDesc.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xr_tbcDescriptionRate.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xr_tbcQuantity.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xr_tblProductWidth.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xr_tbcProductLenght.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xrTbcBlocks.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    xrTbcMDFBlocks.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);

                    xr_tbcProductMaterialDepreciationRate.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    //xrTbcPaintA.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    //xrTbcPaintB.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    //xrTbcTotalWoodConsumable.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                }
            }
            catch (Exception)
            { }
        }
    }
}
