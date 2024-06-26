using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConstant
{
    public partial class MMFormulaConfigurationAddMaterialGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MMFormulaAddmaterialConfigList;
            this.DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = true;
                if (item.FieldName == "FK_MMFormulaID")
                {
                    item.Caption = "Mã CT";
                    item.FieldName = "FK_MMFormulaID";
                    item.OptionsColumn.AllowEdit = true;
                    item.Visible = true;
                    item.VisibleIndex = 1;
                    RepositoryItemLookUpEdit repositoryItemWoodLookUpEdit = new RepositoryItemLookUpEdit();
                    repositoryItemWoodLookUpEdit.DisplayMember = "MMFormulaNo";
                    repositoryItemWoodLookUpEdit.ValueMember = "MMFormulaID";
                    repositoryItemWoodLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemWoodLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemWoodLookUpEdit.NullText = string.Empty;
                    repositoryItemWoodLookUpEdit.Columns.Add(new LookUpColumnInfo("MMFormulaNo", "Mã CT"));
                    repositoryItemWoodLookUpEdit.Columns.Add(new LookUpColumnInfo("MMFormulaNo", "Tên"));
                    repositoryItemWoodLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(AddMaterial_QueryPopUp);
                    item.ColumnEdit = repositoryItemWoodLookUpEdit;
                }
                if (item.FieldName == "MMFormulaConfigurationTopQty")
                    item.Caption = "Cạnh dày";
            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            //gridView.CustomRowCellEdit;
            return gridView;
        }
        public void AddMaterial_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            MMFormulasController objMMFormulasController = new MMFormulasController();
            List<MMFormulasInfo> MMFormulasList = new List<MMFormulasInfo>();
            MMFormulasInfo objMMFormulasInfo = new MMFormulasInfo();
            //objProductAttributesInfo.ICProductAttributeID = 0;

            if (!BOSApp.LookupTables.Contains("MMFormulas"))
                MMFormulasList = objMMFormulasController.GETALL_MMFormulas();
            else
            {
                DataSet ds = (DataSet)BOSApp.LookupTables["MMFormulas"];
                if (ds != null && ds.Tables.Count > 0)
                {
                    MMFormulasList = (List<MMFormulasInfo>)objMMFormulasController.GetListFromDataSet(ds);
                }
            }

            if (MMFormulasList != null)
            {
                MMFormulasList = MMFormulasList.Where(o => o.MMFormulaType == "AddMaterial").ToList();
                if (MMFormulasList != null)
                {
                    MMFormulasList.Insert(0, objMMFormulasInfo);
                    lookUpEdit.Properties.DataSource = MMFormulasList;
                }
            }
            lookUpEdit.Properties.DisplayMember = "MMFormulaNo";
            lookUpEdit.Properties.ValueMember = "MMFormulaID";
        }
        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_MMFormulaID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMFormulas", "MMFormulaID", int.Parse(e.Value.ToString()), "MMFormulaNo");
                }
            }
        }


        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            //GridColumn column = new GridColumn();
            //column.Caption = "Mã loại sơn";
            //column.FieldName = "FK_MMFormulaID";
            //column.OptionsColumn.AllowEdit = true;
            //column.Visible = true;
            //column.VisibleIndex = 1;
            //RepositoryItemLookUpEdit repositoryItemWoodLookUpEdit = new RepositoryItemLookUpEdit();
            //repositoryItemWoodLookUpEdit.DisplayMember = "MMFormulaNo";
            //repositoryItemWoodLookUpEdit.ValueMember = "MMFormulaID";
            //repositoryItemWoodLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //repositoryItemWoodLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            //repositoryItemWoodLookUpEdit.NullText = string.Empty;
            //repositoryItemWoodLookUpEdit.Columns.Add(new LookUpColumnInfo("MMFormulaNo", "Mã sơn"));
            //repositoryItemMMFormulaIDLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Loại"));

            //repositoryItemWoodLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemProductWoodType_QueryPopUp);
            //column.ColumnEdit = repositoryItemWoodLookUpEdit;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = "Mặt";
            //column.FieldName = "MMFormulaConfigurationTopQty";
            //column.OptionsColumn.AllowEdit = true;
            //column.Visible = true;
            //column.VisibleIndex = 2;

            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = "Ngắn";
            //column.FieldName = "MMFormulaConfigurationShortEdgeQty";
            //column.OptionsColumn.AllowEdit = true;
            //column.Visible = true;
            //column.VisibleIndex = 3;
            //gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = "Dài";
            //column.FieldName = "MMFormulaConfigurationLongEdgeQty";
            //column.OptionsColumn.AllowEdit = true;
            //column.Visible = true;
            //column.VisibleIndex = 3;
            //gridView.Columns.Add(column);
        }
        //public void repositoryItemProductWoodType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    LookUpEdit lookUpEdit = (LookUpEdit)sender;
        //    MMFormulasController objMMFormulasController = new MMFormulasController();
        //    List<MMFormulasInfo> MMFormulasList = new List<MMFormulasInfo>();
        //    MMFormulasInfo objMMFormulasInfo = new MMFormulasInfo();
        //    //objProductAttributesInfo.ICProductAttributeID = 0;


        //    MMFormulasList = objMMFormulasController.GETALL_MMFormulas();

        //    if (MMFormulasList != null)
        //    {
        //        MMFormulasList.Insert(0, objMMFormulasInfo);
        //        lookUpEdit.Properties.DataSource = MMFormulasList;
        //    }
        //    lookUpEdit.Properties.DisplayMember = "MMFormulaNo";
        //    lookUpEdit.Properties.ValueMember = "MMFormulaID";
        //}
        //protected override GridView InitializeGridView()
        //{
        //    GridView gridView = base.InitializeGridView();
        //    foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
        //        column.OptionsColumn.AllowEdit = true;
        //    gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
        //    return gridView;
        //}

        //protected void GridView_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        //{

        //    e.ExceptionMode = ExceptionMode.DisplayError;

        //}

        //protected void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        //{
        //    GridView gridView = (GridView)sender;
        //    string configText = Convert.ToString(gridView.GetFocusedRowCellValue("ADConfigText"));

        //    if (e.Value != null)
        //    {
        //        if (gridView.FocusedColumn.FieldName == "ADConfigText")
        //        {
        //            if (string.IsNullOrEmpty(e.Value.ToString()))
        //            {
        //                e.ErrorText = CompanyConstantLocalizedResources.NotNullOrEmptyProductTypeMessage.ToString();
        //                e.Valid = false;
        //            }
        //            else
        //            {
        //                if (!configText.Equals(e.Value.ToString().Trim()))
        //                {
        //                    string configValuesType = "Product";
        //                    ((CompanyConstantModule)Screen.Module).CheckConfigValues(e.Value.ToString().Trim(), e, configValuesType);

        //                }
        //            }
        //        }
        //    }
        //}

        protected override void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);
        }

        protected override void GridView_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductConstantModule)Screen.Module).RemoveMMFormulaAddMaterialConfigList();
            }
        }
    }
}
