using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using BOSComponent;
using System.Data;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using BOSCommon;
using System.Collections.Generic;
using System.Linq;
using BOSERP.MES.Modules.MM.ProductionNorm.Localization;
using BOSERP.MES.Modules.ProductionNorm.UI;
using System;

namespace BOSERP.MES.Modules.ProductionNorm
{
    public partial class MMProductionNormItemWoodPrintGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<MMProductionNormItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn columns in gridView.Columns)
            {
                columns.OptionsColumn.AllowEdit = false;
            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(int.Parse(e.Value.ToString()));
                    if (objProductsInfo != null)
                    {
                        e.DisplayText = objProductsInfo.ICProductDesc;
                    }
                }
            }
            if (e.Column.FieldName == "FK_ICProductAlternativeID")
            {
                if (e.Value != null)
                {
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(int.Parse(e.Value.ToString()));
                    if (objProductsInfo != null)
                    {
                        e.DisplayText = objProductsInfo.ICProductDesc;
                    }
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
    }
}
