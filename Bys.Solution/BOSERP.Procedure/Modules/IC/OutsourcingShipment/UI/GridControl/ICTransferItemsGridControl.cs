using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.OutsourcingShipment
{
    public class ICTransferItemsGridControl : ItemGridControl
    {
        public void InvalidateDataSource(BOSList<ICTransferItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            GridColumn column = new GridColumn();
            column.Caption = BaseLocalizedResources.Select;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(0, column);
            column.VisibleIndex = 0;
            gridView.ExpandAllGroups();

            column = gridView.Columns["FK_ICTransferID"];
            if (column != null)
            {
                column.Group();
            }
            return gridView;
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            gridView.ExpandAllGroups();
        }
        //private void ReposChoosePackage_Click(object sender, EventArgs e)
        //{
        //    ((TransferModule)Screen.Module).ShowTransferItemPackage();
        //}

        //protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        //{
        //    base.GridView_KeyUp(sender, e);

        //    if (e.KeyCode == Keys.Delete)
        //    {
        //        ((TransferModule)Screen.Module).DeleteItemFromTransferItemsList();
        //    }
        //}

        //protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        //{
        //    base.AddColumnsToGridView(strTableName, gridView);
        //    GridColumn column;
        //    column = new GridColumn();
        //    column.Caption = TransferLocalizedResources.PackageColumn;
        //    column.FieldName = "PackageColumn";
        //    column.OptionsColumn.AllowEdit = true;

        //    RepositoryItemHyperLinkEdit reposChoosePackage = new RepositoryItemHyperLinkEdit();
        //    reposChoosePackage.NullText = TransferLocalizedResources.IdentifyPackage;
        //    reposChoosePackage.Click += new EventHandler(ReposChoosePackage_Click);
        //    column.ColumnEdit = reposChoosePackage;

        //    gridView.Columns.Add(column);
        //}

        //protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    base.GridView_CellValueChanged(sender, e);

        //    GridView gridView = (GridView)sender;
        //    if (gridView.FocusedRowHandle >= 0)
        //    {
        //        TransferEntities entity = (TransferEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
        //        if (e.Column.FieldName == "FK_ICFromStockID" || e.Column.FieldName == "FK_ICToStockID")
        //        {
        //            ICTransferItemsInfo objTransferItemsInfo = (ICTransferItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
        //            ((TransferModule)Screen.Module).ChangeItemStock(objTransferItemsInfo);
        //        }                
        //    }
        //}

        //protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        //{
        //    base.GridView_ValidatingEditor(sender, e);

        //    GridView gridView = (GridView)sender;
        //    if (gridView.FocusedRowHandle >= 0)
        //    {
        //        if (gridView.FocusedColumn.FieldName == "ICTransferItemProductQty")
        //        {
        //            ICTransferItemsInfo item = (ICTransferItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
        //            string errMsg = ((TransferModule)Screen.Module).CheckForValidQty(item, Convert.ToDecimal(e.Value));
        //            if (!string.IsNullOrEmpty(errMsg))
        //            {
        //                e.ErrorText = errMsg;
        //                e.Valid = false;
        //            }
        //        }                
        //    }
        //}
    }
}
