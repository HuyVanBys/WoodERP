using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SemiProductReceipt
{
    public partial class guiChooseBatchProductItems : BOSERPScreen
    {
        #region Variables
        private GridControlHelper GridControlHelper;

        public List<MMBatchProductItemsInfo> SelectedObjects { get; set; }

        private BOSList<MMBatchProductItemsInfo> BatchProductItemsList { get; set; }

        private int Count = 0;

        #endregion

        private void guiChooseBatchProductItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcMMBatchProductItems.InvalidateDataSource(BatchProductItemsList);
            SelectedObjects = new List<MMBatchProductItemsInfo>();
            GridView gridView = (GridView)fld_dgcMMBatchProductItems.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            GridControlHelper = new GridControlHelper(gridView);
            InitBindingDatasource();
        }

        private void InitBindingDatasource()
        {
            fld_dgcMMBatchProductItems.InvalidateDataSource(BatchProductItemsList);
            GridView gridView = (GridView)fld_dgcMMBatchProductItems.MainView;
            gridView.ExpandAllGroups();
        }

        public guiChooseBatchProductItems(List<MMBatchProductItemsInfo> batchProductProductionNormItemsList)
        {
            InitializeComponent();
            BatchProductItemsList = new BOSList<MMBatchProductItemsInfo>(TableName.MMBatchProductItemsTableName);
            BatchProductItemsList.Invalidate(batchProductProductionNormItemsList);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<MMBatchProductItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Count = SelectedObjects.Select(o => o.FK_MMBatchProductID).Distinct().Count();
            if (Count > 1)
            {
                MessageBox.Show(TransferOutsourcingLocalizedResources.DuplicateBatchProductErrorMessages, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            String keyWord = String.Empty;
            keyWord = fld_txtFind.Text;
            SearchData(keyWord, BatchProductItemsList);
        }

        public void SearchData(String keyWord, BOSList<MMBatchProductItemsInfo> batchProductProductionNormItemsList)
        {
            GridView gridView = (GridView)fld_dgcMMBatchProductItems.MainView;
            if (!String.IsNullOrEmpty(keyWord))
            {
                List<GridColumn> lstColVisible = new List<GridColumn>();
                for (int i = 0; i < gridView.Columns.Count; i++)
                {
                    if (gridView.Columns[i].VisibleIndex >= 0 || gridView.Columns[i].GroupIndex >= 0)
                    {
                        lstColVisible.Add(gridView.Columns[i]);
                    }
                }
                BOSDbUtil dbUtil = new BOSDbUtil();
                List<MMBatchProductItemsInfo> bindingList = new List<MMBatchProductItemsInfo>();

                fld_dgcMMBatchProductItems.DataSource = batchProductProductionNormItemsList;
                fld_dgcMMBatchProductItems.RefreshDataSource();

                for (int i = 0; i < batchProductProductionNormItemsList.Count; i++)
                {
                    MMBatchProductItemsInfo obj = batchProductProductionNormItemsList[i];
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
                fld_dgcMMBatchProductItems.DataSource = bindingList;
                fld_dgcMMBatchProductItems.RefreshDataSource();
            }
            else
            {
                fld_dgcMMBatchProductItems.DataSource = batchProductProductionNormItemsList;
                fld_dgcMMBatchProductItems.RefreshDataSource();
            }
        }
        public bool IsExistKeyWord(String value, String keyWord)
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

        private void fld_txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String keyWord = String.Empty;
                if (int.Parse(fld_txtFind.Tag.ToString()) != 0)
                    keyWord = fld_txtFind.Text;
                SearchData(keyWord, BatchProductItemsList);
            }
        }
    }
}
