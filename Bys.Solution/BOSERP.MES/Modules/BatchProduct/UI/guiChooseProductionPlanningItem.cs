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

namespace BOSERP.Modules.BatchProduct
{
    public partial class guiChooseProductionPlanningItem : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<ARProductionPlanningItemsInfo> SelectedObjects { get; set; }

        public List<ARProductionPlanningItemsInfo> ProductionPlanningItemList { get; set; }

        #endregion

        public guiChooseProductionPlanningItem()
        {
            InitializeComponent();
            ProductionPlanningItemList = new List<ARProductionPlanningItemsInfo>();
        }

        private void guiChooseProductionPlanningItem_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SelectedObjects = new List<ARProductionPlanningItemsInfo>();
            DateTime toDay = BOSApp.GetCurrentServerDate();
            fld_dteFromDate.EditValue = toDay.AddMonths(-1);
            fld_dteToDate.EditValue = toDay;
            //fld_dgcBatchProposalItemsGridControl.InvalidateDataSource(ProductionPlanningItemList);
            GridView gridView = (GridView)fld_dgcBatchProposalItemsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.OptionsMenu.EnableFooterMenu = false;
            GridControlHelper = new GridControlHelper(gridView);
            InitBindingDatasource();
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
            SelectedObjects = GridControlHelper.Selection.OfType<ARProductionPlanningItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //if (SelectedObjects.Select(o => o.FK_ARProductionPlanningID).Distinct().Count() > 1)
            //{
            //    MessageBox.Show("Các sản phẩm đã chọn không cùng kế hoạch. Vui lòng kiểm tra lại!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}
            if (SelectedObjects.Select(o => o.FK_MMWorkShopID).Distinct().Count() > 1)
            {
                MessageBox.Show("Các sản phẩm đã chọn không cũng xưởng. Vui lòng kiểm tra lại!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitBindingDatasource()
        {
            GridView gridView = (GridView)fld_dgcBatchProposalItemsGridControl.MainView;
            gridView.ExpandAllGroups();
        }


        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            int planingID = fld_lkeFK_ARProductionPlanningID.EditValue == null ? 0 : Int32.Parse(fld_lkeFK_ARProductionPlanningID.EditValue.ToString());
            int saleOrderID = fld_lkeFK_ARSaleOrderID.EditValue == null ? 0 : Int32.Parse(fld_lkeFK_ARSaleOrderID.EditValue.ToString());
            string objectAccessKey = fld_lkeFK_ACObjectID.EditValue == null ? string.Empty : fld_lkeFK_ACObjectID.EditValue.ToString();
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            string keySearch = fld_txtFind.EditValue == null ? string.Empty : fld_txtFind.EditValue.ToString();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            ARProductionPlanningItemsController objProductionPlanningItemsController = new ARProductionPlanningItemsController();
            ProductionPlanningItemList = objProductionPlanningItemsController.GetProductionPlanningItemsForBatchProduct(planingID
                                                                                                                        , saleOrderID
                                                                                                                        , objObjectsInfo.ACObjectID
                                                                                                                        , objObjectsInfo.ACObjectType
                                                                                                                        , fromDate
                                                                                                                        , toDate
                                                                                                                        , BOSApp.CurrentUsersInfo.ADUserID
                                                                                                                        , ModuleName.ProductionPlanning
                                                                                                                        , ADDataViewPermissionType.Module
                                                                                                                        , BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            SearchData(keySearch, ProductionPlanningItemList);
        }

        private void SearchData(String keyWord, List<ARProductionPlanningItemsInfo> purchasePlanItemList)
        {
            fld_dgcBatchProposalItemsGridControl.DataSource = purchasePlanItemList;
            fld_dgcBatchProposalItemsGridControl.RefreshDataSource();
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcBatchProposalItemsGridControl.MainView;
            if (string.IsNullOrEmpty(keyWord))
            {
                gridView.ExpandAllGroups();
                return;
            }
            List<GridColumn> lstColVisible = new List<GridColumn>();
            lstColVisible.Add(gridView.Columns["FK_ARProductionPlanningID"]);
            lstColVisible.Add(gridView.Columns["FK_ARSaleOrderID"]);
            lstColVisible.Add(gridView.Columns["FK_ICProductID"]);
            lstColVisible.Add(gridView.Columns["ARProductionPlanningItemProductName"]);
            lstColVisible.Add(gridView.Columns["ARProductionPlanningItemProductDesc"]);
            List<ARProductionPlanningItemsInfo> bindingList = new List<ARProductionPlanningItemsInfo>();
            for (int i = 0; i < purchasePlanItemList.Count; i++)
            {
                ARProductionPlanningItemsInfo obj = purchasePlanItemList[i];
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
            fld_dgcBatchProposalItemsGridControl.DataSource = bindingList;
            fld_dgcBatchProposalItemsGridControl.RefreshDataSource();
            gridView.ExpandAllGroups();
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