using BOSCommon;
using System;

namespace BOSERP.Modules.MergeBOMChange
{
    public class MergeBOMChangeEntities : BaseTransactionEntities
    {
        #region Public Properties
        public BOSList<MMMergeBOMChangeBatchProductsInfo> BatchProductList { get; set; }
        public BOSList<MMMergeBOMChangeItemBOMLogsInfo> ItemBOMLogList { get; set; }
        public BOSList<MMMergeBOMChangeItemBPLogsInfo> ItemBPLogList { get; set; }
        public BOSList<MMMergeBOMChangeItemProcessBOMLogsInfo> ItemProcessBOMLogList { get; set; }
        public BOSList<MMMergeBOMChangeItemProcessBPLogsInfo> ItemProcessBPLogList { get; set; }
        public BOSList<MMMergeBOMChangeItemMaterialBOMLogsInfo> ItemMaterialBOMLogList { get; set; }
        public BOSList<MMMergeBOMChangeItemMaterialBPLogsInfo> ItemMaterialBPLogList { get; set; }
        #endregion

        #region Contructors
        public MergeBOMChangeEntities()
            : base()
        {
            BatchProductList = new BOSList<MMMergeBOMChangeBatchProductsInfo>();
            ItemBOMLogList = new BOSList<MMMergeBOMChangeItemBOMLogsInfo>();
            ItemBPLogList = new BOSList<MMMergeBOMChangeItemBPLogsInfo>();
            ItemProcessBOMLogList = new BOSList<MMMergeBOMChangeItemProcessBOMLogsInfo>();
            ItemProcessBPLogList = new BOSList<MMMergeBOMChangeItemProcessBPLogsInfo>();
            ItemMaterialBOMLogList = new BOSList<MMMergeBOMChangeItemMaterialBOMLogsInfo>();
            ItemMaterialBPLogList = new BOSList<MMMergeBOMChangeItemMaterialBPLogsInfo>();
        }
        #endregion Contructors

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMMergeBOMChangesInfo();
            SearchObject = new MMMergeBOMChangesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("MMMergeBOMChangeBatchProducts", new MMMergeBOMChangeBatchProductsInfo());
            ModuleObjects.Add("MMMergeBOMChangeItemBOMLogs", new MMMergeBOMChangeItemBOMLogsInfo());
            ModuleObjects.Add("MMMergeBOMChangeItemBPLogs", new MMMergeBOMChangeItemBPLogsInfo());
            ModuleObjects.Add("MMMergeBOMChangeItemProcessBOMLogs", new MMMergeBOMChangeItemProcessBOMLogsInfo());
            ModuleObjects.Add("MMMergeBOMChangeItemProcessBPLogs", new MMMergeBOMChangeItemProcessBPLogsInfo());
            ModuleObjects.Add("MMMergeBOMChangeItemMaterialBOMLogs", new MMMergeBOMChangeItemMaterialBOMLogsInfo());
            ModuleObjects.Add("MMMergeBOMChangeItemMaterialBPLogs", new MMMergeBOMChangeItemMaterialBPLogsInfo());
        }

        public override void InitModuleObjectList()
        {
            BatchProductList.InitBOSList(this, "MMMergeBOMChanges", "MMMergeBOMChangeBatchProducts", BOSList<MMMergeBOMChangeBatchProductsInfo>.cstRelationForeign);
            BatchProductList.ItemTableForeignKey = "FK_MMMergeBOMChangeID";

            ItemBOMLogList.InitBOSList(this, "MMMergeBOMChanges", "MMMergeBOMChangeItemBOMLogs", BOSList<MMMergeBOMChangeItemBOMLogsInfo>.cstRelationForeign);
            ItemBOMLogList.ItemTableForeignKey = "FK_MMMergeBOMChangeID";

            ItemBPLogList.InitBOSList(this, "MMMergeBOMChanges", "MMMergeBOMChangeItemBPLogs", BOSList<MMMergeBOMChangeItemBPLogsInfo>.cstRelationForeign);
            ItemBPLogList.ItemTableForeignKey = "FK_MMMergeBOMChangeID";

            ItemProcessBOMLogList.InitBOSList(this, "MMMergeBOMChanges", "MMMergeBOMChangeItemProcessBOMLogs", BOSList<MMMergeBOMChangeItemProcessBOMLogsInfo>.cstRelationForeign);
            ItemProcessBOMLogList.ItemTableForeignKey = "FK_MMMergeBOMChangeID";

            ItemProcessBPLogList.InitBOSList(this, "MMMergeBOMChanges", "MMMergeBOMChangeItemProcessBPLogs", BOSList<MMMergeBOMChangeItemProcessBPLogsInfo>.cstRelationForeign);
            ItemProcessBPLogList.ItemTableForeignKey = "FK_MMMergeBOMChangeID";

            ItemMaterialBOMLogList.InitBOSList(this, "MMMergeBOMChanges", "MMMergeBOMChangeItemMaterialBOMLogs", BOSList<MMMergeBOMChangeItemMaterialBOMLogsInfo>.cstRelationForeign);
            ItemMaterialBOMLogList.ItemTableForeignKey = "FK_MMMergeBOMChangeID";

            ItemMaterialBPLogList.InitBOSList(this, "MMMergeBOMChanges", "MMMergeBOMChangeItemMaterialBPLogs", BOSList<MMMergeBOMChangeItemMaterialBPLogsInfo>.cstRelationForeign);
            ItemMaterialBPLogList.ItemTableForeignKey = "FK_MMMergeBOMChangeID";
        }

        public override void InitGridControlInBOSList()
        {
            BatchProductList.InitBOSListGridControl();
            ItemBOMLogList.InitBOSListGridControl();
            ItemBPLogList.InitBOSListGridControl();
            ItemProcessBOMLogList.InitBOSListGridControl();
            ItemProcessBPLogList.InitBOSListGridControl();
            ItemMaterialBOMLogList.InitBOSListGridControl();
            ItemMaterialBPLogList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            MMMergeBOMChangesInfo objMergeBOMChangesInfo = (MMMergeBOMChangesInfo)MainObject;
            objMergeBOMChangesInfo.MMMergeBOMChangeDate = DateTime.Now;
            objMergeBOMChangesInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objMergeBOMChangesInfo.MMMergeBOMChangeStatus = Status.New.ToString();
            objMergeBOMChangesInfo.MMMergeBOMChangeType = MergeBOMChangeType.WoodStatus.ToString();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                BatchProductList.SetDefaultListAndRefreshGridControl();
                ItemBOMLogList.SetDefaultListAndRefreshGridControl();
                ItemBPLogList.SetDefaultListAndRefreshGridControl();
                ItemProcessBOMLogList.SetDefaultListAndRefreshGridControl();
                ItemProcessBPLogList.SetDefaultListAndRefreshGridControl();
                ItemMaterialBOMLogList.SetDefaultListAndRefreshGridControl();
                ItemMaterialBPLogList.SetDefaultListAndRefreshGridControl();
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
            BatchProductList.Invalidate(iObjectID);
            ItemBOMLogList.Invalidate(iObjectID);
            ItemBPLogList.Invalidate(iObjectID);
            ItemProcessBOMLogList.Invalidate(iObjectID);
            ItemProcessBPLogList.Invalidate(iObjectID);
            ItemMaterialBOMLogList.Invalidate(iObjectID);
            ItemMaterialBPLogList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();

            BatchProductList.SaveItemObjects();
            ItemBOMLogList.SaveItemObjects();
            ItemBPLogList.SaveItemObjects();
            ItemProcessBOMLogList.SaveItemObjects();
            ItemProcessBPLogList.SaveItemObjects();
            ItemMaterialBOMLogList.SaveItemObjects();
            ItemMaterialBPLogList.SaveItemObjects();

        }

        #endregion Override BaseTransactionEntities

        public override bool CompleteTransaction()
        {
            SetPropertyChangeEventLock(false);
            MMMergeBOMChangesInfo mainObject = (MMMergeBOMChangesInfo)MainObject;

            if (mainObject.MMMergeBOMChangeStatus == Status.New.ToString())
            {
                mainObject.MMMergeBOMChangeStatus = Status.Complete.ToString();
                UpdateMainObject();
            }


            UpdateMainObjectBindingSource();
            SetPropertyChangeEventLock(true);
            return base.CompleteTransaction();
        }

    }
}
