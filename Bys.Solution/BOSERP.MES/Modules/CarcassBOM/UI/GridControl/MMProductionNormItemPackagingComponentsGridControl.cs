using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class MMProductionNormItemPackagingComponentsGridControl : BOSGridControl
    {

        protected override GridView InitializeGridView()
        {
            GridView gridview = base.InitializeGridView();


            string[] colList = new string[] {   "Selected"
                                            ,   "MMProductionNormItemNo"
                                            ,   "MMProductionNormItemProductName"
                                            ,   "MMProductionNormItemProductDesc"
                                            ,   "MMProductionNormItemProductInsideDimensionLength"
                                            ,   "MMProductionNormItemProductInsideDimensionWidth"
                                            ,   "MMProductionNormItemProductInsideDimensionHeight"
                                            ,   "FK_ICProdAttPackingMaterialSpecialityID"
                                            ,   "FK_ICProdAttPackingMaterialSizeID"
                                            ,   "FK_ICProdAttPackingMaterialWeightPerVolumeID"
                                            ,   "MMProductionNormItemProductMarketLength"
                                            ,   "MMProductionNormItemProductMarketWidth"
                                            ,   "MMProductionNormItemProductMarketHeight"
                                            ,   "MMProductionNormItemQuantity"
                                            ,   "MMProductionNormItemTotalQuantity"
                                            ,   "MMProductionNormItemComment"
                                            ,   "MMProductionNormItemProductSizeAndPacking"
                                            ,   "FK_ICMeasureUnitID"
                                            ,   "MMProductionNormItemPackagingNW"
                                            ,   "MMProductionNormItemPackagingGW"
                                            ,   "MMProductionNormItemProductOverallDimensionLength"
                                            ,   "MMProductionNormItemProductOverallDimensionWidth"
                                            ,   "MMProductionNormItemProductOverallDimensionHeight"

                                            };

            ReLocationColumn(colList, gridview);

            GridColumn col = gridview.Columns["MMProductionNormItemTotalQuantity"];
            if (col != null)
            {
                col.Caption = "Qty/box";
            }

            col = gridview.Columns["MMProductionNormItemNo"];
            if (col != null)
            {
                col.Caption = "Mã PLĐG";
            }

            col = gridview.Columns["MMProductionNormItemProductName"];
            if (col != null)
            {
                col.Caption = "Tên PLĐG";
            }

            col = gridview.Columns["Selected"];
            if (col != null)
            {
                col.OptionsColumn.AllowEdit = true;
            }

            FormatColumn(gridview);

            gridview.BestFitColumns();
            return gridview;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Chọn";
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        private RepositoryItemBOSLookupEdit CreateRepositoryLookUpEdit(string displayMember, string valueMember, Dictionary<string, string> lookUpCols)
        {
            RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
            repositoryItemLookUpEdit.DisplayMember = displayMember;
            repositoryItemLookUpEdit.ValueMember = valueMember;
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            if (lookUpCols != null && lookUpCols.Count() > 0)
            {
                foreach (string key in lookUpCols.Keys)
                {
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(key, lookUpCols[key], 100));
                }
            }
            else
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(displayMember, string.Empty, 100));

            return repositoryItemLookUpEdit;
        }

        private List<ICProductAttributesInfo> GetAttributeValueByGroup(string group)
        {
            ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            List<ICProductAttributesInfo> list = objDepartmentAttributeValuesController.GetProductAttributesByProductAttributeGroup(group);
            list.Insert(0, objProductAttributesInfo);

            return list;
        }

        private List<MMPackingMaterialMarketDimensionsInfo> GetPackingMaterialMarketDimensions()
        {
            MMPackingMaterialMarketDimensionsController controller = new MMPackingMaterialMarketDimensionsController();
            List<MMPackingMaterialMarketDimensionsInfo> list = controller.GetAllAliveMarketDimension();
            return list;
        }

        private List<ICMeasureUnitsInfo> GetMeasureUnit()
        {
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            List<ICMeasureUnitsInfo> ds = objMeasureUnitsController.GetAllAliveMeasureUnit();

            return ds;
        }

        private void FormatColumn(GridView gridView)
        {
            GridColumn column = gridView.Columns["FK_ICProdAttPackingMaterialWeightPerVolumeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("ICProductAttributeValue", "Định lượng");
                dic.Add("MMPackingMaterialMarketDimensionProductLength", "Dài");
                dic.Add("MMPackingMaterialMarketDimensionProductWidth", "Rộng");
                dic.Add("MMPackingMaterialMarketDimensionProductHeight", "Cao");

                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit
                    = CreateRepositoryLookUpEdit("ICProductAttributeValue", "ICProductAttributeID", dic);
                List<MMPackingMaterialMarketDimensionsInfo> collection = GetPackingMaterialMarketDimensions();
                repositoryItemLookUpEdit.DataSource = collection;
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.BestFit();
                column.MinWidth = 300;

            }

            //column = gridView.Columns["FK_ICProdAttPackingMaterialSizeID"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = false;
            //    Dictionary<string, string> dic = new Dictionary<string, string>();
            //    dic.Add("ICProductAttributeValue", "Khổ màng foam");

            //    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit
            //        = CreateRepositoryLookUpEdit("ICProductAttributeValue", "ICProductAttributeID", dic);
            //    repositoryItemLookUpEdit.DataSource = GetAttributeValueByGroup(ProductAttributeGroup.PackingMaterialSize.ToString());
            //    column.ColumnEdit = repositoryItemLookUpEdit;
            //    column.MinWidth = 150;

            //}

            //column = gridView.Columns["FK_ICProdAttPackingMaterialSpecialityID"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = false;
            //    Dictionary<string, string> dic = new Dictionary<string, string>();
            //    dic.Add("ICProductAttributeValue", "Đặc tính");

            //    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit
            //        = CreateRepositoryLookUpEdit("ICProductAttributeValue", "ICProductAttributeID", dic);
            //    repositoryItemLookUpEdit.DataSource = GetAttributeValueByGroup(ProductAttributeGroup.PackingMaterialSpeciality.ToString());
            //    column.ColumnEdit = repositoryItemLookUpEdit;
            //    column.MinWidth = 150;

            //}

            //column = gridView.Columns[ProductionNormConst.FK_ICMeasureUnitID];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = false;
            //    Dictionary<string, string> dic = new Dictionary<string, string>();
            //    dic.Add("ICMeasureUnitName", "ĐVT");

            //    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit
            //        = CreateRepositoryLookUpEdit("ICMeasureUnitName", "ICMeasureUnitID", dic);
            //    repositoryItemLookUpEdit.DataSource = GetMeasureUnit();
            //    column.ColumnEdit = repositoryItemLookUpEdit;
            //    column.MinWidth = 50;

            //}


            column = gridView.Columns["ChooseProduct"];
            if (column != null)
            {
                RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
                rpItemComponent.NullText = "Chọn PLĐG";
                rpItemComponent.Click += new System.EventHandler(rpItemComponent_Click);
                column.ColumnEdit = rpItemComponent;
            }
        }

        void rpItemComponent_Click(object sender, System.EventArgs e)
        {
            GridView gridView = (GridView)this.MainView;
            if (gridView != null)
            {
                MMProductionNormItemsInfo item = (MMProductionNormItemsInfo)gridView.GetFocusedRow();
                if (item != null)
                {
                    ((CarcassBOMModule)Screen.Module).ChoosePackaging(item);
                }
            }

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
                        columnedit.AppearanceCell.Options.UseBackColor = true;
                        columnedit.Visible = true;
                        columnedit.VisibleIndex = index++;
                    }
                }

                gridView.BestFitColumns();
            }
        }

    }
}
