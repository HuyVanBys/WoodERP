using BOSComponent;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.DepartmentRoomGroup
{
    class DepartmentRoomGroupModule : BaseModuleERP
    {
        #region Const

        #endregion
        public const string DepartmentRoomLookupEditControlName = "fld_lkeFK_HRDepartmentRoomID2";
        BOSLookupEdit DepartmentRoomLookupEditControl;
        public DepartmentRoomGroupModule()
        {
            Name = "DepartmentRoomGroup";
            CurrentModuleEntity = new DepartmentRoomGroupEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            DepartmentRoomLookupEditControl = (BOSLookupEdit)Controls[DepartmentRoomLookupEditControlName];

        }
        public void removeSelectRow()
        {
            DepartmentRoomGroupEntities entity = (DepartmentRoomGroupEntities)CurrentModuleEntity;
            entity.DepartmentRoomGroupItemList.RemoveSelectedRowObjectFromList();
        }
        public void InvalidateDepartmentRoom(int departmentID)
        {
            if (departmentID > 0)
            {
                HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
                List<HRDepartmentRoomsInfo> list = objDepartmentRoomsController.GetRoomList(departmentID);
                if (list != null)
                {
                    HRDepartmentRoomsInfo objDepartmentRoomsInfo = new HRDepartmentRoomsInfo();
                    list.Insert(0, objDepartmentRoomsInfo);
                }
                DepartmentRoomLookupEditControl.Properties.DataSource = list;
            }
        }


        public void UpdateDepartmentRoomGroupNo()
        {
            DepartmentRoomGroupEntities entity = (DepartmentRoomGroupEntities)CurrentModuleEntity;
            HRDepartmentRoomGroupItemsInfo objDepartmentRoomGroupItemsInfo = (HRDepartmentRoomGroupItemsInfo)entity.DepartmentRoomGroupItemList[entity.DepartmentRoomGroupItemList.CurrentIndex];
            if (objDepartmentRoomGroupItemsInfo != null)
            {
                if (string.IsNullOrEmpty(objDepartmentRoomGroupItemsInfo.HRDepartmentRoomGroupItemNo))
                {
                    int value = MaxValueDepartmentRoomGroupNo();
                    if ((value + 1) >= 10)
                    {
                        objDepartmentRoomGroupItemsInfo.HRDepartmentRoomGroupItemNo = "T" + (value + 1);
                    }
                    else
                    {
                        objDepartmentRoomGroupItemsInfo.HRDepartmentRoomGroupItemNo = "T0" + (value + 1);
                    }
                }
            };
            entity.DepartmentRoomGroupItemList.GridControl.RefreshDataSource();
        }

        public int MaxValueDepartmentRoomGroupNo()
        {
            int result = 0;
            DepartmentRoomGroupEntities entity = (DepartmentRoomGroupEntities)CurrentModuleEntity;
            HRDepartmentRoomGroupItemsInfo objDepartmentRoomGroupItemsInfo = new HRDepartmentRoomGroupItemsInfo();
            if (entity.DepartmentRoomGroupItemList.Count() > 1)
                objDepartmentRoomGroupItemsInfo = (HRDepartmentRoomGroupItemsInfo)entity.DepartmentRoomGroupItemList[entity.DepartmentRoomGroupItemList.CurrentIndex - 1];

            if (objDepartmentRoomGroupItemsInfo != null)
            {
                if (!string.IsNullOrEmpty(objDepartmentRoomGroupItemsInfo.HRDepartmentRoomGroupItemNo))
                    result = Convert.ToInt32(objDepartmentRoomGroupItemsInfo.HRDepartmentRoomGroupItemNo.Substring(1, 2));
            }
            return result;
        }

        public override int ActionSave()
        {
            DepartmentRoomGroupEntities entity = (DepartmentRoomGroupEntities)CurrentModuleEntity;
            HRDepartmentRoomGroupsInfo mainobject = (HRDepartmentRoomGroupsInfo)entity.MainObject;

            if (String.IsNullOrEmpty(mainobject.HRDepartmentRoomGroupNo))
            {
                MessageBox.Show("Mã chứng từ không được để trống. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (String.IsNullOrEmpty(mainobject.HRDepartmentRoomGroupName))
            {
                MessageBox.Show("Tên chứng từ không được để trống. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (mainobject.FK_BRBranchID2 == 0)
            {
                MessageBox.Show("Vui lòng chọn chi nhánh!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (mainobject.FK_HRDepartmentID == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng ban!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (mainobject.FK_HRDepartmentRoomID == 0)
            {
                MessageBox.Show("Vui lòng chọn bộ phận!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            foreach (HRDepartmentRoomGroupItemsInfo item in entity.DepartmentRoomGroupItemList)
            {
                if (checkExistDepartmentRoomGroupNo(item))
                {
                    MessageBox.Show("Mã và tên các tổ không được trùng."
                        + Environment.NewLine + "Mã tổ: " + item.HRDepartmentRoomGroupItemNo + " Tên tổ: " + item.HRDepartmentRoomGroupItemName
                        + Environment.NewLine + "Vui lòng kiểm tra lại!",
                        CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }

            return base.ActionSave();
        }

        public bool checkExistDepartmentRoomGroupNo(HRDepartmentRoomGroupItemsInfo objDepartmentRoomGroupItemsInfo)
        {
            DepartmentRoomGroupEntities entity = (DepartmentRoomGroupEntities)CurrentModuleEntity;
            int check = 0;
            foreach (HRDepartmentRoomGroupItemsInfo item in entity.DepartmentRoomGroupItemList)
            {
                if (!String.IsNullOrEmpty(item.HRDepartmentRoomGroupItemNo))
                {
                    if (item.HRDepartmentRoomGroupItemNo.Trim() == objDepartmentRoomGroupItemsInfo.HRDepartmentRoomGroupItemNo.Trim() || item.HRDepartmentRoomGroupItemName.Trim() == objDepartmentRoomGroupItemsInfo.HRDepartmentRoomGroupItemName.Trim())
                    {
                        check++;
                    }
                }
            }
            if (check > 1)
                return true;
            return false;
        }
        public void GetDataOperation(HRDepartmentRoomGroupItemsInfo group)
        {
            if (group.HRDepartmentRoomGroupItemID == 0)
            {
                BOSApp.ShowMessage("Vui lòng lưu chi tiết trước");
                return;
            }
            if (Toolbar.IsNullOrNoneAction())
                return;
            DepartmentRoomGroupEntities entity = (DepartmentRoomGroupEntities)CurrentModuleEntity;
            HRDepartmentRoomGroupsInfo mainObject = (HRDepartmentRoomGroupsInfo)entity.MainObject;
            MMOperationsController objOperationsController = new MMOperationsController();
            List<MMOperationsInfo> listItem = objOperationsController.GetAliveOperationAndSortOrder();
            List<MMOperationsInfo> listSelectItem = new List<MMOperationsInfo>();
            List<HRDepartmentGroupOperationsInfo> selectedItem = entity.DepGroupOperationList.Where(o => o.FK_HRDepartmentRoomGroupItemID == group.HRDepartmentRoomGroupItemID).ToList();
            if (selectedItem != null && selectedItem.Count > 0)
            {
                selectedItem.ForEach(o =>
                {
                    listItem.ForEach(op => { if (op.MMOperationID == o.FK_MMOperationID) { listSelectItem.Add((MMOperationsInfo)op.Clone()); } }
                        );
                });
            }
            guiChooseOperation guiOperation = new guiChooseOperation();
            guiOperation.OperationItemDataList = listItem;
            guiOperation.OperationDataSelected = listSelectItem;
            guiOperation.Module = this;
            guiOperation.ShowDialog();
            if (guiOperation.DialogResult == DialogResult.OK)
            {
                List<MMOperationsInfo> listSelectedItem = guiOperation.ResultList;
                if (listSelectedItem != null && listSelectedItem.Count > 0)
                {
                    listSelectedItem.OrderBy(s => s.MMOperationPeriodOrder).ToList().ForEach(p =>
                    {
                        if (!selectedItem.Any(s => s.FK_MMOperationID == p.MMOperationID))
                        {
                            HRDepartmentGroupOperationsInfo obj = new HRDepartmentGroupOperationsInfo();
                            obj.FK_MMOperationID = p.MMOperationID;
                            obj.HRDepartmentGroupOperationNo = p.MMOperationNo;
                            obj.HRDepartmentGroupOperationName = p.MMOperationName;
                            obj.FK_HRDepartmentRoomGroupItemID = group.HRDepartmentRoomGroupItemID;
                            entity.DepGroupOperationList.Add(obj);
                        }
                    });
                    selectedItem.ForEach(s =>
                    {
                        if (!listSelectedItem.Any(p => s.FK_MMOperationID == p.MMOperationID))
                        {
                            int index = entity.DepGroupOperationList.IndexOf(s);
                            if (index >= 0)
                                entity.DepGroupOperationList.RemoveAt(index);
                        }
                    });
                }
                if (entity.DepGroupOperationList.GridControl != null)
                    entity.DepGroupOperationList.GridControl.RefreshDataSource();
            }
        }

    }
}
