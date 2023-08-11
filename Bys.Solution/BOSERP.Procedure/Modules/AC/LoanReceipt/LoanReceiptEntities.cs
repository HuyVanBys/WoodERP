using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.LoanReceipt
{
    public class LoanReceiptEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the account list
        /// </summary>
        public BOSList<ACLoanReceiptItemsInfo> LoanReceiptItemList { get; set; }
        public BOSList<ACLoanReceiptPayDocsInfo> LoanReceiptPayDocList { get; set; }
        public BOSList<ACLoanReceiptPaymentPlansInfo> LoanReceiptPaymentPlanList { get; set; }
        public BOSList<ACFileAttachmentsInfo> LoanReceiptTemplateList { get; set; }
        public Dictionary<int, string> LoanReceiptTemplateURLDic { get; set; }
        public BOSList<ACLoanReceiptInterestRateChangesInfo> LoanReceiptInterestRateChangesList { get; set; }
        #endregion

        #region Constructor
        public LoanReceiptEntities()
            : base()
        {
            LoanReceiptItemList = new BOSList<ACLoanReceiptItemsInfo>();
            LoanReceiptPayDocList = new BOSList<ACLoanReceiptPayDocsInfo>();
            LoanReceiptPaymentPlanList = new BOSList<ACLoanReceiptPaymentPlansInfo>();
            LoanReceiptTemplateList = new BOSList<ACFileAttachmentsInfo>();
            LoanReceiptInterestRateChangesList = new BOSList<ACLoanReceiptInterestRateChangesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACLoanReceiptsInfo();
            SearchObject = new ACLoanReceiptsInfo();
        }
        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACLoanReceiptItemsTableName, new ACLoanReceiptItemsInfo());
            ModuleObjects.Add(TableName.ACLoanReceiptPayDocsTableName, new ACLoanReceiptPayDocsInfo());
            ModuleObjects.Add(TableName.ACLoanReceiptPaymentPlansTableName, new ACLoanReceiptPaymentPlansInfo());
            ModuleObjects.Add(TableName.ACLoanReceiptInterestRateChangesTableName, new ACLoanReceiptInterestRateChangesInfo());
        }

        public override void InitModuleObjectList()
        {
            LoanReceiptItemList.InitBOSList(
                                        this,
                                        TableName.ACLoanReceiptsTableName,
                                        TableName.ACLoanReceiptItemsTableName,
                                        BOSList<ACLoanReceiptItemsInfo>.cstRelationForeign);
            LoanReceiptItemList.ItemTableForeignKey = "FK_ACLoanReceiptID";
            LoanReceiptPayDocList.InitBOSList(
                                        this,
                                        TableName.ACLoanReceiptsTableName,
                                        TableName.ACLoanReceiptPayDocsTableName,
                                        BOSList<ACLoanReceiptPayDocsInfo>.cstRelationForeign);
            LoanReceiptPayDocList.ItemTableForeignKey = "FK_ACLoanReceiptID";

            LoanReceiptPaymentPlanList.InitBOSList(
                                       this,
                                       TableName.ACLoanReceiptsTableName,
                                       TableName.ACLoanReceiptPaymentPlansTableName,
                                       BOSList<ACLoanReceiptPaymentPlansInfo>.cstRelationForeign);
            LoanReceiptPaymentPlanList.ItemTableForeignKey = "FK_ACLoanReceiptID";

            LoanReceiptTemplateList.InitBOSList(
                                            this,
                                            TableName.ACLoanReceiptsTableName,
                                            TableName.ACFileAttachmentsTableName,
                                            BOSList<ACFileAttachmentsInfo>.cstRelationForeign);
            LoanReceiptTemplateList.ItemTableForeignKey = "FK_ACLoanReceiptID";

            LoanReceiptInterestRateChangesList.InitBOSList(
                                            this,
                                            TableName.ACLoanReceiptsTableName,
                                            TableName.ACLoanReceiptInterestRateChangesTableName,
                                            BOSList<ACFileAttachmentsInfo>.cstRelationForeign);
            LoanReceiptInterestRateChangesList.ItemTableForeignKey = "FK_ACLoanReceiptID";
        }

        public override void InitGridControlInBOSList()
        {
            LoanReceiptItemList.InitBOSListGridControl(LoanReceiptModule.LoanReceiptItemGridControlName);
            LoanReceiptPayDocList.InitBOSListGridControl(LoanReceiptModule.LoanReceiptPayDocsGridControlName);
            LoanReceiptPaymentPlanList.InitBOSListGridControl(LoanReceiptModule.ACLoanReceiptPaymentPlansGridControlName);
            LoanReceiptTemplateList.InitBOSListGridControl(LoanReceiptModule.LoanReceiptTemplateGridControlName);
            LoanReceiptInterestRateChangesList.InitBOSListGridControl(LoanReceiptModule.LoanReceiptInterestRateChangesGridControlName);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)MainObject;
            objLoanReceiptsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objLoanReceiptsInfo.ACLoanReceiptDate = BOSApp.GetCurrentServerDate();
            objLoanReceiptsInfo.ACLoanReceiptDeadline = BOSApp.GetCurrentServerDate();
            objLoanReceiptsInfo.ACLoanReceiptExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objLoanReceiptsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GECurrencyID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                LoanReceiptItemList.SetDefaultListAndRefreshGridControl();
                LoanReceiptPayDocList.SetDefaultListAndRefreshGridControl();
                LoanReceiptPaymentPlanList.SetDefaultListAndRefreshGridControl();
                LoanReceiptTemplateList.SetDefaultListAndRefreshGridControl();
                LoanReceiptInterestRateChangesList.SetDefaultListAndRefreshGridControl();
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
            LoanReceiptItemList.Invalidate(iObjectID);
            LoanReceiptPayDocList.Invalidate(iObjectID);
            LoanReceiptPaymentPlanList.Invalidate(iObjectID);
            LoanReceiptInterestRateChangesList.Invalidate(iObjectID);
            (Module as LoanReceiptModule).InvalidateNumberFormat();

            ACLoanReceiptsInfo mainObject = (ACLoanReceiptsInfo)MainObject;
            ACFileAttachmentsController objFileAttachmentsController = new ACFileAttachmentsController();
            List<ACFileAttachmentsInfo> fileAttachmentList = objFileAttachmentsController.GetFileAttachmentByModuleAndObjectRef(this.Module.Name, BOSUtil.GetTableNameFromBusinessObject(mainObject), mainObject.ACLoanReceiptID, 0);
            LoanReceiptTemplateList.Invalidate(fileAttachmentList);
        }
        #endregion

        #region Save Module Objects Functions
        public override void SaveModuleObjects()
        {
            ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)MainObject;
            ACLoanAgreementsController objLoanAgreementsController = new ACLoanAgreementsController();
            LoanReceiptItemList.SaveItemObjects();
            LoanReceiptPayDocList.SaveItemObjects();
            LoanReceiptPaymentPlanList.SaveItemObjects();
            LoanReceiptInterestRateChangesList.SaveItemObjects();
            if (objLoanReceiptsInfo.FK_ACLoanAgreementID > 0)
            {
                objLoanAgreementsController.UpdateLoanAgreementForLoanAgreementReceiptAmount(objLoanReceiptsInfo.FK_ACLoanAgreementID);
            }
            LoanReceiptTemplateList.SaveItemObjects();
            LoanReceiptTemplateURLDic = LoanReceiptTemplateList.ToDictionary(o => o.ACFileAttachmentID, o => o.FullPathFile);
        }
        #endregion

        public void UpdateTotalCost()
        {
            ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)MainObject;
            objLoanReceiptsInfo.ACLoanReceiptRemainAmount = objLoanReceiptsInfo.ACLoanReceiptAmount - objLoanReceiptsInfo.ACLoanReceiptOpeningPaidAmount - objLoanReceiptsInfo.ACLoanReceiptPaidAmount;
            BOSApp.RoundByCurrency(objLoanReceiptsInfo, "ACLoanReceiptRemainAmount", objLoanReceiptsInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }
    }
}
