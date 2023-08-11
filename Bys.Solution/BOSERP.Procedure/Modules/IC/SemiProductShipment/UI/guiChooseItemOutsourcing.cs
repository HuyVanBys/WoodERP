using BOSCommon;
using BOSCommon.Constants;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SemiProductShipment
{
    public partial class guiChooseItemOutsourcing : BOSERPScreen
    {
        #region Variables
        private GridControlHelper GridControlHelper;

        public List<ICReceiptItemsInfo> ReceiptItemsList { get; set; }

        public List<ICShipmentItemsInfo> ShipmentItemList { get; set; }

        public string AllocationPlanItemGroup { get; set; }
        public bool isGetFromSemiProductReceipt { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        private int Count = 0;
        #endregion
        public guiChooseItemOutsourcing()
        {
            InitializeComponent();
        }

        private void guiChooseReceiptItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            ShipmentItemList = new List<ICShipmentItemsInfo>();
            fld_dteFromDate.EditValue = isGetFromSemiProductReceipt ? FromDate : ((SemiProductShipmentModule)this.Module).GetServerDate().AddMonths(-1);
            fld_dteToDate.EditValue = isGetFromSemiProductReceipt ? ToDate : ((SemiProductShipmentModule)this.Module).GetServerDate();
            fld_dgcICReceiptItemsGridControl.InvalidateDataSource(ReceiptItemsList);
            fld_dgcICShipmentItemsGridControl.InvalidateDataSource(ShipmentItemList);
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
            if (ShipmentItemList.Count == 0)
            {
                BOSApp.ShowMessage(BaseLocalizedResources.ChooseObjectMessage);
                return;
            }
            if (ShipmentItemList.Select(o => o.FK_MMBatchProductID).Distinct().Count() > 1)
            {
                MessageBox.Show("Danh sách đã chọn không cùng một LSX. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int receiptID = fld_lkeFK_ICReceiptID.EditValue == null ? 0 : int.Parse(fld_lkeFK_ICReceiptID.EditValue.ToString());
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ReceiptItemsList = objReceiptItemsController.GetReceiptItemOutsourcingForShipment(receiptID, batchProductID, fromDate, toDate);
            SemiProductShipmentEntities entity = (SemiProductShipmentEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.ShipmentItemList.ForEach(o =>
            {
                ReceiptItemsList.RemoveAll(item => item.Id == o.FK_ICReceiptItemID);
            });
            ShipmentItemList.ForEach(o =>
            {
                ReceiptItemsList.RemoveAll(item => item.Id == o.FK_ICReceiptItemID);
            });
            fld_dgcICReceiptItemsGridControl.DataSource = ReceiptItemsList;
            fld_dgcICReceiptItemsGridControl.RefreshDataSource();
            GridControlHelper.ClearSelection();
        }

        private void fld_lkeFK_MMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = sender as LookUpEdit;
            if (sender == null)
                return;

            int batchProductID = e.Value == null || e.Value == DBNull.Value ? 0 : (int)e.Value;
            int toBatchProductID = fld_lkeFK_MMBatchProductTargetID.EditValue == null || fld_lkeFK_MMBatchProductTargetID.EditValue == DBNull.Value ? 0 : (int)fld_lkeFK_MMBatchProductTargetID.EditValue;
            if (toBatchProductID == 0)
                fld_lkeFK_MMBatchProductTargetID.EditValue = batchProductID;
        }

        private void fld_lkeFK_MMBatchProductItemID_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lke = sender as LookUpEdit;
            if (sender == null)
                return;

            int toBatchProductID = fld_lkeFK_MMBatchProductTargetID.EditValue == null || fld_lkeFK_MMBatchProductTargetID.EditValue == DBNull.Value ? 0 : (int)fld_lkeFK_MMBatchProductTargetID.EditValue;
            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            List<MMBatchProductItemsInfo> batchProductItemLisst = objBatchProductItemsController.GetBPItemForLookupByBatchProductID(toBatchProductID);
            batchProductItemLisst.Insert(0, new MMBatchProductItemsInfo());
            lke.Properties.DataSource = batchProductItemLisst;
        }

        private void fld_btnAllocationQty_Click(object sender, EventArgs e)
        {
            SemiProductShipmentEntities entity = (SemiProductShipmentEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            List<ICReceiptItemsInfo> receiptItemList = GridControlHelper.Selection.OfType<ICReceiptItemsInfo>().ToList();
            if (!receiptItemList.Any())
            {
                BOSApp.ShowMessage(BaseLocalizedResources.ChooseObjectMessage);
                return;
            }
            if (receiptItemList.Select(o => o.FK_MMBatchProductID).Distinct().Count() > 1)
            {
                MessageBox.Show("Danh sách đã chọn không cùng một LSX. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int fromBatchProductID = fld_lkeFK_MMBatchProductID.EditValue == null || fld_lkeFK_MMBatchProductID.EditValue == DBNull.Value ? 0 : (int)fld_lkeFK_MMBatchProductID.EditValue;
            int toBatchProductID = fld_lkeFK_MMBatchProductTargetID.EditValue == null || fld_lkeFK_MMBatchProductTargetID.EditValue == DBNull.Value ? 0 : (int)fld_lkeFK_MMBatchProductTargetID.EditValue;
            int batchProductItemID = fld_lkeFK_MMBatchProductItemID.EditValue == null || fld_lkeFK_MMBatchProductItemID.EditValue == DBNull.Value ? 0 : (int)fld_lkeFK_MMBatchProductItemID.EditValue;
            int operationID = fld_lkeFK_MMReceiveOperationID.EditValue == null || fld_lkeFK_MMReceiveOperationID.EditValue == DBNull.Value ? 0 : (int)fld_lkeFK_MMReceiveOperationID.EditValue;
            ICReceiptItemsInfo objReceiptItemsInfo = receiptItemList.FirstOrDefault();
            bool isDiffBatchProduct = objReceiptItemsInfo.FK_MMBatchProductID != toBatchProductID || objReceiptItemsInfo.FK_MMBatchProductID == 0;
            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            if (isDiffBatchProduct)
            {
                if (isDiffBatchProduct && toBatchProductID == 0)
                {
                    MessageBox.Show("Thông tin cấp phát không được để trống. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (isDiffBatchProduct && operationID == 0)
                {
                    MessageBox.Show("Công đoạn nhận không được để trống. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MMBatchProductProductionNormItemsController pniController = new MMBatchProductProductionNormItemsController();
                List<MMBatchProductProductionNormItemsInfo> pnItemList = pniController.GetRemainQtyForShipmentByReceiveOperation(toBatchProductID, batchProductItemID, operationID);
                List<int> semiProductList = pnItemList.Select(o => o.FK_ICProductID).ToList();
                string messageError = string.Empty;
                receiptItemList.ForEach(o =>
                {
                    if (semiProductList.Contains(o.FK_ICProductID))
                        return;

                    messageError += string.Format("BTP [{0}] không tồn tại trong LSX hoặc QTSX đã chọn.", BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", o.FK_ICProductID, "ICProductName"));
                    messageError += Environment.NewLine;
                });
                if (!string.IsNullOrWhiteSpace(messageError))
                {
                    messageError += "Vui lòng kiểm tra lại!";
                    MessageBox.Show(messageError, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                shipmentItemList = ((SemiProductShipmentModule)this.Module).AllocationShipmentQty(receiptItemList, pnItemList);
            }
            else
            {
                ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                receiptItemList.ForEach(o =>
                {
                    objShipmentItemsInfo = ((SemiProductShipmentModule)this.Module).ToReceiptItems(o);
                    entity.SetProductPriceByProductUnitPrice(objShipmentItemsInfo);
                    shipmentItemList.Add(objShipmentItemsInfo);
                });
            }
            ShipmentItemList.AddRange(shipmentItemList);
            fld_dgcICShipmentItemsGridControl.RefreshDataSource();
            ReceiptItemsList.RemoveAll(o => receiptItemList.Contains(o));
            fld_dgcICReceiptItemsGridControl.RefreshDataSource();
        }

        private void fld_lkeFK_MMReceiveOperationID_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lke = sender as LookUpEdit;
            if (lke == null)
                return;

            MMOperationsController objOperationsController = new MMOperationsController();
            List<MMOperationsInfo> objOperationsList = new List<MMOperationsInfo>();
            if (BOSApp.LookupTables.ContainsKey(TableName.MMOperationsTableName))
            {
                DataSet ds = (DataSet)BOSApp.LookupTables[TableName.MMOperationsTableName];
                if (ds != null)
                {
                    objOperationsList = (List<MMOperationsInfo>)objOperationsController.GetListFromDataSet(ds);
                    objOperationsList = objOperationsList.Count() > 0 ? objOperationsList.Where(o => o.MMOperationInOutStockCheck).ToList() : new List<MMOperationsInfo>();
                }
            }
            lke.Properties.DataSource = objOperationsList;
        }

        private void fld_dgcICShipmentItemsGridControl_KeyUp(object sender, KeyEventArgs e)
        {
            GridView gridView = fld_dgcICShipmentItemsGridControl.MainView as GridView;
            if (gridView == null)
                return;

            if (gridView.FocusedRowHandle < 0)
                return;

            ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetFocusedRow();
            if (e.KeyCode == Keys.Delete)
            {
                ShipmentItemList.Remove(item);
                fld_dgcICShipmentItemsGridControl.RefreshDataSource();
            }
        }

        private void fld_lkeFK_MMBatchProductTargetID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = sender as LookUpEdit;
            if (sender == null)
                return;

            if (lke.EditValue != lke.OldEditValue)
                fld_lkeFK_MMBatchProductItemID.EditValue = 0;
        }
    }
}
