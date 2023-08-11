using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.NormTemplate
{
    class NormTemplateEntities : BaseTransactionEntities
    {
        #region Public Properties

        ///// <summary>
        ///// Gets or sets the Process item list
        ///// </summary>
        public BOSList<MMNormTemplateItemsInfo> NormTemplateItemList { get; set; }
        public BOSList<MMNormTemplateProductsInfo> NormTemplateProductList { get; set; }

        #endregion

        #region Contructors
        public NormTemplateEntities()
            : base()
        {
            NormTemplateItemList = new BOSList<MMNormTemplateItemsInfo>();
            NormTemplateProductList = new BOSList<MMNormTemplateProductsInfo>();
        }
        #endregion Contructors

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMNormTemplatesInfo();
            SearchObject = new MMNormTemplatesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMNormTemplatesTableName, new MMNormTemplatesInfo());
            ModuleObjects.Add(TableName.MMNormTemplateItemsTableName, new MMNormTemplateItemsInfo());
            ModuleObjects.Add(TableName.MMNormTemplateProductsTableName, new MMNormTemplateProductsInfo());
        }

        public override void InitModuleObjectList()
        {

            NormTemplateItemList.InitBOSList(
                                        this,
                                        TableName.MMNormTemplatesTableName,
                                        TableName.MMNormTemplateItemsTableName,
                                        BOSList<MMNormTemplateItemsInfo>.cstRelationForeign);
            NormTemplateItemList.ItemTableForeignKey = "FK_MMNormTemplateID";

            NormTemplateProductList.InitBOSList(
                                        this,
                                        TableName.MMNormTemplatesTableName,
                                        TableName.MMNormTemplateProductsTableName,
                                        BOSList<MMNormTemplateProductsInfo>.cstRelationForeign);
            NormTemplateProductList.ItemTableForeignKey = "FK_MMNormTemplateID";
        }

        public override void InitGridControlInBOSList()
        {
            NormTemplateItemList.InitBOSListGridControl("fld_dgcMMNormTemplateItems");
            NormTemplateProductList.InitBOSListGridControl("fld_dgcMMNormTemplateProducts");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMNormTemplatesInfo objNormTemplateInfo = (MMNormTemplatesInfo)MainObject;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                NormTemplateItemList.SetDefaultListAndRefreshGridControl();
                NormTemplateProductList.SetDefaultListAndRefreshGridControl();

            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Override BaseTransactionEntities

        public override void InvalidateModuleObjects(int iObjectID)
        {
            NormTemplateItemList.Invalidate(iObjectID);
            NormTemplateProductList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            MMNormTemplatesInfo objNormTemplateInfo = (MMNormTemplatesInfo)MainObject;
            NormTemplateItemList.SaveItemObjects();
            NormTemplateProductList.SaveItemObjects();
        }
        public void SaveNormTemplateProduct()
        {
            MMNormTemplatesInfo objNormTemplateInfo = (MMNormTemplatesInfo)MainObject;
            if (objNormTemplateInfo.MMNormTemplateID == 0) return;
            NormTemplateProductList.ForEach(p => { if (p.FK_MMNormTemplateID == 0) p.FK_MMNormTemplateID = objNormTemplateInfo.MMNormTemplateID; });
            NormTemplateProductList.SaveItemObjects();
        }
        public void ApproveNormTemplate()
        {
            SetPropertyChangeEventLock(false);
            //Update the this's status
            MMNormTemplatesInfo objNormTemplateInfo = (MMNormTemplatesInfo)MainObject;
            objNormTemplateInfo.MMNormTemplateStatus = BatchProductPlanStatus.Approved.ToString();
            UpdateMainObject();
        }

        #endregion Override BaseTransactionEntities
    }
}
