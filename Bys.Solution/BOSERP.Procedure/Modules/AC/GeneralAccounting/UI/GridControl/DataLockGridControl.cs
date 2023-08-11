using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.GeneralAccounting
{
    public partial class DataLockGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.LockList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = " ";
            column.FieldName = "EditLockCommand";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit rep = new RepositoryItemHyperLinkEdit();
            rep.NullText = GeneralAccountingLocalizedResources.EditDataLock;
            rep.Click += new EventHandler(EditDataLock_Click);
            column.ColumnEdit = rep;
            gridView.Columns.Add(column);
        }

        private void EditDataLock_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ADLocksInfo lockInfo = (ADLocksInfo)gridView.GetRow(gridView.FocusedRowHandle);
                ((GeneralAccountingModule)Screen.Module).EditDataLock(lockInfo);
            }
        }
    }
}
