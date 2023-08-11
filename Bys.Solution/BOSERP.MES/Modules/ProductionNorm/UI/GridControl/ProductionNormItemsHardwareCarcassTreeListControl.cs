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
    public partial class ProductionNormItemsHardwareCarcassTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties
        #endregion

        protected override void InitTreeListDataSource()
        {
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DataSource = entity.ProductionNormItemHardwareCarcassList; 
        }
        public override void InitializeControl()
        {
            base.InitializeControl();
            this.ExpandAll();
            this.OptionsView.AutoWidth = false;
            this.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto;
            this.BOSDisplayRoot = true;
            this.BOSDisplayOption = true;
            this.BestFitColumns();
            
            //this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
            this.CustomDrawNodeCell += new CustomDrawNodeCellEventHandler(ProductionNormItemsHardwareTreeListControl_CustomDrawNodeCell);
            this.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(ProductionNormItemsHardwareTreeListControl_CellValueChanged);
            this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
        }

        private void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            MMProductionNormsInfo mainObject = (MMProductionNormsInfo)entity.MainObject;
            TreeListNode node = entity.ProductionNormItemHardwareCarcassList.TreeListControl.GetSelectedNode();
            if (node != null)
            {
                MMProductionNormItemsInfo objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemHardwareCarcassList.CurrentObject;
                if (objProductionNormItemsInfo != null)
                {
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductionNormItemsInfo.FK_ICProductID);
                    if (objProductsInfo != null)
                    {
                        mainObject.MMProductionNormsProductItemPicture = objProductsInfo.ICProductPicture;
                        entity.UpdateMainObjectBindingSource();
                    }
                    
                }
            }
        }
        void ProductionNormItemsHardwareTreeListControl_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            //throw new NotImplementedException();
            string columnName = ((DevExpress.XtraTreeList.CellEventArgs)(e)).Column.FieldName;            
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;           
            TreeListNode node = entity.ProductionNormItemHardwareCarcassList.TreeListControl.GetSelectedNode();

            if (node != null && columnName.Contains("Quantity") && e.Value.Equals(""))
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
                objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemHardwareCarcassList.CurrentObject;
                if(objProductionNormItemsInfo != null)
                    dbUtil.SetPropertyValue(objProductionNormItemsInfo, columnName, 0);                   
            }

            
        }
          private void ProductionNormItemsHardwareTreeListControl_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            if (e.Column.FieldName == ProductionNormConst.FK_ICMeasureUnitID)
            {
                if (e.CellValue != null )
                {
                    int value =0;
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
        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            Columns.Clear();
            #region InitTreeListColumns
            AddTreeListColumns(1, ProductionNormConst.MMProductionNormItemSortOrder, true, false);
            AddTreeListColumns(2, ProductionNormConst.MMProductionNormItemICProductName, true, false);
            AddTreeListColumns(3, ProductionNormConst.MMProductionNormItemNo, true, false);
            AddTreeListColumns(4, "MMProductionNormItemProductSizeAndPacking", true, false);
            AddTreeListColumns(5, "MMProductionNormItemProductDesc", true, false);
            AddTreeListColumns(6, ProductionNormConst.FK_ICMeasureUnitID, true, false);
            AddTreeListColumns(7, "MMHardwareOperationType", false, true);
            //AddTreeListColumns(8, "MMProductionNormItemHardwareAllocationQuantity", false, true);
            AddTreeListColumns(8, ProductionNormConst.MMProductionNormItemQuantity, true, false);
            //AddTreeListColumns(9, "MMProductionNormItemHardwareAssembleQuantity", false, true);
            AddTreeListColumns(9, "MMProductionNormItemComment", true, false);            
            #endregion
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
            if (fieldName == ProductionNormConst.MMProductionNormItemSortOrder)
            {
                column.Caption = ProductionNormConst.MMProductionNormOrderNoCaption;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Width = 70;
                column.BestFit();
            }
            if (fieldName == ProductionNormConst.MMProductionNormItemICProductName)
            {
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNameHardware;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Width = 250;
                column.BestFit();
            }
            
            if (fieldName == ProductionNormConst.MMProductionNormItemNo)
            {
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNoHardware;
                column.Width = 350;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                //column.BestFit();
            }
            if (fieldName == ProductionNormConst.MMProductionNormItemQuantity)
            {
                column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.Format.FormatString = "{0:n2}";
            }
            if (fieldName == "MMProductionNormItemHardware")
            {
                RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
                column.Caption = "Chi tiết cấp phát";
                rpItemComponent.NullText = "Chi tiết";
                rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
                column.ColumnEdit = rpItemComponent;
                this.RepositoryItems.Add(rpItemComponent);
            }
            if (fieldName == "MMHardwareOperationType")
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Công đoạn"));
                // repositoryItemLookUpEdit.QueryPopUp +=new CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                ADReportsController reportCtrl = new ADReportsController();
                List<ADConfigValuesInfo> configList = reportCtrl.GetObjectByADConfigKeyGroup(ConfigValueGroup.HardwareOperationType);
                repositoryItemLookUpEdit.DataSource = configList;
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 50;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (fieldName == ProductionNormConst.FK_ICMeasureUnitID)
            {
                column.OptionsColumn.AllowEdit = AllowEdit;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICMeasureUnitName";
                repositoryItemLookUpEdit.ValueMember = "ICMeasureUnitID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
               // repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemUnitLookUpEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 50;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
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
                            {
                                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemDescCaption;
                                column.OptionsColumn.AllowEdit = true;
                                column.OptionsColumn.ReadOnly = false;
                            }
                            if (fieldName == "MMProductionNormItemHardwareAllocationQuantity")
                                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemHardwareSubForSets;
                            //if (fieldName == ProductionNormConst.MMProductionNormItemQuantity)
                            //    column.Caption = ProductionNormLocalizeResources.MMProductionNormItemHardwareQuantity;
                            if (fieldName == "MMProductionNormItemProductSizeAndPacking")
                                column.Caption = ProductionNormLocalizeResources.MMHardwareItemSpecification;
                            if (fieldName == "MMProductionNormItemProductDesc")
                                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemSemiProductDepartmentAttributeCaption;
                            if (fieldName == ProductionNormConst.MMProductionNormItemSortOrder)
                            {
                                column.Caption = ProductionNormConst.MMProductionNormOrderNoCaption;
                            }
                            if (fieldName == "MMProductionNormItemHardwareAssembleQuantity")
                            {
                                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemHardwareAssembleTotalQuantityCaption;
                            }
                        }
                    
                }
            }
            dsColumns.Dispose();
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
        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            ProductionNormEntities entity = (ProductionNormEntities)((ProductionNormModule)Screen.Module).CurrentModuleEntity;
            MMProductionNormItemsInfo objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemHardwareCarcassList.CurrentObject;
            ((ProductionNormModule)Screen.Module).ShowProductionNormItemHardwareDetail(objProductionNormItemsInfo, true);
        } 
        void repositoryItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            List<ICMeasureUnitsInfo> ds = objMeasureUnitsController.GetAllAliveMeasureUnit();

            lookUpEdit.Properties.DataSource = ds;
        }
        //private void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        //{
        //    ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
           
        //    TreeListNode node = entity.ProductionNormItemHardwareCarcassList.TreeListControl.GetSelectedNode();

        //    if (node != null && node.Level > 0)
        //    {
        //        MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
        //        objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemHardwareCarcassList.CurrentObject;

        //        if (objProductionNormItemsInfo != null && objProductionNormItemsInfo.FK_ICProductID > 0)
        //            ((ProductionNormModule)Screen.Module).InvalidateProductionNormInventoryStockGridControl(objProductionNormItemsInfo.FK_ICProductID, ProductType.Hardware.ToString());
        //    }
        //}
        //public void repositoryItemUnitLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    DataTable dt = ((ProductionNormModule)Screen.Module).GetMeasureUnit();
        //    lookUpEdit.Properties.DataSource = dt;
        //}

    }
}
