using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using Localization;
using System.Data;

namespace BOSERP.Modules.CalculatorProductionNormCost
{
    public partial class ProductionNormItemsPackagingTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties
        #endregion

        protected override void InitTreeListDataSource()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList dataSource = new BOSTreeList();
            MMCalculatorProductionNormItemsController objProductionNormItemsController = new MMCalculatorProductionNormItemsController();
            DataSource = entity.IngredientPackagingList;
        }
        public override void InitializeControl()
        {
            base.InitializeControl();
            this.ExpandAll();
            this.OptionsView.AutoWidth = false;
            this.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto;
            this.BOSDisplayRoot = false;
            this.BOSDisplayOption = true;
            this.ForceInitialize();
            this.BestFitColumns();
            this.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(ProductionNormItemsHardwareTreeListControl_CellValueChanged);
            // this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
            this.CustomDrawNodeCell += new CustomDrawNodeCellEventHandler(ProductionNormItemsPackagingTreeListControl_CustomDrawNodeCell);
        }
        void ProductionNormItemsHardwareTreeListControl_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            ((CalculatorProductionNormCostModule)Screen.Module).UpdateTotalCostIngredientPackaging(true);
        }
        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            Columns.Clear();
            #region InitTreeListColumns

            //AddTreeListColumns(0, CalculationProductionNormConst.MMCalculatorProductionNormItemSortOrder, false, true);//STT
            AddTreeListColumns(1, CalculationProductionNormConst.MMCalculatorProductionNormItemNo, true, false);//Ma vat tu
            AddTreeListColumns(2, CalculationProductionNormConst.MMCalculatorProductionNormItemICProductName, true, false);//Ten VT
            AddTreeListColumns(3, "MMCalculatorProductionNormItemProductDesc", true, false);//Mo ta
            AddTreeListColumns(4, "MMCalculatorProductionNormItemProductInsideDimensionLength", false, true);//KT lọt lòng dài
            AddTreeListColumns(5, "MMCalculatorProductionNormItemProductInsideDimensionWidth", false, true);//KT lọt lòng rộng
            AddTreeListColumns(6, "MMCalculatorProductionNormItemProductInsideDimensionHeight", false, true);//KT lọt lòng cao
            AddTreeListColumns(7, "MMCalculatorProductionNormItemProductOverallDimensionLength", false, true); //Phu bi dài
            AddTreeListColumns(8, "MMCalculatorProductionNormItemProductOverallDimensionWidth", false, true); //Phu bi rộng
            AddTreeListColumns(9, "MMCalculatorProductionNormItemProductOverallDimensionHeight", false, true); //Phu bi cao
            AddTreeListColumns(10, "FK_ICProdAttPackingMaterialSpecialityID", false, true);//Đặc tính
            AddTreeListColumns(11, "FK_ICProdAttPackingMaterialSizeID", false, true);//Khổ màng
            AddTreeListColumns(12, "FK_ICProdAttPackingMaterialWeightPerVolumeID", false, true);//Định lượng
            AddTreeListColumns(13, CalculationProductionNormConst.MMCalculatorProductionNormItemQuantity, false, true);//SL
            AddTreeListColumns(14, "MMCalculatorProductionNormItemProductUnitCost", false, true);
            AddTreeListColumns(15, "MMCalculatorProductionNormItemTotalCost", true, false);
            AddTreeListColumns(16, CalculationProductionNormConst.MMCalculatorProductionNormItemTotalQuantity, false, true);//Qty Inbox
            AddTreeListColumns(17, "MMCalculatorProductionNormItemComment", false, true);//Ghi chu
            AddTreeListColumns(18, "MMCalculatorProductionNormItemProductSizeAndPacking", false, true);//Kích thước/Quy cách
            AddTreeListColumns(19, CalculationProductionNormConst.FK_ICMeasureUnitID, false, true);//DVT
                                                                                                   // //AddTreeListColumns(8, CalculationProductionNormConst.MMCalculatorProductionNormItemPackagingICDepartmentAttribute2, true, false);//Qui cách
                                                                                                   // //AddTreeListColumns(9, CalculationProductionNormConst.MMCalculatorProductionNormItemPackagingICDepartmentAttribute4, true, false);////Định lượng
                                                                                                   //// AddTreeListColumns(10, "MMCalculatorProductionNormItemProductWeightPerVolume", false, true);
                                                                                                   // //AddTreeListColumns(11, CalculationProductionNormConst.MMCalculatorProductionNormItemPackagingAttribute, false, true);//Đặc tính
                                                                                                   // //AddTreeListColumns(12, CalculationProductionNormConst.MMCalculatorProductionNormItemPackagingICDepartmentAttribute7, false, true);//Chất lượng
                                                                                                   // //AddTreeListColumns(13, CalculationProductionNormConst.MMCalculatorProductionNormItemPackagingICDepartmentAttribute8, false, true);//Tỉ lệ pha
            AddTreeListColumns(20, CalculationProductionNormConst.MMCalculatorProductionNormItemPackagingNW, false, true);//NW
            AddTreeListColumns(21, CalculationProductionNormConst.MMCalculatorProductionNormItemPackagingGW, false, true);//GW




            // AddTreeListColumns(18, CalculationProductionNormConst.MMCalculatorProductionNormItemNeededTime, false, true);//Thoi gian can





            #endregion

            if (Columns["MMCalculatorProductionNormItemSortOrder"] == null)
            {
                this.BeginUpdate();
                TreeListColumn column = Columns.Add();
                column.FieldName = "MMCalculatorProductionNormItemSortOrder";
                column.Caption = "SortOrder";
                column.Visible = false;
                //column.SortOrder = SortOrder.Ascending;
                this.EndUpdate();
                this.Update();
            }
            this.OptionsView.ShowSummaryFooter = true;
        }
        public void AddTreeListColumns(int visibleIndex, string fieldName, bool readOnly, bool AllowEdit)
        {
            this.BeginUpdate();
            TreeListColumn column = Columns.Add();
            column.Visible = true;
            column.OptionsColumn.AllowEdit = AllowEdit;
            column.OptionsColumn.ReadOnly = readOnly;
            this.OptionsView.AutoWidth = false;

            column.OptionsColumn.FixedWidth = false;
            column.VisibleIndex = visibleIndex;
            column.FieldName = fieldName;
            //Get Caption
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            DataSet dsColumns = objAAColumnAliasController.GetAAColumnAliasByTableName("MMCalculatorProductionNormItems");
            if (dsColumns.Tables.Count > 0)
            {
                foreach (DataRow rowColumn in dsColumns.Tables[0].Rows)
                {
                    AAColumnAliasInfo objAAColumnAliasInfo = (AAColumnAliasInfo)objAAColumnAliasController.GetObjectFromDataRow(rowColumn);
                    if (objAAColumnAliasInfo != null)
                    {
                        if (fieldName == objAAColumnAliasInfo.AAColumnAliasName)
                        {
                            column.Caption = objAAColumnAliasInfo.AAColumnAliasCaption;
                        }
                        if (fieldName == "MMCalculatorProductionNormItemComment")
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemDescCaption;
                        if (fieldName == "MMCalculatorProductionNormItemProductDesc")
                            column.Caption = ProductionNormLocalizeResources.ICProductAttributeName;//Mo ta
                                                                                                    //if (fieldName == "MMCalculatorProductionNormItemProductAttributeValue2")
                                                                                                    //    column.Caption = ProductionNormLocalizeResources.MMHardwareItemSpecification;//Qui cách
                        if (fieldName == "MMCalculatorProductionNormItemProductOverallDimensionHeight")
                            column.Caption = "KT Phủ bì cao"; //Phu bi
                        if (fieldName == "MMCalculatorProductionNormItemProductOverallDimensionWidth")
                            column.Caption = "KT Phủ bì rộng"; //Phu bi
                        if (fieldName == "MMCalculatorProductionNormItemProductOverallDimensionLength")
                            column.Caption = "KT Phủ bì dài"; //Phu bi
                                                              //if (fieldName == "MMCalculatorProductionNormItemProductAttributeValue4")
                                                              //    column.Caption = ProductionNormLocalizeResources.MMCalculatorProductionNormItemSemiProductDepartmentAttribute5Caption; //Định lượng
                                                              //if (fieldName == "MMCalculatorProductionNormItemProductWeightPerVolume")
                                                              //    column.Caption = ProductionNormLocalizeResources.MMCalculatorProductionNormItemSemiProductDepartmentAttribute5Caption; //Định lượng
                        if (fieldName == "MMCalculatorProductionNormItemProductInsideDimensionHeight")
                            column.Caption = "KT Lọt lòng cao";//KT lọt lòng
                        if (fieldName == "MMCalculatorProductionNormItemProductInsideDimensionWidth")
                            column.Caption = "KT Lọt lòng rộng";//KT lọt lòng
                        if (fieldName == "MMCalculatorProductionNormItemProductInsideDimensionLength")
                            column.Caption = "KT Lọt lòng dài";//KT lọt lòng
                        if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemTotalQuantity)
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemPackagingProductQtyInBox;//KT lọt lòng
                        if (fieldName == "FK_ICProdAttPackingMaterialWeightPerVolumeID")
                            column.Caption = "Định lượng";
                        if (fieldName == "FK_ICProdAttPackingMaterialSizeID")
                            column.Caption = "Khổ màng foam";
                        if (fieldName == "FK_ICProdAttPackingMaterialSpecialityID")
                            column.Caption = "Đặc tính";

                    }
                }
            }
            dsColumns.Dispose();
            if (fieldName == "FK_ICProdAttPackingMaterialWeightPerVolumeID")
            {
                column.OptionsColumn.AllowEdit = true;
                //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                //repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Định lượng"));
                //repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                //repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                //column.ColumnEdit = repositoryItemLookUpEdit;
                //column.MinWidth = 150;
                //this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (fieldName == "FK_ICProdAttPackingMaterialSizeID")
            {
                column.OptionsColumn.AllowEdit = true;
                //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                //repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Khổ màng foam"));
                //repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditQ_QueryPopUp);
                //repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                //column.ColumnEdit = repositoryItemLookUpEdit;
                //column.MinWidth = 150;
                //this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (fieldName == "FK_ICProdAttPackingMaterialSpecialityID")
            {
                column.OptionsColumn.AllowEdit = true;
                //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                //repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));
                //repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditA_QueryPopUp);
                //repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                //column.ColumnEdit = repositoryItemLookUpEdit;
                //column.MinWidth = 150;
                //this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemSortOrder)
            {
                column.Caption = CalculationProductionNormConst.MMProductionNormOrderNoCaption;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Width = 70;
                column.BestFit();
            }
            if (fieldName == CalculationProductionNormConst.FK_ICMeasureUnitID)
            {
                column.OptionsColumn.AllowEdit = true;
                //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEdit.DisplayMember = "ICMeasureUnitName";
                //repositoryItemLookUpEdit.ValueMember = "ICMeasureUnitID";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                //repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditMeasureUnit_QueryPopUp);
                //column.ColumnEdit = repositoryItemLookUpEdit;
                //column.MinWidth = 50;
                //this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemICProductName)
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNamePackaging;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.BestFit();
            }
            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemNo)
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNoPackaging;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.BestFit();
            }
            if (fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemQuantity || fieldName == "MMCalculatorProductionNormItemProductLength"
               || fieldName == "MMCalculatorProductionNormItemProductHeight" || fieldName == "MMCalculatorProductionNormItemProductWidth"
               || fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemTotalQuantity || fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemDepreciationRate
               || fieldName == CalculationProductionNormConst.MMCalculatorProductionNormItemActualDepreciationRate || fieldName == "MMCalculatorProductionNormItemHardwareAssembleQuantity"
               || fieldName == "MMCalculatorProductionNormItemHardwareAllocationQuantity" || fieldName == "MMCalculatorProductionNormItemPackagingGW"
               || fieldName == "MMCalculatorProductionNormItemPackagingNW" || fieldName == "MMCalculatorProductionNormItemPackagingAllocationTotalQuantity"
               || fieldName == "MMCalculatorProductionNormItemProductOverallDimensionHeight" || fieldName == "MMCalculatorProductionNormItemProductOverallDimensionWidth"
               || fieldName == "MMCalculatorProductionNormItemProductOverallDimensionLength" || fieldName == "MMCalculatorProductionNormItemProductInsideDimensionHeight"
               || fieldName == "MMCalculatorProductionNormItemProductInsideDimensionWidth" || fieldName == "MMCalculatorProductionNormItemProductInsideDimensionLength"
               )
            {
                column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.Format.FormatString = "{0:n2}";
            }
            if (fieldName == "MMCalculatorProductionNormItemProductUnitCost"
                || fieldName == "MMCalculatorProductionNormItemTotalCost")
            {
                column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.Format.FormatString = "{0:n2}";
                column.AllNodesSummary = true;
                column.SummaryFooter = SummaryItemType.Sum;
                column.RowFooterSummaryStrFormat = CalculationProductionNormConst.ProducttionNormFormatN4;
            }
            this.OptionsView.ShowSummaryFooter = true;
            this.EndUpdate();
            this.Update();
        }
        //void repositoryItemLookUpEditMeasureUnit_QueryPopUp(object sender, CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
        //    List<ICMeasureUnitsInfo> ds = objMeasureUnitsController.GetAllAliveMeasureUnit();

        //    lookUpEdit.Properties.DataSource = ds;
        //}
        //void repositoryItemLookUpEditQ_QueryPopUp(object sender, CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
        //    ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
        //    List<ICProductAttributesInfo> list = objDepartmentAttributeValuesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.PackingMaterialSize.ToString());
        //    list.Insert(0, objProductAttributesInfo);
        //    lookUpEdit.Properties.DataSource = list;
        //}
        //void repositoryItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
        //    ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
        //    List<ICProductAttributesInfo> list = objDepartmentAttributeValuesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.PackingMaterialWeightPerVolume.ToString());
        //    list.Insert(0, objProductAttributesInfo);
        //    lookUpEdit.Properties.DataSource = list;
        //}
        //void repositoryItemLookUpEditA_QueryPopUp(object sender, CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
        //    ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
        //    List<ICProductAttributesInfo> list = objDepartmentAttributeValuesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.PackingMaterialSpeciality.ToString());
        //    list.Insert(0, objProductAttributesInfo);
        //    lookUpEdit.Properties.DataSource = list;
        //}
        private void ProductionNormItemsPackagingTreeListControl_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            if (e.Column.FieldName == CalculationProductionNormConst.FK_ICMeasureUnitID)
            {
                if (e.CellValue != null)
                {
                    int value = 0;
                    if (int.TryParse(e.CellValue.ToString(), out value))
                    {
                        ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
                        ICMeasureUnitsInfo objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByID(value);
                        if (objMeasureUnitsInfo != null)
                            e.CellText = objMeasureUnitsInfo.ICMeasureUnitName;
                    }
                }
            }
        }
        //public void repositoryItemUnitLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    DataTable dt = ((ProductionNormModule)Screen.Module).GetMeasureUnit();
        //    lookUpEdit.Properties.DataSource = dt;
        //}

        //private void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        //{
        //    CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;

        //    TreeListNode node = entity.ProductionNormItemPackagingList.TreeListControl.GetSelectedNode();

        //    if (node != null && node.Level > 0)
        //    {
        //        MMCalculatorProductionNormItemsInfo objProductionNormItemsInfo = new MMCalculatorProductionNormItemsInfo();
        //        objProductionNormItemsInfo = (MMCalculatorProductionNormItemsInfo)entity.ProductionNormItemPackagingList.CurrentObject;

        //        if (objProductionNormItemsInfo != null && objProductionNormItemsInfo.FK_ICProductID > 0)
        //            ((ProductionNormModule)Screen.Module).InvalidateProductionNormInventoryStockGridControl(objProductionNormItemsInfo.FK_ICProductID, ProductType.Hardware.ToString());
        //    }
        //}
    }
}
