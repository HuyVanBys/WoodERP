using System;

namespace BOSERP.Modules.WorkShop
{
    public class WorkShopEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties

        #endregion

        #region Constructor
        public WorkShopEntities()
            : base()
        {

        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMWorkShopsInfo();
            SearchObject = new MMWorkShopsInfo();
        }

        public override void InitModuleObjects()
        {
            //ModuleObjects.Add(TableName.MMWorkShopsTableName, new MMWorkShopsInfo());
        }


        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMWorkShopsInfo objWorkShop = (MMWorkShopsInfo)MainObject;
            objWorkShop.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
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

        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        #endregion              
    }
}
