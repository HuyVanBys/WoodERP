using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Data;
using System.Collections.Generic;

namespace BOSERP.Modules.EInvoiceConfig
{
    public class EInvoiceConfigEntities : ERPModuleEntities
    {
        #region Constants
        #endregion

        #region Variables
        /// <summary>
        /// A variable to store the company info
        /// </summary>
        private CSCompanysInfo Company;
        #endregion

        #region Public Properties
        public BOSList<ACEInvoiceConfigsInfo> BKAVEInvoiceConfigsList { get; set; }
        public BOSList<ACEInvoiceConfigsInfo> MInvoiceEInvoiceConfigsList { get; set; }
        public BOSList<ACEInvoiceTypesInfo> ACEInvoiceTypesList { get; set; }
        public BOSList<ACEInvoicePaymentMethodsInfo> ACEInvoicePaymentMethodsList { get; set; }
        #endregion

        #region Constructor
        public EInvoiceConfigEntities()
            : base()
        {
            BKAVEInvoiceConfigsList = new BOSList<ACEInvoiceConfigsInfo>();
            MInvoiceEInvoiceConfigsList = new BOSList<ACEInvoiceConfigsInfo>();
            ACEInvoiceTypesList = new BOSList<ACEInvoiceTypesInfo>();
            ACEInvoicePaymentMethodsList = new BOSList<ACEInvoicePaymentMethodsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitModuleObjects()
        {
            base.InitModuleObjects();
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ACEInvoiceConfigsController objPNF = new ACEInvoiceConfigsController();
            List<ACEInvoiceConfigsInfo> listEInvoiceConfigsInfo = objPNF.GetListEInvoiceConfigByPartnerType(EInvoiceConfigPartnerType.BKAV.ToString());
            BKAVEInvoiceConfigsList.Invalidate(listEInvoiceConfigsInfo);

            listEInvoiceConfigsInfo = objPNF.GetListEInvoiceConfigByPartnerType(EInvoiceConfigPartnerType.MInvoice.ToString());
            MInvoiceEInvoiceConfigsList.Invalidate(listEInvoiceConfigsInfo);

            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            DataSet ds = objEInvoiceTypesController.GetListEInvoiceTypesByTypeCombo(InvoiceTypeCombo.Sell.ToString());
            ACEInvoiceTypesList.Invalidate(ds);

            ds = (new ACEInvoicePaymentMethodsController()).GetAllObjects();
            ACEInvoicePaymentMethodsList.Invalidate(ds);
            ds.Dispose();
        }

        public override void InitModuleObjectList()
        {
            BKAVEInvoiceConfigsList.InitBOSList(this,
                                          String.Empty,
                                          "ACEInvoiceConfigs",
                                          BOSList<ACEInvoiceConfigsInfo>.cstRelationNone);

            MInvoiceEInvoiceConfigsList.InitBOSList(this,
                                          String.Empty,
                                          "ACEInvoiceConfigs",
                                          BOSList<ACEInvoiceConfigsInfo>.cstRelationNone);

            ACEInvoiceTypesList.InitBOSList(this,
                                          String.Empty,
                                          TableName.ACEInvoiceTypesTableName,
                                          BOSList<ACEInvoiceTypesInfo>.cstRelationNone);

            ACEInvoicePaymentMethodsList.InitBOSList(this,
                                         String.Empty,
                                         "ACEInvoicePaymentMethods",
                                         BOSList<ACEInvoicePaymentMethodsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            BKAVEInvoiceConfigsList.InitBOSListGridControl("fld_dgcACEInvoiceConfigBKAVs");
            MInvoiceEInvoiceConfigsList.InitBOSListGridControl("fld_dgcACEInvoiceConfigMInvoices");
            ACEInvoiceTypesList.InitBOSListGridControl();
            ACEInvoicePaymentMethodsList.InitBOSListGridControl();
        }
        #endregion


        public override void SaveModuleObjects()
        {
            BKAVEInvoiceConfigsList.SaveItemObjects();
            MInvoiceEInvoiceConfigsList.SaveItemObjects();
            ACEInvoiceTypesList.SaveItemObjects();
            ACEInvoicePaymentMethodsList.SaveItemObjects();
        }
    }
}
