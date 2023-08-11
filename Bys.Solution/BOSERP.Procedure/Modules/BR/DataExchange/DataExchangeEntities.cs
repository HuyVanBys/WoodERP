using BOSLib;
using System;
using System.Data;

namespace BOSERP.Modules.DataExchange
{
    public class DataExchangeEntities : ERPModuleEntities
    {
        #region Variables

        #endregion

        #region Properties
        public BOSList<BRBranchsInfo> BRBranchsList { get; set; }

        /// <summary>
        /// Gets or sets the posting history of a centre
        /// </summary>
        public BOSList<BRPostingHistorysInfo> BRPostingHistoryList { get; set; }

        /// <summary>
        /// Gets or sets the posting history of a region
        /// </summary>
        public BOSList<BRPostingHistorysInfo> RegionalPostingHistoryList { get; set; }
        #endregion

        #region Constructore
        public DataExchangeEntities()
            : base()
        {
            BRBranchsList = new BOSList<BRBranchsInfo>();
            BRPostingHistoryList = new BOSList<BRPostingHistorysInfo>();
            RegionalPostingHistoryList = new BOSList<BRPostingHistorysInfo>();
        }
        #endregion

        #region Initalize Module list
        public override void InitModuleObjectList()
        {
            BRBranchsList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(BRBranchsInfo)));
            DataSet ds = new BRBranchsController().GetAllObjects();
            BRBranchsList.Invalidate(ds);
            for (int i = 0; i < BRBranchsList.Count; i++)
                if (BRBranchsList[i].BRBranchID == BOSApp.CurrentCompanyInfo.FK_BRBranchID)
                {
                    BRBranchsList.RemoveAt(i);
                    break;
                }

            BRPostingHistorysController objPostingHistorysController = new BRPostingHistorysController();
            BRPostingHistoryList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(BRPostingHistorysInfo)));
            ds = objPostingHistorysController.GetAllObjects();
            BRPostingHistoryList.Invalidate(ds);

            RegionalPostingHistoryList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(BRPostingHistorysInfo)));
            ds = objPostingHistorysController.GetAllObjects();
            RegionalPostingHistoryList.Invalidate(ds);
        }
        #endregion

        #region Initalize GridControl
        public override void InitGridControlInBOSList()
        {
            BRBranchsList.InitBOSListGridControl();
            BRPostingHistoryList.InitBOSListGridControl();
            RegionalPostingHistoryList.InitBOSListGridControl(DataExchangeModule.RegionalPostingHistoryGridControlName);
        }
        #endregion
    }
}
