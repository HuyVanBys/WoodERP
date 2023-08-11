using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP197 : ReportForm
    {
        public RP197()
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

        private void RP196_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = DateTime.Now;
            fld_dteSearchToDate.DateTime = DateTime.Now;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Init data source for report
        /// </summary>
        public void InitDataSource()
        {
            string deliveryPlanType = string.Empty;
            deliveryPlanType = Convert.ToString(fld_lkeARDeliveryPlanType.EditValue);
            string saleOrderSaleAgreement = string.Empty;
            saleOrderSaleAgreement = Convert.ToString(fld_txtARSaleOrderSaleAgreement.EditValue);
            int saleOrderID = Convert.ToInt32(fld_lkeFK_ARSaleOrderID.EditValue);
            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }
            string deliveryPlanStatus = Convert.ToString(fld_lkeARDeliveryPlanStatus.EditValue);
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            int deliveryPlanID = Convert.ToInt32(fld_lkeFK_ARDeliveryPlanID.EditValue);
            ARDeliveryPlanItemsController objDeliveryPlanItemsController = new ARDeliveryPlanItemsController();
            List<ARDeliveryPlanItemsInfo> deliveryPlanItems = new List<ARDeliveryPlanItemsInfo>();
            deliveryPlanItems = objDeliveryPlanItemsController.GetDeliveryPlanItemsForReport197(
                                                                                           deliveryPlanType,
                                                                                           saleOrderID,
                                                                                           objectID,
                                                                                           objectType,
                                                                                           saleOrderSaleAgreement,
                                                                                           dateFrom,
                                                                                           dateTo,
                                                                                           deliveryPlanID,
                                                                                           deliveryPlanStatus);
            fld_dgcRP197DeliveryPlanItems.DataSource = deliveryPlanItems;
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            InitDataSource();
        }
    }
}
