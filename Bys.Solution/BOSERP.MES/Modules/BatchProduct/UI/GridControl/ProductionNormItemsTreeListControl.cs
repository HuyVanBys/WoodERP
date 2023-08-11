using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct
{
    public partial class ProductionNormItemsTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties
        #endregion

        protected override void InitTreeListDataSource()
        {
            BatchProductEntities entity = (BatchProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList dataSource = new BOSTreeList();
            MMProductionNormItemsController objProductionNormItemsController = new MMProductionNormItemsController();
            dataSource = entity.BatchProductProductionNormItemList;
            DataSource = dataSource;
        }
        public override void InitializeControl()
        {
            this.BOSDisplayOption = false;
            base.InitializeControl();
            this.ExpandAll();
            this.OptionsView.AutoWidth = false;
            this.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto;
            this.OptionsView.ShowSummaryFooter = true;
            this.BestFitColumns();
            #region Custome Col
            TreeListColumn column = new TreeListColumn();
            column = this.Columns.Add();
            column.Visible = true;
            column.OptionsColumn.FixedWidth = false;
            column.VisibleIndex = this.Columns != null ? this.Columns.Count : 1;
            column.FieldName = "ICReceiptItemProductQty";
            column.Caption = "Số lượng đã SX";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
            rep1.NullText = "Chi tiết";
            rep1.Click += new EventHandler(ViewResult);
            column.ColumnEdit = rep1;

            column = this.Columns["MMBatchProductProductionNormItemProductName"];
            if (column != null) column.Caption = "Tên sản phẩm";

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
            column = this.Columns["MMBatchProductProductionNormItemParentOrderName"];
            if (column != null)
            {
                column.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            }
            //column = new TreeListColumn();
            //column = this.Columns.Add();
            //column.Visible = true;
            //column.OptionsColumn.FixedWidth = false;
            //column.VisibleIndex = this.Columns != null ? this.Columns.Count : 1;
            //column.FieldName = "RemoveOut";
            //column.Caption = "Xoá";
            //column.OptionsColumn.AllowEdit = true;
            //RepositoryItemHyperLinkEdit repDelete = new RepositoryItemHyperLinkEdit();
            //repDelete.NullText = "Xoá";
            //repDelete.Click += new EventHandler(DeleteItem);
            //column.ColumnEdit = repDelete;
            #endregion


            //  this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
            this.ValidateNode += new ValidateNodeEventHandler(TreeList_ValidateNode);
            this.GetCustomSummaryValue += new GetCustomSummaryValueEventHandler(ProductionNormItemsTreeListControl_GetCustomSummaryValue);
            this.CustomDrawNodeCell += new CustomDrawNodeCellEventHandler(ProductionNormItemsTreeListControl_CustomDrawNodeCell);
            this.CellValueChanged += new CellValueChangedEventHandler(ProductionNormItemsTreeListControl_CellValueChanged);
            this.CustomColumnSort += ProductionNormItemsTreeListControl_CustomColumnSort;

        }
        private void ProductionNormItemsTreeListControl_CustomColumnSort(object sender, CustomColumnSortEventArgs e)
        {
            if (e.Column.FieldName != "MMBatchProductProductionNormItemParentOrderName") return;
            try
            {
                e.Result = Compare(e.NodeValue1.ToString(), e.NodeValue2.ToString());
            }
            catch { }
        }
        public int Compare(string x, string y)
        {
            string s1 = x;
            while (s1.Length > 0 && Char.IsDigit(s1.Last())) s1 = s1.TrimEnd(s1.Last());
            s1 = s1 + x.Substring(s1.Length).PadLeft(12, '0');

            string s2 = y;
            while (s2.Length > 0 && Char.IsDigit(s2.Last())) s2 = s2.TrimEnd(s2.Last());
            s2 = s2 + y.Substring(s2.Length).PadLeft(12, '0');

            return string.Compare(s1, s2);
        }
        private void DeleteItem(object sender, EventArgs e)
        {
            BatchProductEntities entity = (BatchProductEntities)((BatchProductModule)Screen.Module).CurrentModuleEntity;
            MMBatchProductProductionNormItemsInfo obj = (MMBatchProductProductionNormItemsInfo)entity.BatchProductProductionNormItemList.CurrentObject;
            if (obj != null)
            {
                bool xkvt = false;
                bool lcp = false;
                //Kiem tra NKBTP
                List<ICReceiptsInfo> nkBTPList = (new ICReceiptsController()).GetSemiProductReceiptByNorm(obj.MMBatchProductProductionNormItemID);
                if (nkBTPList.Count() > 0)
                {
                    MessageBox.Show("Tồn tại chứng từ nhập kho BTP, vui lòng xử lý trước: " + string.Join(",", nkBTPList.Select(r => r.ICReceiptNo).Distinct()));
                    return;
                }

                List<ICShipmentsInfo> xkBTPList = (new ICShipmentsController()).GetSemiProductShipmentByNorm(obj.MMBatchProductProductionNormItemID);
                if (xkBTPList.Count() > 0)
                {
                    MessageBox.Show("Tồn tại chứng từ xuất kho BTP, vui lòng xử lý trước: " + string.Join(",", xkBTPList.Select(r => r.ICShipmentNo).Distinct()));
                    return;
                }

                List<ICShipmentsInfo> xkVatTuList = (new ICShipmentsController()).GetMaterialShipmentByNorm(obj.MMBatchProductProductionNormItemID); ;
                if (xkVatTuList.Count() > 0)
                {
                    if (MessageBox.Show("Tồn tại chứng từ xuất kho vật tư, bạn muốn tiếp tục không: "
                        + string.Join(",", xkVatTuList.Select(r => r.ICShipmentNo).Distinct()), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                    else xkvt = true;
                }

                MMAllocationPlansInfo lcpList = (new MMAllocationPlansController()).GetAllocationPlanByNormID(obj.MMBatchProductProductionNormItemID);
                if (lcpList != null)
                {
                    if (MessageBox.Show("Đã duyệt cấp phát vật tư, bạn muốn tiếp tục không: "
                        + lcpList.MMAllocationPlanNo, "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                    else lcp = true;
                }

                if (lcp && xkVatTuList.Count() == 0)
                {
                    (new MMAllocationPlansController()).DeleteVitualTransactionByPlanItem(obj.MMBatchProductProductionNormItemID);
                }

                (new MMBatchProductProductionNormItemsController()).DeleteItemByID(obj.MMBatchProductProductionNormItemID);
                MessageBox.Show("Xoá xong nhé!");
            }
        }
        private void ProductionNormItemsTreeListControl_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            BOSTreeListControl treeControl = sender as BOSTreeListControl;
            if (treeControl.FocusedNode == null)
                return;

            TreeListNode node = treeControl.FocusedNode;
            if (node == null)
                return;

            BatchProductEntities entity = (BatchProductEntities)((BatchProductModule)Screen.Module).CurrentModuleEntity;
            if (e.Column.FieldName == "MMBatchProductProductionNormItemResourceType")
            {
                string value = e.Value == null ? string.Empty : e.Value.ToString();
                node.SetValue(e.Column.FieldName, e.Value);

                if (value == BatchProductProductionNormItemResourceType.Manafacturing.ToString())
                    return;

                SetChildNodeValue(node, e.Column.FieldName, e.Value);
            }
            else
            {
                ((BatchProductModule)Screen.Module).EditBatchProducProductionNormItemWood();
            }
        }

        public void SetChildNodeValue(TreeListNode treeListNode, string columnName, object value)
        {
            foreach (TreeListNode item in treeListNode.Nodes)
            {
                item.SetValue(columnName, value);
                SetChildNodeValue(item, columnName, value);
            }
        }

        private void ProductionNormItemsTreeListControl_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "MMBatchProductProductionNormItemResourceType")
                {
                    if (e.CellValue != null)
                    {
                        e.CellText = BOSApp.GetDisplayTextFromConfigValue("BatchProductProductionNormItemResourceType", e.CellValue.ToString());
                    }
                }
                else if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    if (e.CellValue != null)
                    {
                        e.CellText = BOSApp.GetDisplayTextFromCatche("ICMeasureUnits", "ICMeasureUnitID", int.Parse(e.CellValue.ToString()), "ICMeasureUnitName");
                    }
                }
                else if (e.Column.FieldName == "FK_ICProductAttributeSpecialityID")
                {
                    if (e.CellValue != null)
                    {
                        e.CellText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes", "ICProductAttributeID", int.Parse(e.CellValue.ToString()), "ICProductAttributeValue");
                    }
                }
                else if (e.Column.FieldName == "FK_ICProductAttributeQualityID")
                {
                    if (e.CellValue != null)
                    {
                        e.CellText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes", "ICProductAttributeID", int.Parse(e.CellValue.ToString()), "ICProductAttributeValue");
                    }
                }
                else if (e.Column.FieldName == "FK_ICProductAttributeWoodTypeID")
                {
                    if (e.CellValue != null)
                    {
                        e.CellText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes", "ICProductAttributeID", int.Parse(e.CellValue.ToString()), "ICProductAttributeValue");
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        void ProductionNormItemsTreeListControl_GetCustomSummaryValue(object sender, GetCustomSummaryValueEventArgs e)
        {
            try
            {
                if (e.IsSummaryFooter)
                {
                    if (e.Column.FieldName == "MMBatchProductProductionNormItemQuantity")
                    {
                        e.CustomValue = ((BatchProductModule)Screen.Module).GetSumProductionNormItemQty();
                    }
                    if (e.Column.FieldName == "MMBatchProductProductionNormItemWoodBlocks")
                    {
                        e.CustomValue = ((BatchProductModule)Screen.Module).GetSumProductionNormItemBlocks();
                    }
                    if (e.Column.FieldName == "MMBatchProductProductionNormItemTotalWoodConsumable")
                    {
                        e.CustomValue = ((BatchProductModule)Screen.Module).GetSumProductionNormItemWoodConsumable();
                    }
                    if (e.Column.FieldName == "MMBatchProductProductionNormItemMDFBlocks")
                    {
                        e.CustomValue = ((BatchProductModule)Screen.Module).GetSumProductionNormItemMDFBlock();
                    }
                    if (e.Column.FieldName == "MMBatchProductProductionNormItemPaintA")
                    {
                        e.CustomValue = ((BatchProductModule)Screen.Module).GetSumProductionNormItemPaintA();
                    }
                    if (e.Column.FieldName == "MMBatchProductProductionNormItemPaintB")
                    {
                        e.CustomValue = ((BatchProductModule)Screen.Module).GetSumProductionNormItemPaintB();
                    }
                    if (e.Column.FieldName == "MMBatchProductProductionNormItemVeneer")
                    {
                        e.CustomValue = ((BatchProductModule)Screen.Module).GetSumProductionNormItemVeneer();
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        //public override void InitTreeListColumns(string strTableName)
        //{
        //    base.InitTreeListColumns(strTableName);
        //    Columns.Clear();
        //    #region InitTreeListColumns
        //    AddTreeListColumns(0, "MMBatchProductProductionNormItemProductName", true, false);
        //    AddTreeListColumns(1, "MMBatchProductProductionNormItemNo", true, false);
        //    AddTreeListColumns(6, "FK_ICProductAttributeSpecialityID", true, true);
        //    AddTreeListColumns(7, "FK_ICProductAttributeQualityID", true, true);
        //    AddTreeListColumns(8, "MMBatchProductProductionNormItemProductSizeAndPacking", true, true);
        //    AddTreeListColumns(8, "MMBatchProductProductionNormItemComment", true, true);
        //    AddTreeListColumns(9, "MMBatchProductProductionNormItemDepreciationRate", false, true);
        //    AddTreeListColumns(10, "MMBatchProductProductionNormItemQuantity", false, true);
        //    AddTreeListColumns(11, "MMBatchProductProductionNormItemProductHeight", true, false);
        //    AddTreeListColumns(12, "MMBatchProductProductionNormItemProductWidth", true, false);
        //    AddTreeListColumns(13, "MMBatchProductProductionNormItemProductLength", true, false);
        //    AddTreeListColumns(11, "MMBatchProductProductionNormItemProductJoinery", true, false);
        //    AddTreeListColumns(12, "FK_ICMeasureUnitID", true, true);
        //    AddTreeListColumns(13, "ICReceiptItemProductQty", false, true);
        //    #endregion
        //    if (Columns["MMBatchProductProductionNormItemSortOrder"] == null)
        //    {
        //        this.BeginUpdate();
        //        TreeListColumn column = Columns.Add();
        //        column.FieldName = "MMBatchProductProductionNormItemSortOrder";
        //        column.Caption = "SortOrder";
        //        column.Visible = false;
        //        //column.SortOrder = SortOrder.Ascending;
        //        this.EndUpdate();
        //        this.Update();
        //    }
        //    this.OptionsView.ShowSummaryFooter = true;
        //    this.OptionsBehavior.ImmediateEditor = true;
        //}
        public void AddTreeListColumns(int visibleIndex, string fieldName, bool readOnly, bool AllowEdit)
        {
            this.BeginUpdate();
            readOnly = true;
            AllowEdit = false;
            TreeListColumn column = Columns.ColumnByFieldName(fieldName);
            if (column == null)
            {
                column = Columns.Add();
            }
            column.Visible = true;
            column.OptionsColumn.AllowEdit = AllowEdit;
            column.OptionsColumn.ReadOnly = readOnly;
            this.OptionsView.AutoWidth = false;

            column.OptionsColumn.FixedWidth = false;
            column.VisibleIndex = visibleIndex;
            column.FieldName = fieldName;
            if (fieldName == "FK_ICProductAttributeWoodTypeID" ||
                fieldName == "MMBatchProductProductionNormItemProductName" ||
                fieldName == "MMBatchProductProductionNormItemNo" ||
                fieldName == "FK_MMProductionNormItemID")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Width = 200;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
            }
            if (fieldName == "MMBatchProductProductionNormICDepartmentAttribute")
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Width = 100;
                column.Visible = false;
            }
            if (fieldName == "MMBatchProductProductionNormItemResourceType" || fieldName == "MMBatchProductProductionNormItemExecuteType"
                || fieldName == "MMBatchProductProductionNormItemComment" || fieldName == "MMBatchProductProductionNormItemProductSizeAndPacking")
            {
                column.OptionsColumn.ReadOnly = false;
                column.OptionsColumn.AllowEdit = true;
                column.MinWidth = 150;
            }

            if (fieldName == "MMBatchProductProductionNormItemPaintA" || fieldName == "MMBatchProductProductionNormItemPaintB"
            || fieldName == "MMBatchProductProductionNormItemVeneer" || fieldName == "MMBatchProductProductionNormItemMDFBlocks "
            )
            {
                column.AllNodesSummary = true;
                column.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom;
                column.RowFooterSummaryStrFormat = ProductionNormConst.ProducttionNormFormatN4;
            }
            if (fieldName == "MMBatchProductProductionNormItemTotalWoodConsumable" || fieldName == "MMBatchProductProductionNormItemQuantity"
                || fieldName == "MMBatchProductProductionNormItemWoodBlocks")
            {
                column.AllNodesSummary = true;
                column.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Custom;
                column.RowFooterSummaryStrFormat = ProductionNormConst.ProducttionNormFormatN4;
                if (fieldName == "MMBatchProductProductionNormItemQuantity")
                {
                    column.RowFooterSummaryStrFormat = ProductionNormConst.ProducttionNormFormatN0;
                    column.OptionsColumn.ReadOnly = false;
                    column.OptionsColumn.AllowEdit = true;
                }
            }

            if (fieldName == "MMProductionNormItemQuantity" || fieldName == "MMBatchProductProductionNormItemProductLength"
               || fieldName == "MMBatchProductProductionNormItemProductHeight" || fieldName == "MMBatchProductProductionNormItemProductWidth"
               || fieldName == "MMBatchProductProductionNormItemTotalQuantity" || fieldName == "MMBatchProductProductionNormItemDepreciationRate"
               || fieldName == "MMBatchProductProductionNormItemActualDepreciationRate" || fieldName == "MMBatchProductProductionNormItemHardwareAssembleQuantity"
               || fieldName == "MMBatchProductProductionNormItemHardwareAllocationQuantity" || fieldName == "MMBatchProductProductionNormItemPackagingGW"
               || fieldName == "MMBatchProductProductionNormItemPackagingNW" || fieldName == "MMBatchProductProductionNormItemPackagingAllocationTotalQuantity"
               || fieldName == "MMBatchProductProductionNormItemProductOverallDimensionHeight" || fieldName == "MMBatchProductProductionNormItemProductOverallDimensionWidth"
               || fieldName == "MMBatchProductProductionNormItemProductOverallDimensionLength" || fieldName == "MMBatchProductProductionNormItemProductInsideDimensionHeight"
               || fieldName == "MMBatchProductProductionNormItemProductInsideDimensionWidth" || fieldName == "MMBatchProductProductionNormItemProductInsideDimensionLength")
            {
                column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.Format.FormatString = "{0:n2}";
            }

            if (fieldName == "MMBatchProductProductionNormItemDepreciationRate" ||
                fieldName == "MMBatchProductProductionNormItemProductLength" ||
                fieldName == "MMBatchProductProductionNormItemProductWidth" ||
                fieldName == "MMBatchProductProductionNormItemProductHeight")
            {
                column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.Format.FormatString = "{0:n2}";
            }
            if (fieldName == "MMProductionNormItemQuantity" || fieldName == "MMBatchProductProductionNormItemTotalQuantity" ||
                fieldName == "MMBatchProductProductionNormItemWoodBlocks" || fieldName == "MMBatchProductProductionNormItemMDFBlocks" ||
                fieldName == "MMBatchProductProductionNormItemBlockPerOne" || fieldName == "MMBatchProductProductionNormItemPaintA"
                || fieldName == "MMBatchProductProductionNormItemQuantity" || fieldName == "MMBatchProductProductionNormItemPlywood"
                || fieldName == "MMBatchProductProductionNormItemPaintB"
                )
            {
                column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.Format.FormatString = "{0:n4}";
            }
            if (fieldName == ProductionNormConst.FK_MMFormulaIDPaintA || fieldName == ProductionNormConst.FK_MMFormulaIDPaintB)
            {
                column.OptionsColumn.AllowEdit = true;
                column.MinWidth = 150;
            }
            if (fieldName == "MMBatchProductProductionNormItemIsReuse")
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemCheckEdit rep = new RepositoryItemCheckEdit();
                column.ColumnEdit = rep;
                column.ColumnEdit.ReadOnly = false;
                this.RepositoryItems.Add(rep);
            }

            if (fieldName == "MMBatchProductProductionNormItemVeneer")
            {
                column.MinWidth = 150;
                column.OptionsColumn.AllowEdit = true;
                column.Caption = ProductionNormLocalizeResources.ProductionNormItemVeneerCaption;
            }

            if (fieldName == "MMProductionNormItemMeterial")
            {
                column.OptionsColumn.AllowEdit = true;
                column.OptionsColumn.ReadOnly = false;
                RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
                rpItemComponent.NullText = "Chi tiết";
                rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
                column.ColumnEdit = rpItemComponent;
                this.RepositoryItems.Add(rpItemComponent);
            }
            if (fieldName == "FK_ICProductAttributeSpecialityID")
            {
                column.OptionsColumn.AllowEdit = true;
                column.OptionsColumn.ReadOnly = false;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repSpeciality_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 150;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (fieldName == "FK_ICProductAttributeQualityID")
            {
                column.OptionsColumn.AllowEdit = true;
                column.OptionsColumn.ReadOnly = false;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEditAttributeQuality = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEditAttributeQuality.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEditAttributeQuality.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEditAttributeQuality.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEditAttributeQuality.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEditAttributeQuality.NullText = string.Empty;
                repositoryItemLookUpEditAttributeQuality.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Chất lượng"));
                repositoryItemLookUpEditAttributeQuality.QueryPopUp += new System.ComponentModel.CancelEventHandler(repQuality_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEditAttributeQuality;
                column.MinWidth = 150;
                this.RepositoryItems.Add(repositoryItemLookUpEditAttributeQuality);

            }
            if (fieldName == "FK_ICProductAttributeWoodTypeID")
            {
                column.OptionsColumn.AllowEdit = true;
                column.OptionsColumn.ReadOnly = false;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEditAttributeQuality = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEditAttributeQuality.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEditAttributeQuality.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEditAttributeQuality.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEditAttributeQuality.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEditAttributeQuality.NullText = string.Empty;
                repositoryItemLookUpEditAttributeQuality.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Loại nguyên liệu"));
                repositoryItemLookUpEditAttributeQuality.QueryPopUp += new System.ComponentModel.CancelEventHandler(repWoodtype_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEditAttributeQuality;
                column.MinWidth = 150;
                this.RepositoryItems.Add(repositoryItemLookUpEditAttributeQuality);

            }
            if (fieldName == "FK_ICMeasureUnitID")
            {
                column.MinWidth = 150;
                column.OptionsColumn.AllowEdit = true;
                column.OptionsColumn.ReadOnly = false;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICMeasureUnitName";
                repositoryItemLookUpEdit.ValueMember = "ICMeasureUnitID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "Tên ĐVT", 300));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repMeasureUnit_QueryPopUp);
                repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                column.ColumnEdit = repositoryItemLookUpEdit;

                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (fieldName == "MMBatchProductProductionNormItemResourceType")
            {
                RepositoryItemBOSLookupEdit repLookupEdit = new RepositoryItemBOSLookupEdit();

                repLookupEdit.DataSource = ADConfigValueUtility.ConfigValues.Tables["BatchProductProductionNormItemResourceType"];
                repLookupEdit.ValueMember = "Value";
                repLookupEdit.DisplayMember = "Text";
                repLookupEdit.ShowHeader = false;
                DevExpress.XtraEditors.Controls.LookUpColumnInfo repColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
                repColumn.FieldName = "Text";
                repColumn.Width = 100;
                repLookupEdit.Columns.Add(repColumn);
                repLookupEdit.PopupWidth = repColumn.Width;
                column.ColumnEdit = repLookupEdit;

            }
            //Get Caption
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            List<AAColumnAliasInfo> dsColumns = BOSApp.LstColumnAlias.Where(a => a.AATableName == TableName.MMBatchProductProductionNormItemsTableName).ToList();
            if (dsColumns.Count() > 0)
            {
                foreach (AAColumnAliasInfo objAAColumnAliasInfo in dsColumns)
                {
                    //AAColumnAliasInfo objAAColumnAliasInfo = (AAColumnAliasInfo)objAAColumnAliasController.GetObjectFromDataRow(rowColumn);
                    {
                        if (fieldName == objAAColumnAliasInfo.AAColumnAliasName)
                            column.Caption = objAAColumnAliasInfo.AAColumnAliasCaption;

                        if (fieldName == "MMBatchProductProductionNormItemComment")
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemDescGraftCaption;
                        //if (fieldName == "FK_ICProductAttributeSpecialityID")
                        //    column.Caption = ProductionNormLocalizeResources.MMProductionNormItemSemiProductDepartmentAttributeCaption;
                        if (fieldName == "MMBatchProductProductionNormItemVeneer")
                            column.Caption = ProductionNormLocalizeResources.ProductionNormItemVeneerCaption;
                        if (fieldName == "MMBatchProductProductionNormItemQuantity")
                            column.Caption = "Số lượng";
                        if (fieldName == "MMBatchProductProductionNormItemModifiedStatus")
                            column.Caption = "Trạng thái thay đổi";
                        if (fieldName == "FK_MMProductionNormItemID")
                            column.Caption = "Mã tham chiếu BDM";
                        if (fieldName == "AACreatedDate")
                            column.Caption = "Ngày tạo";
                        //if (fieldName == "MMProductionNormItemMeterial")
                        //{
                        //    column.Caption = "Nguyên liệu";
                        //}
                    }
                }
            }
            if (column.FieldName == "ICReceiptItemProductQty")
            {
                column.Caption = "Số lượng đã SX";
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
                rep1.NullText = "Chi tiết";
                rep1.Click += new EventHandler(ViewResult);
                column.ColumnEdit = rep1;
            }
            this.EndUpdate();
            this.Update();
        }
        private void ViewResult(object sender, EventArgs e)
        {
            BatchProductEntities entity = (BatchProductEntities)((BatchProductModule)Screen.Module).CurrentModuleEntity;
            MMBatchProductProductionNormItemsInfo obj = (MMBatchProductProductionNormItemsInfo)entity.BatchProductProductionNormItemList.CurrentObject;
            if (obj != null)
            {
                XtraReportHelper.ShowRefFromModule(new BOSList<ADTemplateParamsInfo>(), obj, this.Screen.Module.Controls, this.Screen.Module.Name, this.Screen.Module, "ICReceiptItemProductQty");
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
        public void repSpeciality_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objICProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttribute = objICProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeSpecialityColumnName);
            if (productAttribute != null && productAttribute.Count > 0)
            {
                lookUpEdit.Properties.DataSource = productAttribute;
            }
        }
        public void repQuality_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objICProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttribute = objICProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeQualityColumnName);
            if (productAttribute != null && productAttribute.Count > 0)
            {
                lookUpEdit.Properties.DataSource = productAttribute;
            }
        }
        public void repWoodtype_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objICProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttribute = objICProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeWoodTypeColumnName);
            if (productAttribute != null && productAttribute.Count > 0)
            {
                lookUpEdit.Properties.DataSource = productAttribute;
            }
        }
        private void TreeList_ValidateNode(object sender, ValidateNodeEventArgs e)
        {
            double num;
            TreeListColumn column = Columns["MMBatchProductProductionNormItemQuantity"];
            if (column == null)
            {
                try
                {
                    num = Convert.ToDouble(e.Node[column]);
                }
                catch (Exception)
                {
                    this.SetColumnError(Columns["MMBatchProductProductionNormItemQuantity"], ProductionNormLocalizeResources.InputNotCorrectFornat);
                    e.Valid = false;
                }
            }
            column = Columns["MMBatchProductProductionNormItemPaintA"];
            if (column == null)
            {
                try
                {
                    num = Convert.ToDouble(e.Node[column]);
                }
                catch (Exception)
                {
                    this.SetColumnError(Columns["MMBatchProductProductionNormItemPaintA"], ProductionNormLocalizeResources.InputNotCorrectFornat);
                    e.Valid = false;
                }
            }
        }

        //public void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    DataTable dt = ((BatchProductModule)Screen.Module).GetFormulaTable();
        //    lookUpEdit.Properties.DataSource = dt;
        //}

        //public void repositoryItemLookUpEditSourceType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
        //    DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("BatchProductProductionNormItemResourceType");
        //    if (ds != null && ds.Tables.Count > 0)
        //    {
        //        lookUpEdit.Properties.DataSource = ds.Tables[0];
        //    }
        //}

        //public void repositoryItemLookUpEditWood_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    BatchProductEntities entity = (BatchProductEntities)((BatchProductModule)Screen.Module).CurrentModuleEntity;
        //    MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo = new MMBatchProductProductionNormItemsInfo();
        //    objBatchProductProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)entity.BatchProductProductionNormItemList.CurrentObject;
        //    MMProductionNormItemMeterialsController objProductionNormItemMeterialsController = new MMProductionNormItemMeterialsController();
        //    List<MMProductionNormItemMeterialsInfo> productionNormItemMeterialList = objProductionNormItemMeterialsController.GetAllProductionNormItemMeterialsByProductionNormItemID(objBatchProductProductionNormItemsInfo.FK_MMProductionNormItemID);
        //    if (productionNormItemMeterialList != null && productionNormItemMeterialList.Count > 0)
        //    {
        //        lookUpEdit.Properties.DataSource = productionNormItemMeterialList;
        //    }
        //}

        protected void repositoryItemProductWoodLookupEdit_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lke = sender as LookUpEdit;
            MMProductionNormItemMeterialsInfo objProductionNormItemMeterialsInfo = (MMProductionNormItemMeterialsInfo)lke.GetSelectedDataRow();
            if (objProductionNormItemMeterialsInfo != null)
            {
                BatchProductEntities entity = (BatchProductEntities)((BatchProductModule)Screen.Module).CurrentModuleEntity;
                MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo = new MMBatchProductProductionNormItemsInfo();
                objBatchProductProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)entity.BatchProductProductionNormItemList.CurrentObject;
                objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductLength = objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialLength;
                objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductWidth = objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialWidth;
                objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemProductHeight = objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialHeigth;
                MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
                MMBatchProductItemsInfo objBatchProductItemsInfo = (MMBatchProductItemsInfo)objBatchProductItemsController.GetObjectByID(objBatchProductProductionNormItemsInfo.FK_MMBatchProductItemID);
                objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemWoodBlocks = (objBatchProductItemsInfo.MMBatchProductItemProductQty * objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialWoodBlocks);
                objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemTotalWoodConsumable = objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemWoodBlocks * objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemDepreciationRate;
            }
        }

        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            BatchProductEntities entity = (BatchProductEntities)((BatchProductModule)Screen.Module).CurrentModuleEntity;
            MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)entity.BatchProductProductionNormItemList.CurrentObject;
            /*((BatchProductModule)Screen.Module).ShowProductionNormItemMeterial(objBatchProductProductionNormItemsInfo);*/
        }
    }
}
