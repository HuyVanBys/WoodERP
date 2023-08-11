using BOSCommon.Constants;
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
    public partial class guiChoosePurchasePlanItem : BOSERPScreen
    {

        private GridControlHelper GridHelper;

        public List<MMPurchasePlanItemsInfo> PurchasePlanItemsList { get; set; }

        public List<MMPurchasePlanItemsInfo> SelectedObjects { get; set; }

        public string PlanType { get; set; }

        public guiChoosePurchasePlanItem()
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

        private void guiChooseProposalItem_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            DateTime toDate = BOSApp.GetCurrentServerDate();
            fld_dteFromDate.EditValue = toDate.AddMonths(-1);
            fld_dteToDate.EditValue = toDate;
            PurchaseProposalEntities entity = (PurchaseProposalEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.PurchasePlanItemList.InitBOSListGridControl(fld_dgcMMPurchasePlanItems);
            GridView gridView = (GridView)fld_dgcMMPurchasePlanItems.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            GridHelper = new GridControlHelper(gridView);
            gridView.ExpandAllGroups();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridHelper.Selection.OfType<MMPurchasePlanItemsInfo>().ToList();
            if (SelectedObjects.Count() == 0)
            {
                MessageBox.Show(PurchaseOrderLocalizedResources.ChooseProposalItemsMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        public void SearchData(String keyWord, List<MMPurchasePlanItemsInfo> purchasePlanItemList)
        {
            GridView gridView = (GridView)fld_dgcMMPurchasePlanItems.MainView;
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
                List<MMPurchasePlanItemsInfo> bindingList = new List<MMPurchasePlanItemsInfo>();
                fld_dgcMMPurchasePlanItems.DataSource = purchasePlanItemList;
                fld_dgcMMPurchasePlanItems.RefreshDataSource();

                for (int i = 0; i < purchasePlanItemList.Count; i++)
                {
                    MMPurchasePlanItemsInfo obj = purchasePlanItemList[i];
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
                fld_dgcMMPurchasePlanItems.DataSource = bindingList;
                fld_dgcMMPurchasePlanItems.RefreshDataSource();
            }
            else
            {
                fld_dgcMMPurchasePlanItems.DataSource = purchasePlanItemList;
                fld_dgcMMPurchasePlanItems.RefreshDataSource();
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

        private void Fld_btnSearch_Click(object sender, EventArgs e)
        {
            PurchaseProposalEntities entity = (PurchaseProposalEntities)((PurchaseProposalModule)Module).CurrentModuleEntity;
            int purchasePlanID = fld_lkePurchasePlanID.EditValue == null ? 0 : Int32.Parse(fld_lkePurchasePlanID.EditValue.ToString());
            int batchProductID = fld_lkeMMBatchProductID.EditValue == null ? 0 : Int32.Parse(fld_lkeMMBatchProductID.EditValue.ToString());
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            string keySearch = fld_txtSearchKey.EditValue == null ? string.Empty : fld_txtSearchKey.EditValue.ToString();
            MMPurchasePlanItemsController objPurchasePlanItemsController = new MMPurchasePlanItemsController();
            PurchasePlanItemsList = objPurchasePlanItemsController.GetItemForPurchaseProposal(PlanType
                                                                                            , purchasePlanID
                                                                                            , batchProductID
                                                                                            , fromDate
                                                                                            , toDate
                                                                                            , BOSApp.CurrentUsersInfo.ADUserID
                                                                                            , ModuleName.BatchProductShedule
                                                                                            , ADDataViewPermissionType.Module
                                                                                            , BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            SearchData(keySearch, PurchasePlanItemsList);
        }
    }
}
