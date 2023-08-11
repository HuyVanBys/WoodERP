using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.Equipment
{
    public partial class ICProductIdentifiedEquipmentGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            EquipmentEntities entity = (EquipmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductIdentifiedEquipmentList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);


        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = false;
            }
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductSerieID")
            {
                if (e.Value != null)
                {
                    ICProductSeriesController psController = new ICProductSeriesController();
                    ICProductSeriesInfo ps = (ICProductSeriesInfo)psController.GetObjectByID(int.Parse(e.Value.ToString()));
                    if (ps != null)
                    {
                        e.DisplayText = ps.ICProductSerieNo;
                    }
                    else
                    {
                        e.DisplayText = string.Empty;
                    }
                }
            }
        }

        void rep_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            EquipmentEntities entity = (EquipmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ICProductsInfo objProductsInfo = (ICProductsInfo)entity.MainObject;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            List<ICProductSeriesInfo> productSerieList = objProductSeriesController.GetProductSerieByProductID(objProductsInfo.ICProductID);


            lookup.Properties.DataSource = productSerieList;
            lookup.Properties.DisplayMember = "ICProductSerieNo";
            lookup.Properties.ValueMember = "ICProductSerieID";


        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((EquipmentModule)Screen.Module).DeleteItemFromIdentifiedList();
            }

        }



        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            EquipmentEntities entity = (EquipmentEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.ProductIdentifiedEquipmentList.CurrentIndex >= 0)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ICProductIdentifiedEquipmentsInfo item = (ICProductIdentifiedEquipmentsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (e.Column.FieldName == "ICProductIdentifiedEquipmentNo")
                    {
                        if (!((EquipmentModule)Screen.Module).CheckValidIdentifiedNo(e.Value.ToString(), gridView.FocusedRowHandle))
                        {
                            entity.ProductIdentifiedEquipmentList[entity.ProductIdentifiedEquipmentList.CurrentIndex].ICProductIdentifiedEquipmentNo = gridView.ActiveEditor.OldEditValue.ToString();
                        }

                    }

                }

            }
        }


    }
}
