using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
namespace BOSERP.Modules.CompanyConstant
{
    public partial class GEPackageNumeringConfigsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.GeneratePackageConfigList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                if (column.FieldName == "MMProductionNormItemConfigPackageNo" || column.FieldName == "MMProductionNormItemConfigTypePrefix") column.OptionsColumn.AllowEdit = false;
            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectedGeneratePackageConfigs();
            }
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);
            GridView gridView = (GridView)sender;
            GEPackageNumeringConfigsInfo objGenerateProductNoConfigsInfo = (GEPackageNumeringConfigsInfo)gridView.GetRow(e.RowHandle);
            if (objGenerateProductNoConfigsInfo == null)
                return;
            if(objGenerateProductNoConfigsInfo.FK_ICProductAttributeID > 0)
            {
                List<MMProductionNormItemConfigsInfo> list = (new MMProductionNormItemConfigsController()).GetProductionNormItemConfigByWoodTypeID(objGenerateProductNoConfigsInfo.FK_ICProductAttributeID);
               if(list.Count() > 0)
                objGenerateProductNoConfigsInfo.MMProductionNormItemConfigPackageNo = (list.FirstOrDefault() != null)? list.FirstOrDefault().MMProductionNormItemConfigPackageNo: string.Empty ;
            }
           
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView view1 = (GridView)sender;
            GEPackageNumeringConfigsInfo item = (GEPackageNumeringConfigsInfo)view1.GetFocusedRow();
            if (item != null)
            {
                CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;

                if (e.Column.FieldName == "FK_ICProductAttributeID" || e.Column.FieldName == "GEPackageNumeringConfigHeigth" || e.Column.FieldName == "GEPackageNumeringConfigWoodType")
                {
                    int id = 0;
                    if (item.FK_ICProductAttributeID == 0 && e.Column.FieldName == "FK_ICProductAttributeID")
                    {
                        int.TryParse(e.Value.ToString(), out id);
                        item.FK_ICProductAttributeID = id;
                    }
                    List<GEPackageNumeringConfigsInfo> exits = entity.GeneratePackageConfigList.Where(o => o.FK_ICProductAttributeID == item.FK_ICProductAttributeID 
                                                                                                        && o.GEPackageNumeringConfigHeigth == item.GEPackageNumeringConfigHeigth 
                                                                                                        && o.GEPackageNumeringConfigWoodType == item.GEPackageNumeringConfigWoodType).ToList();
                    if (exits != null && exits.Count > 1)
                    {
                        BOSApp.ShowMessage("Chi tiết đã tồn tại trong danh sách");
                        if (e.Column.FieldName == "FK_ICProductAttributeID") item.FK_ICProductAttributeID = 0;
                        else if (e.Column.FieldName == "GEPackageNumeringConfigHeigth") item.GEPackageNumeringConfigHeigth = 0;
                        else if (e.Column.FieldName == "GEPackageNumeringConfigWoodType") item.GEPackageNumeringConfigWoodType = !item.GEPackageNumeringConfigWoodType;
                        return;
                    }
                    if (e.Column.FieldName == "FK_ICProductAttributeID" && item.FK_ICProductAttributeID > 0)
                    {
                        List<MMProductionNormItemConfigsInfo> list = (new MMProductionNormItemConfigsController()).GetProductionNormItemConfigByWoodTypeID(item.FK_ICProductAttributeID);
                        if (list.Count() > 0)
                            item.MMProductionNormItemConfigPackageNo = (list.FirstOrDefault() != null) ? list.FirstOrDefault().MMProductionNormItemConfigPackageNo : string.Empty;
                    }
                }
            }
        }
    }
}
