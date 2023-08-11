using System;

namespace BOSERP.Modules.MachineConfig
{
    public class MachineConfigEntities : ERPModuleEntities
    {
        #region Constants
        #endregion

        #region Variables
        /// <summary>
        /// A variable to store the company info
        /// </summary>
        private CSCompanysInfo Company;
        #endregion

        #region Public Properties

        public BOSList<MMMachineUnitsInfo> MMMachineUnitsList { get; set; }
        public BOSList<MMMachineUnitOperationsInfo> MMMachineUnitOperationsList { get; set; }
        public BOSList<ICProductSemisInfo> ICProductSemisList { get; set; }

        #endregion

        #region Constructor
        public MachineConfigEntities()
            : base()
        {
            MMMachineUnitOperationsList = new BOSList<MMMachineUnitOperationsInfo>();
            MMMachineUnitsList = new BOSList<MMMachineUnitsInfo>();
            ICProductSemisList = new BOSList<ICProductSemisInfo>();
        }
        #endregion

        public override void InitModuleEntity()
        {
            base.InitModuleEntity();
        }

        #region Init Main Object,Module Objects functions
        public override void InitModuleObjects()
        {
            base.InitModuleObjects();
        }
        public override void InitModuleObjectList()
        {
            MMMachineUnitOperationsList.InitBOSList(this,
                                          String.Empty,
                                          "MMMachineUnitOperations",
                                          BOSList<MMMachineUnitOperationsInfo>.cstRelationNone);

            MMMachineUnitsList.InitBOSList(this,
                                          String.Empty,
                                          "MMMachineUnits",
                                          BOSList<MMMachineUnitsInfo>.cstRelationNone);
            ICProductSemisList.InitBOSList(this,
                                         String.Empty,
                                         "ICProductSemis",
                                         BOSList<ICProductSemisInfo>.cstRelationNone);
        }
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMMachineUnitsInfo objMachineUnitsInfo = (MMMachineUnitsInfo)MainObject;
            objMachineUnitsInfo.MMMachineUnitQty = 1;
            //objMachineUnitsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void InitGridControlInBOSList()
        {
            MMMachineUnitOperationsList.InitBOSListGridControl();
            MMMachineUnitsList.InitBOSListGridControl();
            ICProductSemisList.InitBOSListGridControl();
        }
        #endregion
    }
}
