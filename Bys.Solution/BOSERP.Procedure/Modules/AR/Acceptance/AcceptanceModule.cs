using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Acceptance
{
    public class AcceptanceModule : BaseTransactionModule
    {
        #region Constants

        public const string AcceptanceItemsGridControlName = "fld_dgcAcceptanceItemsGridControl";

        public const string AcceptanceItemCostsGridControlName = "fld_dgcARAcceptanceItemCosts";

        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";

        public const string ModuleName = "Acceptance";

        public const int Currency_VND = 100000;

        public const string TemplateControlName = "fld_lkeFK_MMProductionNormID";

        #endregion

        #region Public properties

        public AcceptanceItemsGridControl AcceptanceItemsGridControl;

        #endregion

        #region Public properties

        public BOSLookupEdit SearchBranchLookupEditControl;

        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;

        public List<BRBranchsInfo> BranchList;

        public BOSLookupEdit TemplateLookUpEditControl;

        #endregion

        public AcceptanceModule()
        {
            Name = ModuleName;
            CurrentModuleEntity = new AcceptanceEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;

            AcceptanceItemsGridControl = (AcceptanceItemsGridControl)Controls[AcceptanceItemsGridControlName];
            TemplateLookUpEditControl = (BOSLookupEdit)Controls[TemplateControlName];
            SetReadOnlyControl(TemplateLookUpEditControl, true);
        }

        public void SetReadOnlyControl(object control, bool isReadOnly)
        {
            (control as BOSLookupEdit).ReadOnly = isReadOnly;
        }

        public void GetCurrentModuleDataViewPermission()
        {
            CurrentModuleDataViewPermissionList = BOSApp.CurrentADDataViewPermissionList.Where(i => i.STModuleName == Name && i.ADDataViewPermissionType == ADDataViewPermissionType.Module).ToList();

            List<int> branchIDList = new List<int>();
            foreach (ADDataViewPermissionsInfo dataViewPermissionsInfo in CurrentModuleDataViewPermissionList)
            {
                branchIDList.Add(dataViewPermissionsInfo.FK_BRBranchID);
            }

            if (branchIDList.Count == 0)
            {
                BranchList = new List<BRBranchsInfo>();
            }
            else
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                List<BRBranchsInfo> branchList = objBranchsController.GetAllBranches();

                BranchList = branchList.Where(i => branchIDList.IndexOf(i.BRBranchID) > -1).ToList();
            }
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ARAcceptancesController objAcceptancesController = new ARAcceptancesController();
            ARAcceptancesInfo searchObject = (ARAcceptancesInfo)CurrentModuleEntity.SearchObject;

            DataSet ds;
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objAcceptancesController.GetDataSetByID(-1);
                }
                else
                {

                    ds = objAcceptancesController.GetAcceptancesListByListOfBranchIDs(
                                                                            searchObject.ARAcceptanceNo,
                                                                            searchObject.ARAcceptanceName,
                                                                            searchObject.FK_HREmployeeID,
                                                                            searchObject.ARAcceptanceDateFrom,
                                                                            searchObject.ARAcceptanceDateTo,
                                                                            searchObject.FK_BRBranchID,
                                                                            BranchList);
                }
            }
            else
            {
                ds = objAcceptancesController.GetAcceptancesListByBranchID(
                                                                    searchObject.ARAcceptanceNo,
                                                                    searchObject.ARAcceptanceName,
                                                                    searchObject.FK_HREmployeeID,
                                                                    searchObject.ARAcceptanceDateFrom,
                                                                    searchObject.ARAcceptanceDateTo,
                                                                    searchObject.FK_BRBranchID);
            }

            return ds;
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            ARAcceptancesInfo objAcceptancesInfo = (ARAcceptancesInfo)entity.MainObject;

            if (objAcceptancesInfo.ARAcceptanceID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                if (objAcceptancesInfo.ARAcceptanceStatus == AcceptanceStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                }
            }
        }

        public override void ActionNew()
        {
            base.ActionNew();

            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            ARAcceptancesInfo objAcceptancesInfo = (ARAcceptancesInfo)entity.MainObject;
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            List<ARSaleOrderItemsInfo> saleOrderItemList = objSaleOrderItemsController.GetSaleOrderItemForAcceptancesByUserPermission(BOSApp.CurrentUsersInfo.ADUserID,
                                                                                        ModuleName,
                                                                                        ADDataViewPermissionType.Module);

            guiFind<ARSaleOrderItemsInfo> guiSaleOrderItems = new guiFind<ARSaleOrderItemsInfo>(TableName.ARSaleOrderItemsTableName,
                                                                saleOrderItemList, this, true, true, new string[] { "FK_ARSaleOrderID" });
            if (guiSaleOrderItems.ShowDialog() != DialogResult.OK)
            {
                ActionCancel();
                return;
            }
            List<ARSaleOrderItemsInfo> results = (List<ARSaleOrderItemsInfo>)guiSaleOrderItems.SelectedObjects;
            if (results.Count == 0) return;

            if (results.Select(o => o.FK_ARSaleOrderID).Distinct().Count() > 1)
            {
                MessageBox.Show(AcceptanceLocalizedResources.AcceptancelsHaveNotSameCustomerMessage,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                ActionCancel();
                ActionNew();
                return;
            }

            ARSaleOrderItemsInfo defaultSaleOrderItemsInfo = results.FirstOrDefault();
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(defaultSaleOrderItemsInfo.FK_ARSaleOrderID);
            objAcceptancesInfo.ACObjectAccessKey = string.Join(";", new string[] { defaultSaleOrderItemsInfo.FK_ACObjectID.ToString(), defaultSaleOrderItemsInfo.ARObjectType });
            objAcceptancesInfo.FK_ARSaleOrderID = defaultSaleOrderItemsInfo.FK_ARSaleOrderID;
            objAcceptancesInfo.ARAcceptanceReference = string.Join(";", results.Select(o => o.ARSaleOrderNo).Distinct().ToArray());
            objAcceptancesInfo.ARAcceptancePONo = defaultSaleOrderItemsInfo.ARSaleOrderSaleAgreement;
            objAcceptancesInfo.FK_PMProjectID = objSaleOrdersInfo.FK_PMProjectID;
            objAcceptancesInfo.ARAcceptanceIsReceiveBill = objSaleOrdersInfo.ARSaleOrderIsReceiveBill;
            objAcceptancesInfo.FK_ARSaleContractID = objSaleOrdersInfo.FK_ARSaleContractID;
            objAcceptancesInfo.FK_ACCostCenterID = defaultSaleOrderItemsInfo.FK_ACCostCenterID;
            objAcceptancesInfo.FK_PMTemplateID = defaultSaleOrderItemsInfo.FK_PMTemplateID;
            objAcceptancesInfo.FK_ARInvoiceRequestID = objSaleOrdersInfo.FK_ARInvoiceRequestID;
            entity.GenerateAcceptanceItemsFromSaleOrderItems(results);
            if (objSaleOrdersInfo != null)
            {
                objAcceptancesInfo.ARAcceptanceSubTotalAmount = entity.AcceptanceItemsList.Sum(p => p.ARAcceptanceItemTotalAmount);

                objAcceptancesInfo.ARAcceptanceDiscountPerCent = objSaleOrdersInfo.ARSaleOrderDiscountPerCent;
                objAcceptancesInfo.ARAcceptanceTaxPercent = objSaleOrdersInfo.ARSaleOrderTaxPercent;

                objAcceptancesInfo.ARAcceptanceDiscountFix = objAcceptancesInfo.ARAcceptanceSubTotalAmount * objAcceptancesInfo.ARAcceptanceDiscountPerCent / 100;
                objAcceptancesInfo.ARAcceptanceDiscountFix = Math.Round(objAcceptancesInfo.ARAcceptanceDiscountFix, 3, MidpointRounding.AwayFromZero);

                objAcceptancesInfo.ARAcceptanceTaxAmount = (objAcceptancesInfo.ARAcceptanceSubTotalAmount - objAcceptancesInfo.ARAcceptanceDiscountFix + objAcceptancesInfo.ARAcceptanceTotalCost) * objAcceptancesInfo.ARAcceptanceTaxPercent / 100;
                objAcceptancesInfo.ARAcceptanceTaxAmount = Math.Round(objAcceptancesInfo.ARAcceptanceTaxAmount, 3, MidpointRounding.AwayFromZero);

                objAcceptancesInfo.ARAcceptanceTotalAmount = objAcceptancesInfo.ARAcceptanceSubTotalAmount - objAcceptancesInfo.ARAcceptanceDiscountFix + objAcceptancesInfo.ARAcceptanceTaxAmount;
                objAcceptancesInfo.ARAcceptanceDepositBalance = objSaleOrdersInfo.ARSaleOrderDepositBalance;
            }
            ARCustomerPaymentTimePaymentsController objCustomerPaymentsController = new ARCustomerPaymentTimePaymentsController();
            List<ARCustomerPaymentTimePaymentsInfo> customerPaymentList = objCustomerPaymentsController.GetCustomerPaymentTimeBySaleOrderID(objAcceptancesInfo.FK_ARSaleOrderID);
            if (customerPaymentList.Count > 0) objAcceptancesInfo.ARCustomerPaymentTimePayment1 = customerPaymentList[0].ARCustomerPaymentTimePaymentAmount;
            objAcceptancesInfo.ARCustomerPaymentTimePayment2 = customerPaymentList.Sum(p => p.ARCustomerPaymentTimePaymentAmount) - objAcceptancesInfo.ARCustomerPaymentTimePayment1;
            objAcceptancesInfo.ARAcceptanceRemainedAmount = objAcceptancesInfo.ARAcceptanceTotalAmount - objAcceptancesInfo.ARAcceptanceDepositBalance - objAcceptancesInfo.ARCustomerPaymentTimePayment1 - objAcceptancesInfo.ARCustomerPaymentTimePayment2;

            GenerateAcceptanceItemCost(results.Select(o => o.FK_ARSaleOrderID).Distinct().ToList());
            entity.AcceptanceItemsList.GridControl.RefreshDataSource();
            entity.AcceptanceItemCostsList.GridControl.RefreshDataSource();
            objAcceptancesInfo.ARAcceptanceTotalCost = entity.AcceptanceItemCostsList.Sum(o => o.ARAcceptanceItemWorkTotalAmount);
            UpdateTotalAmount();
            entity.UpdateMainObjectBindingSource();
            entity.AcceptanceItemsList.GridControl.RefreshDataSource();
        }

        private void GenerateAcceptanceItemCost(List<int> saleOrders)
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            ARSaleOrderItemWorksController controller = new ARSaleOrderItemWorksController();
            List<ARSaleOrderItemWorksInfo> costs = new List<ARSaleOrderItemWorksInfo>();
            saleOrders.ForEach(o => costs = costs.Union(controller.GetSaleOrderItemWorksForAcceptance(o)).ToList());
            entity.GenerateAcceptanceItemCostsFromSaleOrderItemCosts(costs);
        }

        public void DeleteItemAcceptanceItemCostsList()
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            entity.AcceptanceItemCostsList.RemoveSelectedRowObjectFromList();
        }

        public void ChangeCostDiscountPercent()
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            if (entity.AcceptanceItemCostsList.CurrentIndex < 0)
                return;
            ARAcceptanceItemWorksInfo item = entity.AcceptanceItemCostsList[entity.AcceptanceItemCostsList.CurrentIndex];
            item.ARAcceptanceItemWorkDiscountAmount = Math.Round(item.ARAcceptanceItemWorkSubTotalAmount * item.ARAcceptanceItemWorkDiscountPercent / 100, 3, MidpointRounding.AwayFromZero);
            UpdateAcceptanceItemTotalAmount(item);
            UpdateTotalAmount();
            entity.AcceptanceItemCostsList.GridControl.RefreshDataSource();
        }

        public void ChangeCostDiscountAmount()
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            if (entity.AcceptanceItemCostsList.CurrentIndex < 0)
                return;
            ARAcceptanceItemWorksInfo item = entity.AcceptanceItemCostsList[entity.AcceptanceItemCostsList.CurrentIndex];

            if (item.ARAcceptanceItemWorkDiscountAmount == 0 || item.ARAcceptanceItemWorkSubTotalAmount == 0)
                item.ARAcceptanceItemWorkDiscountPercent = 0;
            else
                item.ARAcceptanceItemWorkDiscountPercent = (item.ARAcceptanceItemWorkDiscountAmount / item.ARAcceptanceItemWorkSubTotalAmount) * 100;
            UpdateAcceptanceItemTotalAmount(item);
            UpdateTotalAmount();
            entity.AcceptanceItemCostsList.GridControl.RefreshDataSource();
        }

        public void ChangeCostTaxPercent()
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            if (entity.AcceptanceItemCostsList.CurrentIndex < 0)
                return;
            ARAcceptanceItemWorksInfo item = entity.AcceptanceItemCostsList[entity.AcceptanceItemCostsList.CurrentIndex];
            item.ARAcceptanceItemWorkDiscountAmount = Math.Round((item.ARAcceptanceItemWorkSubTotalAmount - item.ARAcceptanceItemWorkDiscountAmount) * item.ARAcceptanceItemWorkDiscountPercent / 100, 3, MidpointRounding.AwayFromZero);
            UpdateAcceptanceItemTotalAmount(item);
            UpdateTotalAmount();
            entity.AcceptanceItemCostsList.GridControl.RefreshDataSource();
        }

        public void ChangeCostTaxAmount()
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            if (entity.AcceptanceItemCostsList.CurrentIndex < 0)
                return;
            ARAcceptanceItemWorksInfo item = entity.AcceptanceItemCostsList[entity.AcceptanceItemCostsList.CurrentIndex];

            if (item.ARAcceptanceItemWorkTaxAmount == 0 || item.ARAcceptanceItemWorkSubTotalAmount == 0 || (item.ARAcceptanceItemWorkSubTotalAmount - item.ARAcceptanceItemWorkDiscountAmount == 0))
                item.ARAcceptanceItemWorkTaxPercent = 0;
            else
                item.ARAcceptanceItemWorkTaxPercent = (item.ARAcceptanceItemWorkTaxAmount / (item.ARAcceptanceItemWorkSubTotalAmount - item.ARAcceptanceItemWorkDiscountAmount)) * 100;
            UpdateAcceptanceItemTotalAmount(item);
            UpdateTotalAmount();
            entity.AcceptanceItemCostsList.GridControl.RefreshDataSource();
        }

        public void UpdateCostItemAmount()
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            if (entity.AcceptanceItemCostsList.CurrentIndex < 0)
                return;
            ARAcceptanceItemWorksInfo item = entity.AcceptanceItemCostsList[entity.AcceptanceItemCostsList.CurrentIndex];
            item.ARAcceptanceItemWorkSubTotalAmount = item.ARAcceptanceItemWorkTotalAmount - item.ARAcceptanceItemWorkDiscountAmount + item.ARAcceptanceItemWorkTaxAmount;
        }

        public void ChangeCostQty()
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            if (entity.AcceptanceItemCostsList.CurrentIndex < 0)
                return;
            ARAcceptanceItemWorksInfo item = entity.AcceptanceItemCostsList[entity.AcceptanceItemCostsList.CurrentIndex];
            item.ARAcceptanceItemWorkSubTotalAmount = item.ARAcceptanceItemWorkProductUnitPrice * item.ARAcceptanceItemWorkProductQty;
            UpdateAcceptanceItemTotalAmount(item);
            UpdateTotalAmount();
            entity.AcceptanceItemCostsList.GridControl.RefreshDataSource();
        }

        public void UpdateAcceptanceItemTotalAmount(ARAcceptanceItemWorksInfo objAcceptanceItemWorksInfo)
        {
            objAcceptanceItemWorksInfo.ARAcceptanceItemWorkDiscountAmount = objAcceptanceItemWorksInfo.ARAcceptanceItemWorkSubTotalAmount * objAcceptanceItemWorksInfo.ARAcceptanceItemWorkDiscountPercent / 100;
            objAcceptanceItemWorksInfo.ARAcceptanceItemWorkTaxAmount = (objAcceptanceItemWorksInfo.ARAcceptanceItemWorkSubTotalAmount - objAcceptanceItemWorksInfo.ARAcceptanceItemWorkDiscountAmount) * objAcceptanceItemWorksInfo.ARAcceptanceItemWorkTaxPercent / 100;
            objAcceptanceItemWorksInfo.ARAcceptanceItemWorkTotalAmount = objAcceptanceItemWorksInfo.ARAcceptanceItemWorkSubTotalAmount - objAcceptanceItemWorksInfo.ARAcceptanceItemWorkDiscountAmount + objAcceptanceItemWorksInfo.ARAcceptanceItemWorkTaxAmount;
        }

        public void DeleteItemFromAcceptanceItemsList()
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            entity.AcceptanceItemsList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        private void InitSaleOrderAcceptanceReport(RP_Acceptance report)
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            ARAcceptancesInfo objAcceptancesInfo = (ARAcceptancesInfo)entity.MainObject;

            ARAcceptanceItemsController controller = new ARAcceptanceItemsController();
            List<ARAcceptanceItemsInfo> acceptanceItems = controller.GetAcceptanceItemsForReportByAcceptanceID(objAcceptancesInfo.ARAcceptanceID);
            acceptanceItems = acceptanceItems.OrderBy(x => x.ICDepartmentName).ToList();

            int departmentRowNumber = 0;
            int rowNumber = 0;
            string oldDepartmentName = String.Empty;
            String proposalName = string.Empty;

            acceptanceItems.ForEach(o =>
            {
                if (objAcceptancesInfo.ARAcceptanceStatus != "Complete") o.ARAcceptanceItemProductQtyText = String.Empty;
                else o.ARAcceptanceItemProductQtyText = o.ARAcceptanceItemProductQty.ToString();
                if (o.ICDepartmentName != oldDepartmentName)
                {
                    departmentRowNumber++;
                    oldDepartmentName = o.ICDepartmentName;
                    rowNumber = 0;
                }
                o.RowNumber = departmentRowNumber.ToString() + "." + (++rowNumber).ToString();
                o.DepartmentRowNumber = departmentRowNumber.ToString();
            });
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            proposalName = objSaleOrdersController.GetProposalNameBySaleOrderID(objAcceptancesInfo.FK_ARSaleOrderID);

            if (!string.IsNullOrEmpty(proposalName))
            {
                acceptanceItems.ForEach(p =>
                {
                    p.ARProposalName = proposalName;
                });
            }

            report.bsARAcceptances.DataSource = acceptanceItems;
            CSCompanysController objCompanyController = new CSCompanysController();
            CSCompanysInfo objCompanysInfo = (CSCompanysInfo)objCompanyController.GetObjectByID(1);
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objAcceptancesInfo.FK_ACObjectID, objAcceptancesInfo.ARObjectType);
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
                ARAcceptancesController objAcceptancesController = new ARAcceptancesController();
                lblSaleOrderNo.Text = objAcceptancesInfo.ARAcceptanceReference;
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
            GroupHeaderBand groupHeader2 = (GroupHeaderBand)report.Bands["GroupHeader2"];
            if (!string.IsNullOrEmpty(proposalName))
            {
                groupHeader2.Visible = true;
            }
            else groupHeader2.Visible = false;
        }

        public void PrintAcceptanceDocument()
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            ARAcceptancesInfo objAcceptancesInfo = (ARAcceptancesInfo)entity.MainObject;
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RP_Acceptance rpAcceptance = new RP_Acceptance();
                InitSaleOrderAcceptanceReport(rpAcceptance);
                guiReportPreview reviewer = new guiReportPreview(rpAcceptance);
                reviewer.Show();
            }
        }

        public void PrintBalanceSheet()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RP_BanlanceSheet rpBalanceSheet = new RP_BanlanceSheet();
                InitSaleOrderAcceptanceReport(rpBalanceSheet);
                guiReportPreview reviewer = new guiReportPreview(rpBalanceSheet);
                reviewer.Show();
            }
        }

        public void PrintMultiAcceptance()
        {
            guiPrintMultiAcceptances gui = new guiPrintMultiAcceptances();
            gui.Module = this;
            gui.type = "Acceptance";
            gui.Show();
        }

        public void PrintMultiBalanceSheet()
        {
            guiPrintMultiAcceptances gui = new guiPrintMultiAcceptances();
            gui.Module = this;
            gui.type = "BalanceSheet";
            gui.Show();
        }

        public void InitSaleOrderAcceptanceReport(RP_BanlanceSheet rpBalanceSheet)
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            ARAcceptancesController objAcceptancesController = new ARAcceptancesController();
            ARAcceptancesInfo mainObject = (ARAcceptancesInfo)entity.MainObject;
            ARAcceptancesInfo objAcceptancesInfo = (ARAcceptancesInfo)objAcceptancesController.GetObjectByID((mainObject).ARAcceptanceID);
            ARAcceptanceItemsController objAcceptanceItemsController = new ARAcceptanceItemsController();
            List<ARAcceptanceItemsInfo> acceptanceItemsPrintList = objAcceptanceItemsController.GetAcceptanceItemsByAcceptanceIDToBalanceSheetReport(objAcceptancesInfo.ARAcceptanceID);
            String ARProposalName = string.Empty;
            objAcceptancesInfo.ARAcceptanceTotalItemPrice = 0;
            objAcceptancesInfo.ARAcceptanceTotalItemDiscountAmount = 0;
            int departmentRowNumber = 0;
            int rowNumber = 0;
            string oldDepartmentName = String.Empty;

            objAcceptancesInfo.ARAcceptanceTotalItemPrice = 0;
            objAcceptancesInfo.ARAcceptanceTotalItemDiscountAmount = 0;
            acceptanceItemsPrintList.ForEach(p =>
            {
                objAcceptancesInfo.ARAcceptanceTotalItemPrice += p.ARAcceptanceItemPrice;
                objAcceptancesInfo.ARAcceptanceTotalItemDiscountAmount += p.ARAcceptanceItemDiscountAmount;
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
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARProposalName = objSaleOrdersController.GetProposalNameBySaleOrderID(objAcceptancesInfo.FK_ARSaleOrderID);

            if (!string.IsNullOrEmpty(ARProposalName))
            {
                acceptanceItemsPrintList.ForEach(p =>
                {
                    p.ARProposalName = ARProposalName;
                });
            }
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objAcceptancesInfo.FK_ACObjectID, objAcceptancesInfo.ARObjectType);
            ARCustomerPaymentTimePaymentsController objCustomerPaymentTimePaymentsController = new ARCustomerPaymentTimePaymentsController();
            List<ARCustomerPaymentTimePaymentsInfo> customerPaymentTimePaymentsList = objCustomerPaymentTimePaymentsController.GetCustomerPaymentTimeBySaleOrderID(objAcceptancesInfo.FK_ARSaleOrderID);
            if (customerPaymentTimePaymentsList != null && customerPaymentTimePaymentsList.Count > 0)
            {
                objAcceptancesInfo.ARCustomerPaymentTimePayment1 = customerPaymentTimePaymentsList[0].ARCustomerPaymentTimePaymentAmount;
                objAcceptancesInfo.ARCustomerPaymentTimePayment2 = customerPaymentTimePaymentsList.Sum(p => p.ARCustomerPaymentTimePaymentAmount) - objAcceptancesInfo.ARCustomerPaymentTimePayment1;
            }
            objAcceptancesInfo.ARAcceptanceRemainedAmount = objAcceptancesInfo.ARAcceptanceTotalAmount - objAcceptancesInfo.ARCustomerPaymentTimePayment1 - objAcceptancesInfo.ARCustomerPaymentTimePayment2;
            rpBalanceSheet.bsACObjects.DataSource = objObjectsInfo;
            rpBalanceSheet.bsARAcceptances.DataSource = objAcceptancesInfo;
            rpBalanceSheet.bsARAcceptanceItems.DataSource = acceptanceItemsPrintList;
            XRLabel saleOrderPONoLabel = (XRLabel)rpBalanceSheet.Bands[BandKind.ReportHeader].Controls["xr_lblSaleOrderNo"];
            if (saleOrderPONoLabel != null) saleOrderPONoLabel.Text = objAcceptancesInfo.ARAcceptanceReference;
            XRLabel printDateLabel = (XRLabel)rpBalanceSheet.Bands[BandKind.ReportFooter].Controls["xr_lblPrintDate"];
            if (printDateLabel != null) printDateLabel.Text = string.Format("Ngày {0} tháng {1} năm {2}", BOSApp.GetCurrentServerDate().ToString("dd"), BOSApp.GetCurrentServerDate().ToString("MM"), BOSApp.GetCurrentServerDate().ToString("yyyy"));
            XRLabel createdEmployeeLabel = (XRLabel)rpBalanceSheet.Bands[BandKind.ReportFooter].Controls["xr_lblEmployeeName"];
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objCreatedEmployee = !string.IsNullOrEmpty(objAcceptancesInfo.AACreatedUser) ? objEmployeesController.GetEmployeeByUserName(objAcceptancesInfo.AACreatedUser) : objEmployeesController.GetEmployeeByUserName(BOSApp.CurrentUser);
            createdEmployeeLabel.Text = objCreatedEmployee != null ? objCreatedEmployee.HREmployeeName : "";
            GroupHeaderBand groupHeader2 = (GroupHeaderBand)rpBalanceSheet.Bands["GroupHeader2"];
            if (!string.IsNullOrEmpty(ARProposalName))
            {
                groupHeader2.Visible = true;
            }
            else groupHeader2.Visible = false;
        }

        public void ShowMaterialShipment()
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            ARAcceptancesInfo objAcceptancesInfo = (ARAcceptancesInfo)entity.MainObject;
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();

            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            entity.AcceptanceItemsList.Select(o => o.FK_ARSaleOrderID)
                                      .Distinct()
                                      .ToList()
                                      .ForEach(o => shipmentItemList = shipmentItemList.Union(objShipmentItemsController.GetShipmentItemForAcceptance(o)).ToList());

            guiFind<ICShipmentItemsInfo> guiShipmentItems = new guiFind<ICShipmentItemsInfo>(TableName.ICShipmentItemsTableName,
                                                                shipmentItemList, this, true, true, new string[] { "ICDepartmentName" });
            guiShipmentItems.Module = this;
            if (guiShipmentItems.ShowDialog() != DialogResult.OK)
                return;

            List<ICShipmentItemsInfo> results = (List<ICShipmentItemsInfo>)guiShipmentItems.SelectedObjects;
            if (results.Count == 0) return;
            entity.GenerateAcceptanceItem(results);
            UpdateTotalAmount();
            entity.AcceptanceItemsList.GridControl.RefreshDataSource();
        }

        public void ChangeItemQty()
        {
            ChangeItemProductSize();
            UpdateTotalAmount();
        }

        public void UpdateTotalAmount()
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            ARAcceptancesInfo objAcceptancesInfo = (ARAcceptancesInfo)entity.MainObject;
            objAcceptancesInfo.ARAcceptanceSubTotalAmount = 0;
            objAcceptancesInfo.ARAcceptanceTotalAmount = 0;
            objAcceptancesInfo.ARAcceptanceTotalItemPrice = 0;
            objAcceptancesInfo.ARAcceptanceTotalCost = 0;
            objAcceptancesInfo.ARAcceptanceTotalItemDiscountAmount = 0;
            entity.AcceptanceItemsList.ForEach(o =>
            {
                o.ARAcceptanceItemPrice = o.ARAcceptanceItemProductQty * o.ARAcceptanceItemProductUnitPrice;
                o.ARAcceptanceItemDiscountAmount = (o.ARAcceptanceItemPrice * o.ARAcceptanceItemProductDiscount) / 100;
                o.ARAcceptanceItemTaxAmount = (o.ARAcceptanceItemPrice - o.ARAcceptanceItemDiscountAmount) * o.ARAcceptanceItemProductTaxPercent / 100;
                o.ARAcceptanceItemTotalAmount = o.ARAcceptanceItemPrice + o.ARAcceptanceItemTaxAmount - o.ARAcceptanceItemDiscountAmount;
                objAcceptancesInfo.ARAcceptanceSubTotalAmount += o.ARAcceptanceItemTotalAmount;
                objAcceptancesInfo.ARAcceptanceTotalItemPrice += o.ARAcceptanceItemPrice;
                objAcceptancesInfo.ARAcceptanceTotalItemDiscountAmount += o.ARAcceptanceItemDiscountAmount;
                //objAcceptancesInfo.ARAcceptanceTotalAmount += o.ARAcceptanceItemTotalAmount;
            });
            entity.AcceptanceItemCostsList.ForEach(p =>
            {
                p.ARAcceptanceItemWorkSubTotalAmount = p.ARAcceptanceItemWorkProductUnitPrice * p.ARAcceptanceItemWorkProductQty;
                p.ARAcceptanceItemWorkDiscountAmount = p.ARAcceptanceItemWorkDiscountPercent * p.ARAcceptanceItemWorkSubTotalAmount / 100;
                p.ARAcceptanceItemWorkTaxAmount = (p.ARAcceptanceItemWorkSubTotalAmount - p.ARAcceptanceItemWorkDiscountAmount) * p.ARAcceptanceItemWorkTaxPercent / 100;
                p.ARAcceptanceItemWorkTotalAmount = p.ARAcceptanceItemWorkSubTotalAmount - p.ARAcceptanceItemWorkDiscountAmount + p.ARAcceptanceItemWorkTaxAmount;
                objAcceptancesInfo.ARAcceptanceTotalCost += p.ARAcceptanceItemWorkTotalAmount;
                objAcceptancesInfo.ARAcceptanceTotalItemPrice += p.ARAcceptanceItemWorkSubTotalAmount;
                objAcceptancesInfo.ARAcceptanceTotalItemDiscountAmount += p.ARAcceptanceItemWorkDiscountAmount;
            });
            objAcceptancesInfo.ARAcceptanceDiscountFix = objAcceptancesInfo.ARAcceptanceSubTotalAmount * objAcceptancesInfo.ARAcceptanceDiscountPerCent / 100;
            objAcceptancesInfo.ARAcceptanceDiscountFix = Math.Round(objAcceptancesInfo.ARAcceptanceDiscountFix, 3, MidpointRounding.AwayFromZero);

            objAcceptancesInfo.ARAcceptanceTaxAmount = (objAcceptancesInfo.ARAcceptanceSubTotalAmount - objAcceptancesInfo.ARAcceptanceDiscountFix + objAcceptancesInfo.ARAcceptanceTotalCost) * objAcceptancesInfo.ARAcceptanceTaxPercent / 100;
            objAcceptancesInfo.ARAcceptanceTaxAmount = Math.Round(objAcceptancesInfo.ARAcceptanceTaxAmount, 3, MidpointRounding.AwayFromZero);

            objAcceptancesInfo.ARAcceptanceTotalAmount = objAcceptancesInfo.ARAcceptanceSubTotalAmount - objAcceptancesInfo.ARAcceptanceDiscountFix + +objAcceptancesInfo.ARAcceptanceTaxAmount + objAcceptancesInfo.ARAcceptanceTotalCost;
            entity.UpdateMainObjectBindingSource();
            entity.AcceptanceItemsList.GridControl.RefreshDataSource();
        }

        public void ChangeDiscountPercent()
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            ARAcceptancesInfo mainobject = (ARAcceptancesInfo)entity.MainObject;
            mainobject.ARAcceptanceDiscountFix = mainobject.ARAcceptanceSubTotalAmount * mainobject.ARAcceptanceDiscountPerCent / 100;
            UpdateTotalAmount();
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeDiscountAmount()
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            ARAcceptancesInfo mainobject = (ARAcceptancesInfo)entity.MainObject;
            if (mainobject.ARAcceptanceSubTotalAmount != 0)
            {
                mainobject.ARAcceptanceDiscountPerCent = mainobject.ARAcceptanceDiscountFix * 100 / mainobject.ARAcceptanceSubTotalAmount;
            }
            UpdateTotalAmount();
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeTaxPercent()
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            ARAcceptancesInfo mainobject = (ARAcceptancesInfo)entity.MainObject;
            mainobject.ARAcceptanceTaxAmount = (mainobject.ARAcceptanceSubTotalAmount - mainobject.ARAcceptanceDiscountFix + mainobject.ARAcceptanceTotalCost) * mainobject.ARAcceptanceTaxPercent / 100;
            UpdateTotalAmount();
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeTaxAmount()
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            ARAcceptancesInfo mainobject = (ARAcceptancesInfo)entity.MainObject;
            if ((mainobject.ARAcceptanceSubTotalAmount - mainobject.ARAcceptanceDiscountFix + mainobject.ARAcceptanceTotalCost) != 0)
            {
                mainobject.ARAcceptanceTaxPercent = mainobject.ARAcceptanceTaxAmount * 100 / (mainobject.ARAcceptanceSubTotalAmount - mainobject.ARAcceptanceDiscountFix + mainobject.ARAcceptanceTotalCost);
            }
            UpdateTotalAmount();
            entity.UpdateMainObjectBindingSource();
        }

        public void ChooseShipmentItems()
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            ARAcceptancesInfo mainobject = (ARAcceptancesInfo)entity.MainObject;
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItemList = objShipmentItemsController.GetShipmentItemBySaleOrderID(mainobject.FK_ARSaleOrderID);
            entity.AcceptanceItemsList.ForEach(o =>
            {
                shipmentItemList.RemoveAll(o1 => o1.FK_ARSaleOrderItemID == o.FK_ARSaleOrderItemID);
            });
            guiChooseShipmentItems guiFind = new guiChooseShipmentItems(shipmentItemList);
            guiFind.Module = this;
            DialogResult rs = guiFind.ShowDialog();
            if (rs != DialogResult.OK)
                return;

            shipmentItemList = guiFind.SelectedObjects;
            entity.GenerateAcceptanceItem(shipmentItemList);
            UpdateTotalAmount();
            entity.AcceptanceItemsList.GridControl.RefreshDataSource();
        }

        public List<ICProductsInfo> GetAllSectionProductForLookUp()
        {
            ARAcceptancesInfo mainObject = (ARAcceptancesInfo)CurrentModuleEntity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> sectionProductList = objProductsController.GetSectionProductByTemplateID(mainObject.FK_PMTemplateID);
            return sectionProductList;
        }

        public void ShowTemplateItemTree()
        {
            //AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            //ARAcceptancesInfo mainobject = (ARAcceptancesInfo)entity.MainObject;
            //if (mainobject.FK_PMTemplateID == 0)
            //{
            //    MessageBox.Show(ProposalLocalizedResources.TemplateIsRequirer, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //ARAcceptanceItemsInfo objAcceptanceItemsInfo = (ARAcceptanceItemsInfo)entity.AcceptanceItemsList[entity.AcceptanceItemsList.CurrentIndex];
            //if (objAcceptanceItemsInfo == null)
            //    return;

            //guiShowTemplateItems guiShowTemplateItems = new guiShowTemplateItems();
            //guiShowTemplateItems.PMTemplateID = mainobject.FK_PMTemplateID;
            //guiShowTemplateItems.PMTemplateItemID = objAcceptanceItemsInfo.FK_PMTemplateItemID;
            //guiShowTemplateItems.PMTemplateItemProductName = objAcceptanceItemsInfo.PMTemplateItemProductName;
            //guiShowTemplateItems.Module = this;
            //DialogResult rs = guiShowTemplateItems.ShowDialog();
            //if (rs != DialogResult.OK)
            //    return;

            //objAcceptanceItemsInfo.FK_PMTemplateItemID = guiShowTemplateItems.PMTemplateItemID;
            //objAcceptanceItemsInfo.PMTemplateItemProductName = guiShowTemplateItems.PMTemplateItemProductName;

            //if (entity.AcceptanceItemsList.GridControl != null)
            //{
            //    entity.AcceptanceItemsList.EndCurrentEdit();
            //    entity.AcceptanceItemsList.GridControl.RefreshDataSource();
            //}
        }

        public void ChangeItemProductSize()
        {
            AcceptanceEntities entity = (AcceptanceEntities)CurrentModuleEntity;
            ARAcceptanceItemsInfo objAcceptanceItemsInfo = (ARAcceptanceItemsInfo)entity.AcceptanceItemsList[entity.AcceptanceItemsList.CurrentIndex];
            if (objAcceptanceItemsInfo == null)
                return;

            objAcceptanceItemsInfo.ARAcceptanceItemColumnChangedNames.Clear();
            if (objAcceptanceItemsInfo.ARAcceptanceItemLength != objAcceptanceItemsInfo.ARAcceptanceItemSOLength)
                objAcceptanceItemsInfo.ARAcceptanceItemColumnChangedNames.Add("ARAcceptanceItemLength");

            if (objAcceptanceItemsInfo.ARAcceptanceItemWidth != objAcceptanceItemsInfo.ARAcceptanceItemSOWidth)
                objAcceptanceItemsInfo.ARAcceptanceItemColumnChangedNames.Add("ARAcceptanceItemWidth");

            if (objAcceptanceItemsInfo.ARAcceptanceItemHeight != objAcceptanceItemsInfo.ARAcceptanceItemSOHeight)
                objAcceptanceItemsInfo.ARAcceptanceItemColumnChangedNames.Add("ARAcceptanceItemHeight");

            if (objAcceptanceItemsInfo.ARAcceptanceItemProductQty != objAcceptanceItemsInfo.ARAcceptanceItemSaleOrderQty)
                objAcceptanceItemsInfo.ARAcceptanceItemColumnChangedNames.Add("ARAcceptanceItemProductQty");

            entity.AcceptanceItemsList.GridControl.RefreshDataSource();

        }
    }
}
