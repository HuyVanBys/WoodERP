using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BOSLib;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using BOSCommon;
using System.Linq;

namespace BOSERP.Modules.ShipmentSaleOrder
{
    public partial class guiAddProductPackageItemDetails : BOSERPScreen
    {
        #region Variables

        public List<ICShipmentPackageItemDetailsInfo> ShipmentPackageItemDetailsList { get; set; }

        #endregion

        public guiAddProductPackageItemDetails(IBOSList<ICShipmentPackageItemDetailsInfo> ShipmentPackageItemDetailList)
        {
            InitializeComponent();
            ShipmentPackageItemDetailsList = new List<ICShipmentPackageItemDetailsInfo>();
            ShipmentPackageItemDetailsList = (List<ICShipmentPackageItemDetailsInfo>)ShipmentPackageItemDetailList;
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
            ShipmentSaleOrderEntities entity = (ShipmentSaleOrderEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            int productID = 0;
            int productDetailID = 0;
            decimal detailQty = 0;
            if (fld_lkeFK_ICProductID.EditValue != null)
                int.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID);
            if (fld_lkeFK_ICProductDetailID.EditValue != null)
                int.TryParse(fld_lkeFK_ICProductDetailID.EditValue.ToString(), out productDetailID);
            if (fld_tbxICProductPackageQty.EditValue != null)
                decimal.TryParse(fld_tbxICProductPackageQty.EditValue.ToString(), out detailQty);
            if (productDetailID > 0)
            {
                ICProductsController objProductsController = new ICProductsController();
                ICProductDetailsController objProductDetailsController = new ICProductDetailsController();
                ICShipmentPackageItemDetailsInfo objShipmentPackageItemDetailsInfo = new ICShipmentPackageItemDetailsInfo();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                if (objProductsInfo != null)
                {
                    objShipmentPackageItemDetailsInfo.ICShipmentPackageItemDetailFinalProductNo = objProductsInfo.ICProductNo;
                    objShipmentPackageItemDetailsInfo.ICShipmentPackageItemDetailFinalProductName = objProductsInfo.ICProductName;
                    objShipmentPackageItemDetailsInfo.ICShipmentPackageItemDetailFinalProductDesc = objProductsInfo.ICProductDesc;
                    objShipmentPackageItemDetailsInfo.FK_ICProductID = productID;
                }
                ICProductDetailsInfo objProductDetailsInfo = (ICProductDetailsInfo)objProductDetailsController.GetObjectByID(productDetailID);
                objShipmentPackageItemDetailsInfo.ICShipmentPackageItemDetailNo = objProductDetailsInfo.ICProductDetailProductNo;
                objShipmentPackageItemDetailsInfo.ICShipmentPackageItemDetailName = objProductDetailsInfo.ICProductDetailProductName;
                objShipmentPackageItemDetailsInfo.ICShipmentPackageItemDetailQty = detailQty;
                objShipmentPackageItemDetailsInfo.FK_ICProductDetailID = productDetailID;
                entity.ShipmentPackageItemDetailList.Add(objShipmentPackageItemDetailsInfo);
                fld_dgcICShipmentPackageItemDetails1.InvalidateDataSource(entity.ShipmentPackageItemDetailList);
            }
        }

        private void fld_lkeFK_ICProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> productList = new List<ICProductsInfo>();
            productList = objProductsController.GetProductByProductType(ProductType.Product.ToString());
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

        private void guiAddShipmentPackageItemDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}