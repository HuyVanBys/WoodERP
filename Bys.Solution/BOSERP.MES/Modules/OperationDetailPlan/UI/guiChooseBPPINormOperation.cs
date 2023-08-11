using BOSCommon;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Localization;

namespace BOSERP.Modules.OperationDetailPlan
{
    public partial class guiChooseBPPINormOperation : BOSERPScreen
    {
        /// <summary>
        /// Count is used to distinguish focus row changed event in grid
        /// and click event in check edit control
        /// </summary>

        public List<MMBatchProductProductionNormItemsViewInfo> productionNormList = new List<MMBatchProductProductionNormItemsViewInfo>();
        public DateTime planFromdate;
        public DateTime PlanTodate;
        public int BatchProductID { get; set; }
        public List<MMMachineUnitsInfo> DataMachineUnitList { get; set; }
        public List<MMMachineUnitsInfo> SelectMachineUnitList { get; set; }
        public List<MMMachineUnitOperationsInfo> MachineUnitOperationList { get; set; }

        public List<MMMachineUnitItemsInfo> MachineUnitItemList { get; set; }
        public List<ICProductSemisInfo> ProductSemiList { get; set; }
        public List<MMBatchProductProductionNormItemsViewInfo> SelectedNormList = new List<MMBatchProductProductionNormItemsViewInfo>();
        public guiChooseBPPINormOperation()
        {
            InitializeComponent();
        }

        public guiChooseBPPINormOperation(DateTime fromdate, DateTime todate)
        {
            InitializeComponent();
            fld_dteFromDateDetail.DateTime = new DateTime(planFromdate.Year, planFromdate.Month, planFromdate.Day, 7, 30, 0);
            fld_dteToDateDetail.DateTime = new DateTime(PlanTodate.Year, PlanTodate.Month, PlanTodate.Day, 17, 0, 0);
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
            DataMachineUnitList = new List<MMMachineUnitsInfo>();
            SelectMachineUnitList = new List<MMMachineUnitsInfo>();
            MachineUnitItemList = new List<MMMachineUnitItemsInfo>();
            MachineUnitOperationList = new List<MMMachineUnitOperationsInfo>();
        }
        #region Event   
        public void InvalidateMachineUnit(MMBatchProductProductionNormItemsViewInfo item, bool selected)
        {
            if (ProductSemiList == null) return;
            decimal jobTotalQty = 0;
            if (fld_ckeViewByTicket.Checked || fld_ckeViewByOperation.Checked)
            {
                List<MMMachineUnitsInfo> result = new List<MMMachineUnitsInfo>();
                List<MMMachineUnitsInfo> tempList = new List<MMMachineUnitsInfo>();
                //result = DataMachineUnitList;
                string listNormItemID = string.Empty;
                
                List<MMBatchProductProductionNormItemsViewInfo> dataPNormList = new List<MMBatchProductProductionNormItemsViewInfo>();
                dataPNormList = ((List<MMBatchProductProductionNormItemsViewInfo>)fld_dgcMMBatchProductProductionNormItems.DataSource).ToList();
                if (dataPNormList != null && item != null)
                {
                    MMBatchProductProductionNormItemsViewInfo obj = dataPNormList.Where(o => o.FK_MMOperationID == item.FK_MMOperationID
                    && o.MMBatchProductProductionNormItemID == item.MMBatchProductProductionNormItemID).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.Selected = selected;
                    }
                }
                dataPNormList = dataPNormList.Where(a => a.Selected == true).ToList();
                if (dataPNormList.Count() > 0)
                {
                    jobTotalQty = dataPNormList.Sum(a => a.MMBatchProductProductionNormItemBlocks);
                    List<ICProductSemisInfo> SemiList = ProductSemiList.ToList();
                    List<int> resultList = new List<int>();
                    List<ICProductSemisInfo> resultSemiList = new List<ICProductSemisInfo>();
                    if (fld_ckeViewByTicket.Checked)
                    {
                        List<int> machineID = SemiList.Select(m => m.FK_MMMachineUnitID).Distinct().ToList();

                        SemiList = ProductSemiList.Where(o => dataPNormList.Any(n => n.FK_ICProductID == o.FK_ICProductSemiID)).ToList();
                        List<ICProductSemisInfo> tempSemiList = new List<ICProductSemisInfo>();
                        if (machineID.Count() > 0)
                        {
                            foreach (int mID in machineID)
                            {
                                bool isAcceptMachine = true;
                                List<ICProductSemisInfo> machineSemi = SemiList.Where(s => s.FK_MMMachineUnitID == mID).ToList();
                                if (machineSemi.Count() > 0)
                                {
                                    dataPNormList.ForEach(pn =>
                                    {
                                        List<ICProductSemisInfo> machineList = machineSemi.Where(si => si.FK_ICProductSemiID == pn.FK_ICProductID).ToList();
                                        if (machineList.Count() == 0)
                                        {
                                            isAcceptMachine = false;
                                            return;
                                        }

                                    });
                                }
                                if (isAcceptMachine)
                                    tempSemiList.AddRange(machineSemi);
                            }
                        }
                        SemiList = tempSemiList;
                    }

                    if (fld_ckeViewByOperation.Checked)
                    {
                        List<int> machineID = SemiList.Select(m => m.FK_MMMachineUnitID).Distinct().ToList();
                        if (!fld_ckeViewByTicket.Checked && machineID.Count() == 0)
                        {
                            machineID = DataMachineUnitList.Select(o => o.MMMachineUnitID).Distinct().ToList();
                        }
                        if (machineID.Count() > 0)
                        {
                            if (SemiList.Count() > 0)
                                foreach (int mID in machineID)
                                {
                                    bool isAcceptMachine = true;
                                    List<ICProductSemisInfo> machineSemi = SemiList.Where(s => s.FK_MMMachineUnitID == mID).ToList();
                                    if (machineSemi.Count() > 0)
                                    {
                                        dataPNormList.ForEach(pn =>
                                        {
                                            List<ICProductSemisInfo> machineList = machineSemi.Where(si => si.FK_MMOperationID == pn.FK_MMOperationID).ToList();
                                            if (machineList.Count() == 0)
                                            {
                                                isAcceptMachine = false;
                                                return;
                                            }
                                            resultSemiList.AddRange(machineList);
                                        });
                                    }
                                    if (isAcceptMachine)
                                        resultList.Add(mID);
                                }
                            else
                            {
                                foreach (int mID in machineID)
                                {
                                    bool isAcceptMachine = true;
                                    List<MMMachineUnitOperationsInfo> machineSemi = MachineUnitOperationList.Where(s => s.FK_MMMachineUnitID == mID).ToList();
                                    if (machineSemi.Count() > 0)
                                    {
                                        dataPNormList.ForEach(pn =>
                                        {
                                            List<MMMachineUnitOperationsInfo> machineList = machineSemi.Where(si => si.FK_MMOperationID == pn.FK_MMOperationID).ToList();
                                            if (machineList.Count() == 0)
                                            {
                                                isAcceptMachine = false;
                                                return;
                                            }
                                            
                                        });
                                    }
                                    if (isAcceptMachine)
                                        resultList.Add(mID);
                                }
                            }
                        }
                    }
                    if (SemiList != null && !fld_ckeViewByOperation.Checked)
                    {
                        SelectMachineUnitList = DataMachineUnitList.Where(d => SemiList.Any(s => s.FK_MMMachineUnitID == d.MMMachineUnitID)).ToList();
                        SelectMachineUnitList.ForEach(o =>
                        {
                            ICProductSemisInfo exit = SemiList.Where(s => s.FK_MMMachineUnitID == o.MMMachineUnitID).FirstOrDefault();
                            if (exit != null)
                            {
                                o.MMMachineUnitCapacity = exit.ICProductSemiCapacity;
                                o.MMMachineUnitSetupTime = exit.ICProductSemiSetupTime;
                                o.MMCapacityUnit = exit.ICCapacityUnit;
                                o.MMMachineUnitQty = exit.ICProductSemiEmployee;
                            }
                        });
                    }
                    else
                    {
                        SelectMachineUnitList = DataMachineUnitList.Where(d => resultList.Any(s => s == d.MMMachineUnitID)).ToList();
                        SelectMachineUnitList.ForEach(o =>
                        {
                            if (resultSemiList.Count() > 0)
                            {
                                ICProductSemisInfo exit = resultSemiList.Where(s => s.FK_MMMachineUnitID == o.MMMachineUnitID).FirstOrDefault();
                                if (exit != null)
                                {
                                    o.MMMachineUnitCapacity = exit.ICProductSemiCapacity;
                                    o.MMMachineUnitSetupTime = exit.ICProductSemiSetupTime;
                                    o.MMCapacityUnit = exit.ICCapacityUnit;
                                    o.MMMachineUnitQty = exit.ICProductSemiEmployee;
                                }
                            }
                        });
                    }

                }
                else SelectMachineUnitList = new List<MMMachineUnitsInfo>();
            }
            else
                SelectMachineUnitList = DataMachineUnitList.ToList();
            List<int> machineSelectID = SelectMachineUnitList.Select(o => o.MMMachineUnitID).Distinct().ToList();
            List<MMMachineUnitsInfo> DataMachineUnloadList = (new MMMachineUnitsController()).GetUnLoadAnCapacityByMachineList(string.Join( ",",machineSelectID.ToArray()));
            if (DataMachineUnloadList.Count() > 0)
            {
                SelectMachineUnitList.ForEach(o => {
                    MMMachineUnitsInfo unload = DataMachineUnloadList.Where(u => u.MMMachineUnitID == o.MMMachineUnitID).FirstOrDefault();
                    if (unload != null && unload.MMMachineUnitUnloading > 0)
                    {
                        o.MMMachineUnitJobTotalQty = jobTotalQty + unload.MMMachineUnitUnloading;
                        o.MMMachineUnitUnloading = unload.MMMachineUnitUnloading;
                    }
                    else
                    {
                        o.MMMachineUnitJobTotalQty = jobTotalQty ;
                    }
                    if (o.MMMachineUnitCapacity > 0)
                    {
                        decimal config = ((OperationDetailPlanModule)this.Module).GetFactorByConfig(o.MMCapacityUnit);
                        if (config == 0) config = 1;
                        o.MMMachineUnitPlanFinishedDate = ((o.MMMachineUnitUnloading + jobTotalQty) / o.MMMachineUnitCapacity) + o.MMMachineUnitSetupTime/ config;
                    }
                });
            }

            fld_dgcMMMachineUnits.DataSource = SelectMachineUnitList;
            fld_dgcMMMachineUnits.RefreshDataSource();
        }
        private void guiChooseBPPINormOperation_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            int rangeDate = 0;
            string range = ADConfigValueUtility.GetConfigTextByGroupAndValue("PlanDetailRangeDate", "From");
            rangeDate = int.Parse(range != string.Empty ? range : "0");
            fld_dteFromDate.DateTime = DateTime.Now.Date.AddDays(-rangeDate);
            range = ADConfigValueUtility.GetConfigTextByGroupAndValue("PlanDetailRangeDate", "To");
            rangeDate = int.Parse(range != string.Empty ? range : "0");
            fld_dteToDate.DateTime = DateTime.Now.Date.AddDays(rangeDate);
            fld_dteFromDateDetail.DateTime = new DateTime(planFromdate.Year, planFromdate.Month, planFromdate.Day, 7, 30, 0);
            fld_dteToDateDetail.DateTime = new DateTime(PlanTodate.Year, PlanTodate.Month, PlanTodate.Day, 17, 0, 0);
            InitDataSourceOperations();
            MMMachineUnitsController ctl = new MMMachineUnitsController();
            MMMachineUnitItemsController ctlItem = new MMMachineUnitItemsController();
            MMMachineUnitOperationsController ctlMaOper = new MMMachineUnitOperationsController();
            MachineUnitOperationList = ctlMaOper.GetOperationListByUnit(null);
            DataMachineUnitList = ctl.GetAllMachineUnitAndDeparmentRoomUnit();
            if (DataMachineUnitList.Count() > 0)
                MachineUnitItemList = ctlItem.MachineUnitItemByListUnitID(string.Join(",", DataMachineUnitList.Select(o => o.MMMachineUnitID.ToString()).Distinct().ToArray()));

            fld_dgcMMMachineUnits.DataSource = SelectMachineUnitList;
            fld_lkeMMBatchProductID.Properties.ReadOnly = !((OperationDetailPlanModule)Module).ODPMultiBatchInsert;
            if (!((OperationDetailPlanModule)Module).ODPMultiBatchInsert)
                fld_lkeMMBatchProductID.EditValue = BatchProductID;
        }
        public void AddProductToSelectList()
        {
            productionNormList = (List<MMBatchProductProductionNormItemsViewInfo>)fld_dgcMMBatchProductProductionNormItems.DataSource;
            List<MMBatchProductProductionNormItemsViewInfo> fillterList = productionNormList;
            if (productionNormList != null)
            {
                productionNormList = productionNormList.Where(a => a.Selected == true).ToList();
                if (productionNormList.Count() == 0)
                {
                    MessageBox.Show("Vui lòng chọn chi tiết cần hoạch định!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fld_chkSelectAll.Focus();
                    return;
                }
            }

            if (productionNormList != null)
            {
                productionNormList = productionNormList.Where(a => a.Selected == true).ToList();
                if (productionNormList.Count() > 0)
                {
                    bool isvalidDate = true;
                    bool isvalidBatchDate = true;
                    productionNormList.ForEach(o =>
                    {
                        if (o.MMOperationDetailPlanItemChildExecutionFromDate.Date > o.MMOperationDetailPlanItemChildExecutionToDate.Date)
                        { o.IsError = true; isvalidDate = false; }
                        if (o.MMOperationDetailPlanItemChildExecutionFromDate.Date < o.MMBatchProductFromDate.Date)
                        { o.IsError = true; isvalidBatchDate = false; }

                    });
                    if (!isvalidDate)
                    {
                        MessageBox.Show("Tồn tại chi tiết có ngày bắt đầu lớn hơn ngày kết thúc.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        return;
                    }
                    if (!isvalidBatchDate)
                    {
                        MessageBox.Show("Tồn tại chi tiết có ngày bắt đầu nhỏ hơn ngày bắt đầu LSX.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (SelectMachineUnitList.Where(o => o.Selected).Count() == 0)
            {
                if (MessageBox.Show("Bạn chưa chọn nguồn lực. Bạn muốn tiếp tục không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            List<MMBatchProductProductionNormItemsViewInfo> removeAddList = new List<MMBatchProductProductionNormItemsViewInfo>();
            productionNormList.ForEach(s =>
            {
                if (s.Selected)
                {
                    if (SelectMachineUnitList.Where(o => o.Selected).Count() > 0)
                        SelectMachineUnitList.ForEach(hu =>
                        {
                            if (hu.Selected)
                            {

                                List<MMMachineUnitItemsInfo> assestItemList = new List<MMMachineUnitItemsInfo>();
                                if (MachineUnitItemList != null)
                                {
                                    assestItemList = MachineUnitItemList.Where(m => m.FK_MMMachineUnitID == hu.MMMachineUnitID).ToList();
                                    if (assestItemList.Count() > 0)
                                    {
                                        assestItemList.ForEach(a =>
                                        {

                                            a.MMMachineUnitItemCapacity = hu.MMMachineUnitCapacity;
                                            a.MMCapacityUnit = hu.MMCapacityUnit;
                                            a.MMMachineUnitEmployeeQty = hu.MMMachineUnitQty;
                                            a.MMMachineUnitType = hu.MMMachineUnitType;
                                            a.FK_ADWorkingShiftID = hu.FK_ADWorkingShiftID;
                                            a.MMMachineUnitItemSetupTime = hu.MMMachineUnitSetupTime;
                                            a.MMMachineUnitName = hu.MMMachineUnitName;
                                        });
                                    }
                                }
                                else
                                {
                                    MMMachineUnitItemsInfo machin = new MMMachineUnitItemsInfo();
                                    machin.FK_MMMachineUnitID = hu.MMMachineUnitID;
                                    machin.MMMachineUnitItemCapacity = hu.MMMachineUnitCapacity;
                                    machin.MMCapacityUnit = hu.MMCapacityUnit;
                                    machin.MMMachineUnitEmployeeQty = hu.MMMachineUnitQty;
                                    machin.MMMachineUnitType = hu.MMMachineUnitType;
                                    machin.FK_ADWorkingShiftID = hu.FK_ADWorkingShiftID;
                                    machin.MMMachineUnitItemSetupTime = hu.MMMachineUnitSetupTime;
                                    machin.MMMachineUnitName = hu.MMMachineUnitName;
                                    assestItemList.Add(machin);
                                }
                                assestItemList.ForEach(ass =>
                                {
                                    MMDetailPlanMachineUnitsInfo mUnit = new MMDetailPlanMachineUnitsInfo();
                                    mUnit.FK_ACAssetID = ass.FK_ACAssetID;
                                    mUnit.FK_MMMachineUnitID = ass.FK_MMMachineUnitID;
                                    mUnit.FK_MMOperationID = s.FK_MMOperationID;
                                    mUnit.FK_MMBatchProductProductionNormItemID = s.MMBatchProductProductionNormItemID;
                                    mUnit.MMDetailPlanMachineUnitCapacity = ass.MMMachineUnitItemCapacity;
                                    mUnit.MMDetailPlanMachineUnitQty = ass.MMMachineUnitEmployeeQty;
                                    mUnit.MMDetailPlanMachineUnitType = ass.MMMachineUnitType;
                                    mUnit.MMCapacityUnit = ass.MMCapacityUnit;
                                    mUnit.MMDetailPlanMachineUnitSetupTime = ass.MMMachineUnitItemSetupTime;
                                    mUnit.MMMachineUnitName = ass.MMMachineUnitName;

                                    if (s.MachineUnit == null) s.MachineUnit = new List<MMDetailPlanMachineUnitsInfo>();
                                    MMDetailPlanMachineUnitsInfo mExitUnit = s.MachineUnit.Where(o => o.FK_MMBatchProductProductionNormItemID == s.MMBatchProductProductionNormItemID
                                                                                                        && o.FK_MMOperationID == s.FK_MMOperationID
                                                                                                        && o.FK_ACAssetID == ass.FK_ACAssetID
                                                                                                        && o.FK_MMMachineUnitID == ass.FK_MMMachineUnitID).FirstOrDefault();
                                    if (mExitUnit == null || mExitUnit.FK_MMBatchProductProductionNormItemID == 0)
                                        s.MachineUnit.Add(mUnit);
                                });
                            }
                        });
                    else
                    {
                        s.MachineUnit = new List<MMDetailPlanMachineUnitsInfo>();
                    }
                    s.MachineDetail = s.MachineUnit != null ? (string.Join(";", s.MachineUnit.Select(o => o.MMMachineUnitName).Distinct().ToArray())) : string.Empty;
                    SelectedNormList.Add(s);
                    removeAddList.Add((MMBatchProductProductionNormItemsViewInfo)s.Clone());
                }
            });
            if (removeAddList.Count() > 0)
            {
                removeAddList.ForEach(r =>
                {
                    MMBatchProductProductionNormItemsViewInfo exit = fillterList.Where(f => f.MMBatchProductProductionNormItemID == r.MMBatchProductProductionNormItemID && f.FK_MMOperationID == r.FK_MMOperationID).FirstOrDefault();
                    int index = fillterList.IndexOf(exit);
                    if (index >= 0)
                    {
                        fillterList.RemoveAt(index);
                    }
                });
            }
            fld_dgcMMBatchProductProductionNormItems.DataSource = fillterList;
            productionNormList = fillterList;
            fld_dgcMMBatchProductProductionNormItems.RefreshDataSource();
            fld_dgcSelectNormItems.RefreshDataSource();
        }
        public void RemoveProductToSelectList()
        {
            List<MMBatchProductProductionNormItemsViewInfo> fillterList = SelectedNormList;
            productionNormList = (List<MMBatchProductProductionNormItemsViewInfo>)fld_dgcMMBatchProductProductionNormItems.DataSource;
            if (fillterList != null)
            {
                if (productionNormList == null) productionNormList = new List<MMBatchProductProductionNormItemsViewInfo>();
                fillterList = fillterList.Where(a => a.Selected == true).ToList();
                if (fillterList.Count() == 0)
                {
                    MessageBox.Show("Vui lòng chọn chi tiết!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                fillterList.ForEach(r =>
                {
                    int index = SelectedNormList.IndexOf(r);
                    if (index >= 0)
                    {
                        SelectedNormList.RemoveAt(index);
                    }
                    r.MachineUnit = new List<MMDetailPlanMachineUnitsInfo>();
                    r.Selected = false;
                    productionNormList.Add(r);
                });
                fld_dgcMMBatchProductProductionNormItems.DataSource = productionNormList;
                fld_dgcMMBatchProductProductionNormItems.RefreshDataSource();
                fld_dgcSelectNormItems.RefreshDataSource();
            }
        }
        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            List<MMBatchProductProductionNormItemsViewInfo> fillterList = SelectedNormList;
            if (fillterList != null)
            {
                fillterList = fillterList.Where(a => a.Selected == true).ToList();
                if (fillterList == null || fillterList.Count() == 0)
                {
                    MessageBox.Show("Vui lòng chọn chi tiết cần hoạch định!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fld_chkSelectAll.Focus();
                    return;
                }
                if (((OperationDetailPlanModule)Module).AddBatchProductProducttionItem(fillterList))
                {
                    UpdateDataSourceForNotExitsEntityList();
                    GridView gridView = fld_dgcSelectNormItems.MainView as GridView;
                    if (gridView != null)
                        gridView.ActiveFilter.Clear();
                    fld_chkSelectAll.Checked = false;
                }
                else
                {
                    BOSApp.ShowMessage("Tồn tại chi tiết thực hiện cùng công đoạn và cùng khoảng thời gian đã chọn!");
                }
            }
        }
        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            List<MMBatchProductProductionNormItemsViewInfo> fillterList = SelectedNormList.Where(o => o.Selected).ToList();
            if (fillterList.Count() > 0)
            {
                if (MessageBox.Show("Chi tiết đã chọn chưa lưu, bạn có chắc không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            Close();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            if (SelectedNormList.Count() > 0)
            {
                if (MessageBox.Show("Chi tiết đã chọn chưa lưu, bạn có chắc không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                SelectedNormList.Clear();
                fld_dgcSelectNormItems.RefreshDataSource();
            }

            MMBatchProductProductionNormItemsViewController objBpptnromItemController = new MMBatchProductProductionNormItemsViewController();
            DateTime fromdate = fld_dteFromDate.DateTime;
            DateTime todate = fld_dteToDate.DateTime;
            int customerID = 0;
            if (fld_lkeFK_ARCustomerID1.EditValue != null)
            {
                Int32.TryParse(fld_lkeFK_ARCustomerID1.EditValue.ToString(), out customerID);
            }
            int collectionID = 0;
            if (fld_lkeICCollections.EditValue != null)
            {
                Int32.TryParse(fld_lkeICCollections.EditValue.ToString(), out collectionID);
            }
            int TTMTID = 0;
            if (fld_lkeTTMTID.EditValue != null)
            {
                Int32.TryParse(fld_lkeTTMTID.EditValue.ToString(), out TTMTID);
            }
            int branchID = 0;
            if (fld_lkeBRBranchID.EditValue != null)
            {
                Int32.TryParse(fld_lkeBRBranchID.EditValue.ToString(), out branchID);
            }
            string operationID = fld_cmbOperations.EditValue != null ? fld_cmbOperations.EditValue.ToString() : null;

            int batchProductID = 0;
            if (fld_lkeMMBatchProductID.EditValue != null)
            {
                Int32.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out batchProductID);
            }

            if (batchProductID == 0 && !((OperationDetailPlanModule)Module).ODPMultiBatchInsert)
            {
                BOSApp.ShowMessage("Vui lòng chọn LSX.");
                fld_lkeMMBatchProductID.Focus();
                return;
            }
            if (fld_lkeMMBatchProductID.EditValue != null)
            {
                MMBatchProductsInfo objBatchProductsInfo = new MMBatchProductsInfo();
                DataRowView dataRow = (DataRowView)fld_lkeMMBatchProductID.GetSelectedDataRow();
                if (dataRow != null)
                    objBatchProductsInfo = (MMBatchProductsInfo)(new MMBatchProductsController()).GetObjectFromDataRow(dataRow.Row);
                if (objBatchProductsInfo.MMBatchProductID > 0
                    && (objBatchProductsInfo.MMBatchProductWoodStatus == Status.New.ToString() || objBatchProductsInfo.MMBatchProductWoodStatus == Status.Verified.ToString()))
                {
                    BOSApp.ShowMessage("Không được phép thêm công việc cho LSX này vì KHSXCT của LSX này chưa hoạt động (vui lòng Duyệt BTP của LSX)");
                    return;
                }
                else if (objBatchProductsInfo.MMBatchProductID > 0 && objBatchProductsInfo.MMBatchProductWoodStatus == Status.Closed.ToString())
                {
                    BOSApp.ShowMessage("Không được phép thêm công việc cho LSX này vì KHSXCT của LSX này đã đóng");
                    return;
                }
            }

            List<MMBatchProductProductionNormItemsViewInfo> bpptnormItemList = new List<MMBatchProductProductionNormItemsViewInfo>();

            bpptnormItemList = objBpptnromItemController.GetListItemRemainBySomeCriteria(fromdate, todate, customerID, collectionID, branchID, TTMTID, operationID, batchProductID, BOSApp.CurrentUsersInfo.ADUserID);
            if (bpptnormItemList != null && bpptnormItemList.Count > 0)
                bpptnormItemList.ForEach(o =>
                {
                    o.MMOperationDetailPlanItemChildExecutionFromDate = planFromdate;
                    o.MMOperationDetailPlanItemChildExecutionToDate = PlanTodate;
                });
            ICProductSemisController ctlSemi = new ICProductSemisController();
            ProductSemiList = ctlSemi.GetListItemRemainBySomeCriteria(fromdate, todate, customerID, collectionID, branchID, TTMTID, operationID, batchProductID, BOSApp.CurrentUsersInfo.ADUserID);

            fld_dgcMMBatchProductProductionNormItems.DataSource = bpptnormItemList;
            UpdateSearchDataSourceForNotExitsEntityList();

            InvalidateMachineUnit(null, false);
        }
        private void fld_chkSelectAllBatchProductItemOperation_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckedAllByFilterCondition(fld_chkSelectAll.Checked);
            fld_dgcMMBatchProductProductionNormItems.RefreshDataSource();
            InvalidateMachineUnit(null, false);
        }

        private void Fld_dteFromDateDetail_Validated(object sender, EventArgs e)
        {
            //if (fld_dteFromDateDetail.OldEditValue != fld_dteFromDateDetail.EditValue)
            //{
            //    if (fld_dteFromDateDetail.DateTime.Date < planFromdate.Date)
            //    {
            //        fld_dteFromDateDetail.EditValue = fld_dteFromDateDetail.OldEditValue;
            //        MessageBox.Show("Giá trị bạn chọn nhỏ hơn \"từ ngày\" kế hoạch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    if (fld_dteFromDateDetail.DateTime.Date > PlanTodate.Date)
            //    {
            //        fld_dteFromDateDetail.EditValue = fld_dteFromDateDetail.OldEditValue;
            //        MessageBox.Show("Giá trị bạn chọn lớn hơn \"đến ngày\" kế hoạch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void Fld_dteToDateDetail_Validated(object sender, EventArgs e)
        {
            //if (fld_dteToDateDetail.OldEditValue != fld_dteToDateDetail.EditValue)
            //{
            //    if (fld_dteFromDateDetail.DateTime.Date > PlanTodate.Date)
            //    {
            //        fld_dteToDateDetail.EditValue = fld_dteToDateDetail.OldEditValue;
            //        MessageBox.Show("Giá trị bạn chọn lớn hơn \"đến ngày\" kế hoạch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void Fld_btnUpdatePosition_Click(object sender, EventArgs e)
        {
            int workShopID = 0;
            int lineID = 0;
            if (fld_lkeFK_MMWorkShopID.EditValue != null)
                int.TryParse(fld_lkeFK_MMWorkShopID.EditValue.ToString(), out workShopID);
            if (fld_lkeFK_MMLineID.EditValue != null)
                int.TryParse(fld_lkeFK_MMLineID.EditValue.ToString(), out lineID);
            productionNormList = (List<MMBatchProductProductionNormItemsViewInfo>)fld_dgcMMBatchProductProductionNormItems.DataSource;
            List<MMBatchProductProductionNormItemsViewInfo> fillterList = productionNormList;
            GridView gridView = (GridView)fld_dgcMMBatchProductProductionNormItems.MainView;
            List<MMBatchProductProductionNormItemsViewInfo> objects = new List<MMBatchProductProductionNormItemsViewInfo>();
            for (int j = 0; j < gridView.RowCount; j++)
            {
                MMBatchProductProductionNormItemsViewInfo item = (MMBatchProductProductionNormItemsViewInfo)gridView.GetRow(j);
                if (item != null)
                {
                    objects.Add(item);
                }
            }
            if (productionNormList != null && productionNormList.Where(o => o.Selected).Count() > 0)
            {
                if (BOSApp.ShowMessageYesNo("Bạn chắc chắn muốn cập nhật các chi tiết đã chọn?") == DialogResult.Yes)
                {
                    productionNormList.ForEach(o =>
                    {
                        MMBatchProductProductionNormItemsViewInfo found = objects.Where(f => f.MMBatchProductProductionNormItemID == o.MMBatchProductProductionNormItemID).FirstOrDefault();
                        if (o.Selected && found != null && found.MMBatchProductProductionNormItemID > 0)
                        {
                            o.FK_MMWorkShopID = workShopID > 0 ? workShopID : o.FK_MMWorkShopID;
                            o.FK_MMLineID = lineID > 0 ? lineID : o.FK_MMLineID;
                            o.IsError = false;
                        }
                    });
                    fld_dgcMMBatchProductProductionNormItems.RefreshDataSource();
                }
            }
            else
            {
                if (SelectedNormList.Where(o => o.Selected).Count() > 0)
                {
                    if (BOSApp.ShowMessageYesNo("Bạn chắc chắn muốn cập nhật các chi tiết đã chọn?") == DialogResult.Yes)
                    {
                        SelectedNormList.ForEach(o =>
                        {
                            if (o.Selected)
                            {
                                o.FK_MMWorkShopID = workShopID > 0 ? workShopID : o.FK_MMWorkShopID;
                                o.FK_MMLineID = lineID > 0 ? lineID : o.FK_MMLineID;
                                o.IsError = false;
                            }
                        });
                    }
                }
                else
                {
                    BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
                    fld_chkSelectAllCalendar.Focus();
                }

            }
        }

        private void Fld_UpdateQty_Click(object sender, EventArgs e)
        {
            if (fld_txtQty.Text == null) return;
            decimal sL = 0;
            decimal.TryParse(fld_txtQty.Text.TrimEnd(), out sL);

            bool isError = false;
            productionNormList = (List<MMBatchProductProductionNormItemsViewInfo>)fld_dgcMMBatchProductProductionNormItems.DataSource;
            List<MMBatchProductProductionNormItemsViewInfo> fillterList = productionNormList;
            GridView gridView = (GridView)fld_dgcMMBatchProductProductionNormItems.MainView;
            List<MMBatchProductProductionNormItemsViewInfo> objects = new List<MMBatchProductProductionNormItemsViewInfo>();
            for (int j = 0; j < gridView.RowCount; j++)
            {
                MMBatchProductProductionNormItemsViewInfo item = (MMBatchProductProductionNormItemsViewInfo)gridView.GetRow(j);
                if (item != null)
                {
                    objects.Add(item);
                }
            }
            if (productionNormList != null && productionNormList.Where(o => o.Selected).Count() > 0)
            {
                if (sL > 0 && BOSApp.ShowMessageYesNo("Bạn chắc chắn muốn cập nhật các chi tiết đã chọn?") == DialogResult.Yes)
                {
                    productionNormList.ForEach(o => { if (o.Selected && o.MMBatchProductProductionNormItemRemainQty < sL) { o.IsError = true; isError = true; } });
                    if (isError)
                    {
                        BOSApp.ShowMessage("SL cập nhật vượt SL tối đa có thể kế hoạch");
                        fld_txtQty.Focus();
                        return;
                    }
                    productionNormList.ForEach(o =>
                    {
                        MMBatchProductProductionNormItemsViewInfo found = objects.Where(f => f.MMBatchProductProductionNormItemID == o.MMBatchProductProductionNormItemID).FirstOrDefault();
                        if (o.Selected && found != null && found.MMBatchProductProductionNormItemID > 0)
                        { o.MMOperationDetailPlanItemChildPlanProductQty = sL; o.IsError = false; }
                    });
                    fld_dgcMMBatchProductProductionNormItems.RefreshDataSource();
                }
            }
            else
            {
                BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
                fld_chkSelectAll.Focus();
            }
        }

        private void Fld_bteHRDepartmentRoomGroupItemID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
        public void ShowHumanUnit(List<MMBatchProductProductionNormItemsViewInfo> fillterList)
        {
            guiChooseHumanUnit gui = new guiChooseHumanUnit();
            gui.DetailPlanSelected = fillterList.Where(o => o.Selected).ToList();
            gui.Module = this.Module;
            gui.ShowDialog();
            if (gui.DialogResult == DialogResult.OK)
            {
                productionNormList.ForEach(s =>
                {
                    if (s.Selected)
                    {
                        s.HumanUnit = new List<MMDetailPlanHumanUnitsInfo>();
                    }
                });
                if (gui.ResultList != null && gui.ResultList.Count > 0)
                {
                    //Add
                    productionNormList.ForEach(s =>
                    {
                        if (s.Selected)
                        {
                            if (gui.ResultList != null && gui.ResultList.Count > 0)
                                gui.ResultList.ForEach(hu =>
                                {
                                    MMDetailPlanHumanUnitsInfo hUnit = new MMDetailPlanHumanUnitsInfo();
                                    hUnit.FK_HREmployeeID = hu.HREmployeeID;
                                    hUnit.FK_HRDepartmentRoomGroupItemID = hu.HRDepartmentRoomGroupItemParentID;
                                    hUnit.FK_MMOperationID = s.FK_MMOperationID;
                                    hUnit.FK_MMBatchProductProductionNormItemID = s.MMBatchProductProductionNormItemID;
                                    if (s.HumanUnit == null) s.HumanUnit = new List<MMDetailPlanHumanUnitsInfo>();
                                    MMDetailPlanHumanUnitsInfo mExitUnit = s.HumanUnit.Where(o => o.FK_MMBatchProductProductionNormItemID == s.MMBatchProductProductionNormItemID
                                                                                                        && o.FK_MMOperationID == s.FK_MMOperationID
                                                                                                        && o.FK_HREmployeeID == hu.HREmployeeID
                                                                                                        && o.FK_HRDepartmentRoomGroupItemID == hu.HRDepartmentRoomGroupItemID).FirstOrDefault();
                                    if (mExitUnit == null || mExitUnit.FK_MMBatchProductProductionNormItemID == 0)
                                        s.HumanUnit.Add(hUnit);
                                });
                            else
                            {
                                s.HumanUnit = new List<MMDetailPlanHumanUnitsInfo>();
                            }
                        }
                    });
                }
            }
        }
        private void Fld_bedMMMachineUnitID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            productionNormList = (List<MMBatchProductProductionNormItemsViewInfo>)fld_dgcMMBatchProductProductionNormItems.DataSource;
            if (productionNormList != null)
            {
                if (productionNormList.Where(o => o.Selected).Count() == 0)
                {
                    BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
                    fld_chkSelectAll.Focus();
                    return;
                }
                else
                {
                    ShowMachineUnit(productionNormList.Where(o => o.Selected).ToList());
                }
            }
        }
        public void ShowMachineUnit(List<MMBatchProductProductionNormItemsViewInfo> fillterList)
        {
            guiChooseMachineUnit gui = new guiChooseMachineUnit();
            gui.DetailPlanSelected = fillterList.Where(o => o.Selected).ToList();
            gui.Module = this.Module;
            gui.ShowDialog();
            if (gui.DialogResult == DialogResult.OK)
            {
                productionNormList.ForEach(s =>
                {
                    if (s.Selected)
                    {
                        s.MachineUnit = new List<MMDetailPlanMachineUnitsInfo>();
                    }
                });
                if (gui.ResultList != null && gui.ResultList.Count > 0)
                {
                    // Add
                    productionNormList.ForEach(s =>
                    {
                        if (s.Selected)
                        {
                            if (gui.ResultList != null && gui.ResultList.Count > 0)
                                gui.ResultList.ForEach(hu =>
                                {
                                    MMDetailPlanMachineUnitsInfo mUnit = new MMDetailPlanMachineUnitsInfo();
                                    mUnit.FK_ACAssetID = hu.FK_ACAssetID;
                                    mUnit.FK_MMMachineUnitID = hu.MMMachineUnitID;
                                    mUnit.FK_MMOperationID = s.FK_MMOperationID;
                                    mUnit.FK_MMBatchProductProductionNormItemID = s.MMBatchProductProductionNormItemID;
                                    if (s.MachineUnit == null) s.MachineUnit = new List<MMDetailPlanMachineUnitsInfo>();
                                    MMDetailPlanMachineUnitsInfo mExitUnit = s.MachineUnit.Where(o => o.FK_MMBatchProductProductionNormItemID == s.MMBatchProductProductionNormItemID
                                                                                                        && o.FK_MMOperationID == s.FK_MMOperationID
                                                                                                         && o.FK_ACAssetID == hu.FK_ACAssetID
                                                                                                        && o.FK_MMMachineUnitID == hu.MMMachineUnitID).FirstOrDefault();
                                    if (mExitUnit == null || mExitUnit.FK_MMBatchProductProductionNormItemID == 0)
                                        s.MachineUnit.Add(mUnit);
                                });
                        }
                    });
                }
            }
        }
        private void Fld_btnLate_Click(object sender, EventArgs e)
        {
            SearchData("Late");
        }

        private void Fld_lblSelectAll_Click(object sender, EventArgs e)
        {
            fld_chkALittlePlaned.Checked = true;
            fld_chkNotJetPlaned.Checked = true;
            FilterData();
        }
        private void Fld_chkNotJetPlaned_CheckedChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void Fld_chkALittlePlaned_CheckedChanged(object sender, EventArgs e)
        {
            FilterData();
        }
        #endregion
        #region Data & Ultility
        public void InitDataSourceOperations()
        {
            MMOperationsController operationController = new MMOperationsController();
            List<MMOperationsInfo> operationList = operationController.GetPlanOperationsByUserID(BOSApp.CurrentCompanyInfo.FK_BRBranchID, BOSApp.CurrentUsersInfo.ADUserID);
            fld_cmbOperations.Properties.DataSource = operationList;
        }
        public void CheckedAllByFilterCondition(bool isChecked)
        {
            GridView gridView = (GridView)fld_dgcMMBatchProductProductionNormItems.MainView;
            List<MMBatchProductProductionNormItemsViewInfo> listView = new List<MMBatchProductProductionNormItemsViewInfo>();

            List<MMBatchProductProductionNormItemsViewInfo> objects = new List<MMBatchProductProductionNormItemsViewInfo>();
            for (int j = 0; j < gridView.RowCount; j++)
            {
                MMBatchProductProductionNormItemsViewInfo item = (MMBatchProductProductionNormItemsViewInfo)gridView.GetRow(j);
                if (item != null)
                {
                    objects.Add(item);
                }
            }

            if (objects != null)
            {
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMBatchProductProductionNormItemsViewInfo objDataViewPermissionsInfo = (MMBatchProductProductionNormItemsViewInfo)gridView.GetRow(j);
                    if (objDataViewPermissionsInfo != null)
                    {
                        listView.Add(objDataViewPermissionsInfo);
                    }
                }
                for (int i = 0; i < objects.Count; i++)
                {
                    foreach (var dataViewItem in listView)
                    {
                        if (objects[i] == dataViewItem)
                        {
                            objects[i].Selected = isChecked;
                        }
                    }

                }
            }
        }
        public void CheckedAllResourceByFilterCondition(bool isChecked)
        {
            GridView gridView = (GridView)fld_dgcMMMachineUnits.MainView;
            List<MMMachineUnitsInfo> listView = new List<MMMachineUnitsInfo>();

            List<MMMachineUnitsInfo> objects = new List<MMMachineUnitsInfo>();
            for (int j = 0; j < gridView.RowCount; j++)
            {
                MMMachineUnitsInfo item = (MMMachineUnitsInfo)gridView.GetRow(j);
                if (item != null)
                {
                    objects.Add(item);
                }
            }

            if (objects != null)
            {
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMMachineUnitsInfo objDataViewPermissionsInfo = (MMMachineUnitsInfo)gridView.GetRow(j);
                    if (objDataViewPermissionsInfo != null)
                    {
                        listView.Add(objDataViewPermissionsInfo);
                    }
                }
                for (int i = 0; i < objects.Count; i++)
                {
                    foreach (var dataViewItem in listView)
                    {
                        if (objects[i] == dataViewItem)
                        {
                            objects[i].Selected = isChecked;
                        }
                    }

                }
            }
        }
        public void CheckedAllCalendarByFilterCondition(bool isChecked)
        {
            GridView gridView = (GridView)fld_dgcSelectNormItems.MainView;
            List<MMBatchProductProductionNormItemsViewInfo> listView = new List<MMBatchProductProductionNormItemsViewInfo>();

            List<MMBatchProductProductionNormItemsViewInfo> objects = new List<MMBatchProductProductionNormItemsViewInfo>();
            for (int j = 0; j < gridView.RowCount; j++)
            {
                MMBatchProductProductionNormItemsViewInfo item = (MMBatchProductProductionNormItemsViewInfo)gridView.GetRow(j);
                if (item != null)
                {
                    objects.Add(item);
                }
            }

            if (SelectedNormList != null)
            {
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMBatchProductProductionNormItemsViewInfo objDataViewPermissionsInfo = (MMBatchProductProductionNormItemsViewInfo)gridView.GetRow(j);
                    if (objDataViewPermissionsInfo != null)
                    {
                        listView.Add(objDataViewPermissionsInfo);
                    }
                }
                foreach (MMBatchProductProductionNormItemsViewInfo dataViewItem in listView)
                {
                    MMBatchProductProductionNormItemsViewInfo obj = SelectedNormList.Where(o => o.MMBatchProductProductionNormItemID == dataViewItem.MMBatchProductProductionNormItemID && o.FK_MMOperationID == dataViewItem.FK_MMOperationID).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.Selected = isChecked;
                    }
                }
            }
            fld_dgcSelectNormItems.RefreshDataSource();
        }
        public void UpdateSearchDataSourceForNotExitsEntityList()
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)this.Module).CurrentModuleEntity;
            List<MMBatchProductProductionNormItemsViewInfo> bpptnormItemList = (List<MMBatchProductProductionNormItemsViewInfo>)fld_dgcMMBatchProductProductionNormItems.DataSource;
            MMOperationDetailPlanItemChildsController objController = new MMOperationDetailPlanItemChildsController();
            for (int i = bpptnormItemList.Count; i > 0; i--)
            {

                MMBatchProductProductionNormItemsViewInfo item = bpptnormItemList[i - 1];
                List<MMOperationDetailPlanItemChildsInfo> exititem = entity.OperationDetailPlanItemChildsList.Where(t => (t.FK_MMBatchProductProductionNormItemID == item.MMBatchProductProductionNormItemID
                                                                           && t.FK_MMOperationID == item.FK_MMOperationID
                                                                           && t.FK_MMBatchProductItemID == item.FK_MMBatchProductItemID
                                                                           && t.FK_ICProductID == item.FK_ICProductID
                                                                           && t.MMOperationDetailPlanItemChildID == 0
                                                                           && t.MMOperationDetailPlanItemChildStatus != DetailPlanItemChildStatus.Canceled.ToString())).ToList();

                if (exititem != null && exititem.Sum(o => o.MMOperationDetailPlanItemChildPlanProductQty) > 0 && item.MMOperationDetailPlanItemChildRemainQty > exititem.Sum(o => o.MMOperationDetailPlanItemChildPlanProductQty))
                {
                    item.MMOperationDetailPlanItemChildPlanProductQty = item.MMOperationDetailPlanItemChildRemainQty - exititem.Sum(o => o.MMOperationDetailPlanItemChildPlanProductQty);
                    item.MMBatchProductProductionNormItemRemainQty = item.MMOperationDetailPlanItemChildRemainQty - exititem.Sum(o => o.MMOperationDetailPlanItemChildPlanProductQty);
                }
                else if (exititem != null && exititem.Sum(o => o.MMOperationDetailPlanItemChildPlanProductQty) > 0)
                    bpptnormItemList.Remove(item);
            }
            fld_dgcMMBatchProductProductionNormItems.DataSource = bpptnormItemList;
            productionNormList = bpptnormItemList;
            fld_dgcMMBatchProductProductionNormItems.RefreshDataSource();

        }
        public void UpdateDataSourceForNotExitsEntityList()
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)this.Module).CurrentModuleEntity;
            List<MMBatchProductProductionNormItemsViewInfo> bpptnormItemList = SelectedNormList.Where(o => o.Selected).ToList();
            MMOperationDetailPlanItemChildsController objController = new MMOperationDetailPlanItemChildsController();
            for (int i = bpptnormItemList.Count; i > 0; i--)
            {
                MMBatchProductProductionNormItemsViewInfo item = bpptnormItemList[i - 1];
                //List<MMOperationDetailPlanItemChildsInfo> exititem = entity.OperationDetailPlanItemChildsList.Where(t => (t.FK_MMBatchProductProductionNormItemID == item.MMBatchProductProductionNormItemID
                //                                                           && t.FK_MMOperationID == item.FK_MMOperationID
                //                                                           && t.FK_MMBatchProductItemID == item.FK_MMBatchProductItemID
                //                                                           && t.FK_ICProductID == item.FK_ICProductID
                //                                                           && t.MMOperationDetailPlanItemChildStatus != DetailPlanItemChildStatus.Canceled.ToString())).ToList();

                //if (exititem != null && exititem.Sum(o => o.MMOperationDetailPlanItemChildPlanProductQty) > 0 && item.MMOperationDetailPlanItemChildRemainQty > exititem.Sum(o => o.MMOperationDetailPlanItemChildPlanProductQty))
                //{
                //    item.MMOperationDetailPlanItemChildPlanProductQty = item.MMOperationDetailPlanItemChildRemainQty - exititem.Sum(o => o.MMOperationDetailPlanItemChildPlanProductQty);
                //    item.MMBatchProductProductionNormItemRemainQty = item.MMOperationDetailPlanItemChildRemainQty - exititem.Sum(o => o.MMOperationDetailPlanItemChildPlanProductQty);
                //}
                //else if (exititem != null && exititem.Sum(o => o.MMOperationDetailPlanItemChildPlanProductQty) > 0)
                //{
                //    SelectedNormList.Remove(item);
                //}
                SelectedNormList.Remove(item);
            }
            fld_dgcSelectNormItems.RefreshDataSource();

        }
        public void FilterData()
        {
            List<MMBatchProductProductionNormItemsViewInfo> bindingList = new List<MMBatchProductProductionNormItemsViewInfo>();
            //Bind object list to grid for searching
            //productionNormList = (List<MMBatchProductProductionNormItemsViewInfo>)fld_dgcMMBatchProductProductionNormItems.DataSource;
            fld_dgcMMBatchProductProductionNormItems.DataSource = productionNormList;
            fld_dgcMMBatchProductProductionNormItems.RefreshDataSource();

            for (int i = 0; i < productionNormList.Count; i++)
            {
                MMBatchProductProductionNormItemsViewInfo obj = (MMBatchProductProductionNormItemsViewInfo)productionNormList[i].Clone();
                if (obj.MMBatchProductProductionNormItemQuantity == obj.MMBatchProductProductionNormItemRemainQty)
                    if (fld_chkNotJetPlaned.Checked && bindingList.IndexOf(obj) <= 0)
                        bindingList.Add(obj);
                    else
                    {
                        int iIndex = bindingList.IndexOf(obj);
                        if (iIndex >= 0)
                            bindingList.RemoveAt(iIndex);
                    }
                else if (obj.MMBatchProductProductionNormItemRemainQty < obj.MMBatchProductProductionNormItemQuantity
                        && obj.MMBatchProductProductionNormItemQuantity > 0)
                    if (fld_chkALittlePlaned.Checked && bindingList.IndexOf(obj) <= 0)
                        bindingList.Add(obj);
                    else
                    {
                        int iIndex = bindingList.IndexOf(obj);
                        if (iIndex >= 0)
                            bindingList.RemoveAt(iIndex);
                    }
            }
            fld_dgcMMBatchProductProductionNormItems.DataSource = bindingList;
            fld_dgcMMBatchProductProductionNormItems.RefreshDataSource();

        }
        public void SearchData(String keyWord)
        {

            GridView gridView = (GridView)fld_dgcMMBatchProductProductionNormItems.MainView;
            if (!String.IsNullOrEmpty(keyWord))
            {
                List<GridColumn> lstColVisible = new List<GridColumn>();
                for (int i = 0; i < gridView.Columns.Count; i++)
                {
                    if (gridView.Columns[i].VisibleIndex >= 0 || gridView.Columns[i].GroupIndex >= 0)
                    {
                        lstColVisible.Add(gridView.Columns[i]);
                    }
                }
                List<MMBatchProductProductionNormItemsViewInfo> bindingList = new List<MMBatchProductProductionNormItemsViewInfo>();

                //Bind object list to grid for searching
                fld_dgcMMBatchProductProductionNormItems.DataSource = productionNormList;
                fld_dgcMMBatchProductProductionNormItems.RefreshDataSource();

                for (int i = 0; i < productionNormList.Count; i++)
                {
                    MMBatchProductProductionNormItemsViewInfo obj = productionNormList[i];
                    bool isExist = IsTypeFilter(keyWord, obj);
                    if (isExist)
                    {
                        bindingList.Add(obj);
                    }
                }
                fld_dgcMMBatchProductProductionNormItems.DataSource = bindingList;
                fld_dgcMMBatchProductProductionNormItems.RefreshDataSource();
            }
            else
            {
                fld_dgcMMBatchProductProductionNormItems.DataSource = productionNormList;
                fld_dgcMMBatchProductProductionNormItems.RefreshDataSource();
            }
        }
        public bool IsTypeFilter(string type, MMBatchProductProductionNormItemsViewInfo obj)
        {
            bool result = false;
            switch (type)
            {
                case "NotJet":
                    if (obj.MMBatchProductProductionNormItemQuantity == obj.MMBatchProductProductionNormItemRemainQty)
                        result = true;
                    break;
                case "ALittle":
                    if (obj.MMBatchProductProductionNormItemRemainQty < obj.MMBatchProductProductionNormItemQuantity
                        && obj.MMBatchProductProductionNormItemQuantity > 0)
                        result = true;
                    break;
                case "Late":
                    DateTime serverDate = BOSApp.GetCurrentServerDate();
                    if (obj.MMBatchProductItemDeliveryDate.Date <= serverDate || obj.MMBatchProductItemDeliveryDate.Date <= planFromdate.Date ||
                        obj.MMBatchProductItemNeededTime.Date <= serverDate || obj.MMBatchProductItemNeededTime.Date <= planFromdate.Date)
                        result = true;
                    break;
                case "All":
                    result = true;
                    if (!fld_chkALittlePlaned.Checked)
                    {
                        if (obj.MMBatchProductProductionNormItemRemainQty < obj.MMBatchProductProductionNormItemQuantity
                        && obj.MMBatchProductProductionNormItemQuantity > 0)
                            result = false;
                    }
                    if (!fld_chkNotJetPlaned.Checked)
                    {
                        if (obj.MMBatchProductProductionNormItemQuantity == obj.MMBatchProductProductionNormItemRemainQty)
                            result = false;
                    }

                    break;
                default:
                    break;
            }
            return result;
        }

        #endregion

        private void Fld_btnUpdateDate_Click(object sender, EventArgs e)
        {
            if (fld_dteFromDateDetail.DateTime.Date > fld_dteToDateDetail.DateTime.Date)
            {
                MessageBox.Show("Ngày thực hiện \"từ ngày\" phải nhỏ hơn hoặc bằng \"đến ngày\"", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                fld_dteFromDateDetail.Focus();
                return;
            }
            //if (fld_dteFromDateDetail.DateTime.Date < planFromdate.Date || fld_dteToDateDetail.DateTime.Date < planFromdate.Date)
            //{
            //    MessageBox.Show("Giá trị bạn chọn nhỏ hơn \"từ ngày\" kế hoạch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    if (fld_dteFromDateDetail.DateTime.Date < planFromdate.Date)
            //        fld_dteFromDateDetail.Focus();
            //    else
            //        fld_dteToDateDetail.Focus();
            //    return;
            //}
            //if (fld_dteToDateDetail.DateTime.Date > PlanTodate.Date || fld_dteFromDateDetail.DateTime.Date > PlanTodate.Date)
            //{
            //    MessageBox.Show("Giá trị bạn chọn lớn hơn \"đến ngày\" kế hoạch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    if (fld_dteFromDateDetail.DateTime.Date > PlanTodate.Date)
            //        fld_dteFromDateDetail.Focus();
            //    else
            //        fld_dteToDateDetail.Focus();
            //    return;
            //}
            productionNormList = (List<MMBatchProductProductionNormItemsViewInfo>)fld_dgcMMBatchProductProductionNormItems.DataSource;
            List<MMBatchProductProductionNormItemsViewInfo> fillterList = productionNormList;
            GridView gridView = (GridView)fld_dgcMMBatchProductProductionNormItems.MainView;
            List<MMBatchProductProductionNormItemsViewInfo> objects = new List<MMBatchProductProductionNormItemsViewInfo>();
            for (int j = 0; j < gridView.RowCount; j++)
            {
                MMBatchProductProductionNormItemsViewInfo item = (MMBatchProductProductionNormItemsViewInfo)gridView.GetRow(j);
                if (item != null)
                {
                    objects.Add(item);
                }
            }
            if (productionNormList.Where(o => o.Selected).Count() > 0)
            {
                if (BOSApp.ShowMessageYesNo("Bạn chắc chắn muốn cập nhật các chi tiết đã chọn?") == DialogResult.Yes)
                {
                    productionNormList.ForEach(o =>
                    {
                        MMBatchProductProductionNormItemsViewInfo found = objects.Where(f => f.MMBatchProductProductionNormItemID == o.MMBatchProductProductionNormItemID).FirstOrDefault();
                        if (o.Selected && found != null && found.MMBatchProductProductionNormItemID > 0)
                        {
                            o.MMOperationDetailPlanItemChildExecutionFromDate = fld_dteFromDateDetail.DateTime;
                            o.MMOperationDetailPlanItemChildExecutionToDate = fld_dteToDateDetail.DateTime;
                            o.IsError = false;
                        }
                    });
                    fld_dgcMMBatchProductProductionNormItems.RefreshDataSource();
                }
            }
            else
            {
                if (SelectedNormList.Where(o => o.Selected).Count() > 0)
                {
                    if (BOSApp.ShowMessageYesNo("Bạn chắc chắn muốn cập nhật các chi tiết đã chọn?") == DialogResult.Yes)
                    {
                        SelectedNormList.ForEach(o =>
                        {
                            if (o.Selected)
                            {
                                o.MMOperationDetailPlanItemChildExecutionFromDate = fld_dteFromDateDetail.DateTime;
                                o.MMOperationDetailPlanItemChildExecutionToDate = fld_dteToDateDetail.DateTime;
                                o.IsError = false;
                            }
                        });
                    }
                }
                else
                {
                    BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
                    fld_chkSelectAll.Focus();
                }
            }
        }

        private void Fld_lkeFK_MMLineID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int workShopID = 0;
            if (fld_lkeFK_MMWorkShopID.EditValue != null) int.TryParse(fld_lkeFK_MMWorkShopID.EditValue.ToString(), out workShopID);
            DataSet ds = new DataSet();
            if (BOSApp.LookupTables.ContainsKey("MMLines"))
                ds = (DataSet)BOSApp.LookupTables["MMLines"];
            if (workShopID > 0)
            {
                if (BOSApp.LookupTables.ContainsKey("MMLines"))
                {
                    if (ds != null && ds.Tables[0] != null)
                    {
                        List<MMLinesInfo> line = (List<MMLinesInfo>)(new MMLinesController()).GetListFromDataSet(ds);
                        if (line != null)
                        {
                            line = line.Where(o => o.FK_MMWorkShopID == workShopID).ToList();
                            if (line != null)
                            {
                                line.Insert(0, new MMLinesInfo());
                                fld_lkeFK_MMLineID.Properties.DataSource = line;
                            }
                        }
                    }
                }
            }
            else
            {
                if (ds != null)
                    fld_lkeFK_MMLineID.Properties.DataSource = ds.Tables[0];
            }
        }

        private void fld_ckeViewByTicket_CheckedChanged(object sender, EventArgs e)
        {
            InvalidateMachineUnit(null, false);
        }

        private void fld_ckeViewByOperation_CheckedChanged(object sender, EventArgs e)
        {
            InvalidateMachineUnit(null, false);
        }
        private void fld_chkAllResource_CheckedChanged(object sender, EventArgs e)
        {
            CheckedAllResourceByFilterCondition(fld_chkAllResource.Checked);
            fld_dgcMMMachineUnits.RefreshDataSource();
        }

        private void fld_btnAddMachine_Click(object sender, EventArgs e)
        {
            AddProductToSelectList();
            fld_chkSelectAll.Checked = false;
        }
        private void fld_btnRemoveSelect_Click(object sender, EventArgs e)
        {
            RemoveProductToSelectList();
            fld_chkSelectAllCalendar.Checked = false;
        }

        private void fld_chkSelectAllCalendar_CheckedChanged(object sender, EventArgs e)
        {
            fld_chkSelectAll.Checked = false;
            CheckedAllCalendarByFilterCondition(fld_chkSelectAllCalendar.Checked);
            fld_dgcSelectNormItems.RefreshDataSource();
        }

        private void fld_lkeBRBranchID_QueryPopUp(object sender, CancelEventArgs e)
        {
            List<BRBranchsInfo> BranchList = ((OperationDetailPlanModule)Module).GetDataBranch();
            if (BranchList != null)
            {
                BranchList.Insert(0, new BRBranchsInfo());
            }
            fld_lkeBRBranchID.Properties.DataSource = BranchList;
        }

        private void fld_btnTicketZoom_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_dgcMMBatchProductProductionNormItems);
        }
        public void ShowFullScreen(Control ctl)
        {
            // Setup host form to be full screen
            guiZoom host = new guiZoom();
            host.MaximizeBox = false;
            host.MinimizeBox = false;
            // Save properties of control
            var loc = ctl.Location;
            var dock = ctl.Dock;
            var parent = ctl.Parent;
            var form = parent;
            var anchor = ctl.Anchor;
            var size = ctl.Size;
            while (!(form is Form)) form = form.Parent;
            // Move control to host
            //ctl.Parent = host;
            host.AddCtrl(ctl);
            ctl.Location = Point.Empty;
            ctl.Dock = DockStyle.Fill;
            // Setup event handler to restore control back to form
            host.FormClosing += delegate
            {
                ctl.Parent = parent;
                ctl.Dock = dock;
                ctl.Location = loc;
                ctl.Anchor = anchor;
                ctl.Size = size;
                form.Refresh();
            };


            // Exit full screen with escape key
            host.KeyPreview = true;
            host.KeyDown += (KeyEventHandler)((s, e) =>
            {
                if (e.KeyCode == Keys.Escape) host.Close();
            });
            // And go full screen
            host.ShowDialog();
            //  form.Hide();
        }

        private void fld_btnTicketZoomCalenda_Click(object sender, EventArgs e)
        {
            ShowFullScreen(fld_dgcSelectNormItems);
        }
    }
}
