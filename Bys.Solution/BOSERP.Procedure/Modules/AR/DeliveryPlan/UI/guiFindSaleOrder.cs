using BOSCommon;
using BOSCommon.Constants;
using BOSCommon.Extensions.Helper;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.DeliveryPlan
{
    public partial class guiFindSaleOrder : BOSERPScreen
    {
        #region Variables
        public List<ARSaleOrderItemsInfo> SelectedObjects { get; set; }

        public List<ARSaleOrderItemsInfo> SaleOrderItemLists { get; set; }

        public List<ARDeliveryPlanItemsInfo> DeliveryPlanItemLists { get; set; }

        public GridControlHelper gridControlHelper;
        #endregion

        public guiFindSaleOrder(List<ARDeliveryPlanItemsInfo> deliveryPlanItems)
        {
            InitializeComponent();
            DeliveryPlanItemLists = deliveryPlanItems;
        }

        private void guiAddWorkGroup_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            InitBindingDatasource();
            SetDefault();
            SelectedObjects = new List<ARSaleOrderItemsInfo>();
            GridView gridView = (GridView)fld_dgcARSaleOrderItemsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();
            gridControlHelper = new GridControlHelper(gridView);
        }

        private void InitBindingDatasource()
        {
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            List<ARSaleOrdersInfo> saleOrders = objSaleOrdersController.GetSaleOrdersForShipping();
            fld_lkeFK_ARSaleOrderID.Properties.DataSource = saleOrders;

            ARCustomersController objCustomersController = new ARCustomersController();
            DataSet customers = objCustomersController.GetAllCustomersForLookupControl();
            fld_lkeFK_ARCustomerID.Properties.DataSource = customers.Tables[0];

            ARDeliveryPlansController objDeliveryPlansController = new ARDeliveryPlansController();
            DataSet deliveryPlans = objDeliveryPlansController.GetAllObjects();
            fld_lkeFK_ARDeliveryPlanID.Properties.DataSource = deliveryPlans.Tables[0];

            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup("DeliveryPlanAddNewType");
            fld_lkeARDeliveryPlanAddNewType.Properties.DataSource = ds.Tables[0];
            fld_lkeARDeliveryPlanAddNewType.Properties.ValueMember = "Value";
            fld_lkeARDeliveryPlanAddNewType.Properties.DisplayMember = "Text";
        }

        private void SetDefault()
        {
            fld_dteARSaleOrderDeliveryDateForm.EditValue = BOSApp.GetCurrentServerDate();
            fld_dteARSaleOrderDeliveryDateTo.EditValue = BOSApp.GetCurrentServerDate().AddDays(7);
            fld_lkeARDeliveryPlanAddNewType.EditValue = DeliveryPlanAddNewType.New.ToString();
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

        private void fld_lkeFK_PMPhaseTypeID_KeyUp(object sender, KeyEventArgs e)
        {
            string value = string.Empty;
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

        private void fld_btnFind_Click(object sender, EventArgs e)
        {

            if (SaleOrderItemLists != null)
            {
                List<ARSaleOrderItemsInfo> newSelect = gridControlHelper.Selection.OfType<ARSaleOrderItemsInfo>().ToList();
                if (newSelect.Count() != 0)
                    SelectedObjects = SelectedObjects.Union(newSelect).DistinctBy(o => o.ARSaleOrderItemID).ToList();
            }
            SaleOrderItemLists = new List<ARSaleOrderItemsInfo>();
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            SaleOrderItemLists = objSaleOrderItemsController.GetSaleOrderItemForDeliveryPlansByUserPermission(BOSApp.CurrentUsersInfo.ADUserID,
                                                                                        ModuleName.DeliveryPlan,
                                                                                        ADDataViewPermissionType.Module,
                                                                                        (DateTime?)fld_dteARSaleOrderDeliveryDateForm.EditValue,
                                                                                        (DateTime?)fld_dteARSaleOrderDeliveryDateTo.EditValue,
                                                                                        (int?)(fld_lkeFK_ARSaleOrderID.EditValue ?? 0),
                                                                                        (int?)(fld_lkeFK_ARCustomerID.EditValue ?? 0),
                                                                                        (fld_txtARSaleOrderSaleAgreement.EditValue ?? string.Empty).ToString(),
                                                                                        (int?)(fld_lkeFK_ARDeliveryPlanID.EditValue ?? 0),
                                                                                        (fld_lkeARDeliveryPlanAddNewType.EditValue ?? string.Empty).ToString());

            fld_dgcARSaleOrderItemsGridControl.InvalidateDataSource(SaleOrderItemLists);
            GridView gridView = (GridView)fld_dgcARSaleOrderItemsGridControl.MainView;
            gridView.ExpandAllGroups();
        }

        private bool CheckContainBySaleOrderID(int saleOrderItemID)
        {
            if (SelectedObjects.Where(o => o.ARSaleOrderItemID == saleOrderItemID).Count() == 0)
                return true;

            return false;
        }

        private void fld_chkSelectedAll_CheckedChanged(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcARSaleOrderItemsGridControl.MainView;
            List<ARSaleOrderItemsInfo> listView = new List<ARSaleOrderItemsInfo>();
            BindingSource bds = (BindingSource)fld_dgcARSaleOrderItemsGridControl.DataSource;

            List<ARSaleOrderItemsInfo> objects = (List<ARSaleOrderItemsInfo>)bds.DataSource;
            for (int j = 0; j < gridView.RowCount; j++)
            {
                ARSaleOrderItemsInfo objDataViewPermissionsInfo = (ARSaleOrderItemsInfo)gridView.GetRow(j);
                if (objDataViewPermissionsInfo != null)
                {
                    listView.Add(objDataViewPermissionsInfo);
                }
            }
            for (int i = 0; i < objects.Count; i++)
            {
                foreach (var dataViewItem in listView)
                {
                    if (objects[i] == dataViewItem)
                    {
                        objects[i].Selected = fld_chkSelectedAll.Checked;
                    }
                }

            }
            fld_dgcARSaleOrderItemsGridControl.RefreshDataSource();
        }
    }
}