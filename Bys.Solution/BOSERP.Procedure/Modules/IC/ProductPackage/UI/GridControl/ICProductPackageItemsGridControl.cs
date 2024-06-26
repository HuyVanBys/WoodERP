using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductPackage
{
    public class ICProductPackageItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            ProductPackageEntities entity = (ProductPackageEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductPackageItemList;
            this.DataSource = bds;
        }


        public void InvalidateDataSource(List<ICProductPackageItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            this.DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = false;
            }
            if (gridView.Columns["ICProductPackageItemQty"] != null)
            {
                SetFormat("ICProductPackageItemQty", "n2", gridView);
            }
            if (gridView.Columns["ICProductPackageItemLength"] != null)
            {
                SetFormat("ICProductPackageItemLength", "n2", gridView);
            }
            if (gridView.Columns["ICProductPackageItemWidth"] != null)
            {
                SetFormat("ICProductPackageItemWidth", "n2", gridView);
            }
            if (gridView.Columns["ICProductPackageItemHeight"] != null)
            {
                SetFormat("ICProductPackageItemHeight", "n2", gridView);
            }
            return gridView;
        }

        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                //((ProductPackageModule)Screen.Module).DeleteItemProductPackageItemsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            //if (e.Column.FieldName == "ICProductPackageItemName")
            //    ((ProductPackageModule)Screen.Module).SetDefaultProductPackageItemList();
        }

        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            //  ((ProductPackageModule)Screen.Module).AddProductPackageItemDetails();
        }
    }
}
