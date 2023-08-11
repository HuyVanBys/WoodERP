using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class ICPackagesGridControl : BOSComponent.BOSGridControl
    {
        /// <summary>
        /// Invalidate data source of the package grid control
        /// </summary>
        /// <param name="packageList">Package list</param>
        public void InvalidatePackageGridControl(List<ICPackagesInfo> packageList)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = packageList;
            DataSource = bds;
            RefreshDataSource();
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            GridView gridView = (GridView)MainView;
            if (e.KeyCode == Keys.Delete)
            {
                gridView.DeleteSelectedRows();
            }
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column;
            column = new GridColumn();
            column.Caption = CommonLocalizedResources.ICPackageProductOnHandQty;
            column.FieldName = "ICPackageProductOnHandQty";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = CommonLocalizedResources.ICPackageProductQty;
            column.FieldName = "ICPackageProductQty";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0 && gridView.FocusedColumn.FieldName == "ICPackageProductQty")
            {
                ICPackagesInfo objPackagesInfo = (ICPackagesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                decimal qty = Convert.ToDecimal(e.Value);
                BOSDbUtil dbUtil = new BOSDbUtil();
                ICInventoryPackagesController objInventoryPackagesController = new ICInventoryPackagesController();
                ICInventoryPackagesInfo objInventoryPackagesInfo = objInventoryPackagesController.GetInventoryPackageByPackageIDAndStockIDAndProductID(
                                                                                                                objPackagesInfo.ICPackageID,
                                                                                                                objPackagesInfo.FK_ICStockID,
                                                                                                                objPackagesInfo.FK_ICProductID);
                if (objInventoryPackagesInfo == null || objInventoryPackagesInfo.ICInventoryPackageQty < qty)
                {
                    e.ErrorText = CommonLocalizedResources.PackageIsNotEnoughQtyMessage;
                    e.Valid = false;
                }
            }
        }
    }
}
