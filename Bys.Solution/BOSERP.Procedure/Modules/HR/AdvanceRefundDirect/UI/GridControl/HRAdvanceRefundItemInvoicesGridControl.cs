using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AdvanceRefundDirect
{
    public class HRAdvanceRefundItemInvoicesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            AdvanceRefundDirectEntities entity = (AdvanceRefundDirectEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRAdvanceRefundItemInvoiceList;
            this.DataSource = bds;
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["FK_ACDebitAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                ACAccountsController accountController = new ACAccountsController();
                List<ACAccountsInfo> accountList = accountController.GetAllAccountList();
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACAccountNo";
                repositoryItemLookUpEdit.ValueMember = "ACAccountID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountNo", "Mã tài khoản"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountName", "Tên tài khoản"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp1);
                repositoryItemLookUpEdit.DataSource = accountList;
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            column = gridView.Columns["FK_ACUnfinishedConstructionCostID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                ACUnfinishedConstructionCostsController unController = new ACUnfinishedConstructionCostsController();
                List<ACUnfinishedConstructionCostsInfo> coList = unController.GetDataNewStatusForLookupEditControl();
                List<ACUnfinishedConstructionCostsInfo> coListFinal = new List<ACUnfinishedConstructionCostsInfo>();
                coListFinal.Add(new ACUnfinishedConstructionCostsInfo());
                coListFinal.AddRange(coList);
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACUnfinishedConstructionCostName";
                repositoryItemLookUpEdit.ValueMember = "ACUnfinishedConstructionCostID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACUnfinishedConstructionCostNo", "Mã chứng từ"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACUnfinishedConstructionCostName", "Tên chứng từ"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemUnfinishedLookUpEdit_QueryPopUp);
                repositoryItemLookUpEdit.DataSource = coListFinal;
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
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditACEInvoiceTypeNo_QueryPopUp);
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
        void repositoryItemLookUpEditACEInvoiceTypeNo_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACEInvoiceTypesController controller = new ACEInvoiceTypesController();
            List<ACEInvoiceTypesInfo> objACEInvoiceTypesInfo = controller.GetAllACEInvoiceType(InvoiceTypeCombo.Purchase.ToString());
            if (objACEInvoiceTypesInfo != null && objACEInvoiceTypesInfo.Count > 0)
            {
                lookUpEdit.Properties.DataSource = objACEInvoiceTypesInfo;
            }
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
            newColumn.Caption = "Đối tượng";
            newColumn.FieldName = "ACObjectAccessKey";
            newColumn.OptionsColumn.AllowEdit = true;
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DisplayMember = "ACObjectNo";
            repositoryItemLookUpEdit.ValueMember = "ACObjectAccessKey";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectNo", "Mã đối tượng"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectName", "Tên đối tượng"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectContactAddressLine3", "Địa chỉ"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectContactTaxCode", "MST"));
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
            newColumn.ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns.Add(newColumn);


            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName != "HRAdvanceRefundItemInvoiceTotalAmount")
                {
                    column.OptionsColumn.AllowEdit = true;
                }

            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(gridView_ValidateRow);
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
            List<ACObjectsInfo> objList = objectController.GetAllObjects();

            lke.Properties.DataSource = objList;

        }

        void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = this.MainView as GridView;
            if (view.IsNewItemRow(e.RowHandle))
            {
                if (((AdvanceRefundDirectModule)Screen.Module).GetAdvanceRefundType() == AdvanceRefundType.HasInvoice.ToString())
                {
                    e.Valid = false;
                    e.ErrorText = "Loại chứng từ không phù hợp";
                }
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            AdvanceRefundDirectEntities entity = (AdvanceRefundDirectEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            HRAdvanceRefundsInfo advanceRefund = (HRAdvanceRefundsInfo)entity.MainObject;
            if (entity.HRAdvanceRefundItemInvoiceList.CurrentIndex >= 0)
            {
                HRAdvanceRefundItemInvoicesInfo item = (HRAdvanceRefundItemInvoicesInfo)entity.HRAdvanceRefundItemInvoiceList[entity.HRAdvanceRefundItemInvoiceList.CurrentIndex];

                bool updateNeeded = true;
                if (e.Column.FieldName == "HRAdvanceRefundItemInvoiceTaxPercent"
                    || e.Column.FieldName == "HRAdvanceRefundItemInvoiceSubTotalAmount")
                {
                    if (e.Column.FieldName == "HRAdvanceRefundItemInvoiceSubTotalAmount" && item.HRAdvanceRefundItemInvoiceSubTotalAmount < 0)
                    {
                        BOSApp.ShowMessage("Không được nhập số âm!");
                        GridView gridView1 = (GridView)MainView;
                        item.HRAdvanceRefundItemInvoiceSubTotalAmount = Convert.ToDecimal(gridView1.ActiveEditor.OldEditValue.ToString());
                        return;
                    }
                    if (e.Column.FieldName == "HRAdvanceRefundItemInvoiceTaxPercent" && item.HRAdvanceRefundItemInvoiceTaxPercent < 0)
                    {
                        BOSApp.ShowMessage("Không được nhập số âm!");
                        GridView gridView1 = (GridView)MainView;
                        item.HRAdvanceRefundItemInvoiceTaxPercent = Convert.ToDecimal(gridView1.ActiveEditor.OldEditValue.ToString());
                        return;
                    }
                    if (item.HRAdvanceRefundItemInvoiceSubTotalAmount >= 0)
                    {
                        item.HRAdvanceRefundItemInvoiceTaxAmount = item.HRAdvanceRefundItemInvoiceSubTotalAmount / 100 * item.HRAdvanceRefundItemInvoiceTaxPercent;
                        BOSApp.RoundByCurrency(item, "HRAdvanceRefundItemInvoiceTaxAmount", advanceRefund.FK_GECurrencyID);
                        item.HRAdvanceRefundItemInvoiceTotalAmount = item.HRAdvanceRefundItemInvoiceTaxAmount + item.HRAdvanceRefundItemInvoiceSubTotalAmount;
                    }
                }
                else if (e.Column.FieldName == "HRAdvanceRefundItemInvoiceTaxAmount")
                {
                    if (item.HRAdvanceRefundItemInvoiceTaxAmount < 0)
                    {
                        BOSApp.ShowMessage("Không được nhập số âm!");
                        GridView gridView1 = (GridView)MainView;
                        item.HRAdvanceRefundItemInvoiceTaxAmount = Convert.ToDecimal(gridView1.ActiveEditor.OldEditValue.ToString());
                        return;
                    }
                    if (item.HRAdvanceRefundItemInvoiceSubTotalAmount >= 0)
                    {
                        item.HRAdvanceRefundItemInvoiceTaxPercent = item.HRAdvanceRefundItemInvoiceTaxAmount / item.HRAdvanceRefundItemInvoiceSubTotalAmount * 100;
                        item.HRAdvanceRefundItemInvoiceTotalAmount = item.HRAdvanceRefundItemInvoiceTaxAmount + item.HRAdvanceRefundItemInvoiceSubTotalAmount;
                    }
                }
                if (e.Column.FieldName == "FK_ACUnfinishedConstructionCostID")
                {
                    ((AdvanceRefundDirectModule)Screen.Module).UpdateAccountDebitDocumentEntrys(item);
                }
                if (e.Column.FieldName == "FK_ACCostObjectID")
                {
                    ((AdvanceRefundDirectModule)Screen.Module).UpdateAccountDebitByACCostObjectID(item);
                }
                else if (e.Column.FieldName == "ACObjectAccessKey")
                {
                    string[] objArr = item.ACObjectAccessKey.ToString().Split(';');
                    if (objArr.Length == 2)
                    {
                        int objectID = int.Parse(objArr[0]);
                        ACObjectsController objectController = new ACObjectsController();
                        ACObjectsInfo objObjectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectID == objectID && o.ACObjectType == objArr[1]);
                        if (objObjectsInfo != null)
                        {
                            item.FK_HRObjectID = objObjectsInfo.ACObjectID;
                            item.HRObjectType = objObjectsInfo.ACObjectType;
                            item.HRAdvanceRefundItemInvoiceObjectName = objObjectsInfo.ACObjectName;
                            item.HRAdvanceRefundItemInvoiceObjectAddress = objObjectsInfo.ACObjectContactAddressLine3;
                            item.HRAdvanceRefundItemInvoiceObjectTaxNumber = objObjectsInfo.ACObjectTaxNumber;
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
                if (updateNeeded)
                {
                    (entity.Module as AdvanceRefundDirectModule).UpdateTotalAmount();
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((AdvanceRefundDirectModule)Screen.Module).DeleteItemFromHRAdvanceRefundItemInvoiceList();
            }
        }
        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);
            AdvanceRefundDirectEntities entity = (AdvanceRefundDirectEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            HRAdvanceRefundsInfo advanceRefund = (HRAdvanceRefundsInfo)entity.MainObject;
            GridView gridView = (GridView)sender;
            HRAdvanceRefundItemInvoicesInfo objAdvanceRefundItemInvoicesInfo = (HRAdvanceRefundItemInvoicesInfo)gridView.GetRow(e.RowHandle);
            ACObjectsInfo objectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectID == advanceRefund.FK_ACObjectID && o.ACObjectType == advanceRefund.HRObjectType);
            if (objectsInfo != null)
            {
                objAdvanceRefundItemInvoicesInfo.ACObjectAccessKey = advanceRefund.ACObjectAccessKey;
                objAdvanceRefundItemInvoicesInfo.FK_HRObjectID = objectsInfo.ACObjectID;
                objAdvanceRefundItemInvoicesInfo.HRObjectType = objectsInfo.ACObjectType;
                objAdvanceRefundItemInvoicesInfo.HRAdvanceRefundItemInvoiceObjectName = objectsInfo.ACObjectName;
                objAdvanceRefundItemInvoicesInfo.HRAdvanceRefundItemInvoiceObjectAddress = objectsInfo.ACObjectContactAddressLine3;
                objAdvanceRefundItemInvoicesInfo.HRAdvanceRefundItemInvoiceObjectTaxNumber = objectsInfo.ACObjectTaxNumber;
            }
            objAdvanceRefundItemInvoicesInfo.FK_VMVehicleID = advanceRefund.FK_VMVehicleID;
            objAdvanceRefundItemInvoicesInfo.HRAdvanceRefundItemInvoiceObjectDesc = advanceRefund.HRAdvanceRefundDesc;
        }
    }
}
