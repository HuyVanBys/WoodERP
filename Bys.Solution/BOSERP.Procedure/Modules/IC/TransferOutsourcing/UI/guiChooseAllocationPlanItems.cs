using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferOutsourcing
{
    public partial class guiChooseAllocationPlanItems : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<MMAllocationPlanItemsInfo> SelectedObjects { get; set; }

        public BOSList<MMAllocationPlanItemsInfo> AllocationPlanItemsList { get; set; }

        private int Count = 0;

        public string ACObjectAccessKey { get; set; }

        public string StrAllocationPlanType { get; set; }

        #endregion

        public guiChooseAllocationPlanItems(List<MMAllocationPlanItemsInfo> allocationPlanItemsList, string type)
        {
            InitializeComponent();
            AllocationPlanItemsList = new BOSList<MMAllocationPlanItemsInfo>(TableName.MMAllocationPlanItemsTableName);
            AllocationPlanItemsList.Invalidate(allocationPlanItemsList);
            StrAllocationPlanType = type;

        }
        private void guiChooseAllocationPlanItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcMMAllocationPlanItems.InvalidateDataSource(AllocationPlanItemsList);

            SelectedObjects = new List<MMAllocationPlanItemsInfo>();
            GridView gridView = (GridView)fld_dgcMMAllocationPlanItems.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;

            GridColumn columnGroup = gridView.Columns["FK_MMBatchProductID"];
            if (columnGroup != null)
            {
                columnGroup.Group();
            }
            columnGroup = gridView.Columns["MMProductType"];
            if (columnGroup != null)
            {
                columnGroup.Group();
            }
            gridView.ExpandAllGroups();
            GridControlHelper = new GridControlHelper(gridView);
            BOSDbUtil bosDbUtil = new BOSDbUtil();

            fld_dteFromDate.EditValue = BOSApp.GetCurrentServerDate().AddDays(-7);
            fld_dteToDate.EditValue = BOSApp.GetCurrentServerDate();
            fld_lkeFK_ACObjectID.EditValue = ACObjectAccessKey;
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

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<MMAllocationPlanItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Count = SelectedObjects.Select(o => o.FK_MMBatchProductID).Distinct().Count();
            if (Count > 1)
            {
                MessageBox.Show(TransferOutsourcingLocalizedResources.DuplicateBatchProductErrorMessages, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnFindMaterial_Click(object sender, EventArgs e)
        {
            string strControlValue = string.Empty;
            int batchProductID = 0;
            strControlValue = fld_lkeFK_MMBatchProductID.EditValue == null ? "0" : fld_lkeFK_MMBatchProductID.EditValue.ToString();
            Int32.TryParse(strControlValue, out batchProductID);

            int operationID = 0;
            strControlValue = fld_lkeFK_MMOperationID.EditValue == null ? "0" : fld_lkeFK_MMOperationID.EditValue.ToString();
            Int32.TryParse(strControlValue, out operationID);

            strControlValue = fld_lkeFK_ACObjectID.EditValue == null ? string.Empty : fld_lkeFK_ACObjectID.EditValue.ToString();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(strControlValue);

            int saleOrderID = 0;
            strControlValue = fld_lkeFK_ARSaleOrderID.EditValue == null ? "0" : fld_lkeFK_ARSaleOrderID.EditValue.ToString();
            Int32.TryParse(strControlValue, out saleOrderID);

            DateTime? fromDate = (DateTime?)fld_dteFromDate.EditValue;
            DateTime? toDate = (DateTime?)fld_dteToDate.EditValue;

            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            List<MMAllocationPlanItemsInfo> allocationPlanItemList = objAllocationPlanItemsController.GetAllocationPlanItemsForTransferOutsourcing(batchProductID
                                                                                                                                                   , operationID
                                                                                                                                                   , saleOrderID
                                                                                                                                                   , objObjectsInfo.ACObjectID
                                                                                                                                                   , objObjectsInfo.ACObjectType
                                                                                                                                                   , StrAllocationPlanType
                                                                                                                                                   , fromDate
                                                                                                                                                   , toDate);

            AllocationPlanItemsList.Invalidate(allocationPlanItemList);
            fld_dgcMMAllocationPlanItems.InvalidateDataSource(AllocationPlanItemsList);
            GridView gridView = (GridView)fld_dgcMMAllocationPlanItems.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_lkeFK_MMBatchProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            List<MMBatchProductsInfo> batchProductList = objBatchProductsController.GetObjectForLookupEditTransferOutsourcing();
            if (batchProductList != null)
                batchProductList.Insert(0, new MMBatchProductsInfo());
            lke.Properties.DataSource = batchProductList;
        }

        private void fld_lkeFK_MMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;
            if (e.Value == null || (e.Value != null && e.Value == lke.OldEditValue))
                return;
            int objectID = 0;
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            Int32.TryParse(e.Value.ToString(), out objectID);
            lke.EditValue = e.Value;
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)objBatchProductsController.GetObjectByID(objectID);
            fld_lkeFK_ARSaleOrderID.EditValue = objBatchProductsInfo == null ? 0 : objBatchProductsInfo.FK_ARSaleOrderID;
            fld_lkeFK_ACObjectID.EditValue = objBatchProductsInfo == null ? "" : string.Format("{0};{1}", objBatchProductsInfo.FK_ACObjectID, objBatchProductsInfo.MMObjectType);
        }
    }
}
