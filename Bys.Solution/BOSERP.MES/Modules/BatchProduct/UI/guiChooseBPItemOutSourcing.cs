using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct
{
    public partial class guiChooseBPItemOutSourcing : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<MMBatchProductItemOutSourcingsInfo> SelectedObjects { get; set; }

        public List<MMBatchProductItemOutSourcingsInfo> BatchProductItemOutSourcingsList { get; set; }

        #endregion

        public guiChooseBPItemOutSourcing(List<MMBatchProductItemOutSourcingsInfo> itemOutSourcingsList)
        {
            InitializeComponent();
            BatchProductItemOutSourcingsList = itemOutSourcingsList;
        }

        private void guiChooseBPItemOutSourcing_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SelectedObjects = new List<MMBatchProductItemOutSourcingsInfo>();
            InitBindingDatasource();
            GridView gridView = (GridView)fld_dgcMMBPProductionNormItemsGridControl.MainView;
            GridControlHelper = new GridControlHelper(gridView);
            ICStocksController objStocksController = new ICStocksController();
            List<ICStocksInfo> stocks = objStocksController.GetStockPermissionByUserGroupID(BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            fld_cmbStocks.Properties.DataSource = stocks;
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

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<MMBatchProductItemOutSourcingsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SelectedObjects.Select(o => o.FK_MMBatchProductID).Distinct().Count() != 1)
            {
                MessageBox.Show("TP/BTP đã chọn không cùng Lệnh sản xuất. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!((BatchProductModule)Module).IsValidOutSourcingQty(SelectedObjects))
                return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitBindingDatasource()
        {
            List<int> productIds = BatchProductItemOutSourcingsList.Select(o => o.FK_ICProductID).Distinct().ToList();
            ICTransactionsController objTransactionsController = new ICTransactionsController();
            List<ICTransactionsInfo> inventoryStocks = objTransactionsController.GetInventoryStockListByProductRef(productIds);
            ICTransactionsInfo objTransactionsInfo = new ICTransactionsInfo();
            decimal availableQty = 0;
            BatchProductItemOutSourcingsList.ForEach(o =>
            {
                objTransactionsInfo = inventoryStocks.Where(iv => iv.FK_ICProductID == o.FK_ICProductID && iv.FK_MMBatchProductID != o.FK_MMBatchProductID).FirstOrDefault();
                if (objTransactionsInfo == null)
                    objTransactionsInfo = new ICTransactionsInfo();

                availableQty = objTransactionsInfo.ICInventoryStockQuantity - objTransactionsInfo.ICInventoryStockAllocationPlanQuantity;
                if (availableQty < 0)
                    availableQty = 0;

                o.ICInventoryStockQty = availableQty;
                objTransactionsInfo.ICInventoryStockAllocationPlanQuantity += o.MMBatchProductItemOutSourcingProductQty;
            });
            fld_dgcMMBPProductionNormItemsGridControl.InvalidateDataSource(BatchProductItemOutSourcingsList);
            GridView gridView = (GridView)fld_dgcMMBPProductionNormItemsGridControl.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_btnSearchs_Click(object sender, EventArgs e)
        {
            
        }

        public void SearchData(String keyWord, List<MMBatchProductItemOutSourcingsInfo> inventoryStocksList)
        {
            GridView gridView = (GridView)fld_dgcMMBPProductionNormItemsGridControl.MainView;
            if (!String.IsNullOrEmpty(keyWord))
            {
                List<GridColumn> lstColVisible = new List<GridColumn>();
                for (int i = 0; i < gridView.Columns.Count; i++)
                {
                    if (gridView.Columns[i].VisibleIndex >= 0 || gridView.Columns[i].GroupIndex >= 0)
                    {
                        lstColVisible.Add(gridView.Columns[i]);
                    }
                }
                BOSDbUtil dbUtil = new BOSDbUtil();
                List<MMBatchProductItemOutSourcingsInfo> bindingList = new List<MMBatchProductItemOutSourcingsInfo>();
                for (int i = 0; i < inventoryStocksList.Count; i++)
                {
                    MMBatchProductItemOutSourcingsInfo obj = inventoryStocksList[i];
                    bool isExist = false;
                    foreach (GridColumn column in lstColVisible)
                    {
                        int rowHandle = gridView.GetRowHandle(i);
                        string value = gridView.GetRowCellDisplayText(rowHandle, column);
                        isExist = IsExistKeyWord(value, keyWord);
                        if (isExist)
                            break;
                    }
                    if (isExist)
                    {
                        bindingList.Add(obj);
                    }
                }
                fld_dgcMMBPProductionNormItemsGridControl.DataSource = bindingList;
                fld_dgcMMBPProductionNormItemsGridControl.RefreshDataSource();
            }
            else
            {
                fld_dgcMMBPProductionNormItemsGridControl.DataSource = inventoryStocksList;
                fld_dgcMMBPProductionNormItemsGridControl.RefreshDataSource();
            }
        }
        public bool IsExistKeyWord(String value, String keyWord)
        {
            value = value.ToLower();
            keyWord = keyWord.ToLower();
            String[] arrElement = keyWord.Split(new char[] { ' ' });
            bool isExist = false;
            foreach (String element in arrElement)
            {
                if (value.Contains(element))
                {
                    isExist = true;
                }
            }

            if (!isExist)
            {
                value = BOSUtil.ConvertUnicodeStringToUnSign(value);
                foreach (String element in arrElement)
                {
                    if (value.Contains(element))
                    {
                        isExist = true;
                    }
                }
            }
            return isExist;
        }

        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            string[] stockIDs = fld_cmbStocks.EditValue.ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> stockIDList = stockIDs.Select(o => int.Parse(o)).ToList();
            List<int> productIds = BatchProductItemOutSourcingsList.Select(o => o.FK_ICProductID).Distinct().ToList();
            ICTransactionsController objTransactionsController = new ICTransactionsController();
            List<ICTransactionsInfo> inventoryStocks = new List<ICTransactionsInfo>();
            if (stockIDs.Count() > 0)
                inventoryStocks = objTransactionsController.GetInventoryStockListBySomeCreteria(productIds, stockIDList);
            else inventoryStocks = objTransactionsController.GetInventoryStockListByProductRef(productIds);
            ICTransactionsInfo objTransactionsInfo = new ICTransactionsInfo();
            decimal availableQty = 0;
            BatchProductItemOutSourcingsList.ForEach(o =>
            {
                objTransactionsInfo = inventoryStocks.Where(iv => iv.FK_ICProductID == o.FK_ICProductID && iv.FK_MMBatchProductID != o.FK_MMBatchProductID).FirstOrDefault();
                if (objTransactionsInfo == null)
                    objTransactionsInfo = new ICTransactionsInfo();

                availableQty = objTransactionsInfo.ICInventoryStockQuantity - objTransactionsInfo.ICInventoryStockAllocationPlanQuantity;
                if (availableQty < 0)
                    availableQty = 0;

                o.ICInventoryStockQty = availableQty;
                objTransactionsInfo.ICInventoryStockAllocationPlanQuantity += o.MMBatchProductItemOutSourcingProductQty;
            });
            fld_dgcMMBPProductionNormItemsGridControl.InvalidateDataSource(BatchProductItemOutSourcingsList);
            GridView gridView = (GridView)fld_dgcMMBPProductionNormItemsGridControl.MainView;
            gridView.ExpandAllGroups();
        }
    }
}