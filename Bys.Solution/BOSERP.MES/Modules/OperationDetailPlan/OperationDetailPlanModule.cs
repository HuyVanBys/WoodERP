using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BOSReport;

namespace BOSERP.Modules.OperationDetailPlan
{
    public class OperationDetailPlanModule : BaseTransactionModule
    {
        #region Constants
        public const string NewNo = "***NEW***";
        public const string OperationLookupEditName = "fld_lkeFK_MMOperationID";
        public const string LineLookupEditName = "fld_lkeFK_MMLineID";
        public const string ToDateLookupEditName = "fld_dteToDate";
        public const string FromDateLookupEditName = "fld_dteFromDate";
        public const string DetailPlanWeekBottunEditName = "fld_bedMMOperationDetailPlanWeek";
        public const string CancelHumanBottunEditName = "fld_btnCancelHuman";
        public const string CancelMachineBottunEditName = "fld_btnCancelMachine";
        public const string TicketRemainCheckBoxName = "fld_chkTicketRemain";
        #endregion Constants
        #region Private Properties
        public bool ODPMultiBatch;
        public bool ODPMultiBatchInsert;
        public BOSLookupEdit OperationLookupEditControl;
        public BOSLookupEdit LineLookupEditControl;
        public BOSLookupEdit HumanLookupEditControl;
        public BOSLookupEdit MachineLookupEditControl;
        public BOSDateEdit FromDateLookupEditControl;
        public BOSDateEdit ToDateLookupEditControl;
        public BOSDateEdit SearchFromDateLookupEditControl;
        public BOSDateEdit SearchToDateLookupEditControl;

        public BOSButtonEdit DetailPlanWeekBottunEditControl;
        public ChooseHumanUnitTreeControl HumanUnitTreeListControl;
        public ChooseMachineUnitTreeControl MachineUnitTreeListControl;
        public MMHumanPlanItemsGridControl PlanHumanUnitItemGridControl;
        public MMMachinePlanItemsGridControl PlanMachineUnitItemGridControl;
        public MMTicketPlanItemsGridControl TicketPlanItemGridControl;
        public MMCapacityItemsGridControl CapacityItemGridControl;
        public MMEquipmentPlanItemsGridControl EquipmentPlanItemsGridControl;
        public MMOperationDetailPlanItemChildsGridControl OperationPlanGridControl;
        public BOSButtonEdit HumanOperationComBo;
        public BOSButtonEdit MachineOperationComBo;
        public BOSButtonEdit TicketOperationComBo;
        public BOSButtonEdit TicketHumanComBo;
        public BOSButton CancelHumanBottun;
        public BOSButton CancelMachineBottun;
        public BOSCheckEdit TicketRemainCheckBox;

        public CheckedComboBoxEdit fld_cmbOperations;
        AccObjectLookupEdit fld_lkeFK_ACObjectID;
        BOSLookupEdit fld_lkeSaleOrderID;
        BOSLookupEdit fld_lkeMMBatchProductID;
        BOSTextBox fld_txtProductNo;
        BOSTextBox fld_txtProductName;
        CheckedComboBoxEdit fld_cmbOperationsSearch;
        BOSLookupEdit fld_lkeFK_BRBranchID;
        public List<MMOperationsInfo> OperationHumanSelect { get; set; }
        public List<MMOperationsInfo> OperationMachineSelect { get; set; }
        public List<MMOperationsInfo> OperationTicketSelect { get; set; }
        public List<MMOperationsInfo> OperationData { get; set; }
        public List<HRDepartmentRoomGroupItemsInfo> SelectedTicketHuman { get; set; }
        public List<MMMachineUnitsInfo> SelectedTicketMachine { get; set; }

        #region Plan control
        public BOSCheckEdit fld_chkStatusNew;
        public BOSCheckEdit fld_chkStatusApproved;
        public BOSCheckEdit fld_chkStatusClosed;
        public BOSCheckEdit fld_chkStatusCanceled;
        #endregion

        #region Filter human control
        public BOSCheckEdit TicketNotHaveHuman;// fld_ckeDetailPlanHumanAllowcation
        public BOSCheckEdit TicketHaveHuman;// fld_chkAllHumanDetailPlanItem
        public BOSCheckEdit TicketHumanByOperation;// fld_ckeHumanPlanByOperation
        public BOSCheckEdit HumanNotTicket; //fld_chkHumanNotTicket
        public BOSLookupEdit HumanDepartmentLoopkup; // fld_lkeMMWorshopID
        #endregion

        #region Filter machine control
        public BOSCheckEdit TicketNothaveMachine;// fld_ckeTicketNothaveMachine
        public BOSCheckEdit TicketHaveMachine;// fld_TicketHaveMachine
        public BOSCheckEdit TicketByOperation;// fld_ckeTicketByOperation
        public BOSLookupEdit MachineWorshopControl; // fld_lkeMMWorshopID
        public BOSCheckEdit MachineNotTicketCheckBox; //fld_ckeMachineNotTicket
        public Point bolTicketLocation;
        #endregion
        #endregion Private Properties

        #region Public methods

        public OperationDetailPlanModule()
        {
            Name = "OperationDetailPlan";
            CurrentModuleEntity = new OperationDetailPlanEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            LineLookupEditControl = (BOSLookupEdit)Controls[LineLookupEditName];
            LineLookupEditControl.QueryPopUp += new System.ComponentModel.CancelEventHandler(LineLookupEditControl_QueryPopUp);
            ToDateLookupEditControl = (BOSDateEdit)Controls[ToDateLookupEditName];
            FromDateLookupEditControl = (BOSDateEdit)Controls[FromDateLookupEditName];

            #region Search Control
            SearchFromDateLookupEditControl = (BOSDateEdit)Controls["fld_dteMMOperationDetailPlanFromDate"];
            SearchToDateLookupEditControl = (BOSDateEdit)Controls["fld_dteMMOperationDetailPlanToDate"];
            fld_lkeFK_ACObjectID = (AccObjectLookupEdit)Controls["fld_lkeFK_ACObjectID"];
            fld_lkeSaleOrderID = (BOSLookupEdit)Controls["fld_lkeSaleOrderID"];
            fld_lkeMMBatchProductID = (BOSLookupEdit)Controls["fld_lkeMMBatchProductID"];
            fld_txtProductNo = (BOSTextBox)Controls["fld_txtProductNo"];
            fld_txtProductName = (BOSTextBox)Controls["fld_txtProductName"];
            fld_lkeFK_BRBranchID = (BOSLookupEdit)Controls["fld_lkeFK_BRBranchID"];
            fld_cmbOperationsSearch = (CheckedComboBoxEdit)Controls["fld_cmbOperationsSearch"];

            #endregion

            DetailPlanWeekBottunEditControl = (BOSButtonEdit)Controls[DetailPlanWeekBottunEditName];
            OperationHumanSelect = new List<MMOperationsInfo>();
            OperationMachineSelect = new List<MMOperationsInfo>();
            OperationData = new List<MMOperationsInfo>();
            #region Find Control
            PlanHumanUnitItemGridControl = (MMHumanPlanItemsGridControl)Controls["fld_dgcHumanDetailPlanItems"];
            PlanMachineUnitItemGridControl = (MMMachinePlanItemsGridControl)Controls["fld_dgcMachineDetailPlanItems"];
            TicketPlanItemGridControl = (MMTicketPlanItemsGridControl)Controls["fld_dgcMMTicketPlanItems"];
            TicketPlanItemGridControl = (MMTicketPlanItemsGridControl)Controls["fld_dgcMMTicketPlanItems"];
            CapacityItemGridControl = (MMCapacityItemsGridControl)Controls["fld_dgcCapacityItemsGridControl"];
            EquipmentPlanItemsGridControl = (MMEquipmentPlanItemsGridControl)Controls["fld_dgcMMDetailPlanEquipments"];
            OperationPlanGridControl = (MMOperationDetailPlanItemChildsGridControl)Controls["fld_dgcMMOperationDetailPlanItemChilds"];
            TicketRemainCheckBox = (BOSCheckEdit)Controls[TicketRemainCheckBoxName];
            HumanNotTicket = (BOSCheckEdit)Controls["fld_chkHumanNotTicket"]; //fld_chkHumanNotTicket
            MachineNotTicketCheckBox = (BOSCheckEdit)Controls["fld_ckeMachineNotTicket"];
            HumanDepartmentLoopkup = (BOSLookupEdit)Controls["fld_lkeHumanHRDepartmentID"];
            HumanUnitTreeListControl = (ChooseHumanUnitTreeControl)Controls["fld_trlHumanUnits"];
            if (HumanUnitTreeListControl != null)
            {
                HumanUnitTreeListControl.Module = this;
                HumanUnitTreeListControl.InitializeControl();
            }
            MachineUnitTreeListControl = (ChooseMachineUnitTreeControl)Controls["fld_trlMachineUnits"];
            if (MachineUnitTreeListControl != null)
            {
                MachineUnitTreeListControl.Module = this;
                MachineUnitTreeListControl.InitializeControl();
            }
            HumanOperationComBo = (BOSButtonEdit)Controls["fld_bteHumanOperation"];
            MachineOperationComBo = (BOSButtonEdit)Controls["fld_bteMachineOperation"];
            TicketOperationComBo = (BOSButtonEdit)Controls["fld_bteTicketOperation"];
            TicketHumanComBo = (BOSButtonEdit)Controls["fld_bteTicketHuman"];
            CancelHumanBottun = (BOSButton)Controls[CancelHumanBottunEditName];
            CancelMachineBottun = (BOSButton)Controls[CancelMachineBottunEditName];

            TicketNotHaveHuman = (BOSCheckEdit)Controls["fld_ckeDetailPlanHumanAllowcation"];
            TicketHaveHuman = (BOSCheckEdit)Controls["fld_chkAllHumanDetailPlanItem"];
            TicketHumanByOperation = (BOSCheckEdit)Controls["fld_ckeHumanPlanByOperation"];

            TicketNothaveMachine = (BOSCheckEdit)Controls["fld_ckeTicketNothaveMachine"];
            TicketHaveMachine = (BOSCheckEdit)Controls["fld_TicketHaveMachine"];
            TicketByOperation = (BOSCheckEdit)Controls["fld_ckeTicketByOperation"];
            MachineWorshopControl = (BOSLookupEdit)Controls["fld_lkeMMWorshopID"];
            HumanLookupEditControl = (BOSLookupEdit)Controls["fld_lkeHuman"];
            MachineLookupEditControl = (BOSLookupEdit)Controls["fld_lkeMachine"];
            if (HumanLookupEditControl != null)
                LookupData(HumanLookupEditControl);
            if (MachineLookupEditControl != null)
                LookupData(MachineLookupEditControl);

            BOSCheckEdit fld_chkStatusNew = (BOSCheckEdit)Controls["fld_chkStatusNew"];
            BOSCheckEdit fld_chkStatusApproved = (BOSCheckEdit)Controls["fld_chkStatusApproved"];
            BOSCheckEdit fld_chkStatusClosed = (BOSCheckEdit)Controls["fld_chkStatusClosed"];
            BOSCheckEdit fld_chkStatusCanceled = (BOSCheckEdit)Controls["fld_chkStatusCanceled"];

            #endregion

            InvalidateToolbar();
            InitDataSourceOperations();
            SelectedTicketHuman = new List<HRDepartmentRoomGroupItemsInfo>();
            SelectedTicketMachine = new List<MMMachineUnitsInfo>();
            BOSLine fld_bolJob = (BOSLine)Controls["fld_bolJob"];
            if (fld_bolJob != null) bolTicketLocation = new Point(fld_bolJob.Location.X, fld_bolJob.Location.Y);

            BOSLine fld_bolDate = (BOSLine)Controls["fld_bolDate"];
            BOSLine fld_bolWorkCenter = (BOSLine)Controls["fld_bolWorkCenter"];
            BOSLine fld_bolTicket = (BOSLine)Controls["fld_bolTicket"];
            BOSLine fld_bolEquipment = (BOSLine)Controls["fld_bolEquipment"];
            if (fld_bolDate != null) fld_bolDate.Visible = true;
            if (fld_bolJob != null) { fld_bolJob.Visible = true; fld_bolJob.Location = bolTicketLocation; }
            if (fld_bolTicket != null) fld_bolTicket.Visible = false;
            if (fld_bolWorkCenter != null) fld_bolWorkCenter.Visible = true;
            if (fld_bolEquipment != null) fld_bolEquipment.Visible = false;
            fld_cmbOperations = (CheckedComboBoxEdit)Controls["fld_cmbOperations"];
            InitDataSourceSearchOperations();
            DefaultWeek();

            string stODPMultiBatch = ADConfigValueUtility.GetConfigTextByGroupAndValue("ODPMultiBatch", "true");
            ODPMultiBatch = bool.Parse(stODPMultiBatch != string.Empty ? stODPMultiBatch : "false");
            string stODPMultiBatchInsert = ADConfigValueUtility.GetConfigTextByGroupAndValue("ODPMultiBatchInsert", "true");
            ODPMultiBatchInsert = bool.Parse(stODPMultiBatchInsert != string.Empty ? stODPMultiBatchInsert : "false");
        }

        public void LookupData(BOSLookupEdit lookup)
        {
            List<ObjectLookUp> human = new List<ObjectLookUp>();
            ObjectLookUp item = new ObjectLookUp();
            item.Code = "All";
            item.Name = "Tất cả";
            human.Add(item);
            item = new ObjectLookUp();
            item.Code = "Exits";
            item.Name = "Đã gán";
            human.Add(item);
            item = new ObjectLookUp();
            item.Code = "NotExits";
            item.Name = "Chưa gán";
            human.Add(item);
            if (lookup != null)
            {
                lookup.Properties.DisplayMember = "Name";
                lookup.Properties.ValueMember = "Code";
                lookup.Properties.DataSource = human;
                lookup.EditValue = "All";
            }
        }
        public List<BRBranchsInfo> GetDataBranch()
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            List<BRBranchsInfo> BranchList = objBranchsController.GetAllBranchByUserPermission(BOSApp.CurrentUsersInfo.ADUserID, BOSApp.CurrentCompanyInfo.FK_BRBranchID, ModuleName.Branch, ADDataViewPermissionType.Module);
            return BranchList;
        }

        #region Action 
        public void EnableControlPage(XtraTabPage page)
        {
            string pageName = page.Name;
            BOSLine fld_bolDate = (BOSLine)Controls["fld_bolDate"];
            BOSLine fld_bolWorkCenter = (BOSLine)Controls["fld_bolWorkCenter"];
            BOSLine fld_bolJob = (BOSLine)Controls["fld_bolJob"];
            BOSLine fld_bolTicket = (BOSLine)Controls["fld_bolTicket"];
            BOSLine fld_bolEquipment = (BOSLine)Controls["fld_bolEquipment"];

            switch (pageName)
            {
                case "fld_tabDetailPlan":
                    if (fld_bolDate != null) fld_bolDate.Visible = true;
                    if (fld_bolJob != null) { fld_bolJob.Visible = true; fld_bolJob.Location = bolTicketLocation; }
                    if (fld_bolTicket != null) fld_bolTicket.Visible = false;
                    if (fld_bolEquipment != null) fld_bolEquipment.Visible = false;
                    if (fld_bolWorkCenter != null) fld_bolWorkCenter.Visible = true;

                    break;
                case "fld_tabHumanUnit":
                case "fld_tabMachineUnit":

                    if (fld_bolDate != null) fld_bolDate.Visible = false;
                    if (fld_bolJob != null) fld_bolJob.Visible = false;
                    if (fld_bolTicket != null) fld_bolTicket.Visible = false;
                    if (fld_bolWorkCenter != null) fld_bolWorkCenter.Visible = false;
                    if (fld_bolEquipment != null) fld_bolEquipment.Visible = false;
                    if (pageName == "fld_tabHumanUnit")
                        ValidateTreeDatasource(true);
                    else
                        ValidateTreeDatasource(false);
                    break;
                case "fld_tabJobTicket":
                    if (fld_bolDate != null) fld_bolDate.Visible = false;
                    if (fld_bolTicket != null) { fld_bolTicket.Visible = true; fld_bolTicket.Location = fld_bolDate.Location; }
                    if (fld_bolJob != null) fld_bolJob.Visible = false;
                    if (fld_bolWorkCenter != null) fld_bolWorkCenter.Visible = false;
                    if (fld_bolEquipment != null) fld_bolEquipment.Visible = false;
                    break;
                case "fld_xtabEquipment":
                    if (fld_bolDate != null) fld_bolDate.Visible = false;
                    if (fld_bolTicket != null) fld_bolTicket.Visible = false;
                    if (fld_bolEquipment != null) { fld_bolEquipment.Visible = true; fld_bolEquipment.Location = fld_bolDate.Location; }
                    if (fld_bolJob != null) fld_bolJob.Visible = false;
                    if (fld_bolWorkCenter != null) fld_bolWorkCenter.Visible = false;
                    break;
                default:
                    break;
            }
        }
        public void ValidateTreeDatasource(bool ishuman)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            List<string> opID = new List<string>();
            if (entity.OperationDetailPlanItemChildsList != null)
            {
                opID = entity.OperationDetailPlanItemChildsList.Select(o => o.FK_MMOperationID.ToString()).Distinct().ToList();
                OperationHumanSelect.Clear();
                OperationMachineSelect.Clear();
                foreach (var item in opID)
                {
                    OperationData.ForEach(op =>
                    {
                        if (op.MMOperationID.ToString() == item)
                        {
                            OperationHumanSelect.Add((MMOperationsInfo)op.Clone());
                            OperationMachineSelect.Add((MMOperationsInfo)op.Clone());
                        }
                    });
                }
            }
            if (ishuman)
                GetTreeHumanDataSource(true, string.Join(",", opID.ToArray()), 0);
            else
                GetTreeMachineDataSource(true, string.Join(",", opID.ToArray()), 0);
        }
        public override void ActionEdit()
        {
            ActionInvalidate(1);
            if (Toolbar.Edit())
            {
                //Invalidate toolbar after edit action
                ParentScreen.InvalidateToolbarAfterActionEdit();

                //Activate Main Screen
                if (ActiveScreen.IsSearchMainScreen())
                {
                    BOSERPScreen _guiDataMain = (BOSERPScreen)GetDataMainScreen(null, String.Empty);
                    ActiveScreen = _guiDataMain;
                }

                //Invalidate controls
                InvalidateFieldGroupControls(BaseToolbar.ModusEdit);
                if (ParentScreen.IsObjectListExpanded)
                {
                    ParentScreen.CollapseObjectList();
                }

                //Save User Audit
            }
            else
            {
                DevExpress.XtraBars.BarButtonItem barbtnEdit = (BarButtonItem)ParentScreen.GetToolbarButton(BaseToolbar.ToolbarButtonEdit);
                barbtnEdit.Down = false;
            }
        }
        public override void ActionCancel()
        {
            base.ActionCancel();
            InvalidateBySearch();
        }
        public void SearchDetailPlan(DateTime? fromDate, DateTime? toDate, int? CustomerID, string objectType, int? SaleOrderID, int? batchProductID, string listOperationID, string productNo, string productName, int branchID)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;

            ValidateModuleObjectDataBySearch(fromDate, toDate, CustomerID, objectType, SaleOrderID, batchProductID, listOperationID, productNo, productName, branchID);
            ValidateDataBySearch();
        }
        public void ValidateModuleObjectDataBySearch(DateTime? fromDate, DateTime? toDate, int? CustomerID, string objectType, int? SaleOrderID, int? batchProductID, string listOperationID, string productNo, string productName, int branchID)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;
            List<MMOperationDetailPlanItemChildsInfo> SearchList = (new MMOperationDetailPlanItemChildsController())
              .SearchPlanDetaiBySomeCriteria(fromDate, toDate, CustomerID, objectType, SaleOrderID, batchProductID, listOperationID, productNo, productName, branchID, BOSApp.CurrentUsersInfo.ADUserID);

            entity.OperationDetailPlanItemChildsList.Invalidate(SearchList);
            if (OperationPlanGridControl != null)
            {
                GridView view = OperationPlanGridControl.MainView as GridView;
                if (view != null)
                {
                    if (view.Columns["MMOperationDetailPlanItemChildProductSerial"] != null)
                        view.Columns["MMOperationDetailPlanItemChildProductSerial"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                    if (view.Columns["MMOperationDetailPlanItemChildProductNo"] != null)
                        view.Columns["MMOperationDetailPlanItemChildProductNo"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                    if (view.Columns["MMBatchProductProductionNormItemProcessPeriod"] != null)
                        view.Columns["MMBatchProductProductionNormItemProcessPeriod"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                }
            }
            MMDetailPlanHumanUnitsController humanUnitController = new MMDetailPlanHumanUnitsController();
            MMDetailPlanMachineUnitsController machineUnitController = new MMDetailPlanMachineUnitsController();
            List<MMDetailPlanHumanUnitsInfo> listHuman = new List<MMDetailPlanHumanUnitsInfo>();
            List<MMDetailPlanMachineUnitsInfo> listMachineUnit = new List<MMDetailPlanMachineUnitsInfo>();
            listHuman = humanUnitController.SearchPlanDetaiBySomeCriteria(fromDate, toDate, CustomerID, objectType, SaleOrderID, batchProductID, listOperationID, productNo, productName, branchID, BOSApp.CurrentUsersInfo.ADUserID);
            listMachineUnit = machineUnitController.SearchPlanDetaiBySomeCriteria(fromDate, toDate, CustomerID, objectType, SaleOrderID, batchProductID, listOperationID, productNo, productName, branchID, BOSApp.CurrentUsersInfo.ADUserID);
            entity.HumanUnitList.Invalidate(listHuman);
            entity.MachineUnitList.Invalidate(listMachineUnit);
            List<MMOperationDetailPlanCapacityItemsInfo> newList = new List<MMOperationDetailPlanCapacityItemsInfo>();
            entity.CapacityDataList.Invalidate(newList);

            MMDetailPlanEquipmentsController dpEquipmentContrller = new MMDetailPlanEquipmentsController();
            List<MMDetailPlanEquipmentsInfo> planEquipmentList = new List<MMDetailPlanEquipmentsInfo>();
            planEquipmentList = dpEquipmentContrller.SearchPlanDetaiBySomeCriteria(fromDate, toDate, CustomerID, objectType, SaleOrderID, batchProductID, listOperationID, productNo, productName, branchID, BOSApp.CurrentUsersInfo.ADUserID);
            if (planEquipmentList != null)
                entity.EquipmentDetailPlansList.Invalidate(planEquipmentList);

        }
        public void ValidateDataBySearch()
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;
            InitEditComboBoxOperationValue();
            EnableCancelHumanButton(false);
            EnableCancelMachineButton(false);
            entity.DeleteItem = new List<MMOperationDetailPlanItemChildsInfo>();
            entity.DeleteHuman = new List<MMDetailPlanHumanUnitsInfo>();
            entity.DeleteMachine = new List<MMDetailPlanMachineUnitsInfo>();
            List<MMOperationDetailPlanItemChildsInfo> TempUnitDetailList = new List<MMOperationDetailPlanItemChildsInfo>();
            List<MMOperationDetailPlanItemChildsInfo> TempTicketDetailList = new List<MMOperationDetailPlanItemChildsInfo>();
            entity.OperationDetailPlanItemChildsList.ForEach(o =>
            {

                if (entity.HumanUnitList != null && entity.HumanUnitList.Count > 0)
                {
                    o.HumanFocusedList = entity.HumanUnitList.Where(h => h.FK_MMBatchProductProductionNormItemID == o.FK_MMBatchProductProductionNormItemID
                                                                    && h.FK_MMOperationDetailPlanItemChildID == o.MMOperationDetailPlanItemChildID
                                                                    && h.FK_MMOperationID == o.FK_MMOperationID
                                                                    && h.MMDetailPlanHumanUnitAbstract == o.MMOperationDetailPlanItemChildAbstract).ToList();
                    if (o.HumanFocusedList != null) o.Employee = o.HumanFocusedList.Count;
                }
                if (entity.MachineUnitList != null && entity.MachineUnitList.Count > 0)
                {
                    o.MachineFocusedList = entity.MachineUnitList.Where(h => h.FK_MMBatchProductProductionNormItemID == o.FK_MMBatchProductProductionNormItemID
                                                                    && h.FK_MMOperationDetailPlanItemChildID == o.MMOperationDetailPlanItemChildID
                                                                    && h.FK_MMOperationID == o.FK_MMOperationID
                                                                    && h.MMDetailPlanMachineUnitAbstract == o.MMOperationDetailPlanItemChildAbstract).ToList();
                    if (o.MachineFocusedList.Count() > 0)
                    {
                        o.Machine = o.MachineFocusedList.Count;
                        o.MachineDetail = o.MachineFocusedList != null ? string.Join(";", o.MachineFocusedList.Select(m => m.MMMachineUnitName).Distinct().ToArray()) : string.Empty;
                    }
                }
                TempUnitDetailList.Add((MMOperationDetailPlanItemChildsInfo)o.Clone());
                if (o.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.JobCreated.ToString()
                    || o.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.Closed.ToString())
                    TempTicketDetailList.Add((MMOperationDetailPlanItemChildsInfo)o.Clone());

            });
            entity.HumanDetailPlanItemsList.Invalidate(TempUnitDetailList);
            entity.MachineDetailPlanItemsList.Invalidate(TempUnitDetailList);

            entity.TicketDetailPlanItemsList.Invalidate(TempTicketDetailList);
            if (TicketRemainCheckBox != null) TicketRemainCheckBox.Checked = true;
            FilterTicketGrid(true, null, null, false, null);

            List<string> opID = new List<string>();
            if (entity.OperationDetailPlanItemChildsList != null)
            {
                opID = entity.OperationDetailPlanItemChildsList.Select(o => o.FK_MMOperationID.ToString()).Distinct().ToList();
                OperationHumanSelect.Clear();
                OperationMachineSelect.Clear();
                foreach (var item in opID)
                {
                    OperationData.ForEach(op =>
                    {
                        if (op.MMOperationID.ToString() == item)
                        {
                            OperationHumanSelect.Add((MMOperationsInfo)op.Clone());
                            OperationMachineSelect.Add((MMOperationsInfo)op.Clone());
                        }
                    });
                }
            }
            //if (HumanNotTicket != null) HumanNotTicket.Checked = true;
            //GetTreeHumanDataSource(true, string.Join(",", opID.ToArray()), 0);
            //if (MachineNotTicketCheckBox != null) MachineNotTicketCheckBox.Checked = true;
            //GetTreeMachineDataSource(true, string.Join(",", opID.ToArray()), 0);
            //InvalidateHumanPlanByNoteChange();
            //InvalidateMachinePlanByNoteChange();
            entity.TicketDetailPlanItemsList.GridControl?.RefreshDataSource();
            entity.CapacityDataList.GridControl?.RefreshDataSource();
            SelectedTicketHuman = new List<HRDepartmentRoomGroupItemsInfo>();
            SelectedTicketMachine = new List<MMMachineUnitsInfo>();

            if (fld_chkStatusNew != null) fld_chkStatusNew.Checked = true;
            else
            {
                fld_chkStatusNew = (BOSCheckEdit)Controls["fld_chkStatusNew"];
                if (fld_chkStatusNew != null) fld_chkStatusNew.Checked = true;

            }
            if (fld_chkStatusApproved != null) fld_chkStatusApproved.Checked = true;
            else
            {
                fld_chkStatusApproved = (BOSCheckEdit)Controls["fld_chkStatusApproved"];
                if (fld_chkStatusApproved != null) fld_chkStatusApproved.Checked = true;
            }
            fld_chkStatusClosed = (BOSCheckEdit)Controls["fld_chkStatusClosed"];
            if (fld_chkStatusClosed != null) fld_chkStatusClosed.Checked = false;

            fld_chkStatusCanceled = (BOSCheckEdit)Controls["fld_chkStatusCanceled"];
            if (fld_chkStatusCanceled != null) fld_chkStatusCanceled.Checked = false;

            if (HumanLookupEditControl != null) HumanLookupEditControl.EditValue = "All";
            if (MachineLookupEditControl != null) MachineLookupEditControl.EditValue = "All";
            FilterPlanData((MMOperationDetailPlanItemChildsGridControl)entity.OperationDetailPlanItemChildsList.GridControl, true, false, true, false, "All", "All");
            if (entity.EquipmentDetailPlansList != null)
            {
                entity.EquipmentDetailPlansList.ForEach(o =>
                {
                    MMOperationDetailPlanItemChildsInfo found = entity.OperationDetailPlanItemChildsList.Where(p => p.MMOperationDetailPlanItemChildID == o.FK_MMOperationDetailPlanItemChildID).FirstOrDefault();
                    if (found != null && found.MachineFocusedList != null)
                    {
                        o.Machine = found.MachineFocusedList.Count;
                    }
                });
            }
        }

        public void InvalidateBySearch()
        {
            DateTime fromDate = SearchFromDateLookupEditControl.DateTime;
            DateTime toDate = SearchToDateLookupEditControl.DateTime;


            string objectAccessKey = fld_lkeFK_ACObjectID.EditValue == null ? string.Empty : fld_lkeFK_ACObjectID.EditValue.ToString();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);

            string ListOperationID = fld_cmbOperationsSearch.EditValue != null ? fld_cmbOperationsSearch.EditValue.ToString() : null;
            int SaleOrderID = 0;

            if (fld_lkeSaleOrderID.EditValue != null) int.TryParse(fld_lkeSaleOrderID.EditValue.ToString(), out SaleOrderID);
            int batchProductID = 0;

            if (fld_lkeMMBatchProductID.EditValue != null) int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out batchProductID);


            string productNo = string.IsNullOrEmpty(fld_txtProductNo.Text) ? string.Empty : fld_txtProductNo.Text.Trim();


            string productName = string.IsNullOrEmpty(fld_txtProductName.Text) ? string.Empty : fld_txtProductName.Text.Trim();

            int branchID = 0;
            if (fld_lkeFK_BRBranchID.EditValue != null) int.TryParse(fld_lkeFK_BRBranchID.EditValue.ToString(), out branchID);

            SearchDetailPlan(fromDate, toDate, objObjectsInfo != null ? objObjectsInfo.ACObjectID : 0, objObjectsInfo != null ? objObjectsInfo.ACObjectType : string.Empty
                                                                , SaleOrderID, batchProductID, ListOperationID, productNo, productName, branchID);
        }
        public void RefreshEquipmentDetailPlan()
        {
            #region Equipment data
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;
            if (objOperationDetailPlansInfo.MMOperationDetailPlanID == 0) objOperationDetailPlansInfo.MMOperationDetailPlanID = 1;
            if (objOperationDetailPlansInfo.MMOperationDetailPlanID > 0)
            {
                if (Toolbar.IsNullOrNoneAction()) ActionEdit();
                MMDetailPlanEquipmentsController ctlEquipment = new MMDetailPlanEquipmentsController();
                List<MMDetailPlanEquipmentsInfo> listEquipment = ctlEquipment.GetDefaultDetailPlanEquipmentByPlan(objOperationDetailPlansInfo.MMOperationDetailPlanID);
                if (listEquipment != null)
                {
                    entity.EquipmentDetailPlansList.Invalidate(listEquipment);
                    if (entity.EquipmentDetailPlansList != null)
                    {
                        entity.EquipmentDetailPlansList.ForEach(o =>
                        {
                            MMOperationDetailPlanItemChildsInfo found = entity.OperationDetailPlanItemChildsList.Where(p => p.MMOperationDetailPlanItemChildID == o.FK_MMOperationDetailPlanItemChildID).FirstOrDefault();
                            if (found != null && found.MachineFocusedList != null)
                                o.Machine = found.MachineFocusedList.Count;
                        });
                    }
                    entity.EquipmentDetailPlansList.GridControl?.RefreshDataSource();
                }
            }
            else
                BOSApp.ShowMessage("Vui lòng lưu chứng từ trước!");
            #endregion
        }

        public override int ActionSave()
        {
            MMOperationDetailPlanItemChildsController objchild = new MMOperationDetailPlanItemChildsController();
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)entity.MainObject;
            bool error = false;
            entity.OperationDetailPlanItemChildsList.ForEach(o =>
            {
                if (o.FK_MMWorkShopID == 0)
                {
                    o.IsError = true;
                    error = true;
                }
            });
            if (error)
            {
                BOSApp.ShowMessage("Thông tin xưởng không thể trống!");
                return 0;
            }
            #region Save Plan Child
            if (entity.OperationDetailPlanItemChildsList.BackupList != null && entity.OperationDetailPlanItemChildsList.BackupList.Count > 0)
            {
                List<MMOperationDetailPlanItemChildsInfo> checkList = entity.OperationDetailPlanItemChildsList.Where(x => x.MMOperationDetailPlanItemChildID > 0).ToList();
                foreach (MMOperationDetailPlanItemChildsInfo item in entity.OperationDetailPlanItemChildsList.BackupList.Where(x => x.MMOperationDetailPlanItemChildID > 0))
                {
                    int count = 0;
                    if (checkList != null)
                        count = checkList.Where(x => x.MMOperationDetailPlanItemChildID == item.MMOperationDetailPlanItemChildID).ToList().Count();
                    if (count == 0)
                        entity.DeleteItem.Add(item);
                }
            }
            #endregion
            #region Save HumanUnit
            // Remove
            List<MMDetailPlanHumanUnitsInfo> RemoveHumanUnit = new List<MMDetailPlanHumanUnitsInfo>();
            entity.HumanUnitList.ForEach(h =>
            {
                bool exit = false;
                entity.HumanDetailPlanItemsList.ForEach(p =>
                   {
                       if (p.HumanFocusedList != null && p.HumanFocusedList.Count > 0)
                           exit = p.HumanFocusedList.Any(o => o.FK_MMOperationID == h.FK_MMOperationID
                                                               && o.MMDetailPlanHumanUnitAbstract == h.MMDetailPlanHumanUnitAbstract
                                                               && o.FK_HREmployeeID == h.FK_HREmployeeID);
                   });
                if (!exit)
                    RemoveHumanUnit.Add((MMDetailPlanHumanUnitsInfo)h.Clone());
            });
            if (RemoveHumanUnit != null && RemoveHumanUnit.Count > 0)
            {
                RemoveHumanUnit.ForEach(r =>
                {
                    MMDetailPlanHumanUnitsInfo item = entity.HumanUnitList.Where(o =>
                        o.FK_MMOperationID == r.FK_MMOperationID
                        && o.MMDetailPlanHumanUnitAbstract == r.MMDetailPlanHumanUnitAbstract
                        && o.MMDetailPlanHumanUnitID == r.MMDetailPlanHumanUnitID
                        && o.FK_HREmployeeID == r.FK_HREmployeeID).FirstOrDefault();
                    if (item != null && (item.MMDetailPlanHumanUnitAbstract != string.Empty || item.MMDetailPlanHumanUnitID > 0)) entity.HumanUnitList.Remove(item);
                });
            }
            //Add Human
            foreach (MMOperationDetailPlanItemChildsInfo item in entity.HumanDetailPlanItemsList)
            {
                if (item.HumanFocusedList != null && item.HumanFocusedList.Count > 0)
                {
                    item.HumanFocusedList.ForEach(h =>
                    {
                        MMDetailPlanHumanUnitsInfo found = entity.HumanUnitList.Where(x => x.FK_MMOperationID == h.FK_MMOperationID
                        && x.MMDetailPlanHumanUnitAbstract == h.MMDetailPlanHumanUnitAbstract
                        && x.FK_HREmployeeID == h.FK_HREmployeeID
                        ).FirstOrDefault();
                        if (found != null && found.MMDetailPlanHumanUnitAbstract != string.Empty)
                        {
                            found.FK_HRDepartmentRoomGroupItemID = h.FK_HRDepartmentRoomGroupItemID;
                            found.MMDetailPlanHumanUnitDesc = h.MMDetailPlanHumanUnitDesc;
                        }
                        else entity.HumanUnitList.Add((MMDetailPlanHumanUnitsInfo)h.Clone());
                    });

                }
            }

            // Add item to update status Delete
            if (entity.HumanUnitList.BackupList != null && entity.HumanUnitList.BackupList.Count > 0)
            {
                List<MMDetailPlanHumanUnitsInfo> checkList = entity.HumanUnitList.Where(x => x.MMDetailPlanHumanUnitID > 0).ToList();
                foreach (MMDetailPlanHumanUnitsInfo item in entity.HumanUnitList.BackupList.Where(x => x.MMDetailPlanHumanUnitID > 0))
                {
                    int count = 0;
                    if (checkList != null)
                        count = checkList.Where(x => x.MMDetailPlanHumanUnitID == item.MMDetailPlanHumanUnitID).ToList().Count();
                    if (count == 0)
                        entity.DeleteHuman.Add(item);
                }
            }
            #endregion
            #region Save MachineUnit

            // Remove
            List<MMDetailPlanMachineUnitsInfo> RemoveMachineUnit = new List<MMDetailPlanMachineUnitsInfo>();
            entity.MachineUnitList.ForEach(h =>
            {
                bool exit = false;
                entity.MachineDetailPlanItemsList.ForEach(p =>
                {
                    if (p.MachineFocusedList != null && p.MachineFocusedList.Count > 0)
                        exit = p.MachineFocusedList.Any(o => o.FK_MMOperationID == h.FK_MMOperationID
                                                            && o.MMDetailPlanMachineUnitAbstract == h.MMDetailPlanMachineUnitAbstract
                                                            && o.FK_MMOperationID == h.FK_MMOperationID
                                                            && o.FK_ACAssetID == h.FK_ACAssetID);
                });
                if (!exit)
                    RemoveMachineUnit.Add((MMDetailPlanMachineUnitsInfo)h.Clone());
            });
            if (RemoveMachineUnit != null && RemoveMachineUnit.Count > 0)
            {
                RemoveMachineUnit.ForEach(r =>
                {
                    MMDetailPlanMachineUnitsInfo item = entity.MachineUnitList.Where(o =>
                        o.FK_MMOperationID == r.FK_MMOperationID
                        && o.MMDetailPlanMachineUnitAbstract == r.MMDetailPlanMachineUnitAbstract
                        && o.MMDetailPlanMachineUnitID == r.MMDetailPlanMachineUnitID
                        && o.FK_MMOperationID == r.FK_MMOperationID
                        && o.FK_ACAssetID == r.FK_ACAssetID).FirstOrDefault();
                    if (item != null && (item.MMDetailPlanMachineUnitAbstract != string.Empty || item.MMDetailPlanMachineUnitID > 0)) entity.MachineUnitList.Remove(item);
                });
            }
            //Add Machine
            foreach (MMOperationDetailPlanItemChildsInfo item in entity.MachineDetailPlanItemsList)
            {
                if (item.MachineFocusedList != null && item.MachineFocusedList.Count > 0)
                {
                    item.MachineFocusedList.ForEach(h =>
                    {
                        MMDetailPlanMachineUnitsInfo found = entity.MachineUnitList.Where(x => x.FK_MMOperationID == h.FK_MMOperationID
                        && x.MMDetailPlanMachineUnitAbstract == h.MMDetailPlanMachineUnitAbstract
                        && x.FK_MMOperationID == h.FK_MMOperationID
                        && x.FK_ACAssetID == h.FK_ACAssetID
                        ).FirstOrDefault();
                        if (found != null && found.MMDetailPlanMachineUnitAbstract != string.Empty)
                        {
                            found.FK_MMMachineUnitID = h.FK_MMMachineUnitID;
                            found.MMDetailPlanMachineUnitDesc = h.MMDetailPlanMachineUnitDesc;
                        }
                        else entity.MachineUnitList.Add((MMDetailPlanMachineUnitsInfo)h.Clone());
                    });

                }
            }
            if (entity.MachineUnitList.BackupList != null && entity.MachineUnitList.BackupList.Count > 0)
            {
                List<MMDetailPlanMachineUnitsInfo> checkList = entity.MachineUnitList.Where(x => x.MMDetailPlanMachineUnitID > 0).ToList();
                foreach (MMDetailPlanMachineUnitsInfo item in entity.MachineUnitList.BackupList.Where(x => x.MMDetailPlanMachineUnitID > 0))
                {
                    int count = 0;
                    if (checkList != null)
                        count = checkList.Where(x => x.MMDetailPlanMachineUnitID == item.MMDetailPlanMachineUnitID).ToList().Count();
                    if (count == 0)
                        entity.DeleteMachine.Add(item);
                }
            }
            #endregion
            #region Save Equipment

            if (entity.EquipmentDetailPlansList.BackupList != null && entity.EquipmentDetailPlansList.BackupList.Count > 0)
            {
                List<MMDetailPlanEquipmentsInfo> checkList = entity.EquipmentDetailPlansList.Where(x => x.MMDetailPlanEquipmentID > 0).ToList();
                foreach (MMDetailPlanEquipmentsInfo item in entity.EquipmentDetailPlansList.BackupList.Where(x => x.MMDetailPlanEquipmentID > 0))
                {
                    int count = 0;
                    if (checkList != null)
                        count = checkList.Where(x => x.MMDetailPlanEquipmentID == item.MMDetailPlanEquipmentID).ToList().Count();
                    if (count == 0)
                        entity.DeleteEquipment.Add(item);
                }
            }
            #endregion
            int result = base.ActionSave();
            if (result > 0)
            {
                //Invalidate(result);
                InvalidateBySearch();
            }
            return result;
        }
        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
        }

        public void DeleteItemchildList(MMOperationDetailPlanItemChildsInfo item)
        {
            if (Toolbar.IsNullOrNoneAction()) ActionEdit();

            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;
            if (objOperationDetailPlansInfo.MMOperationDetailPlanID == 0) objOperationDetailPlansInfo.MMOperationDetailPlanID = 1;
            if (entity.OperationDetailPlanItemChildsList != null && item.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.New.ToString())
            {
                if (objOperationDetailPlansInfo.MMOperationDetailPlanID > 0 && item.MMOperationDetailPlanItemChildID > 0)
                {
                    MMOperationDetailPlanItemChildsController ctl = new MMOperationDetailPlanItemChildsController();
                    List<MMOperationDetailPlanItemChildsInfo> list = ctl.GetListCapacityByDetailPlan(objOperationDetailPlansInfo.MMOperationDetailPlanID);
                    if (list != null && list.Count > 0)
                    {
                        List<MMOperationDetailPlanItemChildsInfo> jobitem = list.Where(o => o.MMOperationDetailPlanItemChildID == item.MMOperationDetailPlanItemChildID).ToList();
                        if (jobitem != null && jobitem.Sum(j => j.MMOperationDetailPlanItemChildCompletedProductQty) > 0)
                        {
                            MessageBox.Show("Kế hoạch đã tạo thẻ giao việc, bạn không được xóa",
                                          MESLocalizedResources.MessageBoxDefaultCaption,
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                        }
                        List<MMDetailPlanEquipmentsInfo> equipItem = entity.EquipmentDetailPlansList.Where(o => o.FK_MMOperationDetailPlanItemChildID == item.MMOperationDetailPlanItemChildID).ToList();
                        if (equipItem != null && equipItem.Count > 0)
                        {
                            MessageBox.Show("Đã lập Kế hoạch sử dụng DCSX, bạn không được xóa",
                                          MESLocalizedResources.MessageBoxDefaultCaption,
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                        }
                    }
                }
                entity.OperationDetailPlanItemChildsList.RemoveSelectedRowObjectFromList();
                int index = -1;
                MMOperationDetailPlanItemChildsInfo humanObject = entity.HumanDetailPlanItemsList.Where(o => o.MMOperationDetailPlanItemChildID == item.MMOperationDetailPlanItemChildID
                                                                                                && o.MMOperationDetailPlanItemChildAbstract == item.MMOperationDetailPlanItemChildAbstract).FirstOrDefault();
                if (humanObject != null)
                {
                    index = entity.HumanDetailPlanItemsList.IndexOf(humanObject);
                    if (index >= 0)
                        entity.HumanDetailPlanItemsList.RemoveAt(index);
                    entity.HumanDetailPlanItemsList.GridControl?.RefreshDataSource();
                }
                MMOperationDetailPlanItemChildsInfo machineObject = entity.MachineDetailPlanItemsList.Where(o => o.MMOperationDetailPlanItemChildID == item.MMOperationDetailPlanItemChildID
                                                                                                        && o.MMOperationDetailPlanItemChildAbstract == item.MMOperationDetailPlanItemChildAbstract).FirstOrDefault();
                if (machineObject != null)
                {
                    index = entity.MachineDetailPlanItemsList.IndexOf(machineObject);
                    if (index >= 0)
                        entity.MachineDetailPlanItemsList.RemoveAt(index);
                    entity.MachineDetailPlanItemsList.GridControl?.RefreshDataSource();
                }

                List<MMDetailPlanEquipmentsInfo> equipmentList = entity.EquipmentDetailPlansList.Where(o => o.FK_MMOperationDetailPlanItemChildID == item.MMOperationDetailPlanItemChildID
                                                                                                        && o.MMDetailPlanEquipmentAbstract == item.MMOperationDetailPlanItemChildAbstract).ToList();
                if (equipmentList != null)
                {
                    foreach (MMDetailPlanEquipmentsInfo obj in equipmentList)
                    {
                        index = entity.EquipmentDetailPlansList.IndexOf(obj);
                        if (index >= 0)
                            entity.EquipmentDetailPlansList.RemoveAt(index);
                    }
                    entity.EquipmentDetailPlansList.GridControl?.RefreshDataSource();
                }
            }
        }

        #region New
        public override void ActionNew()
        {
            base.ActionNew();
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;
            objOperationDetailPlansInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objOperationDetailPlansInfo.MMOperationDetailPlanDate = DateTime.Now;
            objOperationDetailPlansInfo.MMOperationDetailPlanStatus = AllocationPlanStatus.New.ToString();
            objOperationDetailPlansInfo.MMOperationDetailPlanName = string.Empty;
            objOperationDetailPlansInfo.MMOperationDetailPlanType = OperationDetailPlanType.Production.ToString();
            objOperationDetailPlansInfo.MMOperationDetailPlanTotalBlock = 0;
            objOperationDetailPlansInfo.FK_MMLineID = 0;
            objOperationDetailPlansInfo.FK_MMWorkShopID = 0;
            objOperationDetailPlansInfo.MMOperationDetailPlanDesc = string.Empty;
            DefaultWeek();
            if (OperationPlanGridControl != null)
            {
                OperationPlanGridControl.DataSource = entity.OperationDetailPlanItemChildsList;
                OperationPlanGridControl.RefreshDataSource();
            }
            // entity.OperationDetailPlanItemChildsList.GridControl?.RefreshDataSource();
            entity.HumanDetailPlanItemsList.GridControl?.RefreshDataSource();
            entity.MachineDetailPlanItemsList.GridControl?.RefreshDataSource();
            entity.TicketDetailPlanItemsList.GridControl?.RefreshDataSource();
            entity.CapacityDataList.GridControl?.RefreshDataSource();
        }
        public void ShowBatchProductProducttionItem()
        {
            if (Toolbar.IsNullOrNoneAction()) ActionEdit();
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;

            int batchProductID = 0;
            if (fld_lkeMMBatchProductID.EditValue != null) int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out batchProductID);
            if (batchProductID == 0 && !ODPMultiBatchInsert)
            {
                BOSApp.ShowMessage("Vui lòng chọn LSX.");
                fld_lkeMMBatchProductID.Focus();
                return;
            }
            if (fld_lkeMMBatchProductID.EditValue != null && !ODPMultiBatchInsert)
            {
                MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)(new MMBatchProductsController()).GetObjectByID(batchProductID);
                if (objBatchProductsInfo != null
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

            if (objOperationDetailPlansInfo.MMOperationDetailPlanStatus != OperationDetailPlanStatus.Canceled.ToString())
            {
                DateTime fromDate = SearchFromDateLookupEditControl.DateTime;
                DateTime toDate = SearchToDateLookupEditControl.DateTime;
                guiChooseBPPINormOperation gui = new guiChooseBPPINormOperation(fromDate
                                                                              , toDate);
                gui.planFromdate = DateTime.Now;
                gui.PlanTodate = DateTime.Now;
                gui.BatchProductID = batchProductID;
                gui.Module = this;
                gui.WindowState = FormWindowState.Maximized;
                gui.ShowDialog();

                fld_chkStatusNew = (BOSCheckEdit)Controls["fld_chkStatusNew"];
                fld_chkStatusApproved = (BOSCheckEdit)Controls["fld_chkStatusApproved"];
                fld_chkStatusClosed = (BOSCheckEdit)Controls["fld_chkStatusClosed"];
                fld_chkStatusCanceled = (BOSCheckEdit)Controls["fld_chkStatusCanceled"];

                FilterPlanData(OperationPlanGridControl
                , fld_chkStatusNew != null ? fld_chkStatusNew.Checked : true
                , fld_chkStatusCanceled != null ? fld_chkStatusCanceled.Checked : false
                , fld_chkStatusApproved != null ? fld_chkStatusApproved.Checked : true
                , fld_chkStatusClosed != null ? fld_chkStatusClosed.Checked : false
                , HumanLookupEditControl.EditValue != null ? HumanLookupEditControl.EditValue.ToString() : "All"
                , MachineLookupEditControl.EditValue != null ? MachineLookupEditControl.EditValue.ToString() : "All"
                );
            }
        }

        public bool CheckExitInList(List<MMBatchProductProductionNormItemsViewInfo> productionNormList, BOSList<MMOperationDetailPlanItemChildsInfo> ExitList)
        {
            bool result = true;
            productionNormList.ForEach(item =>
            {
                List<MMOperationDetailPlanItemChildsInfo> exititem = ExitList.Where(t => (t.FK_MMBatchProductProductionNormItemID == item.MMBatchProductProductionNormItemID
                                                                               && t.FK_MMOperationID == item.FK_MMOperationID
                                                                               && t.MMOperationDetailPlanItemChildStatus != DetailPlanItemChildStatus.Canceled.ToString()
                                                                               && t.MMOperationDetailPlanItemChildExecutionFromDate == item.MMOperationDetailPlanItemChildExecutionFromDate
                                                                               && t.MMOperationDetailPlanItemChildExecutionToDate == item.MMOperationDetailPlanItemChildExecutionToDate
                                                                               )
                                                                           || (
                                                                                  t.MMOperationDetailPlanItemChildExecutionFromDate == item.MMOperationDetailPlanItemChildExecutionFromDate
                                                                               && t.MMOperationDetailPlanItemChildExecutionToDate == item.MMOperationDetailPlanItemChildExecutionToDate
                                                                               && t.FK_ICProductID == item.FK_ICProductID
                                                                               && t.FK_ICProductForBatchID == item.FK_ICProductForBatchID
                                                                               && t.FK_MMOperationID == item.FK_MMOperationID
                                                                               && t.FK_MMBatchProductID == item.FK_MMBatchProductID
                                                                               && t.MMOperationDetailPlanItemChildStatus != DetailPlanItemChildStatus.Canceled.ToString())).ToList();
                if (exititem != null && exititem.Any())
                {
                    item.IsError = true;
                    result = false;
                }
            });
            return result;
        }
        public bool AddBatchProductProducttionItem(List<MMBatchProductProductionNormItemsViewInfo> productionNormList)
        {
            bool result = true;
            if (!Toolbar.IsNullOrNoneAction()) ActionEdit();
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;
            MMOperationsController objOperationsController = new MMOperationsController();
            string operationNo = string.Empty;

            if (productionNormList != null && productionNormList.Count() > 0)
            {
                //result = CheckExitInList(productionNormList, entity.OperationDetailPlanItemChildsList);
                //if (!result) return result;

                decimal totalBlock = 0;
                List<MMOperationDetailPlanItemChildsInfo> OperationDetailPlanItemChildsList = new List<MMOperationDetailPlanItemChildsInfo>();
                List<MMOperationDetailPlanItemChildsInfo> HumanUnitDetail = new List<MMOperationDetailPlanItemChildsInfo>();
                List<MMOperationDetailPlanItemChildsInfo> MachineUnitDetail = new List<MMOperationDetailPlanItemChildsInfo>();
                productionNormList.ForEach(a =>
                {
                    MMOperationDetailPlanItemChildsInfo obj = new MMOperationDetailPlanItemChildsInfo();
                    BOSUtil.CopyObject(a, obj);
                    bool isHasComponent = false;
                    ICProductsForViewInfo objProductsInfo = BOSApp.CurrentProductList.FirstOrDefault(b => b.ICProductID == a.FK_ICProductID);
                    if (objProductsInfo != null)
                    {
                        obj.MMOperationDetailPlanItemChildProductNo = objProductsInfo.ICProductNo;
                        obj.MMOperationDetailPlanItemChildProductName = objProductsInfo.ICProductName;
                    }
                    obj.MMOperationDetailPlanItemChildProductQty = a.MMBatchProductProductionNormItemQuantityPerOne; //SL chi tiet/Cum
                    obj.MMOperationDetailPlanItemChildTotalProductQty = a.MMBatchProductProductionNormItemQuantityPerOne * a.MMBatchProductItemProductQty;//Tong SL CT theo HD
                    obj.MMOperationDetailPlanItemChildBlockPerOne = a.MMBatchProductProductionNormItemBlockPerOne; //KL 1 CT/Cum

                    obj.MMOperationDetailPlanItemChildTotalBlock = a.MMBatchProductProductionNormItemQuantityPerOne * a.MMBatchProductProductionNormItemBlockPerOne * a.MMBatchProductItemProductQty;
                    if (a.MMBatchProductProductionNormItemGroup == "Product")
                    {
                        obj.MMOperationDetailPlanItemChildTotalBlock = a.MMBatchProductProductionNormItemBlockPerOne * a.MMBatchProductItemProductQty;
                    }

                    if (!isHasComponent)
                        totalBlock += obj.MMOperationDetailPlanItemChildTotalBlock;

                    obj.MMOperationDetailPlanItemChildBlockPerOne = obj.MMOperationDetailPlanItemChildBlockPerOne;
                    obj.MMOperationDetailPlanItemChildProductWoodType = a.MMBatchProductProductionNormItemProductWoodType;
                    obj.MMOperationDetailPlanItemChildTotalBlock = Math.Round(obj.MMOperationDetailPlanItemChildTotalBlock, 4, MidpointRounding.AwayFromZero);
                    obj.FK_ARSaleOrderID = a.FK_ARSaleOrderID;
                    obj.MMOperationDetailPlanItemChildProductForBatchNo = a.MMBatchProductItemProductNo;
                    obj.MMOperationDetailPlanItemChildProductForBatchName = a.MMBatchProductItemProductName;
                    obj.MMOperationDetailPlanItemChildProductName = a.MMBatchProductProductionNormItemProductName;
                    obj.MMOperationDetailPlanItemChildSaleOrdeNo = a.MMBatchProductSaleOrderNo;
                    obj.MMOperationDetailPlanItemChildParentNo = a.MMBatchProductProductionNormItemParentNo;
                    obj.ICProductCode = a.ICProductCode;
                    obj.MMBatchProductProductionNormItemProcessPeriod = a.MMBatchProductProductionNormItemSortOrder;
                    obj.MMOperationDetailPlanItemChildProductSerial = a.MMBatchProductItemProductSerial;
                    obj.MMOperationDetailPlanItemChildBatchProductItemProductQty = a.MMBatchProductItemProductQty;
                    obj.FK_MMProductionNormItemID = a.FK_MMProductionNormItemID;
                    obj.FK_MMBatchProductItemID = a.FK_MMBatchProductItemID;
                    obj.FK_MMBatchProductProductionNormItemID = a.MMBatchProductProductionNormItemID;
                    obj.FK_MMBatchProductID = a.FK_MMBatchProductID;
                    obj.FK_MMOperationID = a.FK_MMOperationID;
                    obj.FK_MMWorkShopID = a.FK_MMWorkShopID;
                    obj.FK_MMLineID = a.FK_MMLineID;
                    obj.FK_ICProductForBatchID = a.FK_ICProductForBatchID;
                    obj.FK_ACObjectID = a.FK_ACObjectID;
                    obj.ARObjectType = a.ARObjectType;
                    obj.FK_PMProjectID = a.FK_PMProjectID;
                    obj.ACObjectName = a.ACObjectName;
                    obj.MMOperationDetailPlanItemChildPlanProductQty = a.MMOperationDetailPlanItemChildPlanProductQty;

                    obj.MMOperationDetailPlanItemChildProductHeight = a.MMBatchProductProductionNormItemProductHeight;
                    obj.MMOperationDetailPlanItemChildProductWidth = a.MMBatchProductProductionNormItemProductWidth;
                    obj.MMOperationDetailPlanItemChildProductLength = a.MMBatchProductProductionNormItemProductLength;

                    obj.MMOperationDetailPlanItemChildPlanBlock = a.MMBatchProductProductionNormItemBlockPerOne * a.MMOperationDetailPlanItemChildPlanProductQty;
                    obj.MMOperationDetailPlanItemChildExecutionFromDate = a.MMOperationDetailPlanItemChildExecutionFromDate;
                    obj.MMOperationDetailPlanItemChildExecutionToDate = a.MMOperationDetailPlanItemChildExecutionToDate;
                    obj.MMOperationDetailPlanItemChildComment = a.MMBatchProductProductionNormItemComment;
                    obj.MMOperationDetailPlanItemChildPlanDesc = a.MMBatchProductProductionNormItemProductJoinery;
                    obj.MMOperationDetailPlanItemChildAbstract = Guid.NewGuid().ToString();
                    obj.Selected = false;
                    obj.MMOperationDetailPlanItemChildStatus = DetailPlanItemChildStatus.New.ToString();
                    if (a.HumanUnit != null && a.HumanUnit.Count > 0)
                    {
                        obj.HumanFocusedList = a.HumanUnit;
                        obj.Employee = obj.HumanFocusedList.Count;
                        obj.HumanFocusedList.ForEach(o => o.MMDetailPlanHumanUnitAbstract = obj.MMOperationDetailPlanItemChildAbstract);
                    }
                    else a.HumanUnit = new List<MMDetailPlanHumanUnitsInfo>();
                    if (a.MachineUnit != null && a.MachineUnit.Count > 0)
                    {
                        obj.MachineFocusedList = a.MachineUnit;
                        obj.Machine = obj.MachineFocusedList.Count;
                        obj.MachineDetail = obj.MachineFocusedList != null ? string.Join(";", obj.MachineFocusedList.Select(m => m.MMMachineUnitName).Distinct().ToArray()) : string.Empty;
                        obj.MachineFocusedList.ForEach(o => o.MMDetailPlanMachineUnitAbstract = obj.MMOperationDetailPlanItemChildAbstract);
                    }
                    else a.MachineUnit = new List<MMDetailPlanMachineUnitsInfo>();

                    UpdatePlanMachineCapacity(obj);
                    obj.MMOperationDetailPlanItemChildCapacity = a.MMBatchProductProductionNormItemUnitTime;
                    obj.MMOperationDetailPlanItemChildPlanFinishedDate = obj.MMOperationDetailPlanItemChildCapacity * obj.MMOperationDetailPlanItemChildPlanProductQty;
                    entity.OperationDetailPlanItemChildsList.Add(obj);
                    HumanUnitDetail.Add((MMOperationDetailPlanItemChildsInfo)obj.Clone());
                    MachineUnitDetail.Add((MMOperationDetailPlanItemChildsInfo)obj.Clone());

                    if (a.HumanUnit != null && a.HumanUnit.Count > 0)
                        entity.HumanUnitList.AddRange(a.HumanUnit);
                    if (a.MachineUnit != null && a.MachineUnit.Count > 0)
                        entity.MachineUnitList.AddRange(a.MachineUnit);
                });
                //Phải sử dụng control vì datasource đã bị reset khi filter
                if (OperationPlanGridControl != null)
                {
                    OperationPlanGridControl.DataSource = entity.OperationDetailPlanItemChildsList;
                    OperationPlanGridControl.RefreshDataSource();
                }

                entity.HumanDetailPlanItemsList.AddRange(HumanUnitDetail);
                entity.MachineDetailPlanItemsList.AddRange(MachineUnitDetail);
                entity.HumanDetailPlanItemsList.GridControl?.RefreshDataSource();
                entity.MachineDetailPlanItemsList.GridControl?.RefreshDataSource();
                InitEditComboBoxOperationValue();
            }

            return result;
        }
        #endregion
        #region JobTicket
        public void CreateJobTicket()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
                MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;
                List<MMOperationDetailPlanItemChildsInfo> selectedList = entity.OperationDetailPlanItemChildsList.Where(o => o.Selected).ToList();
                if (selectedList == null || selectedList.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn chi tiết cần tạo thẻ!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (selectedList != null)
                {
                    bool isError = false;
                    selectedList.ForEach(p =>
                    {
                        if (p.MMOperationDetailPlanItemChildStatus != Status.New.ToString())
                        {
                            p.IsError = true;
                            isError = true;
                        }
                    });
                    if (isError)
                        BOSApp.ShowMessage("Tồn tại chi tiết có trạng thái không phù hợp!");
                    else
                    {
                        entity.OperationDetailPlanItemChildsList.ForEach(o =>
                        {
                            if (o.Selected) o.MMOperationDetailPlanItemChildStatus = DetailPlanItemChildStatus.JobCreated.ToString();
                        });
                        SaveItemWithDataTableType.SaveItemWithoutDelete<MMOperationDetailPlanItemChildsInfo>(entity.OperationDetailPlanItemChildsList
                             , "MMOperationDetailPlanItemChildID", "MMOperationDetailPlanItemChilds", objOperationDetailPlansInfo.MMOperationDetailPlanID == 0 ? 1 : objOperationDetailPlansInfo.MMOperationDetailPlanID, BOSApp.CurrentUsersInfo.ADUserName);
                        InvalidateBySearch();
                        //Invalidate(objOperationDetailPlansInfo.MMOperationDetailPlanID);
                        BOSApp.ShowMessage("Đã tạo thẻ xong");
                    }
                }
            }
            else if (Toolbar.CurrentObjectID > 0)
            {
                BOSApp.ShowMessage("Vui lòng lưu chứng từ");
            }
        }
        public void CancelJobTicket(MMOperationDetailPlanItemChildsInfo onlyItem, BOSList<MMOperationDetailPlanItemChildsInfo> OperationDetailPlanItemChildsList, bool isMainGrid)
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
                MMOperationDetailPlansInfo mainObject = (MMOperationDetailPlansInfo)entity.MainObject;
                if (Toolbar.IsNullOrNoneAction())
                {
                    ValidateExitCapacity(null, OperationDetailPlanItemChildsList, true);
                    bool isError1 = false;
                    bool isError2 = false;
                    bool isError3 = false;
                    if (OperationDetailPlanItemChildsList.Where(o => (o.Selected && onlyItem == null) || onlyItem != null).Count() > 0)
                    {
                        foreach (MMOperationDetailPlanItemChildsInfo item in OperationDetailPlanItemChildsList)
                        {
                            if ((onlyItem != null && onlyItem.MMOperationDetailPlanItemChildID == item.MMOperationDetailPlanItemChildID) || (onlyItem == null && item.Selected))
                            {
                                if (item.MMOperationDetailPlanItemChildCompletedProductQty > item.MMJobTicketItemPlanReceiptQty && item.MMOperationDetailPlanCapacityItemHasReceipt)
                                {
                                    isError1 = true;
                                    item.IsError = true;
                                }
                                if (item.MMJobTicketItemPlanReceiptQty > 0)
                                {
                                    isError3 = true;
                                    item.IsError = true;
                                }
                                if ((item.MMOperationDetailPlanItemChildStatus == Status.Canceled.ToString()
                                    || item.MMOperationDetailPlanItemChildStatus == Status.Closed.ToString()
                                    || item.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.New.ToString()))
                                {
                                    isError2 = true;
                                    item.IsError = true;
                                }
                            }

                        }
                        if (isError1)
                        {
                            if (BOSApp.ShowMessageYesNo("Tồn tại thẻ đã nhập sản lượng và chưa nhập kho đủ. Bạn chắc chắn muốn huỷ?") == DialogResult.Yes)
                                isError1 = false;
                        }
                        foreach (MMOperationDetailPlanItemChildsInfo item in OperationDetailPlanItemChildsList)
                        {
                            if ((onlyItem != null && onlyItem.MMOperationDetailPlanItemChildID == item.MMOperationDetailPlanItemChildID) || (onlyItem == null && item.Selected))
                            {
                                if (!isError1 && !isError2 && !isError3)
                                    if ((item.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.JobCreated.ToString()) && item.Selected)
                                        item.MMOperationDetailPlanItemChildStatus = Status.Canceled.ToString();
                            }

                        }
                        if (!isError2 && !isError1 && !isError3)
                        {
                            if (BOSApp.ShowMessageYesNo("Bạn chắc chắn hủy các chi tiết đã chọn?") == DialogResult.Yes)
                            {
                                if (OperationDetailPlanItemChildsList.Where(x => (x.Selected && onlyItem == null)
                                    || (onlyItem != null && x.MMOperationDetailPlanItemChildID == onlyItem.MMOperationDetailPlanItemChildID)).Count() > 0)
                                {
                                    SaveItemWithDataTableType.SaveItemWithoutDelete<MMOperationDetailPlanItemChildsInfo>(OperationDetailPlanItemChildsList.Where(x => (x.Selected && onlyItem == null)
                                        || (onlyItem != null && x.MMOperationDetailPlanItemChildID == onlyItem.MMOperationDetailPlanItemChildID)).ToList(), "MMOperationDetailPlanItemChildID", "MMOperationDetailPlanItemChilds"
                                        , mainObject.MMOperationDetailPlanID == 0 ? 1 : mainObject.MMOperationDetailPlanID, BOSApp.CurrentUsersInfo.ADUserName);
                                    InvalidateBySearch();
                                    //Invalidate(mainObject.MMOperationDetailPlanID);
                                    BOSApp.ShowMessage("Hủy thẻ thành công");
                                }
                            }
                        }
                        else
                        {
                            if (isError1) return;
                            string mess = "Có lỗi xảy ra, chi tiết bạn chọn: ";
                            string messEr1 = Environment.NewLine + "Đã nhập sản lượng và chưa nhập kho";
                            string messEr2 = Environment.NewLine + "Trạng thái mới tạo hoặc đã hủy hoặc đóng";
                            string messEr3 = Environment.NewLine + "Đã nhập kho BTP";
                            if (isError2) mess += messEr2;
                            if (isError3) mess += messEr3;
                            BOSApp.ShowMessage(mess);
                        }

                    }
                    else
                        BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
                }
            }
            else if (Toolbar.CurrentObjectID > 0)
            {
                BOSApp.ShowMessage("Vui lòng lưu chứng từ");
            }
        }
        public void ValidateExitCapacity(MMOperationDetailPlanItemChildsInfo item, BOSList<MMOperationDetailPlanItemChildsInfo> OperationDetailPlanItemChildsList, bool isMain)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo mainObject = (MMOperationDetailPlansInfo)entity.MainObject;
            MMOperationDetailPlanItemChildsController ctl = new MMOperationDetailPlanItemChildsController();
            #region GetSearch info
            DateTime fromDate = SearchFromDateLookupEditControl.DateTime;
            DateTime toDate = SearchToDateLookupEditControl.DateTime;
            string objectAccessKey = fld_lkeFK_ACObjectID.EditValue == null ? string.Empty : fld_lkeFK_ACObjectID.EditValue.ToString();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            string ListOperationID = fld_cmbOperationsSearch.EditValue != null ? fld_cmbOperationsSearch.EditValue.ToString() : null;
            int SaleOrderID = 0;
            if (fld_lkeSaleOrderID.EditValue != null) int.TryParse(fld_lkeSaleOrderID.EditValue.ToString(), out SaleOrderID);
            int batchProductID = 0;
            if (fld_lkeMMBatchProductID.EditValue != null) int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out batchProductID);
            string productNo = string.IsNullOrEmpty(fld_txtProductNo.Text) ? string.Empty : fld_txtProductNo.Text.Trim();
            string productName = string.IsNullOrEmpty(fld_txtProductName.Text) ? string.Empty : fld_txtProductName.Text.Trim();
            int branchID = 0;
            if (fld_lkeFK_BRBranchID.EditValue != null) int.TryParse(fld_lkeFK_BRBranchID.EditValue.ToString(), out branchID);
            #endregion

            List<MMOperationDetailPlanItemChildsInfo> list = ctl.SearchPlanDetaiBySomeCriteria(fromDate, toDate
                , objObjectsInfo != null ? objObjectsInfo.ACObjectID : 0, objObjectsInfo != null ? objObjectsInfo.ACObjectType : string.Empty
                , SaleOrderID, batchProductID, ListOperationID, productNo, productName, branchID, BOSApp.CurrentUsersInfo.ADUserID);
            if (item != null && list != null && list.Count > 0)
            {
                list.ForEach(o =>
                {
                    if (o.MMOperationDetailPlanItemChildID == item.MMOperationDetailPlanItemChildID)
                    {
                        item.MMOperationDetailPlanItemChildCompletedProductQty = o.MMOperationDetailPlanItemChildCompletedProductQty;
                        item.MMOperationDetailPlanCapacityItemFailProductQty = o.MMOperationDetailPlanCapacityItemFailProductQty;
                        item.MMJobTicketItemPlanReceiptQty = o.MMJobTicketItemPlanReceiptQty;
                        item.MMOperationDetailPlanCapacityItemHasReceipt = o.MMOperationDetailPlanCapacityItemHasReceipt;
                    }
                });
            }
            else
            {
                foreach (MMOperationDetailPlanItemChildsInfo ticket in OperationDetailPlanItemChildsList)
                {
                    list.ForEach(o =>
                    {
                        if (o.MMOperationDetailPlanItemChildID == ticket.MMOperationDetailPlanItemChildID)
                        {
                            ticket.MMOperationDetailPlanItemChildCompletedProductQty = o.MMOperationDetailPlanItemChildCompletedProductQty;
                            ticket.MMOperationDetailPlanCapacityItemFailProductQty = o.MMOperationDetailPlanCapacityItemFailProductQty;
                            ticket.MMJobTicketItemPlanReceiptQty = o.MMJobTicketItemPlanReceiptQty;
                            ticket.MMOperationDetailPlanCapacityItemHasReceipt = o.MMOperationDetailPlanCapacityItemHasReceipt;
                        }
                    });
                }

                OperationDetailPlanItemChildsList.GridControl?.RefreshDataSource();
                if (!isMain)
                {
                    foreach (MMOperationDetailPlanItemChildsInfo ticket in entity.OperationDetailPlanItemChildsList)
                    {
                        list.ForEach(o =>
                        {
                            if (o.MMOperationDetailPlanItemChildID == ticket.MMOperationDetailPlanItemChildID)
                            {
                                ticket.MMOperationDetailPlanItemChildCompletedProductQty = o.MMOperationDetailPlanItemChildCompletedProductQty;
                                ticket.MMOperationDetailPlanCapacityItemFailProductQty = o.MMOperationDetailPlanCapacityItemFailProductQty;
                                ticket.MMJobTicketItemPlanReceiptQty = o.MMJobTicketItemPlanReceiptQty;
                                ticket.MMOperationDetailPlanCapacityItemHasReceipt = o.MMOperationDetailPlanCapacityItemHasReceipt;
                            }
                        });
                    }
                    entity.OperationDetailPlanItemChildsList.GridControl?.RefreshDataSource();
                }
            }
        }
        public void CloseJobTicket(BOSList<MMOperationDetailPlanItemChildsInfo> OperationDetailPlanItemChildsList)
        {
            MMOperationDetailPlansInfo mainObject = (MMOperationDetailPlansInfo)((OperationDetailPlanEntities)CurrentModuleEntity).MainObject;
            OperationDetailPlanItemChildsList.EndCurrentEdit();
            if (Toolbar.IsNullOrNoneAction())
            {
                bool isError1 = false;
                bool isError2 = false;
                if (OperationDetailPlanItemChildsList.Where(o => o.Selected).Count() > 0)
                {
                    foreach (MMOperationDetailPlanItemChildsInfo item in OperationDetailPlanItemChildsList)
                    {
                        if (item.Selected && (item.MMOperationDetailPlanItemChildStatus == Status.Canceled.ToString()
                            || item.MMOperationDetailPlanItemChildStatus == Status.Closed.ToString()
                            || item.MMOperationDetailPlanItemChildStatus == Status.New.ToString()))
                        {
                            isError1 = true;
                            item.IsError = true;
                        }

                    }
                    if (isError1)
                    {
                        string mess = "Chi tiết đã chọn có trạng thái không phù hợp";
                        if (isError2) mess = "Chi tiết đã chọn đã nhập sản lượng và chưa nhập kho";
                        BOSApp.ShowMessage(mess);
                    }
                    else if (OperationDetailPlanItemChildsList.Where(x => x.Selected).Count() > 0)
                    {
                        if (BOSApp.ShowMessageYesNo("Bạn chắc chắn đóng các chi tiết đã chọn?") == DialogResult.Yes)
                        {
                            ValidateExitCapacity(null, OperationDetailPlanItemChildsList, false);

                            foreach (MMOperationDetailPlanItemChildsInfo item in OperationDetailPlanItemChildsList)
                            {
                                if (item.Selected && item.MMOperationDetailPlanItemChildCompletedProductQty > item.MMJobTicketItemPlanReceiptQty && item.MMOperationDetailPlanCapacityItemHasReceipt)
                                {
                                    isError1 = true;
                                    item.IsError = true;
                                }
                            }
                            if (isError1)
                            {
                                BOSApp.ShowMessage("Tồn tại chi tiết đã nhập sản lượng và chưa nhập kho đủ.");
                                return;
                            }

                            OperationDetailPlanItemChildsList.ForEach(o =>
                            {
                                if (o.Selected)
                                {
                                    o.MMOperationDetailPlanItemChildStatusLog = o.MMOperationDetailPlanItemChildStatusLog +
                                        (!string.IsNullOrEmpty(o.MMOperationDetailPlanItemChildStatusLog) ? ";" : "")
                                    + "Kế hoạch: " + o.MMOperationDetailPlanItemChildPlanProductQty
                                    + ", mới" + o.MMOperationDetailPlanItemChildCompletedProductQty + " mà đóng";

                                    o.MMOperationDetailPlanItemChildPlanProductQty = o.MMOperationDetailPlanItemChildCompletedProductQty;
                                    o.MMOperationDetailPlanItemChildPlanBlock = o.MMOperationDetailPlanItemChildCompletedProductQty * o.MMOperationDetailPlanItemChildBlockPerOne;
                                    o.MMOperationDetailPlanItemChildStatus = Status.Closed.ToString();

                                }
                            });
                            SaveItemWithDataTableType.SaveItemWithoutDelete<MMOperationDetailPlanItemChildsInfo>(OperationDetailPlanItemChildsList.Where(x => x.Selected).ToList()
                                , "MMOperationDetailPlanItemChildID", "MMOperationDetailPlanItemChilds", mainObject.MMOperationDetailPlanID == 0 ? 1 : mainObject.MMOperationDetailPlanID, BOSApp.CurrentUsersInfo.ADUserName);
                            InvalidateBySearch();
                            BOSApp.ShowMessage("Đã đóng thành công");
                        }
                    }
                }
                else
                    BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
            }
        }
        public bool CloseJobTicketByBatch(int batchProductID)
        {
            bool result = true;
            MMOperationDetailPlansInfo mainObject = (MMOperationDetailPlansInfo)((OperationDetailPlanEntities)CurrentModuleEntity).MainObject;
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;

            List<MMOperationDetailPlanItemChildsInfo> checkCloseErrorList = (new MMOperationDetailPlanItemChildsController()).GetCloseErrorListByBatch(batchProductID);
            if (checkCloseErrorList.Count() > 0)
            {
                string mess = string.Join(Environment.NewLine, checkCloseErrorList.Select(o => o.MMOperationDetailPlanItemChildProductName).ToArray());
                BOSApp.ShowMessage("Kế hoạch chi tiết tồn tại thẻ đã nhập sản lượng và chưa nhập kho đủ." + Environment.NewLine + mess);
                return false;
            }
            (new MMOperationDetailPlanItemChildsController()).CloseJobTicketByBatch(batchProductID, BOSApp.CurrentUsersInfo.ADUserName);
            BOSApp.ShowMessage("Đã đóng thành công");
            InvalidateBySearch();
            return result;
        }
        public void OpenJobTicket(MMOperationDetailPlanItemChildsInfo onlyItem, BOSList<MMOperationDetailPlanItemChildsInfo> OperationDetailPlanItemChildsList)
        {
            MMOperationDetailPlansInfo mainObject = (MMOperationDetailPlansInfo)((OperationDetailPlanEntities)CurrentModuleEntity).MainObject;
            OperationDetailPlanItemChildsList.EndCurrentEdit();
            if (Toolbar.IsNullOrNoneAction())
            {
                bool isError1 = false;
                if (OperationDetailPlanItemChildsList.Where(o => (o.Selected && onlyItem == null) || onlyItem != null).Count() > 0)
                {
                    foreach (MMOperationDetailPlanItemChildsInfo item in OperationDetailPlanItemChildsList)
                    {
                        if ((item.Selected && onlyItem == null || (onlyItem != null && onlyItem.MMOperationDetailPlanItemChildID == item.MMOperationDetailPlanItemChildID))
                            && ((item.MMOperationDetailPlanItemChildStatus == Status.Canceled.ToString()
                                                    || item.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.JobCreated.ToString()
                                                    || item.MMOperationDetailPlanItemChildStatus == Status.New.ToString())

                             ))
                        {
                            isError1 = true;
                            item.IsError = true;
                        }

                    }
                    if (isError1)
                    {
                        string mess = "Chi tiết đã chọn có trạng thái không phù hợp";
                        BOSApp.ShowMessage(mess);
                    }
                    else if (OperationDetailPlanItemChildsList.Where(o => (o.Selected && onlyItem == null) || onlyItem != null).Count() > 0)
                    {
                        if (BOSApp.ShowMessageYesNo("Bạn chắc chắn mở các chi tiết đã chọn?") == DialogResult.Yes)
                        {
                            List<MMOperationDetailPlanItemChildsInfo> saveList = new List<MMOperationDetailPlanItemChildsInfo>();
                            OperationDetailPlanItemChildsList.ForEach(o =>
                            {
                                if ((o.Selected && onlyItem == null) || (onlyItem != null && onlyItem.MMOperationDetailPlanItemChildID == o.MMOperationDetailPlanItemChildID))
                                {
                                    o.MMOperationDetailPlanItemChildStatus = DetailPlanItemChildStatus.JobCreated.ToString();
                                    saveList.Add(o);
                                }
                            });
                            SaveItemWithDataTableType.SaveItemWithoutDelete<MMOperationDetailPlanItemChildsInfo>(saveList
                                , "MMOperationDetailPlanItemChildID", "MMOperationDetailPlanItemChilds", mainObject.MMOperationDetailPlanID == 0 ? 1 : mainObject.MMOperationDetailPlanID, BOSApp.CurrentUsersInfo.ADUserName);
                            InvalidateBySearch();
                            //Invalidate(mainObject.MMOperationDetailPlanID);
                        }
                    }
                }
                else
                    BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
            }
        }
        public int GetOpenLastCountFromLog(string log)
        {
            int result = 0;
            string[] logText = log.Split(';');
            if (logText != null && logText.Length > 0)
            {
                string logTime = logText[logText.Length - 1];
                if (!string.IsNullOrEmpty(logTime))
                {
                    string[] spilt = logTime.Split(',');
                    if (spilt != null && spilt.Length > 0)
                    {
                        string find = spilt[0];
                        if (!string.IsNullOrEmpty(find))
                            int.TryParse(find, out result);
                    }
                }
            }
            return result;
        }
        #endregion
        #endregion
        #region Print

        public override void ActionPrint()
        {
            base.ActionPrint();
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)entity.MainObject;
            if (Toolbar.IsEditAction() || Toolbar.IsNewAction())
            {
                return;
            }
        }
        public void PrintOperationDetailPlanItemBatch()
        {
            base.ActionPrint();
        }
        #endregion
        #region GridViewData Proccess
        #region Plan grid view
        public void FilterPlanData(MMOperationDetailPlanItemChildsGridControl fld_dgcMMOperationDetailPlanItemChilds
                                                    , bool fld_chkStatusNew
                                                    , bool fld_chkStatusCanceled
                                                    , bool fld_chkStatusApproved
                                                    , bool fld_chkStatusClosed
                                                    , string human
                                                    , string machine)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)entity.MainObject;

            GridView gridView = (GridView)fld_dgcMMOperationDetailPlanItemChilds.MainView;


            List<MMOperationDetailPlanItemChildsInfo> bindingList = new List<MMOperationDetailPlanItemChildsInfo>();

            //Bind object list to grid for searching
            fld_dgcMMOperationDetailPlanItemChilds.DataSource = entity.OperationDetailPlanItemChildsList;
            fld_dgcMMOperationDetailPlanItemChilds.RefreshDataSource();

            for (int i = 0; i < entity.OperationDetailPlanItemChildsList.Count; i++)
            {

                MMOperationDetailPlanItemChildsInfo obj = entity.OperationDetailPlanItemChildsList[i];
                obj.Selected = false;
                bool added = true;
                if (obj.MMOperationDetailPlanItemChildStatus == Status.New.ToString())
                    if (fld_chkStatusNew && bindingList.IndexOf(obj) < 0)
                        bindingList.Add(obj);
                    else
                    {
                        int iIndex = bindingList.IndexOf(obj);
                        if (iIndex >= 0)
                            bindingList.RemoveAt(iIndex);
                        added = false;
                    }
                else if (obj.MMOperationDetailPlanItemChildStatus == Status.Canceled.ToString())
                    if (fld_chkStatusCanceled && bindingList.IndexOf(obj) < 0)
                        bindingList.Add(obj);
                    else
                    {
                        int iIndex = bindingList.IndexOf(obj);
                        if (iIndex >= 0)
                            bindingList.RemoveAt(iIndex);
                        added = false;
                    }
                else if (obj.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.JobCreated.ToString())
                    if (fld_chkStatusApproved && bindingList.IndexOf(obj) < 0)
                        bindingList.Add(obj);
                    else
                    {
                        int iIndex = bindingList.IndexOf(obj);
                        if (iIndex >= 0)
                            bindingList.RemoveAt(iIndex);
                        added = false;
                    }
                else if (obj.MMOperationDetailPlanItemChildStatus == Status.Closed.ToString())
                    if (fld_chkStatusClosed && bindingList.IndexOf(obj) < 0)
                        bindingList.Add(obj);
                    else
                    {
                        int iIndex = bindingList.IndexOf(obj);
                        if (iIndex >= 0)
                            bindingList.RemoveAt(iIndex);
                        added = false;
                    }
                if (added == true)
                {
                    if (human == "Exits")
                    {
                        if (obj.HumanFocusedList == null || obj.HumanFocusedList.Count == 0)
                        {
                            int iIndex = bindingList.IndexOf(obj);
                            if (iIndex >= 0)
                                bindingList.RemoveAt(iIndex);
                        }
                    }
                    else if (human == "NotExits")
                    {
                        if (obj.HumanFocusedList != null && obj.HumanFocusedList.Any())
                        {
                            int iIndex = bindingList.IndexOf(obj);
                            if (iIndex >= 0)
                                bindingList.RemoveAt(iIndex);
                        }
                    }

                    if (machine == "Exits")
                    {
                        if (obj.MachineFocusedList == null || obj.MachineFocusedList.Count == 0)
                        {
                            int iIndex = bindingList.IndexOf(obj);
                            if (iIndex >= 0)
                                bindingList.RemoveAt(iIndex);
                        }
                    }
                    else if (machine == "NotExits")
                    {
                        if (obj.MachineFocusedList != null && obj.MachineFocusedList.Any())
                        {
                            int iIndex = bindingList.IndexOf(obj);
                            if (iIndex >= 0)
                                bindingList.RemoveAt(iIndex);
                        }
                    }
                }
            }
            //entity.OperationDetailPlanItemChildsList.Invalidate(bindingList);
            fld_dgcMMOperationDetailPlanItemChilds.DataSource = bindingList;
            entity.OperationDetailPlanItemChildsList.GridControl?.RefreshDataSource();

        }
        public void FilterHumanMachinPlanData(MMOperationDetailPlanItemChildsGridControl fld_dgcMMOperationDetailPlanItemChilds
                                                   , bool fld_chkEmployee
                                                   , bool fld_chkMachine
                                                   )
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)entity.MainObject;

            GridView gridView = (GridView)fld_dgcMMOperationDetailPlanItemChilds.MainView;


            List<MMOperationDetailPlanItemChildsInfo> bindingList = new List<MMOperationDetailPlanItemChildsInfo>();

            //Bind object list to grid for searching
            fld_dgcMMOperationDetailPlanItemChilds.DataSource = entity.OperationDetailPlanItemChildsList;
            fld_dgcMMOperationDetailPlanItemChilds.RefreshDataSource();

            for (int i = 0; i < entity.OperationDetailPlanItemChildsList.Count; i++)
            {

                MMOperationDetailPlanItemChildsInfo obj = entity.OperationDetailPlanItemChildsList[i];
                obj.Selected = false;
                if (fld_chkEmployee)
                {
                    if (obj.HumanFocusedList == null || obj.HumanFocusedList.Count == 0)
                    {
                        int iIndex = bindingList.IndexOf(obj);
                        if (iIndex >= 0)
                            bindingList.RemoveAt(iIndex);
                    }
                }
                else
                {
                    if (obj.HumanFocusedList != null && obj.HumanFocusedList.Any())
                    {
                        int iIndex = bindingList.IndexOf(obj);
                        if (iIndex >= 0)
                            bindingList.RemoveAt(iIndex);
                    }
                }
            }
            fld_dgcMMOperationDetailPlanItemChilds.DataSource = bindingList;
            fld_dgcMMOperationDetailPlanItemChilds.RefreshDataSource();

        }
        public bool CellValueChanged(string filedName, decimal valueQty, MMOperationDetailPlanItemChildsInfo row)
        {
            bool result = true;
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)entity.MainObject;
            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();

            MMBatchProductItemsInfo objBatchProductItemsInfo = new MMBatchProductItemsInfo();
            if (objOperationDetailPlansInfo.MMOperationDetailPlanID == 0) objOperationDetailPlansInfo.MMOperationDetailPlanID = 1;
            //childs cell change
            if (filedName == "MMOperationDetailPlanItemChildPlanProductQty")
            {
                int bPPNID = row.FK_MMBatchProductProductionNormItemID;
                int OperationChildID = row.MMOperationDetailPlanItemChildID;
                int operationID = row.FK_MMOperationID;

                decimal RemainProductQty = 0;
                decimal ChildBlockPerOne = row.MMOperationDetailPlanItemChildBlockPerOne;
                MMBatchProductProductionNormItemsInfo objBPPN = (new MMBatchProductProductionNormItemsController()).GetRemainAvailableByBPPNIDAndOperationChildID(bPPNID, OperationChildID, operationID);
                if (objBPPN != null)
                {
                    RemainProductQty = objBPPN.MMBatchProductProductionNormItemQuantity;
                    if (valueQty > RemainProductQty)
                    {
                        //focus valid cell, raise error
                        MessageBox.Show(OperationDetailPlanLocalizedResources.OperationDetailPlanItemProductQtyErrorMessage + ": " + RemainProductQty,
                                              MESLocalizedResources.MessageBoxDefaultCaption,
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        if (ChildBlockPerOne > 0)
                        {
                            row.MMOperationDetailPlanItemChildPlanBlock = ChildBlockPerOne * valueQty;
                        }
                        result = true;
                    }
                    if (objOperationDetailPlansInfo.MMOperationDetailPlanID > 0)
                    {
                        MMOperationDetailPlanItemChildsController ctl = new MMOperationDetailPlanItemChildsController();
                        List<MMOperationDetailPlanItemChildsInfo> list = ctl.GetListCapacityByDetailPlan(objOperationDetailPlansInfo.MMOperationDetailPlanID);
                        if (list != null && list.Count > 0)
                        {
                            List<MMOperationDetailPlanItemChildsInfo> jobitem = list.Where(o => o.MMOperationDetailPlanItemChildID == row.MMOperationDetailPlanItemChildID).ToList();
                            if (jobitem != null && jobitem.Sum(j => j.MMOperationDetailPlanItemChildCompletedProductQty) > 0)
                            {
                                if (valueQty < jobitem.Sum(j => j.MMOperationDetailPlanItemChildCompletedProductQty))
                                    MessageBox.Show("Số lượng thay đổi nhỏ hơn SL đã nhập" + ": " + jobitem.Sum(j => j.MMOperationDetailPlanItemChildCompletedProductQty),
                                             MESLocalizedResources.MessageBoxDefaultCaption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                                return false;
                            }
                        }
                    }
                }
                if (result)
                {
                    MMOperationDetailPlanItemChildsInfo humanObject = entity.HumanDetailPlanItemsList.Where(o => o.MMOperationDetailPlanItemChildID == row.MMOperationDetailPlanItemChildID
                    && o.FK_MMBatchProductProductionNormItemID == row.FK_MMBatchProductProductionNormItemID
                    && o.FK_MMOperationID == row.FK_MMOperationID
                    ).FirstOrDefault();
                    if (humanObject != null)
                    {
                        humanObject.MMOperationDetailPlanItemChildPlanProductQty = valueQty;
                        humanObject.MMOperationDetailPlanItemChildPlanBlock = row.MMOperationDetailPlanItemChildBlockPerOne * valueQty;
                    }
                    MMOperationDetailPlanItemChildsInfo machineObject = entity.MachineDetailPlanItemsList.Where(o => o.MMOperationDetailPlanItemChildID == row.MMOperationDetailPlanItemChildID
                    && o.FK_MMBatchProductProductionNormItemID == row.FK_MMBatchProductProductionNormItemID
                    && o.FK_MMOperationID == row.FK_MMOperationID).FirstOrDefault();
                    if (machineObject != null)
                    {
                        machineObject.MMOperationDetailPlanItemChildPlanProductQty = valueQty;
                        machineObject.MMOperationDetailPlanItemChildPlanBlock = row.MMOperationDetailPlanItemChildBlockPerOne * valueQty;
                    }
                    entity.HumanDetailPlanItemsList.GridControl?.RefreshDataSource();
                    entity.MachineDetailPlanItemsList.GridControl?.RefreshDataSource();
                }
            }
            return result;
        }

        #endregion
        #region Ticket grid view

        public void ShowHumanUnit()
        {
            guiChooseHumanUnit gui = new guiChooseHumanUnit();
            gui.DetailPlanSelected = new List<MMBatchProductProductionNormItemsViewInfo>();
            gui.Module = this;
            gui.ShowDialog();
            if (gui.DialogResult == DialogResult.OK)
            {
                SelectedTicketHuman = gui.ResultList;
                FilterTicketGrid(TicketRemainCheckBox.Checked, SelectedTicketHuman, SelectedTicketMachine, false, OperationTicketSelect);
            }
        }

        public void ShowMachineUnit()
        {
            guiChooseMachineUnit gui = new guiChooseMachineUnit();
            gui.DetailPlanSelected = new List<MMBatchProductProductionNormItemsViewInfo>();
            gui.Module = this;
            gui.ShowDialog();
            if (gui.DialogResult == DialogResult.OK)
            {
                SelectedTicketMachine = gui.ResultList;
                FilterTicketGrid(TicketRemainCheckBox.Checked, SelectedTicketHuman, SelectedTicketMachine, false, OperationTicketSelect);
            }
        }
        public void ShowAllTicket()
        {
            SelectedTicketMachine = new List<MMMachineUnitsInfo>();
            SelectedTicketHuman = new List<HRDepartmentRoomGroupItemsInfo>();
            OperationTicketSelect = new List<MMOperationsInfo>();
            TicketRemainCheckBox.Checked = false;
            FilterTicketGrid(false, null, null, false, null);
        }
        public void FilterTicketGrid(bool isRemain, List<HRDepartmentRoomGroupItemsInfo> selectedHuman, List<MMMachineUnitsInfo> selectedMachine, bool getAll, List<MMOperationsInfo> filterOperation)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            if (TicketPlanItemGridControl == null) return;

            if (entity.OperationDetailPlanItemChildsList != null)
            {
                List<MMOperationDetailPlanItemChildsInfo> bindingList = new List<MMOperationDetailPlanItemChildsInfo>();
                //Bind object list to grid for searching
                foreach (MMOperationDetailPlanItemChildsInfo item in entity.OperationDetailPlanItemChildsList)
                {
                    bool isAdd = false;
                    if (isRemain && !getAll)
                    {
                        if (item.MMOperationDetailPlanItemChildPlanProductQty > item.MMOperationDetailPlanItemChildCompletedProductQty)
                            isAdd = true;
                        else isAdd = false;
                    }
                    else isAdd = true;
                    if (selectedHuman != null && selectedHuman.Count > 0 && isAdd)
                        if (CheckTicketExitSelectedHuman(item, selectedHuman)) isAdd = true; else isAdd = false;

                    if (selectedMachine != null && selectedMachine.Count > 0 && isAdd)
                        if (CheckTicketExitSelectedMachine(item, selectedMachine)) isAdd = true; else isAdd = false;

                    if (filterOperation != null && filterOperation.Count > 0 && isAdd)
                        if (filterOperation.Any(o => o.MMOperationID == item.FK_MMOperationID)) isAdd = true; else isAdd = false;

                    MMOperationDetailPlanItemChildsInfo addItem = (MMOperationDetailPlanItemChildsInfo)item.Clone();
                    if (item.MMOperationDetailPlanItemChildStatus != DetailPlanItemChildStatus.Canceled.ToString() &&
                        item.MMOperationDetailPlanItemChildStatus != DetailPlanItemChildStatus.New.ToString())
                        if (isAdd) bindingList.Add(addItem);
                }
                entity.TicketDetailPlanItemsList.Invalidate(bindingList);
                entity.TicketDetailPlanItemsList.GridControl?.RefreshDataSource();
            }
        }
        #endregion
        #region Capacity grid
        public List<MMCapacityHumanUnitsInfo> ToHumanCapacityList(List<MMDetailPlanHumanUnitsInfo> fromList, string guidID)
        {
            List<MMCapacityHumanUnitsInfo> resultList = new List<MMCapacityHumanUnitsInfo>();
            if (fromList != null)
                fromList.ForEach(h =>
                {
                    MMCapacityHumanUnitsInfo obj = new MMCapacityHumanUnitsInfo();
                    obj.FK_HRDepartmentRoomGroupItemID = h.FK_HRDepartmentRoomGroupItemID;
                    obj.FK_MMOperationDetailPlanItemChildID = h.FK_MMOperationDetailPlanItemChildID;
                    obj.FK_HREmployeeID = h.FK_HREmployeeID;
                    obj.MMCapacityHumanUnitDesc = h.MMDetailPlanHumanUnitDesc;
                    obj.MMCapacityHumanUnitAbstract = guidID;
                    resultList.Add(obj);
                });
            return resultList;
        }
        public void GetData(DateTime fromDate, DateTime toDate)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo mainObject = (MMOperationDetailPlansInfo)entity.MainObject;
            MMOperationDetailPlanItemChildsController ctl = new MMOperationDetailPlanItemChildsController();
            List<MMOperationDetailPlanItemChildsInfo> list = ctl.GetListCapacityByDetailPlan(mainObject.MMOperationDetailPlanID == 0 ? 1 : mainObject.MMOperationDetailPlanID);
            List<MMOperationDetailPlanItemChildsInfo> DataList = new List<MMOperationDetailPlanItemChildsInfo>();
            //= (List<MMOperationDetailPlanItemChildsInfo>)entity.TicketDetailPlanItemsList.Where(o => o.Selected
            //                                                                && o.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.JobCreated.ToString()).ToList();
            GridView gridView = (GridView)TicketPlanItemGridControl.MainView;
            for (int j = 0; j < gridView.RowCount; j++)
            {
                MMOperationDetailPlanItemChildsInfo ticketRow = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(j);
                if (ticketRow != null && ticketRow.Selected) //&& ticketRow.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.JobCreated.ToString())
                    DataList.Add(ticketRow);
            }
            bool errorQty = false;
            bool errorStatus = false;
            foreach (MMOperationDetailPlanItemChildsInfo item in DataList)
            {
                if (item.MMOperationDetailPlanItemChildPlanProductQty <= item.MMOperationDetailPlanItemChildCompletedProductQty && item.MMOperationDetailPlanItemChildCompletedProductQty > 0)
                {
                    item.IsError = true;
                    errorQty = true;
                }
                if (item.MMOperationDetailPlanItemChildStatus != DetailPlanItemChildStatus.JobCreated.ToString())
                {
                    item.IsError = true;
                    errorStatus = true;
                }
            }
            string mess = "Có lổi xãy ra: ";
            if (errorQty) mess += Environment.NewLine + "Tồn tại chi tiết đã nhập đủ số lượng";
            if (errorStatus) mess += Environment.NewLine + "Chi tiết có tình trạng không phù hợp";
            if (errorQty || errorStatus)
            {
                BOSApp.ShowMessage(mess);
                return;
            }

            List<MMOperationDetailPlanCapacityItemsInfo> CapacityList = new List<MMOperationDetailPlanCapacityItemsInfo>();
            if (list != null && list.Count > 0)
            {
                DataList.ForEach(o =>
                {
                    List<MMOperationDetailPlanItemChildsInfo> found = list.Where(c => c.MMOperationDetailPlanItemChildID == o.MMOperationDetailPlanItemChildID).ToList();
                    if (found != null && found.Count > 0)
                    {
                        o.MMOperationDetailPlanItemChildCompletedProductQty = found.Sum(f => f.MMOperationDetailPlanItemChildCompletedProductQty);
                        o.MMOperationDetailPlanItemChildCompletedBlock = found.Sum(f => f.MMOperationDetailPlanItemChildCompletedProductQty * f.MMOperationDetailPlanItemChildBlockPerOne);
                        o.MMOperationDetailPlanCapacityItemFailProductQty = found.Sum(f => f.MMOperationDetailPlanCapacityItemFailProductQty);
                        o.MMOperationDetailPlanItemChildRemainProductQty = found.Sum(f => f.MMOperationDetailPlanItemChildPlanProductQty - f.MMOperationDetailPlanCapacityItemFailProductQty);
                        o.MMOperationDetailPlanCapacityItemSyncProductCheck = found[0].MMOperationDetailPlanCapacityItemSyncProductCheck;
                        o.MMOperationDetailPlanCapacityItemHasReceipt = found[0].MMOperationDetailPlanCapacityItemHasReceipt;
                    }
                });
            }
            foreach (MMOperationDetailPlanItemChildsInfo item in DataList)
            {
                MMOperationDetailPlanCapacityItemsInfo objODInfo = new MMOperationDetailPlanCapacityItemsInfo();
                objODInfo.FK_ICProductID = item.FK_ICProductID;
                objODInfo.MMOperationDetailPlanCapacityItemProductName = item.MMOperationDetailPlanItemChildProductName;
                objODInfo.FK_MMLineID = item.FK_MMLineID;
                objODInfo.FK_MMWorkShopID = item.FK_MMWorkShopID;
                objODInfo.FK_MMBatchProductID = item.FK_MMBatchProductID;
                objODInfo.FK_MMOperationID = item.FK_MMOperationID;
                objODInfo.MMOperationDetailPlanCapacityItemDate = fromDate;
                objODInfo.MMOperationDetailPlanCapacityItemFromTime = fromDate;
                objODInfo.MMOperationDetailPlanCapacityItemToTime = fromDate;
                objODInfo.MMOperationDetailPlanCapacityItemLossTime = 0;
                objODInfo.MMOperationDetailPlanCapacityItemPlanProductQty = item.MMOperationDetailPlanItemChildPlanProductQty;
                objODInfo.MMOperationDetailPlanCapacityItemProductQty = 0;
                objODInfo.MMOperationDetailPlanCapacityItemTotalProductQty = item.MMOperationDetailPlanItemChildTotalProductQty;
                objODInfo.MMOperationDetailPlanCapacityItemRemainProductQty = item.MMOperationDetailPlanItemChildRemainProductQty;
                objODInfo.MMOperationDetailPlanCapacityItemCompletedProductQty = item.MMOperationDetailPlanItemChildCompletedProductQty;
                objODInfo.FK_HRDepartmentRoomGroupItemID = item.FK_HRDepartmentRoomGroupItemID;
                objODInfo.FK_MMBatchProductProductionNormItemID = item.FK_MMBatchProductProductionNormItemID;
                objODInfo.FK_MMBatchProductItemID = item.FK_MMBatchProductItemID;
                objODInfo.MMOperationDetailPlanCapacityItemSaleOrdeNo = item.MMOperationDetailPlanItemChildSaleOrdeNo;
                objODInfo.FK_ARSaleOrderID = item.FK_ARSaleOrderID;
                objODInfo.MMOperationDetailPlanCapacityItemProductSerial = item.MMOperationDetailPlanItemChildProductSerial;
                objODInfo.MMOperationDetailPlanCapacityItemBlockPerOne = item.MMOperationDetailPlanItemChildBlockPerOne;
                objODInfo.MMOperationDetailPlanCapacityItemProductForBatchNo = item.MMOperationDetailPlanItemChildProductForBatchNo;
                objODInfo.MMOperationDetailPlanCapacityItemParentProductName = item.MMOperationDetailPlanItemChildProductForBatchName;
                objODInfo.MMOperationDetailPlanCapacityItemProductName = item.MMOperationDetailPlanItemChildProductName;
                objODInfo.MMOperationDetailPlanCapacityItemProductNo = item.MMOperationDetailPlanItemChildProductNo;
                objODInfo.MMOperationDetailPlanCapacityItemParentNo = item.MMOperationDetailPlanItemChildParentNo;
                objODInfo.ICProductCode = item.ICProductCode;
                objODInfo.MMOperationDetailPlanCapacityItemProductHeight = item.MMOperationDetailPlanItemChildProductHeight;
                objODInfo.MMOperationDetailPlanCapacityItemProductWidth = item.MMOperationDetailPlanItemChildProductWidth;
                objODInfo.MMOperationDetailPlanCapacityItemProductLength = item.MMOperationDetailPlanItemChildProductLength;
                objODInfo.FK_ICProductForBatchID = item.FK_ICProductForBatchID;
                objODInfo.FK_MMOperationDetailPlanItemChildID = item.MMOperationDetailPlanItemChildID;
                objODInfo.MMOperationDetailPlanCapacityItemSyncProductCheck = item.MMOperationDetailPlanCapacityItemSyncProductCheck;
                objODInfo.MMOperationDetailPlanCapacityItemHasReceipt = item.MMOperationDetailPlanCapacityItemHasReceipt;
                objODInfo.MMOperationDetailPlanCapacityItemAbstract = Guid.NewGuid().ToString();
                objODInfo.HumanFocusedList = ToHumanCapacityList(item.HumanFocusedList, objODInfo.MMOperationDetailPlanCapacityItemAbstract);
                CapacityList.Add(objODInfo);
            }
            if (CapacityList == null) CapacityList = new List<MMOperationDetailPlanCapacityItemsInfo>();
            entity.CapacityDataList.Invalidate(CapacityList);
            entity.CapacityDataList.GridControl?.RefreshDataSource();
        }
        public void CheckAllTicket(bool value)
        {
            if (TicketPlanItemGridControl != null)
            {
                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
                GridView gridView = (GridView)TicketPlanItemGridControl.MainView;
                EnableCancelMachineButton(true);
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMOperationDetailPlanItemChildsInfo ticketRow = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(j);
                    if (ticketRow != null)
                        ticketRow.Selected = value;
                }
                TicketPlanItemGridControl?.RefreshDataSource();
            }
        }
        public void UpdateCapacityItem(DateTime fromDate, DateTime toDate, int EmployeeQCID, int EmployeeGiveID, int EmployeeReceiptID)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            List<MMOperationDetailPlanCapacityItemsInfo> CheckList = entity.CapacityDataList.Where(i => i.Selected).ToList();
            if (CheckList != null && CheckList.Count > 0)
            {
                entity.CapacityDataList.ForEach(o =>
                {
                    if (o.Selected)
                    {
                        o.MMOperationDetailPlanCapacityItemDate = fromDate;
                        o.MMOperationDetailPlanCapacityItemFromTime = fromDate;
                        o.MMOperationDetailPlanCapacityItemToTime = toDate;
                        o.MMOperationDetailPlanCapacityItemProcessTime = (decimal)(toDate - fromDate).TotalMinutes;
                        MMOperationDetailPlanItemChildsInfo sourceInfo = entity.OperationDetailPlanItemChildsList.Where(p => p.MMOperationDetailPlanItemChildID == o.FK_MMOperationDetailPlanItemChildID).FirstOrDefault();
                        //if (sourceInfo != null && sourceInfo.MachineFocusedList.Count() > 0)
                        //    o.MMOperationDetailPlanCapacityItemLossTime = sourceInfo.MachineFocusedList.Sum(m => m.MMDetailPlanMachineUnitSetupTime) / sourceInfo.MachineFocusedList.Count();
                        o.FK_HREmployeeQCID = EmployeeQCID;
                        o.FK_HREmployeeGiveID = EmployeeGiveID;
                        o.FK_HREmployeeTakeID = EmployeeReceiptID;
                    }
                });
                CapacityItemGridControl?.RefreshDataSource();
            }
            else
            {
                BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
            }
        }
        public void CheckAllCapacity(bool value)
        {
            if (CapacityItemGridControl != null)
            {
                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
                GridView gridView = (GridView)CapacityItemGridControl.MainView;
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMOperationDetailPlanCapacityItemsInfo ticketRow = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(j);
                    if (ticketRow != null)
                        ticketRow.Selected = value;
                }
                CapacityItemGridControl?.RefreshDataSource();
            }
        }

        public bool SyncTicketItem(MMOperationDetailPlanCapacityItemsInfo item, BOSList<MMOperationDetailPlanCapacityItemsInfo> CapacityDataList)
        {
            bool result = true;
            List<MMOperationDetailPlanCapacityItemsInfo> CheckList = new List<MMOperationDetailPlanCapacityItemsInfo>();
            if (item != null)
                CheckList.Add(item);
            else
                CheckList = CapacityDataList.Where(i => i.Selected && (i.MMOperationDetailPlanCapacityItemProductQty > 0
                                                     || i.MMOperationDetailPlanCapacityItemFailProductQty > 0)).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("StringData"));
            List<string> tableList = new List<string>();
            tableList = CheckList.Select(o => o.FK_MMBatchProductProductionNormItemID.ToString()).Distinct().ToList();
            if (tableList != null && tableList.Count > 0)
                foreach (string ID in tableList)
                {
                    DataRow r = dt.NewRow();
                    r[0] = ID;
                    dt.Rows.Add(r);
                }
            MMOperationDetailPlanItemChildsController ctrol = new MMOperationDetailPlanItemChildsController();
            List<MMOperationDetailPlanItemChildsInfo> foundSyncList = ctrol.GetAvailableSyncData(dt);
            if (CheckList != null && CheckList.Count > 0 && foundSyncList != null && foundSyncList.Count > 0)
            {
                foreach (MMOperationDetailPlanCapacityItemsInfo checkItem in CheckList)
                {
                    List<MMOperationDetailPlanItemChildsInfo> found = foundSyncList.Where(o => o.FK_MMBatchProductProductionNormItemID == checkItem.FK_MMBatchProductProductionNormItemID
                                                                                                && o.FK_MMOperationID == checkItem.FK_MMOperationID).ToList();
                    if (found != null && found.Count > 0)
                    {
                        decimal SyncPerCent = 1;
                        decimal canSync = 0;
                        found.ForEach(o =>
                        {
                            decimal dinhMuc = (o.MMOperationDetailPlanItemChildBatchProductItemProductQty > 0 ? o.MMOperationDetailPlanItemChildBatchProductItemProductQty : o.MMOperationDetailPlanItemChildTotalProductQty);
                            if (dinhMuc > 0)
                                o.MMOperationDetailPlanCapacityItemSynchedQty =
                                                                        (o.MMOperationDetailPlanCapacityItemSynchedQty /
                                                                        (o.MMOperationDetailPlanItemChildBatchProductItemProductQty > 0 ? o.MMOperationDetailPlanItemChildBatchProductItemProductQty : o.MMOperationDetailPlanItemChildTotalProductQty))
                                                                        * o.MMOperationDetailPlanItemChildTotalProductQty;

                            canSync = o.MMOperationDetailPlanCapacityItemTotalAvailSync - o.MMOperationDetailPlanCapacityItemSynchedQty;
                            if (o.MMOperationDetailPlanItemChildTotalProductQty > 0)
                                if (canSync / o.MMOperationDetailPlanItemChildTotalProductQty < SyncPerCent)
                                    SyncPerCent = (canSync / o.MMOperationDetailPlanItemChildTotalProductQty);
                        });
                        checkItem.MMOperationDetailPlanCapacityItemCanSync = Math.Round(SyncPerCent * checkItem.MMOperationDetailPlanCapacityItemPlanProductQty, 1);
                        if (checkItem.MMOperationDetailPlanCapacityItemSyncProductCheck && checkItem.MMOperationDetailPlanCapacityItemProductQty > checkItem.MMOperationDetailPlanCapacityItemCanSync)
                        {
                            result = false;
                            checkItem.IsError = true;
                        }
                    }
                    else checkItem.MMOperationDetailPlanCapacityItemCanSync = checkItem.MMOperationDetailPlanCapacityItemPlanProductQty - checkItem.MMOperationDetailPlanCapacityItemCompletedProductQty;

                }
            }
            if (!result && item == null)
            {
                BOSApp.ShowMessage("Số lượng nhập lớn hơn số lượng có thể đồng bộ!");
            }
            return result;
        }
        public void SaveTicketCapapcity()
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            if (entity.CapacityDataList.Where(i => i.MMOperationDetailPlanCapacityItemProductQty > 0
                || i.MMOperationDetailPlanCapacityItemFailProductQty > 0).ToList().Count > 0)
            {
                List<MMOperationDetailPlanCapacityItemsInfo> CheckList = entity.CapacityDataList.Where(i => i.Selected && (i.MMOperationDetailPlanCapacityItemProductQty > i.MMOperationDetailPlanCapacityItemPlanProductQty
                                                                                     )).ToList();

                if (CheckList != null && CheckList.Count > 0)
                {
                    CheckList.ForEach(er => er.IsError = true);
                    BOSApp.ShowMessage("Tổng số lượng nhập lớn hơn SL thẻ!");
                }
                else
                {
                    List<MMOperationDetailPlanCapacityItemsInfo> saveList = entity.CapacityDataList.Where(i => i.Selected &&
                       (i.MMOperationDetailPlanCapacityItemProductQty > 0 || i.MMOperationDetailPlanCapacityItemFailProductQty > 0)).ToList();
                    if (saveList.Count() > 0)
                    {
                        SaveItemWithDataTableType.SaveItemWithoutDelete<MMOperationDetailPlanCapacityItemsInfo>(entity.CapacityDataList.Where(i => i.Selected &&
                           (i.MMOperationDetailPlanCapacityItemProductQty > 0
                         || i.MMOperationDetailPlanCapacityItemFailProductQty > 0)).ToList(), "MMOperationDetailPlanCapacityItemID", "MMOperationDetailPlanCapacityItems", 0, BOSApp.CurrentUsersInfo.ADUserName);

                        //Save Human
                        List<MMCapacityHumanUnitsInfo> saveHuman = new List<MMCapacityHumanUnitsInfo>();
                        saveList.ForEach(o =>
                        {
                            if (o.HumanFocusedList.Count() > 0)
                                saveHuman.AddRange(o.HumanFocusedList);
                        });
                        if (saveHuman.Count() > 0)
                        {
                            SaveItemWithDataTableType.SaveItemWithoutDelete<MMCapacityHumanUnitsInfo>(saveHuman, "MMCapacityHumanUnitID", "MMCapacityHumanUnits", 0, BOSApp.CurrentUsersInfo.ADUserName);
                        }
                    }
                    else
                    {
                        BOSApp.ShowMessage("Tổng số lượng bằng 0!");
                        return;
                    }
                    ValidateExitCapacity(null, entity.TicketDetailPlanItemsList, false);
                    if (TicketPlanItemGridControl != null)
                    {
                        GridView gridView = (GridView)TicketPlanItemGridControl.MainView;
                        for (int j = 0; j < gridView.RowCount; j++)
                        {
                            MMOperationDetailPlanItemChildsInfo ticketRow = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(j);
                            if (ticketRow != null)
                            {
                                MMOperationDetailPlanItemChildsInfo mainObjectDetailPlan = entity.TicketDetailPlanItemsList.Where(o =>
                                                                          o.MMOperationDetailPlanItemChildID == ticketRow.MMOperationDetailPlanItemChildID
                                                                       ).FirstOrDefault();
                                if (mainObjectDetailPlan != null)
                                {
                                    ticketRow.MMOperationDetailPlanItemChildCompletedProductQty = mainObjectDetailPlan.MMOperationDetailPlanItemChildCompletedProductQty;
                                    ticketRow.MMOperationDetailPlanCapacityItemFailProductQty = mainObjectDetailPlan.MMOperationDetailPlanCapacityItemFailProductQty;
                                }
                            }
                        }
                        TicketPlanItemGridControl?.RefreshDataSource();
                    }
                    if (CapacityItemGridControl != null)
                    {
                        entity.CapacityDataList.Invalidate(entity.CapacityDataList.Where(i => !i.Selected).ToList());
                        CapacityItemGridControl.DataSource = entity.CapacityDataList;
                        CapacityItemGridControl?.RefreshDataSource();
                    }
                    BOSApp.ShowMessage("Cập nhật thành công!");
                }
            }
            else
            {
                BOSApp.ShowMessage("Vui lòng nhập SL chi tiết!");
            }
        }
        #endregion
        #region Human & Machine Grid
        public void CheckedAllByFilterItem(bool isChecked)
        {
            MMOperationDetailPlanItemChildsGridControl fld_dgcPlanChildItems = (MMOperationDetailPlanItemChildsGridControl)Controls["fld_dgcMMOperationDetailPlanItemChilds"];
            if (fld_dgcPlanChildItems == null) return;
            GridView gridView = (GridView)fld_dgcPlanChildItems.MainView;
            List<MMOperationDetailPlanItemChildsInfo> listView = new List<MMOperationDetailPlanItemChildsInfo>();
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;

            List<MMOperationDetailPlanItemChildsInfo> objects = new List<MMOperationDetailPlanItemChildsInfo>();
            for (int j = 0; j < gridView.RowCount; j++)
            {
                MMOperationDetailPlanItemChildsInfo obj = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(j);
                if (obj != null)
                {
                    objects.Add(obj);
                }
            }
            if (objects != null)
            {
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMOperationDetailPlanItemChildsInfo obj = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(j);
                    if (obj != null)
                    {
                        listView.Add(obj);
                    }
                }
                for (int i = 0; i < objects.Count; i++)
                {
                    foreach (var dataViewItem in listView)
                    {
                        if (objects[i] == dataViewItem)
                        {
                            objects[i].Selected = isChecked;
                            objects[i].IsError = false;
                        }
                    }
                }
            }
            fld_dgcPlanChildItems?.RefreshDataSource();
        }
        public void FilterDetailPlanHumanGrid(bool notJetAllowcation, bool isTicketHaveEmp, bool isByOperation, string operationList, List<HRDepartmentRoomGroupItemsInfo> selectedHuman)
        {
            if (PlanHumanUnitItemGridControl == null) return;
            GridView gridView = (GridView)PlanHumanUnitItemGridControl.MainView;
            List<MMOperationDetailPlanItemChildsInfo> listView = new List<MMOperationDetailPlanItemChildsInfo>();
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            string[] operationID = operationList.Split(',');

            if (entity.HumanDetailPlanItemsList != null)
            {
                List<MMOperationDetailPlanItemChildsInfo> bindingList = new List<MMOperationDetailPlanItemChildsInfo>();
                if (selectedHuman == null)
                    selectedHuman = GetHumanSelectedNote();
                //Bind object list to grid for searching
                foreach (MMOperationDetailPlanItemChildsInfo item in entity.HumanDetailPlanItemsList)
                {
                    bool isAdd = false;
                    if (notJetAllowcation && !isTicketHaveEmp && isByOperation)
                    {
                        if (!CheckTicketAllowcationHuman(item)) isAdd = true; else isAdd = false;
                        if (isAdd)
                        {
                            isAdd = false;
                            foreach (var ID in operationID)
                            {
                                if (item.FK_MMOperationID.ToString() == ID)
                                {
                                    isAdd = true;
                                    break;
                                }
                            }
                        }
                    }
                    else if (!notJetAllowcation && isTicketHaveEmp && isByOperation)
                    {

                        if (CheckTicketAllowcationHuman(item)) isAdd = true; else isAdd = false;
                        if (isAdd)
                        {
                            isAdd = false;
                            foreach (var ID in operationID)
                            {
                                if (item.FK_MMOperationID.ToString() == ID)
                                {
                                    isAdd = true;
                                    break;
                                }
                            }
                        }
                        if (isAdd)
                            if (CheckTicketExitSelectedHuman(item, selectedHuman)) isAdd = true; else isAdd = false;
                    }
                    else if (notJetAllowcation && !isTicketHaveEmp && !isByOperation)
                    {
                        if (!CheckTicketAllowcationHuman(item)) isAdd = true; else isAdd = false;
                        if (isAdd && !CheckTicketIsByOperation(operationID, item)) isAdd = true; else isAdd = false;
                    }
                    else if (!notJetAllowcation && isTicketHaveEmp && !isByOperation)
                    {
                        if (CheckTicketAllowcationHuman(item)) isAdd = true; else isAdd = false;
                        if (isAdd && !CheckTicketIsByOperation(operationID, item)) isAdd = true; else isAdd = false;
                        if (isAdd)
                            if (CheckTicketExitSelectedHuman(item, selectedHuman)) isAdd = true; else isAdd = false;
                    }
                    else if (notJetAllowcation && isTicketHaveEmp && !isByOperation)
                    {
                        isAdd = true;
                        if (CheckTicketExitSelectedHuman(item, selectedHuman)) isAdd = true; else isAdd = false;
                        if (isAdd && !CheckTicketIsByOperation(operationID, item)) isAdd = true; else isAdd = false;
                    }
                    else if (notJetAllowcation && isTicketHaveEmp && isByOperation)
                    {

                        foreach (var ID in operationID)
                        {
                            if (item.FK_MMOperationID.ToString() == ID)
                            {
                                isAdd = true;
                                break;
                            }
                            else isAdd = false;
                        }
                        if (isAdd)
                            if (CheckTicketExitSelectedHuman(item, selectedHuman)) isAdd = true; else isAdd = false;
                    }

                    MMOperationDetailPlanItemChildsInfo addItem = (MMOperationDetailPlanItemChildsInfo)item.Clone();
                    if (isAdd) bindingList.Add(addItem);
                }
                PlanHumanUnitItemGridControl.DataSource = bindingList;
                PlanHumanUnitItemGridControl?.RefreshDataSource();
            }
        }
        public void FilterDetailPlanMachineGrid(bool notJetAllowcation, bool isTicketHaveMachine, bool isByOperation, string operationList, int workShopID, List<MMMachineUnitsInfo> selectedMachine)
        {
            if (PlanMachineUnitItemGridControl == null) return;
            GridView gridView = (GridView)PlanHumanUnitItemGridControl.MainView;
            List<MMOperationDetailPlanItemChildsInfo> listView = new List<MMOperationDetailPlanItemChildsInfo>();
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            string[] operationID = operationList.Split(',');

            if (entity.MachineDetailPlanItemsList != null)
            {
                List<MMOperationDetailPlanItemChildsInfo> bindingList = new List<MMOperationDetailPlanItemChildsInfo>();
                if (selectedMachine == null)
                    selectedMachine = GetMachineSelectedNote();
                foreach (MMOperationDetailPlanItemChildsInfo item in entity.MachineDetailPlanItemsList)
                {
                    bool isAdd = false;

                    if (workShopID > 0 && item.FK_MMWorkShopID != workShopID) isAdd = false;
                    else
                    {
                        if (notJetAllowcation && !isTicketHaveMachine && isByOperation)
                        {
                            if (!CheckTicketAllowcationMachine(item)) isAdd = true; else isAdd = false;
                            if (isAdd)
                            {
                                foreach (var ID in operationID)
                                {
                                    if (item.FK_MMOperationID.ToString() == ID)
                                    {
                                        isAdd = true;
                                        break;
                                    }
                                    else isAdd = false;
                                }
                            }
                        }
                        else if (!notJetAllowcation && isTicketHaveMachine && isByOperation)
                        {
                            if (CheckTicketAllowcationMachine(item)) isAdd = true; else isAdd = false;
                            if (isAdd)
                                foreach (var ID in operationID)
                                {
                                    if (item.FK_MMOperationID.ToString() == ID)
                                    {
                                        isAdd = true;
                                        break;
                                    }
                                    else isAdd = false;
                                }
                            if (isAdd)
                                if (CheckTicketExitSelectedMachine(item, selectedMachine)) isAdd = true; else isAdd = false;
                        }
                        else if (notJetAllowcation && !isTicketHaveMachine && !isByOperation)
                        {
                            if (!CheckTicketAllowcationMachine(item)) isAdd = true; else isAdd = false;
                            if (isAdd && !CheckTicketIsByOperation(operationID, item)) isAdd = true; else isAdd = false;
                        }
                        else if (!notJetAllowcation && isTicketHaveMachine && !isByOperation)
                        {
                            if (CheckTicketAllowcationMachine(item)) isAdd = true; else isAdd = false;
                            if (isAdd)
                                if (CheckTicketExitSelectedMachine(item, selectedMachine)) isAdd = false; else isAdd = true;
                            if (isAdd && !CheckTicketIsByOperation(operationID, item)) isAdd = true; else isAdd = false;
                        }
                        else if (notJetAllowcation && isTicketHaveMachine && !isByOperation)
                        {
                            isAdd = true;
                            if (CheckTicketExitSelectedMachine(item, selectedMachine)) isAdd = false; else isAdd = true;
                            if (isAdd && !CheckTicketIsByOperation(operationID, item)) isAdd = true; else isAdd = false;
                        }
                        else if (notJetAllowcation && isTicketHaveMachine && isByOperation)
                        {
                            foreach (var ID in operationID)
                            {
                                if (item.FK_MMOperationID.ToString() == ID)
                                {
                                    isAdd = true;
                                    break;
                                }
                                else isAdd = false;
                            }
                            if (isAdd)
                                if (CheckTicketExitSelectedMachine(item, selectedMachine)) isAdd = true; else isAdd = false;
                        }
                    }
                    if (isAdd) bindingList.Add(item);
                }
                PlanMachineUnitItemGridControl.DataSource = bindingList;
                PlanMachineUnitItemGridControl?.RefreshDataSource();

            }
        }
        public bool CheckTicketIsByOperation(string[] operationID, MMOperationDetailPlanItemChildsInfo item)
        {
            bool isAdd = false;
            foreach (var ID in operationID)
            {
                if (item.FK_MMOperationID.ToString() == ID)
                {
                    isAdd = true;
                    break;
                }
                else isAdd = false;
            }
            return isAdd;
        }

        public bool CheckTicketAllowcationHuman(MMOperationDetailPlanItemChildsInfo item)
        {
            bool result = false;
            if (item.HumanFocusedList != null && item.HumanFocusedList.Count > 0)
                result = true;
            return result;
        }
        public bool CheckTicketExitSelectedHuman(MMOperationDetailPlanItemChildsInfo item, List<HRDepartmentRoomGroupItemsInfo> selectedHuman)
        {
            bool result = false;

            if (item.HumanFocusedList != null && item.HumanFocusedList.Count > 0)
            {
                if (selectedHuman != null && selectedHuman.Count > 0)
                {
                    foreach (MMDetailPlanHumanUnitsInfo o in item.HumanFocusedList)
                    {
                        if (selectedHuman.Any(h => h.HREmployeeID == o.FK_HREmployeeID && h.HREmployeeID > 0))
                        {
                            result = true;
                            break;
                        }
                    }
                }
                else result = true;
            }
            else
            {
                if (selectedHuman == null || selectedHuman.Count == 0) result = true;
            }
            return result;
        }
        public bool CheckTicketAllowcationMachine(MMOperationDetailPlanItemChildsInfo item)
        {
            bool result = false;
            if (item.MachineFocusedList != null && item.MachineFocusedList.Count > 0)
                result = true;
            return result;
        }
        public bool CheckTicketExitSelectedMachine(MMOperationDetailPlanItemChildsInfo item, List<MMMachineUnitsInfo> selectedMachine)
        {
            bool result = false;

            if (item.MachineFocusedList != null && item.MachineFocusedList.Count > 0)
            {
                if (selectedMachine != null && selectedMachine.Count > 0)
                {
                    foreach (MMDetailPlanMachineUnitsInfo o in item.MachineFocusedList)
                    {
                        if (selectedMachine.Any(h => h.FK_ACAssetID == o.FK_ACAssetID && h.FK_ACAssetID > 0))
                        {
                            result = true;
                            break;
                        }
                    }
                }
                else result = true;
            }
            else
            {
                if (selectedMachine == null || selectedMachine.Count == 0) result = true;
            }
            return result;
        }
        public void RefreshHumanToTicket()
        {
            if (PlanHumanUnitItemGridControl != null)
            {
                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
                GridView gridView = (GridView)PlanHumanUnitItemGridControl.MainView;
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMOperationDetailPlanItemChildsInfo ticketRow = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(j);
                    if (ticketRow != null)
                    {
                        MMOperationDetailPlanItemChildsInfo mainObjectDetailPlan = entity.OperationDetailPlanItemChildsList.Where(o =>
                                                                  o.MMOperationDetailPlanItemChildID == ticketRow.MMOperationDetailPlanItemChildID
                                                               && o.FK_MMBatchProductProductionNormItemID == ticketRow.FK_MMBatchProductProductionNormItemID
                                                                && o.MMOperationDetailPlanItemChildAbstract == ticketRow.MMOperationDetailPlanItemChildAbstract
                                                               && o.FK_MMOperationID == ticketRow.FK_MMOperationID
                                                               ).FirstOrDefault();
                        if (mainObjectDetailPlan != null)
                        {
                            ticketRow.HumanFocusedList = mainObjectDetailPlan.HumanFocusedList;
                            MMOperationDetailPlanItemChildsInfo item = entity.HumanDetailPlanItemsList.Where(o => o.MMOperationDetailPlanItemChildID == ticketRow.MMOperationDetailPlanItemChildID
                                                                                                           && o.FK_MMBatchProductProductionNormItemID == ticketRow.FK_MMBatchProductProductionNormItemID
                                                                                                           && o.FK_MMOperationID == ticketRow.FK_MMOperationID
                                                                                                           && o.MMOperationDetailPlanItemChildAbstract == ticketRow.MMOperationDetailPlanItemChildAbstract
                                                                                                           ).FirstOrDefault();
                            if (item != null) item.HumanFocusedList = mainObjectDetailPlan.HumanFocusedList;
                        }

                    }
                }
                PlanHumanUnitItemGridControl?.RefreshDataSource();
            }
        }
        public void RefreshMachineToTicket()
        {
            if (PlanMachineUnitItemGridControl != null)
            {
                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
                GridView gridView = (GridView)PlanMachineUnitItemGridControl.MainView;
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMOperationDetailPlanItemChildsInfo ticketRow = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(j);
                    if (ticketRow != null)
                    {
                        MMOperationDetailPlanItemChildsInfo mainObjectDetailPlan = entity.OperationDetailPlanItemChildsList.Where(o =>
                                                                  o.MMOperationDetailPlanItemChildID == ticketRow.MMOperationDetailPlanItemChildID
                                                               && o.FK_MMBatchProductProductionNormItemID == ticketRow.FK_MMBatchProductProductionNormItemID
                                                               && o.FK_MMOperationID == ticketRow.FK_MMOperationID
                                                               && o.MMOperationDetailPlanItemChildAbstract == ticketRow.MMOperationDetailPlanItemChildAbstract
                                                               ).FirstOrDefault();
                        if (mainObjectDetailPlan != null)
                        {
                            ticketRow.MachineFocusedList = mainObjectDetailPlan.MachineFocusedList;
                            MMOperationDetailPlanItemChildsInfo item = entity.HumanDetailPlanItemsList.Where(o => o.MMOperationDetailPlanItemChildID == ticketRow.MMOperationDetailPlanItemChildID
                                                                                                            && o.FK_MMBatchProductProductionNormItemID == ticketRow.FK_MMBatchProductProductionNormItemID
                                                                                                            && o.FK_MMOperationID == ticketRow.FK_MMOperationID
                                                                                                            && o.MMOperationDetailPlanItemChildAbstract == ticketRow.MMOperationDetailPlanItemChildAbstract
                                                                                                            ).FirstOrDefault();
                            if (item != null) item.MachineFocusedList = mainObjectDetailPlan.MachineFocusedList;
                        }

                    }
                }
                PlanMachineUnitItemGridControl?.RefreshDataSource();
            }
        }
        public void CheckAllHumanTicket(bool value)
        {
            if (PlanHumanUnitItemGridControl != null)
            {

                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
                GridView gridView = (GridView)PlanHumanUnitItemGridControl.MainView;
                EnableCancelHumanButton(true);
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMOperationDetailPlanItemChildsInfo ticketRow = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(j);
                    if (ticketRow != null)
                        ticketRow.Selected = value;
                }
                PlanHumanUnitItemGridControl?.RefreshDataSource();
            }
        }
        public void CheckAllMachineTicket(bool value)
        {
            if (PlanMachineUnitItemGridControl != null)
            {
                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
                GridView gridView = (GridView)PlanMachineUnitItemGridControl.MainView;
                EnableCancelMachineButton(true);
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMOperationDetailPlanItemChildsInfo ticketRow = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(j);
                    if (ticketRow != null)
                        ticketRow.Selected = value;
                }
                PlanMachineUnitItemGridControl?.RefreshDataSource();
            }
        }

        public bool AddHumanToTicket()
        {
            bool result = true;
            if (Toolbar.IsNullOrNoneAction()) ActionEdit();

            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            List<object> filterList = new List<object>();
            List<MMOperationDetailPlanItemChildsInfo> selectedList = new List<MMOperationDetailPlanItemChildsInfo>();
            GridView gridView = (GridView)PlanHumanUnitItemGridControl.MainView;
            if (gridView != null)
            {
                filterList = (List<object>)gridView.DataController.GetAllFilteredAndSortedRows();
                if (filterList != null)
                    foreach (object obj in filterList)
                    {
                        MMOperationDetailPlanItemChildsInfo item = (MMOperationDetailPlanItemChildsInfo)obj;
                        if (item != null && item.Selected)
                            selectedList.Add(item);
                    }
            }
            if (selectedList != null && selectedList.Count > 0)
            {
                List<HRDepartmentRoomGroupItemsInfo> selectedNode = GetHumanSelectedNote();
                if (selectedNode != null && selectedNode.Count > 0)
                {
                    //List<MMOperationDetailPlanItemChildsInfo> capacityList = selectedList.Where(o => o.MMOperationDetailPlanItemChildCompletedProductQty > 0).ToList();

                    //if (capacityList != null && capacityList.Count > 0)
                    //{
                    //    BOSApp.ShowMessage("Tồn tại chi tiết đã nhập sản lượng!");
                    //    return false;
                    //}
                    foreach (MMOperationDetailPlanItemChildsInfo ticketRow in selectedList)
                    {
                        MMOperationDetailPlanItemChildsInfo item = entity.HumanDetailPlanItemsList.Where(o => o.MMOperationDetailPlanItemChildID == ticketRow.MMOperationDetailPlanItemChildID
                                                                                                            && o.FK_MMBatchProductProductionNormItemID == ticketRow.FK_MMBatchProductProductionNormItemID
                                                                                                            && o.FK_MMOperationID == ticketRow.FK_MMOperationID
                                                                                                            && o.MMOperationDetailPlanItemChildAbstract == ticketRow.MMOperationDetailPlanItemChildAbstract
                                                                                                            ).FirstOrDefault();
                        item.HumanFocusedList = new List<MMDetailPlanHumanUnitsInfo>();
                        AddTempHumanUnit(item, true);
                        ticketRow.HumanFocusedList = item.HumanFocusedList;
                        ticketRow.Employee = item.HumanFocusedList.Count;
                    }
                    entity.HumanDetailPlanItemsList.GridControl?.RefreshDataSource();

                    //string operationID = string.Join(",", OperationHumanSelect.Select(o => o.MMOperationID.ToString()).Distinct().ToArray());
                    //int departmentID = 0;
                    //if (HumanDepartmentLoopkup != null && HumanDepartmentLoopkup.EditValue != null)
                    //    int.TryParse(HumanDepartmentLoopkup.EditValue.ToString(), out departmentID);
                    //GetTreeHumanDataSource((HumanNotTicket != null ? HumanNotTicket.Checked : false), operationID, departmentID);
                }
                else
                {
                    BOSApp.ShowMessage("Vui lòng chọn nhân công trước!");
                    result = false;
                }

            }
            else
            {
                BOSApp.ShowMessage("Vui lòng chọn công việc trước!");
                result = false;
            }
            return result;
        }
        public bool AddMachineToTicket()
        {
            bool result = true;
            if (Toolbar.IsNullOrNoneAction()) ActionEdit();

            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            List<object> filterList = new List<object>();
            List<MMOperationDetailPlanItemChildsInfo> selectedList = new List<MMOperationDetailPlanItemChildsInfo>();
            GridView gridView = (GridView)PlanMachineUnitItemGridControl.MainView;
            if (gridView != null)
            {
                filterList = (List<object>)gridView.DataController.GetAllFilteredAndSortedRows();
                if (filterList != null)
                    foreach (object obj in filterList)
                    {
                        MMOperationDetailPlanItemChildsInfo item = (MMOperationDetailPlanItemChildsInfo)obj;
                        if (item != null && item.Selected)
                            selectedList.Add(item);
                    }
            }
            if (selectedList != null && selectedList.Count > 0)
            {
                foreach (MMOperationDetailPlanItemChildsInfo ticketRow in selectedList)
                {
                    MMOperationDetailPlanItemChildsInfo item = entity.MachineDetailPlanItemsList.Where(o => o.MMOperationDetailPlanItemChildID == ticketRow.MMOperationDetailPlanItemChildID
                                                                                               && o.FK_MMBatchProductProductionNormItemID == ticketRow.FK_MMBatchProductProductionNormItemID
                                                                                               && o.MMOperationDetailPlanItemChildAbstract == ticketRow.MMOperationDetailPlanItemChildAbstract
                                                                                               && o.FK_MMOperationID == ticketRow.FK_MMOperationID
                                                                                               ).FirstOrDefault();
                    item.MachineFocusedList = new List<MMDetailPlanMachineUnitsInfo>();
                    AddTempMachineUnit(item, true);
                    ticketRow.MachineFocusedList = item.MachineFocusedList;
                    ticketRow.Machine = item.MachineFocusedList.Count;
                    ticketRow.MachineDetail = ticketRow.MachineFocusedList != null ? string.Join(";", ticketRow.MachineFocusedList.Select(m => m.MMMachineUnitName).Distinct().ToArray()) : string.Empty;
                    MMDetailPlanEquipmentsInfo equipment = entity.EquipmentDetailPlansList.Where(o => o.FK_MMOperationDetailPlanItemChildID == ticketRow.MMOperationDetailPlanItemChildID).FirstOrDefault();
                    if (equipment != null)
                    {
                        equipment.Machine = item.MachineFocusedList.Count;
                    }
                }
                entity.MachineDetailPlanItemsList.GridControl?.RefreshDataSource();
                entity.EquipmentDetailPlansList.GridControl?.RefreshDataSource();
            }
            else
            {
                BOSApp.ShowMessage("Vui lòng chọn công việc trước!");
                result = false;
            }
            return result;
        }
        public void EnableCancelHumanButton(bool visible)
        {

            if (CancelHumanBottun != null)
                CancelHumanBottun.Visible = visible;
            if (PlanHumanUnitItemGridControl != null && visible)
                PlanHumanUnitItemGridControl.IsEdit = visible;
        }
        public void EnableCancelMachineButton(bool visible)
        {
            if (CancelMachineBottun != null)
                CancelMachineBottun.Visible = visible;
            if (PlanMachineUnitItemGridControl != null && visible)
                PlanMachineUnitItemGridControl.IsEdit = visible;
        }

        public void AddTempHumanUnit(MMOperationDetailPlanItemChildsInfo item, bool isAdd)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            List<HRDepartmentRoomGroupItemsInfo> selectedNode = GetHumanSelectedNote();
            if (selectedNode != null && selectedNode.Count > 0)
            {
                if (item.HumanFocusedList == null) item.HumanFocusedList = new List<MMDetailPlanHumanUnitsInfo>();
                selectedNode.ForEach(hu =>
                {
                    MMDetailPlanHumanUnitsInfo hUnit = new MMDetailPlanHumanUnitsInfo();
                    hUnit.FK_HREmployeeID = hu.HREmployeeID;
                    hUnit.FK_HRDepartmentRoomGroupItemID = hu.HRDepartmentRoomGroupItemParentID;
                    hUnit.MMDetailPlanHumanUnitAbstract = item.MMOperationDetailPlanItemChildAbstract;
                    hUnit.FK_MMOperationID = item.FK_MMOperationID;
                    hUnit.FK_MMBatchProductProductionNormItemID = item.FK_MMBatchProductProductionNormItemID;
                    hUnit.FK_MMOperationDetailPlanItemChildID = item.MMOperationDetailPlanItemChildID;
                    MMDetailPlanHumanUnitsInfo mExitUnit = item.HumanFocusedList.Where(o => o.FK_MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID
                                                                                        && o.FK_MMOperationID == item.FK_MMOperationID
                                                                                        && o.FK_HREmployeeID == hu.HREmployeeID
                                                                                        && o.MMDetailPlanHumanUnitAbstract == item.MMOperationDetailPlanItemChildAbstract
                                                                                        && o.FK_MMOperationDetailPlanItemChildID == item.MMOperationDetailPlanItemChildID).FirstOrDefault();
                    if ((mExitUnit == null || mExitUnit.MMDetailPlanHumanUnitAbstract == string.Empty) && isAdd)
                        item.HumanFocusedList.Add(hUnit);
                    else if (!isAdd && mExitUnit != null && mExitUnit.MMDetailPlanHumanUnitAbstract != string.Empty)
                    {
                        int iIdex = item.HumanFocusedList.IndexOf(mExitUnit);
                        if (iIdex >= 0)
                        {
                            item.HumanFocusedList.RemoveAt(iIdex);
                        }
                    }
                });
            }
            else
            {
                //BOSApp.ShowMessage("Vui lòng chọn nhân công trước!");
                return;
            }
        }
        public void AddTempMachineUnit(MMOperationDetailPlanItemChildsInfo item, bool isAdd)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            List<MMMachineUnitsInfo> selectedNode = GetMachineSelectedNote();
            if (selectedNode != null && selectedNode.Count > 0)
            {
                if (item.MachineFocusedList == null) item.MachineFocusedList = new List<MMDetailPlanMachineUnitsInfo>();
                selectedNode.ForEach(hu =>
                {
                    MMDetailPlanMachineUnitsInfo hUnit = new MMDetailPlanMachineUnitsInfo();
                    hUnit.FK_ACAssetID = hu.FK_ACAssetID;
                    hUnit.FK_MMMachineUnitID = hu.MMMachineUnitID;
                    hUnit.MMDetailPlanMachineUnitAbstract = item.MMOperationDetailPlanItemChildAbstract;
                    hUnit.FK_MMOperationID = item.FK_MMOperationID;
                    hUnit.FK_MMBatchProductProductionNormItemID = item.FK_MMBatchProductProductionNormItemID;
                    hUnit.FK_MMOperationDetailPlanItemChildID = item.MMOperationDetailPlanItemChildID;
                    MMDetailPlanMachineUnitsInfo mExitUnit = item.MachineFocusedList.Where(o => o.FK_MMBatchProductProductionNormItemID == item.FK_MMBatchProductProductionNormItemID
                                                                                        && o.FK_MMOperationID == item.FK_MMOperationID
                                                                                        && o.FK_ACAssetID == hu.FK_ACAssetID
                                                                                        && o.MMDetailPlanMachineUnitAbstract == item.MMOperationDetailPlanItemChildAbstract
                                                                                        && o.FK_MMOperationDetailPlanItemChildID == item.MMOperationDetailPlanItemChildID).FirstOrDefault();
                    if ((mExitUnit == null || mExitUnit.MMDetailPlanMachineUnitAbstract == string.Empty) && isAdd)
                        item.MachineFocusedList.Add(hUnit);
                    else if (!isAdd && mExitUnit != null && mExitUnit.MMDetailPlanMachineUnitAbstract != string.Empty)
                    {
                        int iIdex = item.MachineFocusedList.IndexOf(mExitUnit);
                        if (iIdex >= 0)
                        {
                            item.MachineFocusedList.RemoveAt(iIdex);
                        }
                    }
                    item.Machine = item.MachineFocusedList.Count;
                    item.MachineDetail = item.MachineFocusedList != null ? string.Join(";", item.MachineFocusedList.Select(m => m.MMMachineUnitName).Distinct().ToArray()) : string.Empty;
                });
            }
            else
            {
                BOSApp.ShowMessage("Vui lòng chọn máy móc trước!");
                return;
            }
        }

        public List<HRDepartmentRoomGroupItemsInfo> GetHumanSelectedNote()
        {
            List<HRDepartmentRoomGroupItemsInfo> result = new List<HRDepartmentRoomGroupItemsInfo>();
            if (HumanUnitTreeListControl != null)
            {
                HumanUnitTreeListControl.ResultList = new List<HRDepartmentRoomGroupItemsInfo>();
                if (HumanUnitTreeListControl.Nodes != null)
                    foreach (DevExpress.XtraTreeList.Nodes.TreeListNode item in HumanUnitTreeListControl.Nodes)
                    {
                        HRDepartmentRoomGroupItemsInfo childNote = (HRDepartmentRoomGroupItemsInfo)HumanUnitTreeListControl.GetDataRecordByNode(item);
                        if (childNote != null && childNote.Selected && childNote.HREmployeeID > 0)
                        {
                            HumanUnitTreeListControl.ResultList.Add((HRDepartmentRoomGroupItemsInfo)childNote.Clone());
                        }
                        HumanUnitTreeListControl.GetSelectedValueFromTree(item);
                    }
                if (HumanUnitTreeListControl.ResultList != null)
                    result.AddRange(HumanUnitTreeListControl.ResultList);
            }
            return result;
        }
        public List<MMMachineUnitsInfo> GetMachineSelectedNote()
        {
            List<MMMachineUnitsInfo> result = new List<MMMachineUnitsInfo>();
            if (MachineUnitTreeListControl != null)
            {
                MachineUnitTreeListControl.ResultList = new List<MMMachineUnitsInfo>();
                if (MachineUnitTreeListControl.Nodes != null)
                    foreach (DevExpress.XtraTreeList.Nodes.TreeListNode item in MachineUnitTreeListControl.Nodes)
                    {
                        MMMachineUnitsInfo childNote = (MMMachineUnitsInfo)MachineUnitTreeListControl.GetDataRecordByNode(item);
                        if (childNote != null && childNote.Selected && childNote.FK_ACAssetID > 0)
                        {
                            MachineUnitTreeListControl.ResultList.Add((MMMachineUnitsInfo)childNote.Clone());
                        }
                        MachineUnitTreeListControl.GetSelectedValueFromTree(item);
                    }
                if (MachineUnitTreeListControl.ResultList != null)
                    result.AddRange(MachineUnitTreeListControl.ResultList);
            }
            return result;
        }

        public int CheckTicketMergeMultiMachine(MMOperationDetailPlanItemChildsInfo item)
        {
            int result = 0;
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            List<MMMachineUnitsInfo> selectedNode = GetMachineSelectedNote();
            //Continue
            if (selectedNode != null && selectedNode.Count > 0)
            {
                List<MMMachineUnitsInfo> notExitList = new List<MMMachineUnitsInfo>();
                selectedNode.ForEach(s =>
                {
                    MMDetailPlanMachineUnitsInfo found = item.MachineFocusedList.Where(h => h.FK_ACAssetID == s.FK_ACAssetID).FirstOrDefault();
                    if (found == null || found.FK_ACAssetID == 0)
                        notExitList.Add((MMMachineUnitsInfo)s.Clone());
                });
                if (notExitList != null && notExitList.Count > 0)
                    result = 2;
                else
                    result = 1;
            }
            return result;
        }
        public int CheckTicketMergeMultiHuman(MMOperationDetailPlanItemChildsInfo item)
        {
            int result = 0;
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            List<HRDepartmentRoomGroupItemsInfo> selectedNode = GetHumanSelectedNote();
            //Continue
            if (selectedNode != null && selectedNode.Count > 0)
            {
                if (item.HumanFocusedList != null && item.HumanFocusedList.Count > 0)
                {
                    List<HRDepartmentRoomGroupItemsInfo> notExitList = new List<HRDepartmentRoomGroupItemsInfo>();
                    selectedNode.ForEach(s =>
                    {
                        MMDetailPlanHumanUnitsInfo found = item.HumanFocusedList.Where(h => h.FK_HREmployeeID == s.HREmployeeID).FirstOrDefault();
                        if (found == null || found.FK_HREmployeeID == 0)
                            notExitList.Add((HRDepartmentRoomGroupItemsInfo)s.Clone());
                    });
                    if (notExitList != null && notExitList.Count > 0)
                        result = 2;
                    else
                        result = 1;
                }
            }
            return result;
        }
        public void SetHumanTotalQty()
        {
            if (PlanHumanUnitItemGridControl != null)
            {
                GridView gridView = PlanHumanUnitItemGridControl.MainView as GridView;
                BOSLabel lbltotalQty = (BOSLabel)Controls["fld_lblTotalQty"];
                BOSLabel lbltotalBlock = (BOSLabel)Controls["fld_lblTotalBlock"];
                if (lbltotalQty != null || lbltotalBlock != null)
                    SetTotalQty(gridView, lbltotalQty, lbltotalBlock);
            }
        }
        public void SetMachineTotalQty()
        {
            if (PlanMachineUnitItemGridControl != null)
            {
                GridView gridView = PlanMachineUnitItemGridControl.MainView as GridView;
                BOSLabel lbltotalQty = (BOSLabel)Controls["fld_lblMachineTotalQty"];
                BOSLabel lbltotalBlock = (BOSLabel)Controls["fld_lblMachineTotalBlock"];
                if (lbltotalQty != null || lbltotalBlock != null)
                    SetTotalQty(gridView, lbltotalQty, lbltotalBlock);
            }
        }
        public void SetTotalQty(GridView gridView, BOSLabel lbltotalQty, BOSLabel lbltotalBlock)
        {

            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            List<object> filterList = new List<object>();
            decimal totalQty = 0;
            decimal totalBlock = 0;
            if (gridView != null)
            {
                filterList = (List<object>)gridView.DataController.GetAllFilteredAndSortedRows();
                if (filterList != null)
                    foreach (object obj in filterList)
                    {
                        MMOperationDetailPlanItemChildsInfo item = (MMOperationDetailPlanItemChildsInfo)obj;
                        if (item != null && item.Selected)
                        {
                            totalQty += item.MMOperationDetailPlanItemChildPlanProductQty;
                            totalBlock += item.MMOperationDetailPlanItemChildPlanBlock;
                        }
                    }
            }
            if (lbltotalQty != null)
                lbltotalQty.Text = totalQty.ToString("N2");
            if (lbltotalBlock != null)
                lbltotalBlock.Text = totalBlock.ToString("N4");
        }
        #endregion
        #endregion
        #region Utility
        public void DefaultWeek()
        {
            if (DetailPlanWeekBottunEditControl == null) return;
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;
            //if (objOperationDetailPlansInfo.MMOperationDetailPlanWeek.Trim().Equals(string.Empty))
            //objOperationDetailPlansInfo.MMOperationDetailPlanWeek = cal.GetWeekOfYear(DateTime.Now.AddDays(7), dfi.CalendarWeekRule, dfi.FirstDayOfWeek) .ToString();
            DetailPlanWeekBottunEditControl.Text = cal.GetWeekOfYear(DateTime.Now, dfi.CalendarWeekRule, dfi.FirstDayOfWeek).ToString();
            DateTime firtdate = BOSUtil.GetYearBeginDate();
            DateTime lastdate = BOSUtil.GetYearEndDate(DateTime.Now);
            List<WeekRange> rangeWeek = WeekDays(firtdate, lastdate);
            MMOperationDetailPlansInfo week;
            foreach (WeekRange item in rangeWeek)
            {
                week = new MMOperationDetailPlansInfo();
                if (DetailPlanWeekBottunEditControl.Text.Trim() == item.Week.ToString())
                {
                    if (item.StartDate.DayOfWeek == DayOfWeek.Sunday)
                        week.MMOperationDetailPlanFromDate = item.StartDate.AddDays(1);
                    else
                        week.MMOperationDetailPlanFromDate = item.StartDate;
                    if (FromDateLookupEditControl != null)
                        FromDateLookupEditControl.DateTime = new DateTime(week.MMOperationDetailPlanFromDate.Year
                            , week.MMOperationDetailPlanFromDate.Month, week.MMOperationDetailPlanFromDate.Day, 7, 30, 0);
                    if (SearchFromDateLookupEditControl != null)
                        SearchFromDateLookupEditControl.DateTime = new DateTime(week.MMOperationDetailPlanFromDate.Year
                            , week.MMOperationDetailPlanFromDate.Month, week.MMOperationDetailPlanFromDate.Day, 7, 30, 0);

                    if (item.EndDate.DayOfWeek == DayOfWeek.Sunday)
                        week.MMOperationDetailPlanToDate = item.EndDate.AddDays(-1);
                    else
                        week.MMOperationDetailPlanToDate = item.EndDate;

                    if (ToDateLookupEditControl != null)
                        ToDateLookupEditControl.DateTime = new DateTime(week.MMOperationDetailPlanToDate.Year
                            , week.MMOperationDetailPlanToDate.Month
                            , week.MMOperationDetailPlanToDate.Day, 17, 0, 0);
                    if (SearchToDateLookupEditControl != null)
                        SearchToDateLookupEditControl.DateTime = new DateTime(week.MMOperationDetailPlanToDate.Year
                            , week.MMOperationDetailPlanToDate.Month
                            , week.MMOperationDetailPlanToDate.Day, 17, 0, 0);
                }
            }
        }
        public void ShowChooseWeek()
        {
            if (DetailPlanWeekBottunEditControl == null) return;
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            // MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;
            #region Init data week of year
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;

            Calendar cal = dfi.Calendar;
            if (DetailPlanWeekBottunEditControl.Text.Trim().Equals(string.Empty))
                DetailPlanWeekBottunEditControl.Text = cal.GetWeekOfYear(DateTime.Now.AddDays(7), dfi.CalendarWeekRule, dfi.FirstDayOfWeek).ToString();
            DateTime firtdate = BOSUtil.GetYearBeginDate();
            DateTime lastdate = BOSUtil.GetYearEndDate(DateTime.Now);
            List<WeekRange> rangeWeek = WeekDays(firtdate, lastdate);
            MMOperationDetailPlansInfo week;
            entity.ListWeek.Clear();
            foreach (WeekRange item in rangeWeek)
            {
                week = new MMOperationDetailPlansInfo();
                week.MMOperationDetailPlanWeek = item.Week.ToString();
                if (item.StartDate.DayOfWeek == DayOfWeek.Sunday)
                    week.MMOperationDetailPlanFromDate = item.StartDate.AddDays(1);
                else
                    week.MMOperationDetailPlanFromDate = item.StartDate;
                if (item.EndDate.DayOfWeek == DayOfWeek.Sunday)
                    week.MMOperationDetailPlanToDate = item.EndDate.AddDays(-1);
                else
                    week.MMOperationDetailPlanToDate = item.EndDate;
                entity.ListWeek.Add(week);
            }
            #endregion
            guiChooseWeek guiChooseWeek = new guiChooseWeek();
            guiChooseWeek.PlanWeek = DetailPlanWeekBottunEditControl.Text.Trim();
            guiChooseWeek.Module = this;
            if (guiChooseWeek.ShowDialog() == DialogResult.OK)
            {
                DetailPlanWeekBottunEditControl.Text = guiChooseWeek.PlanWeek;
                if (FromDateLookupEditControl != null)
                    FromDateLookupEditControl.DateTime = new DateTime(guiChooseWeek.Fromdate.Year, guiChooseWeek.Fromdate.Month, guiChooseWeek.Fromdate.Day, 7, 30, 0);
                if (SearchFromDateLookupEditControl != null)
                    SearchFromDateLookupEditControl.DateTime = new DateTime(guiChooseWeek.Fromdate.Year, guiChooseWeek.Fromdate.Month, guiChooseWeek.Fromdate.Day, 7, 30, 0);

                if (ToDateLookupEditControl != null)
                    ToDateLookupEditControl.DateTime = new DateTime(guiChooseWeek.Todate.Year, guiChooseWeek.Todate.Month, guiChooseWeek.Todate.Day, 17, 0, 0);
                if (SearchToDateLookupEditControl != null)
                    SearchToDateLookupEditControl.DateTime = new DateTime(guiChooseWeek.Todate.Year, guiChooseWeek.Todate.Month, guiChooseWeek.Todate.Day, 17, 0, 0);

            }
        }
        public DataSet ChangeWorkShop(int workShopID)
        {
            DataSet ds = new DataSet();

            MMLinesController objLinesController = new MMLinesController();
            if (workShopID > 0)
            {
                ds = objLinesController.GetAllDataByForeignColumn("FK_MMWorkShopID", workShopID);
            }
            else
            {
                ds = objLinesController.GetAllObjects();
            }

            return ds;
        }
        public void ChangeWorkShopToItem(int workShopID)
        {
            if (MessageBox.Show("Bạn có muốn thay đổi xưởng cho sản phẩm không?", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
                MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;
                foreach (MMOperationDetailPlanItemChildsInfo item in entity.OperationDetailPlanItemChildsList)
                {
                    if (item.Selected)
                        item.FK_MMWorkShopID = workShopID;
                }
            }
        }
        public void ChangeLineToItem(int lineID)
        {
            if (MessageBox.Show("Bạn có muốn thay đổi chuyền cho sản phẩm không?", MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
                MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;
                foreach (MMOperationDetailPlanItemChildsInfo item in entity.OperationDetailPlanItemChildsList)
                {
                    if (item.Selected)
                        item.FK_MMLineID = lineID;
                }
            }
        }
        public void UpdateBatchPosition(int workShopID, int lineID, int groupID)
        {
            if (Toolbar.IsNullOrNoneAction()) ActionEdit();

            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;
            List<MMJobTicketItemsInfo> listJobTickets = new List<MMJobTicketItemsInfo>();
            if (objOperationDetailPlansInfo.MMOperationDetailPlanID == 0) objOperationDetailPlansInfo.MMOperationDetailPlanID = 1;
            if (objOperationDetailPlansInfo.MMOperationDetailPlanID > 0)
            {
                listJobTickets = (new MMJobTicketItemsController()).GetJobTicketItemByOperationPlan(objOperationDetailPlansInfo.MMOperationDetailPlanID);
                List<MMOperationDetailPlanItemChildsInfo> selectedList = entity.OperationDetailPlanItemChildsList.Where(o => o.Selected).ToList();
                if (selectedList == null || selectedList.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn chi tiết cập nhật!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (selectedList != null && listJobTickets != null)
                {
                    bool isError = false;
                    selectedList.ForEach(p =>
                    {
                        if (listJobTickets.Any(j => j.FK_MMOperationDetailPlanItemChildID == p.MMOperationDetailPlanItemChildID
                            && j.MMJobTicketItemStatus != Status.Canceled.ToString()))
                        {
                            p.IsError = true;
                            isError = true;

                        }
                    });
                    if (isError)
                        if (MessageBox.Show("Tồn tại chi tiết đã tạo thẻ bạn có muốn thay đổi không ?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return;
                        }
                }
            }
            foreach (MMOperationDetailPlanItemChildsInfo item in entity.OperationDetailPlanItemChildsList)
            {
                if (item.MMOperationDetailPlanItemChildID > 0 && listJobTickets != null && listJobTickets.Count > 0)
                {
                    MMJobTicketItemsInfo jobitem = listJobTickets.Where(o => o.FK_MMOperationDetailPlanItemChildID == item.MMOperationDetailPlanItemChildID).FirstOrDefault();
                    if (jobitem != null && jobitem.FK_MMOperationDetailPlanItemChildID > 0) continue;
                }
                if (item.Selected)
                {
                    item.FK_MMWorkShopID = workShopID;
                    item.FK_MMLineID = lineID;
                    //item.FK_HRDepartmentRoomGroupItemID = groupID;
                }
            }
            //entity.OperationDetailPlanItemChildsList.GridControl.RefreshDataSource();
            if (OperationPlanGridControl != null)
            {
                OperationPlanGridControl.DataSource = entity.OperationDetailPlanItemChildsList;
                OperationPlanGridControl.RefreshDataSource();
            }

        }
        public void UpdatePlanDate(DateTime fromDate, DateTime toDate)
        {
            if (Toolbar.IsNullOrNoneAction()) ActionEdit();

            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;
            List<MMJobTicketItemsInfo> listJobTickets = new List<MMJobTicketItemsInfo>();
            if (objOperationDetailPlansInfo.MMOperationDetailPlanID == 0) objOperationDetailPlansInfo.MMOperationDetailPlanID = 1;
            if (objOperationDetailPlansInfo.MMOperationDetailPlanID > 0)
            {
                listJobTickets = (new MMJobTicketItemsController()).GetJobTicketItemByOperationPlan(objOperationDetailPlansInfo.MMOperationDetailPlanID);
                List<MMOperationDetailPlanItemChildsInfo> selectedList = entity.OperationDetailPlanItemChildsList.Where(o => o.Selected).ToList();
                if (selectedList == null || selectedList.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn chi tiết cập nhật!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (selectedList != null && listJobTickets != null)
                {
                    bool isError = false;
                    selectedList.ForEach(p =>
                    {
                        if (listJobTickets.Any(j => j.FK_MMOperationDetailPlanItemChildID == p.MMOperationDetailPlanItemChildID
                          && j.MMJobTicketItemStatus != Status.Canceled.ToString()))
                        {
                            p.IsError = true;
                            isError = true;

                        }
                    });
                    if (isError)
                        if (MessageBox.Show("Tồn tại chi tiết đã tạo thẻ bạn có muốn thay đổi không ?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return;
                        }
                }

            }
            foreach (MMOperationDetailPlanItemChildsInfo item in entity.OperationDetailPlanItemChildsList)
            {
                if (item.MMOperationDetailPlanItemChildID > 0 && listJobTickets != null && listJobTickets.Count > 0)
                {
                    MMJobTicketItemsInfo jobitem = listJobTickets.Where(o => o.FK_MMOperationDetailPlanItemChildID == item.MMOperationDetailPlanItemChildID).FirstOrDefault();
                    if (jobitem != null && jobitem.FK_MMOperationDetailPlanItemChildID > 0) continue;
                }
                if (item.Selected)
                {
                    item.MMOperationDetailPlanItemChildExecutionFromDate = fromDate;
                    item.MMOperationDetailPlanItemChildExecutionToDate = toDate;
                }
            }
            if (OperationPlanGridControl != null)
            {
                OperationPlanGridControl.DataSource = entity.OperationDetailPlanItemChildsList;
                OperationPlanGridControl.RefreshDataSource();
            }

        }

        public List<MMOperationDetailPlanItemChildsInfo> GetSelectedList(GridView gridView)
        {

            List<MMOperationDetailPlanItemChildsInfo> listView = new List<MMOperationDetailPlanItemChildsInfo>();
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;

            List<MMOperationDetailPlanItemChildsInfo> objects = new List<MMOperationDetailPlanItemChildsInfo>();
            for (int j = 0; j < gridView.RowCount; j++)
            {
                MMOperationDetailPlanItemChildsInfo obj = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(j);
                if (obj != null && obj.Selected)
                {
                    objects.Add(obj);
                }
            }
            return objects;
        }
        public void ShowEditHuman(bool isView, MMOperationDetailPlanItemChildsInfo itemTicket)
        {
            if (Toolbar.IsNullOrNoneAction()) ActionEdit();
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;

            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;
            List<MMOperationDetailPlanItemChildsInfo> selectedList = new List<MMOperationDetailPlanItemChildsInfo>();
            if (itemTicket != null) selectedList.Add(itemTicket);

            else
            {
                MMOperationDetailPlanItemChildsGridControl fld_dgcPlanChildItems = (MMOperationDetailPlanItemChildsGridControl)Controls["fld_dgcMMOperationDetailPlanItemChilds"];
                if (fld_dgcPlanChildItems == null) return;
                GridView gridView = (GridView)fld_dgcPlanChildItems.MainView;
                selectedList = GetSelectedList(gridView);
            }
            if (selectedList == null || selectedList.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chi tiết!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (selectedList != null)
            {
                bool isError = false;
                selectedList.ForEach(p =>
                {
                    if (p.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.Closed.ToString() || p.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.Canceled.ToString())
                    {
                        p.IsError = true;
                        isError = true;
                    }
                });
                if (isError)
                    BOSApp.ShowMessage("Tồn tại chi tiết có trạng thái không phù hợp!");
                else
                {
                    guiEditHuman guiEditHuman = new guiEditHuman();
                    guiEditHuman.Module = this;
                    guiEditHuman.HumanDetailPlanItemsList = selectedList;
                    if (guiEditHuman.ShowDialog() == DialogResult.OK)
                    {
                        foreach (MMOperationDetailPlanItemChildsInfo ticketRow in guiEditHuman.HumanDetailPlanItemsList)
                        {
                            MMOperationDetailPlanItemChildsInfo item = entity.HumanDetailPlanItemsList.Where(o => o.MMOperationDetailPlanItemChildID == ticketRow.MMOperationDetailPlanItemChildID
                                                                                                                && o.FK_MMBatchProductProductionNormItemID == ticketRow.FK_MMBatchProductProductionNormItemID
                                                                                                                && o.FK_MMOperationID == ticketRow.FK_MMOperationID
                                                                                                                && o.MMOperationDetailPlanItemChildAbstract == ticketRow.MMOperationDetailPlanItemChildAbstract
                                                                                                                ).FirstOrDefault();
                            item.HumanFocusedList = ticketRow.HumanFocusedList;
                            item.Employee = item.HumanFocusedList.Count;

                            MMOperationDetailPlanItemChildsInfo itemDTicket = entity.TicketDetailPlanItemsList.Where(o => o.MMOperationDetailPlanItemChildID == ticketRow.MMOperationDetailPlanItemChildID
                                                                                                                && o.FK_MMBatchProductProductionNormItemID == ticketRow.FK_MMBatchProductProductionNormItemID
                                                                                                                && o.FK_MMOperationID == ticketRow.FK_MMOperationID
                                                                                                                && o.MMOperationDetailPlanItemChildAbstract == ticketRow.MMOperationDetailPlanItemChildAbstract
                                                                                                                ).FirstOrDefault();
                            if (itemDTicket == null)
                                itemDTicket = new MMOperationDetailPlanItemChildsInfo();

                            itemDTicket.HumanFocusedList = ticketRow.HumanFocusedList;
                            itemDTicket.Employee = itemDTicket.HumanFocusedList.Count;

                            MMOperationDetailPlanItemChildsInfo itemPlan = entity.OperationDetailPlanItemChildsList.Where(o => o.MMOperationDetailPlanItemChildID == ticketRow.MMOperationDetailPlanItemChildID
                                                                                                               && o.FK_MMBatchProductProductionNormItemID == ticketRow.FK_MMBatchProductProductionNormItemID
                                                                                                               && o.FK_MMOperationID == ticketRow.FK_MMOperationID
                                                                                                               && o.MMOperationDetailPlanItemChildAbstract == ticketRow.MMOperationDetailPlanItemChildAbstract
                                                                                                               ).FirstOrDefault();
                            itemPlan.HumanFocusedList = ticketRow.HumanFocusedList;
                            itemPlan.Employee = itemPlan.HumanFocusedList.Count;
                        }

                        entity.OperationDetailPlanItemChildsList.GridControl?.RefreshDataSource();
                        if (itemTicket != null)
                            entity.TicketDetailPlanItemsList.GridControl?.RefreshDataSource();
                    }
                }
            }
        }
        public void ShowTicketEditHuman(bool isView, MMOperationDetailPlanItemChildsInfo itemTicket)
        {
            //if (Toolbar.IsNullOrNoneAction()) ActionEdit();
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;

            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;
            List<MMOperationDetailPlanItemChildsInfo> selectedList = new List<MMOperationDetailPlanItemChildsInfo>();
            if (itemTicket != null) selectedList.Add(itemTicket);
            else
            {
                MMTicketPlanItemsGridControl fld_dgcPlanChildItems = (MMTicketPlanItemsGridControl)Controls["fld_dgcMMTicketPlanItems"];
                if (fld_dgcPlanChildItems == null) return;
                GridView gridView = (GridView)fld_dgcPlanChildItems.MainView;
                selectedList = GetSelectedList(gridView);
            }
            if (selectedList == null || selectedList.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chi tiết!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (selectedList != null)
            {
                bool isError = false;
                selectedList.ForEach(p =>
                {
                    if (p.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.Closed.ToString() || p.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.Canceled.ToString())
                    {
                        p.IsError = true;
                        isError = true;
                    }
                });
                if (isError)
                    BOSApp.ShowMessage("Tồn tại chi tiết có trạng thái không phù hợp!");
                else
                {
                    guiEditHuman guiEditHuman = new guiEditHuman();
                    guiEditHuman.Module = this;
                    guiEditHuman.HumanDetailPlanItemsList = selectedList;
                    if (guiEditHuman.ShowDialog() == DialogResult.OK)
                    {
                        foreach (MMOperationDetailPlanItemChildsInfo ticketRow in guiEditHuman.HumanDetailPlanItemsList)
                        {
                            MMOperationDetailPlanItemChildsInfo itemDTicket = entity.TicketDetailPlanItemsList.Where(o => o.MMOperationDetailPlanItemChildID == ticketRow.MMOperationDetailPlanItemChildID
                                                                                                                && o.FK_MMBatchProductProductionNormItemID == ticketRow.FK_MMBatchProductProductionNormItemID
                                                                                                                && o.FK_MMOperationID == ticketRow.FK_MMOperationID
                                                                                                                && o.MMOperationDetailPlanItemChildAbstract == ticketRow.MMOperationDetailPlanItemChildAbstract
                                                                                                                ).FirstOrDefault();
                            if (itemDTicket == null)
                                itemDTicket = new MMOperationDetailPlanItemChildsInfo();

                            itemDTicket.HumanFocusedList = ticketRow.HumanFocusedList;
                            itemDTicket.HumanFocusedList.ForEach(h =>
                            {
                                h.FK_MMOperationDetailPlanItemChildID = itemDTicket.MMOperationDetailPlanItemChildID;
                            });
                            itemDTicket.Employee = itemDTicket.HumanFocusedList.Count;
                        }
                        entity.TicketDetailPlanItemsList.GridControl?.RefreshDataSource();

                    }
                }
            }
        }
        public void ShowEditMachine(bool isView)
        {
            if (Toolbar.IsNullOrNoneAction()) ActionEdit();
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;

            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;
            MMOperationDetailPlanItemChildsGridControl fld_dgcPlanChildItems = (MMOperationDetailPlanItemChildsGridControl)Controls["fld_dgcMMOperationDetailPlanItemChilds"];
            if (fld_dgcPlanChildItems == null) return;
            GridView gridView = (GridView)fld_dgcPlanChildItems.MainView;

            List<MMOperationDetailPlanItemChildsInfo> selectedList = GetSelectedList(gridView);
            if (selectedList == null || selectedList.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chi tiết!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (selectedList != null)
            {
                bool isError = false;
                selectedList.ForEach(p =>
                {
                    if (p.MMOperationDetailPlanItemChildStatus != Status.New.ToString())
                    {
                        p.IsError = true;
                        isError = true;
                    }
                });
                if (isError)
                    BOSApp.ShowMessage("Tồn tại chi tiết có trạng thái không phù hợp!");
                else
                {
                    guiEditMachine guiEditMachine = new guiEditMachine();
                    guiEditMachine.Module = this;
                    guiEditMachine.MachineDetailPlanItemsList = selectedList;
                    if (guiEditMachine.ShowDialog() == DialogResult.OK)
                    {
                        foreach (MMOperationDetailPlanItemChildsInfo ticketRow in guiEditMachine.MachineDetailPlanItemsList)
                        {
                            MMOperationDetailPlanItemChildsInfo item = entity.MachineDetailPlanItemsList.Where(o => o.MMOperationDetailPlanItemChildID == ticketRow.MMOperationDetailPlanItemChildID
                                                                                                                && o.FK_MMBatchProductProductionNormItemID == ticketRow.FK_MMBatchProductProductionNormItemID
                                                                                                                && o.FK_MMOperationID == ticketRow.FK_MMOperationID
                                                                                                                && o.MMOperationDetailPlanItemChildAbstract == ticketRow.MMOperationDetailPlanItemChildAbstract
                                                                                                                ).FirstOrDefault();
                            item.MachineFocusedList = ticketRow.MachineFocusedList;
                            item.Machine = item.MachineFocusedList.Count;
                            item.MachineDetail = item.MachineFocusedList != null ? (string.Join(";", item.MachineFocusedList.Select(m => m.MMMachineUnitName).Distinct().ToArray())) : string.Empty;
                            MMOperationDetailPlanItemChildsInfo itemPlan = entity.OperationDetailPlanItemChildsList.Where(o => o.MMOperationDetailPlanItemChildID == ticketRow.MMOperationDetailPlanItemChildID
                                                                                                               && o.FK_MMBatchProductProductionNormItemID == ticketRow.FK_MMBatchProductProductionNormItemID
                                                                                                               && o.FK_MMOperationID == ticketRow.FK_MMOperationID
                                                                                                               && o.MMOperationDetailPlanItemChildAbstract == ticketRow.MMOperationDetailPlanItemChildAbstract
                                                                                                               ).FirstOrDefault();
                            itemPlan.MachineFocusedList = ticketRow.MachineFocusedList;
                            itemPlan.Machine = item.MachineFocusedList.Count;
                            itemPlan.MachineDetail = itemPlan.MachineFocusedList != null ? string.Join(";", itemPlan.MachineFocusedList.Select(m => m.MMMachineUnitName).Distinct().ToArray()) : string.Empty;
                            UpdatePlanMachineCapacity(itemPlan);
                        }

                        entity.OperationDetailPlanItemChildsList.GridControl?.RefreshDataSource();
                    }
                }
            }
        }
        public void ShowDataEmployee(MMOperationDetailPlanItemChildsInfo selected, bool isView)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            guiSearchEmployee guiSearchEmployee = new guiSearchEmployee();
            guiSearchEmployee.Module = this;
            if (selected.HumanFocusedList != null && selected.HumanFocusedList.Count > 0)
                guiSearchEmployee.TicketEmployeeList = selected.HumanFocusedList;
            else
                guiSearchEmployee.TicketEmployeeList =
                     entity.HumanUnitList.Where(ep => ep.MMDetailPlanHumanUnitAbstract == selected.MMOperationDetailPlanItemChildAbstract
                                                         && ep.FK_MMOperationID == selected.FK_MMOperationID
                                                         && ep.FK_MMOperationDetailPlanItemChildID == selected.MMOperationDetailPlanItemChildID).ToList();
            if (guiSearchEmployee.TicketEmployeeList == null || guiSearchEmployee.TicketEmployeeList.Count == 0)
            {
                BOSApp.ShowMessage("Công việc chưa gán cho nhân viên!");
                return;
            }
            if (guiSearchEmployee.ShowDialog() == DialogResult.OK && !isView)
            {
                selected.HumanFocusedList = guiSearchEmployee.TicketEmployeeSelectedList.Where(o => o.Selected).ToList();
                selected.Employee = selected.HumanFocusedList != null ? selected.HumanFocusedList.Count : 0;
                MMOperationDetailPlanItemChildsInfo item = entity.HumanDetailPlanItemsList.Where(o => o.MMOperationDetailPlanItemChildID == selected.MMOperationDetailPlanItemChildID
                                                                                                                && o.FK_MMBatchProductProductionNormItemID == selected.FK_MMBatchProductProductionNormItemID
                                                                                                                && o.FK_MMOperationID == selected.FK_MMOperationID
                                                                                                                && o.MMOperationDetailPlanItemChildAbstract == selected.MMOperationDetailPlanItemChildAbstract
                                                                                                                ).FirstOrDefault();
                if (item != null)
                    item.HumanFocusedList = selected.HumanFocusedList;

            }

        }
        public void ShowDataMachine(MMOperationDetailPlanItemChildsInfo selected, bool isView)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            guiSearchMachine guiSearchMachine = new guiSearchMachine();
            guiSearchMachine.Module = this;
            if (selected.MachineFocusedList != null && selected.MachineFocusedList.Count > 0)
                guiSearchMachine.TicketMachineList = selected.MachineFocusedList;
            else
                guiSearchMachine.TicketMachineList =
                entity.MachineUnitList.Where(ep => ep.MMDetailPlanMachineUnitAbstract == selected.MMOperationDetailPlanItemChildAbstract
                                                    && ep.FK_MMOperationID == selected.FK_MMOperationID
                                                    && ep.FK_MMOperationDetailPlanItemChildID == selected.MMOperationDetailPlanItemChildID).ToList();
            if (guiSearchMachine.TicketMachineList == null || guiSearchMachine.TicketMachineList.Count == 0)
            {
                BOSApp.ShowMessage("Công việc chưa gán cho máy!");
                return;
            }
            if (guiSearchMachine.ShowDialog() == DialogResult.OK && !isView)
            {
                selected.MachineFocusedList = guiSearchMachine.TicketMachineSelectedList.Where(o => o.Selected).ToList();
                selected.Machine = selected.MachineFocusedList != null ? selected.MachineFocusedList.Count : 0;
                selected.MachineDetail = selected.MachineFocusedList != null ? (string.Join(";", selected.MachineFocusedList.Select(m => m.MMMachineUnitName).Distinct().ToArray())) : string.Empty;
                MMOperationDetailPlanItemChildsInfo item = entity.MachineDetailPlanItemsList.Where(o => o.MMOperationDetailPlanItemChildID == selected.MMOperationDetailPlanItemChildID
                                                                                                                && o.FK_MMBatchProductProductionNormItemID == selected.FK_MMBatchProductProductionNormItemID
                                                                                                                && o.FK_MMOperationID == selected.FK_MMOperationID
                                                                                                                && o.MMOperationDetailPlanItemChildAbstract == selected.MMOperationDetailPlanItemChildAbstract
                                                                                                                ).FirstOrDefault();
                if (item != null)
                    item.MachineFocusedList = selected.MachineFocusedList;
            }

        }
        #endregion
        #region Event
        void LineLookupEditControl_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;

            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;
            if (objOperationDetailPlansInfo != null)
            {
                DataSet ds = ChangeWorkShop(objOperationDetailPlansInfo.FK_MMWorkShopID);

                if (ds != null && ds.Tables != null)
                {
                    lookup.Properties.DataSource = ds.Tables[0];
                }
            }
        }

        #endregion
        #region Operation Data
        public void InitDataSourceOperations()
        {
            MMOperationsController operationController = new MMOperationsController();
            OperationData = operationController.GetAllOperationsByOperationGroup(ProductType.Product.ToString());
        }
        public void InitDataSourceSearchOperations()
        {
            MMOperationsController operationController = new MMOperationsController();
            if (BOSApp.LookupTables.ContainsKey("MMOperations"))
            {
                DataSet ds = (DataSet)BOSApp.LookupTables["MMOperations"];
                if (ds != null && ds.Tables.Count > 0)
                    if (fld_cmbOperations != null) fld_cmbOperations.Properties.DataSource = ds.Tables[0];
                if (fld_cmbOperationsSearch != null) fld_cmbOperationsSearch.Properties.DataSource = ds.Tables[0];
            }
        }
        public void InitEditComboBoxOperationValue()
        {

            List<string> opID = new List<string>();
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            if (entity.OperationDetailPlanItemChildsList != null)
                opID = entity.OperationDetailPlanItemChildsList.Select(o => o.FK_MMOperationID.ToString()).Distinct().ToList();
            if (OperationData != null && opID != null && opID.Count > 0)
            {
                OperationHumanSelect.Clear();
                OperationMachineSelect.Clear();

                foreach (var item in opID)
                {
                    OperationData.ForEach(op =>
                    {
                        if (op.MMOperationID.ToString() == item)
                        {
                            OperationHumanSelect.Add((MMOperationsInfo)op.Clone());
                            OperationMachineSelect.Add((MMOperationsInfo)op.Clone());
                            if (op.MMOperationParentID > 0)
                            {
                                MMOperationsInfo parent = OperationData.Where(o => o.MMOperationID == op.MMOperationParentID).FirstOrDefault();
                                if (parent != null)
                                {
                                    int index = OperationHumanSelect.IndexOf(parent);
                                    if (index < 0) OperationHumanSelect.Add(parent);
                                    index = OperationMachineSelect.IndexOf(parent);
                                    if (index < 0) OperationMachineSelect.Add(parent);
                                }
                            }

                        }
                    });
                }
                string mess = OperationHumanSelect != null ? string.Join(",", OperationHumanSelect.Select(o => o.MMOperationName).Distinct().ToArray()) : string.Empty;
                if (HumanOperationComBo != null) HumanOperationComBo.EditValue = mess;
                if (MachineOperationComBo != null) MachineOperationComBo.EditValue = mess;

            }
        }

        public void ShowOperation(bool isHuman, bool isTicket)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            List<string> opID = new List<string>();

            guiChooseOperation guiOperation = new guiChooseOperation();
            guiOperation.OperationItemDataList = OperationData;
            guiOperation.OperationDataSelected = isHuman ? OperationHumanSelect : !isTicket ? OperationMachineSelect : OperationTicketSelect;
            guiOperation.Module = this;
            guiOperation.ShowDialog();
            if (guiOperation.DialogResult == DialogResult.OK)
            {
                string mess = string.Empty;
                if (isHuman)
                {
                    OperationHumanSelect = guiOperation.ResultList;
                    mess = OperationHumanSelect != null ? string.Join(",", OperationHumanSelect.Select(o => o.MMOperationName).Distinct().ToArray()) : string.Empty;
                    if (HumanOperationComBo != null) HumanOperationComBo.EditValue = mess;
                }
                else if (!isTicket)
                {
                    OperationMachineSelect = guiOperation.ResultList;
                    mess = OperationHumanSelect != null ? string.Join(",", OperationHumanSelect.Select(o => o.MMOperationName).Distinct().ToArray()) : string.Empty;
                    if (MachineOperationComBo != null) MachineOperationComBo.EditValue = mess;
                }
                else
                {
                    OperationTicketSelect = guiOperation.ResultList;
                    mess = OperationTicketSelect != null ? string.Join(",", OperationTicketSelect.Select(o => o.MMOperationName).Distinct().ToArray()) : string.Empty;
                    if (MachineOperationComBo != null) MachineOperationComBo.EditValue = mess;
                    FilterTicketGrid(TicketRemainCheckBox.Checked, SelectedTicketHuman, SelectedTicketMachine, false, OperationTicketSelect);
                }
            }
        }
        #endregion
        #region Week nummber
        public List<WeekRange> WeekDays(DateTime startDate, DateTime endDate)
        {
            DateTime startDateToCheck = startDate;
            DateTime dateToCheck = startDate;
            DateTime dateRangeBegin = dateToCheck;
            DateTime dateRangeEnd = endDate;

            List<WeekRange> weekRangeList = new List<WeekRange>();
            WeekRange weekRange = new WeekRange();

            int week = 0;
            while (dateToCheck <= endDate)
            {
                week = week + 1;
                dateRangeBegin = new DateTime(dateToCheck.Year, dateToCheck.Month, dateToCheck.Day);
                DateTime dateWeekEnd = new DateTime(dateToCheck.Year, dateToCheck.Month, dateToCheck.Day);
                dateRangeEnd = dateWeekEnd.AddDays(6);
                weekRange = new WeekRange
                {
                    StartDate = dateRangeBegin,
                    EndDate = dateRangeEnd,
                    Range = dateRangeBegin.Date.ToShortDateString() + '-' + dateRangeEnd.Date.ToShortDateString(),
                    Month = dateToCheck.Month,
                    Year = dateToCheck.Year,
                    Week = week
                };
                weekRangeList.Add(weekRange);
                dateToCheck = dateToCheck.AddDays(7);
            }
            return weekRangeList;
        }
        public void GetPlanDateByWeek(string weekText)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
                MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;
                if (objOperationDetailPlansInfo.MMOperationDetailPlanWeek != weekText)
                {
                    int week = 0;
                    if (!int.TryParse(weekText, out week) || week > 53 || week < 0)
                    {
                        MessageBox.Show("Giá trị tuần không hợp lệ!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                DateTime firtdate = BOSUtil.GetYearBeginDate();
                DateTime lastdate = BOSUtil.GetYearEndDate(DateTime.Now);
                List<WeekRange> rangeWeek = WeekDays(firtdate, lastdate);
                foreach (WeekRange item in rangeWeek)
                {
                    if (weekText == item.Week.ToString())
                    {
                        if (item.StartDate.DayOfWeek == DayOfWeek.Sunday)
                            objOperationDetailPlansInfo.MMOperationDetailPlanFromDate = item.StartDate.AddDays(1);
                        else
                            objOperationDetailPlansInfo.MMOperationDetailPlanFromDate = item.StartDate;
                        if (item.EndDate.DayOfWeek == DayOfWeek.Sunday)
                            objOperationDetailPlansInfo.MMOperationDetailPlanToDate = item.EndDate.AddDays(-1);
                        else
                            objOperationDetailPlansInfo.MMOperationDetailPlanToDate = item.EndDate;
                        entity.UpdateMainObjectBindingSource();
                        break;
                    }
                }
            }
        }
        #endregion
        #region TreeList

        public void GetTreeHumanDataSource(bool notJetTicket, string operationList, int deparment)
        {
            if (HumanUnitTreeListControl != null)
            {
                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
                List<MMDetailPlanHumanUnitsInfo> HumanUnitList = GetHumanFromTicketDetailPlan();
                HumanUnitTreeListControl.GetTreeDataSource(deparment, 0, operationList);
                if (HumanUnitTreeListControl.RoomGroupItemDataList != null && HumanUnitTreeListControl.RoomGroupItemDataList.Count > 0)
                {
                    if (!notJetTicket)
                        HumanUnitTreeListControl.RoomGroupItemDataList = HumanUnitTreeListControl.RoomGroupItemDataList.Where(o =>
                        HumanUnitList.Any(h => h.FK_HREmployeeID == o.HREmployeeID)
                        || (o.HREmployeeID == 0)
                        ).ToList();
                    else
                        HumanUnitTreeListControl.RoomGroupItemDataList = HumanUnitTreeListControl.RoomGroupItemDataList.Where(o =>
                            !HumanUnitList.Any(h => (h.FK_HREmployeeID == o.HREmployeeID))).ToList();
                }
                HumanUnitTreeListControl.bindingListSource = new BindingList<HRDepartmentRoomGroupItemsInfo>();
                if (HumanUnitTreeListControl.RoomGroupItemDataList != null)
                    HumanUnitTreeListControl.RoomGroupItemDataList.ForEach(o => HumanUnitTreeListControl.bindingListSource.Add(o));
                HumanUnitTreeListControl.DataSource = HumanUnitTreeListControl.bindingListSource;
                HumanUnitTreeListControl.RefreshDataSource();
                //HumanUnitTreeListControl.ExpandAll();
            }
        }
        public void GetTreeMachineDataSource(bool notJetTicket, string operationList, int workShopID)
        {
            if (MachineUnitTreeListControl != null)
            {
                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
                MachineUnitTreeListControl.GetTreeDataSource(workShopID, 0, operationList, string.Empty);
                List<MMDetailPlanMachineUnitsInfo> MachineUnitList = GetMachineFromTicketDetailPlan();
                if (MachineUnitTreeListControl.MachineGroupItemDataList != null && MachineUnitTreeListControl.MachineGroupItemDataList.Count > 0)
                    if (!notJetTicket)
                        MachineUnitTreeListControl.MachineGroupItemDataList = MachineUnitTreeListControl.MachineGroupItemDataList.Where(o =>
                        MachineUnitList.Any(h => h.FK_ACAssetID == o.FK_ACAssetID)
                        || (o.FK_ACAssetID == 0)).ToList();
                    else
                        MachineUnitTreeListControl.MachineGroupItemDataList = MachineUnitTreeListControl.MachineGroupItemDataList.Where(o =>
                            !MachineUnitList.Any(h => (h.FK_ACAssetID == o.FK_ACAssetID))).ToList();
                MachineUnitTreeListControl.bindingListSource = new BindingList<MMMachineUnitsInfo>();
                if (MachineUnitTreeListControl.MachineGroupItemDataList != null)
                {
                    MachineUnitTreeListControl.MachineGroupItemDataList.ForEach(o => MachineUnitTreeListControl.bindingListSource.Add(o));
                    MachineUnitTreeListControl.DataSource = MachineUnitTreeListControl.bindingListSource;
                }
                MachineUnitTreeListControl.RefreshDataSource();
                //MachineUnitTreeListControl.ExpandAll();
            }
        }
        public List<MMDetailPlanHumanUnitsInfo> GetHumanFromTicketDetailPlan()
        {
            List<MMDetailPlanHumanUnitsInfo> HumanUnitList = new List<MMDetailPlanHumanUnitsInfo>();
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            foreach (MMOperationDetailPlanItemChildsInfo item in entity.HumanDetailPlanItemsList)
            {
                if (item.HumanFocusedList != null && item.HumanFocusedList.Count > 0)
                {
                    item.HumanFocusedList.ForEach(o =>
                    {
                        MMDetailPlanHumanUnitsInfo found = HumanUnitList.Where(h => h.FK_HREmployeeID == o.FK_HREmployeeID ||
                        (o.FK_HREmployeeID == 0 && o.FK_HRDepartmentRoomGroupItemID == h.FK_HRDepartmentRoomGroupItemID)).FirstOrDefault();
                        if (found == null || found.FK_HRDepartmentRoomGroupItemID == 0)
                            HumanUnitList.Add((MMDetailPlanHumanUnitsInfo)o.Clone());
                    });
                }
            }
            return HumanUnitList;
        }
        public List<MMDetailPlanMachineUnitsInfo> GetMachineFromTicketDetailPlan()
        {
            List<MMDetailPlanMachineUnitsInfo> MachineUnitList = new List<MMDetailPlanMachineUnitsInfo>();
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            foreach (MMOperationDetailPlanItemChildsInfo item in entity.HumanDetailPlanItemsList)
            {
                if (item.MachineFocusedList != null && item.MachineFocusedList.Count > 0)
                {
                    item.MachineFocusedList.ForEach(o =>
                    {
                        MMDetailPlanMachineUnitsInfo found = MachineUnitList.Where(h => h.FK_ACAssetID == o.FK_ACAssetID ||
                        (o.FK_ACAssetID == 0 && o.FK_MMMachineUnitID == h.FK_MMMachineUnitID)).FirstOrDefault();
                        if (found == null || found.FK_MMMachineUnitID == 0)
                            MachineUnitList.Add((MMDetailPlanMachineUnitsInfo)o.Clone());
                    });
                }
            }
            return MachineUnitList;
        }

        public bool IsFocusHumanChange { get; set; }

        public void InvalidateHumanPlanByNoteChange()
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            List<HRDepartmentRoomGroupItemsInfo> selectedHuman = GetHumanSelectedNote();
            //if choose human in list have job
            IsFocusHumanChange = true;
            if (CheckExitTicketOfHuman(selectedHuman))
            {
                TicketNotHaveHuman.Checked = false;
                TicketHaveHuman.Checked = true;
                TicketHumanByOperation.Checked = true;
            }
            else
            {
                TicketNotHaveHuman.Checked = true;
                TicketHaveHuman.Checked = false;
                TicketHumanByOperation.Checked = true;
            }

            bool checkDetailPlanHumanAllowcation = TicketNotHaveHuman.Checked;
            bool checkAllHumanDetailPlanItem = TicketHaveHuman.Checked;
            bool checkHumanPlanByOperation = TicketHumanByOperation.Checked;

            List<string> OpIDList = GetOperationOfHuman(selectedHuman);
            string operationID = OpIDList != null ? string.Join(",", OpIDList.ToArray()) : string.Join(",", OperationHumanSelect.Select(o => o.MMOperationID.ToString()).Distinct().ToArray());
            if (PlanHumanUnitItemGridControl != null) PlanHumanUnitItemGridControl.IsEdit = false;
            FilterDetailPlanHumanGrid(checkDetailPlanHumanAllowcation, checkAllHumanDetailPlanItem, checkHumanPlanByOperation, operationID, selectedHuman);
            IsFocusHumanChange = false;
        }
        public List<string> GetOperationOfHuman(List<HRDepartmentRoomGroupItemsInfo> selectedHuman)
        {
            List<string> result = new List<string>();
            foreach (HRDepartmentRoomGroupItemsInfo item in selectedHuman)
            {
                string[] listID = item.MMOperationListID.Split(',');
                if (listID != null && listID.Length > 0)
                {
                    result.AddRange(listID.ToList());
                }
            }
            if (result != null) result = result.Select(o => o).Distinct().ToList();
            return result;
        }
        public List<string> GetOperationOfMachine(List<MMMachineUnitsInfo> selectedMachine)
        {
            List<string> result = new List<string>();
            foreach (MMMachineUnitsInfo item in selectedMachine)
            {
                string[] listID = item.MMOperationListID.Split(',');
                if (listID != null && listID.Length > 0)
                {
                    result.AddRange(listID.ToList());
                }
            }
            if (result != null) result = result.Select(o => o).Distinct().ToList();
            return result;
        }
        public bool CheckExitTicketOfHuman(List<HRDepartmentRoomGroupItemsInfo> selectedHuman)
        {
            bool result = false;
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            foreach (HRDepartmentRoomGroupItemsInfo item in selectedHuman)
            {
                if (item.HREmployeeID > 0)
                    foreach (MMOperationDetailPlanItemChildsInfo o in entity.HumanDetailPlanItemsList)
                    {
                        if (o.HumanFocusedList != null && o.HumanFocusedList.Count > 0)
                        {
                            result = o.HumanFocusedList.Any(f => f.FK_HREmployeeID == item.HREmployeeID);
                            if (result) break;
                        }
                    }
                if (result) break;
            }
            return result;
        }
        public bool IsFocusMachineChange { get; set; }
        public void InvalidateMachinePlanByNoteChange()
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            List<MMMachineUnitsInfo> selectedMachine = GetMachineSelectedNote();
            IsFocusMachineChange = true;
            //if choose human in list have job
            if (CheckExitTicketOfMachine(selectedMachine))
            {
                TicketNothaveMachine.Checked = false;
                TicketHaveMachine.Checked = true;
                TicketByOperation.Checked = true;
            }
            else
            {
                TicketNothaveMachine.Checked = true;
                TicketHaveMachine.Checked = false;
                TicketByOperation.Checked = true;
            }

            bool checkNothaveMachine = TicketNothaveMachine.Checked;
            bool checkTicketHaveMachine = TicketHaveMachine.Checked;
            bool checkMachinePlanByOperation = TicketByOperation.Checked;
            int workShopID = 0;
            if (MachineWorshopControl.EditValue != null)
                int.TryParse(MachineWorshopControl.EditValue.ToString(), out workShopID);
            List<string> OpIDList = GetOperationOfMachine(selectedMachine);
            string operationID = OpIDList != null ? string.Join(",", OpIDList.ToArray()) : string.Join(",", OperationMachineSelect.Select(o => o.MMOperationID.ToString()).Distinct().ToArray());
            if (PlanMachineUnitItemGridControl != null) PlanHumanUnitItemGridControl.IsEdit = false;
            FilterDetailPlanMachineGrid(checkNothaveMachine, checkTicketHaveMachine, checkMachinePlanByOperation, operationID, workShopID, selectedMachine);
            IsFocusMachineChange = false;

        }
        public bool CheckExitTicketOfMachine(List<MMMachineUnitsInfo> selectedMachine)
        {
            bool result = false;
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            foreach (MMMachineUnitsInfo item in selectedMachine)
            {
                if (item.FK_ACAssetID > 0)
                    foreach (MMOperationDetailPlanItemChildsInfo o in entity.MachineDetailPlanItemsList)
                    {
                        if (o.MachineFocusedList != null && o.MachineFocusedList.Count > 0)
                        {
                            result = o.MachineFocusedList.Any(f => f.FK_ACAssetID == item.FK_ACAssetID);
                            if (result) break;
                        }
                    }
                if (result) break;
            }
            return result;
        }
        public void ChangeHumanSelectNote(HRDepartmentRoomGroupItemsInfo childNote, bool value)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;

            if (entity.HumanDetailPlanItemsList != null && entity.HumanDetailPlanItemsList.Count > 0 && childNote.HREmployeeID > 0)
            {
                if (PlanHumanUnitItemGridControl != null)
                {
                    GridView gridView = (GridView)PlanHumanUnitItemGridControl.MainView;
                    if (gridView != null && gridView.RowCount > 0)
                        entity.HumanDetailPlanItemsList.ForEach(hu =>
                        {
                            if (entity.HumanUnitList != null && entity.HumanUnitList.Count > 0)
                            {
                                List<MMDetailPlanHumanUnitsInfo> focusHumanUnit = entity.HumanUnitList.Where(h => h.FK_HREmployeeID == childNote.HREmployeeID).ToList();

                                if (value && focusHumanUnit != null && focusHumanUnit.Count > 0)
                                {
                                    for (int j = 0; j < gridView.RowCount; j++)
                                    {
                                        MMOperationDetailPlanItemChildsInfo ticketRow = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(j);
                                        if (ticketRow != null)
                                        {
                                            MMDetailPlanHumanUnitsInfo existInView = focusHumanUnit.Where(o => o.FK_MMOperationDetailPlanItemChildID == ticketRow.MMOperationDetailPlanItemChildID
                                            && o.MMDetailPlanHumanUnitAbstract == ticketRow.MMOperationDetailPlanItemChildAbstract
                                            && o.FK_MMOperationID == ticketRow.FK_MMOperationID).FirstOrDefault();
                                            if (existInView != null && existInView.FK_MMBatchProductProductionNormItemID > 0)
                                                ticketRow.Selected = value;

                                        }
                                    }
                                }
                                else
                                {
                                    // no thing        
                                }
                            }
                        });
                }
            }
        }
        public void ChangeMachineSelectNote(MMMachineUnitsInfo childNote, bool value)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;

            if (entity.MachineDetailPlanItemsList != null && entity.MachineDetailPlanItemsList.Count > 0 && childNote.FK_ACAssetID > 0)
            {
                if (PlanMachineUnitItemGridControl != null)
                {
                    GridView gridView = (GridView)PlanMachineUnitItemGridControl.MainView;
                    if (gridView != null && gridView.RowCount > 0)
                        entity.MachineDetailPlanItemsList.ForEach(hu =>
                        {
                            if (entity.MachineUnitList != null && entity.MachineUnitList.Count > 0)
                            {
                                List<MMDetailPlanMachineUnitsInfo> focusMachineUnit = entity.MachineUnitList.Where(h => h.FK_ACAssetID == childNote.FK_ACAssetID).ToList();

                                if (value && focusMachineUnit != null && focusMachineUnit.Count > 0)
                                {
                                    for (int j = 0; j < gridView.RowCount; j++)
                                    {
                                        MMOperationDetailPlanItemChildsInfo ticketRow = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(j);
                                        if (ticketRow != null)
                                        {
                                            MMDetailPlanMachineUnitsInfo existInView = focusMachineUnit.Where(o => o.FK_MMOperationDetailPlanItemChildID == ticketRow.MMOperationDetailPlanItemChildID
                                            && o.MMDetailPlanMachineUnitAbstract == ticketRow.MMOperationDetailPlanItemChildAbstract
                                            && o.FK_MMOperationID == ticketRow.FK_MMOperationID).FirstOrDefault();
                                            if (existInView != null && existInView.FK_MMBatchProductProductionNormItemID > 0)
                                                ticketRow.Selected = value;

                                        }
                                    }
                                }
                                else
                                {
                                    // no thing        
                                }
                            }
                        });
                }
            }
        }
        #endregion
        #region Equipment
        public void ShowRegisttrationPlandata(MMDetailPlanEquipmentsInfo obj)
        {
            BOSERPScreen form = (BOSERPScreen)BaseClassFactory.GetClass(String.Format("BOSERP.Modules.Report.{0}", "RPEquipmentReg"));
            if (form != null)
            {
                form.Module = this;
                BOSDbUtil dbUtil = new BOSDbUtil();
                dbUtil.SetPropertyValue(form, "BatchProduct", obj.FK_MMBatchProductID);
                dbUtil.SetPropertyValue(form, "EquipmentProductID", obj.FK_ICEquipmentID);
                dbUtil.SetPropertyValue(form, "_FromDate", obj.MMDetailPlanEquipmentFromDate);
                dbUtil.SetPropertyValue(form, "_ToDate", obj.MMDetailPlanEquipmentToDate);
                form.Show();
            }
        }
        public void RegistrationEquipment(BOSList<MMDetailPlanEquipmentsInfo> DetailPlanEquipment, MMDetailPlanEquipmentsInfo obj)
        {
            MMOperationDetailPlansInfo mainObject = (MMOperationDetailPlansInfo)((OperationDetailPlanEntities)CurrentModuleEntity).MainObject;
            DetailPlanEquipment.EndCurrentEdit();
            if (Toolbar.IsNullOrNoneAction())
            {
                bool isError1 = false;
                if (DetailPlanEquipment.Where(o => o.Selected).Count() > 0 || obj != null)
                {
                    foreach (MMDetailPlanEquipmentsInfo item in DetailPlanEquipment)
                    {
                        if ((item.Selected && obj == null || obj != null && item.MMDetailPlanEquipmentID == obj.MMDetailPlanEquipmentID) && (item.MMDetailPlanEquipmentStatus == Status.Canceled.ToString()
                            || item.MMDetailPlanEquipmentStatus == Status.Approved.ToString()))
                        {
                            isError1 = true;
                            item.IsError = true;
                        }
                        else item.IsError = false;

                    }
                    if (isError1)
                    {
                        string mess = "Chi tiết đã chọn có trạng thái không phù hợp";
                        BOSApp.ShowMessage(mess);
                    }
                    else if (DetailPlanEquipment.Where(x => x.Selected).Count() > 0 || obj != null)
                    {
                        if (BOSApp.ShowMessageYesNo("Bạn chắc chắn đăng ký các chi tiết đã chọn?") == DialogResult.Yes)
                        {
                            bool result = ValidateRegisterEquipment(DetailPlanEquipment, obj);
                            if (!result)
                                if (BOSApp.ShowMessageYesNo("Số lượng đăng ký vượt số lượng có, bạn có muốn tiếp tục không?") == DialogResult.Yes)
                                    result = true;
                            if (result)
                            {
                                foreach (MMDetailPlanEquipmentsInfo item in DetailPlanEquipment)
                                {
                                    if ((item.Selected && obj == null) || (obj != null && item.MMDetailPlanEquipmentID == obj.MMDetailPlanEquipmentID))
                                        item.MMDetailPlanEquipmentStatus = Status.Approved.ToString();
                                }
                            }
                            else
                                return;


                            SaveItemWithDataTableType.SaveItemWithoutDelete<MMDetailPlanEquipmentsInfo>(DetailPlanEquipment.Where(x => (x.Selected && obj == null) ||
                                                                            (obj != null && x.MMDetailPlanEquipmentID == obj.MMDetailPlanEquipmentID)).ToList()
                                , "MMDetailPlanEquipmentID", "MMDetailPlanEquipments", mainObject.MMOperationDetailPlanID == 0 ? 1 : mainObject.MMOperationDetailPlanID, BOSApp.CurrentUsersInfo.ADUserName);
                            InvalidateBySearch();
                            //Invalidate(mainObject.MMOperationDetailPlanID);
                            BOSApp.ShowMessage("Đã đăng ký thành công");
                        }
                    }
                }
                else
                    BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
            }
            else
            {
                //MMDetailPlanEquipmentsInfo item = DetailPlanEquipment.Where(o => o.MMDetailPlanEquipmentID == 0).FirstOrDefault();
                //if (mainObject.MMOperationDetailPlanID == 0 || item != null)
                BOSApp.ShowMessage("Vui lòng lưu chứng từ trước!");
            }
        }

        public void CancelRegistrationEquipment(BOSList<MMDetailPlanEquipmentsInfo> DetailPlanEquipment, MMDetailPlanEquipmentsInfo obj)
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo mainObject = (MMOperationDetailPlansInfo)((OperationDetailPlanEntities)CurrentModuleEntity).MainObject;
            DetailPlanEquipment.EndCurrentEdit();
            if (Toolbar.IsNullOrNoneAction())
            {
                bool isError1 = false;
                bool isError2 = false;
                if (DetailPlanEquipment.Where(o => o.Selected).Count() > 0 || obj != null)
                {
                    foreach (MMDetailPlanEquipmentsInfo item in DetailPlanEquipment)
                    {
                        if ((item.Selected && obj == null || obj != null && item.MMDetailPlanEquipmentID == obj.MMDetailPlanEquipmentID)
                            && (item.MMDetailPlanEquipmentStatus == Status.Canceled.ToString()
                            || item.MMDetailPlanEquipmentStatus == Status.New.ToString()))
                        {
                            isError1 = true;
                            item.IsError = true;
                        }

                        if (item.Selected && obj == null || obj != null && item.MMDetailPlanEquipmentID == obj.MMDetailPlanEquipmentID)
                        {
                            MMOperationDetailPlanItemChildsInfo planItem = entity.OperationDetailPlanItemChildsList.Where(o => o.MMOperationDetailPlanItemChildID == item.FK_MMOperationDetailPlanItemChildID).FirstOrDefault();
                            if (planItem != null && DateTime.Now >= planItem.MMOperationDetailPlanItemChildExecutionFromDate)
                            {
                                isError2 = true;
                                item.IsError = true;
                            }
                        }

                    }
                    if (isError1 || isError2)
                    {
                        if (isError1)
                        {
                            string mess = "Chi tiết đã chọn có trạng thái không phù hợp";
                            BOSApp.ShowMessage(mess);
                        }
                        if (isError2 && !isError1)
                        {
                            string mess = "Chi tiết đã thực hiện, không thể hủy";
                            BOSApp.ShowMessage(mess);
                        }
                    }

                    if (!isError2 && !isError1 && (DetailPlanEquipment.Where(x => x.Selected).Count() > 0 || obj != null))
                    {
                        if (BOSApp.ShowMessageYesNo("Bạn chắc chắn hủy đăng ký các chi tiết đã chọn?") == DialogResult.Yes)
                        {
                            foreach (MMDetailPlanEquipmentsInfo item in DetailPlanEquipment)
                            {
                                if ((item.Selected && obj == null || obj != null && item.MMDetailPlanEquipmentID == obj.MMDetailPlanEquipmentID))
                                    item.MMDetailPlanEquipmentStatus = Status.New.ToString();
                            }
                            SaveItemWithDataTableType.SaveItemWithoutDelete<MMDetailPlanEquipmentsInfo>(DetailPlanEquipment.Where(x => x.Selected && obj == null
                            || obj != null && x.MMDetailPlanEquipmentID == obj.MMDetailPlanEquipmentID).ToList()
                                , "MMDetailPlanEquipmentID", "MMDetailPlanEquipments", mainObject.MMOperationDetailPlanID == 0 ? 1 : mainObject.MMOperationDetailPlanID, BOSApp.CurrentUsersInfo.ADUserName);
                            InvalidateBySearch();
                            //Invalidate(mainObject.MMOperationDetailPlanID);
                            BOSApp.ShowMessage("Đã hủy thành công");
                        }
                    }
                }
                else
                    BOSApp.ShowMessage("Vui lòng chọn chi tiết!");
            }
            else
            {
                BOSApp.ShowMessage("Vui lòng lưu chứng từ trước!");
            }
        }
        public bool ValidateRegisterEquipment(BOSList<MMDetailPlanEquipmentsInfo> DetailPlanEquipment, MMDetailPlanEquipmentsInfo obj)
        {
            bool result = true;
            MMOperationDetailPlansInfo mainObject = (MMOperationDetailPlansInfo)((OperationDetailPlanEntities)CurrentModuleEntity).MainObject;
            MMDetailPlanEquipmentsController objController = new MMDetailPlanEquipmentsController();

            List<MMDetailPlanEquipmentsInfo> exitRegis = new List<MMDetailPlanEquipmentsInfo>();
            foreach (MMDetailPlanEquipmentsInfo item in DetailPlanEquipment)
            {
                if (item.Selected && obj == null || (obj != null && obj.MMDetailPlanEquipmentID == item.MMDetailPlanEquipmentID
                                                    && item.FK_MMOperationDetailPlanItemChildID == obj.FK_MMOperationDetailPlanItemChildID))
                {
                    if (item.MMDetailPlanEquipmentQty > item.MMDetailPlanEquipmentInventoryStockQty && item.MMDetailPlanEquipmentInventoryStockQty > 0)
                    {
                        item.IsError = true;
                        result = false;
                    }
                    else
                    {
                        exitRegis = DetailPlanEquipment.Where(o => o.FK_ICEquipmentID == item.FK_ICEquipmentID
                            && (o.MMDetailPlanEquipmentID != item.MMDetailPlanEquipmentID && item.FK_MMOperationDetailPlanItemChildID != o.FK_MMOperationDetailPlanItemChildID)
                            && o.MMDetailPlanEquipmentStatus == Status.Approved.ToString()
                            && ((item.MMDetailPlanEquipmentFromDate >= o.MMDetailPlanEquipmentFromDate && item.MMDetailPlanEquipmentFromDate <= o.MMDetailPlanEquipmentToDate) ||
                            (item.MMDetailPlanEquipmentToDate >= o.MMDetailPlanEquipmentFromDate && item.MMDetailPlanEquipmentToDate <= o.MMDetailPlanEquipmentToDate))).ToList();
                        if (exitRegis != null && exitRegis.Count > 0)
                        {
                            decimal totalQty = exitRegis.Sum(o => o.MMDetailPlanEquipmentQty) + item.MMDetailPlanEquipmentQty;
                            if (totalQty > item.MMDetailPlanEquipmentInventoryStockQty)
                            {
                                item.IsError = true;
                                result = false;
                                foreach (MMDetailPlanEquipmentsInfo exitObj in exitRegis)
                                {
                                    exitObj.IsError = true;
                                }
                            }
                        }
                        else item.IsError = false;
                    }
                }
            }
            if (!result)
            {
                return result;
            }
            if (obj == null || obj.MMDetailPlanEquipmentID > 0) // trường hợp đăng ký sử dụng mới kiểm tra tồn
            {
                List<MMDetailPlanEquipmentsInfo> ValidateList = objController.GetRegistPlanEquipmentByPlan(mainObject.MMOperationDetailPlanID == 0 ? 1 : mainObject.MMOperationDetailPlanID);
                if (ValidateList != null)
                {
                    foreach (MMDetailPlanEquipmentsInfo item in DetailPlanEquipment)
                    {
                        if (item.Selected && obj == null || (obj != null && obj.MMDetailPlanEquipmentID == item.MMDetailPlanEquipmentID))
                        {
                            exitRegis = ValidateList.Where(o => o.MMDetailPlanEquipmentID == item.MMDetailPlanEquipmentID  // đã sum EquipmentQty theo  ID
                            ).ToList();
                            if (exitRegis != null && exitRegis.Count > 0)
                            {
                                decimal totalQty = item.MMDetailPlanEquipmentQty + exitRegis.Sum(o => o.MMDetailPlanEquipmentQty);
                                decimal stockQty = exitRegis[0].MMDetailPlanEquipmentInventoryStockQty;
                                if (totalQty > stockQty)
                                {
                                    item.IsError = true;
                                    result = false;
                                }
                            }
                        }
                        else item.IsError = false;
                    }
                    if (!result)
                    {
                        if (exitRegis != null && exitRegis.Count > 0)
                        {
                            foreach (var item in exitRegis)
                            {
                                MMDetailPlanEquipmentsInfo exitObj = DetailPlanEquipment.Where(o => o.MMDetailPlanEquipmentID == item.MMDetailPlanEquipmentID).FirstOrDefault();
                                if (exitObj != null)
                                    exitObj.IsError = true;
                            }
                        }
                        return result;
                    }
                }
            }
            return result;
        }
        public bool ValidateMachineEquipment(MMDetailPlanEquipmentsInfo obj)
        {
            bool result = true;
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            MMOperationDetailPlansInfo mainObject = (MMOperationDetailPlansInfo)((OperationDetailPlanEntities)CurrentModuleEntity).MainObject;
            MMDetailPlanMachineUnitsController objController = new MMDetailPlanMachineUnitsController();
            List<MMDetailPlanMachineUnitsInfo> listMachine = objController.GetAssestListByEquipment(obj.FK_ICEquipmentID);
            if (listMachine != null)
            {
                MMOperationDetailPlanItemChildsInfo ticketInfo = entity.OperationDetailPlanItemChildsList.Where(o => o.MMOperationDetailPlanItemChildID == obj.FK_MMOperationDetailPlanItemChildID).FirstOrDefault();
                if (ticketInfo != null)
                {
                    if (ticketInfo.MachineFocusedList != null && ticketInfo.MachineFocusedList.Count > 0)
                    {
                        foreach (MMDetailPlanMachineUnitsInfo item in listMachine)
                        {
                            MMDetailPlanMachineUnitsInfo foundAsset = ticketInfo.MachineFocusedList.Where(m => m.FK_ICMachineProductID == item.FK_ICMachineProductID).FirstOrDefault();
                            if (foundAsset == null || foundAsset.FK_ICMachineProductID == 0)
                                result = false;

                        }
                    }
                    else
                    {
                        result = false;
                        BOSApp.ShowMessage("Thẻ giao việc chưa gán danh sách máy móc!");
                        return result;
                    }
                }
                else
                {
                    result = false;
                    BOSApp.ShowMessage("Không tìm thấy thẻ giao việc tương ứng!");
                    return result;
                }
            }
            else
            {
                result = false;
                BOSApp.ShowMessage("Dụng cụ bạn chọn chưa chỉ định danh sách máy !");
                return result;
            }

            if (!result)
            {
                BOSApp.ShowMessage("Dụng cụ bạn chọn không phù hợp với máy móc đã chọn của thẻ!");
                return result;
            }

            return result;
        }
        public void ChecAllEquipment(bool value)
        {
            if (EquipmentPlanItemsGridControl != null)
            {
                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
                GridView gridView = (GridView)EquipmentPlanItemsGridControl.MainView;
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    MMDetailPlanEquipmentsInfo equip = (MMDetailPlanEquipmentsInfo)gridView.GetRow(j);
                    if (equip != null)
                        equip.Selected = value;
                }
                EquipmentPlanItemsGridControl?.RefreshDataSource();
            }
        }
        public void DeleteItemEquipment(MMDetailPlanEquipmentsInfo item)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
                MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)CurrentModuleEntity.MainObject;
                if (item.MMOperationDetailPlanItemChildStatus == DetailPlanItemChildStatus.New.ToString())
                {
                    entity.EquipmentDetailPlansList.RemoveSelectedRowObjectFromList();
                }
                else
                    MessageBox.Show("Chi tiết đã đăng ký, bạn không được xóa",
                                              MESLocalizedResources.MessageBoxDefaultCaption,
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Machine Capacity
        public void UpdatePlanMachineCapacity(MMOperationDetailPlanItemChildsInfo item)
        {


            var table = ADConfigValueUtility.ConfigValues.Tables[ConfigValueGroup.BlockColumnOperator];
            if (table != null)
            {
                var result = table.Rows.Cast<DataRow>().Select(x => x["Value"]).FirstOrDefault();
                if (result != null)
                {
                    //tổng dài
                    if (result.Equals(BlockColumnOperator.Length.ToString()))
                        item.MMOperationDetailPlanItemChildTotalBlock = item.MMOperationDetailPlanItemChildProductLength * item.MMOperationDetailPlanItemChildPlanProductQty / 1000;
                    //tổng m3
                    else if (result.Equals(BlockColumnOperator.M3.ToString()))
                        item.MMOperationDetailPlanItemChildTotalBlock = item.MMOperationDetailPlanItemChildBlockPerOne * item.MMOperationDetailPlanItemChildPlanProductQty;
                }
            }
            //if (item.MachineFocusedList != null && item.MachineFocusedList.Count() > 0)
            //{
            //    //Năng suất
            //    item.MMOperationDetailPlanItemChildCapacity = item.MachineFocusedList.Sum(m => m.MMDetailPlanMachineUnitCapacity) / item.MachineFocusedList.Count();
            //    //Định biên 
            //    item.MMOperationDetailPlanItemChildPayroll = item.MachineFocusedList.Sum(m => m.MMDetailPlanMachineUnitQty) / item.MachineFocusedList.Count();
            //    decimal capacityMinus = ConvertCapacityToMinus(item.MachineFocusedList);
            //    //Thời gian hoàn thành dự kiến
            //    item.MMOperationDetailPlanItemChildPlanFinishedDate = capacityMinus > 0 ? Math.Round(item.MMOperationDetailPlanItemChildPlanProductQty / (capacityMinus) //Năng suất (phút)
            //        + item.MachineFocusedList.Sum(m => m.MMDetailPlanMachineUnitSetupTime) / item.MachineFocusedList.Count(), 0) : 0; //thời gian setup(ĐVT: phút)
            //}
        }
        public decimal ConvertCapacityToMinus(List<MMDetailPlanMachineUnitsInfo> MachineFocusedList)
        {

            decimal result = 0;
            decimal totalCapacity = 0;
            MachineFocusedList.ForEach(o =>
            {
                decimal factor = GetFactorByConfig(o.MMCapacityUnit);
                // if(o.MMCapacityUnit == )
                totalCapacity += factor > 0 ? o.MMDetailPlanMachineUnitCapacity / factor : 0;
            });
            if (MachineFocusedList.Count() > 0)
                result = totalCapacity / MachineFocusedList.Count();
            return result;
        }
        public decimal GetFactorByConfig(string Unit)
        {
            decimal result = 0;
            ADConfigValuesController configController = new ADConfigValuesController();
            List<ADConfigValuesInfo> configValuesList = configController.GetADConfigValuesByKeyGroup("CapacityUnit");
            if (configValuesList.Count() > 0)
            {
                ADConfigValuesInfo found = configValuesList.Where(C => C.ADConfigKeyValue == Unit).FirstOrDefault();
                if (found != null)
                {
                    Decimal.TryParse(found.ADConfigKeyDesc, out result);
                }
            }
            return result;
        }
        #endregion
        #endregion

        #region Print Job Ticket
        public void PrintJobTicket()
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)CurrentModuleEntity;
            if (entity.TicketDetailPlanItemsList == null || entity.TicketDetailPlanItemsList.Where(o => o.Selected).ToList().Count == 0)
            {
                BOSApp.ShowMessage("Thẻ giao việc chưa được chọn, vui lòng kiểm tra lại!");
                return;
            }
            if (entity.TicketDetailPlanItemsList.Where(o => o.Selected).ToList().Count > 1)
            {
                BOSApp.ShowMessage("Chỉ được chọn 1 thẻ giao việc, vui lòng kiểm tra lại!");
                return;
            }
            guiPrint guiPrintJobTicket = new guiPrint();
            guiPrintJobTicket.Module = this;
            guiPrintJobTicket.ShowDialog();
            if (guiPrintJobTicket.DialogResult == DialogResult.OK)
            {
                string printJobTicketType = guiPrintJobTicket.PrintType;
                MMOperationDetailPlanItemChildsInfo item = entity.TicketDetailPlanItemsList.Where(o => o.Selected).FirstOrDefault();
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("PrintJobTicketType", printJobTicketType);
                string templateNo = objConfigValuesInfo != null ? objConfigValuesInfo.ADConfigKeyDesc : string.Empty;
                if (string.IsNullOrWhiteSpace(templateNo))
                    return;
                ADTemplatesInfo objADTemplatesInfo = (ADTemplatesInfo)new ADTemplatesController().GetObjectByNo(templateNo);
                if (objADTemplatesInfo == null)
                    return;
                if (string.IsNullOrEmpty(objADTemplatesInfo.ADTemplateStoreProc))
                    return;

                string rptFile = System.IO.Path.Combine("Reports", objADTemplatesInfo.ADTemplateNo + ".repx");
                BaseReport report = new BaseReport();
                guiReportPreview reviewer;
                bool bExists = System.IO.File.Exists(rptFile);
                if (!bExists)
                {
                    if (MessageBox.Show("Tệp mẫu báo cáo không tồn tại! Bạn có muốn thiết kế ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        reviewer = new guiReportPreview(report, rptFile, true);
                        reviewer.Show();
                        return;
                    }
                }
                report.LoadLayout(rptFile);
                Utilities.XtraReportHelper.SetFormatField(report);

                DataSet dataSource = SqlDatabaseHelper.RunStoredProcedure(objADTemplatesInfo.ADTemplateStoreProc, item.MMOperationDetailPlanItemChildID);
                report.DataSource = dataSource;
                reviewer = new guiReportPreview(report, rptFile, true);
                reviewer.Show();
            }
        }
        #endregion
    }
    public class WeekRange
    {
        public string Range { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Week { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
    public class ObjectLookUp
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

}
