using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.PurchaseContract
{
    public class PurchaseContractEntities : BaseTransactionEntities
    {
        #region Declare all entities variables

        public BOSList<APFileAttachmentsInfo> PurchaseContractTemplate { get; set; }

        public Dictionary<int, string> PurchaseContractTemplateURLDic { get; set; }
        #endregion

        #region Public Properties

        #endregion
        #region Constructor
        public PurchaseContractEntities()
            : base()
        {
            PurchaseContractTemplate = new BOSList<APFileAttachmentsInfo>();
            PurchaseContractTemplateURLDic = new Dictionary<int, string>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            SearchObject = new APPurchaseContractsInfo();
            MainObject = new APPurchaseContractsInfo();
        }

        public override void InitModuleObjectList()
        {
            PurchaseContractTemplate.InitBOSList(this,
                                                 null,
                                                 TableName.APFileAttachmentsTableName,
                                                 BOSList<APFileAttachmentsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            PurchaseContractTemplate.InitBOSListGridControl("fld_dgcFileAttachmentsGridControl");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                PurchaseContractTemplate.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception) { }
        }

        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            APPurchaseContractsInfo mainobject = (APPurchaseContractsInfo)MainObject;
            mainobject.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            mainobject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            mainobject.APPurchaseContractDate = BOSApp.GetCurrentServerDate();
            mainobject.APPurchaseContractBeginDate = BOSApp.GetCurrentServerDate();
            mainobject.APPurchaseContractEndDate = BOSApp.GetCurrentServerDate();
            UpdateMainObjectBindingSource();
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            APPurchaseContractsInfo mainobject = (APPurchaseContractsInfo)MainObject;
            APFileAttachmentsController objFileAttachmentsController = new APFileAttachmentsController();
            List<APFileAttachmentsInfo> fileAttachmentList = objFileAttachmentsController.GetFileAttachmentByModuleAndObjectRef(ModuleName.PurchaseContract, BOSUtil.GetTableNameFromBusinessObject(mainobject), mainobject.APPurchaseContractID, 0);
            PurchaseContractTemplate.Invalidate(fileAttachmentList);
        }

        public override void SaveModuleObjects()
        {
            PurchaseContractTemplate.SaveItemObjects();
            PurchaseContractTemplateURLDic = PurchaseContractTemplate.ToDictionary(o => o.APFileAttachmentID, o => o.FullPathFile);
        }
        #region Invalidate Module Objects functions
        #endregion
    }
}
