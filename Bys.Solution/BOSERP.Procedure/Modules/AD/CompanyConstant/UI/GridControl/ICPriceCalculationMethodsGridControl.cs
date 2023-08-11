using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace BOSERP.Modules.CompanyConstant
{
    public partial class ICPriceCalculationMethodsGridControl : BOSGridControl
    {
        GridColumn ColumnIsDefault { get; set; }

        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICPriceCalculationMethodsList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.MouseDown += new MouseEventHandler(GridControl_MouseDown);
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
            }
            GridColumn gridColumn = gridView.Columns["ICPriceCalculationMethodIsDefault"];
            if (gridColumn != null)
            {
                ColumnIsDefault = gridColumn;
            }
            return gridView;
        }

        protected virtual void GridControl_MouseDown(object sender, MouseEventArgs e)
        {
            GridView gridView = (GridView)sender;
            hitInfo = gridView.CalcHitInfo(new Point(e.X, e.Y));
            if (hitInfo.RowHandle < 0 || hitInfo.Column == null || !hitInfo.InRowCell)
            {
                hitInfo = null;
                return;
            }

            if (hitInfo.Column == ColumnIsDefault)
            {
                CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                entity.ICPriceCalculationMethodsList.ForEach(o =>
                {
                    o.ICPriceCalculationMethodIsDefault = false;
                });
                entity.ICPriceCalculationMethodsList.GridControl.RefreshDataSource();
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((CompanyConstantModule)Screen.Module).RemovePriceCalculationMethod();
                }
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;

            if (e.Column.FieldName == "ICPriceCalculationMethodIsDefault")
            {
                ICPriceCalculationMethodsInfo objPriceCalculationMethodsInfo = (ICPriceCalculationMethodsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                entity.ICPriceCalculationMethodsList.ForEach(o =>
                {
                    o.ICPriceCalculationMethodIsDefault = false;
                });
                try
                {
                    entity.ICPriceCalculationMethodsList[gridView.FocusedRowHandle].ICPriceCalculationMethodIsDefault = Convert.ToBoolean(gridView.ActiveEditor.EditValue.ToString());
                }
                catch (Exception) { }
                entity.ICPriceCalculationMethodsList.GridControl.RefreshDataSource();
            }
        }
    }
}
