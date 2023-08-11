using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public partial class ICProductCustomerGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductCustomerList;
            this.DataSource = bds;
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            ICProductCustomersInfo item = (ICProductCustomersInfo)gridView.GetFocusedRow();
            if (item != null)
            {
                if (e.Column.FieldName == "FK_ARCustomerID")
                {
                    ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                    ARCustomersController objCustomersController = new ARCustomersController();
                    List<ICProductCustomersInfo> exit = entity.ProductCustomerList.Where(t => t.FK_ARCustomerID == item.FK_ARCustomerID).ToList();
                    if (exit != null && exit.Count > 1)
                    {
                        BOSApp.ShowMessage("Đã tồn tại khách hàng này trong danh sách!");
                        item.FK_ARCustomerID = 0;
                        item.ARCustomerNo = string.Empty;
                    }
                    ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(item.FK_ARCustomerID);
                    if (objCustomersInfo != null)
                        item.ARCustomerNo = objCustomersInfo.ARCustomerNo;
                    if (gridView.IsNewItemRow(e.RowHandle))
                    {
                        ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
                        item.ICProductCustomerProductionComment = objProductsInfo.ICProductProductionComment;
                    }
                }
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
            }
            GridColumn column = gridView.Columns["ARCustomerNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            
            if (gridView.Columns["ICProductCustomerPackagingInfoVietnam"] != null)
            {
                RepositoryItemMemoEdit repositoryItemMemoEdit = new RepositoryItemMemoEdit();
                repositoryItemMemoEdit.AutoHeight = true;
                repositoryItemMemoEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                repositoryItemMemoEdit.WordWrap = true;
                gridView.GridControl.RepositoryItems.Add(repositoryItemMemoEdit);
                gridView.OptionsView.RowAutoHeight = true;
                gridView.Columns["ICProductCustomerPackagingInfoVietnam"].ColumnEdit = repositoryItemMemoEdit;
            }

            if (gridView.Columns["ICProductCustomerLogoPrintingInstructions"] != null)
            {
                RepositoryItemMemoEdit repositoryItemMemoEdit = new RepositoryItemMemoEdit();
                repositoryItemMemoEdit.AutoHeight = true;
                repositoryItemMemoEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                repositoryItemMemoEdit.WordWrap = true;
                gridView.GridControl.RepositoryItems.Add(repositoryItemMemoEdit);
                gridView.OptionsView.RowAutoHeight = true;
                gridView.Columns["ICProductCustomerLogoPrintingInstructions"].ColumnEdit = repositoryItemMemoEdit;
            }

            gridView.OptionsView.RowAutoHeight = true;
            return gridView;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Thông tin đóng gói";
            column.FieldName = "ICProductCustomerPackagingDetail";
            RepositoryItemMemoEdit repositoryItemMemoEdit = new RepositoryItemMemoEdit();
            repositoryItemMemoEdit.NullText = string.Empty;
            repositoryItemMemoEdit.AutoHeight = true;
            repositoryItemMemoEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            repositoryItemMemoEdit.WordWrap = true;
            column.ColumnEdit = repositoryItemMemoEdit;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ghi chú sản xuất";
            column.FieldName = "ICProductCustomerProductionComment";
            repositoryItemMemoEdit = new RepositoryItemMemoEdit();
            repositoryItemMemoEdit.NullText = string.Empty;
            repositoryItemMemoEdit.AutoHeight = true;
            repositoryItemMemoEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            repositoryItemMemoEdit.WordWrap = true;
            column.ColumnEdit = repositoryItemMemoEdit;
            gridView.Columns.Add(column);
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((ProductModule)Screen.Module).RemoveProductCustomerList();
                }
            }
        }
    }
}
