using BOSERP;
using DevExpress.XtraReports.UI;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSReport
{
    public partial class RPProductionNormSemiProductM2HP : BaseReport
    {
        public decimal ProductionNormItemTotalQty = 0;
        #region Contructor
        public RPProductionNormSemiProductM2HP(decimal productionNormItemTotalQty)
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

        public void AddDynamicColumn()
        {
            System.Linq.IOrderedEnumerable<MMProductionNormItemsInfo> list = (System.Linq.IOrderedEnumerable<MMProductionNormItemsInfo>)this.bsSemiProduct.DataSource;
            if (list != null)
            {
                List<MMProductionNormItemsInfo> lstPNI = new List<MMProductionNormItemsInfo>();
                foreach (MMProductionNormItemsInfo Info in list)
                {
                    if (Info != null && Info.MMProductionNormItemParentID == 0)
                    {
                        Info.SumMMProductionNormItemMDFBlocks = Info.MMProductionNormItemMDFBlocks;
                        Info.SumMMProductionNormItemWoodBlocks = Info.MMProductionNormItemWoodBlocks;
                    }    
                    if (lstPNI.Count == 0 && !String.IsNullOrEmpty(Info.ICProductAttributeWoodTypeName))
                    {
                        MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                        objProductionNormItemsInfo.ICProductAttributeWoodTypeName = Info.ICProductAttributeWoodTypeName;
                        objProductionNormItemsInfo.MMProductionNormItemWoodBlocks = Info.MMProductionNormItemWoodBlocks;
                        lstPNI.Add(objProductionNormItemsInfo);
                    }
                    else if (lstPNI.Where(o => o.ICProductAttributeWoodTypeName == Info.ICProductAttributeWoodTypeName).Any())
                    {
                        MMProductionNormItemsInfo objProductionNormItemsInfo = (MMProductionNormItemsInfo)lstPNI.FirstOrDefault(o => o.ICProductAttributeWoodTypeName == Info.ICProductAttributeWoodTypeName);
                        objProductionNormItemsInfo.MMProductionNormItemWoodBlocks += Info.MMProductionNormItemWoodBlocks;
                    }
                    else if (!String.IsNullOrEmpty(Info.ICProductAttributeWoodTypeName))
                    {
                        MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                        objProductionNormItemsInfo.ICProductAttributeWoodTypeName = Info.ICProductAttributeWoodTypeName;
                        objProductionNormItemsInfo.MMProductionNormItemWoodBlocks = Info.MMProductionNormItemWoodBlocks;
                        lstPNI.Add(objProductionNormItemsInfo);
                    }    
                }

                foreach (MMProductionNormItemsInfo Info in lstPNI)
                {
                    XRTableCell tableCell = new XRTableCell();
                    tableCell.Text = Info.ICProductAttributeWoodTypeName;
                    tableCell.WidthF = 130;
                    tableCell.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular);
                    tableCell.ForeColor = System.Drawing.Color.Black;
                    xrTable5.Rows[0].WidthF = 130;
                    xrTable5.Rows[0].Cells.AddRange(new XRTableCell[] { tableCell });
                    xrTable5.Rows[0].WidthF = 130;

                    tableCell = new XRTableCell();
                    tableCell.Text = Info.MMProductionNormItemWoodBlocks.ToString("N4");
                    tableCell.WidthF = 130;
                    tableCell.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular);
                    tableCell.ForeColor = System.Drawing.Color.Black;

                    tableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    xrTableRow5.WidthF = 130;
                    xrTableRow5.Cells.AddRange(new XRTableCell[] { tableCell });
                    xrTableRow5.WidthF = 130;
                }
                xrTableCell19.Text = "Loại nguyên liệu";
                xrTableCell18.Text = "Tổng m3 tinh";
            }

            //Add column inventory stock total quantity
            //Report header
            //XRTableCell cell = new XRTableCell();
            //cell.Text = "Total";
            //cell.ForeColor = Color.DarkRed;
            //cell.WidthF = 70;
            //xrTable3.Rows[0].Cells.AddRange(new XRTableCell[] { cell });

            ////Report detail
            //cell = new XRTableCell();
            //if (BPitem != null && BPitem.MMBatchProductItemMeterialList != null)
            //    cell.Text = BPitem.MMBatchProductItemMeterialList.Sum(b => b.Blocks).ToString("N3");
            //cell.Multiline = true;
            //cell.WidthF = 70;
            //cell.ForeColor = Color.DarkRed;

            //cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            //xrTableRow4.Cells.AddRange(new XRTableCell[] { cell });
        }

        private void xr_tbcRecord_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            BOSERP.MMProductionNormItemsInfo ParentOrderName = new BOSERP.MMProductionNormItemsInfo();
            try 
            {
                ParentOrderName = (BOSERP.MMProductionNormItemsInfo)SemiProduct.GetCurrentRow();
                if (ParentOrderName != null && string.IsNullOrEmpty(ParentOrderName.MMProductionNormItemParentNo) && ParentOrderName.MMProductionNormItemParentID == 0)
                {
                    //xr_tbcRecord.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xr_tbcProductName.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xr_tbcProductWoodType.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xr_tbcAttribute1.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xr_tbcProductDesc.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xr_tbcDescriptionRate.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xr_tbcQuantity.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xr_tbcProductThick.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xr_tblProductWidth.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xr_tbcProductLenght.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xr_tblProductJouDesc.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xrTbcBlocks.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xrTbcMDFBlocks.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xrTbcPaintA.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xrTbcPaintB.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                    //xrTbcTotalWoodConsumable.Font = new Font(xr_tbcRecord.Font.Name, 9, FontStyle.Bold);
                }
                else
                {
                    //xr_tbcRecord.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    //xr_tbcProductName.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    //xr_tbcProductWoodType.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    //xr_tbcAttribute1.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    //xr_tbcProductDesc.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    //xr_tbcDescriptionRate.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    //xr_tbcQuantity.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    //xr_tbcProductThick.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    //xr_tblProductWidth.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    //xr_tbcProductLenght.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    //xr_tblProductJouDesc.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    //xrTbcBlocks.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
                    //xrTbcMDFBlocks.Font = new Font(xr_tbcRecord.Font.Name, 8, FontStyle.Regular);
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
    }
}
