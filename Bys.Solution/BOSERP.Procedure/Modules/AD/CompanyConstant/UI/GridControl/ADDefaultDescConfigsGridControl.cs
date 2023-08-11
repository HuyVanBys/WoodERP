using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class ADDefaultDescConfigsGridControl : BOSGridControl
    {
        private DataSet ListModule { get; set; } 

        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DefaultDescConfigList;
            this.DataSource = bds;
            this.ListModule = (new STModulesController()).GetAllModuleForDefaultDescConfig();
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle < 0)
            {
                SendKeys.Send("{TAB}");
                return;
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView.RowHeight = 120;
            gridView.OptionsFilter.AllowFilterEditor = false;
            gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            gridView.OptionsView.ShowAutoFilterRow = false;
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn newColumn = new GridColumn();
            newColumn.Caption = "Module";
            newColumn.FieldName = "FK_STModuleID";
            newColumn.OptionsColumn.AllowEdit = true;
            RepositoryItemLookUpEdit moduleLookUpEdit = new RepositoryItemLookUpEdit();
            if(ListModule == null)
            {
                ListModule = (new STModulesController()).GetAllModuleForDefaultDescConfig();
            }    
            moduleLookUpEdit.DataSource = ListModule.Tables[0];
            moduleLookUpEdit.ValueMember = "STModuleID";
            moduleLookUpEdit.DisplayMember = "STModuleDescription";
            moduleLookUpEdit.ShowHeader = false;
            moduleLookUpEdit.TextEditStyle = TextEditStyles.Standard;
            moduleLookUpEdit.Columns.Add(new LookUpColumnInfo("STModuleDescription", "Tên Module"));
            moduleLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemModuleLookupEdit_QueryPopUp);
            newColumn.ColumnEdit = moduleLookUpEdit;
            newColumn.Visible = true;
            newColumn.VisibleIndex = 0;
            gridView.Columns.Add(newColumn);

            newColumn = new GridColumn();
            newColumn.Caption = "Hình thức mua/bán hàng";
            newColumn.FieldName = "ADSaleOrderSaleType";
            newColumn.OptionsColumn.AllowEdit = true;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup("SaleOrderSaleType");
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DataSource = ds.Tables[0];
            repositoryItemLookUpEdit.DisplayMember = "Text";
            repositoryItemLookUpEdit.ValueMember = "Value";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("Text", "Hình thức"));
            repositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemSaleOrderSaleTypeLookupEdit_QueryPopUp);
            newColumn.ColumnEdit = repositoryItemLookUpEdit;
            newColumn.Visible = true;
            newColumn.VisibleIndex = 1;
            gridView.Columns.Add(newColumn);

            newColumn = new GridColumn();
            newColumn.Caption = "Ghi chú module";
            newColumn.FieldName = "ADDefaultDescConfigDescValue";
            newColumn.OptionsColumn.AllowEdit = true;            
            RepositoryItemRichTextEdit textEdit = new RepositoryItemRichTextEdit();
            textEdit.OptionsVerticalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            textEdit.OptionsHorizontalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            textEdit.AllowFocused = true;
            textEdit.Encoding = System.Text.Encoding.Unicode;
            newColumn.ColumnEdit = textEdit;
            newColumn.Visible = true;
            newColumn.VisibleIndex = 2;
            gridView.Columns.Add(newColumn);
        }

        protected void repositoryItemModuleLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            if (ListModule == null)
            {
                ListModule = (new STModulesController()).GetAllModuleForDefaultDescConfig();
            }
            lke.Properties.DataSource = ListModule.Tables[0];
        }

        protected void repositoryItemSaleOrderSaleTypeLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            lke.Properties.DataSource = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup("SaleOrderSaleType").Tables[0];
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveDefaultDescConfigList();
            }
        }
    }
}
