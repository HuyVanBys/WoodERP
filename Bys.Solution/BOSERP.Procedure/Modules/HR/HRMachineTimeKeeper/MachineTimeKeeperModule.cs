using BOSCommon.Constants;
using BOSComponent;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using zkemkeeper;

namespace BOSERP.Modules.MachineTimeKeeper
{
    public class MachineTimeKeeperModule : BaseModuleERP
    {
        #region Constants
        List<HRMachineTimeKeepersInfo> MachineTimeKeeperSConnectedList;
        public const string DataFromName = "fld_dteSearchFromDate";
        public const string DataToName = "fld_dteSearchToDate";
        public const string TimeKeepersGridControlName = "TimeKeepersGridControl";
        public const string MachineTimeKeeperLookupEditName = "fld_lkeHRMachineTimeKeeperID";
        public const string MachineTimeKeeperLookupEditName2 = "fld_lkeHRMachineTimeKeeperID2";
        public const string MachineTimeKeeperTypeRadioGroupName = "radioGroup";
        public BOSDateEdit DateFromControl;
        public BOSDateEdit DateToControl;
        public HRTimeKeepersGridControl TimeKeepersGridControl;
        public BOSLookupEdit MachineTimeKeeperLookupEdit;
        public BOSLookupEdit MachineTimeKeeperLookupEdit2;
        public BOSRadioGroup MachineTimeKeeperTypeRadioGroup;
        #endregion

        public MachineTimeKeeperModule()
        {
            Name = ModuleName.MachineTimeKeeper;
            CurrentModuleEntity = new MachineTimeKeeperEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }
        public void TestConnect()
        {
            MachineTimeKeeperEntities entity = (MachineTimeKeeperEntities)CurrentModuleEntity;
            HRMachineTimeKeepersInfo objMachineTimeKeepersInfo = (HRMachineTimeKeepersInfo)entity.MainObject;
            objMachineTimeKeepersInfo = Connect(objMachineTimeKeepersInfo);
            if (objMachineTimeKeepersInfo.HRMachineTimeKeeperIsConnected)
            {
                MessageBox.Show(MachineTimeKeeperLocalizedResources.ConnectSuccess, MachineTimeKeeperLocalizedResources.TestConnect, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisConnect(objMachineTimeKeepersInfo);
            }
            else
            {
                MessageBox.Show(MachineTimeKeeperLocalizedResources.ConnectFalse, MachineTimeKeeperLocalizedResources.TestConnect, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public override int ActionSave()
        {
            MachineTimeKeeperEntities entity = (MachineTimeKeeperEntities)CurrentModuleEntity;
            HRMachineTimeKeepersInfo objMachineTimeKeepersInfo = (HRMachineTimeKeepersInfo)entity.MainObject;
            objMachineTimeKeepersInfo.HRMachineTimeKeeperIsConnected = true;
            return base.ActionSave();
        }
        public void GetGeneralLogData(int machineTimeKeeperID, CZKEMClass machine)
        {
            List<HRTimeKeepersInfo> timeKeeperList = new List<HRTimeKeepersInfo>();

            if (!machine.IsTFTMachine(machineTimeKeeperID))
            {
                MessageBox.Show("Not IsTFTMachine!", MachineTimeKeeperLocalizedResources.TestConnect, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (machine.ReadAllGLogData(machineTimeKeeperID) == true)
                {
                    //int error =0;
                    //machine.GetLastError(ref error);
                    MessageBox.Show("Not IsTFTMachine! ReadAllGLogData == true ", MachineTimeKeeperLocalizedResources.TestConnect, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Not IsTFTMachine! ReadAllGLogData == False ", MachineTimeKeeperLocalizedResources.TestConnect, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("IsTFTMachine!", MachineTimeKeeperLocalizedResources.TestConnect, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (machine.ReadGeneralLogData(machineTimeKeeperID) == true)
                {
                    //int error = 0;
                    //machine.GetLastError(ref error);
                    MessageBox.Show("IsTFTMachine! ReadGeneralLogData == true", MachineTimeKeeperLocalizedResources.TestConnect, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("IsTFTMachine! ReadGeneralLogData == False ", MachineTimeKeeperLocalizedResources.TestConnect, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //machine.EnableDevice(machineTimeKeeperID, true);
            }
        }

        public void DisableDevice(bool isDisable)
        {
            MachineTimeKeeperEntities entity = (MachineTimeKeeperEntities)CurrentModuleEntity;
            HRMachineTimeKeepersInfo objMachineTimeKeepersInfo = (HRMachineTimeKeepersInfo)entity.MainObject;
            objMachineTimeKeepersInfo = Connect(objMachineTimeKeepersInfo);
            if (objMachineTimeKeepersInfo.HRMachineTimeKeeperIsConnected)
            {
                List<HRTimeKeepersInfo> timeKeeperList = new List<HRTimeKeepersInfo>();

                if (!objMachineTimeKeepersInfo.CZKEMMachine.IsTFTMachine(objMachineTimeKeepersInfo.HRMachineTimeKeeperID))
                {
                    objMachineTimeKeepersInfo.CZKEMMachine.EnableDevice(objMachineTimeKeepersInfo.HRMachineTimeKeeperID, isDisable);
                }
                else
                {
                    objMachineTimeKeepersInfo.CZKEMMachine.EnableDevice(objMachineTimeKeepersInfo.HRMachineTimeKeeperID, isDisable);
                }
            }
        }

        public HRMachineTimeKeepersInfo Connect(HRMachineTimeKeepersInfo objMachineTimeKeepersInfo)
        {
            objMachineTimeKeepersInfo.CZKEMMachine = new CZKEMClass();
            objMachineTimeKeepersInfo.HRMachineTimeKeeperIsConnected = objMachineTimeKeepersInfo.CZKEMMachine.Connect_Net(objMachineTimeKeepersInfo.HRMachineTimeKeeperIP, Convert.ToInt32(objMachineTimeKeepersInfo.HRMachineTimeKeeperPortID));
            return objMachineTimeKeepersInfo;
        }
        public HRMachineTimeKeepersInfo DisConnect(HRMachineTimeKeepersInfo objMachineTimeKeepersInfo)
        {
            if (objMachineTimeKeepersInfo.HRMachineTimeKeeperIsConnected)
            {
                if (objMachineTimeKeepersInfo.CZKEMMachine != null)
                    objMachineTimeKeepersInfo.CZKEMMachine.Disconnect();
            }
            objMachineTimeKeepersInfo.HRMachineTimeKeeperIsConnected = false;
            return objMachineTimeKeepersInfo;
        }
        public void DisConnect()
        {
            MachineTimeKeeperEntities entity = (MachineTimeKeeperEntities)CurrentModuleEntity;
            HRMachineTimeKeepersInfo objMachineTimeKeepersInfo = (HRMachineTimeKeepersInfo)entity.MainObject;
            objMachineTimeKeepersInfo = DisConnect(objMachineTimeKeepersInfo);
        }
    }
}
