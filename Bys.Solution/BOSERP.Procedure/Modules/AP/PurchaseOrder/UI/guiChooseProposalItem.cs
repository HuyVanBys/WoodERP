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

namespace BOSERP.Modules.PurchaseOrder
{
    public partial class guiChooseProposalItem : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<APProposalItemsInfo> SelectedObjects { get; set; }

        public List<APProposalItemsInfo> ProposalItemList { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string ProposalProductType { get; set; }

        #endregion
        public guiChooseProposalItem()
        {
            InitializeComponent();
            ProposalItemList = new List<APProposalItemsInfo>();
            SelectedObjects = new List<APProposalItemsInfo>();
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
            DateTime toDay = BOSApp.GetCurrentServerDate();
            fld_dteFromDate.EditValue = toDay.AddMonths(-1);
            fld_dteToDate.EditValue = toDay;
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            GridView gridView = (GridView)fld_dgcAPProposalItems.MainView;
            fld_dgcAPProposalItems.InvalidateDataSource(ProposalItemList);
            GridControlHelper = new GridControlHelper(gridView);
            InitBindingDatasource();
        }

        private void InitBindingDatasource()
        {
            GridView gridView = (GridView)fld_dgcAPProposalItems.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            int countTemp = 0;
            SelectedObjects = GridControlHelper.Selection.OfType<APProposalItemsInfo>().ToList();
            countTemp = SelectedObjects.Count();
            if (countTemp == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            countTemp = SelectedObjects.Select(o => o.APPurchaseProposalType).Distinct().Count();
            if (countTemp != 1)
            {
                DialogResult rs = MessageBox.Show("Bạn đang chọn các mặt hàng không cùng loại đề nghị. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }
            APProposalItemsInfo objProposalItemsInfo = SelectedObjects.FirstOrDefault();
            if (objProposalItemsInfo != null)
            {
                FromDate = objProposalItemsInfo.APProposalItemNeedTime.Date;
                ToDate = objProposalItemsInfo.APProposalItemNeedToTime.Date;
            }
            else
            {
                FromDate = fld_dteFromDate.DateTime.Date;
                ToDate = fld_dteToDate.DateTime.Date;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SearchData(String keyWord, List<APProposalItemsInfo> proposalItemList)
        {
            GridView gridView = (GridView)fld_dgcAPProposalItems.MainView;
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
                List<APProposalItemsInfo> bindingList = new List<APProposalItemsInfo>();

                fld_dgcAPProposalItems.DataSource = proposalItemList;
                fld_dgcAPProposalItems.RefreshDataSource();

                for (int i = 0; i < proposalItemList.Count; i++)
                {
                    APProposalItemsInfo obj = proposalItemList[i];
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
                fld_dgcAPProposalItems.DataSource = bindingList;
                fld_dgcAPProposalItems.RefreshDataSource();
            }
            else
            {
                fld_dgcAPProposalItems.DataSource = proposalItemList;
                fld_dgcAPProposalItems.RefreshDataSource();
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
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((PurchaseOrderModule)Module).CurrentModuleEntity;
            int proposalID = fld_lkeProposalID.EditValue == null ? 0 : Int32.Parse(fld_lkeProposalID.EditValue.ToString());
            int departmentID = fld_lkeFK_HRDepartmentID.EditValue == null ? 0 : Int32.Parse(fld_lkeFK_HRDepartmentID.EditValue.ToString());
            int departmentRoomID = fld_lkeFK_HRDepartmentRoomID.EditValue == null ? 0 : Int32.Parse(fld_lkeFK_HRDepartmentRoomID.EditValue.ToString());
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            string keySearch = fld_txtSearchKey.EditValue == null ? string.Empty : fld_txtSearchKey.EditValue.ToString();
            bool isProposalMaterial = string.IsNullOrWhiteSpace(ProposalProductType) ? false : true;
            APProposalItemsController objProposalItemsController = new APProposalItemsController();
            ProposalItemList = objProposalItemsController.GetItemForPurchaseProposal(BOSApp.CurrentUsersInfo.ADUserID
                                                                                     , ModuleName.PurchaseOrder
                                                                                     , ADDataViewPermissionType.Module
                                                                                     , proposalID
                                                                                     , departmentID
                                                                                     , departmentRoomID
                                                                                     , fromDate
                                                                                     , toDate
                                                                                     , ProposalProductType
                                                                                     , isProposalMaterial);
            entity.PurchaseOrderItemList.ForEach(o =>
            {
                ProposalItemList.RemoveAll(item => item.APProposalItemID == o.FK_APProposalItemID);
            });
            SearchData(keySearch, ProposalItemList);
        }
    }
}
