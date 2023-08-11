using BOSCommon.Constants;
using System.Data;

namespace BOSERP.Modules.ProjectType
{
    public class ProjectTypeEntities : ERPModuleEntities
    {
        #region Declare all entities variables
        public BOSList<PMPhaseTypesInfo> PhaseTypeList { get; set; }
        #endregion

        #region Constructor
        public ProjectTypeEntities()
            : base()
        {
            PhaseTypeList = new BOSList<PMPhaseTypesInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new PMProjectTypesInfo();
            SearchObject = new PMProjectTypesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.PMPhaseTypesTableName, new PMPhaseTypesInfo());
        }

        public override void InitModuleObjectList()
        {
            PhaseTypeList = new BOSList<PMPhaseTypesInfo>();
            PhaseTypeList.InitBOSList(this, TableName.PMProjectTypesTableName, TableName.PMPhaseTypesTableName);
        }

        public override void InitGridControlInBOSList()
        {
            PhaseTypeList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            PhaseTypeList.SetDefaultListAndRefreshGridControl();
        }
        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            PMPhaseTypesController objPhaseTypesController = new PMPhaseTypesController();
            DataSet ds = objPhaseTypesController.GetPhaseTypeByProjectTypeID(iObjectID);
            PhaseTypeList.Invalidate(ds);
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            PMProjectTypesInfo objProjectTypesInfo = (PMProjectTypesInfo)MainObject;
            PhaseTypeList.ForEach(s => s.FK_PMProjectTypeID = objProjectTypesInfo.PMProjectTypeID);
            PhaseTypeList.SaveItemObjects();
        }
        #endregion
    }
}