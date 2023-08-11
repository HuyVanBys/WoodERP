using BOSComponent;
using Localization;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.DepartmentRoomGroupTeam
{
    class DepartmentRoomGroupTeamModule : BaseModuleERP
    {
        #region Const

        #endregion
        public const string DepartmentRoomLookupEditControlName = "fld_lkeFK_HRDepartmentRoomID2";
        BOSLookupEdit DepartmentRoomLookupEditControl;
        public DepartmentRoomGroupTeamModule()
        {
            Name = "DepartmentRoomGroupTeam";
            CurrentModuleEntity = new DepartmentRoomGroupTeamEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            DepartmentRoomLookupEditControl = (BOSLookupEdit)Controls[DepartmentRoomLookupEditControlName];

        }
        public void removeSelectRow()
        {
            DepartmentRoomGroupTeamEntities entity = (DepartmentRoomGroupTeamEntities)CurrentModuleEntity;
            entity.DepartmentRoomGroupTeamItemList.RemoveSelectedRowObjectFromList();
        }
        public void InvalidateDepartmentRoom(int departmentID)
        {
            if (departmentID > 0)
            {
                HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
                List<HRDepartmentRoomsInfo> list = objDepartmentRoomsController.GetRoomList(departmentID);
                DepartmentRoomLookupEditControl.Properties.DataSource = list;
            }

        }

        public override int ActionSave()
        {
            DepartmentRoomGroupTeamEntities entity = (DepartmentRoomGroupTeamEntities)CurrentModuleEntity;
            HRDepartmentRoomGroupTeamsInfo objDepartmentRoomGroupTeamsInfo = (HRDepartmentRoomGroupTeamsInfo)entity.MainObject;
            if (objDepartmentRoomGroupTeamsInfo == null) return 0;

            if (string.IsNullOrEmpty(objDepartmentRoomGroupTeamsInfo.HRDepartmentRoomGroupTeamName))
            {
                MessageBox.Show("Vui lòng nhập tên chứng từ!", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (objDepartmentRoomGroupTeamsInfo.FK_HRDepartmentID == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng ban!", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (objDepartmentRoomGroupTeamsInfo.FK_HRDepartmentRoomID == 0)
            {
                MessageBox.Show("Vui lòng chọn bộ phận!", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return base.ActionSave();
        }
    }
}
