using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class ADInsurranceConditionsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.InsurranceConditionsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            GridColumn column = gridView.Columns["ADInsurranceConditionNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ADInsurranceConditionName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ADInsurranceConditionSocialID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemCheckedComboBoxEdit checkedComboBoxEdit = new RepositoryItemCheckedComboBoxEdit();
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                List<ADConfigValuesInfo> list = objConfigValuesController.GetADConfigValuesByKeyGroup("SocialInsuranceDeclarationType");
                checkedComboBoxEdit.DataSource = list;
                checkedComboBoxEdit.DisplayMember = "ADConfigText";
                checkedComboBoxEdit.ValueMember = "ADConfigKeyValue";
                checkedComboBoxEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                checkedComboBoxEdit.NullText = string.Empty;
                //checkedComboBoxEdit.EditValueChanged += new EventHandler(ReposItemCheckedCombo_EditValueChanged);

                column.ColumnEdit = checkedComboBoxEdit;
            }
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            //gridView.FocusedRowChanged += GridView_FocusedRowChanged1;
            return gridView;
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectedInsurranceConditions();
            }
        }
    }
}
