using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.MachineUnit
{
    public partial class MMMachineUnitOperationGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            MachineUnitEntities entity = (MachineUnitEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MachineUnitOperationList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CellValueChanged += new CellValueChangedEventHandler(GridView_CellValueChanged);
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            foreach (GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((MachineUnitModule)Screen.Module).RemoveSelectOperation();
            }
        }

        void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            MachineUnitEntities entity = (MachineUnitEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            MMOperationsController objOperationsController = new MMOperationsController();
            MMMachineUnitOperationsInfo item = (MMMachineUnitOperationsInfo)gridView.GetFocusedRow();
            if (item != null && e.Column.FieldName == "FK_MMOperationID")
            {
                List<MMMachineUnitOperationsInfo> exit = entity.MachineUnitOperationList.Where(o => o.FK_MMOperationID == item.FK_MMOperationID).ToList();
                if (exit.Count() > 1)
                {
                    BOSApp.ShowMessage("Công đoạn đã tồn tại trong danh sách");
                    item.FK_MMOperationID = 0;
                    item.MMMachineUnitOperationNo = string.Empty;
                    item.MMMachineUnitOperationName = string.Empty;
                    return;
                }
                MMOperationsInfo objOperationsInfo = new MMOperationsInfo();
                int OperationID = 0;
                if (e.Value != null)
                    int.TryParse(e.Value.ToString(), out OperationID);
                DataRow row = BOSApp.GetObjectFromCatche("MMOperations", "MMOperationID", OperationID);
                if (row != null) objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectFromDataRow(row);
                else objOperationsInfo = null;
                if (objOperationsInfo != null)
                {
                    item.MMMachineUnitOperationNo = objOperationsInfo.MMOperationNo;
                    item.MMMachineUnitOperationName = objOperationsInfo.MMOperationName;
                }
            }
        }
    }
}
