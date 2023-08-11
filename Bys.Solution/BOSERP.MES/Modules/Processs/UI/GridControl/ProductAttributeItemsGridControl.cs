using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Processs
{
    public partial class ProductAttributeItemsGridControl : BOSGridControl
    {
        /// <summary>
        /// Invalidate data source
        /// </summary>
        /// <param name="dataSource">Data source</param>
        public override void InitGridControlDataSource()
        {
            ProcesssEntities entity = (ProcesssEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductAttributeItemList;
            this.DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            GridColumn column = gridView.Columns["ICProductAttributeItemIsEndProcess"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;
            return gridView;
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)sender;
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((ProcesssModule)Screen.Module).DeleteItemFromList();
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            foreach (GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = true;
            }

            GridColumn column = new GridColumn();
            column.Caption = "Mã công đoạn";
            column.FieldName = "MMOperationNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = "Tên công đoạn";
            //column.FieldName = "MMOperationName";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = MESLocalizedResources.AddProcessInfo;
            //column.FieldName = "AddProcessInfo";
            //column.OptionsColumn.AllowEdit = true;
            //column.Visible = true;
            //column.VisibleIndex = 3;

            //RepositoryItemHyperLinkEdit AddProcessInfo = new RepositoryItemHyperLinkEdit();
            //AddProcessInfo.NullText = MESLocalizedResources.AddProcessInfo;
            //AddProcessInfo.Click += new EventHandler(AddProcessInfo_Click);
            //column.ColumnEdit = AddProcessInfo;
            //gridView.Columns.Add(column);

        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "FK_MMOperationID")
            {
                ProcesssEntities entity = (ProcesssEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                ICProductAttributeItemsInfo item = entity.ProductAttributeItemList[entity.ProductAttributeItemList.CurrentIndex];
                if (item != null)
                {
                    MMOperationsController OController = new MMOperationsController();
                    MMOperationsInfo OInfo = (MMOperationsInfo)OController.GetObjectByID(item.FK_MMOperationID);
                    if (OInfo != null)
                    {
                        item.MMOperationNo = OInfo.MMOperationNo;
                        item.MMOperationName = OInfo.MMOperationName;
                        item.ICProductAttributeItemIsPlan = OInfo.MMOperationIsPlan;
                        item.FK_MMOperationSynID = OInfo.FK_MMOperationSynID;
                        item.ICProductAttributeItemForParentSyncCheck = OInfo.MMOperationForParentSyncCheck;
                        item.ICProductAttributeItemPeriod = entity.ProductAttributeItemList.Count;
                        item.ICProductAttributeItemInOutStockCheck = OInfo.MMOperationInOutStockCheck;
                        item.ICProductAttributeItemIsOutSourcing = OInfo.MMOperationIsOutSourcing;
                        item.ICProductAttributeItemIsEndProcess = OInfo.MMOperationIsOutSourcing;
                        item.ICProductAttributeItemIsPlan = OInfo.MMOperationIsPlan;
                        item.ICProductAttributeItemSyncProductCheck = OInfo.MMOperationSyncProductCheck;
                        item.FK_MMProcessID = ((MMProcesssInfo)entity.MainObject).MMProcessID;

                    }

                }
            }
            if (e.Column.FieldName == "ICProductAttributeItemIsEndProcess")
            {
                ProcesssEntities entity = (ProcesssEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                ICProductAttributeItemsInfo item = entity.ProductAttributeItemList[entity.ProductAttributeItemList.CurrentIndex];
                if (item == null)
                    return;
                entity.ProductAttributeItemList
                    .Where(p => p != item)
                    .ToList()
                    ?.ForEach(p => p.ICProductAttributeItemIsEndProcess = false);
            }

            RefreshDataSource();
        }

        private void AddProcessInfo_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICProductAttributeItemsInfo objProductAttributeItemsInfo = (ICProductAttributeItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objProductAttributeItemsInfo != null)
                    ((ProcesssModule)Screen.Module).ShowProcessInfo(objProductAttributeItemsInfo);
            }
        }
        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ICMachineGroup")
            {
                if (e.Value != null)
                {
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ADConfigValuesInfo objConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue(ConfigValueGroup.MachineGroup, e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                }
            }
        }
    }
}
