using BOSCommon.Constants;
using Localization;
using System;
using System.Data;
using System.Windows.Forms;
using BOSLib;

namespace BOSERP.Modules.ProductConstant
{
    class ProductConstantEntities : ERPModuleEntities
    {
        #region Constants
        #endregion

        private ICProductAttributesInfo Productattributes;

        #region Public Properties
        //

        public BOSList<ICProductAttributesInfo> WoodTypeList { get; set; }
        public BOSList<ICProductAttributesInfo> AddMaterialTypeList { get; set; }
        //
        public BOSList<ICProductAttributesInfo> CoLorList { get; set; }
        //

        public BOSList<ICProductAttributesInfo> HTTypeList { get; set; }
        //

        public BOSList<ICProductAttributesInfo> TTMTList { get; set; }

        public BOSList<ICProductAttributesInfo> QualityList { get; set; }
        public BOSList<ICProductAttributesInfo> ThickList { get; set; }

        public BOSList<MMReuseSpecificateConfigsInfo> ReuseSpecificateList { get; set; }

        public BOSList<MMConsumableConfigsInfo> ConsumableConfigList { get; set; }


        public BOSList<MMExchangeRateConfigsInfo> ExchangeRateConfigList { get; set; }
        public BOSList<MMOperationProductsInfo> OperationProductList { get; set; }

        //TNDLoc [ADD][26/10/2015][Issue ProductionNormItemConfigs],START
        public BOSList<MMProductionNormItemConfigsInfo> ProductionNormItemConfigsList { get; set; }
        public BOSList<MMFormulaConfigurationsInfo> MMFormulaConfigurationsList { get; set; }
        public BOSList<MMFormulaConfigurationsInfo> MMFormulaAddmaterialConfigList { get; set; }
        public BOSList<ICProductAttributesInfo> AttributesList { get; set; }
        public BOSList<ICProductGroupHeightsInfo> ProductGroupHeightsList { get; set; }
        public BOSList<ICProductAttributesInfo> PackingMaterialSpecialityList { get; set; }
        public BOSList<ICProductAttributesInfo> PackingMaterialSizeList { get; set; }
        public BOSList<ICProductAttributesInfo> PackingMaterialWeightPerVolumeList { get; set; }
        public BOSList<MMPackingMaterialMarketDimensionsInfo> PackingMaterialMarketDimensionList { get; set; }

        public BOSList<MMOverallInsideDimensionConfigsInfo> MMOverallInsideDimensionConfigsList { get; set; }
        public BOSList<MMExchangeMeasureUnitConfigsInfo> MMExchangeMeasureUnitConfigsList { get; set; }
        public BOSList<ICModelsInfo> ModelList { get; set; }
        public BOSList<ICModelDetailsInfo> ModelDetailsList { get; set; }
        public BOSList<MMQuantityAllocationPercentConfigsInfo> QuantityAllocationPercentConfigsList { get; set; }
        public BOSList<MMLabourProductivityTargetConfigsInfo> LabourProductivityTargetConfigsList { get; set; }
        public BOSList<ICProductAttributesInfo> SemiGroupTypeList { get; set; }
        public BOSList<ICLengthGroupsInfo> ICLengthGroupsList { get; set; }
        public BOSList<ICWidthGroupsInfo> ICWidthGroupsList { get; set; }
        public BOSList<ICPerimeterGroupsInfo> ICPerimeterGroupsList { get; set; }
        public BOSList<ICMaterialConfigsInfo> ICMaterialConfigsList { get; set; }
        public BOSList<MMConfigAccountOperationsInfo> ConfigAccountOperationList { get; set; }
        public BOSList<MMConfigFalseConditionalsInfo> ConfigFalseConditionalList { get; set; }
        public BOSList<ICConfigAccordWoodTypesInfo> ConfigThinkAccordWoodTypeList { get; set; }
        public BOSList<ICConfigAccordWoodTypesInfo> ConfigQualityAccordWoodTypeList { get; set; }
        public BOSList<MMProductionCompletionTimeConfigsInfo> ConfigProductionCompletionTimeList { get; set; }
        public BOSList<MMExecuteTimeConfigsInfo> ConfigExecuteTimeList { get; set; }
        public BOSList<ADDirectoryPathConfigsInfo> DirectoryPathList { get; set; }
        public BOSList<MMDepartmentAndOperationsInfo> DepartmentAndOperationList { get; set; }
        public BOSList<MMDepartmentCapacityConfigsInfo> DepartmentCapacityConfigList { get; set; }
        public BOSList<MMProductGroupTypeSwitchingConfigsInfo> ProductGroupTypeSwitchingConfigList { get; set; }
        public BOSList<MMAllocationOperationConfigsInfo> AllocationOperationConfigList { get; set; }
        public BOSList<MMDefaultAllocationOperationConfigsInfo> DefaultAllocationOperationConfigList { get; set; }
        public BOSList<MMConfigMaterialShipmentUtilitysInfo> ConfigMaterialShipmentUtilityList { get; set; }
        public BOSList<MMCalMaterialConfigsInfo> CalMaterialConfigList { get; set; }

        public BOSList<ADConfigValuesInfo> ConfigProductionComplexityTypeList { get; set; }

        #endregion

        #region Constructor
        public ProductConstantEntities()
            : base()
        {
            WoodTypeList = new BOSList<ICProductAttributesInfo>();
            AddMaterialTypeList = new BOSList<ICProductAttributesInfo>();
            CoLorList = new BOSList<ICProductAttributesInfo>();
            HTTypeList = new BOSList<ICProductAttributesInfo>();
            TTMTList = new BOSList<ICProductAttributesInfo>();
            QualityList = new BOSList<ICProductAttributesInfo>();
            ThickList = new BOSList<ICProductAttributesInfo>();
            ReuseSpecificateList = new BOSList<MMReuseSpecificateConfigsInfo>();
            ConsumableConfigList = new BOSList<MMConsumableConfigsInfo>();
            ExchangeRateConfigList = new BOSList<MMExchangeRateConfigsInfo>();
            OperationProductList = new BOSList<MMOperationProductsInfo>();
            ProductionNormItemConfigsList = new BOSList<MMProductionNormItemConfigsInfo>();
            AttributesList = new BOSList<ICProductAttributesInfo>();
            ProductGroupHeightsList = new BOSList<ICProductGroupHeightsInfo>();
            MMFormulaConfigurationsList = new BOSList<MMFormulaConfigurationsInfo>();
            MMFormulaAddmaterialConfigList = new BOSList<MMFormulaConfigurationsInfo>();
            PackingMaterialSpecialityList = new BOSList<ICProductAttributesInfo>();
            PackingMaterialSizeList = new BOSList<ICProductAttributesInfo>();
            PackingMaterialWeightPerVolumeList = new BOSList<ICProductAttributesInfo>();
            MMOverallInsideDimensionConfigsList = new BOSList<MMOverallInsideDimensionConfigsInfo>();
            MMExchangeMeasureUnitConfigsList = new BOSList<MMExchangeMeasureUnitConfigsInfo>();
            ModelList = new BOSList<ICModelsInfo>();
            ModelDetailsList = new BOSList<ICModelDetailsInfo>();
            QuantityAllocationPercentConfigsList = new BOSList<MMQuantityAllocationPercentConfigsInfo>();
            LabourProductivityTargetConfigsList = new BOSList<MMLabourProductivityTargetConfigsInfo>();
            SemiGroupTypeList = new BOSList<ICProductAttributesInfo>();
            ICLengthGroupsList = new BOSList<ICLengthGroupsInfo>();
            ICWidthGroupsList = new BOSList<ICWidthGroupsInfo>();
            ICPerimeterGroupsList = new BOSList<ICPerimeterGroupsInfo>();
            ICMaterialConfigsList = new BOSList<ICMaterialConfigsInfo>();
            PackingMaterialMarketDimensionList = new BOSList<MMPackingMaterialMarketDimensionsInfo>();
            ConfigAccountOperationList = new BOSList<MMConfigAccountOperationsInfo>();
            ConfigFalseConditionalList = new BOSList<MMConfigFalseConditionalsInfo>();
            ConfigThinkAccordWoodTypeList = new BOSList<ICConfigAccordWoodTypesInfo>();
            ConfigQualityAccordWoodTypeList = new BOSList<ICConfigAccordWoodTypesInfo>();
            ConfigProductionCompletionTimeList = new BOSList<MMProductionCompletionTimeConfigsInfo>();
            ConfigExecuteTimeList = new BOSList<MMExecuteTimeConfigsInfo>();
            DirectoryPathList = new BOSList<ADDirectoryPathConfigsInfo>();
            DepartmentAndOperationList = new BOSList<MMDepartmentAndOperationsInfo>();
            DepartmentCapacityConfigList = new BOSList<MMDepartmentCapacityConfigsInfo>();
            ProductGroupTypeSwitchingConfigList = new BOSList<MMProductGroupTypeSwitchingConfigsInfo>();
            AllocationOperationConfigList = new BOSList<MMAllocationOperationConfigsInfo>();
            DefaultAllocationOperationConfigList = new BOSList<MMDefaultAllocationOperationConfigsInfo>();
            ConfigMaterialShipmentUtilityList = new BOSList<MMConfigMaterialShipmentUtilitysInfo>();
            CalMaterialConfigList = new BOSList<MMCalMaterialConfigsInfo>();
            ConfigProductionComplexityTypeList = new BOSList<ADConfigValuesInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICProductAttributesInfo();
        }
        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICProductattributesTableName, new ICProductAttributesInfo());
            ModuleObjects.Add(TableName.ICProductGroupHeightsTableName, new ICProductGroupHeightsInfo());
            ModuleObjects.Add(TableName.ICWidthGroupsTableName, new ICWidthGroupsInfo());
            ModuleObjects.Add(TableName.MMReuseSpecificateConfigsTableName, new MMReuseSpecificateConfigsInfo());
            ModuleObjects.Add(TableName.MMConsumableConfigsTableName, new MMConsumableConfigsInfo());
            ModuleObjects.Add(TableName.MMExchangeRateConfigsTableName, new MMExchangeRateConfigsInfo());
            ModuleObjects.Add(TableName.MMProductionNormItemConfigsTableName, new MMProductionNormItemConfigsInfo());
            ModuleObjects.Add(TableName.MMFormulaConfigurationsTableName, new MMFormulaConfigurationsInfo());
            ModuleObjects.Add(TableName.MMOverallInsideDimensionConfigsTableName, new MMOverallInsideDimensionConfigsInfo());
            ModuleObjects.Add(TableName.MMExchangeMeasureUnitConfigsTableName, new MMExchangeMeasureUnitConfigsInfo());

            ModuleObjects.Add(TableName.ICModelConfigsTableName, new ICModelsInfo());
            ModuleObjects.Add("MMQuantityAllocationPercentConfigs", new MMQuantityAllocationPercentConfigsInfo());
            ModuleObjects.Add("MMLabourProductivityTargetConfigs", new MMLabourProductivityTargetConfigsInfo());

            ModuleObjects.Add(TableName.MMOperationProductsTableName, new MMOperationProductsInfo());
            ModuleObjects.Add("MMPackingMaterialMarketDimensions", new MMPackingMaterialMarketDimensionsInfo());
            ModuleObjects.Add(TableName.MMConfigAccountOperationsTableName, new MMConfigAccountOperationsInfo());
            ModuleObjects.Add(TableName.ICConfigAccordWoodTypesTableName, new ICConfigAccordWoodTypesInfo());
            ModuleObjects.Add(TableName.MMProductionCompletionTimeConfigsTableName, new MMProductionCompletionTimeConfigsInfo());
            ModuleObjects.Add(TableName.MMExecuteTimeConfigsTableName, new MMExecuteTimeConfigsInfo());
            ModuleObjects.Add(TableName.ADDirectoryPathConfigsTableName, new ADDirectoryPathConfigsInfo());
            ModuleObjects.Add("MMAllocationOperationConfigs", new MMAllocationOperationConfigsInfo());
            ModuleObjects.Add("MMConfigMaterialShipmentUtilitys", new MMConfigMaterialShipmentUtilitysInfo());
            ConfigProductionComplexityTypeList.InitBOSList(this,
                                            String.Empty,
                                            TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);
        }
        public override void InitModuleObjectList()
        {
            WoodTypeList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ICProductattributesTableName,
                                           BOSList<ICProductAttributesInfo>.cstRelationNone);
            AddMaterialTypeList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ICProductattributesTableName,
                                           BOSList<ICProductAttributesInfo>.cstRelationNone);
            SemiGroupTypeList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ICProductattributesTableName,
                                           BOSList<ICProductAttributesInfo>.cstRelationNone);
            CoLorList.InitBOSList(this,
                                          String.Empty,
                                          TableName.ICProductattributesTableName,
                                          BOSList<ICProductAttributesInfo>.cstRelationNone);
            HTTypeList.InitBOSList(this,
                                          String.Empty,
                                          TableName.ICProductattributesTableName,
                                          BOSList<ICProductAttributesInfo>.cstRelationNone);
            TTMTList.InitBOSList(this,
                                        String.Empty,
                                        TableName.ICProductattributesTableName,
                                        BOSList<ICProductAttributesInfo>.cstRelationNone);
            QualityList.InitBOSList(this,
                                          String.Empty,
                                          TableName.ICProductattributesTableName,
                                          BOSList<ICProductAttributesInfo>.cstRelationNone);

            ThickList.InitBOSList(this,
                                          String.Empty,
                                          TableName.ICProductattributesTableName,
                                          BOSList<ICProductAttributesInfo>.cstRelationNone);

            ReuseSpecificateList.InitBOSList(this,
                                    String.Empty,
                                    TableName.MMReuseSpecificateConfigsTableName);
            ConsumableConfigList.InitBOSList(this,
                                    String.Empty,
                                    TableName.MMConsumableConfigsTableName);
            ExchangeRateConfigList.InitBOSList(this,
                                    String.Empty,
                                    TableName.MMExchangeRateConfigsTableName);
            OperationProductList.InitBOSList(this,
                                    String.Empty,
                                    TableName.MMOperationProductsTableName);
            //TNDLoc [ADD][26/10/2015][Issue ProductionNormItemConfigs],START
            ProductionNormItemConfigsList.InitBOSList(this,
                                         String.Empty,
                                         TableName.MMProductionNormItemConfigsTableName,
                                         BOSList<MMProductionNormItemConfigsInfo>.cstRelationNone);
            //TNDLoc [ADD][26/10/2015][Issue ProductionNormItemConfigs],END
            //NNGiang [ADD][28/10/2015][Issue PaitnConfigs],START
            MMFormulaConfigurationsList.InitBOSList(this, String.Empty, TableName.MMFormulaConfigurationsTableName,
                                        BOSList<MMFormulaConfigurationsInfo>.cstRelationNone);
            MMFormulaAddmaterialConfigList.InitBOSList(this, String.Empty, TableName.MMFormulaConfigurationsTableName,
                                        BOSList<MMFormulaConfigurationsInfo>.cstRelationNone);
            AttributesList.InitBOSList(this, String.Empty, TableName.ICProductattributesTableName,
                                        BOSList<ICProductAttributesInfo>.cstRelationNone);
            //NNGiang [ADD][28/10/2015][Issue ProductionNormItemConfigs],END
            ProductGroupHeightsList.InitBOSList(this, String.Empty, TableName.ICProductGroupHeightsTableName,
                                            BOSList<ICProductGroupHeightsInfo>.cstRelationNone);
            PackingMaterialSpecialityList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ICProductattributesTableName,
                                           BOSList<ICProductAttributesInfo>.cstRelationNone);
            PackingMaterialSizeList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ICProductattributesTableName,
                                           BOSList<ICProductAttributesInfo>.cstRelationNone);
            PackingMaterialWeightPerVolumeList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ICProductattributesTableName,
                                           BOSList<ICProductAttributesInfo>.cstRelationNone);
            //TNDLoc [ADD][09/12/2015][Issue MMOverallInsideDimensionConfigs],START
            MMOverallInsideDimensionConfigsList.InitBOSList(this,
                                          String.Empty,
                                          TableName.MMOverallInsideDimensionConfigsTableName,
                                          BOSList<MMOverallInsideDimensionConfigsInfo>.cstRelationNone);
            //TNDLoc [ADD][09/12/2015][Issue MMOverallInsideDimensionConfigs],END
            MMExchangeMeasureUnitConfigsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.MMExchangeMeasureUnitConfigsTableName,
                                           BOSList<MMExchangeMeasureUnitConfigsInfo>.cstRelationNone);

            ModelList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ICModelConfigsTableName,
                                           BOSList<ICModelsInfo>.cstRelationNone);

            ModelDetailsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ICModelDetailConfigsTableName,
                                           BOSList<ICModelDetailsInfo>.cstRelationNone);
            QuantityAllocationPercentConfigsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.MMQuantityAllocationPercentConfigsTableName,
                                           BOSList<ICModelsInfo>.cstRelationNone);

            LabourProductivityTargetConfigsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.MMLabourProductivityTargetConfigsTableName,
                                           BOSList<ICModelsInfo>.cstRelationNone);
            ICPerimeterGroupsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ICPerimeterGroupsTableName,
                                           BOSList<ICPerimeterGroupsInfo>.cstRelationNone);
            ICLengthGroupsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ICLengthGroupsTableName,
                                           BOSList<ICLengthGroupsInfo>.cstRelationNone);
            ICWidthGroupsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ICWidthGroupsTableName,
                                           BOSList<ICWidthGroupsInfo>.cstRelationNone);
            ICMaterialConfigsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ICMaterialConfigsTableName,
                                           BOSList<ICMaterialConfigsInfo>.cstRelationNone);
            PackingMaterialMarketDimensionList.InitBOSList(this,
                                           String.Empty,
                                           "MMPackingMaterialMarketDimensions",
                                           BOSList<MMPackingMaterialMarketDimensionsInfo>.cstRelationNone);
            ConfigAccountOperationList.InitBOSList(this,
                                                    String.Empty,
                                                    TableName.MMConfigAccountOperationsTableName,
                                                    BOSList<MMConfigAccountOperationsInfo>.cstRelationNone);
            ConfigFalseConditionalList.InitBOSList(this,
                                                    String.Empty,
                                                    TableName.MMConfigFalseConditionalsTableName,
                                                    BOSList<MMConfigAccountOperationsInfo>.cstRelationNone);
            ConfigThinkAccordWoodTypeList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ICConfigAccordWoodTypesTableName,
                                           BOSList<ICConfigAccordWoodTypesInfo>.cstRelationNone);
            ConfigQualityAccordWoodTypeList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ICConfigAccordWoodTypesTableName,
                                           BOSList<ICConfigAccordWoodTypesInfo>.cstRelationNone);
            ConfigProductionCompletionTimeList.InitBOSList(this,
                                           String.Empty,
                                           TableName.MMProductionCompletionTimeConfigsTableName,
                                           BOSList<MMProductionCompletionTimeConfigsInfo>.cstRelationNone);
            ConfigExecuteTimeList.InitBOSList(this,
                                           String.Empty,
                                           TableName.MMExecuteTimeConfigsTableName,
                                           BOSList<MMExecuteTimeConfigsInfo>.cstRelationNone);
            DirectoryPathList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ADDirectoryPathConfigsTableName,
                                           BOSList<ADDirectoryPathConfigsInfo>.cstRelationNone);

            DepartmentAndOperationList.InitBOSList(this,
                                           String.Empty,
                                           "MMDepartmentAndOperations",
                                           BOSList<MMDepartmentAndOperationsInfo>.cstRelationNone);

            DepartmentCapacityConfigList.InitBOSList(this,
                                           String.Empty,
                                           "MMDepartmentCapacityConfigs",
                                           BOSList<MMDepartmentCapacityConfigsInfo>.cstRelationNone);

            ProductGroupTypeSwitchingConfigList.InitBOSList(this,
                                           String.Empty,
                                           "MMProductGroupTypeSwitchingConfigs",
                                           BOSList<MMProductGroupTypeSwitchingConfigsInfo>.cstRelationNone);
            AllocationOperationConfigList.InitBOSList(this,
                                           String.Empty,
                                           "MMAllocationOperationConfigs",
                                           BOSList<MMAllocationOperationConfigsInfo>.cstRelationNone);
            DefaultAllocationOperationConfigList.InitBOSList(this,
                                           String.Empty,
                                           "MMDefaultAllocationOperationConfigs",
                                           BOSList<MMDefaultAllocationOperationConfigsInfo>.cstRelationNone);
            ConfigMaterialShipmentUtilityList.InitBOSList(this,
                                           String.Empty,
                                           "MMConfigMaterialShipmentUtilitys",
                                           BOSList<MMConfigMaterialShipmentUtilitysInfo>.cstRelationNone);
            CalMaterialConfigList.InitBOSList(this,
                                             String.Empty,
                                             TableName.MMCalMaterialConfigsTablename,
                                             BOSList<MMCalMaterialConfigsInfo>.cstRelationNone);
        }

        public void InitGridControlInBOSListForWoodConfigurationTab()
        {
            WoodTypeList.InitBOSListGridControl(ProductConstantModule.icpWoodTypeGridControl);
            AddMaterialTypeList.InitBOSListGridControl(ProductConstantModule.icpAddMaterialTypeGridControl);
            CoLorList.InitBOSListGridControl(ProductConstantModule.icpCoLorGridControl);
            HTTypeList.InitBOSListGridControl(ProductConstantModule.icpHTTypeGridControl);
            TTMTList.InitBOSListGridControl(ProductConstantModule.icpTTMTGridControl);
            QualityList.InitBOSListGridControl(ProductConstantModule.icpQualityGridControl);
            ThickList.InitBOSListGridControl();
            ReuseSpecificateList.InitBOSListGridControl(ProductConstantModule.ReuseSpecificateGridControl);
            ConsumableConfigList.InitBOSListGridControl(ProductConstantModule.ConsumableConfigGridControl);
            ExchangeRateConfigList.InitBOSListGridControl(ProductConstantModule.ExchangeRateConfigGridControl);
            OperationProductList.InitBOSListGridControl(ProductConstantModule.OperationProductGridControl);
            ProductionNormItemConfigsList.InitBOSListGridControl();
            MMFormulaConfigurationsList.InitBOSListGridControl();
            MMFormulaAddmaterialConfigList.InitBOSListGridControl();
            AttributesList.InitBOSListGridControl();
            ProductGroupHeightsList.InitBOSListGridControl();
            PackingMaterialSpecialityList.InitBOSListGridControl(ProductConstantModule.PackingMaterialSpecialityGridControl);
            PackingMaterialSizeList.InitBOSListGridControl(ProductConstantModule.PackingMaterialSizeGridControl);
            PackingMaterialWeightPerVolumeList.InitBOSListGridControl(ProductConstantModule.PackingMaterialWeightPerVolumeGridControl);
            MMOverallInsideDimensionConfigsList.InitBOSListGridControl(ProductConstantModule.MMOverallInsideDimensionConfigsGridControl);
            MMExchangeMeasureUnitConfigsList.InitBOSListGridControl(ProductConstantModule.MMExchangeMeasureUnitConfigsGridControl);

            ModelList.InitBOSListGridControl(ProductConstantModule.ICModelConfigsGridControl);
            ModelDetailsList.InitBOSListGridControl(ProductConstantModule.ICModelDetailConfigsGridControl);
            QuantityAllocationPercentConfigsList.InitBOSListGridControl(ProductConstantModule.MMQuantityAllocationPercentConfigsGridControl);
            LabourProductivityTargetConfigsList.InitBOSListGridControl(ProductConstantModule.MMLabourProductivityTargetConfigsGridControl);
            SemiGroupTypeList.InitBOSListGridControl(ProductConstantModule.SemiGroupTypeListGridControl);
            ICPerimeterGroupsList.InitBOSListGridControl(ProductConstantModule.ICPerimeterGroupsGridControl);
            ICLengthGroupsList.InitBOSListGridControl(ProductConstantModule.ICLengthGroupsGridControl);
            ICWidthGroupsList.InitBOSListGridControl(ProductConstantModule.ICWidthGroupsGridControl);
            ICMaterialConfigsList.InitBOSListGridControl();
            PackingMaterialMarketDimensionList.InitBOSListGridControl("fld_dgcMMPackingMaterialMarketDimensions");
            ConfigAccountOperationList.InitBOSListGridControl(ProductConstantModule.MMConfigAccountOperationsGridControl);
            ConfigFalseConditionalList.InitBOSListGridControl(ProductConstantModule.MMConfigFalseConditionalsGridControl);
            ConfigThinkAccordWoodTypeList.InitBOSListGridControl(ProductConstantModule.ConfigThinkAccordWoodTypesGridControl);
            ConfigQualityAccordWoodTypeList.InitBOSListGridControl(ProductConstantModule.ConfigQualityAccordWoodTypesGridControl);
            ConfigProductionCompletionTimeList.InitBOSListGridControl(ProductConstantModule.ProductionCompletionTimeConfigsGridControl);
            ConfigExecuteTimeList.InitBOSListGridControl(ProductConstantModule.ExecuteTimeConfigsGridControl);
            DirectoryPathList.InitBOSListGridControl(ProductConstantModule.DirectoryPathConfigGridControl);
            DepartmentAndOperationList.InitBOSListGridControl(ProductConstantModule.DepartmentAndOperationsGridControl);
            DepartmentCapacityConfigList.InitBOSListGridControl(ProductConstantModule.DepartmentCapacityConfigsGridControl);
            ProductGroupTypeSwitchingConfigList.InitBOSListGridControl(ProductConstantModule.DepartmentCapacityConfigsGridControl);
            AllocationOperationConfigList.InitBOSListGridControl(ProductConstantModule.AllocationOperationConfigGridControl);
            DefaultAllocationOperationConfigList.InitBOSListGridControl(ProductConstantModule.DefaultAllocationOperationConfigGridControl);
            ConfigMaterialShipmentUtilityList.InitBOSListGridControl(ProductConstantModule.ConfigMaterialShipmentUtilityGridControl);
            CalMaterialConfigList.InitBOSListGridControl("fld_dgcMMCalMaterialConfigs");
            ConfigProductionComplexityTypeList.InitBOSListGridControl("fld_dgcConfigProductionComplexityType");
        }



        public bool SaveReuseSpecificateConfigsList()
        {
            bool isInvalid = false;

            foreach (MMReuseSpecificateConfigsInfo item in ReuseSpecificateList)
            {
                if (!(item.FK_ICProductAttributeSpecialityID > 0))
                {
                    isInvalid = true;
                    break;
                }
            }
            if (isInvalid)
            {
                MessageBox.Show(ProductConstantLocalizedResources.SaveFailedMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                ReuseSpecificateList.SaveItemObjects();

            }
            return true;
        }
        public bool SaveConsumableConfigList()
        {
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            foreach (MMConsumableConfigsInfo item in ConsumableConfigList)
            {
                ICProductAttributesInfo ProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(item.FK_ICProductAttributeID);
                if (ProductAttributesInfo != null)
                {
                    if (item.MMConsumableConfigValue >= 0)
                    {
                        item.MMConsumableConfigAttributeValue = ProductAttributesInfo.ICProductAttributeValue;
                        item.MMConsumableConfigNo = ProductAttributesInfo.ICProductAttributeNo;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            //int count = ConsumableConfigList.GroupBy(item1 => item1.MMConsumableConfigNo).Count();
            //int countList = ConsumableConfigList.Count();
            //if (countList > count)
            //{
            //    //MessageBox.Show(ProductConstantLocalizedResources)
            //    return false;
            //}
            ConsumableConfigList.SaveItemObjects();
            return true;
        }

        public bool SaveExchangeRateConfigList()
        {
            bool isInvalid = false;
            bool isInvalid1 = false;
            bool isInvalid2 = false;
            bool isInvalid3 = false;
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            foreach (MMExchangeRateConfigsInfo Item in ExchangeRateConfigList)
            {
                if (Item.MMExchangeRateConfigThickExchange > 0)
                {
                    break;
                }
                ICProductGroupsInfo ProductGroupsInfo = null;
                DataRow row = BOSApp.GetObjectFromCatche("ICProductGroups", "ICProductGroupID", Item.FK_ICProductGroupID);
                if(row != null)
                    ProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectFromDataRow(row);
                if (ProductGroupsInfo != null)
                {
                    Item.FK_ICDepartmentID = ProductGroupsInfo.FK_ICDepartmentID;
                }
                if (!(Item.FK_ICProductAttributeID > 0))
                {
                    isInvalid = true;
                    break;
                }
                else if (Item.MMExchangeRateConfigBlockValue == 0)
                {
                    isInvalid1 = true;
                    break;
                }
                else if (!(Item.MMExchangeRateConfigBlockOperationTypeCombo.Length > 0))
                {
                    isInvalid2 = true;
                    break;
                }
                else if (!(Item.FK_ICProductGroupID > 0))
                {
                    isInvalid3 = true;
                    break;
                }

            }
            if (isInvalid)
            {
                MessageBox.Show(ProductConstantLocalizedResources.SaveProductFailedMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (isInvalid1)
            {
                MessageBox.Show(ProductConstantLocalizedResources.SaveValueFailedMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (isInvalid2)
            {
                MessageBox.Show(ProductConstantLocalizedResources.SaveTypeComboFailedMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (isInvalid3)
            {
                MessageBox.Show(ProductConstantLocalizedResources.SaveFKProductFailedMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                ExchangeRateConfigList.SaveItemObjects();
            }
            return true;
        }
        public bool SaveOperationProductList()
        {
            OperationProductList.SaveItemObjects();
            return true;
        }




        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                WoodTypeList.SetDefaultListAndRefreshGridControl();
                AddMaterialTypeList.SetDefaultListAndRefreshGridControl();
                SemiGroupTypeList.SetDefaultListAndRefreshGridControl();
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
            WoodTypeList.Invalidate(iObjectID);
            AddMaterialTypeList.Invalidate(iObjectID);
            SemiGroupTypeList.Invalidate(iObjectID);
        }
        #endregion
    }
}
