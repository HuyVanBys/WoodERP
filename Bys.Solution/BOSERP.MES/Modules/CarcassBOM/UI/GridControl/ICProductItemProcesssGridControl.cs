using BOSCommon;
using BOSComponent;
using BOSERP.Modules.CarcassBOM.UI;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class ICProductItemProcesssGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PIProcessList;
            this.DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((CarcassBOMModule)Screen.Module).DeleteItemFromProductItemProcesssList();
            }
        }
        List<MMOperationsInfo> LstOperation;
        protected override GridView InitializeGridView()
        {
            GridView gridview = base.InitializeGridView();
            GridColumn col = gridview.Columns["ICProductItemProcessPeriod"];
            if (col != null)
            {
                col.OptionsColumn.AllowEdit = true;
            }

            col = gridview.Columns["ICProductItemProcessCapacity"];
            if (col != null)
            {
                col.OptionsColumn.AllowEdit = true;
            }
            col = gridview.Columns["FK_MMOperationID"];
            if (col != null)
            {
                col.OptionsColumn.AllowEdit = true;
            }
            col = gridview.Columns["ICProductItemProcessInOutStockCheck"];
            if (col != null)
            {
                col.OptionsColumn.AllowEdit = true;
            }

            col = gridview.Columns["ICProductItemProcessIsBeginOperation"];
            if (col != null)
            {
                col.OptionsColumn.AllowEdit = true;
            }
            col = gridview.Columns["ICProductItemProcessIsPlan"];
            if (col != null)
            {
                col.OptionsColumn.AllowEdit = true;
            }
            col = gridview.Columns["ICProductItemProcessSyncProductCheck"];
            if (col != null)
            {
                col.OptionsColumn.AllowEdit = true;
            }
            col = gridview.Columns["ICProductItemProcessForParentSyncCheck"];
            if (col != null)
            {
                col.OptionsColumn.AllowEdit = true;
            }
            col = gridview.Columns["ICProductItemProcessIsOutSourcing"];
            if (col != null)
            {
                col.OptionsColumn.AllowEdit = true;
            }
            col = gridview.Columns["ICProductItemProcessIsEndProcess"];
            if (col != null)
            {
                col.OptionsColumn.AllowEdit = true;
            }
            MMOperationsController operationCtrl = new MMOperationsController();
            LstOperation = operationCtrl.GetWithDefaultMachineGroup();
            col = gridview.Columns["FK_MMOperationSynID"];
            if (col != null)
            {
                col.OptionsColumn.AllowEdit = true;
                RepositoryItemBOSLookupEdit repoLookUpEdit = new RepositoryItemBOSLookupEdit();
                repoLookUpEdit.DisplayMember = "MMOperationName";
                repoLookUpEdit.ValueMember = "MMOperationID";
                repoLookUpEdit.NullText = string.Empty;
                repoLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationNo", "Mã"));
                repoLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationName", "Tên"));
                //repoLookUpEdit.DataSource = LstOperation;
                repoLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repoOperationSyn_QueryPopUp);
                col.ColumnEdit = repoLookUpEdit;
            }
            gridview.CustomColumnDisplayText += Gridview_CustomColumnDisplayText;
            gridview.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            return gridview;
        }

        private void Gridview_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Column.FieldName == "FK_MMOperationSynID")
            {
                int id = 0;
                int.TryParse(e.Value.ToString(), out id);
                e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMOperations", "MMOperationID", id, "MMOperationName");
            }
        }

        void repoOperationSyn_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            GridView gridView = this.MainView as GridView;
            if (gridView != null)
            {
                ICProductItemProcesssInfo obj = (ICProductItemProcesssInfo)gridView.GetFocusedRow();
                if (obj != null && obj.ICProductItemProcessSyncProductCheck)
                    lookUpEdit.Properties.DataSource = ResetDataColumn(gridView, obj.ICProductItemProcessPeriod);
                else lookUpEdit.Properties.DataSource = new List<MMOperationsInfo>();
            }
        }
        public List<MMOperationsInfo> ResetDataColumn(GridView gridView, int period)
        {
            List<MMOperationsInfo> dataList = new List<MMOperationsInfo>();
            if (gridView != null)
            {
                CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                GridColumn column = gridView.Columns["FK_MMOperationSynID"];
                if (column != null)
                {
                    List<int> planOperation = new List<int>();
                    for (int j = 0; j < gridView.RowCount; j++)
                    {
                        ICProductItemProcesssInfo obj = (ICProductItemProcesssInfo)gridView.GetRow(j);
                        if (obj != null)
                        {
                            if (!planOperation.Exists(o => o == obj.FK_MMOperationID) && (obj.ICProductItemProcessIsPlan || obj.ICProductItemProcessInOutStockCheck) && obj.ICProductItemProcessPeriod < period)
                                planOperation.Add(obj.FK_MMOperationID);
                        }
                    }
                    if (planOperation != null && planOperation.Count > 0)
                    {
                        foreach (var ID in planOperation)
                        {
                            MMOperationsInfo obj = LstOperation.Where(o => o.MMOperationID == ID).FirstOrDefault();
                            if (obj != null)
                                dataList.Add(obj);
                        }
                    }
                }
            }
            if (dataList.Count() >= 0)
                dataList.Insert(0, new MMOperationsInfo());
            return dataList;
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            GridView gridView = (GridView)sender;
            if (entity.PIProcessList.CurrentIndex >= 0)
            {
                ICProductItemProcesssInfo item = entity.PIProcessList[entity.PIProcessList.CurrentIndex];
                if (e.Column.FieldName == "FK_MMOperationID")
                {
                    MMProductionComplexityByOperationsController objProductionComplexityByOperationsController = new MMProductionComplexityByOperationsController();
                    int maxIndex = 0;
                    if (entity.PIProcessList != null
                        && entity.PIProcessList.Count > 0)
                    {
                        maxIndex = entity.PIProcessList.Select(t => t.ICProductItemProcessPeriod).Max();
                    }
                    item.ICProductItemProcessPeriod = ++maxIndex;
                    item.FK_ICProductID = ((guiProcess)Screen).ProductID;
                    item.FK_ICProductCarcassID = ((guiProcess)Screen).ParentProductID;
                    MMOperationsInfo operation = LstOperation.FirstOrDefault(t => t.MMOperationID == item.FK_MMOperationID);
                    if (operation != null)
                    {
                        item.ICMachineGroup = operation.MMMachineGroupValue;
                        item.ICProductItemProcessCapacity = operation.MMOperationCapacity;
                        item.ICProductItemProcessInOutStockCheck = operation.MMOperationInOutStockCheck;
                        item.ICProductItemProcessIsBeginOperation = operation.MMOperationIsBeginOperation;
                        item.ICProductItemProcessIsPlan = operation.MMOperationIsPlan;
                        item.ICProductItemProcessSyncProductCheck = operation.MMOperationSyncProductCheck;
                        item.ICProductItemProcessForParentSyncCheck = operation.MMOperationForParentSyncCheck;
                        item.FK_MMOperationSynID = operation.FK_MMOperationSynID;
                        item.ICProductItemProcessOperationNo = operation.MMOperationNo;
                        item.ICProductItemProcessUnitTime = objProductionComplexityByOperationsController.GetUnitTimeByOperationAndProductionComplexityType(item.FK_MMOperationID,
                                                            entity.ProductList.Where(o => o.ICProductID == item.FK_ICProductID).Select(o => o.ICConfigProductionComplexityType).FirstOrDefault());
                    }
                }
                else if (e.Column.FieldName == "ICProductItemProcessSyncProductCheck")
                {
                    bool value = false;
                    if (e.Value != null)
                        bool.TryParse(e.Value.ToString(), out value);
                    if (value && item != null && !(item.ICProductItemProcessIsPlan || item.ICProductItemProcessInOutStockCheck))
                    {
                        BOSApp.ShowMessage("Công đoạn không thực hiện ghi nhận sản lượng hoặc xuất nhập kho BTP nên không thể kiểm tra đồng bộ!" + Environment.NewLine + "Vui lòng chọn \"Kế hoạch SXCT hoặc xuất nhập kho BTP\" cho công đoạn này!");
                        item.ICProductItemProcessSyncProductCheck = bool.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                    }
                }
                else if (e.Column.FieldName == "ICProductItemProcessInOutStockCheck")
                {
                    bool value = false;
                    if (e.Value != null)
                        bool.TryParse(e.Value.ToString(), out value);
                    if (value && item != null && !item.ICProductItemProcessIsPlan)
                    {
                        item.ICProductItemProcessIsPlan = true;
                    }
                }
                else if (e.Column.FieldName == "ICProductItemProcessForParentSyncCheck")
                {
                    bool value = false;
                    if (e.Value != null)
                        bool.TryParse(e.Value.ToString(), out value);
                    if (value && item != null && !item.ICProductItemProcessIsPlan)
                    {
                        item.ICProductItemProcessIsPlan = true;
                        entity.PIProcessList.ForEach(o =>
                        {
                            if (o.FK_MMOperationID != item.FK_MMOperationID) o.ICProductItemProcessForParentSyncCheck = false;
                        });
                    }
                }
                else if (e.Column.FieldName == "FK_MMOperationSynID")
                {
                    int value = 0;
                    if (e.Value != null)
                        int.TryParse(e.Value.ToString(), out value);
                    if (value > 0)
                    {
                        ICProductItemProcesssInfo itemSync = entity.PIProcessList.Where(o => o.FK_MMOperationID == value).FirstOrDefault();
                        if (itemSync != null && itemSync.FK_MMOperationSynID == item.FK_MMOperationID)
                        {
                            BOSApp.ShowMessage("Công đoạn kiểm tra đồng bộ phải khác công đoạn cần kiểm tra!");
                            item.FK_MMOperationSynID = int.Parse(string.IsNullOrEmpty(gridView.ActiveEditor.OldEditValue.ToString()) ? "0" : gridView.ActiveEditor.OldEditValue.ToString());
                            return;
                        }
                        if (itemSync != null && itemSync.ICProductItemProcessPeriod >= item.ICProductItemProcessPeriod)
                        {
                            BOSApp.ShowMessage("Công đoạn kiểm tra đồng bộ có thứ tự thực hiện lớn hơn công đoạn cần kiểm tra!");
                            item.FK_MMOperationSynID = int.Parse(string.IsNullOrEmpty(gridView.ActiveEditor.OldEditValue.ToString()) ? "0" : gridView.ActiveEditor.OldEditValue.ToString());
                            return;
                        }
                    }
                }
            }

        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Mã công đoạn";
            column.FieldName = "ICProductItemProcessOperationNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Unit time (Phút)";
            column.FieldName = "ICProductItemProcessUnitTime";
            column.OptionsColumn.AllowEdit = true;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);
        }
    }
}
