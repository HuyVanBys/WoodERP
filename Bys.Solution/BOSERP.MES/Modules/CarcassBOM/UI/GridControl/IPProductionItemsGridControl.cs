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
    public partial class IPProductionItemsGridControl : BOSGridControl
    {
        List<MMOperationsInfo> OperationsList { get; set; }

        List<MMPaintProcessessInfo> PaintProcess { get; set; }

        public void InvalidateDataSource(List<IPProductionItemsInfo> dataSource, List<MMOperationsInfo> operationsList)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
            OperationsList = operationsList;
            MMPaintProcessessController objPaintProcessessController = new MMPaintProcessessController();
            DataSet ds = BOSApp.LookupTables["MMPaintProcessess"] as DataSet;
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData("MMPaintProcessess");
                BOSApp.LookupTables["MMPaintProcessess"] = ds;
            }
            PaintProcess = (List<MMPaintProcessessInfo>)objPaintProcessessController.GetListFromDataSet(ds);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridview = base.InitializeGridView();
            GridColumn column = gridview.Columns["IPProductionItemHasPaint"];
            if (column != null)
            {
                column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(BOSComponent.RepositoryItem.RepositoryItemCheckEdit.ToString());
            }
            return gridview;
        }
        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            IPProductionItemsInfo objProductionItemsInfo = (IPProductionItemsInfo)gridView.GetRow(e.RowHandle);
            if (objProductionItemsInfo == null)
                return;

            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.Where(o => o.ICProductNo.Trim() == objProductionItemsInfo.ICProductNo).FirstOrDefault();
            if (objProductsInfo == null)
            {
                if (string.IsNullOrEmpty(objProductionItemsInfo.IPProductionItemPaintProcessNo))
                    e.Appearance.BackColor = Color.PeachPuff;
            }
            else if (objProductsInfo.ICProductName.Trim() != objProductionItemsInfo.ICProductName || objProductsInfo.ICProductNo.Trim() != objProductionItemsInfo.ICProductNo)
            {
                e.Appearance.BackColor = Color.LightYellow;
            }

            MMOperationsInfo objOperationsInfo = OperationsList.Where(o => o.MMOperationNo.Trim() == objProductionItemsInfo.MMOperationNo).FirstOrDefault();
            if ((objOperationsInfo == null && !string.IsNullOrWhiteSpace(objProductionItemsInfo.MMOperationNo))
                || (objOperationsInfo != null && objOperationsInfo.MMOperationName != objProductionItemsInfo.MMOperationName))
                e.Appearance.BackColor = Color.PaleTurquoise;

            MMPaintProcessessInfo objPaintProcessessInfo = new MMPaintProcessessInfo();
            objPaintProcessessInfo = PaintProcess.Where(o => o.MMPaintProcessesNo == objProductionItemsInfo.IPProductionItemPaintProcessNo).FirstOrDefault();
            if ((objPaintProcessessInfo == null && !string.IsNullOrWhiteSpace(objProductionItemsInfo.IPProductionItemPaintProcessNo))
                || (objPaintProcessessInfo != null && objPaintProcessessInfo.MMPaintProcessesDesc != objProductionItemsInfo.IPProductionItemPaintProcessDesc))
                e.Appearance.BackColor = Color.Gainsboro;
        }
    }
}
