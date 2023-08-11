using BOSCommon;
using BOSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.InvoiceIn
{
    public partial class guiAddProductPackageItemDetails : BOSERPScreen
    {
        #region Variables

        public List<APInvoiceInPackageItemDetailsInfo> InvoiceInPackageItemDetailsList { get; set; }

        #endregion

        public guiAddProductPackageItemDetails(IBOSList<APInvoiceInPackageItemDetailsInfo> InvoiceInPackageItemDetailList)
        {
            InitializeComponent();
            InvoiceInPackageItemDetailsList = new List<APInvoiceInPackageItemDetailsInfo>();
            InvoiceInPackageItemDetailsList = (List<APInvoiceInPackageItemDetailsInfo>)InvoiceInPackageItemDetailList;
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
            InvoiceInEntities entity = (InvoiceInEntities)((BaseModuleERP)Module).CurrentModuleEntity;
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
                APInvoiceInPackageItemDetailsInfo objInvoiceInPackageItemDetailsInfo = new APInvoiceInPackageItemDetailsInfo();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                if (objProductsInfo != null)
                {
                    objInvoiceInPackageItemDetailsInfo.APInvoiceInPackageItemDetailFinalProductNo = objProductsInfo.ICProductNo;
                    objInvoiceInPackageItemDetailsInfo.APInvoiceInPackageItemDetailFinalProductName = objProductsInfo.ICProductName;
                    objInvoiceInPackageItemDetailsInfo.APInvoiceInPackageItemDetailFinalProductDesc = objProductsInfo.ICProductDesc;
                    objInvoiceInPackageItemDetailsInfo.FK_ICProductID = productID;
                }
                ICProductDetailsInfo objProductDetailsInfo = (ICProductDetailsInfo)objProductDetailsController.GetObjectByID(productDetailID);
                objInvoiceInPackageItemDetailsInfo.APInvoiceInPackageItemDetailNo = objProductDetailsInfo.ICProductDetailProductNo;
                objInvoiceInPackageItemDetailsInfo.APInvoiceInPackageItemDetailName = objProductDetailsInfo.ICProductDetailProductName;
                objInvoiceInPackageItemDetailsInfo.APInvoiceInPackageItemDetailQty = detailQty;
                objInvoiceInPackageItemDetailsInfo.FK_ICProductDetailID = productDetailID;
                entity.InvoiceInPackageItemDetailList.Add(objInvoiceInPackageItemDetailsInfo);
                fld_dgcAPInvoiceInPackageItemDetails1.InvalidateDataSource(entity.InvoiceInPackageItemDetailList);
            }
        }

        private void fld_btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guiAddInvoiceInPackageItemDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
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

        private void fld_lkeFK_ICProductDetailID_QueryPopUp_1(object sender, CancelEventArgs e)
        {
            ICProductDetailsController objProductDetailsController = new ICProductDetailsController();
            List<ICProductDetailsInfo> productDetailsList = new List<ICProductDetailsInfo>();
            if (fld_lkeFK_ICProductID.EditValue != null)
                productDetailsList = objProductDetailsController.GetListProductDetailByProductID((int)fld_lkeFK_ICProductID.EditValue);
            fld_lkeFK_ICProductDetailID.Properties.DataSource = productDetailsList;
        }
    }
}