using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_BatchProductSemiProduct : BaseReport
    {
        public RP_BatchProductSemiProduct()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }


        private void xrTable7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            MMBatchProductItemsInfo item = (MMBatchProductItemsInfo)GetCurrentRow();
            if (item != null )
            {
                xrtbcBTPNo.Font = new Font(xrtbcBTPNo.Font.Name, 8, FontStyle.Bold);
                xrtbcBTPNo.ForeColor = Color.DarkRed;
                xrtbcBTPNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0);
                //Ten
                xrtbcDesc.Font = new Font(xrtbcDesc.Font.Name, 8, FontStyle.Bold);
                xrtbcDesc.ForeColor = Color.DarkRed;

            }
            else
            {
                xrtbcBTPNo.Font = new Font(xrtbcBTPNo.Font.Name, 8, FontStyle.Regular);
                xrtbcBTPNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0);
                //ten
                xrtbcDesc.Font = new Font(xrtbcDesc.Font.Name, 8, FontStyle.Regular);

                xrtbcSTT.Font = new Font(xrtbcSTT.Font.Name, 8, FontStyle.Bold);
                xrtbcSTT.ForeColor = Color.Black;

            }
        }

        private void xrtbcBTPNo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            List<MMBatchProductItemsInfo> list = (List<MMBatchProductItemsInfo>)this.MMBatchProductItems.DataSource;
            MMBatchProductItemsInfo BPitem = list.FirstOrDefault();
            if (BPitem != null)
            {
                MMBatchProductProductionNormItemsInfo item = BPitem.MMBatchProductProductionNormItemsSemiProductList.FirstOrDefault(a => a.MMBatchProductProductionNormItemNo == xrtbcBTPNo.Value);
                if (item != null && item.TheNumberOfChild > 0)
                {
                    //Mã
                    xrtbcBTPNo.Font = new Font(xrtbcBTPNo.Font.Name, 8, FontStyle.Bold);
                    xrtbcBTPNo.ForeColor = Color.DarkRed;
                    xrtbcBTPNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0);
                    //Ten
                    xrtbcDesc.Font = new Font(xrtbcDesc.Font.Name, 8, FontStyle.Bold);
                    xrtbcDesc.ForeColor = Color.DarkRed;

                    //xrtbcFJ
                    xrtbcFJ.Font = new Font(xrtbcBTPNo.Font.Name, 8, FontStyle.Bold);
                    xrtbcFJ.ForeColor = Color.DarkRed;

                    //xrtbcFJ
                    xrtbcRemark.Font = new Font(xrtbcBTPNo.Font.Name, 8, FontStyle.Bold);
                    xrtbcRemark.ForeColor = Color.DarkRed;

                    //xrTableCell28
                    xrTableCell28.Font = new Font(xrtbcBTPNo.Font.Name, 8, FontStyle.Bold);
                    xrTableCell28.ForeColor = Color.DarkRed;

                    //xrtbcSTT.Font = new Font(xrtbcSTT.Font.Name, 8, FontStyle.Bold);
                    //xrtbcSTT.ForeColor = Color.DarkRed;
                }
                else if(item != null)
                {
                    //no
                    xrtbcBTPNo.Font = new Font(xrtbcBTPNo.Font.Name, 8, FontStyle.Regular);
                    xrtbcBTPNo.ForeColor = Color.Black;

                    xrtbcDesc.Font = new Font(xrtbcBTPNo.Font.Name, 8, FontStyle.Regular);
                    xrtbcDesc.ForeColor = Color.Black;

                    //xrtbcFJ
                    xrtbcFJ.Font = new Font(xrtbcBTPNo.Font.Name, 8, FontStyle.Regular);
                    xrtbcFJ.ForeColor = Color.Black;

                    //xrtbcFJ
                    xrtbcRemark.Font = new Font(xrtbcBTPNo.Font.Name, 8, FontStyle.Regular);
                    xrtbcRemark.ForeColor = Color.Black;

                    //xrtbcFJ
                    xrTableCell28.Font = new Font(xrtbcBTPNo.Font.Name, 8, FontStyle.Regular);
                    xrTableCell28.ForeColor = Color.Black;

                    //xrtbcSTT.Font = new Font(xrtbcSTT.Font.Name, 8, FontStyle.Regular);
                    //xrtbcSTT.ForeColor = Color.Black;
                }
            }
           
        }

        private void xrTableCell28_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell28.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell28.Text = string.Empty;
        }

        private void xrtbcDaiTP_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrtbcDaiTP.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrtbcDaiTP.Text = string.Empty;
        }

        private void xrtbcRongTp_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrtbcRongTp.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrtbcRongTp.Text = string.Empty;
        }
        public void AddDynamicColumn()
        {
            List<MMBatchProductItemsInfo> list = (List<MMBatchProductItemsInfo>)this.MMBatchProductItems.DataSource;
            MMBatchProductItemsInfo BPitem = list.FirstOrDefault();
            if (BPitem != null && BPitem.MMBatchProductItemMeterialList != null)
            {
                foreach (MMBatchProductProductionNormItemsInfo Info in BPitem.MMBatchProductItemMeterialList)
                {
                    //Report header
                    XRTableCell tableCell = new XRTableCell();
                    tableCell.Text = Info.MMBatchProductProductionNormItemMeterialHeigth.ToString("N0");
                    tableCell.WidthF = 70;
                    xrTable3.Rows[0].Cells.AddRange(new XRTableCell[] { tableCell });

                    //Report detail
                    tableCell = new XRTableCell();
                    tableCell.Text = Info.Blocks.ToString("N3");
                    tableCell.WidthF = 70;
                    
                    tableCell.ForeColor = Color.DarkRed;
                    tableCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    xrTableRow4.Cells.AddRange(new XRTableCell[] { tableCell });
                }

            }

            //Add column inventory stock total quantity
            //Report header
            XRTableCell cell = new XRTableCell();
            cell.Text = "Total";
            cell.ForeColor = Color.DarkRed;
            cell.WidthF = 70;
            xrTable3.Rows[0].Cells.AddRange(new XRTableCell[] { cell });

            //Report detail
            cell = new XRTableCell();
            if (BPitem != null && BPitem.MMBatchProductItemMeterialList != null)
                cell.Text = BPitem.MMBatchProductItemMeterialList.Sum(b => b.Blocks).ToString("N3");
            cell.Multiline = true;
            cell.WidthF = 70;
            cell.ForeColor = Color.DarkRed;
            
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableRow4.Cells.AddRange(new XRTableCell[] { cell });
        }

        private void xrTableCell29_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell29.Text.ToString(), out text);
            decimal so = Math.Round(text, 4);
            if (so == 0)
                xrTableCell29.Text = string.Empty;
        }

        private void xrtbcSTT_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //List<MMBatchProductItemsInfo> list = (List<MMBatchProductItemsInfo>)this.MMBatchProductItems.DataSource;
            //MMBatchProductItemsInfo BPitem = list.FirstOrDefault();
            //if (BPitem != null)
            //{
            //    MMBatchProductProductionNormItemsInfo item = BPitem.MMBatchProductProductionNormItemsSemiProductList.FirstOrDefault(a => a.MMBatchProductProductionNormItemNo == xrtbcBTPNo.Value);
            //    if (item != null && item.TheNumberOfChild > 0)
            //    {
            //        xrtbcSTT.Font = new Font(xrtbcSTT.Font.Name, 8, FontStyle.Bold);
            //        xrtbcSTT.ForeColor = Color.DarkRed;
            //    }
            //    else if (item != null)
            //    {
            //        //STT
            //        //xrtbcSTT.Value = item.STT.ToString();
            //        xrtbcSTT.Font = new Font(xrtbcSTT.Font.Name, 8, FontStyle.Regular);
            //        xrtbcSTT.ForeColor = Color.Black;
                  
            //    }
            //}
        }

        private void xrTableCell30_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell30.Text.ToString(), out text);
            decimal so = Math.Round(text, 4);
            if (so == 0)
                xrTableCell30.Text = string.Empty;
        }

        private void xrTableCell25_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            List<MMBatchProductItemsInfo> list = (List<MMBatchProductItemsInfo>)this.MMBatchProductItems.DataSource;
            MMBatchProductItemsInfo BPitem = list.FirstOrDefault();
            if (BPitem != null)
            {
                MMBatchProductProductionNormItemsInfo item = BPitem.MMBatchProductProductionNormItemsSemiProductList.FirstOrDefault(a => a.MMBatchProductProductionNormItemNo == xrtbcBTPNo.Value);
                if (item != null)
                {
                    if (item.MMBatchProductProductionNormItemProductAttribute.ToLower().Contains("Lọng".ToLower()))
                    {
                        xrTableCell25.BackColor = Color.LightYellow;
                    }
                    else if (item.MMBatchProductProductionNormItemProductAttribute.ToLower().Contains("Chẻ xéo".ToLower()))
                    {
                        xrTableCell25.BackColor = Color.YellowGreen;
                    }
                    else if (item.MMBatchProductProductionNormItemProductAttribute.ToLower().Contains("Tuốt".ToLower()))
                    {
                        xrTableCell25.BackColor = Color.DarkSlateBlue;
                    }
                    else
                    {
                        xrTableCell25.BackColor = Color.White;
                    }
                }
            }
        }
    }
}
