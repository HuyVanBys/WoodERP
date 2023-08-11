using BOSComponent;
using BOSLib;
using BOSLib.Interfaces;
using DevExpress.XtraTreeList;
using System;
using System.Collections.Generic;
using System.Data;

namespace BOSERP
{
    public partial class BOSSearchResultsTreeListControl : BOSTreeListControl
    {
        /// <summary>
        /// Binding search result to the tree list control
        /// </summary>
        /// <param name="dsSearchResults">Search result data</param>
        public virtual void BindingSearchResult(DataSet dsSearchResults)
        {
            if (dsSearchResults.Tables.Count > 0)
            {
                ERPModuleEntities entity = ((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                String mainObjectControllerName = BOSUtil.GetBusinessControllerNameFromBusinessObject(entity.MainObject);
                String mainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(entity.MainObject);
                string mainTablePrefix = mainObjectTableName.Substring(0, mainObjectTableName.Length - 1);
                IBusinessController objCurrentObjectController = BusinessControllerFactory.GetBusinessController(mainObjectControllerName);

                List<BOSTreeListObject> objects = new List<BOSTreeListObject>();
                foreach (DataRow row in dsSearchResults.Tables[0].Rows)
                {
                    BOSTreeListObject obj = (BOSTreeListObject)objCurrentObjectController.GetObjectFromDataRow(row);
                    objects.Add(obj);
                }

                //bool showAll = false;
                //int count = objCurrentObjectController.GetRecordsCount();                
                //if (objects.Count == count)
                //{
                //    showAll = true;
                //}

                //if (showAll)
                //{
                //Remove child objects
                BOSDbUtil dbUtil = new BOSDbUtil();
                for (int i = 0; i < objects.Count; i++)
                {
                    int parentID = dbUtil.GetPropertyIntValue(objects[i], mainTablePrefix + "ParentID");
                    if (parentID > 0)
                    {
                        objects.RemoveAt(i);
                        i--;
                    }
                }

                BOSTreeList treeList = new BOSTreeList();
                treeList.InitBOSList(entity,
                                String.Empty,
                                mainObjectTableName,
                                BOSTreeList.cstRelationNone);
                treeList.Invalidate(objects);
                DataSource = treeList;
                ExpandAll();
                //}
                //else
                //{
                //    BOSTreeList treeList = new BOSTreeList();
                //    foreach (DataRow dr in dsSearchResults.Tables[0].Rows)
                //    {
                //        BOSTreeListObject objTreeListObject = (BOSTreeListObject)objCurrentObjectController.GetObjectFromDataRow(dr);
                //        treeList.Add(objTreeListObject);
                //    }
                //    DataSource = treeList;
                //    ExpandAll();
                //}                
            }
            dsSearchResults.Dispose();
        }

        public override void InitializeControl()
        {
            base.InitializeControl();

            this.FocusedNodeChanged += new FocusedNodeChangedEventHandler(BOSSearchResultsTreeListControl_FocusedNodeChanged);
            BOSDisplayRoot = true;
        }

        protected virtual void BOSSearchResultsTreeListControl_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSTreeListObject obj = (BOSTreeListObject)GetDataRecordByNode(e.Node);
            string mainTableName = BOSUtil.GetTableNameFromBusinessObject(((BaseModuleERP)Screen.Module).CurrentModuleEntity.MainObject);
            string mainTablePrimaryColumn = BOSApp.GetTablePrimaryColumn(mainTableName);
            DataRowCollection rows = Screen.Module.Toolbar.ObjectCollection.Tables[0].Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                if (obj != null)
                {
                    int objectID = dbUtil.GetPropertyIntValue(obj, mainTablePrimaryColumn);
                    if (objectID == Convert.ToInt32(rows[i][mainTablePrimaryColumn]))
                    {
                        Screen.Module.Toolbar.CurrentIndex = i;
                        Screen.Module.Toolbar.Invalidate();
                    }
                }
            }
        }
    }
}
