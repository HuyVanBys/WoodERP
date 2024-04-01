using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System;
using BOSLib;
using Localization;

namespace BOSERP.Modules.CarcassBOM
{
    public class MMProductionNormItemsGridControl : BOSGridControl
    {
        MMAllocationOperationConfigsInfo DefualtAOConfigs { get; set; }
        public override void InitGridControlDataSource()
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.GeneralMaterialList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            foreach (GridColumn col in gridView.Columns)
            {
                //if (col.FieldName != "MMProductionNormItemNo"
                //    && col.FieldName != "MMProductionNormItemProductName"
                //    && col.FieldName != "MMProductionNormItemProductSizeAndPacking"
                //    && col.FieldName != "MMProductionNormItemProductDesc"
                //    && col.FieldName != "MMProductionNormItemUnit"
                //    )
                //{
                col.OptionsColumn.AllowEdit = true;
                //}
            }
            GridColumn column = gridView.Columns["FK_ICMeasureUnitID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;

                //RepositoryItemBOSLookupEdit repMeasureUnitLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repMeasureUnitLookUpEdit.DisplayMember = "ICMeasureUnitName";
                //repMeasureUnitLookUpEdit.ValueMember = "ICMeasureUnitID";
                //repMeasureUnitLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repMeasureUnitLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repMeasureUnitLookUpEdit.NullText = string.Empty;
                //repMeasureUnitLookUpEdit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));

                //repMeasureUnitLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repMeasureUnitLookUpEdit_QueryPopUp);
                //column.ColumnEdit = repMeasureUnitLookUpEdit;
                //gridView.Columns.Add(column);
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
                column.MinWidth = 150;
            }

            column = gridView.Columns["FK_MMOperationID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                DefualtAOConfigs = (new MMAllocationOperationConfigsController().GetDefualtAllocationOperationConfigs());
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "MMOperationName";
                repositoryItemLookUpEdit.ValueMember = "MMOperationID";
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationNo", "Mã", 150));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationName", "Tên công đoạn", 150));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(reqOperation_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            column = gridView.Columns["MMProductionNormItemProductDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = this.Columns["MMProductionNormItemQuantity"];
            if (column != null)
            {
                column.Caption = "Số lượng bao gồm tiêu hao";
                FormatNumbericColumn(column, true, "N4");
            }
            column = this.Columns["MMProductionNormItemTotalQuantity"];
            if (column != null)
            {
                column.Caption = "Số lượng";
                FormatNumbericColumn(column, true, "N4");
            }
            column = this.Columns["MMProductionNormItemDepreciationRate"];
            if (column != null)
            {
                column.Caption = "Tỉ lệ tiêu hao";
                FormatNumbericColumn(column, true, "N2");
            }
            column = this.Columns["MMHardwareOperationType"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(BOSComponent.RepositoryItem.RepositoryItemTextEdit.ToString());
            }
            gridView.KeyDown += new KeyEventHandler(GridView_KeyDown);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }
        private void GridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                MMProductionNormsInfo mainObject = (MMProductionNormsInfo)entity.MainObject;
                if (mainObject.MMProductionNormGeneralMaterialStatus != Status.Approved.ToString())
                    ((CarcassBOMModule)Screen.Module).RemoveSelectedItemFromGeneralMaterialList();
            }
        }
        public void reqOperation_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (BOSApp.LookupTables.Contains(TableName.MMOperationsTableName))
            {
                MMOperationsController control = new MMOperationsController();
                DataSet ds = (DataSet)BOSApp.LookupTables[TableName.MMOperationsTableName];
                if (ds != null && ds.Tables.Count > 0)
                {
                    List<MMOperationsInfo> operationList = (List<MMOperationsInfo>)control.GetListFromDataSet(ds);
                    if (operationList != null) operationList = operationList.Where(o =>
                        (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsPlan.ToString() && o.MMOperationIsPlan)
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsStock.ToString() && o.MMOperationInOutStockCheck)
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsPlanAndStock.ToString() && o.MMOperationInOutStockCheck && o.MMOperationIsPlan)
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsPlanOrStock.ToString() && (o.MMOperationInOutStockCheck || o.MMOperationIsPlan))
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.AllOperation.ToString())
                        || (DefualtAOConfigs == null)
                        ).ToList();
                    lookUpEdit.Properties.DataSource = operationList;
                }
            }
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView view = (GridView)MainView;

            MMProductionNormItemsInfo item = (MMProductionNormItemsInfo)view.GetFocusedRow();
            if (item != null)
            {
                if (e.Column.FieldName == "FK_ICProductID")
                {
                    ICProductsController pCtrl = new ICProductsController();
                    ICProductsInfo pInfo = (ICProductsInfo)pCtrl.GetObjectByID(item.FK_ICProductID);
                    if (pInfo != null)
                    {
                        item.MMProductionNormItemNo = pInfo.ICProductNo;
                        item.MMProductionNormItemProductName = pInfo.ICProductName;
                        item.MMProductionNormItemProductDesc = pInfo.ICProductDesc;
                        item.FK_ICMeasureUnitID = pInfo.FK_ICProductBasicUnitID;
                        item.MMProductionNormItemProductSizeAndPacking = pInfo.ICProductSizeAndSpecifiCations;
                    }
                }
                if (e.Column.FieldName == "MMProductionNormItemDepreciationRate" || e.Column.FieldName == "MMProductionNormItemTotalQuantity")
                {
                    item.MMProductionNormItemQuantity = item.MMProductionNormItemTotalQuantity * item.MMProductionNormItemDepreciationRate;
                }
                else if (e.Column.FieldName == "MMProductionNormItemQuantity")
                {
                    item.MMProductionNormItemTotalQuantity = item.MMProductionNormItemQuantity / (item.MMProductionNormItemDepreciationRate == 0 ? 1 : item.MMProductionNormItemDepreciationRate);
                }
                else if (e.Column.FieldName == "MMHardwareOperationType")
                {
                    try
                    {
                        string mathString = item.MMHardwareOperationType.Trim().Replace(" ", string.Empty).Replace("=", string.Empty);
                        DataTable dt = new DataTable();
                        item.MMProductionNormItemQuantity = Convert.ToDecimal(dt.Compute(mathString, String.Empty));
                        item.MMProductionNormItemTotalQuantity = item.MMProductionNormItemQuantity / (item.MMProductionNormItemDepreciationRate == 0 ? 1 : item.MMProductionNormItemDepreciationRate);
                    }
                    catch
                    {
                        MessageBox.Show("Công thức tính số lượng không đúng định dạng." + Environment.NewLine + "Vui lòng kiểm tra lại!"
                                        , CommonLocalizedResources.MessageBoxDefaultCaption
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Error);

                    }
                }
            }

        }

        private void semiProductItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            lookUpEdit.Properties.DataSource = ((CarcassBOMModule)Screen.Module).GetSemiProductDataSource();
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
            else if (e.Column.FieldName == "FK_MMOperationID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMOperations", "MMOperationID", int.Parse(e.Value.ToString()), "MMOperationName");
                }
            }
            else if (e.Value != null && e.Column.FieldName == "MMProductionNormItemOtherColor")
            {
                e.DisplayText = GetColorDisplayText(e.Value.ToString());
            }
            else if (e.Value != null && (e.Column.FieldName == "MMProductionNormItemPaintAKey" ||
                e.Column.FieldName == "MMProductionNormItemPaintBKey" ||
                e.Column.FieldName == "MMProductionNormItemVeneerKey"))
            {
                e.DisplayText = GetProductColorDisplayText(e.Value.ToString());
            }
            else if (e.Value != null && (e.Column.FieldName == "MMProductionNormItemCode01Combo" ||
                e.Column.FieldName == "MMProductionNormItemCode02Combo" ||
                e.Column.FieldName == "MMProductionNormItemCode03Combo"))
            {
                e.DisplayText = GetPaintProcessDisplayText(e.Value.ToString());
            }
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
        //public void repMeasureUnitLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    DataSet ds = (DataSet)BOSApp.LookupTables[TableName.ICMeasureUnitsTableName];
        //    if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
        //    {
        //        ds = BOSApp.GetLookupTableData(TableName.ICMeasureUnitsTableName);
        //        GELookupTablesInfo lookupTable = BOSApp.LookupTableList.Where(t => t.GELookupTableName == TableName.ICMeasureUnitsTableName).FirstOrDefault();

        //        if (lookupTable != null)
        //        {
        //            LookupTables.Add(TableName.ICMeasureUnitsTableName, ds);
        //            LookupTablesUpdatedDate.Add(TableName.ICMeasureUnitsTableName, DateTime.Now);
        //            LookupTableObjects.Add(TableName.ICMeasureUnitsTableName, lookupTable);
        //        }
        //    }
        //    lookUpEdit.Properties.DataSource = ds.Tables[0];
        //    lookUpEdit.Properties.DisplayMember = "ICMeasureUnitName";
        //    lookUpEdit.Properties.ValueMember = "ICMeasureUnitID";
        //}
        //public void repOperationLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    DataSet ds = (DataSet)BOSApp.LookupTables["MMOperations"];
        //    if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
        //    {
        //        ds = BOSApp.GetLookupTableData("MMOperations");
        //        GELookupTablesInfo lookupTable = BOSApp.LookupTableList.Where(t => t.GELookupTableName == "MMOperations").FirstOrDefault();

        //        if (lookupTable != null)
        //        {
        //            LookupTables.Add("MMOperations", ds);
        //            LookupTablesUpdatedDate.Add("MMOperations", DateTime.Now);
        //            LookupTableObjects.Add("MMOperations", lookupTable);
        //        }
        //    }
        //    lookUpEdit.Properties.DataSource = ds.Tables[0];
        //    lookUpEdit.Properties.DisplayMember = "MMOperationName";
        //    lookUpEdit.Properties.ValueMember = "MMOperationID";
        //}
    }
}
