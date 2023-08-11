using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.EquipmentIncreasing
{
    public class ShipmentItemGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            EquipmentIncreasingEntities entity = (EquipmentIncreasingEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = EquipmentIncreasingLocalizedResources.ICShipmentItemRemainedAmount;
            column.FieldName = "ICShipmentItemRemainedAmount";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["ICShipmentItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICShipmentItemProductUnitPrice"];
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

            column = gridView.Columns["ICShipmentItemDepreciatedAmount"];
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
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "HREmployeeName";
                repositoryItemLookUpEdit.ValueMember = "HREmployeeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HREmployeeNo", "Mã nhân viên"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HREmployeeName", "Tên nhân viên"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditEmployeeProposal_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
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
            }
            column = gridView.Columns["ICShipmentItemProductIdentifiedEquipmentNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductIdentifiedEquipmentID"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["FK_ICModelID"];
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
            column = gridView.Columns["FK_ICModelDetailID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICModelDetailsName";
                repositoryItemLookUpEdit.ValueMember = "ICModelDetailID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICModelDetailsName", PurchaseOrderLocalizedResources.ICModelDetailsName));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditModelDetail_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("ICShipmentItemTotalAmount", DevExpress.Data.SummaryItemType.Sum);
            return gridView;
        }

        protected override void RepositoryItemLookupEdit_QueryPopup(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            string tableName = base.GetLookupTableInLookupEditCtrl(lke);
            if (tableName == "ICModelDetailID")
            {
                EquipmentIncreasingEntities entity = (EquipmentIncreasingEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ICShipmentItemsInfo item = (ICShipmentItemsInfo)entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
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
                    lke.Properties.DataSource = ModelDetailsList;
                }
            }
            else
                base.RepositoryItemLookupEdit_QueryPopup(sender, e);
        }

        public void repositoryItemLookUpEditModelDetail_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            EquipmentIncreasingEntities entity = (EquipmentIncreasingEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
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

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            EquipmentIncreasingEntities entity = (EquipmentIncreasingEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ShipmentItemList.CurrentIndex >= 0)
            {
                ICShipmentItemsInfo item = entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
                entity.ModuleObjects[TableName.ICShipmentItemsTableName] = (ICShipmentItemsInfo)item.Clone();
                if (e.Column.FieldName == "FK_ICModelID")
                {
                    ((EquipmentIncreasingModule)Screen.Module).ResetModelDetail(item);
                }
                (entity.Module as EquipmentIncreasingModule).ChangeItemFromShipmentItemsList();
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
                    string msg = ((EquipmentIncreasingModule)Screen.Module).CheckForValidShippedQty(item, qty);
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
                ((EquipmentIncreasingModule)Screen.Module).DeleteItemFromShipmentItemsList();
            }
        }

        public void repositoryItemLookUpEditEmployeeProposal_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HREmployeesInfo> employeeList = new List<HREmployeesInfo>();
            employeeList = objEmployeesController.GetAllEmployees();
            if (employeeList != null)
            {
                lookUpEdit.Properties.DataSource = employeeList;
            }
            lookUpEdit.Properties.DisplayMember = "HREmployeeName";
            lookUpEdit.Properties.ValueMember = "HREmployeeID";
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_HREmployeeUserID")
            {
                if (e.Value != null)
                {
                    int employeeID = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche(TableName.HREmployeesTableName, "HREmployeeID", employeeID, "HREmployeeName");
                }
            }
        }
    }
}
