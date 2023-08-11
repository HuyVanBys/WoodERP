using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseOrder
{
    public partial class guiChooseBPProductionNormItems : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<MMBatchProductProductionNormItemsInfo> SelectedObjects { get; set; }

        public List<MMBatchProductProductionNormItemsInfo> BPProductionNormItemList { get; set; }

        public string ProposalProductType { get; set; }

        #endregion
        public guiChooseBPProductionNormItems(List<MMBatchProductProductionNormItemsInfo> bpPnisList)
        {
            InitializeComponent();
            BPProductionNormItemList = bpPnisList;
            SelectedObjects = new List<MMBatchProductProductionNormItemsInfo>();
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

        private void guiChooseBPProductionNormItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            DateTime toDay = BOSApp.GetCurrentServerDate();
            GridView gridView = (GridView)fld_dgcBPNormItemsGridControl.MainView;
            fld_dgcBPNormItemsGridControl.InvalidateDataSource(BPProductionNormItemList);
            GridControlHelper = new GridControlHelper(gridView);
            InitBindingDatasource();
        }

        private void InitBindingDatasource()
        {
            GridView gridView = (GridView)fld_dgcBPNormItemsGridControl.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<MMBatchProductProductionNormItemsInfo>().ToList();
            if (SelectedObjects.Count() == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        public void SearchData(String keyWord, List<MMBatchProductProductionNormItemsInfo> productionNormItemList)
        {
            GridView gridView = (GridView)fld_dgcBPNormItemsGridControl.MainView;
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
                List<MMBatchProductProductionNormItemsInfo> bindingList = new List<MMBatchProductProductionNormItemsInfo>();

                fld_dgcBPNormItemsGridControl.DataSource = productionNormItemList;
                fld_dgcBPNormItemsGridControl.RefreshDataSource();

                for (int i = 0; i < productionNormItemList.Count; i++)
                {
                    MMBatchProductProductionNormItemsInfo obj = productionNormItemList[i];
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
                fld_dgcBPNormItemsGridControl.DataSource = bindingList;
                fld_dgcBPNormItemsGridControl.RefreshDataSource();
            }
            else
            {
                fld_dgcBPNormItemsGridControl.DataSource = productionNormItemList;
                fld_dgcBPNormItemsGridControl.RefreshDataSource();
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

        private void Fld_btnSearch_Click(object sender, EventArgs e)
        {
            string keySearch = fld_txtSearchKey.EditValue == null ? string.Empty : fld_txtSearchKey.EditValue.ToString();
            SearchData(keySearch, BPProductionNormItemList);
        }
    }
}
