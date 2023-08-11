using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.HRProductPieceWage
{
    public class HRProductPieceWageEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        #endregion

        #region Constructor
        public HRProductPieceWageEntities()
            : base()
        {
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRProductPieceWagesInfo();
            SearchObject = new HRProductPieceWagesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeesTableName, new HREmployeesInfo());
        }

        public override void InitModuleObjectList()
        {
        }

        public override void InitGridControlInBOSList()
        {
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRProductPieceWagesInfo objEmployeePieceWagesInfo = (HRProductPieceWagesInfo)MainObject;
            objEmployeePieceWagesInfo.HRProductPieceWageQuantity = 1;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
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
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            HRProductPieceWagesInfo objEmployeePieceWagesInfo = (HRProductPieceWagesInfo)MainObject;
            try
            {

            }
            catch (Exception) { }
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
        }
        #endregion
    }
}
