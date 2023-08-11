using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.SaleContract
{
    public class SaleContractEntities : ERPModuleEntities
    {
        #region Declare Constant
        //public readonly static String strARCreditNotesObjectName = "ARCreditNotes";
        #endregion

        #region Declare all entities variables
        //private ARCreditNotesInfo _aRCreditNotesObject;
        #endregion

        #region Public Properties
        public BOSList<ARSaleContractTemplatesInfo> SaleContractTemplatesList { get; set; }
        public Dictionary<int, string> SaleContractTemplateURLDic { get; set; }
        public BOSList<ARSaleOrdersInfo> ARSaleOrdersList { get; set; }
        #endregion

        #region Constructor
        public SaleContractEntities()
            : base()
        {
            SaleContractTemplatesList = new BOSList<ARSaleContractTemplatesInfo>();
            ARSaleOrdersList = new BOSList<ARSaleOrdersInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARSaleContractsInfo();
            SearchObject = new ARSaleContractsInfo();
        }

        public override void InitModuleObjectList()
        {
            SaleContractTemplatesList.InitBOSList(this,
                                    TableName.ARSaleContractsTableName,
                                    TableName.ARSaleContractTemplatesTableName,
                                    BOSList<ARSaleContractTemplatesInfo>.cstRelationForeign);
            SaleContractTemplatesList.ItemTableForeignKey = "FK_ARSaleContractID";

            ARSaleOrdersList.InitBOSList(this,
                                         TableName.ARSaleContractsTableName,
                                         TableName.ARSaleOrdersTableName,
                                         BOSList<ARSaleOrderItemsInfo>.cstRelationForeign);
            ARSaleOrdersList.ItemTableForeignKey = "FK_ARSaleContractID";
        }

        public override void InitGridControlInBOSList()
        {
            SaleContractTemplatesList.InitBOSListGridControl("fld_dgcARSaleContractTemplatesGridControl");
            ARSaleOrdersList.InitBOSListGridControl(SaleContractModule.ARSaleOrderGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                SaleContractTemplatesList.SetDefaultListAndRefreshGridControl();
                ARSaleOrdersList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ARSaleContractTemplatesController objSaleContractTemplatesController = new ARSaleContractTemplatesController();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            List<ARSaleContractTemplatesInfo> saleContractTemplateList = objSaleContractTemplatesController.GetSaleContractTemplateBySaleContractID(iObjectID);
            SaleContractTemplatesList.Invalidate(saleContractTemplateList);
            List<ARSaleOrdersInfo> saleOrderList = objSaleOrdersController.GetSaleOrderBySaleContractID(iObjectID);
            ARSaleOrdersList.Invalidate(saleOrderList);
        }

        public override void SaveModuleObjects()
        {
            SaleContractTemplatesList.SaveItemObjects();
            SaleContractTemplateURLDic = SaleContractTemplatesList.ToDictionary(o => o.ARSaleContractTemplateID, o => o.FullPathFile);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ARSaleContractsInfo mainObject = (ARSaleContractsInfo)MainObject;
            mainObject.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            mainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            mainObject.ARSaleContractDate = BOSApp.GetCurrentServerDate();
            mainObject.ARSaleContractValidDate = BOSApp.GetCurrentServerDate();
            mainObject.ARSaleContractInvalidDate = BOSApp.GetCurrentServerDate().AddDays(7);
        }
        #endregion

    }
}
