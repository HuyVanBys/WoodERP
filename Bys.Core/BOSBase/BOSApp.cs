using BOSCommon;
using BOSCommon.Constants;
using BOSCommon.Extensions;
using BOSComponent;
using BOSLib;
using BOSLib.Interfaces;
using DevExpress.LookAndFeel;
using DevExpress.XtraTreeList;
using Localization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace BOSERP
{
    /// <summary>
    /// BOSApp is the main class which manage all module,screens of BOS System
    /// </summary>
    public partial class BOSApp
    {
        #region Constants
        public const int UserGroupAdmin = 1;
        #endregion

        #region Static variables for BOS Application
        public static int NumOfOpenedModules = 5;
        public static String CurrentModule = String.Empty;
        public static GUIMain MainScreen;
        public static System.Windows.Forms.Form ActiveScreen;
        public static String CurrentLang;
        public static String CurrentUser;

        public static SortedList OpenModules = new SortedList();
        public static Assembly BOSERPAssembly;


        private static int _currentUserGroupID;
        private static ADUsersInfo _currentUsersInfo;
        private static ADUserGroupsInfo _currentUserGroupsInfo;
        private static CSCompanysInfo _currentCompanyInfo;
        public static ImageList ToolbarImageList = new ImageList();
        public static ImageList SectionImageList = new ImageList();

        private static SortedList _lookupTables;
        private static SortedList _lookupTableUpdatedDate;

        private static SortedList _fieldFormatGroups;
        private static int _priceDecimal = 2;
        private static SortedList _gETables;
        private static List<ADDataViewPermissionsInfo> _currentDataViewPermissionList;
        private static List<ICProductsForViewInfo> _currentProductList;
        private static List<GELookupTablesInfo> _lookupTableList;
        private static List<STScreensInfo> _lstScreen;
        private static List<STFieldsInfo> _lstField;
        private static List<STFieldColumnsInfo> _lstFieldColumn;
        private static List<STFieldEventsInfo> _lstFieldEvent;
        private static List<STFieldEventFunctionsInfo> _lstFieldEventFunc;
        private static List<STFieldPermissionsInfo> _lstFieldPermission;
        private static SortedList _lstFieldColumnPermissions;
        private static List<STFieldFormatGroupsInfo> _fieldFormatList;
        private static List<AAColumnAliasInfo> _columnAliasList;
        public static List<STModulesInfo> ModuleList;
        public static List<STModuleDescriptionsInfo> ModuleDescriptionList;
        public static List<STToolbarsInfo> ListToolbar;
        public static List<STToolbarFunctionsInfo> ListToolbarFunc;
        public static List<STToolbarFunctionParametersInfo> ListToolbarFuncParam;
        public static List<STFieldEventFunctionParametersInfo> ListFieldEventFuncParam;
        public static List<STModuleFunctionsInfo> ListModuleFunction;
        public static List<STModuleFunctionParametersInfo> ListModuleFunctionParam;
        public static List<STModuleFunctionParameterValuesInfo> ListModuleFunctionParamValue;
        public static bool UsingCarCass;
        public static bool IsUsedCheckProductCode;
        public static List<String> ModulesListApplyValidateSerial;
        public static List<string> WoodTypesList { get; set; }
        #endregion

        #region Properties
        public static ADUsersInfo CurrentUsersInfo
        {
            get
            {
                return _currentUsersInfo;
            }
            set
            {
                _currentUsersInfo = value;
            }
        }

        public static ADUserGroupsInfo CurrentUserGroupInfo
        {
            get
            {
                return _currentUserGroupsInfo;
            }
        }

        public static CSCompanysInfo CurrentCompanyInfo
        {
            get
            {
                return _currentCompanyInfo;
            }
            set
            {
                _currentCompanyInfo = value;
            }
        }

        public static SortedList LookupTables
        {
            get
            {
                return _lookupTables;
            }
            set
            {
                _lookupTables = value;
            }
        }
        public static SortedList RoundColTable
        {
            get
            {
                return _gETables;
            }
            set
            {
                _gETables = value;
            }
        }
        public static SortedList LookupTablesUpdatedDate
        {
            get
            {
                return _lookupTableUpdatedDate;
            }
            set
            {
                _lookupTableUpdatedDate = value;
            }
        }

        public static SortedList FieldFormatGroups
        {
            get
            {
                return _fieldFormatGroups;
            }
            set
            {
                _fieldFormatGroups = value;
            }
        }

        public static int PriceDecimal
        {
            get
            {
                return _priceDecimal;
            }

            set
            {
                _priceDecimal = value;
            }
        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public static List<ADDataViewPermissionsInfo> CurrentADDataViewPermissionList
        {
            get
            {
                return _currentDataViewPermissionList;
            }
            set
            {
                _currentDataViewPermissionList = value;
            }
        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        //TNDLoc [ADD] [12/01/2016] [ProductList],START
        public static List<ICProductsForViewInfo> CurrentProductList
        {
            get
            {
                return _currentProductList;
            }
            set
            {
                _currentProductList = value;
            }
        }
        public static List<GELookupTablesInfo> LookupTableList
        {
            get
            {
                return _lookupTableList;
            }
            set
            {
                _lookupTableList = value;
            }
        }
        public static List<STScreensInfo> LstScreen
        {
            get
            {
                return _lstScreen;
            }
            set
            {
                _lstScreen = value;
            }
        }
        public static List<STFieldsInfo> LstField
        {
            get
            {
                return _lstField;
            }
            set
            {
                _lstField = value;
            }
        }
        public static List<STFieldColumnsInfo> LstFieldColumn
        {
            get
            {
                return _lstFieldColumn;
            }
            set
            {
                _lstFieldColumn = value;
            }
        }
        public static List<STFieldEventsInfo> LstFieldEvent
        {
            get
            {
                return _lstFieldEvent;
            }
            set
            {
                _lstFieldEvent = value;
            }
        }
        public static List<STFieldEventFunctionsInfo> LstFieldEventFunc
        {
            get
            {
                return _lstFieldEventFunc;
            }
            set
            {
                _lstFieldEventFunc = value;
            }
        }
        public static List<STFieldPermissionsInfo> LstFieldPermission
        {
            get
            {
                return _lstFieldPermission;
            }
            set
            {
                _lstFieldPermission = value;
            }
        }
        public static SortedList LstFieldColumnPermissions
        {
            get
            {
                return _lstFieldColumnPermissions;
            }
            set
            {
                _lstFieldColumnPermissions = value;
            }
        }
        public static List<AAColumnAliasInfo> LstColumnAlias
        {
            get
            {
                return _columnAliasList;
            }
            set
            {
                _columnAliasList = value;
            }
        }
        public static List<STFieldFormatGroupsInfo> FieldFormatList
        {
            get
            {
                return _fieldFormatList;
            }
            set
            {
                _fieldFormatList = value;
            }
        }
        /// <summary>
        /// Gets or sets the list of lookup table objects
        /// </summary>
        public static SortedList<string, GELookupTablesInfo> LookupTableObjects { get; set; }

        /// <summary>
        /// Gets or sets the the current language
        /// </summary>
        public static GELanguagesInfo CurrentLanguage { get; set; }

        /// <summary>
        /// Gets or sets all objects for accounting
        /// </summary>
        public static List<ACObjectsInfo> AccountingObjects { get; set; }
        #endregion

        #region Constant
        public const String cstTopResultsSearchControl = "fld_txtTopResults";
        public const int cstTopResults = 10000;

        #endregion

        #region Public Functions
        /// <summary>
        /// Init Main Form Title
        /// </summary>
        public static void InitMainFormTitle()
        {
            RegistryWorker regWoker = new RegistryWorker();
            regWoker.SubKey = "SOFTWARE\\BOS";
            String strCompanyName = regWoker.Read("CompanyName");
            BRBranchsController branchsController = new BRBranchsController();
            string mainText = string.Format("[BYSERP-{0} {1}] - {2}", BysGateway.CurrentVersion, BysGateway.EnvironmentVersion, ConfigurationManager.AppSettings["CompanyName"]);
            mainText += " - " + "Chi nh�nh : " + branchsController.GetObjectNameByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            mainText += " - " + DateTime.Now.ToShortDateString();
            mainText += " - " + CurrentUser;
            mainText += "/" + new ADUserGroupsController().GetObjectNameByID(new ADUsersController().GetUserGroupOfUser(CurrentUser));
            MainScreen.Text = mainText;
        }

        public static void InitLookupTables()
        {
            _lookupTables = new SortedList();
            _lookupTableUpdatedDate = new SortedList();
            //[NUThao] [Improve Speed] [2014-09-09]
            //_lookupTables.Clear();
            //_lookupTableUpdatedDate.Clear();
            LookupTableObjects = new SortedList<string, GELookupTablesInfo>();
            LookupTableList = new List<GELookupTablesInfo>();
            _gETables = new SortedList();
        }
        public static void InitSystemScreen()
        {
            STScreensController objSTScreensController = new STScreensController();
            LstScreen = new List<STScreensInfo>();
            DataSet dsScreens = objSTScreensController.GetAllScreens();
            if (dsScreens.Tables.Count > 0)
            {
                foreach (DataRow row in dsScreens.Tables[0].Rows)
                {
                    STScreensInfo objSTScreensInfo = (STScreensInfo)objSTScreensController.GetObjectFromDataRow(row);
                    if (objSTScreensInfo.STScreenVisible)
                    {
                        LstScreen.Add(objSTScreensInfo);
                    }
                }
            }
        }
        public static void InitSystemField()
        {
            STFieldsController objFieldsController = new STFieldsController();
            LstField = new List<STFieldsInfo>();
            DataSet dsFields = objFieldsController.GetFieldList(null, null, null, null, null, null, null, null, null);
            if (dsFields.Tables.Count > 0)
            {
                foreach (DataRow row in dsFields.Tables[0].Rows)
                {
                    STFieldsInfo objFieldsInfo = (STFieldsInfo)objFieldsController.GetObjectFromDataRow(row);
                    LstField.Add(objFieldsInfo);
                }
            }
            BOSDisposeUtility.DisposeDataSet(dsFields, 0, GCCollectionMode.Forced);
        }
        public static void InitSystemFieldColumns()
        {
            STFieldColumnsController objFieldColumnsController = new STFieldColumnsController();
            LstFieldColumn = new List<STFieldColumnsInfo>();
            DataSet dsFields = objFieldColumnsController.GetAllObjects();
            if (dsFields.Tables.Count > 0)
            {
                foreach (DataRow row in dsFields.Tables[0].Rows)
                {
                    STFieldColumnsInfo objFieldColumnsInfo = (STFieldColumnsInfo)objFieldColumnsController.GetObjectFromDataRow(row);
                    LstFieldColumn.Add(objFieldColumnsInfo);
                }
            }
            BOSDisposeUtility.DisposeDataSet(dsFields, 0, GCCollectionMode.Forced);
        }
        public static void InitSystemFieldEvent()
        {
            STFieldEventsController objFieldEventsController = new STFieldEventsController();
            LstFieldEvent = new List<STFieldEventsInfo>();
            LstFieldEvent = objFieldEventsController.GetFieldEventBySTFieldID(null);
        }
        public static void InitSystemFieldEventFunction()
        {
            STFieldEventFunctionsController objFieldEventFunctionsController = new STFieldEventFunctionsController();
            LstFieldEventFunc = new List<STFieldEventFunctionsInfo>();
            LstFieldEventFunc = objFieldEventFunctionsController.GetListAllObjects();
        }
        public static void InitSystemFieldEventFunctionParam()
        {
            STFieldEventFunctionParametersController objFieldEventFunctionParametersController = new STFieldEventFunctionParametersController();
            ListFieldEventFuncParam = new List<STFieldEventFunctionParametersInfo>();
            ListFieldEventFuncParam = objFieldEventFunctionParametersController.GetListAllObjects();
        }
        public static void InitSystemModuleDescription()
        {
            STModuleDescriptionsController objModuleDescriptionsController = new STModuleDescriptionsController();
            ModuleDescriptionList = new List<STModuleDescriptionsInfo>();
            ModuleDescriptionList = objModuleDescriptionsController.GetAllModuleDescriptionByModuleNameAndLanguageName(null, null);
        }
        public static void InitSystemToolbar()
        {
            STToolbarsController objToolbarsController = new STToolbarsController();
            ListToolbar = new List<STToolbarsInfo>();
            DataSet ds = objToolbarsController.GetAllSTToolbarsSortOrder();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    STToolbarsInfo objToolbarsInfo = (STToolbarsInfo)objToolbarsController.GetObjectFromDataRow(row);
                    ListToolbar.Add(objToolbarsInfo);
                }
            }
        }
        public static void InitSystemModule()
        {
            STModulesController objModulesController = new STModulesController();
            ModuleList = new List<STModulesInfo>();
            ModuleList = objModulesController.GetAllModuleList();
        }

        public static void InitSystemToolbarFunc()
        {
            STToolbarFunctionsController objToolbarFunctionsController = new STToolbarFunctionsController();
            ListToolbarFunc = new List<STToolbarFunctionsInfo>();
            DataSet ds = objToolbarFunctionsController.GetAllObjects();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    STToolbarFunctionsInfo objToolbarFunctionsInfo = (STToolbarFunctionsInfo)objToolbarFunctionsController.GetObjectFromDataRow(row);
                    ListToolbarFunc.Add(objToolbarFunctionsInfo);
                }
            }
        }
        public static void InitSystemToolbarFuncParam()
        {
            STToolbarFunctionParametersController objToolbarFunctionParametersController = new STToolbarFunctionParametersController();
            ListToolbarFuncParam = new List<STToolbarFunctionParametersInfo>();
            DataSet ds = objToolbarFunctionParametersController.GetAllObjects();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    STToolbarFunctionParametersInfo objToolbarFunctionParametersInfo = (STToolbarFunctionParametersInfo)objToolbarFunctionParametersController.GetObjectFromDataRow(row);
                    ListToolbarFuncParam.Add(objToolbarFunctionParametersInfo);
                }
            }
        }

        public static void InitSystemModuleFunc()
        {
            STModuleFunctionsController objModuleFunctionsController = new STModuleFunctionsController();
            ListModuleFunction = new List<STModuleFunctionsInfo>();
            DataSet ds = objModuleFunctionsController.GetAllObjects();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    STModuleFunctionsInfo objModuleFunctionsInfo = (STModuleFunctionsInfo)objModuleFunctionsController.GetObjectFromDataRow(row);
                    ListModuleFunction.Add(objModuleFunctionsInfo);
                }
            }
        }
        public static void InitSystemModuleFunctionParam()
        {
            STModuleFunctionParametersController objModuleFunctionParametersController = new STModuleFunctionParametersController();
            ListModuleFunctionParam = new List<STModuleFunctionParametersInfo>();
            DataSet ds = objModuleFunctionParametersController.GetAllObjects();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    STModuleFunctionParametersInfo objModuleFunctionParametersInfo = (STModuleFunctionParametersInfo)objModuleFunctionParametersController.GetObjectFromDataRow(row);
                    ListModuleFunctionParam.Add(objModuleFunctionParametersInfo);
                }
            }
        }
        public static void InitSystemModuleFunctionParamValue()
        {
            STModuleFunctionParameterValuesController objModuleFunctionParameterValuesController = new STModuleFunctionParameterValuesController();
            ListModuleFunctionParamValue = new List<STModuleFunctionParameterValuesInfo>();
            DataSet ds = objModuleFunctionParameterValuesController.GetAllObjects();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    STModuleFunctionParameterValuesInfo objModuleFunctionParameterValuesInfo = (STModuleFunctionParameterValuesInfo)objModuleFunctionParameterValuesController.GetObjectFromDataRow(row);
                    ListModuleFunctionParamValue.Add(objModuleFunctionParameterValuesInfo);
                }
            }
        }
        public static void InitSystemFieldPermission()
        {
            STFieldPermissionsController objFieldPermissionsController = new STFieldPermissionsController();
            LstFieldPermission = new List<STFieldPermissionsInfo>();
            LstFieldPermission = objFieldPermissionsController.GetFieldPermissionList(null, null, null, null, null);
        }
        /// <summary>
        /// Get all objects for accounting
        /// </summary>
        public static void InitAccountingObjects()
        {
            ACObjectsController objObjectsController = new ACObjectsController();
            AccountingObjects = objObjectsController.GetAllObjects();
        }

        /// <summary>
        /// Get data of a lookup table 
        /// </summary>
        /// <param name="lookupTableName">Lookup table name</param>
        /// <returns>Data of the lookup table</returns>
        public static DataSet GetLookupTableData(string lookupTableName)
        {
            IBusinessController objBusinessController = BusinessControllerFactory.GetBusinessController(lookupTableName + "Controller");
            DataSet ds = new DataSet();
            if (objBusinessController != null)
            {
                switch (lookupTableName)
                {
                    case TableName.ARCustomersTableName:
                        {
                            int ADUserID = BOSApp.CurrentUsersInfo == null ? 0 : BOSApp.CurrentUsersInfo.ADUserID;
                            ds = ((ARCustomersController)objBusinessController).GetAllCustomersForLookupControlByUser(ADUserID);
                            break;
                        }
                    case TableName.APSuppliersTableName:
                        {
                            APSuppliersController objSuppliersController = new APSuppliersController();
                            ds = ((APSuppliersController)objBusinessController).GetAllSuppliersForLookupControl();
                            break;
                        }
                    case TableName.ICStocksTableName:
                        {
                            int userGroupID = BOSApp.CurrentUsersInfo == null ? 0 : BOSApp.CurrentUsersInfo.ADUserGroupID;
                            ds = ((ICStocksController)objBusinessController).GetAllStocksForLookupControl(userGroupID);
                            break;
                        }
                    case TableName.ICProductsTableName:
                        {
                            int companyID = BOSApp.CurrentCompanyInfo.CSCompanyID;
                            ds = ((ICProductsController)objBusinessController).GetAllProductsForLookupControl(companyID);
                            break;
                        }
                    case TableName.ACAccountsTableName:
                        {
                            ACAccountsController objAccountsController = new ACAccountsController();
                            ds = objAccountsController.GetAllAccountSet();
                            break;
                        }
                    case TableName.HREmployeesTableName:
                        {
                            ds = ((HREmployeesController)objBusinessController).GetAllEmployeesForLookupControl();
                            break;
                        }
                    case TableName.ICProductSeriesTableName:
                        {
                            ds = ((ICProductSeriesController)objBusinessController).GetAllProductSeriesForLookupControl();
                            break;
                        }
                    case TableName.ARSaleOrdersTableName:
                        {
                            ds = ((ARSaleOrdersController)objBusinessController).GetAllSaleOrderForLookupControl();
                            break;
                        }
                    case TableName.ARSaleForecastsTableName:
                        {
                            ds = ((ARSaleForecastsController)objBusinessController).GetAllSaleForecastsForLookupControl();
                            break;
                        }
                    case TableName.ICShipmentProposalItemsTableName:
                        {
                            ds = ((ICShipmentProposalItemsController)objBusinessController).GetAllShipmentProposalItemForLookupControl();
                            break;
                        }
                    case TableName.MMProductionNormsTableName:
                        {
                            ds = ((MMProductionNormsController)objBusinessController).GetAllProductionNormForLookupControl();
                            break;
                        }
                    case TableName.APInvoiceInsTableName:
                        {
                            ds = ((APInvoiceInsController)objBusinessController).GetAllInvoiceInForLookupControl();
                            break;
                        }
                    case TableName.APPurchaseOrdersTableName:
                        {
                            ds = ((APPurchaseOrdersController)objBusinessController).GetAllPurchaseOrderForLookupControl();
                            break;
                        }
                    case TableName.ICShipmentProposalsTableName:
                        {
                            ds = ((ICShipmentProposalsController)objBusinessController).GetAllShipmentProposalsForLookupControl();
                            break;
                        }
                    case TableName.MMBatchProductsTableName:
                        {
                            ds = ((MMBatchProductsController)objBusinessController).GetBatchProductByBranchsForLookupControl(BOSApp.CurrentCompanyInfo == null ? 0 : BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                            break;
                        }
                    case TableName.APProposalsTableName:
                        {
                            ds = ((APProposalsController)objBusinessController).GetAllProposalsForLookupControl();
                            break;
                        }
                    case TableName.MMProposalsTableName:
                        {
                            ds = ((MMProposalsController)objBusinessController).GetAllMMProposalsForLookupControl();
                            break;
                        }
                    case TableName.MMAllocationPlansTableName:
                        {
                            ds = ((MMAllocationPlansController)objBusinessController).GetAllocationPlanByBranchsForLookupControl(BOSApp.CurrentCompanyInfo == null ? 0 : BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                            break;
                        }
                    case TableName.ARInvoicesTableName:
                        {
                            ds = ((ARInvoicesController)objBusinessController).GetAllARInvoicesForLookupControl();
                            break;
                        }
                    case TableName.MMAllocationPlanItemsTableName:
                        {
                            ds = ((MMAllocationPlanItemsController)objBusinessController).GetAllMMAllocationPlanItemsForLookupControl();
                            break;
                        }
                    case TableName.MMPurchasePlansTableName:
                        {
                            ds = ((MMPurchasePlansController)objBusinessController).GetAllMMPurchasePlansForLookupControl();
                            break;
                        }
                    case TableName.MMAllocationProposalsTableName:
                        {
                            ds = ((MMAllocationProposalsController)objBusinessController).GetAllMMAllocationProposalsForLookupControl();
                            break;
                        }
                    case TableName.ICShipmentsTableName:
                        {
                            ds = ((ICShipmentsController)objBusinessController).GetAllICShipmentsForLookupControl();
                            break;
                        }
                    case TableName.ICReceiptsTableName:
                        {
                            ds = ((ICReceiptsController)objBusinessController).GetAllReceiptsForLookupControl();
                            break;
                        }
                    case TableName.MMBatchProductItemsTableName:
                        {
                            ds = ((MMBatchProductItemsController)objBusinessController).GetAllMMBatchProductItemsForLookupControl();
                            break;
                        }
                    case TableName.ACDocumentsTableName:
                        {
                            ds = ((ACDocumentsController)objBusinessController).GetAllACDocumentsForLookupControl();
                            break;
                        }
                    case TableName.MMOperationDetailPlansTableName:
                        {
                            ds = ((MMOperationDetailPlansController)objBusinessController).GetAllMMOperationDetailPlansForLookupControl();
                            break;
                        }
                    case TableName.CSCashFundsTableName:
                        int branchID = BOSApp.CurrentCompanyInfo == null ? 0 : BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                        ds = ((CSCashFundsController)objBusinessController).GetDataSetCashFundsByBranchID(branchID);
                        break;

                    case TableName.STModulesTableName:
                        {
                            ds = ((STModulesController)objBusinessController).GetAllModules();
                            break;
                        }
                    case TableName.GEPaymentTermsTableName:
                        {
                            ds = ((GEPaymentTermsController)objBusinessController).GetAllPaymentTermIsActiveForLookupControl();
                            break;
                        }
                    case TableName.ACCostCentersTableName:
                        {
                            ds = ((ACCostCentersController)objBusinessController).GetAllAliveAndActive();
                            break;
                        }
                    case TableName.HRDepartmentRoomGroupItemsTableName:
                        {
                            ds = ((HRDepartmentRoomGroupItemsController)objBusinessController).GetCatcheData();
                            break;
                        }
                    case TableName.MMLinesTableName:
                        {
                            ds = ((MMLinesController)objBusinessController).GetCatcheData(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                            break;
                        }
                    case TableName.MMWorkShopsTableName:
                        {
                            ds = ((MMWorkShopsController)objBusinessController).GetCatcheDataByPermission(null, BOSApp.CurrentUsersInfo.ADUserID);
                            break;
                        }
                    case TableName.MMOperationsTableName:
                        {
                            ds = ((MMOperationsController)objBusinessController).GetDataSetOperationAndSortPeriod(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                            break;
                        }
                    case TableName.MMProcesssTableName:
                        {
                            ds = ((MMProcesssController)objBusinessController).GetAllProcessesForLookupControl(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                            break;
                        }
                    case TableName.ICProductattributesTableName:
                        {
                            ds = ((ICProductAttributesController)objBusinessController).GetCatcheData();
                            break;
                        }
                    case TableName.MMPaintProcessesTableName:
                        {
                            ds = ((MMPaintProcessessController)objBusinessController).GetCatcheData();
                            break;
                        }
                    case TableName.ARProductionPlanningsTableName:
                        {
                            ds = ((ARProductionPlanningsController)objBusinessController).GetCatcheData(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                            break;
                        }
                    case TableName.ICModelDetailsTableName:
                        {
                            ds = ((ICModelDetailsController)objBusinessController).GetCatcheData();
                            break;
                        }
                    case TableName.GECurrenyTableName:
                        {
                            ds = ((GECurrenciesController)objBusinessController).GetFormatCurrencys();
                            break;
                        }
                    case TableName.ICDepartmentFormatsTableName:
                        {
                            ds = ((ICDepartmentFormatsController)objBusinessController).GetDepartmentFormats();
                            break;
                        }
                    default:
                        {
                            ds = objBusinessController.GetAllObjects();
                            break;
                        }
                }
            }
            return ds;
        }
        public static DataSet GetLookupTableDataByBranch(string lookupTableName)
        {
            IBusinessController objBusinessController = BusinessControllerFactory.GetBusinessController(lookupTableName + "Controller");
            DataSet ds = new DataSet();
            if (objBusinessController != null)
            {
                switch (lookupTableName)
                {
                    case TableName.CSCashFundsTableName:
                        int branchID = BOSApp.CurrentCompanyInfo == null ? 0 : BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                        ds = ((CSCashFundsController)objBusinessController).GetDataSetCashFundsByBranchID(branchID);
                        break;
                    case TableName.MMLinesTableName:
                        {
                            ds = ((MMLinesController)objBusinessController).GetCatcheData(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                            break;
                        }
                    case TableName.MMWorkShopsTableName:
                        {
                            ds = ((MMWorkShopsController)objBusinessController).GetCatcheDataByPermission(null, BOSApp.CurrentUsersInfo.ADUserID);
                            break;
                        }
                    case TableName.MMOperationsTableName:
                        {
                            ds = ((MMOperationsController)objBusinessController).GetDataSetOperationAndSortPeriod(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                            break;
                        }
                    case TableName.MMProcesssTableName:
                        {
                            ds = ((MMProcesssController)objBusinessController).GetAllProcessesForLookupControl(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                            break;
                        }
                    case TableName.ARProductionPlanningsTableName:
                        {
                            ds = ((ARProductionPlanningsController)objBusinessController).GetCatcheData(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                            break;
                        }
                    case TableName.MMBatchProductsTableName:
                        {
                            ds = ((MMBatchProductsController)objBusinessController).GetBatchProductByBranchsForLookupControl(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                            break;
                        }
                    case TableName.MMAllocationPlansTableName:
                        {
                            ds = ((MMAllocationPlansController)objBusinessController).GetAllocationPlanByBranchsForLookupControl(BOSApp.CurrentCompanyInfo == null ? 0 : BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                            break;
                        }
                    default:
                        {
                            ds = null;
                            break;
                        }
                }
            }
            return ds;
        }
        /// <summary>
        /// Init additional customer data and add it to the existing data source
        /// </summary>
        /// <param name="lookupTable">Existing data source</param>
        private static void InitAdditionalCustomerData(DataTable lookupTable)
        {
            ARCustomersController objCustomersController = new ARCustomersController();
            for (int i = 0; i < lookupTable.Rows.Count; i++)
            {
                ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectFromDataRow(lookupTable.Rows[i]);
                ARCustomersInfo objCustomersInfo1 = (ARCustomersInfo)objCustomersInfo.Clone();
                objCustomersInfo1.ARCustomerName1 = string.Empty;
                objCustomersInfo1.ARCustomerName2 = string.Empty;
                objCustomersInfo1.ARCustomerName3 = string.Empty;
                if (!string.IsNullOrEmpty(objCustomersInfo.ARCustomerName1))
                {
                    DataRow addedRow = lookupTable.NewRow();
                    objCustomersInfo1.ARCustomerName = objCustomersInfo.ARCustomerName1;
                    objCustomersController.GetDataRowFromBusinessObject(addedRow, objCustomersInfo1);
                    lookupTable.Rows.InsertAt(addedRow, i + 1);
                }
                if (!string.IsNullOrEmpty(objCustomersInfo.ARCustomerName2))
                {
                    DataRow addedRow = lookupTable.NewRow();
                    objCustomersInfo1.ARCustomerName = objCustomersInfo.ARCustomerName2;
                    objCustomersController.GetDataRowFromBusinessObject(addedRow, objCustomersInfo1);
                    lookupTable.Rows.InsertAt(addedRow, i + 1);
                }
                if (!string.IsNullOrEmpty(objCustomersInfo.ARCustomerName3))
                {
                    DataRow addedRow = lookupTable.NewRow();
                    objCustomersInfo1.ARCustomerName = objCustomersInfo.ARCustomerName3;
                    objCustomersController.GetDataRowFromBusinessObject(addedRow, objCustomersInfo1);
                    lookupTable.Rows.InsertAt(addedRow, i + 1);
                }
            }
        }

        /// <summary>
        /// Init additional supplier data and add it to the existing data source
        /// </summary>
        /// <param name="lookupTable">Existing data source</param>
        private static void InitAdditionalSupplierData(DataTable lookupTable)
        {
            APSuppliersController objSuppliersController = new APSuppliersController();
            for (int i = 0; i < lookupTable.Rows.Count; i++)
            {
                APSuppliersInfo objSuppliersInfo = (APSuppliersInfo)objSuppliersController.GetObjectFromDataRow(lookupTable.Rows[i]);
                APSuppliersInfo objSuppliersInfo1 = (APSuppliersInfo)objSuppliersInfo.Clone();
                objSuppliersInfo1.APSupplierName1 = string.Empty;
                objSuppliersInfo1.APSupplierName2 = string.Empty;
                objSuppliersInfo1.APSupplierName3 = string.Empty;
                if (!string.IsNullOrEmpty(objSuppliersInfo.APSupplierName1))
                {
                    DataRow addedRow = lookupTable.NewRow();
                    objSuppliersInfo1.APSupplierName = objSuppliersInfo.APSupplierName1;
                    objSuppliersController.GetDataRowFromBusinessObject(addedRow, objSuppliersInfo1);
                    lookupTable.Rows.InsertAt(addedRow, i + 1);
                }
                if (!string.IsNullOrEmpty(objSuppliersInfo.APSupplierName2))
                {
                    DataRow addedRow = lookupTable.NewRow();
                    objSuppliersInfo1.APSupplierName = objSuppliersInfo.APSupplierName2;
                    objSuppliersController.GetDataRowFromBusinessObject(addedRow, objSuppliersInfo1);
                    lookupTable.Rows.InsertAt(addedRow, i + 1);
                }
                if (!string.IsNullOrEmpty(objSuppliersInfo.APSupplierName3))
                {
                    DataRow addedRow = lookupTable.NewRow();
                    objSuppliersInfo1.APSupplierName = objSuppliersInfo.APSupplierName3;
                    objSuppliersController.GetDataRowFromBusinessObject(addedRow, objSuppliersInfo1);
                    lookupTable.Rows.InsertAt(addedRow, i + 1);
                }
            }
        }

        /// <summary>
        /// Init additional stock data and add it to the existing data source
        /// </summary>
        /// <param name="lookupTable">Existing data source</param>
        private static void InitAdditionalStockData(DataTable lookupTable)
        {
            ICStocksController objStocksController = new ICStocksController();
            for (int i = 0; i < lookupTable.Rows.Count; i++)
            {
                ICStocksInfo objStocksInfo = (ICStocksInfo)objStocksController.GetObjectFromDataRow(lookupTable.Rows[i]);
                if (!(objStocksInfo.ICStockType == StockType.Central.ToString() || objStocksInfo.ICStockType == StockType.Sale.ToString()))
                {
                    lookupTable.Rows.RemoveAt(i);
                    i--;
                }
            }
        }

        public static void InitFormatGroups()
        {
            FieldFormatGroups = new SortedList();
            STFieldFormatGroupsController objFieldFormatGroupsController = new STFieldFormatGroupsController();
            DataSet ds = objFieldFormatGroupsController.GetAllObjects();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    STFieldFormatGroupsInfo objFieldFormatGroupsInfo = (STFieldFormatGroupsInfo)objFieldFormatGroupsController.GetObjectFromDataRow(row);
                    if (objFieldFormatGroupsInfo != null)
                    {
                        FieldFormatGroups.Add(objFieldFormatGroupsInfo.STFieldFormatGroupID, objFieldFormatGroupsInfo);
                    }
                }
            }
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
        }

        public static void InitFieldColumnPermissions()
        {
            LstFieldColumnPermissions = new SortedList();
            STFieldColumnPermissionsController objFieldColumnPermissionsController = new STFieldColumnPermissionsController();
            DataSet ds = objFieldColumnPermissionsController.GetAllObjects();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    STFieldColumnPermissionsInfo objFieldColumnPermissionsInfo = (STFieldColumnPermissionsInfo)objFieldColumnPermissionsController.GetObjectFromDataRow(row);
                    if (objFieldColumnPermissionsInfo != null)
                    {
                        LstFieldColumnPermissions.Add(objFieldColumnPermissionsInfo.STFieldColumnPermissionID, objFieldColumnPermissionsInfo);
                    }
                }
            }
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
        }
        public static void InitFieldFormatGroups()
        {
            STFieldFormatGroupsController objFieldFormatGroupsController = new STFieldFormatGroupsController();
            FieldFormatList = objFieldFormatGroupsController.GetFieldFormatGroupsByModuleID(null);
        }

        public static void DisableActionToolbarOfOpenModules(String strCurrentModuleName)
        {
            foreach (String strModuleName in OpenModules.Keys)
            {
                if (!strModuleName.Equals(strCurrentModuleName))
                {
                    BaseModuleERP module = (BaseModuleERP)OpenModules[strModuleName];
                    if (module.ParentScreen.ToolbarManager.Bars[BaseToolbar.ToolbarAction] != null)
                        module.ParentScreen.ToolbarManager.Bars[BaseToolbar.ToolbarAction].Visible = false;
                }
            }
        }

        public static void EnableActionToolbarOfOpenModules(String strCurrentModuleName)
        {
            foreach (String strModuleName in OpenModules.Keys)
            {
                if (!strModuleName.Equals(strCurrentModuleName))
                {
                    BaseModuleERP module = (BaseModuleERP)OpenModules[strModuleName];
                    if (module.ParentScreen.ToolbarManager.Bars[BaseToolbar.ToolbarAction] != null)
                        module.ParentScreen.ToolbarManager.Bars[BaseToolbar.ToolbarAction].Visible = true;
                }
            }
        }

        public static bool IsExistOpenModulesInAction()
        {
            foreach (String strModuleName in OpenModules.Keys)
            {
                BaseModuleERP module = (BaseModuleERP)OpenModules[strModuleName];
                if (!module.Toolbar.IsNullOrNoneAction())
                    return true;
            }
            return false;
        }


        #region Functions to Section Manager for Main Form
        public static void InitSectionManagerByCurrentUser(String strUserName)
        {
            //[NUThao] [Improve Speed] [2014-09-09]
            //ADUsersController objUserController = new ADUsersController();
            //int iUserGroupID = objUserController.GetUserGroupOfUser(strUserName);
            //ADUserGroupSectionsController objUserGroupSectionController = new ADUserGroupSectionsController();
            //DataSet dsUserGroupSections = objUserGroupSectionController.GetUserGroupSectionByUserGroupID(iUserGroupID);
            //if (dsUserGroupSections.Tables.Count > 0)
            //{
            //    foreach (DataRow row in dsUserGroupSections.Tables[0].Rows)
            //    {
            //        ADUserGroupSectionsInfo objADUserGroupSectionsInfo = (ADUserGroupSectionsInfo)objUserGroupSectionController.GetObjectFromDataRow(row);
            //        DevExpress.XtraNavBar.NavBarGroup fld_navbarGroupApp = new DevExpress.XtraNavBar.NavBarGroup();
            //        fld_navbarGroupApp.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        fld_navbarGroupApp.Appearance.Options.UseFont = true;
            //        fld_navbarGroupApp.Caption = objADUserGroupSectionsInfo.ADUserGroupSectionName;
            //        fld_navbarGroupApp.Expanded = true;
            //        fld_navbarGroupApp.Name = "fld_navBarGroup" + objADUserGroupSectionsInfo.ADUserGroupSectionID;
            //        AddModuleToGroupSection(fld_navbarGroupApp, objADUserGroupSectionsInfo.ADUserGroupSectionID);

            //        BOSApp.MainScreen.SectionManager.Groups.Add(fld_navbarGroupApp);
            //        BOSApp.MainScreen.SectionManager.ActiveGroup = BOSApp.MainScreen.SectionManager.Groups[0];
            //    }
            //}
            //dsUserGroupSections.Dispose();

            STModulesController moduleController = new STModulesController();
            List<STModulesInfo> modules = moduleController.GetAllModulesByUserNameAndLanguageName(strUserName, BOSApp.CurrentLang);

            if (modules != null)
            {
                //group modules to user group section
                Dictionary<string, List<STModulesInfo>> dictionary = new Dictionary<string, List<STModulesInfo>>();
                string key;
                foreach (STModulesInfo module in modules)
                {
                    key = module.ADUserGroupSectionID + "&&" + module.ADUserGroupSectionName;
                    if (!dictionary.ContainsKey(key))
                        dictionary.Add(key, new List<STModulesInfo>());
                    dictionary[key].Add(module);

                }

                //add modules to sections                
                foreach (string groupSection in dictionary.Keys)
                {
                    if (dictionary[groupSection] != null && dictionary[groupSection].Count != 0)
                    {
                        STModulesInfo firstItem = dictionary[groupSection][0];
                        DevExpress.XtraNavBar.NavBarGroup fld_navbarGroupApp = new DevExpress.XtraNavBar.NavBarGroup();
                        fld_navbarGroupApp.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        fld_navbarGroupApp.Appearance.Options.UseFont = true;
                        fld_navbarGroupApp.Caption = firstItem.ADUserGroupSectionName;
                        fld_navbarGroupApp.Expanded = true;
                        fld_navbarGroupApp.Name = "fld_navBarGroup" + firstItem.ADUserGroupSectionID;
                        AddModuleToGroupSection(fld_navbarGroupApp, dictionary[groupSection]);

                        BOSApp.MainScreen.SectionManager.Groups.Add(fld_navbarGroupApp);
                        BOSApp.MainScreen.SectionManager.ActiveGroup = BOSApp.MainScreen.SectionManager.Groups[0];
                    }
                }
            }
            //[NUThao] [Improve Speed] [2014-09-09]
        }

        //[NUThao] [Improve Speed] [2014-09-09]
        //public static void AddModuleToGroupSection(DevExpress.XtraNavBar.NavBarGroup fld_navBarGroupApp, int iUserGroupSectionID)
        //{
        //    STModuleToUserGroupSectionsController objModuleToUserGroupSectionController = new STModuleToUserGroupSectionsController();
        //    DataSet dsModules = objModuleToUserGroupSectionController.GetDisplayedModulesByUserGroupSectionID(iUserGroupSectionID);
        //    if (dsModules.Tables.Count > 0)
        //    {
        //        foreach (DataRow row in dsModules.Tables[0].Rows)
        //        {
        //            STModuleToUserGroupSectionsInfo objSTModuleToUserGroupSectionsInfo = (STModuleToUserGroupSectionsInfo)objModuleToUserGroupSectionController.GetObjectFromDataRow(row);

        //            STModulesController objModuleController = new STModulesController();
        //            STModulesInfo objModuleInfo = new STModulesInfo();
        //            objModuleInfo = (STModulesInfo)objModuleController.GetObjectByID(objSTModuleToUserGroupSectionsInfo.STModuleID);
        //            DevExpress.XtraNavBar.NavBarItem fld_navBarItemModule = new DevExpress.XtraNavBar.NavBarItem();
        //            fld_navBarItemModule.Caption = new STModuleDescriptionsController().GetDescriptionByModuleNameAndLanguageName(objModuleInfo.STModuleName, BOSApp.CurrentLang);
        //            fld_navBarItemModule.Name = "fld_navBar" + objModuleInfo.STModuleName;
        //            fld_navBarItemModule.SmallImageIndex = BOSApp.SectionImageList.Images.IndexOfKey(objModuleInfo.STModuleName);
        //            fld_navBarItemModule.Tag = objModuleInfo.STModuleName;
        //            fld_navBarItemModule.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(ModuleItem_LinkClicked);

        //            BOSApp.MainScreen.SectionManager.Items.Add(fld_navBarItemModule);
        //            fld_navBarGroupApp.ItemLinks.Add(new DevExpress.XtraNavBar.NavBarItemLink(fld_navBarItemModule));
        //        }
        //    }
        //    dsModules.Dispose();
        //}

        public static void AddModuleToGroupSection(DevExpress.XtraNavBar.NavBarGroup fld_navBarGroupApp, List<STModulesInfo> modules)
        {
            foreach (STModulesInfo module in modules)
            {
                DevExpress.XtraNavBar.NavBarItem fld_navBarItemModule = new DevExpress.XtraNavBar.NavBarItem();
                fld_navBarItemModule.Caption = module.STModuleDescription;
                fld_navBarItemModule.Name = "fld_navBar" + module.STModuleName;
                fld_navBarItemModule.SmallImageIndex = BOSApp.SectionImageList.Images.IndexOfKey(module.STModuleName);
                fld_navBarItemModule.Tag = module.STModuleName;
                fld_navBarItemModule.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(ModuleItem_LinkClicked);

                BOSApp.MainScreen.SectionManager.Items.Add(fld_navBarItemModule);
                fld_navBarGroupApp.ItemLinks.Add(new DevExpress.XtraNavBar.NavBarItemLink(fld_navBarItemModule));
            }
        }

        //[NUThao] [Improve Speed] [2014-09-09]

        private static void ModuleItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (e.Link.Item.Tag.ToString().StartsWith("BOS_") == true)
            {
                String ProgName = "C:\\BOS\\exe\\" + e.Link.Item.Tag.ToString().Substring(6) + ".exe";

                if (System.IO.File.Exists(ProgName) == true)
                    System.Diagnostics.Process.Start(ProgName, "1 2 BB_##TEST");
                else
                    MessageBox.Show("Programm : " + ProgName + " nicht gefunden");

                return;
            }
            ShowModule(e.Link.Item.Tag.ToString());
        }

        public static void SetActiveGroupByModule(String strModuleName)
        {
            DevExpress.XtraNavBar.NavBarItem moduleItem = BOSApp.MainScreen.SectionManager.Items["fld_navBar" + strModuleName];
            DevExpress.XtraNavBar.NavBarItemLink moduleItemLink = moduleItem.Links[0];
            BOSApp.MainScreen.SectionManager.ActiveGroup = moduleItemLink.Group;
            BOSApp.MainScreen.SectionManager.SelectedLink = moduleItemLink;
        }

        #endregion

        #region Treelist
        private static void InitRootTreeListManagerByCurrentUser(String strUserName)
        {
            BOSApp.MainScreen.TreeListSectionManager.StateImageList = BOSApp.SectionImageList;

            ADUsersController objUserController = new ADUsersController();
            int iUserGroupID = objUserController.GetUserGroupOfUser(strUserName);
            ADUserGroupSectionsController objUserGroupSectionController = new ADUserGroupSectionsController();
            DataSet dsUserGroupSections = objUserGroupSectionController.GetUserGroupSectionByUserGroupID(iUserGroupID);
            if (dsUserGroupSections.Tables.Count > 0)
            {
                foreach (DataRow row in dsUserGroupSections.Tables[0].Rows)
                {
                    ADUserGroupSectionsInfo objADUserGroupSectionsInfo = (ADUserGroupSectionsInfo)objUserGroupSectionController.GetObjectFromDataRow(row);
                    DevExpress.XtraTreeList.Nodes.TreeListNode treelstNode = BOSApp.MainScreen.TreeListSectionManager.AppendNode(new object[] { objADUserGroupSectionsInfo.ADUserGroupSectionName }, null);
                    treelstNode.HasChildren = true;
                    AddModuleToChildNode(treelstNode, objADUserGroupSectionsInfo.ADUserGroupSectionID);
                }
            }
            dsUserGroupSections.Dispose();

            BOSApp.MainScreen.TreeListSectionManager.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(TreeListSectionManager_NodeCellStyle);
            BOSApp.MainScreen.TreeListSectionManager.MouseClick += new MouseEventHandler(TreeListSectionManager_MouseClick);
            BOSApp.MainScreen.TreeListSectionManager.MouseMove += new MouseEventHandler(TreeListSectionManager_MouseMove);
            BOSApp.MainScreen.TreeListSectionManager.MouseLeave += new EventHandler(TreeListSectionManager_MouseLeave);

            BOSApp.MainScreen.TreeListSectionManager.ExpandAll();
        }

        private static void AddModuleToChildNode(DevExpress.XtraTreeList.Nodes.TreeListNode treelstParent, int iUserGroupSectionID)
        {
            STModuleToUserGroupSectionsController objModuleToUserGroupSectionController = new STModuleToUserGroupSectionsController();
            DataSet dsModules = objModuleToUserGroupSectionController.GetDisplayedModulesByUserGroupSectionID(iUserGroupSectionID);
            if (dsModules.Tables.Count > 0)
            {
                foreach (DataRow row in dsModules.Tables[0].Rows)
                {
                    STModuleToUserGroupSectionsInfo objSTModuleToUserGroupSectionsInfo = (STModuleToUserGroupSectionsInfo)objModuleToUserGroupSectionController.GetObjectFromDataRow(row);

                    STModulesController objModuleController = new STModulesController();
                    STModulesInfo objModuleInfo = new STModulesInfo();
                    objModuleInfo = ModuleList.Where(o => o.STModuleID == objSTModuleToUserGroupSectionsInfo.STModuleID).FirstOrDefault();
                    STModuleDescriptionsInfo objSTModuleDescriptionsInfo = BOSApp.ModuleDescriptionList.Where(d => d.STModuleName == objModuleInfo.STModuleName && d.GELanguageName == BOSApp.CurrentLang).FirstOrDefault();
                    String strCaption = string.Empty;
                    if (objSTModuleDescriptionsInfo != null)
                        strCaption = objSTModuleDescriptionsInfo.STModuleDescriptionDescription;
                    else
                        strCaption = new STModuleDescriptionsController().GetDescriptionByModuleNameAndLanguageName(objModuleInfo.STModuleName, BOSApp.CurrentLang);
                    DevExpress.XtraTreeList.Nodes.TreeListNode treelstNode = BOSApp.MainScreen.TreeListSectionManager.AppendNode(new object[] { strCaption }, treelstParent);
                    treelstNode.HasChildren = false;
                    treelstNode.Tag = objModuleInfo.STModuleName;
                    treelstNode.StateImageIndex = BOSApp.SectionImageList.Images.IndexOfKey(objModuleInfo.STModuleName);
                }
            }
            dsModules.Dispose();
        }

        public static void SetActiveModuleByModuleName(String strModuleName)
        {
            BOSApp.MainScreen.TreeListHotTrackID = -1;
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode treeParentNode in BOSApp.MainScreen.TreeListSectionManager.Nodes)
            {
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode treeItemNode in treeParentNode.Nodes)
                {
                    if (treeItemNode.Tag.Equals(strModuleName))
                    {
                        treeParentNode.ExpandAll();
                        BOSApp.MainScreen.TreeListSectionManager.SetFocusedNode(treeItemNode);
                        return;
                    }
                }
            }
            BOSApp.MainScreen.TreeListSectionManager.Refresh();
        }

        private static void TreeListSectionManager_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            if (e.Node.Tag != null && e.Node.Tag.ToString() == BOSApp.CurrentModule)
            {
                e.Appearance.Font = new Font(DevExpress.Utils.AppearanceObject.DefaultFont, FontStyle.Underline);
                e.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
                e.Appearance.BackColor = Color.Yellow;
                e.Appearance.BackColor2 = Color.Tomato;
                return;
            }

            if (e.Node.Id == BOSApp.MainScreen.TreeListHotTrackID)
            {
                e.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
                e.Appearance.BackColor = Color.Transparent;
                e.Appearance.BackColor2 = Color.Orange;
                return;
            }

            if (e.Node.HasChildren)
            {
                Font tempfont = new Font("Tahoma", (float)10, FontStyle.Bold);
                e.Appearance.Font = tempfont;
                e.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
                e.Appearance.BackColor = Color.Silver;
                e.Appearance.BackColor2 = Color.White;
                return;
            }
            else
            {
                e.Appearance.BackColor = Color.White;
                e.Appearance.BackColor2 = Color.White;
                return;
            }
        }

        private static void TreeListSectionManager_MouseClick(object sender, MouseEventArgs e)
        {
            TreeList treelst = (TreeList)sender;
            TreeListHitInfo treeHitInfo = treelst.CalcHitInfo(e.Location);
            if (treeHitInfo.Node != null)
            {
                if (treeHitInfo.Node.Tag != null)
                {
                    String strModuleName = treeHitInfo.Node.Tag.ToString();
                    if (!String.IsNullOrEmpty(strModuleName))
                    {
                        BOSApp.SetActiveModuleByModuleName(strModuleName);
                        ShowModule(strModuleName);
                    }
                }
            }
        }

        private static void TreeListSectionManager_MouseMove(object sender, MouseEventArgs e)
        {
            TreeList treelst = (TreeList)sender;
            TreeListHitInfo treeHitInfo = treelst.CalcHitInfo(e.Location);
            if (treeHitInfo.Node != null)
            {
                if (treeHitInfo.Node.Tag != null)
                {
                    BOSApp.MainScreen.TreeListHotTrackID = treeHitInfo.Node.Id;
                    BOSApp.MainScreen.TreeListSectionManager.Refresh();
                }

            }
        }

        private static void TreeListSectionManager_MouseLeave(object sender, EventArgs e)
        {
            BOSApp.MainScreen.TreeListHotTrackID = -1;
            BOSApp.MainScreen.TreeListSectionManager.Refresh();
        }
        #endregion

        #region Utility Functions
        public static void InitToolbarImageList()
        {
            try
            {
                ToolbarImageList.Images.Clear();
                ToolbarImageList.ImageSize = new Size(16, 16);
                String strToolbarImagePath = Application.StartupPath + "\\img\\Toolbar";
                DirectoryInfo dir = new DirectoryInfo(strToolbarImagePath);
                foreach (FileInfo file in dir.GetFiles())
                {
                    if (file.Extension.ToLower() == ".ico" || file.Extension.ToLower() == ".png" || file.Extension.ToLower() == ".jpg" || file.Extension.ToLower() == ".bmp")
                    {
                        int index = file.Name.IndexOf(".");
                        if (index > 0)
                        {
                            String strKey = file.Name.Substring(0, index);
                            Image img = Image.FromFile(file.FullName);
                            ToolbarImageList.Images.Add(strKey, img);
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        public static void InitSectionImageList()
        {
            try
            {
                SectionImageList.Images.Clear();
                SectionImageList.ImageSize = new Size(12, 12);
                String strSectionImagePath = Application.StartupPath + "\\img\\Section";
                DirectoryInfo dir = new DirectoryInfo(strSectionImagePath);
                foreach (FileInfo file in dir.GetFiles())
                {
                    if (file.Extension.ToLower() == ".ico" || file.Extension.ToLower() == ".png" || file.Extension.ToLower() == ".jpg" || file.Extension.ToLower() == ".bmp")
                    {
                        int index = file.Name.IndexOf(".");
                        if (index > 0)
                        {
                            String strKey = file.Name.Substring(0, index);
                            Image img = Image.FromFile(file.FullName);
                            SectionImageList.Images.Add(strKey, img);
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        public static void SetApplicationStyle(String strLookAndFeelStyle, String strLookAndFeelStyleSkin)
        {
            if (strLookAndFeelStyle == "Skin")
            {
                if (!String.IsNullOrEmpty(strLookAndFeelStyleSkin))
                    UserLookAndFeel.Default.SetSkinStyle(strLookAndFeelStyleSkin);
                else
                    UserLookAndFeel.Default.SetSkinStyle("Black");
            }
            else
            {
                LookAndFeelStyle style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
                try
                {
                    style = (LookAndFeelStyle)Enum.Parse(typeof(DevExpress.LookAndFeel.LookAndFeelStyle), strLookAndFeelStyle);
                }
                catch (Exception)
                {
                    style = LookAndFeelStyle.Office2003;
                }
                UserLookAndFeel.Default.SetStyle(style, false, true);
            }
        }

        public static void SaveUserStyle(string strLookAndFeelStyle, string strLookAndFeelStyleSkin)
        {
            if (BOSApp.CurrentUsersInfo != null && (BOSApp.CurrentUsersInfo.ADUserStyle != strLookAndFeelStyle || BOSApp.CurrentUsersInfo.ADUserStyleSkin != strLookAndFeelStyleSkin))
            {
                ADUsersController objUsersController = new ADUsersController();
                BOSApp.CurrentUsersInfo.ADUserStyle = strLookAndFeelStyle;
                BOSApp.CurrentUsersInfo.ADUserStyleSkin = strLookAndFeelStyleSkin;
                objUsersController.UpdateObject(BOSApp.CurrentUsersInfo);
            }
        }

        /// <summary>
        /// Init menu main form
        /// </summary>
        public static void InitMenuOfMainForm()
        {
            //Clear all existing items
            for (int i = 2; i < BOSApp.MainScreen.MainMenu.ItemLinks.Count - 2; i++)
            {
                BOSApp.MainScreen.MainMenu.ItemLinks.RemoveAt(i);
                i--;
            }

            //Add new items from database

            //[NUThao] [Improve Speed] [2014-09-09]
            //ADUsersController objUserController = new ADUsersController();
            //int iUserGroupID = objUserController.GetUserGroupOfUser(BOSApp.CurrentUser);
            //ADUserGroupSectionsController objUserGroupSectionController = new ADUserGroupSectionsController();
            //DataSet dsUserGroupSections = objUserGroupSectionController.GetUserGroupSectionByUserGroupID(iUserGroupID);
            //if (dsUserGroupSections.Tables.Count > 0)
            //{
            //    for (int i = 0; i < dsUserGroupSections.Tables[0].Rows.Count; i++)
            //    {
            //        ADUserGroupSectionsInfo objADUserGroupSectionsInfo = (ADUserGroupSectionsInfo)objUserGroupSectionController.GetObjectFromDataRow(dsUserGroupSections.Tables[0].Rows[i]);
            //        DevExpress.XtraBars.BarSubItem item = new DevExpress.XtraBars.BarSubItem();
            //        item.Caption = objADUserGroupSectionsInfo.ADUserGroupSectionName;
            //        BOSApp.MainScreen.MainMenu.InsertItem(BOSApp.MainScreen.MainMenu.ItemLinks[2 + i], item);
            //        item = AddSubMenuToMenuItem(item, objADUserGroupSectionsInfo.ADUserGroupSectionID);
            //    }
            //}

            STModulesController moduleController = new STModulesController();
            List<STModulesInfo> modules = moduleController.GetAllModulesByUserNameAndLanguageName(BOSApp.CurrentUser, BOSApp.CurrentLang);

            if (modules != null)
            {
                //group modules to user group section
                Dictionary<string, List<STModulesInfo>> dictionary = new Dictionary<string, List<STModulesInfo>>();
                string key;
                foreach (STModulesInfo module in modules)
                {
                    if (module.STModuleViewType != ModuleViewType.AllDevices && module.STModuleViewType != ModuleViewType.OnlyERP)
                        continue;

                    key = module.ADUserGroupSectionID + "&&" + module.ADUserGroupSectionName;
                    if (!dictionary.ContainsKey(key))
                        dictionary.Add(key, new List<STModulesInfo>());
                    dictionary[key].Add(module);

                }

                //add modules to sections              
                int imdex = 0;
                foreach (string groupSection in dictionary.Keys)
                {
                    if (dictionary[groupSection] != null && dictionary[groupSection].Count != 0)
                    {
                        STModulesInfo firstItem = dictionary[groupSection][0];

                        DevExpress.XtraBars.BarSubItem item = new DevExpress.XtraBars.BarSubItem();
                        item.Caption = firstItem.ADUserGroupSectionName;
                        BOSApp.MainScreen.MainMenu.InsertItem(BOSApp.MainScreen.MainMenu.ItemLinks[2 + imdex], item);
                        item = AddSubMenuToMenuItem(item, dictionary[groupSection]);
                        imdex++;

                    }
                }
            }

            //[NUThao] [Improve Speed] [2014-09-09]
        }

        /// <summary>
        /// Init sub menu to menu item
        /// </summary>
        //[NUThao] [Improve Speed] [2014-09-09]
        //public static DevExpress.XtraBars.BarSubItem AddSubMenuToMenuItem(DevExpress.XtraBars.BarSubItem menuItem, int userGroupSectionID)
        //{
        //    STModuleToUserGroupSectionsController objSTModuleToUserGroupSectionsController = new STModuleToUserGroupSectionsController();
        //    DataSet dsModuleUserGroupSections = objSTModuleToUserGroupSectionsController.GetDisplayedModulesByUserGroupSectionID(userGroupSectionID);
        //    if (dsModuleUserGroupSections != null)
        //    {
        //        foreach (DataRow row in dsModuleUserGroupSections.Tables[0].Rows)
        //        {
        //            STModuleToUserGroupSectionsInfo objSTModuleToUserGroupSectionsInfo = (STModuleToUserGroupSectionsInfo)objSTModuleToUserGroupSectionsController.GetObjectFromDataRow(row);
        //            if (objSTModuleToUserGroupSectionsInfo != null)
        //            {
        //                STModulesInfo objSTModulesInfo = (STModulesInfo)new STModulesController().GetObjectByID(objSTModuleToUserGroupSectionsInfo.STModuleID);
        //                STModuleDescriptionsController objModuleDescriptionsController = new STModuleDescriptionsController();
        //                STModuleDescriptionsInfo objModuleDescriptionsInfo = (STModuleDescriptionsInfo)objModuleDescriptionsController.GetModuleDescriptionByModuleNameAndLanguageName(objSTModulesInfo.STModuleName, BOSApp.CurrentLang);
        //                DevExpress.XtraBars.BarButtonItem subItem = new DevExpress.XtraBars.BarButtonItem();
        //                subItem.Caption = objModuleDescriptionsInfo.STModuleDescriptionDescription;
        //                subItem.Tag = objSTModulesInfo.STModuleID;
        //                subItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(subItem_ItemClick);
        //                menuItem.AddItem(subItem);
        //            }
        //        }
        //    }
        //    return menuItem;
        //}

        public static DevExpress.XtraBars.BarSubItem AddSubMenuToMenuItem(DevExpress.XtraBars.BarSubItem menuItem, List<STModulesInfo> modules)
        {
            if (modules != null)
            {
                foreach (STModulesInfo module in modules)
                {
                    DevExpress.XtraBars.BarButtonItem subItem = new DevExpress.XtraBars.BarButtonItem();
                    subItem.Caption = module.STModuleDescription;
                    subItem.Tag = module.STModuleID;
                    subItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(subItem_ItemClick);
                    menuItem.AddItem(subItem);
                }
            }
            return menuItem;
        }
        //[NUThao] [Improve Speed] [2014-09-09]

        /// <summary>
        /// Init toolbar of main form
        /// </summary>
        public static void InitToolbarOfMainForm()
        {
            BOSApp.MainScreen.Toolbar.ClearLinks();
            List<STToolbarsInfo> mainToolList = ListToolbar.Where(t => t.STModuleID == 0 && t.STUserGroupID == 0).OrderBy(t => t.STToolbarOrder).ToList();
            foreach (STToolbarsInfo objToolbarsInfo in mainToolList)
            {
                bool hasPermission = true;
                if (!string.IsNullOrEmpty(objToolbarsInfo.STToolbarTag) && objToolbarsInfo.STToolbarTag != ModuleName.Common)
                {
                    hasPermission = BOSApp.HasModuleAccessPermission(objToolbarsInfo.STToolbarTag);
                }
                if (hasPermission && objToolbarsInfo.STToolbarVisible == true)
                {
                    DevExpress.XtraBars.BarButtonItem toolbarItem = new DevExpress.XtraBars.BarButtonItem();
                    toolbarItem.Caption = objToolbarsInfo.STToolbarCaption;
                    toolbarItem.Name = objToolbarsInfo.STToolbarName;
                    toolbarItem.Tag = objToolbarsInfo.STToolbarID;
                    toolbarItem.LargeImageIndex = BOSApp.ToolbarImageList.Images.IndexOfKey(objToolbarsInfo.STToolbarImage);
                    toolbarItem.ImageIndex = BOSApp.ToolbarImageList.Images.IndexOfKey(objToolbarsInfo.STToolbarImage);
                    toolbarItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
                    toolbarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(toolbarItem_ItemClick);
                    BOSApp.MainScreen.Toolbar.AddItem(toolbarItem);
                }
            }
        }

        /// <summary>
        /// Show module when click submenu item.
        /// </summary>
        private static void subItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int moduleID = (int)e.Item.Tag;
            STModulesInfo objModuleInfo = ModuleList.Where(m => m.STModuleID == moduleID).FirstOrDefault();
            if (objModuleInfo != null && !String.IsNullOrEmpty(objModuleInfo.STModuleName))
            {
                BOSApp.SetActiveModuleByModuleName(objModuleInfo.STModuleName);
                ShowModule(objModuleInfo.STModuleName);
            }
        }

        /// <summary>
        /// Solve click event when user click on toolbar button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void toolbarItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            STToolbarsInfo objToolbarsInfo = ListToolbar.Where(t => t.STToolbarID == ((int)e.Item.Tag)).FirstOrDefault();
            if (objToolbarsInfo == null) return;
            STToolbarFunctionsInfo objToolbarFucntionsInfo = BOSApp.ListToolbarFunc.Where(f => f.STToolbarID == objToolbarsInfo.STToolbarID).FirstOrDefault();
            BaseModuleERP currModule = null;

            if (objToolbarsInfo.STToolbarTag == ModuleName.Common)
            {
                if (objToolbarsInfo.STToolbarName != "fld_barbtnRefreshControlData")
                {
                    BOSApp.SetActiveModuleByModuleName(objToolbarsInfo.STToolbarTag);
                    currModule = BaseModuleFactory.GetModule(ModuleName.Common);
                }
                else
                {
                    foreach (ToolStripButton tsbtnOpenedModule in BOSApp.MainScreen.OpenModulesToolStrip.Items)
                    {
                        if (tsbtnOpenedModule.Checked)
                        {
                            BOSApp.SetActiveModuleByModuleName(tsbtnOpenedModule.Name);
                            currModule = ShowModule(tsbtnOpenedModule.Name);
                            break;
                        }
                    }
                    if (currModule == null)
                        return;
                }
            }
            else
            {
                BOSApp.SetActiveModuleByModuleName(objToolbarsInfo.STToolbarTag);
                currModule = ShowModule(objToolbarsInfo.STToolbarTag);
            }

            if (objToolbarFucntionsInfo != null)
            {
                MethodInfo methodInfo = currModule.GetMethodInfoByMethodFullNameAndMethodClass(objToolbarFucntionsInfo.STToolbarFunctionName, objToolbarFucntionsInfo.STToolbarFunctionFullName, objToolbarFucntionsInfo.STToolbarFunctionClass);
                if (methodInfo != null)
                    methodInfo.Invoke(currModule, null);
            }
        }
        #endregion

        public static void LogOn()
        {
            guiLogin _guiLogin = new guiLogin();
            _guiLogin.ShowDialog();
            if (!_guiLogin.IsDisposed)
                return;

            InitCommonData(_guiLogin.BRBranchID);
        }

        public static void InitCommonData(int branchID)
        {
            ADUsersController objUsersController = new ADUsersController();
            ADUsersInfo objUsersInfo = (ADUsersInfo)objUsersController.GetObjectByName(BOSApp.CurrentUser);
            if (objUsersInfo != null)
                BOSApp.SetApplicationStyle(objUsersInfo.ADUserStyle, objUsersInfo.ADUserStyleSkin);
            //Get current user
            BOSApp.CurrentUsersInfo = objUsersInfo;
            BOSLib.BysGateway.CurrentUsersInfo = CurrentUsersInfo;
            //Get current company info
            //
            CSCompanysController objCSCompanysController = new CSCompanysController();

            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            GECurrenciesInfo objCurrenciesInfo = objCurrenciesController.GetDefaultCurrency();
            GELookupTablesController lookupTableController = new GELookupTablesController();
            BOSProgressBar.Start(BaseLocalizedResources.InitDataMessage);
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSApp.MainScreen.ServerDate = dbUtil.GetCurrentServerDate();
            BOSLib.BysGateway.ServerLoginDate = BOSApp.MainScreen.ServerDate;
            BOSLib.BysGateway.LocalLoginDate = DateTime.Now;
            BOSApp.MainScreen.syncServerTimer.Interval = 1000;
            BOSApp.MainScreen.tickTimer = 0;
            BOSApp.MainScreen.syncServerTimer.Start();
            InitSystemScreen();
            InitSystemField();
            InitSystemFieldColumns();
            InitSystemFieldPermission();
            InitFieldColumnPermissions();
            InitSystemFieldEvent();
            InitSystemFieldEventFunction();
            InitSystemModule();
            InitSystemModuleDescription();
            InitSystemToolbar();
            InitSystemToolbarFunc();
            InitSystemToolbarFuncParam();
            InitFormatGroups();
            InitFieldFormatGroups();
            InitSystemAliasTable();
            InitSystemModuleFunc();
            InitSystemModuleFunctionParam();
            InitSystemModuleFunctionParamValue();
            if (string.IsNullOrEmpty(ConfigurationManager.AppSettings["CSCompanyID"]))
            {
                CSCompanysInfo companysInfo = (CSCompanysInfo)objCSCompanysController.GetFirstObject();
                if (objCurrenciesInfo != null)
                {
                    if (companysInfo != null)
                    {
                        companysInfo.FK_GECurrencyID = objCurrenciesInfo.GECurrencyID;
                    }
                }
                _currentCompanyInfo = companysInfo;
                _currentCompanyInfo.FK_BRBranchID = branchID;

            }
            else
            {
                CSCompanysInfo companysInfo = (CSCompanysInfo)objCSCompanysController.GetObjectByID(int.Parse(ConfigurationManager.AppSettings["CSCompanyID"]));
                if (objCurrenciesInfo != null)
                {
                    if (companysInfo != null)
                    {
                        companysInfo.FK_GECurrencyID = objCurrenciesInfo.GECurrencyID;
                    }
                }
                _currentCompanyInfo = companysInfo;
                _currentCompanyInfo.FK_BRBranchID = branchID;
            }
            if (_currentCompanyInfo == null)
            {
                CSCompanysInfo companysInfo = new CSCompanysInfo();
                if (objCurrenciesInfo != null)
                {
                    if (companysInfo != null)
                    {
                        companysInfo.FK_GECurrencyID = objCurrenciesInfo.GECurrencyID;
                    }
                }
                _currentCompanyInfo = companysInfo;
                _currentCompanyInfo.FK_BRBranchID = branchID;
            }
            UpdateRealTimeExchageRate();
            //Init toolbar manager
            InitToolbarImageList();
            InitSectionImageList();
            MainScreen.BarManager.Images = ToolbarImageList;
            MainScreen.BarManager.LargeImages = ToolbarImageList;

            //InitRootTreeListManagerByCurrentUser(BOSApp.CurrentUser);
            InitSectionManagerByCurrentUser(BOSApp.CurrentUser);

            ADConfigValueUtility.InitGlobalConfigValueTables();
            InitMainFormTitle();
            InitLookupTables();
            InitAccountingObjects();

            _currentUserGroupID = new ADUsersController().GetUserGroupOfUser(BOSApp.CurrentUser);
            _currentUserGroupsInfo = (ADUserGroupsInfo)new ADUserGroupsController().GetObjectByID(_currentUserGroupID);

            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            //_currentDataViewPermissionsInfo
            ADDataViewPermissionsController objDataViewPermissionsController = new ADDataViewPermissionsController();
            _currentDataViewPermissionList = objDataViewPermissionsController.GetDataViewPermissionsByUserID(BOSApp.CurrentUsersInfo.ADUserID);
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
            DataSet dsLookup = lookupTableController.GetAllObjects();
            if (dsLookup.Tables[0].Rows.Count > 0)
            {
                if (LookupTableList == null)
                    LookupTableList = new List<GELookupTablesInfo>();
                foreach (DataRow row in dsLookup.Tables[0].Rows)
                {
                    GELookupTablesInfo objLookupTablesInfo = (GELookupTablesInfo)lookupTableController.GetObjectFromDataRow(row);
                    LookupTableList.Add(objLookupTablesInfo);
                }
            }
            dsLookup.Dispose();
            ICProductsController objProductsController = new ICProductsController();
            DataSet ds = null;
            if (!LookupTables.ContainsKey(TableName.ICProductsTableName))
            {
                ds = GetLookupTableData(TableName.ICProductsTableName);
                GELookupTablesInfo lookupTable = LookupTableList.Where(t => t.GELookupTableName == TableName.ICProductsTableName).FirstOrDefault();

                if (lookupTable != null)
                {
                    LookupTables.Add(TableName.ICProductsTableName, ds);
                    LookupTablesUpdatedDate.Add(TableName.ICProductsTableName, BOSApp.MainScreen.ServerDate.AddSeconds(BOSApp.MainScreen.tickTimer));
                    LookupTableObjects.Add(TableName.ICProductsTableName, lookupTable);
                }
            }
            else
                ds = LookupTables[TableName.ICProductsTableName] as DataSet;

            if (ds != null)
            {
                _currentProductList = objProductsController.GetListViewFromDataSet(ds);
            }
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
            DataSet measureUnit = BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] as DataSet;
            if (measureUnit == null)
            {
                measureUnit = BOSApp.GetLookupTableData(TableName.ICMeasureUnitsTableName);
                if (BOSApp.LookupTables.ContainsKey(TableName.ICMeasureUnitsTableName))
                    BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] = measureUnit;
                BOSApp.LookupTables.Add(TableName.ICMeasureUnitsTableName, measureUnit);
            }
            BOSDisposeUtility.DisposeDataSet(measureUnit, 0, GCCollectionMode.Forced);

            // init data to format by ProductType
            DataSet departmentFormat = BOSApp.LookupTables[TableName.ICDepartmentFormatsTableName] as DataSet;
            if (departmentFormat == null)
            {
                departmentFormat = BOSApp.GetLookupTableData(TableName.ICDepartmentFormatsTableName);
                if (BOSApp.LookupTables.ContainsKey(TableName.ICDepartmentFormatsTableName))
                    BOSApp.LookupTables[TableName.ICDepartmentFormatsTableName] = departmentFormat;
                else
                    BOSApp.LookupTables.Add(TableName.ICDepartmentFormatsTableName, departmentFormat);
            }

            //Init status bar items
            BOSApp.MainScreen.userItem.Caption = BOSApp.CurrentUserGroupInfo.ADUserGroupName + "\\" + BOSApp.CurrentUser;
            BOSApp.MainScreen.dateItem.Caption = DateTime.Now.ToShortDateString();
            //Init bars of main form
            InitMenuOfMainForm();
            InitToolbarOfMainForm();
            BOSProgressBar.Close();
            //Show home page 
            if (BOSApp.HasModuleAccessPermission(ModuleName.Home))
            {
                BOSApp.ShowModule(ModuleName.Home);
            }
            string value = ADConfigValueUtility.GetFirstConfigValueByGroup("UsingCarCass");
            UsingCarCass = bool.Parse(string.IsNullOrEmpty(value) ? "false" : value);
            value = ADConfigValueUtility.GetFirstConfigValueByGroup("IsUsedCheckProductCode");
            IsUsedCheckProductCode = bool.Parse(string.IsNullOrEmpty(value) ? "false" : value);
            ModulesListApplyValidateSerial = new List<string>() { ModuleName.SaleOrder, ModuleName.DeliveryPlan, ModuleName.Invoice, ModuleName.Shipment, "BatchShipmentDryLumber" };
            WoodTypesList = new List<string>() { "Roundwood", "FreshLumber", "DryLumber", "Verneer", "ArtificialBoard", "Lumber", "Reuse", "Material", "Ingredient" };
        }

        public static void InitSystemAliasTable()
        {
            AAColumnAliasController objColumnAliasController = new AAColumnAliasController();
            LstColumnAlias = new List<AAColumnAliasInfo>();
            DataSet ds = objColumnAliasController.GetColumnAliasCollection(null);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    AAColumnAliasInfo objColumnAliasInfo = (AAColumnAliasInfo)objColumnAliasController.GetObjectFromDataRow(row);
                    LstColumnAlias.Add(objColumnAliasInfo);
                }
            }
        }

        public static GECurrenciesInfo RealTimeExchageRateByCurrency(int currencyID)
        {
            try
            {
                GECurrenciesController objCurrenciesController = new GECurrenciesController();
                GECurrenciesInfo currencyExrate = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(currencyID);
                if (currencyExrate == null) return null;
                if (currencyExrate.GECurrencyNo == "VND")
                {
                    currencyExrate.BuyExchangeRate = 1;
                    currencyExrate.TransferExchangeRate = 1;
                    currencyExrate.SellExchangeRate = 1;

                    return currencyExrate;
                }
                XmlDocument xml = new XmlDocument();
                xml.Load("http://www.vietcombank.com.vn/exchangerates/ExrateXML.aspx");

                XmlNodeList noXml;
                noXml = xml.SelectNodes("/ExrateList/Exrate");
                int i = 0;
                for (i = 0; i <= noXml.Count - 1; i++)
                {
                    string currencyCode = currencyExrate.GECurrencyNo;


                    if (currencyCode == noXml.Item(i).Attributes["CurrencyCode"].InnerText)
                    {
                        decimal Buy = 0;
                        decimal Transfer = 0;
                        decimal Sell = 0;
                        decimal.TryParse(noXml.Item(i).Attributes["Buy"].InnerText, out Buy);
                        decimal.TryParse(noXml.Item(i).Attributes["Transfer"].InnerText, out Transfer);
                        decimal.TryParse(noXml.Item(i).Attributes["Sell"].InnerText, out Sell);

                        currencyExrate.BuyExchangeRate = Buy;
                        currencyExrate.TransferExchangeRate = Transfer;
                        currencyExrate.SellExchangeRate = Sell;

                        return currencyExrate;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// Check whether the current user has access permission to a module
        /// </summary>
        /// <param name="moduleName">Module name</param>
        /// <returns>True if can access, otherwise false</returns>
        public static bool HasModuleAccessPermission(string moduleName)
        {
            STModuleToUserGroupSectionsController objModuleToUserGroupSectionsController = new STModuleToUserGroupSectionsController();
            STModuleToUserGroupSectionsInfo objModuleToUserGroupSectionsInfo = objModuleToUserGroupSectionsController.GetModuleToUserGroupSectionByModuleNameAndUserGroupID(
                                                                                                moduleName,
                                                                                                BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            if (objModuleToUserGroupSectionsInfo != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Log off BOS
        /// </summary>
        public static void LogOff()
        {
            //Clear section manager and enable if current section manager is not enable
            BOSApp.MainScreen.SectionManager.Groups.Clear();
            BOSApp.MainScreen.SectionManager.Enabled = true;

            //Close all open modules,clear all in Open Module list and tool strip .Enable Open module tool strip
            CloseAllOpenModules();
            OpenModules.Clear();
            BOSApp.MainScreen.OpenModulesToolStrip.Items.Clear();
            BOSApp.MainScreen.OpenModulesToolStrip.Enabled = true;

            MainScreen.Text = string.Format("[{0} {1}]-{2}", BysGateway.CurrentVersion, BysGateway.EnvironmentVersion, ConfigurationManager.AppSettings["CompanyName"]);
            DisposeAllCatched();
            GC.Collect(0, GCCollectionMode.Forced);
            //Log on again
            LogOn();
        }
        public static void DisposeAllCatched()
        {
            BOSDisposeUtility.DisposeAll(CurrentProductList, 0, GCCollectionMode.Forced);
            BOSDisposeUtility.DisposeAll(LookupTableList, 0, GCCollectionMode.Forced);
            BOSDisposeUtility.DisposeAll(LstScreen, 0, GCCollectionMode.Forced);
            BOSDisposeUtility.DisposeAll(LstField, 0, GCCollectionMode.Forced);
            BOSDisposeUtility.DisposeAll(LstFieldColumn, 0, GCCollectionMode.Forced);
            BOSDisposeUtility.DisposeAll(LstFieldEvent, 0, GCCollectionMode.Forced);
            BOSDisposeUtility.DisposeAll(LstFieldEventFunc, 0, GCCollectionMode.Forced);
            BOSDisposeUtility.DisposeAll(LstFieldPermission, 0, GCCollectionMode.Forced);
            BOSDisposeUtility.DisposeAll(LstFieldColumnPermissions, 0, GCCollectionMode.Forced);
            BOSDisposeUtility.DisposeAll(LstColumnAlias, 0, GCCollectionMode.Forced);
            BOSDisposeUtility.DisposeAll(FieldFormatList, 0, GCCollectionMode.Forced);
            OpenModules.Clear();
            foreach (string item in LookupTables.Keys)
            {
                if (LookupTables.ContainsKey(item) && (DataSet)LookupTables[item] != null)
                {
                    ((DataSet)LookupTables[item]).Clear();
                    ((DataSet)LookupTables[item]).Dispose();
                }
            }
        }
        /// <summary>
        /// Show Module with module Name
        /// </summary>
        /// <param name="strModuleName">Module Name</param>
        public static BaseModuleERP ShowModule(String strModuleName)
        {
            BaseModuleERP currModule = null;
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                //Show new module                   
                //If module will be show is in Opened Module List, get this module and show
                if (BOSApp.IsOpenedModule(strModuleName))
                {
                    currModule = ((BaseModuleERP)BOSApp.OpenModules[strModuleName]);
                    ShowOpenedModule(strModuleName);
                }
                //if module is not in Opened Module List, create new instance and show
                else
                {
                    currModule = BaseModuleFactory.GetModule(strModuleName);
                    if (currModule != null)
                        ShowNewModule(currModule);
                }

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                return null;
            }
            return currModule;
        }

        /// <summary>
        /// Show module have already exist on Opend Modules List
        /// </summary>
        /// <param name="strModuleName"></param>
        public static void ShowOpenedModule(String strModuleName)
        {
            ToolStripButton tsbtnModule = (ToolStripButton)BOSApp.MainScreen.OpenModulesToolStrip.Items[strModuleName];
            CheckOpenModuleToolStripButton(tsbtnModule);
            BaseModuleERP module = (BaseModuleERP)BOSApp.OpenModules[strModuleName];
            module.ParentScreen.Activate();
        }
        /// <summary>
        /// Show new module
        /// </summary>
        /// <param name="module"></param>
        public static void ShowNewModule(BaseModuleERP module)
        {
            BOSApp.UpdateOpenedModule(module);
            AddOpenModuleToOpenModulesToolStrip(module.Name);
            module.Show();
        }

        /// <summary>
        /// Populate ToolStrip Button for open module
        /// </summary>
        /// <param name="strModuleName">Name of Module will be populated to toolstrip button</param>
        /// <returns></returns>
        private static ToolStripButton PopulateOpenModulesToolStripButton(String strModuleName)
        {
            STModuleDescriptionsInfo objSTModuleDescriptionsInfo = BOSApp.ModuleDescriptionList.Where(d => d.STModuleName == strModuleName && d.GELanguageName == BOSApp.CurrentLang).FirstOrDefault();
            String strModuleDesc = string.Empty;
            if (objSTModuleDescriptionsInfo != null)
                strModuleDesc = objSTModuleDescriptionsInfo.STModuleDescriptionDescription;
            else
                strModuleDesc = new STModuleDescriptionsController().GetDescriptionByModuleNameAndLanguageName(strModuleName, BOSApp.CurrentLang);
            if (String.IsNullOrEmpty(strModuleDesc))
                strModuleDesc = strModuleName;

            ToolStripButton tsbtnOpenModules = new ToolStripButton(strModuleDesc, BOSApp.SectionImageList.Images[strModuleName], OpenModulesToolStrip_Click, strModuleName);
            tsbtnOpenModules.TextImageRelation = TextImageRelation.ImageBeforeText;
            tsbtnOpenModules.CheckOnClick = true;
            return tsbtnOpenModules;
        }



        /// <summary>
        /// Set toolstripbutton of Open Module to checked
        /// </summary>
        /// <param name="tsbtnModule"></param>
        public static void CheckOpenModuleToolStripButton(ToolStripButton tsbtnModule)
        {
            tsbtnModule.Checked = true;
            foreach (ToolStripButton tsbtnOpenedModule in BOSApp.MainScreen.OpenModulesToolStrip.Items)
            {
                if (tsbtnOpenedModule.Name != tsbtnModule.Name)
                    tsbtnOpenedModule.Checked = false;
            }
        }


        /// <summary>
        /// Delegate function for event click of Toolstrip Button Open Module
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">Event Arugment</param>
        private static void OpenModulesToolStrip_Click(object sender, EventArgs e)
        {
            ToolStripButton tsbtnModule = (ToolStripButton)sender;
            CheckOpenModuleToolStripButton(tsbtnModule);
            ShowModule(tsbtnModule.Name);
            //SetActiveGroupByModule(tsbtnModule.Name);
        }


        /// <summary>
        /// Add open module to Open Modules Tool Strip
        /// </summary>
        /// <param name="strModuleName">Name of module will be added</param>
        public static void AddOpenModuleToOpenModulesToolStrip(String strModuleName)
        {
            ToolStripButton tsbtnModule = PopulateOpenModulesToolStripButton(strModuleName);
            BOSApp.MainScreen.OpenModulesToolStrip.Items.Add(tsbtnModule);
            tsbtnModule.Visible = true;
            CheckOpenModuleToolStripButton(tsbtnModule);
        }


        /// <summary>
        /// Check the module is opened before or not
        /// </summary>
        /// <param name="strModuleName">Name of module is checked</param>
        /// <returns>true if is opened before, otherwise return false</returns>
        public static bool IsOpenedModule(String strModuleName)
        {
            return OpenModules.ContainsKey(strModuleName);
        }

        /// <summary>
        /// Add new or update module into Opened Module list
        /// </summary>
        /// <param name="module">module will be added new or updated</param>
        public static void UpdateOpenedModule(BaseModuleERP module)
        {
            if (!IsOpenedModule(module.Name))
            {
                OpenModules.Add(module.Name, module);
            }
            else
                OpenModules[module.Name] = module;
        }

        /// <summary>
        /// Remove module from Opened Module list
        /// </summary>
        /// <param name="module">Module will be removed</param>
        public static void RemoveOpenedModule(BaseModuleERP module)
        {
            if (IsOpenedModule(module.Name))
            {
                ((BaseModuleERP)OpenModules[module.Name]).Close();
                OpenModules.Remove(module.Name);
            }
        }

        /// <summary>
        /// Remove module from Opened module list
        /// </summary>
        /// <param name="strModuleName">Module name will be removed</param>
        public static void RemoveOpenedModule(String strModuleName)
        {
            if (IsOpenedModule(strModuleName))
            {
                //BaseModuleERP module = (BaseModuleERP)OpenModules[strModuleName];
                //module = null;
                OpenModules.Remove(strModuleName);
                //GC.Collect();
            }
        }


        public static void CloseAllOpenModules()
        {
            for (int i = 0; i < OpenModules.Count; i++)
            {
                BaseModuleERP module = (BaseModuleERP)OpenModules.GetByIndex(i);
                module.ParentScreen.Close();
                i--;
            }
        }

        #endregion

        #region FTP Server
        /// <summary>
        /// Upload file to Server
        /// </summary>
        /// <param name="filePath">full local path of file will be upload</param>
        /// <param name="subFolder">the folder name on server that will contain the file</param>
        public static bool UploadFileFTP(string objectID, string filePath, string subFolder)
        {
            bool flag = false;
            try
            {
                System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string ftp_host = configuration.AppSettings.Settings["FTP_Host"].Value.ToString();
                string ftp_homedir = configuration.AppSettings.Settings["FTP_HomeDir"].Value.ToString();
                string ftp_username = configuration.AppSettings.Settings["FTP_Username"].Value.ToString();
                string ftp_password = configuration.AppSettings.Settings["FTP_Password"].Value.ToString();

                FileInfo fileInfo = new FileInfo(filePath);
                WebRequest requestFTP;
                string fileName = string.Empty;
                fileName += objectID + "_" + fileInfo.Name.ToString();

                if (!String.IsNullOrEmpty(ftp_homedir))
                {
                    //Create home dir if not exists
                    if (CreateFTPDirectory("ftp://" + ftp_host + "/" + ftp_homedir, ftp_username, ftp_password) == false)
                    {
                        return false;
                    }

                    subFolder = ftp_homedir + "/" + subFolder;
                }

                //Create sub folder if not exists
                if (!String.IsNullOrEmpty(subFolder))
                {
                    if (CreateFTPDirectory("ftp://" + ftp_host + "/" + subFolder, ftp_username, ftp_password) == false)
                    {
                        return false;
                    }
                }

                if (String.IsNullOrEmpty(subFolder))
                {
                    requestFTP = WebRequest.Create("ftp://" + ftp_host + "/" + fileName);
                }
                else
                {
                    requestFTP = WebRequest.Create("ftp://" + ftp_host + "/" + subFolder + "/" + fileName);
                }

                requestFTP.Credentials = new NetworkCredential(ftp_username, ftp_password);
                requestFTP.Method = WebRequestMethods.Ftp.UploadFile;
                FileStream fStream = fileInfo.OpenRead();
                int bufferLength = 2048;
                byte[] buffer = new byte[bufferLength];

                Stream uploadStream = null;
                try
                {
                    uploadStream = requestFTP.GetRequestStream();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }

                int contentLength = fStream.Read(buffer, 0, bufferLength);

                while (contentLength != 0)
                {
                    uploadStream.Write(buffer, 0, contentLength);
                    contentLength = fStream.Read(buffer, 0, bufferLength);
                }
                uploadStream.Close();
                fStream.Close();
                requestFTP = null;
                flag = true;
            }
            catch (Exception ep)
            {
                MessageBox.Show("ERROR: " + ep.Message.ToString());

            }
            return flag;
        }

        public static bool UploadFileFTPImage(string filePath, string subFolderName, string fileName)
        {
            bool flag = false;
            try
            {
                ADDirectoryPathConfigsController pathCtrl = new ADDirectoryPathConfigsController();
                ADDirectoryPathConfigsInfo pathInfo = pathCtrl.GetInfoByImageFolderType(ImageFolderType.TechnicalDrawing.ToString());

                string ftp_path = string.Empty;
                string ftp_username = string.Empty;
                string ftp_password = string.Empty;
                if (pathInfo != null)
                {
                    ftp_path = pathInfo.ADDirectoryPathConfigAddress;
                    ftp_username = pathInfo.ADDirectoryPathConfigUserName;
                    ftp_password = pathInfo.ADDirectoryPathConfigPassword;
                }

                System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //string ftp_host = configuration.AppSettings.Settings["FTP_Host"].Value.ToString();
                //string ftp_homedir = configuration.AppSettings.Settings["FTP_HomeDir"].Value.ToString();
                //string ftp_username = configuration.AppSettings.Settings["FTP_Username"].Value.ToString();
                //string ftp_password = configuration.AppSettings.Settings["FTP_Password"].Value.ToString();

                FileInfo fileInfo = new FileInfo(filePath);
                WebRequest requestFTP;

                if (!String.IsNullOrEmpty(ftp_path))
                {
                    //Create home dir if not exists
                    if (CreateFTPDirectory(ftp_path, ftp_username, ftp_password) == false)
                    {
                        return false;
                    }

                    //subFolderName = ftp_homedir + "/" + subFolderName;
                }

                //Create sub folder if not exists
                if (CreateFTPDirectory(ftp_path + "/" + subFolderName, ftp_username, ftp_password) == false)
                {
                    return false;
                }

                requestFTP = WebRequest.Create(ftp_path + "/" + subFolderName + "/" + fileName);


                requestFTP.Credentials = new NetworkCredential(ftp_username, ftp_password);
                requestFTP.Method = WebRequestMethods.Ftp.UploadFile;
                FileStream fStream = fileInfo.OpenRead();
                int bufferLength = 2048;
                byte[] buffer = new byte[bufferLength];

                Stream uploadStream = null;
                try
                {
                    uploadStream = requestFTP.GetRequestStream();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }

                int contentLength = fStream.Read(buffer, 0, bufferLength);

                while (contentLength != 0)
                {
                    uploadStream.Write(buffer, 0, contentLength);
                    contentLength = fStream.Read(buffer, 0, bufferLength);
                }
                uploadStream.Close();
                fStream.Close();
                requestFTP = null;
                flag = true;
            }
            catch (Exception ep)
            {
                MessageBox.Show("ERROR: " + ep.Message.ToString());

            }
            return flag;
        }
        public static List<string> GetFilesInFtpDirectory(string folderType, string subFolderName, List<Image> imgList)
        {
            try
            {
                ADDirectoryPathConfigsController pathCtrl = new ADDirectoryPathConfigsController();
                ADDirectoryPathConfigsInfo pathInfo = pathCtrl.GetInfoByImageFolderType(folderType);

                string ftp_path = string.Empty;
                string ftp_username = string.Empty;
                string ftp_password = string.Empty;
                if (pathInfo != null)
                {
                    ftp_path = pathInfo.ADDirectoryPathConfigAddress;
                    ftp_username = pathInfo.ADDirectoryPathConfigUserName;
                    ftp_password = pathInfo.ADDirectoryPathConfigPassword;
                }
                System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //string ftp_host = configuration.AppSettings.Settings["FTP_Host"].Value.ToString();
                //string ftp_homedir = configuration.AppSettings.Settings["FTP_HomeDir"].Value.ToString();
                //string ftp_username = configuration.AppSettings.Settings["FTP_Username"].Value.ToString();
                //string ftp_password = configuration.AppSettings.Settings["FTP_Password"].Value.ToString();

                subFolderName = string.Format("{0}/{1}", ftp_path, subFolderName);
                if (folderType == ImageFolderType.SampleItemImage.ToString())
                    subFolderName = ftp_path;

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(subFolderName);
                request.Method = WebRequestMethods.Ftp.ListDirectory;

                request.Credentials = new NetworkCredential(ftp_username, ftp_password);
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string names = reader.ReadToEnd();

                reader.Close();
                response.Close();

                List<string> nameLst = names.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                List<string> lstName = new List<string>();



                foreach (string fullURL in nameLst)
                {
                    string[] urlSplit = fullURL.Split('/');
                    if (urlSplit != null && urlSplit.Length == 2)
                    {
                        byte[] imgByte = DownloadFileFTP(urlSplit[1], subFolderName, ftp_username, ftp_password);
                        if (imgByte != null)
                        {
                            Image img = (Bitmap)((new ImageConverter()).ConvertFrom(imgByte));
                            imgList.Add(img);

                            lstName.Add(urlSplit[1]);
                        }
                    }

                }
                return lstName;
            }
            catch
            {
                return null;
            }

        }

        public static string GetASpecificFileInFtpDirectory(string subFolderName, string fileName, List<Image> imgList)
        {
            try
            {
                System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //string ftp_host = configuration.AppSettings.Settings["FTP_Host"].Value.ToString();
                //string ftp_homedir = configuration.AppSettings.Settings["FTP_HomeDir"].Value.ToString();
                //string ftp_username = configuration.AppSettings.Settings["FTP_Username"].Value.ToString();
                //string ftp_password = configuration.AppSettings.Settings["FTP_Password"].Value.ToString();
                ADDirectoryPathConfigsController pathCtrl = new ADDirectoryPathConfigsController();
                ADDirectoryPathConfigsInfo pathInfo = pathCtrl.GetInfoByImageFolderType(ImageFolderType.TechnicalDrawing.ToString());

                string ftp_path = string.Empty;
                string ftp_username = string.Empty;
                string ftp_password = string.Empty;
                if (pathInfo != null)
                {
                    ftp_path = pathInfo.ADDirectoryPathConfigAddress;
                    ftp_username = pathInfo.ADDirectoryPathConfigUserName;
                    ftp_password = pathInfo.ADDirectoryPathConfigPassword;
                }
                subFolderName = ftp_path + "/" + subFolderName;

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(subFolderName);
                request.Method = WebRequestMethods.Ftp.ListDirectory;

                request.Credentials = new NetworkCredential(ftp_username, ftp_password);
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string names = reader.ReadToEnd();

                reader.Close();
                response.Close();

                List<string> nameLst = names.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string foundFileName = string.Empty;
                foreach (string fullURL in nameLst)
                {
                    string[] urlSplit = fullURL.Split('/');
                    if (urlSplit != null && urlSplit.Length == 2)
                    {
                        string name = urlSplit[1].Substring(0, urlSplit[1].IndexOf('.'));
                        if (name == fileName)
                        {
                            byte[] imgByte = DownloadFileFTP(urlSplit[1], subFolderName, ftp_username, ftp_password);
                            if (imgByte != null)
                            {
                                Image img = (Bitmap)((new ImageConverter()).ConvertFrom(imgByte));
                                imgList.Add(img);

                                foundFileName = urlSplit[1];
                            }
                            break;
                        }
                    }

                }
                return foundFileName;
            }
            catch (Exception ex)
            {
                //throw ex;
                return null;
            }

        }
        public static byte[] DownloadFileFTP(string fileName, string subFolder, string ftp_username, string ftp_password)
        {
            try
            {
                System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string temp_location = System.IO.Path.GetTempPath();

                System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(temp_location);
                if (!System.IO.Directory.Exists(temp_location))
                {
                    System.IO.Directory.CreateDirectory(temp_location);
                }

                WebClient request = new WebClient();
                request.Credentials = new NetworkCredential(ftp_username, ftp_password);
                string FilePath = subFolder;



                byte[] fileData = request.DownloadData(FilePath + "/" + fileName);

                return fileData;
                //string localPath = temp_location + fileName;
                //if (!File.Exists(localPath))
                //{
                //    FileStream file = File.Create(localPath);
                //    file.Write(fileData, 0, fileData.Length);
                //    file.Close();
                //}

            }
            catch (Exception ep)
            {
                MessageBox.Show("ERROR: " + ep.Message.ToString());
                return null;
            }

        }
        /// <summary>
        /// Delte FTP file on Server
        /// </summary>
        public static void DeleteFile(string fileName, string subFolder)
        {
            try
            {
                System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //string ftp_host = configuration.AppSettings.Settings["FTP_Host"].Value.ToString();
                //string ftp_homedir = configuration.AppSettings.Settings["FTP_HomeDir"].Value.ToString();
                //string ftp_username = configuration.AppSettings.Settings["FTP_Username"].Value.ToString();
                //string ftp_password = configuration.AppSettings.Settings["FTP_Password"].Value.ToString();

                ADDirectoryPathConfigsController pathCtrl = new ADDirectoryPathConfigsController();
                ADDirectoryPathConfigsInfo pathInfo = pathCtrl.GetInfoByImageFolderType(ImageFolderType.TechnicalDrawing.ToString());

                string ftp_path = string.Empty;
                string ftp_username = string.Empty;
                string ftp_password = string.Empty;
                if (pathInfo != null)
                {
                    ftp_path = pathInfo.ADDirectoryPathConfigAddress;
                    ftp_username = pathInfo.ADDirectoryPathConfigUserName;
                    ftp_password = pathInfo.ADDirectoryPathConfigPassword;
                }

                FtpWebRequest requestFileDelete = (FtpWebRequest)WebRequest.Create(@ftp_path + "/" + subFolder + "/" + fileName);
                requestFileDelete.Credentials = new NetworkCredential(ftp_username, ftp_password);
                requestFileDelete.Method = WebRequestMethods.Ftp.DeleteFile;
                FtpWebResponse responseFileDelete = (FtpWebResponse)requestFileDelete.GetResponse();
            }
            catch (Exception ep)
            {
                MessageBox.Show("ERROR: " + ep.Message.ToString());
            }
        }

        /// <summary>
        /// Download file from Server
        /// </summary>
        /// <param name="fileName">name of the file will be downloaded</param>
        /// <param name="subFolder">the folder name on server that will contain the file</param>
        public static string DownloadFileFTP(string fileName, string subFolder)
        {
            string localPath = string.Empty;
            try
            {
                System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string ftp_host = configuration.AppSettings.Settings["FTP_Host"].Value.ToString();
                string ftp_homedir = configuration.AppSettings.Settings["FTP_HomeDir"].Value.ToString();
                string ftp_username = configuration.AppSettings.Settings["FTP_Username"].Value.ToString();
                string ftp_password = configuration.AppSettings.Settings["FTP_Password"].Value.ToString();
                //string temp_location = configuration.AppSettings.Settings["Temp_Location"].Value.ToString();
                string temp_location = System.IO.Path.GetTempPath();

                System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(temp_location);
                if (!System.IO.Directory.Exists(temp_location))
                {
                    System.IO.Directory.CreateDirectory(temp_location);
                }
                //foreach (System.IO.FileInfo file1 in directory.GetFiles()) file1.Delete();
                //foreach (System.IO.DirectoryInfo subDirectory in directory.GetDirectories()) subDirectory.Delete(true);

                WebClient request = new WebClient();
                request.Credentials = new NetworkCredential(ftp_username, ftp_password);
                string FilePath = "ftp://";
                if (String.IsNullOrEmpty(ftp_homedir))
                {
                    if (String.IsNullOrEmpty(subFolder))
                    {
                        FilePath += ftp_host;
                    }
                    else
                    {
                        FilePath += ftp_host + "/" + subFolder;
                    }
                }
                else
                {
                    if (String.IsNullOrEmpty(subFolder))
                    {
                        subFolder = ftp_homedir;
                    }
                    else
                    {
                        subFolder = ftp_homedir + "/" + subFolder;
                    }
                    FilePath += ftp_host + "/" + subFolder;
                }

                byte[] fileData = request.DownloadData(FilePath + "/" + fileName);
                localPath = temp_location + "\\" + fileName;
                FileStream file = File.Create(localPath);
                file.Write(fileData, 0, fileData.Length);
                file.Close();
            }
            catch (Exception ep)
            {
                MessageBox.Show("ERROR: " + ep.Message.ToString());
            }
            return localPath;
        }


        /// <summary>
        /// Create FTP directory
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <param name="ftpUser"></param>
        /// <param name="ftpPassword"></param>
        /// <returns></returns>
        private static bool CreateFTPDirectory(string directoryPath, string ftpUser, string ftpPassword)
        {
            try
            {
                //create the directory
                FtpWebRequest requestDir = (FtpWebRequest)FtpWebRequest.Create(new Uri(directoryPath));
                requestDir.Method = WebRequestMethods.Ftp.MakeDirectory;
                requestDir.Credentials = new NetworkCredential(ftpUser, ftpPassword);
                requestDir.UsePassive = true;
                requestDir.UseBinary = true;
                requestDir.KeepAlive = false;
                FtpWebResponse response = (FtpWebResponse)requestDir.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                ftpStream.Close();
                response.Close();

                return true;
            }
            catch (WebException ex)
            {
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                {
                    response.Close();
                    return true;
                }
                else
                {
                    response.Close();
                    return false;
                }
            }
        }
        #endregion

        #region Authentication
        public static bool IsAuthenticated(String strUserName, String strPassword, out string message)
        {
            ADUsersController objADUsersController = new ADUsersController();
            ADUsersInfo objADUsersInfo = new ADUsersInfo();
            objADUsersInfo = (ADUsersInfo)objADUsersController.GetObjectByName(strUserName.ToLower());
            message = string.Empty;
            if (objADUsersInfo != null)
            {
                if (!objADUsersInfo.ADUserActiveCheck)
                {
                    message = BaseLocalizedResources.UserIsLookerMessage;
                    return false;
                }
                String _encodedPassword = Convert.ToBase64String(SHA1Managed.Create().ComputeHash(ASCIIEncoding.ASCII.GetBytes(strPassword)));
                if (_encodedPassword.Equals(objADUsersInfo.ADPassword))
                    return true;
            }
            message = BaseLocalizedResources.InvalidAuthenticationMessage;
            return false;
        }

        public static bool IsBranchPermission(String strUserName, int branchID)
        {
            ADUsersController objADUsersController = new ADUsersController();
            ADUsersInfo objADUsersInfo = new ADUsersInfo();
            objADUsersInfo = (ADUsersInfo)objADUsersController.GetObjectByName(strUserName.ToLower());
            if (objADUsersInfo != null)
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                List<BRBranchsInfo> objBranchsInfo = objBranchsController.GetAllBranchByUserPermission(objADUsersInfo.ADUserID, branchID, string.Empty, ADDataViewPermissionType.Module);
                if (objBranchsInfo != null && objBranchsInfo.Where(o => o.BRBranchID == branchID).Count() > 0)
                    return true;
            }
            return false;
        }

        public static bool IsUserLoggedIn(String strUserName)
        {
            //Get iADUserID
            ADUsersController objADUsersController = new ADUsersController();
            int iADUserID = objADUsersController.GetObjectIDByName(strUserName);

            GEUserAuditsController objGEUserAuditsController = new GEUserAuditsController();
            return objGEUserAuditsController.IsExistUser(iADUserID);
        }

        public static void SetCurrentUserLogin(string strUserName)
        {
            ADUsersController objADUsersController = new ADUsersController();
            ADUsersInfo objADUsersInfo = new ADUsersInfo();
            objADUsersInfo = (ADUsersInfo)objADUsersController.GetObjectByName(strUserName);
            if (objADUsersInfo != null)
            {
                BOSApp.CurrentUser = objADUsersInfo.ADUserName;
                GELanguagesController objLanguageController = new GELanguagesController();
                GELanguagesInfo objLanguageInfo = new GELanguagesInfo();
                int iLanguageID = ((ADUserGroupsInfo)new ADUserGroupsController().GetObjectByID(objADUsersController.GetUserGroupOfUser(objADUsersInfo.ADUserID))).ADLanguageIDCombo;
                objLanguageInfo = (GELanguagesInfo)objLanguageController.GetObjectByID(iLanguageID);
                if (objLanguageInfo != null)
                    BOSApp.CurrentLang = objLanguageInfo.GELanguageName.Trim();
            }
        }
        #endregion

        public static void SetAppLanguage(int languageID)
        {
            GELanguagesController objLanguagesController = new GELanguagesController();
            GELanguagesInfo objLanguagesInfo = (GELanguagesInfo)objLanguagesController.GetObjectByID(languageID);
            if (objLanguagesInfo != null)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(objLanguagesInfo.GELanguageCultur);
                CurrentLanguage = objLanguagesInfo;
            }
        }

        /// <summary>
        /// Get first object from lookup table
        /// </summary>
        /// <param name="tableName">Table name</param>
        /// <returns>First object</returns>
        public static object GetFirstObjectFromLookupTable(string tableName)
        {
            IBusinessController controller = BusinessControllerFactory.GetBusinessController(tableName + "Controller");
            if (controller != null)
            {
                DataSet ds = (DataSet)LookupTables[tableName];
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    var obj = controller.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                    BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
                    return obj;
                }
            }
            return null;
        }

        /// <summary>
        /// Get the end date of a previous period by a current document date
        /// </summary>
        /// <param name="documentDate">Document date</param>
        /// <returns>End date of the previous period</returns>
        public static DateTime GetPreviousPeriodEndDate(DateTime documentDate)
        {
            byte startMonth = BOSApp.CurrentCompanyInfo.CSCompanyStartMonth;
            byte reportPeriod = BOSApp.CurrentCompanyInfo.CSCompanyReportPeriod;
            while (startMonth + reportPeriod - 1 < documentDate.Month)
            {
                startMonth += reportPeriod;
                if (startMonth > 12)
                {
                    startMonth -= 12;
                }
            }
            DateTime endDate = documentDate.AddMonths(startMonth + reportPeriod - 1 - documentDate.Month);
            endDate = endDate.AddMonths(-reportPeriod);
            endDate = BOSUtil.GetMonthEndDate(endDate);
            return endDate;
        }

        /// <summary>
        /// Get the start date of a period by a current document date
        /// </summary>
        /// <param name="documentDate">Document date</param>
        /// <returns>Start date of the period</returns>
        public static DateTime GetPeriodStartDate(DateTime documentDate)
        {
            DateTime prevPeriodEndDate = BOSApp.GetPreviousPeriodEndDate(documentDate);
            return prevPeriodEndDate.AddDays(1);
        }

        /// <summary>
        /// Get the end date of a period by a current document date
        /// </summary>
        /// <param name="documentDate">Document date</param>
        /// <returns>End date of the period</returns>
        public static DateTime GetPeriodEndDate(DateTime documentDate)
        {
            DateTime startDate = BOSApp.GetPeriodStartDate(documentDate);
            return BOSUtil.GetMonthEndDate(startDate.AddMonths(BOSApp.CurrentCompanyInfo.CSCompanyReportPeriod - 1));
        }

        /// <summary>
        /// Check whether a day is end of week
        /// </summary>
        /// <param name="dayOfWeek">Given day</param>
        /// <returns>True if the day is end of week, otherwise false</returns>
        public static bool IsEndOfWeek(DayOfWeek dayOfWeek)
        {
            if (dayOfWeek.Equals(DayOfWeek.Sunday))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Check whether a date is a holiday
        /// </summary>
        /// <param name="date">Given date</param>
        /// <returns>True if the date is a holiday, otherwise false</returns>
        public static bool IsHoliday(DateTime date)
        {
            HRCalendarEntrysInfo objCalendarEntrysInfo = new HRCalendarEntrysInfo();
            HRCalendarEntrysController objCalendarEntrysController = new HRCalendarEntrysController();
            List<HRCalendarEntrysInfo> entries = objCalendarEntrysController.GetCalendarEntryByDateAndCalenderType(date, CalendarType.Holiday.ToString());
            foreach (HRCalendarEntrysInfo entry in entries)
            {
                if (date.Day == entry.HRCalendarEntryDate.Day)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Get the current server date
        /// </summary>
        /// <returns>Current server date</returns>
        public static DateTime GetCurrentServerDate()
        {
            //BOSDbUtil dbUtil = new BOSDbUtil();
            //return dbUtil.GetCurrentServerDate();
            return MainScreen.ServerDate.AddSeconds(MainScreen.tickTimer);
        }

        /// <summary>
        /// Show module by module name and id of document (receipt)
        /// </summary>
        /// <param name="strModuleName"></param>
        /// <param name="ID"></param>
        public static void ShowModule(String strModuleName, int ID)
        {
            BaseModuleERP mdl = ShowModule(strModuleName);
            mdl.Invalidate(ID);
        }
        public static bool CheckChanged(BusinessObject oldObject, BusinessObject newObject)
        {
            object oldValue;
            object newValue;

            PropertyInfo[] props = oldObject.GetType().GetProperties();
            string tableName = BOSUtil.GetTableNameFromBusinessObject(oldObject);
            foreach (PropertyInfo propInfo in props)
            {
                if ((propInfo.Name.Substring(0, 2) != "AA"))
                {
                    if (propInfo.GetType() != typeof(byte[]))
                    {
                        BOSDbUtil bosDbUtil = new BOSDbUtil();
                        newValue = bosDbUtil.GetPropertyValue(newObject, propInfo.Name);
                        oldValue = bosDbUtil.GetPropertyValue(oldObject, propInfo.Name);
                        if (oldValue != null && newValue != null)
                        {
                            if (!oldValue.Equals(newValue))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        public static decimal RoundingAmount(decimal amount, int round)
        {
            decimal r = amount % (1 * round);
            amount = amount - r;
            return amount;
        }
        public static decimal RoundUp(decimal x, int decimals)
        {
            string number = x.ToString();
            string[] splt = number.Split('.');
            if (splt.Length > 0)
            {
                string digit = splt[1];
                decimal value = 0;
                string digitDec = "0";
                if (digit.Length >= decimals)
                {
                    digitDec = digit.Substring(decimals, 1 );
                }
                decimal.TryParse(digitDec, out value);
                if(0 < value && value < 5)
                    number = splt[0] + "." + digit.Substring(0, decimals) + "5";
                else
                    number = splt[0] + "." + digit;
                
                decimal.TryParse(number, out value);
                return Math.Round(value, decimals, MidpointRounding.AwayFromZero);
            }
            else
                return Math.Round(x, decimals, MidpointRounding.AwayFromZero);

        }

        /// <summary>
        /// ResetLookupTablesUpdatedDate
        /// </summary>
        /// <param name="tableName">string LookupTableName</param>
        /// <param name="day"> LastCreatedDate minus day </param>
        public static void ResetLookupTablesUpdatedDate(string tableName, int day)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            //Update lookup table if there is any changes to it
            DateTime dtLastCreatedDate = dbUtil.GetLastCreatedDateOfTable(tableName);
            DateTime dtLastUpdatedDate = dbUtil.GetLastUpdatedDateOfTable(tableName);
            // Update Last Updated Date of Lookup Table
            BOSApp.LookupTablesUpdatedDate[tableName] = dtLastCreatedDate.AddDays(-day);
        }
        public static DateTime GetWeekStartDate()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            int diff = (7 + (dbUtil.GetCurrentServerDate().DayOfWeek - DayOfWeek.Monday)) % 7;
            return dbUtil.GetCurrentServerDate().AddDays(-1 * diff).Date;
        }

        public static DateTime GetWeekEndDate()
        {
            return GetWeekStartDate().AddDays(7).AddSeconds(-1);
        }

        public static void InvalidateProductList()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            DateTime dtLastCreatedDate = dbUtil.GetLastCreatedDateOfTable(TableName.ICProductsTableName);
            DateTime dtLastUpdatedDate = dbUtil.GetLastUpdatedDateOfTable(TableName.ICProductsTableName);
            ICProductsController objProductsController = new ICProductsController();
            if (dtLastCreatedDate.CompareTo(((DateTime)LookupTablesUpdatedDate[TableName.ICProductsTableName])) > 0 ||
                dtLastUpdatedDate.CompareTo(((DateTime)LookupTablesUpdatedDate[TableName.ICProductsTableName])) > 0)
            {
                DataSet ds = GetLookupTableData(TableName.ICProductsTableName);
                if (ds.Tables.Count > 0)
                {
                    LookupTablesUpdatedDate[TableName.ICProductsTableName] = BOSApp.GetCurrentServerDate();
                    LookupTables[TableName.ICProductsTableName] = ds;
                    _currentProductList = objProductsController.GetListViewFromDataSet(ds);
                }
            }
            else
            {
                DataSet ds = (DataSet)LookupTables[TableName.ICProductsTableName];
                _currentProductList = objProductsController.GetListViewFromDataSet(ds);
            }
        }

        public static ICProductsInfo GetProductFromCurrentProductList(int productID)
        {
            if (productID == 0)
                return new ICProductsInfo();

            ICProductsInfo product = null;
            ICProductsForViewInfo productView = null;
            if (CurrentProductList != null && CurrentProductList.Count != 0)
                productView = CurrentProductList.FirstOrDefault(item => item.ICProductID == productID);

            if (productView == null || CurrentProductList.Count() == 0)
                InvalidateProductList();

            productView = CurrentProductList.Count() > 0 ? CurrentProductList.FirstOrDefault(item => item.ICProductID == productID) : new ICProductsForViewInfo();
            product = new ICProductsInfo();
            if (productView != null)
                BOSUtil.CopyViewObject(productView, product);
            return product;
        }

        public static ICProductsInfo GetProductFromCurrentProductListByProductNo(string productNo)
        {
            if (string.IsNullOrWhiteSpace(productNo))
                return new ICProductsInfo();

            ICProductsInfo product = null;
            ICProductsForViewInfo productView = null;
            if (CurrentProductList != null && CurrentProductList.Count != 0)
                productView = CurrentProductList.FirstOrDefault(item => item.ICProductNo == productNo);

            if (productView == null || CurrentProductList.Count() == 0)
                InvalidateProductList();

            productView = CurrentProductList.Count() > 0 ? CurrentProductList.FirstOrDefault(item => item.ICProductNo == productNo) : new ICProductsForViewInfo();
            product = new ICProductsInfo();
            if (productView != null)
                BOSUtil.CopyViewObject(productView, product);
            return product;
        }

        public static ICProductsForViewInfo GetProductFromCurrentViewProductList(int productID)
        {
            if (productID == 0)
                return new ICProductsForViewInfo();

            ICProductsForViewInfo productView = null;
            if (CurrentProductList != null && CurrentProductList.Count != 0)
                productView = CurrentProductList.FirstOrDefault(item => item.ICProductID == productID);
            if (productView == null || CurrentProductList.Count() == 0)
                InvalidateProductList();

            productView = CurrentProductList.FirstOrDefault(item => item.ICProductID == productID);
            return productView;
        }
        public static string GetDisplayTextFromCatche(string tableName, string tableNameID, int GetByID, string getFieldName)
        {
            string display = string.Empty;
            DataSet ds;
            if (!LookupTables.Contains(tableName) && !tableName.IsNullOrWhiteSpace())
            {
                ds = GetLookupTableData(tableName);
                if (ds != null && ds.Tables.Count > 0)
                {
                    LookupTables.Add(tableName, ds);
                    LookupTablesUpdatedDate.Add(tableName, BOSApp.GetCurrentServerDate());
                }
            }

            ds = (DataSet)BOSApp.LookupTables[tableName];
            if (ds != null && ds.Tables.Count > 0)
            {
                var result = ds.Tables[0].Rows.Cast<DataRow>().Where(x => (x[tableNameID] != null ? int.Parse(x[tableNameID].ToString()) : 0)
                                                                            == GetByID).Select(r => r[getFieldName]).FirstOrDefault();
                if (result != null)
                    display = result.ToString();
            }
            return display;
        }
        public static DataRow GetObjectFromCatche(string tableName, string tableNameID, int GetByID)
        {
            string display = string.Empty;
            DataSet ds = (DataSet)BOSApp.LookupTables[tableName];
            if (ds != null && ds.Tables.Count > 0)
            {

                DataRow result = ds.Tables[0].Rows.Cast<DataRow>().Where(x => (x[tableNameID] != null ? int.Parse(x[tableNameID].ToString()) : 0)
                                                                             == GetByID).FirstOrDefault();
                if (result != null)
                    return result;
            }
            return null;
        }
        //public static void ChangeGridViewByCommodityType(string commodityType, BOSGridControl gridControl, string tableName)
        //{
        //    ICCommodityGridControlTypeMappingsController cgtCtrl = new ICCommodityGridControlTypeMappingsController();
        //    ICCommodityGridControlTypeMappingsInfo cgt = cgtCtrl.GetByCommodityType(commodityType);

        //    string commodityGroupType = string.Empty;
        //    if (cgt != null)
        //    {
        //        commodityGroupType = cgt.ICCommodityGroupType;
        //    }
        //    else
        //        commodityGroupType = commodityType;
        //    gridControl.CommodityType = commodityGroupType;

        //    GridView view = (GridView)gridControl.MainView;
        //    if (view != null)
        //    {
        //        string qtyColumn = tableName.Substring(0, tableName.Length - 1) + "ProductQty";
        //        GridColumn col = view.Columns[qtyColumn];
        //        if (col != null)
        //        {
        //            if (commodityGroupType == CommodityGroupType.Roundwood.ToString()
        //            || commodityGroupType == CommodityGroupType.Lumber.ToString())
        //            {
        //                col.Caption = "Khối lượng";
        //            }
        //            else
        //            {
        //                col.Caption = "Số lượng";
        //            }
        //        }
        //    }

        //}
        public static void ShowMessage(string mess)
        {
            MessageBox.Show(mess, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowMessageYesNo(string mess)
        {
            return MessageBox.Show(mess, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public static int GetIntFromLookupEdit(BOSLookupEdit lke)
        {
            int result = 0;

            if (lke.EditValue != null)
            {
                int.TryParse(lke.EditValue.ToString(), out result);
            }

            return result;
        }

        public static bool IsUnChoosenDate(DateTime datetime)
        {
            bool isUnChoosenDate = false;

            if (datetime.ToString("yyyy").Equals("9999"))
            {
                isUnChoosenDate = true;
            }

            return isUnChoosenDate;
        }
        public static bool IsEqualObjects(BusinessObject obj1, BusinessObject obj2, List<string> propertiesList)
        {
            bool IsEqualObject = true;

            BOSDbUtil dbUtil = new BOSDbUtil();

            foreach (string propName in propertiesList)
            {
                object obj1Value = dbUtil.GetPropertyValue(obj1, propName);
                object obj2Value = dbUtil.GetPropertyValue(obj2, propName);
                if (obj1Value != null && obj2Value != null)
                {
                    if (!obj1Value.Equals(obj2Value))
                    {
                        IsEqualObject = false;
                        break;
                    }
                }
            }

            return IsEqualObject;
        }
        public static bool IsEqualObjects(BusinessObject obj1, BusinessObject obj2, string propName)
        {
            bool IsEqualObject = true;

            BOSDbUtil dbUtil = new BOSDbUtil();

            object obj1Value = dbUtil.GetPropertyValue(obj1, propName);
            object obj2Value = dbUtil.GetPropertyValue(obj2, propName);

            if (!obj1Value.Equals(obj2Value))
            {
                IsEqualObject = false;
            }


            return IsEqualObject;
        }

        public static object GetPropertieObjectByName(BusinessObject obj, string propName)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();

            object obj1Value = dbUtil.GetPropertyValue(obj, propName);

            return obj1Value;
        }
        public static object GetDisplayTextByValue(List<BusinessObject> objList, string valueMember, string displayMember, object value)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();


            foreach (BusinessObject obj in objList)
            {
                object getvalue = dbUtil.GetPropertyValue(obj, valueMember);
                if (getvalue != null && value != null && getvalue.ToString() == value.ToString())
                {
                    return dbUtil.GetPropertyValue(obj, displayMember);
                }

            }
            return null;
        }

        public static string GetDisplayTextFromConfigValue(string group, string value)
        {
            string display = string.Empty;
            var table = ADConfigValueUtility.ConfigValues.Tables[group];
            var ds = new DataSet();
            if (table == null)
            {
                var objConfigValuesController = new ADConfigValuesController();
                ds = objConfigValuesController.GetAllAliveObjects();
                if (ds != null && ds.Tables.Count > 0)
                {
                    table = ds.Tables[0];
                }
                if (table != null && table.Rows.Count > 0)
                {
                    var result = table.Rows.Cast<DataRow>().Where(x => ((string)x["ADConfigKeyGroup"] == group) && ((string)x["ADConfigKeyValue"] == value.Trim())).Select(x => x["ADConfigText"]).FirstOrDefault();
                    if (result != null)
                        display = result.ToString();
                }

            }
            else
            {
                var result = table.Rows.Cast<DataRow>().Where(x => ((string)x["Value"] == value)).Select(x => x["Text"]).FirstOrDefault();
                if (result != null)
                    display = result.ToString();
            }
            if (ds != null) ds.Dispose();

            return display;
        }
        public static void RefreshChangeLookupData()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("StringData"));
            List<string> tableList = new List<string>();
            foreach (var item in BOSApp.LookupTables.Keys)
            {
                DataRow r = dt.NewRow();
                string prefix = item.ToString().Substring(0, 2);
                if (prefix.Contains("AR") || prefix.Contains("AP") || prefix.Contains("IC") || prefix.Contains("MM")
                    || prefix.Contains("HR") || prefix.Contains("AC") || prefix.Contains("AD"))
                {
                    r[0] = item;
                    tableList.Add(item.ToString());
                    dt.Rows.Add(r);
                }
            }
            DataSet ds = dbUtil.GetListCreateAndUpdatedDateOfListTable(dt, "Type_StringDatas", "GetListCreateAndUpdatedDateOfListTable");
            if (ds != null && ds.Tables.Count > 0 && tableList.Count > 0)
            {
                BOSApp.MainScreen.ServerDate = dbUtil.GetCurrentServerDate();
                BOSApp.MainScreen.tickTimer = 0;
                foreach (string strLookupTable in tableList)
                {
                    DateTime dtLastCreatedDate = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
                    DateTime dtLastUpdatedDate = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
                    if (ds.Tables[0].Columns["TableName"] != null)
                    {
                        DataRow result = ds.Tables[0].Rows.Cast<DataRow>().FirstOrDefault(x => (x["TableName"] != null ? x["TableName"].ToString() : "") == strLookupTable);
                        if (result != null)
                        {
                            object objCreatedDate = result["AACreatedDate"];
                            if (objCreatedDate != System.DBNull.Value)
                            {
                                DateTime.TryParse(objCreatedDate.ToString(), out dtLastCreatedDate);
                            }

                            object objUpdatedDate = result["AAUpdatedDate"];
                            if (objUpdatedDate != System.DBNull.Value)
                            {
                                DateTime.TryParse(objUpdatedDate.ToString(), out dtLastUpdatedDate);
                            }

                        }
                    }

                    double _creDate = dtLastCreatedDate.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds;
                    double _upddDate = dtLastUpdatedDate.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds;
                    double _lkUpddDate = 0;
                    var data = LookupTablesUpdatedDate[strLookupTable];
                    if (data != null)
                        _lkUpddDate = ((DateTime)LookupTablesUpdatedDate[strLookupTable]).Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds;

                    if (_creDate > _lkUpddDate || _upddDate > _lkUpddDate)
                    {
                        DataSet updateDs = GetLookupTableData(strLookupTable);
                        if (updateDs.Tables.Count > 0)
                        {

                            // Update Last Updated Date of Lookup Table
                            LookupTablesUpdatedDate[strLookupTable] = BOSApp.MainScreen.ServerDate;
                            LookupTables[strLookupTable] = updateDs;

                            if (updateDs != null && strLookupTable == "ICProducts")
                            {
                                _currentProductList = (new ICProductsController()).GetListViewFromDataSet(updateDs);
                            }

                            updateDs.Dispose();
                            GC.Collect(0, GCCollectionMode.Forced);
                        }
                    }
                    ds.Dispose();
                    GC.Collect(0, GCCollectionMode.Forced);
                }
            }
        }
        public static void RefreshLookupDataByBranch()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            DataTable dt = new DataTable();
            List<string> tableList = new List<string>();
            foreach (var item in BOSApp.LookupTables.Keys)
            {
                tableList.Add(item.ToString());
            }
            foreach (string item in tableList)
            {

                DataSet updateDs = GetLookupTableDataByBranch(item);
                if (updateDs != null && updateDs.Tables.Count > 0)
                {
                    // Update Last Updated Date of Lookup Table
                    LookupTablesUpdatedDate[item] = BOSApp.MainScreen.ServerDate.AddSeconds(BOSApp.MainScreen.tickTimer);
                    LookupTables[item] = updateDs;

                    if (updateDs != null && item.ToString() == "ICProducts")
                    {
                        _currentProductList = (new ICProductsController()).GetListViewFromDataSet(updateDs);
                    }

                    updateDs.Dispose();
                    GC.Collect(0, GCCollectionMode.Forced);
                }
                GC.Collect(0, GCCollectionMode.Forced);
            }
        }

        public static string GetDisplayTextFromConfigText(string group, string text)
        {
            string display = string.Empty;
            var table = ADConfigValueUtility.ConfigValues.Tables[group];
            var ds = new DataSet();
            if (table == null)
            {
                var objConfigValuesController = new ADConfigValuesController();
                ds = objConfigValuesController.GetAllAliveObjects();
                if (ds != null && ds.Tables.Count > 0)
                {
                    table = ds.Tables[0];
                }
                if (table != null && table.Rows.Count > 0)
                {
                    var result = table.Rows.Cast<DataRow>().Where(x => ((string)x["ADConfigKeyGroup"] == group) && ((string)x["ADConfigText"] == text.Trim())).Select(x => x["ADConfigKeyValue"]).FirstOrDefault();
                    if (result != null)
                        display = result.ToString();
                }

            }
            else
            {
                var result = table.Rows.Cast<DataRow>().Where(x => ((string)x["Text"] == text)).Select(x => x["Value"]).FirstOrDefault();
                if (result != null)
                    display = result.ToString();
            }
            if (string.IsNullOrEmpty(display))
                display = string.Empty;
            if (ds != null) ds.Dispose();

            return display;
        }

        public static void UpdateRealTimeExchageRate()
        {
            try
            {
                GECurrencyExchangeRatesController EController = new GECurrencyExchangeRatesController();
                List<GECurrencyExchangeRatesInfo> EList = EController.GetCurrencyExchangeRateByDate(BOSApp.GetCurrentServerDate());
                if (EList.Count > 0) return;

                EController.UpdateRateIsVisibleForAll();
                GECurrenciesController CController = new GECurrenciesController();
                List<GECurrenciesInfo> CList = CController.GetAllCurrencys();
                List<string> ListCurrency = new List<string> { "USD", "EUR", "RMB", "SGD", "GBP", "JPY" };
                XmlDocument xml = new XmlDocument();
                xml.Load("https://portal.vietcombank.com.vn/Usercontrols/TVPortal.TyGia/pXML.aspx");
                XmlNodeList noXml;
                noXml = xml.SelectNodes("/ExrateList/Exrate");
                for (int i = 0; i <= noXml.Count - 1; i++)
                {
                    string currencyCode = noXml.Item(i).Attributes["CurrencyCode"].InnerText;
                    if (ListCurrency.Where(t => t == currencyCode).FirstOrDefault() != null)
                    {
                        GECurrencyExchangeRatesInfo item = new GECurrencyExchangeRatesInfo();
                        item.GECurrencyExchangeRateDate = BOSApp.GetCurrentServerDate();
                        item.GECurrencyExchangeRateIsVisible = true;
                        decimal Sell = 0;
                        decimal Transfer = 0;
                        //decimal.TryParse(noXml.Item(i).Attributes["Sell"].InnerText, out Sell);
                        Sell = decimal.Parse(
                                                noXml.Item(i).Attributes["Sell"].InnerText.ToString(),
                                                System.Globalization.CultureInfo.InvariantCulture);
                        Transfer = decimal.Parse(
                                                noXml.Item(i).Attributes["Transfer"].InnerText.ToString(),
                                                System.Globalization.CultureInfo.InvariantCulture);
                        item.GECurrencyExchangeRateExchangeRate = Sell;
                        item.GECurrencyExchangeRateTransferExchangeRate = Transfer;

                        //if (currencyCode == "EUR") 
                        //    currencyCode = "EURO";
                        GECurrenciesInfo objcurrency = CList.Where(c => c.GECurrencyNo == currencyCode).FirstOrDefault();
                        if (objcurrency != null)
                            item.FK_GECurrencyID = objcurrency.GECurrencyID;
                        decimal planExchangeRate = EController.GetPreviousCurrencyExchangeRatePlanByCurrencyIDAndDate(item.FK_GECurrencyID, BOSApp.GetCurrentServerDate());
                        item.GECurrencyExchangeRatePlanExchangeRate = planExchangeRate;
                        EController.CreateObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public static decimal RealTimeExchageRateByCurrencyAndDate(int currencyID, DateTime date)
        {
            try
            {
                if (currencyID == GECurrencyID.VND)
                    return 1;
                GECurrencyExchangeRatesController objCurrenciesController = new GECurrencyExchangeRatesController();
                GECurrencyExchangeRatesInfo currencyExrate = (GECurrencyExchangeRatesInfo)objCurrenciesController.GetCurrencyExchangeRateByCurrencyIDAnddate(currencyID, date);
                if (currencyExrate != null)
                    return currencyExrate.GECurrencyExchangeRateExchangeRate;
                return 1;
            }
            catch (Exception ex)
            {
                return 1;
            }
        }

        public static decimal RealTimeExchageRateTransferByCurrencyAndDate(int currencyID, DateTime date)
        {
            try
            {
                if (currencyID == GECurrencyID.VND)
                    return 1;
                GECurrencyExchangeRatesController objCurrenciesController = new GECurrencyExchangeRatesController();
                GECurrencyExchangeRatesInfo currencyExrate = (GECurrencyExchangeRatesInfo)objCurrenciesController.GetCurrencyExchangeRateByCurrencyIDAnddate(currencyID, date);
                if (currencyExrate != null)
                    return currencyExrate.GECurrencyExchangeRateTransferExchangeRate;
                return 1;
            }
            catch (Exception ex)
            {
                return 1;
            }
        }

        public static ACObjectsInfo GetObjectByIDAndTypeFromCatche(int objectID, string type)
        {
            ACObjectsController objectController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = BOSApp.AccountingObjects.FirstOrDefault(x => x.ACObjectID == objectID && x.ACObjectType == type);
            if (objObjectsInfo == null && objectID != 0)
                objObjectsInfo = objectController.GetObjectByIDAndType(objectID, type);
            return objObjectsInfo;
        }

        public static bool IsWoodTypeDocument(string mainObjectType, BusinessObject itemObject)
        {
            string productType = mainObjectType;

            if (itemObject != null)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                int productID = dbUtil.GetPropertyIntValue(itemObject, "FK_ICProductID");

                ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(o1 => o1.ICProductID == productID);
                if (objProductsInfo != null)
                    productType = objProductsInfo.ICProductType;
            }

            return BOSApp.WoodTypesList.Contains(productType);
        }
        public static bool IsForeignKey(String strTableName, String strColumnName)
        {
            if (strColumnName.Contains("FK_"))
                return true;

            string primaryTable = GetPrimaryTableWhichForeignColumnReferenceTo(strTableName, strColumnName);
            if (primaryTable.IsNullOrWhiteSpace())
                return false;

            return true;
        }

        public static String GetPrimaryTableWhichForeignColumnReferenceTo(String strForeignTableName, String strForeignColumnName)
        {
            return SqlDatabaseHelper.GetPrimaryTableWhichForeignColumnReferenceTo(strForeignTableName, strForeignColumnName);
        }

        public static String GetTablePrimaryColumn(String strTableName)
        {
            return SqlDatabaseHelper.GetPrimaryKeyColumn(strTableName);
        }

        //public static decimal CalculaterProductUnitPrice(ICProductsInfo product, decimal unitPrice, decimal Qty, int measureUnitID, int customerID, DateTime getDate, int currencyID)
        //{
        //    if(product == null)
        //    {
        //        return 0;
        //    }    

        //    decimal calUnitPrice = unitPrice;
        //    CSCompanysInfo objCompanysInfo = BOSApp.CurrentCompanyInfo;
        //    string sellingPriceMethod = objCompanysInfo.CSSourceSellingPriceMethod;

        //    if (sellingPriceMethod == ADConfigValueUtility.cstSourceSellingPriceMethodMasterData)
        //    {
        //        calUnitPrice = product.ICProductPrice01;
        //    }
        //    else if (sellingPriceMethod == ADConfigValueUtility.cstSourceSellingPriceMethodPriceSheet)
        //    {
        //        ARPriceSheetItemsController objPriceSheetItemsController = new ARPriceSheetItemsController();
        //        List<ARPriceSheetItemsInfo> newParams = new List<ARPriceSheetItemsInfo>()
        //            {
        //                new ARPriceSheetItemsInfo (customerID, product.ICProductID, measureUnitID, getDate)
        //            };
        //        List<ARPriceSheetItemsInfo> listPriceSheets = objPriceSheetItemsController.GetPriceSheetInActiveByProductIDs(newParams);
        //        ARPriceSheetItemsInfo objPriceSheetItemsInfo = new ARPriceSheetItemsInfo();
        //        objPriceSheetItemsInfo = listPriceSheets.Where(o => o.ARPriceSheetItemSpecificQty == Qty
        //                                                            && o.FK_ICProductID == product.ICProductID
        //                                                            && o.FK_GECurrencyID == currencyID
        //                                                            && !o.ARPriceSheetItemSOQ).
        //                                                            OrderByDescending(o => o.FK_ARCustomerID).FirstOrDefault();
        //        if (objPriceSheetItemsInfo != null)
        //            calUnitPrice = objPriceSheetItemsInfo.ARPriceSheetItemSpecificPrice;
        //        if (objPriceSheetItemsInfo == null)
        //        {
        //            objPriceSheetItemsInfo = listPriceSheets.Where(o => o.FK_ICProductID == product.ICProductID
        //                                                                && o.FK_GECurrencyID == currencyID).
        //                                                                OrderByDescending(o => o.FK_ARCustomerID).
        //                                                                OrderByDescending(o => o.ARPriceSheetItemQty).FirstOrDefault();
        //        }
        //        if (objPriceSheetItemsInfo == null)
        //            calUnitPrice = 0;
        //        else
        //        {
        //            if (objPriceSheetItemsInfo.ARPriceSheetItemQty < Qty)
        //                calUnitPrice = objPriceSheetItemsInfo.ARPriceSheetItemUpperSpecificPrice;
        //            else
        //                calUnitPrice = objPriceSheetItemsInfo.ARPriceSheetItemLowerSpecificPrice;
        //        }
        //    }
        //    return calUnitPrice;
        //}
        public static decimal CalculaterProductUnitPrice(ICProductsInfo product, decimal unitPrice, decimal Qty, int measureUnitID, int customerID, DateTime getDate, int currencyID)
        {
            if (product == null)
            {
                return 0;
            }

            decimal calUnitPrice = unitPrice;
            CSCompanysInfo objCompanysInfo = BOSApp.CurrentCompanyInfo;
            string sellingPriceMethod = objCompanysInfo.CSSourceSellingPriceMethod;

            if (sellingPriceMethod == ADConfigValueUtility.cstSourceSellingPriceMethodMasterData)
            {
                calUnitPrice = product.ICProductPrice01;
            }
            else if (sellingPriceMethod == ADConfigValueUtility.cstSourceSellingPriceMethodPriceSheet)
            {
                ARPriceSheetItemsController objPriceSheetItemsController = new ARPriceSheetItemsController();
                List<ARPriceSheetItemsInfo> newParams = new List<ARPriceSheetItemsInfo>()
                    {
                        new ARPriceSheetItemsInfo (customerID, product.ICProductID, measureUnitID, getDate)
                    };
                List<ARPriceSheetItemsInfo> listPriceSheets = objPriceSheetItemsController.GetPriceSheetInActiveByProductIDs(newParams);
                ARPriceSheetItemsInfo objPriceSheetItemsInfo = listPriceSheets.Where(o => o.ARPriceSheetItemQty <= Qty
                                                                                        && o.FK_ICProductID == product.ICProductID
                                                                                        && o.FK_GECurrencyID == currencyID).
                                                                                        OrderByDescending(o => o.FK_ARCustomerID).
                                                                                        OrderByDescending(o => o.ARPriceSheetItemQty).FirstOrDefault();
                if (objPriceSheetItemsInfo == null)
                    calUnitPrice = 0;
                else
                    calUnitPrice = objPriceSheetItemsInfo.ARPriceSheetItemPrice;
            }
            return calUnitPrice;
        }
        public static byte[] GetDefaultDescConfig(string moduleName, string saleType)
        {
            byte[] result = new byte[0];
            STModulesInfo objModulesInfo = ModuleList.Where(o => o.STModuleName == moduleName).FirstOrDefault();
            ADDefaultDescConfigsController objDefaultDescConfigsController = new ADDefaultDescConfigsController();
            if (objModulesInfo != null)
            {
                ADDefaultDescConfigsInfo objDefaultDescConfigsInfo = (ADDefaultDescConfigsInfo)objDefaultDescConfigsController.GetDefaultDescByModuleAndSaleType(objModulesInfo.STModuleID, saleType);
                if (objDefaultDescConfigsInfo != null)
                {
                    result = objDefaultDescConfigsInfo.ADDefaultDescConfigDescValue;
                }    
            }
            return result;
        }
    }
}
