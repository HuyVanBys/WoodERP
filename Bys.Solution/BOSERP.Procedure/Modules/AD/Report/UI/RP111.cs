using BOSLib;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP111 : ReportForm
    {
        private List<ICProductsInfo> equipments;

        public RP111()
        {
            InitializeComponent();
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void RP111_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteToDate.EditValue = BOSUtil.GetMonthEndDate();


        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {

            BOSReport.RP111 report = new BOSReport.RP111();
            InitReportDataSource(report, equipments);
            guiReportPreview viewer = new guiReportPreview(report);
            viewer.Show();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Init data source report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        public void InitReportDataSource(XtraReport report, List<ICProductsInfo> equipments)
        {
            DateTime dateFrom = fld_dteFromDate.DateTime;
            DateTime dateTo = fld_dteToDate.DateTime;
            //int stockID = Convert.ToInt32(fld_lkeICStockID.EditValue);
            int productID = Convert.ToInt32(fld_lkeICProductID.EditValue);
            int accountID = Convert.ToInt32(fld_lkeACAccountID.EditValue);
            int costAccountID = Convert.ToInt32(fld_lkeFK_ACDepreciationCostAccountID.EditValue);
            int productGroupID = Convert.ToInt32(fld_lkeICProductGroupID.EditValue);
            int deparmentID = 8;

            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            //XRLabel dateTime = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            //dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
            //                                                                        ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);

            //}
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ICProductsController objProductsController = new ICProductsController();
            equipments = objProductsController.GetProductForReport(productID, dateFrom, dateTo, accountID, costAccountID, deparmentID, productGroupID);
            //ICShipmentsController objShipmentsController = new ICShipmentsController();
            foreach (ICProductsInfo item in equipments)
            {
                if (item.KhauHaoCuoiKi > item.NguyenGiaCuoiKi)
                    item.KhauHaoCuoiKi = item.NguyenGiaCuoiKi;
                item.DauKiConLai = item.NguyenGiaKhauHao - item.KhauHaoDauKi;
                item.CuoiKiConLai = item.NguyenGiaCuoiKi - item.KhauHaoCuoiKi;
                //if (item.InitNguyenGia == 0)
                //{
                //    //item.NguyenGiaKhauHao = 0;
                //}

                ////TKChinh Add [29/28/2016]

                //int count = objShipmentsController.GetShipmentByEquipmentID(item.ICProductIdentifiedEquipmentID, dateFrom, dateTo);
                //if (count > 0)
                //{
                //    item.NguyenGiaCuoiKi = 0;
                //    item.KhauHaoCuoiKi = 0;
                //}

                if (item.GhiTangTrongKy > 0)
                {
                    item.NguyenGiaKhauHao = 0;
                    item.KhauHaoDauKi = 0;
                    item.DauKiConLai = 0;

                }
                if (item.GhiGiamTrongKy > 0)
                {
                    item.NguyenGiaCuoiKi = 0;
                    item.KhauHaoCuoiKi = 0;
                    item.CuoiKiConLai = 0;
                }

                if (item.KhauHaoDaHet == 1)
                {
                    item.NguyenGiaKhauHao = 0;
                    item.KhauHaoDauKi = 0;
                    item.DauKiConLai = 0;
                }

                if (item.CuoiKiConLai < 0)
                {
                    if (dateTo.Month < 06)
                    {
                        item.NguyenGiaCuoiKi = 0;
                        item.KhauHaoCuoiKi = 0;
                        item.CuoiKiConLai = 0;
                    }
                }
            }
            report.DataSource = equipments;
        }








    }
}
