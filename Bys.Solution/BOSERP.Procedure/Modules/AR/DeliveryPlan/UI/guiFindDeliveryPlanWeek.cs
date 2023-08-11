using BOSCommon.Extensions.Helper;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.DeliveryPlan
{
    public partial class guiFindDeliveryPlanWeek : BOSERPScreen
    {
        #region Variables

        public List<ARDeliveryPlanItemsInfo> SelectedObjects { get; set; }

        public List<ARDeliveryPlanItemsInfo> DeliveryPlanItemLists { get; set; }

        public GridControlHelper gridControlHelper;
        #endregion

        public guiFindDeliveryPlanWeek()
        {
            InitializeComponent();
        }

        private void guiAddWorkGroup_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SetDefault();
            SelectedObjects = new List<ARDeliveryPlanItemsInfo>();
            GridView gridView = (GridView)fld_dgcARDeliveryPlanItemFindsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();
            gridControlHelper = new GridControlHelper(gridView);
        }

        private void SetDefault()
        {
            fld_dteARSaleOrderDeliveryDateForm.EditValue = BOSApp.GetCurrentServerDate();
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
            SelectedObjects = gridControlHelper.Selection.OfType<ARDeliveryPlanItemsInfo>().DistinctBy(o => o.ARDeliveryPlanItemID).ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_lkeFK_PMPhaseTypeID_KeyUp(object sender, KeyEventArgs e)
        {
            string value = string.Empty;
            SearchData(value);
        }

        private void SearchData(String keyWord)
        {
            //fld_dgcProductWorkGroupsGridControl.DataSource = ProductWorkGroupList;
            //fld_dgcProductWorkGroupsGridControl.RefreshDataSource();

            //if (string.IsNullOrEmpty(keyWord))
            //    return;

            //DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcProductWorkGroupsGridControl.MainView;

            //List<GridColumn> lstColVisible = new List<GridColumn>();
            //lstColVisible.Add(gridView.Columns["FK_PMPhaseTypeID"]);

            //List<ICProductWorkGroupsInfo> bindingList = new List<ICProductWorkGroupsInfo>();

            //for (int i = 0; i < ProductWorkGroupList.Count; i++)
            //{
            //    ICProductWorkGroupsInfo obj = ProductWorkGroupList[i];
            //    bool isExist = false;
            //    foreach (GridColumn column in lstColVisible)
            //    {
            //        int rowHandle = gridView.GetRowHandle(i);
            //        string value = gridView.GetRowCellDisplayText(rowHandle, column);
            //        isExist = IsExistKeyWord(value, keyWord);
            //        if (isExist)
            //            break;
            //    }
            //    if (isExist)
            //    {
            //        bindingList.Add(obj);
            //    }
            //}
            //fld_dgcProductWorkGroupsGridControl.DataSource = bindingList;
            //fld_dgcProductWorkGroupsGridControl.RefreshDataSource();
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

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            if (DeliveryPlanItemLists != null)
                SelectedObjects = SelectedObjects.Concat(DeliveryPlanItemLists.Where(o => o.Selected == true)).GroupBy(o => o.ARDeliveryPlanItemID).Select(o => o.FirstOrDefault()).ToList();
            DeliveryPlanItemLists = new List<ARDeliveryPlanItemsInfo>();
            ARDeliveryPlanItemsController objDeliveryPlanItemsController = new ARDeliveryPlanItemsController();
            DeliveryPlanItemLists = objDeliveryPlanItemsController.GetDeliveryPlanItemByDeliveryDate((DateTime?)fld_dteARSaleOrderDeliveryDateForm.EditValue);
            DeliveryPlanItemLists.ForEach(o =>
                {
                    if (SelectedObjects.Any(x => x.ARDeliveryPlanItemID == o.ARDeliveryPlanItemID))
                        o.Selected = true;
                });
            fld_dgcARDeliveryPlanItemFindsGridControl.InvalidateDataSource(DeliveryPlanItemLists);
            GridView gridView = (GridView)fld_dgcARDeliveryPlanItemFindsGridControl.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_chkSelectedAll_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DeliveryPlanItemLists.ForEach(o => o.Selected = (bool)e.NewValue);
            fld_dgcARDeliveryPlanItemFindsGridControl.RefreshDataSource();
        }
    }
}