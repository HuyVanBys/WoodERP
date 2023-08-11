using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace BOSERP.Modules.OperationPriceConfig
{
    class OperationPriceConfigModule : BaseTransactionModule
    {
        #region Constants
        #endregion Constants

        #region Private Properties
        BOSButton ButtonAddOperation;
        #endregion Private Properties
        #region Public methods

        public OperationPriceConfigModule()
        {
            Name = "OperationPriceConfig";
            CurrentModuleEntity = new OperationPriceConfigEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            ButtonAddOperation = (BOSButton)Controls["fld_btnAdd"];
            InvalidateToolbar();

        }

        public override int ActionSave()
        {
            OperationPriceConfigEntities entity = (OperationPriceConfigEntities)CurrentModuleEntity;
            MMOperationPriceConfigsInfo objOperationPriceConfigsInfo = (MMOperationPriceConfigsInfo)entity.MainObject;
            EnableToolbar();
            return base.ActionSave();
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            OperationPriceConfigEntities entity = (OperationPriceConfigEntities)CurrentModuleEntity;
            EnableToolbar();
        }
        #endregion Public methods       

        public override void ActionNew()
        {
            base.ActionNew();
            OperationPriceConfigEntities entity = (OperationPriceConfigEntities)CurrentModuleEntity;
            MMOperationPriceConfigsInfo objOperationPriceConfigsInfo = (MMOperationPriceConfigsInfo)CurrentModuleEntity.MainObject;
            objOperationPriceConfigsInfo.MMOperationPriceConfigStatus = BatchProductPlanStatus.New.ToString();
            objOperationPriceConfigsInfo.MMOperationPriceConfigFromDate = BOSUtil.GetMonthBeginDate();
            objOperationPriceConfigsInfo.MMOperationPriceConfigToDate = BOSUtil.GetYearEndDate();
            objOperationPriceConfigsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objOperationPriceConfigsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GEPurchaseCurrencyID;
            objOperationPriceConfigsInfo.MMOperationPriceConfigExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanyPurchaseExchangeRate;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            ButtonAddOperation.Enabled = true;
        }

        public void DeleteItemFromList()
        {
            OperationPriceConfigEntities entity = (OperationPriceConfigEntities)CurrentModuleEntity;
            entity.OperationPriceConfigItemList.RemoveSelectedRowObjectFromList();

        }
        /// <summary>
        /// Approve all items of the BatchProductPlan
        /// </summary>
        public void ApproveOperationPriceConfig()
        {
            OperationPriceConfigEntities entity = (OperationPriceConfigEntities)CurrentModuleEntity;
            entity.ApproveOperationPriceConfig();
            EnableToolbar();
        }
        public void EnableToolbar()
        {
            OperationPriceConfigEntities entity = (OperationPriceConfigEntities)CurrentModuleEntity;
            MMOperationPriceConfigsInfo objOperationPriceConfigsInfo = (MMOperationPriceConfigsInfo)entity.MainObject;
            string status = objOperationPriceConfigsInfo.MMOperationPriceConfigStatus;
            ButtonAddOperation.Enabled = true;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);

            //New
            if (status == MMProposalItemStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
            }
            //Approved
            if (status == MMProposalItemStatus.Approved.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ButtonAddOperation.Enabled = false;
            }
        }
        public void ChangeItemFromOperationPriceConfigItemList()
        {
            OperationPriceConfigEntities entity = (OperationPriceConfigEntities)CurrentModuleEntity;
            entity.OperationPriceConfigItemList.ChangeObjectFromList();
        }

        public void ShowProducts()
        {
            OperationPriceConfigEntities entity = (OperationPriceConfigEntities)CurrentModuleEntity;
            MMOperationPriceConfigsInfo mainObject = (MMOperationPriceConfigsInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> listItem = objProductsController.GetListProductByListProductType();
            guiFind<ICProductsInfo> guiProduct = new guiFind<ICProductsInfo>(TableName.ICProductsTableName, listItem, this, true, true);
            guiProduct.ShowDialog();
            if (guiProduct.DialogResult == DialogResult.OK)
            {
                List<ICProductsInfo> listSelectedItem = guiProduct.SelectedObjects.Where(x => x.Selected).ToList();
                if (listSelectedItem != null && listSelectedItem.Count > 0)
                {
                    listSelectedItem.ForEach(p =>
                    {
                        if (!entity.OperationPriceConfigItemList.Exists("FK_ICProductID", p.ICProductID))
                        {
                            MMOperationPriceConfigItemsInfo obj = new MMOperationPriceConfigItemsInfo();
                            obj.FK_ICProductID = p.ICProductID;
                            obj.FK_ICProductGroupID = p.FK_ICProductGroupID;
                            obj.ICProductNo = p.ICProductNo;
                            obj.ICProductDesc = p.ICProductDesc;
                            obj.FK_MMOperationPriceConfigID = mainObject.MMOperationPriceConfigID;
                            entity.OperationPriceConfigItemList.Add(obj);
                        }
                    });
                    entity.OperationPriceConfigItemList.GridControl?.RefreshDataSource();
                }
            }
        }

        public void ApplyOperationOrMeasureUnitToList(int objectID, bool isOperation, bool isApplyNonValue)
        {
            OperationPriceConfigEntities entity = (OperationPriceConfigEntities)CurrentModuleEntity;
            entity.OperationPriceConfigItemList.ForEach(p =>
            {
                if (isOperation)
                    if (isApplyNonValue && p.FK_MMOperationID == 0) p.FK_MMOperationID = objectID;
                    else p.FK_MMOperationID = objectID;
                else
                {
                    if (isApplyNonValue && p.FK_ICMeasureUnitID == 0) p.FK_ICMeasureUnitID = objectID;
                    else p.FK_ICMeasureUnitID = objectID;
                }
            });
            entity.OperationPriceConfigItemList.GridControl?.RefreshDataSource();
        }
    }
}
