using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.CanceledBatchProposal
{
    public class CanceledBatchProposalEntities : ERPModuleEntities
    {
        #region Public Properties
        public BOSList<MMCanceledProposalItemsInfo> CanceledProposalItemList { get; set; }

        #endregion

        #region Contructors
        public CanceledBatchProposalEntities()
            : base()
        {
            CanceledProposalItemList = new BOSList<MMCanceledProposalItemsInfo>();
            //ProposalItemLumberList = new BOSList<MMProposalItemsInfo>();
            //ProposalTemplatesList = new BOSList<MMProposalTemplatesInfo>();
        }
        #endregion Contructors

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMCanceledProposalsInfo();
            SearchObject = new MMCanceledProposalsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMCanceledProposalItemsTableName, new MMCanceledProposalItemsInfo());

            CanceledProposalItemList.InitBOSList(
                                        this,
                                        TableName.MMCanceledProposalsTableName,
                                        TableName.MMCanceledProposalItemsTableName,
                                        BOSList<MMProposalTemplatesInfo>.cstRelationForeign);
        }

        public override void InitModuleObjectList()
        {
            CanceledProposalItemList.InitBOSList(
                                        this,
                                        TableName.MMCanceledProposalsTableName,
                                        TableName.MMCanceledProposalItemsTableName,
                                        BOSList<MMProposalItemsInfo>.cstRelationForeign);
            CanceledProposalItemList.ItemTableForeignKey = "FK_MMCanceledProposalID";
        }

        public override void InitGridControlInBOSList()
        {
            CanceledProposalItemList.InitBOSListGridControl("fld_dgcMMCanceledProposalItemsGridControl");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            MMCanceledProposalsInfo canceledproposalsInfo = (MMCanceledProposalsInfo)MainObject;
            canceledproposalsInfo.FK_BRBranchID = canceledproposalsInfo.FK_BRBranchID;
            canceledproposalsInfo.MMCanceledProposalDate = DateTime.Now;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                CanceledProposalItemList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Override BaseTransactionEntities

        public override void InvalidateModuleObjects(int iObjectID)
        {

            CanceledProposalItemList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            MMCanceledProposalsInfo objCanceledProposalsInfo = (MMCanceledProposalsInfo)MainObject;
            if (objCanceledProposalsInfo != null)
            {
                CanceledProposalItemList.SaveItemObjects();
            }
        }

        //public override void SetValuesAfterValidateProduct(int productID, BusinessObject item)
        //{
        //    ICProductsController objProductsController = new ICProductsController();
        //    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
        //    if (objProductsInfo != null)
        //    {
        //        MMProposalItemsInfo proposalItem = (MMProposalItemsInfo)item;
        //        SetDefaultValuesFromProduct(productID, proposalItem);
        //        proposalItem.MMProposalItemProductNo = objProductsInfo.ICProductNo;
        //        proposalItem.FK_ARSaleOrderID = 0;
        //        SetProductCost(proposalItem);
        //    }
        //}

        #endregion Override BaseTransactionEntities

        /// <summary>
        /// Approve proposal
        /// </summary>
        public void ApproveProposal()
        {

            SetPropertyChangeEventLock(false);

            //Update the proposal's status
            MMCanceledProposalsInfo objCanceledProposalsInfo = (MMCanceledProposalsInfo)MainObject;
            if (objCanceledProposalsInfo.MMCanceledProposalID > 0)
            {
                objCanceledProposalsInfo.MMCanceledProposalBatchStatus = MMProposalBatchStatus.Approved.ToString();
                UpdateMainObject();
                CanceledProposalItemList.SaveItemObjects();
                CanceledProposalItemList.GridControl?.RefreshDataSource();
            }
        }
    }
}
