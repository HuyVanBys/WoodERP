using BOSCommon;
using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseProposal
{
    public class ICInventoryStocksGridControl : BOSGridControl
    {
        List<AAColumnAliasInfo> LstCustomAliasList { get; set; }

        public void InvalidateDataSource(List<ICInventoryStocksInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override void AddColumnsFromColumnAlias(string strTableName, GridView gridView, List<AAColumnAliasInfo> lstColumnAlias)
        {
            LstCustomAliasList = new List<AAColumnAliasInfo>();
            AddGridColumn(strTableName, "ICDepartmentName", "Ngành hàng");
            AddGridColumn(strTableName, "ICProductGroupName", "Nhóm hàng");
            AddGridColumn(strTableName, "ICProductNo", "Mã sản phẩm");
            AddGridColumn(strTableName, "ICProductName", "Tên sản phẩm");
            AddGridColumn(strTableName, "ICProductDesc", "Mô tả");
            AddGridColumn(strTableName, "ICInventoryStockQuantity", "SL hiện có");
            AddGridColumn(strTableName, "ICInventoryStockSaleOrderQuantity", "SL đặt bán");
            AddGridColumn(strTableName, "ICInventoryStockPurchaseOrderQuantity", "SL đặt mua");
            AddGridColumn(strTableName, "ICInventoryStockCanUserQuantity", "SL có thể sử dụng");
            AddGridColumn(strTableName, "ICInventoryStockTransitInQuantity", "SL hàng về");
            AddGridColumn(strTableName, "ICInventoryStockTransitOutQuantity", "SL trung chuyển");
            AddGridColumn(strTableName, "ICInventoryStocAllocationPlanQuantity", "SL hoạch định");
            AddGridColumn(strTableName, "ICInventoryStockMinQuantity", "SL tồn kho min");
            AddGridColumn(strTableName, "ICInventoryStockMaxQuantity", "SL tồn kho max");
            AddGridColumn(strTableName, "ICInventoryStockProposalQuantity", "SL đề nghị");
            AddGridColumn(strTableName, "ICInventoryStockOrderDate", "Thời gian mua");
            AddGridColumn(strTableName, "ICInventoryStockArrivalDate", "Thời gian hàng về");
            AddGridColumn(strTableName, "ICInventoryStockNeedDate", "Thời gian cần");
            AddGridColumn(strTableName, "ICInventoryStockPurchaseStatus", "Trạng trái");
            base.AddColumnsFromColumnAlias(strTableName, gridView, LstCustomAliasList);
        }

        protected override AAColumnAliasInfo GetColumnAliasInLookupEditCtrl(RepositoryItemBOSLookupEdit lke)
        {
            return LstCustomAliasList.Where(o => o.AAColumnAliasName == lke.ColumnName).FirstOrDefault();
        }

        private void AddGridColumn(string strTableName, string strColumnName, string strCaption, string referenceTable = "", string displayedMember = "", string valueMember = "")
        {

            LstCustomAliasList.Add(new AAColumnAliasInfo
            {
                AAColumnAliasCaption = strCaption,
                AATableName = strTableName,
                AAColumnAliasName = strColumnName,
                AAReferenceTable = referenceTable,
                AADisplayedMember = displayedMember,
                GELookupTableValueColumn = valueMember,
                AAAllowDummy = true
            });
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.RowStyle += new RowStyleEventHandler(gridView_RowStyle);
            GridColumn column = gridView.Columns["ICInventoryStockQuantity"];
            if (column != null)
            {
                FormatNumbericColumn(column, false, "n4");
            }
            column = gridView.Columns["ICInventoryStockSaleOrderQuantity"];
            if (column != null)
            {
                FormatNumbericColumn(column, false, "n4");
            }
            column = gridView.Columns["ICInventoryStockPurchaseOrderQuantity"];
            if (column != null)
            {
                FormatNumbericColumn(column, false, "n4");
            }
            column = gridView.Columns["ICInventoryStockCanUserQuantity"];
            if (column != null)
            {
                FormatNumbericColumn(column, false, "n4");
            }
            column = gridView.Columns["ICInventoryStockTransitInQuantity"];
            if (column != null)
            {
                FormatNumbericColumn(column, false, "n4");
            }
            column = gridView.Columns["ICInventoryStockTransitOutQuantity"];
            if (column != null)
            {
                FormatNumbericColumn(column, false, "n4");
            }
            column = gridView.Columns["ICInventoryStocAllocationPlanQuantity"];
            if (column != null)
            {
                FormatNumbericColumn(column, false, "n4");
            }
            column = gridView.Columns["ICInventoryStockMinQuantity"];
            if (column != null)
            {
                FormatNumbericColumn(column, false, "n4");
            }
            column = gridView.Columns["ICInventoryStockMaxQuantity"];
            if (column != null)
            {
                FormatNumbericColumn(column, false, "n4");
            }
            column = gridView.Columns["ICInventoryStockProposalQuantity"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "n4");
            }
            column = gridView.Columns["ICDepartmentName"];
            if (column != null)
            {
                column.Group();
            }
            column = gridView.Columns["ICProductGroupName"];
            if (column != null)
            {
                column.Group();
            }
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            return gridView;
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        private void gridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            GridView gridView = (GridView)MainView;
            if (e.RowHandle >= 0)
            {
                ICInventoryStocksInfo objInventoryStocksInfo = (ICInventoryStocksInfo)gridView.GetRow(e.RowHandle);
                if (objInventoryStocksInfo != null)
                {
                    if (objInventoryStocksInfo.ICInventoryStockPurchaseStatus == InventoryStockPurchaseStatus.Late.ToString())
                    {
                        e.Appearance.BackColor2 = Color.DarkSalmon;
                        e.Appearance.BackColor = Color.DarkSalmon;
                    }
                    else if (objInventoryStocksInfo.ICInventoryStockPurchaseStatus == InventoryStockPurchaseStatus.OnTime.ToString())
                    {
                        e.Appearance.BackColor2 = Color.LightGreen;
                        e.Appearance.BackColor = Color.LightGreen;
                    }
                }
            }
        }
    }
}
