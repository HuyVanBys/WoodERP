using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.Line
{
    public class LineEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<MMLineOperationsInfo> LineOperationsList { get; set; }
        #endregion

        #region Constructor
        public LineEntities()
            : base()
        {
            LineOperationsList = new BOSList<MMLineOperationsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMLinesInfo();
            SearchObject = new MMLinesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMLineOperationTableName, new MMLineOperationsInfo());
        }

        public override void InitModuleObjectList()
        {
            LineOperationsList.InitBOSList(this,
                                            TableName.MMLinesTableName,
                                            TableName.MMLineOperationTableName,
                                            BOSList<MMLineOperationsInfo>.cstRelationForeign);
            LineOperationsList.ItemTableForeignKey = "FK_MMLineID";
        }

        public override void InitGridControlInBOSList()
        {
            LineOperationsList.InitBOSListGridControl(LineModule.LineOperationGridControl);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMLinesInfo objLinesInfo = (MMLinesInfo)MainObject;
            objLinesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                LineOperationsList.SetDefaultListAndRefreshGridControl();
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
            LineOperationsList.Invalidate(iObjectID);
        }

        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            MMLinesInfo objLinesInfo = (MMLinesInfo)MainObject;
            foreach (MMLineOperationsInfo item in LineOperationsList)
            {
                item.FK_MMLineID = objLinesInfo.MMLineID;
                item.FK_MMWorkShopID = objLinesInfo.FK_MMWorkShopID;
            }
            LineOperationsList.SaveItemObjects();
        }
        #endregion              
    }
}
