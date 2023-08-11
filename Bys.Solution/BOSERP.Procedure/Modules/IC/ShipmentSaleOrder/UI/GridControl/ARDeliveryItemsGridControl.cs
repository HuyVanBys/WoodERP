using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.ShipmentSaleOrder
{
    public class ARDeliveryPlanItemsGridControl : BOSGridControl
    {

        public void InvalidateDataSource(List<ARDeliveryPlanItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["FK_ARDeliveryPlanID"];
            if (column != null)
            {
                column.Group();
            }
            gridView.ExpandAllGroups();
            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
                gridView.Columns.Remove(column);
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICModelDetailID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ICModelDetailsController objModelDetailsController = new ICModelDetailsController();
                    e.DisplayText = objModelDetailsController.GetObjectNameByID(matchCodeID); ;
                }
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "ARListOfSalesChannelType")
            {
                if (e.Value != null)
                {
                    string value = e.Value.ToString();
                    e.DisplayText = BOSApp.GetDisplayTextFromConfigValue("ListOfSalesChannelType", value);
                }    
            }    
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "ARSaleOrderName";
            column.Caption = "Mã đơn hàng nội bộ";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMBatchProductNo";
            column.Caption = "Lệnh sản xuất";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARListOfSalesChannelType";
            column.Caption = "Kênh bán hàng";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductName2";
            column.Caption = "Tên SP tiếng việt";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
