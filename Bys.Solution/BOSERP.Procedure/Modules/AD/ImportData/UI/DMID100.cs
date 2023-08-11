using BOSCommon;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace BOSERP.Modules.ImportData.UI
{
    /// <summary>
    /// Summary description for DMID100
    /// </summary>
    public partial class DMID100 : BOSERPScreen
    {

        public DMID100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }
        private void fld_lkeCheckDataType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (fld_lkeMMOperationID.EditValue != null)
            {
                int operationID = 0;
                int.TryParse(fld_lkeMMOperationID.EditValue.ToString(), out operationID);
                if (operationID > 0)
                {
                    List<MMProductionCostFactorsInfo> listFactor = (new MMProductionCostFactorsController()).GetFactorOfFormulaByOperationID(operationID);
                    if (listFactor.Count() > 0) fld_lkeCheckDataType.Properties.DataSource = listFactor;
                }
            }
        }

        private void fld_dteCheckToDate_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_lkeMMOperationID.EditValue != null)
            {
                int operationID = 0;
                int.TryParse(fld_lkeMMOperationID.EditValue.ToString(), out operationID);
                if (operationID > 0)
                {
                    MMProductionCostCalculationsInfo obj = (new MMProductionCostCalculationsController()).GetProductionCostByOperationIDAndDate(operationID, fld_dteCheckToDate.DateTime);
                    if (obj != null) fld_txtProducttionCostNo.Text = obj.MMProductionCostCalculationNo;
                }
            }
        }

        private void fld_btnCheckData_Click(object sender, EventArgs e)
        {
            ((ImportDataModule)Module).InitGridView("CostGrid", this, fld_grcGroupControl);
            int factor = 0;
            if (fld_lkeCheckDataType.EditValue != null)
            {
                int.TryParse(fld_lkeCheckDataType.EditValue.ToString(), out factor);
            }
            ((ImportDataModule)Module).GetDataError(fld_txtProducttionCostNo.Text, factor);
        }
        private void fld_lkeMMOperationID_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (fld_lkeMMOperationID.EditValue == null) return;
            int operationID = 0;
            int.TryParse(fld_lkeMMOperationID.EditValue.ToString(), out operationID);
            if (operationID > 0)
            {
                MMProductionCostCalculationsInfo obj = (new MMProductionCostCalculationsController()).GetProductionCostByOperationIDAndDate(operationID, fld_dteCheckToDate.DateTime);
                if (obj != null) fld_txtProducttionCostNo.Text = obj.MMProductionCostCalculationNo;
            }
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            if (BOSApp.ShowMessageYesNo("Bạn chắc chắn muốn cập nhật lý do nhập xuất cho dữ liệu sai!") == DialogResult.No)
                return;
            int factor = 0;
            int reason = 0;
            if (fld_lkeCheckDataType.EditValue != null)
            {
                int.TryParse(fld_lkeCheckDataType.EditValue.ToString(), out factor);
                
            }
            if (fld_lkeICImportAndExportReasons.EditValue != null)
            {
                int.TryParse(fld_lkeICImportAndExportReasons.EditValue.ToString(), out reason);
                
            }
            if (reason <= 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn lý do nhập xuất!");
                return;
            }
            if (factor <= 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn Yếu tố chi phí!");
                return;
            }
            if (string.IsNullOrEmpty(fld_txtProducttionCostNo.Text))
            {
                BOSApp.ShowMessage("Vui lòng xác định chứng từ TGT!");
                return;
            }
            if (((ImportDataModule)Module).UpdateShipmentReason(fld_txtProducttionCostNo.Text, factor, reason))
            {
                BOSApp.ShowMessage("Cập nhật thành công!");
            }

        }

        private void fld_btnChecktab1_Click(object sender, EventArgs e)
        {
            ((ImportDataModule)Module).InitGridViewTab1("CostGridTab1", this, fld_gcTab1);
            string typeCombo = string.Empty;
            if (fld_lkeICShipmentTypeCombo.EditValue == null)
            {
                BOSApp.ShowMessage("Vui lòng chọn loại xuất kho !");
                return;
            }
            else typeCombo = fld_lkeICShipmentTypeCombo.EditValue.ToString();

            int operationID = 0;
            int.TryParse(fld_lkeMMoperation1.EditValue.ToString(), out operationID);
            if (operationID == 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn Công đoạn !");
                return;
            }
           
            DateTime fromDate = new DateTime(fld_dteCostDate1.DateTime.Year, fld_dteCostDate1.DateTime.Month, 1);
            DateTime toDate = new DateTime(fld_dteCostDate1.DateTime.Year, fld_dteCostDate1.DateTime.Month, DateTime.DaysInMonth(fld_dteCostDate1.DateTime.Year, fld_dteCostDate1.DateTime.Month));
            DateTime prevDate = fromDate.AddDays(-1);
            ((ImportDataModule)Module).GetDataShipmentAfterCompleteReceipt(typeCombo, operationID, fromDate, toDate, prevDate);
        }

        private void fld_btnCheckTab2_Click(object sender, EventArgs e)
        {
            ((ImportDataModule)Module).InitGridViewTab2("CostGridTab2", this, fld_bgrTab2);
            string typeCombo = string.Empty;
            if (fld_lkeShipmentTypeTab2.EditValue == null)
            {
                BOSApp.ShowMessage("Vui lòng chọn loại xuất kho !");
                return;
            }
            else typeCombo = fld_lkeShipmentTypeTab2.EditValue.ToString();

            int operationID = 0;
            int.TryParse(fld_lkeMMOperationTab2.EditValue.ToString(), out operationID);
            if (operationID == 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn Công đoạn !");
                return;
            }
            int reason = 0;
            if (fld_lkeICImportAndExportReasonsTab2.EditValue != null)
            {
                int.TryParse(fld_lkeICImportAndExportReasonsTab2.EditValue.ToString(), out reason);

            }
            if (reason <= 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn lý do nhập xuất!");
                return;
            }
            
            DateTime fromDate = new DateTime(fld_dteDateTab2.DateTime.Year, fld_dteDateTab2.DateTime.Month, 1);
            DateTime toDate = new DateTime(fld_dteDateTab2.DateTime.Year, fld_dteDateTab2.DateTime.Month, DateTime.DaysInMonth(fld_dteDateTab2.DateTime.Year, fld_dteDateTab2.DateTime.Month));

            ((ImportDataModule)Module).GetDataShipmentErrorOperation(typeCombo, operationID, fromDate, toDate, reason);
        }

        private void fld_btnUpdateTab2_Click(object sender, EventArgs e)
        {
            if (BOSApp.ShowMessageYesNo("Bạn chắc chắn muốn cập nhật Công đoạn cho dữ liệu sai!") == DialogResult.No)
                return;
            string typeCombo = string.Empty;
            if (fld_lkeShipmentTypeTab2.EditValue == null)
            {
                BOSApp.ShowMessage("Vui lòng chọn loại xuất kho !");
                return;
            }
            else typeCombo = fld_lkeShipmentTypeTab2.EditValue.ToString();

            int operationID = 0;
            int.TryParse(fld_lkeMMOperationTab2.EditValue.ToString(), out operationID);
            if (operationID == 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn Công đoạn !");
                return;
            }
            int reason = 0;
            if (fld_lkeICImportAndExportReasonsTab2.EditValue != null)
            {
                int.TryParse(fld_lkeICImportAndExportReasonsTab2.EditValue.ToString(), out reason);

            }
            if (reason <= 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn lý do nhập xuất!");
                return;
            }
            int operationUpdateID = 0;
            int.TryParse(fld_lkeUpdateMMOperationIDTab2.EditValue.ToString(), out operationUpdateID);
            if (operationUpdateID == 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn Công đoạn cập nhật !");
                return;
            }
            DateTime fromDate = new DateTime(fld_dteDateTab2.DateTime.Year, fld_dteDateTab2.DateTime.Month, 1);
            DateTime toDate = new DateTime(fld_dteDateTab2.DateTime.Year, fld_dteDateTab2.DateTime.Month, DateTime.DaysInMonth(fld_dteDateTab2.DateTime.Year, fld_dteDateTab2.DateTime.Month));

            ((ImportDataModule)Module).UpdateShipmentErrorOperation(typeCombo, operationID, fromDate, toDate, reason, operationUpdateID);
        }

        private void fld_btnOperation3_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (fld_btnOperation3.EditValue == null) return;
            int operationID = 0;
            int.TryParse(fld_btnOperation3.EditValue.ToString(), out operationID);
            if (operationID > 0)
            {
                MMProductionCostCalculationsInfo obj = (new MMProductionCostCalculationsController()).GetProductionCostByOperationIDAndDate(operationID, fld_dteCheckToDate3.DateTime);
                if (obj != null) fld_txtProducttionCostNo3.Text = obj.MMProductionCostCalculationNo;
            }
        }

        private void fld_dteCheckToDate3_EditValueChanged(object sender, EventArgs e)
        {
            if (fld_btnOperation3.EditValue != null)
            {
                int operationID = 0;
                int.TryParse(fld_btnOperation3.EditValue.ToString(), out operationID);
                if (operationID > 0)
                {
                    MMProductionCostCalculationsInfo obj = (new MMProductionCostCalculationsController()).GetProductionCostByOperationIDAndDate(operationID, fld_dteCheckToDate3.DateTime);
                    if (obj != null) fld_txtProducttionCostNo3.Text = obj.MMProductionCostCalculationNo;
                }
            }
        }

        private void fld_lkeCheckDataType3_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (fld_btnOperation3.EditValue != null)
            {
                int operationID = 0;
                int.TryParse(fld_btnOperation3.EditValue.ToString(), out operationID);
                if (operationID > 0)
                {
                    List<MMProductionCostFactorsInfo> listFactor = (new MMProductionCostFactorsController()).GetFactorOfFormulaByOperationID(operationID);
                    if (listFactor.Count() > 0)
                    {
                        listFactor = listFactor.Where(o => o.FK_MMProductionCostFactorGroupID == 1).ToList();
                        fld_lkeCheckDataType3.Properties.DataSource = listFactor; 
                    }
                }
            }
        }

        private void fld_btnCheckData3_Click(object sender, EventArgs e)
        {
            int factor = 0;
            if (fld_lkeCheckDataType3.EditValue != null)
            {
                int.TryParse(fld_lkeCheckDataType3.EditValue.ToString(), out factor);
            }
            int operationID = 0;
            int.TryParse(fld_btnOperation3.EditValue.ToString(), out operationID);
            int prevOperationID = 0;
            if (fld_lkePrevMMOperationID.EditValue != null)
            {
                int.TryParse(fld_lkePrevMMOperationID.EditValue.ToString(), out prevOperationID);
                if (prevOperationID > 0)
                    ((ImportDataModule)Module).GetDataErrorAndPrevProductionCost(fld_txtProducttionCostNo3.Text, factor, prevOperationID, operationID);
            }
        }

        private void fld_btnUpdatePrice_Click(object sender, EventArgs e)
        {
            int factor = 0;
            if (fld_lkeCheckDataType3.EditValue != null)
            {
                int.TryParse(fld_lkeCheckDataType3.EditValue.ToString(), out factor);
            }
            int operationID = 0;
            if (fld_btnOperation3.EditValue != null)
            {
                int.TryParse(fld_btnOperation3.EditValue.ToString(), out operationID);
            }
            ((ImportDataModule)Module).UpdateCostPrice(fld_txtProducttionCostNo3.Text, factor, operationID);
        }

        private void fld_btnUpdateSelectItem_Click(object sender, EventArgs e)
        {
            int reason = 0;
            
            if (fld_lkeICImportAndExportReasonsTab1.EditValue != null)
            {
                int.TryParse(fld_lkeICImportAndExportReasonsTab1.EditValue.ToString(), out reason);

            }
            if (reason <= 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn lý do nhập xuất!");
                return;
            }
            ((ImportDataModule)Module).UpdateSelectedItem(reason);
        }

        private void fld_btnUpdateReferItem_Click(object sender, EventArgs e)
        {
            if (((ImportDataModule)Module).UpdateReferItem())
            {
                BOSApp.ShowMessage("Cập nhật thành công !");
            }
        }
    }
}
