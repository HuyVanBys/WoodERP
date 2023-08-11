using BOSCommon.Constants;
using BOSLib;
using System;

namespace BOSERP.Modules.GeneralCostAllocation
{
    public class GeneralCostAllocationEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<MMProductionCostGeneralCostAllocationDetailsInfo> MMProductionCostGeneralCostAllocationDetailsList { get; set; }
        public BOSList<MMProductionCostGeneralCostAllocationCollectDocumentsInfo> MMProductionCostGeneralCostAllocationCollectDocumentsList { get; set; }

        #endregion

        #region Constructor
        public GeneralCostAllocationEntities()
            : base()
        {
            MMProductionCostGeneralCostAllocationDetailsList = new BOSList<MMProductionCostGeneralCostAllocationDetailsInfo>();

            MMProductionCostGeneralCostAllocationCollectDocumentsList = new BOSList<MMProductionCostGeneralCostAllocationCollectDocumentsInfo>();

        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMProductionCostGeneralCostAllocationsInfo();
            SearchObject = new MMProductionCostGeneralCostAllocationsInfo();
        }

        public override void InitModuleObjectList()
        {
            MMProductionCostGeneralCostAllocationDetailsList.InitBOSList(
                                              this,
                                              TableName.MMProductionCostGeneralCostAllocationsTableName,
                                              TableName.MMProductionCostGeneralCostAllocationDetailsTableName,
                                              BOSList<MMProductionCostGeneralCostAllocationDetailsInfo>.cstRelationForeign);
            MMProductionCostGeneralCostAllocationDetailsList.ItemTableForeignKey = "FK_MMProductionCostGeneralCostAllocationID";


            MMProductionCostGeneralCostAllocationCollectDocumentsList.InitBOSList(
                                              this,
                                              TableName.MMProductionCostGeneralCostAllocationsTableName,
                                             "MMProductionCostGeneralCostAllocationCollectDocuments",
                                              BOSList<MMProductionCostGeneralCostAllocationCollectDocumentsInfo>.cstRelationForeign);
            MMProductionCostGeneralCostAllocationCollectDocumentsList.ItemTableForeignKey = "FK_MMProductionCostGeneralCostAllocationID";


        }
        #endregion

        public override void InitGridControlInBOSList()
        {
            MMProductionCostGeneralCostAllocationDetailsList.InitBOSListGridControl(GeneralCostAllocationModule.DetailGridControlName);

        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                MMProductionCostGeneralCostAllocationDetailsList.SetDefaultListAndRefreshGridControl();

                MMProductionCostGeneralCostAllocationCollectDocumentsList.SetDefaultListAndRefreshGridControl();



            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            MMProductionCostGeneralCostAllocationDetailsList.Invalidate(iObjectID);

            MMProductionCostGeneralCostAllocationCollectDocumentsList.Invalidate(iObjectID);


        }

        public override void SaveModuleObjects()
        {
            MMProductionCostGeneralCostAllocationsInfo GeneralCostAllocationsInfo = (MMProductionCostGeneralCostAllocationsInfo)MainObject;
            MMProductionCostGeneralCostAllocationDetailsList.SaveItemObjects();

            MMProductionCostGeneralCostAllocationCollectDocumentsList.SaveItemObjects();

            //POST TTCP
            ACActualCostBudgetDetailsController dController = new ACActualCostBudgetDetailsController();
            dController.InsertDetailByAllcationCostDocument(GeneralCostAllocationsInfo.MMProductionCostGeneralCostAllocationNo
                                                            , BOSApp.CurrentUsersInfo.ADUserName
                                                            , Module.Name);

        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            MMProductionCostGeneralCostAllocationsInfo GeneralCostAllocationsInfo = (MMProductionCostGeneralCostAllocationsInfo)MainObject;
            GeneralCostAllocationsInfo.MMProductionCostGeneralCostAllocationDate = DateTime.Now;
            GeneralCostAllocationsInfo.MMProductionCostGeneralCostAllocationFromDate = BOSUtil.GetMonthBeginDate();
            GeneralCostAllocationsInfo.MMProductionCostGeneralCostAllocationToDate = BOSUtil.GetMonthEndDate();

            UpdateMainObjectBindingSource();

        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMProductionCostGeneralCostAllocationDetailsTableName, new MMProductionCostGeneralCostAllocationDetailsInfo());

        }
    }
}
