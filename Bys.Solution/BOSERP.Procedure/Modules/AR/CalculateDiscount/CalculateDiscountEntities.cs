using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.CalculateDiscount
{
    public class CalculateDiscountEntities : BaseTransactionEntities
    {
        #region Declare all entities variables

        #endregion

        #region Public Properties
        public BOSList<ARDiscountProgramsInfo> DiscountProgramsList { get; set; }

        public BOSList<ARCalculateDiscountItemsInfo> CalculateDiscountItemsList { get; set; }
        #endregion

        #region Constructor
        public CalculateDiscountEntities()
            : base()
        {
            DiscountProgramsList = new BOSList<ARDiscountProgramsInfo>();
            CalculateDiscountItemsList = new BOSList<ARCalculateDiscountItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARCalculateDiscountsInfo();
        }

        public override void InitModuleObjects()
        {

        }

        public override void InitModuleObjectList()
        {
            DiscountProgramsList.InitBOSList(this,
                                            string.Empty,
                                            TableName.ARDiscountProgramsTableName,
                                            BOSList<ARDiscountProgramsInfo>.cstRelationNone);

            CalculateDiscountItemsList.InitBOSList(this,
                                            string.Empty,
                                            TableName.ARCalculateDiscountItemsTableName,
                                            BOSList<ARCalculateDiscountItemsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            DiscountProgramsList.InitBOSListGridControl("fld_dgcARDiscountPrograms");
            CalculateDiscountItemsList.InitBOSListGridControl("fld_dgcARCalculateDiscountItems");
            DocumentEntryList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                DiscountProgramsList.SetDefaultListAndRefreshGridControl();
                CalculateDiscountItemsList.SetDefaultListAndRefreshGridControl();
                DocumentEntryList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
        }

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {

        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            CalculateDiscountItemsList.SaveItemCDObjects();
        }

        public void InvalidateCalculateDiscountItem(ARCalculateDiscountsInfo objCalculateDiscountsInfo)
        {
            //ARCalculateDiscountsInfo mainObject = (ARCalculateDiscountsInfo)MainObject;
            ARCalculateDiscountItemsController objCalculateDiscountItemsController = new ARCalculateDiscountItemsController();
            List<ARCalculateDiscountItemsInfo> calculateDiscountItemsList = objCalculateDiscountItemsController.GetItemByCalculateDiscountID(objCalculateDiscountsInfo.ARCalculateDiscountID);
            CalculateDiscountItemsList.Invalidate(calculateDiscountItemsList);
            CalculateDiscountItemsList.GridControl.RefreshDataSource();
        }
        #endregion
    }
}
