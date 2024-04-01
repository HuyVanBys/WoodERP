using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public class MMProductionNormItemHavePaintGridControl : BOSGridControl
    {
        DataSet dsFormulas;
        public override void InitGridControlDataSource()
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductionNormItemHavePaintList;
            this.DataSource = bds;

            dsFormulas = ((CarcassBOMModule)entity.Module).GetAllFormulas();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = false;
            }

            GridColumn column = gridView.Columns["MMProductionNormItemProductName"];
            if (column != null)
            {
                column.Caption = "Tên Cụm/ Chi tiết";
            }

            column = gridView.Columns["MMProductionNormItemNo"];
            if (column != null)
            {
                column.Caption = "Mã Cụm/ Chi tiết";
            }
            column = gridView.Columns["FK_MMSemiProductID"];
            if (column != null)
            {
                List<MMProductionNormItemsInfo> semiProductDatasource = ((CarcassBOMModule)Screen.Module).GetSemiProductDataSource();
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "MMProductionNormItemNo";
                repositoryItemLookUpEdit.ValueMember = "MMProductionNormItemID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductCode", "Mã code", 150));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionNormItemNo", "Mã chi tiết", 150));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionNormItemProductName", "Tên chi tiết", 300));
                repositoryItemLookUpEdit.DataSource = semiProductDatasource;
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(semiProductItemLookUpEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.Caption = "Thuộc chi tiết";
            }
            column = gridView.Columns["MMProductionNormItemPaintA"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "n5");
            }
            column = gridView.Columns["MMProductionNormItemPaintB"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "n5");
            }
            column = gridView.Columns["MMProductionNormItemPaintC"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "n5");
            }
            //column = gridView.Columns["MMProductionNormItemOtherColor"];
            //if (column != null)
            //{
            //    RepositoryItemCheckedComboBoxEdit rpOhterColor = new RepositoryItemCheckedComboBoxEdit();
            //    rpOhterColor.DisplayMember = "ICProductAttributeValue";
            //    rpOhterColor.ValueMember = "ICProductAttributeID";
            //    rpOhterColor.NullText = string.Empty;
            //    rpOhterColor.DataSource = GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
            //    column.ColumnEdit = rpOhterColor;
            //}
            //column = gridView.Columns["MMProductionNormItemPaintAKey"];
            //if (column != null)
            //{
            //    RepositoryItemCheckedComboBoxEdit rpOhterColor = new RepositoryItemCheckedComboBoxEdit();
            //    rpOhterColor.DisplayMember = "MMPaintProcessesPaintName";
            //    rpOhterColor.ValueMember = "MMPaintProcessesID";
            //    rpOhterColor.NullText = string.Empty;
            //    column.ColumnEdit = rpOhterColor;
            //}
            //column = gridView.Columns["MMProductionNormItemPaintBKey"];
            //if (column != null)
            //{
            //    RepositoryItemCheckedComboBoxEdit rpOhterColor = new RepositoryItemCheckedComboBoxEdit();
            //    rpOhterColor.DisplayMember = "MMPaintProcessesPaintName";
            //    rpOhterColor.ValueMember = "MMPaintProcessesID";
            //    rpOhterColor.NullText = string.Empty;
            //    column.ColumnEdit = rpOhterColor;
            //}
            //column = gridView.Columns["MMProductionNormItemVeneerKey"];
            //if (column != null)
            //{
            //    RepositoryItemCheckedComboBoxEdit rpOhterColor = new RepositoryItemCheckedComboBoxEdit();
            //    rpOhterColor.DisplayMember = "MMPaintProcessesPaintName";
            //    rpOhterColor.ValueMember = "MMPaintProcessesID";
            //    rpOhterColor.NullText = string.Empty;
            //    column.ColumnEdit = rpOhterColor;
            //}
            column = gridView.Columns["MMProductionNormItemPaintExecuteMethod"];
            if (column != null)
            {
                RepositoryItemCheckedComboBoxEdit rpOhterColor = new RepositoryItemCheckedComboBoxEdit();
                rpOhterColor.DisplayMember = "MMPaintProcessesPaintName";
                rpOhterColor.ValueMember = "MMPaintProcessesID";
                rpOhterColor.NullText = string.Empty;
                column.ColumnEdit = rpOhterColor;
            }
            //gridView.DoubleClick += new EventHandler(gridView_DoubleClick);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }
        private string GetColorDisplayText(string colorRef)
        {
            if (string.IsNullOrWhiteSpace(colorRef))
                return string.Empty;

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
        private string GetProductColorDisplayText(string colorRef)
        {
            if (string.IsNullOrWhiteSpace(colorRef))
                return string.Empty;

            List<int> colorID = colorRef.Split(',').Select(o => Int32.Parse(o)).ToList();
            List<ICProductsForViewInfo> ColorData = BOSApp.CurrentProductList.Where(p => p.ICProductType == ProductType.IngredientPaint.ToString()).ToList();
            if (ColorData.Count > 0)
            {
                return string.Join(", ", ColorData.Where(o => colorID.Contains(o.ICProductID)).Select(o => o.ICProductName).ToArray());
            }
            else return string.Empty;
        }
        private string GetPaintProcessDisplayText(string colorRef)
        {
            if (string.IsNullOrWhiteSpace(colorRef))
                return string.Empty;

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
        public List<ICProductAttributesInfo> GetProductAttributeDatasource(string group)
        {
            List<ICProductAttributesInfo> woodTypeList = new List<ICProductAttributesInfo>();
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            woodTypeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(group);
            return woodTypeList;
        }
        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (e.Column.FieldName == "FK_MMSemiProductID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = ((CarcassBOMModule)Screen.Module).GetSemiProductDisplayDisplayText(int.Parse(e.Value.ToString()));
                }
                else
                    e.DisplayText = string.Empty;
            }
            else if (e.Value != null && e.Column.FieldName == "MMProductionNormItemOtherColor")
            {
                e.DisplayText = GetColorDisplayText(e.Value.ToString());
            }
            else if (e.Value != null && (e.Column.FieldName == "MMProductionNormItemPaintAKey" ||
                e.Column.FieldName == "MMProductionNormItemPaintBKey" ||
                e.Column.FieldName == "MMProductionNormItemVeneerKey" ))
            {
                e.DisplayText = GetProductColorDisplayText(e.Value.ToString());
            }
            else if (e.Value != null && (e.Column.FieldName == "MMProductionNormItemCode01Combo" ||
                e.Column.FieldName == "MMProductionNormItemCode02Combo" ||
                e.Column.FieldName == "MMProductionNormItemCode03Combo" ))
            {
                e.DisplayText = GetPaintProcessDisplayText(e.Value.ToString());
            }
        }

        private void semiProductItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            lookUpEdit.Properties.DataSource = ((CarcassBOMModule)Screen.Module).GetSemiProductDataSource();
        }

        public void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (dsFormulas.Tables.Count > 0)
                lookUpEdit.Properties.DataSource = dsFormulas.Tables[0].DefaultView;
        }

        private void GridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CarcassBOMModule)Screen.Module).RemoveSelectedItemFromGeneralMaterialList();
            }
        }

    }
}
