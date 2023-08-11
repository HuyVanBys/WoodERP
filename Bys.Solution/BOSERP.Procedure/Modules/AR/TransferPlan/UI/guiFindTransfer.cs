using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferPlan
{
    public partial class guiFindTransfer : BOSERPScreen
    {
        #region Variables
        public List<ICTransferItemsInfo> SelectedObjects { get; set; }

        public List<ICTransferItemsInfo> TransferItemLists { get; set; }

        public List<ARDeliveryPlanItemsInfo> DeliveryPlanItemLists { get; set; }
        #endregion

        public guiFindTransfer(List<ARDeliveryPlanItemsInfo> deliveryPlanItems)
        {
            InitializeComponent();
            DeliveryPlanItemLists = deliveryPlanItems;
        }

        private void guiAddWorkGroup_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SetDefault();
            SelectedObjects = new List<ICTransferItemsInfo>();
        }

        private void SetDefault()
        {
            fld_dteDateForm.EditValue = BOSApp.GetCurrentServerDate().AddDays(-7);
            fld_dteDateTo.EditValue = BOSApp.GetCurrentServerDate();
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
            SelectedObjects = SelectedObjects.Concat(TransferItemLists.Where(o => o.Selected == true)).GroupBy(o => o.ICTransferItemID).Select(o => o.FirstOrDefault()).ToList();
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
            if (TransferItemLists != null)
                SelectedObjects = SelectedObjects.Concat(TransferItemLists.Where(o => o.Selected == true)).GroupBy(o => o.ICTransferItemID).Select(o => o.FirstOrDefault()).ToList();
            TransferItemLists = new List<ICTransferItemsInfo>();
            ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
            TransferItemLists = objTransferItemsController.GetTransferItemByDate(BOSApp.CurrentUsersInfo.ADUserID,
                                                                                        ModuleName.TransferPlan,
                                                                                        ADDataViewPermissionType.Module,
                                                                                        (DateTime?)fld_dteDateForm.EditValue,
                                                                                        (DateTime?)fld_dteDateTo.EditValue,
                                                                                        (int?)fld_lkeFK_ICFromStockID1.EditValue,
                                                                                        (int?)fld_lkeFK_ICToStockID1.EditValue);
            DeliveryPlanItemLists.ForEach(o =>
            {
                ICTransferItemsInfo objTransferItemsInfo = TransferItemLists.FirstOrDefault(x => x.ICTransferItemID == o.FK_ICTransferItemID);
                if (objTransferItemsInfo != null)
                    TransferItemLists.Remove(objTransferItemsInfo);
            });
            TransferItemLists.ForEach(o =>
                {
                    if (SelectedObjects.Any(x => x.ICTransferItemID == o.ICTransferItemID))
                        o.Selected = true;
                });
            fld_dgcICTransferItemFindsGridControl.InvalidateDataSource(TransferItemLists);
            GridView gridView = (GridView)fld_dgcICTransferItemFindsGridControl.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_chkSelectedAll_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TransferItemLists.ForEach(o => o.Selected = (bool)e.NewValue);
            fld_dgcICTransferItemFindsGridControl.RefreshDataSource();
        }
    }
}