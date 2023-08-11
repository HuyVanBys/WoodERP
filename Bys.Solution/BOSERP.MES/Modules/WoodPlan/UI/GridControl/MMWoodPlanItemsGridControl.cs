using BOSComponent;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.WoodPlan
{
    public class MMWoodPlanItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            WoodPlanEntities entity = (WoodPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.WoodPlanItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "MMBatchProductItemProductDesc";
            column.Caption = "Sản phẩm";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "StatusUpdate";
            column.Caption = "Trạng thái cập nhật";
            gridView.Columns.Add(column);

        }
        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            if (e.Column.FieldName == "Selected")
            {
                ((WoodPlanModule)Screen.Module).UpdateTotalMaterialQty();
            }

        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridGroupSummaryItem summaryItem = new GridGroupSummaryItem();
            gridView.OptionsView.ShowFooter = true;
            if (gridView.Columns["MMBatchProductItemProductDesc"] != null)
            {
                gridView.Columns["MMBatchProductItemProductDesc"].Group();
            }

            if (gridView.Columns["FK_ICProductAttributeWoodTypeID"] != null)
            {
                gridView.Columns["FK_ICProductAttributeWoodTypeID"].Group();
            }


            if (gridView.Columns["MMWoodPlanItemAllocationType"] != null)
            {
                gridView.Columns["MMWoodPlanItemAllocationType"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["FK_ICProductAttributeSpecialityID"] != null)
            {
                gridView.Columns["FK_ICProductAttributeSpecialityID"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["Selected"] != null)
            {
                gridView.Columns["Selected"].OptionsColumn.AllowEdit = true;
            }

            //if (gridView.Columns["MMWoodPlanItemWidth"] != null)
            //{
            //    gridView.Columns["MMWoodPlanItemWidth"].OptionsColumn.AllowEdit = true;
            //}

            //if (gridView.Columns["MMWoodPlanItemLength"] != null)
            //{
            //    gridView.Columns["MMWoodPlanItemLength"].OptionsColumn.AllowEdit = true;
            //}

            if (gridView.Columns["MMWoodPlanItemIsReuse"] != null)
            {
                gridView.Columns["MMWoodPlanItemIsReuse"].OptionsColumn.AllowEdit = true;
            }

            //if (gridView.Columns["FK_ICProductWoodIngredientID"] != null)
            //{
            //    gridView.Columns["FK_ICProductWoodIngredientID"].OptionsColumn.AllowEdit = true;
            //}

            //if (gridView.Columns["MMWoodPlanItemAllocationType"] != null)
            //{
            //    gridView.Columns["MMWoodPlanItemAllocationType"].OptionsColumn.AllowEdit = true;
            //}
            if (gridView.Columns["MMWoodPlanItemComment"] != null)
            {
                gridView.Columns["MMWoodPlanItemComment"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["StatusUpdate"] != null)
            {
                gridView.Columns["StatusUpdate"].OptionsColumn.AllowEdit = false;
            }



            GridColumn column = gridView.Columns["FK_ICProductAttributeSpecialityID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                //repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeNo", WoodPlanLocalizedResources.APInvoiceInItemProductSpecialityNoCaption));
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", WoodPlanLocalizedResources.APInvoiceInItemProductSpecialityValueCaption));
                //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditQuality_QueryPopUp);
                //column.ColumnEdit = repositoryItemLookUpEdit;
            }

            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            gridView.FocusedRowChanged += new FocusedRowChangedEventHandler(gridView_FocusedRowChanged);
            gridView.RowStyle += new RowStyleEventHandler(gridView_RowStyle);
            return gridView;
        }

        void gridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            GridView gridView = (GridView)MainView;
            if (e.RowHandle >= 0)
            {
                if (e.RowHandle == gridView.FocusedRowHandle)
                {
                    e.Appearance.ForeColor = Color.Black;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
                MMWoodPlanItemsInfo objWoodPlanItemsInfo = (MMWoodPlanItemsInfo)gridView.GetRow(e.RowHandle);
                if (objWoodPlanItemsInfo != null)
                {
                    if (objWoodPlanItemsInfo.HaveChanged)
                    {
                        e.Appearance.BackColor2 = Color.Yellow;
                        e.Appearance.BackColor = Color.Yellow;
                    }
                    if (objWoodPlanItemsInfo.HaveChangedForUpdate)
                    {
                        e.Appearance.BackColor2 = Color.Green;
                        e.Appearance.BackColor = Color.Green;
                    }
                }
            }
        }

        void gridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {

            ((WoodPlanModule)Screen.Module).FocusWoodPlanItemChange();

        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            gridView.ExpandAllGroups();
            gridView.BestFitColumns();
        }
        //public void repositoryItemLookUpEditQuality_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
        //    List<ICProductAttributesInfo> productAttributeList = new List<ICProductAttributesInfo>();
        //    ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
        //    objProductAttributesInfo.ICProductAttributeID = 0;
        //    productAttributeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeSpecialityColumnName);
        //    if (productAttributeList != null)
        //    {
        //        productAttributeList.Insert(0, objProductAttributesInfo);
        //        lookUpEdit.Properties.DataSource = productAttributeList;
        //    }
        //    lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
        //    lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        //}
        //private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        //{
        //    if (e.Column.FieldName == "FK_ICProductAttributeSpecialityID")
        //    {
        //        if (e.Value != null)
        //        {
        //            int matchCodeID = int.Parse(e.Value.ToString());
        //            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
        //            ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(matchCodeID);
        //            if (objProductAttributesInfo != null)
        //                e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
        //            else
        //                e.DisplayText = "";
        //        }
        //        else
        //            e.DisplayText = "";
        //    }
        //}
    }
}
