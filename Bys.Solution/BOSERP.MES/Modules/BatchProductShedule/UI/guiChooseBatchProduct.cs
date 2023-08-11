using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProductShedule
{
    public partial class guiChooseBatchProduct : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<MMBatchProductsInfo> SelectedObjects { get; set; }

        public List<MMBatchProductsInfo> BatchProductList { get; set; }

        public bool IsMultiSelect = false;
        #endregion

        public guiChooseBatchProduct(List<MMBatchProductsInfo> batchProductList)
        {
            InitializeComponent();
            BatchProductList = batchProductList;
        }

        private void guiChooseBatchProduct_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SelectedObjects = new List<MMBatchProductsInfo>();
            fld_dgcBatchProductsGridControl.InvalidateDataSource(BatchProductList);
            GridView gridView = (GridView)fld_dgcBatchProductsGridControl.MainView;
            if (IsMultiSelect)
            {
                GridControlHelper = new GridControlHelper(gridView);
            }
            InitBindingDatasource();
        }


        private void InitBindingDatasource()
        {
            GridView gridView = (GridView)fld_dgcBatchProductsGridControl.MainView;
            gridView.ExpandAllGroups();
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcBatchProductsGridControl.MainView;
            SelectedObjects.Clear();
            if (IsMultiSelect)
            {
                SelectedObjects = GridControlHelper.Selection.OfType<MMBatchProductsInfo>().ToList();
            }
            else
            {
                MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
                MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                bool isIsExist = objBatchProductsController.IsExistAllocationPlan(objBatchProductsInfo == null ? 0 : objBatchProductsInfo.MMBatchProductID);
                if (isIsExist)
                {
                    MessageBox.Show("Lệnh sản xuất đã có Kế hoạch sử dụng NPL. Vui lòng kiểm tra lại!", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (objBatchProductsInfo != null)
                    SelectedObjects.Add(objBatchProductsInfo);
            }
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            String keyWord = String.Empty;
            //if (int.Parse(fld_txtFind.Tag.ToString()) != 0)
            keyWord = fld_txtFind.Text;
            SearchData(keyWord);
        }

        private void SearchData(String keyWord)
        {
            fld_dgcBatchProductsGridControl.DataSource = BatchProductList;
            fld_dgcBatchProductsGridControl.RefreshDataSource();
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcBatchProductsGridControl.MainView;
            if (string.IsNullOrEmpty(keyWord))
            {
                gridView.ExpandAllGroups();
                return;
            }

            List<GridColumn> lstColVisible = new List<GridColumn>();
            lstColVisible.Add(gridView.Columns["MMBatchProductNo"]);
            lstColVisible.Add(gridView.Columns["MMBatchProductDesc"]);

            List<MMBatchProductsInfo> bindingList = new List<MMBatchProductsInfo>();

            for (int i = 0; i < BatchProductList.Count(); i++)
            {
                MMBatchProductsInfo obj = BatchProductList[i];
                bool isExist = false;
                foreach (GridColumn column in lstColVisible)
                {
                    int rowHandle = gridView.GetRowHandle(i);
                    string value = gridView.GetRowCellDisplayText(rowHandle, column);
                    isExist = IsExistKeyWord(value, keyWord);
                    if (isExist)
                        break;
                }
                if (isExist)
                {
                    bindingList.Add(obj);
                }
            }
            fld_dgcBatchProductsGridControl.DataSource = bindingList;
            fld_dgcBatchProductsGridControl.RefreshDataSource();
            gridView.ExpandAllGroups();
        }

        private bool IsExistKeyWord(String value, String keyWord)
        {
            value = value.ToLower();
            keyWord = keyWord.ToLower();
            String[] arrElement = keyWord.Split(new char[] { ' ' });
            bool isExist = false;
            foreach (String element in arrElement)
            {
                if (value.Contains(element))
                {
                    isExist = true;
                }
            }

            if (!isExist)
            {
                value = BOSUtil.ConvertUnicodeStringToUnSign(value);
                foreach (String element in arrElement)
                {
                    if (value.Contains(element))
                    {
                        isExist = true;
                    }
                }
            }
            return isExist;
        }
    }
}