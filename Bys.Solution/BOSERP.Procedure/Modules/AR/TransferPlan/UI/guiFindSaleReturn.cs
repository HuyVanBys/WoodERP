using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferPlan
{
    public partial class guiFindSaleReturn : BOSERPScreen
    {
        #region Variables
        public List<ARSaleReturnItemsInfo> SelectedObjects { get; set; }

        public List<ARSaleReturnItemsInfo> SaleReturnItemLists { get; set; }

        public List<ARDeliveryPlanItemsInfo> DeliveryPlanItemLists { get; set; }
        #endregion

        public guiFindSaleReturn(List<ARDeliveryPlanItemsInfo> deliveryPlanItems)
        {
            InitializeComponent();
            DeliveryPlanItemLists = deliveryPlanItems;
        }

        private void guiAddWorkGroup_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            InitBindingDatasource();
            SetDefault();
            SelectedObjects = new List<ARSaleReturnItemsInfo>();
        }

        private void InitBindingDatasource()
        {
            ARSaleReturnsController objSaleReturnsController = new ARSaleReturnsController();
            List<ARSaleReturnsInfo> saleReturns = objSaleReturnsController.GetSaleReturnsForShipping();
            fld_lkeFK_ARSaleReturnID.Properties.DataSource = saleReturns;

            ARCustomersController objCustomersController = new ARCustomersController();
            DataSet customers = objCustomersController.GetAllCustomersForLookupControl();
            fld_lkeFK_ARCustomerID.Properties.DataSource = customers.Tables[0];
        }

        private void SetDefault()
        {
            fld_dteARSaleOrderDeliveryDateForm.EditValue = BOSApp.GetCurrentServerDate().AddDays(-7);
            fld_dteARSaleOrderDeliveryDateTo.EditValue = BOSApp.GetCurrentServerDate();
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
            if (SaleReturnItemLists != null)
            {
                SelectedObjects = SelectedObjects.Concat(SaleReturnItemLists.Where(o => o.Selected == true)).GroupBy(o => o.ARSaleReturnItemID).Select(o => o.FirstOrDefault()).ToList();
            }
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
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

            if (SaleReturnItemLists != null)
                SelectedObjects = SelectedObjects.Concat(SaleReturnItemLists.Where(o => o.Selected == true)).GroupBy(o => o.ARSaleReturnItemID).Select(o => o.FirstOrDefault()).ToList();
            SaleReturnItemLists = new List<ARSaleReturnItemsInfo>();
            ARSaleReturnItemsController objSaleReturnItemsController = new ARSaleReturnItemsController();
            SaleReturnItemLists = objSaleReturnItemsController.GetSaleReturnItemForDeliveryPlansByUserPermission(BOSApp.CurrentUsersInfo.ADUserID,
                                                                                        ModuleName.TransferPlan,
                                                                                        ADDataViewPermissionType.Module,
                                                                                        (DateTime?)fld_dteARSaleOrderDeliveryDateForm.EditValue,
                                                                                        (DateTime?)fld_dteARSaleOrderDeliveryDateTo.EditValue,
                                                                                        (int?)(fld_lkeFK_ARSaleReturnID.EditValue ?? 0),
                                                                                        (int?)(fld_lkeFK_ARCustomerID.EditValue ?? 0)
                                                                                                                        );
            DeliveryPlanItemLists.ForEach(o =>
                {
                    ARSaleReturnItemsInfo objSaleReturnItemsInfo = SaleReturnItemLists.FirstOrDefault(x => x.ARSaleReturnItemID == o.FK_ARSaleReturnItemID);
                    if (objSaleReturnItemsInfo != null)
                        SaleReturnItemLists.Remove(objSaleReturnItemsInfo);
                });
            SaleReturnItemLists.ForEach(o =>
                {
                    if (SelectedObjects.Any(x => x.ARSaleReturnItemID == o.ARSaleReturnItemID))
                        o.Selected = true;
                });
            fld_dgcARSaleReturnItemsGridControl.InvalidateDataSource(SaleReturnItemLists);
            GridView gridView = (GridView)fld_dgcARSaleReturnItemsGridControl.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_chkSelectedAll_CheckedChanged(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcARSaleReturnItemsGridControl.MainView;
            List<ARSaleReturnItemsInfo> listView = new List<ARSaleReturnItemsInfo>();
            BindingSource bds = (BindingSource)fld_dgcARSaleReturnItemsGridControl.DataSource;

            List<ARSaleReturnItemsInfo> objects = (List<ARSaleReturnItemsInfo>)bds.DataSource;
            for (int j = 0; j < gridView.RowCount; j++)
            {
                ARSaleReturnItemsInfo objDataViewPermissionsInfo = (ARSaleReturnItemsInfo)gridView.GetRow(j);
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
            fld_dgcARSaleReturnItemsGridControl.RefreshDataSource();
        }
    }
}