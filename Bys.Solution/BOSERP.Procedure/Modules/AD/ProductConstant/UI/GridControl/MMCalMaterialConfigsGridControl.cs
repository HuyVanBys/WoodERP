using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConstant
{
    public partial class MMCalMaterialConfigsGridControl : BOSComponent.BOSGridControl
    {
        List<MMMaterialDepartmentsInfo> MaterialDepartmentList { get; set; }

        public override void InitGridControlDataSource()
        {
            ProductConstantEntities entity = (ProductConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CalMaterialConfigList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            MMMaterialDepartmentsController objMaterialDepartmentsController = new MMMaterialDepartmentsController();
            MaterialDepartmentList = objMaterialDepartmentsController.GetAllMaterialDepartment();
            DataTable dt = ADConfigValueUtility.ConfigValues.Tables["ProductType"];
            List<string> productTypeList = MaterialDepartmentList.Select(o => o.ICProducType).ToList();
            DataTable datafilter = dt.Clone();
            productTypeList.ForEach(o =>
            {
                var data = dt.Rows.Cast<DataRow>().Where(v => (v["Value"] != null ? v["Value"].ToString() : string.Empty) == o).AsEnumerable();
                if (data != null && data.Any())
                    datafilter.Merge(data.CopyToDataTable());
            });
            DataRow row = datafilter.NewRow();
            row["Key"] = string.Empty;
            row["Value"] = string.Empty;
            row["Text"] = string.Empty;
            datafilter.Rows.InsertAt(row, 0);
            GridColumn column = gridView.Columns["MMProductType"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "Text";
                repositoryItemLookUpEdit.ValueMember = "Value";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("Text", "Loại hàng hóa"));
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.DataSource = datafilter;
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            foreach (GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductConstantModule)Screen.Module).RemoveCalMaterialConfigList();
            }
        }
    }
}
