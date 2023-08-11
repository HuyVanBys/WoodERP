using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.SemiProductIngredient
{
    class SemiProductIngredientEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<MMSemiProductIngredientItemsInfo> SemiProductIngredientItemList { get; set; }

        #endregion

        #region Constructor
        public SemiProductIngredientEntities()
            : base()
        {
            SemiProductIngredientItemList = new BOSList<MMSemiProductIngredientItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new MMSemiProductIngredientsInfo();
            SearchObject = new MMSemiProductIngredientsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.MMSemiProductIngredientItemsTableName, new MMSemiProductIngredientItemsInfo());

        }

        public override void InitModuleObjectList()
        {

            SemiProductIngredientItemList.InitBOSList(
                                          this,
                                          TableName.MMSemiProductIngredientsTableName,
                                          TableName.MMSemiProductIngredientItemsTableName,
                                          BOSList<MMSemiProductIngredientItemsInfo>.cstRelationForeign);
            SemiProductIngredientItemList.ItemTableForeignKey = "FK_MMSemiProductIngredientID";
        }

        public override void InitGridControlInBOSList()
        {
            SemiProductIngredientItemList.InitBOSListGridControl("fld_dgcMMSemiProductIngredientItems");
            DocumentEntryList.InitBOSListGridControl(SemiProductIngredientModule.DocumentEntryGridControlName);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            MMSemiProductIngredientsInfo objSemiProductIngredientsInfo = (MMSemiProductIngredientsInfo)MainObject;
            objSemiProductIngredientsInfo.MMSemiProductIngredientStatus = MMProductionCostStatus.New.ToString();
            objSemiProductIngredientsInfo.MMSemiProductIngredientDate = DateTime.Now;
        }

        public override bool CompleteTransaction()
        {
            MMSemiProductIngredientsInfo objSemiProductIngredientsInfo = (MMSemiProductIngredientsInfo)MainObject;
            objSemiProductIngredientsInfo.MMSemiProductIngredientStatus = MMProductionCostStatus.Completed.ToString();
            UpdateMainObject();

            return base.CompleteTransaction();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                SemiProductIngredientItemList.SetDefaultListAndRefreshGridControl();

            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Main Objects ,Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            SemiProductIngredientItemList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            SemiProductIngredientItemList.SaveItemObjects();
            SaveAccountingData();
        }
        #endregion  

        public void UpdateTotalAmount()
        {
            MMSemiProductIngredientsInfo objSemiProductIngredientsInfo = (MMSemiProductIngredientsInfo)MainObject;
            objSemiProductIngredientsInfo.MMSemiProductIngredientTotalAmount = 0;
            foreach (MMSemiProductIngredientItemsInfo item in SemiProductIngredientItemList)
            {
                objSemiProductIngredientsInfo.MMSemiProductIngredientTotalAmount += item.MMSemiProductIngredientItemProductTotalAmount;
            }
            BOSApp.RoundByCurrency(objSemiProductIngredientsInfo, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }

        #region Accounting
        public override bool SaveAccountingData()
        {
            MMSemiProductIngredientsInfo objSemiProductIngredientsInfo = (MMSemiProductIngredientsInfo)MainObject;
            MMOperationsInfo objOperationsInfo = new MMOperationsInfo();
            MMOperationsController objOperationsController = new MMOperationsController();
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(objSemiProductIngredientsInfo.FK_MMOperationID);
            if (objOperationsInfo != null)
            {
                if (objOperationsInfo.MMOperationNo != OperationNo.Thanhpham.ToString())
                {
                    List<ACDocumentsInfo> docList = objDocumentsController.GetListItemByACDocumentNo(objSemiProductIngredientsInfo.MMSemiProductIngredientNo);
                    foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
                    {
                        BOSUtil.CopyObject(objSemiProductIngredientsInfo, objDocumentsInfo);
                        objDocumentsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                    }
                    if (docList != null)
                    {
                        foreach (ACDocumentsInfo item in docList)
                        {
                            objDocumentsController.DeleteByID(item.ACDocumentID);
                        }
                    }
                    foreach (ACDocumentEntrysInfo item in DocumentEntryList)
                    {
                        item.ACDocumentEntryID = 0;
                    }

                    return base.SaveAccountingData();
                }
                else
                {
                    List<ACDocumentsInfo> docList = objDocumentsController.GetListItemByACDocumentNo(objSemiProductIngredientsInfo.MMSemiProductIngredientNo);
                    foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
                    {
                        objDocumentsController.DeleteByID(objDocumentsInfo.ACDocumentID);
                    }

                }

            }
            return false;
        }
        #endregion
    }
}
