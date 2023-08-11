using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.BillOfLading
{
    public partial class APBillOfLadingItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            BillOfLadingEntities entity = (BillOfLadingEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.BillOfLadingItemList;
            this.DataSource = bds;
        }
        public string[] columnArr;
        public void ReLocationColumn(string[] columns, GridView gridView)
        {
            columnArr = columns;
            InitDefaultGridColumnsVisibleIndex(gridView);
        }
        protected override void InitDefaultGridColumnsVisibleIndex(GridView gridView)
        {
            if (columnArr != null && columnArr.Length > 0)
            {
                foreach (GridColumn columnedit1 in gridView.Columns)
                {
                    columnedit1.Visible = false;
                }
                GridColumn columnedit;
                int index = 1;
                foreach (string column in columnArr)
                {
                    columnedit = gridView.Columns[column];
                    if (columnedit != null)
                    {
                        columnedit.Visible = true;
                        columnedit.VisibleIndex = index++;
                    }
                }

                gridView.BestFitColumns();
            }
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;

            InitColumnSummary("APBillOfLadingItemDOFee", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("APBillOfLadingItemCleaningContFee", DevExpress.Data.SummaryItemType.Sum);


            return gridView;
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            BillOfLadingEntities entity = (BillOfLadingEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            APBillOfLadingsInfo bol = (APBillOfLadingsInfo)entity.MainObject;
            if (entity.BillOfLadingItemList.CurrentIndex >= 0)
            {
                decimal exrate = bol.APBillOfLadingExchangeRate;
                APBillOfLadingItemsInfo item = entity.BillOfLadingItemList[entity.BillOfLadingItemList.CurrentIndex];
                if (e.Column.FieldName == "APBillOfLadingItemTotalCostExchange")
                {
                    item.APBillOfLadingItemTotalCost = item.APBillOfLadingItemProductUnitCost
                                                                * item.APBillOfLadingItemProductQty;

                    item.APBillOfLadingItemProductUnitCostExchange = item.APBillOfLadingItemProductUnitCost * exrate;

                    //item.APBillOfLadingItemTotalCostExchange = item.APBillOfLadingItemTotalCost * exrate;

                    item.APBillOfLadingItemImportTaxAmount = item.APBillOfLadingItemImportTaxPercent
                                                                * item.APBillOfLadingItemTotalCostExchange / 100;

                    item.APBillOfLadingItemConsumptionTaxAmount = item.APBillOfLadingItemConsumptionTaxPercent
                                                                * (item.APBillOfLadingItemTotalCostExchange
                                                                + item.APBillOfLadingItemImportTaxAmount) / 100;

                    item.APBillOfLadingItemEnviromentTaxAmount = item.APBillOfLadingItemEnviromentTaxPercent
                                                               * item.APBillOfLadingItemTotalCostExchange / 100;

                    item.APBillOfLadingItemVATTaxAmount = item.APBillOfLadingItemVATTaxPercent
                                                               * (item.APBillOfLadingItemTotalCostExchange
                                                               + item.APBillOfLadingItemImportTaxAmount
                                                               + item.APBillOfLadingItemConsumptionTaxAmount
                                                               + item.APBillOfLadingItemEnviromentTaxAmount) / 100;


                }
                else if (e.Column.FieldName == "APBillOfLadingItemImportTaxPercent")
                {
                    item.APBillOfLadingItemImportTaxAmount = item.APBillOfLadingItemImportTaxPercent
                                                                * item.APBillOfLadingItemTotalCostExchange / 100;

                    item.APBillOfLadingItemConsumptionTaxAmount = item.APBillOfLadingItemConsumptionTaxPercent
                                                                * (item.APBillOfLadingItemTotalCostExchange
                                                                + item.APBillOfLadingItemImportTaxAmount) / 100;

                    item.APBillOfLadingItemVATTaxAmount = item.APBillOfLadingItemVATTaxPercent
                                                              * (item.APBillOfLadingItemTotalCostExchange
                                                              + item.APBillOfLadingItemImportTaxAmount
                                                              + item.APBillOfLadingItemConsumptionTaxAmount
                                                              + item.APBillOfLadingItemEnviromentTaxAmount) / 100;
                }
                else if (e.Column.FieldName == "APBillOfLadingItemConsumptionTaxPercent")
                {
                    item.APBillOfLadingItemConsumptionTaxAmount = item.APBillOfLadingItemConsumptionTaxPercent
                                                                * (item.APBillOfLadingItemTotalCostExchange
                                                                + item.APBillOfLadingItemImportTaxAmount) / 100;

                    item.APBillOfLadingItemVATTaxAmount = item.APBillOfLadingItemVATTaxPercent
                                                              * (item.APBillOfLadingItemTotalCostExchange
                                                              + item.APBillOfLadingItemImportTaxAmount
                                                              + item.APBillOfLadingItemConsumptionTaxAmount
                                                              + item.APBillOfLadingItemEnviromentTaxAmount) / 100;

                }
                else if (e.Column.FieldName == "APBillOfLadingItemEnviromentTaxPercent")
                {
                    item.APBillOfLadingItemEnviromentTaxAmount = item.APBillOfLadingItemEnviromentTaxPercent
                                                                  * item.APBillOfLadingItemTotalCostExchange / 100;

                    item.APBillOfLadingItemVATTaxAmount = item.APBillOfLadingItemVATTaxPercent
                                                               * (item.APBillOfLadingItemTotalCostExchange
                                                               + item.APBillOfLadingItemImportTaxAmount
                                                               + item.APBillOfLadingItemConsumptionTaxAmount
                                                               + item.APBillOfLadingItemEnviromentTaxAmount) / 100;
                }
                else if (e.Column.FieldName == "APBillOfLadingItemVATTaxPercent")
                {
                    item.APBillOfLadingItemVATTaxAmount = item.APBillOfLadingItemVATTaxPercent
                                                              * (item.APBillOfLadingItemTotalCostExchange
                                                              + item.APBillOfLadingItemImportTaxAmount
                                                              + item.APBillOfLadingItemConsumptionTaxAmount
                                                              + item.APBillOfLadingItemEnviromentTaxAmount) / 100;
                }
                else if (e.Column.FieldName == "APBillOfLadingItemImportTaxAmount")
                {
                    item.APBillOfLadingItemImportTaxPercent = item.APBillOfLadingItemImportTaxAmount
                                                                / item.APBillOfLadingItemTotalCostExchange * 100;

                    item.APBillOfLadingItemConsumptionTaxAmount = item.APBillOfLadingItemConsumptionTaxPercent
                                                                * (item.APBillOfLadingItemTotalCostExchange
                                                                + item.APBillOfLadingItemImportTaxAmount) / 100;

                    item.APBillOfLadingItemVATTaxAmount = item.APBillOfLadingItemVATTaxPercent
                                                              * (item.APBillOfLadingItemTotalCostExchange
                                                              + item.APBillOfLadingItemImportTaxAmount
                                                              + item.APBillOfLadingItemConsumptionTaxAmount
                                                              + item.APBillOfLadingItemEnviromentTaxAmount) / 100;
                }
                else if (e.Column.FieldName == "APBillOfLadingItemConsumptionTaxAmount")
                {
                    item.APBillOfLadingItemConsumptionTaxPercent = item.APBillOfLadingItemConsumptionTaxAmount
                                                                / (item.APBillOfLadingItemTotalCostExchange
                                                                + item.APBillOfLadingItemImportTaxAmount) * 100;

                    item.APBillOfLadingItemVATTaxAmount = item.APBillOfLadingItemVATTaxPercent
                                                              * (item.APBillOfLadingItemTotalCostExchange
                                                              + item.APBillOfLadingItemImportTaxAmount
                                                              + item.APBillOfLadingItemConsumptionTaxAmount
                                                              + item.APBillOfLadingItemEnviromentTaxAmount) / 100;

                }
                else if (e.Column.FieldName == "APBillOfLadingItemEnviromentTaxAmount")
                {
                    item.APBillOfLadingItemEnviromentTaxPercent = item.APBillOfLadingItemEnviromentTaxAmount
                                                                  / item.APBillOfLadingItemTotalCostExchange * 100;

                    item.APBillOfLadingItemVATTaxAmount = item.APBillOfLadingItemVATTaxPercent
                                                               * (item.APBillOfLadingItemTotalCostExchange
                                                               + item.APBillOfLadingItemImportTaxAmount
                                                               + item.APBillOfLadingItemConsumptionTaxAmount
                                                               + item.APBillOfLadingItemEnviromentTaxAmount) / 100;
                }
                else if (e.Column.FieldName == "APBillOfLadingItemVATTaxAmount")
                {
                    item.APBillOfLadingItemVATTaxPercent = item.APBillOfLadingItemVATTaxAmount
                                                              / (item.APBillOfLadingItemTotalCostExchange
                                                              + item.APBillOfLadingItemImportTaxAmount
                                                              + item.APBillOfLadingItemConsumptionTaxAmount
                                                              + item.APBillOfLadingItemEnviromentTaxAmount) * 100;
                }
                else if (e.Column.FieldName == "APBillOfLadingItemTotalCost")
                {
                    item.APBillOfLadingItemProductUnitCost = item.APBillOfLadingItemTotalCost / item.APBillOfLadingItemProductQty;

                    item.APBillOfLadingItemProductUnitCostExchange = item.APBillOfLadingItemProductUnitCost * exrate;
                    item.APBillOfLadingItemTotalCostExchange = (item.APBillOfLadingItemTotalCost * exrate) + item.APBillOfLadingItemDOFee + item.APBillOfLadingItemCleaningContFee;

                    item.APBillOfLadingItemImportTaxAmount = item.APBillOfLadingItemImportTaxPercent
                                                                * item.APBillOfLadingItemTotalCostExchange / 100;

                    item.APBillOfLadingItemConsumptionTaxAmount = item.APBillOfLadingItemConsumptionTaxPercent
                                                                * (item.APBillOfLadingItemTotalCostExchange
                                                                + item.APBillOfLadingItemImportTaxAmount) / 100;

                    item.APBillOfLadingItemEnviromentTaxAmount = item.APBillOfLadingItemEnviromentTaxPercent
                                                               * item.APBillOfLadingItemTotalCostExchange / 100;

                    item.APBillOfLadingItemVATTaxAmount = item.APBillOfLadingItemVATTaxPercent
                                                               * (item.APBillOfLadingItemTotalCostExchange
                                                               + item.APBillOfLadingItemImportTaxAmount
                                                               + item.APBillOfLadingItemConsumptionTaxAmount
                                                               + item.APBillOfLadingItemEnviromentTaxAmount) / 100;
                }
                else if (e.Column.FieldName == "APBillOfLadingItemDOFee" || e.Column.FieldName == "APBillOfLadingItemCleaningContFee")
                {
                    item.APBillOfLadingItemTotalCostExchange = (item.APBillOfLadingItemTotalCost * exrate) + item.APBillOfLadingItemDOFee + item.APBillOfLadingItemCleaningContFee;

                    item.APBillOfLadingItemImportTaxAmount = item.APBillOfLadingItemImportTaxPercent
                                                                * item.APBillOfLadingItemTotalCostExchange / 100;

                    item.APBillOfLadingItemConsumptionTaxAmount = item.APBillOfLadingItemConsumptionTaxPercent
                                                                * (item.APBillOfLadingItemTotalCostExchange
                                                                + item.APBillOfLadingItemImportTaxAmount) / 100;

                    item.APBillOfLadingItemEnviromentTaxAmount = item.APBillOfLadingItemEnviromentTaxPercent
                                                               * item.APBillOfLadingItemTotalCostExchange / 100;

                    item.APBillOfLadingItemVATTaxAmount = item.APBillOfLadingItemVATTaxPercent
                                                               * (item.APBillOfLadingItemTotalCostExchange
                                                               + item.APBillOfLadingItemImportTaxAmount
                                                               + item.APBillOfLadingItemConsumptionTaxAmount
                                                               + item.APBillOfLadingItemEnviromentTaxAmount) / 100;
                }
                item.APBillOfLadingItemTotalTaxAmount = item.APBillOfLadingItemImportTaxAmount
                                                          + item.APBillOfLadingItemConsumptionTaxAmount
                                                          + item.APBillOfLadingItemEnviromentTaxAmount
                                                          + item.APBillOfLadingItemVATTaxAmount;

                entity.BillOfLadingItemList.GridControl.RefreshDataSource();

                ((BillOfLadingModule)Screen.Module).UpdateDocumentEntriesExt();
            }
        }
    }
}
