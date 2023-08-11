using BOSCommon.Constants;
using BOSLib;
using BOSLib.Interfaces;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using Localization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BOSComponent
{
    public partial class BOSTreeListControl : DevExpress.XtraTreeList.TreeList, IBOSControl, INavigatableControl
    {
        #region Variables
        protected BOSScreen _screen;
        protected String _BOSFieldGroup;
        protected String _BOSFieldRelation;
        protected String _BOSDataSource;
        protected String _BOSDataMember;
        protected String _BOSPropertyName;
        protected String _BOSComment;
        protected String _BOSError;
        protected bool _BOSDisplayRoot;
        protected bool _BOSDisplayOption;
        protected String _BOSPrivilege;
        protected String _BOSDescription;
        protected SortedList LookupTables;
        protected SortedList LookupTablesUpdatedDate;
        protected SortedList FieldFormatGroups;
        protected List<GELookupTablesInfo> LookupTableList;
        protected List<STFieldFormatGroupsInfo> FieldFormatList;
        protected SortedList<string, GELookupTablesInfo> LookupTableObjects;
        protected List<AAColumnAliasInfo> LstColumnAlias;
        protected List<STFieldsInfo> FieldList;
        protected List<STFieldPermissionsInfo> LstFieldPermission;
        protected SortedList LstFieldColumnPermissions;
        protected List<STFieldColumnsInfo> LstFieldColumn;
        protected PopupMenu popMenuCForm;
        protected BarManager barManager;
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
        public bool BOSDisplayRoot
        {
            get
            {
                return _BOSDisplayRoot;
            }
            set
            {
                _BOSDisplayRoot = value;
            }
        }

        [Category("BOS")]
        public bool BOSDisplayOption
        {
            get
            {
                return _BOSDisplayOption;
            }
            set
            {
                _BOSDisplayOption = value;
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
        #endregion

        public BOSTreeListControl()
        {
            InitializeComponent();

        }

        public BOSTreeListControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

        }

        public virtual void InitializeControl(STFieldsInfo objFieldInfo)
        {
            this.BOSDisplayRoot = objFieldInfo.STFieldDisplayRoot;
            this.BOSDisplayOption = objFieldInfo.STFieldDisplayOption;
        }

        public virtual void InitializeControl()
        {
            InitCommonData();
            //Init tree list columns
            InitTreeListColumns(BOSDataSource);
            RecoveryDefaultColumnGridControl();
            //Init tree list data source
            InitTreeListDataSource();
            OptionsBehavior.EnterMovesNextColumn = true;
            this.OptionsView.ShowAutoFilterRow = true;
            this.ShowTreeListMenu += new DevExpress.XtraTreeList.TreeListMenuEventHandler(BOSTreeListControl_ShowTreeListMenu);
            //Using embedded Navigator
            this.ShowCustomizationForm += TreeList_ShowCustomizationForm;

        }
        protected void TreeList_ShowCustomizationForm(object sender, EventArgs e)
        {
            ///////////////////////////////
            ///
            barManager = new BarManager();
            popMenuCForm = new DevExpress.XtraBars.PopupMenu();
            barManager.Form = this.CustomizationForm;
            popMenuCForm.Manager = barManager;
            BarButtonItem itemShowAll = new BarButtonItem(barManager, "Hiển thị tất cả", 0);
            BarButtonItem itemSaveCustome = new BarButtonItem(barManager, "Lưu tuỳ chỉnh", 1);
            popMenuCForm.AddItems(new BarItem[] { itemShowAll, itemSaveCustome });
            // Process item clicks. 
            barManager.ItemClick += barManager_ItemClick;
            // Associate the popup menu with the form. 
            barManager.SetPopupContextMenu(this.CustomizationForm, popMenuCForm);
        }
        protected void barManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            BarSubItem subMenu = e.Item as BarSubItem;
            if (subMenu != null) return;
            if (e.Item.ImageIndex == 0)
            {
                this.BeginUpdate();
                foreach (TreeListColumn column in this.Columns)
                {
                    if (column.VisibleIndex == -1 && column.OptionsColumn.ShowInCustomizationForm)
                        column.VisibleIndex = this.Columns.Count;
                }
                this.EndUpdate();
                this.BestFitColumns();
            }
            else if (e.Item.ImageIndex == 1)
            {
                SaveCustomizeColumn();
            }
        }
        private void InitCommonData()
        {
            LookupTables = ((IBaseModuleERP)Screen.Module).GetLookupTableCollection();
            LookupTablesUpdatedDate = ((IBaseModuleERP)Screen.Module).GetLookupTableUpdatedDateCollection();
            LookupTableList = ((IBaseModuleERP)Screen.Module).GetLookupTableList();
            FieldFormatGroups = ((IBaseModuleERP)Screen.Module).GetSystemFieldFormatGroup();
            FieldFormatList = ((IBaseModuleERP)Screen.Module).GetSystemFieldFormatList().Where(f => f.TableName == BOSDataSource).ToList();
            LookupTableObjects = ((IBaseModuleERP)Screen.Module).GetLookupTableObjects();
            LstColumnAlias = ((IBaseModuleERP)Screen.Module).GetSystemAlias().Where(f => f.AATableName == BOSDataSource).ToList();
            //LstFieldPermission = ((IBaseModuleERP)Screen.Module).GetSystemFieldPermissions();
            LstFieldColumnPermissions = ((IBaseModuleERP)Screen.Module).GetSystemFieldColumnPermissions();
            FieldList = ((IBaseModuleERP)Screen.Module).GetSystemFields();
            LstFieldColumn = ((IBaseModuleERP)Screen.Module).GetSystemFieldColumns();
        }

        void BOSTreeListControl_ShowTreeListMenu(object sender, DevExpress.XtraTreeList.TreeListMenuEventArgs e)
        {
            BOSTreeListControl treeList = (BOSTreeListControl)sender;
            //TreeList tL = sender as TreeList;
            TreeListHitInfo hitInfo = treeList.CalcHitInfo(e.Point);
            if (hitInfo.HitInfoType == HitInfoType.Column)
            {
                DXMenuItem menuItem = new DXMenuItem("Export to excel", new EventHandler(this.ExportToExcelClick));
                menuItem.Tag = hitInfo.Column;
                e.Menu.Items.Add(menuItem);
            }
        }
        private void ExportToExcelClick(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = App.ExcelDialogFilter;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                this.ExportToXls(sfd.FileName);

                Process.Start(sfd.FileName);
            }

        }
        protected List<AAColumnAliasInfo> GetColumnAliasFieldPermission(string ModuleName, string strTableName, int userGroupID)
        {
            List<AAColumnAliasInfo> lstColumnAlias = new List<AAColumnAliasInfo>();
            lstColumnAlias = LstColumnAlias.Where(a => a.AATableName == strTableName).ToList();
            List<AAColumnAliasInfo> lstColumnAliasDisplay = new List<AAColumnAliasInfo>();
            List<STFieldColumnPermissionsInfo> fieldPermission = new List<STFieldColumnPermissionsInfo>();
            IList fP = LstFieldColumnPermissions.GetValueList();
            foreach (object item in fP)
            {
                STFieldColumnPermissionsInfo obj = (STFieldColumnPermissionsInfo)item;
                if (obj.STModuleName == ModuleName && obj.STTableName == strTableName)
                    fieldPermission.Add(obj);
            }
            if (lstColumnAlias != null)
            {
                foreach (AAColumnAliasInfo item in lstColumnAlias)
                {
                    bool display = true;
                    if (fieldPermission != null && fieldPermission.Count > 0)
                    {
                        STFieldColumnPermissionsInfo objFcp = fieldPermission.Where(f => (f.STColumnName == item.AAColumnAliasName && f.STFieldColumnPermissionType == Convert.ToByte(0))
                            || !(f.STColumnName == item.AAColumnAliasName)).FirstOrDefault();
                        if (objFcp == null)
                            display = false;
                    }
                    if (display) lstColumnAliasDisplay.Add(item);
                }
            }
            return lstColumnAliasDisplay;
        }
        public List<AAColumnAliasInfo> GetListVisibleToInit(List<AAColumnAliasInfo> lstColumnAlias)
        {
            STFieldsInfo objSTFieldsInfo = GetAssociatedField();
            if (objSTFieldsInfo != null)
            {
                List<STFieldColumnsInfo> lFieldColumn = LstFieldColumn.Where(fc => fc.STFieldID == objSTFieldsInfo.STFieldID)
                                                                      .OrderBy(x => x.STFieldColumnVisibleIndex)
                                                                      .ToList();
                if (lFieldColumn != null && lFieldColumn.Count > 0)
                {
                    lstColumnAlias.ForEach(a =>
                    {
                        STFieldColumnsInfo fieldCol = lFieldColumn.Where(fc => fc.STFieldColumnFieldName == a.AAColumnAliasName).FirstOrDefault();
                        if (fieldCol != null)
                        {
                            a.Visible = true;
                            a.AANumberInt = fieldCol.STFieldColumnVisibleIndex;
                        }
                        else
                        {
                            a.Visible = false;
                            a.AANumberInt = -1;
                        }

                    });
                }
            }
            return lstColumnAlias.OrderBy(x => x.AANumberInt).ToList();
        }
        public virtual void InitTreeListColumns(String strTableName)
        {
            //Add bound columns
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            int userGroupID = BOSLib.BysGateway.CurrentUsersInfo.ADUserGroupID;
            List<AAColumnAliasInfo> lstColumnAlias = GetColumnAliasFieldPermission(Screen.Module.Name, strTableName, userGroupID);
            lstColumnAlias = GetListVisibleToInit(lstColumnAlias);

            if (lstColumnAlias != null && lstColumnAlias.Count > 0)
            {
                foreach (AAColumnAliasInfo objAAColumnAliasInfo in lstColumnAlias)
                {
                    if (this.Columns.ColumnByFieldName(objAAColumnAliasInfo.AAColumnAliasName) == null)
                    {
                        DevExpress.XtraTreeList.Columns.TreeListColumn column = InitTreeListColumn(strTableName, -1, objAAColumnAliasInfo.AAColumnAliasName, objAAColumnAliasInfo.AAColumnAliasCaption, 50);
                        if (!objAAColumnAliasInfo.Visible)
                        {
                            column.Visible = false;
                            this.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] { column });
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(objAAColumnAliasInfo.AAReferenceTable))
                            {
                                //if (!string.IsNullOrEmpty(objAAColumnAliasInfo.AAReferenceTable))
                                //RepositoryItemBOSLookupEdit repLookupEdit = InitColumnLookupEdit(strTableName, objAAColumnAliasInfo.AAColumnAliasName, objAAColumnAliasInfo.AAColumnAliasCaption);
                                RepositoryItemBOSLookupEdit repLookupEdit = InitColumnLookupEdit(objAAColumnAliasInfo);
                                if (repLookupEdit != null)
                                {
                                    column.ColumnEdit = repLookupEdit;
                                    this.RepositoryItems.Add(repLookupEdit);
                                }
                            }
                            else if (((IBaseModuleERP)Screen.Module).IsForeignKey(strTableName, objAAColumnAliasInfo.AAColumnAliasName))
                            {
                                DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookupEdit = InitColumnLookupEdit(strTableName, objAAColumnAliasInfo.AAColumnAliasName);
                                if (repLookupEdit != null)
                                {
                                    column.ColumnEdit = repLookupEdit;
                                    this.RepositoryItems.Add(repLookupEdit);
                                }
                            }
                            else
                            {
                                String strConfigValueTable = String.Empty;

                                if (objAAColumnAliasInfo.AAColumnAliasName.EndsWith("Combo"))
                                    strConfigValueTable = objAAColumnAliasInfo.AAColumnAliasName.Substring(2, objAAColumnAliasInfo.AAColumnAliasName.Length - 7);
                                else
                                    strConfigValueTable = objAAColumnAliasInfo.AAColumnAliasName.Substring(2, objAAColumnAliasInfo.AAColumnAliasName.Length - 2);

                                if (ADConfigValueUtility.ConfigValues.Tables[strConfigValueTable] != null)
                                {
                                    RepositoryItemBOSLookupEdit repLookupEdit = new RepositoryItemBOSLookupEdit();

                                    repLookupEdit.DataSource = ADConfigValueUtility.ConfigValues.Tables[strConfigValueTable];
                                    repLookupEdit.ValueMember = "Value";
                                    repLookupEdit.DisplayMember = "Text";
                                    DevExpress.XtraEditors.Controls.LookUpColumnInfo repColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
                                    repColumn.FieldName = "Text";
                                    repColumn.Width = 100;
                                    repLookupEdit.Columns.Add(repColumn);
                                    repLookupEdit.PopupWidth = repColumn.Width;
                                    column.ColumnEdit = repLookupEdit;
                                    this.RepositoryItems.Add(repLookupEdit);
                                }
                                else
                                {
                                    //Init column repository based on field format group
                                    DevExpress.XtraEditors.Repository.RepositoryItem repItem = InitColumnRepositoryFromFieldFormatGroup(strTableName, objAAColumnAliasInfo.AAColumnAliasName);
                                    if (repItem != null)
                                    {
                                        column.ColumnEdit = repItem;
                                        this.RepositoryItems.Add(repItem);
                                    }
                                }
                            }

                            if (column.ColumnEdit != null)
                                InitColumnRepositoryFormat(column, strTableName, objAAColumnAliasInfo.AAColumnAliasName);
                            else
                            {
                                Type type = BOSUtil.GetColumnDataType(BOSDataSource, column.FieldName);
                                if (type == typeof(DateTime))
                                    column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(RepositoryItem.RepositoryItemDateEdit.ToString());
                                else if (type == typeof(bool))
                                    column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(RepositoryItem.RepositoryItemCheckEdit.ToString());
                                else
                                    column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(RepositoryItem.RepositoryItemTextEdit.ToString());
                                InitColumnRepositoryFormat(column, strTableName, objAAColumnAliasInfo.AAColumnAliasName);
                            }

                            column.OptionsColumn.AllowEdit = false;
                            column.VisibleIndex = objAAColumnAliasInfo.AANumberInt;
                            this.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] { column });
                        }
                    }
                    else
                    {
                        this.Columns[objAAColumnAliasInfo.AAColumnAliasName].Caption = objAAColumnAliasInfo.AAColumnAliasCaption;
                    }

                }
            }

            if (BOSDisplayOption)
            {
                DevExpress.XtraTreeList.Columns.TreeListColumn column = InitTreeListColumn(strTableName, -1, "Selected", ComponentLocalizedResources.Check, 5);
                column.ColumnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
                this.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] { column });
                this.RepositoryItems.Add(column.ColumnEdit);
            }
        }

        protected virtual DevExpress.XtraTreeList.Columns.TreeListColumn InitTreeListColumn(String strTableName, int iVisibleIndex, String strFieldName, String strCaption, int iWidth)
        {
            DevExpress.XtraTreeList.Columns.TreeListColumn column = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            column.Name = "col" + strFieldName;
            column.Caption = strCaption;
            column.FieldName = strFieldName;
            column.VisibleIndex = iVisibleIndex;
            column.Visible = true;
            column.Width = iWidth;
            return column;
        }

        protected virtual RepositoryItemBOSLookupEdit InitColumnLookupEdit(AAColumnAliasInfo columnAlias)
        {
            if (columnAlias == null)
                return null;

            String strDisplayColumn = string.Empty;
            if (!LookupTables.ContainsKey(columnAlias.AAReferenceTable))
            {
                GELookupTablesController lookupTableController = new GELookupTablesController();
                BOSDbUtil dbUtil = new BOSDbUtil();
                GELookupTablesInfo lookupTable = new GELookupTablesInfo();

                if (LookupTableList != null && LookupTableList.Count > 0)
                    lookupTable = LookupTableList.Where(t => t.GELookupTableName == columnAlias.AAReferenceTable).FirstOrDefault();
                if (lookupTable == null || lookupTable.GELookupTableID == 0)
                    lookupTable = lookupTableController.GetObjectByTableName(columnAlias.AAReferenceTable);
                if (lookupTable != null)
                {
                    DataSet ds = ((IBaseModuleERP)Screen.Module).GetLookupTableData(columnAlias.AAReferenceTable);
                    if (!LookupTables.ContainsKey(columnAlias.AAReferenceTable))
                        LookupTables.Add(columnAlias.AAReferenceTable, ds);
                    if (!LookupTablesUpdatedDate.ContainsKey(columnAlias.AAReferenceTable))
                        LookupTablesUpdatedDate.Add(columnAlias.AAReferenceTable, ((IBaseModuleERP)Screen.Module).GetServerDate());
                    if (!LookupTableObjects.ContainsKey(columnAlias.AAReferenceTable))
                        LookupTableObjects.Add(columnAlias.AAReferenceTable, lookupTable);
                    strDisplayColumn = lookupTable.GELookupTableDisplayColumn;
                    ds.Dispose();
                    GC.Collect(0, GCCollectionMode.Forced);
                }
            }
            //[NUThao] [Improve Speed] [2014-09-09]

            if (LookupTables[columnAlias.AAReferenceTable] == null)
            {
                return null;
            }

            RepositoryItemBOSLookupEdit rep = new RepositoryItemBOSLookupEdit();
            rep.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            rep.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            rep.NullText = String.Empty;
            rep.BestFitMode = BestFitMode.BestFitResizePopup;
            rep.Tag = columnAlias.Id;
            //String strPrimaryColumn = ((IBaseModuleERP)Screen.Module).GetTablePrimaryColumn(columnAlias.AAReferenceTable);
            //if (strDisplayColumn.Equals(string.Empty))
            //    strDisplayColumn = GetLookupTableDisplayColumn(columnAlias.AAReferenceTable);
            rep.ValueMember = columnAlias.GELookupTableValueColumn;
            strDisplayColumn = string.Empty;
            if (!string.IsNullOrEmpty(columnAlias.AADisplayedMember))
                strDisplayColumn = columnAlias.AADisplayedMember;
            else
                strDisplayColumn = columnAlias.GELookupTableDisplayColumn;

            rep.DisplayMember = strDisplayColumn;
            DataSet dsTable = ((DataSet)LookupTables[columnAlias.AAReferenceTable]);

            DataTable dt = new DataTable();

            if (dsTable.Tables.Count > 0)
                dt = GetLookupTableByFilterCondition(dsTable.Tables[0], columnAlias.AAReferenceTable, columnAlias.GELookupTableValueColumn,
                                        columnAlias.AAFilteredColumn, columnAlias.AAFilteredValues, true);

            rep.DataSource = dt;
            rep.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            rep.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            rep.NullText = string.Empty;
            dsTable.Dispose();
            dt.Dispose();
            GC.Collect(0, GCCollectionMode.Forced);

            if (!string.IsNullOrEmpty(columnAlias.GELookupTableLookupColumns))
            {
                //LstColumnAlias.Where(a => a.AATableName == strTableName).ToList();
                List<string> columns = columnAlias.GELookupTableLookupColumns.Split(';').ToList();
                if (columns != null)
                {
                    LookUpColumnInfo colName;
                    foreach (string column in columns)
                    {
                        AAColumnAliasInfo alias = LstColumnAlias.Where(a => a.AATableName == columnAlias.AAReferenceTable && a.AAColumnAliasName == column.Trim()).FirstOrDefault();
                        colName = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
                        colName.Caption = alias == null ? column : alias.AAColumnAliasCaption;
                        colName.FieldName = column.Trim();
                        colName.Width = 100;
                        rep.Columns.Add(colName);
                    }
                }
            }
            else
            {
                LookUpColumnInfo colName = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
                colName.Caption = columnAlias.AAColumnAliasCaption;
                colName.FieldName = rep.DisplayMember;
                colName.Width = 100;
                rep.Columns.Add(colName);
            }
            //switch (columnAlias.AAReferenceTable)
            //{
            //    case TableName.ICProductsTableName:
            //        {
            //            InitColumnsForItemLookupEdit(rep);
            //        }
            //        break;
            //    default:
            //        {
            //            LookUpColumnInfo colName = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
            //            colName.Caption = columnCaption;
            //            colName.FieldName = rep.DisplayMember;
            //            colName.Width = 100;
            //            rep.Columns.Add(colName);
            //        }
            //        break;
            //}

            rep.QueryPopUp += new CancelEventHandler(RepositoryItemLookupEdit_QueryPopup);
            rep.Leave += new EventHandler(RepositoryItemBOSLookupEdit_Leave);
            rep.QueryCloseUp += new CancelEventHandler(RepositoryItemLookupEdit_QueryCloseUp);
            rep.KeyDown += new KeyEventHandler(rep_KeyDown);
            return rep;
        }

        protected virtual void RepositoryItemLookupEdit_QueryCloseUp(object sender, CancelEventArgs e)
        {
            //BOSLookupEdit lke = (BOSLookupEdit)sender;
            //DataTable dataSource = (DataTable)lke.Properties.DataSource;
            //if (dataSource.Rows.Count > 0)
            //{
            //    dataSource.Rows.RemoveAt(0);
            //}
        }

        void rep_KeyDown(object sender, KeyEventArgs e)
        {
            //OnKeyDown(e);
            //if ((e.KeyCode == Keys.F10) || (e.Control && e.KeyCode == Keys.F10))
            //{
            //    GridView gr = (GridView)this.DefaultView;
            //    ShowModule(gr.FocusedColumn, gr);
            //}
        }
        private void RepositoryItemBOSLookupEdit_Leave(object sender, EventArgs e)
        {
            //Reset filter
            BOSLookupEdit rep = (BOSLookupEdit)sender;
            object dataSource = rep.Properties.DataSource;
            rep.Properties.DataSource = null;
            rep.Properties.DataSource = dataSource;
        }

        /// <summary>
        /// Init data source for lookup edit from a lookup table
        /// </summary>
        /// <param name="dataSource">Data source</param>
        /// <param name="tableName">Name of table the data source is gotten from</param>
        protected DataTable GetLookupTableByFilterCondition(DataTable ds, string tableName, string valueMember,
                                                    string filteredColumn, string filteredValues, bool allowDummy)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            //Get all data which column "BOSSelectType" contains BOSSelectTypeValue from look up table
            DataTable dataSource = ds;
            if (!String.IsNullOrEmpty(filteredColumn))
            {
                if (dbUtil.ColumnIsExist(tableName, filteredColumn))
                {
                    //uthv 28062017 - optimize speed - must be clone table before any change
                    dataSource = ds.Copy();

                    string[] selectTypeValues = filteredValues.Split(new char[] { ';' });
                    DataTable datafilter = ds.Clone();
                    foreach (string selectTypeValue in selectTypeValues)
                    {
                        if (dataSource != null && dataSource.Rows.Count > 0 && dataSource.Columns[filteredColumn] != null)
                        {
                            var data = dataSource.Rows.Cast<DataRow>().Where(x => (x[filteredColumn] != null ? x[filteredColumn].ToString().Trim().ToLower() : string.Empty)
                                                                        == selectTypeValue.Trim().ToLower()).AsEnumerable();
                            if (data != null && data.Any())
                                datafilter.Merge(data.CopyToDataTable());
                        }
                    }
                    dataSource = datafilter;
                }

            }


            bool hasDummyRow = false;
            if (allowDummy)
            {
                if (dataSource.Rows.Count > 0 && valueMember != null && valueMember != string.Empty)
                {
                    object value = dataSource.Columns[valueMember] != null ? dataSource.Rows[0][valueMember] : 0;
                    if (value is int)
                    {
                        if (Convert.ToInt32(value) > 0)
                        {
                            DataRow row = dataSource.NewRow();
                            foreach (DataColumn column in row.Table.Columns)
                            {
                                if (column.ColumnName != valueMember)
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
                            row[valueMember] = 0;
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
                                if (column.ColumnName != valueMember)
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
                            row[valueMember] = string.Empty;
                            dataSource.Rows.InsertAt(row, 0);
                            hasDummyRow = true;
                        }
                    }
                }
            }
            return dataSource;
        }



        private void RefreshLookupEditDataSource(BOSLookupEdit lke)
        {

            if (lke == null)
                return;

            BOSDbUtil dbUtil = new BOSDbUtil();

            int id = 0;
            if (lke.Properties.Tag != null)
            {
                int.TryParse(lke.Properties.Tag.ToString(), out id);
            }

            string strLookupTable = string.Empty;
            AAColumnAliasInfo alias = null;
            if (id > 0)
            {
                alias = LstColumnAlias.FirstOrDefault(a => a.Id == id);
                if (alias != null)
                    strLookupTable = alias.AAReferenceTable;
            }

            if (string.IsNullOrEmpty(strLookupTable))
                return;

            DateTime dtLastCreatedDate = dbUtil.GetLastCreatedDateOfTable(strLookupTable);
            DateTime dtLastUpdatedDate = dbUtil.GetLastUpdatedDateOfTable(strLookupTable);
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
            TimeSpan cRDate = (dtLastCreatedDate - epoch);
            TimeSpan uDDate = (dtLastUpdatedDate - epoch);
            TimeSpan lKDate = (((DateTime)LookupTablesUpdatedDate[strLookupTable]) - epoch);
            if (cRDate.TotalSeconds > lKDate.TotalSeconds || uDDate.TotalSeconds > lKDate.TotalSeconds)
            {
                //Refesh Data Source
                IBusinessController objLookupTableController = BusinessControllerFactory.GetBusinessController(strLookupTable + "Controller");
                if (objLookupTableController != null)
                {
                    DataSet ds = ((IBaseModuleERP)Screen.Module).GetLookupTableData(strLookupTable);
                    if (ds.Tables.Count > 0)
                    {
                        DateTime updatedDate = ((IBaseModuleERP)Screen.Module).GetServerDate();
                        // Update Last Updated Date of Lookup Table
                        LookupTablesUpdatedDate[strLookupTable] = updatedDate;
                        ((DataSet)LookupTables[strLookupTable]).Tables.Clear();
                        ((DataSet)LookupTables[strLookupTable]).Tables.Add(ds.Tables[0].Copy());
                    }
                    ds.Dispose();
                    GC.Collect(0, GCCollectionMode.Forced);
                }

            }
            DataTable dataSource = ((DataSet)LookupTables[strLookupTable]).Tables[0];
            if (dataSource.Rows.Count == 0 || Convert.ToInt32(dataSource.Rows[0][lke.Properties.ValueMember]) != 0)
            {
                DataRow row = dataSource.NewRow();
                row[lke.Properties.ValueMember] = 0;
                dataSource.Rows.InsertAt(row, 0);
            }
            DataTable dt = dataSource;

            if (alias != null && !string.IsNullOrEmpty(alias.AAFilteredColumn))
            {
                dt = GetLookupTableByFilterCondition(dataSource, alias.AAReferenceTable, alias.GELookupTableValueColumn,
                                            alias.AAFilteredColumn, alias.AAFilteredValues, true);
            }

            lke.Properties.DataSource = dt;
            dataSource.Dispose();
            dt.Dispose();
            GC.Collect(0, GCCollectionMode.Forced);
        }


        protected virtual DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit InitColumnLookupEdit(String strTableName, String strColumnName)
        {
            RepositoryItemBOSLookupEdit rep = new RepositoryItemBOSLookupEdit();
            rep.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            rep.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            rep.NullText = String.Empty;
            //String strLookupTable = new BOSDbUtil().GetPrimaryTableWhichForeignColumnReferenceTo(strTableName, strColumnName);
            String strLookupTable = ((IBaseModuleERP)Screen.Module).GetTreePrimaryTableWhichForeignColumnReferenceTo(strTableName, strColumnName);
            if (LookupTables[strLookupTable] == null)
                return null;

            rep.DataSource = ((DataSet)LookupTables[strLookupTable]).Tables[0];
            //String strPrimaryColumn = new BOSDbUtil().GetTablePrimaryColumn(strLookupTable);
            String strPrimaryColumn = ((IBaseModuleERP)Screen.Module).GetTablePrimaryColumn(strLookupTable);
            String strDisplayColumn = GetLookupTableDisplayColumn(strLookupTable);
            rep.ValueMember = strPrimaryColumn;
            rep.DisplayMember = strDisplayColumn;

            rep.QueryPopUp += new CancelEventHandler(RepositoryItemLookupEdit_QueryPopup);

            DevExpress.XtraEditors.Controls.LookUpColumnInfo colName = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
            colName.FieldName = strDisplayColumn;
            colName.Caption = strDisplayColumn.Substring(strPrimaryColumn.Length - 2);
            colName.Width = 100;

            rep.Columns.Add(colName);

            return rep;
        }

        protected virtual String GetLookupTableDisplayColumn(String strLookupTableName)
        {
            //Get GELookupTableDisplayColumn from GELookupTables
            GELookupTablesInfo objLookupTablesInfo = LookupTableList.Where(t => t.GELookupTableName == strLookupTableName).FirstOrDefault();
            if (objLookupTablesInfo != null && !String.IsNullOrEmpty(objLookupTablesInfo.GELookupTableDisplayColumn))
                return objLookupTablesInfo.GELookupTableDisplayColumn;
            //If not exist, get default display column
            BOSDbUtil dbUtil = new BOSDbUtil();
            String strPrimaryColumn = ((IBaseModuleERP)Screen.Module).GetTablePrimaryColumn(strLookupTableName);
            String prefix = strPrimaryColumn.Substring(0, strPrimaryColumn.Length - 2);
            if (dbUtil.ColumnIsExist(strLookupTableName, prefix + "Name"))
                return prefix + "Name";
            else if (dbUtil.ColumnIsExist(strLookupTableName, prefix + "No"))
                return prefix + "No";
            return String.Empty;
        }

        protected virtual void RepositoryItemLookupEdit_QueryPopup(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            RefreshLookupEditDataSource(lke);
        }

        protected virtual DevExpress.XtraEditors.Repository.RepositoryItem InitColumnRepositoryFromFieldFormatGroup(String strTableName, String strColumnName)
        {
            STFieldFormatGroupsInfo objFieldFormatGroupsInfo = FieldFormatList.Where(f => f.TableName == strTableName && f.ColumnName == strColumnName &&
               ((_screen.Module != null && _screen.Module.ModuleID == f.STModuleID) || (_screen.Module == null) || (_screen.Module.ModuleID == 0))).FirstOrDefault();

            if (objFieldFormatGroupsInfo == null)
                objFieldFormatGroupsInfo = FieldFormatList.Where(f => f.TableName == strTableName && f.ColumnName == strColumnName).FirstOrDefault();

            if (objFieldFormatGroupsInfo != null)
            {
                if (!String.IsNullOrEmpty(objFieldFormatGroupsInfo.STFieldFormatGroupRepository))
                {
                    return BOSUtil.GetRepositoryItemFromText(objFieldFormatGroupsInfo.STFieldFormatGroupRepository);
                }
            }
            return null;
        }

        protected virtual void InitColumnRepositoryFormat(DevExpress.XtraTreeList.Columns.TreeListColumn column, String strTableName, String strColumnName)
        {
            STFieldFormatGroupsInfo objFieldFormatGroupsInfo = FieldFormatList.Where(f => f.TableName == strTableName && f.ColumnName == strColumnName &&
               ((_screen.Module != null && _screen.Module.ModuleID == f.STModuleID) || (_screen.Module == null) || (_screen.Module.ModuleID == 0))).FirstOrDefault();

            if (objFieldFormatGroupsInfo == null)
                objFieldFormatGroupsInfo = FieldFormatList.Where(f => f.TableName == strTableName && f.ColumnName == strColumnName).FirstOrDefault();

            if (objFieldFormatGroupsInfo != null)
            {
                DevExpress.XtraEditors.Repository.RepositoryItem rep = column.ColumnEdit;
                if (objFieldFormatGroupsInfo.STFieldFormatGroupBackColor > 0)
                {
                    rep.Appearance.BackColor = Color.FromArgb(objFieldFormatGroupsInfo.STFieldFormatGroupBackColor);
                    rep.Appearance.Options.UseBackColor = true;
                }
                if (objFieldFormatGroupsInfo.STFieldFormatGroupForeColor > 0)
                {
                    rep.Appearance.ForeColor = Color.FromArgb(objFieldFormatGroupsInfo.STFieldFormatGroupForeColor);
                    rep.Appearance.Options.UseForeColor = true;
                }

                String strDefaultFontName = "Tahoma";
                float fDefaultFontSize = 8.25F;
                if (!String.IsNullOrEmpty(objFieldFormatGroupsInfo.STFieldFormatGroupFontName))
                    strDefaultFontName = objFieldFormatGroupsInfo.STFieldFormatGroupFontName;
                if (objFieldFormatGroupsInfo.STFieldFormatGroupFontSize > 0)
                    fDefaultFontSize = objFieldFormatGroupsInfo.STFieldFormatGroupFontSize;
                rep.Appearance.Font = new Font(strDefaultFontName, fDefaultFontSize);
                rep.Appearance.Options.UseFont = true;

                if (BOSUtil.IsEditRepository(rep))
                {
                    DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repText = (DevExpress.XtraEditors.Repository.RepositoryItemTextEdit)rep;
                    if (objFieldFormatGroupsInfo.STFieldFormatGroupDecimalRound > 0)
                    {
                        repText.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                        repText.Mask.EditMask = String.Format("n{0}", objFieldFormatGroupsInfo.STFieldFormatGroupDecimalRound);
                        repText.Mask.UseMaskAsDisplayFormat = true;
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(objFieldFormatGroupsInfo.STFieldFormatGroupMaskType))
                        {
                            repText.Mask.MaskType = BOSUtil.GetMaskTypeFromText(objFieldFormatGroupsInfo.STFieldFormatGroupMaskType);
                            repText.Mask.EditMask = objFieldFormatGroupsInfo.STFieldFormatGroupMaskEdit;
                            repText.Mask.UseMaskAsDisplayFormat = true;
                        }
                        if (!String.IsNullOrEmpty(objFieldFormatGroupsInfo.STFieldFormatGroupFormatType))
                        {
                            repText.DisplayFormat.FormatType = BOSUtil.GetFormatTypeFromText(objFieldFormatGroupsInfo.STFieldFormatGroupFormatType);
                            repText.DisplayFormat.FormatString = objFieldFormatGroupsInfo.STFieldFormatGroupFormatString;
                        }
                    }
                }
            }
        }

        protected virtual void InitTreeListDataSource()
        {

        }

        public DevExpress.XtraTreeList.Nodes.TreeListNode GetSelectedNode()
        {
            if (this.FocusedNode != null)
                return this.FocusedNode;
            else if (BOSDisplayRoot)
                return this.Nodes.FirstNode;
            else
                return null;
        }

        public static BOSTreeListControl Instance(String strInstanceName, String strModuleName)
        {
            if (!String.IsNullOrEmpty(strInstanceName))
            {
                Assembly BOSERPAssembly = Assembly.LoadFrom(Application.StartupPath + "\\BOSERP.exe");
                Type treeListType = BOSERPAssembly.GetType("BOSERP.Modules." + strModuleName + "." + strInstanceName + "TreeListControl");
                if (treeListType != null)
                {
                    return (BOSTreeListControl)treeListType.InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                }
                else
                {
                    treeListType = BOSERPAssembly.GetType("BOSERP." + strInstanceName + "TreeListControl");
                    if (treeListType != null)
                        return (BOSTreeListControl)treeListType.InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                    else
                        return new BOSTreeListControl();
                }
            }
            else
                return new BOSTreeListControl();
        }

        #region Save custom column
        /// <summary>
        /// Save customize columns of BOSGridControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="strEventName"></param>
        /// <BOSparam name="GridControlName" type="String"></BOSparam>
        public void SaveCustomizeColumn()
        {
            if (BOSLib.BysGateway.CurrentUsersInfo.ADUserIsCustomizeColumn)
            {
                DialogResult rs = MessageBox.Show(ComponentLocalizedResources.SaveConfigForSystemMessages, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    SaveDefaultColumnSystem();
                }
            }
            SaveUserDataColumnGridControl();
            MessageBox.Show(ComponentLocalizedResources.SaveSuccessfully, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        protected virtual void SaveUserDataColumnGridControl()
        {
            string directoryPath = string.Empty;
            if (string.IsNullOrWhiteSpace(BOSLib.BysGateway.ProjectCode))
                directoryPath = BOSLib.BysGateway.UserDataDirectoryPath + BOSLib.BysGateway.CurrentUsersInfo.ADUserName + @"\GridControls\" + Screen.Module.Name + @"\";
            else
                directoryPath = BOSLib.BysGateway.UserDataDirectoryPath + @"[" + BOSLib.BysGateway.ProjectCode + @"]\" + BOSLib.BysGateway.CurrentUsersInfo.ADUserName + @"\GridControls\" + Screen.Module.Name + @"\";

            string filePath = directoryPath + string.Format("{0}.xml", this.Name);
            if (!System.IO.Directory.Exists(directoryPath))
                System.IO.Directory.CreateDirectory(directoryPath);

            this.SaveLayoutToXml(filePath);
        }
        protected virtual void RecoveryDefaultColumnGridControl()
        {
            string directoryPath = string.Empty;
            if (string.IsNullOrWhiteSpace(BOSLib.BysGateway.ProjectCode))
                directoryPath = BOSLib.BysGateway.UserDataDirectoryPath + BOSLib.BysGateway.CurrentUsersInfo.ADUserName + @"\GridControls\" + Screen.Module.Name + @"\";
            else
                directoryPath = BOSLib.BysGateway.UserDataDirectoryPath + @"[" + BOSLib.BysGateway.ProjectCode + @"]\" + BOSLib.BysGateway.CurrentUsersInfo.ADUserName + @"\GridControls\" + Screen.Module.Name + @"\";

            string filePath = directoryPath + string.Format("{0}.xml", this.Name);
            if (System.IO.File.Exists(filePath))
            {
                try
                {
                    this.RestoreLayoutFromXml(filePath);
                    foreach (TreeListColumn column in this.Columns)
                    {
                        AAColumnAliasInfo objAAColumnAliasInfo = LstColumnAlias.Where(a => a.AATableName == BOSDataSource && a.AAColumnAliasName == column.FieldName).FirstOrDefault();
                        if (objAAColumnAliasInfo == null) continue;
                        if (!string.IsNullOrEmpty(objAAColumnAliasInfo.AAReferenceTable))
                        {
                            //if (!string.IsNullOrEmpty(objAAColumnAliasInfo.AAReferenceTable))
                            //RepositoryItemBOSLookupEdit repLookupEdit = InitColumnLookupEdit(strTableName, objAAColumnAliasInfo.AAColumnAliasName, objAAColumnAliasInfo.AAColumnAliasCaption);
                            RepositoryItemBOSLookupEdit repLookupEdit = InitColumnLookupEdit(objAAColumnAliasInfo);
                            if (repLookupEdit != null)
                            {
                                column.ColumnEdit = repLookupEdit;
                                this.RepositoryItems.Add(repLookupEdit);
                            }
                        }
                        else if (((IBaseModuleERP)Screen.Module).IsForeignKey(BOSDataSource, objAAColumnAliasInfo.AAColumnAliasName))
                        {
                            DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookupEdit = InitColumnLookupEdit(BOSDataSource, objAAColumnAliasInfo.AAColumnAliasName);
                            if (repLookupEdit != null)
                            {
                                column.ColumnEdit = repLookupEdit;
                                this.RepositoryItems.Add(repLookupEdit);
                            }
                        }
                        else
                        {
                            String strConfigValueTable = String.Empty;

                            if (objAAColumnAliasInfo.AAColumnAliasName.EndsWith("Combo"))
                                strConfigValueTable = objAAColumnAliasInfo.AAColumnAliasName.Substring(2, objAAColumnAliasInfo.AAColumnAliasName.Length - 7);
                            else
                                strConfigValueTable = objAAColumnAliasInfo.AAColumnAliasName.Substring(2, objAAColumnAliasInfo.AAColumnAliasName.Length - 2);

                            if (ADConfigValueUtility.ConfigValues.Tables[strConfigValueTable] != null)
                            {
                                RepositoryItemBOSLookupEdit repLookupEdit = new RepositoryItemBOSLookupEdit();

                                repLookupEdit.DataSource = ADConfigValueUtility.ConfigValues.Tables[strConfigValueTable];
                                repLookupEdit.ValueMember = "Value";
                                repLookupEdit.DisplayMember = "Text";
                                DevExpress.XtraEditors.Controls.LookUpColumnInfo repColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
                                repColumn.FieldName = "Text";
                                repColumn.Width = 100;
                                repLookupEdit.Columns.Add(repColumn);
                                repLookupEdit.PopupWidth = repColumn.Width;
                                column.ColumnEdit = repLookupEdit;
                                this.RepositoryItems.Add(repLookupEdit);
                            }
                            else
                            {
                                //Init column repository based on field format group
                                DevExpress.XtraEditors.Repository.RepositoryItem repItem = InitColumnRepositoryFromFieldFormatGroup(BOSDataSource, objAAColumnAliasInfo.AAColumnAliasName);
                                if (repItem != null)
                                {
                                    column.ColumnEdit = repItem;
                                    this.RepositoryItems.Add(repItem);
                                }
                            }
                        }

                        if (column.ColumnEdit != null)
                            InitColumnRepositoryFormat(column, BOSDataSource, objAAColumnAliasInfo.AAColumnAliasName);
                        else
                        {
                            Type type = BOSUtil.GetColumnDataType(BOSDataSource, column.FieldName);
                            if (type == typeof(DateTime))
                                column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(RepositoryItem.RepositoryItemDateEdit.ToString());
                            else if (type == typeof(bool))
                                column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(RepositoryItem.RepositoryItemCheckEdit.ToString());
                            else
                                column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(RepositoryItem.RepositoryItemTextEdit.ToString());
                            InitColumnRepositoryFormat(column, BOSDataSource, objAAColumnAliasInfo.AAColumnAliasName);
                        }
                    }
                }
                catch (Exception) { }
            }
        }
        protected virtual void SaveDefaultColumnSystem()
        {
            STFieldsInfo objSTFieldsInfo = GetAssociatedField();
            if (objSTFieldsInfo == null)
            {
                objSTFieldsInfo = new STFieldsInfo();
                objSTFieldsInfo.STFieldName = this.Name;
                objSTFieldsInfo.STFieldGroup = BOSScreen.cstFieldGroupSearch;
                objSTFieldsInfo.STScreenID = Screen == null ? 0 : Screen.ScreenID;
                objSTFieldsInfo.STFieldDataSource = BOSDataSource;
                objSTFieldsInfo.STModuleID = Screen == null ? 0 : (Screen.Module == null ? 0 : Screen.Module.ModuleID);
                new STFieldsController().CreateObject(objSTFieldsInfo);
                ((IBaseModuleERP)Screen.Module).AddSystemField(objSTFieldsInfo);
            }
            if (objSTFieldsInfo != null)
            {
                STFieldColumnsController objSTFieldColumnsController = new STFieldColumnsController();
                objSTFieldColumnsController.DeleteBySTFieldIDAndCommodityType(objSTFieldsInfo.STFieldID, string.Empty);
                ((IBaseModuleERP)Screen.Module).RemoveSystemFieldColumnsByFieldID(objSTFieldsInfo.STFieldID, string.Empty);
                List<STFieldColumnsInfo> fieldColumns = new List<STFieldColumnsInfo>();
                foreach (TreeListColumn column in this.Columns)
                {
                    if (column.Visible)
                    {
                        STFieldColumnsInfo objSTFieldColumnsInfo = new STFieldColumnsInfo();
                        objSTFieldColumnsInfo.STFieldID = objSTFieldsInfo.STFieldID;
                        objSTFieldColumnsInfo.STFieldColumnFieldName = column.FieldName;
                        objSTFieldColumnsInfo.STFieldColumnName = column.Name;
                        objSTFieldColumnsInfo.STFieldColumnCaption = column.Caption;
                        objSTFieldColumnsInfo.STFieldColumnWidth = column.Width;
                        objSTFieldColumnsInfo.STFieldColumnVisibleIndex = column.VisibleIndex;
                        objSTFieldColumnsInfo.STFieldColumnCommodityType = string.Empty;

                        objSTFieldColumnsController.CreateObject(objSTFieldColumnsInfo);
                        fieldColumns.Add(objSTFieldColumnsInfo);
                    }
                }
                ((IBaseModuleERP)Screen.Module).AddSystemFieldColumns(fieldColumns);
            }
        }
        /// <summary>
        /// Get the field associating with the control
        /// </summary>
        /// <return>Field object</return>
        private STFieldsInfo GetAssociatedField()
        {
            STFieldsInfo objSTFieldsInfo = null;
            if (Screen.Fields.ContainsKey(Name))
            {
                objSTFieldsInfo = Screen.Fields[Name];
            }
            if (objSTFieldsInfo == null)
            {
                objSTFieldsInfo = FieldList.Where(f => f.STModuleID == Screen.Module.ModuleID && f.STUserGroupID == UserGroup.Admin && f.STFieldName == Name).FirstOrDefault();
                if (objSTFieldsInfo == null)
                {
                    //The grid control is generated by code behind and used for search screen
                    objSTFieldsInfo = FieldList.Where(f => f.STFieldName == this.Name && f.STFieldGroup == BOSScreen.cstFieldGroupSearch).FirstOrDefault();
                }
            }
            return objSTFieldsInfo;
        }
        #endregion

        /// <summary>
        /// Invalidate lookup edit columns to reflect all changes of lookup table
        /// </summary>
        public virtual void InvalidateLookupEditColumns()
        {
            foreach (DevExpress.XtraTreeList.Columns.TreeListColumn column in this.Columns)
            {
                if (column.ColumnEdit != null && column.ColumnEdit is DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rep = (DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)column.ColumnEdit;
                    String strLookupTable = ((IBaseModuleERP)Screen.Module).GetTreePrimaryTableWhichForeignColumnReferenceTo(BOSDataSource, column.FieldName);
                    //Update lookup table if there is any changes to it
                    DateTime dtLastCreatedDate = dbUtil.GetLastCreatedDateOfTable(strLookupTable);
                    DateTime dtLastUpdatedDate = dbUtil.GetLastUpdatedDateOfTable(strLookupTable);
                    DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
                    TimeSpan cRDate = (dtLastCreatedDate - epoch);
                    TimeSpan uDDate = (dtLastUpdatedDate - epoch);
                    TimeSpan lKDate = (((DateTime)LookupTablesUpdatedDate[strLookupTable]) - epoch);
                    if (cRDate.TotalSeconds > lKDate.TotalSeconds || uDDate.TotalSeconds > lKDate.TotalSeconds)
                    {
                        //Refesh Data Source
                        IBusinessController objLookupTableController = BusinessControllerFactory.GetBusinessController(strLookupTable + "Controller");
                        if (objLookupTableController != null)
                        {
                            DataSet ds = ((IBaseModuleERP)Screen.Module).GetLookupTableData(strLookupTable);
                            if (ds.Tables.Count > 0)
                            {
                                DateTime updatedDate = ((IBaseModuleERP)Screen.Module).GetServerDate();
                                // Update Last Updated Date of Lookup Table
                                LookupTablesUpdatedDate[strLookupTable] = updatedDate;
                                ((DataSet)LookupTables[strLookupTable]).Tables.Clear();
                                ((DataSet)LookupTables[strLookupTable]).Tables.Add(ds.Tables[0].Copy());
                            }
                            ds.Dispose();
                            GC.Collect(0, GCCollectionMode.Forced);
                        }
                    }

                    rep.DataSource = ((DataSet)LookupTables[strLookupTable]).Tables[0];
                }
            }
        }

        public override TreeListNode FindNodeByFieldValue(string fieldName, object cellValue)
        {
            return FindNodeByFieldValue(Nodes, fieldName, cellValue);
        }

        private TreeListNode FindNodeByFieldValue(TreeListNodes nodes, string fieldName, object cellValue)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (TreeListNode node in nodes)
            {
                BOSTreeListObject obj = (BOSTreeListObject)GetDataRecordByNode(node);
                object value = dbUtil.GetPropertyValue(obj, fieldName);
                if (value != null && value.Equals(cellValue))
                {
                    return node;
                }
                if (node.Nodes.Count > 0)
                {
                    TreeListNode childNode = FindNodeByFieldValue(node.Nodes, fieldName, cellValue);
                    if (childNode != null)
                    {
                        return childNode;
                    }
                }
            }
            return null;
        }

        public void EnableColumns(int visibleIndex, string fieldName, bool readOnly, bool allowEdit, bool allowSummary, string formatString)
        {
            TreeListColumn column;

            column = this.Columns.ColumnByFieldName(fieldName);
            if (column != null)
            {
                column.VisibleIndex = visibleIndex;
                column.OptionsColumn.AllowEdit = allowEdit;
                column.OptionsColumn.ReadOnly = readOnly;
                this.OptionsView.AutoWidth = false;

                column.OptionsColumn.FixedWidth = false;

                if (allowEdit)
                {
                    column.AllNodesSummary = true;
                    column.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom;
                }
                if (!string.IsNullOrEmpty(formatString))
                    column.RowFooterSummaryStrFormat = formatString;
            }
        }

        public virtual void FormatNumbericColumn(TreeListColumn column, bool allowEdit, string formatType)
        {
            RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit()
            {
                Mask =
                {
                    MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric,
                    EditMask = formatType,
                    UseMaskAsDisplayFormat = true
                }
            };
            repositoryItemTextEdit.DisplayFormat.FormatType = FormatType.Numeric;
            repositoryItemTextEdit.DisplayFormat.FormatString = formatType;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.ColumnEdit = repositoryItemTextEdit;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }
    }
}
