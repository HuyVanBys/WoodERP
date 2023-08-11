using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseOrder.UI
{
    /// <summary>
    /// Summary description for DMPO101
    /// </summary>
    public partial class DMPO101 : BOSERPScreen
    {

        public DMPO101()
        {
            InitializeComponent();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            int productID = 0;
            int productPackageItemID = 0;
            if (fld_lkeFK_ICProductID.EditValue != null)
                int.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID);
            if (fld_lkeFK_ICProductPackageItemID.EditValue != null)
                int.TryParse(fld_lkeFK_ICProductPackageItemID.EditValue.ToString(), out productPackageItemID);
            if (productID > 0)
            {
                PurchaseOrderModule module = ((Modules.PurchaseOrder.PurchaseOrderModule)this.Module);
                APPurchaseOrderItemsInfo purchaseOrderItem = entity.PurchaseOrderItemList.Where(o => o.FK_ICProductID == productID).FirstOrDefault();
                ICProductPackageItemsController objProductPackageItemsController = new ICProductPackageItemsController();
                ICProductPackageItemsInfo objProductPackageItemsInfo = objProductPackageItemsController.GetProductPackageItemByProductPackageItemID(productPackageItemID);
                APPOPackageItemsInfo objPOPackageItemsInfo = module.ToPOPackageItem(objProductPackageItemsInfo, purchaseOrderItem);
                objPOPackageItemsInfo.APPOPackageItemTemporaryID = entity.POPackageItemList.Count + 1;
                entity.POPackageItemList.Add(objPOPackageItemsInfo);
                fld_dgcAPPOPackageItems.RefreshDataSource();

                if (productPackageItemID > 0)
                {
                    ICProductPackageItemDetailsController objProductPackageItemDetailsController = new ICProductPackageItemDetailsController();
                    List<ICProductPackageItemDetailsInfo> productPackageItemDetailsList = (List<ICProductPackageItemDetailsInfo>)objProductPackageItemDetailsController.GetProductPackageItemDetailsListByProductPackageItemID(productPackageItemID);
                    productPackageItemDetailsList.ForEach(o =>
                    {
                        APPOPackageItemDetailsInfo objPOPackageItemDetailsInfo = module.ToPOPackageItemDetail(o, objPOPackageItemsInfo.APPOPackageItemQty);
                        objPOPackageItemDetailsInfo.FK_APPOPackageItemID = entity.POPackageItemList.Count;
                        entity.POPackageItemDetailShowList.Add(objPOPackageItemDetailsInfo);
                        fld_dgcAPPOPackageItemDetails.RefreshDataSource();
                    });
                }
                entity.CountItemsInPOPackageItemList++;
            }
        }

        private void fld_lkeFK_ICProductPackageItemID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int productID = 0;
            if (fld_lkeFK_ICProductID.EditValue != null)
                int.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID);
            if (productID > 0)
            {
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                ICProductPackageItemsController objProductPackageItemsController = new ICProductPackageItemsController();
                ICProductPackagesController objProductPackagesController = new ICProductPackagesController();
                List<ICProductPackageItemsInfo> ProductPackageItemList = objProductPackageItemsController.GetProductPackageItemsListByProductID(productID);
                fld_lkeFK_ICProductPackageItemID.Properties.DataSource = ProductPackageItemList;
            }
        }

        private void fld_lkeFK_ICProductID_EditValueChanged(object sender, EventArgs e)
        {
            int productID = 0;
            if (fld_lkeFK_ICProductID.EditValue != null)
                int.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID);
            if (productID > 0)
            {
                bool isExistInPurchaseOrderItemList = ((Modules.PurchaseOrder.PurchaseOrderModule)this.Module).CheckExistInPurchaseOrderItemList(productID);
                if (!isExistInPurchaseOrderItemList)
                {
                    MessageBox.Show(PurchaseOrderLocalizedResources.NoneExistInPurchaseOrderItemList, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fld_lkeFK_ICProductID.EditValue = 0;
                    return;
                }
                ICProductPackageItemsController objProductPackageItemsController = new ICProductPackageItemsController();
                ICProductPackagesController objProductPackagesController = new ICProductPackagesController();
                List<ICProductPackageItemsInfo> productPackageItemList = objProductPackageItemsController.GetProductPackageItemsListByProductID(productID);
                fld_lkeFK_ICProductPackageItemID.Properties.DataSource = productPackageItemList;
            }
        }

        private void fld_lkeFK_ICProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            List<ICProductsInfo> products = new List<ICProductsInfo>();
            List<ICProductsForViewInfo> productViewList = BOSApp.CurrentProductList.Where(o => entity.PurchaseOrderItemList.Select(s => s.FK_ICProductID).Contains(o.ICProductID)).ToList();
            if (productViewList.Count() > 0) productViewList.ForEach(o =>
            {
                ICProductsInfo newObj = new ICProductsInfo();
                BOSUtil.CopyViewObject(o, newObj);
                products.Add(newObj);
            });
            fld_lkeFK_ICProductID.Properties.DataSource = products;
        }
    }
}
