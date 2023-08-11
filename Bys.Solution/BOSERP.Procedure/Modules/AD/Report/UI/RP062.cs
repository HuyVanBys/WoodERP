using BOSCommon;
using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP062 : ReportForm
    {
        public RP062()
        {
            InitializeComponent();
        }

        private void RP062_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteToDate.DateTime = BOSUtil.GetMonthEndDate();
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

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP062 report = new BOSReport.RP062();
            InitReportDataSource(report);
            guiReportPreview viewer = new guiReportPreview(report);
            viewer.Show();
        }

        /// <summary>
        /// Init the data source for the report
        /// </summary>
        /// <param name="report">Given report</param>        
        public void InitReportDataSource(XtraReport report)
        {
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            XRLabel dateTime = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblFromdateTodate"];
            dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteFromDate.Text,
                                                                                    ReportLocalizedResources.ToDateTitle, fld_dteToDate.Text);

            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            BRBranchsInfo selectedBranch = new BRBranchsInfo();
            if (branchID > 0)
            {
                BRBranchsInfo objBranchInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(branchID);
                if (objBranchsInfo != null) selectedBranch = objBranchInfo;
            }
            List<ACAssetsInfo> assets = GetAssetList();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            ACAssetShipmentItemsController objAssetShipmentItemsController = new ACAssetShipmentItemsController();
            ACAssetReceiptItemsController objAssetReceiptItemsController = new ACAssetReceiptItemsController();
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            foreach (ACAssetsInfo asset in assets)
            {
                List<ACDocumentEntrysInfo> assetEntries = new List<ACDocumentEntrysInfo>();
                ACDocumentEntrysInfo receiptEntry = new ACDocumentEntrysInfo();
                receiptEntry.ACAssetNo = asset.ACAssetNo;
                receiptEntry.ACAssetName = asset.ACAssetName;
                receiptEntry.ACAssetType = asset.ACAssetType;
                receiptEntry.ACAssetTypeDisplayedText = asset.ACAssetTypeDisplayedText;
                receiptEntry.ACAssetUsedDate = asset.ACAssetUsedDate;
                receiptEntry.ACAssetModelNo = asset.ACAssetModelNo;
                receiptEntry.ACAssetDepreciationPercent = asset.ACAssetDepreciationPercent;
                receiptEntry.ACAssetDepreciationAmount = asset.ACAssetDepreciationAmount;
                receiptEntry.ACAssetOriginalAmount = asset.ACAssetOriginalAmount;
                receiptEntry.ACAssetDepreciatedAmount = asset.ACAssetInitDepreciatedAmount * asset.ACAssetInitQty;
                receiptEntry.GroupValue = string.Format("{0}{1}", selectedBranch.BRBranchNo, asset.ACAssetType);
                receiptEntry.BRBranchName = selectedBranch.BRBranchName;
                receiptEntry.ACDocumentTypeName = AccDocumentType.TangTSCD.ToString();
                ACAssetReceiptItemsInfo receiptItem = objAssetReceiptItemsController.GetItemByAssetID(asset.ACAssetID, fromDate, toDate);
                if (receiptItem != null)
                {
                    receiptEntry.ReceiptDocumentNo = receiptItem.ACAssetReceiptNo;
                    receiptEntry.ACDocumentDate = receiptItem.ACAssetReceiptDate;
                    receiptEntry.ReceiptDocumentDate = receiptItem.ACAssetReceiptDate.ToString("dd/MM/yyyy");
                    assetEntries.Add(receiptEntry);
                }
                else
                {
                    if (asset.ACAssetPurchasedDate.Date >= fromDate.Date && asset.ACAssetPurchasedDate.Date <= toDate.Date)
                    {
                        receiptEntry.ACDocumentDate = asset.ACAssetPurchasedDate;
                        receiptEntry.ReceiptDocumentDate = asset.ACAssetPurchasedDate.ToString("dd/MM/yyyy");
                        assetEntries.Add(receiptEntry);
                    }
                }

                List<ACDocumentEntrysInfo> depreciationEntries = objDocumentEntrysController.GetDepreciationEntriesByAssetID(asset.ACAssetID, fromDate, toDate);
                decimal depreciatedAmount = receiptEntry.ACAssetDepreciatedAmount;
                foreach (ACDocumentEntrysInfo depreciationEntry in depreciationEntries)
                {
                    depreciatedAmount += depreciationEntry.ACDocumentEntryExchangeAmount;
                    depreciationEntry.ReceiptDocumentNo = depreciationEntry.ACDocumentNo;
                    depreciationEntry.ReceiptDocumentDate = depreciationEntry.ACDocumentDate.ToString("dd/MM/yyyy");
                    depreciationEntry.ACAssetNo = asset.ACAssetNo;
                    depreciationEntry.ACAssetName = asset.ACAssetName;
                    depreciationEntry.ACAssetType = asset.ACAssetType;
                    depreciationEntry.ACAssetTypeDisplayedText = asset.ACAssetTypeDisplayedText;
                    depreciationEntry.ACAssetDepreciationPercent = asset.ACAssetDepreciationPercent;
                    depreciationEntry.ACAssetDepreciationAmount = asset.ACAssetDepreciationAmount;
                    depreciationEntry.ACAssetDepreciatedAmount = depreciatedAmount;
                    depreciationEntry.GroupValue = string.Format("{0}{1}", selectedBranch.BRBranchNo, asset.ACAssetType);
                    depreciationEntry.BRBranchName = selectedBranch.BRBranchName;
                    depreciationEntry.ACDocumentTypeName = AccDocumentType.KhauHaoTSCD.ToString();
                    assetEntries.Add(depreciationEntry);
                }


                ACAssetShipmentItemsInfo shipmentItem = objAssetShipmentItemsController.GetItemByAssetID(asset.ACAssetID, fromDate, toDate);
                if (shipmentItem != null)
                {
                    ACDocumentEntrysInfo shipmentEntry = new ACDocumentEntrysInfo();
                    shipmentEntry.ACAssetNo = asset.ACAssetNo;
                    shipmentEntry.ACAssetName = asset.ACAssetName;
                    shipmentEntry.ACAssetType = asset.ACAssetType;
                    shipmentEntry.ACAssetTypeDisplayedText = asset.ACAssetTypeDisplayedText;
                    shipmentEntry.ACAssetDepreciationPercent = asset.ACAssetDepreciationPercent;
                    shipmentEntry.ACAssetDepreciationAmount = asset.ACAssetDepreciationAmount;
                    shipmentEntry.ACAssetDepreciatedAmount = depreciatedAmount;
                    shipmentEntry.ShipmentDocumentNo = shipmentItem.ACDocumentNo;
                    shipmentEntry.ACDocumentDate = shipmentItem.ACDocumentDate;
                    shipmentEntry.ShipmentDocumentDate = shipmentItem.ACDocumentDate.ToString("dd/MM/yyyy");
                    shipmentEntry.ShipmentDocumentDesc = shipmentItem.ACDocumentDesc;
                    shipmentEntry.GroupValue = string.Format("{0}{1}", selectedBranch.BRBranchNo, asset.ACAssetType);
                    shipmentEntry.BRBranchName = selectedBranch.BRBranchName;
                    shipmentEntry.ACDocumentTypeName = AccDocumentType.GiamTSCD.ToString();
                    assetEntries.Add(shipmentEntry);
                }

                if (assetEntries.Count > 0)
                {
                    receiptEntry.ACAssetTotalDepreciatedAmount = assetEntries.Max(e => e.ACAssetDepreciatedAmount);
                    assetEntries = assetEntries.OrderBy(e => e.ACDocumentDate).ToList();
                    entries = entries.Concat(assetEntries).ToList();
                }
            }

            report.DataSource = entries;
        }

        /// <summary>
        /// Get asset list for the report
        /// </summary>
        /// <returns>List of assets</returns>
        private List<ACAssetsInfo> GetAssetList()
        {
            ACAssetsController objAssetsController = new ACAssetsController();
            List<ACAssetsInfo> assets = new List<ACAssetsInfo>();
            int assetID = Convert.ToInt32(fld_lkeACAssetID.EditValue);
            string assetType = Convert.ToString(fld_lkeAssetType.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            List<BRBranchsInfo> selectedBranches = new List<BRBranchsInfo>();
            selectedBranches = GetSelectedBranchesByBranchID(branchID);
            if (assetID > 0)
            {
                ACAssetsInfo asset = (ACAssetsInfo)objAssetsController.GetAssetByID(assetID);
                if (asset != null)
                {
                    if (asset.FK_HRDepartmentRoomID == 0)
                    {
                        if ((branchID == 0 || branchID == asset.FK_BRBranchID) && (assetType.Length == 0 || assetType == asset.ACAssetType))
                            assets.Add(asset);
                    }
                    else
                        //assets = objAssetsController.GetAssetList(asset.ACAssetNo, assetType, branchID);
                        assets = GetAssetListBySomeCriteria(asset.ACAssetNo, assetType, selectedBranches);
                }
                else
                    //assets = objAssetsController.GetAssetList(null, assetType, branchID);
                    assets = GetAssetListBySomeCriteria(null, assetType, selectedBranches);
            }
            else
            {
                //assets = objAssetsController.GetAssetList(null, assetType, branchID);
                assets = GetAssetListBySomeCriteria(null, assetType, selectedBranches);
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            return assets;
        }

        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
        private List<ACAssetsInfo> GetAssetListBySomeCriteria(string assetNo, string assetType, List<BRBranchsInfo> branchList)
        {
            List<ACAssetsInfo> assetList = new List<ACAssetsInfo>();
            ACAssetsController objAssetsController = new ACAssetsController();
            if (branchList != null && branchList.Count > 0)
            {
                foreach (BRBranchsInfo branch in branchList)
                {
                    List<ACAssetsInfo> assets = objAssetsController.GetAssetList(assetNo, assetType, branch.BRBranchID);
                    assetList.AddRange(assets);
                }
            }
            return assetList;
        }
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
    }
}
