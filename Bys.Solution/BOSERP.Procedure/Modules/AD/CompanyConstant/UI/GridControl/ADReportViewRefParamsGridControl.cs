using BOSComponent;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class ADReportViewRefParamsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ViewRefParamsList;
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
            ADReportViewRefsInfo objADTemplatesInfo = (ADReportViewRefsInfo)entity.ModuleObjects["ADReportViewRefs"];
            int ADReportViewRefID = 0;
            GridView gv = sender as GridView;
            if ((objADTemplatesInfo == null || objADTemplatesInfo.ADReportViewRefID == 0) && entity.ViewRefParamsList.Count() == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Tạo và lưu cấu hình báo cáo hoặc module trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                BeginInvoke(new MethodInvoker(gv.CancelUpdateCurrentRow));
                return;
            }
            else if (entity.ViewRefParamsList.Count() > 0 && objADTemplatesInfo == null)
            {
                ADReportViewRefID = entity.ViewRefParamsList[0].FK_ADReportViewRefID;
            }
            else if (objADTemplatesInfo != null)
                ADReportViewRefID = objADTemplatesInfo.ADReportViewRefID;
            if (ADReportViewRefID == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Tạo và lưu cấu hình báo cáo hoặc module trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                BeginInvoke(new MethodInvoker(gv.CancelUpdateCurrentRow));
                return;
            }
            base.GridView_InitNewRow(sender, e);
            ADReportViewRefParamsInfo objItem = (ADReportViewRefParamsInfo)gv.GetRow(e.RowHandle);
            objItem.FK_ADReportViewRefID = ADReportViewRefID;
        }
        protected override void GridView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            base.GridView_ValidateRow(sender, e);
            if (e.Valid)
            {
                GridView gv = sender as GridView;
                ADReportViewRefParamsInfo objItem = (ADReportViewRefParamsInfo)gv.GetRow(e.RowHandle);
                if (objItem.ADReportViewRefParamID == 0)
                    new ADReportViewRefParamsController().CreateObject(objItem);
                else
                    new ADReportViewRefParamsController().UpdateObject(objItem);
            }
        }
        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                GridView gv = sender as GridView;
                ADReportViewRefParamsInfo objItem = (ADReportViewRefParamsInfo)gv.GetFocusedRow();
                if (objItem != null)
                    new ADReportViewRefParamsController().DeleteObject(objItem.ADReportViewRefParamID);
                ((CompanyConstantModule)Screen.Module).RemoveSelectedReportViewRefParam();
            }
        }
    }
}
