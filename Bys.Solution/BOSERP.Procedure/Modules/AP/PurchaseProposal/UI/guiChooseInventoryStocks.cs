using BOSCommon;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseProposal
{
    public partial class guiChooseInventoryStocks : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<ICInventoryStocksInfo> SelectedObjects { get; set; }

        public List<ICInventoryStocksInfo> InventoryStockList { get; set; }

        #endregion

        public guiChooseInventoryStocks()
        {
            InitializeComponent();
        }

        private void guiChooseInventoryStocks_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SelectedObjects = new List<ICInventoryStocksInfo>();
            InventoryStockList = new List<ICInventoryStocksInfo>();
            InitBindingDatasource();
            GridView gridView = (GridView)fld_dgcICInventoryStocksGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            GridControlHelper = new GridControlHelper(gridView);
            DateTime toDate = BOSApp.GetCurrentServerDate();
            fld_dteICInventoryStockOrderDate.DateTime = toDate;
            fld_dteICInventoryStockNeedDay.DateTime = toDate.AddDays(7);
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
            SelectedObjects = GridControlHelper.Selection.OfType<ICInventoryStocksInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitBindingDatasource()
        {
            fld_dgcICInventoryStocksGridControl.InvalidateDataSource(InventoryStockList);
            GridView gridView = (GridView)fld_dgcICInventoryStocksGridControl.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_btnSearchs_Click(object sender, EventArgs e)
        {
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            InventoryStockList = objInventoryStocksController.GetInventoryStocksForPurchaseProposal(Convert.ToInt32(fld_lkeICDepartmentID.EditValue)
                                                                                                   , Convert.ToInt32(fld_lkeICProductGroupID.EditValue)
                                                                                                   , Convert.ToInt32(fld_lkeFK_ICProductID.EditValue));
            DateTime orderDate = fld_dteICInventoryStockOrderDate.DateTime;
            DateTime needDate = fld_dteICInventoryStockNeedDay.DateTime;
            InventoryStockList.ForEach(o =>
            {
                o.ICInventoryStockOrderDate = orderDate;
                o.ICInventoryStockNeedDate = needDate;
                o.ICInventoryStockArrivalDate = orderDate.AddDays(o.ICInventoryStockOrderDay);
                o.ICInventoryStockPurchaseStatus = InventoryStockPurchaseStatus.OnTime.ToString();
                if (o.ICInventoryStockNeedDate < o.ICInventoryStockArrivalDate)
                {
                    o.ICInventoryStockPurchaseStatus = InventoryStockPurchaseStatus.Late.ToString();
                }
                if (o.ICInventoryStockCanUserQuantity > o.ICInventoryStockMinQuantity)
                {
                    o.ICInventoryStockPurchaseStatus = InventoryStockPurchaseStatus.EnoughInventory.ToString();
                }
            });
            SearchData(fld_txtSearchKey.Text, InventoryStockList);
        }

        private void fld_dteICInventoryStockOrderDate_Validated(object sender, EventArgs e)
        {
            UpdateInventoryStockList();
        }

        private void fld_dteICInventoryStockNeedDay_Validated(object sender, EventArgs e)
        {
            UpdateInventoryStockList();
        }

        private void UpdateInventoryStockList()
        {
            DateTime orderDate = fld_dteICInventoryStockOrderDate.DateTime;
            DateTime needDate = fld_dteICInventoryStockNeedDay.DateTime;
            InventoryStockList.ForEach(o =>
            {
                o.ICInventoryStockOrderDate = orderDate;
                o.ICInventoryStockNeedDate = needDate;
                o.ICInventoryStockArrivalDate = orderDate.AddDays(o.ICInventoryStockOrderDay);
                o.ICInventoryStockPurchaseStatus = InventoryStockPurchaseStatus.OnTime.ToString();
                if (o.ICInventoryStockNeedDate < o.ICInventoryStockArrivalDate)
                {
                    o.ICInventoryStockPurchaseStatus = InventoryStockPurchaseStatus.Late.ToString();
                }
                if (o.ICInventoryStockCanUserQuantity > o.ICInventoryStockMinQuantity)
                {
                    o.ICInventoryStockPurchaseStatus = InventoryStockPurchaseStatus.EnoughInventory.ToString();
                }
            });
        }
        public void SearchData(String keyWord, List<ICInventoryStocksInfo> inventoryStocksList)
        {
            GridView gridView = (GridView)fld_dgcICInventoryStocksGridControl.MainView;
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
                List<ICInventoryStocksInfo> bindingList = new List<ICInventoryStocksInfo>();
                for (int i = 0; i < inventoryStocksList.Count; i++)
                {
                    ICInventoryStocksInfo obj = inventoryStocksList[i];
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
                fld_dgcICInventoryStocksGridControl.DataSource = bindingList;
                fld_dgcICInventoryStocksGridControl.RefreshDataSource();
            }
            else
            {
                fld_dgcICInventoryStocksGridControl.DataSource = inventoryStocksList;
                fld_dgcICInventoryStocksGridControl.RefreshDataSource();
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
    }
}