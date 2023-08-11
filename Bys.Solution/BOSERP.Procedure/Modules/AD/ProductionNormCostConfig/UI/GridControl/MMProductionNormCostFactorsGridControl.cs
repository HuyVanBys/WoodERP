using BOSCommon;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;
using Localization;
using System.ComponentModel;

namespace BOSERP.Modules.ProductionNormCostConfig
{
    public partial class MMProductionNormCostFactorsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductionNormCostConfigEntities entity = (ProductionNormCostConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MMProductionNormCostFactorsList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
                col.OptionsColumn.AllowEdit = true;

            GridColumn column = new GridColumn();
            #region MMProductionNormCostFactorProductGroup
            column = gridView.Columns["MMProductionNormCostFactorProductGroup"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.VisibleIndex = 2;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Nhóm NVL"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryProductGroup_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            #endregion
            #region MMProductionNormCostFactorSourceData
            column = gridView.Columns["MMProductionNormCostFactorSourceData"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.VisibleIndex = 3;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Nguồn"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositorySourceData_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            #endregion

            #region MMProductionNormCostFactorCalculator
            column = gridView.Columns["MMProductionNormCostFactorCalculator"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.VisibleIndex = 4;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Cách tính"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryFactorCalculator_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            #endregion

            #region MMProductionNormCostFactorDateData
            column = gridView.Columns["MMProductionNormCostFactorDateData"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.VisibleIndex = 5;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Kỳ lấy dữ liệu"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryDateData_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            #endregion

            

            #region MMProductionNormCostFactorAllocationType
            column = gridView.Columns["MMProductionNormCostFactorAllocationType"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.VisibleIndex = 6;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ADConfigText";
                repositoryItemLookUpEdit.ValueMember = "ADConfigKeyValue";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Phân bổ theo"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryFactorAllocationType_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            #endregion

            #region FK_ACDebitAccountID
            column = gridView.Columns["FK_ACDebitAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.VisibleIndex = 7;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACAccountNo";
                repositoryItemLookUpEdit.ValueMember = "ACAccountID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.DataSource = (new ACAccountsController()).GetAllAccountList();
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountNo", CommonLocalizedResources.ACAccountNo));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountName", CommonLocalizedResources.ACAccountName));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemAccountLookUpEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            #endregion

            #region FK_ACCreditAccountID
            column = gridView.Columns["FK_ACCreditAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.VisibleIndex = 8;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACAccountNo";
                repositoryItemLookUpEdit.ValueMember = "ACAccountID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.DataSource = (new ACAccountsController()).GetAllAccountList();
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountNo", CommonLocalizedResources.ACAccountNo));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountName", CommonLocalizedResources.ACAccountName));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemAccountLookUpEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            #endregion

            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void repositorySourceData_QueryPopUp(object sender, CancelEventArgs e)
        {
            //Nguồn lấy dữ liệu
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            List<ADConfigValuesInfo> ConfigValuesList = ((ProductionNormCostConfigModule)Screen.Module).GetConfigDatasource("ProductionNormCostFactorSourceData");
            lookUpEdit.Properties.DataSource = ConfigValuesList;
            lookUpEdit.Properties.DisplayMember = "ADConfigText";
            lookUpEdit.Properties.ValueMember = "ADConfigKeyValue";
        }

        private void repositoryFactorCalculator_QueryPopUp(object sender, CancelEventArgs e) 
        {
            //Cách tính (chỉ chọn được khi Nguồn lấy dữ liệu là Định mức)
            ProductionNormCostConfigEntities entity = (ProductionNormCostConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
            if (entity.MMProductionNormCostFactorsList.CurrentIndex < 0)
            {
                ConfigValuesList = ((ProductionNormCostConfigModule)Screen.Module).GetConfigDatasource("ProductionNormCostFactorCalculator");
            }
            else
            {
                MMProductionNormCostFactorsInfo item = entity.MMProductionNormCostFactorsList[entity.MMProductionNormCostFactorsList.CurrentIndex];
                if (item.MMProductionNormCostFactorSourceData == ProductionNormCostFactorSourceData.Norm.ToString())
                {
                    ConfigValuesList = ((ProductionNormCostConfigModule)Screen.Module).GetConfigDatasource("ProductionNormCostFactorCalculator");
                }   
            }
            lookUpEdit.Properties.DataSource = ConfigValuesList;
            lookUpEdit.Properties.DisplayMember = "ADConfigText";
            lookUpEdit.Properties.ValueMember = "ADConfigKeyValue";
        }

        private void repositoryProductGroup_QueryPopUp(object sender, CancelEventArgs e)
        {
            //Nhóm NVL (chỉ chọn được khi Nguồn lấy dữ liệu là Định mức)
            ProductionNormCostConfigEntities entity = (ProductionNormCostConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
            if (entity.MMProductionNormCostFactorsList.CurrentIndex < 0)
            {
                ConfigValuesList = ((ProductionNormCostConfigModule)Screen.Module).GetConfigDatasource("ProductionNormCostFactorProductGroup");
            }
            else
            {
                MMProductionNormCostFactorsInfo item = entity.MMProductionNormCostFactorsList[entity.MMProductionNormCostFactorsList.CurrentIndex];
                if (item.MMProductionNormCostFactorSourceData == ProductionNormCostFactorSourceData.Norm.ToString())
                {
                    ConfigValuesList = ((ProductionNormCostConfigModule)Screen.Module).GetConfigDatasource("ProductionNormCostFactorProductGroup");
                }
            }

            lookUpEdit.Properties.DataSource = ConfigValuesList;
            lookUpEdit.Properties.DisplayMember = "ADConfigText";
            lookUpEdit.Properties.ValueMember = "ADConfigKeyValue";
        }

        private void repositoryFactorAllocationType_QueryPopUp(object sender, CancelEventArgs e)
        {
            //Phân bổ theo (chỉ chọn được khi Nguồn lấy dữ liệu là Sổ cái)
            ProductionNormCostConfigEntities entity = (ProductionNormCostConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
            if (entity.MMProductionNormCostFactorsList.CurrentIndex < 0)
            {
                ConfigValuesList = ((ProductionNormCostConfigModule)Screen.Module).GetConfigDatasource("ProductionNormCostFactorAllocationType");
            }
            else
            {
                MMProductionNormCostFactorsInfo item = entity.MMProductionNormCostFactorsList[entity.MMProductionNormCostFactorsList.CurrentIndex];
                if (item.MMProductionNormCostFactorSourceData == ProductionNormCostFactorSourceData.Ledger.ToString())
                {
                    ConfigValuesList = ((ProductionNormCostConfigModule)Screen.Module).GetConfigDatasource("ProductionNormCostFactorAllocationType");
                }   
            }
            lookUpEdit.Properties.DataSource = ConfigValuesList;
            lookUpEdit.Properties.DisplayMember = "ADConfigText";
            lookUpEdit.Properties.ValueMember = "ADConfigKeyValue";
        }

        private void repositoryDateData_QueryPopUp(object sender, CancelEventArgs e)
        {
            //Kỳ lấy dữ liệu (chỉ chọn được khi Nguồn lấy dữ liệu là Sổ cái)
            ProductionNormCostConfigEntities entity = (ProductionNormCostConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ADConfigValuesInfo> ConfigValuesList = new List<ADConfigValuesInfo>();
            if (entity.MMProductionNormCostFactorsList.CurrentIndex < 0)
            {
                ConfigValuesList = ((ProductionNormCostConfigModule)Screen.Module).GetConfigDatasource("ProductionNormCostFactorDateData");
            }
            else
            {
                MMProductionNormCostFactorsInfo item = entity.MMProductionNormCostFactorsList[entity.MMProductionNormCostFactorsList.CurrentIndex];
                if (item.MMProductionNormCostFactorSourceData == ProductionNormCostFactorSourceData.Ledger.ToString())
                {
                    ConfigValuesList = ((ProductionNormCostConfigModule)Screen.Module).GetConfigDatasource("ProductionNormCostFactorDateData");
                }
            }
            lookUpEdit.Properties.DataSource = ConfigValuesList;
            lookUpEdit.Properties.DisplayMember = "ADConfigText";
            lookUpEdit.Properties.ValueMember = "ADConfigKeyValue";
        }
        
        private void repositoryItemAccountLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            //Tk nợ/ Tk có (chỉ chọn được khi Nguồn lấy dữ liệu là Sổ cái)
            ProductionNormCostConfigEntities entity = (ProductionNormCostConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACAccountsController objAccountsController = new ACAccountsController();
            List<ACAccountsInfo> accountList = new List<ACAccountsInfo>();
            if (entity.MMProductionNormCostFactorsList.CurrentIndex < 0)
            {
                accountList = objAccountsController.GetAllAccountList();
            }
            else
            {
                MMProductionNormCostFactorsInfo item = entity.MMProductionNormCostFactorsList[entity.MMProductionNormCostFactorsList.CurrentIndex];
                if (item.MMProductionNormCostFactorSourceData == ProductionNormCostFactorSourceData.Ledger.ToString())
                {
                    accountList = objAccountsController.GetAllAccountList();
                }
            }
            lookUpEdit.Properties.DataSource = accountList;
            lookUpEdit.Properties.DisplayMember = "ACAccountNo";
            lookUpEdit.Properties.ValueMember = "ACAccountID";
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((ProductionNormCostConfigModule)Screen.Module).RemoveSelectedProductionNormCostFactorsList();
                }
            }
        }
        
        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ACAccountsController objAccountsController = new ACAccountsController();
            //if (e.Column.FieldName == "FK_ACCreditAccountID" || e.Column.FieldName == "FK_ACDebitAccountID")
            //{
            //    if (e.Value != null)
            //    {
            //        ACAccountsInfo objAccountsInfo = new ACAccountsInfo();
            //        objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByID(int.Parse( e.Value.ToString()));
            //        if (objAccountsInfo != null)
            //        {
            //            e.DisplayText = objAccountsInfo.ACAccountNo;
            //        }
            //    }
            //}

            if (e.Column.FieldName == "FK_MMProductionNormFactorID")
            {
                if (e.Value != null)
                {
                    ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("ProductionNormCostFactorSourceData", e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = ((ProductionNormCostConfigModule)Screen.Module).GetFactorDisplayText(int.Parse(e.Value.ToString()));
                    }
                }
            }
            if (e.Column.FieldName == "MMProductionNormCostFactorSourceData")
            {
                if (e.Value != null)
                {
                    ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("ProductionNormCostFactorSourceData", e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                }
            }
            if (e.Column.FieldName == "MMProductionNormCostFactorProductGroup")
            {
                if (e.Value != null)
                {
                    ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("ProductionNormCostFactorProductGroup", e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                }
            }

            if (e.Column.FieldName == "MMProductionNormCostFactorPriceType")
            {
                if (e.Value != null)
                {
                    ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("ProductionNormCostFactorPriceType", e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                }
            }
            if (e.Column.FieldName == "MMProductionNormCostFactorDateData")
            {
                if (e.Value != null)
                {
                    ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("ProductionNormCostFactorDateData", e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                }
            }
            if (e.Column.FieldName == "MMProductionNormCostFactorCalculator")
            {
                if (e.Value != null)
                {
                    ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("ProductionNormCostFactorCalculator", e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                }
            }
            if (e.Column.FieldName == "MMProductionNormCostFactorAllocationType")
            {
                if (e.Value != null)
                {
                    ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("ProductionNormCostFactorAllocationType", e.Value.ToString());
                    if (objConfigValuesInfo != null)
                    {
                        e.DisplayText = objConfigValuesInfo.ADConfigText;
                    }
                }
            }
            //if (e.Column.FieldName == "MMPriceType")
            //{
            //    if (e.Value != null)
            //    {
            //        ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            //        objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("PriceType", e.Value.ToString());
            //        if (objConfigValuesInfo != null)
            //        {
            //            e.DisplayText = objConfigValuesInfo.ADConfigText;
            //        }
            //    }
            //}
        }

        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)MainView;
            MMProductionNormCostFactorsInfo objProductionNormCostFactorsInfo = (MMProductionNormCostFactorsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (objProductionNormCostFactorsInfo != null)
            {
                if (gridView.FocusedColumn.FieldName == "MMProductionNormCostFactorSourceData")
                {
                    if(objProductionNormCostFactorsInfo.MMProductionNormCostFactorSourceData == ProductionNormCostFactorSourceData.Ledger.ToString())
                    {
                        objProductionNormCostFactorsInfo.MMProductionNormCostFactorCalculator = string.Empty;
                        objProductionNormCostFactorsInfo.MMProductionNormCostFactorProductGroup = string.Empty;
                    }
                    else
                    {
                        objProductionNormCostFactorsInfo.FK_ACCreditAccountID = 0;
                        objProductionNormCostFactorsInfo.FK_ACDebitAccountID = 0;
                        objProductionNormCostFactorsInfo.MMProductionNormCostFactorDateData = string.Empty;
                        objProductionNormCostFactorsInfo.MMProductionNormCostFactorAllocationType = string.Empty;
                    }    
                }
            }
        }
    }
}
