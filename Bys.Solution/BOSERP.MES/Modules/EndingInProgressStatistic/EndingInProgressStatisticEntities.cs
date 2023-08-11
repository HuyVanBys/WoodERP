using BOSCommon;
using BOSLib;
using System;

namespace BOSERP.Modules.EndingInProgressStatistic
{
    public class EndingInProgressStatisticEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<MMInProgressStatisticDetailsInfo> MMInProgressStatisticDetailsList { get; set; }

        #endregion

        #region Constructor
        public EndingInProgressStatisticEntities()
            : base()
        {
            MMInProgressStatisticDetailsList = new BOSList<MMInProgressStatisticDetailsInfo>();

        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMInProgressStatisticsInfo();
            SearchObject = new MMInProgressStatisticsInfo();
        }

        public override void InitModuleObjectList()
        {
            MMInProgressStatisticDetailsList.InitBOSList(
                                              this,
                                              "MMInProgressStatistics",
                                              "MMInProgressStatisticDetails",
                                              BOSList<MMInProgressStatisticDetailsInfo>.cstRelationForeign);
            MMInProgressStatisticDetailsList.ItemTableForeignKey = "FK_MMInProgressStatisticID";


        }
        #endregion

        public override void InitGridControlInBOSList()
        {
            MMInProgressStatisticDetailsList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                MMInProgressStatisticDetailsList.SetDefaultListAndRefreshGridControl();


            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            MMInProgressStatisticDetailsList.Invalidate(iObjectID);
        }

        public override bool CompleteTransaction()
        {
            MMInProgressStatisticsInfo mainObject = (MMInProgressStatisticsInfo)MainObject;
            if (mainObject.MMInProgressStatisticStatus == Status.New.ToString())
            {
                mainObject.MMInProgressStatisticStatus = Status.Complete.ToString();
                UpdateMainObject();
            }
            return true;
        }
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            MMInProgressStatisticsInfo InProgressStatisticsInfo = (MMInProgressStatisticsInfo)MainObject;
            InProgressStatisticsInfo.MMInProgressStatisticDate = DateTime.Now;
            InProgressStatisticsInfo.MMInProgressStatisticFromDate = BOSUtil.GetMonthBeginDate();
            InProgressStatisticsInfo.MMInProgressStatisticToDate = BOSUtil.GetMonthEndDate();
            InProgressStatisticsInfo.MMInProgressStatisticType = InProgressStatisticType.Ending.ToString();
            UpdateMainObjectBindingSource();

        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("MMInProgressStatisticDetails", new MMInProgressStatisticDetailsInfo());

        }
    }
}
