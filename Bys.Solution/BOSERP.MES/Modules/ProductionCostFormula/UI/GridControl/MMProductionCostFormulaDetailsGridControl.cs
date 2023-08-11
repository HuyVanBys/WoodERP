using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductionCostFormula
{
    public class MMProductionCostFormulaDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductionCostFormulaEntities entity = (ProductionCostFormulaEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MMProductionCostFormulaDetailsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;
                if (column.FieldName == "MMProductionCostFormulaDetailProductCollectType"
                || column.FieldName == "MMProductionCostFormulaDetailProjectCollectType"
                || column.FieldName == "MMProductionCostFormulaDetailProductGroupCollectType"
                || column.FieldName == "MMProductionCostFormulaDetailSaleOrderCollectType"
                || column.FieldName == "MMProductionCostFormulaDetailDepartmentCollectType"
                || column.FieldName == "MMProductionCostFormulaDetailBatchProductCollectType"
                || column.FieldName == "MMProductionCostFormulaDetailOperationCollectType")
                {
                    column.ColumnEdit = CreateRepositoryCollectType();
                }
                //else if (column.FieldName == "MMProductionCostFormulaDetailHasEndingInProgress"
                //|| column.FieldName == "MMProductionCostInProgressCalType"
                ////|| column.FieldName == "FK_ACDebitAccountID"
                ////|| column.FieldName == "FK_ACCreditAccountID"
                //|| column.FieldName == "MMProductionCostFormulaDetailIsDeduction"
                //|| column.FieldName == "FK_ACInProgressAccountID")
                //{
                //    column.OptionsColumn.AllowEdit = false;
                //}
                else if (column.FieldName == "FK_MMProductionCostFactorID"
                || column.FieldName == "FK_MMRefProductionCostFactorID")
                {
                    column.ColumnEdit = CreateRepositoryFactor();
                }
            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value != null)
            {
                if (e.Column.FieldName == "MMProductionCostFormulaDetailProductCollectType"
                || e.Column.FieldName == "MMProductionCostFormulaDetailProjectCollectType"
                || e.Column.FieldName == "MMProductionCostFormulaDetailProductGroupCollectType"
                || e.Column.FieldName == "MMProductionCostFormulaDetailSaleOrderCollectType"
                || e.Column.FieldName == "MMProductionCostFormulaDetailDepartmentCollectType"
                || e.Column.FieldName == "MMProductionCostFormulaDetailBatchProductCollectType"
                || e.Column.FieldName == "MMProductionCostFormulaDetailOperationCollectType")
                {
                    if (e.Value != null)
                        e.DisplayText = ADConfigValueUtility.GetConfigTextByGroupAndValue(ConfigValueGroup.ProductionCostCollectType, e.Value.ToString());
                }
                else if (e.Column.FieldName == "FK_MMProductionCostFactorID"
                || e.Column.FieldName == "FK_MMRefProductionCostFactorID")
                {
                    int factorID = 0;
                    if (int.TryParse(e.Value.ToString(), out factorID))
                    {
                        e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMProductionCostFactors", "MMProductionCostFactorID", factorID, "MMProductionCostFactorName");
                    }
                }
            }
        }

        private RepositoryItemLookUpEdit CreateRepositoryCollectType()
        {
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
            repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Cách tập hợp"));
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditProductOrigin_QueryPopUp);
            return repositoryItemLookUpEdit;

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

        public void repositoryItemLookUpEditProductOrigin_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup(ConfigValueGroup.ProductionCostCollectType.ToString());
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                List<ADConfigValuesInfo> configValueList = new List<ADConfigValuesInfo>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    configValueList.Add(objConfigValuesInfo);
                }
                configValueList.Insert(0, new ADConfigValuesInfo());
                lookUpEdit.Properties.DataSource = configValueList;
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ProductionCostFormulaModule)Screen.Module).DeleteItemFromProductionCostFormulaDetailsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)MainView;
            ((ProductionCostFormulaModule)Screen.Module).ChangeToEdit();
            MMProductionCostFormulaDetailsInfo item = (MMProductionCostFormulaDetailsInfo)gridView.GetFocusedRow();
            if (item != null)
            {
                if (e.Column.FieldName == "FK_MMProductionCostFactorID")
                {
                    ((ProductionCostFormulaModule)Screen.Module).ChangeDetailFactor(item);
                }
            }
        }

    }
}
