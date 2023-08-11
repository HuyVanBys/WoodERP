using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.Report
{
    public class RP128MMPurchasePlanItemWoods : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "MMPurchasePlanItemWoodQuantity";
            column.Caption = "Khối lượng mua mới";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMAllocationPlanItemWoodQty";
            column.Caption = "Khối lượng sử dụng tồn kho";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "FK_ICProductAttributeWoodTypeID";
            column.Caption = "Loại gỗ";
            column.OptionsColumn.AllowEdit = false;
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
            repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeNo", WoodPurchaseReceiptLocalizedResources.APInvoiceInItemProductWoodTypeNoCaption));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", WoodPurchaseReceiptLocalizedResources.APInvoiceInItemProductWoodTypeValueCaption));
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditWoodType_QueryPopUp);
            column.ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns.Add(column);
        }
        public void repositoryItemLookUpEditWoodType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributeList = new List<ICProductAttributesInfo>();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            objProductAttributesInfo.ICProductAttributeID = 0;
            productAttributeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeWoodTypeColumnName);
            if (productAttributeList != null)
            {
                productAttributeList.Insert(0, objProductAttributesInfo);
                lookUpEdit.Properties.DataSource = productAttributeList;
            }
            lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
            lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        }
        //protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        //{
        //    GridView gridView = base.InitializeGridView();
        //    if (gridView.Columns["FK_ICProductAttributeWoodTypeID"] != null)
        //        gridView.Columns["FK_ICProductAttributeWoodTypeID"].Group();
        //    return gridView;
        //}
        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            DateTime value = DateTime.Now;
            if (e.CellValue != null && (e.Column.FieldName == "PurchaseOrderPaymentTimeDateDeposit" || e.Column.FieldName == "APInvoiceIndate"))
            {
                if (DateTime.TryParse(e.CellValue.ToString(), out value))
                {
                    if (value == DateTime.MinValue)
                    {
                        e.DisplayText = "";
                    }
                    if (value == DateTime.MaxValue)
                    {
                        e.DisplayText = "";
                    }
                }
            }

        }


    }
}
