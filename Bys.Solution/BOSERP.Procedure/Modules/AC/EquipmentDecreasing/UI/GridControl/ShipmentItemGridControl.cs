using BOSCommon.Constants;
using BOSComponent;
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

namespace BOSERP.Modules.EquipmentDecreasing
{
    public partial class ShipmentItemGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            EquipmentDecreasingEntities entity = (EquipmentDecreasingEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = EquipmentDecreasingLocalizedResources.ICShipmentItemRemainedAmount;
            column.FieldName = "ICShipmentItemRemainedAmount";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["ICShipmentItemProductQty"];
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
                column.OptionsColumn.AllowEdit = true;
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
            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("ICShipmentItemTotalAmount", DevExpress.Data.SummaryItemType.Sum);
            return gridView;
        }
        public void repositoryItemLookUpEditModelDetail_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            EquipmentDecreasingEntities entity = (EquipmentDecreasingEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICShipmentItemsInfo item = (ICShipmentItemsInfo)entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
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


            List<ICProductIdentifiedEquipmentsInfo> productSerieList = ((EquipmentDecreasingModule)Screen.Module).GetIdentifiedEquipmentList();


            lookup.Properties.DataSource = productSerieList;
            lookup.Properties.DisplayMember = "ICProductIdentifiedEquipmentNo";
            lookup.Properties.ValueMember = "ICProductIdentifiedEquipmentID";

        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            EquipmentDecreasingEntities entity = (EquipmentDecreasingEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ShipmentItemList.CurrentIndex >= 0)
            {
                ICShipmentItemsInfo item = entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
                if (e.Column.FieldName == "FK_ICModelID")
                {
                    ((EquipmentDecreasingModule)Screen.Module).ResetModelDetail(item);
                }
                entity.ModuleObjects[TableName.ICShipmentItemsTableName] = (ICShipmentItemsInfo)item.Clone();
                (entity.Module as EquipmentDecreasingModule).ChangeItemFromShipmentItemsList();
            }
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (gridView.FocusedColumn.FieldName == "ICShipmentItemProductQty")
                {
                    decimal qty = Convert.ToDecimal(e.Value);
                    string msg = ((EquipmentDecreasingModule)Screen.Module).CheckForValidDecreasedQty(item, qty);
                    if (!string.IsNullOrEmpty(msg))
                    {
                        e.Valid = false;
                        e.ErrorText = msg;
                    }
                }

            }
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
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((EquipmentDecreasingModule)Screen.Module).DeleteItemFromShipmentItemsList();
            }
        }

    }
}
