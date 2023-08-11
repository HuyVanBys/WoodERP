using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Customer
{
    public partial class ARCustomerInfoContactsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CustomerEntities entity = (CustomerEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARCustomerInfoContactList;
            DataSource = bds;
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                //if (column.FieldName == "FK_APSupplierID")
                //{
                //    RepositoryItemBOSLookupEdit repProductionNorm = new RepositoryItemBOSLookupEdit();
                //    repProductionNorm.DisplayMember = "APSupplierNo";
                //    repProductionNorm.ValueMember = "APSupplierID";
                //    repProductionNorm.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //    repProductionNorm.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //    repProductionNorm.NullText = string.Empty;
                //    repProductionNorm.Columns.Add(new LookUpColumnInfo("APSupplierNo", "NCC"));
                //    repProductionNorm.Columns.Add(new LookUpColumnInfo("APSupplierName", "NCC"));
                //    repProductionNorm.QueryPopUp += new System.ComponentModel.CancelEventHandler(SupplierName_QueryPopUp);
                //    column.ColumnEdit = repProductionNorm;
                //}
            }
            GridColumn column1 = gridView.Columns["ACObjectAccessKey"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACObjectNo";
                repositoryItemLookUpEdit.ValueMember = "ACObjectAccessKey";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectNo", "Mã đối tượng"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectName", "Tên đối tượng"));
                repositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
                repositoryItemLookUpEdit.DataSource = BOSApp.AccountingObjects;
                repositoryItemLookUpEdit.PopupFormMinSize = new System.Drawing.Size(300, 0);
                column1.ColumnEdit = repositoryItemLookUpEdit;
            }
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }
        //public void SupplierName_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    APSuppliersController objSuppliersController = new APSuppliersController();
        //    List<APSuppliersInfo> suppliersList = new List<APSuppliersInfo>();
        //    APSuppliersInfo objSuppliersInfo = new APSuppliersInfo();
        //    objSuppliersInfo.APSupplierID = 0;
        //    DataSet ds = (DataSet)BOSApp.LookupTables[TableName.APSuppliersTableName];
        //    if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
        //    {
        //        ds = BOSApp.GetLookupTableData(TableName.APSuppliersTableName);
        //        GELookupTablesInfo lookupTable = BOSApp.LookupTableList.Where(t => t.GELookupTableName == TableName.APSuppliersTableName).FirstOrDefault();
        //        if (lookupTable != null)
        //        {
        //            BOSApp.LookupTables.Add(TableName.APSuppliersTableName, ds);
        //            BOSApp.LookupTablesUpdatedDate.Add(TableName.APSuppliersTableName, DateTime.Now);
        //            BOSApp.LookupTableObjects.Add(TableName.APSuppliersTableName, lookupTable);
        //        }
        //    }
        //    suppliersList = (List<APSuppliersInfo>)objSuppliersController.GetListFromDataSet(ds);
        //    if (suppliersList != null)
        //    {
        //        suppliersList.Insert(0, objSuppliersInfo);
        //        lookUpEdit.Properties.DataSource = suppliersList;
        //    }
        //    lookUpEdit.Properties.DisplayMember = "APSupplierNo";
        //    lookUpEdit.Properties.ValueMember = "APSupplierID";
        //}
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((CustomerModule)Screen.Module).RemoveSelectedItemFromCustomerInfoContactList();
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_APSupplierID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche(TableName.APSuppliersTableName, "APSupplierID", int.Parse(e.Value.ToString()), "APSupplierNo");
                }
            }
            if (e.Column.FieldName == "ACObjectAccessKey")
            {
                if (e.Value != null)
                {
                    ACObjectsController objObjectsController = new ACObjectsController();
                    ACObjectsInfo objObjectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o1 => o1.ACObjectAccessKey == e.Value.ToString());
                    if (objObjectsInfo != null)
                    {
                        e.DisplayText = objObjectsInfo.ACObjectNo;
                    }
                    else
                    {
                        e.DisplayText = "";
                    }
                }
                else
                {
                    e.DisplayText = "";
                }
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            CustomerEntities entity = (CustomerEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (((CustomerModule)Screen.Module).Toolbar.IsNullOrNoneAction())
            {
                MessageBox.Show("Vui lòng nhấn nút Sửa!",
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (entity.ARCustomerInfoContactList.Count() > 0)
            {
                GridView gridView = (GridView)MainView;
                ARCustomerInfoContactsInfo item = entity.ARCustomerInfoContactList[entity.ARCustomerInfoContactList.CurrentIndex];
                if (e.Column.FieldName == "ARCustomerInfoContactCheck")
                {
                    if (item.ARCustomerInfoContactCheck == true)
                    {
                        entity.ARCustomerInfoContactList.ForEach(a =>
                            {
                                a.ARCustomerInfoContactCheck = false;
                            });
                        item.ARCustomerInfoContactCheck = true;
                    }
                    else
                    {
                        item.ARCustomerInfoContactCheck = false;
                    }
                    entity.ARCustomerInfoContactList.GridControl.RefreshDataSource();
                }
                if (e.Column.FieldName == "ACObjectAccessKey")
                {
                    ((CustomerModule)Screen.Module).ChangeObjectItem(item, e.Value.ToString());
                }
            }
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            CustomerEntities entity = (CustomerEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (entity.ARCustomerInfoContactList.CurrentIndex > 0)
            {
                ARCustomerInfoContactsInfo item = entity.ARCustomerInfoContactList[entity.ARCustomerInfoContactList.CurrentIndex];
                if (e.Value != null && item != null)
                {
                    if (gridView.FocusedColumn.FieldName != "ACObjectAccessKey"
                            && gridView.FocusedColumn.FieldName != "ARCustomerInfoContactCheck"
                            && gridView.FocusedColumn.FieldName != "ARCustomerInfoContactCommissionPercent")
                    {
                        if (item.ACObjectAccessKey != string.Empty)
                        {
                            e.ErrorText = "Đã chọn đối tượng, không được thay đổi thông tin.";
                            e.Valid = false;
                        }
                    }
                }
            }
        }
    }
}
