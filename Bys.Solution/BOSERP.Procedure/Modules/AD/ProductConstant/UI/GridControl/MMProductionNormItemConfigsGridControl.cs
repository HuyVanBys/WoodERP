using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConstant
{
    public partial class MMProductionNormItemConfigsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductionNormItemConfigsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Chọn tất cả";
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            gridView.Columns.Add(column);
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);


        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView_CellValueChanging);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }
        public void repositoryItemLookUpEditWoodType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributeList = new List<ICProductAttributesInfo>();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            objProductAttributesInfo.ICProductAttributeID = 0;
            productAttributeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeWoodTypeColumnName);
            if (productAttributeList != null)
            {
                productAttributeList.Insert(0, objProductAttributesInfo);
                lookUpEdit.Properties.DataSource = productAttributeList;
            }
            lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
            lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
        }
        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            if (e.Column.FieldName == "FK_ICProductAttributeID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(matchCodeID);
                    if (objProductAttributesInfo != null)
                        e.DisplayText = objProductAttributesInfo.ICProductAttributeValue;
                }
            }
        }

        void gridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            ProductConstantEntities entity = (ProductConstantEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ProductionNormItemConfigsList.CurrentIndex >= 0)
            {

                if (e.Column.FieldName == "Selected")
                {
                    bool isSelected = false;
                    if (bool.TryParse(e.Value.ToString(), out isSelected))
                    {
                        ((ProductConstantModule)Screen.Module).SelectedAllChange(entity.ProductionNormItemConfigsList.CurrentIndex, isSelected);

                    }
                }
            }
        }


    }
}
