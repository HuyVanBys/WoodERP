using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System;

namespace BOSERP.Modules.SaleForecast
{
    public class ARSaleOrderItemsGridControl : BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã SaleForecast";
            column.FieldName = "ARSaleForecastNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Khách hàng";
            column.FieldName = "ARCustomerName";
            gridView.Columns.Add(column);
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ARCustomerID")
            {
                if (e.Value != null)
                {
                    ARCustomersController objCustomersController = new ARCustomersController();
                    ARCustomersInfo objCustomersInfo = objCustomersController.GetObjectByID(Convert.ToInt32(e.Value)) as ARCustomersInfo;
                    if (objCustomersInfo != null)
                    {
                        e.DisplayText = objCustomersInfo.ARCustomerName;
                    }
                }
            }
        }
    }
}
