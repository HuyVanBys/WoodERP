using BOSCommon;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.AccountingFormula
{
    public class GEAccountingFormulaItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {

            AccountingFormulaEntities entity = (AccountingFormulaEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AccountingFormulaItemList;
            this.DataSource = bds;
        }
        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            AccountingFormulaEntities entity = (AccountingFormulaEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            GEAccountingFormulasInfo mainObject = (GEAccountingFormulasInfo)entity.MainObject;

        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((AccountingFormulaModule)Screen.Module).DeleteItemFromAccountingFormulaItemList();
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            //gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        public void LoadGridViewForType(string type)
        {
            GridView gridView = (GridView)MainView;
            AccountingFormulaEntities entity = (AccountingFormulaEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            GEAccountingFormulasInfo mainObject = (GEAccountingFormulasInfo)entity.MainObject;
            if (gridView.Columns["GEAccountingFormulaItemNumber"] != null)
            {
                gridView.Columns["GEAccountingFormulaItemNumber"].OptionsColumn.AllowEdit = true;
                gridView.Columns["GEAccountingFormulaItemNumber"].Visible = true;
            }
            if (gridView.Columns["GEAccountingFormulaItemShowPrint"] != null)
            {
                gridView.Columns["GEAccountingFormulaItemShowPrint"].OptionsColumn.AllowEdit = true;
                gridView.Columns["GEAccountingFormulaItemShowPrint"].Visible = true;
            }
            if (gridView.Columns["GEAccountingFormulaItemBold"] != null)
            {
                gridView.Columns["GEAccountingFormulaItemBold"].OptionsColumn.AllowEdit = true;
                gridView.Columns["GEAccountingFormulaItemBold"].Visible = true;
            }
            if (gridView.Columns["GEAccountingFormulaItemCategory"] != null)
            {
                gridView.Columns["GEAccountingFormulaItemCategory"].OptionsColumn.AllowEdit = true;
                gridView.Columns["GEAccountingFormulaItemCategory"].Visible = true;
            }
            if (gridView.Columns["GEAccountingFormulaItemCategoryEnglish"] != null)
            {
                gridView.Columns["GEAccountingFormulaItemCategoryEnglish"].OptionsColumn.AllowEdit = true;
                gridView.Columns["GEAccountingFormulaItemCategoryEnglish"].Visible = true;
            }
            if (gridView.Columns["GEAccountingFormulaItemAccountNo"] != null)
            {
                gridView.Columns["GEAccountingFormulaItemAccountNo"].OptionsColumn.AllowEdit = true;
                gridView.Columns["GEAccountingFormulaItemAccountNo"].Visible = true;
            }
            //if (gridView.Columns["GEAccountingFormulaItemType"] != null)
            //{
            //    gridView.Columns["GEAccountingFormulaItemType"].OptionsColumn.AllowEdit = true;
            //    gridView.Columns["GEAccountingFormulaItemType"].Visible = true;
            //}
            if (gridView.Columns["GEAccountingFormulaItemDemonstration"] != null)
            {
                gridView.Columns["GEAccountingFormulaItemDemonstration"].OptionsColumn.AllowEdit = true;
                gridView.Columns["GEAccountingFormulaItemDemonstration"].Visible = true;
            }
            if (gridView.Columns["GEAccountingFormulaItemFormula"] != null)
            {
                gridView.Columns["GEAccountingFormulaItemFormula"].OptionsColumn.AllowEdit = true;
                gridView.Columns["GEAccountingFormulaItemFormula"].Visible = true;
            }
            if (gridView.Columns["GEAccountingFormulaItemSpot"] != null)
            {
                gridView.Columns["GEAccountingFormulaItemSpot"].OptionsColumn.AllowEdit = true;
                gridView.Columns["GEAccountingFormulaItemSpot"].Visible = true;
            }
            if (type == AccountingFormulaType.BCDKT.ToString())
            {
                if (gridView.Columns["GEAccountingFormulaItemAccount"] != null)
                {
                    gridView.Columns["GEAccountingFormulaItemAccount"].OptionsColumn.AllowEdit = true;
                    gridView.Columns["GEAccountingFormulaItemAccount"].Visible = true;
                }
                if (gridView.Columns["GEAccountingFormulaItemAccountDebit"] != null)
                {
                    gridView.Columns["GEAccountingFormulaItemAccountDebit"].OptionsColumn.AllowEdit = false;
                    gridView.Columns["GEAccountingFormulaItemAccountDebit"].Visible = false;
                }
                if (gridView.Columns["GEAccountingFormulaItemAccountCredit"] != null)
                {
                    gridView.Columns["GEAccountingFormulaItemAccountCredit"].OptionsColumn.AllowEdit = false;
                    gridView.Columns["GEAccountingFormulaItemAccountCredit"].Visible = false;
                }
                if (gridView.Columns["GEAccountingFormulaItemExceptAccountDebit"] != null)
                {
                    gridView.Columns["GEAccountingFormulaItemExceptAccountDebit"].OptionsColumn.AllowEdit = false;
                    gridView.Columns["GEAccountingFormulaItemExceptAccountDebit"].Visible = false;
                }
                if (gridView.Columns["GEAccountingFormulaItemExceptAccountCredit"] != null)
                {
                    gridView.Columns["GEAccountingFormulaItemExceptAccountCredit"].OptionsColumn.AllowEdit = false;
                    gridView.Columns["GEAccountingFormulaItemExceptAccountCredit"].Visible = false;
                }
                if (gridView.Columns["GEAccountingFormulaItemType"] != null)
                {
                    gridView.Columns["GEAccountingFormulaItemType"].OptionsColumn.AllowEdit = true;
                    gridView.Columns["GEAccountingFormulaItemType"].Visible = true;
                }

            }
            else if (type == AccountingFormulaType.LCTT.ToString())
            {
                if (gridView.Columns["GEAccountingFormulaItemAccountDebit"] != null)
                {
                    gridView.Columns["GEAccountingFormulaItemAccountDebit"].OptionsColumn.AllowEdit = true;
                    gridView.Columns["GEAccountingFormulaItemAccountDebit"].Visible = true;
                }
                if (gridView.Columns["GEAccountingFormulaItemAccountCredit"] != null)
                {
                    gridView.Columns["GEAccountingFormulaItemAccountCredit"].OptionsColumn.AllowEdit = true;
                    gridView.Columns["GEAccountingFormulaItemAccountCredit"].Visible = true;
                }
                if (gridView.Columns["GEAccountingFormulaItemExceptAccountDebit"] != null)
                {
                    gridView.Columns["GEAccountingFormulaItemExceptAccountDebit"].OptionsColumn.AllowEdit = true;
                    gridView.Columns["GEAccountingFormulaItemExceptAccountDebit"].Visible = true;
                }
                if (gridView.Columns["GEAccountingFormulaItemExceptAccountCredit"] != null)
                {
                    gridView.Columns["GEAccountingFormulaItemExceptAccountCredit"].OptionsColumn.AllowEdit = true;
                    gridView.Columns["GEAccountingFormulaItemExceptAccountCredit"].Visible = true;
                }
                if (gridView.Columns["GEAccountingFormulaItemAccount"] != null)
                {
                    gridView.Columns["GEAccountingFormulaItemAccount"].OptionsColumn.AllowEdit = false;
                    gridView.Columns["GEAccountingFormulaItemAccount"].Visible = false;
                }
            }

        }

    }
}
