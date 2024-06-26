using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.EndingAllocationDeclaration
{
    public class ACEndingAllocationDeclarationItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            EndingAllocationDeclarationEntities entity = (EndingAllocationDeclarationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ACEndingAllocationDeclarationItemsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.GroupFormat = "[#image]{1} {2}";
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;

            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Column.FieldName == "FK_ACAccountID")
            {
                int id = 0;
                if (int.TryParse(e.Value.ToString(), out id))
                {
                    ACAccountsController accountController = new ACAccountsController();
                    ACAccountsInfo account = (ACAccountsInfo)accountController.GetObjectByID(id);
                    if (account != null)
                    {
                        e.DisplayText = account.ACAccountNo;
                    }
                    else
                    {
                        e.DisplayText = string.Empty;
                    }
                }
            }
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView != null)
            {
                gridView.ExpandAllGroups();
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((EndingAllocationDeclarationModule)Screen.Module).DeleteItemFromACEndingAllocationDeclarationItemsList();
            }
        }
    }
}
