using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.BugManagement
{
    public class BugManagementEntities : BaseTransactionEntities
    {
        public BOSList<HRBugManagementTemplatesInfo> BugManagementTemplatesList { get; set; }
        public BugManagementEntities()
            : base()
        {
            BugManagementTemplatesList = new BOSList<HRBugManagementTemplatesInfo>();
        }

        public override void InitMainObject()
        {
            MainObject = new HRBugManagementsInfo();
            SearchObject = new HRBugManagementsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRBugManagementTemplatesTableName, new HRBugManagementTemplatesInfo());
        }

        public override void InitModuleObjectList()
        {
            BugManagementTemplatesList.InitBOSList(this,
                                                TableName.HRBugManagementsTableName,
                                                TableName.HRBugManagementTemplatesTableName,
                                                BOSList<HRBugManagementTemplatesInfo>.cstRelationForeign);
            BugManagementTemplatesList.ItemTableForeignKey = "FK_HRBugManagementID";
        }

        public override void InitGridControlInBOSList()
        {
            BugManagementTemplatesList.InitBOSListGridControl("fld_dgcHRBugManagementTemplates");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            HRBugManagementsInfo objBugManagementsInfo = (HRBugManagementsInfo)MainObject;
            objBugManagementsInfo.HRBugManagementDate = BOSApp.GetCurrentServerDate();
            objBugManagementsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objBugManagementsInfo.HRBugManagementStatus = "New";
            UpdateMainObjectBindingSource();
        }

        public override void SetDefaultModuleObjects()
        {
            base.SetDefaultModuleObjects();
            try
            {
                BugManagementTemplatesList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void SaveModuleObjects()
        {
            BugManagementTemplatesList.SaveItemObjects();

        }
        public override bool CompleteTransaction()
        {
            HRBugManagementsInfo objBugManagementsInfo = (HRBugManagementsInfo)MainObject;

            SetPropertyChangeEventLock(false);
            objBugManagementsInfo.HRBugManagementStatus = "Approved";
            UpdateMainObject();
            SetPropertyChangeEventLock(true);

            return base.CompleteTransaction();
        }
        public override void InvalidateModuleObjects(int iObjectID)
        {
            BugManagementTemplatesList.Invalidate(iObjectID);
            foreach (HRBugManagementTemplatesInfo objBugManagementTemplatesInfo in BugManagementTemplatesList)
            {
                BaseTransactionModule objBaseTransactionModule = new BaseTransactionModule();
                string documentID = objBugManagementTemplatesInfo.FK_HRBugManagementID.ToString();
                objBugManagementTemplatesInfo.HRBugManagementTemplateName = objBugManagementTemplatesInfo.HRBugManagementTemplateName.Replace(documentID + "_", "");
            }
        }
        public void SaveTemplate(HRBugManagementTemplatesInfo objBugManagementTemplatesInfo)
        {
            HRBugManagementsInfo objBugManagementsInfo = (HRBugManagementsInfo)MainObject;
            HRBugManagementTemplatesController objBugManagementTemplatesController = new HRBugManagementTemplatesController();
            if (objBugManagementTemplatesInfo.HRBugManagementTemplateID == 0)
            {
                objBugManagementTemplatesInfo.FK_HREmployeeID = objBugManagementsInfo.FK_HREmployeeID;
                objBugManagementTemplatesInfo.AACreatedDate = DateTime.Now;
                objBugManagementTemplatesInfo.FK_HRBugManagementID = objBugManagementsInfo.HRBugManagementID;
                objBugManagementTemplatesController.CreateObject(objBugManagementTemplatesInfo);
            }
            else
            {
                objBugManagementTemplatesInfo.FK_HREmployeeID = objBugManagementsInfo.FK_HREmployeeID;
                objBugManagementTemplatesInfo.AAUpdatedDate = DateTime.Now;
                objBugManagementTemplatesController.UpdateObject(objBugManagementTemplatesInfo);
            }
        }
    }
}
