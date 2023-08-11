using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AdvanceRefund
{
    public class HRAdvanceRefundItemInvoicesGridControl2 : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            AdvanceRefundEntities entity = (AdvanceRefundEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRAdvanceRefundItemInvoiceNoneInvoiceList;
            this.DataSource = bds;
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["FK_ACDebitAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ACUnfinishedConstructionCostID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                //RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                //repositoryItemLookUpEdit.DisplayMember = "ACUnfinishedConstructionCostName";
                //repositoryItemLookUpEdit.ValueMember = "ACUnfinishedConstructionCostID";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACUnfinishedConstructionCostNo", "Mã chứng từ"));
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACUnfinishedConstructionCostName", "Tên chứng từ"));
                //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemUnfinishedLookUpEdit_QueryPopUp);
                //column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["HRAdvanceRefundItemInvoiceSubTotalAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["HRAdvanceRefundItemInvoiceTaxAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["HRAdvanceRefundItemInvoiceTotalAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["HRAdvanceRefundItemInvoiceObjectName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_VMVehicleID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "VMVehicleNoPlate";
                repositoryItemLookUpEdit.ValueMember = "VMVehicleID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("VMVehicleNo", CommonLocalizedResources.VMVehicleNo));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("VMVehicleName", CommonLocalizedResources.VMVehicleName));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("VMVehicleNoPlate", CommonLocalizedResources.VMVehicleNoPlate));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditVehicle_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["FK_ACEInvoiceTypeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACEInvoiceTypeNo";
                repositoryItemLookUpEdit.ValueMember = "ACEInvoiceTypeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACEInvoiceTypeNo", "Mã hóa đơn GTGT"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACEInvoiceTypeTemplateCode", "Mẫu số"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACEInvoiceTypeSeries", "Kí hiệu"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditACEInvoiceType_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.Caption = "Mã hóa đơn GTGT";
            }

            column = gridView.Columns["FK_ACCostObjectID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACCostObjectName";
                repositoryItemLookUpEdit.ValueMember = "ACCostObjectID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACCostObjectNo", "Mã"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACCostObjectName", "Tên"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACCostObjectDesc", "Mô tả"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditACCostObject_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        void repositoryItemLookUpEditACCostObject_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACCostObjectsController unController = new ACCostObjectsController();
            List<ACCostObjectsInfo> coList = unController.GetAllAliveCostObject();
            List<ACCostObjectsInfo> coListFinal = new List<ACCostObjectsInfo>();
            coListFinal.Add(new ACCostObjectsInfo());
            coListFinal.AddRange(coList);
            if (coListFinal != null && coListFinal.Count > 0)
            {
                lookUpEdit.Properties.DataSource = coListFinal;
            }
        }

        void repositoryItemLookUpEditACEInvoiceType_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACEInvoiceTypesController controller = new ACEInvoiceTypesController();
            List<ACEInvoiceTypesInfo> objACEInvoiceTypesInfo = controller.GetAllACEInvoiceType(InvoiceTypeCombo.Purchase.ToString());
            if (objACEInvoiceTypesInfo != null && objACEInvoiceTypesInfo.Count > 0)
            {
                lookUpEdit.Properties.DataSource = objACEInvoiceTypesInfo;
            }
        }
        void repositoryItemLookUpEdit_QueryPopUp1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            ACAccountsController accountController = new ACAccountsController();
            List<ACAccountsInfo> accountList = accountController.GetAllAccountList();
            lke.Properties.DataSource = accountList;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn newColumn = new GridColumn();
            newColumn.Caption = "Mã NCC";
            newColumn.FieldName = "ACObjectAccessKey";
            newColumn.OptionsColumn.AllowEdit = true;
            ACObjectsController objectController = new ACObjectsController();
            List<ACObjectsInfo> objList = objectController.GetObjectsByType(ObjectType.Supplier.ToString());
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DisplayMember = "ACObjectNo";
            repositoryItemLookUpEdit.ValueMember = "ACObjectAccessKey";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectNo", "Mã NCC"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectName", "Tên NCC"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectContactAddressLine3", "Địa chỉ"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectContactTaxCode", "MST"));
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
            newColumn.ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns.Add(newColumn);

            newColumn = new GridColumn();
            newColumn.Caption = "Mã chứng từ";
            newColumn.FieldName = "HRAdvanceRefundItemInvoiceDocumentNo";
            newColumn.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(newColumn);

            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName != "HRAdvanceRefundItemInvoiceTotalAmount")
                {
                    column.OptionsColumn.AllowEdit = true;
                }

            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null
                && e.Column.FieldName == "ACObjectAccessKey")
            {
                string[] objArr = e.Value.ToString().Split(';');
                if (objArr.Length == 2)
                {
                    int objectID = int.Parse(objArr[0]);
                    string objectType = objArr[1];
                    ACObjectsInfo matchObj = BOSApp.GetObjectByIDAndTypeFromCatche(objectID, objectType);
                    if (matchObj != null)
                    {
                        e.DisplayText = matchObj.ACObjectNo;
                    }
                }
            }
            if (e.Column.FieldName == "FK_VMVehicleID")
            {
                if (e.Value != null)
                {
                    int id = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche(TableName.VMVehiclesTableName, "VMVehicleID", id, "VMVehicleNo");
                }
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "FK_ACEInvoiceTypeID")
            {
                if (e.Value != null)
                {
                    int id = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche(TableName.ACEInvoiceTypesTableName, "ACEInvoiceTypeID", id, "ACEInvoiceTypeNo");
                }
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "FK_ACUnfinishedConstructionCostID")
            {
                if (e.Value != null)
                {
                    int id = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche(TableName.ACUnfinishedConstructionCostsTableName, "ACUnfinishedConstructionCostID", id, "ACUnfinishedConstructionCostName");
                }
                else
                    e.DisplayText = "";
            }

            if (e.Column.FieldName == "FK_ACCostObjectID")
            {
                if (e.Value != null)
                {
                    int id = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche(TableName.ACCostObjectsTableName, "ACCostObjectID", id, "ACCostObjectName");
                }
                else
                    e.DisplayText = "";
            }
        }

        void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            ACObjectsController objectController = new ACObjectsController();
            List<ACObjectsInfo> objList = objectController.GetObjectsByType(ObjectType.Supplier.ToString());
            lke.Properties.DataSource = objList;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            AdvanceRefundEntities entity = (AdvanceRefundEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            HRAdvanceRefundsInfo advanceRefund = (HRAdvanceRefundsInfo)entity.MainObject;
            if (entity.HRAdvanceRefundItemInvoiceNoneInvoiceList.CurrentIndex >= 0)
            {
                HRAdvanceRefundItemInvoicesInfo item = (HRAdvanceRefundItemInvoicesInfo)entity.HRAdvanceRefundItemInvoiceNoneInvoiceList[entity.HRAdvanceRefundItemInvoiceNoneInvoiceList.CurrentIndex];

                bool updateNeeded = true;
                if (e.Column.FieldName == "HRAdvanceRefundItemInvoiceTaxPercent"
                    || e.Column.FieldName == "HRAdvanceRefundItemInvoiceSubTotalAmount")
                {
                    if (item.HRAdvanceRefundItemInvoiceSubTotalAmount != 0)
                    {
                        item.HRAdvanceRefundItemInvoiceTaxAmount = item.HRAdvanceRefundItemInvoiceSubTotalAmount / 100 * item.HRAdvanceRefundItemInvoiceTaxPercent;
                        BOSApp.RoundByCurrency(item, "HRAdvanceRefundItemInvoiceTaxAmount", advanceRefund.FK_GECurrencyID);
                        item.HRAdvanceRefundItemInvoiceTotalAmount = item.HRAdvanceRefundItemInvoiceTaxAmount + item.HRAdvanceRefundItemInvoiceSubTotalAmount;
                    }
                }
                else if (e.Column.FieldName == "HRAdvanceRefundItemInvoiceTaxAmount")
                {
                    if (item.HRAdvanceRefundItemInvoiceSubTotalAmount != 0)
                    {
                        item.HRAdvanceRefundItemInvoiceTaxPercent = item.HRAdvanceRefundItemInvoiceTaxAmount / item.HRAdvanceRefundItemInvoiceSubTotalAmount * 100;
                        item.HRAdvanceRefundItemInvoiceTotalAmount = item.HRAdvanceRefundItemInvoiceTaxAmount + item.HRAdvanceRefundItemInvoiceSubTotalAmount;
                    }
                }
                else if (e.Column.FieldName == "ACObjectAccessKey")
                {
                    string[] objArr = item.ACObjectAccessKey.ToString().Split(';');
                    if (objArr.Length == 2)
                    {
                        int objectID = int.Parse(objArr[0]);
                        ACObjectsController objectController = new ACObjectsController();
                        List<ACObjectsInfo> objList = objectController.GetObjectsByType(ObjectType.Supplier.ToString());
                        ACObjectsInfo matchObj = objList.FirstOrDefault(t => t.ACObjectID == objectID);
                        if (matchObj != null)
                        {
                            item.FK_HRObjectID = matchObj.ACObjectID;
                            item.HRObjectType = matchObj.ACObjectType;
                            item.HRAdvanceRefundItemInvoiceObjectName = matchObj.ACObjectName;
                            item.HRAdvanceRefundItemInvoiceObjectAddress = matchObj.ACObjectContactAddressLine3;
                            item.HRAdvanceRefundItemInvoiceObjectTaxNumber = matchObj.ACObjectContactTaxCode;
                        }
                    }

                    updateNeeded = false;
                }
                else if (e.Column.FieldName == "FK_ACSegmentID")
                {
                    if (item.FK_ACSegmentID > 0)
                    {
                        ACSegmentsController objSegmentsController = new ACSegmentsController();
                        ACSegmentsInfo objSegmentsInfo = (ACSegmentsInfo)objSegmentsController.GetObjectByID(item.FK_ACSegmentID);
                        if (objSegmentsInfo != null && objSegmentsInfo.FK_ACDepreciationCostAccountID > 0)
                        {
                            item.FK_ACDebitAccountID = objSegmentsInfo.FK_ACDepreciationCostAccountID;
                        }
                    }
                }
                else if (e.Column.FieldName == "FK_ACEInvoiceTypeID")
                {
                    ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
                    ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByID(item.FK_ACEInvoiceTypeID);
                    if (objEInvoiceTypesInfo != null)
                    {
                        item.HRAdvanceRefundItemInvoiceVATFormNo = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
                        item.HRAdvanceRefundItemInvoiceVATSymbol = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
                    }
                    else
                    {
                        item.HRAdvanceRefundItemInvoiceVATFormNo = string.Empty;
                        item.HRAdvanceRefundItemInvoiceVATSymbol = string.Empty;
                    }
                    entity.UpdateMainObjectBindingSource();
                }
                else if (e.Column.FieldName == "FK_ACUnfinishedConstructionCostID")
                {
                    ACUnfinishedConstructionCostsController objUnfinishedConstructionCostsController = new ACUnfinishedConstructionCostsController();
                    ACUnfinishedConstructionCostsInfo objUnfinishedConstructionCostsInfo = (ACUnfinishedConstructionCostsInfo)objUnfinishedConstructionCostsController.GetObjectByID(item.FK_ACUnfinishedConstructionCostID);
                    if (objUnfinishedConstructionCostsInfo != null)
                    {
                        item.FK_ACDebitAccountID = objUnfinishedConstructionCostsInfo.FK_ACAccountID;
                    }
                }
                if (e.Column.FieldName == "FK_ACCostObjectID")
                {
                    ((AdvanceRefundModule)Screen.Module).UpdateAccountDebitByACCostObjectID(item);
                }
                if (updateNeeded)
                {
                    (entity.Module as AdvanceRefundModule).UpdateTotalAmount();
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((AdvanceRefundModule)Screen.Module).DeleteItemFromHRAdvanceRefundItemInvoiceNoneInvoiceList();
            }
        }

        public void repositoryItemUnfinishedLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;

            ACUnfinishedConstructionCostsController unController = new ACUnfinishedConstructionCostsController();
            List<ACUnfinishedConstructionCostsInfo> coList = unController.GetDataNewStatusForLookupEditControl();
            List<ACUnfinishedConstructionCostsInfo> coListFinal = new List<ACUnfinishedConstructionCostsInfo>();
            coListFinal.Add(new ACUnfinishedConstructionCostsInfo());
            coListFinal.AddRange(coList);

            lookUpEdit.Properties.DataSource = coListFinal;

            lookUpEdit.Properties.DisplayMember = "ACUnfinishedConstructionCostName";
            lookUpEdit.Properties.ValueMember = "ACUnfinishedConstructionCostID";
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);
            AdvanceRefundEntities entity = (AdvanceRefundEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            HRAdvanceRefundItemInvoicesInfo item = entity.HRAdvanceRefundItemInvoiceNoneInvoiceList[entity.HRAdvanceRefundItemInvoiceNoneInvoiceList.CurrentIndex];
            item.HRAdvanceRefundItemInvoiceStatus = AdvanceRefundItemInvoiceStatus.Allowable.ToString();
            item.HRAdvanceRefundItemInvoiceType = AdvanceRefundItemInvoiceType.NoneInvoice.ToString();
        }

        public void repositoryItemLookUpEditVehicle_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            VMVehiclesController objVehiclesController = new VMVehiclesController();
            List<VMVehiclesInfo> vehiclesList = objVehiclesController.GetAllVehicleList();
            VMVehiclesInfo objVehiclesInfo = new VMVehiclesInfo();
            objVehiclesInfo.VMVehicleID = 0;
            if (vehiclesList != null)
            {
                vehiclesList.Insert(0, objVehiclesInfo);
                lookUpEdit.Properties.DataSource = vehiclesList;
            }
            lookUpEdit.Properties.DisplayMember = "VMVehicleNoPlate";
            lookUpEdit.Properties.ValueMember = "VMVehicleID";
        }
    }
}