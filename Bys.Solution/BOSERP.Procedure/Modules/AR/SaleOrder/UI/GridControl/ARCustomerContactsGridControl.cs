using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace BOSERP.Modules.SaleOrder
{
    public partial class ARCustomerContactsGridControl : BOSGridControl
    {
        public List<ARCustomerContactsInfo> CustomerContactsList;

        public void InvalidateGridControlDataSource(List<ARCustomerContactsInfo> customerContactsList)
        {
            CustomerContactsList = customerContactsList;
            BindingSource bds = new BindingSource();
            bds.DataSource = CustomerContactsList;
            this.DataSource = bds;
            this.RefreshDataSource();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Lưu";
            column.FieldName = "SavePackage";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit rpItemSave = new RepositoryItemHyperLinkEdit();
            rpItemSave.NullText = "Lưu";
            rpItemSave.Click += new EventHandler(RpItemAdd_Click);
            column.ColumnEdit = rpItemSave;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Xóa";
            column.FieldName = "Delete";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit rpItemDelete = new RepositoryItemHyperLinkEdit();
            rpItemDelete.NullText = "Xóa";
            rpItemDelete.Click += new EventHandler(RpItemDelete_Click);
            column.ColumnEdit = rpItemDelete;
            gridView.Columns.Add(column);
        }

        private void RpItemAdd_Click(object sender, EventArgs e)
        {
            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARSaleOrdersInfo mainObject = entity.MainObject as ARSaleOrdersInfo;
            GridView gridView = this.MainView as GridView;
            ARCustomerContactsInfo item = (ARCustomerContactsInfo)gridView.GetFocusedRow();
            ARCustomerContactsController objCustomerContactsController = new ARCustomerContactsController();
            if (item != null && item.ARCustomerContactID > 0)
            {
                objCustomerContactsController.UpdateObject(item);
            }
            else if (item != null && item.ARCustomerContactID == 0)
            {
                item.FK_ARCustomerID = mainObject.FK_ARCustomerID;
                objCustomerContactsController.CreateObject(item);
            }
            BOSApp.ShowMessage("Lưu thành công");
        }
        private void RpItemDelete_Click(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ARCustomerContactsInfo obj = (ARCustomerContactsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null &&  obj.ARCustomerContactID > 0)
                {
                    ARCustomerContactsController objCustomerContactsController = new ARCustomerContactsController();
                    objCustomerContactsController.DeleteObject(obj.ARCustomerContactID);
                    CustomerContactsList.Remove(obj);
                    gridView.RefreshData();
                }
            }
            BOSApp.ShowMessage("Xóa thành công");
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                //((SaleOrderModule)Screen.Module).RemoveSelkectedItemFromCustomerContactList();
            }
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            gridView.ExpandAllGroups();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
              column.OptionsColumn.AllowEdit = true;
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            GridColumn newColumn = new GridColumn();
            newColumn.Caption = BaseLocalizedResources.Select;
            newColumn.FieldName = "Selected";
            newColumn.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(0, newColumn);
            newColumn.VisibleIndex = 0;
            gridView.ExpandAllGroups();
            return gridView;
        }
    }
}
