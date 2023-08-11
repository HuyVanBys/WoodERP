using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BOSERP.Modules.CompanyConstant
{
    public class CompanyConstantEntities : ERPModuleEntities
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
        public BOSList<GENumberingInfo> GENumberingsList { get; set; }
        public BOSList<ARPriceLevelsInfo> ARPriceLevelsList { get; set; }
        public BOSList<GEVATsInfo> GEVATsList { get; set; }
        public BOSList<ICMeasureUnitsInfo> ICMeasureUnitsList { get; set; }
        public BOSList<HRTimeSheetParamsInfo> HRTimeSheetParamList { get; set; }
        public BOSList<HRTimeSheetParamsInfo> HRTimeSheetParam2List { get; set; }
        public BOSList<HRWorkingShiftsInfo> HRWorkingShiftList { get; set; }
        public BOSList<HROTFactorsInfo> HROTFactorList { get; set; }
        public BOSList<HREmployeePieceWorksInfo> HREmployeePieceWorksList { get; set; }
        /// <summary>
        /// Gets or sets the company bank list
        /// </summary>
        public BOSList<CSCompanyBanksInfo> CSCompanyBankList { get; set; }
        /// <summary>
        /// Gets or sets the cash fund list
        /// </summary>
        public BOSList<CSCashFundsInfo> CSCashFundList { get; set; }
        /// <summary>
        /// Gets or sets the import/export reason list
        /// </summary>
        public BOSList<ICImportAndExportReasonsInfo> ICImportAndExportReasonList { get; set; }
        /// <summary>
        /// Gets or sets customer type config values
        /// </summary>
        public BOSList<ADConfigValuesInfo> CustomerTypeList { get; set; }

        public BOSList<ARCustomerBusinessTypesInfo> CustomerBusinessTypeList { get; set; }
        /// Gets or sets customer distribution channel type config values
        /// </summary>
        public BOSList<ADConfigValuesInfo> CustomerDistributionChannelTypeList { get; set; }
        /// <summary>
        /// Gets or sets product type config values
        /// </summary>
        public BOSList<ADConfigValuesInfo> ProductTypeList { get; set; }

        /// <summary>
        /// Gets or sets the list of available payment methods
        /// </summary>
        public BOSList<ADConfigValuesInfo> PaymentMethodList { get; set; }

        /// <summary>
        /// Gets or sets the list of reports
        /// </summary>
        public BOSList<ADReportsInfo> ReportList { get; set; }

        /// <summary>
        /// Gets or sets the list of receipt voucher types
        /// </summary>
        public BOSList<ADConfigValuesInfo> ReceiptVoucherTypeList { get; set; }

        /// <summary>
        /// Gets or sets the list of payment voucher types
        /// </summary>
        public BOSList<ADConfigValuesInfo> PaymentVoucherTypeList { get; set; }
        public BOSList<ADConfigValuesInfo> EmployeeSalaryTypeList { get; set; }
        public BOSList<ADConfigValuesInfo> HRTimeSheetParam3List { get; set; }
        public BOSList<ADConfigValuesInfo> TrainingCourseList { get; set; }
        public BOSList<HREmployeeSalaryConfigsInfo> EmployeeSalaryConfigList { get; set; }
        public BOSList<ADAppUserPermissionsInfo> AppUserPermissionList { get; set; }
        public BOSList<ADConfigValuesInfo> ContainerTypeList { get; set; }
        public BOSList<ADConfigValuesInfo> ProductOriginList { get; set; }
        public BOSList<ADConfigValuesInfo> ProductTrademarkList { get; set; }
        public BOSList<ADConfigValuesInfo> ProductCollectionList { get; set; }
        public BOSList<ADConfigValuesInfo> ProductStorageConditionList { get; set; }
        public BOSList<ICProductFormulaPriceConfigsInfo> ICProductFormulaPriceConfigsList { get; set; }
        public BOSList<ARCustomerTypeAccountConfigsInfo> ARCustomerTypeAccountConfigsList { get; set; }
        public BOSList<APSupplierTypeAccountConfigsInfo> APSupplierTypeAccountConfigsList { get; set; }
        public BOSList<ICProductTypeAccountConfigsInfo> ICProductTypeAccountConfigsList { get; set; }
        public BOSList<GENumberingInfo> GENumberingList { get; set; }
        public BOSList<ARCustomerResourcesInfo> CustomerResourcesList { get; set; }
        public BOSList<ARCustomerSaleOrderTypeConfigsInfo> CustomerSaleOrderTypeConfigsList { get; set; }
        public BOSList<ADFengShuisColorsInfo> FengShuisColorsList { get; set; }
        public BOSList<ADFengShuisGenaralsInfo> FengShuisGenaralsList { get; set; }
        public BOSList<ADFengShuisDirectionsInfo> FengShuisDirectionsList { get; set; }
        public BOSList<ADTargetReportBudgetsInfo> TargetReportBudgetsList { get; set; }
        public BOSList<PMProjectTypesInfo> ProjectTypesList { get; set; }
        public BOSList<PMPhaseTypesInfo> PhaseTypesList { get; set; }
        public BOSList<ADConfigValuesInfo> LevelGraduationList { get; set; }
        public BOSList<ADConfigValuesInfo> LevelQualificationList { get; set; }
        //public BOSList<ADConfigValuesInfo> LevelFrequencyList { get; set; }
        public BOSList<ADConfigValuesInfo> LevelDutiesResponsibilitiesFrequencyList { get; set; }
        public BOSList<ADConfigValuesInfo> LevelDutiesResponsibilitiesEvaluationCriteriaList { get; set; }
        //public BOSList<ADConfigValuesInfo> LevelEvaluationCriteriaList { get; set; }
        public BOSList<ADConfigValuesInfo> LevelExpList { get; set; }
        public BOSList<ADConfigValuesInfo> LevelComputerProficiencyList { get; set; }
        public BOSList<ADConfigValuesInfo> LevelNecessarySkillsList { get; set; }
        public BOSList<ADConfigValuesInfo> LevelHealthList { get; set; }
        public BOSList<ADConfigValuesInfo> ProductDepartmentGroupList { get; set; }
        public BOSList<ADConfigValuesInfo> SplitRatioGroupList { get; set; }
        public BOSList<ADConfigValuesInfo> BonusLevelCalculatedOnList { get; set; }
        public BOSList<ACLoanReceiptTypesInfo> LoanReceiptTypesList { get; set; }
        public BOSList<HRErrorTypesInfo> ErrorTypeList { get; set; }
        public BOSList<ADConfigValuesInfo> CircumstancesRewardTypeList { get; set; }
        public BOSList<ADConfigValuesInfo> BestSellerTypeList { get; set; }
        public BOSList<HRConfigRewardBestSellersInfo> ConfigRewardBestSellersList { get; set; }
        public BOSList<HRTimeRewardsInfo> TimeRewardsList { get; set; }
        public BOSList<HRSplitRatiosInfo> SplitRatiosList { get; set; }
        public BOSList<HRBonusLevelsInfo> BonusLevelsList { get; set; }
        public BOSList<ADConfigValuesInfo> LevelMajorList { get; set; }
        public BOSList<ADConfigValuesInfo> LevelJobSummaryList { get; set; }
        public BOSList<ADConfigValuesInfo> ConfigureRewardTimeReceiptTimeList { get; set; }
        public BOSList<ADConfigValuesInfo> ConfigureBonusLevelProductionGroupList { get; set; }
        public BOSList<ADConfigValuesInfo> ConfigureAccordingList { get; set; }
        public BOSList<HRAccountingStoresInfo> AccountingStoresList { get; set; }
        public BOSList<HRConfigureRewardLevelsInfo> ConfigureRewardLevelsList { get; set; }
        public BOSList<HRConfigureBonusLevelsInfo> ConfigureBonusLevelsList { get; set; }
        public BOSList<HRConfigureRewardTimesInfo> ConfigureRewardTimesList { get; set; }
        public BOSList<HRBonusChecksInfo> BonusChecksList { get; set; }
        public BOSList<HRDesignBonussInfo> DesignBonussList { get; set; }
        public BOSList<ACAssetTypeDepreciationConfigsInfo> ACAssetTypeDepreciationConfigsList { get; set; }
        public BOSList<ACAssetTypeAccountConfigsInfo> ACAssetTypeAccountConfigsList { get; set; }
        public BOSList<ACEquipmentTypeAccountConfigsInfo> ACEquipmentTypeAccountConfigsList { get; set; }
        public BOSList<ADConfigValuesInfo> PrivilegeAppSatffGroupsList { get; set; }
        public BOSList<ADPrivilegeAppSatffsInfo> PrivilegeAppSatffsList { get; set; }
        public BOSList<ADTemplatesInfo> TemplatesList { get; set; }
        public BOSList<ADTemplateParamsInfo> TemplateParamsList { get; set; }
        public BOSList<ADReportTemplatesInfo> ReportTemplatesList { get; set; }
        public BOSList<ADTemplateToolbarsInfo> TemplateToolbarsList { get; set; }
        public BOSList<ICFeeConfigsInfo> GESaleCostList { get; set; }
        public BOSList<MMProductionCostFactorGroupsInfo> MMProductionCostFactorGroupsList { get; set; }
        public BOSList<MMProductionCostFactorsInfo> MMProductionCostFactorsList { get; set; }
        public BOSList<MMProductionCostFactorAllocationRatesInfo> MMProductionCostFactorAllocationRatesList { get; set; }
        public BOSList<ADConfigValuesInfo> ProductionCostCollectTypeList { get; set; }
        public BOSList<ADConfigValuesInfo> ProductionCostAllocationTypeList { get; set; }
        public BOSList<ADConfigValuesInfo> ProductionCostInProgressCalTypeList { get; set; }
        public BOSList<ICStockConfigRatesInfo> StockConfigRateList { get; set; }
        public BOSList<ICPriceCalculationMethodsInfo> ICPriceCalculationMethodsList { get; set; }
        public BOSList<HRPercentageRetainedsInfo> HRPercentageRetainedsList { get; set; }
        public BOSList<ADCompletePermissionConfigsInfo> CompletePermissionConfigList { get; set; }
        public BOSList<HRCostTypeConfigsInfo> CostTypeConfigList { get; set; }
        public BOSList<HRWorkingFeeConfigsInfo> WorkingFeeConfigList { get; set; }
        public BOSList<HRFormAllowancesInfo> FormAllowancesList { get; set; }
        public BOSList<HRTimesheetEmployeeLateConfigsInfo> TimesheetEmployeeLateConfigs { get; set; }
        public BOSList<ADTimesheetConfigsInfo> ADTimesheetConfigList { get; set; }
        public BOSList<HRPayRollConfigsInfo> HRPayRollConfigList { get; set; }
        public BOSList<HREmployeePayRollConfigsInfo> HREmployeePayRollConfigList { get; set; }
        public BOSList<HREmployeesInfo> EmployeeList { get; set; }
        public BOSList<ADObjectViewPermissionsInfo> ObjectViewPermissionList { get; set; }
        public BOSList<ADDefaultDescConfigsInfo> DefaultDescConfigList { get; set; }
        public BOSTreeList ProductTemplatesTreeList { get; set; }
        public BOSList<HRAllowanceManageConfigsInfo> AllowanceManageConfigsList { get; set; }
        public BOSList<HRAllowanceManageConfigHistorysInfo> AllowanceManageConfigHistorysList { get; set; }
        public BOSList<HRConfigRanksInfo> HRConfigRanksList { get; set; }
        public BOSList<HRConfigScalesInfo> HRConfigScalesList { get; set; }
        public BOSList<HRAnnualLeaveDayConfigsInfo> HRAnnualLeaveDayConfigsList { get; set; }
        public BOSList<HRSeniorityLeaveDayConfigsInfo> HRSeniorityLeaveDayConfigsList { get; set; }
        public BOSList<HRDepartmentRoomLeaveDayConfigsInfo> HRDepartmentRoomLeaveDayConfigsList { get; set; }
        public BOSList<HROtherLeaveDayConfigsInfo> HROtherLeaveDayConfigsList { get; set; }
        public BOSList<HRRelationshipsInfo> HRRelationshipsList { get; set; }
        public BOSList<HRAllowanceManageConfigHistorysInfo> HRAllowanceManageConfigHistorysList { get; set; }
        public BOSList<ACSalaryDocumentTypesInfo> SalaryDocumentTypeList { get; set; }
        public BOSList<ACSalaryEntryTypesInfo> SalaryEntryTypeList { get; set; }
        public BOSList<ARDeliveryMethodsInfo> ARDeliveryMethodsList { get; set; }
        public BOSList<ARSaleContractGroupsInfo> ARSaleContractGroupList { get; set; }
        public BOSList<APPurchaseContractGroupsInfo> APPurchaseContractGroupList { get; set; }
        public BOSList<ADReportViewRefsInfo> ViewRefsList { get; set; }
        public BOSList<ADReportViewRefParamsInfo> ViewRefParamsList { get; set; }
        public BOSList<STFieldFormatsInfo> FieldFormatList { get; set; }
        public BOSList<ACEquipmentStatesInfo> EquipmentStateList { get; set; }
        public BOSList<GEGenerateProductNoConfigsInfo> GenerateProductNoConfigList { get; set; }
        public BOSList<GEPackageNumeringConfigsInfo> GeneratePackageConfigList { get; set; }
        public BOSList<ACEInvoiceTypesInfo> EInvoiceTypesList { get; set; }
        public BOSList<ADInsurrancePlansInfo> InsurrancePlansList { get; set; }
        public BOSList<ADInsurrancePapersInfo> InsurrancePapersList { get; set; }
        public BOSList<ADInsurranceConditionsInfo> InsurranceConditionsList { get; set; }
        public BOSList<GETerminalsInfo> GETerminalsList { get; set; }
        public BOSList<GEUnitCostsInfo> GEUnitCostsList { get; set; }
        public BOSList<GEUnitCostContainersInfo> GEUnitCostContainersList { get; set; }
        public BOSList<ADConfigValuesInfo> CommodityTypeList { get; set; }
        public BOSList<ADConfigValuesInfo> ListOfSalesChannelTypeList { get; set; }
        public BOSList<ADConfigValuesInfo> SourceSellingPriceTypeList { get; set; }
        public BOSList<ICCommodityProductTypeMappingsInfo> CommodityProductTypeMappingList { get; set; }
        public BOSList<ICProductTypeMappingsInfo> ProductTypeMappingList { get; set; }
        public BOSList<ICCommodityGridControlTypeMappingsInfo> CommodityGridControlTypeMappingList { get; set; }
        public BOSList<GECurrencyExchangeRatesInfo> CurrencyExchangeRateList { get; set; }
        public BOSList<GEBanksInfo> BankList { get; set; }
        public BOSList<MMProductionCostLinkConfigsInfo> MMProductionCostLinkConfigsList { get; set; }
        public BOSList<ADConfigValuesInfo> ProductionCostInProgressClassifyTypeList { get; set; }
        public BOSList<HRATMCardManageConfigsInfo> ATMCardManageConfigList { get; set; }
        public BOSList<ICCalculatedPackageVolumnConfigsInfo> ICCalculatedPackageVolumnConfigList { get; set; }
        private ADInsurrancesInfo InsurrancesInfo { get; set; }
        public BOSList<ARSaleOrderSaleTypeConfigsInfo> ARSaleOrderSaleTypeConfigsList { get; set; }
        #endregion

        #region Constructor
        public CompanyConstantEntities()
            : base()
        {
            CSCompanysController objCompanysController = new CSCompanysController();
            int companyID = 0;
            if (BOSApp.CurrentCompanyInfo != null)
                companyID = BOSApp.CurrentCompanyInfo.CSCompanyID;

            Company = (CSCompanysInfo)objCompanysController.GetObjectByID(companyID);
            if (Company == null)
            {
                Company = new CSCompanysInfo();
            }

            ADInsurrancesController objInsurrancesController = new ADInsurrancesController();
            InsurrancesInfo = (ADInsurrancesInfo)objInsurrancesController.GetFirstObject();
            if (InsurrancesInfo == null)
            {
                InsurrancesInfo = new ADInsurrancesInfo();
            }

            GENumberingsList = new BOSList<GENumberingInfo>();
            ARPriceLevelsList = new BOSList<ARPriceLevelsInfo>();
            GEVATsList = new BOSList<GEVATsInfo>();
            ICMeasureUnitsList = new BOSList<ICMeasureUnitsInfo>();
            HRTimeSheetParamList = new BOSList<HRTimeSheetParamsInfo>();
            HRTimeSheetParam2List = new BOSList<HRTimeSheetParamsInfo>();
            HRWorkingShiftList = new BOSList<HRWorkingShiftsInfo>();
            HROTFactorList = new BOSList<HROTFactorsInfo>();
            CSCompanyBankList = new BOSList<CSCompanyBanksInfo>();
            CSCashFundList = new BOSList<CSCashFundsInfo>();
            ICImportAndExportReasonList = new BOSList<ICImportAndExportReasonsInfo>();
            ICCalculatedPackageVolumnConfigList = new BOSList<ICCalculatedPackageVolumnConfigsInfo>();
            CustomerTypeList = new BOSList<ADConfigValuesInfo>();
            CustomerBusinessTypeList = new BOSList<ARCustomerBusinessTypesInfo>();
            CustomerDistributionChannelTypeList = new BOSList<ADConfigValuesInfo>();
            ProductTypeList = new BOSList<ADConfigValuesInfo>();
            PaymentMethodList = new BOSList<ADConfigValuesInfo>();
            ReportList = new BOSList<ADReportsInfo>();
            ReceiptVoucherTypeList = new BOSList<ADConfigValuesInfo>();
            PaymentVoucherTypeList = new BOSList<ADConfigValuesInfo>();
            EmployeeSalaryTypeList = new BOSList<ADConfigValuesInfo>();
            HREmployeePieceWorksList = new BOSList<HREmployeePieceWorksInfo>();
            HRTimeSheetParam3List = new BOSList<ADConfigValuesInfo>();
            TrainingCourseList = new BOSList<ADConfigValuesInfo>();
            ContainerTypeList = new BOSList<ADConfigValuesInfo>();
            ProductOriginList = new BOSList<ADConfigValuesInfo>();
            ProductTrademarkList = new BOSList<ADConfigValuesInfo>();
            ProductCollectionList = new BOSList<ADConfigValuesInfo>();
            ProductStorageConditionList = new BOSList<ADConfigValuesInfo>();

            ICProductFormulaPriceConfigsList = new BOSList<ICProductFormulaPriceConfigsInfo>();
            ARCustomerTypeAccountConfigsList = new BOSList<ARCustomerTypeAccountConfigsInfo>();
            APSupplierTypeAccountConfigsList = new BOSList<APSupplierTypeAccountConfigsInfo>();
            ICProductTypeAccountConfigsList = new BOSList<ICProductTypeAccountConfigsInfo>();

            GENumberingList = new BOSList<GENumberingInfo>();
            CustomerResourcesList = new BOSList<ARCustomerResourcesInfo>();
            CustomerSaleOrderTypeConfigsList = new BOSList<ARCustomerSaleOrderTypeConfigsInfo>();

            FengShuisColorsList = new BOSList<ADFengShuisColorsInfo>();
            FengShuisGenaralsList = new BOSList<ADFengShuisGenaralsInfo>();
            FengShuisDirectionsList = new BOSList<ADFengShuisDirectionsInfo>();

            TargetReportBudgetsList = new BOSList<ADTargetReportBudgetsInfo>();

            ProjectTypesList = new BOSList<PMProjectTypesInfo>();
            PhaseTypesList = new BOSList<PMPhaseTypesInfo>();

            LevelGraduationList = new BOSList<ADConfigValuesInfo>();
            LevelQualificationList = new BOSList<ADConfigValuesInfo>();
            //LevelFrequencyList = new BOSList<ADConfigValuesInfo>();
            LevelDutiesResponsibilitiesFrequencyList = new BOSList<ADConfigValuesInfo>();
            LevelDutiesResponsibilitiesEvaluationCriteriaList = new BOSList<ADConfigValuesInfo>();
            //LevelEvaluationCriteriaList = new BOSList<ADConfigValuesInfo>();
            LevelExpList = new BOSList<ADConfigValuesInfo>();
            LevelComputerProficiencyList = new BOSList<ADConfigValuesInfo>();
            LevelNecessarySkillsList = new BOSList<ADConfigValuesInfo>();
            LevelHealthList = new BOSList<ADConfigValuesInfo>();
            ProductDepartmentGroupList = new BOSList<ADConfigValuesInfo>();
            SplitRatioGroupList = new BOSList<ADConfigValuesInfo>();
            BonusLevelCalculatedOnList = new BOSList<ADConfigValuesInfo>();

            LoanReceiptTypesList = new BOSList<ACLoanReceiptTypesInfo>();
            CircumstancesRewardTypeList = new BOSList<ADConfigValuesInfo>();
            BestSellerTypeList = new BOSList<ADConfigValuesInfo>();
            ConfigRewardBestSellersList = new BOSList<HRConfigRewardBestSellersInfo>();
            AppUserPermissionList = new BOSList<ADAppUserPermissionsInfo>();
            ErrorTypeList = new BOSList<HRErrorTypesInfo>();
            TimeRewardsList = new BOSList<HRTimeRewardsInfo>();
            SplitRatiosList = new BOSList<HRSplitRatiosInfo>();
            BonusLevelsList = new BOSList<HRBonusLevelsInfo>();
            LevelMajorList = new BOSList<ADConfigValuesInfo>();
            LevelJobSummaryList = new BOSList<ADConfigValuesInfo>();
            ConfigureRewardTimeReceiptTimeList = new BOSList<ADConfigValuesInfo>();
            ConfigureBonusLevelProductionGroupList = new BOSList<ADConfigValuesInfo>();
            ConfigureAccordingList = new BOSList<ADConfigValuesInfo>();

            DesignBonussList = new BOSList<HRDesignBonussInfo>();
            BonusChecksList = new BOSList<HRBonusChecksInfo>();
            ConfigureRewardTimesList = new BOSList<HRConfigureRewardTimesInfo>();
            ConfigureBonusLevelsList = new BOSList<HRConfigureBonusLevelsInfo>();
            ConfigureRewardLevelsList = new BOSList<HRConfigureRewardLevelsInfo>();
            AccountingStoresList = new BOSList<HRAccountingStoresInfo>();

            ACAssetTypeAccountConfigsList = new BOSList<ACAssetTypeAccountConfigsInfo>();
            ACAssetTypeDepreciationConfigsList = new BOSList<ACAssetTypeDepreciationConfigsInfo>();
            ACEquipmentTypeAccountConfigsList = new BOSList<ACEquipmentTypeAccountConfigsInfo>();

            PrivilegeAppSatffsList = new BOSList<ADPrivilegeAppSatffsInfo>();
            PrivilegeAppSatffGroupsList = new BOSList<ADConfigValuesInfo>();

            TemplatesList = new BOSList<ADTemplatesInfo>();
            TemplateParamsList = new BOSList<ADTemplateParamsInfo>();

            ReportTemplatesList = new BOSList<ADReportTemplatesInfo>();
            TemplateToolbarsList = new BOSList<ADTemplateToolbarsInfo>();
            GESaleCostList = new BOSList<ICFeeConfigsInfo>();
            MMProductionCostFactorGroupsList = new BOSList<MMProductionCostFactorGroupsInfo>();
            MMProductionCostFactorsList = new BOSList<MMProductionCostFactorsInfo>();
            MMProductionCostFactorAllocationRatesList = new BOSList<MMProductionCostFactorAllocationRatesInfo>();
            ProductionCostCollectTypeList = new BOSList<ADConfigValuesInfo>();
            ProductionCostAllocationTypeList = new BOSList<ADConfigValuesInfo>();
            ProductionCostInProgressCalTypeList = new BOSList<ADConfigValuesInfo>();
            StockConfigRateList = new BOSList<ICStockConfigRatesInfo>();
            ICPriceCalculationMethodsList = new BOSList<ICPriceCalculationMethodsInfo>();
            HRPercentageRetainedsList = new BOSList<HRPercentageRetainedsInfo>();
            CompletePermissionConfigList = new BOSList<ADCompletePermissionConfigsInfo>();
            ObjectViewPermissionList = new BOSList<ADObjectViewPermissionsInfo>();
            DefaultDescConfigList = new BOSList<ADDefaultDescConfigsInfo>();
            CostTypeConfigList = new BOSList<HRCostTypeConfigsInfo>();
            WorkingFeeConfigList = new BOSList<HRWorkingFeeConfigsInfo>();
            FormAllowancesList = new BOSList<HRFormAllowancesInfo>();
            TimesheetEmployeeLateConfigs = new BOSList<HRTimesheetEmployeeLateConfigsInfo>();
            AllowanceManageConfigsList = new BOSList<HRAllowanceManageConfigsInfo>();
            AllowanceManageConfigHistorysList = new BOSList<HRAllowanceManageConfigHistorysInfo>();
            ADTimesheetConfigList = new BOSList<ADTimesheetConfigsInfo>();
            HRPayRollConfigList = new BOSList<HRPayRollConfigsInfo>();
            HRConfigRanksList = new BOSList<HRConfigRanksInfo>();
            HRConfigScalesList = new BOSList<HRConfigScalesInfo>();
            HREmployeePayRollConfigList = new BOSList<HREmployeePayRollConfigsInfo>();
            EmployeeList = new BOSList<HREmployeesInfo>();

            ProductTemplatesTreeList = new BOSTreeList();

            HRAnnualLeaveDayConfigsList = new BOSList<HRAnnualLeaveDayConfigsInfo>();
            HROtherLeaveDayConfigsList = new BOSList<HROtherLeaveDayConfigsInfo>();
            HRSeniorityLeaveDayConfigsList = new BOSList<HRSeniorityLeaveDayConfigsInfo>();
            HRDepartmentRoomLeaveDayConfigsList = new BOSList<HRDepartmentRoomLeaveDayConfigsInfo>();
            HRRelationshipsList = new BOSList<HRRelationshipsInfo>();
            SalaryDocumentTypeList = new BOSList<ACSalaryDocumentTypesInfo>();
            SalaryEntryTypeList = new BOSList<ACSalaryEntryTypesInfo>();
            ARDeliveryMethodsList = new BOSList<ARDeliveryMethodsInfo>();
            ARSaleContractGroupList = new BOSList<ARSaleContractGroupsInfo>();
            APPurchaseContractGroupList = new BOSList<APPurchaseContractGroupsInfo>();
            ViewRefsList = new BOSList<ADReportViewRefsInfo>();
            ViewRefParamsList = new BOSList<ADReportViewRefParamsInfo>();
            FieldFormatList = new BOSList<STFieldFormatsInfo>();
            EquipmentStateList = new BOSList<ACEquipmentStatesInfo>();
            GenerateProductNoConfigList = new BOSList<GEGenerateProductNoConfigsInfo>();
            GeneratePackageConfigList = new BOSList<GEPackageNumeringConfigsInfo>();
            EInvoiceTypesList = new BOSList<ACEInvoiceTypesInfo>();
            InsurrancePlansList = new BOSList<ADInsurrancePlansInfo>();
            InsurrancePapersList = new BOSList<ADInsurrancePapersInfo>();
            InsurranceConditionsList = new BOSList<ADInsurranceConditionsInfo>();

            GETerminalsList = new BOSList<GETerminalsInfo>();
            GEUnitCostsList = new BOSList<GEUnitCostsInfo>();
            GEUnitCostContainersList = new BOSList<GEUnitCostContainersInfo>();

            CommodityTypeList = new BOSList<ADConfigValuesInfo>();
            CommodityProductTypeMappingList = new BOSList<ICCommodityProductTypeMappingsInfo>();
            ProductTypeMappingList = new BOSList<ICProductTypeMappingsInfo>();
            CommodityGridControlTypeMappingList = new BOSList<ICCommodityGridControlTypeMappingsInfo>();

            CurrencyExchangeRateList = new BOSList<GECurrencyExchangeRatesInfo>();
            BankList = new BOSList<GEBanksInfo>();
            MMProductionCostLinkConfigsList = new BOSList<MMProductionCostLinkConfigsInfo>();
            ProductionCostInProgressClassifyTypeList = new BOSList<ADConfigValuesInfo>();

            EmployeeSalaryConfigList = new BOSList<HREmployeeSalaryConfigsInfo>();
            ATMCardManageConfigList = new BOSList<HRATMCardManageConfigsInfo>();
            ListOfSalesChannelTypeList = new BOSList<ADConfigValuesInfo>();
            SourceSellingPriceTypeList = new BOSList<ADConfigValuesInfo>();
            ARSaleOrderSaleTypeConfigsList = new BOSList<ARSaleOrderSaleTypeConfigsInfo>();
        }
        #endregion

        public override void InitModuleEntity()
        {
            base.InitModuleEntity();

            UpdateModuleObjectBindingSource(TableName.CSCompanysTableName);
            UpdateModuleObjectBindingSource(TableName.ADInsurrancesTableName);
            InitDataToModuleObjectList();
        }

        #region Init Main Object,Module Objects functions
        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.CSCompanysTableName, Company);
            ModuleObjects.Add(TableName.HRTimeSheetParamsTableName, new HRTimeSheetParamsInfo());
            ModuleObjects.Add(TableName.ADWorkingShiftsTableName, new ADWorkingShiftsInfo());
            ModuleObjects.Add(TableName.CSCashFundsTableName, new CSCashFundsInfo());
            ModuleObjects.Add(TableName.ICProductFormulaPriceConfigsTableName, new ICProductFormulaPriceConfigsInfo());
            ModuleObjects.Add(TableName.ICImportAndExportReasonsTableName, new ICImportAndExportReasonsInfo());
            ModuleObjects.Add(TableName.ICCalculatedPackageVolumnConfigsTableName, new ICCalculatedPackageVolumnConfigsInfo());
            ModuleObjects.Add(TableName.GENumberingTableName, new GENumberingInfo());
            ModuleObjects.Add(TableName.ARCustomerResourcesTableName, new ARCustomerResourcesInfo());
            ModuleObjects.Add(TableName.ARCustomerBusinessTypesTableName, new ARCustomerBusinessTypesInfo());
            ModuleObjects.Add(TableName.ADTemplatesTableName, new ADTemplatesInfo());
            ModuleObjects.Add(TableName.ADDefaultDescConfigsTableName, new ADDefaultDescConfigsInfo());
            ModuleObjects.Add(TableName.ADInsurrancesTableName, InsurrancesInfo);
        }

        public override void InvalidateModuleObject(BusinessObject obj)
        {
            base.InvalidateModuleObject(obj);
            if (obj is ADTemplatesInfo)
            {
                TemplateParamsList.Invalidate((obj as ADTemplatesInfo).ADTemplateID);
                DataSet dsFieldFm = new STFieldFormatsController().GetFieldFormatsByModuleNameAndTableName("Report", (obj as ADTemplatesInfo).ADTemplateDataSource);
                FieldFormatList.Invalidate(dsFieldFm);
            }
            if (obj is ADReportViewRefsInfo)
            {
                ViewRefParamsList.Invalidate((obj as ADReportViewRefsInfo).ADReportViewRefID);
                if (ViewRefParamsList == null || ViewRefParamsList.Count == 0)
                {
                    ADTemplatesInfo objADTemplatesInfo = (ADTemplatesInfo)new ADTemplatesController().GetObjectByNo((obj as ADReportViewRefsInfo).ADReportViewRefName);
                    if (objADTemplatesInfo != null && objADTemplatesInfo.ADTemplateNo != string.Empty)
                    {
                        ADReportViewRefParamsController objReportViewRefParamsController = new ADReportViewRefParamsController();
                        List<ADReportViewRefParamsInfo> result = objReportViewRefParamsController.GetTemplateParam(objADTemplatesInfo.ADTemplateID);

                        if (result != null && result.Count > 0)
                        {
                            if ((obj as ADReportViewRefsInfo).ADReportViewRefID > 0)
                                result.ForEach(
                                    o =>
                                    {
                                        o.FK_ADReportViewRefID = (obj as ADReportViewRefsInfo).ADReportViewRefID;
                                    });
                            ViewRefParamsList.Invalidate(result);
                        }
                    }
                }
            }
        }
        public override void InvalidateModuleObjects(int iObjectID)
        {
            // HRTimeSheetParamList.Clear();
            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            DataSet ds = objTimeSheetParamsController.GetAllObjects();
            List<HRTimeSheetParamsInfo> list = new List<HRTimeSheetParamsInfo>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                HRTimeSheetParamsInfo objTimeSheetParamsInfo = new HRTimeSheetParamsInfo();
                objTimeSheetParamsInfo = (HRTimeSheetParamsInfo)objTimeSheetParamsController.GetObjectFromDataRow(row);
                objTimeSheetParamsInfo.HRTimeSheetParamValue2 = objTimeSheetParamsInfo.HRTimeSheetParamValue2 * 100;
                if (!objTimeSheetParamsInfo.IsOTCalculated)
                {
                    list.Add(objTimeSheetParamsInfo);
                }
            }
            HRTimeSheetParamList.Invalidate(list);
            //  HRTimeSheetParam2List.Clear();
            List<HRTimeSheetParamsInfo> list2 = new List<HRTimeSheetParamsInfo>();
            List<HRTimeSheetParamsInfo> lst = objTimeSheetParamsController.GetOTTimeSheetParamsList();
            foreach (HRTimeSheetParamsInfo info in lst)
            {

                info.HRTimeSheetParamValue2 = info.HRTimeSheetParamValue2 * 100;
                list2.Add(info);
            }
            HRTimeSheetParam2List.Invalidate(list2);
            ds.Dispose();

        }

        public override void InitModuleObjectList()
        {
            GENumberingsList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(GENumberingInfo)));
            ARPriceLevelsList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(ARPriceLevelsInfo)));
            GEVATsList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(GEVATsInfo)));
            ICMeasureUnitsList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(ICMeasureUnitsInfo)));
            CustomerBusinessTypeList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(ARCustomerBusinessTypesInfo)));
            ConfigRewardBestSellersList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(HRConfigRewardBestSellersInfo)));
            TimeRewardsList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(HRTimeRewardsInfo)));
            HRTimeSheetParamList.InitBOSList(
                                             this,
                                             String.Empty,
                                             TableName.HRTimeSheetParamsTableName,
                                             BOSList<HRTimeSheetParamsInfo>.cstRelationNone);
            HRTimeSheetParam2List.InitBOSList(
                                            this,
                                            String.Empty,
                                            TableName.HRTimeSheetParamsTableName,
                                            BOSList<HRTimeSheetParamsInfo>.cstRelationNone);
            HRWorkingShiftList.InitBOSList(
                                            this,
                                            String.Empty,
                                            TableName.HRWorkingShiftsTableName,
                                            BOSList<HRWorkingShiftsInfo>.cstRelationNone);

            HROTFactorList.InitBOSList(
                                        this,
                                        String.Empty,
                                        TableName.HROTFactorsTableName,
                                        BOSList<HROTFactorsInfo>.cstRelationNone);

            CSCompanyBankList.InitBOSList(this,
                                          String.Empty,
                                          TableName.CSCompanyBanksTable,
                                          BOSList<CSCompanyBanksInfo>.cstRelationNone);
            CSCashFundList.InitBOSList(this,
                                          String.Empty,
                                          TableName.CSCashFundsTableName,
                                          BOSList<CSCashFundsInfo>.cstRelationNone);
            ICImportAndExportReasonList.InitBOSList(this,
                                                String.Empty,
                                                TableName.ICImportAndExportReasonsTableName,
                                                BOSList<ICImportAndExportReasonsInfo>.cstRelationNone);
            ICCalculatedPackageVolumnConfigList.InitBOSList(this,
                                                String.Empty,
                                                TableName.ICCalculatedPackageVolumnConfigsTableName,
                                                BOSList<ICCalculatedPackageVolumnConfigsInfo>.cstRelationNone);
            CustomerTypeList.InitBOSList(this,
                                            String.Empty,
                                            TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);

            CustomerDistributionChannelTypeList.InitBOSList(this,
                                            String.Empty,
                                            TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);
            ProductTypeList.InitBOSList(this,
                                            String.Empty,
                                            TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);
            PaymentMethodList.InitBOSList(this, string.Empty, TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);

            ReportList.InitBOSList(this, string.Empty, TableName.ADReportsTableName);

            ReceiptVoucherTypeList.InitBOSList(this, string.Empty, TableName.ADConfigValuesTableName);

            PaymentVoucherTypeList.InitBOSList(this, string.Empty, TableName.ADConfigValuesTableName);

            HREmployeePieceWorksList.InitBOSList(this,
                                            String.Empty,
                                            TableName.HREmployeePieceWorksTableName,
                                            BOSList<HREmployeePieceWorksInfo>.cstRelationNone);
            EmployeeSalaryTypeList.InitBOSList(this, string.Empty, TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);
            HRTimeSheetParam3List.InitBOSList(this, string.Empty, TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);
            TrainingCourseList.InitBOSList(this, string.Empty, TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);
            AppUserPermissionList.InitBOSList(this, string.Empty, TableName.ADAppUserPermissionsTableName,
                                            BOSList<ADAppUserPermissionsInfo>.cstRelationNone);
            ContainerTypeList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ADConfigValuesTableName,
                                           BOSList<ADConfigValuesInfo>.cstRelationNone);
            ProductOriginList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ADConfigValuesTableName,
                                           BOSList<ADConfigValuesInfo>.cstRelationNone);
            ProductTrademarkList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ADConfigValuesTableName,
                                           BOSList<ADConfigValuesInfo>.cstRelationNone);
            ProductCollectionList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ADConfigValuesTableName,
                                           BOSList<ADConfigValuesInfo>.cstRelationNone);
            ProductStorageConditionList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ADConfigValuesTableName,
                                           BOSList<ADConfigValuesInfo>.cstRelationNone);

            ICProductFormulaPriceConfigsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ICProductFormulaPriceConfigsTableName,
                                           BOSList<ICProductFormulaPriceConfigsInfo>.cstRelationNone);

            ARCustomerTypeAccountConfigsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ARCustomerTypeAccountConfigsTableName,
                                           BOSList<ARCustomerTypeAccountConfigsInfo>.cstRelationNone);
            APSupplierTypeAccountConfigsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.APSupplierTypeAccountConfigsTableName,
                                           BOSList<APSupplierTypeAccountConfigsInfo>.cstRelationNone);
            ICProductTypeAccountConfigsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ICProductTypeAccountConfigsTableName,
                                           BOSList<ICProductTypeAccountConfigsInfo>.cstRelationNone);
            GENumberingList.InitBOSList(this,
                                        String.Empty,
                                        TableName.GENumberingTableName,
                                        BOSList<GENumberingInfo>.cstRelationNone);
            CustomerResourcesList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ARCustomerResourcesTableName,
                                           BOSList<ARCustomerResourcesInfo>.cstRelationNone);
            CustomerSaleOrderTypeConfigsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ARCustomerSaleOrderTypeConfigsTableName,
                                           BOSList<ARCustomerResourcesInfo>.cstRelationNone);
            FengShuisDirectionsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ADFengShuisDirectionTableName,
                                           BOSList<ADFengShuisDirectionsInfo>.cstRelationNone);
            FengShuisColorsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ADFengShuisColorTableName,
                                           BOSList<ADFengShuisColorsInfo>.cstRelationNone);
            FengShuisGenaralsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ADFengShuisGenaralTableName,
                                           BOSList<ADFengShuisGenaralsInfo>.cstRelationNone);

            TargetReportBudgetsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ADTargetReportBudgetsTableName,
                                           BOSList<ADTargetReportBudgetsInfo>.cstRelationNone);

            ProjectTypesList.InitBOSList(this,
                                        String.Empty,
                                        TableName.PMProjectTypesTableName,
                                        BOSList<PMProjectTypesInfo>.cstRelationNone);

            PhaseTypesList.InitBOSList(this,
                                        String.Empty,
                                        TableName.PMPhaseTypesTableName,
                                        BOSList<PMProjectTypesInfo>.cstRelationNone);

            LevelGraduationList.InitBOSList(this,
                                            String.Empty,
                                            TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);
            LevelQualificationList.InitBOSList(this,
                                            String.Empty,
                                            TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);
            ProductDepartmentGroupList.InitBOSList(this,
                                            String.Empty,
                                            TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);
            LevelDutiesResponsibilitiesFrequencyList.InitBOSList(this,
                                                                 String.Empty,
                                                                 TableName.ADConfigValuesTableName,
                                                                 BOSList<ADConfigValuesInfo>.cstRelationNone);
            LevelDutiesResponsibilitiesEvaluationCriteriaList.InitBOSList(this,
                                                                                 String.Empty,
                                                                                 TableName.ADConfigValuesTableName,
                                                                                 BOSList<ADConfigValuesInfo>.cstRelationNone);
            LevelExpList.InitBOSList(this,
                                            String.Empty,
                                            TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);
            LevelComputerProficiencyList.InitBOSList(this,
                                            String.Empty,
                                            TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);
            LevelNecessarySkillsList.InitBOSList(this,
                                            String.Empty,
                                            TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);
            LevelHealthList.InitBOSList(this,
                                            String.Empty,
                                            TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);
            SplitRatioGroupList.InitBOSList(this,
                                            String.Empty,
                                            TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);
            BonusLevelCalculatedOnList.InitBOSList(this,
                                            String.Empty,
                                            TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);
            LoanReceiptTypesList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ACLoanReceiptTypesTableName,
                                           BOSList<ACLoanReceiptTypesInfo>.cstRelationNone);
            CircumstancesRewardTypeList.InitBOSList(this,
                                            String.Empty,
                                            TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);
            BestSellerTypeList.InitBOSList(this,
                                            String.Empty,
                                            TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);
            SplitRatiosList.InitBOSList(this,
                                           String.Empty,
                                           TableName.HRSplitRatiosTableName,
                                           BOSList<HRSplitRatiosInfo>.cstRelationNone);
            BonusLevelsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.HRBonusLevelsTableName,
                                           BOSList<HRBonusLevelsInfo>.cstRelationNone);
            LevelMajorList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ADConfigValuesTableName,
                                           BOSList<ADConfigValuesInfo>.cstRelationNone);
            LevelJobSummaryList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ADConfigValuesTableName,
                                           BOSList<ADConfigValuesInfo>.cstRelationNone);
            ConfigureRewardTimeReceiptTimeList.InitBOSList(this,
                                                            String.Empty,
                                                            TableName.ADConfigValuesTableName,
                                                            BOSList<ADConfigValuesInfo>.cstRelationNone);
            ConfigureBonusLevelProductionGroupList.InitBOSList(this,
                                                                String.Empty,
                                                                TableName.ADConfigValuesTableName,
                                                                BOSList<ADConfigValuesInfo>.cstRelationNone);

            DesignBonussList.InitBOSList(this,
                                           String.Empty,
                                           TableName.HRDesignBonussTableName,
                                           BOSList<HRDesignBonussInfo>.cstRelationNone);
            BonusChecksList.InitBOSList(this,
                                           String.Empty,
                                           TableName.HRBonusChecksTableName,
                                           BOSList<HRBonusChecksInfo>.cstRelationNone);
            ConfigureRewardTimesList.InitBOSList(this,
                                           String.Empty,
                                           TableName.HRConfigureRewardTimesTableName,
                                           BOSList<HRConfigureRewardTimesInfo>.cstRelationNone);
            ConfigureBonusLevelsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.HRConfigureBonusLevelsTableName,
                                           BOSList<HRConfigureBonusLevelsInfo>.cstRelationNone);
            ConfigureRewardLevelsList.InitBOSList(this,
                                           String.Empty,
                                           TableName.HRConfigureRewardLevelsTableName,
                                           BOSList<HRConfigureRewardLevelsInfo>.cstRelationNone);
            AccountingStoresList.InitBOSList(this,
                                           String.Empty,
                                           TableName.HRAccountingStoresTableName,
                                           BOSList<HRAccountingStoresInfo>.cstRelationNone);

            ConfigureAccordingList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ADConfigValuesTableName,
                                           BOSList<ADConfigValuesInfo>.cstRelationNone);

            ACAssetTypeAccountConfigsList.InitBOSList(this,
                                          String.Empty,
                                          TableName.ACAssetTypeAccountConfigsTableName,
                                          BOSList<ACAssetTypeAccountConfigsInfo>.cstRelationNone);

            ACAssetTypeDepreciationConfigsList.InitBOSList(this,
                                         String.Empty,
                                         TableName.ACAssetTypeDepreciationConfigsTableName,
                                         BOSList<ACAssetTypeDepreciationConfigsInfo>.cstRelationNone);

            ACEquipmentTypeAccountConfigsList.InitBOSList(this,
                                                           String.Empty,
                                                           TableName.ACEquipmentTypeAccountConfigsTableName,
                                                           BOSList<ACEquipmentTypeAccountConfigsInfo>.cstRelationNone);
            ErrorTypeList.InitBOSList(this, string.Empty, TableName.HRErrorTypesTableName,
                                            BOSList<HRErrorTypesInfo>.cstRelationNone);

            PrivilegeAppSatffGroupsList.InitBOSList(this,
                                            String.Empty,
                                            TableName.ADConfigValuesTableName,
                                            BOSList<ADConfigValuesInfo>.cstRelationNone);

            PrivilegeAppSatffsList.InitBOSList(this,
                                               String.Empty,
                                               TableName.ADPrivilegeAppSatffsTableName,
                                               BOSList<ADPrivilegeAppSatffsInfo>.cstRelationNone);
            TemplatesList.InitBOSList(this,
                                        String.Empty,
                                        TableName.ADTemplatesTableName,
                                        BOSList<PMProjectTypesInfo>.cstRelationNone);

            TemplateParamsList.InitBOSList(this,
                                        TableName.ADTemplatesTableName,
                                        TableName.ADTemplateParamsTableName,
                                        BOSList<PMProjectTypesInfo>.cstRelationForeign);

            ReportTemplatesList.InitBOSList(this,
                                        String.Empty,
                                        TableName.ADReportTemplatesTableName,
                                        BOSList<ADReportTemplatesInfo>.cstRelationNone);

            TemplateToolbarsList.InitBOSList(this,
                                        String.Empty,
                                        TableName.ADTemplateToolbarsTableName,
                                        BOSList<ADReportTemplatesInfo>.cstRelationNone);
            GESaleCostList.InitBOSList(this, String.Empty, BOSUtil.GetTableNameFromBusinessObjectType(typeof(ICFeeConfigsInfo)));

            MMProductionCostFactorGroupsList.InitBOSList(this,
                                          String.Empty,
                                          TableName.MMProductionCostFactorGroupsTableName,
                                          BOSList<MMProductionCostFactorGroupsInfo>.cstRelationNone);

            MMProductionCostFactorsList.InitBOSList(this,
                                          String.Empty,
                                          TableName.MMProductionCostFactorsTableName,
                                          BOSList<MMProductionCostFactorsInfo>.cstRelationNone);

            MMProductionCostFactorAllocationRatesList.InitBOSList(this,
                                          String.Empty,
                                          TableName.MMProductionCostFactorAllocationRatesTableName,
                                          BOSList<MMProductionCostFactorAllocationRatesInfo>.cstRelationNone);
            ProductionCostCollectTypeList.InitBOSList(this,
                                          String.Empty,
                                          TableName.ADConfigValuesTableName,
                                          BOSList<ADConfigValuesInfo>.cstRelationNone);
            ProductionCostAllocationTypeList.InitBOSList(this,
                                          String.Empty,
                                          TableName.ADConfigValuesTableName,
                                          BOSList<ADConfigValuesInfo>.cstRelationNone);
            ProductionCostInProgressCalTypeList.InitBOSList(this,
                                          String.Empty,
                                          TableName.ADConfigValuesTableName,
                                          BOSList<ADConfigValuesInfo>.cstRelationNone);

            StockConfigRateList.InitBOSList(this,
                                            String.Empty,
                                            TableName.ICStockConfigRatesTableName,
                                            BOSList<ICStockConfigRatesInfo>.cstRelationNone);

            ICPriceCalculationMethodsList.InitBOSList(this,
                                       String.Empty,
                                       TableName.ICPriceCalculationMethodsTableName,
                                       BOSList<ICPriceCalculationMethodsInfo>.cstRelationNone);
            HRPercentageRetainedsList.InitBOSList(this,
                                                    String.Empty,
                                                    TableName.HRPercentageRetainedsTableName,
                                                    BOSList<HRPercentageRetainedsInfo>.cstRelationNone);

            CompletePermissionConfigList.InitBOSList(this
                                                    , String.Empty
                                                    , TableName.ADCompletePermissionConfigsTableName
                                                    , BOSList<ADCompletePermissionConfigsInfo>.cstRelationNone);
            ObjectViewPermissionList.InitBOSList(this
                                                    , String.Empty
                                                    , TableName.ADObjectViewPermissionsTableName
                                                    , BOSList<ADCompletePermissionConfigsInfo>.cstRelationNone);
            DefaultDescConfigList.InitBOSList(this
                                            , String.Empty
                                            , TableName.ADDefaultDescConfigsTableName
                                            , BOSList<ADDefaultDescConfigsInfo>.cstRelationNone);

            CostTypeConfigList.InitBOSList(this,
                                        String.Empty,
                                        TableName.HRCostTypeConfigsTableName,
                                        BOSList<HRCostTypeConfigsInfo>.cstRelationNone);

            WorkingFeeConfigList.InitBOSList(this,
                                        String.Empty,
                                        TableName.HRWorkingFeeConfigsTableName,
                                        BOSList<HRConfigScalesInfo>.cstRelationNone);

            FormAllowancesList.InitBOSList(this,
                                           String.Empty,
                                           TableName.HRFormAllowancesTableName,
                                           BOSList<HRFormAllowancesInfo>.cstRelationNone);

            TimesheetEmployeeLateConfigs.InitBOSList(this,
                                                        string.Empty,
                                                        TableName.HRTimesheetEmployeeLateConfigsTableName,
                                                        BOSList<HRTimesheetEmployeeLateConfigsInfo>.cstRelationNone);

            AllowanceManageConfigsList.InitBOSList(this,
                                            String.Empty,
                                            TableName.HRAllowanceManageConfigsTableName,
                                            BOSList<HRAllowanceManageConfigsInfo>.cstRelationNone);
            AllowanceManageConfigHistorysList.InitBOSList(this,
                                           String.Empty,
                                           TableName.HRAllowanceManageConfigHistorysTableName,
                                           BOSList<HRAllowanceManageConfigHistorysInfo>.cstRelationNone);

            ADTimesheetConfigList.InitBOSList(this,
                                                string.Empty,
                                                TableName.ADTimesheetConfigsTableName,
                                                BOSList<ADTimesheetConfigsInfo>.cstRelationNone);

            HRConfigRanksList.InitBOSList(this,
                                                string.Empty,
                                                "HRConfigRanks",
                                                BOSList<HRConfigRanksInfo>.cstRelationNone);
            HRRelationshipsList.InitBOSList(this,
                                               string.Empty,
                                               "HRRelationships",
                                               BOSList<HRRelationshipsInfo>.cstRelationNone);


            HRPayRollConfigList.InitBOSList(this,
                                                string.Empty,
                                                TableName.HRPayRollConfigsTableName,
                                                BOSList<HRPayRollConfigsInfo>.cstRelationNone);

            HREmployeePayRollConfigList.InitBOSList(this,
                                                string.Empty,
                                                TableName.HREmployeePayRollConfigsTableName,
                                                BOSList<HREmployeePayRollConfigsInfo>.cstRelationNone);
            EmployeeList.InitBOSList(this,
                                     String.Empty,
                                     TableName.HREmployeesTableName,
                                     BOSList<HREmployeesInfo>.cstRelationNone);

            ProductTemplatesTreeList.InitBOSList(this,
                                                 string.Empty,
                                                 TableName.ICProductTemplateConfigsTableName,
                                                 BOSTreeList.cstRelationNone);

            HRConfigScalesList.InitBOSList(this,
                                                string.Empty,
                                                "HRConfigScales",
                                                BOSList<HRConfigScalesInfo>.cstRelationNone);

            HRAnnualLeaveDayConfigsList.InitBOSList(this,
                                                string.Empty,
                                                "HRAnnualLeaveDayConfigs",
                                                BOSList<HRAnnualLeaveDayConfigsInfo>.cstRelationNone);
            HRSeniorityLeaveDayConfigsList.InitBOSList(this,
                                                string.Empty,
                                                "HRSeniorityLeaveDayConfigs",
                                                BOSList<HRSeniorityLeaveDayConfigsInfo>.cstRelationNone);
            HRDepartmentRoomLeaveDayConfigsList.InitBOSList(this,
                                                string.Empty,
                                                "HRDepartmentRoomLeaveDayConfigs",
                                                BOSList<HRDepartmentRoomLeaveDayConfigsInfo>.cstRelationNone);
            HROtherLeaveDayConfigsList.InitBOSList(this,
                                                string.Empty,
                                                "HROtherLeaveDayConfigs",
                                                BOSList<HROtherLeaveDayConfigsInfo>.cstRelationNone);
            SalaryDocumentTypeList.InitBOSList(this,
                                          String.Empty,
                                          TableName.ACSalaryDocumentTypesTableName,
                                          BOSList<ACSalaryDocumentTypesInfo>.cstRelationNone);
            SalaryEntryTypeList.InitBOSList(this,
                                          String.Empty,
                                          TableName.ACSalaryEntryTypesTableName,
                                          BOSList<ACSalaryEntryTypesInfo>.cstRelationNone);
            ARDeliveryMethodsList.InitBOSList(this,
                                          String.Empty,
                                          TableName.ARDeliveryMethodsTableName,
                                          BOSList<ARDeliveryMethodsInfo>.cstRelationNone);
            ARSaleContractGroupList.InitBOSList(this,
                                          String.Empty,
                                          TableName.ARSaleContractGroupsTableName,
                                          BOSList<ARDeliveryMethodsInfo>.cstRelationNone);
            APPurchaseContractGroupList.InitBOSList(this,
                                          String.Empty,
                                          TableName.APPurchaseContractGroupsTableName,
                                          BOSList<ARDeliveryMethodsInfo>.cstRelationNone);
            ViewRefsList.InitBOSList(this,
                                        String.Empty,
                                        "ADReportViewRefs",
                                        BOSList<ADReportViewRefsInfo>.cstRelationNone);

            ViewRefParamsList.InitBOSList(this,
                                        "ADReportViewRefs",
                                        "ADReportViewRefParams",
                                        BOSList<ADReportViewRefParamsInfo>.cstRelationForeign);
            ViewRefParamsList.ItemTableForeignKey = "FK_ADReportViewRefID";

            FieldFormatList.InitBOSList(this,
                                        String.Empty,
                                        "STFieldFormats",
                                        BOSList<STFieldFormatsInfo>.cstRelationNone);

            EquipmentStateList.InitBOSList(this,
                                            String.Empty,
                                            TableName.ACEquipmentStatesTableName,
                                            BOSList<ACEquipmentStatesInfo>.cstRelationNone);

            GenerateProductNoConfigList.InitBOSList(this,
                                                    String.Empty,
                                                    TableName.GEGenerateProductNoConfigsTableName,
                                                    BOSList<GEGenerateProductNoConfigsInfo>.cstRelationNone);
            GeneratePackageConfigList.InitBOSList(this,
                                                    String.Empty,
                                                    TableName.GEPackageNumeringConfigsTableName,
                                                    BOSList<GEPackageNumeringConfigsInfo>.cstRelationNone);
            EInvoiceTypesList.InitBOSList(this,
                                          String.Empty,
                                          TableName.ACEInvoiceTypesTableName,
                                          BOSList<ACEInvoiceTypesInfo>.cstRelationNone);
            InsurrancePlansList.InitBOSList(this,
                                        String.Empty,
                                        TableName.ADInsurrancePlansTableName,
                                        BOSList<PMProjectTypesInfo>.cstRelationNone);
            InsurrancePapersList.InitBOSList(this,
                                        String.Empty,
                                        TableName.ADInsurrancePapersTableName,
                                        BOSList<PMProjectTypesInfo>.cstRelationNone);
            InsurranceConditionsList.InitBOSList(this,
                                        String.Empty,
                                        TableName.ADInsurranceConditionsTableName,
                                        BOSList<PMProjectTypesInfo>.cstRelationNone);
            GETerminalsList.InitBOSList(this,
                                       String.Empty,
                                       "GETerminals",
                                       BOSList<ADConfigValuesInfo>.cstRelationNone);
            GEUnitCostsList.InitBOSList(this,
                                      String.Empty,
                                      "GEUnitCosts",
                                      BOSList<ADConfigValuesInfo>.cstRelationNone);
            GEUnitCostContainersList.InitBOSList(this,
                                      String.Empty,
                                      "GEUnitCostContainers",
                                      BOSList<ADConfigValuesInfo>.cstRelationNone);

            CommodityTypeList.InitBOSList(this,
                                       String.Empty,
                                       TableName.ADConfigValuesTableName,
                                       BOSList<ADConfigValuesInfo>.cstRelationNone);
            CommodityProductTypeMappingList.InitBOSList(this,
                                       String.Empty,
                                       TableName.ICCommodityProductTypeMappingsTableName,
                                       BOSList<ICCommodityProductTypeMappingsInfo>.cstRelationNone);
            ProductTypeMappingList.InitBOSList(this,
                                       String.Empty,
                                       TableName.ICProductTypeMappingsTableName,
                                       BOSList<ICProductTypeMappingsInfo>.cstRelationNone);
            CommodityGridControlTypeMappingList.InitBOSList(this,
                                       String.Empty,
                                       TableName.ICCommodityGridControlTypeMappingsTableName,
                                       BOSList<ICCommodityGridControlTypeMappingsInfo>.cstRelationNone);

            CurrencyExchangeRateList.InitBOSList(this,
                                       String.Empty,
                                       TableName.GECurrencyExchangeRatesTableName,
                                       BOSList<GECurrencyExchangeRatesInfo>.cstRelationNone);
            BankList.InitBOSList(this,
                                       String.Empty,
                                       TableName.GEBanksTableName,
                                       BOSList<GEBanksInfo>.cstRelationNone);

            MMProductionCostLinkConfigsList.InitBOSList(this,
                                          String.Empty,
                                          TableName.MMProductionCostLinkConfigsTableName,
                                          BOSList<MMProductionCostLinkConfigsInfo>.cstRelationNone);

            ProductionCostInProgressClassifyTypeList.InitBOSList(this,
                                         String.Empty,
                                         TableName.ADConfigValuesTableName,
                                         BOSList<ADConfigValuesInfo>.cstRelationNone);

            EmployeeSalaryConfigList.InitBOSList(this, string.Empty, TableName.HREmployeeSalaryConfigsTableName,
                                            BOSList<HREmployeeSalaryConfigsInfo>.cstRelationNone);
            ATMCardManageConfigList.InitBOSList(this,
                                       String.Empty,
                                       "HRATMCardManageConfigs",
                                       BOSList<STFieldFormatsInfo>.cstRelationNone);
            ListOfSalesChannelTypeList.InitBOSList(this,
                                       String.Empty,
                                       TableName.ADConfigValuesTableName,
                                       BOSList<ADConfigValuesInfo>.cstRelationNone);
            SourceSellingPriceTypeList.InitBOSList(this,
                                       String.Empty,
                                       TableName.ADConfigValuesTableName,
                                       BOSList<ADConfigValuesInfo>.cstRelationNone);
            ARSaleOrderSaleTypeConfigsList.InitBOSList(this,
                                          String.Empty,
                                          TableName.ARSaleOrderSaleTypeConfigsTableName,
                                          BOSList<ARSaleOrderSaleTypeConfigsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            GENumberingsList.InitBOSListGridControl();
            ARPriceLevelsList.InitBOSListGridControl(CompanyConstantModule.cstPriceLevelGridControl);
            GEVATsList.InitBOSListGridControl(CompanyConstantModule.cstTaxPercentTypeGridControl);
            HRTimeSheetParamList.InitBOSListGridControl();
            HRTimeSheetParam2List.InitBOSListGridControl("fld_dgcHRTimeSheetParam2s");
            HRWorkingShiftList.InitBOSListGridControl();
            HROTFactorList.InitBOSListGridControl();
            ICMeasureUnitsList.InitBOSListGridControl();
            ConfigRewardBestSellersList.InitBOSListGridControl(CompanyConstantModule.ConfigRewardBestSellersGridControl);
            TimeRewardsList.InitBOSListGridControl(CompanyConstantModule.TimeRewardsListGridControl);
            CSCompanyBankList.InitBOSListGridControl();
            CSCashFundList.InitBOSListGridControl();
            ICImportAndExportReasonList.InitBOSListGridControl();
            ICCalculatedPackageVolumnConfigList.InitBOSListGridControl(CompanyConstantModule.cstCalculatedPackageVolumnConfigsGridControl);
            CustomerTypeList.InitBOSListGridControl(CompanyConstantModule.cstCustomerTypeGridControl);
            CustomerBusinessTypeList.InitBOSListGridControl(CompanyConstantModule.cstCustomerBusinessGridControl);
            CustomerDistributionChannelTypeList.InitBOSListGridControl(CompanyConstantModule.cstCustomerDistributionChannelTypeGridControl);
            ProductTypeList.InitBOSListGridControl(CompanyConstantModule.cstProductTypeGridControl);
            ReportList.InitBOSListGridControl(CompanyConstantModule.ReportGridControlName);
            ReceiptVoucherTypeList.InitBOSListGridControl(CompanyConstantModule.ReceiptVoucherTypeGridControlName);
            PaymentVoucherTypeList.InitBOSListGridControl(CompanyConstantModule.PaymentVoucherTypeGridControlName);
            ContainerTypeList.InitBOSListGridControl(CompanyConstantModule.ContainerTypeGridControl);
            EmployeeSalaryTypeList.InitBOSListGridControl(CompanyConstantModule.SalaryTypeGridControlName);
            HRTimeSheetParam3List.InitBOSListGridControl(CompanyConstantModule.ADConfigValueHRTimeSheetParam);
            TrainingCourseList.InitBOSListGridControl(CompanyConstantModule.ADConfigValueTraningCourse);
            AppUserPermissionList.InitBOSListGridControl(CompanyConstantModule.AppUserPermission);
            ProductOriginList.InitBOSListGridControl("fld_dgcProductOrigin");
            ProductTrademarkList.InitBOSListGridControl("fld_dgcProductTrademark");
            ProductCollectionList.InitBOSListGridControl("fld_dgcProductCollection");
            ProductStorageConditionList.InitBOSListGridControl("fld_dgcProductStorageCondition");
            HREmployeePieceWorksList.InitBOSListGridControl();

            ICProductFormulaPriceConfigsList.InitBOSListGridControl(CompanyConstantModule.ICProductFormulaPriceConfigsGridControlName);
            ARCustomerTypeAccountConfigsList.InitBOSListGridControl();
            APSupplierTypeAccountConfigsList.InitBOSListGridControl();
            ICProductTypeAccountConfigsList.InitBOSListGridControl();
            GENumberingList.InitBOSListGridControl();
            CustomerResourcesList.InitBOSListGridControl("fld_dgcCustomerResourcesGridControl");
            CustomerSaleOrderTypeConfigsList.InitBOSListGridControl("fld_dgcCustomerSaleOrderTypeConfigs");

            FengShuisDirectionsList.InitBOSListGridControl(CompanyConstantModule.ADFengShuisDirectionsGridControlName);
            FengShuisColorsList.InitBOSListGridControl(CompanyConstantModule.ADFengShuisColorsGridControlName);
            FengShuisGenaralsList.InitBOSListGridControl(CompanyConstantModule.ADFengShuisGenaralsGridControlName);
            ErrorTypeList.InitBOSListGridControl(CompanyConstantModule.ErrorType);
            LevelGraduationList.InitBOSListGridControl(CompanyConstantModule.ADConfigValueHRLevelGraduationsGridControlName);
            LevelQualificationList.InitBOSListGridControl(CompanyConstantModule.ADConfigValueHRLevelQualificationsGridControlName);
            LevelDutiesResponsibilitiesFrequencyList.InitBOSListGridControl(CompanyConstantModule.ADConfigValueHRLevelDutiesResponsibilitiesFrequencysGridControlName);
            LevelDutiesResponsibilitiesEvaluationCriteriaList.InitBOSListGridControl(CompanyConstantModule.ADConfigValueHRLevelDutiesResponsibilitiesEvaluationCriteriasGridControlName);
            ProductDepartmentGroupList.InitBOSListGridControl(CompanyConstantModule.ADConfigValueICProductDepartmentGroupGridControlName);
            LevelExpList.InitBOSListGridControl(CompanyConstantModule.ADConfigValueHRLevelExpsGridControlName);
            LevelComputerProficiencyList.InitBOSListGridControl(CompanyConstantModule.ADConfigValueHRLevelComputerProficiencysGridControlName);
            LevelNecessarySkillsList.InitBOSListGridControl(CompanyConstantModule.ADConfigValueHRLevelNecessarySkillsGridControlName);
            LevelHealthList.InitBOSListGridControl(CompanyConstantModule.ADConfigValueHRLevelHealthsGridControlName);
            SplitRatioGroupList.InitBOSListGridControl(CompanyConstantModule.ADConfigValueHRSplitRatioGroupGridControlName);
            BonusLevelCalculatedOnList.InitBOSListGridControl(CompanyConstantModule.ADConfigValueHRSplitRatioGroupGridControlName);

            LoanReceiptTypesList.InitBOSListGridControl(CompanyConstantModule.ACLoanReceiptTypesGridControlName);
            CircumstancesRewardTypeList.InitBOSListGridControl(CompanyConstantModule.HRCircumstancesRewardGridControlName);
            BestSellerTypeList.InitBOSListGridControl(CompanyConstantModule.HRBestSellerTypeGridControlName);
            SplitRatiosList.InitBOSListGridControl(CompanyConstantModule.SplitRatiosGridControlName);

            BonusLevelsList.InitBOSListGridControl(CompanyConstantModule.BonusLevelsGridControlName);
            LevelMajorList.InitBOSListGridControl(CompanyConstantModule.ADConfigValueHRLevelMajorGridControlName);
            LevelJobSummaryList.InitBOSListGridControl(CompanyConstantModule.ADConfigValueHRLevelJobSummaryGridControlName);
            ConfigureRewardTimeReceiptTimeList.InitBOSListGridControl(CompanyConstantModule.ADConfigValueHRConfigureRewardTimeReceiptTimeGridControlName);
            ConfigureBonusLevelProductionGroupList.InitBOSListGridControl(CompanyConstantModule.ADConfigValueHRConfigureBonusLevelProductionGroupGridControlName);
            ConfigureAccordingList.InitBOSListGridControl(CompanyConstantModule.ADConfigValueHRConfigureAccordingGridControlName);

            DesignBonussList.InitBOSListGridControl(CompanyConstantModule.HRDesignBonussGridControlName);
            BonusChecksList.InitBOSListGridControl(CompanyConstantModule.BonusLevelsGridControlName);
            ConfigureRewardTimesList.InitBOSListGridControl(CompanyConstantModule.HRConfigureRewardTimesGridControlName);
            ConfigureBonusLevelsList.InitBOSListGridControl(CompanyConstantModule.HRConfigureBonusLevelsGridControlName);
            ConfigureRewardLevelsList.InitBOSListGridControl(CompanyConstantModule.HRConfigureRewardLevelsGridControlName);
            AccountingStoresList.InitBOSListGridControl(CompanyConstantModule.HRAccountingStoresGridControlName);

            TargetReportBudgetsList.InitBOSListGridControl(CompanyConstantModule.ADTargetReportBudgetsGridControlName);

            ProjectTypesList.InitBOSListGridControl(CompanyConstantModule.PMProjectTypesGridControlName);
            PhaseTypesList.InitBOSListGridControl(CompanyConstantModule.PMPhaseTypesGridControlName);

            ACAssetTypeAccountConfigsList.InitBOSListGridControl();
            ACAssetTypeDepreciationConfigsList.InitBOSListGridControl();
            ACEquipmentTypeAccountConfigsList.InitBOSListGridControl();
            EquipmentStateList.InitBOSListGridControl();

            PrivilegeAppSatffsList.InitBOSListGridControl(CompanyConstantModule.ADPrivilegeAppSatffsGridControlName);
            PrivilegeAppSatffGroupsList.InitBOSListGridControl(CompanyConstantModule.ADPrivilegeAppSatffGroupsGridControlName);

            TemplatesList.InitBOSListGridControl(CompanyConstantModule.ADTemplatesGridControlName);
            TemplateParamsList.InitBOSListGridControl(CompanyConstantModule.ADTemplateParamsGridControlName);

            ReportTemplatesList.InitBOSListGridControl(CompanyConstantModule.ADReportTemplatesGridControlName);
            TemplateToolbarsList.InitBOSListGridControl(CompanyConstantModule.ADTemplateToolbarsGridControlName);
            GESaleCostList.InitBOSListGridControl(CompanyConstantModule.cstGESaleCostGridControl);
            MMProductionCostFactorGroupsList.InitBOSListGridControl("fld_dgcMMProductionCostFactorGroups1");
            MMProductionCostFactorsList.InitBOSListGridControl();
            MMProductionCostFactorAllocationRatesList.InitBOSListGridControl();
            ProductionCostCollectTypeList.InitBOSListGridControl(CompanyConstantModule.ProductionCostCollectTypeGridControlName);
            ProductionCostAllocationTypeList.InitBOSListGridControl(CompanyConstantModule.ProductionCostAllocationTypeGridControlName);
            ProductionCostInProgressCalTypeList.InitBOSListGridControl(CompanyConstantModule.ProductionCostInProgressCalTypeGridControlName);
            StockConfigRateList.InitBOSListGridControl(CompanyConstantModule.StockConfigRatesGridControl);
            ICPriceCalculationMethodsList.InitBOSListGridControl(CompanyConstantModule.ICPriceCalculationMethodsGridControl);
            CompletePermissionConfigList.InitBOSListGridControl("fld_dgcCompletePermissionConfigsGridControl");
            ObjectViewPermissionList.InitBOSListGridControl("fld_dgcADObjectViewPermissionsGridControl");
            DefaultDescConfigList.InitBOSListGridControl("fld_dgcADDefaultDescConfigsGridControl");
            HRPercentageRetainedsList.InitBOSListGridControl();

            CostTypeConfigList.InitBOSListGridControl();
            WorkingFeeConfigList.InitBOSListGridControl();
            FormAllowancesList.InitBOSListGridControl();
            TimesheetEmployeeLateConfigs.InitBOSListGridControl();
            AllowanceManageConfigsList.InitBOSListGridControl();
            AllowanceManageConfigHistorysList.InitBOSListGridControl();
            ADTimesheetConfigList.InitBOSListGridControl();
            HRConfigScalesList.InitBOSListGridControl();
            HRConfigRanksList.InitBOSListGridControl();
            HRRelationshipsList.InitBOSListGridControl();
            HRPayRollConfigList.InitBOSListGridControl("fld_dgcHRPayRollConfigs");
            HREmployeePayRollConfigList.InitBOSListGridControl("fld_dgcHREmployeePayRollConfigs");
            ProductTemplatesTreeList.InitBOSTreeListControl("fld_trlProductTemplates");

            HRAnnualLeaveDayConfigsList.InitBOSListGridControl();
            HROtherLeaveDayConfigsList.InitBOSListGridControl();
            HRSeniorityLeaveDayConfigsList.InitBOSListGridControl();
            HRDepartmentRoomLeaveDayConfigsList.InitBOSListGridControl();

            SalaryDocumentTypeList.InitBOSListGridControl(CompanyConstantModule.SalaryDocumentTypeGridControlName);
            SalaryEntryTypeList.InitBOSListGridControl(CompanyConstantModule.SalaryEntryTypeGridControlName);
            ARDeliveryMethodsList.InitBOSListGridControl("fld_dgcARDeliveryMethods");
            ARSaleContractGroupList.InitBOSListGridControl("fld_dgcARSaleContractGroups");
            APPurchaseContractGroupList.InitBOSListGridControl("fld_dgcAPPurchaseContractGroups");
            ViewRefsList.InitBOSListGridControl("fld_dgcADReportViewRefs");
            ViewRefParamsList.InitBOSListGridControl("fld_dgcADReportViewRefParams");
            FieldFormatList.InitBOSListGridControl("fld_dgcSTFieldFormats");
            GenerateProductNoConfigList.InitBOSListGridControl("fld_dgcGenerateProductNoConfigsGridControl");
            GeneratePackageConfigList.InitBOSListGridControl("fld_dgcGEPackageNumeringConfigsGridControl");
            EInvoiceTypesList.InitBOSListGridControl();
            InsurrancePlansList.InitBOSListGridControl();
            InsurrancePapersList.InitBOSListGridControl();
            InsurranceConditionsList.InitBOSListGridControl();

            GETerminalsList.InitBOSListGridControl();
            GEUnitCostsList.InitBOSListGridControl();
            GEUnitCostContainersList.InitBOSListGridControl();

            CommodityTypeList.InitBOSListGridControl("fld_dgcCommodityType");
            CommodityProductTypeMappingList.InitBOSListGridControl("fld_dgcICCommodityProductTypeMappings");
            ProductTypeMappingList.InitBOSListGridControl("fld_dgcICProductTypeMappings");
            CommodityGridControlTypeMappingList.InitBOSListGridControl("fld_dgcICCommodityGridControlTypeMappings");

            CurrencyExchangeRateList.InitBOSListGridControl();
            BankList.InitBOSListGridControl();

            MMProductionCostLinkConfigsList.InitBOSListGridControl("fld_dgcMMProductionCostLinkConfigs");
            ProductionCostInProgressClassifyTypeList.InitBOSListGridControl(CompanyConstantModule.ProductionCostInProgressClassifyTypeGridControlName);

            EmployeeSalaryConfigList.InitBOSListGridControl(CompanyConstantModule.EmployeeSalaryConfig);
            ATMCardManageConfigList.InitBOSListGridControl();
            ListOfSalesChannelTypeList.InitBOSListGridControl("fld_dgcListOfSalesChannelType");
            SourceSellingPriceTypeList.InitBOSListGridControl("fld_dgcSourceSellingPriceType");
            ARSaleOrderSaleTypeConfigsList.InitBOSListGridControl("fld_dgcARSaleOrderSaleTypeConfigs");
        }
        #endregion

        public void InitDataToModuleObjectList()
        {
            GENumberingController objNumberingController = new GENumberingController();
            //NUThao [ADD] [08/04/2014] [DB centre] [GENumbering issue], START
            //DataSet ds = objNumberingController.GetAllObjects();
            //GENumberingsList.Invalidate(ds);
            DataSet dsCommonNumbering = objNumberingController.GetNumberingListByBranchID_2(0);
            DataSet ds = objNumberingController.GetNumberingListByBranchID_2(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            ds.Merge(dsCommonNumbering, true);
            //NUThao [ADD] [08/04/2014] [DB centre] [GENumbering issue], END
            STModuleDescriptionsController objModuleDescsController = new STModuleDescriptionsController();
            foreach (GENumberingInfo objNumberingsInfo in GENumberingsList)
            {
                STModuleDescriptionsInfo objModuleDescsInfo = objModuleDescsController.GetModuleDescriptionByModuleNameAndLanguageName(objNumberingsInfo.GENumberingName, BOSApp.CurrentLang);
                if (objModuleDescsInfo != null)
                    objNumberingsInfo.GENumberingDesc = objModuleDescsInfo.STModuleDescriptionDescription;
            }

            ARPriceLevelsController objPriceLevelsController = new ARPriceLevelsController();
            ds = objPriceLevelsController.GetAllObjects();
            ARPriceLevelsList.Invalidate(ds);

            GEVATsController objVATsController = new GEVATsController();
            ds = objVATsController.GetAllObjects();
            GEVATsList.Invalidate(ds);

            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ds = objMeasureUnitsController.GetAllObjects();
            ICMeasureUnitsList.Invalidate(ds);

            HRConfigRewardBestSellersController objConfigRewardBestSellersController = new HRConfigRewardBestSellersController();
            ds = objConfigRewardBestSellersController.GetAllObjects();
            ConfigRewardBestSellersList.Invalidate(ds);

            HRTimeRewardsController objTimeRewardsController = new HRTimeRewardsController();
            ds = objTimeRewardsController.GetAllObjects();
            TimeRewardsList.Invalidate(ds);

            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            ds = objTimeSheetParamsController.GetAllObjects();
            List<HRTimeSheetParamsInfo> list = new List<HRTimeSheetParamsInfo>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                HRTimeSheetParamsInfo objTimeSheetParamsInfo = new HRTimeSheetParamsInfo();
                objTimeSheetParamsInfo = (HRTimeSheetParamsInfo)objTimeSheetParamsController.GetObjectFromDataRow(row);
                objTimeSheetParamsInfo.HRTimeSheetParamValue2 = objTimeSheetParamsInfo.HRTimeSheetParamValue2 * 100;
                if (!objTimeSheetParamsInfo.IsOTCalculated)
                {
                    list.Add(objTimeSheetParamsInfo);
                }
            }
            HRTimeSheetParamList.Invalidate(list);
            List<HRTimeSheetParamsInfo> list2 = new List<HRTimeSheetParamsInfo>();
            List<HRTimeSheetParamsInfo> lst = objTimeSheetParamsController.GetOTTimeSheetParamsList();
            foreach (HRTimeSheetParamsInfo info in lst)
            {

                info.HRTimeSheetParamValue2 = info.HRTimeSheetParamValue2 * 100;
                list2.Add(info);
            }
            HRTimeSheetParam2List.Invalidate(list2);

            HRWorkingShiftsController wsController = new HRWorkingShiftsController();
            List<HRWorkingShiftsInfo> wsList = wsController.GetConfigWorkingShift();
            HRWorkingShiftList.Invalidate(wsList);

            HROTFactorsController objOTFactorsController = new HROTFactorsController();
            ds = objOTFactorsController.GetAllObjects();
            HROTFactorList.Invalidate(ds);

            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.CustomerType.ToString());
            CustomerTypeList.Invalidate(ds);

            ARCustomerBusinessTypesController objCustomerBusinessTypesController = new ARCustomerBusinessTypesController();
            ds = objCustomerBusinessTypesController.GetAllObjects();
            CustomerBusinessTypeList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.CustomerDistributionChannelType.ToString());
            CustomerDistributionChannelTypeList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ProductType.ToString());
            ProductTypeList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.PaymentMethod.ToString());
            PaymentMethodList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ContainerType.ToString());
            ContainerTypeList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ProductOrigin.ToString());
            ProductOriginList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ProductTrademark.ToString());
            ProductTrademarkList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ProductCollection.ToString());
            ProductCollectionList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ProductStorageCondition.ToString());
            ProductStorageConditionList.Invalidate(ds);

            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            ds = objCompanyBanksController.GetAllDataByForeignColumn("FK_CSCompanyID", Company.CSCompanyID);
            CSCompanyBankList.Invalidate(ds);

            CSCashFundsController objCashFundsController = new CSCashFundsController();
            ds = objCashFundsController.GetAllObjects();
            CSCashFundList.Invalidate(ds);

            ICImportAndExportReasonsController objImportAndExportReasonsController = new ICImportAndExportReasonsController();
            ds = objImportAndExportReasonsController.GetAllObjects();
            ICImportAndExportReasonList.Invalidate(ds);

            ICCalculatedPackageVolumnConfigsController objCalculatedPackageVolumnConfigsController = new ICCalculatedPackageVolumnConfigsController();
            ds = objCalculatedPackageVolumnConfigsController.GetAllObjects();
            ICCalculatedPackageVolumnConfigList.Invalidate(ds);

            ADReportsController objReportsController = new ADReportsController();
            ds = objReportsController.GetReportsByType(ReportType.PrintedDocument.ToString());
            ReportList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ReceiptVoucherType.ToString());
            ReceiptVoucherTypeList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.PaymentVoucherType.ToString());
            PaymentVoucherTypeList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.EmployeePayrollFormulaSalaryType.ToString());

            EmployeeSalaryTypeList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.HRTimeSheetParamType.ToString());
            HRTimeSheetParam3List.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.TrainingCourse.ToString());
            TrainingCourseList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ProductDepartmentGroup.ToString());
            ProductDepartmentGroupList.Invalidate(ds);

            HREmployeePieceWorksController objEmployeePieceWorksController = new HREmployeePieceWorksController();
            ds = objEmployeePieceWorksController.GetAllObjects();
            HREmployeePieceWorksList.Invalidate(ds);

            ICProductFormulaPriceConfigsController objProductFormulaPriceConfigsController = new ICProductFormulaPriceConfigsController();
            ds = objProductFormulaPriceConfigsController.GetAllObjects();
            ICProductFormulaPriceConfigsList.Invalidate(ds);

            ds = objNumberingController.GetAllObjects();
            GENumberingList.Invalidate(ds);
            
            ARCustomerResourcesController objCustomerResourcesController = new ARCustomerResourcesController();
            ds = objCustomerResourcesController.GetAllObjects();
            CustomerResourcesList.Invalidate(ds);

            ARCustomerSaleOrderTypeConfigsController objCustomerSaleOrderTypeConfigsController = new ARCustomerSaleOrderTypeConfigsController();
            ds = objCustomerSaleOrderTypeConfigsController.GetAllObjects();
            CustomerSaleOrderTypeConfigsList.Invalidate(ds);

            ADFengShuisGenaralsController objFengShuisGenaralsController = new ADFengShuisGenaralsController();
            ds = objFengShuisGenaralsController.GetAllObjects();
            FengShuisGenaralsList.Invalidate(ds);

            ADFengShuisDirectionsController objFengShuisDirectionsController = new ADFengShuisDirectionsController();
            ds = objFengShuisDirectionsController.GetAllObjects();
            FengShuisDirectionsList.Invalidate(ds);

            ADFengShuisColorsController objFengShuisColorsController = new ADFengShuisColorsController();
            ds = objFengShuisColorsController.GetAllObjects();
            FengShuisColorsList.Invalidate(ds);

            ADTargetReportBudgetsController objTargetReportBudgetsController = new ADTargetReportBudgetsController();
            ds = objTargetReportBudgetsController.GetAllTargetReportBudgets();
            TargetReportBudgetsList.Invalidate(ds);

            PMProjectTypesController objProjectTypesController = new PMProjectTypesController();
            ds = objProjectTypesController.GetAllObjects();
            ProjectTypesList.Invalidate(ds);

            PMPhaseTypesController objPhaseTypesController = new PMPhaseTypesController();
            ds = objPhaseTypesController.GetAllObjects();
            PhaseTypesList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.LevelGraduation.ToString());
            LevelGraduationList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.LevelQualification.ToString());
            LevelQualificationList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.LevelFrequency.ToString());
            //LevelFrequencyList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.LevelDutiesResponsibilitiesFrequency.ToString());
            LevelDutiesResponsibilitiesFrequencyList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.LevelDutiesResponsibilitiesEvaluationCriteria.ToString());
            LevelDutiesResponsibilitiesEvaluationCriteriaList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.LevelEvaluationCriteria.ToString());
            //LevelEvaluationCriteriaList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.LevelExp.ToString());
            LevelExpList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.LevelComputerProficiency.ToString());
            LevelComputerProficiencyList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.LevelNecessarySkills.ToString());
            LevelNecessarySkillsList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.LevelHealth.ToString());
            LevelHealthList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.BonusLevelCalculatedOn.ToString());
            BonusLevelCalculatedOnList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.SplitRatioGroup.ToString());
            SplitRatioGroupList.Invalidate(ds);

            ACLoanReceiptTypesController objLoanReceiptTypesController = new ACLoanReceiptTypesController();
            ds = objLoanReceiptTypesController.GetAllObjects();
            LoanReceiptTypesList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.CircumstancesRewardType.ToString());
            CircumstancesRewardTypeList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.BestSellerType.ToString());
            BestSellerTypeList.Invalidate(ds);
            HRSplitRatiosController objSplitRatiosController = new HRSplitRatiosController();
            ds = objSplitRatiosController.GetAllObjects();
            SplitRatiosList.Invalidate(ds);

            HRBonusLevelsController objBonusLevelsController = new HRBonusLevelsController();
            ds = objBonusLevelsController.GetAllObjects();
            BonusLevelsList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.LevelJobSummary.ToString());
            LevelJobSummaryList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.LevelMajor.ToString());
            LevelMajorList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ConfigureRewardTimeReceiptTime.ToString());
            ConfigureRewardTimeReceiptTimeList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ConfigureBonusLevelProductionGroup.ToString());
            ConfigureBonusLevelProductionGroupList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ConfigureAccording.ToString());
            ConfigureAccordingList.Invalidate(ds);

            HRDesignBonussController objDesignBonussController = new HRDesignBonussController();
            ds = objDesignBonussController.GetAllObjects();
            DesignBonussList.Invalidate(ds);

            HRBonusChecksController objBonusChecksController = new HRBonusChecksController();
            ds = objBonusChecksController.GetAllObjects();
            BonusChecksList.Invalidate(ds);

            HRConfigureRewardTimesController objConfigureRewardTimesController = new HRConfigureRewardTimesController();
            ds = objConfigureRewardTimesController.GetAllObjects();
            ConfigureRewardTimesList.Invalidate(ds);

            HRConfigureBonusLevelsController objConfigureBonusLevelsController = new HRConfigureBonusLevelsController();
            ds = objConfigureBonusLevelsController.GetAllObjects();
            ConfigureBonusLevelsList.Invalidate(ds);

            HRConfigureRewardLevelsController objConfigureRewardLevelsController = new HRConfigureRewardLevelsController();
            ds = objConfigureRewardLevelsController.GetAllObjects();
            ConfigureRewardLevelsList.Invalidate(ds);

            HRAccountingStoresController objAccountingStoresController = new HRAccountingStoresController();
            ds = objAccountingStoresController.GetAllObjects();
            AccountingStoresList.Invalidate(ds);

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.PrivilegeAppSatffGroup.ToString());
            PrivilegeAppSatffGroupsList.Invalidate(ds);

            ADPrivilegeAppSatffsController objPrivilegeAppSatffsController = new ADPrivilegeAppSatffsController();
            ds = objPrivilegeAppSatffsController.GetAllObjects();
            PrivilegeAppSatffsList.Invalidate(ds);

            ADTemplatesController objTemplatesController = new ADTemplatesController();
            ds = objTemplatesController.GetAllObjects();
            TemplatesList.Invalidate(ds);

            //ADTemplateParamsController objTemplateParamsController = new ADTemplateParamsController();
            //ds = objTemplateParamsController.GetAllObjects();
            //TemplateParamsList.Invalidate(ds);

            ADReportTemplatesController objReportTemplatesController = new ADReportTemplatesController();
            ds = objReportTemplatesController.GetAllObjects();
            ReportTemplatesList.Invalidate(ds);

            ADTemplateToolbarsController objTemplateToolbarsController = new ADTemplateToolbarsController();
            ds = objTemplateToolbarsController.GetAllObjects();
            TemplateToolbarsList.Invalidate(ds);
            InvalidateACAssetTypeAccountConfigsList();
            InvalidateACAssetTypeDepreciationConfigsList();
            InvalidateACEquipmentTypeAccountConfigsList();
            InvalidateACEquipmentStatesList();
            ICFeeConfigsController objFeeConfigsController = new ICFeeConfigsController();
            ds = objFeeConfigsController.GetAllObjects();
            GESaleCostList.Invalidate(ds);

            ICStockConfigRatesController objStockConfigRatesController = new ICStockConfigRatesController();
            ds = objStockConfigRatesController.GetAllObjects();
            StockConfigRateList.Invalidate(ds);

            ICPriceCalculationMethodsController objPriceCalculationMethodsController = new ICPriceCalculationMethodsController();
            ds = objPriceCalculationMethodsController.GetAllObjects();
            ICPriceCalculationMethodsList.Invalidate(ds);

            HRPercentageRetainedsController objPercentageRetainedsController = new HRPercentageRetainedsController();
            ds = objPercentageRetainedsController.GetAllObjects();
            HRPercentageRetainedsList.Invalidate(ds);

            ADCompletePermissionConfigsController objCompletePermissionConfigsController = new ADCompletePermissionConfigsController();
            ds = objCompletePermissionConfigsController.GetAllObjects();
            CompletePermissionConfigList.Invalidate(ds);

            ADObjectViewPermissionsController objObjectViewPermissionsController = new ADObjectViewPermissionsController();
            ds = objObjectViewPermissionsController.GetAllObjects();
            ObjectViewPermissionList.Invalidate(ds);

            ADDefaultDescConfigsController objDefaultDescConfigsController = new ADDefaultDescConfigsController();
            ds = objDefaultDescConfigsController.GetAllObjects();
            DefaultDescConfigList.Invalidate(ds);

            HRWorkingFeeConfigsController objWorkingFeeConfigsController = new HRWorkingFeeConfigsController();
            ds = objWorkingFeeConfigsController.GetAllObjects();
            WorkingFeeConfigList.Invalidate(ds);

            HRCostTypeConfigsController objCostTypeConfigsController = new HRCostTypeConfigsController();
            ds = objCostTypeConfigsController.GetAllObjects();
            CostTypeConfigList.Invalidate(ds);

            HRFormAllowancesController objFormAllowancesController = new HRFormAllowancesController();
            ds = objFormAllowancesController.GetAllObjects();
            FormAllowancesList.Invalidate(ds);

            HRTimesheetEmployeeLateConfigsController objTimesheetEmployeeLateConfigsController = new HRTimesheetEmployeeLateConfigsController();
            ds = objTimesheetEmployeeLateConfigsController.GetAllObjects();
            TimesheetEmployeeLateConfigs.Invalidate(ds);

            HRAllowanceManageConfigsController amcontroller = new HRAllowanceManageConfigsController();
            ds = amcontroller.GetAllObjects();
            AllowanceManageConfigsList.Invalidate(ds);

            HRAllowanceManageConfigHistorysController amchcontroller = new HRAllowanceManageConfigHistorysController();
            ds = amchcontroller.GetAllObjects();
            AllowanceManageConfigHistorysList.Invalidate(ds);

            ADTimesheetConfigsController objTimeSheetConfigsController = new ADTimesheetConfigsController();
            ds = objTimeSheetConfigsController.GetAllObjects();
            ADTimesheetConfigList.Invalidate(ds);

            HRConfigRanksController objConfigRanksController = new HRConfigRanksController();
            ds = objConfigRanksController.GetAllObjects();
            HRConfigRanksList.Invalidate(ds);

            HRRelationshipsController objRelationshipsController = new HRRelationshipsController();
            ds = objRelationshipsController.GetAllObjects();
            HRRelationshipsList.Invalidate(ds);

            HRPayRollConfigsController objPayRollConfigsController = new HRPayRollConfigsController();
            ds = objPayRollConfigsController.GetAllObjects();
            HRPayRollConfigList.Invalidate(ds);

            HREmployeePayRollConfigsController objEmployeePayRollConfigsController = new HREmployeePayRollConfigsController();
            ds = objEmployeePayRollConfigsController.GetAllObjects();
            HREmployeePayRollConfigList.Invalidate(ds);

            HRConfigScalesController objConfigScalesController = new HRConfigScalesController();
            ds = objConfigScalesController.GetAllObjects();
            HRConfigScalesList.Invalidate(ds);
            ds.Dispose();

            HRAnnualLeaveDayConfigsController objAnnualLeaveDayConfigsController = new HRAnnualLeaveDayConfigsController();
            ds = objAnnualLeaveDayConfigsController.GetAllObjects();
            HRAnnualLeaveDayConfigsList.Invalidate(ds);
            ds.Dispose();

            HRSeniorityLeaveDayConfigsController objSeniorityLeaveDayConfigsController = new HRSeniorityLeaveDayConfigsController();
            ds = objSeniorityLeaveDayConfigsController.GetAllObjects();
            HRSeniorityLeaveDayConfigsList.Invalidate(ds);
            ds.Dispose();

            HRDepartmentRoomLeaveDayConfigsController objDepartmentRoomLeaveDayConfigsController = new HRDepartmentRoomLeaveDayConfigsController();
            ds = objDepartmentRoomLeaveDayConfigsController.GetAllObjects();
            HRDepartmentRoomLeaveDayConfigsList.Invalidate(ds);
            ds.Dispose();

            HROtherLeaveDayConfigsController objOtherLeaveDayConfigsController = new HROtherLeaveDayConfigsController();
            ds = objOtherLeaveDayConfigsController.GetAllObjects();
            HROtherLeaveDayConfigsList.Invalidate(ds);
            ds.Dispose();

            ARDeliveryMethodsController objDeliveryMethodsController = new ARDeliveryMethodsController();
            ds = objDeliveryMethodsController.GetAllObjects();
            ARDeliveryMethodsList.Invalidate(ds);
            ds.Dispose();

            ARSaleContractGroupsController objSaleContractGroupsController = new ARSaleContractGroupsController();
            ds = objSaleContractGroupsController.GetAllObjects();
            ARSaleContractGroupList.Invalidate(ds);
            ds.Dispose();

            APPurchaseContractGroupsController objPurchaseContractGroupsController = new APPurchaseContractGroupsController();
            ds = objPurchaseContractGroupsController.GetAllObjects();
            APPurchaseContractGroupList.Invalidate(ds);
            ds.Dispose();

            ADReportViewRefsController objReportViewRefsController = new ADReportViewRefsController();
            ds = objReportViewRefsController.GetAllObjects();
            ViewRefsList.Invalidate(ds);
            ds.Dispose();

            HRATMCardManageConfigsController objATMCardManageConfigsController = new HRATMCardManageConfigsController();
            ds = objATMCardManageConfigsController.GetAllObjects();
            ATMCardManageConfigList.Invalidate(ds);
            ds.Dispose();

            GEGenerateProductNoConfigsController objGenerateProductNoConfigsController = new GEGenerateProductNoConfigsController();
            ds = objGenerateProductNoConfigsController.GetAllObjects();
            GenerateProductNoConfigList.Invalidate(ds);
            ds.Dispose();

            GEPackageNumeringConfigsController objGEPackageNumeringConfigsController = new GEPackageNumeringConfigsController();
            List<GEPackageNumeringConfigsInfo> listPackNumering = objGEPackageNumeringConfigsController.GetPackageNumberingList();
            GeneratePackageConfigList.Invalidate(listPackNumering);
            ds.Dispose();

            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ds = objEInvoiceTypesController.GetListEInvoiceTypesByTypeCombo(InvoiceTypeCombo.Purchase.ToString());
            EInvoiceTypesList.Invalidate(ds);
            ds.Dispose();

            ADInsurrancePlansController objInsurrancePlansController = new ADInsurrancePlansController();
            ds = objInsurrancePlansController.GetAllObjects();
            InsurrancePlansList.Invalidate(ds);
            ds.Dispose();

            ADInsurrancePapersController objInsurrancePapersController = new ADInsurrancePapersController();
            ds = objInsurrancePapersController.GetAllObjects();
            InsurrancePapersList.Invalidate(ds);
            ds.Dispose();

            ADInsurranceConditionsController objInsurranceConditionsController = new ADInsurranceConditionsController();
            ds = objInsurranceConditionsController.GetAllObjects();
            InsurranceConditionsList.Invalidate(ds);
            ds.Dispose();

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.CommodityType.ToString());
            CommodityTypeList.Invalidate(ds);
            ds.Dispose();

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ListOfSalesChannelType.ToString());
            ListOfSalesChannelTypeList.Invalidate(ds);
            ds.Dispose();

            ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.SourceSellingPriceType.ToString());
            SourceSellingPriceTypeList.Invalidate(ds);
            ds.Dispose();

            ARSaleOrderSaleTypeConfigsController objSaleOrderSaleTypeConfigsController = new ARSaleOrderSaleTypeConfigsController();
            ds = objSaleOrderSaleTypeConfigsController.GetAllObjects();
            ARSaleOrderSaleTypeConfigsList.Invalidate(ds);
            ds.Dispose();

            InvalidateEmployeeSalaryConfig();

            ds.Dispose();
        }

        /// <summary>
        /// Save working time config 
        /// </summary>
        /// <param name="daysPerMonth"></param>
        /// <param name="hoursPerDay"></param>
        public void SaveWorkingTimeConfig(string daysPerMonth, string hoursPerDay)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.DaysPerMonth.ToString());
            objConfigValuesInfo.ADConfigKeyValue = daysPerMonth;
            objConfigValuesController.UpdateObject(objConfigValuesInfo);

            objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.HoursPerDay.ToString());
            objConfigValuesInfo.ADConfigKeyValue = hoursPerDay;
            objConfigValuesController.UpdateObject(objConfigValuesInfo);
        }

        /// <summary>
        /// Save Orver time Audit config 
        /// </summary>
        /// <param name="oTAuditDay"></param>
        /// <param name="oTAuditMonth"></param>
        public void SaveOverTimeAuditConfig(string oTAuditDay, string oTAuditMonth, string subtractOT)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.OTAuditDay.ToString());
            objConfigValuesInfo.ADConfigKeyValue = oTAuditDay;
            objConfigValuesController.UpdateObject(objConfigValuesInfo);

            objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.OTAuditMonth.ToString());
            objConfigValuesInfo.ADConfigKeyValue = oTAuditMonth;
            objConfigValuesController.UpdateObject(objConfigValuesInfo);

            objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.SubtractOT.ToString());
            objConfigValuesInfo.ADConfigKeyValue = subtractOT;
            objConfigValuesController.UpdateObject(objConfigValuesInfo);
        }

        /// <summary>
        /// Save Orver time config 
        /// </summary>
        /// <param name="oTAuditDay"></param>
        /// <param name="oTAuditMonth"></param>
        public void SaveOverTimeConfig(string oTValueTime, string oTFromTime, string oTToTime)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.OTValueTime.ToString());
            objConfigValuesInfo.ADConfigKeyValue = oTValueTime;
            objConfigValuesController.UpdateObject(objConfigValuesInfo);

            objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.OTFromTime.ToString());
            objConfigValuesInfo.ADConfigKeyValue = oTFromTime;
            objConfigValuesController.UpdateObject(objConfigValuesInfo);

            objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.OTToTime.ToString());
            objConfigValuesInfo.ADConfigKeyValue = oTToTime;
            objConfigValuesController.UpdateObject(objConfigValuesInfo);
        }


        /// <summary>
        /// Save leave days config
        /// </summary>
        /// <param name="annualLeaveDays"></param>
        /// <param name="sickLeaveDays"></param>
        /// <param name="birthLeaveDays"></param>
        /// <param name="otLeaveDays"></param>
        public void SaveLeaveDaysConfig(string annualLeaveDays, string sickLeaveDays, string birthLeaveDays, string otLeaveDays, string normalLeaveDays)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.AnnualLeaveDays.ToString());
            objConfigValuesInfo.ADConfigKeyValue = annualLeaveDays;
            objConfigValuesController.UpdateObject(objConfigValuesInfo);

            objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.SickLeaveDays.ToString());
            objConfigValuesInfo.ADConfigKeyValue = sickLeaveDays;
            objConfigValuesController.UpdateObject(objConfigValuesInfo);

            objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.BirthLeaveDays.ToString());
            objConfigValuesInfo.ADConfigKeyValue = birthLeaveDays;
            objConfigValuesController.UpdateObject(objConfigValuesInfo);

            objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.OTLeaveDays.ToString());
            objConfigValuesInfo.ADConfigKeyValue = otLeaveDays;
            objConfigValuesController.UpdateObject(objConfigValuesInfo);

            objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.NormalLeaveDays.ToString());
            objConfigValuesInfo.ADConfigKeyValue = normalLeaveDays;
            objConfigValuesController.UpdateObject(objConfigValuesInfo);
        }


        /// <summary>
        /// Save company bank list
        /// </summary>
        public void SaveCompanyBankList()
        {
            foreach (CSCompanyBanksInfo objCompanyBanksInfo in CSCompanyBankList)
            {
                objCompanyBanksInfo.FK_CSCompanyID = Company.CSCompanyID;
            }
            CSCompanyBankList.SaveItemObjects();
        }

        public void InvalidateCustomerTypeAccountConfigsList()
        {
            ARCustomerTypeAccountConfigsController ctacController = new ARCustomerTypeAccountConfigsController();
            List<ARCustomerTypeAccountConfigsInfo> catcList = ctacController.GetAllAliveCustomerTypeAccountConfig();

            ARCustomerTypeAccountConfigsList.Invalidate(catcList);
        }

        public void InvalidateProductionCostFactorGroupsList()
        {
            MMProductionCostFactorGroupsController ctacController = new MMProductionCostFactorGroupsController();
            List<MMProductionCostFactorGroupsInfo> catcList = ctacController.GetAllAliveFactorGroup();

            MMProductionCostFactorGroupsList.Invalidate(catcList);
        }

        public void SaveProductionCostFactorGroupsList()
        {
            MMProductionCostFactorGroupsList.SaveItemObjects();
        }

        public void InvalidateProductionCostFactorsList()
        {
            MMProductionCostFactorsController ctacController = new MMProductionCostFactorsController();
            List<MMProductionCostFactorsInfo> catcList = ctacController.GetAllAliveFactor();

            MMProductionCostFactorsList.Invalidate(catcList);
        }

        public void InvalidateProductionCostFactorAllocationRatesList()
        {
            MMProductionCostFactorAllocationRatesController ctacController = new MMProductionCostFactorAllocationRatesController();
            List<MMProductionCostFactorAllocationRatesInfo> catcList = ctacController.GetAllAliveFactorAllocationRate();

            MMProductionCostFactorAllocationRatesList.Invalidate(catcList);
        }

        public void SaveProductionCostFactorsList()
        {
            MMProductionCostFactorsList.SaveItemObjects();
        }

        public void SaveProductionCostFactorAllocationRatesList()
        {
            MMProductionCostFactorAllocationRatesList.SaveItemObjects();
        }

        public void InvalidateProductionCostCollectType()
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("ProductionCostCollectType");
            ProductionCostCollectTypeList.Invalidate(ds);
        }

        public void InvalidateProductionCostAllocationType()
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("ProductionCostAllocationType");
            ProductionCostAllocationTypeList.Invalidate(ds);
        }
        public void InvalidateProductionCostInProgressCalType()
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("ProductionCostInProgressCalType");
            ProductionCostInProgressCalTypeList.Invalidate(ds);
        }

        public void SaveCustomerTypeAccountConfigsList()
        {
            ARCustomerTypeAccountConfigsList.SaveItemObjects();
        }

        public void InvalidateSupplierTypeAccountConfigsList()
        {
            APSupplierTypeAccountConfigsController ctacController = new APSupplierTypeAccountConfigsController();
            List<APSupplierTypeAccountConfigsInfo> catcList = ctacController.GetAllAliveSupplierTypeAccountConfig();

            APSupplierTypeAccountConfigsList.Invalidate(catcList);
        }

        public void SaveSupplierTypeAccountConfigsList()
        {
            APSupplierTypeAccountConfigsList.SaveItemObjects();
        }

        public void InvalidateProductTypeAccountConfigsList()
        {
            ICProductTypeAccountConfigsController ctacController = new ICProductTypeAccountConfigsController();
            List<ICProductTypeAccountConfigsInfo> catcList = ctacController.GetAllAliveProductTypeAccountConfig();

            ICProductTypeAccountConfigsList.Invalidate(catcList);
        }

        public void SaveProductTypeAccountConfigsList()
        {
            ICProductTypeAccountConfigsList.SaveItemObjects();
        }

        public void SaveLoanReceiptTypesList()
        {
            LoanReceiptTypesList.SaveItemObjects();
        }

        public void SaveSplitRatiosList()
        {
            SplitRatiosList.SaveItemObjects();
        }

        public void SaveBonusLevelsList()
        {
            BonusLevelsList.SaveItemObjects();
        }

        public void SaveDesignBonussList()
        {
            DesignBonussList.SaveItemObjects();
        }

        public void SaveBonusChecksList()
        {
            BonusChecksList.SaveItemObjects();
        }

        public void SaveConfigureRewardTimesList()
        {
            ConfigureRewardTimesList.SaveItemObjects();
        }

        public void SaveConfigureBonusLevelsList()
        {
            ConfigureBonusLevelsList.SaveItemObjects();
        }

        public void SaveConfigureRewardLevelsList()
        {
            ConfigureRewardLevelsList.SaveItemObjects();
        }

        public void SaveAccountingStoresList()
        {
            AccountingStoresList.SaveItemObjects();
        }

        public void SaveStockConfigRateList()
        {
            StockConfigRateList.SaveItemObjects();
        }

        public void InvalidateACAssetTypeAccountConfigsList()
        {
            ACAssetTypeAccountConfigsController ctacController = new ACAssetTypeAccountConfigsController();
            List<ACAssetTypeAccountConfigsInfo> catcList = ctacController.GetAllAliveAssetTypeAccountConfig();

            ACAssetTypeAccountConfigsList.Invalidate(catcList);
        }

        public void InvalidateACAssetTypeDepreciationConfigsList()
        {
            ACAssetTypeDepreciationConfigsController ctacController = new ACAssetTypeDepreciationConfigsController();
            List<ACAssetTypeDepreciationConfigsInfo> catcList = ctacController.GetAllAliveAssetTypeDepreciationConfig();

            ACAssetTypeDepreciationConfigsList.Invalidate(catcList);
        }

        public void InvalidateACEquipmentTypeAccountConfigsList()
        {
            ACEquipmentTypeAccountConfigsController ctemController = new ACEquipmentTypeAccountConfigsController();
            List<ACEquipmentTypeAccountConfigsInfo> catcList = ctemController.GetAllAliveEquipmentTypeAccountConfig();

            ACEquipmentTypeAccountConfigsList.Invalidate(catcList);
        }

        public void SaveAssetTypeAccountConfigsList()
        {
            ACAssetTypeAccountConfigsList.SaveItemObjects();
        }

        public void SaveAssetTypeDepreciationConfigsList()
        {
            ACAssetTypeDepreciationConfigsList.SaveItemObjects();
        }

        public void SaveEquipmentTypeDepreciationConfigsList()
        {
            ACEquipmentTypeAccountConfigsList.SaveItemObjects();
        }

        public void SavePrivilegeAppSatffs()
        {
            PrivilegeAppSatffsList.SaveItemObjects();
        }

        public void SaveCostTypesList()
        {
            CostTypeConfigList.SaveItemObjects();
        }

        public void SaveWorkingFeesList()
        {
            WorkingFeeConfigList.SaveItemObjects();
        }

        public void SavePriceCalculationMethodsList()
        {
            ICPriceCalculationMethodsList.SaveItemObjects();
        }

        public void SavePercentageRetainedsList()
        {
            HRPercentageRetainedsList.SaveItemObjects();
        }

        public void SaveCompletePermissionConfig()
        {
            CompletePermissionConfigList.RemoveAll(o => o.FK_STModuleID == 0 || o.FK_ADUserGroupID == 0);
            CompletePermissionConfigList.SaveItemObjects();
        }

        public void SaveObjectViewPermissionList()
        {
            ObjectViewPermissionList.RemoveAll(o => o.FK_STModuleID == 0);
            ObjectViewPermissionList.SaveItemObjects();
        }

        public void SaveDefaultDescConfigList()
        {
            DefaultDescConfigList.RemoveAll(o => o.FK_STModuleID == 0);
            DefaultDescConfigList.ForEach(o => o.ADDefaultDescConfigDescValue = o.ADDefaultDescConfigDescValue);
            DefaultDescConfigList.SaveItemObjects();
        }

        public void SavePayRollConfigsList()
        {
            HRPayRollConfigList.SaveItemObjects();
        }
        public void SaveEmployeePayRollConfigsList()
        {
            HREmployeePayRollConfigList.SaveItemObjects();
            //HREmployeePayRollConfigsController objEmployeePayRollConfigsController = new HREmployeePayRollConfigsController();
            //HREmployeePayRollConfigList.ForEach(o =>
            //{
            //    objEmployeePayRollConfigsController.UpdateObject(o);
            //});
        }

        public void InitDataToDMCS118()
        {
            ACSalaryDocumentTypesController objSalaryDocumentTypesController = new ACSalaryDocumentTypesController();
            DataSet ds = objSalaryDocumentTypesController.GetAllObjects();
            SalaryDocumentTypeList.Invalidate(ds);

            foreach (ACSalaryDocumentTypesInfo item in SalaryDocumentTypeList)
            {
                item.SalaryDocumentTypePayRollDetailsList = new BOSList<ACSalaryDocumentTypePayRollDetailsInfo>();
                item.SalaryDocumentTypePayRollDetailsList.InitBOSList(
                                                    this,
                                                    TableName.ACSalaryDocumentTypesTableName,
                                                    TableName.ACSalaryDocumentTypePayRollDetailsTableName,
                                                    BOSList<ACSalaryDocumentTypePayRollDetailsInfo>.cstRelationForeign);
                item.SalaryDocumentTypePayRollDetailsList.ItemTableForeignKey = "FK_ACSalaryDocumentTypeID";
                item.SalaryDocumentTypePayRollDetailsList.Invalidate(item.ACSalaryDocumentTypeID);
            }

            ACSalaryEntryTypesController objEntryTypesController = new ACSalaryEntryTypesController();
            ds = objEntryTypesController.GetListSalaryEntryTypeForDMCS118();
            SalaryEntryTypeList.Invalidate(ds);

            foreach (ACSalaryEntryTypesInfo item in SalaryEntryTypeList)
            {
                item.SalaryEntryTypeDetailPartsList = new BOSList<ACSalaryEntryTypeDetailPartsInfo>();
                item.SalaryEntryTypeDetailPartsList.InitBOSList(
                                                    this,
                                                    TableName.ACSalaryEntryTypesTableName,
                                                    TableName.ACSalaryEntryTypeDetailPartsTableName,
                                                    BOSList<ACSalaryEntryTypeDetailPartsInfo>.cstRelationForeign);
                item.SalaryEntryTypeDetailPartsList.ItemTableForeignKey = "FK_ACSalaryEntryTypeID";
                item.SalaryEntryTypeDetailPartsList.Invalidate(item.ACSalaryEntryTypeID);
            }
        }

        public void InvalidateACEquipmentStatesList()
        {
            ACEquipmentStatesController objEquipmentStatesController = new ACEquipmentStatesController();
            List<ACEquipmentStatesInfo> equipmentStates = objEquipmentStatesController.GetAllEquipmentStates();

            EquipmentStateList.Invalidate(equipmentStates);
        }

        public void SaveEquipmentStateList()
        {
            EquipmentStateList.SaveItemObjects();
        }

        public void SaveInsurrancePlansList()
        {
            InsurrancePlansList.SaveItemObjects();
        }

        public void SaveInsurrancePapersList()
        {
            InsurrancePapersList.SaveItemObjects();
        }

        public void SaveInsurranceConditionsList()
        {
            InsurranceConditionsList.SaveItemObjects();
        }

        public void InvalidateCostConfig()
        {
            GETerminalsController objTController = new GETerminalsController();
            GEUnitCostsController objUCController = new GEUnitCostsController();
            GEUnitCostContainersController objUCCController = new GEUnitCostContainersController();
            DataSet ds = objTController.GetAllObjects();
            GETerminalsList.Invalidate(ds);

            ds = objUCController.GetAllObjects();
            GEUnitCostsList.Invalidate(ds);

            ds = objUCCController.GetAllObjects();
            GEUnitCostContainersList.Invalidate(ds);
        }

        public void SaveCommodityProductTypeMappingList()
        {
            CommodityProductTypeMappingList.SaveItemObjects();
        }
        public void SaveProductTypeMappingList()
        {
            ProductTypeMappingList.SaveItemObjects();
        }
        public void SaveCommodityGridControlTypeMappingsList()
        {
            CommodityGridControlTypeMappingList.SaveItemObjects();
        }
        public void InvalidateCommodityGridControlTypeMappingList()
        {
            ICCommodityGridControlTypeMappingsController ctacController = new ICCommodityGridControlTypeMappingsController();
            DataSet ds = ctacController.GetAllObjects();

            CommodityGridControlTypeMappingList.Invalidate(ds);
        }
        public void InvalidateCommodityProductTypeMappingList()
        {
            ICCommodityProductTypeMappingsController ctacController = new ICCommodityProductTypeMappingsController();
            DataSet ds = ctacController.GetAllObjects();

            CommodityProductTypeMappingList.Invalidate(ds);
        }
        public void InvalidateProductTypeMappingList()
        {
            ICProductTypeMappingsController ctacController = new ICProductTypeMappingsController();
            DataSet ds = ctacController.GetAllObjects();

            ProductTypeMappingList.Invalidate(ds);
        }

        public void InvalidateCurrencyExchangeRateList()
        {
            GECurrencyExchangeRatesController ctacController = new GECurrencyExchangeRatesController();
            CurrencyExchangeRateList.Invalidate(ctacController.GetCurrencyExchangeRateByDate(BOSApp.GetCurrentServerDate()));
        }

        public void SaveBanksList()
        {
            BankList.SaveItemObjects();
        }

        public void InvalidateBankList()
        {
            GEBanksController objBanksController = new GEBanksController();
            DataSet ds = objBanksController.GetAllObjects();
            BankList.Invalidate(ds);
        }

        public void SaveProductionCostLinkConfigsList()
        {
            MMProductionCostLinkConfigsList.SaveItemObjects();
        }

        public void InvalidateMMProductionCostLinkConfigsList()
        {
            MMProductionCostLinkConfigsController ctacController = new MMProductionCostLinkConfigsController();
            List<MMProductionCostLinkConfigsInfo> catcList = ctacController.GetAllAliveLinkConfigs();

            MMProductionCostLinkConfigsList.Invalidate(catcList);
        }

        public void InvalidateProductionCostInProgressClassifyType()
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("ProductionCostInProgressClassifyType");
            ProductionCostInProgressClassifyTypeList.Invalidate(ds);
        }

        public void InvalidateEmployeeSalaryConfig()
        {
            //HREmployeeSalaryConfigsController objEmployeeSalaryConfigsController = new HREmployeeSalaryConfigsController();
            //DataSet ds = objEmployeeSalaryConfigsController.GetAllObjects();

            //EmployeeSalaryConfigList.Invalidate(ds);
            //ds.Dispose();
        }
        public void InvalidateAppUserPermission()
        {
            ADAppUserPermissionsController objAppUserPermissionsController = new ADAppUserPermissionsController();
            DataSet ds = objAppUserPermissionsController.GetAllObjects();

            AppUserPermissionList.Invalidate(ds);
            ds.Dispose();
        }
        public void SaveEmployeeSalaryConfig()
        {
            EmployeeSalaryConfigList.SaveItemObjects();
        }
        public void SaveAppUserPermission()
        {
            AppUserPermissionList.SaveItemObjects();
        }
        public void InvalidateErrorType()
        {
            HRErrorTypesController objErrorTypesController = new HRErrorTypesController();
            DataSet ds = objErrorTypesController.GetAllObjects();

            ErrorTypeList.Invalidate(ds);
            ds.Dispose();
        }
        public void SaveErrorType()
        {
            ErrorTypeList.SaveItemObjects();
        }
        public void SaveRanksList()
        {
            HRConfigRanksList.SaveItemObjects();
        }
        public void SaveRelationshipsList()
        {
            HRRelationshipsList.SaveItemObjects();
        }
        public void SaveScalesList()
        {
            HRConfigScalesList.SaveItemObjects();
        }
    }
}
