using BOSCommon;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.GeneralAccounting
{
    public partial class guiAllocate : BOSERPScreen
    {
        /// <summary>
        /// Gets or sets the start date of a report period
        /// </summary>
        public DateTime FromDate { get; set; }

        /// <summary>
        /// Gets or sets the end date of a report period
        /// </summary>
        public DateTime ToDate { get; set; }

        public int ACDocumentTypeID { get; set; }

        /// <summary>
        /// Gets or sets the selected branch ids
        /// </summary>
        public string SelectedBranchIDs { get; set; }

        public guiAllocate()
        {
            InitializeComponent();
        }

        public guiAllocate(DateTime fromDate, DateTime toDate, int documentTypeID)
        {
            InitializeComponent();

            fld_dteFromDate.DateTime = fromDate;
            fld_dteToDate.DateTime = toDate;
            ACDocumentTypeID = documentTypeID;
        }

        private void guiAllocate_Load(object sender, EventArgs e)
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            List<BRBranchsInfo> branches = objBranchsController.GetAllBranches();
            fld_cmbBranches.Properties.DataSource = branches;
            fld_cmbBranches.EditValue = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            fld_cmbBranches.RefreshEditValue();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            FromDate = fld_dteFromDate.DateTime;
            ToDate = fld_dteToDate.DateTime;
            SelectedBranchIDs = Convert.ToString(fld_cmbBranches.EditValue);
            int m1 = (ToDate.Month - FromDate.Month);
            int m2 = (ToDate.Year - FromDate.Year) * 12;
            int months = m1 + m2;
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentTypesInfo objDocumentTypesInfo = (ACDocumentTypesInfo)objDocumentTypesController.GetObjectByID(ACDocumentTypeID);
            if (objDocumentTypesInfo != null)
            {
                if (objDocumentTypesInfo.ACDocumentTypeName == AccDocumentType.KhauHaoTSCD.ToString())
                {
                    if (months != 0)
                    {
                        MessageBox.Show("Vui lòng chạy khấu hao theo từng tháng!",
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                    ACDepreciationAssetTransController objDepreciationAssetTransController = new ACDepreciationAssetTransController();
                    List<ACDepreciationAssetTransInfo> depreciationAssetTrans = null;
                    List<int> branchIDsDepreciated = null;
                    if (!(BOSApp.CurrentCompanyInfo.CSCompanyAccountingBeginDateConfig.Month == ToDate.Month && BOSApp.CurrentCompanyInfo.CSCompanyAccountingBeginDateConfig.Year == ToDate.Year))
                    {
                        depreciationAssetTrans = objDepreciationAssetTransController.GetDepreciationAssetTransByMonthAndBranchIDs(ToDate.AddMonths(-1), SelectedBranchIDs);
                        ACAssetsController objAssetsController = new ACAssetsController();
                        List<ACAssetsInfo> depreciatedAssets = new List<ACAssetsInfo>();
                        string[] branchIDs = SelectedBranchIDs.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < branchIDs.Length; i++)
                        {
                            depreciatedAssets.AddRange(objAssetsController.GetAssetsForDepreciating(i, ToDate.AddMonths(-1)));
                        }
                        if (depreciationAssetTrans.Count() == 0 && depreciatedAssets.Count() > 0)
                        {
                            MessageBox.Show("Vui lòng chạy khấu hao tháng " + ToDate.AddMonths(-1).Month + " trước khi chạy khấu hao tháng " + ToDate.Month + "!",
                                            CommonLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            return;
                        }

                        branchIDsDepreciated = depreciationAssetTrans.Select(o => o.FK_BRBranchID).Distinct().ToList();
                        List<int> branchIDsUnDepreciate = new List<int>();
                        int x = 0;
                        branchIDs.All(o =>
                        {
                            x = 0;
                            if (Int32.TryParse(o, out x))
                            {
                                depreciatedAssets = new List<ACAssetsInfo>();
                                depreciatedAssets.AddRange(objAssetsController.GetAssetsForDepreciating(x, ToDate.AddMonths(-1)));
                                if (!branchIDsDepreciated.Any(y => y == x) && depreciatedAssets.Count() > 0)
                                    branchIDsUnDepreciate.Add(x);
                            }
                            return true;
                        });

                        if (branchIDsUnDepreciate.Count() > 0)
                        {
                            BRBranchsController objBranchsController = new BRBranchsController();
                            BRBranchsInfo objBranchsInfo = null;
                            string mes = string.Empty;
                            branchIDsUnDepreciate.ForEach(o =>
                            {
                                objBranchsInfo = objBranchsController.GetObjectByID(o) as BRBranchsInfo;
                                if (objBranchsInfo != null)
                                    mes += Environment.NewLine + objBranchsInfo.BRBranchName;
                            });
                            MessageBox.Show("Vui lòng chạy khấu hao tháng " + ToDate.AddMonths(-1).Month + " trước khi chạy khấu hao tháng " + ToDate.Month + "  cho các chi nhánh sau:" + Environment.NewLine + mes,
                                            CommonLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            return;
                        }
                    }

                    depreciationAssetTrans = objDepreciationAssetTransController.GetDepreciationAssetTransByMonthAndBranchIDs(ToDate, SelectedBranchIDs);
                    List<ACDepreciationAssetTransInfo> branchIDDepreciateds = depreciationAssetTrans.GroupBy(o => o.FK_BRBranchID).Select(o => o.First()).ToList();
                    branchIDsDepreciated = depreciationAssetTrans.Select(o => o.FK_BRBranchID).Distinct().ToList();
                    if (branchIDDepreciateds.Count() > 0)
                    {
                        string mes = string.Empty;
                        branchIDDepreciateds.ForEach(o =>
                        {
                            mes += Environment.NewLine + o.BRBranchName;
                        });
                        MessageBox.Show("Các chi nhánh sau đã được chạy khấu hao cho tháng " + ToDate.Month + ":" + Environment.NewLine + mes,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (objDocumentTypesInfo.ACDocumentTypeName == AccDocumentType.PhanBoCCDC.ToString())
                {
                    if (months != 0)
                    {
                        MessageBox.Show("Vui lòng chạy phân bổ theo từng tháng!",
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                    ACAllocationEquipmentTransController objAllocationEquipmentTransController = new ACAllocationEquipmentTransController();
                    List<ACAllocationEquipmentTransInfo> allocationEquipmentTrans = null;
                    List<int> branchIDsDepreciated = null;
                    if (!(BOSApp.CurrentCompanyInfo.CSCompanyAccountingBeginDateConfig.Month == ToDate.Month && BOSApp.CurrentCompanyInfo.CSCompanyAccountingBeginDateConfig.Year == ToDate.Year))
                    {
                        allocationEquipmentTrans = objAllocationEquipmentTransController.GetAllocationEquipmentTransByMonthAndBranchIDs(ToDate.AddMonths(-1), SelectedBranchIDs);
                        ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
                        List<ICShipmentItemsInfo> depreciatedEquipments = new List<ICShipmentItemsInfo>();
                        string[] branchIDs = SelectedBranchIDs.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < branchIDs.Length; i++)
                        {
                            depreciatedEquipments.AddRange(objShipmentItemsController.GetEquipmentItemsForDepreciating(i, ToDate.AddMonths(-1)));
                        }
                        depreciatedEquipments = depreciatedEquipments.Where(t => t.ICProductIdentifiedEquipmentInitDepriciationMonths > 0).ToList();
                        if (allocationEquipmentTrans.Count() == 0 && depreciatedEquipments.Count() > 0)
                        {
                            MessageBox.Show("Vui lòng chạy phân bổ tháng " + ToDate.AddMonths(-1).Month + " trước khi chạy khấu hao tháng " + ToDate.Month + "!",
                                            CommonLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            return;
                        }

                        branchIDsDepreciated = allocationEquipmentTrans.Select(o => o.FK_BRBranchID).Distinct().ToList();
                        List<int> branchIDsUnDepreciate = new List<int>();
                        int x = 0;
                        branchIDs.All(o =>
                        {
                            x = 0;
                            if (Int32.TryParse(o, out x))
                            {
                                depreciatedEquipments = new List<ICShipmentItemsInfo>();
                                depreciatedEquipments.AddRange(objShipmentItemsController.GetEquipmentItemsForDepreciating(x, ToDate.AddMonths(-1)));
                                depreciatedEquipments = depreciatedEquipments.Where(t => t.ICProductIdentifiedEquipmentInitDepriciationMonths > 0).ToList();
                                if (!branchIDsDepreciated.Any(y => y == x) && depreciatedEquipments.Count() > 0)
                                    branchIDsUnDepreciate.Add(x);
                            }
                            return true;
                        });

                        if (branchIDsUnDepreciate.Count() > 0)
                        {
                            BRBranchsController objBranchsController = new BRBranchsController();
                            BRBranchsInfo objBranchsInfo = null;
                            string mes = string.Empty;
                            branchIDsUnDepreciate.ForEach(o =>
                            {
                                objBranchsInfo = objBranchsController.GetObjectByID(o) as BRBranchsInfo;
                                if (objBranchsInfo != null)
                                    mes += Environment.NewLine + objBranchsInfo.BRBranchName;
                            });
                            MessageBox.Show("Vui lòng chạy khấu hao tháng " + ToDate.AddMonths(-1).Month + " trước khi chạy khấu hao tháng " + ToDate.Month + "  cho các chi nhánh sau:" + Environment.NewLine + mes,
                                            CommonLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            return;
                        }
                    }

                    allocationEquipmentTrans = objAllocationEquipmentTransController.GetAllocationEquipmentTransByMonthAndBranchIDs(ToDate, SelectedBranchIDs);
                    List<ACAllocationEquipmentTransInfo> branchIDDepreciateds = allocationEquipmentTrans.GroupBy(o => o.FK_BRBranchID).Select(o => o.First()).ToList();
                    branchIDsDepreciated = allocationEquipmentTrans.Select(o => o.FK_BRBranchID).Distinct().ToList();
                    if (branchIDDepreciateds.Count() > 0)
                    {
                        string mes = string.Empty;
                        branchIDDepreciateds.ForEach(o =>
                        {
                            mes += Environment.NewLine + o.BRBranchName;
                        });
                        MessageBox.Show("Các chi nhánh sau đã được chạy phân bổ cho tháng " + ToDate.Month + ":" + Environment.NewLine + mes,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
