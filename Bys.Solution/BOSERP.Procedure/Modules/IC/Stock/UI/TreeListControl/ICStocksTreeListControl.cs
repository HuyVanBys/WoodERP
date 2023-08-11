using BOSLib;
using DevExpress.XtraTreeList.Columns;
using Localization;
using System.Data;

namespace BOSERP.Modules.Stock
{
    public partial class ICStocksTreeListControl : BOSSearchResultsTreeListControl
    {
        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);

            TreeListColumn column = Columns["ICStockNo"];
            column.VisibleIndex = 0;
            column.OptionsColumn.AllowEdit = false;

            column = Columns["ICStockName"];
            column.VisibleIndex = 1;
            column.OptionsColumn.AllowEdit = false;
        }

        public override void BindingSearchResult(DataSet dsSearchResults)
        {
            base.BindingSearchResult(dsSearchResults);

            BOSTreeList treeList = (BOSTreeList)DataSource;
            BOSTreeList dataSource = new BOSTreeList();
            dataSource.Add(new ICStocksInfo(StockLocalizedResources.StockList, string.Empty));
            dataSource[0].SubList = treeList;
            DataSource = dataSource;
            ExpandAll();
        }

        protected override void BOSSearchResultsTreeListControl_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            base.BOSSearchResultsTreeListControl_FocusedNodeChanged(sender, e);

            BOSDbUtil dbUtil = new BOSDbUtil();
            BOSTreeListObject obj = (BOSTreeListObject)GetDataRecordByNode(e.Node);
            int stockID = dbUtil.GetPropertyIntValue(obj, "ICStockID");
            if (stockID == 0)
            {
                StockEntities entity = (StockEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                entity.StockParentID = 0;
            }
        }
    }
}
