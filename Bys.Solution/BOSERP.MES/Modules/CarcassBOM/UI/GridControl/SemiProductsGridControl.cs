using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.CarcassBOM.UI;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public partial class SemiProductsGridControl : BOSGridControl
    {
        List<ICProductsInfo> objProductsInfoList { get; set; }

        List<MMMaterialDepartmentsInfo> MaterialDepartList { get; set; }

        private List<MMFormulasInfo> FormulasList { get; set; }

        private List<ICProductGroupsInfo> ProductGroupsList { get; set; }

        private bool IsDoubleClick = false;
        MMAllocationOperationConfigsInfo DefualtAOConfigs { get; set; }
        public override void InitGridControlDataSource()
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductList;
            this.DataSource = bds;
        }
        public List<MMFormulasInfo> GetFormulasDataSource()
        {
            MMFormulasController objFormulasController = new MMFormulasController();
            List<MMFormulasInfo> formulasList = new List<MMFormulasInfo>();
            DataSet ds = (DataSet)BOSApp.LookupTables["MMFormulas"];
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData("MMFormulas");
            }
            formulasList = (List<MMFormulasInfo>)objFormulasController.GetListFromDataSet(ds);
            if (!formulasList.Exists(o => o.MMFormulaID == 0))
                formulasList.Insert(0, new MMFormulasInfo());

            return formulasList;
        }
        public List<ICProductGroupsInfo> GetProductGroupsDataSource()
        {
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            ICDepartmentsInfo objICDepartmentsInfo = (ICDepartmentsInfo)(new ICDepartmentsController()).GetObjectByNo(BOSApp.GetDisplayTextFromConfigText(ConfigValueGroup.DepartmentGroup, DepartmentGroup.SemiProductNo.ToString()));
            List<ICProductGroupsInfo> productsList = new List<ICProductGroupsInfo>();
            DataSet ds = (DataSet)BOSApp.LookupTables["ICProductGroups"];
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData("ICProductGroups");
            }
            productsList = (List<ICProductGroupsInfo>)objProductGroupsController.GetListFromDataSet(ds);
            if (objICDepartmentsInfo != null) productsList = productsList.Where(o => o.FK_ICDepartmentID == objICDepartmentsInfo.ICDepartmentID).ToList();
            if (productsList != null)
                productsList.Insert(0, new ICProductGroupsInfo());
            return productsList;
        }
        public void LoadGrid(BaseModuleERP module, BOSScreen screen)
        {
            this.Screen = screen;
            this.Screen.Module = module;
            InitializeGridView();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridview = base.InitializeGridView();
            gridview.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridview.OptionsView.ShowDetailButtons = true;
            gridview.OptionsDetail.AllowExpandEmptyDetails = true;
            gridview.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            gridview.OptionsDetail.ShowDetailTabs = false;
            gridview.InitNewRow += Gridview_InitNewRow;
            gridview.DoubleClick += new System.EventHandler(gridview_DoubleClick);
            gridview.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gridView1_MasterRowEmpty);
            gridview.RowCellStyle += new RowCellStyleEventHandler(gridview_RowCellStyle);
            gridview.MasterRowGetChildList += new MasterRowGetChildListEventHandler(gridview_MasterRowGetChildList);
            gridview.MasterRowGetRelationName += new MasterRowGetRelationNameEventHandler(gridview_MasterRowGetRelationName);
            gridview.MasterRowGetRelationCount += new MasterRowGetRelationCountEventHandler(gridview_MasterRowGetRelationCount);
            gridview.MasterRowExpanded += new CustomMasterRowEventHandler(gridview_MasterRowExpanded);
            gridview.MasterRowExpanding += new MasterRowCanExpandEventHandler(gridview_MasterRowExpanding);
            gridview.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridview_FocusedRowChanged);
            gridview.CustomColumnDisplayText += Gridview_CustomColumnDisplayText;
            MaterialDepartList = (new MMMaterialDepartmentsController()).GetAllMaterialDepartment();
            objProductsInfoList = ((CarcassBOMModule)Screen.Module).GetWoodIngredient(MaterialDepartList);
            DefualtAOConfigs = (new MMAllocationOperationConfigsController().GetDefualtAllocationOperationConfigs());
            FormulasList = GetFormulasDataSource();
            ProductGroupsList = GetProductGroupsDataSource();

            GridColumn column = gridview.Columns["ICProductCode"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            if (gridview.Columns["ICProductNo"] != null)
                gridview.Columns.Remove(gridview.Columns["ICProductNo"]);
            column = gridview.Columns["ICProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemBOSLookupEdit semeiLookUpEdit = new RepositoryItemBOSLookupEdit();
                semeiLookUpEdit.DisplayMember = "ICProductNo";
                semeiLookUpEdit.ValueMember = "ICProductID";
                semeiLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                semeiLookUpEdit.SearchMode = SearchMode.AutoFilter;
                semeiLookUpEdit.NullText = string.Empty;
                semeiLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductCode", "Code", 100));
                semeiLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã", 100));
                semeiLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên", 200));
                semeiLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả", 200));
                semeiLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductHeight", "Dày", 50));
                semeiLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductWidth", "Rộng", 50));
                semeiLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductLength", "Dài", 50));
                semeiLookUpEdit.DataSource = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.SemiProduct.ToString() ||
                                                                                        o.ICProductType == ProductType.Product.ToString()).ToList();
                semeiLookUpEdit.PopupWidth = 750;
                column.ColumnEdit = semeiLookUpEdit;
            }
            column = gridview.Columns["ICProductName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridview.Columns["ICProductHeight"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "n2");
            }
            column = gridview.Columns["ICProductWidth"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "n2");
            }
            column = gridview.Columns["ICProductLength"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "n2");
            }
            column = gridview.Columns["ICProductDiameter"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "n2");
            }
            column = gridview.Columns["HasComponent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridview.Columns["ICProductHavePaint"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridview.Columns["ICProductDepreciationRate"];
            if (column != null)
            {
                FormatNumbericColumn(column, true, "n2");
            }
            column = gridview.Columns["FK_ICProductWoodIngredientID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridview.Columns["FK_ICProductBasicUnitID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridview.Columns["ICProductDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridview.Columns["FK_MMFormulaIDPaintA"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = FormulaConst.MMFormulaName;
                repositoryItemLookUpEdit.ValueMember = FormulaConst.MMFormulaID;
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(FormulaConst.MMFormulaNo, FormulaConst.MMFormulaNoCaption));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(FormulaConst.MMFormulaName, FormulaConst.MMFormulaNameCaption));
                repositoryItemLookUpEdit.DataSource = FormulasList.Where(o => o.MMFormulaType == "Paint" || o.MMFormulaID == 0).ToList();
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 150;
            }

            column = gridview.Columns["FK_MMFormulaIDPaintB"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = FormulaConst.MMFormulaName;
                repositoryItemLookUpEdit.ValueMember = FormulaConst.MMFormulaID;
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(FormulaConst.MMFormulaNo, FormulaConst.MMFormulaNoCaption));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(FormulaConst.MMFormulaName, FormulaConst.MMFormulaNameCaption));
                repositoryItemLookUpEdit.DataSource = FormulasList.Where(o => o.MMFormulaType == "Paint" || o.MMFormulaID == 0).ToList();
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridview.Columns["FK_MMFormulaIDPaintC"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = FormulaConst.MMFormulaName;
                repositoryItemLookUpEdit.ValueMember = FormulaConst.MMFormulaID;
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(FormulaConst.MMFormulaNo, FormulaConst.MMFormulaNoCaption));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(FormulaConst.MMFormulaName, FormulaConst.MMFormulaNameCaption));
                repositoryItemLookUpEdit.DataSource = FormulasList.Where(o => o.MMFormulaType == "Paint" || o.MMFormulaID == 0).ToList();
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridview.Columns["MMProductionNormItemProductSizeAndPacking"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridview.Columns["ICProductJoinery"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridview.Columns["FK_MMProcessID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridview.Columns["FK_ICProductAttributeWoodTypeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridview.Columns["ICProductOriginOfProduct"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridview.Columns["FK_ICProductAttributeSemiProductSpecialityID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridview.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridview.Columns["ICProductDetailSerial"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridview.Columns["FK_ICProductGroupID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductGroupName";
                repositoryItemLookUpEdit.ValueMember = "ICProductGroupID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductGroupNo", "Mã nhóm"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductGroupName", "Tên nhóm"));

                repositoryItemLookUpEdit.DataSource = ProductGroupsList;
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridview.Columns["ICProductComment"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Caption = "Ghi chú mô tả";
            }
            column = gridview.Columns["FK_ICProductAttributeColorID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Caption = "Màu sơn";
            }
            column = gridview.Columns["ICProductAttributeColorText"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridview.Columns["ICProductOrderID"];
            if (column != null)
            {
                column.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }
            return gridview;
        }

        private void Gridview_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Column.FieldName == "ICProductID")
            {
                int id = 0;
                int.TryParse(e.Value.ToString(), out id);
                e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", id, "ICProductNo");
            }
            if (e.Value != null && e.Column.FieldName == "ICProductColorAttribute")
            {
                e.DisplayText = GetColorDisplayText(e.Value.ToString());
            }
            if (e.Value != null && ( e.Column.FieldName == "ICProductColorPaintA" 
                || e.Column.FieldName == "ICProductColorPaintB" 
                || e.Column.FieldName == "ICProductColorPaintC"
                || e.Column.FieldName == "ICProductPaintProcess")
                )
            {
                e.DisplayText = GetPaintProcessDisplayText(e.Value.ToString());
            }
        }
        private void Paint_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            lookUpEdit.Properties.DataSource = GetFormulasDataSource();
            lookUpEdit.Properties.DisplayMember = "MMFormulaNo";
            lookUpEdit.Properties.ValueMember = "MMFormulaID";
        }

        private void Gridview_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);
            GridView gridView = (GridView)sender;
            ICProductsInfo product = (ICProductsInfo)gridView.GetRow(e.RowHandle);
            if (product == null)
                return;

            ICPriceCalculationMethodsController objPriceCalculationMethodsController = new ICPriceCalculationMethodsController();
            ICPriceCalculationMethodsInfo objPriceCalculationMethodsInfo = objPriceCalculationMethodsController.GetPriceCalculationMethodDefault();
            if (objPriceCalculationMethodsInfo == null)
                objPriceCalculationMethodsInfo = new ICPriceCalculationMethodsInfo();

            product.FK_ICPriceCalculationMethodID = objPriceCalculationMethodsInfo.ICPriceCalculationMethodID;
        }

        void gridview_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        void gridview_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "FK_ICProductCarcassID";
        }

        void gridview_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            GridView gridview = sender as GridView;
            if (gridview == null)
                return;
            ICProductsInfo product = (ICProductsInfo)gridview.GetRow(e.RowHandle);
            if (product == null)
                return;

            e.ChildList = product.MaterialList;
        }

        void gridview_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gridview = (GridView)MainView;
            gridview.CollapseAllDetails();
        }

        void gridview_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = (GridView)MainView;

            ICProductsInfo product = (ICProductsInfo)gridView.GetRow(e.RowHandle);
            if (product != null && product.HasComponent)
            {
                e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold);
            }
            else
            {
                e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Regular);
            }
        }

        void rpItemComponent_Click(object sender, System.EventArgs e)
        {
            GridView gridView = (GridView)MainView;

            ICProductsInfo product = (ICProductsInfo)gridView.GetFocusedRow();
            if (product != null)
            {
                string imgName = ((CarcassBOMModule)Screen.Module).BrowseFile(false);
                if (!string.IsNullOrEmpty(imgName))
                {
                    product.ICProductImageName = imgName;
                    this.RefreshDataSource();
                }
            }
        }

        void gridview_MasterRowExpanding(object sender, MasterRowCanExpandEventArgs e)
        {
            if (IsDoubleClick)
            {
                e.Allow = false;
                IsDoubleClick = false;
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView view1 = (GridView)sender;
            ICProductsInfo item = (ICProductsInfo)view1.GetFocusedRow();
            if (item != null)
            {
                CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;

                if (e.Column.FieldName == "ICProductID")
                {
                    if (item.FK_MMProductionNormID == 0)
                    {
                        int id = 0;
                        int.TryParse(e.Value.ToString(), out id);
                        List<ICProductsInfo> exits = entity.ProductList.Where(o => o.ICProductID == id).ToList();
                        int bomID = entity.ProductList.Where(o => o.FK_MMProductionNormID > 0).Select(o => o.FK_MMProductionNormID).FirstOrDefault();
                        if (exits != null && exits.Count > 1)
                        {
                            BOSApp.ShowMessage("Chi tiết đã tồn tại trong danh sách");
                            item.ICProductID = 0;
                            return;
                        }

                        ICProductsForViewInfo iProduct = BOSApp.CurrentProductList.FirstOrDefault(t => t.ICProductID == id);
                        if (iProduct != null)
                        {
                            BOSUtil.CopyObject(iProduct, item);
                            item.FK_ICProductParentID = 0;
                            item.FK_MMProductionNormID = bomID;
                            decimal rate = 0;
                            if (((CarcassBOMModule)Screen.Module).DepreciationRateTextBox.Text != null)
                                decimal.TryParse(((CarcassBOMModule)Screen.Module).DepreciationRateTextBox.Text, out rate);
                            if (rate > 0 && item.ICProductDepreciationRate == 0)
                            {
                                item.ICProductDepreciationRate = rate;
                            }
                            if (id > 0 && BOSApp.ShowMessageYesNo("Bạn muốn sao chép nguyên liệu không?") == DialogResult.Yes)
                            {
                                guiCopyMaterial guiFind = new guiCopyMaterial(id, 0, null);
                                guiFind.Module = this.Screen.Module;
                                if (guiFind.ShowDialog() == DialogResult.OK)
                                {
                                    List<ICProductItemMaterialsInfo> pimList = guiFind.SelectedObjects;
                                    item.MaterialList = new BindingList<ICProductItemMaterialsInfo>();
                                    ICProductItemMaterialsInfo pim;
                                    pimList.ForEach(m =>
                                    {
                                        pim = (ICProductItemMaterialsInfo)m.Clone();
                                        pim.FK_ICProductCarcassID = ((CarcassBOMModule)Screen.Module).CurrentCarcass.ICProductID;
                                        pim.ICProductItemMaterialID = 0;
                                        pim.FK_MMProductionNormID = bomID;
                                        item.MaterialList.Add(pim);
                                    });
                                }
                            }
                        }
                        else
                        {
                            item = new ICProductsInfo();
                        }


                    }
                    else
                    {
                        BOSApp.ShowMessage("Chi tiết đã lưu bạn không thể thay đổi!");
                        item.ICProductID = int.Parse(view1.ActiveEditor.OldEditValue.ToString());
                        return;
                    }
                }
                else if (item.FK_MMProductionNormID > 0)
                {
                    List<ICProductDetailsInfo> result = ((CarcassBOMModule)Screen.Module).GetListParent(item.ICProductID);
                    if ((e.Column.FieldName == "ICProductNo" || e.Column.FieldName == "ICProductName" ||
                        e.Column.FieldName == "FK_ICProductBasicUnitID" || e.Column.FieldName == "ICProductDesc" ||
                        e.Column.FieldName == "FK_ICProductGroupID") && result.Count() > 1)
                    {
                        BOSApp.ShowMessage("Chi tiết thuộc định mức khác bạn không thể thay đổi giá trị!");
                        if (e.Column.FieldName == "ICProductNo")
                        {
                            item.ICProductNo = view1.ActiveEditor.OldEditValue.ToString();
                        }
                        else if (e.Column.FieldName == "ICProductName")
                        {
                            item.ICProductName = view1.ActiveEditor.OldEditValue.ToString();
                        }
                        else if (e.Column.FieldName == "FK_ICProductBasicUnitID")
                        {
                            item.FK_ICProductBasicUnitID = int.Parse(view1.ActiveEditor.OldEditValue.ToString());
                        }
                        else if (e.Column.FieldName == "FK_ICProductGroupID")
                        {
                            item.FK_ICProductGroupID = int.Parse(view1.ActiveEditor.OldEditValue.ToString());
                        }
                        else if (e.Column.FieldName == "ICProductDesc")
                        {
                            item.ICProductDesc = view1.ActiveEditor.OldEditValue.ToString();
                        }

                        return;
                    }
                }
                int maxIndex = 0;
                if (entity.ProductList.Count() > 0)
                {
                    maxIndex = entity.ProductList.Select(t => t.ICProductOrderID).Max();
                }
                if (item.ICProductOrderID == 0)
                    item.ICProductOrderID = ++maxIndex;

                if (e.Column.FieldName == "FK_MMFormulaIDPaintA"
                    || e.Column.FieldName == "FK_MMFormulaIDPaintB"
                    || e.Column.FieldName == "FK_MMFormulaIDPaintC")
                {
                    if (item.FK_MMFormulaIDPaintA > 0
                        || item.FK_MMFormulaIDPaintB > 0
                        || item.FK_MMFormulaIDPaintC > 0)
                    {
                        item.ICProductHavePaint = true;
                    }
                    else
                    {
                        item.ICProductHavePaint = false;
                    }
                }
            }

            if (e.Column.FieldName == "ICProductLength"
                || e.Column.FieldName == "ICProductWidth"
                || e.Column.FieldName == "ICProductHeight"
                || e.Column.FieldName == "ICProductDepreciationRate"
                || e.Column.FieldName == "HasComponent"
                )
            {
                ((CarcassBOMModule)Screen.Module).RecalDepreciationAllItem();
            }
        }

        void gridview_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            GridView gridView = (GridView)sender;
            GridView detail = (GridView)gridView.GetDetailView(e.RowHandle, e.RelationIndex);
            if (detail == null)
                return;

            gridView.BeginUpdate();
            detail.OptionsView.ShowAutoFilterRow = false;
            detail.OptionsView.ShowFooter = false;
            detail.Columns.Clear();
            ADReportsController reportController = new ADReportsController();
            List<BOSLib.AAColumnAliasInfo> columnAlias = reportController.GetByTableNameWithNumberIntOrder("ICProductItemMaterials");

            GridColumn column;
            int visibleIndex = 0;
            columnAlias.ForEach(col =>
            {

                column = new GridColumn();
                column.Caption = col.AAColumnAliasCaption;
                column.FieldName = col.AAColumnAliasName;
                column.Visible = true;
                column.VisibleIndex = visibleIndex++;
                column.OptionsColumn.AllowEdit = true;
                detail.Columns.Add(column);

                if (column.FieldName == "FK_ICProductMaterialID")
                {
                    RepositoryItemBOSLookupEdit materialLookUpEdit = new RepositoryItemBOSLookupEdit();
                    materialLookUpEdit.DisplayMember = "ICProductNo";
                    materialLookUpEdit.ValueMember = "ICProductID";
                    materialLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                    materialLookUpEdit.SearchMode = SearchMode.AutoFilter;
                    materialLookUpEdit.NullText = string.Empty;
                    materialLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã nguyên liệu", 150));
                    materialLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên nguyên liệu", 300));
                    materialLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả", 300));
                    if (objProductsInfoList.Count() == 0)
                        objProductsInfoList = ((CarcassBOMModule)Screen.Module).GetWoodIngredient(MaterialDepartList);
                    materialLookUpEdit.DataSource = objProductsInfoList;
                    column.ColumnEdit = materialLookUpEdit;
                    column.MinWidth = 750;
                }
                else if (column.FieldName == "FK_ICMeasureUnitID")
                {
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ICMeasureUnitName";
                    repositoryItemLookUpEdit.ValueMember = "ICMeasureUnitID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitNo", "Mã ĐVT", 150));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "Tên ĐVT", 300));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repMeasureUnit_QueryPopUp);

                    column.ColumnEdit = repositoryItemLookUpEdit;
                    column.MinWidth = 150;
                }
                else if (column.FieldName == "FK_MMOperationID")
                {
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "MMOperationName";
                    repositoryItemLookUpEdit.ValueMember = "MMOperationID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationNo", "Mã", 150));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationName", "Tên công đoạn", 150));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(reqOperation_QueryPopUp);

                    column.ColumnEdit = repositoryItemLookUpEdit;
                    column.MinWidth = 150;
                }

                else if (column.FieldName == "FK_MMFormulaID")
                {
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "MMFormulaNo";
                    repositoryItemLookUpEdit.ValueMember = "MMFormulaID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMFormulaNo", "Mã CT", 150));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMFormulaName", "Tên CT", 300));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMFormulaDesc", "Mô tả", 300));
                    repositoryItemLookUpEdit.DataSource = FormulasList.Where(o => o.MMFormulaType == "AddMaterial").ToList();
                    column.ColumnEdit = repositoryItemLookUpEdit;
                    column.MinWidth = 150;
                }
                else if (column.FieldName == "ICProductItemMaterialQty")
                {
                    FormatNumbericColumn(column, false, "n4");
                }
                else if (column.FieldName == "ICProductItemMaterialLength"
                        || column.FieldName == "ICProductItemMaterialWidth"
                     || column.FieldName == "ICProductItemMaterialHeigth")
                {
                    FormatNumbericColumn(column, true, "n2");
                }
                else if (column.FieldName == "ICProductItemMaterialDepreciationRate")
                {
                    FormatNumbericColumn(column, true, "n2");
                }
                else if (column.FieldName == "ICProductItemMaterialWoodQty" )
                {
                    FormatNumbericColumn(column, true, "n5");
                }
                else if (column.FieldName == "ICProductItemMaterialDepreciationQty")
                {
                    FormatNumbericColumn(column, true, "n6");
                }

            });
            detail.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridview_CustomColumnDisplayText1);
            detail.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(detail_CellValueChanged);
            detail.KeyUp += new KeyEventHandler(detail_KeyUp);
            detail.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.EndUpdate();
        }

        void detail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                GridView view = (GridView)sender;
                BindingList<ICProductItemMaterialsInfo> lst = (BindingList<ICProductItemMaterialsInfo>)view.DataSource;
                ICProductItemMaterialsInfo item = (ICProductItemMaterialsInfo)view.GetFocusedRow();
                lst.Remove(item);
                view.RefreshData();
                ((CarcassBOMModule)Screen.Module).RecalDepreciationAllItem();
            }
        }

        private void gridView1_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            e.IsEmpty = false;
        }

        void detail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView == null)
                return;

            GridView mainView = (GridView)this.MainView;
            ICProductItemMaterialsInfo item = (ICProductItemMaterialsInfo)gridView.GetFocusedRow();
            if (item != null)
            {
                if (e.Column.FieldName == "FK_ICProductMaterialID"
                    || e.Column.FieldName == "FK_MMFormulaID")
                {
                    ICProductsInfo parent = (ICProductsInfo)mainView.GetFocusedRow();
                    ((CarcassBOMModule)Screen.Module).ChangeIngredient(item, parent, true);
                    if (item.FK_MMOperationID == 0)
                    {
                        ICProductsForViewInfo material = BOSApp.CurrentProductList.Where(m => m.ICProductID == item.FK_ICProductMaterialID).FirstOrDefault();
                        if (material != null)
                        {
                            MMOperationAndHardwareOperationTypesInfo dfOperation
                                = ((CarcassBOMModule)Screen.Module).DefualtAllocationOperationList.Where(d => d.MMHardwareOperationType == material.ICProductType).FirstOrDefault();
                            if (dfOperation != null) item.FK_MMOperationID = dfOperation.FK_MMOperationID;
                            if (item.FK_MMOperationID == 0)
                            {
                                MMDefaultAllocationOperationConfigsController objDfOperationsController = new MMDefaultAllocationOperationConfigsController();
                                MMDefaultAllocationOperationConfigsInfo dfOperationsInfo = (MMDefaultAllocationOperationConfigsInfo)objDfOperationsController.GetOperationByDepartmentAndProductGroup(material.FK_ICDepartmentID, material.FK_ICProductGroupID);
                                if (dfOperationsInfo != null) item.FK_MMOperationID = dfOperationsInfo.FK_MMOperationID;
                            }    
                        }
                    }
                }
                if (e.Column.FieldName == "FK_ICProductMaterialID"
                    || e.Column.FieldName == "ICProductItemMaterialLength"
                    || e.Column.FieldName == "ICProductItemMaterialWidth"
                    || e.Column.FieldName == "ICProductItemMaterialHeigth"
                    || e.Column.FieldName == "ICProductItemMaterialWoodQty"
                    || e.Column.FieldName == "ICProductItemMaterialDepreciationRate"
                    || e.Column.FieldName == "ICProductItemMaterialDepreciationQty")
                {
                    ((CarcassBOMModule)Screen.Module).RecalDepreciationAllItem();
                }
            }
        }

        void repositoryItemLookUpEdit_QueryPopUp1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            objProductsInfoList = ((CarcassBOMModule)Screen.Module).GetWoodIngredient(MaterialDepartList);
            lookUpEdit.Properties.DataSource = objProductsInfoList;
        }

        public void reqOperation_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (BOSApp.LookupTables.Contains(TableName.MMOperationsTableName))
            {
                MMOperationsController control = new MMOperationsController();
                DataSet ds = (DataSet)BOSApp.LookupTables[TableName.MMOperationsTableName];
                if (ds != null && ds.Tables.Count > 0)
                {
                    List<MMOperationsInfo> operationList = (List<MMOperationsInfo>)control.GetListFromDataSet(ds);
                    if (operationList != null) operationList = operationList.Where(o =>
                        (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsPlan.ToString() && o.MMOperationIsPlan)
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsStock.ToString() && o.MMOperationInOutStockCheck)
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsPlanAndStock.ToString() && o.MMOperationInOutStockCheck && o.MMOperationIsPlan)
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsPlanOrStock.ToString() && (o.MMOperationInOutStockCheck || o.MMOperationIsPlan))
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.AllOperation.ToString())
                        || (DefualtAOConfigs == null)
                        ).ToList();
                    lookUpEdit.Properties.DataSource = operationList;
                }
            }
        }

        void repMeasureUnit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (BOSApp.LookupTables.Contains(TableName.ICMeasureUnitsTableName))
            {
                DataSet ds = (DataSet)BOSApp.LookupTables[TableName.ICMeasureUnitsTableName];
                if (ds != null && ds.Tables.Count > 0)
                {
                    lookUpEdit.Properties.DataSource = ds.Tables[0];
                }
            }


        }

        void gridview_CustomColumnDisplayText1(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null)
            {
                if (e.Column.FieldName == "FK_ICProductMaterialID")
                {
                    int id = 0;
                    int.TryParse(e.Value.ToString(), out id);
                    ICProductsInfo iProduct = objProductsInfoList.FirstOrDefault(t => t.ICProductID == id);
                    if (iProduct != null)
                    {
                        e.DisplayText = iProduct.ICProductName;
                    }
                    else
                    {
                        e.DisplayText = string.Empty;
                    }
                }
                if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    int id = 0;
                    int.TryParse(e.Value.ToString(), out id);
                    if (id > 0)
                        e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICMeasureUnits", "ICMeasureUnitID", id, "ICMeasureUnitName");
                    else
                        e.DisplayText = string.Empty;
                }
                if (e.Column.FieldName == "FK_MMFormulaID")
                {
                    int id = 0;
                    int.TryParse(e.Value.ToString(), out id);
                    if (id > 0)
                        e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMFormulas", "MMFormulaID", id, "MMFormulaNo");
                    else
                        e.DisplayText = string.Empty;
                }
                if (e.Column.FieldName == "FK_MMOperationID")
                {
                    int id = 0;
                    int.TryParse(e.Value.ToString(), out id);
                    if (id > 0)
                        e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMOperations", "MMOperationID", id, "MMOperationName");
                    else
                        e.DisplayText = string.Empty;
                }
                if (e.Column.FieldName == "FK_MMProductionNormID")
                {
                    int id = 0;
                    int.TryParse(e.Value.ToString(), out id);
                    if (id > 0)
                        e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMProductionNorms", "MMProductionNormID", id, "MMProductionNormNo");
                    else
                        e.DisplayText = string.Empty;
                }
            }
        }
        void gridview_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ICProductImageName")
            {
                e.DisplayText = "Chọn hình";
            }
        }

        void gridview_DoubleClick(object sender, System.EventArgs e)
        {
            IsDoubleClick = true;
            GridView gridView = (GridView)this.MainView;
            if (gridView != null)
            {
                ICProductsInfo product = (ICProductsInfo)gridView.GetFocusedRow();
                if (product != null)
                {
                    if (((CarcassBOMModule)Screen.Module).IsViewProperties())
                    {
                        ((CarcassBOMModule)Screen.Module).ShowProductStructureForm(product);
                    }
                    else
                    {
                        ((CarcassBOMModule)Screen.Module).ShowProcess(product, false);
                    }
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridView view = (GridView)MainView;

            GridColumn column = new GridColumn();
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "Chọn hình";
            RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
            rpItemComponent.NullText = "Chọn hình";
            rpItemComponent.Click += new System.EventHandler(rpItemComponent_Click);
            column.ColumnEdit = rpItemComponent;
            view.Columns.Add(column);

            column = new GridColumn();
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "Mã sản phẩm";
            column.FieldName = "ICProductID";
            view.Columns.Add(column);

            column = new GridColumn();
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "STT";
            column.FieldName = "ICProductOrderID";
            column.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            view.Columns.Add(column);

            column = new GridColumn();
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "Link hình ảnh và PDF";
            column.FieldName = "ICProductImageFile";
            view.Columns.Add(column);

            column = new GridColumn();
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "Xem hình ảnh và PDF";
            column.FieldName = "ICProductViewImage";
            RepositoryItemHyperLinkEdit rpLinkItemComponent = new RepositoryItemHyperLinkEdit();
            rpLinkItemComponent.NullText = "Xem hình ảnh và PDF";
            rpLinkItemComponent.Click += new System.EventHandler(rpLinkItemComponent_Click);
            column.ColumnEdit = rpLinkItemComponent;
            view.Columns.Add(column);

            column = new GridColumn();
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "Lưu hình ảnh và PDF";
            column.FieldName = "ICProductSaveImage";
            RepositoryItemHyperLinkEdit rpSaveLinkItemComponent = new RepositoryItemHyperLinkEdit();
            rpSaveLinkItemComponent.NullText = "Lưu hình ảnh và PDF";
            rpSaveLinkItemComponent.Click += new System.EventHandler(rpSaveLinkItemComponent_Click);
            column.ColumnEdit = rpSaveLinkItemComponent;
            view.Columns.Add(column);

            column = new GridColumn();
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "Độ phức tạp sản xuất";
            column.FieldName = "ICConfigProductionComplexityType";
            RepositoryItemLookUpEdit rpConfigProductionComplexityType = new RepositoryItemLookUpEdit();
            rpConfigProductionComplexityType.DisplayMember = "ADConfigText";
            rpConfigProductionComplexityType.ValueMember = "ADConfigKeyValue";
            rpConfigProductionComplexityType.NullText = string.Empty;
            rpConfigProductionComplexityType.Columns.Add(new LookUpColumnInfo("ADConfigText", "Độ phức tạp"));
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ConfigProductionComplexityType.ToString());
            List<ADConfigValuesInfo> listConfigValues = new List<ADConfigValuesInfo>();
            if (ds != null && ds.Tables.Count > 0)
            {
                listConfigValues = (List<ADConfigValuesInfo>)objConfigValuesController.GetListFromDataSet(ds);
            }
            rpConfigProductionComplexityType.DataSource = listConfigValues;
            column.ColumnEdit = rpConfigProductionComplexityType;
            view.Columns.Add(column);

            column = new GridColumn();
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "Màu sơn khác";
            column.FieldName = "ICProductColorAttribute";
            
            RepositoryItemCheckedComboBoxEdit rpOhterColor = new RepositoryItemCheckedComboBoxEdit();
            rpOhterColor.DisplayMember = "ICProductAttributeValue";
            rpOhterColor.ValueMember = "ICProductAttributeID";
            rpOhterColor.NullText = string.Empty;
            rpOhterColor.DataSource = GetProductAttributeDatasource(ProductAttributeGroup.COLOR.ToString());
            column.ColumnEdit = rpOhterColor;
            view.Columns.Add(column);

            column = new GridColumn();
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "Màu sơn A";
            column.FieldName = "ICProductColorPaintA";

            RepositoryItemCheckedComboBoxEdit rpColorA = new RepositoryItemCheckedComboBoxEdit();
            rpColorA.DisplayMember = "MMPaintProcessesPaintName";
            rpColorA.ValueMember = "MMPaintProcessesID";
            rpColorA.NullText = string.Empty;
            rpColorA.DataSource = GetPaintProcessessDatasource(ProductAttributeGroup.COLOR.ToString());
            column.ColumnEdit = rpColorA;
            view.Columns.Add(column);

            column = new GridColumn();
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "Màu sơn B";
            column.FieldName = "ICProductColorPaintB";

            RepositoryItemCheckedComboBoxEdit rpColorB = new RepositoryItemCheckedComboBoxEdit();
            rpColorB.DisplayMember = "MMPaintProcessesPaintName";
            rpColorB.ValueMember = "MMPaintProcessesID";
            rpColorB.NullText = string.Empty;
            rpColorB.DataSource = GetPaintProcessessDatasource(ProductAttributeGroup.COLOR.ToString());
            column.ColumnEdit = rpColorB;
            view.Columns.Add(column);

            column = new GridColumn();
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "Màu sơn C";
            column.FieldName = "ICProductColorPaintC";

            RepositoryItemCheckedComboBoxEdit rpColorC = new RepositoryItemCheckedComboBoxEdit();
            rpColorC.DisplayMember = "MMPaintProcessesPaintName";
            rpColorC.ValueMember = "MMPaintProcessesID";
            rpColorC.NullText = string.Empty;
            rpColorC.DataSource = GetPaintProcessessDatasource(ProductAttributeGroup.COLOR.ToString());
            column.ColumnEdit = rpColorC;
            view.Columns.Add(column);

            column = new GridColumn();
            column.OptionsColumn.AllowEdit = true;
            column.Caption = "QT Sơn";
            column.FieldName = "ICProductPaintProcess";

            RepositoryItemCheckedComboBoxEdit rpPaintProcess = new RepositoryItemCheckedComboBoxEdit();
            rpPaintProcess.DisplayMember = "MMPaintProcessesPaintName";
            rpPaintProcess.ValueMember = "MMPaintProcessesID";
            rpPaintProcess.NullText = string.Empty;
            rpPaintProcess.DataSource = GetPaintProcessessDatasource(ProductAttributeGroup.HTType.ToString());
            column.ColumnEdit = rpPaintProcess;
            view.Columns.Add(column);
        }

        private string GetColorDisplayText(string colorRef)
        {
            if (string.IsNullOrWhiteSpace(colorRef))
                return string.Empty;

            List<int> colorID = colorRef.Split(',').Select(o => Int32.Parse(o)).ToList();
            DataSet ds = BOSApp.GetLookupTableData("ICProductAttributes");
            if (ds != null && ds.Tables.Count > 0)
            {
                List<ICProductAttributesInfo> ColorData = (List<ICProductAttributesInfo>)(new ICProductAttributesController()).GetListFromDataSet(ds);
                return string.Join(", ", ColorData.Where(o => colorID.Contains(o.ICProductAttributeID)).Select(o => o.ICProductAttributeValue).ToArray());
            }
            else return string.Empty;
        }
        private string GetPaintProcessDisplayText(string colorRef)
        {
            if (string.IsNullOrWhiteSpace(colorRef))
                return string.Empty;

            List<int> colorID = colorRef.Split(',').Select(o => Int32.Parse(o)).ToList();
            DataSet ds = BOSApp.GetLookupTableData("MMPaintProcessess");
            if (ds != null && ds.Tables.Count > 0)
            {
                List<MMPaintProcessessInfo> ColorData = (List<MMPaintProcessessInfo>)(new MMPaintProcessessController()).GetListFromDataSet(ds);
                return string.Join(", ", ColorData.Where(o => colorID.Contains(o.MMPaintProcessesID)).Select(o => o.MMPaintProcessesPaintName).ToArray());
            }
            else return string.Empty;
        }

        public List<ICProductAttributesInfo> GetProductAttributeDatasource(string group)
        {
            List<ICProductAttributesInfo> woodTypeList = new List<ICProductAttributesInfo>();
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            woodTypeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(group);
            return woodTypeList;
        }
        public List<MMPaintProcessessInfo> GetPaintProcessessDatasource(string type)
        {
            List<MMPaintProcessessInfo> paintList = new List<MMPaintProcessessInfo>();
            MMPaintProcessessController objMMPaintProcessessController = new MMPaintProcessessController();
            paintList = objMMPaintProcessessController.GetPaintProcessesByType(type);
            return paintList;
        }
        void rpLinkItemComponent_Click(object sender, System.EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICProductsInfo objProductsInfo = (ICProductsInfo)gridView.GetFocusedRow();
            if (objProductsInfo != null && !string.IsNullOrEmpty(objProductsInfo.ICProductImageFile))
            {
                ((CarcassBOMModule)Screen.Module).ReadPDFByProductLink(objProductsInfo.ICProductImageFile);
            }
        }

        void rpSaveLinkItemComponent_Click(object sender, System.EventArgs e)
        {
            GridView mainView = (GridView)this.MainView;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)mainView.GetFocusedRow();
            if (objProductsInfo != null && !string.IsNullOrEmpty(objProductsInfo.ICProductImageFile))
            {
                ICProductsInfo product = objProductsController.GetObjectByID(objProductsInfo.ICProductID) as ICProductsInfo;
                if (product != null)
                {
                    product.ICProductImageFile = objProductsInfo.ICProductImageFile;
                    objProductsController.UpdateObject(product);
                    BOSApp.ShowMessage("Lưu thành công!");
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                ((CarcassBOMModule)Screen.Module).DeleteSemiProducts();
            }

        }
    }
}