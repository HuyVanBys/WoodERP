using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SemiProductShipment
{
    public partial class guiAllocationPlanItems : BOSERPScreen
    {
        #region Variables
        private GridControlHelper GridControlHelper;

        public List<MMAllocationPlanItemsInfo> SelectedObjects { get; set; }

        private BOSList<MMAllocationPlanItemsInfo> AllocationPlanItemsList { get; set; }

        public string AllocationPlanItemGroup { get; set; }

        public int MMBatchProductID { get; set; }

        public int MMAllocationPlanID { get; set; }

        private int Count = 0;

        #endregion

        public guiAllocationPlanItems()
        {
            InitializeComponent();
        }

        private void guiAllocationPlanItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_lkeFK_MMBatchProductID.EditValue = MMBatchProductID;
            fld_dteFromDate.EditValue = BOSApp.GetCurrentServerDate().AddMonths(-1);
            fld_dteToDate.EditValue = BOSApp.GetCurrentServerDate();

            fld_lkeFK_MMBatchProductID.ReadOnly = false;
            fld_lkeFK_MMBatchProductID.Enabled = true;
            fld_lkeFK_MMAllocationPlanID.ReadOnly = false;
            fld_lkeFK_MMAllocationPlanID.Enabled = true;
            if (MMBatchProductID > 0 || MMAllocationPlanID > 0)
            {
                fld_lkeFK_MMBatchProductID.ReadOnly = true;
                fld_lkeFK_MMBatchProductID.Enabled = false;
                fld_lkeFK_MMAllocationPlanID.ReadOnly = true;
                fld_lkeFK_MMAllocationPlanID.Enabled = false;
            }
            fld_dgcMMAllocationPlanItemsGridControl.InvalidateDataSource(AllocationPlanItemsList);
            SelectedObjects = new List<MMAllocationPlanItemsInfo>();
            GridView gridView = (GridView)fld_dgcMMAllocationPlanItemsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;

            GridColumn columnGroup = gridView.Columns["MMAllocationProposalNo"];
            if (columnGroup != null)
            {
                columnGroup.Group();
            }
            if (AllocationPlanItemGroup == ProductType.Hardware.ToString())
            {
                columnGroup = gridView.Columns["FK_MMOperationID"];
                if (columnGroup != null)
                {
                    columnGroup.Group();
                }
            }
            GridControlHelper = new GridControlHelper(gridView);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<MMAllocationPlanItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                BOSApp.ShowMessage(BaseLocalizedResources.ChooseObjectMessage);
                return;
            }
            Count = SelectedObjects.Select(o => o.FK_MMBatchProductID).Distinct().Count();
            if (Count > 1)
            {
                BOSApp.ShowMessage(TransferOutsourcingLocalizedResources.DuplicateBatchProductErrorMessages);
                return;
            }
            Count = SelectedObjects.Select(o => o.FK_MMOperationID).Distinct().Count();
            if (AllocationPlanItemGroup == ProductType.Hardware.ToString() && Count > 1)
            {
                BOSApp.ShowMessage(MaterialShipmentLocalizedResources.ChooseMulltiOperationMessage);
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
            int batchProductID = fld_lkeFK_MMBatchProductID.EditValue == null ? 0 : int.Parse(fld_lkeFK_MMBatchProductID.EditValue.ToString());
            int allocationPlanID = fld_lkeFK_MMAllocationPlanID.EditValue == null ? 0 : int.Parse(fld_lkeFK_MMAllocationPlanID.EditValue.ToString());
            int workShopID = fld_lkeFK_MMWorkShopID.EditValue == null ? 0 : int.Parse(fld_lkeFK_MMWorkShopID.EditValue.ToString());
            int lineID = fld_lkeFK_MMLineID.EditValue == null ? 0 : int.Parse(fld_lkeFK_MMLineID.EditValue.ToString());
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;

            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            List<MMAllocationPlanItemsInfo> planItemList = objAllocationPlanItemsController.GetItemForShipmentByItemGroup(AllocationPlanItemGroup
                                                                                                                          , batchProductID
                                                                                                                          , allocationPlanID
                                                                                                                          , workShopID
                                                                                                                          , lineID
                                                                                                                          , 0
                                                                                                                          , 0
                                                                                                                          , fromDate
                                                                                                                          , toDate
                                                                                                                          , BOSApp.CurrentUsersInfo.ADUserID
                                                                                                                          , ModuleName.BatchProductShedule
                                                                                                                          , ADDataViewPermissionType.Module
                                                                                                                          , BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            SemiProductShipmentEntities entity = (SemiProductShipmentEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.ShipmentItemList.ForEach(o =>
            {
                planItemList.RemoveAll(item => item.Id == o.FK_MMAllocationPlanItemID);
            });
            fld_dgcMMAllocationPlanItemsGridControl.DataSource = planItemList;
            fld_dgcMMAllocationPlanItemsGridControl.RefreshDataSource();
        }

        private void Fld_lkeFK_MMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;

            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int batchProductID = int.Parse(e.Value.ToString());
                MMAllocationPlansController objAllocationPlansController = new MMAllocationPlansController();
                MMAllocationPlansInfo objAllocationPlansInfo = objAllocationPlansController.GetAllocationPlanByBatchProductID(batchProductID);
                if (objAllocationPlansInfo == null)
                    return;

                fld_lkeFK_MMAllocationPlanID.EditValue = objAllocationPlansInfo.MMAllocationPlanID;
                fld_lkeFK_MMAllocationPlanID.Refresh();
            }
        }

        private void Fld_lkeFK_MMAllocationPlanID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = sender as BOSLookupEdit;
            if (lke == null)
                return;

            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int allocationPlanID = int.Parse(e.Value.ToString());
                MMAllocationPlansController objAllocationPlansController = new MMAllocationPlansController();
                MMAllocationPlansInfo objAllocationPlansInfo = (MMAllocationPlansInfo)objAllocationPlansController.GetObjectByID(allocationPlanID);
                if (objAllocationPlansInfo == null)
                    return;

                fld_lkeFK_MMBatchProductID.EditValue = objAllocationPlansInfo.FK_MMBatchProductID;
                fld_lkeFK_MMBatchProductID.Refresh();
            }
        }
    }
}
