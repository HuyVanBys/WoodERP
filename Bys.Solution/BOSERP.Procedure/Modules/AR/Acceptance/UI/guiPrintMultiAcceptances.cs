using BOSCommon.Constants;
using BOSLib;
using BOSReport;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Acceptance
{
    public partial class guiPrintMultiAcceptances : BOSERPScreen
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        //  private List<ACAssetsInfo> AssetList;
        ///// <summary>
        ///// A variable to store the room list for selecting
        ///// </summary>
        public string type;
        public BOSList<ARAcceptancesInfo> AcceptancesInfoList = new BOSList<ARAcceptancesInfo>();
        public guiPrintMultiAcceptances()
        {
            InitializeComponent();
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

        private void guiPrintMultiAcceptances_Load(object sender, EventArgs e)
        {
            fld_dteSearchFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
            AcceptanceEntities entity = (AcceptanceEntities)(((AcceptanceModule)Module).CurrentModuleEntity);
            AcceptancesInfoList.InitBOSList(entity, null, TableName.ARAcceptancesTableName, BOSList<ARAcceptancesInfo>.cstRelationNone);
            AcceptancesInfoList.InitBOSListGridControl(fld_dgcAcceptances);
            InitializeControls(Controls);
            ARAcceptancesController objAcceptancesController = new ARAcceptancesController();
            List<ARAcceptancesInfo> acceptancesList = objAcceptancesController.getAllAcceptanceForMultiPrint();
            AcceptancesInfoList.Invalidate(acceptancesList);
            BindingSource bs = new BindingSource();
            bs.DataSource = AcceptancesInfoList;
            fld_dgcAcceptances.DataSource = bs;
            //AcceptancesInfoList.GridControl.RefreshDataSource();
            GridView gridView = (GridView)fld_dgcAcceptances.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();
        }


        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            GetSearchData();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            List<ARAcceptancesInfo> result = AcceptancesInfoList.Where(o => o.Selected).ToList();
            if (result.Count == 0)
            {
                MessageBox.Show(AcceptanceLocalizedResources.NotSelectAcceptance,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                return;
            }
            if (result.Where(p => p.FK_ACObjectID != result[0].FK_ACObjectID || p.ARObjectType != result[0].ARObjectType).ToList().Count > 0)
            {
                MessageBox.Show(AcceptanceLocalizedResources.NotSameCustomer,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                return;
            }
            if (type == "Acceptance")
            {
                String[] arr = result.Select(p => p.ARAcceptanceID.ToString()).ToArray();
                String acceptanceID = String.Join(",", arr);
                RP_Acceptance rpAcceptance = new RP_Acceptance();
                InitAcceptancesReport(rpAcceptance, acceptanceID, result[0].FK_ACObjectID, result[0].ARObjectType);
                guiReportPreview reviewer = new guiReportPreview(rpAcceptance);
                reviewer.Show();
            }
            else
            {
                String[] arr = result.Select(p => p.ARAcceptanceID.ToString()).ToArray();
                String acceptanceID = String.Join(",", arr);
                RP_MultiBanlanceSheet rpMultiBalanceSheet = new RP_MultiBanlanceSheet();
                InitAcceptancesReport(rpMultiBalanceSheet, acceptanceID, result[0].FK_ACObjectID, result[0].ARObjectType);
                guiReportPreview reviewer = new guiReportPreview(rpMultiBalanceSheet);
                reviewer.Show();
            }
        }

        private void InitAcceptancesReport(RP_MultiBanlanceSheet rpBalanceSheet, string acceptanceID, int objectID, string objectType)
        {
            ARAcceptancesInfo objAcceptancesInfo = new ARAcceptancesInfo();
            ARAcceptanceItemsController objAcceptanceItemsController = new ARAcceptanceItemsController();
            ARAcceptancesController objAcceptancesController = new ARAcceptancesController();
            List<ARAcceptanceItemsInfo> AcceptanceItemList = objAcceptanceItemsController.GetListItemForPrintMultiAcceptance(acceptanceID, BOSApp.CurrentCompanyInfo.CSCompanyID);

            AcceptanceItemList = AcceptanceItemList.OrderBy(x => x.ICDepartmentName).ToList();
            int departmentRowNumber = 0;
            int rowNumber = 0;
            string oldDepartmentName = String.Empty;
            objAcceptancesInfo.ARAcceptanceTotalItemPrice = 0;
            objAcceptancesInfo.ARAcceptanceTotalItemDiscountAmount = 0;
            objAcceptancesInfo.ARAcceptanceSubTotalAmount = 0;
            AcceptanceItemList.ForEach(p =>
            {
                objAcceptancesInfo.ARAcceptanceTotalItemPrice += p.ARAcceptanceItemPrice;
                objAcceptancesInfo.ARAcceptanceTotalItemDiscountAmount += p.ARAcceptanceItemDiscountAmount;
                objAcceptancesInfo.ARAcceptanceSubTotalAmount += p.ARAcceptanceItemTotalAmount;
                if (p.ARAcceptanceItemWidth > 0 && p.ARAcceptanceItemHeight > 0 && p.ARAcceptanceItemLength > 0)
                {
                    p.ICProductSize = string.Format("{0}x{1}x{2}", p.ARAcceptanceItemLength.ToString("n0"), p.ARAcceptanceItemWidth.ToString("n0"), p.ARAcceptanceItemHeight.ToString("n0"));
                }
                if (p.ICDepartmentName != oldDepartmentName)
                {
                    departmentRowNumber++;
                    oldDepartmentName = p.ICDepartmentName;
                    rowNumber = 0;
                }
                p.RowNumber = departmentRowNumber.ToString() + "." + (++rowNumber).ToString();
                p.DepartmentRowNumber = departmentRowNumber.ToString();
            });
            objAcceptancesInfo.ARAcceptanceDiscountFix = objAcceptancesController.GetTotalAcceptanceDiscountFix(acceptanceID);
            objAcceptancesInfo.ARAcceptanceTotalAmount = objAcceptancesInfo.ARAcceptanceSubTotalAmount - objAcceptancesInfo.ARAcceptanceDiscountFix;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objectID, objectType);
            ARCustomerPaymentTimePaymentsController objCustomerPaymentTimePaymentsController = new ARCustomerPaymentTimePaymentsController();
            List<ARCustomerPaymentTimePaymentsInfo> customerPaymentTimePaymentsList = objCustomerPaymentTimePaymentsController.GetCustomerPaymentTimeForPrintMutiAcceptanceReport(acceptanceID);
            if (customerPaymentTimePaymentsList != null && customerPaymentTimePaymentsList.Count > 0)
            {
                objAcceptancesInfo.ARCustomerPaymentTimePayment1 = customerPaymentTimePaymentsList[0].ARCustomerPaymentTimePaymentAmount;
                objAcceptancesInfo.ARCustomerPaymentTimePayment2 = customerPaymentTimePaymentsList.Sum(p => p.ARCustomerPaymentTimePaymentAmount) - objAcceptancesInfo.ARCustomerPaymentTimePayment1;
            }
            objAcceptancesInfo.ARAcceptanceRemainedAmount = objAcceptancesInfo.ARAcceptanceTotalAmount - objAcceptancesInfo.ARCustomerPaymentTimePayment1 - objAcceptancesInfo.ARCustomerPaymentTimePayment2;
            rpBalanceSheet.bsACObjects.DataSource = objObjectsInfo;
            rpBalanceSheet.bsARAcceptances.DataSource = objAcceptancesInfo;
            rpBalanceSheet.bsARAcceptanceItems.DataSource = AcceptanceItemList;

            XRLabel saleOrderPONoLabel = (XRLabel)rpBalanceSheet.Bands[BandKind.ReportHeader].Controls["xr_lblSaleOrderNo"];
            if (saleOrderPONoLabel != null) saleOrderPONoLabel.Visible = false;

            XRLabel printDateLabel = (XRLabel)rpBalanceSheet.Bands[BandKind.ReportFooter].Controls["xr_lblPrintDate"];
            if (printDateLabel != null) printDateLabel.Text = string.Format("Ngày {0} tháng {1} năm {2}", BOSApp.GetCurrentServerDate().ToString("dd"), BOSApp.GetCurrentServerDate().ToString("MM"), BOSApp.GetCurrentServerDate().ToString("yyyy"));
            XRLabel createdEmployeeLabel = (XRLabel)rpBalanceSheet.Bands[BandKind.ReportFooter].Controls["xr_lblEmployeeName"];
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objCreatedEmployee = !string.IsNullOrEmpty(objAcceptancesInfo.AACreatedUser) ? objEmployeesController.GetEmployeeByUserName(objAcceptancesInfo.AACreatedUser) : objEmployeesController.GetEmployeeByUserName(BOSApp.CurrentUser);
            createdEmployeeLabel.Text = objCreatedEmployee != null ? objCreatedEmployee.HREmployeeName : "";
            GroupHeaderBand groupHeader2 = (GroupHeaderBand)rpBalanceSheet.Bands["GroupHeader2"];
            if (groupHeader2 != null)
                groupHeader2.Visible = false;
        }

        private void InitAcceptancesReport(RP_Acceptance report, String acceptanceID, int objectID, string objectType)
        {
            ARAcceptanceItemsController objAcceptanceItemController = new ARAcceptanceItemsController();
            List<ARAcceptanceItemsInfo> AcceptanceItemList = objAcceptanceItemController.GetListItemForPrintMultiAcceptance(acceptanceID, BOSApp.CurrentCompanyInfo.CSCompanyID);
            AcceptanceItemList = AcceptanceItemList.Where(p => p.ICDepartmentName != AcceptanceLocalizedResources.Service).ToList();
            AcceptanceItemList = AcceptanceItemList.OrderBy(x => x.ICDepartmentName).ToList();

            int departmentRowNumber = 0;
            int rowNumber = 0;
            string oldDepartmentName = String.Empty;
            AcceptanceItemList.ForEach(o =>
            {
                if (o.ICDepartmentName != oldDepartmentName)
                {
                    departmentRowNumber++;
                    oldDepartmentName = o.ICDepartmentName;
                    rowNumber = 0;
                }
                o.RowNumber = departmentRowNumber.ToString() + "." + (++rowNumber).ToString();
                o.DepartmentRowNumber = departmentRowNumber.ToString();
            });
            report.bsARAcceptances.DataSource = AcceptanceItemList;

            CSCompanysController objCompanyController = new CSCompanysController();
            CSCompanysInfo objCompanysInfo = (CSCompanysInfo)objCompanyController.GetObjectByID(1);
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objectID, objectType);
            XRLabel lblCompanyName = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCompanyName"];
            if (lblCompanyName != null)
            {
                lblCompanyName.Text = objCompanysInfo.CSCompanyDesc;
            }
            XRLabel lblCompanyAddress = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCompanyAddress"];
            if (lblCompanyAddress != null)
            {
                lblCompanyAddress.Text = objCompanysInfo.CSCompanyAddressLine1;
            }
            XRLabel lblSaleOrderNo = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblSaleOrderNo"];
            if (lblSaleOrderNo != null)
            {
                lblSaleOrderNo.Visible = false;
            }
            XRLabel lblCustomerName = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCustomerName"];
            if (lblCustomerName != null)
            {
                lblCustomerName.Text = string.IsNullOrEmpty(objObjectsInfo.ACObjectContactName) ? objObjectsInfo.ACObjectName : objObjectsInfo.ACObjectContactName;
            }
            XRLabel lblCustomerAddress = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCustomerAddress"];
            if (lblCustomerAddress != null)
            {
                lblCustomerAddress.Text = objObjectsInfo.ACObjectDeliveryAddressLine1;
            }
            XRLabel lblCompanyContact = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblCompanyContact"];
            if (lblCompanyContact != null)
            {
                lblCompanyContact.Text = "Trân trọng cảm ơn sự quan tâm của quý khác hàng. Nếu cần bất kỳ thông tin nào về sản phẩm & dịch vụ của công ty chúng tôi xin vui lòng liên lạc số điện thoại: " + objCompanysInfo.CSCompanyPhone;
            }
        }

        public void GetSearchData()
        {
            String objectAccessKey = String.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null) objectAccessKey = fld_lkeFK_ACObjectID.EditValue.ToString();
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            ACObjectsInfo objObjectsInfo = new ACObjectsInfo();
            if (!String.IsNullOrEmpty(objectAccessKey))
            {
                ACObjectsController objObjectsController = new ACObjectsController();
                objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            }
            ARAcceptancesController objAcceptancesController = new ARAcceptancesController();
            List<ARAcceptancesInfo> acceptancesList = objAcceptancesController.getAcceptanceForMultiPrint(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType, fromDate, toDate);
            AcceptancesInfoList.Invalidate(acceptancesList);
            AcceptancesInfoList.GridControl.RefreshDataSource();
        }

    }
}
