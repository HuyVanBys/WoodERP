using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Data;
using System.Windows.Forms;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

using DevExpress.XtraGrid;
using DevExpress.Data;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using BOSCommon;
using DevExpress.XtraGrid.Views.Base;
using System.Globalization;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using BOSLib;
using System.Reflection;
using Localization;

namespace BOSERP.Modules.ProductionNorm
{
    public partial class ProductionNormItemsPackagingTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties
        #endregion

        protected override void InitTreeListDataSource()
        {
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList dataSource = new BOSTreeList();
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
            DataSource = entity.ProductionNormItemPackagingList; 
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
            
           // this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
            this.CustomDrawNodeCell += new CustomDrawNodeCellEventHandler(ProductionNormItemsPackagingTreeListControl_CustomDrawNodeCell);
        }
        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            Columns.Clear();
            #region InitTreeListColumns
            
            //AddTreeListColumns(0, ProductionNormConst.MMProductionNormItemSortOrder, false, true);//STT
            AddTreeListColumns(1, ProductionNormConst.MMProductionNormItemNo, true, false);//Ma vat tu
            AddTreeListColumns(2, ProductionNormConst.MMProductionNormItemICProductName, true, false);//Ten VT
            AddTreeListColumns(3, "MMProductionNormItemProductDesc", true, false);//Mo ta
            AddTreeListColumns(4, "MMProductionNormItemProductInsideDimensionLength", false, true);//KT lọt lòng dài
            AddTreeListColumns(5, "MMProductionNormItemProductInsideDimensionWidth", false, true);//KT lọt lòng rộng
            AddTreeListColumns(6, "MMProductionNormItemProductInsideDimensionHeight", false, true);//KT lọt lòng cao
            AddTreeListColumns(7, "MMProductionNormItemProductOverallDimensionLength", false, true); //Phu bi dài
            AddTreeListColumns(8, "MMProductionNormItemProductOverallDimensionWidth", false, true); //Phu bi rộng
            AddTreeListColumns(9, "MMProductionNormItemProductOverallDimensionHeight", false, true); //Phu bi cao
            AddTreeListColumns(10, "FK_ICProdAttPackingMaterialSpecialityID", false, true);//Đặc tính
            AddTreeListColumns(11, "FK_ICProdAttPackingMaterialSizeID", false, true);//Khổ màng
            AddTreeListColumns(12, "FK_ICProdAttPackingMaterialWeightPerVolumeID", false, true);//Định lượng
            AddTreeListColumns(13, ProductionNormConst.MMProductionNormItemQuantity, false, true);//SL
            AddTreeListColumns(14, ProductionNormConst.MMProductionNormItemTotalQuantity, false, true);//Qty Inbox
            AddTreeListColumns(15, "MMProductionNormItemComment", false, true);//Ghi chu
            AddTreeListColumns(16, "MMProductionNormItemProductSizeAndPacking", false, true);//Kích thước/Quy cách
            AddTreeListColumns(17, ProductionNormConst.FK_ICMeasureUnitID, false, true);//DVT
           // //AddTreeListColumns(8, ProductionNormConst.MMProductionNormItemPackagingICDepartmentAttribute2, true, false);//Qui cách
           // //AddTreeListColumns(9, ProductionNormConst.MMProductionNormItemPackagingICDepartmentAttribute4, true, false);////Định lượng
           //// AddTreeListColumns(10, "MMProductionNormItemProductWeightPerVolume", false, true);
           // //AddTreeListColumns(11, ProductionNormConst.MMProductionNormItemPackagingAttribute, false, true);//Đặc tính
           // //AddTreeListColumns(12, ProductionNormConst.MMProductionNormItemPackagingICDepartmentAttribute7, false, true);//Chất lượng
           // //AddTreeListColumns(13, ProductionNormConst.MMProductionNormItemPackagingICDepartmentAttribute8, false, true);//Tỉ lệ pha
            AddTreeListColumns(18, ProductionNormConst.MMProductionNormItemPackagingNW, false, true);//NW
            AddTreeListColumns(19, ProductionNormConst.MMProductionNormItemPackagingGW, false, true);//GW
            
            
            
            
           // AddTreeListColumns(18, ProductionNormConst.MMProductionNormItemNeededTime, false, true);//Thoi gian can
            
            
           
            

            #endregion
            
            if (Columns["MMProductionNormItemSortOrder"] == null)
            {
                this.BeginUpdate();
                TreeListColumn column = Columns.Add();
                column.FieldName = "MMProductionNormItemSortOrder";
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
            DataSet dsColumns = objAAColumnAliasController.GetAAColumnAliasByTableName(TableName.MMProductionNormItemsTableName);
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
                            if (fieldName == "MMProductionNormItemComment")
                                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemDescCaption;
                            if (fieldName == "MMProductionNormItemProductDesc")
                                column.Caption = ProductionNormLocalizeResources.ICProductAttributeName;//Mo ta
                            //if (fieldName == "MMProductionNormItemProductAttributeValue2")
                            //    column.Caption = ProductionNormLocalizeResources.MMHardwareItemSpecification;//Qui cách
                            if (fieldName == "MMProductionNormItemProductOverallDimensionHeight")
                                column.Caption = "KT Phủ bì cao"; //Phu bi
                            if (fieldName == "MMProductionNormItemProductOverallDimensionWidth")
                                column.Caption = "KT Phủ bì rộng"; //Phu bi
                            if (fieldName == "MMProductionNormItemProductOverallDimensionLength")
                                column.Caption = "KT Phủ bì dài"; //Phu bi
                            //if (fieldName == "MMProductionNormItemProductAttributeValue4")
                            //    column.Caption = ProductionNormLocalizeResources.MMProductionNormItemSemiProductDepartmentAttribute5Caption; //Định lượng
                            //if (fieldName == "MMProductionNormItemProductWeightPerVolume")
                            //    column.Caption = ProductionNormLocalizeResources.MMProductionNormItemSemiProductDepartmentAttribute5Caption; //Định lượng
                            if (fieldName == "MMProductionNormItemProductInsideDimensionHeight")
                                column.Caption = "KT Lọt lòng cao";//KT lọt lòng
                            if (fieldName == "MMProductionNormItemProductInsideDimensionWidth")
                                column.Caption = "KT Lọt lòng rộng";//KT lọt lòng
                            if (fieldName == "MMProductionNormItemProductInsideDimensionLength")
                                column.Caption = "KT Lọt lòng dài";//KT lọt lòng
                            if (fieldName == ProductionNormConst.MMProductionNormItemTotalQuantity)
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
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Định lượng"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 150;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (fieldName == "FK_ICProdAttPackingMaterialSizeID")
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Khổ màng foam"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditQ_QueryPopUp);
                repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 150;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (fieldName == "FK_ICProdAttPackingMaterialSpecialityID")
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditA_QueryPopUp);
                repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 150;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (fieldName == ProductionNormConst.MMProductionNormItemSortOrder)
            {
                column.Caption = ProductionNormConst.MMProductionNormOrderNoCaption;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Width = 70;
                column.BestFit();
            }
            if (fieldName == ProductionNormConst.FK_ICMeasureUnitID)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICMeasureUnitName";
                repositoryItemLookUpEdit.ValueMember = "ICMeasureUnitID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditMeasureUnit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 50;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (fieldName == ProductionNormConst.MMProductionNormItemICProductName)
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNamePackaging;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.BestFit();
            }
            if (fieldName == ProductionNormConst.MMProductionNormItemNo)
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNoPackaging;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.BestFit();
            }
            if (fieldName == ProductionNormConst.MMProductionNormItemQuantity || fieldName == "MMProductionNormItemProductLength"
               || fieldName == "MMProductionNormItemProductHeight" || fieldName == "MMProductionNormItemProductWidth"
               || fieldName == ProductionNormConst.MMProductionNormItemTotalQuantity || fieldName == ProductionNormConst.MMProductionNormItemDepreciationRate
               || fieldName == ProductionNormConst.MMProductionNormItemActualDepreciationRate || fieldName == "MMProductionNormItemHardwareAssembleQuantity"
               || fieldName == "MMProductionNormItemHardwareAllocationQuantity" || fieldName == "MMProductionNormItemPackagingGW"
               || fieldName == "MMProductionNormItemPackagingNW" || fieldName == "MMProductionNormItemPackagingAllocationTotalQuantity"
               || fieldName == "MMProductionNormItemProductOverallDimensionHeight" || fieldName == "MMProductionNormItemProductOverallDimensionWidth"
               || fieldName == "MMProductionNormItemProductOverallDimensionLength" || fieldName == "MMProductionNormItemProductInsideDimensionHeight"
               || fieldName == "MMProductionNormItemProductInsideDimensionWidth" || fieldName == "MMProductionNormItemProductInsideDimensionLength"
               )
            {
                column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.Format.FormatString = "{0:n2}";
            }
            
            this.EndUpdate();
            this.Update();
        }
        void repositoryItemLookUpEditMeasureUnit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            List<ICMeasureUnitsInfo> ds = objMeasureUnitsController.GetAllAliveMeasureUnit();

            lookUpEdit.Properties.DataSource = ds;
        }
        void repositoryItemLookUpEditQ_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            List<ICProductAttributesInfo> list = objDepartmentAttributeValuesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.PackingMaterialSize.ToString());
            list.Insert(0, objProductAttributesInfo);
            lookUpEdit.Properties.DataSource = list;
        }
        void repositoryItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            List<ICProductAttributesInfo> list = objDepartmentAttributeValuesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.PackingMaterialWeightPerVolume.ToString());
            list.Insert(0, objProductAttributesInfo);
            lookUpEdit.Properties.DataSource = list;
        }
        void repositoryItemLookUpEditA_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            List<ICProductAttributesInfo> list = objDepartmentAttributeValuesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.PackingMaterialSpeciality.ToString());
            list.Insert(0, objProductAttributesInfo);
            lookUpEdit.Properties.DataSource = list;
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
        //    ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
           
        //    TreeListNode node = entity.ProductionNormItemPackagingList.TreeListControl.GetSelectedNode();

        //    if (node != null && node.Level > 0)
        //    {
        //        MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
        //        objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemPackagingList.CurrentObject;

        //        if (objProductionNormItemsInfo != null && objProductionNormItemsInfo.FK_ICProductID > 0)
        //            ((ProductionNormModule)Screen.Module).InvalidateProductionNormInventoryStockGridControl(objProductionNormItemsInfo.FK_ICProductID, ProductType.Hardware.ToString());
        //    }
        //}
    }
}
