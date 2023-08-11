using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.HRDepartment
{
    public class HRDepartmentEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the room list of the department
        /// </summary>
        public BOSList<HRDepartmentRoomsInfo> DepartmentRoomList { get; set; }
        #endregion

        #region Constructor
        public HRDepartmentEntities()
            : base()
        {
            DepartmentRoomList = new BOSList<HRDepartmentRoomsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRDepartmentsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRDepartmentRoomsTableName, new HRDepartmentRoomsInfo());
        }

        public override void InitModuleObjectList()
        {
            DepartmentRoomList.InitBOSList(
                                            this,
                                            TableName.HRDepartmentsTableName,
                                            TableName.HRDepartmentRoomsTableName,
                                            BOSList<HRDepartmentsInfo>.cstRelationForeign);
            DepartmentRoomList.ItemTableForeignKey = "FK_HRDepartmentID";
        }

        public override void InitGridControlInBOSList()
        {
            DepartmentRoomList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                DepartmentRoomList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            DepartmentRoomList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            HRDepartmentsInfo objDepartmentsInfo = (HRDepartmentsInfo)MainObject;
            if (objDepartmentsInfo != null && objDepartmentsInfo.FK_BRBranchID > 0)
            {
                DepartmentRoomList.ForEach(o =>
                {
                    o.FK_BRBranchID = objDepartmentsInfo.FK_BRBranchID;
                });
            }
            DepartmentRoomList.SaveItemObjects();
        }
        #endregion
    }
}
