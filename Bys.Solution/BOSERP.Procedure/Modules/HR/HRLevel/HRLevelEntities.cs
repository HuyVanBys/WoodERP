using System;

namespace BOSERP.Modules.HRLevel
{
    public class HRLevelEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        #endregion

        #region Constructor
        public HRLevelEntities()
            : base()
        {

        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRLevelsInfo();

        }

        public override void InitModuleObjects()
        {
        }

        public override void InitModuleObjectList()
        {
        }

        public override void InitGridControlInBOSList()
        {
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
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
        }
        #endregion
    }
}
