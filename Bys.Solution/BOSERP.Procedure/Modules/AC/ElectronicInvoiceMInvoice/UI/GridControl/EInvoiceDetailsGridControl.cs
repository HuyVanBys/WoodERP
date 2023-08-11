using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using BOSCommon;
using Localization;
using DevExpress.XtraGrid.Views.Base;
using System.Data;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Drawing;
using BOSCommon.Constants;

namespace BOSERP.Modules.ElectronicInvoiceMInvoice
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
            ElectronicInvoiceMInvoiceEntities entity = (ElectronicInvoiceMInvoiceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
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
                if (col.FieldName == "VatAmount" || col.FieldName == "ACEInvoiceDetailTotalAmount")
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
                        RepositoryItemBOSLookupEdit rpItemCode = new RepositoryItemBOSLookupEdit();
                        rpItemCode.DisplayMember = "ICProductNo";
                        rpItemCode.ValueMember = "ICProductNo";
                        rpItemCode.TextEditStyle = TextEditStyles.Standard;
                        rpItemCode.NullText = string.Empty;
                        rpItemCode.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã sản phẩm", 100));
                        rpItemCode.Columns.Add(new LookUpColumnInfo("ICProductNoOfOldSys", "Mã HTC", 100));
                        rpItemCode.Columns.Add(new LookUpColumnInfo("ICProductCustomerNumber", "Mã đối tác", 100));
                        rpItemCode.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên sản phẩm", 350));
                        rpItemCode.PopupFormSize = new Size(850, 100);
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
                    else if (col.FieldName == "DiscountPercent")
                    {
                        col.DisplayFormat.FormatType = FormatType.Numeric;
                        col.DisplayFormat.FormatString = "{0:n2}";
                    }
                    else if (col.FieldName == "DiscountAmount")
                    {
                        col.DisplayFormat.FormatType = FormatType.Numeric;
                        col.DisplayFormat.FormatString = "{0:n2}";
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
            column.Caption = "Thành tiền";
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
            ACEInvoiceDetailsInfo objEInvoiceDetailsInfo = (ACEInvoiceDetailsInfo)gridView.GetRow(e.RowHandle);
            if (objEInvoiceDetailsInfo != null)
            {
                if (e.Column.FieldName == "DiscountAmount")
                {
                    objEInvoiceDetailsInfo.DiscountPercent = objEInvoiceDetailsInfo.DiscountAmount / (objEInvoiceDetailsInfo.UnitPrice * objEInvoiceDetailsInfo.Quantity) * 100;
                    ((ElectronicInvoiceMInvoiceModule)Screen.Module).UpdateTotalAmount();
                }
                if (e.Column.FieldName == "UnitPrice" || e.Column.FieldName == "Quantity" || e.Column.FieldName == "DiscountPercent")
                {
                    ((ElectronicInvoiceMInvoiceModule)Screen.Module).UpdateTotalAmount();
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
                    ((ElectronicInvoiceMInvoiceModule)Screen.Module).ChangeItemCode(objEInvoiceDetailsInfo);
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ElectronicInvoiceMInvoiceModule)Screen.Module).RemoveSelectedItem();
            }
        }
    }
}
