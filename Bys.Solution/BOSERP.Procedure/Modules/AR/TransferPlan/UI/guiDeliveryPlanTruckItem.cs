using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferPlan
{
    public partial class guiDeliveryPlanTruckItem : BOSERPScreen
    {
        #region Variables
        public List<ARDeliveryPlanTruckItemsInfo> SelectedObjects { get; set; }

        //public List<ARDeliveryPlanTrucksInfo> DeliveryPlanTrucksList { get; set; }

        public List<ARDeliveryPlanTruckItemsInfo> DeliveryPlanTruckItemsList { get; set; }
        #endregion

        public guiDeliveryPlanTruckItem(List<ARDeliveryPlanTruckItemsInfo> deliveryPlanTruckItems)
        {
            InitializeComponent();
            DeliveryPlanTruckItemsList = new List<ARDeliveryPlanTruckItemsInfo>();
            DeliveryPlanTruckItemsList = deliveryPlanTruckItems;
        }

        private void guiAddWorkGroup_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dgcARDeliveryPlanTruckItemsGridControl.InvalidateDataSource(DeliveryPlanTruckItemsList);
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
            SelectedObjects = DeliveryPlanTruckItemsList.Where(o => o.Selected == true).ToList();
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
    }
}