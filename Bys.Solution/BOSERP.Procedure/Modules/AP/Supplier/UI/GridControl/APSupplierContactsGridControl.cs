using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Supplier
{
    public partial class APSupplierContactsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SupplierEntities entity = (SupplierEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SupplierContactsList;
            DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SupplierModule)Screen.Module).RemoveSelectedItemFromSupplierContactList();
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["APSupplierContactDealCheck"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APSupplierContactPODefaultCheck"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            SupplierEntities entity = (SupplierEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (((SupplierModule)Screen.Module).Toolbar.IsNullOrNoneAction())
            {
                MessageBox.Show("Vui lòng nhấn nút Sửa!",
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (entity.SupplierContactsList.Count() > 0)
            {
                GridView gridView = (GridView)MainView;
                APSupplierContactsInfo item = entity.SupplierContactsList[entity.SupplierContactsList.CurrentIndex];
                if (e.Column.FieldName == "APSupplierContactPODefaultCheck")
                {
                    if (item.APSupplierContactPODefaultCheck == true)
                    {
                        entity.SupplierContactsList.ForEach(a =>
                        {
                            a.APSupplierContactPODefaultCheck = false;
                        });
                        item.APSupplierContactPODefaultCheck = true;
                    }
                    else
                    {
                        item.APSupplierContactPODefaultCheck = false;
                    }
                }
                if (e.Column.FieldName == "APSupplierContactDealCheck")
                {
                    if (item.APSupplierContactDealCheck == true)
                    {
                        entity.SupplierContactsList.ForEach(a =>
                        {
                            a.APSupplierContactDealCheck = false;
                        });
                        item.APSupplierContactDealCheck = true;
                    }
                    else
                    {
                        item.APSupplierContactDealCheck = false;
                    }
                }
                entity.SupplierContactsList.GridControl.RefreshDataSource();
            }
        }
    }
}
