using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;


namespace BOSERP.Modules.ProductConstant
{
    public partial class MMConfigFalseConditionalsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ConfigFalseConditionalList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "MMConfigFalseConditionalLevel"
                || e.Column.FieldName == "MMConfigFalseConditionalConditional"
                || e.Column.FieldName == "MMConfigFalseConditionalConsequence")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromConfigValue(e.Column.FieldName.Substring(2, e.Column.FieldName.Length - 2), e.Value.ToString());
                }
                else
                    e.DisplayText = "";
            }
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductConstantModule)Screen.Module).RemoveSelectedConfigFalseConditionalList();
            }
        }
        protected override void AddColumnsFromColumnAlias(string strTableName, GridView gridView, List<AAColumnAliasInfo> lstColumnAlias)
        {
            base.AddColumnsFromColumnAlias(strTableName, gridView, lstColumnAlias);

            GridColumn column = new GridColumn();
            column.Caption = "Lỗi";
            column.FieldName = "MMConfigFalseConditionalName";
            column.OptionsColumn.AllowEdit = true;
            column.VisibleIndex = 0;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Giới hạn % tối đa cho phép";
            column.FieldName = "MMConfigFalseConditionalLimit";
            column.OptionsColumn.AllowEdit = true;
            column.VisibleIndex = 1;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "n0";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mức lỗi";
            column.FieldName = "MMConfigFalseConditionalLevel";
            column.OptionsColumn.AllowEdit = true;
            column.VisibleIndex = 2;
            RepositoryItemLookUpEdit repo = new RepositoryItemLookUpEdit();
            repo.DisplayMember = "ADConfigText";
            repo.ValueMember = "ADConfigKeyValue";
            repo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repo.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repo.NullText = string.Empty;
            repo.Columns.Add(new LookUpColumnInfo("ADConfigText", "Mức lỗi"));
            repo.QueryPopUp += new CancelEventHandler(rpLevel_QueryPopUp);
            column.ColumnEdit = repo;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Điều kiện";
            column.FieldName = "MMConfigFalseConditionalConditional";
            column.OptionsColumn.AllowEdit = true;
            column.VisibleIndex = 3;
            repo = new RepositoryItemLookUpEdit();
            repo.DisplayMember = "ADConfigText";
            repo.ValueMember = "ADConfigKeyValue";
            repo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repo.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repo.NullText = string.Empty;
            repo.Columns.Add(new LookUpColumnInfo("ADConfigText", "Điều kiện"));
            repo.QueryPopUp += new CancelEventHandler(rpConditional_QueryPopUp);
            column.ColumnEdit = repo;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Kết quả";
            column.FieldName = "MMConfigFalseConditionalConsequence";
            column.OptionsColumn.AllowEdit = true;
            column.VisibleIndex = 4;
            repo = new RepositoryItemLookUpEdit();
            repo.DisplayMember = "ADConfigText";
            repo.ValueMember = "ADConfigKeyValue";
            repo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repo.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repo.NullText = string.Empty;
            repo.Columns.Add(new LookUpColumnInfo("ADConfigText", "Kết quả"));
            repo.QueryPopUp += new CancelEventHandler(rpConsequence_QueryPopUp);
            column.ColumnEdit = repo;
            gridView.Columns.Add(column);
        }
        void rpLevel_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> objConfigValuesInfo = objConfigValuesController.GetADConfigValuesByKeyGroup("ConfigFalseConditionalLevel");
            if (objConfigValuesInfo != null && objConfigValuesInfo.Count > 0)
            {
                lookUpEdit.Properties.DataSource = objConfigValuesInfo;
            }
        }
        void rpConsequence_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> objConfigValuesInfo = objConfigValuesController.GetADConfigValuesByKeyGroup("ConfigFalseConditionalConsequence");
            if (objConfigValuesInfo != null && objConfigValuesInfo.Count > 0)
            {
                lookUpEdit.Properties.DataSource = objConfigValuesInfo;
            }
        }
        void rpConditional_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> objConfigValuesInfo = objConfigValuesController.GetADConfigValuesByKeyGroup("ConfigFalseConditionalConditional");
            if (objConfigValuesInfo != null && objConfigValuesInfo.Count > 0)
            {
                lookUpEdit.Properties.DataSource = objConfigValuesInfo;
            }
        }
    }
}
