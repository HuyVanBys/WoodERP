using Localization;
using System;
using System.Windows.Forms;
using BOSLib;

namespace BOSERP.Modules.CompanyConstant.UI
{
    public partial class guiConfiguration : BOSERPScreen
    {
        private String CurrentSection;

        public guiConfiguration()
        {
            InitializeComponent();
        }

        private void fld_trlSections_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            CurrentSection = e.Node.Tag.ToString();

            switch (e.Node.Tag.ToString())
            {
                case "CompanyProfile":
                    DMCS100 guiCompanyProfile = new DMCS100();
                    guiCompanyProfile.ScreenNumber = "DMCS100";
                    guiCompanyProfile.Module = Module;
                    LoadScreen(guiCompanyProfile);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = true;
                    break;

                case "Customer":
                    DMCS101 guiCustomer = new DMCS101();
                    guiCustomer.ScreenNumber = "DMCS101";
                    guiCustomer.Module = Module;
                    LoadScreen(guiCustomer);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = true;
                    break;

                case "Product":
                    DMCS102 guiProduct = new DMCS102();
                    guiProduct.ScreenNumber = "DMCS102";
                    guiProduct.Module = Module;
                    LoadScreen(guiProduct);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = true;
                    break;

                case "Sale":
                    DMCS103 guiSale = new DMCS103();
                    guiSale.ScreenNumber = "DMCS103";
                    guiSale.Module = Module;
                    LoadScreen(guiSale);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = true;
                    break;

                case "Purchase":
                    DMCS119 guiPurchase = new DMCS119();
                    guiPurchase.ScreenNumber = "DMCS119";
                    guiPurchase.Module = Module;
                    LoadScreen(guiPurchase);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = true;
                    break;

                case "HumanResource":
                    DMCS105 guiStaff = new DMCS105();
                    guiStaff.ScreenNumber = "DMCS105";
                    guiStaff.Module = Module;
                    LoadScreen(guiStaff);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = true;
                    break;

                case "Accounting":
                    DMCS104 guiAccounting = new DMCS104();
                    guiAccounting.ScreenNumber = "DMCS104";
                    guiAccounting.Module = Module;
                    LoadScreen(guiAccounting);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = true;
                    break;

                case "Report":
                    DMCS106 guiReport = new DMCS106();
                    guiReport.ScreenNumber = "DMCS106";
                    guiReport.Module = Module;
                    LoadScreen(guiReport);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = true;
                    break;
                case "Stock":
                    DMCS107 guiStock = new DMCS107();
                    guiStock.ScreenNumber = "DMCS107";
                    guiStock.Module = Module;
                    LoadScreen(guiStock);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = true;
                    break;
                case "ObjectAccountConfig":
                    DMCS108 guiObjectAccountConfig = new DMCS108();
                    guiObjectAccountConfig.ScreenNumber = "DMCS108";
                    guiObjectAccountConfig.Module = Module;
                    LoadScreen(guiObjectAccountConfig);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateCustomerTypeAccountConfigsList();
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateSupplierTypeAccountConfigsList();
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateProductTypeAccountConfigsList();
                    fld_btnSave.Visible = false;
                    break;
                case "Genumbering":
                    DMCS109 guiGenumbering = new DMCS109();
                    guiGenumbering.ScreenNumber = "DMCS109";
                    guiGenumbering.Module = Module;
                    LoadScreen(guiGenumbering);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = true;
                    break;

                case "FengShuis":
                    DMCS110 guiFengShuis = new DMCS110();
                    guiFengShuis.ScreenNumber = "DMCS110";
                    guiFengShuis.Module = Module;
                    LoadScreen(guiFengShuis);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = true;
                    break;
                case "Budgets":
                    DMCS111 guiBudgets = new DMCS111();
                    guiBudgets.ScreenNumber = "DMCS111";
                    guiBudgets.Module = Module;
                    LoadScreen(guiBudgets);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = true;
                    break;
                case "Projects":
                    DMCS112 guiProjects = new DMCS112();
                    guiProjects.ScreenNumber = "DMCS112";
                    guiProjects.Module = Module;
                    LoadScreen(guiProjects);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = true;
                    break;
                case "AppStaff":
                    DMCS113 guiAppStaff = new DMCS113();
                    guiAppStaff.ScreenNumber = "DMCS113";
                    guiAppStaff.Module = Module;
                    LoadScreen(guiAppStaff);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = true;
                    break;
                case "Templates":
                    DMCS114 guiTemplace = new DMCS114();
                    guiTemplace.ScreenNumber = "DMCS114";
                    guiTemplace.Module = Module;
                    LoadScreen(guiTemplace);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = true;
                    break;
                case "TemplateAssigns":
                    DMCS115 guiTemplaceAssign = new DMCS115();
                    guiTemplaceAssign.ScreenNumber = "DMCS115";
                    guiTemplaceAssign.Module = Module;
                    LoadScreen(guiTemplaceAssign);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = true;
                    break;
                case "ProductionCostConfig":
                    DMCSProductionCostConfig guiDMCSProductionCostConfig = new DMCSProductionCostConfig();
                    guiDMCSProductionCostConfig.ScreenNumber = "DMCSProductionCostConfig";
                    guiDMCSProductionCostConfig.Module = Module;
                    LoadScreen(guiDMCSProductionCostConfig);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateProductionCostFactorGroupsList();
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateMMProductionCostLinkConfigsList();
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateProductionCostAllocationType();
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateProductionCostCollectType();
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateProductionCostInProgressClassifyType();
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateProductionCostInProgressCalType();
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateProductionCostFactorsList();
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateProductionCostFactorAllocationRatesList();

                    fld_btnSave.Visible = false;
                    break;
                case "CompletePermissionConfigs":
                    DMCS116 guiCompletePermissionConfigs = new DMCS116();
                    guiCompletePermissionConfigs.ScreenNumber = "DMCS116";
                    guiCompletePermissionConfigs.Module = Module;
                    LoadScreen(guiCompletePermissionConfigs);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = false;
                    break;
                case "ObjectViewConfig":
                    DMCS117 guiObjectViewConfig = new DMCS117();
                    guiObjectViewConfig.ScreenNumber = "DMCS117";
                    guiObjectViewConfig.Module = Module;
                    LoadScreen(guiObjectViewConfig);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = false;
                    break;
                case "SalaryDocument":
                    DMCS118 guiSalaryDocument = new DMCS118();
                    guiSalaryDocument.ScreenNumber = "DMCS118";
                    guiSalaryDocument.Module = Module;
                    LoadScreen(guiSalaryDocument);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitDataToDMCS118();
                    fld_btnSave.Visible = false;
                    break;
                case "ViewRef":
                    DMCS120 view = new DMCS120();
                    view.ScreenNumber = "DMCS120";
                    view.Module = Module;
                    LoadScreen(view);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    fld_btnSave.Visible = true;
                    break;
                case "Cost":
                    DMCS121 MachineGroup = new DMCS121();
                    MachineGroup.ScreenNumber = "DMCS121";
                    MachineGroup.Module = Module;
                    LoadScreen(MachineGroup);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateCostConfig();
                    fld_btnSave.Visible = true;
                    break;
                case "CommodityType":
                    DMCS122 commodityType = new DMCS122();
                    commodityType.ScreenNumber = "DMCS122";
                    commodityType.Module = Module;
                    LoadScreen(commodityType);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InitGridControlInBOSList();
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateCommodityGridControlTypeMappingList();
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateCommodityProductTypeMappingList();
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateProductTypeMappingList();
                    break;
                case "CurrencyExchangeRate":
                    DMCS123 currencyExchangeRate = new DMCS123();
                    currencyExchangeRate.ScreenNumber = "DMCS123";
                    currencyExchangeRate.Module = Module;
                    LoadScreen(currencyExchangeRate);
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateCurrencyExchangeRateList();
                    ((CompanyConstantEntities)((BaseModuleERP)Module).CurrentModuleEntity).InvalidateBankList();
                    break;
            }
        }

        private void LoadScreen(BOSERPScreen screen)
        {
            fld_pnlScreenContainer.Controls.Clear();
            screen.AddCustomControls(Module.Screens);
            screen.CustomizeControls(screen.Controls);
            screen.InitializeControls(screen.Controls);
            for (int i = 0; i < screen.Controls.Count; i++)
            {
                fld_pnlScreenContainer.Controls.Add(screen.Controls[i]);
                i--;
            }
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            bool isSuccess = true;
            BOSProgressBar.Start("Đang lưu dữ liệu");
            CompanyConstantModule module = (CompanyConstantModule)Module;
            switch (CurrentSection)
            {
                case "CompanyProfile":
                    isSuccess = module.SaveCompanyConfig();
                    break;

                case "Customer":
                    isSuccess = module.SaveCustomerConfig();
                    break;

                case "Product":
                    isSuccess = module.SaveProductConfig();
                    break;

                case "Sale":
                    isSuccess = module.SaveSaleConfig();
                    break;

                case "Purchase":
                    isSuccess = module.SavePurchaseConfig();
                    break;

                case "HumanResource":
                    isSuccess = module.SaveStaffConfig();
                    break;

                case "Accounting":
                    isSuccess = module.SaveAccountingConfig();
                    break;

                case "Report":
                    isSuccess = module.SaveReportConfig();
                    break;

                case "Stock":
                    isSuccess = module.SaveStockConfig();
                    break;

                case "Genumbering":
                    isSuccess = module.SaveNumberingConfig();
                    break;

                case "FengShuis":
                    isSuccess = module.SaveFengShuisConfig();
                    break;

                case "Budgets":
                    isSuccess = module.SaveBudgetsConfig();
                    break;

                case "Projects":
                    isSuccess = module.SaveProjectsConfig();
                    break;

                case "AppStaff":
                    isSuccess = module.SaveAppStaff();
                    break;

                case "Templates":
                    isSuccess = module.SaveAllTemplatesConfig();
                    break;

                case "TemplateAssigns":
                    isSuccess = module.SaveAllReportTemplatesConfig();
                    break;

                case "ViewRef":
                    isSuccess = module.SaveViewRefsConfig();
                    break;

                case "Cost":
                    isSuccess = module.SaveCostConfig();
                    break;

                case "CurrencyExchangeRate":
                    isSuccess = module.SaveCurrencyExchangeRate();
                    break;
            }
            BOSProgressBar.Close();
            if (isSuccess)
            {
                MessageBox.Show(CompanyConstantLocalizedResources.SaveSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
