using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Data;
using System.Windows.Forms;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using DevExpress.XtraGrid;
using DevExpress.Data;
using BOSCommon;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using System.Globalization;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;


namespace BOSERP.Modules.ProductionNorm
{
    public partial class SemiProductProfileManagementHistoryGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SemiProductProfileManagementHistoryList;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.GroupFormat = "[#image]{1} {2}";
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = false;
               
                //if (column.FieldName == ProductionNormConst.GEHistoryDetailTableName)
                //{
                //    column.Group();
                //    column.GroupIndex = 0;
                //    column.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                //}
                if (column.FieldName == "MMProfileManagementItemUpdateDate")
                    column.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            }
            gridView.CustomUnboundColumnData += gridView1_CustomUnboundColumnData;
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView1_CustomColumnDisplayText);
            return gridView;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column;

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormConst.MMProductionNormOrderNoCaption;
            column.FieldName = ProductionNormConst.MMProfileManagementItemOrderNo;
            column.OptionsColumn.AllowEdit = false;
            column.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            column.UnboundExpression = gridView.RowCount.ToString();
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormLocalizeResources.HREmployeeNameCaption;
            column.FieldName = ProductionNormConst.HREmployeeName;
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormLocalizeResources.GEObjectHistoryActionCaption;
            column.FieldName = ProductionNormConst.GEObjectHistoryAction;
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormLocalizeResources.GEHistoryDetailTableNameCaption;
            column.FieldName = ProductionNormConst.GEHistoryDetailTableName;
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormLocalizeResources.MMProfileManagementItemNoCaption;
            column.FieldName = ProductionNormConst.MMProfileManagementItemNo;
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormLocalizeResources.MMProfileManagementItemNameCaption;
            column.FieldName = ProductionNormConst.MMProfileManagementItemName;
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormLocalizeResources.MMProfileManagementItemDescCaption;
            column.FieldName = ProductionNormConst.MMProfileManagementItemDesc;
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormLocalizeResources.MMProfileManagementItemOldValueCaption;
            column.FieldName = ProductionNormConst.MMProfileManagementItemOldValue;
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormLocalizeResources.MMProfileManagementItemNewValueCaption;
            column.FieldName = ProductionNormConst.MMProfileManagementItemNewValue;
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormLocalizeResources.MMProfileManagementItemUpdateDateCaption;
            column.FieldName = "MMProfileManagementItemUpdateDate";
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Loai DM";
            column.FieldName = "GEObjectHistoryObjectName";
            column.OptionsColumn.AllowEdit = false;

            gridView.Columns.Add(column);
        }
     
        public void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = e.ListSourceRowIndex + 1;
        }

        private void gridView1_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (e.Column.FieldName == ProductionNormConst.GEObjectHistoryAction)
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() != string.Empty)
                    {
                        if (e.Value.Equals(ProductionNormLocalizeResources.Change))
                            e.DisplayText = ProductionNormLocalizeResources.ChangeDispalyText;
                        if (e.Value.Equals(ProductionNormLocalizeResources.New))
                            e.DisplayText = ProductionNormLocalizeResources.NewDispalyText;
                        if (e.Value.Equals(ProductionNormLocalizeResources.Delete))
                            e.DisplayText = ProductionNormLocalizeResources.DeleteDispalyText;
                    }
                }
            }

            if (e.Column.FieldName == ProductionNormConst.GEHistoryDetailTableName)
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() != string.Empty)
                    {
                        if (e.Value.Equals("B"+ProductType.SemiProduct.ToString()))
                            e.DisplayText = ProductionNormLocalizeResources.MMProductionNormItemsTableNameDisplayText;
                        else if (e.Value.Equals("C"+ProductType.Hardware.ToString()))
                            e.DisplayText = ProductionNormLocalizeResources.MMHardwareItemsTableNameDisplayText;
                        else if (e.Value.Equals("D"+ProductType.IngredientPackaging.ToString()))
                            e.DisplayText = ProductionNormLocalizeResources.MMPackagingItemsTableNameDisplayText;
                        else if (e.Value.Equals("E"+ProductType.IngredientPaint.ToString()))
                            e.DisplayText = ProductionNormLocalizeResources.MMPaintItemsTableNameDisplayText;
                        else if (e.Value.Equals("A"+ProductType.Product.ToString()))
                            e.DisplayText = ProductionNormLocalizeResources.GeneralDisplayText;
                    }
                }
            }

            if (e.Column.FieldName == ProductionNormConst.MMProfileManagementItemDesc)
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() != string.Empty)
                    {
                        if (e.Value.ToString().ToLower().Equals(ProductionNormLocalizeResources.GEHistoryDetailColumnNameCaption.ToLower())
                            || e.Value.ToString().ToLower().Equals(ProductionNormLocalizeResources.MMHardwareItemNoCaption.ToLower())
                            || e.Value.ToString().ToLower().Equals(ProductionNormLocalizeResources.MMPackagingItemNoCaption.ToLower())
                            || e.Value.ToString().ToLower().Equals(ProductionNormLocalizeResources.MMPaintItemNoCaption.ToLower()))
                        {
                            e.DisplayText = string.Empty;
                        }
                    }
                }
            }
            if (e.Column.FieldName == ProductionNormConst.MMProfileManagementItemNo)
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() != string.Empty)
                    {
                        GEObjectHistoryInfo objObjectHistoryInfo = new GEObjectHistoryInfo();
                        MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
                        objObjectHistoryInfo = entity.ProfileManagementHistoryList[e.ListSourceRowIndex];
                        if (objObjectHistoryInfo.GEHistoryDetailTableName == TableName.MMProductionNormsTableName)
                            e.DisplayText = objProductionNormsInfo.MMProductionNormNo;
                    }
                }
            }

            if (e.Column.FieldName == ProductionNormConst.MMProfileManagementItemName)
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() != string.Empty)
                    {
                        GEObjectHistoryInfo objObjectHistoryInfo = new GEObjectHistoryInfo();
                        MMProductionNormsInfo objProductionNormsInfo = (MMProductionNormsInfo)entity.MainObject;
                        objObjectHistoryInfo = entity.ProfileManagementHistoryList[e.ListSourceRowIndex];
                        if (objObjectHistoryInfo.GEHistoryDetailTableName == TableName.MMProductionNormsTableName)
                            e.DisplayText = objProductionNormsInfo.MMProductionNormName;
                    }
                }
            }
            if (e.Column.FieldName == ProductionNormConst.MMProfileManagementItemOldValue || e.Column.FieldName == ProductionNormConst.MMProfileManagementItemNewValue)
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() != string.Empty)
                    {


                        if (entity.ProfileManagementHistoryList != null)
                        {
                            GEObjectHistoryInfo objObjectHistoryInfo = new GEObjectHistoryInfo();
                            objObjectHistoryInfo = entity.ProfileManagementHistoryList[e.ListSourceRowIndex];
                            if (objObjectHistoryInfo != null)
                            {
                                if (objObjectHistoryInfo.MMProfileManagementItemDesc.ToString().ToLower().Equals(ProductionNormLocalizeResources.GEHistoryDetailColumnNameCaption.ToLower())
                                    || objObjectHistoryInfo.MMProfileManagementItemDesc.ToString().ToLower().Equals(ProductionNormLocalizeResources.MMHardwareItemNoCaption.ToLower())
                                    || objObjectHistoryInfo.MMProfileManagementItemDesc.ToString().ToLower().Equals(ProductionNormLocalizeResources.MMPackagingItemNoCaption.ToLower())
                                    || objObjectHistoryInfo.MMProfileManagementItemDesc.ToString().ToLower().Equals(ProductionNormLocalizeResources.MMPaintItemNoCaption.ToLower()))
                                {
                                    e.DisplayText = string.Empty;
                                }
                            }
                        }

                    }
                }
            }
        }
    }
}
