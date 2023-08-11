using BOSCommon.Extensions.Helper;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseProposal
{
    public partial class guiProductsOfSaleOrder : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<ARSaleOrderItemsInfo> SelectedObjects { get; set; }

        public List<ARSaleOrderItemsInfo> SaleOrderItemList { get; set; }
        public BOSList<APProposalItemsInfo> PurchaseProposalItemList { get; set; }

        public GridControlHelper gridControlHelper;
        #endregion

        public guiProductsOfSaleOrder()
        {
            InitializeComponent();
        }

        public guiProductsOfSaleOrder(BOSList<APProposalItemsInfo> purchaseProposalItemList)
        {
            PurchaseProposalItemList = purchaseProposalItemList;
        }

        private void guiChooseMaterials_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SelectedObjects = new List<ARSaleOrderItemsInfo>();
            fld_dgcAPProductsOfSaleOrderItemGridControl.InvalidateDataSource(SaleOrderItemList);
            GridView gridView = (GridView)fld_dgcAPProductsOfSaleOrderItemGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.OptionsMenu.EnableFooterMenu = false;
            GridControlHelper = new GridControlHelper(gridView);
            InitBindingDatasource();
            SetDefault();
            gridControlHelper = new GridControlHelper(gridView);
        }
        private void SetDefault()
        {
            fld_dteARSaleOrderDeliveryDateForm.EditValue = BOSApp.GetCurrentServerDate();
            fld_dteARSaleOrderDeliveryDateTo.EditValue = BOSApp.GetCurrentServerDate().AddDays(7);
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
            List<ARSaleOrderItemsInfo> newSelect = gridControlHelper.Selection.OfType<ARSaleOrderItemsInfo>().ToList();
            if (newSelect.Count() != 0)
                SelectedObjects = SelectedObjects.Union(newSelect).DistinctBy(o => o.ARSaleOrderItemID).ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitBindingDatasource()
        {
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            List<ARSaleOrdersInfo> saleOrders = objSaleOrdersController.GetSaleOrdersForShipping();
            fld_lkeFK_ARSaleOrderID.Properties.DataSource = saleOrders;

            ARCustomersController objCustomersController = new ARCustomersController();
            DataSet customers = objCustomersController.GetAllCustomersForLookupControl();
            fld_lkeFK_ARCustomerID.Properties.DataSource = customers.Tables[0];
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            if (SaleOrderItemList != null)
            {
                List<ARSaleOrderItemsInfo> newSelect = gridControlHelper.Selection.OfType<ARSaleOrderItemsInfo>().ToList();
                if (newSelect.Count() != 0)
                    SelectedObjects = SelectedObjects.Union(newSelect).DistinctBy(o => o.ARSaleOrderItemID).ToList();
            }
            SaleOrderItemList = new List<ARSaleOrderItemsInfo>();
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            SaleOrderItemList = objSaleOrderItemsController.GetSaleOrderItemForPurchaseProposal((DateTime?)fld_dteARSaleOrderDeliveryDateForm.EditValue,
                                                                                        (DateTime?)fld_dteARSaleOrderDeliveryDateTo.EditValue,
                                                                                        (int?)(fld_lkeFK_ARSaleOrderID.EditValue ?? 0),
                                                                                        (int?)(fld_lkeFK_ARCustomerID.EditValue ?? 0));

            fld_dgcAPProductsOfSaleOrderItemGridControl.InvalidateDataSource(SaleOrderItemList);
            GridView gridView = (GridView)fld_dgcAPProductsOfSaleOrderItemGridControl.MainView;
            gridView.ExpandAllGroups();
        }

        private void SearchData(String keyWord)
        {
            fld_dgcAPProductsOfSaleOrderItemGridControl.DataSource = SaleOrderItemList;
            fld_dgcAPProductsOfSaleOrderItemGridControl.RefreshDataSource();
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcAPProductsOfSaleOrderItemGridControl.MainView;
            if (string.IsNullOrEmpty(keyWord))
            {
                gridView.ExpandAllGroups();
                return;
            }
            List<GridColumn> lstColVisible = new List<GridColumn>();
            lstColVisible.Add(gridView.Columns["ARSaleOrderItemProductDesc"]);
            lstColVisible.Add(gridView.Columns["ARSaleOrderItemProductName"]);
            lstColVisible.Add(gridView.Columns["ARSaleOrderItemPONo"]);
            lstColVisible.Add(gridView.Columns["ACObjectName"]);
            lstColVisible.Add(gridView.Columns["FK_ICProductID"]);
            lstColVisible.Add(gridView.Columns["FK_ARSaleOrderID"]);
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
            fld_dgcAPProductsOfSaleOrderItemGridControl.DataSource = bindingList;
            fld_dgcAPProductsOfSaleOrderItemGridControl.RefreshDataSource();
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