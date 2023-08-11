using BOSComponent;
using BOSERP.MES.Modules.CarcassBOM.ImportInfo;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class IPProductItemProcessGridControl : BOSGridControl
    {
        List<MMOperationsInfo> OperationsList { get; set; }

        List<MMProcesssInfo> ProcessDataList { get; set; }

        public void InvalidateDataSource(List<IPProductItemProcessInfo> dataSource, List<MMOperationsInfo> operationsList, List<MMProcesssInfo> processDataList)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
            OperationsList = operationsList;
            ProcessDataList = processDataList;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridview = base.InitializeGridView();
            GridColumn column = gridview.Columns["ICProductItemProcessInOutStockCheck"];
            if (column != null)
            {
                column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(BOSComponent.RepositoryItem.RepositoryItemCheckEdit.ToString());
            }
            column = gridview.Columns["ICProductItemProcessIsPlan"];
            if (column != null)
            {
                column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(BOSComponent.RepositoryItem.RepositoryItemCheckEdit.ToString());
            }
            column = gridview.Columns["ICProductItemProcessSyncProductCheck"];
            if (column != null)
            {
                column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(BOSComponent.RepositoryItem.RepositoryItemCheckEdit.ToString());
            }
            column = gridview.Columns["ICProductItemProcessForParentSyncCheck"];
            if (column != null)
            {
                column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(BOSComponent.RepositoryItem.RepositoryItemCheckEdit.ToString());
            }
            column = gridview.Columns["ICProductItemProcessIsEndProcess"];
            if (column != null)
            {
                column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(BOSComponent.RepositoryItem.RepositoryItemCheckEdit.ToString());
            }
            return gridview;
        }
        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            IPProductItemProcessInfo objProductItemProcessInfo = (IPProductItemProcessInfo)gridView.GetRow(e.RowHandle);
            if (objProductItemProcessInfo == null)
                return;

            MMOperationsInfo objOperationsInfo = OperationsList.Where(o => o.MMOperationNo == objProductItemProcessInfo.MMOperationNo).FirstOrDefault();
            if ((objOperationsInfo == null && !string.IsNullOrWhiteSpace(objProductItemProcessInfo.MMOperationNo))
                || (objOperationsInfo != null && objOperationsInfo.MMOperationName.Trim() != objProductItemProcessInfo.MMOperationName))
                e.Appearance.BackColor = Color.PaleTurquoise;

            objOperationsInfo = OperationsList.Where(o => o.MMOperationNo.Trim() == objProductItemProcessInfo.MMOperationSynNo).FirstOrDefault();
            if ((objOperationsInfo == null && !string.IsNullOrWhiteSpace(objProductItemProcessInfo.MMOperationSynNo))
                || (objOperationsInfo != null && objOperationsInfo.MMOperationName.Trim() != objProductItemProcessInfo.MMOperationSynName))
                e.Appearance.BackColor = Color.PaleTurquoise;

            MMProcesssInfo objProcesssInfo = new MMProcesssInfo();
            objProcesssInfo = ProcessDataList.Where(o => o.MMProcessNo == objProductItemProcessInfo.MMProcessNo).FirstOrDefault();
            if ((objProcesssInfo == null && !string.IsNullOrWhiteSpace(objProductItemProcessInfo.MMProcessNo))
                || (objProcesssInfo != null && objProcesssInfo.MMProcessName.Trim() != objProductItemProcessInfo.MMProcessName))
                e.Appearance.BackColor = Color.Gainsboro;
        }
    }
}
