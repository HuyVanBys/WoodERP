using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.InvoiceIn.UI
{
    /// <summary>
    /// Summary description for DMII101
    /// </summary>
    public partial class DMII101 : BOSERPScreen
    {

        public DMII101()
        {
            InitializeComponent();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            InvoiceInEntities entity = (InvoiceInEntities)((BaseModuleERP)Module).CurrentModuleEntity;
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
                APInvoiceInPackageItemsInfo objInvoiceInPackageItemsInfo = ((Modules.InvoiceIn.InvoiceInModule)this.Module).GenInvoiceInPackageItemFromProductPackageItem(objProductPackageItemsInfo);
                objInvoiceInPackageItemsInfo.APInvoiceInPackageItemTemporaryID = entity.InvoiceInPackageItemList.Count + 1;
                entity.InvoiceInPackageItemList.Add(objInvoiceInPackageItemsInfo);
                fld_dgcAPInvoiceInPackageItems.RefreshDataSource();

                if (productPackageItemID > 0)
                {
                    ICProductPackageItemDetailsController objProductPackageItemDetailsController = new ICProductPackageItemDetailsController();
                    List<ICProductPackageItemDetailsInfo> ProductPackageItemDetailsList = (List<ICProductPackageItemDetailsInfo>)objProductPackageItemDetailsController.GetProductPackageItemDetailsListByProductPackageItemID(productPackageItemID);
                    ProductPackageItemDetailsList.ForEach(o =>
                    {
                        APInvoiceInPackageItemDetailsInfo objInvoiceInPackageItemDetailsInfo = ((Modules.InvoiceIn.InvoiceInModule)this.Module).GenInvoiceInPackageItemDetailFromProductPackageItemDetail(o, objInvoiceInPackageItemsInfo.APInvoiceInPackageItemQty);
                        objInvoiceInPackageItemDetailsInfo.FK_APInvoiceInPackageItemID = entity.InvoiceInPackageItemList.Count;
                        entity.InvoiceInPackageItemDetailShowList.Add(objInvoiceInPackageItemDetailsInfo);
                        fld_dgcAPInvoiceInPackageItemDetails.RefreshDataSource();
                    });
                }
                entity.CountItemsInInvoiceInPackageItemList++;
            }
        }

        private void fld_lkeFK_ICProductPackageItemID_QueryInvoiceInpUp(object sender, CancelEventArgs e)
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
                bool isExistInInvoiceInItemList = ((Modules.InvoiceIn.InvoiceInModule)this.Module).CheckExistInInvoiceInItemList(productID);
                if (!isExistInInvoiceInItemList)
                {
                    MessageBox.Show(InvoiceInLocalizedResources.NoneExistInInvoiceInItemList, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
