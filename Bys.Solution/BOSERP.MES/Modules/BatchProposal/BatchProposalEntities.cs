using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.BatchProposal
{
    public class BatchProposalEntities : ERPModuleEntities
    {
        #region Public Properties
        public BOSList<MMProposalItemsInfo> ProposalItemList { get; set; }
        public BOSList<MMProposalTemplatesInfo> ProposalTemplatesList { get; set; }
        public Dictionary<int, string> ProposalTemplateURLDic { get; set; }


        #endregion

        #region Contructors
        public BatchProposalEntities()
            : base()
        {
            ProposalItemList = new BOSList<MMProposalItemsInfo>();
            ProposalTemplatesList = new BOSList<MMProposalTemplatesInfo>();
            ProposalTemplateURLDic = new Dictionary<int, string>();
        }
        #endregion Contructors

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMProposalsInfo();
            SearchObject = new MMProposalsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMProposalItemsTableName, new MMProposalItemsInfo());

            //ModuleObjects.Add(TableName.MMProposalTemplatesTableName, new MMProposalTemplatesInfo());

            ProposalTemplatesList.InitBOSList(
                                        this,
                                        TableName.MMProposalsTableName,
                                        TableName.MMProposalTemplatesTableName,
                                        BOSList<MMProposalTemplatesInfo>.cstRelationForeign);
        }

        public override void InitModuleObjectList()
        {
            ProposalItemList.InitBOSList(
                                        this,
                                        TableName.MMProposalsTableName,
                                        TableName.MMProposalItemsTableName,
                                        BOSList<MMProposalItemsInfo>.cstRelationForeign);
            ProposalItemList.ItemTableForeignKey = "FK_MMProposalID";
        }

        public override void InitGridControlInBOSList()
        {
            ProposalItemList.InitBOSListGridControl("fld_dgcMMProposalItemsGridControl");
            ProposalTemplatesList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            MMProposalsInfo proposalsInfo = (MMProposalsInfo)MainObject;
            proposalsInfo.FK_BRBranchID = proposalsInfo.FK_BRBranchID;
            proposalsInfo.MMProposalDate = BOSApp.GetCurrentServerDate();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ProposalItemList.SetDefaultListAndRefreshGridControl();
                ProposalTemplatesList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Override BaseTransactionEntities
        public override string GetMainObjectNo(ref int numberingStart)
        {
            string mainObjectNo = base.GetMainObjectNo(ref numberingStart);
            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)MainObject;
            string[] objectNo = mainObjectNo.Split('-');
            if (objectNo != null && objectNo.Length > 1)
            {
                if (objProposalsInfo != null && objProposalsInfo.MMProposalType == SaleOrderType.FOCSample.ToString() ||
                    objProposalsInfo != null && objProposalsInfo.MMProposalType == SaleOrderType.PaymentSample.ToString() ||
                    objProposalsInfo != null && objProposalsInfo.MMProposalType == SaleOrderType.PaymentSpareSample.ToString() ||
                    objProposalsInfo != null && objProposalsInfo.MMProposalType == SaleOrderType.SpareFOCSample.ToString())
                {
                    mainObjectNo = objectNo[0] + ".M" + "-" + objectNo[1];
                }
                else
                {
                    mainObjectNo = objectNo[0] + ".D" + "-" + objectNo[1];
                }
            }
            return mainObjectNo;
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)MainObject;
            objProposalsInfo.ACObjectAccessKey = objProposalsInfo.FK_ACObjectID + ";" + objProposalsInfo.MMObjectType;
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ProposalItemList.Invalidate(iObjectID);
            //Invalidate sale order templates list
            ProposalTemplatesList.Invalidate(iObjectID);
            foreach (MMProposalTemplatesInfo objProposalTemplatesInfo in ProposalTemplatesList)
            {
                BaseTransactionModule objBaseTransactionModule = new BaseTransactionModule();
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objBaseTransactionModule.GetEmployeeByUsername(objProposalTemplatesInfo.AACreatedUser);
                string SaleForecastID = objProposalTemplatesInfo.FK_MMProposalID.ToString();
                objProposalTemplatesInfo.MMProposalTemplateName = objProposalTemplatesInfo.MMProposalTemplateName.Replace(SaleForecastID + "_", "");
                objProposalTemplatesInfo.UserCreatedFullname = objEmployeesInfo.HREmployeeName;
            }
        }

        public override void SaveModuleObjects()
        {
            ProposalItemList.SaveItemObjects();
            ProposalTemplatesList.SaveItemObjects();
            ProposalTemplateURLDic = ProposalTemplatesList.ToDictionary(o => o.MMProposalTemplateID, o => o.FullPathFile);
        }

        public override void SetValuesAfterValidateProduct(int productID, BusinessObject item)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                MMProposalItemsInfo proposalItem = (MMProposalItemsInfo)item;
                SetDefaultValuesFromProduct(productID, proposalItem);
                proposalItem.MMProposalItemProductUnitPrice = objProductsInfo.ICProductPrice01;
                proposalItem.MMProposalItemProductNo = objProductsInfo.ICProductNo;
                proposalItem.FK_ARSaleOrderID = 0;
                SetProductCost(proposalItem);
            }
        }
        /// <summary>
        /// Save a template to database
        /// </summary>
        public void SaveTemplate(MMProposalTemplatesInfo objProposalTemplatesInfo)
        {
            MMProposalsInfo objBatchsInfo = (MMProposalsInfo)MainObject;
            MMProposalTemplatesController objProposalTemplatesController = new MMProposalTemplatesController();
            if (objProposalTemplatesInfo.FK_MMProposalID == 0)
            {
                objProposalTemplatesInfo.AACreatedUser = BOSApp.CurrentUser;
                objProposalTemplatesInfo.AACreatedDate = DateTime.Now;
                objProposalTemplatesInfo.FK_MMProposalID = objBatchsInfo.MMProposalID;
                objProposalTemplatesController.CreateObject(objProposalTemplatesInfo);
            }
            else
            {
                objProposalTemplatesInfo.AAUpdatedUser = BOSApp.CurrentUser;
                objProposalTemplatesInfo.AAUpdatedDate = DateTime.Now;
                objProposalTemplatesController.UpdateObject(objProposalTemplatesInfo);
            }
            ProposalTemplatesList.GridControl?.RefreshDataSource();
        }
        #endregion Override BaseTransactionEntities


        //[TTLoi][Add Document][06/11/2014] BEGIN


        /// <summary>
        /// Approve proposal
        /// </summary>
        public void ApproveProposal()
        {
            SetPropertyChangeEventLock(false);

            MMProposalsInfo objProposalsInfo = (MMProposalsInfo)MainObject;
            if (objProposalsInfo.MMProposalID > 0)
            {
                objProposalsInfo.MMProposalBatchStatus = MMProposalBatchStatus.Approved.ToString();
                UpdateMainObject();
                ProposalItemList.SaveItemObjects();
                ProposalItemList.GridControl?.RefreshDataSource();
            }
            SetPropertyChangeEventLock(true);
        }
    }
}
