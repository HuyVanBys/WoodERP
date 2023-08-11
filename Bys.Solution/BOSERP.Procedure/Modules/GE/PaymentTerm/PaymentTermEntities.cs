using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.PaymentTerm
{
    public class PaymentTermEntities : ERPModuleEntities
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets GEPaymentTermsInfo list
        /// </summary>
        public BOSList<GEPaymentTermsInfo> PaymentTermsList { get; set; }
        public BOSItemsEntityList<GEPaymentTermItemsInfo> GEPaymentTermItemList { get; set; }
        #endregion

        #region Constructor
        public PaymentTermEntities()
            : base()
        {
            PaymentTermsList = new BOSList<GEPaymentTermsInfo>();
            GEPaymentTermItemList = new BOSItemsEntityList<GEPaymentTermItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new GEPaymentTermsInfo();
        }
        #endregion

        #region Module Objects functions

        public override void InitModuleObjects()
        {
            // ModuleObjects.Add(TableName.GEPaymentTermsTableName, new GEPaymentTermsInfo());
            ModuleObjects.Add(TableName.GEPaymentTermItemsTableName, new GEPaymentTermItemsInfo());
        }


        public override void InitModuleObjectList()
        {

            //PaymentTermsList.InitBOSList(this,
            //                                   TableName.GEPaymentTermsTableName,
            //                                   string.Empty,
            //                                   BOSList<GEPaymentTermsInfo>.cstRelationNone);
            GEPaymentTermItemList.InitBOSList(this,
                                                              TableName.GEPaymentTermsTableName,
                                                              TableName.GEPaymentTermItemsTableName,
                                                              BOSItemsEntityList<GEPaymentTermItemsInfo>.cstRelationForeign);
            GEPaymentTermItemList.ItemTableForeignKey = "FK_GEPaymentTermID";
        }

        public override void InitGridControlInBOSList()
        {
            GEPaymentTermItemList.InitBOSListGridControl("fld_dgcPaymentTermItem");

        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                GEPaymentTermItemList.SetDefaultListAndRefreshGridControl();

            }
            catch (Exception)
            {
                return;
            }
        }
        public override void InvalidateModuleObjects(int iObjectID)
        {
            GEPaymentTermItemList.Invalidate(iObjectID);


        }
        #endregion

        #region Save Module Objects Functions
        public override void SaveModuleObjects()
        {
            UpdateMainObject();
            GEPaymentTermItemList.SaveItemObjects();
        }


        #endregion
    }
}
