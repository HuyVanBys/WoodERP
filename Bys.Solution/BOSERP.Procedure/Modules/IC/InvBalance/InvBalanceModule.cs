using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.InvBalance
{
    public class InvBalanceModule : BaseModuleERP
    {
        public InvBalanceModule()
        {
            Name = "InvBalance";
            CurrentModuleEntity = new InvBalanceEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        public void SaveItem()
        {
            InvBalanceEntities entity = (InvBalanceEntities)CurrentModuleEntity;
            if (entity.InvBalanceList.CurrentIndex < 0)
                return;

            ICInvBalancesInfo objInvBalancesInfo = entity.InvBalanceList[entity.InvBalanceList.CurrentIndex];

            if (objInvBalancesInfo.FK_ICStockID == 0 || objInvBalancesInfo.FK_ICProductID == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin kho và sản phẩm !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ICInvBalancesController controller = new ICInvBalancesController();
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            if (objInvBalancesInfo.ICInvBalanceID > 0)
            {
                controller.UpdateObject(objInvBalancesInfo);

                ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(objInvBalancesInfo.FK_ICProductID, objInvBalancesInfo.ICInvBalanceReceiptSerialNo);
                if (objProductSeriesInfo != null)
                {
                    decimal height = 0;
                    decimal Width = 0;
                    decimal Length = 0;
                    if (!string.IsNullOrEmpty(objInvBalancesInfo.ICInvBalanceCode08Combo)) decimal.TryParse(objInvBalancesInfo.ICInvBalanceCode08Combo, out height);
                    if (!string.IsNullOrEmpty(objInvBalancesInfo.ICInvBalanceCode09Combo)) decimal.TryParse(objInvBalancesInfo.ICInvBalanceCode09Combo, out Width);
                    if (!string.IsNullOrEmpty(objInvBalancesInfo.ICInvBalanceCode10Combo)) decimal.TryParse(objInvBalancesInfo.ICInvBalanceCode10Combo, out Length);

                    objProductSeriesInfo.AAUpdatedDate = DateTime.Now;
                    objProductSeriesInfo.ICProductSerieReceiptDate = objInvBalancesInfo.ICInvBalanceDate;
                    objProductSeriesInfo.ICProductSerieLotNo = objInvBalancesInfo.ICInvBalanceReceiptLotNo;
                    objProductSeriesInfo.FK_MMBatchProductID = objInvBalancesInfo.FK_MMBatchProductID;
                    objProductSeriesInfo.FK_MMOperationID = objInvBalancesInfo.FK_MMOperationID;
                    objProductSeriesInfo.ICProductSerieProductHeight = height> 0 ? height : objProductSeriesInfo.ICProductSerieProductHeight;
                    objProductSeriesInfo.ICProductSerieProductWidth = Width > 0 ? Width : objProductSeriesInfo.ICProductSerieProductWidth; ;
                    objProductSeriesInfo.ICProductSerieProductLength = Length > 0 ? Length :  objProductSeriesInfo.ICProductSerieProductLength; 
                    objProductSeriesController.UpdateObject(objProductSeriesInfo);
                }
                else
                {
                    objProductSeriesController.GenerateProductSerieByInvBalanceID(objInvBalancesInfo.ICInvBalanceID);
                }

                return;
            }
            controller.CreateObject(objInvBalancesInfo);

            objProductSeriesController.GenerateProductSerieByInvBalanceID(objInvBalancesInfo.ICInvBalanceID);
        }

        public void DeleteItem()
        {
            InvBalanceEntities entity = (InvBalanceEntities)CurrentModuleEntity;
            if (entity.InvBalanceList.CurrentIndex < 0)
                return;
            ICInvBalancesInfo objInvBalancesInfo = entity.InvBalanceList[entity.InvBalanceList.CurrentIndex];
            ICInvBalancesController controller = new ICInvBalancesController();
            controller.DeleteObject(objInvBalancesInfo.ICInvBalanceID);

            entity.InvBalanceList.RemoveSelectedRowObjectFromList();
        }

        public void ChangedProduct()
        {
            InvBalanceEntities entity = (InvBalanceEntities)CurrentModuleEntity;
            if (entity.InvBalanceList.CurrentIndex < 0)
                return;
            ICInvBalancesInfo objInvBalancesInfo = entity.InvBalanceList[entity.InvBalanceList.CurrentIndex];

            if (objInvBalancesInfo.FK_ICProductID == 0)
                return;
            ICProductsController productController = new ICProductsController();
            ICProductsInfo product = (ICProductsInfo)productController.GetObjectByID(objInvBalancesInfo.FK_ICProductID);
            if (product == null)
                return;
            objInvBalancesInfo.ICProductName = product.ICProductName;
            objInvBalancesInfo.ICProductDesc = product.ICProductDesc;
            objInvBalancesInfo.FK_ICMeasureUnitID = product.FK_ICProductBasicUnitID;
            objInvBalancesInfo.FK_ACAccountID = product.FK_ACAccountID;
        }

        public void ChangedItem()
        {
            InvBalanceEntities entity = (InvBalanceEntities)CurrentModuleEntity;
            if (entity.InvBalanceList.CurrentIndex < 0)
                return;
            ICInvBalancesInfo objInvBalancesInfo = entity.InvBalanceList[entity.InvBalanceList.CurrentIndex];
            UpdateAmount(objInvBalancesInfo);
        }

        private void UpdateAmount(ICInvBalancesInfo item)
        {
            item.ICInvBalanceExchangeQty = item.ICInvBalanceQty * item.ICInvBalanceFactor;
            item.ICInvBalanceTotalCost = item.ICInvBalanceQty * item.ICInvBalanceUnitCost;
            item.ICInvBalanceExchangeUnitCost = item.ICInvBalanceUnitCost * item.ICInvBalanceExchangeRate / item.ICInvBalanceFactor;
            item.ICInvBalanceExchangeTotalCost = item.ICInvBalanceTotalCost * item.ICInvBalanceExchangeRate;
        }

        public void ChangeItemMeasureUnit()
        {
            InvBalanceEntities entity = (InvBalanceEntities)CurrentModuleEntity;
            if (entity.InvBalanceList.CurrentIndex < 0)
                return;
            ICInvBalancesInfo objInvBalancesInfo = entity.InvBalanceList[entity.InvBalanceList.CurrentIndex];

            ICProductMeasureUnitsController controller = new ICProductMeasureUnitsController();
            ICProductMeasureUnitsInfo measureUnit = controller.GetProductMeasureUnitByProductIDAndMeasureUnitID(objInvBalancesInfo.FK_ICProductID, objInvBalancesInfo.FK_ICMeasureUnitID);
            objInvBalancesInfo.ICInvBalanceFactor = (measureUnit != null && measureUnit.ICProductMeasureUnitFactor > 0)
                                                ? measureUnit.ICProductMeasureUnitFactor
                                                : 1;

        }
    }
}
