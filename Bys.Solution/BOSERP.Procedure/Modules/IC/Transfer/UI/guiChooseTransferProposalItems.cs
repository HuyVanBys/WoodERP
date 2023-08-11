using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Transfer
{
    public partial class guiChooseTransferProposalItems : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<ICTransferProposalItemsInfo> SelectedObjects { get; set; }

        public List<ICTransferProposalItemsInfo> TransferProposalItemList { get; set; }

        #endregion

        public guiChooseTransferProposalItems()
        {
            InitializeComponent();
            TransferProposalItemList = new List<ICTransferProposalItemsInfo>();
        }

        private void guiChooseTransferProposalItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SelectedObjects = new List<ICTransferProposalItemsInfo>();
            fld_dgcICTransferProposaltemsGridControl.InvalidateDataSource(TransferProposalItemList);
            DateTime toDay = BOSApp.GetCurrentServerDate();
            fld_dteICTransferDateFrom.DateTime = toDay.AddMonths(-1);
            fld_dteICTransferDateTo.DateTime = toDay;
            GridView gridView = (GridView)fld_dgcICTransferProposaltemsGridControl.MainView;
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
            SelectedObjects = GridControlHelper.Selection.OfType<ICTransferProposalItemsInfo>().ToList();
            int countTranferProposalID = 0;
            if (SelectedObjects.Count() == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            countTranferProposalID = SelectedObjects.Select(o => o.FK_ICTransferProposalID).Distinct().Count();
            if (countTranferProposalID > 1)
            {
                MessageBox.Show("Sản phẩm đã chọn không cùng đề nghị. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitBindingDatasource()
        {
            GridView gridView = (GridView)fld_dgcICTransferProposaltemsGridControl.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            TransferEntities entity = (TransferEntities)((TransferModule)Module).CurrentModuleEntity;
            int branchID = fld_lkeBRBranchID.EditValue == null ? 0 : Int32.Parse(fld_lkeBRBranchID.EditValue.ToString());
            int transferProposalID = fld_btnFK_ICTransferProposalID.EditValue == null ? 0 : Int32.Parse(fld_btnFK_ICTransferProposalID.EditValue.ToString());
            DateTime fromDate = fld_dteICTransferDateFrom.DateTime;
            DateTime toDate = fld_dteICTransferDateTo.DateTime;
            string keySearch = fld_txtSearchKey.EditValue == null ? string.Empty : fld_txtSearchKey.EditValue.ToString();

            ICTransferProposalItemsController objTransferProposalItemsController = new ICTransferProposalItemsController();
            TransferProposalItemList = objTransferProposalItemsController.GetTransferProposalItemForTransfer(branchID, transferProposalID, fromDate, toDate);
            SearchData(keySearch);
        }

        private void SearchData(String keyWord)
        {
            fld_dgcICTransferProposaltemsGridControl.DataSource = TransferProposalItemList;
            fld_dgcICTransferProposaltemsGridControl.RefreshDataSource();
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcICTransferProposaltemsGridControl.MainView;
            if (string.IsNullOrEmpty(keyWord))
            {
                gridView.ExpandAllGroups();
                return;
            }

            List<GridColumn> lstColVisible = new List<GridColumn>();
            lstColVisible.Add(gridView.Columns["ICTransferProposalNo"]);
            lstColVisible.Add(gridView.Columns["ICTransferProposalItemProductName"]);
            lstColVisible.Add(gridView.Columns["ICTransferProposalItemProductDesc"]);
            List<ICTransferProposalItemsInfo> bindingList = new List<ICTransferProposalItemsInfo>();

            for (int i = 0; i < TransferProposalItemList.Count; i++)
            {
                ICTransferProposalItemsInfo obj = TransferProposalItemList[i];
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
            fld_dgcICTransferProposaltemsGridControl.DataSource = bindingList;
            fld_dgcICTransferProposaltemsGridControl.RefreshDataSource();
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
    }
}