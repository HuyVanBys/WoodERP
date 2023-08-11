using BOSCommon.Constants;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.EquipmentShipment
{
    public class ShipmentItemGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            EquipmentShipmentEntities entity = (EquipmentShipmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new GridColumn();
            column.Caption = BatchShipmentRoundWoodLocalizedResources.AddNewRow;
            column.FieldName = "AddNewRow";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;

            RepositoryItemHyperLinkEdit AddNewRow = new RepositoryItemHyperLinkEdit();
            AddNewRow.NullText = BatchShipmentRoundWoodLocalizedResources.AddNewRow;
            AddNewRow.Click += new EventHandler(AddNewRow_Click);
            column.ColumnEdit = AddNewRow;
            
            
            column = new GridColumn();
            column.Caption = "Lệnh cấp phát";
            column.FieldName = "MMAllocationProposalNo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;

            gridView.Columns.Add(column);
        }

        private void AddNewRow_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            EquipmentShipmentEntities entity = (EquipmentShipmentEntities)(this.Screen.Module as EquipmentShipmentModule).CurrentModuleEntity;
            ICShipmentsInfo ShipmentItemsInfo = (ICShipmentsInfo)entity.MainObject;
            ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            ICShipmentItemsInfo objnewShipmentItemsInfo = (ICShipmentItemsInfo)objShipmentItemsInfo.Clone();
            if (objnewShipmentItemsInfo != null)
            {
                objnewShipmentItemsInfo.Id = 0;
                objnewShipmentItemsInfo.ICShipmentItemProductIdentifiedEquipmentNo = string.Empty;
                objnewShipmentItemsInfo.ICShipmentItemProductIdentifiedEquipmentNo = entity.GenerateProductIdentifiedEquipmentNo(objnewShipmentItemsInfo);
                entity.ShipmentItemList.Add(objnewShipmentItemsInfo);
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            GridColumn column = gridView.Columns["ICShipmentItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n3}";
            }
            column = gridView.Columns["ICShipmentItemProductUnitPrice"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_HRDepartmentRoomID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICShipmentItemProductSerialNo"];
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
            column = gridView.Columns["FK_ACDepreciationCostAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                InitColumnLookupEdit(TableName.ACAccountsTableName, EquipmentShipmentLocalizedResources.ACAccountNo, column.FieldName);
            }

            column = gridView.Columns["FK_ICProductIdentifiedEquipmentID"];
            if (column != null)
            {
                //RepositoryItemLookUpEdit repositoryItemWoodLookUpEdit = new RepositoryItemLookUpEdit();
                //repositoryItemWoodLookUpEdit.DisplayMember = "ICProductIdentifiedEquipmentNo";
                //repositoryItemWoodLookUpEdit.ValueMember = "ICProductIdentifiedEquipmentID";
                //repositoryItemWoodLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemWoodLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemWoodLookUpEdit.NullText = string.Empty;

                //repositoryItemWoodLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductIdentifiedEquipmentNo", "Mã định danh"));

                //repositoryItemWoodLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemWoodLookUpEdit_QueryPopUp);
                //column.ColumnEdit = repositoryItemWoodLookUpEdit;
                //column.OptionsColumn.AllowEdit = true;
                // column.Visible = false;
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["FK_ICModelID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemProductIdentifiedEquipmentNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemDepreciationMonths"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemDepriciationDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemComment"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
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
            column = gridView.Columns["ICShipmentItemIsSpecificCalculation"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemProductFactor"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            //column = gridView.Columns["ICShipmentItemProductExchangeQty"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //}
            column = gridView.Columns["FK_ICMeasureUnitID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit rpMeasureUnit = new RepositoryItemLookUpEdit();
                rpMeasureUnit.DisplayMember = "ICMeasureUnitName";
                rpMeasureUnit.ValueMember = "ICMeasureUnitID";
                rpMeasureUnit.NullText = string.Empty;
                rpMeasureUnit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                DataSet ds = BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] as DataSet;
                rpMeasureUnit.DataSource = ds.Tables[0];
                rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);
                column.ColumnEdit = rpMeasureUnit;

            }
            column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                RepositoryItemLookUpEdit rpMeasureUnit = new RepositoryItemLookUpEdit();
                rpMeasureUnit.DisplayMember = "ICProductNo";
                rpMeasureUnit.ValueMember = "ICProductID";
                rpMeasureUnit.NullText = string.Empty;
                DataSet ds = BOSApp.LookupTables[TableName.ICProductsTableName] as DataSet;
                rpMeasureUnit.DataSource = ds.Tables[0];
                column.ColumnEdit = rpMeasureUnit;
            }
            column = gridView.Columns["ICShipmentItemTotalAmount"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["FK_MMAllocationProposalID"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("ICShipmentItemTotalAmount", DevExpress.Data.SummaryItemType.Sum);
            return gridView;
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {
                ICMeasureUnitsController controller = new ICMeasureUnitsController();
                DataSet measureUnits = controller.GetMeasureUnitByProductID(item.FK_ICProductID);
                if (measureUnits != null)
                {
                    lookUpEdit.Properties.DataSource = measureUnits.Tables[0];
                    lookUpEdit.Properties.DisplayMember = "ICMeasureUnitName";
                    lookUpEdit.Properties.ValueMember = "ICMeasureUnitID";
                }
                measureUnits.Dispose();
            }
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "ICShipmentItemProductFactor")
                {
                    if (!string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        ICProductMeasureUnitsController controller = new ICProductMeasureUnitsController();
                        ICProductMeasureUnitsInfo measureUnit = controller.GetProductMeasureUnitByProductIDAndMeasureUnitID(item.FK_ICProductID, item.FK_ICMeasureUnitID);
                        if (measureUnit != null && measureUnit.ICProductMeasureUnitIsEdit)
                            return;
                        e.ErrorText = "Hệ số không được phép thay đổi.";
                        e.Valid = false;
                    }
                }
            }
        }

        public void repositoryItemLookUpEditModelDetail_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            EquipmentShipmentEntities entity = (EquipmentShipmentEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
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

        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
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
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                if (e.Value != null)
                {
                    int value = Convert.ToInt32(e.Value);
                    e.DisplayText = objMeasureUnitsController.GetObjectNameByID(value);
                }
                else
                {
                    e.DisplayText = "";
                }
            }
        }

        private void repositoryItemWoodLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            List<ICProductIdentifiedEquipmentsInfo> productSerieList = ((EquipmentShipmentModule)Screen.Module).GetIdentifiedEquipmentList();
            lookup.Properties.DataSource = productSerieList;
            lookup.Properties.DisplayMember = "ICProductIdentifiedEquipmentNo";
            lookup.Properties.ValueMember = "ICProductIdentifiedEquipmentID";
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            EquipmentShipmentEntities entity = (EquipmentShipmentEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ShipmentItemList.CurrentIndex >= 0)
            {
                ICShipmentItemsInfo item = entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
                if (e.Column.FieldName == "FK_ICModelID")
                {
                    ((EquipmentShipmentModule)Screen.Module).ResetModelDetail(item);
                }
                else if (e.Column.FieldName == "FK_ICStockID")
                {
                    ((EquipmentShipmentModule)Screen.Module).SelectSeriesNoDefault(item);
                    ((EquipmentShipmentModule)Screen.Module).ChangeItemSerieNo(item);
                }
                else if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    ((EquipmentShipmentModule)Screen.Module).ChangeItemMeasureUnit(item);
                    ((EquipmentShipmentModule)Screen.Module).UpdateTotalAmount();
                }
                else if (e.Column.FieldName == "ICShipmentItemProductSerialNo")
                {
                    ((EquipmentShipmentModule)Screen.Module).ChangeItemSerieNo(item);
                }
                else
                {
                    entity.ModuleObjects[TableName.ICShipmentItemsTableName] = (ICShipmentItemsInfo)item.Clone();
                    if (e.Column.FieldName == "ICShipmentItemProductQty")
                    {
                        ((EquipmentShipmentModule)Screen.Module).ChangeItemQty();
                    }
                    (entity.Module as EquipmentShipmentModule).ChangeItemFromShipmentItemsList();
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((EquipmentShipmentModule)Screen.Module).DeleteItemFromShipmentItemsList();
            }
        }
    }
}
