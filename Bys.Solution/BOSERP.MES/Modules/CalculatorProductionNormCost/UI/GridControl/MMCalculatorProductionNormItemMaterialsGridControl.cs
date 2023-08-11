using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CalculatorProductionNormCost
{
    public class MMCalculatorProductionNormItemMaterialsGridControl : BOSComponent.BOSGridControl
    {
        List<ICProductsInfo> objProductsInfoList;
        List<ICProductAttributesInfo> QualityList;
        public override void InitGridControlDataSource()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CalculatorProductionNormItemMaterialList;
            this.DataSource = bds;
        }


        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            objProductsInfoList = ((CalculatorProductionNormCostModule)Screen.Module).GetWoodIngredient();

            QualityList = ((CalculatorProductionNormCostModule)Screen.Module).GetProductItemAttributeQuality();

            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;

                if (col.FieldName == "MMCalculatorProductionNormItemMaterialTotalCost")
                {
                    col.OptionsColumn.AllowEdit = false;
                }
                else if (col.FieldName == "FK_ICProductMaterialID")
                {
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ICProductName";
                    repositoryItemLookUpEdit.ValueMember = "ICProductID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã nguyên liệu"));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên nguyên liệu"));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp1);
                    repositoryItemLookUpEdit.ButtonsStyle = BorderStyles.Office2003;
                    col.ColumnEdit = repositoryItemLookUpEdit;
                }
                //else if (col.FieldName == "FK_ICProductAttributeQualityID")
                //{
                //RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                //repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                //repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                //repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                //repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Mã"));
                //    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));

                //    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemAttributeQualityLookupEdit_QueryPopUp);
                //    col.ColumnEdit = repositoryItemLookUpEdit;
                //}
            }
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null)
            {
                //if (e.Column.FieldName == "FK_ICProductAttributeQualityID")
                //{
                //    int qualityID = 0;

                //    int.TryParse(e.Value.ToString(), out qualityID);

                //    if (qualityID > 0)
                //    {
                //        ICProductAttributesInfo quality = QualityList.FirstOrDefault(t => t.ICProductAttributeID == qualityID);
                //        if (quality != null)
                //        {
                //            e.DisplayText = quality.ICProductAttributeValue;
                //        }
                //    }

                //}

                if (e.Column.FieldName == "FK_ICProductMaterialID")
                {
                    int productID = 0;

                    int.TryParse(e.Value.ToString(), out productID);

                    ICProductsInfo product = objProductsInfoList.FirstOrDefault(t => t.ICProductID == productID);
                    if (product != null)
                    {
                        e.DisplayText = product.ICProductName;
                    }
                }
            }
        }

        //void repositoryItemAttributeQualityLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    lookUpEdit.Properties.DataSource = QualityList;
        //}

        void repositoryItemLookUpEdit_QueryPopUp1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            lookUpEdit.Properties.DataSource = objProductsInfoList;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((CalculatorProductionNormCostModule)Screen.Module).RemoveSelectedMaterialItemsList();
                }
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;

            MMCalculatorProductionNormItemMaterialsInfo item
                = (MMCalculatorProductionNormItemMaterialsInfo)gridView.GetFocusedRow();

            if (item != null)
            {
                if (e.Column.FieldName == "MMCalculatorProductionNormItemMaterialUnitCost"
                    || e.Column.FieldName == "MMCalculatorProductionNormItemMaterialDepreciationQty")
                {
                    item.MMCalculatorProductionNormItemMaterialTotalCost
                        = item.MMCalculatorProductionNormItemMaterialUnitCost
                        * item.MMCalculatorProductionNormItemMaterialDepreciationQty;
                }
                else if (e.Column.FieldName == "FK_ICProductMaterialID")
                {
                    ICProductsInfo iProduct = objProductsInfoList.FirstOrDefault(t => t.ICProductID == item.FK_ICProductMaterialID);
                    if (iProduct != null)
                    {
                        item.MMCalculatorProductionNormItemMaterialHeigth = iProduct.ICProductHeight;
                    }

                    item.FK_ICProductAttributeQualityID = 0;
                    item.MMCalculatorProductionNormItemMaterialTotalCost = 0;
                    item.MMCalculatorProductionNormItemMaterialUnitCost = 0;
                }
                else if (e.Column.FieldName == "FK_ICProductAttributeQualityID")
                {
                    ((CalculatorProductionNormCostModule)Screen.Module).GetItemMaterialUnitCost(item);
                }
                else if (e.Column.FieldName == "MMCalculatorProductionNormItemMaterialWoodQty"
                    || e.Column.FieldName == "MMCalculatorProductionNormItemMaterialDepreciationFactor")
                {
                    item.MMCalculatorProductionNormItemMaterialDepreciationQty
                        = item.MMCalculatorProductionNormItemMaterialDepreciationFactor
                            * item.MMCalculatorProductionNormItemMaterialWoodQty;

                    item.MMCalculatorProductionNormItemMaterialTotalCost
                        = item.MMCalculatorProductionNormItemMaterialUnitCost
                        * item.MMCalculatorProductionNormItemMaterialDepreciationQty;
                }

                this.RefreshDataSource();
            }

            //((CalculatorProductionNormCostModule)Screen.Module).UpdateTotalCostGo(true);
        }
    }
}
