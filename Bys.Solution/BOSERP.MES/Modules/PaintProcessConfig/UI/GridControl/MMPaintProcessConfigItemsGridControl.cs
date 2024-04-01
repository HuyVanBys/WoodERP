using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PaintProcessConfig
{
    public class MMPaintProcessConfigItemsGridControl : BOSGridControl
    {
        private List<MMFormulasInfo> FormulasList { get; set; }
        public override void InitGridControlDataSource()
        {
            PaintProcessConfigEntities entity = (PaintProcessConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PaintProcessConfigItemsList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            FormulasList = GetFormulasDataSource();
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            foreach (DevExpress.XtraGrid.Columns.GridColumn columns in gridView.Columns)
            {
                columns.OptionsColumn.AllowEdit = true;
            }
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(Gridview_CustomColumnDisplayText);
            return gridView;
        }
        public List<MMFormulasInfo> GetFormulasDataSource()
        {
            MMFormulasController objFormulasController = new MMFormulasController();
            List<MMFormulasInfo> formulasList = new List<MMFormulasInfo>();
            DataSet ds = (DataSet)BOSApp.LookupTables["MMFormulas"];
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData("MMFormulas");
            }
            formulasList = (List<MMFormulasInfo>)objFormulasController.GetListFromDataSet(ds);
            if (!formulasList.Exists(o => o.MMFormulaID == 0))
                formulasList.Insert(0, new MMFormulasInfo());

            return formulasList;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Công thức sơn A";
            column.FieldName = "FK_MMFormulaIDPaintA";
            column.OptionsColumn.AllowEdit = true;
            column.VisibleIndex = 1;
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DisplayMember = FormulaConst.MMFormulaName;
            repositoryItemLookUpEdit.ValueMember = FormulaConst.MMFormulaID;
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(FormulaConst.MMFormulaNo, FormulaConst.MMFormulaNoCaption));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(FormulaConst.MMFormulaName, FormulaConst.MMFormulaNameCaption));
            repositoryItemLookUpEdit.DataSource = FormulasList.Where(o => o.MMFormulaType == "Paint" || o.MMFormulaID == 0).ToList();
            column.ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns.Add(column);
            //column.MinWidth = 150;

            column = new GridColumn();
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "Màu sơn A";
            column.FieldName = "ICProductColorPaintA";
            column.VisibleIndex = 2;
            RepositoryItemButtonEdit colorAEdit = InitColorButtonEdit();
            column.ColumnEdit = colorAEdit;
            gridView.Columns.Add(column);
            //
            column = new GridColumn();
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "QTS A";
            column.FieldName = "ICProductPaintProcessA";
            column.VisibleIndex = 3;
            RepositoryItemButtonEdit ProcessAEdit = InitPaintProcessButtonEdit();
            column.ColumnEdit = ProcessAEdit;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Công thức sơn B";
            column.FieldName = "FK_MMFormulaIDPaintB";
            column.OptionsColumn.AllowEdit = true;
            column.VisibleIndex = 4;
            repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DisplayMember = FormulaConst.MMFormulaName;
            repositoryItemLookUpEdit.ValueMember = FormulaConst.MMFormulaID;
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(FormulaConst.MMFormulaNo, FormulaConst.MMFormulaNoCaption));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(FormulaConst.MMFormulaName, FormulaConst.MMFormulaNameCaption));
            repositoryItemLookUpEdit.DataSource = FormulasList.Where(o => o.MMFormulaType == "Paint" || o.MMFormulaID == 0).ToList();
            column.ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "Màu sơn B";
            column.FieldName = "ICProductColorPaintB";
            column.VisibleIndex = 5;
            RepositoryItemButtonEdit colorBEdit = InitColorButtonEdit();
            column.ColumnEdit = colorBEdit;
            gridView.Columns.Add(column);
            //
            column = new GridColumn();
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "QTS B";
            column.FieldName = "ICProductPaintProcessB";
            column.VisibleIndex = 6;
            RepositoryItemButtonEdit ProcessBEdit = InitPaintProcessButtonEdit();
            column.ColumnEdit = ProcessBEdit;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Công thức sơn C";
            column.FieldName = "FK_MMFormulaIDPaintC";
            column.OptionsColumn.AllowEdit = true;
            column.VisibleIndex = 7;
            repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DisplayMember = FormulaConst.MMFormulaName;
            repositoryItemLookUpEdit.ValueMember = FormulaConst.MMFormulaID;
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(FormulaConst.MMFormulaNo, FormulaConst.MMFormulaNoCaption));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(FormulaConst.MMFormulaName, FormulaConst.MMFormulaNameCaption));
            repositoryItemLookUpEdit.DataSource = FormulasList.Where(o => o.MMFormulaType == "Paint" || o.MMFormulaID == 0).ToList();
            column.ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "Màu sơn C";
            column.FieldName = "ICProductColorPaintC";
            column.VisibleIndex = 8;
            RepositoryItemButtonEdit colorCEdit = InitColorButtonEdit();
            column.ColumnEdit = colorCEdit;
            gridView.Columns.Add(column);
            //
            column = new GridColumn();
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "QTS C";
            column.FieldName = "ICProductPaintProcessC";
            column.VisibleIndex = 9;
            RepositoryItemButtonEdit ProcessCEdit = InitPaintProcessButtonEdit();
            column.ColumnEdit = ProcessCEdit;
            gridView.Columns.Add(column);
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((PaintProcessConfigModule)Screen.Module).DeleteItemFromList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
        }
        private void Gridview_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Column.FieldName == "ICProductColorAttribute")
            {
                e.DisplayText = GetColorDisplayText(e.Value.ToString());
            }
            if (e.Value != null && (e.Column.FieldName == "ICProductColorPaintA"
                || e.Column.FieldName == "ICProductColorPaintB"
                || e.Column.FieldName == "ICProductColorPaintC")
                )
            {
                e.DisplayText = GetProductColorDisplayText(e.Value.ToString());
            }
            if (e.Value != null && (e.Column.FieldName == "ICProductPaintProcessA"
                || e.Column.FieldName == "ICProductPaintProcessB"
                || e.Column.FieldName == "ICProductPaintProcessC")
                )
            {
                e.DisplayText = GetPaintProcessDisplayText(e.Value.ToString());
            }
        }
        private string GetColorDisplayText(string colorRef)
        {
            if (string.IsNullOrWhiteSpace(colorRef))
                return string.Empty;
            try
            {
                List<int> colorID = colorRef.Split(',').Select(o => Int32.Parse(o)).ToList();

                DataSet ds = BOSApp.LookupTables["ICProductAttributes"] as DataSet;
                if (ds == null || ds.Tables.Count == 0)
                    ds = BOSApp.GetLookupTableData("ICProductAttributes");
                if (ds != null && ds.Tables.Count > 0)
                {
                    List<ICProductAttributesInfo> ColorData = (List<ICProductAttributesInfo>)(new ICProductAttributesController()).GetListFromDataSet(ds);
                    return string.Join(", ", ColorData.Where(o => colorID.Contains(o.ICProductAttributeID)).Select(o => o.ICProductAttributeValue).ToArray());
                }
                else return string.Empty;
            }
            catch
            {
                return colorRef;
            }
        }
        private string GetProductColorDisplayText(string colorRef)
        {
            if (string.IsNullOrWhiteSpace(colorRef))
                return string.Empty;
            try
            {
                List<int> colorID = colorRef.Split(',').Select(o => Int32.Parse(o)).ToList();
                List<ICProductsForViewInfo> ColorData = BOSApp.CurrentProductList.Where(p => p.ICProductType == ProductType.IngredientPaint.ToString()).ToList();
                if (ColorData.Count > 0)
                {
                    return string.Join(", ", ColorData.Where(o => colorID.Contains(o.ICProductID)).Select(o => o.ICProductName).ToArray());
                }
                else return string.Empty;
            }
            catch
            {
                return colorRef;
            }
        }
        private string GetPaintProcessDisplayText(string colorRef)
        {
            if (string.IsNullOrWhiteSpace(colorRef))
                return string.Empty;
            try
            {
                List<int> colorID = colorRef.Split(',').Select(o => Int32.Parse(o)).ToList();

                DataSet ds = BOSApp.LookupTables["MMPaintProcessess"] as DataSet;
                if (ds == null || ds.Tables.Count == 0)
                    ds = BOSApp.GetLookupTableData("MMPaintProcessess");
                if (ds != null && ds.Tables.Count > 0)
                {
                    List<MMPaintProcessessInfo> ColorData = (List<MMPaintProcessessInfo>)(new MMPaintProcessessController()).GetListFromDataSet(ds);
                    return string.Join(", ", ColorData.Where(o => colorID.Contains(o.MMPaintProcessesID)).Select(o => o.MMPaintProcessesPaintName).ToArray());
                }
                else return string.Empty;
            }
            catch
            {
                return colorRef;
            }
        }
        public RepositoryItemButtonEdit InitPaintProcessButtonEdit()
        {
            RepositoryItemButtonEdit rep = new RepositoryItemButtonEdit();
            rep.ButtonClick += new ButtonPressedEventHandler(ShowSelectItemData);
            return rep;
        }
        public RepositoryItemButtonEdit InitColorButtonEdit()
        {
            RepositoryItemButtonEdit rep = new RepositoryItemButtonEdit();
            rep.ButtonClick += new ButtonPressedEventHandler(ShowSelectColorItemData);
            return rep;
        }
        private void ShowSelectItemData(object sender, ButtonPressedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            string select = ((PaintProcessConfigModule)Screen.Module).ShowSelectPaintProcessesData();

            MMPaintProcessConfigItemsInfo objProductsInfo = (MMPaintProcessConfigItemsInfo)gridView.GetFocusedRow();
            if (objProductsInfo != null)
            {
                if (gridView.FocusedColumn.FieldName == "ICProductPaintProcessA")
                    objProductsInfo.ICProductPaintProcessA = select;
                if (gridView.FocusedColumn.FieldName == "ICProductPaintProcessB")
                    objProductsInfo.ICProductPaintProcessB = select;
                if (gridView.FocusedColumn.FieldName == "ICProductPaintProcessC")
                    objProductsInfo.ICProductPaintProcessC = select;
            }
            gridView.RefreshData();
        }
        private void ShowSelectColorItemData(object sender, ButtonPressedEventArgs e)
        {
            string select = ((PaintProcessConfigModule)Screen.Module).ShowSelectColorData();
            GridView gridView = (GridView)MainView;

            MMPaintProcessConfigItemsInfo objProductsInfo = (MMPaintProcessConfigItemsInfo)gridView.GetFocusedRow();
            if (objProductsInfo != null)
            {
                if (gridView.FocusedColumn.FieldName == "ICProductColorPaintA")
                    objProductsInfo.ICProductColorPaintA = select;
                if (gridView.FocusedColumn.FieldName == "ICProductColorPaintB")
                    objProductsInfo.ICProductColorPaintB = select;
                if (gridView.FocusedColumn.FieldName == "ICProductColorPaintC")
                    objProductsInfo.ICProductColorPaintC = select;
            }
            gridView.RefreshData();
        }
    }
}
