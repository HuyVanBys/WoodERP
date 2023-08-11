using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductionCostWood
{
    public class MMProductionCostIngredientCostsGridControl : BOSGridControl
    {

        public override void InitGridControlDataSource()
        {
            ProductionCostWoodEntities entity = (ProductionCostWoodEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductionCostIngredientCostList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.GroupFormat = "[#image]{1} {2}";
            gridView.OptionsView.ShowFooter = true;
            GridColumn column = new GridColumn();

            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.Group();
                column.GroupIndex = 0;
            }

            column = gridView.Columns["FK_MMOperationID"];
            if (column != null)
            {
                column.Group();
                column.GroupIndex = 1;
            }
            column = gridView.Columns["MMProductionCostIngredientCostReferenceType"];
            if (column != null)
            {
                column.Group();
                column.GroupIndex = 2;
            }
            column = gridView.Columns["MMProductionCostIngredientCostReferenceNo"];
            if (column != null)
            {
                column.Group();
                column.GroupIndex = 3;
            }
            column = gridView.Columns["MMProductionCostIngredientCostProductQty"];
            if (column != null)
            {
                column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                column.SummaryItem.DisplayFormat = "{0:N2}";

                GridGroupSummaryItem summaryItem = new GridGroupSummaryItem();
                summaryItem.FieldName = "MMProductionCostIngredientCostProductQty";
                summaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                summaryItem.DisplayFormat = "{0:N2}";
                summaryItem.ShowInGroupColumnFooter = column;
                gridView.GroupSummary.Add(summaryItem);
            }
            column = gridView.Columns["MMProductionCostIngredientCostTotalCost"];
            if (column != null)
            {
                column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                column.SummaryItem.DisplayFormat = "{0:N2}";

                GridGroupSummaryItem summaryItem = new GridGroupSummaryItem();
                summaryItem.FieldName = "MMProductionCostIngredientCostTotalCost";
                summaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                summaryItem.DisplayFormat = "{0:N4}";
                summaryItem.ShowInGroupColumnFooter = column;
                gridView.GroupSummary.Add(summaryItem);
            }
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            return gridView;
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {

            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
            gridView.BestFitColumns();
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ShowInventory();
        }

        /// <summary>
        /// Show inventory details of the current item
        /// </summary>
        private void ShowInventory()
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                BusinessObject item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
                BOSDbUtil dbUtil = new BOSDbUtil();
                int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
                string itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
                String columnName = String.Empty;
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductDesc";
                string desc = dbUtil.GetPropertyStringValue(item, columnName);
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
                int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
                ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "MMProductionCostIngredientCostBatchComponent")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ADMatchCodesController objMatchCodesController = new ADMatchCodesController();
                    ADMatchCodesInfo objMatchCodesInfo = (ADMatchCodesInfo)objMatchCodesController.GetObjectByID(matchCodeID);
                    if (objMatchCodesInfo != null)
                        e.DisplayText = objMatchCodesInfo.ADMatchCodeValue;
                }
                else
                {
                    e.DisplayText = "";
                }
            }

            //if (e.Column.FieldName == "MMProductionCostIngredientCostReferenceType")
            //{
            //    if (e.Value != null)
            //    {
            //        GridView gridView = (GridView)this.MainView;
            //        MMProductionCostIngredientCostsInfo objIngredientCostsInfo = new MMProductionCostIngredientCostsInfo();
            //        if (gridView.FocusedRowHandle >= 0)
            //        {
            //            objIngredientCostsInfo = (MMProductionCostIngredientCostsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            //        }
            //        string type = string.Empty;
            //        if (e.Value.ToString().Contains("Receipt"))
            //            type = "ReceiptType";
            //        else
            //            type = "ShipmentType";
            //        e.DisplayText = ((ProductionCostWoodModule)Screen.Module).GetReferenceTypeText(type, e.Value.ToString());
            //    }
            //}
        }
    }
}
