using BOSLib;
using System;

namespace BOSERP.Modules.InventoryAdjustment
{
    class InventoryAdjustmentEntities : BaseTransactionEntities
    {
        #region Declare Constant
        public readonly static String strICAdjustmentObjectName = "ICAdjustments";

        public readonly static String strICAdjustmentItemsObjectName = "ICAdjustmentItems";
        #endregion

        #region Declare all entities variables
        private ICAdjustmentsInfo _iCAdjustmentsObject;
        private ICAdjustmentItemsInfo _iCAdjustmentItemsObject;
        //private BOSList<ICAdjustmentItemsInfo> _lstICAdjustmentItems;
        public BOSItemsEntityList<InventoryAdjustmentItemsEntity> lstICAdjustmentItems;

        #endregion

        #region Public Properties
        public ICAdjustmentsInfo ICAdjustmentsObject
        {
            get
            {
                return _iCAdjustmentsObject;
            }
            set
            {
                _iCAdjustmentsObject = value;
            }
        }
        public ICAdjustmentItemsInfo ICAdjustmentItemsObject
        {
            get
            {
                return _iCAdjustmentItemsObject;
            }
            set
            {
                _iCAdjustmentItemsObject = value;
            }
        }

        //public BOSList<ICAdjustmentItemsInfo> ICAdjustmentItemsList
        //{
        //    get
        //    {
        //        return _lstICAdjustmentItems;
        //    }
        //    set
        //    {
        //        _lstICAdjustmentItems = value;
        //    }
        //}

        public BOSItemsEntityList<InventoryAdjustmentItemsEntity> ICAdjustmentItemsList
        {
            get
            {
                return lstICAdjustmentItems;
            }
            set
            {
                lstICAdjustmentItems = value;
            }
        }

        #endregion

        #region Constructor
        public InventoryAdjustmentEntities()
            : base()
        {
            _iCAdjustmentsObject = new ICAdjustmentsInfo();

            _iCAdjustmentItemsObject = new ICAdjustmentItemsInfo();

            lstICAdjustmentItems = new BOSItemsEntityList<InventoryAdjustmentItemsEntity>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = ICAdjustmentsObject;

        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("ICAdjustmentItems", ICAdjustmentItemsObject);
        }

        public override void InitModuleObjectList()
        {
            //ICAdjustmentItemsList = new BOSList<ICAdjustmentItemsInfo>();
            //ICAdjustmentItemsList.InitBOSList(this, "ICAdjustments", "ICAdjustmentItems");
            //ICPromotionItemDetailsList = new BOSList<ICPromotionItemDetailsInfo>();
            //ICPromotionItemDetailsList.InitBOSList(this, BOSUtil.GetTableNameFromBusinessObjectType(typeof(ICPromotionItemDetailsInfo)));
            //ICPromotionItemDetailsList.InitBOSList(this, "ICPromotionItems", "ICPromotionItemDetails");
            //----//
            //ICAdjustmentItemsList = new BOSItemsEntityList<InventoryAdjustmentItemsEntity>();
            //ICAdjustmentItemsList.InitBOSList(this, "ICAdjustments", "ICAdjustmentItems");
            //---//
            lstICAdjustmentItems = new BOSItemsEntityList<InventoryAdjustmentItemsEntity>();
            lstICAdjustmentItems.InitBOSList(this,
                                           BOSUtil.GetTableNameFromBusinessObjectType(typeof(ICAdjustmentsInfo)),
                                           BOSUtil.GetTableNameFromBusinessObjectType(typeof(ICAdjustmentItemsInfo)));
        }

        public override void InitGridControlInBOSList()
        {
            //ICAdjustmentItemsList.InitBOSListGridControl();
            lstICAdjustmentItems.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ICAdjustmentItemsList.SetDefaultListAndRefreshGridControl();
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
            ICAdjustmentItemsList.Invalidate(iObjectID);
        }
        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ICAdjustmentsInfo objAdjustmentsInfo = (ICAdjustmentsInfo)MainObject;
            objAdjustmentsInfo.ICAdjustmentDate = DateTime.Now;
            objAdjustmentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objAdjustmentsInfo.ICAdjustmentType = InventoryAdjustmentModule.cstAdjustmentTypeQty;
            objAdjustmentsInfo.ICAdjustmentStatus = InventoryAdjustmentModule.cstAdjustmentStatusNew;
            objAdjustmentsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            UpdateMainObjectBindingSource();
        }

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            ICAdjustmentItemsList.EndCurrentEdit();
            UpdateProductQty();
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            ICAdjustmentItemsList.EndCurrentEdit();
            ICAdjustmentItemsList.GridControl.RefreshDataSource();
            ICAdjustmentItemsList.SaveItemObjects();
        }

        public void UpdateProductQty()
        {
            decimal oldQty = 0;
            decimal qty = 0;
            decimal diffTotalCost = 0;
            foreach (InventoryAdjustmentItemsEntity entItem in ICAdjustmentItemsList)
            {
                oldQty += entItem.ICAdjustmentItemProductOldQty;
                qty += entItem.ICAdjustmentItemProductQty;
                diffTotalCost += entItem.ICAdjustmentItemDiffTotalCost;
            }

            ICAdjustmentsInfo objAdjustmentsInfo = (ICAdjustmentsInfo)MainObject;
            objAdjustmentsInfo.ICAdjustmentOldQty = oldQty;
            objAdjustmentsInfo.ICAdjustmentQty = qty;
            objAdjustmentsInfo.ICAdjustmentDiffQty = oldQty - qty;
            objAdjustmentsInfo.ICAdjustmentDiffTotalCost = diffTotalCost;
            UpdateMainObjectBindingSource();
        }
        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetProductByIDAndStockID(iICProductID, BOSApp.CurrentCompanyInfo.FK_ICStockID);
            if (objProductsInfo != null)
            {
                ICAdjustmentItemsInfo objICAdjustmentItemsInfo = (ICAdjustmentItemsInfo)ModuleObjects[InventoryAdjustmentEntities.strICAdjustmentItemsObjectName];
                objICAdjustmentItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                base.SetValuesAfterValidateProduct(objProductsInfo.ICProductID);
                objICAdjustmentItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
                objICAdjustmentItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
                objICAdjustmentItemsInfo.FK_ICStockID = ((ICAdjustmentsInfo)MainObject).FK_ICStockID;
                objICAdjustmentItemsInfo.ICAdjustmentItemProductAttribute = objProductsInfo.ICProductAttribute;
                objICAdjustmentItemsInfo.ICAdjustmentItemProductSerialNo = objProductsInfo.ICProductBarCode;
                objICAdjustmentItemsInfo.ICAdjustmentItemProductOldQty = objProductsInfo.ICInventoryStockQuantity;
                objICAdjustmentItemsInfo.ICAdjustmentItemProductQty = objICAdjustmentItemsInfo.ICAdjustmentItemProductOldQty;
                objICAdjustmentItemsInfo.ICAdjustmentItemProductDiffQty = objICAdjustmentItemsInfo.ICAdjustmentItemProductOldQty - objICAdjustmentItemsInfo.ICAdjustmentItemProductQty;
                objICAdjustmentItemsInfo.ICAdjustmentItemDiffTotalCost = (objICAdjustmentItemsInfo.ICAdjustmentItemProductOldQty - objICAdjustmentItemsInfo.ICAdjustmentItemProductQty) * objICAdjustmentItemsInfo.ICAdjustmentItemProductUnitCost;
                UpdateModuleObjectBindingSource(InventoryAdjustmentEntities.strICAdjustmentItemsObjectName);
            }
        }

        public override bool CompleteTransaction()
        {
            ICAdjustmentsInfo objICAdjustmentsInfo = (ICAdjustmentsInfo)MainObject;

            //Update status of adjustment
            objICAdjustmentsInfo.ICAdjustmentStatus = InventoryAdjustmentModule.cstAdjustmentStatusComplete;
            UpdateMainObject();

            return true;
        }
    }
}
