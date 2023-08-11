using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.ProductConstant.UI;
using BOSLib;
using BOSLib.Extensions;
using DevExpress.XtraEditors;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace BOSERP.Modules.ProductConstant
{
    class ProductConstantModule : BaseModuleERP
    {
        #region Constant
        public const string icpWoodTypeGridControl = "fld_dgcWoodType";
        public const string icpAddMaterialTypeGridControl = "fld_dgcICProductAttributeAddMaterialType";
        public const string icpCoLorGridControl = "fld_dgcCoLor";
        public const string icpHTTypeGridControl = "fld_dgcHTType";
        public const string icpTTMTGridControl = "fld_dgcTTMT";
        public const string icpQualityGridControl = "fld_dgcQuality";
        public const string icpAttributesGridControl = "fld_dgcAttribute";
        public const string ReuseSpecificateGridControl = "fld_dgcMMReuseSpecificateConfigs";
        public const string ConsumableConfigGridControl = "fld_dgcMMConsumableConfigs";
        public const string ExchangeRateConfigGridControl = "fld_dgcMMExchangeRateConfigs";
        public const string OperationProductGridControl = "fld_dgcMMOperationProducts";
        public const string MMFormulaConfigurationGridControl = "fld_dgcMMFormulaConfigurations";
        public const string PackingMaterialSpecialityGridControl = "fld_dgcMaterialSpeciality";
        public const string PackingMaterialSizeGridControl = "fld_dgcPackingMaterialSize";
        public const string PackingMaterialWeightPerVolumeGridControl = "fld_dgcMaterialWeightPerVolume";
        public const string MMOverallInsideDimensionConfigsGridControl = "fld_dgcMMOverallInsideDimensionConfigs";
        public const string MMExchangeMeasureUnitConfigsGridControl = "fld_dgcMMExchangeMeasureUnitConfigs";
        public const string ICPerimeterGroupsGridControl = "fld_dgcICPerimeterGroups";
        public const string ICLengthGroupsGridControl = "fld_dgcICLengthGroups";
        public const string ICWidthGroupsGridControl = "fld_dgcICWidthGroups";
        public const string ICModelConfigsGridControl = "fld_dgcICModels";
        public const string MMQuantityAllocationPercentConfigsGridControl = "fld_dgcMMQuantityAllocationPercentConfigs";
        public const string ICModelDetailConfigsGridControl = "fld_dgcICModelDetails";
        public const string MMLabourProductivityTargetConfigsGridControl = "fld_dgcMMLabourProductivityTargetConfigs";
        public const string SemiGroupTypeListGridControl = "fld_dgcSemiGroupType";
        public const string MMConfigAccountOperationsGridControl = "fld_dgcMMConfigAccountOperations";
        public const string ConfigThinkAccordWoodTypesGridControl = "fld_dgcICConfigThinkAccordWoodType";
        public const string ConfigQualityAccordWoodTypesGridControl = "fld_dgcICConfigQualityAccordWoodType";
        public const string ProductionCompletionTimeConfigsGridControl = "fld_dgcMMProductionCompletionTimeConfigs";
        public const string ExecuteTimeConfigsGridControl = "fld_dgcMMExecuteTimeConfig";
        public const string DepartmentAndOperationsGridControl = "fld_dgcMMDepartmentAndOperations";
        public const string DirectoryPathConfigGridControl = "fld_dgcADDirectoryPathConfigs";
        public const string DepartmentCapacityConfigsGridControl = "fld_dgcMMDepartmentCapacityConfigs";
        public const string ProductGroupTypeSwitchingConfigsGridControl = "fld_dgcMMProductGroupTypeSwitchingConfigs";
        public const string AllocationOperationConfigGridControl = "fld_dgcMMAllocationOperationConfigs";
        public const string DefaultAllocationOperationConfigGridControl = "fld_dgcMMDefaultAllocationOperationConfigs";
        public const string ConfigMaterialShipmentUtilityGridControl = "fld_dgcMMConfigMaterialShipmentUtilitys";
        public const string ADConfigValueConfigProductionComplexityType = "ConfigProductionComplexityType";
        public const string ConfigProductionComplexityType = "ConfigProductionComplexityType";
        public const string cstConfigProductionComplexityTypeGridControl = "fld_dgcConfigProductionComplexityType";
        #endregion
        public ProductConstantModule()
        {
            Name = "ProductConstant";
            CurrentModuleEntity = new ProductConstantEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            BOSApp.InvalidateProductList();
        }
        public override void InitializeScreens()
        {
            guiConfigurationattributes guiConfigurationattributes = new guiConfigurationattributes();
            guiConfigurationattributes.ScreenNumber = "DMPC";
            guiConfigurationattributes.Module = this;
            guiConfigurationattributes.InitializeControls(guiConfigurationattributes.Controls);
            guiConfigurationattributes.AddControlsToParentScreen();

        }
        public override void Show()
        {
            base.Show();
            DevExpress.XtraTreeList.TreeList trlSection2s = (DevExpress.XtraTreeList.TreeList)Controls["fld_trlSection2s"];
            trlSection2s.AppendNode(new object[] { ProductConstantLocalizedResources.ProductionNormConfig }, -1, "ProductionNormConfig");
            trlSection2s.AppendNode(new object[] { ProductConstantLocalizedResources.Productattributes }, -1, "Productattributes");
            trlSection2s.AppendNode(new object[] { ProductConstantLocalizedResources.ReuseSpecificateConfigs }, -1, "ReuseSpecificateConfigs");
            trlSection2s.AppendNode(new object[] { ProductConstantLocalizedResources.ConsumableConfigs }, -1, "ConsumableConfigs");
            trlSection2s.AppendNode(new object[] { ProductConstantLocalizedResources.ExchangeRateConfigs }, -1, "ExchangeRateConfigs");
            trlSection2s.AppendNode(new object[] { ProductConstantLocalizedResources.ProductionNormItemConfigs }, -1, "ProductionNormItemConfigs");
            trlSection2s.AppendNode(new object[] { ProductConstantLocalizedResources.MMFormulaConfigurations }, -1, "MMFormulaConfigurations");
            trlSection2s.AppendNode(new object[] { ProductConstantLocalizedResources.MMCalMaterialConfigs }, -1, "MMCalMaterialConfigs");
            trlSection2s.AppendNode(new object[] { ProductConstantLocalizedResources.ICProductattributes }, -1, "ICProductattributes");

            trlSection2s.AppendNode(new object[] { ProductConstantLocalizedResources.MMOverallInsideDimensionConfigs }, -1, "MMOverallInsideDimensionConfigs");
            trlSection2s.AppendNode(new object[] { ProductConstantLocalizedResources.MMExchangeMeasureUnitConfigs }, -1, "MMExchangeMeasureUnitConfigs");

            trlSection2s.AppendNode(new object[] { ProductConstantLocalizedResources.ICModel }, -1, "ICModel");
            trlSection2s.AppendNode(new object[] { ProductConstantLocalizedResources.MMQuantityAllocationPercentConfig }, -1, "MMQuantityAllocationPercentConfig");
            trlSection2s.AppendNode(new object[] { ProductConstantLocalizedResources.MMLabourProductivityTargetConfig }, -1, "MMLabourProductivityTargetConfig");
            trlSection2s.AppendNode(new object[] { ProductConstantLocalizedResources.OperationProduct }, -1, "OperationProduct");
            trlSection2s.AppendNode(new object[] { ProductConstantLocalizedResources.MMConfigAccountOperations }, -1, "ConfigAccountOperation");
            trlSection2s.AppendNode(new object[] { ProductConstantLocalizedResources.ExecuteTimeConfig }, -1, "ExecuteTimeConfig");
            trlSection2s.AppendNode(new object[] { ProductConstantLocalizedResources.DirectoryPath }, -1, "DirectoryPath");
            trlSection2s.Nodes[0].Selected = true;
            trlSection2s.BestFitColumns();
        }
        public void InvalidateOptionValueConfigList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttribute = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeWoodTypeColumnName);
            if (productAttribute != null)
            {
                entity.WoodTypeList.Invalidate(productAttribute);
                entity.WoodTypeList.GridControl.RefreshDataSource();
            }
        }

        public void InvalidateAddMaterialConfigList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttribute = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeAddMaterialTypeColumnName);
            if (productAttribute != null)
            {
                entity.AddMaterialTypeList.Invalidate(productAttribute);
                entity.AddMaterialTypeList.GridControl.RefreshDataSource();
            }
        }
        public void InvalidateSemiGroupTypeConfigList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> SemiGruopTypeAttribute = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeGroupSemiTypeColumnName);
            if (SemiGruopTypeAttribute != null)
            {
                entity.SemiGroupTypeList.Invalidate(SemiGruopTypeAttribute);
                if (entity.SemiGroupTypeList.GridControl != null)
                    entity.SemiGroupTypeList.GridControl.RefreshDataSource();
            }
        }
        public void InvalidateColorList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttribute = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeColorColumnName);
            if (productAttribute != null)
            {
                entity.CoLorList.Invalidate(productAttribute);
                entity.CoLorList.GridControl.RefreshDataSource();
            }
        }

        public void InvalidateHTTypeList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttribute = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeHTTypeColumnName);
            if (productAttribute != null)
            {
                entity.HTTypeList.Invalidate(productAttribute);
                entity.HTTypeList.GridControl.RefreshDataSource();
            }
        }
        public void InvalidateTTMTList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICProductAttributesController objConfigValuesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttribute = objConfigValuesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeTTMTColumnName);
            if (productAttribute != null)
            {
                entity.TTMTList.Invalidate(productAttribute);
                entity.TTMTList.GridControl.RefreshDataSource();
            }
        }
        public void InvalidateQualityList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICProductAttributesController objConfigValuesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttribute = objConfigValuesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeQualityColumnName);
            if (productAttribute != null)
            {
                entity.QualityList.Invalidate(productAttribute);
                entity.QualityList.GridControl.RefreshDataSource();
            }
        }
        public void InvalidateThickList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICProductAttributesController objConfigValuesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttribute = objConfigValuesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeThickColumnName);
            if (productAttribute != null)
            {
                entity.ThickList.Invalidate(productAttribute);
                entity.ThickList.GridControl.RefreshDataSource();
            }
        }
        public void InvalidateConfigThinkAccordWoodTypeList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICConfigAccordWoodTypesController objConfigAccordWoodTypesController = new ICConfigAccordWoodTypesController();
            List<ICConfigAccordWoodTypesInfo> productAttribute = objConfigAccordWoodTypesController.GetConfigAccordWoodTypeByAttributeType(MatchCodeConst.MatchCodeThickColumnName);
            if (productAttribute != null)
            {
                entity.ConfigThinkAccordWoodTypeList.Invalidate(productAttribute);
                if (entity.ConfigThinkAccordWoodTypeList.GridControl != null)
                    entity.ConfigThinkAccordWoodTypeList.GridControl.RefreshDataSource();
            }
        }
        public void InvalidateConfigQualityAccordWoodTypeList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICConfigAccordWoodTypesController objConfigAccordWoodTypesController = new ICConfigAccordWoodTypesController();
            List<ICConfigAccordWoodTypesInfo> productAttribute = objConfigAccordWoodTypesController.GetConfigAccordWoodTypeByAttributeType(MatchCodeConst.MatchCodeQualityColumnName);
            if (productAttribute != null)
            {
                entity.ConfigQualityAccordWoodTypeList.Invalidate(productAttribute);
                if (entity.ConfigQualityAccordWoodTypeList.GridControl != null)
                    entity.ConfigQualityAccordWoodTypeList.GridControl.RefreshDataSource();
            }
        }
        //
        public void InvalidateReuseSpecificateConfigList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMReuseSpecificateConfigsController objReuseSpecificateConfigsController = new MMReuseSpecificateConfigsController();
            DataSet ds = objReuseSpecificateConfigsController.GetAllObjects();
            if (ds != null)
            {
                entity.ReuseSpecificateList.Invalidate(ds);
                entity.ReuseSpecificateList.GridControl.RefreshDataSource();
            }
            ds.Dispose();
        }
        //
        public void InvalidateConsumableConfigList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMConsumableConfigsController objReuseSpecificateConfigsController = new MMConsumableConfigsController();
            DataSet ds = objReuseSpecificateConfigsController.GetAllObjects();
            if (ds != null)
            {
                entity.ConsumableConfigList.Invalidate(ds);
                entity.ConsumableConfigList.GridControl.RefreshDataSource();
            }
            ds.Dispose();
        }
        //
        public void InvalidateExchangeRateConfigList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMExchangeRateConfigsController objReuseSpecificateConfigsController = new MMExchangeRateConfigsController();
            DataSet ds = objReuseSpecificateConfigsController.GetAllObjects();
            if (ds != null)
            {
                entity.ExchangeRateConfigList.Invalidate(ds);
                entity.ExchangeRateConfigList.GridControl.RefreshDataSource();
            }
            ds.Dispose();
        }
        public void InvalidateOperationProductList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMOperationProductsController ctrl = new MMOperationProductsController();
            DataSet ds = ctrl.GetAllObjects();
            if (ds != null)
            {
                entity.OperationProductList.Invalidate(ds);
                entity.OperationProductList.GridControl.RefreshDataSource();
            }
            ds.Dispose();
        }
        public void InvalidateCalMaterialConfigs()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMCalMaterialConfigsController ctrl = new MMCalMaterialConfigsController();
            DataSet ds = ctrl.GetAllObjects();
            if (ds != null)
            {
                entity.CalMaterialConfigList.Invalidate(ds);
                entity.CalMaterialConfigList.GridControl.RefreshDataSource();
            }
            ds.Dispose();
        }

        public void InvalidateAttributesList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICProductAttributesController objICProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttribute = objICProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeSpecialityColumnName);
            if (productAttribute != null)
            {
                entity.AttributesList.Invalidate(productAttribute);
                entity.AttributesList.GridControl.RefreshDataSource();
            }
        }
        public void InvalidateProductGroupHeightsList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICProductGroupHeightsController objICProductGroupHeightsController = new ICProductGroupHeightsController();
            List<ICProductGroupHeightsInfo> productGroupHeights = objICProductGroupHeightsController.GetAllProductGroupHeights();
            if (productGroupHeights != null)
            {
                entity.ProductGroupHeightsList.Invalidate(productGroupHeights);
                entity.ProductGroupHeightsList.GridControl.RefreshDataSource();
            }
        }
        public void InvalidatePackingMaterialSpeciality()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttribute = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodePackingMaterialSpecialityColumnName);
            if (productAttribute != null)
            {
                entity.PackingMaterialSpecialityList.Invalidate(productAttribute);
                entity.PackingMaterialSpecialityList.GridControl.RefreshDataSource();
            }
        }
        public void InvalidatePackingMaterialSize()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttribute = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodePackingMaterialSizeColumnName);
            if (productAttribute != null)
            {
                entity.PackingMaterialSizeList.Invalidate(productAttribute);
                entity.PackingMaterialSizeList.GridControl.RefreshDataSource();
            }
        }
        public void InvalidatePackingMaterialWeightPerVolume()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttribute = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodePackingMaterialWeightPerVolumeColumnName);
            if (productAttribute != null)
            {
                entity.PackingMaterialWeightPerVolumeList.Invalidate(productAttribute);
                entity.PackingMaterialWeightPerVolumeList.GridControl.RefreshDataSource();
            }
        }
        public void InvalidateMaterialMarketDimensions()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMPackingMaterialMarketDimensionsController objProductAttributesController = new MMPackingMaterialMarketDimensionsController();
            DataSet ds = objProductAttributesController.GetAllObjects();
            if (ds != null)
            {
                entity.PackingMaterialMarketDimensionList.Invalidate(ds);
                entity.PackingMaterialMarketDimensionList.GridControl.RefreshDataSource();
            }
        }

        public void InvalidateQuantityAllocationPercentConfig()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMQuantityAllocationPercentConfigsController objQuantityAllocationPercentConfigsController = new MMQuantityAllocationPercentConfigsController();
            List<MMQuantityAllocationPercentConfigsInfo> QuantityAllocationPercentConfigList = (List<MMQuantityAllocationPercentConfigsInfo>)objQuantityAllocationPercentConfigsController.GetListFromDataSet(objQuantityAllocationPercentConfigsController.GetAllObjects());
            if (QuantityAllocationPercentConfigList != null)
            {
                entity.QuantityAllocationPercentConfigsList.Invalidate(QuantityAllocationPercentConfigList);
                entity.QuantityAllocationPercentConfigsList.GridControl.RefreshDataSource();
            }
        }
        public void InvalidateLabourProductivityTargetConfig()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMLabourProductivityTargetConfigsController objLabourProductivityTargetConfigsController = new MMLabourProductivityTargetConfigsController();
            List<MMLabourProductivityTargetConfigsInfo> LabourProductivityTargetConfigList = (List<MMLabourProductivityTargetConfigsInfo>)objLabourProductivityTargetConfigsController.GetListFromDataSet(objLabourProductivityTargetConfigsController.GetAllObjects());
            if (LabourProductivityTargetConfigList != null)
            {
                entity.LabourProductivityTargetConfigsList.Invalidate(LabourProductivityTargetConfigList);
                entity.LabourProductivityTargetConfigsList.GridControl.RefreshDataSource();
            }
        }
        //public void InvalidateICProductAttributeWoodsList()
        //{
        //    ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
        //    ICProductAttributeWoodsController objPAWController = new ICProductAttributeWoodsController();
        //    DataSet ds = objPAWController.GetAllObjects();
        //    entity.ICProductAttributeWoodsList.Invalidate(ds);
        //}
        public void InvalidatePerimeterAndLengthGroupList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICPerimeterGroupsController objPAWController = new ICPerimeterGroupsController();
            DataSet ds = objPAWController.GetAllObjects();
            entity.ICPerimeterGroupsList.Invalidate(ds);

            ICLengthGroupsController objLGController = new ICLengthGroupsController();
            ds = objLGController.GetAllObjects();
            entity.ICLengthGroupsList.Invalidate(ds);

            ICMaterialConfigsController objMCController = new ICMaterialConfigsController();
            ds = objMCController.GetAllObjects();
            entity.ICMaterialConfigsList.Invalidate(ds);

            ICWidthGroupsController objWGController = new ICWidthGroupsController();
            ds = objWGController.GetAllObjects();
            entity.ICWidthGroupsList.Invalidate(ds);
        }
        public void InvalidateConfigAccountOperationList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMConfigAccountOperationsController ctrl = new MMConfigAccountOperationsController();
            DataSet ds = ctrl.GetAllObjects();
            if (ds != null)
            {
                entity.ConfigAccountOperationList.Invalidate(ds);
                entity.ConfigAccountOperationList.GridControl.RefreshDataSource();
            }
            ds.Dispose();
        }
        public void InvalidateConfigProductionCompletionTimeList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMProductionCompletionTimeConfigsController ctrl = new MMProductionCompletionTimeConfigsController();
            DataSet ds = ctrl.GetAllObjects();
            if (ds != null)
            {
                entity.ConfigProductionCompletionTimeList.Invalidate(ds);
                entity.ConfigProductionCompletionTimeList.GridControl.RefreshDataSource();
            }
            ds.Dispose();
        }
        public void InvalidateConfigExecuteTimeList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMExecuteTimeConfigsController ctrl = new MMExecuteTimeConfigsController();
            DataSet ds = ctrl.GetAllObjects();
            if (ds != null)
            {
                entity.ConfigExecuteTimeList.Invalidate(ds);
                entity.ConfigExecuteTimeList.GridControl.RefreshDataSource();
            }
            ds.Dispose();
        }
        public void InvalidateDepartmentAndOperationList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMDepartmentAndOperationsController ctrl = new MMDepartmentAndOperationsController();
            DataSet ds = ctrl.GetAllObjects();
            if (ds != null)
            {
                entity.DepartmentAndOperationList.Invalidate(ds);
                entity.DepartmentAndOperationList.GridControl.RefreshDataSource();
            }
            ds.Dispose();
        }

        public void InvalidateDepartmentCapacityConfigList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMDepartmentCapacityConfigsController ctrl = new MMDepartmentCapacityConfigsController();
            DataSet ds = ctrl.GetAllObjects();
            if (ds != null)
            {
                entity.DepartmentCapacityConfigList.Invalidate(ds);
                entity.DepartmentCapacityConfigList.GridControl.RefreshDataSource();
            }
            ds.Dispose();
        }

        public void InvalidateProductGroupTypeSwitchingConfigList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMProductGroupTypeSwitchingConfigsController ctrl = new MMProductGroupTypeSwitchingConfigsController();
            DataSet ds = ctrl.GetAllObjects();
            if (ds != null)
            {
                entity.ProductGroupTypeSwitchingConfigList.Invalidate(ds);
                entity.ProductGroupTypeSwitchingConfigList.GridControl.RefreshDataSource();
            }
            ds.Dispose();
        }

        public void RemoveSelectedICLengthGroups()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ICLengthGroupsList.RemoveSelectedRowObjectFromList();
        }

        public void RemoveSelectedICWidthGroups()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ICWidthGroupsList.RemoveSelectedRowObjectFromList();
        }

        public void InvalidateConfigDirectoryPathList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ADDirectoryPathConfigsController ctrl = new ADDirectoryPathConfigsController();
            DataSet ds = ctrl.GetInvalidateDirectoryPathList();
            if (ds != null)
            {
                entity.DirectoryPathList.Invalidate(ds);
                entity.DirectoryPathList.GridControl.RefreshDataSource();
            }
            ds.Dispose();
        }
        public void InvalidateAllocationOperationConfig()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMAllocationOperationConfigsController ctrl = new MMAllocationOperationConfigsController();
            DataSet ds = ctrl.GetAllocationOperationConfigList();
            if (ds != null)
            {
                entity.AllocationOperationConfigList.Invalidate(ds);
                entity.AllocationOperationConfigList.GridControl.RefreshDataSource();
            }
            ds.Dispose();
        }
        public void InvalidateDefaultAllocationOperationConfig()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMDefaultAllocationOperationConfigsController ctrl = new MMDefaultAllocationOperationConfigsController();
            DataSet ds = ctrl.GetDefaultAllocationOperationConfigList();
            if (ds != null)
            {
                entity.DefaultAllocationOperationConfigList.Invalidate(ds);
                entity.DefaultAllocationOperationConfigList.GridControl.RefreshDataSource();
            }
            ds.Dispose();
        }

        public void InvalidateConfigMaterialShipmentUtility()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMConfigMaterialShipmentUtilitysController ctrl = new MMConfigMaterialShipmentUtilitysController();
            DataSet ds = ctrl.GetConfigMaterialShipmentUtilityList();
            if (ds != null)
            {
                entity.ConfigMaterialShipmentUtilityList.Invalidate(ds);
                entity.ConfigMaterialShipmentUtilityList.GridControl.RefreshDataSource();
            }
            ds.Dispose();
        }
        public void InvalidateConfigProductionComplexityType()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;

            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ConfigProductionComplexityType.ToString());
            if (ds != null)
            {
                entity.ConfigProductionComplexityTypeList.Invalidate(ds);
                entity.ConfigProductionComplexityTypeList.GridControl.RefreshDataSource();
            }
            ds.Dispose();
        }
        public void RemoveAttributes()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.AttributesList.RemoveSelectedRowObjectFromList();
        }
        public void RemoveSelectedICPerimeterGroups()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ICPerimeterGroupsList.RemoveSelectedRowObjectFromList();
        }
        //Remove selectAttributeHeights gird control
        public void RemoveAttributeGroupHeights()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ProductGroupHeightsList.RemoveSelectedRowObjectFromList();
        }
        //Remove selected Woodtype grid control
        public void RemoveSelectedWoodType()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.WoodTypeList.RemoveSelectedRowObjectFromList();
        }
        //Remove selected Woodtype grid control
        public void RemoveSelectedAddMaterialType()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.AddMaterialTypeList.RemoveSelectedRowObjectFromList();
        }
        public void RemoveSelectedSemiGroupTypeList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.SemiGroupTypeList.RemoveSelectedRowObjectFromList();
        }
        //Remove selected CoLor gird Control
        public void RemoveSelectedCoLor()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.CoLorList.RemoveSelectedRowObjectFromList();
        }
        //Remove select MMFormulaConfigurationsList
        public void RemoveMMFormulaConfigurationsList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.MMFormulaConfigurationsList.RemoveSelectedRowObjectFromList();
        }
        //Remove select MMFormulaAddMaterialConfigList
        public void RemoveMMFormulaAddMaterialConfigList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.MMFormulaAddmaterialConfigList.RemoveSelectedRowObjectFromList();
        }
        //Remove selected HTType grid Control
        public void RemoveSelectedHTType()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.HTTypeList.RemoveSelectedRowObjectFromList();
        }
        //Remove selected TTMT grid Control
        public void RemoveSelectedTTMT()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.TTMTList.RemoveSelectedRowObjectFromList();
        }
        //Remove selected Quality grid Control
        public void RemoveSelectedQuality()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.QualityList.RemoveSelectedRowObjectFromList();
        }
        //Remove selected ReuseSpecificate grid Control
        public void RemoveSelectReuseSpecificate()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ReuseSpecificateList.RemoveSelectedRowObjectFromList();
        }
        //Remove selected ConsumableConfig grid Control
        public void RemoveSelectConsumableConfig()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ConsumableConfigList.RemoveSelectedRowObjectFromList();
        }
        //Remove selected ExchangeRateConfig grid Control
        public void RemoveSelectExchangeRateConfig()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ExchangeRateConfigList.RemoveSelectedRowObjectFromList();
        }
        public void RemoveSelectOperationProduct()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.OperationProductList.RemoveSelectedRowObjectFromList();
        }

        //Remove selected RemoveSelectedMaterialSpeciality grid Control
        public void RemoveSelectedMaterialSpeciality()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.PackingMaterialSpecialityList.RemoveSelectedRowObjectFromList();
        }
        //Remove selected RemoveSelectedPackingMaterialSize grid Control
        public void RemoveSelectedPackingMaterialSize()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.PackingMaterialSizeList.RemoveSelectedRowObjectFromList();
        }
        //Remove selected RemoveSelectedMaterialWeightPerVolume grid Control
        public void RemoveSelectedMaterialWeightPerVolume()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.PackingMaterialWeightPerVolumeList.RemoveSelectedRowObjectFromList();
        }
        public void RemoveSelectedMaterialMarketDimensions()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.PackingMaterialMarketDimensionList.RemoveSelectedRowObjectFromList();
        }
        //Remove selected RemoveSelectedMaterialWeightPerVolume grid Control
        public void RemoveSelectedMMExchangeMeasureUnitConfigs()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.MMExchangeMeasureUnitConfigsList.RemoveSelectedRowObjectFromList();
        }

        public void RemoveSelectModelConfig()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ModelList.RemoveSelectedRowObjectFromList();
        }
        public void RemoveSelectQuantityAllocationPercentConfigList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.QuantityAllocationPercentConfigsList.RemoveSelectedRowObjectFromList();
        }
        public void RemoveSelectedICMaterialConfigs()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ICMaterialConfigsList.RemoveSelectedRowObjectFromList();
        }
        public void RemoveSelectLabourProductivityTargetConfigList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.LabourProductivityTargetConfigsList.RemoveSelectedRowObjectFromList();
        }

        public void RemoveSelectModelDetailConfig()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ModelDetailsList.RemoveSelectedRowObjectFromList();
        }
        public void RemoveSelectedConfigAccountOperationList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ConfigAccountOperationList.RemoveSelectedRowObjectFromList();
        }
        public void RemoveSelectedProductionCompletionTimeList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ConfigProductionCompletionTimeList.RemoveSelectedRowObjectFromList();
        }
        public void RemoveAllocationOperationConfigList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.AllocationOperationConfigList.RemoveSelectedRowObjectFromList();
        }
        public void RemoveDefaultAllocationOperationConfigList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.DefaultAllocationOperationConfigList.RemoveSelectedRowObjectFromList();
        }

        public void RemoveConfigMaterialShipmentUtilityList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ConfigMaterialShipmentUtilityList.RemoveSelectedRowObjectFromList();
        }
        public void RemoveSelectedConfigExecuteTimeList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ConfigExecuteTimeList.RemoveSelectedRowObjectFromList();
        }
        public void RemoveSelectedDepartmentAndOperationList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.DepartmentAndOperationList.RemoveSelectedRowObjectFromList();
        }

        public void RemoveSelectedDepartmentCapacityConfigList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.DepartmentCapacityConfigList.RemoveSelectedRowObjectFromList();
        }
        public void RemoveSelectedProductGroupTypeSwitchingConfigList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ProductGroupTypeSwitchingConfigList.RemoveSelectedRowObjectFromList();
        }
        public void RemoveSelectDirectoryPath()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.DirectoryPathList.RemoveSelectedRowObjectFromList();
        }
        public bool SavePerimeterAndLengthList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ICPerimeterGroupsList.SaveItemObjects();
            entity.ICLengthGroupsList.SaveItemObjects();
            entity.ICMaterialConfigsList.SaveItemObjects();
            entity.ICWidthGroupsList.SaveItemObjects();
            return true;
        }
        // Save Productattributes

        public bool SaveProductattributes()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)entity.ModuleObjects[TableName.ICProductattributesTableName];
            ICProductGroupHeightsController objProductGroupHeightsController = new ICProductGroupHeightsController();
            ICProductGroupHeightsInfo objProductGroupHeightsInfo = (ICProductGroupHeightsInfo)entity.ModuleObjects[TableName.ICProductGroupHeightsTableName];
            //objProductAttributesController.UpdateObject(objProductAttributesInfo);

            bool isComplete = SaveProductValues(MatchCodeConst.MatchCodeWoodTypeColumnName, (WoodTypeGridControl)Controls[icpWoodTypeGridControl]);
            if (isComplete)
            {
                isComplete = SaveProductValues(MatchCodeConst.MatchCodeColorColumnName, (CoLorGridControl)Controls[icpCoLorGridControl]);
            }
            if (isComplete)
            {
                isComplete = SaveProductValues(MatchCodeConst.MatchCodeHTTypeColumnName, (HTTypeGridControl)Controls[icpHTTypeGridControl]);
            }
            if (isComplete)
            {
                isComplete = SaveProductValues(MatchCodeConst.MatchCodeTTMTColumnName, (TTMTGridControl)Controls[icpTTMTGridControl]);
            }
            if (isComplete)
            {
                isComplete = SaveProductValues(MatchCodeConst.MatchCodeQualityColumnName, (QualityGridControl)Controls[icpQualityGridControl]);
            }
            if (isComplete)
            {
                isComplete = SaveProductValues(MatchCodeConst.MatchCodeSpecialityColumnName, (QualityGridControl)Controls[icpAttributesGridControl]);
            }
            if (isComplete)
            {
                isComplete = SaveProductValues(MatchCodeConst.MatchCodeAddMaterialTypeColumnName, (AddMaterialGridControl)Controls[icpAddMaterialTypeGridControl]);
            }
            if (isComplete)
            {
                isComplete = SaveProductHeight();
            }
            if (isComplete)
            {
                isComplete = SaveProductValues(MatchCodeConst.MatchCodeGroupSemiTypeColumnName, (CauHinhNhomCumGridControl)Controls[SemiGroupTypeListGridControl]);
            }
            if (isComplete)
            {
                isComplete = SaveProductValues(MatchCodeConst.MatchCodeThickColumnName, (ThickGridControl)Controls["fld_dgcThickGridControl"]);
            }
            if (isComplete)
            {
                isComplete = SavePerimeterAndLengthList();
            }
            if (isComplete)
            {
                isComplete = SaveConfigWoodTypeValues(MatchCodeConst.MatchCodeThickColumnName, (ConfigThinkAccordWoodGridControl)Controls[ConfigThinkAccordWoodTypesGridControl]);
            }
            if (isComplete)
            {
                isComplete = SaveConfigWoodTypeValues(MatchCodeConst.MatchCodeQualityColumnName, (ConfigQualityAccordWoodGridControl)Controls[ConfigQualityAccordWoodTypesGridControl]);
            }
            return isComplete;
        }
        public bool SaveProductHeight()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            BOSList<ICProductGroupHeightsInfo> ProductGroupHeightValues = null;

            ProductGroupHeightValues = entity.ProductGroupHeightsList;
            if (ProductGroupHeightValues != null)
            {
                foreach (ICProductGroupHeightsInfo objProductGroupHeightsInfo in ProductGroupHeightValues)
                {
                    if (objProductGroupHeightsInfo.ICProductGroupHeightID == 0)
                    {
                        //objProductGroupHeightsInfo.ICProductAttributeGroup = strGroup;			
                    }
                }
                ProductGroupHeightValues.SaveItemObjects();
            }
            return true;
        }
        #region Config Values
        /// <summary>
        /// Save the changes to config values from user
        /// </summary>        
        public bool SaveProductValues(String strGroup, BOSGridControl gridControl)
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            BOSList<ICProductAttributesInfo> ProductValues = null;
            if (strGroup == MatchCodeConst.MatchCodeWoodTypeColumnName.ToString())
            {
                ProductValues = entity.WoodTypeList;
            }
            else if (strGroup == MatchCodeConst.MatchCodeAddMaterialTypeColumnName.ToString())
            {
                ProductValues = entity.AddMaterialTypeList;
            }
            else if (strGroup == MatchCodeConst.MatchCodeColorColumnName.ToString())
            {
                ProductValues = entity.CoLorList;
            }
            else if (strGroup == MatchCodeConst.MatchCodeHTTypeColumnName.ToString())
            {
                ProductValues = entity.HTTypeList;
            }
            else if (strGroup == MatchCodeConst.MatchCodeTTMTColumnName.ToString())
            {
                ProductValues = entity.TTMTList;
            }
            else if (strGroup == MatchCodeConst.MatchCodeQualityColumnName.ToString())
            {
                ProductValues = entity.QualityList;
            }
            else if (strGroup == MatchCodeConst.MatchCodeThickColumnName.ToString())
            {
                ProductValues = entity.ThickList;
                ProductValues.ForEach(i => i.ICProductAttributeNo = i.ICProductAttributeValue);
            }
            else if (strGroup == MatchCodeConst.MatchCodeSpecialityColumnName.ToString())
            {
                ProductValues = entity.AttributesList;
            }
            else if (strGroup == MatchCodeConst.MatchCodePackingMaterialSpecialityColumnName.ToString())
            {
                ProductValues = entity.PackingMaterialSpecialityList;
            }
            else if (strGroup == MatchCodeConst.MatchCodePackingMaterialSizeColumnName.ToString())
            {
                ProductValues = entity.PackingMaterialSizeList;
            }
            else if (strGroup == MatchCodeConst.MatchCodePackingMaterialWeightPerVolumeColumnName.ToString())
            {
                ProductValues = entity.PackingMaterialWeightPerVolumeList;
            }

            else if (strGroup == MatchCodeConst.MatchCodeGroupSemiTypeColumnName.ToString())
            {
                ProductValues = entity.SemiGroupTypeList;
            }
            if (ProductValues != null)
            {
                foreach (ICProductAttributesInfo objProductAttributesInfo in ProductValues)
                {
                    if (objProductAttributesInfo.ICProductAttributeID == 0)
                    {
                        objProductAttributesInfo.ICProductAttributeGroup = strGroup;
                    }
                }
                ProductValues.SaveItemObjects();
            }
            return true;
        }
        public bool SaveConfigWoodTypeValues(String strGroup, BOSGridControl gridControl)
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            BOSList<ICConfigAccordWoodTypesInfo> ProductValues = null;
            if (strGroup == MatchCodeConst.MatchCodeQualityColumnName.ToString())
            {
                ProductValues = entity.ConfigQualityAccordWoodTypeList;
            }
            else if (strGroup == MatchCodeConst.MatchCodeThickColumnName.ToString())
            {
                ProductValues = entity.ConfigThinkAccordWoodTypeList;
            }
            if (ProductValues != null)
            {
                foreach (ICConfigAccordWoodTypesInfo objProductAttributesInfo in ProductValues)
                {
                    if (objProductAttributesInfo.ICConfigAccordWoodTypeID == 0)
                    {
                        objProductAttributesInfo.ICConfigAccordWoodTypeAttributeType = strGroup;
                    }
                }
                ProductValues.SaveItemObjects();
            }
            return true;
        }
        #endregion


        // Save ReuseSpecificateConfigs
        public bool SaveReuseSpecificateConfigs()
        {
            bool isSuccess = SaveReuseSpecificateconfig();
            if (isSuccess)
            {
                isSuccess = SaveReuseSpecificate();
            }
            return isSuccess;
        }

        public bool SaveReuseSpecificate()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            //    BOSList<MMReuseSpecificateConfigsInfo> ReuseSpecificateValues = null;
            //    ReuseSpecificateValues = entity.ReuseSpecificateList;
            //    if (ReuseSpecificateValues != null)
            //    {
            //        foreach (MMReuseSpecificateConfigsInfo objReuseSpecificateConfigsInfo in ReuseSpecificateValues)
            //        {
            //            if (objReuseSpecificateConfigsInfo.MMReuseSpecificateConfigAttributeValue == null)
            //            {
            //                MessageBox.Show(ProductConstantLocalizedResources.SaveFailfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                return false;
            //            }
            //            else
            return entity.SaveReuseSpecificateConfigsList();
            //        }


            //}
        }
        public bool SaveReuseSpecificateconfig()
        {
            MMReuseSpecificateConfigsController objReuseSpecificateConfigsController = new MMReuseSpecificateConfigsController();
            MMReuseSpecificateConfigsInfo objReuseSpecificateConfigsInfo = (MMReuseSpecificateConfigsInfo)CurrentModuleEntity.ModuleObjects[TableName.MMReuseSpecificateConfigsTableName];
            if (objReuseSpecificateConfigsInfo != null)
            {
                objReuseSpecificateConfigsController.UpdateObject(objReuseSpecificateConfigsInfo);

                //Update current company info
                // BOSApp.CurrentCompanyInfo = objReuseSpecificateConfigsInfo;
            }
            return true;
        }

        //Save ConsumableConfigs
        public bool SaveConsumableConfigs()
        {
            bool isSuccess = UpdateConsumableConfig();
            if (isSuccess)
            {
                return SaveConsumableConfig();
            }
            return isSuccess;
        }
        public bool SaveConsumableConfig()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            return entity.SaveConsumableConfigList();
        }
        public bool UpdateConsumableConfig()
        {
            MMConsumableConfigsController objConsumableConfigsController = new MMConsumableConfigsController();
            MMConsumableConfigsInfo objConsumableConfigsInfo = (MMConsumableConfigsInfo)CurrentModuleEntity.ModuleObjects[TableName.MMConsumableConfigsTableName];
            if (objConsumableConfigsInfo != null)
            {
                if (objConsumableConfigsInfo.MMConsumableConfigValue >= 0)
                {
                    objConsumableConfigsController.UpdateObject(objConsumableConfigsInfo);
                    return true;
                }
            }
            return false;
        }

        // Save ExchangeRateConfigs
        public bool SaveExchangeRateConfigs()
        {
            bool isSuccess = UpdateExchangeRateConfig();
            if (isSuccess)
            {
                isSuccess = SaveExchangeRateConfig();
            }
            return isSuccess;
        }

        public bool SaveExchangeRateConfig()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            return entity.SaveExchangeRateConfigList();

        }

        public bool SaveOperationProductConfig()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            return entity.SaveOperationProductList();

        }



        public bool UpdateExchangeRateConfig()
        {
            MMExchangeRateConfigsController objExchangeRateConfigsController = new MMExchangeRateConfigsController();
            MMExchangeRateConfigsInfo objExchangeRateConfigsInfo = (MMExchangeRateConfigsInfo)CurrentModuleEntity.ModuleObjects[TableName.MMExchangeRateConfigsTableName];
            if (objExchangeRateConfigsInfo != null)
            {
                objExchangeRateConfigsController.UpdateObject(objExchangeRateConfigsInfo);
            }
            return true;
        }

        // Save ICProductattributes

        public bool SaveICProductattributes()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)entity.ModuleObjects[TableName.ICProductattributesTableName];
            // objProductAttributesController.UpdateObject(objProductAttributesInfo);

            bool isComplete = SaveProductValues(MatchCodeConst.MatchCodePackingMaterialSpecialityColumnName, (MaterialSpecialityGridControl)Controls[PackingMaterialSpecialityGridControl]);
            if (isComplete)
            {
                isComplete = SaveProductValues(MatchCodeConst.MatchCodePackingMaterialSizeColumnName, (PackingMaterialSizeGridControl)Controls[PackingMaterialSizeGridControl]);
            }
            if (isComplete)
            {
                isComplete = SaveProductValues(MatchCodeConst.MatchCodePackingMaterialWeightPerVolumeColumnName, (MaterialWeightPerVolumeGridControl)Controls[PackingMaterialWeightPerVolumeGridControl]);
            }

            SavePackingMaterialMarketDimension();
            return isComplete;
        }
        public bool SavePackingMaterialMarketDimension()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.PackingMaterialMarketDimensionList.SaveItemObjects();
            return true;

        }
        public void ChangeItemMaterialMarketDimensions(MMPackingMaterialMarketDimensionsInfo item)
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            string mess = string.Empty;
            entity.PackingMaterialMarketDimensionList.ForEach(o =>
            {
                if (o.FK_ICProdAttPackingMaterialWeightPerVolumeID == item.FK_ICProdAttPackingMaterialWeightPerVolumeID)
                    o.IsError = false;

            });
            entity.PackingMaterialMarketDimensionList.GridControl.RefreshDataSource();
        }
        public bool CheckPackingMaterialMarketDimension()
        {
            bool result = true;
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            string mess = string.Empty;
            entity.PackingMaterialMarketDimensionList.ForEach(o =>
                {
                    var checkList = entity.PackingMaterialMarketDimensionList.Where(c => c.FK_ICProdAttPackingMaterialWeightPerVolumeID == o.FK_ICProdAttPackingMaterialWeightPerVolumeID
                            && c.MMPackingMaterialMarketDimensionProductHeight == o.MMPackingMaterialMarketDimensionProductHeight
                            && c.MMPackingMaterialMarketDimensionProductWidth == o.MMPackingMaterialMarketDimensionProductWidth
                            && c.MMPackingMaterialMarketDimensionProductLength == o.MMPackingMaterialMarketDimensionProductLength).ToList();
                    if (checkList != null && checkList.Count > 1)
                    {
                        o.IsError = true;
                        result = false;
                    }

                });
            if (!result)
                MessageBox.Show("Chi tiết cấu hình quy cách định lượng theo thị trường trùng nhau",
                    CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);


            return result;

        }
        public bool SaveConfigAccountOperationList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ConfigAccountOperationList.SaveItemObjects();
            return true;
        }
        public bool SaveConfigDirectoryPathList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.DirectoryPathList.SaveItemObjects();
            return true;
        }

        //TNDLoc [ADD][09/12/2015][Issue MMOverallInsideDimensionConfigs],START
        public void InvalidateOveralInsideDimensionConfigs()
        {
            MMOverallInsideDimensionConfigsController objOverallInsideDimensionConfigsController = new MMOverallInsideDimensionConfigsController();
            List<MMOverallInsideDimensionConfigsInfo> overallInsideDimensionConfigsList = objOverallInsideDimensionConfigsController.GetAllAliveConfigs();
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.MMOverallInsideDimensionConfigsList.Invalidate(overallInsideDimensionConfigsList);
            entity.MMOverallInsideDimensionConfigsList.GridControl.RefreshDataSource();

        }
        public bool SaveOveralInsideDimensionConfigs()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.MMOverallInsideDimensionConfigsList.SaveItemObjects();
            return true;
        }
        public void RemoveOveralInsideDimensionConfig()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.MMOverallInsideDimensionConfigsList.RemoveSelectedRowObjectFromList();
        }
        //TNDLoc [ADD][09/12/2015][Issue MMOverallInsideDimensionConfigs],END

        public bool SaveMMExchangeMeasureUnitConfigs()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.MMExchangeMeasureUnitConfigsList.SaveItemObjects();
            return true;
        }
        public void InvalidateMMExchangeMeasureUnitConfigs()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMExchangeMeasureUnitConfigsController objExchangeMeasureUnitConfigsController = new MMExchangeMeasureUnitConfigsController();
            //DataSet ds = objExchangeMeasureUnitConfigsController.GetAllAliveConfigs();
            List<MMExchangeMeasureUnitConfigsInfo> list = objExchangeMeasureUnitConfigsController.GetAllAliveConfigs();

            //if (list != null)
            //{
            entity.MMExchangeMeasureUnitConfigsList.Invalidate(list);
            entity.MMExchangeMeasureUnitConfigsList.GridControl.RefreshDataSource();
            // }
        }


        public bool SaveModel()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICModelsGridControl gridControl = (ICModelsGridControl)Controls[ICModelConfigsGridControl];
            ICModelDetailsController objModelDetailsController = new ICModelDetailsController();
            ICModelsController objModelsController = new ICModelsController();
            ICModelsInfo obj = gridControl.GetCurrentModel();
            if (obj != null)
            {
                if (obj.ICModelID == 0)
                {
                    objModelsController.CreateObject(obj);
                }
                foreach (ICModelDetailsInfo subItem in entity.ModelDetailsList)
                {
                    subItem.FK_ICModelID = obj.ICModelID;
                    if (subItem.ICModelDetailID > 0)
                    {
                        objModelDetailsController.UpdateObject(subItem);
                    }
                    else
                    {
                        objModelDetailsController.CreateObject(subItem);
                    }
                }
            }
            entity.ModelDetailsList.SaveItemObjects();
            entity.ModelList.SaveItemObjects();
            return true;
        }

        public bool SaveQuantityAllocationPercentConfig()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            foreach (MMQuantityAllocationPercentConfigsInfo item in entity.QuantityAllocationPercentConfigsList)
            {
                item.MMQuantityAllocationPercentConfigDateType = "Month";
            }
            entity.QuantityAllocationPercentConfigsList.SaveItemObjects();
            return true;
        }
        public bool SaveLabourProductivityTargetConfig()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            foreach (MMLabourProductivityTargetConfigsInfo item in entity.LabourProductivityTargetConfigsList)
            {
                item.MMLabourProductivityTargetConfigDateType = "Month";
                item.MMLabourProductivityTargetConfigDinhHinh = item.MMLabourProductivityTargetConfigSoChe;
                item.MMLabourProductivityTargetConfigLapRap = item.MMLabourProductivityTargetConfigSoChe;
                item.MMLabourProductivityTargetConfigSon = item.MMLabourProductivityTargetConfigSoChe;
                item.MMLabourProductivityTargetConfigDongGoi = item.MMLabourProductivityTargetConfigSoChe;
            }
            entity.LabourProductivityTargetConfigsList.SaveItemObjects();
            return true;
        }
        public void SaveAllocationOperationConfig()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            if (entity.AllocationOperationConfigList.Count() > 1)
            {
                MessageBox.Show("Chỉ hổ trợ một loại cấp phát !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            entity.AllocationOperationConfigList.SaveItemObjects();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void SaveDefaultAllocationOperationConfig()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity; 
            entity.DefaultAllocationOperationConfigList.SaveItemObjects();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void SaveConfigMaterialShipmentUtility()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            if (entity.ConfigMaterialShipmentUtilityList.Count() > 1)
            {
                MessageBox.Show("Chỉ hổ trợ một loại cấu hình tiện ích xuất kho NL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            entity.ConfigMaterialShipmentUtilityList.SaveItemObjects();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void SaveProductionCompletionTimeConfig()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ConfigProductionCompletionTimeList.SaveItemObjects();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void SaveCalMaterialConfigs()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.CalMaterialConfigList.SaveItemObjects();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void RemoveCalMaterialConfigList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.CalMaterialConfigList.RemoveSelectedRowObjectFromList();
        }

        public void SaveExecuteTimes()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            bool checkproduct = false;
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            List<ICMeasureUnitsInfo> measureUnitList = objMeasureUnitsController.GetM3AndSLInMeasureUnit();
            ICMeasureUnitsInfo MeasureUnitsInfo = measureUnitList.FirstOrDefault(a => a.ICMeasureUnitName == "Cái");
            if (MeasureUnitsInfo != null)
            {
                entity.ConfigExecuteTimeList.ForEach(a =>
                    {
                        if (a.FK_ICMeasureUnitID == MeasureUnitsInfo.ICMeasureUnitID)
                        {
                            if (a.FK_ICProductID == 0)
                            {
                                checkproduct = true;
                            }
                        }
                    });
            }
            if (checkproduct)
            {
                MessageBox.Show("Vui lòng xác định sản phẩm cho những item có đơn vị tính là cái!\rLưu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                entity.ConfigExecuteTimeList.SaveItemObjects();
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SaveDepartmentAndOperationList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;

            entity.DepartmentAndOperationList.SaveItemObjects();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void SaveDepartmentCapacityConfigList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;

            entity.DepartmentCapacityConfigList.SaveItemObjects();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void SaveProductGroupTypeSwitchingConfigList()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;

            entity.ProductGroupTypeSwitchingConfigList.SaveItemObjects();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void InvalidateModelConfigs()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICModelsController objModelsController = new ICModelsController();

            List<ICModelsInfo> list = objModelsController.GetallObjects();

            entity.ModelList.Invalidate(list);
            entity.ModelList.GridControl.RefreshDataSource();
            if (list.Count > 0)
            {
                InvalidateModelDetailConfigs(list[0]);
            }

        }

        public void InvalidateModelDetailConfigs(ICModelsInfo objModelsInfo)
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICModelDetailsController objModelDetailsController = new ICModelDetailsController();
            entity.ModelDetailsList.Invalidate(objModelDetailsController.GetModelDetailByModelID(objModelsInfo.ICModelID));
            entity.ModelDetailsList.GridControl.RefreshDataSource();

        }

        //TNDLoc [ADD][26/10/2015][Issue ProductionNormItemConfigs],START
        public void InvalidateProductionNormItemConfigs()
        {
            MMProductionNormItemConfigsController objProductionNormItemConfigsController = new MMProductionNormItemConfigsController();
            List<MMProductionNormItemConfigsInfo> productionNormItemConfigsList = objProductionNormItemConfigsController.GetProductionNormItemConfigList();

            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ConfigValueGroup.WoodType.ToString());

            for (int i = 0; i < productionNormItemConfigsList.Count; i++)
            {
                bool isExist = false;
                if (productionNormItemConfigsList[i].MMProductionNormItemConfigBlocks
                    && productionNormItemConfigsList[i].MMProductionNormItemConfigMDFBlocks
                    && productionNormItemConfigsList[i].MMProductionNormItemConfigPlyWood
                    && productionNormItemConfigsList[i].MMProductionNormItemConfigVeneer)
                {
                    productionNormItemConfigsList[i].Selected = true;
                }
                foreach (ICProductAttributesInfo attribute in productAttributesList)
                {
                    if (attribute.ICProductAttributeID == productionNormItemConfigsList[i].FK_ICProductAttributeID)
                    {
                        isExist = true;
                        break;
                    }
                }
                if (!isExist)
                {
                    productionNormItemConfigsList[i].AAStatus = Status.Delete.ToString();
                    objProductionNormItemConfigsController.UpdateObject(productionNormItemConfigsList[i]);
                    productionNormItemConfigsList.RemoveAt(i--);
                }
            }

            foreach (ICProductAttributesInfo attribute in productAttributesList)
            {
                bool isExist = false;
                foreach (MMProductionNormItemConfigsInfo item in productionNormItemConfigsList)
                {
                    if (item.FK_ICProductAttributeID == attribute.ICProductAttributeID)
                    {
                        isExist = true;
                        break;
                    }
                }

                if (!isExist)
                {
                    MMProductionNormItemConfigsInfo objProductionNormItemConfigsInfo = new MMProductionNormItemConfigsInfo();
                    objProductionNormItemConfigsInfo.MMProductionNormItemConfigBlocks = false;
                    objProductionNormItemConfigsInfo.MMProductionNormItemConfigMDFBlocks = false;
                    objProductionNormItemConfigsInfo.MMProductionNormItemConfigPlyWood = false;
                    objProductionNormItemConfigsInfo.MMProductionNormItemConfigVeneer = false;
                    objProductionNormItemConfigsInfo.Selected = false;
                    objProductionNormItemConfigsInfo.FK_ICProductAttributeID = attribute.ICProductAttributeID;
                    productionNormItemConfigsList.Add(objProductionNormItemConfigsInfo);
                }
            }
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ProductionNormItemConfigsList.Invalidate(productionNormItemConfigsList);
            entity.ProductionNormItemConfigsList.GridControl.RefreshDataSource();
        }
        public void InvalidateMMFormulaConfigurations()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMFormulaConfigurationsController objMMFormulaConfigurationsController = new MMFormulaConfigurationsController();
            List<MMFormulaConfigurationsInfo> ds = objMMFormulaConfigurationsController.GetFormulaConfigByFormulaType("Paint");
            if (ds != null)
            {
                entity.MMFormulaConfigurationsList.Invalidate(ds);
                entity.MMFormulaConfigurationsList.GridControl.RefreshDataSource();
            }

        }
        public void InvalidateMMFormulaAddMaterialConfigs()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            MMFormulaConfigurationsController objMMFormulaConfigurationsController = new MMFormulaConfigurationsController();
            List<MMFormulaConfigurationsInfo> ds = objMMFormulaConfigurationsController.GetFormulaConfigByFormulaType("AddMaterial");
            if (ds != null)
            {
                entity.MMFormulaAddmaterialConfigList.Invalidate(ds);
                entity.MMFormulaAddmaterialConfigList.GridControl.RefreshDataSource();
            }
        }

        public bool SaveProductionNormItemConfigs()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ProductionNormItemConfigsList.SaveItemObjects();
            return true;
        }
        public bool SaveMMFormulaConfigurations()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.MMFormulaConfigurationsList.SaveItemObjects();
            return true;
        }
        public bool SaveMMFormulaAddMaterialConfigurations()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.MMFormulaAddmaterialConfigList.SaveItemObjects();
            return true;
        }

        public void SelectedAllChange(int index, bool isSelected)
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            if (index >= 0)
            {
                if (!isSelected)
                {
                    entity.ProductionNormItemConfigsList[index].MMProductionNormItemConfigBlocks = false;
                    entity.ProductionNormItemConfigsList[index].MMProductionNormItemConfigMDFBlocks = false;
                    entity.ProductionNormItemConfigsList[index].MMProductionNormItemConfigPlyWood = false;
                    entity.ProductionNormItemConfigsList[index].MMProductionNormItemConfigVeneer = false;
                }
                else
                {
                    entity.ProductionNormItemConfigsList[index].MMProductionNormItemConfigBlocks = true;
                    entity.ProductionNormItemConfigsList[index].MMProductionNormItemConfigMDFBlocks = true;
                    entity.ProductionNormItemConfigsList[index].MMProductionNormItemConfigPlyWood = true;
                    entity.ProductionNormItemConfigsList[index].MMProductionNormItemConfigVeneer = true;
                }
                entity.ProductionNormItemConfigsList.GridControl.RefreshDataSource();
            }
        }
        //public void RefreshProductionNormItemConfigsList()
        //{
        //    ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
        //    entity.ProductionNormItemConfigsList.EndCurrentEdit();
        //    for (int i = 0; i < entity.ProductionNormItemConfigsList.Count; i++)
        //    {

        //        if (entity.ProductionNormItemConfigsList[i].MMProductionNormItemConfigBlocks
        //            && entity.ProductionNormItemConfigsList[i].MMProductionNormItemConfigMDFBlocks
        //            && entity.ProductionNormItemConfigsList[i].MMProductionNormItemConfigPlyWood
        //            && entity.ProductionNormItemConfigsList[i].MMProductionNormItemConfigVeneer)
        //        {
        //            entity.ProductionNormItemConfigsList[i].Selected = true;
        //        }
        //        else
        //        {
        //            entity.ProductionNormItemConfigsList[i].Selected = false;
        //        }
        //    }
        //    entity.ProductionNormItemConfigsList.GridControl.RefreshDataSource();
        //}
        //TNDLoc [ADD][26/10/2015][Issue ProductionNormItemConfigs],END
        public void ChangeItemFromConsumableConfigList(MMConsumableConfigsInfo item)
        {
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            ICProductAttributesInfo ProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(item.FK_ICProductAttributeID);
            if (ProductAttributesInfo != null)
            {
                if (ProductAttributesInfo.ICProductAttributeValue != null)
                {
                    item.MMConsumableConfigAttributeValue = ProductAttributesInfo.ICProductAttributeValue;
                    item.MMConsumableConfigNo = ProductAttributesInfo.ICProductAttributeNo;
                }
            }
        }
        public bool IsMatchConsumableConfigNo(int productAttributeID)
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            for (int i = 0; i < entity.ConsumableConfigList.Count; i++)
            {
                if (i != entity.ConsumableConfigList.CurrentIndex)
                {
                    MMConsumableConfigsInfo item = entity.ConsumableConfigList[i];
                    if (productAttributeID == item.FK_ICProductAttributeID)
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SameNoError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //item.MMConsumableConfigNo = string.Empty;
                        entity.ConsumableConfigList.GridControl.RefreshDataSource();
                        return true;
                    }
                }
            }
            return false;
        }
        public void ShowItemOperation()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            if (entity.AttributesList.CurrentIndex >= 0)
            {
                ICProductAttributesInfo objProductAttributesInfo = entity.AttributesList[entity.AttributesList.CurrentIndex];
                if (objProductAttributesInfo != null && objProductAttributesInfo.ICProductAttributeID > 0)
                {
                    guiProductAttributeItems guiForm = new guiProductAttributeItems(objProductAttributesInfo.ICProductAttributeID);
                    guiForm.Text = "Danh sách công đoạn: " + objProductAttributesInfo.ICProductAttributeValue;
                    guiForm.Module = this;
                    guiForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show(ProductConstantLocalizedResources.PleaseSaveTheNewAddFeatureBeforeAddingAStep, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ShowProcessInfo(ICProductAttributeItemsInfo objProductAttributeItemsInfo)
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            if (objProductAttributeItemsInfo.ICProductAttributeItemID > 0)
            {
                guiProcessInfos guiForm = new guiProcessInfos(objProductAttributeItemsInfo);
                guiForm.Text = "Danh sách chi tiết máy";
                guiForm.Module = this;
                guiForm.ShowDialog();

            }
            else
            {
                MessageBox.Show(ProductConstantLocalizedResources.PleaseSaveTheNewAddFeatureBeforeAddingAStep, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ChangeMaterialProduct(ICMaterialConfigsInfo objMaterialConfigsInfo, int productID)
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.Where(p => p.ICProductID == productID).FirstOrDefault();
            if (objProductsInfo != null)
            {
                objMaterialConfigsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                objMaterialConfigsInfo.ICMaterialConfigName = objProductsInfo.ICProductName;
                objMaterialConfigsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                entity.ICMaterialConfigsList.GridControl.RefreshDataSource();
            }
        }

        public void InvalidateOtherConfig()
        {
            string value = ADConfigValueUtility.GetFirstConfigValueByGroup("ChangeBOMRate");
            TextEdit textEdit = (TextEdit)Controls["fld_textBOMChangeRate"];
            if (textEdit != null)
                textEdit.EditValue = value;
        }

        public void SaveBomChangeRate()
        {
            try
            {
                TextEdit textEdit = (TextEdit)Controls["fld_textBOMChangeRate"];
                decimal bomRate = 0m;
                decimal.TryParse(textEdit?.EditValue?.ToString(), out bomRate);
                string groupName = "ChangeBOMRate";
                if (ADConfigValueUtility.ConfigValues.Tables[groupName] != null && ADConfigValueUtility.ConfigValues.Tables[groupName].Rows.Count > 0)
                {
                    ADConfigValueUtility.ConfigValues.Tables[groupName].Rows[0]["Value"] = bomRate;
                }
                ADConfigValuesController controller = new ADConfigValuesController();
                DataSet ds = controller.GetADConfigValuesByGroup(groupName);
                List<ADConfigValuesInfo> configs = (List<ADConfigValuesInfo>)ds.ConvertToList<ADConfigValuesInfo>();
                if (configs.Any())
                {
                    configs.ForEach(o =>
                    {
                        o.ADConfigKey = o.ADConfigKeyGroup + bomRate.ToString();
                        o.ADConfigKeyValue = bomRate.ToString();
                        controller.UpdateObject(o);
                    });
                }
                else
                {
                    ADConfigValuesInfo config = new ADConfigValuesInfo()
                    {
                        ADConfigKeyGroup = groupName,
                        ADConfigKey = groupName + bomRate.ToString(),
                        ADConfigKeyValue = bomRate.ToString(),
                        ADConfigText = bomRate.ToString()
                    };
                    controller.CreateObject(config);
                    DataTable tbl = new DataTable();
                    tbl.Columns.Add(new DataColumn("Key"));
                    tbl.Columns.Add(new DataColumn("Value"));
                    tbl.Columns.Add(new DataColumn("Text"));
                    var row = tbl.Rows.Add();
                    row["Key"] = config.ADConfigKey;
                    row["Value"] = config.ADConfigKeyValue;
                    row["Text"] = config.ADConfigText;
                    tbl.TableName = groupName;
                    tbl.PrimaryKey = new DataColumn[] { tbl.Columns[0] };
                    ADConfigValueUtility.ConfigValues.Tables.Add(tbl);
                }
                MessageBox.Show(CommonLocalizedResources.SaveSuccessful,
                     CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CheckConfigValues(string newValue, BaseContainerValidateEditorEventArgs e, string typeConfig)
        {
            switch (typeConfig)
            {
                case "CustomerDistributionChannel":
                    CheckConfigValues(ConfigProductionComplexityType, (ConfigProductionComplexityTypeGridControl)Controls[cstConfigProductionComplexityTypeGridControl], newValue, e);
                    break;
            }
        }

        public void CheckConfigValues(String group, BOSGridControl gridControl, string newValue, BaseContainerValidateEditorEventArgs e)
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            switch (group.ToString())
            {
                case "ConfigProductionComplexityType":
                    {

                        if (entity.ConfigProductionComplexityTypeList.Exists("ADConfigText", newValue))
                        {
                            e.ErrorText = "Độ phức tạp sản xuất đã tồn tại!";
                            e.Valid = false;
                        }
                    }
                    break;
            }
        }

        public void RemoveSelectedConfigProductionComplexityType()
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            entity.ConfigProductionComplexityTypeList.RemoveSelectedRowObjectFromList();
        }

        public void SaveConfigProductionComplexity()
        {
            SaveConfigValues(ADConfigValueUtility.ADConfigValueConfigProductionComplexityType, (ConfigProductionComplexityTypeGridControl)Controls[cstConfigProductionComplexityTypeGridControl]);
        }

        public bool SaveConfigValues(String strGroup, BOSGridControl gridControl)
        {
            ProductConstantEntities entity = (ProductConstantEntities)CurrentModuleEntity;
            BOSList<ADConfigValuesInfo> configValues = null;
            if (strGroup == ConfigProductionComplexityType.ToString())
            {
                configValues = entity.ConfigProductionComplexityTypeList;
            }
            if (configValues != null)
            {
                foreach (ADConfigValuesInfo objConfigValuesInfo in configValues)
                {
                    if (objConfigValuesInfo.ADConfigValueID == 0)
                    {
                        objConfigValuesInfo.ADConfigKeyGroup = strGroup;
                        objConfigValuesInfo.ADConfigKeyValue = BOSUtil.ConvertUnicodeStringToUnSign(objConfigValuesInfo.ADConfigText)
                                                                            .Replace(" ", string.Empty);
                        objConfigValuesInfo.ADConfigKey = string.Format("{0}{1}", strGroup, objConfigValuesInfo.ADConfigKeyValue);
                    }
                }
                configValues.SaveItemObjects();
            }

            //Update the global table of config values 
            if (ADConfigValueUtility.ConfigValues.Tables.Contains(strGroup))
                ADConfigValueUtility.ConfigValues.Tables.Remove(strGroup);
            ADConfigValueUtility.ConfigValues.Tables.Add(ADConfigValueUtility.InitConfigValueTable(strGroup));

            if (ADConfigValueUtility.ConfigValues.Tables.Contains(strGroup + "Search"))
                ADConfigValueUtility.ConfigValues.Tables.Remove(strGroup + "Search");

            DataTable tblSearch = ADConfigValueUtility.InitConfigValueTable(strGroup);
            tblSearch.TableName = strGroup + "Search";
            tblSearch.Rows.Add(new object[3] { "", "", "" });
            ADConfigValueUtility.ConfigValues.Tables.Add(tblSearch);

            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
    }
}
