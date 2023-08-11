using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.Equipment
{
    public class EquipmentEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSItemsEntityList<ICProductIdentifiedEquipmentsInfo> ProductIdentifiedEquipmentList;
        #endregion

        #region Constructor
        public EquipmentEntities()
            : base()
        {
            ProductIdentifiedEquipmentList = new BOSItemsEntityList<ICProductIdentifiedEquipmentsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICProductsInfo();
            SearchObject = new ICProductsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("ICProductIdentifiedEquipments", new APProposalItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ProductIdentifiedEquipmentList.InitBOSList(this,
                                        TableName.ICProductsTableName,
                                        "ICProductIdentifiedEquipments",
                                        BOSItemsEntityList<ICProductIdentifiedEquipmentsInfo>.cstRelationForeign);
            ProductIdentifiedEquipmentList.ItemTableForeignKey = "FK_ICProductID";
        }

        public override void InitGridControlInBOSList()
        {
            ProductIdentifiedEquipmentList.InitBOSListGridControl("fld_dgcICProductIdentifiedEquipments");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            objProductsInfo.ICProductDepreciationMethod = EquipmentDepreciationMethod.Many.ToString();
            objProductsInfo.ICProductType = ProductType.Equipment.ToString();
            objProductsInfo.ICProductUsingMethod = ProductUsingMethod.SpecificEquipment.ToString();
            ICPriceCalculationMethodsController objPriceCalculationMethodsController = new ICPriceCalculationMethodsController();
            ICPriceCalculationMethodsInfo objPriceCalculationMethodsInfo = (ICPriceCalculationMethodsInfo)objPriceCalculationMethodsController.GetPriceCalculationMethodDefault();
            if (objPriceCalculationMethodsInfo != null)
                objProductsInfo.FK_ICPriceCalculationMethodID = objPriceCalculationMethodsInfo.ICPriceCalculationMethodID;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> configValuesList = objConfigValuesController.GetADConfigValuesByDefaultProductType();
            if (configValuesList.Count() > 0)
            {
                ADConfigValuesInfo found = configValuesList.Where(C => C.ADConfigKeyValue == objProductsInfo.ICProductType).FirstOrDefault();
                if (found != null)
                {
                    objProductsInfo.ICProductIsFollowInventoryStock = false;
                }
                else objProductsInfo.ICProductIsFollowInventoryStock = true;
            }
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ProductIdentifiedEquipmentList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ProductIdentifiedEquipmentList.Invalidate(iObjectID);
        }

        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            objProductsInfo.FK_ICProductSaleUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objProductsInfo.FK_ICProductPurchaseUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            if (Module.Toolbar.IsNewAction())
            {
                objProductsInfo.ICProductSupplierNumber = GetMainObjectNo();
            }
            else
            {
                objProductsInfo.ICProductSupplierNumber = objProductsInfo.ICProductNo;
            }
            objProductsInfo.ICProductDesc = objProductsInfo.ICProductName;
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            ProductIdentifiedEquipmentList.SaveItemObjects();
        }
        public override void DuplicateModuleObjectList()
        {
            ProductIdentifiedEquipmentList.Duplicate();
        }
        #endregion

        public override string GetMainObjectNo(ref int numberingStart)
        {
            string mainObjectNo = GetMainObjectNoByGenerateProductNoConfig(ref numberingStart, false);
            if (!string.IsNullOrWhiteSpace(mainObjectNo))
            {
                return mainObjectNo;
            }

            string productNo = base.GetMainObjectNo(ref numberingStart);
            ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            ICDepartmentsInfo objDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByID(objProductsInfo.FK_ICDepartmentID);
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(objProductsInfo.FK_ICProductGroupID);
            if (objProductGroupsInfo != null)
            {
                objProductGroupsInfo.ICProductGroupNo = objProductGroupsInfo.ICProductGroupNo.Substring(0, 2);
                productNo = string.Format("{0}{1}", objProductGroupsInfo.ICProductGroupNo, productNo);
            }
            if (objDepartmentsInfo != null)
            {
                productNo = string.Format("{0}{1}", objDepartmentsInfo.ICDepartmentNo, productNo);
            }
            return productNo;
        }
    }
}
