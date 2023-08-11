using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BOSComponent;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using System.Data;
using Localization;
using DevExpress.XtraEditors.Repository;
using BOSCommon;
using DevExpress.Utils;
using System.Drawing;

namespace BOSERP.Modules.Report
{
    public class RP214MMBatchProductItemsGridControl : BOSGridControl
    {        
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            //base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();

            column.FieldName = "MMBatchProductNo";
            column.Caption = "Tên LSX";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductDate";
            column.Caption = "Ngày Chứng từ";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductDesc";
            column.Caption = "Mô tả LSX";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductNo";
            column.Caption = "Mã sản phẩm";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ACObjectName";
            column.Caption = "Đối tượng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICMeasureUnitName";
            column.Caption = "Đơn vị tính";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICDepartmentName";
            column.Caption = "Ngành hàng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICDepartmentNo";
            column.Caption = "Mã ngành hàng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductGroupName";
            column.Caption = "Nhóm hàng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.FieldName = "ICProductGroupNo";
            column.Caption = "Mã nhóm hàng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderNo";
            column.Caption = "Mã đơn hàng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARSaleOrderDeliveryDate";
            column.Caption = "Ngày giao hàng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICShipmentItemProductQty";
            column.Caption = "SL đã giao";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductStatusName";
            column.Caption = "Trạng thái";
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n3}";
            column.Visible = true;
            gridView.Columns.Add(column);
           
        }
    }
}
