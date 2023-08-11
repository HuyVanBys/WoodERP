
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Data;
using System.Windows.Forms;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using DevExpress.XtraGrid;
using DevExpress.Data;

using BOSCommon;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using System.Globalization;
using System;

namespace BOSERP.Modules.ProductionNorm
{
    public partial class ProfileManagementItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProfileManagementItemList;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            //gridView.RowHeight = 100; 
            gridView.OptionsView.RowAutoHeight = true;
            
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                if (column.FieldName == ProductionNormConst.MMProfileManagementItemUpdateUser)
                {
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                }
                if (column.FieldName == ProductionNormConst.MMProfileManagementItemUpdateUser
                    || column.FieldName == ProductionNormConst.MMProfileManagementItemUpdateDate)
                {
                    column.OptionsColumn.AllowEdit = true;
                }
                if (column.FieldName == ProductionNormConst.MMProfileManagementItemReason)
                {
                    RepositoryItemMemoEdit repRichTextReason = new RepositoryItemMemoEdit();
                    column.ColumnEdit = repRichTextReason;
                }
                if (column.FieldName == ProductionNormConst.MMProfileManagementItemDesc)
                {
                    RepositoryItemMemoEdit repRichTextReason = new RepositoryItemMemoEdit();
                    column.ColumnEdit = repRichTextReason;
                }
            }
            gridView.CustomUnboundColumnData += gridView1_CustomUnboundColumnData;
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView1_CustomColumnDisplayText);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.InitNewRow += new InitNewRowEventHandler(gridView1_InitNewRow);
            return gridView;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column;

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductionNormConst.MMProductionNormOrderNoCaption;
            column.FieldName = ProductionNormConst.MMProfileManagementItemOrderNo;
            column.OptionsColumn.AllowEdit = true;

            column.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            column.UnboundExpression = gridView.RowCount.ToString();
            foreach (GridColumn columns in gridView.Columns)
            {
                if (columns.FieldName == ProductionNormConst.MMProfileManagementItemUpdateUser)
                {
                    columns.OptionsColumn.AllowEdit = true;
                    RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                    repositoryItemLookUpEdit.DisplayMember = ProductionNormConst.HREmployeeName;
                    repositoryItemLookUpEdit.ValueMember = ProductionNormConst.HREmployeeID;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo(ProductionNormConst.HREmployeeName, ProductionNormConst.HREmployeeNameCaption));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                    columns.ColumnEdit = repositoryItemLookUpEdit;
                }
            }
            gridView.Columns.Add(column);
        }
        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductionNormModule)Screen.Module).RemoveSelectedItemFromProfileManagementItemList();
            }
        }
        public void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = e.ListSourceRowIndex + 1;
        }

        public void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            DataTable dt = ((ProductionNormModule)Screen.Module).GetEmployee();
            lookUpEdit.Properties.DataSource = dt;
        }

        private void gridView1_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (e.Column.FieldName == ProductionNormConst.MMProfileManagementItemUpdateUser)
            {
                int value = 0;
                if (e.Value != null)
                {
                    int employeeID = 0;
                    int.TryParse(e.Value.ToString(),out employeeID);
                    value = employeeID;
                    if (employeeID > 0)
                    {
                        HREmployeesController objEmployeesController = new HREmployeesController();
                        HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(employeeID);
                        if(objEmployeesInfo != null)
                            e.DisplayText = objEmployeesInfo.HREmployeeName;
                    }
                }
                if (value == 0)
                    e.DisplayText = string.Empty;
            }
        }
        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            ColumnView View = sender as ColumnView;
            View.SetRowCellValue(e.RowHandle, View.Columns[ProductionNormConst.MMProfileManagementItemUpdateDate], DateTime.Today);
            View.SetRowCellValue(e.RowHandle, View.Columns[ProductionNormConst.MMProfileManagementItemUpdateUser], BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            if (((ProductionNormModule)Screen.Module).IsEditable())
            {
                ((ProductionNormModule)Screen.Module).ActionEdit();
            }
        }
    }
}