using BOSComponent;
using DevExpress.XtraGrid.Columns;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.POS
{
    public partial class CreditNoteGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            POSEntities entity = (POSEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CreditNoteList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = POSLocalizedResources.ARCreditNoteRemainedAmount;
            column.FieldName = "ARCreditNoteRemainedAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
