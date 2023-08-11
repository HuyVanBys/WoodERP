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
    public partial class MMProductionCostFactorAllocationRatesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MMProductionCostFactorAllocationRatesList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
            }


            GridColumn column = gridView.Columns["FK_MMProductionCostFactorID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = CreateRepositoryFactor();
            }

            return gridView;
        }

        private RepositoryItemLookUpEdit CreateRepositoryFactor()
        {
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DisplayMember = "MMProductionCostFactorName";
            repositoryItemLookUpEdit.ValueMember = "MMProductionCostFactorID";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionCostFactorNo", "Mã yếu tố"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionCostFactorName", "Tên yếu tố"));
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEdit_QueryPopUp);
            return repositoryItemLookUpEdit;

        }

        void repositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            MMProductionCostFactorsController factorController = new MMProductionCostFactorsController();
            List<MMProductionCostFactorsInfo> factorList = new List<MMProductionCostFactorsInfo>();
            factorList.Add(new MMProductionCostFactorsInfo());
            List<MMProductionCostFactorsInfo> factorAllList = factorController.GetAllAliveFactor();
            if (factorAllList != null && factorAllList.Count > 0)
            {
                factorList.AddRange(factorAllList);
            }

            lookUpEdit.Properties.DataSource = factorList;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_MMProductionCostFactorID")
            {
                if (e.Value != null)
                {
                    int factorID = 0;
                    if (int.TryParse(e.Value.ToString(), out factorID))
                    {
                        MMProductionCostFactorsController factorController = new MMProductionCostFactorsController();
                        MMProductionCostFactorsInfo factor = (MMProductionCostFactorsInfo)factorController.GetObjectByID(factorID);
                        if (factor != null)
                        {
                            e.DisplayText = factor.MMProductionCostFactorName;
                        }
                        else
                        {
                            e.DisplayText = string.Empty;
                        }
                    }
                }
                else
                {
                    e.DisplayText = string.Empty;
                }
            }

        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((CompanyConstantModule)Screen.Module).RemoveSelectedProductionCostFactorAllocationRate();
                }
            }
        }
    }
}
