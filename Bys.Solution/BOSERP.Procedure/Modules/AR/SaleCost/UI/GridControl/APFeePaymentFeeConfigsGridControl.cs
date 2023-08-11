using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.AP.FeePayment.Localization;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;


namespace BOSERP.Modules.SaleCost
{
    public partial class APFeePaymentFeeConfigsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SaleCostEntities entity = (SaleCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.FeePaymentFeeConfigList;
            DataSource = bds;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SaleCostModule)Screen.Module).RemoveSelectedFeeConfig();
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
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICFeeConfigName";
                repositoryItemLookUpEdit.ValueMember = "ICFeeConfigID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICFeeConfigName", FeePaymentLocalizedResources.ICFeeConfigName));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                Column.ColumnEdit = repositoryItemLookUpEdit;
                Column.OptionsColumn.AllowEdit = true;
            }
            Column = gridView.Columns["FK_ACEInvoiceTypeID"];
            if (Column != null)
            {
                Column.OptionsColumn.AllowEdit = true;
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
                Column.ColumnEdit = repositoryItemLookUpEdit;
                Column.Caption = "Mã hóa đơn GTGT";
            }
            Column = gridView.Columns["APFeePaymentFeeConfigTotalAmount"];
            if (Column != null)
            {
                Column.OptionsColumn.AllowEdit = false;
            }
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null
                && e.Column.FieldName == "FK_ICFeeConfigID")
            {
                int id = 0;
                if (int.TryParse(e.Value.ToString(), out id))
                {
                    ICFeeConfigsController feeConfigController = new ICFeeConfigsController();
                    ICFeeConfigsInfo feeConfig = (ICFeeConfigsInfo)feeConfigController.GetObjectByID(id);
                    if (feeConfig != null)
                    {
                        e.DisplayText = feeConfig.ICFeeConfigName;
                    }
                    else
                    {
                        e.DisplayText = string.Empty;
                    }
                }
            }
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
        void repositoryItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;

            ICFeeConfigsController feeConfigController = new ICFeeConfigsController();
            List<ICFeeConfigsInfo> feeConfigList = feeConfigController.GetAllFeeConfig();
            /*List<ICFeeConfigsInfo> dataList = new List<ICFeeConfigsInfo>();
            dataList.Add(new ICFeeConfigsInfo());

            SaleCostEntities entity = (SaleCostEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.FeePaymentInvoiceInList != null
                && entity.FeePaymentInvoiceInList.Count > 0)
            {
                List<ICFeeConfigsInfo> filterList = new List<ICFeeConfigsInfo>();
                List<string> distinctTerminal = entity.FeePaymentInvoiceInList.Select(t => t.APTerminalType).Distinct().ToList();

                filterList = feeConfigList.Where(t => distinctTerminal.Contains(t.ICTerminalType)).ToList();
                if (filterList != null && filterList.Count > 0)
                {
                    dataList.AddRange(filterList);
                }
            }*/
            //lookUpEdit.Properties.DataSource = dataList;
            lookUpEdit.Properties.DataSource = feeConfigList;
            lookUpEdit.Properties.DisplayMember = "ICFeeConfigName";
            lookUpEdit.Properties.ValueMember = "ICFeeConfigID";
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            SaleCostEntities entity = (SaleCostEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.FeePaymentFeeConfigList.CurrentIndex >= 0)
            {
                entity.ModuleObjects[TableName.APFeePaymentFeeConfigsTableName] = (APFeePaymentFeeConfigsInfo)entity.FeePaymentFeeConfigList[entity.FeePaymentFeeConfigList.CurrentIndex];
                APFeePaymentFeeConfigsInfo item = (APFeePaymentFeeConfigsInfo)entity.FeePaymentFeeConfigList[entity.FeePaymentFeeConfigList.CurrentIndex];
                if (e.Column.FieldName == "APFeePaymentFeeConfigTaxPercent")
                {
                    item.APFeePaymentFeeConfigTaxAmount = (item.APFeePaymentFeeConfigAmount * item.APFeePaymentFeeConfigTaxPercent) / 100;
                }
                else if (e.Column.FieldName == "APFeePaymentFeeConfigTaxAmount")
                {
                    if (item.APFeePaymentFeeConfigAmount > 0)
                    {
                        item.APFeePaymentFeeConfigTaxPercent = item.APFeePaymentFeeConfigTaxAmount / item.APFeePaymentFeeConfigAmount * 100;
                    }
                    else
                        item.APFeePaymentFeeConfigTaxPercent = 0;
                }
                else if (e.Column.FieldName != "APFeePaymentFeeConfigTaxAmount")
                {
                    ((SaleCostModule)Screen.Module).ChangeFeeConfig(item);
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
                        item.FK_ACEInvoiceTypeID = objEInvoiceTypesInfo.ACEInvoiceTypeID;
                    }
                    else
                    {
                        item.APFeePaymentFeeConfigVATFormNo = string.Empty;
                        item.APFeePaymentFeeConfigVATSymbol = string.Empty;
                    }
                    entity.UpdateMainObjectBindingSource();
                }
                item.APFeePaymentFeeConfigTotalAmount = item.APFeePaymentFeeConfigTaxAmount + item.APFeePaymentFeeConfigAmount;
                (entity.Module as SaleCostModule).ChangeItemFromFeePaymentFeeConfigsList();
            }
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);
            GridView gridView = (GridView)sender;
            APFeePaymentFeeConfigsInfo objFeePaymentFeeConfigsInfo = (APFeePaymentFeeConfigsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            objFeePaymentFeeConfigsInfo.APFeePaymentFeeConfigType = FeePaymentFeeConfigType.Sale.ToString();
        }
    }
}
