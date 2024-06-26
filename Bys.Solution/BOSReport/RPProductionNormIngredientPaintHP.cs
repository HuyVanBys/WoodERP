using BOSERP;
using DevExpress.XtraReports.UI;
using System.Drawing;
using System.Windows.Forms;


namespace BOSReport
{
    public partial class RPProductionNormIngredientPaintHP : BaseReport
    {
        public decimal ProductionNormItemTotalQty = 0;
        #region Contructor
        public RPProductionNormIngredientPaintHP(decimal productionNormItemTotalQty)
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
        }
        private void xrTbcSumPaintA_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //XRTableCell tableCell = (XRTableCell)sender;
            //SetTextOfTypedecimalTableCell(tableCell);
        }
        private void xrTbcSumBlocks_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //XRTableCell tableCell = (XRTableCell)sender;
            //SetTextOfTypedecimalTableCell(tableCell);
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
            if (ParentOrderName != null && string.IsNullOrEmpty(ParentOrderName.MMProductionNormItemParentNo) && ParentOrderName.MMProductionNormItemParentID == 0)
            {

            }
            else
            {

            }
        }

        private void xrSumQty_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
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
            xrLabel2.LocationF = new PointF(0, 0);
        }

        private void xrLabel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrLabel2.Text = string.Empty;
        }
    }
}
