using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public partial class guiUpdateOtherFees : BOSERPScreen
    {
        #region Variables
        public BOSList<ARSaleOrderItemAllocationFeesInfo> AllocationFeesList { get; set; }

        public BOSList<ARSaleOrderItemOtherFeesInfo> OtherFeesList { get; set; }

        public BOSList<ARSaleOrderItemAllocationFeesInfo> DeleteAllocationFeesList { get; set; }

        public BOSList<ARSaleOrderItemOtherFeesInfo> DeleteOtherFeesList { get; set; }
        #endregion

        public guiUpdateOtherFees(List<ARSaleOrderItemOtherFeesInfo> otherFeesList, List<ARSaleOrderItemAllocationFeesInfo> allocationFeesList)
        {
            InitializeComponent();
            AllocationFeesList = new BOSList<ARSaleOrderItemAllocationFeesInfo>();
            AllocationFeesList.InitBOSList(this.Module,
                                            TableName.ARSaleOrdersTableName,
                                            TableName.ARSaleOrderItemAllocationFeesTableName,
                                            BOSList<ARSaleOrderItemAllocationFeesInfo>.cstRelationForeign);
            AllocationFeesList.ItemTableForeignKey = "FK_ARSaleOrderID";
            AllocationFeesList.Invalidate(allocationFeesList);

            OtherFeesList = new BOSList<ARSaleOrderItemOtherFeesInfo>();
            OtherFeesList.InitBOSList(this.Module,
                                        TableName.ARSaleOrdersTableName,
                                        TableName.ARSaleOrderItemOtherFeesTableName,
                                        BOSList<ARSaleOrderItemOtherFeesInfo>.cstRelationForeign);
            OtherFeesList.ItemTableForeignKey = "FK_ARSaleOrderID";
            OtherFeesList.Invalidate(otherFeesList);

            DeleteAllocationFeesList = new BOSList<ARSaleOrderItemAllocationFeesInfo>();
            DeleteOtherFeesList = new BOSList<ARSaleOrderItemOtherFeesInfo>();
            DeleteAllocationFeesList.InitBOSList(this.Module,
                                            TableName.ARSaleOrdersTableName,
                                            TableName.ARSaleOrderItemAllocationFeesTableName,
                                            BOSList<ARSaleOrderItemAllocationFeesInfo>.cstRelationNone);
            DeleteOtherFeesList.InitBOSList(this.Module,
                                        TableName.ARSaleOrdersTableName,
                                        TableName.ARSaleOrderItemOtherFeesTableName,
                                        BOSList<ARSaleOrderItemOtherFeesInfo>.cstRelationNone);
        }

        private void guiAddWorkGroup_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            
            this.WindowState = FormWindowState.Maximized;
            fld_dgcARSaleOrderItemOtherFeesGridControl.InvalidateDataSource(OtherFeesList);
            fld_dgcARSaleOrderItemAllocationFeesGridControl.InvalidateDataSource(AllocationFeesList);
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

        public decimal CalcuAllocationFeePercent(decimal feeAmount)
        {
            decimal totalFee = OtherFeesList.Sum(o => o.ARSaleOrderItemOtherFeeTotalPrice);
            return totalFee != 0 ? feeAmount / totalFee * 100 : 0;
        }

        public void RefreshData()
        {
            decimal totalFee = OtherFeesList.Sum(o => o.ARSaleOrderItemOtherFeeTotalPrice);
            if (AllocationFeesList.Count > 0)
            {
                ARSaleOrderItemAllocationFeesInfo validateItem = AllocationFeesList[AllocationFeesList.Count - 1];
                decimal checkPercent = 100 - AllocationFeesList.Sum(o => o.ARSaleOrderItemAllocationFeeFeePercent);
                if (checkPercent != 0)
                {
                    validateItem.ARSaleOrderItemAllocationFeeFeePercent = validateItem.ARSaleOrderItemAllocationFeeFeePercent + checkPercent;
                }
                AllocationFeesList.ForEach(o => o.ARSaleOrderItemAllocationFeeFeeAmount = o.ARSaleOrderItemAllocationFeeFeePercent / 100 * totalFee);
                totalFee = totalFee - AllocationFeesList.Sum(o => o.ARSaleOrderItemAllocationFeeFeeAmount);
                if (totalFee != 0)
                {
                    validateItem.ARSaleOrderItemAllocationFeeFeeAmount = validateItem.ARSaleOrderItemAllocationFeeFeeAmount + totalFee;
                }
            }
            fld_dgcARSaleOrderItemOtherFeesGridControl.RefreshDataSource();
            fld_dgcARSaleOrderItemAllocationFeesGridControl.RefreshDataSource();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            SaleOrderEntities entity = (SaleOrderEntities)(this.Module as BaseModuleERP).CurrentModuleEntity;
            for (int i = 0; i < AllocationFeesList.Count; i++)
            {
                if (AllocationFeesList[i].FK_ICProductID <= 0)
                {
                    AllocationFeesList.RemoveAt(i);
                    i--;
                }
                else if (AllocationFeesList[i].ARSaleOrderItemAllocationFeeFeePercent < 0)
                {
                    AllocationFeesList[i].ARSaleOrderItemAllocationFeeFeePercent = 0M;
                    AllocationFeesList[i].ARSaleOrderItemAllocationFeeFeeAmount = 0M;
                }
            }
            RefreshData();

            decimal checkFee = OtherFeesList.Sum(o => o.ARSaleOrderItemOtherFeeTotalPrice) - AllocationFeesList.Sum(o => o.ARSaleOrderItemAllocationFeeFeeAmount);
            if (checkFee != 0)
            {
                MessageBox.Show("Chi phí cộng thêm phân bổ chưa đúng" + Environment.NewLine + "Vui lòng kiểm tra lại!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            checkFee = AllocationFeesList.Sum(o => o.ARSaleOrderItemAllocationFeeFeePercent);
            if (AllocationFeesList.Count > 0 && checkFee != 100)
            {
                MessageBox.Show("Phần trăm phân bổ Chi phí cộng thêm chưa đúng" + Environment.NewLine + "Vui lòng kiểm tra lại!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void DeleteAllocationFee(ARSaleOrderItemAllocationFeesInfo item)
        {
            DeleteAllocationFeesList.Add(item);
        }

        public void DeleteOtherFee(ARSaleOrderItemOtherFeesInfo item)
        {
            DeleteOtherFeesList.Add(item);
        }

    }
}