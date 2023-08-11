using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Home
{
    public class APPaymentProposalsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PaymentProposalsList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new GridColumn();
            column.Caption = "Duyệt";
            column.FieldName = "GEPaymentProposalApprove";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
            rpItemComponent.NullText = "Duyệt";
            rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
            column.ColumnEdit = rpItemComponent;
            gridView.Columns.Add(column);
        }

        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                GEPaymentProposalsInfo objPaymentProposalsInfo = (GEPaymentProposalsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objPaymentProposalsInfo == null)
                    return;
                ((HomeModule)Screen.Module).ChangeStatus(objPaymentProposalsInfo);
            }
        }
        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            entity.PaymentProposalsList.SetEndCurrentEdit();
            return;
        }
    }
}
