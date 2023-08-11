using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.Shipment.UI
{
    /// <summary>
    /// Summary description for DMSH101
    /// </summary>
    public partial class DMSH101 : BOSERPScreen
    {

        public DMSH101()
        {
            InitializeComponent();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            ShipmentEntities entity = (ShipmentEntities)((BaseModuleERP)Module).CurrentModuleEntity;
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
                ICShipmentPackageItemsInfo objShipmentPackageItemsInfo = ((Modules.Shipment.ShipmentModule)this.Module).GenShipmentPackageItemFromProductPackageItem(objProductPackageItemsInfo);
                objShipmentPackageItemsInfo.ICShipmentPackageItemTemporaryID = entity.ShipmentPackageItemList.Count + 1;
                entity.ShipmentPackageItemList.Add(objShipmentPackageItemsInfo);
                fld_dgcICShipmentPackageItems.RefreshDataSource();

                if (productPackageItemID > 0)
                {
                    ICProductPackageItemDetailsController objProductPackageItemDetailsController = new ICProductPackageItemDetailsController();
                    List<ICProductPackageItemDetailsInfo> ProductPackageItemDetailsList = (List<ICProductPackageItemDetailsInfo>)objProductPackageItemDetailsController.GetProductPackageItemDetailsListByProductPackageItemID(productPackageItemID);
                    ProductPackageItemDetailsList.ForEach(o =>
                    {
                        ICShipmentPackageItemDetailsInfo objShipmentPackageItemDetailsInfo = ((Modules.Shipment.ShipmentModule)this.Module).GenShipmentPackageItemDetailFromProductPackageItemDetail(o, objShipmentPackageItemsInfo.ICShipmentPackageItemQty);
                        objShipmentPackageItemDetailsInfo.FK_ICShipmentPackageItemID = entity.ShipmentPackageItemList.Count;
                        entity.ShipmentPackageItemDetailShowList.Add(objShipmentPackageItemDetailsInfo);
                        fld_dgcICShipmentPackageItemDetails.RefreshDataSource();
                    });
                }
                entity.CountItemsInShipmentPackageItemList++;
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
                bool isExistInShipmentItemList = ((Modules.Shipment.ShipmentModule)this.Module).CheckExistInShipmentItemList(productID);
                if (isExistInShipmentItemList == false)
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
