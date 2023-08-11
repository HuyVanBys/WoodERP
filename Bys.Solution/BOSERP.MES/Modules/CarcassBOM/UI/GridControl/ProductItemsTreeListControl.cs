using BOSComponent;
using BOSLib;
using DevExpress.Utils.DragDrop;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class ProductItemsTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties
        #endregion

        protected override void InitTreeListDataSource()
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DataSource = entity.ProductItemTreeList;
        }
        public override void InitializeControl()
        {
            this.BOSDisplayOption = false;
            base.InitializeControl();
            //InitTreeListColumns(this.BOSDataSource);
            InitTreeListDataSource();
            foreach (TreeListColumn column in this.Columns)
            {
                if (column.FieldName == "ICProductItemCode" || column.FieldName == "ICProductItemQty")
                {
                    column.OptionsColumn.AllowEdit = true;
                    column.OptionsColumn.ReadOnly = false;
                }
                else
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.OptionsColumn.ReadOnly = true;
                }
                if (column.FieldName == "ICProductCode")
                {
                    column.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
                }
            }
            this.OptionsView.AutoWidth = false;
            this.BestFitColumns();
            this.ExpandAll();
            this.KeyUp += new KeyEventHandler(ProductItemsTreeListControl_KeyUp);
            DragDropManager.Default.DragDrop += OnDragDrop;
            DragDropManager.Default.DragOver += OnDragOver;
            this.CellValueChanged += ProductItemsTreeListControl_CellValueChanged;
            this.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(ProductItemsTreeListControl_CustomColumnDisplayText);
            this.CustomColumnSort += ProductItemsTreeListControl_CustomColumnSort;
        }

        private void ProductItemsTreeListControl_CustomColumnSort(object sender, CustomColumnSortEventArgs e)
        {
            if (e.Column.FieldName != "ICProductCode") return;
            try
            {
                e.Result = Compare(e.NodeValue1.ToString(), e.NodeValue2.ToString());
            }
            catch { }
        }
        public int Compare(string x, string y)
        {
            string s1 = x;
            while (s1.Length > 0 && Char.IsDigit(s1.Last())) s1 = s1.TrimEnd(s1.Last());
            s1 = s1 + x.Substring(s1.Length).PadLeft(12, '0');

            string s2 = y;
            while (s2.Length > 0 && Char.IsDigit(s2.Last())) s2 = s2.TrimEnd(s2.Last());
            s2 = s2 + y.Substring(s2.Length).PadLeft(12, '0');

            return string.Compare(s1, s2);
        }
        private void ProductItemsTreeListControl_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Column.FieldName == "FK_ICProductItemChildID")
            {
                int id = 0;
                int.TryParse(e.Value.ToString(), out id);
                e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", id, "ICProductNo");
            }
        }

        #region DragDrop
        void OnDragDrop(object sender, DragDropEventArgs e)
        {
            try
            {

                e.Handled = false;
                if (e.Action == DragDropActions.None || e.InsertType == InsertType.None)
                    return;
                if (e.Target == this)
                    OnTreeListDrop(e);
                Cursor.Current = Cursors.Default;
                CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                this.DataSource = entity.ProductItemTreeList;
                entity.ProductItemTreeList.TreeListControl.RefreshDataSource();
                this.BestFitColumns();

            }
            catch (System.Exception)
            {
                // no thing by ReloadNodes of Tree view in RefreshDataSource
                e.Handled = false;
                e.InsertType = InsertType.None;
                e.Action = DragDropActions.None;
            }

        }
        void OnDragOver(object sender, DragOverEventArgs e)
        {
            if (object.ReferenceEquals(e.Source, e.Target))
                return;
            e.Default();
            if (e.InsertType == InsertType.None)
                return;
            e.Action = IsCopy(e.KeyState) ? DragDropActions.Copy : DragDropActions.Move;
            Cursor current = Cursors.No;
            if (e.Action != DragDropActions.None)
                current = Cursors.Default;
            e.Cursor = current;
        }
        bool IsCopy(DragDropKeyState key)
        {
            return (key & DragDropKeyState.Control) != 0;
        }
        void OnTreeListDrop(DragDropEventArgs e)
        {
            try
            {
                var items = e.GetData<IEnumerable<object>>();
                if (items.Count() == 0)
                    return;
                var destNode = GetDestNode(e.Location);
                List<object> _items = new List<object>(items);
                TreeListNode sourceNode = _items != null ? (TreeListNode)_items[0] : null;
                if (sourceNode == null || destNode == null) return;
                ICProductItemsInfo objDesParent = new ICProductItemsInfo();
                if (destNode.ParentNode != null)
                    objDesParent = (ICProductItemsInfo)destNode.ParentNode.TreeList.GetDataRecordByNode(destNode.ParentNode);
                ICProductItemsInfo objSourceParent = new ICProductItemsInfo();
                if (sourceNode.ParentNode != null)
                    objSourceParent = (ICProductItemsInfo)sourceNode.ParentNode.TreeList.GetDataRecordByNode(sourceNode.ParentNode);

                ICProductItemsInfo desItem = (ICProductItemsInfo)destNode.TreeList.GetDataRecordByNode(destNode);
                if (desItem == null) return;
                ICProductItemsInfo sourceItem = (ICProductItemsInfo)sourceNode.TreeList.GetDataRecordByNode(sourceNode);
                if (sourceItem == null) return;
                ICProductItemsInfo addItem = (ICProductItemsInfo)sourceItem.Clone();

                if (e.Action == DragDropActions.Move)
                {
                    if (objSourceParent != null && objSourceParent.SubList != null)
                        objSourceParent.SubList.Remove(sourceItem);
                }
                else if (e.Action == DragDropActions.Copy)
                    addItem = CopyTreeList(sourceItem);

                if (e.InsertType == InsertType.AsChild)
                {
                    addItem.ICProductItemParentID = desItem.ICProductItemID;
                    addItem.ICProductionItemParentCode = desItem.ICProductItemCode;

                    if (desItem.SubList == null) desItem.SubList = new BOSTreeList();
                    int indexTarget = desItem.SubList.IndexOf(addItem);
                    if (indexTarget < 0)
                        desItem.SubList.Add(addItem);
                }
                else if (e.InsertType == InsertType.After || e.InsertType == InsertType.Before)
                {
                    addItem.ICProductItemParentID = objDesParent.ICProductItemID;
                    addItem.ICProductionItemParentCode = objDesParent.ICProductItemCode;
                    if (objDesParent.SubList == null) objDesParent.SubList = new BOSTreeList();
                    int indexTarget = objDesParent.SubList.IndexOf(addItem);
                    if (indexTarget < 0)
                        objDesParent.SubList.Add(addItem);
                }
                this.BeginUpdate();
                this.Selection.UnselectAll();
                this.EndUpdate();
                e.InsertType = InsertType.None;
                e.Action = DragDropActions.None;
            }
            catch (System.Exception)
            {
                this.BeginUpdate();
                this.Selection.UnselectAll();
                this.EndUpdate();
                e.InsertType = InsertType.None;
                e.Action = DragDropActions.None;
            }
        }

        TreeListNode GetDestNode(Point hitPoint)
        {
            Point pt = this.PointToClient(hitPoint);
            DevExpress.XtraTreeList.TreeListHitInfo ht = this.CalcHitInfo(pt);
            TreeListNode destNode = ht.Node;
            if (destNode is TreeListAutoFilterNode)
                return null;
            return destNode;
        }
        #endregion
        void ProductItemsTreeListControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CarcassBOMModule)Screen.Module).RemoveProductItemNode();
            }
        }
        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            #region InitTreeListColumns
            //AddTreeListColumns(0, "ICProductCode","Mã Code", true, false, string.Empty);
            //AddTreeListColumns(1, "ICProductName", "Tên chi tiết", true, false, string.Empty);
            //AddTreeListColumns(2, "ICProductItemQty", "Số lượng ", false, true, "{0:n6}");
            //AddTreeListColumns(3, "ICProductItemCode", "Mã nút", false, true, string.Empty);
            //AddTreeListColumns(4, "ICProductionItemParentCode", "Mã nút cha", true, false, string.Empty);
            #endregion
            this.OptionsView.ShowSummaryFooter = true;
        }

        private void ProductItemsTreeListControl_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ICProductItemsInfo item = (ICProductItemsInfo)entity.ProductItemTreeList.CurrentObject;
            MMProductionNormsInfo mainobject = (MMProductionNormsInfo)entity.MainObject;
            if (item == null) return;
            if (e.Column.FieldName == "ICProductItemCode")
            {
                DevExpress.XtraEditors.Repository.RepositoryItem edit = (DevExpress.XtraEditors.Repository.RepositoryItem)e.Column.ColumnEdit;
                if (!CheckExitTreeCode(item)) item.ICProductItemCode = edit != null && edit.OwnerEdit != null ? edit.OwnerEdit.OldEditValue.ToString() : string.Empty;
                if (item.FK_ICProductItemChildID == mainobject.FK_ICProductID)
                    item.ICProductionItemParentCode = item.ICProductItemCode;

                ResetParentCode(item);
                this.RefreshDataSource();
            }
        }
        public void AddTreeListColumns(int visibleIndex, string fieldName, string caption, bool readOnly, bool AllowEdit, string formatNumber)
        {
            this.BeginUpdate();
            TreeListColumn column = Columns.Add();
            column.Visible = true;
            column.OptionsColumn.AllowEdit = AllowEdit;
            column.OptionsColumn.ReadOnly = readOnly;
            this.OptionsView.AutoWidth = false;
            column.Caption = caption;
            column.OptionsColumn.FixedWidth = false;
            column.VisibleIndex = visibleIndex;
            column.FieldName = fieldName;

            if (!string.IsNullOrEmpty(formatNumber))
            {
                column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                //column.Format.FormatString = formatNumber;
            }
            this.EndUpdate();
            this.Update();
        }
        public void ResetCopyKey(ICProductItemsInfo addItem)
        {
            if (addItem == null) return;
            addItem.ICProductItemID = 0;
            if (addItem.SubList != null && addItem.SubList.Count > 0)
            {
                foreach (ICProductItemsInfo item in addItem.SubList)
                {
                    if (item != null)
                        ResetCopyKey(item);
                }
            }
        }
        ICProductItemsInfo toAddItem;
        public ICProductItemsInfo CopyTreeList(ICProductItemsInfo from)
        {
            ICProductItemsInfo result = new ICProductItemsInfo();
            BOSUtil.CopyObject(from, result);
            result.ICProductItemID = 0;
            if (from != null && from.SubList != null && from.SubList.Count() > 0)
            {
                result.SubList = new BOSTreeList();
                foreach (ICProductItemsInfo item in from.SubList)
                {
                    result.SubList.Add(CopyTreeList(item));

                }
            }
            return result;
        }
        public void ResetParentCode(ICProductItemsInfo curItem)
        {
            if (curItem.SubList != null)
            {
                foreach (ICProductItemsInfo item in curItem.SubList)
                {
                    item.ICProductionItemParentCode = curItem.ICProductItemCode;
                }
            }
        }
        public bool CheckExitTreeCode(ICProductItemsInfo curItem)
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            bool result = true;
            if (curItem != null)
            {
                List<ICProductItemsInfo> convert = new List<ICProductItemsInfo>();
                try
                {
                    entity.ProductItemTreeList.ConvertToList(convert);
                    List<ICProductItemsInfo> existTtem = convert.Where(c => c.ICProductItemCode.Trim().ToLower() == curItem.ICProductItemCode.Trim().ToLower()
                                                                                    && !string.IsNullOrEmpty(c.ICProductItemCode)).ToList();
                    if (existTtem.Count() > 1)
                    {
                        result = false;
                        BOSApp.ShowMessage(string.Format("Tồn tại nút: {0} trong danh sách!", curItem.ICProductItemCode));
                        existTtem.ForEach(n => n.IsError = true);
                    }
                }
                catch (System.Exception ex)
                {
                    result = false;
                }

            }
            return result;
        }

    }
}
