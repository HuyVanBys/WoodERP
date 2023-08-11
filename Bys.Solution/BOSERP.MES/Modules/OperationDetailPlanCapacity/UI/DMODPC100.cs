using BOSComponent;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlanCapacity.UI
{
    /// <summary>
    /// Summary description for DMODPC100
    /// </summary>
    public partial class DMODPC100 : BOSERPScreen
    {

        public DMODPC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void DMODPC100_Load(object sender, EventArgs e)
        {
            fld_dteFromDate.DateTime = DateTime.Now;
            fld_dteToDate.DateTime = DateTime.Now;
            fld_dteDate.DateTime = DateTime.Now;

        }

        private void fld_dgcMMOperationDetailPlanCapacityItems_Click(object sender, EventArgs e)
        {

        }

        private void fld_lkeFK_MMWorkShopID_QueryCloseUp(object sender, CancelEventArgs e)
        {
            //int workShopID = 0;
            //if (int.TryParse(fld_lkeFK_MMWorkShopID.EditValue.ToString(), out workShopID))
            //{
            //    DataSet ds =
            //    ((OperationDetailPlanCapacityModule)Module).ChangeWorkShop(workShopID);

            //    if (ds != null && ds.Tables != null)
            //    {
            //        fld_lkeHREmployeeID.Properties.DataSource = ds.Tables[0];
            //    }
            //}
        }

        private void bosLookupEdit1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((OperationDetailPlanCapacityModule)Module).ChangeOperation(int.Parse(e.Value.ToString()));
            }
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            int operationID = BOSApp.GetIntFromLookupEdit(fld_lkeFK_MMOperationID);
            int bpID = BOSApp.GetIntFromLookupEdit(fld_lkeMMBatchProductID);
            DateTime fromdate = fld_dteFromDate.DateTime;
            DateTime todate = fld_dteToDate.DateTime;
            int empGiveID = BOSApp.GetIntFromLookupEdit(fld_lkeHREmployeeGiveID);
            int empTakeID = BOSApp.GetIntFromLookupEdit(fld_lkeHREmployeeTakeID);
            int empQCID = BOSApp.GetIntFromLookupEdit(fld_lkeHREmployeeQCID);
            int productID = BOSApp.GetIntFromLookupEdit(fld_lkeICProductID);
            int productForBatchID = BOSApp.GetIntFromLookupEdit(fld_lkeICProductForBatchID);
            if (fromdate.ToString("yyyy") == "9999")
            {
                BOSApp.ShowMessage("Vui lòng chọn Xem từ ngày");
                return;
            }

            if (todate.ToString("yyyy") == "9999")
            {
                BOSApp.ShowMessage("Vui lòng chọn Đến ngày");
                return;
            }

            ((OperationDetailPlanCapacityModule)Module).SearchItemCapacity(fromdate, todate, productID, bpID, operationID, empGiveID, empTakeID, empQCID, productForBatchID);
        }

        private void fld_btnAddCertificate_Click(object sender, EventArgs e)
        {
            //((OperationDetailPlanCapacityModule)Module).ActionNewFromDetailPlan();
            AddItem();
        }

        private void fld_btnEditCapacity_Click(object sender, EventArgs e)
        {
            ((OperationDetailPlanCapacityModule)Module).SaveItem();
        }

        private void fld_btnDeleteCapacity_Click(object sender, EventArgs e)
        {
            ((OperationDetailPlanCapacityModule)Module).RemoveOperationDetailPlanCapacityList();
        }

        private void fld_btnRefresh_Click(object sender, EventArgs e)
        {
            //fld_lkeARSaleOrderID.EditValue = 0;
            //fld_lkeMMBatchProductID.EditValue = 0;
            //fld_lkeMMOperationDetailPlanID.EditValue = 0;
            //fld_lkeMMBatchProductItemID.EditValue = 0;
            //fld_lkeFK_MMWorkShopID.EditValue = 0;
            //fld_lkeHREmployeeID.EditValue = 0;
            //fld_txtQty.Text = string.Empty;
            //fld_lkeICProductID.EditValue = 0;
            //fld_lkeFK_MMOperationID.EditValue = 0;
            //fld_dteDate.DateTime = DateTime.Now;
            //fld_dteSearchToDate.DateTime = DateTime.Now;

            ((OperationDetailPlanCapacityModule)Module).ClearOperationDetailPlanCapacityList();
        }

        private void fld_lkeMMBatchProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int FK_ARSaleOrderID = 0;
            //if (fld_lkeARSaleOrderID.EditValue != null)
            //    int.TryParse(fld_lkeARSaleOrderID.EditValue.ToString(), out FK_ARSaleOrderID);
            fld_lkeMMBatchProductID.Properties.DataSource = ((OperationDetailPlanCapacityModule)Module).GetBatchProductDataSource(FK_ARSaleOrderID);
        }

        private void fld_lkeICProductForBatchID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int FK_MMBatchProductID = 0;
            if (fld_lkeMMBatchProductID.EditValue != null)
                int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out FK_MMBatchProductID);
            //fld_lkeMMBatchProductItemID.Properties.DataSource = ((OperationDetailPlanCapacityModule)Module).GetBatchProductItemListByBatchProduct(FK_MMBatchProductID);
            //fld_lkeMMBatchProductItemID.Properties.DisplayMember = "ICProductDesc";
            //fld_lkeMMBatchProductItemID.Properties.ValueMember = "FK_MMBatchProductItemID";
        }

        private void fld_lkeMMOperationDetailPlanID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int FK_MMBatchProductID = 0;
            if (fld_lkeMMBatchProductID.EditValue != null)
                int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out FK_MMBatchProductID);
            int FK_MMOperationID = 0;
            if (fld_lkeFK_MMOperationID.EditValue != null)
                int.TryParse(fld_lkeFK_MMOperationID.EditValue.ToString(), out FK_MMOperationID);
            int MMBatchProductItemID = 0;
            //if (fld_lkeMMBatchProductItemID.EditValue != null)
            //    int.TryParse(fld_lkeMMBatchProductItemID.EditValue.ToString(), out MMBatchProductItemID);
            //fld_lkeMMOperationDetailPlanID.Properties.DataSource = ((OperationDetailPlanCapacityModule)Module)
            //    .GetOperationDetailPlanDataSource(FK_MMOperationID, FK_MMBatchProductID, MMBatchProductItemID);
        }

        private void fld_lkeICProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            //int FK_MMOperationDetailPlanID = 0;
            ////if (fld_lkeMMOperationDetailPlanID.EditValue != null)
            ////    int.TryParse(fld_lkeMMOperationDetailPlanID.EditValue.ToString(), out FK_MMOperationDetailPlanID);
            //int FK_MMBatchProductID = 0;
            //if (fld_lkeMMBatchProductID.EditValue != null)
            //    int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out FK_MMBatchProductID);
            //int FK_MMOperationID = 0;
            //if (fld_lkeFK_MMOperationID.EditValue != null)
            //    int.TryParse(fld_lkeFK_MMOperationID.EditValue.ToString(), out FK_MMOperationID);
            //int MMBatchProductItemID = 0;
            ////if (fld_lkeMMBatchProductItemID.EditValue != null)
            ////    int.TryParse(fld_lkeMMBatchProductItemID.EditValue.ToString(), out MMBatchProductItemID);

            //fld_lkeICProductID.Properties.DataSource = ((OperationDetailPlanCapacityModule)Module)
            //    .GetDetailPlanItemChildDataSource(FK_MMOperationDetailPlanID, FK_MMOperationID, FK_MMBatchProductID, MMBatchProductItemID);
            //fld_lkeICProductID.Properties.ValueMember = "FK_ICProductID";
            //fld_lkeICProductID.Properties.DisplayMember = "MMOperationDetailPlanItemChildProductNo";

        }

        private void fld_lkeMMOperationDetailPlanID_QueryCloseUp(object sender, CancelEventArgs e)
        {
            int FK_MMOperationDetailPlanID = 0;
            //if (fld_lkeMMOperationDetailPlanID.EditValue != null)
            //    int.TryParse(fld_lkeMMOperationDetailPlanID.EditValue.ToString(), out FK_MMOperationDetailPlanID);
            MMOperationDetailPlansInfo item = ((OperationDetailPlanCapacityModule)Module).ChangeOperationDetailPlan(FK_MMOperationDetailPlanID);
            if (item != null)
            {
                if (item.FK_MMLineID > 0)
                    fld_lkeHREmployeeGiveID.EditValue = item.FK_MMLineID;
                //if (item.FK_MMWorkShopID > 0)
                //fld_lkeFK_MMWorkShopID.EditValue = item.FK_MMWorkShopID;
            }
        }

        private void fld_txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddItem();
            }
        }

        public void AddItem()
        {
            int operationID = BOSApp.GetIntFromLookupEdit(fld_lkeFK_MMOperationID);
            int bpID = BOSApp.GetIntFromLookupEdit(fld_lkeMMBatchProductID);
            DateTime date = fld_dteDate.DateTime;
            int empGiveID = BOSApp.GetIntFromLookupEdit(fld_lkeHREmployeeGiveID);
            int empTakeID = BOSApp.GetIntFromLookupEdit(fld_lkeHREmployeeTakeID);
            int empQCID = BOSApp.GetIntFromLookupEdit(fld_lkeHREmployeeQCID);
            int productID = BOSApp.GetIntFromLookupEdit(fld_lkeICProductID);
            int productForBatchID = BOSApp.GetIntFromLookupEdit(fld_lkeICProductForBatchID);

            if (((OperationDetailPlanCapacityModule)Module).IsOperationSyncProductCheck(operationID))
            {
                if (productForBatchID == 0)
                {
                    BOSApp.ShowMessage("Vui lòng chọn Thành phẩm!");
                    return;
                }
            }

            decimal qty = 0;
            if (fld_txtQty.EditValue != null)
            {
                decimal.TryParse(fld_txtQty.EditValue.ToString(), out qty);
            }


            int workShopID = 0;
            int lineID = 0;
            string productName = string.Empty;
            if (fld_lkeICProductID.GetColumnValue("ICProductName") != null)
            {
                productName = fld_lkeICProductID.GetColumnValue("ICProductName").ToString();
            }

            if (fld_lkeICProductID.GetColumnValue("FK_MMWorkShopID") != null)
            {
                int.TryParse(fld_lkeICProductID.GetColumnValue("FK_MMWorkShopID").ToString(), out workShopID);
            }

            if (fld_lkeICProductID.GetColumnValue("FK_MMLineID") != null)
            {
                int.TryParse(fld_lkeICProductID.GetColumnValue("FK_MMLineID").ToString(), out lineID);
            }

            if (date.ToString("yyyy") == "9999")
            {
                BOSApp.ShowMessage("Vui lòng chọn ngày nhập");
                return;
            }

            if (operationID == 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn Công đoạn");
                return;
            }

            //if (toOperationID == 0)
            //{
            //    BOSApp.ShowMessage("Vui lòng chọn Công đoạn đến");
            //    return;
            //}

            if (bpID == 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn LSX");
                return;
            }

            if (empGiveID == 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn Người giao");
                return;
            }

            //if (empTakeID == 0)
            //{
            //    BOSApp.ShowMessage("Vui lòng chọn Người nhận");
            //    return;
            //}

            if (productID == 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn Chi tiết/Sản phẩm");
                return;
            }

            if (qty == 0)
            {
                BOSApp.ShowMessage("Vui lòng nhập số lượng");
                return;
            }

            ((OperationDetailPlanCapacityModule)Module).AddItemCapacity(productID, bpID, operationID, empGiveID, empTakeID, empQCID, date, qty, workShopID, lineID, productName, fld_ckeBeginOperation.Checked, fld_ckeHasReceipt.Checked, fld_ckeDefaultByProcess.Checked, productForBatchID);
            fld_lkeICProductID.Focus();
            fld_lkeICProductID.ShowPopup();
        }

        private void fld_lkeFK_MMOperationID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            int batchProductID = BOSApp.GetIntFromLookupEdit(fld_lkeMMBatchProductID);
            int operationID = 0;
            if (e.Value != null)
            {
                int.TryParse(e.Value.ToString(), out operationID);
            }

            ((OperationDetailPlanCapacityModule)Module).ReloadProductLookupDataSource(batchProductID, operationID);
            fld_lkeICProductID.EditValue = null;
        }

        private void fld_lkeMMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            int operationID = BOSApp.GetIntFromLookupEdit(fld_lkeFK_MMOperationID);
            int batchProductID = 0;
            if (e.Value != null)
            {
                int.TryParse(e.Value.ToString(), out batchProductID);
            }
            //((OperationDetailPlanCapacityModule)Module).ReloadProductLookupDataSource(batchProductID, operationID);
            fld_lkeFK_MMOperationID.Properties.DataSource = ((OperationDetailPlanCapacityModule)Module).ReloadOperationLookupDataSource(batchProductID);
            fld_lkeFK_MMOperationID.EditValue = null;
            fld_lkeICProductID.Properties.DataSource = null;
            fld_lkeICProductID.EditValue = null;
            fld_lkeICProductForBatchID.Properties.DataSource = null;
            fld_lkeICProductForBatchID.EditValue = null;
        }

        private void fld_txtQty_Enter(object sender, EventArgs e)
        {
            fld_txtQty.SelectAll();
        }

        private void fld_lkeICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fld_txtQty.Focus();
            }
        }

        private void fld_btnClear_Click(object sender, EventArgs e)
        {
            fld_lkeFK_MMOperationID.EditValue = null;
            fld_lkeMMBatchProductID.EditValue = null;
            fld_lkeHREmployeeGiveID.EditValue = null;
            fld_lkeHREmployeeTakeID.EditValue = null;
            fld_lkeHREmployeeQCID.EditValue = null;
            fld_lkeICProductID.EditValue = null;
            fld_lkeICProductForBatchID.EditValue = null;
            ((OperationDetailPlanCapacityModule)Module).ClearList();
        }

        public void SetControlValueByItem(MMOperationDetailPlanCapacityItemsInfo item)
        {

            fld_lkeFK_MMOperationID.EditValue = item.FK_MMOperationID;
            fld_lkeMMBatchProductID.EditValue = item.FK_MMBatchProductID;
            fld_lkeHREmployeeGiveID.EditValue = item.FK_HREmployeeGiveID;
            fld_lkeHREmployeeTakeID.EditValue = item.FK_HREmployeeTakeID;
            fld_lkeHREmployeeQCID.EditValue = item.FK_HREmployeeQCID;

            ((OperationDetailPlanCapacityModule)Module).ReloadProductLookupDataSource(item.FK_MMBatchProductID, item.FK_MMOperationID);
            fld_lkeICProductID.EditValue = item.FK_ICProductID;
            fld_dteDate.DateTime = item.MMOperationDetailPlanCapacityItemDate;
        }

        private void fld_btnAddFromList_Click(object sender, EventArgs e)
        {
            int operationID = BOSApp.GetIntFromLookupEdit(fld_lkeFK_MMOperationID);
            int bpID = BOSApp.GetIntFromLookupEdit(fld_lkeMMBatchProductID);
            DateTime date = fld_dteDate.DateTime;
            int empGiveID = BOSApp.GetIntFromLookupEdit(fld_lkeHREmployeeGiveID);
            int empTakeID = BOSApp.GetIntFromLookupEdit(fld_lkeHREmployeeTakeID);
            int empQCID = BOSApp.GetIntFromLookupEdit(fld_lkeHREmployeeQCID);
            ((OperationDetailPlanCapacityModule)Module).AddItemFromList(bpID, operationID, empGiveID, empTakeID, empQCID, date, fld_ckeBeginOperation.Checked, fld_ckeHasReceipt.Checked);
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((OperationDetailPlanCapacityModule)Module).CheckCanCapacityQty();
        }

        private void fld_ckeDefaultByProcess_CheckedChanged(object sender, EventArgs e)
        {
            fld_ckeHasReceipt.Enabled = !fld_ckeDefaultByProcess.Checked;
            fld_ckeBeginOperation.Enabled = !fld_ckeDefaultByProcess.Checked;

        }

        private void fld_lkeICProductForBatchID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                int productForBatchID = (int)e.Value;
                ((OperationDetailPlanCapacityModule)Module).ChangeProductForBatch(productForBatchID);
            }
        }
    }
}
