using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;

namespace BOSERP.Modules.ChangeBOMInformation
{
    public class ErrorGridControl : BOSGridControl
    {


        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column2 in gridView.Columns)
            {
                column2.OptionsColumn.AllowEdit = false;
                column2.Visible = false;
            }

            if (gridView.Columns["MMAllocationPlanItemProductDesc"] != null)
            {
                gridView.Columns["MMAllocationPlanItemProductDesc"].Visible = true;
                gridView.Columns["MMAllocationPlanItemProductDesc"].VisibleIndex = 2;
            }
            if (gridView.Columns["MMAllocationPlanItemProductDesc"] != null)
            {
                gridView.Columns["MMAllocationPlanItemProductDesc"].Group();
            }
            if (gridView.Columns["MMAllocationPlanItemProductName"] != null)
            {
                gridView.Columns["MMAllocationPlanItemProductName"].Visible = true;
                gridView.Columns["MMAllocationPlanItemProductName"].VisibleIndex = 1;

            }
            if (gridView.Columns["MMAllocationPlanNo"] != null)
            {
                gridView.Columns["MMAllocationPlanNo"].Visible = true;
                gridView.Columns["MMAllocationPlanNo"].VisibleIndex = 3;

            }

            if (gridView.Columns["MMAllocationPlanItemQty"] != null)
            {
                gridView.Columns["MMAllocationPlanItemQty"].Visible = true;
                gridView.Columns["MMAllocationPlanItemQty"].Caption = "Số lượng KHSD NPL";
                gridView.Columns["MMAllocationPlanItemQty"].VisibleIndex = 4;

            }
            if (gridView.Columns["MMAllocationPlanItemCanceledQty"] != null)
            {
                gridView.Columns["MMAllocationPlanItemCanceledQty"].Visible = true;
                gridView.Columns["MMAllocationPlanItemCanceledQty"].Caption = "Số lượng hủy KHSD NPL";
                gridView.Columns["MMAllocationPlanItemCanceledQty"].VisibleIndex = 5;

            }

            if (gridView.Columns["MMAllocationProposalNo"] != null)
            {
                gridView.Columns["MMAllocationProposalNo"].Visible = true;
                gridView.Columns["MMAllocationProposalNo"].VisibleIndex = 6;

            }
            if (gridView.Columns["MMAllocationProposalItemQty"] != null)
            {
                gridView.Columns["MMAllocationProposalItemQty"].Visible = true;
                gridView.Columns["MMAllocationProposalItemQty"].VisibleIndex = 7;

            }
            if (gridView.Columns["MMAllocationProposalItemCanceledQty"] != null)
            {
                gridView.Columns["MMAllocationProposalItemCanceledQty"].Visible = true;
                gridView.Columns["MMAllocationProposalItemCanceledQty"].VisibleIndex = 8;

            }
            if (gridView.Columns["MMAllocationProposalItemShippedQty"] != null)
            {
                gridView.Columns["MMAllocationProposalItemShippedQty"].Visible = true;
                gridView.Columns["MMAllocationProposalItemShippedQty"].VisibleIndex = 9;
            }




            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "MMAllocationPlanNo";
            column.Caption = "Mã kế hoạch sử dụng NPL";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMAllocationProposalNo";
            column.Caption = "Mã lệnh cấp phát";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMAllocationProposalItemQty";
            column.Caption = "Số lượng cấp phát";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMAllocationProposalItemCanceledQty";
            column.Caption = "Số lượng cấp phát đã hủy";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMAllocationProposalItemShippedQty";
            column.Caption = "Số lượng đã xuất kho";
            gridView.Columns.Add(column);
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }

        //public void repositoryItemLookUpEditComponent_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
        //    List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
        //    ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
        //    objConfigValuesInfo.ADConfigValueID = 0;
        //    DataSet ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.Priority);
        //    if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
        //    {
        //        ConfigValuesList.Add(objConfigValuesInfo);

        //        foreach (DataRow row in ds.Tables[0].Rows)
        //        {
        //            objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
        //            ConfigValuesList.Add(objConfigValuesInfo);
        //        }
        //    }
        //    if (ConfigValuesList != null)
        //    {
        //        lookUpEdit.Properties.DataSource = ConfigValuesList;
        //    }
        //    lookUpEdit.Properties.DisplayMember = "ADConfigText";
        //    lookUpEdit.Properties.ValueMember = "ADConfigKeyValue";
        //}
        //void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        //{
        //    BatchProductSheduleEntities entity = (BatchProductSheduleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
        //    MMAllocationPlanItemsInfo objAllocationPlanItemsInfo = new MMAllocationPlanItemsInfo();
        //    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
        //    GridView gridView = (GridView)MainView;
        //    if (gridView.FocusedRowHandle >= 0)
        //    {
        //        objAllocationPlanItemsInfo = (MMAllocationPlanItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
        //    }
        //    if (e.Column.FieldName == "MMPriority")
        //    {
        //        if (e.Value != null)
        //        {
        //            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
        //            objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ConfigValueGroup.Priority, e.Value.ToString());
        //            if (objConfigValuesInfo != null)
        //            {
        //                e.DisplayText = objConfigValuesInfo.ADConfigText;
        //            }
        //        }
        //    }
        //    if (e.Column.FieldName == "MMAllocationPlanItemHWQtySource")
        //    {
        //        if (e.Value != null)
        //        {
        //            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
        //            objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(ConfigValueGroup.AllocationPlanItemHWQtySource, e.Value.ToString());
        //            if (objConfigValuesInfo != null)
        //            {
        //                e.DisplayText = objConfigValuesInfo.ADConfigText;
        //            }
        //        }
        //    }
        //}

        //private void GridView_KeyUp(object sender, KeyEventArgs e)
        //{
        //    base.GridView_KeyUp(sender, e);
        //    if (e.KeyCode == Keys.Delete)
        //    {
        //        ((BatchProductSheduleModule)Screen.Module).DeleteItemFromAllocationPlanItemList();
        //    }
        //}

        //private void GridView_DoubleClick(object sender, EventArgs e)
        //{
        //    ShowInventory();
        //}

        ///// <summary>
        ///// Show inventory details of the current item
        ///// </summary>
        //private void ShowInventory()
        //{
        //    GridView gridView = (GridView)MainView;
        //    if (gridView.FocusedRowHandle >= 0)
        //    {
        //        BusinessObject item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
        //        BOSDbUtil dbUtil = new BOSDbUtil();
        //        int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
        //        //((BaseTransactionModule)Screen.Module).ShowInventory(productID, false, false);
        //        string itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
        //        String columnName = String.Empty;
        //        columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductDesc";
        //        string desc = dbUtil.GetPropertyStringValue(item, columnName);
        //        /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
        //        int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
        //        int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
        //        /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
        //        ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
        //    }
        //}
    }
}
