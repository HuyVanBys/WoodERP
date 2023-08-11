using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Microsoft.Office.Interop.Excel;
using BOSComponent;
using DevExpress.XtraEditors.Repository;
using Localization;
using DevExpress.XtraGrid.Views.Base;

namespace BOSERP.MES.Modules.ProductionNorm
{
    public partial class ARSaleOrderItemGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<ARSaleOrderItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            gridView.ExpandAllGroups();
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        ICProductsInfo objProductsInfo = new ICProductsInfo();
                        ICProductsController objProductsController = new ICProductsController();
                        objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(value);
                        if (objProductsInfo != null)
                        {
                            e.DisplayText = objProductsInfo.ICProductNo;
                        }
                    }
                }
            }
        }
    }
}
