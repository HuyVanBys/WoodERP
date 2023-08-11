using BOSERP;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPProductionNormForSemiProduct : BaseReport
    {
        public decimal ProductionNormItemTotalQty = 0;
        #region Contructor
        public RPProductionNormForSemiProduct()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
            //ProductionNormItemTotalQty = productionNormItemTotalQty;
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
        }
        #endregion

        private void xrTableCell64_AfterPrint(object sender, EventArgs e)
        {
            //string no = xrtbcBTPNo.Text;
            //if (string.IsNullOrEmpty(no))
            //{
            //    //xrTable7.DeleteRow();
            //}
        }

        private void xrTable7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //List<MMProductionNormItemsInfo> list = (List<MMProductionNormItemsInfo>)this.MMBatchProductItems.DataSource;
            //int stt = 0;
            //Int32.TryParse(xrtbcSTT.Text, out stt);
            //MMProductionNormItemsInfo item = list.FirstOrDefault(a => a.stt == stt);
            //if (item != null)
            //{
            //    if (item.DetailType == "Cum")
            //    {
            //        //STT
            //        xrtbcSTT.Text = "";
            //        xrtbcSTT.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            //        if (item.level == 0)
            //        {
            //            xrtbcSTT.Text = item.STT;
            //            xrtbcSTT.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            //        }                                        
            //        //Mã
            //        xrtbcBTPNo.Font = new Font(xrtbcBTPNo.Font.Name, 9, FontStyle.Bold);
            //        xrtbcBTPNo.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Left;
            //        xrtbcBTPNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5 + (item.level * 5), 0, 0, 0);
            //        //Ten
            //        xrtbcDesc.Font = new Font(xrtbcDesc.Font.Name, 9, FontStyle.Bold);
            //        xrtbcDesc.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Left;
            //        //SL
            //        xrtbcSL.Font = new Font(xrtbcSL.Font.Name, 9, FontStyle.Bold);
            //        xrtbcSL.Text = formatSo(xrtbcSL.Text);
            //        xrtbcSL.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Left;
            //        //Rong NL
            //        xrtbcRongNL.Text = "";
            //        xrtbcRongNL.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Left;
            //        //Day NL
            //        xrtbcDayNL.Text = "";
            //        xrtbcDayNL.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Left;
            //        //Dai NL
            //        xrtbcDaiNL.Text = "";
            //        xrtbcDaiNL.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Left;
            //        //Day TP
            //        xrtbcDayTP.Text = formatSo(xrtbcDayTP.Text);
            //        xrtbcDayTP.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Left;
            //        //Rong TP
            //        xrtbcRongTp.Text = formatSo(xrtbcRongTp.Text);
            //        xrtbcRongTp.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Left;
            //        //Dai TP
            //        xrtbcDaiTP.Text = formatSo(xrtbcDaiTP.Text);
            //        xrtbcDaiTP.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Left;
            //        //LA
            //        xrtbcLA.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Left;
            //        //FJ
            //        xrtbcFJ.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Left;
            //        //remark
            //        xrtbcRemark.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Left;
            //        //store
            //        xrtbcstore.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Left;
            //    }
            //    else
            //    {
            //        xrtbcSTT.Text = "";
            //        //no
            //        xrtbcBTPNo.Font = new Font(xrtbcBTPNo.Font.Name, 9, FontStyle.Regular);
            //        xrtbcBTPNo.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            //        xrtbcBTPNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5 + (item.level * 5), 0, 0, 0);
            //        //ten
            //        xrtbcDesc.Font = new Font(xrtbcDesc.Font.Name, 9, FontStyle.Regular);
            //        xrtbcDesc.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            //        //SL
            //        xrtbcSL.Font = new Font(xrtbcSL.Font.Name, 9, FontStyle.Regular);
            //        formatSo(xrtbcSL.Text);
            //        xrtbcSL.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            //        //Day TP                             
            //        xrtbcDayTP.Text = "";
            //        xrtbcDayTP.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            //        //Rong TP
            //        xrtbcRongTp.Text = "";
            //        xrtbcRongTp.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            //        //Dai TP
            //        xrtbcDaiTP.Text = "";
            //        xrtbcDaiTP.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            //        //Rong NL                    
            //        xrtbcRongNL.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            //        //Day NL                    
            //        xrtbcDayNL.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            //        //Dai NL                    
            //        xrtbcDaiNL.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            //        //LA
            //        xrtbcLA.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            //        //FJ
            //        xrtbcFJ.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            //        //remark
            //        xrtbcRemark.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            //        //store
            //        xrtbcstore.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right;
            //    }
            //    if (stt == list.Count())
            //    {
            //        if (item.DetailType == "Cum")
            //        {
            //            //STT
            //            xrtbcSTT.Borders = DevExpress.XtraPrinting.BorderSide.All;
            //            //no                    
            //            xrtbcBTPNo.Borders = DevExpress.XtraPrinting.BorderSide.All;
            //            //ten                    
            //            xrtbcDesc.Borders = DevExpress.XtraPrinting.BorderSide.All;
            //            //SL                    
            //            xrtbcSL.Borders = DevExpress.XtraPrinting.BorderSide.All;
            //            //Day TP                                                 
            //            xrtbcDayTP.Borders = DevExpress.XtraPrinting.BorderSide.All;
            //            //Rong TP                    
            //            xrtbcRongTp.Borders = DevExpress.XtraPrinting.BorderSide.All;
            //            //Dai TP                   
            //            xrtbcDaiTP.Borders = DevExpress.XtraPrinting.BorderSide.All;
            //            //Rong NL                    
            //            xrtbcRongNL.Borders = DevExpress.XtraPrinting.BorderSide.All;
            //            //Day NL                    
            //            xrtbcDayNL.Borders = DevExpress.XtraPrinting.BorderSide.All;
            //            //Dai NL                    
            //            xrtbcDaiNL.Borders = DevExpress.XtraPrinting.BorderSide.All;
            //            //LA
            //            xrtbcLA.Borders = DevExpress.XtraPrinting.BorderSide.All;
            //            //FJ
            //            xrtbcFJ.Borders = DevExpress.XtraPrinting.BorderSide.All;
            //            //remark
            //            xrtbcRemark.Borders = DevExpress.XtraPrinting.BorderSide.All;
            //            //store
            //            xrtbcstore.Borders = DevExpress.XtraPrinting.BorderSide.All;
            //        }
            //        else
            //        {
            //            //STT
            //            xrtbcSTT.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            //            //no                    
            //            xrtbcBTPNo.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            //            //ten                    
            //            xrtbcDesc.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            //            //SL                    
            //            xrtbcSL.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            //            //Day TP                                                 
            //            xrtbcDayTP.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            //            //Rong TP                    
            //            xrtbcRongTp.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            //            //Dai TP                   
            //            xrtbcDaiTP.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            //            //Rong NL                    
            //            xrtbcRongNL.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            //            //Day NL                    
            //            xrtbcDayNL.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            //            //Dai NL                    
            //            xrtbcDaiNL.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            //            //LA
            //            xrtbcLA.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            //            //FJ
            //            xrtbcFJ.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            //            //remark
            //            xrtbcRemark.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            //            //store
            //            xrtbcstore.Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            //        }
            //    }               
            //}
        }

        private string formatSo(string text)
        {
            decimal a = 0;
            decimal.TryParse(text, out a);
            return a.ToString("n0");
        }

    }
}
