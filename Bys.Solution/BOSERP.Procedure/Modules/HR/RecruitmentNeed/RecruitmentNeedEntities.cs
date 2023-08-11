using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.RecruitmentNeed
{
    public class RecruitmentNeedEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the list of canceled items
        /// </summary>
        public BOSItemsEntityList<HRRecruitmentNeedItemsInfo> RecruitmentNeedItemsList { get; set; }
        #endregion

        #region Constructor
        public RecruitmentNeedEntities()
            : base()
        {
            RecruitmentNeedItemsList = new BOSItemsEntityList<HRRecruitmentNeedItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            SearchObject = new HRRecruitmentNeedsInfo();
            MainObject = new HRRecruitmentNeedsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRRecruitmentNeedItemsTableName, new HRRecruitmentNeedItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            RecruitmentNeedItemsList.InitBOSList(this,
                                            TableName.HRRecruitmentNeedsTableName,
                                            TableName.HRRecruitmentNeedItemsTableName,
                                            BOSList<HRRecruitmentNeedItemsInfo>.cstRelationForeign);
        }

        public override void InitGridControlInBOSList()
        {
            RecruitmentNeedItemsList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                RecruitmentNeedItemsList.SetDefaultListAndRefreshGridControl();
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

            HRRecruitmentNeedsInfo objRecruitmentNeedsInfo = (HRRecruitmentNeedsInfo)MainObject;
            objRecruitmentNeedsInfo.HRRecruitmentNeedDate = BOSApp.GetCurrentServerDate();
            objRecruitmentNeedsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objRecruitmentNeedsInfo.HRRecruitmentNeedStatus = RecruitmentNeedStatus.New.ToString();

            UpdateMainObjectBindingSource();
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            RecruitmentNeedItemsList.Invalidate(iObjectID);
        }

        #region Save Module Objects functions

        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            RecruitmentNeedItemsList.SaveItemObjects();
        }
        #endregion 
    }
}
