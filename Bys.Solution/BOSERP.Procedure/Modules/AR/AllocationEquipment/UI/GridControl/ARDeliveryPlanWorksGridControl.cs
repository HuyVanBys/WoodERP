using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.AllocationEquipment
{
    public class ARDeliveryPlanWorksGridControl : ItemGridControl
    {
        public enum DeliveryPlanWorkColumn
        {
            ARDeliveryPlanWorkProductNo,
            ARDeliveryPlanWorkProductName,
            ARDeliveryPlanWorkProductDesc,
        };

        public void InvalidateDataSource(BOSList<ARDeliveryPlanWorksInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = DeliveryPlanLocalizedResources.ARDeliveryPlanWorkProductNoCaption;
            column.FieldName = DeliveryPlanWorkColumn.ARDeliveryPlanWorkProductNo.ToString();
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = DeliveryPlanLocalizedResources.ARDeliveryPlanWorkProductNameCaption;
            column.FieldName = DeliveryPlanWorkColumn.ARDeliveryPlanWorkProductName.ToString();
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = DeliveryPlanLocalizedResources.ARDeliveryPlanWorkProductDescCaption;
            column.FieldName = DeliveryPlanWorkColumn.ARDeliveryPlanWorkProductDesc.ToString();
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ARDeliveryPlanID")
            {
                if (e.Value != null)
                {
                    ARDeliveryPlansController objDeliveryPlansController = new ARDeliveryPlansController();
                    ARDeliveryPlansInfo objDeliveryPlansInfo = (ARDeliveryPlansInfo)objDeliveryPlansController.GetObjectByID(int.Parse(e.Value.ToString()));
                    if (objDeliveryPlansInfo != null)
                    {
                        e.DisplayText = objDeliveryPlansInfo.ARDeliveryPlanNo;
                    }
                }
            }
        }
    }
}
