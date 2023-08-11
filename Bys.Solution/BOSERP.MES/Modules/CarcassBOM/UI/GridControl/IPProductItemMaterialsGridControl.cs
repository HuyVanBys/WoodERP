using BOSComponent;
using BOSERP.MES.Modules.CarcassBOM.ImportInfo;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class IPProductItemMaterialsGridControl : BOSGridControl
    {
        List<MMOperationsInfo> OperationsList { get; set; }
        public void InvalidateDataSource(List<IPProductItemMaterialsInfo> dataSource, List<MMOperationsInfo> operationsList)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
            OperationsList = operationsList;
        }

        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            IPProductItemMaterialsInfo objProductItemMaterialsInfo = (IPProductItemMaterialsInfo)gridView.GetRow(e.RowHandle);
            if (objProductItemMaterialsInfo == null)
                return;

            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.Where(o => o.ICProductNo == objProductItemMaterialsInfo.ICProductNo).FirstOrDefault();
            if (objProductsInfo == null)
            {
                e.Appearance.BackColor = Color.Salmon;
            }
            else if (objProductsInfo.ICProductName.Trim() != objProductItemMaterialsInfo.ICProductName || objProductsInfo.ICProductNo.Trim() != objProductItemMaterialsInfo.ICProductNo)
            {
                e.Appearance.BackColor = Color.Moccasin;
            }

            MMOperationsInfo objOperationsInfo = OperationsList.Where(o => o.MMOperationNo.Trim() == objProductItemMaterialsInfo.MMOperationNo).FirstOrDefault();
            if ((objOperationsInfo == null && !string.IsNullOrWhiteSpace(objProductItemMaterialsInfo.MMOperationNo))
                || (objOperationsInfo != null && objOperationsInfo.MMOperationName.Trim() != objProductItemMaterialsInfo.MMOperationName))
                e.Appearance.BackColor = Color.PaleTurquoise;
        }
    }
}
