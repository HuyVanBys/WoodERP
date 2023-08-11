using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.AP.FeePayment.Localization;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.FeePayment
{
    public partial class APFeePaymentFeeConfigsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            FeePaymentEntities entity = (FeePaymentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.FeePaymentFeeConfigList;
            DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((FeePaymentModule)Screen.Module).RemoveSelectedFeeConfig();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            ACObjectsController objObjectsController = new ACObjectsController();

            GridColumn newColumn = new GridColumn();
            newColumn.Caption = "Mã đối tượng";
            newColumn.FieldName = "ACObjectAccessKey";
            newColumn.OptionsColumn.AllowEdit = true;
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DataSource = objObjectsController.GetObjectList(null, null);
            repositoryItemLookUpEdit.DisplayMember = "ACObjectNo";
            repositoryItemLookUpEdit.ValueMember = "ACObjectAccessKey";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectNo", "Mã đối tượng"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectName", "Tên đối tượng"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectContactAddressLine3", "Địa chỉ"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectTaxNumber", "MST"));
            repositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditACObjectAccessKey_QueryPopUp);
            newColumn.ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns.Add(newColumn);
        }

        protected void repositoryItemLookUpEditACObjectAccessKey_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            ACObjectsController objectController = new ACObjectsController();
            List<ACObjectsInfo> objList = objectController.GetAllObjects();

            lke.Properties.DataSource = objList;

        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            GridColumn Column = gridView.Columns["APFeePaymentFeeConfigVATSymbol"];
            if (Column != null)
            {
                RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit();
                repositoryItemTextEdit.CharacterCasing = CharacterCasing.Upper;
                Column.ColumnEdit = repositoryItemTextEdit;
            }

            Column = gridView.Columns["FK_ICFeeConfigID"];
            if (Column != null)
            {
                Column.OptionsColumn.AllowEdit = true;
            }
            Column = gridView.Columns["APFeePaymentFeeConfigTotalAmount"];
            if (Column != null)
            {
                Column.OptionsColumn.AllowEdit = false;
            }
            Column = gridView.Columns["FK_VMVehicleID"];
            if (Column != null)
            {
                Column.OptionsColumn.AllowEdit = true;
            }
            Column = gridView.Columns["APFeePaymentFeeConfigNo"];
            if (Column != null)
            {
                Column.OptionsColumn.AllowEdit = false;
            }
            Column = gridView.Columns["APFeePaymentFeeConfigQty"];
            if (Column != null)
            {
                Column.OptionsColumn.AllowEdit = false;
            }
            Column = gridView.Columns["FK_ACEInvoiceTypeID"];
            if (Column != null)
            {
                Column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = "FK_ACEInvoiceTypeID";
                repositoryItemLookUpEdit.DisplayMember = "ACEInvoiceTypeNo";
                repositoryItemLookUpEdit.ValueMember = "ACEInvoiceTypeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACEInvoiceTypeNo", "Mã hóa đơn GTGT"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACEInvoiceTypeTemplateCode", "Mẫu số"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACEInvoiceTypeSeries", "Kí hiệu"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditACEInvoiceTypeNo_QueryPopUp);
                Column.ColumnEdit = repositoryItemLookUpEdit;
                Column.Caption = "Mã hóa đơn GTGT";
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
        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ACEInvoiceTypeID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ACEInvoiceTypesController controller = new ACEInvoiceTypesController();
                    ACEInvoiceTypesInfo objACEInvoiceTypesInfo = (ACEInvoiceTypesInfo)controller.GetObjectByID(matchCodeID);
                    if (objACEInvoiceTypesInfo != null)
                        e.DisplayText = objACEInvoiceTypesInfo.ACEInvoiceTypeNo;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            FeePaymentEntities entity = (FeePaymentEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)entity.MainObject;
            if (entity.FeePaymentFeeConfigList.CurrentIndex >= 0)
            {
                entity.ModuleObjects[TableName.APFeePaymentFeeConfigsTableName] = (APFeePaymentFeeConfigsInfo)entity.FeePaymentFeeConfigList[entity.FeePaymentFeeConfigList.CurrentIndex];
                APFeePaymentFeeConfigsInfo item = (APFeePaymentFeeConfigsInfo)entity.FeePaymentFeeConfigList[entity.FeePaymentFeeConfigList.CurrentIndex];
                if (e.Column.FieldName == "APFeePaymentFeeConfigAmount")
                {
                    if (!string.IsNullOrEmpty(item.APFeePaymentFeeConfigNo))
                    {
                        BOSApp.ShowMessage(FeePaymentLocalizedResources.ErrorData);
                        GridView gridView1 = (GridView)MainView;
                        item.APFeePaymentFeeConfigAmount = Convert.ToDecimal(gridView1.ActiveEditor.OldEditValue.ToString());
                        return;
                    }
                    item.APFeePaymentFeeConfigTaxAmount = item.APFeePaymentFeeConfigAmount * item.APFeePaymentFeeConfigTaxPercent / 100;
                    ((FeePaymentModule)Screen.Module).UpdateTotalAmount();
                    ((FeePaymentModule)Screen.Module).UpdateFeePaymentAllocatedAmountByFeeConfigAmount(item);
                }
                else if (e.Column.FieldName == "APFeePaymentFeeConfigTaxPercent")
                {
                    if (!string.IsNullOrEmpty(item.APFeePaymentFeeConfigNo))
                    {
                        BOSApp.ShowMessage(FeePaymentLocalizedResources.ErrorData);
                        GridView gridView1 = (GridView)MainView;
                        item.APFeePaymentFeeConfigTaxPercent = Convert.ToDecimal(gridView1.ActiveEditor.OldEditValue.ToString());
                        return;
                    }
                    item.APFeePaymentFeeConfigTaxAmount = (item.APFeePaymentFeeConfigAmount * item.APFeePaymentFeeConfigTaxPercent) / 100;
                    ((FeePaymentModule)Screen.Module).UpdateTotalAmount();
                }
                else if (e.Column.FieldName == "APFeePaymentFeeConfigTaxAmount")
                {
                    if (!string.IsNullOrEmpty(item.APFeePaymentFeeConfigNo))
                    {
                        BOSApp.ShowMessage(FeePaymentLocalizedResources.ErrorData);
                        GridView gridView1 = (GridView)MainView;
                        item.APFeePaymentFeeConfigTaxAmount = Convert.ToDecimal(gridView1.ActiveEditor.OldEditValue.ToString());
                        return;
                    }
                    if (item.APFeePaymentFeeConfigAmount > 0)
                        item.APFeePaymentFeeConfigTaxPercent = item.APFeePaymentFeeConfigTaxAmount / item.APFeePaymentFeeConfigAmount * 100;
                    else
                        item.APFeePaymentFeeConfigTaxPercent = 0;
                    ((FeePaymentModule)Screen.Module).UpdateTotalAmount();
                }
                else if (e.Column.FieldName != "APFeePaymentFeeConfigTaxAmount")
                {
                    ((FeePaymentModule)Screen.Module).ChangeFeeConfig(item);
                }
                if (e.Column.FieldName == "ACObjectAccessKey")
                {
                    string[] objArr = item.ACObjectAccessKey.ToString().Split(';');
                    if (objArr.Length == 2)
                    {
                        int objectID = int.Parse(objArr[0]);
                        ACObjectsController objectController = new ACObjectsController();
                        ACObjectsInfo objObjectsInfo = objectController.GetObjectByIDAndType(objectID, objArr[1]);
                        if (objObjectsInfo != null)
                        {
                            item.FK_ACObjectID = objObjectsInfo.ACObjectID;
                            item.APObjectType = objObjectsInfo.ACObjectType;
                            item.APFeePaymentFeeConfigObjectName = objObjectsInfo.ACObjectName;
                            item.APFeePaymentFeeConfigObjectTaxNumber = objObjectsInfo.ACObjectTaxNumber;
                        }
                    }
                }
                if (e.Column.FieldName == "FK_ICFeeConfigID")
                {
                    ICFeeConfigsController feeConfigController = new ICFeeConfigsController();
                    ICFeeConfigsInfo feeConfig = (ICFeeConfigsInfo)feeConfigController.GetObjectByID(item.FK_ICFeeConfigID);
                    item.APFeePaymentFeeConfigTaxPercent = feeConfig.ICFeeConfigVAT;
                }
                if (e.Column.FieldName == "FK_ACEInvoiceTypeID")
                {
                    ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
                    ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByID(item.FK_ACEInvoiceTypeID);
                    if (objEInvoiceTypesInfo != null)
                    {
                        item.APFeePaymentFeeConfigVATFormNo = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
                        item.APFeePaymentFeeConfigVATSymbol = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
                    }
                    else
                    {
                        item.APFeePaymentFeeConfigVATFormNo = string.Empty;
                        item.APFeePaymentFeeConfigVATSymbol = string.Empty;
                    }
                    entity.UpdateMainObjectBindingSource();
                }
                if (e.Column.FieldName == "FK_GETerminalID")
                {
                    if (!string.IsNullOrEmpty(item.APFeePaymentFeeConfigNo))
                    {
                        BOSApp.ShowMessage(FeePaymentLocalizedResources.ErrorData);
                        GridView gridView1 = (GridView)MainView;
                        item.FK_GETerminalID = Convert.ToInt32(gridView1.ActiveEditor.OldEditValue.ToString());
                        return;
                    }
                }
                if (e.Column.FieldName == "FK_GEContainerID")
                {
                    if (!string.IsNullOrEmpty(item.APFeePaymentFeeConfigNo))
                    {
                        BOSApp.ShowMessage(FeePaymentLocalizedResources.ErrorData);
                        GridView gridView1 = (GridView)MainView;
                        item.FK_GEContainerID = Convert.ToInt32(gridView1.ActiveEditor.OldEditValue.ToString());
                        return;
                    }
                }
                if (e.Column.FieldName == "FK_GEUnitCostID")
                {
                    if (!string.IsNullOrEmpty(item.APFeePaymentFeeConfigNo))
                    {
                        BOSApp.ShowMessage(FeePaymentLocalizedResources.ErrorData);
                        GridView gridView1 = (GridView)MainView;
                        item.FK_GEUnitCostID = Convert.ToInt32(gridView1.ActiveEditor.OldEditValue.ToString());
                        return;
                    }
                }
                item.APFeePaymentFeeConfigTotalAmount = item.APFeePaymentFeeConfigTaxAmount + item.APFeePaymentFeeConfigAmount;
                (entity.Module as FeePaymentModule).ChangeItemFromFeePaymentFeeConfigsList();
            }
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);
            GridView gridView = (GridView)sender;
            APFeePaymentFeeConfigsInfo objFeePaymentFeeConfigsInfo = (APFeePaymentFeeConfigsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            objFeePaymentFeeConfigsInfo.APFeePaymentFeeConfigType = FeePaymentFeeConfigType.Purchase.ToString();
        }
    }
}
