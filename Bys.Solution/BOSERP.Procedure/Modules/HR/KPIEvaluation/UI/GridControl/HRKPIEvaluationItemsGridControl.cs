using BOSCommon.Constants;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.KPIEvaluation
{
    public class HRKPIEvaluateItemsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            KPIEvaluationEntities entity = (KPIEvaluationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.KPIEvaluationItemsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["HRKPIEvaluationItemWeight"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
            }

            column = gridView.Columns["HRKPIEvaluationItemWeightBouns"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n0}";
            }

            column = gridView.Columns["HRKPIEvaluationItemPercentComplete"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
            }

            if (gridView.Columns["HRKPIEvaluationItemResult"] != null)
                gridView.Columns["HRKPIEvaluationItemResult"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["HRKPIEvaluationItemMeasurementMethod"] != null)
            {
                RepositoryItemMemoEdit repositoryItemMemoEdit = new RepositoryItemMemoEdit();
                repositoryItemMemoEdit.AutoHeight = true;
                repositoryItemMemoEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                repositoryItemMemoEdit.WordWrap = true;
                gridView.GridControl.RepositoryItems.Add(repositoryItemMemoEdit);
                gridView.OptionsView.RowAutoHeight = true;
                gridView.Columns["HRKPIEvaluationItemMeasurementMethod"].ColumnEdit = repositoryItemMemoEdit;
            }

            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);

            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((KPIEvaluationModule)Screen.Module).DeleteItemFromKPIEvaluationItemsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            KPIEvaluationEntities entity = (KPIEvaluationEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.KPIEvaluationItemsList.CurrentIndex >= 0)
            {
                entity.ModuleObjects[TableName.HRKPIEvaluationItemsTableName] = (HRKPIEvaluationItemsInfo)entity.KPIEvaluationItemsList[entity.KPIEvaluationItemsList.CurrentIndex];
                //if (e.Column.FieldName == "HRKPIEvaluationItemWeightBouns")
                //{
                //    ((KPIEvaluationModule)entity.Module).ChangeItemWeightBouns();
                //}
                if (e.Column.FieldName == "HRKPIEvaluationItemPercentComplete")
                {
                    ((KPIEvaluationModule)entity.Module).ChangeItemPercentComplete();
                }
                if (e.Column.FieldName == "HRKPIEvaluationItemResult")
                {
                    ((KPIEvaluationModule)entity.Module).ChangeItemResult();
                }
            }
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "HRKPIEvaluationItemResult")
            {
                e.Appearance.BackColor2 = Color.Yellow;
                e.Appearance.BackColor = Color.Yellow;
            }
            if (e.Column.FieldName == "HRKPIEvaluationItemAmount")
            {
                e.Appearance.BackColor2 = Color.Green;
                e.Appearance.BackColor = Color.Green;
            }
        }
    }
}
