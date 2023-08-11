using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.ManagerTimeKeeper
{
    public partial class HRTimeKeepersGridControl : BOSComponent.BOSGridControl
    {
        public override void InitializeControl()
        {
            base.InitializeControl();
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = ManagerTimeKeeperLocalizedResources.EmployeeName;
            column.FieldName = "EmployeeName";
            column.OptionsColumn.AllowEdit = false;
            column.Group();
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = ManagerTimeKeeperLocalizedResources.ThName;
            //column.FieldName = "ThName";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = ManagerTimeKeeperLocalizedResources.TypeInput;
            //column.FieldName = "HRTimeKeeperCompleteInOutMode";
            //column.OptionsColumn.AllowEdit = true;
            //gridView.Columns.Add(column);

            column = new GridColumn();
            column = gridView.Columns["HRMachineTimeKeeperType"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            //column = new GridColumn();
            //column = gridView.Columns["HRTimeKeeperCompleteComment"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //}
            //column = gridView.Columns["HRTimeKeeperDate"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //}
            //column = new GridColumn();
            //column.Caption = "Máy chấm công";
            //column.FieldName = "HRTimeKeeperCompleteMachineName";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);
            //gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;

        }
        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);
            GridView gv = (GridView)sender;
            if (MessageBox.Show("Cập nhật thay đổi?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (gv.FocusedRowHandle >= 0)
                {
                    HRTimeKeepersInfo objTimeKeepersInfo = (HRTimeKeepersInfo)gv.GetRow(gv.FocusedRowHandle);
                    HRTimeKeepersController objTimeKeepersController = new HRTimeKeepersController();
                    objTimeKeepersInfo.HRMachineTimeKeeperType = e.Value.ToString();
                    objTimeKeepersController.UpdateObject(objTimeKeepersInfo);
                }
            }
        }

        //protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        //{
        //    base.GridView_KeyUp(sender, e);

        //    if (e.KeyCode == Keys.Delete)
        //    {
        //        GridView view = sender as GridView;
        //        view.DeleteRow(view.FocusedRowHandle);
        //    }
        //}

    }
}
