using BOSCommon.Constants;
using BOSCommon.Enums;
using BOSLib.Extensions;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.InventoryStockCount
{
    public class InventoryStockCountEntities : BaseTransactionEntities
    {
        #region Declare all entities variables
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets ICInventoryStockCount list
        /// </summary>
        public BOSList<ICInventoryStockCountItemsInfo> InventoryStockCountItemsList { get; set; }
        public List<ICInventoryStockCountItemsInfo> DeletedItems { get; set; }

        public List<ICInventoryStockCountItemsInfo> PrintQCodeItemsList { get; set; }
        #endregion

        #region Constructor
        public InventoryStockCountEntities()
            : base()
        {
            InventoryStockCountItemsList = new BOSList<ICInventoryStockCountItemsInfo>();
            PrintQCodeItemsList = new BOSList<ICInventoryStockCountItemsInfo>();
            DeletedItems = new List<ICInventoryStockCountItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICInventoryStockCountsInfo();
            SearchObject = new ICInventoryStockCountsInfo();
        }
        #endregion

        #region Module Objects functions

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICInventoryStockCountItemsTableName, new ICInventoryStockCountItemsInfo());
        }

        public override void InitModuleObjectList()
        {

            InventoryStockCountItemsList.InitBOSList(this,
                                               TableName.ICInventoryStockCountsTableName,
                                               TableName.ICInventoryStockCountItemsTableName,
                                               BOSList<ICProductsInfo>.cstRelationForeign);
            InventoryStockCountItemsList.ItemTableForeignKey = "FK_ICInventoryStockCountID";

        }

        public override void InitGridControlInBOSList()
        {
            InventoryStockCountItemsList.InitBOSListGridControl(InventoryStockCountModule.StockBarCodeResultGridControl);
            DocumentEntryList.InitBOSListGridControl("fld_dgcACDocumentEntrys");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ICInventoryStockCountsInfo mainObject = MainObject as ICInventoryStockCountsInfo;
            mainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            mainObject.ICInventoryStockCountType = InventoryStockCountType.Package.ToString();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                InventoryStockCountItemsList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }
        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            //InventoryStockCountItemsList.Invalidate(iObjectID);
        }
        #endregion
        public override void SaveModuleObjects()
        {
            InventoryStockCountItemsList.SaveItemCDObjects();
            DeletedItems.DeleteObject();
        }
        #endregion
    }
}
