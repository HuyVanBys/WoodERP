using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using BOSLib.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System;


namespace BOSERP.Modules.CarcassBOM
{
    public partial class ProductionNormItemsPackagingTreeListControl : BOSTreeListControl
    {

        #region  properties
        MMAllocationOperationConfigsInfo DefualtAOConfigs { get; set; }
        public List<ICProductsInfo> PackagingList { get; set; }

        public bool HasInitNewRow { get; set; }
        // The variables that will store summary values. 
        #endregion

        protected override void InitTreeListDataSource()
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList dataSource = new BOSTreeList();
            dataSource = entity.ProductionNormItemPackagingList;
            DataSource = dataSource;
        }
        public override void InitializeControl()
        {
            base.InitializeControl();
            this.ExpandAll();
            this.OptionsView.AutoWidth = false;
            this.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto;
            this.BOSDisplayRoot = false;
            this.BOSDisplayOption = true;
            this.NewItemRowText = "Nhấn vào đây để thêm PLĐG mới";
            this.ForceInitialize();
            this.BestFitColumns();
            this.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(ProductionNormItemsTreeListControl_CellValueChanged);
            this.CustomDrawNodeCell += new CustomDrawNodeCellEventHandler(ProductionNormItemsPackagingTreeListControl_CustomDrawNodeCell);
            this.InitNewRow += ProductionNormItemsPackagingTreeListControl_InitNewRow;
            this.CustomColumnDisplayText += ProductionNormItemsPaintTreeListControl_CustomColumnDisplayText;
            this.KeyUp += ProductionNormItemsTreeListControl_KeyUp;
            DefualtAOConfigs = (new MMAllocationOperationConfigsController().GetDefualtAllocationOperationConfigs());
            PackagingList = GetPackagingList();
        }

        private void ProductionNormItemsPackagingTreeListControl_InitNewRow(object sender, TreeListInitNewRowEventArgs e)
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            int maxID = 0;
            var item = new MMProductionNormItemsInfo();
            var node = this.GetSelectedNode();
            item = (MMProductionNormItemsInfo)GetDataRecordByNode(node);
            if (item == null)
                item = new MMProductionNormItemsInfo();
            if (entity.ProductionNormItemPackagingList?.Any() ?? false)
            {
                var itemList = entity.ProductionNormItemPackagingList.ToList().Select(o => (MMProductionNormItemsInfo)o).ToList();
                maxID = itemList.Select(o => o.MMProductionNormItemSortOrder).DefaultIfEmpty().Max() + 1;
            }
            item.MMProductionNormItemSortOrder = maxID;
            item.MMProductionNormItemSortOrderString = maxID.ToString();
            item.MMProductionNormItemGroup = ProductType.IngredientPackaging.ToString();
            var props = item.GetObjectProperties();
            foreach (var prop in props)
            {
                e.SetValue(prop.Name, prop.GetValue(item));
            }
            HasInitNewRow = true;
        }

        private void ProductionNormItemsTreeListControl_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Delete)
            {
                CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                MMProductionNormsInfo mainObject = (MMProductionNormsInfo)entity.MainObject;
                if (mainObject.MMProductionNormPackingMaterialStatus != Status.Approved.ToString())
                {
                    TreeListNode node = this.FocusedNode;
                    MMProductionNormItemsInfo item = (MMProductionNormItemsInfo)GetDataRecordByNode(node);
                    entity.ProductionNormItemPackagingList.Remove(item);
                    entity.ProductionNormItemPackagingList.RemoveSelectedRowObjectFromList();
                    entity.ProductionNormItemPackagingList.TreeListControl?.Refresh();
                }
            }
        }

        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            this.BeginInit();
            Columns.Clear();
            #region InitTreeListColumns
            AddTreeListColumns(0, "MMProductionNormItemSortOrderString", false, true);//STT
            AddTreeListColumns(1, ProductionNormConst.MMProductionNormItemNo, true, false);//Ma vat tu
            AddTreeListColumns(2, ProductionNormConst.MMProductionNormItemICProductName, false, true);//Ten VT
            AddTreeListColumns(3, "MMProductionNormItemProductDesc", false, true);//Mo ta
            AddTreeListColumns(3, "FK_MMSemiProductID", false, true);
            AddTreeListColumns(4, "MMProductionNormItemProductInsideDimensionLength", false, true);//KT lọt lòng dài
            AddTreeListColumns(5, "MMProductionNormItemProductInsideDimensionWidth", false, true);//KT lọt lòng rộng
            AddTreeListColumns(6, "MMProductionNormItemProductInsideDimensionHeight", false, true);//KT lọt lòng cao
            AddTreeListColumns(7, "MMProductionNormItemProductOverallDimensionLength", false, true); //Phu bi dài
            AddTreeListColumns(8, "MMProductionNormItemProductOverallDimensionWidth", false, true); //Phu bi rộng
            AddTreeListColumns(9, "MMProductionNormItemProductOverallDimensionHeight", false, true); //Phu bi cao
            AddTreeListColumns(10, "FK_ICProdAttPackingMaterialSpecialityID", false, true);//Đặc tính
            AddTreeListColumns(11, "FK_ICProdAttPackingMaterialSizeID", false, true);//Khổ màng
            AddTreeListColumns(12, "FK_ICProdAttPackingMaterialWeightPerVolumeID", false, true);//Định lượng
            AddTreeListColumns(13, "MMHardwareOperationType", false, true);//Công thức tính số lượng
            AddTreeListColumns(14, ProductionNormConst.MMProductionNormItemTotalQuantity, false, true);//SL
            AddTreeListColumns(15, ProductionNormConst.MMProductionNormItemQuantity, false, true);//SL tiêu hao
            AddTreeListColumns(16, ProductionNormConst.MMProductionNormItemDepreciationRate, false, true);//Tỉ lệ tiêu hao
            AddTreeListColumns(17, "FK_MMOperationID", false, true);//SL
            //AddTreeListColumns(15, ProductionNormConst.MMProductionNormItemTotalQuantity, false, true);//Qty Inbox
            AddTreeListColumns(18, "MMProductionNormItemComment", false, true);//Ghi chu
            AddTreeListColumns(19, "MMProductionNormItemProductSizeAndPacking", false, true);//Kích thước/Quy cách
            AddTreeListColumns(20, ProductionNormConst.FK_ICMeasureUnitID, false, true);//DVT
            AddTreeListColumns(21, ProductionNormConst.MMProductionNormItemPackagingNW, false, true);//NW
            AddTreeListColumns(22, ProductionNormConst.MMProductionNormItemPackagingGW, false, true);//GW
            AddTreeListColumns(23, "MMProductionNormItemResourceType", false, true);
            AddTreeListColumns(24, "MMProductionNormItemQtyPerOne", false, true);
            #endregion
            this.OptionsView.ShowSummaryFooter = true;
            this.EndInit();
        }

        void ProductionNormItemsTreeListControl_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            string columnName = ((DevExpress.XtraTreeList.CellEventArgs)(e)).Column.FieldName;
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            TreeListNode node = e.Node;
            MMProductionNormItemsInfo item = (MMProductionNormItemsInfo)entity.ProductionNormItemPackagingList.CurrentObject;
            if (node == null || (node?.ImageIndex == -1))
                return;

            if (node.Id < 0 && item == null && entity.ProductionNormItemPackagingList?.Count == 0)
            {
                var newItem = new MMProductionNormItemsInfo();
                var prop = newItem.GetType().GetProperty(columnName);
                TreeListColumn column = Columns[prop.Name];
                if (column != null && prop != null)
                    prop.SetValue(newItem, e.Value);
                newItem.MMProductionNormItemID = 0;
                newItem.MMProductionNormItemParentID = 0;
                newItem.MMProductionNormItemSortOrder = 1;
                newItem.MMProductionNormItemSortOrderString = "1";
                newItem.MMProductionNormItemGroup = ProductType.IngredientPackaging.ToString();
                entity.ProductionNormItemPackagingList.Add(newItem);
                entity.ProductionNormItemPackagingList.TreeListControl?.RefreshDataSource();
                item = newItem;
            }
            if (columnName == "FK_ICProdAttPackingMaterialWeightPerVolumeID")
            {
                string fieldName = e.Column.FieldName;
                if (fieldName == "FK_ICProdAttPackingMaterialWeightPerVolumeID")
                {
                    ((CarcassBOMModule)Screen.Module).SetMarketDimensionForMaterial(item);
                }

            }
            else if (columnName == "MMProductionNormItemQuantity" || columnName == "MMProductionNormItemTotalQuantity")
            {

                decimal qty = 0;
                decimal.TryParse(e.Value?.ToString() ?? "0", out qty);
                node.SetValue(e.Column, qty);
                node.ExpandAll();
                if (node.Nodes?.Any() ?? false)
                {
                    SetQtyValueToList(e.Node, e.Column, qty);
                }
            }
            else if (columnName == "FK_MMOperationID")
            {
                node.SetValue(e.Column, e.Value);
                if (node.Nodes?.Any() ?? false)
                {
                    SetValueToList(e.Node, e.Column, e.Value);
                }
            }
            else if (columnName == "MMProductionNormItemProductInsideDimensionHeight"
                || columnName == "MMProductionNormItemProductInsideDimensionWidth"
                || columnName == "MMProductionNormItemProductInsideDimensionLength"
                || columnName == "FK_ICProdAttPackingMaterialSpecialityID")
            {
                ((CarcassBOMModule)Screen.Module).CalculateProductionNormItemPackaging(columnName, item);
            }
            if (columnName == "FK_ICProdAttPackingMaterialSizeID"
                || columnName == "FK_ICProdAttPackingMaterialWeightPerVolumeID")
            {
                ((CarcassBOMModule)Screen.Module).SetProductForMaterial(columnName, item);
            }
            else if (columnName == "MMProductionNormItemDepreciationRate" || columnName == "MMProductionNormItemTotalQuantity")
            {
                item.MMProductionNormItemQuantity = item.MMProductionNormItemTotalQuantity * item.MMProductionNormItemDepreciationRate;
            }
            else if (columnName == "MMProductionNormItemQuantity")
            {
                item.MMProductionNormItemTotalQuantity = item.MMProductionNormItemQuantity / (item.MMProductionNormItemDepreciationRate == 0 ? 1 : item.MMProductionNormItemDepreciationRate);
            }
            else if (columnName == "MMHardwareOperationType")
            {
                if (item != null)
                {
                    try
                    {
                        string mathString = item.MMHardwareOperationType.Trim().Replace(" ", string.Empty).Replace("=", string.Empty);
                        DataTable dt = new DataTable();
                        item.MMProductionNormItemTotalQuantity = Convert.ToDecimal(dt.Compute(mathString, String.Empty));
                        item.MMProductionNormItemQuantity = item.MMProductionNormItemTotalQuantity * item.MMProductionNormItemDepreciationRate;
                        //item.MMProductionNormItemQuantity = Convert.ToDecimal(dt.Compute(mathString, String.Empty));
                        //item.MMProductionNormItemTotalQuantity = item.MMProductionNormItemQuantity / (item.MMProductionNormItemDepreciationRate == 0 ? 1 : item.MMProductionNormItemDepreciationRate);
                    }
                    catch
                    {
                        MessageBox.Show("Công thức tính số lượng không đúng định dạng." + Environment.NewLine + "Vui lòng kiểm tra lại!"
                                        , CommonLocalizedResources.MessageBoxDefaultCaption
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Error);
                    }
                }
            }
            ((CarcassBOMModule)Screen.Module).SetOperationForMaterial(item);
            entity.ProductionNormItemPackagingList.TreeListControl?.RefreshDataSource();
            this.RefreshDataSource();
        }

        public void SetValueToList(TreeListNode treeListNode, TreeListColumn treeListColumn, object value)
        {
            TreeListColumn column;
            foreach (TreeListNode child in treeListNode.Nodes)
            {
                child.SetValue(treeListColumn, value);
                if (child.HasChildren)
                {
                    SetValueToList(child, treeListColumn, value);
                }
            }
        }

        public void SetQtyValueToList(TreeListNode treeListNode, TreeListColumn treeListColumn, object value)
        {
            TreeListColumn column;
            MMProductionNormItemsInfo item;
            decimal qtyPerOne = 0;
            decimal qty = 0;
            decimal TotalQuantity = 0;
            decimal updatevaluve = 0;
            decimal updateTotalvalue = 0;
            foreach (TreeListNode child in treeListNode.Nodes)
            {
                item = (MMProductionNormItemsInfo)GetDataRecordByNode(child);
                qtyPerOne = item.MMProductionNormItemQtyPerOne;
                if (treeListColumn.FieldName ==  "MMProductionNormItemTotalQuantity")
                {
                    updateTotalvalue = (decimal)value;
                    qty = ((decimal)updateTotalvalue) * qtyPerOne;
                    if (qty == 0)
                        qty = ((decimal)updateTotalvalue);
                    updatevaluve = qty * item.MMProductionNormItemDepreciationRate;
                    column = Columns["MMProductionNormItemQuantity"];
                    if(column != null)
                    child.SetValue(column, updatevaluve);
                    child.SetValue(treeListColumn, qty);
                }
                else if (treeListColumn.FieldName == "MMProductionNormItemQuantity")
                {
                    updatevaluve = (decimal)value;
                    qty = ((decimal)updatevaluve) * qtyPerOne;
                    if (qty == 0)
                        qty = ((decimal)updatevaluve);
                    column = Columns["MMProductionNormItemTotalQuantity"];
                    updateTotalvalue = qty / (item.MMProductionNormItemDepreciationRate == 0 ? 1 : item.MMProductionNormItemDepreciationRate);
                    child.SetValue(treeListColumn, qty);
                    child.SetValue(column, updateTotalvalue);
                }
                
                if (child.HasChildren)
                {
                    SetQtyValueToList(child, treeListColumn, value);
                }
            }
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

            List<AAColumnAliasInfo> listAlias = BOSApp.LstColumnAlias.Where(a => a.AATableName == TableName.MMProductionNormItemsTableName).ToList();
            if (listAlias != null)
            {
                foreach (AAColumnAliasInfo objAAColumnAliasInfo in listAlias)
                {
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
                        if (fieldName == "MMProductionNormItemProductOverallDimensionHeight")
                            column.Caption = "KT Phủ bì cao"; //Phu bi
                        if (fieldName == "MMProductionNormItemProductOverallDimensionWidth")
                            column.Caption = "KT Phủ bì rộng"; //Phu bi
                        if (fieldName == "MMProductionNormItemProductOverallDimensionLength")
                            column.Caption = "KT Phủ bì dài"; //Phu bi
                        if (fieldName == "MMProductionNormItemProductInsideDimensionHeight")
                            column.Caption = "KT Lọt lòng cao";//KT lọt lòng
                        if (fieldName == "MMProductionNormItemProductInsideDimensionWidth")
                            column.Caption = "KT Lọt lòng rộng";//KT lọt lòng
                        if (fieldName == "MMProductionNormItemProductInsideDimensionLength")
                            column.Caption = "KT Lọt lòng dài";//KT lọt lòng
                        if (fieldName == ProductionNormConst.MMProductionNormItemTotalQuantity)
                            column.Caption = "Số lượng";//KT lọt lòng
                        if (fieldName == ProductionNormConst.MMProductionNormItemQuantity)
                            column.Caption = "Số lượng bao gồm tiêu hao";//KT lọt lòng
                        if (fieldName == ProductionNormConst.MMProductionNormItemDepreciationRate)
                            column.Caption = "Tỉ lệ tiêu hao";//KT lọt lòng
                        if (fieldName == "FK_ICProdAttPackingMaterialWeightPerVolumeID")
                            column.Caption = "Định lượng";
                        if (fieldName == "FK_ICProdAttPackingMaterialSizeID")
                            column.Caption = "Khổ màng foam";
                        if (fieldName == "FK_ICProdAttPackingMaterialSpecialityID")
                            column.Caption = "Đặc tính";
                        if (fieldName == "MMProductionNormItemProductName")
                            column.Caption = "Tên PLDG";
                        if (fieldName == "MMProductionNormItemNo")
                            column.Caption = "Mã PLDG";
                    }
                }
            }
            if (fieldName == "FK_MMSemiProductID")
            {
                List<MMProductionNormItemsInfo> semiProductDatasource = ((CarcassBOMModule)Screen.Module).GetSemiProductDataSource();
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "MMProductionNormItemNo";
                repositoryItemLookUpEdit.ValueMember = "MMProductionNormItemID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductCode", "Mã code", 150));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionNormItemNo", "Mã chi tiết", 150));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionNormItemProductName", "Tên chi tiết", 300));
                repositoryItemLookUpEdit.DataSource = semiProductDatasource;
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(semiProductItemLookUpEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.Caption = "Thuộc chi tiết";
                column.MinWidth = 150;
            }
            if (fieldName == "FK_MMOperationID")
            {

                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "MMOperationName";
                repositoryItemLookUpEdit.ValueMember = "MMOperationID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationNo", "Mã CĐ", 50));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationName", "Tên CĐ", 150));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(reqOperation_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 100;
            }
            if (fieldName == "FK_ICProdAttPackingMaterialWeightPerVolumeID")
            {
                column.OptionsColumn.AllowEdit = AllowEdit;
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
            if (fieldName == "MMHardwareOperationType")
            {
                column.OptionsColumn.AllowEdit = AllowEdit;
                column.ColumnEdit = BOSUtil.GetRepositoryItemFromText(BOSComponent.RepositoryItem.RepositoryItemTextEdit.ToString());
            }
            if (fieldName == "FK_ICProdAttPackingMaterialSizeID")
            {
                column.OptionsColumn.AllowEdit = AllowEdit;
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
                column.OptionsColumn.AllowEdit = AllowEdit;
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
            if (fieldName == "MMProductionNormItemSortOrderString")
            {
                column.Caption = ProductionNormConst.MMProductionNormOrderNoCaption;
                column.Width = 100;
                column.BestFit();
            }
            if (fieldName == ProductionNormConst.FK_ICMeasureUnitID)
            {
                column.OptionsColumn.AllowEdit = AllowEdit;
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
            if (fieldName == ProductionNormConst.MMProductionNormItemTotalQuantity || fieldName == "MMProductionNormItemProductLength"
               || fieldName == "MMProductionNormItemProductHeight" || fieldName == "MMProductionNormItemProductWidth"
               || fieldName == ProductionNormConst.MMProductionNormItemDepreciationRate
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
            if (fieldName == ProductionNormConst.MMProductionNormItemQuantity || fieldName == ProductionNormConst.MMProductionNormItemTotalQuantity)
            {
                STFieldFormatGroupsInfo objFieldFormatGroupsInfo = BOSApp.FieldFormatList.Where(f => f.TableName == this.BOSDataSource && f.ColumnName == ProductionNormConst.MMProductionNormItemQuantity ).FirstOrDefault();
                DevExpress.XtraEditors.Repository.RepositoryItem rep = column.ColumnEdit;
                
                if (rep == null && objFieldFormatGroupsInfo != null)
                {
                    rep = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
                    string strDefaultFontName = "Tahoma";
                    float fDefaultFontSize = 8.25F;
                    if (!string.IsNullOrEmpty(objFieldFormatGroupsInfo.STFieldFormatGroupFontName))
                        strDefaultFontName = objFieldFormatGroupsInfo.STFieldFormatGroupFontName;
                    if (objFieldFormatGroupsInfo.STFieldFormatGroupFontSize > 0)
                        fDefaultFontSize = objFieldFormatGroupsInfo.STFieldFormatGroupFontSize;
                    rep.Appearance.Font = new Font(strDefaultFontName, fDefaultFontSize);
                    rep.Appearance.Options.UseFont = true;
                }
                DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repText = (DevExpress.XtraEditors.Repository.RepositoryItemTextEdit)rep;
                if (objFieldFormatGroupsInfo != null && repText != null)
                {
                    repText.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    repText.Mask.EditMask = objFieldFormatGroupsInfo.STFieldFormatGroupMaskEdit;
                    repText.Mask.UseMaskAsDisplayFormat = true;
                    column.ColumnEdit = repText;
                }
            }
            this.EndUpdate();
            this.Update();
        }

        public void reqOperation_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (BOSApp.LookupTables.Contains(TableName.MMOperationsTableName))
            {
                DataSet ds = (DataSet)BOSApp.LookupTables[TableName.MMOperationsTableName];
                if (ds != null && ds.Tables.Count > 0)
                {
                    lookUpEdit.Properties.DataSource = ds.Tables[0];
                }
            }
        }

        void semiProductItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            lookUpEdit.Properties.DataSource = ((CarcassBOMModule)Screen.Module).GetSemiProductDataSource();
        }

        private List<ICProductsInfo> GetPackagingList()
        {
            ICProductsController productController = new ICProductsController();
            List<ICProductsInfo> dataList = new List<ICProductsInfo>();
            dataList.Insert(0, new ICProductsInfo());
            List<ICProductsForViewInfo> productViewList = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.IngredientPackaging.ToString()).ToList();
            if (productViewList.Count() > 0) productViewList.ForEach(o =>
            {
                ICProductsInfo newObj = new ICProductsInfo();
                BOSUtil.CopyViewObject(o, newObj);
                dataList.Add(newObj);
            });
            return dataList;
        }

        private void ProductionNormItemsPackagingTreeListControl_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            var item = (MMProductionNormItemsInfo)GetDataRecordByNode(e.Node);
            var itemList = new List<MMProductionNormItemsInfo>();
            entity.ProductionNormItemPackagingList.ConvertToList(itemList);
            if (item != null)
            {
                ICProductsInfo packaging = PackagingList.FirstOrDefault(t => t.ICProductID == item.FK_ICProductID && item.FK_ICProductID > 0);
                if (packaging == null)
                {
                    e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Regular);
                    e.Appearance.BackColor = Color.SandyBrown;
                }
                else
                {
                    decimal diffFactor = item.MMProductionNormItemDiffFactor; // dung sai

                    bool isMatchProduct = true;

                    if (packaging.FK_ICProdAttPackingMaterialWeightPerVolumeID != item.FK_ICProdAttPackingMaterialWeightPerVolumeID
                        || packaging.FK_ICProdAttPackingMaterialSizeID != item.FK_ICProdAttPackingMaterialSizeID)
                    {
                        isMatchProduct = false;
                    }

                    if ((packaging.ICProductInsideDimensionLength + diffFactor < item.MMProductionNormItemProductInsideDimensionLength
                        || packaging.ICProductInsideDimensionLength - diffFactor > item.MMProductionNormItemProductInsideDimensionLength)
                        && (packaging.ICProductInsideDimensionWidth + diffFactor < item.MMProductionNormItemProductInsideDimensionWidth
                        || packaging.ICProductInsideDimensionWidth - diffFactor > item.MMProductionNormItemProductInsideDimensionWidth))
                    {
                        isMatchProduct = false;
                    }
                    if (!isMatchProduct)
                    {
                        // e.Appearance.BackColor = Color.Green;
                        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Regular);
                        e.Appearance.BackColor = Color.LightYellow;
                    }
                    if (item.AbstractParentID == 0 && itemList.Any(o => o.FK_MMProductionNormItemRefID == item.MMProductionNormItemID))
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold);
                    }
                }
            }
        }

        private void ProductionNormItemsPaintTreeListControl_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            CarcassBOMEntities entity = (CarcassBOMEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (e.Column.FieldName == "FK_MMSemiProductID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = ((CarcassBOMModule)Screen.Module).GetSemiProductDisplayDisplayText(int.Parse(e.Value.ToString()));
                }
                else
                    e.DisplayText = string.Empty;
            }
            if (e.Column.FieldName == "FK_MMOperationID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMOperations", "MMOperationID", int.Parse(e.Value.ToString()), "MMOperationName");
                }
            }
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICMeasureUnits", "ICMeasureUnitID", int.Parse(e.Value.ToString()), "ICMeasureUnitName");
                }
            }
            if (e.Column.FieldName == "FK_ICProdAttPackingMaterialSpecialityID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes", "ICProductAttributeID", int.Parse(e.Value.ToString()), "ICProductAttributeValue");
                }
            }
            if (e.Column.FieldName == "FK_ICProdAttPackingMaterialSizeID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes", "ICProductAttributeID", int.Parse(e.Value.ToString()), "ICProductAttributeValue");
                }
            }
            if (e.Column.FieldName == "FK_ICProdAttPackingMaterialWeightPerVolumeID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes", "ICProductAttributeID", int.Parse(e.Value.ToString()), "ICProductAttributeValue");
                }
            }
        }
    }
}
