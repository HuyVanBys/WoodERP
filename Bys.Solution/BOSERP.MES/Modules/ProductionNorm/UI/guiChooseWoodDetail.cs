using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BOSLib;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using BOSCommon;
using System.Linq;
using BOSERP.MES.Modules.BatchProduct.Localization;

namespace BOSERP.MES.Modules.ProductionNorm
{
    public partial class guiChooseWoodDetail : BOSERPScreen
    {
        #region Variables

        private GridControlHelper GridControlHelper;

        public List<MMProductionNormItemsInfo> SelectedObjects { get; set; }

        public BOSList<MMProductionNormItemsInfo> BPProductionNormItemList { get; set; }

        #endregion

        public guiChooseWoodDetail(List<MMProductionNormItemsInfo> productionNormItemList)
        {
            InitializeComponent();
            BPProductionNormItemList = new BOSList<MMProductionNormItemsInfo>();
            BPProductionNormItemList.Invalidate(productionNormItemList);
        }

        private void guiChooseBatchProposalItem_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SelectedObjects = new List<MMProductionNormItemsInfo>();
            fld_dgcBatchProposalItemsGridControl.InvalidateDataSource(BPProductionNormItemList);
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
            SelectedObjects = GridControlHelper.Selection.OfType<MMProductionNormItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            fld_dgcBatchProposalItemsGridControl.DataSource = BPProductionNormItemList;
            fld_dgcBatchProposalItemsGridControl.RefreshDataSource();
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcBatchProposalItemsGridControl.MainView;
            if (string.IsNullOrEmpty(keyWord))
            {
                gridView.ExpandAllGroups();
                return;
            }

            List<GridColumn> lstColVisible = new List<GridColumn>();
            lstColVisible.Add(gridView.Columns["MMProductionNormItemProductName"]);
            lstColVisible.Add(gridView.Columns["FK_ICProductAttributeWoodTypeID"]);
            lstColVisible.Add(gridView.Columns["MMProductionNormItemNo"]);
            List<MMProductionNormItemsInfo> bindingList = new List<MMProductionNormItemsInfo>();

            for (int i = 0; i < BPProductionNormItemList.Count; i++)
            {
                MMProductionNormItemsInfo obj = BPProductionNormItemList[i];
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