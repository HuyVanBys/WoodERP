using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ShipmentSaleOrder
{
    public partial class guiChooseSaleOrders : BOSERPScreen
    {
        private int Count = 0;
        public GridControlHelper gridControlHelper;

        public List<ARSaleOrderItemsInfo> SaleOrderItemList { get; set; }

        public List<ARSaleOrderItemsInfo> SelectedObjects { get; set; }

        public guiChooseSaleOrders(List<ARSaleOrderItemsInfo> saleOrderItemList)
        {
            InitializeComponent();
            SaleOrderItemList = new List<ARSaleOrderItemsInfo>();
            SaleOrderItemList = saleOrderItemList;
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

        private void fld_dgcARDeliveryPlanItemsGridControl_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcARSaleOrderItemsGridControl.InvalidateDataSource(SaleOrderItemList);
            GridView gridView = (GridView)fld_dgcARSaleOrderItemsGridControl.MainView;
            SelectedObjects = new List<ARSaleOrderItemsInfo>();
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();
            gridControlHelper = new GridControlHelper(gridView);
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            String keyWord = String.Empty;
            if(fld_txtFind.Text != "Nhập từ khóa")
            {
                keyWord = fld_txtFind.Text;
            }
            SearchData(keyWord);
        }

        public void SearchData(String keyWord)
        {
            fld_dgcARSaleOrderItemsGridControl.DataSource = SaleOrderItemList;
            fld_dgcARSaleOrderItemsGridControl.RefreshDataSource();
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcARSaleOrderItemsGridControl.MainView;
            if (string.IsNullOrEmpty(keyWord))
            {
                gridView.ExpandAllGroups();
                return;
            }

            List<GridColumn> lstColVisible = new List<GridColumn>();
            lstColVisible.Add(gridView.Columns["FK_ARSaleOrderID"]);
            lstColVisible.Add(gridView.Columns["ACObjectName"]);
            lstColVisible.Add(gridView.Columns["FK_ICStockID"]);
            lstColVisible.Add(gridView.Columns["FK_ICProductID"]);
            lstColVisible.Add(gridView.Columns["ARSaleOrderItemProductDesc"]);
            lstColVisible.Add(gridView.Columns["ARSaleOrderItemProductName"]);
            List<ARSaleOrderItemsInfo> bindingList = new List<ARSaleOrderItemsInfo>();

            for (int i = 0; i < SaleOrderItemList.Count; i++)
            {
                ARSaleOrderItemsInfo obj = SaleOrderItemList[i];
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
            fld_dgcARSaleOrderItemsGridControl.DataSource = bindingList;
            fld_dgcARSaleOrderItemsGridControl.RefreshDataSource();
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = gridControlHelper.Selection.OfType<ARSaleOrderItemsInfo>().ToList();
            if (SelectedObjects.Count() == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (SelectedObjects.Select(o => o.FK_ARSaleOrderID).Distinct().Count() > 1)
            {
                MessageBox.Show(ShipmentSaleOrderLocalizedResources.NewFromDeleveryPlanErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void fld_txtFind_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fld_txtFind.Text))
            {
                fld_txtFind.Text = "Nhập từ khóa";
            }
        }

        private void fld_txtFind_Enter(object sender, EventArgs e)
        {
            if (fld_txtFind.Text == "Nhập từ khóa")
            {
                fld_txtFind.Text = string.Empty;
            }
        }
    }
}