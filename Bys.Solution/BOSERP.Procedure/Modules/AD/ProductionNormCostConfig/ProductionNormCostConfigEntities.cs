using BOSCommon.Constants;
using System;
using System.Data;

namespace BOSERP.Modules.ProductionNormCostConfig
{
    public class ProductionNormCostConfigEntities : ERPModuleEntities
    {
        #region Constants
        #endregion

        #region Variables
        /// <summary>
        /// A variable to store the company info
        /// </summary>
        private CSCompanysInfo Company;
        #endregion

        #region Public Properties
        public BOSList<MMProductionNormFactorsInfo> MMProductionNormFactorsList { get; set; }
        public BOSList<MMProductionNormCostFactorsInfo> MMProductionNormCostFactorsList { get; set; }

        #endregion

        #region Constructor
        public ProductionNormCostConfigEntities()
            : base()
        {
            MMProductionNormFactorsList = new BOSList<MMProductionNormFactorsInfo>();
            MMProductionNormCostFactorsList = new BOSList<MMProductionNormCostFactorsInfo>();
        }
        #endregion

        public override void InitModuleEntity()
        {
            base.InitModuleEntity();
        }

        #region Init Main Object,Module Objects functions
        public override void InitModuleObjects()
        {
            base.InitModuleObjects();
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            MMProductionNormFactorsController objPNF = new MMProductionNormFactorsController();
            DataSet ds = objPNF.GetAllObjects();
            MMProductionNormFactorsList.Invalidate(ds);

            MMProductionNormCostFactorsController objPNCF = new MMProductionNormCostFactorsController();
            ds = objPNCF.GetAllObjects();
            MMProductionNormCostFactorsList.Invalidate(ds);
            ds.Dispose();
        }

        public override void InitModuleObjectList()
        {
            MMProductionNormFactorsList.InitBOSList(this,
                                          String.Empty,
                                          TableName.MMProductionNormFactorsTableName,
                                          BOSList<MMProductionNormFactorsInfo>.cstRelationNone);

            MMProductionNormCostFactorsList.InitBOSList(this,
                                          String.Empty,
                                          TableName.MMProductionNormCostFactorsTableName,
                                          BOSList<MMProductionNormCostFactorsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            MMProductionNormFactorsList.InitBOSListGridControl();
            MMProductionNormCostFactorsList.InitBOSListGridControl();
        }
        #endregion


        public override void SaveModuleObjects()
        {
            MMProductionNormFactorsList.SaveItemObjects();
            MMProductionNormCostFactorsList.SaveItemObjects();
        }
    }
}
