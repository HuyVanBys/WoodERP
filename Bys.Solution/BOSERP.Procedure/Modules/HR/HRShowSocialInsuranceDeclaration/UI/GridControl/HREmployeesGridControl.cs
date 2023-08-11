using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.HRShowSocialInsuranceDeclaration
{
    public partial class HREmployeesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HRShowSocialInsuranceDeclarationEntities entity = (HRShowSocialInsuranceDeclarationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EmployeeList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            //gridView.DoubleClick += new EventHandler(GridView_DoubleClick);

            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = CommonLocalizedResources.Selected;
            column.FieldName = "Selected";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Công tháng";
            column.FieldName = "HREmployeeWorkingMonthQty";
            gridView.Columns.Add(column);
        }

        protected override void AddColumnsFromColumnAlias(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView, List<AAColumnAliasInfo> lstColumnAlias)
        {
            List<string> list = new List<string> { "HREmployeeNo", "HREmployeeName", "FK_BRBranchID", "FK_HRDepartmentID", "FK_HRDepartmentRoomID", "HREmployeeStatusCombo" };
            lstColumnAlias = lstColumnAlias.Where(o => list.Exists(x => x == o.AAColumnAliasName)).ToList();
            base.AddColumnsFromColumnAlias(strTableName, gridView, lstColumnAlias);
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                HRSocialInsuranceDeclarationsInfo objSocialInsuranceDeclarationsInfo = (HRSocialInsuranceDeclarationsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                HRSocialInsuranceDeclaration.HRSocialInsuranceDeclarationModule socialInsuranceDeclarationModule = (HRSocialInsuranceDeclaration.HRSocialInsuranceDeclarationModule)BOSApp.ShowModule("HRSocialInsuranceDeclaration");
                if (socialInsuranceDeclarationModule == null)
                {
                    if (BOSApp.IsOpenedModule("HRSocialInsuranceDeclaration"))
                    {
                        ToolStripButton tsbtnModule = (ToolStripButton)BOSApp.MainScreen.OpenModulesToolStrip.Items["HRSocialInsuranceDeclaration"];
                        BOSApp.CheckOpenModuleToolStripButton(tsbtnModule);
                        BaseModuleERP module = (BaseModuleERP)BOSApp.OpenModules["HRSocialInsuranceDeclaration"];
                        module.ParentScreen.Activate();
                        module.ActionInvalidate(objSocialInsuranceDeclarationsInfo.HRSocialInsuranceDeclarationID);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    socialInsuranceDeclarationModule.ActionInvalidate(objSocialInsuranceDeclarationsInfo.HRSocialInsuranceDeclarationID);
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                //((HRShowSocialInsuranceDeclarationModule)Screen.Module).DeleteItemFromKPIFormItemsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            if (e.Column.FieldName == "HRKPIFormItemWeight")
            {
                //((HRShowSocialInsuranceDeclarationModule)Screen.Module).ChangeItemWeight();
            }
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            //if (e.Column.FieldName == "HRKPIFormItemWeight")
            //{
            //    e.Appearance.BackColor2 = Color.Yellow;
            //    e.Appearance.BackColor = Color.Yellow;
            //}
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            //if (e.Column.FieldName == "FK_HRKPIID")
            //{
            //    if (e.Value != null)
            //    {
            //        int kpiID = int.Parse(e.Value.ToString());
            //        HRKPIsController objKPIsController = new HRKPIsController();
            //        HRKPIsInfo objKPIsInfo = (HRKPIsInfo)objKPIsController.GetObjectByID(kpiID);
            //        if (objKPIsInfo != null)
            //        {
            //            e.DisplayText = objKPIsInfo.HRKPINo;
            //        }
            //    }
            //}
        }
    }
}
