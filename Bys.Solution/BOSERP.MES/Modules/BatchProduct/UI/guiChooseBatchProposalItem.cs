using BOSERP.Modules.BatchProduct.Localization;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProduct
{
    public partial class guiChooseBatchProposalItem : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<MMProposalItemsInfo> SelectedObjects { get; set; }

        public List<MMProposalItemsInfo> BatchProposalItemList { get; set; }

        #endregion

        public guiChooseBatchProposalItem(List<MMProposalItemsInfo> batchProposalItemList)
        {
            InitializeComponent();
            BatchProposalItemList = batchProposalItemList;
        }

        private void guiChooseBatchProposalItem_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SelectedObjects = new List<MMProposalItemsInfo>();
            fld_dgcBatchProposalItemsGridControl.InvalidateDataSource(BatchProposalItemList);
            GridView gridView = (GridView)fld_dgcBatchProposalItemsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.OptionsMenu.EnableFooterMenu = false;
            GridControlHelper = new GridControlHelper(gridView);
            InitBindingDatasource();
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
            SelectedObjects = GridControlHelper.Selection.OfType<MMProposalItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (SelectedObjects.Select(o => o.FK_MMProposalID).Distinct().Count() > 1)
            {
                MessageBox.Show(BatchProductLocalizedResources.DuplicateBatchProposalMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InitBindingDatasource()
        {
            GridView gridView = (GridView)fld_dgcBatchProposalItemsGridControl.MainView;
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
            fld_dgcBatchProposalItemsGridControl.DataSource = BatchProposalItemList;
            fld_dgcBatchProposalItemsGridControl.RefreshDataSource();
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcBatchProposalItemsGridControl.MainView;
            if (string.IsNullOrEmpty(keyWord))
            {
                gridView.ExpandAllGroups();
                return;
            }

            List<GridColumn> lstColVisible = new List<GridColumn>();
            lstColVisible.Add(gridView.Columns["MMProposalItemProductName"]);
            lstColVisible.Add(gridView.Columns["MMProposalItemProductDesc"]);
            lstColVisible.Add(gridView.Columns["FK_ICProductID"]);
            List<MMProposalItemsInfo> bindingList = new List<MMProposalItemsInfo>();

            for (int i = 0; i < BatchProposalItemList.Count; i++)
            {
                MMProposalItemsInfo obj = BatchProposalItemList[i];
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
            fld_dgcBatchProposalItemsGridControl.DataSource = bindingList;
            fld_dgcBatchProposalItemsGridControl.RefreshDataSource();
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