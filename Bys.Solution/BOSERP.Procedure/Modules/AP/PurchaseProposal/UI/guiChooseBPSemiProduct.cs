using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseProposal
{
    public partial class guiChooseBPSemiProduct : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<MMBatchProductItemOutSourcingsInfo> SelectedObjects { get; set; }

        public List<MMBatchProductItemOutSourcingsInfo> BatchProductItemOutSourcingsList { get; set; }

        #endregion

        public guiChooseBPSemiProduct()
        {
            InitializeComponent();
        }

        private void guiChooseBPSemiProduct_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SelectedObjects = new List<MMBatchProductItemOutSourcingsInfo>();
            BatchProductItemOutSourcingsList = new List<MMBatchProductItemOutSourcingsInfo>();
            InitBindingDatasource();
            GridView gridView = (GridView)fld_dgcMMBPProductionNormItemsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            GridControlHelper = new GridControlHelper(gridView);
            DateTime today = BOSApp.GetCurrentServerDate();
            fld_dteFromDate.DateTime = today;
            fld_dteToDate.DateTime = today.AddMonths(1);
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
                MessageBox.Show("Các sản phẩm đã chọn không cùng Lệnh sản xuất. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitBindingDatasource()
        {
            fld_dgcMMBPProductionNormItemsGridControl.InvalidateDataSource(BatchProductItemOutSourcingsList);
            GridView gridView = (GridView)fld_dgcMMBPProductionNormItemsGridControl.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_btnSearchs_Click(object sender, EventArgs e)
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            int batchProductID = fld_lkeMMBatchProductID.EditValue == null ? 0 : Int32.Parse(fld_lkeMMBatchProductID.EditValue.ToString());
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            MMBatchProductItemOutSourcingsController controller = new MMBatchProductItemOutSourcingsController();
            List<MMBatchProductItemOutSourcingsInfo> bpProductionNormsList = controller.GetItemForPurchaseProposal(batchProductID, fromDate, toDate, BOSApp.CurrentUsersInfo.ADUserID, ModuleName.BatchProduct, ADDataViewPermissionType.Module, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            //bpProductionNormsList.RemoveAll(o => entity.PurchasePlanItemList.Select(o1 => o1.FK_MMBatchProductProductionNormItemID).Contains(o.MMBatchProductProductionNormItemID));
            fld_dgcMMBPProductionNormItemsGridControl.DataSource = bpProductionNormsList;
            fld_dgcMMBPProductionNormItemsGridControl.RefreshDataSource();
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
    }
}