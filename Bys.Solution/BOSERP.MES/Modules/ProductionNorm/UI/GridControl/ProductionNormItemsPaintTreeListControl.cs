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
using System.Drawing;
using Localization;

namespace BOSERP.Modules.ProductionNorm
{
    public partial class ProductionNormItemsPaintTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties
        
        #endregion

        protected override void InitTreeListDataSource()
        {
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DataSource = entity.ProductionNormItemPaintList; 
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
            this.FocusedColumnChanged += new DevExpress.XtraTreeList.FocusedColumnChangedEventHandler(ProductionNormItemsPaintTreeListControl_FocusedColumnChanged);
            this.FocusedNodeChanged += new FocusedNodeChangedEventHandler(ProductionNormItemsPaintTreeListControl_FocusedNodeChanged);
          //  this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
            this.CustomDrawNodeCell += new CustomDrawNodeCellEventHandler(ProductionNormItemsPaintTreeListControl_CustomDrawNodeCell);
        }

        void ProductionNormItemsPaintTreeListControl_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (this.Columns["MMProductionNormItemPaint"] != null)
            {
                if (((ProductionNormModule)Screen.Module).IsPaintProcessNode())
                {
                    this.Columns["MMProductionNormItemPaint"].OptionsColumn.AllowEdit = true;
                    this.Columns["MMProductionNormItemPaint"].OptionsColumn.ReadOnly = false;
                }
                else
                {

                    this.Columns["MMProductionNormItemPaint"].OptionsColumn.AllowEdit = false;
                    this.Columns["MMProductionNormItemPaint"].OptionsColumn.ReadOnly = true;
                }
            }
        }

        void ProductionNormItemsPaintTreeListControl_FocusedColumnChanged(object sender, DevExpress.XtraTreeList.FocusedColumnChangedEventArgs e)
        {
            if (e.Column.FieldName == "MMProductionNormItemPaint")
            {
                if (((ProductionNormModule)Screen.Module).IsPaintProcessNode())
                {
                    e.Column.OptionsColumn.AllowEdit = true;
                    e.Column.OptionsColumn.ReadOnly = false;
                }
                else
                {

                    e.Column.OptionsColumn.AllowEdit = false;
                    e.Column.OptionsColumn.ReadOnly = true;
                }
             
            
            }
        }

      
        
        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            Columns.Clear();
            #region InitTreeListColumns
           // AddTreeListColumns(0, ProductionNormConst.MMProductionNormItemSortOrder, false, true);
            AddTreeListColumns(1, ProductionNormConst.MMProductionNormItemICProductName, true, false);
            AddTreeListColumns(2, ProductionNormConst.MMProductionNormItemNo, true, false);
          
            AddTreeListColumns(3, "MMProductionNormItemPaint", false, true);
           // AddTreeListColumns(3, "MMProductionNormItemProductAttributeValue1", true, false);
            AddTreeListColumns(4, "MMProductionNormItemProductSupplierNumber", false, true);
            AddTreeListColumns(9, "MMProductionNormItemPaintMixRatio", false, true);
            AddTreeListColumns(5, ProductionNormConst.MMProductionNormItemQuantity, false, true);
            AddTreeListColumns(6, ProductionNormConst.FK_ICMeasureUnitID, false, true);
            //AddTreeListColumns(7, "MMProductionNormItemProductSupplierName", false, true);
            AddTreeListColumns(7, "FK_APSupplierID", false, true);
            AddTreeListColumns(8, ProductionNormConst.MMProductionNormItemDesc, false, true);

            AddTreeListColumns(9, ProductionNormConst.MMProductionNormItemPaintPerOne, false, true);
            //AddTreeListColumns(8, ProductionNormConst.MMProductionNormItemTotalQuantity, false, true);
            //AddTreeListColumns(9, ProductionNormConst.MMProductionNormItemNeededTime, false, false);
            
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
                            if (fieldName == ProductionNormConst.MMProductionNormItemDesc)
                                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemDescCaption;
                            //if (fieldName == "MMProductionNormItemProductAttributeValue1")
                            //    column.Caption = ProductionNormLocalizeResources.MMProductionNormItemSemiProductDepartmentAttributeCaption;
                        }
                    }
                }
            }
            if (fieldName == ProductionNormConst.MMProductionNormItemSortOrder)
            {
                column.Caption = ProductionNormConst.MMProductionNormOrderNoCaption;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                //column.Width = 70;
                column.BestFit();
            }
            if (fieldName == ProductionNormConst.MMProductionNormItemICProductName)
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNamePaint;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.BestFit();
            }
            if (fieldName == ProductionNormConst.MMProductionNormItemNo)
            {
                column.VisibleIndex = visibleIndex;
                column.FieldName = fieldName;
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductNoPaint;
                column.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
                column.Width = 350;
                //column.BestFit();
            }
            if (fieldName == "MMProductionNormItemProductSupplierNumber")
                column.Caption = ProductionNormLocalizeResources.MMProductionNormItemICProductSupplierNumber;
            if (fieldName == "FK_APSupplierID")
            {
                //column.Caption = ProductionNormLocalizeResources.APSupplierName;
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "APSupplierName";
                repositoryItemLookUpEdit.ValueMember = "APSupplierID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("APSupplierName", "Tên NCC"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemUnitLookUpEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 100;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            if (fieldName == "MMProductionNormItemPaintMixRatio")
            {
                column.Caption = "Tỉ lệ pha";
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
              //  repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemUnitLookUpEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 50;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
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
            dsColumns.Dispose();
            this.EndUpdate();
            this.Update();
        }
        //private void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        //{
        //    ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
           
        //    TreeListNode node = entity.ProductionNormItemPaintList.TreeListControl.GetSelectedNode();

        //    if (node != null && node.Level > 0)
        //    {
        //        MMProductionNormItemsInfo objProductionNormItemsInfo = new MMProductionNormItemsInfo();
        //        objProductionNormItemsInfo = (MMProductionNormItemsInfo)entity.ProductionNormItemPaintList.CurrentObject;

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
        public void repositoryItemUnitLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            DataTable dt = ((ProductionNormModule)Screen.Module).GetAPSupplier();
            lookUpEdit.Properties.DataSource = dt;
        }
        private void ProductionNormItemsPaintTreeListControl_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
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
            if (e.Column.FieldName == "FK_APSupplierID")
            {
                if (e.CellValue != null)
                {
                    int value = 0;
                    if (int.TryParse(e.CellValue.ToString(), out value))
                    {
                        APSuppliersController objSuppliersController = new APSuppliersController();
                        APSuppliersInfo objSuppliersInfo = (APSuppliersInfo)objSuppliersController.GetObjectByID(value);
                        if (objSuppliersInfo != null)
                            e.CellText = objSuppliersInfo.APSupplierName;
                    }
                }
            }
        }
    }
}
