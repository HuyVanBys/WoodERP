using BOSCommon.Constants;
using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.ElectronicInvoiceBKAV
{
    public partial class EInvoiceDetailsGridControl : BOSGridControl
    {
        public class ACEInvoiceDetailVATCode
        {
            public decimal ACEInvoiceDetailVATCodeValue { get; set; }
            public string ACEInvoiceDetailVATCodeCap { get; set; }
        }
        public override void InitGridControlDataSource()
        {
            ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EInvoiceDetailsList;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
            {
                if (col.FieldName == "VatPercentage" || col.FieldName == "VatAmount" || col.FieldName == "ACEInvoiceDetailTotalAmount" || col.FieldName == "ACEInvoiceDetailReferenceNo")
                    col.OptionsColumn.AllowEdit = false;
                else
                {
                    col.OptionsColumn.AllowEdit = true;
                    if (col.FieldName == "UnitCode")
                    {
                        RepositoryItemLookUpEdit rpMeasureUnit = new RepositoryItemLookUpEdit();
                        rpMeasureUnit.DisplayMember = "ICMeasureUnitName";
                        rpMeasureUnit.ValueMember = "ICMeasureUnitName";
                        rpMeasureUnit.NullText = string.Empty;
                        rpMeasureUnit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "Đơn vị tính"));
                        DataSet ds = BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] as DataSet;
                        if (ds == null)
                        {
                            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
                            rpMeasureUnit.DataSource = objMeasureUnitsController.GetAllAliveMeasureUnit();
                        }
                        else
                        {
                            rpMeasureUnit.DataSource = ds.Tables[0];
                        }
                        rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);
                        col.ColumnEdit = rpMeasureUnit;
                    }
                    else if (col.FieldName == "ItemCode")
                    {
                        RepositoryItemLookUpEdit rpItemCode = new RepositoryItemLookUpEdit();
                        rpItemCode.DisplayMember = "ICProductNo";
                        rpItemCode.ValueMember = "ICProductNo";
                        rpItemCode.NullText = string.Empty;
                        rpItemCode.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã sản phẩm"));
                        rpItemCode.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên sản phẩm"));
                        rpItemCode.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả"));
                        rpItemCode.Columns.Add(new LookUpColumnInfo("ICProductPrice01", "Giá bán"));
                        DataSet ds = BOSApp.LookupTables[TableName.ICProductsTableName] as DataSet;
                        if (ds == null)
                        {
                            ICProductsController objProductsController = new ICProductsController();
                            rpItemCode.DataSource = objProductsController.GetProductsDataSourceForLookupControl(BOSApp.CurrentCompanyInfo.CSCompanyID);
                        }
                        else
                        {
                            rpItemCode.DataSource = ds.Tables[0];
                        }
                        rpItemCode.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpItemCode_QueryPopUp);
                        col.ColumnEdit = rpItemCode;
                    }
                    if (col.FieldName == "ACEInvoiceDetailVATCode")
                    {
                        col.OptionsColumn.AllowEdit = false;
                    }
                    else if (col.FieldName == "UnitPrice")
                    {
                        col.DisplayFormat.FormatType = FormatType.Numeric;
                        col.DisplayFormat.FormatString = "{0:n2}";
                    }
                    else if (col.FieldName == "Quantity")
                    {
                        col.DisplayFormat.FormatType = FormatType.Numeric;
                        col.DisplayFormat.FormatString = "{0:n3}";
                    }
                }

            }
            return gridView;
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            DataSet ds = BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] as DataSet;
            if (ds == null)
            {
                ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
                lke.Properties.DataSource = objMeasureUnitsController.GetAllAliveMeasureUnit();
            }
            else
            {
                lke.Properties.DataSource = ds.Tables[0];
            }
        }

        private void rpItemCode_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            DataSet ds = BOSApp.LookupTables[TableName.ICProductsTableName] as DataSet;
            if (ds == null)
            {
                ICProductsController objProductsController = new ICProductsController();
                lke.Properties.DataSource = objProductsController.GetProductsDataSourceForLookupControl(BOSApp.CurrentCompanyInfo.CSCompanyID);
            }
            else
            {
                lke.Properties.DataSource = ds.Tables[0];
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = ComponentLocalizedResources.TotalAmount;
            column.FieldName = "ACEInvoiceDetailTotalAmount";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n0}";
            gridView.Columns.Add(column);
        }

        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            ElectronicInvoiceBKAVEntities entity = (ElectronicInvoiceBKAVEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ACEInvoiceDetailsInfo objEInvoiceDetailsInfo = entity.EInvoiceDetailsList[entity.EInvoiceDetailsList.CurrentIndex];
            if (objEInvoiceDetailsInfo != null)
            {
                if (e.Column.FieldName == "UnitPrice" || e.Column.FieldName == "Quantity" || e.Column.FieldName == "ACEInvoiceDetailVATCode")
                {
                    ((ElectronicInvoiceBKAVModule)Screen.Module).UpdateTotalAmount();
                }
                else if (e.Column.FieldName == "UnitCode")
                {
                    objEInvoiceDetailsInfo.UnitName = objEInvoiceDetailsInfo.UnitCode;
                }
                else if (e.Column.FieldName == "UnitName")
                {
                    objEInvoiceDetailsInfo.UnitCode = objEInvoiceDetailsInfo.UnitName;
                }
                else if (e.Column.FieldName == "ItemCode")
                {
                    ((ElectronicInvoiceBKAVModule)Screen.Module).ChangeItemCode(objEInvoiceDetailsInfo);
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ElectronicInvoiceBKAVModule)Screen.Module).RemoveSelectedItem();
            }
        }
    }
}
