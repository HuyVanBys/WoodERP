using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.KPIForm
{
    public class HRKPIFormItemsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            KPIFormEntities entity = (KPIFormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.KPIFormItemsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["HRKPIFormItemWeight"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
            }

            //column = gridView.Columns["HRKPIFormItemTarget"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            //    column.DisplayFormat.FormatString = "{0:n2}";
            //}

            if (gridView.Columns["HRKPIFormItemMeasurementMethod"] != null)
            {
                RepositoryItemMemoEdit repositoryItemMemoEdit = new RepositoryItemMemoEdit();
                repositoryItemMemoEdit.AutoHeight = true;
                repositoryItemMemoEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                repositoryItemMemoEdit.WordWrap = true;
                gridView.GridControl.RepositoryItems.Add(repositoryItemMemoEdit);
                gridView.OptionsView.RowAutoHeight = true;
                gridView.Columns["HRKPIFormItemMeasurementMethod"].ColumnEdit = repositoryItemMemoEdit;
            }

            column = gridView.Columns["IsReverseTarget"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((KPIFormModule)Screen.Module).DeleteItemFromKPIFormItemsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            if (e.Column.FieldName == "HRKPIFormItemWeight")
            {
                ((KPIFormModule)Screen.Module).ChangeItemWeight();
            }
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "HRKPIFormItemWeight")
            {
                e.Appearance.BackColor2 = Color.Yellow;
                e.Appearance.BackColor = Color.Yellow;
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_HRKPIID")
            {
                if (e.Value != null)
                {
                    int kpiID = int.Parse(e.Value.ToString());
                    HRKPIsController objKPIsController = new HRKPIsController();
                    HRKPIsInfo objKPIsInfo = (HRKPIsInfo)objKPIsController.GetObjectByID(kpiID);
                    if (objKPIsInfo != null)
                    {
                        e.DisplayText = objKPIsInfo.HRKPINo;
                    }
                }
            }
        }
    }
}
