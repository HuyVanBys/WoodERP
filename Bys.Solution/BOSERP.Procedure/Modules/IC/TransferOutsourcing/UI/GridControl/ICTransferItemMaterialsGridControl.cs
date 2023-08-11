using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferOutsourcing
{
    public class ICTransferItemMaterialsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            TransferOutsourcingEntities entity = (TransferOutsourcingEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MaterialTransferItemList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = new GridColumn();
            column = gridView.Columns["ICTransferItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICTransferItemProductName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICTransferItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICFromStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICToStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICTransferItemProductPakagingQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        private void ReposChoosePackage_Click(object sender, EventArgs e)
        {
            ((TransferOutsourcingModule)Screen.Module).ShowTransferItemPackage();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((TransferOutsourcingModule)Screen.Module).DeleteItemFromMaterialTransferItemsList();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column;
            column = new GridColumn();
            column.Caption = TransferLocalizedResources.PackageColumn;
            column.FieldName = "PackageColumn";
            column.OptionsColumn.AllowEdit = true;

            RepositoryItemHyperLinkEdit reposChoosePackage = new RepositoryItemHyperLinkEdit();
            reposChoosePackage.NullText = TransferLocalizedResources.IdentifyPackage;
            reposChoosePackage.Click += new EventHandler(ReposChoosePackage_Click);
            column.ColumnEdit = reposChoosePackage;

            gridView.Columns.Add(column);
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                TransferOutsourcingEntities entity = (TransferOutsourcingEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
                if (e.Column.FieldName == "FK_ICFromStockID" || e.Column.FieldName == "FK_ICToStockID")
                {
                    ICTransferItemsInfo objTransferItemsInfo = (ICTransferItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    ((TransferOutsourcingModule)Screen.Module).ChangeItemStock(objTransferItemsInfo);
                }
            }
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                if (gridView.FocusedColumn.FieldName == "ICTransferItemProductQty")
                {
                    ICTransferItemsInfo item = (ICTransferItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    string errMsg = ((TransferOutsourcingModule)Screen.Module).CheckForValidQty(item, Convert.ToDecimal(e.Value));
                    if (!string.IsNullOrEmpty(errMsg))
                    {
                        e.ErrorText = errMsg;
                        e.Valid = false;
                    }
                }
            }
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = new ICProductsInfo();
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(value);
                        if (objProductsInfo != null)
                            e.DisplayText = objProductsInfo.ICProductNo;
                    }
                    else
                        e.DisplayText = string.Empty;
                }
            }
        }
    }
}
