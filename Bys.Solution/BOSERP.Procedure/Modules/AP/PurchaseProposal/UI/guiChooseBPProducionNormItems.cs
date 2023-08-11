using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
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
    public partial class guiChooseBPProducionNormItems : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public string PurchaseType { get; set; }

        public List<MMBatchProductProductionNormItemsInfo> SelectedObjects { get; set; }

        public List<MMBatchProductProductionNormItemsInfo> BPProductionNormItemLists { get; set; }
        #endregion

        public guiChooseBPProducionNormItems()
        {
            InitializeComponent();
        }

        private void guiChooseBPProducionNormItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SelectedObjects = new List<MMBatchProductProductionNormItemsInfo>();
            fld_dgcMMBBProductionNormItemsGridControl.InvalidateDataSource(BPProductionNormItemLists);

            DateTime toDate = BOSApp.GetCurrentServerDate();
            fld_dteFromDate.EditValue = toDate.AddMonths(-1);
            fld_dteToDate.EditValue = toDate;
            GridView gridView = (GridView)fld_dgcMMBBProductionNormItemsGridControl.MainView;
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
            SelectedObjects = GridControlHelper.Selection.OfType<MMBatchProductProductionNormItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, BaseLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitBindingDatasource()
        {
            GridView gridView = (GridView)fld_dgcMMBBProductionNormItemsGridControl.MainView;
            gridView.ExpandAllGroups();
        }

        private void SearchData(String keyWord, List<MMBatchProductProductionNormItemsInfo> productionNormItemLists)
        {
            fld_dgcMMBBProductionNormItemsGridControl.DataSource = productionNormItemLists;
            fld_dgcMMBBProductionNormItemsGridControl.RefreshDataSource();
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcMMBBProductionNormItemsGridControl.MainView;
            if (string.IsNullOrEmpty(keyWord))
            {
                gridView.ExpandAllGroups();
                return;
            }

            List<GridColumn> lstColVisible = new List<GridColumn>();
            lstColVisible.Add(gridView.Columns["MMBatchProductProductionNormItemProductName"]);
            lstColVisible.Add(gridView.Columns["MMBatchProductProductionNormItemNo"]);
            lstColVisible.Add(gridView.Columns["MMBatchProductProductionNormItemProductDesc"]);
            List<MMBatchProductProductionNormItemsInfo> bindingList = new List<MMBatchProductProductionNormItemsInfo>();

            for (int i = 0; i < productionNormItemLists.Count; i++)
            {
                MMBatchProductProductionNormItemsInfo obj = productionNormItemLists[i];
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
            fld_dgcMMBBProductionNormItemsGridControl.DataSource = bindingList;
            fld_dgcMMBBProductionNormItemsGridControl.RefreshDataSource();
            gridView.ExpandAllGroups();
        }

        private bool IsExistKeyWord(String value, String keyWord)
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

        private void Fld_btnSearch_Click(object sender, EventArgs e)
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)((PurchaseProposalModule)Module).CurrentModuleEntity;
            int batchProductID = fld_lkeMMBatchProductID.EditValue == null ? 0 : Int32.Parse(fld_lkeMMBatchProductID.EditValue.ToString());
            int batchProductItemID = fld_lkeMMBatchProductItemID.EditValue == null ? 0 : Int32.Parse(fld_lkeMMBatchProductItemID.EditValue.ToString());
            string objectAccessKey = fld_lkeFK_ACObjectID.EditValue == null ? string.Empty : fld_lkeFK_ACObjectID.EditValue.ToString();
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            string keySearch = fld_txtFind.EditValue == null ? string.Empty : fld_txtFind.EditValue.ToString();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            MMBatchProductProductionNormItemsController objPnisController = new MMBatchProductProductionNormItemsController();
            if (PurchaseType == PurchasePlanType.Material.ToString()
                || PurchaseType == PurchasePlanType.OtherMaterial.ToString())
            {
                BPProductionNormItemLists = objPnisController.GetItemMaterialForPurchaseProposal(batchProductID
                                                                                                , PurchaseType
                                                                                                , batchProductItemID
                                                                                                , objObjectsInfo.ACObjectID
                                                                                                , objObjectsInfo.ACObjectType
                                                                                                , fromDate
                                                                                                , toDate
                                                                                                , BOSApp.CurrentUsersInfo.ADUserID
                                                                                                , ModuleName.BatchProduct
                                                                                                , ADDataViewPermissionType.Module
                                                                                                , BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            }
            else
            {
                BPProductionNormItemLists = objPnisController.GetItemForPurchaseProposal(batchProductID
                                                                                         , PurchaseType
                                                                                         , batchProductItemID
                                                                                         , objObjectsInfo.ACObjectID
                                                                                         , objObjectsInfo.ACObjectType
                                                                                         , fromDate
                                                                                         , toDate
                                                                                         , BOSApp.CurrentUsersInfo.ADUserID
                                                                                         , ModuleName.BatchProduct
                                                                                         , ADDataViewPermissionType.Module
                                                                                         , BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            }
            entity.PurchaseProposalItemList.ForEach(item =>
            {
                BPProductionNormItemLists.RemoveAll(o => o.FK_MMBatchProductID == item.FK_MMBatchProductID
                                                    && o.FK_MMBatchProductItemID == item.FK_MMBatchProductItemID
                                                    && o.MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID
                                                    && o.MMBatchProductProductionNormItemProductHeight == item.APProposalItemProductHeight
                                                    && o.MMBatchProductProductionNormItemProductWidth == item.APProposalItemProductWidth
                                                    && o.MMBatchProductProductionNormItemProductLength == item.APProposalItemProductLenght
                                                    && o.FK_ICProductID == item.FK_ICProductID);
            });
            SearchData(keySearch, BPProductionNormItemLists);
        }

        private void Fld_lkeMMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;

            if (e.Value != null && lke.EditValue != lke.OldEditValue)
            {
                int batchProductID = Int32.Parse(lke.EditValue.ToString());
                MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
                List<MMBatchProductItemsInfo> batchProductItemList = objBatchProductItemsController.GetBPItemForLookupByBatchProductID(batchProductID);
                batchProductItemList.Insert(0, new MMBatchProductItemsInfo());
                fld_lkeMMBatchProductItemID.EditValue = 0;
                fld_lkeMMBatchProductItemID.Properties.DataSource = null;
                fld_lkeMMBatchProductItemID.Properties.DataSource = batchProductItemList;
                fld_lkeMMBatchProductItemID.Refresh();
            }
        }
    }
}