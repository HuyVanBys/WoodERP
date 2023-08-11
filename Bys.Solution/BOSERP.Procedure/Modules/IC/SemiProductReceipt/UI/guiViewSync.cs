using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SemiProductReceipt
{
    public partial class guiViewSync : BOSERPScreen
    {
        public int NormID { get; set; }
        public int ReceiptItemID { get; set; }
        public int OperationID { get; set; }
        public decimal PlanQty { get; set; }
        public decimal SyncPerCent { get; set; }
        public guiViewSync()
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

        private void guiViewSync_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            MMOperationDetailPlanCapacityItemsController ctrol = new MMOperationDetailPlanCapacityItemsController();
            List<MMOperationDetailPlanCapacityItemsInfo> foundSyncList = ctrol.GetReceiptDetailAvailableSyncData(NormID, OperationID, ReceiptItemID);
            SyncPerCent = 0;
            if (foundSyncList != null && foundSyncList.Any())
            {
                decimal minSync = foundSyncList.Max(o => o.MMOperationDetailPlanCapacityItemSynchedQty /
                (o.MMBatchProductProductionNormItemQuantity > 0 ? o.MMBatchProductProductionNormItemQuantity : o.MMOperationDetailPlanCapacityItemTotalProductQty));

                SyncPerCent = 1;
                foundSyncList.ForEach(o =>
                {
                    o.MMOperationDetailPlanCapacityItemPlanProductQty = PlanQty;
                    o.MMOperationDetailPlanCapacityItemSynchedQty =
                        (o.MMOperationDetailPlanCapacityItemSynchedQty /
                        (o.MMBatchProductProductionNormItemQuantity > 0 ? o.MMBatchProductProductionNormItemQuantity : o.MMOperationDetailPlanCapacityItemTotalProductQty))
                        * o.MMOperationDetailPlanCapacityItemTotalProductQty;
                    o.MMOperationDetailPlanCapacityItemCanSync = o.MMOperationDetailPlanCapacityItemCanReceipt - o.MMOperationDetailPlanCapacityItemSynchedQty;
                    if (string.IsNullOrEmpty(o.MMOperationName))
                    {
                        o.MMOperationDetailPlanCapacityItemCanSync = o.MMBatchProductProductionNormItemQuantity - o.MMOperationDetailPlanCapacityItemSynchedQty;
                        if (o.MMOperationDetailPlanCapacityItemCanSync / o.MMOperationDetailPlanCapacityItemTotalProductQty < SyncPerCent)
                            SyncPerCent = (o.MMOperationDetailPlanCapacityItemCanSync / o.MMOperationDetailPlanCapacityItemTotalProductQty);
                    }
                    else if (o.MMOperationDetailPlanCapacityItemCanSync / o.MMOperationDetailPlanCapacityItemTotalProductQty < SyncPerCent && !string.IsNullOrEmpty(o.MMOperationName))
                        SyncPerCent = (o.MMOperationDetailPlanCapacityItemCanSync / o.MMOperationDetailPlanCapacityItemTotalProductQty);
                });
            }
            fld_dgcViewSyncInfoGridControls.DataSource = foundSyncList;
            fld_dgcViewSyncInfoGridControls.RefreshDataSource();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
