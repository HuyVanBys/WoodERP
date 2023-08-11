using BOSCommon;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public partial class guiChooseDiscountProgram : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<int> DiscountProgramIDs { get; set; }

        public List<ARDiscountProgramsInfo> SelectedObjects { get; set; }

        public List<ARDiscountProgramsInfo> DiscountProgramsList { get; set; }
        #endregion

        public guiChooseDiscountProgram(List<ARDiscountProgramsInfo> programList)
        {
            InitializeComponent();
            DiscountProgramsList = programList;
            this.CenterToParent();
        }

        private void guiChooseDiscountProgram_Load(object sender, EventArgs e)
        {
            BOSProgressBar.Start("Hệ thống đang kiểm tra Chương trình khuyến mãi!");
            InitializeControls(Controls);
            SelectedObjects = new List<ARDiscountProgramsInfo>();
            GridView gridView = (GridView)fld_dgcDiscountProgramsGridControl.MainView;
            GridControlHelper = new GridControlHelper(gridView);
            fld_dgcDiscountProgramsGridControl.InvalidateDataSource(DiscountProgramsList);
            GridControlHelper.Selection = new ArrayList(DiscountProgramsList.Where(o => DiscountProgramIDs.Contains(o.ARDiscountProgramID)).ToArray());
            GridControlHelper.Invalidate();
            InitBindingDatasource();
            BOSProgressBar.Close();
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
            SelectedObjects = GridControlHelper.Selection.OfType<ARDiscountProgramsInfo>().ToList();
            if (SelectedObjects.Count() == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //int countType = SelectedObjects.Where(o => o.ARDiscountProgramApplyType == DiscountProgramApplyType.SaleOrder.ToString()).Count();
            int countType = SelectedObjects.Count();
            if (countType > 1)
            {
                MessageBox.Show("Không thể áp dụng nhiều chương trình trên một đơn hàng. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitBindingDatasource()
        {
            GridView gridView = (GridView)fld_dgcDiscountProgramsGridControl.MainView;
            gridView.ExpandAllGroups();
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
            fld_dgcDiscountProgramsGridControl.DataSource = DiscountProgramsList;
            fld_dgcDiscountProgramsGridControl.RefreshDataSource();
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcDiscountProgramsGridControl.MainView;
            if (string.IsNullOrEmpty(keyWord))
            {
                gridView.ExpandAllGroups();
                return;
            }

            List<GridColumn> lstColVisible = new List<GridColumn>();
            lstColVisible.Add(gridView.Columns["MMBatchProductProductionNormItemProductName"]);
            lstColVisible.Add(gridView.Columns["MMBatchProductProductionNormItemNo"]);
            lstColVisible.Add(gridView.Columns["MMBatchProductProductionNormItemProductDesc"]);
            List<ARDiscountProgramsInfo> bindingList = new List<ARDiscountProgramsInfo>();

            for (int i = 0; i < DiscountProgramsList.Count; i++)
            {
                ARDiscountProgramsInfo obj = DiscountProgramsList[i];
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
            fld_dgcDiscountProgramsGridControl.DataSource = bindingList;
            fld_dgcDiscountProgramsGridControl.RefreshDataSource();
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