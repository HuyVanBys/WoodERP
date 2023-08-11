using BOSComponent;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.NormTemplate
{
    public partial class NormTemplateItemsGridControl : BOSGridControl
    {
        /// <summary>
        /// Invalidate data source
        /// </summary>
        /// <param name="dataSource">Data source</param>
        public override void InitGridControlDataSource()
        {
            NormTemplateEntities entity = (NormTemplateEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.NormTemplateItemList;
            this.DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            foreach (DevExpress.XtraGrid.Columns.GridColumn columns in gridView.Columns)
            {
                columns.OptionsColumn.AllowEdit = true;
            }
            ((NormTemplateModule)Screen.Module).GeneralSourceData(gridView);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.CellValueChanging += new CellValueChangedEventHandler(gridView_CellValueChanging);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.CellValueChanged += new CellValueChangedEventHandler(gridView_CellValueChanged);
            return gridView;
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "MMNormTemplateItemProductHeight" || e.Column.FieldName == "MMNormTemplateItemProductSpeciality")
                {
                    if (e.CellValue != null && (e.CellValue.ToString()).Trim() != string.Empty)
                    {
                        if (e.RowHandle >= 0)
                        {
                            MMNormTemplateItemsInfo objNormTemplateItemsInfo = (MMNormTemplateItemsInfo)gridView.GetRow(e.RowHandle);
                            if (objNormTemplateItemsInfo.IsError && e.Column.FieldName == "MMNormTemplateItemProductSpeciality")
                            {
                                e.Appearance.BackColor = Color.Red;
                                e.Appearance.BackColor2 = Color.Red;
                            }
                            if (objNormTemplateItemsInfo.IsHeightError && e.Column.FieldName == "MMNormTemplateItemProductHeight")
                            {
                                e.Appearance.BackColor = Color.Red;
                                e.Appearance.BackColor2 = Color.Red;
                            }
                        }
                    }
                }
            }
        }
        void gridView_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                if (e.Column.FieldName == "MMNormTemplateItemProductHeight" || e.Column.FieldName == "MMNormTemplateItemProductSpeciality")
                {
                    MMNormTemplateItemsInfo objNormTemplateItemsInfo = (MMNormTemplateItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (objNormTemplateItemsInfo != null) { objNormTemplateItemsInfo.IsError = false; objNormTemplateItemsInfo.IsHeightError = false; }
                }
            }
        }
        void gridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                if (e.Column.FieldName == "MMNormTemplateItemProductHeight" || e.Column.FieldName == "MMNormTemplateItemProductSpeciality")
                {
                    MMNormTemplateItemsInfo objNormTemplateItemsInfo = (MMNormTemplateItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (objNormTemplateItemsInfo != null)
                    {
                        objNormTemplateItemsInfo.IsError = false;
                        objNormTemplateItemsInfo.IsHeightError = false;
                        ((NormTemplateModule)Screen.Module).CheckTemplateInfo(objNormTemplateItemsInfo, e.Column.FieldName);
                    }


                }
            }
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)sender;
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((NormTemplateModule)Screen.Module).DeleteItemFromList();
                }
            }
        }


    }
}
