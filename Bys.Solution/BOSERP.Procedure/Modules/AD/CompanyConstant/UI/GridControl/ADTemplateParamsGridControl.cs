using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class ADTemplateParamsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.TemplateParamsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);

            return gridView;
        }
        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ADTemplatesInfo objADTemplatesInfo = (ADTemplatesInfo)entity.ModuleObjects[TableName.ADTemplatesTableName];
            GridView gv = sender as GridView;
            if (objADTemplatesInfo == null || objADTemplatesInfo.ADTemplateID == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Tạo và lưu mẫu trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                BeginInvoke(new MethodInvoker(gv.CancelUpdateCurrentRow));
                return;
            }

            base.GridView_InitNewRow(sender, e);
            ADTemplateParamsInfo objItem = (ADTemplateParamsInfo)gv.GetRow(e.RowHandle);
            objItem.FK_ADTemplateID = objADTemplatesInfo.ADTemplateID;
        }
        protected override void GridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            base.GridView_ValidateRow(sender, e);
            if (e.Valid)
            {
                GridView gv = sender as GridView;
                ADTemplateParamsInfo objItem = (ADTemplateParamsInfo)gv.GetRow(e.RowHandle);
                if (objItem.ADTemplateParamID == 0)
                    new ADTemplateParamsController().CreateObject(objItem);
                else
                    new ADTemplateParamsController().UpdateObject(objItem);
            }
        }
        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                GridView gv = sender as GridView;
                ADTemplateParamsInfo objItem = (ADTemplateParamsInfo)gv.GetFocusedRow();
                if (objItem != null)
                    new ADTemplateParamsController().DeleteObject(objItem.ADTemplateParamID);
                ((CompanyConstantModule)Screen.Module).RemoveSelectedTemplateParams();
            }
        }
    }
}
