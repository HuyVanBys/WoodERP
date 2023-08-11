using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class ADInsurrancePapersGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.InsurrancePapersList;
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
            GridColumn column = gridView.Columns["ADInsurrancePaperNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ADInsurrancePaperName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ADInsurrancePaperSocialID"];
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
                ((CompanyConstantModule)Screen.Module).RemoveSelectedInsurrancePapers();
            }
        }
    }
}
