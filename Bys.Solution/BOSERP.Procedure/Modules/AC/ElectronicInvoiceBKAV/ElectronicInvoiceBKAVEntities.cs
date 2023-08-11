using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

namespace BOSERP.Modules.ElectronicInvoiceBKAV
{
    public class ElectronicInvoiceBKAVEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ACEInvoiceDetailsInfo> EInvoiceDetailsList { get; set; }
        public BOSList<ACFileAttachmentsInfo> EInvoiceTemplateList { get; set; }
        public Dictionary<int, string> EInvoiceTemplateURLDic { get; set; }
        #endregion

        #region Constructor
        public ElectronicInvoiceBKAVEntities() : base()
        {
            EInvoiceDetailsList = new BOSList<ACEInvoiceDetailsInfo>();
            EInvoiceTemplateList = new BOSList<ACFileAttachmentsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACEInvoiceGeneralsInfo();
            SearchObject = new ACEInvoiceGeneralsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACEInvoiceDetailsTableName, new ACEInvoiceDetailsInfo());
        }

        public override void InitModuleObjectList()
        {
            EInvoiceDetailsList.InitBOSList(this,
                                            TableName.ACEInvoiceGeneralsTableName,
                                            TableName.ACEInvoiceDetailsTableName,
                                            BOSList<ACEInvoiceDetailsInfo>.cstRelationForeign);

            EInvoiceTemplateList.InitBOSList(this,
                                            TableName.ACEInvoiceGeneralsTableName,
                                            TableName.ACFileAttachmentsTableName,
                                            BOSList<ACFileAttachmentsInfo>.cstRelationForeign);
        }

        public override void InitGridControlInBOSList()
        {
            EInvoiceDetailsList.InitBOSListGridControl();
            EInvoiceTemplateList.InitBOSListGridControl(ElectronicInvoiceBKAVModule.EInvoiceGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                EInvoiceDetailsList.SetDefaultListAndRefreshGridControl();
                EInvoiceTemplateList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)MainObject;
            mainObject.InvoiceIssuedDate = BOSApp.GetCurrentServerDate();
            mainObject.PaymentStatus = string.Empty;
            mainObject.AdditionalReferenceDate = (DateTime)SqlDateTime.MinValue;
            ACTaxUnitsController objTaxUnitsController = new ACTaxUnitsController();
            List<ACTaxUnitsInfo> listTaxUnitsInfo = objTaxUnitsController.GetAllACTaxUnits();
            if (listTaxUnitsInfo != null && listTaxUnitsInfo.Count == 1)
            {
                mainObject.FK_ACTaxUnitID = listTaxUnitsInfo.FirstOrDefault().ACTaxUnitID;
            }
            //mainObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }
        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)MainObject;
            mainObject.ACObjectAccessKey = mainObject.FK_ACObjectID + ";" + mainObject.ACObjectType;
            UpdateMainObjectBindingSource();
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            EInvoiceDetailsList.Invalidate(iObjectID);
            EInvoiceDetailsList.ForEach(p => p.ACEInvoiceDetailTotalAmount = p.Quantity * p.UnitPrice);
            ACEInvoiceGeneralsInfo mainObject = (ACEInvoiceGeneralsInfo)MainObject;
            ACFileAttachmentsController objFileAttachmentsController = new ACFileAttachmentsController();
            List<ACFileAttachmentsInfo> fileAttachmentList = objFileAttachmentsController.GetFileAttachmentByModuleAndObjectRef(this.Module.Name, BOSUtil.GetTableNameFromBusinessObject(mainObject), mainObject.ACEInvoiceGeneralID, 0);
            EInvoiceTemplateList.Invalidate(fileAttachmentList);

        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            EInvoiceDetailsList.SaveItemObjects();
            EInvoiceTemplateList.SaveItemObjects();
            EInvoiceTemplateURLDic = EInvoiceTemplateList.ToDictionary(o => o.ACFileAttachmentID, o => o.FullPathFile);
        }
        #endregion

        public override void DuplicateModuleObjectList()
        {
            EInvoiceDetailsList.Duplicate();
        }
    }
}
