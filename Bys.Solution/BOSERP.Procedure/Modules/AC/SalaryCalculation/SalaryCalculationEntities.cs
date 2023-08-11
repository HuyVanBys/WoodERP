using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.SalaryCalculation
{
    public class SalaryCalculationEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables

        #endregion

        #region Public Properties
        public BOSList<ACSalaryCalculationDetailsInfo> SalaryCalculationDetailsList { get; set; }
        #endregion

        #region Constructor
        public SalaryCalculationEntities()
            : base()
        {
            SalaryCalculationDetailsList = new BOSList<ACSalaryCalculationDetailsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACSalaryCalculationsInfo();
            SearchObject = new ACSalaryCalculationsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACDocumentTypesTableName, new ACSalaryCalculationsInfo());
        }

        public override void InitModuleObjectList()
        {
            SalaryCalculationDetailsList.InitBOSList(this,
                                                    TableName.ACSalaryCalculationsTableName,
                                                    TableName.ACSalaryCalculationDetailsTableName,
                                                    BOSList<ACSalaryCalculationDetailsInfo>.cstRelationForeign);
            SalaryCalculationDetailsList.ItemTableForeignKey = "FK_ACSalaryCalculationID";
        }

        public override void InitGridControlInBOSList()
        {
            SalaryCalculationDetailsList.InitBOSListGridControl("fld_dgcSalaryCalculationDetails");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACSalaryCalculationsInfo objSalaryCalculationsInfo = (ACSalaryCalculationsInfo)MainObject;
            objSalaryCalculationsInfo.ACSalaryCalculationDate = DateTime.Now;
            objSalaryCalculationsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objSalaryCalculationsInfo.ACSalaryCalculationExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objSalaryCalculationsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objSalaryCalculationsInfo.IsPosted = false;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                SalaryCalculationDetailsList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Main Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ACSalaryCalculationsInfo objSalaryCalculationsInfo = (ACSalaryCalculationsInfo)MainObject;
            ACSalaryCalculationDetailsController objSalaryCalculationDetailsController = new ACSalaryCalculationDetailsController();
            List<ACSalaryCalculationDetailsInfo> listSalaryCalculationDetailsInfo = objSalaryCalculationDetailsController.GetListSalaryCalculationDetailsBySalaryCalculationID(objSalaryCalculationsInfo.ACSalaryCalculationID);
            SalaryCalculationDetailsList.Invalidate(listSalaryCalculationDetailsInfo);
            SalaryCalculationDetailsList.GridControl.RefreshDataSource();
        }
        #endregion

        #region Save Module Objects and Main Object functions
        public override int SaveMainObject()
        {
            ACSalaryCalculationsInfo objSalaryCalculationsInfo = (ACSalaryCalculationsInfo)MainObject;
            objSalaryCalculationsInfo.ACSalaryCalculationExchangeAmount = SalaryCalculationDetailsList.Sum(e => e.ACSalaryCalculationDetailExchangeAmount);
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            ACSalaryCalculationsInfo objSalaryCalculationsInfo = (ACSalaryCalculationsInfo)MainObject;
            if (!string.IsNullOrEmpty(objSalaryCalculationsInfo.ACSalaryCalculationNo))
            {
                HRPayRollsController objPayRollsController = new HRPayRollsController();
                HRPayRollsInfo objPayRollsInfo = (HRPayRollsInfo)objPayRollsController.GetObjectByNo(objSalaryCalculationsInfo.ACSalaryCalculationReference);
                if (objPayRollsInfo != null)
                {
                    objPayRollsInfo.HRPayRollStatus = PayRollStatus.Posted.ToString();
                    objPayRollsController.UpdateObject(objPayRollsInfo);
                }
            }
            SalaryCalculationDetailsList.SaveItemObjects();
        }

        #endregion
    }
}
