using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP113 : ReportForm
    {


        public RP113()
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

        private void RP113_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);



        }
        string CDPhoiNo = "CD-003";
        string CDSoCheNo = "CD-004";
        string CDTinhCheNo = "CD-005";
        string CDLapRapNo = "CD-084";
        string CDSonNo = "CD-006";
        string CDDongGoiNo = "CD-007";
        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            DateTime dateFrom = fld_dteFromDate.DateTime;
            DateTime dateTo = fld_dteToDate.DateTime;

            int productID = Convert.ToInt32(fld_lkeICProductID.EditValue);

            int batchProductID = Convert.ToInt32(fld_lkeMMBatchProductID.EditValue);


            ADReportsController objReportsController = new ADReportsController();
            List<ICReceiptItemsInfo> receiptItemList = objReportsController.GetReceiptAndShipmentBySomeConditions(productID, batchProductID, 0, dateFrom, dateTo);
            // List<ICReceiptItemsInfo> receiptItemToTimeList = objReportsController.GetReceiptAndShipmentBySomeConditionsToTime(productID, batchProductID, 0,  dateTo);

            //foreach (ICReceiptItemsInfo item in receiptItemList)
            //{
            //    ICReceiptItemsInfo objReceiptItemsInfo = receiptItemToTimeList.FirstOrDefault(t => t.FK_MMBatchProductID == item.FK_MMBatchProductID
            //                                                                                     && t.FK_MMOperationID == item.FK_MMOperationID
            //                                                                                     && t.FK_ICProductID == item.FK_ICProductID
            //                                                                                     && t.ICDocumentType == item.ICDocumentType);
            //    if (objReceiptItemsInfo != null)
            //    {
            //        item.ICReceiptItemWoodQtyToDate = objReceiptItemsInfo.ICReceiptItemWoodQty;
            //    }
            //}

            SetOperationData(receiptItemList);
            BOSProgressBar.Close();
        }

        public void SetOperationData(List<ICReceiptItemsInfo> receiptItemList)
        {
            List<ICReceiptItemsInfo> objReceiptItemPsList = new List<ICReceiptItemsInfo>();
            List<ICReceiptItemsInfo> objReceiptItemSCsList = new List<ICReceiptItemsInfo>();
            List<ICReceiptItemsInfo> objReceiptItemTCsList = new List<ICReceiptItemsInfo>();
            List<ICReceiptItemsInfo> objReceiptItemLRsList = new List<ICReceiptItemsInfo>();
            List<ICReceiptItemsInfo> objReceiptItemSsList = new List<ICReceiptItemsInfo>();
            List<ICReceiptItemsInfo> objReceiptItemDGsList = new List<ICReceiptItemsInfo>();
            // Công đoạn Phôi
            MMOperationsController objOperationsController = new MMOperationsController();

            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDPhoiNo);
            if (objOperationsInfo != null)
            {
                objReceiptItemPsList = receiptItemList.Where(t => t.FK_MMOperationID == objOperationsInfo.MMOperationID).ToList();
            }

            objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDSoCheNo);
            if (objOperationsInfo != null)
            {
                objReceiptItemSCsList = receiptItemList.Where(t => t.FK_MMOperationID == objOperationsInfo.MMOperationID).ToList();
            }

            objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDTinhCheNo);
            if (objOperationsInfo != null)
            {
                objReceiptItemTCsList = receiptItemList.Where(t => t.FK_MMOperationID == objOperationsInfo.MMOperationID).ToList();
            }

            objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDLapRapNo);
            if (objOperationsInfo != null)
            {
                objReceiptItemLRsList = receiptItemList.Where(t => t.FK_MMOperationID == objOperationsInfo.MMOperationID).ToList();
            }

            objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDSonNo);
            if (objOperationsInfo != null)
            {
                objReceiptItemSsList = receiptItemList.Where(t => t.FK_MMOperationID == objOperationsInfo.MMOperationID).ToList();
            }

            objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByNo(CDDongGoiNo);
            if (objOperationsInfo != null)
            {
                objReceiptItemDGsList = receiptItemList.Where(t => t.FK_MMOperationID == objOperationsInfo.MMOperationID).ToList();
            }

            fld_dgcICReceiptItemP.DataSource = objReceiptItemPsList;
            fld_dgcICReceiptItemSC.DataSource = objReceiptItemSCsList;
            fld_dgcICReceiptItemTC.DataSource = objReceiptItemTCsList;
            fld_dgcICReceiptItemLR.DataSource = objReceiptItemLRsList;
            fld_dgcICReceiptItemS.DataSource = objReceiptItemSsList;
            fld_dgcICReceiptItemDG.DataSource = objReceiptItemDGsList;

            fld_dgcICReceiptItemP.RefreshDataSource();
            fld_dgcICReceiptItemSC.RefreshDataSource();
            fld_dgcICReceiptItemTC.RefreshDataSource();
            fld_dgcICReceiptItemLR.RefreshDataSource();
            fld_dgcICReceiptItemS.RefreshDataSource();
            fld_dgcICReceiptItemDG.RefreshDataSource();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
