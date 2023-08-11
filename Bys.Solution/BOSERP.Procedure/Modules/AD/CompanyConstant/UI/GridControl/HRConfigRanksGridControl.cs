using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BOSERP.Modules.CompanyConstant
{
    public class HRConfigRanksGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRConfigRanksList;
            this.DataSource = bds;
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            GridColumn column = gridView.Columns["HRConfigRankName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRConfigRankNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRConfigRankDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRConfigRankWorkingSalary"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRConfigRankSocialIns"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["IsUpdate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_HRConfigScaleID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "HRConfigScaleName";
                repositoryItemLookUpEdit.ValueMember = "HRConfigScaleID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HRConfigScaleName", "Ngạch"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpConfigScale_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            return gridView;
        }

        void repositoryItemLookUpConfigScale_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            GridView gridView = (GridView)MainView;
            HRConfigScalesController objConfigScalesController = new HRConfigScalesController();
            List<HRConfigScalesInfo> payRollConfigsList = (List<HRConfigScalesInfo>)objConfigScalesController.GetListFromDataSet(objConfigScalesController.GetAllObjects());
            if (payRollConfigsList != null && payRollConfigsList.Count > 0)
            {
                HRConfigScalesInfo objConfigScalesInfo = new HRConfigScalesInfo();
                payRollConfigsList.Insert(0, objConfigScalesInfo);
                lookUpEdit.Properties.DataSource = payRollConfigsList;
                lookUpEdit.Properties.DisplayMember = "HRConfigScaleName";
                lookUpEdit.Properties.ValueMember = "HRConfigScaleID";
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_HRConfigScaleID")
            {
                if (e.Value != null)
                {
                    int configScaleID = int.Parse(e.Value.ToString());
                    HRConfigScalesController objConfigScalesController = new HRConfigScalesController();
                    HRConfigScalesInfo objConfigScalesInfo = (HRConfigScalesInfo)objConfigScalesController.GetObjectByID(configScaleID);
                    if (objConfigScalesInfo != null)
                    {
                        e.DisplayText = objConfigScalesInfo.HRConfigScaleName;
                    }
                }
            }
        }

        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectConfigRank();
            }
        }
        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
    }
}
