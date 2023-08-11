using BOSCommon.Constants;
using BOSCommon.Enums;
using BOSCommon.Extensions;
using BOSComponent;
using BOSLib;
using BOSLib.Extensions;
using BOSLib.Interfaces;
using Dapper;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BOSERP
{
    public class BOSList<T> : List<T>, IBOSList<T>, ICloneable
        where T : BusinessObject, new()
    {
        #region Constant
        public const String cstRelationForeign = "Foreign";
        public const String cstRelationParent = "Parent";
        public const String cstRelationSwitcher = "Switcher";
        public const String cstRelationNone = "None";

        #endregion

        #region variables
        protected ERPModuleEntities _entity = new ERPModuleEntities();
        protected String _relation;
        protected String _parentTableName;
        protected String _itemTableName;
        protected BOSGridControl _gridControl;
        protected String _itemTableForeignKey;
        protected int _currentIndex;
        protected IList<T> _originalList = new List<T>();
        protected bool IsEndCurrentEdit = false;

        /// <summary>
        /// A variable to indicate whether the new item row of the list is inputing
        /// </summary>
        protected bool IsInputingNewRow = false;
        #endregion

        #region Public Properties
        public ERPModuleEntities Entity
        {
            get
            {
                return _entity;
            }
            set
            {
                _entity = value;
            }
        }

        public String Relation
        {
            get
            {
                return _relation;
            }

            set
            {
                _relation = value;
            }
        }

        public BOSGridControl GridControl
        {
            get
            {
                return _gridControl;
            }
            set
            {
                _gridControl = value;
            }
        }

        public DevExpress.XtraGrid.Views.Grid.GridView GridView
        {
            get
            {
                if (GridControl != null)
                {
                    if (GridControl.Views[0] is GridView)
                    {
                        return (GridView)GridControl.Views[0];
                    }
                    return null;
                }
                return null;
            }
        }

        public String ParentTableName
        {
            get
            {
                return _parentTableName;
            }
            set
            {
                _parentTableName = value;
            }
        }

        public String ItemTableName
        {
            get
            {
                return _itemTableName;
            }

            set
            {
                _itemTableName = value;
            }
        }

        public String ItemTableForeignKey
        {
            get
            {
                return _itemTableForeignKey;
            }
            set
            {
                _itemTableForeignKey = value;
            }
        }

        public int CurrentIndex
        {
            get
            {
                if (GridView != null)
                {
                    return GridView.GetDataSourceRowIndex(GridView.FocusedRowHandle);
                }
                return -1;
            }
        }

        public IList<T> OriginalList
        {
            get
            {
                return _originalList;
            }
            set
            {
                _originalList = value;
            }
        }

        /// <summary>
        /// Gets or sets the list used to back up the current list for rollback action
        /// </summary>
        public IList<T> BackupList { get; set; }
        #endregion

        #region Constructor
        public BOSList()
        {
            BackupList = new List<T>();
            FieldNameNotInChanged = new List<string>();
        }

        public BOSList(ERPModuleEntities entity, String strParentTaleName, String strItemTableName)
            : this()
        {
            InitBOSList(entity, strParentTaleName, strItemTableName);
        }

        public BOSList(string itemTableName)
            : this()
        {
            InitBOSList(null, string.Empty, itemTableName);
        }
        #endregion

        #region Init
        public void InitBOSList(object entity, string parentTableName, string itemTableName)
        {
            InitBOSList((ERPModuleEntities)entity, parentTableName, itemTableName);
        }

        public void InitBOSList(object entity, string parentTableName, string itemTableName, string relation)
        {
            InitBOSList((ERPModuleEntities)entity, parentTableName, itemTableName, relation);
        }

        public void InitBOSList(ERPModuleEntities ent, String strParentTableName, String strItemTableName)
        {
            Entity = ent;
            BOSDbUtil dbUtil = new BOSDbUtil();
            ParentTableName = strParentTableName;
            ItemTableName = strItemTableName;
            if (!String.IsNullOrEmpty(ParentTableName))
            {
                String strParentTablePrimaryColumn = BOSApp.GetTablePrimaryColumn(ParentTableName);
                String strItemTablePrimaryColumn = BOSApp.GetTablePrimaryColumn(ItemTableName);
                ItemTableForeignKey = "FK_" + strParentTablePrimaryColumn;
                if (dbUtil.ColumnIsExist(ItemTableName, ItemTableForeignKey))
                    Relation = cstRelationForeign;
                else
                {
                    if (ItemTableName.Equals(ParentTableName))
                    {
                        Relation = cstRelationParent;
                        ItemTableForeignKey = ItemTableName.Substring(0, ItemTableName.Length - 1) + "ParentID";
                    }
                    else
                        Relation = cstRelationNone;
                }
            }
            else
            {
                Relation = cstRelationNone;
            }
        }

        /// <summary>
        /// Init BOS list with given relation
        /// </summary>
        public void InitBOSList(ERPModuleEntities ent, String strParentTableName, String strItemTableName, String strRelation)
        {
            Entity = ent;
            BOSDbUtil dbUtil = new BOSDbUtil();
            ParentTableName = strParentTableName;
            ItemTableName = strItemTableName;
            Relation = strRelation;
            switch (strRelation)
            {
                case cstRelationForeign:
                    {
                        String strParentTablePrimaryColumn = BOSApp.GetTablePrimaryColumn(ParentTableName);
                        String strItemTablePrimaryColumn = BOSApp.GetTablePrimaryColumn(ItemTableName);
                        ItemTableForeignKey = "FK_" + strParentTablePrimaryColumn;
                        break;
                    }
                case cstRelationParent:
                    {
                        ItemTableForeignKey = ItemTableName.Substring(0, ItemTableName.Length - 1) + "ParentID";
                        break;
                    }
            }
        }

        public virtual void InitBOSListGridControl()
        {
            String strGridControlName = "fld_dgc" + ItemTableName;
            InitBOSListGridControl(strGridControlName);
        }

        public virtual void InitBOSListGridControl(String strGridControlName)
        {
            if (Entity.Module != null && Entity.Module.Controls[strGridControlName] != null)
            {
                InitBOSListGridControl((BOSGridControl)Entity.Module.Controls[strGridControlName]);
            }
        }

        public virtual void InitBOSListGridControl(BOSGridControl gridControl)
        {
            GridControl = gridControl;
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)this.GridControl.Views[0];
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(GridView_FocusedRowChanged);
            gridView.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(GridView_CellValueChanging);
        }

        public void SetDefaultListAndRefreshGridControl()
        {
            this.Clear();
            this.OriginalList.Clear();
            this.BackupList.Clear();
            GridControl?.RefreshDataSource();
        }
        #endregion

        #region Invalidate
        public virtual void Invalidate(int iObjectID)
        {
            //Invalidate lookup edit columns to reflect all changes of lookup table
            //if (GridControl != null)
            //    GridControl.InvalidateLookupEditColumns();

            BOSDbUtil dbUtil = new BOSDbUtil();
            IBusinessController objItemController = BusinessControllerFactory.GetBusinessController(ItemTableName + "Controller");
            DataSet ds = new DataSet();

            if (Relation.Equals(cstRelationForeign))
            {
                ds = objItemController.GetAllDataByForeignColumn(ItemTableForeignKey, iObjectID);

            }
            else if (Relation.Equals(cstRelationParent))
            {
                ds = objItemController.GetAllObjectsByObjectParentID(iObjectID);
            }
            else if (Relation.Equals(cstRelationNone))
            {
                ds = objItemController.GetAllObjects();
            }
            DataView view = ds.Tables[0].DefaultView;
            string ID = ItemTableName.Substring(0, ItemTableName.Length - 1) + "ID";
            view.Sort = ID + " ASC";
            DataTable sortIDData = view.ToTable();
            ds.Clear();
            ds.Merge(sortIDData);
            Invalidate(ds);
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
        }

        public virtual void Invalidate(DataSet ds)
        {
            if (ds.Tables.Count > 0)
            {
                Invalidate(ds.Tables[0]);
                ds.Dispose();
                GC.Collect(0, GCCollectionMode.Forced);
            }
        }

        /// <summary>
        /// Invalidate based on a table
        /// </summary>
        /// <param name="table">Table contains object list</param>
        public virtual void Invalidate(DataTable table)
        {
            this.Clear();
            OriginalList.Clear();
            BackupList.Clear();
            BOSDisposeUtility.DisposeAll(this, 0, GCCollectionMode.Forced);
            BOSDisposeUtility.DisposeAll(OriginalList, 0, GCCollectionMode.Forced);
            BOSDisposeUtility.DisposeAll(BackupList, 0, GCCollectionMode.Forced);
            IBusinessController objItemController = BusinessControllerFactory.GetBusinessController(ItemTableName + "Controller");
            foreach (DataRow row in table.Rows)
            {
                T objT = (T)objItemController.GetObjectFromDataRow(row);
                this.Add(objT);

                //Invalidate original list same as itself
                OriginalList.Add((T)objT.Clone());
                //Invalidate backup list same as itself                
                BackupList.Add((T)objT.Clone());
            }


            //Refresh Grid if Grid is not null
            if (GridControl != null)
            {
                GridControl.RefreshDataSource();
                if (this.Count > 0)
                {
                    if (CurrentIndex >= 0 && CurrentIndex < Count)
                    {
                        GridViewFocusRow(CurrentIndex);
                    }
                    else
                    {
                        GridViewFocusRow(0);
                    }
                }
                else
                {
                    Entity.InvalidateModuleObject(BusinessObjectFactory.GetBusinessObject(ItemTableName + "Info"));
                }
            }
            table.Dispose();
            GC.Collect(0, GCCollectionMode.Forced);
        }

        /// <summary>
        /// Invalidate based on a list 
        /// </summary>
        /// <param name="lst">Object list</param>
        public virtual void Invalidate(IList<T> lst)
        {
            this.Clear();
            BOSDisposeUtility.DisposeAll(this, 0, GCCollectionMode.Forced);
            foreach (T obj in lst)
            {
                T newT = (T)obj; //.Clone();
                if (newT != null)
                    this.Add(newT);
                else
                    break;
            }

            //Invalidate original list same as itself

            OriginalList.Clear();
            BOSDisposeUtility.DisposeAll(OriginalList, 0, GCCollectionMode.Forced);
            foreach (T obj in this)
            {
                T newT = (T)obj.Clone();
                if (newT != null)
                    OriginalList.Add(newT);
                else
                    break;
            }

            //Invalidate backup list same as itself

            BackupList.Clear();
            BOSDisposeUtility.DisposeAll(BackupList, 0, GCCollectionMode.Forced);
            foreach (T obj in this)
            {
                T newT = (T)obj.Clone();
                if (newT != null)
                    BackupList.Add(newT);
                else
                    break;
            }

            if (GridControl != null && GridControl.MainView != null)
            {
                GridControl.RefreshDataSource();
                if (this.Count > 0)
                {
                    if (CurrentIndex >= 0 && CurrentIndex < Count)
                    {
                        GridViewFocusRow(CurrentIndex);
                    }
                    else
                    {
                        GridViewFocusRow(0);
                    }
                }
                else
                {
                    Entity.InvalidateModuleObject(BusinessObjectFactory.GetBusinessObject(ItemTableName + "Info"));
                }
            }
        }
        /// <summary>
        /// Invalidate based on a list 
        /// </summary>
        /// <param name="lst">Object list</param>
        public virtual void InvalidateNoneBackUp(IList<T> lst)
        {
            this.Clear();
            BOSDisposeUtility.DisposeAll(this, 0, GCCollectionMode.Forced);
            foreach (T obj in lst)
            {
                T newT = (T)obj.Clone();
                if (newT != null)
                    this.Add(newT);
                else
                    break;
            }

            if (GridControl != null && GridControl.MainView != null)
            {
                GridControl.RefreshDataSource();
                if (this.Count > 0)
                {
                    if (CurrentIndex >= 0 && CurrentIndex < Count)
                    {
                        GridViewFocusRow(CurrentIndex);
                    }
                    else
                    {
                        GridViewFocusRow(0);
                    }
                }
                else
                {
                    Entity.InvalidateModuleObject(BusinessObjectFactory.GetBusinessObject(ItemTableName + "Info"));
                }
            }
        }

        /// <summary>
        /// Invalidate based on a list but don't invalidate the corresponding module object
        /// </summary>
        /// <param name="lst">Object list</param>
        public virtual void InvalidateAndNotUpdateModuleObject(IList<T> lst)
        {
            this.Clear();
            BOSDisposeUtility.DisposeAll(this, 0, GCCollectionMode.Forced);
            foreach (T obj in lst)
            {
                this.Add((T)obj.Clone());
            }

            //Invalidate original list same as itself
            OriginalList.Clear();
            BOSDisposeUtility.DisposeAll(OriginalList, 0, GCCollectionMode.Forced);
            foreach (T obj in this)
                OriginalList.Add((T)obj.Clone());

            //Invalidate backup list same as itself
            BackupList.Clear();
            BOSDisposeUtility.DisposeAll(BackupList, 0, GCCollectionMode.Forced);
            foreach (T obj in this)
            {
                BackupList.Add((T)obj.Clone());
            }
        }
        #endregion

        #region Save List
        public virtual T SaveObjectToList(bool isNew)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String strMainTableName = String.Empty;
            if (Entity.MainObject != null)
                strMainTableName = BOSUtil.GetTableNameFromBusinessObject(Entity.MainObject);

            T objT = new T();
            if (!String.IsNullOrEmpty(ParentTableName))
            {
                if (ItemTableName.Equals(strMainTableName))
                {
                    objT = (T)Entity.MainObject.Clone();
                }
                else
                {
                    objT = (T)Entity.ModuleObjects[ItemTableName].Clone();
                }
            }
            else
            {
                objT = (T)Entity.ModuleObjects[ItemTableName].Clone();
            }

            if (isNew)
            {
                String strPrimaryKey = ItemTableName.Substring(0, ItemTableName.Length - 1) + "ID";
                dbUtil.SetPropertyValue(objT, strPrimaryKey, 0);
                this.Add(objT);
            }
            else
            {
                if (CurrentIndex >= 0)
                    this[CurrentIndex] = objT;
            }
            return objT;
        }

        public virtual void AddObjectToList()
        {
            this.SaveObjectToList(true);
            if (GridControl != null)
            {
                GridControl.RefreshDataSource();
                GridViewFocusRow(this.Count - 1);
            }
        }

        public virtual void ChangeObjectFromList()
        {
            this.SaveObjectToList(false);
            if (GridControl != null)
            {
                if (GridView.FocusedRowHandle >= 0)
                {
                    GridControl.RefreshDataSource();
                    //GridViewFocusRow(GridView.FocusedRowHandle);
                }
            }
        }

        public virtual void RemoveObjectFromList(int iIndex)
        {
            if (this.Count > iIndex)
            {
                this.RemoveAt(iIndex);
            }
            if (GridControl != null)
            {
                GridControl.RefreshDataSource();
            }
            if (this.Count > 0)
            {
                if (this.Count > GridView.FocusedRowHandle)
                    GridViewFocusRow(GridView.FocusedRowHandle);
                else
                    GridViewFocusRow(this.Count - 1);
            }
            else
                Entity.InvalidateModuleObject(BusinessObjectFactory.GetBusinessObject(ItemTableName + "Info"));
        }

        public virtual void RemoveSelectedRowObjectFromList()
        {
            if (GridView != null && GridView.FocusedRowHandle >= 0)
            {
                int currentIndex = CurrentIndex;
                if (Entity.Module.IsEditable())
                {
                    Entity.Module.ActionEdit();
                }
                RemoveObjectFromList(currentIndex);
            }
        }

        public virtual bool Exists(String strPropertyName, object objPropertyValue)
        {
            if (this.PosOf(strPropertyName, objPropertyValue) >= 0)
                return true;
            return false;
        }

        public virtual void GridViewFocusRow(int iRowHandle)
        {
            if (GridView != null)
            {
                if (GridView.FocusedRowHandle == iRowHandle)
                {
                    if (CurrentIndex >= 0)
                    {
                        if (CurrentIndex < this.Count)
                        {
                            Entity.InvalidateModuleObject((T)this[CurrentIndex].Clone());
                        }
                    }
                }
                else
                {
                    GridView.FocusedRowHandle = iRowHandle;
                }
            }
        }

        #endregion

        #region Save List, Delete List to database
        public virtual void DeleteAllItemObjects()
        {
            try
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                IBusinessController objItemsController = BusinessControllerFactory.GetBusinessController(ItemTableName + "Controller");
                switch (Relation)
                {
                    case cstRelationSwitcher:
                        {
                            int iParentObjectID = GetParentObjectID();
                            if (iParentObjectID > 0)
                            {
                                String strSwitcherTableName = ParentTableName.Substring(0, ParentTableName.Length - 1) + ItemTableName.Substring(2);
                                objItemsController.DeleteFromOwner(ParentTableName, iParentObjectID, strSwitcherTableName);
                            }

                            break;
                        }
                    case cstRelationForeign:
                        {
                            int iParentObjectID = GetParentObjectID();
                            if (iParentObjectID > 0)
                            {
                                objItemsController.DeleteByForeignColumn(ItemTableForeignKey, iParentObjectID);
                            }
                            break;
                        }


                    case cstRelationParent:
                        {
                            break;
                        }

                    case cstRelationNone:
                        {
                            objItemsController.DeleteAllObjects();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public virtual void DeleteItemObjects()
        {
            if (typeof(IEntity).IsAssignableFrom(typeof(T)))
                DeleteItemWithDapper();
            else
                DeleteItemObsolete();
        }

        protected virtual void DeleteItemWithDapper()
        {
            this.Select(o => ((IEntity)o)).DeleteObject();
        }

        protected virtual void DeleteItemObsolete()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            IBusinessController objItemsController = BusinessControllerFactory.GetBusinessController(ItemTableName + "Controller");
            String strPrimaryColumn = BOSApp.GetTablePrimaryColumn(ItemTableName);
            foreach (T obj in this)
            {
                int iObjectID = Convert.ToInt32(dbUtil.GetPropertyValue(obj, strPrimaryColumn));
                objItemsController.DeleteObject(iObjectID);
            }
        }

        public virtual void SaveItemObjects(List<int> currentIds = null)
        {
            try
            {
                EndCurrentEdit();
                if (typeof(IEntity).IsAssignableFrom(typeof(T)))
                    SaveItemWithDapper(currentIds);
                else
                    SaveItemObsolete(currentIds);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void SaveItemObsolete(List<int> currentIds = null)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String strItemTablePrimaryKey = BOSApp.GetTablePrimaryColumn(ItemTableName);
            IBusinessController objItemsController = BusinessControllerFactory.GetBusinessController(ItemTableName + "Controller");
            string modulePrefix = ItemTableName.Substring(0, 2);
            int iParentObjectID = GetParentObjectID();

            AAColumnAliasController objColumnAliasController = new AAColumnAliasController();
            List<AAColumnAliasInfo> columnAliasList = BOSApp.LstColumnAlias.Where(a => a.AATableName == ItemTableName).ToList();

            DataTable dt = new DataTable();
            STToolbarsController rController = new STToolbarsController();
            string typeTable = GetTypeHistoryTable(modulePrefix);

            List<string> colList = rController.UserDefinedTableTypeColumnName(typeTable);
            foreach (T objT in this)
            {
                int iItemObjectID = (int)dbUtil.GetPropertyValue(objT, strItemTablePrimaryKey);

                if (iItemObjectID == 0 && Relation == cstRelationForeign)
                {
                    if (iParentObjectID > 0)
                    {
                        if (dbUtil.GetPropertyValue(objT, ItemTableForeignKey) != null)
                            dbUtil.SetPropertyValue(objT, ItemTableForeignKey, iParentObjectID);
                    }
                }

                bool isUpdate = iItemObjectID > 0;
                object oldObject = null;
                object newObject = null;
                if (isUpdate)
                {
                    dbUtil.SetPropertyValue(objT, ERPModuleEntities.AAUpdatedUser, BOSApp.CurrentUser);
                    dbUtil.SetPropertyValue(objT, ERPModuleEntities.AAUpdatedDate, BOSApp.GetCurrentServerDate());
                    oldObject = objItemsController.GetObjectByID(iItemObjectID);
                    objItemsController.UpdateObject(objT);
                    newObject = objT;
                }
                else
                {
                    dbUtil.SetPropertyValue(objT, ERPModuleEntities.AACreatedUser, BOSApp.CurrentUser);
                    dbUtil.SetPropertyValue(objT, ERPModuleEntities.AACreatedDate, BOSApp.GetCurrentServerDate());
                    iItemObjectID = objItemsController.CreateObject(objT);
                }
                if (colList.Count() > 0)
                    dt.Merge(SaveHistory(modulePrefix, columnAliasList, oldObject, newObject, iItemObjectID, isUpdate ? HistoryAction.Change : HistoryAction.Create, colList));
            }

            //Delete items
            foreach (T obj in OriginalList)
            {
                object oldObject = null;
                object newObject = null;
                int iItemObjectID = (int)dbUtil.GetPropertyValue(obj, strItemTablePrimaryKey);
                if (iItemObjectID > 0 && !this.Exists(strItemTablePrimaryKey, iItemObjectID) && !(currentIds?.Any(id => id > 0 && id == iItemObjectID) ?? false))
                {
                    objItemsController.DeleteObject(iItemObjectID);
                    Entity.DeleteObjectRelations(ItemTableName, iItemObjectID);
                    if (colList.Count() > 0)
                        dt.Merge(SaveHistory(modulePrefix, columnAliasList, oldObject, newObject, iItemObjectID, HistoryAction.Delete, colList));
                }
            }
            if (dt.Rows.Count > 0)
                SqlDatabaseHelper.SaveItemObject(dt, 0, modulePrefix + "Historys", "Create", string.Empty);

            //Invalidate original list
            OriginalList.Clear();
            BOSDisposeUtility.DisposeAll(OriginalList, 0, GCCollectionMode.Forced);

            foreach (T obj in this)
            {
                T newT = (T)obj.Clone();
                if (newT != null)
                    OriginalList.Add(newT);
                else
                    break;
            }
        }

        protected virtual void SaveItemWithDapper(List<int> currentIds = null)
        {
            //Get Old ObjectList
            string modulePrefix = ItemTableName.Substring(0, 2);
            var entityIds = this.Select(o => ((IEntity)o).Id).Where(o => o > 0).ToArray();
            string historyTableName = SqlDatabaseHelper.GetTableHistory(modulePrefix);
            List<T> oldObjects = new List<T>();
            if (!historyTableName.IsNullOrWhiteSpace())
            {
                string strPrimaryKey = SqlDatabaseHelper.GetPrimaryKeyColumn(ItemTableName);
                bool hasStatusColumn = SqlDatabaseHelper.ColumnIsExistInTable(ItemTableName, CommonColumn.AAStatus);
                string sqlwhereClause = string.Empty;
                if (hasStatusColumn)
                {
                    sqlwhereClause = string.Format("{0} = '{1}' ", CommonColumn.AAStatus, ObjectStatus.Alive);
                }
                if (sqlwhereClause.IsNullOrWhiteSpace())
                    sqlwhereClause += string.Format("{0} IN @Ids", strPrimaryKey);
                else
                    sqlwhereClause += string.Format("AND {0} IN @Ids", strPrimaryKey);

                string sqlQuery = string.Format("SELECT * FROM {0} WHERE {1}", ItemTableName, sqlwhereClause);
                var entityGetIds = entityIds.Take(entityIds.Length).ToArray();
                do
                {
                    var shortIds = new int[2000];
                    if (entityGetIds.Length > 2000)
                    {
                        shortIds = entityGetIds.Take(2000).ToArray();
                    }
                    else
                    {
                        shortIds = entityGetIds;
                    }    
                    var results = SqlDatabaseHelper.Connection.ExecuteReader(sqlQuery, new { Ids = shortIds });
                    oldObjects.AddRange(results.ConvertToList<T>().ToList());
                    entityGetIds = entityGetIds.Skip(shortIds.Length).ToArray();
                }
                while (entityGetIds.Length > 0);                
            }
            // End Get Old ObjectList
            int iParentObjectID = GetParentObjectID();
            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (IEntity item in this)
            {
                if (item.Id == 0 && Relation == cstRelationForeign)
                {
                    if (iParentObjectID > 0)
                    {
                        dbUtil.SetPropertyValue(item, ItemTableForeignKey, iParentObjectID);
                    }
                }
            }
            var delectedList = new List<T>();
            foreach (T obj in OriginalList)
            {
                if (!entityIds.Contains(((IEntity)obj).Id) && !(currentIds?.Any(id => id > 0 && id == ((IEntity)obj).Id) ?? false))
                {
                    delectedList.Add(obj);
                }
            }
            this.Select(o => ((IEntity)o)).InsertOrUpdateObject();
            delectedList.Select(o => ((IEntity)o)).DeleteObject();
            if (!historyTableName.IsNullOrWhiteSpace())
                SavaItemHistory(modulePrefix, historyTableName, oldObjects, delectedList, entityIds);
        }

        public void SavaItemHistory(string modulePrefix, string historyTableName, List<T> oldObjects, List<T> delectedList, int[] currentIds)
        {
            AAColumnAliasController objColumnAliasController = new AAColumnAliasController();
            List<AAColumnAliasInfo> columnHistories = BOSApp.LstColumnAlias.Where(o => o.AATableName == ItemTableName && o.AAColumnAliasIsSaveHistory).ToList();
            DataTable dt = SqlDatabaseHelper.CreateDataTabeHistory(historyTableName);
            if (dt?.Columns?.Count == 0)
                return;

            List<T> newItemList = this.Where(o => !currentIds.Contains(((IEntity)o).Id)).ToList();
            List<T> updateItemList = this.Where(o => currentIds.Contains(((IEntity)o).Id)).ToList();
            newItemList.ForEach(o =>
            {
                GenerateItemHistory(dt, modulePrefix, HistoryAction.Create, columnHistories, o);
            });
            delectedList.ForEach(o =>
            {
                GenerateItemHistory(dt, modulePrefix, HistoryAction.Delete, columnHistories, o);
            });
            updateItemList.ForEach(o =>
            {
                T oldObject = oldObjects.Where(old => ((IEntity)old).Id == ((IEntity)old).Id).FirstOrDefault();
                GenerateItemHistory(dt, modulePrefix, HistoryAction.Change, columnHistories, o, oldObject);
            });
            if (dt.Rows.Count > 0)
                SqlDatabaseHelper.SaveItemObject(dt, 0, modulePrefix + "Historys", "Create", string.Empty);
        }

        protected void GenerateItemHistory(DataTable dt, string modulePrefix, HistoryAction action, List<AAColumnAliasInfo> columnAliasList, T curentObject, T oldObject = null)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            DataRow dr;
            switch (action)
            {
                case HistoryAction.Change:
                    foreach (AAColumnAliasInfo alias in columnAliasList)
                    {
                        string oldValue = "";
                        string curentValue = "";
                        if (dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName) != null)
                        {
                            oldValue = dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName).ToString();
                        }

                        if (dbUtil.GetPropertyValue(curentObject, alias.AAColumnAliasName) != null)
                        {
                            curentValue = dbUtil.GetPropertyValue(curentObject, alias.AAColumnAliasName).ToString();
                        }
                        if (curentValue != oldValue)
                        {
                            dr = dt.NewRow();
                            SetValueDataHistory(dr, modulePrefix, action.ToString(), ((IEntity)curentObject).Id, alias.AAColumnAliasName, curentValue, oldValue);
                            dt.Rows.Add(dr);
                        }
                    }
                    break;
                case HistoryAction.Create:
                case HistoryAction.Delete:
                    dr = dt.NewRow();
                    SetValueDataHistory(dr, modulePrefix, action.ToString(), ((IEntity)curentObject).Id);
                    dt.Rows.Add(dr);
                    break;
            }
        }

        protected void SetValueDataHistory(DataRow dr, string modulePrefix, string action, int objectId, string columnName = "", object curentValue = null, object oldValue = null)
        {
            if (dr.Table.Columns.Contains(CommonColumn.AAStatus))
                dr[CommonColumn.AAStatus] = ObjectStatus.Alive;
            if (dr.Table.Columns.Contains("ADUserID"))
                dr["ADUserID"] = BOSApp.CurrentUsersInfo.ADUserID;
            if (dr.Table.Columns.Contains("ADUserName"))
                dr["ADUserName"] = BOSApp.CurrentUsersInfo.ADUserName;
            if (dr.Table.Columns.Contains(modulePrefix + "HistoryObjectName"))
                dr[modulePrefix + "HistoryObjectName"] = ItemTableName;
            if (dr.Table.Columns.Contains(modulePrefix + "HistoryObjectID"))
                dr[modulePrefix + "HistoryObjectID"] = objectId;
            if (dr.Table.Columns.Contains(modulePrefix + "HistoryObjectNo"))
                dr[modulePrefix + "HistoryObjectNo"] = string.Empty;
            if (dr.Table.Columns.Contains(modulePrefix + "HistoryAction"))
                dr[modulePrefix + "HistoryAction"] = action;
            if (dr.Table.Columns.Contains(modulePrefix + "HistoryDate"))
                dr[modulePrefix + "HistoryDate"] = BOSApp.GetCurrentServerDate();
            if (dr.Table.Columns.Contains(modulePrefix + "HistoryColumnName"))
                dr[modulePrefix + "HistoryColumnName"] = columnName;
            if (dr.Table.Columns.Contains(modulePrefix + "HistoryOldValue"))
                dr[modulePrefix + "HistoryOldValue"] = oldValue == null ? string.Empty : oldValue.ToString();
            if (dr.Table.Columns.Contains(modulePrefix + "HistoryNewValue"))
                dr[modulePrefix + "HistoryNewValue"] = curentValue == null ? string.Empty : curentValue.ToString();
        }

        protected DataTable SaveHistory(string modulePrefix, List<AAColumnAliasInfo> columnAliasList, object oldObject, object newObject, int iItemObjectID, HistoryAction action, List<string> colList)
        {
            DataTable dt = new DataTable();
            switch ((ModulePrefix)Enum.Parse(typeof(ModulePrefix), modulePrefix))
            {
                case ModulePrefix.AR:
                    //SaveARHistory(columnAliasList, oldObject, newObject, iItemObjectID, action);
                    dt = GenerateARHistory(columnAliasList, oldObject, newObject, iItemObjectID, action, colList);
                    break;

                case ModulePrefix.AP:
                    //SaveAPHistory(columnAliasList, oldObject, newObject, iItemObjectID, action);
                    dt = GenerateAPHistory(columnAliasList, oldObject, newObject, iItemObjectID, action, colList);
                    break;

                case ModulePrefix.IC:
                    //SaveICHistory(columnAliasList, oldObject, newObject, iItemObjectID, action);
                    dt = GenerateICHistory(columnAliasList, oldObject, newObject, iItemObjectID, action, colList);
                    break;

                case ModulePrefix.MM:
                    //SaveMMHistory(columnAliasList, oldObject, newObject, iItemObjectID, action);
                    dt = GenerateMMHistory(columnAliasList, oldObject, newObject, iItemObjectID, action, colList);
                    break;

                case ModulePrefix.AC:
                    //SaveACHistory(columnAliasList, oldObject, newObject, iItemObjectID, action);
                    dt = GenerateACHistory(columnAliasList, oldObject, newObject, iItemObjectID, action, colList);
                    break;

                case ModulePrefix.BR:
                    //SaveBRHistory(columnAliasList, oldObject, newObject, iItemObjectID, action);
                    dt = GenerateBRHistory(columnAliasList, oldObject, newObject, iItemObjectID, action, colList);
                    break;

                case ModulePrefix.AD:
                    //SaveADHistory(columnAliasList, oldObject, newObject, iItemObjectID, action);
                    dt = GenerateADHistory(columnAliasList, oldObject, newObject, iItemObjectID, action, colList);
                    break;

                case ModulePrefix.VM:
                    //SaveVMHistory(columnAliasList, oldObject, newObject, iItemObjectID, action);
                    dt = GenerateVMHistory(columnAliasList, oldObject, newObject, iItemObjectID, action, colList);
                    break;

                case ModulePrefix.PM:
                    //SavePMHistory(columnAliasList, oldObject, newObject, iItemObjectID, action);
                    dt = GeneratePMHistory(columnAliasList, oldObject, newObject, iItemObjectID, action, colList);
                    break;
                default:
                    break;
            }
            return dt;
        }
        public string GetTypeHistoryTable(string modulePrefix)
        {
            string table = string.Empty;
            switch ((ModulePrefix)Enum.Parse(typeof(ModulePrefix), modulePrefix))
            {
                case ModulePrefix.AR:
                    table = "Type_ARHistorys";
                    break;

                case ModulePrefix.AP:
                    table = "Type_APHistorys";
                    break;

                case ModulePrefix.IC:
                    table = "Type_ICHistorys";
                    break;

                case ModulePrefix.MM:
                    table = "Type_MMHistorys";
                    break;

                case ModulePrefix.AC:
                    table = "Type_ACHistorys";
                    break;

                case ModulePrefix.BR:
                    table = "Type_BRHistorys";
                    break;

                case ModulePrefix.AD:
                    table = "Type_ADHistorys";
                    break;

                case ModulePrefix.VM:
                    table = "Type_VMHistorys";
                    break;

                case ModulePrefix.PM:
                    table = "Type_PMHistorys";
                    break;
                default:
                    table = "Type_ICHistorys";
                    break;
            }
            return table;
        }

        public virtual void SaveItemCDObjects()
        {
            try
            {
                EndCurrentEdit();

                BOSDbUtil dbUtil = new BOSDbUtil();
                String strItemTablePrimaryKey = BOSApp.GetTablePrimaryColumn(ItemTableName);
                IBusinessController objItemsController = BusinessControllerFactory.GetBusinessController(ItemTableName + "Controller");

                foreach (T objT in this)
                {
                    int iItemObjectID = (int)dbUtil.GetPropertyValue(objT, strItemTablePrimaryKey);
                    switch (Relation)
                    {
                        case cstRelationSwitcher:
                            {
                                break;
                            }
                        case cstRelationForeign:
                            {
                                int iParentObjectID = GetParentObjectID();
                                if (iParentObjectID > 0)
                                {
                                    if (dbUtil.GetPropertyValue(objT, ItemTableForeignKey) != null)
                                        dbUtil.SetPropertyValue(objT, ItemTableForeignKey, iParentObjectID);
                                }
                                break;
                            }
                        case cstRelationParent:
                            {
                                break;
                            }
                        case cstRelationNone:
                            {
                                break;
                            }
                    }

                    //Create or update items
                    if (iItemObjectID > 0)
                    {
                        dbUtil.SetPropertyValue(objT, ERPModuleEntities.AAUpdatedUser, BOSApp.CurrentUser);
                        dbUtil.SetPropertyValue(objT, ERPModuleEntities.AAUpdatedDate, BOSApp.GetCurrentServerDate());
                        objItemsController.UpdateObject(objT);
                    }
                    else
                    {
                        dbUtil.SetPropertyValue(objT, ERPModuleEntities.AACreatedUser, BOSApp.CurrentUser);
                        dbUtil.SetPropertyValue(objT, ERPModuleEntities.AACreatedDate, BOSApp.GetCurrentServerDate());
                        objItemsController.CreateObject(objT);
                    }
                }

                //Delete items
                foreach (T obj in OriginalList)
                {
                    int iItemObjectID = (int)dbUtil.GetPropertyValue(obj, strItemTablePrimaryKey);
                    if (iItemObjectID > 0 && !this.Exists(strItemTablePrimaryKey, iItemObjectID))
                    {
                        objItemsController.DeleteObject(iItemObjectID);
                        Entity.DeleteObjectRelations(ItemTableName, iItemObjectID);
                        objItemsController.DeleteAllObjectsByObjectParentID(iItemObjectID);
                    }
                }
                //Invalidate original list
                OriginalList.Clear();
                BOSDisposeUtility.DisposeAll(OriginalList, 0, GCCollectionMode.Forced);
                foreach (T obj in this)
                {
                    T newT = (T)obj.Clone();
                    if (newT != null)
                        OriginalList.Add(newT);
                    else
                        break;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public virtual void SaveItemObjects(bool bDeleteFirst)
        {
            if (bDeleteFirst)
            {
                DeleteAllItemObjects();
            }

            SaveItemObjects();
        }
        #endregion

        #region GridControl,GridView event handlers
        protected virtual void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!IsEndCurrentEdit)
            {
                if (this.Count > 0)
                {
                    if (CurrentIndex >= 0 && CurrentIndex < this.Count)
                    {
                        Entity.InvalidateModuleObject((T)this[CurrentIndex].Clone());
                    }
                }
            }
            IsEndCurrentEdit = false;

            if (CurrentIndex < 0)
            {
                IsInputingNewRow = true;
            }
            else
            {
                IsInputingNewRow = false;
            }
        }

        public List<string> FieldNameNotInChanged { get; set; }

        protected virtual void GridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!IsInputingNewRow && !FieldNameNotInChanged.Exists(p => p == e.Column.FieldName))
            {
                if (Entity.ModuleObjects[ItemTableName] != null)
                {
                    Entity.Module.SwitchToEditMode(Entity.ModuleObjects[ItemTableName], String.Empty);
                }
            }
        }
        #endregion

        /// <summary>
        /// Get position of object in list
        /// </summary>
        /// <param name="strPropertyName"></param>
        /// <param name="objPropertyValue"></param>
        /// <returns></returns>
        public virtual int PosOf(String strPropertyName, object objPropertyValue)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            for (int i = 0; i < this.Count; i++)
            {
                object objValue = dbUtil.GetPropertyValue((T)this[i], strPropertyName);
                if (objPropertyValue.Equals(objValue))
                    return i;
            }
            return -1;
        }

        public int GetParentObjectID()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            int iParentObjectID = 0;
            if (!String.IsNullOrEmpty(ParentTableName))
            {
                String strMainTableName = String.Empty;
                if (Entity.MainObject != null)
                {
                    strMainTableName = BOSUtil.GetTableNameFromBusinessObject(Entity.MainObject);
                }
                string strParentTablePrimaryKey = BOSApp.GetTablePrimaryColumn(ParentTableName);
                if (ParentTableName == strMainTableName)
                {
                    iParentObjectID = dbUtil.GetPropertyIntValue(Entity.MainObject, strParentTablePrimaryKey);
                }
            }
            return iParentObjectID;
        }

        /// <summary>
        /// Duplicate list by setting all item primary key to zero
        /// </summary>
        public virtual void Duplicate()
        {
            OriginalList.Clear();
            BOSDisposeUtility.DisposeAll(OriginalList, 0, GCCollectionMode.Forced);

            BOSDbUtil dbUtil = new BOSDbUtil();
            String itemTablePrimaryColumn = BOSApp.GetTablePrimaryColumn(ItemTableName);
            foreach (T obj in this)
                dbUtil.SetPropertyValue(obj, itemTablePrimaryColumn, 0);
        }

        /// <summary>
        /// End current edit to update binding list
        /// </summary>
        public virtual void EndCurrentEdit()
        {
            if (GridView != null)
            {
                IsEndCurrentEdit = true;
                GridView.FocusedRowHandle = -1;
            }
        }
        public virtual void SetEndCurrentEdit()
        {
            if (GridView != null)
            {
                IsEndCurrentEdit = true;
            }
        }

        /// <summary>
        /// Count the number of appearance of object by property name and value
        /// </summary>
        public virtual int GetFrequence(String strPropertyName, object objPropertyValue)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            int count = 0;
            for (int i = 0; i < this.Count; i++)
            {
                object objValue = dbUtil.GetPropertyValue((T)this[i], strPropertyName);
                if (objPropertyValue.Equals(objValue))
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Clone a list
        /// </summary>
        /// <returns>Copied list from the current one</returns>
        public object Clone()
        {
            BOSList<T> result = new BOSList<T>();
            result.InitBOSList(Entity, ParentTableName, ItemTableName, Relation);
            result.ItemTableForeignKey = ItemTableForeignKey;
            foreach (T obj in this)
            {
                T newT = (T)obj.Clone();
                if (newT != null)
                    result.Add(newT);
                else
                    break;

            }
            foreach (T obj in OriginalList)
            {
                T newT = (T)obj.Clone();
                if (newT != null)
                    result.OriginalList.Add(newT);
                else
                    break;
            }
            foreach (T obj in BackupList)
            {
                T newT = (T)obj.Clone();
                if (newT != null)
                    result.BackupList.Add(newT);
                else
                    break;
            }
            return result;
        }

        public virtual void SaveItemTypeObjects()
        {
            try
            {
                EndCurrentEdit();
                BOSDbUtil dbUtil = new BOSDbUtil();
                String strItemTablePrimaryKey = BOSApp.GetTablePrimaryColumn(ItemTableName);
                String strMainTableName = string.Empty;
                string modulePrefix = ItemTableName.Substring(0, 2);
                int mainobjectID = 0;
                if (!String.IsNullOrEmpty(ParentTableName))
                {
                    if (Entity.MainObject != null)
                    {
                        strMainTableName = BOSUtil.GetTableNameFromBusinessObject(Entity.MainObject);
                    }
                    string strParentTablePrimaryKey = BOSApp.GetTablePrimaryColumn(ParentTableName);
                    if (ParentTableName == strMainTableName)
                    {
                        mainobjectID = dbUtil.GetPropertyIntValue(Entity.MainObject, strParentTablePrimaryKey);
                    }
                }
                List<T> deleteitem = new List<T>();
                if (this.OriginalList.Count > 0)
                {
                    List<int> currentIDs = this.Select(o => (int)dbUtil.GetPropertyValue(o, strItemTablePrimaryKey)).Distinct().ToList();
                    List<int> deleteIDs = this.OriginalList.Select(o => (int)dbUtil.GetPropertyValue(o, strItemTablePrimaryKey)).Where(s => s > 0).ToList();

                    deleteIDs = deleteIDs.Where(o => !currentIDs.Contains(o)).ToList();
                    deleteitem = this.OriginalList.Where(o => deleteIDs.Contains((int)dbUtil.GetPropertyValue(o, strItemTablePrimaryKey))).ToList();
                }
                //Delete items
                //for (int i = 0; i < this.OriginalList.Count; i++)
                //{
                //    T obj = this.OriginalList[i];
                //    int iItemObjectID = (int)dbUtil.GetPropertyValue(obj, strItemTablePrimaryKey);
                //    if (iItemObjectID > 0 && !this.Exists(strItemTablePrimaryKey, iItemObjectID))
                //    {
                //        deleteitem.Add(obj);
                //    }
                //}
                SaveItemWithDataTableType.SaveItemWithoutDelete<T>(this, strItemTablePrimaryKey, ItemTableName, mainobjectID, BOSApp.CurrentUsersInfo.ADUserName);
                if (deleteitem != null && deleteitem.Count > 0)
                    SaveItemWithDataTableType.DeleteItem<T>(deleteitem, ItemTableName, BOSApp.CurrentUsersInfo.ADUserName);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GenerateARHistory(List<AAColumnAliasInfo> columnAliasList, object oldObject, object newObject, int iItemObjectID, HistoryAction action, List<string> colList)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();

            ARHistorysInfo objHistorysInfo;
            List<ARHistorysInfo> historysList = new List<ARHistorysInfo>();

            //STToolbarsController rController = new STToolbarsController();
            //List<string> colList = rController.UserDefinedTableTypeColumnName("Type_ARHistorys");

            switch (action)
            {
                case HistoryAction.Change:
                    foreach (AAColumnAliasInfo alias in columnAliasList)
                    {
                        string oldValue = "";
                        string newValue = "";
                        if (dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName) != null)
                        {
                            oldValue = dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName).ToString();
                        }

                        if (dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName) != null)
                        {
                            newValue = dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName).ToString();
                        }
                        if (oldValue != newValue)
                        {
                            objHistorysInfo = new ARHistorysInfo();
                            objHistorysInfo.ARHistoryColumnName = alias.AAColumnAliasName;
                            objHistorysInfo.ARHistoryOldValue = oldValue;
                            objHistorysInfo.ARHistoryNewValue = newValue;
                            historysList.Add(objHistorysInfo);
                        }
                    }

                    if (historysList.Count > 0)
                    {
                        historysList.ForEach(o1 =>
                        {
                            o1.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                            o1.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                            o1.ARHistoryObjectName = ItemTableName;
                            string no = "";
                            if (dbUtil.GetPropertyValue(newObject, ItemTableName.Substring(0, ItemTableName.Length - 1) + "No") != null)
                            {
                                no = dbUtil.GetPropertyValue(newObject, ItemTableName.Substring(0, ItemTableName.Length - 1) + "No").ToString();
                            }
                            o1.ARHistoryObjectNo = no;
                            o1.ARHistoryAction = action.ToString();
                            o1.ARHistoryDate = BOSApp.GetCurrentServerDate();
                            o1.ARHistoryObjectID = iItemObjectID;
                        });
                    }
                    break;

                case HistoryAction.Create:
                case HistoryAction.Delete:
                    objHistorysInfo = new ARHistorysInfo();
                    objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                    objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                    objHistorysInfo.ARHistoryObjectName = ItemTableName;
                    objHistorysInfo.ARHistoryAction = action == HistoryAction.Create ? HistoryAction.Create.ToString() : HistoryAction.Delete.ToString();
                    objHistorysInfo.ARHistoryDate = BOSApp.GetCurrentServerDate();
                    objHistorysInfo.ARHistoryObjectID = iItemObjectID;
                    historysList.Add(objHistorysInfo);
                    break;
            }

            DataTable newTable = CollectionExtensions.AsDataTable<ARHistorysInfo>(historysList, colList);

            return newTable;
        }

        private DataTable GenerateAPHistory(List<AAColumnAliasInfo> columnAliasList, object oldObject, object newObject, int iItemObjectID, HistoryAction action, List<string> colList)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();

            APHistorysInfo objHistorysInfo;
            List<APHistorysInfo> historysList = new List<APHistorysInfo>();

            //STToolbarsController rController = new STToolbarsController();
            //List<string> colList = rController.UserDefinedTableTypeColumnName("Type_APHistorys");

            switch (action)
            {
                case HistoryAction.Change:
                    foreach (AAColumnAliasInfo alias in columnAliasList)
                    {
                        string oldValue = "";
                        string newValue = "";
                        if (dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName) != null)
                        {
                            oldValue = dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName).ToString();
                        }

                        if (dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName) != null)
                        {
                            newValue = dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName).ToString();
                        }
                        if (oldValue != newValue)
                        {
                            objHistorysInfo = new APHistorysInfo();
                            objHistorysInfo.APHistoryColumnName = alias.AAColumnAliasName;
                            objHistorysInfo.APHistoryOldValue = oldValue;
                            objHistorysInfo.APHistoryNewValue = newValue;
                            historysList.Add(objHistorysInfo);
                        }
                    }

                    if (historysList.Count > 0)
                    {
                        historysList.ForEach(o1 =>
                        {
                            o1.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                            o1.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                            o1.APHistoryObjectName = ItemTableName;
                            string no = "";
                            if (dbUtil.GetPropertyValue(newObject, ItemTableName.Substring(0, ItemTableName.Length - 1) + "No") != null)
                            {
                                no = dbUtil.GetPropertyValue(newObject, ItemTableName.Substring(0, ItemTableName.Length - 1) + "No").ToString();
                            }
                            o1.APHistoryObjectNo = no;
                            o1.APHistoryAction = action.ToString();
                            o1.APHistoryDate = BOSApp.GetCurrentServerDate();
                            o1.APHistoryObjectID = iItemObjectID;
                        });
                    }
                    break;

                case HistoryAction.Create:
                case HistoryAction.Delete:
                    objHistorysInfo = new APHistorysInfo();
                    objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                    objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                    objHistorysInfo.APHistoryObjectName = ItemTableName;
                    objHistorysInfo.APHistoryAction = action == HistoryAction.Create ? HistoryAction.Create.ToString() : HistoryAction.Delete.ToString();
                    objHistorysInfo.APHistoryDate = BOSApp.GetCurrentServerDate();
                    objHistorysInfo.APHistoryObjectID = iItemObjectID;
                    historysList.Add(objHistorysInfo);
                    break;
            }

            DataTable newTable = CollectionExtensions.AsDataTable<APHistorysInfo>(historysList, colList);

            return newTable;
        }

        private DataTable GenerateICHistory(List<AAColumnAliasInfo> columnAliasList, object oldObject, object newObject, int iItemObjectID, HistoryAction action, List<string> colList)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();

            ICHistorysInfo objHistorysInfo;
            List<ICHistorysInfo> historysList = new List<ICHistorysInfo>();

            //STToolbarsController rController = new STToolbarsController();
            //List<string> colList = rController.UserDefinedTableTypeColumnName("Type_ICHistorys");

            switch (action)
            {
                case HistoryAction.Change:
                    foreach (AAColumnAliasInfo alias in columnAliasList)
                    {
                        string oldValue = "";
                        string newValue = "";
                        if (dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName) != null)
                        {
                            oldValue = dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName).ToString();
                        }

                        if (dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName) != null)
                        {
                            newValue = dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName).ToString();
                        }
                        if (oldValue != newValue)
                        {
                            objHistorysInfo = new ICHistorysInfo();
                            objHistorysInfo.ICHistoryColumnName = alias.AAColumnAliasName;
                            objHistorysInfo.ICHistoryOldValue = oldValue;
                            objHistorysInfo.ICHistoryNewValue = newValue;
                            historysList.Add(objHistorysInfo);
                        }
                    }

                    if (historysList.Count > 0)
                    {
                        historysList.ForEach(o1 =>
                        {
                            o1.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                            o1.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                            o1.ICHistoryObjectName = ItemTableName;
                            string no = "";
                            if (dbUtil.GetPropertyValue(newObject, ItemTableName.Substring(0, ItemTableName.Length - 1) + "No") != null)
                            {
                                no = dbUtil.GetPropertyValue(newObject, ItemTableName.Substring(0, ItemTableName.Length - 1) + "No").ToString();
                            }
                            o1.ICHistoryObjectNo = no;
                            o1.ICHistoryAction = action.ToString();
                            o1.ICHistoryDate = BOSApp.GetCurrentServerDate();
                            o1.ICHistoryObjectID = iItemObjectID;
                        });
                    }
                    break;

                case HistoryAction.Create:
                case HistoryAction.Delete:
                    objHistorysInfo = new ICHistorysInfo();
                    objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                    objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                    objHistorysInfo.ICHistoryObjectName = ItemTableName;
                    objHistorysInfo.ICHistoryAction = action == HistoryAction.Create ? HistoryAction.Create.ToString() : HistoryAction.Delete.ToString();
                    objHistorysInfo.ICHistoryDate = BOSApp.GetCurrentServerDate();
                    objHistorysInfo.ICHistoryObjectID = iItemObjectID;
                    historysList.Add(objHistorysInfo);
                    break;
            }

            DataTable newTable = CollectionExtensions.AsDataTable<ICHistorysInfo>(historysList, colList);

            return newTable;
        }

        private DataTable GenerateMMHistory(List<AAColumnAliasInfo> columnAliasList, object oldObject, object newObject, int iItemObjectID, HistoryAction action, List<string> colList)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();

            MMHistorysInfo objHistorysInfo;
            List<MMHistorysInfo> historysList = new List<MMHistorysInfo>();

            //STToolbarsController rController = new STToolbarsController();
            //List<string> colList = rController.UserDefinedTableTypeColumnName("Type_MMHistorys");

            switch (action)
            {
                case HistoryAction.Change:
                    foreach (AAColumnAliasInfo alias in columnAliasList)
                    {
                        string oldValue = "";
                        string newValue = "";
                        if (dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName) != null)
                        {
                            oldValue = dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName).ToString();
                        }

                        if (dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName) != null)
                        {
                            newValue = dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName).ToString();
                        }
                        if (oldValue != newValue)
                        {
                            objHistorysInfo = new MMHistorysInfo();
                            objHistorysInfo.MMHistoryColumnName = alias.AAColumnAliasName;
                            objHistorysInfo.MMHistoryOldValue = oldValue;
                            objHistorysInfo.MMHistoryNewValue = newValue;
                            historysList.Add(objHistorysInfo);
                        }
                    }

                    if (historysList.Count > 0)
                    {
                        historysList.ForEach(o1 =>
                        {
                            o1.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                            o1.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                            o1.MMHistoryObjectName = ItemTableName;
                            string no = "";
                            if (dbUtil.GetPropertyValue(newObject, ItemTableName.Substring(0, ItemTableName.Length - 1) + "No") != null)
                            {
                                no = dbUtil.GetPropertyValue(newObject, ItemTableName.Substring(0, ItemTableName.Length - 1) + "No").ToString();
                            }
                            o1.MMHistoryObjectNo = no;
                            o1.MMHistoryAction = action.ToString();
                            o1.MMHistoryDate = BOSApp.GetCurrentServerDate();
                            o1.MMHistoryObjectID = iItemObjectID;
                        });
                    }
                    break;

                case HistoryAction.Create:
                case HistoryAction.Delete:
                    objHistorysInfo = new MMHistorysInfo();
                    objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                    objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                    objHistorysInfo.MMHistoryObjectName = ItemTableName;
                    objHistorysInfo.MMHistoryAction = action == HistoryAction.Create ? HistoryAction.Create.ToString() : HistoryAction.Delete.ToString();
                    objHistorysInfo.MMHistoryDate = BOSApp.GetCurrentServerDate();
                    objHistorysInfo.MMHistoryObjectID = iItemObjectID;
                    historysList.Add(objHistorysInfo);
                    break;
            }

            DataTable newTable = CollectionExtensions.AsDataTable<MMHistorysInfo>(historysList, colList);

            return newTable;
        }

        private DataTable GenerateACHistory(List<AAColumnAliasInfo> columnAliasList, object oldObject, object newObject, int iItemObjectID, HistoryAction action, List<string> colList)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();

            ACHistorysInfo objHistorysInfo;
            List<ACHistorysInfo> historysList = new List<ACHistorysInfo>();

            //STToolbarsController rController = new STToolbarsController();
            //List<string> colList = rController.UserDefinedTableTypeColumnName("Type_ACHistorys");

            switch (action)
            {
                case HistoryAction.Change:
                    foreach (AAColumnAliasInfo alias in columnAliasList)
                    {
                        string oldValue = "";
                        string newValue = "";
                        if (dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName) != null)
                        {
                            oldValue = dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName).ToString();
                        }

                        if (dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName) != null)
                        {
                            newValue = dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName).ToString();
                        }
                        if (oldValue != newValue)
                        {
                            objHistorysInfo = new ACHistorysInfo();
                            objHistorysInfo.ACHistoryColumnName = alias.AAColumnAliasName;
                            objHistorysInfo.ACHistoryOldValue = oldValue;
                            objHistorysInfo.ACHistoryNewValue = newValue;
                            historysList.Add(objHistorysInfo);
                        }
                    }

                    if (historysList.Count > 0)
                    {
                        historysList.ForEach(o1 =>
                        {
                            o1.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                            o1.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                            o1.ACHistoryObjectName = ItemTableName;
                            string no = "";
                            if (dbUtil.GetPropertyValue(newObject, ItemTableName.Substring(0, ItemTableName.Length - 1) + "No") != null)
                            {
                                no = dbUtil.GetPropertyValue(newObject, ItemTableName.Substring(0, ItemTableName.Length - 1) + "No").ToString();
                            }
                            o1.ACHistoryObjectNo = no;
                            o1.ACHistoryAction = action.ToString();
                            o1.ACHistoryDate = BOSApp.GetCurrentServerDate();
                            o1.ACHistoryObjectID = iItemObjectID;
                        });
                    }
                    break;

                case HistoryAction.Create:
                case HistoryAction.Delete:
                    objHistorysInfo = new ACHistorysInfo();
                    objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                    objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                    objHistorysInfo.ACHistoryObjectName = ItemTableName;
                    objHistorysInfo.ACHistoryAction = action == HistoryAction.Create ? HistoryAction.Create.ToString() : HistoryAction.Delete.ToString();
                    objHistorysInfo.ACHistoryDate = BOSApp.GetCurrentServerDate();
                    objHistorysInfo.ACHistoryObjectID = iItemObjectID;
                    historysList.Add(objHistorysInfo);
                    break;
            }

            DataTable newTable = CollectionExtensions.AsDataTable<ACHistorysInfo>(historysList, colList);

            return newTable;
        }

        private DataTable GenerateBRHistory(List<AAColumnAliasInfo> columnAliasList, object oldObject, object newObject, int iItemObjectID, HistoryAction action, List<string> colList)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();

            BRHistorysInfo objHistorysInfo;
            List<BRHistorysInfo> historysList = new List<BRHistorysInfo>();

            //STToolbarsController rController = new STToolbarsController();
            //List<string> colList = rController.UserDefinedTableTypeColumnName("Type_BRHistorys");

            switch (action)
            {
                case HistoryAction.Change:
                    foreach (AAColumnAliasInfo alias in columnAliasList)
                    {
                        string oldValue = "";
                        string newValue = "";
                        if (dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName) != null)
                        {
                            oldValue = dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName).ToString();
                        }

                        if (dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName) != null)
                        {
                            newValue = dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName).ToString();
                        }
                        if (oldValue != newValue)
                        {
                            objHistorysInfo = new BRHistorysInfo();
                            objHistorysInfo.BRHistoryColumnName = alias.AAColumnAliasName;
                            objHistorysInfo.BRHistoryOldValue = oldValue;
                            objHistorysInfo.BRHistoryNewValue = newValue;
                            historysList.Add(objHistorysInfo);
                        }
                    }

                    if (historysList.Count > 0)
                    {
                        historysList.ForEach(o1 =>
                        {
                            o1.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                            o1.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                            o1.BRHistoryObjectName = ItemTableName;
                            string no = "";
                            if (dbUtil.GetPropertyValue(newObject, ItemTableName.Substring(0, ItemTableName.Length - 1) + "No") != null)
                            {
                                no = dbUtil.GetPropertyValue(newObject, ItemTableName.Substring(0, ItemTableName.Length - 1) + "No").ToString();
                            }
                            o1.BRHistoryObjectNo = no;
                            o1.BRHistoryAction = action.ToString();
                            o1.BRHistoryDate = BOSApp.GetCurrentServerDate();
                            o1.BRHistoryObjectID = iItemObjectID;
                        });
                    }
                    break;

                case HistoryAction.Create:
                case HistoryAction.Delete:
                    objHistorysInfo = new BRHistorysInfo();
                    objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                    objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                    objHistorysInfo.BRHistoryObjectName = ItemTableName;
                    objHistorysInfo.BRHistoryAction = action == HistoryAction.Create ? HistoryAction.Create.ToString() : HistoryAction.Delete.ToString();
                    objHistorysInfo.BRHistoryDate = BOSApp.GetCurrentServerDate();
                    objHistorysInfo.BRHistoryObjectID = iItemObjectID;
                    historysList.Add(objHistorysInfo);
                    break;
            }

            DataTable newTable = CollectionExtensions.AsDataTable<BRHistorysInfo>(historysList, colList);

            return newTable;
        }

        private DataTable GenerateADHistory(List<AAColumnAliasInfo> columnAliasList, object oldObject, object newObject, int iItemObjectID, HistoryAction action, List<string> colList)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();

            ADHistorysInfo objHistorysInfo;
            List<ADHistorysInfo> historysList = new List<ADHistorysInfo>();

            //STToolbarsController rController = new STToolbarsController();
            //List<string> colList = rController.UserDefinedTableTypeColumnName("Type_ADHistorys");

            switch (action)
            {
                case HistoryAction.Change:
                    foreach (AAColumnAliasInfo alias in columnAliasList)
                    {
                        string oldValue = "";
                        string newValue = "";
                        if (dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName) != null)
                        {
                            oldValue = dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName).ToString();
                        }

                        if (dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName) != null)
                        {
                            newValue = dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName).ToString();
                        }
                        if (oldValue != newValue)
                        {
                            objHistorysInfo = new ADHistorysInfo();
                            objHistorysInfo.ADHistoryColumnName = alias.AAColumnAliasName;
                            objHistorysInfo.ADHistoryOldValue = oldValue;
                            objHistorysInfo.ADHistoryNewValue = newValue;
                            historysList.Add(objHistorysInfo);
                        }
                    }

                    if (historysList.Count > 0)
                    {
                        historysList.ForEach(o1 =>
                        {
                            o1.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                            o1.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                            o1.ADHistoryObjectName = ItemTableName;
                            string no = "";
                            if (dbUtil.GetPropertyValue(newObject, ItemTableName.Substring(0, ItemTableName.Length - 1) + "No") != null)
                            {
                                no = dbUtil.GetPropertyValue(newObject, ItemTableName.Substring(0, ItemTableName.Length - 1) + "No").ToString();
                            }
                            o1.ADHistoryObjectNo = no;
                            o1.ADHistoryAction = action.ToString();
                            o1.ADHistoryDate = BOSApp.GetCurrentServerDate();
                            o1.ADHistoryObjectID = iItemObjectID;
                        });
                    }
                    break;

                case HistoryAction.Create:
                case HistoryAction.Delete:
                    objHistorysInfo = new ADHistorysInfo();
                    objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                    objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                    objHistorysInfo.ADHistoryObjectName = ItemTableName;
                    objHistorysInfo.ADHistoryAction = action == HistoryAction.Create ? HistoryAction.Create.ToString() : HistoryAction.Delete.ToString();
                    objHistorysInfo.ADHistoryDate = BOSApp.GetCurrentServerDate();
                    objHistorysInfo.ADHistoryObjectID = iItemObjectID;
                    historysList.Add(objHistorysInfo);
                    break;
            }

            DataTable newTable = CollectionExtensions.AsDataTable<ADHistorysInfo>(historysList, colList);

            return newTable;
        }

        private DataTable GenerateVMHistory(List<AAColumnAliasInfo> columnAliasList, object oldObject, object newObject, int iItemObjectID, HistoryAction action, List<string> colList)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();

            VMHistorysInfo objHistorysInfo;
            List<VMHistorysInfo> historysList = new List<VMHistorysInfo>();

            //STToolbarsController rController = new STToolbarsController();
            //List<string> colList = rController.UserDefinedTableTypeColumnName("Type_VMHistorys");

            switch (action)
            {
                case HistoryAction.Change:
                    foreach (AAColumnAliasInfo alias in columnAliasList)
                    {
                        string oldValue = "";
                        string newValue = "";
                        if (dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName) != null)
                        {
                            oldValue = dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName).ToString();
                        }

                        if (dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName) != null)
                        {
                            newValue = dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName).ToString();
                        }
                        if (oldValue != newValue)
                        {
                            objHistorysInfo = new VMHistorysInfo();
                            objHistorysInfo.VMHistoryColumnName = alias.AAColumnAliasName;
                            objHistorysInfo.VMHistoryOldValue = oldValue;
                            objHistorysInfo.VMHistoryNewValue = newValue;
                            historysList.Add(objHistorysInfo);
                        }
                    }

                    if (historysList.Count > 0)
                    {
                        historysList.ForEach(o1 =>
                        {
                            o1.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                            o1.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                            o1.VMHistoryObjectName = ItemTableName;
                            string no = "";
                            if (dbUtil.GetPropertyValue(newObject, ItemTableName.Substring(0, ItemTableName.Length - 1) + "No") != null)
                            {
                                no = dbUtil.GetPropertyValue(newObject, ItemTableName.Substring(0, ItemTableName.Length - 1) + "No").ToString();
                            }
                            o1.VMHistoryObjectNo = no;
                            o1.VMHistoryAction = action.ToString();
                            o1.VMHistoryDate = BOSApp.GetCurrentServerDate();
                            o1.VMHistoryObjectID = iItemObjectID;
                        });
                    }
                    break;

                case HistoryAction.Create:
                case HistoryAction.Delete:
                    objHistorysInfo = new VMHistorysInfo();
                    objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                    objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                    objHistorysInfo.VMHistoryObjectName = ItemTableName;
                    objHistorysInfo.VMHistoryAction = action == HistoryAction.Create ? HistoryAction.Create.ToString() : HistoryAction.Delete.ToString();
                    objHistorysInfo.VMHistoryDate = BOSApp.GetCurrentServerDate();
                    objHistorysInfo.VMHistoryObjectID = iItemObjectID;
                    historysList.Add(objHistorysInfo);
                    break;
            }

            DataTable newTable = CollectionExtensions.AsDataTable<VMHistorysInfo>(historysList, colList);

            return newTable;
        }

        private DataTable GeneratePMHistory(List<AAColumnAliasInfo> columnAliasList, object oldObject, object newObject, int iItemObjectID, HistoryAction action, List<string> colList)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();

            PMHistorysInfo objHistorysInfo;
            List<PMHistorysInfo> historysList = new List<PMHistorysInfo>();

            //STToolbarsController rController = new STToolbarsController();
            //List<string> colList = rController.UserDefinedTableTypeColumnName("Type_PMHistorys");

            switch (action)
            {
                case HistoryAction.Change:
                    foreach (AAColumnAliasInfo alias in columnAliasList)
                    {
                        string oldValue = "";
                        string newValue = "";
                        if (dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName) != null)
                        {
                            oldValue = dbUtil.GetPropertyValue(oldObject, alias.AAColumnAliasName).ToString();
                        }

                        if (dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName) != null)
                        {
                            newValue = dbUtil.GetPropertyValue(newObject, alias.AAColumnAliasName).ToString();
                        }
                        if (oldValue != newValue)
                        {
                            objHistorysInfo = new PMHistorysInfo();
                            objHistorysInfo.PMHistoryColumnName = alias.AAColumnAliasName;
                            objHistorysInfo.PMHistoryOldValue = oldValue;
                            objHistorysInfo.PMHistoryNewValue = newValue;
                            historysList.Add(objHistorysInfo);
                        }
                    }

                    if (historysList.Count > 0)
                    {
                        historysList.ForEach(o1 =>
                        {
                            o1.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                            o1.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                            o1.PMHistoryObjectName = ItemTableName;
                            string no = "";
                            if (dbUtil.GetPropertyValue(newObject, ItemTableName.Substring(0, ItemTableName.Length - 1) + "No") != null)
                            {
                                no = dbUtil.GetPropertyValue(newObject, ItemTableName.Substring(0, ItemTableName.Length - 1) + "No").ToString();
                            }
                            o1.PMHistoryObjectNo = no;
                            o1.PMHistoryAction = action.ToString();
                            o1.PMHistoryDate = BOSApp.GetCurrentServerDate();
                            o1.PMHistoryObjectID = iItemObjectID;
                        });
                    }
                    break;

                case HistoryAction.Create:
                case HistoryAction.Delete:
                    objHistorysInfo = new PMHistorysInfo();
                    objHistorysInfo.ADUserID = BOSApp.CurrentUsersInfo.ADUserID;
                    objHistorysInfo.ADUserName = BOSApp.CurrentUsersInfo.ADUserName;
                    objHistorysInfo.PMHistoryObjectName = ItemTableName;
                    objHistorysInfo.PMHistoryAction = action == HistoryAction.Create ? HistoryAction.Create.ToString() : HistoryAction.Delete.ToString();
                    objHistorysInfo.PMHistoryDate = BOSApp.GetCurrentServerDate();
                    objHistorysInfo.PMHistoryObjectID = iItemObjectID;
                    historysList.Add(objHistorysInfo);
                    break;
            }

            DataTable newTable = CollectionExtensions.AsDataTable<PMHistorysInfo>(historysList, colList);

            return newTable;
        }
    }
}
