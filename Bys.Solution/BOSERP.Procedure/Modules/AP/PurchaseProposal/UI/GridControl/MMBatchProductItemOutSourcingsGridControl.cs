using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseProposal
{
    public partial class MMBatchProductItemOutSourcingsGridControl : BOSGridControl
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
            }
            OperationDataSource = (List<MMOperationsInfo>)objOperationsController.GetListFromDataSet(ds);
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = BaseLocalizedResources.SaleOrderName;
            column.FieldName = "MMBatchProductSOName";
            gridView.Columns.Add(column);
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["MMBatchProductItemOutSourcingOperation"];
            if (column != null)
            {
                RepositoryItemCheckedComboBoxEdit operationRepositoryItem = new RepositoryItemCheckedComboBoxEdit();
                operationRepositoryItem.DisplayMember = "MMOperationName";
                operationRepositoryItem.ValueMember = "MMOperationID";
                operationRepositoryItem.NullText = string.Empty;
                operationRepositoryItem.DataSource = OperationDataSource;
                column.ColumnEdit = operationRepositoryItem;
            }
            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.Group();
            }
            column = gridView.Columns["MMBatchProductItemOutSourcingGroup"];
            if (column != null)
            {
                column.Group();
            }
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
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

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }
    }
}
