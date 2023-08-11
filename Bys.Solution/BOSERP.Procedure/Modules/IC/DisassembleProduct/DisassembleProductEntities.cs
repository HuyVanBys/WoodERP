using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.DisassembleProduct
{
    public class DisassembleProductEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSItemsEntityList<ICDisassembleProductDetailsInfo> ICDisassembleProductDetailsList { get; set; }
        #endregion

        #region Constructor
        public DisassembleProductEntities()
            : base()
        {
            ICDisassembleProductDetailsList = new BOSItemsEntityList<ICDisassembleProductDetailsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICDisassembleProductsInfo();
            SearchObject = new ICDisassembleProductsInfo();
        }

        public override void InitModuleObjectList()
        {
            ICDisassembleProductDetailsList.InitBOSList(
                                              this,
                                              TableName.ICDisassembleProductsTableName,
                                              TableName.ICDisassembleProductDetailsTableName,
                                              BOSItemsEntityList<ICDisassembleProductDetailsInfo>.cstRelationForeign);
            ICDisassembleProductDetailsList.ItemTableForeignKey = "FK_ICDisassembleProductID";
        }
        #endregion

        public override void InitGridControlInBOSList()
        {
            ICDisassembleProductDetailsList.InitBOSListGridControl();

        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ICDisassembleProductDetailsList.SetDefaultListAndRefreshGridControl();

            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICDisassembleProductDetailsList.Invalidate(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            ICDisassembleProductDetailsList.SaveItemObjects();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ICDisassembleProductsInfo revenueBudget = (ICDisassembleProductsInfo)MainObject;
            revenueBudget.ICDisassembleProductDate = DateTime.Now;
            revenueBudget.ICDisassembleProductStatus = DisassembleProductStatus.New.ToString();


            UpdateMainObjectBindingSource();

        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICDisassembleProductDetailsTableName, new ICDisassembleProductDetailsInfo());
        }


    }
}
