using BOSCommon;
using BOSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseOrder
{
    public partial class guiAddProductPackageItemDetails : BOSERPScreen
    {
        #region Variables

        public List<APPOPackageItemDetailsInfo> POPackageItemDetailsList { get; set; }

        #endregion

        public guiAddProductPackageItemDetails(IBOSList<APPOPackageItemDetailsInfo> POPackageItemDetailList)
        {
            InitializeComponent();
            POPackageItemDetailsList = new List<APPOPackageItemDetailsInfo>();
            POPackageItemDetailsList = (List<APPOPackageItemDetailsInfo>)POPackageItemDetailList;
        }

        private void guiAddWorkGroup_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
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

        private void fld_btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            int productID = 0;
            int productDetailID = 0;
            decimal detailQty = 0;
            int.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID);
            int.TryParse(fld_lkeFK_ICProductDetailID.EditValue.ToString(), out productDetailID);
            if (fld_tbxICProductPackageQty.EditValue != null)
                decimal.TryParse(fld_tbxICProductPackageQty.EditValue.ToString(), out detailQty);
            if (productDetailID > 0)
            {
                ICProductsController objProductsController = new ICProductsController();
                ICProductDetailsController objProductDetailsController = new ICProductDetailsController();
                APPOPackageItemDetailsInfo objPOPackageItemDetailsInfo = new APPOPackageItemDetailsInfo();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                if (objProductsInfo != null)
                {
                    objPOPackageItemDetailsInfo.APPOPackageItemDetailFinalProductNo = objProductsInfo.ICProductNo;
                    objPOPackageItemDetailsInfo.APPOPackageItemDetailFinalProductName = objProductsInfo.ICProductName;
                    objPOPackageItemDetailsInfo.APPOPackageItemDetailFinalProductDesc = objProductsInfo.ICProductDesc;
                    objPOPackageItemDetailsInfo.FK_ICProductID = productID;
                }
                ICProductDetailsInfo objProductDetailsInfo = (ICProductDetailsInfo)objProductDetailsController.GetObjectByID(productDetailID);
                objPOPackageItemDetailsInfo.APPOPackageItemDetailNo = objProductDetailsInfo.ICProductDetailProductNo;
                objPOPackageItemDetailsInfo.APPOPackageItemDetailName = objProductDetailsInfo.ICProductDetailProductName;
                objPOPackageItemDetailsInfo.APPOPackageItemDetailQty = detailQty;
                objPOPackageItemDetailsInfo.FK_ICProductDetailID = productDetailID;
                entity.POPackageItemDetailList.Add(objPOPackageItemDetailsInfo);
                fld_dgcAPPOPackageItemDetails1.InvalidateDataSource(entity.POPackageItemDetailList);
            }
        }

        private void fld_lkeFK_ICProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsForViewInfo> productList = new List<ICProductsForViewInfo>();
            productList = BOSApp.CurrentProductList.Where(p => p.ICProductType == ProductType.Product.ToString()).ToList();
            //objProductsController.GetProductByProductType(ProductType.Product.ToString());
            fld_lkeFK_ICProductID.Properties.DataSource = productList;
            fld_lkeFK_ICProductID.EditValue = 0;
        }

        private void fld_lkeFK_ICProductDetailID_QueryPopUp(object sender, CancelEventArgs e)
        {
            ICProductDetailsController objProductDetailsController = new ICProductDetailsController();
            List<ICProductDetailsInfo> productDetailsList = new List<ICProductDetailsInfo>();
            if (fld_lkeFK_ICProductID.EditValue != null)
                productDetailsList = objProductDetailsController.GetListProductDetailByProductID((int)fld_lkeFK_ICProductID.EditValue);
            fld_lkeFK_ICProductDetailID.Properties.DataSource = productDetailsList;
        }

        private void fld_btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guiAddPOPackageItemDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}