using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Localization;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using BOSComponent;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using BOSCommon;
using BOSLib;
using System.Linq;

namespace BOSERP.Modules.ProductionNorm
{
    public class MMProductionNormItemCarcassGridControl : BOSGridControl
    {

        public override void InitGridControlDataSource()
        {
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.GeneralMaterialCarcassList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn col in gridView.Columns)
            {
                if (col.FieldName != "MMProductionNormItemNo"
                    && col.FieldName != "MMProductionNormItemProductName"
                    && col.FieldName != "MMProductionNormItemProductSizeAndPacking"
                    && col.FieldName != "MMProductionNormItemProductDesc"
                    && col.FieldName != "MMProductionNormItemUnit"
                    )
                {
                    col.OptionsColumn.AllowEdit = false;
                }
            }
            GridColumn column = gridView.Columns["FK_ICMeasureUnitID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;

                RepositoryItemBOSLookupEdit repMeasureUnitLookUpEdit = new RepositoryItemBOSLookupEdit();
                repMeasureUnitLookUpEdit.DisplayMember = "ICMeasureUnitName";
                repMeasureUnitLookUpEdit.ValueMember = "ICMeasureUnitID";
                repMeasureUnitLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repMeasureUnitLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repMeasureUnitLookUpEdit.NullText = string.Empty;
                repMeasureUnitLookUpEdit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));

                repMeasureUnitLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repMeasureUnitLookUpEdit_QueryPopUp);
                column.ColumnEdit = repMeasureUnitLookUpEdit;
                gridView.Columns.Add(column);
            }

            column = gridView.Columns["FK_MMOperationID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;

                RepositoryItemLookUpEdit repOperationLookUpEdit = new RepositoryItemLookUpEdit();
                repOperationLookUpEdit.DisplayMember = "MMOperationName";
                repOperationLookUpEdit.ValueMember = "MMOperationID";
                repOperationLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repOperationLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repOperationLookUpEdit.NullText = string.Empty;
                repOperationLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationName", "Công đoạn"));

                repOperationLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repOperationLookUpEdit_QueryPopUp);
                column.ColumnEdit = repOperationLookUpEdit;
                gridView.Columns.Add(column);
            }
            gridView.KeyDown += new KeyEventHandler(GridView_KeyDown);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }
        private void GridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductionNormModule)Screen.Module).RemoveSelectedItemFromGeneralMaterialList();
            }
        }
        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche(TableName.ICMeasureUnitsTableName, "ICMeasureUnitID", int.Parse(e.Value.ToString()), "ICMeasureUnitName");
                }
            }

            if (e.Column.FieldName == "FK_MMOperationID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMOperations", "MMOperationID", int.Parse(e.Value.ToString()), "MMOperationName");
                }
            }
        }
        public void repMeasureUnitLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            DataSet ds = (DataSet)BOSApp.LookupTables[TableName.ICMeasureUnitsTableName];
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                ds = BOSApp.GetLookupTableData(TableName.ICMeasureUnitsTableName);
                GELookupTablesInfo lookupTable = BOSApp.LookupTableList.Where(t => t.GELookupTableName == TableName.ICMeasureUnitsTableName).FirstOrDefault();

                if (lookupTable != null)
                {
                    LookupTables.Add(TableName.ICMeasureUnitsTableName, ds);
                    LookupTablesUpdatedDate.Add(TableName.ICMeasureUnitsTableName, ((ProductionNormModule)Screen.Module).GetServerDate());
                    LookupTableObjects.Add(TableName.ICMeasureUnitsTableName, lookupTable);
                }
            }
            lookUpEdit.Properties.DataSource = ds.Tables[0];
            lookUpEdit.Properties.DisplayMember = "ICMeasureUnitName";
            lookUpEdit.Properties.ValueMember = "ICMeasureUnitID";
        }
        public void repOperationLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            DataSet ds = (DataSet)BOSApp.LookupTables["MMOperations"];
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                ds = BOSApp.GetLookupTableData("MMOperations");
                GELookupTablesInfo lookupTable = BOSApp.LookupTableList.Where(t => t.GELookupTableName == "MMOperations").FirstOrDefault();

                if (lookupTable != null)
                {
                    LookupTables.Add("MMOperations", ds);
                    LookupTablesUpdatedDate.Add("MMOperations", ((ProductionNormModule)Screen.Module).GetServerDate());
                    LookupTableObjects.Add("MMOperations", lookupTable);
                }
            }
            lookUpEdit.Properties.DataSource = ds.Tables[0];
            lookUpEdit.Properties.DisplayMember = "MMOperationName";
            lookUpEdit.Properties.ValueMember = "MMOperationID";
        }
    }
}
