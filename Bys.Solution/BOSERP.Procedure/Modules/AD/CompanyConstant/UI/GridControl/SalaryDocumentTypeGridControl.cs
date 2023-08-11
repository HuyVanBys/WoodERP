using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class SalaryDocumentTypeGridControl : BOSComponent.BOSGridControl
    {
        #region Constants
        #endregion
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SalaryDocumentTypeList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowAutoFilterRow = true;

            GridColumn column = gridView.Columns["ACSalaryDocumentTypeDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACSalaryDocumentTypeName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACSalaryDocumentTypeTakeEmployee"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.FieldName = "Delete";
            column.Caption = "Xóa";
            RepositoryItemHyperLinkEdit repXoa = new RepositoryItemHyperLinkEdit();
            repXoa.NullText = "Xóa";
            repXoa.Click += new EventHandler(rep_DeleteClick);
            column.ColumnEdit = repXoa;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "Detail";
            column.Caption = "Quy cách tính";
            RepositoryItemHyperLinkEdit repDetail = new RepositoryItemHyperLinkEdit();
            repDetail.NullText = "Quy cách tính";
            repDetail.Click += new EventHandler(rep_Click);
            column.ColumnEdit = repDetail;
            gridView.Columns.Add(column);
        }

        protected override void GridView_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelecteSalaryDocumentType();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ACSalaryDocumentTypesInfo objSalaryDocumentTypesInfo = (ACSalaryDocumentTypesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (objSalaryDocumentTypesInfo.ACSalaryDocumentTypeName == string.Empty)
            {
                objSalaryDocumentTypesInfo.ACSalaryDocumentTypeName = ERPModuleEntities.cstNewObjectText;
            }
            entity.SalaryDocumentTypeList.GridControl.RefreshDataSource();
        }

        void rep_DeleteClick(object sender, EventArgs e)
        {
            ((CompanyConstantModule)Screen.Module).RemoveSelecteSalaryDocumentType();
        }

        void rep_Click(object sender, EventArgs e)
        {
            ((CompanyConstantModule)Screen.Module).ChangeSalaryDocumentTypePayRoll();
        }
    }
}
