using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.DormitoryCost
{
    public class DormitoryCostModule : BaseModuleERP
    {

        public DormitoryCostModule()
        {
            Name = "DormitoryCost";
            CurrentModuleEntity = new DormitoryCostEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

        }


        public void AddEmployeeToRegisterDormitoryItem()
        {
            try
            {
                DormitoryCostEntities entity = (DormitoryCostEntities)CurrentModuleEntity;
                HRDormitoryCostsInfo mainObject = (HRDormitoryCostsInfo)entity.MainObject;
                HRDormitorysController objHRDormitoryCostsController = new HRDormitorysController();
                DataSet ds = objHRDormitoryCostsController.GetAllObjects();
                List<HRDormitorysInfo> employeeContactPersonsList = (List<HRDormitorysInfo>)objHRDormitoryCostsController.GetListFromDataSet(ds);
                guiFind<HRDormitorysInfo> guifind = new guiFind<HRDormitorysInfo>("HRDormitorys", employeeContactPersonsList, this, true, true);
                guifind.Module = this;
                if (guifind.ShowDialog() == DialogResult.OK)
                {
                    if (guifind.SelectedObjects != null && guifind.SelectedObjects.Count > 0)
                    {
                        foreach (HRDormitorysInfo Item in guifind.SelectedObjects)
                        {
                            if (entity.DormitoryCostItemList.Where(x => x.FK_HRDormitoryID == Item.HRDormitoryID).ToList().Count == 0)
                            {
                                HRDormitoryCostItemsInfo obDormitoryCostItemsInfo = new HRDormitoryCostItemsInfo();
                                obDormitoryCostItemsInfo.FK_HRDormitoryCostID = mainObject.HRDormitoryCostID;
                                obDormitoryCostItemsInfo.FK_HRDormitoryID = Item.HRDormitoryID;
                                obDormitoryCostItemsInfo.HRDormitoryCostItemDormitoryName = Item.HRDormitoryName;
                                obDormitoryCostItemsInfo.HRDormitoryNo = Item.HRDormitoryNo;
                                entity.DormitoryCostItemList.Add(obDormitoryCostItemsInfo);
                            }
                        }
                    }
                    entity.DormitoryCostItemList.GridControl.RefreshDataSource();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi, vui lòng thử lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override int ActionSave()
        {
            DormitoryCostEntities entity = (DormitoryCostEntities)CurrentModuleEntity;
            HRDormitoryCostsInfo mainObject = (HRDormitoryCostsInfo)entity.MainObject;
            HRDormitoryCostsController objHRDormitoryCostsController = new HRDormitoryCostsController();
            HRDormitoryCostItemsController objHRDormitoryCostItemsController = new HRDormitoryCostItemsController();
            entity.DormitoryCostItemList.EndCurrentEdit();
            if (entity.DormitoryCostItemList.Where(i => i.HRDormitoryCostItemNumberElectricity < 0).ToList().Count > 0)
            {
                MessageBox.Show("Số điện không được nhỏ hơn 0, vui lòng thực hiện lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            List<HRDormitoryCostItemsInfo> ListDormitoryCostItems = objHRDormitoryCostItemsController.GetAllDataByDate();
            foreach (HRDormitoryCostItemsInfo item in entity.DormitoryCostItemList)
            {
                List<HRDormitoryCostItemsInfo> DateList1 = ListDormitoryCostItems.Where(i => i.FK_HRDormitoryID == item.FK_HRDormitoryID
                                                                                           && i.FK_HRDormitoryCostID != mainObject.HRDormitoryCostID
                                                                                           && ((i.HRDormitoryCostFromDate <= mainObject.HRDormitoryCostFromDate && mainObject.HRDormitoryCostFromDate <= i.HRDormitoryCostToDate)
                                                                                                 || (i.HRDormitoryCostFromDate <= mainObject.HRDormitoryCostToDate && mainObject.HRDormitoryCostToDate <= i.HRDormitoryCostToDate))).ToList();
                if (DateList1 != null && DateList1.Count > 0)
                {
                    MessageBox.Show("Phòng: " + DateList1[0].HRDormitoryCostItemDormitoryName
                                    + " đã tạo chi phí từ ngày: "
                                    + DateList1[0].HRDormitoryCostFromDate.ToString("dd/MM/yyyy")
                                    + " đến ngày: "
                                    + DateList1[0].HRDormitoryCostToDate.ToString("dd/MM/yyyy"), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }

            }


            UpdateTotalAmountItems();

            return base.ActionSave();
        }

        public void DeleteItemFromRegisterDormitoryItemsList()
        {
            DormitoryCostEntities entity = (DormitoryCostEntities)CurrentModuleEntity;
            entity.DormitoryCostItemList.RemoveSelectedRowObjectFromList();
        }

        internal void ChangeItemFromDormitoryCostItemsList()
        {
            UpdateTotalAmountItems();
        }
        public void UpdateTotalAmountItems()
        {
            DormitoryCostEntities entity = (DormitoryCostEntities)CurrentModuleEntity;
            HRDormitoryCostsInfo mainObject = (HRDormitoryCostsInfo)entity.MainObject;
            HRDormitoryCostsController objHRDormitoryCostsController = new HRDormitoryCostsController();
            foreach (HRDormitoryCostItemsInfo item in entity.DormitoryCostItemList)
            {
                item.HRDormitoryCostItemNumberElectricity = item.HRDormitoryCostItemEndNumber - item.HRDormitoryCostItemStartNumber;
                item.HRDormitoryCostItemTotalAmount = (item.HRDormitoryCostItemNumberElectricity * mainObject.HRDormitoryCostUnitPriceElectricity);
                item.HRDormitoryCostItemNumberWater = item.HRDormitoryCostItemWaterEndNumber - item.HRDormitoryCostItemWaterStartNumber;
                item.HRDormitoryCostItemWaterCost = (item.HRDormitoryCostItemNumberWater * mainObject.HRDormitoryCostUnitPriceWater);
            }
            entity.DormitoryCostItemList.GridControl.RefreshDataSource();
        }
    }
}
