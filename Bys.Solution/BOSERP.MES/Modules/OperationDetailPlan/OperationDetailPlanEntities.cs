using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.OperationDetailPlan
{
    public class OperationDetailPlanEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the purchase proposal item list
        /// </summary>
        public BOSList<MMBatchProductItemsInfo> BatchProductItemsList { get; set; }
        public BOSList<MMOperationDetailPlanItemChildsInfo> OperationDetailPlanItemChildsList { get; set; }
        public BOSList<MMOperationDetailPlanItemChildsInfo> HumanDetailPlanItemsList { get; set; }
        public BOSList<MMOperationDetailPlanItemChildsInfo> MachineDetailPlanItemsList { get; set; }
        public BOSList<MMOperationDetailPlanItemChildsInfo> TicketDetailPlanItemsList { get; set; }
        public BOSList<MMDetailPlanHumanUnitsInfo> HumanUnitList { get; set; }
        public BOSList<MMDetailPlanMachineUnitsInfo> MachineUnitList { get; set; }
        public BOSList<MMOperationDetailPlansInfo> ListWeek { get; set; }
        public List<MMOperationDetailPlanItemChildsInfo> DeleteItem;
        public List<MMDetailPlanHumanUnitsInfo> DeleteHuman;
        public List<MMDetailPlanMachineUnitsInfo> DeleteMachine;
        public BOSList<MMDetailPlanEquipmentsInfo> EquipmentDetailPlansList { get; set; }
        public List<MMDetailPlanEquipmentsInfo> DeleteEquipment;
        public BOSList<MMOperationDetailPlanCapacityItemsInfo> CapacityDataList { get; set; }
        #endregion
        #region Contructors
        public OperationDetailPlanEntities()
            : base()
        {
            OperationDetailPlanItemChildsList = new BOSList<MMOperationDetailPlanItemChildsInfo>();
            HumanDetailPlanItemsList = new BOSList<MMOperationDetailPlanItemChildsInfo>();
            MachineDetailPlanItemsList = new BOSList<MMOperationDetailPlanItemChildsInfo>();
            TicketDetailPlanItemsList = new BOSList<MMOperationDetailPlanItemChildsInfo>();
            BatchProductItemsList = new BOSList<MMBatchProductItemsInfo>();
            ListWeek = new BOSList<MMOperationDetailPlansInfo>();
            HumanUnitList = new BOSList<MMDetailPlanHumanUnitsInfo>();
            MachineUnitList = new BOSList<MMDetailPlanMachineUnitsInfo>();
            DeleteItem = new List<MMOperationDetailPlanItemChildsInfo>();
            DeleteHuman = new List<MMDetailPlanHumanUnitsInfo>();
            DeleteMachine = new List<MMDetailPlanMachineUnitsInfo>();
            DeleteEquipment = new List<MMDetailPlanEquipmentsInfo>();
            CapacityDataList = new BOSList<MMOperationDetailPlanCapacityItemsInfo>();
            EquipmentDetailPlansList = new BOSList<MMDetailPlanEquipmentsInfo>();
        }
        #endregion Contructors

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMOperationDetailPlansInfo();
            //SearchObject = new MMOperationDetailPlansInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMOperationDetailPlanItemChildsTableName, new MMOperationDetailPlanItemChildsInfo());
            ModuleObjects.Add("MMDetailPlanHumanUnits", new MMDetailPlanHumanUnitsInfo());
            ModuleObjects.Add("MMDetailPlanMachineUnits", new MMDetailPlanMachineUnitsInfo());
            ModuleObjects.Add("MMDetailPlanEquipments", new MMDetailPlanEquipmentsInfo());
        }

        public override void InitModuleObjectList()
        {
            OperationDetailPlanItemChildsList.InitBOSList(this,
                                                    TableName.MMOperationDetailPlansTableName,
                                                    TableName.MMOperationDetailPlanItemChildsTableName,
                                                    BOSList<MMOperationDetailPlanItemChildsInfo>.cstRelationForeign);
            OperationDetailPlanItemChildsList.ItemTableForeignKey = "FK_MMOperationDetailPlanID";

            HumanDetailPlanItemsList.InitBOSList(this,
                                                    TableName.MMOperationDetailPlansTableName,
                                                    TableName.MMOperationDetailPlanItemChildsTableName,
                                                    BOSList<MMOperationDetailPlanItemChildsInfo>.cstRelationNone);
            MachineDetailPlanItemsList.InitBOSList(this,
                                                    TableName.MMOperationDetailPlansTableName,
                                                    TableName.MMOperationDetailPlanItemChildsTableName,
                                                    BOSList<MMOperationDetailPlanItemChildsInfo>.cstRelationNone);

            BatchProductItemsList.InitBOSList(
                                            this,
                                            null,
                                            TableName.MMBatchProductItemsTableName,
                                            BOSList<MMBatchProductItemsInfo>.cstRelationNone);
            HumanUnitList.InitBOSList(
                                            this,
                                            null,
                                            "MMDetailPlanHumanUnits",
                                            BOSList<MMDetailPlanHumanUnitsInfo>.cstRelationNone);
            MachineUnitList.InitBOSList(
                                            this,
                                            null,
                                            "MMDetailPlanMachineUnits",
                                            BOSList<MMDetailPlanMachineUnitsInfo>.cstRelationNone);
            TicketDetailPlanItemsList.InitBOSList(this,
                                                    TableName.MMOperationDetailPlansTableName,
                                                    TableName.MMOperationDetailPlanItemChildsTableName,
                                                    BOSList<MMOperationDetailPlanItemChildsInfo>.cstRelationNone);
            CapacityDataList.InitBOSList(this,
                                        string.Empty,
                                        TableName.MMOperationDetailPlanCapacityItemsTableName,
                                        BOSList<MMOperationDetailPlanCapacityItemsInfo>.cstRelationNone);

            EquipmentDetailPlansList.InitBOSList(this,
                                                TableName.MMOperationDetailPlansTableName,
                                                "MMDetailPlanEquipments",
                                                BOSList<MMDetailPlanEquipmentsInfo>.cstRelationForeign);
            EquipmentDetailPlansList.ItemTableForeignKey = "FK_MMOperationDetailPlanID";
        }

        public override void InitGridControlInBOSList()
        {
            OperationDetailPlanItemChildsList.InitBOSListGridControl("fld_dgcMMOperationDetailPlanItemChilds");
            HumanUnitList.InitBOSListGridControl("fld_dgcMMDetailPlanHumanUnitsGridControl");
            MachineUnitList.InitBOSListGridControl("fld_dgcMMDetailPlanMachineUnitsGridControl");
            HumanDetailPlanItemsList.InitBOSListGridControl("fld_dgcHumanDetailPlanItems");
            MachineDetailPlanItemsList.InitBOSListGridControl("fld_dgcMachineDetailPlanItems");
            TicketDetailPlanItemsList.InitBOSListGridControl("fld_dgcMMTicketPlanItems");
            CapacityDataList.InitBOSListGridControl("fld_dgcCapacityItemsGridControl");
            EquipmentDetailPlansList.InitBOSListGridControl("fld_dgcMMDetailPlanEquipments");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)MainObject;
            objOperationDetailPlansInfo.MMOperationDetailPlanDate = DateTime.Now;
            objOperationDetailPlansInfo.MMOperationDetailPlanStatus = OperationDetailPlanStatus.New.ToString();
            objOperationDetailPlansInfo.MMOperationDetailPlanType = OperationDetailPlanType.Production.ToString();
            objOperationDetailPlansInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objOperationDetailPlansInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                OperationDetailPlanItemChildsList.SetDefaultListAndRefreshGridControl();
                BatchProductItemsList.SetDefaultListAndRefreshGridControl();
                HumanUnitList.SetDefaultListAndRefreshGridControl();
                MachineUnitList.SetDefaultListAndRefreshGridControl();
                HumanDetailPlanItemsList.SetDefaultListAndRefreshGridControl();
                MachineDetailPlanItemsList.SetDefaultListAndRefreshGridControl();
                TicketDetailPlanItemsList.SetDefaultListAndRefreshGridControl();
                CapacityDataList.SetDefaultListAndRefreshGridControl();
                EquipmentDetailPlansList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Override BaseTransactionEntities
        public override void InvalidateModuleObjects(int iObjectID)
        {
            //MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)MainObject;

            //List<MMOperationDetailPlanItemChildsInfo> listPlanItem = new List<MMOperationDetailPlanItemChildsInfo>();
            //listPlanItem = (new MMOperationDetailPlanItemChildsController()).GetAllItemChildByPlanID(iObjectID);
            //if(listPlanItem != null)
            //OperationDetailPlanItemChildsList.Invalidate(listPlanItem);
            //MMDetailPlanHumanUnitsController humanUnitController = new MMDetailPlanHumanUnitsController();
            //MMDetailPlanMachineUnitsController machineUnitController = new MMDetailPlanMachineUnitsController();
            //List<MMDetailPlanHumanUnitsInfo> listHuman = new List<MMDetailPlanHumanUnitsInfo>();
            //List<MMDetailPlanMachineUnitsInfo> listMachineUnit = new List<MMDetailPlanMachineUnitsInfo>();
            //listHuman = humanUnitController.GetDetailPlanHumanUnitPlanID(iObjectID);
            //listMachineUnit = machineUnitController.GetDetailPlanMachineUnitPlanID(iObjectID);
            //HumanUnitList.Invalidate(listHuman);
            //MachineUnitList.Invalidate(listMachineUnit);
            //List<MMOperationDetailPlanCapacityItemsInfo> newList = new List<MMOperationDetailPlanCapacityItemsInfo>();
            //CapacityDataList.Invalidate(newList);

            //MMDetailPlanEquipmentsController dpEquipmentContrller = new MMDetailPlanEquipmentsController();
            //List<MMDetailPlanEquipmentsInfo> planEquipmentList = new List<MMDetailPlanEquipmentsInfo>();
            //planEquipmentList = dpEquipmentContrller.GetAllItemChildByPlanID(iObjectID);
            //if (planEquipmentList != null)
            //    EquipmentDetailPlansList.Invalidate(planEquipmentList);

        }
        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)MainObject;
            #region Save Plan Child
            SaveItemWithDataTableType.SaveItemWithoutDelete<MMOperationDetailPlanItemChildsInfo>(OperationDetailPlanItemChildsList
                , "MMOperationDetailPlanItemChildID", "MMOperationDetailPlanItemChilds", objOperationDetailPlansInfo.MMOperationDetailPlanID, BOSApp.CurrentUsersInfo.ADUserName);
            if (DeleteItem != null && DeleteItem.Count > 0)
                SaveItemWithDataTableType.DeleteItem<MMOperationDetailPlanItemChildsInfo>(DeleteItem, "MMOperationDetailPlanItemChilds", BOSApp.CurrentUsersInfo.ADUserName);
            #endregion
            #region Save HumanUnit

            SaveItemWithDataTableType.SaveItemWithoutDelete<MMDetailPlanHumanUnitsInfo>(HumanUnitList
                , "MMDetailPlanHumanUnitID", "MMDetailPlanHumanUnits", objOperationDetailPlansInfo.MMOperationDetailPlanID, BOSApp.CurrentUsersInfo.ADUserName);
            if (DeleteHuman != null && DeleteHuman.Count > 0)
                SaveItemWithDataTableType.DeleteItem<MMDetailPlanHumanUnitsInfo>(DeleteHuman, "MMDetailPlanHumanUnits", BOSApp.CurrentUsersInfo.ADUserName);

            #endregion
            #region Save MachineUnit
            SaveItemWithDataTableType.SaveItemWithoutDelete<MMDetailPlanMachineUnitsInfo>(MachineUnitList
               , "MMDetailPlanMachineUnitID", "MMDetailPlanMachineUnits", objOperationDetailPlansInfo.MMOperationDetailPlanID, BOSApp.CurrentUsersInfo.ADUserName);
            if (DeleteMachine != null && DeleteMachine.Count > 0)
                SaveItemWithDataTableType.DeleteItem<MMDetailPlanMachineUnitsInfo>(DeleteMachine, "MMDetailPlanMachineUnits", BOSApp.CurrentUsersInfo.ADUserName);
            #endregion
            #region Save Equipment
            SaveItemWithDataTableType.SaveItemWithoutDelete<MMDetailPlanEquipmentsInfo>(EquipmentDetailPlansList
               , "MMDetailPlanEquipmentID", "MMDetailPlanEquipments", objOperationDetailPlansInfo.MMOperationDetailPlanID, BOSApp.CurrentUsersInfo.ADUserName);
            if (DeleteEquipment != null && DeleteEquipment.Count > 0)
                SaveItemWithDataTableType.DeleteItem<MMDetailPlanEquipmentsInfo>(DeleteEquipment, "MMDetailPlanEquipments", BOSApp.CurrentUsersInfo.ADUserName);
            #endregion

        }
        #endregion Override BaseTransactionEntities

        #region Public methods
        /// <summary>
        /// Approve all items of the proposal
        /// </summary>
        public bool ApproveOperationDetailPlan()
        {
            SetPropertyChangeEventLock(false);
            //Update the this's status
            MMOperationDetailPlansInfo objOperationDetailPlansInfo = (MMOperationDetailPlansInfo)MainObject;
            objOperationDetailPlansInfo.MMOperationDetailPlanStatus = OperationDetailPlanStatus.Approved.ToString();
            objOperationDetailPlansInfo.FK_HREmployeeIDApproved = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objOperationDetailPlansInfo.MMOperationDetailPlanToApprovedDate = DateTime.Now;

            UpdateMainObject();

            SetPropertyChangeEventLock(true);

            return true;
        }
        #endregion Public methods
    }
}
