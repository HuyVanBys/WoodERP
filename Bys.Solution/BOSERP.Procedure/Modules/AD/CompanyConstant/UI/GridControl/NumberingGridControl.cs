using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.CompanyConstant
{
    public partial class NumberingGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.GENumberingList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            //gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
                if (col.FieldName == "GENumberingDesc")
                {
                    col.OptionsColumn.AllowEdit = false;
                    col.VisibleIndex = 0;
                }
                else if (col.FieldName == "GENumberingPrefix")
                {
                    col.VisibleIndex = 1;
                }
                else if (col.FieldName == "GENumberingPrefixHaveYear")
                {
                    col.VisibleIndex = 2;
                }
                else if (col.FieldName == "GENumberingPrefixHaveMonth")
                {
                    col.VisibleIndex = 3;
                }
                else if (col.FieldName == "GENumberingPrefixHaveDay")
                {
                    col.VisibleIndex = 4;
                }
                else if (col.FieldName == "GENumberingPrefixHaveStock")
                {
                    col.VisibleIndex = 5;
                }
                else if (col.FieldName == "GENumberingPrefixHaveBankAbbreviation")
                {
                    col.VisibleIndex = 6;
                }
                else if (col.FieldName == "GENumberingStart")
                {
                    col.VisibleIndex = 7;
                }
                else if (col.FieldName == "GENumberingLength")
                {
                    col.VisibleIndex = 8;
                }
                else if (col.FieldName == "GENumberingFormat")
                {
                    col.VisibleIndex = 9;
                }
            }
            return gridView;
        }
    }
}
