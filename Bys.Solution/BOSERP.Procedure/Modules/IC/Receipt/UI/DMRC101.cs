using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.Receipt.UI
{
    /// <summary>
    /// Summary description for DMRC101
    /// </summary>
    public partial class DMRC101 : BOSERPScreen
    {

        public DMRC101()
        {
            InitializeComponent();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            ReceiptEntities entity = (ReceiptEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            int productID = 0;
            int productPackageItemID = 0;
            if (fld_lkeFK_ICProductID.EditValue != null)
                int.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out productID);
            if (fld_lkeFK_ICProductPackageItemID.EditValue != null)
                int.TryParse(fld_lkeFK_ICProductPackageItemID.EditValue.ToString(), out productPackageItemID);
            if (productID > 0)
            {
                ICProductPackageItemsController objProductPackageItemsController = new ICProductPackageItemsController();
                ICProductPackageItemsInfo objProductPackageItemsInfo = (ICProductPackageItemsInfo)objProductPackageItemsController.GetObjectByID(productPackageItemID);
                ICReceiptPackageItemsInfo objReceiptPackageItemsInfo = ((Modules.Receipt.ReceiptModule)this.Module).GenReceiptPackageItemFromProductPackageItem(objProductPackageItemsInfo);
                objReceiptPackageItemsInfo.ICReceiptPackageItemTemporaryID = entity.ReceiptPackageItemList.Count + 1;
                entity.ReceiptPackageItemList.Add(objReceiptPackageItemsInfo);
                fld_dgcICReceiptPackageItems.RefreshDataSource();

                if (productPackageItemID > 0)
                {
                    ICProductPackageItemDetailsController objProductPackageItemDetailsController = new ICProductPackageItemDetailsController();
                    List<ICProductPackageItemDetailsInfo> ProductPackageItemDetailsList = (List<ICProductPackageItemDetailsInfo>)objProductPackageItemDetailsController.GetProductPackageItemDetailsListByProductPackageItemID(productPackageItemID);
                    ProductPackageItemDetailsList.ForEach(o =>
                    {
                        ICReceiptPackageItemDetailsInfo objReceiptPackageItemDetailsInfo = ((Modules.Receipt.ReceiptModule)this.Module).GenReceiptPackageItemDetailFromProductPackageItemDetail(o, objReceiptPackageItemsInfo.ICReceiptPackageItemQty);
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
                bool isExistInReceiptItemList = ((Modules.Receipt.ReceiptModule)this.Module).CheckExistInReceiptItemList(productID);
                if (isExistInReceiptItemList == false)
                {
                    MessageBox.Show(InvoiceInLocalizedResources.NoneExistInInvoiceInItemList, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fld_lkeFK_ICProductID.EditValue = 0;
                    return;
                }
                ICProductPackageItemsController objProductPackageItemsController = new ICProductPackageItemsController();
                ICProductPackagesController objProductPackagesController = new ICProductPackagesController();
                List<ICProductPackageItemsInfo> ProductPackageItemList = objProductPackageItemsController.GetProductPackageItemsListByProductID(productID);
                fld_lkeFK_ICProductPackageItemID.Properties.DataSource = ProductPackageItemList;
            }
        }
    }
}
