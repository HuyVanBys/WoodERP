using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.AssembleProduct
{
    public class AssembleProductEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSItemsEntityList<ICAssembleProductDetailsInfo> ICAssembleProductDetailsList { get; set; }
        #endregion

        #region Constructor
        public AssembleProductEntities()
            : base()
        {
            ICAssembleProductDetailsList = new BOSItemsEntityList<ICAssembleProductDetailsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICAssembleProductsInfo();
            SearchObject = new ICAssembleProductsInfo();
        }

        public override void InitModuleObjectList()
        {
            ICAssembleProductDetailsList.InitBOSList(
                                              this,
                                              TableName.ICAssembleProductsTableName,
                                              TableName.ICAssembleProductDetailsTableName,
                                              BOSItemsEntityList<ICAssembleProductDetailsInfo>.cstRelationForeign);
            ICAssembleProductDetailsList.ItemTableForeignKey = "FK_ICAssembleProductID";
        }
        #endregion

        public override void InitGridControlInBOSList()
        {
            ICAssembleProductDetailsList.InitBOSListGridControl();

        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ICAssembleProductDetailsList.SetDefaultListAndRefreshGridControl();

            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICAssembleProductDetailsList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            ICAssembleProductDetailsList.SaveItemObjects();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ICAssembleProductsInfo revenueBudget = (ICAssembleProductsInfo)MainObject;
            revenueBudget.ICAssembleProductDate = DateTime.Now;
            revenueBudget.ICAssembleProductStatus = AssembleProductStatus.New.ToString();


            UpdateMainObjectBindingSource();

        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICAssembleProductDetailsTableName, new ICAssembleProductDetailsInfo());
        }

        public override int CreateMainObject()
        {
            ICAssembleProductsInfo objReceiptsInfo = (ICAssembleProductsInfo)MainObject;
            int iObjectID = 0;

            iObjectID = base.CreateMainObject();
            if (iObjectID > 0)
            {
                GENumberingController objGENumberingController = new GENumberingController();
                GENumberingInfo objGENumberingInfo = (GENumberingInfo)objGENumberingController.GetObjectByName("ProductSerialNo");
                if (objGENumberingInfo != null)
                {


                    objGENumberingInfo.GENumberingStart++;
                    UpdateProductLotNo(objGENumberingInfo.GENumberingStart);


                }
            }
            return iObjectID;
        }
    }
}
