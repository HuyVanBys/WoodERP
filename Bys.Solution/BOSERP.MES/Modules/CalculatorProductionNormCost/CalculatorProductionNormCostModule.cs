using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraCharts;
using DevExpress.XtraTreeList;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace BOSERP.Modules.CalculatorProductionNormCost
{
    public class CalculatorProductionNormCostModule : BaseModuleERP
    {
        public const string CalculatorProductionNormCostItemGridControlName = "fld_dgcMMCalculatorProductionNormCostItems";
        public const string BatchProductControlName = "fld_lkeFK_MMBatchProductID";
        /// <summary>
        /// Define product group button edit
        /// </summary>
        private BOSButtonEdit ProductGroupsButtonEdit;
        private BOSButton ButtonCalculate;
        public BOSChartControl ChartControl;
        private MMCalculatorProductionNormCostItemsGridControl CostGridControl;
        public BOSLookupEdit ProductLookupEdit;
        public BOSLookupEdit BatchProductControl;
        public BOSLookupEdit CustomerTypeLookupEdit = null;

        public CalculatorProductionNormCostModule()
        {
            Name = ModuleName.CalculatorProductionNormCost;
            CurrentModuleEntity = new CalculatorProductionNormCostEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            ProductGroupsButtonEdit = (BOSButtonEdit)Controls["fld_bedFK_ICProductGroupID"];
            ButtonCalculate = (BOSButton)Controls["fld_btnCalculate"];
            CostGridControl = (MMCalculatorProductionNormCostItemsGridControl)Controls["fld_dgcMMCalculatorProductionNormCostItems"];
            ProductLookupEdit = (BOSLookupEdit)Controls["fld_lkeFK_ICProductID"];
            ChartControl = (BOSChartControl)Controls["fld_ChartControl"];
            CustomerTypeLookupEdit = (BOSLookupEdit)Controls["fld_lkeARCustomerType123"];
            BatchProductControl = (BOSLookupEdit)Controls[BatchProductControlName];
            GetDataForProductLookupEdit();
            BatchProductControl.QueryPopUp += new System.ComponentModel.CancelEventHandler(BatchProductControl_QueryPopUp);

        }
        public void BatchProductControl_QueryPopUp(object sender, EventArgs e)
        {
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            List<MMBatchProductsInfo> batchProductList = objBatchProductsController.GetBatchProductByStatusIsApproved();
            BatchProductControl.Properties.DataSource = batchProductList;
        }
        public void GetDataForProductLookupEdit()
        {
            ICProductsController objICProductsController = new ICProductsController();
            List<ICProductsInfo> list = objICProductsController.GetAllProductsForLookupControlForCustomModule(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            ProductLookupEdit.Properties.DataSource = list;
        }

        public void GetDataForChartControl(BOSComponent.BOSChartControl chartControl)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMCalculatorProductionNormCostsInfo mainObject = (MMCalculatorProductionNormCostsInfo)entity.MainObject;
            ChartControl.Series[0].Points.Clear();
            MMProductionNormCostFactorsController objPNCFCOntroller = new MMProductionNormCostFactorsController();
            List<MMProductionNormCostFactorsInfo> objPNCFIsSetCostPriceList = objPNCFCOntroller.GetItemIsSetCostPrice();
            List<MMCalculatorProductionNormCostItemsInfo> filterList = (List<MMCalculatorProductionNormCostItemsInfo>)entity.CalculatorProductionNormCostItemList.Clone();
            foreach (MMProductionNormCostFactorsInfo item in objPNCFIsSetCostPriceList)
            {
                filterList = filterList.Where(i => i.MMCalculatorProductionNormCostItemNo != item.MMProductionNormCostFactorNo).ToList();
            }

            decimal tongphi = filterList.Sum(i => i.MMCalculatorProductionNormCostItemCostPrice);
            foreach (MMCalculatorProductionNormCostItemsInfo item in filterList)
            {
                decimal phantram = item.MMCalculatorProductionNormCostItemCostPrice * 100 / tongphi;
                SeriesPoint point = new SeriesPoint(string.Format("{0}: {1} ({2}%)", item.MMCalculatorProductionNormCostItemName
                                                                                    , item.MMCalculatorProductionNormCostItemCostPrice.ToString("n0")
                                                                                    , phantram.ToString("n2"))
                                                                                    , phantram);
                ChartControl.Series[0].Points.Add(point);
            }
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMCalculatorProductionNormCostsInfo mainObject = (MMCalculatorProductionNormCostsInfo)entity.MainObject;
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            mainObject.ICProductGroupName = objProductGroupsController.GetObjectNameByID(mainObject.FK_ICProductGroupID);
            ProductGroupsButtonEdit.Text = mainObject.ICProductGroupName;
            entity.UpdateMainObjectBindingSource();
            GetDataForChartControl(ChartControl);
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            MMCalculatorProductionNormCostsInfo mainObject = (MMCalculatorProductionNormCostsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            ButtonCalculate.Enabled = true;
            if (mainObject.MMCalculatorProductionNormCostID > 0)
            {
                if(mainObject.MMCalculatorProductionNormCostStatus == MMProposalItemStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                }  
                if (mainObject.MMCalculatorProductionNormCostStatus == MMProposalItemStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ButtonCalculate.Enabled = false;
                }
            }
        }

        public void ApproveCalculatorProductionNormCost()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMCalculatorProductionNormCostsInfo objCostInfo = (MMCalculatorProductionNormCostsInfo)entity.MainObject;
            entity.ApproveCalculatorProductionNormCost();
            if (objCostInfo.MMCalculatorProductionNormCostCostPrice > 0)
            {
                DialogResult dlgResult = MessageBox.Show("Bạn muốn cập nhật giá vốn sản phẩm không?"
                                          , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.No)
                    return;
                else
                {
                    ICProductsController objProductsController = new ICProductsController();
                    //   objProductsController.UpdateProductCostPrice(objCostInfo.FK_ICProductID, objCostInfo.MMCalculatorProductionNormCostCostPrice);

                    int currencyDefID = 0;
                    //GECurrenciesInfo currency = BOSApp.CurrenciesList.FirstOrDefault(t=>t.GECurrencyIsDefault);
                    //if(currency!=null)
                    //{
                    //    currencyDefID = currency.GECurrencyID;
                    //}
                    currencyDefID = GECurrencyID.VND;
                    objProductsController.UpdateProductBranchPriceByCalculatorID(objCostInfo.MMCalculatorProductionNormCostID, objCostInfo.FK_GECurrencyID, objCostInfo.FK_ICProductID, currencyDefID);

                }
            }
            InvalidateToolbar();
        }

        public List<MMProcesssInfo> GetProcessDataSource(int productID)
        {
            MMProcesssController objProcesssController = new MMProcesssController();
            List<MMProcesssInfo> ProcessList = new List<MMProcesssInfo>();
            ProcessList = objProcesssController.GetProcessListData(productID);
            return ProcessList;
        }
        public List<MMProductionNormsInfo> GetProductionNormDataSource(int productID, int customerID)
        {
            MMProductionNormsController objProductionNormsController = new MMProductionNormsController();
            List<MMProductionNormsInfo> ProductionNormList = new List<MMProductionNormsInfo>();
            ProductionNormList = objProductionNormsController.GetProductionNormListData(productID, customerID);
            return ProductionNormList;
        }
        public void RemoveSelectedItemsList()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            entity.CalculatorProductionNormCostItemList.RemoveSelectedRowObjectFromList();
        }

        public void RemoveSelectedMaterialItemsList()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            entity.CalculatorProductionNormItemMaterialList.RemoveSelectedRowObjectFromList();

            //UpdateTotalCostGo(true);
        }
        public override void ActionNew()
        {
            base.ActionNew();
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMCalculatorProductionNormCostsInfo mainObject = (MMCalculatorProductionNormCostsInfo)entity.MainObject;
            mainObject.MMCalculatorProductionNormCostDate = DateTime.Now;
            mainObject.MMCalculatorProductionNormCostEffectiveDate = DateTime.Now;
            mainObject.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            mainObject.MMCalculatorProductionNormCostExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            GetDataForChartControl(ChartControl);
        }
        public void ShowCategoryTree()
        {
            if (IsEditable())
            {
                ActionEdit();
            }

            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMCalculatorProductionNormCostsInfo mainObject = (MMCalculatorProductionNormCostsInfo)entity.MainObject;
            ICProductGroupsController objPgController = new ICProductGroupsController();
            ICProductGroupsInfo objProductGroupsInfo = (ICProductGroupsInfo)objPgController.GetObjectByID(mainObject.FK_ICProductGroupID);
            int deparment = 0;
            int productGroupID = 0;
            if (objProductGroupsInfo == null)
            {
                if (mainObject.FK_ICProductID > 0)
                {
                    ICProductsController objPdController = new ICProductsController();
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objPdController.GetObjectByID(mainObject.FK_ICProductID);
                    if (objProductsInfo != null)
                    {
                        deparment = objProductsInfo.FK_ICDepartmentID;
                        productGroupID = objProductsInfo.FK_ICProductGroupID;
                    }
                }
            }
            else
            {
                deparment = objProductGroupsInfo.FK_ICDepartmentID;
                productGroupID = objProductGroupsInfo.ICProductGroupID;
            }
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(deparment, productGroupID);
            guiProductGroupTree.Module = this;
            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                objProductGroupsInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupsInfo != null)
                {
                    mainObject.FK_ICProductGroupID = objProductGroupsInfo.ICProductGroupID;
                    mainObject.ICProductGroupName = guiProductGroupTree.GetSelectedProductGroupName();
                }
                else
                {
                    mainObject.FK_ICProductGroupID = 0;
                    mainObject.ICProductGroupName = string.Empty;
                }
                entity.UpdateMainObjectBindingSource();
            }
        }

        public void CalculateCost(int productID, int bomID, int processID, int currencyID, DateTime effectiveDate, string priceType, int batchProductID)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMCalculatorProductionNormCostsInfo mainObject = (MMCalculatorProductionNormCostsInfo)entity.MainObject;
            MMCalculatorProductionNormCostItemsController objCalculatorsController = new MMCalculatorProductionNormCostItemsController();
            List<MMCalculatorProductionNormCostItemsInfo> listItem = objCalculatorsController.CalculatorProductionNormCost(productID, bomID, processID, effectiveDate, null, null, priceType);
            
            entity.CalculatorProductionNormCostItemList.Clear();
            entity.CalculatorProductionNormCostItemList.AddRange(listItem);
            mainObject.MMCalculatorProductionNormCostCostPrice = entity.CalculatorProductionNormCostItemList.Sum(o => o.MMCalculatorProductionNormCostItemCostPrice);
            entity.CalculatorProductionNormCostItemList.GridControl?.RefreshDataSource();

            //load semiproduct
            if (bomID > 0)
            {
                MMProductionNormsController pnCtrl = new MMProductionNormsController();
                MMProductionNormsInfo pn = (MMProductionNormsInfo)pnCtrl.GetObjectByID(bomID);
                if (pn != null)
                {
                    LoadSemiProductTreeList(pn.MMProductionNormID);
                    LoadMaterialList(pn.MMProductionNormID, effectiveDate);
                    LoadHardwareList(pn.MMProductionNormID, effectiveDate);
                    LoadGeneralMaterialList(pn.MMProductionNormID, effectiveDate);
                    LoadIngredientPackagingList(pn.MMProductionNormID, effectiveDate);
                    LoadPaintList(pn.MMProductionNormID, effectiveDate);
                }
            }
           // RecalCost();
        }

        public void LoadGeneralMaterialList(int carcassBOMID, DateTime effectiveDate)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMProductionNormItemsController pniCtrl = new MMProductionNormItemsController();
            List<MMProductionNormItemsInfo> pniList = pniCtrl.GetByGroupAnd2ProductionNormID(ProductType.GeneralMaterial.ToString(), carcassBOMID, effectiveDate);

            entity.GeneralMaterialList.Clear();

            if (pniList != null && pniList.Any())
            {
                MMCalculatorProductionNormItemsInfo newItem;

                foreach (MMProductionNormItemsInfo pni in pniList)
                {
                    newItem = new MMCalculatorProductionNormItemsInfo();
                    BOSUtil.CopyObject(pni, newItem);
                    newItem.MMCalculatorProductionNormItemID = 0;
                    newItem.MMCalculatorProductionNormItemParentID = 0;
                    newItem.FK_MMProductionNormItemID = pni.MMProductionNormItemID;
                    newItem.MMCalculatorProductionNormItemProductUnitCost = pni.ProductCost;
                    newItem.MMCalculatorProductionNormItemQuantity = pni.MMProductionNormItemQuantity;
                    newItem.MMCalculatorProductionNormItemTotalCost = newItem.MMCalculatorProductionNormItemProductUnitCost *
                                                                    newItem.MMCalculatorProductionNormItemQuantity;
                    entity.GeneralMaterialList.Add(newItem);
                }
            }

            entity.GeneralMaterialList.GridControl?.RefreshDataSource();

            //UpdateTotalCostVTK(false);

        }

        public void AddGeneralMaterial(int productID)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                AddItemToGeneralMaterialList(objProductsInfo);
                ResetGeneralMaterialSortOrder();
                UpdateTotalCostVTK(true);
            }

        }

        public void ResetGeneralMaterialSortOrder()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            int sortOrder = 1;
            foreach (MMCalculatorProductionNormItemsInfo item in entity.GeneralMaterialList)
            {
                item.MMCalculatorProductionNormItemSortOrder = sortOrder++;
            }
            entity.GeneralMaterialList.GridControl?.RefreshDataSource();
        }

        public MMCalculatorProductionNormItemsInfo AddItemToGeneralMaterialList(ICProductsInfo productObject)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            ICProductsController objProductsController = new ICProductsController();

            if (productObject != null)
            {
                MMCalculatorProductionNormItemsInfo objProductionNormItemsInfo = new MMCalculatorProductionNormItemsInfo();
                objProductionNormItemsInfo = SetValueGeneralMaterialItemFromProduct(productObject);
                if (entity.GeneralMaterialList != null && entity.GeneralMaterialList.Count > 0)
                    objProductionNormItemsInfo.MMCalculatorProductionNormItemSortOrder = entity.GeneralMaterialList.Count + 1;
                else
                    objProductionNormItemsInfo.MMCalculatorProductionNormItemSortOrder = 1;

                ICMaterialConfigsController mcController = new ICMaterialConfigsController();
                List<ICMaterialConfigsInfo> lstConfig = mcController.GetAllAliveAndActiveConfig();

                List<ICMaterialConfigsInfo> lstMatchConfig;
                objProductionNormItemsInfo.MMCalculatorProductionNormItemQuantity = 0;

                lstMatchConfig = lstConfig.Where(t => t.FK_ICProductID == objProductionNormItemsInfo.FK_ICProductID).ToList();


                entity.GeneralMaterialList.Add(objProductionNormItemsInfo);
                entity.GeneralMaterialList.GridControl?.RefreshDataSource();
                return objProductionNormItemsInfo;
            }
            return null;

        }

        public MMCalculatorProductionNormItemsInfo SetValueGeneralMaterialItemFromProduct(ICProductsInfo objProductsInfo)
        {
            MMCalculatorProductionNormItemsInfo objProductionNormItemsInfo = new MMCalculatorProductionNormItemsInfo();
            objProductionNormItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objProductionNormItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objProductionNormItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            objProductionNormItemsInfo.MMCalculatorProductionNormItemProductName = objProductsInfo.ICProductName;
            objProductionNormItemsInfo.MMCalculatorProductionNormItemNo = objProductsInfo.ICProductNo;
            objProductionNormItemsInfo.MMCalculatorProductionNormItemNeededTime = DateTime.Now;
            objProductionNormItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objProductionNormItemsInfo.MMCalculatorProductionNormItemProductDesc = objProductsInfo.ICProductDesc;
            objProductionNormItemsInfo.MMCalculatorProductionNormItemProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
            objProductionNormItemsInfo.MMCalculatorProductionNormItemGroup = ProductType.GeneralMaterial.ToString();
            objProductionNormItemsInfo.MMCalculatorProductionNormItemProductSizeAndPacking = objProductsInfo.ICProductSizeAndSpecifiCations;
            //Get unit from Products
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();
            objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByID(objProductsInfo.FK_ICProductBasicUnitID);
            if (objMeasureUnitsInfo != null)
                objProductionNormItemsInfo.MMCalculatorProductionNormItemUnit = objMeasureUnitsInfo.ICMeasureUnitName;

            if (objProductionNormItemsInfo.SubList == null)
                objProductionNormItemsInfo.SubList = new BOSTreeList();
            return objProductionNormItemsInfo;
        }

        public void LoadIngredientPackagingList(int carcassBOMID, DateTime effectiveDate)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMProductionNormItemsController pniCtrl = new MMProductionNormItemsController();
            List<MMProductionNormItemsInfo> pniList = pniCtrl.GetByGroupAnd2ProductionNormID(ProductType.IngredientPackaging.ToString(), carcassBOMID, effectiveDate);

            entity.IngredientPackagingList.Clear();

            if (pniList != null && pniList.Any())
            {
                string priceType = GetPriceType(ProductType.IngredientPackaging.ToString());
                AddSemiProductToList(0, pniList, entity.IngredientPackagingList, priceType);
                RefreshProductItemTreeListView(entity.IngredientPackagingList);
            }
            //UpdateTotalCostIngredientPackaging(false);
        }

        private string GetPriceType(string productGroup)
        {
            string priceType = string.Empty;
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            if (entity.CalculatorProductionNormCostItemList != null)
            {
                MMCalculatorProductionNormCostItemsInfo foundItem = entity.CalculatorProductionNormCostItemList.FirstOrDefault(item => item.MMProductionNormCostFactorProductGroup == productGroup);
                if (foundItem != null)
                    priceType = foundItem.MMProductionNormCostFactorPriceType;
            }
            return priceType;
        }

        public void LoadHardwareList(int carcassBOMID, DateTime effectiveDate)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMProductionNormItemsController pniCtrl = new MMProductionNormItemsController();
            List<MMProductionNormItemsInfo> pniList = pniCtrl.GetByGroupAnd2ProductionNormID(ProductType.Hardware.ToString(), carcassBOMID, effectiveDate);

            entity.HardwareList.Clear();

            if (pniList != null && pniList.Any())
            {
                string priceType = GetPriceType(ProductType.Hardware.ToString());
                AddSemiProductToList(0, pniList, entity.HardwareList, priceType);
                RefreshProductItemTreeListView(entity.HardwareList);
            }
            //UpdateTotalCostHW(false);
        }

        public void LoadPaintList(int carcassBOMID, DateTime effectiveDate)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMProductionNormItemsController pniCtrl = new MMProductionNormItemsController();
            List<MMProductionNormItemsInfo> pniList = pniCtrl.GetByGroupAnd2ProductionNormID(ProductType.IngredientPaint.ToString(), carcassBOMID, effectiveDate);

            entity.PaintList.Clear();

            if (pniList != null && pniList.Any())
            {
                string priceType = GetPriceType(ProductType.IngredientPaint.ToString());
                AddSemiProductToList(0, pniList, entity.PaintList, priceType);
                entity.ReDrawPaintTreeList();
                RefreshProductItemTreeListView(entity.PaintList);
            }
            //UpdateTotalCostPaint(false);
        }

        public void RemoveSelectedItemFromProductionNormItemHardwareList()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            if (entity.HardwareList.TreeListControl != null)
            {
                DevExpress.XtraTreeList.Nodes.TreeListNode currentNode = entity.HardwareList.TreeListControl.GetSelectedNode();
                if (currentNode != null)
                {
                    if (currentNode.Level == 0)
                        entity.HardwareList.TreeListControl.Nodes.Remove(currentNode);
                    else
                        currentNode.ParentNode.Nodes.Remove(currentNode);
                }
                entity.HardwareList.TreeListControl.RefreshDataSource();
                ResetHardwareListSortOrder();
                //UpdateTotalCostHW(true);
            }
        }

        public void AddHardware(int productID)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                AddItemToHardwareItemsList(objProductsInfo);
                ResetHardwareListSortOrder();
            }
        }

        public void ResetHardwareListSortOrder()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            int sortOrder = 1;
            foreach (MMCalculatorProductionNormItemsInfo item in entity.HardwareList)
            {
                item.MMCalculatorProductionNormItemSortOrder = sortOrder++;
            }
            if (entity.HardwareList.TreeListControl != null)
            {
                entity.HardwareList.TreeListControl.RefreshDataSource();
            }
        }

        public MMCalculatorProductionNormItemsInfo AddItemToHardwareItemsList(ICProductsInfo productObject)
        {

            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;

            ICProductsController objProductsController = new ICProductsController();

            if (productObject != null)
            {
                //if (CheckValidHardware(productObject))
                //{
                MMCalculatorProductionNormItemsInfo objProductionNormItemsInfo = new MMCalculatorProductionNormItemsInfo();
                objProductionNormItemsInfo = SetValueHardwareItemFromProduct(productObject);
                if (entity.HardwareList != null && entity.HardwareList.Count > 0)
                    objProductionNormItemsInfo.MMCalculatorProductionNormItemSortOrder = entity.HardwareList.Count + 1;
                else
                    objProductionNormItemsInfo.MMCalculatorProductionNormItemSortOrder = 1;
                entity.HardwareList.Add(objProductionNormItemsInfo);
                entity.HardwareList.TreeListControl.RefreshDataSource();
                entity.HardwareList.TreeListControl.ExpandAll();
                entity.HardwareList.TreeListControl.BestFitColumns();
                return objProductionNormItemsInfo;
                //}
                //else
                //{
                //    MessageBox.Show(ProductionNormLocalizeResources.MatchHardwareNo, MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            return null;

        }

        public MMCalculatorProductionNormItemsInfo SetValueHardwareItemFromProduct(ICProductsInfo objProductsInfo)
        {
            MMCalculatorProductionNormItemsInfo objProductionNormItemsInfo = new MMCalculatorProductionNormItemsInfo();
            objProductionNormItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objProductionNormItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objProductionNormItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            objProductionNormItemsInfo.MMCalculatorProductionNormItemProductName = objProductsInfo.ICProductName;
            objProductionNormItemsInfo.MMCalculatorProductionNormItemNo = objProductsInfo.ICProductNo;
            objProductionNormItemsInfo.MMCalculatorProductionNormItemNeededTime = DateTime.Now;
            objProductionNormItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
            objProductionNormItemsInfo.MMCalculatorProductionNormItemProductDesc = objProductsInfo.ICProductDesc;
            objProductionNormItemsInfo.MMCalculatorProductionNormItemProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
            objProductionNormItemsInfo.MMCalculatorProductionNormItemGroup = ProductType.Hardware.ToString();
            //Get unit from Products
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();
            objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByID(objProductsInfo.FK_ICProductBasicUnitID);
            if (objMeasureUnitsInfo != null)
                objProductionNormItemsInfo.MMCalculatorProductionNormItemUnit = objMeasureUnitsInfo.ICMeasureUnitName;

            // objProductionNormItemsInfo.MMProductionNormItemProductAttributeValue1 = objProductsInfo.ICProductSizeAndSpecifiCations;
            objProductionNormItemsInfo.MMCalculatorProductionNormItemProductSizeAndPacking = objProductsInfo.ICProductSizeAndSpecifiCations;
            objProductionNormItemsInfo.MMCalculatorProductionNormItemProductDesc = objProductsInfo.ICProductDesc;
            if (objProductionNormItemsInfo.SubList == null)
                objProductionNormItemsInfo.SubList = new BOSTreeList();
            return objProductionNormItemsInfo;
        }

        public void LoadMaterialList(int productionNormID, DateTime effectiveDate)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMCalculatorProductionNormItemMaterialsController cpnimCtrl = new MMCalculatorProductionNormItemMaterialsController();
            List<MMCalculatorProductionNormItemMaterialsInfo> cpnimList = cpnimCtrl.GetByProductionNormIDReferences(productionNormID, effectiveDate);
            entity.CalculatorProductionNormItemMaterialList.Clear();
            entity.CalculatorProductionNormItemMaterialList.AddRange(cpnimList);
            entity.CalculatorProductionNormItemMaterialList.GridControl?.RefreshDataSource();
            //UpdateTotalCostGo(false);
        }


        public void UpdateTotalCostGo(bool isUpdateTotal)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            decimal totalCost = entity.CalculatorProductionNormItemMaterialList.Sum(t => t.MMCalculatorProductionNormItemMaterialTotalCost);

            //foreach (MMCalculatorProductionNormCostItemsInfo item in entity.CalculatorProductionNormCostItemList)
            //{
            //    if (item.MMProductionNormCostFactorProductGroup == ProductionNormCostFactorProductGroup.SemiProduct.ToString())
            //    {
            //        item.MMCalculatorProductionNormCostItemCostPrice = totalCost;
            //        break;
            //    }
            //}

            if (isUpdateTotal)
            {
                //RecalCost();
            }
        }

        public void UpdateTotalCostVTK(bool isUpdateTotal)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            decimal totalCost = entity.GeneralMaterialList.Sum(t => t.MMCalculatorProductionNormItemTotalCost);

            //foreach (MMCalculatorProductionNormCostItemsInfo item in entity.CalculatorProductionNormCostItemList)
            //{
            //    if (item.MMProductionNormCostFactorProductGroup == ProductionNormCostFactorProductGroup.Other.ToString())
            //    {
            //        item.MMCalculatorProductionNormCostItemCostPrice = totalCost;
            //        break;
            //    }
            //}

            if (isUpdateTotal)
            {
                //RecalCost();
            }
        }


        public void GetTreeListSumCost(IBOSTreeList treeList, ref decimal result)
        {
            foreach (MMCalculatorProductionNormItemsInfo item in treeList)
            {
                item.MMCalculatorProductionNormItemTotalCost
                    = item.MMCalculatorProductionNormItemQuantity * item.MMCalculatorProductionNormItemProductUnitCost;

                result += item.MMCalculatorProductionNormItemTotalCost;
                if (item.SubList != null
                    && item.SubList.Any())
                {
                    GetTreeListSumCost(item.SubList, ref result);
                }
            }
        }

        public void UpdateTotalCostHW(bool isUpdateTotal)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            decimal totalCost = 0;

            GetTreeListSumCost(entity.HardwareList, ref totalCost);

            //foreach (MMCalculatorProductionNormCostItemsInfo item in entity.CalculatorProductionNormCostItemList)
            //{
            //    if (item.MMProductionNormCostFactorProductGroup == ProductionNormCostFactorProductGroup.Hardware.ToString())
            //    {
            //        item.MMCalculatorProductionNormCostItemCostPrice = totalCost;
            //        break;
            //    }
            //}

            RefreshProductItemTreeListView(entity.HardwareList);

            if (isUpdateTotal)
            {
                //RecalCost();
            }
        }


        public void UpdateTotalCostPaint(bool isUpdateTotal)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            decimal totalCost = 0;

            GetTreeListSumCost(entity.PaintList, ref totalCost);

            //foreach (MMCalculatorProductionNormCostItemsInfo item in entity.CalculatorProductionNormCostItemList)
            //{
            //    if (item.MMProductionNormCostFactorProductGroup == ProductionNormCostFactorProductGroup.IngredientPaint.ToString())
            //    {
            //        item.MMCalculatorProductionNormCostItemCostPrice = totalCost;
            //        break;
            //    }
            //}

            RefreshProductItemTreeListView(entity.PaintList);

            if (isUpdateTotal)
            {
               // RecalCost();
            }
        }

        public void UpdateTotalCostIngredientPackaging(bool isUpdateTotal)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            decimal totalCost = 0;

            GetTreeListSumCost(entity.IngredientPackagingList, ref totalCost);

            //foreach (MMCalculatorProductionNormCostItemsInfo item in entity.CalculatorProductionNormCostItemList)
            //{
            //    if (item.MMProductionNormCostFactorProductGroup == ProductionNormCostFactorProductGroup.IngredientPackaging.ToString())
            //    {
            //        item.MMCalculatorProductionNormCostItemCostPrice = totalCost;
            //        break;
            //    }
            //}

            RefreshProductItemTreeListView(entity.IngredientPackagingList);

            if (isUpdateTotal)
            {
                //RecalCost();
            }
        }


        public void RecalCost()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMCalculatorProductionNormCostsInfo mainObject = (MMCalculatorProductionNormCostsInfo)entity.MainObject;
            MMProductionNormCostFactorsController normCostCtrl = new MMProductionNormCostFactorsController();
            List<MMProductionNormCostFactorsInfo> pncfList = normCostCtrl.GetAllAliveNormCost();

            if (pncfList != null && pncfList.Any())
            {
                foreach (MMProductionNormCostFactorsInfo pncf in pncfList)
                {
                    CalCostNorm(pncf, entity.CalculatorProductionNormCostItemList, pncfList);
                    MMCalculatorProductionNormCostItemsInfo match = entity.CalculatorProductionNormCostItemList
                                                                     .FirstOrDefault(t => t.MMCalculatorProductionNormCostItemNo == pncf.MMProductionNormCostFactorNo);
                    if (match != null)
                    {
                        match.MMCalculatorProductionNormCostItemCostPrice = pncf.CostPrice;
                        match.MMCalculatorProductionNormCostItemCostPriceExchange
                            = match.MMCalculatorProductionNormCostItemCostPrice / mainObject.MMCalculatorProductionNormCostExchangeRate;
                    }
                }
                entity.CalculatorProductionNormCostItemList.GridControl?.RefreshDataSource();

                if (mainObject.FK_GECurrencyID == GECurrencyID.VND)
                {
                    mainObject.MMCalculatorProductionNormCostCostPrice = entity.CalculatorProductionNormCostItemList.Sum(o => o.MMCalculatorProductionNormCostItemCostPriceExchange);
                }
                else
                {
                    mainObject.MMCalculatorProductionNormCostCostPrice = entity.CalculatorProductionNormCostItemList.Sum(o => o.MMCalculatorProductionNormCostItemCostPrice);
                }
            }
        }

        public void CalCostNorm(MMProductionNormCostFactorsInfo pncf, BOSList<MMCalculatorProductionNormCostItemsInfo> calPNCostList, List<MMProductionNormCostFactorsInfo> pncfList)
        {
            if (pncf.IsCal == 0)
            {
                pncf.IsCal = 1;
                if (string.IsNullOrEmpty(pncf.MMProductionNormCostFactorFormula))
                {

                    MMCalculatorProductionNormCostItemsInfo match = calPNCostList
                                                                     .FirstOrDefault(t => t.MMCalculatorProductionNormCostItemNo == pncf.MMProductionNormCostFactorNo);
                    if (match != null)
                    {
                        pncf.CostPrice = match.MMCalculatorProductionNormCostItemCostPrice;
                    }
                }
                else
                {
                    string compareNo = string.Empty;
                    string mathString = pncf.MMProductionNormCostFactorFormula;
                    foreach (MMProductionNormCostFactorsInfo item in pncfList)
                    {
                        compareNo = "[" + item.MMProductionNormCostFactorNo + "]";
                        if (pncf.MMProductionNormCostFactorFormula.Contains(compareNo))
                        {
                            CalCostNorm(item, calPNCostList, pncfList);
                            mathString = mathString.Replace(compareNo, item.CostPrice.ToString());
                        }
                    }

                    DataTable dt = new DataTable();
                    pncf.CostPrice = Convert.ToDecimal(dt.Compute(mathString, ""));

                }
            }
        }

        public void RefreshProductItemTreeListView(BOSTreeList treelist)
        {
            if (treelist != null && treelist.TreeListControl != null)
            {
                treelist.TreeListControl.RefreshDataSource();
                treelist.TreeListControl.ExpandAll();
                treelist.TreeListControl.BestFitColumns();
            }
        }

        #region Đỗ dữ liệu theo LSX
        public void LoadSemiProductTreeListByLSX(int batchProductID)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;

            entity.ProductionNormItemList.Clear();

            MMBatchProductProductionNormItemsController bpptniController = new MMBatchProductProductionNormItemsController();
            List<MMBatchProductProductionNormItemsInfo> pniList = bpptniController.GetBPPNItemByBatchProductIDAndGroup(BatchProductGroup.SemiProduct.ToString(), batchProductID);

            if (pniList != null && pniList.Any())
            {
                AddSemiProductToListByLSX(0, pniList, entity.ProductionNormItemList, string.Empty);
                RefreshProductItemTreeListView(entity.ProductionNormItemList);
            }

        }
        public void AddSemiProductToListByLSX(int parentID, List<MMBatchProductProductionNormItemsInfo> pniList, IBOSTreeList treeList, string priceType)
        {
            List<MMBatchProductProductionNormItemsInfo> collection = pniList.Where(t => t.MMBatchProductProductionNormItemParentID == parentID).ToList();
            if (collection != null
                && collection.Any())
            {
                MMCalculatorProductionNormItemsInfo newItem;
                collection.ForEach(pni =>
                {
                    newItem = new MMCalculatorProductionNormItemsInfo();
                    BOSUtil.CopyObject(pni, newItem);
                    newItem.MMCalculatorProductionNormItemID = 0;
                    newItem.MMCalculatorProductionNormItemParentID = 0;
                    newItem.FK_MMProductionNormItemID = pni.FK_MMProductionNormItemID;
                    newItem.FK_MMBatchProductProductionNormItemID = pni.MMBatchProductProductionNormItemID;
                    if (priceType == "NormPrice")
                        newItem.MMCalculatorProductionNormItemProductUnitCost = pni.ICProductSupplierPrice;
                    else
                        newItem.MMCalculatorProductionNormItemProductUnitCost = pni.ProductCost;
                    newItem.MMCalculatorProductionNormItemTotalCost = newItem.MMCalculatorProductionNormItemProductUnitCost *
                                                                    newItem.MMCalculatorProductionNormItemQuantity;
                    treeList.Add(newItem);

                    newItem.SubList = new BOSTreeList();
                    AddSemiProductToListByLSX(pni.MMBatchProductProductionNormItemID, pniList, newItem.SubList, string.Empty);
                });
            }
        }
        //public void LoadMaterialListByLSX(int batchProductID)
        //{
        //    CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
        //    MMCalculatorProductionNormItemMaterialsController cpnimCtrl = new MMCalculatorProductionNormItemMaterialsController();
        //    List<MMCalculatorProductionNormItemMaterialsInfo> cpnimList = cpnimCtrl.GetBybatchProductID(batchProductID);

        //    entity.CalculatorProductionNormItemMaterialList.Clear();
        //    entity.CalculatorProductionNormItemMaterialList.AddRange(cpnimList);
        //    entity.CalculatorProductionNormItemMaterialList.GridControl?.RefreshDataSource();

        //    UpdateTotalCostGo(false);

        //}
        //public void LoadHardwareListByLSX(int batchProductID, DateTime effectiveDate)
        //{
        //    CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
        //    MMBatchProductProductionNormItemsController pniCtrl = new MMBatchProductProductionNormItemsController();
        //    List<MMBatchProductProductionNormItemsInfo> pniList = pniCtrl.GetByGroupAndBatchProductID(ProductType.Hardware.ToString(), batchProductID, effectiveDate);

        //    entity.HardwareList.Clear();

        //    if (pniList != null && pniList.Any())
        //    {
        //        string priceType = GetPriceType(ProductType.Hardware.ToString());
        //        AddSemiProductToListByLSX(0, pniList, entity.HardwareList, priceType);
        //        RefreshProductItemTreeListView(entity.HardwareList);
        //    }
        //    UpdateTotalCostHW(false);
        //}
        //public void LoadIngredientPackagingListByLSX(int batchProductID, DateTime effectiveDate)
        //{
        //    CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
        //    MMBatchProductProductionNormItemsController pniCtrl = new MMBatchProductProductionNormItemsController();
        //    List<MMBatchProductProductionNormItemsInfo> pniList = pniCtrl.GetByGroupAndBatchProductID(ProductType.IngredientPackaging.ToString(), batchProductID, effectiveDate);

        //    entity.IngredientPackagingList.Clear();

        //    if (pniList != null && pniList.Any())
        //    {
        //        string priceType = GetPriceType(ProductType.IngredientPackaging.ToString());
        //        AddSemiProductToListByLSX(0, pniList, entity.IngredientPackagingList, priceType);
        //        RefreshProductItemTreeListView(entity.IngredientPackagingList);
        //    }
        //    UpdateTotalCostIngredientPackaging(false);
        //}
        //public void LoadPaintListByLSX(int batchProductID, DateTime effectiveDate)
        //{
        //    CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
        //    MMBatchProductProductionNormItemsController pniCtrl = new MMBatchProductProductionNormItemsController();
        //    List<MMBatchProductProductionNormItemsInfo> pniList = pniCtrl.GetByGroupAndBatchProductID(ProductType.IngredientPaint.ToString(), batchProductID, effectiveDate);

        //    entity.PaintList.Clear();

        //    if (pniList != null && pniList.Any())
        //    {
        //        string priceType = GetPriceType(ProductType.IngredientPaint.ToString());
        //        AddSemiProductToListByLSX(0, pniList, entity.PaintList, priceType);
        //        entity.ReDrawPaintTreeList();
        //        RefreshProductItemTreeListView(entity.PaintList);
        //    }
        //    UpdateTotalCostPaint(false);
        //}
        //public void LoadGeneralMaterialListByLSX(int batchProductID, DateTime effectiveDate)
        //{
        //    CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
        //    MMBatchProductProductionNormItemsController pniCtrl = new MMBatchProductProductionNormItemsController();
        //    List<MMBatchProductProductionNormItemsInfo> pniList = pniCtrl.GetByGroupAndBatchProductID(ProductType.GeneralMaterial.ToString(), batchProductID, effectiveDate);

        //    entity.GeneralMaterialList.Clear();

        //    if (pniList != null && pniList.Any())
        //    {
        //        MMCalculatorProductionNormItemsInfo newItem;

        //        foreach (MMBatchProductProductionNormItemsInfo pni in pniList)
        //        {
        //            newItem = new MMCalculatorProductionNormItemsInfo();
        //            BOSUtil.CopyObject(pni, newItem);
        //            newItem.MMCalculatorProductionNormItemID = 0;
        //            newItem.MMCalculatorProductionNormItemParentID = 0;
        //            newItem.FK_MMProductionNormItemID = pni.FK_MMProductionNormItemID;
        //            newItem.FK_MMBatchProductProductionNormItemID = pni.MMBatchProductProductionNormItemID;
        //            newItem.MMCalculatorProductionNormItemProductUnitCost = pni.ProductCost;
        //            newItem.MMCalculatorProductionNormItemTotalCost = newItem.MMCalculatorProductionNormItemProductUnitCost *
        //                                                            newItem.MMCalculatorProductionNormItemQuantity;
        //            entity.GeneralMaterialList.Add(newItem);
        //        }
        //    }

        //    entity.GeneralMaterialList.GridControl?.RefreshDataSource();

        //    UpdateTotalCostVTK(false);

        //}
        #endregion

        public void LoadSemiProductTreeList(int productionNormID)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;

            entity.ProductionNormItemList.Clear();

            MMProductionNormItemsController pniController = new MMProductionNormItemsController();
            List<MMProductionNormItemsInfo> pniList = pniController.GetProductionNormItemsByGroupTypeAndProductionNormID(BatchProductGroup.SemiProduct.ToString(), productionNormID);

            if (pniList != null && pniList.Any())
            {
                AddSemiProductToList(0, pniList, entity.ProductionNormItemList, string.Empty);
                RefreshProductItemTreeListView(entity.ProductionNormItemList);
            }

        }

        public void AddSemiProductToList(int parentID, List<MMProductionNormItemsInfo> pniList, IBOSTreeList treeList, string priceType)
        {
            List<MMProductionNormItemsInfo> collection = pniList.Where(t => t.MMProductionNormItemParentID == parentID).ToList();
            if (collection != null
                && collection.Any())
            {
                MMCalculatorProductionNormItemsInfo newItem;
                collection.ForEach(pni =>
                {
                    newItem = new MMCalculatorProductionNormItemsInfo();
                    BOSUtil.CopyObject(pni, newItem);
                    newItem.MMCalculatorProductionNormItemID = 0;
                    newItem.MMCalculatorProductionNormItemParentID = 0;
                    newItem.FK_MMProductionNormItemID = pni.MMProductionNormItemID;
                    if (priceType == "NormPrice")
                        newItem.MMCalculatorProductionNormItemProductUnitCost = pni.ICProductSupplierPrice;
                    else
                        newItem.MMCalculatorProductionNormItemProductUnitCost = pni.ProductCost;
                    newItem.MMCalculatorProductionNormItemQuantity = pni.MMProductionNormItemQuantity;
                    newItem.MMCalculatorProductionNormItemTotalCost = newItem.MMCalculatorProductionNormItemProductUnitCost *
                                                                    newItem.MMCalculatorProductionNormItemQuantity;
                    treeList.Add(newItem);

                    newItem.SubList = new BOSTreeList();
                    AddSemiProductToList(pni.MMProductionNormItemID, pniList, newItem.SubList, string.Empty);
                });
            }
        }

        public void UpdateExchangeAmount(int curencyID)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMCalculatorProductionNormCostsInfo mainObject = (MMCalculatorProductionNormCostsInfo)entity.MainObject;
            mainObject.FK_GECurrencyID = curencyID;
            if (mainObject.MMCalculatorProductionNormCostID == 0)
            {
                decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateByCurrencyAndDate(mainObject.FK_GECurrencyID, mainObject.MMCalculatorProductionNormCostDate);
                mainObject.MMCalculatorProductionNormCostExchangeRate = dCurrencyExchangeRate;
                entity.UpdateMainObjectBindingSource();

                if (entity.CalculatorProductionNormCostItemList != null && entity.CalculatorProductionNormCostItemList.Count > 0)
                {
                    if (mainObject.MMCalculatorProductionNormCostExchangeRate == 0)
                    {
                        mainObject.MMCalculatorProductionNormCostExchangeRate = 1;
                        mainObject.FK_GECurrencyID = GECurrencyID.VND;
                    }
                    entity.CalculatorProductionNormCostItemList.ForEach(c =>
                    {
                        c.MMCalculatorProductionNormCostItemCostPriceExchange
                            = c.MMCalculatorProductionNormCostItemCostPrice / mainObject.MMCalculatorProductionNormCostExchangeRate;
                    });

                }

                MMCalculatorProductionNormCostItemsInfo setCostPrice = entity.CalculatorProductionNormCostItemList.Where(p => p.MMProductionNormCostFactorIsSetCostPrice).FirstOrDefault();
                if (setCostPrice != null)
                {
                    if (mainObject.FK_GECurrencyID == GECurrencyID.VND)
                        mainObject.MMCalculatorProductionNormCostCostPrice = setCostPrice.MMCalculatorProductionNormCostItemCostPrice;
                    else
                        mainObject.MMCalculatorProductionNormCostCostPrice = setCostPrice.MMCalculatorProductionNormCostItemCostPriceExchange;
                }
                entity.CalculatorProductionNormCostItemList.GridControl?.RefreshDataSource();
            }
        }

        public void ChangeCostGridFormat()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMCalculatorProductionNormCostsInfo mainObject = (MMCalculatorProductionNormCostsInfo)entity.MainObject;
            int curencyID = 0;
            if (mainObject != null)
            {
                curencyID = mainObject.FK_GECurrencyID;
            }
            CostGridControl.ChangeGridFormat(curencyID);
        }

        public DataSet GetAllFormulas()
        {
            MMFormulasController formulasController = new MMFormulasController();
            DataSet ds = formulasController.GetFormulaData();
            return ds;
        }

        public List<ICProductsInfo> GetWoodIngredient()
        {
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> objProductsInfoList = new List<ICProductsInfo>();
            objProductsInfoList.Add(new ICProductsInfo());
            objProductsInfoList.AddRange(objProductsController.GetProductByDepartmentID(DepartmentID.Wood));
            return objProductsInfoList;
        }
        #region Summary

        public void GetSumPNormItemQty(ref decimal result, IBOSTreeList itemList)
        {
            foreach (MMCalculatorProductionNormItemsInfo item in itemList)
            {
                if (item.SubList == null || !item.SubList.Any())
                {
                    result += item.MMCalculatorProductionNormItemQuantity;
                }
                else
                {
                    GetSumPNormItemQty(ref result, item.SubList);

                }
            }
        }

        public decimal GetSumProductionNormItemQty()
        {
            decimal result = 0;
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            ICProductsController objProductsController = new ICProductsController();
            foreach (MMCalculatorProductionNormItemsInfo item in entity.ProductionNormItemList)
            {
                if (item.SubList == null || !item.SubList.Any())
                {
                    result += item.MMCalculatorProductionNormItemQuantity;
                }
                else
                {
                    GetSumPNormItemQty(ref result, item.SubList);

                }
            }
            return result;
        }

        public decimal GetSumProductionNormItemBlocks()
        {
            decimal result = 0;
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            foreach (MMCalculatorProductionNormItemsInfo item in entity.ProductionNormItemList)
            {
                result += item.MMCalculatorProductionNormItemWoodBlocks;
            }
            return result;
        }
        public decimal GetSumProductionNormItemWoodConsumable()
        {
            decimal result = 0;
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            foreach (MMCalculatorProductionNormItemsInfo item in entity.ProductionNormItemList)
            {
                result += item.MMCalculatorProductionNormItemTotalWoodConsumable;
            }
            return result;
        }
        public decimal GetSumProductionNormItemMDFBlock()
        {
            decimal result = 0;
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            foreach (MMCalculatorProductionNormItemsInfo item in entity.ProductionNormItemList)
            {
                result += item.MMCalculatorProductionNormItemMDFBlocks;
            }
            return result;
        }
        public decimal GetSumProductionNormItemPaintA()
        {
            decimal result = 0;
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            foreach (MMCalculatorProductionNormItemsInfo item in entity.ProductionNormItemList)
            {
                result += item.MMCalculatorProductionNormItemPaintA;
            }
            return result;
        }
        public decimal GetSumProductionNormItemPaintB()
        {
            decimal result = 0;
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            foreach (MMCalculatorProductionNormItemsInfo item in entity.ProductionNormItemList)
            {
                result += item.MMCalculatorProductionNormItemPaintB;
            }
            return result;
        }
        public decimal GetSumProductionNormItemVeneer()
        {
            decimal result = 0;
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            foreach (MMCalculatorProductionNormItemsInfo item in entity.ProductionNormItemList)
            {
                result += item.MMCalculatorProductionNormItemVeneer;
            }
            return result;
        }


        #endregion

        public void RemoveSelectedItemFromGeneralMaterialList()
        {

            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            entity.GeneralMaterialList.RemoveSelectedRowObjectFromList();
            UpdateTotalCostVTK(true);

        }

        public void AddPLDGParent(string productIDList)
        {
            ICProductsController objProductsController = new ICProductsController();
            string[] productIDs = productIDList.Split(',');
            //reset repeat: variable to check exit
            repeat = false;
            foreach (string productIDStr in productIDs)
            {
                int productID = 0;
                if (int.TryParse(productIDStr.Trim(), out productID))
                {

                    AddPLDGFromNormProduct(productID, true);
                }
            }
        }
        public bool repeat = false;
        public void AddPLDGFromNormProduct(int productID, bool isPackProduct)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMCalculatorProductionNormCostsInfo objProductionNormsInfo = (MMCalculatorProductionNormCostsInfo)entity.MainObject;

            ICPackagingNormItemsController objPackagingNormItemsController = new ICPackagingNormItemsController();
            if (productID > 0)
            {
                List<ICPackagingNormItemsInfo> packList;
                if (!isPackProduct)
                    packList = objPackagingNormItemsController.GetPackagingNormItemByParentProduct(productID);
                else
                    packList = objPackagingNormItemsController.GetPackagingNormItemByPackProduct(productID);
                if (packList != null && packList.Count > 0)
                {
                    List<ICPackagingNormItemsInfo> packParentList = packList.Where(p => p.FK_ICProductID == p.FK_ICProductParentID).ToList();
                    packParentList.ForEach(p =>
                    {
                        MMCalculatorProductionNormItemsInfo objProductionNormItemsInfo = new MMCalculatorProductionNormItemsInfo();
                        bool updateParent = false;

                        //Check Exits Parent
                        entity.IngredientPackagingList.ForEach(pack =>
                        {
                            MMCalculatorProductionNormItemsInfo objExit = (MMCalculatorProductionNormItemsInfo)pack;
                            if (objExit.FK_ICProductID == p.FK_ICProductID)
                            {

                                DialogResult dlgResult = DialogResult.No;
                                if (!repeat)
                                {
                                    dlgResult = MessageBox.Show(string.Format(ProductionNormLocalizeResources.MaterialExitsInListMessage, p.ICPackagingNormItemProductDesc)
                                           + Environment.NewLine + "Cancel: Cập nhật và không hỏi lại"
                                           + Environment.NewLine + "Yes: Thêm mới"
                                           + Environment.NewLine + "No: Thoát"
                                          , MESLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                                }
                                if (dlgResult == DialogResult.Cancel)
                                {
                                    objProductionNormItemsInfo = objExit;
                                    repeat = true;
                                    updateParent = true;
                                }
                                else if (dlgResult == DialogResult.No)
                                {
                                    return;
                                }
                            }
                        }
                            );

                        SetValuePackagingItemFromNormProduct(p, p.ICPackagingNormItemProductName, objProductionNormItemsInfo);
                        objProductionNormItemsInfo.MMCalculatorProductionNormItemGroup = ProductType.IngredientPackaging.ToString();
                        objProductionNormItemsInfo.MMCalculatorProductionNormItemSortOrder = entity.IngredientPackagingList.Count;
                        objProductionNormItemsInfo.MMCalculatorProductionNormItemQuantity = p.ICPackagingNormItemProductQty;
                        objProductionNormItemsInfo.MMCalculatorProductionNormItemIsComponent = true;

                        List<ICPackagingNormItemsInfo> packChilrentList = packList.Where(c => c.FK_ICProductParentID == p.FK_ICProductID
                                                                                        && c.FK_ICProductID != p.FK_ICProductID).ToList();
                        if (packChilrentList != null && packChilrentList.Count > 0)
                        {
                            packChilrentList.ForEach(c =>
                            {
                                if (objProductionNormItemsInfo != null && objProductionNormItemsInfo.SubList == null)
                                {
                                    objProductionNormItemsInfo.SubList = new BOSTreeList();
                                    objProductionNormItemsInfo.HasChildren();
                                }

                                MMCalculatorProductionNormItemsInfo objProductionNormItemChildsInfo = new MMCalculatorProductionNormItemsInfo();
                                bool existChild = false;
                                if (updateParent)
                                {
                                    if (objProductionNormItemsInfo.SubList != null && objProductionNormItemsInfo.SubList.Count > 0)
                                    {
                                        foreach (MMCalculatorProductionNormItemsInfo itemChild in objProductionNormItemsInfo.SubList)
                                        {
                                            if (itemChild.FK_ICProductID == c.FK_ICProductID)
                                            {
                                                objProductionNormItemChildsInfo = itemChild;
                                                existChild = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                                SetValuePackagingItemFromNormProduct(c, p.ICPackagingNormItemProductName, objProductionNormItemChildsInfo);
                                objProductionNormItemChildsInfo.MMCalculatorProductionNormItemGroup = ProductType.IngredientPackaging.ToString();
                                objProductionNormItemChildsInfo.MMCalculatorProductionNormItemIsComponent = false;
                                objProductionNormItemChildsInfo.MMCalculatorProductionNormItemSortOrder = objProductionNormItemsInfo.SubList.Count;
                                objProductionNormItemChildsInfo.MMCalculatorProductionNormItemQuantity = c.ICPackagingNormItemProductQty;
                                if (!existChild)
                                    objProductionNormItemsInfo.SubList.Add(objProductionNormItemChildsInfo);
                            }
                            );
                        }
                        if (!updateParent)
                            entity.IngredientPackagingList.Add(objProductionNormItemsInfo);
                    }
                    );
                }
            }
            RefreshPackagingItemList();
            UpdateTotalCostIngredientPackaging(true);
        }
        public void RefreshPackagingItemList()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;

            entity.IngredientPackagingList.TreeListControl.RefreshDataSource();
            entity.IngredientPackagingList.TreeListControl.ForceInitialize();
            entity.IngredientPackagingList.TreeListControl.DragNodesMode = TreeListDragNodesMode.Advanced;
            entity.IngredientPackagingList.TreeListControl.OptionsBehavior.CanCloneNodesOnDrop = false;
            entity.IngredientPackagingList.TreeListControl.OptionsBehavior.AutoChangeParent = false;
            entity.IngredientPackagingList.TreeListControl.ClearSorting();
            entity.IngredientPackagingList.TreeListControl.Columns["MMCalculatorProductionNormItemSortOrder"].SortOrder = SortOrder.Ascending;
            entity.IngredientPackagingList.TreeListControl.ExpandAll();
            entity.IngredientPackagingList.TreeListControl.BestFitColumns();

            //SetDefaultCartonDemesion();
            CalculateProductionNormItemPackaging(string.Empty);
        }

        public void CalculateProductionNormItemPackaging(string editColumnName)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            if (editColumnName == "MMCalculatorProductionNormItemProductInsideDimensionHeight"
                || editColumnName == "MMCalculatorProductionNormItemProductInsideDimensionWidth"
                || editColumnName == "MMCalculatorProductionNormItemProductInsideDimensionLength"
                || editColumnName == "FK_ICProdAttPackingMaterialSpecialityID")
            {

                if (entity.IngredientPackagingList != null && entity.IngredientPackagingList.Count > 0)
                {

                    MMCalculatorProductionNormItemsInfo productionNormItem = (MMCalculatorProductionNormItemsInfo)entity.IngredientPackagingList.CurrentObject;
                    if (productionNormItem != null)
                    {

                        MMOverallInsideDimensionConfigsController objOverallInsideDimensionConfigsController = new MMOverallInsideDimensionConfigsController();
                        List<MMOverallInsideDimensionConfigsInfo> overallInsideDimensionConfigsList = new List<MMOverallInsideDimensionConfigsInfo>();
                        MMOverallInsideDimensionConfigsInfo objOverallInsideDimensionConfigsInfo = new MMOverallInsideDimensionConfigsInfo();


                        productionNormItem.MMCalculatorProductionNormItemProductOverallDimensionHeight = 0;
                        productionNormItem.MMCalculatorProductionNormItemProductOverallDimensionWidth = 0;
                        productionNormItem.MMCalculatorProductionNormItemProductOverallDimensionLength = 0;
                        if (productionNormItem.FK_ICProdAttPackingMaterialSpecialityID > 0)
                        {
                            #region Height
                            overallInsideDimensionConfigsList
                                = objOverallInsideDimensionConfigsController.GetConfigByAttributeIDAndType(productionNormItem.FK_ICProdAttPackingMaterialSpecialityID, OverallInsideDimensionConfigType.Height.ToString(), productionNormItem.FK_ICProductGroupID);
                            objOverallInsideDimensionConfigsInfo = overallInsideDimensionConfigsList.FirstOrDefault();
                            if (objOverallInsideDimensionConfigsInfo != null)
                            {
                                productionNormItem.MMCalculatorProductionNormItemProductOverallDimensionHeight = CalculateOverallDimension(objOverallInsideDimensionConfigsInfo,
                                                                                                                   productionNormItem.MMCalculatorProductionNormItemProductInsideDimensionHeight);
                            }
                            #endregion
                            #region Width
                            overallInsideDimensionConfigsList
                                = objOverallInsideDimensionConfigsController.GetConfigByAttributeIDAndType(productionNormItem.FK_ICProdAttPackingMaterialSpecialityID, OverallInsideDimensionConfigType.Width.ToString(), productionNormItem.FK_ICProductGroupID);
                            objOverallInsideDimensionConfigsInfo = overallInsideDimensionConfigsList.FirstOrDefault();
                            if (objOverallInsideDimensionConfigsInfo != null)
                            {
                                productionNormItem.MMCalculatorProductionNormItemProductOverallDimensionWidth = CalculateOverallDimension(objOverallInsideDimensionConfigsInfo,
                                                                                                                   productionNormItem.MMCalculatorProductionNormItemProductInsideDimensionWidth);
                            }
                            #endregion
                            #region Length
                            overallInsideDimensionConfigsList
                                = objOverallInsideDimensionConfigsController.GetConfigByAttributeIDAndType(productionNormItem.FK_ICProdAttPackingMaterialSpecialityID, OverallInsideDimensionConfigType.Length.ToString(), productionNormItem.FK_ICProductGroupID);
                            objOverallInsideDimensionConfigsInfo = overallInsideDimensionConfigsList.FirstOrDefault();
                            if (objOverallInsideDimensionConfigsInfo != null)
                            {
                                productionNormItem.MMCalculatorProductionNormItemProductOverallDimensionLength = CalculateOverallDimension(objOverallInsideDimensionConfigsInfo,
                                                                                                                   productionNormItem.MMCalculatorProductionNormItemProductInsideDimensionLength);
                            }
                            #endregion
                        }
                    }
                }
            }

            #region Desc
            //KT phủ bì
            string productionNormOverallDimension = string.Empty;
            //KT lọt lòng
            string productionNormInsideDimension = string.Empty;
            foreach (MMCalculatorProductionNormItemsInfo item in entity.IngredientPackagingList)
            {
                #region Desc
                if (!string.IsNullOrEmpty(GetOverallDimension(item)))
                {
                    if (!string.IsNullOrEmpty(productionNormOverallDimension))
                    {
                        productionNormOverallDimension += ";" + GetOverallDimension(item);
                    }
                    else
                    {
                        productionNormOverallDimension += GetOverallDimension(item);
                    }
                }

                if (!string.IsNullOrEmpty(GetInsideDimension(item)))
                {
                    if (!string.IsNullOrEmpty(productionNormInsideDimension))
                    {
                        productionNormInsideDimension += ";" + GetInsideDimension(item);
                    }
                    else
                    {
                        productionNormInsideDimension += GetInsideDimension(item);
                    }
                }
                #endregion


                if (item.SubList != null && item.SubList.Count > 0)
                {
                    foreach (MMCalculatorProductionNormItemsInfo subItem in item.SubList)
                    {
                        #region Desc
                        if (!string.IsNullOrEmpty(GetOverallDimension(subItem)))
                        {
                            if (!string.IsNullOrEmpty(productionNormOverallDimension))
                            {
                                productionNormOverallDimension += ";" + GetOverallDimension(subItem);
                            }
                            else
                            {
                                productionNormOverallDimension += GetOverallDimension(subItem);
                            }

                            if (!string.IsNullOrEmpty(GetInsideDimension(subItem)))
                            {
                                if (!string.IsNullOrEmpty(productionNormInsideDimension))
                                {
                                    productionNormInsideDimension += ";" + GetInsideDimension(subItem);
                                }
                                else
                                {
                                    productionNormInsideDimension += GetInsideDimension(subItem);
                                }
                            }
                        }
                        #endregion
                    }
                }
            }

            #region Desc
            ////KT phủ bì
            //objProductionNormsInfo.MMCalculatorProductionNormOverallDimension = productionNormOverallDimension;
            ////KT lọt lòng
            //objProductionNormsInfo.MMCalculatorProductionNormInsideDimension = productionNormInsideDimension;
            #endregion
            #endregion

            entity.IngredientPackagingList.TreeListControl.RefreshDataSource();
            entity.IngredientPackagingList.TreeListControl.ExpandAll();
            entity.IngredientPackagingList.TreeListControl.BestFitColumns();
        }

        public string GetOverallDimension(MMCalculatorProductionNormItemsInfo item)
        {
            string result = string.Empty;
            result += (int)item.MMCalculatorProductionNormItemProductOverallDimensionLength + "x";
            result += (int)item.MMCalculatorProductionNormItemProductOverallDimensionWidth + "x";
            result += (int)item.MMCalculatorProductionNormItemProductOverallDimensionHeight;
            return result;
        }
        public string GetInsideDimension(MMCalculatorProductionNormItemsInfo item)
        {
            string result = string.Empty;
            result += (int)item.MMCalculatorProductionNormItemProductInsideDimensionLength + "x";
            result += (int)item.MMCalculatorProductionNormItemProductInsideDimensionWidth + "x";
            result += (int)item.MMCalculatorProductionNormItemProductInsideDimensionHeight;
            return result;
        }

        public decimal CalculateOverallDimension(MMOverallInsideDimensionConfigsInfo objOverallInsideDimensionConfigsInfo, decimal insideDimension)
        {
            decimal overallDimension = 0;
            if (insideDimension > 0)
            {
                int value = objOverallInsideDimensionConfigsInfo.MMOverallInsideDimensionConfigOperationValue;
                if (objOverallInsideDimensionConfigsInfo.MMOverallInsideDimensionConfigOperationType == OperationType.Plus.ToString())
                {
                    overallDimension = insideDimension + value;
                }
                else if (objOverallInsideDimensionConfigsInfo.MMOverallInsideDimensionConfigOperationType == OperationType.Minus.ToString())
                {
                    overallDimension = insideDimension - value;
                }
                else if (objOverallInsideDimensionConfigsInfo.MMOverallInsideDimensionConfigOperationType == OperationType.Multi.ToString())
                {
                    overallDimension = insideDimension * value;
                }
                else if (objOverallInsideDimensionConfigsInfo.MMOverallInsideDimensionConfigOperationType == OperationType.Split.ToString())
                {
                    if (value != 0)
                    {
                        overallDimension = insideDimension / value;
                    }
                }
            }
            return overallDimension;
        }


        public MMCalculatorProductionNormItemsInfo SetValuePackagingItemFromNormProduct(ICPackagingNormItemsInfo objProductsInfo, string ProductName, MMCalculatorProductionNormItemsInfo objPackagingItemsInfo)
        {
            objPackagingItemsInfo.FK_ICProductID = objProductsInfo.FK_ICProductID;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductName = objProductsInfo.ICPackagingNormItemProductName;
            objPackagingItemsInfo.MMCalculatorProductionNormItemNo = objProductsInfo.ICPackagingNormItemNo;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductDesc = objProductsInfo.ICPackagingNormItemProductDesc.Trim();
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
            objPackagingItemsInfo.MMCalculatorProductionNormItemPackagingNW = objProductsInfo.ICPackagingNormItemPackagingNW;
            objPackagingItemsInfo.MMCalculatorProductionNormItemPackagingGW = objProductsInfo.ICPackagingNormItemPackagingGW;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductSizeAndPacking = objProductsInfo.ICPackagingNormItemProductSizeAndPacking;
            objPackagingItemsInfo.MMCalculatorProductionNormItemComment = objProductsInfo.ICPackagingNormItemComment;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductInsideDimensionLength = objProductsInfo.ICPackagingNormItemProductInsideDimensionLength;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductInsideDimensionWidth = objProductsInfo.ICPackagingNormItemProductInsideDimensionWidth;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductInsideDimensionHeight = objProductsInfo.ICPackagingNormItemProductInsideDimensionHeight;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductOverallDimensionLength = objProductsInfo.ICPackagingNormItemProductOverallDimensionLength;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductOverallDimensionWidth = objProductsInfo.ICPackagingNormItemProductOverallDimensionWidth;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductOverallDimensionHeight = objProductsInfo.ICPackagingNormItemProductOverallDimensionHeight;
            objPackagingItemsInfo.FK_ICProdAttPackingMaterialSpecialityID = objProductsInfo.FK_ICProdAttPackingMaterialSpecialityID;
            objPackagingItemsInfo.FK_ICProdAttPackingMaterialSizeID = objProductsInfo.FK_ICProdAttPackingMaterialSizeID;
            objPackagingItemsInfo.FK_ICProdAttPackingMaterialWeightPerVolumeID = objProductsInfo.FK_ICProdAttPackingMaterialWeightPerVolumeID;
            objPackagingItemsInfo.MMCalculatorProductionNormItemNeededTime = DateTime.Now;
            objPackagingItemsInfo.MMCalculatorProductionNormItemParentOrderName = ProductName;
            objPackagingItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objPackagingItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            objPackagingItemsInfo.MMCalculatorProductionNormItemUnit = objProductsInfo.ICMeasureUnitName;
            objPackagingItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICMeasureUnitID;
            if (objPackagingItemsInfo.SubList == null)
                objPackagingItemsInfo.SubList = new BOSTreeList();
            return objPackagingItemsInfo;
        }

        public void AddPLDGChild(string productIDList)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            if (entity.IngredientPackagingList.CurrentObject != null)
            {
                MMCalculatorProductionNormItemsInfo currentItemsInfo = (MMCalculatorProductionNormItemsInfo)entity.IngredientPackagingList.CurrentObject;
                if (currentItemsInfo.MMCalculatorProductionNormItemIsComponent)
                {
                    ICProductsController objProductsController = new ICProductsController();
                    string[] productIDs = productIDList.Split(',');
                    foreach (string productIDStr in productIDs)
                    {
                        int productID = 0;
                        if (int.TryParse(productIDStr.Trim(), out productID))
                        {
                            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
                            if (objProductsInfo != null)
                            {
                                AddPLDGChildToPackagingItemsList(objProductsInfo);
                            }
                        }
                    }
                }
            }

        }

        public void AddPLDGChildToPackagingItemsList(ICProductsInfo productObject)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            List<MMProductionNormItemsInfo> currentPackagingItemsList = new List<MMProductionNormItemsInfo>();

            if (entity.IngredientPackagingList.CurrentObject != null && entity.IngredientPackagingList.CurrentObject.SubList == null)
            {
                entity.IngredientPackagingList.CurrentObject.SubList = new BOSTreeList();
                entity.IngredientPackagingList.CurrentObject.HasChildren();
            }

            MMCalculatorProductionNormItemsInfo objProductionNormItemsInfo = new MMCalculatorProductionNormItemsInfo();
            objProductionNormItemsInfo = SetValuePackagingItemFromProduct(productObject, productObject.ICProductName);
            objProductionNormItemsInfo.MMCalculatorProductionNormItemGroup = ProductType.IngredientPackaging.ToString();
            objProductionNormItemsInfo.MMCalculatorProductionNormItemIsComponent = false;
            objProductionNormItemsInfo.MMCalculatorProductionNormItemSortOrder = entity.IngredientPackagingList.CurrentObject.SubList.Count;
            entity.IngredientPackagingList.CurrentObject.SubList.Add(objProductionNormItemsInfo);
            RefreshPackagingItemList();

        }

        public MMCalculatorProductionNormItemsInfo SetValuePackagingItemFromProduct(ICProductsInfo objProductsInfo, string ProductName)
        {
            MMCalculatorProductionNormItemsInfo objPackagingItemsInfo = new MMCalculatorProductionNormItemsInfo();
            MMCalculatorProductionNormItemsInfo objToGetPackagingItemsInfo = new MMCalculatorProductionNormItemsInfo();
            string heightOrThick = string.Empty;
            objPackagingItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductName = objProductsInfo.ICProductName;
            objPackagingItemsInfo.MMCalculatorProductionNormItemNo = objProductsInfo.ICProductNo;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductDesc = objProductsInfo.ICProductDesc.Trim();
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductLength = objProductsInfo.ICProductLength;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductWidth = objProductsInfo.ICProductWidth;
            objPackagingItemsInfo.MMCalculatorProductionNormItemPackagingNW = objProductsInfo.ICProductNetWeight;
            objPackagingItemsInfo.MMCalculatorProductionNormItemPackagingGW = objProductsInfo.ICProductGrossWeight;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductInsideDimensionLength = objProductsInfo.ICProductInsideDimensionLength;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductInsideDimensionWidth = objProductsInfo.ICProductInsideDimensionWidth;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductInsideDimensionHeight = objProductsInfo.ICProductInsideDimensionHeight;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductOverallDimensionLength = objProductsInfo.ICProductOverallDimensionLength;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductOverallDimensionWidth = objProductsInfo.ICProductOverallDimensionWidth;
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductOverallDimensionHeight = objProductsInfo.ICProductOverallDimensionHeight;
            objPackagingItemsInfo.FK_ICProdAttPackingMaterialSpecialityID = objProductsInfo.FK_ICProdAttPackingMaterialSpecialityID;
            objPackagingItemsInfo.FK_ICProdAttPackingMaterialSizeID = objProductsInfo.FK_ICProdAttPackingMaterialSizeID;
            objPackagingItemsInfo.MMCalculatorProductionNormItemNeededTime = DateTime.Now;
            objPackagingItemsInfo.MMCalculatorProductionNormItemParentOrderName = ProductName;
            objPackagingItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objPackagingItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            if (objProductsInfo.ICProductHeight != 0)
                objPackagingItemsInfo.MMCalculatorProductionNormItemProductHeight = objProductsInfo.ICProductHeight;

            //Get unit from Products
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();
            objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByID(objProductsInfo.FK_ICProductBasicUnitID);
            if (objMeasureUnitsInfo != null)
            {
                objPackagingItemsInfo.MMCalculatorProductionNormItemUnit = objMeasureUnitsInfo.ICMeasureUnitName;
                objPackagingItemsInfo.FK_ICMeasureUnitID = objMeasureUnitsInfo.ICMeasureUnitID;
            }

            objPackagingItemsInfo.MMCalculatorProductionNormItemProductDesc = objProductsInfo.ICProductDesc.Trim();
            //  objPackagingItemsInfo.MMProductionNormItemPackagingGW = objProductsInfo.ICProductGW.ToString();
            // objPackagingItemsInfo.MMProductionNormItemPackagingNW = objProductsInfo.ICProductNW.ToString();
            objPackagingItemsInfo.MMCalculatorProductionNormItemProductSizeAndPacking = objProductsInfo.ICProductSizeAndSpecifiCations;
            //   objPackagingItemsInfo.MMProductionNormItemProductAttributeValue3 = objProductsInfo.ICProductOverallDimension;
            //objPackagingItemsInfo.MMProductionNormItemProductAttributeValue6 = objProductsInfo.ICProductInsideDimension;

            if (objPackagingItemsInfo.SubList == null)
                objPackagingItemsInfo.SubList = new BOSTreeList();
            return objPackagingItemsInfo;
        }
        public void SetDefaultPackagingDescription()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;

            if (entity.IngredientPackagingList != null && entity.IngredientPackagingList.Count > 0)
            {
                ICProductAttributesController objDepartmentAttributeValuesController = new ICProductAttributesController();
                foreach (MMCalculatorProductionNormItemsInfo item in entity.IngredientPackagingList)
                {
                    item.MMCalculatorProductionNormItemProductDesc = string.Empty;
                    if (!string.IsNullOrEmpty(item.MMCalculatorProductionNormItemProductName))
                    {
                        item.MMCalculatorProductionNormItemProductDesc += item.MMCalculatorProductionNormItemProductName.Trim();
                    }
                    if (!(item.MMCalculatorProductionNormItemProductInsideDimensionWidth == 0
                        && item.MMCalculatorProductionNormItemProductInsideDimensionLength == 0
                        && item.MMCalculatorProductionNormItemProductInsideDimensionHeight == 0))
                    {
                        if (!string.IsNullOrEmpty(item.MMCalculatorProductionNormItemProductDesc))
                        {
                            item.MMCalculatorProductionNormItemProductDesc += ", ";
                        }
                        item.MMCalculatorProductionNormItemProductDesc += item.MMCalculatorProductionNormItemProductInsideDimensionLength.ToString("n0").Trim()
                            + "x" + item.MMCalculatorProductionNormItemProductInsideDimensionWidth.ToString("n0").Trim()
                            + "x" + item.MMCalculatorProductionNormItemProductInsideDimensionHeight.ToString("n0").Trim();
                    }
                    if (!(item.MMCalculatorProductionNormItemProductOverallDimensionWidth == 0
                        && item.MMCalculatorProductionNormItemProductOverallDimensionLength == 0
                        && item.MMCalculatorProductionNormItemProductOverallDimensionHeight == 0))
                    {
                        if (!string.IsNullOrEmpty(item.MMCalculatorProductionNormItemProductDesc))
                        {
                            item.MMCalculatorProductionNormItemProductDesc += ", ";
                        }
                        item.MMCalculatorProductionNormItemProductDesc += item.MMCalculatorProductionNormItemProductOverallDimensionLength.ToString("n0").Trim()
                            + "x" + item.MMCalculatorProductionNormItemProductOverallDimensionWidth.ToString("n0").Trim()
                            + "x" + item.MMCalculatorProductionNormItemProductOverallDimensionHeight.ToString("n0").Trim();
                    }
                    if (!string.IsNullOrEmpty(item.MMCalculatorProductionNormItemProductSizeAndPacking))
                    {
                        if (!string.IsNullOrEmpty(item.MMCalculatorProductionNormItemProductDesc))
                        {
                            item.MMCalculatorProductionNormItemProductDesc += ", ";
                        }
                        item.MMCalculatorProductionNormItemProductDesc += item.MMCalculatorProductionNormItemProductSizeAndPacking.Trim();
                    }
                    if (item.FK_ICProdAttPackingMaterialSpecialityID > 0)
                    {
                        ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(item.FK_ICProdAttPackingMaterialSpecialityID);
                        if (objAttribute != null)
                        {
                            if (!string.IsNullOrEmpty(item.MMCalculatorProductionNormItemProductDesc))
                            {
                                item.MMCalculatorProductionNormItemProductDesc += ", ";
                            }
                            item.MMCalculatorProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                        }
                    }
                    if (item.FK_ICProdAttPackingMaterialWeightPerVolumeID > 0)
                    {
                        ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(item.FK_ICProdAttPackingMaterialWeightPerVolumeID);
                        if (objAttribute != null)
                        {
                            if (!string.IsNullOrEmpty(item.MMCalculatorProductionNormItemProductDesc))
                            {
                                item.MMCalculatorProductionNormItemProductDesc += ", ";
                            }
                            item.MMCalculatorProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                        }
                    }
                    if (item.FK_ICProdAttPackingMaterialSizeID > 0)
                    {

                        ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(item.FK_ICProdAttPackingMaterialSizeID);
                        if (objAttribute != null)
                        {
                            if (!string.IsNullOrEmpty(item.MMCalculatorProductionNormItemProductDesc))
                            {
                                item.MMCalculatorProductionNormItemProductDesc += ", ";
                            }
                            item.MMCalculatorProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                        }
                    }
                    if (!string.IsNullOrEmpty(item.MMCalculatorProductionNormItemComment))
                    {
                        if (!string.IsNullOrEmpty(item.MMCalculatorProductionNormItemProductDesc))
                        {
                            item.MMCalculatorProductionNormItemProductDesc += ", ";
                        }
                        item.MMCalculatorProductionNormItemProductDesc += item.MMCalculatorProductionNormItemComment.Trim();
                    }
                    if (item.SubList != null)
                    {
                        foreach (MMCalculatorProductionNormItemsInfo subItem in item.SubList)
                        {
                            subItem.MMCalculatorProductionNormItemProductDesc = string.Empty;
                            if (!string.IsNullOrEmpty(subItem.MMCalculatorProductionNormItemProductName))
                            {
                                subItem.MMCalculatorProductionNormItemProductDesc += subItem.MMCalculatorProductionNormItemProductName.Trim();
                            }
                            if (!(subItem.MMCalculatorProductionNormItemProductInsideDimensionWidth == 0
                                && subItem.MMCalculatorProductionNormItemProductInsideDimensionLength == 0
                                && subItem.MMCalculatorProductionNormItemProductInsideDimensionHeight == 0))
                            {
                                if (!string.IsNullOrEmpty(subItem.MMCalculatorProductionNormItemProductDesc))
                                {
                                    subItem.MMCalculatorProductionNormItemProductDesc += ", ";
                                }
                                subItem.MMCalculatorProductionNormItemProductDesc += subItem.MMCalculatorProductionNormItemProductInsideDimensionLength.ToString("n0").Trim()
                                    + "x" + subItem.MMCalculatorProductionNormItemProductInsideDimensionWidth.ToString("n0").Trim()
                                    + "x" + subItem.MMCalculatorProductionNormItemProductInsideDimensionHeight.ToString("n0").Trim();
                            }
                            if (!(subItem.MMCalculatorProductionNormItemProductOverallDimensionWidth == 0
                                && subItem.MMCalculatorProductionNormItemProductOverallDimensionLength == 0
                                && subItem.MMCalculatorProductionNormItemProductOverallDimensionHeight == 0))
                            {
                                if (!string.IsNullOrEmpty(subItem.MMCalculatorProductionNormItemProductDesc))
                                {
                                    subItem.MMCalculatorProductionNormItemProductDesc += ", ";
                                }
                                subItem.MMCalculatorProductionNormItemProductDesc += subItem.MMCalculatorProductionNormItemProductOverallDimensionLength.ToString("n0").Trim()
                                    + "x" + subItem.MMCalculatorProductionNormItemProductOverallDimensionWidth.ToString("n0").Trim()
                                    + "x" + subItem.MMCalculatorProductionNormItemProductOverallDimensionHeight.ToString("n0").Trim();
                            }
                            if (!string.IsNullOrEmpty(subItem.MMCalculatorProductionNormItemProductSizeAndPacking))
                            {
                                if (!string.IsNullOrEmpty(subItem.MMCalculatorProductionNormItemProductDesc))
                                {
                                    subItem.MMCalculatorProductionNormItemProductDesc += ", ";
                                }
                                subItem.MMCalculatorProductionNormItemProductDesc += subItem.MMCalculatorProductionNormItemProductSizeAndPacking.Trim();
                            }
                            if (subItem.FK_ICProdAttPackingMaterialSpecialityID > 0)
                            {
                                ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(subItem.FK_ICProdAttPackingMaterialSpecialityID);
                                if (objAttribute != null)
                                {
                                    if (!string.IsNullOrEmpty(subItem.MMCalculatorProductionNormItemProductDesc))
                                    {
                                        subItem.MMCalculatorProductionNormItemProductDesc += ", ";
                                    }
                                    subItem.MMCalculatorProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                                }
                            }
                            if (subItem.FK_ICProdAttPackingMaterialWeightPerVolumeID > 0)
                            {
                                ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(subItem.FK_ICProdAttPackingMaterialWeightPerVolumeID);
                                if (objAttribute != null)
                                {
                                    if (!string.IsNullOrEmpty(subItem.MMCalculatorProductionNormItemProductDesc))
                                    {
                                        subItem.MMCalculatorProductionNormItemProductDesc += ", ";
                                    }
                                    subItem.MMCalculatorProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                                }
                            }
                            if (subItem.FK_ICProdAttPackingMaterialSizeID > 0)
                            {

                                ICProductAttributesInfo objAttribute = (ICProductAttributesInfo)objDepartmentAttributeValuesController.GetObjectByID(subItem.FK_ICProdAttPackingMaterialSizeID);
                                if (objAttribute != null)
                                {
                                    if (!string.IsNullOrEmpty(subItem.MMCalculatorProductionNormItemProductDesc))
                                    {
                                        subItem.MMCalculatorProductionNormItemProductDesc += ", ";
                                    }
                                    subItem.MMCalculatorProductionNormItemProductDesc += objAttribute.ICProductAttributeValue.Trim();
                                }
                            }
                            if (!string.IsNullOrEmpty(subItem.MMCalculatorProductionNormItemComment))
                            {
                                if (!string.IsNullOrEmpty(subItem.MMCalculatorProductionNormItemProductDesc))
                                {
                                    subItem.MMCalculatorProductionNormItemProductDesc += ", ";
                                }
                                subItem.MMCalculatorProductionNormItemProductDesc += subItem.MMCalculatorProductionNormItemComment.Trim();
                            }
                        }
                    }
                }
                RefreshProductItemTreeListView(entity.IngredientPackagingList);
            }
        }

        public void RemoveSelectedItemFromProductionNormItemPackagingList()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            entity.IngredientPackagingList.RemoveSelectedRowObjectFromList();
            CalculateProductionNormItemPackaging(string.Empty);
        }

        public void AddPaint(int productID)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                AddItemToPaintItemsList(objProductsInfo);
            }
        }

        public void AddItemToPaintItemsList(ICProductsInfo productObject)
        {
            if (IsEditable())
                ActionEdit();
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            ICProductsController objProductsController = new ICProductsController();

            if (productObject != null)
            {
                MMCalculatorProductionNormItemsInfo objProductionNormItemsInfo = new MMCalculatorProductionNormItemsInfo();
                objProductionNormItemsInfo = SetValuePaintItemFromProduct(productObject);
                objProductionNormItemsInfo.MMCalculatorProductionNormItemGroup = ProductType.IngredientPaint.ToString();
                UpdateValuePaintItems(objProductionNormItemsInfo);
                entity.PaintList.Add(objProductionNormItemsInfo);
                RefreshProductItemTreeListView(entity.PaintList);
            }


        }
        public MMCalculatorProductionNormItemsInfo UpdateValuePaintItems(MMCalculatorProductionNormItemsInfo objPaintItemsInfo)
        {
            int productQuantity = 1;
            objPaintItemsInfo.MMCalculatorProductionNormItemTotalQuantity = objPaintItemsInfo.MMCalculatorProductionNormItemQuantity * productQuantity;
            objPaintItemsInfo.MMCalculatorProductionNormItemTotalQuantity = Math.Round(objPaintItemsInfo.MMCalculatorProductionNormItemTotalQuantity, 4, MidpointRounding.AwayFromZero);
            return objPaintItemsInfo;
        }
        public MMCalculatorProductionNormItemsInfo SetValuePaintItemFromProduct(ICProductsInfo objProductsInfo)
        {
            MMCalculatorProductionNormItemsInfo objPaintItemsInfo = new MMCalculatorProductionNormItemsInfo();
            MMCalculatorProductionNormItemsInfo objToGetPaintItemsInfo = new MMCalculatorProductionNormItemsInfo();
            APSuppliersController objSuppliersController = new APSuppliersController();
            APSuppliersInfo objSuppliersInfo = new APSuppliersInfo();
            objPaintItemsInfo.MMCalculatorProductionNormItemProductDesc = objProductsInfo.ICProductDesc;
            objPaintItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
            objPaintItemsInfo.FK_ICProductGroupID = objProductsInfo.FK_ICProductGroupID;
            objPaintItemsInfo.FK_ICDepartmentID = objProductsInfo.FK_ICDepartmentID;
            objPaintItemsInfo.MMCalculatorProductionNormItemProductName = objProductsInfo.ICProductName;
            objPaintItemsInfo.MMCalculatorProductionNormItemNo = objProductsInfo.ICProductNo;
            objPaintItemsInfo.MMCalculatorProductionNormItemProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
            objPaintItemsInfo.MMCalculatorProductionNormItemProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
            objPaintItemsInfo.MMCalculatorProductionNormItemNeededTime = DateTime.Now;

            //Get unit from Products
            ICMeasureUnitsController objMeasureUnitsController = new ICMeasureUnitsController();
            ICMeasureUnitsInfo objMeasureUnitsInfo = new ICMeasureUnitsInfo();
            objMeasureUnitsInfo = (ICMeasureUnitsInfo)objMeasureUnitsController.GetObjectByID(objProductsInfo.FK_ICProductBasicUnitID);
            if (objMeasureUnitsInfo != null)
            {
                objPaintItemsInfo.MMCalculatorProductionNormItemUnit = objMeasureUnitsInfo.ICMeasureUnitName;
                objPaintItemsInfo.FK_ICMeasureUnitID = objMeasureUnitsInfo.ICMeasureUnitID;
            }
            if (objPaintItemsInfo.SubList == null)
                objPaintItemsInfo.SubList = new BOSTreeList();
            return objPaintItemsInfo;
        }

        public void ChangeItemPaint()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMCalculatorProductionNormItemsInfo objPaintItemsInfo = (MMCalculatorProductionNormItemsInfo)entity.PaintList.CurrentObject;
            if (objPaintItemsInfo != null
                && objPaintItemsInfo.MMCalculatorProductionNormItemGroup != ProductType.IngredientPaint.ToString())
            {
                SetPaintQty(objPaintItemsInfo, objPaintItemsInfo.MMCalculatorProductionNormItemPaint);
                RefreshProductItemTreeListView(entity.PaintList);

                UpdateTotalCostPaint(true);
            }


        }
        public void SetPaintQty(MMCalculatorProductionNormItemsInfo objPaintItemsInfo, decimal newPaint)
        {
            objPaintItemsInfo.MMCalculatorProductionNormItemPaint = newPaint;
            objPaintItemsInfo.MMCalculatorProductionNormItemTotalQuantity = objPaintItemsInfo.MMCalculatorProductionNormItemPaint * objPaintItemsInfo.MMCalculatorProductionNormItemPaintPerOne;
            objPaintItemsInfo.MMCalculatorProductionNormItemQuantity = objPaintItemsInfo.MMCalculatorProductionNormItemPaint * objPaintItemsInfo.MMCalculatorProductionNormItemPaintPerOne;
            objPaintItemsInfo.MMCalculatorProductionNormItemTotalQuantity = Math.Round(objPaintItemsInfo.MMCalculatorProductionNormItemTotalQuantity, 4, MidpointRounding.AwayFromZero);
            objPaintItemsInfo.MMCalculatorProductionNormItemQuantity = Math.Round(objPaintItemsInfo.MMCalculatorProductionNormItemQuantity, 4, MidpointRounding.AwayFromZero);
            if (objPaintItemsInfo.SubList != null && objPaintItemsInfo.SubList.Count > 0)
            {
                foreach (MMCalculatorProductionNormItemsInfo item in objPaintItemsInfo.SubList)
                {
                    SetPaintQty(item, newPaint);
                }
            }
        }

        public void ChangeItemFromPaintItemsList()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMCalculatorProductionNormItemsInfo objPaintItemsInfo = (MMCalculatorProductionNormItemsInfo)entity.PaintList.CurrentObject;
            if (objPaintItemsInfo != null)
            {
                UpdateValuePaintItems(objPaintItemsInfo);
                CalculateProductionNormItemPaint();

                UpdateTotalCostPaint(true);
            }


        }

        public void CalculateProductionNormItemPaint()
        {
            #region Controller
            ICProductsController objProductsController = new ICProductsController();

            //Công diện tích sơn
            MMFormulaConfigurationsController objFormulasController = new MMFormulaConfigurationsController();
            #endregion
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            if (entity.PaintList != null && entity.PaintList.Count > 0)
            {
                decimal totalPaint = 0;
                foreach (MMCalculatorProductionNormItemsInfo item in entity.PaintList)
                {



                    #region Số lượng
                    item.MMCalculatorProductionNormItemTotalQuantity = item.MMCalculatorProductionNormItemQuantity;
                    //TNDLoc [ADD][19/05/2016][Round Paint 4],START
                    item.MMCalculatorProductionNormItemTotalQuantity = Math.Round(item.MMCalculatorProductionNormItemTotalQuantity, 4, MidpointRounding.AwayFromZero);
                    //TNDLoc [ADD][19/05/2016][Round Paint 4],END
                    #endregion

                    totalPaint += (item.MMCalculatorProductionNormItemPaintA + item.MMCalculatorProductionNormItemPaintB);

                    if (item.SubList != null && item.SubList.Count > 0)
                    {
                        foreach (MMCalculatorProductionNormItemsInfo subItem in entity.PaintList)
                        {
                            decimal surFaceSub = CalSurFace(subItem);
                            decimal longEdgeSub = CalLongEdge(subItem);
                            decimal shortEdgeSub = CalShortEdge(subItem);


                            #region Số lượng
                            subItem.MMCalculatorProductionNormItemTotalQuantity = subItem.MMCalculatorProductionNormItemQuantity;
                            //TNDLoc [ADD][19/05/2016][Round Paint 4],START
                            subItem.MMCalculatorProductionNormItemTotalQuantity = Math.Round(subItem.MMCalculatorProductionNormItemTotalQuantity, 4, MidpointRounding.AwayFromZero);
                            //TNDLoc [ADD][19/05/2016][Round Paint 4],END
                            #endregion

                            totalPaint += (subItem.MMCalculatorProductionNormItemPaintA + subItem.MMCalculatorProductionNormItemPaintB);
                        }
                    }
                }


            }
        }
        public decimal CalSurFace(MMCalculatorProductionNormItemsInfo item)
        {
            return item.MMCalculatorProductionNormItemProductWidth * item.MMCalculatorProductionNormItemProductLength;
        }
        public decimal CalLongEdge(MMCalculatorProductionNormItemsInfo item)
        {
            return item.MMCalculatorProductionNormItemProductHeight * item.MMCalculatorProductionNormItemProductLength;
        }
        public decimal CalShortEdge(MMCalculatorProductionNormItemsInfo item)
        {
            return item.MMCalculatorProductionNormItemProductHeight * item.MMCalculatorProductionNormItemProductWidth;
        }

        public void RemoveSelectedItemFromProductionNormItemPaintList()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            if (entity.PaintList.TreeListControl != null)
            {
                DevExpress.XtraTreeList.Nodes.TreeListNode currentNode = entity.PaintList.TreeListControl.GetSelectedNode();
                if (currentNode != null)
                {
                    if (currentNode.Level == 0)
                        entity.PaintList.TreeListControl.Nodes.Remove(currentNode);
                    else
                        currentNode.ParentNode.Nodes.Remove(currentNode);
                }
                entity.PaintList.TreeListControl.RefreshDataSource();
                CalculateProductionNormItemPaint();
                UpdateTotalCostPaint(true);
            }

        }

        public bool IsPaintProcessNode()
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMCalculatorProductionNormItemsInfo objPaintItemsInfo = (MMCalculatorProductionNormItemsInfo)entity.PaintList.CurrentObject;
            if (objPaintItemsInfo != null && objPaintItemsInfo.MMCalculatorProductionNormItemGroup != ProductType.IngredientPaint.ToString())
            {
                return true;
            }
            return false;
        }

        public DataTable GetAPSupplier()
        {
            APSuppliersController objSuppliersController = new APSuppliersController();
            DataSet ds = objSuppliersController.GetAllObjects();
            DataTable dt = new DataTable();
            if (ds != null)
                dt = ds.Tables[0];
            return dt;
        }

        public void GetItemMaterialUnitCost(MMCalculatorProductionNormItemMaterialsInfo item)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMCalculatorProductionNormCostsInfo mainObject = (MMCalculatorProductionNormCostsInfo)entity.MainObject;

            ICReceiptItemsController receiptItemCtrl = new ICReceiptItemsController();
            decimal unitCost = receiptItemCtrl.GetMaterialUnitCostByProductIDAndQualityIDAndEffetiveDate(item.FK_ICProductMaterialID, item.FK_ICProductAttributeQualityID, mainObject.MMCalculatorProductionNormCostDate);

            item.MMCalculatorProductionNormItemMaterialUnitCost = unitCost;
            item.MMCalculatorProductionNormItemMaterialTotalCost =
                item.MMCalculatorProductionNormItemMaterialUnitCost * item.MMCalculatorProductionNormItemMaterialDepreciationQty;
        }

        public List<ICProductAttributesInfo> GetProductItemAttributeQuality()
        {
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.Quality.ToString());
            if (productAttributesList != null)
            {
                return productAttributesList;
            }
            else
                return null;
        }
        public void ChangeCustomer(int customerID)
        {
            CalculatorProductionNormCostEntities entity = (CalculatorProductionNormCostEntities)CurrentModuleEntity;
            MMCalculatorProductionNormCostsInfo mainObject = (MMCalculatorProductionNormCostsInfo)entity.MainObject;
            ARCustomersController objCustomersController = new ARCustomersController();
            ICProductCustomersController objProductCustomersController = new ICProductCustomersController();
            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(customerID);
            if (objCustomersInfo != null)
            {
                mainObject.ARCustomerType = objCustomersInfo.ARCustomerTypeCombo;
                mainObject.FK_ARCustomerID = objCustomersInfo.ARCustomerID;
            }
            else
            {
                mainObject.FK_ARCustomerID = 0;
            }
            if (CustomerTypeLookupEdit != null)
            {
                if (mainObject.FK_ARCustomerID > 0)
                {
                    CustomerTypeLookupEdit.Properties.ReadOnly = true;
                }
                else
                {
                    CustomerTypeLookupEdit.Properties.ReadOnly = false;
                }
            }
            entity.UpdateMainObjectBindingSource();
        }
    }
}
