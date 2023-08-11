using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BOSLib
{
    public class BaseModule
    {
        #region "Constant for Module"
        public const String cstHomeModule = "Home";
        public const String cstCustomerModule = "Customer";
        public const String cstSupplierModule = "Supplier";
        public const String cstProductModule = "Product";
        public const String cstAccountModule = "Account";
        public const String cstStockModule = "Stock";
        public const String cstPriceListModule = "PriceList";
        public const String cstTemplateModule = "Template";
        public const String cstSellerModule = "Seller";

        public const String cstUserManagementModule = "UserManagement";
        public const String cstBOSActivationModule = "BOSActivation";

        public const String cstMatchCodeModule = "MatchCode";
        public const String cstNumberingModule = "Numbering";
        public const String cstReportModule = "Report";
        #endregion

        #region Constant for Screen Type
        /// <summary>
        /// Constant define screen is data main
        /// </summary>
        public const String cstDataMainScreen = "DM";
        /// <summary>
        /// Constant define screen is search main
        /// </summary>
        public const String cstSearchMainScreen = "SM";
        /// <summary>
        /// Constant define Screen is Search Results
        /// </summary>
        public const String cstSearchResultsScreen = "SR";
        /// <summary>
        /// Constant define Screen is Data Sub
        /// </summary>
        public const String cstDataSubScreen = "DS";
        #endregion

        #region "Constant for Module Status"
        /// <summary>
        /// Constant define Module is open
        /// </summary>
        public const String cstModuleStatusOpen = "Open";
        /// <summary>
        /// Constant define Module is hibernate
        /// </summary>
        public const String cstModuleStatusHibernate = "Hibernate";
        /// <summary>
        /// Constant define module is close
        /// </summary>
        public const String cstModuleStatusClose = "Close";
        /// <summary>
        /// Constant define module is hide
        /// </summary>
        public const String cstModuleStatusHide = "Hide";
        #endregion

        #region "Constant for Show Module"
        /// <summary>
        /// Constant define modus which module will be showed is Normal
        /// </summary>
        public const String cstModusNormal = "Normal";
        /// <summary>
        /// Constant define modus which module will be showed is Search
        /// </summary>
        public const String cstModusSearch = "Search";
        #endregion

        #region Constant for User Audit Action
        public const String cstUserAuditNothing = "Nothing";
        public const String cstUserAuditNew = "Create";
        public const String cstUserAuditEdit = "Edit";
        #endregion

        #region Constant for Object History Action
        public const String cstObjectHistoryActionNew = "Create";
        public const String cstObjectHistoryActionChange = "Change";
        public const String cstObjectHistoryActionDelete = "Delete";
        #endregion

        #region variables
        /// <summary>
        /// Variable define Name of Module
        /// </summary>
        /// 
        protected String _name = String.Empty;

        /// <summary>
        /// Variable define Code of Module
        /// </summary>
        protected String _code = String.Empty;
        /// <summary>
        /// Variable define Screen collection of Module
        /// </summary>
        public List<BOSScreen> Screens;
        /// <summary>
        /// Variable define Control collection of module
        /// </summary>
        public ControlCollection Controls;
        /// <summary>
        /// Variable define Active Screen
        /// </summary>
        protected BOSScreen _activateScreen;
        /// <summary>
        /// Variable define toolbar of module
        /// </summary>
        public BaseToolbar Toolbar;

        public DevExpress.Utils.WaitDialogForm WaitDialog;
        #endregion      

        #region Public properties
        public int ModuleID { get; set; }

        /// <summary>
        /// Gets,sets Module Name
        /// </summary>
        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Gets,sets Module Code
        /// </summary>
        public String Code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }

        /// <summary>
        /// Gets,sets active Screen of modle
        /// </summary>
        public BOSScreen ActiveScreen
        {
            get { return _activateScreen; }
            set
            {
                _activateScreen = value;
                _activateScreen.Activate();
            }
        }

        /// <summary>
        /// Gets or sets the format group list of table columns of the module
        /// </summary>
        public List<STFieldFormatGroupsInfo> FormatGroups { get; set; }
        /// <summary>
        /// Gets or sets the format group list of table columns of the module
        /// </summary>
        public List<STFieldFormatGroupsInfo> FieldFormatList { get; set; }
        /// <summary>
        /// Gets or sets the STScreensInfo list of sys
        /// </summary>
        public List<STScreensInfo> LstScreen { get; set; }
        /// <summary>
        /// Gets or sets the STFieldsInfo list of sys
        /// </summary>
        public List<STFieldsInfo> LstField { get; set; }
        /// <summary>
        /// Gets or sets the STFieldEventsInfo list of sys
        /// </summary>
        public List<STFieldEventsInfo> LstFieldEvent { get; set; }
        /// <summary>
        /// Gets or sets the STFieldPermissionsInfo list of sys
        /// </summary>
        public List<STFieldPermissionsInfo> LstFieldPermission { get; set; }

        /// <summary>
        /// Gets or sets the ColumnAlias list of sys
        /// </summary>
        public List<AAColumnAliasInfo> LstColumnAlias { get; set; }

        /// <summary>
        /// Gets or sets the STFieldsInfo list of sys
        /// </summary>
        public List<STFieldColumnsInfo> LstFieldColumn { get; set; }

        #endregion

        #region Constructor
        public BaseModule()
        {
            Toolbar = new BaseToolbar();
            Screens = new List<BOSScreen>();
            LstScreen = new List<STScreensInfo>();
            Controls = new ControlCollection();
            FormatGroups = new List<STFieldFormatGroupsInfo>();
            FieldFormatList = new List<STFieldFormatGroupsInfo>();
        }
        #endregion

        #region Get Control Functions
        /// <summary type="GetControl">
        /// Get Control by Name
        /// </summary>
        /// <param name="strControlName"></param>
        /// <returns></returns>
        public Control GetControlByName(String strControlName)
        {
            if (Controls[strControlName] != null)
                return Controls[strControlName];
            else
                return null;
        }


        /// <summary type="Check">
        /// Determine module contains this control or not
        /// </summary>
        /// <param name="strControlName"></param>
        /// <returns></returns>
        public bool Contains(String strControlName)
        {
            if (Controls[strControlName] != null)
                return true;
            else
                return false;
        }
        #endregion

        #region Show Module functions
        /// <summary type="Show">
        /// Showw all main screens of module
        /// </summary>        
        protected void ShowAllMainScreens()
        {
            for (int i = 0; i < Screens.Count; i++)
            {
                BOSScreen scr = Screens[i];
                String strScreenNumber = Screens[i].ScreenNumber;
                if (strScreenNumber.StartsWith("DM") || strScreenNumber.StartsWith("SM") || strScreenNumber.StartsWith("SR"))
                    ShowScreen(scr, true);
            }
        }

        /// <summary type="Show">
        /// Show specific screen
        /// </summary>        
        /// <param name="scr">Screen to be showned</param>
        /// <param name="bIsChild">Define the screen is child screen or not</param>
        public virtual void ShowScreen(BOSScreen scr, bool bIsChild)
        {

        }

        public virtual BOSScreen GetScreenByScreenNumber(String strScreenNumber)
        {
            for (int i = 0; i < Screens.Count; i++)
            {
                if (Screens[i].ScreenNumber == strScreenNumber)
                    return Screens[i];
            }
            return null;
        }
        #endregion
        /// <summary>
        /// Re binding catche data to control
        /// </summary>
        /// <returns></returns>
        public virtual bool RefreshData()
        {
            return true;
        }
        public virtual void ReInitializeFieldFormat(int CurrencyID)
        {
        }
        #region Get Method Info Functions

        /// <summary>
        /// Get Method by Method Name and Parameter Type array
        /// </summary>
        /// <functiontype>Get Method</functiontype>
        /// <param name="strMethodName"></param>
        /// <param name="parametersType"></param>
        /// <returns></returns>
        public MethodInfo GetMethodInfoByMethodNameAndParametersType(String strMethodName, Type[] parametersType)
        {
            return this.GetType().GetMethod(strMethodName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, null, parametersType, null);
        }

        /// <summary>
        /// Get Parameter Type Array of Method
        /// </summary>
        /// <functiontype>Get Method</functiontype>
        /// <param name="strMethodFullName"></param>
        /// <returns></returns>
        public Type[] GetParameterTypeArrayFromMethodFullName(String strMethodFullName)
        {
            String strMethodParameters = strMethodFullName.Substring(strMethodFullName.IndexOf("("));
            Type[] parametersType = new Type[0];
            int index = strMethodParameters.IndexOf(",");
            while (index > 0)
            {
                Array.Resize(ref parametersType, parametersType.Length + 1);
                parametersType.SetValue(Type.GetType(strMethodParameters.Substring(1, index - 1)), parametersType.Length - 1);
                strMethodParameters = strMethodParameters.Substring(index + 1);
                index = strMethodParameters.IndexOf(",");
            }
            index = strMethodParameters.IndexOf(")");
            if (index > 0)
            {
                if (!String.IsNullOrEmpty(strMethodParameters.Substring(1, index - 1)))
                {
                    Array.Resize(ref parametersType, parametersType.Length + 1);

                    parametersType.SetValue(GetType(BOSUtil.GetFullTypeName(strMethodParameters.Substring(1, index - 1))), parametersType.Length - 1);
                }
            }

            return parametersType;
        }

        /// <summary>
        /// Get Method Info
        /// </summary>
        /// <functiontype>Get Method</functiontype>
        /// <param name="strMethodName">Method Name</param>
        /// <param name="strMethodFullName">Method Full Name</param>
        /// <param name="strMethodClass">Class of Method</param>
        /// <returns></returns>
        public MethodInfo GetMethodInfoByMethodFullNameAndMethodClass(String strMethodName, String strMethodFullName, String strMethodClass)
        {
            try
            {
                String strAssemblyName = GetAssemblyName();

                if (!String.IsNullOrEmpty(strAssemblyName))
                {
                    //Assembly a = Assembly.Load(strAssemblyName);
                    Type classType = GetClassType(strMethodClass);
                    if (classType != null)
                    {
                        MethodInfo method = classType.GetMethod(strMethodName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, GetParameterTypeArrayFromMethodFullName(strMethodFullName), null);
                        return method;
                    }
                    else
                        return null;
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                MessageBox.Show(this.GetType().Name + ".GetMethodByMethodFullNameAndMethodClass:" + e.Message);
                return null;
            }
        }

        protected Type GetType(String strFullTypeName)
        {
            if (Type.GetType(strFullTypeName) != null)
                return Type.GetType(strFullTypeName);
            else
            {
                if (strFullTypeName == "DevExpress.XtraBars.ItemClickEventArgs")
                    return typeof(DevExpress.XtraBars.ItemClickEventArgs);
                else
                {
                    String strAssemblyName = strFullTypeName.Substring(0, strFullTypeName.LastIndexOf("."));
                    Assembly a = Assembly.LoadFile("C:\\WINDOWS\\Microsoft.NET\\Framework\\v2.0.50727\\" + strAssemblyName + ".dll");
                    return a.GetType(strFullTypeName);
                }
            }


        }

        /// <summary>
        /// Get Parameters value of method
        /// </summary>
        /// <functiontype>Get Method</functiontype>
        /// <param name="parameters"></param>
        /// <param name="parameterValue"></param>
        /// <returns></returns>
        public object[] GetMethodParameterValues(ParameterInfo[] parameters, params object[] parameterValue)
        {
            TypeConverter typeConverter = new TypeConverter();
            object[] paramObjects = new object[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                paramObjects[i] = parameterValue[i];
            }
            return paramObjects;
        }

        public virtual String GetAssemblyName()
        {
            return String.Empty;
        }

        public virtual Type GetClassType(String strClassName)
        {
            return null;
        }
        #endregion                

        /// <summary>
        /// Get format group the column is set to
        /// </summary>
        /// <param name="tableName">Name of the table the column belongs to</param>
        /// <param name="columnName">Name of the given column</param>
        /// <returns>Format group object</returns>
        public virtual STFieldFormatGroupsInfo GetColumnFormat(String tableName, String columnName , int? moduleID)
        {
            STFieldFormatGroupsController objFieldFormatGroupsController = new STFieldFormatGroupsController();
            STFieldFormatGroupsInfo objFieldFormatGroupsInfo = FormatGroups.Where(fg => fg.TableName == tableName && fg.ColumnName == columnName && (moduleID == 0 || fg.STModuleID == moduleID)).FirstOrDefault();
            if (objFieldFormatGroupsInfo == null)
                objFieldFormatGroupsInfo = FormatGroups.Where(fg => fg.TableName == tableName && fg.ColumnName == columnName ).FirstOrDefault();
            if (objFieldFormatGroupsInfo == null)
            {
                //Find property binding to this column then get its format group attribute
                FormatGroupAttribute formatGroupAttr = null;
                BusinessObject obj = BusinessObjectFactory.GetBusinessObject(tableName + "Info");
                if (obj != null)
                {
                    PropertyInfo prop = obj.GetType().GetProperty(columnName);
                    if (prop != null)
                    {
                        object[] attrs = prop.GetCustomAttributes(typeof(FormatGroupAttribute), true);
                        if (attrs.Length > 0)
                            formatGroupAttr = (FormatGroupAttribute)attrs[0];
                    }
                }
                if (formatGroupAttr != null)
                {
                    if (FieldFormatList != null)
                        objFieldFormatGroupsInfo = FieldFormatList.Where(f => f.STFieldFormatGroupName == formatGroupAttr.FormatGroup).FirstOrDefault();
                    if (objFieldFormatGroupsInfo == null)
                        objFieldFormatGroupsInfo = (STFieldFormatGroupsInfo)objFieldFormatGroupsController.GetObjectByName(formatGroupAttr.FormatGroup);
                }

                //Get format group directly from database based on table name and column name
                if (objFieldFormatGroupsInfo == null)
                {
                    if (FieldFormatList != null)
                        objFieldFormatGroupsInfo = FieldFormatList.Where(f => f.TableName == tableName && f.ColumnName == columnName).FirstOrDefault();
                    //if (objFieldFormatGroupsInfo == null)
                    //    objFieldFormatGroupsInfo = objFieldFormatGroupsController.GetFieldFormatGroupByTableNameAndColumnName(tableName, columnName);                    
                }
            }
            return objFieldFormatGroupsInfo;
        }
    }
}
