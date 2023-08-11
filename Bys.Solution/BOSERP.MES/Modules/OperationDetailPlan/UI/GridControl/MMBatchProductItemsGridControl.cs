using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlan
{
    public partial class MMBatchProductItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.BatchProductItemsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = OperationDetailPlanLocalizedResources.Selected;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            if (gridView.Columns["FK_ARProductionPlanningID"] != null)
            {
                gridView.Columns["FK_ARProductionPlanningID"].Visible = true;
                gridView.Columns["FK_ARProductionPlanningID"].VisibleIndex = 2;
                gridView.Columns["FK_ARProductionPlanningID"].Group();
                gridView.Columns["FK_ARProductionPlanningID"].GroupIndex = 1;
            }

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = OperationDetailPlanLocalizedResources.MMBatchProductNoMessage;
            column.FieldName = "MMBatchProductNo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = OperationDetailPlanLocalizedResources.ARSaleOrderNoMessage;
            column.FieldName = "ARSaleOrderNo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Xưởng";
            column.FieldName = "FK_MMWorkShopID";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "STT SX";
            column.FieldName = "MMProductionNormItemSortOrder";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = OperationDetailPlanLocalizedResources.MMOperationDetailPlanItemProductSerialMessage;
            column.FieldName = "MMOperationDetailPlanItemProductSerial";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 7;

            gridView.Columns.Add(column);

            if (gridView.Columns["MMBatchProductItemProductDeliveryDate"] != null)
            {
                gridView.Columns["MMBatchProductItemProductDeliveryDate"].Visible = true;
                gridView.Columns["MMBatchProductItemProductDeliveryDate"].VisibleIndex = 8;
            }

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = OperationDetailPlanLocalizedResources.ProductForBatchNoMessage;
            column.FieldName = "ProductForBatchNo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = OperationDetailPlanLocalizedResources.ProductNoMessage;
            column.FieldName = "ICProductNo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = OperationDetailPlanLocalizedResources.ProductNameMessage;
            column.FieldName = "ICProductName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);


            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = OperationDetailPlanLocalizedResources.MMOperationNameMessage;
            column.FieldName = "MMOperationName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 12;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = OperationDetailPlanLocalizedResources.BatchProductItemTotalQtyMessage;
            column.FieldName = "MMOperationDetailPlanItemProductQty";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 13;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = OperationDetailPlanLocalizedResources.MMOperationDetailPlanItemCompletedProductCountMessage;
            column.FieldName = "MMOperationDetailPlanItemPlanProductQty";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 14;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = OperationDetailPlanLocalizedResources.MMOperationDetailPlanItemProductHeightMessage;
            column.FieldName = "MMOperationDetailPlanItemProductHeight";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 15;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = OperationDetailPlanLocalizedResources.MMOperationDetailPlanItemProductWidthMessage;
            column.FieldName = "MMOperationDetailPlanItemProductWidth";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 16;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = OperationDetailPlanLocalizedResources.MMOperationDetailPlanItemProductLengthMessage;
            column.FieldName = "MMOperationDetailPlanItemProductLength";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 17;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = OperationDetailPlanLocalizedResources.MMOperationDetailPlanItemProductWoodTypeMessage;
            column.FieldName = "MMOperationDetailPlanItemProductWoodType";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 18;
            gridView.Columns.Add(column);

        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();


            return gridView;
        }
    }
}
