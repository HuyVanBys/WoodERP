using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AssetReceipt
{
    public class AssetReceiptModule : BaseTransactionModule
    {
        #region Constants
        public const string AssetReceiptItemGridControlName = "fld_dgcAssetReceiptItems";
        public const string DocumentEntryGridControlName = "fld_dgcDocumentEntrys";
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public const string AssetLookupEditControlName = "fld_lkeFK_ACAssetID";
        public const string ProductLookupEditControlName = "fld_lkeFK_ICProductID";

        #endregion
        public BOSLookupEdit SearchBranchLookupEditControl = null;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        public BOSLookupEdit AssetLookupEditControl = null;
        public List<ACAssetsInfo> AssetList;
        public BOSLookupEdit ProductLookupEditControl = null;
        public BOSLabel label;


        public AssetReceiptModule()
        {
            Name = ModuleName.AssetReceipt;
            CurrentModuleEntity = new AssetReceiptEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;

            ProductLookupEditControl = (BOSLookupEdit)Controls[ProductLookupEditControlName];
            if (ProductLookupEditControl != null)
            {
                ICProductsController objProductsController = new ICProductsController();
                List<ICProductsInfo> listProduct = new List<ICProductsInfo>();
                List<ICProductsForViewInfo> productViewList = BOSApp.CurrentProductList.Where(x => x.ICProductUsingMethod == ProductUsingMethod.SpecificAsset.ToString()
                                                                                                && x.ICProductActiveCheck == true).ToList();
                if (productViewList.Count() > 0) productViewList.ForEach(o =>
                {
                    ICProductsInfo newObj = new ICProductsInfo();
                    BOSUtil.CopyViewObject(o, newObj);
                    listProduct.Add(newObj);
                });
                ProductLookupEditControl.Properties.DataSource = listProduct;
            }

            AssetLookupEditControl = (BOSLookupEdit)Controls[AssetLookupEditControlName];
            if (AssetLookupEditControl != null)
            {
                ACAssetsController objAssetsController = new ACAssetsController();
                AssetList = objAssetsController.GetAssetsForAssetReceipt();
                AssetLookupEditControl.Properties.DataSource = AssetList;
            }
        }

        public void GetCurrentModuleDataViewPermission()
        {
            CurrentModuleDataViewPermissionList = BOSApp.CurrentADDataViewPermissionList.Where(i => i.STModuleName == Name && i.ADDataViewPermissionType == ADDataViewPermissionType.Module).ToList();

            List<int> branchIDList = new List<int>();
            foreach (ADDataViewPermissionsInfo dataViewPermissionsInfo in CurrentModuleDataViewPermissionList)
            {
                branchIDList.Add(dataViewPermissionsInfo.FK_BRBranchID);
            }

            if (branchIDList.Count == 0)
            {
                BranchList = new List<BRBranchsInfo>();
            }
            else
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                List<BRBranchsInfo> branchList = objBranchsController.GetAllBranches();

                BranchList = branchList.Where(i => branchIDList.IndexOf(i.BRBranchID) > -1).ToList();
            }
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ACAssetReceiptsInfo searchObject = (ACAssetReceiptsInfo)CurrentModuleEntity.SearchObject;
            ACAssetReceiptsController assetReceiptController = new ACAssetReceiptsController();
            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = assetReceiptController.GetDataSetByID(-1);
                }
                else
                {
                    ds = assetReceiptController.GetAssetReceiptListDataSetByListOfBranchID(searchObject.ACAssetReceiptNo,
                                                                                searchObject.ACAssetReceiptInvoiceNo,
                                                                                searchObject.FK_APSupplierID,
                                                                                searchObject.FK_HREmployeeID,
                                                                                searchObject.AssetReceiptDateFrom,
                                                                                searchObject.AssetReceiptDateTo,
                                                                                BranchList);
                }
            }
            else
            {
                ds = assetReceiptController.GetAssetReceiptListBySomeCriteria(searchObject.ACAssetReceiptNo,
                                                                                searchObject.ACAssetReceiptInvoiceNo,
                                                                                searchObject.FK_APSupplierID,
                                                                                searchObject.FK_HREmployeeID,
                                                                                searchObject.FK_BRBranchID,
                                                                                searchObject.AssetReceiptDateFrom,
                                                                                searchObject.AssetReceiptDateTo);
            }

            return ds;
        }

        public void SetLookUpProductAndAssetForAssetReceiptType()
        {
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo objAssetReceiptsInfo = (ACAssetReceiptsInfo)entity.MainObject;
            if (objAssetReceiptsInfo.ACAssetReceiptType == AssetReceiptType.Receipt.ToString())
            {
                label = (BOSLabel)Controls["bosLabel9"];
                if (label != null)
                    label.Text = "Sản phẩm";
                if (ProductLookupEditControl != null)
                {
                    ProductLookupEditControl.Visible = true;
                }
                if (AssetLookupEditControl != null)
                {
                    AssetLookupEditControl.Visible = false;
                }

            }
            else
            {
                label = (BOSLabel)Controls["bosLabel9"];
                if (label != null)
                    label.Text = "Tài sản";
                if (AssetLookupEditControl != null)
                {
                    AssetLookupEditControl.Visible = true;
                }
                if (ProductLookupEditControl != null)
                {
                    ProductLookupEditControl.Visible = false;
                }
            }

        }
        public override void ActionNew()
        {
            base.ActionNew();
        }

        public void ActionNewFromNewIncrease()
        {
            ActionNew();
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo objAssetReceiptsInfo = (ACAssetReceiptsInfo)entity.MainObject;
            objAssetReceiptsInfo.ACAssetReceiptType = AssetReceiptType.NewIncrease.ToString();
            entity.UpdateMainObjectBindingSource();
            SetLookUpProductAndAssetForAssetReceiptType();
        }

        public void ActionNewFromUnfinishedConstructionCost()
        {
            ActionNew();
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo objAssetReceiptsInfo = (ACAssetReceiptsInfo)entity.MainObject;
            objAssetReceiptsInfo.ACAssetReceiptType = AssetReceiptType.FromUnfinishedConstructionCost.ToString();
            entity.UpdateMainObjectBindingSource();
            SetLookUpProductAndAssetForAssetReceiptType();
        }

        public void ActionNewPurchaseReceipt()
        {
            ActionNew();
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo objAssetReceiptsInfo = (ACAssetReceiptsInfo)entity.MainObject;
            objAssetReceiptsInfo.ACAssetReceiptType = AssetReceiptType.Receipt.ToString();
            entity.UpdateMainObjectBindingSource();
            SetLookUpProductAndAssetForAssetReceiptType();
        }
        public override void ActionEdit()
        {
            base.ActionEdit();
            SetLookUpProductAndAssetForAssetReceiptType();
        }

        public override int ActionSave()
        {
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo objAssetReceiptsInfo = (ACAssetReceiptsInfo)entity.MainObject;
            if ((objAssetReceiptsInfo.ACAssetReceiptType != AssetReceiptType.Receipt.ToString() 
                && objAssetReceiptsInfo.ACAssetReceiptType != AssetReceiptType.FromUnfinishedConstructionCost.ToString() )
                && objAssetReceiptsInfo.FK_APSupplierID == 0)
            {
                MessageBox.Show("Vui lòng chọn đối tượng nhà cung cấp.", "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            entity.AssetReceiptItemList.EndCurrentEdit();
            foreach (ACAssetReceiptItemsInfo item in entity.AssetReceiptItemList)
            {
                int dem = entity.AssetReceiptItemList.Where(i => i.FK_ACUnfinishedConstructionCostID == item.FK_ACUnfinishedConstructionCostID).ToList().Count;
                if (dem > 1)
                {
                    MessageBox.Show("1 chi phí chỉ dùng cho 1 tài sản, vui lòng chọn lại", "Thông báo");
                    return 0;
                }
            }
            if (objAssetReceiptsInfo.ACAssetReceiptType == AssetReceiptType.Receipt.ToString())
            {
                if (entity.AssetReceiptItemList != null && entity.AssetReceiptItemList.Count() > 0
                    && entity.AssetReceiptItemList.Where(x => x.FK_ICStockID == 0).ToList().Count() > 0)
                {
                    BOSApp.ShowMessage("Vui lòng chọn kho cho sản phẩm dưới lưới!");
                    return 0;
                }

                if (entity.AssetReceiptItemList != null && entity.AssetReceiptItemList.Count() > 0
                    && entity.AssetReceiptItemList.Where(x => x.FK_ICProductSerieID == 0).ToList().Count() > 0)
                {
                    BOSApp.ShowMessage("Vui lòng chọn lô cho sản phẩm dưới lưới!");
                    return 0;
                }
            }
            bool isValid = ValidateData();
            if (!isValid)
                return 0;
            UpdateTotalCost();
            return base.ActionSave();
        }

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                RPAssetIncreasing report = new RPAssetIncreasing();
                InitAssetIncreasingReport(report, Toolbar.CurrentObjectID);
                guiReportPreview viewer = new guiReportPreview(report);
                viewer.Show();
            }
        }

        /// <summary>
        /// Init an asset increasing report
        /// </summary>
        /// <param name="report">Given report</param>
        /// <param name="assetReceiptID">Asset receipt id</param>
        private void InitAssetIncreasingReport(RPAssetIncreasing report, int assetReceiptID)
        {
            //Set current branch
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;

            ADReportsController objReportsController = new ADReportsController();
            List<ACAssetReceiptItemsInfo> items = objReportsController.GetItemsByAssetReceiptID(assetReceiptID);
            report.DataSource = items;
        }

        /// <summary>
        /// Add an item to its list
        /// </summary>
        public void AddItemToList()
        {
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo mainObject = (ACAssetReceiptsInfo)entity.MainObject;
            ACAssetsController assetController = new ACAssetsController();
            ICProductSeriesController productSerialController = new ICProductSeriesController();
            ICProductSeriesInfo objIProductSeriesInfo = new ICProductSeriesInfo();
            ACAssetReceiptItemsInfo objAssetReceiptItemsInfo = (ACAssetReceiptItemsInfo)entity.ModuleObjects[TableName.ACAssetReceiptItemsTableName];
            List<int> listAssetID = entity.AssetReceiptItemList.Select(i => i.FK_ACAssetID).ToList();

            if (listAssetID.Contains(objAssetReceiptItemsInfo.FK_ACAssetID) == true)
            {
                MessageBox.Show("Tài sản cố định này đã tồn tại trên lưới", "Thông báo");
                return;
            }
            if (objAssetReceiptItemsInfo.FK_ACAssetID > 0)
            {
                ACAssetsInfo asset = assetController.GetObjectByID(objAssetReceiptItemsInfo.FK_ACAssetID) as ACAssetsInfo;
                if (asset != null && asset.ACAssetStatus != "Purchased")
                {
                    MessageBox.Show("Chỉ được phép tăng tài sản cố định với trạng thái đã mua", "Thông báo");
                    return;
                }
                objAssetReceiptItemsInfo.FK_ACAccountID = asset.FK_ACAccountID;
                objAssetReceiptItemsInfo.FK_ACDepreciationAccountID = asset.FK_ACDepreciationAccountID;
                objAssetReceiptItemsInfo.FK_HRDepartmentRoomID = asset.FK_HRDepartmentRoomID;
                objAssetReceiptItemsInfo.FK_HRDepartmentID = asset.FK_HRDepartmentID;
                objAssetReceiptItemsInfo.ACAssetReceiptItemOriginalAmount = 0;
                objAssetReceiptItemsInfo.FK_MMWorkShopID = asset.FK_MMWorkShopID;
                objAssetReceiptItemsInfo.FK_MMLineID = asset.FK_MMLineID;
                objAssetReceiptItemsInfo.FK_HRDepartmentRoomGroupItemID = asset.FK_HRDepartmentRoomGroupItemID;
                objAssetReceiptItemsInfo.FK_HREmployeeUserID = asset.FK_HREmployeeUserID;
                objAssetReceiptItemsInfo.ACAssetReceiptItemTotalCost = 0;
                objAssetReceiptItemsInfo.ACAssetReceiptItemUnitCost = 0;
                objAssetReceiptItemsInfo.ACAssetReceiptItemQty = 1;
                objAssetReceiptItemsInfo.ACAssetReceiptItemProductName = asset.ACAssetName;
                objAssetReceiptItemsInfo.ACAssetReceiptItemProductDesc = asset.ACAssetDesc;
                if (mainObject.ACAssetReceiptType == AssetReceiptType.FromUnfinishedConstructionCost.ToString())
                {
                    objAssetReceiptItemsInfo.FK_ACUnfinishedConstructionCostID = asset.FK_ACUnfinishedConstructionCostID;
                }
                entity.SetValuesAfterValidatingAsset(objAssetReceiptItemsInfo);
                entity.AssetReceiptItemList.AddObjectToList();
                UpdateTotalCost();
            }


        }

        public void AddItemProductToList()
        {
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo mainObject = (ACAssetReceiptsInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductSeriesController productSerialController = new ICProductSeriesController();
            ICProductSeriesInfo objIProductSeriesInfo = new ICProductSeriesInfo();
            ACAssetReceiptItemsInfo objAssetReceiptItemsInfo = (ACAssetReceiptItemsInfo)entity.ModuleObjects[TableName.ACAssetReceiptItemsTableName];
            List<int> listProduct = entity.AssetReceiptItemList.Select(i => i.FK_ICProductID).ToList();
            if (listProduct.Contains(objAssetReceiptItemsInfo.FK_ICProductID) == true)
            {
                MessageBox.Show("Sản phẩm này đã tồn tại trên lưới", "Thông báo");
                return;
            }

            if (objAssetReceiptItemsInfo.FK_ICProductID > 0)
            {
                ICProductsInfo objProductsInfo = objProductsController.GetObjectByID(objAssetReceiptItemsInfo.FK_ICProductID) as ICProductsInfo;
                if (objProductsInfo != null)
                {
                    objAssetReceiptItemsInfo.ACAssetReceiptItemUnitCost = objProductsInfo.ICProductUnitCost;
                    objAssetReceiptItemsInfo.ACAssetReceiptItemProductName = objProductsInfo.ICProductName;
                    objAssetReceiptItemsInfo.ACAssetReceiptItemProductDesc = objProductsInfo.ICProductDesc;
                    objAssetReceiptItemsInfo.FK_ACAssetID = 0;
                    entity.SetValuesAfterValidateProduct(objAssetReceiptItemsInfo.FK_ICProductID);
                    entity.AssetReceiptItemList.AddObjectToList();
                    UpdateTotalCost();
                }
            }
        }

        /// <summary>
        /// Change an item from its list
        /// </summary>
        public void ChangeItemFromList(ACAssetReceiptItemsInfo item)
        {
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            entity.CalculateItemCost(item);
            entity.AssetReceiptItemList.GridControl.RefreshDataSource();
            UpdateTotalCost();
        }

        /// <summary>
        /// Remove the selected item from its list
        /// </summary>
        public void RemoveSelectedItem()
        {
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptItemsInfo removedItem = (ACAssetReceiptItemsInfo)entity.ModuleObjects[TableName.ACAssetReceiptItemsTableName];
            if (removedItem != null)
                removedItem = removedItem.Clone() as ACAssetReceiptItemsInfo;
            entity.AssetReceiptItemList.RemoveSelectedRowObjectFromList();
            ACAssetReceiptItemsInfo currentItem = (ACAssetReceiptItemsInfo)entity.ModuleObjects[TableName.ACAssetReceiptItemsTableName];
            entity.ModuleObjects[TableName.ACAssetReceiptItemsTableName] = removedItem;
            UpdateDocumentEntries();
            entity.ModuleObjects[TableName.ACAssetReceiptItemsTableName] = currentItem;
        }

        /// <summary>
        /// Called when the user changes the discount percent
        /// </summary>
        public void ChangeDiscountPercent()
        {
            UpdateTotalCost();
        }

        /// <summary>
        /// Called when the user changes the discount amount
        /// </summary>
        public void ChangeDiscountAmount()
        {
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo objReceiptsInfo = (ACAssetReceiptsInfo)entity.MainObject;
            if (objReceiptsInfo.ACAssetReceiptSubTotalCost > 0)
                objReceiptsInfo.ACAssetReceiptDiscountPercent = objReceiptsInfo.ACAssetReceiptDiscountAmount / objReceiptsInfo.ACAssetReceiptSubTotalCost * 100;
            UpdateTotalCost();
        }

        /// <summary>
        /// Called when the user changes the tax percent
        /// </summary>
        public void ChangeTaxPercent()
        {
            UpdateTotalCost();
        }

        /// <summary>
        /// Called when the users change the tax amount
        /// </summary>
        public void ChangeTaxAmount()
        {
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo objReceiptsInfo = (ACAssetReceiptsInfo)entity.MainObject;
            decimal subTotalCost = objReceiptsInfo.ACAssetReceiptSubTotalCost -
                                    objReceiptsInfo.ACAssetReceiptDiscountAmount +
                                    objReceiptsInfo.ACAssetReceiptShippingFee +
                                    objReceiptsInfo.ACAssetReceiptExtraFee;
            if (subTotalCost > 0)
            {
                objReceiptsInfo.ACAssetReceiptTaxPercent = objReceiptsInfo.ACAssetReceiptTaxAmount / subTotalCost * 100;
            }
            UpdateTotalCost();
        }

        /// <summary>
        /// Called when the user changes fees
        /// </summary>
        public void ChangeFee()
        {
            UpdateTotalCost();
        }

        /// <summary>
        /// Called when the user changes the supplier
        /// </summary>
        /// <param name="supplierID">Target supplier id</param>
        public void ChangeSupplier(int supplierID)
        {
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo objAssetReceiptsInfo = (ACAssetReceiptsInfo)entity.MainObject;
            objAssetReceiptsInfo.FK_APSupplierID = supplierID;
            if (supplierID > 0)
            {
                APSuppliersController objSuppliersController = new APSuppliersController();
                APSuppliersInfo objSuppliersInfo = (APSuppliersInfo)objSuppliersController.GetObjectByID(supplierID);
                if (objSuppliersInfo != null)
                {
                    objAssetReceiptsInfo.ACAssetReceiptSupplierTaxNumber = objSuppliersInfo.APSupplierTaxNumber;
                    objAssetReceiptsInfo.ACAssetReceiptSupplierContactAddress = objSuppliersInfo.APSupplierContactAddressLine3;
                }
            }
            if (!Toolbar.IsNullOrNoneAction())
            {
                SetDefaultValuesFromSupplier();
            }
            entity.UpdateMainObjectBindingSource();
        }

        /// <summary>
        /// Update the total costs of the asset receipt
        /// </summary>
        public void UpdateTotalCost()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
                ACAssetReceiptsInfo objAssetReceiptsInfo = (ACAssetReceiptsInfo)CurrentModuleEntity.MainObject;
                objAssetReceiptsInfo.ACAssetReceiptSubTotalCost = 0;
                //TNDLoc [ADD][27/09/2016][Round by currency],START
                foreach (ACAssetReceiptItemsInfo item in entity.AssetReceiptItemList)
                {
                    BOSApp.RoundByCurrency(item, objAssetReceiptsInfo.FK_GECurrencyID);
                    objAssetReceiptsInfo.ACAssetReceiptSubTotalCost += item.ACAssetReceiptItemTotalCost;
                }

                //objAssetReceiptsInfo.ACAssetReceiptSubTotalCost = entity.AssetReceiptItemList.Sum(i => i.ACAssetReceiptItemTotalCost);
                //TNDLoc [ADD][27/09/2016][Round by currency],END

                objAssetReceiptsInfo.ACAssetReceiptDiscountAmount = objAssetReceiptsInfo.ACAssetReceiptDiscountPercent * objAssetReceiptsInfo.ACAssetReceiptSubTotalCost / 100;
                objAssetReceiptsInfo.ACAssetReceiptTaxAmount = (objAssetReceiptsInfo.ACAssetReceiptSubTotalCost -
                                                 objAssetReceiptsInfo.ACAssetReceiptDiscountAmount +
                                                 objAssetReceiptsInfo.ACAssetReceiptShippingFee +
                                                 objAssetReceiptsInfo.ACAssetReceiptExtraFee) * objAssetReceiptsInfo.ACAssetReceiptTaxPercent / 100;
                objAssetReceiptsInfo.ACAssetReceiptTotalCost = objAssetReceiptsInfo.ACAssetReceiptSubTotalCost -
                                                               objAssetReceiptsInfo.ACAssetReceiptDiscountAmount +
                                                               objAssetReceiptsInfo.ACAssetReceiptShippingFee +
                                                               objAssetReceiptsInfo.ACAssetReceiptExtraFee +
                                                               objAssetReceiptsInfo.ACAssetReceiptTaxAmount;
                //TNDLoc [ADD][27/09/2016][Round by currency],START
                BOSApp.RoundByCurrency(objAssetReceiptsInfo, "ACAssetReceiptSubTotalCost", objAssetReceiptsInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(objAssetReceiptsInfo, "ACAssetReceiptDiscountAmount", objAssetReceiptsInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(objAssetReceiptsInfo, "ACAssetReceiptTaxAmount", objAssetReceiptsInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(objAssetReceiptsInfo, "ACAssetReceiptTotalCost", objAssetReceiptsInfo.FK_GECurrencyID);
                //TNDLoc [ADD][27/09/2016][Round by currency],END
                entity.UpdateMainObjectBindingSource();

                UpdateAssetOriginalAmount();
                //TNDLoc [ADD][27/09/2016][Round by currency],START
                entity.AssetReceiptItemList.GridControl.RefreshDataSource();
                //TNDLoc [ADD][27/09/2016][Round by currency],END

                UpdateDocumentEntries();
            }
        }

        /// <summary>
        /// Update the original amount of the all assets
        /// </summary>
        public void UpdateAssetOriginalAmount()
        {
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo objAssetReceiptsInfo = (ACAssetReceiptsInfo)entity.MainObject;
            decimal extCost = entity.AssetReceiptItemList.Sum(i => i.ACAssetReceiptItemExtCost);
            foreach (ACAssetReceiptItemsInfo item in entity.AssetReceiptItemList)
            {
                decimal originalAmount = item.ACAssetReceiptItemExtCost - item.ACAssetReceiptItemDiscountAmount;
                if (extCost > 0)
                {
                    decimal factor = item.ACAssetReceiptItemExtCost / extCost;
                    originalAmount -= factor * objAssetReceiptsInfo.ACAssetReceiptDiscountAmount;
                    originalAmount += factor * objAssetReceiptsInfo.ACAssetReceiptShippingFee;
                    originalAmount += factor * objAssetReceiptsInfo.ACAssetReceiptExtraFee;
                }
                if (item.ACAssetReceiptItemQty > 0)
                {
                    originalAmount = originalAmount / item.ACAssetReceiptItemQty;
                }
                item.ACAssetReceiptItemOriginalAmount = originalAmount;

                //TNDLoc [ADD][27/09/2016][Round by currency],START
                BOSApp.RoundByCurrency(item, "ACAssetReceiptItemOriginalAmount", objAssetReceiptsInfo.FK_GECurrencyID);
                //TNDLoc [ADD][27/09/2016][Round by currency],END
            }
        }

        #region Accounting
        #endregion

        public void ApproveAssetReceipt()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
                ACAssetReceiptsInfo mainObject = (ACAssetReceiptsInfo)entity.MainObject;
                entity.AssetReceiptItemList.EndCurrentEdit();
                UpdateTotalCost();
                ActionComplete();
            }
        }
        public void ChangeCurrency(int currencyID)
        {
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo objAssetReceiptsInfo = (ACAssetReceiptsInfo)entity.MainObject;

            objAssetReceiptsInfo.FK_GECurrencyID = currencyID;
            decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateByCurrencyAndDate(objAssetReceiptsInfo.FK_GECurrencyID, objAssetReceiptsInfo.ACAssetReceiptDate);
            objAssetReceiptsInfo.ACAssetReceiptExchangeRate = (dCurrencyExchangeRate > 0)
                                                               ? dCurrencyExchangeRate
                                                               : 1;
            UpdateTotalCost();
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            SetLookUpProductAndAssetForAssetReceiptType();
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo objAssetReceiptsInfo = (ACAssetReceiptsInfo)entity.MainObject;
            ACAssetsController objAssetsController = new ACAssetsController();
            ParentScreen.SetEnableOfToolbarButton("PutToUse", false);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            if (objAssetReceiptsInfo.ACAssetReceiptID > 0)
            {
                if (objAssetReceiptsInfo.ACAssetReceiptStatus == AssetReceiptStatus.Complete.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                    foreach (ACAssetReceiptItemsInfo item in entity.AssetReceiptItemList)
                    {
                        ACAssetsInfo objAssetsInfo = (ACAssetsInfo)objAssetsController.GetObjectByID(item.FK_ACAssetID);
                        if (objAssetsInfo != null)
                        {
                            if (objAssetsInfo.ACAssetStatus == AssetStatus.Purchased.ToString())
                            {

                                ParentScreen.SetEnableOfToolbarButton("PutToUse", true);
                            }
                        }
                    }
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                        objAssetReceiptsInfo.ACAssetReceiptPostedStatus != PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                        objAssetReceiptsInfo.ACAssetReceiptPostedStatus == PostedTransactionStatus.Posted.ToString());
                }
                else
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", true);
                }
                if (Toolbar.IsEditAction())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
                }
            }
        }

        public void AssetTypeChange()
        {

        }

        public bool ValidateData()
        {
            bool isValid = true;
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo objAssetReceiptsInfo = (ACAssetReceiptsInfo)entity.MainObject;

            //if (objAssetReceiptsInfo.FK_APSupplierID == 0)
            //{
            //    MessageBox.Show("Vui lòng chọn đối tượng nhà cung cấp.", "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    isValid = false;
            //}

            if (objAssetReceiptsInfo.ACAssetReceiptType == AssetReceiptType.FromUnfinishedConstructionCost.ToString())
            {
                bool isExist = entity.AssetReceiptItemList.Exists(item => item.FK_ACUnfinishedConstructionCostID == 0);
                isValid = !isExist;
                if (!isValid)
                    MessageBox.Show("Vui lòng chọn chi phí xây dựng cơ bản dở dang dưới lưới.", "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (objAssetReceiptsInfo.ACAssetReceiptType == AssetReceiptType.NewIncrease.ToString())
            {
                bool isExist = entity.AssetReceiptItemList.Exists(item => item.FK_ACUnfinishedConstructionCostID != 0);
                isValid = !isExist;
                if (!isValid)
                    MessageBox.Show("Tăng mới tài sản không phải tập hợp từ chi phí xây dựng cơ bản dở dang. Vui lòng chọn bỏ chi phí xây dựng cơ bản dở dang dưới lưới.", "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isValid;
        }

        public void PutToUse()
        {
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo mainObject = (ACAssetReceiptsInfo)entity.MainObject;
            ACAssetsController objAssetsController = new ACAssetsController();
            ACUnfinishedConstructionCostsController objUnfinishedConstructionCostsController = new ACUnfinishedConstructionCostsController();
            ACAssetsInfo objAssetsInfo;
            ACUnfinishedConstructionCostsInfo objUnfinishedConstructionCostsInfo;

            foreach (ACAssetReceiptItemsInfo item in entity.AssetReceiptItemList)
            {
                objAssetsInfo = (ACAssetsInfo)objAssetsController.GetObjectByID(item.FK_ACAssetID);
                if (objAssetsInfo != null)
                {
                    objAssetsInfo.ACAssetStatus = AssetStatus.Using.ToString();
                    //objAssetsInfo.ACAssetUsedDate = BOSApp.GetCurrentServerDate();
                    objAssetsInfo.ACAssetInitQty = 1;
                    objAssetsController.UpdateObject(objAssetsInfo);
                }
                objUnfinishedConstructionCostsInfo = (ACUnfinishedConstructionCostsInfo)objUnfinishedConstructionCostsController.GetObjectByID(item.FK_ACUnfinishedConstructionCostID);
                if (objUnfinishedConstructionCostsInfo != null)
                {
                    objUnfinishedConstructionCostsInfo.ACUnfinishedConstructionCostFinishedDate = mainObject.ACAssetReceiptDate;
                    objUnfinishedConstructionCostsInfo.ACUnfinishedConstructionCostStatus = UnfinishedConstructionCostStatus.Complete.ToString();
                    objUnfinishedConstructionCostsController.UpdateObject(objUnfinishedConstructionCostsInfo);
                }
            }
            MessageBox.Show("Đưa vào sử dụng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InvalidateToolbar();
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo mainObject = (ACAssetReceiptsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ACAssetReceiptPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACAssetReceiptID, PostedTransactionStatus.Posted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.PostedTransactions(this.Name, mainObject.ACAssetReceiptID, ModulePostingType.Accounting, ModulePostingType.InvoiceInTrans, ModulePostingType.Stock);
            InvalidateToolbar();
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo mainObject = (ACAssetReceiptsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ACAssetReceiptPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACAssetReceiptID, PostedTransactionStatus.UnPosted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.UnPostedTransactions(this.Name, mainObject.ACAssetReceiptID, ModulePostingType.Accounting, ModulePostingType.InvoiceInTrans, ModulePostingType.Stock);
            InvalidateToolbar();
        }
        public override void ModuleAfterCompleted()
        {
            base.ModuleAfterCompleted();
            DataSet ds = BOSApp.GetLookupTableData(TableName.ACAssetsTableName);
            BOSApp.LookupTables[TableName.ACAssetsTableName] = ds;
            BOSApp.LookupTablesUpdatedDate[TableName.ACAssetsTableName] = BOSApp.MainScreen.ServerDate;
            AssetReceiptItemGridControl gridControl = (AssetReceiptItemGridControl)Controls["fld_dgcAssetReceiptItems"];
            if (gridControl != null)
            {
                gridControl.RefreshBindingDataLookupEdit();
            }
            ActionPosted();
        }

        public void ChangeACEInvoiceTypeNo(int invoiceID)
        {
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo objAssetReceiptsInfo = (ACAssetReceiptsInfo)entity.MainObject;
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetObjectByID(invoiceID);
            if (objEInvoiceTypesInfo != null)
            {
                objAssetReceiptsInfo.ACAssetReceiptVATFormNo = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
                objAssetReceiptsInfo.ACAssetReceiptSymbol = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
            }
            entity.UpdateMainObjectBindingSource();
        }

        public virtual void ChangeItemSerieNo(ACAssetReceiptItemsInfo item)
        {
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo objAssetReceiptsInfo = (ACAssetReceiptsInfo)entity.MainObject;
            if (objAssetReceiptsInfo.ACAssetReceiptType == AssetReceiptType.Receipt.ToString())
            {
                item.ACAssetReceiptItemProductUnitCost = AccountHelper.GetProductUnitCost(item.FK_ICStockID, item.FK_ICProductID, item.ACAssetReceiptItemProductSerialNo, objAssetReceiptsInfo.ACAssetReceiptDate);
                item.ACAssetReceiptItemOriginalAmount = item.ACAssetReceiptItemProductUnitCost;
                item.ACAssetReceiptItemUnitCost = item.ACAssetReceiptItemProductUnitCost;
                entity.SetProductPriceByProductUnitPrice(item);
                BOSApp.RoundByCurrency(item, objAssetReceiptsInfo.FK_GECurrencyID);
                entity.AssetReceiptItemList.GridControl.RefreshDataSource();
                UpdateTotalCost();
            }
        }

        public virtual void SelectSeriesNoDefault(ACAssetReceiptItemsInfo item)
        {
            AssetReceiptEntities entity = (AssetReceiptEntities)CurrentModuleEntity;
            ACAssetReceiptsInfo objAssetReceiptsInfo = (ACAssetReceiptsInfo)entity.MainObject;
            if (objAssetReceiptsInfo.ACAssetReceiptType == AssetReceiptType.Receipt.ToString())
            {
                item.FK_ICProductSerieID = 0;
                item.ACAssetReceiptItemProductSerialNo = string.Empty;
                entity.AssetReceiptItemList.GridControl.RefreshDataSource();
            }
        }

        #region Mở chứng từ
        public override bool ActionCancelComplete()
        {
            ACAssetReceiptsInfo mainObject = (ACAssetReceiptsInfo)CurrentModuleEntity.MainObject;
            if (mainObject.ACAssetReceiptID > 0)
            {
                if (!CheckRelativeDocument())
                {
                    return false;
                }
                if (!base.ActionCancelComplete()) return false;
                CurrentModuleEntity.SetPropertyChangeEventLock(false);
                if (mainObject.ACAssetReceiptPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    ActionUnPosted();
                }
                mainObject.ACAssetReceiptStatus = AssetReceiptStatus.New.ToString();
                CurrentModuleEntity.UpdateMainObject();
                CurrentModuleEntity.SetPropertyChangeEventLock(true);
                
                InvalidateToolbar();
            }
            return true;
        }
        #endregion

        #region Xóa chứng từ
        public override void ActionDelete()
        {
            ACAssetReceiptsInfo mainObject = (ACAssetReceiptsInfo)CurrentModuleEntity.MainObject.Clone();
            if (mainObject.ACAssetReceiptID > 0)
            {
                if (!CheckRelativeDocument())
                {
                    return;
                }
                if (mainObject.ACAssetReceiptPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    ActionUnPosted();
                }
                base.ActionDelete();
            }
        }
        #endregion

        private bool CheckRelativeDocument()
        {
            ACAssetReceiptsInfo mainObject = (ACAssetReceiptsInfo)CurrentModuleEntity.MainObject;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            List<ACDocumentsInfo> documentsList = objDocumentsController.GetRelativeDocumentListByAssetReceiptID(mainObject.ACAssetReceiptID);

            if (documentsList.Count() > 0)
            {
                MessageBox.Show(string.Format("Không thể thực hiện do đã tạo các chứng từ sau:" + Environment.NewLine + "-{0}", string.Join("\n-", documentsList.Select(o => o.ACDocumentNo).ToArray()))
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
