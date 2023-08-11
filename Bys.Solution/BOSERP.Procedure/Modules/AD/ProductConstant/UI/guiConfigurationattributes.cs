using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConstant.UI
{
    public partial class guiConfigurationattributes : BOSERPScreen
    {
        private String CurrentSection;

        public guiConfigurationattributes()
        {
            InitializeComponent();
        }

        private void fld_trlSections_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            CurrentSection = e.Node.Tag.ToString();
            switch (e.Node.Tag.ToString())
            {
                case "Productattributes":
                    DMPC100 guiProductattributes = new DMPC100();
                    guiProductattributes.ScreenNumber = "DMPC100";
                    guiProductattributes.Module = Module;
                    LoadScreen(guiProductattributes);
                    ((ProductConstantModule)this.Module).InvalidateOptionValueConfigList();
                    ((ProductConstantModule)this.Module).InvalidateColorList();
                    ((ProductConstantModule)this.Module).InvalidateHTTypeList();
                    ((ProductConstantModule)this.Module).InvalidateTTMTList();
                    ((ProductConstantModule)this.Module).InvalidateQualityList();
                    ((ProductConstantModule)this.Module).InvalidateThickList();
                    ((ProductConstantModule)this.Module).InvalidateAttributesList();
                    ((ProductConstantModule)this.Module).InvalidateSemiGroupTypeConfigList();
                    ((ProductConstantModule)this.Module).InvalidateProductGroupHeightsList();
                    ((ProductConstantModule)this.Module).InvalidateAddMaterialConfigList();
                    ((ProductConstantModule)this.Module).InvalidatePerimeterAndLengthGroupList();
                    ((ProductConstantModule)this.Module).InvalidateConfigThinkAccordWoodTypeList();
                    ((ProductConstantModule)this.Module).InvalidateConfigQualityAccordWoodTypeList();
                    fld_btnSave2.Visible = true;
                    break;
                case "ReuseSpecificateConfigs":
                    DMPC101 guiCustomer = new DMPC101();
                    guiCustomer.ScreenNumber = "DMPC101";
                    guiCustomer.Module = Module;
                    LoadScreen(guiCustomer);
                    ((ProductConstantModule)this.Module).InvalidateReuseSpecificateConfigList();
                    fld_btnSave2.Visible = true;
                    break;
                case "ConsumableConfigs":
                    DMPC102 guiProduct = new DMPC102();
                    guiProduct.ScreenNumber = "DMPC102";
                    guiProduct.Module = Module;
                    LoadScreen(guiProduct);
                    ((ProductConstantModule)this.Module).InvalidateConsumableConfigList();
                    fld_btnSave2.Visible = true;
                    break;
                case "ExchangeRateConfigs":
                    DMPC103 guiSale = new DMPC103();
                    guiSale.ScreenNumber = "DMPC103";
                    guiSale.Module = Module;
                    LoadScreen(guiSale);
                    ((ProductConstantModule)this.Module).InvalidateExchangeRateConfigList();
                    fld_btnSave2.Visible = true;
                    break;
                //TNDLoc [ADD][26/10/2015][Issue ProductionNormItemConfigs],START
                case "ProductionNormItemConfigs":
                    DMPC104 guiProductionNormItemConfigs = new DMPC104();
                    guiProductionNormItemConfigs.ScreenNumber = "DMPC104";
                    guiProductionNormItemConfigs.Module = Module;
                    LoadScreen(guiProductionNormItemConfigs);
                    ((ProductConstantModule)this.Module).InvalidateProductionNormItemConfigs();
                    fld_btnSave2.Visible = true;
                    break;
                //TNDLoc [ADD][26/10/2015][Issue ProductionNormItemConfigs],END
                case "MMFormulaConfigurations":
                    DMPC105 guiMMFormulaConfigurations = new DMPC105();
                    guiMMFormulaConfigurations.ScreenNumber = "DMPC105";
                    guiMMFormulaConfigurations.Module = Module;
                    LoadScreen(guiMMFormulaConfigurations);
                    ((ProductConstantModule)this.Module).InvalidateMMFormulaConfigurations();
                    ((ProductConstantModule)this.Module).InvalidateMMFormulaAddMaterialConfigs();
                    fld_btnSave2.Visible = true;
                    break;
                case "ICProductattributes":
                    DMPC106 guiICProduct = new DMPC106();
                    guiICProduct.ScreenNumber = "DMPC106";
                    guiICProduct.Module = Module;
                    LoadScreen(guiICProduct);
                    ((ProductConstantModule)this.Module).InvalidatePackingMaterialSpeciality();
                    ((ProductConstantModule)this.Module).InvalidatePackingMaterialSize();
                    ((ProductConstantModule)this.Module).InvalidatePackingMaterialWeightPerVolume();
                    fld_btnSave2.Visible = true;
                    break;
                case "MMOverallInsideDimensionConfigs":
                    DMPC107 guiOverallInsideDimensionConfigs = new DMPC107();
                    guiOverallInsideDimensionConfigs.ScreenNumber = "DMPC107";
                    guiOverallInsideDimensionConfigs.Module = Module;
                    LoadScreen(guiOverallInsideDimensionConfigs);
                    ((ProductConstantModule)this.Module).InvalidateOveralInsideDimensionConfigs();
                    fld_btnSave2.Visible = true;
                    break;
                case "MMExchangeMeasureUnitConfigs":
                    DMPC108 guiProductConstant7 = new DMPC108();
                    guiProductConstant7.ScreenNumber = "DMPC108";
                    guiProductConstant7.Module = Module;
                    LoadScreen(guiProductConstant7);
                    ((ProductConstantModule)this.Module).InvalidateMMExchangeMeasureUnitConfigs();
                    fld_btnSave2.Visible = true;
                    break;
                case "ICModel":
                    DMPC109 guiProductConstant9 = new DMPC109();
                    guiProductConstant9.ScreenNumber = "DMPC109";
                    guiProductConstant9.Module = Module;
                    LoadScreen(guiProductConstant9);
                    ((ProductConstantModule)this.Module).InvalidateModelConfigs();
                    fld_btnSave2.Visible = true;
                    break;
                case "MMQuantityAllocationPercentConfig":
                    DMPC110 guiProductionConstantQuantityAllocationPercent = new DMPC110();
                    guiProductionConstantQuantityAllocationPercent.ScreenNumber = "DMPC110";
                    guiProductionConstantQuantityAllocationPercent.Module = Module;
                    LoadScreen(guiProductionConstantQuantityAllocationPercent);
                    ((ProductConstantModule)this.Module).InvalidateQuantityAllocationPercentConfig();
                    fld_btnSave2.Visible = true;
                    break;
                case "MMLabourProductivityTargetConfig":
                    DMPC111 guiProductionConstantLabourProductivityTarget = new DMPC111();
                    guiProductionConstantLabourProductivityTarget.ScreenNumber = "DMPC111";
                    guiProductionConstantLabourProductivityTarget.Module = Module;
                    LoadScreen(guiProductionConstantLabourProductivityTarget);
                    ((ProductConstantModule)this.Module).InvalidateLabourProductivityTargetConfig();
                    fld_btnSave2.Visible = true;
                    break;
                case "MMCalMaterialConfigs":
                    DMPC112 guiDMPC112 = new DMPC112();
                    guiDMPC112.ScreenNumber = "DMPC112";
                    guiDMPC112.Module = Module;
                    LoadScreen(guiDMPC112);
                    ((ProductConstantModule)this.Module).InvalidateCalMaterialConfigs();
                    fld_btnSave2.Visible = false;
                    break;
                case "OperationProduct":
                    DMPC114 guiOperationProduct = new DMPC114();
                    guiOperationProduct.ScreenNumber = "DMPC114";
                    guiOperationProduct.Module = Module;
                    LoadScreen(guiOperationProduct);
                    ((ProductConstantModule)this.Module).InvalidateOperationProductList();
                    fld_btnSave2.Visible = true;
                    break;
                case "ConfigAccountOperation":
                    DMPC115 guiConfigAccountOperation = new DMPC115();
                    guiConfigAccountOperation.ScreenNumber = "DMPC115";
                    guiConfigAccountOperation.Module = Module;
                    LoadScreen(guiConfigAccountOperation);
                    ((ProductConstantModule)this.Module).InvalidateConfigAccountOperationList();
                    fld_btnSave2.Visible = true;
                    break;
                case "ExecuteTimeConfig":
                    DMPC116 guiExecuteTimeConfig = new DMPC116();
                    guiExecuteTimeConfig.ScreenNumber = "DMPC116";
                    guiExecuteTimeConfig.Module = Module;
                    LoadScreen(guiExecuteTimeConfig);
                    ((ProductConstantModule)this.Module).InvalidateConfigProductionCompletionTimeList();
                    ((ProductConstantModule)this.Module).InvalidateConfigExecuteTimeList();
                    ((ProductConstantModule)this.Module).InvalidateDepartmentAndOperationList();
                    ((ProductConstantModule)this.Module).InvalidateDepartmentCapacityConfigList();
                    ((ProductConstantModule)this.Module).InvalidateProductGroupTypeSwitchingConfigList();
                    fld_btnSave2.Visible = false;
                    break;
                case "DirectoryPath":
                    DMPC117 guiDirectoryPath = new DMPC117();
                    guiDirectoryPath.ScreenNumber = "DMPC117";
                    guiDirectoryPath.Module = Module;
                    LoadScreen(guiDirectoryPath);
                    ((ProductConstantModule)this.Module).InvalidateConfigDirectoryPathList();
                    fld_btnSave2.Visible = true;
                    break;
                case "ProductionNormConfig":
                    DMPC118 guiAllocationOperation = new DMPC118();
                    guiAllocationOperation.ScreenNumber = "DMPC118";
                    guiAllocationOperation.Module = Module;
                    LoadScreen(guiAllocationOperation);
                    ((ProductConstantModule)this.Module).InvalidateAllocationOperationConfig();
                    ((ProductConstantModule)this.Module).InvalidateDefaultAllocationOperationConfig();
                    ((ProductConstantModule)this.Module).InvalidateConfigProductionComplexityType();
                    ((ProductConstantModule)this.Module).InvalidateOtherConfig();
                    ((ProductConstantModule)this.Module).InvalidateConfigMaterialShipmentUtility();
                    fld_btnSave2.Visible = false;
                    break;
            }

            ((ProductConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
        }

        private void LoadScreen(BOSERPScreen screen)
        {
            fld_pnlScreenContainer2.Controls.Clear();
            screen.AddCustomControls(Module.Screens);
            screen.CustomizeControls(screen.Controls);
            screen.InitializeControls(screen.Controls);
            for (int i = 0; i < screen.Controls.Count; i++)
            {
                fld_pnlScreenContainer2.Controls.Add(screen.Controls[i]);
                i--;
            }
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.InitGridControlInBOSListForWoodConfigurationTab();
        }

        private void fld_btnSave2_Click_1(object sender, EventArgs e)
        {
            bool isSuccess = true;
            ProductConstantModule module = (ProductConstantModule)Module;
            switch (CurrentSection)
            {
                case "Productattributes":
                    isSuccess = module.SaveProductattributes();
                    if (isSuccess)
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "ReuseSpecificateConfigs":
                    isSuccess = module.SaveReuseSpecificateConfigs();
                    if (isSuccess)
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "ConsumableConfigs":
                    isSuccess = module.SaveConsumableConfigs();
                    if (isSuccess)
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveNegativeMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity;
                    entity.ConsumableConfigList.GridControl.RefreshDataSource();
                    break;

                case "ExchangeRateConfigs":
                    isSuccess = module.SaveExchangeRateConfigs();
                    if (isSuccess)
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "OperationProduct":
                    isSuccess = module.SaveOperationProductConfig();
                    if (isSuccess)
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                //TNDLoc [ADD][26/10/2015][Issue ProductionNormItemConfigs],START
                case "ProductionNormItemConfigs":
                    isSuccess = module.SaveProductionNormItemConfigs();
                    if (isSuccess)
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                //TNDLoc [ADD][26/10/2015][Issue ProductionNormItemConfigs],END
                case "MMFormulaConfigurations":
                    isSuccess = module.SaveMMFormulaConfigurations();
                    isSuccess = module.SaveMMFormulaAddMaterialConfigurations();
                    if (isSuccess)
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "ICProductattributes":
                    isSuccess = module.SaveICProductattributes();
                    if (isSuccess)
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "MMOverallInsideDimensionConfigs":
                    isSuccess = module.SaveOveralInsideDimensionConfigs();
                    if (isSuccess)
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "MMExchangeMeasureUnitConfigs":
                    isSuccess = module.SaveMMExchangeMeasureUnitConfigs();
                    if (isSuccess)
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "ICModel":
                    isSuccess = module.SaveModel();
                    if (isSuccess)
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "MMQuantityAllocationPercentConfig":
                    isSuccess = module.SaveQuantityAllocationPercentConfig();
                    if (isSuccess)
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "MMLabourProductivityTargetConfig":
                    isSuccess = module.SaveLabourProductivityTargetConfig();
                    if (isSuccess)
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "ConfigAccountOperation":
                    isSuccess = module.SaveConfigAccountOperationList();
                    if (isSuccess)
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(ProductConstantLocalizedResources.SaveErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }

        }
    }
}
