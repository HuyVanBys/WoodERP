using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.EndingAllocation
{
    public class ACEndingAllocationItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            EndingAllocationEntities entity = (EndingAllocationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ACEndingAllocationItemsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.GroupFormat = "[#image]";
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = false;

            }

            GridColumn columnGroup = gridView.Columns["ACEndingAllocationItemGroupOrder"];
            if (columnGroup != null)
            {
                columnGroup.Group();
            }

            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.RowHandle >= 0)
            {
                ACEndingAllocationItemsInfo item = (ACEndingAllocationItemsInfo)gridView.GetRow(e.RowHandle);
                if (item != null)
                {
                    if (item.ACEndingAllocationItemType == "Allocation")
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    }
                }
            }

        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null)
            {
                decimal value = 0;
                if (decimal.TryParse(e.Value.ToString(), out value))
                {
                    if (value == 0)
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
                ((EndingAllocationModule)Screen.Module).DeleteItemFromACEndingAllocationItemsList();
            }
        }



    }
}
