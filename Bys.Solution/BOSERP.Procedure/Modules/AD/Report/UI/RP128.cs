using BOSCommon;
using BOSLib;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP128 : ReportForm
    {


        public RP128()
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

        private void RP128_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();

            fld_lkeFK_MMBatchProductID.QueryPopUp += new CancelEventHandler(fld_lkeFK_MMBatchProductID_QueryPopUp);

        }

        void fld_lkeFK_MMBatchProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int customerID = Convert.ToInt32(fld_lkeFK_ARCustomerID.EditValue);

            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            List<MMBatchProductsInfo> objBatchProductList = objBatchProductsController.GetBatchProductByCustomerID(customerID);

            LookUpEdit lke = (LookUpEdit)sender;
            lke.Properties.DataSource = objBatchProductList;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;

            int customerID = Convert.ToInt32(fld_lkeFK_ARCustomerID.EditValue);
            int batchProductID = Convert.ToInt32(fld_lkeFK_MMBatchProductID.EditValue);

            ADReportsController objReportsController = new ADReportsController();
            List<MMAllocationPlansInfo> allocationPlanList = objReportsController.GetAllocationPlanItemByBatchProductIDAndCustomerID(batchProductID, customerID, dateFrom, dateTo);
            fld_dgcRP128MMAllocationPlans.DataSource = allocationPlanList;

        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void GetAllDataDetail(MMAllocationPlansInfo objAllocationPlansInfo)
        {
            MMPurchasePlanItemsController objPurchasePlanItemsController = new MMPurchasePlanItemsController();
            List<MMPurchasePlanItemsInfo> purchasePlanItemWoodList = objPurchasePlanItemsController.GetPurchasePlanItemByBatchProductIDAndType(objAllocationPlansInfo.MMBatchProductID, PurchasePlanType.Material.ToString());
            fld_dgcRP128MMPurchasePlanItemWoods.DataSource = purchasePlanItemWoodList;
            List<MMPurchasePlanItemsInfo> purchasePlanItemHWList = objPurchasePlanItemsController.GetPurchasePlanItemByBatchProductIDAndTypeisHWorPaint(objAllocationPlansInfo.MMBatchProductID, PurchasePlanType.Hardware.ToString());
            fld_dgcRP128MMPurchasePlanItemHWs.DataSource = purchasePlanItemHWList;
            List<MMPurchasePlanItemsInfo> purchasePlanItemPaintList = objPurchasePlanItemsController.GetPurchasePlanItemByBatchProductIDAndTypeisHWorPaint(objAllocationPlansInfo.MMBatchProductID, PurchasePlanType.IngredientPaint.ToString());
            fld_lkeRP128MMPurchasePlanItemPaints.DataSource = purchasePlanItemPaintList;
            List<MMPurchasePlanItemsInfo> purchasePlanItemPLDGList = objPurchasePlanItemsController.GetPurchasePlanItemByBatchProductIDAndTypeisPLDG(objAllocationPlansInfo.MMBatchProductID, PurchasePlanType.IngredientPackaging.ToString());
            fld_lkeRP128MMPurchasePlanItemPLDGs.DataSource = purchasePlanItemPLDGList;
        }

    }
}
