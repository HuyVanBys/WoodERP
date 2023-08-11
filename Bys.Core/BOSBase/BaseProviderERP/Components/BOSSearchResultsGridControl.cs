using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP
{

    public partial class BOSSearchResultsGridControl : BOSGridControl
    {
        #region Constructors
        public BOSSearchResultsGridControl()
        {
            InitializeComponent();
        }

        public BOSSearchResultsGridControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion

        #region Function Init Search Result GridControl
        public void InitializeControl(STFieldsInfo objFieldInfo)
        {

        }

        public void InitializeControl()
        {
            base.InitializeControl();
            this.MouseDoubleClick += new MouseEventHandler(GridControlSearchResults_MouseDoubleClick);

        }

        protected override void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView dgvSearchResults = (GridView)sender;
            BOSProgressBar.Start("Ðang tải...");
            String strMainTable = ((BaseModuleERP)Screen.Module).CurrentModuleEntity.MainObject.GetType().Name.Substring(0, ((BaseModuleERP)Screen.Module).CurrentModuleEntity.MainObject.GetType().Name.Length - 4);
            DataRow row = dgvSearchResults.GetDataRow(dgvSearchResults.FocusedRowHandle);
            if (row != null)
            {
                try
                {
                    string no = strMainTable.Substring(0, strMainTable.Length - 1) + "No";
                    string dataNo = row[no].ToString();
                    if (!string.IsNullOrEmpty(dataNo))
                        BOSProgressBar.Start("Ðang tải: " + dataNo);

                    Screen.Module.Toolbar.CurrentIndex = Screen.Module.Toolbar.ObjectCollection.Tables[0].Rows.IndexOf(row);
                    if (Screen.Module.Toolbar.CurrentIndex < 0)
                    {
                        var bindingSource = (BindingSource)dgvSearchResults.DataSource;
                        var dt = (DataTable)bindingSource.DataSource;
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            Screen.Module.Toolbar.CurrentIndex = dt.Rows.IndexOf(row);

                        }
                    }
                }
                catch (Exception ex)
                {
                    //
                }
                Screen.Module.Toolbar.Invalidate();
            }
            BOSProgressBar.Close();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
            {
                ((BaseModuleERP)Screen.Module).ActivateDataMainScreen();
            }
        }

        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.VisibleIndex >= 0)
            {
                try
                {
                    String strTableName = BOSUtil.GetTableNameFromBusinessObject(((BaseModuleERP)Screen.Module).CurrentModuleEntity.MainObject);
                    String strColumnName = e.Column.FieldName;
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    if (strTableName.StartsWith("FA"))
                        if (strColumnName.Contains("FA" + Screen.Module.Name + "Type"))
                            if (ADConfigValueUtility.ConfigValues.Tables[Screen.Module.Name + "Type"] != null)
                                if (e.CellValue != null)
                                {
                                    String strValue = e.CellValue.ToString();
                                    DataRow row = ADConfigValueUtility.ConfigValues.Tables[Screen.Module.Name + "Type"].Rows.Find(strValue);
                                    if (row != null)
                                        e.DisplayText = row["Text"].ToString();
                                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    (sender as GridView).Columns.Remove(e.Column);
                }
            }
        }

        private void GridControlSearchResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.GridControl dgcSearchResults = (DevExpress.XtraGrid.GridControl)sender;
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hi = ((GridView)dgcSearchResults.MainView).CalcHitInfo(new Point(e.X, e.Y));
            if (hi.RowHandle >= 0)
            {
                BOSScreen _guiDataMainScreen = ((BaseModuleERP)Screen.Module).GetDataMainScreen(null, String.Empty);
                if (_guiDataMainScreen != null)
                {
                    _guiDataMainScreen.Activate();
                    Screen.Module.ActiveScreen = _guiDataMainScreen;
                }
            }
        }

        #endregion

        #region Add Search Results To GridControl Functions
        #region Utilities For Data GridControl View
        public static void BindingSearchResultGridControl(DevExpress.XtraGrid.GridControl gridControl, DataSet dsSearchResults)
        {
            if (dsSearchResults != null && dsSearchResults.Tables.Count > 0)
            {
                GridView gridView = (GridView)gridControl.ViewCollection[0];
                gridView.OptionsBehavior.AutoPopulateColumns = false;

                BindingSource bdsSearchResults = new BindingSource();
                bdsSearchResults.DataSource = dsSearchResults.Tables[0];
                gridControl.DataSource = bdsSearchResults;
                dsSearchResults.Dispose();
            }
        }

        protected override void InitGridColumnsVisibleIndex(GridView gridView)
        {
            STGridResultColumnDisplaysController objGridResultColumnDisplayController = new STGridResultColumnDisplaysController();

            DataSet dsColumns = objGridResultColumnDisplayController.GetGridResultColumnDisplaysByModuleName(Screen.Module.Name);
            if (dsColumns.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow rowColumn in dsColumns.Tables[0].Rows)
                {
                    STGridResultColumnDisplaysInfo objGridResultColumnDisplayInfo = (STGridResultColumnDisplaysInfo)objGridResultColumnDisplayController.GetObjectFromDataRow(rowColumn);
                    if (gridView.Columns[objGridResultColumnDisplayInfo.STGridResultColumnFieldName] != null)
                    {
                        gridView.Columns[objGridResultColumnDisplayInfo.STGridResultColumnFieldName].VisibleIndex = objGridResultColumnDisplayInfo.STGridResultSortOrder;
                        gridView.Columns[objGridResultColumnDisplayInfo.STGridResultColumnFieldName].Width = objGridResultColumnDisplayInfo.STGridResultColumnWidth;
                    }
                }
            }
            else
            {
                InitDefaultGridViewVisibleIndex(gridView, BOSDataSource);
            }
            dsColumns.Dispose();
        }

        protected virtual void InitDefaultGridViewVisibleIndex(GridView gridView, String strTableName)
        {

        }
        #endregion
        #endregion

        //public object Clone()
        //{
        //    return this.MemberwiseClone();
        //}
    }
}
