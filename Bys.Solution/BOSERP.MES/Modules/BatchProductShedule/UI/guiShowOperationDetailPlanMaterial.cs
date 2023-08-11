using BOSCommon;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProductShedule
{
    public partial class guiShowOperationDetailPlanMaterial : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<MMOperationDetailPlanItemChildsInfo> SelectedObjects { get; set; }

        public List<MMOperationDetailPlanItemChildsInfo> PlanItemChildList { get; set; }

        public int BatchProductID { get; set; }

        public int ICProductID { get; set; }

        public int BatchProductItemID { get; set; }

        public int BPPNItemID { get; set; }

        public DateTime BatchProductDate { get; set; }

        public bool IsMultiSelect = false;

        public string OperationDetailPlanType { get; set; }
        #endregion

        public guiShowOperationDetailPlanMaterial(int batchProductID, int batchProductItemID, int bpPNItemID, int productID, DateTime batchProductDate)
        {
            InitializeComponent();
            BatchProductID = batchProductID;
            BatchProductItemID = batchProductItemID;
            BPPNItemID = bpPNItemID;
            ICProductID = productID;
            BatchProductDate = batchProductDate;
        }

        private void guiShowOperationDetailPlanMaterial_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SelectedObjects = new List<MMOperationDetailPlanItemChildsInfo>();
            fld_lkeMMBatchProductID.EditValue = BatchProductID;

            fld_lkeICProductForBatchID.Properties.DataSource = GetProductForBatch();
            fld_lkeICProductForBatchID.EditValue = BatchProductItemID;

            fld_lkeFK_ICSemiProductID.Properties.DataSource = GetSemiProductDataSourceForBatch();
            fld_lkeFK_ICSemiProductID.EditValue = BPPNItemID;

            fld_lkeICProductID.EditValue = ICProductID;
            fld_dteFromDate.EditValue = BatchProductDate;

            DateTime toDate = BOSApp.GetCurrentServerDate().AddMonths(1);
            fld_dteToDate.EditValue = toDate;
            MMOperationDetailPlanItemChildsController controller = new MMOperationDetailPlanItemChildsController();
            if (OperationDetailPlanType == AllocationPlanItemGroup.OtherMaterial.ToString()
                    || OperationDetailPlanType == AllocationPlanItemGroup.Material.ToString())
            {
                PlanItemChildList = controller.GetItemChildMaterialForBatchProductShedule(BatchProductID, BatchProductItemID, BPPNItemID, ICProductID, BatchProductDate, toDate);
            }
            else if (OperationDetailPlanType == ProductType.SemiProduct.ToString())
            {
                PlanItemChildList = controller.GetItemChildSemiProductForBatchProductShedule(BatchProductID, BatchProductItemID, BPPNItemID, ICProductID, BatchProductDate, toDate);
            }
            else
            {
                PlanItemChildList = controller.GetItemChildForBatchProductShedule(BatchProductID, BatchProductItemID, BPPNItemID, ICProductID, BatchProductDate, toDate);
            }
            fld_dgcOperationDetailPlanItemChildsGridControl.InvalidateDataSource(PlanItemChildList);
            InitBindingDatasource();
        }

        public void LoadDataSourceControl()
        {
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> productForBatchList = objProductsController.GetProductListByBatchProductID(BatchProductID);
            fld_lkeICProductForBatchID.Properties.DataSource = productForBatchList;
        }
        private void InitBindingDatasource()
        {
            GridView gridView = (GridView)fld_dgcOperationDetailPlanItemChildsGridControl.MainView;
            gridView.ExpandAllGroups();
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

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            int batchProductID = fld_lkeMMBatchProductID.EditValue == null ? 0 : Int32.Parse(fld_lkeMMBatchProductID.EditValue.ToString());
            int batchProductItemID = fld_lkeICProductForBatchID.EditValue == null ? 0 : Int32.Parse(fld_lkeICProductForBatchID.EditValue.ToString());
            int bpPNItemID = fld_lkeFK_ICSemiProductID.EditValue == null ? 0 : Int32.Parse(fld_lkeFK_ICSemiProductID.EditValue.ToString());
            int productID = fld_lkeICProductID.EditValue == null ? 0 : Int32.Parse(fld_lkeICProductID.EditValue.ToString());
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            MMOperationDetailPlanItemChildsController controller = new MMOperationDetailPlanItemChildsController();
            if (OperationDetailPlanType == AllocationPlanItemGroup.OtherMaterial.ToString()
                    || OperationDetailPlanType == AllocationPlanItemGroup.Material.ToString())
            {
                PlanItemChildList = controller.GetItemChildMaterialForBatchProductShedule(BatchProductID, BatchProductItemID, BPPNItemID, ICProductID, BatchProductDate, toDate);
            }
            else if (OperationDetailPlanType == ProductType.SemiProduct.ToString())
            {
                PlanItemChildList = controller.GetItemChildSemiProductForBatchProductShedule(BatchProductID, BatchProductItemID, BPPNItemID, ICProductID, BatchProductDate, toDate);
            }
            else
            {
                PlanItemChildList = controller.GetItemChildForBatchProductShedule(BatchProductID, BatchProductItemID, BPPNItemID, ICProductID, BatchProductDate, toDate);
            }
            fld_dgcOperationDetailPlanItemChildsGridControl.InvalidateDataSource(PlanItemChildList);
            InitBindingDatasource();
        }

        private void Fld_btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Fld_lkeICProductForBatchID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;

            List<MMBatchProductItemsInfo> batchProductItemList = GetProductForBatch();
            lke.Properties.DataSource = batchProductItemList;
        }

        public List<MMBatchProductItemsInfo> GetProductForBatch()
        {
            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            List<MMBatchProductItemsInfo> batchProductItemList = objBatchProductItemsController.GetBPItemForLookupByBatchProductID(BatchProductID);
            batchProductItemList.Insert(0, new MMBatchProductItemsInfo());
            return batchProductItemList;
        }

        private void Fld_lkeFK_ICSemiProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;

            List<MMBatchProductProductionNormItemsInfo> datasoureList = GetSemiProductDataSourceForBatch();
            lke.Properties.DataSource = datasoureList;
        }

        public List<MMBatchProductProductionNormItemsInfo> GetSemiProductDataSourceForBatch()
        {
            MMBatchProductProductionNormItemsController controller = new MMBatchProductProductionNormItemsController();
            List<MMBatchProductProductionNormItemsInfo> datasoureList = controller.GetSemiProductForLookupByBatchProductID(BatchProductID, BatchProductItemID);
            datasoureList.Insert(0, new MMBatchProductProductionNormItemsInfo());
            return datasoureList;
        }


    }
}