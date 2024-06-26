using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConstant
{
    public partial class ConfigThinkAccordWoodGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ConfigThinkAccordWoodTypeList;
            this.DataSource = bds;
        }

        public void repositoryItemLookUpEditThink_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributeList = new List<ICProductAttributesInfo>();
            ICProductAttributesInfo objProductAttributesInfo = new ICProductAttributesInfo();
            objProductAttributesInfo.ICProductAttributeID = 0;
            productAttributeList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(MatchCodeConst.MatchCodeThickColumnName);
            if (productAttributeList != null)
            {
                productAttributeList.Insert(0, objProductAttributesInfo);
                lookUpEdit.Properties.DataSource = productAttributeList;
            }
            lookUpEdit.Properties.DisplayMember = "ICProductAttributeValue";
            lookUpEdit.Properties.ValueMember = "ICProductAttributeID";
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

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                if (column.FieldName == "FK_ICProductAttributeID")
                {
                    column.Caption = "Độ dày";
                    column.OptionsColumn.AllowEdit = true;

                    repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                    repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                    repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Độ dày"));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditThink_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                }
                else if (column.FieldName == "FK_ICProductAttributeWoodTypeID")
                {
                    column.Caption = "Loại gỗ";
                    column.OptionsColumn.AllowEdit = true;

                    repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                    repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                    repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                    repositoryItemLookUpEdit.NullText = string.Empty;
                    repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Loại gỗ"));
                    repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditWoodType_QueryPopUp);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                }
            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }


        protected override void GridView_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                entity.ConfigThinkAccordWoodTypeList.RemoveSelectedRowObjectFromList();
            }
        }
        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            if (e.Column.FieldName == "FK_ICProductAttributeID"
                || e.Column.FieldName == "FK_ICProductAttributeWoodTypeID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche(TableName.ICProductattributesTableName, "ICProductattributeID", int.Parse(e.Value.ToString()), "ICProductattributeValue");
                }
            }
        }
    }
}
