using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.BatchProduct
{
    public partial class ProductionNormItemsHardwareTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties
        #endregion

        protected override void InitTreeListDataSource()
        {
            BatchProductEntities entity = (BatchProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DataSource = entity.ProductionNormItemHardwareList;
        }
        public override void InitializeControl()
        {
            this.BOSDisplayOption = false;
            base.InitializeControl();
            this.ExpandAll();
            this.OptionsView.AutoWidth = false;
            this.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto;
            this.BOSDisplayRoot = true;
            this.BestFitColumns();

            //this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
            this.CustomDrawNodeCell += new CustomDrawNodeCellEventHandler(ProductionNormItemsHardwareTreeListControl_CustomDrawNodeCell);
            this.CustomColumnDisplayText += ProductionNormItemsHardwareTreeListControl_CustomColumnDisplayText;
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
        private void ProductionNormItemsHardwareTreeListControl_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
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
        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            //Columns.Clear();
            #region InitTreeListColumns
            //AddTreeListColumns(1, "MMBatchProductProductionNormItemSortOrder", true, false);
            //AddTreeListColumns(2, "MMBatchProductProductionNormItemProductName", true, false);
            //AddTreeListColumns(3, "MMBatchProductProductionNormItemNo", true, false);
            //AddTreeListColumns(4, "FK_MMProductionNormItemID", true, false);
            //AddTreeListColumns(5, "FK_MMBPSemiProductID", true, false);
            //AddTreeListColumns(6, "MMBatchProductProductionNormItemProductDesc", true, false);
            //AddTreeListColumns(7, ProductionNormConst.FK_ICMeasureUnitID, false, false);
            //AddTreeListColumns(8, "FK_MMOperationID", false, true);
            //AddTreeListColumns(9, "MMBatchProductProductionNormItemHardware", false, true);
            //AddTreeListColumns(10, "MMBatchProductProductionNormItemQuantity", false, false);
            //AddTreeListColumns(12, "MMBatchProductProductionNormItemComment", false, false);
            ////AddTreeListColumns(10, "MMBatchProductProductionNormItemModifiedStatus", true, false);
            //AddTreeListColumns(12, "MMBatchProductProductionNormItemNeededTime", false, true);
            ////AddTreeListColumns(12, "AACreatedDate", true, false);

            #endregion
        }
        public void AddTreeListColumns(int visibleIndex, string fieldName, bool readOnly, bool AllowEdit)
        {
            this.BeginUpdate();
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
            if (fieldName == "MMBatchProductProductionNormItemSortOrder")
            {
                column.Caption = ProductionNormConst.MMProductionNormOrderNoCaption;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Width = 70;
                column.BestFit();
            }
            if (fieldName == "MMBatchProductProductionNormItemProductName")
            {
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNameHardware;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Width = 250;
                column.BestFit();
            }

            if (fieldName == "MMBatchProductProductionNormItemNo")
            {
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNoHardware;
                column.Width = 200;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.BestFit();
            }
            if (fieldName == "FK_MMProductionNormItemID")
            {
                column.Caption = "Mã tham chiếu BDM";
                column.Width = 200;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.BestFit();
            }
            if (fieldName == "MMBatchProductProductionNormItemHardwareAssembleQuantity")
            {
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemHardwareAssembleTotalQuantityCaption;
                column.OptionsColumn.AllowEdit = true;
                column.OptionsColumn.ReadOnly = false;
                column.BestFit();
            }
            if (fieldName == ProductionNormConst.FK_ICMeasureUnitID)
            {
                column.OptionsColumn.AllowEdit = true;
                //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEdit.DisplayMember = "ICMeasureUnitName";
                //repositoryItemLookUpEdit.ValueMember = "ICMeasureUnitID";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                // repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemUnitLookUpEdit_QueryPopUp);
                //column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 50;
                //this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (fieldName == "MMBatchProductProductionNormItemHardware")
            {
                RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
                column.Caption = "Chi tiết cấp phát";
                column.OptionsColumn.AllowEdit = true;
                rpItemComponent.NullText = "Chi tiết";
                rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
                column.ColumnEdit = rpItemComponent;
                this.RepositoryItems.Add(rpItemComponent);
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
                        {
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemDescCaption;
                            column.OptionsColumn.AllowEdit = true;
                            column.OptionsColumn.ReadOnly = false;
                        }
                        if (fieldName == "MMBatchProductProductionNormItemHardwareAllocationQuantity")
                        {
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemHardwareSubForSets;
                            column.OptionsColumn.AllowEdit = true;
                            column.OptionsColumn.ReadOnly = false;
                        }
                        if (fieldName == "MMBatchProductProductionNormItemQuantity")
                        {
                            column.Caption = "Số lượng";
                            column.OptionsColumn.AllowEdit = true;
                            column.OptionsColumn.ReadOnly = false;
                        }
                        //if (fieldName == "MMBatchProductProductionNormItemProductDesc")
                        //    column.Caption = ProductionNormLocalizeResources.MMHardwareItemSpecification;
                        if (fieldName == "MMBatchProductProductionNormItemProductDesc")
                            column.Caption = ProductionNormLocalizeResources.MMProductionNormItemSemiProductDepartmentAttributeCaption;
                        if (fieldName == "MMBatchProductProductionNormItemSortOrder")
                        {
                            column.Caption = ProductionNormConst.MMProductionNormOrderNoCaption;
                        }
                        if (fieldName == "MMBatchProductProductionNormItemModifiedStatus")
                            column.Caption = "Trạng thái thay đổi";

                        if (fieldName == "FK_MMProductionNormItemID")
                            column.Caption = "Mã tham chiếu BDM";
                        if (fieldName == "AACreatedDate")
                            column.Caption = "Ngày tạo";

                    }
                }
            }
            this.EndUpdate();
            this.Update();
        }


        private void ProductionNormItemsHardwareTreeListControl_CustomColumnDisplayText(object sender, DevExpress.XtraTreeList.CustomColumnDisplayTextEventArgs e)
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

        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            BatchProductEntities entity = (BatchProductEntities)((BatchProductModule)Screen.Module).CurrentModuleEntity;
            MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)entity.ProductionNormItemHardwareList.CurrentObject;
            ((BatchProductModule)Screen.Module).ShowProductionNormItemHardwareDetail(objBatchProductProductionNormItemsInfo);
        }
    }
}
