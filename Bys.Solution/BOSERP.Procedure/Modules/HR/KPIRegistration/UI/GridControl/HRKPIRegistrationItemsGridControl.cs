using BOSCommon.Constants;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.KPIRegistration
{
    public class HRKPIRegistrationItemsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            KPIRegistrationEntities entity = (KPIRegistrationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.KPIRegistrationItemsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["HRKPIRegistrationItemWeight"];
            if (column != null)
            {
                //column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
            }

            column = gridView.Columns["HRKPIRegistrationItemWeightBouns"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n0}";
            }

            if (gridView.Columns["HRKPIRegistrationItemMeasurementMethod"] != null)
            {
                RepositoryItemMemoEdit repositoryItemMemoEdit = new RepositoryItemMemoEdit();
                repositoryItemMemoEdit.AutoHeight = true;
                repositoryItemMemoEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                repositoryItemMemoEdit.WordWrap = true;
                gridView.GridControl.RepositoryItems.Add(repositoryItemMemoEdit);
                gridView.OptionsView.RowAutoHeight = true;
                gridView.Columns["HRKPIRegistrationItemMeasurementMethod"].ColumnEdit = repositoryItemMemoEdit;
            }

            column = gridView.Columns["HRKPIRegistrationItemGeneralTarget"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
            }

            column = gridView.Columns["HRKPIRegistrationItemTarget"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["IsReverseTarget"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);

            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((KPIRegistrationModule)Screen.Module).DeleteItemFromKPIRegistItemsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            KPIRegistrationEntities entity = (KPIRegistrationEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.KPIRegistrationItemsList.CurrentIndex >= 0)
            {
                entity.ModuleObjects[TableName.HRKPIRegistrationItemsTableName] = (HRKPIRegistrationItemsInfo)entity.KPIRegistrationItemsList[entity.KPIRegistrationItemsList.CurrentIndex];
                HRKPIRegistrationItemsInfo objKPIRegistrationItemsInfo = (HRKPIRegistrationItemsInfo)entity.KPIRegistrationItemsList[entity.KPIRegistrationItemsList.CurrentIndex];
                if (e.Column.FieldName == "HRKPIRegistrationItemTarget")
                {
                    ((KPIRegistrationModule)entity.Module).ChangeItemWeight(objKPIRegistrationItemsInfo);
                }
            }
        }

        //protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    base.GridView_CellValueChanged(sender, e);

        //    KPIRegistrationEntities entity = (KPIRegistrationEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
        //    if (entity.KPIRegistrationItemsList.CurrentIndex >= 0)
        //    {
        //        entity.ModuleObjects[TableName.HRKPIRegistrationItemsTableName] = (HRKPIRegistrationItemsInfo)entity.KPIRegistrationItemsList[entity.KPIRegistrationItemsList.CurrentIndex];
        //        HRKPIRegistrationItemsInfo objKPIRegistrationItemsInfo = (HRKPIRegistrationItemsInfo)entity.KPIRegistrationItemsList[entity.KPIRegistrationItemsList.CurrentIndex];
        //        if (e.Column.FieldName == "HRKPIRegistrationItemWeight")
        //        {
        //            ((KPIRegistrationModule)entity.Module).ChangeItemWeight(objKPIRegistrationItemsInfo);
        //        }
        //    }
        //}

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "HRKPIRegistrationItemTarget")
            {
                e.Appearance.BackColor2 = Color.Yellow;
                e.Appearance.BackColor = Color.Yellow;
            }
        }
    }
}
