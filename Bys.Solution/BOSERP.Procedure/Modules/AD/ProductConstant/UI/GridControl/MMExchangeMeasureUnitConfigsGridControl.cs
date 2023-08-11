using BOSCommon;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConstant
{
    public partial class MMExchangeMeasureUnitConfigsConfigGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MMExchangeMeasureUnitConfigsList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                if (column.FieldName == "FK_ICProductID")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ICProductName";
                    repositoryItemLookUpEdit.ValueMember = "ICProductID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã sản phẩm"));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNoOfOldSys", "Mã HT cũ"));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên sản phẩm"));
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả"));
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    ICProductsController objProductsController = new ICProductsController();
                    repositoryItemLookUpEdit.DataSource = BOSApp.CurrentProductList.Where(x => x.ICProductType != ProductType.Work.ToString()
                                                                      && x.ICProductType != ProductType.Service.ToString()
                                                                      && x.ICProductType != ProductType.SemiProduct.ToString()).ToList();
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryProductLookUpEdit_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                }
                if (column.FieldName == "MMExchangeMeasureUnitConfigHeightOperation")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                    repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Công thức"));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;


                    //ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    //DataSet ds = objConfigValuesController.GetADConfigValuesByGroup(OverallInsideDimensionConfigOperationType.OverallInsideDimensionConfigOperationType.ToString());


                    //repositoryItemLookUpEdit.Properties.DataSource = ds;
                    //column.ColumnEdit = repositoryItemLookUpEdit;
                }
                if (column.FieldName == "MMExchangeMeasureUnitConfigWidthOperation")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                    repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Công thức"));
                    repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;

                }
                if (column.FieldName == "MMExchangeMeasureUnitConfigLengthOperation")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                    repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Công thức"));
                    repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                }
                if (column.FieldName == "MMExchangeMeasureUnitConfigQuantity")
                {
                    column.OptionsColumn.AllowEdit = true;
                    RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                    repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Công thức"));
                    repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                }





            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

            if (e.Column.FieldName == "MMExchangeMeasureUnitConfigHeightOperation")
            {
                if (e.Value != null)
                {
                    ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(OverallInsideDimensionConfigOperationType.OverallInsideDimensionConfigOperationType.ToString(), e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                }
            }
            if (e.Column.FieldName == "MMExchangeMeasureUnitConfigWidthOperation")
            {
                if (e.Value != null)
                {
                    ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(OverallInsideDimensionConfigOperationType.OverallInsideDimensionConfigOperationType.ToString(), e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                }
            }
            if (e.Column.FieldName == "MMExchangeMeasureUnitConfigLengthOperation")
            {
                if (e.Value != null)
                {
                    ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(OverallInsideDimensionConfigOperationType.OverallInsideDimensionConfigOperationType.ToString(), e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                }
            }
            if (e.Column.FieldName == "MMExchangeMeasureUnitConfigQuantity")
            {
                if (e.Value != null)
                {
                    ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue(OverallInsideDimensionConfigOperationType.OverallInsideDimensionConfigOperationType.ToString(), e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                }
            }
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    int ProductID = 0;

                    if (int.TryParse(e.Value.ToString(), out ProductID))
                    {
                        if (ProductID > 0)
                        {
                            ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.Where(x => x.ICProductID == ProductID).FirstOrDefault();
                            e.DisplayText = objProductsInfo.ICProductDesc;
                        }
                    }
                }
            }
        }

        void repositoryItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            objConfigValuesInfo.ADConfigValueID = 0;
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup(OverallInsideDimensionConfigOperationType.OverallInsideDimensionConfigOperationType.ToString());
            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                ConfigValuesList.Add(objConfigValuesInfo);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    ConfigValuesList.Add(objConfigValuesInfo);
                }
            }
            if (ConfigValuesList != null)
            {
                lookUpEdit.Properties.DataSource = ConfigValuesList;
            }
            lookUpEdit.Properties.DisplayMember = "ADConfigText";
            lookUpEdit.Properties.ValueMember = "ADConfigKeyValue";
            ds.Dispose();
        }

        void repositoryProductLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            lookUpEdit.Properties.DataSource = BOSApp.CurrentProductList.Where(x => x.ICProductType != ProductType.Work.ToString()
                                                                      && x.ICProductType != ProductType.Service.ToString()
                                                                      && x.ICProductType != ProductType.SemiProduct.ToString()).ToList();
            lookUpEdit.Properties.DisplayMember = "ICProductName";
            lookUpEdit.Properties.ValueMember = "ICProductID";
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((ProductConstantModule)Screen.Module).RemoveSelectedMMExchangeMeasureUnitConfigs();
                }
            }
        }


    }
}
