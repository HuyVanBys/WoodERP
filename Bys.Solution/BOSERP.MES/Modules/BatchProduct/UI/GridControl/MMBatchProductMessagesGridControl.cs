using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct
{
    public class MMBatchProductMessagesGridControl : BOSGridControl
    {
        List<STModulesInfo> ModuleList { get; set; }


        public void InvalidateDataSource(List<MMBatchProductMessagesInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
            GetDataSourceModule();
        }

        public void GetDataSourceModule()
        {
            STModulesController objModulesController = new STModulesController();
            DataSet ds = (DataSet)BOSApp.LookupTables[TableName.STModulesTableName];
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData(TableName.STModulesTableName);
            }
            ModuleList = (List<STModulesInfo>)objModulesController.GetListFromDataSet(ds);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        public void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "STModuleName")
            {
                if (e.Value != null)
                {
                    e.DisplayText = ModuleList.Where(o => o.STModuleName == e.Value.ToString()).Select(o => o.STModuleDescription).FirstOrDefault();
                }
            }
        }

        private void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            MMBatchProductMessagesInfo item = (MMBatchProductMessagesInfo)gridView.GetRow(e.RowHandle);
            if (item == null)
                return;

            if (item.MMProductionStatus != "OK")
            {
                e.Appearance.BackColor = Color.Red;
                e.Appearance.BackColor2 = Color.OrangeRed;
            }
            else
            {
                e.Appearance.BackColor = Color.Green;
                e.Appearance.BackColor2 = Color.ForestGreen;
            }
        }
    }
}
