




using BOSCommon;
using BOSLib;
using System;

namespace BOSERP.Modules.Stock
{
    public class StockEntities : ERPModuleEntities
    {
        #region Declare Constant
        public readonly static String strICStocksObjectName = "ICStocks";

        public readonly static String strICStockSlotsObjectName = "ICStockSlots";
        #endregion

        #region Declare all entities variables

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets stock parent id
        /// </summary>
        public int StockParentID { get; set; }
        #endregion

        #region Constructor
        public StockEntities()
            : base()
        {
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {

            MainObject = new ICStocksInfo();
        }

        public override void InitModuleObjects()
        {

        }

        public override void InitModuleObjectList()
        {

        }

        public override void InitGridControlInBOSList()
        {

        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ICStocksInfo objStocksInfo = (ICStocksInfo)MainObject;
            objStocksInfo.ICStockType = StockType.Sale.ToString();
            objStocksInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
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

            StockParentID = iObjectID;
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
        }

        #endregion

        #region Save Module Objects functions

        public override int SaveMainObject()
        {
            ICStocksInfo objStocksInfo = (ICStocksInfo)MainObject;
            if (objStocksInfo.ICStockID == 0)
            {
                objStocksInfo.ICStockParentID = StockParentID;
            }
            objStocksInfo.ICStockContactAddressLine3 = BOSUtil.GenerateFullAddress(MainObject, AddressType.Contact.ToString());

            int stockID = base.SaveMainObject();
            return stockID;
        }
        public override void SaveModuleObjects()
        {
        }

        #endregion

        public override void Delete(int iObjectID)
        {
            ICStocksInfo objStocksInfo = (ICStocksInfo)MainObject;
            iObjectID = objStocksInfo.ICStockID;
            base.Delete(iObjectID);
        }

    }
}
