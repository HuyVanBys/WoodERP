using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CancelPurchaseOrder
{
    public partial class guiChoosePurchaseOrderItem : BOSERPScreen
    {
        /// <summary>
        /// Count is used to distinguish focus row changed event in grid
        /// and click event in check edit control
        /// </summary>
        private int Count = 0;
        public GridControlHelper gridControlHelper;

        public List<APPurchaseOrderItemsInfo> ReceiptList { get; set; }

        public List<APPurchaseOrderItemsInfo> SelectedObjects { get; set; }

        public guiChoosePurchaseOrderItem(List<APPurchaseOrderItemsInfo> receiptList)
        {
            InitializeComponent();
            ReceiptList = new List<APPurchaseOrderItemsInfo>();
            ReceiptList = receiptList;
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

        private void guiChoosePurchaseOrderItem_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcAPProductsOfProposalItemsGridControl.InvalidateDataSource(ReceiptList);
            GridView gridView = (GridView)fld_dgcAPProductsOfProposalItemsGridControl.MainView;
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(GridView_FocusedRowChanged);
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();
            gridControlHelper = new GridControlHelper(gridView);
        }

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Count = 1;
            GridView gridView = (GridView)fld_dgcAPProductsOfProposalItemsGridControl.MainView;
            APPurchaseOrderItemsInfo objReceiptItemsInfo = (APPurchaseOrderItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = gridControlHelper.Selection.OfType<APPurchaseOrderItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            String keyWord = String.Empty;
            keyWord = fld_txtFind.Text;
            SearchData(keyWord);
        }

        public void SearchData(String keyWord)
        {
            fld_dgcAPProductsOfProposalItemsGridControl.DataSource = ReceiptList;
            fld_dgcAPProductsOfProposalItemsGridControl.RefreshDataSource();
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcAPProductsOfProposalItemsGridControl.MainView;
            if (string.IsNullOrEmpty(keyWord))
            {
                gridView.ExpandAllGroups();
                return;
            }

            List<GridColumn> lstColVisible = new List<GridColumn>();
            GridColumn col = gridView.Columns["FK_ICProductID"];
            if(col != null)
            {
                lstColVisible.Add(col);
            }
            col = gridView.Columns["APPurchaseOrderItemProductName"];
            if (col != null)
            {
                lstColVisible.Add(col);
            }
            col = gridView.Columns["ARCustomerName"];
            if (col != null)
            {
                lstColVisible.Add(col);
            }
            col = gridView.Columns["ACObjectName"];
            if (col != null)
            {
                lstColVisible.Add(col);
            }
            col = gridView.Columns["ACAssObjectName"];
            if (col != null)
            {
                lstColVisible.Add(col);
            }
            col = gridView.Columns["FK_APPurchaseOrderID"];
            if (col != null)
            {
                lstColVisible.Add(col);
            }
            col = gridView.Columns["APPurchaseOrderNo"];
            if (col != null)
            {
                lstColVisible.Add(col);
            }
            List<APPurchaseOrderItemsInfo> bindingList = new List<APPurchaseOrderItemsInfo>();

            for (int i = 0; i < ReceiptList.Count; i++)
            {
                APPurchaseOrderItemsInfo obj = ReceiptList[i];
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
            fld_dgcAPProductsOfProposalItemsGridControl.DataSource = bindingList;
            fld_dgcAPProductsOfProposalItemsGridControl.RefreshDataSource();
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

        private void fld_txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String keyWord = String.Empty;
                keyWord = fld_txtFind.Text;
                SearchData(keyWord);
            }
        }
    }
}
