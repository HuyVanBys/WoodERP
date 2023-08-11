using BOSLib;
using DevExpress.XtraTreeList.Columns;
using Localization;
using System.Data;

namespace BOSERP.Modules.Operation
{
    public partial class MMOperationsTreeListControl : BOSSearchResultsTreeListControl
    {
        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            Columns.Clear();
            AddTreeListColumns(0, "MMOperationNo", "Mã", true, false, string.Empty);
            AddTreeListColumns(1, "MMOperationName", "Tên", true, false, string.Empty);
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
                column.Format.FormatString = formatNumber;
            }

            this.EndUpdate();
            this.Update();
        }
        public override void BindingSearchResult(DataSet dsSearchResults)
        {
            base.BindingSearchResult(dsSearchResults);

            BOSTreeList treeList = (BOSTreeList)DataSource;

            BOSTreeList dataSource = new BOSTreeList();
            dataSource.Add(new MMOperationsInfo(OperationLocalizedResources.OperationList, string.Empty));
            dataSource[0].SubList = treeList;
            DataSource = dataSource;
            ExpandAll();
            this.BestFitColumns();
        }

        protected override void BOSSearchResultsTreeListControl_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            base.BOSSearchResultsTreeListControl_FocusedNodeChanged(sender, e);

            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSTreeListObject obj = (BOSTreeListObject)GetDataRecordByNode(e.Node);
            if (obj != null)
            {
                int operationID = dbUtil.GetPropertyIntValue(obj, "MMOperationID");
                if (operationID == 0)
                {
                    OperationEntities entity = (OperationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                    entity.OperationParentID = 0;
                }
            }
        }
    }
}
