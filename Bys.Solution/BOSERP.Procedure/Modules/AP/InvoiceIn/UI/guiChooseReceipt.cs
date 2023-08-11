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

namespace BOSERP.Modules.InvoiceIn
{
    public partial class guiChooseReceipt : BOSERPScreen
    {
        #region Variables
        private GridControlHelper GridControlHelper;

        public List<ICReceiptsInfo> SelectedObjects { get; set; }

        private BOSList<ICReceiptsInfo> ReceiptList { get; set; }

        private int Count = 0;

        #endregion

        public guiChooseReceipt(List<ICReceiptsInfo> receiptList)
        {
            InitializeComponent();
            ReceiptList = new BOSList<ICReceiptsInfo>(TableName.MMAllocationPlanItemsTableName);
            ReceiptList.Invalidate(receiptList);
            ICReceiptsInfo objReceiptsInfo = ReceiptList.FirstOrDefault();
        }

        private void guiChooseReceipt_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcReceiptsGridControl.InvalidateDataSource(ReceiptList);
            SelectedObjects = new List<ICReceiptsInfo>();
            GridView gridView = (GridView)fld_dgcReceiptsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            GridControlHelper = new GridControlHelper(gridView);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<ICReceiptsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Count = SelectedObjects.Select(o => new { o.FK_ACObjectID, o.ICObjectType }).Distinct().Count();
            if (Count > 1)
            {
                MessageBox.Show(InvoiceInLocalizedResources.PurchaseOrdersHaveNotSameSupplierMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Count = SelectedObjects.Where(o => o.FK_APPurchaseOrderID > 0).Select(o => o.FK_APPurchaseOrderID).Distinct().Count();
            if (Count > 1)
            {
                MessageBox.Show(InvoiceInLocalizedResources.ChooseMultiPurchaseOrderMesssage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            SearchData(keyWord, ReceiptList);
        }

        public void SearchData(String keyWord, BOSList<ICReceiptsInfo> ReceiptList)
        {
            GridView gridView = (GridView)fld_dgcReceiptsGridControl.MainView;
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
                List<ICReceiptsInfo> bindingList = new List<ICReceiptsInfo>();

                fld_dgcReceiptsGridControl.DataSource = ReceiptList;
                fld_dgcReceiptsGridControl.RefreshDataSource();

                for (int i = 0; i < ReceiptList.Count; i++)
                {
                    ICReceiptsInfo obj = ReceiptList[i];
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
                fld_dgcReceiptsGridControl.DataSource = bindingList;
                fld_dgcReceiptsGridControl.RefreshDataSource();
            }
            else
            {
                fld_dgcReceiptsGridControl.DataSource = ReceiptList;
                fld_dgcReceiptsGridControl.RefreshDataSource();
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
                SearchData(keyWord, ReceiptList);
            }
        }
    }
}
