using BOSCommon.Constants;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.SupplierPriceSheet
{
    public class APPriceSheetItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            SupplierPriceSheetEntities entity = (SupplierPriceSheetEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PriceSheetItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["ACObjectAccessKey"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACObjectName";
                repositoryItemLookUpEdit.ValueMember = "ACObjectAccessKey";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.DataSource = GetDataSourceFormObjectLookup();
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectNo", CommonLocalizedResources.ACObjectNo));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectName", CommonLocalizedResources.ACObjectName));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectContactAddress", CommonLocalizedResources.ACObjectContactAddress));
                repositoryItemLookUpEdit.CloseUp += new CloseUpEventHandler(repositoryItemLookUpEdit_CloseUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["APPriceSheetItemPrice"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPriceSheetItemQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_GECurrencyID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                //RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                //repositoryItemLookUpEdit.DisplayMember = "GECurrencyNo";
                //repositoryItemLookUpEdit.ValueMember = "GECurrencyID";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.DataSource = GetDataSourceFormCurrencyLookup();
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("GECurrencyNo", "GECurrencyNo"));
                //repositoryItemLookUpEdit.CloseUp += new CloseUpEventHandler(repositoryItemGECurrencyLookUpEdit_CloseUp);
                //column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["FK_ICMeasureUnitID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit rpMeasureUnit = new RepositoryItemLookUpEdit();
                rpMeasureUnit.DisplayMember = "ICMeasureUnitName";
                rpMeasureUnit.ValueMember = "ICMeasureUnitID";
                rpMeasureUnit.NullText = string.Empty;
                rpMeasureUnit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));

                rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);
                column.ColumnEdit = rpMeasureUnit;

            }
            column = gridView.Columns["APPriceSheetItemProductFactor"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        private void repositoryItemLookUpEdit_CloseUp(object sender, CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            if (lke != null && e.Value != null && lke.OldEditValue != e.Value)
            {
                ((SupplierPriceSheetModule)Screen.Module).ChangeItemObject(Convert.ToString(e.Value));
            }
            else
            {
                ((SupplierPriceSheetModule)Screen.Module).ChangeItemObject(string.Empty);
            }
        }

        public List<ACObjectsInfo> GetDataSourceFormObjectLookup()
        {
            ACObjectsController objObjectsController = new ACObjectsController();
            List<ACObjectsInfo> objectList = objObjectsController.GetObjectViewPermissionByModule(this.Screen.Module.Name);
            objectList.Insert(0, new ACObjectsInfo());
            return objectList;
        }

        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SupplierPriceSheetModule)Screen.Module).DeleteItemFromPriceSheetItemList();
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            //if (e.Column.FieldName == "FK_GECurrencyID")
            //{
            //    if (e.Value != null)
            //    {
            //        int matchCodeID = int.Parse(e.Value.ToString());
            //        e.DisplayText = BOSApp.GetDisplayTextFromCatche("GECurrencyID", "GECurrencyID", int.Parse(e.Value.ToString()), "GECurrencyName");
            //    }
            //    else
            //        e.DisplayText = "";
            //}
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche(TableName.ICMeasureUnitsTableName, "ICMeasureUnitID", int.Parse(e.Value.ToString()), "ICMeasureUnitName");
                }
            }
        }

        public List<GECurrenciesInfo> GetDataSourceFormCurrencyLookup()
        {
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            List<GECurrenciesInfo> currencyList = objCurrenciesController.GetAllCurrencys();
            return currencyList;
        }

        private void repositoryItemGECurrencyLookUpEdit_CloseUp(object sender, CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((SupplierPriceSheetModule)Screen.Module).ChangeItemCurrency(Convert.ToInt32(e.Value));
            }
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            APPriceSheetItemsInfo item = (APPriceSheetItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "FK_GECurrencyID")
                {
                    if (e.Value == null && Convert.ToInt32(e.Value) == 0)
                    {
                        e.ErrorText = "Vui lòng chọn loại tiền tệ.";
                        e.Valid = false;
                    }
                }
                if (gridView.FocusedColumn.FieldName == "APPriceSheetItemProductFactor")
                {
                    if (!string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        ICProductMeasureUnitsController controller = new ICProductMeasureUnitsController();
                        ICProductMeasureUnitsInfo measureUnit = controller.GetProductMeasureUnitByProductIDAndMeasureUnitID(item.FK_ICProductID, item.FK_ICMeasureUnitID);
                        if (measureUnit != null && measureUnit.ICProductMeasureUnitIsEdit)
                            return;
                        e.ErrorText = "Hệ số không được phép thay đổi.";
                        e.Valid = false;
                    }
                }
            }
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            APPriceSheetItemsInfo item = (APPriceSheetItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {
                ICMeasureUnitsController controller = new ICMeasureUnitsController();
                DataSet measureUnits = controller.GetMeasureUnitByProductID(item.FK_ICProductID);
                if (measureUnits != null)
                {
                    lookUpEdit.Properties.DataSource = measureUnits.Tables[0];
                    lookUpEdit.Properties.DisplayMember = "ICMeasureUnitName";
                    lookUpEdit.Properties.ValueMember = "ICMeasureUnitID";
                }
                measureUnits.Dispose();
            }
        }
    }
}
