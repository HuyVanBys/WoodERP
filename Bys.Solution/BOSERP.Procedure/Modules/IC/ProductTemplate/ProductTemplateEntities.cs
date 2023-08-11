using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using BOSLib;
using BOSCommon;

namespace BOSERP.Modules.ProductTemplate
{
    public class ProductTemplateEntities : ERPModuleEntities
    {
        #region Public Properties
        public BOSTreeList ProductTemplateItemsTreeList { get; set; }

        #endregion

        #region Constructor
        public ProductTemplateEntities()
            : base()
        {
            ProductTemplateItemsTreeList = new BOSTreeList();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICProductTemplatesInfo();
            SearchObject = new ICProductTemplatesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICProductTemplateItemsTableName, new ICProductTemplateItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ProductTemplateItemsTreeList.InitBOSList(this,
                                                     TableName.ICProductTemplatesTableName,
                                                     TableName.ICProductTemplateItemsTableName,
                                                     BOSTreeList.cstRelationForeign);
            ProductTemplateItemsTreeList.ItemTableForeignKey = "FK_ICProductTemplateID";
        }

        public override void InitGridControlInBOSList()
        {
            ProductTemplateItemsTreeList.InitBOSTreeListControl("fld_trlProductTemplateItemTreeListControl");
        }

        public override void SetDefaultModuleObjectsList()
        {
            ProductTemplateItemsTreeList.SetDefaultListAndRefreshTreeListControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ICProductTemplatesInfo mainobject = MainObject as ICProductTemplatesInfo;
            mainobject.FK_HREmployeeID = BOSApp.CurrentUsersInfo == null ? 0 : BOSApp.CurrentUsersInfo.FK_HREmployeeID;
        }

        public override void SaveModuleObjects()
        {
            ProductTemplateItemsTreeList.SaveItemObjects();
        }
        #endregion
    }
}