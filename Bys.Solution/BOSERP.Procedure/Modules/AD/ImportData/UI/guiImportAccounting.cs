using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using BOSComponent;
using BOSCommon;
using BOSLib;
using BOSCommon.Constants;
using Localization;
using Microsoft.Office.Interop.Excel;

namespace BOSERP.Modules.ImportData
{
    /// <summary>
    /// Summary description for DMID101
    /// </summary>
    public partial class guiImportAccounting : BOSERPScreen
    {
        #region Private properties
        private string DataType;
        private string TableNameImport;
        private Range DataImport;
        private BOSGridControl GridControlResult;
        #endregion

        #region Data Import
        private BOSList<ACLoanAgreementsInfo> LoanAgreementsList { get; set; }  //Hợp đồng vay
        private BOSList<ACLoanReceiptsInfo> LoanReceiptsList { get; set; } // Khế ước vay
        private BOSList<ACListAccountBanksInfo> AccountBanksList { get; set; } // Danh sách tài khoản ngân hàng
        private BOSList<GEPaymentTermItemsInfo> PaymentTermItemsList { get; set; } // Điều khoản thanh toán
        #endregion

        #region Constructor
        public guiImportAccounting(string dataType, Range ds)
        {
            this.DataType = dataType;
            this.DataImport = ds;
            switch (this.DataType)
            {
                case "LoanAgreement":
                    TableNameImport = TableName.ACLoanAgreementsTableName;
                    break;

                case "LoanReceipt":
                    TableNameImport = TableName.ACLoanReceiptsTableName;
                    break;

                case "ListAccountBank":
                    TableNameImport = TableName.ACListAccountBanksTableName;
                    break;

                case "PaymentTerm":
                    TableNameImport = TableName.GEPaymentTermItemsTableName;
                    break;
            }
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void guiImportAccounting_Load(object sender, EventArgs e)
        {
            GridControlResult = BOSGridControl.Instance(TableNameImport, this.Module.Name);
            GridControlResult.Name = "fld_dgc" + TableNameImport;
            GridControlResult.Screen = this;
            GridControlResult.BOSDataSource = TableNameImport;
            GridControlResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            GridControlResult.Dock = DockStyle.Fill;
            GridControlResult.TabIndex = 0;
            GridControlResult.InitializeControl();
            GridControl.Controls.Add(GridControlResult);
        }
        #endregion

        #region Init BOS List
        public void InitBOSList()
        {
            ERPModuleEntities entity = (((BaseModuleERP)this.Module).CurrentModuleEntity);
            switch (this.DataType)
            {
                case "LoanAgreement":
                    LoanAgreementsList = new BOSList<ACLoanAgreementsInfo>();
                    LoanAgreementsList.InitBOSList(entity, null, TableNameImport,
                                                    BOSList<ACLoanAgreementsInfo>.cstRelationNone);
                    LoanAgreementsList.InitBOSListGridControl((BOSGridControl)this.GridControl.Controls["fld_dgc" + TableNameImport]);
                    LoanAgreementsList.SetDefaultListAndRefreshGridControl();
                    break;

                case "LoanReceipt":
                    LoanReceiptsList = new BOSList<ACLoanReceiptsInfo>();
                    LoanReceiptsList.InitBOSList(entity, null, TableNameImport,
                                                    BOSList<ACLoanReceiptsInfo>.cstRelationNone);
                    LoanReceiptsList.InitBOSListGridControl((BOSGridControl)this.GridControl.Controls["fld_dgc" + TableNameImport]);
                    LoanReceiptsList.SetDefaultListAndRefreshGridControl();
                    break;

                case "ListAccountBank":
                    AccountBanksList = new BOSList<ACListAccountBanksInfo>();
                    AccountBanksList.InitBOSList(entity, null, TableNameImport,
                                                    BOSList<ACListAccountBanksInfo>.cstRelationNone);
                    AccountBanksList.InitBOSListGridControl((BOSGridControl)this.GridControl.Controls["fld_dgc" + TableNameImport]);
                    AccountBanksList.SetDefaultListAndRefreshGridControl();
                    break;

                case "PaymentTerm":
                    PaymentTermItemsList = new BOSList<GEPaymentTermItemsInfo>();
                    PaymentTermItemsList.InitBOSList(entity, null, TableNameImport,
                                                    BOSList<GEPaymentTermItemsInfo>.cstRelationNone);
                    PaymentTermItemsList.InitBOSListGridControl((BOSGridControl)this.GridControl.Controls["fld_dgc" + TableNameImport]);
                    PaymentTermItemsList.SetDefaultListAndRefreshGridControl();
                    break;
            }
        }
        #endregion

        #region Init Data
        public void InitDataImport()
        {
            switch (this.DataType)
            {
                case "LoanAgreement":
                    InitDataLoanAgreement();
                    break;

                case "LoanReceipt":
                    InitDataLoanReceipt();
                    break;

                case "ListAccountBank":
                    InitDataListAccountBank();
                    break;

                case "PaymentTerm":
                    InitDataPaymentTerm();
                    break;
            }
        }

        private void InitDataLoanAgreement()
        {
            if (this.DataImport == null)
                return;

            ACLoanAgreementsInfo objLoanAgreementsInfo = new ACLoanAgreementsInfo();
            string cellValue = string.Empty;
            decimal value = 0;
            GECurrenciesInfo currenciesInfo;
            List<GECurrenciesInfo> listCurrenciesInfo = (new GECurrenciesController()).GetAllCurrencys();

            CSCompanyBanksInfo companyBanksInfo;
            List<CSCompanyBanksInfo> listCompanyBanksInfo = (new CSCompanyBanksController()).GetAllBanks();

            for (int row = 2; row <= DataImport.Rows.Count; row++)
            {
                objLoanAgreementsInfo = new ACLoanAgreementsInfo();
                objLoanAgreementsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                objLoanAgreementsInfo.ACLoanAgreementNo = (DataImport.Cells[row, 2] as Range).Text.ToString().Trim();
                if (string.IsNullOrWhiteSpace(objLoanAgreementsInfo.ACLoanAgreementNo))
                {
                    continue;
                }

                cellValue = (DataImport.Cells[row, 3] as Range).Text.ToString().Trim();
                companyBanksInfo = listCompanyBanksInfo.FirstOrDefault(o => o.CSCompanyBankName == cellValue);
                if (companyBanksInfo != null)
                {
                    objLoanAgreementsInfo.FK_CSCompanyBankID = companyBanksInfo.CSCompanyBankID;
                }

                cellValue = (DataImport.Cells[row, 4] as Range).Text.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objLoanAgreementsInfo.ACLoanAgreementDate = Convert.ToDateTime(cellValue);
                    }
                    catch (Exception ex) { }
                }

                cellValue = (DataImport.Cells[row, 5] as Range).Text.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objLoanAgreementsInfo.ACLoanAgreementDeadline = Convert.ToDateTime(cellValue);
                    }
                    catch (Exception ex) { }
                }

                cellValue = (DataImport.Cells[row, 6] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objLoanAgreementsInfo.ACLoanAgreementTotalLimit = Convert.ToDecimal(cellValue);
                    }
                    catch (Exception ex)
                    {
                        objLoanAgreementsInfo.ACLoanAgreementTotalLimit = 0;
                    }
                }

                cellValue = (DataImport.Cells[row, 7] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objLoanAgreementsInfo.ACLoanAgreementAmount = Convert.ToDecimal(cellValue);
                    }
                    catch (Exception ex)
                    {
                        objLoanAgreementsInfo.ACLoanAgreementAmount = 0;
                    }
                }

                cellValue = (DataImport.Cells[row, 8] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objLoanAgreementsInfo.ACLoanAgreementLCLimit = Convert.ToDecimal(cellValue);
                    }
                    catch (Exception ex)
                    {
                        objLoanAgreementsInfo.ACLoanAgreementLCLimit = 0;
                    }
                }

                cellValue = (DataImport.Cells[row, 9] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objLoanAgreementsInfo.ACLoanAgreementReceiptAmount = Convert.ToDecimal(cellValue);
                    }
                    catch (Exception ex)
                    {
                        objLoanAgreementsInfo.ACLoanAgreementReceiptAmount = 0;
                    }
                }

                cellValue = (DataImport.Cells[row, 10] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objLoanAgreementsInfo.ACLoanAgreementRemainAmount = Convert.ToDecimal(cellValue);
                    }
                    catch (Exception ex)
                    {
                        objLoanAgreementsInfo.ACLoanAgreementRemainAmount = 0;
                    }
                }

                cellValue = (DataImport.Cells[row, 11] as Range).Text.ToString().Trim();
                currenciesInfo = listCurrenciesInfo.FirstOrDefault(o => o.GECurrencyName == cellValue || o.GECurrencyNo == cellValue);
                if (currenciesInfo != null)
                {
                    objLoanAgreementsInfo.FK_GECurrencyID = currenciesInfo.GECurrencyID;
                }

                LoanAgreementsList.Add(objLoanAgreementsInfo);
            }
            if (LoanAgreementsList.GridControl != null)
            {
                LoanAgreementsList.GridControl.DataSource = LoanAgreementsList;
                LoanAgreementsList.GridControl.RefreshDataSource();
            }
        }

        private void InitDataLoanReceipt()
        {
            if (this.DataImport == null)
                return;

            ACLoanReceiptsInfo objLoanReceiptsInfo = new ACLoanReceiptsInfo();
            string cellValue = string.Empty;
            decimal value = 0;
            GECurrenciesInfo currenciesInfo;
            List<GECurrenciesInfo> listCurrenciesInfo = (new GECurrenciesController()).GetAllCurrencys();

            ACLoanAgreementsInfo objLoanAgreementsInfo;
            ACLoanAgreementsController objLoanAgreementsController = new ACLoanAgreementsController();
            List<ACLoanAgreementsInfo> listLoanAgreementsInfo = (List<ACLoanAgreementsInfo>)objLoanAgreementsController.GetListFromDataSet(objLoanAgreementsController.GetAllObjects());

            ACLoanReceiptTypesInfo objLoanReceiptTypesInfo;
            ACLoanReceiptTypesController objLoanReceiptTypesController = new ACLoanReceiptTypesController();
            List<ACLoanReceiptTypesInfo> listLoanReceiptTypesInfo = (List<ACLoanReceiptTypesInfo>)objLoanReceiptTypesController.GetListFromDataSet(objLoanReceiptTypesController.GetAllObjects());

            for (int row = 2; row <= DataImport.Rows.Count; row++)
            {
                objLoanReceiptsInfo = new ACLoanReceiptsInfo();
                objLoanReceiptsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                objLoanReceiptsInfo.ACLoanAgreementNo = (DataImport.Cells[row, 2] as Range).Text.ToString().Trim();
                if (string.IsNullOrWhiteSpace(objLoanReceiptsInfo.ACLoanAgreementNo))
                {
                    continue;
                }

                objLoanAgreementsInfo = listLoanAgreementsInfo.FirstOrDefault(o => o.ACLoanAgreementNo == objLoanReceiptsInfo.ACLoanAgreementNo);
                if(objLoanAgreementsInfo != null)
                {
                    objLoanReceiptsInfo.FK_ACLoanAgreementID = objLoanAgreementsInfo.ACLoanAgreementID;
                    objLoanReceiptsInfo.FK_CSCompanyBankID = objLoanAgreementsInfo.FK_CSCompanyBankID;
                    objLoanReceiptsInfo.FK_GECurrencyID = objLoanAgreementsInfo.FK_GECurrencyID;
                    objLoanReceiptsInfo.FK_PMProjectID = objLoanAgreementsInfo.FK_PMProjectID;
                }    
                objLoanReceiptsInfo.ACLoanReceiptNo = (DataImport.Cells[row, 3] as Range).Text.ToString().Trim();

                cellValue = (DataImport.Cells[row, 4] as Range).Text.ToString().Trim();
                objLoanReceiptTypesInfo = listLoanReceiptTypesInfo.FirstOrDefault(o => o.ACLoanReceiptTypeNanme == cellValue);
                if (objLoanReceiptTypesInfo != null)
                {
                    objLoanReceiptsInfo.FK_ACLoanReceiptTypeID = objLoanReceiptTypesInfo.ACLoanReceiptTypeID;
                }

                cellValue = (DataImport.Cells[row, 5] as Range).Text.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objLoanReceiptsInfo.ACLoanReceiptDate = Convert.ToDateTime(cellValue);
                    }
                    catch (Exception ex) { }
                }

                cellValue = (DataImport.Cells[row, 6] as Range).Text.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objLoanReceiptsInfo.ACLoanReceiptDeadline = Convert.ToDateTime(cellValue);
                    }
                    catch (Exception ex) { }
                }

                cellValue = (DataImport.Cells[row, 7] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objLoanReceiptsInfo.ACLoanReceiptLimit = Convert.ToInt32(cellValue);
                    }
                    catch (Exception ex)
                    {
                        objLoanReceiptsInfo.ACLoanReceiptLimit = 0;
                    }
                }

                cellValue = (DataImport.Cells[row, 8] as Range).Text.ToString().Trim();
                currenciesInfo = listCurrenciesInfo.FirstOrDefault(o => o.GECurrencyName == cellValue || o.GECurrencyNo == cellValue);
                if (currenciesInfo != null)
                {
                    objLoanReceiptsInfo.FK_GECurrencyID = currenciesInfo.GECurrencyID;
                }

                cellValue = (DataImport.Cells[row, 9] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objLoanReceiptsInfo.ACLoanReceiptExchangeRate = Convert.ToDecimal(cellValue);
                    }
                    catch (Exception ex)
                    {
                        objLoanReceiptsInfo.ACLoanReceiptExchangeRate = 1;
                    }
                }

                cellValue = (DataImport.Cells[row, 10] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objLoanReceiptsInfo.ACLoanReceiptInterestRate = Convert.ToDecimal(cellValue);
                    }
                    catch (Exception ex)
                    {
                        objLoanReceiptsInfo.ACLoanReceiptInterestRate = 0;
                    }
                }

                cellValue = (DataImport.Cells[row, 11] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objLoanReceiptsInfo.ACLoanReceiptOverdueInterestRate = Convert.ToDecimal(cellValue);
                    }
                    catch (Exception ex)
                    {
                        objLoanReceiptsInfo.ACLoanReceiptOverdueInterestRate = 0;
                    }
                }

                cellValue = (DataImport.Cells[row, 12] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objLoanReceiptsInfo.ACLoanReceiptAmount = Convert.ToDecimal(cellValue);
                        objLoanReceiptsInfo.ACLoanReceiptExchangeAmount = objLoanReceiptsInfo.ACLoanReceiptAmount * objLoanReceiptsInfo.ACLoanReceiptExchangeRate; ;
                    }
                    catch (Exception ex)
                    {
                        objLoanReceiptsInfo.ACLoanReceiptAmount = 0;
                    }
                }

                cellValue = (DataImport.Cells[row, 13] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objLoanReceiptsInfo.ACLoanReceiptExchangeAmount = Convert.ToDecimal(cellValue);
                    }
                    catch (Exception ex) {}
                }

                cellValue = (DataImport.Cells[row, 14] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objLoanReceiptsInfo.ACLoanReceiptOpeningPaidAmount = Convert.ToDecimal(cellValue);
                    }
                    catch (Exception ex)
                    {
                        objLoanReceiptsInfo.ACLoanReceiptOpeningPaidAmount = 0;
                    }
                }

                cellValue = (DataImport.Cells[row, 15] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objLoanReceiptsInfo.ACLoanReceiptRemainAmount = Convert.ToDecimal(cellValue);
                    }
                    catch (Exception ex)
                    {
                        objLoanReceiptsInfo.ACLoanReceiptRemainAmount = 0;
                    }
                }
                LoanReceiptsList.Add(objLoanReceiptsInfo);
            }
            if (LoanReceiptsList.GridControl != null)
            {
                LoanReceiptsList.GridControl.DataSource = LoanReceiptsList;
                LoanReceiptsList.GridControl.RefreshDataSource();
            }
        }

        private void InitDataListAccountBank()
        {
            if (this.DataImport == null)
                return;

            ACListAccountBanksInfo objAccountBanksInfo = new ACListAccountBanksInfo();
            string cellValue = string.Empty;
            decimal value = 0;
            GEStateProvincesInfo stateProvincesInfo;
            List<GEStateProvincesInfo> listStateProvincesInfo = (new GEStateProvincesController()).getAllAliveStateProvinces();

            ACObjectsInfo objectsInfo;

            for (int row = 2; row <= DataImport.Rows.Count; row++)
            {
                objAccountBanksInfo = new ACListAccountBanksInfo();
                objAccountBanksInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                objAccountBanksInfo.ACListAccountBankStatus = ListAccountBankStatus.Complete.ToString();
                objAccountBanksInfo.ACListAccountBankAccount = (DataImport.Cells[row, 2] as Range).Text.ToString().Trim();
                objAccountBanksInfo.ACListAccountBankSwiftCode = (DataImport.Cells[row, 3] as Range).Text.ToString().Trim();
                objAccountBanksInfo.ACListAccountBankName = (DataImport.Cells[row, 4] as Range).Text.ToString().Trim();
                objAccountBanksInfo.ACListAccountBankBranch = (DataImport.Cells[row, 5] as Range).Text.ToString().Trim();
                if (string.IsNullOrWhiteSpace(objAccountBanksInfo.ACListAccountBankName))
                {
                    continue;
                }
                cellValue = (DataImport.Cells[row, 6] as Range).Text.ToString().Trim();
                stateProvincesInfo = listStateProvincesInfo.FirstOrDefault(o => o.GEStateProvinceName == cellValue);
                if (stateProvincesInfo != null)
                {
                    objAccountBanksInfo.FK_ACListAccountBankBranchCityID = stateProvincesInfo.GEStateProvinceID;
                }

                cellValue = (DataImport.Cells[row, 7] as Range).Text.ToString().Trim();
                objectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectName == cellValue);
                if (objectsInfo != null)
                {
                    objAccountBanksInfo.FK_ACObjectID = objectsInfo.ACObjectID;
                    objAccountBanksInfo.ACObjectType = objectsInfo.ACObjectType;
                    objAccountBanksInfo.ACObjectAccessKey = objectsInfo.ACObjectID + ";" + objectsInfo.ACObjectType;
                }

                objAccountBanksInfo.ACListAccountBankAccountHolder = (DataImport.Cells[row, 8] as Range).Text.ToString().Trim();
                objAccountBanksInfo.ACListAccountBankAccountHolderIDNumber = (DataImport.Cells[row, 9] as Range).Text.ToString().Trim();

                cellValue = (DataImport.Cells[row, 10] as Range).Text.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objAccountBanksInfo.ACListAccountBankAccountHolderIDCardDate = Convert.ToDateTime(cellValue);
                    }
                    catch (Exception ex) { }
                }
                objAccountBanksInfo.ACListAccountBankAccountHolderCity = (DataImport.Cells[row, 11] as Range).Text.ToString().Trim();

                if(string.IsNullOrWhiteSpace(objAccountBanksInfo.ACListAccountBankAccountHolder) && objectsInfo != null)
                {
                    objAccountBanksInfo.ACListAccountBankAccountHolder = objectsInfo.ACObjectName;
                }    
                AccountBanksList.Add(objAccountBanksInfo);
            }
            if (AccountBanksList.GridControl != null)
            {
                AccountBanksList.GridControl.DataSource = AccountBanksList;
                AccountBanksList.GridControl.RefreshDataSource();
            }
        }

        private void InitDataPaymentTerm()
        {
            if (this.DataImport == null)
                return;

            GEPaymentTermItemsInfo objPaymentTermItemsInfo = new GEPaymentTermItemsInfo();
            string cellValue = string.Empty;
            decimal value = 0;
            
            for (int row = 4; row <= DataImport.Rows.Count; row++)
            {
                objPaymentTermItemsInfo = new GEPaymentTermItemsInfo();
                objPaymentTermItemsInfo.GEPaymentTermNo = (DataImport.Cells[row, 1] as Range).Text.ToString().Trim();
                objPaymentTermItemsInfo.GEPaymentTermName = (DataImport.Cells[row, 2] as Range).Text.ToString().Trim();

                if (string.IsNullOrWhiteSpace(objPaymentTermItemsInfo.GEPaymentTermNo))
                {
                    continue;
                }

                cellValue = (DataImport.Cells[row, 3] as Range).Text.ToString().Trim();
                if(cellValue.Contains("Pay"))
                {
                    objPaymentTermItemsInfo.GEPaymentTermItemPaymentType = PaymentTermItemPaymentType.Payment.ToString();
                }
                else
                {
                    objPaymentTermItemsInfo.GEPaymentTermItemPaymentType = PaymentTermItemPaymentType.Deposit.ToString();
                }

                cellValue = (DataImport.Cells[row, 4] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objPaymentTermItemsInfo.GEPaymentTermItemPercentPayment = Convert.ToInt32(cellValue);
                    }
                    catch (Exception ex)
                    {
                        objPaymentTermItemsInfo.GEPaymentTermItemPercentPayment = 0;
                    }
                }

                cellValue = (DataImport.Cells[row, 5] as Range).Text.ToString().Trim();
                if (cellValue.ToLower().Contains("ngay khi"))
                {
                    objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate = PaymentTermItemPaymentDate.IsContract.ToString();
                }
                else if (cellValue.ToLower().Contains("trước khi"))
                {
                    objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate = PaymentTermItemPaymentDate.IsBeforeDelivery.ToString();
                }
                else if (cellValue.ToLower().Contains("sau khi"))
                {
                    objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate = PaymentTermItemPaymentDate.IsAfterDelivery.ToString();
                }
                else
                {
                    objPaymentTermItemsInfo.GEPaymentTermItemPaymentDate = PaymentTermItemPaymentDate.IsInvoiceIn.ToString();
                }

                cellValue = (DataImport.Cells[row, 6] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objPaymentTermItemsInfo.GEPaymentTermItemDay = Convert.ToInt32(cellValue);
                    }
                    catch (Exception ex)
                    {
                        objPaymentTermItemsInfo.GEPaymentTermItemDay = 0;
                    }
                }

                PaymentTermItemsList.Add(objPaymentTermItemsInfo);
            }
            if (PaymentTermItemsList.GridControl != null)
            {
                PaymentTermItemsList.GridControl.DataSource = PaymentTermItemsList;
                PaymentTermItemsList.GridControl.RefreshDataSource();
            }
        }
        #endregion

        #region Save 
        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vui lòng KIỂM TRA THẬT KỸ dữ liệu bạn muốn import ở trên!!!" + Environment.NewLine + "Bạn chắc chắn muốn Lưu dữ liệu?"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.YesNo
                                , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BOSProgressBar.Start("Đang lưu dữ liệu");
                this.SaveDataAccounting();
                BOSProgressBar.Close();
            }
        }

        private void SaveDataAccounting()
        {
            switch (this.DataType)
            {
                case "LoanAgreement":
                    SaveDataLoanAgreement();
                    break;

                case "LoanReceipt":
                    SaveDataLoanReceipt();
                    break;

                case "ListAccountBank":
                    SaveDataListAccountBank();
                    break;

                case "PaymentTerm":
                    SaveDataPaymentTerm();
                    break;
            }
        }

        private void SaveDataLoanAgreement()
        {
            LoanAgreementsList.Invalidate(LoanAgreementsList.Where(o => !String.IsNullOrWhiteSpace(o.ACLoanAgreementNo)).ToList());
            try
            {
                LoanAgreementsList.SaveItemObjects();
                MessageBox.Show(CommonLocalizedResources.SaveSuccessful
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra..." + Environment.NewLine + "Vui lòng kiểm tra lại dữ liệu import và thử lại sau!"
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveDataLoanReceipt()
        {
            LoanReceiptsList.Invalidate(LoanReceiptsList.Where(o => !String.IsNullOrWhiteSpace(o.ACLoanReceiptNo)).ToList());
            try
            {
                LoanReceiptsList.SaveItemObjects();
                MessageBox.Show(CommonLocalizedResources.SaveSuccessful
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra..." + Environment.NewLine + "Vui lòng kiểm tra lại dữ liệu import và thử lại sau!"
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveDataListAccountBank()
        {
            AccountBanksList.Invalidate(AccountBanksList.Where(o => !String.IsNullOrWhiteSpace(o.ACListAccountBankName)).ToList());
            try
            {
                AccountBanksList.SaveItemObjects();
                MessageBox.Show(CommonLocalizedResources.SaveSuccessful
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra..." + Environment.NewLine + "Vui lòng kiểm tra lại dữ liệu import và thử lại sau!"
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveDataPaymentTerm()
        {
            ERPModuleEntities entity = (((BaseModuleERP)this.Module).CurrentModuleEntity);
            PaymentTermItemsList.Invalidate(PaymentTermItemsList.Where(o => !String.IsNullOrWhiteSpace(o.GEPaymentTermNo)).ToList());

            //Tạo thông tin chung GEPaymentTerms
            GEPaymentTermsInfo objPaymentTermsInfo = new GEPaymentTermsInfo();
            BOSList<GEPaymentTermsInfo> PaymentTermsList = new BOSList<GEPaymentTermsInfo>();
            PaymentTermsList.InitBOSList(entity, null, TableName.GEPaymentTermsTableName,
                                            BOSList<GEPaymentTermsInfo>.cstRelationNone);

            foreach (GEPaymentTermItemsInfo item in PaymentTermItemsList)
            {
                objPaymentTermsInfo = new GEPaymentTermsInfo();
                objPaymentTermsInfo.GEPaymentTermNo = item.GEPaymentTermNo;
                objPaymentTermsInfo.GEPaymentTermName = item.GEPaymentTermName;
                objPaymentTermsInfo.GEPaymentTermActiveCheck = true;

                if(PaymentTermsList.FirstOrDefault(o => o.GEPaymentTermNo == objPaymentTermsInfo.GEPaymentTermNo) == null)
                {
                    PaymentTermsList.Add(objPaymentTermsInfo);
                }    
            }
            PaymentTermsList.SaveItemObjects();

            GEPaymentTermsController objPaymentTermsController = new GEPaymentTermsController();
            PaymentTermsList.Invalidate((List<GEPaymentTermsInfo>)objPaymentTermsController.GetListFromDataSet(objPaymentTermsController.GetAllPaymentTermIsActiveForLookupControl()));
            foreach (GEPaymentTermItemsInfo item in PaymentTermItemsList)
            {
                objPaymentTermsInfo = PaymentTermsList.FirstOrDefault(o => o.GEPaymentTermNo == item.GEPaymentTermNo);
                if(objPaymentTermsInfo != null)
                {
                    item.FK_GEPaymentTermID = objPaymentTermsInfo.GEPaymentTermID;
                }
            }

            try
            {
                PaymentTermItemsList.SaveItemObjects();
                MessageBox.Show(CommonLocalizedResources.SaveSuccessful
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra..." + Environment.NewLine + "Vui lòng kiểm tra lại dữ liệu import và thử lại sau!"
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Cancel
        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn hủy Import?"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.YesNo
                                , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        #endregion
    }
}
