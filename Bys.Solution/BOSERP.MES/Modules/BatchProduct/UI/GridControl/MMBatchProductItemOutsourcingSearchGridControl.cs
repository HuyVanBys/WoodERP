using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct
{
    public partial class MMBatchProductItemOutsourcingSearchGridControl : BOSGridControl
    {
        private List<MMOperationsInfo> OperationDataSource = new List<MMOperationsInfo>();

        public void InvalidateDataSource(List<MMBatchProductItemOutSourcingsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
            MMOperationsController objOperationsController = new MMOperationsController();
            DataSet ds = BOSApp.LookupTables[TableName.MMOperationsTableName] as DataSet;
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData(TableName.MMOperationsTableName);
                if (BOSApp.LookupTables.ContainsKey(TableName.MMOperationsTableName))
                    BOSApp.LookupTables[TableName.MMOperationsTableName] = ds;
                BOSApp.LookupTables.Add(TableName.MMOperationsTableName, ds);
            }
            if (ds != null)
                OperationDataSource = (List<MMOperationsInfo>)objOperationsController.GetListFromDataSet(ds);
            else
                OperationDataSource = new List<MMOperationsInfo>();
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "SL tồn kho";
            column.FieldName = "ICInventoryStockQty";
            column.OptionsColumn.AllowEdit = false;
            FormatNumbericColumn(column, false, "n3");
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên sp tiếng việt";
            column.FieldName = "ICProductName2";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã HT cũ";
            column.FieldName = "ICProductNoOfOldSys";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["MMBatchProductItemOutSourcingNeedDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["MMBatchProductItemOutSourcingProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["MMBatchProductItemOutSourcingResourceType"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["MMBatchProductItemOutSourcingOperation"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemCheckedComboBoxEdit operationRepositoryItem = new RepositoryItemCheckedComboBoxEdit();
                operationRepositoryItem.DisplayMember = "MMOperationName";
                operationRepositoryItem.ValueMember = "MMOperationID";
                operationRepositoryItem.NullText = string.Empty;
                operationRepositoryItem.DataSource = OperationDataSource;
                operationRepositoryItem.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpOperationName_QueryPopUp);
                column.ColumnEdit = operationRepositoryItem;
            }
            column = gridView.Columns["MMBatchProductItemOutSourcingGroup"];
            if (column != null)
            {
                column.Group();
            }
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            return gridView;
        }
        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", Int32.Parse(e.Value.ToString()), "ICProductNo");
                }
            }
            if (e.Column.FieldName == "MMBatchProductItemOutSourcingOperation")
            {
                if (e.Value != null)
                {
                    e.DisplayText = GetOperationDisplayText(e.Value.ToString());
                }
            }
        }

        private string GetOperationDisplayText(string operationRef)
        {
            if (string.IsNullOrWhiteSpace(operationRef))
                return string.Empty;

            List<int> operation = operationRef.Split(',').Select(o => Int32.Parse(o)).ToList();
            return string.Join(", ", OperationDataSource.Where(o => operation.Contains(o.MMOperationID)).Select(o => o.MMOperationName).ToArray());
        }

        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            MMBatchProductItemOutSourcingsInfo item = (MMBatchProductItemOutSourcingsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;

            BOSDbUtil dbUtil = new BOSDbUtil();
            if (e.Column.FieldName == "MMBatchProductItemOutSourcingProductQty"
                || e.Column.FieldName == "MBatchProductItemOutSourcingResourceType"
                || e.Column.FieldName == "MMBatchProductItemOutSourcingOperation")
            {
                if (((BatchProductModule)Screen.Module).IsValidOutSourcingQty(item, e.Column.FieldName, true))
                    return;

                dbUtil.SetPropertyValue(item, e.Column.FieldName, gridView.ActiveEditor.OldEditValue);
                gridView.ActiveEditor.EditValue = gridView.ActiveEditor.OldEditValue;
                gridView.RefreshData();
            }
        }

        private void rpOperationName_QueryPopUp(object sender, CancelEventArgs e)
        {
            CheckedComboBoxEdit lke = (CheckedComboBoxEdit)sender;
            if (lke == null)
                return;

            GridView gridView = (GridView)MainView;
            MMBatchProductItemOutSourcingsInfo item = (MMBatchProductItemOutSourcingsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                item = new MMBatchProductItemOutSourcingsInfo();

            lke.Properties.DataSource = ((BatchProductModule)Screen.Module).GetOperationDataSourceOfSemiProduct(item.MMBatchProductItemOutSourcingGroup, item.FK_MMBatchProductItemID, item.FK_MMBatchProductProductionNormItemID, item.MMBatchProductItemOutSourcingResourceType);
            lke.Properties.DisplayMember = "MMOperationName";
            lke.Properties.ValueMember = "MMOperationID";
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        private void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle < 0)
                return;

            MMBatchProductItemOutSourcingsInfo item = (MMBatchProductItemOutSourcingsInfo)gridView.GetRow(e.RowHandle);
            if (item == null)
                return;

            if (e.Column.FieldName == "ICInventoryStockQty")
            {
                e.Appearance.BackColor = Color.LightGoldenrodYellow;
                e.Appearance.BackColor2 = Color.LightGoldenrodYellow;
            }
        }
    }
}
