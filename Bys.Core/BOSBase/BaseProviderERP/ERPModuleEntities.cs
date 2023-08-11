using BOSCommon;
using BOSCommon.Constants;
using BOSCommon.Extensions;
using BOSLib;
using BOSLib.Interfaces;
using Localization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Transactions;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class ERPModuleEntities
    {
        #region Constant
        public const String AAStatusColumn = "AAStatus";
        public const String AACreatedUser = "AACreatedUser";
        public const String AACreatedDate = "AACreatedDate";
        public const String AAUpdatedUser = "AAUpdatedUser";
        public const String AAUpdatedDate = "AAUpdatedDate";

        public const String cstNewObjectText = "***NEW***";
        public const String cstTemplateObjectText = "***TEMPLATE***";
        #endregion

        #region variables
        protected BaseModuleERP _module;
        protected BusinessObject _mainObject;
        protected BusinessObjectCollection _moduleObjects;
        protected BindingSource _mainObjectBindingSource;
        protected BindingSourceCollection _moduleObjectsBindingSource;

        private bool IsValid = true;
        private Dictionary<string, int> ListOfFirstID;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the module that the entity belongs to
        /// </summary>
        public BaseModuleERP Module
        {
            get { return _module; }
            set { _module = value; }
        }

        /// <summary>
        /// Gets or sets the search object of the module
        /// </summary>
        public BusinessObject SearchObject { get; set; }

        /// <summary>
        /// Gets or sets the main object of the module
        /// </summary>
        public BusinessObject MainObject
        {
            get { return _mainObject; }
            set { _mainObject = value; }
        }

        /// <summary>
        /// Gets or sets the list of module objects of the module
        /// </summary>
        public BusinessObjectCollection ModuleObjects
        {
            get { return _moduleObjects; }
            set { _moduleObjects = value; }
        }

        /// <summary>
        /// Gets or sets the binding source of the search object
        /// </summary>
        public BindingSource SearchObjectBindingSource { get; set; }

        /// <summary>
        /// Gets or sets the binding source of the main object
        /// </summary>
        public BindingSource MainObjectBindingSource
        {
            get { return _mainObjectBindingSource; }
            set { _mainObjectBindingSource = value; }
        }

        /// <summary>
        /// Gets or sets the list of binding sources of the module objects
        /// </summary>
        public BindingSourceCollection ModuleObjectsBindingSource
        {
            get { return _moduleObjectsBindingSource; }
            set { _moduleObjectsBindingSource = value; }
        }
        #endregion

        #region Constructor
        public ERPModuleEntities()
        {
            MainObjectBindingSource = new BindingSource();
            ModuleObjects = new BusinessObjectCollection();
            ModuleObjectsBindingSource = new BindingSourceCollection();
            ListOfFirstID = new Dictionary<string, int>();
        }

        public virtual void InitModuleEntity()
        {
            InitMainObject();
            InitModuleObjects();
            InitModuleObjectList();

            InitMainObjectBindingSource();
            InitModuleObjectsBindingSource();
        }

        public virtual void InitGridControlInBOSList()
        {

        }

        #endregion

        #region Init MainObject, ModuleObjects Functions

        public virtual void InitMainObject()
        {

        }

        /// <summary type="Initialize">
        /// Initialize Module Objects
        /// </summary>
        public virtual void InitModuleObjects()
        {

        }

        public virtual void InitModuleObjectList()
        {

        }


        /// <summary type="Initialize">
        /// Initialize Current Object Binding Source
        /// </summary>
        public virtual void InitMainObjectBindingSource()
        {
            if (MainObject != null)
            {
                MainObjectBindingSource.DataSource = MainObject;
            }
            if (SearchObject != null)
            {
                SearchObjectBindingSource = new BindingSource();
                SearchObjectBindingSource.DataSource = SearchObject;
            }
        }

        /// <summary type="Initialize">
        /// Initialize Module Objects Binding Source
        /// </summary>
        public virtual void InitModuleObjectsBindingSource()
        {
            try
            {
                foreach (DictionaryEntry de in ModuleObjects)
                {
                    BindingSource bds = new BindingSource();
                    bds.DataSource = ModuleObjects[de.Key.ToString()].GetType();
                    ModuleObjectsBindingSource.Add(de.Key.ToString(), bds);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this.GetType().FullName + "-InitModuleObjectsBindingSource-" + e.Message);
            }
        }

        #endregion

        #region Register Module Object Event
        /// <summary type="ObjectRule">
        /// Create Module Object Rule
        /// </summary>
        /// <functiontype>Create Object Rule</functiontype>
        public virtual void CreateMainObjectRule()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);

            DataSet dsColumns = dbUtil.GetNotAllowNullTableColumns(strMainObjectTableName);

            if (dsColumns.Tables.Count > 0)
            {
                AAColumnAliasController objColumnAlliasController = new AAColumnAliasController();
                foreach (DataRow rowColumn in dsColumns.Tables[0].Rows)
                {
                    String strColumnName = rowColumn["COLUMN_NAME"].ToString();
                    String strBrokenRuleDescription = String.Empty;
                    //Add rule if column is not primary key
                    if (!dbUtil.IsPrimaryKey(strMainObjectTableName, strColumnName))
                    {
                        //If column does not allow null
                        if (!dbUtil.ColumnIsAllowNull(strMainObjectTableName, strColumnName))
                        {
                            AAColumnAliasInfo objColumnAliasInfo = BOSApp.LstColumnAlias.Where(a => a.AATableName == strMainObjectTableName
                            && a.AAColumnAliasName == strColumnName).FirstOrDefault();
                            if (objColumnAliasInfo != null)
                            {
                                strBrokenRuleDescription = String.Format(string.Format(BaseLocalizedResources.ColumnRequiredMessage, objColumnAliasInfo.AAColumnAliasCaption));
                            }
                            else
                            {
                                strBrokenRuleDescription = String.Format(string.Format(BaseLocalizedResources.ColumnRequiredMessage, strColumnName));
                            }

                            if (((IBaseModuleERP)Module).IsForeignKey(strMainObjectTableName, strColumnName))
                            {
                                BusinessRule foreignKeyRule = new BusinessRule(
                                                                    strColumnName,
                                                                    strBrokenRuleDescription,
                                                                    IsValidForeignKeyProperty);
                                MainObject.BusinessRuleCollections.Add(foreignKeyRule);
                            }
                            else
                            {
                                BusinessRule nonForeignKeyRule = new BusinessRule(strColumnName, strBrokenRuleDescription, IsValidNonForeignKeyPropety);
                                MainObject.BusinessRuleCollections.Add(nonForeignKeyRule);
                            }
                        }
                    }
                }
            }
            dsColumns.Dispose();
        }

        protected List<BusinessRule> BackupMainObjectBusinessRule()
        {
            List<BusinessRule> mainObjectRules = new List<BusinessRule>();
            foreach (BusinessRule rule in MainObject.BusinessRuleCollections)
            {
                mainObjectRules.Add(rule);
            }
            return mainObjectRules;
        }

        protected void RestoreMainObjectBusinessRule(List<BusinessRule> mainObjectRules)
        {
            foreach (BusinessRule rule in mainObjectRules)
            {
                MainObject.BusinessRuleCollections.Add(rule);
            }
        }


        public bool IsValidForeignKeyProperty(String strForeignKeyColumn)
        {
            try
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                //String strMainObjectTableName = MainObject.GetType().Name.Substring(0, MainObject.GetType().Name.Length - 4);
                String strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
                String strPrimaryTable = ((IBaseModuleERP)Module).GetTreePrimaryTableWhichForeignColumnReferenceTo(strMainObjectTableName, strForeignKeyColumn);
                String strPrimaryColumn = ((IBaseModuleERP)Module).GetTreePrimaryTableWhichForeignColumnReferenceTo(strMainObjectTableName, strForeignKeyColumn);
                IBusinessController objPrimaryTableObjectController = BusinessControllerFactory.GetBusinessController(strPrimaryTable + "Controller");
                int iForeignKeyColumnValue = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, strForeignKeyColumn));
                if (iForeignKeyColumnValue > 0 && objPrimaryTableObjectController != null)
                    return objPrimaryTableObjectController.IsExist(iForeignKeyColumnValue);
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool IsValidNonForeignKeyPropety(String strNonForeignKeyColumn)
        {
            try
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                PropertyInfo property = MainObject.GetType().GetProperty(strNonForeignKeyColumn);
                if (property.PropertyType.Equals(typeof(int)))
                {
                    object objPropertyValue = dbUtil.GetPropertyValue(MainObject, strNonForeignKeyColumn);
                    int iConvert = Convert.ToInt32(objPropertyValue);
                    return true;
                }
                else if (property.PropertyType.Equals(typeof(double)))
                {
                    object objPropertyValue = dbUtil.GetPropertyValue(MainObject, strNonForeignKeyColumn);
                    double dbConvert = Convert.ToDouble(objPropertyValue);
                    return true;
                }
                else if (property.PropertyType.Equals(typeof(decimal)))
                {
                    object objPropertyValue = dbUtil.GetPropertyValue(MainObject, strNonForeignKeyColumn);
                    decimal dcConvert = Convert.ToDecimal(objPropertyValue);
                    return true;
                }
                else if (property.PropertyType.Equals(typeof(short)))
                {
                    object objPropertyValue = dbUtil.GetPropertyValue(MainObject, strNonForeignKeyColumn);
                    short sConvert = Convert.ToInt16(objPropertyValue);
                    return true;
                }
                else if (property.PropertyType.Equals(typeof(bool)))
                {
                    object objPropertyValue = dbUtil.GetPropertyValue(MainObject, strNonForeignKeyColumn);
                    bool bConvert = Convert.ToBoolean(objPropertyValue);
                    return true;
                }
                else if (property.PropertyType.Equals(typeof(DateTime)))
                {
                    object objPropertyValue = dbUtil.GetPropertyValue(MainObject, strNonForeignKeyColumn);
                    DateTime dtConvert = Convert.ToDateTime(objPropertyValue);
                    return true;
                }
                else if (property.PropertyType.Equals(typeof(string)) || property.PropertyType.Equals(typeof(String)))
                {
                    object objPropertyValue = dbUtil.GetPropertyValue(MainObject, strNonForeignKeyColumn);
                    String strConvert = Convert.ToString(objPropertyValue);
                    if (!String.IsNullOrEmpty(strConvert))
                        return true;
                    else
                        return false;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }

        /// <summary type="ObjectEvent">
        /// Subcribe Main Object Event
        /// </summary>        
        public void SubcribeMainObjectEvent()
        {
            MainObject.PropertyChanged += new PropertyChangedEventHandler(MainObject_OnChanged);
        }

        /// <summary>
        /// Subcribe Module object Event
        /// </summary>
        public void SubcribeModueObjectEvent(String strModuleObjectName)
        {
            ModuleObjects[strModuleObjectName].PropertyChanged += new PropertyChangedEventHandler(ModuleObject_OnChanged);
        }

        /// <summary type="ObjectEvent">
        /// Delegate Function for Event Valid of Module Object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void ModuleObject_OnValid(object sender, EventArgs e)
        {
            if (!Module.Toolbar.IsNullOrNoneAction())
            {
                DevExpress.XtraBars.BarButtonItem barbtnSave = Module.ParentScreen.GetToolbarButton(
                                                                            BaseToolbar.ToolbarAction,
                                                                            BaseToolbar.ToolbarButtonSave);
                DevExpress.XtraBars.BarButtonItem barbtnDelete = Module.ParentScreen.GetToolbarButton(
                                                                                BaseToolbar.ToolbarAction,
                                                                                BaseToolbar.ToolbarButtonDelete);
                if (barbtnSave != null)
                    barbtnSave.Enabled = true;
                if (barbtnDelete != null)
                {
                    if (Module.Toolbar.ModusAction == BaseToolbar.ModusEdit)
                        barbtnDelete.Enabled = true;
                }
                IsValid = true;
            }
        }

        /// <summary type="ObjectEvent">
        /// Delegate Function for Event Invalid of Module Object
        /// </summary>        
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModuleObject_OnInvalid(object sender, EventArgs e)
        {
            if (!Module.Toolbar.IsNullOrNoneAction())
            {
                DevExpress.XtraBars.BarButtonItem barbtnSave = Module.ParentScreen.GetToolbarButton(
                                                                                BaseToolbar.ToolbarAction,
                                                                                BaseToolbar.ToolbarButtonSave);
                DevExpress.XtraBars.BarButtonItem barbtnDelete = Module.ParentScreen.GetToolbarButton(
                                                                                BaseToolbar.ToolbarAction,
                                                                                BaseToolbar.ToolbarButtonDelete);
                if (barbtnSave != null)
                    barbtnSave.Enabled = false;
                if (barbtnDelete != null)
                    barbtnDelete.Enabled = false;
                IsValid = false;
            }
        }


        /// <summary type="ObjectEvent">
        /// Delegate Function for Event Invalid of Main Object
        /// </summary>        
        public virtual void MainObject_OnChanged(object sender, PropertyChangedEventArgs e)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            object changedValue = dbUtil.GetPropertyValue((BusinessObject)sender, e.PropertyName);
            if (Module.SwitchToEditMode((BusinessObject)sender, e.PropertyName))
            {
                dbUtil.SetPropertyValue(MainObject, e.PropertyName, changedValue);
                UpdateMainObjectBindingSource();
            }
        }

        /// <summary type="ObjectEvent">
        /// Delegate Function for Event Invalid of Module Object
        /// </summary>        
        public virtual void ModuleObject_OnChanged(object sender, PropertyChangedEventArgs e)
        {
            string tableName = BOSUtil.GetTableNameFromBusinessObject((BusinessObject)sender);
            if (ModuleObjects[tableName] != null && ModuleObjects[tableName].Equals(sender))
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                object changedValue = dbUtil.GetPropertyValue((BusinessObject)sender, e.PropertyName);
                if (Module.SwitchToEditMode((BusinessObject)sender, e.PropertyName))
                {
                    dbUtil.SetPropertyValue(ModuleObjects[tableName], e.PropertyName, changedValue);
                    UpdateModuleObjectBindingSource(tableName);
                }
            }
        }

        /// <summary>
        /// Lock property change event, prevent it from raising continuously in action chain
        /// </summary
        public void SetPropertyChangeEventLock(bool allow)
        {
            MainObject.AllowPropertyChangedEvent = allow;
            foreach (BusinessObject moduleObject in ModuleObjects.Values)
            {
                moduleObject.AllowPropertyChangedEvent = allow;
            }
        }

        private void RefreshControl(String strPropertyName, STFieldsInfo objSTFieldsInfo)
        {
            String strMainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            object objPropertyValue = new BOSDbUtil().GetPropertyValue(MainObject, strPropertyName);
            String strControlType = objSTFieldsInfo.STFieldType;
            Control ctrl = Module.Controls[objSTFieldsInfo.STFieldName];
            if (strControlType.Equals("BOSTextBox"))
                ctrl.Text = objPropertyValue.ToString();
            else if (strControlType.Equals("BOSComboBox"))
                (ctrl as DevExpress.XtraEditors.ComboBoxEdit).EditValue = objPropertyValue;
            else if (strControlType.Equals("BOSLookupEdit"))
                (ctrl as DevExpress.XtraEditors.LookUpEdit).EditValue = objPropertyValue;
            else if (strControlType.Equals("BOSDateEdit"))
                (ctrl as DevExpress.XtraEditors.DateEdit).DateTime = Convert.ToDateTime(objPropertyValue);
            else if (strControlType.Equals("BOSTimeEdit"))
                (ctrl as DevExpress.XtraEditors.TimeEdit).Time = Convert.ToDateTime(objPropertyValue);
            else if (strControlType.Equals("BOSCheckEdit"))
                (ctrl as DevExpress.XtraEditors.CheckEdit).EditValue = objPropertyValue;

            ctrl.Refresh();
        }


        #endregion

        #region Invalidate functions

        public virtual void Invalidate(int iObjectID)
        {
            InvalidateMainObject(iObjectID);
            InvalidateModuleObjects(iObjectID);
        }

        /// <summary type="Invalidate">
        /// Invalidate Current Object
        /// </summary>
        /// <param name="iObjectID"></param>
        public virtual void InvalidateMainObject(int iObjectID)
        {
            List<BusinessRule> mainObjectRules = BackupMainObjectBusinessRule();

            Type typMainObjectType = MainObject.GetType();
            BaseBusinessController objMainObjectController = new BaseBusinessController(typMainObjectType);
            MainObject = (BusinessObject)objMainObjectController.GetObjectByID(iObjectID);

            RestoreMainObjectBusinessRule(mainObjectRules);
            SubcribeMainObjectEvent();

            UpdateMainObjectBindingSource();
        }

        /// <summary>
        /// Update module object to the given business object
        /// then refresh data binding to reflect changes to screen
        /// </summary>
        /// <param name="obj">The given business object</param>
        public virtual void InvalidateModuleObject(BusinessObject obj)
        {
            String strModuleObjectName = BOSUtil.GetTableNameFromBusinessObject(obj);
            if (ModuleObjects[strModuleObjectName] != null)
            {
                ModuleObjects[strModuleObjectName] = obj;
                SubcribeModueObjectEvent(strModuleObjectName);
                UpdateModuleObjectBindingSource(strModuleObjectName);
            }
        }

        /// <summary>
        /// Update module entity item, just convert to business object
        /// and reuse the previous overload function
        /// </summary>
        /// <param name="entItem">The given entity item</param>
        /// <param name="strModuleObjectName">The table name of module object</param>
        public virtual void InvalidateModuleObject(ERPModuleItemsEntity entItem, String strModuleObjectName)
        {
            InvalidateModuleObject(entItem);
        }

        /// <summary type="Invalidate">
        /// Invalidate Module Objects
        /// </summary>
        public virtual void InvalidateModuleObjects(int iObjectID)
        {

        }

        public virtual void InvalidateModuleItemObjectFromModuleItemsEntityList(int iPos)
        {

        }

        #endregion

        #region Set Default Main Object, Module Objects functions

        public virtual void SetDefaultMainObject()
        {
            try
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                List<BusinessRule> mainObjectRules = BackupMainObjectBusinessRule();

                //If not Exist Template object,create new template object
                if (!IsExistTemplateObject())
                {
                    //Renew Current Object
                    String strMainObjectName = MainObject.GetType().Name;
                    MainObject = BusinessObjectFactory.GetBusinessObject(strMainObjectName);

                    //Get Table which Main Object Represent
                    String strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);

                    String strPrimaryColumn = strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "ID";

                    dbUtil.SetPropertyValue(MainObject, strPrimaryColumn.Substring(0, strPrimaryColumn.Length - 2) + "No", cstNewObjectText);

                    //[NUThao] [DELETE] [Improve speed when creating a new object and saving a object] [08/13/2014] [START]
                    ////Set Default Value for all property is foreign column and not allow null
                    //DataSet dsForeignKeys = dbUtil.GetTableForeignKeys(strMainObjectTableName);
                    //if (dsForeignKeys.Tables.Count > 0)
                    //{
                    //    foreach (DataRow rowForeignKey in dsForeignKeys.Tables[0].Rows)
                    //    {
                    //        String strForeignKeyPropertyName = rowForeignKey["COLUMN_NAME"].ToString();
                    //        if (!dbUtil.ColumnIsAllowNull(strMainObjectTableName, strForeignKeyPropertyName))
                    //        {
                    //            String strPrimaryTable = dbUtil.GetPrimaryTableWhichForeignColumnReferenceTo(
                    //                                                strMainObjectTableName,
                    //                                                strForeignKeyPropertyName);
                    //            Type typPrimaryTableObjectType = BusinessObjectFactory.GetBusinessObjectType(strPrimaryTable + "Info");
                    //            //BaseBusinessController objPrimaryTableController = new BaseBusinessController(BusinessObjectFactory.GetBusinessObjectType(strPrimaryTable + "Info"));
                    //            BaseBusinessController objPrimaryTableController = new BaseBusinessController(typPrimaryTableObjectType);

                    //            int iPrimaryTableObjectID = objPrimaryTableController.GetFirstObjectID();
                    //        }
                    //    }
                    //}
                    //[NUThao] [DELETE] [Improve speed when creating a new object and saving a object] [08/13/2014] END
                }
                //If exist template object,copy template object to main object
                else
                {
                    //Get Table which Main Object Represent
                    String strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);

                    String strPrimaryColumn = strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "ID";

                    IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(strMainObjectTableName + "Controller");
                    BusinessObject objTemplateObject = (BusinessObject)objMainObjectController.GetTemplateObject();
                    MainObject = (BusinessObject)objTemplateObject.Clone();
                    dbUtil.SetPropertyValue(MainObject, strPrimaryColumn.Substring(0, strPrimaryColumn.Length - 2) + "No", cstNewObjectText);
                    dbUtil.SetPropertyValue(MainObject, AAStatusColumn, BusinessObject.DefaultAAStatus);
                }

                RestoreMainObjectBusinessRule(mainObjectRules);
                UpdateMainObjectBindingSource();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        /// <summary type="Set">
        /// Set Default Module Objects
        /// </summary>
        public virtual void SetDefaultModuleObjects()
        {
            String[] keysArray = new String[ModuleObjects.Count];
            ModuleObjects.Keys.CopyTo(keysArray, 0);
            for (int i = 0; i < keysArray.Length; i++)
            {
                String strModuleObjectName = keysArray[i].ToString();
                SetDefaultModuleObject(strModuleObjectName);
            }
        }

        public virtual void SetDefaultModuleObject(String strModuleObjectName)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();

            //Renew BusinessObject
            String strModuleObjectTypeName = ModuleObjects[strModuleObjectName].GetType().Name;
            ModuleObjects[strModuleObjectName] = BusinessObjectFactory.GetBusinessObject(strModuleObjectTypeName);

            //Get Table which Business object Represent
            //String strObjectTableName = ModuleObjects[strModuleObjectName].GetType().Name.Substring(0, ModuleObjects[strModuleObjectName].GetType().Name.Length - 4);
            String strObjectTableName = BOSUtil.GetTableNameFromBusinessObject(ModuleObjects[strModuleObjectName]);

            //Set Default Value for all property is foreign column and not allow null
            DataSet dsForeignKeys = dbUtil.GetTableForeignKeys(strObjectTableName);
            if (dsForeignKeys.Tables.Count > 0)
            {
                //[NUThao] [EDIT] [Improve speed when creating a new object and saving a object] [08/13/2014] [START]
                //foreach (DataRow rowForeignKey in dsForeignKeys.Tables[0].Rows)
                //{
                //    String strForeignKeyPropertyName = rowForeignKey["COLUMN_NAME"].ToString();
                //    if (!dbUtil.ColumnIsAllowNull(strObjectTableName, strForeignKeyPropertyName))
                //    {
                //        String strPrimaryTable = dbUtil.GetPrimaryTableWhichForeignColumnReferenceTo(
                //                                            strObjectTableName,
                //                                            strForeignKeyPropertyName);

                //        String strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);                        
                //        if (!strPrimaryTable.Equals(strMainObjectTableName))
                //        {
                //            BaseBusinessController objPrimaryTableController = new BaseBusinessController(BusinessObjectFactory.GetBusinessObjectType(strPrimaryTable + "Info"));

                //            int iPrimaryTableObjectID = objPrimaryTableController.GetFirstObjectID();
                //            dbUtil.SetPropertyValue(
                //                        ModuleObjects[strModuleObjectName],
                //                        strForeignKeyPropertyName,
                //                        iPrimaryTableObjectID);
                //        }
                //    }
                //}

                String strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
                string query = string.Empty;
                foreach (DataRow rowForeignKey in dsForeignKeys.Tables[0].Rows)
                {
                    String strForeignKeyPropertyName = rowForeignKey["COLUMN_NAME"].ToString();
                    if (!dbUtil.ColumnIsAllowNull(strObjectTableName, strForeignKeyPropertyName))
                    {
                        String strPrimaryTable = ((IBaseModuleERP)Module).GetTreePrimaryTableWhichForeignColumnReferenceTo(
                                                            strObjectTableName,
                                                            strForeignKeyPropertyName);
                        if (!strPrimaryTable.Equals(strMainObjectTableName))
                        {
                            int iPrimaryTableObjectID = 0;
                            if (ListOfFirstID.ContainsKey(strPrimaryTable))
                            {
                                iPrimaryTableObjectID = ListOfFirstID[strPrimaryTable];
                            }
                            else
                            {
                                if (strPrimaryTable != string.Empty)
                                {
                                    BaseBusinessController objPrimaryTableController = new BaseBusinessController(BusinessObjectFactory.GetBusinessObjectType(strPrimaryTable + "Info"));
                                    query = string.Format("SELECT top 1 {2} FROM [dbo].[{0}]{1}", strPrimaryTable, " where AAStatus = 'Alive'", SqlDatabaseHelper.GetPrimaryKeyColumn(strPrimaryTable));
                                    DbCommand cmd = SqlDatabaseHelper.GetQuery(query);
                                    DataSet ds = SqlDatabaseHelper.RunQuery(cmd);
                                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                                    {
                                        iPrimaryTableObjectID = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                                    }
                                    ListOfFirstID.Add(strPrimaryTable, iPrimaryTableObjectID);
                                    BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
                                }
                            }
                            dbUtil.SetPropertyValue(
                                        ModuleObjects[strModuleObjectName],
                                        strForeignKeyPropertyName,
                                        iPrimaryTableObjectID);
                        }
                    }
                }
                //[NUThao] [EDIT] [Improve speed when creating a new object and saving a object] [08/13/2014] [END]
            }
            dsForeignKeys.Dispose();
            UpdateModuleObjectBindingSource(strModuleObjectName);

        }

        public virtual void SetDefaultModuleObjectsList()
        {

        }

        public virtual void DuplicateModuleObjectList()
        {

        }
        #endregion

        #region Update Main Object, Module Objects Binding Source Functions
        /// <summary type="Update">
        /// Update Binding Source of Main Object
        /// </summary>        
        public virtual void UpdateMainObjectBindingSource()
        {
            MainObjectBindingSource.DataSource = this.MainObject;
            MainObjectBindingSource.ResetBindings(false);

        }

        /// <summary>
        /// Update the binding source of the search object
        /// </summary>        
        public virtual void UpdateSearchObjectBindingSource()
        {
            SearchObjectBindingSource.DataSource = SearchObject;
            try
            {
                SearchObjectBindingSource.ResetBindings(false);
            }
            catch
            {
                return;
            }

        }

        /// <summary type="Update">
        /// Update Binding Source of Module Objects
        /// </summary>        
        public virtual void UpdateModuleObjectsBindingSource()
        {
            foreach (DictionaryEntry de in ModuleObjects)
            {
                ModuleObjectsBindingSource[de.Key.ToString()].DataSource = de.Value;
            }
        }

        /// <summary type="Update">
        /// Update Binding Source Of Module Object By Module Object Name
        /// </summary>
        /// <param name="strModuleObjectName">Module Object Name will be updated</param>
        public virtual void UpdateModuleObjectBindingSource(String strModuleObjectName)
        {
            try
            {
                if (ModuleObjects[strModuleObjectName] != null && ModuleObjectsBindingSource[strModuleObjectName] != null)
                    ModuleObjectsBindingSource[strModuleObjectName].DataSource = ModuleObjects[strModuleObjectName];
            }
            catch (Exception ex)
            {
                return;
            }
            //ModuleObjectsBindingSource[strModuleObjectName].ResetBindings(false);
        }
        #endregion

        #region Function for create Module Entity
        public virtual String GetMainObjectNo(ref int numberingStart)
        {
            String strMainObjectNo = String.Empty;
            GENumberingController objGENumberingController = new GENumberingController();

            GENumberingInfo objGENumberingInfo;
            objGENumberingInfo = objGENumberingController.GetGENumberingByNameAndBranchID(Module.Name, BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            if (objGENumberingInfo != null)
            {
                strMainObjectNo = objGENumberingInfo.GENumberingFormat;
                DateTime currentDate = BOSApp.GetCurrentServerDate();
                BOSDbUtil dbUtil = new BOSDbUtil();

                if ((objGENumberingInfo.AAUpdatedDate.Year < currentDate.Year && objGENumberingInfo.GENumberingPrefixHaveYear)
                            || (objGENumberingInfo.AAUpdatedDate.Month < currentDate.Month && objGENumberingInfo.GENumberingPrefixHaveMonth)
                            || (objGENumberingInfo.AAUpdatedDate.Day < currentDate.Day && objGENumberingInfo.GENumberingPrefixHaveDay))
                {
                    objGENumberingInfo.GENumberingStart = 1;
                }

                strMainObjectNo = strMainObjectNo.Replace("{1}", objGENumberingInfo.GENumberingPrefix);
                if (objGENumberingInfo.GENumberingPrefixHaveYear)
                {
                    strMainObjectNo = strMainObjectNo.Replace("{2}", currentDate.Year.ToString().Substring(2, 2));
                }
                else
                {
                    strMainObjectNo = strMainObjectNo.Replace("{2}", string.Empty);
                }

                if (objGENumberingInfo.GENumberingPrefixHaveMonth)
                {
                    strMainObjectNo = strMainObjectNo.Replace("{3}", currentDate.Month.ToString().PadLeft(2, '0'));
                }
                else
                {
                    strMainObjectNo = strMainObjectNo.Replace("{3}", string.Empty);
                }

                if (objGENumberingInfo.GENumberingPrefixHaveDay)
                {
                    strMainObjectNo = strMainObjectNo.Replace("{4}", currentDate.Day.ToString().PadLeft(2, '0'));
                }
                else
                {
                    strMainObjectNo = strMainObjectNo.Replace("{4}", string.Empty);
                }

                if (objGENumberingInfo.GENumberingPrefixHaveStock)
                {

                    int stockID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_ICStockID"));
                    ICStocksInfo objStocksInfo = (ICStocksInfo)(new ICStocksController()).GetObjectByID(stockID);
                    strMainObjectNo = strMainObjectNo.Replace("{5}", objStocksInfo.ICStockPrefix);
                }
                else
                {
                    strMainObjectNo = strMainObjectNo.Replace("{5}", string.Empty);
                }

                if (objGENumberingInfo.GENumberingPrefixHaveBankAbbreviation)
                {
                    int companyBankID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_CSCompanyBankID"));
                    CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)(new CSCompanyBanksController()).GetObjectByID(companyBankID);
                    strMainObjectNo = strMainObjectNo.Replace("{6}", objCompanyBanksInfo.CSCompanyBankAbbreviation);
                }
                else
                {
                    strMainObjectNo = strMainObjectNo.Replace("{6}", string.Empty);
                }

                objGENumberingInfo.GENumberingFormat = strMainObjectNo;
                String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
                IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(mainTableName + "Controller");
                if (objMainObjectController != null)
                {
                    strMainObjectNo = objGENumberingInfo.GENumberingFormat.Replace("{7}", objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                    numberingStart = objGENumberingInfo.GENumberingStart;
                    while (objMainObjectController.IsExist(strMainObjectNo))
                    {
                        objGENumberingInfo.GENumberingStart++;
                        strMainObjectNo = objGENumberingInfo.GENumberingFormat.Replace("{7}", objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                        numberingStart = objGENumberingInfo.GENumberingStart;
                    }
                }
            }
            return strMainObjectNo;
        }

        /// <summary>
        /// Get main object number automatically from config
        /// </summary>
        /// <returns>Main object number</returns>
        public virtual string GetMainObjectNo()
        {
            int numberingStart = 0;
            return GetMainObjectNo(ref numberingStart);
        }

        private bool HasExistLookupTable(string tableName)
        {
            bool hasExist = false;
            GELookupTablesController lookupTableController = new GELookupTablesController();
            BOSDbUtil dbUtil = new BOSDbUtil();
            GELookupTablesInfo lookupTable = new GELookupTablesInfo();

            if (BOSApp.LookupTableList != null && BOSApp.LookupTableList.Count > 0)
                lookupTable = BOSApp.LookupTableList.Where(t => t.GELookupTableName == tableName).FirstOrDefault();
            if (lookupTable == null || lookupTable.GELookupTableID == 0)
            {
                lookupTable = lookupTableController.GetObjectByTableName(tableName);
                if (lookupTable != null)
                {
                    if (!BOSApp.LookupTableObjects.Keys.Contains(tableName))
                        BOSApp.LookupTableObjects.Add(tableName, lookupTable);
                    hasExist = true;
                }
            }
            else
                hasExist = true;

            if (!BOSApp.LookupTablesUpdatedDate.ContainsKey(tableName))
                BOSApp.LookupTablesUpdatedDate.Add(tableName, DateTime.MinValue);
            return hasExist;
        }

        public virtual void UpdateLookupTableDataSource()
        {
            String strLookupTable = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            bool hasExist = HasExistLookupTable(strLookupTable);
            if (!hasExist)
                return;

            BOSDbUtil dbUtil = new BOSDbUtil();
            DateTime dtLastCreatedDate = dbUtil.GetLastCreatedDateOfTable(strLookupTable);
            DateTime dtLastUpdatedDate = dbUtil.GetLastUpdatedDateOfTable(strLookupTable);

            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
            TimeSpan cRDate = (dtLastCreatedDate - epoch);
            TimeSpan uDDate = (dtLastUpdatedDate - epoch);
            TimeSpan lKDate = (((DateTime)BOSApp.LookupTablesUpdatedDate[strLookupTable]) - epoch);
            if (cRDate.TotalSeconds > lKDate.TotalSeconds || uDDate.TotalSeconds > lKDate.TotalSeconds)
            {
                //Refesh Data Source
                IBusinessController objLookupTableController = BusinessControllerFactory.GetBusinessController(strLookupTable + "Controller");
                if (objLookupTableController != null)
                {
                    DataSet ds = BOSApp.GetLookupTableData(strLookupTable);
                    if (ds.Tables.Count > 0 && !strLookupTable.IsNullOrWhiteSpace())
                    {
                        DateTime updatedDate = this.Module.GetServerDate();
                        // Update Last Updated Date of Lookup Table
                        BOSApp.LookupTablesUpdatedDate[strLookupTable] = updatedDate;
                        if (!BOSApp.LookupTables.ContainsKey(strLookupTable))
                        {
                            BOSApp.LookupTables.Add(strLookupTable, ds);
                        }
                        else
                        {
                            ((DataSet)BOSApp.LookupTables[strLookupTable]).Tables.Clear();
                            ((DataSet)BOSApp.LookupTables[strLookupTable]).Tables.Add(ds.Tables[0].Copy());
                        }

                        if (strLookupTable == "ICProducts")
                        {
                            ICProductsController productController = new ICProductsController();
                            BOSApp.CurrentProductList = productController.GetListViewFromDataSet(ds);
                        }
                    }
                    ds.Dispose();
                }
            }
        }
        public virtual int CreateMainObject()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            int iObjectID = 0;
            bool editObjectNo = true;

            //Get Table which Business object Represent            
            String strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(strMainObjectTableName + "Controller");

            //Set Object No value
            String strPrimaryColumn = strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "ID";
            String strColumnNo = strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "No";
            String strMainObjectNo = dbUtil.GetPropertyStringValue(MainObject, strColumnNo);
            int numberingStart = 0;
            try
            {
                if (strMainObjectNo.Equals(cstNewObjectText))
                {
                    editObjectNo = false;
                    strMainObjectNo = GetMainObjectNo(ref numberingStart);
                    dbUtil.SetPropertyValue(MainObject, strColumnNo, strMainObjectNo);
                }

                //Set Created User, Created Date
                dbUtil.SetPropertyValue(MainObject, AACreatedUser, BOSApp.CurrentUser);
                dbUtil.SetPropertyValue(MainObject, AACreatedDate, BOSApp.GetCurrentServerDate());
                iObjectID = dbUtil.GetPropertyIntValue(MainObject, strPrimaryColumn);
                if (iObjectID == 0)
                {
                    int employeeID = dbUtil.GetPropertyIntValue(MainObject, "FK_HREmployeeID");
                    if (employeeID == 0)
                        dbUtil.SetPropertyValue(MainObject, "FK_HREmployeeID", BOSApp.CurrentUsersInfo.FK_HREmployeeID);

                    iObjectID = objMainObjectController.CreateObject(MainObject);
                }
                else
                {
                    objMainObjectController.CreateObject(MainObject, iObjectID);
                }

                if (iObjectID > 0)
                {
                    //TNDLoc - HISTORY, START
                    string modulePrefix = strMainObjectTableName.Substring(0, 2);
                    #region AR
                    if (modulePrefix == "AR")
                    {
                        ARHistorysController objHistorysController = new ARHistorysController();
                        ARHistorysInfo objHistorysInfo = new ARHistorysInfo();
                        objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                        objHistorysInfo.ARHistoryObjectName = strMainObjectTableName;
                        objHistorysInfo.ARHistoryObjectNo = strMainObjectNo;
                        objHistorysInfo.ARHistoryAction = "Create";
                        objHistorysInfo.ARHistoryDate = BOSApp.GetCurrentServerDate();
                        objHistorysInfo.ARHistoryObjectID = iObjectID;
                        objHistorysController.CreateObject(objHistorysInfo);

                    }
                    #endregion
                    #region AP
                    else if (modulePrefix == "AP")
                    {
                        APHistorysController objHistorysController = new APHistorysController();
                        APHistorysInfo objHistorysInfo = new APHistorysInfo();
                        objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                        objHistorysInfo.APHistoryObjectName = strMainObjectTableName;
                        objHistorysInfo.APHistoryObjectNo = strMainObjectNo;
                        objHistorysInfo.APHistoryAction = "Create";
                        objHistorysInfo.APHistoryDate = BOSApp.GetCurrentServerDate();
                        objHistorysInfo.APHistoryObjectID = iObjectID;
                        objHistorysController.CreateObject(objHistorysInfo);

                    }
                    #endregion
                    #region IC
                    else if (modulePrefix == "IC")
                    {
                        ICHistorysController objHistorysController = new ICHistorysController();
                        ICHistorysInfo objHistorysInfo = new ICHistorysInfo();
                        objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                        objHistorysInfo.ICHistoryObjectName = strMainObjectTableName;
                        objHistorysInfo.ICHistoryObjectNo = strMainObjectNo;
                        objHistorysInfo.ICHistoryAction = "Create";
                        objHistorysInfo.ICHistoryDate = BOSApp.GetCurrentServerDate();
                        objHistorysInfo.ICHistoryObjectID = iObjectID;
                        objHistorysController.CreateObject(objHistorysInfo);

                    }
                    #endregion

                    #region MM
                    else if (modulePrefix == "MM")
                    {
                        MMHistorysController objHistorysController = new MMHistorysController();
                        MMHistorysInfo objHistorysInfo = new MMHistorysInfo();
                        objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                        objHistorysInfo.MMHistoryObjectName = strMainObjectTableName;
                        objHistorysInfo.MMHistoryObjectNo = strMainObjectNo;
                        objHistorysInfo.MMHistoryAction = "Create";
                        objHistorysInfo.MMHistoryDate = BOSApp.GetCurrentServerDate();
                        objHistorysInfo.MMHistoryObjectID = iObjectID;
                        objHistorysController.CreateObject(objHistorysInfo);

                    }
                    #endregion
                    #region AC
                    else if (modulePrefix == "AC")
                    {
                        ACHistorysController objHistorysController = new ACHistorysController();
                        ACHistorysInfo objHistorysInfo = new ACHistorysInfo();
                        objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                        objHistorysInfo.ACHistoryObjectName = strMainObjectTableName;
                        objHistorysInfo.ACHistoryObjectNo = strMainObjectNo;
                        objHistorysInfo.ACHistoryAction = "Create";
                        objHistorysInfo.ACHistoryDate = BOSApp.GetCurrentServerDate();
                        objHistorysInfo.ACHistoryObjectID = iObjectID;
                        objHistorysController.CreateObject(objHistorysInfo);

                    }
                    #endregion

                    #region BR
                    else if (modulePrefix == "BR")
                    {
                        BRHistorysController objHistorysController = new BRHistorysController();
                        BRHistorysInfo objHistorysInfo = new BRHistorysInfo();
                        objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                        objHistorysInfo.BRHistoryObjectName = strMainObjectTableName;
                        objHistorysInfo.BRHistoryObjectNo = strMainObjectNo;
                        objHistorysInfo.BRHistoryAction = "Create";
                        objHistorysInfo.BRHistoryDate = BOSApp.GetCurrentServerDate();
                        objHistorysInfo.BRHistoryObjectID = iObjectID;
                        objHistorysController.CreateObject(objHistorysInfo);

                    }
                    #endregion

                    #region AD
                    else if (modulePrefix == "AD")
                    {
                        ADHistorysController objHistorysController = new ADHistorysController();
                        ADHistorysInfo objHistorysInfo = new ADHistorysInfo();
                        objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                        objHistorysInfo.ADHistoryObjectName = strMainObjectTableName;
                        objHistorysInfo.ADHistoryObjectNo = strMainObjectNo;
                        objHistorysInfo.ADHistoryAction = "Create";
                        objHistorysInfo.ADHistoryDate = BOSApp.GetCurrentServerDate();
                        objHistorysInfo.ADHistoryObjectID = iObjectID;
                        objHistorysController.CreateObject(objHistorysInfo);

                    }
                    #endregion

                    #region VM
                    else if (modulePrefix == "VM")
                    {
                        VMHistorysController objHistorysController = new VMHistorysController();
                        VMHistorysInfo objHistorysInfo = new VMHistorysInfo();
                        objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                        objHistorysInfo.VMHistoryObjectName = strMainObjectTableName;
                        objHistorysInfo.VMHistoryObjectNo = strMainObjectNo;
                        objHistorysInfo.VMHistoryAction = "Create";
                        objHistorysInfo.VMHistoryDate = DateTime.Now;
                        objHistorysInfo.VMHistoryObjectID = iObjectID;
                        objHistorysController.CreateObject(objHistorysInfo);

                    }
                    #endregion
                    //TNDLoc - HISTORY, END
                    if (!editObjectNo)
                    {
                        UpdateObjectNumbering(numberingStart);
                    }

                    String strMainObjectPrimaryColumnName = BOSApp.GetTablePrimaryColumn(strMainObjectTableName);
                    dbUtil.SetPropertyValue(MainObject, strMainObjectPrimaryColumnName, iObjectID);
                }
            }
            catch (Exception ex)
            {
                if (!editObjectNo)
                {
                    dbUtil.SetPropertyValue(MainObject, strColumnNo, cstNewObjectText);
                    dbUtil.SetPropertyValue(MainObject, strPrimaryColumn, 0);
                }

                iObjectID = 0;
                MessageBox.Show(ex.Message.ToString());
            }

            return iObjectID;
        }

        /// <summary type="Save">
        /// Update Current Object
        /// </summary>
        /// <returns></returns>
        public virtual int UpdateMainObject()
        {
            int iObjectID = 0;
            String strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(strMainObjectTableName + "Controller");

            //Set AAUpdatedUser, AAUpdatedDate
            BOSDbUtil dbUtil = new BOSDbUtil();
            dbUtil.SetPropertyValue(MainObject, AAUpdatedUser, BOSApp.CurrentUser);
            dbUtil.SetPropertyValue(MainObject, AAUpdatedDate, DateTime.Now);
            //TNDLoc - HISTORY, START
            int objectID = int.Parse(dbUtil.GetPropertyValue(MainObject, strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "ID").ToString());
            var mainObject = objMainObjectController.GetObjectByID(objectID);
            //TNDLoc - HISTORY, END
            iObjectID = objMainObjectController.UpdateObject(MainObject);

            //TNDLoc - HISTORY, START
            List<AAColumnAliasInfo> columnAliasList = BOSApp.LstColumnAlias.Where(a => a.AATableName == strMainObjectTableName).ToList();

            string modulePrefix = strMainObjectTableName.Substring(0, 2);
            #region AR
            if (modulePrefix == "AR")
            {
                List<ARHistorysInfo> historyList = new List<ARHistorysInfo>();
                foreach (AAColumnAliasInfo alias in columnAliasList)
                {

                    string oldValue = "";
                    string newValue = "";
                    if (dbUtil.GetPropertyValue(mainObject, alias.AAColumnAliasName) != null)
                    {
                        oldValue = dbUtil.GetPropertyValue(mainObject, alias.AAColumnAliasName).ToString();
                    }

                    if (dbUtil.GetPropertyValue(MainObject, alias.AAColumnAliasName) != null)
                    {
                        newValue = dbUtil.GetPropertyValue(MainObject, alias.AAColumnAliasName).ToString();
                    }
                    if (oldValue != newValue)
                    {
                        ARHistorysInfo objHistorysInfo = new ARHistorysInfo();
                        objHistorysInfo.ARHistoryColumnName = alias.AAColumnAliasName;
                        objHistorysInfo.ARHistoryOldValue = oldValue;
                        objHistorysInfo.ARHistoryNewValue = newValue;
                        historyList.Add(objHistorysInfo);
                    }
                }
                if (historyList.Count > 0)
                {
                    foreach (ARHistorysInfo objHistorysInfo in historyList)
                    {
                        objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                        objHistorysInfo.ARHistoryObjectName = strMainObjectTableName;
                        string no = "";
                        if (dbUtil.GetPropertyValue(MainObject, strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "No") != null)
                        {
                            no = dbUtil.GetPropertyValue(MainObject, strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "No").ToString();
                        }
                        objHistorysInfo.ARHistoryObjectNo = no;
                        objHistorysInfo.ARHistoryAction = "Change";
                        objHistorysInfo.ARHistoryDate = BOSApp.GetCurrentServerDate();
                        objHistorysInfo.ARHistoryObjectID = iObjectID;
                    }

                    STToolbarsController rController = new STToolbarsController();
                    List<string> colList = rController.UserDefinedTableTypeColumnName("Type_ARHistorys");
                    DataTable newTable = CollectionExtensions.AsDataTable<ARHistorysInfo>(historyList, colList);
                    if (newTable.Rows.Count > 0)
                        SqlDatabaseHelper.SaveItemObject(newTable, 0, modulePrefix + "Historys", "Create", string.Empty);
                }
            }
            #endregion

            #region AP
            else if (modulePrefix == "AP")
            {
                List<APHistorysInfo> historyList = new List<APHistorysInfo>();
                foreach (AAColumnAliasInfo alias in columnAliasList)
                {

                    string oldValue = "";
                    string newValue = "";
                    if (dbUtil.GetPropertyValue(mainObject, alias.AAColumnAliasName) != null)
                    {
                        oldValue = dbUtil.GetPropertyValue(mainObject, alias.AAColumnAliasName).ToString();
                    }

                    if (dbUtil.GetPropertyValue(MainObject, alias.AAColumnAliasName) != null)
                    {
                        newValue = dbUtil.GetPropertyValue(MainObject, alias.AAColumnAliasName).ToString();
                    }
                    if (oldValue != newValue)
                    {
                        APHistorysInfo objHistorysInfo = new APHistorysInfo();
                        objHistorysInfo.APHistoryColumnName = alias.AAColumnAliasName;
                        objHistorysInfo.APHistoryOldValue = oldValue;
                        objHistorysInfo.APHistoryNewValue = newValue;
                        historyList.Add(objHistorysInfo);
                    }
                }
                if (historyList.Count > 0)
                {
                    foreach (APHistorysInfo objHistorysInfo in historyList)
                    {
                        objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                        objHistorysInfo.APHistoryObjectName = strMainObjectTableName;
                        string no = "";
                        if (dbUtil.GetPropertyValue(MainObject, strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "No") != null)
                        {
                            no = dbUtil.GetPropertyValue(MainObject, strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "No").ToString();
                        }
                        objHistorysInfo.APHistoryObjectNo = no;
                        objHistorysInfo.APHistoryAction = "Change";
                        objHistorysInfo.APHistoryDate = BOSApp.GetCurrentServerDate();
                        objHistorysInfo.APHistoryObjectID = iObjectID;
                    }

                    STToolbarsController rController = new STToolbarsController();
                    List<string> colList = rController.UserDefinedTableTypeColumnName("Type_APHistorys");
                    DataTable newTable = CollectionExtensions.AsDataTable<APHistorysInfo>(historyList, colList);
                    if (newTable.Rows.Count > 0)
                        SqlDatabaseHelper.SaveItemObject(newTable, 0, modulePrefix + "Historys", "Create", string.Empty);
                }
            }
            #endregion

            #region IC
            else if (modulePrefix == "IC")
            {
                List<ICHistorysInfo> historyList = new List<ICHistorysInfo>();
                foreach (AAColumnAliasInfo alias in columnAliasList)
                {

                    string oldValue = "";
                    string newValue = "";
                    if (dbUtil.GetPropertyValue(mainObject, alias.AAColumnAliasName) != null)
                    {
                        oldValue = dbUtil.GetPropertyValue(mainObject, alias.AAColumnAliasName).ToString();
                    }

                    if (dbUtil.GetPropertyValue(MainObject, alias.AAColumnAliasName) != null)
                    {
                        newValue = dbUtil.GetPropertyValue(MainObject, alias.AAColumnAliasName).ToString();
                    }
                    if (oldValue != newValue)
                    {
                        ICHistorysInfo objHistorysInfo = new ICHistorysInfo();
                        objHistorysInfo.ICHistoryColumnName = alias.AAColumnAliasName;
                        objHistorysInfo.ICHistoryOldValue = oldValue;
                        objHistorysInfo.ICHistoryNewValue = newValue;
                        historyList.Add(objHistorysInfo);
                    }
                }
                if (historyList.Count > 0)
                {
                    foreach (ICHistorysInfo objHistorysInfo in historyList)
                    {
                        objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                        objHistorysInfo.ICHistoryObjectName = strMainObjectTableName;
                        string no = "";
                        if (dbUtil.GetPropertyValue(MainObject, strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "No") != null)
                        {
                            no = dbUtil.GetPropertyValue(MainObject, strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "No").ToString();
                        }
                        objHistorysInfo.ICHistoryObjectNo = no;
                        objHistorysInfo.ICHistoryAction = "Change";
                        objHistorysInfo.ICHistoryDate = BOSApp.GetCurrentServerDate();
                        objHistorysInfo.ICHistoryObjectID = iObjectID;
                    }

                    STToolbarsController rController = new STToolbarsController();
                    List<string> colList = rController.UserDefinedTableTypeColumnName("Type_ICHistorys");
                    DataTable newTable = CollectionExtensions.AsDataTable<ICHistorysInfo>(historyList, colList);
                    if (newTable.Rows.Count > 0)
                        SqlDatabaseHelper.SaveItemObject(newTable, 0, modulePrefix + "Historys", "Create", string.Empty);
                }
            }
            #endregion
            #region MM
            else if (modulePrefix == "MM")
            {
                List<MMHistorysInfo> historyList = new List<MMHistorysInfo>();
                foreach (AAColumnAliasInfo alias in columnAliasList)
                {

                    string oldValue = "";
                    string newValue = "";
                    if (dbUtil.GetPropertyValue(mainObject, alias.AAColumnAliasName) != null)
                    {
                        oldValue = dbUtil.GetPropertyValue(mainObject, alias.AAColumnAliasName).ToString();
                    }

                    if (dbUtil.GetPropertyValue(MainObject, alias.AAColumnAliasName) != null)
                    {
                        newValue = dbUtil.GetPropertyValue(MainObject, alias.AAColumnAliasName).ToString();
                    }
                    if (oldValue != newValue)
                    {
                        MMHistorysInfo objHistorysInfo = new MMHistorysInfo();
                        objHistorysInfo.MMHistoryColumnName = alias.AAColumnAliasName;
                        objHistorysInfo.MMHistoryOldValue = oldValue;
                        objHistorysInfo.MMHistoryNewValue = newValue;
                        historyList.Add(objHistorysInfo);
                    }
                }

                if (historyList.Count > 0)
                {
                    foreach (MMHistorysInfo objHistorysInfo in historyList)
                    {
                        objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                        objHistorysInfo.MMHistoryObjectName = strMainObjectTableName;
                        string no = "";
                        if (dbUtil.GetPropertyValue(MainObject, strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "No") != null)
                        {
                            no = dbUtil.GetPropertyValue(MainObject, strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "No").ToString();
                        }
                        objHistorysInfo.MMHistoryObjectNo = no;
                        objHistorysInfo.MMHistoryAction = "Change";
                        objHistorysInfo.MMHistoryDate = BOSApp.GetCurrentServerDate();
                        objHistorysInfo.MMHistoryObjectID = iObjectID;
                    }

                    STToolbarsController rController = new STToolbarsController();
                    List<string> colList = rController.UserDefinedTableTypeColumnName("Type_MMHistorys");
                    DataTable newTable = CollectionExtensions.AsDataTable<MMHistorysInfo>(historyList, colList);
                    if (newTable.Rows.Count > 0)
                        SqlDatabaseHelper.SaveItemObject(newTable, 0, modulePrefix + "Historys", "Create", string.Empty);
                }
            }
            #endregion
            #region AC
            else if (modulePrefix == "AC")
            {
                List<ACHistorysInfo> historyList = new List<ACHistorysInfo>();
                foreach (AAColumnAliasInfo alias in columnAliasList)
                {

                    string oldValue = "";
                    string newValue = "";
                    if (dbUtil.GetPropertyValue(mainObject, alias.AAColumnAliasName) != null)
                    {
                        oldValue = dbUtil.GetPropertyValue(mainObject, alias.AAColumnAliasName).ToString();
                    }

                    if (dbUtil.GetPropertyValue(MainObject, alias.AAColumnAliasName) != null)
                    {
                        newValue = dbUtil.GetPropertyValue(MainObject, alias.AAColumnAliasName).ToString();
                    }
                    if (oldValue != newValue)
                    {
                        ACHistorysInfo objHistorysInfo = new ACHistorysInfo();
                        objHistorysInfo.ACHistoryColumnName = alias.AAColumnAliasName;
                        objHistorysInfo.ACHistoryOldValue = oldValue;
                        objHistorysInfo.ACHistoryNewValue = newValue;
                        historyList.Add(objHistorysInfo);
                    }
                }
                if (historyList.Count > 0)
                {
                    foreach (ACHistorysInfo objHistorysInfo in historyList)
                    {
                        objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                        objHistorysInfo.ACHistoryObjectName = strMainObjectTableName;
                        string no = "";
                        if (dbUtil.GetPropertyValue(MainObject, strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "No") != null)
                        {
                            no = dbUtil.GetPropertyValue(MainObject, strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "No").ToString();
                        }
                        objHistorysInfo.ACHistoryObjectNo = no;
                        objHistorysInfo.ACHistoryAction = "Change";
                        objHistorysInfo.ACHistoryDate = BOSApp.GetCurrentServerDate();
                        objHistorysInfo.ACHistoryObjectID = iObjectID;
                    }

                    STToolbarsController rController = new STToolbarsController();
                    List<string> colList = rController.UserDefinedTableTypeColumnName("Type_ACHistorys");
                    DataTable newTable = CollectionExtensions.AsDataTable<ACHistorysInfo>(historyList, colList);
                    if (newTable.Rows.Count > 0)
                        SqlDatabaseHelper.SaveItemObject(newTable, 0, modulePrefix + "Historys", "Create", string.Empty);
                }
            }
            #endregion
            #region BR
            else if (modulePrefix == "BR")
            {
                List<BRHistorysInfo> historyList = new List<BRHistorysInfo>();
                foreach (AAColumnAliasInfo alias in columnAliasList)
                {

                    string oldValue = "";
                    string newValue = "";
                    if (dbUtil.GetPropertyValue(mainObject, alias.AAColumnAliasName) != null)
                    {
                        oldValue = dbUtil.GetPropertyValue(mainObject, alias.AAColumnAliasName).ToString();
                    }

                    if (dbUtil.GetPropertyValue(MainObject, alias.AAColumnAliasName) != null)
                    {
                        newValue = dbUtil.GetPropertyValue(MainObject, alias.AAColumnAliasName).ToString();
                    }
                    if (oldValue != newValue)
                    {
                        BRHistorysInfo objHistorysInfo = new BRHistorysInfo();
                        objHistorysInfo.BRHistoryColumnName = alias.AAColumnAliasName;
                        objHistorysInfo.BRHistoryOldValue = oldValue;
                        objHistorysInfo.BRHistoryNewValue = newValue;
                        historyList.Add(objHistorysInfo);
                    }
                }
                if (historyList.Count > 0)
                {
                    foreach (BRHistorysInfo objHistorysInfo in historyList)
                    {
                        objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                        objHistorysInfo.BRHistoryObjectName = strMainObjectTableName;
                        string no = "";
                        if (dbUtil.GetPropertyValue(MainObject, strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "No") != null)
                        {
                            no = dbUtil.GetPropertyValue(MainObject, strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "No").ToString();
                        }
                        objHistorysInfo.BRHistoryObjectNo = no;
                        objHistorysInfo.BRHistoryAction = "Change";
                        objHistorysInfo.BRHistoryDate = BOSApp.GetCurrentServerDate();
                        objHistorysInfo.BRHistoryObjectID = iObjectID;
                    }

                    STToolbarsController rController = new STToolbarsController();
                    List<string> colList = rController.UserDefinedTableTypeColumnName("Type_BRHistorys");
                    DataTable newTable = CollectionExtensions.AsDataTable<BRHistorysInfo>(historyList, colList);
                    if (newTable.Rows.Count > 0)
                        SqlDatabaseHelper.SaveItemObject(newTable, 0, modulePrefix + "Historys", "Create", string.Empty);
                }
            }
            #endregion
            #region AD
            else if (modulePrefix == "AD")
            {
                List<ADHistorysInfo> historyList = new List<ADHistorysInfo>();
                foreach (AAColumnAliasInfo alias in columnAliasList)
                {

                    string oldValue = "";
                    string newValue = "";
                    if (dbUtil.GetPropertyValue(mainObject, alias.AAColumnAliasName) != null)
                    {
                        oldValue = dbUtil.GetPropertyValue(mainObject, alias.AAColumnAliasName).ToString();
                    }

                    if (dbUtil.GetPropertyValue(MainObject, alias.AAColumnAliasName) != null)
                    {
                        newValue = dbUtil.GetPropertyValue(MainObject, alias.AAColumnAliasName).ToString();
                    }
                    if (oldValue != newValue)
                    {
                        ADHistorysInfo objHistorysInfo = new ADHistorysInfo();
                        objHistorysInfo.ADHistoryColumnName = alias.AAColumnAliasName;
                        objHistorysInfo.ADHistoryOldValue = oldValue;
                        objHistorysInfo.ADHistoryNewValue = newValue;
                        historyList.Add(objHistorysInfo);
                    }
                }
                if (historyList.Count > 0)
                {
                    foreach (ADHistorysInfo objHistorysInfo in historyList)
                    {
                        objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                        objHistorysInfo.ADHistoryObjectName = strMainObjectTableName;
                        string no = "";
                        if (dbUtil.GetPropertyValue(MainObject, strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "No") != null)
                        {
                            no = dbUtil.GetPropertyValue(MainObject, strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "No").ToString();
                        }
                        objHistorysInfo.ADHistoryObjectNo = no;
                        objHistorysInfo.ADHistoryAction = "Change";
                        objHistorysInfo.ADHistoryDate = BOSApp.GetCurrentServerDate();
                    }

                    STToolbarsController rController = new STToolbarsController();
                    List<string> colList = rController.UserDefinedTableTypeColumnName("Type_ADHistorys");
                    DataTable newTable = CollectionExtensions.AsDataTable<ADHistorysInfo>(historyList, colList);
                    if (newTable.Rows.Count > 0)
                        SqlDatabaseHelper.SaveItemObject(newTable, 0, modulePrefix + "Historys", "Create", string.Empty);
                }
            }
            #endregion
            #region VM
            else if (modulePrefix == "VM")
            {
                List<VMHistorysInfo> historyList = new List<VMHistorysInfo>();
                foreach (AAColumnAliasInfo alias in columnAliasList)
                {

                    string oldValue = "";
                    string newValue = "";
                    if (dbUtil.GetPropertyValue(mainObject, alias.AAColumnAliasName) != null)
                    {
                        oldValue = dbUtil.GetPropertyValue(mainObject, alias.AAColumnAliasName).ToString();
                    }

                    if (dbUtil.GetPropertyValue(MainObject, alias.AAColumnAliasName) != null)
                    {
                        newValue = dbUtil.GetPropertyValue(MainObject, alias.AAColumnAliasName).ToString();
                    }
                    if (oldValue != newValue)
                    {
                        VMHistorysInfo objHistorysInfo = new VMHistorysInfo();
                        objHistorysInfo.VMHistoryColumnName = alias.AAColumnAliasName;
                        objHistorysInfo.VMHistoryOldValue = oldValue;
                        objHistorysInfo.VMHistoryNewValue = newValue;
                        historyList.Add(objHistorysInfo);
                    }
                }

                if (historyList.Count > 0)
                {
                    foreach (VMHistorysInfo objHistorysInfo in historyList)
                    {
                        objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                        objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                        objHistorysInfo.VMHistoryObjectName = strMainObjectTableName;
                        string no = "";
                        if (dbUtil.GetPropertyValue(MainObject, strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "No") != null)
                        {
                            no = dbUtil.GetPropertyValue(MainObject, strMainObjectTableName.Substring(0, strMainObjectTableName.Length - 1) + "No").ToString();
                        }
                        objHistorysInfo.VMHistoryObjectNo = no;
                        objHistorysInfo.VMHistoryAction = "Change";
                        objHistorysInfo.VMHistoryDate = BOSApp.GetCurrentServerDate();
                        objHistorysInfo.VMHistoryObjectID = iObjectID;
                    }

                    STToolbarsController rController = new STToolbarsController();
                    List<string> colList = rController.UserDefinedTableTypeColumnName("Type_VMHistorys");
                    DataTable newTable = CollectionExtensions.AsDataTable<VMHistorysInfo>(historyList, colList);
                    if (newTable.Rows.Count > 0)
                        SqlDatabaseHelper.SaveItemObject(newTable, 0, modulePrefix + "Historys", "Create", string.Empty);
                }
            }
            #endregion
            return iObjectID;
        }

        /// <summary type="Save">
        /// Save Main Object
        /// </summary>
        /// <returns></returns>
        public virtual int SaveMainObject()
        {
            int id = 0;
            if (Module.Toolbar.IsNewAction())
                id = CreateMainObject();
            else
                id = UpdateMainObject();
            //UpdateLookupTableDataSource();
            return id;
        }

        public virtual bool IsExistTemplateObject()
        {
            String strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(strMainObjectTableName + "Controller");
            BusinessObject objTemplateObject = (BusinessObject)objMainObjectController.GetTemplateObject();
            if (objTemplateObject != null)
                return true;
            return false;
        }


        public virtual void SaveModuleObjects()
        {

        }

        public virtual void UpdateObjectNumbering(int numberingStart)
        {
            if (numberingStart > 0)
            {
                GENumberingController objGENumberingController = new GENumberingController();
                GENumberingInfo objGENumberingInfo;
                objGENumberingInfo = objGENumberingController.GetGENumberingByNameAndBranchID(Module.Name, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                if (objGENumberingInfo != null)
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    objGENumberingInfo.GENumberingStart = numberingStart + 1;
                    objGENumberingInfo.AAUpdatedDate = BOSApp.GetCurrentServerDate();
                    objGENumberingController.UpdateObject(objGENumberingInfo);
                }
            }
        }
        #endregion

        #region Function for action New,Save,Delete Module Entity
        public virtual void New()
        {
            SetDefaultMainObject();
            SetDefaultModuleObjects();
            SetDefaultModuleObjectsList();
        }

        public virtual void Save()
        {

        }

        public virtual void Delete(int iObjectID)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    IBusinessController objCurrentObjectController = BusinessControllerFactory.GetBusinessController(MainObject.GetType().Name.Substring(0, MainObject.GetType().Name.Length - 4) + "Controller");
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    dbUtil.SetPropertyValue(MainObject, "AAUpdatedDate", DateTime.Now);
                    dbUtil.SetPropertyValue(MainObject, "AAUpdatedUser", BOSApp.CurrentUser);
                    objCurrentObjectController.UpdateObject(MainObject);

                    objCurrentObjectController.DeleteObject(iObjectID);
                    String strTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
                    DeleteObjectRelations(strTableName, iObjectID);
                    scope.Complete();
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                }
            }
        }

        /// <summary>
        /// Delete all relations of deleted object
        /// </summary>
        public virtual void DeleteObjectRelations(String strTableName, int iObjectID)
        {

        }

        public virtual void DeleteModuleObject(String strModuleObjectName, int iObjectID)
        {

        }

        public virtual void SaveMainObjectRelations()
        {

        }

        public virtual void SaveObjectItemRelations(ERPModuleItemsEntity entItems)
        {

        }

        /// <summary>
        /// Complete transaction and update inventory
        /// </summary>
        public virtual bool CompleteTransaction()
        {
            return true;
        }
        #endregion

        #region Utitlity functions
        public List<FATransactionsInfo> CopyFATransactionsList(List<FATransactionsInfo> lstSourceFATransactions)
        {
            List<FATransactionsInfo> lstDestFATransaction = new List<FATransactionsInfo>();
            foreach (FATransactionsInfo objFATransactionsInfo in lstSourceFATransactions)
            {
                FATransactionsInfo objCopyTransactionsInfo = (FATransactionsInfo)objFATransactionsInfo.Clone();
                lstDestFATransaction.Add(objCopyTransactionsInfo);
            }

            return lstDestFATransaction;
        }

        public List<ERPModuleItemsEntity> GetModuleItemsEntityList(String strModuleItemsEntityName)
        {
            List<ERPModuleItemsEntity> lstERPModuleItemsEntity = new List<ERPModuleItemsEntity>();
            foreach (FieldInfo field in this.GetType().GetFields())
            {
                if (field.FieldType.FullName.Contains("System.Collections.Generic"))
                {
                    Type[] arrType = field.FieldType.GetGenericArguments();
                    if (arrType[0].Name.Contains(strModuleItemsEntityName))
                    {
                        try
                        {
                            if (arrType[0].BaseType == typeof(ERPModuleItemsEntity))
                            {
                                lstERPModuleItemsEntity = (List<ERPModuleItemsEntity>)field.GetValue(this);
                                return lstERPModuleItemsEntity;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return null;
                        }
                    }
                }
            }
            return null;
        }

        public List<BusinessObject> GetBusinessObjectList(String strBusinessObjectName)
        {
            List<BusinessObject> lstBusinessObject = new List<BusinessObject>();
            foreach (FieldInfo field in this.GetType().GetFields())
            {
                if (field.FieldType.FullName.Contains("System.Collections.Generic"))
                {
                    Type[] arrType = field.FieldType.GetGenericArguments();
                    try
                    {
                        if (arrType[0].BaseType == typeof(BusinessObject))
                        {
                            lstBusinessObject = (List<BusinessObject>)field.GetValue(this);
                            return lstBusinessObject;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return null;
                    }
                }
            }
            return null;
        }
        #endregion

        /// <summary>
        /// Save history details of an object
        /// </summary>
        /// <param name="objectHistoryID">History id of the object</param>
        /// <param name="oldObject">Old object</param>
        /// <param name="newObject">New object</param>
        public virtual void SaveHistoryDetails(int objectHistoryID, BusinessObject oldObject, BusinessObject newObject)
        {
            object oldValue;
            object newValue;

            GEHistoryDetailsController objHistoryDetailsController = new GEHistoryDetailsController();
            PropertyInfo[] props = oldObject.GetType().GetProperties();
            string tableName = BOSUtil.GetTableNameFromBusinessObject(oldObject);

            List<GEHistoryDetailsInfo> historyDetailsList = new List<GEHistoryDetailsInfo>();
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
                                GEHistoryDetailsInfo objHistoryDetailsInfo = new GEHistoryDetailsInfo();
                                objHistoryDetailsInfo.FK_GEObjectHistoryID = objectHistoryID;
                                objHistoryDetailsInfo.GEHistoryDetailTableName = tableName;
                                objHistoryDetailsInfo.GEHistoryDetailColumnName = propInfo.Name;
                                if (oldValue != null)
                                {
                                    objHistoryDetailsInfo.GEHistoryDetailOldValue = oldValue.ToString().Trim();
                                }
                                if (newValue != null)
                                {
                                    objHistoryDetailsInfo.GEHistoryDetailNewValue = newValue.ToString().Trim();
                                }
                                //objHistoryDetailsController.CreateObject(objHistoryDetailsInfo);
                                historyDetailsList.Add(objHistoryDetailsInfo);
                                //If the field is address line 3, create history details of its sub entries
                                if (propInfo.Name.Contains("AddressLine3"))
                                {
                                    string addressType = string.Empty;
                                    if (propInfo.Name.Contains(AddressType.Contact.ToString()))
                                    {
                                        addressType = AddressType.Contact.ToString();
                                    }
                                    else if (propInfo.Name.Contains(AddressType.Delivery.ToString()))
                                    {
                                        addressType = AddressType.Delivery.ToString();
                                    }
                                    else if (propInfo.Name.Contains(AddressType.Invoice.ToString()))
                                    {
                                        addressType = AddressType.Invoice.ToString();
                                    }
                                    else if (propInfo.Name.Contains(AddressType.Payment.ToString()))
                                    {
                                        addressType = AddressType.Payment.ToString();
                                    }
                                    if (!string.IsNullOrEmpty(addressType))
                                    {
                                        SaveAddressHistoryDetails(objectHistoryID, objHistoryDetailsInfo.GEHistoryDetailID, oldObject, newObject, addressType);
                                        PropertyInfo[] props2 = typeof(ARCustomersInfo).GetProperties();
                                        string tableName2 = BOSUtil.GetTableNameFromBusinessObject(oldObject);
                                        BOSDbUtil dbUtil = new BOSDbUtil();
                                        foreach (PropertyInfo propInfo2 in props2)
                                        {
                                            GEHistoryDetailsInfo objHistoryDetailsInfo2 = new GEHistoryDetailsInfo();
                                            objHistoryDetailsInfo2.FK_GEObjectHistoryID = objectHistoryID;
                                            objHistoryDetailsInfo2.GEHistoryDetailTableName = tableName2;
                                            objHistoryDetailsInfo2.GEHistoryDetailColumnName = propInfo2.Name;
                                            if (propInfo.Name.Contains(addressType + "Address") && !propInfo.Name.Contains(addressType + "AddressLine3"))
                                            {
                                                object oldValue2 = dbUtil.GetPropertyValue(oldObject, propInfo.Name);
                                                object newValue2 = dbUtil.GetPropertyValue(newObject, propInfo.Name);
                                                if (oldValue != null)
                                                {
                                                    objHistoryDetailsInfo.GEHistoryDetailOldValue = oldValue2.ToString().Trim();
                                                }
                                                if (newValue != null)
                                                {
                                                    objHistoryDetailsInfo.GEHistoryDetailNewValue = newValue2.ToString().Trim();
                                                }
                                                //objHistoryDetailsController.CreateObject(objHistoryDetailsInfo);
                                                historyDetailsList.Add(objHistoryDetailsInfo2);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            STToolbarsController rController = new STToolbarsController();
            List<string> colList = rController.UserDefinedTableTypeColumnName("Type_GEHistoryDetails");

            DataTable newTable = CollectionExtensions.AsDataTable<GEHistoryDetailsInfo>(historyDetailsList, colList);
            if (newTable.Rows.Count > 0)
                SqlDatabaseHelper.SaveItemObject(newTable, 0, "GEHistoryDetails", "Create", string.Empty);
        }

        /// <summary>
        /// Save history details of an object
        /// </summary>
        /// <param name="objectHistoryID">History id of the object</param>
        /// <param name="objProductOldBranchPricesInfo">Old price</param>
        /// <param name="objProductNewBranchPricesInfo">new price</param>
        public virtual void SaveBranchPriceHistory(int objectHistoryID, ICProductBranchPricesInfo objProductOldBranchPricesInfo, ICProductBranchPricesInfo objProductNewBranchPricesInfo)
        {
            GEHistoryDetailOfProductBranchPricesController objHistoryDetailOfProductBranchPricesController = new GEHistoryDetailOfProductBranchPricesController();
            GEHistoryDetailOfProductBranchPricesInfo objHistoryDetailOfProductBranchPricesInfo = new GEHistoryDetailOfProductBranchPricesInfo();
            objHistoryDetailOfProductBranchPricesInfo.FK_GEObjectHistoryID = objectHistoryID;
            objHistoryDetailOfProductBranchPricesInfo.AAStatus = objProductOldBranchPricesInfo.AAStatus;
            objHistoryDetailOfProductBranchPricesInfo.FK_BRBranchID = objProductOldBranchPricesInfo.FK_BRBranchID;
            objHistoryDetailOfProductBranchPricesInfo.FK_GECurrencyID = objProductOldBranchPricesInfo.FK_GECurrencyID;
            objHistoryDetailOfProductBranchPricesInfo.GEHistoryDetailOfProductBranchPriceOldValue = objProductOldBranchPricesInfo.ICProductBranchPrice;
            objHistoryDetailOfProductBranchPricesInfo.GEHistoryDetailOfProductBranchPriceNewValue = objProductNewBranchPricesInfo.ICProductBranchPrice;
            objHistoryDetailOfProductBranchPricesController.CreateObject(objHistoryDetailOfProductBranchPricesInfo);
        }

        /// <summary>
        /// Save history details of sub entries of an address
        /// </summary>
        /// <param name="objectHistoryID">The object history id</param>
        /// <param name="historyDetailParentID">ID of history that the sub history depends on</param>
        /// <param name="oldObject">Old object</param>
        /// <param name="newObject">New object</param>               
        /// <param name="addressType">Address type</param>
        public void SaveAddressHistoryDetails(int objectHistoryID, int historyDetailParentID, BusinessObject oldObject, BusinessObject newObject, string addressType)
        {
            PropertyInfo[] props = typeof(ARCustomersInfo).GetProperties();
            GEHistoryDetailsController objHistoryDetailsController = new GEHistoryDetailsController();
            string tableName = BOSUtil.GetTableNameFromBusinessObject(oldObject);
            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (PropertyInfo propInfo in props)
            {
                GEHistoryDetailsInfo objHistoryDetailsInfo = new GEHistoryDetailsInfo();
                objHistoryDetailsInfo.FK_GEObjectHistoryID = objectHistoryID;
                objHistoryDetailsInfo.GEHistoryDetailTableName = tableName;
                objHistoryDetailsInfo.GEHistoryDetailColumnName = propInfo.Name;
                if (propInfo.Name.Contains(addressType + "Address") && !propInfo.Name.Contains(addressType + "AddressLine3"))
                {
                    object oldValue = dbUtil.GetPropertyValue(oldObject, propInfo.Name);
                    object newValue = dbUtil.GetPropertyValue(newObject, propInfo.Name);
                    if (oldValue != null)
                    {
                        objHistoryDetailsInfo.GEHistoryDetailOldValue = oldValue.ToString().Trim();
                    }
                    if (newValue != null)
                    {
                        objHistoryDetailsInfo.GEHistoryDetailNewValue = newValue.ToString().Trim();
                    }
                    objHistoryDetailsController.CreateObject(objHistoryDetailsInfo);
                }
            }
        }

        /// <summary>
        /// Get product lot no
        /// </summary>
        /// <returns></returns>
        public virtual string GetProductWoodLotNo()
        {
            string year = DateTime.Now.Year.ToString();
            string lotNo = string.Empty;
            if (year.Length >= 4)
                year = year.Substring(2, 2);

            String strMainObjectNo = String.Empty;
            GENumberingController objGENumberingController = new GENumberingController();
            GENumberingInfo objGENumberingInfo = (GENumberingInfo)objGENumberingController.GetObjectByName("ProductWoodSerialNo");
            if (objGENumberingInfo != null)
            {
                lotNo = objGENumberingInfo.GENumberingPrefix + year + objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0');
            }
            return lotNo;
        }
        /// <summary>
        /// Get product lot no
        /// </summary>
        /// <returns></returns>
        public virtual string GetProductLotNo()
        {
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();
            string lotNo = string.Empty;
            if (year.Length >= 4)
                year = year.Substring(2, 2);

            String strMainObjectNo = String.Empty;
            GENumberingController objGENumberingController = new GENumberingController();
            GENumberingInfo objGENumberingInfo = (GENumberingInfo)objGENumberingController.GetObjectByName("ProductSerialNo");
            if (objGENumberingInfo != null)
            {
                //lotNo = objGENumberingInfo.GENumberingPrefix + year + objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0');
                lotNo = GenarateObjectNo(objGENumberingInfo);
            }
            return lotNo;
        }
        public virtual void UpdateProductLotNo(int numberingStart)
        {
            if (numberingStart > 0)
            {
                GENumberingController objGENumberingController = new GENumberingController();
                DateTime currentDate = BOSApp.GetCurrentServerDate();
                GENumberingInfo objGENumberingInfo = (GENumberingInfo)objGENumberingController.GetObjectByName("ProductSerialNo");
                if (objGENumberingInfo != null)
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    if ((objGENumberingInfo.AAUpdatedDate.Year < currentDate.Year && objGENumberingInfo.GENumberingPrefixHaveYear)
                       || (objGENumberingInfo.AAUpdatedDate.Month < currentDate.Month && objGENumberingInfo.GENumberingPrefixHaveMonth)
                       || (objGENumberingInfo.AAUpdatedDate.Day < currentDate.Day && objGENumberingInfo.GENumberingPrefixHaveDay))
                    {
                        objGENumberingInfo.GENumberingStart = 1;
                    }
                    else
                    {
                        objGENumberingInfo.GENumberingStart = objGENumberingInfo.GENumberingStart + 1;
                    }
                    objGENumberingInfo.AAUpdatedDate = currentDate;
                    objGENumberingController.UpdateObject(objGENumberingInfo);
                }
            }
        }

        public virtual void UpdateProductWoodLotNo(int numberingStart)
        {
            if (numberingStart > 0)
            {
                GENumberingController objGENumberingController = new GENumberingController();
                GENumberingInfo objGENumberingInfo = (GENumberingInfo)objGENumberingController.GetObjectByName("ProductWoodSerialNo");
                if (objGENumberingInfo != null)
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    if (objGENumberingInfo.AAUpdatedDate.Year < DateTime.Today.Year)
                    {
                        objGENumberingInfo.GENumberingStart = 1;
                    }
                    else
                    {
                        objGENumberingInfo.GENumberingStart = objGENumberingInfo.GENumberingStart + 1;
                    }
                    objGENumberingController.UpdateObject(objGENumberingInfo);
                }
            }
        }

        private string GenarateObjectNo(GENumberingInfo objGENumberingInfo)
        {
            string strMainObjectNo = objGENumberingInfo.GENumberingFormat;
            DateTime currentDate = BOSApp.GetCurrentServerDate();
            BOSDbUtil dbUtil = new BOSDbUtil();

            if ((objGENumberingInfo.AAUpdatedDate.Year < currentDate.Year && objGENumberingInfo.GENumberingPrefixHaveYear)
                        || (objGENumberingInfo.AAUpdatedDate.Month < currentDate.Month && objGENumberingInfo.GENumberingPrefixHaveMonth)
                        || (objGENumberingInfo.AAUpdatedDate.Day < currentDate.Day && objGENumberingInfo.GENumberingPrefixHaveDay))
            {
                objGENumberingInfo.GENumberingStart = 1;
            }

            strMainObjectNo = strMainObjectNo.Replace("{1}", objGENumberingInfo.GENumberingPrefix);
            if (objGENumberingInfo.GENumberingPrefixHaveYear)
            {
                strMainObjectNo = strMainObjectNo.Replace("{2}", currentDate.Year.ToString().Substring(2, 2));
            }
            else
            {
                strMainObjectNo = strMainObjectNo.Replace("{2}", string.Empty);
            }

            if (objGENumberingInfo.GENumberingPrefixHaveMonth)
            {
                strMainObjectNo = strMainObjectNo.Replace("{3}", currentDate.Month.ToString().PadLeft(2, '0'));
            }
            else
            {
                strMainObjectNo = strMainObjectNo.Replace("{3}", string.Empty);
            }

            if (objGENumberingInfo.GENumberingPrefixHaveDay)
            {
                strMainObjectNo = strMainObjectNo.Replace("{4}", currentDate.Day.ToString().PadLeft(2, '0'));
            }
            else
            {
                strMainObjectNo = strMainObjectNo.Replace("{4}", string.Empty);
            }

            if (objGENumberingInfo.GENumberingPrefixHaveStock)
            {
                int stockID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_ICStockID"));
                ICStocksInfo objStocksInfo = (ICStocksInfo)(new ICStocksController()).GetObjectByID(stockID);
                strMainObjectNo = strMainObjectNo.Replace("{5}", objStocksInfo.ICStockPrefix);
            }
            else
            {
                strMainObjectNo = strMainObjectNo.Replace("{5}", string.Empty);
            }

            if (objGENumberingInfo.GENumberingPrefixHaveBankAbbreviation)
            {
                int companyBankID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_CSCompanyBankID"));
                CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)(new CSCompanyBanksController()).GetObjectByID(companyBankID);
                strMainObjectNo = strMainObjectNo.Replace("{6}", objCompanyBanksInfo.CSCompanyBankAbbreviation);
            }
            else
            {
                strMainObjectNo = strMainObjectNo.Replace("{6}", string.Empty);
            }

            objGENumberingInfo.GENumberingFormat = strMainObjectNo;
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            IBusinessController objMainObjectController = BusinessControllerFactory.GetBusinessController(mainTableName + "Controller");
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            if (objMainObjectController != null)
            {
                strMainObjectNo = objGENumberingInfo.GENumberingFormat.Replace("{7}", objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                int numberingStart = objGENumberingInfo.GENumberingStart;
                while (objProductSeriesController.IsExist(strMainObjectNo))
                {
                    objGENumberingInfo.GENumberingStart++;
                    strMainObjectNo = objGENumberingInfo.GENumberingFormat.Replace("{7}", objGENumberingInfo.GENumberingStart.ToString().PadLeft(objGENumberingInfo.GENumberingLength, '0'));
                    numberingStart = objGENumberingInfo.GENumberingStart;
                }
            }
            return strMainObjectNo;
        }

        public virtual void AfterCompleteTransaction()
        {

        }

        public virtual void AfterSaveTransaction()
        {

        }

        public virtual bool CancelCompleteTransaction()
        {
            return true;
        }
        public virtual string GetMainObjectNoByGenerateProductNoConfig(ref int numberingStart, bool isEditAction)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);

            int backupNumberingStart = numberingStart;

            if (strMainObjectTableName.Equals(TableName.ICProductsTableName))
            {
                ICProductsInfo objProductsInfo = (ICProductsInfo)MainObject;

                GEGenerateProductNoConfigsController objGenerateProductNoConfigsController = new GEGenerateProductNoConfigsController();
                GEGenerateProductNoConfigsInfo objGenerateProductNoConfigsInfo = objGenerateProductNoConfigsController.GetProductNoByDepartmentID(objProductsInfo.FK_ICDepartmentID, BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                if (objGenerateProductNoConfigsInfo == null)
                {
                    return string.Empty;
                }

                string productNo = string.Empty;

                ICProductsController objProductsController = new ICProductsController();
                ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(objProductsInfo.FK_ICProductGroupID);
                if (objProductGroupsInfo == null)
                {
                    objProductGroupsInfo = new ICProductGroupsInfo();
                    if (objProductsInfo.FK_ICDepartmentID == ProductionNormConst.MMProductionNormProductDepartment)
                        objProductGroupsInfo.ICProductGroupConfigGroupNoLength = 2;
                    else
                        objProductGroupsInfo.ICProductGroupConfigGroupNoLength = 3;
                }

                //int currentStart = objGenerateProductNoConfigsInfo.GEGenerateProductNoConfigStart;
                int currentStart = objProductGroupsInfo.ICProductGroupConfigStart;
                if (isEditAction && numberingStart > 0)
                    currentStart = numberingStart;


                List<string> joinStrings = new List<string>();
                string tempNo = string.Empty;
                if (!string.IsNullOrWhiteSpace(objGenerateProductNoConfigsInfo.GEGenerateProductNoConfigPrefix))
                    joinStrings.Add(objGenerateProductNoConfigsInfo.GEGenerateProductNoConfigPrefix);

                if (objGenerateProductNoConfigsInfo.GEGenerateProductNoConfigIsDepartmentNo)
                {
                    tempNo = BOSApp.GetDisplayTextFromCatche("ICDepartments", "ICDepartmentID", objProductsInfo.FK_ICDepartmentID, "ICDepartmentNo");
                    if (tempNo.Length > 2)
                    {
                        tempNo = tempNo.Substring(0, 2);
                    }
                    if (!string.IsNullOrWhiteSpace(tempNo))
                        joinStrings.Add(tempNo);
                }
                if (objProductGroupsInfo.ICProductGroupID > 0)
                {
                    ICProductGroupsInfo rootInfo = objProductGroupsController.GetRootGroupByGroup(objProductsInfo.FK_ICDepartmentID, objProductsInfo.FK_ICProductGroupID);
                    string rootNo = rootInfo != null ? rootInfo.ICProductGroupNo : string.Empty;
                    
                    joinStrings.Add(rootNo);
                    tempNo = string.Empty;
                    if (objProductGroupsInfo.ICProductGroupID > 0)
                        tempNo = objProductGroupsInfo.ICProductGroupNo;
                    else
                        tempNo = BOSApp.GetDisplayTextFromCatche("ICProductGroups", "ICProductGroupID", objProductsInfo.FK_ICProductGroupID, "ICProductGroupNo");

                    if (string.IsNullOrWhiteSpace(tempNo))
                        tempNo = tempNo.PadLeft(objGenerateProductNoConfigsInfo.GEGenerateProductNoConfigLength, '0');

                    if (tempNo.Length > objProductGroupsInfo.ICProductGroupConfigGroupNoLength)
                    {
                        tempNo = tempNo.Substring(0, objProductGroupsInfo.ICProductGroupConfigGroupNoLength);
                    }
                    tempNo = tempNo.PadLeft(objProductGroupsInfo.ICProductGroupConfigGroupNoLength, '0');
                    joinStrings.Add(tempNo);
                }
                if (objGenerateProductNoConfigsInfo.GEGenerateProductNoConfigIsPrefixYear)
                {
                    DateTime currentDate = BOSApp.GetCurrentServerDate();
                    tempNo = currentDate.Year.ToString().Substring(2, 2);
                    if (!string.IsNullOrWhiteSpace(tempNo))
                        joinStrings.Add(tempNo);
                }

                string configStart = currentStart.ToString().PadLeft(objProductGroupsInfo.ICProductGroupConfigLength, '0');
                productNo = string.Join(objGenerateProductNoConfigsInfo.GEGenerateProductNoConfigJoinCharacter, joinStrings.ToArray());
                string productTemp = productNo + objGenerateProductNoConfigsInfo.GEGenerateProductNoConfigJoinCharacter + configStart;
                while (objProductsController.IsExist(productTemp))
                {
                    currentStart++;
                    configStart = currentStart.ToString().PadLeft(objProductGroupsInfo.ICProductGroupConfigLength, '0');
                    productTemp = productNo + objGenerateProductNoConfigsInfo.GEGenerateProductNoConfigJoinCharacter + configStart;
                }
                currentStart++;

                if (objProductGroupsInfo.ICProductGroupID > 0
                        && (!isEditAction || (isEditAction && backupNumberingStart != currentStart)))
                {
                    numberingStart = currentStart;
                    objProductGroupsInfo.ICProductGroupConfigStart = currentStart;
                    objProductGroupsController.UpdateObject(objProductGroupsInfo);
                }

                objProductsInfo.ICProductCreateNumber = currentStart;
                //result : productTemp
                return productTemp;
            }
            return string.Empty;
        }
    }
}
