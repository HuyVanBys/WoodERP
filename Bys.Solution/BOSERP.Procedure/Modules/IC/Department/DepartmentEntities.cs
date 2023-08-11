using BOSCommon.Constants;
using System;
using System.Data;

namespace BOSERP.Modules.Department
{
    public class DepartmentEntities : ERPModuleEntities
    {
        #region Declare all entities variables
        private ICDepartmentsInfo _iCDepartmentsObject;
        private ICProductGroupsInfo _iCProductGroupsObject;
        private ICDepartmentAttributesInfo _iCDepartmentAttributesObject;
        private ICDepartmentAttributeValuesInfo _iCDeparmtneAttributeValuesObject;

        public BOSTreeList lstICProductGroups;
        public BOSList<ICDepartmentAttributesInfo> lstICDepartmentAttributes;
        public BOSList<ICDepartmentAttributeValuesInfo> lstICDeparmtneAttributeValues;
        #endregion

        #region Public Properties
        public ICDepartmentsInfo ICDepartmentsObject
        {
            get
            {
                return _iCDepartmentsObject;
            }
            set
            {
                _iCDepartmentsObject = value;
            }
        }

        public ICProductGroupsInfo ICProductGroupsObject
        {
            get
            {
                return _iCProductGroupsObject;
            }
            set
            {
                _iCProductGroupsObject = value;
            }
        }

        public ICDepartmentAttributesInfo ICDepartmentAttributesObject
        {
            get
            {
                return _iCDepartmentAttributesObject;
            }
            set
            {
                _iCDepartmentAttributesObject = value;
            }
        }

        public ICDepartmentAttributeValuesInfo ICDepartmentAttributeValuesObject
        {
            get
            {
                return _iCDeparmtneAttributeValuesObject;
            }
            set
            {
                _iCDeparmtneAttributeValuesObject = value;
            }
        }

        public BOSTreeList ICProductGroupsList
        {
            get
            {
                return lstICProductGroups;
            }
            set
            {
                lstICProductGroups = value;
            }
        }

        public BOSList<ICDepartmentAttributesInfo> ICDepartmentAttributesList
        {
            get
            {
                return lstICDepartmentAttributes;
            }
            set
            {
                lstICDepartmentAttributes = value;
            }
        }

        public BOSList<ICDepartmentAttributeValuesInfo> ICDepartmentAttributeValuesList
        {
            get
            {
                return lstICDeparmtneAttributeValues;
            }
            set
            {
                lstICDeparmtneAttributeValues = value;
            }
        }
        #endregion

        #region Constructor
        public DepartmentEntities()
            : base()
        {
            _iCDepartmentsObject = new ICDepartmentsInfo();
            _iCProductGroupsObject = new ICProductGroupsInfo();
            _iCDepartmentAttributesObject = new ICDepartmentAttributesInfo();
            _iCDeparmtneAttributeValuesObject = new ICDepartmentAttributeValuesInfo();

            lstICProductGroups = new BOSTreeList();
            lstICDepartmentAttributes = new BOSList<ICDepartmentAttributesInfo>();
            lstICDeparmtneAttributeValues = new BOSList<ICDepartmentAttributeValuesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = ICDepartmentsObject;
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(DepartmentModule.cstICProductGroupsObjectName, ICProductGroupsObject);
            ModuleObjects.Add(DepartmentModule.cstICDepartmentAttributesObjectName, ICDepartmentAttributesObject);
            ModuleObjects.Add(DepartmentModule.cstICDepartmentAttributeValuesObjectName, ICDepartmentAttributeValuesObject);
        }

        public override void InitModuleObjectList()
        {
            lstICProductGroups = new BOSTreeList();
            lstICDepartmentAttributes = new BOSList<ICDepartmentAttributesInfo>();
            lstICDeparmtneAttributeValues = new BOSList<ICDepartmentAttributeValuesInfo>();

            lstICProductGroups.InitBOSList(this, DepartmentModule.cstICDepartmentsObjectName, DepartmentModule.cstICProductGroupsObjectName, BOSList<ICProductGroupsInfo>.cstRelationForeign);
            lstICDepartmentAttributes.InitBOSList(this, DepartmentModule.cstICDepartmentsObjectName, DepartmentModule.cstICDepartmentAttributesObjectName);
            lstICDeparmtneAttributeValues.InitBOSList(this, DepartmentModule.cstICDepartmentAttributesObjectName, DepartmentModule.cstICDepartmentAttributeValuesObjectName);
        }

        public override void InitGridControlInBOSList()
        {
            ICProductGroupsList.InitBOSTreeListControl();
            ICDepartmentAttributeValuesList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            ICProductGroupsList.SetDefaultListAndRefreshTreeListControl();

            ICDepartmentAttributesList.SetDefaultListAndRefreshGridControl();
            ICDepartmentAttributeValuesList.SetDefaultListAndRefreshGridControl();
            ((DepartmentModule)Module).InitComboboxDataSource();
        }
        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICProductGroupsList.InvalidateTreeList(iObjectID);

            ICDepartmentAttributesList.Invalidate(iObjectID);
            foreach (ICDepartmentAttributesInfo objDepartmentAttributesInfo in ICDepartmentAttributesList)
            {
                objDepartmentAttributesInfo.ICDepartmentAttributeValuesList = new BOSList<ICDepartmentAttributeValuesInfo>();
                objDepartmentAttributesInfo.ICDepartmentAttributeValuesList.InitBOSList(this, DepartmentModule.cstICDepartmentAttributesObjectName, DepartmentModule.cstICDepartmentAttributeValuesObjectName);
                objDepartmentAttributesInfo.ICDepartmentAttributeValuesList.Invalidate(objDepartmentAttributesInfo.ICDepartmentAttributeID);
            }
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            //Save categories
            ICDepartmentsInfo objDepartmentsInfo = (ICDepartmentsInfo)MainObject;
            ICProductGroupsList.SetValueToList("FK_ICDepartmentID", objDepartmentsInfo.ICDepartmentID);
            ICProductGroupsList.SaveItemObjects();

            //Set attribute level
            foreach (ICDepartmentAttributesInfo objDepartmentAttributesInfo in ICDepartmentAttributesList)
            {
                int level = ((DepartmentModule)Module).GetItemIndex(objDepartmentAttributesInfo.ICDepartmentAttributeName);
                objDepartmentAttributesInfo.ICDepartmentAttributeLevel = level;
            }
            //Save attributes
            ICDepartmentAttributesList.SaveItemObjects();

            //Add values to current attribute
            ICDepartmentAttributeValuesList.EndCurrentEdit();
            int pos = ICDepartmentAttributesList.PosOf(DepartmentModule.cstICDepartmentAttributeNameColumnName, ((ICDepartmentAttributesInfo)ModuleObjects[DepartmentModule.cstICDepartmentAttributesObjectName]).ICDepartmentAttributeName);
            if (pos >= 0)
            {
                ICDepartmentAttributesList[pos].ICDepartmentAttributeValuesList.Clear();
                foreach (ICDepartmentAttributeValuesInfo objDepartmentAttributeValuesInfo in ICDepartmentAttributeValuesList)
                    ICDepartmentAttributesList[pos].ICDepartmentAttributeValuesList.Add((ICDepartmentAttributeValuesInfo)objDepartmentAttributeValuesInfo.Clone());
            }
            //Save attribute values
            foreach (ICDepartmentAttributesInfo objDepartmentAttributesInfo in ICDepartmentAttributesList)
            {
                foreach (ICDepartmentAttributeValuesInfo objDepartmentAttributeValuesInfo in objDepartmentAttributesInfo.ICDepartmentAttributeValuesList)
                    objDepartmentAttributeValuesInfo.FK_ICDepartmentAttributeID = objDepartmentAttributesInfo.ICDepartmentAttributeID;
                objDepartmentAttributesInfo.ICDepartmentAttributeValuesList.InitBOSList(this, DepartmentModule.cstICDepartmentAttributesObjectName, DepartmentModule.cstICDepartmentAttributeValuesObjectName);
                objDepartmentAttributesInfo.ICDepartmentAttributeValuesList.SaveItemObjects();
            }
        }
        #endregion

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            switch (strTableName)
            {
                case DepartmentModule.cstICDepartmentsObjectName:
                    {
                        ICDepartmentAttributesController objDepartmentAttributesController = new ICDepartmentAttributesController();
                        DataSet ds = objDepartmentAttributesController.GetAllDataByForeignColumn("FK_ICDepartmentID", iObjectID);
                        if (ds.Tables.Count > 0)
                        {
                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                objDepartmentAttributesController.DeleteObject(Convert.ToInt32(row[0]));
                                DeleteObjectRelations(DepartmentModule.cstICDepartmentAttributesObjectName, Convert.ToInt32(row[0]));
                            }
                        }

                        ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                        objProductGroupsController.DeleteByForeignColumn("FK_ICDepartmentID", iObjectID);
                    }
                    break;
                case DepartmentModule.cstICDepartmentAttributesObjectName:
                    {
                        ICDepartmentAttributeValuesController objDepartmentAttributeValuesController = new ICDepartmentAttributeValuesController();
                        objDepartmentAttributeValuesController.DeleteByForeignColumn("FK_ICDepartmentAttributeID", iObjectID);
                    }
                    break;
                case TableName.ICProductGroupsTableName:
                    {
                        ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                        objProductGroupsController.DeleteByForeignColumn("ICProductGroupParentID", iObjectID);
                    }
                    break;
            }
        }
    }
}
