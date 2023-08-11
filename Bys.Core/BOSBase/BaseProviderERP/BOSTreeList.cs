using BOSComponent;
using BOSLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace BOSERP
{
    public class BOSTreeList : BOSList<BOSTreeListObject>, DevExpress.XtraTreeList.TreeList.IVirtualTreeListData, IBOSTreeList
    {
        #region Variables
        protected BOSTreeListControl _treeListControl;
        #endregion

        #region Public properties
        public BOSTreeListControl TreeListControl
        {
            get
            {
                return _treeListControl;
            }
            set
            {
                _treeListControl = value;
            }
        }

        public BOSTreeListObject CurrentObject
        {
            get
            {
                DevExpress.XtraTreeList.Nodes.TreeListNode currentNode = TreeListControl.GetSelectedNode();
                if (currentNode != null)
                    return (BOSTreeListObject)TreeListControl.GetDataRecordByNode(currentNode);
                return null;
            }
            set
            {
                DevExpress.XtraTreeList.Nodes.TreeListNode currentNode = TreeListControl.GetSelectedNode();
                if (currentNode != null)
                {
                    BOSTreeListObject currentObject = (BOSTreeListObject)TreeListControl.GetDataRecordByNode(currentNode);
                    currentObject = value;
                }
            }
        }

        public bool CheckAll { get; set; }

        public bool IsSwitchToEdit = true;
        #endregion

        void DevExpress.XtraTreeList.TreeList.IVirtualTreeListData.VirtualTreeGetChildNodes(DevExpress.XtraTreeList.VirtualTreeGetChildNodesInfo info)
        {
            try
            {
                BOSTreeListObject obj = info.Node as BOSTreeListObject;
                info.Children = (BOSTreeList)obj.SubList;
            }
            catch (Exception ex)
            {
                return;
            }
        }

        void DevExpress.XtraTreeList.TreeList.IVirtualTreeListData.VirtualTreeGetCellValue(DevExpress.XtraTreeList.VirtualTreeGetCellValueInfo info)
        {
            try
            {

                BOSDbUtil dbUtil = new BOSDbUtil();
                BOSTreeListObject obj = info.Node as BOSTreeListObject;
                info.CellData = dbUtil.GetPropertyValue(obj, info.Column.FieldName);
            }
            catch (Exception ex)
            {
                return;
            }
        }
        void DevExpress.XtraTreeList.TreeList.IVirtualTreeListData.VirtualTreeSetCellValue(DevExpress.XtraTreeList.VirtualTreeSetCellValueInfo info)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSTreeListObject obj = info.Node as BOSTreeListObject;
            try
            {
                SetPropertyValue(obj, info.Column.FieldName, info.NewCellData);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public void SetPropertyValue(BusinessObject obj, String strPropertyName, object value)
        {
            PropertyInfo property = obj.GetType().GetProperty(strPropertyName);
            if (property != null)
            {
                Type type = property.PropertyType;
                string strTypename = type.Name;
                if (strTypename != string.Empty && value != null)
                {
                    switch (strTypename.ToLower())
                    {
                        case "double":
                            property.SetValue(obj, double.Parse(value.ToString()), null);
                            break;
                        case "int":
                            property.SetValue(obj, int.Parse(value.ToString()), null);
                            break;
                        case "int32":
                            property.SetValue(obj, int.Parse(value.ToString()), null);
                            break;
                        case "boolean":
                            property.SetValue(obj, bool.Parse(value.ToString()), null);
                            break;
                        case "bool":
                            property.SetValue(obj, bool.Parse(value.ToString()), null);
                            break;
                        case "DateTime":
                            property.SetValue(obj, DateTime.Parse(value.ToString()), null);
                            break;
                        case "float":
                            property.SetValue(obj, float.Parse(value.ToString()), null);
                            break;
                        case "long":
                            property.SetValue(obj, long.Parse(value.ToString()), null);
                            break;
                        case "decimal":
                            property.SetValue(obj, decimal.Parse(value.ToString()), null);
                            break;
                        case "byte":
                            property.SetValue(obj, byte.Parse(value.ToString()), null);
                            break;
                        default:
                            property.SetValue(obj, value, null);
                            break;
                    }
                }
                else
                {
                    property.SetValue(obj, value, null);
                }
            }
        }
        public virtual void InitBOSTreeListControl()
        {
            String strTreeListControlName = "fld_trl" + ItemTableName;
            InitBOSTreeListControl(strTreeListControlName);
        }

        public virtual void InitBOSTreeListControl(String strTreeListControlName)
        {
            if (Entity.Module.Controls[strTreeListControlName] != null)
            {
                InitBOSTreeListControl((BOSTreeListControl)Entity.Module.Controls[strTreeListControlName]);
            }
        }

        public virtual void InitBOSTreeListControl(BOSTreeListControl treeListControl)
        {
            TreeListControl = treeListControl;
            TreeListControl.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
            TreeListControl.CellValueChanging += new DevExpress.XtraTreeList.CellValueChangedEventHandler(TreeList_CellValueChanging);
        }

        public void SetDefaultListAndRefreshTreeListControl()
        {
            this.Clear();
            this.OriginalList.Clear();
            if (TreeListControl != null)
                TreeListControl.RefreshDataSource();
        }

        #region Tree list event handlers
        protected virtual void TreeList_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {

                if (e.Node != null && CurrentObject != null)
                {
                    Entity.InvalidateModuleObject((BusinessObject)CurrentObject.Clone());
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        protected virtual void TreeList_CellValueChanging(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            try
            {
                if (Entity.ModuleObjects[ItemTableName] != null && IsSwitchToEdit)
                {
                    Entity.Module.SwitchToEditMode(Entity.ModuleObjects[ItemTableName], String.Empty);
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
        #endregion

        #region Invalidation functions
        public virtual void InvalidateTreeList(int iObjectID)
        {
            CheckAll = false;
            this.Invalidate(iObjectID);

            if (Entity != null)
            {
                if (this.Count > 0)
                    Entity.InvalidateModuleObject(this[0]);
                else
                    Entity.InvalidateModuleObject(BusinessObjectFactory.GetBusinessObject(ItemTableName + "Info"));
            }

            if (TreeListControl != null)
            {
                TreeListControl.RefreshDataSource();
                TreeListControl.ExpandAll();
            }
        }

        public virtual void InvalidateTreeList(int iObjectID, bool checkAll)
        {
            CheckAll = checkAll;
            this.Invalidate(iObjectID);

            if (Entity != null)
            {
                if (this.Count > 0)
                    Entity.InvalidateModuleObject(this[0]);
                else
                    Entity.InvalidateModuleObject(BusinessObjectFactory.GetBusinessObject(ItemTableName + "Info"));
            }

            if (TreeListControl != null)
            {
                TreeListControl.RefreshDataSource();
                TreeListControl.ExpandAll();
            }
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            InvalidateSubList();
        }

        public override void Invalidate(System.Data.DataSet ds)
        {
            base.Invalidate(ds);
            InvalidateSubList();
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
        }

        public virtual void Invalidate(IList lst)
        {
            this.Clear();
            BOSDisposeUtility.DisposeAll(this, 0, GCCollectionMode.Forced);
            foreach (BOSTreeListObject obj in lst)
            {
                this.Add((BOSTreeListObject)obj.Clone());
            }

            //Invalidate original list same as itself
            OriginalList.Clear();
            BOSDisposeUtility.DisposeAll(OriginalList, 0, GCCollectionMode.Forced);
            foreach (BOSTreeListObject obj in this)
                OriginalList.Add((BOSTreeListObject)obj.Clone());

            //Invalidate backup list same as itself
            BackupList.Clear();
            BOSDisposeUtility.DisposeAll(BackupList, 0, GCCollectionMode.Forced);
            foreach (BOSTreeListObject obj in this)
            {
                BackupList.Add((BOSTreeListObject)obj.Clone());
            }

            InvalidateSubList();
        }

        public virtual void Invalidate(IList lst, int parentID)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String strParentObjectIDForeignKey = ItemTableName.Substring(0, ItemTableName.Length - 1) + "ParentID";
            this.Clear();
            BOSDisposeUtility.DisposeAll(this, 0, GCCollectionMode.Forced);
            foreach (BOSTreeListObject obj in lst)
            {
                int parentObjectIDForeignID = Convert.ToInt32(dbUtil.GetPropertyValue(obj, strParentObjectIDForeignKey));
                if (parentObjectIDForeignID == parentID)
                    this.Add((BOSTreeListObject)obj.Clone());
            }

            //Invalidate original list same as itself
            OriginalList.Clear();
            BOSDisposeUtility.DisposeAll(OriginalList, 0, GCCollectionMode.Forced);
            foreach (BOSTreeListObject obj in this)
                OriginalList.Add((BOSTreeListObject)obj.Clone());
            //Invalidate backup list same as itself
            BackupList.Clear();
            BOSDisposeUtility.DisposeAll(BackupList, 0, GCCollectionMode.Forced);
            foreach (BOSTreeListObject obj in this)
            {
                BackupList.Add((BOSTreeListObject)obj.Clone());
            }

            InvalidateSubList(lst);
        }

        /// <summary>
        /// Invalidate sub list of a tree list node
        /// </summary>
        private void InvalidateSubList(IList lst)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (BOSTreeListObject obj in this)
            {
                if (CheckAll)
                    obj.Selected = true;

                String strParentObjectIDForeignKey = ItemTableName.Substring(0, ItemTableName.Length - 1) + "ParentID";
                int parentObjectIDForeignID = Convert.ToInt32(dbUtil.GetPropertyValue(obj, strParentObjectIDForeignKey));
                if (parentObjectIDForeignID == 0 || obj.TheNumberOfChild > 0)
                {
                    //Make the type of sub list same as its parent
                    object objType = this.GetType().InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                    obj.SubList = (BOSTreeList)objType;
                    obj.SubList.InitBOSList(Entity, ItemTableName, ItemTableName);

                    String parentTablePrimaryKey = BOSApp.GetTablePrimaryColumn(obj.SubList.ParentTableName);
                    int parentObjectID = Convert.ToInt32(dbUtil.GetPropertyValue(obj, parentTablePrimaryKey));
                    obj.SubList.CheckAll = CheckAll;
                    obj.SubList.Invalidate(lst, parentObjectID);
                    foreach (BOSTreeListObject objSub in obj.SubList)
                        objSub.Parent = obj;
                }
            }
        }

        /// <summary>
        /// Invalidate sub list of a tree list node
        /// </summary>
        private void InvalidateSubList()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (BOSTreeListObject obj in this)
            {
                if (CheckAll)
                    obj.Selected = true;

                String strParentObjectIDForeignKey = ItemTableName.Substring(0, ItemTableName.Length - 1) + "ParentID";
                int parentObjectIDForeignID = Convert.ToInt32(dbUtil.GetPropertyValue(obj, strParentObjectIDForeignKey));
                if (parentObjectIDForeignID == 0 || obj.TheNumberOfChild > 0)
                {
                    //Make the type of sub list same as its parent
                    object objType = this.GetType().InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                    obj.SubList = (BOSTreeList)objType;
                    obj.SubList.InitBOSList(Entity, ItemTableName, ItemTableName);

                    String parentTablePrimaryKey = BOSApp.GetTablePrimaryColumn(obj.SubList.ParentTableName);
                    int parentObjectID = Convert.ToInt32(dbUtil.GetPropertyValue(obj, parentTablePrimaryKey));
                    obj.SubList.CheckAll = CheckAll;
                    obj.SubList.Invalidate(parentObjectID);
                    foreach (BOSTreeListObject objSub in obj.SubList)
                        objSub.Parent = obj;
                }
            }
        }
        #endregion

        public override BOSTreeListObject SaveObjectToList(bool IsNew)
        {
            if (TreeListControl != null)
                TreeListControl.InvalidateLookupEditColumns();

            BOSDbUtil dbUtil = new BOSDbUtil();
            String strMainTableName = String.Empty;
            if (Entity.MainObject != null)
                strMainTableName = BOSUtil.GetTableNameFromBusinessObject(Entity.MainObject);

            BOSTreeListObject obj = new BOSTreeListObject();
            if (!String.IsNullOrEmpty(ParentTableName))
            {
                if (ItemTableName.Equals(strMainTableName))
                {
                    obj = (BOSTreeListObject)Entity.MainObject.Clone();
                }
                else
                {
                    obj = (BOSTreeListObject)Entity.ModuleObjects[ItemTableName].Clone();
                }
            }
            else
            {
                obj = (BOSTreeListObject)Entity.ModuleObjects[ItemTableName].Clone();
            }
            //Refer sub list to new list because Clone() does not copy it
            obj.SubList = new BOSTreeList();

            if (IsNew)
            {
                String strPrimaryKey = ItemTableName.Substring(0, ItemTableName.Length - 1) + "ID";
                dbUtil.SetPropertyValue(obj, strPrimaryKey, 0);
                if (CurrentObject.SubList == null)
                    CurrentObject.SubList = new BOSTreeList();
                CurrentObject.SubList.Add(obj);
            }
            else
            {
                BOSTreeListObject currObj = CurrentObject;
                PropertyInfo[] props = currObj.GetType().GetProperties();
                foreach (PropertyInfo prop in props)
                    if (typeof(BOSTreeListObject).GetProperty(prop.Name) == null)
                        dbUtil.SetPropertyValue(currObj, prop.Name, dbUtil.GetPropertyValue(obj, prop.Name));
            }
            return obj;
        }

        public override void AddObjectToList()
        {
            if (CurrentObject != null)
            {
                this.SaveObjectToList(true);
                TreeListControl.RefreshDataSource();
                TreeListControl.ExpandAll();
            }
        }

        public override void ChangeObjectFromList()
        {
            DevExpress.XtraTreeList.Nodes.TreeListNode currNode = TreeListControl.GetSelectedNode();
            if (currNode != null)
            {
                if (TreeListControl.BOSDisplayRoot && currNode.Level == 0)
                    return;
                this.SaveObjectToList(false);
                TreeListControl.RefreshDataSource();
                TreeListControl.ExpandAll();
            }
        }

        public override void RemoveSelectedRowObjectFromList()
        {
            DevExpress.XtraTreeList.Nodes.TreeListNode currentNode = TreeListControl.GetSelectedNode();
            if (currentNode != null)
            {
                if (TreeListControl.BOSDisplayRoot)
                {
                    if (currentNode.Level > 0)
                        currentNode.ParentNode.Nodes.Remove(currentNode);
                }
                else
                {
                    if (currentNode.Level == 0)
                        TreeListControl.Nodes.Remove(currentNode);
                    else
                        currentNode.ParentNode.Nodes.Remove(currentNode);
                }

                //Switch module to edit mode before removing
                if (Entity.Module.IsEditable())
                {
                    Entity.Module.ActionEdit();
                }
            }
        }

        public override void SaveItemObjects(List<int> currentIds = null)
        {
            EndCurrentEdit();
            BOSDbUtil dbUtil = new BOSDbUtil();
            //String strItemTablePrimaryKey = dbUtil.GetTablePrimaryColumn(ItemTableName);
            //BaseBusinessController objItemsController = BusinessControllerFactory.GetBusinessController(ItemTableName + "Controller");
            //// Delete sub Item by delete Item
            //foreach (BOSTreeListObject obj in OriginalList)
            //{
            //    int iItemObjectID = (int)dbUtil.GetPropertyValue(obj, strItemTablePrimaryKey);
            //    if (iItemObjectID > 0 && !this.Exists(strItemTablePrimaryKey, iItemObjectID))
            //    {
            //        objItemsController.DeleteObject(iItemObjectID);
            //        Entity.DeleteObjectRelations(ItemTableName, iItemObjectID);
            //        if ((obj.SubList != null && obj.SubList.Count > 0) || obj.TheNumberOfChild > 0)
            //        {
            //            objItemsController.DeleteAllObjectsByObjectParentID(iItemObjectID);
            //        }
            //    }
            //}
            base.SaveItemObjects(currentIds);
            int iMainObjectID = 0;
            string strParentTableForeignKey = string.Empty;
            if (Entity.MainObject != null)
            {
                string strMainTableName = BOSUtil.GetTableNameFromBusinessObject(Entity.MainObject);
                string strMainTablePrimaryKey = BOSApp.GetTablePrimaryColumn(strMainTableName);
                iMainObjectID = dbUtil.GetPropertyIntValue(Entity.MainObject, strMainTablePrimaryKey);
                strParentTableForeignKey = "FK_" + strMainTablePrimaryKey;
            }

            foreach (BOSTreeListObject obj in this)
            {
                if (obj.SubList == null)
                {
                    obj.SubList = new BOSTreeList();
                }
                obj.SubList.InitBOSList(Entity, ItemTableName, ItemTableName);
                String parentTablePrimaryKey = BOSApp.GetTablePrimaryColumn(obj.SubList.ParentTableName);
                int parentObjectID = Convert.ToInt32(dbUtil.GetPropertyValue(obj, parentTablePrimaryKey));
                foreach (BOSTreeListObject objSub in obj.SubList)
                {
                    dbUtil.SetPropertyValue(objSub, obj.SubList.ItemTableForeignKey, parentObjectID);
                    dbUtil.SetPropertyValue(objSub, strParentTableForeignKey, iMainObjectID);
                }
                if (obj.SubList.Count > 0 || obj.SubList.OriginalList.Count > 0)
                    obj.SubList.SaveItemObjects(currentIds);
            }
        }

        public void SaveItemObjectsNoneReference()
        {
            EndCurrentEdit();
            BOSDbUtil dbUtil = new BOSDbUtil();
            //String strItemTablePrimaryKey = dbUtil.GetTablePrimaryColumn(ItemTableName);
            //BaseBusinessController objItemsController = BusinessControllerFactory.GetBusinessController(ItemTableName + "Controller");
            //// Delete sub Item by delete Item
            //foreach (BOSTreeListObject obj in OriginalList)
            //{
            //    int iItemObjectID = (int)dbUtil.GetPropertyValue(obj, strItemTablePrimaryKey);
            //    if (iItemObjectID > 0 && !this.Exists(strItemTablePrimaryKey, iItemObjectID))
            //    {
            //        objItemsController.DeleteObject(iItemObjectID);
            //        Entity.DeleteObjectRelations(ItemTableName, iItemObjectID);
            //        if ((obj.SubList != null && obj.SubList.Count > 0) || obj.TheNumberOfChild > 0)
            //        {
            //            objItemsController.DeleteAllObjectsByObjectParentID(iItemObjectID);
            //        }
            //    }
            //}

            base.SaveItemCDObjects();

            foreach (BOSTreeListObject obj in this)
            {
                if (obj.SubList == null)
                {
                    obj.SubList = new BOSTreeList();
                }
                obj.SubList.InitBOSList(Entity, ItemTableName, ItemTableName);
                String parentTablePrimaryKey = BOSApp.GetTablePrimaryColumn(obj.SubList.ParentTableName);
                int parentObjectID = Convert.ToInt32(dbUtil.GetPropertyValue(obj, parentTablePrimaryKey));
                foreach (BOSTreeListObject objSub in obj.SubList)
                {
                    dbUtil.SetPropertyValue(objSub, obj.SubList.ItemTableForeignKey, parentObjectID);
                }
                if (obj.SubList.Count > 0 || obj.SubList.OriginalList.Count > 0)
                    obj.SubList.SaveItemObjectsNoneReference();
            }
        }

        #region Functions for getting object
        public virtual BOSTreeListObject GetSelectedObject()
        {
            foreach (BOSTreeListObject obj in this)
            {
                if (obj.Selected)
                    return obj;
                if (obj.HasChildren())
                {
                    BOSTreeListObject objSub = obj.SubList.GetSelectedObject();
                    if (objSub != null)
                        return objSub;
                }
            }
            return null;
        }

        public override bool Exists(string strPropertyName, object objPropertyValue)
        {
            BOSTreeListObject obj = GetObjectByPropertyNameAndValue(strPropertyName, objPropertyValue);
            if (obj != null)
                return true;
            return false;
        }

        public virtual BOSTreeListObject GetObjectByPropertyNameAndValue(string strPropertyName, object objPropertyValue)
        {
            int pos = base.PosOf(strPropertyName, objPropertyValue);
            if (pos >= 0)
                return this[pos];
            else
            {
                foreach (BOSTreeListObject obj in this)
                {
                    if (obj.SubList != null)
                    {
                        if (obj.SubList.Count > 0)
                        {
                            BOSTreeListObject objSub = obj.SubList.GetObjectByPropertyNameAndValue(strPropertyName, objPropertyValue);
                            if (objSub != null)
                                return objSub;
                        }
                    }
                }
            }
            return null;
        }

        public virtual BOSTreeListObject GetObjectByTemplateObject(BOSTreeListObject objTemplateObject, params String[] propertyNames)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (BOSTreeListObject obj in this)
            {
                bool flag = false;
                foreach (String propertyName in propertyNames)
                    if (!dbUtil.GetPropertyValue(obj, propertyName).Equals(dbUtil.GetPropertyValue(objTemplateObject, propertyName)))
                        flag = true;
                if (flag == false)
                    return obj;
            }

            foreach (BOSTreeListObject obj in this)
                if (obj.SubList.Count > 0)
                {
                    BOSTreeListObject objSub = obj.SubList.GetObjectByTemplateObject(objTemplateObject, propertyNames);
                    if (objSub != null)
                        return objSub;
                }
            return null;
        }
        #endregion

        public override void Duplicate()
        {
            base.Duplicate();

            foreach (BOSTreeListObject obj in this)
                if (obj.HasChildren())
                    obj.SubList.Duplicate();
        }

        public virtual void GetLastNodes(IBOSList<BOSTreeListObject> lst)
        {
            foreach (BOSTreeListObject obj in this)
            {
                if (obj.HasChildren())
                    obj.SubList.GetLastNodes(lst);
                else
                    lst.Add(obj);
            }
        }

        public virtual void EndCurrentEdit()
        {
            if (TreeListControl != null)
                TreeListControl.FocusedNode = null;
        }

        /// <summary>
        /// Set a value to all items of tree list
        /// </summary>
        /// <param name="propertyName">Name of the property that need to be set</param>
        /// <param name="value">Value to be set</param>
        public virtual void SetValueToList(string propertyName, object value)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (BOSTreeListObject obj in this)
            {
                dbUtil.SetPropertyValue(obj, propertyName, value);
                if (obj.HasChildren())
                {
                    obj.SubList.SetValueToList(propertyName, value);
                }
            }
        }

        public virtual void ConvertToList(IList list)
        {
            foreach (BOSTreeListObject obj in this)
            {
                list.Add(obj);
                if (obj.SubList != null)
                {
                    if (obj.SubList.Count > 0)
                    {
                        obj.SubList.ConvertToList(list);
                    }
                }
            }
        }

        public void InvalidateLoadMore(System.Data.DataSet ds)
        {
            base.Invalidate(ds);
            InvalidateLoadMoreSubList();
            BOSDisposeUtility.DisposeDataSet(ds, 0, GCCollectionMode.Forced);
        }

        public void InvalidateLoadMore(int parentObjectID)
        {
            base.Invalidate(parentObjectID);
            InvalidateLoadMoreSubList();
        }

        private void InvalidateLoadMoreSubList()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (BOSTreeListObject obj in this)
            {
                if (CheckAll)
                    obj.Selected = true;

                String strParentObjectIDForeignKey = ItemTableName.Substring(0, ItemTableName.Length - 1) + "ParentID";
                int parentObjectIDForeignID = Convert.ToInt32(dbUtil.GetPropertyValue(obj, strParentObjectIDForeignKey));
                if (parentObjectIDForeignID == 0 || obj.TheNumberOfChild > 0)
                {
                    //Make the type of sub list same as its parent
                    //object objType = this.GetType().InvokeMember("", BindingFlags.CreateInstance, null, null, null);
                    //obj.SubList = (BOSTreeList)objType;
                    //obj.SubList.InitBOSList(Entity, ItemTableName, ItemTableName);

                    //String parentTablePrimaryKey = dbUtil.GetTablePrimaryColumn(obj.SubList.ParentTableName);
                    //int parentObjectID = Convert.ToInt32(dbUtil.GetPropertyValue(obj, parentTablePrimaryKey));
                    //obj.SubList.CheckAll = CheckAll;
                    //obj.SubList.Invalidate(parentObjectID);
                    //foreach (BOSTreeListObject objSub in obj.SubList)
                    //    objSub.Parent = obj;
                }
            }
        }
    }
}
