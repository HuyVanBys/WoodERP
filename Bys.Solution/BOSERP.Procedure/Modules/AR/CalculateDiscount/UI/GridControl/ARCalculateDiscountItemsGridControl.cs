using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.CalculateDiscount
{
    public class ARCalculateDiscountItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CalculateDiscountEntities entity = (CalculateDiscountEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CalculateDiscountItemsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column = new GridColumn();
            column.Caption = BaseLocalizedResources.ACObjectName;
            column.FieldName = "ACObjectAccessKey";
            column.OptionsColumn.AllowEdit = false;

            RepositoryItemLookUpEdit itemLookUpEdit = new RepositoryItemLookUpEdit();

            itemLookUpEdit.DisplayMember = "ACObjectName";
            itemLookUpEdit.ValueMember = "ACObjectAccessKey";
            itemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            itemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            itemLookUpEdit.NullText = string.Empty;
            itemLookUpEdit.Columns.AddRange(new LookUpColumnInfo[]
            {
                new LookUpColumnInfo("ACObjectNo", BaseLocalizedResources.ACObjectNo),
                new LookUpColumnInfo("ACObjectName", BaseLocalizedResources.ACObjectName),
                new LookUpColumnInfo("ACObjectContactPhone", BaseLocalizedResources.ACObjectContactPhone),
                new LookUpColumnInfo("ACObjectContactAddress", BaseLocalizedResources.ACObjectContactAddress)
            });
            itemLookUpEdit.DataSource = BOSApp.AccountingObjects;
            itemLookUpEdit.NullText = string.Empty;
            column.ColumnEdit = itemLookUpEdit;
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = "Duyệt";
            //column.FieldName = "ARApproved";
            //column.OptionsColumn.AllowEdit = true;

            //RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
            //rpItemComponent.NullText = "Duyệt";
            //rpItemComponent.Click += new EventHandler(rpItemApproved_Click);
            //column.ColumnEdit = rpItemComponent;
            //gridView.Columns.Add(column);
        }

        private void rpItemApproved_Click(object sender, EventArgs e)
        {
            //((SaleOrderModule)Screen.Module).CopyItemToNewRow();
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {

            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CalculateDiscountModule)Screen.Module).DeleteCalculateDiscountItem();
            }
        }
    }
}
