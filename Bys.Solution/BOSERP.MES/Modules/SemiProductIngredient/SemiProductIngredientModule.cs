using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SemiProductIngredient
{
    class SemiProductIngredientModule : BaseTransactionModule
    {
        public const string OperationLookupEditControlName = "fld_lkeFK_MMOperationID";
        public const string DocumentEntryGridControlName = "fld_dgcACDocumentEntrys";

        public BOSLookupEdit OperationLookupEditControl = null;

        public SemiProductIngredientModule()
        {
            Name = "SemiProductIngredient";
            CurrentModuleEntity = new SemiProductIngredientEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            OperationLookupEditControl = (BOSLookupEdit)Controls[OperationLookupEditControlName];

        }

        private void InitializeOperationlookupDataSource()
        {
            //Công đoạn
            MMOperationsController objOperationsController = new MMOperationsController();
            List<MMOperationsInfo> objOperationsList = objOperationsController.GetOperationListForProductionCost();
            OperationLookupEditControl.Properties.DataSource = objOperationsList;
        }

        public override bool ActionComplete()
        {
            SemiProductIngredientEntities entity = (SemiProductIngredientEntities)CurrentModuleEntity;
            entity.SemiProductIngredientItemList.EndCurrentEdit();
            return base.ActionComplete();
        }

        public override void InvalidateToolbar()
        {
            MMSemiProductIngredientsInfo objSemiProductIngredientsInfo = (MMSemiProductIngredientsInfo)CurrentModuleEntity.MainObject;
            if (objSemiProductIngredientsInfo.MMSemiProductIngredientID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                if (objSemiProductIngredientsInfo.MMSemiProductIngredientStatus == MMProductionCostStatus.Completed.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                }
            }

            base.InvalidateToolbar();
        }

        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                SemiProductIngredientEntities entity = (SemiProductIngredientEntities)CurrentModuleEntity;
                entity.UpdateTotalAmount();
                UpdateDocumentEntries();
            }
        }

        public override int ActionSave()
        {
            UpdateTotalAmount();
            return base.ActionSave();
        }

        public void RemoveProductionCostItemList()
        {
            SemiProductIngredientEntities entity = (SemiProductIngredientEntities)CurrentModuleEntity;
            MMSemiProductIngredientItemsInfo objSemiProductIngredientItemsInfo = entity.SemiProductIngredientItemList[entity.SemiProductIngredientItemList.CurrentIndex];
            entity.SemiProductIngredientItemList.RemoveSelectedRowObjectFromList();
        }

        public void ShowIngredientCostDD(int batchProductID, int operationID, DateTime month)
        {
            //if (Toolbar.IsNullOrNoneAction())
            //{
            //    ActionEdit();
            //}
            SemiProductIngredientEntities entity = (SemiProductIngredientEntities)CurrentModuleEntity;
            MMSemiProductIngredientsInfo objShipmentsInfo = (MMSemiProductIngredientsInfo)entity.MainObject;

            //MMSemiProductIngredientItemsController objSemiProductIngredientItemsController = new MMSemiProductIngredientItemsController();
            //List<MMSemiProductIngredientItemsInfo> SemiProductIngredientItemsList = objSemiProductIngredientItemsController.GetReceiptByReceiptType(ReceiptType.ProductionReceipt.ToString());
            //guiFind<MMSemiProductIngredientItemsInfo> guiShowIngredientCostDD
            //  = new guiFind<MMSemiProductIngredientItemsInfo>(TableName.SemiProductIngredientItemsTableName,
            //                                SemiProductIngredientItemsList,
            //                                this,
            //                                false);
            guiShowIngredientCostDD guiShowIngredientCostDD = new guiShowIngredientCostDD(batchProductID, operationID, month);
            guiShowIngredientCostDD.Module = this;
            if (guiShowIngredientCostDD.ShowDialog() == DialogResult.OK)
            {
                if (guiShowIngredientCostDD.itemList.Count > 0)
                {
                    MMSemiProductIngredientItemsInfo objSemiProductIngredientItemsInfo = guiShowIngredientCostDD.itemList[0];
                    objShipmentsInfo.FK_MMBatchProductID = objSemiProductIngredientItemsInfo.FK_MMBatchProductID;
                    //objShipmentsInfo.FK_MMOperationID = objSemiProductIngredientItemsInfo.FK_MMOperationID;
                    objShipmentsInfo.MMSemiProductIngredientDate = guiShowIngredientCostDD.dateTime;
                    objShipmentsInfo.FK_MMProductionCostID = objSemiProductIngredientItemsInfo.FK_MMProductionCostID;
                    entity.SemiProductIngredientItemList.Clear();
                    foreach (MMSemiProductIngredientItemsInfo item in guiShowIngredientCostDD.itemList)
                    {
                        BOSApp.RoundByCurrency(item, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                        entity.SemiProductIngredientItemList.Add(item);
                    }

                    entity.SemiProductIngredientItemList.GridControl.InitGridControlDataSource();
                    UpdateTotalAmount();
                    entity.UpdateMainObjectBindingSource();
                }
            }
            else
            {
                ActionCancel();
            }
        }
        public override int GetDocumentTypeID()
        {
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            int documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.XuatKhoBTP.ToString());
            MMSemiProductIngredientsInfo objShipmentsInfo = (MMSemiProductIngredientsInfo)CurrentModuleEntity.MainObject;
            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(objShipmentsInfo.FK_MMOperationID);
            if (objOperationsInfo != null)
            {
                if (objOperationsInfo.MMOperationNo == OperationNo.Soche.ToString())
                {
                    documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentName.XuatKhoBTPCongDoanSoChe);
                }
                else if (objOperationsInfo.MMOperationNo == OperationNo.Tinhche.ToString())
                {
                    documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentName.XuatKhoBTPCongDoanTinhChe);
                }
                else if (objOperationsInfo.MMOperationNo == OperationNo.Laprap.ToString())
                {
                    documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentName.XuatKhoBTPCongDoanLapRap);
                }
                else if (objOperationsInfo.MMOperationNo == OperationNo.Son.ToString())
                {
                    documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentName.XuatKhoBTPCongDoanSon);
                }
                else if (objOperationsInfo.MMOperationNo == OperationNo.Donggoi.ToString())
                {
                    documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentName.XuatBTPCongDoanDongGoi);
                }
                else if (objOperationsInfo.MMOperationNo == OperationNo.Thanhpham.ToString())
                {
                    documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentName.DongGoiQuaThanhPham);
                }
                else
                {
                    documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.XuatKhoBTP.ToString());
                }
            }
            return documentTypeID;
        }

        public override void GenerateAccountingData()
        {
            SemiProductIngredientEntities entity = (SemiProductIngredientEntities)CurrentModuleEntity;
            MMSemiProductIngredientsInfo objShipmentsInfo = (MMSemiProductIngredientsInfo)entity.MainObject;
            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(objShipmentsInfo.FK_MMOperationID);
            if (objOperationsInfo != null)
            {
                if (objOperationsInfo.MMOperationNo == OperationNo.Soche.ToString())
                {
                    GenerateAccountingData(new string[] { AccDocumentName.XuatKhoBTPCongDoanSoChe });
                }
                else if (objOperationsInfo.MMOperationNo == OperationNo.Tinhche.ToString())
                {
                    GenerateAccountingData(new string[] { AccDocumentName.XuatKhoBTPCongDoanTinhChe });
                }
                else if (objOperationsInfo.MMOperationNo == OperationNo.Laprap.ToString())
                {
                    GenerateAccountingData(new string[] { AccDocumentName.XuatKhoBTPCongDoanLapRap });
                }
                else if (objOperationsInfo.MMOperationNo == OperationNo.Son.ToString())
                {
                    GenerateAccountingData(new string[] { AccDocumentName.XuatKhoBTPCongDoanSon });
                }
                else if (objOperationsInfo.MMOperationNo == OperationNo.Donggoi.ToString())
                {
                    GenerateAccountingData(new string[] { AccDocumentName.XuatBTPCongDoanDongGoi });
                }
                else
                {
                    GenerateAccountingData(new string[] { AccDocumentType.XuatKhoBTP.ToString() });
                }
            }
            else
            {
                GenerateAccountingData(new string[] { AccDocumentType.XuatKhoBTP.ToString() });
            }

        }

        protected override void UpdateDocumentEntries()
        {
            SemiProductIngredientEntities entity = (SemiProductIngredientEntities)CurrentModuleEntity;
            MMSemiProductIngredientsInfo objShipmentsInfo = (MMSemiProductIngredientsInfo)entity.MainObject;

            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(objShipmentsInfo.FK_MMOperationID);
            string documentType = AccDocumentType.XuatKhoBTP.ToString();
            string entryType = AccEntryType.XuatKhoBTP.ToString();
            if (objOperationsInfo != null)
            {
                if (objOperationsInfo.MMOperationNo == OperationNo.Soche.ToString())
                {
                    documentType = AccDocumentName.XuatKhoBTPCongDoanSoChe;
                    entryType = AccEntryName.XuatKhoBTPCongDoanSoChe;
                }
                else if (objOperationsInfo.MMOperationNo == OperationNo.Tinhche.ToString())
                {
                    documentType = AccDocumentName.XuatKhoBTPCongDoanTinhChe;
                    entryType = AccEntryName.XuatKhoBTPCongDoanTinhChe;
                }
                else if (objOperationsInfo.MMOperationNo == OperationNo.Laprap.ToString())
                {
                    documentType = AccDocumentName.XuatKhoBTPCongDoanLapRap;
                    entryType = AccEntryName.XuatKhoBTPCongDoanLapRap;
                }
                else if (objOperationsInfo.MMOperationNo == OperationNo.Son.ToString())
                {
                    documentType = AccDocumentName.XuatKhoBTPCongDoanSon;
                    entryType = AccEntryName.XuatKhoBTPCongDoanSon;
                }
                else if (objOperationsInfo.MMOperationNo == OperationNo.Donggoi.ToString())
                {
                    documentType = AccDocumentName.XuatBTPCongDoanDongGoi;
                    entryType = AccEntryName.XuatBTPCongDoanDongGoi;
                }
            }

            ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        documentType,
                                                                        entryType);
            ACEntryTypesController objEntryTypesController = new ACEntryTypesController();
            ACEntryTypesInfo entryTypesIfno = (ACEntryTypesInfo)objEntryTypesController.GetObjectByName(entryType);

            ACDocumentEntrysInfo entry = entity.DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == entryType);
            if (entryTypesIfno != null && entry == null)
            {
                entry = new ACDocumentEntrysInfo();
                entry.FK_ACEntryTypeID = entryTypesIfno.ACEntryTypeID;
                entry.ACDocumentEntryDesc = entryTypesIfno.ACEntryTypeDesc;
                entity.DocumentEntryList.Add(entry);
            }
            entry.ACDocumentEntryAmount = entity.SemiProductIngredientItemList.Sum(i => i.MMSemiProductIngredientItemProductUnitPrice * i.MMSemiProductIngredientItemProductQty);
            entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount;

            //entity.DocumentEntryList.Clear();
            //entity.DocumentEntryList.Add(entry);
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocumentsInfo objDocumentsInfo = entity.DocumentList.LastOrDefault(d => d.ACDocumentTypeName == documentType);
            if (objDocumentsInfo == null)
            {
                objDocumentsInfo = new ACDocumentsInfo();
                int documentTypeID = objDocumentTypesController.GetObjectIDByName(documentType);
                objDocumentsInfo.FK_ACDocumentTypeID = documentTypeID;
                objDocumentsInfo.ACDocumentTypeName = documentType;
                objDocumentsInfo.FK_ACObjectID = 1;
                objDocumentsInfo.ACObjectType = BranchType.Branch.ToString();
                objDocumentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                objDocumentsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                entity.DocumentList.Add(objDocumentsInfo);
            }
            else
            {
                objDocumentsInfo.FK_ACObjectID = 1;
                objDocumentsInfo.ACObjectType = BranchType.Branch.ToString();
                objDocumentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            }
            entity.DocumentEntryList.GridControl?.RefreshDataSource();
        }
    }
}
