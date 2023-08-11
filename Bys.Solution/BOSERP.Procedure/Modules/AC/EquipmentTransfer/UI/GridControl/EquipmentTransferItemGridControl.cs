using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.EquipmentTransfer
{
    public partial class EquipmentTransferItemGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            EquipmentTransferEntities entity = (EquipmentTransferEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EquipmentTransferItemList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = EquipmentTransferLocalizedResources.ICProductNo;
            column.FieldName = "ICProductNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = EquipmentTransferLocalizedResources.ICProductName;
            column.FieldName = "ICProductName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = EquipmentTransferLocalizedResources.EquipmentRemainedAmount;
            column.FieldName = "EquipmentRemainedAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = EquipmentTransferLocalizedResources.ItemKey;
            column.FieldName = "ItemKey";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductIdentifiedEquipmentID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ICProductIdentifiedEquipmentsController objPIEsController = new ICProductIdentifiedEquipmentsController();

                    ICProductIdentifiedEquipmentsInfo objPIEsInfo = (ICProductIdentifiedEquipmentsInfo)objPIEsController.GetObjectByID(matchCodeID);
                    if (objPIEsInfo != null)
                        e.DisplayText = objPIEsInfo.ICProductIdentifiedEquipmentNo;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "ItemKey")
            {
                if (e.Value != null)
                {
                    string itemKey = e.Value.ToString();
                    e.DisplayText = ((EquipmentTransferModule)Screen.Module).GetDisplayTextForItemByItemKey(itemKey);
                }
            }

        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(GridView_FocusedColumnChanged);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["ACEquipmentTransferItemQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["FK_HRFromRoomID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ICProductSerieID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["FK_HRToRoomID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HRDepartmentRoomGroupItemID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMLineID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMWorkShopID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HRToDepartmentRoomGroupItemID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMToLineID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMToWorkShopID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICProductSerieNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_HREmployeeUserID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HRDepartmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HRDepartmentRoomID"];
            if (column != null)
            {
                column.Visible = false;
            }
            column = gridView.Columns["FK_ICProductIdentifiedEquipmentID"];
            if (column != null)
            {
                RepositoryItemLookUpEdit repositoryItemWoodLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemWoodLookUpEdit.DisplayMember = "ICProductIdentifiedEquipmentNo";
                repositoryItemWoodLookUpEdit.ValueMember = "ICProductIdentifiedEquipmentID";
                repositoryItemWoodLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemWoodLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemWoodLookUpEdit.NullText = string.Empty;
                repositoryItemWoodLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductIdentifiedEquipmentNo", "Mã định danh"));
                repositoryItemWoodLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemWoodLookUpEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemWoodLookUpEdit;
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ItemKey"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ACDepreciationCostAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                InitColumnLookupEdit(TableName.ACAccountsTableName, AssetTransferLocalizedResources.ACAccountNo, column.FieldName);
            }

            column = gridView.Columns["FK_ICModelID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICModelDetailID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICModelDetailsName";
                repositoryItemLookUpEdit.ValueMember = "ICModelDetailID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICModelDetailsName", PurchaseOrderLocalizedResources.ICModelDetailsName));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditModelDetail_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            column = gridView.Columns["FK_ACCostCenterID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ACSegmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Visible = true;

            }
            return gridView;
        }
        public void repositoryItemLookUpEditModelDetail_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            EquipmentTransferEntities entity = (EquipmentTransferEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ACEquipmentTransferItemsInfo item = (ACEquipmentTransferItemsInfo)entity.EquipmentTransferItemList[entity.EquipmentTransferItemList.CurrentIndex];
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICModelDetailsController objModelDetailsController = new ICModelDetailsController();
            List<ICModelDetailsInfo> ModelDetailsList = new List<ICModelDetailsInfo>();
            ICModelDetailsInfo objModelDetailsInfo = new ICModelDetailsInfo();
            objModelDetailsInfo.ICModelDetailID = 0;
            if (item != null)
            {
                ModelDetailsList = objModelDetailsController.GetModelDetailByModelID(item.FK_ICModelID);
            }
            if (ModelDetailsList != null)
            {
                if (ModelDetailsList.Count > 0)
                {
                    ModelDetailsList.Insert(0, objModelDetailsInfo);
                }
                lookUpEdit.Properties.DataSource = ModelDetailsList;
            }
            lookUpEdit.Properties.DisplayMember = "ICModelDetailsName";
            lookUpEdit.Properties.ValueMember = "ICModelDetailID";
        }
        void repositoryItemWoodLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            List<ICProductIdentifiedEquipmentsInfo> productSerieList = ((EquipmentTransferModule)Screen.Module).GetIdentifiedEquipmentList();
            lookup.Properties.DataSource = productSerieList;
            lookup.Properties.DisplayMember = "ICProductIdentifiedEquipmentNo";
            lookup.Properties.ValueMember = "ICProductIdentifiedEquipmentID";
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ACEquipmentTransferItemsInfo item = (ACEquipmentTransferItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (e.Column.FieldName == "ItemKey")
                //if (e.Column.FieldName == "ICProductSerieNo")
                {
                    ACEquipmentTransferItemsInfo selectedProductSerie = ((RepositoryItemBOSLookupEdit)e.Column.ColumnEdit).GetDataSourceRowByKeyValue(e.Value) as ACEquipmentTransferItemsInfo;
                    ((EquipmentTransferModule)Screen.Module).ChangeEquipmentSerie(item, selectedProductSerie);
                }
                if (e.Column.FieldName == "FK_ICModelID")
                {
                    ((EquipmentTransferModule)Screen.Module).ResetModelDetail(item);
                }
                else if (e.Column.FieldName == "FK_HRFromRoomID")
                {
                    item.ICProductSerieNo = string.Empty;
                    ((EquipmentTransferModule)Screen.Module).ChangeEquipmentSerie(item, new ACEquipmentTransferItemsInfo());
                }
                else if (e.Column.FieldName == "ACEquipmentTransferItemQty")
                {
                    ((EquipmentTransferModule)Screen.Module).ChangeEquipmentQty((decimal)e.Value);
                }
                else if (e.Column.FieldName == "FK_ICProductIdentifiedEquipmentID")
                {
                    ((EquipmentTransferModule)Screen.Module).ChangeIdentifiedEquipment(item);
                }
            }
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ACEquipmentTransferItemsInfo item = (ACEquipmentTransferItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (gridView.FocusedColumn.FieldName == "ACEquipmentTransferItemQty")
                {
                    decimal qty = Convert.ToDecimal(e.Value);
                    string msg = ((EquipmentTransferModule)Screen.Module).CheckForValidShippedQty(item, qty);
                    if (!string.IsNullOrEmpty(msg))
                    {
                        e.Valid = false;
                        e.ErrorText = msg;
                    }
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((EquipmentTransferModule)Screen.Module).RemoveSelectedItem();
            }
        }

        protected override void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn.FieldName == "ItemKey")
            //if (gridView.FocusedColumn.FieldName == "ICProductSerieNo")
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ACEquipmentTransferItemsInfo item = (ACEquipmentTransferItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    InvalidateSerieColumn(gridView.FocusedColumn, item);
                }
                else
                {
                    GridColumn column = gridView.Columns["ItemKey"];
                    if (column != null)
                    {
                        column.ColumnEdit = null;
                    }
                }
            }
        }

        private void GridView_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn.FieldName == "ItemKey")
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ACEquipmentTransferItemsInfo item = (ACEquipmentTransferItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    InvalidateSerieColumn(gridView.FocusedColumn, item);
                }
            }
            else
            {
                GridColumn column = gridView.Columns["ItemKey"];
                if (column != null)
                {
                    column.ColumnEdit = null;
                }
            }
        }

        /// <summary>
        /// Invalidate a serie column
        /// </summary>
        /// <param name="column">Given column</param>
        /// <param name="item">Current item</param>
        private void InvalidateSerieColumn(GridColumn column, ACEquipmentTransferItemsInfo item)
        {
            RepositoryItemBOSLookupEdit rep = new RepositoryItemBOSLookupEdit();
            rep.TextEditStyle = TextEditStyles.Standard;
            rep.SearchMode = SearchMode.AutoFilter;
            rep.NullText = string.Empty;
            rep.BestFitMode = BestFitMode.BestFitResizePopup;
            rep.Tag = "ICProductSeries";
            rep.Columns.Add(new LookUpColumnInfo("ICProductSerieNo", EquipmentTransferLocalizedResources.ICProductSerieNo));
            rep.Columns.Add(new LookUpColumnInfo("ACEquipmentTransferItemRemainedQty", EquipmentTransferLocalizedResources.EquipmentRemainedQty));
            rep.Columns.Add(new LookUpColumnInfo("EquipmentRemainedAmount", EquipmentTransferLocalizedResources.EquipmentRemainedAmount));
            rep.ValueMember = "ItemKey";
            rep.DisplayMember = "ICProductSerieNo";

            ACEquipmentTransferItemsController equipmentTransferItemController = new ACEquipmentTransferItemsController();
            List<ACEquipmentTransferItemsInfo> list = equipmentTransferItemController.GetSeriesByEquipmentIDAndRoomID(item.FK_ICProductID, item.FK_HRFromRoomID);
            if (list.Count > 0)
            {
                list.Insert(0, new ACEquipmentTransferItemsInfo());
            }
            //ICProductSeriesController productSerieController = new ICProductSeriesController();
            //List<ICProductSeriesInfo> list = productSerieController.GetSeriesByEquipmentIDAndRoomID(item.FK_ICProductID, item.FK_HRFromRoomID);
            //if (list.Count > 0)
            //{
            //    list.Insert(0, new ICProductSeriesInfo());
            //}
            rep.DataSource = list;
            column.ColumnEdit = rep;
        }
        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ShowInventory();
        }
        private void ShowInventory()
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                BusinessObject item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
                BOSDbUtil dbUtil = new BOSDbUtil();
                int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
                string itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
                String columnName = String.Empty;
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductDesc";
                string desc = dbUtil.GetPropertyStringValue(item, columnName);
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
                int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
                ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
            }
        }
    }
}
