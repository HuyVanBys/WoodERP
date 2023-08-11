using BOSComponent;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SemiProductReceipt.UI
{
    /// <summary>
    /// Summary description for DMSPRC101
    /// </summary>
    public partial class DMSPRC101 : BOSERPScreen
    {

        public DMSPRC101()
        {
            InitializeComponent();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            SemiProductReceiptEntities entity = (SemiProductReceiptEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            int productID = 0;
            int productPackageItemID = 0;
            if (fld_lkeFK_ICProductID.EditValue != null)
                int.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID);
            if (fld_lkeFK_ICProductPackageItemID.EditValue != null)
                int.TryParse(fld_lkeFK_ICProductPackageItemID.EditValue.ToString(), out productPackageItemID);
            if (productID > 0)
            {
                ICProductPackageItemsController objProductPackageItemsController = new ICProductPackageItemsController();
                ICProductPackageItemsInfo objProductPackageItemsInfo = objProductPackageItemsController.GetProductPackageItemByProductPackageItemID(productPackageItemID);
                ICReceiptPackageItemsInfo objReceiptPackageItemsInfo = ((Modules.SemiProductReceipt.SemiProductReceiptModule)this.Module).GenReceiptPackageItemFromProductPackageItem(objProductPackageItemsInfo);
                objReceiptPackageItemsInfo.ICReceiptPackageItemTemporaryID = entity.ReceiptPackageItemList.Count + 1;
                entity.ReceiptPackageItemList.Add(objReceiptPackageItemsInfo);
                fld_dgcICReceiptPackageItems.RefreshDataSource();

                if (productPackageItemID > 0)
                {
                    ICProductPackageItemDetailsController objProductPackageItemDetailsController = new ICProductPackageItemDetailsController();
                    List<ICProductPackageItemDetailsInfo> ProductPackageItemDetailsList = (List<ICProductPackageItemDetailsInfo>)objProductPackageItemDetailsController.GetProductPackageItemDetailsListByProductPackageItemID(productPackageItemID);
                    ProductPackageItemDetailsList.ForEach(o =>
                    {
                        ICReceiptPackageItemDetailsInfo objReceiptPackageItemDetailsInfo = ((Modules.SemiProductReceipt.SemiProductReceiptModule)this.Module).GenReceiptPackageItemDetailFromProductPackageItemDetail(o, objReceiptPackageItemsInfo.ICReceiptPackageItemQty);
                        objReceiptPackageItemDetailsInfo.FK_ICReceiptPackageItemID = entity.ReceiptPackageItemList.Count;
                        entity.ReceiptPackageItemDetailShowList.Add(objReceiptPackageItemDetailsInfo);
                        fld_dgcICReceiptPackageItemDetails.RefreshDataSource();
                    });
                }
                entity.CountItemsInReceiptPackageItemList++;
            }
        }

        private void fld_lkeFK_ICProductPackageItemID_QueryReceiptpUp(object sender, CancelEventArgs e)
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
                List<ICProductPackageItemsInfo> productPackageItemList = objProductPackageItemsController.GetProductPackageItemsListByProductID(productID);
                productPackageItemList.Insert(0, new ICProductPackageItemsInfo());
                fld_lkeFK_ICProductPackageItemID.Properties.DataSource = productPackageItemList;
            }
        }

        private void fld_lkeFK_ICProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;

            SemiProductReceiptEntities entity = (SemiProductReceiptEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            string productRef = string.Join(",", entity.ReceiptItemsList.Where(o => o.ICReceiptItemHasProductPackage).Select(o => o.FK_ICProductID.ToString()).ToArray());
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> productList = objProductsController.GetProductByProductRefToLookupEdit(productRef);
            productList.Insert(0, new ICProductsInfo());
            lke.Properties.DataSource = productList;
        }

        private void fld_lkeFK_ICProductID_Validated(object sender, EventArgs e)
        {
            int productID = 0;
            if (fld_lkeFK_ICProductID.EditValue != null)
                int.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID);
            if (productID > 0)
            {
                bool isExistInReceiptItemList = ((Modules.SemiProductReceipt.SemiProductReceiptModule)this.Module).CheckExistInReceiptItemList(productID);
                if (isExistInReceiptItemList == false)
                {
                    MessageBox.Show(InvoiceInLocalizedResources.NoneExistInInvoiceInItemList, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fld_lkeFK_ICProductID.EditValue = 0;
                    return;
                }
                ICProductPackageItemsController objProductPackageItemsController = new ICProductPackageItemsController();
                ICProductPackagesController objProductPackagesController = new ICProductPackagesController();
                List<ICProductPackageItemsInfo> productPackageItemList = objProductPackageItemsController.GetProductPackageItemsListByProductID(productID);
                fld_lkeFK_ICProductPackageItemID.Properties.DataSource = productPackageItemList;
            }
        }
    }
}
