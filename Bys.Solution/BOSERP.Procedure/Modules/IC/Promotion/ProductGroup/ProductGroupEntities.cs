using System;
using System.Collections.Generic;
using System.Text;
using BOSLib;

namespace BOSERP.Modules.ProductGroup 
{
    public class ProductGroupEntities : ERPModuleEntities
    {
        #region Declare Constant
        public readonly static String strICProductGroupsObjectName = "ICProductGroups";
        public readonly static String strICProductGroupRelationsObjectName = "ICProductGroupRelations";
        #endregion
        
        #region Declare all entities variables
        private ICProductGroupsInfo _iCProductGroupsObject;
        private ICProductGroupRelationsInfo _iCProductGroupRelationsObject;
 
        public BOSList<ICProductGroupRelationsInfo> lstICProductGroupRelations;
        #endregion

        #region Public Properties
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

        public ICProductGroupRelationsInfo ICProductGroupRelationsObject
        {
            get
            {
                return _iCProductGroupRelationsObject;
            }
            set
            {
                _iCProductGroupRelationsObject = value;
            }
        }

        public BOSList<ICProductGroupRelationsInfo> ICProductGroupRelationsList
        {
            get
            {
                return lstICProductGroupRelations;
            }
            set
            {
                lstICProductGroupRelations = value;
            }
        }
        #endregion

        #region Constructor
        public ProductGroupEntities()
            : base()
        {
            _iCProductGroupsObject = new ICProductGroupsInfo();
            _iCProductGroupRelationsObject = new ICProductGroupRelationsInfo();

            lstICProductGroupRelations = new BOSList<ICProductGroupRelationsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {

            MainObject = ICProductGroupsObject;
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("ICProductGroupRelations", _iCProductGroupRelationsObject);
        }

        public override void InitModuleObjectList()
        {            
            lstICProductGroupRelations = new BOSList<ICProductGroupRelationsInfo>();
            lstICProductGroupRelations.InitBOSList(this, 
                                                    BOSUtil.GetTableNameFromBusinessObjectType(typeof(ICProductGroupsInfo)),
                                                    BOSUtil.GetTableNameFromBusinessObjectType(typeof(ICProductGroupRelationsInfo)));
        }

        public override void InitGridControlInBOSList()
        {
            lstICProductGroupRelations.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                lstICProductGroupRelations.SetDefaultListAndRefreshGridControl();

            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions


        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICProductGroupRelationsList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions

        public override void SaveModuleObjects()
        {
            ICProductGroupRelationsList.SaveItemObjects(true);
        }
        #endregion
    }
}
