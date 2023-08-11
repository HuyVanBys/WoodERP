using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace BOSERP.Modules.BatchProduct
{
    public partial class ProductionNormItemsPackagingTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties
        #endregion

        protected override void InitTreeListDataSource()
        {
            BatchProductEntities entity = (BatchProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList dataSource = new BOSTreeList();
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
            DataSource = entity.ProductionNormItemPackagingList;
        }
        public override void InitializeControl()
        {
            this.BOSDisplayOption = false;
            base.InitializeControl();
            this.ExpandAll();
            this.OptionsView.AutoWidth = false;
            this.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto;
            this.BOSDisplayRoot = false;
            this.BestFitColumns();

            // this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
            this.CustomDrawNodeCell += new CustomDrawNodeCellEventHandler(ProductionNormItemsPackagingTreeListControl_CustomDrawNodeCell);
            this.CustomColumnDisplayText += ProductionNormItemsPackagingTreeListControl_CustomColumnDisplayText;
            #region Custome Col
            TreeListColumn column = this.Columns["FK_MMBPSemiProductID"];
            if (column != null)
            {
                List<MMBatchProductProductionNormItemsInfo> semiProductDatasource = ((BatchProductModule)Screen.Module).GetBPSemiProductDataSource();
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "MMBatchProductProductionNormItemNo";
                repositoryItemLookUpEdit.ValueMember = "MMBatchProductProductionNormItemID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMBatchProductProductionNormItemNo", "Mã chi tiết", 150));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMBatchProductProductionNormItemProductName", "Tên chi tiết", 300));
                repositoryItemLookUpEdit.DataSource = semiProductDatasource;
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = this.Columns["MMBatchProductProductionNormItemProductName"];
            if (column != null) column.Caption = "Tên PLDG";
            column = this.Columns["MMBatchProductProductionNormItemNo"];
            if (column != null) column.Caption = "Mã PLDG";
            column = this.Columns["MMBatchProductProductionNormItemWoodBlocks"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "N5");
            }
            column = this.Columns["MMBatchProductProductionNormItemBlocks"];
            if (column != null)
            {
                FormatNumbericColumn(column, false, "N5");
            }
            column = this.Columns["MMBatchProductProductionNormItemBlockPerOne"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "N5");
            }
            #endregion
        }
        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            //Columns.Clear();
            // #region InitTreeListColumns

            //string[] colList = new string[] { "MMBatchProductProductionNormItemNo"
            //                                ,   "MMBatchProductProductionNormItemProductName"
            //                                ,   "FK_MMProductionNormItemID"
            //                                ,   "FK_MMBPSemiProductID"
            //                                ,   "MMBatchProductProductionNormItemProductSizeAndPacking"
            //                                ,   "MMBatchProductProductionNormItemProductDesc"
            //                                ,   "FK_ICMeasureUnitID"
            //                                ,   "FK_MMOperationID"
            //                                ,   "MMBatchProductProductionNormItemQuantity"
            //                                ,   "MMBatchProductProductionNormItemNeededTime"
            //                                ,   "MMBatchProductProductionNormItemComment"
            //                                ,   "FK_MMProductionNormID"
            //                                ,   "FK_ICProductID"
            //                                ,   "MMBatchProductProductionNormItemProductLength"
            //                                ,   "MMBatchProductProductionNormItemProductWidth"
            //                                ,   "MMBatchProductProductionNormItemProductHeight"
            //                                };

            //AddTreeListColumns(1, "MMBatchProductProductionNormItemNo", true, false);//Ma vat tu
            //AddTreeListColumns(2, "MMBatchProductProductionNormItemProductName", true, false);//Ten VT
            //AddTreeListColumns(3, "FK_MMProductionNormItemID", true, false);
            //AddTreeListColumns(4, "FK_MMBPSemiProductID", true, false);
            //AddTreeListColumns(11, "MMBatchProductProductionNormItemProductSizeAndPacking", false, true);//Kích thước/Quy cách
            //AddTreeListColumns(12, "MMBatchProductProductionNormItemProductDesc", true, false);//Mo ta
            //AddTreeListColumns(13, ProductionNormConst.FK_ICMeasureUnitID, false, true);//DVT
            //AddTreeListColumns(14, "FK_MMOperationID", false, true);
            //AddTreeListColumns(18, "MMBatchProductProductionNormItemQuantity", false, true);//SL
            //AddTreeListColumns(20, "MMBatchProductProductionNormItemNeededTime", false, true);//Thoi gian can
            //AddTreeListColumns(21, "MMBatchProductProductionNormItemComment", false, true);//Ghi chu
            //foreach (TreeListColumn column in Columns)
            //{
            //    column.Visible = false;
            //}
            //int count = 0;
            //foreach (string field in colList)
            //{
            //    TreeListColumn column = Columns[field];
            //    if (column != null)
            //    {
            //        column.Visible = true;
            //        column.VisibleIndex = count;
            //        count++;
            //    }
            //}

            //#endregion

            //if (Columns["MMBatchProductProductionNormItemSortOrder"] == null)
            //{
            //    this.BeginUpdate();
            //    TreeListColumn column = Columns.Add();
            //    column.FieldName = "MMBatchProductProductionNormItemSortOrder";
            //    column.Caption = "SortOrder";
            //    column.Visible = false;
            //    //column.SortOrder = SortOrder.Ascending;
            //    this.EndUpdate();
            //    this.Update();
            //}
            //this.OptionsView.ShowSummaryFooter = true;
        }
        public void AddTreeListColumns(int visibleIndex, string fieldName, bool readOnly, bool allowEdit)
        {
            this.BeginUpdate();
            TreeListColumn column = Columns.ColumnByFieldName(fieldName);
            if (column == null)
            {
                column = Columns.Add();
            }
            column.Visible = true;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.OptionsColumn.ReadOnly = readOnly;
            this.OptionsView.AutoWidth = false;

            column.OptionsColumn.FixedWidth = false;
            column.VisibleIndex = visibleIndex;
            column.FieldName = fieldName;
            //Get Caption
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            List<AAColumnAliasInfo> dsColumns = BOSApp.LstColumnAlias.Where(a => a.AATableName == TableName.MMBatchProductProductionNormItemsTableName).ToList();
            if (dsColumns.Count() > 0)
            {
                foreach (AAColumnAliasInfo objAAColumnAliasInfo in dsColumns)
                {
                    //AAColumnAliasInfo objAAColumnAliasInfo = (AAColumnAliasInfo)objAAColumnAliasController.GetObjectFromDataRow(rowColumn);
                    if (objAAColumnAliasInfo != null)
                    {
                        if (fieldName == objAAColumnAliasInfo.AAColumnAliasName)
                        {
                            column.Caption = objAAColumnAliasInfo.AAColumnAliasCaption;
                        }
                        if (fieldName == "MMBatchProductProductionNormItemComment")
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemDescCaption;
                        if (fieldName == "MMBatchProductProductionNormItemProductDesc")
                            column.Caption = ProductionNormLocalizeResources.ICProductAttributeName;//Mo ta
                        if (fieldName == "MMBatchProductProductionNormItemProductOverallDimensionHeight")
                            column.Caption = "KT Phủ bì cao"; //Phu bi
                        if (fieldName == "MMBatchProductProductionNormItemProductOverallDimensionWidth")
                            column.Caption = "KT Phủ bì rộng"; //Phu bi
                        if (fieldName == "MMBatchProductProductionNormItemProductOverallDimensionLength")
                            column.Caption = "KT Phủ bì dài"; //Phu bi
                                                              //if (fieldName == "MMProductionNormItemProductAttributeValue4")
                                                              //    column.Caption = ProductionNormLocalizeResources.MMProductionNormItemSemiProductDepartmentAttribute5Caption; //Định lượng
                        if (fieldName == "MMBatchProductProductionNormItemProductWeightPerVolume")
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemSemiProductDepartmentAttribute5Caption; //Định lượng
                        if (fieldName == "MMBatchProductProductionNormItemProductInsideDimensionHeight")
                            column.Caption = "KT Lọt lòng cao";//KT lọt lòng
                        if (fieldName == "MMBatchProductProductionNormItemProductInsideDimensionWidth")
                            column.Caption = "KT Lọt lòng rộng";//KT lọt lòng
                        if (fieldName == "MMBatchProductProductionNormItemProductInsideDimensionLength")
                            column.Caption = "KT Lọt lòng dài";//KT lọt lòng
                        if (fieldName == "MMBatchProductProductionNormItemTotalQuantity")
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemPackagingProductQtyInBox;//KT lọt lòng
                        if (fieldName == "MMBatchProductProductionNormItemModifiedStatus")
                            column.Caption = "Trạng thái thay đổi";
                        if (fieldName == "FK_MMProductionNormItemID")
                            column.Caption = "Mã tham chiếu BDM";
                        if (fieldName == "AACreatedDate")
                            column.Caption = "Ngày tạo";
                    }
                }
            }
            //TNDLoc [ADD][28/11/2015][Allow edit for only Qty],START
            if (fieldName == "MMBatchProductProductionNormItemQuantity")
            {
                column.OptionsColumn.AllowEdit = true;
                column.OptionsColumn.ReadOnly = false;
            }
            //TNDLoc [ADD][28/11/2015][Allow edit for only Qty],END
            if (fieldName == ProductionNormConst.MMProductionNormItemSortOrder)
            {
                column.Caption = ProductionNormConst.MMProductionNormOrderNoCaption;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Width = 70;
                column.BestFit();
            }
            if (fieldName == "FK_MMProductionNormItemID")
            {
                column.Caption = "Mã tham chiếu BDM";
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Width = 200;
                column.BestFit();
            }
            if (fieldName == ProductionNormConst.FK_ICMeasureUnitID)
            {
                column.OptionsColumn.AllowEdit = false;
                //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEdit.DisplayMember = "ICMeasureUnitName";
                //repositoryItemLookUpEdit.ValueMember = "ICMeasureUnitID";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                //  repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemUnitLookUpEdit_QueryPopUp);
                //column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 50;
                //this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (fieldName == "MMBatchProductProductionNormItemProductName")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNamePackaging;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.BestFit();
            }
            if (fieldName == "MMBatchProductProductionNormItemNo")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNoPackaging;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.BestFit();
            }
            if (fieldName == "FK_MMBPSemiProductID")
            {
                List<MMBatchProductProductionNormItemsInfo> semiProductDatasource = ((BatchProductModule)Screen.Module).GetBPSemiProductDataSource();
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "MMBatchProductProductionNormItemNo";
                repositoryItemLookUpEdit.ValueMember = "MMBatchProductProductionNormItemID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMBatchProductProductionNormItemNo", "Mã chi tiết", 150));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMBatchProductProductionNormItemProductName", "Tên chi tiết", 300));
                repositoryItemLookUpEdit.DataSource = semiProductDatasource;
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.Caption = "Thuộc chi tiết";
                column.MinWidth = 150;
            }
            this.EndUpdate();
            this.Update();
        }
        private void ProductionNormItemsPackagingTreeListControl_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            if (e.Column.FieldName == ProductionNormConst.FK_ICMeasureUnitID)
            {
                if (e.CellValue != null)
                {
                    int value = 0;
                    if (int.TryParse(e.CellValue.ToString(), out value))
                    {
                        e.CellText = BOSApp.GetDisplayTextFromCatche("ICMeasureUnits", "ICMeasureUnitID", value, "ICMeasureUnitName");
                    }
                }
            }
        }

        private void ProductionNormItemsPackagingTreeListControl_CustomColumnDisplayText(object sender, DevExpress.XtraTreeList.CustomColumnDisplayTextEventArgs e)
        {
            BatchProductEntities entity = (BatchProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (e.Column.FieldName == "FK_MMBPSemiProductID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = ((BatchProductModule)Screen.Module).GetBPSemiProductDisplayDisplayText(int.Parse(e.Value.ToString()));
                }
                else
                    e.DisplayText = string.Empty;
            }
        }
    }
}
