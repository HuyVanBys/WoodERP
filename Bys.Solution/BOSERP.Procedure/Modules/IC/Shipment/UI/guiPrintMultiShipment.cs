using BOSCommon;
using BOSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using BOSComponent;
using Localization;

namespace BOSERP.Modules.Shipment
{
    public partial class guiPrintMultiShipment : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<ICShipmentsInfo> SelectedObjects { get; set; }

        public List<ICShipmentsInfo> ShipmentList { get; set; }

        public DateTime? ShipmentFromDate { get; set; }

        public DateTime? ShipmentToDate { get; set; }


        #endregion

        public guiPrintMultiShipment()
        {
            InitializeComponent();
            InitBindingDatasource();
            ShipmentList = new List<ICShipmentsInfo>();
        }

        private void guiAddWorkGroup_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SelectedObjects = new List<ICShipmentsInfo>();
            fld_dgcShipmentsGridControl.InvalidateDataSource(ShipmentList);
            GridView gridView = (GridView)fld_dgcShipmentsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.OptionsMenu.EnableFooterMenu = false;
            GridControlHelper = new GridControlHelper(gridView);
            InitBindingDatasource();
            fld_dteShipmentDateFrom.EditValue = ShipmentFromDate;
            fld_dteShipmentDateTo.EditValue = ShipmentToDate;
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
            SelectedObjects = GridControlHelper.Selection.OfType<ICShipmentsInfo>().ToList();
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
            GridView gridView = (GridView)fld_dgcShipmentsGridControl.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            ShipmentFromDate = (DateTime?)fld_dteShipmentDateFrom.EditValue;
            ShipmentToDate = (DateTime?)fld_dteShipmentDateTo.EditValue;

            ICShipmentsController objDeliveryPlansController = new ICShipmentsController();
            List<ICShipmentsInfo> shipmentList = objDeliveryPlansController.GetShipmentForMultiSummaryRP( ShipmentFromDate
                                                                                                                     , ShipmentToDate);
            ShipmentList = shipmentList;
            fld_dgcShipmentsGridControl.InvalidateDataSource(shipmentList);
        }

        private void fld_dteShipmentDateFrom_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSDateEdit lke = sender as BOSDateEdit;
            if (lke == null)
                return;
            ShipmentFromDate = (fld_dteShipmentDateFrom.EditValue as DateTime?) ?? DateTime.MaxValue;
        }

        private void fld_dteShipmentDateTo_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSDateEdit lke = sender as BOSDateEdit;
            if (lke == null)
                return;
            ShipmentToDate = (fld_dteShipmentDateTo.EditValue as DateTime?) ?? DateTime.MaxValue;
        }

    }
}




//private void fld_btnAddProduct_Click(object sender, EventArgs e)
//{

//}

//private void fld_btnAdd_Click(object sender, EventArgs e)
//{
//ShipmentEntities entity = (ShipmentEntities)((BaseModuleERP)Module).CurrentModuleEntity;
//int productID = 0;
//int productDetailID = 0;
//decimal detailQty = 0;
//if (fld_lkeFK_ICProductID.EditValue != null)
//    int.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID);
//if (fld_lkeFK_ICProductDetailID.EditValue != null)
//    int.TryParse(fld_lkeFK_ICProductDetailID.EditValue.ToString(), out productDetailID);
//if (fld_tbxICProductPackageQty.EditValue != null)
//    decimal.TryParse(fld_tbxICProductPackageQty.EditValue.ToString(), out detailQty);
//if (productDetailID > 0)
//{
//    ICProductsController objProductsController = new ICProductsController();
//    ICProductDetailsController objProductDetailsController = new ICProductDetailsController();
//    ICShipmentPackageItemDetailsInfo objShipmentPackageItemDetailsInfo = new ICShipmentPackageItemDetailsInfo();
//    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
//    if (objProductsInfo != null)
//    {
//        objShipmentPackageItemDetailsInfo.ICShipmentPackageItemDetailFinalProductNo = objProductsInfo.ICProductNo;
//        objShipmentPackageItemDetailsInfo.ICShipmentPackageItemDetailFinalProductName = objProductsInfo.ICProductName;
//        objShipmentPackageItemDetailsInfo.ICShipmentPackageItemDetailFinalProductDesc = objProductsInfo.ICProductDesc;
//        objShipmentPackageItemDetailsInfo.FK_ICProductID = productID;
//    }
//    ICProductDetailsInfo objProductDetailsInfo = (ICProductDetailsInfo)objProductDetailsController.GetObjectByID(productDetailID);
//    objShipmentPackageItemDetailsInfo.ICShipmentPackageItemDetailNo = objProductDetailsInfo.ICProductDetailProductNo;
//    objShipmentPackageItemDetailsInfo.ICShipmentPackageItemDetailName = objProductDetailsInfo.ICProductDetailProductName;
//    objShipmentPackageItemDetailsInfo.ICShipmentPackageItemDetailQty = detailQty;
//    objShipmentPackageItemDetailsInfo.FK_ICProductDetailID = productDetailID;
//    entity.ShipmentPackageItemDetailList.Add(objShipmentPackageItemDetailsInfo);
//    fld_dgcICShipmentPackageItemDetails1.InvalidateDataSource(entity.ShipmentPackageItemDetailList);
//    }
//}

//private void fld_lkeFK_ICProductID_QueryPopUp(object sender, CancelEventArgs e)
//{
//    //ICProductsController objProductsController = new ICProductsController();
//    //List<ICProductsForViewInfo> productList = new List<ICProductsForViewInfo>();
//    //productList = BOSApp.CurrentProductList.Where(p => p.ICProductType == ProductType.Product.ToString()).ToList();
//    //fld_lkeFK_ICProductID.Properties.DataSource = productList;
//    //fld_lkeFK_ICProductID.EditValue = 0;
//}

//private void fld_lkeFK_ICProductDetailID_QueryPopUp(object sender, CancelEventArgs e)
//{
//    //ICProductDetailsController objProductDetailsController = new ICProductDetailsController();
//    //List<ICProductDetailsInfo> productDetailsList = new List<ICProductDetailsInfo>();
//    //if (fld_lkeFK_ICProductID.EditValue != null)
//    //    productDetailsList = objProductDetailsController.GetListProductDetailByProductID((int)fld_lkeFK_ICProductID.EditValue);
//    //fld_lkeFK_ICProductDetailID.Properties.DataSource = productDetailsList;
//}

//private void fld_btnClosed_Click(object sender, EventArgs e)
//{
//    //this.Close();
//}

//private void guiAddShipmentPackageItemDetails_FormClosing(object sender, FormClosingEventArgs e)
//{
//}

//ICShipmentsController objShipmentsController = new ICShipmentsController();
//DataSet shipments = objShipmentsController.GetAllObjects();
//fld_lkeFK_ARDeliveryPlanID.Properties.DataSource = deliveryPlans.Tables[0];

//ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
//DataSet ds = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup("DeliveryPlanType");
//fld_lkeARDeliveryPlanType.Properties.DataSource = ds.Tables[0];
//fld_lkeARDeliveryPlanType.Properties.ValueMember = "Value";
//fld_lkeARDeliveryPlanType.Properties.DisplayMember = "Text";