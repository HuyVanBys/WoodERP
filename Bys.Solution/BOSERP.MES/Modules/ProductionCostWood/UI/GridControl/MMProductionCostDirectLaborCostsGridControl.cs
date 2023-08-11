using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using BOSLib;
using BOSComponent;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using BOSCommon;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System.Data;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;

namespace BOSERP.MES.Modules.ProductionCost
{
    public class MMProductionCostDirectLaborCostsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductionCostEntities entity = (ProductionCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductionCostDirectLaborCostList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.GroupFormat = "[#image]{1} {2}";
            //gridView.CellValueChanged += new CellValueChangedEventHandler(gridView_CellValueChanged);

            foreach (GridColumn column in gridView.Columns)
            {                
                if (column.FieldName == "FK_MMBatchProductID")
                {
                    column.OptionsColumn.AllowEdit = true;
                    column.Group();
                    BOSComponent.RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = column.ColumnEdit as BOSComponent.RepositoryItemBOSLookupEdit;
                    if (repositoryItemLookUpEdit != null)
                    {
                        repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(BatchRepositoryItemLookUpEdit_QueryPopUp);
                    }
                }
                
                //else if (column.FieldName == "FK_ARSaleOrderID")
                //{
                //    column.OptionsColumn.AllowEdit = true;
                //    BOSComponent.RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = column.ColumnEdit as BOSComponent.RepositoryItemBOSLookupEdit;
                //    if (repositoryItemLookUpEdit != null)
                //    {
                //        repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(SaleOrderRepositoryItemLookUpEdit_QueryPopUp);
                //    }
                //}

                //else if (column.FieldName == "FK_MMOperationID")
                //{
                //    column.OptionsColumn.AllowEdit = true;
                //    BOSComponent.RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = column.ColumnEdit as BOSComponent.RepositoryItemBOSLookupEdit;
                //    if (repositoryItemLookUpEdit != null)
                //    {
                //        repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(OperationRepositoryItemLookUpEdit_QueryPopUp);
                //    }
                //}

                //else if (column.FieldName == "FK_MMProposalID")
                //{
                //    column.OptionsColumn.AllowEdit = true;
                //    BOSComponent.RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = column.ColumnEdit as BOSComponent.RepositoryItemBOSLookupEdit;
                //    if (repositoryItemLookUpEdit != null)
                //    {
                //        repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(ProposalRepositoryItemLookUpEdit_QueryPopUp);
                //    }
                //}

                //else if (column.FieldName == "FK_ICProductIDForBatch")
                //{
                //    column.OptionsColumn.AllowEdit = true;
                //    BOSComponent.RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = column.ColumnEdit as BOSComponent.RepositoryItemBOSLookupEdit;
                //    if (repositoryItemLookUpEdit != null)
                //    {
                //        repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(ProductRepositoryItemLookUpEdit_QueryPopUp);
                //    }
                //}

                else if (column.FieldName == "MMProductionCostDirectLaborCostProductQty")
                {
                    column.OptionsColumn.AllowEdit = true;
                }

                else if (column.FieldName == "MMProductionCostDirectLaborCostTotalCost")
                {
                    column.OptionsColumn.AllowEdit = true;
                    GridGroupSummaryItem summaryItem = new GridGroupSummaryItem();
                    summaryItem.FieldName = "MMProductionCostDirectLaborCostTotalCost";
                    summaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    summaryItem.DisplayFormat = "{0:N2}";
                    summaryItem.ShowInGroupColumnFooter = column;
                    gridView.GroupSummary.Add(summaryItem);
                }
                else if (column.FieldName == "MMProductionCostDirectLaborCostBatchComponent")
                {
                    column.OptionsColumn.AllowEdit = true;
                }
                else if (column.FieldName == "FK_HREmployeeID")
                {
                    column.OptionsColumn.AllowEdit = true;
                }
                else if (column.FieldName == "FK_ICProductID")
                {
                    column.OptionsColumn.AllowEdit = true;
                }
                else if (column.FieldName == "FK_ICStockID")
                {
                    column.OptionsColumn.AllowEdit = true;
                }
            }
           
            //gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Mã chấm công";
            column.FieldName = "HRManufactureTimeSheetNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày chấm công";
            column.FieldName = "HRManufactureTimeSheetDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        /// <summary>
        /// LookUpEdit product component
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //public void repositoryItemLookUpEditComponent_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ADMatchCodesController objMatchCodesController = new ADMatchCodesController();
        //    List<ADMatchCodesInfo> matchCodesList = new List<ADMatchCodesInfo>();
        //    ADMatchCodesInfo objMatchCodesInfo = new ADMatchCodesInfo();
        //    objMatchCodesInfo.ADMatchCodeID = 0;
        //    matchCodesList = objMatchCodesController.GetADMatchCodesByMatchCodeColumnName(MatchCodeConst.MatchCodeComponentColumnName);
        //    if (matchCodesList != null)
        //    {
        //        matchCodesList.Insert(0, objMatchCodesInfo);
        //        lookUpEdit.Properties.DataSource = matchCodesList;
        //    }
        //    lookUpEdit.Properties.DisplayMember = "ADMatchCodeValue";
        //    lookUpEdit.Properties.ValueMember = "ADMatchCodeID";
        //}

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
                ((BaseModuleERP)Screen.Module).ShowInventory(productID);
            }
        }

        //void gridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        //{
        //    base.GridView_CellValueChanged(sender, e);

        //    ProductionCostEntities entity = (ProductionCostEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
        //    if (entity.DirectLaborCostList.CurrentIndex >= 0)
        //    {
        //        GridView gridView = (GridView)sender;
        //        MMDirectLaborCostsInfo item = (MMDirectLaborCostsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                
        //        ((ProductionCostModule)Screen.Module).UpdatePieceWork(item);
        //        ((ProductionCostModule)Screen.Module).UpdateProductQtyFromManufactureTimeSheet(item);
        //        ((ProductionCostModule)Screen.Module).UpdateDirectLaborCostAppropriationAmount();
        //    }
        //}

        public void BatchRepositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (lookUpEdit != null)
                lookUpEdit.Properties.DataSource = ((ProductionCostModule)Screen.Module).GetBatchs();
        }

        //public void SaleOrderRepositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    if (lookUpEdit != null)
        //        lookUpEdit.Properties.DataSource = ((ProductionCostModule)Screen.Module).GetSaleOderByBatchID();
        //}

        //public void OperationRepositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    if (lookUpEdit != null)
        //        lookUpEdit.Properties.DataSource = ((ProductionCostModule)Screen.Module).GetOperationByBatchID();
        //}

        //public void ProposalRepositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    if (lookUpEdit != null)
        //        lookUpEdit.Properties.DataSource = ((ProductionCostModule)Screen.Module).GetProposalByBatchID();
        //}

        //public void ProductRepositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    if (lookUpEdit != null)
        //        lookUpEdit.Properties.DataSource = ((ProductionCostModule)Screen.Module).GetProductByBatchID();
        //}

        //private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        //{
        //    if (e.Column.FieldName == "MMDirectLaborCostBatchComponent")
        //    {
        //        if (e.Value != null)
        //        {
        //            int matchCodeID = int.Parse(e.Value.ToString());
        //            ADMatchCodesController objMatchCodesController = new ADMatchCodesController();
        //            ADMatchCodesInfo objMatchCodesInfo = (ADMatchCodesInfo)objMatchCodesController.GetObjectByID(matchCodeID);
        //            if (objMatchCodesInfo != null)
        //                e.DisplayText = objMatchCodesInfo.ADMatchCodeValue;
        //            if (matchCodeID == 0)
        //            {
        //                e.DisplayText = "";
        //            }
        //        }
        //        else
        //        {
        //            e.DisplayText = "";
        //        }
        //    }

        //    if (e.Column.FieldName == "MMDirectLaborCostReferenceType")
        //    {
        //        if (e.Value != null)
        //        {
        //            GridView gridView = (GridView)this.MainView;
        //            MMDirectLaborCostsInfo objDirectLaborCostsInfo = new MMDirectLaborCostsInfo();
        //            if (gridView.FocusedRowHandle >= 0)
        //            {
        //                objDirectLaborCostsInfo = (MMDirectLaborCostsInfo)gridView.GetRow(gridView.FocusedRowHandle);
        //            }
        //            string type = string.Empty;
        //            if (e.Value.ToString().Contains("Receipt"))
        //                type = "ReceiptType";
        //            else
        //                type = "ShipmentType";
        //            e.DisplayText = ((ProductionCostModule)Screen.Module).GetReferenceTypeText(type,e.Value.ToString());
        //        }
        //    }
        //}

        //protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        //{
        //    base.GridView_KeyUp(sender, e);

        //    if (e.KeyCode == Keys.Delete)
        //    {
        //        ((ProductionCostModule)Screen.Module).DeleteItemFromDirectLaborCostItemList();
        //        ((ProductionCostModule)Screen.Module).UpdateDirectLaborCostAppropriationAmount();
        //    }
        //}
    }
}
