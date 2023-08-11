using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;

namespace BOSERP.Modules.RecruitmentPlan
{
    public class RecruitmentPlanEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the list of canceled items
        /// </summary>
        public BOSItemsEntityList<HRRecruitmentPlanItemsInfo> RecruitmentPlanItemsList { get; set; }
        #endregion

        #region Constructor
        public RecruitmentPlanEntities()
            : base()
        {
            RecruitmentPlanItemsList = new BOSItemsEntityList<HRRecruitmentPlanItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            SearchObject = new HRRecruitmentPlansInfo();
            MainObject = new HRRecruitmentPlansInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRRecruitmentPlanItemsTableName, new HRRecruitmentPlanItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            RecruitmentPlanItemsList.InitBOSList(this,
                                            TableName.HRRecruitmentPlansTableName,
                                            TableName.HRRecruitmentPlanItemsTableName,
                                            BOSList<HRRecruitmentPlanItemsInfo>.cstRelationForeign);
        }

        public override void InitGridControlInBOSList()
        {
            RecruitmentPlanItemsList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                RecruitmentPlanItemsList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            HRRecruitmentPlansInfo objRecruitmentPlansInfo = (HRRecruitmentPlansInfo)MainObject;
            objRecruitmentPlansInfo.HRRecruitmentPlanDate = BOSApp.GetCurrentServerDate();
            objRecruitmentPlansInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objRecruitmentPlansInfo.HRRecruitmentPlanStatus = RecruitmentPlanStatus.New.ToString();

            UpdateMainObjectBindingSource();
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            RecruitmentPlanItemsList.Invalidate(iObjectID);
        }

        #region Save Module Objects functions

        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            RecruitmentPlanItemsList.SaveItemObjects();
        }
        #endregion

        public void GenerateRecruitmentNeedItem(HRRecruitmentNeedItemsInfo objRecruitmentNeedItemsInfo)
        {
            HRRecruitmentPlanItemsInfo objRecruitmentPlanItemsInfo = new HRRecruitmentPlanItemsInfo();
            BOSUtil.CopyObject(objRecruitmentNeedItemsInfo, objRecruitmentPlanItemsInfo);
            objRecruitmentPlanItemsInfo.FK_HRRecruitmentNeedItemID = objRecruitmentNeedItemsInfo.HRRecruitmentNeedItemID;
            RecruitmentPlanItemsList.Add(objRecruitmentPlanItemsInfo);
        }
    }
}
