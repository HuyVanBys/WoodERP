using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Data;

namespace BOSERP.Modules.ClearData
{
    public class ClearDataEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<STModuleClearDatasInfo> ClearDataList { get; set; }
        /// <summary>
        /// Get or set account list
        /// </summary>
        #endregion

        #region Constructor
        public ClearDataEntities()
            : base()
        {
            ClearDataList = new BOSList<STModuleClearDatasInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {

        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.STModuleClearDatasTableName, new STModuleClearDatasInfo());
        }

        public override void InitModuleObjectList()
        {
            ClearDataList.InitBOSList(this,
                                           String.Empty,
                                           TableName.STModuleClearDatasTableName,
                                           BOSList<STModuleClearDatasInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            ClearDataList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ClearDataList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion
    }
}
