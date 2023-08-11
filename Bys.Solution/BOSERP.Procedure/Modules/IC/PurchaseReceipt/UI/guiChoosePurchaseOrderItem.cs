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

namespace BOSERP.Modules.PurchaseReceipt
{
    public partial class guiChoosePurchaseOrderItem : BOSERPScreen
    {
        #region Variables
        private GridControlHelper GridControlHelper;

        public List<APPurchaseOrderItemsInfo> SelectedObjects { get; set; }

        private BOSList<APPurchaseOrderItemsInfo> PurchaseOrderItemList { get; set; }

        private int Count = 0;

        #endregion

        public guiChoosePurchaseOrderItem(List<APPurchaseOrderItemsInfo> purchaseOrderItemList)
        {
            InitializeComponent();
            PurchaseOrderItemList = new BOSList<APPurchaseOrderItemsInfo>(TableName.APPurchaseOrderItemsTableName);
            PurchaseOrderItemList.Invalidate(purchaseOrderItemList);
        }

        private void guiChoosePurchaseOrderItem_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.InvalidateDataSource(PurchaseOrderItemList);
            SelectedObjects = new List<APPurchaseOrderItemsInfo>();
            GridView gridView = (GridView)fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            GridControlHelper = new GridControlHelper(gridView);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<APPurchaseOrderItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Count = SelectedObjects.Select(o => o.FK_APPurchaseOrderID).Distinct().Count();
            if (Count > 1)
            {
                MessageBox.Show(PurchaseReceiptLocalizedResources.ChooseMultiPurchaseOrderMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            SearchData(keyWord, PurchaseOrderItemList);
        }

        public void SearchData(String keyWord, BOSList<APPurchaseOrderItemsInfo> purchaseOrderItemList)
        {
            GridView gridView = (GridView)fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.MainView;
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
                List<APPurchaseOrderItemsInfo> bindingList = new List<APPurchaseOrderItemsInfo>();

                fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.DataSource = purchaseOrderItemList;
                fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.RefreshDataSource();

                for (int i = 0; i < PurchaseOrderItemList.Count; i++)
                {
                    APPurchaseOrderItemsInfo obj = purchaseOrderItemList[i];
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
                fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.DataSource = bindingList;
                fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.RefreshDataSource();
            }
            else
            {
                fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.DataSource = purchaseOrderItemList;
                fld_dgcGuiPCReceiptPurchaseOrderItemsGridControl.RefreshDataSource();
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
                SearchData(keyWord, PurchaseOrderItemList);
            }
        }
    }
}
