using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.InventoryAdjustment
{
    class InventoryAdjustmentModule : BaseTransactionModule
    {
        #region Constant 
        #region Adjustment Type Constants
        public const string cstAdjustmentTypeQty = "Qty";
        public const string cstAdjustmentTypeCost = "Cost";
        #endregion

        #region Adjustment Status Constants
        public const string cstAdjustmentStatusNew = "New";
        public const string cstAdjustmentStatusComplete = "Complete";
        #endregion
        #endregion

        public InventoryAdjustmentModule()
        {
            Name = "InventoryAdjustment";
            CurrentModuleEntity = new InventoryAdjustmentEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        #region Local
        public void AddItemToAdjustmentItemsList()
        {
            InventoryAdjustmentEntities entity = (InventoryAdjustmentEntities)CurrentModuleEntity;
            ICAdjustmentItemsInfo objAdjustmentItemsInfo = (ICAdjustmentItemsInfo)entity.ModuleObjects[InventoryAdjustmentEntities.strICAdjustmentItemsObjectName];
            if (objAdjustmentItemsInfo.FK_ICProductID > 0)
            {
                entity.SetValuesAfterValidateProduct(objAdjustmentItemsInfo.FK_ICProductID);
                entity.ICAdjustmentItemsList.AddObjectToList();
                entity.UpdateProductQty();
            }
        }

        public void ChangeItemFromAdjustmentItemsList()
        {
            InventoryAdjustmentEntities entity = (InventoryAdjustmentEntities)CurrentModuleEntity;
            ICAdjustmentItemsInfo objAdjustmentItemsInfo = (ICAdjustmentItemsInfo)entity.ModuleObjects[InventoryAdjustmentEntities.strICAdjustmentItemsObjectName];
            objAdjustmentItemsInfo.ICAdjustmentItemProductDiffQty = objAdjustmentItemsInfo.ICAdjustmentItemProductOldQty - objAdjustmentItemsInfo.ICAdjustmentItemProductQty;
            objAdjustmentItemsInfo.ICAdjustmentItemDiffTotalCost = objAdjustmentItemsInfo.ICAdjustmentItemProductDiffQty * objAdjustmentItemsInfo.ICAdjustmentItemProductUnitCost;
            entity.ICAdjustmentItemsList.ChangeObjectFromList();
            entity.UpdateProductQty();
        }

        public void DeleteItemFromAdjustmentItemsList()
        {
            InventoryAdjustmentEntities entity = (InventoryAdjustmentEntities)CurrentModuleEntity;
            entity.ICAdjustmentItemsList.RemoveSelectedRowObjectFromList();
            entity.UpdateProductQty();
        }
        #endregion

        public override void ActionEdit()
        {
            InventoryAdjustmentEntities entity = (InventoryAdjustmentEntities)CurrentModuleEntity;
            if ((entity.MainObject as ICAdjustmentsInfo).ICAdjustmentStatus == InventoryAdjustmentModule.cstAdjustmentStatusComplete)
            {
                MessageBox.Show("The adjustment has been completed and can not modify", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                CurrentModuleEntity.SetPropertyChangeEventLock(false);
                return;
            }

            base.ActionEdit();
        }

        public override bool ActionComplete()
        {
            if (Toolbar.CurrentObjectID > 0)
            {
                InventoryAdjustmentEntities entity = (InventoryAdjustmentEntities)CurrentModuleEntity;
                if ((entity.MainObject as ICAdjustmentsInfo).ICAdjustmentStatus == InventoryAdjustmentModule.cstAdjustmentStatusComplete)
                {
                    MessageBox.Show("The adjustment has been completed", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (MessageBox.Show("Do you want to complete the adjustment?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (base.ActionComplete())
                    {
                        MessageBox.Show("Complete successfully. The inventory has been updated", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
