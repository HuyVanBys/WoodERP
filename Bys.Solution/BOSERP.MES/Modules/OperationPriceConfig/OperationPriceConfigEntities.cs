using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.OperationPriceConfig
{
    class OperationPriceConfigEntities : BaseTransactionEntities
    {
        #region Public Properties

        ///// <summary>
        ///// Gets or sets the OperationPriceConfig item list
        ///// </summary>
        public BOSList<MMOperationPriceConfigItemsInfo> OperationPriceConfigItemList { get; set; }

        #endregion

        #region Contructors
        public OperationPriceConfigEntities()
            : base()
        {
            OperationPriceConfigItemList = new BOSList<MMOperationPriceConfigItemsInfo>();
        }
        #endregion Contructors

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMOperationPriceConfigsInfo();
            SearchObject = new MMOperationPriceConfigsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMOperationPriceConfigsTableName, new MMOperationPriceConfigsInfo());
            ModuleObjects.Add(TableName.MMOperationPriceConfigItemsTableName, new MMOperationPriceConfigItemsInfo());
        }

        public override void InitModuleObjectList()
        {

            OperationPriceConfigItemList.InitBOSList(
                                        this,
                                        TableName.MMOperationPriceConfigsTableName,
                                        TableName.MMOperationPriceConfigItemsTableName,
                                        BOSList<MMOperationPriceConfigItemsInfo>.cstRelationForeign);
            OperationPriceConfigItemList.ItemTableForeignKey = "FK_MMOperationPriceConfigID";

        }

        public override void InitGridControlInBOSList()
        {
            OperationPriceConfigItemList.InitBOSListGridControl("fld_dgcMMOperationPriceConfigItems");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMOperationPriceConfigsInfo objOperationPriceConfigsInfo = (MMOperationPriceConfigsInfo)MainObject;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                OperationPriceConfigItemList.SetDefaultListAndRefreshGridControl();

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
            OperationPriceConfigItemList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            MMOperationPriceConfigsInfo objOperationPriceConfigsInfo = (MMOperationPriceConfigsInfo)MainObject;
            OperationPriceConfigItemList.SaveItemObjects();
        }

        public void ApproveOperationPriceConfig()
        {
            SetPropertyChangeEventLock(false);
            //Update the this's status
            MMOperationPriceConfigsInfo objOperationPriceConfigsInfo = (MMOperationPriceConfigsInfo)MainObject;
            objOperationPriceConfigsInfo.MMOperationPriceConfigStatus = BatchProductPlanStatus.Approved.ToString();
            UpdateMainObject();
        }

        #endregion Override BaseTransactionEntities
    }
}
