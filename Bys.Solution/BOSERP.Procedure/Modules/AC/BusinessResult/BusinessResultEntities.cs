using System;

namespace BOSERP.Modules.BusinessResult
{
    class BusinessResultEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ACBusinessResultDetailsInfo> ACBusinessResultDetailsList { get; set; }

        #endregion

        #region Constructor
        public BusinessResultEntities()
            : base()
        {
            ACBusinessResultDetailsList = new BOSList<ACBusinessResultDetailsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACBusinessResultsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("ACBusinessResultDetails", new ACBusinessResultDetailsInfo());
        }

        public override void InitModuleObjectList()
        {
            ACBusinessResultDetailsList.InitBOSList(
                                            this,
                                            "ACBusinessResults",
                                            "ACBusinessResultDetails",
                                            BOSList<ACBusinessResultDetailsInfo>.cstRelationForeign);
            ACBusinessResultDetailsList.ItemTableForeignKey = "FK_ACBusinessResultID";
        }

        public override void InitGridControlInBOSList()
        {
            ACBusinessResultDetailsList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ACBusinessResultDetailsList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ACBusinessResultDetailsList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            ACBusinessResultDetailsList.SaveItemObjects();
        }
        #endregion
    }
}
