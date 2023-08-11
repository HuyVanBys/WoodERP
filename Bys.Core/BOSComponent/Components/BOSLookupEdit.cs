using BOSCommon.Constants;
using BOSCommon.Extensions;
using BOSLib;
using BOSLib.Interfaces;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ListControls;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using Localization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BOSComponent
{
    #region Customize Base Behaviours for Multiple-column Filtering
    public class BOSLookupListDataAdapter : DevExpress.XtraEditors.ListControls.LookUpListDataAdapter
    {
        public BOSLookupListDataAdapter(RepositoryItemBOSLookupEdit item) : base(item)
        {

        }

        protected override CriteriaOperator CreateFilterCriteria(CriteriaOperator criteria)
        {
            String filterExpression = String.Empty;
            //String[] words = this.Item.OwnerEdit.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < words.Length; i++)
            //{
            //    String word = BOSUtil.GetSearchString(words[i].Replace("'", "''"));
            //    filterExpression += "(";
            //    for (int j = 0; j < this.Item.OwnerEdit.Properties.Columns.Count; j++)
            //    {
            //        LookUpColumnInfo column = this.Item.OwnerEdit.Properties.Columns[j];
            //        filterExpression += String.Format(" [{0}] LIKE '%{1}%'", column.FieldName, word);
            //        if (j < this.Item.OwnerEdit.Properties.Columns.Count - 1)
            //            filterExpression += " OR";
            //    }
            //    filterExpression += ")";
            //    if (i < words.Length - 1)
            //        filterExpression += " AND ";
            //}

            string words = this.Item.OwnerEdit.Text;
            String word = BOSUtil.GetSearchString(words.Replace("'", "''"));
            filterExpression += "(";
            for (int j = 0; j < this.Item.OwnerEdit.Properties.Columns.Count; j++)
            {
                LookUpColumnInfo column = this.Item.OwnerEdit.Properties.Columns[j];
                filterExpression += String.Format(" [{0}] LIKE '%{1}%'", column.FieldName, word.TrimEnd());
                if (j < this.Item.OwnerEdit.Properties.Columns.Count - 1)
                    filterExpression += " OR";
            }
            filterExpression += ")";
            return CriteriaOperator.Parse(filterExpression);
        }
    }

    [UserRepositoryItem("RegisterBOSLookupEdit")]
    public class RepositoryItemBOSLookupEdit : RepositoryItemLookUpEdit
    {
        static RepositoryItemBOSLookupEdit() { RegisterBOSLookupEdit(); }

        public RepositoryItemBOSLookupEdit()
            : base()
        {

        }

        public const string BOSLookupEditName = "BOSLookupEdit";

        public override string EditorTypeName { get { return BOSLookupEditName; } }

        public string ColumnName { get; set; }

        public static void RegisterBOSLookupEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(BOSLookupEditName,
              typeof(BOSLookupEdit), typeof(RepositoryItemBOSLookupEdit),
              typeof(LookUpEditViewInfo), new ButtonEditPainter(), true, null));
        }

        protected override LookUpListDataAdapter CreateDataAdapter()
        {
            return new BOSLookupListDataAdapter(this);
        }
    }
    #endregion

    public partial class BOSLookupEdit : DevExpress.XtraEditors.LookUpEdit, IBOSControl
    {
        static BOSLookupEdit() { RepositoryItemBOSLookupEdit.RegisterBOSLookupEdit(); }

        public override string EditorTypeName { get { return RepositoryItemBOSLookupEdit.BOSLookupEditName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemBOSLookupEdit Properties { get { return base.Properties as RepositoryItemBOSLookupEdit; } }
        #region Variables
        protected BOSScreen _screen;
        protected String _BOSFieldGroup;
        protected String _BOSFieldParent;
        protected String _BOSFieldRelation;
        protected String _BOSDataSource;
        protected String _BOSDataMember;
        protected String _BOSPropertyName;
        protected bool _BOSAllowDummy;
        protected String _BOSSelectType;
        protected String _BOSSelectTypeValue;
        protected String _BOSError;
        protected String _BOSComment;
        protected String _BOSPrivilege;
        protected String _BOSDescription;
        protected String _currentDisplayText;
        public SortedList LookupTables;
        public SortedList LookupTablesUpdatedDate;
        protected DateTime LastUpdatedDate;
        //[NUThao] [Improve Speed] [2014-09-09]
        public SortedList<string, GELookupTablesInfo> LookupTableObjects;
        //[NUThao] [Improve Speed] [2014-09-09]
        //[NUThao] [Add] [Refresh Lookup edit control] [2015-06-17] Start
        private bool bosSelectTypeValueChanged = false;
        //[NUThao] [Add] [Refresh Lookup edit control] [2015-06-17] END


        /// <summary>
        /// A variable to store the display member of the lookup edit
        /// </summary>
        private string DisplayMember = App.DefaultString;
        #endregion

        #region Public properties
        [Category("Design")]
        [Browsable(true)]
        public new String Name
        {
            get
            {
                return base.Name;
            }

            set
            {
                base.Name = value;
            }
        }

        public BOSScreen Screen
        {
            get
            {
                return _screen;
            }
            set
            {
                _screen = value;
            }
        }

        [Category("BOS")]
        public String BOSFieldGroup
        {
            get
            {
                return _BOSFieldGroup;
            }
            set
            {
                _BOSFieldGroup = value;
            }
        }

        [Category("BOS")]
        public String BOSFieldParent
        {
            get
            {
                return _BOSFieldParent;
            }
            set
            {
                _BOSFieldParent = value;
            }
        }

        [Category("BOS")]
        public String BOSFieldRelation
        {
            get
            {
                return _BOSFieldRelation;
            }
            set
            {
                _BOSFieldRelation = value;
            }
        }

        [Category("BOS")]
        public String BOSDataSource
        {
            get
            {
                return _BOSDataSource;
            }
            set
            {
                _BOSDataSource = value;
            }
        }

        [Category("BOS")]
        public String BOSDataMember
        {
            get
            {
                return _BOSDataMember;
            }
            set
            {
                _BOSDataMember = value;
            }
        }

        [Category("BOS")]
        public bool BOSAllowDummy
        {
            get
            {
                return _BOSAllowDummy;
            }
            set
            {
                _BOSAllowDummy = value;
            }
        }

        [Category("BOS")]
        public String BOSSelectType
        {
            get
            {
                return _BOSSelectType;
            }
            set
            {
                _BOSSelectType = value;
            }
        }

        [Category("BOS")]
        public String BOSSelectTypeValue
        {
            get
            {
                return _BOSSelectTypeValue;
            }
            set
            {
                if (value != _BOSSelectTypeValue)
                {
                    bosSelectTypeValueChanged = true;
                    _BOSSelectTypeValue = value;
                    //RefreshLookupEditDataSource();
                }

            }
        }

        [Category("BOS")]
        public String BOSError
        {
            get
            {
                return _BOSError;
            }
            set
            {
                _BOSError = value;
            }
        }

        [Category("BOS")]
        public String BOSPropertyName
        {
            get
            {
                return _BOSPropertyName;
            }
            set
            {
                _BOSPropertyName = value;
            }
        }

        [Category("BOS")]
        public String BOSComment
        {
            get
            {
                return _BOSComment;
            }
            set
            {
                _BOSComment = value;
            }
        }

        [Category("BOS")]
        public String BOSPrivilege
        {
            get
            {
                return _BOSPrivilege;
            }
            set
            {
                _BOSPrivilege = value;
            }
        }

        [Category("BOS")]
        public String BOSDescription
        {
            get
            {
                return _BOSDescription;
            }
            set
            {
                _BOSDescription = value;
            }
        }

        [Category("BOS")]
        public bool BOSAllowAddNew { get; set; }

        public String CurrentDisplayText
        {
            get { return _currentDisplayText; }
            set { _currentDisplayText = value; }
        }
        public List<GELookupTablesInfo> LookupTableList;
        public List<STFieldColumnsInfo> LstFieldColumns;
        #endregion

        public BOSLookupEdit()
        {
            InitializeComponent();

            Size = new Size(150, 20);
        }

        public BOSLookupEdit(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            Size = new Size(150, 20);
        }

        public BOSLookupEdit(BOSScreen scr)
        {
            _screen = scr;

            InitializeComponent();

            Size = new Size(125, 20);

            InitializeControl();
        }

        #region Initialize LookupEdit functions
        public virtual void InitializeControl(STFieldsInfo objFieldInfo)
        {
            this.BOSFieldParent = objFieldInfo.STFieldFieldParent;
            this.BOSAllowDummy = objFieldInfo.STFieldAllowDummy;
            this.BOSSelectType = objFieldInfo.STFieldSelectType;
            this.BOSSelectTypeValue = objFieldInfo.STFieldSelectTypeValue;
            this.BOSPrivilege = objFieldInfo.STFieldPrivilege;

            this.Properties.DisplayMember = objFieldInfo.STFieldDisplayMember;
            this.Properties.ValueMember = objFieldInfo.STFieldValueMember;
        }
        private void InitCommonData()
        {
            LookupTables = ((IBaseModuleERP)Screen.Module).GetLookupTableCollection();
            LookupTablesUpdatedDate = ((IBaseModuleERP)Screen.Module).GetLookupTableUpdatedDateCollection();
            LookupTableObjects = ((IBaseModuleERP)Screen.Module).GetLookupTableObjects();
            LookupTableList = ((IBaseModuleERP)Screen.Module).GetLookupTableList();
            STFieldsInfo objSTFieldsInfo = null;
            if (Screen.Fields.ContainsKey(Name))
                objSTFieldsInfo = Screen.Fields[Name];
            if (objSTFieldsInfo != null)
                LstFieldColumns = ((IBaseModuleERP)Screen.Module).GetSystemFieldColumns();
        }
        private void DisposeCommonData()
        {
            foreach (var item in LookupTables.Keys)
            {
                ((DataSet)LookupTables[item]).Dispose();
            }
        }
        public virtual void InitializeControl()
        {
            try
            {
                InitCommonData();
                //Init lookup edit columns                
                InitLookupEditColumns();
                InitObjectDataToLookupEdit();
                //InvalidateDataSourceToLookupEdit();
                RefreshLookupEditDataSource();

                //LastUpdatedDate = dbUtil.GetCurrentServerDate() ;
                Properties.BestFitMode = BestFitMode.BestFitResizePopup;
                Properties.SearchMode = SearchMode.AutoFilter;
                Properties.TextEditStyle = TextEditStyles.Standard;
                Properties.NullText = string.Empty;
                Properties.AllowMouseWheel = false;
                if (!String.IsNullOrEmpty(BOSDataSource) && !String.IsNullOrEmpty(BOSDataMember))
                {
                    if (!BOSDataSource.Equals("ADConfigValues"))
                        ((BOSScreen)Screen).BindingDataControl(this);
                }

                this.Click += ((IBaseModuleERP)Screen.Module).Control_Click;
                this.KeyUp += new KeyEventHandler(((IBaseModuleERP)Screen.Module).Control_KeyUp);
                this.KeyUp += new KeyEventHandler(BOSLookupEdit_KeyUp);
                this.EditValueChanged += new EventHandler(BOSLookupEdit_EditValueChanged);
                this.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(BOSLookupEdit_ProcessNewValue);
                this.QueryPopUp += new CancelEventHandler(BOSLookupEdit_QueryPopUp);
                this.Leave += new EventHandler(BOSLookupEdit_Leave);
                this.KeyDown += new KeyEventHandler(BOSLookupEdit_KeyDown);
                this.CloseUp += new CloseUpEventHandler(BOSLookupEdit_CloseUp);
                this.Spin += new SpinEventHandler(BOSLookupEdit_Spin);
                DisposeCommonData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void BOSLookupEdit_Spin(object sender, SpinEventArgs e)
        {
            BOSLookupEdit control = sender as BOSLookupEdit;
            if (!control.IsPopupOpen)
                e.Handled = true;
        }

        protected virtual void InitObjectDataToLookupEdit()
        {
            String strTableName = BOSDataSource;
            String strColumnName = BOSDataMember;
            BOSDbUtil dbUtil = new BOSDbUtil();

            //If DataMember is not empty
            if (!String.IsNullOrEmpty(strColumnName))
            {
                if (Screen == null || Screen.Module == null) return;
                //If is foreign key
                if (((IBaseModuleERP)Screen.Module).IsForeignKey(strTableName, strColumnName))
                {
                    String strLookupTable = ((IBaseModuleERP)Screen.Module).GetTreePrimaryTableWhichForeignColumnReferenceTo(BOSDataSource, BOSDataMember);
                    InitObjectDataFromLookupTable(strLookupTable);
                }
                else
                {
                    String configValueTable = GetConfigValueGroup();
                    if (!string.IsNullOrWhiteSpace(configValueTable))
                    {
                        this.Properties.DataSource = ADConfigValueUtility.ConfigValues.Tables[configValueTable];
                        this.Properties.ValueMember = "Value";
                        this.Properties.DisplayMember = "Text";
                        LookUpColumnInfo column = new LookUpColumnInfo();
                        column.Caption = ComponentLocalizedResources.Name;
                        column.FieldName = "Text";
                        column.Width = 100;
                        LookUpColumnInfo exitCol = this.Properties.Columns.Where(o => o.FieldName == column.FieldName).FirstOrDefault();
                        if (exitCol == null)
                            this.Properties.Columns.Add(column);
                        this.Properties.PopupWidth = column.Width;
                        Properties.ShowHeader = false;
                    }
                    else if (string.IsNullOrWhiteSpace(strColumnName)
                            || strColumnName == ((IBaseModuleERP)Screen.Module).GetTablePrimaryColumn(strTableName)
                            || strColumnName == strTableName)
                    {
                        InitObjectDataFromLookupTable(strTableName);
                    } 
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(strTableName))
                {
                    InitObjectDataFromLookupTable(strTableName);
                }
            }
        }

        /// <summary>
        /// Init object data from lookup table
        /// </summary>
        /// <param name="strLookupTable">Lookup table name</param>
        protected bool InitObjectDataFromLookupTable(String strLookupTable)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            if (LookupTables != null)
            {
                //[NUThao] [Improve Speed] [2014-09-09]
                if (!LookupTables.ContainsKey(strLookupTable) && !strLookupTable.IsNullOrWhiteSpace())
                {
                    GELookupTablesController lookupTableController = new GELookupTablesController();
                    GELookupTablesInfo lookupTable = new GELookupTablesInfo();
                    if (LookupTableList != null && LookupTableList.Count > 0)
                        lookupTable = LookupTableList.Where(t => t.GELookupTableName == strLookupTable).FirstOrDefault();
                    if (lookupTable == null || lookupTable.GELookupTableID == 0)
                        lookupTable = lookupTableController.GetObjectByTableName(strLookupTable);

                    if (lookupTable != null)
                    {
                        DataSet ds = ((IBaseModuleERP)Screen.Module).GetLookupTableData(strLookupTable);
                        if (!LookupTables.ContainsKey(strLookupTable))
                            LookupTables.Add(strLookupTable, ds);
                        else
                        {
                            ((DataSet)LookupTables[strLookupTable]).Tables.Clear();
                            ((DataSet)LookupTables[strLookupTable]).Dispose();
                            ((DataSet)LookupTables[strLookupTable]).Tables.Add(ds.Tables[0].Copy());
                        }
                        if (!LookupTablesUpdatedDate.ContainsKey(strLookupTable))
                            LookupTablesUpdatedDate.Add(strLookupTable, ((IBaseModuleERP)Screen.Module).GetServerDate());
                        if (!LookupTableObjects.ContainsKey(strLookupTable))
                            LookupTableObjects.Add(strLookupTable, lookupTable);
                        ds.Dispose();
                        GC.Collect(0, GCCollectionMode.Forced);
                    }

                }
                //[NUThao] [Improve Speed] [2014-09-09]
                if (LookupTables[strLookupTable] != null)
                {
                    //DataTable table = ((DataSet)LookupTables[strLookupTable]).Tables[0].Copy();
                    //InitObjectDataFromLookupTable(table, strLookupTable);
                    InitObjectDataFromLookupTable(((DataSet)LookupTables[strLookupTable]).Tables[0], strLookupTable);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Init data source for lookup edit from a lookup table
        /// </summary>
        /// <param name="dataSource">Data source</param>
        /// <param name="tableName">Name of table the data source is gotten from</param>
        protected void InitObjectDataFromLookupTable(DataTable ds, string tableName)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            //Get all data which column "BOSSelectType" contains BOSSelectTypeValue from look up table
            DataTable dataSource = ds;
            if (!String.IsNullOrEmpty(BOSSelectType))
            {
                if (dbUtil.ColumnIsExist(tableName, BOSSelectType))
                {
                    dataSource = ds.Copy();

                    string[] selectTypeValues = BOSSelectTypeValue.Split(new char[] { ';' });
                    DataTable datafilter = ds.Clone();
                    foreach (string selectTypeValue in selectTypeValues)
                    {
                        if (dataSource != null && dataSource.Rows.Count > 0 && dataSource.Columns[BOSSelectType] != null)
                        {
                            var data = dataSource.Rows.Cast<DataRow>().Where(x => (x[BOSSelectType] != null ? x[BOSSelectType].ToString().Trim().ToLower() : string.Empty)
                                                                        == selectTypeValue.Trim().ToLower()).AsEnumerable();
                            if (data != null && data.Any())
                                datafilter.Merge(data.CopyToDataTable());
                        }
                    }

                    dataSource = datafilter;
                }
            }

            bool hasDummyRow = false;
            if (BOSAllowDummy)
            {
                if (dataSource.Rows.Count > 0)
                {
                    if (dataSource.Columns[this.Properties.ValueMember] != null)
                    {
                        object value = dataSource.Rows[0][this.Properties.ValueMember];
                        if (value is int)
                        {
                            if (Convert.ToInt32(value) > 0)
                            {
                                DataRow row = dataSource.NewRow();
                                foreach (DataColumn column in row.Table.Columns)
                                {
                                    if (column.ColumnName != this.Properties.ValueMember)
                                    {
                                        Type type = column.DataType;
                                        switch (Type.GetTypeCode(type))
                                        {
                                            case TypeCode.Boolean:
                                                row[column.ColumnName] = false;
                                                break;

                                            case TypeCode.Int16:
                                            case TypeCode.Int32:
                                            case TypeCode.Int64:
                                                row[column.ColumnName] = 0;
                                                break;
                                            case TypeCode.Char:
                                            case TypeCode.String:
                                                row[column.ColumnName] = string.Empty;
                                                break;
                                        };
                                    }
                                }
                                row[this.Properties.ValueMember] = 0;
                                dataSource.Rows.InsertAt(row, 0);
                                hasDummyRow = true;
                            }
                        }
                        else if (value is string)
                        {
                            if (!string.IsNullOrEmpty(value.ToString()))
                            {
                                DataRow row = dataSource.NewRow();
                                foreach (DataColumn column in row.Table.Columns)
                                {
                                    if (column.ColumnName != this.Properties.ValueMember)
                                    {
                                        Type type = column.DataType;
                                        switch (Type.GetTypeCode(type))
                                        {
                                            case TypeCode.Boolean:
                                                row[column.ColumnName] = false;
                                                break;

                                            case TypeCode.Int16:
                                            case TypeCode.Int32:
                                            case TypeCode.Int64:
                                                row[column.ColumnName] = 0;
                                                break;
                                            case TypeCode.Char:
                                            case TypeCode.String:
                                                row[column.ColumnName] = string.Empty;
                                                break;
                                        };
                                    }
                                }
                                row[this.Properties.ValueMember] = string.Empty;
                                dataSource.Rows.InsertAt(row, 0);
                                hasDummyRow = true;
                            }
                        }
                    }
                }
            }

            if (BOSAllowAddNew)
            {
                String strFieldParentPrimaryColumn = ((IBaseModuleERP)Screen.Module).GetTablePrimaryColumn(tableName);
                string searchExpression = strFieldParentPrimaryColumn + "= -1";
                DataRow[] foundRows = dataSource.Select(searchExpression);
                if (foundRows.Count() == 0)
                {
                    DataRow row = dataSource.NewRow();
                    foreach (DataColumn column in row.Table.Columns)
                    {
                        if (column.ColumnName != this.Properties.ValueMember)
                        {
                            Type type = column.DataType;
                            switch (Type.GetTypeCode(type))
                            {
                                case TypeCode.Boolean:
                                    row[column.ColumnName] = false;
                                    break;

                                case TypeCode.Int16:
                                case TypeCode.Int32:
                                case TypeCode.Int64:
                                    row[column.ColumnName] = 0;
                                    break;
                                case TypeCode.Char:
                                case TypeCode.String:
                                    row[column.ColumnName] = string.Empty;
                                    break;
                            };
                        }
                    }
                    row[this.Properties.ValueMember] = -1;
                    row[this.Properties.DisplayMember] = ComponentLocalizedResources.AddNew;
                    if (hasDummyRow)
                    {
                        dataSource.Rows.InsertAt(row, 1);
                    }
                    else
                    {
                        dataSource.Rows.InsertAt(row, 0);
                    }
                }
            }
            this.Properties.DataSource = dataSource;

            dataSource.Dispose();
            GC.Collect(0, GCCollectionMode.Forced);
            //if (((DataSet)LookupTables[tableName]).Tables[0].Rows.Count > 0)
            //    this.ItemIndex = 0;
        }

        public virtual void InitLookupEditColumns()
        {
            STFieldsInfo objSTFieldsInfo = null;
            if (Screen.Fields.ContainsKey(Name))
            {
                objSTFieldsInfo = Screen.Fields[Name];
            }
            if (objSTFieldsInfo != null && LstFieldColumns != null)
            {
                // STFieldColumnsController objSTFieldColumnsController = new STFieldColumnsController();
                List<STFieldColumnsInfo> lstFieldColumns = LstFieldColumns.Where(fc => fc.STFieldID == objSTFieldsInfo.STFieldID).ToList();

                if (lstFieldColumns != null && lstFieldColumns.Count > 0)
                {
                    this.Properties.Columns.Clear();
                    this.Properties.PopupWidth = 0;
                    foreach (STFieldColumnsInfo objSTFieldColumnsInfo in lstFieldColumns)
                    {
                        DevExpress.XtraEditors.Controls.LookUpColumnInfo column = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
                        column.Caption = objSTFieldColumnsInfo.STFieldColumnCaption;
                        column.FieldName = objSTFieldColumnsInfo.STFieldColumnFieldName;
                        column.FormatType = (DevExpress.Utils.FormatType)Enum.Parse(typeof(DevExpress.Utils.FormatType), objSTFieldColumnsInfo.STFieldColumnFormatType);
                        column.FormatString = objSTFieldColumnsInfo.STFieldColumnFormatString;
                        column.Width = objSTFieldColumnsInfo.STFieldColumnWidth;
                        this.Properties.Columns.Add(column);
                        this.Properties.PopupWidth += column.Width;
                    }
                }
            }
        }

        /// <summary>
        /// Invalidate data source to LookupEdit which belongs to field parent
        /// For reflecting changes made to data source
        /// </summary>
        private void InvalidateDataSourceToLookupEditWhichBelongsToFieldParent()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSLookupEdit lkeFieldParent = (BOSLookupEdit)this.Screen.Module.Controls[BOSFieldParent];

            if (lkeFieldParent != null)
            {
                String strFieldParentLookupTable = ((IBaseModuleERP)Screen.Module).GetTreePrimaryTableWhichForeignColumnReferenceTo(lkeFieldParent.BOSDataSource, lkeFieldParent.BOSDataMember);
                String strFieldParentPrimaryColumn = ((IBaseModuleERP)Screen.Module).GetTablePrimaryColumn(strFieldParentLookupTable);
                String strLookupTable = ((IBaseModuleERP)Screen.Module).GetTreePrimaryTableWhichForeignColumnReferenceTo(this.BOSDataSource, this.BOSDataMember);

                if (String.IsNullOrEmpty(strLookupTable))
                    strLookupTable = this.BOSDataSource;

                String strForeignColumn = "FK_" + strFieldParentPrimaryColumn;
                IBusinessController objLookupTableController = BusinessControllerFactory.GetBusinessController(strLookupTable + "Controller");

                if (objLookupTableController != null)
                {
                    DataSet ds = objLookupTableController.GetAllDataByForeignColumn(strForeignColumn, lkeFieldParent.EditValue);
                    //Binding LookupEdit
                    if (ds.Tables.Count > 0)
                    {
                        DataTable dtLookupTable = ds.Tables[0];
                        //Get all data which column "BOSSelectType" contains BOSSelectTypeValue from look up table
                        if (!String.IsNullOrEmpty(BOSSelectType))
                            if (dbUtil.ColumnIsExist(strLookupTable, BOSSelectType))
                            {
                                for (int i = 0; i < dtLookupTable.Rows.Count; i++)
                                {
                                    DataRow row = dtLookupTable.Rows[i];
                                    if (!row[BOSSelectType].ToString().Equals(BOSSelectTypeValue))
                                    {
                                        row.Delete();
                                    }
                                }
                                dtLookupTable.AcceptChanges();
                            }

                        if (BOSAllowDummy)
                        {
                            if (dtLookupTable.Rows.Count > 0)
                            {
                                if (Convert.ToInt32(dtLookupTable.Rows[0][this.Properties.ValueMember]) > 0)
                                {
                                    DataRow row = dtLookupTable.NewRow();
                                    row[this.Properties.DisplayMember] = string.Empty;
                                    row[this.Properties.ValueMember] = 0;
                                    dtLookupTable.Rows.InsertAt(row, 0);
                                }
                            }
                        }
                        BindingSource bds = new BindingSource();
                        bds.DataSource = dtLookupTable;
                        this.Properties.DataSource = bds;
                        dtLookupTable.Dispose();
                    }
                    ds.Dispose();
                    GC.Collect(0, GCCollectionMode.Forced);
                }
            }
        }

        /// <summary>
        /// Invalidate data source to LookupEdit which not belong to field parent
        /// For reflecting changes made to data source
        /// </summary>
        public void InvalidateDataSourceToLookupEdit()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String strLookupTable = ((IBaseModuleERP)Screen.Module).GetTreePrimaryTableWhichForeignColumnReferenceTo(BOSDataSource, BOSDataMember);
            if (String.IsNullOrEmpty(strLookupTable))
                strLookupTable = BOSDataSource;
            if (LookupTables != null && LookupTables[strLookupTable] != null)
            {
                if (BOSDataMember != "ACObjectAccessKey")
                {
                    DateTime dtLastCreatedDate = dbUtil.GetLastCreatedDateOfTable(strLookupTable);
                    DateTime dtLastUpdatedDate = dbUtil.GetLastUpdatedDateOfTable(strLookupTable);
                    double _creDate = dtLastCreatedDate.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds;
                    double _upddDate = dtLastUpdatedDate.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds;
                    double _lkUpddDate = ((DateTime)LookupTablesUpdatedDate[strLookupTable]).Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds;
                    if (_creDate > _lkUpddDate || _upddDate > _lkUpddDate)
                    {
                        //Refesh Data Source
                        DataSet ds = ((IBaseModuleERP)Screen.Module).GetLookupTableData(strLookupTable);
                        if (ds.Tables.Count > 0)
                        {
                            // Update Last Updated Date of Lookup Table
                            LookupTablesUpdatedDate[strLookupTable] = ((IBaseModuleERP)Screen.Module).GetServerDate();
                            //LastUpdatedDate = (DateTime)LookupTablesUpdatedDate[strLookupTable];
                            ((DataSet)LookupTables[strLookupTable]).Dispose();
                            LookupTables[strLookupTable] = ds;
                            InitObjectDataFromLookupTable(strLookupTable);
                        }
                        ds.Dispose();
                    }

                    if (((DateTime)LookupTablesUpdatedDate[strLookupTable]).CompareTo(LastUpdatedDate) > 0 || bosSelectTypeValueChanged == true)
                    {
                        InitObjectDataFromLookupTable(strLookupTable);
                        //LastUpdatedDate = (DateTime)LookupTablesUpdatedDate[strLookupTable];
                        bosSelectTypeValueChanged = false;
                    }
                }
            }
        }

        public void RefreshBindingDataSource()
        {
            InitObjectDataToLookupEdit();
        }

        #region Event Handlers
        protected virtual void BOSLookupEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            //RefreshLookupEditDataSource();
        }

        protected virtual void BOSLookupEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        protected virtual void BOSLookupEdit_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {

        }

        protected virtual void BOSLookupEdit_Leave(object sender, EventArgs e)
        {
            //Reset filter
            object dataSource = Properties.DataSource;
            Properties.DataSource = null;
            Properties.DataSource = dataSource;
        }

        protected virtual void BOSLookupEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                ShowPopup();
            }
        }

        protected virtual void BOSLookupEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Properties.ReadOnly && !IsPopupOpen)
            {
                byte keyCode = Convert.ToByte(e.KeyCode);
                if ((keyCode >= 48 && keyCode <= 57) || (keyCode >= 65 && keyCode <= 90) || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                {
                    if (Properties.DisplayMember != App.DefaultString)
                    {
                        DisplayMember = Properties.DisplayMember;
                    }
                    Properties.DisplayMember = App.DefaultString;
                }
            }
        }

        protected virtual void BOSLookupEdit_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (DisplayMember != App.DefaultString)
            {
                Properties.DisplayMember = DisplayMember;
            }
            if (BOSDataMember != null && BOSDataMember.Contains("GECurrencyID"))
            {
                if (e.Value != null && e.Value != this.OldEditValue)
                {
                    int CurrencyID = 0;
                    if (int.TryParse(e.Value.ToString(), out CurrencyID))
                    {
                        if (CurrencyID > 0)
                        {
                            this.Screen.Module.ReInitializeFieldFormat(CurrencyID);
                        }
                    }
                }
            }
        }
        #endregion

        public static BOSLookupEdit Instance(String strInstanceName, String strModuleName)
        {
            if (!String.IsNullOrEmpty(strInstanceName))
            {
                Assembly BOSERPAssembly = Assembly.LoadFrom(Application.StartupPath + "\\BOSERP.exe");
                Type gridType = BOSERPAssembly.GetType("BOSERP.Modules." + strModuleName + "." + strInstanceName + "LookupEdit");
                if (gridType != null)
                {
                    return (BOSLookupEdit)gridType.InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                }
                else
                {
                    gridType = BOSERPAssembly.GetType("BOSERP." + strInstanceName + "GridControl");
                    if (gridType != null)
                        return (BOSLookupEdit)gridType.InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                    else
                        return new BOSLookupEdit();
                }
            }
            else
                return new BOSLookupEdit();
        }

        /// <summary>
        /// Get ADConfigValueGroup to initialize data source from  ADConfigValues table
        /// </summary>
        private String GetConfigValueGroup()
        {
            string configValueTable = string.Empty;
            if (!string.IsNullOrEmpty(BOSDataSource) && !string.IsNullOrEmpty(BOSDataMember))
            {
                if (BOSDataSource == TableName.ADConfigValuesTableName)
                {
                    configValueTable = BOSDataMember;
                }
                else
                {
                    if (BOSDataMember.Contains("Combo"))
                    {
                        configValueTable = BOSDataMember.Substring(2, BOSDataMember.Length - 7);
                    }
                    else
                    {
                        configValueTable = BOSDataMember.Substring(2, BOSDataMember.Length - 2);
                    }
                }

                if (ADConfigValueUtility.ConfigValues.Tables[configValueTable] != null)
                {
                    if ((Tag != null && Tag.ToString() == BOSScreen.SearchControl) || BOSAllowDummy)
                    {
                        configValueTable = configValueTable + "Search";
                    }
                }
                else
                {
                    configValueTable = string.Empty;
                }
            }
            return configValueTable;
        }

        public void RefreshLookupEditDataSource()
        {
            InitObjectDataToLookupEdit();
        }
        #endregion
    }
}
