using BOSCommon.Constants;
using BOSLib;
using System;

namespace BOSERP.Modules.TransferProposal
{
    public class TransferProposalEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the purchase proposal item list
        /// </summary>
        public BOSList<ICTransferProposalItemsInfo> TransferProposalItemList { get; set; }

        #endregion

        #region Constructor
        public TransferProposalEntities()
            : base()
        {
            TransferProposalItemList = new BOSList<ICTransferProposalItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICTransferProposalsInfo();
            SearchObject = new ICTransferProposalsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICTransferProposalItemsTableName, new ICTransferProposalItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            TransferProposalItemList.InitBOSList(
                                        this,
                                        TableName.ICTransferProposalsTableName,
                                        TableName.ICTransferProposalItemsTableName,
                                        BOSList<ICTransferProposalItemsInfo>.cstRelationForeign);
        }

        public override void InitGridControlInBOSList()
        {
            TransferProposalItemList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ICTransferProposalsInfo objTransferProposalsInfo = (ICTransferProposalsInfo)MainObject;
            objTransferProposalsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objTransferProposalsInfo.ICTransferProposalDate = BOSApp.GetCurrentServerDate();
            objTransferProposalsInfo.ICTransferProposalValidDate = BOSApp.GetCurrentServerDate();
            //objTransferProposalsInfo.ICTransferProposalType = PurchaseProposalType.SaleOrder.ToString();
            //objTransferProposalsInfo.ICTransferProposalStatus = PurchaseProposalStatus.New.ToString();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                TransferProposalItemList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Main Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            TransferProposalItemList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects and Main Object functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            if (TransferProposalItemList.Count > 0)
            {
                TransferProposalItemList.SaveItemObjects();
            }

        }
        #endregion

        public override void SetDefaultValuesFromProduct(int productID, BusinessObject item)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                base.SetDefaultValuesFromProduct(productID, item);
                ICTransferProposalsInfo objTransferProposalsInfo = (ICTransferProposalsInfo)MainObject;
                ICTransferProposalItemsInfo objTransferProposalItemsInfo = (ICTransferProposalItemsInfo)item;
                objTransferProposalItemsInfo.FK_ICFromStockID = objTransferProposalsInfo.FK_ICFromStockID;
                objTransferProposalItemsInfo.FK_ICToStockID = objTransferProposalsInfo.FK_ICToStockID;
                objTransferProposalItemsInfo.FK_ICTransitStockID = objTransferProposalsInfo.FK_ICTransitStockID;
                objTransferProposalItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductPurchaseUnitID;
                objTransferProposalItemsInfo.ICTransferProposalItemProductTransferredQty = 0;
                objTransferProposalItemsInfo.ICTransferProposalItemProductOldQty = 0;
                objTransferProposalItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductSaleUnitID;
                UpdateModuleObjectBindingSource(TableName.ICTransferProposalItemsTableName);
            }
        }
    }
}
