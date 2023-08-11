using BOSCommon;
using BOSCommon.Constants;
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
    public partial class guiChooseReceiptItems : BOSERPScreen
    {
        #region Variables
        private GridControlHelper GridControlHelper;

        public List<ICReceiptItemsInfo> SelectedObjects { get; set; }

        public List<ICReceiptItemsInfo> ReceiptItemsList { get; set; }

        public string AllocationPlanItemGroup { get; set; }
        public bool isGetFromSemiProductReceipt { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        private int Count = 0;

        #endregion

        public guiChooseReceiptItems()
        {
            InitializeComponent();
        }

        private void guiChooseReceiptItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteFromDate.EditValue = isGetFromSemiProductReceipt ? FromDate : ((SemiProductShipmentModule)this.Module).GetServerDate().AddMonths(-1);
            fld_dteToDate.EditValue = isGetFromSemiProductReceipt ? ToDate : ((SemiProductShipmentModule)this.Module).GetServerDate();
            fld_dgcICReceiptItemsGridControl.InvalidateDataSource(ReceiptItemsList);
            SelectedObjects = new List<ICReceiptItemsInfo>();
            GridView gridView = (GridView)fld_dgcICReceiptItemsGridControl.MainView;
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
            SelectedObjects = GridControlHelper.Selection.OfType<ICReceiptItemsInfo>().ToList();
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
            if (isGetFromSemiProductReceipt)
            {
                Count = SelectedObjects.Where(o => o.FK_MMOperationIDInReceipt > 0).Select(o => o.FK_MMOperationIDInReceipt).Distinct().Count();
                if (Count > 1)
                {
                    BOSApp.ShowMessage(SemiProductShipmentLocalizedResources.MultiNextOperation);
                    return;
                }
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
            int receiptID = fld_lkeFK_ICReceiptID.EditValue == null ? 0 : int.Parse(fld_lkeFK_ICReceiptID.EditValue.ToString());
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            if (!isGetFromSemiProductReceipt)
                ReceiptItemsList = objReceiptItemsController.GetReceiptItemOutsourcingForShipment(receiptID, batchProductID, fromDate, toDate);
            else
                ReceiptItemsList = objReceiptItemsController.GetItemSemiProductRemainBySomeCriteria(receiptID, batchProductID, fromDate, toDate
                                                                                                                        , BOSApp.CurrentUsersInfo.ADUserID
                                                                                                                        , this.Name
                                                                                                                        , ADDataViewPermissionType.Module
                                                                                                                        , BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            SemiProductShipmentEntities entity = (SemiProductShipmentEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.ShipmentItemList.ForEach(o =>
            {
                ReceiptItemsList.RemoveAll(item => item.Id == o.FK_ICReceiptItemID);
            });
            fld_dgcICReceiptItemsGridControl.DataSource = ReceiptItemsList;
            fld_dgcICReceiptItemsGridControl.RefreshDataSource();
        }
    }
}
