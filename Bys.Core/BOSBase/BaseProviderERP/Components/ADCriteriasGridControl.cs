using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using Localization;
using System;
using System.Collections.Generic;

namespace BOSERP
{
    public partial class ADCriterasGridControl : BOSGridControl
    {
        public override void InitializeControl()
        {
            base.InitializeControl();
            this.UseEmbeddedNavigator = false;
        }

        public override void InitGridControlDataSource()
        {

            ADCriteriasInfo showAllCriteria = null;
            if (DataSource != null)
            {
                showAllCriteria = ((List<ADCriteriasInfo>)DataSource)[0];
            }
            ADCriteriasController objCriteriasController = new ADCriteriasController();
            List<ADCriteriasInfo> criteriaList = objCriteriasController.GetAllObjectByModuleAndUser(((IBaseModuleERP)Screen.Module).ModuleID, BOSApp.CurrentUsersInfo.ADUserID);
            //Add 'Show All' criteria
            if (showAllCriteria == null)
            {
                BaseModuleERP module = (BaseModuleERP)Screen.Module;
                showAllCriteria = new ADCriteriasInfo();
                showAllCriteria.ADCriteriaName = BaseLocalizedResources.ShowAll;
                showAllCriteria.ADCriteriaQueryString = module.GenerateSearchQuery(BOSUtil.GetTableNameFromBusinessObject(module.CurrentModuleEntity.MainObject));
            }
            criteriaList.Insert(0, showAllCriteria);

            DataSource = criteriaList;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.ShowColumnHeaders = false;
            gridView.OptionsView.ShowIndicator = false;
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ColumnAutoWidth = true;
            gridView.OptionsView.ShowFooter = false;
            gridView.OptionsView.ShowAutoFilterRow = false;

            GridColumn column = gridView.Columns["ADCriteriaName"];
            if (column != null)
            {
                column.VisibleIndex = 0;
            }

            return gridView;
        }
        protected override void OnDoubleClick(EventArgs ev)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)this.Views[0];
            if (gridView != null && gridView.FocusedRowHandle >= 0)
            {
                ADCriteriasInfo objCriteriasInfo = (ADCriteriasInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objCriteriasInfo != null)
                {
                    if (objCriteriasInfo.ADCriteriaName == BaseLocalizedResources.ShowAll)
                    {
                        ((BaseModuleERP)Screen.Module).SearchAll(objCriteriasInfo.ADCriteriaQueryString);
                    }
                    else
                    {
                        ((BaseModuleERP)Screen.Module).SearchByQuery(objCriteriasInfo.ADCriteriaQueryString);
                    }
                }
            }
        }
    }
}
