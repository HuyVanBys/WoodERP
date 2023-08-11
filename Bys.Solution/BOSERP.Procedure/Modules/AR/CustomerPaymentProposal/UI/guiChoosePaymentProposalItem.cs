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

namespace BOSERP.Modules.CustomerPaymentProposal
{
    public partial class guiChoosePaymentProposalItem : BOSERPScreen
    {
        #region Variables
        private GridControlHelper GridControlHelper;

        public List<ARPaymentProposalItemsInfo> SelectedObjects { get; set; }

        private BOSList<ARPaymentProposalItemsInfo> PaymentProposalItemList { get; set; }

        private int Count = 0;

        #endregion

        public guiChoosePaymentProposalItem(List<ARPaymentProposalItemsInfo> paymentProposalItemList)
        {
            InitializeComponent();
            PaymentProposalItemList = new BOSList<ARPaymentProposalItemsInfo>(TableName.ARPaymentProposalItemsTableName);
            PaymentProposalItemList.Invalidate(paymentProposalItemList);
            ARPaymentProposalItemsInfo objReceiptsInfo = paymentProposalItemList.FirstOrDefault();
        }

        private void guiChoosePaymentProposalItem_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcARChoosePaymentProposalItemsGridControl.InvalidateDataSource(PaymentProposalItemList);
            SelectedObjects = new List<ARPaymentProposalItemsInfo>();
            GridView gridView = (GridView)fld_dgcARChoosePaymentProposalItemsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            GridControlHelper = new GridControlHelper(gridView);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<ARPaymentProposalItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Count = SelectedObjects.Select(o => new { o.ACObjectID, o.ACObjectType }).Distinct().Count();
            if (Count > 1)
            {
                MessageBox.Show(CustomerPaymentProposalLocalizedResources.NotMatchCustomer, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            String keyWord = String.Empty;
            keyWord = fld_txtFind.Text;
            SearchData(keyWord, PaymentProposalItemList);
        }

        public void SearchData(String keyWord, BOSList<ARPaymentProposalItemsInfo> paymentProposalItemList)
        {
            GridView gridView = (GridView)fld_dgcARChoosePaymentProposalItemsGridControl.MainView;
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
                List<ARPaymentProposalItemsInfo> bindingList = new List<ARPaymentProposalItemsInfo>();

                fld_dgcARChoosePaymentProposalItemsGridControl.DataSource = paymentProposalItemList;
                fld_dgcARChoosePaymentProposalItemsGridControl.RefreshDataSource();

                for (int i = 0; i < PaymentProposalItemList.Count; i++)
                {
                    ARPaymentProposalItemsInfo obj = PaymentProposalItemList[i];
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
                fld_dgcARChoosePaymentProposalItemsGridControl.DataSource = bindingList;
                fld_dgcARChoosePaymentProposalItemsGridControl.RefreshDataSource();
            }
            else
            {
                fld_dgcARChoosePaymentProposalItemsGridControl.DataSource = paymentProposalItemList;
                fld_dgcARChoosePaymentProposalItemsGridControl.RefreshDataSource();
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

        private void fld_txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String keyWord = String.Empty;
                if (int.Parse(fld_txtFind.Tag.ToString()) != 0)
                    keyWord = fld_txtFind.Text;
                SearchData(keyWord, PaymentProposalItemList);
            }
        }
    }
}
