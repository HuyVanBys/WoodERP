using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.EndingInProgressStatistic
{
    public class MMInProgressStatisticDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            EndingInProgressStatisticEntities entity = (EndingInProgressStatisticEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MMInProgressStatisticDetailsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ACOffsetAccountID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ACAccounts", "ACAccountID", int.Parse(e.Value.ToString()), "ACAccountNo");
                }
            }
            else if (e.Column.FieldName == "FK_ACAccountID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ACAccounts", "ACAccountID", int.Parse(e.Value.ToString()), "ACAccountNo");
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = true;

            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            if (gridView.Columns["FK_ICProductID"] != null)
            {
                GridColumn column = gridView.Columns["FK_ICProductID"];
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = (object)BOSApp.CurrentProductList;
                repositoryItemLookUpEdit.ValueMember = "ICProductID";
                repositoryItemLookUpEdit.DisplayMember = "ICProductNo";
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã sản phẩm"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên sản phẩm"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả"));
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemProductLookupEdit_QueryPopUp);
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

            MMProductionCostFactorsController objProductionCostFactorsController = new MMProductionCostFactorsController();
            DataSet dsProductionCostFactors = objProductionCostFactorsController.GetAllObjects();
            if (gridView.Columns["FK_MMProductionCostFactorID"] != null)
            {
                GridColumn column = gridView.Columns["FK_MMProductionCostFactorID"];
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = (object)dsProductionCostFactors.Tables[0];
                repositoryItemLookUpEdit.ValueMember = "MMProductionCostFactorID";
                repositoryItemLookUpEdit.DisplayMember = "MMProductionCostFactorName";
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMProductionCostFactorName", "Tên yếu tố"));
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemProductionCostFactorLookupEdit_QueryPopUp);
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

            MMOperationsController objOperationsController = new MMOperationsController();
            DataSet dsOperations = objOperationsController.GetAllObjects();
            if (gridView.Columns["FK_MMOperationID"] != null)
            {
                GridColumn column = gridView.Columns["FK_MMOperationID"];
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = (object)dsOperations.Tables[0];
                repositoryItemLookUpEdit.ValueMember = "MMOperationID";
                repositoryItemLookUpEdit.DisplayMember = "MMOperationName";
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationName", "Tên Công đoạn"));
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemOperationLookupEdit_QueryPopUp);
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

        }

        public void LoadGridViewByProgressClassifyType(string productionCostInProgressClassifyType)
        {
            GridView gridView = (GridView)MainView;
            bool allowEdit = false;

            if (productionCostInProgressClassifyType == ProductionCostInProgressClassifyType.Dodangnguyenlieusudung.ToString())
            {
                gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                allowEdit = false;
                if (gridView.Columns["MMInProgressStatisticDetailPercent"] != null)
                {
                    gridView.Columns["MMInProgressStatisticDetailPercent"].Visible = false;
                    gridView.Columns["MMInProgressStatisticDetailPercent"].OptionsColumn.AllowEdit = false;
                }
                if (gridView.Columns["MMInProgressStatisticDetailReceiptSerialNo"] != null)
                {
                    gridView.Columns["MMInProgressStatisticDetailReceiptSerialNo"].OptionsColumn.AllowEdit = false;
                    gridView.Columns["MMInProgressStatisticDetailReceiptSerialNo"].Visible = true;
                }
                if (gridView.Columns["MMInProgressStatisticDetailUnitCost"] != null)
                {
                    gridView.Columns["MMInProgressStatisticDetailUnitCost"].OptionsColumn.AllowEdit = false;
                    gridView.Columns["MMInProgressStatisticDetailUnitCost"].Visible = true;
                }
            }
            else
            {
                gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                allowEdit = true;
                if (gridView.Columns["MMInProgressStatisticDetailPercent"] != null)
                {
                    gridView.Columns["MMInProgressStatisticDetailPercent"].Visible = true;
                    gridView.Columns["MMInProgressStatisticDetailPercent"].OptionsColumn.AllowEdit = true;
                }
                if (gridView.Columns["MMInProgressStatisticDetailUnitCost"] != null)
                {
                    gridView.Columns["MMInProgressStatisticDetailUnitCost"].OptionsColumn.AllowEdit = false;
                    gridView.Columns["MMInProgressStatisticDetailUnitCost"].Visible = false;
                }
                if (gridView.Columns["MMInProgressStatisticDetailReceiptSerialNo"] != null)
                {
                    gridView.Columns["MMInProgressStatisticDetailReceiptSerialNo"].OptionsColumn.AllowEdit = true;
                    gridView.Columns["MMInProgressStatisticDetailReceiptSerialNo"].Visible = true;
                }
            }
            if (gridView.Columns["FK_ICProductID"] != null)
            {
                gridView.Columns["FK_ICProductID"].OptionsColumn.AllowEdit = allowEdit;
            }
            if (gridView.Columns["FK_ARSaleOrderID"] != null)
            {
                gridView.Columns["FK_ARSaleOrderID"].OptionsColumn.AllowEdit = allowEdit;
            }
            if (gridView.Columns["FK_HRDepartmentID"] != null)
            {
                gridView.Columns["FK_HRDepartmentID"].OptionsColumn.AllowEdit = allowEdit;
            }
            if (gridView.Columns["FK_ICProductGroupID"] != null)
            {
                gridView.Columns["FK_ICProductGroupID"].OptionsColumn.AllowEdit = allowEdit;
            }
            if (gridView.Columns["FK_PMProjectID"] != null)
            {
                gridView.Columns["FK_PMProjectID"].OptionsColumn.AllowEdit = allowEdit;
            }
            if (gridView.Columns["MMInProgressStatisticDetailProductName"] != null)
            {
                gridView.Columns["MMInProgressStatisticDetailProductName"].OptionsColumn.AllowEdit = allowEdit;
            }
            if (gridView.Columns["FK_MMOperationID"] != null)
            {
                gridView.Columns["FK_MMOperationID"].OptionsColumn.AllowEdit = allowEdit;
            }
            if (gridView.Columns["FK_MMBatchProductID"] != null)
            {
                gridView.Columns["FK_MMBatchProductID"].OptionsColumn.AllowEdit = allowEdit;
            }
            if (gridView.Columns["MMInProgressStatisticDetailQty"] != null)
            {
                gridView.Columns["MMInProgressStatisticDetailQty"].OptionsColumn.AllowEdit = allowEdit;
            }
            if (gridView.Columns["FK_MMProductionCostFactorID"] != null)
            {
                gridView.Columns["FK_MMProductionCostFactorID"].OptionsColumn.AllowEdit = allowEdit;
            }
            if (gridView.Columns["MMInProgressStatisticDetailValue"] != null)
            {
                gridView.Columns["MMInProgressStatisticDetailValue"].OptionsColumn.AllowEdit = allowEdit;
            }
            if (gridView.Columns["FK_ICProductForBatchID"] != null)
            {
                gridView.Columns["FK_ICProductForBatchID"].OptionsColumn.AllowEdit = false;
            }
            if (gridView.Columns["FK_ACOffsetAccountID"] != null)
            {
                gridView.Columns["FK_ACOffsetAccountID"].OptionsColumn.AllowEdit = false;
            }

        }

        public void repositoryItemOperationLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            EndingInProgressStatisticEntities entity = (EndingInProgressStatisticEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            MMInProgressStatisticsInfo mainObject = entity.MainObject as MMInProgressStatisticsInfo;
            if (mainObject.FK_MMProductionCostFormulaID == 0)
            {
                MessageBox.Show("Vui lòng chọn Công thức tính giá thành!", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lookUpEdit.Properties.DataSource = new List<MMOperationsInfo>();
                return;
            }
            MMOperationsController objOperationsController = new MMOperationsController();
            List<MMOperationsInfo> operations = objOperationsController.GetOperationByProductionCostFormulaID(mainObject.FK_MMProductionCostFormulaID);
            if (operations != null)
            {
                lookUpEdit.Properties.DataSource = operations;
            }
            else
                lookUpEdit.Properties.DataSource = new List<MMOperationsInfo>();
        }

        public void repositoryItemProductLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            EndingInProgressStatisticEntities entity = (EndingInProgressStatisticEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            MMInProgressStatisticsInfo mainObject = entity.MainObject as MMInProgressStatisticsInfo;
            if (mainObject.FK_MMProductionCostFormulaID == 0)
            {
                MessageBox.Show("Vui lòng chọn Công thức tính giá thành!", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lookUpEdit.Properties.DataSource = new List<ICProductsInfo>();
                return;
            }
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> productList = objProductsController.GetProductByProductionCostFormulaID(mainObject.FK_MMProductionCostFormulaID);
            if (productList != null)
            {
                lookUpEdit.Properties.DataSource = productList;
            }
            else
                lookUpEdit.Properties.DataSource = new List<ICProductsInfo>();
        }

        public void repositoryItemProductionCostFactorLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            MMProductionCostFactorsController objProductionCostFactorsController = new MMProductionCostFactorsController();
            DataSet dsProductionCostFactors = objProductionCostFactorsController.GetAllObjects();
            List<MMProductionCostFactorsInfo> productionCostFactors = (List<MMProductionCostFactorsInfo>)objProductionCostFactorsController.GetListFromDataSet(dsProductionCostFactors);
            if (productionCostFactors != null)
            {
                lookUpEdit.Properties.DataSource = productionCostFactors.Where(o => o.MMProductionCostFactorHasEndingInProgress == true).ToList();
            }
            else
                lookUpEdit.Properties.DataSource = new List<MMProductionCostFactorsInfo>();
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            EndingInProgressStatisticEntities entity = (EndingInProgressStatisticEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            GridView gridView = MainView as GridView;
            MMInProgressStatisticDetailsInfo item = null;
            if (gridView.FocusedRowHandle >= 0)
                item = (MMInProgressStatisticDetailsInfo)entity.MMInProgressStatisticDetailsList[gridView.FocusedRowHandle];
            else
                item = (MMInProgressStatisticDetailsInfo)gridView.GetRow(e.RowHandle);
            if (item != null)
            {
                if (e.Column.FieldName == "FK_ICProductID")
                {
                    ICProductsController objProductsController = new ICProductsController();
                    ICProductsInfo objProductsInfo = objProductsController.GetObjectByID(item.FK_ICProductID) as ICProductsInfo;
                    if (objProductsInfo != null)
                    {
                        item.MMInProgressStatisticDetailProductNo = objProductsInfo.ICProductNo;
                        item.MMInProgressStatisticDetailProductName = objProductsInfo.ICProductName;
                    }
                }
            }

        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((EndingInProgressStatisticModule)Screen.Module).DeleteItemFromInProgressStatisticDetailsList();
            }
        }

    }
}
