using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;

namespace BOSERP.Modules.Barcode
{
    public class BarcodeEntities : ERPModuleEntities
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets product list
        /// </summary>
        public BOSList<ICBarcodeItemsInfo> BarcodeItemsList { get; set; }
        #endregion

        #region Constructor
        public BarcodeEntities()
            : base()
        {
            BarcodeItemsList = new BOSList<ICBarcodeItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICBarcodesInfo();
            SearchObject = new ICBarcodesInfo();
        }
        #endregion

        #region Module Objects functions

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICBarcodeItemsTableName, new ICBarcodeItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            BarcodeItemsList.InitBOSList(this,
                                               string.Empty,
                                               TableName.ICBarcodeItemsTableName,
                                               BOSList<ICBarcodeItemsInfo>.cstRelationNone);
            BarcodeItemsList.InitBOSList(
                                        this,
                                        TableName.ICBarcodesTableName,
                                        TableName.ICBarcodeItemsTableName,
                                        BOSList<ICBarcodeItemsInfo>.cstRelationForeign);
            BarcodeItemsList.ItemTableForeignKey = "FK_ICBarcodeID";
        }

        public override void InitGridControlInBOSList()
        {
            BarcodeItemsList.InitBOSListGridControl("fld_dgcICBarcodeItems");
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ICBarcodesInfo objBarcodesInfo = (ICBarcodesInfo)MainObject;
            objBarcodesInfo.ICBarcodeDate = DateTime.Now;
            objBarcodesInfo.ICBarcodeStatus = BarcodeStatus.New.ToString();
            objBarcodesInfo.ICBarcodeNumber = 1;
            objBarcodesInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            UpdateMainObjectBindingSource();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                BarcodeItemsList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            BarcodeItemsList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            BarcodeItemsList.SaveItemObjects();
        }
        #endregion
    }
}
