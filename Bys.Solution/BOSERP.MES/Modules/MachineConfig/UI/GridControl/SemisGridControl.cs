using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.MachineConfig
{
    public partial class SemisGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            MachineConfigEntities entity = (MachineConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICProductSemisList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                if (column.FieldName == "FK_ICProductSemiID" && column.ColumnEdit != null)
                {
                    RepositoryItemBOSLookupEdit rep = (RepositoryItemBOSLookupEdit)column.ColumnEdit;
                    if (rep != null && rep.Columns.Count > 0)
                    {
                        if (rep.Columns["ICProductSupplierNumber"] != null)
                        {
                            rep.Columns.Remove(rep.Columns["ICProductSupplierNumber"]);
                        }
                        if (rep.Columns["ICProductAttribute"] != null)
                        {
                            rep.Columns.Remove(rep.Columns["ICProductAttribute"]);
                        }
                    }
                    LookUpColumnInfo colName = new LookUpColumnInfo();
                    colName.Caption = "Tên sản phẩm";
                    colName.FieldName = "ICProductName";
                    rep.Columns.Add(colName);

                    colName = new LookUpColumnInfo();
                    colName.Caption = "Mã thành phẩm";
                    colName.FieldName = "ICProductParentNo";
                    rep.Columns.Add(colName);

                    colName = new LookUpColumnInfo();
                    colName.Caption = "Tên thành phẩm";
                    colName.FieldName = "ICProductParentName";
                    rep.Columns.Add(colName);
                }
            }
            gridView.CellValueChanged += new CellValueChangedEventHandler(gridView_CellValueChanged);
            return gridView;
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ICProductSemisInfo items = (ICProductSemisInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    ((MachineConfigModule)Screen.Module).DeleteItemSemiProductItemList();
                }

            }
        }
        void gridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            ICProductSemisInfo row = (ICProductSemisInfo)gridView.GetFocusedRow();
            if (row != null && e.Column.FieldName == "FK_ICProductSemiID")
            {
                MachineConfigEntities entity = (MachineConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                List<ICProductSemisInfo> exits = entity.ICProductSemisList.Where(o => o.FK_ICProductSemiID == row.FK_ICProductSemiID).ToList();
                if (exits != null && exits.Count > 1)
                {
                    BOSApp.ShowMessage("Sản phẩm đã tồn tại trong danh sách");
                    row.FK_ICProductSemiID = 0;
                }
                else
                {
                    ICProductsInfo iCProductsInfo = BOSApp.GetProductFromCurrentProductList(row.FK_ICProductSemiID);
                    if (iCProductsInfo != null)
                    {
                        MMMachineUnitOperationsInfo item = entity.MMMachineUnitOperationsList.Where(o => o.MMMachineUnitOperationID ==
                        ((MachineConfigModule)Screen.Module).MMMachineUnitOperationID).FirstOrDefault();
                        row.ICProductSemiName = iCProductsInfo.ICProductName;
                        row.ICProductSemiNo = iCProductsInfo.ICProductNo;
                        row.FK_ICMeasureUnitID = iCProductsInfo.FK_ICProductBasicUnitID;
                        row.FK_MMMachineUnitID = ((MachineConfigModule)Screen.Module).MachineUnitID;
                        row.FK_MMMachineUnitOperationID = ((MachineConfigModule)Screen.Module).MMMachineUnitOperationID;
                        if (item != null)
                        {
                            row.ICProductSemiCapacity = item.MMMachineUnitOperationCapacity;
                            row.ICCapacityUnit = item.MMCapacityUnit;
                            row.ICProductSemiSetupTime = item.MMMachineUnitOperationSetupTime;
                        }
                    }
                }
            }
        }
    }
}
