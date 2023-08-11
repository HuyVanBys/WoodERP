using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.MachineGroup
{
    public class MachineGroupModule : BaseModuleERP
    {
        public int CurrentID = 0;
        public BOSLookupEdit ACDeviceIdentifierNo;
        List<ACDevicesInfo> ListACDeviceIdentifier;
        BOSLookupEdit CCDClookupEdit;
        List<ICProductIdentifiedEquipmentsInfo> ProductIdentifierList = new List<ICProductIdentifiedEquipmentsInfo>();
        public MachineGroupModule()
        {
            Name = ModuleName.MachineGroup;
            CurrentModuleEntity = new MachineGroupEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            CCDClookupEdit = (BOSLookupEdit)Controls["fld_lkeICProductIdentifiedEquipmentID"];
            CCDClookupEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(CCDClookupEdit_QueryPopUp);
            GetDataMachineGroup();
        }

        void CCDClookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ICProductIdentifiedEquipmentsController objPIController = new ICProductIdentifiedEquipmentsController();
            ProductIdentifierList = objPIController.GetAllListForMachineGroup();
            CCDClookupEdit.Properties.DataSource = ProductIdentifierList;
        }

        public void GetDataMachineGroup()
        {
            MachineGroupEntities entity = (MachineGroupEntities)CurrentModuleEntity;
            ICMachinesController obj = new ICMachinesController();
            DataSet ds = obj.GetAllObjects();
            entity.MachineGroupList.Invalidate(ds);
        }
        public void InvalidateTSCDAndCCDC(ICMachinesInfo item)
        {
            MachineGroupEntities entity = (MachineGroupEntities)CurrentModuleEntity;
            ICMachineGroupsController objMCGController = new ICMachineGroupsController();

            DataSet ds = objMCGController.GetListByMachineID(item.ICMachineID, true);
            entity.MachineGroupTSCDList.Invalidate(ds);

            ds = objMCGController.GetListByMachineID(item.ICMachineID, false);
            entity.MachineGroupCCDCList.Invalidate(ds);
        }
        public void ActionSave()
        {
            MachineGroupEntities entity = (MachineGroupEntities)CurrentModuleEntity;
            entity.MachineGroupList.SaveItemObjects();
            foreach (ICMachinesInfo item in entity.MachineGroupList)
            {
                entity.MachineGroupCCDCList.Where(i => i.CurrentID == item.CurrentID).ToList().ForEach(i => i.FK_ICMachineID = item.ICMachineID);
                entity.MachineGroupTSCDList.Where(i => i.CurrentID == item.CurrentID).ToList().ForEach(i => i.FK_ICMachineID = item.ICMachineID);
            }
            entity.MachineGroupCCDCList.SaveItemObjects();
            entity.MachineGroupTSCDList.SaveItemObjects();
            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void AddItemICMachineGroupCCDCList(int CCDC)
        {
            MachineGroupEntities entity = (MachineGroupEntities)CurrentModuleEntity;
            if (entity.MachineGroupList.CurrentIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn nhóm máy trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ICMachinesInfo objMachineInfo = entity.MachineGroupList[entity.MachineGroupList.CurrentIndex];
            ICProductIdentifiedEquipmentsController objPIController = new ICProductIdentifiedEquipmentsController();
            ICProductIdentifiedEquipmentsInfo objPIInfo = (ICProductIdentifiedEquipmentsInfo)objPIController.GetObjectByID(CCDC);
            if (objPIInfo != null)
            {
                ICMachineGroupsInfo item = new ICMachineGroupsInfo();
                BOSUtil.CopyObject(objMachineInfo, item);
                item.FK_ICProductIdentifiedEquipmentID = CCDC;
                item.ICMachineGroupStatus = "Using";
                item.ICMachineGroupName = ProductIdentifierList.Where(i => i.ICProductIdentifiedEquipmentID == CCDC).First().ICProductName;
                item.FK_ICProductID = ProductIdentifierList.Where(i => i.ICProductIdentifiedEquipmentID == CCDC).First().FK_ICProductID;
                entity.MachineGroupCCDCList.Add(item);
                entity.MachineGroupCCDCList.GridControl.RefreshDataSource();
            }
        }
        public void AddItemICMachineGroupTSCDList(int assetID)
        {
            MachineGroupEntities entity = (MachineGroupEntities)CurrentModuleEntity;

            if (entity.MachineGroupList.CurrentIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn nhóm máy trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ICMachinesInfo objMachineInfo = entity.MachineGroupList[entity.MachineGroupList.CurrentIndex];
            ACAssetsController objASController = new ACAssetsController();
            ACAssetsInfo objACAssetInfo = (ACAssetsInfo)objASController.GetObjectByID(assetID);
            if (objACAssetInfo != null)
            {
                ICMachineGroupsInfo item = new ICMachineGroupsInfo();
                BOSUtil.CopyObject(objMachineInfo, item);
                item.FK_ACAssetID = assetID;
                item.FK_ICProductID = objACAssetInfo.FK_ICProductID;
                item.ICMachineGroupStatus = "Using";
                item.ICMachineGroupName = objACAssetInfo.ACAssetName;
                entity.MachineGroupTSCDList.Add(item);
                entity.MachineGroupTSCDList.GridControl.RefreshDataSource();
            }
        }
    }
}
